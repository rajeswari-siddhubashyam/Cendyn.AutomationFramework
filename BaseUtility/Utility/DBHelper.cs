using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseUtility.Utility
{
    public class DBHelper : Helper
    {
        private static SqlConnection con;
        private static SqlCommand cmd;
        private static SqlDataAdapter dataAdapter;
        private static DataTable dataTable;
        private static string Result;

        public static SqlConnection SqlConn()
        {
            if (testCategory == "PostDeployment")
            {
                con = new SqlConnection(ConnectionString3);
            }
            else if (testCategory == "POC")
            {
                con = new SqlConnection(ConnectionString4);
            }
            else if (testCategory == "EU02_PostDeployment")
            {
                con = new SqlConnection(ConnectionString5);
            }
            else if (testCategory == "QA")
            {
                con = new SqlConnection(ConnectionString);
            }
            else 
            {
                con = new SqlConnection(ConnectionString);
            }
            return con;
        }
        public static SqlConnection SqlConn2()
        {
            con = new SqlConnection(ConnectionString2);
            return con;
        }
        public static SqlConnection SqlConn3()
        {
            con = new SqlConnection(ConnectionString3);
            return con;
        }
        public static SqlConnection PromptsDB()
            {
            con = new SqlConnection(ConnectionStringVar);
            return con;
        }

        public static void OpenDB()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }

        /// <summary>
        /// This method will close the DB connection.
        /// </summary>
        public static void CloseDB()
        {
            con.Close();
        }

        /// <summary>
        /// This method will execute the query fill the database.
        /// </summary>
        /// <param name="query"></param>
        private static void ExecuteQueryAndFillTable(string query)
        {
            cmd = new SqlCommand(query);
            cmd.Connection = con;
            dataAdapter = new SqlDataAdapter(cmd);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
        }

        /// <summary>
        /// This method will execute the query and fill and return the first result.
        /// </summary>
        /// <param name="query">Query to execute</param>
        /// <returns></returns>
        public static string ExecuteQueryAndReturnColumn(string query, string column)
        {
            DBHelper.OpenDB();
            ExecuteQueryAndFillTable(query);
            if (dataTable.Rows.Count > 0)
            {
                Result = dataTable.Rows[0][column].ToString();
            }
            else
            {
                Result = null;
            }
            DBHelper.CloseDB();
            return Result;
        }

        /// <summary>
        /// This method will execute the query and fill and return the second result.
        /// </summary>
        /// <param name="query">Query to execute</param>
        /// <returns></returns>
        public static string ExecuteQueryAndReturnColumnNextRow(string query, string column, int row)
        {
            ExecuteQueryAndFillTable(query);
            Result = dataTable.Rows[row][column].ToString();
            return Result;
        }

        /// <summary>
        /// This method will return the first value in the desired column from the filled table.
        /// </summary>
        /// <param name="column">Field to obtain data from</param>
        /// <returns></returns>
        public static string GetDataFromColumn(string column)
        {
            Result = dataTable.Rows[0][column].ToString();
            return Result;
        }
    }
}
