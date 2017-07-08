using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Common;
namespace BusinessLayer
{
    public class Profile
    {
        public string CreateProfile(UserInfoDOJO userInfo)
        {
            CreateProfileDAO createProfileDAO = new CreateProfileDAO();
            String phoneNumber = createProfileDAO.insertNewUserProfile(userInfo);
            return "";
        }

        public UserInfoDOJO UpdateProfile(UserInfoDOJO userInfo)
        {
            UserInfoDOJO usrInfo = new UserInfoDOJO();
            
            return usrInfo;
        }

        public bool DeleteProfile(UserInfoDOJO userInfo)
        {
            
            
            return true;
        }

        public UserInfoDOJO ViewProfile(string phoneNumber)
        {
            UserInfoDOJO usrInfo = new UserInfoDOJO();
            return usrInfo;
        }

        public UserInfoDOJO DetailProfile(string phoneNumber)
        {
            UserInfoDOJO usrInfo = new UserInfoDOJO();
            return usrInfo;
        }

    }
}
