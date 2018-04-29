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
            this.looper1 = new VirtualLoopPedal.Looper();
            this.looper2 = new VirtualLoopPedal.Looper();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_metronomeMeasuse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_metronomeTempo)).BeginInit();
            this.groupBox_metronome.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_metronomeStart
            // 
            this.button_metronomeStart.Location = new System.Drawing.Point(248, 19);
            this.button_metronomeStart.Name = "button_metronomeStart";
            this.button_metronomeStart.Size = new System.Drawing.Size(60, 20);
            this.button_metronomeStart.TabIndex = 0;
            this.button_metronomeStart.Text = "Start";
            this.button_metronomeStart.UseVisualStyleBackColor = true;
            this.button_metronomeStart.Click += new System.EventHandler(this.button_metronomeStart_Click);
            // 
            // button_metronomeStop
            // 
            this.button_metronomeStop.Location = new System.Drawing.Point(314, 19);
            this.button_metronomeStop.Name = "button_metronomeStop";
            this.button_metronomeStop.Size = new System.Drawing.Size(60, 20);
            this.button_metronomeStop.TabIndex = 0;
            this.button_metronomeStop.Text = "Stop";
            this.button_metronomeStop.UseVisualStyleBackColor = true;
            this.button_metronomeStop.Click += new System.EventHandler(this.button_metronomeStop_Click);
            // 
            // numericUpDown_metronomeMeasuse
            // 
            this.numericUpDown_metronomeMeasuse.Location = new System.Drawing.Point(60, 19);
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
            this.numericUpDown_metronomeMeasuse.Size = new System.Drawing.Size(36, 20);
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
            this.numericUpDown_metronomeTempo.Location = new System.Drawing.Point(162, 19);
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
            this.numericUpDown_metronomeTempo.Size = new System.Drawing.Size(67, 20);
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
            this.label2.Location = new System.Drawing.Point(116, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tempo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Measure";
            // 
            // groupBox_metronome
            // 
            this.groupBox_metronome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox_metronome.Controls.Add(this.label3);
            this.groupBox_metronome.Controls.Add(this.button_metronomeStop);
            this.groupBox_metronome.Controls.Add(this.numericUpDown_metronomeTempo);
            this.groupBox_metronome.Controls.Add(this.button_metronomeStart);
            this.groupBox_metronome.Controls.Add(this.label2);
            this.groupBox_metronome.Controls.Add(this.numericUpDown_metronomeMeasuse);
            this.groupBox_metronome.Location = new System.Drawing.Point(205, 12);
            this.groupBox_metronome.Name = "groupBox_metronome";
            this.groupBox_metronome.Size = new System.Drawing.Size(391, 48);
            this.groupBox_metronome.TabIndex = 5;
            this.groupBox_metronome.TabStop = false;
            this.groupBox_metronome.Text = "Metronome";
            // 
            // looper1
            // 
            this.looper1.Location = new System.Drawing.Point(12, 66);
            this.looper1.Name = "looper1";
            this.looper1.Size = new System.Drawing.Size(308, 338);
            this.looper1.TabIndex = 6;
            // 
            // looper2
            // 
            this.looper2.Location = new System.Drawing.Point(415, 66);
            this.looper2.Name = "looper2";
            this.looper2.Size = new System.Drawing.Size(308, 338);
            this.looper2.TabIndex = 6;
            // 
            // Pedal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.looper2);
            this.Controls.Add(this.looper1);
            this.Controls.Add(this.groupBox_metronome);
            this.Name = "Pedal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_metronomeMeasuse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_metronomeTempo)).EndInit();
            this.groupBox_metronome.ResumeLayout(false);
            this.groupBox_metronome.PerformLayout();
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
        private Looper looper1;
        private Looper looper2;
    }
}

