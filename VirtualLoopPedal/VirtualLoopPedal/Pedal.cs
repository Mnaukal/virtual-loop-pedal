using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace VirtualLoopPedal
{
    public partial class Pedal : Form
    {
        public Metronome metronome;
        List<Looper> loopers;
        Looper selectedLooper = null;
        int looperCount = 0;

        public Pedal()
        {
            InitializeComponent();
            metronome = new Metronome(Convert.ToInt32(numericUpDown_metronomeTempo.Value), Convert.ToInt32(numericUpDown_metronomeMeasuse.Value));

            metronome.Bar += Metronome_Bar;
            metronome.Beat += Metronome_Beat;

            loopers = new List<Looper>();
            AddLooper(looper1);
            AddLooper(looper2);
            AddLooper(looper3);
            AddLooper(looper4);
        }

        void AddLooper(Looper looper)
        {
            loopers.Add(looper);
            looper.SetName("Looper " + ++looperCount);
            looper.Click += looper_Click;
            looper.SetParent(this);
            metronome.Bar += looper.Metronome_Bar;
            metronome.Beat += looper.Metronome_Beat;
        }

        private void Metronome_Beat(object sender, MetronomeEventArgs e)
        {
            label_beat.Text = (e.BeatNumber + 1).ToString() + "/" + numericUpDown_metronomeMeasuse.Value.ToString();
        }

        private void Metronome_Bar(object sender, MetronomeEventArgs e)
        {
            label_bar.Text = e.BarNumber.ToString();
        }

        private void button_metronomeStart_Click(object sender, EventArgs e)
        {
            metronome.Start();
        }

        private void button_metronomeStop_Click(object sender, EventArgs e)
        {
            metronome.Stop();
        }

        private void numericUpDown_metronomeMeasure_ValueChanged(object sender, EventArgs e)
        {
            metronome.ChangeBeatsPerBar(Convert.ToInt32((sender as NumericUpDown).Value));
        }

        private void numericUpDown_metronomeTempo_ValueChanged(object sender, EventArgs e)
        {
            metronome.ChangeTempo(Convert.ToInt32((sender as NumericUpDown).Value));
        }

        private void checkBox_metronome_CheckedChanged(object sender, EventArgs e)
        {
            metronome.MakeSound = (sender as CheckBox).Checked;
        }

        /// <summary>
        /// Select Looper
        /// </summary>
        private void looper_Click(object sender, EventArgs e)
        {
            Looper l = sender as Looper;
            DeselectAllLoopers();
            l.Selected = true;
            selectedLooper = l;
        }

        private void DeselectAllLoopers()
        {
            foreach (Looper l in loopers)
                l.Selected = false;
        }

        private void button_addLooper_Click(object sender, EventArgs e)
        {
            Looper l = new Looper();
            flowLayoutPanel1.Controls.Add(l);
            AddLooper(l);
        }

        private void button_deleteLooper_Click(object sender, EventArgs e)
        {
            loopers.Remove(selectedLooper);
            selectedLooper?.Dispose();
            selectedLooper = null;
        }
    }

    public class Metronome
    {
        Timer timer;
        bool running;
        int BPM; // beats per minute
        int BPB; // beats per bar
        int currentBeat; // current beat in bar
        int currentBar; // number of bars since start of metronome

        ISampleProvider first, other; // beats in bar
        WaveOutEvent First, Other;

        public bool MakeSound = true;

        /// <summary>
        /// Fires on every beat
        /// </summary>
        public event EventHandler<MetronomeEventArgs> Beat;
        /// <summary>
        /// Fires on start of each bar (measure)
        /// </summary>
        public event EventHandler<MetronomeEventArgs> Bar;
        
        public Metronome(int Tempo, int BeatsPerBar)
        {
            timer = new Timer();
            timer.Tick += Timer_Tick;

            BPM = Tempo;
            BPB = BeatsPerBar;

            first = new SignalGenerator()
            {
                Gain = 0.2,
                Frequency = 660,
                Type = SignalGeneratorType.Sin
            };//.Take(TimeSpan.FromMilliseconds(100));

            other = new SignalGenerator()
            {
                Gain = 0.2,
                Frequency = 440,
                Type = SignalGeneratorType.Sin
            };//.Take(TimeSpan.FromMilliseconds(100));

            First = new WaveOutEvent();
            First.Init(first);
            First.Volume = 1;
            Other = new WaveOutEvent();
            Other.Init(other);
            Other.Volume = 1;
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
            Beat?.Invoke(this, e);
        }

        protected virtual void OnBar(MetronomeEventArgs e)
        {
            Bar?.Invoke(this, e);
        }

        public void Start()
        {
            currentBeat = 0;
            currentBar = 1;
            timer.Interval = 60000 / BPM;
            timer.Start();
            running = true;
        }

        public void ChangeTempo(int Tempo)
        {
            BPM = Tempo;
            if(running)
                Start();
        }

        public void ChangeBeatsPerBar(int BeatsPerBar)
        {
            BPB = BeatsPerBar;
            if (running)
                Start();
        }

        public void Stop()
        {
            timer.Stop();
            running = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine(currentBeat);

            OnBeat(new MetronomeEventArgs() { BeatNumber = currentBeat, BarNumber = currentBar, BeatsInBar = BPB } ); // maybe move after OnBar

            if (MakeSound)
            {
                if (currentBeat == 0)
                {
                    First.Play();
                    OnBar(new MetronomeEventArgs() { BarNumber = currentBar });
                }
                else
                    Other.Play();

                Task.Delay(100).ContinueWith(t =>
                {
                    First.Pause();
                    Other.Pause();
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
