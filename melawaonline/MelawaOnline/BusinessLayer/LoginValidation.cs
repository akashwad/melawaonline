using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class LoginValidation
    {
        
        private string userID=null;
        private string password = null;
         

      
        public bool ValidateAuthentication(LoginValidation login)
        {
            //DAO layer method call
            DataAccess dal = new DataAccess();
            return dal.ValidateLogin(login.userID, login.password);
            
        }
    }
}
