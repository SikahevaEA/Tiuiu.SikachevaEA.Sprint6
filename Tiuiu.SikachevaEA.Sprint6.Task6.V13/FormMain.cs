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
using Tiuiu.SikachevaEA.Sprint6.Task6.V13.Lib;

namespace Tiuiu.SikachevaEA.Sprint6.Task6.V13
{
    public partial class FormMainTask6_SEA : Form
    {
        public FormMainTask6_SEA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path;
        private void buttonHelp_SEA_Click(object sender, EventArgs e)
        {
            FormAboutTask6_SEA formAbout = new FormAboutTask6_SEA();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_SEA_Click(object sender, EventArgs e)
        {
            openFileDialogTask6_SEA.ShowDialog();
            path = openFileDialogTask6_SEA.FileName;
            textBoxData_SEA.Text = File.ReadAllText(path);
            groupBoxOutPutData_SEA.Text = groupBoxOutPutData_SEA.Text + " " + openFileDialogTask6_SEA.FileName;
            buttonDone_SEA.Enabled = true;
        }

        private void buttonDone_SEA_Click(object sender, EventArgs e)
        {
            textBoxResult_SEA.Text = ds.CollectTextFromFile(path);
        }
    }
}
