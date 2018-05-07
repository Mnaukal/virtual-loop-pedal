using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace VirtualLoopPedal
{
    public partial class Metronome : UserControl
    {
        Timer timer;
        bool running;
        int BPM; // beats per minute
        int BPB; // beats per bar
        int currentBeat; // current beat in bar
        int currentBar; // number of bars since start of metronome

        ISampleProvider firstBeatGen, otherBeatGen; // beats in bar
        VolumeSampleProvider firstBeatVol, otherBeatVol;

        public bool MakeSound = true;
        private Pedal parent;

        /// <summary>
        /// Fires on every beat
        /// </summary>
        public event EventHandler<MetronomeEventArgs> Beat;
        /// <summary>
        /// Fires on start of each bar (measure)
        /// </summary>
        public event EventHandler<MetronomeEventArgs> Bar;
        /// <summary>
        /// Fires when metronome stops
        /// </summary>
        public event EventHandler<MetronomeEventArgs> Stopped;
        /// <summary>
        /// Fires when metronome starts
        /// </summary>
        public event EventHandler<MetronomeEventArgs> Started;

        public Metronome()
        {
            InitializeComponent();

            this.Load += Metronome_Load;
        }

        public void Metronome_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Tick += Timer_Tick;

            BPM = Convert.ToInt32(numericUpDown_metronomeTempo.Value);
            BPB = Convert.ToInt32(numericUpDown_metronomeMeasuse.Value);

            firstBeatGen = new SignalGenerator(parent.waveFormat.SampleRate, parent.waveFormat.Channels)
            {
                Gain = 1,
                Frequency = 660,
                Type = SignalGeneratorType.Sin,
            };

            otherBeatGen = new SignalGenerator(parent.waveFormat.SampleRate, parent.waveFormat.Channels)
            {
                Gain = 1,
                Frequency = 440,
                Type = SignalGeneratorType.Sin
            };

            firstBeatVol = new VolumeSampleProvider(firstBeatGen);
            firstBeatVol.Volume = 0;
            otherBeatVol = new VolumeSampleProvider(otherBeatGen);
            otherBeatVol.Volume = 0;

            if (parent != null)
            {
                parent.GetRecorder().AddTrackNoOffset(firstBeatVol);
                parent.GetRecorder().AddTrackNoOffset(otherBeatVol);
            }
        }

        public void SetParent(Pedal parent)
        {
            this.parent = parent;
        }

        public MetronomeEventArgs MetronomeInfo()
        {
            return new MetronomeEventArgs()
            {
                BeatNumber = currentBeat,
                BarNumber = currentBar,
                BeatsInBar = BPB,
            };
        }

        protected virtual void OnBeat(MetronomeEventArgs e)
        {
            //Console.WriteLine(currentBar + "/" + currentBeat);
            label_beat.Text = (e.BeatNumber + 1).ToString() + "/" + numericUpDown_metronomeMeasuse.Value.ToString();
            Beat?.Invoke(this, e);
        }

        protected virtual void OnBar(MetronomeEventArgs e)
        {
            label_bar.Text = e.BarNumber.ToString();
            Bar?.Invoke(this, e);
        }

        protected virtual void OnStopped(MetronomeEventArgs e)
        {
            Stopped?.Invoke(this, e);
        }

        protected virtual void OnStarted(MetronomeEventArgs e)
        {
            Started?.Invoke(this, e);
        }

        private void button_metronomeStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void button_metronomeStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void numericUpDown_metronomeMeasure_ValueChanged(object sender, EventArgs e)
        {
            ChangeBeatsPerBar(Convert.ToInt32((sender as NumericUpDown).Value));
        }

        private void numericUpDown_metronomeTempo_ValueChanged(object sender, EventArgs e)
        {
            ChangeTempo(Convert.ToInt32((sender as NumericUpDown).Value));
        }

        private void checkBox_metronome_CheckedChanged(object sender, EventArgs e)
        {
            MakeSound = (sender as CheckBox).Checked;
        }

        public void Start()
        {
            currentBeat = 0;
            currentBar = 1;
            timer.Interval = 60000 / BPM;
            timer.Start();
            running = true;
            OnStarted(new MetronomeEventArgs());

            numericUpDown_metronomeTempo.Enabled = false;
            numericUpDown_metronomeMeasuse.Enabled = false;
        }

        public void ChangeTempo(int Tempo)
        {
            BPM = Tempo;
        }

        public void ChangeBeatsPerBar(int BeatsPerBar)
        {
            BPB = BeatsPerBar;
        }

        public void Stop()
        {
            timer.Stop();
            running = false;
            OnStopped(new MetronomeEventArgs());

            numericUpDown_metronomeTempo.Enabled = true;
            numericUpDown_metronomeMeasuse.Enabled = true;
        }

        public void EmergencyStop()
        {
            firstBeatVol.Volume = 0;
            otherBeatVol.Volume = 0;
            Stop();
        }

        public void StartOrStop()
        {
            if (running)
                Stop();
            else
                Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine(currentBeat);
            if (currentBeat == 0)
                OnBar(new MetronomeEventArgs() { BarNumber = currentBar });
            OnBeat(new MetronomeEventArgs() { BeatNumber = currentBeat, BarNumber = currentBar, BeatsInBar = BPB });

            if (MakeSound)
            {
                int offset = Convert.ToInt32(numericUpDown_offset.Value);
                while(offset < 0)
                {
                    offset += Convert.ToInt32(60 * 1000 * numericUpDown_metronomeMeasuse.Value / numericUpDown_metronomeTempo.Value);
                }

                if (currentBeat == 0)
                    Task.Delay(offset).ContinueWith(s =>
                    {
                        firstBeatVol.Volume = 1;
                    });
                else
                    Task.Delay(offset).ContinueWith(s =>
                    {
                        otherBeatVol.Volume = 1;
                    });

                Task.Delay(offset + 100).ContinueWith(t =>
                {
                    firstBeatVol.Volume = 0;
                    otherBeatVol.Volume = 0;
                });
            }

            currentBeat++;
            if (currentBeat >= BPB)
            {
                currentBeat = 0;
                currentBar++;
            }
        }
    }

    public class MetronomeEventArgs : EventArgs
    {
        public int BarNumber, BeatNumber, BeatsInBar;
    }
}
