using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using Model;
using BusinessLayer;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodd.UC_F
{
    public partial class Type_UC : UserControl
    {
        public Type_UC()
        {
            InitializeComponent();            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foodTypeBindingSource.Add(new Food_Type());
            foodTypeBindingSource.MoveLast();
            panCRUD.Enabled = false;
            panSave.Enabled = true;
            txtTypeName.Clear();
            txtTypeName.Focus();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            panSave.Enabled = true;
            panCRUD.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Food_Type ftyp = foodTypeBindingSource.Current as Food_Type;
                if (MessageBox.Show("Are you sure want to delete this name ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Food_TypeBUS.delete(ftyp);
                    MessageBox.Show("Delete successful!", "Result", MessageBoxButtons.OK);
                    foodTypeBindingSource.RemoveCurrent();
                }
            }
            catch
            {
                MessageBox.Show("Can not delete this name!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Food_Type ftyp = foodTypeBindingSource.Current as Food_Type;
            if(string.IsNullOrEmpty(txtTypeName.Text))
            {
                MessageBox.Show("Name field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(ftyp.Id==0)
                {
                    if(Food_TypeBUS.checkFoodType(txtTypeName.Text))
                    {
                        MessageBox.Show("This name is already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTypeName.Clear();
                        txtTypeName.Focus();
                    }
                    else
                    {
                        Food_TypeBUS.Insert(ftyp);                       
                        foodTypeBindingSource.MoveLast();
                        MessageBox.Show("Add successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panCRUD.Enabled = true;
                        panSave.Enabled = false;
                    }                    
                }
                else
                {
                    Food_TypeBUS.update(ftyp);
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
                foodTypeBindingSource.DataSource = Food_TypeBUS.GetAll();            
        }

        private void Type_UC_Load(object sender, EventArgs e)
        {
            panSave.Enabled = false;
        }

        private void dataGird_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Food_Type ftyp = foodTypeBindingSource.Current as Food_Type;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Search field is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foodTypeBindingSource.DataSource = Food_TypeBUS.search(txtSearch.Text);
                Food_Type ftyp = foodTypeBindingSource.Current as Food_Type;
                txtSearch.Clear();
            }
            
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            foodTypeBindingSource.DataSource = Food_TypeBUS.GetAll();
        }
    }
}
