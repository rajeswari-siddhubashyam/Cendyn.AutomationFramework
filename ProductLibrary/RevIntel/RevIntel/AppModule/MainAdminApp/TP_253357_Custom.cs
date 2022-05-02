using AventStack.ExtentReports.Model;
using BaseUtility.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using RevIntel.AppModule.UI;
using RevIntel.PageObject.UI;
using RevIntel.Utility;
using System;

namespace RevIntel.AppModule.MainAdminApp
{
    public partial class MainAdminApp : RevIntel.Utility.Setup
    {
        //Validate the OTB Comparison By Segment
        public static void TC_253358()
        {
            if (TestCaseId == Utility.Constants.TC_253358)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, As_Of_Date, Portfolio_Name_Date, Hotel, Total_19, Total_DIR19, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Oct-20 -Nights", reportName;
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
                As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_Date");
                Total_DIR19 = TestData.ExcelData.TestDataReader.ReadData(1, "Total_DIR19");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Total_19 = TestData.ExcelData.TestDataReader.ReadData(1, "Total_19");

                Logger.WriteInfoMessage("Test Case : Validate the OTB Comparison By Segment");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_OTB_Comparison_by_Segment_Reports();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on OTB Comparison By Segment Report Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_OTB_Comparison_by_Segment_Report());

                //Select Currency and Business Value
                ReportParameter.Select_Hotel_DDL();
                ReportParameter.Select_Hotel_value();
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
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter As of date as = " + As_Of_Date);
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
                Helper.ReloadPage();

