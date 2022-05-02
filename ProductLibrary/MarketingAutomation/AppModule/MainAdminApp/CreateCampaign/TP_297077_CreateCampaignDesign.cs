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

namespace MarketingAutomation.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region[TP_297077]
        public static void TC_297079()
        {
            if (TestCaseId == Constants.TC_297079)
            {

                //Variables declaration and object creation
                string campaignName, subject;

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

                //Verify Page Title matches same as Account Dropdown with "[Campaign Type] Campaign" above
                CreateCampaign.VerifyPageTitle("Cendyn | Edit Campaign | Design");
                Logger.WriteInfoMessage("Page Title matches same as Account Dropdown with 'Cendyn | Edit Campaign | Design' above");

                //Verify Step Component shows Audience with check mark and Design as selected
                CreateCampaign.VrifyAudienceChecked();
                CreateCampaign.VerifyDesignHighlighted();
                Logger.WriteDebugMessage("Step Component shows Audience with check mark and Design as selected");

                //Verify no design is selected by default
                CreateCampaign.VerifyNoDesignSelectedDefault();
                Logger.WriteDebugMessage("No design is selected when creating a new campaign");

                //Click on a design
                string designCardName = CreateCampaign.SelectAndReturnDesignCardName();
                CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);
                Logger.WriteDebugMessage("Clicking on an design selects the design and highlights with a border");

                //Verify clicking on a design enables the Continue button
                CreateCampaign.VerifySaveAndContinueButtonEnable();
                Logger.WriteDebugMessage("Clicking on a design enables the Continue button");

                //Click on a different design
                string designCardName2 = CreateCampaign.SelectAndReturnDesignCardName();
                CreateCampaign.VerifyCorrectDesignCardSelected(designCardName2);
                Logger.WriteDebugMessage("Newly selected design appears highlighted with a border and previous design is no longer highlighted");
            }
        }

        public static void TC_297080()
        {
            try
            {
                if (TestCaseId == Constants.TC_297080)
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
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void TC_297081()
        {
            if (TestCaseId == Constants.TC_297081)
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
        #endregion[TP_297077]
    }
}
