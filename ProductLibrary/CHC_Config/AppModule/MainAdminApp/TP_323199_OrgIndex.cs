using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHC_Config.AppModule.UI;
using CHC_Config.Utility;

namespace CHC_Config.AppModule.MainAdminApp
{
    public partial class MainAdminApp : CHC_Config.Utility.Setup
    {
        #region[TP_323199]
        public static void TC_353241()
        {
            if (TestCaseId == Constants.TC_353241)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();
                OrgIndex.viewColumnNames();
                OrgIndex.VerifyPropertyTable();
            }
        }
        public static void TC_326759()
        {
            if (TestCaseId == Constants.TC_326759)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();
                OrgIndex.SearchPropertyName();

            }
        }
        public static void TC_309597()
        {
            if (TestCaseId == Constants.TC_309597)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();
                OrgIndex.SearchPropertyName();
                OrgIndex.ViewPropertyDashboard();
                OrgIndex.BackToOrganization("Property");
                OrgIndex.SearchPropertyName();
                OrgIndex.ViewBrandDashboard();
                OrgIndex.BackToOrganization("Brand");
                OrgIndex.SearchPropertyName();
                OrgIndex.ViewChainDashboard();
                OrgIndex.BackToOrganization("Chain");
            }
        }
        public static void TC_309602()
        {
            if (TestCaseId == Constants.TC_309602)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();
                Create.clickCreateButton();
                Create.createAndCancel();
            }
        }

        #endregion[TP_323199]
    }
}
