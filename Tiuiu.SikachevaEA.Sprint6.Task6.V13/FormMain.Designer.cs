
namespace Tiuiu.SikachevaEA.Sprint6.Task6.V13
{
    partial class FormMainTask6_SEA
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainTask6_SEA));
            this.textBoxTask_SEA = new System.Windows.Forms.GroupBox();
            this.textBoxTask6_SEA = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_SEA = new System.Windows.Forms.GroupBox();
            this.textBoxData_SEA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_SEA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SEA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask6_SEA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipTask6_SEA = new System.Windows.Forms.ToolTip(this.components);
            this.buttonOpenFile_SEA = new System.Windows.Forms.Button();
            this.buttonDone_SEA = new System.Windows.Forms.Button();
            this.buttonHelp_SEA = new System.Windows.Forms.Button();
            this.textBoxTask_SEA.SuspendLayout();
            this.groupBoxInPutData_SEA.SuspendLayout();
            this.groupBoxOutPutData_SEA.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTask_SEA
            // 
            this.textBoxTask_SEA.Controls.Add(this.textBoxTask6_SEA);
            this.textBoxTask_SEA.Location = new System.Drawing.Point(12, 135);
            this.textBoxTask_SEA.Name = "textBoxTask_SEA";
            this.textBoxTask_SEA.Size = new System.Drawing.Size(1191, 140);
            this.textBoxTask_SEA.TabIndex = 0;
            this.textBoxTask_SEA.TabStop = false;
            this.textBoxTask_SEA.Text = "Условие";
            // 
            // textBoxTask6_SEA
            // 
            this.textBoxTask6_SEA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask6_SEA.Location = new System.Drawing.Point(7, 30);
            this.textBoxTask6_SEA.Multiline = true;
            this.textBoxTask6_SEA.Name = "textBoxTask6_SEA";
            this.textBoxTask6_SEA.ReadOnly = true;
            this.textBoxTask6_SEA.Size = new System.Drawing.Size(1178, 104);
            this.textBoxTask6_SEA.TabIndex = 0;
            this.textBoxTask6_SEA.Text = resources.GetString("textBoxTask6_SEA.Text");
            // 
            // groupBoxInPutData_SEA
            // 
            this.groupBoxInPutData_SEA.Controls.Add(this.textBoxData_SEA);
            this.groupBoxInPutData_SEA.Location = new System.Drawing.Point(12, 275);
            this.groupBoxInPutData_SEA.Name = "groupBoxInPutData_SEA";
            this.groupBoxInPutData_SEA.Size = new System.Drawing.Size(564, 675);
            this.groupBoxInPutData_SEA.TabIndex = 1;
            this.groupBoxInPutData_SEA.TabStop = false;
            this.groupBoxInPutData_SEA.Text = "Ввод данных";
            // 
            // textBoxData_SEA
            // 
            this.textBoxData_SEA.Location = new System.Drawing.Point(7, 31);
            this.textBoxData_SEA.Multiline = true;
            this.textBoxData_SEA.Name = "textBoxData_SEA";
            this.textBoxData_SEA.ReadOnly = true;
            this.textBoxData_SEA.Size = new System.Drawing.Size(551, 631);
            this.textBoxData_SEA.TabIndex = 0;
            // 
            // groupBoxOutPutData_SEA
            // 
            this.groupBoxOutPutData_SEA.Controls.Add(this.textBoxResult_SEA);
            this.groupBoxOutPutData_SEA.Location = new System.Drawing.Point(583, 275);
            this.groupBoxOutPutData_SEA.Name = "groupBoxOutPutData_SEA";
            this.groupBoxOutPutData_SEA.Size = new System.Drawing.Size(621, 675);
            this.groupBoxOutPutData_SEA.TabIndex = 2;
            this.groupBoxOutPutData_SEA.TabStop = false;
            this.groupBoxOutPutData_SEA.Text = "Вывод данных";
            // 
            // textBoxResult_SEA
            // 
            this.textBoxResult_SEA.Location = new System.Drawing.Point(8, 30);
            this.textBoxResult_SEA.Multiline = true;
            this.textBoxResult_SEA.Name = "textBoxResult_SEA";
            this.textBoxResult_SEA.ReadOnly = true;
            this.textBoxResult_SEA.Size = new System.Drawing.Size(607, 621);
            this.textBoxResult_SEA.TabIndex = 0;
            // 
            // openFileDialogTask6_SEA
            // 
            this.openFileDialogTask6_SEA.FileName = "openFileDialog1";
            // 
            // toolTipTask6_SEA
            // 
            this.toolTipTask6_SEA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipTask6_SEA.ToolTipTitle = "Подсказка";
            // 
            // buttonOpenFile_SEA
            // 
            this.buttonOpenFile_SEA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenFile_SEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SEA.Image")));
            this.buttonOpenFile_SEA.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_SEA.Name = "buttonOpenFile_SEA";
            this.buttonOpenFile_SEA.Size = new System.Drawing.Size(123, 101);
            this.buttonOpenFile_SEA.TabIndex = 7;
            this.toolTipTask6_SEA.SetToolTip(this.buttonOpenFile_SEA, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_SEA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_SEA.Click += new System.EventHandler(this.buttonOpenFile_SEA_Click);
            // 
            // buttonDone_SEA
            // 
            this.buttonDone_SEA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonDone_SEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SEA.Image")));
            this.buttonDone_SEA.Location = new System.Drawing.Point(141, 12);
            this.buttonDone_SEA.Name = "buttonDone_SEA";
            this.buttonDone_SEA.Size = new System.Drawing.Size(152, 100);
            this.buttonDone_SEA.TabIndex = 8;
            this.toolTipTask6_SEA.SetToolTip(this.buttonDone_SEA, "Производит поиск предпоследнего слова в каждой строке");
            this.buttonDone_SEA.UseVisualStyleBackColor = false;
            this.buttonDone_SEA.Click += new System.EventHandler(this.buttonDone_SEA_Click);
            // 
            // buttonHelp_SEA
            // 
            this.buttonHelp_SEA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonHelp_SEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SEA.Image")));
            this.buttonHelp_SEA.Location = new System.Drawing.Point(1064, 13);
            this.buttonHelp_SEA.Name = "buttonHelp_SEA";
            this.buttonHelp_SEA.Size = new System.Drawing.Size(133, 116);
            this.buttonHelp_SEA.TabIndex = 9;
            this.toolTipTask6_SEA.SetToolTip(this.buttonHelp_SEA, "Сведенья о программе");
            this.buttonHelp_SEA.UseVisualStyleBackColor = false;
            this.buttonHelp_SEA.Click += new System.EventHandler(this.buttonHelp_SEA_Click);
            // 
            // FormMainTask6_SEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1216, 962);
            this.Controls.Add(this.buttonHelp_SEA);
            this.Controls.Add(this.buttonDone_SEA);
            this.Controls.Add(this.buttonOpenFile_SEA);
            this.Controls.Add(this.groupBoxOutPutData_SEA);
            this.Controls.Add(this.groupBoxInPutData_SEA);
            this.Controls.Add(this.textBoxTask_SEA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMainTask6_SEA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спиринт 6 || Таск 6 || Вариант 13 || Сикачёва Е. А.";
            this.textBoxTask_SEA.ResumeLayout(false);
            this.textBoxTask_SEA.PerformLayout();
            this.groupBoxInPutData_SEA.ResumeLayout(false);
            this.groupBoxInPutData_SEA.PerformLayout();
            this.groupBoxOutPutData_SEA.ResumeLayout(false);
            this.groupBoxOutPutData_SEA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox textBoxTask_SEA;
        private System.Windows.Forms.TextBox textBoxTask6_SEA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_SEA;
        private System.Windows.Forms.TextBox textBoxData_SEA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_SEA;
        private System.Windows.Forms.TextBox textBoxResult_SEA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask6_SEA;
        private System.Windows.Forms.ToolTip toolTipTask6_SEA;
        private System.Windows.Forms.Button buttonOpenFile_SEA;
        private System.Windows.Forms.Button buttonDone_SEA;
        private System.Windows.Forms.Button buttonHelp_SEA;
    }
}

