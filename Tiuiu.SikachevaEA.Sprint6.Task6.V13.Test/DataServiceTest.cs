using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tiuiu.SikachevaEA.Sprint6.Task6.V13.Lib;

namespace Tiuiu.SikachevaEA.Sprint6.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V13.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
