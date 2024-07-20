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
    public class CustomersDatabase
    {
        public static List<Customer> customers;

        public CustomersDatabase() 
        {
            customers = new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void RemoveCustomer(Customer customer)
        {
            customers.Remove(customer);
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }

        public void LoadCustomers()
        {
            #region list of products 
            customers.Add(new Customer("Crafty Brews Co.", "123 Brew St, Beer Town", true, "4"));
            customers.Add(new Customer("Golden Ale Brewery", "456 Ale Ave, Hop City", false, "1"));
            customers.Add(new Customer("Hoppy Times LLC", "789 Hop Blvd, Malt City", true, "2"));
            customers.Add(new Customer("Foamy Froth Inc.", "101 Foam Rd, Lager Town", true, "7"));
            customers.Add(new Customer("Brewtopia", "202 Brew Lane, Yeastville", false, "21"));
            customers.Add(new Customer("Yeast Feast Brewery", "303 Yeast Way, Hoptown", true, "13"));
            #endregion
        }

        //public static string DisplayCustomerInfo(Customer customer)
        //{
        //    return $"Name: {customer.Name}\tAddress: {customer.Address}\tIs capable of loading? {(customer.IsCapableOfLoading ? "Yes" : "No")}\tDelivery Hours: {customer.DeliveryHours}";
        //}

        //public static string DisplayAllCustomers()
        //{
        //    string list = "";
        //    foreach (Customer customer in customers)
        //    {
        //        list += DisplayCustomerInfo(customer);
        //        list += "\n";
        //    }
        //    return list;
        //}
    }
}