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
using SqlWarehouse;

namespace eNgage.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_243876]
        public static void TC_243878()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            PageObject_Home.Nav_Home().Click();
            PageObject_Search.Nav_Search().Click();
            AddDelay(500);
            IList<String> ReservationIDs = SqlWarehouseQuery.GetReservationIds(LegacyTestData.ClientName);
            Search.loadMultipleSearches(Driver, wait, ReservationIDs, "Reservation");
        }
        public static void TC_243948()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            PageObject_Home.Nav_Home().Click();
            AddDelay(1000);

            var CompanyName = "HotelOrigami";
            IList<String> FirstNames = SqlWarehouseQuery.GetFirstNameList(CompanyName);
            PageObject_Search.Nav_Search().Click();
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue("Name");
            /****Enter no of searches *****/
            int count = 5;
            int i = 0;
            while (i < count)
            {
                /*foreach (var i in FirstNames)
                {
                    Console.WriteLine(i);
                    IList<String> InputElements = new List<String>();
                    InputElements.Add(searchDropDown.SelectedOption.Text);
                    InputElements.Add("First");
                    InputElements.Add(i);
                    Search.searchBy(Driver, InputElements);
                    Search.clickFromSearchResults(Driver);
                    Prompts.checkPromptsLoad(Driver, wait);

                }*/

                Console.WriteLine(FirstNames[i]);
                IList<String> InputElements = new List<String>();
                InputElements.Add(searchDropDown.SelectedOption.Text);
                InputElements.Add("First");
                InputElements.Add(FirstNames[i]);
                Search.searchBy(Driver, InputElements);
                Search.clickFromSearchResults(Driver);
                AddDelay(500);
                Prompts.checkPromptsLoad(Driver, wait);
                PageObject_Search.Nav_Search().Click();
                i++;
                if (i == FirstNames.Count - 1)
                    i = 0;

            }
        }
        public static void TC_243949()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            PageObject_Home.Nav_Home().Click();
            PageObject_Search.Nav_Search().Click();
            AddDelay(500);
            IList<String> EmailList = SqlWarehouseQuery.GetEmailList(LegacyTestData.ClientName);
            IList<String> Emails = Search.FilterEmailList(EmailList);
            Search.loadMultipleSearches(Driver, wait, Emails, "Email");
        }
        public static void TC_251550()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            PageObject_Home.Nav_Home().Click();
            AddDelay(500);
            IList<IWebElement> dashboardTiles = PageObject_Home.Dashboard_Tiles();//Driver.FindElements(By.ClassName("dashboard-stat2"));
            dashboardTiles = PageObject_Home.Dashboard_Tiles();
            string count = PageObject_Home.Home_DashboardTile_Res_Count(); //dashboardTiles[0].FindElement(By.ClassName("number")).FindElement(By.TagName("h3")).Text;

            if (Convert.ToInt32(count) <= 2)
            {
                Home.changeDateAndCheckCount(Driver, wait);
            }
            PageObject_Home.Dashboard_FirstTile().Click();

            // Change this count value to chnage the number of profiles to be loaded.
            int TotalCountOfProfiles = 5;

            Home.loadMultipleProfiles(Driver, wait, TotalCountOfProfiles);
        }
        #endregion[TP_243876]

    }
}
