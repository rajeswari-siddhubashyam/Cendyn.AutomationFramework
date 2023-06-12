using System;
using BaseUtility.Utility;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;
using System.Xml;
using Newtonsoft.Json.Linq;
using eInsight.Utility;

namespace SqlWarehouse
{
    public class SqlWarehouseQuery : Helper
    {
        private static string query = "";
        private static string columnName = "";
        public static string companyName = "";
        public static string getValue = "";
        public static string dbName = "";
        public static string templateDB = "";

        private static string GetDatabaseName()
        {
            if (testCategory == "QA")
            {
                dbName = "[eContact_Cendyn_QA]";
                templateDB = "[TemplateBuilder_App_QA]";
            }
            else if (testCategory == "POC")
            {
                dbName = "[eContact_Cendyn_QA]";
                templateDB = "[TemplateApi]";
            }
            else if (testCategory == "PostDeployment")
            {
                dbName = "[eContact_Cendyn]";
                //templateDB = "";
            }
            else if (testCategory == "EU02_PostDeployment")
            {
                dbName = "[eContact_Cendyn_EU]";
                //templateDB = "";
            }
            return dbName;
        }

       private static ClientdbConnection GetClientdbConnection(string CompanyName, ClientdbConnection strConn)
        {
            //Regex regex = new Regex(@"\S");
            if (testCategory == "QA")
            {
                Regex regex = new Regex(@"^\S*");
                Match match = regex.Match(CompanyName);

                query = "SELECT cc.CRM_Server, " +
                               "cc.CRM_Database, " +
                               "cc.CRM_User, " +
                               "cc.CRM_Password, " +
                               "cc.ConnectonString " +
                        "FROM dbo.V_ClientdbConnections cc " +
                        "WHERE cc.CRM_Database LIKE '%" + match.Value + "%' " +
                        "AND Enviorment = '"+ testCategory + "'";
            }
            else
            {
                string pattern = @"\s";
                string value = Regex.Replace(CompanyName, pattern, "%");
                if (testCategory == "EU02_PostDeployment")
                {
                    
                        strConn.ServerName = "vmpdb-eu1-crm01";
                        strConn.DatabasName = "eInsightCRM_HotelOrigami";
                        strConn.UserName = "offshoreQA";
                        strConn.Password = "R5szPJwF6!pyx";
                        strConn.ConnectonString = "Data Source = vmpdb-eu1-crm01; Initial Catalog = eInsightCRM_HotelOrigami; Persist Security Info = True; User ID = offshoreQA; Password = R5szPJwF6!pyx";
                    return strConn;
                }
                query = "SELECT cc.CRM_Server, " +
                               "cc.CRM_Database, " +
                               "cc.CRM_User, " +
                               "cc.CRM_Password, " +
                               "cc.ConnectonString " +
                        "FROM dbo.V_ClientdbConnections cc " +
                        "WHERE cc.CRM_Database LIKE '%" + value + "%' " +
                        "AND Enviorment = '" + testCategory + "'";
            }

            using (SqlConnection connection = DBHelper.SqlConn2())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            strConn.ServerName = reader["CRM_Server"].ToString();
                            strConn.DatabasName = reader["CRM_Database"].ToString();
                            strConn.UserName = reader["CRM_User"].ToString();
                            strConn.Password = reader["CRM_Password"].ToString();
                            strConn.ConnectonString = reader["ConnectonString"].ToString();
                        }
                    }
                }
                connection.Close();
             
                return strConn;
            }
        }

        public static void GetCommonXMLData(string projectName)
        {
            string executableLocationCodeBase = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            UriBuilder uri = new UriBuilder(executableLocationCodeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            string locationPath = Path.GetDirectoryName(path);
            string xslLocation = Path.Combine(executableLocationCodeBase, "TestData");
            xslLocation = xslLocation + "\\Common.xml";

            query = "EXEC dbo.CreateCommonData_QAOnly @ProjectName = N'" + projectName + " '";

            using (SqlConnection connection = DBHelper.SqlConn2())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    XmlWriterSettings set = new XmlWriterSettings();
                    set.ConformanceLevel = ConformanceLevel.Document;
                    set.Indent = true;
                    set.CloseOutput = true;

                    using (XmlReader reader = command.ExecuteXmlReader())
                    using (XmlWriter writer = XmlWriter.Create(File.Open(xslLocation, FileMode.OpenOrCreate, FileAccess.Write), set))
                    {
                        while (!reader.EOF)
                        {
                            writer.WriteStartElement("TestData");
                            writer.WriteNode(reader, true);
                            writer.WriteEndElement();
                        }
                        writer.WriteEndDocument();
                    }
                }
                connection.Close();
            }
        }

        public static ClientdbConnection GetCompanyName(int ProjectID, ClientdbConnection strvar)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "SELECT DISTINCT " +
                           "p2.ParentCompany, " +
                           "c.CompanyName " +
                    "FROM dbo.projects p  " +
                         "INNER JOIN dbo.Company c  ON p.CompanyID = c.CompanyID " +
                         "INNER JOIN dbo.Parentcompany p2  ON p2.ID = c.ParentCompany " +
                    "WHERE (CASE WHEN ISNULL(p.eContact_Campaign_ParentProjectID, '') = '' THEN p.ID ELSE p.eContact_Campaign_ParentProjectID END) = " + ProjectID;

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
                            strvar.ParentCompanyName = reader["ParentCompany"].ToString();
                            strvar.CompanyName = reader["CompanyName"].ToString();
                        }
                    }
                }
                connection.Close();
                return strvar;
            }
        }

        public static Users GetCustomerCampaignHistoryData(Users CustData, string CompanyName, string caseType, string customerID = null)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(CompanyName, Connstr);
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            switch (caseType)
            {
                case "GetReservatonfromCustomer":
                    query = query + "EXEC [dbo].[P_get_campaign_history] " +
                                 "@p0 = " + customerID + ";";
                    break;
                case "GetRandomReservation":
                    query = query + "IF OBJECT_ID('tempdb..#MailingSummary') IS NOT NULL " +
                                "DROP TABLE #MailingSummary; " +
                            "DECLARE @CustomerID INT; " +

                            "SELECT Distinct srd.Email, NEWID() ID " +
                            "INTO #MailingSummary " +
                            "FROM dbo.SM_REPORT_DELIVERED srd " +
                                 "INNER JOIN dbo.SM_REPORT_MAILING_SUMMARY srms ON srms.ChildProjectID = srd.ChildProjectID " +
                            "WHERE srms.SendDate >= CONVERT(DATE, DATEADD(MONTH, -11, GETDATE())) AND srms.SendDate <= CONVERT(DATE, GETDATE()) " +
                                  "AND SUBSTRING ( " +
                                    "srd.Email, " +
                                    "CHARINDEX( '@', srd.Email ) + 1,  " +
                                    "LEN(srd.Email  " +
                                  ")) != 'jijesoft.com' " +
                            "GROUP BY srd.Email " +
                            "HAVING COUNT(srd.Email) < 2 " +
                            "ORDER BY NEWID() DESC; " +

                            "SELECT @CustomerID = dc.CustomerID " +
                            "FROM dbo.D_CUSTOMER dc " +
                                 "INNER JOIN #MailingSummary ms ON ms.Email = dc.Email; " +

                            "EXEC [dbo].[P_get_campaign_history] " +
                                 "@p0 = @CustomerID;";
                    break;
            }

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 300;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CustData.CustomerID = reader["CustomerID"].ToString();
                            CustData.Email = reader["Email"].ToString();
                            CustData.CampaignName = reader["CampaignName"].ToString();
                            CustData.Subject = reader["Subject"].ToString();
                            CustData.SendDate = reader["SendDate"].ToString();
                            CustData.OpenYN = reader["OpenYN"].ToString();
                            CustData.ClickYN = reader["ClickYN"].ToString();
                            CustData.ClickLinksCount = reader["ClickLinksCount"].ToString();
                            CustData.BouncedYN = reader["BouncedYN"].ToString();
                            CustData.BounceReason = reader["BounceReason"].ToString();
                        }
                    }
                }
                connection.Close();
                return CustData;
            }
        }
        public static ProfileCustData GetCustomerProfileData(ProfileCustData ProfileData, string CompanyName, string CountryCode)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(CompanyName, Connstr);
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "DECLARE @CountryCodeCOndition VARCHAR(25)= '" + CountryCode + "'; " +
                    "IF OBJECT_ID('tempdb..#WithStayCustomer') IS NOT NULL " +
                        "DROP TABLE #WithStayCustomer; " +

                    "SELECT TOP 100 dcs.CustomerID " +
                    "INTO #WithStayCustomer " +
                    "FROM dbo.D_CUSTOMER_STAY dcs " +
                    "INNER JOIN dbo.D_CUSTOMER dc ON dc.CustomerID = dcs.CustomerID " +
                    "WHERE dc.CountryCode = @CountryCodeCOndition; " +

                    "SELECT TOP 1 dc.CustomerID, " +
                                 "dc.FirstName, " +
                                 "dc.LastName, " +
                                 "dc.Email, " +
                                 "CASE " +
                                     "WHEN dc.GenderCode = 'U' " +
                                     "THEN 'Unspecified' " +
                                     "WHEN dc.GenderCode IS NULL " +
                                     "THEN '' " +
                                     "ELSE dc.GenderCode " +
                                 "END AS GenderCode, " +
                                 "ISNULL(Languages, '') AS Languages, " +
                                 "ISNULL(dc.PropertyCode, '') AS PropertyCode, " +
                                 "ISNULL(dc.InsertDate, '') AS InsertDate, " +
                                 "ISNULL(dc.UpdateDate, '') AS UpdateDate, " +
                                 "ISNULL(ldsc.SourceName, '') AS SourceName, " +
                                 "ISNULL(PhoneNumber, '') AS PhoneNumber, " +
                                 "ISNULL(Address1, '') AS Address1, " +
                                 "ISNULL(City, '') AS City, " +
                                 "ISNULL(lgsc.StateName, '') AS StateName, " +
                                 "ISNULL(ZipCode, '') AS ZipCode, " +
                                 "ISNULL(dc.CountryCode, '') AS CountryCode, " +
                                 "ISNULL(ldas.Name, '') AS AddressStatus " +
                    "FROM dbo.D_CUSTOMER dc " +
                         "INNER JOIN #WithStayCustomer wsc ON wsc.CustomerID = dc.CustomerID " +
                         "INNER JOIN dbo.L_DATA_SOURCE_CODE ldsc WITH(NOLOCK) ON dc.SourceID = ldsc.SourceID " +
                         "INNER JOIN dbo.L_DATA_EMAIL_STATUS ldes WITH(NOLOCK) ON ldes.EmailStatus = dc.EmailStatus " +
                         "INNER JOIN dbo.L_DATA_ADDRESS_STATUS ldas WITH(NOLOCK) ON ldas.AddressStatus = dc.AddressStatus " +
                         "INNER JOIN dbo.L_GEO_STATE_CODE lgsc WITH(NOLOCK) ON lgsc.StateCode = dc.StateProvinceCode " +
                    "WHERE ISNULL(dc.Email, '') != '' " +
                          "AND dc.CountryCode = @CountryCodeCOndition " +
                          " ORDER BY  NEWID(); ";

            //"WITH RandDCustomerID " +
            //     "AS ( " +
            //     "SELECT TOP 10 dc.CustomerID " +
            //     "FROM dbo.D_CUSTOMER dc  " +
            //          "INNER JOIN dbo.d_customer_stay dcs  ON dc.customerID = dcs.customerID " +
            //     "WHERE dc.Email IS NOT NULL " +
            //           "AND ISNULL(dc.City, '') != '' " +
            //           "AND ISNULL(dc.StateProvinceCode, '') != '' " +
            //           "AND (ABS(CAST((BINARY_CHECKSUM(*) * RAND()) AS INT)) % 1000) <= 100 " +
            //           "AND dc.CountryCode IN " +
            //"(CASE " +
            //     "WHEN @CountryCodeCOndition = 'US' " +
            //     "THEN 'US' " +
            //     "WHEN @CountryCodeCOndition = 'CA' " +
            //     "THEN 'CA' " +
            //     "ELSE 'US' " +
            // "END " +
            //") " +
            //     "ORDER BY dc.CustomerID DESC) " +
            //     "SELECT TOP 1 cust.CustomerID, " +
            //                  "cust.FirstName+' '+cust.LastName AS FullName, " +
            //                  "cust.Email, " +
            //                  "CASE " +
            //                      "WHEN cust.GenderCode = 'U' " +
            //                      "THEN 'Unspecified' " +
            //                      "ELSE cust.GenderCode " +
            //                  "END AS GenderCode, " +
            //                  "Languages, " +
            //                  "stay.CompanyName, " +
            //                  "cust.PropertyCode, " +
            //                  "cust.InsertDate, " +
            //                  "cust.UpdateDate, " +
            //                  "ldsc.SourceName, " +
            //                  "Email, " +
            //                  "PhoneNumber, " +
            //                  "Address1, " +
            //                  "address2, " +
            //                  "City, " +
            //                  "StateProvinceCode, " +
            //                  "ZipCode, " +
            //                  "CountryCode, " +
            //                  "ldas.Name AS AddressStatus " +
            //     "FROM D_CUSTOMER AS cust  " +
            //          "INNER JOIN d_customer_stay AS Stay  ON cust.customerID = Stay.customerID " +
            //          "INNER JOIN dbo.L_DATA_SOURCE_CODE ldsc  ON ldsc.PropertyCode = cust.PropertyCode " +
            //          "INNER JOIN dbo.L_DATA_EMAIL_STATUS ldes  ON ldes.EmailStatus = cust.EmailStatus " +
            //          "INNER JOIN dbo.L_DATA_ADDRESS_STATUS ldas  ON ldas.AddressStatus = cust.AddressStatus " +
            //          "INNER JOIN RandDCustomerID rdc  ON rdc.CustomerID = cust.CustomerID;";
            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProfileData.CustomerID = reader["CustomerID"].ToString();
                            ProfileData.FirstName = reader["FirstName"].ToString();
                            ProfileData.LastName = reader["LastName"].ToString();
                            ProfileData.Email = reader["Email"].ToString();
                            ProfileData.GenderCode = reader["GenderCode"].ToString();
                            ProfileData.Languages = reader["Languages"].ToString();
                            ProfileData.PropertyCode = reader["PropertyCode"].ToString();
                            ProfileData.InsertDate = reader["InsertDate"].ToString();
                            ProfileData.UpdateDate = reader["UpdateDate"].ToString();
                            ProfileData.SourceName = reader["SourceName"].ToString();
                            ProfileData.PhoneNumber = reader["PhoneNumber"].ToString();
                            ProfileData.Address1 = reader["Address1"].ToString();
                            ProfileData.City = reader["City"].ToString();
                            ProfileData.StateProvinceCode = reader["StateName"].ToString();
                            ProfileData.ZipCode = reader["ZipCode"].ToString();
                            ProfileData.CountryCode = reader["CountryCode"].ToString();
                            ProfileData.AddressStatus = reader["AddressStatus"].ToString();
                        }
                    }
                }
                connection.Close();
                return ProfileData;
            }
        }

        public static ProfileCustData GetProfileData(ProfileCustData stayData, string CompanyName, int caseNum, string groupID)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(CompanyName, Connstr);
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";

            switch (caseNum)
            {
                case 1:
                    query = query + "IF OBJECT_ID('tempdb..#stays') IS NOT NULL " +
                                "DROP TABLE #stays; " +
                            "IF OBJECT_ID('tempdb..#GetCustomerIDs') IS NOT NULL " +
                                "DROP TABLE #GetCustomerIDs; " +
                            "IF OBJECT_ID('tempdb..#GroupCustomers') IS NOT NULL " +
                                "DROP TABLE #GroupCustomers; " +
                            "DECLARE @tcName NVARCHAR(255); " +

                            "/*Get the Customer having Stays*/ " +

                            "SELECT TOP 10000 " +
                                   "dcs.CustomerID, " +
                                   "COUNT(dcs.CustomerID) countss " +
                            "INTO #stays " +
                            "FROM dbo.D_CUSTOMER_STAY dcs  " +
                            "GROUP BY dcs.CustomerID " +
                            "HAVING COUNT(dcs.CustomerID) < 20; " +

                            "/*Get list of Customer from D_Customer Table*/ " +

                            "SELECT DISTINCT TOP 10000 " +
                                   "dcs.CustomerID " +
                            "INTO #GetCustomerIDs " +
                            "FROM dbo.D_CUSTOMER dc  " +
                                "INNER JOIN #stays dcs " +
                                    "ON dcs.CustomerID = dc.CustomerID " +
                            "WHERE ISNULL(dc.Email, '') <> ''; " +

                            "/*Get the Global Profile Group, GroupCustomer and Primary Customer */ " +
                            "WITH Results AS ( " +
                            "SELECT TOP 1000 " +
                                       "CONVERT(VARCHAR(255), gpm.GroupID) AS GroupID " +
                                "FROM dbo.Global_Profile_Mapping AS gpm  " +
                                    "INNER JOIN #GetCustomerIDs AS c " +
                                        "ON c.CustomerID = gpm.CustomerID " +
                                "GROUP BY gpm.GroupID, " +
                                         "gpm.CustomerID " +
                                "HAVING COUNT(gpm.GroupID) < 5 " +
                                "ORDER BY GroupID DESC) " +
                            "SELECT TOP 1 " +
                                   "r.GroupID " +
                            "INTO #GroupCustomers " +
                            "FROM Results r " +
                            "ORDER BY NEWID() DESC; " +

                            "/*Group all GroupIDs in one */ " +
                            "SELECT STUFF( " +
                                   "( " +
                                       "SELECT ',' + GroupID " +
                                       "FROM " +
                                       "(SELECT DISTINCT r.GroupID FROM #GroupCustomers AS r) AS x " +
                                       "FOR XML PATH('') " +
                                   "),1, 1, '') AS GroupIDs; ";
                    using (var connection = new SqlConnection(Connstr.ConnectonString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.CommandTimeout = 180;
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    stayData.GroupID = reader["GroupIDs"].ToString();
                                }
                            }
                        }
                        connection.Close();
                    }
                    break;

                case 2:
                    query = query + "DECLARE @GroupID INT = '" + groupID + "'; " +
                            "IF OBJECT_ID('tempdb..#GetCustomerIDs') IS NOT NULL " +
                                "DROP TABLE #GetCustomerIDs; " +
                            "IF OBJECT_ID('tempdb..#GroupCustomers') IS NOT NULL " +
                                "DROP TABLE #GroupCustomers; " +
                            "IF OBJECT_ID('tempdb..#GetCustReservations') IS NOT NULL " +
                                "DROP TABLE #GetCustReservations; " +
                            "IF OBJECT_ID('tempdb..#CustomerIDsSplit') IS NOT NULL " +
                                "DROP TABLE #CustomerIDsSplit; " +

                            "/* Get the Global Profile Group, GroupCustomer and Primary Customer */ " +

                            "SELECT TOP 1 gpm.GroupID, " +
                                         "LTRIM(RTRIM(STUFF( " +
                            "( " +
                                "SELECT ',' + CONVERT(VARCHAR(MAX), gpm2.CustomerID) " +
                                "FROM dbo.Global_Profile_Mapping gpm2 WITH(NOLOCK) " +
                                "WHERE(gpm2.GroupID = gpm.GroupID) " +
                                "ORDER BY gpm2.GlobalRanking FOR XML PATH('') " +
                            "), 1, 1, ''))) AS CustomerIDs, " +
                            "( " +
                                "SELECT gpm2.CustomerID " +
                                "FROM dbo.Global_Profile_Mapping gpm2 WITH(NOLOCK) " +
                                "WHERE(gpm2.GroupID = gpm.GroupID) " +
                                     "AND gpm2.GlobalRanking = 1 " +
                            ") AS PrimaryCustomer " +
                            "INTO #GroupCustomers " +
                            "FROM dbo.Global_Profile_Mapping gpm WITH(NOLOCK) " +
                            "WHERE gpm.GroupID = @GroupID " +
                            "GROUP BY gpm.GroupID, " +
                                     "gpm.CustomerID; " +

                            "/* Get Reservation as per GroupID */ " +

                            "DECLARE @CustomerIDSplit NVARCHAR(255); " +
                            "SELECT @CustomerIDSplit = CustomerIDs " +
                            "FROM #GroupCustomers gc; " +
                            "SELECT @GroupID AS GroupID, " +
                                   "ss.token " +
                            "INTO #CustomerIDsSplit " +
                            "FROM utility.split_string(@CustomerIDSplit, ',') ss; " +
                            "WITH Ress " +
                                 "AS (SELECT cids.GroupID, " +
                                            "dcs.ReservationNumber, " +
                                            "dcs.SubReservationNumber " +
                                     "FROM #CustomerIDsSplit cids " +
                                          "INNER JOIN dbo.D_CUSTOMER_STAY dcs WITH(NOLOCK) ON dcs.CustomerID = cids.token) " +
                                 "SELECT gc.GroupID, " +
                                        "LTRIM(RTRIM(STUFF( " +
                                 "( " +
                                     "SELECT ',' + CONVERT(VARCHAR(MAX), gc2.ReservationNumber) " +
                                     "FROM Ress gc2 " +
                                     "WHERE(gc.GroupID = gc2.GroupID) FOR XML PATH('') " +
                                 "), 1, 1, ''))) AS ReservationNumber, " +
                                        "LTRIM(RTRIM(STUFF( " +
                                 "( " +
                                     "SELECT ',' + CONVERT(VARCHAR(MAX), gc2.SubReservationNumber) " +
                                     "FROM Ress gc2 " +
                                     "WHERE(gc.GroupID = gc2.GroupID) FOR XML PATH('') " +
                                 "), 1, 1, ''))) AS SubReservationNumber " +
                                 "INTO #GetCustReservations " +
                                 "FROM Ress gc " +
                                 "GROUP BY gc.GroupID; " +

                            "/* Combined Customer Profile Details, Stays and Subscription Detail */ " +

                            "SELECT gc.PrimaryCustomer, " +
                                   "gc.CustomerIDs, " +
                                   "ISNULL(cust.ShortTitle, '') AS ShortTitle, " +
                                   "ISNULL(cust.Title, '') AS Title, " +
                                   "cust.FirstName, " +
                                   "cust.LastName, " +
                                   "cust.Email, " +
                                   "CASE " +
                                       "WHEN cust.GenderCode = 'U' " +
                                       "THEN 'Unspecified' " +
                                       "WHEN cust.GenderCode IS NULL " +
                                       "THEN '' " +
                                       "ELSE cust.GenderCode " +
                                   "END AS GenderCode, " +
                                   "ISNULL(cust.Languages, '') AS Languages, " +
                                   "ISNULL(dp.PropertyName, '') AS PropertyCode, " +
                                   "ISNULL(FORMAT(cust.InsertDate, 'M/d/yyyy'), '') AS InsertDate, " +
                                   "ISNULL(FORMAT(cust.UpdateDate, 'M/d/yyyy'), '') AS UpdateDate, " +
                                   "ISNULL(ldsc.SourceName, '') AS SourceName, " +
                                   "ISNULL(cust.PhoneNumber, '') AS PhoneNumber, " +
                                   "ISNULL(cust.PhoneExtension, '') AS PhoneExt, " +
                                   "ISNULL(cust.CellPhoneNumber, '') AS MobilePhone, " +
                                   "ISNULL(cust.BusinessPhoneNumber, '') AS WorkPhone, " +
                                   "ISNULL(cust.HomePhoneNumber, '') AS HomePhone, " +
                                   "ISNULL(cust.Address1, '') AS Address1, " +
                                   "ISNULL(cust.City, '') AS City, " +
                                   "ISNULL(lgsc.StateName, '') AS StateName, " +
                                   "ISNULL(cust.ZipCode, '') AS ZipCode, " +
                                   "ISNULL(cust.CountryCode, '') AS CountryCode, " +
                                   "ISNULL(ldas.Name, '') AS AddressStatus, " +
                                   "CASE " +
                                       "WHEN ldes.Name = 'Valid Email' " +
                                       "THEN 'Valid Email' " +
                                       "ELSE ldes.Name " +
                                   "END AS EmailStatus, " +
                                   "gcr.ReservationNumber, " +
                                   "gcr.SubReservationNumber, " +
                                   "cust.SourceGuestID " +
                            "FROM D_CUSTOMER AS cust WITH(NOLOCK) " +
                                 "INNER JOIN #GroupCustomers gc ON cust.CustomerID = gc.PrimaryCustomer " +
                                 "INNER JOIN #GetCustReservations gcr ON gc.GroupID = gcr.GroupID " +
                                 "LEFT JOIN dbo.D_PROPERTY dp WITH(NOLOCK) ON dp.PropertyCode = cust.PropertyCode " +
                                 "INNER JOIN dbo.L_DATA_SOURCE_CODE ldsc WITH(NOLOCK) ON ldsc.SourceID = cust.SourceID " +
                                 "INNER JOIN dbo.L_DATA_EMAIL_STATUS ldes WITH(NOLOCK) ON ldes.EmailStatus = cust.EmailStatus " +
                                 "INNER JOIN dbo.L_DATA_ADDRESS_STATUS ldas WITH(NOLOCK) ON ldas.AddressStatus = cust.AddressStatus " +
                                 "LEFT JOIN dbo.L_GEO_STATE_CODE lgsc WITH(NOLOCK) ON lgsc.StateCode = cust.StateProvinceCode " +
                            "WHERE ISNULL(cust.Email, '') <> '';";

                    using (var connection = new SqlConnection(Connstr.ConnectonString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.CommandTimeout = 60;
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    stayData.PrimaryCustomer = reader["PrimaryCustomer"].ToString();
                                    stayData.CustomerIDs = reader["CustomerIDs"].ToString();
                                    stayData.ShortTitle = reader["ShortTitle"].ToString();
                                    stayData.Title = reader["Title"].ToString();
                                    stayData.FirstName = reader["FirstName"].ToString();
                                    stayData.LastName = reader["LastName"].ToString();
                                    stayData.Email = reader["Email"].ToString();
                                    stayData.GenderCode = reader["GenderCode"].ToString();
                                    stayData.Languages = reader["Languages"].ToString();
                                    stayData.PropertyCode = reader["PropertyCode"].ToString();
                                    stayData.InsertDate = reader["InsertDate"].ToString();
                                    stayData.UpdateDate = reader["UpdateDate"].ToString();
                                    stayData.SourceName = reader["SourceName"].ToString();
                                    stayData.PhoneNumber = reader["PhoneNumber"].ToString();
                                    stayData.PhoneExt = reader["PhoneExt"].ToString();
                                    stayData.MobilePhone = reader["MobilePhone"].ToString();
                                    stayData.WorkPhone = reader["WorkPhone"].ToString();
                                    stayData.HomePhone = reader["HomePhone"].ToString();
                                    stayData.Address1 = reader["Address1"].ToString();
                                    stayData.City = reader["City"].ToString();
                                    stayData.StateProvinceCode = reader["StateName"].ToString();
                                    stayData.ZipCode = reader["ZipCode"].ToString();
                                    stayData.CountryCode = reader["CountryCode"].ToString();
                                    stayData.AddressStatus = reader["AddressStatus"].ToString();
                                    stayData.EmailStatus = reader["EmailStatus"].ToString();
                                    stayData.ReservationNumber = reader["ReservationNumber"].ToString();
                                    stayData.SubReservationNumber = reader["SubReservationNumber"].ToString();
                                    stayData.SourceGuestID = reader["SourceGuestID"].ToString();
                                }
                            }
                        }
                        connection.Close();
                    }
                    break;

            }
            return stayData;
        }



        public static ProfileCustData GetCustomerProfileData_Others(ProfileCustData ProfileData, string CompanyName)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(CompanyName, Connstr);
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "WITH RandDCustomerID " +
                         "AS ( " +
                    "SELECT TOP 1 dc.CustomerID " +
                         "FROM dbo.D_CUSTOMER dc  " +
                              "INNER JOIN dbo.d_customer_stay dcs  ON dc.customerID = dcs.customerID " +
                         "WHERE dc.Email IS NOT NULL " +
                               "AND ISNULL(dc.City, '') != ''" +
                               "AND ISNULL(dc.StateProvinceCode, '') != ''" +
                               "AND (ABS(CAST((BINARY_CHECKSUM(*) * RAND()) AS INT)) % 1000) <= 100 " +
                               "AND dc.CountryCode Not IN ('CA', 'US')" +
                         "ORDER BY dc.CustomerID DESC) " +
                    "SELECT TOP 1 cust.CustomerID, " +
                                      "cust.FirstName+' '+cust.LastName AS FullName, " +
                                      "cust.Email, " +
                                      "CASE " +
                                          "WHEN cust.GenderCode = 'U' " +
                                          "THEN 'Unspecified' " +
                                          "ELSE cust.GenderCode " +
                                      "END AS GenderCode, " +
                                      "Languages, " +
                                      "stay.CompanyName, " +
                                      "cust.PropertyCode, " +
                                      "cust.InsertDate, " +
                                      "cust.UpdateDate, " +
                                      "ldsc.SourceName, " +
                                      "Email, " +
                                      "PhoneNumber, " +
                                      "Address1, " +
                                      "address2, " +
                                      "City, " +
                                      "StateProvinceCode, " +
                                      "ZipCode, " +
                                      "CountryCode, " +
                                      "ldas.Name AS AddressStatus" +
                         "FROM D_CUSTOMER AS cust  " +
                              "INNER JOIN d_customer_stay AS Stay  ON cust.customerID = Stay.customerID " +
                              "INNER JOIN dbo.L_DATA_SOURCE_CODE ldsc  ON ldsc.PropertyCode = cust.PropertyCode " +
                              "INNER JOIN dbo.L_DATA_EMAIL_STATUS ldes  ON ldes.EmailStatus = cust.EmailStatus " +
                              "INNER JOIN dbo.L_DATA_ADDRESS_STATUS ldas  ON ldas.AddressStatus = cust.AddressStatus " +
                              "INNER JOIN RandDCustomerID rdc  ON rdc.CustomerID = cust.CustomerID;";
            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProfileData.CustomerID = reader["CustomerID"].ToString();
                            ProfileData.FirstName = reader["FirstName"].ToString();
                            ProfileData.LastName = reader["LastName"].ToString();
                            ProfileData.Email = reader["Email"].ToString();
                            ProfileData.GenderCode = reader["GenderCode"].ToString();
                            ProfileData.Languages = reader["Languages"].ToString();
                            ProfileData.CompanyName = reader["CompanyName"].ToString();
                            ProfileData.PropertyCode = reader["PropertyCode"].ToString();
                            ProfileData.InsertDate = reader["InsertDate"].ToString();
                            ProfileData.UpdateDate = reader["UpdateDate"].ToString();
                            ProfileData.SourceName = reader["SourceName"].ToString();
                            ProfileData.PhoneNumber = reader["PhoneNumber"].ToString();
                            ProfileData.Address1 = reader["Address1"].ToString();
                            ProfileData.Address2 = reader["address2"].ToString();
                            ProfileData.City = reader["City"].ToString();
                            ProfileData.StateProvinceCode = reader["StateProvinceCode"].ToString();
                            ProfileData.ZipCode = reader["ZipCode"].ToString();
                            ProfileData.CountryCode = reader["CountryCode"].ToString();
                            ProfileData.AddressStatus = reader["AddressStatus"].ToString();
                        }
                    }
                }
                connection.Close();
                return ProfileData;
            }
        }
        public static string VerifyStateCodeMatch(string CountryCode)
        {
            string pmsCustomer;
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "Declare @StateProvince VARCHAR(10) = '" + CountryCode + "'; " +
                    "DECLARE @CheckExpressions NVARCHAR(10)= " +
                    "( " +
                        "SELECT LEN(lgsc.StateCode) " +
                        "FROM dbo.L_GEO_STATE_CODE lgsc  " +
                        "WHERE lgsc.StateCode = @StateProvince AND lgsc.CountryCode = 'CA' " +
                    "); " +
                    "SELECT @CheckExpressions " +
                    "SELECT CASE " +
                               "WHEN @CheckExpressions IS NULL " +
                               "THEN 'Record does not exist in table.' " +
                               "WHEN @CheckExpressions > 1 " +
                               "THEN 'Record exist in table.' " +
                           "END AS CheckExpressions;";

            columnName = "CheckExpressions";

            DBHelper.OpenDB();
            pmsCustomer = DBHelper.ExecuteQueryAndReturnColumn(query, columnName);
            DBHelper.CloseDB();

            return pmsCustomer;
        }
        public static ProfileCustData VerifyCampaignData(ProfileCustData StayData, string CompanyName, string EmailStatus, int queryCase)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(CompanyName, Connstr);
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";

            switch (queryCase)
            {
                /*ProjectID:6417357*/
                case 0:
                    {
                        query = query + " WITH EmailResult " +
                                 "AS ( " +
                                 "SELECT srd.Email, " +
                                        "srms.Subject " +
                                 "FROM dbo.SM_REPORT_DELIVERED srd  " +
                                      "INNER JOIN dbo.SM_REPORT_MAILING_SUMMARY srms  ON srms.ChildProjectID = srd.ChildProjectID " +
                                 "WHERE srms.ParentProjectID = '40012875') " +
                                 "SELECT TOP 1 dc.CustomerID, " +
                                              "dc.FirstName, " +
                                              "dc.LastName, " +
                                              "dc.Email, " +
                                              "CASE " +
                                                  "WHEN ISNULL(dc.CountryCode, '') = '' " +
                                                  "THEN 'N/A' " +
                                                  "ELSE dc.CountryCode " +
                                              "END AS CountryCode, " +
                                              "CASE " +
                                                  "WHEN ISNULL(dcs.ArrivalDate, '') = '' " +
                                                  "THEN 'N/A' " +
                                                  "ELSE CONVERT(NVARCHAR(25), dcs.ArrivalDate, 101)" +
                                              "END AS ArrivalDate, " +
                                              "CASE " +
                                                  "WHEN ISNULL(dcs.SourceStayID, 0) = 0 " +
                                                  "THEN CAST('N/A' AS NVARCHAR(10)) " +
                                                  "ELSE CONVERT(NVARCHAR(25), dcs.SourceStayID) " +
                                              "END AS SourceStayID, " +
                                              "CASE " +
                                                  "WHEN ISNULL(dcs.ReservationNumber, '') = '' " +
                                                  "THEN CAST('N/A' AS NVARCHAR(10)) " +
                                                  "ELSE dcs.ReservationNumber " +
                                              "END AS ReservationNumber, " +
                                 "EmailResult.Subject " +
                                 "FROM dbo.D_CUSTOMER dc  " +
                                      "LEFT JOIN dbo.D_CUSTOMER_STAY dcs  ON dcs.CustomerID = dc.CustomerID " +
                                      "INNER JOIN EmailResult ON EmailResult.Email = dc.Email " +
                                 "where dc.EmailStatus = " + EmailStatus +
                                       "AND ISNULL(dcs.ArrivalDate, '') != '' " +
                                 "ORDER BY NEWID();";
                        break;
                    }
                case 1:
                    {
                        query = query + " WITH EmailResult " +
                                 "AS ( " +
                                 "SELECT srd.Email, " +
                                        "srms.Subject " +
                                 "FROM dbo.SM_REPORT_DELIVERED srd  " +
                                      "INNER JOIN dbo.SM_REPORT_MAILING_SUMMARY srms  ON srms.ChildProjectID = srd.ChildProjectID " +
                                 "WHERE srms.ParentProjectID = '40012875') " +
                                 "SELECT TOP 1 dc.CustomerID, " +
                                              "dc.FirstName, " +
                                              "dc.LastName, " +
                                              "dc.Email, " +
                                              "CASE " +
                                                  "WHEN ISNULL(dc.CountryCode, '') = '' " +
                                                  "THEN 'N/A' " +
                                                  "ELSE dc.CountryCode " +
                                              "END AS CountryCode, " +
                                              "CASE " +
                                                  "WHEN ISNULL(dcs.ArrivalDate, '') = '' " +
                                                  "THEN 'N/A' " +
                                                  "ELSE CONVERT(NVARCHAR(25), dcs.ArrivalDate, 101) " +
                                              "END AS ArrivalDate, " +
                                              "CASE " +
                                                  "WHEN ISNULL(dcs.SourceStayID, 0) = 0 " +
                                                  "THEN CAST('N/A' AS NVARCHAR(10)) " +
                                                  "ELSE CONVERT(NVARCHAR(25), dcs.SourceStayID) " +
                                              "END AS SourceStayID, " +
                                              "CASE " +
                                                  "WHEN ISNULL(dcs.ReservationNumber, '') = '' " +
                                                  "THEN CAST('N/A' AS NVARCHAR(10)) " +
                                                  "ELSE dcs.ReservationNumber " +
                                              "END AS ReservationNumber, " +
                                              "EmailResult.Subject " +
                                 "FROM dbo.D_CUSTOMER dc  " +
                                      "LEFT JOIN dbo.D_CUSTOMER_STAY dcs  ON dcs.CustomerID = dc.CustomerID " +
                                      "INNER JOIN EmailResult ON EmailResult.Email = dc.Email " +
                                 "WHERE dc.EmailStatus = " + EmailStatus +
                                       "AND dc.CustomerID = 1759183 " +
                                       "AND ISNULL(dc.CountryCode, '') != '' " +
                                 "ORDER BY NEWID();";
                        break;
                    }
            }

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 120;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StayData.CustomerID = reader["CustomerID"].ToString();
                            StayData.FirstName = reader["FirstName"].ToString();
                            StayData.LastName = reader["LastName"].ToString();
                            StayData.Email = reader["Email"].ToString();
                            StayData.CountryCode = reader["CountryCode"].ToString();
                            StayData.ArrivalDate = reader["ArrivalDate"].ToString();
                            StayData.SourceStayID = reader["SourceStayID"].ToString();
                            StayData.CampaignSubject = reader["Subject"].ToString();
                            StayData.ReservationNumber = reader["ReservationNumber"].ToString();
                        }
                    }
                }
                connection.Close();
                return StayData;
            }
        }

        public static ProfileCustData GetCustomerIDSendTest(ProfileCustData StayData, string CompanyName)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(CompanyName, Connstr);
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "WITH getsendtotest " +
                     "AS ( " +
                     "SELECT DISTINCT TOP 1 dc.CustomerID " +
                     "FROM dbo.SM_REPORT_DELIVERED srd  " +
                          "INNER JOIN dbo.SM_REPORT_MAILING_SUMMARY srms  ON srms.ChildProjectID = srd.ChildProjectID " +
                          "INNER JOIN dbo.D_CUSTOMER dc  ON dc.Email = srd.Email " +
                     "WHERE srms.ParentProjectID = 6417357 " +
                     "ORDER BY dc.CustomerID ASC) " +
                     "SELECT dc.CustomerID, " +
                            "dc.FirstName, " +
                            "dc.LastName, " +
                            "dc.Email, " +
                            "CONVERT(DATE, dcs.ArrivalDate, 101) AS ArrivalDate, " +
                            "dcs.SourceStayID " +
                     "FROM dbo.D_CUSTOMER dc  " +
                          "INNER JOIN dbo.D_CUSTOMER_STAY dcs  ON dcs.CustomerID = dc.CustomerID " +
                          "INNER JOIN getsendtotest ON getsendtotest.CustomerID = dc.CustomerID;";
            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StayData.CustomerID = reader["CustomerID"].ToString();
                            StayData.FirstName = reader["FirstName"].ToString();
                            StayData.LastName = reader["LastName"].ToString();
                            StayData.Email = reader["Email"].ToString();
                            StayData.ArrivalDate = reader["ArrivalDate"].ToString();
                            StayData.SourceStayID = reader["SourceStayID"].ToString();
                        }
                    }
                }
                connection.Close();
                return StayData;
            }
        }
        public static Users GetCustomerDataForSendTest(Users StayData, string CompanyName)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(CompanyName, Connstr);
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + " IF OBJECT_ID('tempdb..#EmailResult') IS NOT NULL " +
                    "DROP TABLE #EmailResult; " +

                    "SELECT srd.Email, " +
                           "srms.Subject " +
                    "INTO #EmailResult " +
                    "FROM dbo.SM_REPORT_DELIVERED srd  " +
                         "INNER JOIN dbo.SM_REPORT_MAILING_SUMMARY srms  ON srms.ChildProjectID = srd.ChildProjectID " +
                    "WHERE srms.ParentProjectID = '6417357'; " +

                    "SELECT TOP 1 dc.CustomerID, " +
                                 "dc.FirstName, " +
                                 "dc.LastName, " +
                                 "dc.Email, " +
                                 "CASE " +
                                     "WHEN ISNULL(dc.CountryCode, '') = '' " +
                                     "THEN 'N/A' " +
                                     "ELSE dc.CountryCode " +
                                 "END AS CountryCode, " +
                                 "CASE " +
                                     "WHEN ISNULL(dcs.ArrivalDate, '') = '' " +
                                     "THEN 'N/A' " +
                                     "ELSE CONVERT(NVARCHAR(25), dcs.ArrivalDate, 101) " +
                                 "END AS ArrivalDate, " +
                                 "CASE " +
                                     "WHEN ISNULL(dcs.SourceStayID, 0) = 0 " +
                                     "THEN CAST('N/A' AS NVARCHAR(10)) " +
                                     "ELSE CONVERT(NVARCHAR(25), dcs.SourceStayID) " +
                                 "END AS SourceStayID, " +
                                 "er.Subject " +
                    "FROM dbo.D_CUSTOMER dc  " +
                         "LEFT JOIN dbo.D_CUSTOMER_STAY dcs  ON dcs.CustomerID = dc.CustomerID " +
                         "INNER JOIN #EmailResult er ON er.Email = dc.Email " +
                    "ORDER BY CustomerID ASC;";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StayData.CustomerID = reader["CustomerID"].ToString();
                            StayData.FirstName = reader["FirstName"].ToString();
                            StayData.LastName = reader["LastName"].ToString();
                            StayData.Email = reader["Email"].ToString();
                            StayData.CountryCode = reader["CountryCode"].ToString();
                            StayData.ArrivalDate = reader["ArrivalDate"].ToString();
                            StayData.SourceStayID = reader["SourceStayID"].ToString();
                            StayData.CampaignSubject = reader["Subject"].ToString();
                        }
                    }
                }
                connection.Close();
                return StayData;
            }
        }

        public static ProfileCustData GetSendtoTestEmailTriggeredData(string projectID, string companyName, ProfileCustData custData)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + " SELECT P9 AS Email " +
                    "FROM dbo.eInsight_Dynamic_Customer_Extract_StrongMail eidcesm  " +
                    "WHERE ProjectID = " + projectID + ";";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            custData.Email = reader["Email"].ToString();
                        }
                    }
                }
                connection.Close();
                return custData;
            }
        }


        public static Users GetPersonalizedTagValue(Users ProfileData, string CompanyName, int caseNum, string ReservationNumber, string projectID, string customerID)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(CompanyName, Connstr);
            GetDatabaseName();
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";

            switch (caseNum)
            {

                case 0:
                    query = query + "IF OBJECT_ID('criteria_email_result', 'U') IS NOT NULL " +
                                    "DROP TABLE criteria_email_result; " +
                                "IF OBJECT_ID('GetEmailResult', 'U') IS NOT NULL " +
                                    "DROP TABLE GetEmailResult; " +
                                "IF OBJECT_ID('tempdb..#CustomerRFM') IS NOT NULL " +
                                    "DROP TABLE #CustomerRFM; " +
                                "IF OBJECT_ID('tempdb..#DCustomer') IS NOT NULL " +
                                    "DROP TABLE #DCustomer; " +
                                "IF OBJECT_ID('tempdb..#DCustomerStay') IS NOT NULL " +
                                    "DROP TABLE #DCustomerStay; " +
                                "IF OBJECT_ID('tempdb..#criteria_email_result') IS NOT NULL " +
                                    "DROP TABLE #criteria_email_result; " +
                                "IF OBJECT_ID('tempdb..#lessStays') IS NOT NULL " +
                                    "DROP TABLE #lessStays; " +
                                "DECLARE @querySelector VARCHAR(MAX); " +
                                "DECLARE @GetCustomerID INT; " +
                                "SET @querySelector = " +
                                "( " +
                                    "SELECT CONVERT(VARCHAR(MAX), dcc.sqlPreSelect) + CHAR(10) + CONVERT(VARCHAR(MAX), dcc.sqlPostSelect) " +
                                    "FROM dbo.D_CUSTOMER_CRITERIA dcc WITH(NOLOCK) " +
                                    "WHERE dcc.ProjectID = " + projectID +
                                "); " +
                                "SET @querySelector = REPLACE(@querySelector, '[#criteria_email_result]', '[criteria_email_result]'); " +
                                "EXEC (@querySelector); " +
                                "SELECT r.customer_id, " +
                                       "r.stay_id, " +
                                       "r.email_id, " +
                                       "r.email_source_id " +
                                "INTO GetEmailResult " +
                                "FROM criteria_email_result r; " +
                                "DROP TABLE criteria_email_result; " +
                                "WITH Results " +
                                     "AS (SELECT customer_id, " +
                                                "dc.Email, " +
                                                "ROW_NUMBER() OVER(PARTITION BY dc.CustomerID " +
                                                "ORDER BY dc.Email) row_num " +
                                         "FROM GetEmailResult gr " +
                                              "INNER JOIN dbo.D_CUSTOMER dc WITH(NOLOCK) ON dc.CustomerID = gr.customer_id " +
                                         "WHERE(dc.FirstName NOT LIKE '%[0-9]%' " +
                                               "AND dc.LastName NOT LIKE '%[0-9]%' " +
                                               "AND dc.LastName <> 'Uset/Usef' " +
                                               "AND dc.LastName NOT LIKE '%/%')) " +
                                     "SELECT r.customer_id, " +
                                            "r.Email, " +
                                            "ROW_NUMBER() OVER(PARTITION BY r.customer_id " +
                                            "ORDER BY r.Email) rn " +
                                     "INTO #lessStays " +
                                     "FROM dbo.D_CUSTOMER_STAY dcs WITH(NOLOCK) ";
                    if (testCategory == "PostDeployment"|| testCategory=="EU02_PostDeployment")
                    {
                        query = query + "RIGHT JOIN Results r ON r.customer_id = dcs.CustomerID ";
                    }
                    else
                    {
                        query = query + "INNER JOIN Results r ON r.customer_id = dcs.CustomerID ";
                    }

                    if (testCategory != "PostDeployment" && testCategory != "EU02_PostDeployment")
                    {
                        query = query + "WHERE r.row_num < 2 "; 
                    }
                    if (projectID == "40012827")
                    {
                        query = query + " AND dcs.PropertyCode IN ('DUANE', 'INDEPEN', 'INDEPENDENTC'); ";
                    }
                    query = query +
                           "SELECT STUFF( " +
                            "( " +
                                "SELECT ',' + CONVERT(VARCHAR(255), x.customer_id) " +
                                "FROM " +
                                "( " +
                                    "SELECT TOP 1 l.customer_id " +
                                    "FROM #lessStays l " +
                                    "ORDER BY NEWID() " +
                                ") AS x FOR XML PATH('') " +
                            "), 1, 1, '') AS CustomerIDs; " +
                            "IF OBJECT_ID('criteria_email_result', 'U') IS NOT NULL " +
                                "DROP TABLE criteria_email_result; " +
                            "IF OBJECT_ID('tempdb..#CustomerRFM') IS NOT NULL " +
                                "DROP TABLE #CustomerRFM; " +
                            "IF OBJECT_ID('tempdb..#DCustomer') IS NOT NULL " +
                                "DROP TABLE #DCustomer; " +
                            "IF OBJECT_ID('tempdb..#DCustomerStay') IS NOT NULL " +
                                "DROP TABLE #DCustomerStay;";


                    using (var connection = new SqlConnection(Connstr.ConnectonString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.CommandTimeout = 600;
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    ProfileData.CustomerIDs = reader["CustomerIDs"].ToString();
                                }
                            }
                        }
                        connection.Close();
                    }

                    break;
                case 1:
                    query = query + " DECLARE @customerID INT= " + customerID + "; " +
                            "DECLARE @projectID INT= " + projectID + "; " +

                            "IF OBJECT_ID('tempdb..#projectDetails') IS NOT NULL " +
                                "DROP TABLE #projectDetails; " +
                            "IF OBJECT_ID('tempdb..#DCustomer') IS NOT NULL " +
                                "DROP TABLE #DCustomer; " +
                            "IF OBJECT_ID('tempdb..#D_CUSTOMER_STAY') IS NOT NULL " +
                                "DROP TABLE #D_CUSTOMER_STAY; " +
                            "IF OBJECT_ID('tempdb..#V_GA_Memberships') IS NOT NULL " +
                                "DROP TABLE #V_GA_Memberships; " +
                            "IF OBJECT_ID('tempdb..#v_Omni_FieldData_API') IS NOT NULL " +
                                "DROP TABLE #v_Omni_FieldData_API; " +

                            "/*Get Project Details*/ " +

                            "SELECT TOP 1 @customerID AS CustomerID, " +
                                         "p.fromname, " +
                                         "p.fromemail, " +
                                         "p.EmailCampaignSubject, " +
                                         "c.CompanyName, " +
                                         "CASE " +
                                             "WHEN ISNULL(p.eContact_Campaign_ParentProjectID, '') = '' " +
                                             "THEN p.ID " +
                                             "ELSE p.eContact_Campaign_ParentProjectID " +
                                         "END AS ProjectID " +
                            "INTO #projectDetails " +
                            "FROM [APPDBSERVER]."+ dbName + ".[dbo].[projects] p WITH(NOLOCK) " +
                            "INNER JOIN [APPDBSERVER]." + dbName + ".[dbo].[Company] [c] ON c.CompanyID = p.CompanyID " +
                                    "WHERE p.eContact_Campaign_ParentProjectID = @projectID  OR p.ID = @projectID " +
                                    "ORDER BY ID DESC; ";
                    query = query + 
                            "/*Customer*/ " +

                            "SELECT TOP 1 dc.CustomerID, " +
                                   "dc.FirstName, " +
                                   "dc.LastName, " +
                                   "'' AS MemberLevel, " +
                                   "dc.Email, " +
                                   "dc.ZipCode " +
                            "INTO #DCustomer " +
                            "FROM dbo.D_CUSTOMER dc WITH(NOLOCK) " +
                            "INNER JOIN dbo.GetEmailResult ger ON dc.CustomerID = ger.customer_id " +
                            "WHERE dc.CustomerID = @customerID; " +

                            "/*Stay and Other */ " +

                            "SELECT dcs.CustomerID, " +
                                   "dcs.SourceStayID, " +
                                   "dcs.ReservationNumber, " +
                                   "ArrivalDate, " +
                                   "DepartureDate, " +
                                   "CancelDate, " +
                                   "LegNumbers, " +
                                   "Points, " +
                                   "AverageDailyRevenueWithTax, " +
                                   "dp.PropertyName " +
                            "INTO #D_CUSTOMER_STAY " +
                            "FROM dbo.D_CUSTOMER_STAY dcs WITH(NOLOCK) " +
                                 "INNER JOIN dbo.D_PROPERTY dp WITH(NOLOCK) ON dp.PropertyCode = dcs.PropertyCode " +
                                 "INNER JOIN dbo.GetEmailResult ger ON dcs.SourceStayID = ger.stay_id " +
                            "WHERE dcs.CustomerID = @customerID " +
                                  "AND dcs.ReservationNumber = " +
                            "( " +
                                "SELECT MIN(dcs2.ReservationNumber) " +
                                "FROM dbo.D_CUSTOMER_STAY dcs2 WITH(NOLOCK) " +
                                "WHERE dcs2.CustomerID = dcs.CustomerID " +
                                " AND dcs2.SourceStayID = dcs.SourceStayID" +
                            ") ";
                            if (projectID == "40012827")
                            {
                                query = query + " AND dcs.PropertyCode IN ('INDAMBROSE', 'DUANE', 'INDEPENDENTC'); ";
                            }
                            
                            query = query + 
                            "/*Memberships*/ " +

                            "SELECT vgm.CustomerID, " +
                                   "BirthDay, " +
                                   "vcml.NextLevel, " +
                                   "vcml.MembershipLevel " +
                            "INTO #V_GA_Memberships " +
                            "FROM dbo.V_GA_Memberships vgm " +
                                 "INNER JOIN dbo.V_Customer_MembershipLevel vcml ON vcml.CustomerID = vgm.CustomerID " +
                            "WHERE vgm.CustomerID = @customerID; " +

                            "/* " +
                            "/*Activities*/ " +

                            "SELECT vcs.CustomerId, " +
                                    "AirLineName " +
                            "INTO #V_Customer_Stay_Activities_One_To_One " +
                            "FROM dbo.V_Customer_Stay_Activities_One_To_One vcs " +
                            "WHERE vcs.CustomerId = @customerID; " +


                            "/*UVC*/ " +

                            "SELECT gm.CustomerID, " +
                                    "MembershipNumber " +
                            "INTO #GBS_Memberships " +
                            "FROM dbo.GBS_Memberships gm  " +
                            "WHERE gm.CustomerID = @customerID; " +
                            "*/ " +
                            "/*API Data*/ " +

                            "SELECT vof.CustomerID, " +
                                   "FirstName AS GuestFirstName, " +
                                   "ConfirmationNumber, " +
                                   "vof.PropertyCode " +
                            "INTO #v_Omni_FieldData_API " +
                            "FROM dbo.v_Omni_FieldData_API vof " +
                            "WHERE vof.CustomerID = @customerID; " +

                            "SELECT Top 1 pd.EmailCampaignSubject, " +
                                   "pd.ProjectID, " +
                                   "dc.CustomerID, " +
                                   "dcs.SourceStayID, " +
                                   "dcs.ReservationNumber, " +
                                   "dc.FirstName, " +
                                   "dc.LastName, " +
                                   "dc.Email, " +
                                   "CASE " +
                                       "WHEN ISNULL(dc.MemberLevel, '') = '' " +
                                       "THEN 'No Data' " +
                                       "ELSE dc.MemberLevel " +
                                   "END AS MemberLevel, " +
                                   "CASE " +
                                       "WHEN ISNULL(dcs.ArrivalDate, '') = '' " +
                                       "THEN 'No Data' " +
                                       "ELSE CONVERT(VARCHAR, dcs.ArrivalDate, 101) " +
                                   "END AS ArrivalDate, " +
                                   "CASE " +
                                       "WHEN ISNULL(dcs.DepartureDate, '') = '' " +
                                       "THEN 'No Data' " +
                                       "ELSE CONVERT(VARCHAR, dcs.DepartureDate, 101) " +
                                   "END AS DepartureDate, " +
                                   "CASE " +
                                       "WHEN ISNULL(dcs.CancelDate, '') = '' " +
                                       "THEN 'No Data' " +
                                       "ELSE CONVERT(VARCHAR, dcs.CancelDate, 101) " +
                                   "END AS CancelDate, " +
                                   "CASE " +
                                       "WHEN ISNULL(dcs.LegNumbers, '') = '' " +
                                       "THEN 0 " +
                                       "ELSE dcs.LegNumbers " +
                                   "END AS LegNumbers, " +
                                   "CASE " +
                                       "WHEN ISNULL(dcs.Points, '') = '' " +
                                       "THEN 0 " +
                                       "ELSE dcs.Points " +
                                   "END AS Points, " +
                                   "CASE " +
                                       "WHEN ISNULL(dcs.AverageDailyRevenueWithTax, '') = '' " +
                                       "THEN 0 " +
                                       "ELSE CAST(ROUND(dcs.AverageDailyRevenueWithTax, 2) AS NUMERIC(36, 2)) " +
                                   "END AS StayAverageTax, " +
                                   "CASE " +
                                       "WHEN ISNULL(vgm.BirthDay, '') = '' " +
                                       "THEN 'No Data' " +
                                       "ELSE CONVERT(VARCHAR, vgm.BirthDay, 101) " +
                                   "END AS BirthDay, " +
                                   "CASE " +
                                       "WHEN ISNULL(vgm.NextLevel, '') = '' " +
                                       "THEN 0 " +
                                       "ELSE vgm.NextLevel " +
                                   "END AS NextLevel, " +
                                   "CASE " +
                                       "WHEN ISNULL(vgm.MembershipLevel, '') = '' " +
                                       "THEN 0 " +
                                       "ELSE vgm.MembershipLevel " +
                                   "END AS MembershipLevel, " +
                                   "CASE " +
                                       "WHEN ISNULL(dcs.PropertyName, '') = '' " +
                                       "THEN 'No Data' " +
                                       "ELSE dcs.PropertyName " +
                                   "END AS PropertyName, " +
                                   "dc.ZipCode, " +
                                   "vof.GuestFirstName, " +
                                   "CASE " +
                                       "WHEN ISNULL(vof.ConfirmationNumber, '') = '' " +
                                       "THEN 'No Data' " +
                                       "ELSE vof.ConfirmationNumber " +
                                   "END AS ConfirmationNumber, " +
                                   "CASE " +
                                       "WHEN ISNULL(vof.PropertyCode, '') = '' " +
                                       "THEN 'No Data' " +
                                       "ELSE vof.PropertyCode " +
                                   "END AS PropertyCode " +
                            "FROM #DCustomer dc " +
                                 "LEFT JOIN #D_CUSTOMER_STAY dcs ON dcs.CustomerID = dc.CustomerID " +
                                 "LEFT JOIN #V_GA_Memberships vgm ON vgm.CustomerID = dc.CustomerID " +
                                 "LEFT JOIN #v_Omni_FieldData_API vof ON vof.GuestFirstName = dc.FirstName " +
                                 "LEFT JOIN #projectDetails pd ON pd.CustomerID = dc.CustomerID " +
                            "WHERE ISNULL(dcs.ReservationNumber, '') != ''; " + 

                            "IF OBJECT_ID('tempdb..#projectDetails') IS NOT NULL " +
                                "DROP TABLE #projectDetails; " +
                            "IF OBJECT_ID('tempdb..#DCustomer') IS NOT NULL " +
                                "DROP TABLE #DCustomer; " +
                            "IF OBJECT_ID('tempdb..#D_CUSTOMER_STAY') IS NOT NULL " +
                                "DROP TABLE #D_CUSTOMER_STAY; " +
                            "IF OBJECT_ID('tempdb..#V_GA_Memberships') IS NOT NULL " +
                                "DROP TABLE #V_GA_Memberships; " +
                            "IF OBJECT_ID('tempdb..#v_Omni_FieldData_API') IS NOT NULL " +
                                "DROP TABLE #v_Omni_FieldData_API; ";

                    using (var connection = new SqlConnection(Connstr.ConnectonString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.CommandTimeout = 50;
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    ProfileData.Subject = reader["EmailCampaignSubject"].ToString();
                                    ProfileData.SourceStayID = reader["SourceStayID"].ToString();
                                    ProfileData.ReservationNumber = reader["ReservationNumber"].ToString();
                                    ProfileData.ParentProjectID = reader["ProjectID"].ToString();
                                    ProfileData.PrimaryCustomer = reader["CustomerID"].ToString();
                                    ProfileData.FirstName = reader["FirstName"].ToString();
                                    ProfileData.LastName = reader["LastName"].ToString();
                                    ProfileData.Email = reader["Email"].ToString();
                                    ProfileData.memberLevel = reader["MemberLevel"].ToString();
                                    ProfileData.ArrivalDate = reader["ArrivalDate"].ToString();
                                    ProfileData.DepartureDate = reader["DepartureDate"].ToString();
                                    ProfileData.CancelDate = reader["CancelDate"].ToString();
                                    ProfileData.legNumbers = reader["LegNumbers"].ToString();
                                    ProfileData.stayPoints = reader["Points"].ToString();
                                    ProfileData.stayAverageTax = reader["StayAverageTax"].ToString();
                                    ProfileData.birthday = reader["BirthDay"].ToString();
                                    ProfileData.nextLevel = reader["NextLevel"].ToString();
                                    ProfileData.membershipLevel = reader["MembershipLevel"].ToString();
                                    ProfileData.PropertyName = reader["PropertyName"].ToString();
                                    ProfileData.ZipCode = reader["ZipCode"].ToString();
                                    ProfileData.guestFirstName = reader["GuestFirstName"].ToString();
                                    ProfileData.confirmationNumber = reader["ConfirmationNumber"].ToString();
                                    ProfileData.PropertyCode = reader["PropertyCode"].ToString();
                                }
                            }
                        }
                        connection.Close();
                    }
                    break;

                case 3:
                    query = query + " SELECT dcs.CustomerID, " +
                                   "dcs.AcknowledgementNum, " +
                                   "dcs.Channel, " +
                                   "dcs.InvBlockCode, " +
                                   "dcs.TaxType, " +
                                   "dcs.ClientType, " +
                                   "dcs.MarketSeg, " +
                                   "dcs.MarketSubSeg, " +
                                   "dcs.CurrencyCode, " +
                                   "dcs.PackageCode, " +
                                   "dcs.IATA, " +
                                   "dcs.ArrivalDate, " +
                                   "dcs.DepartureDate, " +
                                   "dcs.RateCategory, " +
                                   "dcs.MemberShipID, " +
                                   "dcs.SourceOfBusiness, " +
                                   "dcs.RTC, " +
                                   "dcs.MP, " +
                                   "dcs.CompanyName, " +
                                   "dcs.Quantity, " +
                                   "dcs.RatePackage, " +
                                   "dcs.RemainingBalance, " +
                                   "dcs.GroupName, " +
                                   "dcs.PK_Reservations, " +
                                   "dcs.SubReservationNumber, " +
                                   "dcs.ResAgent, " +
                                   "dcs.BookingEngConfNum, " +
                                   "dcs.PropertyCode, " +
                                   "dcs.RateType, " +
                                   "dcs.SourceStayID, " +
                                   "dcs.TotalPackageRate, " +
                                   "dcs.RoomCode, " +
                                   "dcs.DepositPolicy, " +
                                   "dcs.MemberShipLevel, " +
                                   "dcs.CentralReservation, " +
                                   "dcs.TotalPackageRateWithTax, " +
                                   "dcs.AverageDailyRevenueWithTax, " +
                                   "dcs.CancellationNum, " +
                                   "dcs.CheckOutTime, " +
                                   "dcs.RoomTypeCode, " +
                                   "dcs.CXLPolicy, " +
                                   "dcs.StayNights, " +
                                   "dcs.NumRooms, " +
                                   "dcs.CheckInTime, " +
                                   "dcs.TotalPersons, " +
                                   "dcs.GroupResortFees, " +
                                   "dcs.RoomNights, " +
                                   "dcs.CancelByDate, " +
                                   "dcs.ResCreationDate, " +
                                   "dcs.TotalResortFees, " +
                                   "dcs.NumChildren, " +
                                   "dcs.NumAdults, " +
                                   "dcs.AverageDailyRevenue, " +
                                   "dcs.OtherRevenue, " +
                                   "dcs.Deposit, " +
                                   "dcs.ReservationNumber, " +
                                   "dcs.RoomRevenue, " +
                                   "dcs.Tax, " +
                                   "dcs.AverageDailyRate, " +
                                   "dcs.TotalRevenue, " +
                                   "dcs.TotalRevenueWithTax, " +
                                   "dcs.CancelDate, " +
                                   "vcsst.Total, " +
                                   "lta.IATADes, " +
                                   "vcscas.CurrencySymbol, " +
                                   "vcscas.CurrencyType, " +
                                   "vcsrrwtl.RoomRevenueStayWithTax_10pct, " +
                                   "vcsrrwtl.RoomRevenueStayWithTax_90Pct, " +
                                   "vcsrrwtl.NonMember_RoomRevenueStayWithTax_12Months, " +
                                   "vcsrrwtl.NonMember_RoomRevenueStayWithTax_12Months_10pct, " +
                                   "vcsrrwtl.NonMember_RoomRevenueStayWithTax_12Months_90pct " +
                            "FROM dbo.D_CUSTOMER_STAY dcs  " +
                                "LEFT JOIN dbo.V_Customer_Stay_Service_Totals vcsst " +
                                    "ON vcsst.CustomerID = dcs.CustomerID " +
                                       "AND vcsst.SourceStayID = dcs.SourceStayID " +
                                "LEFT JOIN dbo.L_TRAVEL_AGENT lta  " +
                                    "ON lta.IATA = dcs.IATA " +
                                "INNER JOIN dbo.V_Customer_Stay_CurrencyAndSymbol vcscas " +
                                    "ON vcscas.CustomerID = dcs.CustomerID " +
                                "INNER JOIN dbo.V_Customer_StayRoomRevenueWithTax_9010_Latest vcsrrwtl " +
                                    "ON vcsrrwtl.CustomerID = dcs.CustomerID " +
                            "WHERE dcs.CustomerID = @GetCustomerID;";

                    using (var connection = new SqlConnection(Connstr.ConnectonString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.CommandTimeout = 60;
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    ProfileData.CustomerID = reader["CustomerID"].ToString();
                                    ProfileData.AcknowledgementNum = reader["AcknowledgementNum"].ToString();
                                    ProfileData.Channel = reader["Channel"].ToString();
                                    ProfileData.InvBlockCode = reader["InvBlockCode"].ToString();
                                    ProfileData.TaxType = reader["TaxType"].ToString();
                                    ProfileData.ClientType = reader["ClientType"].ToString();
                                    ProfileData.MarketSeg = reader["MarketSeg"].ToString();
                                    ProfileData.MarketSubSeg = reader["MarketSubSeg"].ToString();
                                    ProfileData.CurrencyCode = reader["CurrencyCode"].ToString();
                                    ProfileData.PackageCode = reader["PackageCode"].ToString();
                                    ProfileData.IATA = reader["IATA"].ToString();
                                    ProfileData.ArrivalDate = reader["ArrivalDate"].ToString();
                                    ProfileData.DepartureDate = reader["DepartureDate"].ToString();
                                    ProfileData.RateCategory = reader["RateCategory"].ToString();
                                    ProfileData.MemberShipID = reader["MemberShipID"].ToString();
                                    ProfileData.SourceOfBusiness = reader["SourceOfBusiness"].ToString();
                                    ProfileData.RTC = reader["RTC"].ToString();
                                    ProfileData.MP = reader["MP"].ToString();
                                    ProfileData.CompanyName = reader["CompanyName"].ToString();
                                    ProfileData.Quantity = reader["Quantity"].ToString();
                                    ProfileData.RatePackage = reader["RatePackage"].ToString();
                                    ProfileData.RemainingBalance = reader["RemainingBalance"].ToString();
                                    ProfileData.GroupName = reader["GroupName"].ToString();
                                    ProfileData.PK_Reservations = reader["PK_Reservations"].ToString();
                                    ProfileData.SubReservationNumber = reader["SubReservationNumber"].ToString();
                                    ProfileData.ResAgent = reader["ResAgent"].ToString();
                                    ProfileData.BookingEngConfNum = reader["BookingEngConfNum"].ToString();
                                    ProfileData.PropertyCode = reader["PropertyCode"].ToString();
                                    ProfileData.RateType = reader["RateType"].ToString();
                                    ProfileData.SourceStayID = reader["SourceStayID"].ToString();
                                    ProfileData.TotalPackageRate = reader["TotalPackageRate"].ToString();
                                    ProfileData.RoomCode = reader["RoomCode"].ToString();
                                    ProfileData.DepositPolicy = reader["DepositPolicy"].ToString();
                                    ProfileData.MemberShipLevel = reader["MemberShipLevel"].ToString();
                                    ProfileData.CentralReservation = reader["CentralReservation"].ToString();
                                    ProfileData.TotalPackageRateWithTax = reader["TotalPackageRateWithTax"].ToString();
                                    ProfileData.AverageDailyRevenueWithTax = reader["AverageDailyRevenueWithTax"].ToString();
                                    ProfileData.CancellationNum = reader["CancellationNum"].ToString();
                                    ProfileData.CheckOutTime = reader["CheckOutTime"].ToString();
                                    ProfileData.RoomTypeCode = reader["RoomTypeCode"].ToString();
                                    ProfileData.CXLPolicy = reader["CXLPolicy"].ToString();
                                    ProfileData.StayNights = reader["StayNights"].ToString();
                                    ProfileData.NumRooms = reader["NumRooms"].ToString();
                                    ProfileData.CheckInTime = reader["CheckInTime"].ToString();
                                    ProfileData.TotalPersons = reader["TotalPersons"].ToString();
                                    ProfileData.GroupResortFees = reader["GroupResortFees"].ToString();
                                    ProfileData.RoomNights = reader["RoomNights"].ToString();
                                    ProfileData.CancelByDate = reader["CancelByDate"].ToString();
                                    ProfileData.ResCreationDate = reader["ResCreationDate"].ToString();
                                    ProfileData.TotalResortFees = reader["TotalResortFees"].ToString();
                                    ProfileData.NumChildren = reader["NumChildren"].ToString();
                                    ProfileData.NumAdults = reader["NumAdults"].ToString();
                                    ProfileData.AverageDailyRevenue = reader["AverageDailyRevenue"].ToString();
                                    ProfileData.OtherRevenue = reader["OtherRevenue"].ToString();
                                    ProfileData.Deposit = reader["Deposit"].ToString();
                                    ProfileData.ReservationNumber = reader["ReservationNumber"].ToString();
                                    ProfileData.RoomRevenue = reader["RoomRevenue"].ToString();
                                    ProfileData.Tax = reader["Tax"].ToString();
                                    ProfileData.AverageDailyRate = reader["AverageDailyRate"].ToString();
                                    ProfileData.TotalRevenue = reader["TotalRevenue"].ToString();
                                    ProfileData.TotalRevenueWithTax = reader["TotalRevenueWithTax"].ToString();
                                    ProfileData.CancelDate = reader["CancelDate"].ToString();
                                    ProfileData.Total = reader["Total"].ToString();
                                    ProfileData.IATADes = reader["IATADes"].ToString();
                                    ProfileData.CurrencySymbol = reader["CurrencySymbol"].ToString();
                                    ProfileData.CurrencyType = reader["CurrencyType"].ToString();
                                    ProfileData.RoomRevenueStayWithTax_10pct = reader["RoomRevenueStayWithTax_10pct"].ToString();
                                    ProfileData.RoomRevenueStayWithTax_90Pct = reader["RoomRevenueStayWithTax_90Pct"].ToString();
                                    ProfileData.NonMember_RoomRevenueStayWithTax_12Months = reader["NonMember_RoomRevenueStayWithTax_12Months"].ToString();
                                    ProfileData.NonMember_RoomRevenueStayWithTax_12Months_10pct = reader["NonMember_RoomRevenueStayWithTax_12Months_10pct"].ToString();
                                    ProfileData.NonMember_RoomRevenueStayWithTax_12Months_90pct = reader["NonMember_RoomRevenueStayWithTax_12Months_90pct"].ToString();
                                }
                            }
                        }
                        connection.Close();
                    }
                    break;
            }
            return ProfileData;
        }
        public static CampaignDetails ReturnCampaignStatus(int projectID, CampaignDetails campData)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + " SELECT TOP 1 v3.mapProjectStatus([Status], NULL) AS OldStatus, " +
                                 "eContact_Campaign_ParentProjectID, " +
                                 "p.ID, " +
                                 "c.CompanyName, " +
                                 "p2.ParentCompany, " +
                                 "p.EmailCampaignName " +
                    "FROM [projects] p  " +
                         "INNER JOIN dbo.Company c  ON p.CompanyID = c.CompanyID " +
                         "INNER JOIN dbo.Parentcompany p2  ON p2.ID = c.ParentCompany " +
                    "WHERE p.ID = " + projectID;

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
                            campData.OldStatus = reader["OldStatus"].ToString();
                            campData.ParentCompanyID = reader["eContact_Campaign_ParentProjectID"].ToString();
                            campData.ChildCampaignID = reader["ID"].ToString();
                            campData.CompanyName = reader["CompanyName"].ToString();
                            campData.ParentCompanyName = reader["ParentCompany"].ToString();
                            campData.CampaignName = reader["EmailCampaignName"].ToString();
                        }
                    }
                }
                connection.Close();
            }

            return campData;
        }
        public static int ReturnCampaignScheduleStatus(int projectID)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "SELECT ecece.ActiveStatus_YN " +
                    "FROM dbo.eContact_eCalendar_events ecece  " +
                    "WHERE ecece.CenAdmin_ProjectID = " + projectID + ";";
            columnName = "ActiveStatus_YN";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getValue = reader["ActiveStatus_YN"].ToString();
                        }
                    }
                }
                connection.Close();
            }

            return Convert.ToInt32(getValue);
        }

        public static void UpdateProjectStatus(int projectID, string status = null)
        {
            if (String.IsNullOrEmpty(status))
            {
                query = "EXEC dbo.UpdateProjectStatus_QAOnly @ProjectID = " + projectID + ", @Status = NULL";
            }
            else if (testCategory == "EU02_PostDeployment")
            {
                query = "EXEC dbo.UpdateProjectStatus_QA @ProjectID = " + projectID + ", @Status = N'" + status + "'";
            }
            else
            {
                query = "EXEC dbo.UpdateProjectStatus_QAOnly @ProjectID = " + projectID + ", @Status = N'" + status + "'";
            }
            
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

        public static ResendCampaignData GetReservationNumber(string companyName, ResendCampaignData stayData, string testType, string projectID = null)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            GetDatabaseName();
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query +
                        "IF OBJECT_ID('tempdb..#GetProjectID') IS NOT NULL " +
                            "DROP TABLE #GetProjectID; " +
                        "IF OBJECT_ID('tempdb..#GetCustomerIDs') IS NOT NULL " +
                            "DROP TABLE #GetCustomerIDs; " +
                        "IF OBJECT_ID('tempdb..#HasCompanyAccess') IS NOT NULL " +
                            "DROP TABLE #HasCompanyAccess; " +
                        "IF OBJECT_ID('tempdb..#HasCampaignEmail')  IS NOT NULL " +
                            "DROP TABLE #HasCampaignEmail; " +
                        "IF OBJECT_ID('tempdb..#GlobalProfileMatch')  IS NOT NULL " +
                            "DROP TABLE #GlobalProfileMatch;" +

                    "SELECT ss.value " +
                        "INTO #HasCompanyAccess " +
                        "FROM [APPDBSERVER]."+ dbName + ".[dbo].[Users] [u] " +
                        "CROSS APPLY utility.split_int(CompanyID) ss " +
                        "WHERE u.Email = '" + LegacyTestData.CommonFrontendEmail + "'; " +
                        "SELECT DISTINCT ss.token AS ParentProjectID," +
                        "p2.EmailCampaignSubject AS CampaignSubject, " +
                        "p2.EmailCampaignName AS CampaignName, " +
                        "c.CompanyName " +
                        "INTO #GetProjectID " +
                        "FROM [APPDBSERVER]." + dbName + ".[dbo].[eContact_Settings] ecs " +
                             "INNER JOIN [APPDBSERVER]." + dbName + ".[dbo].[Company] c ON c.CompanyID = ecs.CompanyID " +
                             "INNER JOIN #HasCompanyAccess hc On hc.value = c.CompanyID " +
                             "INNER JOIN [APPDBSERVER]." + dbName + ".[dbo].[Parentcompany] [p] ON p.ID = c.ParentCompany " +
                             "CROSS APPLY utility.split_string(ecs.SettingValue, ',') ss " +
                             "INNER JOIN [APPDBSERVER]." + dbName + ".[dbo].[projects] p2 ON ss.token = p2.eContact_Campaign_ParentProjectID OR ss.token = p2.ID " +
                        "WHERE ecs.SettingName = 'ConfirmationProjectID' " +
                              "AND p.ParentCompany = '" + companyName + "' " +
                              "AND ISNULL(ss.token, '') != '' " +
                              "AND ISNULL(p2.EmailCampaignSubject, '')!= '' ";
            if (testType == "SendCampaign")
            {
                query = query + "AND ISNULL(ss.token, '') = '" + projectID + "'";
            }
            if (testType == "Profile")
            {
                if(testCategory == "QA")
                {
                    query = query + "AND ISNULL(ss.token, '') = '40012935' ";
                }
                else
                {
                    query = query + "AND ISNULL(ss.token, '') = '" + projectID + "'";
                }
            }
            query = query +
                    "ORDER BY ss.token DESC; " +

                    "SELECT DISTINCT TOP 100 " +
                               "e.Email, " +
                               "e.CustomerID, " +
                               "pi.CampaignName, " +
                               "pi.ParentProjectID, " +
                               "pi.CampaignSubject, " +
                               "pi.CompanyName, " +
                               "gpm.GroupID " +
                        "INTO #HasCampaignEmail " +
                        "FROM dbo.eInsight_Dynamic_ReSend_Message_Extract e " +
                            "INNER JOIN #GetProjectID pi " +
                                "ON pi.ParentProjectID = e.ProjectID " +
                            "INNER JOIN dbo.ECONTACT_CAMPAIGNNAME ec " +
                                "ON pi.ParentProjectID = ec.ParentProjectID " +
                            "LEFT JOIN dbo.Global_Profile_Mapping gpm " +
                                "ON gpm.CustomerID = e.CustomerID " +
                        "WHERE e.CustomerID <> 0 ";
            if (testType != "SendCampaign")
            {
                query = query + "AND ec.IsTransactional = 1 ";
            }

            query = query + "GROUP BY e.Email, " +
                             "e.CustomerID, " +
                             "pi.CampaignName, " +
                             "pi.ParentProjectID, " +
                             "pi.CampaignSubject, " +
                             "pi.CompanyName, " +
                             "gpm.GroupID " +
                "SELECT TOP 1 gpm2.CustomerID AS PrimaryCustomer, " +
                             "gpl.CustomerID " +
                "INTO #GlobalProfileMatch " +
                "FROM dbo.Global_Profile_Mapping gpm2 WITH(NOLOCK) " +
                     "LEFT JOIN #HasCampaignEmail gpl ON gpl.GroupID = gpm2.GroupID " +
                                                         "AND gpm2.GlobalRanking = 1 ";
                if (testType == "CASLSend" && companyName == "Independent Collection")
                {
                    query = query + "WHERE gpl.ParentProjectID = 40013810 ";
                }
                query = query + "ORDER BY gpl.CustomerID ASC; " +
                "SELECT DISTINCT " +
                       "dc.Email, " +
                       "e.CampaignName, " +
                       "e.ParentProjectID, " +
                       "e.CampaignSubject, " +
                       "e.CompanyName, " +
                "CASE WHEN ISNULL(gpm.CustomerID, 0) = 0 " +
                    "THEN dc.CustomerID " +
                    "ELSE gpm.CustomerID " +
                    "END AS CustomerID, " +
                    "CASE WHEN ISNULL(gpm.PrimaryCustomer, 0) = 0 " +
                    "THEN dc.CustomerID " +
                    "ELSE gpm.PrimaryCustomer " +
                "END AS PrimaryCustomer " +
                "INTO #GetCustomerIDs " +
                    "FROM #HasCampaignEmail e " +
                        "INNER JOIN dbo.D_CUSTOMER dc " +
                            "ON dc.CustomerID = e.CustomerID " +
                        "LEFT JOIN #GlobalProfileMatch gpm " +
                            "ON gpm.CustomerID = dc.CustomerID " +
                    "WHERE dc.RecordStatus = 1 " +
                    "AND ISNULL(dc.Email, '') != '' " ;
            if (testType == "CASLSend")
            {
                query = query + " AND dc.CountryCode = 'CA' ";
            }

            query = query + "; SELECT TOP 1 " +
                           "dcs.CustomerID, " +
                           "dcs.ReservationNumber, " +
                           "c.Email, " +
                           "c.CampaignName, " +
                           "c.CampaignSubject," +
                            "c.ParentProjectID, " +
                            "c.CompanyName AS PropertyName, " +
                            "c.PrimaryCustomer " +
                    "FROM dbo.D_CUSTOMER_STAY dcs " +
                        "INNER JOIN #GetCustomerIDs c " +
                            "ON c.CustomerID = dcs.CustomerID " +
                        "INNER JOIN dbo.D_PROPERTY dp " +
                            " ON dcs.PropertyCode = dp.PropertyCode " +
                    " GROUP BY dcs.CustomerID, " +
                             "dcs.ReservationNumber, " +
                             "c.Email, " +
                             "c.CampaignName, " +
                             "c.CampaignSubject, " +
                             "c.ParentProjectID, " +
                             "c.CompanyName, " +
                             "c.PrimaryCustomer " +
                    "HAVING COUNT(dcs.CustomerID) < 2 ";
            //"ORDER BY NEWID() DESC;";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 300;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            stayData.CustomerID = reader["CustomerID"].ToString();
                            stayData.ReservationNumber = reader["ReservationNumber"].ToString();
                            stayData.EmailAddress = reader["Email"].ToString();
                            stayData.CampaignName = reader["CampaignName"].ToString();
                            stayData.CampaignSubject = reader["CampaignSubject"].ToString();
                            stayData.ParentProjectID = reader["ParentProjectID"].ToString();
                            stayData.PropertyName = reader["PropertyName"].ToString();
                            stayData.PrimaryCustomer = reader["PrimaryCustomer"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return stayData;
        }
        public static ResendCampaignData GetCampaignName(ResendCampaignData campaignData)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + " SELECT TOP 1 " +
                           "p.eContact_Campaign_ParentProjectID AS ParentProjectID, " +
                           "CASE " +
                               "WHEN ISNULL(em.NewContentSubject, '') = '' THEN " +
                                   "em.ContentSubject " +
                               "ELSE " +
                                   "em.NewContentSubject " +
                           "END AS CampaignSubject, " +
                           "p.ProjectName AS CampaignName " +
                    "FROM projects p  " +
                        "INNER JOIN eContact_eMailMarketing em  " +
                            "ON p.ID = em.ProjectID " +
                    "WHERE CONVERT(DATE, em.SentDate) >= DATEADD(DAY, -3, CONVERT(DATE, GETDATE())) " +
                          "AND CONVERT(DATE, em.SentDate) <= CONVERT(DATE, GETDATE()) " +
                          "AND ISNULL(p.eContact_Campaign_ParentProjectID, '') != '' " +
                    "ORDER BY NEWID();";
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
                            campaignData.ParentProjectID = reader["ParentProjectID"].ToString();
                            campaignData.CampaignSubject = reader["CampaignSubject"].ToString();
                            campaignData.CampaignName = reader["CampaignName"].ToString();
                        }
                    }
                }
                connection.Close();
                return campaignData;
            }
        }
        public static AnnonymizedData GetDummyData(AnnonymizedData guestdetails)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + " SELECT TOP 1 pg.ID, " +
                                "pg.Prefix, " +
                                "pg.FirstName, " +
                                "pg.LastName, " +
                                "pg.Email, " +
                                "pg.HomePhone, " +
                                "pg.WorkPhone, " +
                                "pg.CellPhone, " +
                                "pg.Address1, " +
                                "pg.Address2, " +
                                "pg.City, " +
                                "pg.StateProvinceCode, " +
                                "pg.ZipCode, " +
                                "pg.Country, " +
                                "pg.IsUsed " +
                    "FROM dbo.ProfileGenerator pg " +
                    "WHERE pg.IsUsed = 0 " +
                    "AND pg.Prefix IN('Mr.', 'Mrs.', 'Ms.')" +
                    "ORDER BY NEWID();";
            using (SqlConnection connection = DBHelper.SqlConn2())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            guestdetails.ID = reader["ID"].ToString();
                            guestdetails.Prefix = reader["Prefix"].ToString();
                            guestdetails.FirstName = reader["FirstName"].ToString();
                            guestdetails.LastName = reader["LastName"].ToString();
                            guestdetails.Email = reader["Email"].ToString();
                            guestdetails.HomePhone = reader["HomePhone"].ToString();
                            guestdetails.WorkPhone = reader["WorkPhone"].ToString();
                            guestdetails.CellPhone = reader["CellPhone"].ToString();
                            guestdetails.Address1 = reader["Address1"].ToString();
                            guestdetails.Address2 = reader["Address2"].ToString();
                            guestdetails.City = reader["City"].ToString();
                            guestdetails.StateProvinceCode = reader["StateProvinceCode"].ToString();
                            guestdetails.ZipCode = reader["ZipCode"].ToString();
                            guestdetails.Country = reader["Country"].ToString();
                            guestdetails.IsUsed = reader["IsUsed"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return guestdetails;
        }

        public static void UpdateUsedguestData(string guestid)
        {
            query = "UPDATE pg " +
                    "SET pg.IsUsed = 1 " +
                    "FROM dbo.ProfileGenerator pg " +
                    "WHERE pg.ID = '" + guestid + "'";

            using (SqlConnection connection = DBHelper.SqlConn2())
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
        public static CampaignReportDetails CampaignReport(string reportType, string campaignType, string companyName, string childproperty, CampaignReportDetails reportdata)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            GetDatabaseName();
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "IF OBJECT_ID('tempdb..#HadCompAccess')  IS NOT NULL " +
                            "DROP TABLE #HadCompAccess; " +
                            "WITH HasCompanyAccess AS " +
                            "( " +
                            "SELECT ss.value FROM [APPDBSERVER]." + dbName + ".[dbo].[Users] [u] " +
                            "CROSS APPLY utility.split_int(CompanyID) ss " +
                            "WHERE u.Email = '" + LegacyTestData.CommonFrontendEmail + "' " +
                            ") " + 
                            "SELECT c.CompanyID, " +
                            "c.CompanyName " +
                            "INTO #HadCompAccess " +
                            "FROM [APPDBSERVER]."+ dbName + ".[dbo].[Company] [c] " +
                            "INNER JOIN HasCompanyAccess ha ON ha.value = c.CompanyID " +
                            " SELECT TOP 1 S.CampaignName, " +
                                 "S.Subject, " +
                                 "ISNULL(FORMAT(S.SendDate, 'M/d/yyyy'), '') AS SendDate, " +
                                 "S.SendCount, " +
                                 "S.DeliverCount, " +
                                 "S.OpenCount, " +
                                 "S.UniqueOpenCount, " +
                                 "S.ClickCount, " +
                                 "S.NetClickCount, " +
                                 "S.ParentProjectID, " +
                                 "S.ChildProjectID, " +
                                 "CASE " +
                                     "WHEN DATEDIFF(MONTH, CONVERT(DATE, GETDATE()), CONVERT(DATE, S.SendDate)) = 0 " +
                                     "THEN '1 Months' " +
                                     "WHEN DATEDIFF(MONTH, CONVERT(DATE, GETDATE()), CONVERT(DATE, S.SendDate)) = -2 " +
                                     "THEN '2 Months' " +
                                     "WHEN DATEDIFF(MONTH, CONVERT(DATE, GETDATE()), CONVERT(DATE, S.SendDate)) = -3 " +
                                     "THEN '3 Months' " +
                                     "WHEN DATEDIFF(MONTH, CONVERT(DATE, GETDATE()), CONVERT(DATE, S.SendDate)) = -6 " +
                                     "THEN '6 Months' " +
                                     "ELSE '12 Months' " +
                                 "END AS 'DateRange', " +
                                 "dp.PropertyName, " +
                                 "ha.CompanyName " +
                    "FROM ECONTACT_CAMPAIGN_SUMMARY S " +
                         "INNER JOIN ECONTACT_CAMPAIGNNAME N ON S.ChildProjectID = N.ProjectID ";
                        if (campaignType == "Marketing")
                        {
                            query = query + " AND N.IsTriggerCampaign = 0 ";
                        }
                        if (campaignType == "Transactional")
                        {
                            query = query + " AND N.IsTriggerCampaign = 1 ";
                        }
            query = query + "INNER JOIN dbo.D_PROPERTY dp ON n.CompanyID = dp.CenAdminCompanyID " +
           "INNER JOIN #HadCompAccess ha ON ha.CompanyID = dp.CenAdminCompanyID ";
            if (campaignType == "Transactional" && testCategory != "QA")
            {
                query = query + " And ha.CompanyName = '" + companyName + "' "; ;
            }

            switch (reportType)
            {
                case "NetClick":

                    query = query + "WHERE ISNULL(S.NetClickCount, '') != 0 " +
                          "AND CONVERT(DATE, S.SendDate) >= DATEADD(MONTH, -12, CONVERT(DATE, GETDATE())) " +
                          "AND CONVERT(DATE, S.SendDate) <= CONVERT(DATE, GETDATE()) " +
                          //"AND dp.PropertyName = '" + childproperty + "'" +
                          " ORDER BY S.ChildProjectID desc";
                    break;

                case "NetOpen":
                    query = query + "WHERE ISNULL(S.NetOpenPercent, '') != 0 " +
                          "AND CONVERT(DATE, S.SendDate) >= DATEADD(MONTH, -6, CONVERT(DATE, GETDATE())) " +
                          "AND CONVERT(DATE, S.SendDate) <= CONVERT(DATE, GETDATE()) " +
                          //"AND dp.PropertyName = '" + childproperty + "'" +
                          " ORDER BY S.ChildProjectID desc";
                    break;
                case "Others":
                    query = query + "WHERE  CONVERT(DATE, S.SendDate) >= DATEADD(MONTH, -12, CONVERT(DATE, GETDATE())) " +
                          "AND CONVERT(DATE, S.SendDate) <= CONVERT(DATE, GETDATE()) " +
                          //"AND dp.PropertyName = '" + childproperty + "'" +
                          " ORDER BY S.ChildProjectID desc";
                    break;
                case "GetCountDetails":
                    query = query + "WHERE  CONVERT(DATE, S.SendDate) >= DATEADD(MONTH, -3, CONVERT(DATE, GETDATE())) " +
                            "AND CONVERT(DATE, S.SendDate) <= CONVERT(DATE, GETDATE()) " +
                            //"AND dp.PropertyName = '" + childproperty + "'" +
                            " ORDER BY S.ChildProjectID desc";
                    //"AND (ISNULL(S.SendCount, 0) <> 0 " +
                    //       "AND ISNULL(S.DeliverCount, 0) <> 0) " +
                    //  "OR (ISNULL(S.OpenCount, 0) <> 0 " +
                    //      "AND ISNULL(S.ClickCount, 0) <> 0 " +
                    //      "AND ISNULL(S.UniqueOpenCount, 0) <> 0 " +
                    //      "AND ISNULL(S.NetClickCount, 0) <> 0);";
                    break;
            }
            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 300;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reportdata.CampaignName = reader["CampaignName"].ToString();
                            reportdata.Subject = reader["Subject"].ToString();
                            reportdata.SendDate = reader["SendDate"].ToString();
                            reportdata.SendCount = reader["SendCount"].ToString();
                            reportdata.DeliverCount = reader["DeliverCount"].ToString();
                            reportdata.OpenCount = reader["OpenCount"].ToString();
                            reportdata.UniqueOpenCount = reader["UniqueOpenCount"].ToString();
                            reportdata.ClickCount = reader["ClickCount"].ToString();
                            reportdata.NetClickCount = reader["NetClickCount"].ToString();
                            reportdata.ParentProjectID = reader["ParentProjectID"].ToString();
                            reportdata.ChildProjectID = reader["ChildProjectID"].ToString();
                            reportdata.DateRange = reader["DateRange"].ToString();
                            reportdata.PropertyName = reader["PropertyName"].ToString();
                            reportdata.CompanyName = reader["CompanyName"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return reportdata;
        }
        public static CampaignReportDetails CampaignReport_Transactional(string reportType, string campaignType, string companyName, CampaignReportDetails reportdata)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            GetDatabaseName();
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "IF OBJECT_ID('tempdb..#HadCompAccess')  IS NOT NULL " +
                            "DROP TABLE #HadCompAccess; " +
                            "WITH HasCompanyAccess AS " +
                            "( " +
                            "SELECT ss.value FROM [APPDBSERVER]."+ dbName +".[dbo].[Users] [u] " +
                            "CROSS APPLY utility.split_int(CompanyID) ss " +
                                "WHERE u.Email = '" + LegacyTestData.CommonFrontendEmail + "' " +
                            ") " +

                            "SELECT c.CompanyID, " +
                            "c.CompanyName " +
                            "INTO #HadCompAccess " +
                            "FROM [APPDBSERVER]." + dbName + ".[dbo].[Company] [c] " +
                            "INNER JOIN HasCompanyAccess ha ON ha.value = c.CompanyID " +
                            " SELECT TOP 1 dcs.ReservationNumber, " +
                                         "eidrsme.Email, " +
                                         "ISNULL(FORMAT(ec.InsertDate, 'M/d/yyyy'), '') AS StartDate, " +
                                         "ISNULL(FORMAT(GETDATE(), 'M/d/yyyy'), '') AS EndDate, " +
                                         "dp.PropertyName, " +
                                         "ec.CampaignName, " +
                                         "ha.CompanyName " +
                            "FROM dbo.eInsight_Dynamic_ReSend_Message_Extract eidrsme " +
                                "INNER JOIN	eInsight_Dynamic_Customer_Extract_StrongMail esm ON esm.ProjectID = eidrsme.ProjectID " +
                                 "INNER JOIN dbo.ECONTACT_CAMPAIGNNAME ec ON ec.ParentProjectID = eidrsme.ProjectID " +
                                                                            "AND ec.IsTransactional = 1 " +
                                 "INNER JOIN dbo.D_CUSTOMER_STAY dcs ON dcs.CustomerID = eidrsme.CustomerID " +
                                 "INNER JOIN dbo.D_PROPERTY dp ON dp.PropertyCode = dcs.PropertyCode " +
                                 "INNER JOIN #HadCompAccess ha ON ha.CompanyID = dp.CenAdminCompanyID " +
                            "WHERE CONVERT(DATE, eidrsme.InsertDate) >= DATEADD(DAY, -365, CONVERT(DATE, GETDATE())) " +
                                  "AND CONVERT(DATE, eidrsme.InsertDate) <= CONVERT(DATE, GETDATE()) " +
                                  "AND ISNULL(eidrsme.CustomerID, 0) != 0 " +
                            "ORDER BY ec.InsertDate desc;";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 300;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reportdata.ReservationNumber = reader["ReservationNumber"].ToString();
                            reportdata.Email = reader["Email"].ToString();
                            reportdata.StartDate = reader["StartDate"].ToString();
                            reportdata.EndDate = reader["EndDate"].ToString();
                            reportdata.CampaignName = reader["CampaignName"].ToString();
                            reportdata.PropertyName = reader["PropertyName"].ToString();
                            reportdata.CompanyName = reader["CompanyName"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return reportdata;
        }
        public static UserPreference GetUserPreference(UserPreference userPref, string email)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + " SELECT pref.user_id, " +
                           "pref.region, " +
                           "pref.language, " +
                           "pref.inserttime, " +
                           "pref.updatetime " +
                    "FROM dbo.eInsight_User_Preferences pref " +
                    "INNER JOIN dbo.Users u ON u.UserId = pref.user_id " +
                    "WHERE u.Email = '" + email + "'";

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
                            userPref.user_id = reader["user_id"].ToString();
                            userPref.region = reader["region"].ToString();
                            userPref.language = reader["language"].ToString();
                            userPref.inserttime = reader["inserttime"].ToString();
                            userPref.updatetime = reader["updatetime"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return userPref;
        }


        public static AudienceBuilderData GetActiveInactiveAudienceBuilder(AudienceBuilderData ab_Inactive, string companyName, string resulttype, string searchType)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            switch (resulttype)
            {
                case "active":
                    query = query + " SELECT TOP 1 asb.Name " +
                            "FROM eInsight_Audience_Detail_For_Search asb " +
                            "WHERE asb.isactive = 1 " +
                            "      AND asb.AudienceDetailType = '" + searchType + "' " +
                            "order by NewID(); ";
                    break;
                case "inactive":
                    query = query + " SELECT TOP 1 asb.Name " +
                            "FROM eInsight_Audience_Detail_For_Search asb " +
                            "WHERE asb.isactive = 0 " +
                            "      AND asb.AudienceDetailType = '" + searchType + "' " +
                            "order by NewID(); ";
                    break;
                case "specialcharacter":
                    query = query + " SELECT TOP 1 asb.Name " +
                            "FROM eInsight_Audience_Detail_For_Search asb " +
                            "WHERE asb.isactive = 1 " +
                            "      AND asb.AudienceDetailType = '" + searchType + "' " +
                            "	  and Name like '%&%' " +
                            "order by NewID();";
                    break;
            }


            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 300;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ab_Inactive.AudienceName = reader["Name"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return ab_Inactive;
        }
        public static CampaignDetails GetCampaignDetails(CampaignDetails campaignData, string companyName,string projectID)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            GetDatabaseName();
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + " SELECT TOP 1 ec.ParentProjectID, " +
                           "ec.ProjectID, " +
                           "c.CompanyName, " +
                           "p.ParentCompany, " +
                           "ec.CampaignName, " +
                           "ec.CampaignSubject, " +
                           "CONVERT(DATE, MAX(ec.InsertDate))InsertDate " +
                    "FROM dbo.ECONTACT_CAMPAIGNNAME ec " +
                    "INNER JOIN [APPDBSERVER]."+ dbName +".[dbo].[Company] c ON c.CompanyID = ec.CompanyID " +
                    "INNER JOIN [APPDBSERVER]." + dbName + ".[dbo].[ParentCompany] p ON p.ID = c.ParentCompany " +
                    "WHERE ec.ParentProjectID = " + projectID +
                    " GROUP BY ec.ParentProjectID, " +
                           "ec.ProjectID, " +
                           "c.CompanyName, " +
                           "p.ParentCompany, " +
                           "ec.CampaignName, " +
                           "ec.CampaignSubject, " +
                           "InsertDate " + 
                    "ORDER BY NEWID()";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            campaignData.ParentCompanyID = reader["ParentProjectID"].ToString();
                            campaignData.ChildCampaignID = reader["ProjectID"].ToString();
                            campaignData.ChildCompanyName = reader["CompanyName"].ToString();
                            campaignData.CompanyName = reader["ParentCompany"].ToString();
                            campaignData.CampaignName = reader["CampaignName"].ToString();
                            campaignData.CampaignSubject = reader["CampaignSubject"].ToString();
                            campaignData.DateSubmitted = reader["InsertDate"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return campaignData;

        }
        public static AudienceBuilderData GetAudienceDetails(AudienceBuilderData details, string companyName, string isPublished, int isActive, int queryType, string audienceName = null)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            switch (queryType)
            {
                case 0:
                    query = query + "SELECT TOP 1 eiadfs.AudienceID," +
                                         "eiadfs.Name, " +
                                         "eiadfs.AudienceCreatedOn, " +
                                         "eiadfs.AudienceUpdatedOn, " +
                                         "eiadfs.AudienceCreatedByUserID, " +
                                         "eiadfs.IsActive, " +
                                         "eiadfs.Description, " +
                                         "eiadfs.PropertyNames, " +
                                         "eiadfs.AudienceUpdatedByUserID, " +
                                         "eiadfs.Tags " +
                            "FROM dbo.eInsight_Audience_Detail_For_Search eiadfs " +
                            "WHERE eiadfs.AudienceDetailType = '" + isPublished + "' " +
                                  " AND eiadfs.IsActive = " + isActive +
                                  " AND ISNULL(eiadfs.Description, '') <> '' " +
                            " AND eiadfs.Name IS NOT NULL " +
                            "GROUP BY eiadfs.AudienceID, " +
                                     "eiadfs.Name, " +
                                     "eiadfs.AudienceCreatedOn, " +
                                     "eiadfs.AudienceUpdatedOn, " +
                                     "eiadfs.AudienceCreatedByUserID, " +
                                     "eiadfs.IsActive, " +
                                     "eiadfs.Description, " +
                                     "eiadfs.PropertyNames, " +
                                     "eiadfs.AudienceUpdatedByUserID, " +
                                     "eiadfs.Tags " +
                            "HAVING COUNT(eiadfs.Name) = 1 " +
                    "ORDER BY NEWID();";
                    break;
                case 1:

                    query = query + " DECLARE @audiencename NVARCHAR(255)= '" + audienceName + "'; " +
                                "SELECT eiadfs.AudienceID," +
                                       "eiadfs.Name, " +
                                       "eiadfs.AudienceCreatedOn, " +
                                       "eiadfs.AudienceUpdatedOn, " +
                                       "eiadfs.AudienceCreatedByUserID, " +
                                       "eiadfs.IsActive, " +
                                       "eiadfs.Description, " +
                                       "eiadfs.PropertyNames, " +
                                       "eiadfs.AudienceUpdatedByUserID, " +
                                       "eiadfs.Tags " +
                            "FROM dbo.eInsight_Audience_Detail_For_Search eiadfs " +
                            "WHERE eiadfs.Name = @audiencename " +
                                " AND eiadfs.AudienceDetailType = '" + isPublished + "' " +
                                  "AND eiadfs.AudienceUpdatedOn = " +
                            "( " +
                                "SELECT MAX(AudienceUpdatedOn) " +
                                "FROM eInsight_Audience_Detail_For_Search eiadfs " +
                                "WHERE eiadfs.Name = @audiencename " +
                                " AND eiadfs.AudienceDetailType = '" + isPublished + "' " +
                            ");";
                    break;
            }

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 300;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            details.AudienceID = reader["AudienceID"].ToString();
                            details.AudienceName = reader["Name"].ToString();
                            details.InsertedOn = reader["AudienceCreatedOn"].ToString();
                            details.UpdatedOn = reader["AudienceUpdatedOn"].ToString();
                            details.InsertedByUser = reader["AudienceCreatedByUserID"].ToString();
                            details.IsActive = reader["IsActive"].ToString();
                            details.AudienceDescription = reader["Description"].ToString();
                            details.AudiencePropertyName = reader["PropertyNames"].ToString();
                            details.UpdatedBy = reader["AudienceUpdatedByUserID"].ToString();
                            details.Tags = reader["Tags"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return details;
        }

        public static AudienceBuilderData AudienceHistoryLog(AudienceBuilderData historyData, string companyName, string audienceName)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "SELECT TOP 1 eiah.ActivityType, " +
                                         "AudienceUpdatedByUserID, " +
                                         "eiadfs.AudienceUpdatedOn " +
                            "FROM dbo.eInsight_Audience_History eiah " +
                                 "INNER JOIN dbo.eInsight_Audience_Detail_For_Search eiadfs ON eiadfs.AudienceID = eiah.AudienceID " +
                            "WHERE eiadfs.Name = '" + audienceName + "' " +
                                  "AND eiadfs.IsActive = 1 " +
                            "ORDER BY eiah.ActivityDate DESC; ";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 300;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            historyData.ActivityType = reader["ActivityType"].ToString();
                            historyData.AudienceUpdatedByUserID = reader["AudienceUpdatedByUserID"].ToString();
                            historyData.AudienceUpdatedOn = reader["AudienceUpdatedOn"].ToString();
                        }
                    }
                }
            }

            return historyData;
        }
        public static UserStayData GetCurrencyDetails(UserStayData stayData, string companyName, string propertyorCorporate)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            GetDatabaseName();
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "IF OBJECT_ID('tempdb..#HadCompanyAccess')  IS NOT NULL " +
                                "DROP TABLE #HadCompanyAccess; " +
                            "SELECT c.CompanyName, " +
                                   "c.CompanyID " +
                            "INTO #HadCompanyAccess " +
                            "FROM [APPDBSERVER]."+ dbName + ".[dbo].[Users] [u] " +
                            "CROSS APPLY utility.split_int(u.CompanyID) ss " +
                            "INNER JOIN [APPDBSERVER]." + dbName + ".[dbo].Company c ON c.CompanyID = ss.value " +
                            "INNER JOIN [APPDBSERVER]." + dbName + ".[dbo].[Parentcompany] [p] ON c.ParentCompany = p.ID " +
                            "WHERE u.Email = 'cendynautomation@cendyn.com';";
                            if (!(companyName.Contains("Rydges")))
                            {
                                query = query + "SELECT DISTINCT TOP 10 dcsr.CustomerID " +
                                                "INTO #GetCustomerID " +
                                                "FROM dbo.D_CUSTOMER_STAY_RATE dcsr " +
                                                     "INNER JOIN dbo.D_CUSTOMER_STAY dcs ON dcs.SourceStayID = dcsr.SourceStayID " +
                                                "WHERE dcs.StayStatus = 'O' " +
                                                      "AND ISNULL(dcsr.StayRateAmount_Prop, 0) != 0 " +
                                                      "AND ISNULL(dcsr.StayRateAmount_Corp, 0) != 0 " +
                                                "GROUP BY dcsr.CustomerID " +
                                                "HAVING COUNT(dcsr.CustomerID) = 1;";
                            }
                            query = query + "SELECT TOP 1 dcsr.CustomerID, " +
                                      "dp.CurrencyCode, " +
                                      "dp.PropertyName, " +
                                      "dcsr.SourceStayID, " +
                                      "dcsr.ReservationNumber, " +
                                      "CONVERT(varchar, CAST(dcsr.StayRateAmount_Prop AS money), 1) StayRateAmount_Prop, " +
                                      "CONVERT(varchar, CAST(dcsr.StayRateAmount_Corp AS money), 1) StayRateAmount_Corp, " +
                                      "CONVERT(varchar, CAST(dcsr.StayRateAmountConvertedUSD AS money), 1) StayRateAmountConvertedUSD " +
                         "FROM dbo.D_CUSTOMER_STAY_RATE dcsr " +
                         "INNER JOIN dbo.D_PROPERTY dp ON dp.PropertyCode = dcsr.PropertyCode ";
            if (!(companyName.Contains("Rydges")))
            {
                query = query + "INNER JOIN #GetCustomerID gid ON gid.CustomerID = dcsr.CustomerID ";
            }
            if (companyName.Contains("Rydges"))
            {
                query = query + " WHERE dcsr.CustomerID IN(44913370, 47231129, 45823023, 45819193, 52237249, 50643842, 45938689, 45934859, 49799994, 47300764) ";
            }
            query = query + "ORDER BY NEWID();";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 500;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            stayData.CustomerID = reader["CustomerID"].ToString();
                            stayData.CurrencyCode = reader["CurrencyCode"].ToString();
                            stayData.PropertyName = reader["PropertyName"].ToString();
                            stayData.ReservationNumber = reader["ReservationNumber"].ToString();
                            stayData.StayRateAmount_Prop = reader["StayRateAmount_Prop"].ToString();
                            stayData.StayRateAmount_Corp = reader["StayRateAmount_Corp"].ToString();
                            stayData.StayRateAmountConvertedUSD = reader["StayRateAmountConvertedUSD"].ToString();
                            stayData.SourceStayID = reader["SourceStayID"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return stayData;
        }

        public static UserStayData GetRFMCurrency(UserStayData stayData, string companyName, string currency)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";

            if (!companyName.Contains("Standard") || !companyName.Contains("AMResorts"))
            {
                query = query + " SELECT TOP 10 REPLACE(FORMAT(Monetary, 'c', 'en-US'), '$', '') monetary  " +
                    "FROM Customer_RFM_Currency " +
                    "WHERE customer_id = " + stayData.CustomerID +
                          " AND currency = '" + currency.Replace("$ ", "") + "';";
            }
            else
            {
                query = query + " SELECT REPLACE(FORMAT(dcr.Monetary, 'c', 'en-US'), '$', '') monetary " +
                        "FROM dbo.D_CUSTOMER_RFM dcr " +
                        "WHERE dcr.CustomerID = " + stayData.CustomerID + ";";
            }

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            stayData.Monetory = reader["monetary"].ToString();
                        }
                    }
                }
                connection.Close();
            }

            return stayData;
        }
        public static UserPreference GetCurrencyPreferenceSaved(UserPreference data, string companyName)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + " SELECT up.UserID, " +
                           "up.CurrencyCode " +
                    "FROM dbo.UserParentCompanyPreference up " +
                        "INNER JOIN dbo.Parentcompany p " +
                            "ON p.ID = up.ParentCompanyID " +
                        "INNER JOIN dbo.Users u " +
                            "ON u.UserId = up.UserID " +
                    "WHERE p.ParentCompany LIKE '%" + companyName + "%' " +
                          "AND Email = 'cendynautomation@cendyn.com';";
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
                            data.user_id = reader["UserID"].ToString();
                            data.CurrencyCode = reader["CurrencyCode"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static ProfileCustData GetProfileDetails(string companyName, ProfileCustData profData)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + " WITH GetCustomerID " +
                     "AS (SELECT DISTINCT TOP 100 dcsr.CustomerID " +
                         "FROM dbo.D_CUSTOMER_STAY_RATE dcsr " +
                         "WHERE ISNULL(dcsr.StayRateAmount_Prop, '') != '' " +
                               "AND ISNULL(dcsr.StayRateAmount_Corp, '') != '' " +
                         "GROUP BY dcsr.CustomerID " +
                         "HAVING COUNT(dcsr.CustomerID) = 1) " +

                     "SELECT TOP 1 dc.CustomerID, " +
                                  "dc.FirstName, " +
                                  "dc.LastName, " +
                                  "Email, " +
                                  "CONVERT(DATE, dc.InsertDate) AS InsertDate, " +
                                  "CONVERT(DATE, dc.UpdateDate) AS UpdateDate, " +
                                  "CONVERT(DATE, dcs.ArrivalDate) AS ArrivalDate, " +
                                  "CONVERT(DATE, dcs.DepartureDate) AS DepartureDate, " +
                                  "CONVERT(DATE, dcs.ResCreationDate) AS ResCreationDate " +
                     "FROM dbo.D_CUSTOMER_STAY dcs WITH(NOLOCK) " +
                          "INNER JOIN dbo.D_CUSTOMER dc WITH(NOLOCK) ON dc.CustomerID = dcs.CustomerID " +
                          "INNER JOIN GetCustomerID gcid WITH(NOLOCK) ON dcs.CustomerID = gcid.CustomerID " +
                     "ORDER BY NEWID();";
            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            profData.CustomerID = reader["CustomerID"].ToString();
                            profData.InsertDate = reader["InsertDate"].ToString();
                            profData.UpdateDate = reader["UpdateDate"].ToString();
                            profData.ArrivalDate = reader["ArrivalDate"].ToString();
                            profData.DepartureDate = reader["DepartureDate"].ToString();
                            profData.ResCreationDate = reader["ResCreationDate"].ToString();
                            profData.Email = reader["Email"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return profData;
        }
        public static CampaignDetails GetManageCampaignDateDetails(string companyName, CampaignDetails campData)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + " WITH includeCompany " +
                     "AS (SELECT ss.Value " +
                         "FROM dbo.Users u " +
                              "CROSS APPLY dbo.SplitString(u.CompanyID) ss " +
                         "WHERE u.Email = 'cendynautomation@cendyn.com'), " +
                     "projectSubmitted " +
                     "AS (SELECT p.eContact_Campaign_ParentProjectID, " +
                                "MIN(p.DateSubmitted) DateSubmitted " +
                         "FROM [projects] p " +
                              "INNER JOIN dbo.Company c ON p.CompanyID = c.CompanyID " +
                              "INNER JOIN dbo.Parentcompany p2 ON p2.ID = c.ParentCompany " +
                              "INNER JOIN includeCompany ic ON ic.Value = c.CompanyID " +
                         "GROUP BY p.eContact_Campaign_ParentProjectID), " +
                     "projectrun " +
                     "AS (SELECT p.eContact_Campaign_ParentProjectID, " +
                                "MAX(pe.[on]) LastUpdated " +
                         "FROM dbo.projects p " +
                              "INNER JOIN dbo.projectevent pe ON p.eContact_Campaign_ParentProjectID = pe.ProjectID " +
                         "GROUP BY p.eContact_Campaign_ParentProjectID) " +
                     "SELECT TOP 1 ps.eContact_Campaign_ParentProjectID  AS ParentProjectID, " +
                            "CONVERT(DATE,ps.DateSubmitted)DateSubmitted, " +
                            "CONVERT(DATE,pr.LastUpdated)LastUpdated, " +
                            "p2.ParentCompany " +
                     "FROM projectSubmitted ps " +
                          "INNER JOIN projectrun pr ON ps.eContact_Campaign_ParentProjectID = pr.eContact_Campaign_ParentProjectID " +
                          "INNER JOIN dbo.projects p3 ON p3.eContact_Campaign_ParentProjectID = ps.eContact_Campaign_ParentProjectID " +
                          "INNER JOIN dbo.Company c ON p3.CompanyID = c.CompanyID " +
                          "INNER JOIN dbo.Parentcompany p2 ON p2.ID = c.ParentCompany " +
                          "INNER JOIN dbo.ManageCampaigns_GetProjects mc ON mc.ProjectID = p3.eContact_Campaign_ParentProjectID AND mc.IsTransactional = 0 ";
                    if(testCategory == "QA")
                    { 
                      query = query + "WHERE pr.eContact_Campaign_ParentProjectID = 40014445;";
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
                            campData.ParentProjectID = reader["ParentProjectID"].ToString();
                            campData.DateSubmitted = reader["DateSubmitted"].ToString();
                            campData.LastUpdated = reader["LastUpdated"].ToString();
                            campData.CompanyName = reader["ParentCompany"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return campData;
        }
        public static CampaignDetails GetProjectEventDetails(CampaignDetails data, string eventType)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + " WITH includeCompany " +
                    "AS (SELECT ss.Value " +
                        "FROM dbo.Users u " +
                            "CROSS APPLY dbo.SplitString(u.CompanyID) ss " +
                        "WHERE u.Email = 'cendynautomation@cendyn.com') " +
                    "SELECT TOP 1 " +
                           "e.projectid, " +
                           "e.companyid, " +
                           "p.ProjectName AS Title, " +
                           "REPLACE(p.EmailCampaignSubject, '#CUSTOMERID#', '') AS Subject, " +
                           "e.eventtype, " +
                           "CONVERT(DATE,e.[on]) AS DateSubmitted, " +
                           "e.[by] " +
                    "FROM projectevent e  " +
                        "JOIN projects p  " +
                            "ON e.projectid = p.ID " +
                               "AND e.projectid <> 0 " +
                               "AND p.ParentSubProjectId IS NULL " +
                        "JOIN includeCompany ic " +
                            "ON ic.Value = e.companyid " +
                    "WHERE ISNULL(e.projecteventid, '') <> 0 ";
            if (eventType != "All")
            {
                query = query + " AND e.eventtype = '" + eventType + "' ";
            }

            query = query + " ORDER BY e.[on] DESC;";

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
                            data.ParentProjectID = reader["projectid"].ToString();
                            data.ParentCompanyID = reader["companyid"].ToString();
                            data.CampaignName = reader["Title"].ToString();
                            data.Subject = reader["Subject"].ToString();
                            data.eventtype = reader["eventtype"].ToString();
                            data.DateSubmitted = reader["DateSubmitted"].ToString();
                            data.by = reader["by"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static string ReturnCompanyName(string caseID, string keyName, string planID = null)
        {
            query = "SELECT tdtqo.KeyValue " +
                    "FROM dbo.TestData_Template_QAOnly tdtqo " +
                    "WHERE ";
            if (!string.IsNullOrEmpty(planID))
            {
                query = query + " tdtqo.PlanID = '" + planID + "' " +
                                " and tdtqo.CaseID = 'NA' ";
            }
            else
            {
                query = query + "tdtqo.CaseID = '" + caseID + "' ";
            }
            query = query +
                  "AND tdtqo.IsEnable = 1 ";
            if (testCategory == "PostDeployment")
            {
                query = query + "AND tdtqo.KeyName = '" + "Prod_" + keyName + "'";
            }
            else if (testCategory == "POC")
            {
                query = query + "AND tdtqo.KeyName = '" + "POC_" + keyName + "'";
            }
            else if (testCategory == "EU02_PostDeployment")
            {
                query = query + "AND tdtqo.KeyName = '" + "ProdEU02_" + keyName + "'";
            }
            else
            {
                query = query + "AND tdtqo.KeyName = '" + keyName + "'";
            }


            using (SqlConnection connection = DBHelper.SqlConn2())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getValue = reader["KeyValue"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return getValue;
        }

        public static string ReturnCompanyNameByTestCase(string caseID, string keyName, string planID = null)
        {
            query = "SELECT tdtqo.KeyValue " +
                    "FROM dbo.TestData_Template_QAOnly tdtqo " +
                    "WHERE ";
            query = query + "tdtqo.CaseID = '" + caseID + "' " +
            "AND tdtqo.IsEnable = 1 ";
            if (testCategory == "PostDeployment")
            {
                query = query + "AND tdtqo.KeyName = '" + "Prod_" + keyName + "'";
            }
            else
            {
                query = query + "AND tdtqo.KeyName = '" + keyName + "'";
            }


            using (SqlConnection connection = DBHelper.SqlConn2())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            companyName = reader["KeyValue"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return companyName;
        }

        public static string ReturnDescriptionValue(string caseID, string keyName, string planID = null)
        {
            query = "SELECT tdtqo.Description " +
                    "FROM dbo.TestData_Template_QAOnly tdtqo " +
                    "WHERE ";
            if (!string.IsNullOrEmpty(planID))
            {
                query = query + " tdtqo.PlanID = '" + planID + "' " +
                                " and tdtqo.CaseID = 'NA' ";
            }
            else
            {
                query = query + "tdtqo.CaseID = '" + caseID + "' ";
            }
            query = query +
                  "AND tdtqo.IsEnable = 1 ";
            if (testCategory == "QA")
            {
                query = query + "AND tdtqo.KeyName = '" + keyName + "';";
            }
            if (testCategory == "PostDeploymemt")
            {
                query = query + "AND tdtqo.KeyName = 'Prod_" + keyName + "';";
            }
            if (testCategory == "POC")
            {
                query = query + "AND tdtqo.KeyName = 'POC_" + keyName + "';";
            }


            using (SqlConnection connection = DBHelper.SqlConn2())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getValue = reader["Description"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return getValue;
        }
        public static UserPreference GetUserCurrencyPreference(UserPreference userPref, string parentCompany)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "SELECT " +
                            "pref.UserID, " +
                            "pref.ParentCompanyID, " +
                            "pref.CurrencyCode, " +
                            "pref.UpdateTime " +
                            "FROM dbo.UserParentCompanyPreference pref " +
                            "INNER JOIN dbo.Parentcompany p ON p.ID = pref.ParentCompanyID " +
                            "INNER JOIN dbo.Users u ON u.UserId = pref.UserID " +
                            "WHERE p.ParentCompany = '" + parentCompany + "' AND u.Email = 'cendynautomation@cendyn.com'";

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
                            userPref.user_id = reader["UserID"].ToString();
                            userPref.CurrencyCode = reader["CurrencyCode"].ToString();
                            userPref.updatetime = reader["updatetime"].ToString();
                            userPref.ParentCompanyID = reader["ParentCompanyID"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return userPref;
        }

        public static CampaignDetails GetCampaignStatus(CampaignDetails campstatus, int projectiD)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "DECLARE @ParentProjectID INT= " + projectiD + "; " +
                            "SELECT ecemm.CampaignStatus, " +
                                   "ecemm.ExtractStatus, " +
                                   "p.eContact_Campaign_ParentProjectID AS ParentProjectID " +
                            "FROM dbo.eContact_eMailMarketing ecemm " +
                                 "INNER JOIN dbo.projects p ON p.ID = ecemm.ProjectID " +
                            "WHERE p.eContact_Campaign_ParentProjectID = @ParentProjectID OR p.ID = @ParentProjectID;";

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
                            campstatus.ParentProjectID = reader["ParentProjectID"].ToString();
                            campstatus.campaignStatus = reader["CampaignStatus"].ToString();
                            campstatus.extractStatus = reader["ExtractStatus"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return campstatus;
        }

        public static string ReturnCurrencyList(string CompanyName)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);

            string currencyList = "";

            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "WITH Results " +
                     "AS (SELECT DISTINCT " +
                                "CurrencyCode " +
                         "FROM eFolio_CustomerRevenue_Summary_Conversion) " +
                     "SELECT LTRIM(RTRIM(STUFF( " +
                     "( " +
                         "SELECT DISTINCT " +
                                "',' + CONVERT(VARCHAR(MAX), r.CurrencyCode) " +
                         "FROM Results r WITH(NOLOCK) FOR XML PATH('') " +
                     "), 1, 1, ''))) AS CurrencyCode;";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            currencyList = reader["CurrencyCode"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return currencyList;
        }
        public static CampaignDetails GetCampaignDetailsforPreviewForecaster(CampaignDetails campdetails, string casetype, int projectID, string companyName)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            switch (casetype)
            {
                case "Preview":
                    query = query + " WITH HasAccess " +
                                     "AS (SELECT ss.Value " +
                                         "FROM dbo.Users " +
                                              "CROSS APPLY dbo.SplitString(CompanyID) ss " +
                                         "WHERE Email = 'cendynautomation@cendyn.com') " +
                                     "SELECT TOP 1 CASE " +
                                                      "WHEN ISNULL(p.eContact_Campaign_ParentProjectID, '') = '' " +
                                                      "THEN p.ID " +
                                                      "ELSE p.eContact_Campaign_ParentProjectID " +
                                                  "END AS ParentProjectID, " +
                                                  "p.EmailCampaignSubject, " +
                                                  "p.EmailCampaignName AS CampaignName, " +
                                                  "c.CompanyName, " +
                                                  "c.CompanyName, " +
                                                  "CONVERT(DATE, adrr.RequestedDate) RequestedDate " +
                                     "FROM [projects] p " +
                                          "INNER JOIN dbo.Company c ON p.CompanyID = c.CompanyID " +
                                          "INNER JOIN dbo.Parentcompany p2 ON p2.ID = c.ParentCompany " +
                                          "INNER JOIN HasAccess a ON a.Value = c.CompanyID " +
                                          "INNER JOIN eInsight_InboxPreviews adrr ON adrr.ProjectId = p.eContact_Campaign_ParentProjectID " +
                                     "WHERE ISNULL(p.eContact_Campaign_ParentProjectID, '') != '' " +
                                           "AND ISNULL(p.EmailCampaignName, '') != '' " +
                                           "AND p2.ParentCompany = '"+ companyName + "' " +
                                           //"AND c.CompanyName = 'Independent Collection' " +
                                           "AND p.eContact_Campaign_ParentProjectID = " + projectID +
                                           " OR p.ID = " + projectID +
                                     " ORDER BY adrr.ID desc;";


                    break;
                case "Forecaster":
                    query = query + "WITH HasAccess " +
                                     "AS (SELECT ss.Value " +
                                         "FROM dbo.Users " +
                                              "CROSS APPLY dbo.SplitString(CompanyID) ss " +
                                         "WHERE Email = 'cendynautomation@cendyn.com') " +
                                     "SELECT TOP 1 CASE " +
                                                      "WHEN ISNULL(p.eContact_Campaign_ParentProjectID, '') = '' " +
                                                      "THEN p.ID " +
                                                      "ELSE p.eContact_Campaign_ParentProjectID " +
                                                  "END AS ParentProjectID, " +
                                                  "p.EmailCampaignSubject, " +
                                                  "p.EmailCampaignName AS CampaignName, " +
                                                  "c.CompanyName, " +
                                                  "CONVERT(DATE, adrr.RequestedDate) RequestedDate " +
                                     "FROM [projects] p " +
                                          "INNER JOIN dbo.Company c ON p.CompanyID = c.CompanyID " +
                                          "INNER JOIN dbo.Parentcompany p2 ON p2.ID = c.ParentCompany " +
                                          "INNER JOIN HasAccess a ON a.Value = c.CompanyID " +
                                          "INNER JOIN eInsight_AdvanceDeliverabilityReport_Events adrr ON adrr.ProjectId = p.eContact_Campaign_ParentProjectID " +
                                     "WHERE ISNULL(p.eContact_Campaign_ParentProjectID, '') != '' " +
                                           "AND v3.mapProjectStatus([Status], NULL) IN('Approved', 'Scheduled') " +
                                           "AND p2.ParentCompany = '"+ companyName + "' " +
                                           //"AND c.CompanyName = 'Independent Collection' " +
                                           "AND p.eContact_Campaign_ParentProjectID =  " + projectID +
                                           " OR p.ID = " + projectID +
                                     " ORDER BY adrr.RequestedDate DESC;";
                    break;
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
                            campdetails.ParentProjectID = reader["ParentProjectID"].ToString();
                            campdetails.Subject = reader["EmailCampaignSubject"].ToString();
                            campdetails.CampaignName = reader["CampaignName"].ToString();
                            campdetails.CompanyName = reader["CompanyName"].ToString();
                            campdetails.RequestDate = reader["RequestedDate"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return campdetails;
        }
        public static CampaignDetails GetCampaignforClone(CampaignDetails campdata)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + " WITH includeCompany " +
                             "AS (SELECT ss.Value AS CompanyID " +
                                 "FROM dbo.Users u " +
                                      "CROSS APPLY dbo.SplitString(u.CompanyID) ss " +
                                 "WHERE u.Email = 'cendynautomation@cendyn.com') " +
                             "SELECT TOP 1 p.eContact_Campaign_ParentProjectID AS ParentProjectID, " +
                                          "p.EmailCampaignName, " +
                                          "p.EmailCampaignSubject, " +
                                          "p2.ParentCompany, " +
                                          "c.CompanyName " +
                             "FROM dbo.projects p " +
                                  "INNER JOIN includeCompany ic ON p.CompanyID = ic.CompanyID " +
                                  "INNER JOIN dbo.Company c ON c.CompanyID = ic.CompanyID " +
                                  "INNER JOIN dbo.Parentcompany p2 ON p2.ID = c.ParentCompany " +
                             "WHERE p.RequestedBy = 'jshah@cendyn.com' " +
                                   "AND ISNULL(p.eContact_Campaign_ParentProjectID, '') != '' " +
                                   "AND p2.ParentCompany = 'Independent Collection' " +
                                   "AND p.EmailCampaignName Not Like '%Clone%' " +
                             "ORDER BY p.eContact_Campaign_ParentProjectID desc;";

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
                            campdata.ParentProjectID = reader["ParentProjectID"].ToString();
                            campdata.CampaignName = reader["EmailCampaignName"].ToString();
                            campdata.Subject = reader["EmailCampaignSubject"].ToString();
                            campdata.ParentCompanyName = reader["ParentCompany"].ToString();
                            campdata.CompanyName = reader["CompanyName"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return campdata;
        }

        public static ProfileCustData SendForCASL(ProfileCustData StayData, string CompanyName, int queryCase, int projectID)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(CompanyName, Connstr);

            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";

            switch (queryCase)
            {
                case 1:
                    {
                        query = query + " WITH EmailResult " +
                                 "AS ( " +
                                 "SELECT srd.Email, " +
                                        "srms.Subject " +
                                 "FROM dbo.SM_REPORT_DELIVERED srd  " +
                                      "INNER JOIN dbo.SM_REPORT_MAILING_SUMMARY srms  ON srms.ChildProjectID = srd.ChildProjectID " +
                                 "WHERE srms.ParentProjectID = '" + projectID + "') " +
                                 "SELECT TOP 1 dc.CustomerID, " +
                                              "dc.FirstName, " +
                                              "dc.LastName, " +
                                              "dc.Email, " +
                                              "CASE " +
                                                  "WHEN ISNULL(dc.CountryCode, '') = '' " +
                                                  "THEN 'N/A' " +
                                                  "ELSE dc.CountryCode " +
                                              "END AS CountryCode, " +
                                              "CASE " +
                                                  "WHEN ISNULL(dcs.ArrivalDate, '') = '' " +
                                                  "THEN 'N/A' " +
                                                  "ELSE CONVERT(NVARCHAR(25), dcs.ArrivalDate, 101)" +
                                              "END AS ArrivalDate, " +
                                              "CASE " +
                                                  "WHEN ISNULL(dcs.DepartureDate, '') = '' " +
                                                  "THEN 'N/A' " +
                                                  "ELSE CONVERT(NVARCHAR(25), dcs.DepartureDate, 101) " +
                                              "END AS DepartureDate, "+
                                             "CASE " +
                                                  "WHEN ISNULL(dcs.SourceStayID, 0) = 0 " +
                                                  "THEN CAST('N/A' AS NVARCHAR(10)) " +
                                                  "ELSE CONVERT(NVARCHAR(25), dcs.SourceStayID) " +
                                              "END AS SourceStayID, " +
                                              "EmailResult.Subject, " +
                                              "dcs.ReservationNumber " +
                                 "FROM dbo.D_CUSTOMER dc  " +
                                      "LEFT JOIN dbo.D_CUSTOMER_STAY dcs  ON dcs.CustomerID = dc.CustomerID " +
                                      "INNER JOIN EmailResult ON EmailResult.Email = dc.Email " +
                                 "where dc.EmailStatus = 1 " +
                                       "AND ISNULL(dcs.ArrivalDate, '') != '' " +

                                       "AND dc.CountryCode = 'CA' " +
                                 "ORDER BY NEWID();";
                        break;
                    }
            }

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 120;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StayData.CustomerIDs = reader["CustomerID"].ToString();
                            StayData.FirstName = reader["FirstName"].ToString();
                            StayData.LastName = reader["LastName"].ToString();
                            StayData.Email = reader["Email"].ToString();
                            StayData.CountryCode = reader["CountryCode"].ToString();
                            StayData.ArrivalDate = reader["ArrivalDate"].ToString();
                            StayData.DepartureDate = reader["DepartureDate"].ToString();
                            StayData.SourceStayID = reader["SourceStayID"].ToString();
                            StayData.CampaignSubject = reader["Subject"].ToString();
                            StayData.ReservationNumber = reader["ReservationNumber"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return StayData;
        }

        public static CampaignDetails GetCASLReservationDetails(CampaignDetails data, string CompanyName)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(CompanyName, Connstr);

            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";

            query = query + "IF OBJECT_ID('tempdb..#GetCampaignEmails')  IS NOT NULL " +
                            "DROP TABLE #GetCampaignEmails; " +

                            "SELECT DISTINCT " +
                                   "dce.CustomerID, " +
                                   "srd.Email, " +
                                   "srms.CampaignName, " +
                                   "srms.Subject " +
                            "INTO #GetCampaignEmails " +
                            "FROM dbo.SM_REPORT_MAILING_SUMMARY srms " +
                                 "INNER JOIN dbo.SM_REPORT_DELIVERED srd ON srd.ChildProjectID = srms.ChildProjectID " +
                                 "INNER JOIN dbo.D_CUSTOMER_EMAIL dce ON dce.Email = srd.Email " +
                            "WHERE srms.ParentProjectID = 40009523 " +


                            "SELECT TOP 1 dc.CustomerID, dc.Email, dcs.ReservationNumber, gce.CampaignName FROM dbo.D_CUSTOMER dc " +
                            "INNER JOIN #GetCampaignEmails gce ON gce.CustomerID = dc.CustomerID " +
                            "INNER JOIN dbo.D_CUSTOMER_STAY dcs ON dcs.CustomerID = dc.CustomerID " +
                            "WHERE dc.EmailStatus = 1 " +
                                  "AND dc.CountryCode = 'CA' " +
                            "ORDER BY NEWID(); ";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Email = reader["Email"].ToString();
                            data.CampaignName = reader["CampaignName"].ToString();
                            data.CampaignSubject = reader["CampaignSubject"].ToString();
                            data.ReservationNumber = reader["ReservationNumber"].ToString();
                            data.CustomerID = reader["CustomerID"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static ClientdbConnection GetAssignedCompanyFromUser(ClientdbConnection data, string emailaddress, string companyName = null)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "DECLARE @emailAddress NVARCHAR(255)= '" + emailaddress + " '; " +

                            "IF OBJECT_ID('tempdb..#HasAccess') IS NOT NULL " +
                                "DROP TABLE #HasAccess; " +

                            "SELECT c.CompanyName " +
                            "INTO #HasAccess " +
                            "FROM dbo.Users u " +
                                 "CROSS APPLY dbo.SplitString(u.CompanyID) ss " +
                                 "INNER JOIN dbo.Company c ON ss.Value = c.CompanyID " +
                                 "INNER JOIN dbo.Parentcompany p ON p.ID = c.ParentCompany " +
                            "WHERE u.Email = @emailAddress ";
            if (!String.IsNullOrEmpty(companyName))
            {
                query = query + "AND p.ParentCompany = '" + companyName + "';";
            }


            query = query + "SELECT STUFF( " +
                            "( " +
                                "SELECT ', ' + CAST(r.CompanyName AS VARCHAR(MAX)) " +
                                "FROM #HasAccess r FOR XML PATH('') " +
                            "), 1, 1, '') AS CompanyName; " +

                                "DROP TABLE #HasAccess;";


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
                            data.CompanyName = reader["CompanyName"].ToString();
                        }
                    }
                }
                connection.Close();
                return data;
            }
        }
        private static string getPropertyDatafromJSON(string jsonValue)
        {
            string value;
            var quote = '"';

            JObject rss = JObject.Parse(jsonValue);

            value = rss["propertyPool"].ToString().Replace(quote.ToString(), "").Replace("[", "").Replace("]", "").TrimStart().TrimEnd().Replace(Environment.NewLine, "");

            return value;
        }

        public static AudienceBuilderData createAudience(string CompanyName, AudienceBuilderData audienceBuilderData, string audienceName, string criteriajson, string email, string isActive = null)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(CompanyName, Connstr);

            string getPropertyCodes = getPropertyDatafromJSON(criteriajson);

            query = "DECLARE @audienceName NVARCHAR(MAX) = N'" + audienceName + "'; " +
                    "DECLARE @propertycodes NVARCHAR(MAX) = N'" + getPropertyCodes + "'; " +
                    "DECLARE @email NVARCHAR(MAX) = N'" + email + "'; " +
                    "DECLARE @hasAudience INT = " +
                            "( " +
                                "SELECT COUNT(eiadfs.Name) " +
                                "FROM dbo.eInsight_Audience_Detail_For_Search eiadfs " +
                                "WHERE eiadfs.Name = @audienceName " +
                            "); " +
                    "IF (@hasAudience > 0) " +
                    "BEGIN " +
                        "SELECT AudienceID, 1 AS AudienceDetailID FROM dbo.eInsight_Audience_Detail_For_Search eiadfs " +
                        "WHERE eiadfs.Name = @audienceName; " +
                    "END; " +
                    "IF (@hasAudience < 1) " +
                    "BEGIN " +
                        "EXEC dbo.eInsight_Audience_Create @Name = @audienceName, " +
                                                          "@Description = @audienceName, " +
                                                          "@DynamicCriteriaJSON = '" + criteriajson + "'," +
                                                          "@Tags = @audienceName, " +
                                                          "@PropertyCodes = @propertycodes, ";
            if (!(String.IsNullOrEmpty(isActive)))
            {
                query = query + "@IsActive = 0, ";
            }
            else
            {
                query = query + "@IsActive = 1, ";
            }
            query = query + "@User = @email; " +
                    "END;";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 120;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            audienceBuilderData.AudienceID = reader["AudienceID"].ToString();
                            audienceBuilderData.AudienceDetailID = reader["AudienceDetailID"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return audienceBuilderData;
        }
        public static AudienceBuilderData publishAudience(string CompanyName, AudienceBuilderData audienceBuilderData, string audienceName, string email)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(CompanyName, Connstr);

            query = "DECLARE @NewPublishedDetailID INT; " +
                    "DECLARE @AudienceName NVARCHAR(MAX) = '" + audienceName + "'; " +
                    "DECLARE @email NVARCHAR(MAX) = '" + email + "'; " +
                    "DECLARE @AudienceID INT= " +
                    "( " +
                        "SELECT TOP 1 eiadfs.AudienceID " +
                        "FROM dbo.eInsight_Audience_Detail_For_Search eiadfs " +
                        "WHERE Name = @AudienceName " +
                    "); " +

                    "EXEC dbo.eInsight_Audience_Publish " +
                         "@AudienceID = @AudienceID, " +
                         "@User = @email, " +
                         "@NewPublishedDetailID = @NewPublishedDetailID OUTPUT; " +

                    "SELECT @NewPublishedDetailID AS NewPublishedDetailID;";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 240;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            audienceBuilderData.AudiencePublishDetailID = reader["NewPublishedDetailID"].ToString();
                        }
                    }
                }
                connection.Close();
            }

            return audienceBuilderData;
        }

        public static AudienceBuilderData SetAudienceActiveStatus(string CompanyName, AudienceBuilderData audienceBuilderData, string audienceName, int isActive)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(CompanyName, Connstr);

            query = "EXEC dbo.SetAudienceActiveInActive_QAOnly @AudienceName = N'" + audienceName + "', " +
                                          "@activeStatus = " + isActive;

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    command.ExecuteReader();
                }
                connection.Close();
            }

            return audienceBuilderData;
        }
        public static string GetAudienceCriteria(string audienceName, string companyName, string AudienceDetailType = null, string querytype = null)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);

            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            switch (querytype)
            {
                case "getSpecificCriteria":
                    query = query + "SELECT Top 1 " +
                                   "eiad.DynamicCriteriaJSON " +
                            "FROM dbo.eInsight_Audience_Detail eiad " +
                                 "INNER JOIN dbo.eInsight_Audience eia ON eia.AudienceID = eiad.AudienceID " +
                            "WHERE eia.Name = '" + audienceName + "'";
                    if (AudienceDetailType == "LastSaved")
                    {
                        query = query + " AND eiad.IsPublished = 0 " +
                                        " ORDER BY eiad.AudienceDetailID desc;";
                    }
                    if (AudienceDetailType == "LastPublished")
                    {
                        query = query + " AND eiad.IsPublished = 1" +
                                        " ORDER BY eiad.AudienceDetailID desc;";
                    }

                    break;
                default:
                    query = query + "SELECT DISTINCT " +
                                   "eiad.DynamicCriteriaJSON " +
                            "FROM dbo.eInsight_Audience_Detail eiad " +
                                 "INNER JOIN dbo.eInsight_Audience eia ON eia.AudienceID = eiad.AudienceID " +
                            "WHERE eia.Name = '" + audienceName + "';";
                    break;
            }


            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            companyName = reader["DynamicCriteriaJSON"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return companyName;
        }
        public static string GetAudienceIds(string companyName, string campaignStatusType = null, string scheduleStatusType = null)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            GetDatabaseName();

            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "IF OBJECT_ID('tempdb..#ProjectAudiencetemp') IS NOT NULL " +
                                "DROP TABLE #ProjectAudiencetemp; " +
                            "SELECT DISTINCT " +
                                   "* " +
                            "INTO #ProjectAudiencetemp " +
                            "FROM OPENQUERY([APPDBSERVER], 'SELECT "+ dbName + ".v3.mapProjectStatus([Status], NULL) AS OldStatus, pa.*, p2.EmailCampaignName FROM "+ dbName +".[dbo].[ProjectsAudience] pa " +
                                 "INNER JOIN " + dbName + ".[dbo].[Parentcompany] p ON p.ID = pa.CompanyId " +
                                 "INNER JOIN " + dbName + ".[dbo].[Company] c ON c.ParentCompany = p.ID " +
                                 "INNER JOIN " + dbName + ".[dbo].[projects] p2 ON pa.ProjectId = (CASE " +
                                    "WHEN ISNULL(p2.eContact_Campaign_ParentProjectID, '''') = '''' " +
                                    "THEN p2.ID " +
                                    "ELSE p2.eContact_Campaign_ParentProjectID " +
                                "END) " +
                            "WHERE p.ParentCompany = ''" + companyName + "'';') oq " +
                            " WHERE LEN(oq.EmailCampaignName) < 15 ";
            if (!String.IsNullOrEmpty(campaignStatusType))
            {
                query = query + " AND oq.oldstatus = '" + campaignStatusType + "'";
            }
            if (!String.IsNullOrEmpty(scheduleStatusType))
            {
                query = query + " AND oq.ActiveStatus_YN = '" + scheduleStatusType + "'";
            }

            query = query + ";WITH Results " +
                 "AS (SELECT DISTINCT TOP 1 AudienceID, " +
                                           "NEWID() AS NewIDs " +
                     "FROM #ProjectAudiencetemp pa " +
                     "ORDER BY NEWID()) " +
                 "SELECT STUFF( " +
                 "( " +
                     "SELECT TOP 1 ', ' + CAST(r.AudienceID AS VARCHAR(MAX)) " +
                     "FROM Results r " +
                     "ORDER BY NEWID() FOR XML PATH('') " +
                 "), 1, 1, '') AS AudienceIDs;";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 90;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getValue = reader["AudienceIDs"].ToString();
                        }
                    }
                }
                connection.Close();
            }

            return getValue;
        }
        public static AudienceBuilderData GetAudienceProjects(AudienceBuilderData data, string companyName, string audienceID, string projectID = null, string campaignStatusType = null)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            GetDatabaseName();
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";


            query = query + "DECLARE @AudienceId INT= " + audienceID + "; " +
                            "WITH Results " +
                             "AS (SELECT TOP 1 paqo.[AudienceId], " +
                                            "LTRIM(RTRIM(STUFF( " +
                                "( " + 
                                "SELECT DISTINCT " +
                                           "',' + CONVERT(VARCHAR(10), [pa2].[ProjectId]) " +
                                       "FROM [APPDBSERVER]."+ dbName +".[dbo].[ProjectAudience_QAOnly] pa2 " +
                                       "WHERE([pa2].[AudienceId] = [paqo].[AudienceId] " +
                                           "AND pa2.ParentCompany = paqo.ParentCompany) FOR XML PATH('') " +
                                   "), 1, 1, ''))) AS ProjectIds " +
                                   "FROM [APPDBSERVER]." + dbName + ".[dbo].[ProjectAudience_QAOnly] paqo " +
                                    "WHERE paqo.AudienceId = @AudienceId " +
                                    " AND paqo.ParentCompany = '" + companyName + "'" +
                                    ") " +
                                    "SELECT DISTINCT TOP 1 " +
                                    "pa.ID AS ProjectId, " +
                                    "pa.Name AS ProjectName, " +
                                    "pa.Details, " +
                                    "pa.AudienceId, " +
                                    "pa.CreatedOn AS DateSubmitted , " +
                                    "pa.ModifiedOn, " +
                                    "eia.Name AS AudienceName, " +
                                    "r.ProjectIds, " +
                                    "pa.Status " +
                                  "FROM Results r " +
                                  "CROSS APPLY utility.split_int(r.ProjectIds) si " +
                                  "INNER JOIN [APPDBSERVER]." + dbName + ".[dbo].[ProjectAudience2_QAOnly] pa ON pa.ID = si.value " +
                                  "INNER JOIN dbo.eInsight_Audience eia ON eia.AudienceID = r.AudienceId " +
                                                                          "AND eia.IsActive = 1 ";
            if (!String.IsNullOrEmpty(projectID))
            {
                query = query + "WHERE pa.ID = " + projectID;
            }


            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 600;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.ParentProjectID = reader["ProjectId"].ToString();
                            data.CampaignName = reader["ProjectName"].ToString();
                            data.eventtype = reader["Details"].ToString();
                            data.AudienceID = reader["AudienceId"].ToString();
                            data.DateSubmitted = reader["DateSubmitted"].ToString();
                            data.ModifiedOn = reader["ModifiedOn"].ToString();
                            data.AudienceName = reader["AudienceName"].ToString();
                            data.ParentProjectIDs = reader["ProjectIds"].ToString();
                            data.OldStatus = reader["Status"].ToString();
                            //data.CompanyID = reader["CompanyId"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }

        public static string HasSubjectLineTag(string companyName, int projectID, string subjectLine, int caseType)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);

            query = "EXEC dbo.CheckProjectSubjectLineMap_QAOnly @projectID = " + projectID + ", " +
                                           "@subjectLine = N'" + subjectLine + "', " +
                                           "@caseType = " + caseType + "; ";


            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getValue = reader["Result"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return getValue;
        }
        public static string HasParentSetting(string companyName, string settingName)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "DECLARE @HasPropertyFromName NVARCHAR(5) = (SELECT ecs.SettingValue " +
                            "FROM dbo.eContact_ParentCompany_Settings ecs " +
                                 "INNER JOIN dbo.Parentcompany p ON ecs.CompanyID = p.ID " +
                            "WHERE ecs.SettingName LIKE '" + settingName + "' " +
                                  "AND p.ParentCompany = '" + companyName + "' " +
                            "); " +


                            "IF (@HasPropertyFromName = 'Y') " +
                            "SELECT 'Enabled' AS Result " +
                            "ELSE " +
                            "SELECT 'Disabled' AS Result";


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
                            getValue = reader["Result"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return getValue;
        }

        public static void UpdateAudience(string companyName, string audienceName, string isActive, string casetype, string audienceID = null)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            switch (casetype)
            {
                case "AudienceStatus":
                    query = "UPDATE eia " +
                    "SET eia.IsActive = " + isActive +
                    "FROM dbo.eInsight_Audience eia " +
                    "WHERE eia.Name = '" + audienceName + "'";
                    break;
                case "AudienceName":
                    query = "DECLARE @audienceName NVARCHAR(255) = '" + audienceName + "'; " +
                            "DECLARE @audienceID int = " + audienceID +

                            "UPDATE eia " +
                            "SET eia.Name = @audienceName " +
                            "FROM dbo.eInsight_Audience eia " +
                            "WHERE eia.AudienceID = @audienceID";
                    break;
            }

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
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

        public static string GetAudiencePublishedName(string companyName, string audienceDetailType, int isActive)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);

            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query = query + "WITH GetAudienceName " +
                             "AS (SELECT TOP 10 eiadfs.Name " +
                                 "FROM dbo.eInsight_Audience_Detail_For_Search eiadfs " +
                                 "WHERE eiadfs.AudienceDetailType = '" + audienceDetailType + "' " +
                                       "AND eiadfs.IsActive =  " + isActive +
                                 " ORDER BY eiadfs.AudienceUpdatedOn DESC) " +
                             "SELECT TOP 1 g.Name " +
                             "FROM GetAudienceName g " +
                             "ORDER BY NEWID();";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getValue = reader["Name"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return getValue;
        }

        public static AudienceBuilderData getForeCastAudience(string companyName, string audienceName, AudienceBuilderData data, string isPublished = null)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);

            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "WITH results " +
                            "AS (SELECT MAX(eiadfl.AudienceDetailForecastLogID) AudienceDetailForecastLogID " +
                                "FROM dbo.eInsight_Audience eia " +
                                    "INNER JOIN dbo.eInsight_Audience_Detail eiad ON eiad.AudienceID = eia.AudienceID " +
                                    "INNER JOIN dbo.eInsight_Audience_Detail_Forecast_Log eiadfl ON eiadfl.AudienceDetailID = eiad.AudienceDetailID " +
                                                                                                    "AND eiadfl.AudienceDetailForecastLogID = eiad.AudienceDetailForecastLogID ";
            if (String.IsNullOrEmpty(isPublished))
            {
                query = query + "WHERE eia.Name = '" + audienceName + "') ";
            }
            if (!(String.IsNullOrEmpty(isPublished)))
            {
                query = query + "WHERE eia.Name = '" + audienceName + "') and eiad.IsPublished = " + isPublished;
            }

            query = query + "SELECT eia.AudienceID, " +
                        "eia.Name, " +
                        "PARSENAME(CONVERT(varchar, CAST( eiadfl2.CountBounced AS money), 1), 2) CountBounced, " +
                        "PARSENAME(CONVERT(varchar, CAST( eiadfl2.CountFlagged AS money), 1), 2) CountFlagged, " +
                        "PARSENAME(CONVERT(varchar, CAST( eiadfl2.CountNonConsent AS money), 1), 2) CountNonConsent, " +
                        "PARSENAME(CONVERT(varchar, CAST( eiadfl2.CountNull AS money), 1), 2) CountNull, " +
                        "PARSENAME(CONVERT(varchar, CAST( eiadfl2.CountTotal AS money), 1), 2) CountTotal, " +
                        "PARSENAME(CONVERT(varchar, CAST( eiadfl2.CountUnique AS money), 1), 2) CountUnique, " +
                        "PARSENAME(CONVERT(varchar, CAST( eiadfl2.CountUnsubscribed AS money), 1), 2) CountUnsubscribed, " +
                        "PARSENAME(CONVERT(varchar, CAST( eiadfl2.CountValid AS money), 1), 2) CountValid, " +
                        "PARSENAME(CONVERT(varchar, CAST( eiadfl2.CountInvalid AS money), 1), 2) CountInvalid " +
                    "FROM dbo.eInsight_Audience_Detail_Forecast_Log eiadfl2 " +
                        "INNER JOIN results r1 ON r1.AudienceDetailForecastLogID = eiadfl2.AudienceDetailForecastLogID " +
                        "INNER JOIN dbo.eInsight_Audience_Detail eiad ON eiad.AudienceDetailForecastLogID = eiadfl2.AudienceDetailForecastLogID " +
                        "INNER JOIN dbo.eInsight_Audience eia ON eia.AudienceID = eiad.AudienceID;";
            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.AudienceID = reader["AudienceID"].ToString();
                            data.AudienceName = reader["Name"].ToString();
                            data.CountBounced = reader["CountBounced"].ToString();
                            data.CountFlagged = reader["CountFlagged"].ToString();
                            data.CountNonConsent = reader["CountNonConsent"].ToString();
                            data.CountNull = reader["CountNull"].ToString();
                            data.CountUnique = reader["CountUnique"].ToString();
                            data.CountUnsubscribed = reader["CountUnsubscribed"].ToString();
                            data.CountValid = reader["CountValid"].ToString();
                            data.CountInvalid = reader["CountInvalid"].ToString();
                            data.CountTotal = reader["CountTotal"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return data;
        }
        public static string GetAudienceCustomer(string companyName, string audienceID)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);

            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "IF OBJECT_ID('tempdb..#Results') IS NOT NULL " +
                                "DROP TABLE #Results; " +

                            "SELECT DISTINCT TOP 2 dc.Email " +
                            "INTO #Results " +
                            "FROM cache.audience_"+ audienceID + "_1 a " +
                                 "INNER JOIN dbo.D_CUSTOMER dc ON a.customer_id = dc.CustomerID; " +
                            "SELECT STUFF( " +
                            "( " +
                                "SELECT ',' + CONVERT(VARCHAR(255), s.Email) " +
                                "FROM #Results s FOR XML PATH('') " +
                            "), 1, 1, '') Email;";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getValue = reader["Email"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return getValue;
        }

        public static string GetReservationCount(string companyName)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);

            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "IF OBJECT_ID('tempdb..#ReservationsByBookedDate') IS NOT NULL " +
                        "DROP TABLE #ReservationsByBookedDate; " +
                    "IF OBJECT_ID('tempdb..#CreateSourceStayID') IS NOT NULL " +
                        "DROP TABLE #CreateSourceStayID; " +

                    "DECLARE @startDate DATETIME= CONVERT(DATE, GETDATE()); " +
                    "DECLARE @endDate DATETIME= CONVERT(DATE, GETDATE()); " +
                    "DECLARE @ResCreateDate DATETIME= CONVERT(DATE, GETDATE()); " +
                    "DECLARE @ArrivalDate DATETIME= CONVERT(DATE, @ResCreateDate + 1); " +
                    "DECLARE @DepartureDate DATETIME= CONVERT(DATE, @ArrivalDate + 8); " +
                    "DECLARE @datediff INT= " +
                    "( " +
                        "SELECT DATEDIFF(DAY, @ArrivalDate, @DepartureDate) " +
                    "); " +

                    "DECLARE @ResNum NVARCHAR(255)= 'Test' + CONVERT(VARCHAR, @ResCreateDate, 112); " +
                    "DECLARE @CustID INT= 4554494; " +
                    "DECLARE @SourceGuestID INT= 509919; " +
                    "DECLARE @hasSourceStayID INT; " +

                    "CREATE TABLE #ReservationsByBookedDate " +
                    "(SourceStayID         INT, " +
                        "CustomerID           INT, " +
                        "Name                 NVARCHAR(255), " +
                        "Email                NVARCHAR(255), " +
                        "PropertyName         NVARCHAR(255), " +
                        "ReservationNumber    NVARCHAR(255), " +
                        "SubReservationNumber NVARCHAR(255), " +
                        "StayStatus           NVARCHAR(255), " +
                        "ArrivalDate          NVARCHAR(255), " +
                        "DepartureDate        NVARCHAR(255), " +
                        "BookedDate           NVARCHAR(255), " +
                        "CompanyID            NVARCHAR(255), " +
                        "CancelDate           DATETIME, " +
                        "UpdatedDate          DATETIME " +
                    "); " +

                    "CREATE TABLE #CreateSourceStayID(SourceStayID INT); " +
                    "INSERT INTO #ReservationsByBookedDate " +
                    "EXEC dbo.metrans_GetReservationsByBookedDate " +
                            "@startDate, " +
                            "@endDate; " +

                    "SELECT COUNT(1) AS Result " +
                    "FROM #ReservationsByBookedDate;";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getValue = reader["Result"].ToString();
                        }
                    }
                }
                connection.Close();
            }

            return getValue;
        }

        public static string HasBookingReservation(string companyName, int customerID, int sourceGuestID, int emailID, int hasEmail)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);

            query = "EXEC dbo.CreateReservationbyBookingDate_QAOnly @CustomerID = " + customerID + ", " +
                                               "@SourceGuestID = " + sourceGuestID + ", " +
                                               "@EmailID = " + emailID + ", " +
                                               "@HasEmail = " + hasEmail;

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getValue = reader["Result"].ToString();
                        }
                    }
                }
                connection.Close();
            }

            return getValue;
        }

        public static string HasBookingReservation_NoCampaignAttached(string companyName, int customerID, int sourceGuestID, int emailID, int hasEmail)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);

            query = "EXEC dbo.CreateReservationbyBookingDate_QAOnly_NotAttachedCampaign @CustomerID = " + customerID + ", " +
                                               "@SourceGuestID = " + sourceGuestID + ", " +
                                               "@EmailID = " + emailID + ", " +
                                               "@HasEmail = " + hasEmail;

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getValue = reader["Result"].ToString();
                        }
                    }
                }
                connection.Close();
            }

            return getValue;
        }

        public static ProfileCustData GetStayDetails(string companyName, ProfileCustData profData, string email, int matchnomatch, string startDate = null, string endDate = null, string clientName = null, string hasNoEmail = null)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            GetDatabaseName();

            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "IF OBJECT_ID('tempdb..#ReservationsByBookedDate') IS NOT NULL " +
                                "DROP TABLE #ReservationsByBookedDate; " +
                            "IF OBJECT_ID('tempdb..#CompanyAccessList') IS NOT NULL " +
                                "DROP TABLE #CompanyAccessList; ";
            if (String.IsNullOrEmpty(startDate) || String.IsNullOrEmpty(endDate))
            {
                query = query + "DECLARE @startDate DATETIME  = CONVERT(Date, GetDate()); " +
                            "DECLARE @endDate DATETIME  = CONVERT(Date, GetDate());";
            }
            else
            {
                query = query + "DECLARE @startDate DATETIME = CONVERT(DATE,GETDATE()+" + Convert.ToInt32(startDate) + "); " +
                                "DECLARE @endDate DATETIME = CONVERT(DATE,GETDATE()+" + Convert.ToInt32(endDate) + "); ";
            }
            query = query + "CREATE TABLE #ReservationsByBookedDate " +
                            "(SourceStayID         INT, " +
                                "CustomerID           INT, " +
                                "Name                 NVARCHAR(255), " +
                                "Email                NVARCHAR(255), " +
                                "PropertyName         NVARCHAR(255), " +
                                "ReservationNumber    NVARCHAR(255), " +
                                "SubReservationNumber NVARCHAR(255), " +
                                "StayStatus           NVARCHAR(255), " +
                                "ArrivalDate          NVARCHAR(255), " +
                                "DepartureDate        NVARCHAR(255), " +
                                "BookedDate           NVARCHAR(255), " +
                                "CompanyID            NVARCHAR(255), " +
                                "CancelDate           DATETIME, " +
                                "UpdatedDate          DATETIME " +
                            "); " +

                            "INSERT INTO #ReservationsByBookedDate " +
                            "EXEC dbo.metrans_GetReservationsByBookedDate " +
                                    "@startDate, " +
                                    "@endDate; " +
                            "WITH CompanyIDs " +
                                    "AS (SELECT si.value " +
                                        "FROM [APPDBSERVER]."+ dbName +".[dbo].[Users] [u] " +
                                            "CROSS APPLY utility.split_int(u.CompanyID) si " +
                                        "WHERE u.Email = '" + email + "') " +
                                    "SELECT c.CompanyName, " +
                                        "c.CompanyID " +
                                    "INTO #CompanyAccessList " +
                                    "FROM [APPDBSERVER]." + dbName + ".[dbo].[Company] [c] " +
                                        "INNER JOIN CompanyIDs v ON c.CompanyID = v.value " +
                                        "INNER JOIN [APPDBSERVER]." + dbName + ".[dbo].[Parentcompany] [p] ON c.ParentCompany = p.ID " +
                                    "WHERE p.ParentCompany = '" + companyName +"'; " +
                            "SELECT TOP 1 t.SourceStayID, " +
                                            "t.CustomerID, " +
                                            "t.Name, " +
                                            "t.Email, " +
                                            "t.PropertyName, " +
                                            "t.ReservationNumber, " +
                                            "t.SubReservationNumber, " +
                                            "t.StayStatus, " +
                                            "CONVERT(DATE, t.ArrivalDate) AS ArrivalDate, " +
                                            "CONVERT(DATE, t.DepartureDate) AS DepartureDate, " +
                                            "CONVERT(DATE, t.BookedDate) AS ResCreationDate, " +
                                            "t.CompanyID, " +
                                            "cal.CompanyName " +
                            "FROM #ReservationsByBookedDate t " +
                                    "INNER JOIN dbo.D_PROPERTY dp ON dp.PropertyName = t.PropertyName ";
            if (matchnomatch == 0)
            {
                query = query + "INNER JOIN #CompanyAccessList cal ON cal.CompanyID = dp.CenAdminCompanyID ";
            }
            else if (matchnomatch == 1)
            {
                query = query + "Left JOIN #CompanyAccessList cal ON cal.CompanyID = dp.CenAdminCompanyID ";
                //" WHERE cal.CompanyID IS null ";
            }
            if (hasNoEmail == "0")
            {
                query = query + "WHERE ISNULL(t.Email, '') = '' ";
            }
            else if (hasNoEmail == "1")
            {
                query = query + "WHERE ISNULL(t.Email, '') != '' ";
            }
            if (!String.IsNullOrEmpty(clientName) && testCategory == "QA")
            {
                query = query + "AND t.PropertyName = '"+ clientName +"' ";
            }

            query = query + "ORDER BY NEWID();";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            profData.FullName = reader["Name"].ToString();
                            profData.Email = reader["Email"].ToString();
                            profData.PropertyName = reader["PropertyName"].ToString();
                            profData.ReservationNumber = reader["ReservationNumber"].ToString();
                            profData.SubReservationNumber = reader["SubReservationNumber"].ToString();
                            profData.ReservationStatus = reader["StayStatus"].ToString();
                            profData.ArrivalDate = reader["ArrivalDate"].ToString();
                            profData.DepartureDate = reader["DepartureDate"].ToString();
                            profData.ResCreationDate = reader["ResCreationDate"].ToString();
                            profData.CustomerID = reader["CustomerID"].ToString();
                            profData.CompanyName = reader["CompanyName"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return profData;
        }

        public static string InsertCustomStay(string companyName, string startdate = null, string enddate = null)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);

            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            if (String.IsNullOrEmpty(startdate) && String.IsNullOrEmpty(enddate))
            {
                query = query + "DECLARE @ArrivalDate DATETIME = CONVERT(DATE, GETDATE()+1); " +
                "DECLARE @DepartureDate DATETIME = CONVERT(DATE, GETDATE()+1); " +
                "DECLARE @datediff INT =(SELECT DATEDIFF(DAY, @ArrivalDate, @DepartureDate)); ";
            }
            else
            {
                query = query + "DECLARE @ArrivalDate DATETIME = CONVERT(DATE, GETDATE()+" + startdate + "); " +
                "DECLARE @DepartureDate DATETIME = CONVERT(DATE, GETDATE()+ " + enddate + "); " +
                "DECLARE @datediff INT =(SELECT DATEDIFF(DAY, @ArrivalDate, @DepartureDate)); ";
            }


            query = query + "EXEC dbo._tmp_insert_d_customerstay2 @customerId = 4486536, " +
                                     "@PropertyCode = 'HOTELMILO', " +
                                     "@ReservationNumber = 'test12022020', " +
                                     "@ArrivalDate = @ArrivalDate, " +
                                     "@DepartureDate = @DepartureDate, " +
                                     "@ServerNodeID = '', " +
                                     "@SourceGuestID = '', " +
                                     "@CendynPropertyID = '1153', " +
                                     "@StayStatus = 'R', " +
                                     "@StayNights = @datediff, " +
                                     "@RoomNights = @datediff, " +
                                     "@NumAdults = 1, " +
                                     "@NumChildren = 0, " +
                                     "@TotalPersons = 0, " +
                                     "@MarketSeg = 'WHL', " +
                                     "@MarketSubSeg = 'FIT', " +
                                     "@otherRevenue = NULL, " +
                                     "@roomTypeCode = N'MM', " +
                                     "@roomRevenue = '109.00', " +
                                     "@ResCreationDate = '2020-12-02 20:03:26', " +
                                     "@SelectedLoyaltyMemberID = '', " +
                                     "@SourceofBusiness = 'IHOS', " +
                                     "@ResAgent = 'JSMITHEE', " +
                                     "@ratecode = '1', " +
                                     "@channel = ''; " +

                            "SELECT MAX(dcs.SourceStayID)SourceStayID " +
                            "FROM dbo.D_CUSTOMER_STAY dcs " +
                            "WHERE dcs.CustomerID = 4486536";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getValue = reader["SourceStayID"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return getValue;
        }

        public static string ReturnProjectJSONfromAPPDB(string companyName, string projectID)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            GetDatabaseName();
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + " SELECT ID, " +
                                " p.dynamic_criteria_json " +
                            " FROM [APPDBSERVER]."+ dbName +".[dbo].[projects][p] " +
                            " WHERE p.ID = " + projectID;
            
            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getValue = reader["dynamic_criteria_json"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return getValue;
        }

        public static void DeleteAudience(string companyName, string audienceName)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);

            query = "EXEC dbo.Delete_Audience_QAOnly " +
                    " @AudienceName = N'" + audienceName + "'; ";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
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

        public static string ReturnDataSourceID(string companyName, string dataSourceName)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);

            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + " SELECT ldsc.SourceID FROM dbo.L_DATA_SOURCE_CODE ldsc " +
                                " WHERE ldsc.SubSourceName = '" + dataSourceName + "'";
            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getValue = reader["SourceID"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return getValue;
        }

        public static CampaignDetails GetResendCampaignStatus(CampaignDetails statusDetails, string projectID, string companyName)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "IF OBJECT_ID('tempdb..#HasScheduled') IS NOT NULL " +
                                "DROP TABLE #HasScheduled; " +
                            "IF OBJECT_ID('tempdb..#HadResendSaved') IS NOT NULL " +
                                "DROP TABLE #HadResendSaved; " +

                            "DECLARE @ParentProjectId NVARCHAR(15)= '" + projectID + "'; " +
                            "DECLARE @CompanyName NVARCHAR(255)= '"+ companyName + "'; " +

                            "WITH TOPChildProjects " +
                                 "AS (SELECT TOP 1 p.ID " +
                                     "FROM dbo.projects p " +
                                     "WHERE p.ID = @ParentProjectId " +
                                     "ORDER BY p.ID DESC) " +
                                 "SELECT v3.mapProjectStatus([Status], NULL) AS OldStatus, " +
                                        "p.ID, " +
                                        "@ParentProjectId AS eContact_Campaign_ParentProjectID " +
                                 "INTO #HasScheduled " +
                                 "FROM dbo.projects p " +
                                      "INNER JOIN TOPChildProjects tpi ON tpi.ID = p.ID; " +

                            "WITH HadResendSaved " +
                                 "AS (SELECT DISTINCT " +
                                            "ss.Value " +
                                     "FROM dbo.eContact_Settings ecs " +
                                          "CROSS APPLY dbo.SplitString(ecs.SettingValue) ss " +
                                          "INNER JOIN dbo.Company c ON c.CompanyID = ecs.CompanyID " +
                                          "INNER JOIN dbo.Parentcompany p ON p.ID = c.ParentCompany " +
                                     "WHERE ecs.SettingName = 'ConfirmationProjectID' " +
                                           "AND p.ParentCompany = @CompanyName) " +
                                 "SELECT CASE " +
                                            "WHEN ISNULL(hrs.Value, '') = @ParentProjectId " +
                                            "THEN 1 " +
                                            "ELSE 0 " +
                                        "END AS ResendSaveCheck, " +
                                        "hrs.Value " +
                                 "INTO #HadResendSaved " +
                                 "FROM HadResendSaved hrs " +
                                 "WHERE hrs.Value = @ParentProjectId; " +

                            "SELECT hs.OldStatus, " +
                                   "hs.ID, " +
                                   "hs.eContact_Campaign_ParentProjectID, " +
                                   "hrs.ResendSaveCheck " +
                            "FROM #HasScheduled hs " +
                                 "LEFT JOIN #HadResendSaved hrs ON hs.eContact_Campaign_ParentProjectID = hrs.Value;";

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
                            statusDetails.OldStatus = reader["OldStatus"].ToString();
                            statusDetails.ChildCampaignID = reader["ID"].ToString();
                            statusDetails.ParentProjectID = reader["eContact_Campaign_ParentProjectID"].ToString();
                            statusDetails.ResendSaveCheck = reader["ResendSaveCheck"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return statusDetails;
        }

        public static ProfileCustData GetDataForCASL(ProfileCustData StayData, string companyName, int projectID)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; " +
                            "IF OBJECT_ID('criteria_email_result', 'U') IS NOT NULL " +
                                "DROP TABLE criteria_email_result; " +
                            "IF OBJECT_ID('GetEmailResult', 'U') IS NOT NULL " +
                                "DROP TABLE GetEmailResult; " +
                            "IF OBJECT_ID('tempdb..#CustomerRFM') IS NOT NULL " +
                                "DROP TABLE #CustomerRFM; " +
                            "IF OBJECT_ID('tempdb..#DCustomer') IS NOT NULL " +
                                "DROP TABLE #DCustomer; " +
                            "IF OBJECT_ID('tempdb..#DCustomerStay') IS NOT NULL " +
                                "DROP TABLE #DCustomerStay; " +
                            "IF OBJECT_ID('tempdb..#criteria_email_result') IS NOT NULL " +
                                "DROP TABLE #criteria_email_result; " +
                            "IF OBJECT_ID('tempdb..#lessStays') IS NOT NULL " +
                                "DROP TABLE #lessStays; " +
                            "IF OBJECT_ID('tempdb..#GPMGroupID')  IS NOT NULL " +
                                "DROP TABLE #GPMGroupID; " +
                            "IF OBJECT_ID('tempdb..#GPMCustomer')  IS NOT NULL " +
                                "DROP TABLE #GPMCustomer; " +

                            "DECLARE @querySelector VARCHAR(MAX); " +
                            "DECLARE @GetCustomerID INT; " +
                            "SET @querySelector = " +
                            "( " +
                                "SELECT CONVERT(VARCHAR(MAX), dcc.sqlPreSelect) + CHAR(10) + CONVERT(VARCHAR(MAX), dcc.sqlPostSelect) " +
                                "FROM dbo.D_CUSTOMER_CRITERIA dcc WITH(NOLOCK) " +
                                "WHERE dcc.ProjectID = " + projectID +
                            "); " +
                            "SET @querySelector = REPLACE(@querySelector, '[#criteria_email_result]', '[criteria_email_result]'); " +
                            "EXEC (@querySelector); " +
                            "SELECT r.customer_id, " +
                                   "r.stay_id, " +
                                   "r.email_id, " +
                                   "r.email_source_id " +
                            "INTO GetEmailResult " +
                            "FROM criteria_email_result r; " +
                            "DROP TABLE criteria_email_result; " +

                            "SELECT DISTINCT TOP 1 gpm.GroupID, " +
                                                  "ger.customer_id CustomerID " +
                            "INTO #GPMGroupID " +
                            "FROM dbo.Global_Profile_Mapping gpm " +
                                 "INNER JOIN dbo.GetEmailResult ger ON ger.customer_id = gpm.CustomerID " +
                                 "INNER JOIN dbo.D_CUSTOMER dc ON dc.CustomerID = gpm.CustomerID " +
                                                                 "AND dc.CountryCode = 'CA'; " +

                            "SELECT gpm.CustomerID AS PrimaryCustomer, " +
                                   "ggi.CustomerID " +
                            "INTO #GPMCustomer " +
                            "FROM dbo.Global_Profile_Mapping gpm " +
                                 "INNER JOIN #GPMGroupID ggi ON ggi.GroupID = gpm.GroupID " +
                            "WHERE gpm.GlobalRanking = 1; " +
                            "SELECT TOP 1 dc.CustomerID, " +
                                         "CASE " +
                                             "WHEN ISNULL(gc.PrimaryCustomer, 0) = 0 " +
                                             "THEN gc.CustomerID " +
                                             "ELSE gc.PrimaryCustomer " +
                                         "END AS PrimaryCustomer, " +
                                         "dc.FirstName, " +
                                         "dc.LastName, " +
                                         "dc.Email, " +
                                         "CASE " +
                                             "WHEN ISNULL(dc.CountryCode, '') = '' " +
                                             "THEN 'N/A' " +
                                             "ELSE dc.CountryCode " +
                                         "END AS CountryCode, " +
                                         "CASE " +
                                             "WHEN ISNULL(dcs.ArrivalDate, '') = '' " +
                                             "THEN 'N/A' " +
                                             "ELSE CONVERT(NVARCHAR(25), dcs.ArrivalDate, 101) " +
                                         "END AS ArrivalDate, " +
                                         "CASE " +
                                             "WHEN ISNULL(dcs.DepartureDate, '') = '' " +
                                             "THEN 'N/A' " +
                                             "ELSE CONVERT(NVARCHAR(25), dcs.DepartureDate, 101) " +
                                         "END AS DepartureDate, " +
                                         "CASE " +
                                             "WHEN ISNULL(dcs.SourceStayID, 0) = 0 " +
                                             "THEN CAST('N/A' AS NVARCHAR(10)) " +
                                             "ELSE CONVERT(NVARCHAR(25), dcs.SourceStayID) " +
                                         "END AS SourceStayID, " +
                                         "dcs.ReservationNumber " +
                            "FROM dbo.GetEmailResult ger " +
                                 "INNER JOIN dbo.D_CUSTOMER dc ON dc.CustomerID = ger.customer_id " +
                                                                 "AND dc.EmailStatus = 1 " +
                                 "INNER JOIN dbo.D_CUSTOMER_STAY dcs ON dcs.CustomerID = dc.CustomerID " +
                                                                       "AND dcs.SourceStayID = ger.stay_id " +
                                 "INNER JOIN #GPMCustomer gc ON gc.CustomerID = dc.CustomerID " +
                                 "WHERE dcs.SourceStayID = " +
                                "( " +
                                    "SELECT MAX(dcs2.SourceStayID) " +
                                    "FROM dbo.D_CUSTOMER_STAY dcs2 " +
                                    "WHERE dcs.CustomerID = dcs2.CustomerID " +
                                    "GROUP BY dcs2.CustomerID " +
                               ") ";
                            if (testCategory == "QA")
                            {
                                query = query + "AND dcs.PropertyCode IN('INDAMBROSE', 'INDEPEN', 'INDEPENDENTC'); ";
                            }


            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 120;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StayData.CustomerIDs = reader["CustomerID"].ToString();
                            StayData.PrimaryCustomer = reader["PrimaryCustomer"].ToString();
                            StayData.FirstName = reader["FirstName"].ToString();
                            StayData.LastName = reader["LastName"].ToString();
                            StayData.Email = reader["Email"].ToString();
                            StayData.CountryCode = reader["CountryCode"].ToString();
                            StayData.ArrivalDate = reader["ArrivalDate"].ToString();
                            StayData.DepartureDate = reader["DepartureDate"].ToString();
                            StayData.SourceStayID = reader["SourceStayID"].ToString();
                            StayData.ReservationNumber = reader["ReservationNumber"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return StayData;
        }

        public static string CheckDeliveredCampaign (string companyName, string Email)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);

            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = "DECLARE @Date NVARCHAR(255) =  FORMAT(DATEADD(HOUR, -1, GETDATE()), 'hh:mm:ss') " +
                    "DECLARE @CheckifExist INT =  (SELECT COUNT(1) " +
                    "FROM dbo.SM_REPORT_DELIVERED srd " +
                    "WHERE srd.Email = '" + Email + "' " +
                            "AND CONVERT(DATE, srd.DeliveredDate) = CONVERT(DATE, GETDATE()) " +
                            "AND CONVERT(TIME, srd.DeliveredDate) > @Date); " +

                    "IF ISNULL(@CheckifExist, 0) = 0 " +

                    "SELECT 'Email was not sent' AS Result " +

                    "ELSE IF @CheckifExist > 0 " +

                    "SELECT 'Email sent' AS Result ";


            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 120;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getValue = reader["Result"].ToString();                            
                        }
                    }
                }
                connection.Close();
            }
            return getValue;
        }

        public static CampaignReportDetails GetTransactional_Report(CampaignReportDetails reportdata, string companyName)
        {
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(companyName, Connstr);
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "IF OBJECT_ID('tempdb..#summary') IS NOT NULL " +
                        "DROP TABLE #summary; " +
                    "DECLARE @startDate DATE= DATEADD(Month, -1, CONVERT(DATE, GETDATE())); " +
                    "DECLARE @endDate DATE= CONVERT(DATE, GETDATE()); " +
                    "DECLARE @companyId INT= " +
                    "( " +
                        "SELECT TOP 1 ec.CompanyID " +
                        "FROM dbo.ECONTACT_CAMPAIGNNAME ec " +
                        "WHERE ec.InsertDate >= @startDate " +
                              "AND ec.InsertDate <= @endDate " +
                              "AND ec.IsTransactional = 1 " +
                        "ORDER BY ec.InsertDate DESC " +
                    "); " +
                    "SELECT this.ID AS Id, " +
                           "this.CustomerId, " +
                           "this.ProjectId, " +
                           "this.Email, " +
                           "this.InsertDate, " +
                           "CASE " +
                               "WHEN SMRD.DeliveredDate IS NULL " +
                               "THEN '' " +
                               "ELSE 'Yes' " +
                           "END AS Delivered, " +
                           "0 AS isResend, " +
                           "campaign.CampaignName AS ProjectName, " +
                           "campaign.CampaignSubject AS ProjectSubject, " +
                           "ISNULL(this.SourceStayID, 0) AS SourceStayID, " +
                           "campaign.CompanyID " +
                    "INTO #summary " +
                    "FROM eInsight_Dynamic_Customer_Extract_StrongMail AS this WITH(NOLOCK) " +
                         "JOIN ECONTACT_CAMPAIGNNAME AS campaign WITH(NOLOCK) ON campaign.ProjectID = this.ProjectID " +
                         "LEFT JOIN SM_REPORT_DELIVERED AS SMRD WITH(NOLOCK) ON SMRD.ChildProjectID = this.ProjectID " +
                                                                               "AND SMRD.Email = this.Email " +
                    "WHERE this.InsertDate >= @startDate " +
                          "AND this.InsertDate <= @endDate " +
                          "AND this.CustomerExtractStatusID = 1 " +
                          "AND campaign.IsTransactional = 1 " +
                          "AND campaign.companyId = @companyId " +
                          "AND this.id NOT IN " +
                    "( " +
                        "SELECT this.ID " +
                        "FROM eInsight_Dynamic_Customer_Extract_StrongMail AS this WITH(NOLOCK) " +
                             "JOIN ECONTACT_CAMPAIGNNAME AS campaign WITH(NOLOCK) ON campaign.ProjectID = this.ProjectID " +
                        "WHERE this.InsertDate >= @startDate " +
                              "AND this.InsertDate <= @endDate " +
                              "AND this.CustomerExtractStatusID = 1 " +
                              "AND campaign.IsTransactional = 1 " +
                              "AND campaign.companyId = @companyId " +
                              "AND campaign.TransactionalEmailVersion = 'v2' " +
                    ") " +
                    "UNION ALL " +
                    "SELECT this.ID AS Id, " +
                           "this.CustomerId, " +
                           "this.ProjectId, " +
                           "this.Email, " +
                           "this.InsertDate, " +
                           "CASE " +
                               "WHEN EXISTS " +
                    "( " +
                        "SELECT COUNT(1) " +
                        "FROM sm_report_delivered " +
                        "WHERE ChildProjectID = this.ProjectID " +
                              "AND email = this.email " +
                              "AND CAST(delivereddate AS DATE) = CAST(this.insertdate AS DATE) " +
                    ") " +
                               "THEN 'Yes' " +
                               "ELSE '' " +
                           "END AS Delivered, " +
                           "0 AS isResend, " +
                           "campaign.CampaignName AS ProjectName, " +
                           "campaign.CampaignSubject AS ProjectSubject, " +
                           "ISNULL(this.SourceStayID, 0) AS SourceStayID, " +
                           "campaign.CompanyID " +
                    "FROM eInsight_Dynamic_Customer_Extract_StrongMail AS this WITH(NOLOCK) " +
                         "JOIN ECONTACT_CAMPAIGNNAME AS campaign WITH(NOLOCK) ON campaign.ProjectID = this.ProjectID " +
                    "WHERE this.InsertDate >= @startDate " +
                          "AND this.InsertDate <= @endDate " +
                          "AND this.CustomerExtractStatusID = 1 " +
                          "AND campaign.IsTransactional = 1 " +
                          "AND campaign.companyId = @companyId " +
                          "AND campaign.TransactionalEmailVersion = 'v2' " +
                    "UNION ALL " +
                    "SELECT this.MessageId AS Id, " +
                           "this.CustomerId, " +
                           "this.ProjectId, " +
                           "this.Email, " +
                           "this.InsertDate, " +
                           "CASE " +
                               "WHEN SMRD.DeliveredDate IS NULL " +
                               "THEN '' " +
                               "ELSE 'Yes' " +
                           "END AS Delivered, " +
                           "1 AS isResend, " +
                           "campaign.CampaignName AS ProjectName, " +
                           "campaign.CampaignSubject AS ProjectSubject, " +
                           "ISNULL(SourceStayID, 0) AS SourceStayID, " +
                           "campaign.CompanyID " +
                    "FROM eInsight_Dynamic_Resend_Message_Extract AS this WITH(NOLOCK) " +
                         "JOIN ECONTACT_CAMPAIGNNAME AS campaign WITH(NOLOCK) ON campaign.ID = " +
                    "( " +
                        "SELECT TOP 1 ID " +
                        "FROM ECONTACT_CAMPAIGNNAME WITH(NOLOCK) " +
                        "WHERE ParentProjectID = this.ProjectID " +
                              "AND IsTransactional = 1 " +
                              "AND CompanyID = @companyId " +
                        "ORDER BY ID DESC " +
                    ") " +
                         "LEFT JOIN SM_REPORT_DELIVERED AS SMRD WITH(NOLOCK) ON SMRD.ChildProjectID = this.ProjectID " +
                                                                               "AND SMRD.Email = this.Email " +
                    "WHERE this.InsertDate >= @startDate " +
                          "AND this.InsertDate <= @endDate OPTION(RECOMPILE); " +
                    "WITH result " +
                         "AS (SELECT this.*, " +
                                    "dcs.firstname AS firstname, " +
                                    "dcs.lastname AS lastname, " +
                                    "dcs.reservationnumber AS ReservationNumber " +
                             "FROM #summary AS this " +
                                  "INNER JOIN newtransactionemailextractmapping dcs WITH(NOLOCK) ON this.id = dcs.extractid " +
                             "WHERE this.CustomerID = 0 " +
                                   "AND this.SourceStayID = 0 " +
                             "UNION " +
                             "SELECT this.*, " +
                                    "customer.firstname, " +
                                    "customer.lastname, " +
                                    "dcs.ReservationNumber " +
                             "FROM #summary AS this " +
                                  "INNER JOIN customer WITH(NOLOCK) ON this.customerid = customer.customerid " +
                                  "LEFT JOIN dbo.d_customer_stay dcs WITH(NOLOCK) ON dcs.customerid = this.customerid " +
                                                                                    "AND dcs.sourcestayid = this.sourcestayid) " +
                         "SELECT TOP 1 r.ReservationNumber, " +
                                      "r.Email, " +
                                      "CONVERT(DATE, r.InsertDate) SentDate, " +
                                      "r.ProjectName, " +
                                      "r.ProjectSubject, " +
                                      "r.CompanyID " +
                         "FROM result r " +
                              "INNER JOIN dbo.D_PROPERTY dp ON r.companyID = dp.CenAdminCompanyID " +
                         "ORDER BY InsertDate DESC;";

            using (var connection = new SqlConnection(Connstr.ConnectonString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 120;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reportdata.ReservationNumber = reader["ReservationNumber"].ToString();
                            reportdata.Email = reader["Email"].ToString();
                            reportdata.SendDate = reader["SentDate"].ToString();
                            reportdata.CampaignName = reader["ProjectName"].ToString();
                            reportdata.CampaignSubject = reader["ProjectSubject"].ToString();
                            reportdata.CompanyID = reader["CompanyID"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return reportdata;
        }

        public static string GetCompanyName (string companyID)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "SELECT c.CompanyName " +
                            "FROM dbo.Company c " +
                            "WHERE c.CompanyID = " + companyID;

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
                            getValue = reader["CompanyName"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return getValue;
        }

        public static CampaignDetails GetCampaignDetails_Report(CampaignDetails campData, string companyName, string projectStatus, int isTransactional, int isScheduleActive, string projectID = null)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "SELECT TOP 1 ProjectID, " +
                                   "[Status], " +
                                   "CONVERT(DATE, approveddate) ApprovedDate, " +
                                   "CONVERT(DATE, DateStart) DateStart " +
                            "FROM ManageCampaigns_GetProjects gp " +
                            "INNER JOIN dbo.Company c ON c.CompanyID = gp.CompanyID " +
                            "INNER JOIN dbo.Parentcompany p ON p.ID = c.ParentCompany ";
                            if (String.IsNullOrEmpty(projectID))
                            {
                                query = query + "WHERE Status = '" + projectStatus + "' " +
                                                "AND IsTransactional = " + isTransactional + " ";
                                if(projectStatus != "Approved")
                                {
                                    query = query + "AND gp.ScheduleActive = " + isScheduleActive + " ";
                                }

                                query = query + "AND c.CompanyName = '" + companyName + "' " +
                                                "ORDER BY ProjectID Desc";
                            }
                            else if (!String.IsNullOrEmpty(projectID))
                            {
                                query = query + "WHERE gp.ProjectID = " + Convert.ToInt32(projectID);
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
                            campData.ParentProjectID = reader["ProjectID"].ToString();
                            campData.OldStatus = reader["Status"].ToString();
                            campData.RequestDate = reader["ApprovedDate"].ToString();
                            campData.DateSubmitted = reader["DateStart"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return campData;
        }
        public static CampaignDetails GetProjectEvents(CampaignDetails campData, string companyName, string projectID)
        {
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "SELECT TOP 1 " +
                                   "pe.ProjectId, " +
                                   "c.CompanyName, " +
                                   "pe.EventType, " +
                                   "CONVERT(DATE, pe.[On])[On], " +
                                   "pe.[By] " +
                            "FROM ProjectEvent pe WITH(NOLOCK) " +
                            "INNER JOIN dbo.Company c ON c.CompanyID = pe.companyid " +
                            "WHERE ProjectId = " + projectID +
                            " ORDER BY [On] DESC;";
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
                            campData.ParentProjectID = reader["ProjectID"].ToString();
                            campData.CompanyName = reader["CompanyName"].ToString();
                            campData.EventType = reader["EventType"].ToString();
                            campData.ModifiedOn = reader["On"].ToString();
                            campData.by = reader["By"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return campData;
        }
        public static TemplateEditor GetTemplareDetails(TemplateEditor templateData)
        {
            GetDatabaseName();
            query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ";
            query = query + "SELECT TOP 1 t.Name, " +
                                         "t.UpdateDate " +
                            "FROM " + templateDB + ".[dbo].[Template] t " +
                            "WHERE t.Active = 1 " +
                                  "AND t.Deleted = 0 " +
                            "ORDER BY t.Id;";
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
                            templateData.templateName = reader["Name"].ToString();
                            templateData.UpdateDate = reader["UpdateDate"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return templateData;
        }
    }
}

