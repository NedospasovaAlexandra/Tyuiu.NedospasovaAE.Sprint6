
using System;
using System.Windows.Forms;

namespace Tyuiu.NedospasovaAE.Sprint6.Task2.V4
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBoxTask_NAE = new System.Windows.Forms.PictureBox();
            this.dataGridViewResult_NAE = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartResult_NAE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_NAE = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxData_NAE = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_NAE = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_NAE = new System.Windows.Forms.TextBox();
            this.groupBoxInput_NAE = new System.Windows.Forms.GroupBox();
            this.textBoxInput_NAE = new System.Windows.Forms.TextBox();
            this.groupBoxDone_NAE = new System.Windows.Forms.GroupBox();
            this.buttonHelp_NAE = new System.Windows.Forms.Button();
            this.buttonDone_NAE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_NAE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_NAE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_NAE)).BeginInit();
            this.groupBoxTask_NAE.SuspendLayout();
            this.groupBoxData_NAE.SuspendLayout();
            this.groupBoxOutput_NAE.SuspendLayout();
            this.groupBoxInput_NAE.SuspendLayout();
            this.groupBoxDone_NAE.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTask_NAE
            // 
            this.pictureBoxTask_NAE.Image = global::Tyuiu.NedospasovaAE.Sprint6.Task2.V4.Properties.Resources.Без_названия;
            this.pictureBoxTask_NAE.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxTask_NAE.Name = "pictureBoxTask_NAE";
            this.pictureBoxTask_NAE.Size = new System.Drawing.Size(635, 210);
            this.pictureBoxTask_NAE.TabIndex = 0;
            this.pictureBoxTask_NAE.TabStop = false;
            // 
            // dataGridViewResult_NAE
            // 
            this.dataGridViewResult_NAE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_NAE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnFX});
            this.dataGridViewResult_NAE.Location = new System.Drawing.Point(0, 19);
            this.dataGridViewResult_NAE.Name = "dataGridViewResult_NAE";
            this.dataGridViewResult_NAE.RowHeadersVisible = false;
            this.dataGridViewResult_NAE.Size = new System.Drawing.Size(104, 303);
            this.dataGridViewResult_NAE.TabIndex = 1;
            this.dataGridViewResult_NAE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridResult_NAE_CellContentClick);
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            this.ColumnX.Width = 50;
            // 
            // ColumnFX
            // 
            this.ColumnFX.HeaderText = "F(X)";
            this.ColumnFX.Name = "ColumnFX";
            this.ColumnFX.ReadOnly = true;
            this.ColumnFX.Width = 50;
            // 
            // chartResult_NAE
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_NAE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResult_NAE.Legends.Add(legend1);
            this.chartResult_NAE.Location = new System.Drawing.Point(124, 19);
            this.chartResult_NAE.Name = "chartResult_NAE";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_NAE.Series.Add(series1);
            this.chartResult_NAE.Size = new System.Drawing.Size(337, 303);
            this.chartResult_NAE.TabIndex = 2;
            this.chartResult_NAE.Text = "chart1";
            // 
            // groupBoxTask_NAE
            // 
            this.groupBoxTask_NAE.Controls.Add(this.groupBox2);
            this.groupBoxTask_NAE.Controls.Add(this.pictureBoxTask_NAE);
            this.groupBoxTask_NAE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_NAE.Name = "groupBoxTask_NAE";
            this.groupBoxTask_NAE.Size = new System.Drawing.Size(647, 242);
            this.groupBoxTask_NAE.TabIndex = 3;
            this.groupBoxTask_NAE.TabStop = false;
            this.groupBoxTask_NAE.Text = "Условие";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBoxData_NAE
            // 
            this.groupBoxData_NAE.Controls.Add(this.groupBoxOutput_NAE);
            this.groupBoxData_NAE.Controls.Add(this.groupBoxInput_NAE);
            this.groupBoxData_NAE.Location = new System.Drawing.Point(12, 260);
            this.groupBoxData_NAE.Name = "groupBoxData_NAE";
            this.groupBoxData_NAE.Size = new System.Drawing.Size(381, 90);
            this.groupBoxData_NAE.TabIndex = 4;
            this.groupBoxData_NAE.TabStop = false;
            this.groupBoxData_NAE.Text = "Ввод данных";
            // 
            // groupBoxOutput_NAE
            // 
            this.groupBoxOutput_NAE.Controls.Add(this.textBoxOutput_NAE);
            this.groupBoxOutput_NAE.Location = new System.Drawing.Point(212, 19);
            this.groupBoxOutput_NAE.Name = "groupBoxOutput_NAE";
            this.groupBoxOutput_NAE.Size = new System.Drawing.Size(162, 55);
            this.groupBoxOutput_NAE.TabIndex = 0;
            this.groupBoxOutput_NAE.TabStop = false;
            this.groupBoxOutput_NAE.Text = "Конец шага:";
            // 
            // textBoxOutput_NAE
            // 
            this.textBoxOutput_NAE.Location = new System.Drawing.Point(32, 29);
            this.textBoxOutput_NAE.Name = "textBoxOutput_NAE";
            this.textBoxOutput_NAE.Size = new System.Drawing.Size(100, 20);
            this.textBoxOutput_NAE.TabIndex = 1;
            // 
            // groupBoxInput_NAE
            // 
            this.groupBoxInput_NAE.Controls.Add(this.textBoxInput_NAE);
            this.groupBoxInput_NAE.Location = new System.Drawing.Point(6, 19);
            this.groupBoxInput_NAE.Name = "groupBoxInput_NAE";
            this.groupBoxInput_NAE.Size = new System.Drawing.Size(162, 55);
            this.groupBoxInput_NAE.TabIndex = 0;
            this.groupBoxInput_NAE.TabStop = false;
            this.groupBoxInput_NAE.Text = "Старт шага:";
            // 
            // textBoxInput_NAE
            // 
            this.textBoxInput_NAE.Location = new System.Drawing.Point(33, 29);
            this.textBoxInput_NAE.Name = "textBoxInput_NAE";
            this.textBoxInput_NAE.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput_NAE.TabIndex = 0;
            // 
            // groupBoxDone_NAE
            // 
            this.groupBoxDone_NAE.Controls.Add(this.dataGridViewResult_NAE);
            this.groupBoxDone_NAE.Controls.Add(this.chartResult_NAE);
            this.groupBoxDone_NAE.Location = new System.Drawing.Point(665, 12);
            this.groupBoxDone_NAE.Name = "groupBoxDone_NAE";
            this.groupBoxDone_NAE.Size = new System.Drawing.Size(467, 338);
            this.groupBoxDone_NAE.TabIndex = 5;
            this.groupBoxDone_NAE.TabStop = false;
            this.groupBoxDone_NAE.Text = "Вывод данных";
            // 
            // buttonHelp_NAE
            // 
            this.buttonHelp_NAE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_NAE.Location = new System.Drawing.Point(399, 288);
            this.buttonHelp_NAE.Name = "buttonHelp_NAE";
            this.buttonHelp_NAE.Size = new System.Drawing.Size(110, 64);
            this.buttonHelp_NAE.TabIndex = 6;
            this.buttonHelp_NAE.Text = "Справка";
            this.buttonHelp_NAE.UseVisualStyleBackColor = false;
            this.buttonHelp_NAE.Click += new System.EventHandler(this.buttonHelp_NAE_Click);
            // 
            // buttonDone_NAE
            // 
            this.buttonDone_NAE.BackColor = System.Drawing.Color.Green;
            this.buttonDone_NAE.Location = new System.Drawing.Point(515, 288);
            this.buttonDone_NAE.Name = "buttonDone_NAE";
            this.buttonDone_NAE.Size = new System.Drawing.Size(138, 64);
            this.buttonDone_NAE.TabIndex = 7;
            this.buttonDone_NAE.Text = "Выполнить";
            this.buttonDone_NAE.UseVisualStyleBackColor = false;
            this.buttonDone_NAE.Click += new System.EventHandler(this.buttonDone_NAE_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 362);
            this.Controls.Add(this.buttonDone_NAE);
            this.Controls.Add(this.buttonHelp_NAE);
            this.Controls.Add(this.groupBoxData_NAE);
            this.Controls.Add(this.groupBoxTask_NAE);
            this.Controls.Add(this.groupBoxDone_NAE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 4 | Недоспасова.А.Э";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_NAE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_NAE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_NAE)).EndInit();
            this.groupBoxTask_NAE.ResumeLayout(false);
            this.groupBoxData_NAE.ResumeLayout(false);
            this.groupBoxOutput_NAE.ResumeLayout(false);
            this.groupBoxOutput_NAE.PerformLayout();
            this.groupBoxInput_NAE.ResumeLayout(false);
            this.groupBoxInput_NAE.PerformLayout();
            this.groupBoxDone_NAE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void dataGridResult_NAE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTask_NAE;
        private System.Windows.Forms.DataGridView dataGridViewResult_NAE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_NAE;
        private System.Windows.Forms.GroupBox groupBoxTask_NAE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFX;
        private System.Windows.Forms.GroupBox groupBoxData_NAE;
        private System.Windows.Forms.GroupBox groupBoxOutput_NAE;
        private System.Windows.Forms.TextBox textBoxOutput_NAE;
        private System.Windows.Forms.GroupBox groupBoxInput_NAE;
        private System.Windows.Forms.TextBox textBoxInput_NAE;
        private System.Windows.Forms.GroupBox groupBoxDone_NAE;
        private System.Windows.Forms.Button buttonHelp_NAE;
        private System.Windows.Forms.Button buttonDone_NAE;
    }
}

