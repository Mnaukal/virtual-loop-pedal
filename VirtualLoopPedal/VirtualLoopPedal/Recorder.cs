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
        public int DesiredLatency
        {
            get { return desiredLatency; }
            set
            {
                desiredLatency = value;
                if (player != null)
                    player.DesiredLatency = desiredLatency;
            }
        }
        private int desiredLatency = 100;

        MixingSampleProvider mixer;
        WaveInEvent recorder;
        BufferedWaveProvider buffer;
        MeteringSampleProvider meter;
        WaveOutEvent player;

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

        private void Recorder_Load(object sender, EventArgs e)
        {
            recorder = new WaveInEvent();
            recorder.DataAvailable += Recorder_DataAvailable;
            recorder.RecordingStopped += Recorder_RecordingStopped;
            recorder.WaveFormat = parent.waveFormat;

            player = new WaveOutEvent();
            player.PlaybackStopped += Player_PlaybackStopped;
            player.DesiredLatency = DesiredLatency;

            buffer = new BufferedWaveProvider(recorder.WaveFormat);
            mixer = new MixingSampleProvider(recorder.WaveFormat);

            meter = new MeteringSampleProvider(buffer.ToSampleProvider());
            meter.StreamVolume += Notifier_StreamVolume;

            mixer.ReadFully = true;
            mixer.AddMixerInput(meter);
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
            mixer.AddMixerInput(provider);
        }

        public void RemoveTrack(ISampleProvider provider)
        {
            mixer.RemoveMixerInput(provider);
        }

        private void numericUpDown_latency_ValueChanged(object sender, EventArgs e)
        {
            DesiredLatency = Convert.ToInt32(numericUpDown_latency.Value);
        }
    }
}
