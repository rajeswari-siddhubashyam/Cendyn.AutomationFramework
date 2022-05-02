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
        //Validate the Room type Analysis
        public static void TC_252847()
        {
            if (TestCaseId == Utility.Constants.TC_252847)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Portfolio_Name_Date, Hotel, Prior_Revenue, Current_Year_Room_Sold, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Room Type Analysis", reportName;
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
                Current_Year_Room_Sold = TestData.ExcelData.TestDataReader.ReadData(1, "Current_Year_Room_Sold");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Prior_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Prior_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Room type Analysis");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Room Type menu drop down displayed");
                Navigation.Click_Room_Type_Analysis_Report();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Room Type Analysis Report Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Analysis_Report());

                //Required field Validation
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Click_View_Analysis();
                VerifyTextOnPageAndHighLight("Required");
                Logger.WriteDebugMessage("Required field validation message is displaying");

                //verify that the "Expand Level" drop down filter functions properly
                if (PageObject_ReportParameter.Market_Report_Expand_Level().Displayed)
                {
                    Logger.WriteDebugMessage("Expand Level Field Displayed");
                }
                else
                    Assert.Fail("Expand Level Field Is missing");

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
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Room Type menu drop down displayed");
                Navigation.Click_Room_Type_Analysis_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Room Type Analysis Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Analysis_Report());

                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
                Helper.ScrollToText("View Analysis");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
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
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 3);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteDebugMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Room = at.GetCellData(Worksheetname, 4, 91);
                    if (Room.Contains(Current_Year_Room_Sold))
                        Logger.WriteDebugMessage(Current_Year_Room_Sold + " matched with RoomSold under Current Year section");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Room Type menu drop down displayed");
                Navigation.Click_Room_Type_Analysis_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Room Type Analysis Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Analysis_Report());

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
                Helper.ScrollToText("View Analysis");
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
                    string Revenue = ll.GetCellData(Worksheetname, 11, 32);
                    if (Revenue.Contains(Prior_Revenue))
                        Logger.WriteDebugMessage(Prior_Revenue + " matched with total ADR under Compairson Year section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current_Year_Room_Sold", Current_Year_Room_Sold);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario3_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Prior_Revenue", Prior_Revenue, true);
            }
        }

        //Validate the Room Type and Up Grade Statistics
        public static void TC_252848()
        {
            if (TestCaseId == Utility.Constants.TC_252848)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Portfolio_Name_Date, Hotel, Total_No_Rooms, No_Rooms, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Room Type and Up Grade Statisti", reportName;
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
                Total_No_Rooms = TestData.ExcelData.TestDataReader.ReadData(1, "Total_No_Rooms");

                Logger.WriteInfoMessage("Test Case : Validate the Room Type and Up Grade Statistics");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Room Type menu drop down displayed");
                Navigation.Click_Room_Type_and_Up_Grade_Statistics_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Room Type and Up Grade Statistics Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_and_Up_Grade_Statistics_Report());

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
                    string Name = tt.GetCellData(Worksheetname, 1, 2);
                    if (Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;
                }
                Helper.ReloadPage();
                /*validate report with one filter*/
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Room Type menu drop down displayed");
                Navigation.Click_Room_Type_and_Up_Grade_Statistics_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Room Type and Up Grade Statistics Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_and_Up_Grade_Statistics_Report());

                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(40000);
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
                    string Room = at.GetCellData(Worksheetname, 4, 21);
                    if (Room.Contains(No_Rooms))
                        Logger.WriteDebugMessage(No_Rooms + " matched with Room for Marina Mountain View");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Room Type menu drop down displayed");
                Navigation.Click_Room_Type_and_Up_Grade_Statistics_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Room Type and Up Grade Statistics Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_and_Up_Grade_Statistics_Report());

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
                Helper.AddDelay(30000);
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
                    string total_room = ll.GetCellData(Worksheetname, 4, 102);
                    if (total_room.Contains(Total_No_Rooms))
                        Logger.WriteDebugMessage(Total_No_Rooms + " matched with total ADR under Compairson Year section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_No_Rooms", Total_No_Rooms, true);
            }
        }

        //Validate the Booked Room Materialization
        public static void TC_252849()
        {
            if (TestCaseId == Utility.Constants.TC_252849)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Portfolio_Name_Date, Hotel, Total_No_Rooms, No_Rooms, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Booked Room Materialization", reportName;
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
                Total_No_Rooms = TestData.ExcelData.TestDataReader.ReadData(1, "Total_No_Rooms");

                Logger.WriteInfoMessage("Test Case : Validate the Room Type and Up Grade Statistics");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Room Type menu drop down displayed");
                Navigation.Click_Booked_Room_Materialization_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Booked Room Materialization Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Booked_Room_Materialization_Report());

                //Required field Validation
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
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Room Type menu drop down displayed");
                Navigation.Click_Booked_Room_Materialization_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Booked Room Materialization Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Booked_Room_Materialization_Report());

                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
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

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Room = at.GetCellData(Worksheetname,4, 176);
                    if (Room.Contains(No_Rooms))
                        Logger.WriteDebugMessage(No_Rooms + " matched with Room for Marina Mountain View");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Room Type menu drop down displayed");
                Navigation.Click_Booked_Room_Materialization_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Booked Room Materialization Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Booked_Room_Materialization_Report());

                ReportParameter.HotelorPortfolio_Dropdown_Arrow();
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(Hotel + "is selected as Hotel");
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
                Helper.AddDelay(30000);
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
                    string total_room = ll.GetCellData(Worksheetname, 4, 42);
                    if (total_room.Contains(Total_No_Rooms))
                        Logger.WriteDebugMessage(Total_No_Rooms + " matched with total ADR under Compairson Year section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_No_Rooms", Total_No_Rooms, true);
            }
        }

        //Validate the Detailed Room Type Availability
        public static void TC_252850()
        {
            if (TestCaseId == Utility.Constants.TC_252850)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Portfolio_Name_Date, Hotel, Thr_Total, Total, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Detailed Room Type Availability", reportName;
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
                Total = TestData.ExcelData.TestDataReader.ReadData(1, "Total");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Thr_Total = TestData.ExcelData.TestDataReader.ReadData(1, "Thr_Total");

                Logger.WriteInfoMessage("Test Case : Validate the Detailed Room Type Availability");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Room Type menu drop down displayed");
                Navigation.Click_Detailed_Room_Type_Availability_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Detailed Room Type Availability Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Detailed_Room_Type_Availability_Report());

                //Required field Validation
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
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Room Type menu drop down displayed");
                Navigation.Click_Detailed_Room_Type_Availability_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Booked Room Materialization Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Detailed_Room_Type_Availability_Report());

                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
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
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 2);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteInfoMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Tot = at.GetCellData(Worksheetname, 4, 40);
                    if (Tot.Contains(Total))
                        Logger.WriteInfoMessage(Total + " matched with total for 1/31/2020");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Room Type menu drop down displayed");
                Navigation.Click_Detailed_Room_Type_Availability_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Detailed Room Type Avaiability Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Detailed_Room_Type_Availability_Report());

                ReportParameter.HotelorPortfolio_Dropdown_Arrow();
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(Hotel + "is selected as Hotel");
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
                    string Thr = ll.GetCellData(Worksheetname, 4, 11);
                    if (Thr.Contains(Thr_Total))
                        Logger.WriteInfoMessage(Thr_Total + " matched with total for 1/2/2020");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total", Total);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario3_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Thr_Total", Thr_Total, true);
            }
        }

    }
}

