namespace SerialCommunicationGui
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox_Ports = new System.Windows.Forms.ComboBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_BaudRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DataBits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox_Parity = new System.Windows.Forms.ComboBox();
            this.comboBox_StopBits = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_Handshake = new System.Windows.Forms.ComboBox();
            this.textBox_Debug = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_Send = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox_Ports
            // 
            this.comboBox_Ports.FormattingEnabled = true;
            this.comboBox_Ports.Location = new System.Drawing.Point(22, 32);
            this.comboBox_Ports.Name = "comboBox_Ports";
            this.comboBox_Ports.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Ports.TabIndex = 0;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(149, 32);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(93, 23);
            this.button_Connect.TabIndex = 1;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Location = new System.Drawing.Point(248, 32);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(93, 23);
            this.button_Disconnect.TabIndex = 2;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "BaudRate";
            // 
            // textBox_BaudRate
            // 
            this.textBox_BaudRate.Location = new System.Drawing.Point(149, 76);
            this.textBox_BaudRate.Name = "textBox_BaudRate";
            this.textBox_BaudRate.Size = new System.Drawing.Size(100, 22);
            this.textBox_BaudRate.TabIndex = 4;
            this.textBox_BaudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parity";
            // 
            // textBox_DataBits
            // 
            this.textBox_DataBits.Location = new System.Drawing.Point(149, 134);
            this.textBox_DataBits.Name = "textBox_DataBits";
            this.textBox_DataBits.Size = new System.Drawing.Size(100, 22);
            this.textBox_DataBits.TabIndex = 8;
            this.textBox_DataBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "DataBits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "StopBits";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(347, 32);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(441, 300);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // comboBox_Parity
            // 
            this.comboBox_Parity.FormattingEnabled = true;
            this.comboBox_Parity.Location = new System.Drawing.Point(149, 105);
            this.comboBox_Parity.Name = "comboBox_Parity";
            this.comboBox_Parity.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Parity.TabIndex = 18;
            // 
            // comboBox_StopBits
            // 
            this.comboBox_StopBits.FormattingEnabled = true;
            this.comboBox_StopBits.Location = new System.Drawing.Point(149, 164);
            this.comboBox_StopBits.Name = "comboBox_StopBits";
            this.comboBox_StopBits.Size = new System.Drawing.Size(121, 23);
            this.comboBox_StopBits.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "HandShake";
            // 
            // comboBox_Handshake
            // 
            this.comboBox_Handshake.FormattingEnabled = true;
            this.comboBox_Handshake.Location = new System.Drawing.Point(149, 195);
            this.comboBox_Handshake.Name = "comboBox_Handshake";
            this.comboBox_Handshake.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Handshake.TabIndex = 21;
            // 
            // textBox_Debug
            // 
            this.textBox_Debug.Location = new System.Drawing.Point(12, 340);
            this.textBox_Debug.Multiline = true;
            this.textBox_Debug.Name = "textBox_Debug";
            this.textBox_Debug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Debug.Size = new System.Drawing.Size(776, 98);
            this.textBox_Debug.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(12, 299);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(92, 23);
            this.button_Send.TabIndex = 24;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(110, 299);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(92, 23);
            this.button_Stop.TabIndex = 25;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_Debug);
            this.Controls.Add(this.comboBox_Handshake);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_StopBits);
            this.Controls.Add(this.comboBox_Parity);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_DataBits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_BaudRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Disconnect);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.comboBox_Ports);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox_Ports;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_BaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox_Parity;
        private System.Windows.Forms.ComboBox comboBox_StopBits;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_Handshake;
        private System.Windows.Forms.TextBox textBox_Debug;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_Stop;
    }
}

