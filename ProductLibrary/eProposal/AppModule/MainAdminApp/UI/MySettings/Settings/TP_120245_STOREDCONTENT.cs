using System;
using eProposal.Utility;
using eProposal.AppModule.UI;
using Common;
using Constants = eProposal.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using SqlWarehouse;
using OpenQA.Selenium;
using NUnit.Framework;
using eProposal.AppModule.UI;
using eProposal.AppModule.Admin;
using eProposal.PageObject.UI;
using System.Text.RegularExpressions;

namespace eProposal.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_120245]
        #region[TC_120246]

        public static void TC_120246()
        {
            //1. Log into: ePFull Admin                
            Driver.Navigate().GoToUrl(LegacyTestData.CommonAdminURL);
            AdminLogin.LogInCommon();
            Logger.WriteDebugMessage("Land on eSALES SUITE ADMINISTRATION");

            //2. Select a regular property. (Cendyn - Hilton Dresden).
            AdminNavigation.Click_Button_eProposal();
            Logger.WriteDebugMessage("Land on eProposal page.");

            //3. Select a multi-module property.​               
            AddDelay(1500);
            AdminProperties.SelectProperty(Property);
            Logger.WriteDebugMessage("Page populates");

            //4. Click "Setup Module Settings"
            AdminEProposal.Click_Link_SetupModuleSettings();
            Logger.WriteDebugMessage("Land on Property Module Settings");

            //5. Look at each module and it's DisplayName and take note of them.
            var data = AdminEProposal.Assign_DisplayNames();
            Logger.WriteDebugMessage("Noted.");

            // 08/07 Marc : Removed adding a new user and will use an existing user with property access
            OpenNewTab();
            ControlToNewWindow();
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL);
            EmployeeLogin.CommonLogin_SSO();
            AddDelay(2500);
            EmployeeHome.SelectProperty(Property);

            //8. Click "My Settings - > Settings"
            AddDelay(5000);
            EmployeeHome.Click_WelcomeButton();
            AddDelay(1500);
            EmployeeHome.Hover_MySettings_New();
            EmployeeHome.Click_MySettings_New();
            Logger.WriteDebugMessage("Land on the My Setting page.");

            //9. Click the "Senior Staff Info" tab
            //Settings.Click_Tab_SeniorStaffInfo();
            //Logger.WriteDebugMessage("Land on Senior Staff Information page");
            Settings.Click_Tab_StoredContent();
            AddDelay(10000);
            Logger.WriteDebugMessage("Land on Stored Content Tab.");

            //10.Click the "Module" drop down and verify all the modules that include a Senior Staff Information will display.(If you don't know if the module has a Senior Staff Message, click "Create/Edit -> eProposal", change the module and see if the Senior Staff Message is displayed.
            Settings.VerifyModuleDropdown(data);
            Logger.WriteDebugMessage("They are!");
        }

        #endregion[TC_120246]    

        #endregion[TP_120245]

    }
}
