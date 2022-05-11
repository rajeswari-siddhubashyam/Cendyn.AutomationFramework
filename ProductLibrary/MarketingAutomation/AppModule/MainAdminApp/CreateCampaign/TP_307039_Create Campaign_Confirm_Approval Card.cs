using BaseUtility.Utility;
using InfoMessageLogger;
using MarketingAutomation.AppModule.MainAdminApp;
using MarketingAutomation.AppModule.UI;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestData;
using Constants = MarketingAutomation.Utility.Constants;

namespace MarketingAutomation.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region[TP_307039]

        public static void TC_307093()
        {
            if (TestCaseId == Constants.TC_307093)
            {

                //Variables declaration and object creation
                string campaignName, subject, tmpDesignCardName;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "Test PC - Template";

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
            }
        }

        public static void TC_307094()
        {
            if (TestCaseId == Constants.TC_307094)
            {

                //Variables declaration and object creation
                string campaignName, subject, tmpDesignCardName;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "Test PC - Template";

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
                Logger.WriteDebugMessage("User lands on Audience page.");

                //Click on Save and Continue.
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("User lands on Design page.");

                //Click Send Request in Approval Card.
                CreateCampaign.Campaign_Click_Approval_SendRequest_Button();
                Logger.WriteDebugMessage("User should navigate to Approval card.");

                //Title:-Approval 
                CreateCampaign.Verify_Approval_Card_Title();
                Logger.WriteDebugMessage("Approval is displayed in Title");

                //Text: -'Requested' with user image get displays.
                CreateCampaign.Verify_Approval_Card_Text();
                Logger.WriteDebugMessage("Requested is displayed for Text");

                //Buttons: Approve(Left aligned / Green) & Reject(Right aligned / Red)
                CreateCampaign.Verify_Approval_Left_Button();
                Logger.WriteDebugMessage("Approve is displayed in Left aligned button");
                CreateCampaign.Verify_Approval_Right_Button();
                Logger.WriteDebugMessage("Reject is displayed in Left aligned button");
            }
        }

        public static void TC_307095()
        {
            if (TestCaseId == Constants.TC_307095)
            {

                //Variables declaration and object creation
                string campaignName, subject, tmpDesignCardName;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "Test PC - Template";

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
                Logger.WriteDebugMessage("User lands on Audience page.");

                //Click on Save and Continue.
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("User lands on Design page.");

                //Validate Approval card contains
                CreateCampaign.Verify_Approval_Card_contain();
            }
        }

        public static void TC_307096()
        {
            if (TestCaseId == Constants.TC_307096)
            {

                //Variables declaration and object creation
                string campaignName, subject, tmpDesignCardName;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "Test PC - Template";

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
                Logger.WriteDebugMessage("User lands on Audience page.");

                //Click on Save and Continue.
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("User lands on Design page.");

                //Validate Approval card contains
                CreateCampaign.Verify_Approval_Card_contain();

                //Click Self Approve in Approval Card.
                CreateCampaign.ClickOnSelfApproveButton();
                Logger.WriteDebugMessage("User should navigated to Schedule card.");

                
            }
        }

        public static void TC_307097()
        {
            if (TestCaseId == Constants.TC_307097)
            {

                //Variables declaration and object creation
                string campaignName, subject,tmpDesignCardName;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "Test PC - Template";

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

                //Verify Approval card details
                CreateCampaign.VerifySendApprovalinApprovalcard();

                //Click on Reject.
                CreateCampaign.Campaign_Click_Approval_SendRequest_Reject_Button();
                Logger.WriteDebugMessage("Reject Approval Modal should get opened.");
                
            }
        }

        public static void TC_307098()
        {
            if (TestCaseId == Constants.TC_307098)
            {

                //Variables declaration and object creation
                string campaignName, subject, tmpDesignCardName;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "Test PC - Template";

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

                //Verify Approval card details
                CreateCampaign.VerifySendApprovalinApprovalcard();               

                //Click on Reject.
                CreateCampaign.Campaign_Click_Approval_SendRequest_Reject_Button();
                Logger.WriteDebugMessage("Reject Approval Modal should get opened.");

                //Verify Reject Approval Modal details
                CreateCampaign.ValidateRejectApprovalModalCotains();
            }
        }

        public static void TC_312228()
        {
            if (TestCaseId == Constants.TC_312228)
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
                CreateCampaign.RejectApproval__popUp_Cancel_button();
                Logger.WriteDebugMessage("Reject Campaign should not be successful.");

               
            }
        }

        public static void TC_312229()
        {
            if (TestCaseId == Constants.TC_312229)
            {

                //Variables declaration and object creation
                string campaignName, subject, tmpDesignCardName, Commenttext;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "Test PC - Template";
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

                //Verify Approval card details
                CreateCampaign.VerifySendApprovalinApprovalcard();

                //Click on Reject.
                CreateCampaign.Campaign_Click_Approval_SendRequest_Reject_Button();
                Logger.WriteDebugMessage("Reject Approval Modal should get opened.");

                //Verify Reject Approval Modal details
                CreateCampaign.ValidateRejectApprovalModalCotains();

                //Enter comment
                CreateCampaign.RejectApproval__popUp_Enter_text(Commenttext);

                //Again click on Reject from Reject Approval popup
                CreateCampaign.RejectApproval__popUp_Reject_button();
                Helper.VerifyTextOnPageAndHighLight("Your request was rejected");
                Logger.WriteDebugMessage("Reject Campaign successful.");

            }
        }

        #endregion[TP_332222]
    }
}

