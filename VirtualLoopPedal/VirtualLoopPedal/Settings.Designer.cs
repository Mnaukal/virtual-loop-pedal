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
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_sampleRate = new System.Windows.Forms.Label();
            this.radioButton_waveOutEvent = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_asioPanel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_asioDriver = new System.Windows.Forms.ComboBox();
            this.comboBox_outputWave = new System.Windows.Forms.ComboBox();
            this.comboBox_inputWave = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_asio = new System.Windows.Forms.RadioButton();
            this.numericUpDown_sampleRate = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_waveEvent = new System.Windows.Forms.Panel();
            this.panel_asio = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_waveEvent.SuspendLayout();
            this.panel_asio.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_save.Location = new System.Drawing.Point(115, 402);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 50);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(225, 402);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 50);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // label_sampleRate
            // 
            this.label_sampleRate.AutoSize = true;
            this.label_sampleRate.Location = new System.Drawing.Point(12, 14);
            this.label_sampleRate.Name = "label_sampleRate";
            this.label_sampleRate.Size = new System.Drawing.Size(68, 13);
            this.label_sampleRate.TabIndex = 4;
            this.label_sampleRate.Text = "Sample Rate";
            // 
            // radioButton_waveOutEvent
            // 
            this.radioButton_waveOutEvent.AutoSize = true;
            this.radioButton_waveOutEvent.Location = new System.Drawing.Point(6, 26);
            this.radioButton_waveOutEvent.Name = "radioButton_waveOutEvent";
            this.radioButton_waveOutEvent.Size = new System.Drawing.Size(123, 17);
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
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 145);
            this.panel1.TabIndex = 6;
            // 
            // button_asioPanel
            // 
            this.button_asioPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_asioPanel.Location = new System.Drawing.Point(18, 48);
            this.button_asioPanel.Name = "button_asioPanel";
            this.button_asioPanel.Size = new System.Drawing.Size(164, 29);
            this.button_asioPanel.TabIndex = 9;
            this.button_asioPanel.Text = "Open ASIO control panel";
            this.button_asioPanel.UseVisualStyleBackColor = true;
            this.button_asioPanel.Click += new System.EventHandler(this.button_asioPanel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Asio driver:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Input:";
            // 
            // comboBox_asioDriver
            // 
            this.comboBox_asioDriver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_asioDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_asioDriver.FormattingEnabled = true;
            this.comboBox_asioDriver.Location = new System.Drawing.Point(3, 16);
            this.comboBox_asioDriver.Name = "comboBox_asioDriver";
            this.comboBox_asioDriver.Size = new System.Drawing.Size(189, 21);
            this.comboBox_asioDriver.TabIndex = 7;
            // 
            // comboBox_outputWave
            // 
            this.comboBox_outputWave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_outputWave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_outputWave.FormattingEnabled = true;
            this.comboBox_outputWave.Location = new System.Drawing.Point(3, 56);
            this.comboBox_outputWave.Name = "comboBox_outputWave";
            this.comboBox_outputWave.Size = new System.Drawing.Size(189, 21);
            this.comboBox_outputWave.TabIndex = 7;
            // 
            // comboBox_inputWave
            // 
            this.comboBox_inputWave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_inputWave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_inputWave.FormattingEnabled = true;
            this.comboBox_inputWave.Location = new System.Drawing.Point(3, 16);
            this.comboBox_inputWave.Name = "comboBox_inputWave";
            this.comboBox_inputWave.Size = new System.Drawing.Size(189, 21);
            this.comboBox_inputWave.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Audio Driver";
            // 
            // radioButton_asio
            // 
            this.radioButton_asio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton_asio.AutoSize = true;
            this.radioButton_asio.Enabled = false;
            this.radioButton_asio.Location = new System.Drawing.Point(213, 26);
            this.radioButton_asio.Name = "radioButton_asio";
            this.radioButton_asio.Size = new System.Drawing.Size(50, 17);
            this.radioButton_asio.TabIndex = 5;
            this.radioButton_asio.TabStop = true;
            this.radioButton_asio.Text = "ASIO";
            this.radioButton_asio.UseVisualStyleBackColor = true;
            this.radioButton_asio.CheckedChanged += new System.EventHandler(this.radioButton_asio_CheckedChanged);
            // 
            // numericUpDown_sampleRate
            // 
            this.numericUpDown_sampleRate.Location = new System.Drawing.Point(86, 12);
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
            this.numericUpDown_sampleRate.Size = new System.Drawing.Size(74, 20);
            this.numericUpDown_sampleRate.TabIndex = 0;
            this.numericUpDown_sampleRate.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel_waveEvent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_asio, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(402, 92);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel_waveEvent
            // 
            this.panel_waveEvent.Controls.Add(this.label2);
            this.panel_waveEvent.Controls.Add(this.comboBox_inputWave);
            this.panel_waveEvent.Controls.Add(this.label3);
            this.panel_waveEvent.Controls.Add(this.comboBox_outputWave);
            this.panel_waveEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_waveEvent.Location = new System.Drawing.Point(3, 3);
            this.panel_waveEvent.Name = "panel_waveEvent";
            this.panel_waveEvent.Size = new System.Drawing.Size(195, 86);
            this.panel_waveEvent.TabIndex = 0;
            // 
            // panel_asio
            // 
            this.panel_asio.Controls.Add(this.label4);
            this.panel_asio.Controls.Add(this.button_asioPanel);
            this.panel_asio.Controls.Add(this.comboBox_asioDriver);
            this.panel_asio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_asio.Location = new System.Drawing.Point(204, 3);
            this.panel_asio.Name = "panel_asio";
            this.panel_asio.Size = new System.Drawing.Size(195, 86);
            this.panel_asio.TabIndex = 1;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 464);
            this.Controls.Add(this.numericUpDown_sampleRate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_sampleRate);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_waveEvent.ResumeLayout(false);
            this.panel_waveEvent.PerformLayout();
            this.panel_asio.ResumeLayout(false);
            this.panel_asio.PerformLayout();
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
        private System.Windows.Forms.Button button_asioPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_asioDriver;
        private System.Windows.Forms.ComboBox comboBox_outputWave;
        private System.Windows.Forms.ComboBox comboBox_inputWave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_waveEvent;
        private System.Windows.Forms.Panel panel_asio;
    }
}