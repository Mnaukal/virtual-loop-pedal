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
        Metronome metronome;

        public Pedal()
        {
            InitializeComponent();
            metronome = new Metronome(Convert.ToInt32(numericUpDown_metronomeTempo.Value), Convert.ToInt32(numericUpDown_metronomeMeasuse.Value));
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
    }

    class Metronome
    {
        Timer timer;
        bool running;
        int BPM; // beats per minute
        int BPB; // beats per bar
        int currentBeat; // current beat in bar

        ISampleProvider first, other; // beats in bar
        WaveOutEvent First, Other;
        
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

        public void Start()
        {
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
            currentBeat = 0;
            running = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine(currentBeat);
            if (currentBeat == 0)
                First.Play();
            else
                Other.Play();

            //System.Threading.Thread.Sleep(100);

            Task.Delay(100).ContinueWith(t =>
            {
                First.Pause();
                Other.Pause();
            });

            currentBeat++;
            if (currentBeat >= BPB)
                currentBeat = 0;
        }
    }

}
