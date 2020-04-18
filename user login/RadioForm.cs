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
    public partial class RadioForm : Form

    {
        public RadioForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnRadRed.ForeColor = Color.FromArgb(0, 0, 0);
            BtnRadGreen.ForeColor = Color.FromArgb(0, 0, 0);
            BtnRadBlue.ForeColor = Color.FromArgb(0, 0, 0);
            BtnRadYellow.ForeColor = Color.FromArgb(0, 0, 0);

            BtnRadRed.Checked = false;
            BtnRadGreen.Checked = false;
            BtnRadBlue.Checked = false;
            BtnRadYellow.Checked = false;

            BtnRadRed2.ForeColor = Color.FromArgb(0, 0, 0);
            BtnRadGreen2.ForeColor = Color.FromArgb(0, 0, 0);
            BtnRadBlue2.ForeColor = Color.FromArgb(0, 0, 0);
            BtnRadYellow2.ForeColor = Color.FromArgb(0, 0, 0);

            BtnRadRed2.Checked = false;
            BtnRadBlue2.Checked = false;
            BtnRadGreen2.Checked = false;
            BtnRadYellow2.Checked = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmradio_Load(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnRadRed.Checked == true)

                BtnRadRed.ForeColor = Color.FromArgb(255, 0, 0);
            else

                BtnRadRed.ForeColor = Color.FromArgb(0, 0, 0);

        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnRadGreen.Checked == true)

                BtnRadGreen.ForeColor = Color.FromArgb(0, 255, 0);
            else

                BtnRadGreen.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void BtnRadBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnRadBlue.Checked == true)

                BtnRadBlue.ForeColor = Color.FromArgb(0, 0, 255);
            else

                BtnRadBlue.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void BtnRadYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnRadYellow.Checked == true)

                BtnRadYellow.ForeColor = Color.FromArgb(255, 255, 0);
            else

                BtnRadYellow.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void BtnRadRed2_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnRadRed2.Checked == true)

                BtnRadRed2.ForeColor = Color.FromArgb(255, 0, 0);
            else

                BtnRadRed2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void BtnRadGreen2_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnRadGreen2.Checked == true)

                BtnRadGreen2.ForeColor = Color.FromArgb(0, 255, 0);
            else

                BtnRadGreen2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void BtnRadBlue2_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnRadBlue2.Checked == true)

                BtnRadBlue2.ForeColor = Color.FromArgb(0, 0, 255);
            else

                BtnRadBlue2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void BtnRadYellow2_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnRadYellow2.Checked == true)

                BtnRadYellow2.ForeColor = Color.FromArgb(255, 255, 0);
            else

                BtnRadYellow2.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
}
