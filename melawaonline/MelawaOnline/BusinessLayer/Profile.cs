using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Profile
    {
        public string CreateProfile(UserInfo userInfo)
        {
            return "";
        }

        public UserInfo UpdateProfile(UserInfo userInfo)
        {
            UserInfo usrInfo = new UserInfo();
            return usrInfo;
        }

        public bool DeleteProfile(UserInfo userInfo)
        {
            return true;
        }

        public UserInfo ViewProfile(string phoneNumber)
        {
            UserInfo usrInfo = new UserInfo();
            return usrInfo;
        }

        public UserInfo DetailProfile(string phoneNumber)
        {
            UserInfo usrInfo = new UserInfo();
            return usrInfo;
        }

    }
}
