namespace CoraabiaTime
{
    partial class CoraabiaTime
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.actualizeBtn = new System.Windows.Forms.Button();
            this.coraabianTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(23, 18);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(102, 13);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Aktuální lidský čas: ";
            // 
            // actualizeBtn
            // 
            this.actualizeBtn.Location = new System.Drawing.Point(612, 359);
            this.actualizeBtn.Name = "actualizeBtn";
            this.actualizeBtn.Size = new System.Drawing.Size(75, 23);
            this.actualizeBtn.TabIndex = 1;
            this.actualizeBtn.Text = "Aktualizuj";
            this.actualizeBtn.UseVisualStyleBackColor = true;
            this.actualizeBtn.Click += new System.EventHandler(this.actualizeBtn_Click);
            // 
            // coraabianTimeLabel
            // 
            this.coraabianTimeLabel.AutoSize = true;
            this.coraabianTimeLabel.Location = new System.Drawing.Point(320, 18);
            this.coraabianTimeLabel.Name = "coraabianTimeLabel";
            this.coraabianTimeLabel.Size = new System.Drawing.Size(119, 13);
            this.coraabianTimeLabel.TabIndex = 2;
            this.coraabianTimeLabel.Text = "Aktuální coraabský čas";
            // 
            // CoraabiaTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 441);
            this.Controls.Add(this.coraabianTimeLabel);
            this.Controls.Add(this.actualizeBtn);
            this.Controls.Add(this.timeLabel);
            this.Name = "CoraabiaTime";
            this.Text = "Coraabia time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button actualizeBtn;
        private System.Windows.Forms.Label coraabianTimeLabel;
    }
}

