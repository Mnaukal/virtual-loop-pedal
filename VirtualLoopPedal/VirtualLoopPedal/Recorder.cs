using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave.SampleProviders;
using NAudio.Wave;

namespace VirtualLoopPedal
{
    public partial class Recorder : UserControl
    {
        MixingSampleProvider mixer;
        IWaveIn recorder;
        BufferedWaveProvider buffer;
        MeteringSampleProvider meter;
        IWavePlayer player;

        bool listen = false;
        private Pedal parent;

        public event EventHandler<WaveInEventArgs> Write;

        public event EventHandler<SampleProviderEventArgs> MixerInputEnded
        {
            add { mixer.MixerInputEnded += value; }
            remove { mixer.MixerInputEnded -= value; }
        }

        public Recorder()
        {
            InitializeComponent();

            this.Load += Recorder_Load;
        }

        protected virtual void OnWrite(WaveInEventArgs e)
        {
            Write?.Invoke(this, e);
        }

        void Recorder_Load(object sender, EventArgs e)
        {
            if (parent == null)
                return;

            buffer = new BufferedWaveProvider(parent.waveFormat);
            mixer = new MixingSampleProvider(parent.waveFormat);

            meter = new MeteringSampleProvider(buffer.ToSampleProvider());
            meter.StreamVolume += Notifier_StreamVolume;

            mixer.ReadFully = true;
            mixer.AddMixerInput(meter);

            InitializePlayer();
        }

        public void Reset()
        {
            player?.Dispose();
            player = null;
            recorder?.Dispose();
            recorder = null;

            Recorder_Load(this, new EventArgs());
        }

        void InitializePlayer()
        {
            recorder = new WaveInEvent() { DeviceNumber = parent.WaveInDeviceNumber, WaveFormat = parent.waveFormat };
            WaveOutEvent playerWave = new WaveOutEvent() { DeviceNumber = parent.WaveOutDeviceNumber };
            player = playerWave;

            recorder.DataAvailable += Recorder_DataAvailable;
            recorder.RecordingStopped += Recorder_RecordingStopped;
            player.PlaybackStopped += Player_PlaybackStopped;

            playerWave.DesiredLatency = parent.DesiredLatency;
            player.Init(mixer);
            player.Play();

            recorder.StartRecording();
        }

        public void SetParent(Pedal parent)
        {
            this.parent = parent;
        }

        private void Notifier_StreamVolume(object sender, StreamVolumeEventArgs e)
        {
            volumeMeter.Amplitude = e.MaxSampleValues[0];
        }

        private void Player_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            // TODO: nothing?
            //throw new NotImplementedException();
        }

        private void Recorder_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (listen)
                buffer.AddSamples(e.Buffer, 0, e.BytesRecorded);

            OnWrite(e); // connection to Loopers
        }

        private void Recorder_RecordingStopped(object sender, StoppedEventArgs e)
        {
            //throw new NotImplementedException();
            //recorder.Dispose();
        }

        private void checkBox_playback_CheckedChanged(object sender, EventArgs e)
        {
            listen = checkBox_playback.Checked;
        }

        public void AddTrack(OffsetSampleProvider provider)
        {
            provider.DelayBy = TimeSpan.FromMilliseconds(Convert.ToDouble(numericUpDown_offset.Value));
            AddTrackNoOffset(provider);
        }

        public void AddTrackNoOffset(ISampleProvider provider)
        {
            try
            {
                Console.WriteLine("addind " + provider.ToString());
                mixer.AddMixerInput(provider);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show("File not recorded using Virtual Loop Pedal or recorded with different settings.", "Wrong file format");
            }
        }

        public void RemoveTrack(ISampleProvider provider)
        {
            Console.WriteLine("removing " + provider?.ToString());
            mixer.RemoveMixerInput(provider);
        }
    }
}
