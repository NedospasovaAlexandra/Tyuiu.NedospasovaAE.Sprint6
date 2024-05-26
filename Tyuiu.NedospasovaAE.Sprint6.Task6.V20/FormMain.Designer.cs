
using System;

namespace Tyuiu.NedospasovaAE.Sprint6.Task6.V20
{
    partial class FormMain_NAE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_NAE));
            this.panelUp_NAE = new System.Windows.Forms.Panel();
            this.textBoxTask_NAE = new System.Windows.Forms.TextBox();
            this.groupBoxTask_NAE = new System.Windows.Forms.GroupBox();
            this.buttonHelp_NAE = new System.Windows.Forms.Button();
            this.buttonOpenFile_NAE = new System.Windows.Forms.Button();
            this.buttonDone_NAE = new System.Windows.Forms.Button();
            this.panelLeft_NAE = new System.Windows.Forms.Panel();
            this.groupBoxInput_NAE = new System.Windows.Forms.GroupBox();
            this.textBoxInput_NAE = new System.Windows.Forms.TextBox();
            this.splitterNeed_NAE = new System.Windows.Forms.Splitter();
            this.panelRight_NAE = new System.Windows.Forms.Panel();
            this.groupBoxOutput_NAE = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_NAE = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_NAE = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_NAE = new System.Windows.Forms.ToolTip(this.components);
            this.panelUp_NAE.SuspendLayout();
            this.groupBoxTask_NAE.SuspendLayout();
            this.panelLeft_NAE.SuspendLayout();
            this.groupBoxInput_NAE.SuspendLayout();
            this.panelRight_NAE.SuspendLayout();
            this.groupBoxOutput_NAE.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp_NAE
            // 
            this.panelUp_NAE.Controls.Add(this.textBoxTask_NAE);
            this.panelUp_NAE.Controls.Add(this.groupBoxTask_NAE);
            this.panelUp_NAE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_NAE.Location = new System.Drawing.Point(0, 0);
            this.panelUp_NAE.Name = "panelUp_NAE";
            this.panelUp_NAE.Size = new System.Drawing.Size(1234, 130);
            this.panelUp_NAE.TabIndex = 0;
            // 
            // textBoxTask_NAE
            // 
            this.textBoxTask_NAE.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_NAE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_NAE.Location = new System.Drawing.Point(3, 90);
            this.textBoxTask_NAE.Multiline = true;
            this.textBoxTask_NAE.Name = "textBoxTask_NAE";
            this.textBoxTask_NAE.Size = new System.Drawing.Size(1228, 24);
            this.textBoxTask_NAE.TabIndex = 0;
            this.textBoxTask_NAE.Text = resources.GetString("textBoxTask_NAE.Text");
            // 
            // groupBoxTask_NAE
            // 
            this.groupBoxTask_NAE.Controls.Add(this.buttonHelp_NAE);
            this.groupBoxTask_NAE.Controls.Add(this.buttonOpenFile_NAE);
            this.groupBoxTask_NAE.Controls.Add(this.buttonDone_NAE);
            this.groupBoxTask_NAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_NAE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_NAE.Name = "groupBoxTask_NAE";
            this.groupBoxTask_NAE.Size = new System.Drawing.Size(1234, 130);
            this.groupBoxTask_NAE.TabIndex = 5;
            this.groupBoxTask_NAE.TabStop = false;
            this.groupBoxTask_NAE.Text = "Условие:";
            // 
            // buttonHelp_NAE
            // 
            this.buttonHelp_NAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_NAE.Location = new System.Drawing.Point(1129, 19);
            this.buttonHelp_NAE.Name = "buttonHelp_NAE";
            this.buttonHelp_NAE.Size = new System.Drawing.Size(93, 71);
            this.buttonHelp_NAE.TabIndex = 4;
            this.buttonHelp_NAE.Text = "Справка";
            this.toolTip_NAE.SetToolTip(this.buttonHelp_NAE, "Сведения о программе");
            this.buttonHelp_NAE.UseVisualStyleBackColor = true;
            this.buttonHelp_NAE.Click += new System.EventHandler(this.buttonHelp_NAE_Click);
            // 
            // buttonOpenFile_NAE
            // 
            this.buttonOpenFile_NAE.Location = new System.Drawing.Point(12, 19);
            this.buttonOpenFile_NAE.Name = "buttonOpenFile_NAE";
            this.buttonOpenFile_NAE.Size = new System.Drawing.Size(93, 71);
            this.buttonOpenFile_NAE.TabIndex = 2;
            this.buttonOpenFile_NAE.Text = "Открыть файл";
            this.toolTip_NAE.SetToolTip(this.buttonOpenFile_NAE, "Выберите нужный файл для обработки\r\n");
            this.buttonOpenFile_NAE.UseVisualStyleBackColor = true;
            this.buttonOpenFile_NAE.Click += new System.EventHandler(this.buttonOpenFile_NAE_Click);
            // 
            // buttonDone_NAE
            // 
            this.buttonDone_NAE.Location = new System.Drawing.Point(111, 19);
            this.buttonDone_NAE.Name = "buttonDone_NAE";
            this.buttonDone_NAE.Size = new System.Drawing.Size(93, 71);
            this.buttonDone_NAE.TabIndex = 1;
            this.buttonDone_NAE.Text = "Выполнить";
            this.toolTip_NAE.SetToolTip(this.buttonDone_NAE, "Выводит второе слово каждой строки и выводит их textBoxOut_NAE");
            this.buttonDone_NAE.UseVisualStyleBackColor = true;
            this.buttonDone_NAE.Click += new System.EventHandler(this.buttonDone_NAE_Click);
            // 
            // panelLeft_NAE
            // 
            this.panelLeft_NAE.Controls.Add(this.groupBoxInput_NAE);
            this.panelLeft_NAE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_NAE.Location = new System.Drawing.Point(0, 130);
            this.panelLeft_NAE.Name = "panelLeft_NAE";
            this.panelLeft_NAE.Size = new System.Drawing.Size(619, 481);
            this.panelLeft_NAE.TabIndex = 0;
            // 
            // groupBoxInput_NAE
            // 
            this.groupBoxInput_NAE.Controls.Add(this.textBoxInput_NAE);
            this.groupBoxInput_NAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_NAE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_NAE.Name = "groupBoxInput_NAE";
            this.groupBoxInput_NAE.Size = new System.Drawing.Size(619, 481);
            this.groupBoxInput_NAE.TabIndex = 0;
            this.groupBoxInput_NAE.TabStop = false;
            this.groupBoxInput_NAE.Text = "Ввод:";
            // 
            // textBoxInput_NAE
            // 
            this.textBoxInput_NAE.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInput_NAE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInput_NAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput_NAE.Location = new System.Drawing.Point(3, 16);
            this.textBoxInput_NAE.Multiline = true;
            this.textBoxInput_NAE.Name = "textBoxInput_NAE";
            this.textBoxInput_NAE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_NAE.Size = new System.Drawing.Size(613, 462);
            this.textBoxInput_NAE.TabIndex = 0;
            // 
            // splitterNeed_NAE
            // 
            this.splitterNeed_NAE.Location = new System.Drawing.Point(619, 130);
            this.splitterNeed_NAE.Name = "splitterNeed_NAE";
            this.splitterNeed_NAE.Size = new System.Drawing.Size(3, 481);
            this.splitterNeed_NAE.TabIndex = 1;
            this.splitterNeed_NAE.TabStop = false;
            // 
            // panelRight_NAE
            // 
            this.panelRight_NAE.Controls.Add(this.groupBoxOutput_NAE);
            this.panelRight_NAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_NAE.Location = new System.Drawing.Point(622, 130);
            this.panelRight_NAE.Name = "panelRight_NAE";
            this.panelRight_NAE.Size = new System.Drawing.Size(612, 481);
            this.panelRight_NAE.TabIndex = 2;
            // 
            // groupBoxOutput_NAE
            // 
            this.groupBoxOutput_NAE.Controls.Add(this.textBoxOutput_NAE);
            this.groupBoxOutput_NAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_NAE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_NAE.Name = "groupBoxOutput_NAE";
            this.groupBoxOutput_NAE.Size = new System.Drawing.Size(612, 481);
            this.groupBoxOutput_NAE.TabIndex = 0;
            this.groupBoxOutput_NAE.TabStop = false;
            this.groupBoxOutput_NAE.Text = "Вывод:";
            // 
            // textBoxOutput_NAE
            // 
            this.textBoxOutput_NAE.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOutput_NAE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutput_NAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput_NAE.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutput_NAE.Multiline = true;
            this.textBoxOutput_NAE.Name = "textBoxOutput_NAE";
            this.textBoxOutput_NAE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_NAE.Size = new System.Drawing.Size(606, 462);
            this.textBoxOutput_NAE.TabIndex = 1;
            // 
            // openFileDialogTask_NAE
            // 
            this.openFileDialogTask_NAE.FileName = "openFileDialog1";
            // 
            // toolTip_NAE
            // 
            this.toolTip_NAE.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_NAE.ToolTipTitle = "Подсказка";
            // 
            // FormMain_NAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 611);
            this.Controls.Add(this.panelRight_NAE);
            this.Controls.Add(this.splitterNeed_NAE);
            this.Controls.Add(this.panelLeft_NAE);
            this.Controls.Add(this.panelUp_NAE);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormMain_NAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 20 | Недоспасова.А.Э";
            this.panelUp_NAE.ResumeLayout(false);
            this.panelUp_NAE.PerformLayout();
            this.groupBoxTask_NAE.ResumeLayout(false);
            this.panelLeft_NAE.ResumeLayout(false);
            this.groupBoxInput_NAE.ResumeLayout(false);
            this.groupBoxInput_NAE.PerformLayout();
            this.panelRight_NAE.ResumeLayout(false);
            this.groupBoxOutput_NAE.ResumeLayout(false);
            this.groupBoxOutput_NAE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_NAE;
        private System.Windows.Forms.TextBox textBoxTask_NAE;
        private System.Windows.Forms.GroupBox groupBoxTask_NAE;
        private System.Windows.Forms.Button buttonHelp_NAE;
        private System.Windows.Forms.Button buttonOpenFile_NAE;
        private System.Windows.Forms.ToolTip toolTip_NAE;
        private System.Windows.Forms.Button buttonDone_NAE;
        private System.Windows.Forms.Panel panelLeft_NAE;
        private System.Windows.Forms.GroupBox groupBoxInput_NAE;
        private System.Windows.Forms.Splitter splitterNeed_NAE;
        private System.Windows.Forms.Panel panelRight_NAE;
        private System.Windows.Forms.GroupBox groupBoxOutput_NAE;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_NAE;
        private System.Windows.Forms.TextBox textBoxInput_NAE;
        private System.Windows.Forms.TextBox textBoxOutput_NAE;
    }
}

