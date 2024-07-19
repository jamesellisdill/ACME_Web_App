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

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewOrderForm newOrderForm = new NewOrderForm();
            newOrderForm.Show();
        }
    }
}
