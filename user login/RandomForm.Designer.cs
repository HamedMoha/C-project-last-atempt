namespace user_login
{
    partial class RandomForm
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
            this.GenRanButt = new System.Windows.Forms.Button();
            this.RanNumButt = new System.Windows.Forms.Button();
            this.ExitButt = new System.Windows.Forms.Button();
            this.RGBLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenRanButt
            // 
            this.GenRanButt.BackColor = System.Drawing.Color.Silver;
            this.GenRanButt.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenRanButt.Location = new System.Drawing.Point(12, 12);
            this.GenRanButt.Name = "GenRanButt";
            this.GenRanButt.Size = new System.Drawing.Size(286, 62);
            this.GenRanButt.TabIndex = 0;
            this.GenRanButt.Text = "Generate Random Color";
            this.GenRanButt.UseVisualStyleBackColor = false;
            this.GenRanButt.Click += new System.EventHandler(this.GenRanButt_Click);
            // 
            // RanNumButt
            // 
            this.RanNumButt.BackColor = System.Drawing.Color.Silver;
            this.RanNumButt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RanNumButt.Location = new System.Drawing.Point(68, 141);
            this.RanNumButt.Name = "RanNumButt";
            this.RanNumButt.Size = new System.Drawing.Size(164, 41);
            this.RanNumButt.TabIndex = 1;
            this.RanNumButt.Text = "Random Number";
            this.RanNumButt.UseVisualStyleBackColor = false;
            this.RanNumButt.Click += new System.EventHandler(this.RanNumButt_Click);
            // 
            // ExitButt
            // 
            this.ExitButt.BackColor = System.Drawing.Color.Silver;
            this.ExitButt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButt.ForeColor = System.Drawing.Color.Red;
            this.ExitButt.Location = new System.Drawing.Point(110, 202);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(75, 37);
            this.ExitButt.TabIndex = 2;
            this.ExitButt.Text = "Exit";
            this.ExitButt.UseVisualStyleBackColor = false;
            this.ExitButt.Click += new System.EventHandler(this.ExitButt_Click);
            // 
            // RGBLab
            // 
            this.RGBLab.AutoSize = true;
            this.RGBLab.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGBLab.ForeColor = System.Drawing.Color.Black;
            this.RGBLab.Location = new System.Drawing.Point(126, 94);
            this.RGBLab.Name = "RGBLab";
            this.RGBLab.Size = new System.Drawing.Size(33, 14);
            this.RGBLab.TabIndex = 3;
            this.RGBLab.Text = "r-g-b";
            // 
            // RandomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(310, 281);
            this.Controls.Add(this.RGBLab);
            this.Controls.Add(this.ExitButt);
            this.Controls.Add(this.RanNumButt);
            this.Controls.Add(this.GenRanButt);
            this.Name = "RandomForm";
            this.Text = "RandomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenRanButt;
        private System.Windows.Forms.Button RanNumButt;
        private System.Windows.Forms.Button ExitButt;
        private System.Windows.Forms.Label RGBLab;
    }
}