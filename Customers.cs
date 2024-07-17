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
        private bool isCapableOfLoading = false;
        private int lowerBoundDeliveryHours { get; set; }
        private int upperBoundDeliveryHours { get; set; }

        public Customers(string name, string address, bool isCapableOfLoading, int lowerBoundDeliveryHours, int upperBoundDeliveryHours)
        {
            this.name = name;
            this.address = address;
            this.isCapableOfLoading = isCapableOfLoading;
            this.lowerBoundDeliveryHours = lowerBoundDeliveryHours;
            this.upperBoundDeliveryHours = upperBoundDeliveryHours;
        }

        public bool IsCapableOfLoading { get { return isCapableOfLoading; } set { isCapableOfLoading = value; } }
    }
}
