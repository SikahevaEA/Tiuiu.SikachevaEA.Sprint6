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
using Tiuiu.SikachevaEA.Sprint6.Task7.V25.Lib;

namespace Tiuiu.SikachevaEA.Sprint6.Task7.V25
{
    public partial class FormMainTask7_SEA : Form
    {
        public FormMainTask7_SEA()
        {
            InitializeComponent();
            openFileDialogTask7_SEA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogMatrix_SEA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromFileData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonOpen_SEA_Click(object sender, EventArgs e)
        {
            openFileDialogTask7_SEA.ShowDialog();
            openFile = openFileDialogTask7_SEA.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFile);

            dataGridViewIn_SEA.RowCount = rows;
            dataGridViewIn_SEA.ColumnCount = columns;
            dataGridViewOut_SEA.RowCount = rows;
            dataGridViewOut_SEA.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_SEA.Columns[i].Width = 25;
                dataGridViewOut_SEA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_SEA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone_SEA.Enabled = true;
        }

        private void buttonDone_SEA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_SEA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSeve_SEA.Enabled = true;
        }

        private void buttonSeve_SEA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SEA.FileName = "OutPutFileTask7.V25.csv";
            saveFileDialogMatrix_SEA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SEA.ShowDialog();

            string path = saveFileDialogMatrix_SEA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_SEA.RowCount;
            int columns = dataGridViewOut_SEA.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewIn_SEA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewIn_SEA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_SEA_Click(object sender, EventArgs e)
        {
            FormAboutInfo_SEA formabout = new FormAboutInfo_SEA();
            formabout.ShowDialog();
        }

        private void buttonOpen_SEA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SEA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_SEA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SEA.ToolTipTitle = "Выполнить";
        }

        private void buttonSeve_SEA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SEA.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_SEA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SEA.ToolTipTitle = "Справка";
        }
    }
}
