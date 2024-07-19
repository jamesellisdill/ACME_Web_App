using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME_Web_App
{
    public class OrderManager
    {
        private List<Order> orders;

        public OrderManager()
        {
            orders = new List<Order>();
        }

        public Order CreateNewOrder()
        {
            Order newOrder = new Order();
            orders.Add(newOrder);
            return newOrder;
        }

        public void AddToOrder(Order order, Product product)
        {
            order.AddToOrder(product);
        }

        public void RemoveFromOrder(Order order, Product product)
        {
            order.RemoveFromOrder(product);
        }

        public string PlaceOrder(Order order)
        {
            return order.GetOrderID();
        }
    }
}