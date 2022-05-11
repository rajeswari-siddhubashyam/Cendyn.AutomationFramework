using MarketingAutomation.AppModule.UI;
using MarketingAutomation.Entity;
using MarketingAutomation.Utility;
using BaseUtility.Utility;
using Queries = MarketingAutomation.Utility.Queries;
using System.Collections.Generic;
using InfoMessageLogger;
using TestData;
using OpenQA.Selenium;

namespace MarketingAutomation.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region[TP_294395]
        public static void TC_293201()
        {
            if (TestCaseId == Constants.TC_293201)
            {

                //Variables declaration and object creation
                string campaignName, subject, subjectText, tipText, both;
                IList<string> listForm = new List<string>();
                IList<string> listReply = new List<string>();
                Campaign data = new Campaign();

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                subjectText = TestData.ExcelData.TestDataReader.ReadData(3, "subjectText");
                tipText = TestData.ExcelData.TestDataReader.ReadData(4, "tipText");
                both = TestData.ExcelData.TestDataReader.ReadData(1, "allenv");

                //Navigate to Marketing Automation and log in as valid user
                Helper.WaitForAjaxControls(30);
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);
                Helper.WaitForAjaxControls(50);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //User lands on Campaign Selection page
                CreateCampaign.VerifyMarketingTabSelection();

                //Select a card to proceed to the Settings page 
                //Verify Step Component shows Settings as selected
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Verify Page Title matches same as Account Dropdown with "Cendyn | Edit Campaign | Settings" Campaign" above
                CreateCampaign.VerifyPageTitle("Cendyn | Edit Campaign | Settings");

                //Validate Campaign Name field, Campaign Name field is freeform text box
                CreateCampaign.EnterCampaignNameVerifySame(campaignName);

                //Validate Subject field, subject field is freeform text box
                CreateCampaign.EnterSubjectVerifySame(subject);

                //Subtext: "Make your subject lines relevant, engaging, and tailored for the selected audience."
                CreateCampaign.VerifySubjectTextOnThePage(subjectText);

                //Validate From field
                //listForm.Add("Campaign Origami 1 <campaign_1@cendyn17.com>"); listForm.Add("Campaign Origami 3 <campaign_3@cendyn17.com>"); listForm.Add("Campaign Origami 2 <campaign_2@cendyn17.com>");
                listForm.Add("Campaign Origami 1 <campaign_1@gocendyn.com>"); listForm.Add("Campaign Origami 3 <campaign_3@gocendyn.com>"); listForm.Add("Campaign Origami 2 <campaign_2@gocendyn.com>");
                CreateCampaign.ClickOnFromDropDownAndVerifyList(listForm);


                //Validate Reply to field
                //listReply.Add("Reply Campaign Origami 2 <reply_campaign_2@cendyn17.com>"); listReply.Add("Reply Campaign Origami 1 <reply_campaign_1@cendyn17.com>");
                listReply.Add("Reply Campaign Origami 2 <reply_campaign_2@gocendyn.com>"); listReply.Add("Reply Campaign Origami 1 <reply_campaign_1@gocendyn.com>");
                CreateCampaign.ClickOnReplyDropDownAndVerifyList(listReply);


                //Verify Tip box
                CreateCampaign.VerifyTipBoxText(tipText);
            }
        }


        public static void TC_293202()
        {
            if (TestCaseId == Constants.TC_293202)
            {

                //Variables declaration and object creation
                string campaignName, campaignFieldError, subject, subjectFieldError, formFieldError, formFieldErrorLimit, subjectFieldErrorLimit, both;
                IList<string> listForm = new List<string>();
                IList<string> listReply = new List<string>();
                Campaign data = new Campaign();

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                campaignFieldError = TestData.ExcelData.TestDataReader.ReadData(2, "campaignFieldError");
                subject = TestData.ExcelData.TestDataReader.ReadData(3, "subject");
                subjectFieldError = TestData.ExcelData.TestDataReader.ReadData(4, "subjectFieldError");
                formFieldError = TestData.ExcelData.TestDataReader.ReadData(5, "formFieldError");
                formFieldErrorLimit = TestData.ExcelData.TestDataReader.ReadData(6, "formFieldErrorLimit");
                subjectFieldErrorLimit = TestData.ExcelData.TestDataReader.ReadData(7, "subjectFieldErrorLimit");

                //Navigate to Marketing Automation and log in as a valid user
                Helper.WaitForAjaxControls(30);
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);
                Helper.WaitForAjaxControls(50);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //User lands on Campaign Selection page
                CreateCampaign.VerifyMarketingTabSelection();

                //Select a card to proceed to the Settings page
                //User lands on the settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Try to click continue without adding any details
                CreateCampaign.ClickAndVerifySaveAndContinueButtonDisabled();


                //Add Campaign name and verify Continue button is not enabled
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.ClickAndVerifySaveAndContinueButtonDisabled();

                //Remove Campaign Name and verify
                //-Field validation indicating Campaign Name is required
                //- Continue button is not enabled
                CreateCampaign.RemoveCampaignNameAndVerifyErrorMsgButtonStatus(campaignFieldError);

                //Add Subject and verify Continue button is not enabled
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickAndVerifySaveAndContinueButtonDisabled();

                //Remove Subject and verify field validation indicating Subject is required
                CreateCampaign.RemoveSubjectAndVerifyErrorMsgs(subjectFieldError);
                CreateCampaign.VerifyCampaignErrorMsg(campaignFieldError);
                Logger.WriteDebugMessage("There is a required field validation message and user cannot click Continue, Campaign Name cannot be empty.");

                //Add subject and field validation is gone for Subject
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.VerifySubjectRequiredMsgHide();

                //Click From dropdown and select a value
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();

                //Remove From Name/Email and verify field validation indication From selection is required
                CreateCampaign.RemoveFromSelectionAndVerifyErrorMsgs(formFieldError);

                // Add From Email and field validation is gone
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.VerifyFromRequiredMsgHide();


                //Click to select a Reply email
                CreateCampaign.ClickOnReplyDropDownAndSelectFirstValue();

                //Remove Reply email
                CreateCampaign.RemoveReplySelection();

                //Verify Campaign Name field is MAX 250 characters by adding 250 character Campaign Name
                campaignName = Helper.GetRandomAlphaNumericString(250);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.VerifyCampaignErrorMsgHide();

                //Click Continue
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("Click on Save and Continue button to save campaign details");
                CreateCampaign.VerifyUserNavigatedOnTheAudience();
                Logger.WriteDebugMessage("Clicking on Save&Continue, user is brought to Audience");

                //Click Back and verify entire Campaign Name is still in field
                CreateCampaign.ClickOnBackAndVerifySettingsTab();
                CreateCampaign.VerifyCampaignName(campaignName);
                Logger.WriteDebugMessage("Campaign Name was saved with up to 250 characters");

                //Add one character to Campaign Name (251 characters total) 
                //and verify - Field validation message indicating 250 characters max - Continue button is disabled
                campaignName = Helper.GetRandomAlphaNumericString(251);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.VerifyCampaignErrorMsg(formFieldErrorLimit);
                Helper.ScrollUpUsingJavaScript(Helper.Driver, -1000);
                Logger.WriteDebugMessage("There is max character field validation message on Campagin Name and Continue button is disabled");

                //Update Campaign Name to be regular length (ex. 30 characters)
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                CreateCampaign.EnterCampaignName(campaignName);
                Logger.WriteDebugMessage("Campaign Name updated");

                //Verify Subject field is MAX 100 characters by adding 100 character Subject
                subject = Helper.GetRandomAlphaNumericString(100);
                CreateCampaign.EnterSubject(subject);
                Logger.WriteDebugMessage("Subject is added");

                //Click Continue
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("Click on Save and Continue button to save campaign details");
                CreateCampaign.VerifyUserNavigatedOnTheAudience();
                Logger.WriteDebugMessage("Clicking on Save&Continue, user is brought to Audience");

                //Click Back and verify entire Subject is still in field
                CreateCampaign.ClickOnBackAndVerifySettingsTab();
                CreateCampaign.VerifySubjectName(subject);
                Logger.WriteDebugMessage("Subject was saved with up to 100 characters");

                //Add one character to Subject (101 characters total) and verify - 
                //Field validation message indicating 101 characters max - Continue button is disabled
                subject = Helper.GetRandomAlphaNumericString(101);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.VerifySubjectErrorMsgs(subjectFieldErrorLimit);
                Helper.ScrollUpUsingJavaScript(Helper.Driver, -1000);
                Logger.WriteDebugMessage("There is max character field validation message on Subject and Continue button is disabled");

            }
        }




        public static void TC_293203()
        {
            if (TestCaseId == Constants.TC_293203)
            {

                //Variables declaration and object creation
                string campaignName, subject, fromValue, replyValue;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");

                //Navigate to Marketing Automation and log in as a valid user
                Helper.WaitForAjaxControls(30);
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);
                Helper.WaitForAjaxControls(50);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //User lands on Campaign Selection page
                CreateCampaign.VerifyMarketingTabSelection();

                //Select a card to proceed to the Settings page
                //User lands on the settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Add required fields and click Continue
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                fromValue = CreateCampaign.GetFromValue();
                replyValue = CreateCampaign.GetReplyValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("Click on Save and Continue button to save campaign details");
                CreateCampaign.VerifyUserNavigatedOnTheAudience();
                Logger.WriteDebugMessage("Clicking on Save&Continue, user is brought to Audience");

                //Click Back
                CreateCampaign.ClickOnBackAndVerifySettingsTab();
                Logger.WriteDebugMessage("Clicked on Back button and navigated to settings page");
                CreateCampaign.VerifyCampaignName(campaignName);
                CreateCampaign.VerifySubjectName(subject);
                CreateCampaign.VerifyFromValue(fromValue);
                CreateCampaign.VerifyReplyValue(replyValue);
                Logger.WriteDebugMessage("All fields with values reflect the values when the user clicked Continue from Settings page, fields left blank or without selection still do not have values");

            }
        }


        public static void TC_293204()
        {
            if (TestCaseId == Constants.TC_293204)
            {

                //Variables declaration and object creation
                string campaignName, subject, fromValue, replyValue;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");

                //Navigate to Marketing Automation and log in as a valid user
                Helper.WaitForAjaxControls(30);
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);
                Helper.WaitForAjaxControls(50);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //User lands on Campaign Selection page
                CreateCampaign.VerifyMarketingTabSelection();

                //Select a card to proceed to the Settings page
                //User lands on the settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Add all fields and click Continue
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnReplyDropDownAndSelectFirstValue();
                fromValue = CreateCampaign.GetFromValue();
                replyValue = CreateCampaign.GetReplyValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("Click on Save and Continue button to save campaign details");
                CreateCampaign.VerifyUserNavigatedOnTheAudience();
                Logger.WriteDebugMessage("Clicking on Save&Continue, user is brought to Audience");
                //Click Back
                CreateCampaign.ClickOnBackAndVerifySettingsTab();
                Logger.WriteDebugMessage("Clicked on Back button and navigated to settings page");
                CreateCampaign.VerifyCampaignName(campaignName);
                CreateCampaign.VerifySubjectName(subject);
                CreateCampaign.VerifyFromValue(fromValue);
                CreateCampaign.VerifyReplyValue(replyValue);
                Logger.WriteDebugMessage("All fields reflect the values when the user clicked Continue from Settings page");

            }
        }

        #endregion
    }
}