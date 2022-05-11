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
using BaseUtility.Utility.Hotmail;

namespace MarketingAutomation.AppModule.MainAdminApp
{

    public partial class MainAdminApp : Utility.Setup
    {
        #region[TP_357992]
        public static void TC_333249()
        {
            if (TestCaseId == Constants.TC_333249)
            {

                //Variables declaration and object creation
                string campaignName, subject, selectedZone, sendDDM, cards, defaultsendDDM,rejectComment, rejectText;
                Campaign data = new Campaign();


                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                cards = TestData.ExcelData.TestDataReader.ReadData(3, "cards");
                sendDDM = TestData.ExcelData.TestDataReader.ReadData(4, "sendDDM");
                defaultsendDDM = TestData.ExcelData.TestDataReader.ReadData(5, "defaultsendDDM");
                rejectComment = TestData.ExcelData.TestDataReader.ReadData(6, "rejectComments");
                rejectText = TestData.ExcelData.TestDataReader.ReadData(7, "rejectText"); 

                //Step1 : Navigate to Marketing Automation and log in as a valid Admin user.
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);
                //User lands on Marketing Automation with initial icon on top right corner
                Navigation.Verify_LandsOnMAPage();
                //initial icon on top right corner
                CreateCampaign.Verify_TopIcon();
                Logger.WriteInfoMessage("User lands on Marketing Automation with initial icon on top right corner");


                //Step 2: Click on Campaign Left Navigation Menu.
                Navigation.ClickOnSidebarCampaigns();
                //User lands on Campaign Manage page with Marketing Campaigns default 3 x 3 Card view 
                CreateCampaign.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("User lands on Campaign Manage page with Marketing Campaigns default 3 x 3 Card view ");


                //Step 3 : Click on Create Campaign
                CreateCampaign.ClickOnCreateCampaign();
                string expTabs = "Marketing, Automated";
                CreateCampaign.VerifyTabsAreAvailabeOrNot(expTabs);
                Logger.WriteInfoMessage("User Lands on Create Campaign Page with 2 tabs as 1 - Marketing 2 - Automated");
                CreateCampaign.VerifyMarketingTabSelection();
                Logger.WriteDebugMessage("User Lands on Create Campaign Page with 2 tabs as 1 - Marketing 2 - Automated");

                //Step 4 : Verify Marketing Campaign Selection Card >> Create Campaign. 
                CreateTemplate.VerifyTabSelection();
                Helper.WaitForAjaxControls(120);
                CreateCampaign.VerifyCardsOnMarketingTab(cards);
                Logger.WriteDebugMessage("Event types are available for Marketing Campaign:- - One Time. - Auto Response. - Custom.");
                //step 5: Select One-Time Card and click on Continue.
                CreateCampaign.ClickingOnCardBasedOnName(cards.Split(',')[0]);
                CreateCampaign.VerifyWizardStepsSettingsAudienceDesignAndConfirm();
                Logger.WriteDebugMessage("1. User lands on Setting Page." +
                    "2. Navigated successfully to Marketing Campaigns  Page with Following steps as 1 - Settings ​​​​​​​2 - Audience ​​​​​​​3 - Design 4 - Confirm");

                //Step 6 : Enter all required details and ​​​​​​​Click Save and Continue.
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("Click on Save and Continue button to save campaign details");
                Helper.WaitForAjaxControls(120);
                CreateCampaign.VerifyUserNavigatedOnTheAudience();
                Logger.WriteDebugMessage("User lands on Audience Page.");

                //step 7: Select Audience and click on Save and Continue.
                CreateCampaign.SelectRandomAudienceCardFromFirstPage();
                CreateCampaign.ClickOnSaveAndContinue();

                //User lands on Audience Preview page
                CreateCampaign.VerifyUserNavigateToAudiencePreview();
                Logger.WriteDebugMessage("User lands on Audience Preview page");

                //step 8: Click Continue button
                CreateCampaign.ClickOnSaveAndContinue();

                // User lands on Design Page.
                CreateCampaign.VerifyUserNavigateToDesignCardView();
                Logger.WriteDebugMessage("User lands on Design Page.");

                //step 9: Select Design and click on Save and Continue.
                string designCardName = CreateCampaign.SelectAndReturnDesignCardName();
                CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("User lands on Design Preview Page.");

                //User lands on Design Preview Page.
                CreateCampaign.VerifyUserNavigateToDesignPreview();
                Logger.WriteDebugMessage("User lands on Design Preview Page.");

                //Verify the Design selected was added to the template
                //-Correct Design preview is shown
                CreateCampaign.ValidateDesignCardTitleOnPreviewPage(designCardName);
                Logger.WriteDebugMessage("Correct Design preview is shown");
                // step 10 : Click on Save & Continue.
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("User lands on Confirm page with Self Approve and  Send Request Button.");

                //step 11: Click on Send Request Button
                CreateCampaign.ClickOnSendRequestAndVerifyButtons();
                Logger.WriteDebugMessage("User lands on Confirm page with Approve and  Reject Button.");

                //step 12: Click on Reject Button.
                CreateCampaign.ClickOnRejectButtonAndVerifyCommentBox();
                Logger.WriteDebugMessage("Reject Approval Modal Pop-Up should get displayed.");
                

                //step 13: Enter Reject Comments >> Data and click on Reject Button.
                CreateCampaign.EnterCommentAndRejectButton(rejectComment);
                CreateCampaign.VerifyCommentsAndUserName(rejectComment, Constants.Username, rejectText);
                Logger.WriteDebugMessage("Reject Comments should get displayed >> Confirm Page. "+
                            "Your Request was Rejected on[Date / Time] by[Username]."+
                            "Comments :-Comments Added[Text]. Buttons:-Self Approve and Send Request.");

                //Validate schedule card displayed in Confirm page
                CreateCampaign.VerifyConfirmHighlightedAndPage();
                //step 14: Click on Approve >> Send Request Button.
                CreateCampaign.ClickOnSelfApproveButton();

                // step 15: Click on Search DDM Tab.  Once ddm should get loaded by default.
                CreateCampaign.VerifySendDMMDefaultValue(defaultsendDDM);
                CreateCampaign.VerifyTimeZoneValue();
                Logger.WriteDebugMessage("Send  Schedule Card should get displayed with following details:-Default Time Zone Preference. ");

                //step 16: Set [Date/Time] with selected Time Zone Preference.

                //Select Weekly from sent ddm
                //Weekly should be selected
                CreateCampaign.SelectOptionFromSendDDM(sendDDM);
                WaitForAjaxControls(30);
                Logger.WriteDebugMessage($"{sendDDM} should be selected");

                //Put days to selection
                //1-Sun, 2-Mon, 3-Tue, 4-Wed, 5-Thur, 6-Fri, 7-Sat
                CreateCampaign.SelectedADayFromWeek("Mon,Tue");

                //select zone
                selectedZone = CreateCampaign.SelectZoneInTimeZone("India Standard Time");
                Logger.WriteDebugMessage("[Date/Time] with Time Zone should get displayed.");

                //steps 17: Click on Finish.
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                CreateCampaign.VerifyVisibilityOfManageCampaignsAndEditScheduleButtons();
                CreateCampaign.VerifySubTitleOnPage(campaignName, sendDDM, selectedZone);
                Logger.WriteDebugMessage("Campaign should get scheduled and land on Success Page with details:-" +
                                            "Scheduled Campaign Name with Set[Date / Time] with Time Zone. Manage Campaign Button.Edit Schedule Button.");

                //Step 18: Click Manage Campaign
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("User should navigated to Manage Campaign Page.");

                //step 16: Search for the campaign which is created recently.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Equal", campaignName);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.VerifyFilterCampaignInfoOnPage(campaignName, null, null, null, null);
                Logger.WriteDebugMessage("Campaign should be available in Manage campaign with status as Scheduled.");
            }
        }

