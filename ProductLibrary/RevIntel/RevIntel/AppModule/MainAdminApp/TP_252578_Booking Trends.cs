using BaseUtility.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using RevIntel.AppModule.UI;
using RevIntel.PageObject.UI;
using System;
using Navigation = RevIntel.AppModule.UI.Navigation;

namespace RevIntel.AppModule.MainAdminApp
{
    public partial class MainAdminApp : RevIntel.Utility.Setup
    {
        // Validate Pace Report
        public static void TC_252597()
        {
            if (TestCaseId == Utility.Constants.TC_252597)
            {
                //Pre-Requisite
                string password, username, Portfolio_value, environment, hotel, As_Of_Date, total_ADR, reportName_stay, Hotel_Name_stay, parameter1_value, total_Revenue, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Jul-20", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
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
                Hotel_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_stay");

                Logger.WriteInfoMessage("Test Case : Validate Pace Report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                Navigation.Select_Client(client);

                //Navigate to Pace Report
                Navigation.Click_Menu_Booking_Trends();
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Pace_Report();
                Navigation.Booking_Trends();
                //Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Pace report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_report());

                //Varify filters on Pace and Pickup Analysis page`
                ReportParameter.Booking_Trends_reports_filters();

                //Required field validation
                ReportParameter.Required_Field_Validation();

                //Enter mandatory field and generate report
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage(startDate + "Selected as start date");
                Logger.WriteDebugMessage(enddate + "Selected as end date");
                Logger.WriteDebugMessage(As_Of_Date + "Selected as As_Of_Date");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(70000);
                Logger.WriteDebugMessage("Report Generated");
                if (client == "Kerzner")
                {
                    ReportParameter.PaceReport_Expand();
                    //Helper.AddDelay(5000);
                    Logger.WriteDebugMessage("Data for Direct parameter expand");
                    ReportParameter.PaceReport_Collapse();
                    Logger.WriteDebugMessage("Data for Direct parameter collapse");
                                
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
                ElementWait(PageObject_Navigation.Booking_Trends(), 240);
                Helper.DoubleClickElement(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Pace_Report();
                //Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Pace Report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_report());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage(As_Of_Date + "Selected as As_Of_Date");
                Logger.WriteDebugMessage(startDate + "Selected as start date");
                Logger.WriteDebugMessage(enddate + "Selected as end date");
                Helper.ScrollToText("Rate Code:");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Room Product parameter");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Room Product: Room;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                //Verify Data in export document and in front end 
                
                if (client == "Kerzner")
                {
                    ReportParameter.Report_Excel_Format();
                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 3);
                    if (Name_stay.Contains(reportName_stay))
                        Logger.WriteDebugMessage(reportName_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        Assert.Fail("Report Portfolio name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR = at.GetCellData(Worksheetname,5,74);
                    if (ADR.Contains(total_ADR))
                        Logger.WriteDebugMessage(total_ADR + " matched with total ADR for Subject section");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter 
                Helper.ReloadPage();
                Navigation.Booking_Trends();
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Pace_Report();
                //Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on pace report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_report());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Currency,Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Logger.WriteDebugMessage(As_Of_Date + "Selected as As od Date");
                Helper.ScrollToText("Rate Code:");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage(parameter1_value + "selected for Room Product");
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Channel");
                Helper.ScrollToText("View Analysis");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                //Verify Data in export document and in front end 
                
                if (client == "Kerzner")
                {
                    ReportParameter.Report_Excel_Format();
                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Hotel_Date = jj.GetCellData(Worksheetname, 1, 3);
                    if (Hotel_Date.Contains(Hotel_Name_stay))
                        Logger.WriteDebugMessage(Hotel_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        Assert.Fail("Report Portfolio name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader aa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Revenue = aa.GetCellData(Worksheetname, 9, 45);
                    if (Revenue.Contains(total_Revenue))
                        Logger.WriteDebugMessage(total_Revenue + " matched with total revenue for Compaire section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName_stay", reportName_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_ADR", total_ADR);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_stay", Hotel_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_Revenue", total_Revenue, true);
            }
        }

        // Validate Pace Trend
        public static void TC_252598()
        {
            if (TestCaseId == Utility.Constants.TC_252598)
            {
                //Pre-Requisite
                string password, username, Portfolio_value, environment, hotel, As_Of_Date, total_ADR, Portfolio_Name_stay, Hotel_Name_stay, Start_Month, total_Revenue, Currency, Business_Unit, client, FilePath, FullPath, Filename, Worksheetname = "Pace Trend", reportName;
                bool scenario1 = true, scenario2 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                Start_Month = TestData.ExcelData.TestDataReader.ReadData(1, "Start_Month");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_stay");
                total_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "total_ADR");
                total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "total_Revenue");
                Hotel_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_stay");

                Logger.WriteInfoMessage("Test Case : Validate Pace Trend");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Pace Report
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Pace_Trend();
                Navigation.Booking_Trends();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Pace Trend page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_Trend());

                /*validate report for Hotel Level*/
                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Business_Unit,Currency);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage(As_Of_Date + "enter as As_Of_Date");
                ReportParameter.Enter_Pace_Trend_Start_Month(Start_Month);
                Logger.WriteDebugMessage(Start_Month + "enter as start Month");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");

                //Verify Data in export document and in front end 
                if (client == "Kerzner")
                {
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name = tt.GetCellData(Worksheetname, 1, 1);
                    if (Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 3);
                    if (Name_stay.Contains(Hotel_Name_stay))
                        Logger.WriteDebugMessage(Hotel_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        Assert.Fail("Report Portfolio name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR = at.GetCellData(Worksheetname, 13, 15);
                    if (ADR.Contains(total_ADR))
                        Logger.WriteDebugMessage(total_ADR + " matched with ADR for 2019 year under Budget section");
                    else
                        scenario1 = false;
                }
                //Report for Portfolio Level
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Pace_Trend();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on pace Trend page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_Trend());
                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_Pace_Trend_Start_Month(Start_Month);
                Logger.WriteDebugMessage(Start_Month + "enter as start Month");
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage(As_Of_Date + "Selected as As_Of_Date");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(40000);
                Logger.WriteDebugMessage("Report generated");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Date = jj.GetCellData(Worksheetname, 1, 3);
                    if (Date.Contains(Portfolio_Name_stay))
                        Logger.WriteDebugMessage(Portfolio_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        Assert.Fail("Report Portfolio name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader aa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Revenue = aa.GetCellData(Worksheetname, 13, 17);
                    if (Revenue.Contains(total_Revenue))
                        Logger.WriteDebugMessage(total_Revenue + " matched with total revenue for year 2020 under Budget section");
                    else
                        scenario2 = false;

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                if (scenario1 == false) Assert.Fail("Report for hotel level is fail");
                else Logger.WriteDebugMessage("Scenario 1 : Report for hotel level is Pass");

                if (scenario2 == false) Assert.Fail("Report for Portfolio level is fail");
                else Logger.WriteDebugMessage("Scenario 2 : Report for Portfolio level is Pass");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_Start_Month", Start_Month);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_stay", Hotel_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_ADR", total_ADR);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_Start_Month", Start_Month);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_stay", Portfolio_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_Revenue", total_Revenue, true);
            }
        }

        // Validate Daily Pace and Pickup Analysis 
        public static void TC_252599()
        {
            if (TestCaseId == Utility.Constants.TC_252599)
            {
                //Pre-Requisite
                string password, username, Portfolio_value, environment, hotel, As_Of_Date, total_ADR, Portfolio_Name_stay, Hotel_Name_stay, Start_Month, total_Revenue, Currency, Business_Unit, client, FilePath, FullPath, Filename, Worksheetname = "Sheet2", reportName;
                bool scenario1 = true, scenario2 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                Start_Month = TestData.ExcelData.TestDataReader.ReadData(1, "Start_Month");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_stay");
                total_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "total_ADR");
                total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "total_Revenue");
                Hotel_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_stay");

                Logger.WriteInfoMessage("Test Case : Validate Daily Pace and Pickup Analysis ");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Pace Report
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Daily_Pace_and_Pickup_Analysis();
                Navigation.Booking_Trends();
                Helper.AddDelay(1000);
                Logger.WriteDebugMessage("User landed on Daily Pace and Pickup Analysis  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Daily_Pace_and_Pickup_Analysis());

                /*validate report for Hotel Level*/
                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Currency,Business_Unit);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage(As_Of_Date + "enter as As_Of_Date");
                ReportParameter.Enter_Pace_Trend_Start_Month(Start_Month);
                Logger.WriteDebugMessage(Start_Month + "enter as start Month");
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
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 2);
                    if (Name_stay.Contains(Hotel_Name_stay))
                        Logger.WriteDebugMessage(Hotel_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        Assert.Fail("Report Portfolio name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR = at.GetCellData(Worksheetname, 6, 39);
                    if (ADR.Contains(total_ADR))
                        Logger.WriteDebugMessage(total_ADR + " matched with ADR for Current year section section");
                    else
                        scenario1 = false;
                }
                //Report for Portfolio Level
                Helper.ReloadPage();
                Helper.AddDelay(5000);
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Daily_Pace_and_Pickup_Analysis();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Daily Pace and Pickup Analysis ");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Daily_Pace_and_Pickup_Analysis());
                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Business_Unit,Currency);
                ReportParameter.Enter_Pace_Trend_Start_Month(Start_Month);
                Logger.WriteDebugMessage(Start_Month + "enter as start Month");
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage(As_Of_Date + "Selected as As_Of_Date");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Date = jj.GetCellData(Worksheetname, 1, 2);
                    if (Date.Contains(Portfolio_Name_stay))
                        Logger.WriteDebugMessage(Portfolio_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        Assert.Fail("Report Portfolio name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader aa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Revenue = aa.GetCellData(Worksheetname,14,39);
                    if (Revenue.Contains(total_Revenue))
                        Logger.WriteDebugMessage(total_Revenue + " matched with total revenue for year 2020 under Budget section");
                    else
                        scenario2 = false;

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                if (scenario1 == false) Assert.Fail("Report for hotel level is fail");
                else Logger.WriteDebugMessage("Scenario 1 : Report for hotel level is Pass");

                if (scenario2 == false) Assert.Fail("Report for Portfolio level is fail");
                else Logger.WriteDebugMessage("Scenario 2 : Report for Portfolio level is Pass");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_Start_Month", Start_Month);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_stay", Hotel_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_ADR", total_ADR);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_Start_Month", Start_Month);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_stay", Portfolio_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_Revenue", total_Revenue, true);

                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        // Validate Pace and Pickup Analysis
        public static void TC_252600()
        {
            if (TestCaseId == Utility.Constants.TC_252600)
            {
                //Pre-Requisite
                string password, username, Portfolio_value, environment, hotel, As_Of_Date, OCC, Portfolio_Name_stay, Hotel_Name_stay, parameter1_value, total_Revenue, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Jul-20", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_stay");
                OCC = TestData.ExcelData.TestDataReader.ReadData(1, "OCC");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "total_Revenue");
                Hotel_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_stay");

                Logger.WriteInfoMessage("Test Case : Validate Pace and Pickup Analysis");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Pace Report
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Pace_and_Pickup_Analysis();
                Navigation.Booking_Trends();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Pace and Pickup Analysis page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_and_Pickup_Analysis());

                //Required field validation
                ReportParameter.Required_Field_Validation();

                //Varify filters on Pace and Pickup Analysis page`
                ReportParameter.Booking_Trends_reports_filters();

                //Enter mandatory field and generate report
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage(startDate + "Selected as start date");
                Logger.WriteDebugMessage(enddate + "Selected as end date");
                Logger.WriteDebugMessage(As_Of_Date + "Selected as As_Of_Date");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(70000);
                Logger.WriteDebugMessage("Report Generated");

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
                /*validate report with one filter at Portfolio Level*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Helper.AddDelay(5000);
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Pace_and_Pickup_Analysis();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Pace and Pickup Analysis page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_and_Pickup_Analysis());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage(startDate + "Selected as start date");
                Logger.WriteDebugMessage(enddate + "Selected as end date");
                Logger.WriteDebugMessage(As_Of_Date + "Selected as As_Of_Date");
                Helper.ScrollToText("Rate Code:");
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected for channel parameter");
                Helper.ScrollToText("View Analysis");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; ");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Portfolio = hh.GetCellData(Worksheetname, 1, 2);
                    if (Portfolio.Contains(Portfolio_Name_stay))
                        Logger.WriteDebugMessage(Portfolio_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        Assert.Fail("Report Portfolio name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Actual_OCC = at.GetCellData(Worksheetname, 7, 39);
                    if (Actual_OCC.Contains(OCC))
                        Logger.WriteDebugMessage(OCC + " matched with occ% under Current Year Totals section ");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter at Hotel Level
                Helper.ReloadPage();
                Helper.AddDelay(5000);
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Pace_and_Pickup_Analysis();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on pace report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_and_Pickup_Analysis());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Currency,Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Logger.WriteDebugMessage(As_Of_Date + "Selected as As od Date");
                Helper.ScrollToText("Rate Code:");
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter1_value + "selected for channnel");
                ReportParameter.Parameter_market();
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Market");
                Helper.ScrollToText("Hotel/Portfolio");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000); 
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; ");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Hotel_Date = jj.GetCellData(Worksheetname, 1, 2);
                    if (Hotel_Date.Contains(Hotel_Name_stay))
                        Logger.WriteDebugMessage(Hotel_Name_stay + " matched with Report Hotel name and stay dates ");
                    else
                        Assert.Fail("Report Hotel name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader kk = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Revenue = kk.GetCellData(Worksheetname, 8, 39);
                    if (Revenue.Contains(total_Revenue))
                        Logger.WriteDebugMessage(total_Revenue + " matched with occ% under Current Year Totals section ");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_stay", Portfolio_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_OCC", OCC);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_stay", Hotel_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_Revenue", total_Revenue, true);

                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        //Validate Rate Code Pace Report
        public static void TC_252601()
        {
            if (TestCaseId == Utility.Constants.TC_252601)
            {
                //Pre-Requisite
                string password, username, Portfolio_value, environment, hotel, As_Of_Date, Rooms_sold, Portfolio_Name_stay, Hotel_Name_stay, parameter1_value, total_Revenue, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Mar-20", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_stay");
                Rooms_sold = TestData.ExcelData.TestDataReader.ReadData(1, "Rooms_sold");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "total_Revenue");
                Hotel_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_stay");

                Logger.WriteInfoMessage("Test Case : Validate Rate Code Pace Report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Pace Report
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Rate_Code_Pace_Report();
                Navigation.Booking_Trends();
                Helper.AddDelay(15000);
                Logger.WriteDebugMessage("User landed on Rate Code Pace Report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Rate_Code_Pace_Report());

                //Required field validation
                ReportParameter.Required_Field_Validation();

                //Varify filters on Pace and Pickup Analysis page`
                ReportParameter.Booking_Trends_reports_filters();

                //Enter mandatory field and generate report
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage(startDate + "Selected as start date");
                Logger.WriteDebugMessage(enddate + "Selected as end date");
                Logger.WriteDebugMessage(As_Of_Date + "Selected as As_Of_Date");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report Generated");

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
                /*validate report with one filter at Portfolio Level*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Helper.AddDelay(5000);
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Rate_Code_Pace_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Rate code Pace Report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Rate_Code_Pace_Report());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Currency,Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage(startDate + "Selected as start date");
                Logger.WriteDebugMessage(enddate + "Selected as end date");
                Logger.WriteDebugMessage(As_Of_Date + "Selected as As_Of_Date");
                Helper.ScrollToText("Rate Code:");
                ReportParameter.Select_RoomProduct_DDL();
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Room Product parameter");
                Helper.ScrollToText("Portfolio");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(90000);
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

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Portfolio = hh.GetCellData(Worksheetname, 1, 3);
                    if (Portfolio.Contains(Portfolio_Name_stay))
                        Logger.WriteDebugMessage(Portfolio_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        Assert.Fail("Report Portfolio name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Rooms = at.GetCellData(Worksheetname, 3, 941);
                    if (Rooms.Contains(Rooms_sold))
                        Logger.WriteDebugMessage(Rooms_sold + " matched with Room sold under subject section ");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter at Hotel Level
                Helper.ReloadPage();
                Helper.AddDelay(7000);
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Rate_Code_Pace_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Rate code pace report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Rate_Code_Pace_Report());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Logger.WriteDebugMessage(As_Of_Date + "Selected as As of Date");
                Helper.ScrollToText("Rate Code:");
                ReportParameter.Parameter_Channel();
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for channnel");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; ");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Hotel_Date = jj.GetCellData(Worksheetname, 1, 3);
                    if (Hotel_Date.Contains(Hotel_Name_stay))
                        Logger.WriteDebugMessage(Hotel_Name_stay + " matched with Report Hotel name and stay dates ");
                    else
                        Assert.Fail("Report Hotel name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader kk = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Revenue = kk.GetCellData(Worksheetname, 5, 1218);
                    if (Revenue.Contains(total_Revenue))
                        Logger.WriteDebugMessage(total_Revenue + " matched with total Revenue under subject section ");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_stay", Portfolio_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Rooms_sold", Rooms_sold);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_stay", Hotel_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_Revenue", total_Revenue, true);
            }
        }

        //Validate Channel by Room Type Pace
        public static void TC_252602()
        {
            if (TestCaseId == Utility.Constants.TC_252602)
            {
                //Pre-Requisite
                string password, username, Portfolio_value, environment, hotel, As_Of_Date, Total_ADR, Portfolio_Name_stay, Hotel_Name_stay, parameter1_value, total_Rooms_sold, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Channel By Room Type Pace", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_stay");
                Total_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "Total_ADR");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                total_Rooms_sold = TestData.ExcelData.TestDataReader.ReadData(1, "total_Rooms_sold");
                Hotel_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_stay");

                Logger.WriteInfoMessage("Test Case : Validate Channel by Room Type Pace");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Pace Report
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Channel_By_Room_Type_Pace();
                Navigation.Booking_Trends();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Channel By Room Type Pace page");

                //TestHandling.ScreenMinimize();
                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Channel_By_Room_Type_Pace());

                //Required field validation
                ReportParameter.Required_Field_Validation();

                //Varify filters on Pace and Pickup Analysis page`
                ReportParameter.Booking_Trends_reports_filters();

                //Enter mandatory field and generate report
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage(startDate + "Selected as start date");
                Logger.WriteDebugMessage(enddate + "Selected as end date");
                Logger.WriteDebugMessage(As_Of_Date + "Selected as As_Of_Date");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report Generated");

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

                /*validate report with one filter at Portfolio Level*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Channel_By_Room_Type_Pace();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on channelBy Room Type Pace page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Channel_By_Room_Type_Pace());

                ReportParameter.Portfolio_RadioButton(); 
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage(startDate + "Selected as start date");
                Logger.WriteDebugMessage(enddate + "Selected as end date");
                Logger.WriteDebugMessage(As_Of_Date + "Selected as As_Of_Date");
                Helper.ScrollToText("Rate Code:");
                ReportParameter.Select_RoomProduct_DDL();
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Room Product parameter");
                Helper.ScrollToText("View Analysis");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(20000);
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

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Portfolio = hh.GetCellData(Worksheetname, 2, 3);
                    if (Portfolio.Contains(Portfolio_Name_stay))
                        Logger.WriteDebugMessage(Portfolio_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        Assert.Fail("Report Portfolio name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR = at.GetCellData(Worksheetname, 10, 298);
                    if (ADR.Contains(Total_ADR))
                        Logger.WriteDebugMessage(Total_ADR + " matched with total ADR under Prior Period section ");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter at Hotel Level
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Channel_By_Room_Type_Pace();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Channel By Room Type Pace page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Channel_By_Room_Type_Pace());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Logger.WriteDebugMessage(As_Of_Date + "Selected as As of Date");
                ReportParameter.Parameter_market();
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter1_value + "selected for Market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s): ; Market Segment:");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Hotel_Date = jj.GetCellData(Worksheetname, 2, 3);
                    if (Hotel_Date.Contains(Hotel_Name_stay))
                        Logger.WriteDebugMessage(Hotel_Name_stay + " matched with Report Hotel name and stay dates ");
                    else
                        Assert.Fail("Report Hotel name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader kk = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Rooms_sold = kk.GetCellData(Worksheetname, 9, 74);
                    if (Rooms_sold.Contains(total_Rooms_sold))
                        Logger.WriteDebugMessage(total_Rooms_sold + " matched with total Roomd sold under Prior Period section ");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_stay", Portfolio_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_ADR", Total_ADR);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_stay", Hotel_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_Rooms_sold", total_Rooms_sold, true);

                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        //Validate Channel Pace Analysis
        public static void TC_252603()
        {
            if (TestCaseId == Utility.Constants.TC_252603)
            {
                //Pre-Requisite
                string password, username, Portfolio_value, environment, hotel, As_Of_Date, Total_ADR, Portfolio_Name_stay, Hotel_Name_stay, parameter1_value, total_Room_Sold, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Channel Pace Analysis", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_stay");
                Total_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "Total_ADR");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                total_Room_Sold = TestData.ExcelData.TestDataReader.ReadData(1, "total_Room_Sold");
                Hotel_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_stay");

                Logger.WriteInfoMessage("Test Case : Validate Channel Pace Analysis");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 

                Navigation.Select_Client(client);

                //Navigate to Pace Report
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Channel_Pace_Analysis();
                Navigation.Booking_Trends();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Channel Pace analysis page");

                //TestHandling.ScreenMinimize();
                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Channel_Pace_Analysis());

                //Required field validation
                ReportParameter.Required_Field_Validation();

                //Varify filters on Pace and Pickup Analysis page`
                ReportParameter.Booking_Trends_reports_filters();

                //Enter mandatory field and generate report
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage(startDate + "Selected as start date");
                Logger.WriteDebugMessage(enddate + "Selected as end date");
                Logger.WriteDebugMessage(As_Of_Date + "Selected as As_Of_Date");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report Generated");

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

                /*validate report with one filter at Portfolio Level*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Channel_Pace_Analysis();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Channel Pace analysis page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Channel_Pace_Analysis());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage(startDate + "Selected as start date");
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage(As_Of_Date + "Selected as As_Of_Date");
                Logger.WriteDebugMessage(enddate + "Selected as end date");
                Helper.ScrollToText("Channel:");
                ReportParameter.Parameter_Channel();
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Room Product parameter");
                Helper.ScrollToText("View Analysis");
                Helper.AddDelay(500);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; ");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Portfolio = hh.GetCellData(Worksheetname, 2, 3);
                    if (Portfolio.Contains(Portfolio_Name_stay))
                        Logger.WriteDebugMessage(Portfolio_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        Assert.Fail("Report Portfolio name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR = at.GetCellData(Worksheetname, 6, 17);
                    if (ADR.Contains(Total_ADR))
                        Logger.WriteDebugMessage(Total_ADR + " matched with total ADR under Current Period section ");
                    else
                        scenario2 = false;
                }

                //Report with Multiple filter at Hotel Level
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Channel_Pace_Analysis();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Channel Pace analysis page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Channel_Pace_Analysis());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Logger.WriteDebugMessage(As_Of_Date + "Selected as As of Date");
                Helper.ScrollToText("Rate Code:");
                ReportParameter.Parameter_Channel();
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Room Product parameter");
                ReportParameter.Parameter_market();
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Market");
                Helper.ScrollToText("View Analysis");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(80000);
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

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Hotel_Date = jj.GetCellData(Worksheetname, 2, 3);
                    if (Hotel_Date.Contains(Hotel_Name_stay))
                        Logger.WriteDebugMessage(Hotel_Name_stay + " matched with Report Hotel name and stay dates ");
                    else
                        Assert.Fail("Report Hotel name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader kk = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Rooms_sold = kk.GetCellData(Worksheetname, 5, 16);
                    if (Rooms_sold.Contains(total_Room_Sold))
                        Logger.WriteDebugMessage(total_Room_Sold + " matched with total Room sold under Current Period section ");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_stay", Portfolio_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_ADR", Total_ADR);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_stay", Hotel_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_Room_Sold", total_Room_Sold, true);
            }
        }

        //Validate Pickup By Day
        public static void TC_252604()
        {
            if (TestCaseId == Utility.Constants.TC_252604)
            {
                //Pre-Requisite
                string password, username, Portfolio_value, Pickup_startDate, Pickup_enddate, environment, hotel, Total_Pickup, Portfolio_Name_stay, Hotel_Name_stay, parameter1_value, total_ADR_of_Rooms_Picked_Up, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Pickup by Day", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Pickup_startDate = TestData.ExcelData.TestDataReader.ReadData(1, "Pickup_startDate");
                Pickup_enddate = TestData.ExcelData.TestDataReader.ReadData(1, "Pickup_enddate");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_stay");
                Total_Pickup = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Pickup");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                total_ADR_of_Rooms_Picked_Up = TestData.ExcelData.TestDataReader.ReadData(1, "total_ADR_of_Rooms_Picked_Up");
                Hotel_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_stay");

                Logger.WriteInfoMessage("Test Case : Validate Pickup By Day");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 

                Navigation.Select_Client(client);

                //Navigate to Pace Report
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Pickup_By_Day();
                Navigation.Booking_Trends();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on  page");

                //TestHandling.ScreenMinimize();
                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pickup_By_Day());

                //Required field validation
                ReportParameter.Required_Field_Validation();

                //Varify filters on Pace and Pickup Analysis page`
                ReportParameter.Booking_Trends_reports_filters();

                //Enter mandatory field and generate report
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Selected as start date");
                Logger.WriteDebugMessage(enddate + "Selected as end date");
                ReportParameter.Pickup_startDate(Pickup_startDate);
                ReportParameter.Pickup_enddate(Pickup_enddate);
                Logger.WriteDebugMessage(Pickup_startDate + "Selected as Pickup_startDate");
                Logger.WriteDebugMessage(Pickup_enddate + "Selected as Pickup_enddate");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report Generated");

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
                /*validate report with one filter at Portfolio Level*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Helper.AddDelay(5000);
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Pickup_By_Day();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Channel Pace analysis page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pickup_By_Day());

                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Selected as start date");
                Logger.WriteDebugMessage(enddate + "Selected as end date");
                ReportParameter.Pickup_startDate(Pickup_startDate);
                ReportParameter.Pickup_enddate(Pickup_enddate);
                Logger.WriteDebugMessage(Pickup_startDate + "Selected as Pickup_startDate");
                Logger.WriteDebugMessage(Pickup_enddate + "Selected as Pickup_enddate");
                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Parameter_Channel();
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Room Product parameter");
                Helper.ScrollToText("View Analysis");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
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

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Portfolio = hh.GetCellData(Worksheetname, 2, 2);
                    if (Portfolio.Contains(Portfolio_Name_stay))
                        Logger.WriteDebugMessage(Portfolio_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        Assert.Fail("Report Portfolio name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string PickUp = at.GetCellData(Worksheetname, 18, 41);
                    if (PickUp.Contains(Total_Pickup))
                        Logger.WriteDebugMessage(Total_Pickup + " matched with Total_Pickup under Revenue section ");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter at Hotel Level
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Pickup_By_Day();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Pickup By Day page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pickup_By_Day());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);                                                                                              
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Selected as start date");
                Logger.WriteDebugMessage(enddate + "Selected as end date");
                ReportParameter.Pickup_startDate(Pickup_startDate);
                ReportParameter.Pickup_enddate(Pickup_enddate);
                Logger.WriteDebugMessage(Pickup_startDate + "Selected as Pickup_startDate");
                Logger.WriteDebugMessage(Pickup_enddate + "Selected as Pickup_enddate");
                ReportParameter.Parameter_Channel();
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Room Product parameter");
                ReportParameter.Select_SourceMarket_DDL();
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage(parameter2_value + "selected for Market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
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

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Hotel_Date = jj.GetCellData(Worksheetname, 2, 2);
                    if (Hotel_Date.Contains(Hotel_Name_stay))
                        Logger.WriteDebugMessage(Hotel_Name_stay + " matched with Report Hotel name and stay dates ");
                    else
                        Assert.Fail("Report Hotel name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader kk = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR_of_Rooms_Picked_Up = kk.GetCellData(Worksheetname, 14, 41);
                    if (ADR_of_Rooms_Picked_Up.Contains(total_ADR_of_Rooms_Picked_Up))
                        Logger.WriteDebugMessage(total_ADR_of_Rooms_Picked_Up + " matched with total ADR of Rooms Picked Up ");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Pickup_startDate", Pickup_startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Pickup_enddate", Pickup_enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_stay", Portfolio_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Pickup", Total_Pickup);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_stay", Hotel_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_ADR_of_Rooms_Picked_Up", total_ADR_of_Rooms_Picked_Up, true);

                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        //Validate Pickup by Day Detailed
        public static void TC_252605()
        {
            if (TestCaseId == Utility.Constants.TC_252605)
            {
                //Pre-Requisite
                string password, username, Portfolio_value, test_Pickup_startDate, Pickup_Total_Room, Pickup_startDate, Pickup_enddate, startDate, enddate, environment, hotel, Portfolio_Name_stay, Hotel_Name_stay, parameter1_value, parameter2_value, parameter2, Currency, Start_total_ADR, Business_Unit, client, parameter1, FilePath, FullPath, Filename, Worksheetname = "By Date", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                test_Pickup_startDate = TestData.ExcelData.TestDataReader.ReadData(1, "test_Pickup_startDate");
                Pickup_startDate = TestData.ExcelData.TestDataReader.ReadData(1, "Pickup_startDate");
                Pickup_enddate = TestData.ExcelData.TestDataReader.ReadData(1, "Pickup_enddate");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_stay");
                Pickup_Total_Room = TestData.ExcelData.TestDataReader.ReadData(1, "Pickup_Total_Room");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Hotel_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_stay");
                Start_total_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "Start_total_ADR");

                Logger.WriteInfoMessage("Test Case :  Validate Pickup by Day Detailed");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Pace Report
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Pickup_By_Day_Detailed();
                Navigation.Booking_Trends();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Pickup_By_Day_Detailed page");

                //TestHandling.ScreenMinimize();
                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pickup_By_Day_Detailed());

                //Required field validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message dislayed for required fields");

                //Report with only mandatory field
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_EndDate(enddate);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                ReportParameter.Pickup_startDate(Pickup_startDate);
                ReportParameter.Pickup_enddate(Pickup_enddate);
                ReportParameter.Pickup_enddate(Pickup_enddate);
                Logger.WriteDebugMessage(Pickup_startDate + "Entered as start Date");
                Logger.WriteDebugMessage(Pickup_enddate + "Entered as End Date");
                Helper.ScrollToText("Hotel/Portfolio");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
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

                /*validate report with one filter at Portfolio Level*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Pickup_By_Day_Detailed();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Pickup By Day Detailed page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pickup_By_Day_Detailed());

                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                ReportParameter.Pickup_startDate(Pickup_startDate);
                ReportParameter.Pickup_enddate(Pickup_enddate);
                Logger.WriteDebugMessage(Pickup_startDate + "Entered as start Date");
                Logger.WriteDebugMessage(Pickup_enddate + "Entered as End Date");
                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                Helper.ScrollToText("Rate Code:");
                ReportParameter.Select_RoomProduct_DDL();
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Room Product parameter");
                Helper.ScrollToText("Hotel/Portfolio");
                Helper.ScrollToText("View Analysis");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(40000);
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

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Portfolio = hh.GetCellData(Worksheetname, 1, 3);
                    if (Portfolio.Contains(Portfolio_Name_stay))
                        Logger.WriteDebugMessage(Portfolio_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        Assert.Fail("Report Portfolio name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Total_Room = at.GetCellData(Worksheetname, 14, 8640);
                    if (Total_Room.Contains(Pickup_Total_Room))
                        Logger.WriteDebugMessage(Pickup_Total_Room + " matched with total Room under Pickup section ");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter at Hotel Level
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Pickup_By_Day_Detailed();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Annual Pickup by day page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pickup_By_Day_Detailed());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                ReportParameter.Parameter_market();
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Market");
                ReportParameter.Pickup_startDate(Pickup_startDate);
                ReportParameter.Pickup_enddate(Pickup_enddate);
                Logger.WriteDebugMessage(Pickup_startDate + "Entered as start Date");
                Logger.WriteDebugMessage(Pickup_enddate + "Entered as End Date");
                Helper.ScrollToText("Hotel/Portfolio");
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

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Hotel_Date = jj.GetCellData(Worksheetname, 1, 3);
                    if (Hotel_Date.Contains(Hotel_Name_stay))
                        Logger.WriteDebugMessage(Hotel_Name_stay + " matched with Report Hotel name and stay dates ");
                    else
                        Assert.Fail("Report Hotel name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader kk = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR = kk.GetCellData(Worksheetname, 10, 2656);
                    if (ADR.Contains(Start_total_ADR))
                        Logger.WriteDebugMessage(Start_total_ADR + " matched with total ADR under start section ");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_stay", Portfolio_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Pickup_Total_Room", Pickup_Total_Room);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_stay", Hotel_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start_total_ADR", Start_total_ADR, true);
            }
        }

        // Validate Monthly Pick up
        public static void TC_252606()
        {
            if (TestCaseId == Utility.Constants.TC_252606)
            {
                //Pre-Requisite
                string password, username, Portfolio_value, Pickup_startDate, Total_StartDate, Pickup_enddate, environment, hotel, Portfolio_Name_stay, Hotel_Name_stay, Currency, Business_Unit, client, FilePath, FullPath, Filename, Worksheetname = "Monthly Pickup and Budget Varia", reportName;
                bool scenario1 = true, scenario2 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Pickup_startDate = TestData.ExcelData.TestDataReader.ReadData(1, "Pickup_startDate");
                Pickup_enddate = TestData.ExcelData.TestDataReader.ReadData(1, "Pickup_enddate");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_stay");
                Hotel_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_stay");
                Total_StartDate = TestData.ExcelData.TestDataReader.ReadData(1, "Total_StartDate");

                Logger.WriteInfoMessage("Test Case :Validate Monthly Pick up");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 

                Navigation.Select_Client(client);

                //Navigate to Pace Report
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Monthly_Pickup();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Monthly pickup page");

                //TestHandling.ScreenMinimize();
                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Monthly_Pickup());

                //Report with Hotel Level
                ReportParameter.Monthly_PickupStart(Pickup_startDate);
                ReportParameter.Monthly_PickupEnd(Pickup_enddate);
                Logger.WriteDebugMessage(Pickup_startDate + "Entered as Monthly Pickup Start");
                Logger.WriteDebugMessage(Pickup_enddate + "Entered as Monthly Pickup End Date");
                ReportParameter.Monthly_Pickup_Excel();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    //ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.Dashboard_GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name = tt.GetCellData(Worksheetname, 1, 2);
                    if (Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string StartDate = hh.GetCellData(Worksheetname, 4, 21);
                    if (StartDate.Contains(Total_StartDate))
                        Logger.WriteDebugMessage(Total_StartDate + " matched with State date total");
                    else
                        scenario1 = false;
                }

                /*validate report with one filter at Portfolio Level*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Helper.AddDelay(5000);
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Monthly_Pickup();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Monthly Pickup page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Monthly_Pickup());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Pickup_startDate(Pickup_startDate);
                ReportParameter.Pickup_enddate(Pickup_enddate);
                Logger.WriteDebugMessage(Pickup_startDate + "Entered as start Date");
                Logger.WriteDebugMessage(Pickup_enddate + "Entered as End Date");
                ReportParameter.Monthly_Pickup_Excel();
                Helper.AddDelay(40000);
                Logger.WriteDebugMessage("Report generated");

                if (client == "Kerzner")
                {
                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader kk = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Portfolio = kk.GetCellData(Worksheetname, 1, 3);
                    if (Portfolio.Contains(Portfolio_Name_stay))
                        Logger.WriteDebugMessage(Portfolio_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        scenario2 = false;

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                if (scenario1 == false) Assert.Fail("Report with Hotel level is fail");
                else Logger.WriteDebugMessage("Scenario 1 : Report with Hotel level is Pass");

                if (scenario2 == false) Assert.Fail("Report with Portfolio level is fail");
                else Logger.WriteDebugMessage("Scenario 2 : Report with Portfolio level is fail");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_stay", Portfolio_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_stay", Hotel_Name_stay, true);
            }
        }

        // Validate Production Pattern Report
        public static void TC_252607()
        {
            if (TestCaseId == Utility.Constants.TC_252607)
            {
                //Pre-Requisite
                string password, username, Portfolio_value, startDate, enddate, BookingStartDate, BookingEndDate, environment, hotel, Portfolio_Name_stay, Current_Room, Hotel_Name_stay, parameter1_value, parameter2_value, parameter2, Currency, Prior_ADR, Business_Unit, client, parameter1, FilePath, FullPath, Filename, Worksheetname = "Production Patterns", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                BookingStartDate = TestData.ExcelData.TestDataReader.ReadData(1, "BookingStartDate");
                BookingEndDate = TestData.ExcelData.TestDataReader.ReadData(1, "BookingEndDate");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_stay");
                Current_Room = TestData.ExcelData.TestDataReader.ReadData(1, "Current_Room");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Hotel_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_stay");
                Prior_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "Prior_ADR");

                Logger.WriteInfoMessage("Test Case :Validate Production Pattern Report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 

                Navigation.Select_Client(client);

                //Navigate to Pace Report
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Production_Patterns();
                Navigation.Booking_Trends();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Production Patterns report page");

                //TestHandling.ScreenMinimize();
                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Production_Patterns());

                //Required field validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message dislayed for required fields");

                //Report with only mandatory field
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(40000);
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

                /*validate report with one filter at Portfolio Level*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Production_Patterns();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Pickup By Day Detailed page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Production_Patterns());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                Helper.ScrollToText("Booking Date:");
                Business_Source.BookingStartDate(BookingStartDate);
                Business_Source.BookingEndDate(BookingEndDate);
                Logger.WriteDebugMessage(BookingStartDate + " Enter as booking start date");
                Logger.WriteDebugMessage(BookingEndDate + " Enter as booking end date");
                Helper.ScrollToText("View Analysis");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(20000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s): Booking Date: 6/1/2020 - 6/30/2020");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Portfolio = hh.GetCellData(Worksheetname, 1, 3);
                    if (Portfolio.Contains(Portfolio_Name_stay))
                        Logger.WriteDebugMessage(Portfolio_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        Assert.Fail("Report Portfolio name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Room = at.GetCellData(Worksheetname, 2, 16);
                    if (Room.Contains(Current_Room))
                        Logger.WriteDebugMessage(Current_Room + " matched with current room count for Monday under Rooms section ");
                    else
                        scenario2 = false;
                }

                //Report with Multiple filter at Hotel Level
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Production_Patterns();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Annual Pickup by day page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Production_Patterns());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                Helper.ScrollToText("Booking Date:");
                Business_Source.BookingStartDate(BookingStartDate);
                Business_Source.BookingEndDate(BookingEndDate);
                Logger.WriteDebugMessage(BookingStartDate + " Enter as booking start date");
                Logger.WriteDebugMessage(BookingEndDate + " Enter as booking end date");
                ReportParameter.Parameter_Channel();
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s): Booking Date: 6/1/2020 - 6/30/2020 ; Channel: Hotel Direct; Executive Office; Front Office Direct; Government; Option Booking; Room Reservation Direct; Tour Operator DMC; Tour Operator Others");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Hotel_Date = jj.GetCellData(Worksheetname, 1, 3);
                    if (Hotel_Date.Contains(Hotel_Name_stay))
                        Logger.WriteDebugMessage(Hotel_Name_stay + " matched with Report Hotel name and stay dates ");
                    else
                        Assert.Fail("Report Hotel name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader kk = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR = kk.GetCellData(Worksheetname, 8, 10);
                    if (ADR.Contains(Prior_ADR))
                        Logger.WriteDebugMessage(Prior_ADR + " matched with prior ADR under ADR section for Aug 20 ");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_stay", Portfolio_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current_Room", Current_Room);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_stay", Hotel_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Prior_ADR", Prior_ADR, true);

                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        //Validate High Occupancy Night By Day Report
        public static void TC_252608()
        {
            if (TestCaseId == Utility.Constants.TC_252608)
            {
                //Pre-Requisite
                string password, username, Portfolio_value, Total_Revenue, Pickup_startDate, Pickup_enddate, startDate, enddate, environment, hotel, Portfolio_Name_stay, Hotel_Name_stay, parameter1_value, parameter2_value, parameter2, Currency, Food_Revenue, Business_Unit, client, parameter1, FilePath, FullPath, Filename, Worksheetname = "Sheet1", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_stay");
                Total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Revenue");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Hotel_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_stay");
                Food_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Food_Revenue");

                Logger.WriteInfoMessage("Test Case :Validate Monthly Pick up");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 

                Navigation.Select_Client(client);

                //Navigate to Pace Report
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.High_Occupancy_Night_By_Day();
                Navigation.Booking_Trends();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on High Occupancy Night By Day page");

                //TestHandling.ScreenMinimize();
                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_High_Occupancy_Night_By_Day());

                //Required field validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message dislayed for required fields");

                //Report with only mandatory field
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
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
                    string Name = tt.GetCellData(Worksheetname, 2, 1);
                    if (Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;
                }
                
                /*validate report with one filter at Portfolio Level*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.High_Occupancy_Night_By_Day();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on High Occupancy Night By Day page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_High_Occupancy_Night_By_Day());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                Helper.ScrollToText("Room Product:");
                ReportParameter.Select_SourceMarket_DDL();
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Room Product parameter");
                Helper.ScrollToText("Portfolio");
                Helper.ScrollToText("Portfolio");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(70000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Portfolio = hh.GetCellData(Worksheetname, 1, 3);
                    if (Portfolio.Contains(Portfolio_Name_stay))
                        Logger.WriteDebugMessage(Portfolio_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        Assert.Fail("Report Portfolio name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Revenue = at.GetCellData(Worksheetname, 10, 102);
                    if (Revenue.Contains(Total_Revenue))
                        Logger.WriteDebugMessage(Total_Revenue + " matched with total revenue for Averages for High Occupancy Days");
                    else
                        scenario2 = false;
                }

                //Report with Multiple filter at Hotel Level
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.High_Occupancy_Night_By_Day();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on High Occupancy Night By Day report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_High_Occupancy_Night_By_Day());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                Helper.ScrollToText("Booking Date");
                ReportParameter.Select_SourceMarket_DDL();
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage(parameter1_value + "selected for Market");
                ReportParameter.Parameter_market();
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Market");
                Helper.ScrollToText("Portfolio");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(20000);
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

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Hotel_Date = jj.GetCellData(Worksheetname, 1, 3);
                    if (Hotel_Date.Contains(Hotel_Name_stay))
                        Logger.WriteDebugMessage(Hotel_Name_stay + " matched with Report Hotel name and stay dates ");
                    else
                        Assert.Fail("Report Hotel name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader kk = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Food = kk.GetCellData(Worksheetname, 12, 91);
                    if (Food.Contains(Food_Revenue))
                        Logger.WriteDebugMessage(Food_Revenue + " matched with total Revenue under Averages for High Occupancy Days ");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_stay", Portfolio_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Revenue", Total_Revenue);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_stay", Hotel_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Food_Revenue", Food_Revenue, true);
            }
        }

        // Validate Sold Out Night Analysis
        public static void TC_252609()
        {
            if (TestCaseId == Utility.Constants.TC_252609)
            {
                //Pre-Requisite
                string password, username, Portfolio_value, Room_Sold_out_Night, startDate, enddate, environment, hotel, Portfolio_Name_stay, Hotel_Name_stay, parameter1_value, parameter2_value, parameter2, Currency, total_Revenue, Business_Unit, client, parameter1, FilePath, FullPath, Filename, Worksheetname = "Sold Out Night Analysis", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_stay");
                Room_Sold_out_Night = TestData.ExcelData.TestDataReader.ReadData(1, "Room_Sold_out_Night");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Hotel_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_stay");
                total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "total_Revenue");

                Logger.WriteInfoMessage("Test Case :Validate Sold Out Night Analysis");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 

                Navigation.Select_Client(client);

                //Navigate to Pace Report
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Sold_Out_Night_Analysis();
                Navigation.Booking_Trends();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Sold Out Night Analysis page");

                //TestHandling.ScreenMinimize();
                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Sold_Out_Night_Analysis());

                //Required field validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message dislayed for required fields");

                //Report with only mandatory field
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
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

                /*validate report with one filter at Portfolio Level*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Sold_Out_Night_Analysis();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Sold Out Night Analysis page page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Sold_Out_Night_Analysis());

                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_RoomProduct_DDL();
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Room Product parameter");
                Helper.ScrollToText("View Analysis");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(60000);
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

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Portfolio = hh.GetCellData(Worksheetname, 1, 3);
                    if (Portfolio.Contains(Portfolio_Name_stay))
                        Logger.WriteDebugMessage(Portfolio_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        Assert.Fail("Report Portfolio name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Room_sold = at.GetCellData(Worksheetname, 8, 3232);
                    if (Room_sold.Contains(Room_Sold_out_Night))
                        Logger.WriteDebugMessage(Room_Sold_out_Night + " matched with Room Sold from Total for Sold Out Nights section for Prioryear ");
                    else
                        scenario2 = false;
                }

                //Report with Multiple filter at Hotel Level
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Sold_Out_Night_Analysis();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Sold Out Night Analysis page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Sold_Out_Night_Analysis());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_RoomProduct_DDL();
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "selected for Market");
                ReportParameter.Parameter_Channel();
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(60000);
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

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Hotel_Date = jj.GetCellData(Worksheetname, 1, 3);
                    if (Hotel_Date.Contains(Hotel_Name_stay))
                        Logger.WriteDebugMessage(Hotel_Name_stay + " matched with Report Hotel name and stay dates ");
                    else
                        Assert.Fail("Report Hotel name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader kk = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Revenue = kk.GetCellData(Worksheetname, 7, 3302);
                    if (Revenue.Contains(total_Revenue))
                        Logger.WriteDebugMessage(total_Revenue + " matched with total Revenue under Total for Period section ");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_stay", Portfolio_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Room_Sold_out_Night", Room_Sold_out_Night);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_stay", Hotel_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_Revenue", total_Revenue, true);

                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        // Validate Cancellation Report
        public static void TC_252610()
        {
            if (TestCaseId == Utility.Constants.TC_252610)
            {
                //Pre-Requisite
                string password, username, Portfolio_value, startDate, enddate, environment, hotel, Portfolio_Name_stay, Hotel_Name_stay, parameter1_value, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, FilePath, FullPath, Filename, Worksheetname = "Cancellation Report", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_stay");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Hotel_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_stay");

                Logger.WriteInfoMessage("Test Case : Validate Cancellation Report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 

                Navigation.Select_Client(client);

                //Navigate to Pace Report
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Cancellation_Report();
                Navigation.Booking_Trends();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Cancellation_Report page");

                //TestHandling.ScreenMinimize();
                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Cancellation_Report());

                //Required field validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message dislayed for required fields");

                //Report with only mandatory field
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
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

                /*validate report with one filter at Portfolio Level*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Cancellation_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Pickup By Day Detailed page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Cancellation_Report());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                Helper.ScrollToText("Room Product:");
                ReportParameter.Select_RoomProduct_DDL();
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Room Product parameter");
                Helper.ScrollToText("View Analysis");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Room Product: Room; ");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Portfolio = hh.GetCellData(Worksheetname, 1, 2);
                    if (Portfolio.Contains(Portfolio_Name_stay))
                        Logger.WriteDebugMessage(Portfolio_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        scenario2 = false;
                }

                //Report with Multiple filter at Hotel Level
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Cancellation_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Annual Pickup by day page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Cancellation_Report());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                ReportParameter.Parameter_Channel();
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter1_value + "selected for Market");
                ReportParameter.Parameter_market();
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
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

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Hotel_Date = jj.GetCellData(Worksheetname, 1, 2);
                    if (Hotel_Date.Contains(Hotel_Name_stay))
                        Logger.WriteDebugMessage(Hotel_Name_stay + " matched with Report Hotel name and stay dates ");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_stay", Portfolio_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_stay", Hotel_Name_stay, true);
            }
        }


        //Validate Annual Pickup by Day
        public static void TC_252643()
        {
            if (TestCaseId == Utility.Constants.TC_252643)
            {
                //Pre-Requisite
                string password, username, Portfolio_value, environment, hotel, Portfolio_Name_stay, Hotel_Name_stay, parameter1_value, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, FilePath, FullPath, Filename, Worksheetname = "Annual Pickup by Day", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_stay");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Hotel_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_stay");

                Logger.WriteInfoMessage("Test Case :  Validate Annual Pickup by Day");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 

                Navigation.Select_Client(client);

                //Navigate to Pace Report
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Annual_Pickup_by_Day();
                Navigation.Booking_Trends();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Annual Pickup by days page");

                //TestHandling.ScreenMinimize();
                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Annual_Pickup_by_Day());

                //Varify filters on Annual Pickup by Day page`
                ReportParameter.Annual_Pickup_by_Day_filter();

                //Generate report without filter
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report Generated");

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

                /*validate report with one filter at Portfolio Level*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Annual_Pickup_by_Day();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on  Annual Pickup by days page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Annual_Pickup_by_Day());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Parameter_Channel();
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Room Product parameter");
                Helper.ScrollToText("View Analysis");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(40000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Portfolio = hh.GetCellData(Worksheetname, 1, 2);
                    if (Portfolio.Contains(Portfolio_Name_stay))
                        Logger.WriteDebugMessage(Portfolio_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter at Hotel Level
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Annual_Pickup_by_Day();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Annual Pickup by day page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Annual_Pickup_by_Day());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Parameter_Channel();
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Room Product parameter");
                ReportParameter.Parameter_market();
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

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Hotel_Date = jj.GetCellData(Worksheetname, 1, 2);
                    if (Hotel_Date.Contains(Hotel_Name_stay))
                        Logger.WriteDebugMessage(Hotel_Name_stay + " matched with Report Hotel name and stay dates ");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_stay", Portfolio_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_stay", Hotel_Name_stay, true);

            }
        }

        //Validate Length of Stay Report
        public static void TC_252644()
        {
            if (TestCaseId == Utility.Constants.TC_252644)
            {
                //Pre-Requisite
                string password, username, Portfolio_value, Today_Budget, startDate, enddate, environment, hotel, Portfolio_Name_stay, Hotel_Name_stay, parameter1_value, parameter2_value, parameter2, Currency, Today_Budget_Dec2020, Business_Unit, client, parameter1, FilePath, FullPath, Filename, Worksheetname = "Length of Stay Report", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_stay");
                Today_Budget = TestData.ExcelData.TestDataReader.ReadData(1, "Today_Budget");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Hotel_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_stay");
                Today_Budget_Dec2020 = TestData.ExcelData.TestDataReader.ReadData(1, "Today_Budget_Dec2020");

                Logger.WriteInfoMessage("Test Case :  Validate Length of Stay Report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Pace Report
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Length_of_Stay_Report();
                Navigation.Booking_Trends();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Length of stay report page");

                //TestHandling.ScreenMinimize();
                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Lenght_of_stay_Report());

                //Required field validation
                ReportParameter.Click_View_Analysis();

                //Report with only mandatory field
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(70000);
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
                /*validate report with one filter at Portfolio Level*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Length_of_Stay_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Length of stay Report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Lenght_of_stay_Report());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                ReportParameter.Select_RoomProduct_DDL();
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Room Product parameter");
                Helper.ScrollToText("View Analysis");
                ReportParameter.Click_View_Analysis();
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(70000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Room Product: Room;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                Helper.VerifyTextOnPageAndHighLight("Avg LOS");
                Helper.ScrollToText("Length of Stay Report");

                if (client == "Kerzner") 
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Portfolio = hh.GetCellData(Worksheetname, 1, 3);
                    if (Portfolio.Contains(Portfolio_Name_stay))
                        Logger.WriteDebugMessage(Portfolio_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        Assert.Fail("Report Portfolio name and stay dates not matched");

                    //TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    //string Budget = at.GetCellData(Worksheetname, 9, 40);
                    //if (Budget.Contains(Today_Budget))
                    //    Logger.WriteDebugMessage(Today_Budget + " matched with budget for today under December 2020 section ");
                    //else
                    //    scenario2 = false;
                }

                //Report with Multiple filter at Hotel Level
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Length_of_Stay_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Annual Pickup by day page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Lenght_of_stay_Report());

                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                ReportParameter.Parameter_Channel();
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected for Room Product parameter");
                ReportParameter.Parameter_Channel();
                ReportParameter.Parameter_market();
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(90000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                Helper.VerifyTextOnPageAndHighLight("Avg LOS");
                Helper.ScrollToText("Length of Stay Report");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Hotel_Date = jj.GetCellData(Worksheetname, 1, 3);
                    if (Hotel_Date.Contains(Hotel_Name_stay))
                        Logger.WriteDebugMessage(Hotel_Name_stay + " matched with Report Hotel name and stay dates ");
                    else
                        Assert.Fail("Report Hotel name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader kk = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Dec2020 = kk.GetCellData(Worksheetname, 9, 25);
                    if (Dec2020.Contains(Today_Budget_Dec2020))
                        Logger.WriteDebugMessage(Today_Budget_Dec2020 + " matched with total ADR under decemder 2020 year section ");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_stay", Portfolio_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Today_Budget", Today_Budget);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_stay", Hotel_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Today_Budget_Dec2020", Today_Budget_Dec2020, true);

                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        //Validate Rooms Lead time
        public static void TC_252645()
        {
            if (TestCaseId == Utility.Constants.TC_252645)
            {
                //Pre-Requisite
                string password, username, Portfolio_value, Reservation_Detail, startDate, enddate, environment, hotel, Portfolio_Name_stay, Hotel_Name_stay, parameter1_value, parameter2_value, parameter2, Currency, Today_Budget_Dec2020, Business_Unit, client, parameter1, FilePath, FullPath, Filename, Worksheetname = "Rooms Lead Time", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_stay");
                Reservation_Detail = TestData.ExcelData.TestDataReader.ReadData(1, "Reservation_Detail");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Hotel_Name_stay = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_stay");
                Today_Budget_Dec2020 = TestData.ExcelData.TestDataReader.ReadData(1, "Today_Budget_Dec2020");

                Logger.WriteInfoMessage("Test Case :  Validate Rooms Lead time");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 

                Navigation.Select_Client(client);

                //Navigate to Pace Report
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Rooms_Lead_Time();
                Navigation.Booking_Trends();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Rooms Lead Time report page");

                //TestHandling.ScreenMinimize();
                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Rooms_Lead_Time());

                //Required field validation
                ReportParameter.Click_View_Analysis();

                //Report with only mandatory field
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
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
                /*validate report with one filter at Portfolio Level*/
                //Navigate to Portfolio report
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Rooms_Lead_Time();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Rooms Lead Time Report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Rooms_Lead_Time());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                ReportParameter.Parameter_market();
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected for market parameter");
                Helper.ScrollToText("View Analysis");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(20000);
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
                    string Portfolio = hh.GetCellData(Worksheetname, 1, 3);
                    if (Portfolio.Contains(Portfolio_Name_stay))
                        Logger.WriteDebugMessage(Portfolio_Name_stay + " matched with Report Portfolio name and stay dates ");
                    else
                        Assert.Fail("Report Portfolio name and stay dates not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Detail = at.GetCellData(Worksheetname, 1, 13);
                    if (Detail.Contains(Reservation_Detail))
                        Logger.WriteDebugMessage(Reservation_Detail + " matched with budget for today under December 2020 section ");
                    else
                        scenario2 = false;
                }

                //Report with Multiple filter at Hotel Level
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Booking_Trends());
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Rooms_Lead_Time();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Rooms Lead Time report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Rooms_Lead_Time());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage(startDate + "Entered as start Date");
                Logger.WriteDebugMessage(enddate + "Entered as End Date");
                ReportParameter.Parameter_market();
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected for market parameter");
                ReportParameter.Parameter_market();
                ReportParameter.Select_RoomProduct_DDL();
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter2_value + "selected for Room Product");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Room Product: Room; Deluxe; Deluxe Family;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Hotel_Date = jj.GetCellData(Worksheetname, 1, 3);
                    if (Hotel_Date.Contains(Hotel_Name_stay))
                        Logger.WriteDebugMessage(Hotel_Name_stay + " matched with Report Hotel name and stay dates ");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_stay", Portfolio_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Reservation_Detail", Reservation_Detail);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_stay", Hotel_Name_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Today_Budget_Dec2020", Today_Budget_Dec2020, true);

                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }


    }
}
