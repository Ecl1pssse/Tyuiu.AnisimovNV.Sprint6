using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.AnisimovNV.Sprint6.Task5.V25.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task5.V25
{
    public partial class FormMain : Form
    {
        private double[] dataArray;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonLoad_NVA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                string path = @"InPutFileTask5V25.txt";

                // Загружаем данные из файла
                dataArray = ds.LoadFromDataFile(path);

                // Выводим в DataGridView
                DisplayDataInGridView();

                // Строим диаграмму
                DrawDiagram();

                // Выводим статистику
                labelStatus_NVA.Text = $"Загружено {dataArray.Length} ненулевых значений";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки файла: {ex.Message}",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayDataInGridView()
        {
            dataGridViewValues_NVA.Rows.Clear();
            dataGridViewValues_NVA.Columns.Clear();

            // Создаем колонки
            dataGridViewValues_NVA.Columns.Add("Index", "№");
            dataGridViewValues_NVA.Columns.Add("Value", "Значение");

            dataGridViewValues_NVA.Columns[0].Width = 50;
            dataGridViewValues_NVA.Columns[1].Width = 100;
            dataGridViewValues_NVA.Columns[1].DefaultCellStyle.Format = "F3";

            // Заполняем данными
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataGridViewValues_NVA.Rows.Add(i + 1, dataArray[i]);
            }
        }

        private void DrawDiagram()
        {
            if (dataArray == null || dataArray.Length == 0)
                return;

            Bitmap bmp = new Bitmap(pictureBoxDiagram_NVA.Width, pictureBoxDiagram_NVA.Height);
            Graphics g = Graphics.FromImage(bmp);

            // Очищаем фон
            g.Clear(Color.White);

            // Находим минимальное и максимальное значение
            double maxValue = dataArray.Max();
            double minValue = dataArray.Min();

            // Параметры диаграммы
            int margin = 40;
            int diagramWidth = bmp.Width - 2 * margin;
            int diagramHeight = bmp.Height - 2 * margin;
            int columnWidth = diagramWidth / dataArray.Length;

            // Рисуем оси
            Pen axisPen = new Pen(Color.Black, 2);
            g.DrawLine(axisPen, margin, margin, margin, margin + diagramHeight); // Ось Y
            g.DrawLine(axisPen, margin, margin + diagramHeight, margin + diagramWidth, margin + diagramHeight); // Ось X

            // Подписи
            Font labelFont = new Font("Arial", 8);
            g.DrawString("Значения", labelFont, Brushes.Black, margin + diagramWidth / 2 - 30, margin + diagramHeight + 10);
            g.DrawString("Значение", labelFont, Brushes.Black, 5, margin);

            // Масштаб
            double scale = diagramHeight / (maxValue - minValue + 1);

            // Рисуем столбцы
            Random rand = new Random();
            for (int i = 0; i < dataArray.Length; i++)
            {
                int columnHeight = (int)((dataArray[i] - minValue) * scale);
                int x = margin + i * columnWidth;
                int y = margin + diagramHeight - columnHeight;

                // Случайный цвет для каждого столбца
                Color columnColor = Color.FromArgb(rand.Next(50, 200), rand.Next(50, 200), rand.Next(50, 200));
                Brush columnBrush = new SolidBrush(columnColor);

                // Рисуем столбец
                g.FillRectangle(columnBrush, x + 2, y, columnWidth - 4, columnHeight);
                g.DrawRectangle(Pens.Black, x + 2, y, columnWidth - 4, columnHeight);

                // Подпись значения
                string valueText = dataArray[i].ToString("F3");
                SizeF textSize = g.MeasureString(valueText, labelFont);
                g.DrawString(valueText, labelFont, Brushes.Black,
                           x + (columnWidth - textSize.Width) / 2, y - 15);

                // Номер столбца
                g.DrawString((i + 1).ToString(), labelFont, Brushes.Black,
                           x + columnWidth / 2 - 5, margin + diagramHeight + 2);

                columnBrush.Dispose();
            }

            // Отображаем в PictureBox
            pictureBoxDiagram_NVA.Image = bmp;

            // Освобождаем ресурсы
            axisPen.Dispose();
            labelFont.Dispose();
            g.Dispose();
        }

        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСТИБ-25-1 Анисимов Н.В.",
                          "Сообщение",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }
    }
}