        public static void TC_357987()
        {
            if (TestCaseId == Constants.TC_357987)
            {

                //Variables declaration and object creation
                string campaignName, subject, selectedZone, sendDDM, cards, defaultsendDDM, selectedFromDate, selectedUntilDate, selectedTime, rejectComment, rejectText;
                Campaign data = new Campaign();

                
                //Read the data
                campaignName = TestData.ExcelData.TestDataReader.ReadData(1, "campaignName");
                subject = TestData.ExcelData.TestDataReader.ReadData(2, "subject");
                cards = TestData.ExcelData.TestDataReader.ReadData(3, "cards");
                defaultsendDDM = TestData.ExcelData.TestDataReader.ReadData(4, "defaultsendDDM");
                rejectComment = TestData.ExcelData.TestDataReader.ReadData(5, "rejectComments");
                rejectText = TestData.ExcelData.TestDataReader.ReadData(6, "rejectText");

                //Step1 : Navigate to Marketing Automation and log in as a valid Admin user.
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);
                //User lands on Marketing Automation with initial icon on top right corner
                Navigation.Verify_LandsOnMAPage();
                //initial icon on top right corner
                CreateCampaign.Verify_TopIcon();
                Logger.WriteInfoMessage("User lands on Marketing Automation with initial icon on top right corner");


                //Step 2: Click on Campaign Left Navigation Menu.
                Navigation.ClickOnSidebarCampaigns();
                CreateCampaign.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("User lands on Campaign Manage page with Marketing Campaigns default 3 x 3 Card view");


                //Step 3 :Click on Automated Tab.
                CreateCampaign.ToggletoAutomatedTtab();
                CreateCampaign.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("User lands on Campaign Manage page with Automated Campaigns default 3 x 3 Card view.");

                //Step 4 : Click on Create Campaign
                CreateCampaign.ClickOnCreateCampaign();
                string expTabs = "Marketing, Automated";
                CreateCampaign.VerifyTabsAreAvailabeOrNot(expTabs);
                CreateCampaign.VerifyMarketingTabSelection();
                Logger.WriteDebugMessage("User Lands on Campaign Selection Page with Tabs:- 1 - Marketing. 2 - Automated.  Note:-Marketing Campaign Selection Page get loaded by default.");

                //step 5: Verify Automated Campaign Selection Card >> Click on Automated Tab.
                CreateCampaign.ToggletoAutomatedTtab();
                Helper.WaitForAjaxControls(120);
                CreateCampaign.VerifyCardsOnMarketingTab(cards);
                Logger.WriteDebugMessage("6 event types are available for Automated Campaign:  - Confirmation. - Updates. - Cancellation. - Pre stay and Post stay. - Custom.");


                //step 6: Select Confirmation Card and click on Continue.
                CreateCampaign.ClickingOnCardBasedOnName(cards.Split(',')[0]);
                CreateCampaign.VerifyWizardStepsSettingsDesignAndConfirm();
                Logger.WriteDebugMessage("User lands on Setting Page.");

                //Step 7 : Enter all required details and ​​​​​​​Click Save and Continue.
                campaignName = campaignName + Helper.GetRandomNumber(2);
                subject = subject + Helper.GetRandomNumber(2);
                CreateCampaign.EnterCampaignName(campaignName);
                CreateCampaign.EnterSubject(subject);
                CreateCampaign.ClickOnFromDropDownAndSelectFirstValue();
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("Click on Save and Continue button to save campaign details");
                Helper.WaitForAjaxControls(120);
                // User lands on Design Page.
                CreateCampaign.VerifyUserNavigateToDesignCardViewMA();
                Logger.WriteDebugMessage("User lands on Template Page.");

                //step 8: Select Template and click on Save and Continue.
                string designCardName = CreateCampaign.SelectAndReturnDesignCardName();
                CreateCampaign.VerifyCorrectDesignCardSelected(designCardName);

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("User lands on Design Preview Page.");

                //User lands on Design Preview Page.
                CreateCampaign.VerifyUserNavigateToDesignPreviewMA();
                Logger.WriteDebugMessage("User lands on Design Preview Page.");

                //Verify the Design selected was added to the template
                //-Correct Design preview is shown
                CreateCampaign.ValidateDesignCardTitleOnPreviewPage(designCardName);
                Logger.WriteDebugMessage("Correct Design preview is shown");
                // step 9 : Click on Save & Continue.
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("User lands on Confirm page with Self Approve and  Send Request Button.");

                //step 10: Click on Send Request Button
                CreateCampaign.ClickOnSendRequestAndVerifyButtons();
                Logger.WriteDebugMessage("User lands on Confirm page with Approve and  Reject Button.");

                //step 11: Click on Reject Button.
                CreateCampaign.ClickOnRejectButtonAndVerifyCommentBox();
                Logger.WriteDebugMessage("Reject Approval Modal Pop-Up should get displayed.");


                //step 12: Enter Reject Comments >> Data and click on Reject Button.
                CreateCampaign.EnterCommentAndRejectButton(rejectComment);
                CreateCampaign.VerifyCommentsAndUserName(rejectComment, Constants.Username, rejectText);
                Logger.WriteDebugMessage("Reject Comments should get displayed >> Confirm Page. " +
                            "Your Request was Rejected on[Date / Time] by[Username]." +
                            "Comments :-Comments Added[Text]. Buttons:-Self Approve and Send Request.");


                //Validate schedule card displayed in Confirm page
                CreateCampaign.VerifyConfirmHighlightedAndPage();
                //step 13: Click on Approve >> Send Request Button.
                CreateCampaign.ClickOnSelfApproveButton();
                Logger.WriteDebugMessage("User lands on Schedule page.");

                // step 14: Click on Search DDM Tab.  Immediate ddm should get loaded by default.
                CreateCampaign.VerifySendDMMDefaultValue(defaultsendDDM);
                CreateCampaign.VerifyTimeZoneValue();
                Logger.WriteDebugMessage("Send  Schedule Card should get displayed with following details:- Default Time Zone Preference. ");

                //step 15: Set [Date/Time] with selected Time Zone Preference.
                sendDDM = defaultsendDDM;
                //Weekly should be selected
                CreateCampaign.SelectOptionFromSendDDM(sendDDM);
                WaitForAjaxControls(30);
                Logger.WriteDebugMessage($"{sendDDM} should be selected");

                //selectedFromDate = CreateCampaign.SelectStartOnDateCurrentOrNext(0);
                selectedFromDate = CreateCampaign.SelectDateInStartFromFieldOfNextMonth(5);
                selectedUntilDate = CreateCampaign.SelectDateIUntilFieldOfNextDay(6);

                //selected Date time
                selectedTime = CreateCampaign.SelectTimeInAtFieldOfNextslotForMinutes();

                //select zone
                selectedZone = CreateCampaign.SelectZoneInTimeZone("India Standard Time");
                Logger.WriteDebugMessage("[Date/Time] with Time Zone should get displayed.");

                //step 16: Click on Finish.
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                CreateCampaign.VerifyVisibilityOfManageCampaignsAndEditScheduleButtons();
                CreateCampaign.VerifySubTitleOnPage(campaignName, sendDDM, selectedFromDate, selectedTime, selectedZone);
                Logger.WriteDebugMessage("Campaign should get scheduled and land on Success Page with details:- Scheduled Campaign Name with Set[Date / Time] with Time Zone. Manage Campaign Button.Edit Schedule Button.");

                //Step 17: Click Manage Campaign Button.
                Navigation.ClickOnSidebarCampaigns();
                Logger.WriteDebugMessage("User should navigated to Manage Campaign Page.");

                //step 18: Search for the campaign which is created recently under Automated type.
                CreateCampaign.Campaign_Click_Filter();
                ManageCampaign.EnterFilterValues("Name", "Equal", campaignName);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.VerifyFilterCampaignInfoOnPage(campaignName, null, null, null, null);
                Logger.WriteDebugMessage("Campaign should be available in Manage campaign with status as Scheduled.");
            }
        }

        public static void TC_357988()
        {
            if (TestCaseId == Constants.TC_357988)
            {

                //Variables declaration and object creation
                string audienceName, segmentName, domain, field,operation, criteriavalue;

                //Read the data
                audienceName = TestData.ExcelData.TestDataReader.ReadData(1, "audienceName");
                segmentName = TestData.ExcelData.TestDataReader.ReadData(2, "segmentName");
                domain = TestData.ExcelData.TestDataReader.ReadData(3, "domain");
                field = TestData.ExcelData.TestDataReader.ReadData(4, "field");
                operation = TestData.ExcelData.TestDataReader.ReadData(5, "operation");
                criteriavalue = TestData.ExcelData.TestDataReader.ReadData(6, "criteriavalue");


                //Step1: Navigate to Marketing Automation and log in as a valid Admin user.
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation with initial icon on top right corner
                Navigation.Verify_LandsOnMAPage();
                //initial icon on top right corner
                CreateCampaign.Verify_TopIcon();
                Logger.WriteDebugMessage("User lands on Marketing Automation with initial icon on top right corner.");

                //Step2: Click on Audience Left Navigation Menu.
                Navigation.ClickOnSidebarAudience();
                CreateCampaign.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Admin able to Audience Manage page with Audience default 3 x 3 Card view.");

                // Step3: Verify Toggle switch between Audience and Segment Tab.
                CreateAudience.ClickOnSegmentAndVerifyTitle();
                CreateAudience.ClickOnAudienceAndVerifyTitle();
                Logger.WriteDebugMessage("Toggle to switch between Audience and Segment.");

                //Step4: Click on Create Audience.
                CreateAudience.ClickOnCreateAudience();
                CreateAudience.VerifyWizardStepsSettings();
                Logger.WriteDebugMessage("User lands on Setting Page.");

                //Step5: Enter all required details and ​​​​​​​Click Save and Continue.
                CreateAudience.EnterAudienceName(audienceName);
                CreateAudience.ClickOnSave();
                Logger.WriteDebugMessage("Audience created successfully with status as Draft Status.");

                //Step6: Again navigate on Audience Left Navigation Menu.
                Navigation.ClickOnSidebarAudience();
                CreateAudience.VerifyAudienceInList(audienceName,"Draft");
                Logger.WriteDebugMessage("Recent Audience should be available in Manage Audience Page.");

                //Step7: Click on Segment Tab.
                CreateAudience.ClickOnSegmentAndVerifyTitle();
                CreateAudience.Verify3x3SegmentCardsAvailableOrNot();
                Logger.WriteDebugMessage("Admin able to Segment Manage page with Segment default 3 x 3 Card view.");

                //Step8: Click on Create Segment.
                CreateAudience.ClickOnCreateSegment();
                CreateAudience.VerifyWizardStepsSettings();
                Logger.WriteDebugMessage("User lands on Setting Page.");

                //Step9: Enter all required details and ​​​​​​​Click Save and Continue.
                CreateAudience.EnterSegmentName(segmentName);
                CreateAudience.ClickOnSave();
                CreateAudience.SelectDomain(domain);
                CreateAudience.SelectField(field);
                CreateAudience.SelectOperation(operation);
                CreateAudience.EnterCriteriaValue(criteriavalue);
                CreateAudience.ClickOnSave();
                CreateAudience.ClickOnFinish();
                CreateAudience.VerifySegmentCreationPage();
                Logger.WriteDebugMessage("Segment created successfully with status as Draft Status.");

                //Step10: Again navigate on Audience Left Navigation Menu.Click on Segment
                Navigation.ClickOnSidebarAudience();
                CreateAudience.ClickOnSegmentAndVerifyTitle();
                Logger.WriteDebugMessage("Manage Segment page should get display.");

                //Step11: Search for the Segment which is created recently >> Click on Segment Tab.
                CreateAudience.VerifySegmenteInList(segmentName, "Draft");
                Logger.WriteDebugMessage("Segment should be available in Manage Segment.");
            }
        }

        public static void TC_357993()
        {
            if (TestCaseId == Constants.TC_357993)
            {

                //Variables declaration and object creation
                string editURL, cloneURL, suffixClone, filterNameValue, filterName, cloneCampaignName, titleCampaignName;

                
                //Read the data
                editURL = TestData.ExcelData.TestDataReader.ReadData(1, "editURL");
                cloneURL = TestData.ExcelData.TestDataReader.ReadData(2, "cloneURL");
                suffixClone = TestData.ExcelData.TestDataReader.ReadData(3, "suffixClone");
                filterNameValue = TestData.ExcelData.TestDataReader.ReadData(4, "filterNameValue");
                filterName = TestData.ExcelData.TestDataReader.ReadData(5, "filterName");

                //Variables declaration and object creation
                string campaignID;
                string[] campaignDetails = new string[2];

                ///Step1 : Navigate to Marketing Automation and log in as a valid Admin user.
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);
                //User lands on Marketing Automation with initial icon on top right corner
                Navigation.Verify_LandsOnMAPage();
                //initial icon on top right corner
                CreateCampaign.Verify_TopIcon();
                Logger.WriteInfoMessage("User lands on Marketing Automation with initial icon on top right corner");

                //Step 2: Click on Campaign Left Navigation Menu.
                Navigation.ClickOnSidebarCampaigns();
                //User lands on Campaign Manage page with Marketing Campaigns default 3 x 3 Card view 
                CreateCampaign.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("User lands on Campaign Manage page with Marketing Campaigns default 3 x 3 Card view ");

                //taking random id from the list to edit campaign
                campaignDetails = CreateCampaign.getTitleAndIdOfCampaignCardRandom();
                titleCampaignName = campaignDetails[0];
                campaignID = campaignDetails[1];

                //Step3: Click on Edit Option >> Ellipse
                CreateCampaign.ClickOnCamapignCardEllipseEdit(campaignID);
                CreateCampaign.VrifySettingsChecked();
                editURL = editURL + campaignID;
                CreateCampaign.VrifyURLs(editURL);
                Logger.WriteDebugMessage("User lands on Setting Page and should redirected to:- https://marketingqa.gocendyn.com/build-campaign/[campaign-id].");

                // Step4:Again navigate on Campaign Left Navigation Menu.
                Navigation.ClickOnSidebarCampaigns();
                CreateCampaign.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("User again navigates to Campaign Manage page.");

                //taking random id from the list to edit campaign
                campaignDetails = CreateCampaign.getTitleAndIdOfCampaignCardRandom();
                titleCampaignName = campaignDetails[0];
                campaignID = campaignDetails[1];

                //Step5: Click on Clone Option >> Ellipse
                CreateCampaign.ClickOnCamapignCardEllipseClone(campaignID);
                cloneURL = cloneURL + campaignID;
                CreateCampaign.VrifyURLs(cloneURL);
                Logger.WriteDebugMessage("User lands on Setting Page and should redirected to:- https://marketingqa.gocendyn.com/campaigns/build-campaign/settings/cloneFrom=[campaign-id].");


                //Step6: Clone Campaign from Setting Page and proceed till Success Page.
                cloneCampaignName = CreateCampaign.VerifySuffixAndPrepopulatedDataOnCampaignName(titleCampaignName, suffixClone);
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("Click on Save and Continue button to save campaign details");
                Helper.WaitForAjaxControls(120);
                CreateCampaign.VerifyUserNavigatedOnTheAudience();
                Logger.WriteDebugMessage("User lands on Audience Card view");

                //Select an Audience and click Continue
                //CreateCampaign.SelectRandomAudienceCardFromFirstPage();
                CreateCampaign.ClickOnSaveAndContinue();

                //User lands on Audience Preview page
                CreateCampaign.VerifyUserNavigateToAudiencePreview();
                Logger.WriteDebugMessage("User lands on Audience Preview page");

                //Click Continue button
                CreateCampaign.ClickOnSaveAndContinue();

                //User lands on Design Card View
                CreateCampaign.VerifyUserNavigateToDesignCardView();
                Logger.WriteDebugMessage("User lands on Design Card View");

                //Click on Save and Continue.
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("User lands on Design page.");

                //Click on Save and Continue.
                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteDebugMessage("User lands on Design page.");

                //Click on Send Request.
                CreateCampaign.ClickOnSelfApproveButton();
                CreateCampaign.ClickOnFinishButton();
                CreateCampaign.VerifySuccessTextOnConfirmPage();
                Logger.WriteDebugMessage("Campaign should get cloned.");

                //Step 7: Again go to Manage Campaign Page and check the Clone Campaign created.
                Navigation.ClickOnSidebarCampaigns();
                CreateCampaign.applyFilter(filterName, filterNameValue, cloneCampaignName);
                ManageCampaign.VerifyFilterCampaignInfoOnPage(cloneCampaignName, null, null, null, null);
                Logger.WriteDebugMessage("Campaign should append with clone.");

            }
        }

        public static void TC_357994()
        {
            if (TestCaseId == Constants.TC_357994)
            {

                //Variables declaration and object creation
                string filterOption, sortOption, titleCampaignName, campaignID;
                string[] campaignDetails = new string[2];

                //Read the data
                filterOption = TestData.ExcelData.TestDataReader.ReadData(1, "filterOption");
                sortOption = TestData.ExcelData.TestDataReader.ReadData(2, "sortOption");

                //Step1 : Navigate to Marketing Automation and log in as a valid Admin user.
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);
                //User lands on Marketing Automation with initial icon on top right corner
                Navigation.Verify_LandsOnMAPage();
                //initial icon on top right corner
                CreateCampaign.Verify_TopIcon();
                Logger.WriteInfoMessage("User lands on Marketing Automation with initial icon on top right corner");

                //Step 2: Click on Campaign Left Navigation Menu.
                Navigation.ClickOnSidebarCampaigns();
                //User lands on Campaign Manage page with Marketing Campaigns default 3 x 3 Card view 
                CreateCampaign.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("User lands on Campaign Manage page with Marketing Campaigns default 3 x 3 Card view ");



                //taking random id from the list to edit campaign
                campaignDetails = CreateCampaign.getTitleAndIdOfCampaignCardRandom();
                titleCampaignName = campaignDetails[0];
                campaignID = campaignDetails[1];

                //Step3: Click on Edit Option >> Ellipse
                CreateCampaign.ClickOnCamapignCardEllipseViewDetails(campaignID);
                ManageCampaign.VerifySummaryTab();
                Logger.WriteDebugMessage("User lands on Campaign Summary Page.");

                //Step4: Click on Audience Tab 
                ManageCampaign.ClickOnViewCampaignAudienceTab();
                Logger.WriteDebugMessage("User lands on Audience Page.");

                //Step5: Click on Design Tab 
                ManageCampaign.ClickOnViewCampaignDesignTab();
                Logger.WriteDebugMessage("User lands on Design Page.");

                //Step6: Click on Campaign tab
                Navigation.ClickOnSidebarCampaigns();
                CreateCampaign.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("User again navigated to Campaign Manage page.");

                IList<string> step8Info = ManageCampaign.GetCampaignInfoFromPageByProvidingName("campaignName", null, null, null, null);
                //Step7: Click on Filter Tab. Select Name Filter Tab.
                CreateCampaign.Campaign_Click_Filter();
                ManageTemplate.ClickOnFilterIconAndVerifyFilterOptionsDropDownValue("Name", filterOption);
                Logger.WriteDebugMessage("Name Filter Pop-Up should get opened with drop-down options:- Start - With. Ends - With. Contains. Equals.");

                //Step8: Enter data in Name Filter Tab - Start With Option. Click on Apply.
                ManageCampaign.EnterFilterValues("Name", "Starts With", step8Info[0]);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageCampaign.VerifyFilterCampaignInfoOnPage(step8Info[0], null, null, null, null);
                Logger.WriteDebugMessage("should get display according to Name Filter.");
                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();

                //Step9: Click on Sort Tab. Select ID Sort Tab.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.VerifySortOptions(sortOption);
                Logger.WriteDebugMessage("ID Sort Pop - Up should get opened with drop - down options: -      Least - Most.      Most - Least.");

                //Step10: Select Sort Least-Most drop-down option. Click on Apply.
                ManageCampaign.SelectSortType("ID");
                ManageCampaign.ClickOnSortApplyButton();
                ManageCampaign.VerifyCampaignOrderIDsDesc();
                Logger.WriteDebugMessage("Campaigns should get display according to ID Sort.");
            }
        }

        public static void TC_357995()
        {
            if (TestCaseId == Constants.TC_357995)
            {

                //Variables declaration and object creation
                string filterOption, sortOption;
                string[] campaignDetails = new string[2];

                //Read the data
                filterOption = TestData.ExcelData.TestDataReader.ReadData(1, "filterOption");
                sortOption = TestData.ExcelData.TestDataReader.ReadData(2, "sortOption");

                //Step1 : Navigate to Marketing Automation and log in as a valid Admin user.
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);
                //User lands on Marketing Automation with initial icon on top right corner.
                Navigation.Verify_LandsOnMAPage();
                //initial icon on top right corner
                CreateCampaign.Verify_TopIcon();
                Logger.WriteInfoMessage("User lands on Marketing Automation with initial icon on top right corner");

                //Step 2: Click on Audience Left Navigation Menu.
                Navigation.ClickOnSidebarAudience();
                CreateAudience.VerifyAudience3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Admin able to Audience Manage page with Audience default 3 x 3 Card view.");

                //Step3: Click on View Detail >> Ellipse
                Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                CreateTemplate.Click_TemplatePage_Ellipses();
                CreateTemplate.Click_TemplatePage_Ellipses_ViewDetails();
                CreateAudience.VerifyAudienceSummaryPage();
                Logger.WriteDebugMessage("User lands on Audience Summary Page.");

                //Step4: Click on Campaigns Tab 
                Navigation.ClickOnSidebarCampaigns();
                CreateCampaign.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("User lands on Campaign Page.");

                //Step5: Again navigate on Audience Left Navigation Menu.
                Navigation.ClickOnSidebarAudience();
                CreateAudience.VerifyUserNavigateToAudienceCardView();
                Logger.WriteDebugMessage("User lands back to Audience Manage Page.");

                //Step6: Click on Filter Tab. Select Name Filter Tab.
                string randomAudinceName = ManageAudience.GetAudienceName();
                CreateCampaign.Campaign_Click_Filter();
                ManageTemplate.ClickOnFilterIconAndVerifyFilterOptionsDropDownValue("Name", filterOption);
                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Filter();
                Logger.WriteDebugMessage("Name Filter Pop-Up should get opened with drop-down options:- Start - With. Ends - With. Contains. Equals.");

                //Step7: Enter data in Name Filter Tab - Start With Option. Click on Apply.
                ManageCampaign.EnterFilterValues("Name", "Starts With", randomAudinceName);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                ManageAudience.VerifyFilterAudienceInfoOnPage(randomAudinceName);
                Logger.WriteDebugMessage("Audience should get display according to Name Filter.");

                //Step8: Click on Clear Button.
                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                Logger.WriteDebugMessage("Default Audience Manage Page should get loaded.");

                //Step9: Click on Sort Tab. Select Name Sort Tab.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.VerifySortOptions(sortOption);
                Logger.WriteDebugMessage("Name Sort Pop-Up should get opened with drop-down options:- A - Z. Z - A.");

                //Step10: Select Sort Z-A drop-down option. Click on Apply.
                ManageCampaign.SelectSortType("Name");
                ManageCampaign.ClickOnSortApplyButton();
                ManageAudience.VerifyAudienceListNameOrdersDesc();
                Logger.WriteDebugMessage("Audience should get display according to Name Sort.");
            }
        }

        public static void TC_357996()
        {
            if (TestCaseId == Constants.TC_357996)
            {

                //Variables declaration and object creation
                string filterOption, sortOption;
                string[] campaignDetails = new string[2];

                //Read the data
                filterOption = TestData.ExcelData.TestDataReader.ReadData(1, "filterOption");
                sortOption = TestData.ExcelData.TestDataReader.ReadData(2, "sortOption");

                //Step1 : Navigate to Marketing Automation and log in as a valid Admin user.
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);
                Navigation.Verify_LandsOnMAPage();
                CreateCampaign.Verify_TopIcon();
                Logger.WriteInfoMessage("User lands on Marketing Automation with initial icon on top right corner.");

                //Step 2: Click on Template Left Navigation Menu.
                Navigation.ClickOnSidebarTemplates();
                CreateTemplate.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Admin able to Template Manage page with Templates default 3 x 3 Card view.");

                //Step3: Click on View Detail >> Ellipse
                Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                CreateTemplate.Click_TemplatePage_Ellipses();
                CreateTemplate.Click_TemplatePage_Ellipses_ViewDetails();
                ManageTemplate.VerifyTemplateSummaryPage();
                Logger.WriteDebugMessage("User lands on Template Summary Page.");

                //Step4: Click on Campaigns Tab >> Summary.
                ManageTemplate.ClickOnCampaignTabAndVerifyColumnHeader();
                Logger.WriteDebugMessage("User lands on Campaign Page.");

                //Step5: Click on Template from left navigation. 
                Navigation.ClickOnSidebarTemplates();
                CreateTemplate.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("User again navigated to Template Manage page.");

                //Step6: Click on Filter Tab. Select Name Filter Tab.
                string randomTemplateName = CreateTemplate.GetTemplateName();
                CreateCampaign.Campaign_Click_Filter();
                ManageTemplate.ClickOnFilterIconAndVerifyFilterOptionsDropDownValue("Name", filterOption);
                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Filter();
                Logger.WriteDebugMessage("Name Filter Pop-Up should get opened with drop-down options:- Start - With. Ends - With. Contains. Equals.");

                //Step7: Enter data in Name Filter Tab - Start With Option. Click on Apply.
                ManageCampaign.EnterFilterValues("Name", "Starts With", randomTemplateName);
                CreateCampaign.Campaign_Click_Filter_Apply_Button();
                CreateTemplate.VerifyFilterTemplateInfoOnPage(randomTemplateName);
                Logger.WriteDebugMessage("Audience should get display according to Name Filter.");

                //Step8: Click on Clear Button.
                CreateCampaign.Campaign_Click_Filter();
                CreateCampaign.Campaign_Click_Clear();
                Logger.WriteDebugMessage("Default Audience Manage Page should get loaded.");

                //Step9: Click on Sort Tab. Select Name Sort Tab.
                ManageCampaign.ClickOnSortButton();
                ManageCampaign.VerifySortOptions(sortOption);
                Logger.WriteDebugMessage("Name Sort Pop-Up should get opened with drop-down options:- A - Z. Z - A.");

                //Step10: Select Sort Z-A drop-down option. Click on Apply.
                ManageCampaign.SelectSortOptions(sortOption.Split(',')[0]);
                ManageCampaign.SelectSortType("Name");
                ManageCampaign.ClickOnSortApplyButton();
                CreateTemplate.VerifyTemplateListNameOrdersDesc();
                Logger.WriteDebugMessage("Audience should get display according to Name Sort.");
            }
        }

        
        public static void TC_359105()
        {
            if (TestCaseId == Constants.TC_359105)
            { 
                string segmentName;
                //Read the data
                segmentName = TestData.ExcelData.TestDataReader.ReadData(1, "segmentName");
                //Step1 : Navigate to Marketing Automation and log in as a valid Admin user.
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);
                Navigation.ClickOnSidebarAudience();
                CreateCampaign.Verify_TopIcon();
                Logger.WriteInfoMessage("User lands on Marketing Automation with initial icon on top right corner."); 
                
                //Step2: Verify Toggle switch between Audience and Segment Tab.
                CreateAudience.ClickOnSegmentAndVerifyTitle();
                CreateAudience.ClickOnAudienceAndVerifyTitle();
                Logger.WriteDebugMessage("Toggle to switch between Audience and Segment.");
                // Step3: Click on Segment Tab.
                CreateAudience.ClickOnSegmentAndVerifyTitle();
                CreateAudience.Verify3x3SegmentCardsAvailableOrNot();
                Logger.WriteDebugMessage("Admin able to Segment Manage page with Segment default 3 x 3 Card view."); 
                //Step4: Click on Create Segment.
                CreateAudience.ClickOnCreateSegment();
                CreateAudience.VerifyWizardStepsSettings();
                Logger.WriteDebugMessage("User lands on Setting Page.");
                //Step5: Enter all required details and Click Save and Continue. 
                CreateAudience.EnterSegmentName(segmentName);
                CreateAudience.ClickOnSave();
                Logger.WriteDebugMessage("Segment created successfully with status as Draft Status."); 
                //Step6: Again navigate on Audience Left Navigation Menu.Click on Segment.
                Navigation.ClickOnSidebarAudience();
                CreateAudience.ClickOnSegmentAndVerifyTitle();
                Logger.WriteDebugMessage("Manage Segment page should get display."); 
                //Step7: Search for the Segment which is created recently >> Click on Segment Tab.
                CreateAudience.VerifySegmenteInList(segmentName, "Draft");
                Logger.WriteDebugMessage("Segment should be available in Manage Segment.");
            }
        }

        public static void TC_357997()
        {
            if (TestCaseId == Constants.TC_357997)
            {
                //Navigate to email and logged in with valid credentials
                Hotmail.NavigateToWebmail("https://www.office.com/?auth=2");
                Logger.WriteDebugMessage("User navigated to the https://www.office.com ");
                Hotmail.AutomationAcc_SignIn(Constants.CatchAllEmail, Constants.CatchAllPassword);
                Logger.WriteDebugMessage("User logged in into the catch all using valid credentials");
                //Validate the valid scenarion which will show email in outlook
                string emailTitle = TestData.ExcelData.TestDataReader.ReadData(1, "emailTitle");
                string scenariosData = TestData.ExcelData.TestDataReader.ReadData(2, "scenario1");
                string emailValid = TestData.ExcelData.TestDataReader.ReadData(3, "email");
                Helper.WaitForAjaxControls(50);
                Hotmail.SearchEmailBySubject(emailTitle);
                Hotmail.SearchEmailAndOpenLatestEmail(emailValid, 0);
                EmailSendService.VerifyEmailInformation(scenariosData, emailTitle);
                Driver.Navigate().Refresh();
                }
            }


        #endregion[TP_357992]
    }
}
