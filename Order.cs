using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME_Web_App
{
    public class Order
    {
        // ATTRIBUTES
        private List<ListViewItem> order;
        private static int orderIDCounter = 6000000;
        private int orderID;

        // CONSTRUCTOR
        public Order()
        {
            orderID = orderIDCounter++;
            order = new List<ListViewItem>();
        }

        // ADD PRODUCT TO ORDER
        public void AddToOrder(ListViewItem item)
        {
            order.Add(item);
        }

        // REMOVE PRODUCT FROM ORDER
        public void RemoveFromOrder(Product product)
        {
            //order.Remove(product);
        }

        // SHOW A STRING OF ALL PRODUCTS IN THE ORDER CONCATENATED
/*        public string DisplayOrderProducts()
        {
            string orderProductList = "";
            foreach (Product product in order)
            {
                orderProductList += product.ViewProductInfo() + "\n";
            }
            return orderProductList;
        }*/

        // RETURNS THE ACTUAL PRODUCT OBJECTS IN THE ORDER
/*        public List<Product> GetOrderProducts()
        {
            return order;
        }*/

        // GETS ORDER ID
        public string GetOrderID()
        {
            return orderID.ToString();
        }
    }
}
