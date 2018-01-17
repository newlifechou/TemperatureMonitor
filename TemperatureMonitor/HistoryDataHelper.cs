using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace TemperatureMonitor
{
    class HistoryDataHelper
    {
        private string dataFolder;
        public HistoryDataHelper()
        {
            dataFolder = Path.Combine(Environment.CurrentDirectory, "Data");
        }

        public List<int> GetSingleTempData(string filename)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            List<int> data = new List<int>();
            string filePath = Path.Combine(dataFolder, filename);
            if (!File.Exists(filePath))
                return null;
            using (var sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                        string dataPart = line.Substring(7, line.Length - 7);
                        int dataInt = int.Parse(dataPart);
                        data.Add(dataInt);
                }
            }

            sw.Stop();
            Debug.Print($"读取数据消耗时间{sw.ElapsedMilliseconds}");
            return data;

        }


        public List<DataModel> GetDataFiles()
        {
            List<DataModel> data = new List<DataModel>();
            DirectoryInfo dir = new DirectoryInfo(dataFolder);
            if (!dir.Exists)
                return null;
            foreach (var file in dir.GetFiles())
            {
                if (file.Name != "Notice.txt")
                {
                    DataModel d = new DataModel
                    {
                        FileName = file.Name,
                        CreateTime = file.CreationTime
                    };

                    data.Add(d);
                }

            }

            return data;
        }

    }
}
