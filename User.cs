using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ACME_App
{
    public abstract class User
    {
        // VARS
        public string username { get; private set; }
        public string password { get; private set; }

        public bool isAdmin { get; private set; }
        public bool accountActive { get; private set; } 

        // CONSTRUCTOR
        public User(string username, string password, bool isAdmin, bool accountActive)
        {
            this.username = username;
            this.password = password;
            this.isAdmin = isAdmin;
            this.accountActive = accountActive;
        }

        // ENSURES ACCOUNT IS ACTIVE
        public abstract bool CanLogin();

        // CHECKS LEVEL OF ACCESS
        public abstract bool IsAdmin();

        // CHECKS IF PASSWORD MATCHES
        public abstract bool LoginCredentialsCheck(string username, string password);
    }
}
