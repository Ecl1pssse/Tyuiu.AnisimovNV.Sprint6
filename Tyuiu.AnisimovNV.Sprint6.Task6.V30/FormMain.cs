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

        private void buttonOpen_NVA_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FileName = "InPutFileTask6V30.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog1.FileName;

                    // Читаем файл
                    textBoxIn_NVA.Text = System.IO.File.ReadAllText(path);

                    // Обрабатываем
                    DataService ds = new DataService();
                    textBoxOut_NVA.Text = ds.CollectTextFromFile(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void buttonInfo_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6 выполнил студент группы ИСТИБ-25-1 Анисимов Н.В.");
        }
    }
}