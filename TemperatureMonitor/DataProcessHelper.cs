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

        public void WriteData(Temperature data, string machineName)
        {
            try
            {
                string filepath = Path.Combine(dir, $"{DateTime.Now.ToString("yyMMdd")}machineName");
                StreamWriter sw = new StreamWriter(filepath, true);
                string line = $"{data.RecordDate.ToString()},{data.Data}";
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
