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
        static string hadPropertyFromName = "";

        #region[TP_259526]
        public static void TC_258998()
        {
            string projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", "TP_259526");
            string subjectName = "ProjectId=#ProjectID# (FromName)".Replace("#ProjectID#", projectID);
            string fromName = SqlWarehouseQuery.ReturnCompanyName("NA", "FromName", "TP_259526");
            string replyEmail = "Cendynqatest##cendynautomation@cendyn.com";
            Users tagValues = new Users();

            Profile.SelectSubClient(clientName);

            #region[TC_261220]
            Logger.WriteInfoMessage("Start of Test Case # 261220");
            string hadPropertyFromName = SqlWarehouseQuery.HasParentSetting(CompanyName, "HasPropertyFromName");
            if (hadPropertyFromName == "Enabled")
            {
                Logger.WriteInfoMessage("Setting is Enabled");
            }
            else
            {
                Logger.WriteInfoMessage("Setting is disabled");
            }
            Logger.WriteInfoMessage("End of Test Case # 261220");
            #endregion[TC_261220]

            #region[TC_261222]

            if (hadPropertyFromName == "Disabled")
            {
                Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "Admin.mvc/Admin");
                Admin.Click_Link_AllTabs();
                Admin.Click_Link_CompanySettings();
                Admin.Click_Button_HasPropertyFromName();
                Admin.EnterText_SettingValue("Y");
            }
            #endregion[TC_261222]

            Navigation.MenuNavigation("ManageCampaign");
            Logger.WriteInfoMessage("Executing for ProjectID: " + projectID + ". And updating Campaign status to Draft.");
            SqlWarehouseQuery.UpdateProjectStatus(Convert.ToInt32(projectID));
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign, "Transactional");
            ManageCampaign.ManageCampaign_EllipseButton("Edit");
            ManageCampaign.EnterCampaignSubject(subjectName);
            CreateCampaign.SelectFromName(fromName);
            CreateCampaign.SelectReplyEmail(replyEmail);
            ScrollUpUsingJavaScript(Driver, -500);
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 60);
            Logger.WriteDebugMessage("Landed on Testing Tab.");
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            ElementWait(Driver.FindElement(By.XPath("//*[@id='SendToTestEmails" + projectID + "']")), 60);
            Logger.WriteDebugMessage("Landed on Approval Tab.");
            CreateCampaign.Click_Button_SendforApproval();
            CreateCampaign.CampaignApprove(Convert.ToInt32(projectID));
            CreateCampaign.CreateCampaign_Button_Continue();
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab(), 60);
            Logger.WriteDebugMessage("Landed on Schedule Page");
            CreateCampaign.SelectTime();
            ScrollUpUsingJavaScript(Driver, -500);

            CreateCampaign.CampaignScheduleandComplete("Schedule");
            if (testCategory == "QA")
            {
                SqlWarehouseQuery.GetPersonalizedTagValue(tagValues, CompanyName, 0, "", projectID, "");
                SqlWarehouseQuery.GetPersonalizedTagValue(tagValues, CompanyName, 1, "", projectID, tagValues.CustomerIDs);
            }
            //SqlWarehouseQuery.UpdateReservationStatus(CompanyName, tagValues.PrimaryCustomer);
            AddDelay(9000);
            OpenNewTab();
            ControlToNewWindow();

            Login.AutoAcc_login(subjectName, 1, 0, LegacyTestData.CommonCatchallURL, 0);
            //Hotmail.SearchEmailAndOpenLatestEmail(tagValues.Email, 0);
            SqlWarehouseQuery.UpdateProjectStatus(Convert.ToInt32(projectID));
        }
        public static void TC_258999()
        {
            //CompanyName = SqlWarehouseQuery.ReturnCompanyName("", "CompanyName", "TP_259526");
            //clientName = SqlWarehouseQuery.ReturnCompanyName("", "clientName", "TP_259526");
            string projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);
            string subjectName = SqlWarehouseQuery.ReturnCompanyName("NA", "SubjectName", TestPlanId).Replace("#ProjectID#", projectID);
            string fromName = SqlWarehouseQuery.ReturnCompanyName("NA", "FromName", "TP_259526");
            string replyEmail = "Cendynqatest##cendynautomation@cendyn.com";
            Users tagValues = new Users();

            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            #region[TC_261220]
            Logger.WriteInfoMessage("Start of Test Case # 261220");
            hadPropertyFromName = SqlWarehouseQuery.HasParentSetting(CompanyName, "HasPropertyFromName");
            if (hadPropertyFromName == "Enabled")
            {
                Logger.WriteInfoMessage("Setting is Enabled");
            }
            else
            {
                Logger.WriteInfoMessage("Setting is disabled");
            }
            Logger.WriteInfoMessage("End of Test Case # 261220");
            #endregion[TC_261220]

            #region[TC_261222]

            if (hadPropertyFromName == "Disabled")
            {
                Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "Admin.mvc/Admin");
                Admin.Click_Link_AllTabs();
                Admin.Click_Link_CompanySettings();
                Admin.Click_Button_HasPropertyFromName();
                Admin.EnterText_SettingValue("Y");
            }
            #endregion[TC_261222]

            Navigation.MenuNavigation("ManageCampaign");

            Logger.WriteInfoMessage("Executing for ProjectID: " + projectID + ". And updating Campaign status to Draft.");
            SqlWarehouseQuery.UpdateProjectStatus(Convert.ToInt32(projectID));

            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign, "Transactional");
            ManageCampaign.ManageCampaign_EllipseButton("Edit");
            ElementWait(Driver.FindElement(By.Id("FromNameChecked")), 60);
            AddDelay(8000);
            var quotes = '"';
            var script = "return $('input[id=" + quotes + "FromNameChecked" + quotes + "]:checked').length > 0;";
            IJavaScriptExecutor js = (IJavaScriptExecutor)Helper.Driver;
            string isChecked = js.ExecuteScript(script).ToString();
            if (isChecked.ToString() == "True")
            {
                Logger.WriteDebugMessage("Use Property From Name/Email is already checked");
            }
            else
            {
                ElementClick(Driver.FindElement(By.Id("FromNameChecked")));
                Logger.WriteDebugMessage("Clicked Use Property From Name/Email checkbox");
            }
            script = "return $('input[id=" + quotes + "ReplyToEmailChecked" + quotes + "]:checked').length > 0;";
            isChecked = js.ExecuteScript(script).ToString();
            if (isChecked == "True")
            {
                Logger.WriteDebugMessage("Clicked Use Property Reply-to Email checkbox");
            }
            else
            {
                ElementClick(Driver.FindElement(By.Id("FromNameChecked")));
                Logger.WriteDebugMessage("Clicked Use Property Reply-to Email checkbox");
            }
            ElementClick(Driver.FindElement(By.Id("ReplyToEmailChecked")));
            Logger.WriteDebugMessage("Clicked on Property ReplyTo checkbox");
            ManageCampaign.EnterCampaignSubject(subjectName);
            CreateCampaign.SelectFromName(fromName);
            CreateCampaign.SelectReplyEmail(replyEmail);
            ScrollUpUsingJavaScript(Driver, -500);
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 60);
            Logger.WriteDebugMessage("Landed on Testing Tab.");
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            ElementWait(Driver.FindElement(By.XPath("//*[@id='SendToTestEmails" + projectID + "']")), 60);
            Logger.WriteDebugMessage("Landed on Approval Tab.");
            CreateCampaign.Click_Button_SendforApproval();
            CreateCampaign.CampaignApprove(Convert.ToInt32(projectID));
            CreateCampaign.CreateCampaign_Button_Continue();
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab(), 60);
            Logger.WriteDebugMessage("Landed on Schedule Page");
            CreateCampaign.SelectTime();
            ScrollUpUsingJavaScript(Driver, -500);
            CreateCampaign.CampaignScheduleandComplete("Schedule");
            AddDelay(300000);
            OpenNewTab();
            ControlToNewWindow();
            if (testCategory == "QA")
            {
                SqlWarehouseQuery.GetPersonalizedTagValue(tagValues, CompanyName, 0, "", projectID, "");
                SqlWarehouseQuery.GetPersonalizedTagValue(tagValues, CompanyName, 1, "", projectID, tagValues.CustomerIDs);
            }
            Login.AutoAcc_login(subjectName, 1, 0, LegacyTestData.CommonCatchallURL, 0);
            SqlWarehouseQuery.UpdateProjectStatus(Convert.ToInt32(projectID));
        }
       
        #endregion[TP_259526]

    }
}
