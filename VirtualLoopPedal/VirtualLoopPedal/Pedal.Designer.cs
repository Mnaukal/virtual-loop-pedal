namespace VirtualLoopPedal
{
    partial class Pedal
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_metronomeStart = new System.Windows.Forms.Button();
            this.button_metronomeStop = new System.Windows.Forms.Button();
            this.numericUpDown_metronomeMeasuse = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_metronomeTempo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_metronome = new System.Windows.Forms.GroupBox();
            this.label_beat = new System.Windows.Forms.Label();
            this.label_bar = new System.Windows.Forms.Label();
            this.checkBox_metronome = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.looper1 = new VirtualLoopPedal.Looper();
            this.looper2 = new VirtualLoopPedal.Looper();
            this.looper3 = new VirtualLoopPedal.Looper();
            this.looper4 = new VirtualLoopPedal.Looper();
            this.button_addLooper = new System.Windows.Forms.Button();
            this.button_deleteLooper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_metronomeMeasuse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_metronomeTempo)).BeginInit();
            this.groupBox_metronome.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_metronomeStart
            // 
            this.button_metronomeStart.BackColor = System.Drawing.Color.LightGreen;
            this.button_metronomeStart.Location = new System.Drawing.Point(136, 20);
            this.button_metronomeStart.Margin = new System.Windows.Forms.Padding(4);
            this.button_metronomeStart.Name = "button_metronomeStart";
            this.button_metronomeStart.Size = new System.Drawing.Size(113, 60);
            this.button_metronomeStart.TabIndex = 0;
            this.button_metronomeStart.Text = "Start";
            this.button_metronomeStart.UseVisualStyleBackColor = false;
            this.button_metronomeStart.Click += new System.EventHandler(this.button_metronomeStart_Click);
            // 
            // button_metronomeStop
            // 
            this.button_metronomeStop.BackColor = System.Drawing.Color.Crimson;
            this.button_metronomeStop.Location = new System.Drawing.Point(257, 20);
            this.button_metronomeStop.Margin = new System.Windows.Forms.Padding(4);
            this.button_metronomeStop.Name = "button_metronomeStop";
            this.button_metronomeStop.Size = new System.Drawing.Size(113, 60);
            this.button_metronomeStop.TabIndex = 0;
            this.button_metronomeStop.Text = "Stop";
            this.button_metronomeStop.UseVisualStyleBackColor = false;
            this.button_metronomeStop.Click += new System.EventHandler(this.button_metronomeStop_Click);
            // 
            // numericUpDown_metronomeMeasuse
            // 
            this.numericUpDown_metronomeMeasuse.Location = new System.Drawing.Point(80, 23);
            this.numericUpDown_metronomeMeasuse.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_metronomeMeasuse.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_metronomeMeasuse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_metronomeMeasuse.Name = "numericUpDown_metronomeMeasuse";
            this.numericUpDown_metronomeMeasuse.Size = new System.Drawing.Size(48, 22);
            this.numericUpDown_metronomeMeasuse.TabIndex = 1;
            this.numericUpDown_metronomeMeasuse.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_metronomeMeasuse.ValueChanged += new System.EventHandler(this.numericUpDown_metronomeMeasure_ValueChanged);
            // 
            // numericUpDown_metronomeTempo
            // 
            this.numericUpDown_metronomeTempo.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_metronomeTempo.Location = new System.Drawing.Point(69, 55);
            this.numericUpDown_metronomeTempo.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_metronomeTempo.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.numericUpDown_metronomeTempo.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_metronomeTempo.Name = "numericUpDown_metronomeTempo";
            this.numericUpDown_metronomeTempo.Size = new System.Drawing.Size(59, 22);
            this.numericUpDown_metronomeTempo.TabIndex = 3;
            this.numericUpDown_metronomeTempo.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown_metronomeTempo.ValueChanged += new System.EventHandler(this.numericUpDown_metronomeTempo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tempo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Measure";
            // 
            // groupBox_metronome
            // 
            this.groupBox_metronome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox_metronome.Controls.Add(this.label_beat);
            this.groupBox_metronome.Controls.Add(this.label_bar);
            this.groupBox_metronome.Controls.Add(this.checkBox_metronome);
            this.groupBox_metronome.Controls.Add(this.label3);
            this.groupBox_metronome.Controls.Add(this.button_metronomeStop);
            this.groupBox_metronome.Controls.Add(this.numericUpDown_metronomeTempo);
            this.groupBox_metronome.Controls.Add(this.button_metronomeStart);
            this.groupBox_metronome.Controls.Add(this.label2);
            this.groupBox_metronome.Controls.Add(this.numericUpDown_metronomeMeasuse);
            this.groupBox_metronome.Location = new System.Drawing.Point(565, 15);
            this.groupBox_metronome.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_metronome.Name = "groupBox_metronome";
            this.groupBox_metronome.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_metronome.Size = new System.Drawing.Size(643, 87);
            this.groupBox_metronome.TabIndex = 5;
            this.groupBox_metronome.TabStop = false;
            this.groupBox_metronome.Text = "Metronome";
            // 
            // label_beat
            // 
            this.label_beat.AutoSize = true;
            this.label_beat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_beat.Location = new System.Drawing.Point(379, 55);
            this.label_beat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_beat.Name = "label_beat";
            this.label_beat.Size = new System.Drawing.Size(19, 20);
            this.label_beat.TabIndex = 6;
            this.label_beat.Text = "0";
            this.label_beat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_bar
            // 
            this.label_bar.AutoSize = true;
            this.label_bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_bar.Location = new System.Drawing.Point(379, 23);
            this.label_bar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_bar.Name = "label_bar";
            this.label_bar.Size = new System.Drawing.Size(19, 20);
            this.label_bar.TabIndex = 6;
            this.label_bar.Text = "0";
            this.label_bar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_metronome
            // 
            this.checkBox_metronome.AutoSize = true;
            this.checkBox_metronome.Checked = true;
            this.checkBox_metronome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_metronome.Location = new System.Drawing.Point(440, 41);
            this.checkBox_metronome.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_metronome.Name = "checkBox_metronome";
            this.checkBox_metronome.Size = new System.Drawing.Size(189, 21);
            this.checkBox_metronome.TabIndex = 5;
            this.checkBox_metronome.Text = "Enable metronome sound";
            this.checkBox_metronome.UseVisualStyleBackColor = true;
            this.checkBox_metronome.CheckedChanged += new System.EventHandler(this.checkBox_metronome_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.looper1);
            this.flowLayoutPanel1.Controls.Add(this.looper2);
            this.flowLayoutPanel1.Controls.Add(this.looper3);
            this.flowLayoutPanel1.Controls.Add(this.looper4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 110);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1635, 468);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // looper1
            // 
            this.looper1.DesiredLatency = 100;
            this.looper1.Location = new System.Drawing.Point(13, 12);
            this.looper1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.looper1.MaximumSize = new System.Drawing.Size(381, 389);
            this.looper1.MinimumSize = new System.Drawing.Size(381, 389);
            this.looper1.Name = "looper1";
            this.looper1.Selected = false;
            this.looper1.Size = new System.Drawing.Size(381, 389);
            this.looper1.TabIndex = 0;
            // 
            // looper2
            // 
            this.looper2.DesiredLatency = 100;
            this.looper2.Location = new System.Drawing.Point(420, 12);
            this.looper2.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.looper2.MaximumSize = new System.Drawing.Size(381, 389);
            this.looper2.MinimumSize = new System.Drawing.Size(381, 389);
            this.looper2.Name = "looper2";
            this.looper2.Selected = false;
            this.looper2.Size = new System.Drawing.Size(381, 389);
            this.looper2.TabIndex = 1;
            // 
            // looper3
            // 
            this.looper3.DesiredLatency = 100;
            this.looper3.Location = new System.Drawing.Point(827, 12);
            this.looper3.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.looper3.MaximumSize = new System.Drawing.Size(381, 389);
            this.looper3.MinimumSize = new System.Drawing.Size(381, 389);
            this.looper3.Name = "looper3";
            this.looper3.Selected = false;
            this.looper3.Size = new System.Drawing.Size(381, 389);
            this.looper3.TabIndex = 2;
            // 
            // looper4
            // 
            this.looper4.DesiredLatency = 100;
            this.looper4.Location = new System.Drawing.Point(1234, 12);
            this.looper4.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.looper4.MaximumSize = new System.Drawing.Size(381, 389);
            this.looper4.MinimumSize = new System.Drawing.Size(381, 389);
            this.looper4.Name = "looper4";
            this.looper4.Selected = false;
            this.looper4.Size = new System.Drawing.Size(381, 389);
            this.looper4.TabIndex = 3;
            // 
            // button_addLooper
            // 
            this.button_addLooper.Location = new System.Drawing.Point(16, 20);
            this.button_addLooper.Margin = new System.Windows.Forms.Padding(4);
            this.button_addLooper.Name = "button_addLooper";
            this.button_addLooper.Size = new System.Drawing.Size(131, 32);
            this.button_addLooper.TabIndex = 8;
            this.button_addLooper.Text = "Add Looper";
            this.button_addLooper.UseVisualStyleBackColor = true;
            this.button_addLooper.Click += new System.EventHandler(this.button_addLooper_Click);
            // 
            // button_deleteLooper
            // 
            this.button_deleteLooper.Location = new System.Drawing.Point(16, 59);
            this.button_deleteLooper.Margin = new System.Windows.Forms.Padding(4);
            this.button_deleteLooper.Name = "button_deleteLooper";
            this.button_deleteLooper.Size = new System.Drawing.Size(131, 32);
            this.button_deleteLooper.TabIndex = 8;
            this.button_deleteLooper.Text = "Remove selected";
            this.button_deleteLooper.UseVisualStyleBackColor = true;
            this.button_deleteLooper.Click += new System.EventHandler(this.button_deleteLooper_Click);
            // 
            // Pedal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 575);
            this.Controls.Add(this.button_deleteLooper);
            this.Controls.Add(this.button_addLooper);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox_metronome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(839, 526);
            this.Name = "Pedal";
            this.Text = "Virtual Loop Pedal";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_metronomeMeasuse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_metronomeTempo)).EndInit();
            this.groupBox_metronome.ResumeLayout(false);
            this.groupBox_metronome.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_metronomeStart;
        private System.Windows.Forms.Button button_metronomeStop;
        private System.Windows.Forms.NumericUpDown numericUpDown_metronomeMeasuse;
        private System.Windows.Forms.NumericUpDown numericUpDown_metronomeTempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_metronome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_bar;
        private System.Windows.Forms.CheckBox checkBox_metronome;
        private System.Windows.Forms.Label label_beat;
        private System.Windows.Forms.Button button_addLooper;
        private System.Windows.Forms.Button button_deleteLooper;
        private Looper looper1;
        private Looper looper2;
        private Looper looper3;
        private Looper looper4;
    }
}

