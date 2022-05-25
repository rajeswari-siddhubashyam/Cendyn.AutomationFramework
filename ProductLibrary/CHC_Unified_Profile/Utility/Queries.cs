using BaseUtility.Utility;
using CHC_Unified_Profile.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHC_Unified_Profile.Utility
{
    public class Queries : BaseUtility.Utility.Queries
    {
        public static void ViewContactDetails_Email(Profile_DB profile)
        {
            //clear the old items from the list
            //data.clientCards.Clear();           

            query = " select * from up.profile p join up.ContactMethod c on p.ProfileId = c.ProfileId  where ContactMethodTypeId = 7 and p.profileid=1375 ";

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
                            profile.ProfileId = reader["ProfileId"].ToString();
                            profile.CMData = reader["CMData"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void ViewContactDetails_Phone(Profile_DB profile)
        {
            //clear the old items from the list
            //data.clientCards.Clear();           

            query = " select * from up.profile p join up.ContactMethod  c on p.ProfileId = c.ProfileId where ContactMethodTypeId = 5 and p.profileid=300 ";

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
                            profile.ProfileId = reader["ProfileId"].ToString();
                            profile.CMData = reader["CMData"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void ViewContactDetails_Fax(Profile_DB profile)
        {
            //clear the old items from the list
            //data.clientCards.Clear();           

            query = " select * from up.profile p join up.ContactMethod c on p.ProfileId = c.ProfileId  where ContactMethodTypeId = 3 and p.profileid=300 ";

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
                            profile.ProfileId = reader["ProfileId"].ToString();
                            profile.CMData = reader["CMData"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void ViewContactDetails_Address(Profile_DB profile)
        {
            //clear the old items from the list
            //data.clientCards.Clear();           

            query = " select * from up.address where profileid=300 ";

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
                            profile.ProfileId = reader["ProfileId"].ToString();
                            profile.Address1 = reader["Address1"].ToString();
                            profile.City = reader["City"].ToString();
                            profile.StateProvince = reader["StateProvince"].ToString();
                            profile.PostalCode = reader["PostalCode"].ToString();
                            profile.CountryCode = reader["CountryCode"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetProfiles(Profile_DB profile)
        {
            //clear the old items from the list
            //data.clientCards.Clear();           

            query = "select * from up.profile p join up.ContactMethod c on c.ProfileId=p.ProfileId where c.ContactMethodId = 2164 and p.ProfileId = '1375' ";

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
                            profile.ProfileId = reader["ProfileId"].ToString();                            
                            profile.CMData = reader["CMData"].ToString();                            
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetProfile_Main(Profile_DB profile)
        {
            //clear the old items from the list
            //data.clientCards.Clear();           

            query = "select * from up.profile p join up.ContactMethod c on p.ProfileId = c.ProfileId  where c.ContactMethodTypeId=1 and c.ContactMethodId=5824 and p.profileid=3201 ";

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
                            profile.ProfileId = reader["ProfileId"].ToString();
                            profile.CMData = reader["CMData"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetProfile(Profile_DB profile)
        {
            //clear the old items from the list
            //data.clientCards.Clear();           

            query = " select* from up.profile where profileid = 1375 ";

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
                            profile.ProfileId = reader["ProfileId"].ToString();                           
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void Get_Profile(Profile_DB profile)
        {
            //clear the old items from the list
            //data.clientCards.Clear();           

            query = " select * from up.Profile where profileid = '3240' ";

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
                            profile.ProfileId = reader["ProfileId"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void Get_Reservation_Popover_Details(Profile_DB profile)
        {
            //clear the old items from the list
            //data.clientCards.Clear();           

            query = " select * from Reservation r join MarketSegmentInfo m on r.MarketSegmentInfoId = m.MarketsegmentInfoId join Guest g on g.ReservationId = r.ReservationId join Profile p on g.ProfileId = p.ProfileId where p.ProfileId = '4583' ";

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
                            profile.ExternalResID1 = reader["ExternalResID1"].ToString();
                            profile.ConfirmationNum = reader["ConfirmationNum"].ToString();
                            profile.DateInserted = reader["DateInserted"].ToString();
                            profile.CancellationDate = reader["CancellationDate"].ToString();
                            profile.RateCode = reader["RateCode"].ToString();
                            profile.MarketCodeCategory = reader["MarketCodeCategory"].ToString();
                            profile.ResSourceCode = reader["ResSourceCode"].ToString();
                            profile.ChannelCode = reader["ChannelCode"].ToString();
                            profile.RoomTypeCode = reader["RoomTypeCode"].ToString();
                            profile.TotalRoomRevenue = reader["TotalRoomRevenue"].ToString();
                            profile.TotalFBRevenue = reader["TotalFBRevenue"].ToString();
                            profile.TotalOtherRevenue = reader["TotalOtherRevenue"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }
        
        public static void GetProfiles_Phone(Profile_DB profile)
        {
            //clear the old items from the list
            //data.clientCards.Clear();           

            query = " select * from up.profile p join up.ContactMethod c on p.ProfileId = c.ProfileId  where c.ContactMethodTypeId=2 and p.profileid=3201 " ;
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
                            profile.ProfileId = reader["ProfileId"].ToString();
                            profile.CMData = reader["CMData"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetProfiles_PersonalDetails(Profile_DB profile)
        {
            //clear the old items from the list
            //data.clientCards.Clear();           

            query = "select * from up.profile p join up.ContactMethod c on c.ProfileId=p.ProfileId where c.ContactMethodId = 2165 and p.ProfileId = '1375' ";

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
                            profile.Suffix = reader["Suffix"].ToString();
                            profile.PrimaryLanguage = reader["PrimaryLanguage"].ToString();
                            profile.GenderCode = reader["GenderCode"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetProfiles_ContactDetails(Profile_DB profile)
        {
            //clear the old items from the list
            //data.clientCards.Clear();           

            query = "select * from up.profile p join up.ContactMethod c on c.ProfileId=p.ProfileId where c.ContactMethodId = 2164 and p.ProfileId = '1375' ";

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
                            profile.CMData = reader["CMData"].ToString();                            
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetListfrom_Profiletable(List<Profile_DB> lst_ProfileDb)
        {
            //clear the old items from the list
            //data.clientCards.Clear();           

            query = " select top 10 * from up.profile order by profileid desc ";
            //List<Profile_DB> lst = new List<Profile_DB>();

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
                            Profile_DB profile = new Profile_DB();
                            profile.ProfileId = reader["ProfileId"].ToString();                            
                            lst_ProfileDb.Add(profile);
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetListfrom_Reservationtable(List<Profile_DB> lst_ProfileDb)
        {
            //clear the old items from the list
            //data.clientCards.Clear();           

            query = " select top 10 * from Reservation r join Guest g on g.ReservationId = r.ReservationId join Profile p on g.ProfileId = p.ProfileId where p.ProfileId = '4583' order by p.profileid desc ";
            //List<Profile_DB> lst = new List<Profile_DB>();

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
                            Profile_DB profile = new Profile_DB();
                            profile.ExternalResID1 = reader["ExternalResID1"].ToString();
                            lst_ProfileDb.Add(profile);
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}
