using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tako.CRC;

namespace TestSerialPort
{
    /// <summary>
    /// 串口帮助类
    /// </summary>
    public static class SerialPortHelper
    {
        /// <summary>
        /// 6组双位16进制字符串转换为字符数组并添加CRC16_MODBUS校验
        /// </summary>
        /// <param name="hexString">6组双位16进制字符串</param>
        /// <returns></returns>
        public static byte[] HexStringToBytes(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            int strlen = hexString.Length / 2;
            if (strlen != 6)
                throw new FormatException("协议命令格式必须是6位16进制数组成的字符串，例如01 03 01 F4 00 02");

            byte[] crc = CRC16MODBUSArray(hexString);
            byte[] data = new byte[strlen + 2];

            for (int i = 0; i < strlen; i++)
            {
                byte b = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                data[i] = b;
            }
            //倒序追加
            data[6] = crc[1];
            data[7] = crc[0];
            return data;
        }
        /// <summary>
        /// 字节数组转化为16进制的双位字符串
        /// </summary>
        /// <param name="data">字节数组</param>
        /// <returns></returns>
        public static string BytesToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.AppendFormat("{0:x2}", data[i]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 使用了Toko.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        #region CRC校验方法区
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
        #endregion

    }
}
