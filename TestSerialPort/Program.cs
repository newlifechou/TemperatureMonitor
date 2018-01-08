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
            RealTest test = new RealTest();
            test.TestTemperatureOnly();
            //Console.Read();
        }
    }
}
