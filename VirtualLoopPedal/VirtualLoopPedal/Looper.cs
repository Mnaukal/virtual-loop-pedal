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

        WaveInEvent recorder;
        WaveFileWriter writer;
        WaveOutEvent player;
        AudioFileReader reader;
        bool closing = false;

        public Looper()
        {
            InitializeComponent();

            recorder = new WaveInEvent();
            recorder.DataAvailable += Recorder_DataAvailable;
            recorder.RecordingStopped += Recorder_RecordingStopped;

            player = new WaveOutEvent();
            player.PlaybackStopped += Player_PlaybackStopped;

            //Directory.CreateDirectory("data\\" + this.Name);
        }

        private void Player_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            //player.Dispose();
            //player = null;
            reader.Dispose();
            reader = null;

            button_play.Enabled = true;
            button_StopPlayback.Enabled = false;
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
            writer.Write(e.Buffer, 0, e.BytesRecorded);

            if (writer.Position > recorder.WaveFormat.AverageBytesPerSecond * 30) // automatically stop recording after 30 seconds
            {
                recorder.StopRecording();
            }
        }

        private void button_record_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("data\\" + this.Name);
            writer = new WaveFileWriter("data\\" + this.Name + "\\" + FileName, recorder.WaveFormat);
            recorder.StartRecording();
            button_record.Enabled = false;
            button_StopRecording.Enabled = true;
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            if (File.Exists("data\\" + this.Name + "\\" + FileName))
            {
                reader = new AudioFileReader("data\\" + this.Name + "\\" + FileName);
                reader.Volume = trackBar_Volume.Value / 100f; 
                player.Init(reader);
                player.Play();
                button_play.Enabled = false;
                button_StopPlayback.Enabled = true;
            }
            else
            {
                MessageBox.Show("You must first record the audio.", "File doesn't exist");
            }
        }

        private void button_StopRecording_Click(object sender, EventArgs e)
        {
            recorder.StopRecording();
            button_record.Enabled = true;
            button_StopRecording.Enabled = false;
            button_play.Enabled = true;
        }

        private void button_StopPlayback_Click(object sender, EventArgs e)
        {
            player?.Stop();
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
    }
}
