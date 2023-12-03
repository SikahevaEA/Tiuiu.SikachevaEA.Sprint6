using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiuiu.SikachevaEA.Sprint6.Task3.V4.Lib;

namespace Tiuiu.SikachevaEA.Sprint6.Task3.V4
{
    public partial class FormMainTask3_SEA : Form
    {
        public FormMainTask3_SEA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { {-17, -6, 10, 5, 3},
                                      {-10, -14, 10, -7, -3},
                                      {-19, 9, 8, -17, -9},
                                      {-19, -5, -9, -18, 14},
                                      {17, 12, 11, 12, 2} };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_SEA.ColumnCount = columns;
            dataGridViewMatrix_SEA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_SEA.Columns[i].Width = 25;
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SEA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_SEA_Click(object sender, EventArgs e)
        {
            var sorted_matrix = ds.Calculate(mtrx);

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrixResult_SEA.ColumnCount = columns;
            dataGridViewMatrixResult_SEA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixResult_SEA.Columns[i].Width = 25;
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixResult_SEA.Rows[i].Cells[j].Value = Convert.ToString(sorted_matrix[i, j]);
                }
            }
        }
        private void buttonHelp_SEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы РПСб-23-1 Сикачева Елизавета Александровна", "Сообщение");
        }
    }
}
