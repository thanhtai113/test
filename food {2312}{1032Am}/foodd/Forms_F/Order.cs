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
using System.Text.RegularExpressions;

namespace foodd.Forms_F
{
    
    public partial class Order : Form
    {
        public static bool isDone = false;
        public Order()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;


            txtChangeQuan.Enabled = false;
            btnChangeQuan.Enabled = false;
            dataDishView.Focus();
        }

        private void btnDataGridRef_Click(object sender, EventArgs e)
        {
            foodSizeBindingSource.DataSource = Food_SizeBUS.GetAll();
            foodTypeBindingSource.DataSource = Food_TypeBUS.GetAll();
            combSizeFilter.DataSource = Food_SizeBUS.GetAll();
            combTypeFilter.DataSource = Food_TypeBUS.GetAll();
            foodDishBindingSource.DataSource = Food_DishBUS.dish_NotLocked();
            txtSearchName.Clear();

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

        private void btnOrder_Click(object sender, EventArgs e)
        {
            cusOrdersBindingSource.Add(new CusOrders());
            cusOrdersBindingSource.MoveLast();
            Food_Dish fd = foodDishBindingSource.Current as Food_Dish;            
            if (fd != null)
            {
                Regex pattern = new Regex(@"[0-9]");
                if (pattern.IsMatch(txtNumberD.Text))
                {
                    string dName = fd.name;
                    double dPrice = fd.price;
                    int quantity;
                    DateTime orderdate = DateTime.Now;
                    if ( int.TryParse(txtNumberD.Text,out quantity))
                    {
                        if (CusOrderBUS.check_DishExist(dName) == false)
                        {
                            if (fd.stock < quantity)
                            {
                                MessageBox.Show("Only " + fd.stock + "left!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtNumberD.Focus();
                            }
                            else
                            {
                                CusOrderBUS.insert(dName, dPrice, quantity, orderdate);
                                cusOrdersBindingSource.MoveLast();
                                cusOrdersBindingSource.DataSource = CusOrderBUS.GetAll();
                                labelCost.Text = CusOrderBUS.TotalCost().ToString() + "$";
                                txtNumberD.Clear();
                                Food_DishBUS.stockCalulate(fd.Id, quantity, true);
                                foodDishBindingSource.DataSource = Food_DishBUS.dish_NotLocked();
                            }
                        }
                        else
                        {
                            MessageBox.Show("This food is already in your list! Please chood another food.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dataDishView.Focus();
                            cusOrdersBindingSource.RemoveCurrent();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong number! Please type your number again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNumberD.Focus();
                        cusOrdersBindingSource.RemoveCurrent();
                    }
                }
                else
                {
                    if (MessageBox.Show("Please type the quantity of your dish!", "Missing your dish quantity!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Retry)
                    {
                        cusOrdersBindingSource.MoveLast();
                        txtNumberD.Focus();
                        txtNumberD.Select();
                        cusOrdersBindingSource.RemoveCurrent();
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Pleas choose your dish!", "Your order is empty!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Retry)
                {
                    txtNumberD.Clear();
                    dataDishView.Focus();
                    cusOrdersBindingSource.RemoveCurrent();
                }
            }

        }

        private void dataDishView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtChangeQuan.Enabled = false;
            btnChangeQuan.Enabled = false;
            txtNumberD.Enabled = true;
            btnOrder.Enabled = true;
            Food_Dish fdish = foodDishBindingSource.Current as Food_Dish;
            if (fdish.Id != 0)
            {
                int typeID = fdish.TypeId;
                int sizeID = fdish.SizeId;
                foodTypeBindingSource.DataSource = Food_TypeBUS.showType(typeID);
                foodSizeBindingSource.DataSource = Food_SizeBUS.showSize(sizeID);                
                //picBox.Image = Image.FromFile(fdish.imaGeURL);
                txtNumberD.Clear();
            }
            else
            {
                return;
            }
        }

        private void txtNumberD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CusOrders cusOrder = cusOrdersBindingSource.Current as CusOrders;
            CusOrders cusO = CusOrderBUS.GetByName(cusOrder.name);
            Food_Dish fd = Food_DishBUS.GetByName(cusO.name);
            if (cusOrder != null)
            {
                Food_DishBUS.stockCalulate(fd.Id, cusO.numberDish, false);
                CusOrderBUS.delete(cusOrder);
                cusOrdersBindingSource.RemoveCurrent();
                labelCost.Text = CusOrderBUS.TotalCost().ToString() + "$";
                foodDishBindingSource.DataSource = Food_DishBUS.dish_NotLocked();
            }
            else
            {
                if (MessageBox.Show("List is empty! Please choose your food.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    dataDishView.Focus();
                }
                return;
            }
        }       
        private void txtChangeQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dataCusOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CusOrders cusO = cusOrdersBindingSource.Current as CusOrders;
            txtNumberD.Enabled = false;
            btnOrder.Enabled = false;
            txtChangeQuan.Enabled = true;
            btnChangeQuan.Enabled = true;
        }
        private void btnChangeQuan_Click(object sender, EventArgs e)
        {
            CusOrders cusO = cusOrdersBindingSource.Current as CusOrders;
            Food_Dish fd = Food_DishBUS.GetByName(cusO.name);
            CusOrders cusOder = CusOrderBUS.GetByName(cusO.name);
            int tempDish=0;
            int changeQuan = int.Parse(txtChangeQuan.Text);
            if(changeQuan==0 ||txtChangeQuan.Text==" "|| txtChangeQuan.Text == "")
            {
                MessageBox.Show("Number of dish can not be 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChangeQuan.Clear();
                txtChangeQuan.Focus();
                foodDishBindingSource.DataSource = Food_DishBUS.dish_NotLocked();
                return;
            }
            else
            {
                if (cusO != null)
                {
                    if (changeQuan > fd.stock)
                    {
                        MessageBox.Show("Only " + fd.stock + "left!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cusOrdersBindingSource.DataSource = CusOrderBUS.GetAll();
                        return;
                    }
                    else
                    {
                        if (changeQuan > cusOder.numberDish)
                        {
                            tempDish = changeQuan - cusOder.numberDish;
                            CusOrderBUS.changeQuantity(cusO);
                            Food_DishBUS.stockCalulate(fd.Id, tempDish, true);
                            foodDishBindingSource.DataSource = Food_DishBUS.dish_NotLocked();
                            labelCost.Text = CusOrderBUS.TotalCost().ToString() + "$";

                        }
                        else
                        {
                            tempDish = cusOder.numberDish - changeQuan;
                            CusOrderBUS.changeQuantity(cusO);
                            Food_DishBUS.stockCalulate(fd.Id, tempDish, false);
                            foodDishBindingSource.DataSource = Food_DishBUS.dish_NotLocked();
                            labelCost.Text = CusOrderBUS.TotalCost().ToString() + "$";
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Order successful! Thank for buying food.","Thank you",MessageBoxButtons.OK,MessageBoxIcon.Information)==DialogResult.OK)
            {
                Close();
            }            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSearchName.Text))
            {
                return;
            }
            else
            {
                string fName = txtSearchName.Text;
                foodDishBindingSource.DataSource = Food_DishBUS.search(fName);
                txtSearchName.Clear();
                txtSearchName.Focus();
            }
        }
        private void btnCusO_Ref_Click(object sender, EventArgs e)
        {
            cusOrdersBindingSource.DataSource = CusOrderBUS.GetAll();
        }
    }
}
