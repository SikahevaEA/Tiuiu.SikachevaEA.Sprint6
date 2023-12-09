
namespace Tiuiu.SikachevaEA.Sprint6.Task4.V23
{
    partial class FormMain_SEA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.textBoxTask_SEA = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBoxDataInput_SEA = new System.Windows.Forms.GroupBox();
            this.labelStop_SEA = new System.Windows.Forms.Label();
            this.labelStart_SEA = new System.Windows.Forms.Label();
            this.textBoxStop_SEA = new System.Windows.Forms.TextBox();
            this.textBoxStart_SEA = new System.Windows.Forms.TextBox();
            this.groupBoxDataOutPut_SEA = new System.Windows.Forms.GroupBox();
            this.chartFunction_SEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxResult_SEA = new System.Windows.Forms.TextBox();
            this.buttonHelp_SEA = new System.Windows.Forms.Button();
            this.buttonSave_SEA = new System.Windows.Forms.Button();
            this.buttonDone_SEA = new System.Windows.Forms.Button();
            this.textBoxTask_SEA.SuspendLayout();
            this.groupBoxDataInput_SEA.SuspendLayout();
            this.groupBoxDataOutPut_SEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SEA)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTask_SEA
            // 
            this.textBoxTask_SEA.Controls.Add(this.textBox4);
            this.textBoxTask_SEA.Location = new System.Drawing.Point(13, 13);
            this.textBoxTask_SEA.Name = "textBoxTask_SEA";
            this.textBoxTask_SEA.Size = new System.Drawing.Size(736, 163);
            this.textBoxTask_SEA.TabIndex = 0;
            this.textBoxTask_SEA.TabStop = false;
            this.textBoxTask_SEA.Text = "Условие";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(7, 25);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(719, 132);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Протабулировать функцию 4 - 2x + 2 + cos(x) / 2x - 2 на диапазоне от -5 до 5.\r\nРе" +
    "зультат вывести в text Box, построить график функции и сохранить в файл OutPutFi" +
    "leTask4V23 по нажатию кнопки. ";
            // 
            // groupBoxDataInput_SEA
            // 
            this.groupBoxDataInput_SEA.Controls.Add(this.labelStop_SEA);
            this.groupBoxDataInput_SEA.Controls.Add(this.labelStart_SEA);
            this.groupBoxDataInput_SEA.Controls.Add(this.textBoxStop_SEA);
            this.groupBoxDataInput_SEA.Controls.Add(this.textBoxStart_SEA);
            this.groupBoxDataInput_SEA.Location = new System.Drawing.Point(755, 12);
            this.groupBoxDataInput_SEA.Name = "groupBoxDataInput_SEA";
            this.groupBoxDataInput_SEA.Size = new System.Drawing.Size(398, 158);
            this.groupBoxDataInput_SEA.TabIndex = 1;
            this.groupBoxDataInput_SEA.TabStop = false;
            this.groupBoxDataInput_SEA.Text = "Ввод данных";
            // 
            // labelStop_SEA
            // 
            this.labelStop_SEA.AutoSize = true;
            this.labelStop_SEA.Location = new System.Drawing.Point(210, 43);
            this.labelStop_SEA.Name = "labelStop_SEA";
            this.labelStop_SEA.Size = new System.Drawing.Size(129, 25);
            this.labelStop_SEA.TabIndex = 3;
            this.labelStop_SEA.Text = "Конец шага";
            // 
            // labelStart_SEA
            // 
            this.labelStart_SEA.AutoSize = true;
            this.labelStart_SEA.Location = new System.Drawing.Point(6, 43);
            this.labelStart_SEA.Name = "labelStart_SEA";
            this.labelStart_SEA.Size = new System.Drawing.Size(126, 25);
            this.labelStart_SEA.TabIndex = 2;
            this.labelStart_SEA.Text = "Старт шага";
            // 
            // textBoxStop_SEA
            // 
            this.textBoxStop_SEA.Location = new System.Drawing.Point(203, 86);
            this.textBoxStop_SEA.Name = "textBoxStop_SEA";
            this.textBoxStop_SEA.Size = new System.Drawing.Size(183, 31);
            this.textBoxStop_SEA.TabIndex = 1;
            // 
            // textBoxStart_SEA
            // 
            this.textBoxStart_SEA.Location = new System.Drawing.Point(6, 86);
            this.textBoxStart_SEA.Name = "textBoxStart_SEA";
            this.textBoxStart_SEA.Size = new System.Drawing.Size(176, 31);
            this.textBoxStart_SEA.TabIndex = 0;
            // 
            // groupBoxDataOutPut_SEA
            // 
            this.groupBoxDataOutPut_SEA.Controls.Add(this.chartFunction_SEA);
            this.groupBoxDataOutPut_SEA.Controls.Add(this.textBoxResult_SEA);
            this.groupBoxDataOutPut_SEA.Location = new System.Drawing.Point(13, 182);
            this.groupBoxDataOutPut_SEA.Name = "groupBoxDataOutPut_SEA";
            this.groupBoxDataOutPut_SEA.Size = new System.Drawing.Size(1663, 880);
            this.groupBoxDataOutPut_SEA.TabIndex = 2;
            this.groupBoxDataOutPut_SEA.TabStop = false;
            this.groupBoxDataOutPut_SEA.Text = "Вывод данных";
            // 
            // chartFunction_SEA
            // 
            this.chartFunction_SEA.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.Name = "ChartArea1";
            this.chartFunction_SEA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_SEA.Legends.Add(legend2);
            this.chartFunction_SEA.Location = new System.Drawing.Point(369, 30);
            this.chartFunction_SEA.Name = "chartFunction_SEA";
            this.chartFunction_SEA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_SEA.Series.Add(series2);
            this.chartFunction_SEA.Size = new System.Drawing.Size(1469, 858);
            this.chartFunction_SEA.TabIndex = 1;
            this.chartFunction_SEA.Text = "График функции 4 - 2x + 2 + cos(x) / 2x - 2 ";
            title2.ForeColor = System.Drawing.Color.MidnightBlue;
            title2.Name = "function";
            title2.Text = "График функции 4 - 2x + 2 + cos(x) / 2x - 2  ";
            this.chartFunction_SEA.Titles.Add(title2);
            // 
            // textBoxResult_SEA
            // 
            this.textBoxResult_SEA.Location = new System.Drawing.Point(7, 41);
            this.textBoxResult_SEA.Multiline = true;
            this.textBoxResult_SEA.Name = "textBoxResult_SEA";
            this.textBoxResult_SEA.ReadOnly = true;
            this.textBoxResult_SEA.Size = new System.Drawing.Size(356, 833);
            this.textBoxResult_SEA.TabIndex = 0;
            // 
            // buttonHelp_SEA
            // 
            this.buttonHelp_SEA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_SEA.Location = new System.Drawing.Point(1475, 38);
            this.buttonHelp_SEA.Name = "buttonHelp_SEA";
            this.buttonHelp_SEA.Size = new System.Drawing.Size(119, 91);
            this.buttonHelp_SEA.TabIndex = 3;
            this.buttonHelp_SEA.Text = "Справка";
            this.buttonHelp_SEA.UseVisualStyleBackColor = false;
            this.buttonHelp_SEA.Click += new System.EventHandler(this.buttonHelp_SEA_Click);
            // 
            // buttonSave_SEA
            // 
            this.buttonSave_SEA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_SEA.Location = new System.Drawing.Point(1335, 38);
            this.buttonSave_SEA.Name = "buttonSave_SEA";
            this.buttonSave_SEA.Size = new System.Drawing.Size(134, 91);
            this.buttonSave_SEA.TabIndex = 4;
            this.buttonSave_SEA.Text = "Сохранить";
            this.buttonSave_SEA.UseVisualStyleBackColor = false;
            this.buttonSave_SEA.Click += new System.EventHandler(this.buttonSave_SEA_Click);
            // 
            // buttonDone_SEA
            // 
            this.buttonDone_SEA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SEA.Location = new System.Drawing.Point(1159, 38);
            this.buttonDone_SEA.Name = "buttonDone_SEA";
            this.buttonDone_SEA.Size = new System.Drawing.Size(170, 91);
            this.buttonDone_SEA.TabIndex = 5;
            this.buttonDone_SEA.Text = "Выполнить";
            this.buttonDone_SEA.UseVisualStyleBackColor = false;
            this.buttonDone_SEA.Click += new System.EventHandler(this.buttonDone_SEA_Click);
            // 
            // FormMain_SEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1600, 1074);
            this.Controls.Add(this.buttonDone_SEA);
            this.Controls.Add(this.buttonSave_SEA);
            this.Controls.Add(this.buttonHelp_SEA);
            this.Controls.Add(this.groupBoxDataOutPut_SEA);
            this.Controls.Add(this.groupBoxDataInput_SEA);
            this.Controls.Add(this.textBoxTask_SEA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain_SEA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спиринт 6 || Таск 4 || Вариант 23 || Сикачёва Е. А.";
            this.textBoxTask_SEA.ResumeLayout(false);
            this.textBoxTask_SEA.PerformLayout();
            this.groupBoxDataInput_SEA.ResumeLayout(false);
            this.groupBoxDataInput_SEA.PerformLayout();
            this.groupBoxDataOutPut_SEA.ResumeLayout(false);
            this.groupBoxDataOutPut_SEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox textBoxTask_SEA;
        private System.Windows.Forms.GroupBox groupBoxDataInput_SEA;
        private System.Windows.Forms.Label labelStart_SEA;
        private System.Windows.Forms.TextBox textBoxStop_SEA;
        private System.Windows.Forms.TextBox textBoxStart_SEA;
        private System.Windows.Forms.GroupBox groupBoxDataOutPut_SEA;
        private System.Windows.Forms.Button buttonHelp_SEA;
        private System.Windows.Forms.Button buttonSave_SEA;
        private System.Windows.Forms.Button buttonDone_SEA;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelStop_SEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SEA;
        private System.Windows.Forms.TextBox textBoxResult_SEA;
    }
}

