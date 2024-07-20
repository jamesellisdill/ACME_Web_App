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
    public partial class Form2 : Form
    {
        private string authenticatorCode = "123456";

        public Form2()
        {
            InitializeComponent();
        }

        // BACK ARROW
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }

        // AUTHENTICATE BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            string enteredCode = textBox1.Text;

            if (String.Equals(authenticatorCode, enteredCode))
            {
                this.Hide();
                PortalScreen form3 = new PortalScreen();
                form3.Show();
            }
            else
            {
                // SHOW THE ERROR MESSAGE
            }
        }
    }
}
