using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tiuiu.SikachevaEA.Sprint6.Task5.V17.Lib;

namespace Tiuiu.SikachevaEA.Sprint6.Task5.V17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V17.txt";
        private void buttonDone_SEA_Click(object sender, EventArgs e)
        {
            dataGridViewResult_SEA.ColumnCount = 2;
            dataGridViewResult_SEA.Columns[0].Width = 20;
            dataGridViewResult_SEA.Columns[1].Width = 50;

            this.chartFunction_SEA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_SEA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_SEA.Series[0].Points.Clear();

            double[] numArray = new double[ds.len];
            numArray = ds.LoadFromDataFile(path);
            for (int i = 0; i < numArray.Length; i++)
            {
                dataGridViewResult_SEA.Rows.Add(Convert.ToString(i), Convert.ToString(numArray[i]));
                chartFunction_SEA.Series[0].Points.AddXY(i, numArray[i]);
            }
        }

        private void buttonHelp_SEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы РПСб-23-1 Сикачева Елизавета Александровна", "Сообщение");
        }

        private void buttonSave_SEA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
