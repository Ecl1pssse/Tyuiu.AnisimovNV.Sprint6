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

        DataService ds = new DataService();
        string openFilePath;
        int[,] matrix;

        private void buttonOpen_NVA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_NVA.ShowDialog();
            openFilePath = openFileDialogTask_NVA.FileName;

            if (File.Exists(openFilePath))
            {
                matrix = ds.GetMatrix(openFilePath);

                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);

                dataGridViewIn_NVA.ColumnCount = columns;
                dataGridViewIn_NVA.RowCount = rows;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewIn_NVA.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }

                int[,] resultMatrix = ds.GetMatrix(matrix);

                dataGridViewOut_NVA.ColumnCount = columns;
                dataGridViewOut_NVA.RowCount = rows;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewOut_NVA.Rows[i].Cells[j].Value = resultMatrix[i, j];
                    }
                }

                if (columns > 8)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        dataGridViewOut_NVA.Rows[i].Cells[8].Style.BackColor = System.Drawing.Color.Yellow;
                    }
                }

                buttonSave_NVA.Enabled = true;
            }
        }

        private void buttonSave_NVA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_NVA.FileName = "OutPutFileTask7V12.csv";
            saveFileDialogMatrix_NVA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_NVA.ShowDialog();

            if (saveFileDialogMatrix_NVA.FileName != "")
            {
                string savePath = saveFileDialogMatrix_NVA.FileName;

                int rows = dataGridViewOut_NVA.RowCount;
                int columns = dataGridViewOut_NVA.ColumnCount;

                using (StreamWriter writer = new StreamWriter(savePath))
                {
                    for (int i = 0; i < rows; i++)
                    {
                        string line = "";
                        for (int j = 0; j < columns; j++)
                        {
                            line += dataGridViewOut_NVA.Rows[i].Cells[j].Value;
                            if (j != columns - 1)
                            {
                                line += ";";
                            }
                        }
                        writer.WriteLine(line);
                    }
                }

                MessageBox.Show("Файл сохранен", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 7 выполнил студент группы ИСТИБ-25-1 Анисимов Н.В.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}