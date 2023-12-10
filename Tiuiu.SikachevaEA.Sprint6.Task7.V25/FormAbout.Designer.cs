
namespace Tiuiu.SikachevaEA.Sprint6.Task7.V25
{
    partial class FormAboutInfo_SEA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutInfo_SEA));
            this.labelInfo_SEA = new System.Windows.Forms.Label();
            this.buttonOk_SEA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo_SEA
            // 
            this.labelInfo_SEA.AutoSize = true;
            this.labelInfo_SEA.Location = new System.Drawing.Point(12, 18);
            this.labelInfo_SEA.Name = "labelInfo_SEA";
            this.labelInfo_SEA.Size = new System.Drawing.Size(551, 225);
            this.labelInfo_SEA.TabIndex = 1;
            this.labelInfo_SEA.Text = resources.GetString("labelInfo_SEA.Text");
            // 
            // buttonOk_SEA
            // 
            this.buttonOk_SEA.Location = new System.Drawing.Point(571, 262);
            this.buttonOk_SEA.Name = "buttonOk_SEA";
            this.buttonOk_SEA.Size = new System.Drawing.Size(151, 44);
            this.buttonOk_SEA.TabIndex = 2;
            this.buttonOk_SEA.Text = "Ok";
            this.buttonOk_SEA.UseVisualStyleBackColor = true;
            this.buttonOk_SEA.Click += new System.EventHandler(this.buttonOk_SEA_Click);
            // 
            // FormAboutInfo_SEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 318);
            this.Controls.Add(this.buttonOk_SEA);
            this.Controls.Add(this.labelInfo_SEA);
            this.Name = "FormAboutInfo_SEA";
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_SEA;
        private System.Windows.Forms.Button buttonOk_SEA;
    }
}