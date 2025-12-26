namespace Tyuiu.AnisimovNV.Sprint6.Task6.V30
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
            this.textBoxInput_NVA = new System.Windows.Forms.TextBox();
            this.textBoxOutput_NVA = new System.Windows.Forms.TextBox();
            this.buttonOpenFile_NVA = new System.Windows.Forms.Button();
            this.buttonInfo_NVA = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();

            // textBoxInput_NVA
            this.textBoxInput_NVA.Location = new System.Drawing.Point(12, 12);
            this.textBoxInput_NVA.Multiline = true;
            this.textBoxInput_NVA.Name = "textBoxInput_NVA";
            this.textBoxInput_NVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_NVA.Size = new System.Drawing.Size(300, 250);
            this.textBoxInput_NVA.TabIndex = 0;

            // textBoxOutput_NVA
            this.textBoxOutput_NVA.Location = new System.Drawing.Point(318, 12);
            this.textBoxOutput_NVA.Multiline = true;
            this.textBoxOutput_NVA.Name = "textBoxOutput_NVA";
            this.textBoxOutput_NVA.ReadOnly = true;
            this.textBoxOutput_NVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_NVA.Size = new System.Drawing.Size(300, 250);
            this.textBoxOutput_NVA.TabIndex = 1;

            // buttonOpenFile_NVA
            this.buttonOpenFile_NVA.Location = new System.Drawing.Point(12, 268);
            this.buttonOpenFile_NVA.Name = "buttonOpenFile_NVA";
            this.buttonOpenFile_NVA.Size = new System.Drawing.Size(100, 30);
            this.buttonOpenFile_NVA.TabIndex = 2;
            this.buttonOpenFile_NVA.Text = "Открыть файл";
            this.buttonOpenFile_NVA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_NVA.Click += new System.EventHandler(this.buttonOpenFile_NVA_Click);

            // buttonInfo_NVA
            this.buttonInfo_NVA.Location = new System.Drawing.Point(118, 268);
            this.buttonInfo_NVA.Name = "buttonInfo_NVA";
            this.buttonInfo_NVA.Size = new System.Drawing.Size(80, 30);
            this.buttonInfo_NVA.TabIndex = 3;
            this.buttonInfo_NVA.Text = "Справка";
            this.buttonInfo_NVA.UseVisualStyleBackColor = true;
            this.buttonInfo_NVA.Click += new System.EventHandler(this.buttonInfo_NVA_Click);

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 310);
            this.Controls.Add(this.buttonInfo_NVA);
            this.Controls.Add(this.buttonOpenFile_NVA);
            this.Controls.Add(this.textBoxOutput_NVA);
            this.Controls.Add(this.textBoxInput_NVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 30 | Анисимов Н.В.";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxInput_NVA;
        private System.Windows.Forms.TextBox textBoxOutput_NVA;
        private System.Windows.Forms.Button buttonOpenFile_NVA;
        private System.Windows.Forms.Button buttonInfo_NVA;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}