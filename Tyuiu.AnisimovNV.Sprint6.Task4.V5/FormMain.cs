using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.AnisimovNV.Sprint6.Task4.V5.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task4.V5
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
                int startValue = -5;
                int stopValue = 5;

                double[] values = ds.GetMassFunction(startValue, stopValue);

                // Выводим в TextBox
                textBoxResult_NVA.Text = "";
                textBoxResult_NVA.AppendText("Таблица значений:\r\n");
                textBoxResult_NVA.AppendText("F(x) = (2*sin(x))/(3*x+1.2) + cos(x) - 7*x*2\r\n\r\n");

                for (int i = 0; i < values.Length; i++)
                {
                    int x = startValue + i;
                    textBoxResult_NVA.AppendText($"F({x}) = {values[i]:F2}\r\n");
                }

                // Сохраняем в файл
                SaveToFile(values, startValue, stopValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveToFile(double[] values, int startValue, int stopValue)
        {
            try
            {
                string path = "OutPutFileTask4V5.txt";

                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("Таблица значений функции:");
                    writer.WriteLine("F(x) = (2*sin(x))/(3*x+1.2) + cos(x) - 7*x*2");
                    writer.WriteLine($"Диапазон: [{startValue}; {stopValue}], шаг: 1\r\n");

                    for (int i = 0; i < values.Length; i++)
                    {
                        int x = startValue + i;
                        writer.WriteLine($"F({x}) = {values[i]:F2}");
                    }
                }

                MessageBox.Show($"Файл сохранён: {Path.GetFullPath(path)}",
                              "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИСТИБ-25-1 Анисимов Н.В.",
                          "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}