using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccess
    {
        public bool ValidateLogin(string userID, string password)
        {
            string connetionString = null;
            SqlConnection cnn;
            bool validUser = false;
            connetionString = "Data Source=melawaonline.database.windows.net;Initial Catalog=melawa;User ID=akashwad;Password=$ummer35";
            cnn = new SqlConnection(connetionString);
            try
            {
                

                SqlCommand cmd = new SqlCommand("ValidateLogin", cnn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@userID", SqlDbType.VarChar, 20).Value = userID;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = password;
                cmd.Parameters.Add("@isValid", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output;

                cnn.Open();
                cmd.ExecuteNonQuery();

                int isValid = Convert.ToInt32(cmd.Parameters["@isValid"].Value);

                cnn.Close();


                if (isValid > 0)
                    validUser = true;
                
                
            }
            catch (Exception ex)
            {

            }
            return validUser;

        }
    }
}
