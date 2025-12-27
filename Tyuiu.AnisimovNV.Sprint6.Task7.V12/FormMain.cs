using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.AnisimovNV.Sprint6.Task7.V12.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task7.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonSave_NVA.Enabled = false;
        }

        private DataService ds = new DataService();
        private int[,] sourceMatrix;
        private int[,] resultMatrix;

        private void buttonOpen_NVA_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_NVA.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialogTask_NVA.FileName = "InPutFileTask7V12.csv";
                openFileDialogTask_NVA.InitialDirectory = Application.StartupPath;

                if (openFileDialogTask_NVA.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialogTask_NVA.FileName;

                    if (!File.Exists(filePath))
                    {
                        MessageBox.Show("Файл не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Загружаем исходную матрицу (без изменений)
                    sourceMatrix = ds.LoadMatrixWithoutModify(filePath);

                    // Отображаем исходную матрицу
                    DisplayMatrix(sourceMatrix, dataGridViewIn_NVA);

                    // Получаем преобразованную матрицу
                    resultMatrix = ds.GetMatrix(sourceMatrix);

                    // Отображаем результат
                    DisplayMatrix(resultMatrix, dataGridViewOut_NVA);

                    // Подсвечиваем 9-й столбец
                    HighlightNinthColumn();

                    buttonSave_NVA.Enabled = true;

                    MessageBox.Show("Данные успешно загружены и преобразованы!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:\n{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSave_NVA.Enabled = false;
            }
        }

        private void buttonSave_NVA_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogMatrix_NVA.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialogMatrix_NVA.FileName = "OutPutFileTask7V12.csv";
                saveFileDialogMatrix_NVA.InitialDirectory = Application.StartupPath;

                if (saveFileDialogMatrix_NVA.ShowDialog() == DialogResult.OK)
                {
                    SaveMatrixToFile(resultMatrix, saveFileDialogMatrix_NVA.FileName);

                    MessageBox.Show($"Файл сохранен:\n{saveFileDialogMatrix_NVA.FileName}", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении:\n{ex.Message}", "Ошибка",
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

        private void DisplayMatrix(int[,] matrix, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Создаем столбцы
            for (int j = 0; j < columns; j++)
            {
                dgv.Columns.Add($"col{j}", $"Столбец {j + 1}");
                dgv.Columns[j].Width = 50;
                dgv.Columns[j].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }

            // Заполняем данными
            dgv.RowCount = rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dgv.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void HighlightNinthColumn()
        {
            if (dataGridViewOut_NVA.Columns.Count > 8)
            {
                for (int i = 0; i < dataGridViewOut_NVA.Rows.Count; i++)
                {
                    dataGridViewOut_NVA.Rows[i].Cells[8].Style.BackColor =
                        System.Drawing.Color.Yellow;
                }
            }
        }

        private void SaveMatrixToFile(int[,] matrix, string path)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < rows; i++)
                {
                    string[] values = new string[columns];
                    for (int j = 0; j < columns; j++)
                    {
                        values[j] = matrix[i, j].ToString();
                    }
                    writer.WriteLine(string.Join(";", values));
                }
            }
        }

        private void openFileDialogTask_NVA_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void saveFileDialogMatrix_NVA_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void textBoxTask_NVA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}