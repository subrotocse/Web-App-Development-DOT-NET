using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice3SuperShopStore
{
    public partial class Form1 : Form
    {
       
        Shop aShop = new Shop();
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
          
            aShop.Name = nameTextBox.Text;
            aShop.Address = addressTextBox.Text;
            nameTextBox.Enabled=false;
            addressTextBox.Enabled = false;
        }
        private void addItemButton_Click(object sender, EventArgs e)
        {
            Product aProduct = new Product();
            aProduct.ProductId = itemIdTextBox.Text;
            aProduct.Quantity = Convert.ToInt32(quantityTextBox.Text);
            aShop.ProductList.Add(aProduct);
            itemIdTextBox.Clear();
            quantityTextBox.Clear();
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            string allProduct = "";
            string shop = "";
            foreach (Product aProduct in aShop.ProductList)
            {
                allProduct += aProduct.GetAllProductInformation();
               shop= aShop.GetShopFullInformation();
            }
            MessageBox.Show("Shop Name       "+"Address         "+"\n"+shop+"Product Item        "+"Quantity      "+"\n"+allProduct);
        }
    }
}
