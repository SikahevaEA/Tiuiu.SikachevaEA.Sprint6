
namespace Tiuiu.SikachevaEA.Sprint6.Task3.V4
{
    partial class FormMainTask3_SEA
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
            this.textBoxTask_SEA = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_SEA = new System.Windows.Forms.DataGridView();
            this.textBoxCondition_SEA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_SEA = new System.Windows.Forms.GroupBox();
            this.labelResult_SEA = new System.Windows.Forms.Label();
            this.buttonHelp_SEA = new System.Windows.Forms.Button();
            this.buttonDone_SEA = new System.Windows.Forms.Button();
            this.dataGridViewMatrixResult_SEA = new System.Windows.Forms.DataGridView();
            this.textBoxTask_SEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SEA)).BeginInit();
            this.groupBoxResult_SEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_SEA)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTask_SEA
            // 
            this.textBoxTask_SEA.Controls.Add(this.dataGridViewMatrix_SEA);
            this.textBoxTask_SEA.Controls.Add(this.textBoxCondition_SEA);
            this.textBoxTask_SEA.Location = new System.Drawing.Point(13, 23);
            this.textBoxTask_SEA.Name = "textBoxTask_SEA";
            this.textBoxTask_SEA.Size = new System.Drawing.Size(867, 538);
            this.textBoxTask_SEA.TabIndex = 0;
            this.textBoxTask_SEA.TabStop = false;
            this.textBoxTask_SEA.Text = "Условие";
            // 
            // dataGridViewMatrix_SEA
            // 
            this.dataGridViewMatrix_SEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SEA.Location = new System.Drawing.Point(427, 31);
            this.dataGridViewMatrix_SEA.Name = "dataGridViewMatrix_SEA";
            this.dataGridViewMatrix_SEA.ReadOnly = true;
            this.dataGridViewMatrix_SEA.RowHeadersVisible = false;
            this.dataGridViewMatrix_SEA.RowHeadersWidth = 82;
            this.dataGridViewMatrix_SEA.RowTemplate.Height = 33;
            this.dataGridViewMatrix_SEA.Size = new System.Drawing.Size(429, 494);
            this.dataGridViewMatrix_SEA.TabIndex = 1;
            // 
            // textBoxCondition_SEA
            // 
            this.textBoxCondition_SEA.Location = new System.Drawing.Point(7, 31);
            this.textBoxCondition_SEA.Multiline = true;
            this.textBoxCondition_SEA.Name = "textBoxCondition_SEA";
            this.textBoxCondition_SEA.ReadOnly = true;
            this.textBoxCondition_SEA.Size = new System.Drawing.Size(396, 494);
            this.textBoxCondition_SEA.TabIndex = 0;
            this.textBoxCondition_SEA.Text = "Дана матрица 5 на 5 \r\n-14  -7  18  12 -20\r\n -2 -15 -19 -19  -3\r\n -18 -5 -10 14 -1" +
    "7\r\n -1  2 -10  0  11\r\n 6 -18  0 19 16\r\nЗаменить четные значения во второй строке" +
    " на 0.";
            // 
            // groupBoxResult_SEA
            // 
            this.groupBoxResult_SEA.Controls.Add(this.dataGridViewMatrixResult_SEA);
            this.groupBoxResult_SEA.Controls.Add(this.labelResult_SEA);
            this.groupBoxResult_SEA.Controls.Add(this.buttonHelp_SEA);
            this.groupBoxResult_SEA.Controls.Add(this.buttonDone_SEA);
            this.groupBoxResult_SEA.Location = new System.Drawing.Point(886, 23);
            this.groupBoxResult_SEA.Name = "groupBoxResult_SEA";
            this.groupBoxResult_SEA.Size = new System.Drawing.Size(500, 538);
            this.groupBoxResult_SEA.TabIndex = 2;
            this.groupBoxResult_SEA.TabStop = false;
            this.groupBoxResult_SEA.Text = "Вывод данных";
            // 
            // labelResult_SEA
            // 
            this.labelResult_SEA.AutoSize = true;
            this.labelResult_SEA.Location = new System.Drawing.Point(7, 31);
            this.labelResult_SEA.Name = "labelResult_SEA";
            this.labelResult_SEA.Size = new System.Drawing.Size(121, 25);
            this.labelResult_SEA.TabIndex = 5;
            this.labelResult_SEA.Text = "Результат:";
            // 
            // buttonHelp_SEA
            // 
            this.buttonHelp_SEA.Location = new System.Drawing.Point(6, 421);
            this.buttonHelp_SEA.Name = "buttonHelp_SEA";
            this.buttonHelp_SEA.Size = new System.Drawing.Size(103, 89);
            this.buttonHelp_SEA.TabIndex = 3;
            this.buttonHelp_SEA.Text = "?";
            this.buttonHelp_SEA.UseVisualStyleBackColor = true;
            this.buttonHelp_SEA.Click += new System.EventHandler(this.buttonHelp_SEA_Click);
            // 
            // buttonDone_SEA
            // 
            this.buttonDone_SEA.Location = new System.Drawing.Point(128, 421);
            this.buttonDone_SEA.Name = "buttonDone_SEA";
            this.buttonDone_SEA.Size = new System.Drawing.Size(146, 89);
            this.buttonDone_SEA.TabIndex = 4;
            this.buttonDone_SEA.Text = "Выполнить";
            this.buttonDone_SEA.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMatrixResult_SEA
            // 
            this.dataGridViewMatrixResult_SEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixResult_SEA.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewMatrixResult_SEA.Name = "dataGridViewMatrixResult_SEA";
            this.dataGridViewMatrixResult_SEA.RowHeadersWidth = 82;
            this.dataGridViewMatrixResult_SEA.RowTemplate.Height = 33;
            this.dataGridViewMatrixResult_SEA.Size = new System.Drawing.Size(482, 355);
            this.dataGridViewMatrixResult_SEA.TabIndex = 6;
            //this.dataGridViewMatrixResult_SEA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrixResult_SEA_CellContentClick);
            // 
            // FormMainTask3_SEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 573);
            this.Controls.Add(this.textBoxTask_SEA);
            this.Controls.Add(this.groupBoxResult_SEA);
            this.Name = "FormMainTask3_SEA";
            this.Text = "Спиринт 6 || Таск 3 || Вариант 4 || Сикачёва Е. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.textBoxTask_SEA.ResumeLayout(false);
            this.textBoxTask_SEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SEA)).EndInit();
            this.groupBoxResult_SEA.ResumeLayout(false);
            this.groupBoxResult_SEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_SEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox textBoxTask_SEA;
        private System.Windows.Forms.Button buttonDone_SEA;
        private System.Windows.Forms.Button buttonHelp_SEA;
        private System.Windows.Forms.GroupBox groupBoxResult_SEA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SEA;
        private System.Windows.Forms.TextBox textBoxCondition_SEA;
        private System.Windows.Forms.Label labelResult_SEA;
        private System.Windows.Forms.DataGridView dataGridViewMatrixResult_SEA;
    }
}

