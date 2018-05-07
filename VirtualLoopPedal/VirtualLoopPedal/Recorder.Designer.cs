namespace VirtualLoopPedal
{
    partial class Recorder
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
            this.volumeMeter = new NAudio.Gui.VolumeMeter();
            this.checkBox_playback = new System.Windows.Forms.CheckBox();
            this.numericUpDown_offset = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_recorder = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_offset)).BeginInit();
            this.groupBox_recorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // volumeMeter
            // 
            this.volumeMeter.Amplitude = 0F;
            this.volumeMeter.ForeColor = System.Drawing.Color.LimeGreen;
            this.volumeMeter.Location = new System.Drawing.Point(199, 17);
            this.volumeMeter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.volumeMeter.MaxDb = 18F;
            this.volumeMeter.MinDb = -60F;
            this.volumeMeter.Name = "volumeMeter";
            this.volumeMeter.Size = new System.Drawing.Size(25, 75);
            this.volumeMeter.TabIndex = 1;
            this.volumeMeter.TabStop = false;
            this.volumeMeter.Text = "Volume Meter";
            // 
            // checkBox_playback
            // 
            this.checkBox_playback.AutoSize = true;
            this.checkBox_playback.Location = new System.Drawing.Point(9, 64);
            this.checkBox_playback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_playback.Name = "checkBox_playback";
            this.checkBox_playback.Size = new System.Drawing.Size(145, 21);
            this.checkBox_playback.TabIndex = 2;
            this.checkBox_playback.Text = "Listen to recording";
            this.checkBox_playback.UseVisualStyleBackColor = true;
            this.checkBox_playback.CheckedChanged += new System.EventHandler(this.checkBox_playback_CheckedChanged);
            // 
            // numericUpDown_offset
            // 
            this.numericUpDown_offset.Location = new System.Drawing.Point(118, 24);
            this.numericUpDown_offset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_offset.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_offset.Name = "numericUpDown_offset";
            this.numericUpDown_offset.Size = new System.Drawing.Size(64, 22);
            this.numericUpDown_offset.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Playback offset:";
            // 
            // groupBox_recorder
            // 
            this.groupBox_recorder.Controls.Add(this.label1);
            this.groupBox_recorder.Controls.Add(this.volumeMeter);
            this.groupBox_recorder.Controls.Add(this.checkBox_playback);
            this.groupBox_recorder.Controls.Add(this.numericUpDown_offset);
            this.groupBox_recorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_recorder.Location = new System.Drawing.Point(0, 0);
            this.groupBox_recorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_recorder.MaximumSize = new System.Drawing.Size(236, 100);
            this.groupBox_recorder.MinimumSize = new System.Drawing.Size(236, 100);
            this.groupBox_recorder.Name = "groupBox_recorder";
            this.groupBox_recorder.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_recorder.Size = new System.Drawing.Size(236, 100);
            this.groupBox_recorder.TabIndex = 5;
            this.groupBox_recorder.TabStop = false;
            this.groupBox_recorder.Text = "Recorder";
            // 
            // Recorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_recorder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Recorder";
            this.Size = new System.Drawing.Size(236, 100);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_offset)).EndInit();
            this.groupBox_recorder.ResumeLayout(false);
            this.groupBox_recorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private NAudio.Gui.VolumeMeter volumeMeter;
        private System.Windows.Forms.CheckBox checkBox_playback;
        private System.Windows.Forms.NumericUpDown numericUpDown_offset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_recorder;
    }
}
