using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NedospasovaAE.Sprint6.TaskReview.V10.Lib;

namespace Tyuiu.NedospasovaAE.Sprint6.TaskReview.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_NAE_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            int m = Convert.ToInt32(textBoxM_NAE.Text);
            int n = Convert.ToInt32(textBoxN_NAE.Text);
            int n1 = Convert.ToInt32(textBoxN1_NAE.Text);
            int n2 = Convert.ToInt32(textBoxN2_NAE.Text);
            int k = Convert.ToInt32(textBoxK_NAE.Text);
            int l = Convert.ToInt32(textBoxL_NAE.Text);
            int c = Convert.ToInt32(textBoxC_NAE.Text);


            int[,] array = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j % 2 == 0)
                        array[i, j] = rnd.Next(n1, n2 + 1);
                    else
                        array[i, j] = Convert.ToInt32(Math.Pow(array[i, j - 1], 3));
                }
            }

            dataGridViewMatrix_NAE.ColumnCount = m;
            dataGridViewMatrix_NAE.RowCount = n;

            for (int i = 0; i < m; i++)
            {
                dataGridViewMatrix_NAE.Columns[i].Width = 50;
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridViewMatrix_NAE.Rows[i].Cells[j].Value = array[i, j];
                }
            }

            textBoxResult_NAE.Text = Convert.ToString(ds.GetMatrix(array, c, k, l));

            if ((n1 > n2) || (k > l))
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_NAE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ТаскРевью выполнила студентка группы ИИПб-23-2 Недоспасова Александра Эдуардовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
