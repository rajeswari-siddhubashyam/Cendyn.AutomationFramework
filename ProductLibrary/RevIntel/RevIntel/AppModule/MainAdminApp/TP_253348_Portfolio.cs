using BaseUtility.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using RevIntel.AppModule.UI;
using RevIntel.PageObject.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevIntel.AppModule.MainAdminApp
{
    public partial class MainAdminApp : RevIntel.Utility.Setup
    {
        //Validate the Portfolio Report
        public static void TC_253349()
        {
            try
            {
                if (TestCaseId == Utility.Constants.TC_253349)
                {
                    //Pre-Requisite
                    string password, username, environment, Portfolio_value, reportName_stay, PriorYear_Total_Revenue, Budget_total_ADR, parameter2_value, parameter2, Currency, Business_Unit, client, hotel, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Portfolio Report", reportName;
                    bool scenario1 = true, scenario2 = true, scenario3 = true;

                    //Retrieve data from Database or testdata file
                    username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                    password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                    client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                    environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                    Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                    Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                    Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                    startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                    enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                    parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                    parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                    reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                    reportName_stay = TestData.ExcelData.TestDataReader.ReadData(1, "reportName_stay");
                    Budget_total_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "Budget_total_ADR");
                    parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                    parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                    PriorYear_Total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "PriorYear_Total_Revenue");

                    Logger.WriteInfoMessage("Test Case : Validate the Portfolio Report");

                    //Enter Email address and password
                    Login.Frontend_SignIn(username, password);

                    //Select Client 
                    Navigation.Select_Client(client);

                    Helper.AddDelay(7000); // Change

                    //Navigate to Portfolio report
                    Navigation.Click_Menu_Portfolio();
                    Logger.WriteDebugMessage("Portfolio Drop down displayed");
                    Navigation.Click_Portfolio_Report();
                    Navigation.Portfolio();
                    Logger.WriteDebugMessage("User landed on Portfolio page");
                    Helper.AddDelay(10000);

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Portfolio());

                    //verify Hotel section For Portfolio report
                    ReportParameter.Hotel_Selection_DDL();

                    //Verify filters on Portfolio page
                    ReportParameter.Portfolio_reports_filters();

                    //Required field validation
                    ReportParameter.Click_View_Analysis();
                    Logger.WriteDebugMessage("validation message displayed for required field");

                    //Enter mandatory field and generate report
                    ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                    Helper.ScrollToText("View Analysis");
                    ReportParameter.Click_View_Analysis();
                    Helper.AddDelay(30000);
                    Logger.WriteDebugMessage("Report generated");
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
                    /*validate report with one filter*/
                    //Navigate to Portfolio report
                    Helper.ReloadPage();
                    Navigation.Click_Menu_Portfolio();
                    Logger.WriteDebugMessage("Portfolio Drop down displayed");
                    Navigation.Click_Portfolio_Report();
                    Navigation.Portfolio();
                    Helper.AddDelay(5000);
                    Logger.WriteDebugMessage("User landed on Portfolio page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Portfolio());

                    //Report with one parameter
                    ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                    ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                    ReportParameter.Select_SourceMarket_DDL();
                    Logger.WriteDebugMessage("Source Market drop down displayed");
                    ReportParameter.Select_SourceMarket_value();
                    Logger.WriteDebugMessage(parameter1_value + "Selected as source market");

                    Helper.ScrollToElement(PageObject_ReportParameter.Click_View_Analysis());
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
                        string Name_stay = hh.GetCellData(Worksheetname, 1, 3);
                        if (Name_stay.Contains(reportName_stay))
                            Logger.WriteDebugMessage(reportName_stay + " matched with Report name ");
                        else
                            Assert.Fail("Report name and stay not matched");

                        TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                        string Budget_ADR = at.GetCellData(Worksheetname, 10, 25);
                        if (Budget_ADR.Contains(Budget_total_ADR))
                            Logger.WriteDebugMessage(Budget_total_ADR + " matched with total ADR under Budget section");
                        else
                            scenario2 = false;
                    }
                    //Report with Multiple filter and excel column validation 
                    Helper.ReloadPage();
                    Navigation.Click_Menu_Portfolio();
                    Logger.WriteDebugMessage("Portfolio Drop down displayed");
                    Navigation.Click_Portfolio_Report();
                    Navigation.Portfolio();
                    Helper.AddDelay(5000);
                    Logger.WriteDebugMessage("User landed on Portfolio page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Portfolio());

                    ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                    ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
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
                    Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; Central Africa; Sao Tome and Principe; Cameroon; Central African Republic;");
                    Logger.WriteDebugMessage("Applied filter displayed at footer");
                    if (client == "Kerzner")
                    {
                        //Verify Data in export document and in front end 
                        ReportParameter.Report_Excel_Format();

                        FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                        Filename = ReportParameter.VerifyFileFormate(FilePath);
                        FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                        TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                        string Total_Revenue = ll.GetCellData(Worksheetname, 14, 36);
                        if (Total_Revenue.Contains(PriorYear_Total_Revenue))
                            Logger.WriteDebugMessage(PriorYear_Total_Revenue + " matched with total ADR under Budget section");
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
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1", parameter1);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1_value", parameter1_value);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName_stay", reportName_stay);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Budget_total_ADR", Budget_total_ADR);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2", parameter2);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2_value", parameter2_value);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PriorYear_Total_Revenue", PriorYear_Total_Revenue, true);
                }
            }
            catch(Exception e) { }
        }

        //Validate the Agent By Hotel
        public static void TC_253350()
        {
            if (TestCaseId == Utility.Constants.TC_253350)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Column, reportName_stay, total_Rooms, parameter2_value, parameter2, Currency, Business_Unit, client, hotel, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Agent By Hotel", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportName_stay = TestData.ExcelData.TestDataReader.ReadData(1, "reportName_stay");
                total_Rooms = TestData.ExcelData.TestDataReader.ReadData(1, "total_Rooms");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");

                Logger.WriteInfoMessage("Test Case : Validate the Agent By Hotel");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Portfolio report
                Navigation.Click_Menu_Portfolio();
                Navigation.Agent_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Agent By Hotel page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Agent_By_Hotel());

                //verify Hotel section For Portfolio report
                ReportParameter.Hotel_Selection_DDL();

                //Verify filters on Portfolio page
                ReportParameter.Portfolio_reports_filters();
                if (client == "Kerzner")
                {
                    //Required field validation
                    ReportParameter.Required_Field_Validation();

                    //Enter mandatory field and generate report
                    ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);                   
                    ReportParameter.Click_View_Analysis();
                    Helper.AddDelay(30000);
                    Logger.WriteDebugMessage("Report generated");

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
                /*validate report with one filter*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Navigation.Click_Menu_Portfolio();
                Navigation.Agent_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Agent By Hotel report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Agent_By_Hotel());

                //Enter mandatory field and generate report
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected as for channel");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; Front Office Direct; Government; Option Booking; Room Reservation Direct");
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
                    if (Name_stay.Contains(reportName_stay))
                        Logger.WriteDebugMessage(reportName_stay + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Rooms = at.GetCellData(Worksheetname, 6, 338);
                    if (Rooms.Contains(total_Rooms))
                        Logger.WriteDebugMessage(total_Rooms + " matched with Total Rooms");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage(); 
                Navigation.Click_Menu_Portfolio();
                Navigation.Agent_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(500);
                Logger.WriteDebugMessage("User landed on Agent By Hotel page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Agent_By_Hotel());

                //Enter mandatory field and generate report
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage(parameter1_value + "Selected for channel");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter2_value + "selected for Room product");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; Front Office Direct; Government; Option Booking; Room Reservation Direct");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));
                    TestData.ExcelData.ExcelDataReader aa = new TestData.ExcelData.ExcelDataReader(FullPath);

                    for (int ColumnNumber = 4; ColumnNumber < 7; ColumnNumber++)
                    {
                        Column = TestData.ExcelData.TestDataReader.ReadData(ColumnNumber, "Column");
                        string column_Actual = aa.GetCellData(Worksheetname, ColumnNumber, 8);
                        if (Column.Contains(column_Actual))
                            Logger.WriteDebugMessage(Column + " column display");
                        else
                            scenario3 = false;
                    }

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                if (scenario1 == false) Assert.Fail("Report with mandatory field is fail");
                else Logger.WriteDebugMessage("Scenario 1 : Report with mandatory field is Pass");

                if (scenario2 == false) Assert.Fail("Report with one filter is fail");
                else Logger.WriteDebugMessage("Scenario 2 : Report with one filter is Pass");

                if (scenario3 == false) Assert.Fail("Report with  multiple filter is fail");
                else Logger.WriteDebugMessage("Scenario 3 : Report with multiple filter is Pass");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName_stay", reportName_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_Rooms", total_Rooms);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2_value", parameter2_value, true);


                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        //Validate the Channel By Hotel Report
        public static void TC_253351()
        {
            if (TestCaseId == Utility.Constants.TC_253351)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, total_Rooms, reportName_stay, total_Occ, parameter2_value, parameter2, Currency, Business_Unit, client, hotel, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Channel By Hotel Report", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportName_stay = TestData.ExcelData.TestDataReader.ReadData(1, "reportName_stay");
                total_Occ = TestData.ExcelData.TestDataReader.ReadData(1, "total_Occ");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                total_Rooms = TestData.ExcelData.TestDataReader.ReadData(1, "total_Rooms");

                Logger.WriteInfoMessage("Test Case : Validate the Channel By Hotel Report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Portfolio report
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Channel_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("User landed on channel By Hotel page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_channel_By_Hotel());

                //verify Hotel section For Portfolio report
                ReportParameter.Hotel_Selection_DDL();

                //Verify filters on Portfolio page
                ReportParameter.Portfolio_reports_filters();

                //Required field validation
                ReportParameter.Required_Field_Validation();

                //Enter mandatory field and generate report
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
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
                /*validate report with one filter*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Channel_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(20000);
                Logger.WriteDebugMessage("User landed on channel By Hotel report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_channel_By_Hotel());

                //Enter mandatory field and generate report
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected as for channel");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(40000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; Front Office Direct; Government; Option Booking; Room Reservation Direct");
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
                    if (Name_stay.Contains(reportName_stay))
                        Logger.WriteDebugMessage(reportName_stay + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Occ = at.GetCellData(Worksheetname, 6, 42);
                    if (Occ.Contains(total_Occ))
                        Logger.WriteDebugMessage(total_Occ + " matched with Total Occ for O&O Cape Town Resort");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Channel_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("User landed on channel By Hotel page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_channel_By_Hotel());

                //Enter mandatory field and generate report
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage(parameter1_value + "Selected for channel");
                ReportParameter.Paremeter_Memberships();
                Logger.WriteDebugMessage("Membership drop down displayed");
                ReportParameter.Paremeter_Memberships_value();
                Logger.WriteDebugMessage(parameter2_value + "selected for membership");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; Front Office Direct; Government; Option Booking; Room Reservation Direct");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader aa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Rooms = aa.GetCellData(Worksheetname, 5, 41);
                    if (Rooms.Contains(total_Rooms))
                        Logger.WriteDebugMessage(total_Rooms + " matched with Report name ");
                    else
                        scenario3 = false;

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }

                if (scenario1 == false) Assert.Fail("Report with mandatory field is fail");
                else Logger.WriteDebugMessage("Scenario 1 : Report with mandatory field is Pass");

                if (scenario2 == false) Assert.Fail("Report with one filter is fail");
                else Logger.WriteDebugMessage("Scenario 2 : Report with one filter is Pass");

                if (scenario3 == false) Assert.Fail("Report with  multiple filter is fail");
                else Logger.WriteDebugMessage("Scenario 3 : Report with multiple filter is Pass");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName_stay", reportName_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_Occ", total_Occ);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_Rooms", total_Rooms, true);
            }
        }

        //Validate the Company By Hotel
        public static void TC_253352()
        {
            if (TestCaseId == Utility.Constants.TC_253352)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, total_Revenue, reportName_stay, parameter1_startdate, parameter1_enddate, total_ADR, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Company By Hotel", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_startdate = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_startdate");
                parameter1_enddate = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_enddate");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportName_stay = TestData.ExcelData.TestDataReader.ReadData(1, "reportName_stay");
                total_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "total_ADR");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "total_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Company By Hotel");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Portfolio report
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Company_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Company By Hotel page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_company_By_Hotel());

                //verify Hotel section For Portfolio report
                ReportParameter.Hotel_Selection_DDL();

                //Verify filters on Portfolio page
                ReportParameter.Portfolio_reports_filters();

                //Required field validation
                ReportParameter.Required_Field_Validation();

                //Enter mandatory field and generate report
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
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
                /*validate report with one filter*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Company_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Company By Hotel report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_company_By_Hotel());

                //Enter mandatory field and generate report
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Business_Source.BookingStartDate(parameter1_startdate);
                Business_Source.BookingEndDate(parameter1_enddate);
                Logger.WriteDebugMessage(parameter1_startdate + "Selected as Booking start date");
                Logger.WriteDebugMessage(parameter1_enddate + "Selected as Booking start date");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s): Booking Date: 7/1/2020 - 7/31/2020");
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
                    if (Name_stay.Contains(reportName_stay))
                        Logger.WriteDebugMessage(reportName_stay + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR = at.GetCellData(Worksheetname, 4, 359);
                    if (ADR.Contains(total_ADR))
                        Logger.WriteDebugMessage(total_ADR + " matched with total ADR ");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter 
                Helper.ReloadPage();
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Company_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(500);
                Logger.WriteDebugMessage("User landed on company By Hotel page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_company_By_Hotel());

                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Business_Source.BookingStartDate(parameter1_startdate);
                Business_Source.BookingEndDate(parameter1_enddate);
                Logger.WriteDebugMessage(parameter1_startdate + "Selected as Booking start date");
                Logger.WriteDebugMessage(parameter1_enddate + "Selected as Booking start date");
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Corporate();
                Logger.WriteDebugMessage(parameter2_value + "selected for market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s): Booking Date: 7/1/2020 - 7/31/2020; Market Segment: Corporate; Government / Diplomatic; Local Corporate Rate");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader aa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Revenue = aa.GetCellData(Worksheetname, 4, 112);
                    if (Revenue.Contains(total_Revenue))
                        Logger.WriteDebugMessage(total_Revenue + " matched with Report total revenue");
                    else
                        scenario3 = false;

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                if (scenario1 == false) Assert.Fail("Report with mandatory field is fail");
                else Logger.WriteDebugMessage("Scenario 1 : Report with mandatory field is Pass");

                if (scenario2 == false) Assert.Fail("Report with one filter is fail");
                else Logger.WriteDebugMessage("Scenario 2 : Report with one filter is Pass");

                if (scenario3 == false) Assert.Fail("Report with  multiple filter is fail");
                else Logger.WriteDebugMessage("Scenario 3 : Report with multiple filter is Pass");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1_startdate", parameter1_startdate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1_enddate", parameter1_enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName_stay", reportName_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_ADR", total_ADR);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_Revenue", total_Revenue, true);
            }
        }

        //Validate the Market By Hotel Report
        public static void TC_253353()
        {
            if (TestCaseId == Utility.Constants.TC_253353)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, total_Revenue, reportName_stay, parameter1_value, total_ADR, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Market By Hotel Report", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportName_stay = TestData.ExcelData.TestDataReader.ReadData(1, "reportName_stay");
                total_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "total_ADR");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "total_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Market By Hotel Report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Portfolio report
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Market_By_Hotel_Report();
                Navigation.Portfolio();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Market By Hotel report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_By_Hotel_Report());

                //verify Hotel section For Portfolio report
                ReportParameter.Hotel_Selection_DDL();

                //Verify filters on Portfolio page
                ReportParameter.Portfolio_reports_filters();

                //Required field validation
                ReportParameter.Required_Field_Validation();

                //Enter mandatory field and generate report
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
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
                    string Name = tt.GetCellData(Worksheetname, 1, 1);
                    if (Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;
                }
                /*validate report with one filter*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Market_By_Hotel_Report();
                Navigation.Portfolio(); 
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Market By Hotel Report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_By_Hotel_Report());

                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Market parameter");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s): ; Market Segment: Direct; Brand.com; Call Center / In House Reservation");
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
                    if (Name_stay.Contains(reportName_stay))
                        Logger.WriteDebugMessage(reportName_stay + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Revenue = at.GetCellData(Worksheetname, 5, 636);
                    if (Revenue.Contains(total_Revenue))
                        Logger.WriteDebugMessage(total_Revenue + " matched with Report for O&O Cape Town");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter 
                Helper.ReloadPage();
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Market_By_Hotel_Report();
                Navigation.Portfolio();
                Helper.AddDelay(1000);
                Logger.WriteDebugMessage("User landed on Market By Hotel Report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_By_Hotel_Report());

                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage(parameter1_value + "selected for market");
                Helper.ScrollToText("Room Product:");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage(parameter2_value + "selected for source market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; Central Africa;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader aa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR = aa.GetCellData(Worksheetname, 4, 135);
                    if (ADR.Contains(total_ADR))
                        Logger.WriteDebugMessage(total_ADR + " matched with Report name ");
                    else
                        scenario3 = false;

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                if (scenario1 == false) Assert.Fail("Report with mandatory field is fail");
                else Logger.WriteDebugMessage("Scenario 1 : Report with mandatory field is Pass");

                if (scenario2 == false) Assert.Fail("Report with one filter is fail");
                else Logger.WriteDebugMessage("Scenario 2 : Report with one filter is Pass");

                if (scenario3 == false) Assert.Fail("Report with  multiple filter is fail");
                else Logger.WriteDebugMessage("Scenario 3 : Report with multiple filter is Pass");


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName_stay", reportName_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_ADR", total_ADR);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_Revenue", total_Revenue, true);
            }
        }

        // Validate the Province and State By Hotel
        public static void TC_253354()
        {
            if (TestCaseId == Utility.Constants.TC_253354)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, total_Room, reportName_stay, parameter1_value, total_Revenue, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Province and State By Hotel", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportName_stay = TestData.ExcelData.TestDataReader.ReadData(1, "reportName_stay");
                total_Room = TestData.ExcelData.TestDataReader.ReadData(1, "total_Room");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "total_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Province and State By Hotel Report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Portfolio report
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Province_and_State_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Province and State By Hotel page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Province_and_State_By_Hotel());

                //verify Hotel section For Portfolio report
                ReportParameter.Hotel_Selection_DDL();

                //Verify filters on Portfolio page
                ReportParameter.Portfolio_reports_filters();

                //Required field validation
                ReportParameter.Required_Field_Validation();

                //Enter mandatory field and generate report
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
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
                /*validate report with one filter*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Province_and_State_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Market By Hotel Report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Province_and_State_By_Hotel());

                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Room Product parameter");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(20000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Room Product: Room; Arabian Court Deluxe Rooms; ");
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
                    if (Name_stay.Contains(reportName_stay))
                        Logger.WriteDebugMessage(reportName_stay + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Room = at.GetCellData(Worksheetname, 4, 234);
                    if (Room.Contains(total_Room))
                        Logger.WriteDebugMessage(total_Room + " matched with total Rooms");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter 
                Helper.ReloadPage();
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Province_and_State_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(500);
                Logger.WriteDebugMessage("User landed on Market By Hotel Report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Province_and_State_By_Hotel());

                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage(parameter1_value + "selected for Room Product");
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for channel parameter");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; Front Office Direct; ");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader aa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Revenue = aa.GetCellData(Worksheetname, 5, 193);
                    if (Revenue.Contains(total_Revenue))
                        Logger.WriteDebugMessage(total_Revenue + " matched with total revenue for O&O Cape Town");
                    else
                        scenario3 = false;

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                if (scenario1 == false) Assert.Fail("Report with mandatory field is fail");
                else Logger.WriteDebugMessage("Scenario 1 : Report with mandatory field is Pass");

                if (scenario2 == false) Assert.Fail("Report with one filter is fail");
                else Logger.WriteDebugMessage("Scenario 2 : Report with one filter is Pass");

                if (scenario3 == false) Assert.Fail("Report with  multiple filter is fail");
                else Logger.WriteDebugMessage("Scenario 3 : Report with multiple filter is Pass");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName_stay", reportName_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_Room", total_Room);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_Revenue", total_Revenue, true);

                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        // Validate the Room Type by Hotel
        public static void TC_253355()
        {
            if (TestCaseId == Utility.Constants.TC_253355)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, total_ADR, reportName_stay, parameter1_value, total_Revenue, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Room Type By Hotel", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportName_stay = TestData.ExcelData.TestDataReader.ReadData(1, "reportName_stay");
                total_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "total_ADR");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "total_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Room Type by Hotel");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Portfolio report
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Room_Type_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Room Type By Hotel page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_By_Hotel());

                //verify Hotel section For Portfolio report
                ReportParameter.Hotel_Selection_DDL();

                //Verify filters on Portfolio page
                ReportParameter.Portfolio_reports_filters();

                //Required field validation
                ReportParameter.Required_Field_Validation();

                //Enter mandatory field and generate report
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
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
                /*validate report with one filter*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Room_Type_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Room Type by Hotel Report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_By_Hotel());

                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Market parameter");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s): ; Market Segment: Direct; Brand.com; Call Center / In House Reservation");
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
                    if (Name_stay.Contains(reportName_stay))
                        Logger.WriteDebugMessage(reportName_stay + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR = at.GetCellData(Worksheetname, 5, 620);
                    if (ADR.Contains(total_ADR))
                        Logger.WriteDebugMessage(total_ADR + " matched with total ADR ");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter 
                Helper.ReloadPage();
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Room_Type_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(500);
                Logger.WriteDebugMessage("User landed on Room Type By Hotel page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_By_Hotel());

                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage(parameter1_value + "selected for market");
                Helper.ScrollToText("Room Product:");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage(parameter2_value + "selected for source market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; Central Africa;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader aa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Revenue = aa.GetCellData(Worksheetname, 5, 241);
                    if (Revenue.Contains(total_Revenue))
                        Logger.WriteDebugMessage(total_Revenue + " matched with total revenue");
                    else
                        scenario3 = false;

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                if (scenario1 == false) Assert.Fail("Report with mandatory field is fail");
                else Logger.WriteDebugMessage("Scenario 1 : Report with mandatory field is Pass");

                if (scenario2 == false) Assert.Fail("Report with one filter is fail");
                else Logger.WriteDebugMessage("Scenario 2 : Report with one filter is Pass");

                if (scenario3 == false) Assert.Fail("Report with  multiple filter is fail");
                else Logger.WriteDebugMessage("Scenario 3 : Report with multiple filter is Pass");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName_stay", reportName_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_ADR", total_ADR);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_Revenue", total_Revenue, true);

                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        // Validate the Source Market By Hotel
        public static void TC_253356()
        {
            if (TestCaseId == Utility.Constants.TC_253356)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, total_ADR, reportName_stay, parameter1_value, total_Revenue, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Source Market By Hotel", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportName_stay = TestData.ExcelData.TestDataReader.ReadData(1, "reportName_stay");
                total_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "total_ADR");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "total_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Source Market By Hotel");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Portfolio report
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Source_Market_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Source Market By Hotel page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Source_Market_By_Hotel());

                //verify Hotel section For Portfolio report
                ReportParameter.Hotel_Selection_DDL();

                //Verify filters on Portfolio page
                ReportParameter.Portfolio_reports_filters();

                //Required field validation
                ReportParameter.Required_Field_Validation();

                //Enter mandatory field and generate report
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Report generated");
                //ReportParameter.Click_Source_Market_By_Hotel_expand_sign();
                //Logger.WriteDebugMessage("Africa section get expanded");
                //ReportParameter.Click_Source_Market_By_Hotel_collapse_sign();
                //Logger.WriteDebugMessage("Africa section get collapse");
                Helper.ScrollToText("Excel");
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
                }
                /*validate report with one filter*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Source_Market_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Source Market By Hotel Report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Source_Market_By_Hotel());

                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Helper.ScrollToText("Membership:");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Room Product parameter");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Room Product: Room; Arabian Court Deluxe Rooms; ");
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
                    if (Name_stay.Contains(reportName_stay))
                        Logger.WriteDebugMessage(reportName_stay + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR = at.GetCellData(Worksheetname, 5, 534);
                    if (ADR.Contains(total_ADR))
                        Logger.WriteDebugMessage(total_ADR + " matched with total ADR");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter 
                Helper.ReloadPage();
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Source_Market_By_Hotel();
                Navigation.Portfolio();
                Helper.AddDelay(500);
                Logger.WriteDebugMessage("User landed on Source Market By Hotel page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Source_Market_By_Hotel());

                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage(parameter1_value + "selected for Room Product");
                Helper.ScrollToText("Room Product:");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage(parameter2_value + "selected for source market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; Central Africa;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader aa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Revenue = aa.GetCellData(Worksheetname, 5, 107);
                    if (Revenue.Contains(total_Revenue))
                        Logger.WriteDebugMessage(total_Revenue + " matched with total revenue");
                    else
                        scenario3 = false;

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                if (scenario1 == false) Assert.Fail("Report with mandatory field is fail");
                else Logger.WriteDebugMessage("Scenario 1 : Report with mandatory field is Pass");

                if (scenario2 == false) Assert.Fail("Report with one filter is fail");
                else Logger.WriteDebugMessage("Scenario 2 : Report with one filter is Pass");

                if (scenario3 == false) Assert.Fail("Report with  multiple filter is fail");
                else Logger.WriteDebugMessage("Scenario 3 : Report with multiple filter is Pass");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName_stay", reportName_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_ADR", total_ADR);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_Revenue", total_Revenue, true);

                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }
    }
}
