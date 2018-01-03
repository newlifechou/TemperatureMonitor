using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        BindingSource bs;
        private void Form1_Load(object sender, EventArgs e)
        {
            data = new int[100];
            bs = new BindingSource();
            timer1.Start();
        }
        int start = 0;
        int[] data;
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                data[i] = data[i + 1];
            }
            data[data.Length - 1] = RandDataFactory.GetRand(start);
            start++;
            //int[] data = RandDataFactory.GetRandInt(100);
            bs.DataSource = data;
            listBox1.DataSource = null;
            listBox1.DataSource = bs;
            var series = chart1.Series[0];
            series.Points.DataBindY(bs);
        }
    }
}
