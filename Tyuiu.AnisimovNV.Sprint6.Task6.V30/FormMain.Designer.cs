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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.openFileDialogTask_NVA = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxInput_NVA = new System.Windows.Forms.GroupBox();
            this.textBoxInput_NVA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_NVA = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_NVA = new System.Windows.Forms.TextBox();
            this.buttonOpenFile_NVA = new System.Windows.Forms.Button();
            this.buttonHelp_NVA = new System.Windows.Forms.Button();
            this.groupBoxTask_NVA = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_NVA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_NVA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_NVA.SuspendLayout();
            this.groupBoxOutput_NVA.SuspendLayout();
            this.groupBoxTask_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_NVA)).BeginInit();
            this.SuspendLayout();

            // openFileDialogTask_NVA
            this.openFileDialogTask_NVA.FileName = "openFileDialog1";

            // groupBoxInput_NVA
            this.groupBoxInput_NVA.Controls.Add(this.textBoxInput_NVA);
            this.groupBoxInput_NVA.Location = new System.Drawing.Point(12, 168);
            this.groupBoxInput_NVA.Name = "groupBoxInput_NVA";
            this.groupBoxInput_NVA.Size = new System.Drawing.Size(320, 200);
            this.groupBoxInput_NVA.TabIndex = 0;
            this.groupBoxInput_NVA.TabStop = false;
            this.groupBoxInput_NVA.Text = "Входные данные из файла";

            // textBoxInput_NVA
            this.textBoxInput_NVA.Location = new System.Drawing.Point(6, 19);
            this.textBoxInput_NVA.Multiline = true;
            this.textBoxInput_NVA.Name = "textBoxInput_NVA";
            this.textBoxInput_NVA.ReadOnly = true;
            this.textBoxInput_NVA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInput_NVA.Size = new System.Drawing.Size(308, 175);
            this.textBoxInput_NVA.TabIndex = 0;

            // groupBoxOutput_NVA
            this.groupBoxOutput_NVA.Controls.Add(this.textBoxOutput_NVA);
            this.groupBoxOutput_NVA.Location = new System.Drawing.Point(338, 168);
            this.groupBoxOutput_NVA.Name = "groupBoxOutput_NVA";
            this.groupBoxOutput_NVA.Size = new System.Drawing.Size(320, 200);
            this.groupBoxOutput_NVA.TabIndex = 1;
            this.groupBoxOutput_NVA.TabStop = false;
            this.groupBoxOutput_NVA.Text = "Выходные данные (четвертые слова)";

            // textBoxOutput_NVA
            this.textBoxOutput_NVA.Location = new System.Drawing.Point(6, 19);
            this.textBoxOutput_NVA.Multiline = true;
            this.textBoxOutput_NVA.Name = "textBoxOutput_NVA";
            this.textBoxOutput_NVA.ReadOnly = true;
            this.textBoxOutput_NVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_NVA.Size = new System.Drawing.Size(308, 175);
            this.textBoxOutput_NVA.TabIndex = 0;

            // buttonOpenFile_NVA
            this.buttonOpenFile_NVA.Location = new System.Drawing.Point(12, 374);
            this.buttonOpenFile_NVA.Name = "buttonOpenFile_NVA";
            this.buttonOpenFile_NVA.Size = new System.Drawing.Size(120, 38);
            this.buttonOpenFile_NVA.TabIndex = 2;
            this.buttonOpenFile_NVA.Text = "Открыть файл";
            this.buttonOpenFile_NVA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_NVA.Click += new System.EventHandler(this.buttonOpenFile_NVA_Click);

            // buttonHelp_NVA
            this.buttonHelp_NVA.BackColor = System.Drawing.SystemColors.Window;
            this.buttonHelp_NVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_NVA.Location = new System.Drawing.Point(138, 374);
            this.buttonHelp_NVA.Name = "buttonHelp_NVA";
            this.buttonHelp_NVA.Size = new System.Drawing.Size(37, 37);
            this.buttonHelp_NVA.TabIndex = 3;
            this.buttonHelp_NVA.Text = "?";
            this.buttonHelp_NVA.UseVisualStyleBackColor = false;
            this.buttonHelp_NVA.Click += new System.EventHandler(this.buttonHelp_NVA_Click);

            // groupBoxTask_NVA
            this.groupBoxTask_NVA.Controls.Add(this.pictureBoxTask_NVA);
            this.groupBoxTask_NVA.Controls.Add(this.textBoxTask_NVA);
            this.groupBoxTask_NVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_NVA.Name = "groupBoxTask_NVA";
            this.groupBoxTask_NVA.Size = new System.Drawing.Size(646, 150);
            this.groupBoxTask_NVA.TabIndex = 4;
            this.groupBoxTask_NVA.TabStop = false;
            this.groupBoxTask_NVA.Text = "Условие";

            // pictureBoxTask_NVA
            this.pictureBoxTask_NVA.Location = new System.Drawing.Point(10, 40);
            this.pictureBoxTask_NVA.Name = "pictureBoxTask_NVA";
            this.pictureBoxTask_NVA.Size = new System.Drawing.Size(350, 50);
            this.pictureBoxTask_NVA.TabIndex = 1;
            this.pictureBoxTask_NVA.TabStop = false;

            // textBoxTask_NVA
            this.textBoxTask_NVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_NVA.Location = new System.Drawing.Point(10, 20);
            this.textBoxTask_NVA.Name = "textBoxTask_NVA";
            this.textBoxTask_NVA.ReadOnly = true;
            this.textBoxTask_NVA.Size = new System.Drawing.Size(600, 13);
            this.textBoxTask_NVA.TabIndex = 0;
            this.textBoxTask_NVA.Text = "Загрузить файл InPutFileTask6V30.txt через OpenFileDialog. Выделить четвертое слово каждой строки.";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 424);
            this.Controls.Add(this.groupBoxTask_NVA);
            this.Controls.Add(this.buttonHelp_NVA);
            this.Controls.Add(this.buttonOpenFile_NVA);
            this.Controls.Add(this.groupBoxOutput_NVA);
            this.Controls.Add(this.groupBoxInput_NVA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 30 | Анисимов Н.В.";
            this.groupBoxInput_NVA.ResumeLayout(false);
            this.groupBoxInput_NVA.PerformLayout();
            this.groupBoxOutput_NVA.ResumeLayout(false);
            this.groupBoxOutput_NVA.PerformLayout();
            this.groupBoxTask_NVA.ResumeLayout(false);
            this.groupBoxTask_NVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_NVA)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogTask_NVA;
        private System.Windows.Forms.GroupBox groupBoxInput_NVA;
        private System.Windows.Forms.TextBox textBoxInput_NVA;
        private System.Windows.Forms.GroupBox groupBoxOutput_NVA;
        private System.Windows.Forms.TextBox textBoxOutput_NVA;
        private System.Windows.Forms.Button buttonOpenFile_NVA;
        private System.Windows.Forms.Button buttonHelp_NVA;
        private System.Windows.Forms.GroupBox groupBoxTask_NVA;
        private System.Windows.Forms.PictureBox pictureBoxTask_NVA;
        private System.Windows.Forms.TextBox textBoxTask_NVA;
    }
}