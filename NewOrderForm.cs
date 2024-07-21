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

        // LIST VIEW FORMATTING
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.CheckBoxes = true;
            listView1.FullRowSelect = true;
        }


        private void LoadProductsToListView()
        {
            // Hides the confirmation labels.
            label1.Hide();
            label2.Hide();

            //Loads the products.
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

        // CREATE ORDER
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count == 0)
            {
                label1.Text = "Must select items to order!";
                label1.Show();
            }
            else
            {
                Order order = Program.orderManager.CreateNewOrder();
                Program.orderManager.AddToOrdersList(order);

                foreach (ListViewItem item in listView1.CheckedItems)
                {
                    Product product = item.Tag as Product;
                    order.AddToOrder(product);

                    //TESTING
                    //Console.WriteLine($"Added to order: {product.ViewProductInfo()}");
                }

                Program.orderManager.PlaceOrder(order);

                string orderID = order.GetOrderID();
                label2.Text = orderID;

                // Shows the confirmation labels.
                label1.Text = "Order placed! Here's your confirmation number:";
                label1.Show();
                label2.Show();
            }

            foreach (ListViewItem item in listView1.CheckedItems)
            {
                if (item.Checked == true) item.Checked = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // ORDER PORTAL
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           OrderPortal Orderportal = new OrderPortal();
            Orderportal.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PortalScreen portalScreen = new PortalScreen();
            portalScreen.Show();
        }
    }
}
