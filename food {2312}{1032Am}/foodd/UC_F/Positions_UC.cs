using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using BusinessLayer;
using Model;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodd.UC_F
{
    public partial class Positions_UC : UserControl
    {
        public Positions_UC()
        {
            InitializeComponent();
            panSave.Enabled = false;
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Search field is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else
            {
                positionsBindingSource.DataSource = PositionBUS.search(txtSearch.Text);
                Positions pos = positionsBindingSource.Current as Positions;
                txtSearch.Clear();
            }            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Positions pos = positionsBindingSource.Current as Positions;
            if(string.IsNullOrEmpty(txtPosName.Text))
            {
                MessageBox.Show("Name field is empty!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPosName.Focus();
            }
            else
            {
                if(pos.Id==0)
                {
                    if(PositionBUS.checkName(txtPosName.Text)==true)
                    {
                        MessageBox.Show("This name is already used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPosName.Clear();
                        txtPosName.Focus();
                    }
                    else
                    {
                        PositionBUS.insert(pos);
                        positionsBindingSource.MoveLast();
                        MessageBox.Show("Add successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panCRUD.Enabled = true;
                        panSave.Enabled = false;
                    }
                }
                else
                {
                    PositionBUS.edit(pos);
                    MessageBox.Show("Update successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panSave.Enabled = false;
                    panCRUD.Enabled = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Positions pos = positionsBindingSource.Current as Positions;
            if(pos.Id!=0)
            {
                panCRUD.Enabled = true;
                panSave.Enabled = false;
                positionsBindingSource.DataSource = PositionBUS.GetAll();
            }
            else
            {
                panCRUD.Enabled = true;
                panSave.Enabled = false;
                positionsBindingSource.RemoveCurrent();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            positionsBindingSource.Add(new Positions());            
            positionsBindingSource.MoveLast();
            panCRUD.Enabled = false;
            panSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {            
            txtPosName.Focus();           
            panCRUD.Enabled = false;
            panSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to delete this name?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Positions pos = positionsBindingSource.Current as Positions;
                PositionBUS.delete(pos);
                positionsBindingSource.RemoveCurrent();
            }
            
        }


        private void dataGirdPos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Positions pos = positionsBindingSource.Current as Positions;
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            positionsBindingSource.DataSource = PositionBUS.GetAll();
        }
    }
}
