using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_login
{
    public partial class Form1 : Form
    {
        string username = "hamed";
        string password = "1234";
        int MaxAttempts = 3;
        int attempt = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            while (attempt <= MaxAttempts)
            {
                if (Txtuser.Text != username)
                {
                    // username is incorrect
                    MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                    attempt++;
                    return;
                }
                else
                {   // username is correct
                    // so check password			
                    if (Txtpassword.Text != password)
                    {
                        // Incorrect password
                        attempt++;
                        MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                        return;
                    }
                    else
                    {
                        //Both are correct
                        attempt = 0; // reset the number of attempts
                        MessageBox.Show("Login successful");
                        return;

                    }

                }


            }
        }

        private void BtnCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_Form frm = new CheckBox_Form();
            frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            ComboForm frm = new ComboForm();
            frm.ShowDialog();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            RandomForm frm = new RandomForm();
            frm.ShowDialog();
        }

        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {
            RandomCombo frm = new RandomCombo();
            frm.ShowDialog();
        }

        private void BtnPicbox_Click(object sender, EventArgs e)
        {
            Image frm = new Image();
            frm.ShowDialog();
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
