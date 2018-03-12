using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TemperatureMonitor
{
    public class DataProcessHelper
    {
        private string filePath;
        public DataProcessHelper(string path)
        {
            filePath = path;
        }

        public void WriteData(int data = 0)
        {
            try
            {
                var now = DateTime.Now;
                StreamWriter sw = new StreamWriter(filePath, true);
                string line = $"{now.ToString()},{data}";
                sw.WriteLine(line);
                sw.Close();
            }
            catch
            {
            }
        }


    }
}
