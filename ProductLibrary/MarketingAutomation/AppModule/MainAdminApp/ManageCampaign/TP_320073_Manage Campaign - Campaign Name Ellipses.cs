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
using MarketingAutomation.PageObject.UI;

namespace MarketingAutomation.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region[TP_320073]

        public static void TC_320074()
        {
            if (TestCaseId == Constants.TC_320074)
            {
                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Validate Ellipses
                ManageCampaign.Click_ManageCampaign_Ellipse();
                Logger.WriteDebugMessage("Ellipse is present");

                Helper.IsElementDisplayed(PageObject_ManageCampaign.Click_ManageCampaign_Ellipse_ViewDetails());
                Helper.IsElementDisplayed(PageObject_ManageCampaign.Click_ManageCampaign_Ellipse_Edit());
                Helper.IsElementDisplayed(PageObject_ManageCampaign.Campaign_Card_Campaign_Ellipse_Clone());
                Logger.WriteDebugMessage("View Details is displayed under Ellipse");
                Logger.WriteDebugMessage("Edit is displayed under Ellipse");                
                Logger.WriteDebugMessage("Clone is displayed under Ellipse");

            }
        }

        public static void TC_320077()
        {
            if (TestCaseId == Constants.TC_320077)
            {
                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Validate Ellipses
                ManageCampaign.Click_ManageCampaign_Ellipse();
                Logger.WriteDebugMessage("Ellipse is present");

                //Click Ellipses>>View Details
                ManageCampaign.Click_ManageCampaign_Ellipse_ViewDetails();
                Logger.WriteDebugMessage("View Details Summary page displayed");
                Helper.IsElementDisplayed(PageObject_ManageCampaign.Click_ManageCampaign_Ellipse_ViewDetails_Subject());
                Logger.WriteDebugMessage("Subject field displayed on View Details Summary page");

            }
        }

        public static void TC_320075()
        {
            if (TestCaseId == Constants.TC_320075)
            {

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //1.Applied Draft Status Campaign and verify landed page
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", "Draft");
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                if (Helper.IsElementDisplayed(PageObject_CreateCampaign.CreateCampaign_Audience_Selection()))
                {
                    ManageCampaign.Click_ManageCampaign_Ellipse();
                    Logger.WriteDebugMessage("Click Ellipse");
                    ManageCampaign.Click_ManageCampaign_Ellipse_Edit();
                    string client_CurrentUrl = Driver.Url;
                    client_CurrentUrl.Contains("audience");
                    Logger.WriteDebugMessage("User landed on audience page");
                }
                else
                {
                    ManageCampaign.Click_ManageCampaign_Ellipse();
                    Logger.WriteDebugMessage("Click Ellipse");
                    ManageCampaign.Click_ManageCampaign_Ellipse_Edit();
                    Logger.WriteDebugMessage("User landed on the Design Page");
                    Helper.IsElementDisplayed(PageObject_CreateCampaign.Verify_DesignPage_ApprovalCard_Title());
                    Logger.WriteDebugMessage("Approval title is present on Confirm Step Page");
                }
                
                Navigation.ClickOnSidebarCampaigns();
                //2.Applied filter for Pending Status Campaign and verify landed page
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", "Pending");
                CreateCampaign.Campaign_Click_Filter_Apply_Button();

                ManageCampaign.Click_ManageCampaign_Ellipse();
                Logger.WriteDebugMessage("Click Ellipse");
                ManageCampaign.Click_ManageCampaign_Ellipse_Edit();
                Logger.WriteDebugMessage("User landed on the Confirm step Page");
                Helper.IsElementDisplayed(PageObject_CreateCampaign.Verify_DesignPage_ApprovalCard_Title());
                Logger.WriteDebugMessage("Approval title is present on Confirm Step Page");
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("User lands on Manage Campaign page");

                //3.Applied filter for Approved  Status Campaign and verify landed page
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", "Approved");
                CreateCampaign.Campaign_Click_Filter_Apply_Button();

                ManageCampaign.Click_ManageCampaign_Ellipse();
                Logger.WriteDebugMessage("Click Ellipse");
                ManageCampaign.Click_ManageCampaign_Ellipse_Edit();
                Logger.WriteDebugMessage("User landed on the Confirm step Page");
                Helper.IsElementDisplayed(PageObject_CreateCampaign.Verify_SchedulePage_Schedule_Title());
                Logger.WriteDebugMessage("Schedule title is present on Schedule Page");
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("User lands on Manage Campaign page");

                //4.Applied filter for Rejected  Status Campaign and verify landed page
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", "Rejected");
                CreateCampaign.Campaign_Click_Filter_Apply_Button();

                ManageCampaign.Click_ManageCampaign_Ellipse();
                Logger.WriteDebugMessage("Click Ellipse");
                ManageCampaign.Click_ManageCampaign_Ellipse_Edit();
                Logger.WriteDebugMessage("User landed on the Confirm step Page");
                Helper.IsElementDisplayed(PageObject_CreateCampaign.Verify_DesignPage_ApprovalCard_Title());
                Logger.WriteDebugMessage("Approval title is present on Confirm Step Page");
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("User lands on Manage Campaign page");

                //5.Applied filter for Scheduled Status Campaign and verify landed page
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", "Scheduled Active");
                CreateCampaign.Campaign_Click_Filter_Apply_Button();

                ManageCampaign.Click_ManageCampaign_Ellipse();
                Logger.WriteDebugMessage("Click Ellipse");
                ManageCampaign.Click_ManageCampaign_Ellipse_Edit();
                Logger.WriteDebugMessage("User landed on the Confirm step Page");
                Helper.IsElementDisplayed(PageObject_CreateCampaign.Verify_SchedulePage_Schedule_Title());
                Logger.WriteDebugMessage("Schedule title is present on Schedule Page");
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("User lands on Manage Campaign page");
            }
        }
        #endregion[TP_320073]
    }
}
