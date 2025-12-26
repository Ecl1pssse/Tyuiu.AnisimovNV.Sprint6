namespace Tyuiu.AnisimovNV.Sprint6.Task7.V12
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxTask_NVA;
        private System.Windows.Forms.TextBox textBoxTask_NVA;
        private System.Windows.Forms.GroupBox groupBoxInput_NVA;
        private System.Windows.Forms.DataGridView dataGridViewIn_NVA;
        private System.Windows.Forms.Button buttonOpen_NVA;
        private System.Windows.Forms.GroupBox groupBoxOutput_NVA;
        private System.Windows.Forms.DataGridView dataGridViewOut_NVA;
        private System.Windows.Forms.Button buttonSave_NVA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_NVA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_NVA;
        private System.Windows.Forms.Button buttonHelp_NVA;

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
            this.dataGridViewIn_NVA = new System.Windows.Forms.DataGridView();
            this.buttonOpen_NVA = new System.Windows.Forms.Button();
            this.groupBoxOutput_NVA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_NVA = new System.Windows.Forms.DataGridView();
            this.buttonSave_NVA = new System.Windows.Forms.Button();
            this.openFileDialogTask_NVA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_NVA = new System.Windows.Forms.SaveFileDialog();
            this.buttonHelp_NVA = new System.Windows.Forms.Button();
            this.groupBoxTask_NVA.SuspendLayout();
            this.groupBoxInput_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_NVA)).BeginInit();
            this.groupBoxOutput_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_NVA)).BeginInit();
            this.SuspendLayout();

            this.groupBoxTask_NVA.Controls.Add(this.textBoxTask_NVA);
            this.groupBoxTask_NVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_NVA.Name = "groupBoxTask_NVA";
            this.groupBoxTask_NVA.Size = new System.Drawing.Size(760, 60);
            this.groupBoxTask_NVA.TabIndex = 0;
            this.groupBoxTask_NVA.TabStop = false;
            this.groupBoxTask_NVA.Text = "Условие";

            this.textBoxTask_NVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_NVA.Location = new System.Drawing.Point(10, 20);
            this.textBoxTask_NVA.Multiline = true;
            this.textBoxTask_NVA.Name = "textBoxTask_NVA";
            this.textBoxTask_NVA.ReadOnly = true;
            this.textBoxTask_NVA.Size = new System.Drawing.Size(740, 30);
            this.textBoxTask_NVA.Text = "В файле InPutFileTask7V12.csv хранится матрица. Загрузить матрицу и в 9-м столбце заменить значения, не равные 10, на 0. Сохранить результат.";

            this.groupBoxInput_NVA.Controls.Add(this.dataGridViewIn_NVA);
            this.groupBoxInput_NVA.Controls.Add(this.buttonOpen_NVA);
            this.groupBoxInput_NVA.Location = new System.Drawing.Point(12, 80);
            this.groupBoxInput_NVA.Name = "groupBoxInput_NVA";
            this.groupBoxInput_NVA.Size = new System.Drawing.Size(370, 320);
            this.groupBoxInput_NVA.TabIndex = 1;
            this.groupBoxInput_NVA.TabStop = false;
            this.groupBoxInput_NVA.Text = "Исходная матрица";

            this.dataGridViewIn_NVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_NVA.Location = new System.Drawing.Point(10, 60);
            this.dataGridViewIn_NVA.Name = "dataGridViewIn_NVA";
            this.dataGridViewIn_NVA.Size = new System.Drawing.Size(350, 250);
            this.dataGridViewIn_NVA.TabIndex = 1;

            this.buttonOpen_NVA.Location = new System.Drawing.Point(10, 20);
            this.buttonOpen_NVA.Name = "buttonOpen_NVA";
            this.buttonOpen_NVA.Size = new System.Drawing.Size(150, 30);
            this.buttonOpen_NVA.TabIndex = 0;
            this.buttonOpen_NVA.Text = "Открыть файл";
            this.buttonOpen_NVA.UseVisualStyleBackColor = true;
            this.buttonOpen_NVA.Click += new System.EventHandler(this.buttonOpen_NVA_Click);

            this.groupBoxOutput_NVA.Controls.Add(this.dataGridViewOut_NVA);
            this.groupBoxOutput_NVA.Controls.Add(this.buttonSave_NVA);
            this.groupBoxOutput_NVA.Location = new System.Drawing.Point(390, 80);
            this.groupBoxOutput_NVA.Name = "groupBoxOutput_NVA";
            this.groupBoxOutput_NVA.Size = new System.Drawing.Size(370, 320);
            this.groupBoxOutput_NVA.TabIndex = 2;
            this.groupBoxOutput_NVA.TabStop = false;
            this.groupBoxOutput_NVA.Text = "Результат";

            this.dataGridViewOut_NVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_NVA.Location = new System.Drawing.Point(10, 60);
            this.dataGridViewOut_NVA.Name = "dataGridViewOut_NVA";
            this.dataGridViewOut_NVA.Size = new System.Drawing.Size(350, 250);
            this.dataGridViewOut_NVA.TabIndex = 2;

            this.buttonSave_NVA.Enabled = false;
            this.buttonSave_NVA.Location = new System.Drawing.Point(10, 20);
            this.buttonSave_NVA.Name = "buttonSave_NVA";
            this.buttonSave_NVA.Size = new System.Drawing.Size(150, 30);
            this.buttonSave_NVA.TabIndex = 1;
            this.buttonSave_NVA.Text = "Сохранить результат";
            this.buttonSave_NVA.UseVisualStyleBackColor = true;
            this.buttonSave_NVA.Click += new System.EventHandler(this.buttonSave_NVA_Click);

            this.buttonHelp_NVA.Location = new System.Drawing.Point(720, 12);
            this.buttonHelp_NVA.Name = "buttonHelp_NVA";
            this.buttonHelp_NVA.Size = new System.Drawing.Size(52, 23);
            this.buttonHelp_NVA.TabIndex = 3;
            this.buttonHelp_NVA.Text = "?";
            this.buttonHelp_NVA.UseVisualStyleBackColor = true;
            this.buttonHelp_NVA.Click += new System.EventHandler(this.buttonHelp_NVA_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.buttonHelp_NVA);
            this.Controls.Add(this.groupBoxOutput_NVA);
            this.Controls.Add(this.groupBoxInput_NVA);
            this.Controls.Add(this.groupBoxTask_NVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 12 | Анисимов Н.В.";
            this.groupBoxTask_NVA.ResumeLayout(false);
            this.groupBoxTask_NVA.PerformLayout();
            this.groupBoxInput_NVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_NVA)).EndInit();
            this.groupBoxOutput_NVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_NVA)).EndInit();
            this.ResumeLayout(false);
        }
    }
}