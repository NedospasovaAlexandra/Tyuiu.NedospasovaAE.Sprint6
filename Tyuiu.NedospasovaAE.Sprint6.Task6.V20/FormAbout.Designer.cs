
namespace Tyuiu.NedospasovaAE.Sprint6.Task6.V20
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_NAE = new System.Windows.Forms.Label();
            this.pictureBox_NAE = new System.Windows.Forms.PictureBox();
            this.buttonOk_NAE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NAE)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_NAE
            // 
            this.labelInfo_NAE.AutoSize = true;
            this.labelInfo_NAE.Location = new System.Drawing.Point(191, 12);
            this.labelInfo_NAE.Name = "labelInfo_NAE";
            this.labelInfo_NAE.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_NAE.TabIndex = 0;
            this.labelInfo_NAE.Text = resources.GetString("labelInfo_NAE.Text");
            // 
            // pictureBox_NAE
            // 
            this.pictureBox_NAE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_NAE.Image")));
            this.pictureBox_NAE.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_NAE.Name = "pictureBox_NAE";
            this.pictureBox_NAE.Size = new System.Drawing.Size(173, 235);
            this.pictureBox_NAE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_NAE.TabIndex = 1;
            this.pictureBox_NAE.TabStop = false;
            // 
            // buttonOk_NAE
            // 
            this.buttonOk_NAE.Location = new System.Drawing.Point(384, 203);
            this.buttonOk_NAE.Name = "buttonOk_NAE";
            this.buttonOk_NAE.Size = new System.Drawing.Size(91, 44);
            this.buttonOk_NAE.TabIndex = 2;
            this.buttonOk_NAE.Text = "OK";
            this.buttonOk_NAE.UseVisualStyleBackColor = true;
            this.buttonOk_NAE.Click += new System.EventHandler(this.buttonOk_NAE_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 259);
            this.Controls.Add(this.buttonOk_NAE);
            this.Controls.Add(this.pictureBox_NAE);
            this.Controls.Add(this.labelInfo_NAE);
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О пользователе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NAE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_NAE;
        private System.Windows.Forms.PictureBox pictureBox_NAE;
        private System.Windows.Forms.Button buttonOk_NAE;
    }
}