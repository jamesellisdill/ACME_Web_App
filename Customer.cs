using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME_Web_App
{
    internal class Customer
    {
        private string name {  get; set; }
        private string address { get; set; }
        private bool isCapableOfLoading { get; set; }
        private string deliveryHours { get; set; }

        public ArrayList customers = new ArrayList();

        public Customer(string name, string address, bool isCapableOfLoading, string deliveryHours)
        {
            this.name = name;
            this.address = address;
            this.isCapableOfLoading = isCapableOfLoading;
            this.deliveryHours = deliveryHours;
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public string DisplayCustomerInfo(Customer customer)
        {
            return $"Name: {name}\nAddress: {address}\nIs capable of loading? {(isCapableOfLoading ? "Yes" : "No")}\nDelivery Hours: {deliveryHours}";
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
