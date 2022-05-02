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
                //tmpDesignCardName = "Test PC - Template";
                tmpDesignCardName = "Template_Create Camp";
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
                tmpDesignCardName = "Template_Create Camp";
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
                tmpDesignCardName = "Template_Create Camp";
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
                tmpDesignCardName = "Template_Create Camp";
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

        public static void TC_333358()
        {
            if (TestCaseId == Constants.TC_333358)
            {
                
                //Step 1: Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                String ID = GetText(PageObject_ManageCampaign.CardView_Campaign_ID());

                //Step 2 & 3: User is selecting View Detils from ellipse of card on Manage Campaign page
                ManageCampaign.Click_ManageCampaign_Ellipse();
                ManageCampaign.Click_ManageCampaign_Ellipse_ViewDetails();
                Logger.WriteDebugMessage("User lands on Campaign Summary page.");

                //Verify Summary Detail of Campaign.
                string Subject1 = GetText(PageObject_ManageCampaign.Click_ManageCampaign_Ellipse_ViewDetails_Subject());

                //Click on Campaign in Left Navigation Menu.
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("User lands on Manage Campaign page.");

                //Click on Filter.
                CreateCampaign.Campaign_Click_Filter();
                Logger.WriteDebugMessage("Filter Pop-up Modal should get opened.");

                //Click on Name Filter Drop-Down and Select Equal ddm.
                AddDelay(10000);
                CreateCampaign.Campaign_Click_Filter_ID_ddL();
                string selectionValue = "Equal";
                IList<IWebElement> list = Helper.Driver.FindElements(By.XPath("//div[@class='e-ddl e-popup e-lib e-control e-popup-open']/descendant::li"));
                foreach (var item in list)
                {
                    if (item.Text.Trim().Equals(selectionValue))
                    {
                        item.Click();
                        break;
                    }
                }

                //Enter Campaign Noted Down at the step 5.
                CreateCampaign.Campaign_Filter_Enter_ID(ID);
                Logger.WriteDebugMessage("Enter Campaign ID as " + ID);

                //Click on Apply.
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                Logger.WriteDebugMessage("Clone Campaign displayed as per the applied filter for Name");

                //Step 2 & 3: User is selecting View Detils from ellipse of card on Manage Campaign page
                ManageCampaign.Click_ManageCampaign_Ellipse();
                ManageCampaign.Click_ManageCampaign_Ellipse_ViewDetails();
                Logger.WriteDebugMessage("User lands on Campaign Summary page.");

                //Verify Campaign Subject
                string Subject2 = GetText(PageObject_ManageCampaign.Click_ManageCampaign_Ellipse_ViewDetails_Subject());
                Assert.IsTrue(Subject1.Equals(Subject2), "Summary Overview of Campaign should get displayed.");
                Logger.WriteDebugMessage("Summary Overview of Campaign get displayed.");
            }
        }    

        public static void TC_333356()
        {
            if (TestCaseId == Constants.TC_333356)
            {

                //Variables declaration and object creation
                string suffixClone, titleCampaignName, campaignID, cloneCampaignName;
                string[] campaignDetails = new string[2];
                string[] campaignFilterDetails = new string[2];

                //Read the data
                suffixClone = TestData.ExcelData.TestDataReader.ReadData(1, "suffixClone");


                //Step 1: Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //User is getting text of Title of Campaign card
                campaignDetails = CreateCampaign.getTitleAndIdOfCampaignCardRandom();
                titleCampaignName = campaignDetails[0];
                campaignID = campaignDetails[1];

                //Step 2 & 3: User is selecting clone from ellipse of card on Manage Campaign page
                CreateCampaign.ClickOnCamapignCardEllipseClone(campaignID);

                //Step 4: Verify suffix and pre-populated data in Campaign name field and Click on Save and Continue of Setting page
                cloneCampaignName = CreateCampaign.VerifySuffixAndPrepopulatedDataOnCampaignName(titleCampaignName, suffixClone);
                CreateCampaign.ClickOnSaveAndContinue();

                //Step 5: Click Campaign Left Navigation Tab
                Navigation.ClickOnSidebarCampaigns();
                WaitForAjaxControls(90);

                //Click on List View.
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("List View displayed.");

                //Search Clone Campaign
                Helper.VerifyTextOnPage(cloneCampaignName);

                //Click on Filter.
                CreateCampaign.Campaign_Click_Filter();
                Logger.WriteDebugMessage("Filter Pop-up Modal should get opened.");

                //Click on Name Filter Drop-Down and Select Equal ddm.
                AddDelay(10000);
                CreateCampaign.Campaign_Click_Filter_Name_ddL();
                string selectionValue = "Equal";
                IList<IWebElement> list = Helper.Driver.FindElements(By.XPath("//div[@class='e-ddl e-popup e-lib e-control e-popup-open']/descendant::li"));
                foreach (var item in list)
                {
                    if (item.Text.Trim().Equals(selectionValue))
                    {
                        item.Click();
                        break;
                    }
                }

                //Enter Campaign Noted Down at the step 5.
                CreateCampaign.Campaign_Click_Filter_Name_Enter_CampaignName(cloneCampaignName);
                Logger.WriteDebugMessage("Enter Campaign Name as " + cloneCampaignName);

                //Click on Apply.
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                Logger.WriteDebugMessage("Clone Campaign displayed as per the applied filter for Name");


            }
        }

        public static void TC_333369()
        {
            if (TestCaseId == Constants.TC_333369)
            {

                //Variables declaration and object creation
                string suffixClone, titleCampaignName, campaignID, cloneCampaignName;
                string[] campaignDetails = new string[2];
                string[] campaignFilterDetails = new string[2];

                //Read the data
                suffixClone = TestData.ExcelData.TestDataReader.ReadData(1, "suffixClone");


                //Step 1: Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on Automated
                ManageCampaign.ClickOnAutomatedToggle();
                Logger.WriteDebugMessage("User lands on Automated Campaign Page.");

                //User is getting text of Title of Campaign card
                campaignDetails = CreateCampaign.getTitleAndIdOfCampaignCardRandom();
                titleCampaignName = campaignDetails[0];
                campaignID = campaignDetails[1];

                //Step 2 & 3: User is selecting clone from ellipse of card on Manage Campaign page
                CreateCampaign.ClickOnCamapignCardEllipseClone(campaignID);

                //Step 4: Verify suffix and pre-populated data in Campaign name field and Click on Save and Continue of Setting page
                cloneCampaignName = CreateCampaign.VerifySuffixAndPrepopulatedDataOnCampaignName(titleCampaignName, suffixClone);
                CreateCampaign.ClickOnSaveAndContinue();

                //Step 5: Click Campaign Left Navigation Tab
                Navigation.ClickOnSidebarCampaigns();
                WaitForAjaxControls(90);

                //Click on List View.
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("List View displayed.");

                //Search Clone Campaign
                Helper.VerifyTextOnPage(cloneCampaignName);

                //Click on Filter.
                CreateCampaign.Campaign_Click_Filter();
                Logger.WriteDebugMessage("Filter Pop-up Modal should get opened.");

                //Click on Name Filter Drop-Down and Select Equal ddm.
                AddDelay(10000);
                CreateCampaign.Campaign_Click_Filter_Name_ddL();
                string selectionValue = "Equal";
                IList<IWebElement> list = Helper.Driver.FindElements(By.XPath("//div[@class='e-ddl e-popup e-lib e-control e-popup-open']/descendant::li"));
                foreach (var item in list)
                {
                    if (item.Text.Trim().Equals(selectionValue))
                    {
                        item.Click();
                        break;
                    }
                }

                //Enter Campaign Noted Down at the step 5.
                CreateCampaign.Campaign_Click_Filter_Name_Enter_CampaignName(cloneCampaignName);
                Logger.WriteDebugMessage("Enter Campaign Name as " + cloneCampaignName);

                //Click on Apply.
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                Logger.WriteDebugMessage("Clone Campaign displayed as per the applied filter for Name");


            }
        }

        public static void TC_333371()
        {
            if (TestCaseId == Constants.TC_333371)
            {

                //Step 1: Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on Automate Toggle button
                ManageCampaign.Automated_Toggle_Button();
                Logger.WriteDebugMessage("Automated Campaign displayed");

                String ID = GetText(PageObject_ManageCampaign.CardView_Campaign_ID());

                //Step 2 & 3: User is selecting View Detils from ellipse of card on Manage Campaign page
                ManageCampaign.Click_ManageCampaign_Ellipse();
                ManageCampaign.Click_ManageCampaign_Ellipse_ViewDetails();
                Logger.WriteDebugMessage("User lands on Campaign Summary page.");

                //Verify Summary Detail of Campaign.
                string Subject1 = GetText(PageObject_ManageCampaign.Click_ManageCampaign_Ellipse_ViewDetails_Subject());

                //Click on Campaign in Left Navigation Menu.
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("User lands on Manage Campaign page.");

                //Click on Filter.
                CreateCampaign.Campaign_Click_Filter();
                Logger.WriteDebugMessage("Filter Pop-up Modal should get opened.");

                //Click on Name Filter Drop-Down and Select Equal ddm.
                AddDelay(10000);
                CreateCampaign.Campaign_Click_Filter_ID_ddL();
                string selectionValue = "Equal";
                IList<IWebElement> list = Helper.Driver.FindElements(By.XPath("//div[@class='e-ddl e-popup e-lib e-control e-popup-open']/descendant::li"));
                foreach (var item in list)
                {
                    if (item.Text.Trim().Equals(selectionValue))
                    {
                        item.Click();
                        break;
                    }
                }

                //Enter Campaign Noted Down at the step 5.
                CreateCampaign.Campaign_Filter_Enter_ID(ID);
                Logger.WriteDebugMessage("Enter Campaign ID as " + ID);

                //Click on Apply.
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                Logger.WriteDebugMessage("Clone Campaign displayed as per the applied filter for Name");

                //Step 2 & 3: User is selecting View Detils from ellipse of card on Manage Campaign page
                ManageCampaign.Click_ManageCampaign_Ellipse();
                ManageCampaign.Click_ManageCampaign_Ellipse_ViewDetails();
                Logger.WriteDebugMessage("User lands on Campaign Summary page.");

                //Verify Campaign Subject
                string Subject2 = GetText(PageObject_ManageCampaign.Click_ManageCampaign_Ellipse_ViewDetails_Subject());
                Assert.IsTrue(Subject1.Equals(Subject2), "Summary Overview of Campaign should get displayed.");
                Logger.WriteDebugMessage("Summary Overview of Campaign get displayed.");
            }
        }

        public static void TC_333357()
        {
            if (TestCaseId == Constants.TC_333357)
            {
                //Variables declaration and object creation
                string campaignName, subject, DefaultStatus, tmpDesignCardName;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "Test PC - Template";
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
                CreateCampaign.Campaign_Click_Approval_SendRequest_Button();
                Logger.WriteDebugMessage("Approval Card should get displayed.");

                //Click on Campaign in Left Navigation Menu.
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("User lands on Manage Campaign page.");


                //Click on Finish.
                CreateCampaign.ClickOnFinishButton();
                Logger.WriteDebugMessage("Campaign get scheduled.");

                //Click on Campaign in Left Navigation Menu.
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("User lands on Manage Campaign page.");

                String ID = GetText(PageObject_ManageCampaign.Campaign_ID());

                //Click on Filter.
                CreateCampaign.Campaign_Click_Filter();
                Logger.WriteDebugMessage("Filter Pop-up Modal should get opened.");

                //Click on Name Filter Drop-Down and Select Equal ddm.
                AddDelay(10000);
                CreateCampaign.Campaign_Click_Filter_ID_ddL();
                string selectionValue = "Equal";
                IList<IWebElement> list = Helper.Driver.FindElements(By.XPath("//div[@class='e-ddl e-popup e-lib e-control e-popup-open']/descendant::li"));
                foreach (var item in list)
                {
                    if (item.Text.Trim().Equals(selectionValue))
                    {
                        item.Click();
                        break;
                    }
                }

                //Enter Campaign Noted Down at the step 5.
                CreateCampaign.Campaign_Filter_Enter_ID(ID);
                Logger.WriteDebugMessage("Enter Campaign ID as " + ID);

                //Click on Apply.
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                Logger.WriteDebugMessage("Campaign displayed as per the applied filter for Name");

                //Step 2 & 3: User is selecting View Detils from ellipse of card on Manage Campaign page
                ManageCampaign.Click_ManageCampaign_Ellipse();
                ManageCampaign.Click_ManageCampaign_Ellipse_ViewDetails();
                Logger.WriteDebugMessage("User lands on Campaign Summary page.");

                //Verify Campaign Subject
                string Status = GetText(PageObject_ManageCampaign.CardView_Campaign_Status());
                Assert.IsTrue(Status.Equals(DefaultStatus), "Scheduled  Status Campaign should get displayed.");
                Logger.WriteDebugMessage("Scheduled  Status Campaign should get displayed.");
            }
        }

        public static void TC_333370()
        {
            if (TestCaseId == Constants.TC_333370)
            {

                //Step 1: Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on Automate Toggle button
                //ManageCampaign.Automated_Toggle_Button();
                //Logger.WriteDebugMessage("Automated Campaign displayed");

                String ID = GetText(PageObject_ManageCampaign.CardView_Campaign_ID());

                //Step 2 & 3: User is selecting View Detils from ellipse of card on Manage Campaign page
                ManageCampaign.Click_ManageCampaign_Ellipse();
                ManageCampaign.Click_ManageCampaign_Ellipse_Edit();
                Logger.WriteDebugMessage("User lands on Campaign Summary page.");

                //Verify Summary Detail of Campaign.
                string Subject1 = GetText(PageObject_ManageCampaign.Click_ManageCampaign_Ellipse_ViewDetails_Subject());

                //Click on Campaign in Left Navigation Menu.
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("User lands on Manage Campaign page.");

                //Click on Filter.
                CreateCampaign.Campaign_Click_Filter();
                Logger.WriteDebugMessage("Filter Pop-up Modal should get opened.");

                //Click on Name Filter Drop-Down and Select Equal ddm.
                AddDelay(10000);
                CreateCampaign.Campaign_Click_Filter_ID_ddL();
                string selectionValue = "Equal";
                IList<IWebElement> list = Helper.Driver.FindElements(By.XPath("//div[@class='e-ddl e-popup e-lib e-control e-popup-open']/descendant::li"));
                foreach (var item in list)
                {
                    if (item.Text.Trim().Equals(selectionValue))
                    {
                        item.Click();
                        break;
                    }
                }

                //Enter Campaign Noted Down at the step 5.
                CreateCampaign.Campaign_Filter_Enter_ID(ID);
                Logger.WriteDebugMessage("Enter Campaign ID as " + ID);

                //Click on Apply.
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                Logger.WriteDebugMessage("Clone Campaign displayed as per the applied filter for Name");

                //Step 2 & 3: User is selecting View Detils from ellipse of card on Manage Campaign page
                ManageCampaign.Click_ManageCampaign_Ellipse();
                ManageCampaign.Click_ManageCampaign_Ellipse_ViewDetails();
                Logger.WriteDebugMessage("User lands on Campaign Summary page.");

                //Verify Campaign Subject
                string Subject2 = GetText(PageObject_ManageCampaign.Click_ManageCampaign_Ellipse_ViewDetails_Subject());
                Assert.IsTrue(Subject1.Equals(Subject2), "Summary Overview of Campaign should get displayed.");
                Logger.WriteDebugMessage("Summary Overview of Campaign get displayed.");
            }
        }

        public static void TC_333362()
        {
            if (TestCaseId == Constants.TC_333362)
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

                //Click on Automated Campaign Tab.
                ManageCampaign.ClickOnAutomatedToggle();
                Logger.WriteDebugMessage("Automated Campaign tab selected");

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //Click on Automated Campaign Tab.
                CreateCampaign.Create_Campaign_Automated_Button();
                Logger.WriteDebugMessage("Automated Campaign tab selected");

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

        public static void TC_333363()
        {
            if (TestCaseId == Constants.TC_333363)
            {

                //Variables declaration and object creation
                string campaignName, subject, DefaultStatus, tmpDesignCardName;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "Test PC - Template";
                DefaultStatus = "Pending";

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on Automated Campaign Tab.
                ManageCampaign.ClickOnAutomatedToggle();
                Logger.WriteDebugMessage("Automated Campaign tab selected");

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //Click on Automated Campaign Tab.
                CreateCampaign.Create_Campaign_Automated_Button();
                Logger.WriteDebugMessage("Automated Campaign tab selected");


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

                //Verify Campaign status
                string Campaign_Status = GetText(PageObject_ManageCampaign.ManageCapaign_Status());
                Assert.IsTrue(Campaign_Status.Equals(DefaultStatus), "Campaign has Pending Status as per applied filters.");
                Logger.WriteDebugMessage("Campaign has Pending Status as per applied filters.");
            }
        }

        public static void TC_333364()
        {
            if (TestCaseId == Constants.TC_333364)
            {

                //Variables declaration and object creation
                string campaignName, subject, DefaultStatus, tmpDesignCardName;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "Test PC - Template";
                DefaultStatus = "Approved";

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on Automated Campaign Tab.
                ManageCampaign.ClickOnAutomatedToggle();
                Logger.WriteDebugMessage("Automated Campaign tab selected");

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //Click on Automated Campaign Tab.
                CreateCampaign.Create_Campaign_Automated_Button();
                Logger.WriteDebugMessage("Automated Campaign tab selected");

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

                //Verify Campaign status
                string Campaign_Status = GetText(PageObject_ManageCampaign.ManageCapaign_Status());
                Assert.IsTrue(Campaign_Status.Equals(DefaultStatus), "Campaign has Approved Status as per applied filters.");
                Logger.WriteDebugMessage("Campaign has Approved Status as per applied filters.");
            }
        }

        public static void TC_333365()
        {
            if (TestCaseId == Constants.TC_333365)
            {

                //Variables declaration and object creation
                string campaignName, subject, DefaultStatus, tmpDesignCardName;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "Test PC - Template";
                DefaultStatus = "Scheduled";

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on Automated Campaign Tab.
                ManageCampaign.ClickOnAutomatedToggle();
                Logger.WriteDebugMessage("Automated Campaign tab selected");

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //Click on Automated Campaign Tab.
                CreateCampaign.Create_Campaign_Automated_Button();
                Logger.WriteDebugMessage("Automated Campaign tab selected");

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

                //Verify Campaign status
                string Campaign_Status = GetText(PageObject_ManageCampaign.ManageCapaign_Status());
                Assert.IsTrue(Campaign_Status.Equals(DefaultStatus), "Campaign has Scheduled Status as per applied filters.");
                Logger.WriteDebugMessage("Campaign has Scheduled Status as per applied filters.");
            }
        }

        public static void TC_333367()
        {
            if (TestCaseId == Constants.TC_333367)
            {

                //Variables declaration and object creation
                string campaignName, subject, DefaultStatus, tmpDesignCardName, Commenttext;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "Test PC - Template";
                DefaultStatus = "Rejected";
                Commenttext = "This is a Testing comment";

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on Automated Campaign Tab.
                ManageCampaign.ClickOnAutomatedToggle();
                Logger.WriteDebugMessage("Automated Campaign tab selected");

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //Click on Automated Campaign Tab.
                CreateCampaign.Create_Campaign_Automated_Button();
                Logger.WriteDebugMessage("Automated Campaign tab selected");

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

                //Verify Campaign status
                string Campaign_Status = GetText(PageObject_ManageCampaign.ManageCapaign_Status());
                Assert.IsTrue(Campaign_Status.Equals(DefaultStatus), "Campaign has Rejected Status as per applied filters.");
                Logger.WriteDebugMessage("Campaign has Rejected Status as per applied filters.");

            }
        }

        public static void TC_335948()
        {
            if (TestCaseId == Constants.TC_335948)
            {
                //Variables declaration and object creation
                string TemplateHeaderColumn;

                //Read the data
                TemplateHeaderColumn = TestData.ExcelData.TestDataReader.ReadData(1, "TemplateHeaderColumn");

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on Campaign in Left Navigation Menu.
                Navigation.ClickOnSidebarTemplates();
                Logger.WriteDebugMessage("User lands on Manage Template page.");

                //Click on List View.
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("List View displayed.");

                //Validate the List View column names
                CreateTemplate.VerifyManageTemplateHeaderList(TemplateHeaderColumn);
            }
        }

        public static void TC_335946()
        {
            if (TestCaseId == Constants.TC_335946)
            {
                //Variables declaration and object creation
                string TemplateHeaderColumn;

                //Read the data
                TemplateHeaderColumn = TestData.ExcelData.TestDataReader.ReadData(1, "TemplateHeaderColumn");

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on Campaign in Left Navigation Menu.
                Navigation.ClickOnSidebarTemplates();
                Logger.WriteDebugMessage("User lands on Manage Template page.");

                //Click on  Ellipse > View Details.
                CreateTemplate.Click_TemplatePage_Ellipses();
                Logger.WriteDebugMessage("Click on Ellipse.");

                //Click on  Ellipse > View Details.
                CreateTemplate.Click_TemplatePage_Ellipses_ViewDetails();
                Logger.WriteDebugMessage("User lands on Template Summary page.");

                //Click on Summary Page > Campaign Tab
                CreateTemplate.Click_TemplatePage_Ellipses_ViewDetails_SummaryTab();
                Logger.WriteDebugMessage("Campaign Tab should get displayed.");

                //Validate the List View column names
                CreateTemplate.VerifyTemplateDetailsHeaderList(TemplateHeaderColumn);
            }
        }

        public static void TC_335945()
        {
            if (TestCaseId == Constants.TC_335945)
            {

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on Campaign in Left Navigation Menu.
                Navigation.ClickOnSidebarTemplates();
                Logger.WriteDebugMessage("User lands on Manage Template page.");

                //Click on  Ellipse 
                CreateTemplate.Click_TemplatePage_Ellipses();
                Logger.WriteDebugMessage("Click on Ellipse.");

                //Click on  Ellipse > View Details.
                CreateTemplate.Click_TemplatePage_Ellipses_ViewDetails();
                CreateTemplate.Click_TemplatePage_SummaryTab();

                //Click on Campaign in Left Navigation Menu.
                Navigation.ClickOnSidebarTemplates();
                Logger.WriteDebugMessage("User lands on Manage Template page.");

                //Click on List View
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("Campaign displayed in list view");

                //Click on Template Name.
                CreateTemplate.Click_ListView_FirstTemplate();
                Logger.WriteDebugMessage("Click on Template Name");

                //Verify Summary Page
                CreateTemplate.Click_TemplatePage_SummaryTab();

            }
        }

        public static void TC_335956()
        {
            if (TestCaseId == Constants.TC_335956)
            {

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on Campaign in Left Navigation Menu.
                Navigation.ClickOnSidebarAudience();
                Logger.WriteDebugMessage("User lands on Manage Audience page");

                //Click on View Detail < Ellipse or Audience Name.
                CreateAudience.Click_Audience_Name();

                //Verify Criteria tab on Summary Detail Page of Audience.
                CreateAudience.Verify_CriteriaTab_AudiencePage();
            }
        }

        public static void TC_335955()
        {
            if (TestCaseId == Constants.TC_335955)
            {
                //Variables declaration and object creation
                Campaign data = new Campaign();

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on Audience in Left Navigation Menu.
                Navigation.ClickOnSidebarAudience();
                Logger.WriteDebugMessage("User lands on Manage Audience page");

                //Validate Card View details
                String aName = GetText(PageObject_CreateAudience.Get_Audience_Name());
                String aStatus = GetText(PageObject_CreateAudience.Get_Audience_Status());
                String aTag = GetText(PageObject_CreateAudience.Get_Audience_Tag());
                String aUpdatedDate = GetText(PageObject_CreateAudience.Get_Audience_UpdatedDate());

                var UpdatedDate = Convert.ToDateTime(aUpdatedDate).ToString("yyyy-MM-dd");

                //Get connection string
                Queries.Audience_Card_View(data, aName);

                //Verify Audience Name
                Assert.IsTrue(aName.Equals(data.AudienceName), "Audience Name is present and matched with DB");
                Logger.WriteDebugMessage("Audience Name displayed As " + aName);

                //Verify Audience Tag
                Assert.IsTrue(aTag.Equals(data.AudienceTags), "Audience Tag is present and matched with DB");
                Logger.WriteDebugMessage("Audience Tag displayed As " + aTag);

                //Verify Audience Status
                Assert.IsTrue(aStatus.Equals(data.AudienceStatus), "Audience Status is present and matched with DB");
                Logger.WriteDebugMessage("Audience Status displayed As " + aStatus);

                //Verify Audience UpdateDate
                Assert.IsTrue(UpdatedDate.Contains(data.AudienceUpdateDate), "Audience UpdateDate is present and matched with DB");
                Logger.WriteDebugMessage("Audience UpdateDate displayed As " + aUpdatedDate);

            }
        }

        public static void TC_335938()
        {
            if (TestCaseId == Constants.TC_335938)
            {
                //Variables declaration and object creation
                Campaign data = new Campaign();

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on Template in Left Navigation Menu.
                Navigation.ClickOnSidebarTemplates();
                Logger.WriteDebugMessage("User lands on Template page");

                //Validate Card View.
                string TName = GetText(PageObject_ManageCampaign.Campaign_ID());

                //Get connection string
                Queries.Audience_Card_View(data, TName);
                string campID = GetText(PageObject_ManageCampaign.Campaign_ID());
                Assert.IsTrue(campID.Equals(data.CampaignId), "CampaignID is present and matched with DB");
                Logger.WriteDebugMessage("ID displayed As" + campID);

            }
        }


        public static void TC_333359()
        {
            if (TestCaseId == Constants.TC_333359)
            {
                //Step1: Navigate to Marketing Automation Front End and log in as valid user.
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation page.
                Navigation.Verify_LandsOnMAPage();

                //Step2: Verify Marketing Campaign Page.
                ManageCampaign.VerifyMarketingCampaignPage();
                Logger.WriteDebugMessage("User navigated to Marketing Campaign Page.");

                //Step3: Copy Campaign ID and Name.
                IList<string> step3Info = ManageCampaign.GetCampaignInfoFromPageByProvidingName("campaignName", null, "Id", null, null);
                Logger.WriteDebugMessage("Campaign ID and Name should get entered correctly.");
                //Step4: Click on ID Filter and Name Filter and enter data copied at step 3 
                // Click Apply.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("ID", "Equal", step3Info[1]);
                ManageCampaign.EnterFilterValues("Name", "Starts With", step3Info[0]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.VerifyFilterCampaignInfoOnPage(step3Info[0], null, step3Info[1], null, null);
                Logger.WriteDebugMessage("Campaign should get displayed with ID and Name.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                //Step5: Copy Campaign ID and Audience Name.
                IList<string> step5Info = ManageCampaign.GetCampaignInfoFromPageByProvidingName(null, "audienceName", "id", null, null);
                Logger.WriteDebugMessage("Campaign ID and Audience Name should get entered correctly.");

                //Step6: Click on ID Filter and Audience Name Filter and enter data copied at 5.
                //Click Apply.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("ID", "Equal", step5Info[1]);
                ManageCampaign.EnterFilterValues("Audience", "Starts With", step5Info[0]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.VerifyFilterCampaignInfoOnPage(null, step5Info[0], step5Info[1], null, null);
                Logger.WriteDebugMessage("Campaign should get displayed with ID and Audience Name.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                // Step7: Copy Campaign Name and Audience Name.
                IList<string> step7Info = ManageCampaign.GetCampaignInfoFromPageByProvidingName("campaignName", "audienceName", null, null, null);
                Logger.WriteDebugMessage("Campaign Name and Audience Name should get entered correctly.");

                //Step8:Click on Campaign Name Filter and Audience Name Filter and enter data copied at step 7
                //Click Apply.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Starts With", step7Info[0]);
                ManageCampaign.EnterFilterValues("Audience", "Starts With", step7Info[1]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.VerifyFilterCampaignInfoOnPage(step7Info[0], step7Info[1], null, null, null); ;
                Logger.WriteDebugMessage("Campaign should get displayed with Campaign Name and Audience Name.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderOnListView();
                // Step9: Copy Campaign Name and Status - Campaign.
                IList<string> step9Info = ManageCampaign.GetCampaignInfoFromPageByProvidingName("campaignName", null, null, "status", null);
                Logger.WriteDebugMessage("Campaign Name and Status should get entered correctly.");

                //Step10: Click on Name Filter and Status Filter and enter data copied at step 9.
                //Click Apply.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Starts With", step9Info[0]);
                ManageCampaign.EnterFilterValues("Status", "Equal", step9Info[1]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.VerifyFilterCampaignInfoOnPage(step9Info[0], null, null, step9Info[1], null); ;
                Logger.WriteDebugMessage("Campaign should get displayed with Campaign Name and Status.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                //step11:Click on Status Filter and Select any Status then click Apply.
                IList<string> step11Info = ManageCampaign.GetCampaignInfoFromPageByProvidingName(null, null, null, "status", null);
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", step11Info[0]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.VerifyFilterCampaignInfoOnPage(null, null, null, step11Info[0], null); ;
                Logger.WriteDebugMessage("Campaign should get displayed with Status Filter.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                // Step12: Copy Campaign Name, ID and Updated On - Equal Date.
                IList<string> step12Info = ManageCampaign.GetCampaignInfoFromPageByProvidingName("campaignName", null, "ID", null, "updatedOn");
                Logger.WriteDebugMessage("Campaign Name, ID and Updated On - Equal Date should get entered correctly.");

                //Step13: Click on Campaign Name , ID and Updated On -Equal Date Filter and enter data copied at step 12.
                //Click Apply.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Starts With", step12Info[0]);
                ManageCampaign.EnterFilterValues("ID", "Equal", step12Info[1]);
                ManageCampaign.EnterFilterValues("Updated On", "Equal", step12Info[2]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.VerifyFilterCampaignInfoOnPage(step12Info[0], null, step12Info[1], null, step12Info[2]); ;
                Logger.WriteDebugMessage("Campaign should get displayed with Campaign Name, ID and Equal Date.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                // Step14: Copy Campaign Name, ID , Updated On - Equal Date and Audience Name.
                IList<string> step14Info = ManageCampaign.GetCampaignInfoFromPageByProvidingName("campaignName", "audienceName", "ID", null, "updatedOn");
                Logger.WriteDebugMessage("Campaign Name, ID, Updated On - Equal Date and Audience Name should get entered correctly.");

                //Step15: Click on Campaign Name , ID and Updated On -Equal Date Filter and Audience Name and Enter data copied at step 14
                //Click Apply.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Starts With", step14Info[0]);
                ManageCampaign.EnterFilterValues("Audience", "Starts With", step14Info[1]);
                ManageCampaign.EnterFilterValues("ID", "Equal", step14Info[2]);
                ManageCampaign.EnterFilterValues("Updated On", "Equal", step14Info[3]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.VerifyFilterCampaignInfoOnPage(step14Info[0], step14Info[1], step14Info[2], null, step14Info[3]); ;
                Logger.WriteDebugMessage("Campaign should get displayed with Campaign Name, ID , Update On - Equal Date and Audience Name.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                //Step16: Click on Sort and Select ID with Drop-Down Option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("ID");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.VerifyCampaignOrderIDsDesc();
                Logger.WriteDebugMessage("Campaign should get displayed with ID option selected.");
                // Step:17 Click on Sort and Select Name with Drop-Down Option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("Name");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.VerifyCampaignListOrdersDesc("Name");
                Logger.WriteDebugMessage("Campaign should get displayed with Name option Selected.");

                //Steps 18: Click on Sort and Select Audience with Drop-Down Option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("Audience");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.VerifyCampaignListOrdersDesc("Audience");
                Logger.WriteDebugMessage("Campaign should get displayed with Audience option Selected.");

                //Steps 19: Click on Sort and Select Status with Drop-Down Option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("Status");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.VerifyCampaignListOrdersDesc("Status");
                Logger.WriteDebugMessage("Campaign should get displayed with Status option Selected.");

                //Steps 20: Click on Sort and Select Updated On with Drop-Down Option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("Updated On");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.VerifyCampaignListDateOrdersDesc();
                Logger.WriteDebugMessage("Campaign should get displayed with Updated On option Selected.");
            }
        }


        public static void TC_333360()
        {
            if (TestCaseId == Constants.TC_333360)
            {
                //Step1: Navigate to Marketing Automation Front End and log in as valid user.
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation page.
                Navigation.Verify_LandsOnMAPage();

                //Step2: Verify Marketing Campaign Page.
                ManageCampaign.VerifyMarketingCampaignPage();
                Logger.WriteDebugMessage("User navigated to Marketing Campaign Page.");

                //Step3: Click on List View.
                ManageCampaign.List_View();
                CreateCampaign.VerifyDesignListViewPage();
                Logger.WriteDebugMessage("List View should get displayed.");

                //Step4: Copy Campaign ID and Name.
                IList<string> step3Info = ManageCampaign.GetCampaignInfoFromPageByProvidingNameListView("campaignName", null, "Id", null, null);
                Logger.WriteDebugMessage("Campaign ID and Name should get entered correctly.");

                //Step5:Click on Filter.
                ManageCampaign.Campaign_Click_FilterAndVerifyPopup();
                Logger.WriteDebugMessage("Filter Pop-up Modal should get opened.");

                //Step6: Click on ID Filter and Name Filter and enter data.
                //Click Apply.Campaign ID and Name Noted Down at Step 4.
                ManageCampaign.EnterFilterValues("ID", "Equal", step3Info[1]);
                ManageCampaign.EnterFilterValues("Name", "Starts With", step3Info[0]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignInfoOnPageByProvidingNameListView(step3Info[0], null, step3Info[1], null, null);
                Logger.WriteDebugMessage("Campaign should get displayed with ID and Name Filter.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderOnListView();
                //Step7: Copy Campaign ID and Audience Name.
                IList<string> step7Info = ManageCampaign.GetCampaignInfoFromPageByProvidingNameListView(null, "audienceName", "id", null, null);
                Logger.WriteDebugMessage("Campaign ID and Audience Name should get entered correctly.");

                //Step8: Click on ID Filter and Audience Filter and enter data.
                //Click Apply.Campaign ID and Name Noted Down at Step 7
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("ID", "Equal", step7Info[1]);
                ManageCampaign.EnterFilterValues("Audience", "Starts With", step7Info[0]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignInfoOnPageByProvidingNameListView(null, step7Info[0], step7Info[1], null, null);
                Logger.WriteDebugMessage("Campaign should get displayed with ID and Audience Name.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderOnListView();
                // Step9: Copy Campaign Name and Audience Name.
                IList<string> step9Info = ManageCampaign.GetCampaignInfoFromPageByProvidingNameListView("campaignName", "audienceName", null, null, null);
                Logger.WriteDebugMessage("Campaign Name and Audience Name should get entered correctly.");

                //Step10:Click on Name Filter and Audience Filter and enter data.
                //Click Apply.Campaign ID and Name Noted Down at Step 9.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Starts With", step9Info[0]);
                ManageCampaign.EnterFilterValues("Audience", "Starts With", step9Info[1]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignInfoOnPageByProvidingNameListView(step9Info[0], step9Info[1], null, null, null); ;
                Logger.WriteDebugMessage("Campaign should get displayed with Name and Audience Filter.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderOnListView();
                // Step11: Copy Campaign Name and Status.
                IList<string> step11Info = ManageCampaign.GetCampaignInfoFromPageByProvidingNameListView("campaignName", null, null, "status", null);
                Logger.WriteDebugMessage("Campaign Name and Status should get entered correctly.");

                //Step12: Click on Name Filter and Status Filter and enter data.
                //Click Apply.Campaign ID and Name Noted Down at Step 11.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Starts With", step11Info[0]);
                ManageCampaign.EnterFilterValues("Status", "Contains", step11Info[1]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignInfoOnPageByProvidingNameListView(step11Info[0], null, null, step11Info[1], null); ;
                Logger.WriteDebugMessage("Campaign should get displayed with Campaign Name and Status.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderOnListView();
                //step13:Click on Status Filter and Select any Status then click Apply.
                IList<string> step13Info = ManageCampaign.GetCampaignInfoFromPageByProvidingNameListView(null, null, null, "status", null);
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", step13Info[0]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignInfoOnPageByProvidingNameListView(null, null, null, step13Info[0], null); 
                Logger.WriteDebugMessage("Campaign should get displayed with Status Filter.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderOnListView();
                // Step14: Copy Campaign Name, ID and Updated On-Equal Date.
                IList<string> step14Info = ManageCampaign.GetCampaignInfoFromPageByProvidingNameListView("campaignName", null, "ID", null, "updatedOn");
                Logger.WriteDebugMessage("Campaign Name, ID and Updated On-Equal Date should get entered correctly.");

                //Step15: Click on Name, ID and Updated On-Equal Date Filter and enter data.
                //Click Apply.Campaign ID and Name Noted Down at Step 14.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Starts With", step14Info[0]);
                ManageCampaign.EnterFilterValues("ID", "Equal", step14Info[1]);
                ManageCampaign.EnterFilterValues("Updated On", "Equal", step14Info[2]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignInfoOnPageByProvidingNameListView(step14Info[0], null, step14Info[1], null, step14Info[2]); ;
                Logger.WriteDebugMessage("Campaign should get displayed with Name, ID and Updated On-Equal Date Filter.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderOnListView();
                // Step16: Copy Campaign Name, ID, Updated On-Equal Date and Audience Name.
                IList<string> step16Info = ManageCampaign.GetCampaignInfoFromPageByProvidingNameListView("campaignName", "audienceName", "ID", null, "updatedOn");
                Logger.WriteDebugMessage("Campaign Name, ID, Updated On - Equal Date and Audience Name should get entered correctly.");

                //Step17: Click on Name, ID, Updated On-Equal Date and Audience Filter and enter data.
                //Click Apply.Campaign ID and Name Noted Down at Step 16.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Starts With", step16Info[0]);
                ManageCampaign.EnterFilterValues("Audience", "Starts With", step16Info[1]);
                ManageCampaign.EnterFilterValues("ID", "Equal", step16Info[2]);
                ManageCampaign.EnterFilterValues("Updated On", "Equal", step16Info[3]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.VerifyCampaignInfoOnPageByProvidingNameListView(step16Info[0], step16Info[1], step16Info[2], null, step16Info[3]); ;
                Logger.WriteDebugMessage("Campaign should get displayed with Campaign Name, ID , Update On - Equal Date and Audience Name.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                //Step18: Click on Sort and Select ID with Drop-Down option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("ID");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignSortBasedOnId();
                Logger.WriteDebugMessage("Campaign should get displayed with ID option selected.");
                // Step:19 Click on Sort and Select Name with Drop-Down option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("Name");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignSortBasedOnNameDesc();
                Logger.WriteDebugMessage("Campaign should get displayed with Name option selected.");

                //Steps 20: Click on Sort and Select Audience with Drop-Down option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("Audience");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignSortBasedOnAudienceDesc();
                Logger.WriteDebugMessage("Campaign should get displayed with Audience option selected.");

                //Steps 21:Click on Sort and Select Status with Drop-Down option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("Status");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignSortBasedOnStatuseDesc();
                Logger.WriteDebugMessage("Campaign should get displayed with Status option selected.");

                //Steps 22: Click on Sort and Select Updated On with Drop-Down option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("Updated On");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.WaitToHideLoaderOnListView();
                CreateCampaign.VerifyDefaultListBasedOnUpdatedOn();
                Logger.WriteDebugMessage("Campaign should get displayed with Update-On option selected.");
            }
        }

        public static void TC_333372()
        {
            if (TestCaseId == Constants.TC_333372)
            {
                //Step1: Navigate to Marketing Automation Front End and log in as valid user.
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation page.
                Navigation.Verify_LandsOnMAPage();

                //Step2: Click on Automated Campaign Tab.
                CreateCampaign.ToggletoAutomatedTtab();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyAutomatedPage();
                Logger.WriteDebugMessage("User lands on Automated Campaign Page.");

                //Step3: Copy Campaign ID and Name.
                IList<string> step3Info = ManageCampaign.GetCampaignInfoFromPageByProvidingName("campaignName", null, "Id", null, null);
                Logger.WriteDebugMessage("Campaign ID and Name should get entered correctly.");
                //Step4: Click on ID Filter and Name Filter and enter data copied at step 3 
                // Click Apply.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("ID", "Equal", step3Info[1]);
                ManageCampaign.EnterFilterValues("Name", "Starts With", step3Info[0]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyFilterCampaignInfoOnPage(step3Info[0], null, step3Info[1], null, null);
                Logger.WriteDebugMessage("Campaign should get displayed with ID and Name.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                //Step5: Copy Campaign ID 
                IList<string> step5Info = ManageCampaign.GetCampaignInfoFromPageByProvidingName(null, null, "id", null, null);
                Logger.WriteDebugMessage("Campaign ID should get entered correctly.");

                //Step6: Click on ID Filter Filter and enter data copied at 5.
                //Click Apply.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("ID", "Equal", step5Info[0]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyFilterCampaignInfoOnPage(null, null, step5Info[0], null, null);
                Logger.WriteDebugMessage("Campaign should get displayed with ID .");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                // Step7: Copy Campaign Name 
                IList<string> step7Info = ManageCampaign.GetCampaignInfoFromPageByProvidingName("campaignName", null, null, null, null);
                Logger.WriteDebugMessage("Campaign Name should get entered correctly.");

                //Step8:Click on Campaign Name Filter and enter data copied at step 7
                //Click Apply.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Starts With", step7Info[0]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyFilterCampaignInfoOnPage(step7Info[0], null, null, null, null); 
                Logger.WriteDebugMessage("Campaign should get displayed with Campaign Name ");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderOnListView();
                // Step9: Copy Campaign Name and Status - Campaign.
                IList<string> step9Info = ManageCampaign.GetCampaignInfoFromPageByProvidingName("campaignName", null, null, "status", null);
                Logger.WriteDebugMessage("Campaign Name and Status should get entered correctly.");

                //Step10: Click on Name Filter and Status Filter and enter data copied at step 9.
                //Click Apply.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Starts With", step9Info[0]);
                ManageCampaign.EnterFilterValues("Status", "Equal", step9Info[1]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyFilterCampaignInfoOnPage(step9Info[0], null, null, step9Info[1], null); 
                Logger.WriteDebugMessage("Campaign should get displayed with Campaign Name and Status.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderOnListView();
                //step11:Click on Status Filter and Select any Status then click Apply.
                IList<string> step11Info = ManageCampaign.GetCampaignInfoFromPageByProvidingName(null, null, null, "status", null);
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", step11Info[0]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyFilterCampaignInfoOnPage(null, null, null, step11Info[0], null); ;
                Logger.WriteDebugMessage("Campaign should get displayed with Status Filter.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderOnListView();
                // Step12: Copy Campaign Name, ID and Updated On - Equal Date.
                IList<string> step12Info = ManageCampaign.GetCampaignInfoFromPageByProvidingName("campaignName", null, "ID", null, "updatedOn");
                Logger.WriteDebugMessage("Campaign Name, ID and Updated On - Equal Date should get entered correctly.");

                //Step13: Click on Campaign Name , ID and Updated On -Equal Date Filter and enter data copied at step 12.
                //Click Apply.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Starts With", step12Info[0]);
                ManageCampaign.EnterFilterValues("ID", "Equal", step12Info[1]);
                ManageCampaign.EnterFilterValues("Updated On", "Equal", step12Info[2]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyFilterCampaignInfoOnPage(step12Info[0], null, step12Info[1], null, step12Info[2]); ;
                Logger.WriteDebugMessage("Campaign should get displayed with Campaign Name, ID and Equal Date.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderOnListView();
                // Step14: Copy Campaign Name, ID and Updated On - Equal Date .
                IList<string> step14Info = ManageCampaign.GetCampaignInfoFromPageByProvidingName("campaignName", null, "ID", null, "updatedOn");
                Logger.WriteDebugMessage("Campaign Name, ID and Updated On - Equal Date should get entered correctly.");

                //Step15: Click on Campaign Name , ID and Updated On -Equal Date Filter and Enter data copied at step 14
                //Click Apply.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Starts With", step14Info[0]);
                ManageCampaign.EnterFilterValues("ID", "Equal", step14Info[1]);
                ManageCampaign.EnterFilterValues("Updated On", "Equal", step14Info[2]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyFilterCampaignInfoOnPage(step14Info[0], null, step14Info[1], null, step14Info[2]); 
                Logger.WriteDebugMessage("Campaign should get displayed with Campaign Name, ID , Update On - Equal Date ");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                //Step16: Click on Sort and Select ID with Drop-Down Option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("ID");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.VerifyCampaignOrderIDsDesc();
                Logger.WriteDebugMessage("Campaign should get displayed with ID option selected.");
                // Step:17 Click on Sort and Select Name with Drop-Down Option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("Name");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.VerifyCampaignListOrdersDesc("Name");
                Logger.WriteDebugMessage("Campaign should get displayed with Name option Selected.");

                //Steps 18: Click on Sort and Select Status with Drop-Down Option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("Status");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.VerifyCampaignListOrdersDesc("Status");
                Logger.WriteDebugMessage("Campaign should get displayed with Status option Selected.");

                //Steps 19: Click on Sort and Select Updated On with Drop-Down Option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("Updated On");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.VerifyCampaignListDateOrdersDesc();
                Logger.WriteDebugMessage("Campaign should get displayed with Updated On option Selected.");
            }
        }

        public static void TC_333374()
        {
            if (TestCaseId == Constants.TC_333374)
            {
                //Step1: Navigate to Marketing Automation Front End and log in as valid user.
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation page.
                Navigation.Verify_LandsOnMAPage();

                //Step2: Click on Automated Campaign Tab.
                CreateCampaign.ToggletoAutomatedTtab();
                ManageCampaign.VerifyAutomatedPage();
                Logger.WriteDebugMessage("User lands on Automated Campaign Page.");

                //Step3: Click on List View.
                ManageCampaign.List_View();
                CreateCampaign.VerifyDesignListViewPage();
                Logger.WriteDebugMessage("List View should get displayed.");

                //Step4: Copy Campaign ID and Name.
                IList<string> step3Info = ManageCampaign.GetCampaignInfoFromPageByProvidingNameListView("campaignName", null, "Id", null, null);
                Logger.WriteDebugMessage("Campaign ID and Name should get entered correctly.");

                //Step5:Click on Filter.
                ManageCampaign.Campaign_Click_FilterAndVerifyPopup();
                Logger.WriteDebugMessage("Filter Pop-up Modal should get opened.");

                //Step6: Click on ID Filter and Name Filter and enter data.
                //Click Apply.Campaign ID and Name Noted Down at Step 4.
                ManageCampaign.EnterFilterValues("ID", "Equal", step3Info[1]);
                ManageCampaign.EnterFilterValues("Name", "Starts With", step3Info[0]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignInfoOnPageByProvidingNameListView(step3Info[0], null, step3Info[1], null, null);
                Logger.WriteDebugMessage("Campaign should get displayed with ID and Name Filter.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderOnListView();
                //Step7: Copy Campaign ID 
                IList<string> step7Info = ManageCampaign.GetCampaignInfoFromPageByProvidingNameListView(null, null, "id", null, null);
                Logger.WriteDebugMessage("Campaign ID should get entered correctly.");

                //Step8: Click on ID Filter Filter and enter data.
                //Click Apply.Campaign ID and Name Noted Down at Step 7
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("ID", "Equal", step7Info[0]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignInfoOnPageByProvidingNameListView(null, null, step7Info[0], null, null);
                Logger.WriteDebugMessage("Campaign should get displayed with ID .");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderOnListView();
                // Step9: Copy Campaign Name 
                IList<string> step9Info = ManageCampaign.GetCampaignInfoFromPageByProvidingNameListView("campaignName", null, null, null, null);
                Logger.WriteDebugMessage("Campaign Name should get entered correctly.");

                //Step10:Click on Name Filter  and enter data.
                //Click Apply.Campaign ID and Name Noted Down at Step 9.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Starts With", step9Info[0]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignInfoOnPageByProvidingNameListView(step9Info[0], null, null, null, null); ;
                Logger.WriteDebugMessage("Campaign should get displayed with Name  Filter.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderOnListView();
                // Step11: Copy Campaign Name and Status.
                IList<string> step11Info = ManageCampaign.GetCampaignInfoFromPageByProvidingNameListView("campaignName", null, null, "status", null);
                Logger.WriteDebugMessage("Campaign Name and Status should get entered correctly.");

                //Step12: Click on Name Filter and Status Filter and enter data.
                //Click Apply.Campaign ID and Name Noted Down at Step 11.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Starts With", step11Info[0]);
                ManageCampaign.EnterFilterValues("Status", "Contains", step11Info[1]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignInfoOnPageByProvidingNameListView(step11Info[0], null, null, step11Info[1], null); ;
                Logger.WriteDebugMessage("Campaign should get displayed with Campaign Name and Status.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderOnListView();
                //step13:Click on Status Filter and Select any Status then click Apply.
                IList<string> step13Info = ManageCampaign.GetCampaignInfoFromPageByProvidingNameListView(null, null, null, "status", null);
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Status", "Contains", step13Info[0]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignInfoOnPageByProvidingNameListView(null, null, null, step13Info[0], null); ;
                Logger.WriteDebugMessage("Campaign should get displayed with Status Filter.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderOnListView();
                // Step14: Copy Campaign Name, ID and Updated On-Equal Date.
                IList<string> step14Info = ManageCampaign.GetCampaignInfoFromPageByProvidingNameListView("campaignName", null, "ID", null, "updatedOn");
                Logger.WriteDebugMessage("Campaign Name, ID and Updated On-Equal Date should get entered correctly.");

                //Step15: Click on Name, ID and Updated On-Equal Date Filter and enter data.
                //Click Apply.Campaign ID and Name Noted Down at Step 14.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Starts With", step14Info[0]);
                ManageCampaign.EnterFilterValues("ID", "Equal", step14Info[1]);
                ManageCampaign.EnterFilterValues("Updated On", "Equal", step14Info[2]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignInfoOnPageByProvidingNameListView(step14Info[0], null, step14Info[1], null, step14Info[2]); ;
                Logger.WriteDebugMessage("Campaign should get displayed with Name, ID and Updated On-Equal Date Filter.");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderOnListView();
                // Step16: Copy Campaign Name, ID, Updated On-Equal Date 
                IList<string> step16Info = ManageCampaign.GetCampaignInfoFromPageByProvidingNameListView("campaignName", null, "ID", null, "updatedOn");
                Logger.WriteDebugMessage("Campaign Name, ID, Updated On - Equal Date should get entered correctly.");

                //Step17: Click on Name, ID, Updated On-Equal Date and Audience Filter and enter data.
                //Click Apply.Campaign ID and Name Noted Down at Step 16.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Starts With", step16Info[0]);
                ManageCampaign.EnterFilterValues("ID", "Equal", step16Info[1]);
                ManageCampaign.EnterFilterValues("Updated On", "Equal", step16Info[2]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.VerifyCampaignInfoOnPageByProvidingNameListView(step16Info[0], null, step16Info[1], null, step16Info[2]); 
                Logger.WriteDebugMessage("Campaign should get displayed with Campaign Name, ID , Update On - Equal Date ");

                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                //Step18: Click on Sort and Select ID with Drop-Down option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("ID");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignSortBasedOnId();
                Logger.WriteDebugMessage("Campaign should get displayed with ID option selected.");
                // Step:19 Click on Sort and Select Name with Drop-Down option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("Name");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignSortBasedOnNameDesc();
                Logger.WriteDebugMessage("Campaign should get displayed with Name option selected.");


                //Steps 20:Click on Sort and Select Status with Drop-Down option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("Status");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.WaitToHideLoaderOnListView();
                ManageCampaign.VerifyCampaignSortBasedOnStatuseDesc();
                Logger.WriteDebugMessage("Campaign should get displayed with Status option selected.");

                //Steps 21: Click on Sort and Select Updated On with Drop-Down option then click Apply.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.SelectSortType("Updated On");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.WaitToHideLoaderOnListView();
                CreateCampaign.VerifyDefaultListBasedOnUpdatedOn();
                Logger.WriteDebugMessage("Campaign should get displayed with Update-On option selected.");
            }
        }

        public static void TC_335957()
        {
            if (TestCaseId == Constants.TC_335957)
            {
                //Variables declaration and object creation
                string TemplateHeaderColumn;

                //Read the data
                TemplateHeaderColumn = TestData.ExcelData.TestDataReader.ReadData(1, "TemplateHeaderColumn");

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on Audience in Left Navigation Menu.
                Navigation.ClickOnSidebarAudience();
                Logger.WriteDebugMessage("User lands on Audience page.");

                //Click on  Ellipse > View Details.
                CreateTemplate.Click_TemplatePage_Ellipses();
                Logger.WriteDebugMessage("Click on Ellipse.");

                //Click on  Ellipse > View Details.
                CreateTemplate.Click_TemplatePage_Ellipses_ViewDetails();
                Logger.WriteDebugMessage("User lands on Audience Summary page.");

                //Click on Summary Page > Campaign Tab
                CreateAudience.Click_ManageAudience_CampaignTab();
                Logger.WriteDebugMessage("Campaign Tab should get displayed.");

                //Validate the List View column names
                CreateTemplate.VerifyTemplateDetailsHeaderList(TemplateHeaderColumn);
            }
        }

        public static void TC_335958()
        {
            if (TestCaseId == Constants.TC_335958)
            {
                //Variables declaration and object creation
                Campaign data = new Campaign();

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on Audience in Left Navigation Menu.
                Navigation.ClickOnSidebarAudience();
                Logger.WriteDebugMessage("User lands on Manage Audience page");

                //Validate Card View details
                String aName = GetText(PageObject_CreateAudience.Get_Audience_Name());
                String aStatus = GetText(PageObject_CreateAudience.Get_Audience_Status());
                String aTag = GetText(PageObject_CreateAudience.Get_Audience_Tag());
                String aUpdatedDate = GetText(PageObject_CreateAudience.Get_Audience_UpdatedDate());

                var UpdatedDate = Convert.ToDateTime(aUpdatedDate).ToString("yyyy-MM-dd");

                //Click on List View
                ManageCampaign.List_View();
                Logger.WriteDebugMessage("Campaign Displayed in List view");

                //Get connection string
                Queries.Audience_Card_View(data, aName);

                //Verify Audience Name
                Assert.IsTrue(aName.Equals(data.AudienceName), "Audience Name is present and matched with DB");
                Logger.WriteDebugMessage("Audience Name displayed As " + aName);

                //Verify Audience Tag
                Assert.IsTrue(aTag.Equals(data.AudienceTags), "Audience Tag is present and matched with DB");
                Logger.WriteDebugMessage("Audience Tag displayed As " + aTag);

                //Verify Audience Status
                Assert.IsTrue(aStatus.Equals(data.AudienceStatus), "Audience Status is present and matched with DB");
                Logger.WriteDebugMessage("Audience Status displayed As " + aStatus);

                //Verify Audience UpdateDate
                Assert.IsTrue(UpdatedDate.Contains(data.AudienceUpdateDate), "Audience UpdateDate is present and matched with DB");
                Logger.WriteDebugMessage("Audience UpdateDate displayed As " + aUpdatedDate);

            }
        }

        #endregion[TP_332222]
    }
}

