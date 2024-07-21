using ACME_Web_App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ACME_Web_App

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Login fields.
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            foreach (User user in Program.users) 
            {
                if (user.LoginCredentialsCheck(username, password) && user.accountActive)
                {
                    this.Hide();
                    var form2 = new Form2();
                    form2.Show();
                    return;
                }
            }

            // UNABLE TO LOGIN. 
            // QUEUE THE LOADING OF ERROR UI SCENE.
            Console.WriteLine("UNABLE TO LOGIN ERROR");
        }
    }
}
