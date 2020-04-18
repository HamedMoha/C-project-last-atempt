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
    public partial class RandomCombo : Form
    {
        public RandomCombo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenCB1.ResetText();
            GenCB1.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 51); i++)
            {
                GenCB1.Items.Add(r.Next(100, 999));
            }
        }

        private void ResetButt1_Click(object sender, EventArgs e)
        {
            GenCB1.ResetText();
            GenCB1.Items.Clear();
            More1CB.Checked = false;
            Less1CB.Checked = false;
        }

        private void GenCB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(GenCB1.Text) > 499)
            {
                More1CB.Checked = true;
            }
            else
            {
                Less1CB.Checked = true;
            }
        }

        private void GenButt2_Click(object sender, EventArgs e)
        {
            GenCB2.ResetText();
            GenCB2.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(2, 9) - 1; i++)
            {
                GenCB2.Items.Add(r.Next(10, 99));
            }
        }

        private void GenCB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(GenCB2.Text) > 49)
            {
                More2CB.Checked = true;
            }
            else
            {
                Less2CB.Checked = true;
            }
        }

        private void ResetButt2_Click(object sender, EventArgs e)
        {
            GenCB2.ResetText();
            GenCB2.Items.Clear();
            More2CB.Checked = false;
            Less2CB.Checked = false;
        }
    }
}
