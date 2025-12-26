using System;
using System.Windows.Forms;
using Tyuiu.AnisimovNV.Sprint6.Task3.V7.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task3.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_NVA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();

                // Получаем исходную матрицу
                int[,] matrix = ds.GetMatrix();

                // Сортируем матрицу
                int[,] sortedMatrix = ds.Calculate(matrix);

                // Очищаем DataGridView
                dataGridViewResult_NVA.Rows.Clear();
                dataGridViewResult_NVA.Columns.Clear();

                // Настраиваем DataGridView для исходной матрицы
                dataGridViewInput_NVA.Rows.Clear();
                dataGridViewInput_NVA.Columns.Clear();

                // Настраиваем столбцы
                for (int col = 0; col < 5; col++)
                {
                    dataGridViewInput_NVA.Columns.Add($"col{col}", $"Столбец {col + 1}");
                    dataGridViewResult_NVA.Columns.Add($"col{col}", $"Столбец {col + 1}");

                    dataGridViewInput_NVA.Columns[col].Width = 60;
                    dataGridViewResult_NVA.Columns[col].Width = 60;
                }

                // Заполняем исходную матрицу
                for (int row = 0; row < 5; row++)
                {
                    dataGridViewInput_NVA.Rows.Add();
                    for (int col = 0; col < 5; col++)
                    {
                        dataGridViewInput_NVA.Rows[row].Cells[col].Value = matrix[row, col];
                    }
                }

                // Заполняем отсортированную матрицу
                for (int row = 0; row < 5; row++)
                {
                    dataGridViewResult_NVA.Rows.Add();
                    for (int col = 0; col < 5; col++)
                    {
                        dataGridViewResult_NVA.Rows[row].Cells[col].Value = sortedMatrix[row, col];
                    }
                }

                // Подсвечиваем 4-й столбец (индекс 3)
                for (int row = 0; row < 5; row++)
                {
                    dataGridViewResult_NVA.Rows[row].Cells[3].Style.BackColor = System.Drawing.Color.LightYellow;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСТИБ-25-1 Анисимов Н.В.",
                          "Сообщение",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }
    }
}