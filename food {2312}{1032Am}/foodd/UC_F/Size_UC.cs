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
    public partial class Size_UC : UserControl
    {
        public Size_UC()
        {
            InitializeComponent();            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foodSizeBindingSource.Add(new Food_Size());
            foodSizeBindingSource.MoveLast();
            panCRUD.Enabled = false;
            panSave.Enabled = true;
            txtSizeName.Clear();
            txtSizeName.Focus();
        }

        private void Size_UC_Load(object sender, EventArgs e)
        {
            panSave.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panSave.Enabled = true;
            panCRUD.Enabled = false;
            txtSizeName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Food_Size obj = foodSizeBindingSource.Current as Food_Size;
                if (MessageBox.Show("Are you sure want to delete this name ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Food_SizeBUS.delete(obj);
                    MessageBox.Show("Delete successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foodSizeBindingSource.RemoveCurrent();                   
                }                
            }
            catch
            {
                MessageBox.Show("Can not delete this name!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSizeName.Text))
            {
                MessageBox.Show("Name field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSizeName.Focus();
            }
            else
            {
                Food_Size obj = foodSizeBindingSource.Current as Food_Size;
                if(obj.Id==0)
                {
                    if (Food_SizeBUS.checkName(txtSizeName.Text))
                    {
                        MessageBox.Show("This name is already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSizeName.Focus();
                    }
                    else
                    {
                        Food_SizeBUS.insert(obj);
                        foodSizeBindingSource.DataSource = Food_SizeBUS.GetAll();
                        foodSizeBindingSource.MoveLast();
                        MessageBox.Show("Add successfully!","Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panCRUD.Enabled = true;
                        panSave.Enabled = false;
                    }
                }
                else
                {
                    Food_SizeBUS.edit(obj);
                    MessageBox.Show("Update successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panCRUD.Enabled = true;
                    panSave.Enabled = false;
                }
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
                panSave.Enabled = false;
                panCRUD.Enabled = true;
                foodSizeBindingSource.DataSource = Food_SizeBUS.GetAll();
        }

        private void dataGird_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Food_Size obj = foodSizeBindingSource.Current as Food_Size;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Search field is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foodSizeBindingSource.DataSource = Food_SizeBUS.search(txtSearch.Text);
                Food_Size fsi = foodSizeBindingSource.Current as Food_Size;
                
            }
            txtSearch.Clear();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            foodSizeBindingSource.DataSource = Food_SizeBUS.GetAll();
        }
    }
}
