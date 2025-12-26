using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.AnisimovNV.Sprint7.Task7.V12.Lib;

namespace Tyuiu.AnisimovNV.Sprint7.Task7.V12
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();
        private int[,] currentMatrix;

        public FormMain()
        {
            InitializeComponent();
            buttonSave_NVA.Enabled = false;
        }

        private void buttonLoadData_NVA_Click(object sender, EventArgs e)
        {
            if (openFileDialogInput_NVA.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialogInput_NVA.FileName;
                    int[,] inputMatrix = ds.GetMatrix(path);

                    // Показываем исходную
                    ShowMatrix(inputMatrix, dataGridViewIn);

                    // Модифицируем
                    int[,] outputMatrix = ds.ModifyMatrix(inputMatrix);
                    currentMatrix = outputMatrix;

                    // Показываем результат
                    ShowMatrix(outputMatrix, dataGridViewOut);

                    buttonSave_NVA.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_NVA_Click(object sender, EventArgs e)
        {
            if (saveFileDialogOutput_NVA.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ds.SaveMatrixToFile(currentMatrix, saveFileDialogOutput_NVA.FileName);
                    MessageBox.Show("Сохранено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание 7 выполнил студент группы ИСТИБ-25-1 Анисимов Н.В.", "Справка");
        }

        private void ShowMatrix(int[,] matrix, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int j = 0; j < cols; j++)
            {
                dgv.Columns.Add($"col{j}", $"Столбец {j + 1}");
                dgv.Columns[j].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                dgv.Rows.Add();
                for (int j = 0; j < cols; j++)
                {
                    dgv.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
    }
}