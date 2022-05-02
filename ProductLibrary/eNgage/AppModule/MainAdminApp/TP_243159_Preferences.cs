using System;
using eNgage.Utility;
using eNgage.AppModule.UI;
using Common;
using Constants = eNgage.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using OpenQA.Selenium;
using NUnit.Framework;
using eNgage.AppModule.UI;
using eNgage.PageObject.UI;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace eNgage.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_243159]
        public static void TC_243197()
        {
            PageObject_Search.Nav_Search().Click();
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue("Profile");
            IList<String> InputElements = new List<String>();
            InputElements.Add(searchDropDown.SelectedOption.GetAttribute("value"));
            InputElements.Add("Profile");
            InputElements.Add(profileID);

            Search.searchBy(Driver, InputElements);
            Search.clickFromSearchResults(Driver);
            Preferences.addPreferences(Driver);

            var beforeSaveCount = Preferences.savePreferencesCount(Driver);
            Preferences.savePreferences(Driver);

            PageObject_Search.Nav_Search().Click();
            AddDelay(1000);
            Search.searchBy(Driver, InputElements);
            Search.clickFromSearchResults(Driver);
            AddDelay(1000);
            PageObject_Preferences.Nav_Preferences().Click();
            var afterSavecount = Preferences.savePreferencesCount(Driver);
            Preferences.verifyPreferencesSaved(Driver, beforeSaveCount, afterSavecount);

            Preferences.removePreferences(Driver);
            Preferences.savePreferences(Driver);
        }
        #endregion[TP_243159]

    }
}
