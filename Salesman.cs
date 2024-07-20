using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME_Web_App
{
    public class Salesman : User
    {
        // CONSTRUCTOR
        public Salesman (string username, string password, bool isAdmin, bool accountActive)
            : base( username, password, false, accountActive)
        {
            // USES PARENT VARS
        }

        public override bool CanLogin()
        {
            return accountActive;
        }

        public override bool IsAdmin()
        {
            return isAdmin;
        }

        public override bool LoginCredentialsCheck(string username, string password)
        {

            return string.Equals(this.username, username) && string.Equals(this.password, password);
        }
    }
}
