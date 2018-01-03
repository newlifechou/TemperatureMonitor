using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TemperatureMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            start1 = 0;
            start2 = 10;
            start3 = 500;
            start4 = 630;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            temperatureGraph1.MachineName = "热压机A";
            temperatureGraph1.MonitorPosition = "底部";
            temperatureGraph2.MachineName = "热压机B";
            temperatureGraph2.MonitorPosition = "侧边";
            temperatureGraph3.MachineName = "热压机C";
            temperatureGraph3.MonitorPosition = "压头";
            temperatureGraph4.MachineName = "热压机D";
            temperatureGraph4.MonitorPosition = "底部右";

            helper = new DataProcessHelper();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int temperature1 = GraphTest.RandDataFactory.GetRand(start1, 4, true);
            int temperature2 = GraphTest.RandDataFactory.GetRand(start2, 3, true);
            int temperature3 = GraphTest.RandDataFactory.GetRand(start3, 3, false);
            int temperature4 = GraphTest.RandDataFactory.GetRand(start4, 4, false);
            start1++; start2++; start3--; start4--;
            temperatureGraph1.SetCurrentTempareture(temperature1);
            temperatureGraph2.SetCurrentTempareture(temperature2);
            temperatureGraph3.SetCurrentTempareture(temperature3);
            temperatureGraph4.SetCurrentTempareture(temperature4);
        }

        private DataProcessHelper helper;
        private int start1;
        private int start2;
        private int start3;
        private int start4;
        private Timer timer;
    }
}
