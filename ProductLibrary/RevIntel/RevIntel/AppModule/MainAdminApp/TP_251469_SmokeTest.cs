using BaseUtility.Utility;
using InfoMessageLogger;
using MongoDB.Driver.Core.Events;
using NUnit.Framework;
using RevIntel.AppModule.UI;
using RevIntel.PageObject.UI;
using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using Navigation = RevIntel.AppModule.UI.Navigation;

namespace RevIntel.AppModule.MainAdminApp
{
    public partial class MainAdminApp : RevIntel.Utility.Setup
    {

        //This test cases will Verify Login and Log out is successful and URL is pointing to right database
        public static void TC_251470()
        {
            if (TestCaseId == Utility.Constants.TC_251470)
            {
                //Pre-Requisite
                string password, environment, username, client, url;
                int i;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");

                Logger.WriteInfoMessage("This test cases will Verify Login and Log out is successful and URL is pointing to right database");

                for (int ClientNumber = 1; ClientNumber < 1; ClientNumber++)
                {
                    url = TestData.ExcelData.TestDataReader.ReadData(ClientNumber, "url");
                    Helper.Driver.Url = (url);
                  
                    //Enter Email address and password
                    Login.Frontend_SignIn(username, password);

                    //Select Client and verify link navigate to right database
                    client = TestData.ExcelData.TestDataReader.ReadData(ClientNumber, "client");
                    Logger.WriteDebugMessage("user landed on the RevIntel client selection page");
                    Helper.DynamicScroll(Helper.Driver, PageObject_Navigation.Link_ClientName(client));
                    Logger.WriteDebugMessage("Client displayed");
                    Navigation.Click_ClientName(client);
                    Logger.WriteDebugMessage(client + " selected");

                    //Verify link directed to right database
                    string client_CurrentUrl = Driver.Url;
                    if (client_CurrentUrl.Contains(url))
                        Logger.WriteDebugMessage("Actual url = " + client_CurrentUrl + " match with Expected url = " + url);
                    else
                        Assert.Fail("Actual and Expeted url are not same");
                   
                    //Click on log out
                    Login.Select_DropDown();
                    Logger.WriteDebugMessage("Drop down Displayed");
                    Login.LogOut_Button();
                    Logger.WriteDebugMessage("Log out successful");

                    //Log test data into log file as well as extent report
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_url", url, true);

                }

            }
        }
     
