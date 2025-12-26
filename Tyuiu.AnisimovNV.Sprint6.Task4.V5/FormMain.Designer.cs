namespace Tyuiu.AnisimovNV.Sprint6.Task4.V5
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxResult_NVA = new System.Windows.Forms.TextBox();
            this.buttonDone_NVA = new System.Windows.Forms.Button();
            this.buttonHelp_NVA = new System.Windows.Forms.Button();
            this.labelTask_NVA = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // textBoxResult_NVA
            this.textBoxResult_NVA.Location = new System.Drawing.Point(12, 40);
            this.textBoxResult_NVA.Multiline = true;
            this.textBoxResult_NVA.Name = "textBoxResult_NVA";
            this.textBoxResult_NVA.ReadOnly = true;
            this.textBoxResult_NVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_NVA.Size = new System.Drawing.Size(300, 300);
            this.textBoxResult_NVA.TabIndex = 0;

            // buttonDone_NVA
            this.buttonDone_NVA.Location = new System.Drawing.Point(12, 350);
            this.buttonDone_NVA.Name = "buttonDone_NVA";
            this.buttonDone_NVA.Size = new System.Drawing.Size(100, 30);
            this.buttonDone_NVA.TabIndex = 1;
            this.buttonDone_NVA.Text = "Выполнить";
            this.buttonDone_NVA.UseVisualStyleBackColor = true;
            this.buttonDone_NVA.Click += new System.EventHandler(this.buttonDone_NVA_Click);

            // buttonHelp_NVA
            this.buttonHelp_NVA.Location = new System.Drawing.Point(120, 350);
            this.buttonHelp_NVA.Name = "buttonHelp_NVA";
            this.buttonHelp_NVA.Size = new System.Drawing.Size(80, 30);
            this.buttonHelp_NVA.TabIndex = 2;
            this.buttonHelp_NVA.Text = "Справка";
            this.buttonHelp_NVA.UseVisualStyleBackColor = true;
            this.buttonHelp_NVA.Click += new System.EventHandler(this.buttonHelp_NVA_Click);

            // labelTask_NVA
            this.labelTask_NVA.AutoSize = true;
            this.labelTask_NVA.Location = new System.Drawing.Point(12, 12);
            this.labelTask_NVA.Name = "labelTask_NVA";
            this.labelTask_NVA.Size = new System.Drawing.Size(300, 13);
            this.labelTask_NVA.TabIndex = 3;
            this.labelTask_NVA.Text = "Табулирование функции F(x) = (2*sin(x))/(3*x+1.2) + cos(x) - 14x";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 391);
            this.Controls.Add(this.labelTask_NVA);
            this.Controls.Add(this.buttonHelp_NVA);
            this.Controls.Add(this.buttonDone_NVA);
            this.Controls.Add(this.textBoxResult_NVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 5 | Анисимов Н.В.";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxResult_NVA;
        private System.Windows.Forms.Button buttonDone_NVA;
        private System.Windows.Forms.Button buttonHelp_NVA;
        private System.Windows.Forms.Label labelTask_NVA;
    }
}