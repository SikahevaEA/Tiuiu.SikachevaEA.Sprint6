﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.SikachevaEA.Sprint6.Task2.V11.Lib;

namespace Tiuiu.SikachevaEA.Sprint6.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray = new double[stopValue - startValue + 1];
            valueWaitArray = new double[len];

            valueWaitArray[0] = -15.44;
            valueWaitArray[1] = -10.93;
            valueWaitArray[2] = -7.22;
            valueWaitArray[3] = -5.04;
            valueWaitArray[4] = 0;
            valueWaitArray[5] = -0.3;
            valueWaitArray[6] = 2.57;
            valueWaitArray[7] = 6.40;
            valueWaitArray[8] = 10.04;
            valueWaitArray[9] = 12.72;
            valueWaitArray[10] = 14.68;

            double[] res = new double[stopValue - startValue + 1];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
