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
        #region[TP_296600]
        public static void TC_294729()
        {
            if (TestCaseId == Constants.TC_294729)
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
                //Verify Step Component shows Settings as selected
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Add required details and click Continue
                campaignName = campaignName+Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("Click on Save and Continue button to save campaign details");
                Helper.WaitForAjaxControls(120);
                CreateCampaign.VerifyUserNavigatedOnTheAudience();
                Logger.WriteDebugMessage("User lands on Audience Card view");
                //Search for audience
                CreateCampaign.VerifyTruncatedTitleCardPresent();
                //Verify Audience Name is trucated with '…' and hover over displays the full text for the audience card
                CreateCampaign.VerifyFullTextTruncatedTitleCard();
                Logger.WriteDebugMessage("Audience Name is trucated with '…' and hover over displays the full text for the audience card");
            }
        }

        public static void TC_294730()
        {
            if (TestCaseId == Constants.TC_294730)
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
                //Verify Step Component shows Settings as selected
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
                //Search for 'Many Tags'
                Helper.WaitForAjaxControls(120);
                CreateCampaign.VerifyManyTagsWithCount();
                //Verify tags display with first couple and +[#] where # is the number not displayed -- on hover, user can see all tags
                CreateCampaign.VerifyManyTagsWithCountAndHoverDisplayList(0);
                Logger.WriteDebugMessage("Audience Name is trucated with '…' and hover over displays the full text for the audience card");

                //Verify tags display with first couple and +[#] where # is the number not displayed -- on hover, user can see all tags
                CreateCampaign.VerifyManyTagsWithCountAndHoverDisplayList(1);
                Logger.WriteDebugMessage("Tags display with first couple and +[#] where # is the number not displayed -- on hover, user can see all tags");
            }
        }


        public static void TC_294733()
        {
            if (TestCaseId == Constants.TC_294733)
            {

                //Variables declaration and object creation
                string campaignName, subject;
                Campaign data = new Campaign();

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");

                //Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                ////Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //User lands on Campaign Selection page
                CreateCampaign.VerifyMarketingTabSelection();

                //Select a card to proceed to the Settings page
                //Verify Step Component shows Settings as selected
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnRandomCardOfCampaignFromList();

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
                //Click Ellipses > Select & Continue option for an audience
                CreateCampaign.ClickOnEllipsesAndSelectContinue();
                Logger.WriteDebugMessage("Click Ellipses > Select & Continue option for an audience");
                //User lands on Audience Preview page
                CreateCampaign.VerifyUserNavigateToAudiencePreview();
                Logger.WriteDebugMessage("User lands on Audience Preview page");

                //- Correct Audience preview is shown
                //-In DB, correct Audience is associated to Campaign
                SetupConnectionString(Constants.clientEnv.MarketingAutoQA);
                //Get campaign id using name
                Queries.GetCampaignIdByName(data,campaignName);
                //Get AudienceId, Name, Description Using CampainId
                Queries.GetAudienceIdNameDescriptionUsingCampainId(data, Convert.ToInt32(data.CampaignId));
                // Get audience tags
                Queries.GetTagsUsingAudienceId(data, Convert.ToInt32(data.AudienceId));
                CreateCampaign.VerifyAudienceName(data.AudienceName);
                CreateCampaign.VerifyAudienceDescription(data.AudienceDescription);
                if (data.AudienceTagNames.Count > 1)
                {
                    foreach (var item in data.AudienceTagNames)
                    {
                        CreateCampaign.VerifyTagsOnPreviewPage(item);
                    }
                }
                //- Correct Audience Card is selected when clicking Back from Audience Preview
                CreateCampaign.ClickOnBackButton();
                CreateCampaign.VerifyCorrectCardSelected(data.AudienceName);
                Logger.WriteDebugMessage("- Correct Audience preview is shown " +
                                "- In DB, correct Audience is associated to Campaign" +
                                "- Correct Audience Card is selected when clicking Back from Audience Preview");
            }
        }

        public static void TC_294734()
        {
            if (TestCaseId == Constants.TC_294734)
            {

                //Variables declaration and object creation
                string campaignName, subject;
                Campaign data = new Campaign();

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");

                //Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                ////Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //User lands on Campaign Selection page
                CreateCampaign.VerifyMarketingTabSelection();

                //Select a card to proceed to the Settings page
                //Verify Step Component shows Settings as selected
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnRandomCardOfCampaignFromList();

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
                //Click to select an audience
                //Click Ellipses > Select & Continue option for an audience
                CreateCampaign.SelectCardAndClickOnEllipsesAndSelectContinue();
                Logger.WriteDebugMessage("Click Ellipses > Select & Continue option for an audience");
                //User lands on Audience Preview page
                CreateCampaign.VerifyUserNavigateToAudiencePreview();
                Logger.WriteDebugMessage("User lands on Audience Preview page");

                //- Correct Audience preview is shown
                //-In DB, correct Audience is associated to Campaign
                SetupConnectionString(Constants.clientEnv.MarketingAutoQA);
                //Get campaign id using name
                Queries.GetCampaignIdByName(data, campaignName);
                //Get AudienceId, Name, Description Using CampainId
                Queries.GetAudienceIdNameDescriptionUsingCampainId(data, Convert.ToInt32(data.CampaignId));
                // Get audience tags
                Queries.GetTagsUsingAudienceId(data, Convert.ToInt32(data.AudienceId));
                CreateCampaign.VerifyAudienceName(data.AudienceName);
                CreateCampaign.VerifyAudienceDescription(data.AudienceDescription);
                if (data.AudienceTagNames.Count > 1)
                {
                    foreach (var item in data.AudienceTagNames)
                    {
                        CreateCampaign.VerifyTagsOnPreviewPage(item);
                    }
                }
                //- Correct Audience Card is selected when clicking Back from Audience Preview
                CreateCampaign.ClickOnBackButton();
                CreateCampaign.VerifyCorrectCardSelected(data.AudienceName);
                Logger.WriteDebugMessage("- Correct Audience preview is shown "+
                                "- In DB, correct Audience is associated to Campaign"+
                                "- Correct Audience Card is selected when clicking Back from Audience Preview");
            }
        }


        public static void TC_303959()
        {
            if (TestCaseId == Constants.TC_303959)
            {

                //Variables declaration and object creation
                string campaignName, subject;
                Campaign data = new Campaign();

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                string audienceName = "Single Property";
                int forecastTypeId = 8;

                //Navigate to Marketing Automation and log in as a valid user
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
                Logger.WriteDebugMessage("User lands on the settings page");

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


                //Attach to campaign and click Save &Continue
                //string audienceName= CreateCampaign.SelectAndReturnAudienceCardName();
                CreateCampaign.SelectGivenAudienceCard(audienceName);
                SetupConnectionString(Constants.clientEnv.MarketingAutoQA);
                Queries.GetCampaignsCountBasedOnAudienceAndForecastTypeId(data, audienceName, forecastTypeId);
                int campaignsCountBeforeSave = Convert.ToInt32(data.CampaignsCount);
                CreateCampaign.ClickOnSaveAndContinue();
                //Get campaign id using name
                Queries.GetCampaignIdByName(data, campaignName);
                Queries.GetCampaignsCountBasedOnAudienceAndForecastTypeId(data, audienceName, forecastTypeId);
                int campaignsCountAfterSave = Convert.ToInt32(data.CampaignsCount);
                Assert.IsTrue(campaignsCountAfterSave > campaignsCountBeforeSave, "Campaigns count is not increase");
                int campCount = CreateCampaign.ReturnCompainsCountFromAudiencePreviewPage();
                Assert.IsTrue(campaignsCountAfterSave ==  campCount, "Campaigns count is not increase");
                Logger.WriteDebugMessage("See Campaign count increased");

                //Mark new campaign Deleted = 1
                Queries.DeleteCampaignOrGetItBackBasedOnId(Convert.ToInt32(data.CampaignId), 1);
                Queries.GetCampaignsCountBasedOnAudienceAndForecastTypeId(data, audienceName, forecastTypeId);
                campaignsCountAfterSave = Convert.ToInt32(data.CampaignsCount);
                Assert.IsTrue(campaignsCountAfterSave == campaignsCountBeforeSave, "Campaigns is not deleted");
                Logger.WriteDebugMessage("Campaign Deleted");

                //Click to create a campaign
                Navigation.ClickOnSidebarCampaigns();
                WaitForAjaxControls(90);

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //User lands on Campaign Selection page
                CreateCampaign.VerifyMarketingTabSelection();

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();
                Logger.WriteDebugMessage("User lands on the settings page");

                //Restore campaign
                Queries.DeleteCampaignOrGetItBackBasedOnId(Convert.ToInt32(data.CampaignId), 0);

                //Add required details and click Continue
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("Click on Save and Continue button to save campaign details");
                
                //Verify Campaign count is count noted - 1
                string latestCount= CreateCampaign.SearchAudienceAndGetCampaignCount(audienceName);
                Queries.GetCampaignsCountBasedOnAudienceAndForecastTypeId(data, audienceName, forecastTypeId);
                int campaignsCountDeleteRestore = Convert.ToInt32(data.CampaignsCount);
                Assert.IsTrue(campaignsCountDeleteRestore == Convert.ToInt32(latestCount), "Campaign count is not increased");
                Logger.WriteDebugMessage("Verify Campaign count is count noted - 1");
            }
        }

        public static void TC_294727()
        {
            if (TestCaseId == Constants.TC_294727)
            {

                //Variables declaration and object creation
                string campaignName, subject;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");

                //Navigate to Marketing Automation and log in as a valid user
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
                Logger.WriteDebugMessage("User lands on the settings page");
                //Add required details and click Continue
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("Click on Save and Continue button to save campaign details");
                //Verify Page Title matches same as Account Dropdown with "[Campaign Type] Campaign" above
                CreateCampaign.VerifyPageTitle("Cendyn | Edit Campaign | Audience");
                //Verify Step Component shows Settings with check mark and Audience as selected
                CreateCampaign.VrifySettingsChecked();
                CreateCampaign.VerifyUserNavigatedOnTheAudience();
                Logger.WriteDebugMessage("Step Component shows Settings with check mark and Audience as selected");
                //Verify no audience is selected by default
                CreateCampaign.VerifyNoAudienceSelectedDefault();
                Logger.WriteDebugMessage("No audience is selected when creating a new campaign");
                //Click on an audience
                string audienceName = CreateCampaign.SelectAndReturnAudienceCardName();
                CreateCampaign.VerifyCorrectCardSelected(audienceName);
                Logger.WriteDebugMessage("Clicking on an audience selects the audience and highlights with a border");
                //Verify clicking on an audience enables the Continue button
                CreateCampaign.VerifySaveAndContinueButtonEnable();
                Logger.WriteDebugMessage("Clicking on an audience enables the Continue button");
                //Click on a different audience
                string audienceName2 = CreateCampaign.SelectAndReturnAudienceCardName();
                CreateCampaign.VerifyCorrectCardSelected(audienceName2);
                Logger.WriteDebugMessage("Newly selected audience appears highlighted with a border");
            }
        }

        public static void TC_294731()
        {
            if (TestCaseId == Constants.TC_294731)
            {

                //Variables declaration and object creation
                string campaignName, subject;
                Campaign data = new Campaign();

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");

                //Navigate to Marketing Automation and log in as a valid user
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
                Logger.WriteDebugMessage("User lands on the settings page");
                //Add required details and click Continue
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("User lands on Audience Card view");
                //Need to validate each scenario
                //- Audience 'Counts_Test_2k' has 1987 total counts --will round to 1.9K
                //- Audience 'Counts_Test_1k' has 1499-- will round to 1.4K
                //- Audience 'Counts_Test_1m' has 1237142-- will round to 1.2M
                //- Audience 'Counts_test_doubledigits' has 87-- will show 87
                int[] audienceCounts = new int[] { 1987, 1499, 1237142, 87 };
                string[] expAudienceCount = new string[] { "1.9K", "1.4K", "1.2M", "87" };
                //Get connection string
                SetupConnectionString(Constants.clientEnv.MarketingAutoQA);
                for (int i = 0; i < audienceCounts.Length; i++)
                {
                    //Get Audience name based on audience count
                    Queries.GetAudienceNameBasedOnAudienceCount(data, audienceCounts[i]);
                    CreateCampaign.VerifyAudienceCount(data.AudienceName, expAudienceCount[i]);
                }
                Logger.WriteDebugMessage("- Audience 'Counts_Test_2k' has 1987 total counts -- will round to 1.9K "+
                                            "- Audience 'Counts_Test_1k' has 1499-- will round to 1.4K"+
                                            "- Audience 'Counts_Test_1m' has 1237142-- will round to 1.2M"+
                                            "- Audience 'Counts_test_doubledigits' has 87-- will show 87");
                
            }
        }

        public static void TC_298413()
        {
            if (TestCaseId == Constants.TC_298413)
            {

                //Variables declaration and object creation
                string campaignName, subject;
                Campaign data = new Campaign();

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");

                //Navigate to Marketing Automation and log in as a valid user
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
                Logger.WriteDebugMessage("User lands on the settings page");
                //Add required details and click Continue
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("User lands on Audience Card view");

                // Search for Audience '!🦑你好ç日本語ê-ñ@#$<]*#'
                // Verify counts show as 0
                int[] audienceCounts = new int[] { 0 };
                string[] expAudienceCount = new string[] { "0" };
                //Get connection string
                SetupConnectionString(Constants.clientEnv.MarketingAutoQA);
                for (int i = 0; i < audienceCounts.Length; i++)
                {
                    //Get Audience name based on audience count
                    Queries.GetAudienceNameBasedOnAudienceCount(data, audienceCounts[i]);
                    CreateCampaign.VerifyAudienceCount(data.AudienceName, expAudienceCount[i]);
                }
                Logger.WriteDebugMessage($"Audience is contains count as 0 ");

            }
        }


        public static void TC_294732()
        {
            if (TestCaseId == Constants.TC_294732)
            {

                //Variables declaration and object creation
                string campaignName, subject;
                Campaign data = new Campaign();
                string audienceName = "TC_294732";
                int forecastTypeId = 8;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");

                //Navigate to Marketing Automation and log in as a valid user
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
                Logger.WriteDebugMessage("User lands on the settings page");

                //Add required details and click Continue
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("User lands on Audience Card view");

                // Search for Audience 'TC_294732'
                // Verify card data for Audience is correct
                //Get connection string
                SetupConnectionString(Constants.clientEnv.MarketingAutoQA);
                Queries.GetCampaignsDetailsBasedOnAudienceAndForecastTypeId(data, audienceName, forecastTypeId);
                CreateCampaign.VerifyAudienceDetailsOnGrid(data.AudienceName, data.CriteriaCount, data.AudienceTags,
                    data.AudienceCount, data.CampaignsCount, data.AudienceUpdateDate);
                Logger.WriteDebugMessage("Card data displays the following Title: Audience Name Subtitle: # Criteria conditions Tags Audience Count(display Total Number) Campaigns using Last Modified Date");

            }
        }

        public static void TC_295387()
        {
            if (TestCaseId == Constants.TC_295387)
            {

                //Variables declaration and object creation
                string campaignName, subject, audienceName, expAudienceCount;

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");

                //Navigate to Marketing Automation and log in as a valid user
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
                Logger.WriteDebugMessage("User lands on the settings page");
                //Add required details and click Continue
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("User lands on Audience Card view");

                // Search for Audience 'TC_295387_NoCounts NoDescription'
                // '--' shows for when no counts have been run
                 audienceName = "TC_295387_NoCounts NoDescription";
                 expAudienceCount = "--";
                CreateCampaign.VerifyAudienceCount(audienceName, expAudienceCount);
                Logger.WriteDebugMessage($"'--' shows for when no counts have been run ");

            }
        }

        #endregion[TP_296600]
    }
}
