
namespace Tiuiu.SikachevaEA.Sprint6.Task5.V17
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxTask_SEA = new System.Windows.Forms.GroupBox();
            this.textBoxTask5_SEA = new System.Windows.Forms.TextBox();
            this.buttonDone_SEA = new System.Windows.Forms.Button();
            this.buttonSave_SEA = new System.Windows.Forms.Button();
            this.buttonHelp_SEA = new System.Windows.Forms.Button();
            this.groupBoxDataOutPut_SEA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SEA = new System.Windows.Forms.DataGridView();
            this.chartFunction_SEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxTask_SEA.SuspendLayout();
            this.groupBoxDataOutPut_SEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SEA)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTask_SEA
            // 
            this.textBoxTask_SEA.Controls.Add(this.textBoxTask5_SEA);
            this.textBoxTask_SEA.Location = new System.Drawing.Point(12, 12);
            this.textBoxTask_SEA.Name = "textBoxTask_SEA";
            this.textBoxTask_SEA.Size = new System.Drawing.Size(900, 163);
            this.textBoxTask_SEA.TabIndex = 1;
            this.textBoxTask_SEA.TabStop = false;
            this.textBoxTask_SEA.Text = "Условие";
            // 
            // textBoxTask5_SEA
            // 
            this.textBoxTask5_SEA.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxTask5_SEA.Location = new System.Drawing.Point(13, 25);
            this.textBoxTask5_SEA.Multiline = true;
            this.textBoxTask5_SEA.Name = "textBoxTask5_SEA";
            this.textBoxTask5_SEA.ReadOnly = true;
            this.textBoxTask5_SEA.Size = new System.Drawing.Size(887, 132);
            this.textBoxTask5_SEA.TabIndex = 0;
            this.textBoxTask5_SEA.Text = resources.GetString("textBoxTask5_SEA.Text");
            // 
            // buttonDone_SEA
            // 
            this.buttonDone_SEA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SEA.Location = new System.Drawing.Point(918, 47);
            this.buttonDone_SEA.Name = "buttonDone_SEA";
            this.buttonDone_SEA.Size = new System.Drawing.Size(170, 91);
            this.buttonDone_SEA.TabIndex = 6;
            this.buttonDone_SEA.Text = "Выполнить";
            this.buttonDone_SEA.UseVisualStyleBackColor = false;
            this.buttonDone_SEA.Click += new System.EventHandler(this.buttonDone_SEA_Click);
            // 
            // buttonSave_SEA
            // 
            this.buttonSave_SEA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_SEA.Location = new System.Drawing.Point(1094, 47);
            this.buttonSave_SEA.Name = "buttonSave_SEA";
            this.buttonSave_SEA.Size = new System.Drawing.Size(134, 91);
            this.buttonSave_SEA.TabIndex = 7;
            this.buttonSave_SEA.Text = "Открыть файл";
            this.buttonSave_SEA.UseVisualStyleBackColor = false;
            this.buttonSave_SEA.Click += new System.EventHandler(this.buttonSave_SEA_Click);
            // 
            // buttonHelp_SEA
            // 
            this.buttonHelp_SEA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_SEA.Location = new System.Drawing.Point(1234, 47);
            this.buttonHelp_SEA.Name = "buttonHelp_SEA";
            this.buttonHelp_SEA.Size = new System.Drawing.Size(119, 91);
            this.buttonHelp_SEA.TabIndex = 8;
            this.buttonHelp_SEA.Text = "Справка";
            this.buttonHelp_SEA.UseVisualStyleBackColor = false;
            this.buttonHelp_SEA.Click += new System.EventHandler(this.buttonHelp_SEA_Click);
            // 
            // groupBoxDataOutPut_SEA
            // 
            this.groupBoxDataOutPut_SEA.Controls.Add(this.dataGridViewResult_SEA);
            this.groupBoxDataOutPut_SEA.Controls.Add(this.chartFunction_SEA);
            this.groupBoxDataOutPut_SEA.Location = new System.Drawing.Point(12, 197);
            this.groupBoxDataOutPut_SEA.Name = "groupBoxDataOutPut_SEA";
            this.groupBoxDataOutPut_SEA.Size = new System.Drawing.Size(1341, 879);
            this.groupBoxDataOutPut_SEA.TabIndex = 9;
            this.groupBoxDataOutPut_SEA.TabStop = false;
            this.groupBoxDataOutPut_SEA.Text = "Вывод данных";
            // 
            // dataGridViewResult_SEA
            // 
            this.dataGridViewResult_SEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SEA.Location = new System.Drawing.Point(13, 40);
            this.dataGridViewResult_SEA.Name = "dataGridViewResult_SEA";
            this.dataGridViewResult_SEA.RowHeadersWidth = 82;
            this.dataGridViewResult_SEA.RowTemplate.Height = 33;
            this.dataGridViewResult_SEA.Size = new System.Drawing.Size(410, 833);
            this.dataGridViewResult_SEA.TabIndex = 2;
            // 
            // chartFunction_SEA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SEA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_SEA.Legends.Add(legend1);
            this.chartFunction_SEA.Location = new System.Drawing.Point(429, 22);
            this.chartFunction_SEA.Name = "chartFunction_SEA";
            this.chartFunction_SEA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SEA.Series.Add(series1);
            this.chartFunction_SEA.Size = new System.Drawing.Size(1099, 851);
            this.chartFunction_SEA.TabIndex = 1;
            this.chartFunction_SEA.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1369, 1088);
            this.Controls.Add(this.groupBoxDataOutPut_SEA);
            this.Controls.Add(this.buttonHelp_SEA);
            this.Controls.Add(this.buttonSave_SEA);
            this.Controls.Add(this.buttonDone_SEA);
            this.Controls.Add(this.textBoxTask_SEA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спиринт 6 || Таск 5 || Вариант 17 || Сикачёва Е. А.";
            this.textBoxTask_SEA.ResumeLayout(false);
            this.textBoxTask_SEA.PerformLayout();
            this.groupBoxDataOutPut_SEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox textBoxTask_SEA;
        private System.Windows.Forms.TextBox textBoxTask5_SEA;
        private System.Windows.Forms.Button buttonDone_SEA;
        private System.Windows.Forms.Button buttonSave_SEA;
        private System.Windows.Forms.Button buttonHelp_SEA;
        private System.Windows.Forms.GroupBox groupBoxDataOutPut_SEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SEA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SEA;
    }
}

