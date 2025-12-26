namespace Tyuiu.AnisimovNV.Sprint6.Task3.V7
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
            this.groupBoxTask_NVA = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_NVA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_NVA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_NVA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput_NVA = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_NVA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_NVA = new System.Windows.Forms.DataGridView();
            this.buttonDone_NVA = new System.Windows.Forms.Button();
            this.buttonHelp_NVA = new System.Windows.Forms.Button();
            this.groupBoxTask_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_NVA)).BeginInit();
            this.groupBoxInput_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_NVA)).BeginInit();
            this.groupBoxResult_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_NVA)).BeginInit();
            this.SuspendLayout();

            // groupBoxTask_NVA
            this.groupBoxTask_NVA.Controls.Add(this.pictureBoxTask_NVA);
            this.groupBoxTask_NVA.Controls.Add(this.textBoxTask_NVA);
            this.groupBoxTask_NVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_NVA.Name = "groupBoxTask_NVA";
            this.groupBoxTask_NVA.Size = new System.Drawing.Size(460, 150);
            this.groupBoxTask_NVA.TabIndex = 0;
            this.groupBoxTask_NVA.TabStop = false;
            this.groupBoxTask_NVA.Text = "Условие";

            // pictureBoxTask_NVA
            this.pictureBoxTask_NVA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_NVA.Image")));
            this.pictureBoxTask_NVA.Location = new System.Drawing.Point(10, 40);
            this.pictureBoxTask_NVA.Name = "pictureBoxTask_NVA";
            this.pictureBoxTask_NVA.Size = new System.Drawing.Size(350, 100);
            this.pictureBoxTask_NVA.TabIndex = 1;
            this.pictureBoxTask_NVA.TabStop = false;

            // textBoxTask_NVA
            this.textBoxTask_NVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_NVA.Location = new System.Drawing.Point(10, 20);
            this.textBoxTask_NVA.Name = "textBoxTask_NVA";
            this.textBoxTask_NVA.ReadOnly = true;
            this.textBoxTask_NVA.Size = new System.Drawing.Size(400, 13);
            this.textBoxTask_NVA.TabIndex = 0;
            this.textBoxTask_NVA.Text = "Дан массив 5×5. Выполнить сортировку по возрастанию в четвертом столбце.";

            // groupBoxInput_NVA
            this.groupBoxInput_NVA.Controls.Add(this.dataGridViewInput_NVA);
            this.groupBoxInput_NVA.Location = new System.Drawing.Point(12, 168);
            this.groupBoxInput_NVA.Name = "groupBoxInput_NVA";
            this.groupBoxInput_NVA.Size = new System.Drawing.Size(320, 180);
            this.groupBoxInput_NVA.TabIndex = 1;
            this.groupBoxInput_NVA.TabStop = false;
            this.groupBoxInput_NVA.Text = "Исходная матрица";

            // dataGridViewInput_NVA
            this.dataGridViewInput_NVA.AllowUserToAddRows = false;
            this.dataGridViewInput_NVA.AllowUserToDeleteRows = false;
            this.dataGridViewInput_NVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_NVA.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewInput_NVA.Name = "dataGridViewInput_NVA";
            this.dataGridViewInput_NVA.ReadOnly = true;
            this.dataGridViewInput_NVA.Size = new System.Drawing.Size(308, 155);
            this.dataGridViewInput_NVA.TabIndex = 0;

            // groupBoxResult_NVA
            this.groupBoxResult_NVA.Controls.Add(this.dataGridViewResult_NVA);
            this.groupBoxResult_NVA.Location = new System.Drawing.Point(338, 168);
            this.groupBoxResult_NVA.Name = "groupBoxResult_NVA";
            this.groupBoxResult_NVA.Size = new System.Drawing.Size(320, 180);
            this.groupBoxResult_NVA.TabIndex = 2;
            this.groupBoxResult_NVA.TabStop = false;
            this.groupBoxResult_NVA.Text = "Отсортированная матрица (по 4-му столбцу)";

            // dataGridViewResult_NVA
            this.dataGridViewResult_NVA.AllowUserToAddRows = false;
            this.dataGridViewResult_NVA.AllowUserToDeleteRows = false;
            this.dataGridViewResult_NVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_NVA.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewResult_NVA.Name = "dataGridViewResult_NVA";
            this.dataGridViewResult_NVA.ReadOnly = true;
            this.dataGridViewResult_NVA.Size = new System.Drawing.Size(308, 155);
            this.dataGridViewResult_NVA.TabIndex = 0;

            // buttonDone_NVA
            this.buttonDone_NVA.Location = new System.Drawing.Point(12, 354);
            this.buttonDone_NVA.Name = "buttonDone_NVA";
            this.buttonDone_NVA.Size = new System.Drawing.Size(87, 38);
            this.buttonDone_NVA.TabIndex = 3;
            this.buttonDone_NVA.Text = "Выполнить";
            this.buttonDone_NVA.UseVisualStyleBackColor = true;
            this.buttonDone_NVA.Click += new System.EventHandler(this.buttonDone_NVA_Click);

            // buttonHelp_NVA
            this.buttonHelp_NVA.BackColor = System.Drawing.SystemColors.Window;
            this.buttonHelp_NVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_NVA.Location = new System.Drawing.Point(105, 354);
            this.buttonHelp_NVA.Name = "buttonHelp_NVA";
            this.buttonHelp_NVA.Size = new System.Drawing.Size(37, 37);
            this.buttonHelp_NVA.TabIndex = 4;
            this.buttonHelp_NVA.Text = "?";
            this.buttonHelp_NVA.UseVisualStyleBackColor = false;
            this.buttonHelp_NVA.Click += new System.EventHandler(this.buttonHelp_NVA_Click);

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 404);
            this.Controls.Add(this.buttonHelp_NVA);
            this.Controls.Add(this.buttonDone_NVA);
            this.Controls.Add(this.groupBoxResult_NVA);
            this.Controls.Add(this.groupBoxInput_NVA);
            this.Controls.Add(this.groupBoxTask_NVA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 7 | Анисимов Н.В.";
            this.groupBoxTask_NVA.ResumeLayout(false);
            this.groupBoxTask_NVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_NVA)).EndInit();
            this.groupBoxInput_NVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_NVA)).EndInit();
            this.groupBoxResult_NVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_NVA)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_NVA;
        private System.Windows.Forms.PictureBox pictureBoxTask_NVA;
        private System.Windows.Forms.TextBox textBoxTask_NVA;
        private System.Windows.Forms.GroupBox groupBoxInput_NVA;
        private System.Windows.Forms.DataGridView dataGridViewInput_NVA;
        private System.Windows.Forms.GroupBox groupBoxResult_NVA;
        private System.Windows.Forms.DataGridView dataGridViewResult_NVA;
        private System.Windows.Forms.Button buttonDone_NVA;
        private System.Windows.Forms.Button buttonHelp_NVA;
    }
}
