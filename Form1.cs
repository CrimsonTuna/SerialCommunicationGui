using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SerialCommunicationGui
{
    public partial class Form1 : Form
    {
        List<double> xValues;
        List<double> yValues;
        double _current = default;
        Random _rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Ports.Items.AddRange(SerialPort.GetPortNames()); 
            comboBox_Parity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            comboBox_Parity.SelectedIndex = 0;
            comboBox_StopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            comboBox_StopBits.SelectedIndex = 1;
            comboBox_Handshake.Items.AddRange(Enum.GetNames(typeof(Handshake)));
            comboBox_Handshake.SelectedIndex = 0;
            textBox_BaudRate.Text = "9600";
            textBox_DataBits.Text = "8";

            xValues = Enumerable.Range(0, 100).Select(v=>(double)v).ToList();
            yValues = Enumerable.Repeat(0d, 100).ToList();

            chart1.Legends.Clear();
            chart1.Series[0].Points.DataBindXY(xValues, yValues);
            chart1.Series[0].ChartType = SeriesChartType.Line;

            button_Stop.Enabled = false;
        }


        private void button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                ThreadPool.SetMinThreads(2, 4);


                // Set Port Property
                serialPort1.PortName = comboBox_Ports.Text;
                serialPort1.BaudRate = int.Parse(textBox_BaudRate.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox_Parity.Text);
                serialPort1.DataBits = int.Parse(textBox_DataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox_StopBits.Text);
                serialPort1.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comboBox_Handshake.Text);
                serialPort1.ReceivedBytesThreshold = 1;
                serialPort1.DtrEnable = true;
                serialPort1.RtsEnable = true;
                serialPort1.Encoding = Encoding.ASCII;
                serialPort1.Open();

                button_Disconnect.Enabled = true;
                button_Connect.Enabled = false;

                textBox_Debug.Text = $"{serialPort1.PortName} connected.{Environment.NewLine}";
            }
            catch(Exception ex)
            {
                textBox_Debug.Text = ex.ToString();
            }
            
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();

                    button_Disconnect.Enabled = false;
                    button_Connect.Enabled = true;

                    textBox_Debug.Text = $"{serialPort1.PortName} disconnected.{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                textBox_Debug.Text = ex.ToString();
            }
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                button_Send.Enabled = true;
                button_Stop.Enabled = false;
            }
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;  // 500 msec
            timer1.Start();

            button_Send.Enabled = false;
            button_Stop.Enabled = true;
        }



        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;

            this.Invoke(new RecieveMessage(RecieveMessageMethod), new object[] { "Error" });

            port.DiscardInBuffer();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;

            this.Invoke(new RecieveMessage(RecieveMessageMethod), new object[]{port.ReadLine()});
        }

        public delegate void RecieveMessage(string message);

        public void RecieveMessageMethod(string message)
        {
            textBox_Debug.Text = $"Data Recieved: {message}{Environment.NewLine}";

            if(double.TryParse(message,out double value))
            {
                yValues.Add(value);
                yValues.RemoveAt(0);
                chart1.Series[0].Points.DataBindXY(xValues, yValues);
                chart1.Invalidate();
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            // Send random walk
            _current += _rand.NextDouble() - 0.5d;
            serialPort1.WriteLine(_current.ToString());

            textBox_Debug.Text = $"Data Send: {_current}";
        }
    }
}
