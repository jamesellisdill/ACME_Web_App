using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ACME_Web_App
{
    public class CustomerManager
    {
        public static List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public static string DisplayCustomerInfo(Customer customer)
        {
            return $"Name: {customer.Name}\t\tAddress: {customer.Address}\t\tIs capable of loading? {(customer.IsCapableOfLoading ? "Yes" : "No")}\t\tDelivery Hours: {customer.DeliveryHours}";
        }

        /*public static string DisplayAllCustomers()
        {
            string list = "";
            foreach (Customer customer in customers)
            {
                list += DisplayCustomerInfo(customer);
                list += "\r\n";
            }
            return list;
        }*/
    }
}