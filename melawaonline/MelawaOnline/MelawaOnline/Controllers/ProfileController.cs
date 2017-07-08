using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BusinessLayer;
using Common;

namespace MelawaOnline.Controllers
{
    [RoutePrefix("Profile")]
    public class ProfileController : ApiController
    {
        [Route("Create")]
        [HttpPost]
        public string CreateProfile([FromBody]UserInfoDOJO userInfo)
        {
            Profile prof = new Profile();
            string phoneNumber = prof.CreateProfile(userInfo);
           // code to convert output into JSON
            return "";
        }

        [Route("Update")]
        [HttpPost]
        public string UpdateProfile([FromBody]UserInfoDOJO userInfo)
        {
            Profile prof = new Profile();
            UserInfoDOJO userInforeturn = prof.UpdateProfile(userInfo);
            // code to convert output into JSON
            return "";

            //Convert check to json string and send back
            
        }

        [Route("Delete")]
        [HttpPost]
        public string DeleteProfile([FromBody]UserInfoDOJO userInfo)
        {
            Profile prof = new Profile();
            bool check = prof.DeleteProfile(userInfo);
            // code to convert output into JSON
            return "";
        }

        [Route("View")]
        [HttpPost]
        public string ViewProfile([FromBody]string phonenumber)
        {
            Profile prof = new Profile();
            UserInfoDOJO userInfo = prof.ViewProfile(phonenumber);
            // code to convert output into JSON
            return "";
        }

        [Route("Detail")]
        [HttpPost]
        public UserInfoDOJO DetailProfile([FromBody]string phonenumber)
        {
            Profile prof = new Profile();
            UserInfoDOJO userInfo = prof.DetailProfile(phonenumber);
            // code to convert output into JSON
            return userInfo;
        }
    }
}