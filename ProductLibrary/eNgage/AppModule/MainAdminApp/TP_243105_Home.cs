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
        private static string count;
        #region[TP_243105]
        public static void TC_243109()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            PageObject_Home.Nav_Home().Click();
            wait.Until(x => x.FindElement(By.ClassName("dashboard-stat2")));
            IList<IWebElement> dashboardTiles = PageObject_Home.Dashboard_Tiles();
            count = PageObject_Home.Home_DashboardTile_Res_Count();
            //dashboardTiles[0].FindElement(By.ClassName("number")).FindElement(By.TagName("h3")).Text;
            dashboardTiles[0].Click();
            AddDelay(1000);
            Home.checkSearchResultDisplay(Driver, wait, count);
        }
        public static void TC_243110()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            PageObject_Home.Nav_Home().Click();
            wait.Until(x => x.FindElement(By.ClassName("dashboard-stat2")));
            IList<IWebElement> dashboardTiles = PageObject_Home.Dashboard_Tiles();
            count = PageObject_Home.Home_DashboardTile_Count(dashboardTiles[1]);
            //count = dashboardTiles[1].FindElement(By.ClassName("number")).FindElement(By.TagName("h3")).Text;
            dashboardTiles[1].Click();
            AddDelay(1000);
            Home.checkSearchResultDisplay(Driver, wait, count);

        }
        public static void TC_243112()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            PageObject_Home.Nav_Home().Click();
            wait.Until(x => x.FindElement(By.ClassName("dashboard-stat2")));
            IList<IWebElement> dashboardTiles = PageObject_Home.Dashboard_Tiles();
            count = PageObject_Home.Home_DashboardTile_Count(dashboardTiles[2]);
            //count = dashboardTiles[2].FindElement(By.ClassName("number")).FindElement(By.TagName("h3")).Text;
            dashboardTiles[2].Click();
            AddDelay(1000);
            Home.checkSearchResultDisplay(Driver, wait, count);

        }
        public static void TC_243113()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            PageObject_Home.Nav_Home().Click();
            wait.Until(x => x.FindElement(By.ClassName("dashboard-stat2")));
            IList<IWebElement> dashboardTiles = PageObject_Home.Dashboard_Tiles();
            count = PageObject_Home.Home_DashboardTile_Count(dashboardTiles[3]);
            //count = dashboardTiles[3].FindElement(By.ClassName("number")).FindElement(By.TagName("h3")).Text;
            dashboardTiles[3].Click();
            AddDelay(1000);
            Home.checkSearchResultDisplay(Driver, wait, count);
        }
        public static void TC_243114()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            PageObject_Home.Nav_Home().Click();
            wait.Until(x => x.FindElement(By.ClassName("dashboard-stat2")));
            IList<IWebElement> dashboardTiles = PageObject_Home.Dashboard_Tiles();
            count = PageObject_Home.Home_DashboardTile_Count(dashboardTiles[4]);
            //count = dashboardTiles[4].FindElement(By.ClassName("number")).FindElement(By.TagName("h3")).Text;
            dashboardTiles[4].Click();
            AddDelay(1000);
            Home.checkSearchResultDisplay(Driver, wait, count);

        }
        public static void TC_243118()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            PageObject_Home.Nav_Home().Click();
            wait.Until(x => x.FindElement(By.ClassName("dashboard-stat2")));
            IList<IWebElement> dashboardTiles = PageObject_Home.Dashboard_Tiles();
            count = PageObject_Home.Home_DashboardTile_Count(dashboardTiles[5]);
            //count = dashboardTiles[5].FindElement(By.ClassName("number")).FindElement(By.TagName("h3")).Text;
            dashboardTiles[5].Click();
            AddDelay(1000);
            Home.checkSearchResultDisplay(Driver, wait, count);
        }
        public static void TC_243120()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(50));
            PageObject_Home.Nav_Home().Click();
            wait.Until(x => x.FindElement(By.ClassName("dashboard-stat2")));

            AddDelay(500);
            IWebElement dashboardTile = PageObject_Home.Dashboard_FirstTile();
            var selectedHotel = PageObject_Home.Home_SelectedHotel();

            Helper.AddDelay(500);
            IList<IWebElement> hotels = PageObject_Home.Home_Hotels_List();

            for (int i = 1; i < hotels.Count - 1; i++)
            {
                count = PageObject_Home.Home_DashboardTile_Res_Count();
                hotels = PageObject_Home.Home_Hotels_List();
                Home.changeHotel(hotels[i], Driver);
            }
            Home.SearchHotelName(Driver);
            Home.changeDate(Driver);
            Home.refreshHomePage(Driver);
            Home.verifyPercentage(Driver, wait);
        }
        public static void TC_243608()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            PageObject_Home.Nav_Home().Click();
            wait.Until(x => x.FindElement(By.ClassName("dashboard-stat2")));
            IList<IWebElement> dashboardTiles = PageObject_Home.Dashboard_Tiles();
            count = PageObject_Home.Home_DashboardTile_Res_Count();
            if (count == "0")
            {
                Home.changeDateAndCheckCount(Driver, wait);
            }
            dashboardTiles = PageObject_Home.Dashboard_Tiles();
            foreach (IWebElement dashboard in dashboardTiles)
            {
                count = dashboard.FindElement(By.ClassName("number")).FindElement(By.TagName("h3")).Text;
                dashboard.Click();
                AddDelay(2000);
                Home.searchResultsCount(Driver, wait, count);
            }
        }
        public static void TC_160133()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            AddDelay(1000);
            Home.verifyLandingPage(Driver);

        }
        public static void TC_243996()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            PageObject_Home.Nav_Home().Click();
            AddDelay(1000);
            Home.DashboardIconText();
        }
        public static void TC_244589()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            PageObject_Home.Nav_Home().Click();
            wait.Until(x => x.FindElement(By.ClassName("dashboard-stat2")));
            IList<IWebElement> dashboardTiles = PageObject_Home.Dashboard_Tiles();
            count = PageObject_Home.Home_DashboardTile_Count(dashboardTiles[0]);
            //count = dashboardTiles[0].FindElement(By.ClassName("number")).FindElement(By.TagName("h3")).Text;

            if (count == "0")
            {
                Home.changeHotelDropDown(Driver, wait);
                count = PageObject_Home.Home_DashboardTile_Count(dashboardTiles[0]);
            }
            while (count == "0")
                Home.changeDateAndCheckCount(Driver, wait);
            dashboardTiles = PageObject_Home.Dashboard_Tiles();
            dashboardTiles[0].Click();
            AddDelay(500);
            Home.HomeSearchList(Driver, wait);
            Prompts.checkPromptsLoad(Driver, wait);
            Banner.checkBannerLoad(Driver, wait);
            Summary.checkSummaryLoad(Driver, wait);
        }
        #endregion[TP_243105]

    }
}
