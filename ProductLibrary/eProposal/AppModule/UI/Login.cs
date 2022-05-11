using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using BaseUtility.Utility.Hotmail;
using NUnit.Framework;
using eProposal.Utility;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.UI;
using InfoMessageLogger;
using eProposalConstants = eProposal.Utility.Constants;


namespace eProposal.AppModule.UI
{
    class Login : Helper
    {
        public static void AutoAcc_login(string Email, int typeofLogin, int typeofNavigation)
        {
            Hotmail.NavigateToWebmail(LegacyTestData.CommonCatchallURL);
            ControlToNewWindow();
            if (IsElementPresent(By.Id("otherTileText")))
            {
                ElementClick(Driver.FindElement(By.Id("otherTileText")));
            }
            switch (typeofLogin)
            {
                case 1:
                    Hotmail.AutomationAcc_SignIn(LegacyTestData.CommonCatchallUserName, LegacyTestData.CommonCatchallPassword);
                    break;
                case 2:
                    Hotmail.AutomationAcc_SignIn(LegacyTestData.CommonCatchallUserName, LegacyTestData.CommonCatchallPassword);
                    break;
            }
            //ControlToPreviousWindow();
            //CloseCurrentTab();
            ControlToNewWindow();
            switch (typeofNavigation)
            {
                case 0:
                    Hotmail.SearchEmailAndOpenLatestEmail(Email, 1);
                    break;
                case 1:
                    Hotmail.OpenLatestEmailReceived();
                    break;
                default:
                    break;
            }

        }
        public static void AccountLogout()
        {
            ElementClick(Driver.FindElement(By.XPath("//div[@id='meInitialsButton']//following::div[@class='_2KqWkae0FcyhdNhWQ-Cp-M']")));
            AddDelay(3000);
            ElementClick(Driver.FindElement(By.XPath("//a[contains(text(), 'Sign out')]")));
            AddDelay(3000);
            Logger.WriteDebugMessage("Logged out from Account.");
        }
    }
}
