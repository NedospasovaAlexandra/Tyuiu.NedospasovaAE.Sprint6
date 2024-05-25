using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NedospasovaAE.Sprint6.Task2.V4.Lib;

namespace Tyuiu.NedospasovaAE.Sprint6.Task2.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_NAE_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInput_NAE.Text);
                int stopStep = Convert.ToInt32(textBoxOutput_NAE.Text);


                int len = ds.GetMassFunction(startStep, stopStep).Length;


                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartResult_NAE.Titles.Add("График функции");

                this.chartResult_NAE.ChartAreas[0].AxisX.Title = "Ось X";

                this.chartResult_NAE.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_NAE.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartResult_NAE.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonHelp_NAE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИИПБ-23-2 Недоспасова Александра Эдуардовна", "Сообщение");
        }
        private void buttonDone_DDA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_NAE.BackColor = Color.Red;
        }


        private void buttonDone_DDA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_NAE.BackColor = Color.Blue;
        }

        private void buttonDone_DDA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_NAE.BackColor = Color.Green;
        }

    }

}
