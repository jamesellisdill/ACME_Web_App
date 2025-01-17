using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME_Web_App
{
    public class Customer
    {
        // VARS
        private string name;
        private string address;
        private bool isCapableOfLoading;
        private string deliveryHours;

        // CONSTRUCTOR
        public Customer(string name, string address, bool isCapableOfLoading, string deliveryHours)
        {
            this.name = name;
            this.address = address;
            this.isCapableOfLoading = isCapableOfLoading;
            this.deliveryHours = deliveryHours;
        }

        // GETTERS AND SETTERS
        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public bool IsCapableOfLoading { get { return isCapableOfLoading; } set { isCapableOfLoading = value; } }
        public string DeliveryHours { get { return deliveryHours; } set { deliveryHours = value; } }
    }
}
