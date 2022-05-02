using System;
using eNgage.Utility;
using eNgage.AppModule.UI;
using Common;
using Constants = eNgage.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using SqlWarehouse;
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

        private static string fName;
        private static string lName;
        private static string email;
        private static string phone;
        private static string memID;
        private static string resID;
        private static string zip_Code;

        public static void AssignDataVariables()
        {
            fName = SqlWarehouseQuery.ReturnGetTestDataValue(TestCaseId, "FirstName");
            lName = SqlWarehouseQuery.ReturnGetTestDataValue(TestCaseId, "LastName");
            email = SqlWarehouseQuery.ReturnGetTestDataValue(TestCaseId, "Email");
            phone = SqlWarehouseQuery.ReturnGetTestDataValue(TestCaseId, "Phone");
            memID = SqlWarehouseQuery.ReturnGetTestDataValue(TestCaseId, "MemberID");
            resID = SqlWarehouseQuery.ReturnGetTestDataValue(TestCaseId, "ReservationID");
            zip_Code = SqlWarehouseQuery.ReturnGetTestDataValue(TestCaseId, "Zip");
    }


        #region[TP_160101]
        public static void TC_160134()
        {
            AssignDataVariables();
            PageObject_Search.Nav_Search().Click();
            Search.VerifySearchValuesFields();
        }
        public static void TC_160143()
        {
            AssignDataVariables();
            PageObject_Search.Nav_Search().Click();
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue("Profile");
            Search.ClearInputValues();
            IList<String> InputElements = new List<String>
                {
                    searchDropDown.SelectedOption.GetAttribute("value"),
                    "Profile",
                    profileID
                };
            Search.searchBy(Driver, InputElements);
            AddDelay(500);
            Search.VerifyIDSearchResults(Driver, profileID, profileID);
        }
        public static void TC_160144()
        {
            AssignDataVariables();
            PageObject_Search.Nav_Search().Click();
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue("Name");
            Search.ClearInputValues();
            IList<String> InputElements = new List<String>();
            InputElements.Add(searchDropDown.SelectedOption.Text);
            InputElements.Add("Name");
            InputElements.Add(fName);
            InputElements.Add(lName);
            Search.searchBy(Driver, InputElements);
            AddDelay(500);
            Search.verifyNameSearchResults(Driver, fName, lName);
        }
        public static void TC_160146()
        {
            AssignDataVariables();
            PageObject_Search.Nav_Search().Click();
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue("Phone");
            Search.ClearInputValues();
            IList<String> InputElements = new List<String>
                {
                    searchDropDown.SelectedOption.GetAttribute("value"),
                    phone,
                    fName,
                    lName
                };
            Search.searchBy(Driver, InputElements);
            AddDelay(500);
            Search.VerifyEmailPhoneSearchResults(Driver, phone, fName, lName, searchDropDown.SelectedOption.GetAttribute("value"));
        }
        public static void TC_160147()
        {
            AssignDataVariables();
            PageObject_Search.Nav_Search().Click();
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue("Email");
            Search.ClearInputValues();
            IList<String> InputElements = new List<String>
                {
                    searchDropDown.SelectedOption.GetAttribute("value"),
                    email,
                    fName,
                    lName
                };
            Search.searchBy(Driver, InputElements);
            AddDelay(500);
            Search.VerifyEmailPhoneSearchResults(Driver, email, fName, lName, searchDropDown.SelectedOption.GetAttribute("value"));
        }
        public static void TC_160149()
        {
            AssignDataVariables();
            PageObject_Search.Nav_Search().Click();
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue("Membership");
            Search.ClearInputValues();
            IList<String> InputElements = new List<String>
                {
                    searchDropDown.SelectedOption.GetAttribute("value"),
                    "Membership",
                    memID,
                };
            Search.searchBy(Driver, InputElements);
            AddDelay(500);
            Search.VerifyIDSearchResults(Driver, memID, profileID);
        }
        public static void TC_243421()
        {
            AssignDataVariables();
            PageObject_Search.Nav_Search().Click();
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue("Reservation");
            Search.ClearInputValues();
            IList<String> InputElements = new List<String>
                {
                    searchDropDown.SelectedOption.GetAttribute("value"),
                    "Reservation",
                    resID,
                };
            Search.searchBy(Driver, InputElements);
            AddDelay(500);
            Search.VerifyIDSearchResults(Driver, resID, profileID);
        }
        public static void TC_243423()
        {
            AssignDataVariables();
            PageObject_Search.Nav_Search().Click();
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue("Zip");
            Search.ClearInputValues();
            IList<String> InputElements = new List<String>
                {
                    searchDropDown.SelectedOption.GetAttribute("value"),
                    zip_Code,
                    fName,
                    lName
                };
            Search.searchBy(Driver, InputElements);
            AddDelay(500);
            Search.VerifyEmailPhoneSearchResults(Driver, zip_Code, fName, lName, searchDropDown.SelectedOption.GetAttribute("value"));
        }
        public static void TC_160193()
        {
            AssignDataVariables();
            PageObject_Search.Nav_Search().Click();
            Search.searchByNullValues();
            Search.searchInvalidData(Driver, TestCaseId);
        }
        public static void TC_243411()
        {
            AssignDataVariables();
            PageObject_Search.Nav_Search().Click();
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue("Reservation");
            IList<String> InputElements = new List<String>
                {
                    searchDropDown.SelectedOption.GetAttribute("value"),
                    "Reservation",
                    resID,
                };
            Search.changeSearchButton("Search Hotel");
            Search.searchBy(Driver, InputElements);
            Search.checkSearchResultsForValid();
            AddDelay(500);
            Search.changeSearchButton("Search Network");
            Search.searchBy(Driver, InputElements);
            Search.checkSearchResultsForValid();
            AddDelay(500);

            Home.changeToHotelValue(null);
            Search.changeSearchButton("Search Hotel");
            Search.searchBy(Driver, InputElements);
            Search.checkSearchResultsForInvalid();
        }
        #endregion[TP_160101]
    }
}
