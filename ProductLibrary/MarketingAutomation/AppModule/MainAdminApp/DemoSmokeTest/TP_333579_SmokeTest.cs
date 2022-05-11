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
        #region[TP_333579]

        public static void TC_333143()
        {
            if (TestCaseId == Constants.TC_333143)
            {
                //Variables declaration
                string usernamedesigner, passworddesigner;

                //Read the data
                usernamedesigner = TestData.ExcelData.TestDataReader.ReadData(1, "email");
                passworddesigner = TestData.ExcelData.TestDataReader.ReadData(2, "password");

                //Step1 : Navigate to Marketing Automation and log in as a valid Marketing Manager user.
                SignIn.LoginWithValidCredentials(usernamedesigner, passworddesigner);
                Navigation.Verify_LandsOnMAPage();
                CreateCampaign.Verify_TopIcon();
                Logger.WriteDebugMessage("User lands on Marketing Automation with initial icon on top right corner");

                //Step2 : Click on Campaign
                Navigation.ClickOnSidebarCampaigns();
                CreateCampaign.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("User lands on Campaign Manage page with Marketing Campaigns default 3 x 3 Card view ");

                //Step3 : Scroll down to see the bottom of the page
                ManageCampaign.Verify_ScrollToBottom();
                ManageCampaign.VerifyPagginationCountMore();
                ManageCampaign.VerifyAbsoluteGrids();
                Logger.WriteDebugMessage("Able to scroll and Page is loaded with Marketing and Automation Campaigns.");
                ManageCampaign.Verify_ScrollToTop();

                //Step4 : Click on Automated Tab
                ManageCampaign.Automated_Toggle_Button();
                CreateCampaign.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Automated Campaigns are displayed as default 3 x 3 card views");

                //Step5 : Toggle Card and List view
                ManageCampaign.Toggle_switch();
                //verify the default view
                ManageCampaign.VerifyDefaultView();
                CreateCampaign.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Campaign Displayed in Card View");
                //Validate List view
                CreateCampaign.ClickOnDesignListButton();
                CreateCampaign.VerifyDesignListViewPage();
                Logger.WriteDebugMessage("Campaign Displayed in List View");
                Logger.WriteDebugMessage("Campaigns displayed as expected when toggled between card and List View");

                //Step6 : Click on initial logo on top right corner
                bool isLogout = ManageCampaign.ClickOnInitiaLogoOnTopRightCorner();
                Assert.IsTrue(isLogout.Equals(true), "Logout is not at top right corner after click icon");
                Logger.WriteDebugMessage("Logout is displayed");

                //Step7 : Click on Logout
                CreateCampaign.ClickOnLogout();
                //verification is not done due to its not implemented
                Logger.WriteDebugMessage("Logged out successfully to CHC Sign In Page- https://qa.gocendyn.com/login");

            }
        }

        public static void TC_333159()
        {
            if (TestCaseId == Constants.TC_333159)
            {
                //Variables declaration
                string usernamedesigner, passworddesigner;

                //Read the data
                usernamedesigner = TestData.ExcelData.TestDataReader.ReadData(1, "email");
                passworddesigner = TestData.ExcelData.TestDataReader.ReadData(2, "password");

                //Step1 : Navigate to Marketing Automation and log in as a valid CRM Analyst user.
                Driver.Navigate().GoToUrl("https://audienceqa.gocendyn.com/");//PKTODO:Temporary Remove this Navigation once Platform running errorless.
                SignIn.LoginWithValidCredentials(usernamedesigner, passworddesigner);
                WaitForAjaxControls(100);
                Navigation.Verify_LandsOnMAPage();
                CreateCampaign.Verify_TopIcon();
                Logger.WriteDebugMessage("User lands on Marketing Automation with initial icon on top right corner");

                //Step2 : Click on Audience
                Navigation.ClickOnSidebarAudience();
                CreateTemplate.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("User lands on Audience Manage page with Templates default 3 x 3 Card view ");

                //Step3 : Scroll down to see the bottom of the page
                ManageCampaign.Verify_ScrollToBottom();
                ManageCampaign.VerifyPagginationCountMore();
                ManageCampaign.VerifyAbsoluteGrid();
                Logger.WriteDebugMessage("Able to scroll and Page is loaded with Templates.");
                ManageCampaign.Verify_ScrollToTop();

                //Step4 : Toggle Card and List view
                ManageCampaign.Toggle_switch();
                ManageCampaign.VerifyDefaultView();
                CreateTemplate.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Campaign Displayed in Card View");
                CreateCampaign.ClickOnDesignListButton();
                CreateCampaign.VerifyDesignListViewPage();
                Logger.WriteDebugMessage("Campaign Displayed in List View");
                Logger.WriteDebugMessage("Campaigns displayed as expected when toggled between card and List View");

                //Step5 : Click on initial logo on top right corner
                bool isLogout = ManageCampaign.ClickOnInitiaLogoOnTopRightCorner();
                Assert.IsTrue(isLogout.Equals(true), "Logout is not at top right corner after click icon");
                Logger.WriteDebugMessage("Logout drop down is displayed");

                //Step6 : Click on Logout
                CreateCampaign.ClickOnLogout();
                //verification is not done due to its not implemented
                Logger.WriteDebugMessage("Logged out successfully to CHC Sign In Page- https://qa.gocendyn.com/login");

            }
        }

        public static void TC_333163()
        {
            if (TestCaseId == Constants.TC_333163)
            {
                //Variables declaration
                string usernamedesigner, passworddesigner;

                //Read the data
                usernamedesigner = TestData.ExcelData.TestDataReader.ReadData(1, "email");
                passworddesigner = TestData.ExcelData.TestDataReader.ReadData(2, "password");

                //Step1 : Navigate to Marketing Automation and log in as a valid Designer user.
                Driver.Navigate().GoToUrl("https://templatesqa.gocendyn.com/");//PKTODO:Temporary Remove this Navigation once Platform running errorless.
                SignIn.LoginWithValidCredentials(usernamedesigner, passworddesigner);
                Navigation.Verify_LandsOnMAPage();
                CreateCampaign.Verify_TopIcon();
                int countLinks = Navigation.VerifyNumberOfNavigatorLinks();
                Assert.IsTrue(countLinks == 1, "More than 1 Navigation links are available");
                Logger.WriteDebugMessage("User lands on Marketing Automation with only Templates to navigate and with initial icon on top right corner");

                //Step2 : Click on Templates.
                Navigation.ClickOnSidebarTemplates();
                Assert.IsTrue(PageObject_CreateTemplate.CreateTemplate_Button().Displayed, "Not navigated to Template Manage page.");
                CreateTemplate.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Designer navigated successfully to Templates Manage page with Templates default 3 x 3 Card view ");

                //Step3 : Scroll down to see the bottom of the page
                ManageCampaign.Verify_ScrollToBottom();
                ManageCampaign.VerifyPagginationCountMore();
                ManageCampaign.VerifyAbsoluteGrid();
                Logger.WriteDebugMessage("Able to scroll and Page is loaded with Templates.");
                ManageCampaign.Verify_ScrollToTop();

                //Step4 : Toggle Card and List view
                ManageCampaign.Toggle_switch();
                ManageCampaign.VerifyDefaultView();
                CreateTemplate.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Campaign Displayed in Card View");
                CreateCampaign.ClickOnDesignListButton();
                CreateCampaign.VerifyDesignListViewPage();
                Logger.WriteDebugMessage("Campaign Displayed in List View");
                Logger.WriteDebugMessage("Campaigns displayed as expected when toggled between card and List View");

                //Step5 : Click on initial logo on top right corner
                bool isLogout = ManageCampaign.ClickOnInitiaLogoOnTopRightCorner();
                Assert.IsTrue(isLogout.Equals(true), "Logout is not at top right corner after click icon");
                Logger.WriteDebugMessage("Logout drop down is displayed");

                //Step6 : Click on Logout
                CreateCampaign.ClickOnLogout();
                //verification is not done due to its not implemented
                Logger.WriteDebugMessage("Logged out successfully to CHC Sign In Page- https://qa.gocendyn.com/login");

            }
        }

        public static void TC_333170()
        {
            if (TestCaseId == Constants.TC_333170)
            {
                //Variables declaration
                string usernamedesigner, passworddesigner;

                //Read the data
                usernamedesigner = TestData.ExcelData.TestDataReader.ReadData(1, "email");
                passworddesigner = TestData.ExcelData.TestDataReader.ReadData(2, "password");

                //Step1 : Navigate to Marketing Automation and log in as a valid Marketing Co-ordinator user.
                SignIn.LoginWithValidCredentials(usernamedesigner, passworddesigner);
                Navigation.Verify_LandsOnMAPage();
                CreateCampaign.Verify_TopIcon();
                Logger.WriteDebugMessage("User lands on Marketing Automation with initial icon on top right corner");

                //Step2 : Click on Templates.
                Navigation.ClickOnSidebarTemplates();
                CreateTemplate.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Marketing Co-ordinator able to Templates Manage page with Templates default 3 x 3 Card view ");

                //Step3 : Toggle Card and List view
                ManageCampaign.Toggle_switch();
                ManageCampaign.VerifyDefaultView();
                CreateTemplate.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Campaign Displayed in Card View");
                CreateCampaign.ClickOnDesignListButton();
                CreateCampaign.VerifyDesignListViewPage();
                Logger.WriteDebugMessage("Campaign Displayed in List View");
                Logger.WriteDebugMessage("Campaigns displayed as expected when toggled between card and List View");

                //Step4 : Click on initial logo on top right corner
                bool isLogout = ManageCampaign.ClickOnInitiaLogoOnTopRightCorner();
                Assert.IsTrue(isLogout.Equals(true), "Logout is not at top right corner after click icon");
                Logger.WriteDebugMessage("Logout drop down is displayed");

                //Step5 : Click on Logout
                CreateCampaign.ClickOnLogout();
                //verification is not done due to its not implemented
                Logger.WriteDebugMessage("Logged out successfully to CHC Sign In Page- https://qa.gocendyn.com/login");

            }
        }

        public static void TC_333179()
        {
            if (TestCaseId == Constants.TC_333179)
            {
                //Variables declaration
                string usernamedesigner, passworddesigner;

                //Read the data
                usernamedesigner = TestData.ExcelData.TestDataReader.ReadData(1, "email");
                passworddesigner = TestData.ExcelData.TestDataReader.ReadData(2, "password");

                //Step1 : Navigate to CHC  and log in as a valid Admin  user
                Driver.Navigate().GoToUrl("https://qa.gocendyn.com/login");
                SignIn.LoginWithValidCredentials(usernamedesigner, passworddesigner);
                bool isLoggedin = ManageCampaign.VerifyLoggedinDashboard();
                Assert.IsTrue(isLoggedin.Equals(true), "Not at CHC dashboard");
                Logger.WriteDebugMessage("Navigated CHC Home Page with all Applications");

                //Step2 : Click on Marketing Automation
                Navigation.ClickOnMAInCHCDashboard();
                Navigation.Verify_LandsOnMAPage();
                CreateCampaign.Verify_TopIcon();
                Logger.WriteDebugMessage("Marketing Automation Home Page opened successfully with initials as logo on top right corner ");

                //Step3 : Click on Campaign
                Navigation.ClickOnSidebarCampaigns();
                CreateCampaign.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("User lands on Campaign Manage page with Marketing Campaigns default 3 x 3 Card view ");

                //Step4 : Click on Automated Tab
                ManageCampaign.Automated_Toggle_Button();
                CreateCampaign.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Automated Campaigns are displayed as default 3 x 3 card views");

                //Step5 : Toggle Card and List view
                ManageCampaign.Toggle_switch();
                ManageCampaign.VerifyDefaultView();
                CreateCampaign.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Campaign Displayed in Card View");
                CreateCampaign.ClickOnDesignListButton();
                CreateCampaign.VerifyDesignListViewPage();
                Logger.WriteDebugMessage("Campaign Displayed in List View");
                Logger.WriteDebugMessage("Campaigns displayed as expected when toggled between card and List View");

                //Step6 : Click on initial logo on top right corner
                bool isLogout = ManageCampaign.ClickOnInitiaLogoOnTopRightCorner();
                Assert.IsTrue(isLogout.Equals(true), "Logout is not at top right corner after click icon");
                Logger.WriteDebugMessage("Logout drop down is displayed");

                //Step7 : Click on Logout
                CreateCampaign.ClickOnLogout();
                //verification is not done due to its not implemented
                Logger.WriteDebugMessage("Logged out successfully to CHC Sign In Page- https://qa.gocendyn.com/login");

                //Step8 : Login with Admin User
                /*PKTODO:Temporary till QA link get running correctly */
                Driver.Navigate().Refresh();
                /*SignIn.LoginWithValidCredentials(usernamedesigner, passworddesigner);
                Driver.Navigate().GoToUrl("https://campaignsdev.gocendyn.com/");
                SignIn.LoginWithValidCredentials(usernamedesigner, passworddesigner);*/
                /*END PKTODO:Temporary till QA link get running correctly. 
                 * Remove : Driver.Navigate().GoToUrl("https://campaignsdev.gocendyn.com/");
                 * Keep: SignIn.LoginWithValidCredentials(usernamedesigner, passworddesigner);*/
                //Navigation.Verify_LandsOnMAPage(); 
                CreateCampaign.Verify_TopIcon();
                Logger.WriteDebugMessage("Marketing Automation Home Page opened successfully with initials as logo on top right corner");

                //Step9 : Click on Audience 
                Navigation.ClickOnSidebarAudience();
                CreateTemplate.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Admin navigated successfully into Audience Manage page with Audience default 3 x 3 Card view ");

                //Step10 : Toggle Card and List view
                ManageCampaign.Toggle_switch();
                ManageCampaign.VerifyDefaultView();
                CreateTemplate.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Audience Displayed in Card View");
                CreateCampaign.ClickOnDesignListButton();
                CreateCampaign.VerifyDesignListViewPage();
                Logger.WriteDebugMessage("Audience Displayed in List View");
                Logger.WriteDebugMessage("Audience displayed as expected when toggled between card and List View");

                //Step11 : Click on initial logo on top right corner
                bool isLogoutMAAudience = ManageCampaign.ClickOnInitiaLogoOnTopRightCorner();
                Assert.IsTrue(isLogoutMAAudience.Equals(true), "Logout is not at top right corner after click icon");
                Logger.WriteDebugMessage("Logout drop down is displayed");

                //Step12 : Click on Logout
                CreateCampaign.ClickOnLogout();
                //verification is not done due to its not implemented
                Logger.WriteDebugMessage("Logged out successfully to CHC Sign In Page- https://qa.gocendyn.com/login");

                //Step13 : Login with Admin User
                /*PKTODO:Temporary till QA link get running correctly */
                /* Driver.Navigate().GoToUrl("https://campaignsdev.gocendyn.com/");
                 SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);*/
                /*END PKTODO:Temporary till QA link get running correctly. 
                 * Remove : Driver.Navigate().GoToUrl("https://campaignsdev.gocendyn.com/");
                 * Keep: SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);*/

                Driver.Navigate().Refresh();
                Logger.WriteDebugMessage("Marketing Automation Home Page opened successfully with initials as logo on top right corner");

                //Step14 : Click on Templates
                Navigation.ClickOnSidebarTemplates();
                CreateTemplate.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Admin navigated successfully into Templates Manage page with Templates default 3 x 3 Card view ");

                //Step15 : Toggle Card and List view
                ManageCampaign.Toggle_switch();
                ManageCampaign.VerifyDefaultView();
                CreateTemplate.Verify3x3CardsAvailableOrNot();
                Logger.WriteDebugMessage("Templates Displayed in Card View");
                CreateCampaign.ClickOnDesignListButton();
                CreateCampaign.VerifyDesignListViewPage();
                Logger.WriteDebugMessage("Templates Displayed in List View");
                Logger.WriteDebugMessage("Templates  displayed as expected when toggled between card and List View");

                //Step16 : Click on initial logo on top right corner
                bool isLogoutMATemplate = ManageCampaign.ClickOnInitiaLogoOnTopRightCorner();
                Assert.IsTrue(isLogoutMATemplate.Equals(true), "Logout is not at top right corner after click icon");
                Logger.WriteDebugMessage("Logout drop down is displayed");

                //Step17 : Click on Logout
                CreateCampaign.ClickOnLogout();
                //verification is not done due to its not implemented
                Logger.WriteDebugMessage("Logged out successfully to CHC Sign In Page- https://qa.gocendyn.com/login");
            }
        }


        #endregion[TP_333579]
    }
}
