using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace eNgage.Utility
{
    public class LegacyTestData : Setup
    {
        //Assign the XML value to a string

        #region[Common]

        public static string CommonBrowserType { get; set; }
        public static string CommonAdminURL { get; set; }
        public static string CommonFrontendURL { get; set; }
        public static string CommonFrontendEmail { get; set; }
        public static string CommonFrontendPassword { get; set; }
        public static string CommonCatchallURL { get; set; }
        public static string CommonCatchallUserName { get; set; }
        public static string CommonCatchallPassword { get; set; }
        public static string CommonAutomationPassword { get; set; }
        public static string FrontEndEmail { get; set; }
        public static string FrontEndPassword { get; set; }
        public static string ClientName { get; set; }
        public static string FrontEndURL { get; set; }

        public static string LambdaUserName { get; set; }
        public static string LambdaAccessKey { get; set; }
        public static string LambdaHub { get; set; }
        public static string LambdaBuild { get; set; }
        public static string LambdaTunnel { get; set; }
        public static string LambdaExecution { get; set; }

        #endregion[/Common]

        #region[TP_160101]
        #region[TC_160144]
        public static string TC_160144_Search_FirstName { get; set; }
        public static string TC_160144_Search_LastName { get; set; }
        #endregion[TC_160144]
        #region[TC_160143]
        public static string TC_160143_Search_ProfileID { get; set; }
        #endregion[TC_160143]
        #region[TC_160147]
        public static string TC_160147_Search_Email { get; set; }
        public static string TC_160147_Search_FirstName { get; set; }
        public static string TC_160147_Search_LastName { get; set; }
        #endregion[TC_160147]
        #region[TC_160149]
        public static string TC_160149_Search_MemberID { get; set; }
        public static string TC_160149_Search_ProfileID { get; set; }
        #endregion[TC_160149]
        #region[TC_243421]
        public static string TC_243421_Search_ReservationID { get; set; }
        public static string TC_243421_Search_ProfileID { get; set; }
        #endregion[TC_243421]
        #region[TC_160146]
        public static string TC_160146_Search_Phone { get; set; }
        public static string TC_160146_Search_FirstName { get; set; }
        public static string TC_160146_Search_LastName { get; set; }
        #endregion[TC_160146]
        #region[TC_243411]
        public static string TC_243411_Search_ReservationID { get; set; }
        #endregion[TC_243411]
        #region[TC_243423]
        public static string TC_243423_Search_Zip { get; set; }
        public static string TC_243423_Search_FirstName { get; set; }
        public static string TC_243423_Search_LastName { get; set; }
        #endregion[TC_243423]
        #region[TC_160193]
        public static string TC_160193_Search_ReservationID { get; set; }
        public static string TC_160193_Search_ProfileID { get; set; }
        public static string TC_160193_Search_MemberID { get; set; }
        public static string TC_160193_Search_FirstName { get; set; }
        public static string TC_160193_Search_LastName { get; set; }
        public static string TC_160193_Search_Email { get; set; }
        public static string TC_160193_Search_Phone { get; set; }
        #endregion[TC_160193]
        #endregion[TP_160101]

        #region[TC_243197]
        public static string TC_243197_Search_FirstName { get; set; }
        public static string TC_243197_Search_LastName { get; set; }
        public static string TC_243197_Search_ProfileID { get; set; }
        #endregion[TC_243197]

        #region[TP_242772]
        #region[TC_243245]
        public static string TC_243245_Search_FirstName { get; set; }
        public static string TC_243245_Search_LastName { get; set; }
        public static string TC_243245_Search_ProfileID { get; set; }
        #endregion[TC_243245]
        #region[TC_242784]
        public static string TC_242784_Search_FirstName { get; set; }
        public static string TC_242784_Search_LastName { get; set; }
        public static string TC_242784_Search_ProfileID { get; set; }
        #endregion[TC_242784]
        #region[TC_242805]
        public static string TC_242805_Search_FirstName { get; set; }
        public static string TC_242805_Search_LastName { get; set; }
        public static string TC_242805_Search_ProfileID { get; set; }
        #endregion[TC_242805]
        #region[TC_242789]
        public static string TC_242789_Search_FirstName { get; set; }
        public static string TC_242789_Search_LastName { get; set; }
        public static string TC_242789_Search_ProfileID { get; set; }
        #endregion[TC_242789]
        #region[TC_242812]
        public static string TC_242812_Search_FirstName { get; set; }
        public static string TC_242812_Search_LastName { get; set; }
        public static string TC_242812_Search_ProfileID { get; set; }
        public static string TC_242812_Test_Email { get; set; }
        #endregion[TC_242812]

        #endregion[TP_242772]
        

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
                    else if (pair.Key == "FrontEndEmail")
                    {
                        FrontEndEmail = pair.Value;
                    }
                    else if (pair.Key == "FrontEndPassword")
                    {
                        FrontEndPassword = pair.Value;
                    }
                    else if (pair.Key == "ClientName")
                    {
                        ClientName = pair.Value;
                    }
                    else if (pair.Key == "FrontEndURL")
                    {
                        FrontEndURL = pair.Value;
                    }
                    else if (pair.Key == "LambdaUserName")
                    {
                        LambdaUserName = pair.Value;
                    }
                    else if (pair.Key == "LambdaAccessKey")
                    {
                        LambdaAccessKey = pair.Value;
                    }
                    else if (pair.Key == "LambdaHub")
                    {
                        LambdaHub = pair.Value;
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
                    }
                }
                #endregion[Common]
                #region[TP_243105]
                if (TestCaseId == Constants.TC_243109)
                {

                }
                if (TestCaseId == Constants.TC_243110)
                {

                }
                if (TestCaseId == Constants.TC_243112)
                {

                }
                if (TestCaseId == Constants.TC_243113)
                {

                }
                if (TestCaseId == Constants.TC_243114)
                {

                }
                if (TestCaseId == Constants.TC_243118)
                {

                }
                if (TestCaseId == Constants.TC_243608)
                {

                }
                if (TestCaseId == Constants.TC_244589)
                {

                }
                #endregion[TP_243105]

                #region[TP_243876]
                if (TestCaseId == Constants.TC_251550)
                {

                }
                else if (TestCaseId == Constants.TC_243948)
                {

                }
                #endregion[TP_243876]
                #region[TP_159979]
                if (TestCaseId == Constants.TC_244590)
                {

                }
                #endregion[TP_159979]

                #region[TP_160101]

                if (TestCaseId == Constants.TC_160144)
                {
                    if (pair.Key == "TC_160144_Search_FirstName")
                        TC_160144_Search_FirstName = pair.Value;
                    else if (pair.Key == "TC_160144_Search_LastName")
                        TC_160144_Search_LastName = pair.Value;
                }
                else if (TestCaseId == Constants.TC_160143)
                {
                    if (pair.Key == "TC_160143_Search_ProfileID")
                        TC_160143_Search_ProfileID = pair.Value;
                }
                else if (TestCaseId == Constants.TC_160147)
                {
                    if (pair.Key == "TC_160147_Search_Email")
                        TC_160147_Search_Email = pair.Value;
                    else if (pair.Key == "TC_160147_Search_FirstName")
                        TC_160147_Search_FirstName = pair.Value;
                    else if (pair.Key == "TC_160147_Search_LastName")
                        TC_160147_Search_LastName = pair.Value;
                }
                else if (TestCaseId == Constants.TC_160149)
                {
                    if (pair.Key == "TC_160149_Search_MemberID")
                        TC_160149_Search_MemberID = pair.Value;
                    else if (pair.Key == "TC_160149_Search_ProfileID")
                        TC_160149_Search_ProfileID = pair.Value;
                }
                else if (TestCaseId == Constants.TC_243421)
                {
                    if (pair.Key == "TC_243421_Search_ReservationID")
                        TC_243421_Search_ReservationID = pair.Value;
                    else if (pair.Key == "TC_243421_Search_ProfileID")
                        TC_243421_Search_ProfileID = pair.Value;
                }
                else if (TestCaseId == Constants.TC_160146)
                {
                    if (pair.Key == "TC_160146_Search_Phone")
                        TC_160146_Search_Phone = pair.Value;
                    else if (pair.Key == "TC_160146_Search_FirstName")
                        TC_160146_Search_FirstName = pair.Value;
                    else if (pair.Key == "TC_160146_Search_LastName")
                        TC_160146_Search_LastName = pair.Value;
                }
                else if (TestCaseId == Constants.TC_243423)
                {
                    if (pair.Key == "TC_243423_Search_Zip")
                        TC_243423_Search_Zip = pair.Value;
                    else if (pair.Key == "TC_243423_Search_FirstName")
                        TC_243423_Search_FirstName = pair.Value;
                    else if (pair.Key == "TC_243423_Search_LastName")
                        TC_243423_Search_LastName = pair.Value;
                }
                else if (TestCaseId == Constants.TC_243411)
                {
                    if (pair.Key == "TC_243411_Search_ReservationID")
                        TC_243411_Search_ReservationID = pair.Value;
                }
                else if (TestCaseId == Constants.TC_160193)
                {
                    if (pair.Key == "TC_160193_Search_ReservationID")
                        TC_160193_Search_ReservationID = pair.Value;
                    else if (pair.Key == "TC_160193_Search_ProfileID")
                        TC_160193_Search_ProfileID = pair.Value;
                    else if (pair.Key == "TC_160193_Search_MemberID")
                        TC_160193_Search_MemberID = pair.Value;
                    else if (pair.Key == "TC_160193_Search_FirstName")
                        TC_160193_Search_FirstName = pair.Value;
                    else if (pair.Key == "TC_160193_Search_LastName")
                        TC_160193_Search_LastName = pair.Value;
                    else if (pair.Key == "TC_160193_Search_Email")
                        TC_160193_Search_Email = pair.Value;
                    else if (pair.Key == "TC_160193_Search_Phone")
                        TC_160193_Search_Phone = pair.Value;
                }


                #endregion[TP_160101]


                #region[TP_243159]
                if (TestCaseId == Constants.TC_243197)
                {
                    if (pair.Key == "TC_243197_Search_FirstName")
                        TC_243197_Search_FirstName = pair.Value;
                    else if (pair.Key == "TC_243197_Search_LastName")
                        TC_243197_Search_LastName = pair.Value;
                    else if (pair.Key == "TC_243197_Search_ProfileID")
                        TC_243197_Search_ProfileID = pair.Value;
                }
                #endregion[TP_243159]

                #region[TP_242772]
                if (TestCaseId == Constants.TC_243245)
                {
                    if (pair.Key == "TC_243245_Search_ProfileID")
                        TC_243245_Search_ProfileID = pair.Value;
                    else if (pair.Key == "TC_243245_Search_FirstName")
                        TC_243245_Search_FirstName = pair.Value;
                    else if (pair.Key == "TC_243245_Search_LastName")
                        TC_243245_Search_LastName = pair.Value;
                }
                else if (TestCaseId == Constants.TC_242784)
                {
                    if (pair.Key == "TC_242784_Search_ProfileID")
                        TC_242784_Search_ProfileID = pair.Value;
                    else if (pair.Key == "TC_242784_Search_FirstName")
                        TC_242784_Search_FirstName = pair.Value;
                    else if (pair.Key == "TC_242784_Search_LastName")
                        TC_242784_Search_LastName = pair.Value;
                }
                else if (TestCaseId == Constants.TC_242805)
                {
                    if (pair.Key == "TC_242805_Search_ProfileID")
                        TC_242805_Search_ProfileID = pair.Value;
                    else if (pair.Key == "TC_242805_Search_FirstName")
                        TC_242805_Search_FirstName = pair.Value;
                    else if (pair.Key == "TC_242805_Search_LastName")
                        TC_242805_Search_LastName = pair.Value;
                }
                else if (TestCaseId == Constants.TC_242789)
                {
                    if (pair.Key == "TC_242789_Search_ProfileID")
                        TC_242789_Search_ProfileID = pair.Value;
                    else if (pair.Key == "TC_242789_Search_FirstName")
                        TC_242789_Search_FirstName = pair.Value;
                    else if (pair.Key == "TC_242789_Search_LastName")
                        TC_242789_Search_LastName = pair.Value;
                }
                else if (TestCaseId == Constants.TC_242812)
                {
                    if (pair.Key == "TC_242812_Search_ProfileID")
                        TC_242812_Search_ProfileID = pair.Value;
                    else if (pair.Key == "TC_242812_Search_FirstName")
                        TC_242812_Search_FirstName = pair.Value;
                    else if (pair.Key == "TC_242812_Search_LastName")
                        TC_242812_Search_LastName = pair.Value;
                    else if (pair.Key == "TC_242812_Test_Email")
                        TC_242812_Test_Email = pair.Value;
                }

                #endregion[TP_242772]
            }
            return obj;
        }


    }
}