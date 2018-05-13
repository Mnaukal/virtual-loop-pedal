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
            this.panel_wasapi = new System.Windows.Forms.Panel();
            this.checkBox_exclusive = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_inputWasapi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_outputWasapi = new System.Windows.Forms.ComboBox();
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
            this.radioButton_wasapi = new System.Windows.Forms.RadioButton();
            this.radioButton_asio = new System.Windows.Forms.RadioButton();
            this.numericUpDown_sampleRate = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_latency = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_bufferSize = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label_noAsio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_wasapi.SuspendLayout();
            this.panel_asio.SuspendLayout();
            this.panel_waveEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_latency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bufferSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_save.Location = new System.Drawing.Point(273, 523);
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
            this.button_cancel.Location = new System.Drawing.Point(420, 523);
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
            this.panel1.Controls.Add(this.radioButton_wasapi);
            this.panel1.Controls.Add(this.radioButton_asio);
            this.panel1.Controls.Add(this.radioButton_waveOutEvent);
            this.panel1.Location = new System.Drawing.Point(19, 128);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 240);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.panel_wasapi, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_asio, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_waveEvent, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 73);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 167);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel_wasapi
            // 
            this.panel_wasapi.Controls.Add(this.checkBox_exclusive);
            this.panel_wasapi.Controls.Add(this.label6);
            this.panel_wasapi.Controls.Add(this.comboBox_inputWasapi);
            this.panel_wasapi.Controls.Add(this.label7);
            this.panel_wasapi.Controls.Add(this.comboBox_outputWasapi);
            this.panel_wasapi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_wasapi.Location = new System.Drawing.Point(523, 4);
            this.panel_wasapi.Margin = new System.Windows.Forms.Padding(4);
            this.panel_wasapi.Name = "panel_wasapi";
            this.panel_wasapi.Size = new System.Drawing.Size(249, 159);
            this.panel_wasapi.TabIndex = 3;
            // 
            // checkBox_exclusive
            // 
            this.checkBox_exclusive.AutoSize = true;
            this.checkBox_exclusive.Location = new System.Drawing.Point(7, 109);
            this.checkBox_exclusive.Name = "checkBox_exclusive";
            this.checkBox_exclusive.Size = new System.Drawing.Size(124, 21);
            this.checkBox_exclusive.TabIndex = 9;
            this.checkBox_exclusive.Text = "Exclusive mode";
            this.toolTip1.SetToolTip(this.checkBox_exclusive, "Exclusive mode should have lower latency, but blocks other applications from play" +
        "ing audio.");
            this.checkBox_exclusive.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Input:";
            // 
            // comboBox_inputWasapi
            // 
            this.comboBox_inputWasapi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_inputWasapi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_inputWasapi.FormattingEnabled = true;
            this.comboBox_inputWasapi.Location = new System.Drawing.Point(4, 20);
            this.comboBox_inputWasapi.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_inputWasapi.Name = "comboBox_inputWasapi";
            this.comboBox_inputWasapi.Size = new System.Drawing.Size(240, 24);
            this.comboBox_inputWasapi.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Output:";
            // 
            // comboBox_outputWasapi
            // 
            this.comboBox_outputWasapi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_outputWasapi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_outputWasapi.FormattingEnabled = true;
            this.comboBox_outputWasapi.Location = new System.Drawing.Point(4, 69);
            this.comboBox_outputWasapi.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_outputWasapi.Name = "comboBox_outputWasapi";
            this.comboBox_outputWasapi.Size = new System.Drawing.Size(240, 24);
            this.comboBox_outputWasapi.TabIndex = 7;
            // 
            // panel_asio
            // 
            this.panel_asio.Controls.Add(this.label_noAsio);
            this.panel_asio.Controls.Add(this.label4);
            this.panel_asio.Controls.Add(this.button_asioPanel);
            this.panel_asio.Controls.Add(this.comboBox_asioDriver);
            this.panel_asio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_asio.Location = new System.Drawing.Point(260, 4);
            this.panel_asio.Margin = new System.Windows.Forms.Padding(4);
            this.panel_asio.Name = "panel_asio";
            this.panel_asio.Size = new System.Drawing.Size(255, 159);
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
            this.button_asioPanel.Location = new System.Drawing.Point(33, 59);
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
            this.comboBox_asioDriver.Size = new System.Drawing.Size(246, 24);
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
            this.panel_waveEvent.Size = new System.Drawing.Size(248, 159);
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
            this.comboBox_inputWave.Size = new System.Drawing.Size(239, 24);
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
            this.comboBox_outputWave.Size = new System.Drawing.Size(239, 24);
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
            // radioButton_wasapi
            // 
            this.radioButton_wasapi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton_wasapi.AutoSize = true;
            this.radioButton_wasapi.Location = new System.Drawing.Point(530, 32);
            this.radioButton_wasapi.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_wasapi.Name = "radioButton_wasapi";
            this.radioButton_wasapi.Size = new System.Drawing.Size(73, 21);
            this.radioButton_wasapi.TabIndex = 5;
            this.radioButton_wasapi.TabStop = true;
            this.radioButton_wasapi.Text = "Wasapi";
            this.radioButton_wasapi.UseVisualStyleBackColor = true;
            this.radioButton_wasapi.CheckedChanged += new System.EventHandler(this.radioButton_wasapi_CheckedChanged);
            // 
            // radioButton_asio
            // 
            this.radioButton_asio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton_asio.AutoSize = true;
            this.radioButton_asio.Enabled = false;
            this.radioButton_asio.Location = new System.Drawing.Point(264, 32);
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
            this.label5.Location = new System.Drawing.Point(16, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Desired Latency";
            // 
            // numericUpDown_latency
            // 
            this.numericUpDown_latency.Location = new System.Drawing.Point(135, 45);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Buffer Size\r\n";
            // 
            // numericUpDown_bufferSize
            // 
            this.numericUpDown_bufferSize.Location = new System.Drawing.Point(135, 75);
            this.numericUpDown_bufferSize.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_bufferSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_bufferSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_bufferSize.Name = "numericUpDown_bufferSize";
            this.numericUpDown_bufferSize.Size = new System.Drawing.Size(99, 22);
            this.numericUpDown_bufferSize.TabIndex = 0;
            this.numericUpDown_bufferSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 77);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Recommended: 100";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(6, 62);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(310, 18);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/Mnaukal/virtual-loop-pedal";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(310, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Virtual Loop Pedal";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(245, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 141);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "About";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(310, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "uses Naudio library by Mark Heath";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(310, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "by Michal Töpfer";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Location = new System.Drawing.Point(6, 111);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(310, 20);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://github.com/naudio/NAudio";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label_noAsio
            // 
            this.label_noAsio.AutoSize = true;
            this.label_noAsio.ForeColor = System.Drawing.Color.DarkRed;
            this.label_noAsio.Location = new System.Drawing.Point(48, 109);
            this.label_noAsio.Name = "label_noAsio";
            this.label_noAsio.Size = new System.Drawing.Size(160, 17);
            this.label_noAsio.TabIndex = 10;
            this.label_noAsio.Text = "ASIO driver not installed";
            this.label_noAsio.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 599);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown_bufferSize);
            this.Controls.Add(this.numericUpDown_latency);
            this.Controls.Add(this.numericUpDown_sampleRate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_sampleRate);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_wasapi.ResumeLayout(false);
            this.panel_wasapi.PerformLayout();
            this.panel_asio.ResumeLayout(false);
            this.panel_asio.PerformLayout();
            this.panel_waveEvent.ResumeLayout(false);
            this.panel_waveEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_latency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bufferSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel_wasapi;
        private System.Windows.Forms.CheckBox checkBox_exclusive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_inputWasapi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_outputWasapi;
        private System.Windows.Forms.RadioButton radioButton_wasapi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_bufferSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label_noAsio;
    }
}