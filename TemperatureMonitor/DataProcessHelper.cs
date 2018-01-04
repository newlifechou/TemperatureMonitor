using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TemperatureMonitor
{
    public class DataProcessHelper
    {
        private string dir;
        public DataProcessHelper()
        {
            dir = Path.Combine(Environment.CurrentDirectory, "Data");
        }

        public void WriteData(string machineName, int data = 0)
        {
            try
            {
                var now = DateTime.Now;
                string filepath = Path.Combine(dir, $"{now.ToString("yyMMdd")}{machineName}.txt");
                StreamWriter sw = new StreamWriter(filepath, true);
                string line = $"{now.ToString("HHmmss")}={data}";
                sw.WriteLine(line);
                sw.Close();
            }
            catch
            {
                throw;
            }
        }


    }
}
