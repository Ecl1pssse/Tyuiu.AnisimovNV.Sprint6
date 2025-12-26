using System;
using System.Windows.Forms;
using Tyuiu.AnisimovNV.Sprint6.Task1.V27.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task1.V27
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

                textBoxResult_NVA.Text = "";

                textBoxResult_NVA.AppendText("+----------+----------+\r\n");
                textBoxResult_NVA.AppendText("|    X     |   F(x)   |\r\n");
                textBoxResult_NVA.AppendText("+----------+----------+\r\n");

                int count = 0;
                for (int x = startValue; x <= stopValue; x++)
                {
                    textBoxResult_NVA.AppendText($"|{x,5}     | {result[count],7:F2}  |\r\n");
                    count++;
                }

                textBoxResult_NVA.AppendText("+----------+----------+\r\n");
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСТИБ-25-1 Анисимов Н.В.",
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