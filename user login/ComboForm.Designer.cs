namespace user_login
{
    partial class ComboForm
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
            this.Showbutt = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RemLast2butt = new System.Windows.Forms.Button();
            this.RemLast1butt = new System.Windows.Forms.Button();
            this.RemNaButt = new System.Windows.Forms.Button();
            this.RemInButt = new System.Windows.Forms.Button();
            this.ShowButt2 = new System.Windows.Forms.Button();
            this.ExButt = new System.Windows.Forms.Button();
            this.CBDays = new System.Windows.Forms.ComboBox();
            this.LabDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Showbutt
            // 
            this.Showbutt.BackColor = System.Drawing.Color.Silver;
            this.Showbutt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Showbutt.Location = new System.Drawing.Point(28, 55);
            this.Showbutt.Name = "Showbutt";
            this.Showbutt.Size = new System.Drawing.Size(196, 44);
            this.Showbutt.TabIndex = 0;
            this.Showbutt.Text = "Show Selected Method 1";
            this.Showbutt.UseVisualStyleBackColor = false;
            this.Showbutt.Click += new System.EventHandler(this.Showbutt_Click);
            // 
            // RemLast2butt
            // 
            this.RemLast2butt.BackColor = System.Drawing.Color.Silver;
            this.RemLast2butt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemLast2butt.Location = new System.Drawing.Point(322, 142);
            this.RemLast2butt.Name = "RemLast2butt";
            this.RemLast2butt.Size = new System.Drawing.Size(196, 79);
            this.RemLast2butt.TabIndex = 1;
            this.RemLast2butt.Text = "Remove 2ND Last Item";
            this.RemLast2butt.UseVisualStyleBackColor = false;
            this.RemLast2butt.Click += new System.EventHandler(this.RemLast2butt_Click);
            // 
            // RemLast1butt
            // 
            this.RemLast1butt.BackColor = System.Drawing.Color.Silver;
            this.RemLast1butt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemLast1butt.Location = new System.Drawing.Point(541, 142);
            this.RemLast1butt.Name = "RemLast1butt";
            this.RemLast1butt.Size = new System.Drawing.Size(196, 79);
            this.RemLast1butt.TabIndex = 2;
            this.RemLast1butt.Text = "Remove Last Item";
            this.RemLast1butt.UseVisualStyleBackColor = false;
            this.RemLast1butt.Click += new System.EventHandler(this.RemLast1butt_Click);
            // 
            // RemNaButt
            // 
            this.RemNaButt.BackColor = System.Drawing.Color.Silver;
            this.RemNaButt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemNaButt.Location = new System.Drawing.Point(212, 266);
            this.RemNaButt.Name = "RemNaButt";
            this.RemNaButt.Size = new System.Drawing.Size(150, 44);
            this.RemNaButt.TabIndex = 3;
            this.RemNaButt.Text = "Remove By Name";
            this.RemNaButt.UseVisualStyleBackColor = false;
            this.RemNaButt.Click += new System.EventHandler(this.RemNaButt_Click);
            // 
            // RemInButt
            // 
            this.RemInButt.BackColor = System.Drawing.Color.Silver;
            this.RemInButt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemInButt.Location = new System.Drawing.Point(28, 266);
            this.RemInButt.Name = "RemInButt";
            this.RemInButt.Size = new System.Drawing.Size(150, 44);
            this.RemInButt.TabIndex = 4;
            this.RemInButt.Text = "Remove By Indix";
            this.RemInButt.UseVisualStyleBackColor = false;
            this.RemInButt.Click += new System.EventHandler(this.RemInButt_Click);
            // 
            // ShowButt2
            // 
            this.ShowButt2.BackColor = System.Drawing.Color.Silver;
            this.ShowButt2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButt2.Location = new System.Drawing.Point(28, 105);
            this.ShowButt2.Name = "ShowButt2";
            this.ShowButt2.Size = new System.Drawing.Size(196, 44);
            this.ShowButt2.TabIndex = 5;
            this.ShowButt2.Text = "Show Selected Method 2";
            this.ShowButt2.UseVisualStyleBackColor = false;
            // 
            // ExButt
            // 
            this.ExButt.BackColor = System.Drawing.Color.Silver;
            this.ExButt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExButt.ForeColor = System.Drawing.Color.Red;
            this.ExButt.Location = new System.Drawing.Point(569, 336);
            this.ExButt.Name = "ExButt";
            this.ExButt.Size = new System.Drawing.Size(171, 46);
            this.ExButt.TabIndex = 6;
            this.ExButt.Text = "Exit ";
            this.ExButt.UseVisualStyleBackColor = false;
            this.ExButt.Click += new System.EventHandler(this.ExButt_Click);
            // 
            // CBDays
            // 
            this.CBDays.FormattingEnabled = true;
            this.CBDays.Location = new System.Drawing.Point(86, 171);
            this.CBDays.Name = "CBDays";
            this.CBDays.Size = new System.Drawing.Size(213, 21);
            this.CBDays.TabIndex = 7;
            this.CBDays.SelectedIndexChanged += new System.EventHandler(this.CBDays_SelectedIndexChanged);
            // 
            // LabDays
            // 
            this.LabDays.AutoSize = true;
            this.LabDays.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDays.ForeColor = System.Drawing.Color.Red;
            this.LabDays.Location = new System.Drawing.Point(24, 173);
            this.LabDays.Name = "LabDays";
            this.LabDays.Size = new System.Drawing.Size(44, 19);
            this.LabDays.TabIndex = 8;
            this.LabDays.Text = "Days";
            // 
            // ComboForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(744, 382);
            this.Controls.Add(this.LabDays);
            this.Controls.Add(this.CBDays);
            this.Controls.Add(this.ExButt);
            this.Controls.Add(this.ShowButt2);
            this.Controls.Add(this.RemInButt);
            this.Controls.Add(this.RemNaButt);
            this.Controls.Add(this.RemLast1butt);
            this.Controls.Add(this.RemLast2butt);
            this.Controls.Add(this.Showbutt);
            this.Name = "ComboForm";
            this.Text = "ComboForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Showbutt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button RemLast2butt;
        private System.Windows.Forms.Button RemLast1butt;
        private System.Windows.Forms.Button RemNaButt;
        private System.Windows.Forms.Button RemInButt;
        private System.Windows.Forms.Button ShowButt2;
        private System.Windows.Forms.Button ExButt;
        private System.Windows.Forms.ComboBox CBDays;
        private System.Windows.Forms.Label LabDays;
    }
}