        //Verify the default filter value and eyeball on calculated field in report
        public static void TC_252390()
        {
            if (TestCaseId == Utility.Constants.TC_252390)
            {
                //Pre-Requisite
                string password, username, client, url,environment, Pickup_End, Pickup_Start, Start, End;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");

                Logger.WriteInfoMessage("Test Case : Verify the default filter value and eyeball on calculated field in report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
               Navigation.Select_Client(client);

                //Verify link directed to right URL
                url = TestData.ExcelData.TestDataReader.ReadData(1, "url");

                string client_CurrentUrl = Driver.Url;
                if (client_CurrentUrl.Contains(url))
                    Logger.WriteDebugMessage("Actual url = " + client_CurrentUrl + " match with Expected url = " + url);
                else
                    Assert.Fail("Actual and Expeted url are not same");

                Pickup_End = DateTime.Now.ToString("M/d/yyyy").Replace("-","/");
                Pickup_Start = DateTime.Now.AddDays(-1).ToString("M/d/yyyy").Replace("-", "/");

                Start = DateTime.Now.ToString("Jan yyyy");
                End = DateTime.Now.ToString("Dec yyyy");

                //Change filter from user preference tab
                Login.Select_DropDown();
                Logger.WriteDebugMessage("Drop down displayed");
                Navigation.user_preferences();
                Login.Select_DropDown();
                Logger.WriteDebugMessage("User landed on User preference page");

                Helper.EnterFrameByxPath(PageObject_Navigation.Iframe_user_preferences());

                string userPref_Hotel = PageObject_Navigation.user_preferences_Hotel().GetAttribute("value");
                string userPref_Currency = PageObject_Navigation.user_preferences_Currency().GetAttribute("value");
                string userPref_Business_Unit = PageObject_Navigation.user_preferences_BusinessUnit().GetAttribute("value");

                Helper.ExitFrame();

                //Verify set filter on Monthly Pickup report page
                Helper.ReloadPage();
                AddDelay(10000);

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Monthly_Pickup());

                string MonthlyPickup_Hotel = PageObject_ReportParameter.Monthly_Pickup_Hotel_Value().GetAttribute("value");
                string MonthlyPickup_Currency = PageObject_ReportParameter.Monthly_Pickup_Currency_Value().GetAttribute("value");
                string MonthlyPickup_Business_Unit = PageObject_ReportParameter.Monthly_Pickup_Business_Unit_Value().GetAttribute("value");
                string MonthlyPickup_Pickupstart = PageObject_ReportParameter.Monthly_PickupStart().GetAttribute("value"); 
                string MonthlyPickup_PickupEnd = PageObject_ReportParameter.Monthly_PickupEnd().GetAttribute("value");
                string MonthlyPickup_Start = PageObject_ReportParameter.Monthly_Start().GetAttribute("value");
                string MonthlyPickup_End = PageObject_ReportParameter.Monthly_End().GetAttribute("value");

                if (userPref_Hotel.Equals(MonthlyPickup_Hotel))
                    Logger.WriteDebugMessage("Monthly Pickup page Hotel Value matched with user preference hotel value");
                else
                    Assert.Fail("Hotel Value not matched");

                if (userPref_Currency.Equals(MonthlyPickup_Currency))
                    Logger.WriteDebugMessage("Monthly Pickup page Curremcy Value matched with user preference Currency value");
                else
                    Assert.Fail("Currency Value not matched");

                if (userPref_Business_Unit.Equals(MonthlyPickup_Business_Unit))
                    Logger.WriteDebugMessage("Monthly Pickup page Business_Unit Value matched with user preference Business_Unit value");
                else
                    Assert.Fail("Business_Unit Value not matched");

                if (Pickup_Start.Contains(MonthlyPickup_Pickupstart))
                    Logger.WriteDebugMessage("Monthly Pickup page start matched ");
                else
                    Assert.Fail("Pickup_Start not matched");

                if (Pickup_End.Contains(MonthlyPickup_PickupEnd))
                    Logger.WriteDebugMessage("Monthly Pickup page Pickup_End matched");
                else
                    Assert.Fail("Pickup_End not matched");

                if (Start.Contains(MonthlyPickup_Start))
                    Logger.WriteDebugMessage("Start matched");
                else
                    Assert.Fail("Start not matched");

                if (End.Contains(MonthlyPickup_End))
                    Logger.WriteDebugMessage("End matched");
                else
                    Assert.Fail("End not matched");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_userPref_Hotel", userPref_Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_userPref_Currency", userPref_Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_userPref_Business_Unit", userPref_Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_MonthlyPickup_Hotel", MonthlyPickup_Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_MonthlyPickup_Currency", MonthlyPickup_Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_MonthlyPickup_Business_Unit", MonthlyPickup_Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_MonthlyPickup_Pickupstart", MonthlyPickup_Pickupstart);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_MonthlyPickup_PickupEnd", MonthlyPickup_PickupEnd);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_MonthlyPickup_Start", MonthlyPickup_Start);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_MonthlyPickup_End", MonthlyPickup_End, true);
            }
        }

        //-Verify the Other Link
        public static void TC_252482()
        {
            if (TestCaseId == Utility.Constants.TC_252482)
            {
                //Pre-Requisite
                string password, username, client, url,environment, url1, url2;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");

                Logger.WriteInfoMessage("Test Case : Verify the Other Links");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Verify link directed to right URL
                url = TestData.ExcelData.TestDataReader.ReadData(1, "url");

                string client_CurrentUrl = Driver.Url;
                if (client_CurrentUrl.Contains(url))
                    Logger.WriteDebugMessage("Actual url = " + client_CurrentUrl + " match with Expected url = " + url);
                else
                    Assert.Fail("Actual and Expeted url are not same");

                //Select  (?-> Release note)
                //Verify Training link
                Helper.DoubleClickElement(PageObject_Navigation.Help_Menu());
                Logger.WriteDebugMessage("Help menu displayed");
                Navigation.Training();
                Helper.ControlToNextWindow();

                //Verify Training link directed to right URL
                url1 = TestData.ExcelData.TestDataReader.ReadData(1, "url1");

                string Training_CurrentUrl = Driver.Url;
                if (Training_CurrentUrl.Contains(url1))
                    Logger.WriteDebugMessage("Actual url = " + client_CurrentUrl + " match with Expected url = " + url1);
                else
                    Assert.Fail("Actual and Expeted url for Training are not same");

                Helper.AddDelay(20000);
                Logger.WriteDebugMessage("Landed on Training page");
                Helper.ControlToPreviousWindow();

                //Verify Release link
                Helper.DoubleClickElement(PageObject_Navigation.Help_Menu());
                Logger.WriteDebugMessage("Help menu displayed");
                Navigation.Release_note();
                Helper.ControlToNextWindow();

                //Verify Release link directed to right URL
                url2 = TestData.ExcelData.TestDataReader.ReadData(1, "url2");

                string Release_CurrentUrl = Driver.Url;
                if (Release_CurrentUrl.Contains(url2))
                    Logger.WriteDebugMessage("Actual url = " + client_CurrentUrl + " match with Expected url = " + url2);
                else
                    Assert.Fail("Actual and Expeted url for Release note are not same");

                Helper.AddDelay(20000);
                Logger.WriteDebugMessage("Landed on Release note page");
                Helper.ControlToPreviousWindow();

                //Change filter from user preference tab
                Login.Select_DropDown();
                Logger.WriteDebugMessage("Drop down displayed");
                Navigation.user_preferences();
                Login.Select_DropDown();
                Logger.WriteDebugMessage("User landed on User preference page");

                Helper.EnterFrameByxPath(PageObject_Navigation.Iframe_user_preferences());

                Navigation.Click_User_Preference_Portfolio_Toggle_button();
                Helper.ExitFrame();

                //Change Tenant
                Login.Select_DropDown();
                Logger.WriteDebugMessage("Drop down displayed");
                Navigation.Click_change_tenant();
                //Navigation.Click_Automation();
                Navigation.Tenant_21C();
                Logger.WriteDebugMessage("Tenant is selected as 21C");

                //Change filter from user preference tab
                Login.Select_DropDown();
                Logger.WriteDebugMessage("Drop down displayed");
                Navigation.user_preferences();
                Login.Select_DropDown();
                Logger.WriteDebugMessage("User landed on User preference page");

                Helper.EnterFrameByxPath(PageObject_Navigation.Iframe_user_preferences());

                Navigation.Click_User_Preference_Portfolio_Toggle_button();

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);

                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        //Verify attempting to create a new user with exsiting email id or userid should fail
        public static void TC_252494()
        {
            if (TestCaseId == Utility.Constants.TC_252494)
            {
                //Pre-Requisite
                string password, username, client, url,environment, email, user_ID, firstName, lastName;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                user_ID = TestData.ExcelData.TestDataReader.ReadData(1, "user_ID");
                email = TestData.ExcelData.TestDataReader.ReadData(1, "email");
                firstName = TestData.ExcelData.TestDataReader.ReadData(1, "firstName");
                lastName = TestData.ExcelData.TestDataReader.ReadData(1, "lastName");

                Logger.WriteInfoMessage("Test Case : Verify attempting to create a new user with exsiting email id or userid should fail");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Verify link directed to right URL
                url = TestData.ExcelData.TestDataReader.ReadData(1, "url");

                string client_CurrentUrl = Driver.Url;
                if (client_CurrentUrl.Contains(url))
                    Logger.WriteDebugMessage("Actual url = " + client_CurrentUrl + " match with Expected url = " + url);
                else
                    Assert.Fail("Actual and Expeted url are not same");

                //Go to Administration>User Preference and add existing user
                Navigation.Click_Hamburger_Icon();
                Logger.WriteDebugMessage("All reports under Hamburger_Icon dropdown Displayed");
                Navigation.Administration();
                Logger.WriteDebugMessage("Administration drop down list displayed");
                Navigation.User_Maintenance();
                Logger.WriteDebugMessage("User landed on user preference page");

                Helper.EnterFrameByxPath(PageObject_Navigation.Iframe_user_Maintenance());
                Navigation.Add_New_User();
                Logger.WriteDebugMessage("Add new user pop up displayed");

                Helper.EnterFrameByxPath(PageObject_Navigation.Iframe_Add_User());
                Navigation.user_Maintenance_Save();
                Logger.WriteDebugMessage("Vaidation message displayed for User_id and Email fields");
                Helper.VerifyTextOnPageAndHighLight("User Id is required!");
                Helper.VerifyTextOnPageAndHighLight("Email Id is required!");
                Navigation.user_Id(user_ID);
                Logger.WriteDebugMessage(user_ID + " entered as user ID");
                Navigation.Add_User_FirstName(firstName);
                Logger.WriteDebugMessage(firstName + " entered as firstname");
                Navigation.Add_User_LastName(lastName);
                Logger.WriteDebugMessage(lastName + " entered as lastname");
                Navigation.Add_User_Email(email);
                Logger.WriteDebugMessage(email + " as email");

                Navigation.Select_Available_Hotels();
                Logger.WriteDebugMessage("Hotel moved to selected hotel section");
                Navigation.user_Maintenance_Save();
                Helper.VerifyTextOnPageAndHighLight("User k_rshende already exists!");
                Helper.ExitFrame();

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_user_ID", user_ID);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_email", email);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_firstName", firstName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_lastName", lastName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Validation", "User k_rshende already exists!",true);

                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        //Verify attempting to create a new portfolia with same name should fail
        public static void TC_252496()
        {
            if (TestCaseId == Utility.Constants.TC_252496)
            {
                //Pre-Requisite
                string password, username, environment,url, client, Portfolio_Name, validation;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name");
                validation = TestData.ExcelData.TestDataReader.ReadData(1, "validation");

                Logger.WriteInfoMessage("Test Case : Verify attempting to create a new portfolia with same name should fail");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Verify link directed to right URL
                url = TestData.ExcelData.TestDataReader.ReadData(1, "url");

                string client_CurrentUrl = Driver.Url;
                if (client_CurrentUrl.Contains(url))
                    Logger.WriteDebugMessage("Actual url = " + client_CurrentUrl + " match with Expected url = " + url);
                else
                    Assert.Fail("Actual and Expeted url are not same");

                //Go to Administration>User Preference and add existing user
                Navigation.Click_Hamburger_Icon();
                Logger.WriteDebugMessage("All reports under Hamburger_Icon dropdown Displayed");
                Navigation.Administration();
                Logger.WriteDebugMessage("Administration drop down list displayed");
                Navigation.Corporate_Portfolio();
                Logger.WriteDebugMessage("landed on Corporate_Portfolio page");

                Helper.EnterFrameByxPath(PageObject_Navigation.iframe_New_Portfolio());
                Navigation.Add_New_Portfolio();
                Logger.WriteDebugMessage("Add_New_Portfolio pop up displayed");
                Helper.EnterFrameByxPath(PageObject_Navigation.Iframe_Add_User());
                Navigation.Portfolio_name(Portfolio_Name);
                Logger.WriteDebugMessage(Portfolio_Name + " as Portfolio name");
                Navigation.Select_Available_Hotels();
                Logger.WriteDebugMessage("Hotel selected");
                Navigation.user_Maintenance_Save();
                Helper.VerifyTextOnPageAndHighLight(validation);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name", Portfolio_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_validation", validation, true);
                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        //Verify logged in user is able to navigate to all menu and generate random reports
        public static void TC_252394()
        {
            if (TestCaseId == Utility.Constants.TC_252394)
            {
                //Pre-Requisite
                string password, username, environment, client, startDate, url, enddate;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");

                Logger.WriteInfoMessage("Test Case : Verify logged in user is able to navigate to all menu and generate random reports");

                //Enter Email address and password
                    Login.Frontend_SignIn(username, password);

                //Select Client
                Navigation.Select_Client(client);

                //Verify link directed to right URL
                url = TestData.ExcelData.TestDataReader.ReadData(1, "url");

                string client_CurrentUrl = Driver.Url;
                if (client_CurrentUrl.Contains(url))
                    Logger.WriteDebugMessage("Actual url = " + client_CurrentUrl + " match with Expected url = " + url);
                else
                    Assert.Fail("Actual and Expeted url are not same");

                //Navigate to Hotel->Hotel Event Calender
                Navigation.Hotel();
                Logger.WriteDebugMessage("Hotel Dropdown displayed");
               // Navigation.Click_Hotel_Event_Calendar_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Hotel Event Calender Report page");

                ////Navigate to Business Source->Agent Analysis 
                Navigation.BusinessSource();
                Logger.WriteDebugMessage("BusinessSource Dropdown displayed");
                Navigation.Click_AgentAnalysis_Report();
                Helper.AddDelay(20000);
                Logger.WriteDebugMessage("User landed on Agent Analysis Report page");

                ////Navigate to Market->Market Report 
                Navigation.Market();
                Logger.WriteDebugMessage("market Dropdown displayed");
                Navigation.Market_Performance();
                Helper.AddDelay(20000);
                Logger.WriteDebugMessage("User landed on Market Report page");

                ////Navigate to Booking Trends->Lenght of Stay Report 
                Navigation.Click_Menu_Booking_Trends();
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Click_Length_of_Stay_Report();
                Helper.AddDelay(20000);
                Logger.WriteDebugMessage("User landed on Lenght of Stay Report  page");

                ////Navigate to Channel->Channel Report 
                Navigation.Click_Menu_Channel();
                Logger.WriteDebugMessage("channel Drop down Displayed");
                Navigation.Click_Channel_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Channel Report  page");

                ////Navigate to Room Type->Room Type analysis
                Navigation.Click_Hamburger_Icon();
                Helper.AddDelay(10000);
                Navigation.Click_Menu_Room_Type();                
                Logger.WriteDebugMessage("Room Type Drop down Displayed");
                Navigation.Click_Menu_Room_Type_Analysis();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Room Type analysis Report  page");

                ////Navigate to Forecast and Budget->Pace and Forecast Report
                Navigation.Booking_Trends();
                Logger.WriteDebugMessage("Booking Trends Drop down displayed");
                Navigation.Pace_Trend();
                Helper.AddDelay(20000);
                Logger.WriteDebugMessage("User landed on Pace Trend  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_Trend());

                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");
                Logger.WriteDebugMessage("Report dispalyed for Pace and Forecast Report");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate,true);
            }
        }

        //Verify user should be able to export the Pace report data in all format
        public static void TC_252401()
        {
            if (TestCaseId == Utility.Constants.TC_252401)
            {
                //Pre-Requisite
                string password, username, client, url,environment;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");

                Logger.WriteInfoMessage("Test Case : Verify user should be able to export the Pace report data in all format");

                //Enter Email address and password
               Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Verify link directed to right URL
                url = TestData.ExcelData.TestDataReader.ReadData(1, "url");

                string client_CurrentUrl = Driver.Url;
                if (client_CurrentUrl.Contains(url))
                    Logger.WriteDebugMessage("Actual url = " + client_CurrentUrl + " match with Expected url = " + url);
                else
                    Assert.Fail("Actual and Expeted url are not same");

                //Navigate to all menu
                Helper.ElementHover(PageObject_Navigation.Forecast_and_Budget());
                Logger.WriteDebugMessage("Forecast_and_Budget Dropdown displayed");
                Navigation.Pace_Forecast_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Pace and Forcast report page");

                Helper.EnterFrameByxPath(PageObject_Navigation.iFrame_Pace_Forecast_Report());
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(70000);
                Logger.WriteDebugMessage("Report generated");

                //Export report in excel format
                ReportParameter.Export_Menu();
                Logger.WriteDebugMessage("Dropdown displayed");
                ReportParameter.Excel();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("Report exported in excel format");

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                Helper.VerifyFileExists(FilePath);

                //Export report in Word format
                ReportParameter.Export_Menu();
                Logger.WriteDebugMessage("Dropdown displayed");
                ReportParameter.Word();
                Helper.AddDelay(20000);
                Logger.WriteDebugMessage("Report exported in Word format");

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyWordFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                Helper.VerifyFileExists(FilePath);

                //Export report in PDF format
                ReportParameter.Export_Menu();
                Logger.WriteDebugMessage("Dropdown displayed");
                ReportParameter.PDF();
                Helper.AddDelay(20000);
                Logger.WriteDebugMessage("Report exported in PDF format");

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyPdfFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                Helper.VerifyFileExists(FilePath);

                //Export report in TIFE format
                ReportParameter.Export_Menu();
                Logger.WriteDebugMessage("Dropdown displayed");
                ReportParameter.TIFF();
                Helper.AddDelay(20000);
                Logger.WriteDebugMessage("Report exported in TIFF format");

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyTIFFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                Helper.VerifyFileExists(FilePath);

                //Export report in PowerPoint format
                ReportParameter.Export_Menu();
                Logger.WriteDebugMessage("Dropdown displayed");
                ReportParameter.PowerPoint();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report exported in PowerPoint format");

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyPowerPointFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                Helper.VerifyFileExists(FilePath);

                //Export report in CSV format
                ReportParameter.Export_Menu();
                Logger.WriteDebugMessage("Dropdown displayed");
                ReportParameter.CSV();
                Helper.AddDelay(20000);
                Logger.WriteDebugMessage("Report exported in CSV format");

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyCSVFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                Helper.VerifyFileExists(FilePath);

                //Export report in Data_Feed format
                ReportParameter.Export_Menu();
                Logger.WriteDebugMessage("Dropdown displayed");
                ReportParameter.Data_Feed();
                Helper.AddDelay(20000);
                Logger.WriteDebugMessage("Report exported in Data_Feed format");

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyDataFeedFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                Helper.VerifyFileExists(FilePath);

                ////Export report in MHTML format
                //ReportParameter.Export_Menu();
                //Logger.WriteDebugMessage("Dropdown displayed");
                //ReportParameter.MHTML();
                //Helper.AddDelay(30000);
                //Logger.WriteDebugMessage("Report exported in MHTML format");

                //FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                //Filename = ReportParameter.VerifymhtmlFormate(FilePath);
                //FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                //Helper.VerifyFileExists(FilePath);

                //////Export report in XML format
                //ReportParameter.Export_Menu();
                //Logger.WriteDebugMessage("Dropdown displayed");
                //ReportParameter.XML();
                //Helper.AddDelay(20000);
                //Logger.WriteDebugMessage("Report exported in XML format");

                //FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                //Filename = ReportParameter.VerifyXMLFormate(FilePath);
                //FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                //Helper.VerifyFileExists(FilePath);

                Helper.ExitFrame();

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }

        }

    }




