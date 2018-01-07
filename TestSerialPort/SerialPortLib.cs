using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace TestSerialPort
{
    public class SerialPortLib
    {
        public SerialPortLib()
        {
            comDevice = new SerialPort();
        }

        /// <summary>
        /// 获取当前计算机上的串口名称
        /// </summary>
        /// <returns>串口名称数组</returns>
        public string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }

        /// <summary>
        /// 设置串口参数
        /// </summary>
        public void SetSerialPort(int portIndex = 0)
        {
            string[] portNames = GetPortNames();
            //判定串口数目
            if (portNames.Length == 0)
            {
                throw new Exception("当前计算机上没有找到可用串口");
            }
            comDevice.PortName = portNames[portIndex];
            comDevice.BaudRate = 9600;
            comDevice.Parity = Parity.None;
            comDevice.DataBits = 8;
            comDevice.StopBits = StopBits.One;
        }

        public void OpenPort()
        {
            if (!comDevice.IsOpen) comDevice.Open();
        }
        public void ClosePort()
        {
            if (comDevice.IsOpen) comDevice.Close();
        }
        public void SendData(string data)
        {

        }

        public string GetData(string data)
        {
            return null;
        }

        public void SendData(byte[] data)
        {

        }
        public byte[] GetDate(byte[] data)
        {
            return null;
        }


        private SerialPort comDevice;
    }
}
