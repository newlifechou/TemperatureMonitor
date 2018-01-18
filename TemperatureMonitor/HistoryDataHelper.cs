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

        public List<string> GetSingleTempData(string filename)
        {

            Debug.Print(filename);
            Stopwatch sw = new Stopwatch();
            sw.Start();

            List<string> data = new List<string>();
            string filePath = Path.Combine(dataFolder, filename);
            if (!File.Exists(filePath))
                return null;
            using (var sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    data.Add(line);
                }
            }

            sw.Stop();
            Debug.Print($"读取数据消耗时间{sw.ElapsedMilliseconds}");
            Debug.Print($"共读取数据{data.Count}");
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
                        CreateTime = file.CreationTime,
                        FileSize = file.Length / 1024 / 1024
                    };

                    data.Add(d);
                }

            }

            return data;
        }

    }
}
