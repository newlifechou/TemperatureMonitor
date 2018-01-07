using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tako.CRC;

namespace TestSerialPort
{
    public static class SerialPortHelper
    {
        public static byte[] HexStringToBytes(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if (hexString.Length/2!=6)
                throw new FormatException("协议命令格式必须是6位16进制数组成的字符串，例如01 03 01 F4 00 02");

            byte[] crc = CRC16MODBUSArray(hexString);
            byte[] data = new byte[8];

            for (int i = 0; i < hexString.Length / 2; i++)
            {
                byte b = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                data[i] = b;
            }
            data[6] = crc[1];
            data[7] = crc[0];
            return data;
        }

        public static string BytesToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.AppendFormat("{0:x2}", data[i]);
            }
            return sb.ToString();
        }


        public static string CRC16MODBUS(string input)
        {
            CRCManager manager = new CRCManager();
            CRCProviderBase crc = manager.CreateCRCProvider(EnumCRCProvider.CRC16Modbus);
            CRCStatus status = crc.GetCRC(input);
            return status.CrcHexadecimal;
        }
        public static byte[] CRC16MODBUSArray(string input)
        {
            CRCManager manager = new CRCManager();
            CRCProviderBase crc = manager.CreateCRCProvider(EnumCRCProvider.CRC16Modbus);
            CRCStatus status = crc.GetCRC(input);
            return status.CrcArray;
        }
    }
}
