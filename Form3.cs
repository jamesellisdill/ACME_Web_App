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
    public partial class PortalScreen : Form
    {
        public PortalScreen()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderPortal orderPortal = new OrderPortal();
            orderPortal.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerPortal customerPortal = new CustomerPortal();
            customerPortal.Show();
        }

        private void PortalScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
