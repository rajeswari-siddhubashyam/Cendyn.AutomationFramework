using AventStack.ExtentReports.Model;
using BaseUtility.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using RevIntel.AppModule.UI;
using RevIntel.PageObject.UI;
using System;

namespace RevIntel.AppModule.MainAdminApp
{
    public partial class MainAdminApp : RevIntel.Utility.Setup
    {
        //Verify the Role Maintenance only lists the roles that are available to the Tenant you logged in as
        public static void TC_252552()
        {
            if (TestCaseId == Utility.Constants.TC_252552)
            {
                //Pre-Requisite
                string password, username, environment, client;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");

                Logger.WriteInfoMessage("Test Case :Verify the Role Maintenance only lists the roles that are available to the Tenant you logged in as");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_RainMaker();
                Logger.WriteDebugMessage("Rainmaker menu drop down displayed");
                ReportParameter.Click_Role_Maintenance();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Role Maintenance Page");
                Helper.VerifyTextOnPage("Administrator");
                Logger.WriteDebugMessage("Administrator displayed on Role Maintenance Page");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }

        //Verify logged in user have access only to those reports that are accessible for the Role you logged in as
        public static void TC_252553()
        {
            if (TestCaseId == Utility.Constants.TC_252553)
            {
                //Pre-Requisite
                string password, username, username2, password2,environment, client;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                username2 = TestData.ExcelData.TestDataReader.ReadData(1, "username2");
                password2 = TestData.ExcelData.TestDataReader.ReadData(1, "password2");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                

                Logger.WriteInfoMessage("Test Case : Verify logged in user have access only to those reports that are accessible for the Role you logged in as");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Administration();
                Logger.WriteDebugMessage("Administration menu drop down displayed");
                Navigation.User_Maintenance();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on User Maintenance Page");

                Helper.EnterFrameByxPath(PageObject_Navigation.Iframe_user_Maintenance());

                Helper.ScrollDown();
                Helper.VerifyTextOnPageAndHighLight("testaccess@cendyn17.com");
                Logger.WriteDebugMessage("testaccess@cendyn17.com displayed");
                ReportParameter.Maintenance_Edit_testaccess();

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Maintain_User());
                Helper.VerifyTextOnPageAndHighLight("Atlantis Sanya");
                Logger.WriteDebugMessage("Atlantis Sanya selected as Access hotel");
                Helper.ScrollDown();
                Helper.VerifyTextOnPageAndHighLight("Mazagan Beach & Golf Resort");
                Logger.WriteDebugMessage("Mazagan Beach & Golf Resort selected as Access hotel");
                Helper.VerifyTextOnPageAndHighLight("Forecast and Budget");
                Logger.WriteDebugMessage("Forecast and Budget Report selected as User role");
                Helper.ExitFrame();
                Helper.ExitFrame();

                Navigation.Click_TA();
                Login.LogOut_Button();
                Logger.WriteDebugMessage("User get logged out successfully");

                Login.Enter_EmailAddress(username2);
                Logger.WriteDebugMessage("Email Address displayed");
                Login.Click_Next_Button();
                Login.Enter_Password(password2);
                Logger.WriteDebugMessage("Login in with Username =" + username + " and Password =" + password);
                Login.Click_SignIn_Button();

                //Select Client
                Navigation.Select_Client(client);

                Helper.VerifyTextOnPage("Forecast and Budget");
                Logger.WriteDebugMessage("Forecast and Budget displayed");
                Navigation.Click_Menu_Forecast_and_Budget();
                Logger.WriteDebugMessage("Forecast and budget menu drop down displayed");
                Navigation.Click_Pace_and_Forecast_Report();
                Logger.WriteDebugMessage("Landed on Pace and Forecast report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_and_Forecast_Report());
                ReportParameter.Click_HotelorPortfolio_DDL();
                Helper.VerifyTextOnPageAndHighLight("Atlantis Sanya");
                Helper.VerifyTextOnPageAndHighLight("Mazagan Beach & Golf Resort");


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username2", username2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password2", password2, true);
            }
        }

