using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.AnisimovNV.Sprint6.Task5.V25.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task5.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonLoad_NVA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();

                // Путь к файлу (в той же папке, что и exe)
                string path = "InPutFileTask5V25.txt";

                if (!File.Exists(path))
                {
                    // Если файла нет, создаем тестовый
                    CreateTestFile(path);
                    MessageBox.Show($"Создан тестовый файл: {path}", "Информация",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Загружаем данные
                double[] values = ds.LoadFromDataFile(path);

                // Отображаем в DataGridView
                dataGridView_NVA.Rows.Clear();
                dataGridView_NVA.Columns.Clear();

                // Создаем колонки
                dataGridView_NVA.Columns.Add("Index", "№");
                dataGridView_NVA.Columns.Add("Value", "Значение");
                dataGridView_NVA.Columns[1].DefaultCellStyle.Format = "F3";

                // Заполняем данными
                for (int i = 0; i < values.Length; i++)
                {
                    dataGridView_NVA.Rows.Add(i + 1, values[i]);
                }

                labelStatus_NVA.Text = $"Загружено {values.Length} ненулевых значений";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateTestFile(string path)
        {
            // Создаем тестовый файл с данными
            string[] testData = {
                "3.14159",
                "0",
                "-2.5",
                "0.0",
                "1.234567",
                "0",
                "-0.001",
                "4.5",
                "0",
                "6.789"
            };

            File.WriteAllLines(path, testData);
        }

        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСТИБ-25-1 Анисимов Н.В.",
                          "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}