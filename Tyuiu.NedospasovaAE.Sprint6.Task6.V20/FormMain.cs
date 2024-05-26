using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.NedospasovaAE.Sprint6.Task6.V20.Lib;

namespace Tyuiu.NedospasovaAE.Sprint6.Task6.V20
{
    public partial class FormMain_NAE : Form
    {
        public FormMain_NAE()
        {
            InitializeComponent();
        }

        private string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_NAE_Click(object sender, EventArgs e)
        {
            openFileDialogTask_NAE.ShowDialog();
            openFilePath = openFileDialogTask_NAE.FileName;
            textBoxInput_NAE.Text = File.ReadAllText(openFilePath);
            groupBoxInput_NAE.Text = groupBoxInput_NAE.Text + " " + openFileDialogTask_NAE.FileName;
            buttonDone_NAE.Enabled = true;
        }

        private void buttonDone_NAE_Click(object sender, EventArgs e)
        {
            textBoxOutput_NAE.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_NAE_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
