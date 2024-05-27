
using System;

namespace Tyuiu.NedospasovaAE.Sprint6.Task7.V19
{
    partial class FormAbout_NAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_NAE));
            this.labelInfo_NAE = new System.Windows.Forms.Label();
            this.buttonOk_NAE = new System.Windows.Forms.Button();
            this.pictureBoxMe_NAE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_NAE)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_NAE
            // 
            this.labelInfo_NAE.AutoSize = true;
            this.labelInfo_NAE.Location = new System.Drawing.Point(182, 12);
            this.labelInfo_NAE.Name = "labelInfo_NAE";
            this.labelInfo_NAE.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_NAE.TabIndex = 0;
            this.labelInfo_NAE.Text = resources.GetString("labelInfo_NAE.Text");
            // 
            // buttonOk_NAE
            // 
            this.buttonOk_NAE.Location = new System.Drawing.Point(371, 194);
            this.buttonOk_NAE.Name = "buttonOk_NAE";
            this.buttonOk_NAE.Size = new System.Drawing.Size(95, 35);
            this.buttonOk_NAE.TabIndex = 2;
            this.buttonOk_NAE.Text = "ОК";
            this.buttonOk_NAE.UseVisualStyleBackColor = true;
            this.buttonOk_NAE.Click += new System.EventHandler(this.buttonOk_NAE_Click);
            // 
            // pictureBoxMe_NAE
            // 
            this.pictureBoxMe_NAE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMe_NAE.Image")));
            this.pictureBoxMe_NAE.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMe_NAE.Name = "pictureBoxMe_NAE";
            this.pictureBoxMe_NAE.Size = new System.Drawing.Size(164, 217);
            this.pictureBoxMe_NAE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMe_NAE.TabIndex = 1;
            this.pictureBoxMe_NAE.TabStop = false;
            this.pictureBoxMe_NAE.Click += new System.EventHandler(this.pictureBoxMe_NAE_Click);
            // 
            // FormAbout_NAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 241);
            this.Controls.Add(this.buttonOk_NAE);
            this.Controls.Add(this.pictureBoxMe_NAE);
            this.Controls.Add(this.labelInfo_NAE);
            this.Name = "FormAbout_NAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О пользователе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_NAE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBoxMe_NAE_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label labelInfo_NAE;
        private System.Windows.Forms.PictureBox pictureBoxMe_NAE;
        private System.Windows.Forms.Button buttonOk_NAE;
    }
}