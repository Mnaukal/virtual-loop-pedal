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
using NAudio.Wave.SampleProviders;

namespace VirtualLoopPedal
{
    public partial class Looper : UserControl
    {
        [Description("Name of file to save the recording in.")]
        public string FileName = "tmp.wav";

        [Description("Is Looper selected")]
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

        [Description("Background color if Looper is selected.")]
        public Color SelectedColor = Color.Honeydew;

        WaveFileWriter writer;
        AudioFileReader reader1, reader2; // 2 are needed for smoother looping
        OffsetSampleProvider sampleProvider1, sampleProvider2;
        
        enum LooperState { Waiting, ReadyToRecord, Recording, ReadyToPlay, Playing };

        LooperState state_value = LooperState.Waiting;
        LooperState State
        {
            get { return state_value; }
            set
            {
                state_value = value;

                switch(value)
                {
                    case LooperState.ReadyToRecord:
                    case LooperState.ReadyToPlay:
                        label_state.Text = "Waiting";
                        ResetProgressBar(Color.Blue, parent.GetMetronome().MetronomeInfo().BeatsInBar * Convert.ToInt32(numericUpDown_start.Value));
                        coloredProgressBar_record.Value = 1;
                        break;
                    case LooperState.Recording:
                        label_state.Text = "Recording";
                        ResetProgressBar(Color.Red, parent.GetMetronome().MetronomeInfo().BeatsInBar * Convert.ToInt32(numericUpDown_length.Value));
                        coloredProgressBar_record.Value = 1;
                        break;
                    case LooperState.Playing:
                        label_state.Text = "Playing";
                        ResetProgressBar(Color.Green, parent.GetMetronome().MetronomeInfo().BeatsInBar * Convert.ToInt32(numericUpDown_length.Value));
                        coloredProgressBar_record.Value = 1;
                        break;
                    default:
                        ResetProgressBar(Color.White, 1);
                        label_state.Text = "";
                        break;
                }
            }
        }
        int StartingBar; // starting bar of current recording / playing

        Pedal parent;

        public Looper()
        {
            InitializeComponent();

            this.Load += Looper_Load;

            WireClickOfChildren(this);
        }

        private void Looper_Load(object sender, EventArgs e)
        {
            parent.GetRecorder().MixerInputEnded += Looper_MixerInputEnded;
        }

        private void Looper_MixerInputEnded(object sender, SampleProviderEventArgs e)
        {
            /*if (e.SampleProvider == sampleProvider1)
                sampleProvider1 = null;
            if (e.SampleProvider == sampleProvider2)
                sampleProvider2 = null;*/
        }

        public void SetParent(Pedal parent)
        {
            this.parent = parent;
        }

        void WireClickOfChildren(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Click += Control_Click;
                if (control.HasChildren)
                    WireClickOfChildren(control);
            }
        }

        public void SetName(string name)
        {
            this.Name = name;
            groupBox1.Text = this.Name;
        }

