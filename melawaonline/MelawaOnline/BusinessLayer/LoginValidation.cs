using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LoginValidation
    {
        private string userID=null;
        private string password = null;
         

        public LoginValidation(string userID, string password)
        {
            this.UserID = userID;
            this.Password = password;            
        }

        public string UserID { get => userID; set => userID = value; }
        public string Password { get => password; set => password = value; }
         
        public bool ValidateAuthentication()
        {
            //DAO layer method call
            return true;
        }
    }
}
