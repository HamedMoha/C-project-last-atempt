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
    public partial class CheckBox_Form : Form
    {
        public CheckBox_Form()
        {
            InitializeComponent();
        }

        private void CheckBox_Form_Load(object sender, EventArgs e)
        {

        }

        private void ShowButt_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (CKboxCoffe.Checked == true)
            {
                msg = CKboxCoffe.Text;
            }
            if (CKboxDonut.Checked == true)
            {
                msg = msg + CKboxDonut.Text;
            }
            if (CKboxBrownie.Checked == true)
            {
                msg = msg + CKboxBrownie.Text;
            }

            if (msg.Length == 0)
            {
                msg = "nothing selected";
            }
            MessageBox.Show(msg);
        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
