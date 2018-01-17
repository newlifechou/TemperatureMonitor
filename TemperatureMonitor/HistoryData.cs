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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            string fileName = (listBox1.SelectedItem as DataModel).FileName;
            Debug.Print(fileName);

            List<int> data = new HistoryDataHelper().GetSingleTempData(fileName);
            int[] dd = data.ToArray<int>();
            //chart1.Series[0].Points.DataBindY(dd);
        }
    }
}
