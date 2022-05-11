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
        #region[TP_333578]

       


        

        public static void TC_333160()
        {
            if (TestCaseId == Constants.TC_333160)
                {
                     //MA - Direct Templates Login of Admin user     
                     Driver.Navigate().GoToUrl("https://marketingqa.gocendyn.com/templates");

                    //Step1 : Navigate to Marketing Automation and log in as a valid Admin user.
                    SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                    Navigation.Verify_LandsOnMAPage();
                    CreateCampaign.Verify_TopIcon();
                    Logger.WriteInfoMessage("User lands on Marketing Automation with initial icon on top right corner");


                    //Step 2: Click on Templates
                    Navigation.ClickOnSidebarTemplates();
                    CreateTemplate.Verify3x3CardsAvailableOrNot();
                    Logger.WriteDebugMessage("User lands on Templates Manage page with Templates default 3 x 3 Card view ");

                    //Step 3: Scroll down to see the bottom of the page
                    CreateTemplate.Verify_ScrollToBottom();
                    CreateTemplate.VerifyTemplatesLoaded();
                    Logger.WriteDebugMessage("Able to scroll and Page is loaded with Templates.");

                    //Step 4: Toggle Card and List view
                    CreateCampaign.ClickOnDesignListButton();
                    CreateCampaign.VerifyDesignListViewPage();
                    CreateCampaign.ClickOnDesignGridButton();
                    CreateTemplate.VerifyUserNavigateToTemplateCardView();
                    Logger.WriteDebugMessage("Templates displayed as expected when toggled between card and List View");

                    //Step 5: Click on initial logo on top right corner
                    CreateCampaign.ClickOnUserIconAndVerifyLogoutOption();
                    Logger.WriteDebugMessage("Logout is displayed");

                    //Step 6: Click on Logout
                    CreateCampaign.ClickOnLogout();
                    Logger.WriteDebugMessage("Logged out successfully to CHC Sign In Page- https://qa.gocendyn.com/login");
            }
        }

        public static void TC_333146()
        {
            if (TestCaseId == Constants.TC_333146)
            {

                // MA - Direct Audience Login of Admin User
                Driver.Navigate().GoToUrl("https://marketingqa.gocendyn.com/audience");
                //Step1 : Navigate to Marketing Automation and log in as a valid Admin user.
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                Navigation.Verify_LandsOnMAPage();
                CreateCampaign.Verify_TopIcon();
                Logger.WriteInfoMessage("User lands on Marketing Automation with initial icon on top right corner");


                //Step 2: Click on Audience 
                Navigation.ClickOnSidebarAudience();
                CreateAudience.VerifyAudience3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Admin able to Audience Manage page with Audience default 3 x 3 Card view  ");

                //Step 3: Scroll down to see the bottom of the page
                CreateTemplate.Verify_ScrollToBottom();
                CreateAudience.VerifyAudienceLoaded();
                Logger.WriteDebugMessage("Able to scroll and Page is loaded with Audiences.");

                //Step 4: Toggle Card and List view
                CreateCampaign.ClickOnDesignListButton();
                CreateCampaign.VerifyDesignListViewPage();
                CreateCampaign.ClickOnDesignGridButton();
                CreateAudience.VerifyUserNavigateToAudienceCardView();
                Logger.WriteDebugMessage("Audience displayed as expected when toggled between card and List View");

                //Step 5: Click on initial logo on top right corner
                CreateCampaign.ClickOnUserIconAndVerifyLogoutOption();
                Logger.WriteDebugMessage("Logout is displayed");

                //Step 6: Click on Logout
                CreateCampaign.ClickOnLogout();
                //verification is not done due to its not implemented
                Logger.WriteDebugMessage("Logged out successfully to CHC Sign In Page- https://qa.gocendyn.com/login");
            }
        }

        public static void TC_333134()
        {
            if (TestCaseId == Constants.TC_333134)
            {

                //Step1 : Navigate to Marketing Automation and log in as a valid Admin user.
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                Navigation.Verify_LandsOnMAPage();
                CreateCampaign.Verify_TopIcon();
                Logger.WriteInfoMessage("User lands on Marketing Automation with initial icon on top right corner");


                //Step 2: Click on Campaign
                Navigation.ClickOnSidebarCampaigns();
                ManageCampaign.VerifyCampaign3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("User lands on Campaign Manage page with Marketing Campaigns default 3 x 3 Card view ");

                //Step 3: Scroll down to see the bottom of the page
                CreateTemplate.Verify_ScrollToBottom();
                ManageCampaign.VerifyCampaignLoaded();
                Logger.WriteDebugMessage("Able to scroll and Page is loaded with Marketing and Automation Campaigns.");

                // Steps 4: Click on Automated Tab
                ManageCampaign.ClickOnAutomatedToggle();
                ManageCampaign.VerifyCampaign3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Automated Campaigns are displayed as default 3 x 3 card views");

                //Step 5: Toggle Card and List view
                CreateCampaign.ClickOnDesignListButton();
                CreateCampaign.VerifyDesignListViewPage();
                CreateCampaign.ClickOnDesignGridButton();
                ManageCampaign.VerifyUserNavigateToCampaignCardView();
                Logger.WriteDebugMessage("Campaigns displayed as expected when toggled between card and List View");

                //Step 6: Click on initial logo on top right corner
                CreateCampaign.ClickOnUserIconAndVerifyLogoutOption();
                Logger.WriteDebugMessage("Logout is displayed");

                //Step 7: Click on Logout
                CreateCampaign.ClickOnLogout();
                //verification is not done due to its not implemented
                Logger.WriteDebugMessage("Logged out successfully to CHC Sign In Page- https://qa.gocendyn.com/login");
            }
        }
        #endregion[TP_333578]
    }
}
