using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopApp
{
    public partial class SuperShopUI : Form
    {
        private Shop aShop;
        private Product aProduct;

        public SuperShopUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aShop = new Shop();
            aShop.NAME = shopNameTextBox.Text;
            aShop.Address = shopAddressTextBox.Text;
            MessageBox.Show("Shop has been saved");
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            aProduct=new Product();
            aProduct.ProductId = productIdTextBox.Text;
            aProduct.Quantity = Convert.ToInt32(quantityTextBox.Text);
           MessageBox.Show( aShop.AddItem(aProduct.ProductId,aProduct.Quantity));

        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
           MessageBox.Show(aShop.ShowDetails(shopNameTextBox.Text,shopAddressTextBox.Text));
        }
    }
}
