using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseUtility.Utility;
using InfoMessageLogger;
using Common;
using OpenQA.Selenium;
using eNgage.PageObject.UI;
using eNgage.Utility;
using BaseUtility.Utility.Hotmail;
using NUnit.Framework;

namespace eNgage.AppModule.UI
{
    class Login : Helper
    {
        /// <summary>
        /// This method will enter the user name on the eNgage login page.
        /// </summary>
        /// <param name="username">Username to enter.</param>
        public static void EnterUserName(string username)
        {
            ElementEnterText(PageObject_Login.Email(), username);
        }

        /// <summary>
        /// This method will enter the password on the eNgage login page.
        /// </summary>
        /// <param name="password">Password to enter.</param>
        public static void EnterPassword(string password)
        {
            ElementEnterText(PageObject_Login.Password(), password);
        }

        /// <summary>
        /// This method will click the Forgot Password link on the eInsight login page.
        /// </summary>
        public static void ClickForgotPassword()
        {
            ElementClick(PageObject_Login.ForgotPassword());
        }

        public static void Click_Button_ForgotPassword_Submit()
        {
            ElementClick(PageObject_Login.Button_ForgotPassword_Submit());
        }

        public static void EnterText_Text_ForgotPassword_Email(string text)
        {
            ElementEnterText(PageObject_Login.Text_ForgotPassword_Email(), text);
        }

        /// <summary>
        /// This method will click the Submit button on the eInsight login page.
        /// </summary>
        public static void ClickSubmit()
        {
            ElementClick(PageObject_Login.Submit());
        }



        public static void CommonLogin(string CommonFrontendURL)
        {
            if(LegacyTestData.CommonFrontendEmail == "cendynautomation@cendyn.com")
            {
                LegacyTestData.CommonFrontendPassword = "Cendyn111$";
            }
            Driver.Navigate().GoToUrl(CommonFrontendURL);
            EnterUserName(LegacyTestData.CommonFrontendEmail);
            EnterPassword(LegacyTestData.CommonFrontendPassword);
            ClickSubmit();
            AddDelay(9000);
            //Need to add condition to check whetther login n succesful or not
            if (Driver.Title == "eInsight Engage")
            {
                Logger.WriteDebugMessage("Logged in to URL: " + CommonFrontendURL + " with UserName - " + LegacyTestData.CommonFrontendEmail);
            }
            else
            {
                Logger.WriteFatalMessage("Unable to Login " + CommonFrontendURL + " with UserName - " + LegacyTestData.CommonFrontendEmail + " INVALID LOGIN");
                Assert.Fail("Unable to Login");
            }
        }
        //Login used for few specific test cases 
        public static void LoginTestCase(string CommonFrontendURL)
        {
            Driver.Navigate().GoToUrl(CommonFrontendURL);
            EnterUserName(LegacyTestData.FrontEndEmail);
            EnterPassword(LegacyTestData.FrontEndPassword);
            ClickSubmit();
            if (CommonFrontendURL.Contains("Minor") == true)
            {
                if (Driver.Title.Trim() == "MH Front Office")
                {
                    Logger.WriteDebugMessage("Logged in to URL: " + CommonFrontendURL + " with UserName - " + LegacyTestData.FrontEndEmail);
                }
                else
                {
                    Logger.WriteFatalMessage("Unable to Login " + CommonFrontendURL + " with UserName - " + LegacyTestData.FrontEndEmail + " INVALID LOGIN");
                    Assert.Fail("Unable to Login");
                }
            }
            else
            {
                if (Driver.Title == "eInsight Engage")
                {
                    Logger.WriteDebugMessage("Logged in to URL: " + CommonFrontendURL + " with UserName - " + LegacyTestData.FrontEndEmail);
                }
                else
                {
                    Logger.WriteFatalMessage("Unable to Login " + CommonFrontendURL + " with UserName - " + LegacyTestData.FrontEndEmail + " INVALID LOGIN");
                    Assert.Fail("Unable to Login");
                }
            }
        }

        public static string LoginURL()
        {
            string URL;
            Console.WriteLine("value =" + LegacyTestData.FrontEndURL);
            if (LegacyTestData.FrontEndURL != "" && LegacyTestData.FrontEndURL != null)
            {
                URL = LegacyTestData.FrontEndURL;
                URL = URL.Replace("{ClientName}", LegacyTestData.ClientName);
            }
            else
                URL = LegacyTestData.CommonFrontendURL;
            return URL;
        }
    }
}
