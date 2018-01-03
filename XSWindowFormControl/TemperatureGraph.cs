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
        public TemperatureGraph()
        {
            InitializeComponent();
            data = new int[100];
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
        private int[] data;
        private BindingSource bs;
        public void SetCurrentTempareture(int currentTemperature)
        {
            txtCurrentTemperature.Text = $"{currentTemperature}℃";

            for (int i = 0; i < data.Length - 1; i++)
            {
                data[i] = data[i + 1];
            }
            data[data.Length - 1] = currentTemperature;

            chartMain.Series[0].Points.DataBindY(data);
        }

    }
}
