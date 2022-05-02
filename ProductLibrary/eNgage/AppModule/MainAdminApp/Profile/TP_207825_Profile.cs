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
        private static string profile_ID = "30289223";
        private static string customerID = "5561072";
        private static string firstName = "Sean";
        private static string lastName = "Kinney";
        private static string emailAddress = "seanfromlola@cendyn17.com";
        private static string cellPhone = "9177676118";
        private static string phoneNumber = "9177676118";
        private static string address1 = "1955 1st ave";
        private static string address2 = "";
        private static string city = "New York";
        private static string stateProvinceCode = "NY";
        private static string stateprovinceProfile = "NEW YORK";
        private static string zipCode = "90068";
        private static string CountryCode = "US";
        private static string reservationNum = "35615202";
        #region[TP_207825]
        public static void TC_207827()
        {
           PageObject_Search.Nav_Search().Click();
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue("Profile");
            Search.ClearInputValues();
            IList<String> InputElements = new List<String>
                {
                    searchDropDown.SelectedOption.GetAttribute("value"),
                    "Profile",
                    profile_ID
                };
            Search.searchBy(Driver, InputElements);
            AddDelay(500);
            Search.VerifyIDSearchResults(Driver, profile_ID, profile_ID);
            ElementClick(Driver.FindElement(By.XPath("//td[contains(text(), '30289223')]")));
            PageObject_Summary.Nav_Summary().Click();
            
            string xpathMobilePhone = "//span[contains(text(), 'Mobile Phone')]/following::*[contains(text(), '" + cellPhone + "')]";
            string xpathPrimaryPhone = "//span[contains(text(), 'Primary Phone')]/following::*[contains(text(), '" + phoneNumber + "')]";
            string xpathEmail = "//span[contains(text(), 'Email Address')]/following::*[contains(text(), '" + emailAddress + "')]";
            string xpathAddress1 = "//span[contains(text(), 'Address1')]/following::*[contains(text(), '" + address1 + "')]";
            string xpathAddress2 = "//span[contains(text(), 'Address2')]/following::*[contains(text(), '" + address2 + "')]";
            string xpathCity = "//span[contains(text(), 'City')]/following::*[contains(text(), '" + city + "')]";
            string xpathState = "//span[contains(text(), 'State')]/following::*[contains(text(), '" + stateProvinceCode + "')]";
            string xpathPostalCode = "//span[contains(text(), 'Postal Code')]/following::*[contains(text(), '" + zipCode + "')]";
            string xpathCountry = "//span[contains(text(), 'Country')]/following::*[contains(text(), '" + CountryCode + "')]";

            if (IsElementPresent(By.XPath(xpathMobilePhone)) && IsElementPresent(By.XPath(xpathPrimaryPhone)) && IsElementPresent(By.XPath(xpathEmail)) && IsElementPresent(By.XPath(xpathAddress1)) && IsElementPresent(By.XPath(xpathAddress2)) && IsElementPresent(By.XPath(xpathCity)) && IsElementPresent(By.XPath(xpathState)) && IsElementPresent(By.XPath(xpathPostalCode)) && IsElementPresent(By.XPath(xpathCountry)))
            {
                string message = "Found Profile Contact Details on Summary Page";
                message = message + "\n Email: " + emailAddress;
                message = message + "\n CellPhone: " + cellPhone;
                message = message + "\n PhoneNumber: " + phoneNumber;
                message = message + "\n Address1: " + address1;
                message = message + "\n Address2: " + address2;
                message = message + "\n City: " + city;
                message = message + "\n StateProvinceCode: " + stateProvinceCode;
                message = message + "\n ZipCode: " + zipCode;
                message = message + "\n CountryCode: " + CountryCode;
                Logger.WriteDebugMessage(message);

            }
            else
            {
                string message = "Did not found Profile Contact Details on Summary Page";
                message = message + "\n Email: " + emailAddress;
                message = message + "\n CellPhone: " + cellPhone;
                message = message + "\n PhoneNumber: " + phoneNumber;
                message = message + "\n Address1: " + address1;
                message = message + "\n Address2: " + address2;
                message = message + "\n City: " + city;
                message = message + "\n StateProvinceCode: " + stateProvinceCode;
                message = message + "\n ZipCode: " + zipCode;
                message = message + "\n CountryCode: " + CountryCode;

                Assert.Fail(message);
            }
            

            PageObject_Profile.Nav_Profile().Click();
            AddDelay(15000);

            Driver.SwitchTo().Frame(0);
            ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, '#profile-div" + customerID + "')]")), 60);
            if (IsElementPresent(By.XPath("//a[contains(@href, '#profile-div" + customerID + "')]")))
            {
                Logger.WriteDebugMessage("Landed on Profile Page for CustomerID: " + customerID);

                xpathMobilePhone = "//dt[contains(text(), 'Mobile Phone')]/following::*[contains(text(), '" + cellPhone + "')]";
                xpathPrimaryPhone = "//dt[contains(text(), 'Primary Phone')]/following::*[contains(text(), '" + phoneNumber + "')]";
                xpathEmail = "//dt[contains(text(), 'Reservation Email')]/following::*[contains(text(), '" + emailAddress + "')]";
                xpathAddress1 = "//dt[contains(text(), 'Address Line 1')]/following::*[contains(text(), '" + address1 + "')]";
                xpathCity = "//dt[contains(text(), 'City')]/following::*[contains(text(), '" + city + "')]";
                xpathState = "//dt[contains(text(), 'State/Province')]/following::*[contains(text(), '" + stateprovinceProfile + "')]";
                xpathPostalCode = "//dt[contains(text(), 'Zip Code')]/following::*[contains(text(), '" + zipCode + "')]";
                xpathCountry = "//dt[contains(text(), 'Country')]/following::*[contains(text(), '" + CountryCode + "')]";

                if (IsElementPresent(By.XPath(xpathMobilePhone)) && IsElementPresent(By.XPath(xpathPrimaryPhone)) && IsElementPresent(By.XPath(xpathEmail)) && IsElementPresent(By.XPath(xpathAddress1)) && IsElementPresent(By.XPath(xpathCity)) && IsElementPresent(By.XPath(xpathState)) && IsElementPresent(By.XPath(xpathPostalCode)) && IsElementPresent(By.XPath(xpathCountry)))
                {
                    string message = "Found Profile Contact Details on Summary Page";
                    message = message + "\n Email: " + emailAddress;
                    message = message + "\n CellPhone: " + cellPhone;
                    message = message + "\n PhoneNumber: " + phoneNumber;
                    message = message + "\n Address1: " + address1;
                    message = message + "\n Address2: " + address2;
                    message = message + "\n City: " + city;
                    message = message + "\n StateProvinceCode: " + stateProvinceCode;
                    message = message + "\n ZipCode: " + zipCode;
                    message = message + "\n CountryCode: " + CountryCode;
                    Logger.WriteDebugMessage(message);

                }
                else
                {
                    string message = "Did not found Profile Contact Details on Summary Page";
                    message = message + "\n Email: " + emailAddress;
                    message = message + "\n CellPhone: " + cellPhone;
                    message = message + "\n PhoneNumber: " + phoneNumber;
                    message = message + "\n Address1: " + address1;
                    message = message + "\n Address2: " + address2;
                    message = message + "\n City: " + city;
                    message = message + "\n StateProvinceCode: " + stateProvinceCode;
                    message = message + "\n ZipCode: " + zipCode;
                    message = message + "\n CountryCode: " + CountryCode;

                    Assert.Fail(message);
                }

            }

        }
        public static void TC_207829()
        {
            PageObject_Search.Nav_Search().Click();
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue("Profile");
            Search.ClearInputValues();
            IList<String> InputElements = new List<String>
                {
                    searchDropDown.SelectedOption.GetAttribute("value"),
                    "Profile",
                    profile_ID
                };
            Search.searchBy(Driver, InputElements);
            AddDelay(500);
            Search.VerifyIDSearchResults(Driver, profile_ID, profile_ID);
            ElementClick(Driver.FindElement(By.XPath("//td[contains(text(), '30289223')]")));
            PageObject_Profile.Nav_Profile().Click();
            AddDelay(15000);

            Driver.SwitchTo().Frame(0);
            ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, '#profile-div" + customerID + "')]")), 60);

            if (IsElementPresent(By.XPath("//a[contains(@href, '#profile-div" + customerID + "')]")))
            {
                Logger.WriteDebugMessage("Landed on Profile Page for CustomerID: " + customerID);
                ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '#stays-div" + customerID + "')]")));
                if (VerifyTextOnPage(reservationNum))
                {
                    string message = "Found Stay Reservation Number " + reservationNum +  " on Profile -> Stay Page for CustomerID - " + customerID;
                   Logger.WriteDebugMessage(message);

                }
                else
                {
                    Assert.Fail("Reservation Number: " + reservationNum + " did not show on the page.");
                }
                

            }
        }
        #endregion[TP_207825]

    }
}
