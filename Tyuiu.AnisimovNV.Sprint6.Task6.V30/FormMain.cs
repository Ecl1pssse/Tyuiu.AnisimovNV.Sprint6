using System;
using System.Windows.Forms;
using Tyuiu.AnisimovNV.Sprint6.Task6.V30.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task6.V30
{
    public partial class FormMain : Form
    {
        private string filePath;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_NVA_Click(object sender, EventArgs e)
        {
            // Настраиваем OpenFileDialog
            openFileDialogTask_NVA.FileName = "InPutFileTask6V30.txt";
            openFileDialogTask_NVA.InitialDirectory = @"C:\";
            openFileDialogTask_NVA.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialogTask_NVA.FilterIndex = 1;

            // Открываем диалог выбора файла
            if (openFileDialogTask_NVA.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialogTask_NVA.FileName;

                try
                {
                    // Загружаем содержимое файла
                    textBoxInput_NVA.Text = System.IO.File.ReadAllText(filePath);
                    textBoxInput_NVA.ScrollBars = ScrollBars.Both;

                    // Обрабатываем файл
                    ProcessFile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка чтения файла: {ex.Message}",
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ProcessFile()
        {
            try
            {
                DataService ds = new DataService();
                string result = ds.CollectTextFromFile(filePath);
                textBoxOutput_NVA.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обработки файла: {ex.Message}",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6 выполнил студент группы ИСТИБ-25-1 Анисимов Н.В.",
                          "Сообщение",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }
    }
}