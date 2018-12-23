using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Model;
using BusinessLayer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodd.Forms_F
{
    public partial class ChangePass : Form
    {
        Accounts accKeep = new Accounts();
        public ChangePass(Accounts acc):this()
        {
            accKeep = acc;
        }
        public ChangePass()
        {
            InitializeComponent();
            txtConNewPass.PasswordChar = '*';
            txtNewPass.PasswordChar = '*';
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text!=txtConNewPass.Text)
            {
                if(MessageBox.Show("New password and confirm password are not match!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)==DialogResult.Retry)
                {
                    txtConNewPass.Clear();
                    txtNewPass.Clear();
                    txtNewPass.Focus();
                }
                else
                {
                    Hide();
                }
            }
            else
            {
                AccountBUS.changepass(accKeep.username, txtNewPass.Text);
                MessageBox.Show("Password changed!", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
