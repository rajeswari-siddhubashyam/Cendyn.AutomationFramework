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

        public static void TC_307250()
        {
            if (TestCaseId == Constants.TC_307250)
            {

                //Variables declaration and object creation
                string campaignName, subject, tmpDesignCardName, DefaultLoginEmail;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "MA QA Test Campaign Template";
                DefaultLoginEmail = Constants.FrontEndEmail;

                //Step1: Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Step2: Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //User lands on Campaign Selection page
                CreateCampaign.VerifyMarketingTabSelection();

                //Step3: Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Step4: Add required details and click Continue
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

                //Step5: Select an Audience and click Continue
                CreateCampaign.SelectRandomAudienceCardFromFirstPage();
                CreateCampaign.ClickOnSaveAndContinue();

                //User lands on Audience Preview page
                CreateCampaign.VerifyUserNavigateToAudiencePreview();
                Logger.WriteDebugMessage("User lands on Audience Preview page");

                //Step6: Click Continue button
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


                //Step7: Select Design Card and click Continue
                CreateCampaign.SelectGivenDesignCard(tmpDesignCardName);
                CreateCampaign.VerifyCorrectDesignCardSelected(tmpDesignCardName);
                Logger.WriteDebugMessage("Clicking on an design selects the design and highlights with a border");

                /*Validate Send Test email confirmation dialog*/
                //Click Continue button
                CreateCampaign.ClickOnSaveAndContinue();


                //Step8: Click Send Email Icon.
                CreateCampaign.Campaign_Create_Design_Click_SendMail();
                Logger.WriteDebugMessage("Send Test email confirmation dialog displayed");

                /*Validate fileds on Send Test email confirmation dialog*/
                Helper.VerifyTextOnPageAndHighLight("Recipients");
                Logger.WriteDebugMessage("Recipients :  field displayed");
                Helper.VerifyTextOnPageAndHighLight("Seed Lists");
                Logger.WriteDebugMessage("Seed Lists :  field displayed");
                Helper.VerifyTextOnPageAndHighLight("Cancel");
                Logger.WriteDebugMessage("Cancel  : Button displayed");
                Helper.VerifyTextOnPageAndHighLight("Send");
                Logger.WriteDebugMessage("Send : Button displayed");

                /*Validate Recipients field is showing default logged in email of the user*/
                CreateCampaign.Recipients_Text_Box();
                CreateCampaign.VerifyDefaultRecipients(DefaultLoginEmail);

                CreateCampaign.Campaign_Create_Design_SeedList_DDL();
                CreateCampaign.SelectOptionFromSeedList_DDL("First Seed");

                //Step9: Add incorrect email in Recipients field Select seed  click save
                CreateCampaign.Enter_Recipients("Test");
                Helper.Keyboard_Enter();
                CreateCampaign.Campaign_Create_Design_SendTest_Send_Button();
                Assert.IsTrue(Helper.VerifyTextOnPage("Recipient email address is not valid."),"Error message is not display for wrong email");
                Logger.WriteDebugMessage("Validation message dispalyed as : Recipient email address is not valid.");
            }
        }

        public static void TC_307251()
        {
            if (TestCaseId == Constants.TC_307251)
            {

                //Variables declaration and object creation
                string campaignName, subject, tmpDesignCardName;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                tmpDesignCardName = "MA QA Test Campaign Template";

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
                string designCardName = CreateCampaign.SelectAndReturnDesignCardName();
                CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);
                Logger.WriteDebugMessage("Clicking on an design selects the design and highlights with a border");
                CreateCampaign.SelectGivenDesignCard(tmpDesignCardName);
                CreateCampaign.VerifyCorrectDesignCardSelected(tmpDesignCardName);


                //Click Continue button
                CreateCampaign.ClickOnSaveAndContinue();

                //Click Send Email 
                CreateCampaign.Campaign_Create_Design_Click_SendMail();
                Logger.WriteDebugMessage("Send Test Pop up displayed");

                //verify fields on send test popup
                Helper.VerifyTextOnPageAndHighLight("Recipients");
                Logger.WriteDebugMessage("Recipients :  field displayed");
                Helper.VerifyTextOnPageAndHighLight("Seed Lists");
                Logger.WriteDebugMessage("Seed Lists :  field displayed");
                Helper.VerifyTextOnPageAndHighLight("Cancel");
                Logger.WriteDebugMessage("Cancel  : Button displayed");
                Helper.VerifyTextOnPageAndHighLight("Send");
                Logger.WriteDebugMessage("Send : Button displayed");

                CreateCampaign.Campaign_Create_Design_SeedList_DDL();
                CreateCampaign.Campaign_Create_Design_SeedList_value("First Seed");
                Logger.WriteDebugMessage("Seed Value is selected as : First Seed");

                //Click Send button
                CreateCampaign.Campaign_Create_Design_SendTest_Send_Button();

                Helper.VerifyTextOnPageAndHighLight("Your test email has been triggered. The email should arrive to your inbox shortly.");
                Logger.WriteDebugMessage("Confirmation message displayed as :Your test email has been triggered.The email should arrive to your inbox shortly.");
            }
        }

        public static void TC_307252()
        {
            if (TestCaseId == Constants.TC_307252)
            {

                //Variables declaration and object creation
                string campaignName, subject, tmpDesignCardName;
                Campaign data = new Campaign();
                //Right now all design preview is have loading issue due to bad test data so using below design card name as static
                //remove this line and dependant methods when it contain proper data and uncomment line number 161, 162, 175 and 181
                tmpDesignCardName = "MA QA Test Campaign Template";

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");

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

                //Select a design and click Continue
                //string designCardName = CreateCampaign.SelectAndReturnDesignCardName();
                //CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);
                CreateCampaign.SelectGivenDesignCard(tmpDesignCardName);
                CreateCampaign.VerifyCorrectDesignCardSelected(tmpDesignCardName);

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");

                //User lands on Design Preview page
                CreateCampaign.VerifyUserNavigateToDesignPreview();
                Logger.WriteDebugMessage("User lands on Design Preview page");

                //Verify the Design selected was added to the template
                //-Correct Design preview is shown
                //CreateCampaign.ValidateDesignCardTitleOnPreviewPage(designCardName);
                CreateCampaign.ValidateDesignCardTitleOnPreviewPage(tmpDesignCardName);
                Logger.WriteDebugMessage("Correct Design preview is shown");

                //By clicking Back button and verifying the correct Design Card is selected
                CreateCampaign.ClickOnBackButton();
                //CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);
                CreateCampaign.VerifyCorrectDesignCardSelected(tmpDesignCardName);
                Logger.WriteDebugMessage("By clicking Back button and the correct Design Card is selected");
            }
        }

        public static void TC_307253()
        {
            if (TestCaseId == Constants.TC_307253)
            {

                //Variables declaration and object creation
                string campaignName, subject, tmpDesignCardName;
                Campaign data = new Campaign();
                //Right now all design preview is have loading issue due to bad test data so using below design card name as static
                //remove this line and dependant methods when it contain proper data and uncomment line number 268,274
                tmpDesignCardName = "MA QA Test Campaign Template";

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");

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

                //Click to select a design
                string designCardName = CreateCampaign.SelectAndReturnDesignCardName();
                CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);
                Logger.WriteDebugMessage($"{designCardName} Design is selected");

                //Click to select a different design
                CreateCampaign.SelectGivenDesignCard(tmpDesignCardName);
                CreateCampaign.VerifyCorrectDesignCardSelected(tmpDesignCardName);
                Logger.WriteDebugMessage("Different design is selected");

                //Click Continue button
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");

                //User lands on Design Preview page
                CreateCampaign.VerifyUserNavigateToDesignPreview();
                Logger.WriteDebugMessage("User lands on Design Preview page");


                //Verify the Design selected at time of clicking Continue was added to the template
                //-Correct Design preview is shown
                //- By clicking Back button and verifying the correct Design Card is selected
                //CreateCampaign.ValidateDesignCardTitleOnPreviewPage(designCardName);
                CreateCampaign.ValidateDesignCardTitleOnPreviewPage(tmpDesignCardName);
                Logger.WriteDebugMessage("Correct Design preview is shown");

                //By clicking Back button and verifying the correct Design Card is selected
                CreateCampaign.ClickOnBackButton();
                //CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);
                CreateCampaign.VerifyCorrectDesignCardSelected(tmpDesignCardName);
                Logger.WriteDebugMessage("By clicking Back button and the correct Design Card is selected");
            }
        }

        public static void TC_307254()
        {
            if (TestCaseId == Constants.TC_307254)
            {

                //Variables declaration and object creation
                string campaignName, subject, tmpDesignCardName;
                Campaign data = new Campaign();
                //Right now all design preview is have loading issue due to bad test data so using below design card name as static
                //remove this line and dependant methods when it contain proper data and uncomment line number 268,274
                tmpDesignCardName = "MA QA Test Campaign Template";

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");

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

                //Click to select a design
                string designCardName = CreateCampaign.SelectAndReturnDesignCardName();
                CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);
                Logger.WriteDebugMessage($"{designCardName} Design is selected");

                //Click to select a different design
                CreateCampaign.SelectGivenDesignCard(tmpDesignCardName);
                CreateCampaign.VerifyCorrectDesignCardSelected(tmpDesignCardName);
                Logger.WriteDebugMessage("Different design is selected");

                //Click Continue button
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");

                //User lands on Design Preview page
                CreateCampaign.VerifyUserNavigateToDesignPreview();
                Logger.WriteDebugMessage("User lands on Design Preview page");


                //Verify the Design selected at time of clicking Continue was added to the template
                //-Correct Design preview is shown
                //- By clicking Back button and verifying the correct Design Card is selected
                //CreateCampaign.ValidateDesignCardTitleOnPreviewPage(designCardName);
                CreateCampaign.ValidateDesignCardTitleOnPreviewPage(tmpDesignCardName);
                Logger.WriteDebugMessage("Correct Design preview is shown");

                //By clicking Back button and verifying the correct Design Card is selected
                CreateCampaign.ClickOnBackButton();
                //CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);
                CreateCampaign.VerifyCorrectDesignCardSelected(tmpDesignCardName);
                Logger.WriteDebugMessage("By clicking Back button and the correct Design Card is selected");
            }
        }
        #endregion[TP_33081]
    }
}
