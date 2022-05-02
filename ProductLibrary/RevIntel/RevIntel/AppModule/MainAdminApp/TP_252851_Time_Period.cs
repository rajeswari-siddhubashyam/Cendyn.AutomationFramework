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
        //Validate the Annual Trends Analysis
        public static void TC_252852()
        {
            if (TestCaseId == Utility.Constants.TC_252852)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Portfolio_Name_Date, Hotel, Total_In_House_Reservation_2017, Total_2020, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Annual Trends", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_Date");
                Total_2020 = TestData.ExcelData.TestDataReader.ReadData(1, "Total_2020");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Total_In_House_Reservation_2017 = TestData.ExcelData.TestDataReader.ReadData(1, "Total_In_House_Reservation_2017");

                Logger.WriteInfoMessage("Test Case : Validate the Annual Trends Analysis");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Time_Period_Menu();
                Logger.WriteDebugMessage("Time Period menu drop down displayed");
                Navigation.Click_Annual_Trends_Report();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Annual Trends Report Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Annual_Trends_Report());

                //Select Currency and Hotel
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);

                //Required field Validation
                ReportParameter.Click_View_Analysis();
                VerifyTextOnPageAndHighLight("Required");
                Logger.WriteDebugMessage("Required field validation message is displaying");

                //Report with Required Field
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(60000);
                Logger.WriteDebugMessage("Report generated");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name = tt.GetCellData(Worksheetname, 2, 2);
                    if (Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;
                }
                Helper.ReloadPage();

                /*validate report with one filter*/
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Time_Period_Menu();
                Logger.WriteDebugMessage("Time Period menu drop down displayed");
                Navigation.Click_Annual_Trends_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Annual Trends Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Annual_Trends_Report());

                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; Central Africa; Sao Tome and Principe; Cameroon; ");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 4);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteDebugMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Total = at.GetCellData(Worksheetname, 5, 16);
                    if (Total.Contains(Total_2020))
                        Logger.WriteDebugMessage(Total_2020 + " matched with RoomSold under Current Year section");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Time_Period_Menu();
                Logger.WriteDebugMessage("Time Period menu drop down displayed");
                Navigation.Click_Annual_Trends_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Annual Trends Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Annual_Trends_Report());

                ReportParameter.HotelorPortfolio_Dropdown_Arrow();
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(Hotel + "is selected as Hotel");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; Central Africa; Sao Tome and Principe;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string In_House_Reservation = ll.GetCellData(Worksheetname, 6, 26);
                    if (In_House_Reservation.Contains(Total_In_House_Reservation_2017))
                        Logger.WriteDebugMessage(Total_In_House_Reservation_2017 + " matched with Call Center / In House Reservation section for 2017");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_2020", Total_2020);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario3_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_In_House_Reservation_2017", Total_In_House_Reservation_2017, true);
            }
        }

        //Validate the Daily Analysis
        public static void TC_252853()
        {
            if (TestCaseId == Utility.Constants.TC_252853)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Column, Portfolio_Name_Date, Hotel, Total_Vacant_Rooms, Total_Individual, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Daily Analysis", reportName;
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
                Total_Individual = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Individual");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Total_Vacant_Rooms = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Vacant_Rooms");
                Column = TestData.ExcelData.TestDataReader.ReadData(1, "Column");

                Logger.WriteInfoMessage("Test Case : Validate the Daily Analysis");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Time_Period_Menu();
                Logger.WriteDebugMessage("Time Period menu drop down displayed");
                Navigation.Click_Daily_Analysis_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Daily Analysis Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Daily_Analysis_Report());

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
                Navigation.Click_Daily_Analysis_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Daily Analysis Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Daily_Analysis_Report());

                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected as Room Product");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(40000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Room Product: Room; Arabian Court Deluxe Rooms;");
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
                        Logger.WriteDebugMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Individual = at.GetCellData(Worksheetname, 6, 42);
                    if (Individual.Contains(Total_Individual))
                        Logger.WriteDebugMessage(Total_Individual + " matched with Total Individual");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Time_Period_Menu();
                Logger.WriteDebugMessage("Time Period menu drop down displayed");
                Navigation.Click_Daily_Analysis_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Daily Analysis Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Daily_Analysis_Report());

                ReportParameter.HotelorPortfolio_Dropdown_Arrow();
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(Hotel + " is selected as Hotel");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage(parameter1_value + "Selected as Room Product");
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Room Product: Room;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Vacant_Rooms = ll.GetCellData(Worksheetname, 10, 42);
                    if (Vacant_Rooms.Contains(Total_Vacant_Rooms))
                        Logger.WriteDebugMessage(Total_Vacant_Rooms + " matched with Vacant_Rooms");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Individual", Total_Individual);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario3_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Vacant_Rooms", Total_Vacant_Rooms, true);
            }
        }

        //Validate the Day of Week Statistics
        public static void TC_252854()
        {
            if (TestCaseId == Utility.Constants.TC_252854)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Portfolio_Name_Date, Hotel, Total_Room_Revenue, No_Rooms, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Day of Week Statistics", reportName;
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
                No_Rooms = TestData.ExcelData.TestDataReader.ReadData(1, "No_Rooms");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Total_Room_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Room_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Day of Week Statistics");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Time_Period_Menu();
                Logger.WriteDebugMessage("Time Period menu drop down displayed");
                Navigation.Click_Day_of_Week_Statistics_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Day of Week Statistics Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Day_of_Week_Statistics_Report());

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
                    string Name = tt.GetCellData(Worksheetname, 1, 2);
                    if (Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;
                }
                Helper.ReloadPage();
                /*validate report with one filter*/
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Time_Period_Menu();
                Logger.WriteDebugMessage("Time Period menu drop down displayed");
                Navigation.Click_Day_of_Week_Statistics_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Day of Week Statistics Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Day_of_Week_Statistics_Report());

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
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 4);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteDebugMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Room = at.GetCellData(Worksheetname, 7, 106);
                    if (Room.Contains(No_Rooms))
                        Logger.WriteDebugMessage(No_Rooms + " matched with Room for Sunday");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Time_Period_Menu();
                Logger.WriteDebugMessage("Time Period menu drop down displayed");
                Navigation.Click_Day_of_Week_Statistics_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Day of Week Statistics Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Day_of_Week_Statistics_Report());

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
                Logger.WriteDebugMessage("Channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage(parameter1_value + "Selected as channel");
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Market");
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
                    string Room_Revenue = ll.GetCellData(Worksheetname, 22, 25);
                    if (Room_Revenue.Contains(Total_Room_Revenue))
                        Logger.WriteDebugMessage(Total_Room_Revenue + " matched with total Room Revenue section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_No_Rooms", No_Rooms);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario3_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Room_Revenue", Total_Room_Revenue, true);
            }
        }

        //Validate the Day of Week Analysis
        public static void TC_252855()
        {
            if (TestCaseId == Utility.Constants.TC_252855)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Portfolio_Name_Date, Hotel, Total_Room_PriorYear, Total_Room_CurrentYear, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Day of Week Analysis", reportName;
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
                Total_Room_CurrentYear = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Room_CurrentYear");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Total_Room_PriorYear = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Room_PriorYear");

                Logger.WriteInfoMessage("Test Case : Validate the Day of Week Analysis");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Time_Period_Menu();
                Logger.WriteDebugMessage("Time Period menu drop down displayed");
                Navigation.Click_Day_of_Week_Analysis_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Day of Week Analysis Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Day_of_Week_Analysis_Report());

                //Required field Validation
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Click_View_Analysis();
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
                    string Name = tt.GetCellData(Worksheetname, 1, 1);
                    if (Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;
                }
                Helper.ReloadPage();
                /*validate report with one filter*/
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Time_Period_Menu();
                Logger.WriteDebugMessage("Time Period menu drop down displayed");
                Navigation.Click_Day_of_Week_Analysis_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Day of Week Analysis Page Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Day_of_Week_Analysis_Report());

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
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 3);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteInfoMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Room_CurrentYear = at.GetCellData(Worksheetname, 18, 1021);
                    if (Room_CurrentYear.Contains(Total_Room_CurrentYear))
                        Logger.WriteInfoMessage(Total_Room_CurrentYear + " matched with total for 1/31/2020");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Time_Period_Menu();
                Logger.WriteDebugMessage("Time Period menu drop down displayed");
                Navigation.Click_Day_of_Week_Analysis_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Day of Week Analysis Page Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Day_of_Week_Analysis_Report());

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
                    string Room_PriorYear = ll.GetCellData(Worksheetname, 18, 2054);
                    if (Room_PriorYear.Contains(Total_Room_PriorYear))
                        Logger.WriteInfoMessage(Total_Room_PriorYear + " matched with total Room for Prior year");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Room_CurrentYear", Total_Room_CurrentYear);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario3_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Room_PriorYear", Total_Room_PriorYear, true);
            }
        }

        //Validate the Monthly Summary (RHBI)
        public static void TC_252856()
        {
            if (TestCaseId == Utility.Constants.TC_252856)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Portfolio_Name_Date, Hotel, Total_Actuals_OTB_Room, Total_Actuals_OTB_RevPAR, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Monthly Summary", reportName;
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
                Total_Actuals_OTB_RevPAR = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Actuals_OTB_RevPAR");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Total_Actuals_OTB_Room = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Actuals_OTB_Room");

                Logger.WriteInfoMessage("Test Case : Validate the Monthly Summary (RHBI)");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Time_Period_Menu();
                Logger.WriteDebugMessage("Time Period menu drop down displayed");
                Navigation.Click_Monthly_Summary_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Monthly Summary Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Monthly_Summary_Report());

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
                    string Name = tt.GetCellData(Worksheetname, 1, 1);
                    if (Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;
                }
                Helper.ReloadPage();
                /*validate report with one filter*/
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Time_Period_Menu();
                Logger.WriteDebugMessage("Time Period menu drop down displayed");
                Navigation.Click_Monthly_Summary_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Monthly Summary Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Monthly_Summary_Report());

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
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 3);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteInfoMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Actuals_OTB_RevPAR = at.GetCellData(Worksheetname, 3, 19);
                    if (Actuals_OTB_RevPAR.Contains(Total_Actuals_OTB_RevPAR))
                        Logger.WriteInfoMessage(Total_Actuals_OTB_RevPAR + " matched with total RevPAR for Actuals/OTB");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Time_Period_Menu();
                Logger.WriteDebugMessage("Time Period menu drop down displayed");
                Navigation.Click_Monthly_Summary_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Monthly Summary Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Monthly_Summary_Report());

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
                    string Actuals_OTB_Room = ll.GetCellData(Worksheetname, 3, 16);
                    if (Actuals_OTB_Room.Contains(Total_Actuals_OTB_Room))
                        Logger.WriteInfoMessage(Total_Actuals_OTB_Room + " matched with total Rooms for Actuals/OTA section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Actuals_OTB_RevPAR", Total_Actuals_OTB_RevPAR);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario3_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Actuals_OTB_Room", Total_Actuals_OTB_Room, true);
            }
        }

        //Validate the Daily Analysis with Sleeper Data
        public static void TC_252857()
        {
            if (TestCaseId == Utility.Constants.TC_252857)
            {
                //Pre-Requisite
                string password, username, Column,environment, Portfolio_value, Portfolio_Name_Date, Hotel, Total_Occupied, Total_Adults, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Daily Analysis PerPerson", reportName;
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

