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
        private static string currencyXPath = "";
        private static string withID = "";
        private static string eachStayRateAmountProp = "";
        private static string currecycode = "";

        #region[TP_166736]
        public static void TC_152570()
        {
            UserStayData stayData = new UserStayData();
            SqlWarehouseQuery.GetCurrencyDetails(stayData, companyNameByTestCase, "property");
            Navigation.MenuNavigation("Profile");
            Profile.SelectSubClient(stayData.PropertyName);
            PageLoadWait(120, "Profile.mvc/Profile");
            ElementWait(Driver.FindElement(By.XPath("//input[@id='search']")), 120);
            ElementWait(PageObject_Profile.Profile_SearchGuestsSearch(), 120);
            Profile.SelectSearchGuestsSearchBy("Customer ID");
            Profile.InsertTextSearchGuestsSearchFor(stayData.CustomerID);
            Logger.WriteDebugMessage("Searching for an customer for a reservation number : " + stayData.ReservationNumber + " on profile search page.");
            AddDelay(15000);
            Profile.ClickOpenProfile(stayData.CustomerID);
            AddDelay(8000);
            ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, '#profile-div" + stayData.CustomerID + "')]")), 60);

            string currencyXPath = "//select[contains(@name,'RFMCurrency" + stayData.CustomerID + "')]";

            Profile.SelectCurrency(currencyXPath, "USD");

            string withID = "profileimage" + stayData.CustomerID;
            AddDelay(20000);
            ScrollToElement(Driver.FindElement(By.Id(withID)));
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '#stays-div" + stayData.CustomerID + "')]")));
            Logger.WriteDebugMessage("Landed on Profile - Stays Tab");
            ElementWait(Driver.FindElement(By.XPath("//*[contains(text(), 'Stay Overview')]")), 120);

            string[] eachStayRateAmountProp = Regex.Split(stayData.StayRateAmountConvertedUSD, ",");
            foreach (string StayRateAmountProp in eachStayRateAmountProp)
            {
                ScrollToElement(Driver.FindElement(By.Id(withID)));
                if (VerifyTextOnPage(StayRateAmountProp))
                {
                    Logger.WriteDebugMessage("Found StayRateAmount : USD" + StayRateAmountProp);
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(@onclick, '" + stayData.SourceStayID + "')]")));
                    AddDelay(20000);
                    Logger.WriteDebugMessage("Landed on Stay Overview Page.");
                    if (VerifyTextOnPage(StayRateAmountProp))
                    {
                        Logger.WriteDebugMessage("Found StayRateAmount : USD" + StayRateAmountProp);
                    }

                }
                else
                {
                    Assert.Fail("Amount was not found for CustomerID - " + stayData.CustomerID + "\n Expected Result - USD" + StayRateAmountProp);
                }
                Logger.WriteInfoMessage("Checking for RFM Monetory.");

                SqlWarehouseQuery.GetRFMCurrency(stayData, companyNameByTestCase, "USD");

                ScrollToElement(PageObject_Profile.Profile_Client());

                if (String.IsNullOrEmpty(stayData.Monetory))
                {
                    stayData.Monetory = "0.00";
                    if (VerifyTextOnPage(stayData.Monetory))
                    {
                        Logger.WriteDebugMessage("Found amount monetory USD " + stayData.Monetory + " for CustomerID - " + stayData.CustomerID);
                    }

                }
                else if (!String.IsNullOrEmpty(stayData.Monetory))
                {
                    if (VerifyTextOnPage(stayData.Monetory))
                    {
                        Logger.WriteDebugMessage("Found amount monetory USD " + stayData.Monetory + " for CustomerID - " + stayData.CustomerID);
                    }
                }
                else
                {
                    Assert.Fail("RFM Lifetime Spend did not matched for CustomerID - " + stayData.CustomerID + "\n Expected Monetory: " + stayData.Monetory);
                }
            }
        }
        public static void TC_152607()
        {
            UserStayData stayData = new UserStayData();
            
            
            SqlWarehouseQuery.GetCurrencyDetails(stayData, companyNameByTestCase, "property");
            Navigation.MenuNavigation("Profile");
            Profile.SelectSubClient(stayData.PropertyName);
            PageLoadWait(120, "Profile.mvc/Profile");
            ElementWait(Driver.FindElement(By.XPath("//input[@id='search']")), 120);
            ElementWait(PageObject_Profile.Profile_SearchGuestsSearch(), 120);
            Profile.SelectSearchGuestsSearchBy("Customer ID");
            Profile.InsertTextSearchGuestsSearchFor(stayData.CustomerID);
            Logger.WriteDebugMessage("Searching for an customer for a reservation number : " + stayData.ReservationNumber + " on profile search page.");
            AddDelay(50000);
            Profile.ClickOpenProfile(stayData.CustomerID);
            AddDelay(50000);
            ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, '#profile-div" + stayData.CustomerID + "')]")), 120);

            string withID = "profileimage" + stayData.CustomerID;
            AddDelay(20000);
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '#stays-div" + stayData.CustomerID + "')]")));
            Logger.WriteDebugMessage("Landed on Profile - Stays Tab");
            ManageCampaign.WaitForReady();
            ElementWait(Driver.FindElement(By.XPath("//*[contains(text(), 'Stay Overview')]")), 120);

            string currecycode = "USD," + stayData.CurrencyCode;
            string[] eachCurrencyCode2 = Regex.Split(currecycode, ",");
            foreach (string currency in eachCurrencyCode2)
            {
                currencyXPath = "//select[contains(@name,'RFMCurrency" + stayData.CustomerID + "')]";

                Profile.SelectCurrency(currencyXPath, currency);

                AddDelay(5000);
                ScrollToElement(Driver.FindElement(By.Id(withID)));
                Logger.WriteInfoMessage("Selected currency - " + currency);
                withID = "profileimage" + stayData.CustomerID;
                AddDelay(20000);
                ScrollToElement(Driver.FindElement(By.Id(withID)));

                ElementWait(Driver.FindElement(By.XPath("//*[contains(text(), 'Stay Overview')]")), 120);

                string[] eachStayRateAmountProp2 = Regex.Split(stayData.StayRateAmount_Prop, ",");
                foreach (string StayRateAmountProp in eachStayRateAmountProp2)
                {
                    if (currency == "USD")
                    {
                        if (VerifyTextOnPage(stayData.StayRateAmountConvertedUSD))
                        {
                            Logger.WriteDebugMessage("Found StayRateAmount : " + currency + stayData.StayRateAmountConvertedUSD);
                            AddDelay(15000);
                            ElementClick(Driver.FindElement(By.XPath("//a[contains(@onclick, '" + stayData.SourceStayID + "')]")));
                            ManageCampaign.WaitForReady();
                            AddDelay(20000);
                            Logger.WriteDebugMessage("Landed on Stay Overview Page.");
                            if (VerifyTextOnPage(stayData.StayRateAmountConvertedUSD))
                            {
                                Logger.WriteDebugMessage("Found StayRateAmount : " + currency + stayData.StayRateAmountConvertedUSD);
                            }
                            else
                            {
                                Assert.Fail("USD Amount was not found on Stay Detail Page for CustomerID - " + stayData.CustomerID);
                            }

                        }
                    }
                    else if (currency != "$ USD")
                    {
                        AddDelay(20000);
                        Logger.WriteDebugMessage("Landed on Stay Overview Page.");
                        VerifyTextOnPage(StayRateAmountProp);
                        Logger.WriteDebugMessage("Found StayRateAmount : " + currency + StayRateAmountProp);
                    }
                    else
                    {
                        Assert.Fail("Currency was not found for CustomerID " + stayData.CustomerID + "\n Expected Result - " + currency + StayRateAmountProp);
                    }
                    Logger.WriteInfoMessage("Checking for RFM Monetory.");

                    SqlWarehouseQuery.GetRFMCurrency(stayData, companyNameByTestCase, currency);

                    if (String.IsNullOrEmpty(stayData.Monetory))
                    {
                        stayData.Monetory = "0.00";
                    }

                    ScrollToElement(PageObject_Profile.Profile_Client());

                    if (VerifyTextOnPage(stayData.Monetory))
                    {
                        Logger.WriteDebugMessage("Found amount monetory " + currency + stayData.Monetory + " for CustomerID - " + stayData.CustomerID);
                    }
                    else
                    {
                        Assert.Fail("RFM Lifetime Spend did not matched for CustomerID - " + stayData.CustomerID + " with Lifetime spend -  " + currency + stayData.Monetory);
                    }
                    //Actions action = new Actions(Driver);
                    //action.KeyDown(Keys.Control).KeyDown(Keys.Home).KeyUp(Keys.Control).KeyUp(Keys.Home).Perform();

                    ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Stay Overview')]")));
                    ManageCampaign.WaitForReady();
                    if (IsElementPresent(By.XPath("staysRegularTable" + stayData.CustomerID)))
                    {
                        Logger.WriteDebugMessage("Landed on Stay Overview Tab.");
                    }
                }
            }
        }
        public static void TC_152686()
        {
            UserStayData stayData = new UserStayData();
        
            SqlWarehouseQuery.GetCurrencyDetails(stayData, clientNameByTestCase, "property");
            Navigation.MenuNavigation("Profile");
            Profile.SelectSubClient(stayData.PropertyName);
            PageLoadWait(120, "Profile.mvc/Profile");
            ElementWait(Driver.FindElement(By.XPath("//input[@id='search']")), 120);
            ElementWait(PageObject_Profile.Profile_SearchGuestsSearch(), 120);
            Profile.SelectSearchGuestsSearchBy("Customer ID");
            Profile.InsertTextSearchGuestsSearchFor(stayData.CustomerID);
            Logger.WriteDebugMessage("Searching for an customer for a reservation number : " + stayData.ReservationNumber + " on profile search page.");
            AddDelay(15000);
            Profile.ClickOpenProfile(stayData.CustomerID);
            AddDelay(15000);
            ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, '#profile-div" + stayData.CustomerID + "')]")), 60);

            currencyXPath = "//select[contains(@name,'RFMCurrency" + stayData.CustomerID + "')]";

            Profile.SelectCurrency(currencyXPath, stayData.CurrencyCode);

            AddDelay(3000);

            withID = "profileimage" + stayData.CustomerID;
            AddDelay(20000);
            ScrollToElement(Driver.FindElement(By.Id(withID)));
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '#stays-div" + stayData.CustomerID + "')]")));
            ManageCampaign.WaitForReady();
            Logger.WriteDebugMessage("Landed on Profile - Stays Tab");

            ElementWait(Driver.FindElement(By.XPath("//*[contains(text(), 'Stay Overview')]")), 120);
            
            string[] eachStayRateAmountProp = Regex.Split(stayData.StayRateAmountConvertedUSD, ",");
            eachStayRateAmountProp = Regex.Split(stayData.StayRateAmount_Prop, ",");
            foreach (string StayRateAmountProp in eachStayRateAmountProp)
            {
                ScrollToElement(Driver.FindElement(By.Id(withID)));
                VerifyTextOnPage(StayRateAmountProp);
                Logger.WriteDebugMessage("Found StayRateAmount : " + stayData.CurrencyCode + StayRateAmountProp);
                ElementClick(Driver.FindElement(By.XPath("//a[contains(@onclick, '" + stayData.SourceStayID + "')]")));
                ManageCampaign.WaitForReady();
                AddDelay(20000);
                Logger.WriteDebugMessage("Landed on Stay Overview Page.");
                VerifyTextOnPage(StayRateAmountProp);
                Logger.WriteDebugMessage("Found StayRateAmount : " + StayRateAmountProp);

                Logger.WriteInfoMessage("Checking for RFM Monetory.");

                SqlWarehouseQuery.GetRFMCurrency(stayData, clientNameByTestCase, stayData.CurrencyCode);

                if (String.IsNullOrEmpty(stayData.Monetory))
                {
                    stayData.Monetory = "0.00";
                }

                ScrollToElement(PageObject_Profile.Profile_Client());

                if (VerifyTextOnPage(stayData.Monetory))
                {
                    Logger.WriteDebugMessage("Found amount monetory " + stayData.CurrencyCode + stayData.Monetory + " for CustomerID - " + stayData.CustomerID);
                }
                else
                {
                    Assert.Fail("RFM Lifetime Spend did not matched for CustomerID - " + stayData.CustomerID + "\n Expected Result - " + stayData.CurrencyCode + stayData.Monetory);
                }
            }
        }
        public static void TC_168859()
        {
            UserStayData stayData = new UserStayData();

            SqlWarehouseQuery.GetCurrencyDetails(stayData, clientNameByTestCase, "property");
            Navigation.MenuNavigation("Profile");
            Profile.SelectSubClient(stayData.PropertyName);
            PageLoadWait(120, "Profile.mvc/Profile");
            ElementWait(Driver.FindElement(By.XPath("//input[@id='search']")), 120);
            ElementWait(PageObject_Profile.Profile_SearchGuestsSearch(), 120);
            Profile.SelectSearchGuestsSearchBy("Customer ID");
            Profile.InsertTextSearchGuestsSearchFor(stayData.CustomerID);
            Logger.WriteDebugMessage("Searching for an customer for a reservation number : " + stayData.ReservationNumber + " on profile search page.");
            AddDelay(15000);
            Profile.ClickOpenProfile(stayData.CustomerID);
            ManageCampaign.WaitForReady();
            AddDelay(25000);
            ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, '#profile-div" + stayData.CustomerID + "')]")), 120);

            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '#stays-div" + stayData.CustomerID + "')]")));
            ManageCampaign.WaitForReady();
            Logger.WriteDebugMessage("Landed on Profile - Stays Tab");
            ElementWait(Driver.FindElement(By.XPath("//*[contains(text(), 'Stay Overview')]")), 120);

            currecycode = "USD";
            if (stayData.CurrencyCode != "USD")
            {
                currecycode = currecycode + "," + stayData.CurrencyCode;
            }
            
            string[] eachCurrencyCode3 = Regex.Split(currecycode, ",");
            foreach (string currency in eachCurrencyCode3)
            {
                currencyXPath = "//select[contains(@name,'RFMCurrency" + stayData.CustomerID + "')]";

                Profile.SelectCurrency(currencyXPath, currency);

                AddDelay(3000);
                withID = "profileimage" + stayData.CustomerID;

                ScrollToElement(Driver.FindElement(By.Id(withID)));
                Logger.WriteInfoMessage("Selected currency - " + currency);
                AddDelay(20000);
                ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '#stays-div" + stayData.CustomerID + "')]")));
                ManageCampaign.WaitForReady();
                Logger.WriteDebugMessage("Landed on Profile - Stays Tab");

                ElementWait(Driver.FindElement(By.XPath("//*[contains(text(), 'Stay Overview')]")), 120);

                string[] eachStayRateAmountProp2 = Regex.Split(stayData.StayRateAmount_Prop, ",");
                foreach (string StayRateAmountProp in eachStayRateAmountProp2)
                {
                    if (currency == "USD")
                    {
                        if (VerifyTextOnPage(stayData.StayRateAmountConvertedUSD))
                        {
                            Logger.WriteDebugMessage("Found StayRateAmount : " + currency + stayData.StayRateAmountConvertedUSD);
                            ScrollToElement(Driver.FindElement(By.XPath("//a[contains(@onclick, '" + stayData.SourceStayID + "')]")));
                            ElementClick(Driver.FindElement(By.XPath("//a[contains(@onclick, '" + stayData.SourceStayID + "')]")));
                            AddDelay(20000);
                            Logger.WriteDebugMessage("Landed on Stay Overview Page.");
                            if (VerifyTextOnPage(stayData.StayRateAmountConvertedUSD))
                            {
                                Logger.WriteDebugMessage("Found StayRateAmount : " + currency + stayData.StayRateAmountConvertedUSD);
                            }
                            else
                            {
                                Assert.Fail("USD Amount" + currency + " was not found on Stay Detail Page for CustomerID - " + stayData.CustomerID);
                            }

                        }
                    }
                    else if (currency != "USD")
                    {
                        AddDelay(20000);
                        Logger.WriteDebugMessage("Landed on Stay Overview Page.");
                        VerifyTextOnPage(StayRateAmountProp);
                        Logger.WriteDebugMessage("Found StayRateAmount : " + currency + StayRateAmountProp);
                    }
                    else
                    {
                        Assert.Fail("Currency was not found.");
                    }
                    Logger.WriteInfoMessage("Checking for RFM Monetory.");

                    SqlWarehouseQuery.GetRFMCurrency(stayData, clientNameByTestCase, currency);

                    if (String.IsNullOrEmpty(stayData.Monetory))
                    {
                        stayData.Monetory = "0.00";
                    }

                    ScrollToElement(PageObject_Profile.Profile_Client());

                    if (VerifyTextOnPage(stayData.Monetory))
                    {
                        Logger.WriteDebugMessage("Found amount monetory + " + stayData.Monetory + "for CustomerID - " + stayData.CustomerID);
                    }
                    else
                    {
                        Assert.Fail("RFM Lifetime Spend did not matched for CustomerID - " + stayData.CustomerID);
                    }
                }
            }
        }
        public static void TC_171634()
        {
            UserStayData stayData = new UserStayData();
                       
            SqlWarehouseQuery.GetCurrencyDetails(stayData, companyNameByTestCase, "property");
            Navigation.MenuNavigation("Profile");
            Profile.SelectSubClient(stayData.PropertyName);
            PageLoadWait(120, "Profile.mvc/Profile");
            ElementWait(Driver.FindElement(By.XPath("//input[@id='search']")), 120);
            ElementWait(PageObject_Profile.Profile_SearchGuestsSearch(), 120);
            Profile.SelectSearchGuestsSearchBy("Customer ID");
            Profile.InsertTextSearchGuestsSearchFor(stayData.CustomerID);
            ManageCampaign.WaitForReady();
            Logger.WriteDebugMessage("Searching for an customer for a reservation number : " + stayData.ReservationNumber + " on profile search page.");
            AddDelay(15000);
            Profile.ClickOpenProfile(stayData.CustomerID);
            AddDelay(15000);
            ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, '#profile-div" + stayData.CustomerID + "')]")), 60);

            AddDelay(1500);
            string currencyindb = SqlWarehouseQuery.ReturnCurrencyList(companyNameByTestCase);
            Logger.WriteInfoMessage("Currency List should contain: " + currencyindb);
            currencyXPath = "//select[contains(@name,'RFMCurrency" + stayData.CustomerID + "')]";
            Driver.FindElement(By.XPath(currencyXPath)).Click();

            Logger.WriteDebugMessage("Identified all currency code for " + companyNameByTestCase);
        }
        public static void TC_171636()
        {
            UserStayData stayData = new UserStayData();
            UserPreference prefdata = new UserPreference();
            SqlWarehouseQuery.GetCurrencyDetails(stayData, clientNameByTestCase, "property");

            UserActions.Click_Button_UserrAction();
            Logger.WriteDebugMessage("Clicked on User Actions.");

            UserActions.Click_Button_UserrAction_MyPreference();
            Logger.WriteDebugMessage("Clicked on My Preferences");

            UserActions.SelectCurrency("$ USD");
            Logger.WriteDebugMessage("Region Selected : $ USD");

            UserActions.Click_Button_UserrAction_SavePreference();

            SqlWarehouseQuery.GetUserCurrencyPreference(prefdata, companyNameByTestCase);

            if (String.IsNullOrEmpty(prefdata.CurrencyCode))
            {
                Assert.Fail("Currency preference was not saved.");
            }
            else
            {
                Logger.WriteDebugMessage("Currency Preference was saved as " + prefdata.CurrencyCode + " for company name - " + companyNameByTestCase);
            }
            Logger.WriteInfoMessage("If preference is saved. Logout and Login to check preference is skipped.");


            /*
             * Region TC_171638
             */
            Logger.WriteInfoMessage("Starting TC_171638");
            Navigation.MenuNavigation("Profile");
            Profile.SelectSubClient(stayData.PropertyName);
            PageLoadWait(120, "Profile.mvc/Profile");
            ElementWait(Driver.FindElement(By.XPath("//input[@id='search']")), 120);
            ElementWait(PageObject_Profile.Profile_SearchGuestsSearch(), 120);
            Profile.SelectSearchGuestsSearchBy("Customer ID");
            Profile.InsertTextSearchGuestsSearchFor(stayData.CustomerID);
            Logger.WriteDebugMessage("Searching for an customer for a reservation number : " + stayData.ReservationNumber + " on profile search page.");
            AddDelay(15000);
            Profile.ClickOpenProfile(stayData.CustomerID);
            AddDelay(25000);
            ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, '#profile-div" + stayData.CustomerID + "')]")), 120);

            withID = "profileimage" + stayData.CustomerID;
            AddDelay(20000);
            ScrollToElement(Driver.FindElement(By.Id(withID)));
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '#stays-div" + stayData.CustomerID + "')]")));
            Logger.WriteDebugMessage("Landed on Profile - Stays Tab");
            ElementWait(Driver.FindElement(By.XPath("//*[contains(text(), 'Stay Overview')]")), 120);
            VerifyTextOnPage(stayData.StayRateAmountConvertedUSD);
            Logger.WriteDebugMessage("Found StayRateAmount : " + stayData.StayRateAmountConvertedUSD);

            UserActions.Click_Button_UserrAction();
            Logger.WriteDebugMessage("Clicked on User Actions.");

            UserActions.Click_Button_UserrAction_MyPreference();
            Logger.WriteDebugMessage("Clicked on My Preferences");

            UserActions.SelectCurrency("$ USD");
            Logger.WriteDebugMessage("Region Selected : $ USD");

            UserActions.Click_Button_UserrAction_SavePreference();

            PageLoadWait(120, "Profile.mvc/Profile");

            Logger.WriteDebugMessage("Landed to Profile Page.");

            /*
            SqlWarehouseQuery.GetCurrencyPreferenceSaved(prefdata, CompanyName);
            if (String.IsNullOrEmpty(prefdata.CurrencyCode))
            {
                Assert.Fail("Currency Prefernce was not saved.");
            }
            else
            {
                Logger.WriteDebugMessage("Currecy code saved was " + prefdata.CurrencyCode);
            }
            */
        }
        #endregion[TP_166736]

    }
}
