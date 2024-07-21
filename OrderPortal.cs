using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME_Web_App
{
    public partial class OrderPortal : Form
    {
        public OrderPortal()
        {
            InitializeComponent();
        }

        // NEW ORDER FORM BUTTON
        private void newOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewOrderForm newOrderForm = new NewOrderForm();
            newOrderForm.Show();
        }

        // BACK ARROW
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PortalScreen portalScreen = new PortalScreen();
            portalScreen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PortalScreen portalScreen = new PortalScreen();
            portalScreen.Show();
        }
    }
}
