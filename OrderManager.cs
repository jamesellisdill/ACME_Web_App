using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME_Web_App
{
    public class OrderManager
    {
        // CREATED LIST OF ORDERS
        private List<Order> orders;

        // CONSTRUCTOR
        public OrderManager()
        {
            orders = new List<Order>();
        }

        // CREATES A NEW ORDER AND ADDS IT TO 'orders' LIST
        public Order CreateNewOrder()
        {
            Order newOrder = new Order();
            orders.Add(newOrder);
            return newOrder;
        }

        // EDITS THE ORDER PASSED IN BY ADDING IN THE PRODUCT PASSED IN. IT USES THE OBJECTS ADD METHOD TO ADD.
        public void AddToOrder(Order order, Product product)
        {
            order.AddToOrder(product);
        }

        // EDITS THE ORDER PASSED IN BY REMOVING IN THE PRODUCT PASSED IN. IT USES THE OBJECTS REMOVE METHOD TO REMOVE.
        public void RemoveFromOrder(Order order, Product product)
        {
            order.RemoveFromOrder(product);
        }

        // CURRENTLY IT JUST RETURNS THE ORDER ID TO USE AS A CONFIRMATION NUMBER. THIS MAY BE EXPANDED ON LATER AS WE IMPLEMENT THE SOLUTION.
        public string PlaceOrder(Order order)
        {
            Console.WriteLine(order.GetOrderID());
            return order.GetOrderID();
        }

        public void AddToOrdersList(Order order)
        {
            orders.Add(order);
        }
    }
}
