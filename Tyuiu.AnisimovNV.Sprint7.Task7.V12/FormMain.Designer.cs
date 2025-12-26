namespace Tyuiu.AnisimovNV.Sprint7.Task7.V12
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxTask_NVA;
        private System.Windows.Forms.TextBox textBoxTask_NVA;
        private System.Windows.Forms.GroupBox groupBoxInput_NVA;
        private System.Windows.Forms.Button buttonLoadData_NVA;
        private System.Windows.Forms.DataGridView dataGridViewIn;
        private System.Windows.Forms.GroupBox groupBoxOutput_NVA;
        private System.Windows.Forms.Button buttonSave_NVA;
        private System.Windows.Forms.DataGridView dataGridViewOut;
        private System.Windows.Forms.OpenFileDialog openFileDialogInput_NVA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutput_NVA;
        private System.Windows.Forms.Button buttonHelp_NVA;
        private System.Windows.Forms.Label labelIn_NVA;
        private System.Windows.Forms.Label labelOut_NVA;

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
            this.groupBoxTask_NVA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_NVA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_NVA = new System.Windows.Forms.GroupBox();
            this.labelIn_NVA = new System.Windows.Forms.Label();
            this.dataGridViewIn = new System.Windows.Forms.DataGridView();
            this.buttonLoadData_NVA = new System.Windows.Forms.Button();
            this.groupBoxOutput_NVA = new System.Windows.Forms.GroupBox();
            this.labelOut_NVA = new System.Windows.Forms.Label();
            this.dataGridViewOut = new System.Windows.Forms.DataGridView();
            this.buttonSave_NVA = new System.Windows.Forms.Button();
            this.openFileDialogInput_NVA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogOutput_NVA = new System.Windows.Forms.SaveFileDialog();
            this.buttonHelp_NVA = new System.Windows.Forms.Button();
            this.groupBoxTask_NVA.SuspendLayout();
            this.groupBoxInput_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).BeginInit();
            this.groupBoxOutput_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).BeginInit();
            this.SuspendLayout();

            // groupBoxTask_NVA
            this.groupBoxTask_NVA.Controls.Add(this.textBoxTask_NVA);
            this.groupBoxTask_NVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_NVA.Name = "groupBoxTask_NVA";
            this.groupBoxTask_NVA.Size = new System.Drawing.Size(760, 60);
            this.groupBoxTask_NVA.TabIndex = 0;
            this.groupBoxTask_NVA.TabStop = false;
            this.groupBoxTask_NVA.Text = "Задание";

            // textBoxTask_NVA
            this.textBoxTask_NVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_NVA.Location = new System.Drawing.Point(10, 20);
            this.textBoxTask_NVA.Multiline = true;
            this.textBoxTask_NVA.Name = "textBoxTask_NVA";
            this.textBoxTask_NVA.ReadOnly = true;
            this.textBoxTask_NVA.Size = new System.Drawing.Size(740, 30);
            this.textBoxTask_NVA.Text = "Загрузить матрицу из CSV, в 9-м столбце заменить значения ≠10 на 0, сохранить результат.";

            // groupBoxInput_NVA
            this.groupBoxInput_NVA.Controls.Add(this.labelIn_NVA);
            this.groupBoxInput_NVA.Controls.Add(this.dataGridViewIn);
            this.groupBoxInput_NVA.Controls.Add(this.buttonLoadData_NVA);
            this.groupBoxInput_NVA.Location = new System.Drawing.Point(12, 78);
            this.groupBoxInput_NVA.Name = "groupBoxInput_NVA";
            this.groupBoxInput_NVA.Size = new System.Drawing.Size(370, 350);
            this.groupBoxInput_NVA.TabIndex = 1;
            this.groupBoxInput_NVA.TabStop = false;
            this.groupBoxInput_NVA.Text = "Входные данные";

            // labelIn_NVA
            this.labelIn_NVA.AutoSize = true;
            this.labelIn_NVA.Location = new System.Drawing.Point(10, 70);
            this.labelIn_NVA.Name = "labelIn_NVA";
            this.labelIn_NVA.Size = new System.Drawing.Size(90, 13);
            this.labelIn_NVA.Text = "Исходная матрица";

            // dataGridViewIn
            this.dataGridViewIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn.Location = new System.Drawing.Point(10, 90);
            this.dataGridViewIn.Name = "dataGridViewIn";
            this.dataGridViewIn.Size = new System.Drawing.Size(350, 250);
            this.dataGridViewIn.TabIndex = 1;

            // buttonLoadData_NVA
            this.buttonLoadData_NVA.Location = new System.Drawing.Point(10, 25);
            this.buttonLoadData_NVA.Name = "buttonLoadData_NVA";
            this.buttonLoadData_NVA.Size = new System.Drawing.Size(150, 30);
            this.buttonLoadData_NVA.Text = "Загрузить файл";
            this.buttonLoadData_NVA.UseVisualStyleBackColor = true;
            this.buttonLoadData_NVA.Click += new System.EventHandler(this.buttonLoadData_NVA_Click);

            // groupBoxOutput_NVA
            this.groupBoxOutput_NVA.Controls.Add(this.labelOut_NVA);
            this.groupBoxOutput_NVA.Controls.Add(this.dataGridViewOut);
            this.groupBoxOutput_NVA.Controls.Add(this.buttonSave_NVA);
            this.groupBoxOutput_NVA.Location = new System.Drawing.Point(392, 78);
            this.groupBoxOutput_NVA.Name = "groupBoxOutput_NVA";
            this.groupBoxOutput_NVA.Size = new System.Drawing.Size(380, 350);
            this.groupBoxOutput_NVA.TabIndex = 2;
            this.groupBoxOutput_NVA.TabStop = false;
            this.groupBoxOutput_NVA.Text = "Результат";

            // labelOut_NVA
            this.labelOut_NVA.AutoSize = true;
            this.labelOut_NVA.Location = new System.Drawing.Point(10, 70);
            this.labelOut_NVA.Name = "labelOut_NVA";
            this.labelOut_NVA.Size = new System.Drawing.Size(120, 13);
            this.labelOut_NVA.Text = "Модифицированная матрица";

            // dataGridViewOut
            this.dataGridViewOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut.Location = new System.Drawing.Point(10, 90);
            this.dataGridViewOut.Name = "dataGridViewOut";
            this.dataGridViewOut.Size = new System.Drawing.Size(360, 250);
            this.dataGridViewOut.TabIndex = 1;

            // buttonSave_NVA
            this.buttonSave_NVA.Enabled = false;
            this.buttonSave_NVA.Location = new System.Drawing.Point(10, 25);
            this.buttonSave_NVA.Name = "buttonSave_NVA";
            this.buttonSave_NVA.Size = new System.Drawing.Size(150, 30);
            this.buttonSave_NVA.Text = "Сохранить результат";
            this.buttonSave_NVA.UseVisualStyleBackColor = true;
            this.buttonSave_NVA.Click += new System.EventHandler(this.buttonSave_NVA_Click);

            // openFileDialogInput_NVA
            this.openFileDialogInput_NVA.Filter = "CSV files|*.csv|All files|*.*";

            // saveFileDialogOutput_NVA
            this.saveFileDialogOutput_NVA.Filter = "CSV files|*.csv|All files|*.*";

            // buttonHelp_NVA
            this.buttonHelp_NVA.Location = new System.Drawing.Point(720, 12);
            this.buttonHelp_NVA.Name = "buttonHelp_NVA";
            this.buttonHelp_NVA.Size = new System.Drawing.Size(52, 23);
            this.buttonHelp_NVA.Text = "?";
            this.buttonHelp_NVA.UseVisualStyleBackColor = true;
            this.buttonHelp_NVA.Click += new System.EventHandler(this.buttonHelp_NVA_Click);

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.buttonHelp_NVA);
            this.Controls.Add(this.groupBoxOutput_NVA);
            this.Controls.Add(this.groupBoxInput_NVA);
            this.Controls.Add(this.groupBoxTask_NVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 7 | Задание 7 | Вариант 12 | Анисимов Н.В.";
            this.groupBoxTask_NVA.ResumeLayout(false);
            this.groupBoxTask_NVA.PerformLayout();
            this.groupBoxInput_NVA.ResumeLayout(false);
            this.groupBoxInput_NVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).EndInit();
            this.groupBoxOutput_NVA.ResumeLayout(false);
            this.groupBoxOutput_NVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).EndInit();
            this.ResumeLayout(false);
        }
    }
}