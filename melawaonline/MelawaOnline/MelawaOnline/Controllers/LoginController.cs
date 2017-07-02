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
        public IEnumerable<string> SignInUser([FromBody]Login login)
        {
            return new string[] { "signinuser", "value2" };
        }

        // POST api/login
        [Route("SignUpUser")]
        [HttpPost]
        public IEnumerable<string> SignUpUser([FromBody]Login login)
        {
            return new string[] { "SignUpUser", "value2" };
        }
    }
}
