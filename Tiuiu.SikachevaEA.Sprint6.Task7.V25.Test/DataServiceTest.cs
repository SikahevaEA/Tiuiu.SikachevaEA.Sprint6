using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tiuiu.SikachevaEA.Sprint6.Task7.V25.Lib;

namespace Tiuiu.SikachevaEA.Sprint6.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string openedFile = @"C:\Users\lizas\source\repos\Tiuiu.SikachevaEA.Sprint6\Tiuiu.SikachevaEA.Sprint6.Task7.V25\bin\Debug\InPutFileTask7V25.csv";
            FileInfo file = new FileInfo(openedFile);
            bool exists = file.Exists;
            Assert.AreEqual(true, exists);
        }
    }
}
