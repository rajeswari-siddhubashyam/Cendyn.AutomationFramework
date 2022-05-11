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
        #region[TP_346034]

        public static void TC_346058()
        {
            if (TestCaseId == Constants.TC_346058)
            {
                //Variables declaration and object creation
                string CampaignName;

                //Read the data
                CampaignName = TestData.ExcelData.TestDataReader.ReadData(1, "CampaignName");

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //1.Click on Campaign
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("Landed on Mange Campaign Page");

                //Click on List View Icon
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("Campaign diplayed in list view");

                //2.Applied filter for Pending Status Campaign and verify landed page
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", "Draft");
                ManageCampaign.EnterFilterValues("Name", "Equal", CampaignName);               
                CreateCampaign.Campaign_Click_Filter_Apply_Button();

                //3.Hover Over for any Draft Status Campaign
                ManageCampaign.Click_ManageCampaign_ListView_StatusArrow();
                Logger.WriteDebugMessage("Default status campaign displayed");
                Helper.IsElementDisplayed(PageObject_ManageCampaign.Check_ManageCampaign_cardView_Status_SelfApprove_button());
                Logger.WriteDebugMessage("Self Approve button displayed");
                Helper.IsElementDisplayed(PageObject_ManageCampaign.Check_ManageCampaign_cardView_Status_RequestApprove_button());
                Logger.WriteDebugMessage("Request Approve button displayed");

            }
        }

        public static void TC_346051()
        {
            if (TestCaseId == Constants.TC_346051)
            {
                //Variables declaration and object creation
                string CampaignName;

                //Read the data
                CampaignName = TestData.ExcelData.TestDataReader.ReadData(1, "CampaignName");

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //1.Click on Campaign
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("Landed on Mange Campaign Page");


                //2.Applied filter for Pending Status Campaign and verify landed page
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", "Approved");
                ManageCampaign.EnterFilterValues("Name", "Equal", CampaignName);               
                CreateCampaign.Campaign_Click_Filter_Apply_Button();


                //Click on List View Icon
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("Campaign diplayed in list view");

                //3.Hover Over for any Draft Status Campaign
                Helper.ScrollDown();
                ManageCampaign.Click_ManageCampaign_ListView_StatusArrow();
                ManageCampaign.VerifyApprovedByandApprovedOnFiled();
                Helper.IsElementDisplayed(PageObject_ManageCampaign.Check_ManageCampaign_cardView_Status_Schedule_button());
                Logger.WriteDebugMessage("Schedule button displayed");
            }
        }

        public static void TC_346055()
        {
            if (TestCaseId == Constants.TC_346055)
            {
                //Variables declaration and object creation
                string DefaultStatus , CampaignName, Commenttext;

                //Read the data
                DefaultStatus = "Rejected";
                Commenttext = "This is a Testing comment";
                CampaignName = TestData.ExcelData.TestDataReader.ReadData(1, "CampaignName");

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //1.Click on Campaign
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("Landed on Mange Campaign Page");

                //Click on List View Icon
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("Campaign diplayed in list view");

                //2.Applied filter for Pending Status Campaign and verify landed page
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", "Pending");
                ManageCampaign.EnterFilterValues("Name", "Equal", CampaignName);               
                CreateCampaign.Campaign_Click_Filter_Apply_Button();

                //3.Hover Over for any Draft Status Campaign
                ManageCampaign.Click_ManageCampaign_ListView_StatusArrow();
                Logger.WriteDebugMessage("Click on Pending status drop down");
                Helper.IsElementDisplayed(PageObject_CreateCampaign.RejectApproval__popUp_Reject_button());
                Logger.WriteDebugMessage("Reject Button displayed");
                Helper.IsElementDisplayed(PageObject_CreateCampaign.Campaign_Click_Approval_SendRequest_Approve_Button());
                Logger.WriteDebugMessage("Apptove Button displayed");

                //4.Verify title is displaying as Reject Approval
                CreateCampaign.RejectApproval__popUp_Reject_button();
                Logger.WriteDebugMessage("User should land on Reject Approval Pop up");

                //Verify title is displaying as Reject Approval
                Helper.VerifyTextOnPageAndHighLight("Reject Approval");
                Logger.WriteDebugMessage("Title displayed as:  Reject Approval");

                //Verify subtitle is displaying 
                Helper.VerifyTextOnPageAndHighLight("Please provide an explanation for rejecting this campaign.");
                Logger.WriteDebugMessage("Subtitle displayed correctly");
                Helper.IsElementDisplayed(PageObject_CreateCampaign.RejectApproval__popUp_Enter_text());

                //Again click on Reject from Reject Approval popup
                CreateCampaign.RejectApproval__popUp_Cancel_button();
                Logger.WriteDebugMessage("User landed on Mange campaign page");

                ManageCampaign.Click_ManageCampaign_ListView_StatusArrow();
                Logger.WriteDebugMessage("Click on Pending status drop down");
                CreateCampaign.RejectApproval__popUp_Reject_button();
                CreateCampaign.RejectApproval__popUp_Enter_text(Commenttext);
                //Again click on Reject from Reject Approval popup
                CreateCampaign.Campaign_Click_Approval_SendRequest_Reject_Button();
                Logger.WriteDebugMessage("Campaign get Rejected");

                //1.Click on Campaign
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("Landed on Mange Campaign Page");

                //2.Applied filter for Pending Status Campaign and verify landed page
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", "Rejected");
                ManageCampaign.EnterFilterValues("Name", "Equal", CampaignName);               
                CreateCampaign.Campaign_Click_Filter_Apply_Button();

                //Verify Campaign status
                string Campaign_Status = GetText(PageObject_ManageCampaign.Manage_Campaign_Cards_Status());
                Assert.IsTrue(Campaign_Status.Equals(DefaultStatus), "Campaign has Rejected Status as per applied filters.");
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("Campaign has Rejected Status as per applied filters.");
            }
        }

        public static void TC_346056()
        {
            if (TestCaseId == Constants.TC_346056)
            {
                //Variables declaration and object creation
                string DefaultStatus,CampaignName;

                //Read the data
                CampaignName = TestData.ExcelData.TestDataReader.ReadData(1, "CampaignName");
                DefaultStatus = "SCHEDULE INACTIVE";

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //1.Click on Campaign
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("Landed on Mange Campaign Page");

                //Click on List View Icon
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("Campaign diplayed in list view");

                //2.Applied filter for Schedule Active Status Campaign and verify landed page
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", "Scheduled Active");
                ManageCampaign.EnterFilterValues("Name", "Equal", CampaignName);               
                CreateCampaign.Campaign_Click_Filter_Apply_Button();

                //3.Hover Over for any Draft Status Campaign
                ManageCampaign.Click_ManageCampaign_ListView_StatusArrow();
                Helper.IsElementDisplayed(PageObject_CreateCampaign.Schedule_Campaign_details_Send_Field());
                Logger.WriteDebugMessage("Send Field displayed");
                Helper.IsElementDisplayed(PageObject_CreateCampaign.Schedule_Campaign_details_ScheduledBy_Field());
                Logger.WriteDebugMessage("Scheduled By_Field displayed");
                Helper.IsElementDisplayed(PageObject_ManageCampaign.Scheduled_Active_Edit_Button());
                Logger.WriteDebugMessage("Edit Button displayed");
                Helper.IsElementDisplayed(PageObject_ManageCampaign.Scheduled_Active_Deactivate_Button());
                Logger.WriteDebugMessage("Deactivate Button displayed");

                //Click on Edit button
                ManageCampaign.Scheduled_Active_Edit_Button();
                Helper.IsElementDisplayed(PageObject_CreateCampaign.Verify_SchedulePage_Schedule_Title());
                Logger.WriteDebugMessage("User should land on the schedule step for the campaign");

                //1.Click on Campaign
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("Landed on Mange Campaign Page");

                //Click on List View Icon
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("Campaign diplayed in list view");

                //Applied filter for Pending Status Campaign and verify landed page
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", "Scheduled Active");
                ManageCampaign.EnterFilterValues("Name", "Equal", CampaignName);               
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.Click_ManageCampaign_ListView_StatusArrow();
                ManageCampaign.Scheduled_Active_Deactivate_Button();

                //Click on Deactivate. Check below details
                Assert.IsTrue(Helper.IsElementDisplayed(PageObject_CreateCampaign.Deactivate_Schedule_Dialog_Contains_Title()), "Title: Deactivate schedule displayed");
                Assert.IsTrue(Helper.IsElementDisplayed(PageObject_CreateCampaign.Deactivate_Schedule_Dialog_Contains_Text()), "You can resume sending this campaign at any time. Displayed");
                Assert.IsTrue(Helper.IsElementDisplayed(PageObject_CreateCampaign.Deactivate_Schedule_Dialog_Contains_Cancel()),"Cancel button Displayed");
                Assert.IsTrue(Helper.IsElementDisplayed(PageObject_CreateCampaign.Deactivate_Schedule_Dialog_Contains_Deactivate()), "Deactivate button Displayed");

                //Click on Cancel button
                CreateCampaign.Deactivate_Schedule_Dialog_Contains_Cancel();
                Logger.WriteDebugMessage("Status will not get changed");

                //Click on Deactivate
                ManageCampaign.Click_ManageCampaign_ListView_StatusArrow();
                ManageCampaign.Scheduled_Active_Deactivate_Button();
                Logger.WriteDebugMessage("Click on Deactivate button");
                CreateCampaign.Deactivate_Schedule_Dialog_Contains_Deactivate();
                Logger.WriteDebugMessage("Click on Deactivate button");

                //Verify Campaign status
                Helper.ReloadPage();
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Equal", CampaignName);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.Click_ManageCampaign_ListView_StatusArrow();
                string Campaign_Status = GetText(PageObject_CreateCampaign.Schedule_Campaign_details_Status());
                Assert.IsTrue(Campaign_Status.Equals(DefaultStatus), "Campaign has Schedule Inactive Status.");
                Logger.WriteDebugMessage("Campaign has Schedule Inactive Status.");
            }
        }

        public static void TC_346057()
        {
            if (TestCaseId == Constants.TC_346057)
            {
                //Variables declaration and object creation
                string DefaultStatus,CampaignName;

                //Read the data
                CampaignName = TestData.ExcelData.TestDataReader.ReadData(1, "CampaignName");
                DefaultStatus = "SCHEDULE ACTIVE";

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //1.Click on Campaign
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("Landed on Mange Campaign Page");

                //Click on List View Icon
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("Campaign diplayed in list view");

                //2.Applied filter for Pending Status Campaign and verify landed page
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", "Scheduled Inactive");
                ManageCampaign.EnterFilterValues("Name", "Equal", CampaignName);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();

                //3.Hover Over for any Draft Status Campaign
                ManageCampaign.Click_ManageCampaign_ListView_StatusArrow();
                Helper.IsElementDisplayed(PageObject_CreateCampaign.Schedule_Campaign_details_Send_Field());
                Logger.WriteDebugMessage("Send Field displayed");
                Helper.IsElementDisplayed(PageObject_CreateCampaign.Schedule_Campaign_details_ScheduledBy_Field());
                Logger.WriteDebugMessage("Scheduled By_Field displayed");
                Helper.IsElementDisplayed(PageObject_ManageCampaign.Scheduled_Active_Edit_Button());
                Logger.WriteDebugMessage("Edit Button displayed");
                Helper.IsElementDisplayed(PageObject_CreateCampaign.Activate_Schedule_Dialog_Contains_Activate_Button());
                Logger.WriteDebugMessage("Activate Button displayed");

                //Click on Edit button
                ManageCampaign.Scheduled_Active_Edit_Button();
                Helper.IsElementDisplayed(PageObject_CreateCampaign.Campaign_Click_Approval_SendRequest_Button());
                Logger.WriteDebugMessage("User should land on the Approval Page");

                //1.Click on Campaign
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("Landed on Manage Campaign Page");

                //Click on List View Icon
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("Campaign diplayed in list view");

                //Applied filter for Pending Status Campaign and verify landed page
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", "Scheduled Inactive");
                ManageCampaign.EnterFilterValues("Name", "Equal", CampaignName);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.Click_ManageCampaign_ListView_StatusArrow();
                ManageCampaign.Scheduled_InActive_Activate_Button();

                //Click on Deactivate. Check below details
                Helper.IsElementDisplayed(PageObject_CreateCampaign.Deactivate_Schedule_Dialog_Contains_Cancel());
                Helper.IsElementDisplayed(PageObject_CreateCampaign.Activate_Schedule_Dialog_Contains_Activate_Button());

                //Click on Cancel button
                CreateCampaign.Deactivate_Schedule_Dialog_Contains_Cancel();
                Logger.WriteDebugMessage("Status will not get changed");

                //Click on Deactivate
                ManageCampaign.Click_ManageCampaign_ListView_StatusArrow();
                CreateCampaign.Schedule_Campaign_Activate_Button();
                Logger.WriteDebugMessage("Click on Activate button");
                CreateCampaign.Activate_Schedule_Dialog_Contains_Activate_Button();
                Logger.WriteDebugMessage("Click on Activate button");

                //Verify Campaign status
                Helper.ReloadPage();

                //Click on List View Icon
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("Campaign diplayed in list view");

                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Equal", CampaignName);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.Click_ManageCampaign_ListView_StatusArrow();
                string Campaign_Status = GetText(PageObject_CreateCampaign.Schedule_Campaign_details_Status());
                Assert.IsTrue(Campaign_Status.Equals(DefaultStatus), "Campaign has Schedule Inactive Status.");
                Logger.WriteDebugMessage("Campaign has Schedule Inactive Status.");
            }
        }

        public static void TC_346059()
        {
            if (TestCaseId == Constants.TC_346059)
            {
                //Variables declaration and object creation
                string CampaignName;
                string DefaultStatus = "Draft";

                //Read the data
                CampaignName = TestData.ExcelData.TestDataReader.ReadData(1, "CampaignName");

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //1.Click on Campaign
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("Landed on Mange Campaign Page");


                //2.Applied filter for Pending Status Campaign and verify landed page
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", "Draft");
                ManageCampaign.EnterFilterValues("Name", "Contains", CampaignName);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();

                //3.Hover Over for any Draft Status Campaign
                string Campaign_Status = GetText(PageObject_ManageCampaign.Manage_Campaign_Cards_Status());
                Assert.IsTrue(Campaign_Status.Equals(DefaultStatus), "Campaign has Schedule Draft Status.");
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("Campaign has Draft Status.");
            }
        }


        #endregion[TP_346034]
    }
}
