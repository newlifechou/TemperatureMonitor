﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSerialPort
{
    /// <summary>
    /// Temperature and Humidity Data
    /// </summary>
    public class THData
    {
        public THData()
        {
            Temperature = Humidity = 0;
            CurrentTime = DateTime.Now;
        }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public DateTime CurrentTime { get; set; }
    }
}
