using BaseUtility.Utility;
using CHC.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHC.Utility
{
    public class Queries : BaseUtility.Utility.Queries
    {
        public static void GetCards(Users data, int id)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            //query = "SELECT Type FROM CAM.CampaignType" +
            //        " WHERE CampaignTypeGroupId = " + id + "";
            //using (SqlConnection connection = DBHelper.SqlConn())
            //{
            //    connection.Open();

            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.CommandTimeout = 60;
            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                data.clientCards.Add(reader["Type"].ToString());
            //            }
            //        }
            //    }
            //    connection.Close();
            //}
        }

        public static void GetEmail(Profile_DB Profile)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = " select  top 1 * from ContactMethod where ContactMethodTypeId = 3 and RecordStatus = 1 and profileid = '2056' ";
            //select top 1 * from ContactMethod where ContactMethodTypeId = 1 and RecordStatus = 1 and CMOptOut = 1

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
                            Profile.CMData = reader["CMData"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetReservation(Reservation_DB reservation)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = "select top 1* from Reservation where SourceResStatus = 'Reserved' and PropertyAccountid = 40 and SourcePropertyID = 'Hotel Origami - Palm Beach' and patindex('%[^0-9]%',ExternalResID1) = 0 Order By DateInserted DESC";

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
                            reservation.ExternalResID1 = Convert.ToInt32(reader["ExternalResID1"].ToString());
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetProfiles(Profile_DB profile, string externalprofileid)
        {
            //clear the old items from the list
            //data.clientCards.Clear();           
           
            query = "select top 1* from profile where PropertyAccountId = 40 and ExternalProfileId1 = '" + externalprofileid + "' ";

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
                            profile.ExternalProfileId1 = reader["ExternalProfileId1"].ToString();
                            profile.ProfileId = reader["ProfileId"].ToString();
                            profile.SourceCreateUser = reader["SourceCreateUser"].ToString();
                            profile.DateInserted = reader["DateInserted"].ToString();
                            profile.DateUpdated = reader["DateUpdated"].ToString();
                        }
                    }
                }
                connection.Close(); 
            }
        }

        public static void GetPersonalDetails(Profile_DB profile, string profileid)
                {
                    //clear the old items from the list
                    //data.clientCards.Clear();
                    query = "select top 1* from profile where PropertyAccountId = 40 and ExternalProfileId1 = '" + profileid + "'";

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
                                    profile.FamiliarName = reader["FamiliarName"].ToString();
                                    profile.FirstName = reader["FirstName"].ToString();
                                    profile.LastName = reader["LastName"].ToString();
                                    profile.Salutation = reader["Salutation"].ToString();
                                    profile.MiddleName = reader["MiddleName"].ToString();                                   
                                    profile.Suffix = reader["Suffix"].ToString();
                                    profile.PrimaryLanguage = reader["PrimaryLanguage"].ToString();
                                    profile.GenderCode = reader["GenderCode"].ToString();
                                    profile.Nationality = reader["Nationality"].ToString();
                                    profile.JobTitle = reader["JobTitle"].ToString();
                        }
                            }
                        }
                        connection.Close(); 
            }
        }

        public static void GetAddressDetails(Profile_DB profile, string profileid)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = "select top 1* from profile p join Address a on p.profileid = a.ProfileId where ExternalProfileId1 = '" + profileid + "'";

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
                            profile.Address1 =  reader["Address1"].ToString();
                            profile.Address2 =  reader["Address2"].ToString();
                            profile.City =  reader["City"].ToString();
                            profile.StateProvince = reader["StateProvince"].ToString();
                            profile.PostalCode = reader["PostalCode"].ToString();
                            profile.CountryCode = reader["CountryCode"].ToString();
                            profile.IsPrimary = reader["IsPrimary"].ToString();
                            profile.AddressLanguage = reader["AddressLanguage"].ToString();
                            profile.DateInserted = reader["DateInserted"].ToString();
                            profile.DateUpdated = reader["DateUpdated"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }
        public static void GetMemberships(Profile_DB profile, string profileid)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = "select top 1 * from Membership m join profile p on p.profileid = m.profileid where p.ExternalProfileId1 = '" + profileid + "'";

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
                            profile.CustomerMembershipID = reader["CustomerMembershipID"].ToString();                            
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetVIPCode_VIPID(Profile_DB profile , string profileid)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = "select top 1* from Profile P join ProfileBusinessInfo b on b.ProfileId=p.ProfileId where p.ExternalProfileId1 = '" + profileid + "' ";

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
                            profile.VIPID = reader["VIPID"].ToString();
                            profile.VIPCode = reader["VIPCode"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetCommunicationPreferences(Profile_DB profile , string profileid)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = " select * from Profile p join ProfilePolicy d on d.InternalId=p.ProfileId join PolicyType type on type.PolicyTypeId = d.PolicyTypeId where p.ExternalProfileId1 = '" + profileid + "'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                profile.AttributeNames_Values = new Dictionary<string, int>();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            profile.AttributeNames_Values.Add(reader["AttributeName"].ToString(),Convert.ToInt32(reader["IntegerValue"]));
                                                                                
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetCMData(Profile_DB profile)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = "select top 1 * from contactmethod c join profile p on c.profileid = p.profileid order by c.DateInserted desc ";

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
                            profile.CMOptOut = reader["CMOptOut"].ToString();
                            profile.IsPrimary = reader["IsPrimary"].ToString();
                            profile.DateInserted = reader["DateInserted"].ToString();
                            profile.DateUpdated = reader["DateUpdated"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetMainResDetails(Profile_DB profile, Reservation_DB reservation)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = "select* from Reservation where ExternalResID1= '"+ reservation.ExternalResID1+"'  ";

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
                            //profile.FamiliarName = reader["Guest Name"].ToString();
                            reservation.Reservationid = reader["Reservationid"].ToString();
                            //reservation.ResArriveDate = reader["ResArriveDate"].ToString();
                            reservation.ConfirmationNum = reader["ConfirmationNum"].ToString();
                            //reservation.ResDepartDate = reader["ResDepartDate"].ToString();
                            //reservation.NumRooms = reader["NumRooms"].ToString();
                            //reservation.NumAdults = reader["NumAdults"].ToString();
                            //reservation.NumChildren = reader["NumChildren"].ToString();
                            //reservation.TotalRoomNights = reader["TotalRoomNights"].ToString();
                            //profile.DateInserted = reader["DateInserted"].ToString();
                            //profile.DateUpdated = reader["DateUpdated"].ToString();
                            ////profile.MiddleName = reader["Arrival Date"].ToString();                           
                        }
                    }
                }
                connection.Close(); 
            }
        }

        public static void GetMainResDetails_Room(Profile_DB profile, Reservation_DB reservation)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = "select* from Reservation where ExternalResID1= '" + reservation.ExternalResID1 + "'  ";

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
                            reservation.ResArriveDate = reader["ResArriveDate"].ToString();                            
                            reservation.ResDepartDate = reader["ResDepartDate"].ToString();
                            reservation.TotalRoomNights = reader["TotalRoomNights"].ToString();
                            reservation.NumAdults = reader["NumAdults"].ToString();
                            reservation.NumChildren = reader["NumChildren"].ToString();
                            reservation.NumRooms = reader["NumRooms"].ToString();                                                                              
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetGuestsDetails(Profile_DB profile, string profileid)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = "select top 1* from profile where PropertyAccountId = 40 and ExternalProfileId1 = '" + profileid + "'";

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
                            profile.FamiliarName = reader["Profile ID"].ToString();
                            profile.FirstName = reader["FirstName"].ToString();
                            profile.LastName = reader["LastName"].ToString();
                            profile.Salutation = reader["Email"].ToString();
                            profile.MiddleName = reader["Phone"].ToString();
                            profile.Suffix = reader["Country"].ToString();                            
                            profile.Nationality = reader["Is Promary"].ToString();
                            profile.DateInserted = reader["DateInserted"].ToString();
                            profile.DateUpdated = reader["DateUpdated"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetStayDetails(Profile_DB profile, Reservation_DB reservation)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = "select * from Reservation r join StayDetail d on d.ReservationId = r.ReservationId where ExternalResID1 =  '" + reservation.ExternalResID1 + "' ";

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
                            reservation.StayDate = reader["StayDate"].ToString();
                            reservation.SourceRoomType = reader["SourceRoomType"].ToString();
                            reservation.SourceRateType = reader["SourceRateType"].ToString();
                            reservation.CurrencyCode = reader["CurrencyCode"].ToString();
                            reservation.DailyRate = reader["DailyRate"].ToString();
                            reservation.MarketCode = reader["MarketCode"].ToString();
                            reservation.ResSourceCode = reader["ResSourceCode"].ToString();
                            reservation.DateInserted = reader["DateInserted"].ToString();
                            reservation.DateUpdated = reader["DateUpdated"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetTransactionsDetails(Profile_DB profile, string profileid)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = "select top 1* from profile where PropertyAccountId = 40 and ExternalProfileId1 = '" + profileid + "'";

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
                            profile.FamiliarName = reader["Transaction ID"].ToString();
                            profile.FirstName = reader["Transaction Group"].ToString();                            
                            profile.Salutation = reader["Description"].ToString();                            
                            profile.Suffix = reader["Quantity"].ToString();
                            profile.PrimaryLanguage = reader["Ammount"].ToString();
                            profile.DateInserted = reader["DateInserted"].ToString();                            
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetPackageDetails(Profile_DB profile, string profileid)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = "select top 1* from profile where PropertyAccountId = 40 and ExternalProfileId1 = '" + profileid + "'";

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
                            profile.FamiliarName = reader["Code"].ToString();
                            profile.FirstName = reader["Description"].ToString();
                            profile.LastName = reader["Service Invoice Code"].ToString();
                            profile.Salutation = reader["Start Date"].ToString();
                            profile.MiddleName = reader["End Date"].ToString();
                            profile.Suffix = reader["Price Amount"].ToString();                            
                            profile.GenderCode = reader["Current"].ToString();
                            profile.PrimaryLanguage = reader["Quantity"].ToString();
                            profile.Nationality = reader["Service Comments"].ToString();                           
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetRevenueDetails(Profile_DB profile, Reservation_DB reservation)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = "select* from Reservation where ExternalResID1= '" + reservation.ExternalResID1 + "' ";

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
                            reservation.TotalRoomRevenue = reader["TotalRoomRevenue"].ToString();
                            reservation.TotalOtherRevenue = reader["TotalOtherRevenue"].ToString();
                            reservation.TotalTax = reader["TotalTax"].ToString();
                            reservation.TotalFees = reader["TotalFees"].ToString();
                            reservation.TotalRevenue = reader["TotalRevenue"].ToString();                            
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetPoliciesDetails(Profile_DB profile, Reservation_DB reservation)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = "select* from Reservation where ExternalResID1= '" + reservation.ExternalResID1 + "' ";

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
                            reservation.GuaranteedByCode = reader["GuaranteedByCode"].ToString();
                            reservation.MethodOfPayment = reader["MethodOfPayment"].ToString();
                            reservation.RateConfidential = reader["RateConfidential"].ToString();
                            reservation.DiscountCode = reader["DiscountCode"].ToString();
                            reservation.DiscountAmount = reader["DiscountAmount"].ToString();
                            reservation.DiscountPercent = reader["DiscountPercent"].ToString();
                            reservation.DiscountReasonCode = reader["DiscountReasonCode"].ToString();
                            //reservation.IsNotRefundable = reader["IsNotRefundable"].ToString();
                            reservation.ApplyTax = reader["ApplyTax"].ToString();                            
                        }
                    }
                }
                connection.Close();
            }
        }        

        public static void GetAssociatedProfileDetails(Profile_DB profile, Reservation_DB reservation)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = "select* from Reservation where ExternalResID1= '" + reservation.ExternalResID1 + "' ";

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
                            reservation.CompanyCode = reader["CompanyCode"].ToString();
                            reservation.CompanyName = reader["CompanyName"].ToString();
                            reservation.TravelAgentCode = reader["TravelAgentCode"].ToString();
                            reservation.TravelAgentName = reader["TravelAgentName"].ToString();                            
                        }
                    }
                }
                connection.Close();
            }
        }        
    }
}









