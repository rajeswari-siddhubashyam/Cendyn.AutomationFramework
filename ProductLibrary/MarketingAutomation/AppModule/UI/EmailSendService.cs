using BaseUtility.Utility;
using Common;
using MarketingAutomation.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketingAutomation.Utility;
using System.Globalization;
using MarketingAutomation.Entity;
using Queries = MarketingAutomation.Utility.Queries;

namespace MarketingAutomation.AppModule.UI
{
    class EmailSendService: Helper
    {
        public static void VerifyEmailInformation(string scenarioData, string emailTitle)
        {
            var data = scenarioData.Split(',');
            var arrivalDate = Helper.GetFutureDateByProvidingDays(Convert.ToInt32((data[8].Split('+'))[1]));
            var depatureDate = Helper.GetFutureDateByProvidingDays(Convert.ToInt32((data[9].Split('+'))[1]));
            string heading = Helper.GetText(PageObject_Email.Outlook_Email_Heading());
            string bodyText= Helper.GetText(PageObject_Email.Outlook_Yahoo_Email_Body());
            Assert.IsTrue(heading.Trim().Equals(emailTitle.Trim()), "Email title is not machting as per campaign description");
            if (bodyText.Contains(data[0].Trim()) && bodyText.Contains(data[1].Trim()) && bodyText.Contains(data[2].Trim()) && bodyText.Contains(data[3].Trim()) && bodyText.Contains(data[4].Trim()) && bodyText.Contains(data[5].Trim()) && bodyText.Contains(data[6].Trim()) && bodyText.Contains(data[7].Trim()) && bodyText.Contains(arrivalDate.Trim()) && bodyText.Contains(depatureDate.Trim()))
                Logger.WriteDebugMessage($"Reservation data is showing in the email as per template: {scenarioData}");
            else
            {
                Console.WriteLine("Data is not matching");
                Assert.Fail($"Reservation data is not showing in the email as per template: {scenarioData}");
            }
        }
        public static void VerifyEmailInformation()
        {
            Assert.IsTrue(Helper.IsElementDisplayed(PageObject_Email.Outlook_Email_No_Result()), "User is getting email in the inbox in invalid case ");
        }

        public static void AddFilterToGetTheUnreadEmail()
        {
            try
            {
                Helper.Driver.FindElement(By.XPath("//div[@role='button']/child::div[contains(.,'Filter')]")).Click();
                Helper.AddDelay(15000);
                Helper.Driver.FindElement(By.XPath("//ul[@role='presentation']/descendant::button[@name='Unread']")).Click();
                Helper.AddDelay(15000);
            }
            catch (Exception) { }
        }

        public static void SignInIntoYahoo(string username, string password)
        {
            Helper.ElementClick(PageObject_Email.Yahoo_Email_Sign_In_Link());
            Helper.ElementEnterText(PageObject_Email.Yahoo_Email_Username(), username);
            Helper.ElementClick(PageObject_Email.Yahoo_Email_Next());
            Helper.ElementEnterText(PageObject_Email.Yahoo_Email_Password(), password);
            Helper.ElementClick(PageObject_Email.Yahoo_Email_Submit());
        }

        public static void SearchEmailInYahoo(string value)
        {
            Helper.ElementEnterText(PageObject_Email.Yahoo_Email_Search_Input(), value);
            PageObject_Email.Yahoo_Email_Search_Input().SendKeys(Keys.Enter);
        }

        public static void ClickOnYahooEmail()
        {
            Helper.ElementClick(PageObject_Email.Yahoo_Email_Searched_Result_Li());
        }

        public static void VerifyEmailInformation(string scenarioData)
        {
            var data = scenarioData.Split(',');
            var arrivalDate = Helper.GetFutureDateByProvidingDays(Convert.ToInt32((data[8].Split('+'))[1]));
            var depatureDate = Helper.GetFutureDateByProvidingDays(Convert.ToInt32((data[9].Split('+'))[1]));
            string bodyText = Helper.GetText(PageObject_Email.Outlook_Yahoo_Email_Body());
            if (bodyText.Contains(data[0].Trim()) && bodyText.Contains(data[1].Trim()) && bodyText.Contains(data[2].Trim()) && bodyText.Contains(data[3].Trim()) && bodyText.Contains(data[4].Trim()) && bodyText.Contains(data[5].Trim()) && bodyText.Contains(data[6].Trim()) && bodyText.Contains(data[7].Trim()) && bodyText.Contains(arrivalDate.Trim()) && bodyText.Contains(depatureDate.Trim()))
                Logger.WriteDebugMessage($"Reservation data is showing in the email as per template: {scenarioData}");
            else
            {
                Console.WriteLine("Data is not matching");
                Assert.Fail($"Reservation data is not showing in the email as per template: {scenarioData}");
            }
        }
    }
}
