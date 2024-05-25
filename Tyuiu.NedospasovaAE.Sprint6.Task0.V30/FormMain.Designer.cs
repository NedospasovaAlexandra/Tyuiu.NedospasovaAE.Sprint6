
namespace Tyuiu.NedospasovaAE.Sprint6.Task0.V30
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
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBoxVarX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Controls.Add(this.pictureBoxFormula);
            this.groupBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(776, 262);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            this.textBoxTask.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(491, 56);
            this.textBoxTask.TabIndex = 1;
            this.textBoxTask.TabStop = false;
            this.textBoxTask.Text = "Вычислить значение выражения по формуле:";
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxFormula.Image = global::Tyuiu.NedospasovaAE.Sprint6.Task0.V30.Properties.Resources.Без_имени;
            this.pictureBoxFormula.Location = new System.Drawing.Point(531, 19);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(239, 101);
            this.pictureBoxFormula.TabIndex = 0;
            this.pictureBoxFormula.TabStop = false;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxVarX);
            this.groupBoxInput.Controls.Add(this.labelX);
            this.groupBoxInput.Controls.Add(this.textBox2);
            this.groupBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput.Location = new System.Drawing.Point(12, 280);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(525, 96);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // textBoxVarX
            // 
            this.textBoxVarX.Location = new System.Drawing.Point(24, 48);
            this.textBoxVarX.Name = "textBoxVarX";
            this.textBoxVarX.Size = new System.Drawing.Size(140, 22);
            this.textBoxVarX.TabIndex = 8;
            this.textBoxVarX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KeyPress);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(21, 25);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(143, 16);
            this.labelX.TabIndex = 6;
            this.labelX.Text = "Введите значение x:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.labelResult);
            this.groupBoxOutput.Controls.Add(this.textBoxResult);
            this.groupBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutput.Location = new System.Drawing.Point(564, 280);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(224, 96);
            this.groupBoxOutput.TabIndex = 0;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод данных";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(20, 25);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(81, 16);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(23, 48);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(78, 22);
            this.textBoxResult.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(669, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.Location = new System.Drawing.Point(601, 386);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(62, 52);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 30 | Недоспасова.А.Э";
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.TextBox textBoxVarX;
    }
}

