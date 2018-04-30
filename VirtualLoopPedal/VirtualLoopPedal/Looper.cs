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
using System.IO;

namespace VirtualLoopPedal
{
    public partial class Looper : UserControl
    {
        [Description("Name of file to save the recording in.")]
        public string FileName = "tmp.wav";

        [Description("Desired latency of audio player.")]
        public int DesiredLatency
        {
            get { return desiredLatency; }
            set
            {
                desiredLatency = value;
                if (playerBack != null)
                    playerBack.DesiredLatency = desiredLatency;
                /*if (player != null)
                    player.DesiredLatency = desiredLatency;*/
            }
        }
        private int desiredLatency = 100;

        [Description("Selected Looper")]
        public bool Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                if (selected)
                    groupBox1.BackColor = SelectedColor;
                else
                    groupBox1.BackColor = SystemColors.Control;
            }
        }
        private bool selected = false;

        [Description("Desired latency of audio player.")]
        public Color SelectedColor = Color.Honeydew;

        WaveInEvent recorder;
        WaveFileWriter writer;
        BufferedWaveProvider bufferedWaveProvider;
        WaveOutEvent playerBack; // to play back while recording
        bool playBackWhileRecording = false;
        bool closing = false;

        WaveOutEvent player;
        AudioFileReader reader;

        enum State { Waiting, WantToRecord, ReadyToRecord, Recording, ReadyToPlay, Playing };

        State state_value = State.Waiting;
        State state
        {
            get { return state_value; }
            set
            {
                state_value = value;

                switch(value)
                {
                    case State.ReadyToRecord:
                    case State.ReadyToPlay:
                        label_state.Text = "Waiting";
                        break;
                    case State.Recording:
                        label_state.Text = "Recording";
                        break;
                    case State.Playing:
                        label_state.Text = "Playing";
                        break;
                }
            }
        }
        int StartingBar; // starting bar of current recording / playing
        
        public Looper()
        {
            InitializeComponent();

            recorder = new WaveInEvent();
            recorder.DataAvailable += Recorder_DataAvailable;
            recorder.RecordingStopped += Recorder_RecordingStopped;

            player = new WaveOutEvent();
            player.PlaybackStopped += Player_PlaybackStopped;
            //player.DesiredLatency = DesiredLatency;

            playerBack = new WaveOutEvent();
            playerBack.PlaybackStopped += PlayerBack_PlaybackStopped;
            playerBack.DesiredLatency = DesiredLatency;

            bufferedWaveProvider = new BufferedWaveProvider(recorder.WaveFormat);

            WireClickOfChildren(this);
        }

        void WireClickOfChildren(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Click += control_Click;
                if (control.HasChildren)
                    WireClickOfChildren(control);
            }
        }

        public void SetName(string name)
        {
            this.Name = name;
            groupBox1.Text = this.Name;
        }

        private void control_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, e);
        }

        private void PlayerBack_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            
        }

        private void Player_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            //player.Dispose();
            //player = null;
            reader?.Dispose();
            reader = null;

            button_play.Enabled = true; // TODO ??
            button_StopPlayback.Enabled = false;

            if (state == State.WantToRecord)
                state = State.ReadyToRecord;
        }

        private void Recorder_RecordingStopped(object sender, StoppedEventArgs e)
        {
            writer?.Dispose();
            writer = null;
            button_record.Enabled = true;
            button_StopRecording.Enabled = false;
            if (closing)
            {
                recorder.Dispose();
            }
        }

        private void Recorder_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (playBackWhileRecording)
            {
                bufferedWaveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
            }

            writer.Write(e.Buffer, 0, e.BytesRecorded);

            if (writer.Position > recorder.WaveFormat.AverageBytesPerSecond * 30) // automatically stop recording after 30 seconds
            {
                recorder.StopRecording();
            }            
        }

        private void button_record_Click(object sender, EventArgs e)
        {
            if (state == State.Playing) // playing must finish before we can start recording
                state = State.WantToRecord;
            else
                state = State.ReadyToRecord;

            button_record.Enabled = false;
            button_StopRecording.Enabled = true;
            button_play.Enabled = false;
            numericUpDown_length.Enabled = false;
            numericUpDown_start.Enabled = false;
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            state = State.ReadyToPlay;

            button_play.Enabled = false;
            button_StopPlayback.Enabled = true;
            //button_record.Enabled = false;
        }

        private void button_StopRecording_Click(object sender, EventArgs e)
        {
            StopRecording();
        }

        private void button_StopPlayback_Click(object sender, EventArgs e)
        {
            StopPlayback();
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            closing = true;
            recorder.StopRecording();
            player.Stop();

            base.OnHandleDestroyed(e);
        }

        private void trackBar_Volume_Scroll(object sender, EventArgs e)
        {
            if (reader != null)
                reader.Volume = trackBar_Volume.Value / 100f;

            //player.Volume = trackBar_Volume.Value / 100f; 
        }

        void StartRecording()
        {
            state = State.Recording;

            playBackWhileRecording = checkBox_playBack.Checked;
            Directory.CreateDirectory("data\\" + this.Name);

            if (checkBox_playBack.Checked)
            {
                playerBack.Init(bufferedWaveProvider);
                playerBack.Play();
            }

            writer = new WaveFileWriter("data\\" + this.Name + "\\" + FileName, recorder.WaveFormat); // TODO: can't record at the same time as playing (using same file)
            recorder.StartRecording();
        }

        void StopRecording()
        {
            state = State.Waiting; // TODO: option to automatically start playing

            recorder.StopRecording();
            if (playBackWhileRecording)
                playerBack.Stop();

            button_record.Enabled = true;
            button_StopRecording.Enabled = false;
            button_play.Enabled = true;
            numericUpDown_length.Enabled = true;
            numericUpDown_start.Enabled = true;
        }

        void StartPlayback()
        {
            state = State.Playing;

            if (File.Exists("data\\" + this.Name + "\\" + FileName))
            {
                reader = new AudioFileReader("data\\" + this.Name + "\\" + FileName);
                reader.Volume = trackBar_Volume.Value / 100f;
                player.Init(reader);
                player.Play();
            }
            else
            {
                MessageBox.Show("You must first record the audio.", "File doesn't exist");
            }
        }

        void StopPlayback()
        {
            state = State.Waiting;

            player?.Stop();
        }

        /// <summary>
        /// Wire this to base metronome
        /// </summary>
        public void Metronome_Bar(object sender, MetronomeEventArgs e) 
        {
            if(selected)
                Console.WriteLine(state + " " + e.BarNumber);

            int length = Convert.ToInt32(numericUpDown_length.Value);
            int start = Convert.ToInt32(numericUpDown_start.Value);

            switch (state) // TODO if/else -> multiple changes per bar
            {
                case State.ReadyToRecord:
                    if(e.BarNumber % start == 0)
                    {
                        StartingBar = e.BarNumber;
                        StartRecording();
                        coloredProgressBar_record.Value = 1;
                    }
                    break;
                case State.ReadyToPlay:
                    if (e.BarNumber % start == 0)
                    {
                        StartingBar = e.BarNumber;
                        StartPlayback();
                        coloredProgressBar_record.Value = 1;
                    }
                    break;
                case State.Recording:
                    if (e.BarNumber >= StartingBar + length)
                    {
                        StopRecording();
                        coloredProgressBar_record.Value = 0;
                    }
                    break;
                case State.Playing:
                    if (e.BarNumber >= StartingBar + length)
                    {
                        StopPlayback();
                        StartingBar = e.BarNumber;
                        StartPlayback();
                        coloredProgressBar_record.Value = 1;
                    }
                    break;
            }
        }

        public void Metronome_Beat(object sender, MetronomeEventArgs e)
        {
            int length = Convert.ToInt32(numericUpDown_length.Value);
            int start = Convert.ToInt32(numericUpDown_start.Value);

            int lengthBeats = length * e.BeatsInBar;
            int currentBeat = e.BarNumber * e.BeatsInBar + e.BeatNumber;
            int startBeats = start * e.BeatsInBar;

            switch (state)
            {
                case State.ReadyToRecord:
                    coloredProgressBar_record.Maximum = startBeats;
                    coloredProgressBar_record.Value = (currentBeat % startBeats) + 1;
                    coloredProgressBar_record.ForeColor = Color.Blue;
                    break;
                case State.ReadyToPlay:
                    coloredProgressBar_record.Maximum = startBeats;
                    coloredProgressBar_record.Value = (currentBeat % startBeats) + 1;
                    coloredProgressBar_record.ForeColor = Color.Blue;
                    break;
                case State.Recording:
                    coloredProgressBar_record.Maximum = lengthBeats;
                    coloredProgressBar_record.Value = (((e.BarNumber - StartingBar) * e.BeatsInBar + e.BeatNumber) % lengthBeats) + 1;
                    coloredProgressBar_record.ForeColor = Color.Red;
                    break;
                case State.Playing:
                    coloredProgressBar_record.Maximum = lengthBeats;
                    coloredProgressBar_record.Value = (((e.BarNumber - StartingBar) * e.BeatsInBar + e.BeatNumber) % lengthBeats) + 1;
                    coloredProgressBar_record.ForeColor = Color.Green;
                    break;
            }
        }
    }
}
