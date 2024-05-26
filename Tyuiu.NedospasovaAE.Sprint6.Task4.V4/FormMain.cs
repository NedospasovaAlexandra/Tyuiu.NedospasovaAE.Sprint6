using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NedospasovaAE.Sprint6.Task4.V4.Lib;
using System.IO;

namespace Tyuiu.NedospasovaAE.Sprint6.Task4.V4
{
    public partial class FormMain_NAE : Form
    {
        public FormMain_NAE()
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
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_NAE.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_NAE.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_NAE.Text = "";

                chartFunction_NAE.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_NAE.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_NAE.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonSaveFile_NAE_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V4.txt";
                File.WriteAllText(path, textBoxResult_NAE.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }

            }
            catch
            {
                MessageBox.Show("Сбой сохранения файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonInfo_NAE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИИПб-23-2 Недоспасова Александра Эдуардовна", "Сообщение");
        }
    }
}
