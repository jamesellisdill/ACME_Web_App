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
    internal class CustomerManager
    {
        ArrayList customers = new ArrayList();

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine(DisplayCustomerInfo(customer));
        }

        public string DisplayCustomerInfo(Customer customer)
        {
            return $"Name: {customer.Name}\tAddress: {customer.address}\tIs capable of loading? {(customer.isCapableOfLoading ? "Yes" : "No")}\tDelivery Hours: {customer.deliveryHours}";
        }

        public string DisplayAllCustomers()
        {
            foreach (Customer customer in customers)
            {
                return DisplayCustomerInfo(customer);
            }
            return "\n";
        }
    }
}
