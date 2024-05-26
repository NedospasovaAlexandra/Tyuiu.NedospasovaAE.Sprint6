
using System;
using System.Windows.Forms;

namespace Tyuiu.NedospasovaAE.Sprint6.Task3.V25
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
            this.groupBoxTask_NAE = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_NAE = new System.Windows.Forms.DataGridView();
            this.textBoxTask_NAE = new System.Windows.Forms.TextBox();
            this.buttonDone_NAE = new System.Windows.Forms.Button();
            this.buttonHelp_NAE = new System.Windows.Forms.Button();
            this.groupBoxFinish_NAE = new System.Windows.Forms.GroupBox();
            this.textBoxAnswer_NAE = new System.Windows.Forms.TextBox();
            this.textBoxResult_NAE = new System.Windows.Forms.TextBox();
            this.groupBoxTask_NAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_NAE)).BeginInit();
            this.groupBoxFinish_NAE.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_NAE
            // 
            this.groupBoxTask_NAE.Controls.Add(this.dataGridViewMatrix_NAE);
            this.groupBoxTask_NAE.Controls.Add(this.textBoxTask_NAE);
            this.groupBoxTask_NAE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_NAE.Name = "groupBoxTask_NAE";
            this.groupBoxTask_NAE.Size = new System.Drawing.Size(618, 380);
            this.groupBoxTask_NAE.TabIndex = 0;
            this.groupBoxTask_NAE.TabStop = false;
            this.groupBoxTask_NAE.Text = "Условие";
            // 
            // dataGridViewMatrix_NAE
            // 
            this.dataGridViewMatrix_NAE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_NAE.Location = new System.Drawing.Point(333, 19);
            this.dataGridViewMatrix_NAE.Name = "dataGridViewMatrix_NAE";
            this.dataGridViewMatrix_NAE.Size = new System.Drawing.Size(279, 204);
            this.dataGridViewMatrix_NAE.TabIndex = 1;
            // 
            // textBoxTask_NAE
            // 
            this.textBoxTask_NAE.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_NAE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_NAE.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_NAE.Multiline = true;
            this.textBoxTask_NAE.Name = "textBoxTask_NAE";
            this.textBoxTask_NAE.ReadOnly = true;
            this.textBoxTask_NAE.Size = new System.Drawing.Size(468, 220);
            this.textBoxTask_NAE.TabIndex = 0;
            this.textBoxTask_NAE.Text = "Дан массив 5 на 5 элементов\r\n14   5  -9  18  21\r\n-5 -12 -12   4  28\r\n27  -2 -14  " +
    "23  27\r\n-19 -15  17  15   1\r\n33   2   6  24  24\r\nВыполнить сортировку по возраст" +
    "анию в третьем столбце";
            // 
            // buttonDone_NAE
            // 
            this.buttonDone_NAE.Location = new System.Drawing.Point(686, 398);
            this.buttonDone_NAE.Name = "buttonDone_NAE";
            this.buttonDone_NAE.Size = new System.Drawing.Size(102, 40);
            this.buttonDone_NAE.TabIndex = 2;
            this.buttonDone_NAE.Text = "Выполнить";
            this.buttonDone_NAE.UseVisualStyleBackColor = true;
            this.buttonDone_NAE.Click += new System.EventHandler(this.buttonDone_NAE_Click);
            // 
            // buttonHelp_NAE
            // 
            this.buttonHelp_NAE.Location = new System.Drawing.Point(601, 398);
            this.buttonHelp_NAE.Name = "buttonHelp_NAE";
            this.buttonHelp_NAE.Size = new System.Drawing.Size(79, 40);
            this.buttonHelp_NAE.TabIndex = 3;
            this.buttonHelp_NAE.Text = "?";
            this.buttonHelp_NAE.UseVisualStyleBackColor = true;
            this.buttonHelp_NAE.Click += new System.EventHandler(this.buttonHelp_NAE_Click);
            // 
            // groupBoxFinish_NAE
            // 
            this.groupBoxFinish_NAE.Controls.Add(this.textBoxAnswer_NAE);
            this.groupBoxFinish_NAE.Controls.Add(this.textBoxResult_NAE);
            this.groupBoxFinish_NAE.Location = new System.Drawing.Point(636, 12);
            this.groupBoxFinish_NAE.Name = "groupBoxFinish_NAE";
            this.groupBoxFinish_NAE.Size = new System.Drawing.Size(152, 86);
            this.groupBoxFinish_NAE.TabIndex = 4;
            this.groupBoxFinish_NAE.TabStop = false;
            this.groupBoxFinish_NAE.Text = "Вывод данных";
            // 
            // textBoxAnswer_NAE
            // 
            this.textBoxAnswer_NAE.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAnswer_NAE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAnswer_NAE.Location = new System.Drawing.Point(6, 28);
            this.textBoxAnswer_NAE.Multiline = true;
            this.textBoxAnswer_NAE.Name = "textBoxAnswer_NAE";
            this.textBoxAnswer_NAE.ReadOnly = true;
            this.textBoxAnswer_NAE.Size = new System.Drawing.Size(140, 20);
            this.textBoxAnswer_NAE.TabIndex = 1;
            this.textBoxAnswer_NAE.Text = "Результат:";
            // 
            // textBoxResult_NAE
            // 
            this.textBoxResult_NAE.Location = new System.Drawing.Point(6, 54);
            this.textBoxResult_NAE.Name = "textBoxResult_NAE";
            this.textBoxResult_NAE.ReadOnly = true;
            this.textBoxResult_NAE.Size = new System.Drawing.Size(140, 20);
            this.textBoxResult_NAE.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxFinish_NAE);
            this.Controls.Add(this.buttonHelp_NAE);
            this.Controls.Add(this.buttonDone_NAE);
            this.Controls.Add(this.groupBoxTask_NAE);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 25 | Недоспасова.А.Э";
            this.Load += new System.EventHandler(this.FormMain_NAE_Load);
            this.groupBoxTask_NAE.ResumeLayout(false);
            this.groupBoxTask_NAE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_NAE)).EndInit();
            this.groupBoxFinish_NAE.ResumeLayout(false);
            this.groupBoxFinish_NAE.PerformLayout();
            this.ResumeLayout(false);

        }

        private void buttonHelp_NAE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИИПб-23-2 Недоспасова Александра Эдуардовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_NAE;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_NAE;
        private System.Windows.Forms.TextBox textBoxTask_NAE;
        private System.Windows.Forms.Button buttonDone_NAE;
        private System.Windows.Forms.Button buttonHelp_NAE;
        private System.Windows.Forms.GroupBox groupBoxFinish_NAE;
        private System.Windows.Forms.TextBox textBoxAnswer_NAE;
        private System.Windows.Forms.TextBox textBoxResult_NAE;
    }
}

