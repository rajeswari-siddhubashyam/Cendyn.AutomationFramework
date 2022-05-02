using System;
using eInsight.Utility;
using eInsight.AppModule.UI;
using Common;
using Constants = eInsight.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using BaseUtility.Utility.Hotmail;
using TestData;
using SqlWarehouse;
using OpenQA.Selenium;
using NUnit.Framework;
using eInsight.AppModule.UI;
using eInsight.PageObject.UI;
using System.Text.RegularExpressions;

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_89853]
        public static void TC_89856()
        {
            CompanyName = SqlWarehouseQuery.ReturnCompanyName("", "CompanyName", TestPlanId);
            clientName = SqlWarehouseQuery.ReturnCompanyName("", "clientName", TestPlanId);
            string projectID = SqlWarehouseQuery.ReturnCompanyName("", "ProjectID", TestPlanId);
            string groupName = SqlWarehouseQuery.ReturnCompanyName("", "GroupName", TestPlanId);
            string seedListEmails = SqlWarehouseQuery.ReturnCompanyName("", "SeedListEmails", TestPlanId);

            Navigation.MenuNavigation("ManageCampaign");
            AddDelay(8000);
            Logger.WriteDebugMessage("Landed on Manage Campaign Page for Property: " + CompanyName);
            ManageCampaign.PreSearchCampaign(1, Convert.ToInt32(projectID), CompanyName, clientName);

            //Clone the Campaign
            HighlightElement(Driver.FindElement(By.XPath("//a[@id='clone']")));
            Logger.WriteDebugMessage("Clicking on Clone button.");
            IWebElement SearchElement = Driver.FindElement(By.XPath("//a[@id='clone']"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].click();", SearchElement);
            AddDelay(12000);
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Button_Save(), 60);
            string getURL = Driver.Url;
            var newProjectID = Regex.Match(getURL, "#(.*)&ProjectTitle").Groups[1].Value;
            newProjectID = newProjectID.Replace("ProjectId=", "");
            string subjectName = "ProjectId=" + newProjectID;
            ManageCampaign.EnterCampaignSubject(subjectName);
            Logger.WriteDebugMessage("Landed on Cloned Campaign - Edit Campaign. New ProjectID - " + newProjectID);
            ScrollDownUsingJavaScript(Driver, -1000);
            CreateCampaign.CreateCampaign_Button_Save();
            ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 60);
            Logger.WriteDebugMessage("Landed on Testing Tab.");
            CreateCampaign.CreateCampaign_Button_Save();
            ElementWait(Driver.FindElement(By.XPath("//*[@id='SendToTestEmails" + newProjectID + "']")), 60);
            Logger.WriteDebugMessage("Landed on Approval Tab.");
            CreateCampaign.Click_Button_SendforApproval();
            CreateCampaign.CampaignApprove(Convert.ToInt32(newProjectID));
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab(), 60);
            Logger.WriteDebugMessage("Landed on Schedule Page");
            CreateCampaign.SelectTime();
            ScrollDownUsingJavaScript(Driver, -1000);
            CreateCampaign.CampaignScheduleandComplete("Marketing");
            Logger.WriteInfoMessage("Waiting for 7 minutes to send out campa");
            string message = "Automation will check out for below email address";
            message = message + "\n Global Seed List -  cendynautomationtest@cendyn17.com";
            message = message + "\n Group Seed List -  cendynautomationtest1@cendyn17.com,cendynautomation2Test@cendyn17.com,3cendynautomationTest@cendyn17.com";
            Logger.WriteInfoMessage(message);
            AddDelay(360000);
            OpenNewTab();
            ControlToNewWindow();
            Login.AutoAcc_login("", 1, 1, LegacyTestData.CommonCatchallURL, 0);
            string[] listofEmails = Regex.Split(seedListEmails, ",");
            foreach (string emailAddress in listofEmails)
            {
                Hotmail.SearchEmail(emailAddress);
                Hotmail.OpenLatestEmail();
                if (VerifyTextOnPage(subjectName))
                {
                    Logger.WriteDebugMessage("Received Email for EmailAddress - " + emailAddress + " for ProjectID - " + newProjectID);
                }
                else
                {
                    Assert.Fail("Did not received email for EmailAddress - " + emailAddress + " for ProjectID - " + newProjectID);
                }
            }

            /*
             * Post-Requisite
            */
            ControlToPreviousWindow();
            ManageCampaign.PreSearchCampaign(1, Convert.ToInt32(newProjectID), CompanyName, clientName);
            Logger.WriteInfoMessage("Deleting Campaign " + newProjectID);
            HighlightElement(Driver.FindElement(By.XPath("//a[contains(text(), 'Delete Campaign')]")));
            Logger.WriteDebugMessage("CLicking on Delete Button");
            ElementClick(Driver.FindElement(By.XPath("//a[contains(text(), 'Delete Campaign')]")));
            Logger.WriteDebugMessage("Confirming to delete campaign.");
            ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Ok')]")));
            AddDelay(35000);
            ((IJavaScriptExecutor)Driver).ExecuteScript("location.reload(true);");
        }
        #endregion[TP_89853]

    }
}
