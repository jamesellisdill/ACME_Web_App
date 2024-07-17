using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME_Web_App
{
    internal class Customers
    {
        private string name {  get; set; }
        private string address { get; set; }
        private bool isCapableOfLoading { get; set; }
        private string deliveryHours { get; set; }

        public Customers(string name, string address, bool isCapableOfLoading, string deliveryHours)
        {
            this.name = name;
            this.address = address;
            this.isCapableOfLoading = isCapableOfLoading;
            this.deliveryHours = deliveryHours;
        }
    }
}
