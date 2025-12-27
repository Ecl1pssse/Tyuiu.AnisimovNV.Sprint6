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
            groupBoxTask_NVA = new GroupBox();
            textBoxTask_NVA = new TextBox();
            groupBoxInput_NVA = new GroupBox();
            dataGridViewIn_NVA = new DataGridView();
            buttonOpen_NVA = new Button();
            groupBoxOutput_NVA = new GroupBox();
            dataGridViewOut_NVA = new DataGridView();
            buttonSave_NVA = new Button();
            openFileDialogTask_NVA = new OpenFileDialog();
            saveFileDialogMatrix_NVA = new SaveFileDialog();
            buttonHelp_NVA = new Button();
            groupBoxTask_NVA.SuspendLayout();
            groupBoxInput_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_NVA).BeginInit();
            groupBoxOutput_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_NVA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_NVA
            // 
            groupBoxTask_NVA.Controls.Add(textBoxTask_NVA);
            groupBoxTask_NVA.Location = new Point(14, 14);
            groupBoxTask_NVA.Margin = new Padding(4, 3, 4, 3);
            groupBoxTask_NVA.Name = "groupBoxTask_NVA";
            groupBoxTask_NVA.Padding = new Padding(4, 3, 4, 3);
            groupBoxTask_NVA.Size = new Size(887, 69);
            groupBoxTask_NVA.TabIndex = 0;
            groupBoxTask_NVA.TabStop = false;
            groupBoxTask_NVA.Text = "Условие";
            // 
            // textBoxTask_NVA
            // 
            textBoxTask_NVA.BorderStyle = BorderStyle.None;
            textBoxTask_NVA.Location = new Point(12, 23);
            textBoxTask_NVA.Margin = new Padding(4, 3, 4, 3);
            textBoxTask_NVA.Multiline = true;
            textBoxTask_NVA.Name = "textBoxTask_NVA";
            textBoxTask_NVA.ReadOnly = true;
            textBoxTask_NVA.Size = new Size(863, 35);
            textBoxTask_NVA.TabIndex = 0;
            textBoxTask_NVA.Text = "В файле InPutFileTask7V12.csv хранится матрица. Загрузить матрицу и в 9-м столбце заменить значения, не равные 10, на 0. Сохранить результат.";
            textBoxTask_NVA.TextChanged += textBoxTask_NVA_TextChanged;
            // 
            // groupBoxInput_NVA
            // 
            groupBoxInput_NVA.Controls.Add(dataGridViewIn_NVA);
            groupBoxInput_NVA.Controls.Add(buttonOpen_NVA);
            groupBoxInput_NVA.Location = new Point(14, 92);
            groupBoxInput_NVA.Margin = new Padding(4, 3, 4, 3);
            groupBoxInput_NVA.Name = "groupBoxInput_NVA";
            groupBoxInput_NVA.Padding = new Padding(4, 3, 4, 3);
            groupBoxInput_NVA.Size = new Size(432, 369);
            groupBoxInput_NVA.TabIndex = 1;
            groupBoxInput_NVA.TabStop = false;
            groupBoxInput_NVA.Text = "Исходная матрица";
            // 
            // dataGridViewIn_NVA
            // 
            dataGridViewIn_NVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_NVA.Location = new Point(12, 69);
            dataGridViewIn_NVA.Margin = new Padding(4, 3, 4, 3);
            dataGridViewIn_NVA.Name = "dataGridViewIn_NVA";
            dataGridViewIn_NVA.Size = new Size(408, 288);
            dataGridViewIn_NVA.TabIndex = 1;
            // 
            // buttonOpen_NVA
            // 
            buttonOpen_NVA.Location = new Point(12, 23);
            buttonOpen_NVA.Margin = new Padding(4, 3, 4, 3);
            buttonOpen_NVA.Name = "buttonOpen_NVA";
            buttonOpen_NVA.Size = new Size(175, 35);
            buttonOpen_NVA.TabIndex = 0;
            buttonOpen_NVA.Text = "Открыть файл";
            buttonOpen_NVA.UseVisualStyleBackColor = true;
            buttonOpen_NVA.Click += buttonOpen_NVA_Click;
            // 
            // groupBoxOutput_NVA
            // 
            groupBoxOutput_NVA.Controls.Add(dataGridViewOut_NVA);
            groupBoxOutput_NVA.Controls.Add(buttonSave_NVA);
            groupBoxOutput_NVA.Location = new Point(455, 92);
            groupBoxOutput_NVA.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutput_NVA.Name = "groupBoxOutput_NVA";
            groupBoxOutput_NVA.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutput_NVA.Size = new Size(432, 369);
            groupBoxOutput_NVA.TabIndex = 2;
            groupBoxOutput_NVA.TabStop = false;
            groupBoxOutput_NVA.Text = "Результат";
            // 
            // dataGridViewOut_NVA
            // 
            dataGridViewOut_NVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_NVA.Location = new Point(12, 69);
            dataGridViewOut_NVA.Margin = new Padding(4, 3, 4, 3);
            dataGridViewOut_NVA.Name = "dataGridViewOut_NVA";
            dataGridViewOut_NVA.Size = new Size(408, 288);
            dataGridViewOut_NVA.TabIndex = 2;
            // 
            // buttonSave_NVA
            // 
            buttonSave_NVA.Enabled = false;
            buttonSave_NVA.Location = new Point(12, 23);
            buttonSave_NVA.Margin = new Padding(4, 3, 4, 3);
            buttonSave_NVA.Name = "buttonSave_NVA";
            buttonSave_NVA.Size = new Size(175, 35);
            buttonSave_NVA.TabIndex = 1;
            buttonSave_NVA.Text = "Сохранить результат";
            buttonSave_NVA.UseVisualStyleBackColor = true;
            buttonSave_NVA.Click += buttonSave_NVA_Click;
            // 
            // openFileDialogTask_NVA
            // 
            openFileDialogTask_NVA.FileOk += openFileDialogTask_NVA_FileOk;
            // 
            // saveFileDialogMatrix_NVA
            // 
            saveFileDialogMatrix_NVA.FileOk += saveFileDialogMatrix_NVA_FileOk;
            // 
            // buttonHelp_NVA
            // 
            buttonHelp_NVA.Location = new Point(840, 14);
            buttonHelp_NVA.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_NVA.Name = "buttonHelp_NVA";
            buttonHelp_NVA.Size = new Size(61, 27);
            buttonHelp_NVA.TabIndex = 3;
            buttonHelp_NVA.Text = "?";
            buttonHelp_NVA.UseVisualStyleBackColor = true;
            buttonHelp_NVA.Click += buttonHelp_NVA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 474);
            Controls.Add(buttonHelp_NVA);
            Controls.Add(groupBoxOutput_NVA);
            Controls.Add(groupBoxInput_NVA);
            Controls.Add(groupBoxTask_NVA);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 12 | Анисимов Н.В.";
            groupBoxTask_NVA.ResumeLayout(false);
            groupBoxTask_NVA.PerformLayout();
            groupBoxInput_NVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_NVA).EndInit();
            groupBoxOutput_NVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_NVA).EndInit();
            ResumeLayout(false);
        }
    }
}