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
using NAudio.CoreAudioApi;

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

            try
            {
                if (parent.settings.SelectedDriver == Driver.ASIO)
                    throw new NotImplementedException("ASIO driver is not implemented.");
                else if (parent.settings.SelectedDriver == Driver.Wasapi)
                    InitializePlayerWasapi();
                else
                    InitializePlayerWave();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nTry to select different audio device or sample rate.", "Error starting playback.");
                parent.button_settings_Click(this, new EventArgs());
            }
        }

        public void Reset()
        {
            player?.Dispose();
            player = null;
            recorder?.Dispose();
            recorder = null;

            Recorder_Load(this, new EventArgs());
        }

        void InitializePlayerWave()
        {            
            recorder = new WaveInEvent() { DeviceNumber = parent.settings.WaveInDeviceNumber, WaveFormat = parent.waveFormat, BufferMilliseconds = parent.settings.BufferSize };
            player = new WaveOutEvent() {
                DeviceNumber = parent.settings.WaveOutDeviceNumber,
                DesiredLatency = parent.settings.DesiredLatency
            };

            recorder.DataAvailable += Recorder_DataAvailable;

            player.Init(mixer);
            player.Play();

            recorder.StartRecording();            
        }

        void InitializePlayerWasapi()
        {
            player = new WasapiOut(parent.settings.WasapiOutDevice, parent.settings.ShareMode, true, parent.settings.DesiredLatency);
            recorder = new WasapiCapture(parent.settings.WasapiInDevice, true, parent.settings.BufferSize)
            {
                WaveFormat = parent.waveFormat,
                ShareMode = parent.settings.ShareMode
            };

            recorder.DataAvailable += Recorder_DataAvailable;

            player.Init(mixer);
            player.Play();

            recorder.StartRecording();
        }

        public void SetParent(Pedal parent)
        {
            this.parent = parent;
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            player?.Stop();
            player?.Dispose();
            recorder?.StopRecording();
            recorder?.Dispose();

            base.OnHandleDestroyed(e);
        }

        private void Notifier_StreamVolume(object sender, StreamVolumeEventArgs e)
        {
            volumeMeter.Amplitude = e.MaxSampleValues[0];
        }

        private void Recorder_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (listen)
                buffer.AddSamples(e.Buffer, 0, e.BytesRecorded);

            OnWrite(e); // connection to Loopers
        }

        private void checkBox_playback_CheckedChanged(object sender, EventArgs e)
        {
            listen = checkBox_playback.Checked;
        }

        public void DisableListen()
        {
            checkBox_playback.Checked = false;
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
                //Console.WriteLine("addind " + provider.ToString());
                mixer.AddMixerInput(provider);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show("File not recorded using Virtual Loop Pedal or recorded with different settings.", "Wrong file format");
            }
        }

        public void RemoveTrack(ISampleProvider provider)
        {
            //Console.WriteLine("removing " + provider?.ToString());
            mixer.RemoveMixerInput(provider);
        }
    }
}
