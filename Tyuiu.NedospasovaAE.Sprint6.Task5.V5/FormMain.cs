using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NedospasovaAE.Sprint6.Task5.V5.Lib;
using System.IO;

namespace Tyuiu.NedospasovaAE.Sprint6.Task5.V5
{
    public partial class FormMain_NAE : Form
    {
        public FormMain_NAE()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V5.txt";
        private void buttonDone_NAE_Click(object sender, EventArgs e)
        {
            dataGridViewResult_NAE.ColumnCount = 2;
            dataGridViewResult_NAE.Columns[0].Width = 20;
            dataGridViewResult_NAE.Columns[1].Width = 50;

            this.chartResult_NAE.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_NAE.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_NAE.Series[0].Points.Clear();

            double[] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult_NAE.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartResult_NAE.Series[0].Points.AddXY(i, numMass[i]);
            }


        }

        private void buttonInfo_NAE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПБ-23-2 Недоспасова Александра Эдуардовна", "Сообщение");
        }

        private void buttonOpenFile_NAE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
