using BaseUtility.Utility;
using eMenus.Entity;
using System.Data.SqlClient;

namespace eMenus.Utility
{
    public class Queries : BaseUtility.Utility.Queries
    {
        // Identify the Environment, URL, User name and Password
        public static Users GetEnvironmentDetails(Users data)
        {
            query = "select ud.Environment, ud.URL, ud.Username, ud.Password from eMenus_Env_UrlDetails ud WITH(NoLock) where flag = 1";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           // data.New = reader["New"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;

        }
        public static Users GetActiveMemberEmail(Users data)
        {

            query = "SELECT top 1 cs.email FROM customers cs WITH (NOLOCK) where cs.email LIKE '%@cendyn17.com' order by cs.RegistrationEmailSentDate desc";

          using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.email = reader["email"].ToString();
                            
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users GetActiveManagerContact(Users data)
        {

            query = "select Email, DisplayName from PropertyContact where MasterPropertyCode = 'A0C34730' and Active = 1 and ContactTypeCode = 'MGR'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.email = reader["Email"].ToString();
                            data.name = reader["DisplayName"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
    }
}
