using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NedospasovaAE.Sprint6.Task1.V13.Lib;

namespace Tyuiu.NedospasovaAE.Sprint6.Task1.V13
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
                int startStep = Convert.ToInt32(textBoxStartStep_NAE.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_NAE.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = new double[len];
                textBoxResult_NAE.Text = "";
                textBoxResult_NAE.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxResult_NAE.AppendText("|    x     |     f(x)   |" + Environment.NewLine);
                textBoxResult_NAE.AppendText("+----------+------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1,7:f2}    |", startStep, valueArray[i]);
                    textBoxResult_NAE.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_NAE.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_NAE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИИПб-23-2 Недоспасова Александра Эдуардовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
