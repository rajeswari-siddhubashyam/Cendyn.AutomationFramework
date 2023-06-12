#region Using
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using AventStack.ExtentReports;
using System.Reflection;
using System.Collections.Generic;
#endregion


namespace Common
{
    public class CommonMethod
    {
        #region Properties
        public static string BrowserType { get; set; }
        public static IWebDriver Driver { get; set; }
        public static ThreadLocal<IWebDriver> Drivers { get; set; }
        public static IWebDriver Driver2 { get; set; }
        public static IList<IWebElement> Elements { get; set; }
        public static IWebElement Element { get; set; }
        public static SelectElement SelectElement { get; set; }
        public static bool ProposalOrder { get; set; }
        public static string UIWindow { get; set; }
        public static Actions Actions { get; set; }
        public static string UrlInfo { get; set; }
        public static string TestCaseId { get; set; }
        public static string TestCaseTitle { get; set; }
        public static string TestPlanId { get; set; }
        public static int StepCount { get; set; }
        public static string eProposalFlow { get; set; }
        public static string ScreenShotPath { get; set; }
        public static ExtentReports MyExtent { get; set; }
        public static ExtentTest MyExtentTest { get; set; }
        public static DateTime thisDay { get; set; }
        //public static string TestDataFile { get; set; }
        public static string CurrentElementName { get; set; }
        public static string CurrentPageName { get; set; }
        public static string DropDownValue { get; set; }
        public static string ProjectName { get; set; }
        public static string LogFilePath { get; set; }
        public static string PropertyType { get; set; }
        public static string ConnectionString { get; set; }
        public static string ConnectionString2 { get; set; }
        public static string ConnectionString3 { get; set; }
        public static string ConnectionString4 { get; set; }
        public static string ConnectionString5 { get; set; }
        public static string ConnectionStringVar { get; set; }
        public static IJavaScriptExecutor javaScriptExecutor { get; set; }
        public static string ProjectPath { get; set; }
        public static string TestDataFile { get; set; }
        public static string Project_Path { get; set; }
        public static string testCategory { get; set; }
        public static string frontEndURL { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Method to get the path for the working directory
        /// </summary>
        /// <returns></returns>
        public static string GetProjectPath(string cases)
        {
            try
            {
                if (cases.Equals("1"))
                {
                    string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
                    string actualPath = path.Substring(0, path.LastIndexOf("/bin"));
                    ProjectPath = new Uri(actualPath).LocalPath;
                }
                else
                {
                    string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
                    string actualPath = path.Substring(0, path.LastIndexOf("/GuestLoyaltyV3"));
                    ProjectPath = new Uri(actualPath).LocalPath;
                }
            }
            catch (Exception)
            {
                //Logger.WriteErrorMessage("Unable to fetch Project location", ex);
            }
            return ProjectPath;
        }

        /// <summary>
        /// POC Excel
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetEnumDescription(Enum value)
        {
            string description = value.ToString();
            FieldInfo fi = value.GetType().GetField(value.ToString());
            var attribute = (System.ComponentModel.DescriptionAttribute)fi.GetCustomAttribute(typeof(System.ComponentModel.DescriptionAttribute));
            return attribute.Description;
        }

        /// <summary>
        /// This function will search a page for a string of text and return True if it is NOT found.
        /// </summary>
        /// <param name="text">Text to find</param>
        /// <returns></returns>
        public static bool VerifyTextNOTOnPage(string text)
        {
            AddDelay(2500);
            try
            {
                if (!Driver.PageSource.Contains(text))
                {
                    return true;
                }
                return false;
            }

            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// This function will search a page for a string of text and return TRUE if it is found.
        /// </summary>
        /// <param name="text">Text to find</param>
        /// <returns></returns>
        public static bool VerifyTextOnPage(string text)
        {
            AddDelay(2500);
            try
            {
                if (Driver.PageSource.Contains(text) || Driver.PageSource.Contains(text.ToLower()))
                {
                    return true;
                }
                return false;
            }

            catch (Exception)
            {
                return false;
            }
        }

        public static void AddDelay(int time)
        {
            Thread.Sleep(time);
        }        
        #endregion
    }
}
