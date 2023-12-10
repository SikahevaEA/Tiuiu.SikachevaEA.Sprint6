
namespace Tiuiu.SikachevaEA.Sprint6.Task7.V25
{
    partial class FormMainTask7_SEA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainTask7_SEA));
            this.buttonOpen_SEA = new System.Windows.Forms.Button();
            this.buttonDone_SEA = new System.Windows.Forms.Button();
            this.buttonSeve_SEA = new System.Windows.Forms.Button();
            this.buttonHelp_SEA = new System.Windows.Forms.Button();
            this.textBoxTask_SEA = new System.Windows.Forms.GroupBox();
            this.textBoxTask7_SEA = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_SEA = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_SEA = new System.Windows.Forms.DataGridView();
            this.groupBoxOutPutData_SEA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_SEA = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask7_SEA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_SEA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_SEA = new System.Windows.Forms.SaveFileDialog();
            this.textBoxTask_SEA.SuspendLayout();
            this.groupBoxInPutData_SEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_SEA)).BeginInit();
            this.groupBoxOutPutData_SEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_SEA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpen_SEA
            // 
            this.buttonOpen_SEA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonOpen_SEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_SEA.Image")));
            this.buttonOpen_SEA.Location = new System.Drawing.Point(13, 13);
            this.buttonOpen_SEA.Name = "buttonOpen_SEA";
            this.buttonOpen_SEA.Size = new System.Drawing.Size(134, 111);
            this.buttonOpen_SEA.TabIndex = 0;
            this.toolTipButton_SEA.SetToolTip(this.buttonOpen_SEA, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpen_SEA.UseVisualStyleBackColor = false;
            this.buttonOpen_SEA.Click += new System.EventHandler(this.buttonOpen_SEA_Click);
            this.buttonOpen_SEA.MouseEnter += new System.EventHandler(this.buttonOpen_SEA_MouseEnter);
            // 
            // buttonDone_SEA
            // 
            this.buttonDone_SEA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonDone_SEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SEA.Image")));
            this.buttonDone_SEA.Location = new System.Drawing.Point(153, 12);
            this.buttonDone_SEA.Name = "buttonDone_SEA";
            this.buttonDone_SEA.Size = new System.Drawing.Size(160, 112);
            this.buttonDone_SEA.TabIndex = 1;
            this.toolTipButton_SEA.SetToolTip(this.buttonDone_SEA, "Изменяет в седьмом столбце матрицы элементы кратные 5 на 2 ");
            this.buttonDone_SEA.UseVisualStyleBackColor = false;
            this.buttonDone_SEA.Click += new System.EventHandler(this.buttonDone_SEA_Click);
            this.buttonDone_SEA.MouseEnter += new System.EventHandler(this.buttonDone_SEA_MouseEnter);
            // 
            // buttonSeve_SEA
            // 
            this.buttonSeve_SEA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSeve_SEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSeve_SEA.Image")));
            this.buttonSeve_SEA.Location = new System.Drawing.Point(319, 12);
            this.buttonSeve_SEA.Name = "buttonSeve_SEA";
            this.buttonSeve_SEA.Size = new System.Drawing.Size(174, 112);
            this.buttonSeve_SEA.TabIndex = 2;
            this.toolTipButton_SEA.SetToolTip(this.buttonSeve_SEA, "Сохраняет результат в файл OutPutFileTask7");
            this.buttonSeve_SEA.UseVisualStyleBackColor = false;
            this.buttonSeve_SEA.Click += new System.EventHandler(this.buttonSeve_SEA_Click);
            this.buttonSeve_SEA.MouseEnter += new System.EventHandler(this.buttonSeve_SEA_MouseEnter);
            // 
            // buttonHelp_SEA
            // 
            this.buttonHelp_SEA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonHelp_SEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SEA.Image")));
            this.buttonHelp_SEA.Location = new System.Drawing.Point(1332, 13);
            this.buttonHelp_SEA.Name = "buttonHelp_SEA";
            this.buttonHelp_SEA.Size = new System.Drawing.Size(147, 111);
            this.buttonHelp_SEA.TabIndex = 3;
            this.buttonHelp_SEA.UseVisualStyleBackColor = false;
            this.buttonHelp_SEA.Click += new System.EventHandler(this.buttonHelp_SEA_Click);
            this.buttonHelp_SEA.MouseEnter += new System.EventHandler(this.buttonHelp_SEA_MouseEnter);
            // 
            // textBoxTask_SEA
            // 
            this.textBoxTask_SEA.Controls.Add(this.textBoxTask7_SEA);
            this.textBoxTask_SEA.Location = new System.Drawing.Point(13, 130);
            this.textBoxTask_SEA.Name = "textBoxTask_SEA";
            this.textBoxTask_SEA.Size = new System.Drawing.Size(1472, 140);
            this.textBoxTask_SEA.TabIndex = 4;
            this.textBoxTask_SEA.TabStop = false;
            this.textBoxTask_SEA.Text = "Условие";
            // 
            // textBoxTask7_SEA
            // 
            this.textBoxTask7_SEA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask7_SEA.Location = new System.Drawing.Point(7, 30);
            this.textBoxTask7_SEA.Multiline = true;
            this.textBoxTask7_SEA.Name = "textBoxTask7_SEA";
            this.textBoxTask7_SEA.ReadOnly = true;
            this.textBoxTask7_SEA.Size = new System.Drawing.Size(1459, 104);
            this.textBoxTask7_SEA.TabIndex = 0;
            this.textBoxTask7_SEA.Text = resources.GetString("textBoxTask7_SEA.Text");
            // 
            // groupBoxInPutData_SEA
            // 
            this.groupBoxInPutData_SEA.Controls.Add(this.dataGridViewIn_SEA);
            this.groupBoxInPutData_SEA.Location = new System.Drawing.Point(19, 276);
            this.groupBoxInPutData_SEA.Name = "groupBoxInPutData_SEA";
            this.groupBoxInPutData_SEA.Size = new System.Drawing.Size(730, 590);
            this.groupBoxInPutData_SEA.TabIndex = 5;
            this.groupBoxInPutData_SEA.TabStop = false;
            this.groupBoxInPutData_SEA.Text = "Ввод:";
            // 
            // dataGridViewIn_SEA
            // 
            this.dataGridViewIn_SEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_SEA.Location = new System.Drawing.Point(6, 31);
            this.dataGridViewIn_SEA.Name = "dataGridViewIn_SEA";
            this.dataGridViewIn_SEA.ReadOnly = true;
            this.dataGridViewIn_SEA.RowHeadersVisible = false;
            this.dataGridViewIn_SEA.RowHeadersWidth = 82;
            this.dataGridViewIn_SEA.RowTemplate.Height = 33;
            this.dataGridViewIn_SEA.Size = new System.Drawing.Size(711, 553);
            this.dataGridViewIn_SEA.TabIndex = 0;
            // 
            // groupBoxOutPutData_SEA
            // 
            this.groupBoxOutPutData_SEA.Controls.Add(this.dataGridViewOut_SEA);
            this.groupBoxOutPutData_SEA.Location = new System.Drawing.Point(755, 282);
            this.groupBoxOutPutData_SEA.Name = "groupBoxOutPutData_SEA";
            this.groupBoxOutPutData_SEA.Size = new System.Drawing.Size(724, 584);
            this.groupBoxOutPutData_SEA.TabIndex = 6;
            this.groupBoxOutPutData_SEA.TabStop = false;
            this.groupBoxOutPutData_SEA.Text = "Вывод:";
            // 
            // dataGridViewOut_SEA
            // 
            this.dataGridViewOut_SEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_SEA.Location = new System.Drawing.Point(6, 31);
            this.dataGridViewOut_SEA.Name = "dataGridViewOut_SEA";
            this.dataGridViewOut_SEA.ReadOnly = true;
            this.dataGridViewOut_SEA.RowHeadersVisible = false;
            this.dataGridViewOut_SEA.RowHeadersWidth = 82;
            this.dataGridViewOut_SEA.RowTemplate.Height = 33;
            this.dataGridViewOut_SEA.Size = new System.Drawing.Size(712, 547);
            this.dataGridViewOut_SEA.TabIndex = 0;
            // 
            // openFileDialogTask7_SEA
            // 
            this.openFileDialogTask7_SEA.FileName = "openFileDialog1";
            // 
            // toolTipButton_SEA
            // 
            this.toolTipButton_SEA.IsBalloon = true;
            this.toolTipButton_SEA.ToolTipTitle = "Подсказка";
            // 
            // FormMainTask7_SEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1491, 896);
            this.Controls.Add(this.groupBoxOutPutData_SEA);
            this.Controls.Add(this.groupBoxInPutData_SEA);
            this.Controls.Add(this.textBoxTask_SEA);
            this.Controls.Add(this.buttonHelp_SEA);
            this.Controls.Add(this.buttonSeve_SEA);
            this.Controls.Add(this.buttonDone_SEA);
            this.Controls.Add(this.buttonOpen_SEA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMainTask7_SEA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спиринт 6 || Таск 7 || Вариант 25 || Сикачёва Е. А.";
            this.textBoxTask_SEA.ResumeLayout(false);
            this.textBoxTask_SEA.PerformLayout();
            this.groupBoxInPutData_SEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_SEA)).EndInit();
            this.groupBoxOutPutData_SEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_SEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen_SEA;
        private System.Windows.Forms.Button buttonDone_SEA;
        private System.Windows.Forms.Button buttonSeve_SEA;
        private System.Windows.Forms.Button buttonHelp_SEA;
        private System.Windows.Forms.GroupBox textBoxTask_SEA;
        private System.Windows.Forms.TextBox textBoxTask7_SEA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_SEA;
        private System.Windows.Forms.DataGridView dataGridViewIn_SEA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_SEA;
        private System.Windows.Forms.DataGridView dataGridViewOut_SEA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask7_SEA;
        private System.Windows.Forms.ToolTip toolTipButton_SEA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SEA;
    }
}

