namespace Tyuiu.AnisimovNV.Sprint6.Task2.V26
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
            this.groupBoxInputData_NVA = new System.Windows.Forms.GroupBox();
            this.labelStart_NVA = new System.Windows.Forms.Label();
            this.labelStop_NVA = new System.Windows.Forms.Label();
            this.textBoxStart_NVA = new System.Windows.Forms.TextBox();
            this.textBoxStop_NVA = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_NVA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_NVA = new System.Windows.Forms.DataGridView();
            this.buttonDone_NVA = new System.Windows.Forms.Button();
            this.buttonHelp_NVA = new System.Windows.Forms.Button();
            this.groupBoxTask_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_NVA)).BeginInit();
            this.groupBoxInputData_NVA.SuspendLayout();
            this.groupBoxOutputData_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_NVA)).BeginInit();
            this.SuspendLayout();

            // groupBoxTask_NVA
            this.groupBoxTask_NVA.Controls.Add(this.pictureBoxTask_NVA);
            this.groupBoxTask_NVA.Controls.Add(this.textBoxTask_NVA);
            this.groupBoxTask_NVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_NVA.Name = "groupBoxTask_NVA";
            this.groupBoxTask_NVA.Size = new System.Drawing.Size(450, 150);
            this.groupBoxTask_NVA.TabIndex = 0;
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
            this.textBoxTask_NVA.Size = new System.Drawing.Size(400, 13);
            this.textBoxTask_NVA.TabIndex = 0;
            this.textBoxTask_NVA.Text = "Табулировать функцию F(x) = sin(x) + cos(2x)/2 - 1,5x на диапазоне [-5; 5] с шагом 1";

            // groupBoxInputData_NVA
            this.groupBoxInputData_NVA.Controls.Add(this.labelStop_NVA);
            this.groupBoxInputData_NVA.Controls.Add(this.labelStart_NVA);
            this.groupBoxInputData_NVA.Controls.Add(this.textBoxStop_NVA);
            this.groupBoxInputData_NVA.Controls.Add(this.textBoxStart_NVA);
            this.groupBoxInputData_NVA.Location = new System.Drawing.Point(12, 168);
            this.groupBoxInputData_NVA.Name = "groupBoxInputData_NVA";
            this.groupBoxInputData_NVA.Size = new System.Drawing.Size(200, 100);
            this.groupBoxInputData_NVA.TabIndex = 1;
            this.groupBoxInputData_NVA.TabStop = false;
            this.groupBoxInputData_NVA.Text = "Ввод данных";

            // labelStart_NVA
            this.labelStart_NVA.AutoSize = true;
            this.labelStart_NVA.Location = new System.Drawing.Point(6, 25);
            this.labelStart_NVA.Name = "labelStart_NVA";
            this.labelStart_NVA.Size = new System.Drawing.Size(70, 13);
            this.labelStart_NVA.TabIndex = 0;
            this.labelStart_NVA.Text = "Старт шага:";

            // labelStop_NVA
            this.labelStop_NVA.AutoSize = true;
            this.labelStop_NVA.Location = new System.Drawing.Point(6, 60);
            this.labelStop_NVA.Name = "labelStop_NVA";
            this.labelStop_NVA.Size = new System.Drawing.Size(69, 13);
            this.labelStop_NVA.TabIndex = 1;
            this.labelStop_NVA.Text = "Конец шага:";

            // textBoxStart_NVA
            this.textBoxStart_NVA.Location = new System.Drawing.Point(80, 22);
            this.textBoxStart_NVA.Name = "textBoxStart_NVA";
            this.textBoxStart_NVA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_NVA.TabIndex = 2;
            this.textBoxStart_NVA.Text = "-5";
            this.textBoxStart_NVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStart_NVA_KeyPress);

            // textBoxStop_NVA
            this.textBoxStop_NVA.Location = new System.Drawing.Point(80, 57);
            this.textBoxStop_NVA.Name = "textBoxStop_NVA";
            this.textBoxStop_NVA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_NVA.TabIndex = 3;
            this.textBoxStop_NVA.Text = "5";
            this.textBoxStop_NVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStop_NVA_KeyPress);

            // groupBoxOutputData_NVA
            this.groupBoxOutputData_NVA.Controls.Add(this.dataGridViewResult_NVA);
            this.groupBoxOutputData_NVA.Location = new System.Drawing.Point(218, 168);
            this.groupBoxOutputData_NVA.Name = "groupBoxOutputData_NVA";
            this.groupBoxOutputData_NVA.Size = new System.Drawing.Size(244, 180);
            this.groupBoxOutputData_NVA.TabIndex = 2;
            this.groupBoxOutputData_NVA.TabStop = false;
            this.groupBoxOutputData_NVA.Text = "Вывод данных";

            // dataGridViewResult_NVA
            this.dataGridViewResult_NVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_NVA.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewResult_NVA.Name = "dataGridViewResult_NVA";
            this.dataGridViewResult_NVA.ReadOnly = true;
            this.dataGridViewResult_NVA.Size = new System.Drawing.Size(232, 155);
            this.dataGridViewResult_NVA.TabIndex = 0;

            // buttonDone_NVA
            this.buttonDone_NVA.Location = new System.Drawing.Point(12, 274);
            this.buttonDone_NVA.Name = "buttonDone_NVA";
            this.buttonDone_NVA.Size = new System.Drawing.Size(87, 38);
            this.buttonDone_NVA.TabIndex = 3;
            this.buttonDone_NVA.Text = "Выполнить";
            this.buttonDone_NVA.UseVisualStyleBackColor = true;
            this.buttonDone_NVA.Click += new System.EventHandler(this.buttonDone_NVA_Click);

            // buttonHelp_NVA
            this.buttonHelp_NVA.BackColor = System.Drawing.SystemColors.Window;
            this.buttonHelp_NVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_NVA.Location = new System.Drawing.Point(105, 274);
            this.buttonHelp_NVA.Name = "buttonHelp_NVA";
            this.buttonHelp_NVA.Size = new System.Drawing.Size(37, 37);
            this.buttonHelp_NVA.TabIndex = 4;
            this.buttonHelp_NVA.Text = "?";
            this.buttonHelp_NVA.UseVisualStyleBackColor = false;
            this.buttonHelp_NVA.Click += new System.EventHandler(this.buttonHelp_NVA_Click);

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 360);
            this.Controls.Add(this.buttonHelp_NVA);
            this.Controls.Add(this.buttonDone_NVA);
            this.Controls.Add(this.groupBoxOutputData_NVA);
            this.Controls.Add(this.groupBoxInputData_NVA);
            this.Controls.Add(this.groupBoxTask_NVA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 26 | Анисимов Н.В.";
            this.groupBoxTask_NVA.ResumeLayout(false);
            this.groupBoxTask_NVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_NVA)).EndInit();
            this.groupBoxInputData_NVA.ResumeLayout(false);
            this.groupBoxInputData_NVA.PerformLayout();
            this.groupBoxOutputData_NVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_NVA)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_NVA;
        private System.Windows.Forms.PictureBox pictureBoxTask_NVA;
        private System.Windows.Forms.TextBox textBoxTask_NVA;
        private System.Windows.Forms.GroupBox groupBoxInputData_NVA;
        private System.Windows.Forms.Label labelStart_NVA;
        private System.Windows.Forms.Label labelStop_NVA;
        private System.Windows.Forms.TextBox textBoxStart_NVA;
        private System.Windows.Forms.TextBox textBoxStop_NVA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_NVA;
        private System.Windows.Forms.DataGridView dataGridViewResult_NVA;
        private System.Windows.Forms.Button buttonDone_NVA;
        private System.Windows.Forms.Button buttonHelp_NVA;
    }
}
