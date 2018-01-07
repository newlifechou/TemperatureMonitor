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
        }
    }
}