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
            query = "select top 1 * from ContactMethod where ContactMethodTypeId = 1 and RecordStatus = 1 and CMOptOut = 1";

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
                    "ad.Address1 +', '+ ad.City +', '+ad.StateProvince +' '+ad.PostalCode +' '+ad.CountryCode as 'Address' from Account a " + 
                    "join ReleaseMode r on r.ReleaseModeId = a.ReleaseModeId "+
                    "join AccountStatusType s on s.AccountStatusTypeId = a.StatusId "+
                    "join AccountAddress ad on ad.AccountId=a.AccountId "+
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
                            acc.AccountType = reader["AccountType"].ToString();
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
        public static void GetAddress(List<AccountLinks> links, string chainId)
        {
            query = "select link.CendynPropertyId as'AccountID',link.Url,t.Description from PropertyUrlLink link " +
                    "join LinkType t on t.LinkTypeId = link.Type " +
                    "where accountID = '" + chainId + "'";

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
    }
}
