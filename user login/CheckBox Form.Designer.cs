namespace user_login
{
    partial class CheckBox_Form
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
            this.ShowButt = new System.Windows.Forms.Button();
            this.CKboxDonut = new System.Windows.Forms.CheckBox();
            this.CKboxCoffe = new System.Windows.Forms.CheckBox();
            this.CKboxBrownie = new System.Windows.Forms.CheckBox();
            this.ExitButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowButt
            // 
            this.ShowButt.BackColor = System.Drawing.Color.Silver;
            this.ShowButt.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButt.ForeColor = System.Drawing.Color.Black;
            this.ShowButt.Location = new System.Drawing.Point(55, 159);
            this.ShowButt.Name = "ShowButt";
            this.ShowButt.Size = new System.Drawing.Size(225, 48);
            this.ShowButt.TabIndex = 0;
            this.ShowButt.Text = "Show";
            this.ShowButt.UseVisualStyleBackColor = false;
            this.ShowButt.Click += new System.EventHandler(this.ShowButt_Click);
            // 
            // CKboxDonut
            // 
            this.CKboxDonut.AutoSize = true;
            this.CKboxDonut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKboxDonut.ForeColor = System.Drawing.Color.Black;
            this.CKboxDonut.Location = new System.Drawing.Point(128, 107);
            this.CKboxDonut.Name = "CKboxDonut";
            this.CKboxDonut.Size = new System.Drawing.Size(71, 23);
            this.CKboxDonut.TabIndex = 1;
            this.CKboxDonut.Text = "Donut";
            this.CKboxDonut.UseVisualStyleBackColor = true;
            // 
            // CKboxCoffe
            // 
            this.CKboxCoffe.AutoSize = true;
            this.CKboxCoffe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKboxCoffe.ForeColor = System.Drawing.Color.Black;
            this.CKboxCoffe.Location = new System.Drawing.Point(128, 24);
            this.CKboxCoffe.Name = "CKboxCoffe";
            this.CKboxCoffe.Size = new System.Drawing.Size(65, 23);
            this.CKboxCoffe.TabIndex = 2;
            this.CKboxCoffe.Text = "Coffe";
            this.CKboxCoffe.UseVisualStyleBackColor = true;
            // 
            // CKboxBrownie
            // 
            this.CKboxBrownie.AutoSize = true;
            this.CKboxBrownie.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKboxBrownie.ForeColor = System.Drawing.Color.Black;
            this.CKboxBrownie.Location = new System.Drawing.Point(128, 62);
            this.CKboxBrownie.Name = "CKboxBrownie";
            this.CKboxBrownie.Size = new System.Drawing.Size(85, 23);
            this.CKboxBrownie.TabIndex = 3;
            this.CKboxBrownie.Text = "Brownie";
            this.CKboxBrownie.UseVisualStyleBackColor = true;
            // 
            // ExitButt
            // 
            this.ExitButt.BackColor = System.Drawing.Color.Silver;
            this.ExitButt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButt.Location = new System.Drawing.Point(128, 213);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(75, 23);
            this.ExitButt.TabIndex = 4;
            this.ExitButt.Text = "Exit";
            this.ExitButt.UseVisualStyleBackColor = false;
            this.ExitButt.Click += new System.EventHandler(this.ExitButt_Click);
            // 
            // CheckBox_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(370, 268);
            this.Controls.Add(this.ExitButt);
            this.Controls.Add(this.CKboxBrownie);
            this.Controls.Add(this.CKboxCoffe);
            this.Controls.Add(this.CKboxDonut);
            this.Controls.Add(this.ShowButt);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "CheckBox_Form";
            this.Text = "CheckBox_Form";
            this.Load += new System.EventHandler(this.CheckBox_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowButt;
        private System.Windows.Forms.CheckBox CKboxDonut;
        private System.Windows.Forms.CheckBox CKboxCoffe;
        private System.Windows.Forms.CheckBox CKboxBrownie;
        private System.Windows.Forms.Button ExitButt;
    }
}