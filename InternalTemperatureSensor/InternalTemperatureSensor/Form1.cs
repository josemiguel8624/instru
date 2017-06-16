using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using System.IO.Ports;
using System.Threading;


namespace InternalTemperatureSensor
{
    public delegate void emptyFunction();
    public partial class Form1 : Form

    {
        //Chart chart1 = new Chart();
        public Form1()
        {
            InitializeComponent();
            double[] pointsArray = { };

            chart1.ChartAreas.Add("areas");
            chart1.ChartAreas["areas"].AxisX.Minimum = 0;
            chart1.ChartAreas["areas"].AxisX.Interval = 0.25;
            chart1.ChartAreas["areas"].AxisY.Minimum = 0;
            chart1.ChartAreas["areas"].AxisY.Interval = 0.1;
            chart1.ChartAreas["areas"].AxisY.Maximum = 5;
            chart1.ChartAreas["areas"].AxisX.Title = "Time [s]";
            chart1.ChartAreas["areas"].AxisY.Title = "Temperature [°C]";

            chart1.Series.Add("Temperature");
            chart1.Series["Temperature"].Color = Color.Red;
            chart1.Series["Temperature"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart1.Titles.Add("Internal Temeperatur Sensor");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart1.SetBounds(10, 10, 600, 400);

            SerialPort mySerialPort = new SerialPort("COM4");

            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceiveHandler);

            mySerialPort.Open();
        }

        private void DataReceiveHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;

            string indata = sp.ReadTo("\r");
            double temp = Double.Parse(indata);
            temp = temp / 10;
            string time = DateTime.Now.ToShortTimeString();

            Thread thread = new Thread(() => ChartAdd(time, temp));
            thread.IsBackground = true;
            thread.Start();
        }

        private void ChartAdd(string x, double y)
        {
            chart1.Invoke(new emptyFunction(delegate ()
            {
                chart1.Series["Temperature"].Points.AddXY(x, y);
            }));
        }
    }
}