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
using Tiuiu.SikachevaEA.Sprint6.Task4.V23.Lib;

namespace Tiuiu.SikachevaEA.Sprint6.Task4.V23
{
    public partial class FormMain_SEA : Form
    {
        public FormMain_SEA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_SEA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_SEA.Text);
                int stopValue = Convert.ToInt32(textBoxStop_SEA.Text);

                string strLine;
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_SEA.Titles.Clear();
                this.chartFunction_SEA.Titles.Add("График функции");
                this.chartFunction_SEA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SEA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_SEA.Text = "";
                chartFunction_SEA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    textBoxResult_SEA.AppendText(valueArray[i] + Environment.NewLine);
                    this.chartFunction_SEA.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы РПСб-23-1 Сикачева Елизавета Александровна", "Сообщение");
        }

        private void buttonSave_SEA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V23.txt";
                File.WriteAllText(path, textBoxResult_SEA.Text);

                DialogResult dialogResult = MessageBox.Show($"Файл {path} сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
