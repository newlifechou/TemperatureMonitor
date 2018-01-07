using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using Tako.CRC;

namespace TestSerialPort
{
    public class SerialPortLib
    {
        public SerialPortLib()
        {
            comDevice = new SerialPort();
        }
        public byte[] ResponseBytes { get; set; }

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
            comDevice.Parity = Parity.None;//无校验
            comDevice.DataBits = 8;
            comDevice.StopBits = StopBits.One;
            comDevice.Encoding = Encoding.ASCII;
            comDevice.DataReceived += ComDevice_DataReceived;
            comDevice.ErrorReceived += ComDevice_ErrorReceived;
            comDevice.ReceivedBytesThreshold = 9;
        }

        private void ComDevice_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ComDevice_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] receivedData = new byte[comDevice.BytesToRead];
            comDevice.Read(receivedData, 0, receivedData.Length);
            ResponseBytes = receivedData;
        }

        public void OpenPort()
        {
            if (!comDevice.IsOpen) comDevice.Open();
        }
        public void ClosePort()
        {
            if (comDevice.IsOpen) comDevice.Close();
        }
        public void SendData()
        {
            //comDevice.Write("010301F400028405");\
            byte[] send = new byte[8];
            send[0] = 0x01;
            send[1] = 0x03;
            send[2] = 0x01;
            send[3] = 0xF4;
            send[4] = 0x00;
            send[5] = 0x02;
            send[6] = 0x84;
            send[7] = 0x05;
            comDevice.Write(send, 0, send.Length);
            //string str = comDevice.ReadExisting();
            //byte[] go = Encoding.ASCII.GetBytes(str);
        }
        public void SendData(byte[] data)
        {
            comDevice.Write(data, 0, data.Length);
        }

        /// <summary>
        /// 使用了tako.crc类库
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string CRC16MODBUS(string input)
        {
            CRCManager manager = new CRCManager();
            CRCProviderBase crc = manager.CreateCRCProvider(EnumCRCProvider.CRC16Modbus);
            CRCStatus status = crc.GetCRC(input);
            return status.CrcHexadecimal;
        }
        public byte[] CRC16MODBUSArray(string input)
        {
            CRCManager manager = new CRCManager();
            CRCProviderBase crc = manager.CreateCRCProvider(EnumCRCProvider.CRC16Modbus);
            CRCStatus status = crc.GetCRC(input);
            return status.CrcArray;
        }

        private SerialPort comDevice;
    }
}