        private void Control_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, e);
        }

        private void Recorder_DataAvailable(object sender, WaveInEventArgs e)
        {
            writer.Write(e.Buffer, 0, e.BytesRecorded);          
        }

        private void button_record_Click(object sender, EventArgs e)
        {
            State = LooperState.ReadyToRecord;

            button_record.Enabled = false;
            button_StopRecording.Enabled = true;

            if (Convert.ToInt32(numericUpDown_start.Value) == 0)
                StartRecording();
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            State = LooperState.ReadyToPlay;

            button_play.Enabled = false;
            button_StopPlayback.Enabled = true;

            if (Convert.ToInt32(numericUpDown_start.Value) == 0)
                StartPlayback();
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
            reader1?.Dispose();
            reader1 = null;
            reader2?.Dispose();
            reader2 = null;
            parent.GetRecorder().RemoveTrack(sampleProvider1);
            parent.GetRecorder().RemoveTrack(sampleProvider2);

            base.OnHandleDestroyed(e);
        }

        private void trackBar_Volume_Scroll(object sender, EventArgs e)
        {
            if (reader1 != null)
                reader1.Volume = trackBar_Volume.Value / 100f;
            if (reader2 != null)
                reader2.Volume = trackBar_Volume.Value / 100f;
        }

        void StartRecording()
        {
            State = LooperState.Recording;

            button_record.Enabled = false;
            button_StopRecording.Enabled = true;
            button_play.Enabled = false;
            button_StopPlayback.Enabled = false;
            numericUpDown_length.Enabled = false;
            numericUpDown_start.Enabled = false;

            Directory.CreateDirectory("data\\" + this.Name);

            reader1?.Dispose();
            reader1 = null;
            reader2?.Dispose();
            reader2 = null;
            sampleProvider1 = null;
            sampleProvider2 = null;
            writer = new WaveFileWriter("data\\" + this.Name + "\\" + FileName, parent.waveFormat);
            parent.GetRecorder().Write += Recorder_DataAvailable;
        }

        void StopRecording()
        {
            State = LooperState.Waiting; // TODO: option to automatically start playing

            button_record.Enabled = true;
            button_StopRecording.Enabled = false;
            button_play.Enabled = true;
            numericUpDown_length.Enabled = true;
            numericUpDown_start.Enabled = true;

            parent.GetRecorder().Write -= Recorder_DataAvailable;
            writer?.Dispose();
            writer = null;
        }

        void StartPlayback()
        {
            State = LooperState.Playing;

            button_play.Enabled = false;
            button_StopPlayback.Enabled = true;
            numericUpDown_length.Enabled = false;
            numericUpDown_start.Enabled = false;

            if (File.Exists("data\\" + this.Name + "\\" + FileName))
            {
                if (reader1 == null)
                {
                    reader1 = new AudioFileReader("data\\" + this.Name + "\\" + FileName);
                    reader1.Volume = trackBar_Volume.Value / 100f;

                    sampleProvider1 = new OffsetSampleProvider(reader1);
                    parent.GetRecorder().AddTrack(sampleProvider1);
                }
                else if (reader1.Position == reader1.Length)
                {
                    reader1.Position = 0;

                    sampleProvider1 = new OffsetSampleProvider(reader1);
                    parent.GetRecorder().AddTrack(sampleProvider1);
                }
                else if (reader2 == null)
                {
                    reader2 = new AudioFileReader("data\\" + this.Name + "\\" + FileName);
                    reader2.Volume = trackBar_Volume.Value / 100f;

                    sampleProvider2 = new OffsetSampleProvider(reader2);
                    parent.GetRecorder().AddTrack(sampleProvider2);
                }
                else
                { 
                    reader2.Position = 0;

                    sampleProvider2 = new OffsetSampleProvider(reader2);
                    parent.GetRecorder().AddTrack(sampleProvider2);
                }
            }
            else
            {
                parent.GetMetronome().EmergencyStop();
                MessageBox.Show("You must first record the audio.", "File doesn't exist");
            }
        }

        void StopPlayback()
        {
            State = LooperState.Waiting;

            button_play.Enabled = true;
            button_StopPlayback.Enabled = false;
            numericUpDown_length.Enabled = true;
            numericUpDown_start.Enabled = true;

            parent.GetRecorder().RemoveTrack(sampleProvider1);
            parent.GetRecorder().RemoveTrack(sampleProvider2);
        }

        /// <summary>
        /// Wire this to base metronome
        /// </summary>
        public void Metronome_Bar(object sender, MetronomeEventArgs e) 
        {
            int length = Convert.ToInt32(numericUpDown_length.Value);
            int start = Convert.ToInt32(numericUpDown_start.Value);

            if (State == LooperState.ReadyToRecord)
            {
                if (e.BarNumber % start == 0)
                {
                    StartingBar = e.BarNumber;
                    StartRecording();
                }
            }
            if (State == LooperState.ReadyToPlay)
            {
                if (e.BarNumber % start == 0)
                {
                    StartingBar = e.BarNumber;
                    StartPlayback();
                }
            }
            if (State == LooperState.Recording) {
                if (e.BarNumber >= StartingBar + length)
                {
                    StopRecording();
                }
            }
            if (State == LooperState.Playing) {
                if (e.BarNumber >= StartingBar + length)
                {
                    //StopPlayback();
                    StartingBar = e.BarNumber;
                    StartPlayback();
                }
            }
        }

        public void Metronome_Beat(object sender, MetronomeEventArgs e)
        {
            int length = Convert.ToInt32(numericUpDown_length.Value);
            int start = Convert.ToInt32(numericUpDown_start.Value);

            int lengthBeats = length * e.BeatsInBar;
            int currentBeat = e.BarNumber * e.BeatsInBar + e.BeatNumber;
            int startBeats = start * e.BeatsInBar;

            switch (State)
            {
                case LooperState.ReadyToRecord:
                case LooperState.ReadyToPlay:
                    coloredProgressBar_record.Value = (currentBeat % startBeats) + 1;
                    coloredProgressBar_record.Value = (currentBeat % startBeats) + 1;
                    break;
                case LooperState.Recording:
                case LooperState.Playing:
                    coloredProgressBar_record.Value = (((e.BarNumber - StartingBar) * e.BeatsInBar + e.BeatNumber) % lengthBeats) + 1;
                    break;
            }
        }

        public void Metronome_Stop(object sender, MetronomeEventArgs e)
        {
            if (State == LooperState.Recording)
                StopRecording();
            else if (State == LooperState.Playing)
                StopPlayback();
        }

        void ResetProgressBar(Color color, int maximum)
        {
            coloredProgressBar_record.Maximum = maximum != 0 ? maximum : 1;
            coloredProgressBar_record.Value = 0;
            coloredProgressBar_record.ForeColor = color;
        }

        public void PlayOrPause()
        {
            if (State == LooperState.Waiting)
                State = LooperState.ReadyToPlay;
            else if(State == LooperState.Playing)
                StopPlayback();
        }

        public void RecordOrStop()
        {
            if (State == LooperState.Recording)
                StopRecording();
            else
                State = LooperState.Recording;
        }
    }
}
