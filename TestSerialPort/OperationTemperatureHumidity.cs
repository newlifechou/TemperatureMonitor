using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace TestSerialPort
{
    /// <summary>
    /// 温湿度传感器操作类
    /// </summary>
    public class OperationTemperatureHumidity
    {
        private SerialPort port;

        public OperationTemperatureHumidity()
        {

        }
        public OperationTemperatureHumidity(string portName)
        {
            SetSerialPort(portName);
        }

        public void SetSerialPort(string portName)
        {
            port = new SerialPort();
            port.PortName = portName;
            port.BaudRate = 9600;
            port.Parity = Parity.None;
            port.DataBits = 8;
            port.StopBits = StopBits.One;
        }

        public void Write(byte[] data)
        {
            try
            {
                if (!port.IsOpen)
                    port.Open();

                port.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Write(string hexString)
        {
            try
            {
                byte[] data = SerialPortHelper.HexStringToBytes(hexString);
                Write(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string Read()
        {
            byte[] data = Read(9);
            string hexString = SerialPortHelper.BytesToHexString(data);
            return hexString;
        }

        public byte[] Read(int count)
        {
            byte[] data = new byte[count];
            port.Read(data, 0, count);
            return data;
        }

    }
}
