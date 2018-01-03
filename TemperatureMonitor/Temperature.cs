using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemperatureMonitor
{
    public class Temperature
    {
        public Temperature()
        {
            RecordDate = DateTime.Now;
            Data = 0;
        }
        public DateTime RecordDate { get; set; }
        public int Data { get; set; }
    }
}
