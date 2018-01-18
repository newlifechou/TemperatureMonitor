using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TemperatureMonitor
{
    public partial class HistoryData : Form
    {
        private HistoryDataHelper helper;
        public HistoryData()
        {
            InitializeComponent();
            helper = new HistoryDataHelper();
            this.Load += HistoryData_Load;
        }


        private void HistoryData_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = helper.GetDataFiles();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            string fileName = (listBox1.SelectedItem as DataModel).FileName;

            List<string> data = new HistoryDataHelper().GetSingleTempData(fileName);

            listBox2.BeginUpdate();
            listBox2.Items.Clear();
           
            data.ForEach(i =>
            {
                listBox2.Items.Add(i);
            });
            listBox2.EndUpdate();

            // int[] dd = data.ToArray<int>();
            //chart1.Series[0].Points.DataBindY(dd);
        }
    }
}
