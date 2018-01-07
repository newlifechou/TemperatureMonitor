using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using Tako.CRC;
using System.Threading;

namespace TestSerialPort
{
    class Program
    {
        static void Main(string[] args)
        {
            var operation = new TemperatureHumidity("COM5");
            while (true)
            {
                string readCmd = "010301F40002";
                operation.Write(readCmd);
                Thread.Sleep(2000);
                string hexString = operation.Read();
                string tempstr = hexString.Substring(6, 4);
                string humistr = hexString.Substring(10, 4);
                double temp = Convert.ToInt32(tempstr, 16) / 10.0;
                double humi = Convert.ToInt32(humistr, 16) / 10.0;
                THData d = new THData();
                d.Temperature = temp;
                d.Humidity = humi;
                d.CurrentTime = DateTime.Now;

                Console.WriteLine($"时间:{d.CurrentTime.ToString()} 温度:{d.Temperature}℃,湿度:{d.Humidity}%");
            }
            //Console.Read();
        }
    }
}
