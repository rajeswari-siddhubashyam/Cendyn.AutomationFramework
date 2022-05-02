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
        #region[TP_292592]
        public static void TC_292525()
        {
            if (TestCaseId == Constants.TC_292525)
            {

                //Variables declaration and object creation
                Campaign data = new Campaign();

                //Navigate to Marketing Automation and log in as valid user
                Helper.WaitForAjaxControls(30);
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);
                Helper.WaitForAjaxControls(50);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click to Create Campaign
                CreateCampaign.ClickOnCreateCampaign();

                //Verify Marketing is selected by default
                CreateCampaign.VerifyMarketingTabSelection();

                //Verify Page Title shows "Cendyn | Create"
                CreateCampaign.VerifyPageTitle("Cendyn | Create");

                //Get the cards list from the database
                SetupConnectionString(Constants.clientEnv.MarketingAutoQA);
                Queries.GetCards(data, 1);

                //Verify cards present on the marketing tab
                Helper.WaitForAjaxControls(50);
                foreach (var item in data.clientCards)
                {
                    CreateCampaign.VerifyCardOnActiveTab(item);
                }

                //Click on Marketing and Transactional on toggle and verify cards shown
                CreateCampaign.ToggletoAutomatedTtab();
                //Verify cards present on the Automated tab

                //Get the cards list from the database
                Queries.GetCards(data, 2);
                foreach (var item in data.clientCards)
                {
                    CreateCampaign.VerifyCardOnActiveTab(item);

                }
                CreateCampaign.ToggletoMarketingTtab();

                //Verify when clicking on card, user is brought to first step of campaign creation process
                CreateCampaign.VerifyClickingOnCardFirstStepOfCampaign();
            }
        }
        #endregion

    }
}