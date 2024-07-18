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
        private string name;
        public string address;
        public bool isCapableOfLoading;
        public string deliveryHours;

        public Customer(string name, string address, bool isCapableOfLoading, string deliveryHours)
        {
            this.name = name;
            this.address = address;
            this.isCapableOfLoading = isCapableOfLoading;
            this.deliveryHours = deliveryHours;
        }

        public string Name { get { return name; } }
    }
}
