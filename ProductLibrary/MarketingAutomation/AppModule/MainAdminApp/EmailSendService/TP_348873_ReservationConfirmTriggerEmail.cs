using MarketingAutomation.AppModule.UI;
using MarketingAutomation.Entity;
using MarketingAutomation.Utility;
using BaseUtility.Utility;
using Queries = MarketingAutomation.Utility.Queries;
using System.Collections.Generic;
using InfoMessageLogger;
using TestData;
using OpenQA.Selenium;
using System;
using NUnit.Framework;
using BaseUtility.Utility.Hotmail;
using MarketingAutomation.PageObject.UI;


namespace MarketingAutomation.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region[TP_348873]

        public static void TC_344498()
        {
            if (TestCaseId == Constants.TC_344498)
            {
                //Navigate to email and logged in with valid credentials
                Hotmail.NavigateToWebmail("https://www.office.com/?auth=2");
                Logger.WriteDebugMessage("User navigated to the https://www.office.com ");
                Hotmail.AutomationAcc_SignIn(Constants.CatchAllEmail, Constants.CatchAllPassword);
                Logger.WriteDebugMessage("User logged in into the catch all using valid credentials");
                //Validate the valid scenarion which will show email in outlook
                int s = 1;
                for (int i = 1; i < 12; i++)
                {
                    //Read the data scenario voice 
                    string emailTitle = TestData.ExcelData.TestDataReader.ReadData(1, "emailTitle");
                    string scenariosData = TestData.ExcelData.TestDataReader.ReadData(i+1, $"scenario{s}");
                    string emailValid= TestData.ExcelData.TestDataReader.ReadData(i+2, "email");
                    Helper.WaitForAjaxControls(50);
                    Hotmail.SearchEmailBySubject(emailTitle);
                    Hotmail.SearchEmailAndOpenLatestEmail(emailValid, 0);
                    EmailSendService.VerifyEmailInformation(scenariosData, emailTitle);
                    Driver.Navigate().Refresh();
                    i = i + 1;
                    s = s + 1;
                }

                //Validate the invalid scenarion which will not receive an email in outlook
                for (int j = 14; j < 17; j++)
                {
                    //Read the data scenario voice 
                    string emailInvalid = TestData.ExcelData.TestDataReader.ReadData(j, "email");
                    Helper.WaitForAjaxControls(50);
                    Hotmail.SearchEmail(emailInvalid);
                    EmailSendService.AddFilterToGetTheUnreadEmail();
                    EmailSendService.VerifyEmailInformation();
                    Logger.WriteDebugMessage("User is not getting email in the invalid case");
                    Driver.Navigate().Refresh();
                }
                //Validate yahoo email data
                string yahooEmail = TestData.ExcelData.TestDataReader.ReadData(17, "yahooEmail");
                string yahooPassword = TestData.ExcelData.TestDataReader.ReadData(18, "yahooPassword");
                string emailYahooInbox = TestData.ExcelData.TestDataReader.ReadData(19, "email");
                string yahooDataVerification = TestData.ExcelData.TestDataReader.ReadData(20, "scenario9");
                Hotmail.NavigateToWebmail("https://in.mail.yahoo.com/");
                Logger.WriteDebugMessage("User navigated to the https://in.mail.yahoo.com/");
                EmailSendService.SignInIntoYahoo(yahooEmail, yahooPassword);
                Logger.WriteDebugMessage("User logged in into the Yahoo using valid credentials");
                EmailSendService.SearchEmailInYahoo(emailYahooInbox);
                EmailSendService.ClickOnYahooEmail();
                EmailSendService.VerifyEmailInformation(yahooDataVerification);
            }
        }
        #endregion[TP_348873]
    }
}
