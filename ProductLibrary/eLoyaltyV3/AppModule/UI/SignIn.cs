using BaseUtility.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eLoyaltyV3.PageObject.UI;
using InfoMessageLogger;
using TestData;
using NUnit.Framework;

namespace eLoyaltyV3.AppModule.UI
{
    public class SignIn
    {
        public static void Click_Button_LogIn(string projectName)
        {
            switch (projectName)
            {
                case "HotelIcon":
                case "Fraser":
                case "PublicHotel":
                case "AMR":
                    Helper.ElementClick(Common.CommonMethod.Driver.FindElement(By.XPath("//input[@value='Log In']")));
                    break;
                case "MyPlace":
                case "IndependentCollection":
                case "EHPC":
                case "Sacher":
                    Helper.ElementClick(Common.CommonMethod.Driver.FindElement(By.XPath("//button[contains(text(),'Sign In')]")));
                    break;
                case "Sarova":
                case "Bartell":
                case "AdareManor":
                case "HotelOrigami":
                    Helper.ElementClick(Common.CommonMethod.Driver.FindElement(By.XPath("//input[@value='Sign In' and @type='submit']")));
                    break;
                default:
                    Helper.ElementClick(PageObject_SignIn.Button_LogIn2());
                    break;
            }

            //else if (Helper.IsElementPresent(By.XPath("//input[@value='Welcome Home']")))
            //{
            //    Helper.ElementClick(PageObject_SignIn.Button_LogIn3());
            //}

            //else if (Helper.IsElementPresent(By.XPath("//input[@value='Sign In' and @type='submit']")))
            //{
            //    Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//input[@value='Sign In' and @type='submit']")));
            //}
            //else if (Helper.IsElementPresent(By.XPath("//button[contains(text(),'Login')]")))
            //{
            //    Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//button[contains(text(),'Login')]")));
            //}
            //else if (Helper.IsElementPresent(By.XPath("//button[contains(text(),'Sign In')]")))
            //{
            //    Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//button[contains(text(),'Sign In')]")));
            //}
            //else
            //{
            //    Helper.ElementClick(PageObject_SignIn.Button_LogIn2());
            //}
        }

        /// <summary>
        /// Method to perform end to end Login Operation
        /// </summary>      
        public static void LogIn(string email, string password, string projectName)
        {

            /*if (projectName.Equals("IndependentCollection"))
            {
                Logger.WriteDebugMessage("Landed on IndependentCollection Login Page.");
                Helper.ElementWait(PageObject_SignIn.Text_Email(), 60);
                EnterText_Text_Email(email);
                Logger.WriteDebugMessage("Entered email address - " + email);
                Click_Button_Next();
                Logger.WriteDebugMessage("Landed SSO Login Page");
                EnterText_Text_Password(password);
                Logger.WriteDebugMessage("Entered password - " + password);
                Click_Button_LogIn(projectName);
            }
            else if (projectName.Equals("HotelIcon"))
            {

                Helper.ElementWait(PageObject_SignIn.Text_Email(), 60);
                Logger.WriteDebugMessage("Login Page Popup is displayed.");
                EnterText_Text_Email(email);
                EnterText_Text_Password(password);
                Logger.WriteDebugMessage("Entered Email: " + email + " and Password: " + password + " credentials");
                Helper.AddDelay(2500);
                Click_Button_LogIn(projectName);
            }
            else
            {*/
                Logger.WriteDebugMessage("Landed on Login Page.");
                EnterText_Text_Email(email);
                EnterText_Text_Password(password);
                Logger.WriteDebugMessage("Entered Email: " + email + " and Password: " + password + " credentials");
                Click_Button_LogIn(projectName);
                Helper.AddDelay(2500);
            //}
        }
        public static void EnterText_Text_Email(string text)
        {
            Helper.ElementEnterText(PageObject_SignIn.Text_Email(), text);
        }

        public static void EnterText_Text_Password(string text)
        {
            Helper.ElementEnterText(PageObject_SignIn.Text_Password(), text);
        }
        public static void Click_Link_ForgotYourLogin(string projectName, string emailId = "")
        {

            if (projectName.Equals("HotelIcon"))
            {
                Navigation.Click_Button_SignIn();
                Helper.ElementClick(PageObject_SignIn.Link_ForgotYourLogin());
                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recover(), 60);
            }
            else if (projectName.Equals("IndependentCollection"))
            {
                SignIn.EnterText_Text_Email(ProjectDetails.CommonFrontendEmail);
                SignIn.Click_Button_Next();
                Helper.ElementClick(PageObject_SignIn.Link_ForgotYourLogin());
                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recover(), 60);
            }
            else if (projectName.Equals("MyPlace") && emailId != "")
            {
                Helper.ElementClick(PageObject_SignIn.Link_ForgotYourLogin());
                SignIn.EnterText_Text_Email(emailId);
                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recover(), 60);
            }
            else
            {
                Helper.ElementClick(PageObject_SignIn.Link_ForgotYourLogin());
                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recover(), 60);
            }

        }

        public static void Click_Button_Next()
        {
            Helper.ElementClick(PageObject_SignIn.Button_NextLogin());
        }
        public static void VerifyLandingPage(string projectName, string title)
        {
            if (title.Contains("My Activity"))
                Logger.WriteDebugMessage("User Successfully landed to Landing Page:" + title);
            else if (title.Contains("Profile"))
                Logger.WriteDebugMessage("User Successfully landed to Landing Page:" + title);
            else if (title.Contains("Overview"))
                Logger.WriteDebugMessage("User Successfully landed to Landing Page:" + title);
            else if (title.Contains("Member"))
                Logger.WriteDebugMessage("User Successfully landed to Landing Page:" + title);
            else if (title.Contains("My Awards"))
                Logger.WriteDebugMessage("User Successfully landed to Landing Page:" + title);
            else if (title.Contains("Specials"))
                Logger.WriteDebugMessage("User Successfully landed to Landing Page:" + title);
            else if (title.Contains("FAQ"))
                Logger.WriteDebugMessage("User Successfully landed to Landing Page:" + title);
            else if (title.Contains("Contact Us"))
                Logger.WriteDebugMessage("User Successfully landed to Landing Page:" + title);
            else if (title.Contains("Login"))
                Logger.WriteDebugMessage("User Successfully landed to Landing Page:" + title);
            else if (title.Contains(""))
                Logger.WriteDebugMessage("User Successfully landed to Landing Page:" + title);
            else
                Assert.Fail("User redirected to Invalid Page:" + title);
        }

        public static void ValidateMembershipLevel(string projectname)
        {
            if (projectname.Equals("Fraser"))
            {
                Helper.VerifyTextOnPage("Crystal");
                Logger.WriteDebugMessage("Crystal membership Level should be displayed");
            }
            else if (projectname.Equals("IndependentCollection"))
            {
                Helper.VerifyTextOnPage("Gold");
                Logger.WriteDebugMessage("Gold membership Level should be displayed");
            }
            else if (projectname.Equals("AdareManor"))
            {
                Helper.VerifyTextOnPage("Welcome");
                Logger.WriteDebugMessage("Landed on Welcome page");
            }
            else if (projectname.Equals("HotelIcon"))
            {
                Logger.WriteDebugMessage("Landed on Welcome page");
            }
        }

        public static void ValidateMembershipSince()
        {
            string date = DateTime.Now.ToShortDateString();
            Helper.ValidateTextOnPage(date);
        }
    }
}
