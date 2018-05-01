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
            metronome.Stopped += looper.Metronome_Stop;
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

        private void Pedal_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F:
                    looper_Click(loopers[0], new EventArgs());
                    break;
                case Keys.G:
                    looper_Click(loopers[1], new EventArgs());
                    break;
                case Keys.H:
                    looper_Click(loopers[2], new EventArgs());
                    break;
                case Keys.J:
                    looper_Click(loopers[3], new EventArgs());
                    break;
                case Keys.V:
                    // TODO: next looper
                    break;
                case Keys.C:
                    // TODO: previous looper
                    break;
                case Keys.M:
                    checkBox_metronome.Checked = !checkBox_metronome.Checked;
                    break;
                case Keys.R:
                case Keys.N:
                    selectedLooper?.RecordOrStop();
                    break;
                case Keys.B:
                case Keys.P:
                    selectedLooper?.PlayOrPause();
                    break;
                case Keys.Space:
                    metronome.StartOrStop();
                    break;
                case Keys.X:
                    metronome.EmergencyStop();
                    break;
            }
            //e.SuppressKeyPress = true;
        }

        private void button_tempoTool_Click(object sender, EventArgs e)
        {
            TempoTool tempoTool = new TempoTool();
            tempoTool.Show();
        }
    }
}
