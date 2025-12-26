using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.AnisimovNV.Sprint7.Task7.V12.Lib;

namespace Tyuiu.AnisimovNV.Sprint7.Task7.V12
{
    public partial class FormMain : Form
    {
        private DataService dataService;

        public FormMain()
        {
            InitializeComponent();
            dataService = new DataService();
            buttonSave_NVA.Enabled = false;
        }

        private void buttonLoadData_NVA_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogInput_NVA.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialogInput_NVA.Title = "Выберите входной файл";

                if (openFileDialogInput_NVA.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialogInput_NVA.FileName;

                    if (File.Exists(filePath))
                    {
                        // Загрузка матрицы
                        int[,] inputMatrix = dataService.GetMatrix(filePath);

                        // Отображение исходной матрицы
                        DisplayMatrixInDataGridView(dataGridViewIn, inputMatrix);

                        // Модификация матрицы
                        int[,] outputMatrix = dataService.ModifyMatrix(inputMatrix);

                        // Отображение результата
                        DisplayMatrixInDataGridView(dataGridViewOut, outputMatrix);

                        // Сохраняем результат для возможного сохранения
                        this.Tag = outputMatrix;

                        // Активируем кнопку сохранения
                        buttonSave_NVA.Enabled = true;

                        MessageBox.Show("Данные успешно загружены!", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла:\n{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_NVA_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogOutput_NVA.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialogOutput_NVA.Title = "Сохранить результат";
                saveFileDialogOutput_NVA.FileName = "OutPutFileTask7.csv";

                if (saveFileDialogOutput_NVA.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialogOutput_NVA.FileName;

                    if (this.Tag != null && this.Tag is int[,] outputMatrix)
                    {
                        dataService.SaveMatrixToFile(outputMatrix, filePath);
                        MessageBox.Show($"Результат сохранен в файл:\n{filePath}", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла:\n{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 7 выполнил студент группы ИСТИБ-25-1 Анисимов Н.В.",
                          "Сообщение",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        private void DisplayMatrixInDataGridView(DataGridView dataGridView, int[,] matrix)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Создаем столбцы
            for (int j = 0; j < columns; j++)
            {
                dataGridView.Columns.Add($"Column{j}", $"Столбец {j + 1}");
                dataGridView.Columns[j].Width = 50;
                dataGridView.Columns[j].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Добавляем строки
            dataGridView.RowCount = rows;

            // Заполняем данными
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            // Выделяем 9-й столбец цветом
            if (columns > 8)
            {
                for (int i = 0; i < rows; i++)
                {
                    dataGridView.Rows[i].Cells[8].Style.BackColor = System.Drawing.Color.LightYellow;
                }
            }
        }
    }
}