using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSerialPort
{
    public class Temperature_Humidity
    {
        private string ReadStr;
        private SerialPortLib portLib;
        public Temperature_Humidity()
        {
            ReadStr = "010301F40002";
            portLib = new SerialPortLib();
            //COM5
            portLib.SetSerialPort(2);
        }
        public void Open()
        {
            portLib.OpenPort();
        }
        public void Close()
        {
            portLib.ClosePort();
        }
        /// <summary>
        /// 获取原始温湿度数据
        /// </summary>
        /// <returns></returns>
        private string GetRawData()
        {
            byte[] readCmd = BuildSendMessage();

            portLib.SendData(readCmd);
            return null;
        }

        /// <summary>
        /// 获取TDData
        /// </summary>
        /// <returns></returns>
        public THData GetTHData()
        {
            GetRawData();
            THData data = new THData();
            return data;
        }


        public byte[] BuildSendMessage()
        {
            byte[] send = new byte[8];
            byte[] crc = portLib.CRC16MODBUSArray(ReadStr);
            send[0] = 0x01;
            send[1] = 0x03;
            send[2] = 0x01;
            send[3] = 0xF4;
            send[4] = 0x00;
            send[5] = 0x02;
            send[6] = 0x84;
            send[7] = 0x05;

            return send;
        }
    }
}
