using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualLoopPedal
{
    public partial class TempoTool : Form
    {
        Stopwatch stopwatch;
        bool running = false;
        long totalMiliseconds;
        int numberOfTimes;

        public TempoTool()
        {
            Logger.Log("Initializing TempoTool");
            InitializeComponent();
            stopwatch = new Stopwatch();
            Reset();
            Logger.Log("TempoTool initialized successfully");
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if(!running)
            {
                Start();
            }
            else
            {
                Measure();
            }
        }

        void Reset()
        {
            // reset stopwatch
            stopwatch.Reset();
            textBox_average.Text = "";
            textBox_tempo.Text = "";
            label_times.Text = "";
            running = false;
            totalMiliseconds = 0;
            numberOfTimes = 0;
            button_start.Text = "Start";
        }

        void Start()
        {
            // start measuring tempo
            button_start.Text = "Measure";
            stopwatch.Start();
            running = true;
        }

        void Measure()
        {
            // called when user click button to save how long it took from last click and compute tempo
            label_times.Text += "\n" + (stopwatch.ElapsedMilliseconds / 1000f).ToString("0.00");
            totalMiliseconds += stopwatch.ElapsedMilliseconds;
            numberOfTimes++;

            float averageTime = totalMiliseconds / 1000f / numberOfTimes;
            textBox_average.Text = averageTime.ToString("0.00");
            textBox_tempo.Text = (60 / averageTime).ToString("0.#");

            stopwatch.Restart();
        }

        private void TempoTool_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                if (running)
                    Measure();
                else
                    Start();
                e.SuppressKeyPress = true;
            }
        }
    }
}
