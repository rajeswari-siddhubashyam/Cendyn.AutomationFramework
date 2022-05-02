using BaseUtility.Utility;
using eLoyaltyV3.Entity;
using InfoMessageLogger;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eLoyaltyV3.Utility
{
    public class Queries : BaseUtility.Utility.Queries
    {
        /// <summary>
        /// Identify Registered user.
        /// </summary>
        /// <returns>email address</returns>
        public static string ReturnRegisteredUserEmail()
        {
            string registeredUser;
            query = "SELECT TOP 1 email FROM Users WITH (NoLock)  WHERE email LIKE '%@cendyn17.com' ORDER BY id DESC";
            columnName = "email";
            registeredUser = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return registeredUser;
        }

        public static CRMAPIInfo GetCredentialsAndMasterPropertyCode(CRMAPIInfo data)
        {

            query = "DECLARE @MasterPropertyCode NVARCHAR(50)= " +
                    "( " +
                        "SELECT TOP 1 pm.MasterMasterPropertyCode " +
                        "FROM dbo.PropertyMapping pm WITH(NOLOCK) " +
                    "); " +
                    "WITH [Credentials] " +
                         "AS (SELECT 1 AS ID, " +
                                    "ps.SettingValue, " +
                                    "ps.MasterPropertyCode " +
                             "FROM dbo.PropertySetting ps WITH(NOLOCK) " +
                             "WHERE ps.SettingKey IN('CRMApiUsername') " +
                             "AND ps.MasterPropertyCode = @MasterPropertyCode " +
                             "UNION " +
                             "SELECT 2 AS ID, " +
                                    "ps.SettingValue, " +
                                    "ps.MasterPropertyCode " +
                             "FROM dbo.PropertySetting ps WITH(NOLOCK) " +
                             "WHERE ps.SettingKey IN('CRMApiPassword') " +
                             "AND ps.MasterPropertyCode = @MasterPropertyCode) " +
                         "SELECT TOP 1 STUFF( " +
                         "( " +
                             "SELECT ':' + c2.SettingValue " +
                             "FROM [Credentials] c2 WITH(NOLOCK) FOR XML PATH('') " +
                         "), 1, 1, NULL) AS [Credential], " +
                                      "c.MasterPropertyCode, " +
                         "( " +
                             "SELECT TOP 1 REPLACE(ps2.SettingValue, '{crm_property_code}', ps2.MasterPropertyCode) AS SignUpApiUrl " +
                             "FROM dbo.PropertySetting ps2 WITH(NOLOCK) " +
                             "WHERE ps2.SettingKey = 'SignUpApiUrl' " +
                         ") AS CRMAPIURL " +
                         "FROM [Credentials] c " +
                              "INNER JOIN dbo.PropertySetting ps WITH(NOLOCK) ON ps.MasterPropertyCode = c.MasterPropertyCode;";


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
                            data.Credentials = reader["Credential"].ToString();
                            data.MasterPropertyCode = reader["MasterPropertyCode"].ToString();
                            data.CRMAPIURL = reader["CRMAPIURL"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        /// <summary>
        /// Identify registered user but not activated account
        /// </summary>
        /// <returns>email address</returns>
        public static string ReturnRegisteredNotActiveUserEmail()
        {
            string registeredUser;
            query = "Select Top 1 email from Users U with (nolock) where U.RegistrationConfirmDate is null and email like '%@Cendyn17.com' order by id desc ";
            columnName = "email";
            registeredUser = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return registeredUser;
        }

        /// <summary>
        /// PMS customer with no membership and stay status in checkedout
        /// Returns Cendyn17 email
        /// </summary>
        /// <returns>Email</returns>
        public static string ReturnPMSCustomerIDCheckedOutNoMembership()
        {
            string pmsCustomer;
            query = "Select top 1 CustomerID from d_customer cust with (nolock) inner join D_customer_stay stay with (nolock) on cust.CustomerID = stay.CustomerID where not exists ( select 1 from memberships mem with (nolock) where mem.MemberEmail = cust.email) and profileid is null and staystatus in ( 'O' ) and Email like '%@Cendyn17.com' order by cust.CustomerID desc";
            columnName = "CustomerID";
            pmsCustomer = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomer;
        }

        /// <summary>
        /// Identify Record exist in D_Customer_Stay table with a specific Staystatus
        /// Returns Null or Record exist
        /// </summary>
        public static string ReturnStayStatus(string stayStatus)
        {
            string pmsCustomer;

            query = "DECLARE @CheckExpressions NVARCHAR(10)= " +
                    "( " +
                        "SELECT TOP 1 LEN(dcs.StayStatus) " +
                        "FROM dbo.D_CUSTOMER_STAY dcs WITH (NOLOCK) " +
                        "WHERE dcs.StayStatus = '" + stayStatus + "' " +
                    "); " +
                    "SELECT CASE " +
                                "WHEN @CheckExpressions IS NULL " +
                                "THEN 'Record does not exist in table.' " +
                                "WHEN @CheckExpressions = 1 " +
                                "THEN 'Record exist in table.' " +
                            "END AS CheckExpressions;";

            columnName = "CheckExpressions";
            pmsCustomer = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomer;
        }

        /// <summary>
        /// PMS customer with no membership and stay status in reserverd
        /// Returns Cendyn17 email
        /// </summary>
        /// <returns>Email</returns>
        public static Users ReturnPMSCustomerHavingStay(string stayStatus, Users data)
        {

            query = "WITH StayResult " +
                         "AS (SELECT dcs.CustomerID, " +
                                    "dcs.StayStatus " +
                             "FROM dbo.D_CUSTOMER_STAY dcs WITH (NOLOCK) " +
                             "WHERE dcs.StayStatus = '" + stayStatus + "' " +
                                   "AND ISNULL(dcs.StayStatus, '') != ''), " +
                         "DCResult " +
                         "AS (SELECT dc.CustomerID, " +
                                    "dc.FirstName, " +
                                    "dc.LastName, " +
                                    "dc.Email, " +
                                    "t.StayStatus " +
                             "FROM dbo.D_CUSTOMER dc WITH (nolock) " +
                                  "INNER JOIN dbo.PropertyMapping pm WITH (NOLOCK) ON dc.PropertyCode = pm.PropertyCode " +
                                  "LEFT JOIN StayResult t ON dc.CustomerID = t.CustomerID " +
                             "WHERE dc.SourceID = 1 " +
                                   "AND dc.ProfileId IS NULL " +
                                   "AND ISNULL(dc.Email, '') != '' " +
                                   "AND ISNULL(t.StayStatus, '') != '') " +
                         "SELECT TOP 10 ts.CustomerID, " +
                                       "ts.FirstName, " +
                                       "ts.LastName, " +
                                       "ts.StayStatus,ts.email " +
                         "FROM DCResult ts WITH (NOLOCK) " +
                         "WHERE NOT EXISTS " +
                    "( " +
                        "SELECT 1 " +
                        "FROM dbo.MemberShips ms WITH (nolock) " +
                        "WHERE ms.MemberEmail = ts.Email " +
                    ") " +
                               "AND ts.StayStatus = '" + stayStatus + "' " +
                               "AND ts.FirstName NOT LIKE '%[&]%';";

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
                            data.CustomerID = reader["CustomerID"].ToString();
                            data.firstName = reader["FirstName"].ToString();
                            data.lastName = reader["LastName"].ToString();
                            data.eMail = reader["Email"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        /// <summary>
        /// PMS customer with no membership and stay status in reserverd
        /// Returns Cendyn17 email
        /// </summary>
        /// <returns>Email</returns>
        public static Users ReturnPMSCustomerHavingStay_Test(string stayStatus, Users data)
        {
            query = "DECLARE @stayStatus VARCHAR(10)= '" + stayStatus + "'; " +
                    "WITH GetStayData " +
                         "AS ( " +
                         "SELECT TOP 100000 dcs.CustomerID, " +
                                           "dcs.SourceStayID, " +
                                           "dcs.StayStatus " +
                         "FROM dbo.D_CUSTOMER_STAY dcs WITH (NOLOCK) " +
                         "WHERE ISNULL(dcs.StayStatus, '') != '' " +
                         "ORDER BY dcs.CustomerID DESC), " +
                         "StayResult " +
                         "AS ( " +
                         "SELECT gsd.CustomerID, " +
                                "gsd.SourceStayID, " +
                                "gsd.StayStatus, " +
                    "( " +
                        "SELECT dcs1.PropertyCode " +
                        "FROM dbo.D_CUSTOMER_STAY dcs1 WITH (NOLOCK) " +
                        "WHERE dcs1.SourceStayID = gsd.SourceStayID " +
                    ") PropertyCode " +
                         "FROM GetStayData gsd " +
                         "WHERE NOT EXISTS " +
                    "( " +
                        "SELECT gsd.StayStatus " +
                        "FROM dbo.D_CUSTOMER_STAY dcs WITH (NOLOCK) " +
                        "WHERE dcs.StayStatus NOT IN(@stayStatus) " +
                        "AND gsd.CustomerID = dcs.CustomerID " +
                    ")), " +
                         "DCResult " +
                         "AS ( " +
                         "SELECT dc.CustomerID, " +
                                "dc.FirstName, " +
                                "dc.LastName, " +
                                "dc.Email, " +
                                "t.StayStatus " +
                         "FROM dbo.D_CUSTOMER dc WITH (nolock) " +
                              "LEFT JOIN StayResult t ON dc.CustomerID = t.CustomerID " +
                              "INNER JOIN dbo.PropertyMapping pm WITH (NOLOCK) ON t.PropertyCode = pm.PropertyCode " +
                         "WHERE dc.SourceID = 1 " +
                               "AND dc.ProfileId IS NULL " +
                               "AND ISNULL(dc.Email, '') != '' " +
                               "AND ISNULL(t.StayStatus, '') != '') " +
                         "SELECT DISTINCT TOP 1 ts.CustomerID, " +
                                                 "ts.FirstName, " +
                                                 "ts.LastName, " +
                                                 "ts.Email " +
                         "FROM DCResult ts WITH (NOLOCK) " +
                         "WHERE NOT EXISTS " +
                    "( " +
                        "SELECT 1 " +
                        "FROM dbo.MemberShips ms WITH (nolock) " +
                        "WHERE ms.MemberEmail = ts.Email " +
                    ") " +
                               "AND ts.FirstName NOT LIKE '%[&]%' " +
                               "AND ISNULL(ts.FirstName, '') != '' " +
                               "AND ISNULL(ts.LastName, '') != '' " +
                               "AND ts.Email LIKE '%[a-z0-9]%';";


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
                            data.CustomerID = reader["CustomerID"].ToString();
                            data.firstName = reader["FirstName"].ToString();
                            data.lastName = reader["LastName"].ToString();
                            data.eMail = reader["Email"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        //Start of Commenting out code
        public static string ReturnPMSCustomerIDReservedNoMembership()
        {
            string pmsCustomer;
            query = "WITH StayResult " +
                         "AS (SELECT dcs.CustomerID, " +
                                    "dcs.StayStatus " +
                             "FROM dbo.D_CUSTOMER_STAY dcs WITH (NOLOCK) " +
                             "WHERE dcs.StayStatus = 'R'), " +
                         "DCResult " +
                         "AS (SELECT TOP 10 dc.CustomerID, " +
                                    "dc.FirstName, " +
                                    "dc.LastName, " +
                                    "dc.Email, " +
                                    "t.StayStatus " +
                             "FROM dbo.D_CUSTOMER dc WITH (nolock) " +
                                  "INNER JOIN dbo.PropertyMapping pm WITH (NOLOCK) ON dc.PropertyCode = pm.PropertyCode " +
                                  "LEFT JOIN StayResult t ON dc.CustomerID = t.CustomerID " +
                             "WHERE dc.SourceID = 1 " +
                                   "AND dc.ProfileId IS NULL " +
                                   "AND ISNULL(dc.Email, '') != '' " +
                                   "AND ISNULL(t.StayStatus, '') != '') " +
                         "SELECT ts.CustomerID, " +
                                "ts.FirstName, " +
                                "ts.LastName, " +
                                "ts.StayStatus " +
                         "FROM DCResult ts WITH (NOLOCK) " +
                         "WHERE NOT EXISTS " +
                    "( " +
                        "SELECT 1 " +
                        "FROM dbo.MemberShips ms WITH (nolock) " +
                        "WHERE ms.MemberEmail = ts.Email " +
                    ") " +
                               "AND ts.FirstName NOT LIKE '%[&]%';";


            columnName = "CustomerID";
            pmsCustomer = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomer;
        }

        public static Users ReturnPMSCustomerIDReservedNoMembership_Test(Users data)
        {
            string pmsCustomer;
            query = "WITH StayResult " +
                     "AS ( " +
                        "SELECT dcs.CustomerID, " +
                                "dcs.StayStatus " +
                         "FROM dbo.D_CUSTOMER_STAY dcs WITH (NOLOCK) " +
                         "WHERE dcs.StayStatus = 'R' " +
                        "), " +
                     "DCResult " +
                     "AS (SELECT TOP 10 dc.CustomerID, " +
                                       "dc.FirstName, " +
                                       "dc.LastName, " +
                                       "dc.Email, " +
                                       "t.StayStatus " +
                         "FROM dbo.D_CUSTOMER dc WITH (nolock) " +
                              "INNER JOIN dbo.PropertyMapping pm WITH (NOLOCK) ON dc.PropertyCode = pm.PropertyCode " +
                              "LEFT JOIN StayResult t ON dc.CustomerID = t.CustomerID " +
                         "WHERE dc.SourceID <> 1 " +
                               "AND dc.ProfileId IS NULL " +
                               "AND ISNULL(dc.Email, '') != '' " +
                               "AND ISNULL(t.StayStatus, '') != '') " +
                     "SELECT TOP 1 ts.CustomerID, " +
                                  "ts.FirstName, " +
                                  "ts.LastName, " +
                                  "ts.Email, " +
                                  "ts.StayStatus " +
                     "FROM DCResult ts WITH (NOLOCK) " +
                     "WHERE NOT EXISTS " +
                "( " +
                    "SELECT 1 " +
                    "FROM dbo.MemberShips ms WITH (nolock) " +
                    "WHERE ms.MemberEmail = ts.Email " +
                ") " +
                           "AND ISNULL(ts.FirstName, '') != '' " +
                           "AND ISNULL(ts.LastName, '') != '' " +
                           "AND ts.FirstName NOT LIKE '%[&]%';";


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
                            data.CustomerID = reader["CustomerID"].ToString();
                            data.firstName = reader["FirstName"].ToString();
                            data.lastName = reader["LastName"].ToString();
                            data.eMail = reader["Email"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        /// <summary>
        /// PMS customer with no membership and stay status is In House
        /// Returns Cendyn17 email
        /// </summary>
        /// <returns>Email</returns>
        public static string ReturnPMSCustomerIDInHouseNoMembership()
        {
            string pmsCustomer;
            query = "SELECT TOP 10 dc.CustomerID, " +
                                  "dc.FirstName, " +
                                  "dc.LastName, " +
                                  "dc.Email " +
                    "FROM dbo.D_CUSTOMER dc WITH (nolock) " +
                         "INNER JOIN dbo.D_CUSTOMER_STAY dcs WITH (nolock) ON dc.CustomerID = dcs.CustomerID " +
                         "INNER JOIN dbo.PropertyMapping pm WITH (NOLOCK) ON dcs.PropertyCode = pm.PropertyCode " +
                    "WHERE NOT EXISTS " +
                    "( " +
                        "SELECT 1 " +
                        "FROM dbo.MemberShips ms WITH (nolock) " +
                        "WHERE ms.MemberEmail = dc.email " +
                    ") " +
                          "AND dc.SourceID = 1 " +
                          "AND dc.ProfileId IS NULL " +
                          "AND dcs.staystatus IN('I') " +
                         "AND ISNULL(dc.Email, '') != '' " +
                         "AND dc.Email LIKE '%@cendyn17.com' " +
                    "ORDER BY dc.CustomerID DESC;";

            columnName = "CustomerID";
            pmsCustomer = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomer;
        }

        /// <summary>
        /// PMS customer with no membership and stay status is Cancelled
        /// Returns Cendyn17 email
        /// </summary>
        /// <returns>Email</returns>
        public static string ReturnPMSCustomerIDCancelledNoMembership()
        {
            string pmsCustomer;
            query = "SELECT TOP 10 dc.CustomerID, " +
                                  "dc.FirstName, " +
                                  "dc.LastName, " +
                                  "dc.Email " +
                    "FROM dbo.D_CUSTOMER dc WITH (nolock) " +
                         "INNER JOIN dbo.D_CUSTOMER_STAY dcs WITH (nolock) ON dc.CustomerID = dcs.CustomerID " +
                         "INNER JOIN dbo.PropertyMapping pm WITH (NOLOCK) ON dcs.PropertyCode = pm.PropertyCode " +
                    "WHERE NOT EXISTS " +
                    "( " +
                        "SELECT 1 " +
                        "FROM dbo.MemberShips ms WITH (nolock) " +
                        "WHERE ms.MemberEmail = dc.email " +
                    ") " +
                          "AND dc.SourceID = 1 " +
                          "AND dc.ProfileId IS NULL " +
                          "AND dcs.staystatus IN('C') " +
                         "AND ISNULL(dc.Email, '') != '' " +
                         "AND dc.Email LIKE '%@cendyn17.com' " +
                    "ORDER BY dc.CustomerID DESC;";

            columnName = "CustomerID";
            pmsCustomer = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomer;
        }

        /// <summary>
        /// PMS customer with no membership and stay status is No Show
        /// Returns Cendyn17 email
        /// </summary>
        /// <returns>Email</returns>
        public static string ReturnPMSCustomerIDNoShowedNoMembership()
        {
            string pmsCustomer;
            query = "SELECT TOP 10 dc.CustomerID, " +
                                  "dc.FirstName, " +
                                  "dc.LastName, " +
                                  "dc.Email " +
                    "FROM dbo.D_CUSTOMER dc WITH (nolock) " +
                         "INNER JOIN dbo.D_CUSTOMER_STAY dcs WITH (nolock) ON dc.CustomerID = dcs.CustomerID " +
                         "INNER JOIN dbo.PropertyMapping pm WITH (NOLOCK) ON dcs.PropertyCode = pm.PropertyCode " +
                    "WHERE NOT EXISTS " +
                    "( " +
                        "SELECT 1 " +
                        "FROM dbo.MemberShips ms WITH (nolock) " +
                        "WHERE ms.MemberEmail = dc.email " +
                    ") " +
                          "AND dc.SourceID = 1 " +
                          "AND dc.ProfileId IS NULL " +
                          "AND dcs.staystatus IN('N') " +
                         "AND ISNULL(dc.Email, '') != '' " +
                         "AND dc.Email LIKE '%@cendyn17.com' " +
                    "ORDER BY dc.CustomerID DESC;";

            columnName = "CustomerID";
            pmsCustomer = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomer;
        }

        /// <summary>
        /// This method will return the value in the entered column for the customerID
        /// </summary>
        /// <param name="customerID">Customer ID of the data</param>
        /// <param name="column">Column of data to be returned</param>
        /// <returns></returns>
        public static string ReturnValueFromColumnByCustomerID(string customerID, string column)
        {
            string pmsCustomer;
            query = "SELECT * " +
                    "FROM d_customer cust WITH (nolock) " +
                         "INNER JOIN D_customer_stay stay WITH (nolock) ON cust.CustomerID = stay.CustomerID " +
                    "WHERE cust.CustomerID = " + customerID;

            columnName = column;
            pmsCustomer = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomer;
        }

        //With Specific Stay
        public static string ReturnStayValueFromColumnByCustomerID(string customerID, string column, string staystatus)
        {
            string pmsCustomer;
            query = "SELECT ReservationNumber,staystatus, * " +
                    "FROM d_customer dc WITH (nolock) " +
                         "INNER JOIN D_customer_stay dcs WITH (nolock) ON dc.CustomerID = dcs.CustomerID " +
                    "WHERE dc.CustomerID = " + customerID + "";

            columnName = column;
            pmsCustomer = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomer;
        }

        public static Users ReturnStayValueFromColumnByEmail(string Email, string staystatus, Users data)
        {
            if (!string.IsNullOrEmpty(staystatus))
            {
                query = "IF OBJECT_ID('tempdb..#GetReservationNum') IS NOT NULL " +
                            "DROP TABLE #GetReservationNum; " +

                        "DECLARE @Email NVARCHAR(50)= '" + Email + "'; " +
                        "DECLARE @Staystatus NVARCHAR(50)= '" + staystatus + "'; " +

                        "SELECT ReservationNumber " +
                        "INTO #GetReservationNum " +
                        "FROM dbo.D_CUSTOMER dc WITH(NOLOCK) " +
                             "INNER JOIN dbo.D_CUSTOMER_STAY dcs WITH(NOLOCK) ON dc.CustomerID = dcs.CustomerID " +
                             "INNER JOIN dbo.Users u WITH(NOLOCK) ON u.Email = dc.Email " +
                                                                    "AND u.ProfileID = dc.ProfileId " +
                        "WHERE dc.Email = @Email " +
                              "AND StayStatus = @StayStatus " +
                              "AND dc.LoyaltyProfileID IS NOT NULL; " +

                        "SELECT STUFF( " +
                        "( " +
                            "SELECT ',' + x.ReservationNumber " +
                            "FROM " +
                            "( " +
                                "SELECT DISTINCT " +
                                       "grn.ReservationNumber " +
                                "FROM #GetReservationNum grn " +
                            ") AS x FOR XML PATH('') " +
                        "), 1, 1, '') AS ReservationNums; " +
                        "IF OBJECT_ID('tempdb..#GetReservationNum') IS NOT NULL " +
                            "DROP TABLE #GetReservationNum;";
            }
            else
            {
                query = "IF OBJECT_ID('tempdb..#GetReservationNum') IS NOT NULL " +
                        "DROP TABLE #GetReservationNum; " +

                        "DECLARE @Email NVARCHAR(50)= '" + Email + "'; " +
                        "DECLARE @Staystatus NVARCHAR(50)= '" + staystatus + "'; " +

                        "SELECT ReservationNumber " +
                        "INTO #GetReservationNum " +
                        "FROM dbo.D_CUSTOMER dc WITH(NOLOCK) " +
                             "INNER JOIN dbo.D_CUSTOMER_STAY dcs WITH(NOLOCK) ON dc.CustomerID = dcs.CustomerID " +
                             "INNER JOIN dbo.Users u WITH(NOLOCK) ON u.Email = dc.Email " +
                                                                    "AND u.ProfileID = dc.ProfileId " +
                        "WHERE dc.Email = @Email " +
                              "AND dc.LoyaltyProfileID IS NOT NULL; " +

                        "SELECT STUFF( " +
                        "( " +
                            "SELECT ',' + x.ReservationNumber " +
                            "FROM " +
                            "( " +
                                "SELECT DISTINCT " +
                                       "grn.ReservationNumber " +
                                "FROM #GetReservationNum grn " +
                            ") AS x FOR XML PATH('') " +
                        "), 1, 1, '') AS ReservationNums; " +
                        "IF OBJECT_ID('tempdb..#GetReservationNum') IS NOT NULL " +
                            "DROP TABLE #GetReservationNum;";
            }
            columnName = "ReservationNums";
            data.ReservationNumber = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;

        }

        /// <summary>
        /// This method will return the value in the entered column for the Email
        /// </summary>
        /// <param name="Email">Email of the data</param>
        /// <param name="column">Column of data to be returned</param>
        /// <returns></returns>
        public static string ReturnValueFromColumnByEmail(string customerID, string column)
        {
            string pmsCustomer;
            query = "SELECT dc.CustomerID, " +
                           "dc.FirstName, " +
                           "dc.LastName, " +
                           "dc.Email, " +
                          "dcs.ReservationNumber " +
                    "FROM dbo.D_CUSTOMER dc WITH (nolock) " +
                         "INNER JOIN dbo.D_CUSTOMER_STAY dcs WITH (nolock) ON dc.CustomerID = dcs.CustomerID " +
                    "WHERE dc.CustomerID = " + customerID;

            columnName = column;
            pmsCustomer = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomer;
        }

        /// <summary>
        /// Member with stay  
        /// </summary>
        /// <returns>CustomerID</returns>
        public static string ReturnMemberWithStay()
        {
            string pmsCustomer;
            query = "Select top 1 CustomerID from d_customer cust with (nolock) inner join D_customer_stay stay with (nolock) on cust.CustomerID = stay.CustomerID where exists ( select 1 from memberships mem with (nolock) where mem.MemberEmail = cust.email) and profileid is not null and staystatus in ( 'O','R', 'N', 'I' , 'C' ) order by cust.CustomerID desc";
            columnName = "CustomerID";
            pmsCustomer = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomer;
        }

        /// <summary>
        /// Guest with multiple records in PMS with same name and email
        /// Returns Cendyn17 email
        /// </summary>
        /// <returns>Email</returns>
        public static string ReturnGuestEmailInPMSSameNameAndEmail()
        {
            string pmsCustomer;
            query = "WITH tmpDCustomerQA " +
                         "AS (SELECT TOP 10 dc.Email, " +
                                            "dc.FirstName, " +
                                            "dc.LastName " +
                             "FROM dbo.D_CUSTOMER dc WITH (NOLOCK) " +
                                  "INNER JOIN dbo.PropertyMapping pm WITH (NOLOCK) ON dc.PropertyCode = pm.PropertyCode " +
                             "WHERE dc.SourceID = 1 " +
                                   "AND dc.Firstname NOT LIKE '%[0-9Mr . -]%' " +
                                   "AND dc.LastName NOT LIKE '%[0-9Mr . -]%' " +
                                   "AND dc.Emailstatus = 1 " +
                                   "AND NOT EXISTS " +
                    "( " +
                        "SELECT 1 " +
                        "FROM dbo.MemberShips ms WITH (NOLOCK) " +
                        "WHERE ms.MemberEmail = dc.Email " +
                    ") " +
                             "GROUP BY dc.Email, " +
                                      "dc.FirstName, " +
                                      "dc.LastName " +
                             "HAVING COUNT(*) > 1) " +
                         "SELECT TOP 1 dc.CustomerID, " +
                                      "dc.Email, " +
                                      "dc.FirstName, " +
                                      "dc.LastName " +
                         "FROM tmpDCustomerQA t WITH (NOLOCK) " +
                              "INNER JOIN dbo.D_CUSTOMER dc WITH (NOLOCK) ON t.Email = dc.Email; ";

            columnName = "CustomerID";
            pmsCustomer = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomer;
        }

        /// <summary>
        /// Guest with multiple records in PMS with same name and email
        /// Returns Cendyn17 email
        /// </summary>
        /// <returns>Email</returns>
        public static UserSignUpCRMAPI ReturnGuestEmailInPMSSameNameAndEmail_Test(UserSignUpCRMAPI data)
        {
            query = "WITH tmpDCustomerQA " +
                         "AS ( " +
                         "SELECT TOP 10 dc.Email, " +
                                       "dc.FirstName, " +
                                       "dc.LastName " +
                         "FROM dbo.D_CUSTOMER dc WITH (NOLOCK) " +
                              "INNER JOIN dbo.PropertyMapping pm WITH (NOLOCK) ON dc.PropertyCode = pm.PropertyCode " +
                         "WHERE dc.SourceID = 1 " +
                               "AND dc.Firstname NOT LIKE '%[0-9Mr . -]%' " +
                               "AND dc.LastName NOT LIKE '%[0-9Mr . -]%' " +
                               "AND dc.Emailstatus = 1 " +
                               "AND NOT EXISTS " +
                    "( " +
                        "SELECT 1 " +
                        "FROM dbo.MemberShips ms WITH (NOLOCK) " +
                        "WHERE ms.MemberEmail = dc.Email " +
                    ") " +
                         "GROUP BY dc.Email, " +
                                  "dc.FirstName, " +
                                  "dc.LastName " +
                         "HAVING COUNT(*) > 1 " +
                         "ORDER BY NEWID() DESC) " +
                         "SELECT TOP 1 dc.CustomerID, " +
                                      "dc.Email, " +
                                      "dc.FirstName, " +
                                      "dc.LastName " +
                         "FROM tmpDCustomerQA t WITH (NOLOCK) " +
                              "INNER JOIN dbo.D_CUSTOMER dc WITH (NOLOCK) ON t.Email = dc.Email;";

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
                            data.first_name = reader["FirstName"].ToString();
                            data.last_name = reader["LastName"].ToString();
                            data.email = reader["Email"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        /// <summary>
        /// Guest with multiple records in PMS with same email but different name
        /// Returns Cendyn17 email
        /// </summary>
        /// <returns>Email</returns>
        public static string ReturnGuestEmailInPMSSameEmailDifferentName()
        {
            string pmsCustomer;
            query = "WITH tmpDCustomerQA " +
                     "AS (SELECT TOP 10 dc.Email, " +
                                       "COUNT(DISTINCT dc.firstname) AS Firstname " +
                         "FROM dbo.D_CUSTOMER dc WITH (nolock) " +
                              "INNER JOIN dbo.D_CUSTOMER_STAY dcs WITH (NOLOCK) ON dc.CustomerID = dcs.CustomerID " +
                              "INNER JOIN dbo.PropertyMapping pm WITH (NOLOCK) ON dc.PropertyCode = pm.PropertyCode " +
                         "WHERE dc.Sourceid = 1 " +
                               "AND dc.Emailstatus = 1 " +
                               "AND ISNULL(CONVERT(VARCHAR(50), dc.LoyaltyProfileID), '') = '' " +
                               "AND dc.Email NOT LIKE '!!@%' " +
                               "AND dc.Email NOT LIKE '11@%' " +
                               "AND dc.Email LIKE '[^0-9]%' " +
                               "AND NOT EXISTS " +
                "( " +
                    "SELECT 1 " +
                    "FROM dbo.MemberShips ms WITH (nolock) " +
                    "WHERE ms.MemberEmail = dc.Email " +
                ") " +
                         "GROUP BY dc.Email " +
                         "HAVING COUNT(DISTINCT firstname) > 1 " +
                         "ORDER BY dc.Email) " +
                     "SELECT TOP 1 dc2.CustomerID, " +
                                  "dc2.Email, " +
                                  "dc2.FirstName, " +
                                  "dc2.LastName " +
                     "FROM d_customer dc2 WITH (nolock) " +
                          "INNER JOIN tmpDCustomerQA me WITH (NOLOCK) ON dc2.email = me.Email " +
                     "WHERE dc2.FirstName NOT LIKE '%[&]%' " +
                         "AND dc2.LastName LIKE '%[a-zA-Z]%';";


            columnName = "CustomerID";
            pmsCustomer = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomer;
        }

        /// <summary>
        /// Guest with multiple records in PMS with same email but different name
        /// Returns Cendyn17 email
        /// </summary>
        /// <returns>Email</returns>
        public static UserSignUpCRMAPI ReturnGuestEmailInPMSSameEmailDifferentName_Test(UserSignUpCRMAPI data)
        {
            query = "WITH tmpDCustomerQA " +
                     "AS (SELECT TOP 100 dc.Email, " +
                                       "COUNT(DISTINCT dc.firstname) AS Firstname " +
                         "FROM dbo.D_CUSTOMER dc WITH (nolock) " +
                              "INNER JOIN dbo.D_CUSTOMER_STAY dcs WITH (NOLOCK) ON dc.CustomerID = dcs.CustomerID " +
                              "INNER JOIN dbo.PropertyMapping pm WITH (NOLOCK) ON dc.PropertyCode = pm.PropertyCode " +
                         "WHERE dc.Sourceid = 1 " +
                               "AND dc.Emailstatus = 1 " +
                               "AND ISNULL(CONVERT(VARCHAR(50), dc.LoyaltyProfileID), '') = '' " +
                               "AND dc.Email NOT LIKE '!!@%' " +
                               "AND dc.Email NOT LIKE '11@%' " +
                               "AND dc.Email LIKE '[^0-9]%' " +
                               "AND NOT EXISTS " +
                "( " +
                    "SELECT 1 " +
                    "FROM dbo.MemberShips ms WITH (nolock) " +
                    "WHERE ms.MemberEmail = dc.Email " +
                ") " +
                         "GROUP BY dc.Email " +
                         "HAVING COUNT(DISTINCT firstname) > 1 " +
                         "ORDER BY dc.Email) " +
                     "SELECT dc2.CustomerID, " +
                                  "dc2.Email, " +
                                  "dc2.FirstName, " +
                                  "dc2.LastName " +
                     "FROM d_customer dc2 WITH (nolock) " +
                          "INNER JOIN tmpDCustomerQA me WITH (NOLOCK) ON dc2.email = me.Email " +
                     "WHERE dc2.FirstName NOT LIKE '%[&]%' " +
                         "AND dc2.LastName LIKE '%[a-zA-Z]%' " +
                    "AND ISNULL(dc2.FirstName, '') != '' " +
                    "AND ISNULL(dc2.LastName, '') != '' " +
                    "AND ISNULL(dc2.Email, '') != ''";


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
                            data.first_name = reader["FirstName"].ToString();
                            data.last_name = reader["LastName"].ToString();
                            data.email = reader["Email"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        /// <summary>
        /// Guest with multiple records in PMS with different name but matching email
        /// Returns Cendyn17 email
        /// </summary>
        /// <returns>Email</returns>
        public static string ReturnGuestEmailInPMSameEmailDifferentName()
        {
            string pmsCustomer;
            query = "SELECT TOP 10 * " +
                    "FROM dbo.D_CUSTOMER dc WITH (nolock) " +
                         "INNER JOIN dbo.D_CUSTOMER_STAY dcs WITH (nolock) ON dc.CustomerID = dcs.CustomerID " +
                    "WHERE NOT EXISTS " +
                    "( " +
                        "SELECT 1 " +
                        "FROM dbo.MemberShips ms WITH (nolock) " +
                        "WHERE ms.MemberEmail = dc.email " +
                    ") " +
                          "AND dc.ProfileId IS NULL " +
                          "AND dcs.StayStatus IN('O') " +
                         "AND dc.SourceID = 1 " +
                         "AND ISNULL(dc.Email, '') != '' " +
                    "ORDER BY dc.CustomerID DESC;";

            columnName = "CustomerID";
            pmsCustomer = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomer;
        }

        /// <summary>
        /// Guest with multiple records in PMS with different name but matching email
        /// Returns Cendyn17 email
        /// </summary>
        /// <returns>Email</returns>
        public static UserSignUpCRMAPI ReturnGuestEmailInPMSameEmailDifferentName_Test(UserSignUpCRMAPI data)
        {
            string pmsCustomer;
            query = "WITH CustomerStayandProperty AS ( " +
                    "SELECT TOP 100 dcs.CustomerID, " +
                                  "dcs.PropertyCode " +
                    "FROM dbo.D_CUSTOMER_STAY dcs WITH (NOLOCK) " +
                         "INNER JOIN dbo.PropertyMapping pm WITH (NOLOCK) ON dcs.PropertyCode = pm.PropertyCode " +
                    "WHERE dcs.StayStatus IN('O') " +
                    ") " +
                    "SELECT TOP 1 dc.CustomerID, " +
                           "dc.FirstName, " +
                           "dc.LastName, " +
                           "dc.Email " +
                    "FROM dbo.D_CUSTOMER dc WITH (NOLOCK) " +
                         "INNER JOIN CustomerStayandProperty csp WITH (NOLOCK) ON dc.CustomerID = csp.CustomerID " +
                    "WHERE NOT EXISTS " +
                    "( " +
                        "SELECT 1 " +
                        "FROM dbo.MemberShips ms WITH (nolock) " +
                        "WHERE ms.MemberEmail = dc.email " +
                    ") " +
                          "AND dc.ProfileId IS NULL " +
                          "AND dc.SourceID = 1 " +
                          "AND ISNULL(dc.Email, '') != '' " +
                    "ORDER BY dc.CustomerID DESC;";

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
                            data.first_name = reader["FirstName"].ToString();
                            data.last_name = reader["LastName"].ToString();
                            data.email = reader["Email"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            data.first_name = data.first_name + Helper.GetRandomAlphaNumericString(2);
            data.last_name = data.last_name + Helper.GetRandomAlphaNumericString(2);
            return data;
        }

        public static Users ReturnUserSignUpData_Test(string EmailAddress, Users data)
        {
            string email = EmailAddress.Trim();
            query = "SELECT dc.FirstName, " +
                    "dc.LastName, " +
                    "dc.Email, " +
                    "u.SignerName AS KioskName, " +
                    "u.KioskSource " +
            "FROM dbo.D_CUSTOMER dc WITH (NOLOCK) " +
                    "INNER JOIN dbo.Users u WITH (NOLOCK) ON dc.Email = u.Email " +
                    "LEFT JOIN dbo.KioskSignUpSource ksus WITH (NOLOCK) ON u.KioskSource = ksus.KioskCode " + "WHERE dc.Email = '" + email + "';";

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
                            data.firstName = reader["FirstName"].ToString();
                            data.lastName = reader["LastName"].ToString();
                            data.eMail = reader["Email"].ToString();
                            data.KioskName = reader["KioskName"].ToString();
                            data.KioskSource = reader["KioskSource"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static string ReturnUserFirstNameFromEmail(string EmailAddress)
        {
            string pmsCustomerFirstName;
            query = "SELECT dc.FirstName " +
                    "FROM dbo.D_CUSTOMER dc WITH (NOLOCK) " +
                    "WHERE dc.SourceID = 12 and dc.Email = '" + EmailAddress + "';";
            columnName = "FirstName";
            pmsCustomerFirstName = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomerFirstName;
        }

        public static string ReturnUserLastNameFromEmail(string EmailAddress)
        {
            string pmsCustomerLastName;
            query = "SELECT dc.LastName " +
                    "FROM dbo.D_CUSTOMER dc WITH (NOLOCK) " +
                    "WHERE dc.SourceID = 12 and dc.Email = '" + EmailAddress + "';";
            columnName = "LastName";
            pmsCustomerLastName = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomerLastName;
        }

        public static string ReturnUserEmail(string EmailAddress)
        {
            string pmsCustomerFirstName;
            query = "SELECT dc.Email " +
                    "FROM dbo.D_CUSTOMER dc WITH (NOLOCK) " +
                        "WHERE dc.SourceID = 12 " +
                        "AND dc.Email = '" + EmailAddress + "';";
            columnName = "Email";
            pmsCustomerFirstName = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomerFirstName;
        }

        public static string ReturnUserKioskName(string EmailAddress)
        {
            string pmsCustomerLastName;
            query = "SELECT u.SignerName " +
                    "FROM dbo.Users u WITH (NOLOCK) " +
                        "INNER JOIN dbo.KioskSignUpSource ksus WITH (NOLOCK) ON u.SignupCode = ksus.KioskCode " +
                    "WHERE u.Email = '" + EmailAddress + "';";
            columnName = "SignerName";
            pmsCustomerLastName = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomerLastName;
        }

        public static string ReturnUserSignUpCode(string EmailAddress)
        {
            string pmsCustomerLastName;
            query = "SELECT ksus.KioskCode " +
                    "FROM dbo.Users u WITH (NOLOCK) " +
                         "INNER JOIN dbo.KioskSignUpSource ksus WITH (NOLOCK) ON u.SignupCode = ksus.KioskCode " +
                    "WHERE u.Email = '" + EmailAddress + "';";
            columnName = "KioskCode";
            pmsCustomerLastName = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomerLastName;
        }

        public static string ReturnHasStayEmail(string column)
        {
            string pmsCustomerLastName;
            query = "SELECT TOP 100 dc.firstname, " +
                                   "dc.Lastname, " +
                                   "dc.Email, " +
                                   "dc.CustomerID " +
                    "FROM D_customer dc WITH (nolock) " +
                         "INNER JOIN dbo.D_CUSTOMER_STAY dcs WITH (NOLOCK) ON dc.CustomerID = dcs.CustomerID " +
                    "WHERE dc.sourceid = 1 " +
                          "AND isnull(dc.email, '') != '' " +
                          "AND isnull(dc.firstname, '') != '' " +
                          "AND isnull(dc.lastname, '') != '' " +
                          "AND dc.profileid IS NULL " +
                          "AND NOT EXISTS " +
                    "( " +
                        "SELECT 1 " +
                        "FROM dbo.MemberShips ms WITH (nolock) " +
                        "WHERE ms.MemberEmail = dc.email " +
                    ") " +
                    "GROUP BY dc.Firstname, " +
                             "dc.Lastname, " +
                             "dc.Email, " +
                             "dc.CustomerID " +
                    "HAVING COUNT(dcs.CustomerID) >= 1 " +
                    "ORDER BY dc.CustomerID DESC;";

            columnName = column;
            pmsCustomerLastName = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomerLastName;
        }

        public static Users ReturnHasStayCustomer_Test(Users data)
        {
            string pmsCustomerLastName;
            query = "SELECT TOP 100 dc.firstname, " +
                                   "dc.Lastname, " +
                                   "dc.Email, " +
                                   "dc.CustomerID " +
                    "FROM D_customer dc WITH (nolock) " +
                         "INNER JOIN dbo.D_CUSTOMER_STAY dcs WITH (NOLOCK) ON dc.CustomerID = dcs.CustomerID " +
                    "WHERE dc.sourceid = 1 " +
                          "AND isnull(dc.email, '') != '' " +
                          "AND isnull(dc.firstname, '') != '' " +
                          "AND isnull(dc.lastname, '') != '' " +
                          "AND dc.profileid IS NULL " +
                         "AND dc.Email LIKE '%@cendyn17.com' " +
                          "AND NOT EXISTS " +
                    "( " +
                        "SELECT 1 " +
                        "FROM dbo.MemberShips ms WITH (nolock) " +
                        "WHERE ms.MemberEmail = dc.email " +
                    ") " +
                    "GROUP BY dc.Firstname, " +
                             "dc.Lastname, " +
                             "dc.Email, " +
                             "dc.CustomerID " +
                    "HAVING COUNT(dcs.CustomerID) >= 1 " +
                    "ORDER BY dc.CustomerID DESC;";

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
                            data.CustomerID = reader["CustomerID"].ToString();
                            data.firstName = reader["FirstName"].ToString();
                            data.lastName = reader["LastName"].ToString();
                            data.eMail = reader["Email"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static string ReturnMemberAccExpirationDate(string EmailAddress)
        {
            string pmsCustomerAccExp;
            query = "SELECT CONVERT(VARCHAR(10), ms.ExpirationDate, 101) AS ExpirationDate " +
                        "FROM dbo.MemberShips ms " +
                    "WHERE ms.MemberEmail = '" + EmailAddress + "';";

            columnName = "ExpirationDate";
            pmsCustomerAccExp = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return pmsCustomerAccExp;
        }

        public static string ReturnDCustomerEmail(string EmailAddress)
        {
            string DCustomerEmail;
            query = "DECLARE @Email VARCHAR(255)= '" + EmailAddress + "'; " +
                    "SELECT dc.Email " +
                    "FROM dbo.D_CUSTOMER dc WITH (NOLOCK) " +
                    "WHERE dc.Email = CONVERT(VARCHAR(70), SUBSTRING(LTRIM(RTRIM(@Email)), 1, CHARINDEX('@', LTRIM(RTRIM(@Email))))+'cendyn17.com');";
            columnName = "Email";
            DCustomerEmail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return DCustomerEmail;
        }

        public static Users ReturnDCustomerEmail_Test(string EmailAddress, Users data)
        {
            query = "DECLARE @Email VARCHAR(255)= '" + EmailAddress + "'; " +
                    "SELECT  dc.firstname, " +
                             "dc.Lastname, " +
                             "dc.Email, " +
                             "dc.CustomerID " +
                    "FROM dbo.D_CUSTOMER dc WITH (NOLOCK) " +
                    "WHERE dc.Email = CONVERT(VARCHAR(70), SUBSTRING(LTRIM(RTRIM(@Email)), 1, CHARINDEX('@', LTRIM(RTRIM(@Email))))+'cendyn17.com');";


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
                            data.CustomerID = reader["CustomerID"].ToString();
                            data.firstName = reader["FirstName"].ToString();
                            data.lastName = reader["LastName"].ToString();
                            data.eMail = reader["Email"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static AdminVariable ReturnAwardID(string AwardName, AdminVariable data)
        {
            query = "SELECT TOP 1 la.ID AS AwardID, " +
                                 "la.AwardName, " +
                                 "la.AwardType " +
                    "FROM dbo.LoyaltyAward la WITH (NOLOCK) " +
                         "INNER JOIN dbo.L_AwardType lat WITH (NOLOCK) ON la.AwardType = lat.ID " +
                    "WHERE lat.Active = 1 " +
                          "AND la.Active = 1 " +
                          "AND lat.Name = '" + AwardName + "';";


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
                            data.AwardID = reader["AwardID"].ToString();
                            data.AwardName = reader["AwardName"].ToString();
                            data.AwardType = reader["AwardType"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users ReturnDCustomerData(Users data)
        {
            query = "SELECT TOP 1 dc.CustomerID, " +
                                 "dc.FirstName, " +
                                 "dc.LastName, " +
                                 "dc.Email, " +
                                 "dcs.SelectedLoyaltyMemberID " +
                    "FROM dbo.D_CUSTOMER_STAY dcs WITH (nolock) " +
                         "INNER JOIN dbo.D_CUSTOMER dc WITH (nolock) ON dcs.customerid = dc.customerid " +
                    "WHERE ISNULL(SelectedLoyaltyMemberID, '') != '' " +
                          "AND dc.SourceID = 1 " +
                          "AND ISNULL(dc.Email, '') != '' " +
                          "AND dc.Email IN " +
                    "( " +
                        "SELECT u.Email " +
                        "FROM dbo.Users AS u WITH (NOLOCK) " +
                    ") " +
                          "AND dcs.StayStatus NOT IN " +
                    "( " +
                        "SELECT dss.StayStatus " +
                        "FROM dbo.DIM_STAY_STATUS dss WITH (NOLOCK) " +
                        "WHERE dss.StayStatus NOT IN('O', 'R') " +
                    ") " +
                    "ORDER BY sourcestayid DESC;";


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
                            data.CustomerID = reader["CustomerID"].ToString();
                            data.firstName = reader["firstName"].ToString();
                            data.lastName = reader["lastName"].ToString();
                            data.eMail = reader["eMail"].ToString();
                            data.SelectedLoyaltyMemberID = reader["SelectedLoyaltyMemberID"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users ReturnDCustomerStayReservationData(Users data)
        {
            query = "SELECT ReservationNumber, " +
                           "dcs.StayStatus " +
                    "FROM dbo.D_CUSTOMER_STAY dcs WITH (NOLOCK) " +
                         "INNER JOIN dbo.D_CUSTOMER dc WITH (NOLOCK) ON dc.CustomerID = dcs.CustomerID " +
                    "WHERE dcS.SelectedLoyaltyMemberID = " + data.SelectedLoyaltyMemberID + ";";


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
                            data.ReservationNumber = reader["ReservationNumber"].ToString();
                            data.eMail = reader["Email"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static string ReturnMSCustomerEmail(string EmailAddress)
        {
            string MSCustomerEmail;
            query = "SELECT ms.MemberEmail " +
                    "FROM dbo.MemberShips ms WITH (NOLOCK) " +
                    "WHERE ms.MemberEmail = '" + EmailAddress + "';";
            columnName = "MemberEmail";
            MSCustomerEmail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return MSCustomerEmail;
        }

        public static string ReturnUCustomerEmail(string EmailAddress)
        {
            string UCustomerEmail;
            query = "SELECT u.Email " +
                    "FROM dbo.Users u WITH (NOLOCK) " +
                    "WHERE u.Username = '" + EmailAddress + "';";
            columnName = "Email";
            UCustomerEmail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return UCustomerEmail;
        }

        public static string ReturnNonPMSCustomerEmail()
        {
            string NonPMSCustomerEmail;
            query = "WITH Userss " +
                     "AS ( " +
                     "SELECT TOP 100 u.Email, " +
                                    "u.[Password], " +
                                    "u.RegistrationTime " +
                     "FROM dbo.Users u WITH (NOLOCK) " +
                     "WHERE u.RegistrationConfirmDate <> '' " +
                           "AND u.RegistrationConfirmDate IS NOT NULL " +
                           "AND u.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' " +
                     "ORDER BY u.RegistrationTime DESC) " +
                     "SELECT DISTINCT TOP 1 dc.Email, " +
                                           "dc.FirstName, " +
                                           "dc.LastName " +
                     "FROM dbo.D_CUSTOMER dc WITH (NOLOCK) " +
                          "INNER JOIN Userss us WITH (NOLOCK) ON us.Email = dc.Email " +
                     "WHERE dc.SourceID <> 1 " +
                           "AND dc.Email LIKE '%@cendyn17.com' " +
                           "AND dc.Email NOT LIKE '%test%' " +
                           "AND dc.Email NOT LIKE '%qa%' " +
                           "AND dc.Email NOT LIKE 'bg@%' " +
                           "AND ISNULL(dc.FirstName, '') != '' " +
                           "AND ISNULL(dc.LastName, '') != ''";

            columnName = "Email";
            NonPMSCustomerEmail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return NonPMSCustomerEmail;
        }

        public static string ReturnPMSCustomerEmail()
        {
            string PMSCustomerEmail;
            query = "SELECT TOP 1 u.Email FROM users U WITH (NOLOCK) INNER JOIN d_customer cust " +
                    " WITH(NOLOCK) ON cust.ProfileId = u.profileid INNER JOIN memberships msp WITH (NOLOCK) ON cust.profileid = msp.profileid INNER JOIN L_Data_Source_code sourcecode" +
                    " WITH(NOLOCK) ON Cust.Sourceid = sourcecode.sourceid WHERE SubSourceName LIKE '%PMS%' AND CAST(msp.MemberShipStatus AS VARCHAR) = '1' AND u.Locked <> 1 AND u.RegistrationConfirmDate <>'' AND u.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3'";
            columnName = "Email";
            PMSCustomerEmail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return PMSCustomerEmail;
        }

        public static string ReturnSignUpSourceCode()
        {
            string KioskName;
            query = "Select Top 50 KioskName from KioskSignUpSource;";
            columnName = "KioskName";
            KioskName = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return KioskName;
        }

        /// <summary>
        /// Identify PMS profile who has stay   and is not a member
        /// Returns Cendyn17 email
        /// </summary>
        /// <returns>Email</returns>
        public static Users ReturnGuestEmailInPMSProfileisNotMember(Users data)
        {
            string pmsCustomer;
            query = "Select top 100 Firstname , Lastname , email, *from d_customer cust with(nolock)" +
                    " inner join L_Data_Source_code sourcecode  with(nolock) on Cust.Sourceid = sourcecode.sourceid" +
                    " inner join D_customer_stay stay with(nolock) on stay.customerid = cust.customerid" +
                    " where SubSourceName like '%PMS%'  and not exists(Select  email from Users U with(nolock) where cust.email = U.Email)" +
                    " and Profileid is null and Firstname is not null and email is not null";

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
                            data.CustomerID = reader["CustomerID"].ToString();
                            data.firstName = reader["FirstName"].ToString();
                            data.lastName = reader["LastName"].ToString();
                            data.eMail = reader["email"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static string ReturnMultipleRecordforSearch(string columnName)
        {
            string data;
            query = "SELECT TOP 2 M.LoyaltyMemberID,M.CellPhoneNumber,M.MemberFirstName, M.MemberLastName, M.MemberEmail, P.Company " +
                    "FROM MemberShips M  WITH(NOLOCK)  " +
                    "INNER JOIN Profile P WITH(NOLOCK) ON M.LoyaltyMemberID = P.LoyaltyMemberID " +
                    "WHERE M.MemberFirstName LIKE '_%' and  M.MemberLastName LIKE '_%' and M.CellPhoneNumber <>''";
            //where P.Company <> '' and M.CellPhoneNumber <> '' ";
            data = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static string ReturnCommonDataForSearch(string columnName)
        {
            string data;
            query = "Select * from MemberShips M  INNER JOIN Profile P on M.LoyaltyMemberID = P.LoyaltyMemberID where M.CellPhoneNumber <> ''  ";
            data = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static string ReturnSocialMediaUser(string columnName)
        {
            string data;
            query = "Select * from MemberShips M  INNER JOIN Profile P on M.LoyaltyMemberID = P.LoyaltyMemberID where P.Company <> '' and M.CellPhoneNumber <> ''  ";
            data = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static string ReturnMembership(string columnName, string Email)
        {
            string data;
            string email = Email.Trim();
            query = "Select LoyaltyMemberId,MembershipLevel,  * from memberships where memberemail ='" + email + "'; ";
            data = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static string ReturnIsSubscriptionValue(string columnName, string Email)
        {
            string data;
            query = "select * from email_subscription_status where email_address = '" + Email + "'; ";
            data = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static UserCredential ReturnLoyaltyUserLoginCredentials(UserCredential data, string Casetype_Email, string Casetype_Password)
        {
            query =
                    "DECLARE @CaseType_Email VARCHAR(25)= '" + Casetype_Email + "'; " +
                    "DECLARE @CaseType_Password VARCHAR(25)= '" + Casetype_Password + "'; " +
                    "SELECT TOP 1 ms.MemberID member_id, " +
                                        "CASE " +
                                            "WHEN @CaseType_Email = 'Invalid' " +
                                            "THEN CONVERT(VARCHAR(70), SUBSTRING(LTRIM(RTRIM(u.Username)), 0, CHARINDEX('@', LTRIM(RTRIM(u.Username))))+CONVERT(VARCHAR(20), CONVERT(DATE, GETDATE()), 112)+'@cendyn17.com') " +
                                            "WHEN @CaseType_Email = 'Valid_Space' " +
                                            "THEN ' '+u.Username+' ' " +
                                            "ELSE u.Username " +
                                        "END AS login_id, " +
                                        "CASE " +
                                            "WHEN @CaseType_Password = 'Invalid' " +
                                            "THEN 'Cendyn12345$' " +
                                            "ELSE 'Cendyn123$' " +
                                        "END AS profile_password, " +
                                        "CASE " +
                                            "WHEN @CaseType_Email = 'Invalid' " +
                                            "THEN CONVERT(VARCHAR(70), SUBSTRING(LTRIM(RTRIM(u.Email)), 0, CHARINDEX('@', LTRIM(RTRIM(u.Email))))+CONVERT(VARCHAR(20), CONVERT(DATE, GETDATE()), 112)+'@cendyn17.com') " +
                                            "WHEN @CaseType_Email = 'Valid_Space' " +
                                            "THEN ' '+u.Email+' ' " +
                                            "ELSE u.Email " +
                                        "END AS profile_email " +
                        "FROM dbo.Users u WITH (NOLOCK) " +
                                "INNER JOIN dbo.MemberShips ms WITH (NOLOCK) ON ms.profileid = u.ProfileID " +
                                                                            "AND ms.MemberEmail = u.Email " +
                        "WHERE u.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' " +
                                "AND u.Email NOT LIKE '%qatestAuto%' " +
                                "AND u.Email NOT LIKE '%test%' " +
                                "AND u.Email NOT LIKE '%qa%' " +
                                "AND ISNULL(u.RegistrationConfirmDate, '') = (CASE " +
                                                                                "WHEN @CaseType_Email = 'IsBlank' " +
                                                                                "THEN '' " +
                                                                                "ELSE u.RegistrationConfirmDate " +
                                                                            "END) " +
                                "AND (ABS(CAST((BINARY_CHECKSUM(*) * RAND()) AS INT)) % 1000) <= 100" +
                                "AND RIGHT(u.Email, LEN(u.Email)-CHARINDEX('@', u.Email)) = 'cendyn17.com';";

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
                            data.member_id = reader["member_id"].ToString();
                            data.login_id = reader["login_id"].ToString();
                            data.profile_password = reader["profile_password"].ToString();
                            data.profile_email = reader["profile_email"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static string ReturnResponseJsonText(string EmailAddress, string MasterPropertyCode)
        {
            query =
                    "SELECT Top 1 rtl.ResponseBody " +
                    "FROM [QHB-CRMDB004.CENTRALSERVICES.LOCAL].[CRMAPILOG].[dbo].[RESTAPITransactionLog] rtl WITH (NOLOCK) " +
                    "WHERE rtl.RequestBody LIKE '%" + EmailAddress + "%' " +
                          "AND rtl.MasterProperyCode = '" + MasterPropertyCode + "' " +
                          "AND rtl.RequestUri LIKE '%Account/Login%' " +
                          "AND ISNULL(CONVERT(NVARCHAR(50), rtl.ElmahErrorID), '') = '' " +
                    "ORDER BY rtl.TransactionID DESC;";

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
                            JSONResponseBody = reader["ResponseBody"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return JSONResponseBody;
        }

        public static string ReturnResponseJsonText_V2(string EmailAddress, string MasterPropertyCode, string RequestType)
        {
            query =
                    "DECLARE @APIType NVARCHAR(50) = '" + RequestType + "'; " +
                    "DECLARE @RequestUri NVARCHAR(50); " +

                    "IF @APIType = 'Login' " +
                    "BEGIN " +
                        "SET @RequestUri = '%Account/Login%' " +
                    "END " +
                    "IF @APIType = 'SignUp' " +
                    "BEGIN " +
                        "SET @RequestUri = '%/Account/Register%' " +
                    "END " +

                    "SELECT Top 1 rtl.ResponseBody " +
                                        "FROM [QHB-CRMDB004.CENTRALSERVICES.LOCAL].[CRMAPILOG].[dbo].[RESTAPITransactionLog] rtl WITH (NOLOCK) " +
                                        "WHERE rtl.RequestBody LIKE '%" + EmailAddress + "%' " +
                                              "AND rtl.MasterProperyCode = '" + MasterPropertyCode + "' " +
                                              "AND rtl.RequestUri LIKE @RequestUri " +
                                              "AND ISNULL(CONVERT(NVARCHAR(50), rtl.ElmahErrorID), '') = '' " +
                                        "ORDER BY rtl.TransactionID DESC;";

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
                            JSONResponseBody = reader["ResponseBody"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return JSONResponseBody;
        }

        public static Users ReturnMemberTransactionDetails(string EmailAddress, Users data)
        {

            query = "Select Atc.ReasonCode, Atc.points, Atc.MasterPropertyCode," +
                    " Atc.CommentsInternal, Atc.CommentsToCustomer, Atc.EmailSent from D_Customer as DC" +
                    " with(nolock) inner join AdminAccountTransaction Atc with(nolock)" +
                    " on DC.ProfileId = Atc.ProfileId where DC.Email = '" + EmailAddress + "'";

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
                            data.Points = reader["points"].ToString();
                            data.CommentsInternal = reader["CommentsInternal"].ToString();
                            data.CommentsToCustomer = reader["CommentsToCustomer"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users ReturnMemberAddTransactionDetails(string EmailAddress, string comments, Users data)
        {
            query = "Select Atc.points,Atc.Transactionby from D_Customer as DC" +
                    " with(nolock) inner join AdminAccountTransaction Atc with(nolock)" +
                    " on DC.ProfileId = Atc.ProfileId where DC.Email = '" + EmailAddress + "' and atc.CommentsInternal = '" + comments + "'";

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
                            data.Points = reader["points"].ToString();
                            data.Transactionby = reader["Transactionby"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static void UpdateRegistrationConfirmDate(string ProjectName, string EmailAdd)
        {
            query =
                    "DECLARE @Expiration DATE; " +
                    "DECLARE @ProfileID INT; " +
                    "DECLARE @RegistrationDate DATE= GETDATE(); " +
                    "DECLARE @ProjectName VARCHAR(50)= '" + ProjectName + "'; " +
                    "SELECT @ProfileID = u.ProfileID " +
                    "FROM dbo.Users u WITH (NOLOCK) " +
                         "INNER JOIN dbo.MemberShips ms WITH (NOLOCK) ON ms.profileid = u.ProfileID " +
                                                                        "AND ms.MemberEmail = u.Email " +
                    "WHERE u.Email = '" + EmailAdd + "'; " +

                    "IF @ProjectName IN('HotelIcon', 'PublicHotel', 'Iberostar', 'Adare_Manor', 'Loews') " +
                        "BEGIN " +
                            "SET @Expiration = CONVERT(VARCHAR(100), CONVERT(DATE, DATEADD(MONTH, 12, @RegistrationDate))); " +
                        "END; " +
                    "IF @ProjectName = ('NYLO') " +
                        "BEGIN " +
                            "SET @Expiration = CONVERT(VARCHAR(100), CONVERT(DATE, DATEADD(MONTH, 18, @RegistrationDate))); " +
                        "END; " +
                    "IF @ProjectName IN('Fraser', 'HotelVic') " +
                        "BEGIN " +
                            "SET @Expiration = CONVERT(VARCHAR(100), CONVERT(DATE, DATEADD(month, ((YEAR(@RegistrationDate) - 1900) * 12) + MONTH(@RegistrationDate), -1))); " +
                        "END; " +
                    "IF @ProjectName IN('IndependentCollection', 'Origami') " +
                        "BEGIN " +
                            "SET @Expiration = DATEADD(yy, DATEDIFF(yy, 0, CONVERT(DATE, DATEADD(MONTH, 24, GETDATE()))), 0); " +
                        "END; " +
                    "EXEC dbo.[_tmp_UpdateUserRegisterTime] " +
                         "@profileId = @ProfileID," +
                         "@regiterTime = @RegistrationDate, " +
                         "@ExpirationDate = @Expiration;";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    command.ExecuteReader();
                }
                connection.Close();
            }
        }

        public static Users GeneratePasswordRecoveryLink(string EmailAddress, Users data)
        {
            query =
                "SELECT TOP 1 pr.PasswordRecoveryToken " +
                    "FROM dbo.PasswordRecovery pr WITH (NOLOCK) " +
                         "INNER JOIN dbo.Users u WITH (NOLOCK) ON pr.UserId = u.Id " +
                    "WHERE u.Email = '" + EmailAddress + "' " +
                    "ORDER BY pr.Id DESC;";
            columnName = "Token";
            data.Token = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users GetDataAsPerMemberLevel(string memberlevel, Users data)
        {

            query = "select Distinct Top 1 Memberemail, Expirationdate, loyaltyMemberid, m.insertdate from Memberships as m with(nolock) " +
                    "inner join Users u with(nolock) on m.MemberEmail = u.Email " +
                    "and RegistrationConfirmDate <> '' and u.Locked <> 1 and MembershipLevel='" + memberlevel + "'and MemberShipStatus = 1 " +
                    "and memberemail like '%@cendyn17.com' and Expirationdate is not null AND M.loyaltyMemberid IS NOT NULL AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3'";

            if (data != null && !string.IsNullOrEmpty(data.MemberEmail))
                query += " AND memberemail != '" + data.MemberEmail + "' ";

            query += " ORDER BY m.insertdate desc ";

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
                            data.MemberEmail = reader["Memberemail"].ToString();
                            data.ExpirationDate = reader["ExpirationDate"].ToString();
                            data.MemberShipId = reader["loyaltyMemberid"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users GetExpirationDate(string email, Users data)
        {
            query = "SELECT TOP 1 ExpirationDate FROM Memberships WITH(NOLOCK) where MemberEmail ='" + email.Trim() + "'";
            columnName = "ExpirationDate";
            data.ExpirationDate = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users GetDataPerStatus(string status, Users data, string Projectname)
        {
            query = "SELECT TOP 1 U.email, PLD.Balance, cust.membership from users U WITH (NOLOCK) " +
                    "INNER JOIN ProfileLoyaltyDetail PLd WITH(NOLOCK) ON PLD.ProfileID = U.ProfileID " +
                    "INNER JOIN D_customer cust WITH (nolock) ON cust.profileid = PLD.ProfileID " +
                    "INNER JOIN L_MembershipStatus MS WITH(NOLOCK) ON MS.ID = PLD.MembershipStatus " +
                    "WHERE PlD.MemberType IS NOT NULL AND U.Email Like '%@cendyn17.com' AND MS.MembershipStatus = '" + status + "'";

            if (status=="Active")
                query += " AND PLD.Balance > 0";

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
                            data.eMail = reader["email"].ToString();
                            data.Balance = reader["Balance"].ToString();
                            data.Membership = reader["membership"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users GetMemberLogStatus(string email, Users data)
        {
            query = "SELECT MSL.*FROM MemberStatusLog MSL WITH (nolock)" +
                    "INNER JOIN D_customer cust WITH (nolock) ON cust.profileid = MSL.Profileid " +
                    "INNER JOIN L_DATA_SOURCE_CODE SRC WITH (nolock) ON cust.Sourceid = SRC.Sourceid" +
                    " WHERE SubsourceName = 'Guest Loyalty'" +
                    "AND email = '" + email + "'";

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
                            data.Status = reader["Status"].ToString();
                            data.UpdatedBy = reader["UpdatedBy"].ToString();
                            data.InsertDate = reader["InsertDate"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users GetProfilePerStatus(string status, Users data)
        {
            switch (status)
            {
                case "Social media user":
                    query = "SELECT TOP 1 u.email,m.Membershiplevel FROM Users u WITH (nolock) INNER JOIN Memberships m on m.Memberemail = u.email " +
                            " INNER JOIN D_Customer d on d.Email = u.email " +
                            " WHERE socialsource IS NOT NULL AND MemberShipStatus = 1 AND MembershipLevel IS NOT NULL AND u.RegistrationConfirmDate IS NOT NULL";

                    columnName = "email";
                    break;
                case "Loyalty User":
                    query = "SELECT Distinct TOP 1 u.email,m.Membershiplevel FROM Users u WITH (nolock) inner join Memberships m on m.Memberemail = u.email inner join D_Customer AS dc on dc.Email = m.Memberemail" +
                            " WHERE socialsource IS NULL AND MemberShipStatus = 1 AND MembershipLevel IS NOT NULL AND RegistrationSrc = 'Loyalty' AND Kiosksource IS NULL AND u.RegistrationConfirmDate IS NOT NULL and u.Email <> ''";

                    columnName = "email";
                    break;

                case "Kiosk User":
                    query = "SELECT Distinct TOP 10 u.email,m.Membershiplevel,m.MemberID FROM Users u WITH(nolock) inner join Memberships m on m.Memberemail = u.email inner join D_Customer AS dc on dc.Email = m.Memberemail WHERE Kiosksource IS NOT NULL AND MembershipLevel IS NOT NULL AND u.RegistrationConfirmDate IS NOT NULL";
                    columnName = "email";
                    break;
            }
            data.eMail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users ReturnProfileData(string email, Users data)
        {
            query = "select  c.Firstname,c.Lastname ,c.membership ,m.MemberShipStatus,m.Membershiplevel,c.CustomerID,m.birthday,c.ProfileId from [dbo].[D_CUSTOMER] c left join Memberships m on m.MemberEmail = c.email where email ='" + email + "' and c.membership <>''";
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
                            data.firstName = reader["Firstname"].ToString();
                            data.lastName = reader["Lastname"].ToString();
                            data.Membership = reader["membership"].ToString();
                            data.Membershiplevel = reader["Membershiplevel"].ToString();
                            data.MemberShipStatus = reader["MemberShipStatus"].ToString();
                            data.Birthday = reader["birthday"].ToString();
                            data.CustomerID = reader["CustomerID"].ToString();
                            data.ProfileId = reader["ProfileId"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users ReturnPMSUserData(Users data)
        {
            query = " SELECT DISTINCT TOP 1 C.email, C.FirstName, C.LastName " +
                    " FROM D_CUSTOMER AS C WITH(NOLOCK) " +
                    " INNER JOIN D_CUSTOMER_STAY AS S WITH(NOLOCK)  ON S.CustomerID = C.customerID " +
                    " INNER JOIN Users AS U WITH(NOLOCK) ON U.ProfileID != C.ProfileId and C.EMAIL IS NOT NULL";

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
                            data.firstName = reader["FirstName"].ToString();
                            data.lastName = reader["LastName"].ToString();
                            data.eMail = reader["email"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users GetNonActiveUser(Users data)
        {
            query = "SELECT TOP 1 email FROM Users u WITH (nolock) INNER JOIN MemberShips m WITH(nolock) ON u.Profileid = m.Profileid WHERE RegistrationConfirmDate is null ORDER BY u.Profileid DESC";
            columnName = "email";
            data.eMail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users GetActiveUserWithSufficientPoints(Users data)
        {
            query = "select top 2 m.MemberEmail from ProfileLoyaltyDetail p with (nolock) inner join " +
                " memberships m with (nolock) on p.profileid = m.profileid where p.memberPoints > 0 and m.membershipstatus = 1 ";
            columnName = "MemberEmail";
            data.MemberEmail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users ReturnRegistrationConfirmDate(Users data, string Email)
        {
            query = "select RegistrationConfirmDate, * from Users where email ='" + Email + "'";
            columnName = "RegistrationConfirmDate";
            data.RegistrationConfirmDate = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users ReturnSignUpPMSCustomerWithStay(Users data)
        {
            //query = "Select DISTINCT top 1 c.CustomerID, c.email,c.FirstName,c.LastName from D_Customer as c with(nolock) where CustomerId in (Select Customerid from D_Customer_Stay as s with(nolock) where s.CustomerID = c.CustomerID) AND c.email " +
            //        "In(Select Email from Users as u with(nolock) where u.ProfileID = c.ProfileId and RegistrationConfirmDate <> '') and Email is NOT NULL and c.SourceId = 1";
            query = "SELECT TOP 1 C.CustomerID, C.email, C.FirstName, C.LastName, PD.MembershipStatus " +
                    "FROM D_Customer AS C WITH(NOLOCK) " +
                    "INNER JOIN D_Customer_Stay AS S WITH(NOLOCK) ON S.CustomerID = C.CustomerID " +
                    "INNER JOIN Users AS U WITH(NOLOCK) ON U.ProfileID = C.ProfileId AND U.RegistrationConfirmDate IS NOT NULL " +
                    "INNER JOIN  ProfileLoyaltyDetail PD WITH(NOLOCK) ON U.ProfileID = PD.ProfileID " +
                    "INNER JOIN Memberships M WITH(NOLOCK) ON M.ProfileID = C.ProfileID " +
                    "WHERE C.Email IS NOT NULL " +
                    "AND C.SourceId = 1 AND M.loyaltymemberid IS NOT NULL " +
                    "AND PD.MembershipStatus = 1 AND s.DepartureDate IS NOT NULL order by NEWID()";
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
                            data.CustomerID = reader["CustomerID"].ToString();
                            data.firstName = reader["FirstName"].ToString();
                            data.lastName = reader["LastName"].ToString();
                            data.eMail = reader["Email"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users ReturnMemberSearchAsPerDate(Users data, string DepartureFrom, string DepartureTo, string firstname, string lastname)
        {
            query = "SELECT TOP 1 U.email, dcu.FirstName, dcu.LastName, dcs.ArrivalDate, dcs.DepartureDate, DCU.PropertyCode,Dcs.RateType , dcu.membership " +
                    "FROM D_CUSTOMER_STAY dcs WITH(NOLOCK) " +
                    "INNER JOIN d_customer dcu ON dcs.CustomerID = dcu.CustomerID " +
                    "INNER JOIN users U WITH(NOLOCK) ON U.ProfileID = dcu.ProfileId " +
                    "INNER JOIN ProfileLoyaltyDetail PLd WITH(NOLOCK) ON PLD.ProfileID = U.ProfileID " +
                    "INNER JOIN L_MembershipStatus MS WITH(NOLOCK) ON MS.ID = PLD.MembershipStatus " +
                    "WHERE (MS.MembershipStatus = 'Active' AND dcs.DepartureDate between '" + DepartureFrom + "' and '" + DepartureTo + "') ";
            if (!firstname.Equals(" "))
            {
                query += " OR dcu.FirstName = '" + firstname + "' ";
            }

            if (!lastname.Equals(" "))
            {
                query += " OR dcu.LastName = '" + lastname + "' ";
            }

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
                            data.eMail = reader["email"].ToString();
                            data.firstName = reader["FirstName"].ToString();
                            data.lastName = reader["LastName"].ToString();
                            data.ArrivalDate = reader["ArrivalDate"].ToString();
                            data.DepartureDate = reader["DepartureDate"].ToString();
                            data.PropertyCode = reader["PropertyCode"].ToString();
                            data.RateType = reader["RateType"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users ReturnMemberSearchAsPerFirstname(Users data, string firstname)
        {
            query = "SELECT TOP 1 ms.MemberFirstName AS FirstName, " +
                     "ms.MemberLastName AS LastName " +
                     "FROM dbo.MemberShips ms WITH (NOLOCK) " +
                      "WHERE ISNULL(ms.MemberFirstName, '') <> '' " +
                      "AND ms.MemberFirstName NOT LIKE '%[A-Z]%' " +
                      "AND ms.MemberFirstName NOT LIKE '%[0-9]%' " +
                      "AND ISNULL(ms.MemberEmail, '') <> '' " +
                      "ORDER BY NEWID() Desc; ";

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
                            data.firstName = reader["FirstName"].ToString();
                            data.lastName = reader["LastName"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users ReturnDCustomerStayData(Users data)
        {
            query = " SELECT DISTINCT TOP 1 DC.Email, AT.SourceReferenceNumber FROM D_CUSTOMER AS DC WITH(NOLOCK) " +
                " INNER JOIN AccountTransaction AS AT WITH(NOLOCK) ON AT.profileID = DC.profileID " +
                " INNER JOIN Memberships AS M WITH(NOLOCK) ON M.memberemail = DC.email " +
                " WHERE DC.EMAIL IS NOT NULL AND M.MemberShipStatus = 1";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        command.CommandTimeout = 60;
                        while (reader.Read())
                        {
                            data.ReservationNumber = reader["SourceReferenceNumber"].ToString();
                            data.eMail = reader["Email"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users IdentifyHotel(Users data)
        {

            query = "SELECT TOP 1 pm.PropertyName, pm.MasterPropertyCode FROM PropertyMapping pm WITH (NOLOCK) " +
                    "ORDER BY NEWID() Desc";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.PropertyName = reader["PropertyName"].ToString();
                            data.PropertyCode = reader["MasterPropertyCode"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users ReturnReservationNumber(Users data)
        {

            query = "SELECT TOP 1 U.email, PLD.Balance, dcu.membership, dcs.ReservationNumber " +
                    "FROM D_CUSTOMER_STAY dcs WITH(NOLOCK) " +
                    "INNER JOIN d_customer dcu ON dcs.CustomerID = dcu.CustomerID " +
                    "INNER JOIN users U WITH(NOLOCK) ON U.ProfileID = dcu.ProfileId " +
                    "INNER JOIN ProfileLoyaltyDetail PLd WITH(NOLOCK) ON PLD.ProfileID = U.ProfileID " +
                    "INNER JOIN L_MembershipStatus MS WITH(NOLOCK) ON MS.ID = PLD.MembershipStatus " +
                    " WHERE MS.MembershipStatus = 'Active' AND dcs.ReservationNumber IS NOT NULL ";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.eMail = reader["email"].ToString();
                            data.Membership = reader["membership"].ToString();
                            data.ReservationNumber = reader["ReservationNumber"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users ReturnEmail_WithStay(Users data)
        {
            query = " select Top 1  Email from Users U with (nolock) inner join AccountTransaction AT with(nolock) on AT.ProfileID = u.ProfileID inner join MemberShips ms with(nolock) on u.email = ms.memberemail where ms.membershipstatus = 1";
            columnName = "Email";
            data.eMail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users ReturnEmail_WithActiveAnd100Points(Users data, int balance)
        {
            query = "select top 1 m.MemberEmail from MemberShips as m with(nolock) " +
                    "inner join ProfileLoyaltyDetail PLD with(nolock) on m.ProfileId = PLD.ProfileId " +
                    "where PLD.Balance >" + balance + " and m.MemberPassword = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' order by PLD.Balance asc";

            columnName = "MemberEmail";
            data.MemberEmail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users Return_DataAsPerEmail_Stay(Users data, string email)
        {
            query = "Select m.ProfileID, TransactionReference, ReferenceTransactionStatus, ArrivalDate, DepartureDate," +
                    " MasterPropertyCode, RateCode from Memberships AS m INNER JOIN AccountTransaction AS a ON m.ProfileID = a.ProfileID" +
                    " where m.memberemail ='" + email + "'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.ArrivalDate = reader["ArrivalDate"].ToString();
                            data.DepartureDate = reader["DepartureDate"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users Return_AutoUpgradeDowngrade_Status(Users data, string setBy, string MemberLevel1, string MemberLevel2)
        {
            query = "select top 1 m.MemberEmail from MembershipLevelAndStatusLog As ms with(nolock) " +
                   " inner join memberships as m with(nolock) on ms.profileId = m.profileId " +
                    "where ms.SetBy = '" + setBy + "' and ms.PreviousMemberLevel = '" + MemberLevel1 + "' and ms.MembershipLevel = '" + MemberLevel2 + "' and m.memberemail like '%@cendyn17.com'";

            columnName = "MemberEmail";
            data.MemberEmail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users ReturnEmail_WithMaximumAdminUpdates(Users data)
        {

            query = " select top 1 ms.MemberEmail,count(*) As numberOfCount " +
                    " from Loyalty_AdminChange_Log AS Aclogs with(nolock) inner join MemberShips As ms with(nolock)on Aclogs.ProfileID = ms.ProfileID " +
                    " inner join Users As u with(nolock) on u.ProfileID = ms.ProfileID where u.RegistrationConfirmDate IS NOT NULL " +
                    " and ms.MemberEmail like '%@cendyn17.com' group by ms.MemberEmail HAVING COUNT(*) > 30 AND COUNT(*) < 50 ";
            columnName = "MemberEmail";
            data.MemberEmail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users ReturnEmail_WithMaximumMyStays(Users data)
        {
            query = "SELECT TOP 2 m.MemberEmail FROM AccountTransaction AS Aclogs WITH(NoLock) " +
            "INNER JOIN Memberships As m WITH(NoLock) on Aclogs.ProfileID = m.ProfileID " +
            "LEFT JOIN  ProfileLoyaltyDetail PD WITH(NOLOCK) ON M.ProfileID = PD.ProfileID " +
            "INNER JOIN Users U WITH(NOLOCK) ON M.MemberEmail = U.Email " +
            "WHERE M.MemberEmail LIKE '%@cendyn17.com' AND U.RegistrationConfirmDate IS NOT NULL AND M.loyaltyMemberid IS NOT NULL " +
            "AND PD.MembershipStatus = 1 " +
            "GROUP BY m.MemberEmail HAVING COUNT(*) > 5 AND COUNT(*) < 50 ";

            columnName = "MemberEmail";
            data.MemberEmail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users GetAdminUpdatesData(Users data)
        {
            query = "select * from [dbo].[MembershipLevelAndStatusLog]";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.SetBy = reader["SetBy"].ToString();
                            data.InsertDate = reader["InsertDate"].ToString();
                            data.Membershiplevel = reader["Membershiplevel"].ToString();
                            data.PreviousMembershiplevel = reader["PreviousMemberLevel"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users GetAutoAddedUsers(Users data)
        {
            query = " SELECT DISTINCT TOP 1 DC.Email FROM D_CUSTOMER AS DC WITH(NOLOCK) " +
                      " INNER JOIN D_CUSTOMER_STAY AS DCS WITH(NOLOCK) ON DCS.CustomerID = DC.CustomerID " +
                      " INNER JOIN Users AS U WITH(NOLOCK) ON U.ProfileID = DC.ProfileId AND U.RegistrationConfirmDate <> '' " +
                      " INNER JOIN Memberships AS M WITH(NOLOCK) ON M.ProfileID = DC.ProfileId " +
                      " WHERE DC.Email Like '%_@Cendyn17.com' " +
                      " AND DC.EMAIL = M.MemberEmail ";
            columnName = "Email";
            data.eMail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users GetRandomAwardName(Users data)
        {
            query = "select TOP 1 lw.AwardName FROM LoyaltyAward lw with(nolock) where IsAutomatic = 0 and Active = 1 and Enddate > getdate() order by NEWID() DESC";
            columnName = "AwardName";
            data.AwardName = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users GetUsers(Users data)
        {
            query = "Select DISTINCT top 1 MemberEmail from Memberships where MemberEmail Like '%_@cendyn17.com'";

            columnName = "MemberEmail";
            data.MemberEmail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users GetAdminChange_Type(Users data, string Change)
        {
            query = "Select Id from L_adminChange with(nolock) where Change = '" + Change + "'";
            columnName = "Id";
            data.ID = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users GetAdminChange_Log(Users data, string email)
        {
            string query1 = "select top 1 dc.Email, ChangeTypeId from Loyalty_AdminChange_Log As m with(nolock) " +
                            "inner join D_Customer as dc with(nolock) on m.ProfileId = dc.ProfileId where dc.Email = '" + email + "' ORDER BY LogDate DESC";

            columnName = "ChangeTypeId";
            data.ChangeTypeId = DBHelper.ExecuteQueryAndReturnColumn(query1, columnName);
            return data;
        }

        public static UserSignUpCRMAPI GetCustomerSignUpAPIData(string stayStatus, UserSignUpCRMAPI data)
        {
            query = "EXEC dbo.tmpQACreateXMLData @StayStatus = '" + stayStatus + "';";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 120;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.first_name = reader["FirstName"].ToString();
                            data.last_name = reader["LastName"].ToString();
                            data.email = reader["Email"].ToString();
                            data.login_id = reader["Email"].ToString();
                            data.Password = reader["Password"].ToString();
                            data.Salutation = reader["Salutation"].ToString();
                            data.language = reader["Languages"].ToString();
                            data.date_of_birth = (Convert.ToDateTime(reader["Birthday"])).ToString("MM/dd/yyyy");
                            data.HasMembership = reader["HasMembership"].ToString();
                            data.NeedActivate = reader["NeedActivate"].ToString();
                            data.NewsletterSubscription = reader["NewsletterSubscription"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static UserSignUpCRMAPI GetDummySignUpAPIData(UserSignUpCRMAPI data)
        {
            query = "SELECT TOP 1 Salutation, " +
                           "lpg.FirstName, " +
                           "lpg.LastName, " +
                           "lpg.Email, " +
                           "lpg.Password, " +
                           "lpg.Languages, " +
                           "lpg.Birthday, " +
                           "lpg.HasMembership, " +
                           "lpg.NeedActivate, " +
                           "lpg.NewsletterSubscription " +
                    "FROM dbo.LOY_ProfileGenerator lpg " +
                    "where lpg.IsUsed = 0 "+
                    "ORDER BY NEWID()";

            using (SqlConnection connection = DBHelper.SqlConn2())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 120;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.first_name = reader["FirstName"].ToString();
                            data.last_name = reader["LastName"].ToString();
                            data.email = reader["Email"].ToString();
                            data.login_id = reader["Email"].ToString();
                            data.Password = reader["Password"].ToString();
                            data.Salutation = reader["Salutation"].ToString();
                            data.language = reader["Languages"].ToString();
                            data.date_of_birth = (Convert.ToDateTime(reader["Birthday"])).ToString("MM/dd/yyyy");
                            data.HasMembership = reader["HasMembership"].ToString();
                            data.NeedActivate = reader["NeedActivate"].ToString();
                            data.NewsletterSubscription = reader["NewsletterSubscription"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static void UpdateUsedDummyData(string email)
        {
            query = "UPDATE lpg " +
                    "SET lpg.IsUsed = 1 " +
                    "FROM dbo.LOY_ProfileGenerator lpg " +
                    "WHERE lpg.Email = '"+ email + "'; ";

            using (SqlConnection connection = DBHelper.SqlConn2())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 120;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                        }
                    }
                }
                connection.Close();
            }
        }

        public static Users GetDataPerStatus_DCustomer(string status, int row, Users data, string email = null)
        {
            query = "SELECT TOP 1 U.email,M.loyaltymemberid FROM users U WITH(NOLOCK) "
                    + "INNER JOIN D_Customer DC WITH(NOLOCK) ON DC.ProfileId = U.ProfileID "
                    + "INNER JOIN ProfileLoyaltyDetail PLd WITH(NOLOCK) ON PLD.ProfileID = U.ProfileID "
                    + "INNER JOIN L_MembershipStatus MS WITH(NOLOCK) ON MS.ID = PLD.MembershipStatus "
                    + "INNER JOIN Memberships M WITH(NOLOCK) ON M.ProfileID = DC.ProfileID "
                    + "WHERE MS.MembershipStatus = '" + status + "' "
                    + "AND U.email like '%@cendyn17.com' "
                    + "AND DC.FirstName IS NOT NULL "
                    + "AND DC.LastName IS NOT NULL AND M.loyaltymemberid IS NOT NULL ";

            if (row == 1 && !String.IsNullOrEmpty(email))
                query += " AND U.email != '" + email + "' ORDER BY NEWID()";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.eMail = reader["email"].ToString();
                            data.ID = reader["loyaltymemberid"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
            
        }

        public static Users GetDataPer_JoiningDate(string date, int row, Users data, string email = null)
        {
            query = "WITH DD AS " +
                      "(SELECT TOP 2 LoyaltyMemberid, MemberEmail FROM Memberships WITH(NOLOCK) " +
                          "WHERE CONVERT(DATE, MemberSinceDate) <= '12/13/2019'and Memberemail Like '%@cendyn17.com' " +
                          "AND ExpirationDate IS NOT NULL " +
                          "GROUP BY LoyaltyMemberid, MemberEmail " +
                          "HAVING COUNT(MemberID) = 1 " +
                      ") " +
                      "SELECT DD.MemberEmail, MemberSinceDate, ExpirationDate, M.loyaltyMemberid  " +
                      "FROM DD " +
                      "INNER JOIN Memberships M WITH(NOLOCK)ON M.MemberEmail = DD.MemberEmail AND M.loyaltyMemberid = DD.loyaltyMemberid";
            if (row == 1 && !String.IsNullOrEmpty(email))
                query += " Where DD.MemberEmail != '" + email + "'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["MemberEmail"].ToString();
                            data.MemberSinceDate = reader["MemberSinceDate"].ToString();
                            data.ExpirationDate = reader["ExpirationDate"].ToString();
                            data.MemberShipId = reader["loyaltyMemberid"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users GetDataPer_ManualTransaction(int row, Users data, string email = null)
        {
            query = "SELECT DISTINCT TOP 1 m.MemberEmail " +
                    " FROM Memberships m WITH(nolock) " +
                    " INNER JOIN AdminAccountTransaction AS ad WITH (nolock)ON m.ProfileId = ad.ProfileId " +
                    " WHERE ISNULL(m.MemberEmail, '') <> '' " +
                    " AND m.MembershipStatus = 1 AND m.FK_CustomerID <> 0" +
                    "AND m.MemberEmail like '%@cendyn17.com'";
            if (row == 1 && !String.IsNullOrEmpty(email))
                query += " AND m.MemberEmail != '" + email + "'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["MemberEmail"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users GetAdminAccountTransactionCount(Users data, string email)
        {
            string query1 = "select Email,Count(Id) AS NoOfTransaction from AdminAccountTransaction AS AT with (nolock) " +
                            " inner Join D_Customer as DC with(nolock) on AT.ProfileID = DC.ProfileId" +
                             " group by Email having DC.Email = '" + email + "'";
            columnName = "NoOfTransaction";
            data.NoOfTransaction = DBHelper.ExecuteQueryAndReturnColumn(query1, columnName);
            return data;
        }

        /// <summary>
        /// Query to Get the member status Log
        /// </summary>        
        public static Users GetMemberStatusChange_Log(Users data, string date, string email)
        {
            string query1 = "Select * from MemberStatusLog MSL with (nolock) inner join D_Customer DC on MSL.ProfileId = DC.ProfileId where DC.Email = '" + email + "' order by MSL.insertdate";

            columnName = "Status";
            data.Status = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static string ReturnLoyaltyEmail()
        {
            string EmailAddress;
            query = "SELECT TOP 1 Email " +
                    "FROM dbo.Users u WITH (NOLOCK) " +
                    "WHERE u.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' " +
                          "AND ISNULL(RegistrationConfirmDate, '') != '' " +
                          "AND ISNULL(u.Email, '') != '' " +
                          "AND u.Email NOT LIKE '%qatest%' " +
                          "AND u.Email NOT LIKE '%auto%' " +
                          "AND u.Email NOT LIKE '%qa%' " +
                    "ORDER BY NEWID() DESC;";

            columnName = "Email";
            EmailAddress = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return EmailAddress;
        }

        public static Users ReturnEmailAddress(string profileId, string table, Users data)
        {
            string query = "";
            switch (table)
            {
                case "User":
                    query = "select Email from Users where ProfileId =" + profileId;
                    columnName = "Email";
                    data.eMail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
                    break;
                case "MemberShips":
                    query = "select MemberEmail from MemberShips where ProfileId =" + profileId;
                    columnName = "MemberEmail";
                    data.MemberEmail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
                    break;
                case "D_Customer":
                    query = "select TOP 1 Email from D_Customer where ProfileId =" + profileId;
                    columnName = "Email";
                    data.eMail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
                    break;
            }
            return data;
        }

        /// <summary>
        /// This method will return the MemberEmail having balance greater than the required balance
        /// </summary>
        /// <param name="data"></param>
        /// <param name="balance"></param>
        /// <returns></returns>
        public static Users GetMemberEmailWithSufficientBalance(Users data, string balance)
        {
            query = "SELECT TOP 1 M.MemberEmail,PLD.Balance FROM MemberShips AS M WITH(NOLOCK) " +
                     "INNER JOIN ProfileLoyaltyDetail PLD WITH(NOLOCK) ON M.ProfileId = PLD.ProfileId " +
                     "INNER JOIN Users U WITH (NOLOCK) ON M.MemberEmail = U.Email " +
                     "WHERE PLD.Balance >" + balance + " and  m.MemberEmail like '%@cendyn17.com' AND PLD.MembershipStatus = 1 AND u.Locked <> 1 AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' AND U.LastSuccessfulLoginDate is not null ORDER BY PLD.Balance DESC";
            columnName = "MemberEmail";
            data.MemberEmail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users GetMemberEmailWithZeroBalance(Users data, string balance)
        {
            query = "SELECT TOP 2 M.MemberEmail,PLD.Balance FROM MemberShips AS M WITH(NOLOCK) " +
            "INNER JOIN ProfileLoyaltyDetail PLD WITH(NOLOCK) ON M.ProfileId = PLD.ProfileId " +
            "INNER JOIN Users U WITH(NOLOCK) ON M.MemberEmail = U.Email " +
            "WHERE PLD.Balance =" + balance + " and m.MemberEmail like '%@cendyn17.com'AND u.Locked <> 1 AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' ORDER BY PLD.Balance DESC";
            columnName = "MemberEmail";
            data.MemberEmail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        /// <summary>
        /// This function returns the Award With PastDate
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static AdminVariable GetAwardWithPastDate(AdminVariable data)
        {
            query = "Select AwardName from LoyaltyAward with(noLock) where Enddate < getdate()";
            columnName = "AwardName";
            data.AwardName = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users GetMemberLevel(Users data, int Memberlevel)
        {
            query = "SELECT MembershipLevel,MembershipCode FROM dbo.L_MembershipLevel lml with (nolock) where id = " + Memberlevel + "and Active = 1";
            //columnName = "MembershipLevel";
            //data.MembershipLevel = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MembershipLevel = reader["MembershipLevel"].ToString();
                            data.MembershipCode = reader["MembershipCode"].ToString();                            

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        /// <summary>
        /// This function is used get the memeber email of the Active user.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Users GetActiveMemberEmail(Users data, string projectname = null)
        {
            //query = "select top 1 MemberEmail from memberships with(nolock) where membershipstatus = 1 and MemberEmail LIKE '%@cendyn17.com'";
            query = " SELECT TOP 1 M.MemberEmail,M.loyaltyMemberid, M.MemberShipStatus, M.profileid " +
                    " FROM Memberships AS M WITH(NOLOCK) " +
                    " LEFT JOIN  ProfileLoyaltyDetail PD WITH(NOLOCK) ON M.ProfileID = PD.ProfileID " +
                    " INNER JOIN Users U WITH (NOLOCK) ON M.MemberEmail = U.Email " +
                    " WHERE M.MemberEmail LIKE '%@cendyn17.com' AND U.RegistrationConfirmDate IS NOT NULL AND M.loyaltyMemberid IS NOT NULL " +
                    " AND PD.MembershipStatus = 1 AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' AND U.LockCount = 0";

            if (!String.IsNullOrEmpty(projectname) && projectname.Equals("Fraser"))
            {
                query += "AND M.EnrollmentSource IS NOT NULL";
            }

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["MemberEmail"].ToString();
                            data.MemberShipId = reader["loyaltyMemberid"].ToString();
                            data.ProfileId = reader["profileid"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users GetActiveMemberEmailMEMBER(Users data, string projectname = null)
        {
            //query = "select top 1 MemberEmail from memberships with(nolock) where membershipstatus = 1 and MemberEmail LIKE '%@cendyn17.com'";
            query = " SELECT TOP 1 M.MemberEmail,M.loyaltyMemberid , M.profileid " +
                    " FROM Memberships AS M WITH(NOLOCK) " +
                    " LEFT JOIN  ProfileLoyaltyDetail PD WITH(NOLOCK) ON M.ProfileID = PD.ProfileID " +
                    " INNER JOIN Users U WITH (NOLOCK) ON M.MemberEmail = U.Email " +
                    " WHERE M.MemberEmail LIKE '%@cendyn17.com' AND U.RegistrationConfirmDate IS NOT NULL AND M.loyaltyMemberid IS NOT NULL " +
                    " AND PD.MembershipStatus = 1 AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' AND U.LockCount = 0 AND M.MembershipLevel = 'MEMBER'";

            if (!String.IsNullOrEmpty(projectname) && projectname.Equals("Fraser"))
            {
                query += "AND M.EnrollmentSource IS NOT NULL";
            }

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["MemberEmail"].ToString();
                            data.MemberShipId = reader["loyaltyMemberid"].ToString();
                            data.ProfileId = reader["profileid"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetActiveMemberEmailPREFERRED(Users data, string projectname = null)
        {
            //query = "select top 1 MemberEmail from memberships with(nolock) where membershipstatus = 1 and MemberEmail LIKE '%@cendyn17.com'";
            query = " SELECT TOP 1 M.MemberEmail,M.loyaltyMemberid , M.profileid " +
                    " FROM Memberships AS M WITH(NOLOCK) " +
                    " LEFT JOIN  ProfileLoyaltyDetail PD WITH(NOLOCK) ON M.ProfileID = PD.ProfileID " +
                    " INNER JOIN Users U WITH (NOLOCK) ON M.MemberEmail = U.Email " +
                    " WHERE M.MemberEmail LIKE '%@cendyn17.com' AND U.RegistrationConfirmDate IS NOT NULL AND M.loyaltyMemberid IS NOT NULL " +
                    " AND PD.MembershipStatus = 1 AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' AND U.LockCount = 0 AND M.MembershipLevel = 'PREFERRED'";

            if (!String.IsNullOrEmpty(projectname) && projectname.Equals("Fraser"))
            {
                query += "AND M.EnrollmentSource IS NOT NULL";
            }

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["MemberEmail"].ToString();
                            data.MemberShipId = reader["loyaltyMemberid"].ToString();
                            data.ProfileId = reader["profileid"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetActiveMemberEmailELITE(Users data, string projectname = null)
        {
            //query = "select top 1 MemberEmail from memberships with(nolock) where membershipstatus = 1 and MemberEmail LIKE '%@cendyn17.com'";
            query = " SELECT TOP 1 M.MemberEmail,M.loyaltyMemberid , M.profileid " +
                    " FROM Memberships AS M WITH(NOLOCK) " +
                    " LEFT JOIN  ProfileLoyaltyDetail PD WITH(NOLOCK) ON M.ProfileID = PD.ProfileID " +
                    " INNER JOIN Users U WITH (NOLOCK) ON M.MemberEmail = U.Email " +
                    " WHERE M.MemberEmail LIKE '%@cendyn17.com' AND U.RegistrationConfirmDate IS NOT NULL AND M.loyaltyMemberid IS NOT NULL " +
                    " AND PD.MembershipStatus = 1 AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' AND U.Status = 1" +
                    " AND U.LockCount = 0 AND M.MembershipLevel = 'ELITE'";

            if (!String.IsNullOrEmpty(projectname) && projectname.Equals("Fraser"))
            {
                query += "AND M.EnrollmentSource IS NOT NULL";
            }

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["MemberEmail"].ToString();
                            data.MemberShipId = reader["loyaltyMemberid"].ToString();
                            data.ProfileId = reader["profileid"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetMemberEmailWithLessThan100Balance(Users data, string balance)
        {
            query = "SELECT TOP 1 M.MemberEmail,PLD.Balance FROM MemberShips AS M WITH(NOLOCK) " +
                     "INNER JOIN ProfileLoyaltyDetail PLD WITH(NOLOCK) ON M.ProfileId = PLD.ProfileId " +
                     "INNER JOIN Users U WITH (NOLOCK) ON M.MemberEmail = U.Email " +
                     "WHERE PLD.Balance < " + balance + " and  m.MemberEmail like '%@cendyn17.com' AND u.Locked <> 1 AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' ORDER BY PLD.Balance asc";
            columnName = "MemberEmail";
            data.MemberEmail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }
        public static Users GetMemberEmailWithBalanceEqualsToBalance(Users data, string balance)
        {
            query = "SELECT TOP 1 M.MemberEmail,PLD.Balance FROM MemberShips AS M WITH(NOLOCK) " +
                     "INNER JOIN ProfileLoyaltyDetail PLD WITH(NOLOCK) ON M.ProfileId = PLD.ProfileId " +
                     "INNER JOIN Users U WITH (NOLOCK) ON M.MemberEmail = U.Email " +
                     "WHERE PLD.Balance = " + balance + " and u.Locked <> 1 and  m.MemberEmail like '%@cendyn17.com' AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' ORDER BY PLD.Balance asc";
            columnName = "MemberEmail";
            data.MemberEmail = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }
        public static Users GetMemberEmailWithMoreThan100Balance(Users data, string balance)
        {
            query = "SELECT TOP 2 M.MemberEmail,PLD.Balance,PLD.ProfileId FROM MemberShips AS M WITH(NOLOCK) " +
                     "INNER JOIN ProfileLoyaltyDetail PLD WITH(NOLOCK) ON M.ProfileId = PLD.ProfileId " +
                     "INNER JOIN Users U WITH (NOLOCK) ON M.MemberEmail = U.Email " +
                     "WHERE PLD.Balance >" + balance + " and  m.MemberEmail like '%@cendyn17.com' AND u.Locked <> 1 AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' ORDER BY PLD.Balance desc";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["MemberEmail"].ToString();
                            data.Balance = reader["Balance"].ToString();
                            data.ProfileId = reader["ProfileId"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetActiveMemberEmailPL(Users data, string projectname = null)
        {
            //query = "select top 1 MemberEmail from memberships with(nolock) where membershipstatus = 1 and MemberEmail LIKE '%@cendyn17.com'";
            query = " SELECT TOP 1 M.MemberEmail,M.loyaltyMemberid , M.profileid " +
                    " FROM Memberships AS M WITH(NOLOCK) " +
                    " LEFT JOIN  ProfileLoyaltyDetail PD WITH(NOLOCK) ON M.ProfileID = PD.ProfileID " +
                    " INNER JOIN Users U WITH (NOLOCK) ON M.MemberEmail = U.Email " +
                    " WHERE M.MemberEmail LIKE '%@cendyn17.com' AND U.RegistrationConfirmDate IS NOT NULL AND M.loyaltyMemberid IS NOT NULL " +
                    " AND PD.MembershipStatus = 1 AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' AND U.LockCount = 0 AND M.MembershipLevel = 'PL'";

            if (!String.IsNullOrEmpty(projectname) && projectname.Equals("Fraser"))
            {
                query += "AND M.EnrollmentSource IS NOT NULL";
            }

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["MemberEmail"].ToString();
                            data.MemberShipId = reader["loyaltyMemberid"].ToString();
                            data.ProfileId = reader["profileid"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static string ReturnMaxDepartureDate()
        {
            string departureDate = "";
            query = "SELECT MAX(dcs.DepartureDate) AS DepartureDate " +
            "FROM D_CUSTOMER_STAY dcs WITH(NOLOCK) " +
            "INNER JOIN d_customer dcu ON dcs.CustomerID = dcu.CustomerID " +
            "INNER JOIN users U WITH(NOLOCK) ON U.ProfileID = dcu.ProfileId " +
            "INNER JOIN ProfileLoyaltyDetail PLd WITH(NOLOCK) ON PLD.ProfileID = U.ProfileID " +
            "INNER JOIN L_MembershipStatus MS WITH(NOLOCK) ON MS.ID = PLD.MembershipStatus " +
            "WHERE MS.MembershipStatus = 'Active' ";
            columnName = "DepartureDate";
            departureDate = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return departureDate;
        }

        public static Users GetActiveMemberWithAddress(Users data)
        {
            query = "SELECT TOP 1 M.MemberEmail, M.LoyaltyMemberId, M.Address1, ISNULL(M.Address2,'') AS Address2, ISNULL(M.City,'') AS City, " +
                   "ISNULL(M.StateProvinceCode,'') AS StateProvinceCode, ISNULL(M.ZipCode,'') AS ZipCode, ISNULL(M.CountryCode,'') AS CountryCode  " +
                   " FROM Memberships AS M WITH(NOLOCK) " +
                   " LEFT JOIN  ProfileLoyaltyDetail PD WITH(NOLOCK) ON M.ProfileID = PD.ProfileID " +
                   " INNER JOIN Users U WITH (NOLOCK) ON M.MemberEmail = U.Email " +
                   " WHERE M.MemberEmail LIKE '%@cendyn17.com' AND U.RegistrationConfirmDate IS NOT NULL " +
                   " AND PD.MembershipStatus = 1 AND M.Address1 IS NOT NULL AND M.City IS NOT NULL AND ZipCode IS NOT NULL AND CountryCode IS NOT NULL";


            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["MemberEmail"].ToString();
                            data.SelectedLoyaltyMemberID = reader["LoyaltyMemberId"].ToString();
                            data.Address1 = reader["Address1"].ToString();
                            //data.Address2 = reader["Address2"].ToString();
                            data.City = reader["City"].ToString();
                            data.StateProvinceCode = reader["StateProvinceCode"].ToString();
                            data.ZipCode = reader["ZipCode"].ToString();
                            data.CountryCode = reader["CountryCode"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static string GetLockedCount(string Email, Users data)
        {

            query = "SELECT LockCount FROM Users WITH (NoLock) WHERE Email='" + Email + "'";

            columnName = "LockCount";
            data.LockCount = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data.LockCount;
        }
        public static string GetMaxLockOutCounter(Users data)
        {

            query = "SELECT Configurationvalue FROM Configuration WITH(NoLock) WHERE Configurationname = 'UserLockoutAttemptsNumber'";
            columnName = "Configurationvalue";
            data.Configurationvalue = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data.Configurationvalue;
        }
        public static string GetServerDate()
        {
            string returnDate = "";
            query = "SELECT GetDate() AS ServerDate";
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
                            returnDate = reader["ServerDate"].ToString();
                            //DateTime.Today.ToString("MM/dd/yyyy")
                            DateTime serverDate;
                            string strInsertDate = "";
                            bool isValidDate = DateTime.TryParse(returnDate, out serverDate);
                            if (isValidDate)
                                returnDate = serverDate.ToString("MM/dd/yyyy");
                        }
                    }
                }
                connection.Close();
            }
            return returnDate;
        }

        public static Users GetEmailWithAward(Users data, string Status)
        {
            query = "SELECT TOP 1 MS.memberemail, MA.VoucherNumber, MS.loyaltyMemberid from Memberaward MA WITH(NoLock) INNER JOIN Memberships MS WITH(NoLock) " +
                    "ON MA.profileid = MS.Profileid INNER JOIN LoyaltyAward LA  WITH (NOLOCK) ON MA.AwardCode = LA.AwardCode WHERE MS.MemberShipStatus = 1 AND MA.Status = '" + Status + "' AND MS.memberemail LIKE '%@cendyn17.com' " +
                    "AND LA.is_eGift = 0 group by MS.MemberEmail,MS.loyaltyMemberid,MA.VoucherNumber" +
                      " having count(MA.VoucherNumber) < 5";
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
                            data.MemberEmail = reader["Memberemail"].ToString();
                            data.VoucherNumber = reader["VoucherNumber"].ToString();
                            data.MemberShipId = reader["loyaltyMemberid"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
      public static Users GetEmailWithNoAward(Users data)
        {
            query = "SELECT TOP 1 MS.memberemail, MS.loyaltyMemberid FROM Memberships MS WITH(NoLock) " +
                "INNER JOIN Users U WITH(NOLOCK) ON MS.MemberEmail = U.Email " +
                "where MS.memberemail LIKE '%@cendyn17.com'  AND u.RegistrationConfirmDate <> '' AND " +
                "MS.MemberShipStatus = 1 AND MS.profileid NOT IN(select MA.Profileid from Memberaward MA WITH(NoLock))";
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
                            data.MemberEmail = reader["Memberemail"].ToString();
                            data.MemberShipId = reader["loyaltyMemberid"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetAdminLockOutAttempt(Users data)
        {
            query = "SELECT ConfigurationValue FROM Configuration with(NoLock) WHERE ConfigurationName = 'AdminLockoutAttemptsNumber'";
            columnName = "Configurationvalue";
            data.Configurationvalue = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }

        public static Users GetMemberwithNonEgiftAward(Users data, string awardstatus)
        {

            query = " SELECT TOP 1 M.MemberEmail,M.loyaltyMemberid , MA.VoucherNumber, LA.AwardName " +
                    " FROM Memberships AS M WITH(NOLOCK) " +
                    " LEFT JOIN  ProfileLoyaltyDetail PD WITH(NOLOCK) ON M.ProfileID = PD.ProfileID " +
                    " INNER JOIN Users U WITH (NOLOCK) ON M.MemberEmail = U.Email " +
                    " INNER JOIN MemberAward MA WITH (NOLOCK) ON M.ProfileID = MA.ProfileID " +
                    " INNER JOIN LoyaltyAward LA  WITH (NOLOCK) ON MA.AwardCode = LA.AwardCode " +
                    " WHERE M.MemberEmail LIKE '%@cendyn17.com' AND U.RegistrationConfirmDate IS NOT NULL " +
                    " AND PD.MembershipStatus = 1 AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' " +
                    " AND LA.is_eGift = 0 AND MA.Status = '" + awardstatus + "'" +
                    " group by M.MemberEmail, M.loyaltyMemberid, MA.VoucherNumber, LA.AwardName having count(MA.VoucherNumber) < 5";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["MemberEmail"].ToString();
                            data.MemberShipId = reader["loyaltyMemberid"].ToString();
                            data.VoucherNumber = reader["VoucherNumber"].ToString();
                            data.AwardName = reader["AwardName"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetMemberwithEgiftAward(Users data, string awardstatus)
        {

            query = " SELECT TOP 1 M.MemberEmail,M.loyaltyMemberid , MA.VoucherNumber, LA.AwardName, MA.UpdateDate " +
                    " FROM Memberships AS M WITH(NOLOCK) " +
                    " LEFT JOIN  ProfileLoyaltyDetail PD WITH(NOLOCK) ON M.ProfileID = PD.ProfileID " +
                    " INNER JOIN Users U WITH (NOLOCK) ON M.MemberEmail = U.Email " +
                    " INNER JOIN MemberAward MA WITH (NOLOCK) ON M.ProfileID = MA.ProfileID " +
                    " INNER JOIN LoyaltyAward LA  WITH (NOLOCK) ON MA.AwardCode = LA.AwardCode " +
                    " WHERE M.MemberEmail LIKE '%@cendyn17.com' AND U.RegistrationConfirmDate IS NOT NULL " +
                    " AND PD.MembershipStatus = 1 AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' " +
                    " AND LA.is_eGift = 1 AND MA.Status = '" + awardstatus + "'" +
                    " group by M.MemberEmail, M.loyaltyMemberid, MA.VoucherNumber, LA.AwardName, MA.UpdateDate having count(MA.VoucherNumber) < 5" +
                    " Order by MA.UpdateDate desc";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["MemberEmail"].ToString();
                            data.MemberShipId = reader["loyaltyMemberid"].ToString();
                            data.VoucherNumber = reader["VoucherNumber"].ToString();
                            data.AwardName = reader["AwardName"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetMemberAwardName(Users data)
        {
            query = " SELECT TOP 1 memberemail,awardname FROM loyaltyaward la " +
                    " WITH (NoLock) INNER JOIN  memberaward ma WITH(NoLock) ON la.awardCode = ma.awardcode " +
                    " INNER JOIN Memberships ms WITH(NoLock) ON ma.profileid = ms.profileid " +
                    " WHERE la.Enddate > getdate() AND ma.Status = 'ORD'";

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
                            data.MemberEmail = reader["memberemail"].ToString();
                            data.AwardName = reader["awardname"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetUpdatedEmail(Users data, string profileId)
        {
            query = " SELECT New FROM Loyalty_AdminChange_Log WHERE profileid = '" + profileId + "' ";

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
                            data.New = reader["New"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;

        }
        public static Users GetMembershipStatus(Users data, string memberLevelName)
        {
            query = "SELECT MembershipLevel, Active FROM L_Membershiplevel WITH(NoLock) WHERE MembershipLevel = '" + memberLevelName + "'";
                

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
                            data.Active = reader["Active"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;

        }
        public static Users GetActiveMembershipLevel(Users data)
        {
            query = "SELECT TOP 1 MembershipLevel, MembershipCode, LevelOrder, Active FROM L_Membershiplevel WITH(NoLock) WHERE Active = 1";


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
                            data.MembershipLevelName = reader["MembershipLevel"].ToString();
                            data.MembershipCode = reader["MembershipCode"].ToString();
                            data.LevelOrder = reader["LevelOrder"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;

        }
        public static Users GetActiveMembershipLevelwithCount(Users data)
        {
            query = "SELECT membershiplevel,(SELECT count(*) FROM L_Membershiplevel WITH(NoLock) WHERE Active = 1) count FROM L_Membershiplevel WITH(NoLock) WHERE Active = 1";


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
                            data.MembershipLevelName = reader["MembershipLevel"].ToString();
                            data.LevelCount = reader["count"].ToString();
                            
                        }
                    }
                }
                connection.Close();
            }
            return data;

        }
        public static Users GetActiveMembershipLevelByLevelOrder(Users data, string value)
        {
            query = "SELECT MembershipLevel FROM L_Membershiplevel WITH(NoLock) WHERE  Active = 1  AND  LevelOrder = " + value +"";


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
                            data.MembershipLevelName = reader["MembershipLevel"].ToString();
                            
                        }
                    }
                }
                connection.Close();
            }
            return data;

        }
        public static Users GetMemberForAdminUpdates(Users data, string projectname = null)
        {
            query = " SELECT TOP 1 M.MemberEmail,M.loyaltyMemberid , M.profileid " +
                    " FROM Memberships AS M WITH(NOLOCK) " +
                    " LEFT JOIN  ProfileLoyaltyDetail PD WITH(NOLOCK) ON M.ProfileID = PD.ProfileID " +
                    " INNER JOIN Users U WITH (NOLOCK) ON M.MemberEmail = U.Email " +
                    " inner join [dbo].[Loyalty_AdminChange_Log] la with (nolock) on m.ProfileID  = LA.ProfileID"+
                    " WHERE M.MemberEmail LIKE '%@cendyn17.com' AND U.RegistrationConfirmDate IS NOT NULL AND" +
                    " M.loyaltyMemberid IS NOT NULL " +
                    " AND PD.MembershipStatus = 1 AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' AND" +
                    " U.LockCount = 0 AND la.[By] like '%automation%'" ;

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["MemberEmail"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

       
    public static Users GetMemberAwardWithExipiredDate(Users data)
        {
            query = "Select Top 1 AwardName from [dbo].[RedemptionProduct] RP with (nolock) inner join LoyaltyAward LA with (nolock) on RP.LoyaltyAwardID = LA.ID " +
                    " Where LA.EndDate < getdate() order by RP.CreateDate desc";
            columnName = "AwardName";
            data.AwardName = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            return data;
        }
    public static Users GetActiveMemberMembershipCardInfo(Users data, string projectname = null)
        {
               query = " SELECT TOP 1 M.MemberEmail,M.loyaltyMemberid , M.MemberLastName, M.MemberFirstName, M.MemberSinceDate" +
                    " FROM Memberships AS M WITH(NOLOCK) " +
                    " LEFT JOIN  ProfileLoyaltyDetail PD WITH(NOLOCK) ON M.ProfileID = PD.ProfileID " +
                    " INNER JOIN Users U WITH (NOLOCK) ON M.MemberEmail = U.Email " +
                    " WHERE M.MemberEmail LIKE '%@cendyn17.com' AND U.RegistrationConfirmDate IS NOT NULL AND M.loyaltyMemberid IS NOT NULL " +
                    " AND PD.MembershipStatus = 1 AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' AND U.LockCount = 0";

            if (!String.IsNullOrEmpty(projectname) && projectname.Equals("Fraser"))
            {
                query += "AND M.EnrollmentSource IS NOT NULL";
            }

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["MemberEmail"].ToString();
                            data.MemberShipId = reader["loyaltyMemberid"].ToString();
                            //data.ProfileId = reader["profileid"].ToString();
                            data.firstName = reader["MemberFirstName"].ToString();
                            data.lastName = reader["MemberLastName"].ToString();
                            data.MemberSinceDate = reader["MemberSinceDate"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }


        public static Users GetDeactivedMemberEmail(Users data)
        {
            query = " SELECT TOP 1 M.MemberEmail,M.loyaltyMemberid , M.profileid " +
                    " FROM Memberships AS M WITH(NOLOCK) " +
                    " LEFT JOIN  ProfileLoyaltyDetail PD WITH(NOLOCK) ON M.ProfileID = PD.ProfileID " +
                    " INNER JOIN Users U WITH (NOLOCK) ON M.MemberEmail = U.Email " +
                    " WHERE M.MemberEmail LIKE '%@cendyn17.com' AND U.RegistrationConfirmDate IS NOT NULL AND M.loyaltyMemberid IS NOT NULL " +
                    " AND PD.MembershipStatus = 3 AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' AND U.LockCount = 0";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["MemberEmail"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetMemberLevelRuleDetails(Users data, string referralCode)
        {
            query = "SELECT TOP 1 ReferralCode, NightNumber, stayTypeId, MemberLevelId FROM MembershipLevelRule WITH(noLock) WHERE Referralcode = '"+referralCode+"' ORDER BY InsertDate DESC";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.ReferralCode = reader["ReferralCode"].ToString();
                            data.NightNumber = reader["NightNumber"].ToString();
                            data.StayTypeId = reader["stayTypeId"].ToString();
                            data.MemberLevelId = reader["MemberLevelId"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users GetLoyaltyRules(Users data, string status,string ruleType)
        {
            query = "SELECT TOP 1 RuleName, Priority FROM LoyaltyRule with(noLock) WHERE active = '"+status+"' And RuleType = '"+ruleType+"'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.RuleName = reader["RuleName"].ToString();
                            data.Priority = reader["Priority"].ToString();
                            
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetRuleByName(Users data, string ruleName)
        {
            query = "SELECT TOP 1 id FROM LoyaltyRule with(noLock) WHERE RuleName = '" + ruleName+"'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.RuleId = reader["id"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetRulewithChannelCode(Users data, string ruleId)
        {
            query = "SELECT TOP 1 included from LoyaltyRuleInclExclChannelCodes with(noLock) WHERE RuleId = '" + ruleId+"'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.RuleIncluded = reader["included"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetQualifiedRuleDetails(Users data, string ruleName)
        {
            query = "select TOP 1 LR.RuleID, LR.RuleName, LR.Description,  LR.MinRevenue, LR.ParallelStay, LR.AllowConsecutiveStays FROM LoyaltyRuleLog  LR WITH(noLOCK)  WHERE RuleName = '" + ruleName + "' ORDER BY insertdate DESC";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.RuleId = reader["RuleID"].ToString();
                            data.RuleName = reader["RuleName"].ToString();
                            data.RuleDescription = reader["Description"].ToString();
                            data.MinRevenue = reader["MinRevenue"].ToString();
                            data.ParallelStay = reader["ParallelStay"].ToString();
                            data.AllowConsecutiveStays = reader["AllowConsecutiveStays"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetQualifiedNIghtRuleDetails(Users data, string ruleName)
        {
            query = "select TOP 1 LR.RuleID, LR.RuleName, LR.Description,  LR.MinRevenue from LoyaltyRuleLog LR with(nolock)  where RuleName = '" + ruleName+"' order by insertdate desc ";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.RuleId = reader["RuleID"].ToString();
                            data.RuleName = reader["RuleName"].ToString();
                            data.RuleDescription = reader["Description"].ToString();
                            data.MinRevenue = reader["MinRevenue"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetActiveTestEmailTemplate(Users data)
        {
            query = "Select top 1 EmailName from [dbo].[PropertyEmailSettings]  with (nolock) where Active = 1 and EmailName like'%test%'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.EmailName = reader["EmailName"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users GetSettingValueFromPropertySettings(Users data)
        {
            query = "SELECT SettingValue FROM propertysetting WHERE settingkey LIKE '%Mail_From%'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.SettingValue = reader["SettingValue"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users GetFromEmailFromPropertyEmailSettings(Users data)
        {
            query = "SELECT TOP 1 EmailFromAddress FROM PropertyEmailSettings";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.EmailFromAddress = reader["EmailFromAddress"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetActiveLoyaltyOffer(Users data)
        {
            query = "SELECT TOP 1 LOF.Title, LO.OfferStartDate, LO.OfferEnddate, LP.PromotionCode FROM [dbo].[LoyaltyOffer] LO WITH(noLock) " +
                "INNER JOIN [dbo].[LoyaltyOfferDisplay] LOF WITH(noLock) ON LO.ID = LOF.LoyaltyOfferID " +
                "INNER JOIN[LoyaltyPromotion] LP with(nolock) on LP.LoyaltyOfferID = LO.ID" +
                " WHERE OfferStartDate < GETDATE() and OfferEndDate > GETDATE() and LOF.LanguageCultureName = 'en-US' " +
                " Order by LP.ID desc";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.OfferTitle = reader["Title"].ToString();
                            data.OfferStartDate = reader["OfferStartDate"].ToString();
                            data.OfferEndDate = reader["OfferEnddate"].ToString();
                            data.PromotionCode = reader["PromotionCode"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetScheduledLoyaltyOffer(Users data)
        {
            query = "SELECT TOP 1 LOF.Title, LO.OfferStartDate, LO.OfferEnddate FROM [dbo].[LoyaltyOffer] LO WITH(noLock) INNER JOIN [dbo].[LoyaltyOfferDisplay] LOF WITH(noLock) ON LO.ID = LOF.LoyaltyOfferID WHERE LO.VisibleStartDate > GETDATE() and LOF.LanguageCultureName = 'en-US'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.OfferTitle = reader["Title"].ToString();
                            data.OfferStartDate = reader["OfferStartDate"].ToString();
                            data.OfferEndDate = reader["OfferEnddate"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetInactiveLoyaltyOffer(Users data)
        {
            query = "SELECT TOP 1 LOF.Title, LO.OfferStartDate, LO.OfferEnddate FROM [dbo].[LoyaltyOffer] LO WITH(noLock) INNER JOIN [dbo].[LoyaltyOfferDisplay] LOF WITH(noLock) ON LO.ID = LOF.LoyaltyOfferID WHERE LO.OfferEndDate < GETDATE() and LOF.LanguageCultureName = 'en-US'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.OfferTitle = reader["Title"].ToString();
                            data.OfferStartDate = reader["OfferStartDate"].ToString();
                            data.OfferEndDate = reader["OfferEnddate"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetRuleMarketCode(Users data, string  Ruleid, string MarketCode)
        {
            query = "Select top 1 MarketCode from LoyaltyRuleInclExclMarketCodesLog with(nolock) where Ruleid = "+Ruleid+" and " +
                "MarketCode = '"+MarketCode+"' order by InsertDate desc";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MarketCode = reader["MarketCode"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetRuleMarketRateCombo(Users data, string Ruleid)
        {
            query = "Select top 1 Marketcode, RateCode from LoyaltyRuleInclExclMarketCodesRatesCombLog with(nolock) where Ruleid = "+Ruleid+" order by InsertDate desc";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MarketCombo = reader["Marketcode"].ToString();
                            data.RateCombo = reader["RateCode"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetRuleRateCode(Users data, string Ruleid)
        {
            query = "Select top 1  RateCode from LoyaltyRuleInclExclRatesLog with(nolock) where Ruleid = "+Ruleid+" order by InsertDate desc";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.RateCode = reader["RateCode"].ToString();
                            
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetRuleProperty(Users data, string Ruleid, string propertyname)
        {
            query = "Select top 1  pm.MasterPropertyCode from LoyaltyRuleInclExclHotelsLog lrxh with(nolock) inner join PropertyMapping pm with(noLock) on pm.MasterPropertyCode = lrxh.MasterPropertyCode where RuleID = "+Ruleid+" and PropertyName = '"+propertyname+"' order by lrxh.Insertdate desc";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MasterPropertyCode = reader["MasterPropertyCode"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetStayAsPerFirstName(Users data,string firstName)
        {
            query = " Select top 1 dcu.FirstName, dcu.LastName, dcs.ArrivalDate, dcs.DepartureDate, dcs.ReservationNumber" +
                " From D_CUSTOMER_STAY dcs inner " +
                " join d_customer dcu " +
                " on dcs.CustomerID = dcu.CustomerID where dcs.DepartureDate >= '2016-08-04' and dcu.FirstName = '" + firstName + "'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.firstName = reader["FirstName"].ToString();
                            data.lastName = reader["LastName"].ToString();
                            data.ArrivalDate = reader["ArrivalDate"].ToString();
                            data.DepartureDate = reader["DepartureDate"].ToString();
                            data.ReservationNumber = reader["ReservationNumber"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetRedeemeGift_Award(Users data)
        {
           query = "Select top 1 RP.ProductName from[dbo].[RedemptionProduct] RP with(nolock) inner join LoyaltyAward LA  with(nolock) on RP.LoyaltyAwardID = LA.ID where LA.EndDate > getdate() and LA.is_eGift = 1  and Active = 1 order by RP.CreateDate desc";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.AwardName = reader["ProductName"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }


        public static Users Return_ReservationNumberOfPMSUser(Users data)
        {
            query = " SELECT TOP 10 C.CustomerID, C.email, C.FirstName, C.LastName, S.ReservationNumber" +
                    " FROM D_Customer AS C WITH(NOLOCK) " +
                    " INNER JOIN D_Customer_Stay AS S WITH(NOLOCK) ON S.CustomerID = C.CustomerID " +
                    " WHERE C.Email IS NOT NULL AND ProfileId not In(Select ProfileId from Users as u with(nolock)" +
                    " where u.ProfileID = c.ProfileId)" +
                    " AND S.ReservationNumber not In(Select AT.SourceReferenceNumber from Accounttransaction as AT with(nolock) " +
                    " where S.ReservationNumber = AT.SourceReferenceNumber) " +
                    " AND C.SourceId = 1 And s.DepartureDate IS NOT NULL Order by c.insertdate desc";
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
                            data.ReservationNumber = reader["ReservationNumber"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static string InsertStay(int customerId, string propertyCode, string reservatioNo, string arrivalDate, string departureDate, string sourceNodeID, string sourceGuestId, string cendynPropertyId, string stayStatus, int stayNight, int roomNight, int numAdult, int numChild, int totalPerson, string marketSeg, string margetsubseg, string otherrevenue, string roomTypeCode, string roomRevenue, string resCreationDate, string selectedLoyMemberId, string sourceOfBusisness, string resAgent, string rateCode, string channel)
        {
            string resutid = "";
            query = "exec _tmp_insert_d_customerstay " + customerId + ",'" + propertyCode + "','" + reservatioNo + "','" + arrivalDate + "','" + departureDate + "','" + sourceNodeID + "'," + sourceGuestId + "," + cendynPropertyId + ",'" + stayStatus + "'," + stayNight + "," + roomNight + "," + numAdult + "," + numChild + "," + totalPerson + ",'" + marketSeg + "','" + margetsubseg + "'," + otherrevenue + ",'" + roomTypeCode + "'," + roomRevenue + ",'" + resCreationDate + "','" + selectedLoyMemberId + "','" + sourceOfBusisness + "','" + resAgent + "','" + rateCode + "','" + channel + "'";

            using (var connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            resutid = reader["SouceStayID"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return resutid;
        }


        public static void InsertNight(int sourceStayId, int customerId, string propertyCode, string reservatioNo, string stayDate, decimal stayRateAmount, int stayNumRooms, decimal stayRateAmountUSD, string stayRateType)
        {
            query = "exec _tmp_insert_d_customer_stay_rate " + sourceStayId + ",'" + customerId + "','" + propertyCode + "','" + reservatioNo + "','" + stayDate + "','" + stayRateAmount + "','" + stayNumRooms + "'," + stayRateAmountUSD + ",'" + stayRateType + "'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.CommandTimeout = 60;
                    command.ExecuteReader();

                }
                connection.Close();
            }
        }
        public static Users VerifyStayTransaction(Users data, string useremail, string ruleID, string reservationNo)
        {
            data.TransactionPoints = null;
            query = "SELECT TOP 1 AT.TransactionId, AT.ProfileId, ATR.AccountTransactionId, atr.RuleId, ATP.TransactionPoints, " + "ATP.LoyaltyRuleId, AT.SourceReferenceNumber " +
                    "FROM AccountTransaction AT WITH(nolock) " +
                    "INNER JOIN AccountTransactionRuleLog ATR WITH(nolock) " +
                    "ON at.TransactionId = atr.AccountTransactionId " +
                    "INNER JOIN AccountTransactionPoints ATP WITH(nolock) " +
                    "ON ATR.AccountTransactionId = ATP.AccountTransactionId " +
                    "INNER JOIN D_customer DC with(nolock) " +
                    "ON AT.ProfileId = dc.ProfileId " +
                    "INNER JOIN D_CUSTOMER_STAY DCS with(nolock) " +
                    "ON DCS.CustomerID = dc.CustomerID " +
                    "INNER JOIN D_customer_stay_Rate DCSR with(nolock) " +
                    "ON DCSR.CustomerID = dc.CustomerID " +
                    "WHERE AT.profileid IN " +
                    "( " +
                        "SELECT Profileid " +
                        "FROM users WITH (nolock) " +
                        "WHERE email = '" + useremail + "' " +
                    ") " +
                    "AND ATP.LoyaltyRuleId = " + ruleID + "" +
                    "AND AT.SourceReferenceNumber = '" + reservationNo + "'" +
                    " ORDER BY DCS.UpdateDate DESC;";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.TransactionPoints = reader["TransactionPoints"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users GetProertyDetails(Users data)
        {
            query = "Select TOP 1 CRMProp.PropertyCode, CendynPropertyID from D_Property CRMProp with (nolock) inner join PropertyMapping LOYProp with (nolock) on LOYProp.Propertycode = CRMProp.Propertycode";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.PropertyCode = reader["PropertyCode"].ToString();
                            data.PropertyId = reader["CendynPropertyID"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetProertyDetailsByName(Users data, string propertyName)
        {
            query = "Select TOP 1 CRMProp.PropertyCode, CendynPropertyID from D_Property CRMProp with (nolock) inner join PropertyMapping LOYProp with (nolock) on LOYProp.Propertycode = CRMProp.Propertycode where CRMProp.PropertyName = '" + propertyName + "'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.PropertyCode = reader["PropertyCode"].ToString();
                            data.PropertyId = reader["CendynPropertyID"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetCustomerIdByMemberEmail(Users data, string email)
        {
            query = "SELECT CustomerId, SourceGuestID FROM D_Customer WITH(NoLock) WHERE email = '" + email + "'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.CustomerID = reader["CustomerId"].ToString();
                            data.SourceGuestId = reader["SourceGuestID"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static void UpdateRegistrationDate(string profileId, string regDate, string expDate)
        {
            query = "EXEC _tmp_updateuserregistertime " + profileId + ", '" + regDate + "', '" + expDate + "'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.CommandTimeout = 60;
                    command.ExecuteReader();

                }
                connection.Close();
            }

        }

        public static Users GetProfileIdByMemberEmail(Users data, string email)
        {
            query = "Select ProfileID from MemberShips with(noLock) where MemberEmail = '" + email + "'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.ProfileId = reader["ProfileID"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static void InsertLoyaltyRule(string rulename, string displayName, string description, string dateType, string startDate, string endDate, int priority, int calculatedUnitTypeId, int fixedPoints, int calculateUnit, int CalculationType, string revenueType, decimal roomRevenue, decimal fnBRevenue, decimal otherRevenue, decimal pointsPerNight, int minRevenue, int minStay, int maxStay, string ruleType)
        {
            query = "exec [InsertLoyaltyRule_QAOnly]     @RuleName = '" + rulename + "'," +
                                                        "@DisplayName ='" + displayName + "'," +
                                                        "@Description  ='" + description + "'," +
                                                        "@DateType = '" + dateType + "'," +
                                                        "@StartDate = '" + startDate + "'," +
                                                        "@EndDate ='" + endDate + "'," + 
                                                        "@Priority ='" + priority + "'," +
                                                        "@CalculateUnitTypeID =" + calculatedUnitTypeId + "," +
                                                        "@FixedPoints = " + fixedPoints + "," +
                                                        "@CalculateUnit =" + calculateUnit + "," +
                                                        "@CalculationType =" + CalculationType + "," +
                                                        "@RevenueType ='" + revenueType + "'," +
                                                        "@RoomRevenue =" + roomRevenue + "," +
                                                        "@FoodBevRevenue =" + fnBRevenue + "," +
                                                        "@OtherRevenue =" + otherRevenue + "," +
                                                        "@PointsPerNight =" + pointsPerNight + "," +
                                                        "@MinRevenue =" + minRevenue + "," +
                                                        "@MinStays =" + minStay + "," +
                                                        "@MaxStays  =" + maxStay + "," +
                                                        "@RuleType ='" + ruleType + "';";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.CommandTimeout = 60;
                    command.ExecuteReader();

                }
                connection.Close();
            }
        }
        public static void InsertQualifyingRule(string rulename, int ruleid, int allowconsecutivestay, int minRevenue, string channel, string marketcode, string ratecode, string sob, string hotel, int parallelstay, string marketcombo, string ratecombo, int marketIncluded, int rateIncluded, int sobIncluded, int channelIncluded, int hotelIncluded, int marketratecomboIncluded)
        {
            query = "exec [InsertQualifyingRule_QAOnly]     @RuleName = '" + rulename + "'," +
                                                        "@RuleID = " + ruleid + "," +
                                                        "@AllowConsecutiveStays  = " + allowconsecutivestay + "," +
                                                        "@MinRevenue = " + minRevenue + "," +
                                                        "@Channel = '" + channel + "'," +
                                                        "@MarketCode ='" + marketcode + "'," +
                                                        "@RateCode = '" + ratecode + "'," +
                                                        "@SOB = '" + sob + "'," +
                                                        "@Hotel = '" + hotel + "'," +
                                                        "@ParellelStay = " + parallelstay + "," +
                                                        "@MarketCodeCombo ='" + marketcombo + "'," +
                                                        "@RateCodeCombo = '" + ratecombo + "'," +
                                                        "@MarketIncluded = " + marketIncluded + "," +
                                                        "@RateIncluded = " + rateIncluded + "," +
                                                        "@SOBIncluded = " + sobIncluded + "," +
                                                        "@ChannelIncluded = " + channelIncluded + "," +
                                                        "@HotelIncluded = " + hotelIncluded + "," +
                                                        "@MarketRateComboIncluded  = " + marketratecomboIncluded + ";";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.CommandTimeout = 60;
                    command.ExecuteReader();

                }
                connection.Close();
            }
        }
        public static void UpdateRuleStatus(Users data, string RuleName, int activestatus)
        {
            query = "Update LoyaltyRule SET Active = "+activestatus+" where RuleName = '"+RuleName+"'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteReader();
                    
                }
                connection.Close();
            }
            
        }
        public static Users GetMasterPropertyCode(Users data, string Propertyname)
        {
            query = "select MasterPropertyCode from propertymapping with(noLock) where PropertyName = '"+Propertyname+"'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.PropertyCode = reader["MasterPropertyCode"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static Users GetAllMasterPropertyCode(Users data, string MasterPropertyCode = null)
        {
            query = "select Distinct MasterPropertyCode from propertymapping with(noLock)";
            if (MasterPropertyCode != null)
            {
                query += "where MasterPropertyCode <> '"+ MasterPropertyCode + "' ";
            }
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.PropertyCode = reader["MasterPropertyCode"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static void UpdateQualifyingRule(string rulename, int ruleid, int allowconsecutivestay, int minRevenue, string channel, string marketcode, string ratecode, string sob, string hotel, int parallelstay, string marketcombo, string ratecombo, int marketIncluded, int rateIncluded, int sobIncluded, int channelIncluded, int hotelIncluded, int marketratecomboIncluded)
        {
            query = "exec [UpdateQualifyingRule_QAOnly]     @RuleName = '" + rulename + "'," +
                                                        "@RuleID = " + ruleid + "," +
                                                        "@AllowConsecutiveStays  = " + allowconsecutivestay + "," +
                                                        "@MinRevenue = " + minRevenue + "," +
                                                        "@Channel = '" + channel + "'," +
                                                        "@MarketCode ='" + marketcode + "'," +
                                                        "@RateCode = '" + ratecode + "'," +
                                                        "@SOB = '" + sob + "'," +
                                                        "@Hotel = '" + hotel + "'," +
                                                        "@ParellelStay = " + parallelstay + "," +
                                                        "@MarketCodeCombo ='" + marketcombo + "'," +
                                                        "@RateCodeCombo = '" + ratecombo + "'," +
                                                        "@MarketIncluded = " + marketIncluded + "," +
                                                        "@RateIncluded = " + rateIncluded + "," +
                                                        "@SOBIncluded = " + sobIncluded + "," +
                                                        "@ChannelIncluded = " + channelIncluded + "," +
                                                        "@HotelIncluded = " + hotelIncluded + "," +
                                                        "@MarketRateComboIncluded  = " + marketratecomboIncluded + ";";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.CommandTimeout = 60;
                    command.ExecuteReader();

                }
                connection.Close();
            }
        }
        public static void UpdateLoyaltyRule(Users data, int AllowConsecutiveStays, int MinRevenue, string RuleName)
        {
            query = "Update LoyaltyRule SET AllowConsecutiveStays = "+ AllowConsecutiveStays + ", MinRevenue = "+MinRevenue+" WHERE RuleName = '"+RuleName+"'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteReader();
                    
                }
                connection.Close();
            }

        }
        public static void UpdatePropertySettings(Users data, int SettingValue)
        {
            query = "Update Propertysetting SET SettingValue = "+ SettingValue + " WHERE SettingKey = 'ParallelStayThreshold'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteReader();
                    
                }
                connection.Close();
            }

        }
        public static void InsertHotels(Users data, int ruleid, string hotel, int included)
        {
            query = "INSERT INTO LoyaltyRuleInclExclHotels VALUES(" + ruleid+", '"+hotel+"', "+included+")";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteReader();
                    
                }
                connection.Close();
            }

        }
        public static void InsertChannelCode(Users data, int ruleid, string channel, int included)
        {
            query = "INSERT INTO LoyaltyRuleInclExclChannelCodes VALUES(" + ruleid + ", '" + channel + "', " + included + ")";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteReader();
                    
                }
                connection.Close();
            }

        }
        public static void InsertMarketCode(Users data, int ruleid, string marketCode, int included)
        {
            query = "INSERT INTO LoyaltyRuleInclExclMarketCodes VALUES(" + ruleid + ", '" + marketCode + "', " + included + ")";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteReader();
                    
                }
                connection.Close();
            }

        }
        public static void InsertMarketRateCombo(Users data, int ruleid, string marketCodeCombo, string rateCodeCombo, int included)
        {
            query = "INSERT INTO LoyaltyRuleInclExclMarketCodesRatesComb VALUES(" + ruleid + ", '" + marketCodeCombo + "', '" + rateCodeCombo + "'," + included + ")";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteReader();
                }
                connection.Close();
            }

        }
        public static void InsertRateCode(Users data, int ruleid, string rateCode, int included)
        {
            query = "INSERT INTO LoyaltyRuleInclExclRates VALUES(" + ruleid + ", '" + rateCode + "', " + included + ")";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteReader();
                    
                }
                connection.Close();
            }

        }
        public static void InsertSOB(Users data, int ruleid, string sob, int included)
        {
            query = "INSERT INTO LoyaltyRuleInclExclSourceOfBusiness VALUES(" + ruleid + ", '" + sob + "', " + included + ")";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteReader();
                    
                }
                connection.Close();
            }

        }
        public static void DeleteRules(Users data, string ruleName)
        {
            query = "DECLARE @RuleId VARCHAR(100); " +
                    "SET @RuleId = (SELECT ID FROM LoyaltyRule WHERE RuleName = '"+ ruleName + "'); " +
                    "Delete from[LoyaltyRuleInclExclHotels] where RuleId = @RuleId " +
                    "Delete from[dbo].[LoyaltyRuleInclExclMarketCodes] where RuleId = @RuleId " +
                    "Delete from[dbo].[LoyaltyRuleInclExclRates] where RuleId = @RuleId " +
                    "Delete from[dbo].[LoyaltyRuleInclExclChannelCodes] where RuleId = @RuleId " +
                    "Delete from[dbo].[LoyaltyRuleInclExclSourceOfBusiness] where RuleId = @RuleId " +
                    "Delete from[dbo].[LoyaltyRuleInclExclMarketCodesRatesComb] where RuleId = @RuleId ;";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteReader();
                    
                }
                connection.Close();
            }

        }
        public static void InsertRoomType(Users data, int ruleid, string RoomType, int included)
        {
            query = "INSERT INTO LoyaltyRuleInclExclRoomTypes VALUES(" + ruleid + ", '" + RoomType + "', " + included + ")";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteReader();

                }
                connection.Close();
            }

        }
        public static void Start_ETL ()
        {
            query = "EXEC msdb.dbo.sp_start_job 'ETL_Origami4_Loyalty'";
            //query = "EXEC msdb.dbo.sp_start_job 'ETL_Origami_Loyalty'"

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.CommandTimeout = 60;
                    command.ExecuteReader();

                }
                connection.Close();
            }

        }
        /// <summary>
        /// This method will return the PointsRemaining of the Night based on below parameter
        /// </summary>
        /// <param name="data"></param>
        /// <param name="useremail"></param>
        /// <param name="stayDate"></param>
        /// <param name="ruleID"></param>
        /// <returns>PointsRemaining</returns>
        public static Users VerifyStayTransactionPerNight(Users data, string useremail, string stayDate, string ruleID)
        {
            data.PointsRemaining = null;
            query = "Select TOP 1 Email,u.ProfileID, SR.StayDate, ATNP.PointsRemaining from AccountTransactionNightsPoints ATNP with (nolock)" +
                     " inner join D_customer_stay_rate SR with(nolock) on SR.RateId = ATNP.StayRateID" +
                     " inner join AccountTransaction AT with(nolock) on AT.TransactionReference = SR.SourceStayID" +
                     " inner join AccounTTransactionPoints ATP with(nolock) on ATP.LoyaltyRuleId = atnp.LoyaltyRuleID and At.TransactionId = ATP.AccountTransactionId" +
                     " inner join Users U with(nolock) on U.profileid = AT.Profileid" +
                     " Where SR.StayDate = '" + stayDate + "' and " + " ATP.LoyaltyRuleID = '"+ ruleID + "' and "+
                     " email = '" + useremail + "' order by ATNP.StayRateID;";
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.PointsRemaining = reader["PointsRemaining"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        /// <summary>
        /// This method will return based on below parameters
        /// </summary>
        /// <param name="data"></param>
        /// <param name="email"></param>
        /// <param name="date"></param>
        /// <param name="reservationNumber"></param>
        /// <returns>RateID</returns>
        public static Users GetStayRateIDByMemberEmailAndStayDate(Users data, string email, string date, string reservationNumber)
        {
            query = "Select 'StayRate table' Stay_Rate, D_customer_stay_Rate.RateID, D_customer_stay_Rate.SourceStayID, D_customer_stay_Rate.CustomerID, D_customer_stay_Rate.PropertyCode, D_customer_stay_Rate.ReservationNumber, D_customer_stay_Rate.StayDate, D_customer_stay_Rate.StayRateType, D_customer_stay_Rate.StayRateAmountConvertedUSD, D_customer_stay_Rate.StayRateAmount_Corp, D_customer_stay_Rate.StayRateAmount_Prop, D_customer_stay_Rate.StayRoomType, D_customer_stay_Rate.StayRateAmount, D_customer_stay_Rate.StayNumRooms, D_customer_stay_Rate.StayQuotedInterval, D_customer_stay_Rate.InsertDate, D_customer_stay_Rate.UpdateDate, D_customer_stay_Rate.CurrencyCode, D_customer_stay_Rate.CurrencySymbol, D_customer_stay_Rate.StayRoomCode, D_customer_stay_Rate.StayDetailHeaderID, D_customer_stay_Rate.PK_StayDetail, D_customer_stay_Rate.Currency_To_USD_Rate, D_customer_stay_Rate.ExchangeRate_Corp, D_customer_stay_Rate.ExchangeRate_Prop, D_customer_stay_Rate.MarketCode, D_customer_stay_Rate.ResSourceCode from D_customer_stay_Rate with (nolock) where sourcestayid in (Select Sourcestayid from D_customer_stay stay with (nolock) " +
                 " inner join D_customer cust with(nolock) on cust.customerid = stay.customerid " +
                " where Profileid in (SELECT Profileid FROM users WITH(nolock)" +
                " WHERE email = '"+email+"') and StayDate = '"+date+ "' and ReservationNumber = '"+ reservationNumber + "')"; 

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.RateID = reader["RateID"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        /// <summary>
        /// Updates the night rate based on below parameter
        /// </summary>
        /// <param name="rateID"></param>
        /// <param name="stayRateType"></param>
        /// <param name="stayRateAmountConvertedUSD"></param>
        /// <param name="stayRateAmountCorp"></param>
        /// <param name="stayRateAmountProp"></param>
        public static void UpdateNightRate(int rateID, string stayRateType, decimal stayRateAmountConvertedUSD, string stayRateAmountCorp, string stayRateAmountProp)
            {
            query = "EXEC dbo.[_tmp_update_d_customer_stay_rate_stayrateamount]" +
                " @PARAM_RateID = " + rateID + " " + "," +
                " @PARAM_StayRateType = '" + stayRateType + "' " + "," +
                " @PARAM_StayRateAmountConvertedUSD = " + stayRateAmountConvertedUSD + "" + "," +
                " @PARAM_StayRateAmount_Corp = '" + stayRateAmountCorp + "'";
            //" @PARAM_StayRateAmount_Prop = '" + stayRateAmountProp + "'";
            //As per Origami 4 we don't need last parameter so commenting it. In case needed please uncomment this for QA environment
            using (SqlConnection connection = DBHelper.SqlConn())
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandTimeout = 60;
                        command.ExecuteReader();
                    }
                    connection.Close();
            }
        }
        /// <summary>
        /// This method retun the SourceStayID based on below parameter
        /// </summary>
        /// <param name="data"></param>
        /// <param name="email"></param>
        /// <param name="reservationNumber"></param>
        /// <returns>SourceStayID</returns>
        public static Users GetSourceStayIDByMemberEmailAndResNo(Users data, string email, string reservationNumber)
        {
            query = "SELECT TOP 1 'Stay table' Stay, stay.SourceStayID, stay.CustomerID, stay.ServerNodeID,stay.Channel,stay.PropertyCode, stay.CendynPropertyID, stay.SourceGuestID, stay.ReservationNumber, stay.StayStatus, stay.ArrivalDate, stay.DepartureDate, stay.ResCreationDate, stay.CancelDate, stay.ClientType, stay.GroupReservation, stay.SourceOfBusiness, stay.MarketSeg, stay.MarketSubSeg, stay.StayNights, stay.RoomNights, stay.NumAdults, stay.NumChildren, stay.TotalPersons, stay.GuestTypeCode, stay.RateCategory, stay.RateType, stay.RateTypeString, stay.RatePackage, stay.RoomCode, stay.RoomTypeCode, stay.RoomTypeString, stay.UnitAmount, stay.Quantity, stay.Amount, stay.SharerCode, stay.DiscountPercentage, stay.DiscountAmount, stay.DiscountCode, stay.VIPStatus, stay.MemberShipID, stay.MemberShipLevel, stay.LeadTimeDays, stay.IATA, stay.CompanyClientCode, stay.ReservedByClientCode, stay.CentralReservation, stay.ServiceCode1, stay.ServiceCode2, stay.ServiceCode3, stay.ServiceCode5, stay.QuotedRate, stay.QuotedInterval, stay.InsertDate, stay.UpdateDate, stay.IsValid_RateTypeString, stay.SubReservationNumber, stay.SourceID, stay.ResAgent, stay.CheckinAgent, stay.PK_Reservations, stay.CancellationNum, stay.AverageDailyRevenue, stay.Tax, stay.Deposit, stay.BuildingCode, stay.RateConfidential, stay.RoomRevenue, stay.OtherRevenue, stay.TotalRevenue, stay.TotalRevenueWithTax, stay.AverageDailyRevenueWithTax, stay.AverageDailyRate, stay.PackageCode, stay.TaxType, stay.CXLPolicy, stay.CancelByDate, stay.InvBlockCode, stay.RTC, stay.GroupName, stay.CompanyName, stay.GroupResortFees, stay.RemainingBalance, stay.MarketCodeCategory, stay.CXLCode, stay.AgencyCode, stay.Report_Flag, stay.TotalResortFees, stay.TotalPackageRateWithTax, stay.GroupType, stay.TotalPackageRate, stay.ImportSourceID, stay.ExternalResID2, stay.SourcePropertyID, stay.BookingEngConfNum, stay.DepositAmountDue, stay.DepositAmountPaid, stay.RF2, stay.ResCheckedInBy, stay.ResCheckedOutBy, stay.DepositCode, stay.DepositPolicy, stay.RateCategoryCode, stay.ResSourceCategory, stay.MP, stay.AcknowledgementNum, stay.NumRooms, stay.SourceResStatus, stay.GuaranteedByCode, stay.CheckInTime, stay.CheckOutTime, stay.SelectedLoyaltyMemberID, stay.ImportSource, stay.PseudoRoom, stay.StayAverageTax, stay.StayTotalRoomRevenueWithTax, stay.FacilitiesFees, stay.Points, stay.LegNumbers, cust.CustomerID, cust.PropertyCode, cust.SourceGuestID, cust.ShortTitle, cust.FirstName, cust.MiddleName, cust.LastName, cust.Salutation, cust.GenderCode, cust.Title, cust.Company, cust.Address1, cust.Address2, cust.City, cust.StateProvinceCode, cust.ZipCode, cust.MSACode, cust.DivisionCode, cust.RegionCode, cust.CountryCode, cust.PhoneNumber, cust.PhoneExtension, cust.HomePhoneNumber, cust.FaxNumber, cust.Email, cust.Languages, cust.Nationality, cust.Attention, cust.InsertDate, cust.UpdateDate, cust.EmailInsertDate, cust.EmailUpdateDate, cust.Address1InsertDate, cust.Address1UpdateDate, cust.CASSDate, cust.CASSBatch, cust.CASSStatus, cust.NCOADate, cust.RawSourceID, cust.SourceID, cust.CellPhoneNumber, cust.EmailStatus, cust.ZipCodePlus4, cust.AddressStatus, cust.AddressType, cust.AddressStandardization, cust.EmailDomainHash, cust.EmailHash, cust.CompanyTitle, cust.PK_Profiles, cust.DedupeCheck, cust.DatePMSProfileUpdated, cust.AllowEMail, cust.AllowMail, cust.AllowSMS, cust.BusinessPhoneNumber, cust.Report_Flag, cust.Lang_LanguageID, cust.Membership, cust.UNIFOCUS_SCORE, cust.ExternalProfileID2, cust.VIPID, cust.VIPCode, cust.AllowPhone, cust.[C-VIP], cust.DMACode, cust.Token, cust.ProfileId, cust.LoyaltyProfileID, cust.email_address_sha1, cust.MarketingSegment, cust.DataSource, cust.DataSubSource, cust.VIPLevel, cust.JobTitle from D_customer_stay stay with (nolock)" +
                    " inner join D_customer cust with(nolock) on cust.customerid = stay.customerid " +
                    " where Profileid in (SELECT Profileid FROM users WITH(nolock)" +
                    " WHERE email = '" + email + "' and ReservationNumber = '" + reservationNumber + "') ORDER BY stay.InsertDate DESC";
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.SourceStayID = reader["SourceStayID"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static void UpdateStayStatus(int sourceStayId, string stayStatus)
        {
                 query = "EXEC dbo.[_tmp_update_d_customer_stay_staystatus]" +
                " @PARAM_SourceStayId = " + sourceStayId + " " + "," +
                " @PARAM_StayStatus = '" + stayStatus + "' " ;
                
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    command.ExecuteReader();
                }
                connection.Close();
            }
        }


        public static Users GetProfileIDByMemberEmail(Users data, string email)
        {
            query = "SELECT 'Users' Users, "+
                    " users.Id, users.Username, users.Email, users.Password, users.MasterPropertyCode, users.RegistrationTime, users.LastSuccessfulLoginDate, users.LastFailedLoginDate, users.LastLoginIPAddress, users.Status, users.ProfileID, users.PasswordFormatId, users.[Delete], users.RegistrationToken, users.RegistrationConfirmDate, users.RegistrationEmailSentDate, users.RegistrationSrc, users.SignupCode, users.SignerName, users.KioskSource, users.SocialMediaUserToken, users.SocialSource "+
                    " FROM users WITH(nolock) " +
                    "WHERE email = '"+email+"'; ";
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.ProfileID = reader["ProfileID"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static void DeductPoints(int pointsToDeduct, int profileId, string trasanctionType, string description, string performBy)
        {
            query = "EXEC [dbo].[DeductPointsByExpirationDate]" +
                    " @PointsToDeduct = " + pointsToDeduct + "" + "," +
                    " @ProfileId = " + profileId + "" + "," +
                    " @TrasanctionType = '" + trasanctionType + "'" + "," +
                    " @Description = '" + description + "'" + "," +
                    " @PerformBy = '" + performBy + "'";
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    command.ExecuteReader();
                }
                connection.Close();
            }
        }


        public static Users GetPointsRemainingRedeemUsingProfileID(Users data, int profileId)
        {
            query = "declare @Profileid int" +
                    " set @Profileid = " + profileId + "; " +
                    " WITH cte_pointsummary" +
                    " as (SELECT profileid,sum(ps.PointsRemaining) AS pointsremaining FROM dbo.PointsSummary ps GROUP BY ps.ProfileID)" +
                    " SELECT p.loyaltymemberid,pld.balance,c.pointsremaining FROM dbo.ProfileLoyaltyDetail pld JOIN cte_pointsummary c ON c.profileid=pld.ProfileID" +
                    " JOIN profile p ON p.id=pld.profileid" +
                    " WHERE p.id = @Profileid";
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.PointsRemainingForRedeem = reader["pointsremaining"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static void UpdateMarketSubSegment(int sourceStayId, string marketSubSeg)
            {
                query = "EXEC [dbo].[_tmp_update_d_customer_stay_marketsubseg]" +
                    " @PARAM_SourceStayId = " + sourceStayId+" " +","+
                    " @PARAM_MarketSubSeg= '" + marketSubSeg + "' ";

                using (SqlConnection connection = DBHelper.SqlConn())
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandTimeout = 60;
                        command.ExecuteReader();
                    }
                    connection.Close();
            }
        }

        public static void SimulateDateUsingProfileId(int profileId, string dateForSimulate)
        {
            
            query = "EXEC [dbo].[CheckQualifiedStayRule_FOR_QA_ONLY_NOT_PRODUCTION]" +
                    " @dateToSimulate= '" + dateForSimulate + "' "+ "," +
                   " @profileId= '" + profileId + "' ";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    command.ExecuteReader();
                }
                connection.Close();
            }
        }

        public static void UpdateNightRateWithNullRate(int rateID, string stayRateType, string stayRateAmountConvertedUSD, string stayRateAmountCorp, string stayRateAmountProp)
        {

            query = "EXEC dbo.[_tmp_update_d_customer_stay_rate_stayrateamount]" +
                " @PARAM_RateID = " + rateID + " " + "," +
                " @PARAM_StayRateType = '" + stayRateType + "' " + "," +
                " @PARAM_StayRateAmountConvertedUSD = null" + "," +
               " @PARAM_StayRateAmount_Corp = null ";
            //+ "," + " @PARAM_StayRateAmount_Prop = null";
            //Commented for Origami 4 
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    command.ExecuteReader();
                }
                connection.Close();
            }
        }

        public static void ExecuteSPsToUpdatePointsAfterStatusChanged() 
        {

            query = "EXEC CheckQualifiedStayRule";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    command.ExecuteReader();
                }
                connection.Close();
            }

            Thread.Sleep(10000);
            query = "declare @RuleID int;" +
                    " declare @stopFurtherRules int;"+
                    " declare cur CURSOR LOCAL for"+
                    " select ID, stopFurtherRules from LoyaltyRule where Active = 1 and RuleType = 'Points'"+
                    " open cur"+"\n"+
                    " fetch next from cur into @RuleID, @stopFurtherRules"+"\n"+
                    " while @@FETCH_STATUS = 0 BEGIN"+"\n"+
                    " exec ValidateAccountTransaction  @RuleID, @stopFurtherRules"+"\n"+
                    " fetch next from cur into @RuleID, @stopFurtherRules" + "\n" +
                    "  END" + "\n" +
                    " close cur" + "\n" +
                    " deallocate cur";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    command.ExecuteReader();
                }
                connection.Close();
            }
            Thread.Sleep(10000);
            query = "EXEC CalculateProfilePoint";
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    command.ExecuteReader();
                }
                connection.Close();
            }
        }

        public static Users GetActiveMemberEmailUsingMembershipLevel(Users data, string mLevel, string projectname = null)
        {
            //query = "select top 1 MemberEmail from memberships with(nolock) where membershipstatus = 1 and MemberEmail LIKE '%@cendyn17.com'";
            query = " SELECT TOP 1 M.MemberEmail,M.loyaltyMemberid , M.profileid " +
                    " FROM Memberships AS M WITH(NOLOCK) " +
                    " LEFT JOIN  ProfileLoyaltyDetail PD WITH(NOLOCK) ON M.ProfileID = PD.ProfileID " +
                    " INNER JOIN Users U WITH (NOLOCK) ON M.MemberEmail = U.Email " +
                    " WHERE M.MemberEmail LIKE '%@cendyn17.com' AND U.RegistrationConfirmDate IS NOT NULL AND M.loyaltyMemberid IS NOT NULL " +
                    " AND M.MembershipLevel= '"+ mLevel + "'" +
                    " AND PD.MembershipStatus = 1 AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' AND U.LockCount = 0";

            if (!String.IsNullOrEmpty(projectname) && projectname.Equals("Fraser"))
            {
                query += "AND M.EnrollmentSource IS NOT NULL";
            }

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["MemberEmail"].ToString();
                            data.MemberShipId = reader["loyaltyMemberid"].ToString();
                            data.ProfileId = reader["profileid"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users GetActiveAdminMemberEmail(Users data, string projectname = null)
        {
            query = "SELECT TOP 1 Email from AdminUsers AU where AU.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' " +
                   " AND AU.IsLocked = 0 and AU.Active = 1 AND AU.Email LIKE '%@cendyn17.com' AND " +
                   " AU.Email NOT IN('CendynAdmin@cendyn17.com', 'Origamiautomationuser@cendyn17.com') AND AU.PWDExpirationDate > GetDate()";
            
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["Email"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static void Restore_DB()
        {
            query = "RESTORE DATABASE eInsightCRM_Origami4_QA FROM  DISK = N'F:\\backup\\eInsightCRM_Origami4_QABaseDB.bak' WITH  FILE = 13";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.CommandTimeout = 60;
                    command.ExecuteReader();

                }
                connection.Close();
            }

        }
        public static void BackUp_DB(Users data)
        {
            query = "Backup database eInsightCRM_Origami4_QA to disk = N'F:\\backup\\eInsightCRM_Origami3_QABaseDB.bak' with compression;";
          
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.CommandTimeout = 60;
                    command.ExecuteReader();

                }
                connection.Close();
            }
            query = "select top 1 a.position, a.server_name, a.database_name, backup_finish_date, a.backup_size," +
                       " CASE a.[type] " +
                          "  WHEN 'D' THEN 'Full'" +
                          "  WHEN 'I' THEN 'Differential'" +
                          "  WHEN 'L' THEN 'Transaction Log'" +
                          "  ELSE a.[type]" +
                          " END as BackupType, b.physical_device_name" +
                          " from msdb.dbo.backupset a join msdb.dbo.backupmediafamily b on a.media_set_id = b.media_set_id" +
                          " where a.database_name Like 'eInsightCRM_Origami4_QA%'" +
                          " order by a.backup_finish_date desc";
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.BackUpFileNumber = reader["position"].ToString();
                        }
                    }
                }
                connection.Close();
            }

            query = "Restore database eInsightCRM_Origami3_QA FROM  DISK = N'F:\\backup\\eInsightCRM_Origami3_QABaseDB.bak' WITH FILE = "+data.BackUpFileNumber+"";
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.CommandTimeout = 60;
                    command.ExecuteReader();

                }
                connection.Close();
            }

        }


        public static void SetupTransactionCloseDelayHours(string settingKey, string settingValue)
        {
            query = "[dbo].[_tmp_updatepropertysetting]" +
                    " @SettingKey = '" + settingKey + "'" + "," +
                    " @SettingValue = '" + settingValue + "'";
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    command.ExecuteReader();
                }
                connection.Close();
            }
        }

        public static void ExecuteSPsToUpdatePointsAfterDateSimulate(string simulateDate)
        {

            query = "declare @RuleID int;" +
                    " declare @stopFurtherRules int;" +
                    " declare cur CURSOR LOCAL for" +
                    " select ID, stopFurtherRules from LoyaltyRule where Active = 1 and RuleType = 'Points'" +
                    " open cur" + 
                    " fetch next from cur into @RuleID, @stopFurtherRules" + 
                    " while @@FETCH_STATUS = 0 BEGIN" + 
                    " exec ValidateAccountTransaction_FOR_QA_ONLY_NOT_PRODUCTION  @RuleID,'" + simulateDate + "' ,@stopFurtherRules" + 
                    " fetch next from cur into @RuleID, @stopFurtherRules" +
                    "  END" + 
                    " close cur" + 
                    " deallocate cur";
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    command.ExecuteReader();
                }
                connection.Close();
            }
            Thread.Sleep(10000);
            query = "EXEC CalculateProfilePoint";
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    command.ExecuteReader();
                }
                connection.Close();
            }
        }

        public static Users GetAwardNameAndPoint(Users data, string productName)
        {
            query = "Select LA.AwardName, LA.Points from[dbo].[RedemptionProduct] RP with(nolock) inner join LoyaltyAward LA  with(nolock) on RP.LoyaltyAwardID = LA.ID" +
                    " where RP.ProductName = '"+ productName + "'";
            
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.AwardName = reader["AwardName"].ToString();
                            data.Points = reader["Points"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static Users GetMemberEmailWithBalanceToMatchAwardBalance(Users data, string operators)
        {
            query = "Select top 1 RP.ProductName from [dbo].[RedemptionProduct] RP with (nolock) inner join LoyaltyAward LA  with (nolock) on  RP.LoyaltyAwardID = LA.ID where LA.EndDate > getdate() and CultureCode = 'en-US' and LA.is_eGift = 0";
            columnName = "ProductName";
            string productName = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);

            query = "Select top 1 LA.Points from [dbo].[RedemptionProduct] RP with (nolock) inner join LoyaltyAward LA  with (nolock) on  RP.LoyaltyAwardID = LA.ID" +
                    " where RP.ProductName = '"+productName+"'";
            columnName = "Points";
            string points = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);

            query = "Select top 1 MemberLevelCode from  [LoyaltyAwardMemberLevelMapping] LM with (nolock) inner join LoyaltyAward LA  with (nolock) on  LM.LoyaltyAwardID = LA.ID" +
                    " inner join[dbo].[RedemptionProduct] RP with(nolock) on RP.LoyaltyAwardID = LA.ID where RP.ProductName =  '" + productName + "'";
            columnName = "MemberLevelCode";
            string memberLevelCode = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);


            query = "with cte_ps as" +
                    " (select profileid, Sum(ps.PointsRemaining) as PointsRemaining from PointsSummary ps" +
                    " group by ps.ProfileID)"+
                    " select Top 1 M.MemberEmail, p.LoyaltyMemberID,cp.PointsRemaining,pld.Balance from profile p"+
                    " join cte_ps cp on p.id = cp.ProfileID"+
                    " join ProfileLoyaltyDetail pld on pld.ProfileID = p.ID" +
                    " inner join MemberShips AS M WITH(NOLOCK) on M.ProfileID = p.ID"+
                    " INNER JOIN Users U WITH(NOLOCK) ON M.MemberEmail = U.Email"+
                    " where cp.PointsRemaining = pld.balance and pld.balance "+ operators + " "+ points + " and m.MemberEmail like '%@cendyn17.com' AND u.Locked <> 1 AND M.loyaltyMemberid is not null AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3'" +
                    " AND pld.MembershipStatus = 1 AND U.RegistrationConfirmDate IS NOT NULL and M.MembershipLevel = '" + memberLevelCode + "' ORDER BY pld.Balance";


            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["MemberEmail"].ToString();
                            data.PointsRemaining = reader["PointsRemaining"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            data.ProductName = productName;
            return data;
        }
        public static Users GetMemberBalance(Users data, string email)
        {
            query = "SELECT TOP 2 M.MemberEmail,PLD.Balance,PLD.ProfileId FROM MemberShips AS M WITH(NOLOCK) " +
                     "INNER JOIN ProfileLoyaltyDetail PLD WITH(NOLOCK) ON M.ProfileId = PLD.ProfileId " +
                     "INNER JOIN Users U WITH (NOLOCK) ON M.MemberEmail = U.Email " +
                     "WHERE m.MemberEmail like '" + email + "' AND u.Locked <> 1 AND U.Password = 'D8DC2C8B51482DB762FB7E3103E91C3A9B4969D3' ORDER BY PLD.Balance desc";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.MemberEmail = reader["MemberEmail"].ToString();
                            data.Balance = reader["Balance"].ToString();
                            data.ProfileId = reader["ProfileId"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
    }
}
