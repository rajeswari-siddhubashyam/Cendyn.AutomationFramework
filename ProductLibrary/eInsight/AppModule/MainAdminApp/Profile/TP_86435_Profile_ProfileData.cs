using System;
using eInsight.Utility;
using eInsight.AppModule.UI;
using Common;
using Constants = eInsight.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using SqlWarehouse;
using OpenQA.Selenium;
using NUnit.Framework;
using eInsight.AppModule.UI;
using eInsight.PageObject.UI;
using System.Text.RegularExpressions;

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_86435]
        public static void TC_97478()
        {
            ProfileCustData ProfData = new ProfileCustData();
            Navigation.MenuNavigation("Profile");
            Profile.SelectSubClient(companyNameByTestCase);
            SqlWarehouseQuery.GetCustomerProfileData(ProfData, companyNameByTestCase, "CA");
            Profile.SelectSearchGuestsSearchBy("Customer ID");
            Profile.InsertTextSearchGuestsSearchFor(ProfData.CustomerID);
            Logger.WriteDebugMessage("Searching for an customer for a CustomerID: " + ProfData.CustomerID + " in profile search page.");
            Profile.ClickOpenProfile(ProfData.CustomerID);
            AddDelay(8000);
            ScrollToElement(Driver.FindElement(By.XPath("//a[contains(@href, '#profile-div" + ProfData.CustomerID + "')]")));
            Profile.VerifyProfileData(ProfData);
        }
        public static void TC_97482()
        {
            ProfileCustData ProfData = new ProfileCustData();
            Navigation.MenuNavigation("Profile");
            Profile.SelectSubClient(companyNameByTestCase);
            SqlWarehouseQuery.GetCustomerProfileData(ProfData, companyNameByTestCase, "US");
            Profile.SelectSearchGuestsSearchBy("Customer ID");
            Profile.InsertTextSearchGuestsSearchFor(ProfData.CustomerID);
            Logger.WriteDebugMessage("Searching for an customer for a CustomerID: " + ProfData.CustomerID + " in profile search page.");
            Profile.ClickOpenProfile(ProfData.CustomerID);
            AddDelay(8000);
            ScrollToElement(Driver.FindElement(By.XPath("//a[contains(@href, '#profile-div" + ProfData.CustomerID + "')]")));
            Profile.VerifyProfileData(ProfData);
            AddDelay(8000);
            if (VerifyTextOnPage(ProfData.StateProvinceCode))
            {
                Logger.WriteDebugMessage("State or ProvinceCode" + ProfData.StateProvinceCode + " does exist in table for CustomerID: " + ProfData.CustomerID);
            }
            else
            {
                Assert.Fail("State or ProvinceCode" + ProfData.StateProvinceCode + " does not exist in table for CustomerID: " + ProfData.CustomerID);
            }
        }
        public static void TC_80485()
        {
            ProfileCustData ProfData = new ProfileCustData();
            Navigation.MenuNavigation("Profile");
            Profile.SelectSubClient(companyNameByTestCase);
            SqlWarehouseQuery.GetCustomerProfileData(ProfData, companyNameByTestCase, "US");
            Profile.SelectSearchGuestsSearchBy("Customer ID");
            Profile.InsertTextSearchGuestsSearchFor(ProfData.CustomerID);
            Logger.WriteDebugMessage("Searching for an customer for a CustomerID: " + ProfData.CustomerID + " in profile search page.");
            Profile.ClickOpenProfile(ProfData.CustomerID);
            AddDelay(8000);
            ScrollToElement(Driver.FindElement(By.XPath("//a[contains(@href, '#profile-div" + ProfData.CustomerID + "')]")));
            Profile.VerifyProfileData(ProfData);
        }
        #endregion[TP_86435]

    }
}
