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
    public partial class ComboForm : Form
    {
        public ComboForm()
        {
            InitializeComponent();
            CBDays.Items.Add("Sunday");
            CBDays.Items.Add("Monday");
            CBDays.Items.Add("Tuesday");
            CBDays.Items.Add("Wdnesday");
            CBDays.Items.Add("Thursday");
            CBDays.Items.Add("Friday");
            CBDays.Items.Add("Saturday");
        }

        private void Showbutt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CBDays.Text);
        }

        private void CBDays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemLast1butt_Click(object sender, EventArgs e)
        {
            if (CBDays.Items.Count >= 1) // to know the number of items
            {
                CBDays.Items.RemoveAt(CBDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("cant remove last item");
            }
        }

        private void RemLast2butt_Click(object sender, EventArgs e)
        {
             if (CBDays.Items.Count >= 2)
            {
                CBDays.Items.RemoveAt(CBDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("cant remove last item");
            }
        }

        private void RemInButt_Click(object sender, EventArgs e)
        {
            CBDays.Items.RemoveAt(1);
        }

        private void RemNaButt_Click(object sender, EventArgs e)
        {
            CBDays.Items.Remove("Friday");
        }

        private void ExButt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
