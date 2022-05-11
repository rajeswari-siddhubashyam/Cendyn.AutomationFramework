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
using System.Collections.Generic;

namespace eProposal.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_84921]
        #region[TC_61367]

        public static void TC_61367()
        {
            //1. Log into: ePFull Admin
            Driver.Navigate().GoToUrl(LegacyTestData.CommonAdminURL);
            AdminLogin.LogInCommon();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Click "eProposal"
            AdminNavigation.Click_Button_eProposal();
            Logger.WriteDebugMessage("Land on eProposal page");

            //3. Select a multi-module property.​               
            AdminProperties.SelectProperty(Property);
            Logger.WriteDebugMessage("Page populates");

            //4. Land on Property Module Settings
            AdminEProposal.Click_Link_SetupModuleSettings();
            Logger.WriteDebugMessage("Opens in a new window or tab.");

            //5. Look at each module and it's DisplayName and take note of them.
            List<String> data = AdminEProposal_SetupModuleSettings.Assign_DisplayNames();
            var NumberOfModules = data.Count;
            for (var i = 0; i < NumberOfModules; i++)
                Logger.WriteDebugMessage("Module Name " + i + " Noted");
            Logger.WriteDebugMessage("Noted - each module and it's DisplayName");

            //6. Click "Users"    
            AdminNavigation.Click_Button_Users();
            Logger.WriteDebugMessage("Land on users page.");

            //7. Add yourself as a user to this property and click "Login"
            string Email = "Testautomation@cendyn17.com";
            var splitEmail = Email.Split('@');
            var time = DateTime.Now.ToShortTimeString().Split(':');
            var email = splitEmail[0] + "4" + "@" + splitEmail[1];


            //Verify if your user already exists
            AdminUsers.SearchUser(Constants.UserOption1, Constants.UserOption2, email);
            if (Helper.VerifyTextOnPage("First Name/Last Name"))
                Logger.WriteDebugMessage("User already exists");
            else
            {
                AdminUsers.AddNewUser("Test", "Automation11", "TestAutomation11@cendyn17.com",
                       "Cendyn$123", "Admin", "1440");
                AdminUsers.Click_Button_Save();
                AddDelay(2500);
                AdminUsers.SearchUser(Constants.UserOption1, Constants.UserOption2, email);
            }
            AdminUsers.Click_Link_LogIn();
            ControlToNewWindow();
            AddDelay(25000);
            Logger.WriteDebugMessage("Created Profile, clicked Login and Landed on Profile Page for Email: " + email + ". Clicking on Save button to Save Profile.");
            Driver.SwitchTo().Frame(0);
            if (IsElementPresent(By.XPath("//a[contains(text(),'Agree and Proceed')]")))
            {
                ElementClick(Driver.FindElement(By.XPath("//a[contains(text(),'Agree and Proceed')]")));
                if (IsElementPresent(By.XPath("//a[contains(text(),'Close')]")))
                {
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(text(),'Close')]")));
                }

            }
            Driver.SwitchTo().ParentFrame();
            ElementEnterText(Driver.FindElement(By.Id("ctl00_ctl00_MainContent_MainContent_txtTitle")), "Mr.");
            ElementClick(Driver.FindElement(By.XPath("//input[@value='Save']")));
            //8. Click "My Settings - > Settings"
            AddDelay(5000);
            EmployeeHome.Click_WelcomeButton();
            AddDelay(1500);
            EmployeeHome.Hover_MySettings_Demo();
            EmployeeHome.Click_MySettings_Demo();
            Logger.WriteDebugMessage("Land on the My Setting page.");

            //9. Click the "Room/Event Block Comments" tab
            Settings.Click_Tab_RoomEventBlockComments();
            Logger.WriteDebugMessage("Land on Room/Event Block Comments page");

            //10.Click the "Module" drop down and verify all the modules that include a Senior Staff Information will display.(If you don't know if the module has a Senior Staff Message, click "Create/Edit -> eProposal", change the module and see if the Senior Staff Message is displayed.
            AddDelay(2000);
            Settings.VerifyModuleDropdownCustomizePDFByList(data);
            Logger.WriteDebugMessage("They are!");
        }
        #endregion[TC_61367]
        #endregion[TP_84921]

    }
}
