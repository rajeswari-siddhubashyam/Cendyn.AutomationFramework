using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BaseUtility.Utility
{
    public class TestDataLocation //: Setup
    {
        //Test Plan Test Data File Locations
        public static string RootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);        
        public static string CommonTestData = String.Concat(RootPath, ConfigurationManager.AppSettings["CommonTestData"]);
        public static string TestData = String.Concat(RootPath, ConfigurationManager.AppSettings["TestData"]);
        public static string POCExcel = String.Concat(RootPath, ConfigurationManager.AppSettings["POCExcel"]);
        //public static string CommonTestData = String.Concat(RootPath, ConfigurationManager.AppSettings["CommonTestData"]);

        public static string TP_243105 = String.Concat(RootPath, ConfigurationManager.AppSettings["TP_243105"]);
        public static string TP_243876 = String.Concat(RootPath, ConfigurationManager.AppSettings["TP_243876"]);
        public static string TP_159979 = String.Concat(RootPath, ConfigurationManager.AppSettings["TP_159979"]);
        public static string TP_243163 = String.Concat(RootPath, ConfigurationManager.AppSettings["TP_243163"]);
        public static string TP_160101 = String.Concat(RootPath, ConfigurationManager.AppSettings["TP_160101"]);
        public static string TP_243159 = String.Concat(RootPath, ConfigurationManager.AppSettings["TP_243159"]);
        public static string TP_244114 = String.Concat(RootPath, ConfigurationManager.AppSettings["TP_244114"]);
        public static string TP_242772 = String.Concat(RootPath, ConfigurationManager.AppSettings["TP_242772"]);
    }
}
