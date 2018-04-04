namespace GNSSInitialize
{
    partial class mGNSSInitializeForm
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
            this.mOpenPortButton = new System.Windows.Forms.Button();
            this.mSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.portNameComboBox = new System.Windows.Forms.ComboBox();
            this.mInitializButton = new System.Windows.Forms.Button();
            this.mClosePortButton = new System.Windows.Forms.Button();
            this.mDataTextBox = new System.Windows.Forms.TextBox();
            this.mSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.serialPortDebugGroupBox = new System.Windows.Forms.GroupBox();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitsLabel = new System.Windows.Forms.Label();
            this.parityLabel = new System.Windows.Forms.Label();
            this.dataBitsLabel = new System.Windows.Forms.Label();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.portNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.closePortGroupBox = new System.Windows.Forms.GroupBox();
            this.serialPortDebugGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.closePortGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mOpenPortButton
            // 
            this.mOpenPortButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mOpenPortButton.Location = new System.Drawing.Point(61, 209);
            this.mOpenPortButton.Name = "mOpenPortButton";
            this.mOpenPortButton.Size = new System.Drawing.Size(82, 35);
            this.mOpenPortButton.TabIndex = 0;
            this.mOpenPortButton.Text = "Open";
            this.mOpenPortButton.UseVisualStyleBackColor = true;
            this.mOpenPortButton.Click += new System.EventHandler(this.mOpenPortButton_Click);
            // 
            // mSerialPort
            // 
            this.mSerialPort.BaudRate = 19200;
            this.mSerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.mSerialPort_DataReceived);
            // 
            // portNameComboBox
            // 
            this.portNameComboBox.FormattingEnabled = true;
            this.portNameComboBox.Location = new System.Drawing.Point(101, 171);
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(100, 32);
            this.portNameComboBox.TabIndex = 1;
            // 
            // mInitializButton
            // 
            this.mInitializButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mInitializButton.Location = new System.Drawing.Point(9, 37);
            this.mInitializButton.Name = "mInitializButton";
            this.mInitializButton.Size = new System.Drawing.Size(119, 34);
            this.mInitializButton.TabIndex = 2;
            this.mInitializButton.Text = "GPGGA+GPZDA";
            this.mInitializButton.UseVisualStyleBackColor = true;
            this.mInitializButton.Click += new System.EventHandler(this.mInitializeButton_Click);
            // 
            // mClosePortButton
            // 
            this.mClosePortButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mClosePortButton.Location = new System.Drawing.Point(61, 29);
            this.mClosePortButton.Name = "mClosePortButton";
            this.mClosePortButton.Size = new System.Drawing.Size(82, 34);
            this.mClosePortButton.TabIndex = 3;
            this.mClosePortButton.Text = "Close";
            this.mClosePortButton.UseVisualStyleBackColor = true;
            this.mClosePortButton.Click += new System.EventHandler(this.mClosePortButton_Click);
            // 
            // mDataTextBox
            // 
            this.mDataTextBox.Location = new System.Drawing.Point(226, 12);
            this.mDataTextBox.Multiline = true;
            this.mDataTextBox.Name = "mDataTextBox";
            this.mDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mDataTextBox.Size = new System.Drawing.Size(517, 441);
            this.mDataTextBox.TabIndex = 4;
            // 
            // mSaveCheckBox
            // 
            this.mSaveCheckBox.AutoSize = true;
            this.mSaveCheckBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSaveCheckBox.Location = new System.Drawing.Point(134, 45);
            this.mSaveCheckBox.Name = "mSaveCheckBox";
            this.mSaveCheckBox.Size = new System.Drawing.Size(67, 23);
            this.mSaveCheckBox.TabIndex = 5;
            this.mSaveCheckBox.Text = "Save";
            this.mSaveCheckBox.UseVisualStyleBackColor = true;
            this.mSaveCheckBox.CheckedChanged += new System.EventHandler(this.saveCheckBox_CheckedChanged);
            // 
            // serialPortDebugGroupBox
            // 
            this.serialPortDebugGroupBox.BackColor = System.Drawing.SystemColors.Info;
            this.serialPortDebugGroupBox.Controls.Add(this.stopBitsComboBox);
            this.serialPortDebugGroupBox.Controls.Add(this.parityComboBox);
            this.serialPortDebugGroupBox.Controls.Add(this.dataBitsComboBox);
            this.serialPortDebugGroupBox.Controls.Add(this.baudRateComboBox);
            this.serialPortDebugGroupBox.Controls.Add(this.stopBitsLabel);
            this.serialPortDebugGroupBox.Controls.Add(this.parityLabel);
            this.serialPortDebugGroupBox.Controls.Add(this.dataBitsLabel);
            this.serialPortDebugGroupBox.Controls.Add(this.baudRateLabel);
            this.serialPortDebugGroupBox.Controls.Add(this.portNameLabel);
            this.serialPortDebugGroupBox.Controls.Add(this.mOpenPortButton);
            this.serialPortDebugGroupBox.Controls.Add(this.portNameComboBox);
            this.serialPortDebugGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialPortDebugGroupBox.Location = new System.Drawing.Point(12, 12);
            this.serialPortDebugGroupBox.Name = "serialPortDebugGroupBox";
            this.serialPortDebugGroupBox.Size = new System.Drawing.Size(208, 250);
            this.serialPortDebugGroupBox.TabIndex = 6;
            this.serialPortDebugGroupBox.TabStop = false;
            this.serialPortDebugGroupBox.Text = "OpenSerialPort";
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Location = new System.Drawing.Point(101, 133);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(100, 32);
            this.stopBitsComboBox.TabIndex = 10;
            // 
            // parityComboBox
            // 
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Location = new System.Drawing.Point(101, 95);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(100, 32);
            this.parityComboBox.TabIndex = 11;
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Location = new System.Drawing.Point(101, 57);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(100, 32);
            this.dataBitsComboBox.TabIndex = 10;
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(101, 19);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(100, 32);
            this.baudRateComboBox.TabIndex = 9;
            // 
            // stopBitsLabel
            // 
            this.stopBitsLabel.AutoSize = true;
            this.stopBitsLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopBitsLabel.Location = new System.Drawing.Point(6, 140);
            this.stopBitsLabel.Name = "stopBitsLabel";
            this.stopBitsLabel.Size = new System.Drawing.Size(89, 17);
            this.stopBitsLabel.TabIndex = 8;
            this.stopBitsLabel.Text = "StopBits:";
            // 
            // parityLabel
            // 
            this.parityLabel.AutoSize = true;
            this.parityLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.parityLabel.Location = new System.Drawing.Point(6, 102);
            this.parityLabel.Name = "parityLabel";
            this.parityLabel.Size = new System.Drawing.Size(71, 17);
            this.parityLabel.TabIndex = 7;
            this.parityLabel.Text = "Parity:";
            // 
            // dataBitsLabel
            // 
            this.dataBitsLabel.AutoSize = true;
            this.dataBitsLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataBitsLabel.Location = new System.Drawing.Point(6, 64);
            this.dataBitsLabel.Name = "dataBitsLabel";
            this.dataBitsLabel.Size = new System.Drawing.Size(89, 17);
            this.dataBitsLabel.TabIndex = 6;
            this.dataBitsLabel.Text = "DataBits:";
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baudRateLabel.Location = new System.Drawing.Point(6, 26);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(89, 17);
            this.baudRateLabel.TabIndex = 5;
            this.baudRateLabel.Text = "BaudRate:";
            // 
            // portNameLabel
            // 
            this.portNameLabel.AutoSize = true;
            this.portNameLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.portNameLabel.Location = new System.Drawing.Point(6, 178);
            this.portNameLabel.Name = "portNameLabel";
            this.portNameLabel.Size = new System.Drawing.Size(89, 17);
            this.portNameLabel.TabIndex = 4;
            this.portNameLabel.Text = "PortName:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.mInitializButton);
            this.groupBox1.Controls.Add(this.mSaveCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "InitializePort";
            // 
            // closePortGroupBox
            // 
            this.closePortGroupBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.closePortGroupBox.Controls.Add(this.mClosePortButton);
            this.closePortGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closePortGroupBox.Location = new System.Drawing.Point(12, 374);
            this.closePortGroupBox.Name = "closePortGroupBox";
            this.closePortGroupBox.Size = new System.Drawing.Size(207, 79);
            this.closePortGroupBox.TabIndex = 8;
            this.closePortGroupBox.TabStop = false;
            this.closePortGroupBox.Text = "ClosePort";
            // 
            // mGNSSInitializeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(755, 458);
            this.Controls.Add(this.closePortGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.serialPortDebugGroupBox);
            this.Controls.Add(this.mDataTextBox);
            this.Name = "mGNSSInitializeForm";
            this.Text = "GNSSInitialize";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mGNSSInitializeForm_FormClosing);
            this.serialPortDebugGroupBox.ResumeLayout(false);
            this.serialPortDebugGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.closePortGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mOpenPortButton;
        private System.IO.Ports.SerialPort mSerialPort;
        private System.Windows.Forms.ComboBox portNameComboBox;
        private System.Windows.Forms.Button mInitializButton;
        private System.Windows.Forms.Button mClosePortButton;
        private System.Windows.Forms.TextBox mDataTextBox;
        private System.Windows.Forms.CheckBox mSaveCheckBox;
        private System.Windows.Forms.GroupBox serialPortDebugGroupBox;
        private System.Windows.Forms.Label portNameLabel;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Label parityLabel;
        private System.Windows.Forms.Label dataBitsLabel;
        private System.Windows.Forms.Label stopBitsLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox closePortGroupBox;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.ComboBox baudRateComboBox;
    }
}

