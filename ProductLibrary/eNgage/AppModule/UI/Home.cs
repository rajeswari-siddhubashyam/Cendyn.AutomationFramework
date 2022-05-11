using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseUtility.Utility;
using InfoMessageLogger;
using Common;
using OpenQA.Selenium;
using eNgage.PageObject.UI;
using eNgage.Utility;
using BaseUtility.Utility.Hotmail;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace eNgage.AppModule.UI
{
    class Home
    {
        public static void checkSearchResultDisplay(IWebDriver d, WebDriverWait wait, String HomeScreenCount)
        {
            if (HomeScreenCount != "0")
            {
                wait.Until(x => (bool)(x as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0"));
                IWebElement searchResults = d.FindElement(By.Id("resultsTable")).FindElement(By.TagName("tbody"));
                IList<IWebElement> searchResults_Rows = searchResults.FindElements(By.TagName("tr"));
                if (searchResults_Rows.Count > 0)
                {
                    Logger.WriteDebugMessage("Search Results Rows are present");
                }
                else
                {
                    Logger.WriteFatalMessage("Search Results empty");
                }
                Assert.NotZero(searchResults_Rows.Count);
            }
            else
            {
                Logger.WriteDebugMessage("Count 0");

            }


        }
        public static void searchResultsCount(IWebDriver d, WebDriverWait wait, String HomeScreenCount)
        {
            if (HomeScreenCount != "0")
                wait.Until(x => (bool)(x as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0"));

            IWebElement searchResults = d.FindElement(By.Id("resultsTable")).FindElement(By.TagName("tbody"));
            IList<IWebElement> searchResults_Rows = searchResults.FindElements(By.TagName("tr"));

            Logger.WriteDebugMessage(d.FindElement(By.ClassName("SearchReport")).Text + " Count " + HomeScreenCount + " Search Rows " + searchResults_Rows.Count);

            if (HomeScreenCount != searchResults_Rows.Count.ToString())
            {
                Logger.WriteFatalMessage("Count mismatch");
            }

            Assert.AreEqual(HomeScreenCount, searchResults_Rows.Count.ToString());

            PageObject_Home.Nav_Home().Click();
        }

        public static void changeHotelDropDown(IWebDriver d, WebDriverWait w)
        {
            try
            {
                Logger.WriteDebugMessage("Changing Hotel");
                var headerContainer = PageObject_Home.Home_HeaderContainer();
                var selectedHotel = PageObject_Home.Home_SelectedHotel();
                selectedHotel.Click();
                Helper.AddDelay(500);
                IList<IWebElement> hotels = PageObject_Home.Home_Hotels_List();
                //IList<IWebElement> hotels = headerContainer.FindElements(By.CssSelector(".dropdown-menu.inner li"));
                //IList<IWebElement> hotels = headerContainer.FindElement(By.CssSelector("ul[class='dropdown-menu inner']")).FindElements(By.TagName("li"));
                //Console.WriteLine("inside change hotelDropdown");
                for (int i = 1; i < hotels.Count; i++)
                {
                    hotels[i].Click();
                    Helper.AddDelay(500);
                    w.Until(x => x.FindElement(By.ClassName("dashboard-stat2")));
                    IWebElement dashboard = PageObject_Home.Dashboard_FirstTile();
                    //string count = dashboard.FindElement(By.ClassName("number")).FindElement(By.TagName("h3")).Text;
                    string count = PageObject_Home.Home_DashboardTile_Res_Count();
                    if (count != "0")
                        i = hotels.Count;
                    else
                        selectedHotel.Click();
                }
            }
            catch (TimeoutException e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        public static void HomeSearchList(IWebDriver d, WebDriverWait w)
        {
            IList<IWebElement> searchResults_Rows = PageObject_Search.Search_Results().FindElements(By.TagName("tr"));
            Random randomNumber = new Random();
            Logger.WriteDebugMessage("Selecting a random profile from search list");
            int row = randomNumber.Next(0, searchResults_Rows.Count - 1);
            if (searchResults_Rows.Count != 0)
                searchResults_Rows[row].FindElement(By.TagName("td")).Click();
            else
            {
                Assert.Fail("Search result empty");
                Logger.WriteFatalMessage("Search result empty");
            }

        }
        public static void changeDateAndCheckCount(IWebDriver d, WebDriverWait w)
        {
            //d.FindElement(By.Id("homeDate")).Click();

            PageObject_Home.Home_Date().Click();
            Helper.AddDelay(100);
            //PageObject_Home.Home_Calendar_Table().Click();

            PageObject_Home.Home_Calendar_Prev_Month().Click();

            Random randomNumber = new Random();
            int row = randomNumber.Next(0, 5);
            int column = randomNumber.Next(0, 6);
            PageObject_Home.Home_Calendar_Table().FindElement(By.CssSelector("[data-title=r" + row + "c" + column + "]")).Click();
            Logger.WriteDebugMessage("Changing Calendar Date");
            Helper.AddDelay(500);

            IList<IWebElement> dashboardTiles = PageObject_Home.Dashboard_Tiles();
            string count = dashboardTiles[0].FindElement(By.ClassName("number")).FindElement(By.TagName("h3")).Text;
            if (Convert.ToInt32(count) <= 10)
            {
                changeDateAndCheckCount(d, w);
            }
            /* else
                 dashboardTiles[0].Click();*/
        }
        public static void changeHotel(IWebElement hotel, IWebDriver d)
        {
            try
            {
                var selectedHotel = PageObject_Home.Home_SelectedHotel();
                selectedHotel.Click();
                var dropdownSelect = hotel.Text.Trim();
                Helper.AddDelay(500);
                hotel.Click();
                Helper.AddDelay(500);
                Helper.ElementWait(PageObject_Home.Dashboard_FirstTile(), 50);
                selectedHotel = PageObject_Home.Home_SelectedHotel();
                Assert.AreEqual(dropdownSelect, selectedHotel.Text.Trim());
                if (dropdownSelect == selectedHotel.Text.Trim())
                    Logger.WriteDebugMessage("Selected Hotel " + selectedHotel.Text);
                else
                    Logger.WriteFatalMessage("Hotel names different");
                //w.Until(x => x.FindElement(By.ClassName("dashboard-stat2")));
            }
            catch (TimeoutException e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        public static void loadMultipleProfiles(IWebDriver d, WebDriverWait w, int TotalCount)
        {

            IList<IWebElement> searchResults_Rows = PageObject_Search.Search_Results().FindElements(By.TagName("tr"));
            int i = 0;
            int count = 0;
            while (count <= TotalCount)
            {
                count++;
                Logger.WriteInfoMessage("Profile ID " + searchResults_Rows[i].FindElement(By.TagName("td")).Text + " Count " + count);
                searchResults_Rows[i].FindElement(By.TagName("td")).Click();

                Helper.AddDelay(200);
                Prompts.checkPromptsLoad(d, w);
                
                PageObject_Search.Nav_Search().Click();
                i++;
                if (i > searchResults_Rows.Count - 1)
                {
                    i = 0;
                }

            }
            /*for (int i = 1; i <= 5; i++)
            {
                searchResults_Rows[i].FindElement(By.TagName("td")).Click();
                Helper.AddDelay(200);
                Prompts.checkPromptsLoad(d,w);
                Logger.WriteDebugMessage("Profiles Loaded Count " + i);
                PageObject_Search.Nav_Search().Click();
            }*/
        }
        public static void SearchHotelName(IWebDriver d)
        {
            var selectedHotel = PageObject_Home.Home_SelectedHotel();
            selectedHotel.Click();
            IList<IWebElement> hotels = PageObject_Home.Home_Hotels_List();
            Random r = new Random();
            int hotelIndex = r.Next(0, hotels.Count - 1);
            var searchText = hotels[hotelIndex].Text;
            PageObject_Home.Home_Search_hotel().SendKeys(searchText);
            Logger.WriteDebugMessage("Search Text entered -" + searchText);
            hotels = PageObject_Home.Home_Hotels_Active_List();
            if (hotels.Count != 0)
            {
                hotels[0].Click();
                Helper.AddDelay(500);
                selectedHotel = PageObject_Home.Home_SelectedHotel();
                Assert.IsTrue(selectedHotel.Text.Trim().Contains(searchText.Trim()));
                if (selectedHotel.Text.Trim().Contains(searchText.Trim()))
                    Logger.WriteDebugMessage("Searched Hotel found " + selectedHotel.Text.Trim());
                else
                    Logger.WriteFatalMessage("Hotel names different");
            }
            else
                Logger.WriteDebugMessage("Searched hotel name not present");
        }
        public static void changeDate(IWebDriver d)
        {
            PageObject_Home.Home_Date().Click();
            Helper.AddDelay(500);
            PageObject_Home.Home_Calendar_Prev_Month().Click();
            IWebElement dayElement;
            do
            {
                Random randomNumber = new Random();
                int row = randomNumber.Next(0, 5);
                int column = randomNumber.Next(0, 6);
                dayElement = PageObject_Home.Home_Calendar_Table().FindElement(By.CssSelector("[data-title=r" + row + "c" + column + "]"));
                //var ClassName = dayElement.GetAttribute("class");
            } while (dayElement.GetAttribute("class").Contains("off") == true);

            var day = dayElement.Text;
            IWebElement monthElement = PageObject_Home.Home_Calendar_Table().FindElement(By.ClassName("month"));
            var month = monthElement.Text;
            Logger.WriteDebugMessage("Changing Calendar Date to Month " + month.Trim() + "Day " + day.Trim());
            dayElement.Click();

            //Console.WriteLine(month.Trim()+" "+day.Trim());
            Helper.AddDelay(500);

            IList<IWebElement> dashboardTiles = PageObject_Home.Dashboard_Tiles();
            string count = PageObject_Home.Home_DashboardTile_Res_Count();
            if (Convert.ToInt32(count) == 0)
            {
                changeDate(d);
            }
            else
            {
                IWebElement calendar = PageObject_Home.Home_Date();

                var CalendarDate = DateTime.Parse(calendar.Text);
                var selectedDate = DateTime.Parse(day.Trim() + " " + month.Trim());
                //Console.WriteLine("CalendarDate " + CalendarDate + " selectedDate " + selectedDate);
                Assert.AreEqual(CalendarDate, selectedDate);
                if (CalendarDate == selectedDate)
                {
                    Logger.WriteDebugMessage("Date matching");
                }
                else
                {
                    Logger.WriteFatalMessage("Date is not changed");
                }
            }

        }
        public static void refreshHomePage(IWebDriver d)
        {
            var LastUpdated = d.FindElement(By.XPath(ObjectRepository.Home_LastUpdated));
            var LastUpdatedBeforeRefresh = Convert.ToDateTime(PageObject_Home.Home_LastUpdated().Text);
            PageObject_Home.Home_Refresh().Click();
            Helper.AddDelay(500);
            //Helper.WaittillElementDisplay(PageObject_Home.Dashboard_FirstTile());

            var LastUpdatedAfterRefresh = Convert.ToDateTime(PageObject_Home.Home_LastUpdated().Text);
            Assert.AreNotEqual(LastUpdatedBeforeRefresh, LastUpdatedAfterRefresh);
            if (LastUpdatedAfterRefresh > LastUpdatedBeforeRefresh)
            {
                Logger.WriteDebugMessage("Refresh Page is complete");
            }
            else
            {
                Logger.WriteFatalMessage("On clicking Refresh - Page is not updated");
            }
        }
        public static void verifyPercentage(IWebDriver d, WebDriverWait w)
        {
          
            int count = Convert.ToInt32(PageObject_Home.Home_DashboardTile_Res_Count());
            if (count <= 10)
                Home.changeDateAndCheckCount(d, w);

            IWebElement departure = Home.FindDashboardTile("Departures", d);
            int count2 = Convert.ToInt32(PageObject_Home.Home_DashboardTile_Count(departure));
            string ProgressPercentage = PageObject_Home.Home_DashboardTile_ProgressPercentage(departure);
            string ProgressBarWidth = PageObject_Home.Home_DashboardTile_ProgressBar_Width(departure);
           
            Helper.AddDelay(1000);
            if (count2 > 0)
            {
                Assert.NotZero(Convert.ToInt32(ProgressPercentage.Trim()));
                if (Convert.ToInt32(ProgressPercentage.Trim()) > 0) 
                {
                    Logger.WriteDebugMessage("Progress Bar is loading");
                }
                else
                { 
                        Logger.WriteFatalMessage("Progress Bar & Percentage is not loaded");
                }

            }
            else
            {
                Logger.WriteInfoMessage("No data");
            }
        }
        public static IWebElement FindDashboardTile(string element, IWebDriver d)
        {
            IWebElement returnElement = null;
            IList<IWebElement> DashboardTiles = PageObject_Home.Dashboard_Tiles();
            for (int i = 0; i < DashboardTiles.Count; i++)
            {
                var text = PageObject_Home.Home_DashboardTile_Text(DashboardTiles[i]);
                if (text.Trim()==element)
                {
                    returnElement = DashboardTiles[i];
                }
            }
            return returnElement;
        }

        public static void DashboardIconText()
        {
            PageObject_Home.Nav_Home().Click();
            Helper.AddDelay(1000);
            IList<IWebElement> DashboardTiles = PageObject_Home.Dashboard_Tiles();
            bool textAndCount = true;
            bool icon = true;
            foreach (IWebElement element in DashboardTiles)
            {
                if (textAndCount == true)
                {
                    if (PageObject_Home.Home_DashboardTile_Text(element) == "" && PageObject_Home.Home_DashboardTile_Count(element) == "")
                    {
                        textAndCount = false;
                    }
                }
                
                string className = PageObject_Home.Home_DashboardTile_Icon(element).GetAttribute("class");
                if (icon == true)
                {
                    if (className.Contains("icon-"))
                    {
                        icon = true;
                    }
                    else
                        icon = false;
                }
            }
            Assert.IsTrue(textAndCount);
            if (textAndCount == true)
            {
                Logger.WriteDebugMessage("Count & text for DashboardTile found");
            }
            else
            {
                Logger.WriteDebugMessage("Count or text missing for DashboardTile");
            }
            Assert.IsTrue(icon);
            if (icon == true)
            {
                Logger.WriteDebugMessage("Icon for DashboardTiles found");
            }
            else
            {
                Logger.WriteDebugMessage("Icon missing for DashboardTiles");
            }
        }
        public static void verifyLandingPage(IWebDriver d)
        {
            IWebElement LandingPage = PageObject_Login.Login_LandingPage();
            if (LegacyTestData.FrontEndURL != "" && LegacyTestData.FrontEndURL != null)
            {
                if (LegacyTestData.FrontEndURL.Contains("Minor") == true)
                {
                    Assert.AreEqual(LandingPage.Text, "Search");
                    if (LandingPage.Text == "Search")
                    {
                        Logger.WriteDebugMessage("Default Landing page is "+ LandingPage.Text);
                    }
                    else
                    {
                        Logger.WriteFatalMessage("Landing page is different " + LandingPage.Text);
                    }
                }

            }
            else
            {
                Assert.AreEqual(LandingPage.Text, "Home");
                if (LandingPage.Text == "Home")
                {
                    Logger.WriteDebugMessage("Default Landing page is " + LandingPage.Text);
                }
                else
                {
                    Logger.WriteFatalMessage("Landing page is different " + LandingPage.Text);
                }
            }

        }
        public static void changeToHotelValue(string hotelName)
        {
            try
            {
                var selectedHotel = PageObject_Home.Home_SelectedHotel();
                selectedHotel.Click();
                IList<IWebElement> hotels = PageObject_Home.Home_Hotels_List();

                if(hotelName!="" && hotelName != null)
                {
                    foreach (IWebElement i in hotels)
                    {
                        if (i.Text.Trim() == hotelName)
                        {
                            i.Click();
                            Helper.AddDelay(500);
                        }
                    }
                }
                else
                {
                    Random r = new Random();
                    int j =r.Next(1, hotels.Count - 1);
                    hotels[j].Click();
                    Helper.AddDelay(500);
                }

                Logger.WriteInfoMessage("Changed Hotel to " + PageObject_Home.Home_SelectedHotel().Text.Trim());
                    
            }
            catch (TimeoutException e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
    }
}
