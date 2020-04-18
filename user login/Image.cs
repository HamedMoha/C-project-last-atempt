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
    public partial class Image : Form
    {
        public Image()
        {
            InitializeComponent();
        }

        private void LoadButt_Click(object sender, EventArgs e)
        {
            try
            {

                pictureBox1.Image = Image.FromFile("C:\\Users\\USER\\Desktop\\C#\\20.png");
            }
            catch
            {
                MessageBox.Show("Image file not found!");
            }

        }

       
    }
}
 