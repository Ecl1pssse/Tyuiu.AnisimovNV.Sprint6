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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxIn_NVA = new System.Windows.Forms.TextBox();
            this.textBoxOut_NVA = new System.Windows.Forms.TextBox();
            this.buttonOpen_NVA = new System.Windows.Forms.Button();
            this.buttonInfo_NVA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // openFileDialog1
            this.openFileDialog1.FileName = "openFileDialog1";

            // textBoxIn_NVA
            this.textBoxIn_NVA.Location = new System.Drawing.Point(12, 30);
            this.textBoxIn_NVA.Multiline = true;
            this.textBoxIn_NVA.Name = "textBoxIn_NVA";
            this.textBoxIn_NVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn_NVA.Size = new System.Drawing.Size(300, 200);
            this.textBoxIn_NVA.TabIndex = 0;

            // textBoxOut_NVA
            this.textBoxOut_NVA.Location = new System.Drawing.Point(318, 30);
            this.textBoxOut_NVA.Multiline = true;
            this.textBoxOut_NVA.Name = "textBoxOut_NVA";
            this.textBoxOut_NVA.ReadOnly = true;
            this.textBoxOut_NVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_NVA.Size = new System.Drawing.Size(300, 200);
            this.textBoxOut_NVA.TabIndex = 1;

            // buttonOpen_NVA
            this.buttonOpen_NVA.Location = new System.Drawing.Point(12, 236);
            this.buttonOpen_NVA.Name = "buttonOpen_NVA";
            this.buttonOpen_NVA.Size = new System.Drawing.Size(100, 30);
            this.buttonOpen_NVA.TabIndex = 2;
            this.buttonOpen_NVA.Text = "Открыть файл";
            this.buttonOpen_NVA.UseVisualStyleBackColor = true;
            this.buttonOpen_NVA.Click += new System.EventHandler(this.buttonOpen_NVA_Click);

            // buttonInfo_NVA
            this.buttonInfo_NVA.Location = new System.Drawing.Point(120, 236);
            this.buttonInfo_NVA.Name = "buttonInfo_NVA";
            this.buttonInfo_NVA.Size = new System.Drawing.Size(80, 30);
            this.buttonInfo_NVA.TabIndex = 3;
            this.buttonInfo_NVA.Text = "Справка";
            this.buttonInfo_NVA.UseVisualStyleBackColor = true;
            this.buttonInfo_NVA.Click += new System.EventHandler(this.buttonInfo_NVA_Click);

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Содержимое файла";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Четвертые слова из строк";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 280);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInfo_NVA);
            this.Controls.Add(this.buttonOpen_NVA);
            this.Controls.Add(this.textBoxOut_NVA);
            this.Controls.Add(this.textBoxIn_NVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание 6 | Вариант 30 | Анисимов Н.В.";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxIn_NVA;
        private System.Windows.Forms.TextBox textBoxOut_NVA;
        private System.Windows.Forms.Button buttonOpen_NVA;
        private System.Windows.Forms.Button buttonInfo_NVA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}