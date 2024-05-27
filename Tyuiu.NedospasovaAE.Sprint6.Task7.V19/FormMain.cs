using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NedospasovaAE.Sprint6.Task7.V19.Lib;
using System.IO;

namespace Tyuiu.NedospasovaAE.Sprint6.Task7.V19
{
    public partial class FormMain_NAE : Form
    {
        public FormMain_NAE()
        {
            InitializeComponent();
            openFileDialog_NAE.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_NAE.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;

        static string openFilePath;
        DataService ds = new DataService();

        public int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_NAE_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_NAE.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_NAE_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_NAE.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_NAE_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_NAE.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonInfo_NAE_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_NAE.ToolTipTitle = "Справка";
        }

        private void buttonOpenFile_NAE_Click(object sender, EventArgs e)
        {
            openFileDialog_NAE.ShowDialog();
            openFilePath = openFileDialog_NAE.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewIn_NAE.ColumnCount = columns;
            dataGridViewIn_NAE.RowCount = rows;
            dataGridViewOut_NAE.ColumnCount = columns;
            dataGridViewOut_NAE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_NAE.Columns[i].Width = 25;
                dataGridViewOut_NAE.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_NAE.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_NAE.Enabled = true;
        }
        private void buttonDone_NAE_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_NAE.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_NAE.Enabled = true;
        }

        private void buttonSaveFile_NAE_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_NAE.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_NAE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_NAE.ShowDialog();

            string path = saveFileDialogMatrix_NAE.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_NAE.RowCount;
            int columns = dataGridViewOut_NAE.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_NAE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_NAE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonInfo_NAE_Click(object sender, EventArgs e)
        {
            FormAbout_NAE formAbout = new FormAbout_NAE();
            formAbout.ShowDialog();
        }
        private void FormMain_NAE_Load(object sender, EventArgs e)
        {
            dataGridViewIn_NAE.ColumnCount = 50;
            dataGridViewOut_NAE.ColumnCount = 50;

            dataGridViewIn_NAE.RowCount = 50;
            dataGridViewOut_NAE.RowCount = 50;

            panelLeft_NAE.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_NAE.Columns[i].Width = 25;
                dataGridViewOut_NAE.Columns[i].Width = 25;
            }
        }

    }
}
