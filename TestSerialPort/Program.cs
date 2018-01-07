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
            var operation = new OperationTemperatureHumidity("COM5");
            while (true)
            {
                operation.Write("010301F40002");
                Thread.Sleep(2000);
                string hexString = operation.Read();
                string tempstr = hexString.Substring(6, 4);
                string humistr = hexString.Substring(10, 4);
                double temp = Convert.ToInt32(tempstr, 16) / 10.0;
                double humi = Convert.ToInt32(humistr, 16) / 10.0;
                Console.WriteLine($"温度:{temp}℃,湿度:{humi}%");
            }
            //Console.Read();
        }
    }
}
