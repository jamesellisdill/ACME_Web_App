using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME_Web_App
{
    public class Order
    {
        private List<Product> order;
        private static int orderIDCounter = 6000000;
        private int orderID;

        public Order()
        {
            orderID = orderIDCounter++;
            order = new List<Product>();
        }

        public void AddToOrder(Product product)
        {
            order.Add(product);
        }

        public void RemoveFromOrder(Product product)
        {
            order.Remove(product);
        }

        public string DisplayOrderProducts()
        {
            string orderProductList = "";
            foreach (Product product in order)
            {
                orderProductList += product.ViewProductInfo() + "\n";
            }
            return orderProductList;
        }

        public List<Product> GetOrderProducts()
        {
            return order;
        }

        public string GetOrderID()
        {
            return orderID.ToString();
        }
    }
}