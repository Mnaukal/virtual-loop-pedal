namespace VirtualLoopPedal
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_sampleRate = new System.Windows.Forms.Label();
            this.radioButton_waveOutEvent = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_asio = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button_asioPanel = new System.Windows.Forms.Button();
            this.comboBox_asioDriver = new System.Windows.Forms.ComboBox();
            this.panel_waveEvent = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_inputWave = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_outputWave = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_asio = new System.Windows.Forms.RadioButton();
            this.numericUpDown_sampleRate = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_latency = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_asio.SuspendLayout();
            this.panel_waveEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_latency)).BeginInit();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_save.Location = new System.Drawing.Point(133, 495);
            this.button_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(133, 62);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(280, 495);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(133, 62);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // label_sampleRate
            // 
            this.label_sampleRate.AutoSize = true;
            this.label_sampleRate.Location = new System.Drawing.Point(16, 17);
            this.label_sampleRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_sampleRate.Name = "label_sampleRate";
            this.label_sampleRate.Size = new System.Drawing.Size(89, 17);
            this.label_sampleRate.TabIndex = 4;
            this.label_sampleRate.Text = "Sample Rate";
            // 
            // radioButton_waveOutEvent
            // 
            this.radioButton_waveOutEvent.AutoSize = true;
            this.radioButton_waveOutEvent.Location = new System.Drawing.Point(8, 32);
            this.radioButton_waveOutEvent.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_waveOutEvent.Name = "radioButton_waveOutEvent";
            this.radioButton_waveOutEvent.Size = new System.Drawing.Size(155, 21);
            this.radioButton_waveOutEvent.TabIndex = 5;
            this.radioButton_waveOutEvent.TabStop = true;
            this.radioButton_waveOutEvent.Text = "WaveEvent (default)";
            this.radioButton_waveOutEvent.UseVisualStyleBackColor = true;
            this.radioButton_waveOutEvent.CheckedChanged += new System.EventHandler(this.radioButton_waveOutEvent_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButton_asio);
            this.panel1.Controls.Add(this.radioButton_waveOutEvent);
            this.panel1.Location = new System.Drawing.Point(19, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 178);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.panel_asio, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_waveEvent, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(495, 113);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel_asio
            // 
            this.panel_asio.Controls.Add(this.label4);
            this.panel_asio.Controls.Add(this.button_asioPanel);
            this.panel_asio.Controls.Add(this.comboBox_asioDriver);
            this.panel_asio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_asio.Location = new System.Drawing.Point(247, 4);
            this.panel_asio.Margin = new System.Windows.Forms.Padding(4);
            this.panel_asio.Name = "panel_asio";
            this.panel_asio.Size = new System.Drawing.Size(244, 105);
            this.panel_asio.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Asio driver:";
            // 
            // button_asioPanel
            // 
            this.button_asioPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_asioPanel.Location = new System.Drawing.Point(28, 59);
            this.button_asioPanel.Margin = new System.Windows.Forms.Padding(4);
            this.button_asioPanel.Name = "button_asioPanel";
            this.button_asioPanel.Size = new System.Drawing.Size(190, 36);
            this.button_asioPanel.TabIndex = 9;
            this.button_asioPanel.Text = "Open ASIO control panel";
            this.button_asioPanel.UseVisualStyleBackColor = true;
            // 
            // comboBox_asioDriver
            // 
            this.comboBox_asioDriver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_asioDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_asioDriver.FormattingEnabled = true;
            this.comboBox_asioDriver.Location = new System.Drawing.Point(4, 20);
            this.comboBox_asioDriver.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_asioDriver.Name = "comboBox_asioDriver";
            this.comboBox_asioDriver.Size = new System.Drawing.Size(235, 24);
            this.comboBox_asioDriver.TabIndex = 7;
            // 
            // panel_waveEvent
            // 
            this.panel_waveEvent.Controls.Add(this.label2);
            this.panel_waveEvent.Controls.Add(this.comboBox_inputWave);
            this.panel_waveEvent.Controls.Add(this.label3);
            this.panel_waveEvent.Controls.Add(this.comboBox_outputWave);
            this.panel_waveEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_waveEvent.Location = new System.Drawing.Point(4, 4);
            this.panel_waveEvent.Margin = new System.Windows.Forms.Padding(4);
            this.panel_waveEvent.Name = "panel_waveEvent";
            this.panel_waveEvent.Size = new System.Drawing.Size(235, 105);
            this.panel_waveEvent.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Input:";
            // 
            // comboBox_inputWave
            // 
            this.comboBox_inputWave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_inputWave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_inputWave.FormattingEnabled = true;
            this.comboBox_inputWave.Location = new System.Drawing.Point(4, 20);
            this.comboBox_inputWave.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_inputWave.Name = "comboBox_inputWave";
            this.comboBox_inputWave.Size = new System.Drawing.Size(226, 24);
            this.comboBox_inputWave.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output:";
            // 
            // comboBox_outputWave
            // 
            this.comboBox_outputWave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_outputWave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_outputWave.FormattingEnabled = true;
            this.comboBox_outputWave.Location = new System.Drawing.Point(4, 69);
            this.comboBox_outputWave.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_outputWave.Name = "comboBox_outputWave";
            this.comboBox_outputWave.Size = new System.Drawing.Size(226, 24);
            this.comboBox_outputWave.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Audio Driver";
            // 
            // radioButton_asio
            // 
            this.radioButton_asio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton_asio.AutoSize = true;
            this.radioButton_asio.Enabled = false;
            this.radioButton_asio.Location = new System.Drawing.Point(247, 32);
            this.radioButton_asio.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_asio.Name = "radioButton_asio";
            this.radioButton_asio.Size = new System.Drawing.Size(58, 21);
            this.radioButton_asio.TabIndex = 5;
            this.radioButton_asio.TabStop = true;
            this.radioButton_asio.Text = "ASIO";
            this.radioButton_asio.UseVisualStyleBackColor = true;
            this.radioButton_asio.CheckedChanged += new System.EventHandler(this.radioButton_asio_CheckedChanged);
            // 
            // numericUpDown_sampleRate
            // 
            this.numericUpDown_sampleRate.Location = new System.Drawing.Point(135, 15);
            this.numericUpDown_sampleRate.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_sampleRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.Name = "numericUpDown_sampleRate";
            this.numericUpDown_sampleRate.Size = new System.Drawing.Size(99, 22);
            this.numericUpDown_sampleRate.TabIndex = 0;
            this.toolTip1.SetToolTip(this.numericUpDown_sampleRate, "Number of audio samples per second. Recommended values: 8000, 44100, 48000.");
            this.numericUpDown_sampleRate.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Desired Latency";
            // 
            // numericUpDown_latency
            // 
            this.numericUpDown_latency.Location = new System.Drawing.Point(135, 48);
            this.numericUpDown_latency.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_latency.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_latency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_latency.Name = "numericUpDown_latency";
            this.numericUpDown_latency.Size = new System.Drawing.Size(99, 22);
            this.numericUpDown_latency.TabIndex = 0;
            this.toolTip1.SetToolTip(this.numericUpDown_latency, "Latency of player in milliseconds (values below 100 can cause problems)");
            this.numericUpDown_latency.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 571);
            this.Controls.Add(this.numericUpDown_latency);
            this.Controls.Add(this.numericUpDown_sampleRate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_sampleRate);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_asio.ResumeLayout(false);
            this.panel_asio.PerformLayout();
            this.panel_waveEvent.ResumeLayout(false);
            this.panel_waveEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_latency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_sampleRate;
        private System.Windows.Forms.RadioButton radioButton_waveOutEvent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown_sampleRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_asio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_outputWave;
        private System.Windows.Forms.ComboBox comboBox_inputWave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_waveEvent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_latency;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel_asio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_asioPanel;
        private System.Windows.Forms.ComboBox comboBox_asioDriver;
    }
}