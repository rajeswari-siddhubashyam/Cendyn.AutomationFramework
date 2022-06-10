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

            }
        }
        #endregion[TP_389110]
    }
}