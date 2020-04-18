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
    public partial class RandomForm : Form
       
    {
        Random y = new Random();
        public RandomForm()
        {
            InitializeComponent();
        }

        private void GenRanButt_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);

            RGBLab.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" +
                Convert.ToString(b);
            GenRanButt.BackColor = Color.FromArgb(r, g, b);
        }

        private void RanNumButt_Click(object sender, EventArgs e)
        {
            RanNumButt.Text = Convert.ToString(y.Next(1, 10));
        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
