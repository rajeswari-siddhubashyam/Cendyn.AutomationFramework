using CHC_Config.AppModule.UI;
using CHC_Config.Entity;
using CHC_Config.Utility;
using BaseUtility.Utility;
using Queries = CHC_Config.Utility.Queries;
using System.Collections.Generic;
using InfoMessageLogger;
using TestData;
using OpenQA.Selenium;
using System.Threading;
using CHC.PageObject.UI;

namespace CHC_Config.AppModule.MainAdminApp
{
    public partial class TP_389110_CreateUser_QA : CHC_Config.Utility.Setup
    {
        #region[TP_389110]
        public static void TC_336529()
        {
            if (TestCaseId == Constants.TC_336529)
            {
                //Step1 : User login CHC application with valid credentials
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();

                //Step2: User click on Configuration app
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                //Step3: User clicked on Users tab from side nav
                CreateUser.Clickon_Users_SideNav();

                //Step4: Click on Craete User button
                CreateUser.Clickon_CreateUser_Button();

                //Step5: Verify Popup with Proceed and Cancel buttons
                CreateUser.VerifyProceed_CancelPopup();

                //Step6: Enter Email in email text box
                //CreateUser.Verify_Email_Txt.clear();
                CreateUser.Verify_Email_Txt("abcd@cendyn17.");

                //Step7: Verify Enter wrong Email in email text box
                CreateUser.Verify_Email_Txt("abcd@cendyn17.com");

                //Step8: Click on Proceed button
                CreateUser.Click_On_Proceed_Button();

                //Step9: Enter First name
                //CreateUser.Txt_FirstName("@#@#@@");
                CreateUser.Txt_FirstName("abcd");

                //Step10: Enter Last name
                //CreateUser.Txt_LastName("&%*^$%d");
                CreateUser.Txt_LastName("abcd");

                //Step11: Enter Job Title
                //CreateUser.Txt_JobTitle("^#$#^&^^");
                CreateUser.Txt_JobTitle("Manager");

                //Step12: Click on Continue button
                CreateUser.Clickon_Continue_Button();

                //Step13: User select the Organization to user
                string accountName = "Kirigami Hotels (Chain)";
                CreateUser.Select_Org_ToUser(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");                
                
                //Step14: User click on Select all button
                //CreateUser.Select_SelectAll_Org_ToUser();

                //Step15: User click on Continue button
                CreateUser.Clickon_Continue_Button();

                //Step16: Assign application to User
                CreateUser.Assign_App_ToUser();

                //Step17: Assign application roles to user
                CreateUser.Assign_App_Roles_ToUser();

                //Step18: Click on Continue button
                CreateUser.Clickon_Continue_Button();

                //Step19: User click on Create user button
                CreateUser.Clickon_CreateUser_Button();
            }
        }
        #endregion[TP_389110]
    }
}