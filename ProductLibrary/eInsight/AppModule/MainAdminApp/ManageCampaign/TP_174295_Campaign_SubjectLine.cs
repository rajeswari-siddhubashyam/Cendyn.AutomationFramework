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
        #region[TP_174295]
        public static void TC_174296()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName("", "ProjectID", TestPlanId);
            subjectName = "#SUBJECTLINE# Test";

            /*Pre-Requisite*/
            Logger.WriteInfoMessage("Pre-Requisite");
            hasSubjectLine = SqlWarehouseQuery.HasSubjectLineTag(CompanyName, Convert.ToInt32(projectID), "QA Automation", 1);

            if (hasSubjectLine == "Subject Line Tag is removed.")
            {
                Logger.WriteInfoMessage("Removed SubjectLine Mapping for projectID - " + projectID);
            }
            if (hasSubjectLine == "Subject Line Tag map does not exist.")
            {
                Logger.WriteInfoMessage("SubjectLine Mapping for projectID - " + projectID + " does not exist");
            }

            Navigation.MenuNavigation("ManageCampaign");

            SqlWarehouseQuery.UpdateProjectStatus(Convert.ToInt32(projectID));

            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);

            Logger.WriteInfoMessage("Executing for ProjectID: " + projectID + ". And updating Campaign status to Draft.");

            ManageCampaign.ManageCampaign_EllipseButton("Edit");
            if (IsElementVisible(Driver.FindElement(By.XPath("(//div[@class='dialogContent']//button[@class='btn btn-lg btn-danger'])[1]")))) ;
            {
                ElementClick(Driver.FindElement(By.XPath("(//div[@class='dialogContent']//button[@class='btn btn-lg btn-danger'])[1]")));
                Logger.WriteDebugMessage("Clicked on 'OK' button of Confirm Popup button");
            }
            ManageCampaign.EnterCampaignSubject(subjectName);

            CreateCampaign.MapSubjectLine();
            ScrollUpUsingJavaScript(Driver, -500);
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            //Check if SubjectLine Tag is Mapped.
            hasSubjectLine = SqlWarehouseQuery.HasSubjectLineTag(CompanyName, Convert.ToInt32(projectID), subjectName, 0);
            Logger.WriteInfoMessage("SubjectLine exist for projectID - " + projectID);
        }
        public static void TC_174312()
        {
            Users tagValues = new Users();
            projectID = SqlWarehouseQuery.ReturnCompanyName("", "ProjectID", TestPlanId);
            subjectName = "#SUBJECTLINE# Test";
            string searchSubject = subjectName.Replace("#SUBJECTLINE#", "QA Automation");

            Navigation.MenuNavigation("ManageCampaign");

            SqlWarehouseQuery.UpdateProjectStatus(Convert.ToInt32(projectID));

            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);

            Logger.WriteInfoMessage("Executing for ProjectID: " + projectID + ". And updating Campaign status to Draft.");
            ManageCampaign.ManageCampaign_EllipseButton("Edit");
            AddDelay(5000);

            ManageCampaign.EnterCampaignSubject(subjectName);
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
            AddDelay(10000);
            OpenNewTab();
            ControlToNewWindow();
            if (testCategory == "QA")
            {
                SqlWarehouseQuery.GetPersonalizedTagValue(tagValues, CompanyName, 0, "", projectID, "");
                SqlWarehouseQuery.GetPersonalizedTagValue(tagValues, CompanyName, 1, "", projectID, tagValues.CustomerIDs);
            }

            Login.AutoAcc_login(searchSubject, 1, 0, LegacyTestData.CommonCatchallURL, 0);
            SqlWarehouseQuery.UpdateProjectStatus(Convert.ToInt32(projectID));
        }
        public static void TC_174320()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName("", "ProjectID", TestPlanId);
            subjectName = "#SUBJECTLINE# Test";//SqlWarehouseQuery.ReturnCompanyName("", "SubjectName", "TP_174295");

            Navigation.MenuNavigation("ManageCampaign");
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Clone");
            AddDelay(10000);
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Button_SaveandContinue(), 120);
            if (VerifyTextOnPage("Clone") && VerifyTextOnPage(subjectName))
            {
                Logger.WriteDebugMessage("Landed on Cloned Campaign - Edit Campaign. Subject Name " + subjectName + " exist on the page.");

                CreateCampaign.CreateCampaign_Button_SaveandContinue();
                ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 60);
                Logger.WriteDebugMessage("Landed on Testing Tab.");

                CreateCampaign.Click_Button_TestingSendtoTest();

                AddDelay(10000);
                OpenNewTab();
                ControlToNewWindow();

                Login.AutoAcc_login(subjectName, 2, 1, LegacyTestData.CommonCatchallURL, 0);
            }
        }
        public static void TC_174328()
        {
            Users tagValues = new Users();
            projectID = SqlWarehouseQuery.ReturnCompanyName("", "ProjectID", TestPlanId);
            Navigation.MenuNavigation("ManageCampaign");
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Details");
            ManageCampaign.CampaignDetails_TabActions("Audience", projectID, "CustomerDetails");
            SqlWarehouseQuery.GetPersonalizedTagValue(tagValues, CompanyName, 0, "", projectID, "");
            Logger.WriteInfoMessage("Computing for CustomerIds: " + tagValues.CustomerIDs);
            string[] geteachCustomerIds = Regex.Split(tagValues.CustomerIDs, ",");
            foreach (string custID in geteachCustomerIds)
            {
                SqlWarehouseQuery.GetPersonalizedTagValue(tagValues, CompanyName, 1, "", projectID.ToString(), custID);
                ManageCampaign.SearchCustomer("Email", tagValues.Email);
                ManageCampaign.CustomerDetailEllipse_PreviewQuickSend("QuickSend");
                ManageCampaign.Customer_Send_QuickSend(custID, "");
                AddDelay(10000);
                OpenNewTab();
                ControlToNewWindow();

                subjectName = subjectName.Replace("#SUBJECTLINE#", "");
                Login.AutoAcc_logins(subjectName, 2, 1, LegacyTestData.CommonCatchallURL, 1);
                Logger.WriteDebugMessage("Received quick send email for Email - " + tagValues.Email);
            }
        }
        #endregion[TP_174295]

    }
}
