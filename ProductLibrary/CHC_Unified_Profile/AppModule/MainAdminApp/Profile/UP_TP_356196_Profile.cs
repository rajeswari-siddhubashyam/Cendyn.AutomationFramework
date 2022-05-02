using CHC_Unified_Profile.AppModule.UI;
using CHC_Unified_Profile.Entity;
using CHC_Unified_Profile.Utility;
using BaseUtility.Utility;
using Queries = CHC_Unified_Profile.Utility.Queries;
using System.Collections.Generic;
using InfoMessageLogger;
using TestData;
using OpenQA.Selenium;
using System.Threading;
using CHC_Unified_Profile.PageObject.UI;

namespace CHC_Unified_Profile.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region[TP_356196]

        public static void TC_340276()
        {
            if (TestCaseId == Constants.TC_340276)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();

                //Step2 - Verify all accessing applications to the user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page");
                Home.VerifyApplications();

                //Step3 - Click on Unified Porfile App
                Navigation.Click_Unified_Profile_App();
                Logger.WriteDebugMessage("User should view the Org selector");

                //Step4 - Verify the Org selector popup
                Home.VerifyPopup();

                ////Click on Choose button
                Home.ClickOnChooseOnPopup();
                Logger.WriteDebugMessage("User should view the list of Orgs");

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Unified Porfile application");

                //Click on Logout                
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_340278()
        {
            if (TestCaseId == Constants.TC_340278)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();

                //Step2 - Verify all accessing applications to the user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page");
                Home.VerifyApplications();

                //Step3 - Click on Unified Porfile App
                Navigation.Click_Unified_Profile_App();
                Logger.WriteDebugMessage("User should view the Org selector");

                //Step4 - Verify the Org selector popup
                Home.VerifyPopup();

                ////Click on Choose button
                Home.ClickOnChooseOnPopup();
                Logger.WriteDebugMessage("User should view the list of Orgs");

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Unified Porfile application");

                //Profile.ClickonProfilerecord();

                string prodileId = Profile.ClickonProfilerecordonprofilestable();
                Profile.VerifyViewprofileName(prodileId);
                Logger.WriteDebugMessage("Profileid matches");
                Profile.VerifyViewprofileName(prodileId);

                Profile.ClickOn_ViewProfile_ContactDetailsTab();

                Profile.Clickonreservationstab();

                Profile.Clickon_ViewProfile_HistoryTab();

                //Click on Logout                
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_340284()
        {
            if (TestCaseId == Constants.TC_340284)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();

                //Step2 - Verify all accessing applications to admin user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page");
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();
                Logger.WriteDebugMessage("User should view the Org selector");

                //Step4 - Verify the Org selector popup
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();
                Logger.WriteDebugMessage("User should view the list of Orgs");

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                //Click on Logout                
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_340283()
        {
            if (TestCaseId == Constants.TC_340283)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();

                //Step2 - Verify all accessing applications to admin user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page");
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();
                Logger.WriteDebugMessage("User should view the Org selector");

                //Step4 - Verify the Org selector popup
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();
                Logger.WriteDebugMessage("User should view the list of Orgs");

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                //Click on Logout                
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_340280()
        {
            if (TestCaseId == Constants.TC_340280)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();

                //Step2 - Verify all accessing applications to admin user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page");
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Profile.Click_Unified_ProfileApp();
                Logger.WriteDebugMessage("User should view the Org selector");

                //Step4 - Verify the Org selector popup
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();
                Logger.WriteDebugMessage("User should view the list of Orgs");

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Profile.ClickOn_ViewProfile_ContactDetailsTab();

                //Click on Logout                
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_340291()
        {
            if (TestCaseId == Constants.TC_340291)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();

                //Step2 - Verify all accessing applications to admin user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page");
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();
                Logger.WriteDebugMessage("User should view the Org selector");

                //Step4 - Verify the Org selector popup
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();
                Logger.WriteDebugMessage("User should view the list of Orgs");

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                //Click on Logout                
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_340281()
        {
            if (TestCaseId == Constants.TC_340281)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();

                //Step2 - Verify all accessing applications to admin user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page");
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();
                Logger.WriteDebugMessage("User should view the Org selector");

                //Step4 - Verify the Org selector popup
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();
                Logger.WriteDebugMessage("User should view the list of Orgs");

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");



                //Click on Logout                
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        #endregion[TP_356196]
    }
}


