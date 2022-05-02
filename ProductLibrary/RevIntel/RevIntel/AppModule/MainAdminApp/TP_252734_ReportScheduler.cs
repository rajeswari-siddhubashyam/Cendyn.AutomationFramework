using BaseUtility.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using RevIntel.AppModule.UI;
using RevIntel.PageObject.UI;
using System;
using Navigation = RevIntel.AppModule.UI.Navigation;
using GlobalParam = RevIntel.Utility.GlobalParameter;
using System.Text.RegularExpressions;

namespace RevIntel.AppModule.MainAdminApp
{
    public partial class MainAdminApp : RevIntel.Utility.Setup
    {
        public static void TC_265412()
        {
            if (TestCaseId == Utility.Constants.TC_265412)
            {
                //Pre-Requisite
                string password, userName, client, startDate, endDate, hotelPortfolio;

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                hotelPortfolio = TestData.ExcelData.TestDataReader.ReadData(1, "HotelPortfolio");


                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Enter absolute dates are entered using Calendar or Keyboard for Booking Trend -> Pick up by Day Detailed
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
                ReportScheduler.Click_BookingTrends_PickUpByDayDetailed();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pick up by day detailed page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate());
                ReportScheduler.Enter_PickUpByDayDetailed_StartDate(startDate);
                ReportScheduler.Enter_PickUpByDayDetailed_EndDate(endDate);
                ReportScheduler.Enter_PickUpByDayDetailed_PickupStartDate(startDate);
                ReportScheduler.Enter_PickUpByDayDetailed_PickupEndDate(endDate);
                Logger.WriteDebugMessage("Absolute dates has entered for Pick up by day detailed");
                PageUp();
                PageDown();

                //Checking relative dates are Disabled
                ReportScheduler.Check_RelativeDatesDisabled();

                //Clearing absolute dates and checking relative dates are Enabled
                ReportScheduler.Clear_AbsoluteDates();

                //Enter absolute dates are entered using Calendar or Keyboard for Booking Trend -> channel Pace analysis 
                ExitFrame();
                ExitFrame();
                PageUp();
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");
                EnterFrame_ByName("wndReportScheduler2");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis());
                ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis();
                AddDelay(30000);
                Logger.WriteDebugMessage("Channel Pace analysis page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate());
                ReportScheduler.Enter_PickUpByDayDetailed_StartDate(startDate);
                ReportScheduler.Enter_PickUpByDayDetailed_EndDate(endDate);
                Logger.WriteDebugMessage("Absolute dates has entered for Channel Pace analysis");

                PageUp();
                PageDown();

                //Checking relative dates are Disabled
                string relativeStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate().GetAttribute("class");
                if (relativeStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative start date is disabled for channel Pace analysis");
                else
                    Assert.Fail("Relative start date is enabled for channel Pace analysis");
                AddDelay(7000);
                string relativeEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeEndDate().GetAttribute("class");
                if (relativeEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative end date is disabled for channel Pace analysis");
                else
                    Assert.Fail("Relative end date is enabled for channel Pace analysis");

                //Clearing absolute dates and checking relative dates are Enabled
                ReportScheduler.Enter_PickUpByDayDetailed_StartDate("");
                ReportScheduler.Enter_PickUpByDayDetailed_EndDate("");
                Logger.WriteDebugMessage("Absolute dates has cleared for channel Pace analysis");

                relativeStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate().GetAttribute("class");
                if (relativeStartDate.Contains("Disabled"))
                    Assert.Fail("Relative start date is Disabled for channel Pace analysis");
                else
                    Logger.WriteDebugMessage("Relative start date is enabled for channel Pace analysis");
                Logger.WriteDebugMessage("Relative start date offset is disabled for Pickup by day detailed");
                relativeEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeEndDate().GetAttribute("class");
                if (relativeEndDate.Contains("Disabled"))
                    Assert.Fail("Relative end date is Disabled for channel Pace analysis");
                else
                    Logger.WriteDebugMessage("Relative end date is enabled for channel Pace analysis");
                Logger.WriteDebugMessage("Relative end date offset is disabled for Pickup by day detailed");

                Logger.WriteInfoMessage("Test Case : Verify the Relative dates and its offset gets enabled when absolute dates are cleared");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel Portfolio", hotelPortfolio, true);
            }
        }

        public static void TC_265413()
        {
            if (TestCaseId == Utility.Constants.TC_265413)
            {
                //Pre-Requisite
                string password, userName, client;

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");

                Logger.WriteInfoMessage("Test Case : Verify the absolute dates gets enabled when relative dates are cleared");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Relative dates are entered using Calendar or Keyboard for Booking Trend -> Pick up by Day Detailed
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
                ReportScheduler.Click_BookingTrends_PickUpByDayDetailed();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pick up by day detailed page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
                ReportScheduler.Select_CurrentDate_RelativeStartDate();
                ReportScheduler.Select_CurrentDate_RelativeEndDate();
                ReportScheduler.Select_CurrentDate_RelativePickupStartDate();
                ReportScheduler.Select_CurrentDate_RelativePickupEndDate();
                Logger.WriteDebugMessage("Relative dates has entered for Pick up by day detailed");
                PageUp();
                PageDown();

                //Checking absolute dates are Disabled
                string absoluteStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate().GetAttribute("class");
                if (absoluteStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute start date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Relative start date is enabled for Pickup by day detailed");
                string absoluteEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_EndDate().GetAttribute("class");
                if (absoluteEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute end date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Relative end date is enabled for Pickup by day detailed");
                string absolutePickupStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupStartDate().GetAttribute("class");
                if (absolutePickupStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute pickup start date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Relative pickup start date is enabled for Pickup by day detailed");
                Helper.AddDelay(15000);
                string absolutePickupEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupEndDate().GetAttribute("class");
                if (absolutePickupEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute pickup end date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Absolute pickup end is enabled for Pickup by day detailed");

                //Clearing relative dates and checking absolute dates are Enabled
                ReportScheduler.Select_SelectDate_RelativeStartDate();
                ReportScheduler.Select_SelectDate_RelativeEndDate();
                ReportScheduler.Select_SelectDate_RelativePickupStartDate();
                ReportScheduler.Select_SelectDate_RelativePickupEndDate();
                Logger.WriteDebugMessage("Absolute dates has cleared for Pickup by day detailed");

                absoluteStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate().GetAttribute("class");
                if (absoluteStartDate.Contains("Disabled"))
                    Assert.Fail("Absolute start date is Disabled for Pickup by day detailed");
                else
                    Logger.WriteDebugMessage("Absolute start date is enabled for Pickup by day detailed");
                absoluteEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_EndDate().GetAttribute("class");
                if (absoluteEndDate.Contains("Disabled"))
                    Assert.Fail("Absolute end date is Disabled for Pickup by day detailed");
                else
                    Logger.WriteDebugMessage("Absolute end date is enabled for Pickup by day detailed");
                absolutePickupStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupStartDate().GetAttribute("class");
                if (absolutePickupStartDate.Contains("Disabled"))
                    Assert.Fail("Absolute pickup start date is Disabled for Pickup by day detailed");
                else
                    Logger.WriteDebugMessage("Absolute pickup start date is enabled for Pickup by day detailed");
                Helper.AddDelay(15000);
                absolutePickupEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupEndDate().GetAttribute("class");
                if (absolutePickupEndDate.Contains("Disabled"))
                    Assert.Fail("Absolute pickup end is Disabled for Pickup by day detailed");
                else
                    Logger.WriteDebugMessage("Absolute pickup end date is enabled for Pickup by day detailed");

                //Relative dates are entered using Calendar or Keyboard for Booking Trend -> channel Pace analysis 
                ExitFrame();
                ExitFrame();
                PageUp();
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");
                EnterFrame_ByName("wndReportScheduler2");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis());
                ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis();
                AddDelay(30000);
                Logger.WriteDebugMessage("Channel Pace analysis page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
                ReportScheduler.Select_CurrentDate_RelativeStartDate();
                ReportScheduler.Select_CurrentDate_RelativeEndDate();
                Logger.WriteDebugMessage("Relative dates has entered for Channel Pace analysis");

                PageUp();
                PageDown();

                //Checking absolute dates are Disabled
                absoluteStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate().GetAttribute("class");
                if (absoluteStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute start date is disabled for channel Pace analysis");
                else
                    Assert.Fail("Absolute start date is enabled for channel Pace analysis");
                absoluteEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_EndDate().GetAttribute("class");
                if (absoluteEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute end date is disabled for channel Pace analysis");
                else
                    Assert.Fail("Absolute end date is enabled for channel Pace analysis");

                //Clearing relative dates and checking absolute dates are Enabled
                ReportScheduler.Select_SelectDate_RelativeStartDate();
                ReportScheduler.Select_SelectDate_RelativeEndDate();
                Logger.WriteDebugMessage("Relative dates has cleared for channel Pace analysis");

                absoluteStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate().GetAttribute("class");
                if (absoluteStartDate.Contains("Disabled"))
                    Assert.Fail("Relative start date is Disabled for channel Pace analysis");
                else
                    Logger.WriteDebugMessage("Relative start date is enabled for channel Pace analysis");
                absoluteEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_EndDate().GetAttribute("class");
                if (absoluteEndDate.Contains("Disabled"))
                    Assert.Fail("Relative end date is Disabled for channel Pace analysis");
                else
                    Logger.WriteDebugMessage("Relative end date is enabled for channel Pace analysis");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }

        public static void TC_265416()
        {
            if (TestCaseId == Utility.Constants.TC_265416)
            {
                //Pre-Requisite
                string password, userName, client;

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");

                Logger.WriteInfoMessage("Test Case : Verify user should be able to edit the report report in manage schedule");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Select the report Business Source  ->Room Type Analysis and Enter parameter for Daily schedule 
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BusinessSource();
                Logger.WriteDebugMessage("Business Source link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BusinessSource_RoomTypeAnalysis());
                ReportScheduler.Click_BusinessSource_RoomTypeAnalysis();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pick up by day detailed page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
                ReportScheduler.Select_CurrentDate_RelativeStartDate();
                ReportScheduler.Select_CurrentDate_RelativeEndDate();
                //ReportScheduler.Select_CurrentDate_RelativePickupStartDate();
                //ReportScheduler.Select_CurrentDate_RelativePickupEndDate();
                //Logger.WriteDebugMessage("Absolute dates has entered for Pick up by day detailed");
                PageUp();
                PageDown();
                string absoluteStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate().GetAttribute("class");
                if (absoluteStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative start date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Relative start date is enabled for Pickup by day detailed");
                string absoluteEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_EndDate().GetAttribute("class");
                if (absoluteEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative end date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Relative end date is enabled for Pickup by day detailed");
                //string absolutePickupStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupStartDate().GetAttribute("class");
                //if (absolutePickupStartDate.Contains("Disabled"))
                //    Logger.WriteDebugMessage("Relative pickup start date is disabled for Pickup by day detailed");
                //else
                //    Assert.Fail("Relative pickup start date is enabled for Pickup by day detailed");
                //Helper.AddDelay(15000);
                //string absolutePickupEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupEndDate().GetAttribute("class");
                //if (absolutePickupEndDate.Contains("Disabled"))
                //    Logger.WriteDebugMessage("Relative pickup end date is disabled for Pickup by day detailed");
                //else
                //    Assert.Fail("Relative pickup end is enabled for Pickup by day detailed");

                //Clear absolute dates
                ReportScheduler.Select_SelectDate_RelativeStartDate();
                ReportScheduler.Select_SelectDate_RelativeEndDate();
                //ReportScheduler.Select_SelectDate_RelativePickupStartDate();
                //ReportScheduler.Select_SelectDate_RelativePickupEndDate();
                Logger.WriteDebugMessage("Absolute dates has cleared for Pickup by day detailed");

                absoluteStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate().GetAttribute("class");
                if (absoluteStartDate.Contains("Disabled"))
                    Assert.Fail("Relative start date is Disabled for Pickup by day detailed");
                else
                    Logger.WriteDebugMessage("Relative start date is enabled for Pickup by day detailed");
                absoluteEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_EndDate().GetAttribute("class");
                if (absoluteEndDate.Contains("Disabled"))
                    Assert.Fail("Relative end date is Disabled for Pickup by day detailed");
                else
                    Logger.WriteDebugMessage("Relative end date is enabled for Pickup by day detailed");
                //absolutePickupStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupStartDate().GetAttribute("class");
                //if (absolutePickupStartDate.Contains("Disabled"))
                //    Assert.Fail("Relative pickup start date is Disabled for Pickup by day detailed");
                //else
                //    Logger.WriteDebugMessage("Relative pickup start date is enabled for Pickup by day detailed");
                //Helper.AddDelay(15000);
                //absolutePickupEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupEndDate().GetAttribute("class");
                //if (absolutePickupEndDate.Contains("Disabled"))
                //    Assert.Fail("Relative pickup end is Disabled for Pickup by day detailed");
                //else
                //    Logger.WriteDebugMessage("Relative pickup end date is enabled for Pickup by day detailed");

                //Relative dates are entered using Calendar or Keyboard for Booking Trend -> channel Pace analysis 
                ExitFrame();
                ExitFrame();
                PageUp();
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");
                EnterFrame_ByName("wndReportScheduler2");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis());
                ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis();
                AddDelay(30000);
                Logger.WriteDebugMessage("Channel Pace analysis page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
                ReportScheduler.Select_CurrentDate_RelativeStartDate();
                ReportScheduler.Select_CurrentDate_RelativeEndDate();
                Logger.WriteDebugMessage("Absolute dates has entered for Channel Pace analysis");

                PageUp();
                PageDown();
                absoluteStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate().GetAttribute("class");
                if (absoluteStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative start date is disabled for channel Pace analysis");
                else
                    Assert.Fail("Relative start date is enabled for channel Pace analysis");
                absoluteEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_EndDate().GetAttribute("class");
                if (absoluteEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative end date is disabled for channel Pace analysis");
                else
                    Assert.Fail("Relative end date is enabled for channel Pace analysis");

                //Clear absolute dates
                ReportScheduler.Select_SelectDate_RelativeStartDate();
                ReportScheduler.Select_SelectDate_RelativeEndDate();
                Logger.WriteDebugMessage("Absolute dates has cleared for channel Pace analysis");

                absoluteStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate().GetAttribute("class");
                if (absoluteStartDate.Contains("Disabled"))
                    Assert.Fail("Relative start date is Disabled for channel Pace analysis");
                else
                    Logger.WriteDebugMessage("Relative start date is enabled for channel Pace analysis");
                absoluteEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_EndDate().GetAttribute("class");
                if (absoluteEndDate.Contains("Disabled"))
                    Assert.Fail("Relative end date is Disabled for channel Pace analysis");
                else
                    Logger.WriteDebugMessage("Relative end date is enabled for channel Pace analysis");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }
        public static void TC_265417()
        {
            if (TestCaseId == Utility.Constants.TC_265417)
            {
                //Pre-Requisite
                string password, userName, client;

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");

                Logger.WriteInfoMessage("Test Case : Verify user should be able to edit the report report in manage schedule");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Relative dates are entered using Calendar or Keyboard for Booking Trend -> Pick up by Day Detailed
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
                ReportScheduler.Click_BookingTrends_PickUpByDayDetailed();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pick up by day detailed page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
                ReportScheduler.Select_CurrentDate_RelativeStartDate();
                ReportScheduler.Select_CurrentDate_RelativeEndDate();
                ReportScheduler.Select_CurrentDate_RelativePickupStartDate();
                ReportScheduler.Select_CurrentDate_RelativePickupEndDate();
                Logger.WriteDebugMessage("Absolute dates has entered for Pick up by day detailed");
                PageUp();
                PageDown();
                string absoluteStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate().GetAttribute("class");
                if (absoluteStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative start date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Relative start date is enabled for Pickup by day detailed");
                string absoluteEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_EndDate().GetAttribute("class");
                if (absoluteEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative end date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Relative end date is enabled for Pickup by day detailed");
                string absolutePickupStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupStartDate().GetAttribute("class");
                if (absolutePickupStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative pickup start date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Relative pickup start date is enabled for Pickup by day detailed");
                Helper.AddDelay(15000);
                string absolutePickupEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupEndDate().GetAttribute("class");
                if (absolutePickupEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative pickup end date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Relative pickup end is enabled for Pickup by day detailed");

                //Clear absolute dates
                ReportScheduler.Select_SelectDate_RelativeStartDate();
                ReportScheduler.Select_SelectDate_RelativeEndDate();
                ReportScheduler.Select_SelectDate_RelativePickupStartDate();
                ReportScheduler.Select_SelectDate_RelativePickupEndDate();
                Logger.WriteDebugMessage("Absolute dates has cleared for Pickup by day detailed");

                absoluteStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate().GetAttribute("class");
                if (absoluteStartDate.Contains("Disabled"))
                    Assert.Fail("Relative start date is Disabled for Pickup by day detailed");
                else
                    Logger.WriteDebugMessage("Relative start date is enabled for Pickup by day detailed");
                absoluteEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_EndDate().GetAttribute("class");
                if (absoluteEndDate.Contains("Disabled"))
                    Assert.Fail("Relative end date is Disabled for Pickup by day detailed");
                else
                    Logger.WriteDebugMessage("Relative end date is enabled for Pickup by day detailed");
                absolutePickupStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupStartDate().GetAttribute("class");
                if (absolutePickupStartDate.Contains("Disabled"))
                    Assert.Fail("Relative pickup start date is Disabled for Pickup by day detailed");
                else
                    Logger.WriteDebugMessage("Relative pickup start date is enabled for Pickup by day detailed");
                Helper.AddDelay(15000);
                absolutePickupEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupEndDate().GetAttribute("class");
                if (absolutePickupEndDate.Contains("Disabled"))
                    Assert.Fail("Relative pickup end is Disabled for Pickup by day detailed");
                else
                    Logger.WriteDebugMessage("Relative pickup end date is enabled for Pickup by day detailed");

                //Relative dates are entered using Calendar or Keyboard for Booking Trend -> channel Pace analysis 
                ExitFrame();
                ExitFrame();
                PageUp();
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");
                EnterFrame_ByName("wndReportScheduler2");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis());
                ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis();
                AddDelay(30000);
                Logger.WriteDebugMessage("Channel Pace analysis page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
                ReportScheduler.Select_CurrentDate_RelativeStartDate();
                ReportScheduler.Select_CurrentDate_RelativeEndDate();
                Logger.WriteDebugMessage("Absolute dates has entered for Channel Pace analysis");

                PageUp();
                PageDown();
                absoluteStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate().GetAttribute("class");
                if (absoluteStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative start date is disabled for channel Pace analysis");
                else
                    Assert.Fail("Relative start date is enabled for channel Pace analysis");
                absoluteEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_EndDate().GetAttribute("class");
                if (absoluteEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative end date is disabled for channel Pace analysis");
                else
                    Assert.Fail("Relative end date is enabled for channel Pace analysis");

                //Clear absolute dates
                ReportScheduler.Select_SelectDate_RelativeStartDate();
                ReportScheduler.Select_SelectDate_RelativeEndDate();
                Logger.WriteDebugMessage("Absolute dates has cleared for channel Pace analysis");

                absoluteStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate().GetAttribute("class");
                if (absoluteStartDate.Contains("Disabled"))
                    Assert.Fail("Relative start date is Disabled for channel Pace analysis");
                else
                    Logger.WriteDebugMessage("Relative start date is enabled for channel Pace analysis");
                absoluteEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_EndDate().GetAttribute("class");
                if (absoluteEndDate.Contains("Disabled"))
                    Assert.Fail("Relative end date is Disabled for channel Pace analysis");
                else
                    Logger.WriteDebugMessage("Relative end date is enabled for channel Pace analysis");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }

        public static void TC_265421()
        {
            if (TestCaseId == Utility.Constants.TC_265421)
            {
                //Pre-Requisite
                string password, userName, client, description, startHours, startMinutes, emailTo, emailSubject, startDate, endDate, staticAsOfDate, relativeAsOfDate,
                    static_ValidationMessage, relative_ValidationMessage;
                Random ranNo = new Random();

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                description = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Description"), ranNo.Next().ToString().Substring(0, 2));
                startHours = TestData.ExcelData.TestDataReader.ReadData(1, "StartHours");
                startMinutes = TestData.ExcelData.TestDataReader.ReadData(1, "StartMinutes");
                emailTo = TestData.ExcelData.TestDataReader.ReadData(1, "EmailTo");
                emailSubject = TestData.ExcelData.TestDataReader.ReadData(1, "EmailSubject");
                static_ValidationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "Static_ValidationMessage");
                relative_ValidationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "Relative_ValidationMessage");
                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                staticAsOfDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                relativeAsOfDate = DateTime.Now.AddDays(2).ToString("dd");

                Logger.WriteInfoMessage("Test Case : Verify When setting the Static or Relative As of Date > Today's date, an error message should populate when saving a report");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");


                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
                ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis();
                AddDelay(30000);
                Logger.WriteDebugMessage("Channel Pace Analysis page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");

                //Enter all required parameter for reports 
                ReportScheduler.Enter_ReportDescription(description);
                ReportScheduler.Enter_StartTimeHours(startHours);
                ReportScheduler.Enter_StartTimeMinutes("0");
                //ReportScheduler.Enter_RendorFormat();
                //ReportScheduler.Click_ReportType_Excel();
                ReportScheduler.Enter_StartTimeMinutes("45");
                Logger.WriteDebugMessage("Details are entered like description,Time,Report Type");
                ReportScheduler.Enter_EmailTo(emailTo);
                ReportScheduler.Enter_EmailSubject(emailSubject);
                Logger.WriteDebugMessage("Email and Subject entered");
                Helper.ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
                ReportScheduler.Enter_PickUpByDayDetailed_StartDate(startDate);
                ReportScheduler.Enter_PickUpByDayDetailed_EndDate(endDate);
                Logger.WriteDebugMessage("Absolute dates are entered");

                //Set the Static  As of Date > Today's date and click on Save
                ReportScheduler.Enter_AsOfDate(staticAsOfDate);
                Logger.WriteDebugMessage("Static as of date entered");
                ReportScheduler.Click_RoomTypeAnalysis_SaveButton();
                AddDelay(70000);
                //ElementWait(PageObject_ReportScheduler.Click_SaveSchedule_OkButton(),900);
                VerifyTextOnPageAndHighLight(static_ValidationMessage);
                Logger.WriteDebugMessage(static_ValidationMessage + " = Validation messaged displayed");
                ReportScheduler.Click_SaveSchedule_OkButton();

                //Set the relative   As of Date > Today's date and click on Save
                ReportScheduler.Enter_AsOfDate("");
                ReportScheduler.Select_RelativeAsOfDate_CurrentMonth();
                ReportScheduler.Click_RelativeAsOfDate_Offset(relativeAsOfDate);
                Logger.WriteDebugMessage("Relative as of date entered");
                ReportScheduler.Click_RoomTypeAnalysis_SaveButton();
                AddDelay(70000);
                //ElementWait(PageObject_ReportScheduler.Click_SaveSchedule_OkButton(), 900);
                VerifyTextOnPageAndHighLight(relative_ValidationMessage);
                Logger.WriteDebugMessage(relative_ValidationMessage + " = Validation messaged displayed");


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Hours", startHours);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Minutes", startMinutes);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email To", emailTo);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email Subject", emailSubject);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Static Validation Message", static_ValidationMessage);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Relative Validation Message", relative_ValidationMessage, true);
            }
        }
        public static void TC_265422()
        {
            if (TestCaseId == Utility.Constants.TC_265422)
            {
                //Pre-Requisite
                string password, userName, client, description, startHours, startMinutes, emailTo, emailSubject, startDate, endDate, relativeStartDate, relativeEndDate,
                    static_ValidationMessage, relative_ValidationMessage;
                Random ranNo = new Random();

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                description = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Description"), ranNo.Next().ToString().Substring(0, 2));
                startHours = TestData.ExcelData.TestDataReader.ReadData(1, "StartHours");
                startMinutes = TestData.ExcelData.TestDataReader.ReadData(1, "StartMinutes");
                emailTo = TestData.ExcelData.TestDataReader.ReadData(1, "EmailTo");
                emailSubject = TestData.ExcelData.TestDataReader.ReadData(1, "EmailSubject");
                static_ValidationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "Static_ValidationMessage");
                relative_ValidationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "Relative_ValidationMessage");
                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy");
                relativeStartDate = DateTime.Now.AddDays(1).ToString("dd");
                relativeEndDate = DateTime.Now.AddDays(-1).ToString("dd");

                Logger.WriteInfoMessage("Test Case : Verify When setting the Static or Relative As of Date > Today's date, an error message should populate when saving a report");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");


                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
                ReportScheduler.Click_BookingTrends_PickUpByDayDetailed();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pickup by day detailted page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");

                //Enter all required parameter for reports 
                ReportScheduler.Enter_ReportDescription(description);
                ReportScheduler.Enter_StartTimeHours(startHours);
                ReportScheduler.Enter_StartTimeMinutes("11");
                //ReportScheduler.Enter_RendorFormat();
                //ReportScheduler.Click_ReportType_Excel();
                ReportScheduler.Enter_StartTimeMinutes("45");
                Logger.WriteDebugMessage("Details are entered like description,Time,Report Type");
                ReportScheduler.Enter_EmailTo(emailTo);
                ReportScheduler.Enter_EmailSubject(emailSubject);
                Logger.WriteDebugMessage("Email and Subject entered");
                Helper.ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());


                //Set the Static  End Date < Start date and click on Save 
                ReportScheduler.Enter_PickUpByDayDetailed_StartDate(startDate);
                ReportScheduler.Enter_PickUpByDayDetailed_EndDate(endDate);
                Logger.WriteDebugMessage("Static dates are entered");
                VerifyTextOnPageAndHighLight(static_ValidationMessage);
                Logger.WriteDebugMessage(static_ValidationMessage + " = Validation messaged displayed");

                ReportScheduler.Enter_PickUpByDayDetailed_PickupStartDate(startDate);
                ReportScheduler.Enter_PickUpByDayDetailed_PickupEndDate(endDate);
                Logger.WriteDebugMessage("Static dates are entered");
                VerifyTextOnPageAndHighLight(static_ValidationMessage);
                Logger.WriteDebugMessage(static_ValidationMessage + " = Validation messaged displayed");

                //Set the relative   End Date < Start date and click on Save 
                ReportScheduler.Enter_PickUpByDayDetailed_StartDate("");
                ReportScheduler.Enter_PickUpByDayDetailed_EndDate("");
                ReportScheduler.Enter_PickUpByDayDetailed_PickupStartDate("");
                ReportScheduler.Enter_PickUpByDayDetailed_PickupEndDate("");
                ReportScheduler.Select_CurrentDate_RelativeStartDate();
                ReportScheduler.Enter_RelativeStartDateOffset(relativeStartDate);
                ReportScheduler.Select_CurrentDate_RelativeEndDate();
                ReportScheduler.Enter_RelativeEndDateOffset(relativeEndDate);
                ReportScheduler.Select_CurrentDate_RelativePickupStartDate();
                ReportScheduler.Enter_RelativePickUpStartDateOffset(relativeStartDate);
                ReportScheduler.Select_CurrentDate_RelativePickupEndDate();
                ReportScheduler.Enter_RelativePickUpEndDateOffset(relativeEndDate);
                Logger.WriteDebugMessage("Relative date entered");
                ReportScheduler.Click_RoomTypeAnalysis_SaveButton();
                AddDelay(70000);
                VerifyTextOnPageAndHighLight(relative_ValidationMessage);
                Logger.WriteDebugMessage(relative_ValidationMessage + " = Validation messaged displayed");


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Hours", startHours);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Minutes", startMinutes);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email To", emailTo);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email Subject", emailSubject);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Static Validation Message", static_ValidationMessage);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Relative Validation Message", relative_ValidationMessage, true);
            }
        }
        public static void TC_265418()
        {
            if (TestCaseId == Utility.Constants.TC_265418)
            {
                //Pre-Requisite
                string password, userName, client, description, startHours, startMinutes, emailTo, emailSubject, startDate, endDate;
                Random ranNo = new Random();



                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                description = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Description"), ranNo.Next().ToString().Substring(0, 2));
                startHours = TestData.ExcelData.TestDataReader.ReadData(1, "StartHours");
                startMinutes = TestData.ExcelData.TestDataReader.ReadData(1, "StartMinutes");
                emailTo = TestData.ExcelData.TestDataReader.ReadData(1, "EmailTo");
                emailSubject = TestData.ExcelData.TestDataReader.ReadData(1, "EmailSubject");
                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");



                Logger.WriteInfoMessage("Test Case : Verify user should be able to delete the report in manage schedule");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Select the report Business Source  ->Room Type Analysis and Enter parameter for Daily schedule 
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PaceReport());
                ReportScheduler.Click_BookingTrends_PaceReport();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pace Report page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ReportScheduler.AddSchedule(description, startHours, startMinutes, emailTo, emailSubject, startDate, endDate);
                ExitFrame();
                ExitFrame();

                //Verify the detail entered reflected in Manage Schedule
                Navigation.Click_UserMenu_ManageReportSchedules();
                Logger.WriteDebugMessage("Manage Report Scheduler clicked");
                EnterFrame_ByName("wndManageScheduler");
                ElementWait(PageObject_ReportScheduler.Click_ManageReportSchedule_DeleteButton(), 500);
                ReportScheduler.Click_ManageReportSchedule_DeleteButton();
                Logger.WriteDebugMessage("Delete pop up displayed");
                AddDelay(3000);

                //Actions builder = new Actions(Driver);
                //builder.SendKeys(Keys.Enter);

                ExitFrame();
                //Driver.SwitchTo().Alert().Accept();

                IAlert alert = Driver.SwitchTo().Alert();
                alert.Accept();

                //Update the Schedule and report parameters and click on Save 
                //ExitFrame();
                //Helper.AddDelay(30000);
                //EnterFrame_ByName("ReportDeliveryDialog");
                //ReportScheduler.Enter_ReportDescription(description + "_Edit");
                //Logger.WriteDebugMessage("Description edited");
                //ReportScheduler.Click_RoomTypeAnalysis_SaveButton();
                //Helper.AddDelay(60000);
                //Logger.WriteDebugMessage("Saved successfully");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Hours", startHours);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Minutes", startMinutes);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email To", emailTo);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email Subject", emailSubject, true);
            }
        }
        public static void TC_265361()
        {
            if (TestCaseId == Utility.Constants.TC_265361)
            {
                //Pre-Requisite
                string password, userName, client, description, startHours, startMinutes, emailTo, emailSubject, startDate, endDate, hotelPortfolio;
                Random ranNo = new Random();

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                description = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Description"), ranNo.Next().ToString().Substring(0, 2));
                startHours = TestData.ExcelData.TestDataReader.ReadData(1, "StartHours");
                startMinutes = TestData.ExcelData.TestDataReader.ReadData(1, "StartMinutes");
                emailTo = TestData.ExcelData.TestDataReader.ReadData(1, "EmailTo");
                emailSubject = TestData.ExcelData.TestDataReader.ReadData(1, "EmailSubject");
                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                hotelPortfolio = TestData.ExcelData.TestDataReader.ReadData(1, "HotelPortfolio");

                Logger.WriteInfoMessage("Test Case : Verify Pace Report gets generated when scheduled Daily with out stop schedule date");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Select the report Booking Trend  ->Pace Report and Enter parameter for Daily schedule 
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PaceReport());
                ReportScheduler.Click_BookingTrends_PaceReport();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pace Report page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ReportScheduler.AddSchedule(description, startHours, startMinutes, emailTo, emailSubject, startDate, endDate);
                ExitFrame();
                ExitFrame();

                //Verify the detail entered reflected in Manage Schedule
                Navigation.Click_UserMenu_ManageReportSchedules();
                Logger.WriteDebugMessage("Manage Report Scheduler clicked");
                EnterFrame_ByName("wndManageScheduler");

                //Helper.Driver.FindElements(By.XPath("//*[contains(text(),'" + description + "')]"));
                Helper.HighlightElement(Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + description + "')]")));
                Logger.WriteDebugMessage("Report available in Manage Report Schedules");
                ExitFrame();

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_RainMaker();
                Navigation.Click_SubscriptionSupport();
                Logger.WriteDebugMessage("Subscription Centre");
                //Navigation.Click_Hamburger_Icon();

                EnterFrame_ByName("Subscription Support");
                Helper.HighlightElement(Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + description + "')]")));
                Logger.WriteDebugMessage("Report available in Subscription Center");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Hours", startHours);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Minutes", startMinutes);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email To", emailTo);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email Subject", emailSubject);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel Portfolio", hotelPortfolio, true);
            }
        }
        public static void TC_265367()
        {
            if (TestCaseId == Utility.Constants.TC_265367)
            {
                //Pre-Requisite
                string password, userName, client, description, startHours, startMinutes, emailTo, emailSubject, startDate, endDate, hotelPortfolio;
                Random ranNo = new Random();

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                description = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Description"), ranNo.Next().ToString().Substring(0, 2));
                startHours = TestData.ExcelData.TestDataReader.ReadData(1, "StartHours");
                startMinutes = TestData.ExcelData.TestDataReader.ReadData(1, "StartMinutes");
                emailTo = TestData.ExcelData.TestDataReader.ReadData(1, "EmailTo");
                emailSubject = TestData.ExcelData.TestDataReader.ReadData(1, "EmailSubject");
                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                hotelPortfolio = TestData.ExcelData.TestDataReader.ReadData(1, "HotelPortfolio");

                Logger.WriteInfoMessage("Test Case : Verify Rate Code Pace report generated when scheduled Monthly");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Select the report Booking Trend  ->Pace Report and Enter parameter for Daily schedule 
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PaceReport());
                ReportScheduler.Click_BookingTrends_PaceReport();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pace Report page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ReportScheduler.AddScheduleMonth(description, startHours, startMinutes, emailTo, emailSubject, startDate, endDate);
                ExitFrame();
                ExitFrame();

                //Verify the detail entered reflected in Manage Schedule
                Navigation.Click_UserMenu_ManageReportSchedules();
                Logger.WriteDebugMessage("Manage Report Scheduler clicked");
                EnterFrame_ByName("wndManageScheduler");

                //Helper.Driver.FindElements(By.XPath("//*[contains(text(),'" + description + "')]"));
                Helper.HighlightElement(Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + description + "')]")));
                Logger.WriteDebugMessage("Report available in Manage Report Schedules");
                ExitFrame();

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_RainMaker();
                Navigation.Click_SubscriptionSupport();
                Logger.WriteDebugMessage("Subscription Centre");
                //Navigation.Click_Hamburger_Icon();

                EnterFrame_ByName("Subscription Support");
                Helper.HighlightElement(Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + description + "')]")));
                Logger.WriteDebugMessage("Report available in Subscription Center");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Hours", startHours);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Minutes", startMinutes);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email Subject", emailSubject);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel Portfolio", hotelPortfolio, true);
            }
        }
        public static void TC_265368()
        {
            if (TestCaseId == Utility.Constants.TC_265368)
            {
                //Pre-Requisite
                string password, userName, client, description, startHours, startMinutes, emailTo, emailSubject, startDate, endDate, hotelPortfolio;
                Random ranNo = new Random();

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                description = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Description"), ranNo.Next().ToString().Substring(0, 2));
                startHours = TestData.ExcelData.TestDataReader.ReadData(1, "StartHours");
                startMinutes = TestData.ExcelData.TestDataReader.ReadData(1, "StartMinutes");
                emailTo = TestData.ExcelData.TestDataReader.ReadData(1, "EmailTo");
                emailSubject = TestData.ExcelData.TestDataReader.ReadData(1, "EmailSubject");
                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                hotelPortfolio = TestData.ExcelData.TestDataReader.ReadData(1, "HotelPortfolio");

                Logger.WriteInfoMessage("Test Case : Verify Monthly Pickup generated when scheduled Once");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Select the report Booking Trend  ->Pace Report and Enter parameter for Daily schedule 
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PaceReport());
                ReportScheduler.Click_BookingTrends_PaceReport();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pace Report page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ReportScheduler.AddScheduleOnce(description, startHours, startMinutes, emailTo, emailSubject, startDate, endDate);
                ExitFrame();
                ExitFrame();

                //Verify the detail entered reflected in Manage Schedule
                Navigation.Click_UserMenu_ManageReportSchedules();
                Logger.WriteDebugMessage("Manage Report Scheduler clicked");
                EnterFrame_ByName("wndManageScheduler");

                //Helper.Driver.FindElements(By.XPath("//*[contains(text(),'" + description + "')]"));
                Helper.HighlightElement(Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + description + "')]")));
                Logger.WriteDebugMessage("Report available in Manage Report Schedules");
                ExitFrame();

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_RainMaker();
                Navigation.Click_SubscriptionSupport();
                Logger.WriteDebugMessage("Subscription Centre");
                //Navigation.Click_Hamburger_Icon();

                EnterFrame_ByName("Subscription Support");
                Helper.HighlightElement(Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + description + "')]")));
                Logger.WriteDebugMessage("Report available in Subscription Center");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Hours", startHours);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Minutes", startMinutes);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email To", emailTo);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email Subject", emailSubject);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel Portfolio", hotelPortfolio, true);
            }
        }
        public static void TC_265380()
        {
            if (TestCaseId == Utility.Constants.TC_265380)
            {
                //Pre-Requisite
                string password, userName, client, description, startHours, startMinutes, emailTo, emailSubject, startDate, endDate, hotelPortfolio, timeZone;
                Random ranNo = new Random();

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                description = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Description"), ranNo.Next().ToString().Substring(0, 2));
                startHours = TestData.ExcelData.TestDataReader.ReadData(1, "StartHours");
                startMinutes = TestData.ExcelData.TestDataReader.ReadData(1, "StartMinutes");
                emailTo = TestData.ExcelData.TestDataReader.ReadData(1, "EmailTo");
                emailSubject = TestData.ExcelData.TestDataReader.ReadData(1, "EmailSubject");
                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                hotelPortfolio = TestData.ExcelData.TestDataReader.ReadData(1, "HotelPortfolio");
                timeZone = TestData.ExcelData.TestDataReader.ReadData(1, "TimeZone");

                Logger.WriteInfoMessage("Test Case : Verify Report gets generated when scheduled Daily for timeZone other than EST");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Select the report Booking Trend  ->Pace Report and Enter parameter for Daily schedule 
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PaceReport());
                ReportScheduler.Click_BookingTrends_PaceReport();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pace Report page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ReportScheduler.AddSchedule(description, startHours, startMinutes, emailTo, emailSubject, startDate, endDate);
                ExitFrame();
                ExitFrame();

                //Verify the detail entered reflected in Manage Schedule
                Navigation.Click_UserMenu_ManageReportSchedules();
                Logger.WriteDebugMessage("Manage Report Scheduler clicked");
                EnterFrame_ByName("wndManageScheduler");

                //Helper.Driver.FindElements(By.XPath("//*[contains(text(),'" + description + "')]"));
                Helper.HighlightElement(Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + description + "')]")));
                Logger.WriteDebugMessage("Report available in Manage Report Schedules");
                ExitFrame();

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_RainMaker();
                Navigation.Click_SubscriptionSupport();
                Logger.WriteDebugMessage("Subscription Centre");
                //Navigation.Click_Hamburger_Icon();

                EnterFrame_ByName("Subscription Support");
                Helper.HighlightElement(Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + description + "')]")));
                Logger.WriteDebugMessage("Report available in Subscription Center");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Hours", startHours);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Minutes", startMinutes);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email To", emailTo);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email Subject", emailSubject);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Time Zone", timeZone);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel Portfolio", hotelPortfolio, true);
            }
        }
        public static void TC_265385()
        {
            if (TestCaseId == Utility.Constants.TC_265385)
            {
                //Pre-Requisite
                string password, userName, client, startDate, endDate, hotelPortfolio, staticAsOfDate;

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                staticAsOfDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                hotelPortfolio = TestData.ExcelData.TestDataReader.ReadData(1, "HotelPortfolio");

                Logger.WriteInfoMessage("Test Case : Verify the Relative dates and its offset gets disabled when absolute dates are entered");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Enter absolute dates are entered using Calendar or Keyboard for Booking Trend -> Pick up by Day Detailed
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
                ReportScheduler.Click_BookingTrends_PickUpByDayDetailed();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pick up by day detailed page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate());
                ReportScheduler.Enter_PickUpByDayDetailed_StartDate(startDate);
                ReportScheduler.Enter_PickUpByDayDetailed_EndDate(endDate);
                ReportScheduler.Enter_PickUpByDayDetailed_PickupStartDate(startDate);
                ReportScheduler.Enter_PickUpByDayDetailed_PickupEndDate(endDate);
                Logger.WriteDebugMessage("Absolute dates has entered for Pick up by day detailed");
                PageUp();
                PageDown();

                //Checking relative dates are Disabled
                ReportScheduler.Check_RelativeDatesDisabled();

                //Enter absolute dates are entered using Calendar or Keyboard for Booking Trend -> channel Pace analysis 
                ExitFrame();
                ExitFrame();
                PageUp();
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");
                EnterFrame_ByName("wndReportScheduler2");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis());
                ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis();
                AddDelay(30000);
                Logger.WriteDebugMessage("Channel Pace analysis page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate());
                ReportScheduler.Enter_PickUpByDayDetailed_StartDate(startDate);
                ReportScheduler.Enter_PickUpByDayDetailed_EndDate(endDate);
                ReportScheduler.Enter_AsOfDate(staticAsOfDate);
                Logger.WriteDebugMessage("Absolute dates has entered for Channel Pace analysis");

                PageUp();
                PageDown();

                //Checking relative dates are Disabled
                string relativeStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate().GetAttribute("class");
                if (relativeStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative start date and offset is disabled for channel Pace analysis");
                else
                    Assert.Fail("Relative start date is enabled for channel Pace analysis");
                string relativeEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeEndDate().GetAttribute("class");
                if (relativeEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative end date and offset is disabled for channel Pace analysis");
                else
                    Assert.Fail("Relative end date is enabled for channel Pace analysis");
                string relativeAsOfDate = PageObject_ReportScheduler.Enter_RelativeAsOfDate().GetAttribute("class");
                if (relativeAsOfDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative As Of date and offset is disabled for channel Pace analysis");
                else
                    Assert.Fail("Relative As Of date is enabled for channel Pace analysis");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel Portfolio", hotelPortfolio, true);
            }
        }
        public static void TC_265386()
        {
            if (TestCaseId == Utility.Constants.TC_265386)
            {
                //Pre-Requisite
                string password, userName, client, hotelPortfolio;

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                hotelPortfolio = TestData.ExcelData.TestDataReader.ReadData(1, "HotelPortfolio");

                Logger.WriteInfoMessage("Test Case : Verify the obsolute dates gets disabled when relative dates are entered");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Relative dates are entered using Calendar or Keyboard for Booking Trend -> Pick up by Day Detailed
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
                ReportScheduler.Click_BookingTrends_PickUpByDayDetailed();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pick up by day detailed page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
                ReportScheduler.Select_CurrentDate_RelativeStartDate();
                ReportScheduler.Select_CurrentDate_RelativeEndDate();
                ReportScheduler.Select_CurrentDate_RelativePickupStartDate();
                ReportScheduler.Select_CurrentDate_RelativePickupEndDate();
                Logger.WriteDebugMessage("Relative dates has entered for Pick up by day detailed");
                PageUp();
                PageDown();

                //Checking absolute dates are Disabled
                string absoluteStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate().GetAttribute("class");
                if (absoluteStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute start date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Relative start date is enabled for Pickup by day detailed");
                string absoluteEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_EndDate().GetAttribute("class");
                if (absoluteEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute end date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Relative end date is enabled for Pickup by day detailed");
                string absolutePickupStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupStartDate().GetAttribute("class");
                if (absolutePickupStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute pickup start date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Relative pickup start date is enabled for Pickup by day detailed");
                Helper.AddDelay(15000);
                string absolutePickupEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupEndDate().GetAttribute("class");
                if (absolutePickupEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute pickup end date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Absolute pickup end is enabled for Pickup by day detailed");


                //Relative dates are entered using Calendar or Keyboard for Booking Trend -> channel Pace analysis 
                ExitFrame();
                ExitFrame();
                PageUp();
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");
                EnterFrame_ByName("wndReportScheduler2");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis());
                ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis();
                AddDelay(30000);
                Logger.WriteDebugMessage("Channel Pace analysis page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
                ReportScheduler.Select_CurrentDate_RelativeStartDate();
                ReportScheduler.Select_CurrentDate_RelativeEndDate();
                ReportScheduler.Click_RelativeAsOfDate();
                ReportScheduler.Click_RelativeAsOfDate_Currentmonth();
                Logger.WriteDebugMessage("Relative dates has entered for Channel Pace analysis");

                PageUp();
                PageDown();

                //Checking absolute dates are Disabled
                absoluteStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate().GetAttribute("class");
                if (absoluteStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute start date is disabled for channel Pace analysis");
                else
                    Assert.Fail("Absolute start date is enabled for channel Pace analysis");
                absoluteEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_EndDate().GetAttribute("class");
                if (absoluteEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute end date is disabled for channel Pace analysis");
                else
                    Assert.Fail("Absolute end date is enabled for channel Pace analysis");
                PageDown();
                string absoluteAsOfDate = PageObject_ReportScheduler.Enter_AsOfDate().GetAttribute("class");
                if (absoluteAsOfDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute As Of date is disabled for channel Pace analysis");
                else
                    Assert.Fail("Absolute As Of date is enabled for channel Pace analysis");


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel Portfolio", hotelPortfolio, true);
            }
        }
        public static void TC_265397()
        {
            if (TestCaseId == Utility.Constants.TC_265397)
            {
                //Pre-Requisite
                string password, userName, client, hotelPortfolio;

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                hotelPortfolio = TestData.ExcelData.TestDataReader.ReadData(1, "HotelPortfolio");

                Logger.WriteInfoMessage("Test Case : erify when Quick dates are selected for Relative dates , absolute date disabled");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Relative dates are entered using Calendar or Keyboard for Booking Trend -> Pick up by Day Detailed
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
                ReportScheduler.Click_BookingTrends_PickUpByDayDetailed();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pick up by day detailed page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
                ReportScheduler.Click_Quick_RelativeDate();
                Logger.WriteDebugMessage("Quick Relative date is clicked");
                ReportScheduler.Click_Quick_RelativeDateToday();
                ReportScheduler.Click_Quick_RelativePickupDate();
                Logger.WriteDebugMessage("Quick Relative pickup date is clicked");
                ReportScheduler.Click_Quick_RelativePickupDateToday();
                Logger.WriteDebugMessage("Relative Quick dates are selected for Pick up by day detailed");
                PageUp();
                PageDown();

                //Checking absolute dates are Disabled
                string absoluteStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate().GetAttribute("class");
                if (absoluteStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute start date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Relative start date is enabled for Pickup by day detailed");
                string absoluteEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_EndDate().GetAttribute("class");
                if (absoluteEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute end date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Relative end date is enabled for Pickup by day detailed");
                string absolutePickupStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupStartDate().GetAttribute("class");
                if (absolutePickupStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute pickup start date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Relative pickup start date is enabled for Pickup by day detailed");
                Helper.AddDelay(15000);
                string absolutePickupEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupEndDate().GetAttribute("class");
                if (absolutePickupEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute pickup end date is disabled for Pickup by day detailed");
                else
                    Assert.Fail("Absolute pickup end is enabled for Pickup by day detailed");


                //Relative dates are entered using Calendar or Keyboard for Booking Trend -> channel Pace analysis 
                ExitFrame();
                ExitFrame();
                PageUp();
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");
                EnterFrame_ByName("wndReportScheduler2");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis());
                ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis();
                AddDelay(30000);
                Logger.WriteDebugMessage("Channel Pace analysis page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
                ReportScheduler.Click_Quick_RelativeDate();
                Logger.WriteDebugMessage("Quick Relative date is clicked");
                ReportScheduler.Click_Quick_RelativeDateToday();
                ReportScheduler.Click_RelativeAsOfDate();
                ReportScheduler.Click_RelativeAsOfDate_Currentmonth();
                Logger.WriteDebugMessage("Relative Quick dates are selected for channel Pace analysis");

                PageUp();
                PageDown();

                //Checking absolute dates are Disabled
                absoluteStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate().GetAttribute("class");
                if (absoluteStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute start date is disabled for channel Pace analysis");
                else
                    Assert.Fail("Absolute start date is enabled for channel Pace analysis");
                absoluteEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_EndDate().GetAttribute("class");
                if (absoluteEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute end date is disabled for channel Pace analysis");
                else
                    Assert.Fail("Absolute end date is enabled for channel Pace analysis");
                string absoluteAsOfDate = PageObject_ReportScheduler.Enter_AsOfDate().GetAttribute("class");
                if (absoluteAsOfDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Absolute As Of date is disabled for channel Pace analysis");
                else
                    Assert.Fail("Absolute As Of date is enabled for channel Pace analysis");


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel Portfolio", hotelPortfolio, true);
            }
        }
        public static void TC_265396()
        {
            if (TestCaseId == Utility.Constants.TC_265396)
            {
                //Pre-Requisite
                string password, userName, client, startDate, endDate, hotelPortfolio, staticAsOfDate;

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                staticAsOfDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                hotelPortfolio = TestData.ExcelData.TestDataReader.ReadData(1, "HotelPortfolio");

                Logger.WriteInfoMessage("Test Case : Verify when Quick dates are selected for absolute date , relative date and offset gets disabled");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Select Quick absolute dates Booking Trend -> Pick up by Day Detailed
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
                ReportScheduler.Click_BookingTrends_PickUpByDayDetailed();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pick up by day detailed page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate());
                ReportScheduler.Click_Quick_AbsoluteDate();
                Logger.WriteDebugMessage("Quick Absolute date is clicked");
                ReportScheduler.Click_Quick_AbsoluteDateToday();
                ReportScheduler.Click_Quick_AbsolutePickupDate();
                Logger.WriteDebugMessage("Quick Absolute Pickup date is clicked");
                ReportScheduler.Click_Quick_AbsolutePickupDateToday();
                Logger.WriteDebugMessage("Quick Absolute dates are selected for Pick up by day detailed");
                PageUp();
                PageDown();

                //Checking relative dates are Disabled
                ReportScheduler.Check_RelativeDatesDisabled();

                //Select Quick Absolute dates for Booking Trend -> channel Pace analysis 
                ExitFrame();
                ExitFrame();
                PageUp();
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");
                EnterFrame_ByName("wndReportScheduler2");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis());
                ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis();
                AddDelay(30000);
                Logger.WriteDebugMessage("Channel Pace analysis page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate());
                ReportScheduler.Click_Quick_AbsoluteDate();
                Logger.WriteDebugMessage("Quick Absolute date is clicked");
                ReportScheduler.Click_Quick_AbsoluteDateToday();
                ReportScheduler.Enter_AsOfDate(staticAsOfDate);
                Logger.WriteDebugMessage("Quick Absolute dates are selected for Channel Pace analysis");

                PageUp();
                PageDown();

                //Checking relative dates are Disabled
                string relativeStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate().GetAttribute("class");
                if (relativeStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative start date and offset is disabled for channel Pace analysis");
                else
                    Assert.Fail("Relative start date is enabled for channel Pace analysis");
                string relativeEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeEndDate().GetAttribute("class");
                if (relativeEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative end date and offset is disabled for channel Pace analysis");
                else
                    Assert.Fail("Relative end date is enabled for channel Pace analysis");
                string relativeAsOfDate = PageObject_ReportScheduler.Enter_RelativeAsOfDate().GetAttribute("class");
                if (relativeAsOfDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative As Of date and offset is disabled for channel Pace analysis");
                else
                    Assert.Fail("Relative As Of date is enabled for channel Pace analysis");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel Portfolio", hotelPortfolio, true);
            }
        }
        public static void TC_282043()
        {
            if (TestCaseId == Utility.Constants.TC_282043)
            {
                //Pre-Requisite
                string password, userName, client, startDate, endDate, hotelPortfolio, staticAsOfDate;

                //Retrieve data from Database or test data file
                
                userName = GlobalParam.Username; //TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = GlobalParam.Password; //TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = GlobalParam.Client; //TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                staticAsOfDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                hotelPortfolio = GlobalParam.Portfolio; //TestData.ExcelData.TestDataReader.ReadData(1, "HotelPortfolio");

                Logger.WriteInfoMessage("Test Case : Verify the value rendered for Relative - Quick dates");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");
                Navigation.Click_UserMenu();

                //Select Quick Relative dates for Booking Trend -> Pick up by Day Detailed
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
                ReportScheduler.Click_BookingTrends_PickUpByDayDetailed();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pick up by day detailed page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());

                string daySelection = "Yesterday,Today,MTD,YTD,Last month,This month,Next month,Last year,This year,Date to end of year";
                string[] selectionsplit = Regex.Split(daySelection, ",");
                foreach (string eachDay in selectionsplit)
                {
                    ReportScheduler.SelectRelativeQuickDaySelection(eachDay);
                    ReportScheduler.SelectRelativePickUpSelection(eachDay);
                    
                }

                /*
                //select quick relative date
                ReportScheduler.Click_Quick_RelativeDate();
                Logger.WriteDebugMessage("Quick Relative date is clicked");
                //select today
                ReportScheduler.Click_Quick_RelativeDateToday();

                //select quick relative date
                ReportScheduler.Click_Quick_RelativeDate();
                Logger.WriteDebugMessage("Quick Relative date is clicked");
                //select yesterday
                ReportScheduler.Click_Quick_RelativeDateYesteraday();

                //select quick relative date
                ReportScheduler.Click_Quick_RelativeDate();
                Logger.WriteDebugMessage("Quick Relative date is clicked");
                //select last month
                ReportScheduler.Click_Quick_RelativeDateLastMonth();

                //select quick relative date
                ReportScheduler.Click_Quick_RelativeDate();
                Logger.WriteDebugMessage("Quick Relative date is clicked");
                //select this month
                ReportScheduler.Click_Quick_RelativeDateThisMonth();

                //select quick relative date
                ReportScheduler.Click_Quick_RelativeDate();
                Logger.WriteDebugMessage("Quick Relative date is clicked");
                //select next month
                ReportScheduler.Click_Quick_RelativeDateNextMonth();

                //select quick relative date
                ReportScheduler.Click_Quick_RelativeDate();
                Logger.WriteDebugMessage("Quick Relative date is clicked");
                //select last year
                ReportScheduler.Click_Quick_RelativeDateLastYear();

                //select quick relative date
                ReportScheduler.Click_Quick_RelativeDate();
                Logger.WriteDebugMessage("Quick Relative date is clicked");
                //select this year
                ReportScheduler.Click_Quick_RelativeDateThisYear();

                ReportScheduler.Click_Quick_RelativePickupDate();
                Logger.WriteDebugMessage("Quick Relative pickup date is clicked");
                ReportScheduler.Click_Quick_RelativePickupDateToday();
                Logger.WriteDebugMessage("Relative Quick dates are selected for Pick up by day detailed");
                PageUp();
                PageDown();





                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel Portfolio", hotelPortfolio, true);
                */
            }
        }
        public static void TC_282049()
        {
            if (TestCaseId == Utility.Constants.TC_282049)
            {
                //Pre-Requisite
                string password, userName, client, startDate, endDate, hotelPortfolio, staticAsOfDate;

                //Retrieve data from Database or test data file
                userName = GlobalParam.Username; //TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = GlobalParam.Password; //TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = GlobalParam.Client; //TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                staticAsOfDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                hotelPortfolio = GlobalParam.Portfolio; //TestData.ExcelData.TestDataReader.ReadData(1, "HotelPortfolio");

                Logger.WriteInfoMessage("Test Case : Verify when Quick dates are selected for absolute date , relative date and offset gets disabled");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");
                Navigation.Click_UserMenu();

                //Select Quick absolute dates Booking Trend -> Pick up by Day Detailed
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
                ReportScheduler.Click_BookingTrends_PickUpByDayDetailed();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pick up by day detailed page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate());

                string daySelection = "Yesterday,Today,MTD,YTD,Last month,This month,Next month,Last year,This year,Date to end of year";
                string[] selectionsplit = Regex.Split(daySelection, ",");
                foreach (string eachDay in selectionsplit)
                {
                    ReportScheduler.SelectAbsoluteQuickDaySelection(eachDay);
                    ReportScheduler.SelectAbsolutePickUpDaySelection(eachDay);
                    ReportScheduler.CompareAbsoluteQuickStartEndDate(eachDay);
                    ReportScheduler.ComparePickUpStartEndDate(eachDay);
                }
            }
        }
        public static void TC_265430()
        {
            if (TestCaseId == Utility.Constants.TC_265430)
            {
                //Pre-Requisite
                string password, userName, client, startDate, endDate, hotelPortfolio, staticAsOfDate;

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                staticAsOfDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                hotelPortfolio = TestData.ExcelData.TestDataReader.ReadData(1, "HotelPortfolio");

                Logger.WriteInfoMessage("Test Case : Verify when Quick dates are selected for absolute date , relative date and offset gets disabled");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Select Quick absolute dates Booking Trend -> Pick up by Day Detailed
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
                ReportScheduler.Click_BookingTrends_PickUpByDayDetailed();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pick up by day detailed page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate());
                ReportScheduler.Click_Quick_AbsoluteDate();
                Logger.WriteDebugMessage("Quick Absolute date is clicked");
                ReportScheduler.Click_Quick_AbsoluteDateToday();
                ReportScheduler.Click_Quick_AbsolutePickupDate();
                Logger.WriteDebugMessage("Quick Absolute Pickup date is clicked");
                ReportScheduler.Click_Quick_AbsolutePickupDateToday();
                Logger.WriteDebugMessage("Quick Absolute dates are selected for Pick up by day detailed");
                PageUp();
                PageDown();

                //Checking relative dates are Disabled
                ReportScheduler.Check_RelativeDatesDisabled();

                //Select Quick Absolute dates for Booking Trend -> channel Pace analysis 
                ExitFrame();
                ExitFrame();
                PageUp();
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");
                EnterFrame_ByName("wndReportScheduler2");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis());
                ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis();
                AddDelay(30000);
                Logger.WriteDebugMessage("Channel Pace analysis page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate());
                ReportScheduler.Click_Quick_AbsoluteDate();
                Logger.WriteDebugMessage("Quick Absolute date is clicked");
                ReportScheduler.Click_Quick_AbsoluteDateToday();
                ReportScheduler.Enter_AsOfDate(staticAsOfDate);
                Logger.WriteDebugMessage("Quick Absolute dates are selected for Channel Pace analysis");

                PageUp();
                PageDown();

                //Checking relative dates are Disabled
                string relativeStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate().GetAttribute("class");
                if (relativeStartDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative start date and offset is disabled for channel Pace analysis");
                else
                    Assert.Fail("Relative start date is enabled for channel Pace analysis");
                string relativeEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeEndDate().GetAttribute("class");
                if (relativeEndDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative end date and offset is disabled for channel Pace analysis");
                else
                    Assert.Fail("Relative end date is enabled for channel Pace analysis");
                string relativeAsOfDate = PageObject_ReportScheduler.Enter_RelativeAsOfDate().GetAttribute("class");
                if (relativeAsOfDate.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative As Of date and offset is disabled for channel Pace analysis");
                else
                    Assert.Fail("Relative As Of date is enabled for channel Pace analysis");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel Portfolio", hotelPortfolio, true);
            }
        }
        public static void TC_265431()
        {
            if (TestCaseId == Utility.Constants.TC_265431)
            {
                //Pre-Requisite
                string password, userName, client, startDate, endDate, hotelPortfolio, staticAsOfDate;

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                hotelPortfolio = TestData.ExcelData.TestDataReader.ReadData(1, "HotelPortfolio");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Booking Trend -> Pick up by Day Detailed
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
                ReportScheduler.Click_BookingTrends_PickUpByDayDetailed();
                AddDelay(30000);
                Logger.WriteDebugMessage("Report Delivery Scheduler loads for Pick up by day detailed");
                ExitFrame();

                //Portfolio -> Agent by hotel
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");
                EnterFrame_ByName("wndReportScheduler2");
                ScrollToElement(PageObject_ReportScheduler.Click_Portfolio());
                ReportScheduler.Click_Portfolio();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ReportScheduler.Click_BookingTrends_AgentByHotel();
                AddDelay(30000);
                Logger.WriteDebugMessage("Report Delivery Scheduler loads for Agent by hotel");
                ExitFrame();

                Logger.WriteInfoMessage("Test Case : Verify Report Delivery Scheduler loads for all available Report types w/o throwing a page error");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel Portfolio", hotelPortfolio, true);
            }
        }
        public static void TC_265427()
        {
            if (TestCaseId == Utility.Constants.TC_265427)
            {
                //Pre-Requisite
                string password, userName, client;

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Portfolio -> Agent by hotel
                EnterFrame_ByName("wndReportScheduler");
                ScrollToElement(PageObject_ReportScheduler.Click_Portfolio());
                ReportScheduler.Click_Portfolio();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ReportScheduler.Click_BookingTrends_AgentByHotel();
                AddDelay(30000);
                Logger.WriteDebugMessage("Agent by hotel page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Click_SelectType());

                string selectType = PageObject_ReportScheduler.Click_SelectType().GetAttribute("disabled");
                if (selectType.Equals("true"))
                    Logger.WriteDebugMessage("Select type is disabled");
                else
                    Assert.Fail("Select type is enabled");

                Logger.WriteInfoMessage("Test Case : Verify Portfolio reports should not have Hotel name selections.");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);

            }
        }
        public static void TC_265426()
        {
            if (TestCaseId == Utility.Constants.TC_265426)
            {
                //Pre-Requisite
                string password, userName, client, description, startHours, startMinutes, emailTo, emailSubject, startDate, endDate, hotelPortfolio, timeZone;
                Random ranNo = new Random();

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                description = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Description"), ranNo.Next().ToString().Substring(0, 2));
                startHours = TestData.ExcelData.TestDataReader.ReadData(1, "StartHours");
                startMinutes = TestData.ExcelData.TestDataReader.ReadData(1, "StartMinutes");
                emailTo = TestData.ExcelData.TestDataReader.ReadData(1, "EmailTo");
                emailSubject = TestData.ExcelData.TestDataReader.ReadData(1, "EmailSubject");
                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                hotelPortfolio = TestData.ExcelData.TestDataReader.ReadData(1, "HotelPortfolio");
                timeZone = TestData.ExcelData.TestDataReader.ReadData(1, "TimeZone");


                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Select the report Booking Trend  ->Pace Report and Enter parameter for Daily schedule 
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PaceReport());
                ReportScheduler.Click_BookingTrends_PaceReport();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pace Report page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ReportScheduler.AddSchedule(description, startHours, startMinutes, emailTo, emailSubject, startDate, endDate);
                ExitFrame();
                ExitFrame();

                //Verify the detail entered reflected in Manage Schedule
                Navigation.Click_UserMenu_ManageReportSchedules();
                Logger.WriteDebugMessage("Manage Report Scheduler clicked");
                EnterFrame_ByName("wndManageScheduler");

                //Helper.Driver.FindElements(By.XPath("//*[contains(text(),'" + description + "')]"));
                Helper.HighlightElement(Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + description + "')]")));
                Logger.WriteDebugMessage("Report available in Manage Report Schedules");
                ExitFrame();

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_RainMaker();
                Navigation.Click_SubscriptionSupport();
                Logger.WriteDebugMessage("Subscription Centre");
                //Navigation.Click_Hamburger_Icon();

                EnterFrame_ByName("Subscription Support");
                Helper.HighlightElement(Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + description + "')]")));
                Logger.WriteDebugMessage("Report available in Subscription Center");

                Logger.WriteInfoMessage("Test Case : Verify Report gets generated when scheduled Daily for timeZone other than EST");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Hours", startHours);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Minutes", startMinutes);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email To", emailTo);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email Subject", emailSubject);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Time Zone", timeZone);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel Portfolio", hotelPortfolio, true);
            }
        }
        public static void TC_265424()
        {
            if (TestCaseId == Utility.Constants.TC_265424)
            {
                //Pre-Requisite
                string password, userName, client;

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to user preferences
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.user_preferences();
                Logger.WriteDebugMessage("Navigated to user prefernces");
                EnterFrame_ByName("wndUserPreference");

                //Get preference
                string hotelValue = PageObject_ReportParameter.UserPreference_GetHotel().GetAttribute("value");
                string businessUnitValue = PageObject_ReportParameter.UserPreference_GetBusinessUnit().GetAttribute("value");
                string getCurrencyValue = PageObject_ReportParameter.UserPreference_GetCurrency().GetAttribute("value");

                ExitFrame();

                //Navigate to Report Scheduler 
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Booking Trend -> Pick up by Day Detailed
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
                ReportScheduler.Click_BookingTrends_PickUpByDayDetailed();
                AddDelay(30000);
                Logger.WriteDebugMessage("Report Delivery Scheduler loads for Pick up by day detailed");
                EnterFrame_ByName("ReportDeliveryDialog");
                //ExitFrame();
                ScrollToElement(PageObject_ReportScheduler.Click_SelectType());
                //Get preference
                string hotelValueReportScheduler = PageObject_ReportScheduler.ReportScheduler_GetHotel().GetAttribute("value");
                string businessUnitValueReportScheduler = PageObject_ReportScheduler.ReportScheduler_GetBusinessUnit().GetAttribute("value");
                string getCurrencyValueReportScheduler = PageObject_ReportScheduler.ReportScheduler_GetCurrency().GetAttribute("value");

                if (hotelValue == hotelValueReportScheduler)
                    Logger.WriteDebugMessage("Hotel matched");
                else
                    Assert.Fail("Hotel NOT matched");

                if (businessUnitValue == businessUnitValueReportScheduler)
                    Logger.WriteDebugMessage("Business unit matched");
                else
                    Assert.Fail("Business unit NOT matched");

                if (getCurrencyValue == getCurrencyValueReportScheduler)
                    Logger.WriteDebugMessage("Currency matched");
                else
                    Assert.Fail("Currency NOT matched");

                Logger.WriteInfoMessage("Test Case : Verify preference set up should reflect as default value in report scheduler");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);

            }
        }
        public static void TC_265415()
        {
            if (TestCaseId == Utility.Constants.TC_265415)
            {
                //Pre-Requisite
                string password, userName, client;

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");

                Logger.WriteInfoMessage("Test Case : Verify the absolute dates gets enabled when relative dates are cleared");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");
                Navigation.Click_UserMenu();

                //Relative dates are entered using Calendar or Keyboard for Booking Trend -> Pick up by Day Detailed
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
                Logger.WriteDebugMessage("Booking trends -> PickUpByDayDetailed Menu Displayed");
                ReportScheduler.Click_BookingTrends_PickUpByDayDetailed();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pick up by day detailed page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
                ReportScheduler.Select_CurrentDate_RelativeStartDate();
                ReportScheduler.Select_CurrentDate_RelativeEndDate();
                ReportScheduler.Select_CurrentDate_RelativePickupStartDate();
                ReportScheduler.Select_CurrentDate_RelativePickupEndDate();
                Logger.WriteDebugMessage("Relative dates has entered for Pick up by day detailed");
                PageUp();
                PageDown();

                //Checking Relative dates are Enabled
                string dateOffset;
                dateOffset = PageObject_ReportScheduler.Enter_RelativeStartDateOffset().GetAttribute("class");
                if (dateOffset.Contains("Disabled"))
                    Assert.Fail("Relative start date Offset is disable for Pickup by day detailed");
                else
                {
                    ReportScheduler.Enter_RelativeStartDateOffset("10");
                    Logger.WriteDebugMessage("Relative start date offset is enable for Pickup by day detailed");
                }
                dateOffset = PageObject_ReportScheduler.Enter_RelativeEndDateOffset().GetAttribute("class");
                if (dateOffset.Contains("Disabled"))
                    Assert.Fail("Relative end date Offset is disable for Pickup by day detailed");
                else
                {
                    ReportScheduler.Enter_RelativeEndDateOffset("10");
                    Logger.WriteDebugMessage("Relative end date offset is enable for Pickup by day detailed");
                }
                dateOffset = PageObject_ReportScheduler.Enter_RelativePickUpStartDateOffset().GetAttribute("class");
                if (dateOffset.Contains("Disabled"))
                    Assert.Fail("Relative pickup start date offset is disabled for Pickup by day detailed");
                else
                {
                    ReportScheduler.Enter_RelativePickUpStartDateOffset("10");
                    Logger.WriteDebugMessage("Relative pickup start date offset is enabled for Pickup by day detailed");
                }

                dateOffset = PageObject_ReportScheduler.Enter_RelativePickUpEndDateOffset().GetAttribute("class");
                if (dateOffset.Contains("Disabled"))
                    Assert.Fail("Relative pickup end date is offset disabled for Pickup by day detailed");
                else
                {
                    ReportScheduler.Enter_RelativePickUpEndDateOffset("10");
                    Logger.WriteDebugMessage("Relative pickup end date offset is enabled for Pickup by day detailed");
                }


                //Clearing relative dates and checking Relative dates Offset are disable
                ReportScheduler.Select_SelectDate_RelativeStartDate();
                ReportScheduler.Select_SelectDate_RelativeEndDate();
                ReportScheduler.Select_SelectDate_RelativePickupStartDate();
                ReportScheduler.Select_SelectDate_RelativePickupEndDate();
                Logger.WriteDebugMessage("Relative dates has cleared for Pickup by day detailed");

                dateOffset = PageObject_ReportScheduler.Enter_RelativeStartDateOffset().GetAttribute("class");
                if (dateOffset.Contains("Disabled"))
                    Logger.WriteInfoMessage("Relative start date offset is disable for Pickup by day detailed");
                else
                    Assert.Fail("Relative start date Offset is still enabled for Pickup by day detailed");

                dateOffset = PageObject_ReportScheduler.Enter_RelativeEndDateOffset().GetAttribute("class");
                if (dateOffset.Contains("Disabled"))
                    Logger.WriteInfoMessage("Relative end date offset is disable for Pickup by day detailed");
                else
                    Assert.Fail("Relative end date Offset is still enabled for Pickup by day detailed");

                dateOffset = PageObject_ReportScheduler.Enter_RelativePickUpStartDateOffset().GetAttribute("class");
                if (dateOffset.Contains("Disabled"))
                    Logger.WriteInfoMessage("Relative Pick Up start date offset is disable for Pickup by day detailed");
                else
                    Assert.Fail("Relative Pick Up start date Offset is still enabled for Pickup by day detailed");

                dateOffset = PageObject_ReportScheduler.Enter_RelativePickUpEndDateOffset().GetAttribute("class");
                if (dateOffset.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative Pick Up start date offset is disable for Pickup by day detailed");
                else
                    Assert.Fail("Relative Pick Up start date Offset is still enabled for Pickup by day detailed");


                //Relative dates are entered using Calendar or Keyboard for Booking Trend -> channel Pace analysis 
                ExitFrame();
                ExitFrame();
                PageUp();
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");
                Navigation.Click_UserMenu();
                EnterFrame_ByName("wndReportScheduler2");
                ReportScheduler.Click_BookingTrends();
                Logger.WriteDebugMessage("Booking trends link got clicked");
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis());
                ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis();
                AddDelay(30000);
                Logger.WriteDebugMessage("Channel Pace analysis page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
                ReportScheduler.Select_CurrentDate_RelativeStartDate();
                ReportScheduler.Select_CurrentDate_RelativeEndDate();
                ReportScheduler.Select_RelativeAsOfDate_CurrentMonth();
                Logger.WriteDebugMessage("Relative dates are selected for Channel Pace analysis");

                PageUp();
                PageDown();

                //Checking Relative dates are Disabled
                dateOffset = PageObject_ReportScheduler.Enter_RelativeStartDateOffset().GetAttribute("class");
                if (dateOffset.Contains("Disabled"))
                    Assert.Fail("Relative start date offset is disabled for channel Pace analysis");
                else
                {
                    ReportScheduler.Enter_RelativeStartDateOffset("10");
                    Logger.WriteDebugMessage("Relative start date offset is enable for channel Pace analysis");
                }
                dateOffset = PageObject_ReportScheduler.Enter_RelativeEndDateOffset().GetAttribute("class");
                if (dateOffset.Contains("Disabled"))
                    Assert.Fail("Relative end date offset is disabled for channel Pace analysis");
                else
                {
                    ReportScheduler.Enter_RelativeEndDateOffset("10");
                    Logger.WriteDebugMessage("Relative end date offset is enable for channel Pace analysis");
                }
                dateOffset = PageObject_ReportScheduler.Click_RelativeAsOfDate_Offset().GetAttribute("class");
                if (dateOffset.Contains("Disabled"))
                    Assert.Fail("Relative As of date offset is disabled for channel Pace analysis");
                else
                {
                    ReportScheduler.Click_RelativeAsOfDate_Offset("10");
                    Logger.WriteDebugMessage("Relative as of date offset is enable for channel Pace analysis");
                }

                //Clearing relative dates and checking absolute dates are Enabled
                ReportScheduler.Select_SelectDate_RelativeStartDate();
                ReportScheduler.Select_SelectDate_RelativeEndDate();
                ReportScheduler.Select_RelativeAsOfDate_Blank();
                Logger.WriteDebugMessage("Relative dates has cleared for channel Pace analysis");

                dateOffset = PageObject_ReportScheduler.Enter_RelativeStartDateOffset().GetAttribute("class");
                if (dateOffset.Contains("Disabled"))
                    Logger.WriteInfoMessage("Relative start date offset is Disabled for channel Pace analysis");

                else
                    Assert.Fail("Relative start date offset is Enabled for channel Pace analysis");

                dateOffset = PageObject_ReportScheduler.Enter_RelativeEndDateOffset().GetAttribute("class");
                if (dateOffset.Contains("Disabled"))
                    Logger.WriteInfoMessage("Relative End date offset is Disabled for channel Pace analysis");
                else
                    Assert.Fail("Relative End date offset is Enabled for channel Pace analysis");

                dateOffset = PageObject_ReportScheduler.Click_RelativeAsOfDate_Offset().GetAttribute("class");
                if (dateOffset.Contains("Disabled"))
                    Logger.WriteDebugMessage("Relative As of  date offset is Disabled for channel Pace analysis");
                else
                    Assert.Fail("Relative As Of Date offset is Enabled for channel Pace analysis");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }
        /*
        public static void TC_265408()
        {
            if (TestCaseId == Utility.Constants.TC_265408)
            {
                //Pre-Requisite
                string password, userName, client, description, startHours, startMinutes, emailTo, emailSubject, startDate, endDate, hotelPortfolio, timeZone;
                Random ranNo = new Random();

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                description = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Description"), ranNo.Next().ToString().Substring(0, 2));
                startHours = TestData.ExcelData.TestDataReader.ReadData(1, "StartHours");
                startMinutes = TestData.ExcelData.TestDataReader.ReadData(1, "StartMinutes");
                emailTo = TestData.ExcelData.TestDataReader.ReadData(1, "EmailTo");
                emailSubject = TestData.ExcelData.TestDataReader.ReadData(1, "EmailSubject");
                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");

                Logger.WriteInfoMessage("Test Case : Verify the absolute dates gets enabled when relative dates are cleared");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //for Market-> Market Report
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_ReportParameter_Market();
                ScrollToElement(PageObject_ReportScheduler.Click_Market_MarketReport());
                Logger.WriteDebugMessage("Market-> Market Report Menu Displayed");
                ReportScheduler.Click_Market_MarketReport();
                AddDelay(30000);
                Logger.WriteDebugMessage("Market Report page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ReportScheduler.AddSchedule_WithReportType(description, startHours, startMinutes, emailTo, emailSubject, startDate, endDate, "4");
                ExitFrame();
                ExitFrame();

                //Verify the detail entered reflected in Manage Schedule
                Navigation.Click_UserMenu_ManageReportSchedules();
                Logger.WriteDebugMessage("Manage Report Scheduler clicked");
                EnterFrame_ByName("wndManageScheduler");

                Helper.HighlightElement(Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + description + "')]")));
                Logger.WriteDebugMessage("Report available in Manage Report Schedules");
                ExitFrame();

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_RainMaker();
                Navigation.Click_SubscriptionSupport();
                Logger.WriteDebugMessage("Subscription Centre");

                EnterFrame_ByName("Subscription Support");
                Helper.HighlightElement(Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + description + "')]")));
                Logger.WriteDebugMessage("Report available in Subscription Center");


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Hours", startHours);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Minutes", startMinutes);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email To", emailTo);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email Subject", emailSubject, true);

            }
        }*/
        public static void TC_265401()
        {
            if (TestCaseId == Utility.Constants.TC_265401)
            {
                //Pre-Requisite
                string password, userName, client;

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");

                Logger.WriteInfoMessage("Test Case : Verify after choosing 'Portfolio' SelectType, if none are configured, UI indicates w/ message and disables dropdown");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Select the report Booking Trend -> Pick up by Day Detailed
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
                Logger.WriteDebugMessage("Booking trends -> PickUpByDayDetailed Menu Displayed");
                ReportScheduler.Click_BookingTrends_PickUpByDayDetailed();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pick up by day detailed page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                ReportScheduler.Click_SelectType_Hotel();
                Logger.WriteDebugMessage("Clicked on Select Type");
                ReportScheduler.Select_SelectType_Portfolio();
                AddDelay(30000);
                Logger.WriteDebugMessage("Portfolio get selected and pop-up should displayed");
                string frameName = PageObject_ReportScheduler.Get_AlertFrameName().GetAttribute("name");
                ReportScheduler.Click_InvalidSelection_OkButton(frameName + "_content");
                Logger.WriteDebugMessage("Clicked on Ok button");
                string type_Hotel = PageObject_ReportScheduler.Click_SelectType_Hotel().GetAttribute("disabled");
                string value_Hotel = PageObject_ReportScheduler.Click_SelectType_Hotel().GetAttribute("value");
                if (type_Hotel.Equals("true") && value_Hotel.Equals("Hotel"))
                    Logger.WriteDebugMessage("Selection list value defaults to hotel and gets disabled");
                else
                    Assert.Fail("Selection list value is enabled");
                ExitFrame();

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Client", client, true);

            }
        }/*
        public static void TC_265402()
        {
            if (TestCaseId == Utility.Constants.TC_265402)
            {
                //Pre-Requisite
                string password, userName, client, hotelValue;

                //Retrieve data from Database or test data file
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");

                Logger.WriteInfoMessage("Test Case : Verify after choosing 'Portfolio' SelectType, if none are configured, UI indicates w/ message and disables dropdown");

                //Enter Email address and password
                Login.Frontend_SignIn(userName, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Report Scheduler 
                Navigation.Click_UserMenu();
                Logger.WriteDebugMessage("User menu clicked");
                Navigation.Click_UserMenu_ReportScheduler();
                Logger.WriteDebugMessage("Report scheduler link clicked");

                //Select the report Booking Trend -> Pick up by Day Detailed
                EnterFrame_ByName("wndReportScheduler");
                ReportScheduler.Click_BookingTrends();
                ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
                Logger.WriteDebugMessage("Booking trends -> PickUpByDayDetailed Menu Displayed");
                ReportScheduler.Click_BookingTrends_PickUpByDayDetailed();
                AddDelay(30000);
                Logger.WriteDebugMessage("Pick up by day detailed page should get displayed");
                EnterFrame_ByName("ReportDeliveryDialog");
                DynamicScroll(Driver, PageObject_ReportScheduler.Click_SelectType_Hotel());
                Logger.WriteDebugMessage("Hotel and Portfolio are displaying");
                ReportScheduler.Click_SelectType_Hotel();
                Logger.WriteDebugMessage("Clicked on Select Type");
                ReportScheduler.Select_SelectType_Hotel();
                Logger.WriteDebugMessage("Hotel Got Selected");
                ReportScheduler.Click_HotelOrPortfolio();
                Logger.WriteDebugMessage("Click on select Hotel/Portfolio dropdown");
                ReportScheduler.Select_HotelName("1");
                Logger.WriteDebugMessage("Hotel on 1st Position got selected");
                ElementWait(PageObject_ReportScheduler.Click_RoomTypeAnalysis_SaveButton(), 240);
                for (int i = 1; i <= 8; i++)
                {
                    hotelValue = TestData.ExcelData.TestDataReader.ReadData(i, "HotelListValue");
                    VerifyTextOnPageAndHighLight(hotelValue);
                }
                Logger.WriteDebugMessage("All the Values for Hotel Select Types are displaying properly");
                ExitFrame();
                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Username", userName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Client", client, true);

            }
        }
      */
        public static void TC_265398()
        {
            //Pre-Requisite
            string password, userName, client, startDate, endDate, hotelPortfolio;

            //Retrieve data from Database or test data file
            userName = GlobalParam.Username;//TestData.ExcelData.TestDataReader.ReadData(1, "UserName");
            password = GlobalParam.Password;//TestData.ExcelData.TestDataReader.ReadData(1, "Password");
            client = GlobalParam.Client;//TestData.ExcelData.TestDataReader.ReadData(1, "Client");
            startDate = DateTime.Now.ToString("MM/dd/yyyy");
            endDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
            hotelPortfolio = GlobalParam.Portfolio;//TestData.ExcelData.TestDataReader.ReadData(1, "HotelPortfolio");


            //Enter Email address and password
            Login.Frontend_SignIn(userName, password);

            //Select Client 
            Navigation.Select_Client(client);

            //Navigate to Report Scheduler 
            Navigation.Click_UserMenu();
            Logger.WriteDebugMessage("User menu clicked");
            Navigation.Click_UserMenu_ReportScheduler();
            Logger.WriteDebugMessage("Report scheduler link clicked");
            Navigation.Click_UserMenu();

            //Enter absolute dates are entered using Calendar or Keyboard for Booking Trend -> Pick up by Day Detailed
            EnterFrame_ByName("wndReportScheduler");
            ReportScheduler.Click_BookingTrends();
            Logger.WriteDebugMessage("Booking trends link got clicked");
            ScrollToElement(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
            ReportScheduler.Click_BookingTrends_PickUpByDayDetailed();
            AddDelay(30000);
            Logger.WriteDebugMessage("Pick up by day detailed page should get displayed");
            Driver.SwitchTo().Frame("ReportDeliveryDialog");
            ReportScheduler.Click_SelectType_Hotel();
            ReportScheduler.Select_SelectType_Portfolio();
            ElementWait(Driver.FindElement(By.XPath("//input[@name = 'DeliveryConfigPanelBar$i4$BusinessUnitId']")), 240);
            AddDelay(30000);
            // Get Text from Report Delivery
            IWebElement elem = Driver.FindElement(By.XPath("//input[@name = 'DeliveryConfigPanelBar$i4$HotelCode']"));
            string rD_Portfolio_Text = elem.GetAttribute("value");
            
            elem = Driver.FindElement(By.XPath("//input[@name = 'DeliveryConfigPanelBar$i4$BusinessUnitId']"));
            string rD_BusinessUnit_Text = elem.GetAttribute("value");
            elem = Driver.FindElement(By.XPath("//input[@name = 'DeliveryConfigPanelBar$i4$CurrencyCd']"));
            string rD_Currency_Text = elem.GetAttribute("value");

            Logger.WriteDebugMessage("Found Selected Porfolio as " + rD_Portfolio_Text + ", Business Unit as " + rD_BusinessUnit_Text + "and Currency as " + rD_Currency_Text);
            Driver.SwitchTo().DefaultContent();
            
            //Check Text in Portfolio Report
            Navigation.Click_Menu_Portfolio();
            Logger.WriteDebugMessage("Portfolio Drop down displayed");
            Navigation.Click_Portfolio_Report();
            Helper.AddDelay(30000);
            string xPathPortfolioReportFrame = "(//iframe[@src='Report/AnalysisPortfolioViewer.aspx?ReportKey=10'])[2]";
            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(xPathPortfolioReportFrame)));
            Logger.WriteDebugMessage("User landed on Portfolio page");
            elem = Driver.FindElement(By.XPath("//input[@name = 'wcHotelPortBrand']"));
            string pR_Portfolio_Text = elem.GetAttribute("value");

            elem = Driver.FindElement(By.XPath("//input[@name = 'rcBusinessUnit']"));
            string pR_Business_Unit_Text = elem.GetAttribute("value");

            elem = Driver.FindElement(By.XPath("//input[@name = 'wcCurrency']"));
            string pR_Currency_Text = elem.GetAttribute("value");

            if (rD_Portfolio_Text == pR_Portfolio_Text && rD_BusinessUnit_Text == pR_Business_Unit_Text && rD_Currency_Text == pR_Currency_Text)
            {
                Logger.WriteDebugMessage("Found Values similar to values expected from Report Scheduler" + "\n Portfolio as " + pR_Portfolio_Text + "\n Business Unit as " + pR_Business_Unit_Text + "\n Currency as " + pR_Currency_Text);
            }
            else
            {
                Assert.Fail("Found Values similar to values expected from Report Scheduler" + "\n Portfolio as " + pR_Portfolio_Text + "\n Business Unit as " + pR_Business_Unit_Text + "\n Currency as " + pR_Currency_Text);
            }
            /*
            //Navigate to User Preference
            Driver.SwitchTo().DefaultContent();
            Navigation.Click_UserMenu();
            Logger.WriteDebugMessage("User menu clicked");
            Navigation.user_preferences();
            Logger.WriteDebugMessage("Navigated to user prefernces");
            Navigation.Click_UserMenu();
            EnterFrame_ByName("wndUserPreference");
            ElementWait(Driver.FindElement(By.XPath("//*[@id='HotelPortfolioDropdown_Input']")), 240);
            //Get preference
            string hotelValue = PageObject_ReportParameter.UserPreference_GetHotel().GetAttribute("value");
            string businessUnitValue = PageObject_ReportParameter.UserPreference_GetBusinessUnit().GetAttribute("value");
            string getCurrencyValue = PageObject_ReportParameter.UserPreference_GetCurrency().GetAttribute("value");

            if (hotelValue == rD_Portfolio_Text && businessUnitValue == rD_BusinessUnit_Text && getCurrencyValue == rD_Currency_Text)
            {
                Logger.WriteDebugMessage("Found Values similar to values expected from Report Scheduler" + "\n Portfolio as " + hotelValue + "\n Business Unit as " + businessUnitValue + "\n Currency as " + getCurrencyValue);
            }
            else
            {
                Assert.Fail("Found Business Unit from Portfolio Report not same as User Preference  - " + pR_Business_Unit_Text + "\n Found Currency  from Portfolio Report not same as User Preference  - " + pR_Currency_Text);
            }
            */
        }
    }
}
