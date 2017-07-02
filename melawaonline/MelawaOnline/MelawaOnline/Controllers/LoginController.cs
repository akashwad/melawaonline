using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer;

namespace MelawaOnline.Controllers
{
    [RoutePrefix("Login")]
    public class LoginController : ApiController
    {

        // POST api/login
        [Route("SignInUser")]
        [HttpPost]
        public IEnumerable<string> SignInUser([FromBody]LoginValidation login)
        {
            bool check=login.ValidateAuthentication();
            if(check)
            { 
            return new string[] {"Valid User" };
            }
            return new string[] { "Invalid User" };
        }

        // POST api/login
        [Route("SignUpUser")]
        [HttpPost]
        public IEnumerable<string> SignUpUser([FromBody]UserSignUp userSignUp)
        {
            bool check = userSignUp.AddUser();
            if (check)
            {
                return new string[] { "User Added Successfully!!!" };
            }
            return new string[] { "Failed UserSignUp!!!" };
            
        }
    }
}
