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
    public class SerialPortOperate
    {
        private SerialPort port;

        public SerialPortOperate()
        {

        }
        public SerialPortOperate(string portName)
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
            port.ReadTimeout = 100;
        }

        #region 写入缓冲区
        public void Write(byte[] data)
        {
            try
            {
                if (!port.IsOpen)
                    port.Open();

                port.Write(data, 0, data.Length);
            }
            catch
            {
                throw;
            }
        }
        public void Write(string hexString)
        {
            try
            {
                byte[] data = SerialPortHelper.HexStringToBytes(hexString);
                Write(data);
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region 读取缓冲区
        public string Read()
        {
            try
            {
                byte[] data = Read(9);
                string hexString = SerialPortHelper.BytesToHexString(data);
                return hexString;
            }
            catch
            {
                throw;
            }

        }

        public byte[] Read(int count)
        {
            try
            {
                if (!port.IsOpen)
                    port.Open();

                byte[] data = new byte[count];
                port.Read(data, 0, count);
                return data;
            }
            catch
            {
                throw;
            }
        }
        #endregion


    }
}
