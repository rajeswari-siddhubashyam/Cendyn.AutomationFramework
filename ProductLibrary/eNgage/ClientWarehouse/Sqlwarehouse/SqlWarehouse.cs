using System;
using BaseUtility.Utility;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;
using System.Xml;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using eNgage.Utility;

namespace SqlWarehouse
{
    public class SqlWarehouseQuery : Helper
    {
        private static string query = "";
        private static string columnName = "";
        private static string value = "";

        private static ClientdbConnection GetClientdbConnection(string CompanyName, ClientdbConnection strConn)
        {
            Regex regex = new Regex(@"^\S*");
            Match match = regex.Match(CompanyName);

            query = "SELECT cc.CRM_Server, " +
                           "cc.CRM_Database, " +
                           "cc.CRM_User, " +
                           "cc.CRM_Password, " +
                           "cc.ConnectonString " +
                    "FROM dbo.V_ClientdbConnections cc " +
                    "WHERE cc.CRM_Database LIKE '%" + match.Value + "%';";
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
            query = "SELECT DISTINCT " +
                           "p2.ParentCompany, " +
                           "c.CompanyName " +
                    "FROM dbo.projects p WITH (NOLOCK) " +
                         "INNER JOIN dbo.Company c WITH (NOLOCK) ON p.CompanyID = c.CompanyID " +
                         "INNER JOIN dbo.Parentcompany p2 WITH (NOLOCK) ON p2.ID = c.ParentCompany " +
                    "WHERE p.eContact_Campaign_ParentProjectID = " + ProjectID;

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
                            strvar.ParentCompanyName = reader["ParentCompany"].ToString();
                            strvar.CompanyName = reader["CompanyName"].ToString();
                        }
                    }
                }
                connection.Close();
                return strvar;
            }
        }

        // Get few first names from Client QA DB for Search
        public static IList<String> GetFirstNameList(string CompanyName)
        {
            IList<String> FirstNames = new List<String>();
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(CompanyName, Connstr);
            query = "select top(25) FirstName from D_customer with(nolock) " +
                    "where firstname is not null " +
                    "and lastname is not null " +
                    "and RecordStatus = 1 " +
                    "and address1 is not null " +
                    "and CountryCode = 'US'";

            string name = "";
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
                            name = reader["FirstName"].ToString();
                            FirstNames.Add(name);
                        }
                    }
                }
                connection.Close();
            }
            return FirstNames;
        }
        // Get few Reservation IDs from Client QA DB for Search
        public static IList<String> GetReservationIds(string CompanyName)
        {
            IList<String> ReservationID = new List<String>();
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(CompanyName, Connstr);
            query = "select top(25) ReservationNumber from D_customer_stay with(nolock) " +
                    "where StayStatus = 'O' ";
            //"ORDER BY DepartureDate desc";

            string name = "";
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
                            name = reader["ReservationNumber"].ToString();
                            ReservationID.Add(name);
                        }
                    }
                }
                connection.Close();
            }
            return ReservationID;
        }
        // Get few Email IDs from Client QA DB for Search
        public static IList<String> GetEmailList(string CompanyName)
        {
            IList<String> EmailList = new List<String>();
            ClientdbConnection Connstr = new ClientdbConnection();
            GetClientdbConnection(CompanyName, Connstr);
            query = "select top(25) email from D_customer with(nolock) " +
                    "where email is not NULL " +
                    "and FirstName is not NULL " +
                    "and LastName is not NULL " +
                    "and RecordStatus = 1 ";

            string name = "";
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
                            name = reader["email"].ToString();
                            EmailList.Add(name);
                        }
                    }
                }
                connection.Close();
            }
            return EmailList;
        }
        public static Dictionary<string, string> GetPromptResponses(string projectName)
        {
            string LoginUsername = (LegacyTestData.FrontEndURL == null) ? LegacyTestData.CommonFrontendEmail : LegacyTestData.FrontEndEmail;
            Dictionary<string, string> response = new Dictionary<string, string>();
            query = "SELECT top(1) * FROM Responses with (nolock)" +
                    "WHERE SSOUserId = '" + LoginUsername + "' " +
                    "AND CAST(LastUpdated AS DATE)= CAST(GETDATE() AS DATE) " +
                    "ORDER BY LastUpdated desc";

            using (SqlConnection connection = DBHelper.PromptsDB())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            response.Add(reader["SourceProfileID"].ToString(), reader["Reaction"].ToString());
                        }
                    }
                }
                connection.Close();
                return response;
            }
        }
        public static List<PromptsRules> GetPromptRules()
        {
            List<PromptsRules> pr = new List<PromptsRules>();

            //string LoginUsername = (TestData.FrontEndURL == null) ? TestData.CommonFrontendEmail : TestData.FrontEndEmail;
            //Dictionary<string, string> response = new Dictionary<string, string>();
            query = "select g.HotelName, g.Category, g.CendynPropertyId, " +
                    "rs.Name AS 'RuleSetName', rs.Priority as 'RuleSetPriority', rs.Active as RuleSetActive, " +
                    "p.Text AS 'PromptText', p.DisplayType,  " +
                    "r.Name AS 'RuleName', r.ParseTree, r.Priority as 'RulePriority', r.Active as RuleActive " +
                    "from Rules r " +
                    "join Prompts p on r.FK_Prompt = p.PK_Prompt " +
                    "join RuleSets rs on r.FK_RuleSet = rs.PK_RuleSet " +
                    "join Groups g on g.PK_Group = rs.FK_Group " +
                    "WHERE rs.Active = 1 " +
                    "AND r.Active = 1";

            using (SqlConnection connection = DBHelper.PromptsDB())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PromptsRules p = new PromptsRules();
                            p.HotelName = reader["HotelName"].ToString();
                            p.Category = reader["Category"].ToString();
                            p.CendynPropertyID = reader["CendynPropertyID"].ToString();
                            p.RuleSetName = reader["RuleSetName"].ToString();
                            p.RuleSetPriority = reader["RuleSetPriority"].ToString();
                            p.RuleSetActive = reader["RuleSetActive"].ToString();
                            p.PromptText = reader["PromptText"].ToString();
                            p.DisplayType = reader["DisplayType"].ToString();
                            p.RuleName = reader["RuleName"].ToString();
                            p.ParseTree = reader["ParseTree"].ToString();
                            p.RulePriority = reader["RulePriority"].ToString();
                            p.RuleActive = reader["RuleActive"].ToString();

                            pr.Add(p);
                        }
                    }
                }
                connection.Close();
                return pr;
            }
        }
        public static PromptsResponses GetPromptSavedResponse(string projectName, string profileID)
        {
            PromptsResponses r = new PromptsResponses();
            string LoginUsername = (LegacyTestData.FrontEndURL == null) ? LegacyTestData.CommonFrontendEmail : LegacyTestData.FrontEndEmail;
            Dictionary<string, string> response = new Dictionary<string, string>();
            query = "SELECT top(1) * FROM Responses with (nolock)" +
                    "WHERE SSOUserId = '" + LoginUsername + "' " +
                    "AND SourceProfileID ='" + profileID + "' " +
                    "AND CAST(LastUpdated AS DATE)= CAST(GETDATE() AS DATE) " +
                    "ORDER BY LastUpdated desc";

                        using (SqlConnection connection = DBHelper.PromptsDB())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            r.PromptText = reader["PromptText"].ToString();
                            r.CendynProfileID = reader["CendynProfileID"].ToString();
                            r.SourceProfileID = reader["SourceProfileID"].ToString();
                            r.Reaction = reader["Reaction"].ToString();
                            r.Response = reader["Response"].ToString();
                            r.DateCreated = reader["DateCreated"].ToString();
                            r.LastUpdated = reader["LastUpdated"].ToString();
                            r.SSOUserID = reader["SSOUserID"].ToString();
                        }
                    }
                }
                connection.Close();
                return r;
            }
        }
        public static string ReturnGetTestDataValue(string caseID, string keyName, string planID = null)
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
                query = query + "AND tdtqo.KeyName = Prod_'" + keyName + "'";
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
                            value = reader["KeyValue"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            return value;
        }


    }
}

