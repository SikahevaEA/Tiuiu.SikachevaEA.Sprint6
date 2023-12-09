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
        int[,] matrix = new int[5, 5] { {  -14,-7,18,12,-20 },
                                         { -2,-15,-19,-19,-3 },
                                         { -18,-5,-10,14,-17 },
                                         { -1,2,-10,0,11 },
                                         { 6,-18,0,19,16 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix_SEA.ColumnCount = columns;
            dataGridViewMatrix_SEA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_SEA.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SEA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    

        private void buttonDone_SEA_Click(object sender, EventArgs e)
        {
            int[,] mtrx = ds.Calculate(matrix);
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrixResult_SEA.ColumnCount = columns;
            dataGridViewMatrixResult_SEA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixResult_SEA.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixResult_SEA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
        private void buttonHelp_SEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы РПСб-23-1 Сикачева Елизавета Александровна", "Сообщение");
        }
    }
}
