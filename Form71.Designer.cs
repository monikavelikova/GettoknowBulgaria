﻿namespace GettoknowBulgaria
{
    partial class FormKardzhaliProvinceEcoPathsEn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKardzhaliProvinceEcoPathsEn));
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.labelZaglavie = new System.Windows.Forms.Label();
            this.pictureBoxMinimizee = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizee)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(995, -1);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(45, 35);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // labelZaglavie
            // 
            this.labelZaglavie.AutoSize = true;
            this.labelZaglavie.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZaglavie.ForeColor = System.Drawing.Color.Transparent;
            this.labelZaglavie.Location = new System.Drawing.Point(417, 9);
            this.labelZaglavie.Name = "labelZaglavie";
            this.labelZaglavie.Size = new System.Drawing.Size(212, 55);
            this.labelZaglavie.TabIndex = 1;
            this.labelZaglavie.Text = "Eco Paths";
            // 
            // pictureBoxMinimizee
            // 
            this.pictureBoxMinimizee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimizee.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimizee.Image")));
            this.pictureBoxMinimizee.Location = new System.Drawing.Point(944, -1);
            this.pictureBoxMinimizee.Name = "pictureBoxMinimizee";
            this.pictureBoxMinimizee.Size = new System.Drawing.Size(45, 35);
            this.pictureBoxMinimizee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinimizee.TabIndex = 2;
            this.pictureBoxMinimizee.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonBack.Location = new System.Drawing.Point(400, 658);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(200, 65);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormKardzhaliProvinceEcoPathsEn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1040, 735);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBoxMinimizee);
            this.Controls.Add(this.labelZaglavie);
            this.Controls.Add(this.pictureBoxClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKardzhaliProvinceEcoPathsEn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form71";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label labelZaglavie;
        private System.Windows.Forms.PictureBox pictureBoxMinimizee;
        private System.Windows.Forms.Button buttonBack;
    }
}