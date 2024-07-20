using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME_Web_App
{
    public static class Program
    {
        public static CustomersDatabase customersDatabase = new CustomersDatabase();
        public static Inventory inventory = new Inventory();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // MAKE INSTANCES BEFORE RUNNING FIRST FORM
            inventory.LoadProducts();
            customersDatabase.LoadCustomers();

            Application.Run(new Form1()); //Change this to pick which form appears first.
        }
    }
}
