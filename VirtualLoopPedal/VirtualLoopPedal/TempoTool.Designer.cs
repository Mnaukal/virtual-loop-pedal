namespace VirtualLoopPedal
{
    partial class TempoTool
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_start = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.label_times = new System.Windows.Forms.Label();
            this.textBox_average = new System.Windows.Forms.TextBox();
            this.textBox_tempo = new System.Windows.Forms.TextBox();
            this.label_average = new System.Windows.Forms.Label();
            this.label_tempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(12, 12);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(126, 51);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(144, 12);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(126, 51);
            this.button_reset.TabIndex = 0;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label_times
            // 
            this.label_times.AutoSize = true;
            this.label_times.Location = new System.Drawing.Point(12, 91);
            this.label_times.Name = "label_times";
            this.label_times.Size = new System.Drawing.Size(0, 17);
            this.label_times.TabIndex = 1;
            // 
            // textBox_average
            // 
            this.textBox_average.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_average.Location = new System.Drawing.Point(144, 111);
            this.textBox_average.Name = "textBox_average";
            this.textBox_average.ReadOnly = true;
            this.textBox_average.Size = new System.Drawing.Size(126, 15);
            this.textBox_average.TabIndex = 2;
            // 
            // textBox_tempo
            // 
            this.textBox_tempo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_tempo.Location = new System.Drawing.Point(144, 169);
            this.textBox_tempo.Name = "textBox_tempo";
            this.textBox_tempo.ReadOnly = true;
            this.textBox_tempo.Size = new System.Drawing.Size(126, 15);
            this.textBox_tempo.TabIndex = 3;
            // 
            // label_average
            // 
            this.label_average.AutoSize = true;
            this.label_average.Location = new System.Drawing.Point(141, 91);
            this.label_average.Name = "label_average";
            this.label_average.Size = new System.Drawing.Size(95, 17);
            this.label_average.TabIndex = 4;
            this.label_average.Text = "Average time:";
            // 
            // label_tempo
            // 
            this.label_tempo.AutoSize = true;
            this.label_tempo.Location = new System.Drawing.Point(141, 149);
            this.label_tempo.Name = "label_tempo";
            this.label_tempo.Size = new System.Drawing.Size(56, 17);
            this.label_tempo.TabIndex = 4;
            this.label_tempo.Text = "Tempo:";
            // 
            // TempoTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 450);
            this.Controls.Add(this.label_tempo);
            this.Controls.Add(this.label_average);
            this.Controls.Add(this.textBox_tempo);
            this.Controls.Add(this.textBox_average);
            this.Controls.Add(this.label_times);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_start);
            this.KeyPreview = true;
            this.Name = "TempoTool";
            this.Text = "TempoTool";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TempoTool_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label_times;
        private System.Windows.Forms.TextBox textBox_average;
        private System.Windows.Forms.TextBox textBox_tempo;
        private System.Windows.Forms.Label label_average;
        private System.Windows.Forms.Label label_tempo;
    }
}