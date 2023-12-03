using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiuiu.SikachevaEA.Sprint6.Task2.V11.Lib;


namespace Tiuiu.SikachevaEA.Sprint6.Task2.V11
{
    public partial class FormMainTask2_SEA : Form
    {
        public FormMainTask2_SEA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_SEA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_SEA.Text);
                int stopStep = Convert.ToInt32(textBoxEnd_SEA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartData_SEA.Titles.Add("График функции sin(x)");
                this.chartData_SEA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartData_SEA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_SEA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    
                    this.chartData_SEA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введен неправильный диапазон", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_SEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы РПСб-23-1 Сикачева Елизавета Александровна", "Сообщение");
        }

        private void buttonDone_SEA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SEA.BackColor = Color.Red;
        }

        private void buttonDone_SEA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SEA.BackColor = Color.Green;
        }

        private void buttonDone_SEA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SEA.BackColor = Color.Blue;
        }

    }
}
