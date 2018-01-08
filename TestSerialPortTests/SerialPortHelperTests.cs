using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSerialPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSerialPort.Tests
{
    [TestClass()]
    public class SerialPortHelperTests
    {
        [TestMethod()]
        public void HexStringToBytesTest()
        {
            string hexString = "01 03 01 F4 00 02";
            byte[] data = SerialPortHelper.HexStringToBytes(hexString);

            Assert.AreEqual(1, data[0]);
            Assert.AreEqual(3, data[1]);
            Assert.AreEqual(1, data[2]);
            Assert.AreEqual(244, data[3]);
            Assert.AreEqual(0, data[4]);
            Assert.AreEqual(2, data[5]);
            Assert.AreEqual(132, data[6]);
            Assert.AreEqual(5, data[7]);
        }

        [TestMethod()]
        public void BytesToHexStringTest()
        {
            byte[] data = new byte[8];
            data[0] = 1;
            data[1] = 3;
            data[2] = 1;
            data[3] = 244;
            data[4] = 0;
            data[5] = 2;
            data[6] = 132;
            data[7] = 5;

            string hexString = "010301F400028405";

            string result = SerialPortHelper.BytesToHexString(data);
            Assert.AreEqual(hexString.ToLower(), result);
        }
    }
}