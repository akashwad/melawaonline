using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BusinessLayer;

namespace MelawaOnline.Controllers
{
    [RoutePrefix("Profile")]
    public class ProfileController : ApiController
    {
        [Route("Create")]
        [HttpPost]
        public string CreateProfile([FromBody]UserInfo userInfo)
        {
            Profile prof = new Profile();
            string phoneNumber = prof.CreateProfile(userInfo);
           
            return "";
        }

        [Route("Update")]
        [HttpPost]
        public string UpdateProfile([FromBody]UserInfo userInfo)
        {
            Profile prof = new Profile();
            UserInfo userInforeturn = prof.UpdateProfile(userInfo);

            return "";

            //Convert check to json string and send back
            
        }

        [Route("Delete")]
        [HttpPost]
        public string DeleteProfile([FromBody]UserInfo userInfo)
        {
            Profile prof = new Profile();
            bool check = prof.DeleteProfile(userInfo);

            return "";
        }

        [Route("View")]
        [HttpPost]
        public string ViewProfile([FromBody]string phonenumber)
        {
            Profile prof = new Profile();
            UserInfo userInfo = prof.ViewProfile(phonenumber);

            return "";
        }

        [Route("Detail")]
        [HttpPost]
        public UserInfo DetailProfile([FromBody]string phonenumber)
        {
            Profile prof = new Profile();
            UserInfo userInfo = prof.DetailProfile(phonenumber);

            return userInfo;
        }
    }
}