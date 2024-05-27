
using System;

namespace Tyuiu.NedospasovaAE.Sprint6.Task7.V19
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
            this.panelTop_NAE = new System.Windows.Forms.Panel();
            this.buttonSaveFile_NAE = new System.Windows.Forms.Button();
            this.buttonInfo_NAE = new System.Windows.Forms.Button();
            this.buttonDone_NAE = new System.Windows.Forms.Button();
            this.buttonOpenFile_NAE = new System.Windows.Forms.Button();
            this.groupBoxTask_NAE = new System.Windows.Forms.GroupBox();
            this.labelTask_NAE = new System.Windows.Forms.Label();
            this.panelLeft_NAE = new System.Windows.Forms.Panel();
            this.groupBoxIn_NAE = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_NAE = new System.Windows.Forms.DataGridView();
            this.panelRight_NAE = new System.Windows.Forms.Panel();
            this.groupBoxOut_NAE = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_NAE = new System.Windows.Forms.DataGridView();
            this.splitterNeed_NAE = new System.Windows.Forms.Splitter();
            this.openFileDialog_NAE = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_NAE = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_NAE = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_NAE.SuspendLayout();
            this.groupBoxTask_NAE.SuspendLayout();
            this.panelLeft_NAE.SuspendLayout();
            this.groupBoxIn_NAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_NAE)).BeginInit();
            this.panelRight_NAE.SuspendLayout();
            this.groupBoxOut_NAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_NAE)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_NAE
            // 
            this.panelTop_NAE.Controls.Add(this.buttonSaveFile_NAE);
            this.panelTop_NAE.Controls.Add(this.buttonInfo_NAE);
            this.panelTop_NAE.Controls.Add(this.buttonDone_NAE);
            this.panelTop_NAE.Controls.Add(this.buttonOpenFile_NAE);
            this.panelTop_NAE.Controls.Add(this.groupBoxTask_NAE);
            this.panelTop_NAE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_NAE.Location = new System.Drawing.Point(0, 0);
            this.panelTop_NAE.Name = "panelTop_NAE";
            this.panelTop_NAE.Size = new System.Drawing.Size(1052, 211);
            this.panelTop_NAE.TabIndex = 0;
            // 
            // buttonSaveFile_NAE
            // 
            this.buttonSaveFile_NAE.Image = global::Tyuiu.NedospasovaAE.Sprint6.Task7.V19.Properties.Resources.page_save;
            this.buttonSaveFile_NAE.Location = new System.Drawing.Point(214, 12);
            this.buttonSaveFile_NAE.Name = "buttonSaveFile_NAE";
            this.buttonSaveFile_NAE.Size = new System.Drawing.Size(95, 85);
            this.buttonSaveFile_NAE.TabIndex = 4;
            this.toolTipButton_NAE.SetToolTip(this.buttonSaveFile_NAE, " Сохранить результат в файл OutPutFileTask7.csv через saveFileDialog\r\n");
            this.buttonSaveFile_NAE.UseVisualStyleBackColor = true;
            this.buttonSaveFile_NAE.Click += new System.EventHandler(this.buttonSaveFile_NAE_Click);
            this.buttonSaveFile_NAE.MouseEnter += new System.EventHandler(this.buttonSaveFile_NAE_MouseEnter);
            // 
            // buttonInfo_NAE
            // 
            this.buttonInfo_NAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_NAE.Image = global::Tyuiu.NedospasovaAE.Sprint6.Task7.V19.Properties.Resources.help;
            this.buttonInfo_NAE.Location = new System.Drawing.Point(945, 12);
            this.buttonInfo_NAE.Name = "buttonInfo_NAE";
            this.buttonInfo_NAE.Size = new System.Drawing.Size(95, 85);
            this.buttonInfo_NAE.TabIndex = 3;
            this.toolTipButton_NAE.SetToolTip(this.buttonInfo_NAE, "О пользователе");
            this.buttonInfo_NAE.UseVisualStyleBackColor = true;
            this.buttonInfo_NAE.Click += new System.EventHandler(this.buttonInfo_NAE_Click);
            this.buttonInfo_NAE.MouseEnter += new System.EventHandler(this.buttonInfo_NAE_MouseEnter);
            // 
            // buttonDone_NAE
            // 
            this.buttonDone_NAE.Image = global::Tyuiu.NedospasovaAE.Sprint6.Task7.V19.Properties.Resources.page_go;
            this.buttonDone_NAE.Location = new System.Drawing.Point(113, 12);
            this.buttonDone_NAE.Name = "buttonDone_NAE";
            this.buttonDone_NAE.Size = new System.Drawing.Size(95, 85);
            this.buttonDone_NAE.TabIndex = 2;
            this.toolTipButton_NAE.SetToolTip(this.buttonDone_NAE, "Изменить во второй строке числа кратные 2 на 2. Результат вывести в объект dataGr" +
        "idViewOut\r\n");
            this.buttonDone_NAE.UseVisualStyleBackColor = true;
            this.buttonDone_NAE.Click += new System.EventHandler(this.buttonDone_NAE_Click);
            this.buttonDone_NAE.MouseEnter += new System.EventHandler(this.buttonDone_NAE_MouseEnter);
            // 
            // buttonOpenFile_NAE
            // 
            this.buttonOpenFile_NAE.Image = global::Tyuiu.NedospasovaAE.Sprint6.Task7.V19.Properties.Resources.folder_page;
            this.buttonOpenFile_NAE.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_NAE.Name = "buttonOpenFile_NAE";
            this.buttonOpenFile_NAE.Size = new System.Drawing.Size(95, 85);
            this.buttonOpenFile_NAE.TabIndex = 1;
            this.toolTipButton_NAE.SetToolTip(this.buttonOpenFile_NAE, "Открыть файл\r\nВыберите нужный файл для обработки\r\n\r\n");
            this.buttonOpenFile_NAE.UseVisualStyleBackColor = true;
            this.buttonOpenFile_NAE.Click += new System.EventHandler(this.buttonOpenFile_NAE_Click);
            this.buttonOpenFile_NAE.MouseEnter += new System.EventHandler(this.buttonOpenFile_NAE_MouseEnter);
            // 
            // groupBoxTask_NAE
            // 
            this.groupBoxTask_NAE.Controls.Add(this.labelTask_NAE);
            this.groupBoxTask_NAE.Location = new System.Drawing.Point(0, 103);
            this.groupBoxTask_NAE.Name = "groupBoxTask_NAE";
            this.groupBoxTask_NAE.Size = new System.Drawing.Size(1052, 108);
            this.groupBoxTask_NAE.TabIndex = 0;
            this.groupBoxTask_NAE.TabStop = false;
            this.groupBoxTask_NAE.Text = "Условие";
            // 
            // labelTask_NAE
            // 
            this.labelTask_NAE.AutoSize = true;
            this.labelTask_NAE.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask_NAE.Location = new System.Drawing.Point(3, 26);
            this.labelTask_NAE.Name = "labelTask_NAE";
            this.labelTask_NAE.Size = new System.Drawing.Size(1044, 57);
            this.labelTask_NAE.TabIndex = 0;
            this.labelTask_NAE.Text = resources.GetString("labelTask_NAE.Text");
            // 
            // panelLeft_NAE
            // 
            this.panelLeft_NAE.Controls.Add(this.groupBoxIn_NAE);
            this.panelLeft_NAE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_NAE.Location = new System.Drawing.Point(0, 211);
            this.panelLeft_NAE.Name = "panelLeft_NAE";
            this.panelLeft_NAE.Size = new System.Drawing.Size(533, 416);
            this.panelLeft_NAE.TabIndex = 0;
            // 
            // groupBoxIn_NAE
            // 
            this.groupBoxIn_NAE.Controls.Add(this.dataGridViewIn_NAE);
            this.groupBoxIn_NAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn_NAE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn_NAE.Name = "groupBoxIn_NAE";
            this.groupBoxIn_NAE.Size = new System.Drawing.Size(533, 416);
            this.groupBoxIn_NAE.TabIndex = 0;
            this.groupBoxIn_NAE.TabStop = false;
            this.groupBoxIn_NAE.Text = "Ввод данных";
            // 
            // dataGridViewIn_NAE
            // 
            this.dataGridViewIn_NAE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_NAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_NAE.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewIn_NAE.Name = "dataGridViewIn_NAE";
            this.dataGridViewIn_NAE.Size = new System.Drawing.Size(527, 397);
            this.dataGridViewIn_NAE.TabIndex = 0;
            // 
            // panelRight_NAE
            // 
            this.panelRight_NAE.Controls.Add(this.groupBoxOut_NAE);
            this.panelRight_NAE.Controls.Add(this.splitterNeed_NAE);
            this.panelRight_NAE.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_NAE.Location = new System.Drawing.Point(530, 211);
            this.panelRight_NAE.Name = "panelRight_NAE";
            this.panelRight_NAE.Size = new System.Drawing.Size(522, 416);
            this.panelRight_NAE.TabIndex = 0;
            // 
            // groupBoxOut_NAE
            // 
            this.groupBoxOut_NAE.Controls.Add(this.dataGridViewOut_NAE);
            this.groupBoxOut_NAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_NAE.Location = new System.Drawing.Point(3, 0);
            this.groupBoxOut_NAE.Name = "groupBoxOut_NAE";
            this.groupBoxOut_NAE.Size = new System.Drawing.Size(519, 416);
            this.groupBoxOut_NAE.TabIndex = 1;
            this.groupBoxOut_NAE.TabStop = false;
            this.groupBoxOut_NAE.Text = "Вывод данных";
            // 
            // dataGridViewOut_NAE
            // 
            this.dataGridViewOut_NAE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_NAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_NAE.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOut_NAE.Name = "dataGridViewOut_NAE";
            this.dataGridViewOut_NAE.Size = new System.Drawing.Size(513, 397);
            this.dataGridViewOut_NAE.TabIndex = 0;
            // 
            // splitterNeed_NAE
            // 
            this.splitterNeed_NAE.Location = new System.Drawing.Point(0, 0);
            this.splitterNeed_NAE.Name = "splitterNeed_NAE";
            this.splitterNeed_NAE.Size = new System.Drawing.Size(3, 416);
            this.splitterNeed_NAE.TabIndex = 0;
            this.splitterNeed_NAE.TabStop = false;
            // 
            // openFileDialog_NAE
            // 
            this.openFileDialog_NAE.FileName = "openFileDialog1";
            // 
            // toolTipButton_NAE
            // 
            this.toolTipButton_NAE.IsBalloon = true;
            this.toolTipButton_NAE.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_NAE.ToolTipTitle = "Подсказка";
            // 
            // FormMain_NAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 627);
            this.Controls.Add(this.panelRight_NAE);
            this.Controls.Add(this.panelLeft_NAE);
            this.Controls.Add(this.panelTop_NAE);
            this.MinimumSize = new System.Drawing.Size(1068, 666);
            this.Name = "FormMain_NAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 19 | Недоспасова.А.Э";
            this.panelTop_NAE.ResumeLayout(false);
            this.groupBoxTask_NAE.ResumeLayout(false);
            this.groupBoxTask_NAE.PerformLayout();
            this.panelLeft_NAE.ResumeLayout(false);
            this.groupBoxIn_NAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_NAE)).EndInit();
            this.panelRight_NAE.ResumeLayout(false);
            this.groupBoxOut_NAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_NAE)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel panelTop_NAE;
        private System.Windows.Forms.Panel panelLeft_NAE;
        private System.Windows.Forms.Button buttonSaveFile_NAE;
        private System.Windows.Forms.Button buttonInfo_NAE;
        private System.Windows.Forms.Button buttonDone_NAE;
        private System.Windows.Forms.Button buttonOpenFile_NAE;
        private System.Windows.Forms.GroupBox groupBoxTask_NAE;
        private System.Windows.Forms.Label labelTask_NAE;
        private System.Windows.Forms.GroupBox groupBoxIn_NAE;
        private System.Windows.Forms.DataGridView dataGridViewIn_NAE;
        private System.Windows.Forms.Panel panelRight_NAE;
        private System.Windows.Forms.GroupBox groupBoxOut_NAE;
        private System.Windows.Forms.DataGridView dataGridViewOut_NAE;
        private System.Windows.Forms.Splitter splitterNeed_NAE;
        private System.Windows.Forms.ToolTip toolTipButton_NAE;
        private System.Windows.Forms.OpenFileDialog openFileDialog_NAE;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_NAE;
    }
}

