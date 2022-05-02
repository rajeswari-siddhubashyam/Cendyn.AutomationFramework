using MarketingAutomation.AppModule.UI;
using MarketingAutomation.Entity;
using MarketingAutomation.Utility;
using BaseUtility.Utility;
using Queries = MarketingAutomation.Utility.Queries;
using InfoMessageLogger;
using System;

namespace MarketingAutomation.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region[TP_309532]
        public static void TC_309801()
        {
            if (TestCaseId == Constants.TC_309801)
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

                //Steps:1 Navigate to Marketing Automation and log in as valid user
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

                //Enter all required details from Settings to Confirm page //
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

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");

                //Validate schedule card displayed in Confirm page
                CreateCampaign.VerifyConfirmHighlightedAndPage();
                CreateCampaign.ClickOnSelfApproveButton();

                CreateCampaign.VerifySendDefaultValue("Daily");
                CreateCampaign.VerifyDayFromCurrentDate();
                CreateCampaign.VerifyUntilCurrentDate();
                CreateCampaign.VerifyTimeGreaterThanCurrentTime();
                Logger.WriteDebugMessage("Once  should selected as default in card and todays date / time should display");

                //click on Campaigns to select Automated
                //Click to create a campaign
                Navigation.ClickOnSidebarCampaigns();
                WaitForAjaxControls(90);

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //Click on Marketing and Transactional on toggle and verify cards shown
                CreateCampaign.ToggletoAutomatedTtab();

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Enter all required details from Settings to Confirm page //
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("Click on Save and Continue button to save campaign details");
                Helper.WaitForAjaxControls(120);
                
                 //Select a design and click Continue
                //string designCardName = CreateCampaign.SelectAndReturnDesignCardName();
                //CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);
                CreateCampaign.SelectGivenDesignCard(tmpDesignCardName);
                CreateCampaign.VerifyCorrectDesignCardSelected(tmpDesignCardName);

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");

                //Verify the Design selected was added to the template
                //-Correct Design preview is shown
                //CreateCampaign.ValidateDesignCardTitleOnPreviewPage(designCardName);
                CreateCampaign.ValidateDesignCardTitleOnPreviewPage(tmpDesignCardName);
                Logger.WriteDebugMessage("Correct Design preview is shown");

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");

                //Validate schedule card displayed in Confirm page
                CreateCampaign.VerifyConfirmHighlightedAndPage();
                CreateCampaign.ClickOnSelfApproveButton();

                CreateCampaign.VerifySendDefaultValue("Immediately");
                CreateCampaign.VerifyStartOnCurrentDate();
                CreateCampaign.VerifyUntilCurrentDate();
                CreateCampaign.VerifyTimeGreaterThanCurrentTime();
                Logger.WriteDebugMessage("1. Schedule card should display in Confirm page 2.Once  should selected as default in card and todays date / time should display");

            }
        }


        public static void TC_309802()
        {
            if (TestCaseId == Constants.TC_309802)
            {

                //Variables declaration and object creation
                string campaignName, subject, tmpDesignCardName, marketingSendDDM;
                Campaign data = new Campaign();
                //Right now all design preview is have loading issue due to bad test data so using below design card name as static
                //remove this line and dependant methods when it contain proper data and uncomment line number 161, 162, 175 and 181
                tmpDesignCardName = "MA QA Test Campaign Template";

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                marketingSendDDM = TestData.ExcelData.TestDataReader.ReadData(3, "marketingSendDDM");

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);


                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //User lands on Campaign Selection page
                CreateCampaign.VerifyMarketingTabSelection();
                Logger.WriteDebugMessage("User lands on Campaign Selection page");

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Enter all required details from Settings to Confirm page //
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

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");
                Logger.WriteDebugMessage("User should landed on Confirm page");

                //Validate schedule card displayed in Confirm page
                CreateCampaign.VerifyConfirmHighlightedAndPage();
                CreateCampaign.ClickOnSelfApproveButton();

                CreateCampaign.VerifySendDefaultValue("Daily");
                CreateCampaign.ClickOnSendDDMList();
                CreateCampaign.VerifySendDDMDropDownList(marketingSendDDM);
                CreateCampaign.VerifyDayFromCurrentDate();
                CreateCampaign.VerifyUntilCurrentDate();
                CreateCampaign.VerifyTimeGreaterThanCurrentTime();
                Logger.WriteDebugMessage("Send ddm should display below options 1.Once 2.Daily 3.Weekly 4.Monthly 5.Yearly 6.Hourly 7.x - Minutes");
            }
        }

        public static void TC_309803()
        {
            if (TestCaseId == Constants.TC_309803)
            {

                //Variables declaration and object creation
                string campaignName, subject, tmpDesignCardName,selectedDate, selectedTime,selectedZone,sendDDM;
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
                Logger.WriteDebugMessage("User lands on Campaign Selection page");

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Enter all required details from Settings to Confirm page //
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

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");
                Logger.WriteDebugMessage("User should landed on Confirm page");

                //Validate schedule card displayed in Confirm page
                CreateCampaign.VerifyConfirmHighlightedAndPage();
                CreateCampaign.ClickOnSelfApproveButton();

                CreateCampaign.VerifySendDefaultValue("Daily");

                //Select Once from sent ddm
                sendDDM = "Once";
                CreateCampaign.SelectOptionFromSendDDM(sendDDM);
                WaitForAjaxControls(30);
                Logger.WriteDebugMessage("Once should be selected");

                //Enter start/ end dates and time
                selectedDate = CreateCampaign.SelectDatesInOnFieldOfNextDay();
                //selected Date time
                selectedTime = CreateCampaign.SelectTimeInAtFieldOfNextslot();
                //select zone
                selectedZone= CreateCampaign.SelectZoneInTimeZone("India Standard Time");
                Logger.WriteDebugMessage("User should able to add start/end dates and times");

                //Select dates and time. Click on finish button
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                CreateCampaign.VerifyVisibilityOfManageCampaignsAndEditScheduleButtons();
                CreateCampaign.VerifySubTitleOnPage(campaignName,sendDDM,selectedDate,selectedTime,selectedZone);
                Logger.WriteDebugMessage("Campaign should save successfully with Title Success Sub Title Your campaign[CampaignName] will be sent[frequency] on[Day] at[Time][Timezone] Manage campaigns and Edit Schedule button should display");
                //Validate saved Campaign in DB
                Queries.GetCampaignIdByName(data, campaignName);
                Queries.GetCampaignFrequencyBasedOngNameAndId(data, campaignName, Convert.ToInt32(data.CampaignId));
                CreateCampaign.VerifyFrequencyData(data.CampaignFrequency, sendDDM, selectedDate, selectedTime, selectedZone);
                Logger.WriteInfoMessage("Campaign Frequency/Schedule & Timezone gets stored in the DB");
            }
        }

        public static void TC_309804()
        {
            if (TestCaseId == Constants.TC_309804)
            {

                //Variables declaration and object creation
                string campaignName, subject, tmpDesignCardName, selectedFromDate, selectedTime, selectedZone, sendDDM, selectedUntilDate, selectedEvery;
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
                Logger.WriteDebugMessage("User lands on Campaign Selection page");

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Enter all required details from Settings to Confirm page //
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

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");
                Logger.WriteDebugMessage("User should landed on Confirm page");

                //Validate schedule card displayed in Confirm page
                CreateCampaign.VerifyConfirmHighlightedAndPage();
                CreateCampaign.ClickOnSelfApproveButton();

                //Select Daily from sent ddm
                sendDDM = "Daily";
                CreateCampaign.SelectOptionFromSendDDM(sendDDM);
                WaitForAjaxControls(30);
                Logger.WriteDebugMessage("Daily should be selected");

                //Enter start/end dates and time
                selectedFromDate = CreateCampaign.SelectDateInDayFromFieldOfNextDay();
                selectedUntilDate = CreateCampaign.SelectDateIUntilFieldOfNextDay(0);

                //selected Date time
                selectedTime = CreateCampaign.SelectTimeInAtFieldOfNextslot();
                // selected every
                selectedEvery = CreateCampaign.SelectCountOfEvery("4");
                //select zone
                selectedZone = CreateCampaign.SelectZoneInTimeZone("India Standard Time");
                Logger.WriteDebugMessage("User should able to add start/end dates and times");

                //Validate schedule from and until dates
                CreateCampaign.VerifyUntillDateGreateThanOtherDate(selectedFromDate, selectedUntilDate);
                Logger.WriteDebugMessage("Schedule until date should greater than schedule from date");
                //Select dates and time. Click on finish button
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                CreateCampaign.VerifyVisibilityOfManageCampaignsAndEditScheduleButtons();
                CreateCampaign.VerifySubTitleOnPage(campaignName, sendDDM, selectedFromDate, selectedTime, selectedZone);
                Logger.WriteDebugMessage("Campaign should save successfully with Title Success Sub Title Your campaign[CampaignName] will be sent[frequency] on[Day] at[Time][Timezone] Manage campaigns and Edit Schedule button should display");
                //Validate saved Campaign in DB
                Queries.GetCampaignIdByName(data, campaignName);
                Queries.GetCampaignFrequencyBasedOngNameAndId(data, campaignName, Convert.ToInt32(data.CampaignId));
                CreateCampaign.VerifyFrequencyData(data.CampaignFrequency, sendDDM, selectedFromDate, selectedUntilDate, selectedTime, selectedZone, selectedEvery);
                Logger.WriteInfoMessage("Campaign Frequency/Schedule & Timezone gets stored in the DB");
            }
        }

       

        public static void TC_309806()
        {
            if (TestCaseId == Constants.TC_309806)
            {

                //Variables declaration and object creation
                string campaignName, subject, tmpDesignCardName, selectedFromDate, selectedTime, selectedZone, sendDDM, selectedUntilDate, selectedEvery;
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
                Logger.WriteDebugMessage("User lands on Campaign Selection page");

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Enter all required details from Settings to Confirm page //
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

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");
                Logger.WriteDebugMessage("User should landed on Confirm page");

                //Validate schedule card displayed in Confirm page
                CreateCampaign.VerifyConfirmHighlightedAndPage();
                CreateCampaign.ClickOnSelfApproveButton();

                //Select Monthly from sent ddm
                sendDDM = "Monthly";
                CreateCampaign.SelectOptionFromSendDDM(sendDDM);
                WaitForAjaxControls(30);
                Logger.WriteDebugMessage("Monthly should be selected");

                //Enter start/end dates and time
                selectedFromDate = CreateCampaign.SelectDateInMonthsFromFieldOfNextDay();
                selectedUntilDate = CreateCampaign.SelectDateIUntilFieldOfNextDay(2);

                //selected Date time
                selectedTime = CreateCampaign.SelectTimeInAtFieldOfNextslot();
                // selected every
                selectedEvery = CreateCampaign.SelectCountOfEveryForMonth("6");
                //select zone
                selectedZone = CreateCampaign.SelectZoneInTimeZone("India Standard Time");
                Logger.WriteDebugMessage("User should able to add start/end dates and times");

                //Validate schedule from and until dates
                CreateCampaign.VerifyUntillDateGreateThanOtherDate(selectedFromDate, selectedUntilDate);
                Logger.WriteDebugMessage("Schedule until date should greater than schedule from date");

                //Select dates and time. Click on finish button
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                CreateCampaign.VerifyVisibilityOfManageCampaignsAndEditScheduleButtons();
                CreateCampaign.VerifySubTitleOnPage(campaignName, sendDDM, selectedFromDate, selectedTime, selectedZone);
                Logger.WriteDebugMessage("Campaign should save successfully with Title Success Sub Title Your campaign[CampaignName] will be sent[frequency] on[Day] at[Time][Timezone] Manage campaigns and Edit Schedule button should display");

                //Validate saved Campaign in DB
                Queries.GetCampaignIdByName(data, campaignName);
                Queries.GetCampaignFrequencyBasedOngNameAndId(data, campaignName, Convert.ToInt32(data.CampaignId));
                CreateCampaign.VerifyFrequencyData(data.CampaignFrequency, sendDDM, selectedFromDate, selectedUntilDate, selectedTime, selectedZone, selectedEvery);
                Logger.WriteInfoMessage("Campaign Frequency/Schedule & Timezone gets stored in the DB");
            }
        }


        public static void TC_309812()
        {
            if (TestCaseId == Constants.TC_309812)
            {

                //Variables declaration and object creation
                string campaignName, subject, tmpDesignCardName, selectedFromDate, selectedTime, selectedTime2, selectedZone, sendDDM, selectedUntilDate, selectedEvery;
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
                Logger.WriteDebugMessage("User lands on Campaign Selection page");

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Enter all required details from Settings to Confirm page //
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

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");
                Logger.WriteDebugMessage("User should landed on Confirm page");

                //Validate schedule card displayed in Confirm page
                CreateCampaign.VerifyConfirmHighlightedAndPage();
                CreateCampaign.ClickOnSelfApproveButton();

                //Select X-Minutes from sent ddm
                sendDDM = "X-Minute";
                CreateCampaign.SelectOptionFromSendDDM(sendDDM);
                WaitForAjaxControls(30);
                Logger.WriteDebugMessage("Minutes should be selected");

                //Enter start/end dates and time
                selectedFromDate = CreateCampaign.SelectDateInMinutesFromFieldOfNextDay();
                selectedUntilDate = CreateCampaign.SelectDateIUntilFieldOfNextDay(1);

                //selected Date time
                selectedTime = CreateCampaign.SelectTimeInAtFieldOfNextslotForMinutes();
                selectedTime2 = CreateCampaign.SelectTimeInAtFieldOfNextslotForUntil();
                // selected every
                selectedEvery = CreateCampaign.SelectCountOfEveryForMinutes("45");
                //select zone
                selectedZone = CreateCampaign.SelectZoneInTimeZone("India Standard Time");
                Logger.WriteDebugMessage("User should able to add start/end dates and times");

                //Validate schedule from and until dates
                CreateCampaign.VerifyUntillDateGreateThanOtherDate(selectedFromDate, selectedUntilDate);
                Logger.WriteDebugMessage("Schedule until date should greater than schedule from date");

                //Select dates and time. Click on finish button
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                CreateCampaign.VerifyVisibilityOfManageCampaignsAndEditScheduleButtons();
                CreateCampaign.VerifySubTitleOnPage(campaignName, sendDDM, selectedFromDate, selectedTime, selectedZone);
                Logger.WriteDebugMessage("Campaign should save successfully with Title Success Sub Title Your campaign[CampaignName] will be sent[frequency] on[Day] at[Time][Timezone] Manage campaigns and Edit Schedule button should display");

                //Validate saved Campaign in DB
                Queries.GetCampaignIdByName(data, campaignName);
                Queries.GetCampaignFrequencyBasedOngNameAndId(data, campaignName, Convert.ToInt32(data.CampaignId));
                CreateCampaign.VerifyFrequencyData(data.CampaignFrequency, sendDDM, selectedFromDate, selectedUntilDate, selectedTime, selectedTime2, selectedZone, selectedEvery);
                Logger.WriteInfoMessage("Campaign Frequency/Schedule & Timezone gets stored in the DB");
            }
        }

        public static void TC_309809()
        {
            if (TestCaseId == Constants.TC_309809)
            {

                //Variables declaration and object creation
                string campaignName, subject, selectedFromDate, selectedTime, selectedTime2, selectedZone, sendDDM, selectedUntilDate, selectedEvery;
                Campaign data = new Campaign();

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
                Logger.WriteDebugMessage("User lands on Campaign Selection page");

                //Switch to Automated 
                CreateCampaign.ToggletoAutomatedTtab();

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.SelectCardByProvidingIndex(2);

                //Enter all required details from Settings to Confirm page //
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("Click on Save and Continue button to save campaign details");
                Helper.WaitForAjaxControls(120);

                //Select a design and click Continue
                string designCardName = CreateCampaign.SelectAndReturnDesignCardName();
                CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);
                
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");

                 //Verify the Design selected was added to the template
                //-Correct Design preview is shown
                CreateCampaign.ValidateDesignCardTitleOnPreviewPage(designCardName);
                Logger.WriteDebugMessage("Correct Design preview is shown");

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");
                Logger.WriteDebugMessage("User should landed on Confirm page");

                //Validate schedule card displayed in Confirm page
                CreateCampaign.VerifyConfirmHighlightedAndPage();
                CreateCampaign.ClickOnSelfApproveButton();

                //Select Immediately from sent ddm
                sendDDM = "Immediately";
                CreateCampaign.SelectOptionFromSendDDM(sendDDM);
                WaitForAjaxControls(30);
                Logger.WriteDebugMessage("Immediately should be selected");

                //Enter start/end dates and time

                selectedFromDate = CreateCampaign.SelectStartOnDateCurrentOrNext(0);
                selectedUntilDate = CreateCampaign.SelectDateIUntilFieldOfNextDay(1);

                //selected Date time
                selectedTime = CreateCampaign.SelectTimeInAtFieldOfNextslotForMinutes();
                
                //select zone
                selectedZone = CreateCampaign.SelectZoneInTimeZone("India Standard Time");
                Logger.WriteDebugMessage("User should able to add start/end dates and times");

                //Validate schedule from and until dates
                CreateCampaign.VerifyUntillDateGreateThanOtherDate(selectedFromDate, selectedUntilDate);
                Logger.WriteDebugMessage("Schedule until date should greater than schedule from date");

                //Select dates and time. Click on finish button
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                CreateCampaign.VerifyVisibilityOfManageCampaignsAndEditScheduleButtons();
                CreateCampaign.VerifySubTitleOnPage(campaignName, sendDDM, selectedFromDate, selectedTime, selectedZone);
                Logger.WriteDebugMessage("Campaign should save successfully with Title Success Sub Title Your campaign[CampaignName] will be sent[frequency] on[Day] at[Time][Timezone] Manage campaigns and Edit Schedule button should display");

                //Validate saved Campaign in DB
                Queries.GetCampaignIdByName(data, campaignName);
                Queries.GetCampaignFrequencyBasedOngNameAndId(data, campaignName, Convert.ToInt32(data.CampaignId));
                CreateCampaign.VerifyFrequencyData(data.CampaignFrequency, sendDDM, selectedFromDate, selectedUntilDate, selectedTime, selectedZone, null);
                Logger.WriteInfoMessage("Campaign Frequency/Schedule & Timezone gets stored in the DB");
            }
        }


        public static void TC_309805()
        {
            if (TestCaseId == Constants.TC_309805)
            {

                //Variables declaration and object creation
                string timeZone, campaignName, subject, selectedFromDate, selectedTime, selectedZone, sendDDM, selectedUntilDate, selectedDays;
                Campaign data = new Campaign();

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                timeZone = TestData.ExcelData.TestDataReader.ReadData(3, "timeZone");

                //Steps1: Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);


                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Steps2: Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //User lands on Campaign Selection page
                CreateCampaign.VerifyMarketingTabSelection();
                Logger.WriteDebugMessage("User lands on Campaign Selection page");

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Steps3: Enter all required details from Settings to Confirm page
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
                string designCardName = CreateCampaign.SelectAndReturnDesignCardName();
                CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);
                
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");

                //User lands on Design Preview page
                CreateCampaign.VerifyUserNavigateToDesignPreview();
                Logger.WriteDebugMessage("User lands on Design Preview page");

                //Verify the Design selected was added to the template
                //Correct Design preview is shown
                CreateCampaign.ValidateDesignCardTitleOnPreviewPage(designCardName);
                Logger.WriteDebugMessage("Correct Design preview is shown");

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");
                Logger.WriteDebugMessage("User should landed on Confirm page");

                //Validate schedule card displayed in Confirm page
                CreateCampaign.VerifyConfirmHighlightedAndPage();
                CreateCampaign.ClickOnSelfApproveButton();

                //Step4: Select Weekly from sent ddm
                sendDDM = "Weekly";
                CreateCampaign.SelectOptionFromSendDDM(sendDDM);
                WaitForAjaxControls(30);
                Logger.WriteDebugMessage("Weekly should be selected");



                //Step5: Enter start/end dates and time
                //Put days to selection
                //Sun, Mon,Tue, Wed, Thur, Fri, Sat
                selectedDays = CreateCampaign.SelectedADayFromWeek("Sun, Mon");
                selectedFromDate = CreateCampaign.SelectDateInWeeklyFromFieldOfNextDay();
                selectedUntilDate = CreateCampaign.SelectDateIUntilFieldOfNextDay(1);

                //selected Date time
                selectedTime = CreateCampaign.SelectTimeInAtFieldOfNextslotForWeekly();

                //select zone
                selectedZone = CreateCampaign.SelectZoneInTimeZone("India Standard Time");
                Logger.WriteDebugMessage("User should able to add start/end dates and times");

                //Validate schedule from and until dates
                CreateCampaign.VerifyUntillDateGreateThanOtherDate(selectedFromDate, selectedUntilDate);
                Logger.WriteDebugMessage("Schedule until date should greater than schedule from date");
                Helper.WaitForAjaxControls(30);
                //Step6: Select dates and time. Click on finish button
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                CreateCampaign.VerifyVisibilityOfManageCampaignsAndEditScheduleButtons();
                CreateCampaign.VerifySubTitleOnPage(campaignName, sendDDM, selectedFromDate, selectedTime, selectedZone);
                Logger.WriteDebugMessage("Campaign should save successfully with Title Success Sub Title Your campaign[CampaignName] will be sent[frequency] on[Day] at[Time][Timezone] Manage campaigns and Edit Schedule button should display");

                //Step7: Validate saved Campaign in DB
                Queries.GetCampaignIdByName(data, campaignName);
                Queries.GetCampaignFrequencyBasedOngNameAndId(data, campaignName, Convert.ToInt32(data.CampaignId));
                CreateCampaign.VerifyFrequencyData(data.CampaignFrequency, sendDDM, selectedFromDate, selectedUntilDate, selectedTime, null, selectedZone, null, selectedDays);
                Logger.WriteInfoMessage("Campaign Frequency/Schedule & Timezone gets stored in the DB");
            }
        }

        public static void TC_309816()
        {
            if (TestCaseId == Constants.TC_309816)
            {

                //Variables declaration and object creation
                string campaignName, subject, sendDDM, x_minutes;
                Campaign data = new Campaign();

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                x_minutes = TestData.ExcelData.TestDataReader.ReadData(3, "x_minutes");


                //Step 1 : Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);


                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Step 2 : Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //User lands on Campaign Selection page
                CreateCampaign.VerifyMarketingTabSelection();
                Logger.WriteDebugMessage("User lands on Campaign Selection page");

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Step 3 : Enter all required details from Settings to Confirm page
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
                string designCardName = CreateCampaign.SelectAndReturnDesignCardName();
                CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");

                //User lands on Design Preview page
                CreateCampaign.VerifyUserNavigateToDesignPreview();
                Logger.WriteDebugMessage("User lands on Design Preview page");

                //Verify the Design selected was added to the template
                //-Correct Design preview is shown
                CreateCampaign.ValidateDesignCardTitleOnPreviewPage(designCardName);
                Logger.WriteDebugMessage("Correct Design preview is shown");

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");
                Logger.WriteDebugMessage("User should landed on Confirm page");

                //Validate schedule card displayed in Confirm page
                CreateCampaign.VerifyConfirmHighlightedAndPage();
                CreateCampaign.ClickOnSelfApproveButton();

                //Select X-Minutes from sent ddm
                sendDDM = "X-Minute";
                CreateCampaign.SelectOptionFromSendDDM(sendDDM);
                WaitForAjaxControls(30);
                Logger.WriteDebugMessage("Minutes should be selected");

                //Step 4 : Validate minute ddm when x-Minutes selected from send ddm
                CreateCampaign.VerifyOptionFromXMinuteDropdown(x_minutes);
                Logger.WriteDebugMessage("User should be able to select minutes");
            }
        }





        public static void TC_309810()
        {
            if (TestCaseId == Constants.TC_309810)
            {

                //Variables declaration and object creation
                string campaignName, subject, selectedFromDate, selectedTime, selectedTime2, selectedZone, sendDDM, selectedUntilDate, selectedEvery;
                Campaign data = new Campaign();

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
                Logger.WriteDebugMessage("User lands on Campaign Selection page");

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Enter all required details from Settings to Confirm page //
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
                string designCardName = CreateCampaign.SelectAndReturnDesignCardName();
                CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");

                //User lands on Design Preview page
                CreateCampaign.VerifyUserNavigateToDesignPreview();
                Logger.WriteDebugMessage("User lands on Design Preview page");

                //Verify the Design selected was added to the template
                //-Correct Design preview is shown
                CreateCampaign.ValidateDesignCardTitleOnPreviewPage(designCardName);
                Logger.WriteDebugMessage("Correct Design preview is shown");

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");
                Logger.WriteDebugMessage("User should landed on Confirm page");

                //Validate schedule card displayed in Confirm page
                CreateCampaign.VerifyConfirmHighlightedAndPage();
                CreateCampaign.ClickOnSelfApproveButton();

                //Select Hourly from sent ddm
                sendDDM = "Hourly";
                CreateCampaign.SelectOptionFromSendDDM(sendDDM);
                WaitForAjaxControls(30);
                Logger.WriteDebugMessage("Hourly should be selected");

                //Enter start/end dates and time
                selectedFromDate = CreateCampaign.SelectDateInHoursFromFieldOfNextDay();
                selectedUntilDate = CreateCampaign.SelectDateIUntilFieldOfNextDay(1);

                //selected Date time
                selectedTime = CreateCampaign.SelectTimeInAtFieldOfNextslotForMinutes();
                selectedTime2 = CreateCampaign.SelectTimeInAtFieldOfNextslotForUntil();
                // selected every
                selectedEvery = CreateCampaign.SelectCountOfEveryForHours("5");
                //select zone
                selectedZone = CreateCampaign.SelectZoneInTimeZone("India Standard Time");
                Logger.WriteDebugMessage("User should able to add start/end dates and times");

                //Validate schedule from and until dates
                CreateCampaign.VerifyUntillDateGreateThanOtherDate(selectedFromDate, selectedUntilDate);
                Logger.WriteDebugMessage("Schedule until date should greater than schedule from date");

                //Select dates and time. Click on finish button
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                CreateCampaign.VerifyVisibilityOfManageCampaignsAndEditScheduleButtons();
                CreateCampaign.VerifySubTitleOnPage(campaignName, sendDDM, selectedFromDate, selectedTime, selectedZone);
                Logger.WriteDebugMessage("Campaign should save successfully with Title Success Sub Title Your campaign[CampaignName] will be sent[frequency] on[Day] at[Time][Timezone] Manage campaigns and Edit Schedule button should display");

                //Validate saved Campaign in DB
                Queries.GetCampaignIdByName(data, campaignName);
                Queries.GetCampaignFrequencyBasedOngNameAndId(data, campaignName, Convert.ToInt32(data.CampaignId));
                CreateCampaign.VerifyFrequencyData(data.CampaignFrequency, sendDDM, selectedFromDate, selectedUntilDate, selectedTime, selectedTime2, selectedZone, selectedEvery);
                Logger.WriteInfoMessage("Campaign Frequency/Schedule & Timezone gets stored in the DB");
            }
        }


        public static void TC_309811()
        {
            if (TestCaseId == Constants.TC_309811)
            {

                //Variables declaration and object creation
                string campaignName, subject, sendDDM, hours;
                Campaign data = new Campaign();

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                hours = TestData.ExcelData.TestDataReader.ReadData(3, "hours");

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);


                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();

                //User lands on Campaign Selection page
                CreateCampaign.VerifyMarketingTabSelection();
                Logger.WriteDebugMessage("User lands on Campaign Selection page");

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Enter all required details from Settings to Confirm page //
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
                string designCardName = CreateCampaign.SelectAndReturnDesignCardName();
                CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");

                //User lands on Design Preview page
                CreateCampaign.VerifyUserNavigateToDesignPreview();
                Logger.WriteDebugMessage("User lands on Design Preview page");

                //Verify the Design selected was added to the template
                //-Correct Design preview is shown
                CreateCampaign.ValidateDesignCardTitleOnPreviewPage(designCardName);
                Logger.WriteDebugMessage("Correct Design preview is shown");

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");
                Logger.WriteDebugMessage("User should landed on Confirm page");

                //Validate schedule card displayed in Confirm page
                CreateCampaign.VerifyConfirmHighlightedAndPage();
                CreateCampaign.ClickOnSelfApproveButton();

                //Select Hourly from sent ddm
                sendDDM = "Hourly";
                CreateCampaign.SelectOptionFromSendDDM(sendDDM);
                WaitForAjaxControls(30);
                Logger.WriteDebugMessage("Hourly should be selected");

                //Validate hours ddm when Hourly selected from send ddm
                CreateCampaign.VerifyEveryDropDownOptionWhenHourSelected(hours);
                Logger.WriteDebugMessage("Every drop down is displaying  1-23 options");
            }
        }
        public static void TC_309817()
        {
            if (TestCaseId == Constants.TC_309817)
            {

                //Variables declaration and object creation
                string campaignName, subject, timeZone, selectedDate, anothertimeZone, selectedTime, selectedZone, sendDDM;
                Campaign data = new Campaign();

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                timeZone = TestData.ExcelData.TestDataReader.ReadData(3, "timeZone");
                anothertimeZone = TestData.ExcelData.TestDataReader.ReadData(4, "anothertimeZone");

                //Step 1 : Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);
                Navigation.Verify_LandsOnMAPage();

                //Step 2 : Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();
                CreateCampaign.VerifyMarketingTabSelection();
                Logger.WriteDebugMessage("User landed on Campaign Selection page");

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Step 3 : Enter all required details from Settings to Confirm page
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Click on Save and Continue button to save campaign details");
                Helper.WaitForAjaxControls(120);
                CreateCampaign.VerifyUserNavigatedOnTheAudience();
                Logger.WriteDebugMessage("User landed on Audience Card view");
                CreateCampaign.SelectRandomAudienceCardFromFirstPage();
                CreateCampaign.ClickOnSaveAndContinue();
                CreateCampaign.VerifyUserNavigateToAudiencePreview();
                Logger.WriteDebugMessage("User landed on Audience Preview page");
                CreateCampaign.ClickOnSaveAndContinue();
                Helper.WaitForAjaxControls(30);
                CreateCampaign.VerifyUserNavigateToDesignCardView();
                Logger.WriteDebugMessage("User landed on Design Card View");
                string designCardName = CreateCampaign.SelectAndReturnDesignCardName();
                CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);
                CreateCampaign.ClickOnSaveAndContinue();
                Helper.WaitForAjaxControls(150);
                Logger.WriteInfoMessage("Select a design and click Continue");
                CreateCampaign.VerifyUserNavigateToDesignPreview();
                Logger.WriteDebugMessage("User landed on Design Preview page");
                CreateCampaign.ValidateDesignCardTitleOnPreviewPage(designCardName);
                Logger.WriteDebugMessage("Correct Design preview is shown");
                CreateCampaign.ClickOnSaveAndContinue();
                Helper.WaitForAjaxControls(30);
                Logger.WriteDebugMessage("User landed on Confirm page");

                CreateCampaign.VerifyConfirmHighlightedAndPage();
                CreateCampaign.ClickOnSelfApproveButton();
                Logger.WriteDebugMessage("User landed on Schedule page");

                //Step 4 : Select Once from send ddm and enter date and time & Click on Finish
                sendDDM = "Once";
                CreateCampaign.SelectOptionFromSendDDM(sendDDM);
                WaitForAjaxControls(30);
                Logger.WriteDebugMessage("Once selected");
                selectedDate = CreateCampaign.SelectDatesInOnFieldOfNextDay();
                selectedTime = CreateCampaign.SelectTimeInAtFieldOfNextslot();
                selectedZone = CreateCampaign.SelectZoneInTimeZone(timeZone);
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                CreateCampaign.VerifyVisibilityOfManageCampaignsAndEditScheduleButtons();
                Logger.WriteDebugMessage("Campaign saved successfully");

                //Step 5 : Click on Edit Schedule
                CreateCampaign.ClickOnEditSchedule();
                CreateCampaign.VerifyOnSchedulePage();
                Logger.WriteDebugMessage("User navigated back to the Confirm step with the Schedule Card displaying");

                //Step 6 : Validate fields 
                CreateCampaign.VerifyFrequencyOnPageByElement(sendDDM);
                CreateCampaign.VerifyDateOnPageByElementOnce(selectedDate);
                CreateCampaign.VerifyTimeOnPageByElement(selectedTime);
                Logger.WriteDebugMessage("1. Once should be selected 2.Dates and time should displays as entered");

                //Step 7 : Edit Frequency/time/timezone and click on Finish button
                selectedDate = CreateCampaign.SelectDatesInOnFieldOfNextDay();
                selectedTime = CreateCampaign.SelectTimeInAtFieldOfNextslotEditalbe();
                selectedZone = CreateCampaign.SelectZoneInTimeZone(anothertimeZone);
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                CreateCampaign.VerifyVisibilityOfManageCampaignsAndEditScheduleButtons();
                CreateCampaign.VerifySubTitleOnPage(campaignName, sendDDM, selectedDate, selectedTime, selectedZone);
                Logger.WriteDebugMessage("Campaign saved successfully with edited values:Title-Success,Sub Title-Your campaign [CampaignName] will be sent [frequency] on [Day] at [Time] [Timezone],Manage campaigns and Edit Schedule button should display");
                
                
                //Validate saved Campaign in DB
                Queries.GetCampaignIdByName(data, campaignName);
                Queries.GetCampaignFrequencyBasedOngNameAndId(data, campaignName, Convert.ToInt32(data.CampaignId));
                CreateCampaign.VerifyFrequencyData(data.CampaignFrequency, sendDDM, selectedDate, selectedTime, selectedZone);
                Logger.WriteInfoMessage("Campaign Frequency/Schedule & Timezone gets stored in the DB");
            }
        }

        public static void TC_309819()
        {
            if (TestCaseId == Constants.TC_309819)
            {

                //Variables declaration and object creation
                string campaignName, subject, timeZone, selectedTime, anothertimeZone, selectedZone, sendDDM, selectedFromDate, selectedUntilDate,selectedEvery ;
                Campaign data = new Campaign();
                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                timeZone = TestData.ExcelData.TestDataReader.ReadData(3, "timeZone");
                anothertimeZone = TestData.ExcelData.TestDataReader.ReadData(4, "anothertimeZone");

                //Step 1 : Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);
                Navigation.Verify_LandsOnMAPage();

                //Step 2 : Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();
                CreateCampaign.VerifyMarketingTabSelection();
                Logger.WriteDebugMessage("User landed on Campaign Selection page");

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Step 3 : Enter all required details from Settings to Confirm page
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Click on Save and Continue button to save campaign details");
                Helper.WaitForAjaxControls(120);
                CreateCampaign.VerifyUserNavigatedOnTheAudience();
                Logger.WriteDebugMessage("User landed on Audience Card view");
                CreateCampaign.SelectRandomAudienceCardFromFirstPage();
                CreateCampaign.ClickOnSaveAndContinue();
                Helper.WaitForAjaxControls(30);
                CreateCampaign.VerifyUserNavigateToAudiencePreview();
                Logger.WriteDebugMessage("User landed on Audience Preview page");
                CreateCampaign.ClickOnSaveAndContinue();
                Helper.WaitForAjaxControls(30);
                CreateCampaign.VerifyUserNavigateToDesignCardView();
                Logger.WriteDebugMessage("User landed on Design Card View");
                string designCardName = CreateCampaign.SelectAndReturnDesignCardName();
                CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);
                CreateCampaign.ClickOnSaveAndContinue();
                Helper.WaitForAjaxControls(150);
                Logger.WriteInfoMessage("Select a design and click Continue");
                CreateCampaign.VerifyUserNavigateToDesignPreview();
                Logger.WriteDebugMessage("User landed on Design Preview page");
                CreateCampaign.ValidateDesignCardTitleOnPreviewPage(designCardName);
                Logger.WriteDebugMessage("Correct Design preview is shown");
                CreateCampaign.ClickOnSaveAndContinue();
                Helper.WaitForAjaxControls(30);
                Logger.WriteDebugMessage("User landed on Confirm page");

                CreateCampaign.VerifyConfirmHighlightedAndPage();
                CreateCampaign.ClickOnSelfApproveButton();
                Logger.WriteDebugMessage("User landed on Schedule page");

                //Step 4 : Select Daily from send ddm and enter date and time & Click on Finish
                sendDDM = "Daily";
                CreateCampaign.SelectOptionFromSendDDM(sendDDM);
                WaitForAjaxControls(30);
                Logger.WriteDebugMessage("Daily selected"); 
                selectedEvery = CreateCampaign.SelectCountOfEvery("4");
                selectedFromDate = CreateCampaign.SelectDateInDayFromFieldOfNextDay();
                selectedUntilDate = CreateCampaign.SelectDateIUntilFieldOfNextDay(0);
                selectedTime = CreateCampaign.SelectTimeInAtFieldOfNextslot();
                selectedZone = CreateCampaign.SelectZoneInTimeZone(timeZone);
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                CreateCampaign.VerifyVisibilityOfManageCampaignsAndEditScheduleButtons();
                Logger.WriteDebugMessage("Campaign saved successfully");

                //Step 5 : Click on Edit Schedule
                CreateCampaign.ClickOnEditSchedule();
                CreateCampaign.VerifyOnSchedulePage();
                Logger.WriteDebugMessage("User navigated back to the Confirm step with the Schedule Card displaying");

                //Step 6 : Validate fields 
                CreateCampaign.VerifyFrequencyOnPageByElement(sendDDM);
                CreateCampaign.VerifyDateOnPageByElementOther(selectedFromDate);
                CreateCampaign.VerifyTimeOnPageByElement(selectedTime);
                Logger.WriteDebugMessage("1. Daily selected 2.Dates and time displayed as entered");

                //Step 7 : Edit Frequency/time/timezone and click on Finish button
                selectedZone = CreateCampaign.SelectZoneInTimeZone(anothertimeZone);
                selectedEvery = CreateCampaign.SelectCountOfEvery("30");
                selectedFromDate = CreateCampaign.SelectDateInDayFromFieldOfNextDay();
                selectedUntilDate = CreateCampaign.SelectDateIUntilFieldOfNextDay(0);
                selectedTime = CreateCampaign.SelectTimeInAtFieldOfNextslotEditalbe();
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                CreateCampaign.VerifyVisibilityOfManageCampaignsAndEditScheduleButtons();
                CreateCampaign.VerifySubTitleOnPage(campaignName, sendDDM, selectedFromDate, selectedTime, selectedZone);
                Logger.WriteDebugMessage("Campaign saved successfully with edited values:Title-Success,Sub Title-Your campaign [CampaignName] will be sent [frequency] on [Day] at [Time] [Timezone],Manage campaigns and Edit Schedule button should display");
                
                
                //Validate saved Campaign in DB
                Queries.GetCampaignIdByName(data, campaignName);
                Queries.GetCampaignFrequencyBasedOngNameAndId(data, campaignName, Convert.ToInt32(data.CampaignId));
                CreateCampaign.VerifyFrequencyData(data.CampaignFrequency, sendDDM, selectedFromDate, selectedUntilDate, selectedTime, selectedZone, selectedEvery);
                Logger.WriteInfoMessage("Campaign Frequency/Schedule & Timezone gets stored in the DB");
            }
        }

        public static void TC_309821()
        {
            if (TestCaseId == Constants.TC_309821)
            {

                //Variables declaration and object creation
                string campaignName, subject, timeZone,  selectedTime, anothertimeZone, selectedZone, sendDDM,selectedDays,selectedFromDate,selectedUntilDate;
                Campaign data = new Campaign();

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                timeZone = TestData.ExcelData.TestDataReader.ReadData(3, "timeZone");
                anothertimeZone = TestData.ExcelData.TestDataReader.ReadData(4, "anothertimeZone");

                //Step 1 : Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);
                Navigation.Verify_LandsOnMAPage();

                //Step 2 : Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();
                CreateCampaign.VerifyMarketingTabSelection();
                Logger.WriteDebugMessage("User landed on Campaign Selection page");

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Step 3 : Enter all required details from Settings to Confirm page
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Click on Save and Continue button to save campaign details");
                Helper.WaitForAjaxControls(120);
                CreateCampaign.VerifyUserNavigatedOnTheAudience();
                Logger.WriteDebugMessage("User landed on Audience Card view");
                CreateCampaign.SelectRandomAudienceCardFromFirstPage();
                CreateCampaign.ClickOnSaveAndContinue();
                Helper.WaitForAjaxControls(30);
                CreateCampaign.VerifyUserNavigateToAudiencePreview();
                Logger.WriteDebugMessage("User landed on Audience Preview page");
                CreateCampaign.ClickOnSaveAndContinue();
                Helper.WaitForAjaxControls(30);
                CreateCampaign.VerifyUserNavigateToDesignCardView();
                Logger.WriteDebugMessage("User landed on Design Card View");
                string designCardName = CreateCampaign.SelectAndReturnDesignCardName();
                CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);
                CreateCampaign.ClickOnSaveAndContinue();
                Helper.WaitForAjaxControls(150);
                Logger.WriteInfoMessage("Select a design and click Continue");
                CreateCampaign.VerifyUserNavigateToDesignPreview();
                Logger.WriteDebugMessage("User landed on Design Preview page");
                CreateCampaign.ValidateDesignCardTitleOnPreviewPage(designCardName);
                Logger.WriteDebugMessage("Correct Design preview is shown");
                CreateCampaign.ClickOnSaveAndContinue();
                Helper.WaitForAjaxControls(30);
                Logger.WriteDebugMessage("User landed on Confirm page");

                //Validate schedule card displayed in Confirm page
                CreateCampaign.VerifyConfirmHighlightedAndPage();
                CreateCampaign.ClickOnSelfApproveButton();

                //Step 4 : Select Weekly from send ddm and enter date and time & Click on Finish
                sendDDM = "Weekly";
                CreateCampaign.SelectOptionFromSendDDM(sendDDM);
                WaitForAjaxControls(30);
                Logger.WriteDebugMessage("Weekly selected");
                //Sun, Mon,Tue, Wed, Thur, Fri, Sat
                selectedDays = CreateCampaign.SelectedADayFromWeek("Sun, Mon");
                selectedFromDate = CreateCampaign.SelectDateInWeeklyFromFieldOfNextDay();
                selectedUntilDate = CreateCampaign.SelectDateIUntilFieldOfNextDay(1);
                selectedTime = CreateCampaign.SelectTimeInAtFieldOfNextslotForWeekly();
                selectedZone = CreateCampaign.SelectZoneInTimeZone(timeZone);
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                CreateCampaign.VerifyVisibilityOfManageCampaignsAndEditScheduleButtons();
                Logger.WriteDebugMessage("Campaign saved successfully");

                //Step 5 : Click on Edit Schedule
                CreateCampaign.ClickOnEditSchedule();
                CreateCampaign.VerifyOnSchedulePage();
                Logger.WriteDebugMessage("User navigated back to the Confirm step with the Schedule Card displaying");

                //Step 6 : Validate fields 
                CreateCampaign.VerifyFrequencyOnPageByElement(sendDDM);
                CreateCampaign.VerifyDateOnPageByElementOther(selectedFromDate);
                CreateCampaign.VerifyTimeOnPageByElement(selectedTime);
                Logger.WriteDebugMessage("1. Weekly selected 2.Dates and time displayed as entered");

                //Step 7 : Edit Frequency/time/timezone and click on Finish button
                //Sun, Mon,Tue, Wed, Thur, Fri, Sat
                selectedDays = CreateCampaign.SelectedADayFromWeek("Sun, Mon, Sat");
                selectedFromDate = CreateCampaign.SelectDateInWeeklyFromFieldOfNextDay();
                selectedUntilDate = CreateCampaign.SelectDateIUntilFieldOfNextDay(1);
                selectedTime = CreateCampaign.SelectTimeInAtFieldOfNextslotEditalbe();
                selectedZone = CreateCampaign.SelectZoneInTimeZone(anothertimeZone);
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                CreateCampaign.VerifyVisibilityOfManageCampaignsAndEditScheduleButtons();
                CreateCampaign.VerifySubTitleOnPage(campaignName, sendDDM, selectedFromDate, selectedTime, selectedZone);
                Logger.WriteDebugMessage("Campaign saved successfully with edited values:Title-Success,Sub Title-Your campaign [CampaignName] will be sent [frequency] on [Day] at [Time] [Timezone],Manage campaigns and Edit Schedule button should display");


                //Validate saved Campaign in DB
                Queries.GetCampaignIdByName(data, campaignName);
                Queries.GetCampaignFrequencyBasedOngNameAndId(data, campaignName, Convert.ToInt32(data.CampaignId));
                CreateCampaign.VerifyFrequencyData(data.CampaignFrequency, sendDDM, selectedFromDate, selectedUntilDate, selectedTime, null, selectedZone, null, selectedDays);
                Logger.WriteInfoMessage("Campaign Frequency/Schedule & Timezone gets stored in the DB");
            }
        }

        public static void TC_309825()
        {
            if (TestCaseId == Constants.TC_309825)
            {

                //Variables declaration and object creation
                string campaignName, subject, timeZone, anothertimeZone,  selectedTime, selectedZone, sendDDM, selectedFromDate, selectedUntilDate,selectedEvery ;
                Campaign data = new Campaign();

                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                timeZone = TestData.ExcelData.TestDataReader.ReadData(3, "timeZone");
                anothertimeZone = TestData.ExcelData.TestDataReader.ReadData(4, "anothertimeZone");

                //Step 1 : Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);
                Navigation.Verify_LandsOnMAPage();

                //Step 2 : Click to create a campaign
                CreateCampaign.ClickOnCreateCampaign();
                CreateCampaign.VerifyMarketingTabSelection();
                Logger.WriteDebugMessage("User landed on Campaign Selection page");

                //Select a card to proceed to the Settings page
                Helper.WaitForAjaxControls(120);
                CreateCampaign.ClickingOnCardFirstStepOfCampaign();

                //Step 3 : Enter all required details from Settings to Confirm page
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Click on Save and Continue button to save campaign details");
                Helper.WaitForAjaxControls(120);
                CreateCampaign.VerifyUserNavigatedOnTheAudience();
                Logger.WriteDebugMessage("User landed on Audience Card view");
                CreateCampaign.SelectRandomAudienceCardFromFirstPage();
                CreateCampaign.ClickOnSaveAndContinue();
                Helper.WaitForAjaxControls(30);
                CreateCampaign.VerifyUserNavigateToAudiencePreview();
                Logger.WriteDebugMessage("User landed on Audience Preview page");
                CreateCampaign.ClickOnSaveAndContinue();
                Helper.WaitForAjaxControls(30);
                CreateCampaign.VerifyUserNavigateToDesignCardView();
                Logger.WriteDebugMessage("User landed on Design Card View");
                string designCardName = CreateCampaign.SelectAndReturnDesignCardName();
                CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);
                CreateCampaign.ClickOnSaveAndContinue();
                Helper.WaitForAjaxControls(150);
                Logger.WriteInfoMessage("Select a design and click Continue");
                CreateCampaign.VerifyUserNavigateToDesignPreview();
                Logger.WriteDebugMessage("User landed on Design Preview page");
                CreateCampaign.ValidateDesignCardTitleOnPreviewPage(designCardName);
                Logger.WriteDebugMessage("Correct Design preview is shown");
                CreateCampaign.ClickOnSaveAndContinue();
                Helper.WaitForAjaxControls(30);
                Logger.WriteDebugMessage("User landed on Confirm page");

                CreateCampaign.VerifyConfirmHighlightedAndPage();
                CreateCampaign.ClickOnSelfApproveButton();

                //Step 4 : Select Monthly from send ddm and enter date and time & Click on Finish
                sendDDM = "Monthly";
                CreateCampaign.SelectOptionFromSendDDM(sendDDM);
                WaitForAjaxControls(30);
                Logger.WriteDebugMessage("Monthly selected");
                selectedEvery = CreateCampaign.SelectCountOfEveryForMonth("6");
                selectedFromDate = CreateCampaign.SelectDateInMonthsFromFieldOfNextDay();
                selectedUntilDate = CreateCampaign.SelectDateIUntilFieldOfNextDay(2);
                selectedTime = CreateCampaign.SelectTimeInAtFieldOfNextslot();
                selectedZone = CreateCampaign.SelectZoneInTimeZone(timeZone);
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                CreateCampaign.VerifyVisibilityOfManageCampaignsAndEditScheduleButtons();
                Logger.WriteDebugMessage("Campaign saved successfully");

                //Step 5 : Click on Edit Schedule
                CreateCampaign.ClickOnEditSchedule();
                CreateCampaign.VerifyOnSchedulePage();
                Logger.WriteDebugMessage("User navigated back to the Confirm step with the Schedule Card displaying");

                //Step 6 : Validate fields 
                CreateCampaign.VerifyFrequencyOnPageByElement(sendDDM);
                CreateCampaign.VerifyDateOnPageByElementOther(selectedFromDate);
                CreateCampaign.VerifyTimeOnPageByElement(selectedTime);
                Logger.WriteDebugMessage("1. Monthly selected 2.Dates and time displayed as entered");

                //Step 7 : Edit Frequency/time/timezone and click on Finish button
                CreateCampaign.VerifyOnSchedulePage();
                selectedEvery = CreateCampaign.SelectCountOfEveryForMonth("12");
                selectedFromDate = CreateCampaign.SelectDateInMonthsFromFieldOfNextDay();
                selectedUntilDate = CreateCampaign.SelectDateIUntilFieldOfNextDay(2);
                selectedTime = CreateCampaign.SelectTimeInAtFieldOfNextslot();
                selectedZone = CreateCampaign.SelectZoneInTimeZone(anothertimeZone);
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                CreateCampaign.VerifyVisibilityOfManageCampaignsAndEditScheduleButtons();
                CreateCampaign.VerifySubTitleOnPage(campaignName, sendDDM, selectedFromDate, selectedTime, selectedZone);
                Logger.WriteDebugMessage("Campaign saved successfully with edited values:Title-Success,Sub Title-Your campaign [CampaignName] will be sent [frequency] on [Day] at [Time] [Timezone],Manage campaigns and Edit Schedule button should display");
                
                
                //Validate saved Campaign in DB
                Queries.GetCampaignIdByName(data, campaignName);
                Queries.GetCampaignFrequencyBasedOngNameAndId(data, campaignName, Convert.ToInt32(data.CampaignId));
                CreateCampaign.VerifyFrequencyData(data.CampaignFrequency, sendDDM, selectedFromDate, selectedUntilDate, selectedTime, selectedZone, selectedEvery);
                Logger.WriteInfoMessage("Campaign Frequency/Schedule & Timezone gets stored in the DB");
            }
        }
        #endregion[TP_309532]
    }
}
