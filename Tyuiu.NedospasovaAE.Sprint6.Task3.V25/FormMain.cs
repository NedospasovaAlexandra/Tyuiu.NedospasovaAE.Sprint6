using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NedospasovaAE.Sprint6.Task3.V25.Lib;

namespace Tyuiu.NedospasovaAE.Sprint6.Task3.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrx = new int[5, 5] { { 14, 5, -9, 18, 21 },
                                           { -5, -12, -12, 4, 28 },
                                           { 27, -2, -14, 23, 27 },
                                           { -19, -15, 17, 15, 1 },
                                           { 33, 2, 6, 24, 24 } };
        private void FormMain_NAE_Load(object sender, EventArgs e)
        {
            int rows = matrx.GetUpperBound(0) + 1;
            int columns = matrx.Length / rows;

            dataGridViewMatrix_NAE.ColumnCount = columns;
            dataGridViewMatrix_NAE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_NAE.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_NAE.Rows[i].Cells[j].Value = Convert.ToString(matrx[i, j]);
                }
            }
        }
        private void buttonHelp_NAE_Click_(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИИПб-23-2 Недоспасова Александра Эдуардовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_NAE_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int[,] matrx = new int[5, 5] { { 14, 5, -9, 18, 21 },
                                           { -5, -12, -12, 4, 28 },
                                           { 27, -2, -14, 23, 27 },
                                           { -19, -15, 17, 15, 1 },
                                           { 33, 2, 6, 24, 24 } };
            int[,] mtrx = ds.Calculate(matrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_NAE.ColumnCount = columns;
            dataGridViewMatrix_NAE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_NAE.Columns[i].Width = 25;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_NAE.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }

}
