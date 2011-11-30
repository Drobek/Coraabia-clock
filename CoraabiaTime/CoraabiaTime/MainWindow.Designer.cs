﻿namespace CoraabiaTime
{
    partial class MainWindow
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
            this.humanTimeLbl = new System.Windows.Forms.Label();
            this.coraabLongLbl = new System.Windows.Forms.Label();
            this.coraabianShortLbl = new System.Windows.Forms.Label();
            this.actualizeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // humanTimeLbl
            // 
            this.humanTimeLbl.AutoSize = true;
            this.humanTimeLbl.Location = new System.Drawing.Point(12, 9);
            this.humanTimeLbl.Name = "humanTimeLbl";
            this.humanTimeLbl.Size = new System.Drawing.Size(63, 13);
            this.humanTimeLbl.TabIndex = 0;
            this.humanTimeLbl.Text = "Human time";
            // 
            // coraabLongLbl
            // 
            this.coraabLongLbl.AutoSize = true;
            this.coraabLongLbl.Location = new System.Drawing.Point(12, 33);
            this.coraabLongLbl.Name = "coraabLongLbl";
            this.coraabLongLbl.Size = new System.Drawing.Size(101, 13);
            this.coraabLongLbl.TabIndex = 1;
            this.coraabLongLbl.Text = "coiraabian long time";
            // 
            // coraabianShortLbl
            // 
            this.coraabianShortLbl.AutoSize = true;
            this.coraabianShortLbl.Location = new System.Drawing.Point(12, 60);
            this.coraabianShortLbl.Name = "coraabianShortLbl";
            this.coraabianShortLbl.Size = new System.Drawing.Size(102, 13);
            this.coraabianShortLbl.TabIndex = 2;
            this.coraabianShortLbl.Text = "coraabian short time";
            // 
            // actualizeBtn
            // 
            this.actualizeBtn.Location = new System.Drawing.Point(15, 85);
            this.actualizeBtn.Name = "actualizeBtn";
            this.actualizeBtn.Size = new System.Drawing.Size(75, 23);
            this.actualizeBtn.TabIndex = 3;
            this.actualizeBtn.Text = "Aktualizuj";
            this.actualizeBtn.UseVisualStyleBackColor = true;
            this.actualizeBtn.Click += new System.EventHandler(this.actualizeBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 168);
            this.Controls.Add(this.actualizeBtn);
            this.Controls.Add(this.coraabianShortLbl);
            this.Controls.Add(this.coraabLongLbl);
            this.Controls.Add(this.humanTimeLbl);
            this.Name = "MainWindow";
            this.Text = "Human to Coraabian time converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label humanTimeLbl;
        private System.Windows.Forms.Label coraabLongLbl;
        private System.Windows.Forms.Label coraabianShortLbl;
        private System.Windows.Forms.Button actualizeBtn;
    }
}
