using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XSWindowFormControl
{
    public partial class TemperatureGraph : UserControl
    {
        private int[] data;

        public TemperatureGraph()
        {
            InitializeComponent();
            data = new int[50];
        }
        public int DataCount
        {
            set
            {
                data = new int[value];
            }
        }
        public string MachineName
        {
            set
            {
                txtMachine.Text = value;
            }
        }
        public string MonitorPosition
        {
            set
            {
                txtPosition.Text = value;
            }
        }

        public void SetCurrentTempareture(int currentTemperature, DateTime recordTime)
        {
            try
            {
                txtCurrentTemperature.Text = $"{currentTemperature}℃";
                txtTime.Text = recordTime.ToString("HH:mm:ss");

                for (int i = 0; i < data.Length - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                data[data.Length - 1] = currentTemperature;

                chartMain.Series[0].Points.DataBindY(data);
            }
            catch
            {
                throw;
            }
        }

    }
}
