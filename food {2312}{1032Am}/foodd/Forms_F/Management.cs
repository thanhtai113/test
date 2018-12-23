using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using BusinessLayer;
using Model;
using System.Linq;
using foodd.UC_F;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodd.Forms_F
{
    public partial class Management : Form
    {

        public Management()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            
        }
        Accounts acc= new Accounts();
        public Management(Accounts accLog): this()
        {
            acc.level = accLog.level;
            acc.username = accLog.username;
                       
        }
        private void Management_Load(object sender, EventArgs e)
        {
            laName.Text = acc.username;            
            string name = laName.Text;        
            if (AccountBUS.checklevel(acc))
            {
                btnAccMain.Visible = true;
                btnPositionMain.Visible = true;
                
            }
            else
            {
                btnAccMain.Visible = false;
                btnPositionMain.Visible = false;
            }
        }

        private void btnTypeMain_Click(object sender, EventArgs e)
        {
            panSide.Top = btnTypeMain.Top;
            panSide.Height = btnTypeMain.Height;
            

        }

        private void btnSizeMain_Click(object sender, EventArgs e)
        {
            panSide.Top = btnSizeMain.Top;
            panSide.Height = btnSizeMain.Height;
            
        }

        private void btnDishMain_Click(object sender, EventArgs e)
        {
            panSide.Top = btnDishMain.Top;
            panSide.Height = btnDishMain.Height;
            
        }

        private void btnPositionMain_Click(object sender, EventArgs e)
        {
            panSide.Top = btnPositionMain.Top;
            panSide.Height = btnPositionMain.Height;
            
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            panSide.Top = btnAccMain.Top;
            panSide.Height = btnAccMain.Height;
            
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Logout ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Hide();
                Login log = new Login();
                log.Show();
                List<Form> openForm = new List<Form>();
                foreach(Form f in Application.OpenForms)
                {
                    openForm.Add(f);                    
                }
                foreach (Form f in openForm)
                {
                    if (f.Name == "Order")
                        f.Close();
                }
            }
        }

        private void linkChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePass chan = new ChangePass(acc);
            chan.ShowDialog();
        }

        private void btnOrderMain_Click(object sender, EventArgs e)
        {
            panSide.Top = btnOrderMain.Top;
            panSide.Height = btnOrderMain.Height;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(acc.level);
        }
    }
}
