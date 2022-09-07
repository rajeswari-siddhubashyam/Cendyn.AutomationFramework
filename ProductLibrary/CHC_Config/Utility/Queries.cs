using BaseUtility.Utility;
using CHC_Config.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHC_Config.Utility
{
    public class Queries : BaseUtility.Utility.Queries
    {
        //This method added as an example
        public static void GetEmail(Users Profile)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = " select top 1 * from ContactMethod where ContactMethodTypeId = 1 and RecordStatus = 1 and CMOptOut = 1";

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

        public static void GetAccountDetails(AccountInfo acc, string chain)
        {
            query = "select r.Description as 'ReleaseDesc', s.Description as 'StatusDesc',a.*, " +
                    "ad.Address1 +', '+ ad.Address2 +', '+ ad.City +', '+ad.StateProvince +' '+ad.PostalCode +' '+ad.CountryCode as 'Address' from Account a " + 
                    "left join ReleaseMode r on r.ReleaseModeId = a.ReleaseModeId "+
                    "left join AccountStatusType s on s.AccountStatusTypeId = a.StatusId "+
                    "left join AccountAddress ad on ad.AccountId=a.AccountId "+
                    "where Name = '" + chain + "'";

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
                            acc.Name = reader["Name"].ToString();
                            acc.ManagementCompany = reader["ManagmentCompany"].ToString();
                            acc.BillingReference = reader["BillingReference"].ToString();
                            acc.AccountID = reader["AccountId"].ToString();
                            acc.ReleaseMode = reader["ReleaseDesc"].ToString();
                            acc.Status = reader["StatusDesc"].ToString();
                            string accountType = reader["AccountType"].ToString();
                            if (accountType == "3")
                                acc.PropertyType = "Hotel";
                            else if (accountType=="2")
                                acc.PropertyType = "Brand";
                            else
                                acc.PropertyType = "Chain";

                            acc.AccountParentID = reader["AccountParentId"].ToString();
                            acc.Address = reader["Address"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }
        public static void GetLocalization(AccountLocalization al, string chainId)
        {
            query = "select a.AccountId,t.TimeZoneName,d.Format as 'DateFormat',c.CurrencyCode,c.CurrencySymbol,l.NativeName as'Language' from Account a "+ 
                    "join TimeZone t on t.TimeZoneId = a.DefaultTimeZoneId "+
                    "join DateFormat d on d.DateFormatId = a.DefaultDateFormatId "+
                    "join Currency c on c.CurrencyCode = a.DefaultCurrencyCode "+
                    "join Languages l on l.Languagecode = a.DefaultLanguageCode "+
                    "where a.AccountId = '" + chainId + "'";

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
                            al.AccountID = reader["AccountId"].ToString();
                            al.CurrencyCode = reader["CurrencyCode"].ToString();
                            al.CurrencySymbol = reader["CurrencySymbol"].ToString();
                            al.DefaultDateFormat = reader["DateFormat"].ToString();
                            al.DefaultLanguage = reader["Language"].ToString();
                            al.TimeZone = reader["TimeZoneName"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }
        public static void GetAccountPhone(List<AccountPhone> phone, string chainId)
        {
            query = "select accountID as 'AccountID' , CountryDialCode+' '+AreaCode+' '+Number as 'PhoneNumber',Type from AccountPhone "+
                    "where accountID = '" + chainId + "'";
            
            string phoneType = null;
            
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
                            AccountPhone p = new AccountPhone();
                            p.AccountID = reader["AccountID"].ToString();
                            p.PhoneNumber = reader["PhoneNumber"].ToString();
                            phoneType = reader["Type"].ToString();
                            if (phoneType == "1")
                                p.PhoneType = "Primary";
                            else if (phoneType == "2")
                                p.PhoneType = "Reservations";
                            else if (phoneType == "3")
                                p.PhoneType = "Fax";
                            else
                                p.PhoneType = phoneType;

                            phone.Add(p);
                        }
                    }
                }
                connection.Close();
            }
        }
        public static void GetLinks(List<AccountLinks> links, string accountId)
        {
            query = "select link.CendynPropertyId as'AccountID',link.Url,t.Description from PropertyUrlLink link "+
                    "join LinkType t on t.LinkTypeId = link.Type "+
                    "where link.CendynPropertyId = '" + accountId + "'";

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
                            AccountLinks l = new AccountLinks();
                            l.AccountID = reader["AccountID"].ToString();
                            l.Url = reader["Url"].ToString();
                            l.Description = reader["Description"].ToString();
                            links.Add(l);
                        }
                    }
                }
                connection.Close();
            }
        }
        public static void GetPropertyAdvancedConfig(PropertyAdvancedConfig p, string propId)
        {
            query = "select a.AccountId, i.Latitude,i.Longitude,i.NumberBeds,i.NumberRooms,c.ChainScaleDescription,t.PropertyTypeDescription,o.OperationDescription,l.LocationName,r.RegionName,r.SubRegion from Account a " +
                    "left join PropertyInfo i on i.AccountId = a.AccountId " +
                    "left join ChainScale c on c.ChainScaleId = i.ChainScaleId " +
                    "left join PropertyType t on t.PropertyTypeId = i.PropertyTypeId " +
                    "left join PropertyOperationType o on o.PropertyOperationTypeId = i.PropertyOperationTypeId " +
                    "left join PropertyLocation l on l.LocationId = i.LocationId " +
                    "left join Region r on r.RegionId=i.RegionId "+
                    "where a.AccountId = '" + propId + "'";


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
                            p.AccountID = reader["AccountId"].ToString();
                            p.Latitude = reader["Latitude"].ToString();
                            p.Longitude = reader["Longitude"].ToString();
                            p.NumberOfBeds = reader["NumberBeds"].ToString();
                            p.NumberOfRooms = reader["NumberRooms"].ToString();
                            p.STRChainScale = reader["ChainScaleDescription"].ToString();
                            p.PropertyType = reader["PropertyTypeDescription"].ToString();
                            p.STROperation = reader["OperationDescription"].ToString();
                            p.STRLocation = reader["LocationName"].ToString();
                            p.UNRegion = reader["RegionName"].ToString();
                            p.UNSubRegion = reader["SubRegion"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }
        
        public static void GetBrandsForChain(List<AccountInfo> brands, string chainId)
        {
            query = "select Name, FORMAT(InsertDate, 'MMM dd yyyy') as 'DateAdded' from Account "+
                    "where AccountType = '2' "+
                    "and AccountParentId = '" + chainId + "' "+
                    "order by Name ";

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
                            AccountInfo acc = new AccountInfo();
                            acc.Name = reader["Name"].ToString();
                            acc.DateAdded = reader["DateAdded"].ToString();
                            brands.Add(acc);
                        }
                    }
                }
                connection.Close();
            }
        }
        public static void GetPropertiesForChain(List<AccountInfo> properties, string chainId)
        {
            query = "select Name, FORMAT(InsertDate, 'MMM dd yyyy') as 'DateAdded' from Account " +
                    "where AccountType = '3' "+
                    "and AccountParentId in (select AccountId from Account where AccountType = '2' and AccountParentId = '" + chainId + "') "+
                     "order by Name ";

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
                            AccountInfo acc = new AccountInfo();
                            acc.Name = reader["Name"].ToString();
                            acc.DateAdded = reader["DateAdded"].ToString();
                            properties.Add(acc);
                        }
                    }
                }
                connection.Close();
            }
        }
        public static void GetPropertiesForBrand(List<AccountInfo> properties, string brandId)
        {
            query = "select Name, FORMAT(InsertDate, 'MMM dd yyyy') as 'DateAdded' from Account " +
                    "where AccountType = '3' " +
                    "and AccountParentId = '" + brandId + "' "+
                     "order by Name ";

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
                            AccountInfo acc = new AccountInfo();
                            acc.Name = reader["Name"].ToString();
                            acc.DateAdded = reader["DateAdded"].ToString();
                            properties.Add(acc);
                        }
                    }
                }
                connection.Close();
            }
        }
        public static void GetParentAccount(AccountInfo acc, string propId)
        {
            query = "select AccountId, Name, FORMAT(InsertDate, 'MMM dd yyyy') as 'DateAdded' from Account " +
                    "where AccountId in (select AccountParentId from Account where AccountId = '" + propId + "')" ;        

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
                            acc.Name = reader["Name"].ToString();
                            acc.DateAdded = reader["DateAdded"].ToString();
                            acc.AccountID = reader["AccountId"].ToString();                           
                        }
                    }
                }
                connection.Close();
            }
        }
        public static void GetFacilities(List<string> facilities, string propId)
        {
            query = "select f.FacilityDescription from PropertyFacility f "+
                    "join PropertyFacilityMapping m on m.FacilityCode = f.FacilityCode "+
                    "where m.AccountId = '" + propId + "' order by f.FacilityDescription";
                    
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
                            facilities.Add(reader["FacilityDescription"].ToString());
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetUser(Users user)
        {
            //clear the old items from the list
            //data.clientCards.Clear();
            query = " select * from Users where userid = 472 ";

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
                            user.UserId = reader["UserId"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetListfrom_Usersetable(List<Users> lst_ProfileDb)
        {
            //clear the old items from the list
            //data.clientCards.Clear();           

            query = " select top 10 * from Users order by userid ";
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
                            Users profile = new Users();
                            profile.UserId = reader["UserId"].ToString();
                            lst_ProfileDb.Add(profile);
                        }
                    }
                }
                connection.Close();
            }
        }

    }
}
