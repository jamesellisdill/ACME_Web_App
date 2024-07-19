using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME_Web_App
{
    public partial class NewOrderForm : Form
    {
        public NewOrderForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.CheckBoxes = true;
            listView1.FullRowSelect = true;
        }

        private void loadProductsButton_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.LoadProducts();

            foreach (Product product in Inventory.products)
            {
                ListViewItem productDetails = new ListViewItem(product.Id);
                productDetails.SubItems.Add(product.Description);
                productDetails.SubItems.Add(product.Supplier);
                productDetails.SubItems.Add(product.Brand);
                productDetails.SubItems.Add($"{(product.Availability ? "Active" : "Restricted")}");
                listView1.Items.Add(productDetails);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderManager orderManager = new OrderManager();
            Order order = orderManager.CreateNewOrder();

            ListView.SelectedListViewItemCollection selectedProducts = listView1.SelectedItems;
            foreach (Product product in selectedProducts)
            {
                orderManager.AddToOrder(order, product);
                Console.WriteLine(product.Description);
            }
        }
    }
}
