﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiuiu.SikachevaEA.Sprint6.Task1.V8.Lib;

namespace Tiuiu.SikachevaEA.Sprint6.Task1.V8
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainTask1_SEA());
        }
    }
}