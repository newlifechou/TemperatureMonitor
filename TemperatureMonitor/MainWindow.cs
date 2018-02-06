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
using WaveFilter;


namespace TemperatureMonitor
{
    public partial class MainWindow : Form
    {
        private DataProcessHelper dataHelper;

        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.FormClosing += Form1_FormClosing;

            intervalRead = Properties.Settings.Default.ReadInterval;
            intervalWrite = Properties.Settings.Default.WriteInterval;
            offSet = Properties.Settings.Default.OffSet;

            InitializeDevices();

            //开启一个任务
            Task newTask = new Task(StartTemperature1);
            newTask.Start();
        }

        private void InitializeDevices()
        {
            temperatureGraph1.MachineName = "设备A";
            temperatureGraph1.MonitorPosition = "底部";
            temperatureGraph1.DataCount = 1000;
            dataHelper = new DataProcessHelper();
        }

        private readonly int intervalRead;
        private readonly int intervalWrite;
        private readonly int offSet;

        /// <summary>
        /// 开始读写并处理数据
        /// </summary>
        public void StartTemperature1()
        {
            string portSetting = Properties.Settings.Default.SerialPortName;
            var operation = new SerialPortOperate(portSetting);

            //一直循环
            int counter = 0;
            //读取温度传感器的温度指令（未校验）
            const string readCmd = "010303200004";

            ValueGroupFilter filter = new ValueGroupFilter();

            while (true)
            {
                try
                {
                    //读取一组数值
                    int readCount = 10;
                    List<double> readGroup = new List<double>();
                    while (readCount > 0)
                    {
                        operation.Write(readCmd);
                        Thread.Sleep(intervalRead);
                        string hexString = operation.Read();
                        string tempstr = hexString.Substring(6, 4);
                        double temp = Convert.ToInt32(tempstr, 16);

                        readGroup.Add(temp);
                        readCount--;
                    }

                    double okValue = filter.Process(readGroup.ToArray());

                    THData d = new THData();
                    d.Temperature = okValue + offSet;
                    d.Humidity = 0;
                    //d.CurrentTime = DateTime.Now;

                    int temperature1 = (int)d.Temperature;
                    //update ui
                    this.Invoke(new Action(() =>
                    {
                        temperatureGraph1.SetCurrentTempareture(temperature1, d.CurrentTime);
                    }));

                    counter++;
                    if (counter * intervalRead % intervalWrite == 0)
                    {
                        //Write Log
                        dataHelper.WriteData("A", temperature1);
                        counter = 0;
                    }
                }
                catch (Exception ex)
                {
                    string exMsg = ex.Message;
                    System.Diagnostics.Debug.Print(exMsg);
                    this.Invoke(new Action(() =>
                    {
                        txtStatus.Text = exMsg;
                    }));
                }


            }

        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("热电偶测温自动记录程序 designed by xs.zhou", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 历史曲线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Data");
            try
            {
                System.Diagnostics.Process.Start(filePath);
                MessageBox.Show("可以使用Excel软件打开数据文件，自行筛选数据并绘图随意");
            }
            catch (Exception ex)
            {
                txtStatus.Text = ex.Message;
            }
            //HistoryData h = new HistoryData();
            //h.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("你确定要关闭这个程序?", "确认?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (dr == DialogResult.No);
        }
    }
}