        //Verify Subscription Support
        public static void TC_252554()
        {
            if (TestCaseId == Utility.Constants.TC_252554)
            {
                //Pre-Requisite
                string password, username, environment,client;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                
                Logger.WriteInfoMessage("Test Case : Verify Subscription Support");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_RainMaker();
                Logger.WriteDebugMessage("Rainmaker menu drop down displayed");
                Navigation.Click_SubscriptionSupport();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Subscription support page");
                Helper.VerifyTextOnPage("k_tautomation");
                Logger.WriteDebugMessage("k_tautomation displayed on Subscription support page");


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }

        //Verify the Sorting and filter functonality
        public static void TC_253552()
        {
            if (TestCaseId == Utility.Constants.TC_253552)
            {
                //Pre-Requisite
                string password, username, environment,client;
               

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                

                Logger.WriteInfoMessage("Test Case : Verify the Sorting and filter functonality");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Verify sorting and filter functinality for Room Type Mapping page
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_RainMaker();
                Logger.WriteDebugMessage("Rainmaker menu drop down displayed");
                Navigation.Click_Room_Type_Mapping();
                Logger.WriteDebugMessage("User landed on Room Type mapping Page");
                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Mapping());
                ReportParameter.Rainmaker_Hotel_Dropdown();
                Logger.WriteDebugMessage("Hotel Drop down displayed");
                ReportParameter.Rainmaker_Hotel_Value();
                Logger.WriteDebugMessage("Hotel is selected as Atlantis, The Palm");

                ReportParameter.Click_Room_Type_Code();
                if (PageObject_ReportParameter.Click_Room_Type_Code().Displayed)
                {
                    Logger.WriteDebugMessage("Room Type code field is clickable");
                }
                else
                    Assert.Fail("Room Type code field is Not clickable");
                Logger.WriteDebugMessage("Room Type Code column get sorted");

                ReportParameter.Click_Room_Type_Name();
                if (PageObject_ReportParameter.Click_Room_Type_Name().Displayed)
                {
                    Logger.WriteDebugMessage("Room Type Name field is clickable");
                }
                else
                    Assert.Fail("Room Type Name field is Not clickable");
                Logger.WriteDebugMessage("Room Type Name column get sorted");

                //Verify filter functinality for Room Type Name 
                ReportParameter.Enter_Room_Type_Name("Posting");
                Logger.WriteDebugMessage("Posting is entered in Room type name filed");
                ReportParameter.Click_Filter_Icon_Room_Type_Name();
                ReportParameter.Filter_with_statsWith();
                Logger.WriteDebugMessage("Filtered Room type Name with statswith filter");
                Helper.VerifyTextOnPageAndHighLight("Posting");

                ReportParameter.Click_Rooms_Counted();
                if (PageObject_ReportParameter.Click_Rooms_Counted().Displayed)
                {
                    Logger.WriteDebugMessage("Room Counted field is clickable");
                }
                else
                    Assert.Fail("Room Counted field is Not clickable");
                Logger.WriteDebugMessage("Room Counted column get sorted");

                ReportParameter.Click_Rooms_Product();
                if (PageObject_ReportParameter.Click_Rooms_Product().Displayed)
                {
                    Logger.WriteDebugMessage("Room Product field is clickable");
                }
                else
                    Assert.Fail("Room Product field is Not clickable");
                Logger.WriteDebugMessage("Room Product column get sorted");

                ReportParameter.Click_Business_Unit();
                if (PageObject_ReportParameter.Click_Business_Unit().Displayed)
                {
                    Logger.WriteDebugMessage("Business Unit field is clickable");
                }
                else
                    Assert.Fail("Business Unit field is Not clickable");
                Logger.WriteDebugMessage("Business Unit column get sorted");
                Helper.ExitFrame();               

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_RainMaker();
                Logger.WriteDebugMessage("Rainmaker menu drop down displayed");
                Navigation.Click_Market_Mapping();
                Logger.WriteDebugMessage("User landed on Market mapping Page");
                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Mapping());
                ReportParameter.Rainmaker_Hotel_Dropdown();
                Logger.WriteDebugMessage("Hotel Drop down displayed");
                ReportParameter.Rainmaker_Hotel_Value();
                Logger.WriteDebugMessage("Hotel is selected as Atlantis, The Palm");
                ReportParameter.Click_PMS_Market_Code();
                if (PageObject_ReportParameter.Click_PMS_Market_Code().Displayed)
                {
                    Logger.WriteDebugMessage("PMS Market code field is clickable");
                }
                else
                    Assert.Fail("PMS Market code field is Not clickable");
                Logger.WriteDebugMessage("PMS market code column get sorted");

                ReportParameter.Click_revintel_Market_1();
                if (PageObject_ReportParameter.Click_revintel_Market_1().Displayed)
                {
                    Logger.WriteDebugMessage("RenIntel Market field is clickable");
                }
                else
                    Assert.Fail("RenIntel Market field is Not clickable");
                Logger.WriteDebugMessage("RevIntel Market  column get sorted");

                //Verify filter functinality for RevIntel Market
                ReportParameter.Enter_Market_Name("Group");
                Logger.WriteDebugMessage("Posting is entered in Revintel market field");
                ReportParameter.Click_Filter_Icon_Market_Name();
                ReportParameter.Filter_with_statsWith();
                Logger.WriteDebugMessage("Filtered Room type Name with statswith filter");
                Helper.VerifyTextOnPageAndHighLight("Group");

                ReportParameter.Click_revintel_Market_2();
                if (PageObject_ReportParameter.Click_revintel_Market_2().Displayed)
                {
                    Logger.WriteDebugMessage("RenIntel Market field is clickable");
                }
                else
                    Assert.Fail("RenIntel Market field is Not clickable");
                Logger.WriteDebugMessage("RevIntel Market column get sorted");
                Helper.ExitFrame();

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_RainMaker();
                Logger.WriteDebugMessage("Rainmaker menu drop down displayed");
                Navigation.Click_Channel_Mapping();
                Logger.WriteDebugMessage("User landed on Channel mapping Page");
                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Channel_Mapping());
                ReportParameter.Rainmaker_Hotel_Dropdown();
                Logger.WriteDebugMessage("Hotel Drop down displayed");
                ReportParameter.Rainmaker_Hotel_Value();
                Logger.WriteDebugMessage("Hotel is selected as Atlantis, The Palm");
                ReportParameter.Click_PMS_Channel_Code();
                if (PageObject_ReportParameter.Click_PMS_Channel_Code().Displayed)
                {
                    Logger.WriteDebugMessage("PMS channel code field is clickable");
                }
                else
                    Assert.Fail("PMS channel code field is Not clickable");
                Logger.WriteDebugMessage("PMS channel code column get sorted");

