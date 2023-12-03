using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiuiu.SikachevaEA.Sprint6.Task0.V6.Lib;

namespace Tiuiu.SikachevaEA.Sprint6.Task0.V6
{
    public partial class FormMainTask0EA : Form
    {
        public FormMainTask0EA()
        {
            InitializeComponent();
        }

        private void buttonPushMe_SEA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_SEA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxPositionWinX_SEA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPositionWinX_SEA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 3) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonQuestion_SEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы РПСб-23-1 Сикачева Елизавета Александровна", "Сообщение");
        }

       
    }
}
