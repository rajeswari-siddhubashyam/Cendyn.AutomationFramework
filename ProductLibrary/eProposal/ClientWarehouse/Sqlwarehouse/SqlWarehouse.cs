using System;
using BaseUtility.Utility;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;
using System.Xml;
using Newtonsoft.Json.Linq;

namespace SqlWarehouse
{
    public class SqlWarehouseQuery : Helper
    {
        private static string query = "";
        private static string columnName = "";
        public static string companyName = "";
        public static string getValue = "";

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
                  "AND tdtqo.IsEnable = 1 " +
                  "AND tdtqo.KeyName = '" + keyName + "';";

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

       

    }
}

