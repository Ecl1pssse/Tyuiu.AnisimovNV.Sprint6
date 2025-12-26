using System;
using System.Windows.Forms;
using Tyuiu.AnisimovNV.Sprint6.Task6.V30.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task6.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_NVA_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "InPutFileTask6V30.txt";
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                try
                {
                    // Показать содержимое файла
                    textBoxInput_NVA.Text = System.IO.File.ReadAllText(filePath);

                    // Обработать файл
                    DataService ds = new DataService();
                    string result = ds.CollectTextFromFile(filePath);
                    textBoxOutput_NVA.Text = result;
                }
                catch
                {
                    MessageBox.Show("Ошибка при чтении файла");
                }
            }
        }

        private void buttonInfo_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание 6 выполнил студент группы ИСТИБ-25-1 Анисимов Н.В.");
        }
    }
}