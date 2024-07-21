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
        public static OrderManager orderManager = new OrderManager();
        public static User salesmanUser = new Salesman("salesman", "ACME", false, true);    // salesman
        public static User adminUser = new Admin("admin", "ACME", true, true);              // admin
        public static User inactiveUser = new Salesman("salesman2", "ACME", false, false);  // deactivated account

        public static List<User> users = new List<User> {salesmanUser, adminUser, inactiveUser};

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

            Application.Run(new ViewModifyCustomerForm()); //Change this to pick which form appears first.
        }
    }
}
