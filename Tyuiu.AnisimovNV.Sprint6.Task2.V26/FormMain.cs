using System;
using System.Data;
using System.Windows.Forms;
using Tyuiu.AnisimovNV.Sprint6.Task2.V26.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task2.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_NVA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_NVA.Text);
                int stopValue = Convert.ToInt32(textBoxStop_NVA.Text);

                double[] result = ds.GetMassFunction(startValue, stopValue);

                // Создаем таблицу для DataGridView
                DataTable dt = new DataTable();
                dt.Columns.Add("X", typeof(int));
                dt.Columns.Add("F(x)", typeof(double));

                // Заполняем таблицу
                int count = 0;
                for (int x = startValue; x <= stopValue; x++)
                {
                    dt.Rows.Add(x, result[count]);
                    count++;
                }

                // Привязываем таблицу к DataGridView
                dataGridViewResult_NVA.DataSource = dt;

                // Настраиваем внешний вид DataGridView
                dataGridViewResult_NVA.Columns[0].Width = 50;
                dataGridViewResult_NVA.Columns[1].Width = 100;
                dataGridViewResult_NVA.Columns[1].DefaultCellStyle.Format = "F2";
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИСТИБ-25-1 Анисимов Н.В.",
                          "Сообщение",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        private void textBoxStart_NVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxStop_NVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}