                /*validate report with one filter*/
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_OTB_Comparison_by_Segment_Reports();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on OTB Comparison By Segment Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_OTB_Comparison_by_Segment_Report());

                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter As of date as = " + As_Of_Date);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
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
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteDebugMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Total = at.GetCellData(Worksheetname, 4, 44);
                    if (Total.Contains(Total_DIR19))
                        Logger.WriteDebugMessage(Total_DIR19 + " matched with total DIR 19");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_OTB_Comparison_by_Segment_Reports();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on OTB Comparison By Segment Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_OTB_Comparison_by_Segment_Report());

                ReportParameter.HotelorPortfolio_Dropdown_Arrow();
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(Hotel + "is selected as Hotel");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter As of date as = " + As_Of_Date);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage(parameter1_value + "Selected as market");
                Helper.ScrollToText("Room Product:");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter2_value + "selected for Room Product");
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
                    string Comp_Total_19 = ll.GetCellData(Worksheetname, 40, 44);
                    if (Comp_Total_19.Contains(Total_19))
                        Logger.WriteDebugMessage(Total_19 + " matched with Total 19 for Total including Comp section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_Date", Portfolio_Name_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_DIR19", Total_DIR19);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario3_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_19", Total_19, true);
            }
        }

        //Validate the Daily Pickup
        public static void TC_253359()
        {
            if (TestCaseId == Utility.Constants.TC_253359)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value,Portfolio_Name_Date, Hotel, As_Of_Date, Pickup, Total_Pickup_STLY, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Daily Pick Up Report", reportName;
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
                As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_Date");
                Total_Pickup_STLY = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Pickup_STLY");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Pickup = TestData.ExcelData.TestDataReader.ReadData(1, "Pickup");

                Logger.WriteInfoMessage("Test Case : Validate the Daily Pickup");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_Daily_Pick_Up_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Daily Pickup Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Daily_Pick_Up_Report());

                //Required field Validation
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Click_View_Analysis();
                VerifyTextOnPageAndHighLight("Required");
                Logger.WriteDebugMessage("Required field validation message is displaying");

                //Report with Required Field
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter As of date as = " + As_Of_Date);
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
                    string Name = tt.GetCellData(Worksheetname, 1, 2);
                    if (Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;
                }
                Helper.ReloadPage();
                /*validate report with one filter*/
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_Daily_Pick_Up_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Daily Pickup Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Daily_Pick_Up_Report());

                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter As of date as = " + As_Of_Date);
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected as Channel");
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
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 3);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteDebugMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Pickup_STLY = at.GetCellData(Worksheetname, 2, 41);
                    if (Pickup_STLY.Contains(Total_Pickup_STLY))
                        Logger.WriteDebugMessage(Total_Pickup_STLY + " matched with Total_Pickup_STLY");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_Daily_Pick_Up_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Daily Analysis Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Daily_Pick_Up_Report());

                ReportParameter.HotelorPortfolio_Dropdown_Arrow();
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(Hotel + "is selected as Hotel");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter As of date as = " + As_Of_Date);
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected as Channel");
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
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

                    TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Total_Pickup = ll.GetCellData(Worksheetname, 2, 40);
                    if (Total_Pickup.Contains(Pickup))
                        Logger.WriteDebugMessage(Pickup + " matched with Total Pickup");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_Date", Portfolio_Name_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Pickup_STLY", Total_Pickup_STLY);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario3_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Pickup", Pickup, true);
            }
        }

        //Validate the Revenue by Room Product
        public static void TC_253360()
        {
            if (TestCaseId == Utility.Constants.TC_253360)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Portfolio_Name_Date, As_Of_Date,Hotel, Total_ALL_Room_Left, Total_TTL, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Nov-20", reportName;
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
                As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_Date");
                Total_TTL = TestData.ExcelData.TestDataReader.ReadData(1, "Total_TTL");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Total_ALL_Room_Left = TestData.ExcelData.TestDataReader.ReadData(1, "Total_ALL_Room_Left");

                Logger.WriteInfoMessage("Test Case : Validate the Revenue by Room Product");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custum menu drop down displayed");
                Navigation.Click_Revenue_By_Room_Product_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed Revenue by Room Product Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Revenue_By_Room_Product_Report());

                //Required field Validation
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Click_View_Analysis();
                VerifyTextOnPageAndHighLight("Required");
                Logger.WriteDebugMessage("Required field validation message is displaying");

                //Report with Required Field
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter As of date as = " + As_Of_Date);
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
                Helper.ReloadPage();
                /*validate report with one filter*/
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_Revenue_By_Room_Product_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed Revenue by Room Product Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Revenue_By_Room_Product_Report());

                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter As of date as = " + As_Of_Date);
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
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

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 3);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteDebugMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string TTL = at.GetCellData(Worksheetname, 6, 107);
                    if (TTL.Contains(Total_TTL))
                        Logger.WriteDebugMessage(Total_TTL + " matched withTotal_TTL");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_Revenue_By_Room_Product_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed Revenue by Room Product Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Revenue_By_Room_Product_Report());

                ReportParameter.HotelorPortfolio_Dropdown_Arrow();
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(Hotel + "is selected as Hotel");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter As of date as = " + As_Of_Date);
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
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Total_ALL_Room = ll.GetCellData(Worksheetname, 11, 107);
                    if (Total_ALL_Room.Contains(Total_ALL_Room_Left))
                        Logger.WriteDebugMessage(Total_ALL_Room_Left + " matched with total left under Total All Room section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_Date", Portfolio_Name_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_TTL", Total_TTL);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario3_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_ALL_Room_Left", Total_ALL_Room_Left, true);
            }
        }

        //Validate the Pickup by Market Segment
        public static void TC_253361()
        {
            if (TestCaseId == Utility.Constants.TC_253361)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Portfolio_Name_Date, Pickup_enddate, Pickup_startDate, Hotel, Direct_RMS, Leisure_RMS, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "All Months", reportName;
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
                Pickup_startDate = TestData.ExcelData.TestDataReader.ReadData(1, "Pickup_startDate");
                Pickup_enddate = TestData.ExcelData.TestDataReader.ReadData(1, "Pickup_enddate");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_Date");
                Leisure_RMS = TestData.ExcelData.TestDataReader.ReadData(1, "Leisure_RMS");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Direct_RMS = TestData.ExcelData.TestDataReader.ReadData(1, "Direct_RMS");

                Logger.WriteInfoMessage("Test Case : Validate the Pickup by Market Segment");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_Pickup_by_Market_Segment_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Pickup by Market Segment Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pickup_by_Market_Segment_Report());

                //Required field Validation
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Required field validation message is displaying");

                //Report with Required Field
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Pickup_startDate(Pickup_startDate);
                Logger.WriteDebugMessage("Enter Pickup start date as = " + Pickup_startDate);
                ReportParameter.Pickup_enddate(Pickup_enddate);
                Logger.WriteDebugMessage("Enter Pickup_enddate as = " + Pickup_enddate);
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
                    string Name = tt.GetCellData(Worksheetname, 2, 1);
                    if (Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;
                }
                Helper.ReloadPage();
                /*validate report with one filter*/
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_Pickup_by_Market_Segment_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Pickup by Market Segment Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pickup_by_Market_Segment_Report());

                //Report with one parameter
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Pickup_startDate(Pickup_startDate);
                Logger.WriteDebugMessage("Enter Pickup start date as = " + Pickup_startDate);
                ReportParameter.Pickup_enddate(Pickup_enddate);
                Logger.WriteDebugMessage("Enter Pickup_enddate as = " + Pickup_enddate);
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_DDL();
                Logger.WriteDebugMessage("Portfolio drop down displyed");
                ReportParameter.Portfolio_DDL_value(GlobalParameter.Portfolio);
                Logger.WriteDebugMessage(Portfolio_value + "Selected");
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
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

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_stay = hh.GetCellData(Worksheetname, 2, 3);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteInfoMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string RMS = at.GetCellData(Worksheetname, 16, 24);
                    if (RMS.Contains(Leisure_RMS))
                        Logger.WriteInfoMessage(Leisure_RMS + " matched with total Leisure RMS for 2020 section");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_Pickup_by_Market_Segment_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Pickup by Market Segment Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pickup_by_Market_Segment_Report());

                ReportParameter.HotelorPortfolio_Dropdown_Arrow();
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(Hotel + "is selected as Hotel");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Pickup_startDate(Pickup_startDate);
                Logger.WriteDebugMessage("Enter Pickup start date as = " + Pickup_startDate);
                ReportParameter.Pickup_enddate(Pickup_enddate);
                Logger.WriteDebugMessage("Enter Pickup_enddate as = " + Pickup_enddate);
                Helper.ScrollToText("Room Product:");
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage(parameter2_value + "selected for Room Product");
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

                    TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Direct = ll.GetCellData(Worksheetname, 3, 24);
                    if (Direct.Contains(Direct_RMS))
                        Logger.WriteInfoMessage(Direct_RMS + " matched with total Room for Prior year");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Pickup_startDate", Pickup_startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Pickup_enddate", Pickup_enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_Date", Portfolio_Name_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Leisure_RMS", Leisure_RMS);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario3_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Direct_RMS", Direct_RMS, true);
            }
        }

        //Validate the OTB Comparison for All Segments
        public static void TC_253362()
        {
            if (TestCaseId == Utility.Constants.TC_253362)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Portfolio_Name_Date, As_Of_Date, Hotel, Current_Year_Budget_Room, Comparison_Year_ADR, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Budget Totals", reportName;
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
                As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_Date");
                Comparison_Year_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "Comparison_Year_ADR");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Current_Year_Budget_Room = TestData.ExcelData.TestDataReader.ReadData(1, "Current_Year_Budget_Room");

                Logger.WriteInfoMessage("Test Case : Validate the OTB Comparison for All Segments");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_OTB_Comparison_for_All_Segments_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on OTB Comparison for All Segments Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_OTB_Comparison_for_All_Segments_Report());

                //Required field Validation
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Click_View_Analysis();
                VerifyTextOnPageAndHighLight("Required");
                Logger.WriteDebugMessage("Required field validation message is displaying");

                //Report with Required Field
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter as of date = " + As_Of_Date);
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
                Helper.ReloadPage();
                /*validate report with one filter*/
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_OTB_Comparison_for_All_Segments_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on OTB Comparison for All Segments Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_OTB_Comparison_for_All_Segments_Report());

                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter as of date = " + As_Of_Date);
                Helper.ScrollToText("Room Product:");
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
                    string ADR = at.GetCellData(Worksheetname, 3, 11);
                    if (ADR.Contains(Comparison_Year_ADR))
                        Logger.WriteInfoMessage(Comparison_Year_ADR + " matched with total ADR under Comparison_Year section");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_OTB_Comparison_for_All_Segments_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on OTB Comparison for All Segments Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_OTB_Comparison_for_All_Segments_Report());

                ReportParameter.HotelorPortfolio_Dropdown_Arrow();
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(Hotel + "is selected as Hotel");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter as of date = " + As_Of_Date);
                Helper.ScrollToText("Room Product:");
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
                    string Room = ll.GetCellData(Worksheetname, 28, 11);
                    if (Room.Contains(Current_Year_Budget_Room))
                        Logger.WriteInfoMessage(Current_Year_Budget_Room + " matched with Room under Current_Year_Budget section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_Date", Portfolio_Name_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison_Year_ADR", Comparison_Year_ADR);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario3_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current_Year_Budget_Room", Current_Year_Budget_Room, true);
            }
        }

        //Validate the OTB vs Budget by Segment
        public static void TC_253363()
        {
            if (TestCaseId == Utility.Constants.TC_253363)
            {
                //Pre-Requisite
                string password, username, As_Of_Date, environment, Portfolio_value, Portfolio_Name_Date, Hotel, Total_ADR, Total_Rmnts, Start_Month, Currency, Business_Unit, client, FilePath, FullPath, Filename, Worksheetname = "December Totals", reportName;
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
                Start_Month = TestData.ExcelData.TestDataReader.ReadData(1, "Start_Month");
                As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_Date");
                Total_Rmnts = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Rmnts");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                Total_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "Total_ADR");

                Logger.WriteInfoMessage("Test Case : Validate the OTB vs Budget by Segment");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_OTB_vs_Budget_by_Segment_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on OTB vs Budget by Segment report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_OTB_vs_Budget_by_Segment_Report());

                //Required field Validation
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_Pace_Trend_Start_Month(Start_Month);
                Logger.WriteDebugMessage("Start Month Enter as " + Start_Month);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter As_Of_Date as " + As_Of_Date);
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
                Helper.ReloadPage();
                /*validate report with one filter*/
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_OTB_vs_Budget_by_Segment_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on OTB vs Budget by Segment report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_OTB_vs_Budget_by_Segment_Report());

                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_DDL();
                Logger.WriteDebugMessage("Portfolio drop down displyed");
                ReportParameter.Portfolio_DDL_value(GlobalParameter.Portfolio);
                Logger.WriteDebugMessage(Portfolio_value + "Selected");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_Pace_Trend_Start_Month(Start_Month);
                Logger.WriteDebugMessage("Start Month Enter as " + Start_Month);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter As_Of_Date as " + As_Of_Date);
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

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 2);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteInfoMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Rmnts = at.GetCellData(Worksheetname, 15, 30);
                    if (Rmnts.Contains(Total_Rmnts))
                        Logger.WriteInfoMessage(Total_Rmnts + " matched with total Adults under Sleepers section");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_OTB_vs_Budget_by_Segment_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on OTB vs Budget by Segment report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_OTB_vs_Budget_by_Segment_Report());

                ReportParameter.HotelorPortfolio_Dropdown_Arrow();
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(Hotel + "is selected as Hotel");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_Pace_Trend_Start_Month(Start_Month);
                Logger.WriteDebugMessage("Start Month Enter as " + Start_Month);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter As_Of_Date as " + As_Of_Date);
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

                    TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR = ll.GetCellData(Worksheetname, 17, 25);
                    if (ADR.Contains(Total_ADR))
                        Logger.WriteInfoMessage(Total_ADR + " matched with total ADR value under December-2020 section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start_Month", Start_Month);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_Date", Portfolio_Name_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Rmnts", Total_Rmnts);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario3_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_ADR", Total_ADR, true);
            }
        }

        //Validate the OTB vs Forecast by Segment
        public static void TC_253364()
        {
            if (TestCaseId == Utility.Constants.TC_253364)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Portfolio_Name_Date, hotel, Total_Rmnts, Currency, Business_Unit, client, Start_Month, As_Of_Date, FilePath, FullPath, Filename, Worksheetname = "December", reportName;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                Start_Month = TestData.ExcelData.TestDataReader.ReadData(1, "Start_Month");
                As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_Date");
                Total_Rmnts = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Rmnts");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");

                Logger.WriteInfoMessage("Test Case : Validate the OTB vs Forecast by Segment");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_OTB_vs_Forecast_by_Segment_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on OTB vs Forecast by Segment report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_OTB_vs_Forecast_by_Segment_Report());

                //Required field Validation
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                Helper.ElementClearText(PageObject_ReportParameter.Enter_Pace_Trend_Start_Month());
                Helper.ElementClearText(PageObject_ReportParameter.Enter_As_Of_Date());
                ReportParameter.Click_View_Analysis();
                VerifyTextOnPageAndHighLight("Required");
                Logger.WriteDebugMessage("Required field validation message is displaying");

                ReportParameter.Enter_Pace_Trend_Start_Month(Start_Month);
                Logger.WriteDebugMessage("Start Month Enter as " + Start_Month);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter As_Of_Date as " + As_Of_Date);
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
                        Assert.Fail("Report name not matched");
                }
                Helper.ReloadPage();
                /*validate report with one filter*/
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_OTB_vs_Forecast_by_Segment_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Daily Analysis PerPerson report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_OTB_vs_Forecast_by_Segment_Report());

                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_DDL();
                Logger.WriteDebugMessage("Portfolio drop down displyed");
                ReportParameter.Portfolio_DDL_value(GlobalParameter.Portfolio);
                Logger.WriteDebugMessage(Portfolio_value + "Selected");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_Pace_Trend_Start_Month(Start_Month);
                Logger.WriteDebugMessage("Start Month Enter as " + Start_Month);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter As_Of_Date as " + As_Of_Date);
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

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 2);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteInfoMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Rmnts = at.GetCellData(Worksheetname, 4, 41);
                    if (Rmnts.Contains(Total_Rmnts))
                        Logger.WriteInfoMessage(Total_Rmnts + " matched with Total_Rmnts under Direct section");
                    else
                        Assert.Fail("Report not matched with Total_Rmnts under Direct section");


                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start_Month", Start_Month);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_Date", Portfolio_Name_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Rmnts", Total_Rmnts, true);
            }
        }

        //Validate the Room Type Booked Vs Occupied
        public static void TC_280393()
        {
            if (TestCaseId == Utility.Constants.TC_280393)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Portfolio_Name_Date, PriorYear, currentyear, As_Of_Date, Hotel, Current_Year_Booked_RN, Comparison_Year_ADR, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, 
                    startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Room Type Booked vs Occupied", reportName;
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
                As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                currentyear = TestData.ExcelData.TestDataReader.ReadData(1, "currentyear");
                PriorYear = TestData.ExcelData.TestDataReader.ReadData(1, "PriorYear");
                Portfolio_Name_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_Date");
                Comparison_Year_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "Comparison_Year_ADR");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Current_Year_Booked_RN = TestData.ExcelData.TestDataReader.ReadData(1, "Current_Year_Booked_RN");

                Logger.WriteInfoMessage("Test Case : Validate the Room Type Booked Vs Occupied");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_Room_Type_Booked_vs_Occupied();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Room Type Booked Vs Occupied Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Booked_vs_Occupied());

                //Required field Validation
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Click_View_Analysis();
                VerifyTextOnPageAndHighLight("Required");
                Logger.WriteDebugMessage("Required field validation message is displaying");

                //Report with Required Field
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
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
                    string Name = tt.GetCellData(Worksheetname, 1, 2);
                    if (Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string current_year = at.GetCellData(Worksheetname,13,9);
                    if (current_year.Equals(currentyear))
                        Logger.WriteDebugMessage(currentyear + " column added  for current year ");
                    else
                        Assert.Fail("Occ to Bkd % added  for current year");

                    TestData.ExcelData.ExcelDataReader dt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Prior_Year = dt.GetCellData(Worksheetname,29,9);
                    if (Prior_Year.Equals(PriorYear))
                        Logger.WriteDebugMessage(PriorYear + " column added  for Prior year");
                    else
                        scenario1 = false;
                }
                Helper.ReloadPage();
                /*validate report with one filter*/
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_Room_Type_Booked_vs_Occupied();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Click_Room_Type_Booked_vs_Occupied Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Booked_vs_Occupied());

                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Helper.ScrollToText("Room Product:");
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
                    string Name_stay = hh.GetCellData(Worksheetname, 1,4);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteInfoMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR = at.GetCellData(Worksheetname, 5, 160);
                    if (ADR.Contains(Comparison_Year_ADR))
                        Logger.WriteInfoMessage(Comparison_Year_ADR + " matched with total ADR under Comparison_Year booked section");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Custom_Menu();
                Logger.WriteDebugMessage("Custom menu drop down displayed");
                Navigation.Click_Room_Type_Booked_vs_Occupied();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Click_Room_Type_Booked_vs_Occupied Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Booked_vs_Occupied());

                ReportParameter.HotelorPortfolio_Dropdown_Arrow();
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(Hotel + "is selected as Hotel");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Helper.ScrollToText("Room Product:");
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
                    string RN = ll.GetCellData(Worksheetname,8, 24);
                    if (RN.Contains(Current_Year_Booked_RN))
                        Logger.WriteInfoMessage(Current_Year_Booked_RN + " matched with Room under Current_Year_Budget section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_Date", Portfolio_Name_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison_Year_ADR", Comparison_Year_ADR);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario3_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current_Year_Booked_RN", Current_Year_Booked_RN);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current_Year_ColumnValue", currentyear);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Prior_Year_ColumnValue", PriorYear, true);
            }
        }

    }
}

