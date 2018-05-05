namespace VirtualLoopPedal
{
    partial class Metronome
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

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_metronome = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_offset = new System.Windows.Forms.NumericUpDown();
            this.label_beat = new System.Windows.Forms.Label();
            this.label_bar = new System.Windows.Forms.Label();
            this.checkBox_metronome = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_metronomeStop = new System.Windows.Forms.Button();
            this.numericUpDown_metronomeTempo = new System.Windows.Forms.NumericUpDown();
            this.button_metronomeStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_metronomeMeasuse = new System.Windows.Forms.NumericUpDown();
            this.groupBox_metronome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_metronomeTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_metronomeMeasuse)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_metronome
            // 
            this.groupBox_metronome.Controls.Add(this.label1);
            this.groupBox_metronome.Controls.Add(this.numericUpDown_offset);
            this.groupBox_metronome.Controls.Add(this.label_beat);
            this.groupBox_metronome.Controls.Add(this.label_bar);
            this.groupBox_metronome.Controls.Add(this.checkBox_metronome);
            this.groupBox_metronome.Controls.Add(this.label3);
            this.groupBox_metronome.Controls.Add(this.button_metronomeStop);
            this.groupBox_metronome.Controls.Add(this.numericUpDown_metronomeTempo);
            this.groupBox_metronome.Controls.Add(this.button_metronomeStart);
            this.groupBox_metronome.Controls.Add(this.label2);
            this.groupBox_metronome.Controls.Add(this.numericUpDown_metronomeMeasuse);
            this.groupBox_metronome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_metronome.Location = new System.Drawing.Point(0, 0);
            this.groupBox_metronome.Name = "groupBox_metronome";
            this.groupBox_metronome.Size = new System.Drawing.Size(464, 81);
            this.groupBox_metronome.TabIndex = 6;
            this.groupBox_metronome.TabStop = false;
            this.groupBox_metronome.Text = "Metronome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Metronome offset:";
            // 
            // numericUpDown_offset
            // 
            this.numericUpDown_offset.Location = new System.Drawing.Point(407, 49);
            this.numericUpDown_offset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown_offset.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_offset.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown_offset.Name = "numericUpDown_offset";
            this.numericUpDown_offset.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown_offset.TabIndex = 7;
            // 
            // label_beat
            // 
            this.label_beat.AutoSize = true;
            this.label_beat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_beat.Location = new System.Drawing.Point(284, 48);
            this.label_beat.Name = "label_beat";
            this.label_beat.Size = new System.Drawing.Size(17, 17);
            this.label_beat.TabIndex = 6;
            this.label_beat.Text = "0";
            this.label_beat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_bar
            // 
            this.label_bar.AutoSize = true;
            this.label_bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_bar.Location = new System.Drawing.Point(284, 22);
            this.label_bar.Name = "label_bar";
            this.label_bar.Size = new System.Drawing.Size(17, 17);
            this.label_bar.TabIndex = 6;
            this.label_bar.Text = "0";
            this.label_bar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_metronome
            // 
            this.checkBox_metronome.AutoSize = true;
            this.checkBox_metronome.Checked = true;
            this.checkBox_metronome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_metronome.Location = new System.Drawing.Point(314, 24);
            this.checkBox_metronome.Name = "checkBox_metronome";
            this.checkBox_metronome.Size = new System.Drawing.Size(146, 17);
            this.checkBox_metronome.TabIndex = 2;
            this.checkBox_metronome.Text = "Enable metronome sound";
            this.checkBox_metronome.UseVisualStyleBackColor = true;
            this.checkBox_metronome.CheckedChanged += new System.EventHandler(this.checkBox_metronome_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Measure";
            // 
            // button_metronomeStop
            // 
            this.button_metronomeStop.BackColor = System.Drawing.Color.Crimson;
            this.button_metronomeStop.Location = new System.Drawing.Point(193, 20);
            this.button_metronomeStop.Name = "button_metronomeStop";
            this.button_metronomeStop.Size = new System.Drawing.Size(85, 49);
            this.button_metronomeStop.TabIndex = 1;
            this.button_metronomeStop.Text = "Stop";
            this.button_metronomeStop.UseVisualStyleBackColor = false;
            this.button_metronomeStop.Click += new System.EventHandler(this.button_metronomeStop_Click);
            // 
            // numericUpDown_metronomeTempo
            // 
            this.numericUpDown_metronomeTempo.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_metronomeTempo.Location = new System.Drawing.Point(52, 48);
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
            this.numericUpDown_metronomeTempo.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown_metronomeTempo.TabIndex = 4;
            this.numericUpDown_metronomeTempo.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown_metronomeTempo.ValueChanged += new System.EventHandler(this.numericUpDown_metronomeTempo_ValueChanged);
            // 
            // button_metronomeStart
            // 
            this.button_metronomeStart.BackColor = System.Drawing.Color.LightGreen;
            this.button_metronomeStart.Location = new System.Drawing.Point(102, 20);
            this.button_metronomeStart.Name = "button_metronomeStart";
            this.button_metronomeStart.Size = new System.Drawing.Size(85, 49);
            this.button_metronomeStart.TabIndex = 0;
            this.button_metronomeStart.Text = "Start";
            this.button_metronomeStart.UseVisualStyleBackColor = false;
            this.button_metronomeStart.Click += new System.EventHandler(this.button_metronomeStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tempo";
            // 
            // numericUpDown_metronomeMeasuse
            // 
            this.numericUpDown_metronomeMeasuse.Location = new System.Drawing.Point(60, 22);
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
            this.numericUpDown_metronomeMeasuse.TabIndex = 3;
            this.numericUpDown_metronomeMeasuse.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_metronomeMeasuse.ValueChanged += new System.EventHandler(this.numericUpDown_metronomeMeasure_ValueChanged);
            // 
            // Metronome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_metronome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Metronome";
            this.Size = new System.Drawing.Size(464, 81);
            this.groupBox_metronome.ResumeLayout(false);
            this.groupBox_metronome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_metronomeTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_metronomeMeasuse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_metronome;
        private System.Windows.Forms.Label label_beat;
        private System.Windows.Forms.Label label_bar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_metronomeStop;
        private System.Windows.Forms.NumericUpDown numericUpDown_metronomeTempo;
        private System.Windows.Forms.Button button_metronomeStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_metronomeMeasuse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_offset;
        public System.Windows.Forms.CheckBox checkBox_metronome;
    }
}
