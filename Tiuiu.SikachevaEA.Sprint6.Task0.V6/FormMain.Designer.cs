
namespace Tiuiu.SikachevaEA.Sprint6.Task0.V6
{
    partial class FormMainTask0EA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainTask0EA));
            this.groupBoxTask_SEA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_SEA = new System.Windows.Forms.PictureBox();
            this.textBoxCondition_SEA = new System.Windows.Forms.TextBox();
            this.groupBoxDataInput_SEA = new System.Windows.Forms.GroupBox();
            this.labelVariableX_SEA = new System.Windows.Forms.Label();
            this.textBoxPositionWinX_SEA = new System.Windows.Forms.TextBox();
            this.groupBoxDataOutput_SEA = new System.Windows.Forms.GroupBox();
            this.labelResult_SEA = new System.Windows.Forms.Label();
            this.textBoxResult_SEA = new System.Windows.Forms.TextBox();
            this.buttonPushMe_SEA = new System.Windows.Forms.Button();
            this.buttonQuestion_SEA = new System.Windows.Forms.Button();
            this.groupBoxTask_SEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SEA)).BeginInit();
            this.groupBoxDataInput_SEA.SuspendLayout();
            this.groupBoxDataOutput_SEA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SEA
            // 
            this.groupBoxTask_SEA.Controls.Add(this.pictureBoxFormula_SEA);
            this.groupBoxTask_SEA.Controls.Add(this.textBoxCondition_SEA);
            this.groupBoxTask_SEA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SEA.Name = "groupBoxTask_SEA";
            this.groupBoxTask_SEA.Size = new System.Drawing.Size(713, 253);
            this.groupBoxTask_SEA.TabIndex = 0;
            this.groupBoxTask_SEA.TabStop = false;
            this.groupBoxTask_SEA.Text = "Условие";
            // 
            // pictureBoxFormula_SEA
            // 
            this.pictureBoxFormula_SEA.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxFormula_SEA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_SEA.Image")));
            this.pictureBoxFormula_SEA.InitialImage = null;
            this.pictureBoxFormula_SEA.Location = new System.Drawing.Point(500, 30);
            this.pictureBoxFormula_SEA.Name = "pictureBoxFormula_SEA";
            this.pictureBoxFormula_SEA.Size = new System.Drawing.Size(200, 147);
            this.pictureBoxFormula_SEA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFormula_SEA.TabIndex = 1;
            this.pictureBoxFormula_SEA.TabStop = false;
            // 
            // textBoxCondition_SEA
            // 
            this.textBoxCondition_SEA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxCondition_SEA.Location = new System.Drawing.Point(6, 30);
            this.textBoxCondition_SEA.Multiline = true;
            this.textBoxCondition_SEA.Name = "textBoxCondition_SEA";
            this.textBoxCondition_SEA.ReadOnly = true;
            this.textBoxCondition_SEA.Size = new System.Drawing.Size(478, 178);
            this.textBoxCondition_SEA.TabIndex = 0;
            this.textBoxCondition_SEA.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Окр" +
    "углить до трёх знаков после запятой.";
            // 
            // groupBoxDataInput_SEA
            // 
            this.groupBoxDataInput_SEA.Controls.Add(this.labelVariableX_SEA);
            this.groupBoxDataInput_SEA.Controls.Add(this.textBoxPositionWinX_SEA);
            this.groupBoxDataInput_SEA.Location = new System.Drawing.Point(12, 293);
            this.groupBoxDataInput_SEA.Name = "groupBoxDataInput_SEA";
            this.groupBoxDataInput_SEA.Size = new System.Drawing.Size(250, 157);
            this.groupBoxDataInput_SEA.TabIndex = 1;
            this.groupBoxDataInput_SEA.TabStop = false;
            this.groupBoxDataInput_SEA.Text = "Ввод данных";
            // 
            // labelVariableX_SEA
            // 
            this.labelVariableX_SEA.AutoSize = true;
            this.labelVariableX_SEA.Location = new System.Drawing.Point(18, 41);
            this.labelVariableX_SEA.Name = "labelVariableX_SEA";
            this.labelVariableX_SEA.Size = new System.Drawing.Size(163, 25);
            this.labelVariableX_SEA.TabIndex = 1;
            this.labelVariableX_SEA.Text = "Переменная X:";
            // 
            // textBoxPositionWinX_SEA
            // 
            this.textBoxPositionWinX_SEA.Location = new System.Drawing.Point(6, 72);
            this.textBoxPositionWinX_SEA.Name = "textBoxPositionWinX_SEA";
            this.textBoxPositionWinX_SEA.Size = new System.Drawing.Size(187, 31);
            this.textBoxPositionWinX_SEA.TabIndex = 0;
            this.textBoxPositionWinX_SEA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPositionWinX_SEA_KeyPress);
            // 
            // groupBoxDataOutput_SEA
            // 
            this.groupBoxDataOutput_SEA.Controls.Add(this.labelResult_SEA);
            this.groupBoxDataOutput_SEA.Controls.Add(this.textBoxResult_SEA);
            this.groupBoxDataOutput_SEA.Location = new System.Drawing.Point(281, 304);
            this.groupBoxDataOutput_SEA.Name = "groupBoxDataOutput_SEA";
            this.groupBoxDataOutput_SEA.Size = new System.Drawing.Size(252, 146);
            this.groupBoxDataOutput_SEA.TabIndex = 2;
            this.groupBoxDataOutput_SEA.TabStop = false;
            this.groupBoxDataOutput_SEA.Text = "Вывод данных";
            // 
            // labelResult_SEA
            // 
            this.labelResult_SEA.AutoSize = true;
            this.labelResult_SEA.Location = new System.Drawing.Point(35, 30);
            this.labelResult_SEA.Name = "labelResult_SEA";
            this.labelResult_SEA.Size = new System.Drawing.Size(121, 25);
            this.labelResult_SEA.TabIndex = 1;
            this.labelResult_SEA.Text = "Результат:";
            // 
            // textBoxResult_SEA
            // 
            this.textBoxResult_SEA.Location = new System.Drawing.Point(21, 61);
            this.textBoxResult_SEA.Name = "textBoxResult_SEA";
            this.textBoxResult_SEA.ReadOnly = true;
            this.textBoxResult_SEA.Size = new System.Drawing.Size(183, 31);
            this.textBoxResult_SEA.TabIndex = 0;
            // 
            // buttonPushMe_SEA
            // 
            this.buttonPushMe_SEA.Location = new System.Drawing.Point(550, 483);
            this.buttonPushMe_SEA.Name = "buttonPushMe_SEA";
            this.buttonPushMe_SEA.Size = new System.Drawing.Size(185, 62);
            this.buttonPushMe_SEA.TabIndex = 3;
            this.buttonPushMe_SEA.Text = "Выполнить";
            this.buttonPushMe_SEA.UseVisualStyleBackColor = true;
            this.buttonPushMe_SEA.Click += new System.EventHandler(this.buttonPushMe_SEA_Click);
            // 
            // buttonQuestion_SEA
            // 
            this.buttonQuestion_SEA.Location = new System.Drawing.Point(458, 483);
            this.buttonQuestion_SEA.Name = "buttonQuestion_SEA";
            this.buttonQuestion_SEA.Size = new System.Drawing.Size(75, 62);
            this.buttonQuestion_SEA.TabIndex = 4;
            this.buttonQuestion_SEA.Text = "?";
            this.buttonQuestion_SEA.UseVisualStyleBackColor = true;
            this.buttonQuestion_SEA.Click += new System.EventHandler(this.buttonQuestion_SEA_Click);
            // 
            // FormMainTask0EA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 569);
            this.Controls.Add(this.buttonQuestion_SEA);
            this.Controls.Add(this.buttonPushMe_SEA);
            this.Controls.Add(this.groupBoxDataOutput_SEA);
            this.Controls.Add(this.groupBoxDataInput_SEA);
            this.Controls.Add(this.groupBoxTask_SEA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMainTask0EA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 6 | Сикачёва Е. А.";
            this.groupBoxTask_SEA.ResumeLayout(false);
            this.groupBoxTask_SEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SEA)).EndInit();
            this.groupBoxDataInput_SEA.ResumeLayout(false);
            this.groupBoxDataInput_SEA.PerformLayout();
            this.groupBoxDataOutput_SEA.ResumeLayout(false);
            this.groupBoxDataOutput_SEA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SEA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SEA;
        private System.Windows.Forms.TextBox textBoxCondition_SEA;
        private System.Windows.Forms.GroupBox groupBoxDataInput_SEA;
        private System.Windows.Forms.Label labelVariableX_SEA;
        private System.Windows.Forms.TextBox textBoxPositionWinX_SEA;
        private System.Windows.Forms.GroupBox groupBoxDataOutput_SEA;
        private System.Windows.Forms.Label labelResult_SEA;
        private System.Windows.Forms.TextBox textBoxResult_SEA;
        private System.Windows.Forms.Button buttonPushMe_SEA;
        private System.Windows.Forms.Button buttonQuestion_SEA;
    }
}

