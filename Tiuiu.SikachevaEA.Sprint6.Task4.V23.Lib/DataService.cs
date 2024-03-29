﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tiuiu.SikachevaEA.Sprint6.Task4.V23.Lib
{
    public class DataService : ISprint6Task4V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2), 2);
                if (!double.IsNaN(y) && !double.IsInfinity(y))
                {
                    valueArray[count] = y;
                }
                else
                {
                    valueArray[count] = 0;
                }
                count++;
            }
            return valueArray;
        }
    }
}
