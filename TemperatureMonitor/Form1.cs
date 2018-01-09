using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using TestSerialPort;
using System.Threading.Tasks;

namespace TemperatureMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;

            temperatureGraph1.MachineName = "设备A";
            temperatureGraph1.MonitorPosition = "底部";
            temperatureGraph1.DataCount = 500;

            dataHelper = new DataProcessHelper();
            //开启一个任务
            Task.Factory.StartNew(StartTemperature1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("你确定要关闭这个程序?", "确认?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (dr == DialogResult.No);
        }

        public void StartTemperature1()
        {
            try
            {
                var operation = new SerialPortOperate("COM5");
                //一直循环
                while (true)
                {
                    //读取温度传感器的温度指令（未校验）
                    string readCmd = "010303200004";
                    operation.Write(readCmd);

                    Thread.Sleep(2000);

                    string hexString = operation.Read();
                    string tempstr = hexString.Substring(6, 4);
                    double temp = Convert.ToInt32(tempstr, 16);
                    THData d = new THData();
                    d.Temperature = temp;
                    d.Humidity = 0;
                    //d.CurrentTime = DateTime.Now;

                    int temperature1 = (int)d.Temperature;
                    //update ui
                    this.Invoke(new Action(() =>
                    {
                        temperatureGraph1.SetCurrentTempareture(temperature1, d.CurrentTime);
                    }));


                    //Write Log
                    dataHelper.WriteData("A", temperature1);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
            }
        }

        private DataProcessHelper dataHelper;

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
