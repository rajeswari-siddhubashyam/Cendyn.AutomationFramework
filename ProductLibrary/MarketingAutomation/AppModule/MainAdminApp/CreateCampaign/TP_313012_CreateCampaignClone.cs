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
        #region[TP_313012]
        
        public static void TC_313016()
        {
            if (TestCaseId == Constants.TC_313016)
            {
                
                //Variables declaration and object creation
                string suffixClone, titleCampaignName, filterName, campaignID, cloneCampaignName, filterNameValue, titleCampaignNameFilter;
                string[] campaignDetails = new string[2];
                string[] campaignFilterDetails = new string[2];

                //Read the data
                suffixClone = TestData.ExcelData.TestDataReader.ReadData(1, "suffixClone");
                filterNameValue = TestData.ExcelData.TestDataReader.ReadData(2, "filterNameValue");
                filterName = TestData.ExcelData.TestDataReader.ReadData(3, "filterName");
               
                 
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

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Step 6: Search Clone Campaign Name on Manage Campaign page with Filter Name
                CreateCampaign.applyFilter(filterName, filterNameValue, cloneCampaignName);
                campaignFilterDetails = CreateCampaign.getTitleAndIdOfCampaignCardRandom();
                titleCampaignNameFilter = campaignFilterDetails[0];
                CreateCampaign.VerifyFilterCampaignName(cloneCampaignName, titleCampaignNameFilter);


            }
        }

        public static void TC_325734()
        {
            if (TestCaseId == Constants.TC_325734)
            {

                //Variables declaration and object creation
                string suffixClone, filterName, titleCampaignName, campaignID, cloneCampaignName, filterNameValue, titleCampaignNameFilter, tmpDesignCardName;
                string[] campaignDetails = new string[2];
                string[] campaignFilterDetails = new string[2];
                tmpDesignCardName = "MA QA Test Campaign Template";

                //Read the data
                suffixClone = TestData.ExcelData.TestDataReader.ReadData(1, "suffixClone");
                filterNameValue = TestData.ExcelData.TestDataReader.ReadData(2, "filterNameValue");
                filterName = TestData.ExcelData.TestDataReader.ReadData(3, "filterName");

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

                //Step 5 & 6: Select an Audience and click Continue
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

                //Step 7 & 8: Select a design and click Continue
                CreateCampaign.SelectGivenDesignCard(tmpDesignCardName);
                CreateCampaign.VerifyCorrectDesignCardSelected(tmpDesignCardName);

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");

                //User lands on Design Preview page
                CreateCampaign.VerifyUserNavigateToDesignPreview();
                Logger.WriteDebugMessage("User lands on Design Preview page");

                //Verify the Design selected was added to the template
                CreateCampaign.ValidateDesignCardTitleOnPreviewPage(tmpDesignCardName);
                Logger.WriteDebugMessage("Correct Design preview is shown");

                CreateCampaign.ClickOnSaveAndContinue();
                Logger.WriteInfoMessage("Select a design and click Continue");
                Logger.WriteDebugMessage("User should landed on Confirm page");

                //Step 9: Click on Self-Approve and Validate schedule card displayed in Confirm page
                CreateCampaign.VerifyConfirmHighlightedAndPage();
                CreateCampaign.ClickOnSelfApproveButton();

                //Step 10: Click Campaign Left Navigation Tab
                Navigation.ClickOnSidebarCampaigns();
                WaitForAjaxControls(90);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Step 11: Search Clone Campaign Name on Manage Campaign page with Filter Name
                CreateCampaign.applyFilter(filterName, filterNameValue, cloneCampaignName);
                campaignFilterDetails = CreateCampaign.getTitleAndIdOfCampaignCardRandom();
                titleCampaignNameFilter = campaignFilterDetails[0];
                CreateCampaign.VerifyFilterCampaignName(cloneCampaignName, titleCampaignNameFilter);


            }
        }

        public static void TC_325735()
        {
            if (TestCaseId == Constants.TC_325735)
            {

                //Variables declaration and object creation
                string suffixClone, titleCampaignName, campaignID;
                string[] campaignDetails = new string[2];

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

                //Step 4: Verify suffix and pre-populated data in Campaign name field of Setting page
                CreateCampaign.VerifySuffixAndPrepopulatedDataOnCampaignName(titleCampaignName, suffixClone);

                //Step 5: Verify Campaign ID in URL for clone campaign on Setting page window
                CreateCampaign.VerifyCampaignIDInUrl(campaignID);


            }
        }

        #endregion
    }
}