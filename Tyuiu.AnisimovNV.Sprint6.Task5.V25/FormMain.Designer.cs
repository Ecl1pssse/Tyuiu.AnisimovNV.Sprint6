namespace Tyuiu.AnisimovNV.Sprint6.Task5.V25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxData_NVA = new System.Windows.Forms.GroupBox();
            this.dataGridViewValues_NVA = new System.Windows.Forms.DataGridView();
            this.groupBoxDiagram_NVA = new System.Windows.Forms.GroupBox();
            this.pictureBoxDiagram_NVA = new System.Windows.Forms.PictureBox();
            this.buttonLoad_NVA = new System.Windows.Forms.Button();
            this.buttonHelp_NVA = new System.Windows.Forms.Button();
            this.labelStatus_NVA = new System.Windows.Forms.Label();
            this.groupBoxTask_NVA = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_NVA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_NVA = new System.Windows.Forms.TextBox();
            this.groupBoxData_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues_NVA)).BeginInit();
            this.groupBoxDiagram_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiagram_NVA)).BeginInit();
            this.groupBoxTask_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_NVA)).BeginInit();
            this.SuspendLayout();

            // groupBoxData_NVA
            this.groupBoxData_NVA.Controls.Add(this.dataGridViewValues_NVA);
            this.groupBoxData_NVA.Location = new System.Drawing.Point(12, 168);
            this.groupBoxData_NVA.Name = "groupBoxData_NVA";
            this.groupBoxData_NVA.Size = new System.Drawing.Size(200, 200);
            this.groupBoxData_NVA.TabIndex = 0;
            this.groupBoxData_NVA.TabStop = false;
            this.groupBoxData_NVA.Text = "Загруженные данные";

            // dataGridViewValues_NVA
            this.dataGridViewValues_NVA.AllowUserToAddRows = false;
            this.dataGridViewValues_NVA.AllowUserToDeleteRows = false;
            this.dataGridViewValues_NVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValues_NVA.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewValues_NVA.Name = "dataGridViewValues_NVA";
            this.dataGridViewValues_NVA.ReadOnly = true;
            this.dataGridViewValues_NVA.Size = new System.Drawing.Size(188, 175);
            this.dataGridViewValues_NVA.TabIndex = 0;

            // groupBoxDiagram_NVA
            this.groupBoxDiagram_NVA.Controls.Add(this.pictureBoxDiagram_NVA);
            this.groupBoxDiagram_NVA.Location = new System.Drawing.Point(218, 168);
            this.groupBoxDiagram_NVA.Name = "groupBoxDiagram_NVA";
            this.groupBoxDiagram_NVA.Size = new System.Drawing.Size(350, 200);
            this.groupBoxDiagram_NVA.TabIndex = 1;
            this.groupBoxDiagram_NVA.TabStop = false;
            this.groupBoxDiagram_NVA.Text = "Диаграмма значений";

            // pictureBoxDiagram_NVA
            this.pictureBoxDiagram_NVA.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxDiagram_NVA.Name = "pictureBoxDiagram_NVA";
            this.pictureBoxDiagram_NVA.Size = new System.Drawing.Size(338, 175);
            this.pictureBoxDiagram_NVA.TabIndex = 0;
            this.pictureBoxDiagram_NVA.TabStop = false;

            // buttonLoad_NVA
            this.buttonLoad_NVA.Location = new System.Drawing.Point(12, 374);
            this.buttonLoad_NVA.Name = "buttonLoad_NVA";
            this.buttonLoad_NVA.Size = new System.Drawing.Size(100, 38);
            this.buttonLoad_NVA.TabIndex = 2;
            this.buttonLoad_NVA.Text = "Загрузить";
            this.buttonLoad_NVA.UseVisualStyleBackColor = true;
            this.buttonLoad_NVA.Click += new System.EventHandler(this.buttonLoad_NVA_Click);

            // buttonHelp_NVA
            this.buttonHelp_NVA.BackColor = System.Drawing.SystemColors.Window;
            this.buttonHelp_NVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_NVA.Location = new System.Drawing.Point(118, 374);
            this.buttonHelp_NVA.Name = "buttonHelp_NVA";
            this.buttonHelp_NVA.Size = new System.Drawing.Size(37, 37);
            this.buttonHelp_NVA.TabIndex = 3;
            this.buttonHelp_NVA.Text = "?";
            this.buttonHelp_NVA.UseVisualStyleBackColor = false;
            this.buttonHelp_NVA.Click += new System.EventHandler(this.buttonHelp_NVA_Click);

            // labelStatus_NVA
            this.labelStatus_NVA.AutoSize = true;
            this.labelStatus_NVA.Location = new System.Drawing.Point(218, 374);
            this.labelStatus_NVA.Name = "labelStatus_NVA";
            this.labelStatus_NVA.Size = new System.Drawing.Size(130, 13);
            this.labelStatus_NVA.TabIndex = 4;
            this.labelStatus_NVA.Text = "Нажмите \"Загрузить\"";

            // groupBoxTask_NVA
            this.groupBoxTask_NVA.Controls.Add(this.pictureBoxTask_NVA);
            this.groupBoxTask_NVA.Controls.Add(this.textBoxTask_NVA);
            this.groupBoxTask_NVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_NVA.Name = "groupBoxTask_NVA";
            this.groupBoxTask_NVA.Size = new System.Drawing.Size(556, 150);
            this.groupBoxTask_NVA.TabIndex = 5;
            this.groupBoxTask_NVA.TabStop = false;
            this.groupBoxTask_NVA.Text = "Условие";

            // pictureBoxTask_NVA
            this.pictureBoxTask_NVA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_NVA.Image")));
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
            this.textBoxTask_NVA.Size = new System.Drawing.Size(500, 13);
            this.textBoxTask_NVA.TabIndex = 0;
            this.textBoxTask_NVA.Text = "Прочитать данные из файла InPutFileTask5V25.txt. Вывести в DataGridView ненулевые значения. Построить диаграмму.";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 424);
            this.Controls.Add(this.groupBoxTask_NVA);
            this.Controls.Add(this.labelStatus_NVA);
            this.Controls.Add(this.buttonHelp_NVA);
            this.Controls.Add(this.buttonLoad_NVA);
            this.Controls.Add(this.groupBoxDiagram_NVA);
            this.Controls.Add(this.groupBoxData_NVA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 25 | Анисимов Н.В.";
            this.groupBoxData_NVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues_NVA)).EndInit();
            this.groupBoxDiagram_NVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiagram_NVA)).EndInit();
            this.groupBoxTask_NVA.ResumeLayout(false);
            this.groupBoxTask_NVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_NVA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxData_NVA;
        private System.Windows.Forms.DataGridView dataGridViewValues_NVA;
        private System.Windows.Forms.GroupBox groupBoxDiagram_NVA;
        private System.Windows.Forms.PictureBox pictureBoxDiagram_NVA;
        private System.Windows.Forms.Button buttonLoad_NVA;
        private System.Windows.Forms.Button buttonHelp_NVA;
        private System.Windows.Forms.Label labelStatus_NVA;
        private System.Windows.Forms.GroupBox groupBoxTask_NVA;
        private System.Windows.Forms.PictureBox pictureBoxTask_NVA;
        private System.Windows.Forms.TextBox textBoxTask_NVA;
    }
}