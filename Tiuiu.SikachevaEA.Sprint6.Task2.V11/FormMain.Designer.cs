
namespace Tiuiu.SikachevaEA.Sprint6.Task2.V11
{
    partial class FormMainTask2_SEA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainTask2_SEA));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SEA = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_SEA = new System.Windows.Forms.TextBox();
            this.groupBoxGrid_SEA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SEA = new System.Windows.Forms.DataGridView();
            this.VarX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartData_SEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_SEA = new System.Windows.Forms.Label();
            this.buttonHelp_SEA = new System.Windows.Forms.Button();
            this.buttonDone_SEA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDataInput_SEA = new System.Windows.Forms.GroupBox();
            this.labelEnd_SEA = new System.Windows.Forms.Label();
            this.labelStart_SEA = new System.Windows.Forms.Label();
            this.textBoxEnd_SEA = new System.Windows.Forms.TextBox();
            this.textBoxStart_SEA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxTask_SEA.SuspendLayout();
            this.groupBoxGrid_SEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartData_SEA)).BeginInit();
            this.groupBoxDataInput_SEA.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SEA
            // 
            this.groupBoxTask_SEA.Controls.Add(this.textBoxCondition_SEA);
            this.groupBoxTask_SEA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_SEA.Name = "groupBoxTask_SEA";
            this.groupBoxTask_SEA.Size = new System.Drawing.Size(562, 325);
            this.groupBoxTask_SEA.TabIndex = 0;
            this.groupBoxTask_SEA.TabStop = false;
            this.groupBoxTask_SEA.Text = "Условие";
            // 
            // textBoxCondition_SEA
            // 
            this.textBoxCondition_SEA.Location = new System.Drawing.Point(7, 31);
            this.textBoxCondition_SEA.Multiline = true;
            this.textBoxCondition_SEA.Name = "textBoxCondition_SEA";
            this.textBoxCondition_SEA.ReadOnly = true;
            this.textBoxCondition_SEA.Size = new System.Drawing.Size(544, 288);
            this.textBoxCondition_SEA.TabIndex = 0;
            this.textBoxCondition_SEA.Text = resources.GetString("textBoxCondition_SEA.Text");
            // 
            // groupBoxGrid_SEA
            // 
            this.groupBoxGrid_SEA.Controls.Add(this.dataGridViewResult_SEA);
            this.groupBoxGrid_SEA.Controls.Add(this.chartData_SEA);
            this.groupBoxGrid_SEA.Controls.Add(this.labelResult_SEA);
            this.groupBoxGrid_SEA.Location = new System.Drawing.Point(673, 12);
            this.groupBoxGrid_SEA.Name = "groupBoxGrid_SEA";
            this.groupBoxGrid_SEA.Size = new System.Drawing.Size(831, 527);
            this.groupBoxGrid_SEA.TabIndex = 2;
            this.groupBoxGrid_SEA.TabStop = false;
            this.groupBoxGrid_SEA.Text = "Вывод данных";
            // 
            // dataGridViewResult_SEA
            // 
            this.dataGridViewResult_SEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SEA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VarX,
            this.ColumnFunction});
            this.dataGridViewResult_SEA.GridColor = System.Drawing.Color.White;
            this.dataGridViewResult_SEA.Location = new System.Drawing.Point(6, 54);
            this.dataGridViewResult_SEA.Name = "dataGridViewResult_SEA";
            this.dataGridViewResult_SEA.ReadOnly = true;
            this.dataGridViewResult_SEA.RowHeadersVisible = false;
            this.dataGridViewResult_SEA.RowHeadersWidth = 82;
            this.dataGridViewResult_SEA.RowTemplate.Height = 33;
            this.dataGridViewResult_SEA.Size = new System.Drawing.Size(194, 462);
            this.dataGridViewResult_SEA.TabIndex = 0;
            // 
            // VarX
            // 
            this.VarX.HeaderText = "X";
            this.VarX.MinimumWidth = 10;
            this.VarX.Name = "VarX";
            this.VarX.Width = 50;
            // 
            // ColumnFunction
            // 
            this.ColumnFunction.HeaderText = "F(X)";
            this.ColumnFunction.MinimumWidth = 10;
            this.ColumnFunction.Name = "ColumnFunction";
            this.ColumnFunction.Width = 50;
            // 
            // chartData_SEA
            // 
            this.chartData_SEA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chartData_SEA.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            this.chartData_SEA.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.chartData_SEA.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.Name = "ChartArea1";
            this.chartData_SEA.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartData_SEA.Legends.Add(legend3);
            this.chartData_SEA.Location = new System.Drawing.Point(206, 45);
            this.chartData_SEA.Name = "chartData_SEA";
            this.chartData_SEA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series3.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Legent1 - Empty";
            this.chartData_SEA.Series.Add(series3);
            this.chartData_SEA.Size = new System.Drawing.Size(689, 462);
            this.chartData_SEA.TabIndex = 2;
            this.chartData_SEA.Text = "График функции F(x)";
            // 
            // labelResult_SEA
            // 
            this.labelResult_SEA.AutoSize = true;
            this.labelResult_SEA.Location = new System.Drawing.Point(21, 26);
            this.labelResult_SEA.Name = "labelResult_SEA";
            this.labelResult_SEA.Size = new System.Drawing.Size(121, 25);
            this.labelResult_SEA.TabIndex = 1;
            this.labelResult_SEA.Text = "Результат:";
            // 
            // buttonHelp_SEA
            // 
            this.buttonHelp_SEA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_SEA.Location = new System.Drawing.Point(322, 402);
            this.buttonHelp_SEA.Name = "buttonHelp_SEA";
            this.buttonHelp_SEA.Size = new System.Drawing.Size(123, 105);
            this.buttonHelp_SEA.TabIndex = 5;
            this.buttonHelp_SEA.Text = "Справка";
            this.buttonHelp_SEA.UseVisualStyleBackColor = false;
            this.buttonHelp_SEA.Click += new System.EventHandler(this.buttonHelp_SEA_Click);
            // 
            // buttonDone_SEA
            // 
            this.buttonDone_SEA.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_SEA.Location = new System.Drawing.Point(451, 402);
            this.buttonDone_SEA.Name = "buttonDone_SEA";
            this.buttonDone_SEA.Size = new System.Drawing.Size(216, 105);
            this.buttonDone_SEA.TabIndex = 6;
            this.buttonDone_SEA.Text = "Выполнить";
            this.buttonDone_SEA.UseVisualStyleBackColor = false;
            this.buttonDone_SEA.Click += new System.EventHandler(this.buttonDone_SEA_Click);
            this.buttonDone_SEA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_SEA_MouseDown);
            this.buttonDone_SEA.MouseEnter += new System.EventHandler(this.buttonDone_SEA_MouseEnter);
            this.buttonDone_SEA.MouseLeave += new System.EventHandler(this.buttonDone_SEA_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 31);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // groupBoxDataInput_SEA
            // 
            this.groupBoxDataInput_SEA.Controls.Add(this.labelEnd_SEA);
            this.groupBoxDataInput_SEA.Controls.Add(this.labelStart_SEA);
            this.groupBoxDataInput_SEA.Controls.Add(this.textBoxEnd_SEA);
            this.groupBoxDataInput_SEA.Controls.Add(this.textBoxStart_SEA);
            this.groupBoxDataInput_SEA.Location = new System.Drawing.Point(4, 2);
            this.groupBoxDataInput_SEA.Name = "groupBoxDataInput_SEA";
            this.groupBoxDataInput_SEA.Size = new System.Drawing.Size(290, 123);
            this.groupBoxDataInput_SEA.TabIndex = 4;
            this.groupBoxDataInput_SEA.TabStop = false;
            this.groupBoxDataInput_SEA.Text = "Ввод данных";
            // 
            // labelEnd_SEA
            // 
            this.labelEnd_SEA.AutoSize = true;
            this.labelEnd_SEA.Location = new System.Drawing.Point(143, 31);
            this.labelEnd_SEA.Name = "labelEnd_SEA";
            this.labelEnd_SEA.Size = new System.Drawing.Size(129, 25);
            this.labelEnd_SEA.TabIndex = 3;
            this.labelEnd_SEA.Text = "Конец шага";
            // 
            // labelStart_SEA
            // 
            this.labelStart_SEA.AutoSize = true;
            this.labelStart_SEA.Location = new System.Drawing.Point(7, 31);
            this.labelStart_SEA.Name = "labelStart_SEA";
            this.labelStart_SEA.Size = new System.Drawing.Size(126, 25);
            this.labelStart_SEA.TabIndex = 2;
            this.labelStart_SEA.Text = "Старт шага";
            // 
            // textBoxEnd_SEA
            // 
            this.textBoxEnd_SEA.Location = new System.Drawing.Point(148, 69);
            this.textBoxEnd_SEA.Name = "textBoxEnd_SEA";
            this.textBoxEnd_SEA.Size = new System.Drawing.Size(118, 31);
            this.textBoxEnd_SEA.TabIndex = 1;
            // 
            // textBoxStart_SEA
            // 
            this.textBoxStart_SEA.Location = new System.Drawing.Point(0, 69);
            this.textBoxStart_SEA.Name = "textBoxStart_SEA";
            this.textBoxStart_SEA.Size = new System.Drawing.Size(133, 31);
            this.textBoxStart_SEA.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBoxDataInput_SEA);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(20, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // FormMainTask2_SEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 567);
            this.Controls.Add(this.buttonDone_SEA);
            this.Controls.Add(this.buttonHelp_SEA);
            this.Controls.Add(this.groupBoxGrid_SEA);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxTask_SEA);
            this.MaximizeBox = false;
            this.Name = "FormMainTask2_SEA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 || Таск 2 || Вариант 11 || Сикачёва Е. А.";
            this.groupBoxTask_SEA.ResumeLayout(false);
            this.groupBoxTask_SEA.PerformLayout();
            this.groupBoxGrid_SEA.ResumeLayout(false);
            this.groupBoxGrid_SEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartData_SEA)).EndInit();
            this.groupBoxDataInput_SEA.ResumeLayout(false);
            this.groupBoxDataInput_SEA.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SEA;
        private System.Windows.Forms.TextBox textBoxCondition_SEA;
        private System.Windows.Forms.GroupBox groupBoxGrid_SEA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SEA;
        private System.Windows.Forms.Button buttonHelp_SEA;
        private System.Windows.Forms.Button buttonDone_SEA;
        private System.Windows.Forms.Label labelResult_SEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData_SEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFunction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxDataInput_SEA;
        private System.Windows.Forms.Label labelEnd_SEA;
        private System.Windows.Forms.Label labelStart_SEA;
        private System.Windows.Forms.TextBox textBoxEnd_SEA;
        private System.Windows.Forms.TextBox textBoxStart_SEA;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

