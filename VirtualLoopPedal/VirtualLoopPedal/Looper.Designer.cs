namespace VirtualLoopPedal
{
    partial class Looper
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_record = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.button_StopRecording = new System.Windows.Forms.Button();
            this.button_StopPlayback = new System.Windows.Forms.Button();
            this.trackBar_Volume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_playBack = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // button_record
            // 
            this.button_record.Location = new System.Drawing.Point(24, 26);
            this.button_record.Name = "button_record";
            this.button_record.Size = new System.Drawing.Size(113, 50);
            this.button_record.TabIndex = 0;
            this.button_record.Text = "Record";
            this.button_record.UseVisualStyleBackColor = true;
            this.button_record.Click += new System.EventHandler(this.button_record_Click);
            // 
            // button_play
            // 
            this.button_play.Enabled = false;
            this.button_play.Location = new System.Drawing.Point(24, 109);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(113, 45);
            this.button_play.TabIndex = 1;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_StopRecording
            // 
            this.button_StopRecording.Enabled = false;
            this.button_StopRecording.Location = new System.Drawing.Point(143, 26);
            this.button_StopRecording.Name = "button_StopRecording";
            this.button_StopRecording.Size = new System.Drawing.Size(112, 50);
            this.button_StopRecording.TabIndex = 2;
            this.button_StopRecording.Text = "Stop";
            this.button_StopRecording.UseVisualStyleBackColor = true;
            this.button_StopRecording.Click += new System.EventHandler(this.button_StopRecording_Click);
            // 
            // button_StopPlayback
            // 
            this.button_StopPlayback.Enabled = false;
            this.button_StopPlayback.Location = new System.Drawing.Point(143, 109);
            this.button_StopPlayback.Name = "button_StopPlayback";
            this.button_StopPlayback.Size = new System.Drawing.Size(112, 45);
            this.button_StopPlayback.TabIndex = 3;
            this.button_StopPlayback.Text = "Stop";
            this.button_StopPlayback.UseVisualStyleBackColor = true;
            this.button_StopPlayback.Click += new System.EventHandler(this.button_StopPlayback_Click);
            // 
            // trackBar_Volume
            // 
            this.trackBar_Volume.LargeChange = 10;
            this.trackBar_Volume.Location = new System.Drawing.Point(69, 160);
            this.trackBar_Volume.Maximum = 100;
            this.trackBar_Volume.Name = "trackBar_Volume";
            this.trackBar_Volume.Size = new System.Drawing.Size(186, 45);
            this.trackBar_Volume.TabIndex = 4;
            this.trackBar_Volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_Volume.Value = 50;
            this.trackBar_Volume.Scroll += new System.EventHandler(this.trackBar_Volume_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Volume";
            // 
            // checkBox_playBack
            // 
            this.checkBox_playBack.AutoSize = true;
            this.checkBox_playBack.Location = new System.Drawing.Point(24, 188);
            this.checkBox_playBack.Name = "checkBox_playBack";
            this.checkBox_playBack.Size = new System.Drawing.Size(147, 17);
            this.checkBox_playBack.TabIndex = 6;
            this.checkBox_playBack.Text = "Play back while recording";
            this.checkBox_playBack.UseVisualStyleBackColor = true;
            // 
            // Looper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_playBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar_Volume);
            this.Controls.Add(this.button_StopPlayback);
            this.Controls.Add(this.button_StopRecording);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.button_record);
            this.Name = "Looper";
            this.Size = new System.Drawing.Size(425, 393);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_record;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_StopRecording;
        private System.Windows.Forms.Button button_StopPlayback;
        private System.Windows.Forms.TrackBar trackBar_Volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_playBack;
    }
}
