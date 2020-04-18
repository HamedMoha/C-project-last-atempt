using System;

namespace user_login
{
    partial class Form1
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
            this.Grblogin = new System.Windows.Forms.GroupBox();
            this.Txtpassword = new System.Windows.Forms.TextBox();
            this.Txtuser = new System.Windows.Forms.TextBox();
            this.Lblpassword = new System.Windows.Forms.Label();
            this.Lbluser = new System.Windows.Forms.Label();
            this.Btnlogin = new System.Windows.Forms.Button();
            this.Btnexit = new System.Windows.Forms.Button();
            this.BtnRad = new System.Windows.Forms.Button();
            this.BtnCombo = new System.Windows.Forms.Button();
            this.BtnCheckBox = new System.Windows.Forms.Button();
            this.BtnPicbox = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.BtnRandomCombo = new System.Windows.Forms.Button();
            this.BtnGbBasicCONTROLS = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BtnGbGrapical = new System.Windows.Forms.GroupBox();
            this.BtnGbMoreControls = new System.Windows.Forms.GroupBox();
            this.Grblogin.SuspendLayout();
            this.BtnGbBasicCONTROLS.SuspendLayout();
            this.BtnGbGrapical.SuspendLayout();
            this.BtnGbMoreControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grblogin
            // 
            this.Grblogin.BackColor = System.Drawing.Color.NavajoWhite;
            this.Grblogin.Controls.Add(this.Txtpassword);
            this.Grblogin.Controls.Add(this.Txtuser);
            this.Grblogin.Controls.Add(this.Lblpassword);
            this.Grblogin.Controls.Add(this.Lbluser);
            this.Grblogin.Controls.Add(this.Btnlogin);
            this.Grblogin.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Grblogin.Location = new System.Drawing.Point(12, 90);
            this.Grblogin.Name = "Grblogin";
            this.Grblogin.Size = new System.Drawing.Size(417, 225);
            this.Grblogin.TabIndex = 0;
            this.Grblogin.TabStop = false;
            this.Grblogin.Text = "LOGIN";
            // 
            // Txtpassword
            // 
            this.Txtpassword.Location = new System.Drawing.Point(196, 95);
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.Size = new System.Drawing.Size(100, 27);
            this.Txtpassword.TabIndex = 5;
            // 
            // Txtuser
            // 
            this.Txtuser.Location = new System.Drawing.Point(196, 48);
            this.Txtuser.Name = "Txtuser";
            this.Txtuser.Size = new System.Drawing.Size(100, 27);
            this.Txtuser.TabIndex = 4;
            // 
            // Lblpassword
            // 
            this.Lblpassword.AutoSize = true;
            this.Lblpassword.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Lblpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lblpassword.Location = new System.Drawing.Point(65, 103);
            this.Lblpassword.Name = "Lblpassword";
            this.Lblpassword.Size = new System.Drawing.Size(94, 19);
            this.Lblpassword.TabIndex = 3;
            this.Lblpassword.Text = "PASSWORD";
            // 
            // Lbluser
            // 
            this.Lbluser.AutoSize = true;
            this.Lbluser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Lbluser.ForeColor = System.Drawing.Color.Black;
            this.Lbluser.Location = new System.Drawing.Point(65, 48);
            this.Lbluser.Name = "Lbluser";
            this.Lbluser.Size = new System.Drawing.Size(96, 19);
            this.Lbluser.TabIndex = 2;
            this.Lbluser.Text = "USER NAME";
            // 
            // Btnlogin
            // 
            this.Btnlogin.BackColor = System.Drawing.Color.Red;
            this.Btnlogin.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Btnlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btnlogin.Location = new System.Drawing.Point(0, 188);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(417, 37);
            this.Btnlogin.TabIndex = 0;
            this.Btnlogin.Text = "LOGIN";
            this.Btnlogin.UseVisualStyleBackColor = false;
            this.Btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // Btnexit
            // 
            this.Btnexit.BackColor = System.Drawing.Color.Red;
            this.Btnexit.Font = new System.Drawing.Font("Tahoma", 20F);
            this.Btnexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btnexit.Location = new System.Drawing.Point(1093, 376);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(153, 45);
            this.Btnexit.TabIndex = 1;
            this.Btnexit.Text = "EXIT";
            this.Btnexit.UseVisualStyleBackColor = false;
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // BtnRad
            // 
            this.BtnRad.ForeColor = System.Drawing.Color.Orange;
            this.BtnRad.Location = new System.Drawing.Point(42, 18);
            this.BtnRad.Name = "BtnRad";
            this.BtnRad.Size = new System.Drawing.Size(75, 23);
            this.BtnRad.TabIndex = 1;
            this.BtnRad.Text = "Radio";
            this.BtnRad.UseVisualStyleBackColor = true;
            this.BtnRad.Click += new System.EventHandler(this.BtnRad_Click);
            // 
            // BtnCombo
            // 
            this.BtnCombo.ForeColor = System.Drawing.Color.Orange;
            this.BtnCombo.Location = new System.Drawing.Point(42, 71);
            this.BtnCombo.Name = "BtnCombo";
            this.BtnCombo.Size = new System.Drawing.Size(75, 23);
            this.BtnCombo.TabIndex = 2;
            this.BtnCombo.Text = "Combo";
            this.BtnCombo.UseVisualStyleBackColor = true;
            this.BtnCombo.Click += new System.EventHandler(this.BtnCombo_Click);
            // 
            // BtnCheckBox
            // 
            this.BtnCheckBox.ForeColor = System.Drawing.Color.Orange;
            this.BtnCheckBox.Location = new System.Drawing.Point(42, 47);
            this.BtnCheckBox.Name = "BtnCheckBox";
            this.BtnCheckBox.Size = new System.Drawing.Size(75, 23);
            this.BtnCheckBox.TabIndex = 3;
            this.BtnCheckBox.Text = "CheckBox";
            this.BtnCheckBox.UseVisualStyleBackColor = true;
            this.BtnCheckBox.Click += new System.EventHandler(this.BtnCheckBox_Click);
            // 
            // BtnPicbox
            // 
            this.BtnPicbox.ForeColor = System.Drawing.Color.Orange;
            this.BtnPicbox.Location = new System.Drawing.Point(6, 19);
            this.BtnPicbox.Name = "BtnPicbox";
            this.BtnPicbox.Size = new System.Drawing.Size(142, 54);
            this.BtnPicbox.TabIndex = 4;
            this.BtnPicbox.Text = "Picture Box";
            this.BtnPicbox.UseVisualStyleBackColor = true;
            this.BtnPicbox.Click += new System.EventHandler(this.BtnPicbox_Click);
            // 
            // BtnRandom
            // 
            this.BtnRandom.ForeColor = System.Drawing.Color.Orange;
            this.BtnRandom.Location = new System.Drawing.Point(42, 23);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(75, 23);
            this.BtnRandom.TabIndex = 10;
            this.BtnRandom.Text = "Random";
            this.BtnRandom.UseVisualStyleBackColor = true;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // BtnRandomCombo
            // 
            this.BtnRandomCombo.ForeColor = System.Drawing.Color.Orange;
            this.BtnRandomCombo.Location = new System.Drawing.Point(42, 52);
            this.BtnRandomCombo.Name = "BtnRandomCombo";
            this.BtnRandomCombo.Size = new System.Drawing.Size(75, 42);
            this.BtnRandomCombo.TabIndex = 11;
            this.BtnRandomCombo.Text = "RandomCombo";
            this.BtnRandomCombo.UseVisualStyleBackColor = true;
            this.BtnRandomCombo.Click += new System.EventHandler(this.BtnRandomCombo_Click);
            // 
            // BtnGbBasicCONTROLS
            // 
            this.BtnGbBasicCONTROLS.Controls.Add(this.BtnRad);
            this.BtnGbBasicCONTROLS.Controls.Add(this.BtnCheckBox);
            this.BtnGbBasicCONTROLS.Controls.Add(this.BtnCombo);
            this.BtnGbBasicCONTROLS.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnGbBasicCONTROLS.ForeColor = System.Drawing.Color.Red;
            this.BtnGbBasicCONTROLS.Location = new System.Drawing.Point(470, 12);
            this.BtnGbBasicCONTROLS.Name = "BtnGbBasicCONTROLS";
            this.BtnGbBasicCONTROLS.Size = new System.Drawing.Size(166, 100);
            this.BtnGbBasicCONTROLS.TabIndex = 19;
            this.BtnGbBasicCONTROLS.TabStop = false;
            this.BtnGbBasicCONTROLS.Text = "Basic Controls";
            // 
            // BtnGbGrapical
            // 
            this.BtnGbGrapical.Controls.Add(this.BtnPicbox);
            this.BtnGbGrapical.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnGbGrapical.ForeColor = System.Drawing.Color.Red;
            this.BtnGbGrapical.Location = new System.Drawing.Point(470, 139);
            this.BtnGbGrapical.Name = "BtnGbGrapical";
            this.BtnGbGrapical.Size = new System.Drawing.Size(166, 100);
            this.BtnGbGrapical.TabIndex = 20;
            this.BtnGbGrapical.TabStop = false;
            this.BtnGbGrapical.Text = "Grapical";
            // 
            // BtnGbMoreControls
            // 
            this.BtnGbMoreControls.Controls.Add(this.BtnRandom);
            this.BtnGbMoreControls.Controls.Add(this.BtnRandomCombo);
            this.BtnGbMoreControls.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnGbMoreControls.ForeColor = System.Drawing.Color.Red;
            this.BtnGbMoreControls.Location = new System.Drawing.Point(470, 273);
            this.BtnGbMoreControls.Name = "BtnGbMoreControls";
            this.BtnGbMoreControls.Size = new System.Drawing.Size(166, 100);
            this.BtnGbMoreControls.TabIndex = 21;
            this.BtnGbMoreControls.TabStop = false;
            this.BtnGbMoreControls.Text = "More Controls";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1258, 450);
            this.Controls.Add(this.BtnGbMoreControls);
            this.Controls.Add(this.BtnGbGrapical);
            this.Controls.Add(this.BtnGbBasicCONTROLS);
            this.Controls.Add(this.Btnexit);
            this.Controls.Add(this.Grblogin);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Grblogin.ResumeLayout(false);
            this.Grblogin.PerformLayout();
            this.BtnGbBasicCONTROLS.ResumeLayout(false);
            this.BtnGbGrapical.ResumeLayout(false);
            this.BtnGbMoreControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void BtnRad_Click(object sender, EventArgs e)
        {
            RadioForm frm = new RadioForm();
            frm.ShowDialog();
        }

        #endregion

        private System.Windows.Forms.GroupBox Grblogin;
        private System.Windows.Forms.TextBox Txtpassword;
        private System.Windows.Forms.TextBox Txtuser;
        private System.Windows.Forms.Label Lblpassword;
        private System.Windows.Forms.Label Lbluser;
        private System.Windows.Forms.Button Btnexit;
        private System.Windows.Forms.Button Btnlogin;
        private System.Windows.Forms.Button BtnRad;
        private System.Windows.Forms.Button BtnCombo;
        private System.Windows.Forms.Button BtnCheckBox;
        private System.Windows.Forms.Button BtnPicbox;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.Button BtnRandomCombo;
        private System.Windows.Forms.GroupBox BtnGbBasicCONTROLS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox BtnGbGrapical;
        private System.Windows.Forms.GroupBox BtnGbMoreControls;
    }
}

