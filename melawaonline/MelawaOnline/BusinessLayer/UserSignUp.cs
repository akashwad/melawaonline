using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserSignUp
    {
        private string userID = null;
        private string password = null;
        private string confirmPassword = null;

        public UserSignUp(string userID, string password, string confirmPassword)
        {
            this.UserID = userID;
            this.Password = password;
            this.ConfirmPassword = confirmPassword;
        }

        public string UserID { get => userID; set => userID = value; }
        public string Password { get => password; set => password = value; }
        public string ConfirmPassword { get => confirmPassword; set => confirmPassword = value; }
        public bool AddUser()
        {
            //DAO layer method call
            return true;
        }
    }
}
