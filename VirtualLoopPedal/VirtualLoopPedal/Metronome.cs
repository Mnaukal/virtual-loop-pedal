using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualLoopPedal
{
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
        /// <summary>
        /// Fires when metronome stops
        /// </summary>
        public event EventHandler<MetronomeEventArgs> Stopped;
        /// <summary>
        /// Fires when metronome starts
        /// </summary>
        public event EventHandler<MetronomeEventArgs> Started;

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

        protected virtual void OnStopped(MetronomeEventArgs e)
        {
            Stopped?.Invoke(this, e);
        }

        protected virtual void OnStarted(MetronomeEventArgs e)
        {
            Started?.Invoke(this, e);
        }

        public void Start()
        {
            currentBeat = 0;
            currentBar = 1;
            timer.Interval = 60000 / BPM;
            timer.Start();
            running = true;
            OnStarted(new MetronomeEventArgs());
        }

        public void ChangeTempo(int Tempo)
        {
            BPM = Tempo;
            if (running)
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
            OnStopped(new MetronomeEventArgs());
        }

        public void EmergencyStop()
        {
            First.Pause();
            Other.Pause();
            Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine(currentBeat);

            OnBeat(new MetronomeEventArgs() { BeatNumber = currentBeat, BarNumber = currentBar, BeatsInBar = BPB }); // maybe move after OnBar

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
