using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseUtility.Utility;
using InfoMessageLogger;
using Common;
using OpenQA.Selenium;
using eInsight.PageObject.UI;
using eInsight.Utility;
using BaseUtility.Utility.Hotmail;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;
using SqlWarehouse;

namespace eInsight.AppModule.UI
{
    class UserActions : Helper
    {

        /// <summary>
        /// This method will enter the user name on the eInsight login page.
        /// </summary>
        /// <param name="username">Username to enter.</param>
        public static void Click_Button_UserrAction()
        {
            ElementClick(PageObject_UserActions.User_UserActions());
        }

        public static void Click_Button_UserrAction_MyPreference()
        {
            ElementClick(PageObject_UserActions.Click_Button_UserrAction_MyPreference());
        }
        public static void Click_Button_UserrAction_SavePreference()
        {
            ElementClick(PageObject_UserActions.UserAction_MyPreference_Save());
        }

        public static void GetSelectedElementValue()
        {
            IWebElement comboBox = Driver.FindElement(By.Id("RegionPreference"));
            SelectElement selectedValue = new SelectElement(comboBox);
            string wantedText = selectedValue.SelectedOption.Text;

            Logger.WriteDebugMessage("Selected Region is " + wantedText);
        }

        public static void SelectRegion(string client)
        {
            AddDelay(1500);
            PageObject_UserActions.UserAction_MyPreference_Region().Click();
            AddDelay(1000);
            PageObject_UserActions.UserAction_MyPreference_Region().SendKeys(client);
            AddDelay(10000);
            PageObject_UserActions.UserAction_MyPreference_Region().SendKeys(Keys.Enter);
            AddDelay(3000);
        }

        public static void SelectCurrency(string client)
        {
            AddDelay(1500);
            PageObject_UserActions.UserAction_MyPreference_Currency().Click();
            AddDelay(1000);
            PageObject_UserActions.UserAction_MyPreference_Currency().SendKeys(client);
            AddDelay(10000);
            PageObject_UserActions.UserAction_MyPreference_Currency().SendKeys(Keys.Enter);
            AddDelay(3000);
        }

        public static void SelectPreferredRegion(string selectedRegion)
        {
            Driver.SwitchTo().ParentFrame();
            UserActions.Click_Button_UserrAction();
            Logger.WriteDebugMessage("Clicked on User Actions.");

            UserActions.Click_Button_UserrAction_MyPreference();
            Logger.WriteDebugMessage("Clicked on My Preferences");

            SelectRegion(selectedRegion);
            Logger.WriteDebugMessage("Region Selected :" + selectedRegion);

            Click_Button_UserrAction_SavePreference();
            By loader1 = By.XPath("//*[contains(.,'Loading...')]");
            Helper.WaitTillInvisibilityOfLoader(loader1, 120);
            string loader2 = "//div[@class='e-spinner-pane e-spin-show']";
            Helper.FindLoaderAndWaitTillHide(loader2);
            //AddDelay(15000);
        }
    }
}
