using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace eInsight.Utility
{
    public class LegacyTestData : Setup
    {
        //Assign the XML value to a string

        #region[Common]

        public static string CommonBrowserType { get; set; }
        public static string CommonAdminURL { get; set; }
        public static string CommonFrontendURL { get; set; }

        public static string CommonFrontendProdURL { get; set; }
        public static string CommonFrontendEmail { get; set; }
        public static string CommonFrontendPassword { get; set; }
        public static string CommonCatchallURL  { get; set; }
        public static string CommonCatchallUserName  { get; set; }
        public static string CommonCatchallPassword  { get; set; }
        public static string CommonAutomationPassword { get; set; }
        public static string CommonFrontendEU01URL { get; set; }
        public static string CommonFrontendEU02URL { get; set; }

        public static string LambdaUserName { get; set; }
        public static string LambdaAccessKey { get; set; }
        public static string LambdaHub { get; set; }
        public static string LambdaBuild { get; set; }
        public static string LambdaTunnel { get; set; }
        public static string LambdaExecution { get; set; }
        #endregion[/Common]

        /// <summary>
        /// This method will assign all string values from the test xml file.
        /// </summary>
        /// <param name=testCase>Test Case ID</param>
        public static LegacyTestData ReadData(string testCase)
        {
            LegacyTestData obj = new LegacyTestData();
            XDocument doc = XDocument.Load(TestDataFile);
            var query = doc.Descendants(testCase).Elements()
                .ToDictionary(x => x.Attribute("key").Value,
                    x => x.Value);

            foreach (KeyValuePair<string, string> pair in query)
            {
                #region[Common]

                if (testCase == Constants.ModuleCommon)
                {
                    if (pair.Key == "CommonBrowserType")
                    {
                        CommonBrowserType = pair.Value;
                    }
                    else if (pair.Key == "CommonAdminURL")
                    {
                        CommonAdminURL = pair.Value;
                    }
                    else if (pair.Key == "CommonFrontendURL")
                    {
                        CommonFrontendURL = pair.Value;
                    }
                    else if (pair.Key == "CommonFrontendProdURL")
                    {
                        CommonFrontendProdURL = pair.Value;
                    }
                    else if (pair.Key == "CommonFrontendEmail")
                    {
                        CommonFrontendEmail = pair.Value;
                    }
                    else if (pair.Key == "CommonFrontendPassword")
                    {
                        CommonFrontendPassword = pair.Value;
                    }
                    else if (pair.Key == "CommonCatchallURL")
                    {
                        CommonCatchallURL = pair.Value;
                    }
                    else if (pair.Key == "CommonCatchallUserName")
                    {
                        CommonCatchallUserName = pair.Value;
                    }
                    else if (pair.Key == "CommonCatchallPassword")
                    {
                        CommonCatchallPassword = pair.Value;
                    }
                    else if (pair.Key == "CommonAutomationPassword")
                    {
                        CommonAutomationPassword = pair.Value;
                    }
                    else if (pair.Key == "LambdaUserName")
                    {
                        LambdaUserName = "msridhar";//pair.Value;
                    }
                    else if (pair.Key == "LambdaAccessKey")
                    {
                        LambdaAccessKey = "vYvjGSXb6gmVhlTwqxHRVs4TaKE4roDJfUfkwqiIVfonRlO59x";//pair.Value;
                    }
                    else if (pair.Key == "LambdaHub")
                    {
                        LambdaHub = "https://msridhar:vYvjGSXb6gmVhlTwqxHRVs4TaKE4roDJfUfkwqiIVfonRlO59x@hub.lambdatest.com/wd/hub"; //pair.Value;
                    }
                    else if (pair.Key == "LambdaBuild")
                    {
                        LambdaBuild = pair.Value;
                    }
                    else if (pair.Key == "LambdaTunnel")
                    {
                        LambdaTunnel = pair.Value;
                    }
                    else if (pair.Key == "LambdaExecution")
                    {
                        LambdaExecution = pair.Value;
                    }else if (pair.Key == "CommonFrontendEU01URL")
                    {
                        CommonFrontendEU01URL = pair.Value;
                    }else if (pair.Key == "CommonFrontendEU02URL")
                    {
                        CommonFrontendEU02URL = pair.Value;
                    }
                }
                #endregion[Common]                
            }
            return obj;
        }


    }
}