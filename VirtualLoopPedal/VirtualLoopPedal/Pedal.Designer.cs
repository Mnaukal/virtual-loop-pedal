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
            this.flowLayoutPanel_loopers = new System.Windows.Forms.FlowLayoutPanel();
            this.looper1 = new VirtualLoopPedal.Looper();
            this.looper2 = new VirtualLoopPedal.Looper();
            this.looper3 = new VirtualLoopPedal.Looper();
            this.looper4 = new VirtualLoopPedal.Looper();
            this.button_addLooper = new System.Windows.Forms.Button();
            this.button_deleteLooper = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_tempoTool = new System.Windows.Forms.Button();
            this.metronome = new VirtualLoopPedal.Metronome();
            this.recorder = new VirtualLoopPedal.Recorder();
            this.flowLayoutPanel_loopers.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_loopers
            // 
            this.flowLayoutPanel_loopers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_loopers.Controls.Add(this.looper1);
            this.flowLayoutPanel_loopers.Controls.Add(this.looper2);
            this.flowLayoutPanel_loopers.Controls.Add(this.looper3);
            this.flowLayoutPanel_loopers.Controls.Add(this.looper4);
            this.flowLayoutPanel_loopers.Location = new System.Drawing.Point(0, 98);
            this.flowLayoutPanel_loopers.Name = "flowLayoutPanel_loopers";
            this.flowLayoutPanel_loopers.Size = new System.Drawing.Size(1225, 296);
            this.flowLayoutPanel_loopers.TabIndex = 7;
            // 
            // looper1
            // 
            this.looper1.Location = new System.Drawing.Point(10, 10);
            this.looper1.Margin = new System.Windows.Forms.Padding(10);
            this.looper1.Name = "looper1";
            this.looper1.Selected = false;
            this.looper1.Size = new System.Drawing.Size(286, 267);
            this.looper1.TabIndex = 5;
            // 
            // looper2
            // 
            this.looper2.Location = new System.Drawing.Point(316, 10);
            this.looper2.Margin = new System.Windows.Forms.Padding(10);
            this.looper2.Name = "looper2";
            this.looper2.Selected = false;
            this.looper2.Size = new System.Drawing.Size(286, 267);
            this.looper2.TabIndex = 6;
            // 
            // looper3
            // 
            this.looper3.Location = new System.Drawing.Point(622, 10);
            this.looper3.Margin = new System.Windows.Forms.Padding(10);
            this.looper3.Name = "looper3";
            this.looper3.Selected = false;
            this.looper3.Size = new System.Drawing.Size(286, 267);
            this.looper3.TabIndex = 7;
            // 
            // looper4
            // 
            this.looper4.Location = new System.Drawing.Point(928, 10);
            this.looper4.Margin = new System.Windows.Forms.Padding(10);
            this.looper4.Name = "looper4";
            this.looper4.Selected = false;
            this.looper4.Size = new System.Drawing.Size(286, 267);
            this.looper4.TabIndex = 8;
            // 
            // button_addLooper
            // 
            this.button_addLooper.Location = new System.Drawing.Point(12, 16);
            this.button_addLooper.Name = "button_addLooper";
            this.button_addLooper.Size = new System.Drawing.Size(98, 26);
            this.button_addLooper.TabIndex = 9;
            this.button_addLooper.Text = "Add Looper";
            this.button_addLooper.UseVisualStyleBackColor = true;
            this.button_addLooper.Click += new System.EventHandler(this.button_addLooper_Click);
            // 
            // button_deleteLooper
            // 
            this.button_deleteLooper.Location = new System.Drawing.Point(12, 48);
            this.button_deleteLooper.Name = "button_deleteLooper";
            this.button_deleteLooper.Size = new System.Drawing.Size(98, 26);
            this.button_deleteLooper.TabIndex = 10;
            this.button_deleteLooper.Text = "Remove selected";
            this.button_deleteLooper.UseVisualStyleBackColor = true;
            this.button_deleteLooper.Click += new System.EventHandler(this.button_deleteLooper_Click);
            // 
            // button_settings
            // 
            this.button_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_settings.Location = new System.Drawing.Point(1116, 16);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(98, 26);
            this.button_settings.TabIndex = 9;
            this.button_settings.Text = "Settings";
            this.button_settings.UseVisualStyleBackColor = true;
            // 
            // button_tempoTool
            // 
            this.button_tempoTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_tempoTool.Location = new System.Drawing.Point(1116, 49);
            this.button_tempoTool.Name = "button_tempoTool";
            this.button_tempoTool.Size = new System.Drawing.Size(98, 26);
            this.button_tempoTool.TabIndex = 9;
            this.button_tempoTool.Text = "Tempo Tool";
            this.button_tempoTool.UseVisualStyleBackColor = true;
            this.button_tempoTool.Click += new System.EventHandler(this.button_tempoTool_Click);
            // 
            // metronome
            // 
            this.metronome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metronome.Location = new System.Drawing.Point(291, 10);
            this.metronome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metronome.Name = "metronome";
            this.metronome.Size = new System.Drawing.Size(464, 81);
            this.metronome.TabIndex = 11;
            // 
            // recorder
            // 
            this.recorder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recorder.DesiredLatency = 100;
            this.recorder.Location = new System.Drawing.Point(759, 10);
            this.recorder.Margin = new System.Windows.Forms.Padding(2);
            this.recorder.Name = "recorder";
            this.recorder.Size = new System.Drawing.Size(177, 81);
            this.recorder.TabIndex = 12;
            // 
            // Pedal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 383);
            this.Controls.Add(this.recorder);
            this.Controls.Add(this.metronome);
            this.Controls.Add(this.button_deleteLooper);
            this.Controls.Add(this.button_tempoTool);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_addLooper);
            this.Controls.Add(this.flowLayoutPanel_loopers);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(892, 422);
            this.Name = "Pedal";
            this.Text = "Virtual Loop Pedal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pedal_KeyDown);
            this.flowLayoutPanel_loopers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_loopers;
        private System.Windows.Forms.Button button_addLooper;
        private System.Windows.Forms.Button button_deleteLooper;
        private Looper looper1;
        private Looper looper2;
        private Looper looper3;
        private Looper looper4;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_tempoTool;
        private Recorder recorder;
        private Metronome metronome;
    }
}

