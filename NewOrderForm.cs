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
            LoadProductsToListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.CheckBoxes = true;
            listView1.FullRowSelect = true;
        }


        private void LoadProductsToListView()
        {
            label1.Hide();
            label2.Hide();

            foreach (Product product in Program.inventory.GetProducts())
            {
                ListViewItem productDetails = new ListViewItem(product.Id);
                productDetails.SubItems.Add(product.Description);
                productDetails.SubItems.Add(product.Supplier);
                productDetails.SubItems.Add(product.Brand);
                productDetails.SubItems.Add($"{(product.Availability ? "Active" : "Restricted")}");
                productDetails.Tag = product;
                listView1.Items.Add(productDetails);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order order = Program.orderManager.CreateNewOrder();
            Program.orderManager.AddToOrdersList(order);

            foreach (ListViewItem item in listView1.CheckedItems)
            {
                Product product = item.Tag as Product;
                order.AddToOrder(product);

                //TESTING
                Console.WriteLine($"Added to order: {product.ViewProductInfo()}");
            }

            string orderID = order.GetOrderID();
            label2.Text = orderID;

            label1.Show();
            label2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           OrderPortal Orderportal = new OrderPortal();
            Orderportal.Show();
        }
    }
}
