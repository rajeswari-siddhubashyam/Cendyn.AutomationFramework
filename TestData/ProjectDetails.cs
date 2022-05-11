using System.Linq;
using System.Collections.Generic;
using Common;

namespace TestData
{
    public class ProjectDetails //: Setup
    {
        //Assign the XML value to a string    

        #region[Common]
        public static string CommonFrontendURL { get; set; }
        public static string CommonAdminURL { get; set; }
        public static string CommonFrontendEmail { get; set; }
        public static string CommonFrontendPassword { get; set; }
        public static string CommonAdminEmail { get; set; }
        public static string CommonAdminPassword { get; set; }
        public static string CommonKioskSignUpURL { get; set; }
        public static string CommonGmail { get; set; }
    

        #endregion[Common]

        /* SignIn Validation */
        public static ProjectDetails ReadDataExcel(Dictionary<string, string> TestData_KeyValuePair, string testCase)
        {
            ProjectDetails obj = new ProjectDetails();
            var query = TestData_KeyValuePair.ToDictionary(x => x.Key, x => x.Value);
            foreach (KeyValuePair<string, string> pair in query)
            {
                if (testCase == Constants.ModuleCommon)
                {
                    if (pair.Key == "CommonAdminURL")
                    {
                        CommonAdminURL = pair.Value;
                    }
                    else if (pair.Key == "CommonFrontendURL")
                    {
                        CommonFrontendURL = pair.Value;
                    }
                    else if (pair.Key == "CommonFrontendEmail")
                    {
                        CommonFrontendEmail = pair.Value;
                    }
                    else if (pair.Key == "CommonFrontendPassword")
                    {
                        CommonFrontendPassword = pair.Value;
                    }
                    else if (pair.Key == "CommonAdminPassword")
                    {
                        CommonAdminPassword = pair.Value;
                    }
                    else if (pair.Key == "CommonKioskSignUpURL")
                    {
                        CommonKioskSignUpURL = pair.Value;
                    }
                    else if (pair.Key == "CommonAdminEmail")
                    {
                        CommonAdminEmail = pair.Value;
                    }
                    else if (pair.Key == "CommonGmail")
                    {
                        CommonGmail = pair.Value;
                    }
                }
            }
            return obj;
        }
    }
}
