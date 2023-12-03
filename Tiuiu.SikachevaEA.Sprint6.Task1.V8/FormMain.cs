using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiuiu.SikachevaEA.Sprint6.Task1.V8.Lib;

namespace Tiuiu.SikachevaEA.Sprint6.Task1.V8
{
    public partial class FormMainTask1_SEA : Form
    {
        public FormMainTask1_SEA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_SEA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_SEA.Text);
                int stopValue = Convert.ToInt32(textBoxEnd_SEA.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_SEA.Text = "";
                textBoxResult_SEA.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxResult_SEA.AppendText("|     X    |    f(x)    |" + Environment.NewLine);
                textBoxResult_SEA.AppendText("+----------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}   |", startValue, valueArray[i]);
                    textBoxResult_SEA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_SEA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonHelp_SEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы РПСб-23-1 Сикачева Елизавета Александровна", "Сообщение");
        }

        
    }
}
