using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Security.Permissions;
using System.Linq;
using System.Text;
using Model;
using BusinessLayer;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodd.UC_F
{
    public partial class Dish_UC : UserControl
    {
        public Dish_UC()
        {
            InitializeComponent();            
        }
        private void btnTypeRef_Click(object sender, EventArgs e)
        {
            foodTypeBindingSource.DataSource = Food_TypeBUS.GetAll();            
        }

        private void btnSizeRef_Click(object sender, EventArgs e)
        {
            foodSizeBindingSource.DataSource = Food_SizeBUS.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            comboSize.DataSource = Food_SizeBUS.GetAll();
            comboType.DataSource = Food_TypeBUS.GetAll();
            foodDishBindingSource.Add(new Food_Dish());
            foodDishBindingSource.MoveLast();
            dataGridDish.Enabled = false;
            panCRUD.Enabled = false;
            panFilter.Enabled = false;
            panSave.Enabled = true;
            panType_Size.Enabled = false;
        }
        private void Dish_UC_Load(object sender, EventArgs e)
        {
            panSave.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Food_Dish fdish = foodDishBindingSource.Current as Food_Dish;
            Food_Size fsize = foodSizeBindingSource.Current as Food_Size;
            Food_Type ftype = foodTypeBindingSource.Current as Food_Type;
            string sizeName = fsize.name;
            string typeName = ftype.nameType;
            string D_Name = txtD_Name.Text;
            double D_Price = double.Parse(txtD_Price.Text);
            string D_Descript = txtD_Description.Text;
            string D_ImageURL = fdish.imaGeURL;
            int D_Stock = int.Parse(txtStock.Text);
            int D_Id = fdish.Id;
            if(fdish==null)
            {
                MessageBox.Show("Nothing to edit!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foodDishBindingSource.DataSource = Food_DishBUS.GetAll();
                return;
            }
            else
            {
                if(string.IsNullOrEmpty(txtD_Name.Text)|| string.IsNullOrEmpty(txtD_Price.Text)|| string.IsNullOrEmpty(txtD_Description.Text))
                {
                    MessageBox.Show("Please type all the information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (fdish.Id == 0)
                    {
                        if (Food_DishBUS.chekName(txtD_Name.Text))
                        {
                            MessageBox.Show("This name is already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            txtD_Name.Clear();
                            txtD_Price.Clear();
                            txtD_Description.Clear();
                        }
                        else
                        {
                            Food_DishBUS.insert(D_Name,D_Price,D_Descript,D_ImageURL,typeName,sizeName,D_Stock);
                            MessageBox.Show("Insert successfully!", "Insert dish name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            foodDishBindingSource.DataSource = Food_DishBUS.GetAll();
                            foodDishBindingSource.MoveLast();
                            panCRUD.Enabled = true;
                            panFilter.Enabled = true;
                            panSave.Enabled = false;
                            dataGridDish.Enabled = true;
                        }

                    }
                    else
                    {
                        Food_DishBUS.edit(fdish, D_Name, D_Price, D_Descript, D_ImageURL, typeName, sizeName, D_Id, D_Stock);
                        MessageBox.Show("Update successfully!", "Update dish name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foodDishBindingSource.DataSource = Food_DishBUS.GetAll();
                        panCRUD.Enabled = true;
                        panSave.Enabled = false;
                        panFilter.Enabled = true;
                        dataGridDish.Enabled = true;
                    }
                }
            }       
        }
        private void btnDataGrid_Click(object sender, EventArgs e)
        {
            
            foodSizeBindingSource.DataSource = Food_SizeBUS.GetAll();
            foodTypeBindingSource.DataSource = Food_TypeBUS.GetAll();            
            combSizeFilter.DataSource = Food_SizeBUS.GetAll();
            combTypeFilter.DataSource = Food_TypeBUS.GetAll();
            foodDishBindingSource.DataSource = Food_DishBUS.GetAll();
        }

        private void txtD_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to delete this dish ?","Waring",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Food_Dish fdish = foodDishBindingSource.Current as Food_Dish;
                Food_DishBUS.delete(fdish);
                foodDishBindingSource.DataSource = Food_DishBUS.GetAll();
            }
            
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Food_Dish fdish = foodDishBindingSource.Current as Food_Dish;
            if (fdish.Id != 0)
            {
                int typeID = fdish.TypeId;
                int sizeID = fdish.SizeId;
                foodTypeBindingSource.DataSource = Food_TypeBUS.showType(typeID);
                foodSizeBindingSource.DataSource = Food_SizeBUS.showSize(sizeID);
                if(fdish.imaGeURL!=null)
                {
                    picBox.Image = Image.FromFile(fdish.imaGeURL);
                }
                else
                {
                    picBox.Image = null;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {            
            foodDishBindingSource.DataSource = Food_DishBUS.search(txtSearch.Text);
            txtSearch.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panCRUD.Enabled = true;
            panSave.Enabled = false;
            panFilter.Enabled = true;
            dataGridDish.Enabled = true;
            foodDishBindingSource.DataSource = Food_DishBUS.GetAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {            
            panCRUD.Enabled = false;
            panFilter.Enabled = false;
            panSave.Enabled = true;
            panType_Size.Enabled = false;
            dataGridDish.Enabled = false;
            foodSizeBindingSource.DataSource = Food_SizeBUS.GetAll();
            foodTypeBindingSource.DataSource = Food_TypeBUS.GetAll();
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "(*.jpg;*.jpeg;*.bmp;) | *.jpg;*.jpeg;*.bmp;" })
            {
                ofd.Multiselect = false;
                if(ofd.ShowDialog()==DialogResult.OK)
                {
                    picBox.Image = Image.FromFile(ofd.FileName);
                    Food_Dish fd = foodDishBindingSource.Current as Food_Dish;
                    if(fd != null)
                    {
                        fd.imaGeURL = ofd.FileName;
                    }                    
                }
            }
        }

        private void combTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int typId = int.Parse(combTypeFilter.SelectedValue.ToString());
            foodDishBindingSource.DataSource = Food_DishBUS.D_TypeFilter(typId);
        }

        private void combSizeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {            
            int sizId = int.Parse(combSizeFilter.SelectedValue.ToString());
            foodDishBindingSource.DataSource = Food_DishBUS.D_SizeFilter(sizId);            
        }
        private void btnLock_Unclock_Click(object sender, EventArgs e)
        {
            Food_Dish fd = foodDishBindingSource.Current as Food_Dish;
            if(fd==null)
            {
                return;
            }
            else
            {
                int id = fd.Id;
                Food_DishBUS.dishLock_Unlock(id);
                foodDishBindingSource.DataSource = Food_DishBUS.GetAll();
            }            
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
