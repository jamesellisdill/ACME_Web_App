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
        Inventory inventory = new Inventory();
        OrderManager orderManager = new OrderManager();

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
            inventory.LoadProducts();

            foreach (Product product in inventory.GetProducts())
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
            Order activeOrder = orderManager.CreateNewOrder();
            orderManager.AddToOrdersList(activeOrder);
            List<string> orderItems = new List<string>();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                Console.WriteLine(item.Text);
                orderItems.Add(item.Text);
            }

            foreach (Product product in inventory.GetProducts())
            {
                foreach (string id in orderItems)
                {
                    if (product.Id == id) { orderManager.AddToOrder(activeOrder, product); break; }
                }
            }
        }
    }
}
