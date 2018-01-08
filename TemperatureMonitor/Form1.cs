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

            temperatureGraph1.MachineName = "设备A";
            temperatureGraph1.MonitorPosition = "底部";

            dataHelper = new DataProcessHelper();
            //开启一个任务
            Task.Factory.StartNew(StartTemperature1);
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

    }
}
