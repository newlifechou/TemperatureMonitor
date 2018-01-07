using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSerialPort
{
    public interface ISerialPort
    {
        void GetSerialPortNames();
        string GetCRC16MODBUS(string firstPart);
        byte[] GetHexBytes(string hexString);

        void OpenPort();
        void ClosePort();
        void SetPort(string comName);

        void Write(string planText);
        void Write(byte[] byteData);
        

    }
}
