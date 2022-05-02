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
        #region[TP_330881]

        public static void TC_333349()
        {
            if (TestCaseId == Constants.TC_333349)
            {

                //Variables declaration and object creation
                string campaignName, subject, DefaultStatus;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                DefaultStatus = "Draft";

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //User lands on Campaign Selection page
                CreateCampaign.VerifyMarketingTabSelection();

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Add required details and click Continue
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("Click on Save and Continue button to save campaign details");
                Helper.WaitForAjaxControls(120);
                CreateCampaign.VerifyUserNavigatedOnTheAudience();
                Logger.WriteDebugMessage("User lands on Audience Card view");

                //Click on Campaign in Left Navigation Menu.
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("User lands on Manage Campaign page.");

                //Search Campaign Noted Down at the step 5.
                Helper.VerifyTextOnPage(campaignName);

                //Click on List View.
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("List View displayed.");

                //Apply filter for Name
                CreateCampaign.Verify_Apply_Filter_for_Name();

                //Apply filter for ID
                CreateCampaign.Verify_Apply_Filter_for_ID();

                //Verify Campaign status
                string Campaign_Status = GetText(PageObject_ManageCampaign.ManageCapaign_Status());
                Assert.IsTrue(Campaign_Status.Equals(DefaultStatus), "Campaign has Draft Status as per applied filters.");
                Logger.WriteDebugMessage("Campaign has Draft Status as per applied filters.");
            }
        }

        public static void TC_333350()
        {
            if (TestCaseId == Constants.TC_333350)
            {

                //Variables declaration and object creation
                string campaignName, subject, DefaultStatus, tmpDesignCardName;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "MA QA Test Campaign Template";
                DefaultStatus = "Pending";

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //User lands on Campaign Selection page
                CreateCampaign.VerifyMarketingTabSelection();

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Add required details and click Continue
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("Click on Save and Continue button to save campaign details");
                Helper.WaitForAjaxControls(120);
                CreateCampaign.VerifyUserNavigatedOnTheAudience();
                Logger.WriteDebugMessage("User lands on Audience Card view");

                //Select an Audience and click Continue
                CreateCampaign.SelectRandomAudienceCardFromFirstPage();
                CreateCampaign.ClickOnSaveAndContinue();

                //User lands on Audience Preview page
                CreateCampaign.VerifyUserNavigateToAudiencePreview();
                Logger.WriteDebugMessage("User lands on Audience Preview page");

                //Click Continue button
                CreateCampaign.ClickOnSaveAndContinue();

                //User lands on Design Card View
                CreateCampaign.VerifyUserNavigateToDesignCardView();
                Logger.WriteDebugMessage("User lands on Design Card View");

                //Verify Page Title matches same as Account Dropdown with "[Campaign Type] Campaign" above
                CreateCampaign.VerifyPageTitle("Cendyn | Edit Campaign | Design");
                Logger.WriteInfoMessage("Page Title matches same as Account Dropdown with 'Cendyn | Edit Campaign | Design' above");

                //Verify Step Component shows Audience with check mark and Design as selected
                CreateCampaign.VrifyAudienceChecked();
                CreateCampaign.VerifyDesignHighlighted();
                Logger.WriteDebugMessage("Step Component shows Audience with check mark and Design as selected");


                //Click on a design
                CreateCampaign.SelectGivenDesignCard(tmpDesignCardName);
                CreateCampaign.VerifyCorrectDesignCardSelected(tmpDesignCardName);
                Logger.WriteDebugMessage("Clicking on an design selects the design and highlights with a border");

                //Click on Save and Continue.
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("User lands on Design page.");

                //Click on Save and Continue.
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("User lands on Design page.");

                //Click on Send Request.
                CreateCampaign.Campaign_Click_Approval_SendRequest_Button();
                Logger.WriteDebugMessage("Approval Card should get displayed.");

                //Click on Campaign in Left Navigation Menu.
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("User lands on Manage Campaign page.");

                //Search Campaign Noted Down at the step 5.
                Helper.VerifyTextOnPage(campaignName);

                //Click on List View.
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("List View displayed.");

                //Apply Filters for Name
                CreateCampaign.Verify_Apply_Filter_for_Name();

                //Apply Filters for ID
                CreateCampaign.Verify_Apply_Filter_for_ID();

                //Apply Filters for Audience
                CreateCampaign.Verify_Apply_Filter_for_Audience();

                 //Verify Campaign status
                 string Campaign_Status = GetText(PageObject_ManageCampaign.ManageCapaign_Status());
                 Assert.IsTrue(Campaign_Status.Equals(DefaultStatus), "Campaign has Pending Status as per applied filters.");
                 Logger.WriteDebugMessage("Campaign has Pending Status as per applied filters.");
            }
        }

        public static void TC_333351()
        {
            if (TestCaseId == Constants.TC_333351)
            {

                //Variables declaration and object creation
                string campaignName, subject, DefaultStatus, tmpDesignCardName;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "MA QA Test Campaign Template";
                DefaultStatus = "Approved";

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //User lands on Campaign Selection page
                CreateCampaign.VerifyMarketingTabSelection();

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Add required details and click Continue
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("Click on Save and Continue button to save campaign details");
                Helper.WaitForAjaxControls(120);
                CreateCampaign.VerifyUserNavigatedOnTheAudience();
                Logger.WriteDebugMessage("User lands on Audience Card view");

                //Select an Audience and click Continue
                CreateCampaign.SelectRandomAudienceCardFromFirstPage();
                CreateCampaign.ClickOnSaveAndContinue();

                //User lands on Audience Preview page
                CreateCampaign.VerifyUserNavigateToAudiencePreview();
                Logger.WriteDebugMessage("User lands on Audience Preview page");

                //Click Continue button
                CreateCampaign.ClickOnSaveAndContinue();

                //User lands on Design Card View
                CreateCampaign.VerifyUserNavigateToDesignCardView();
                Logger.WriteDebugMessage("User lands on Design Card View");

                //Verify Page Title matches same as Account Dropdown with "[Campaign Type] Campaign" above
                CreateCampaign.VerifyPageTitle("Cendyn | Edit Campaign | Design");
                Logger.WriteInfoMessage("Page Title matches same as Account Dropdown with 'Cendyn | Edit Campaign | Design' above");

                //Verify Step Component shows Audience with check mark and Design as selected
                CreateCampaign.VrifyAudienceChecked();
                CreateCampaign.VerifyDesignHighlighted();
                Logger.WriteDebugMessage("Step Component shows Audience with check mark and Design as selected");

                //Click on a design
                CreateCampaign.SelectGivenDesignCard(tmpDesignCardName);
                CreateCampaign.VerifyCorrectDesignCardSelected(tmpDesignCardName);
                Logger.WriteDebugMessage("Clicking on an design selects the design and highlights with a border");

                //Click on Save and Continue.
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("User lands on Design page.");

                //Click on Save and Continue.
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("User lands on Design page.");

                //Click on Send Request.
                CreateCampaign.ClickOnSelfApproveButton();
                Logger.WriteDebugMessage("Schedule Campaign Card page should get displayed.");

                //Click on Campaign in Left Navigation Menu.
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("User lands on Manage Campaign page.");

                //Search Campaign Noted Down at the step 5.
                Helper.VerifyTextOnPage(campaignName);

                //Click on List View.
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("List View displayed.");

                //Apply filter for Name
                CreateCampaign.Verify_Apply_Filter_for_Name();

                //Apply filter for ID
                CreateCampaign.Verify_Apply_Filter_for_ID();

                //Apply filter for Audience
                CreateCampaign.Verify_Apply_Filter_for_Audience();

                //Verify Campaign status
                string Campaign_Status = GetText(PageObject_ManageCampaign.ManageCapaign_Status());
                Assert.IsTrue(Campaign_Status.Equals(DefaultStatus), "Campaign has Approved Status as per applied filters.");
                Logger.WriteDebugMessage("Campaign has Approved Status as per applied filters.");
            }
        }

        public static void TC_333352()
        {
            if (TestCaseId == Constants.TC_333352)
            {

                //Variables declaration and object creation
                string campaignName, subject, DefaultStatus, tmpDesignCardName;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "MA QA Test Campaign Template";
                DefaultStatus = "Scheduled";

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //User lands on Campaign Selection page
                CreateCampaign.VerifyMarketingTabSelection();

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Add required details and click Continue
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("Click on Save and Continue button to save campaign details");
                Helper.WaitForAjaxControls(120);
                CreateCampaign.VerifyUserNavigatedOnTheAudience();
                Logger.WriteDebugMessage("User lands on Audience Card view");

                //Select an Audience and click Continue
                CreateCampaign.SelectRandomAudienceCardFromFirstPage();
                CreateCampaign.ClickOnSaveAndContinue();

                //User lands on Audience Preview page
                CreateCampaign.VerifyUserNavigateToAudiencePreview();
                Logger.WriteDebugMessage("User lands on Audience Preview page");

                //Click Continue button
                CreateCampaign.ClickOnSaveAndContinue();

                //User lands on Design Card View
                CreateCampaign.VerifyUserNavigateToDesignCardView();
                Logger.WriteDebugMessage("User lands on Design Card View");

                //Verify Page Title matches same as Account Dropdown with "[Campaign Type] Campaign" above
                CreateCampaign.VerifyPageTitle("Cendyn | Edit Campaign | Design");
                Logger.WriteInfoMessage("Page Title matches same as Account Dropdown with 'Cendyn | Edit Campaign | Design' above");

                //Verify Step Component shows Audience with check mark and Design as selected
                CreateCampaign.VrifyAudienceChecked();
                CreateCampaign.VerifyDesignHighlighted();
                Logger.WriteDebugMessage("Step Component shows Audience with check mark and Design as selected");


                //Click on a design
                CreateCampaign.SelectGivenDesignCard(tmpDesignCardName);
                CreateCampaign.VerifyCorrectDesignCardSelected(tmpDesignCardName);
                Logger.WriteDebugMessage("Clicking on an design selects the design and highlights with a border");

                //Click on Save and Continue.
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("User lands on Design page.");

                //Click on Save and Continue.
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("User lands on Design page.");

                //Click on Send Request.
                CreateCampaign.ClickOnSelfApproveButton();
                Logger.WriteDebugMessage("Schedule Campaign Card page should get displayed.");

                //Select Send ddm option from Drop-Down - Once.
                CreateCampaign.Click_design_SelfApprove_Send_DDL();
                string selectionOnce = "Once";
                IList<IWebElement> Send_list = Helper.Driver.FindElements(By.XPath("//div[@class='e-ddl e-popup e-lib e-control e-popup-open']/descendant::li"));
                foreach (var item in Send_list)
                {
                    if (item.Text.Trim().Equals(selectionOnce))
                    {
                        item.Click();
                        break;
                    }
                }

                //Select Time Zone
                CreateCampaign.Click_design_SelfApprove_TimeZone_DDL();
                string selectionZone = "Acre Time (ACT)";
                IList<IWebElement> TimeZone = Helper.Driver.FindElements(By.XPath("//div[@class='e-ddl e-popup e-lib e-control e-popup-open']/descendant::li"));
                foreach (var item in TimeZone)
                {
                    if (item.Text.Trim().Equals(selectionZone))
                    {
                        item.Click();
                        break;
                    }
                }

                //Click on Finish.
                CreateCampaign.ClickOnFinishButton();
                Logger.WriteDebugMessage("Campaign get scheduled.");

                //Click on Campaign in Left Navigation Menu.
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("User lands on Manage Campaign page.");

                //Search Campaign Noted Down at the step 5.
                Helper.VerifyTextOnPage(campaignName);

                //Click on List View.
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("List View displayed.");

                //Apply Filter for Name
                CreateCampaign.Verify_Apply_Filter_for_Name();

                //Apply Filter for ID
                CreateCampaign.Verify_Apply_Filter_for_ID();

                //Apply Filter for Audience
                CreateCampaign.Verify_Apply_Filter_for_Audience();

                //Verify Campaign status
                string Campaign_Status = GetText(PageObject_ManageCampaign.ManageCapaign_Status());
                Assert.IsTrue(Campaign_Status.Equals(DefaultStatus), "Campaign has Scheduled Status as per applied filters.");
                Logger.WriteDebugMessage("Campaign has Scheduled Status as per applied filters.");
            }
        }       

        public static void TC_333354()
        {
            if (TestCaseId == Constants.TC_333354)
            {

                //Variables declaration and object creation
                string campaignName, subject, DefaultStatus, tmpDesignCardName, Commenttext;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "MA QA Test Campaign Template";
                DefaultStatus = "Rejected";
                Commenttext = "This is a Testing comment";

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //User lands on Campaign Selection page
                CreateCampaign.VerifyMarketingTabSelection();

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Add required details and click Continue
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("Click on Save and Continue button to save campaign details");
                Helper.WaitForAjaxControls(120);
                CreateCampaign.VerifyUserNavigatedOnTheAudience();
                Logger.WriteDebugMessage("User lands on Audience Card view");

                //Select an Audience and click Continue
                CreateCampaign.SelectRandomAudienceCardFromFirstPage();
                CreateCampaign.ClickOnSaveAndContinue();

                //User lands on Audience Preview page
                CreateCampaign.VerifyUserNavigateToAudiencePreview();
                Logger.WriteDebugMessage("User lands on Audience Preview page");

                //Click Continue button
                CreateCampaign.ClickOnSaveAndContinue();

                //User lands on Design Card View
                CreateCampaign.VerifyUserNavigateToDesignCardView();
                Logger.WriteDebugMessage("User lands on Design Card View");

                //Verify Page Title matches same as Account Dropdown with "[Campaign Type] Campaign" above
                CreateCampaign.VerifyPageTitle("Cendyn | Edit Campaign | Design");
                Logger.WriteInfoMessage("Page Title matches same as Account Dropdown with 'Cendyn | Edit Campaign | Design' above");

                //Verify Step Component shows Audience with check mark and Design as selected
                CreateCampaign.VrifyAudienceChecked();
                CreateCampaign.VerifyDesignHighlighted();
                Logger.WriteDebugMessage("Step Component shows Audience with check mark and Design as selected");


                //Click on a design
                CreateCampaign.SelectGivenDesignCard(tmpDesignCardName);
                CreateCampaign.VerifyCorrectDesignCardSelected(tmpDesignCardName);
                Logger.WriteDebugMessage("Clicking on an design selects the design and highlights with a border");

                //Click on Save and Continue.
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("User lands on Design page.");

                //Click on Save and Continue.
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("User lands on Design page.");

                //Click on Send Request.
                CreateCampaign.Campaign_Click_Approval_SendRequest_Button();
                Logger.WriteDebugMessage("Approval Card should get displayed.");

                //Click on Reject.
                CreateCampaign.Campaign_Click_Approval_SendRequest_Reject_Button();
                Logger.WriteDebugMessage("Reject Approval Modal should get opened.");

                //Enter comment
                CreateCampaign.RejectApproval__popUp_Enter_text(Commenttext);

                //Again click on Reject from Reject Approval popup
                CreateCampaign.RejectApproval__popUp_Reject_button();

                //Click on Campaign in Left Navigation Menu.
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("User lands on Manage Campaign page.");
               
                //Search Campaign Noted Down at the step 5.
                Helper.VerifyTextOnPage(campaignName);

                //Click on List View.
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("List View displayed.");

                //Apply Filter for Name
                CreateCampaign.Verify_Apply_Filter_for_Name();

                //Apply Filter for Name
                CreateCampaign.Verify_Apply_Filter_for_ID();

                //Apply Filter for Name
                CreateCampaign.Verify_Apply_Filter_for_Audience();

                //Verify Campaign status
                string Campaign_Status = GetText(PageObject_ManageCampaign.ManageCapaign_Status());
                Assert.IsTrue(Campaign_Status.Equals(DefaultStatus), "Campaign has Rejected Status as per applied filters.");
                Logger.WriteDebugMessage("Campaign has Rejected Status as per applied filters.");

            }
        }

        #endregion[TP_332222]
    }
}
