using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using BusinessLayer;
using Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace foodd.UC_F
{
    public partial class Employee_Management_UC : UserControl
    {
        public Employee_Management_UC()
        {
            InitializeComponent();
            panSave.Enabled = false;
            txtPass.PasswordChar = '*';
            txtConPass.PasswordChar = '*';
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            comboPosRe.DataSource = PositionBUS.GetAll();
            accountsBindingSource.Add(new Accounts());
            accountsBindingSource.MoveLast();
            dataGridView.Enabled = false;
            panCRUD.Enabled = false;
            panSave.Enabled = true;
            txtConPass.Clear();
            txtUserName.Enabled = true;
            txtPass.Enabled = true;
            txtConPass.Enabled = true;
            panSearch.Enabled = false;
            comboPosFilter.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            comboPosRe.Visible = true;
            labelPos.Visible = true;
            Accounts acc = accountsBindingSource.Current as Accounts;
            string position = comboPosRe.SelectedValue.ToString();
            string imageURL = acc.imageURL;
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtF_Name.Text) || string.IsNullOrEmpty(txtL_Name.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please type all the informaton!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Regex pattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (!pattern.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("This mail is invalid! Please use another mail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Clear();
                    txtEmail.Focus();
                }
                else
                {
                    Regex patternPhone = new Regex(@"[0-9]{10}");
                    if(!patternPhone.IsMatch(txtPhone.Text))
                    {
                        MessageBox.Show("Wrong phone number! Please enter your phone again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPhone.Focus();
                    }
                    else
                    {
                        if (acc.Id == 0)
                        {
                            if (AccountBUS.checkUsername(txtUserName.Text) == true)
                            {
                                MessageBox.Show("This username is already used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtUserName.Focus();
                            }
                            else
                            {
                                if (txtPass.Text != txtConPass.Text)
                                {
                                    MessageBox.Show("Password does not match the confirm password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtConPass.Focus();
                                }
                                else
                                {
                                    AccountBUS.insert(txtUserName.Text, txtPass.Text, txtF_Name.Text, txtL_Name.Text, txtEmail.Text, txtPhone.Text, txtAddress.Text, position, imageURL);
                                    MessageBox.Show("Save successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    accountsBindingSource.DataSource = AccountBUS.GetAll();
                                    accountsBindingSource.MoveLast();
                                    panCRUD.Enabled = true;
                                    panSave.Enabled = false;
                                    panSearch.Enabled = true;
                                    comboPosFilter.Enabled = true;
                                    dataGridView.Enabled = true;
                                }
                            }

                        }
                        else
                        {
                            positionsBindingSource.DataSource = PositionBUS.GetAll();
                            int id = acc.Id;
                            AccountBUS.edit(acc, id, txtF_Name.Text, txtL_Name.Text, txtEmail.Text, txtPhone.Text, txtAddress.Text, position, imageURL);
                            MessageBox.Show("Save successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            accountsBindingSource.DataSource = AccountBUS.GetAll();                            
                            panCRUD.Enabled = true;
                            panSave.Enabled = false;
                            panSearch.Enabled = true;
                            dataGridView.Enabled = true;
                            comboPosFilter.Enabled = true;
                        }
                    }
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "(*.jpeg;*.bmg;*.jpg;*.png)|*.jpeg;*.bmg;*.jpg;*.png" })
            {
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picBox.Image = Image.FromFile(ofd.FileName);
                    Accounts acc = accountsBindingSource.Current as Accounts;
                    acc.imageURL = ofd.FileName;
                }
            }
        }

        private void btnAccRef_Click(object sender, EventArgs e)
        {
            accountsBindingSource.DataSource = AccountBUS.GetAll();
            positionsBindingSource.DataSource = PositionBUS.GetAll();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Accounts acc = accountsBindingSource.Current as Accounts;
            if(acc==null)
            {
                return;
            }
            else
            {
                if (acc.level == 1)
                {
                    comboPosRe.Visible = false;
                    labelPos.Visible = false;                    
                }
                comboPosFilter.Enabled = false;
                dataGridView.Enabled = false;
                panCRUD.Enabled = false;
                panSave.Enabled = true;
                txtUserName.Enabled = false;
                txtPass.Enabled = false;
                txtConPass.Enabled = false;
                panSearch.Enabled = false;
                comboPosRe.Enabled = true;
                comboPosRe.DataSource = PositionBUS.GetAll();
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Accounts acc = accountsBindingSource.Current as Accounts;
            if(acc==null)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this account?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    AccountBUS.delete(acc);
                    MessageBox.Show("Delete successfully!", "Result", MessageBoxButtons.OK);
                    accountsBindingSource.DataSource = AccountBUS.GetAll();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataGridView.Enabled = true;
            panCRUD.Enabled = true;
            panSave.Enabled = false;
            accountsBindingSource.DataSource = AccountBUS.GetAll();
            panSearch.Enabled = true;
            comboPosFilter.Enabled = true;
            comboPosRe.Visible = true;
            labelPos.Visible = true;
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Accounts acc = accountsBindingSource.Current as Accounts;
            txtConPass.Clear();
            if(acc.level==1)
            {
                btnLock_Unlock.Visible = false;
                btnDelete.Visible = false;
            }
            else
            {
                btnLock_Unlock.Visible = true;
                btnDelete.Visible = true;
            }
        }
        private void btnSearchFirst_Click(object sender, EventArgs e)
        {
            accountsBindingSource.DataSource = AccountBUS.searchFirstname(txtSearchFirst.Text);
            txtSearchFirst.Clear();
        }

        private void btnSearchLast_Click(object sender, EventArgs e)
        {
            accountsBindingSource.DataSource = AccountBUS.searchLastname(txtSearchLast.Text);
            txtSearchLast.Clear();
        }

        private void comboPosFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string posi = comboPosFilter.Text;
            accountsBindingSource.DataSource = AccountBUS.positionFilter(posi);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            positionsBindingSource.DataSource = PositionBUS.GetAll();
        }

        private void btnLock_Unlock_Click(object sender, EventArgs e)
        {
            Accounts acc = accountsBindingSource.Current as Accounts;
            int id = acc.Id;
            AccountBUS.lock_unlockUser(id);
            accountsBindingSource.DataSource = AccountBUS.GetAll();
        }
    }
}