                ReportParameter.Click_revintel_Channel_1();
                if (PageObject_ReportParameter.Click_revintel_Channel_1().Displayed)
                {
                    Logger.WriteDebugMessage("Revintel channel 1 code field is clickable");
                }
                else
                    Assert.Fail("Revintel channel 1 field is Not clickable");
                Logger.WriteDebugMessage("RevIntel channel  column get sorted");

                //Verify filter functinality for RevIntel channel
                ReportParameter.Enter_Channel_Name("Point of Sale");
                Logger.WriteDebugMessage("Point of Sale is entered in Revintel channel field");
                ReportParameter.Click_Filter_Icon_Channel_Name();
                ReportParameter.Filter_with_statsWith();
                Logger.WriteDebugMessage("Filtered channel Name with statswith filter");
                Helper.VerifyTextOnPageAndHighLight("Point of Sale");


                ReportParameter.Click_revintel_Channel_2();
                if (PageObject_ReportParameter.Click_revintel_Channel_2().Displayed)
                {
                    Logger.WriteDebugMessage("Revintel channel 2 field is clickable");
                }
                else
                    Assert.Fail("Revintel channel 2 field is Not clickable");
                Logger.WriteDebugMessage("RevIntel channel column get sorted");
                Helper.ExitFrame();

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_RainMaker();
                Logger.WriteDebugMessage("Rainmaker menu drop down displayed");
                Navigation.Click_Business_Unit_Grouping();
                Logger.WriteDebugMessage("User landed on Business Unit Grouping  Page");
                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Business_Unit_Grouping());
                ReportParameter.Click_Business_Unit_Group_Sort();
                if (PageObject_ReportParameter.Click_Business_Unit_Group_Sort().Displayed)
                {
                    Logger.WriteDebugMessage("Buisness Unit group field is clickable");
                }
                else
                    Assert.Fail("Buisness Unit group field is Not clickable");
                Logger.WriteDebugMessage("Business Unit group column sorted");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }

        //RainMaker | Business Unit - Verify the addition deletion and modification of Business Unit group
        public static void TC_254238()
        {
            if (TestCaseId == Utility.Constants.TC_254238)
            {
                //Pre-Requisite
                string password, username, environment,client;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");

                Logger.WriteInfoMessage("Test Case : Verify the addition deletion and modification of Business Unit group");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_RainMaker();
                Logger.WriteDebugMessage("Rainmaker menu drop down displayed");
                Navigation.Click_Business_Unit_Grouping();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Business Unit group Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Business_Unit_Grouping());

                //Required field Validation
                Navigation.Click_Add_New_Business_Unit_Group();
                Logger.WriteDebugMessage("Add Business Unit Group Pop up displayed");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Add_Business_Unit_Group());             
                ReportParameter.Enter_Business_Unit_Grouping_Code("TTT");
                Logger.WriteDebugMessage("TTT Enter as Business Unit Grouping code");
                ReportParameter.Enter_Business_Unit_Grouping_Name("Kerzner-D");
                Logger.WriteDebugMessage("Kerzner-D Enter as Business Unit Grouping Name");
                ReportParameter.Click_Business_Unit_Grouping_TransferAllFrom_Button();
                ReportParameter.Saved_Business_Unit_Grouping();
                Logger.WriteDebugMessage("Business Unit Grouping got saved successfully");
                Helper.VerifyTextOnPage("Kerzner-D");
                Logger.WriteDebugMessage("Added Business Unit group displayed");
                Helper.ExitFrame();

                //update of Business unit group  Name 
                ReportParameter.Click_Edit_Business_Unit_Grouping_button();
                Logger.WriteDebugMessage("Landed on List Business Units pop up");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Add_Business_Unit_Group());

                ReportParameter.Enter_Business_Unit_Grouping_Code("TTT-Updated");
                Logger.WriteDebugMessage("TTT-Updated Enter as Business Unit Grouping code");
                ReportParameter.Enter_Business_Unit_Grouping_Name("Kerzner-D-Updated");
                Logger.WriteDebugMessage("Kerzner-D-Updated Enter as Business Unit Grouping Name");
                ReportParameter.Saved_Business_Unit_Grouping();
                Logger.WriteDebugMessage("Updated Business Unit Grouping got saved successfully");
                Helper.VerifyTextOnPage("Kerzner-D-Updated");
                Logger.WriteDebugMessage("Updated Business Unit group displayed");
                Helper.ExitFrame();

                //Delete of Business unit group  Name 
                ReportParameter.Delete_Business_Unit_Grouping_button();
                Logger.WriteDebugMessage("Business Unit group got deleted");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }

        //Rainmaker Menu | Business Unit - Verify no duplicate classification name or code is allowed
        public static void TC_254239()
        {
            if (TestCaseId == Utility.Constants.TC_254239)
            {
                //Pre-Requisite
                string password, username, Column, environment, Portfolio_value, Portfolio_Name_Date, Hotel, Total_Occupied, Total_Adults, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Daily Analysis PerPerson", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_Date");
                Total_Adults = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Adults");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Total_Occupied = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Occupied");

                Logger.WriteInfoMessage("Test Case : Validate the Daily Analysis with Sleeper Data");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Time_Period_Menu();
                Logger.WriteDebugMessage("Time Period menu drop down displayed");
                Navigation.Click_Daily_Analysis_PerPerson_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Daily Analysis PerPerson report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Daily_Analysis_PerPerson_Report());

                //Required field Validation
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Click_View_Analysis();
                VerifyTextOnPageAndHighLight("Required");
                Logger.WriteDebugMessage("Required field validation message is displaying");

                //Report with Required Field
                ReportParameter.Enter_startDate_EndDate(startDate, enddate);
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name = tt.GetCellData(Worksheetname, 2, 1);
                    if (Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;

                    for (int ColumnNumber = 11; ColumnNumber < 14; ColumnNumber++)
                    {
                        Column = TestData.ExcelData.TestDataReader.ReadData(ColumnNumber, "Column");
                        string Actual_column = tt.GetCellData(Worksheetname, ColumnNumber, 9);
                        if (Column.Contains(Actual_column))
                            Logger.WriteDebugMessage(Column + " display next to Vacant Rooms in the middle section of the report");
                        else
                            Assert.Fail("Report not matched");
                    }
                }
                Helper.ReloadPage();
                /*validate report with one filter*/
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Time_Period_Menu();
                Logger.WriteDebugMessage("Time Period menu drop down displayed");
                Navigation.Click_Daily_Analysis_PerPerson_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Daily Analysis PerPerson report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Daily_Analysis_PerPerson_Report());

                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(40000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; ");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_stay = hh.GetCellData(Worksheetname, 2, 3);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteInfoMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Adults = at.GetCellData(Worksheetname, 17, 42);
                    if (Adults.Contains(Total_Adults))
                        Logger.WriteInfoMessage(Total_Adults + " matched with total Adults under Sleepers section");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Time_Period_Menu();
                Logger.WriteDebugMessage("Time Period menu drop down displayed");
                Navigation.Click_Daily_Analysis_PerPerson_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Daily Analysis PerPerson report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Daily_Analysis_PerPerson_Report());

                ReportParameter.HotelorPortfolio_Dropdown_Arrow();
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(Hotel + " is selected as Hotel");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter2_value + "selected for Room Product");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Occupied = ll.GetCellData(Worksheetname, 9, 42);
                    if (Occupied.Contains(Total_Occupied))
                        Logger.WriteInfoMessage(Total_Occupied + " matched with total Occupied value under Occupied Rooms section");
                    else
                        scenario3 = false;

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                if (scenario1 == false) Assert.Fail("Report with mandatory field is fail");
                else Logger.WriteInfoMessage("Scenario 1 : Report with mandatory field is Pass");

                if (scenario2 == false) Assert.Fail("Report with one filter is fail");
                else Logger.WriteInfoMessage("Scenario 2 : Report with one filter is Pass");

                if (scenario3 == false) Assert.Fail("Report with  multiple filter is fail");
                else Logger.WriteInfoMessage("Scenario 3 : Report with multiple filter is Pass");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_endDate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_Date", Portfolio_Name_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Adults", Total_Adults);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario3_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Occupied", Total_Occupied, true);
            }
        }

    }
}

