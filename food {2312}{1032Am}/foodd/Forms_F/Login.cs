using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Model;
using BusinessLayer;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodd.Forms_F
{
    public partial class Login : Form
    {
        private int attempt = 5;
        
        public Login()
        {
            InitializeComponent();
            txtPass.Enabled = false;
            btnLogin.BringToFront();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }
        Accounts acc = new Accounts();
        private void btnLogin_Click(object sender, EventArgs e)
        {            
            acc.username = txtUsername.Text;
            if (AccountBUS.checkUsername(acc.username) == true)
            {
                txtUsername.Enabled = false;
                txtPass.Enabled = true;
                txtPass.Focus();
                txtPass.PasswordChar = '*';
                btnLogin.Enabled = false;
                btnContinue.BringToFront();
            }
            else
            {
                if (attempt != 0)
                {
                    if (MessageBox.Show("Login failed! Wrong password!\r\n" + --attempt + " left", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        txtUsername.Clear();
                        txtUsername.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Application close now!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            acc.password = txtPass.Text;
            if(AccountBUS.checkLogin(acc.username,acc.password)==true)
            {
                if(AccountBUS.checkIsLock(acc.username,acc.password)==true)
                {
                    MessageBox.Show("This account is being locked! Contact admin to unlock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsername.Clear();
                    txtUsername.Enabled = true;
                    txtPass.Clear();
                    txtPass.Enabled = false;
                    btnLogin.BringToFront();
                    btnLogin.Enabled = true;
                    txtUsername.Focus();
                }
                else
                {
                    acc.level = AccountBUS.GetLevel(acc.username, acc.password);
                    MessageBox.Show("Login successful!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Management mana = new Management(acc);
                    Order od = new Order();
                    mana.Show();
                    od.Show();
                    Hide();
                }       
            }
            else
            {
                if(attempt!=0)
                {
                    if(MessageBox.Show("Login failed! Wrong password!\r\n" + --attempt + " left", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)==DialogResult.Retry)
                    {
                        txtPass.Clear();
                        txtPass.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Application close now!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void linkContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                    Application.OpenForms[i].Close();
            }
        }
    }
}
