using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.AnisimovNV.Sprint6.Task4.V5.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task4.V5
{
    public partial class FormMain : Form
    {
        private double[] functionValues;
        private int[] xValues;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_NVA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startValue = -5;
                int stopValue = 5;

                // Получаем значения функции
                functionValues = ds.GetMassFunction(startValue, stopValue);
                xValues = new int[functionValues.Length];

                // Заполняем массив x
                for (int i = 0; i < functionValues.Length; i++)
                {
                    xValues[i] = startValue + i;
                }

                // Выводим в TextBox
                textBoxResult_NVA.Text = "Таблица значений функции:\r\n";
                textBoxResult_NVA.AppendText("F(x) = (2*sin(x))/(3*x+1.2) + cos(x) - 7*x*2\r\n");
                textBoxResult_NVA.AppendText("Диапазон: [-5; 5], шаг: 1\r\n\r\n");

                textBoxResult_NVA.AppendText("+----------+----------+\r\n");
                textBoxResult_NVA.AppendText("|    X     |   F(x)   |\r\n");
                textBoxResult_NVA.AppendText("+----------+----------+\r\n");

                for (int i = 0; i < functionValues.Length; i++)
                {
                    textBoxResult_NVA.AppendText($"|{xValues[i],5}     | {functionValues[i],7:F2}  |\r\n");
                }

                textBoxResult_NVA.AppendText("+----------+----------+\r\n");

                // Рисуем простой график в PictureBox
                DrawGraph();

                // Активируем кнопку сохранения
                buttonSave_NVA.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawGraph()
        {
            if (functionValues == null || functionValues.Length == 0) return;

            Bitmap bmp = new Bitmap(pictureBoxGraph_NVA.Width, pictureBoxGraph_NVA.Height);
            Graphics g = Graphics.FromImage(bmp);

            // Очищаем фон
            g.Clear(Color.White);

            // Настраиваем перо для осей
            Pen axisPen = new Pen(Color.Black, 2);

            // Рисуем оси
            int centerX = bmp.Width / 2;
            int centerY = bmp.Height / 2;

            g.DrawLine(axisPen, 0, centerY, bmp.Width, centerY); // Ось X
            g.DrawLine(axisPen, centerX, 0, centerX, bmp.Height); // Ось Y

            // Подписи осей
            Font labelFont = new Font("Arial", 8);
            g.DrawString("X", labelFont, Brushes.Black, bmp.Width - 15, centerY - 20);
            g.DrawString("Y", labelFont, Brushes.Black, centerX + 10, 5);

            // Находим минимальное и максимальное значение функции
            double minY = functionValues[0];
            double maxY = functionValues[0];
            for (int i = 1; i < functionValues.Length; i++)
            {
                if (functionValues[i] < minY) minY = functionValues[i];
                if (functionValues[i] > maxY) maxY = functionValues[i];
            }

            // Масштабируем график
            double scaleX = (bmp.Width - 40) / (xValues.Length - 1);
            double scaleY = (bmp.Height - 40) / (maxY - minY);

            // Рисуем график
            Pen graphPen = new Pen(Color.Blue, 2);
            PointF[] points = new PointF[functionValues.Length];

            for (int i = 0; i < functionValues.Length; i++)
            {
                float x = 20 + (float)(i * scaleX);
                float y = centerY - (float)((functionValues[i] - (minY + maxY) / 2) * scaleY);
                points[i] = new PointF(x, y);
            }

            // Соединяем точки
            for (int i = 0; i < points.Length - 1; i++)
            {
                g.DrawLine(graphPen, points[i], points[i + 1]);
            }

            // Рисуем точки
            foreach (PointF point in points)
            {
                g.FillEllipse(Brushes.Red, point.X - 3, point.Y - 3, 6, 6);
            }

            // Отображаем в PictureBox
            pictureBoxGraph_NVA.Image = bmp;

            // Освобождаем ресурсы
            axisPen.Dispose();
            graphPen.Dispose();
            labelFont.Dispose();
            g.Dispose();
        }

        private void buttonSave_NVA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                string path = ds.SaveToFileText(-5, 5);

                MessageBox.Show($"Файл сохранён по пути:\n{path}", "Успешно",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Открываем файл для просмотра
                System.Diagnostics.Process.Start("notepad.exe", path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИСТИБ-25-1 Анисимов Н.В.",
                          "Сообщение",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }
    }
}