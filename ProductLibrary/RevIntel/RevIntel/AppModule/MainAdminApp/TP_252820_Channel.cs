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
        //Validate the Channel Report
        public static void TC_252831()
        {
            if (TestCaseId == Utility.Constants.TC_252831)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Portfolio_NameDate, Room_Night, Hotel, Prior_Revenue,parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Totals", reportName;
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
                Room_Night = TestData.ExcelData.TestDataReader.ReadData(1, "Room_Night");
                Portfolio_NameDate = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_NameDate");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Prior_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Prior_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Channel Report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Menu_Channel();
                Logger.WriteDebugMessage("Channel drop down displayed");
                Navigation.Click_Channel_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Channel Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Channel_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                //Required field Validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Required field validation message is displaying");

                //Report with Required Field
                ReportParameter.Enter_startDate_EndDate(startDate, enddate);

                //Verify Data in export document and in front end 
                ReportParameter.Report_Excel_Format();

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                //FilePath = "C:\\Users\\ltuser\\Downloads";
                Filename = ReportParameter.VerifyFileFormate(FilePath);

                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                string Name = tt.GetCellData(Worksheetname,3, 1);
                if (Name.Equals(reportName))
                    Logger.WriteInfoMessage(reportName + " matched with Report name ");
                else
                    scenario1 = false;

                Helper.ReloadPage();

                /*validate report with one filter*/
                Navigation.Click_Menu_Channel();
                Logger.WriteDebugMessage("Channel Dropdown displayed");
                Navigation.Click_Channel_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Channel report  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Channel_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
                Helper.AddDelay(1000);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(70000);
                Logger.WriteDebugMessage("Report generated");
                //Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                //Verify Data in export document and in front end 
                ReportParameter.Report_Excel_Format();

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                string Name_stay = hh.GetCellData(Worksheetname,4,3);
                if (Name_stay.Contains(Portfolio_NameDate))
                    Logger.WriteInfoMessage(Portfolio_NameDate + " matched with Report name ");
                else
                    Assert.Fail("Report name and stay not matched");

                TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                string Room = at.GetCellData(Worksheetname,8,31);
                if (Room.Contains(Room_Night))
                    Logger.WriteInfoMessage(Room_Night + " matched with Room_Night under Current Year section");
                else
                    scenario2 = false;

                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Menu_Channel();
                Logger.WriteDebugMessage("Channel Dropdown displayed");
                Navigation.Click_Channel_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on channel report  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Channel_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
               // Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market drop down displayed");
                Helper.AddDelay(1000);
                ReportParameter.Select_SourceMarket_value();
                Helper.AddDelay(1000);
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Market");
                Helper.AddDelay(1000);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(90000);
                Logger.WriteDebugMessage("Report generated");
                //Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; Central Africa; ");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                //Verify Data in export document and in front end 
                ReportParameter.Report_Excel_Format();

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                string Revenue = ll.GetCellData(Worksheetname,15,20);
                if (Revenue.Contains(Prior_Revenue))
                    Logger.WriteInfoMessage(Prior_Revenue + " matched with total revenue under Prior year section");
                else
                    scenario3 = false;

                //Delete downloaded file
                TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);

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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_NameDate", Portfolio_NameDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Room_Night", Room_Night);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Prior_Revenue", Prior_Revenue, true);
            }
        }

        //Validate the Channel Trend Report
        public static void TC_252832()
        {
            if (TestCaseId == Utility.Constants.TC_252832)
            {
                //Pre-Requisite
                string password, username, environment, booking_enddate, Portfolio_value, booking_startDate, Compare_Start_Date, Compare_End_Date, Portfolio_Name_Date, Hotel, Compare_ADR, Subject_Room, parameter2_value, parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Channel Trend Report", reportName;
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
                booking_startDate = TestData.ExcelData.TestDataReader.ReadData(1, "booking_startDate");
                booking_enddate = TestData.ExcelData.TestDataReader.ReadData(1, "booking_enddate");
                Compare_Start_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Compare_Start_Date");
                Compare_End_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Compare_End_Date");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_Date");
                Subject_Room = TestData.ExcelData.TestDataReader.ReadData(1, "Subject_Room");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Compare_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "Compare_ADR");

                Logger.WriteInfoMessage("Test Case : Validate the Channel Trend Report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Menu_Channel();
                Logger.WriteDebugMessage("Channel drop down displayed");
                Navigation.Click_Channel_Trend_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Click_Channel_Trend_Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Channel_Trend_Report());

                //Required field Validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Required field validation message is displaying");
                Helper.AddDelay(1000);
                //Report with Required Field
                ReportParameter.Compare_Start_Date(Compare_Start_Date);
                ReportParameter.Compare_End_Date(Compare_End_Date);
                Logger.WriteDebugMessage("Enter Compare Start date as = " + Compare_Start_Date);
                Logger.WriteDebugMessage("Enter Compare enddate as = " + Compare_End_Date);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Helper.AddDelay(1000);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(70000);
                Logger.WriteDebugMessage("Report generated");

                //Verify Data in export document and in front end 
                ReportParameter.Report_Excel_Format();

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                string Name = tt.GetCellData(Worksheetname,1,1);
                if (Name.Equals(reportName))
                    Logger.WriteInfoMessage(reportName + " matched with Report name ");
                else
                    scenario1 = false;

                /*validate report with one filter*/
                Helper.ReloadPage();
                Navigation.Click_Menu_Channel();
                Logger.WriteDebugMessage("Channel Dropdown displayed");
                Navigation.Click_Channel_Trend_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on channel Trend Report  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Channel_Trend_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Helper.ScrollToText("Booking Date:");
                Business_Source.BookingStartDate(booking_startDate);
                Logger.WriteDebugMessage(booking_startDate + " entered as booking start date");
                Business_Source.BookingEndDate(booking_enddate);
                Logger.WriteDebugMessage(booking_enddate + " entered as booking end date");
                ReportParameter.Compare_Start_Date(Compare_Start_Date);
                ReportParameter.Compare_End_Date(Compare_End_Date);
                Logger.WriteDebugMessage("Enter Compare Start date as = " + Compare_Start_Date);
                Logger.WriteDebugMessage("Enter Compare enddate as = " + Compare_End_Date);
                ReportParameter.Select_SourceMarket_DDL();
                ReportParameter.Select_SourceMarket_value();
                ReportParameter.Select_SourceMarket_DDL();
                Helper.PageUp();
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(70000);
                Logger.WriteDebugMessage("Report generated with only any error");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s): Booking Date: 11/1/2020 - 11/30/2020 ; Source Market: Africa;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                //Verify Data in export document and in front end 
                ReportParameter.Report_Excel_Format();

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                string Name_stay = hh.GetCellData(Worksheetname,1,3);
                if (Name_stay.Contains(Portfolio_Name_Date))
                    Logger.WriteInfoMessage(Portfolio_Name_Date + " matched with Report name ");
                else
                    scenario2 = false;

                //Report with Multiple filter and excel column validation
                Helper.ReloadPage();
                Navigation.Click_Menu_Channel();
                Logger.WriteDebugMessage("channel Dropdown displayed");
                Navigation.Click_Channel_Trend_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on channel Trend Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Channel_Trend_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_SourceMarket_DDL();
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage("Source Market drop down displayed");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage(parameter1_value + "Selected as Source Market");
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Market");
                ReportParameter.Compare_Start_Date(Compare_Start_Date);
                Logger.WriteDebugMessage("Enter Compare Start date as = " + Compare_Start_Date);
                ReportParameter.Compare_End_Date(Compare_End_Date);
                Logger.WriteDebugMessage("Enter Compare enddate as = " + Compare_End_Date);
                PageUp();
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(70000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; ");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                //Verify Data in export document and in front end 
                ReportParameter.Report_Excel_Format();

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                string ADR = ll.GetCellData(Worksheetname,28, 20);
                if (ADR.Contains(Compare_ADR))
                    Logger.WriteInfoMessage(Compare_ADR + " matched with total ADR under Compare section for Africa");
                else
                    scenario3 = false;

                //Delete downloaded file
                TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);

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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_booking_startDate", booking_startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_booking_enddate", booking_enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_Date", Portfolio_Name_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Subject_Room", Subject_Room);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Compare_ADR", Compare_ADR, true);
            }
        }

        //Validate the Daily Channel by Room Type
        public static void TC_252833()
        {
            if (TestCaseId == Utility.Constants.TC_252833)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Portfolio_NameDate, Total_Room, Hotel, Total_Revenue, Parameter2_Value, Parameter2, Currency, Business_Unit, client, Parameter1, Parameter1_Value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Daily Channel by Room Type", reportName;
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
                Parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1");
                Parameter1_Value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1_Value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Total_Room = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Room");
                Portfolio_NameDate = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_NameDate");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                Parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2");
                Parameter2_Value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2_Value");
                Total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Channel Report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Menu_Channel();
                Logger.WriteDebugMessage("Channel drop down displayed");
                Helper.AddDelay(1000);
                Navigation.Click_Daily_Channel_by_Room_Type();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Channel Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Daily_Channel_by_Room_Type_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                //Required field Validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Required field validation message is displaying");

                //Report with Required Field
                ReportParameter.Enter_startDate_EndDate(startDate, enddate);

                //Verify Data in export document and in front end 
                ReportParameter.Report_Excel_Format();

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                string Name = tt.GetCellData(Worksheetname,1, 1);
                if (Name.Equals(reportName))
                    Logger.WriteInfoMessage(reportName + " matched with Report name ");
                else
                    scenario1 = false;

                Helper.ReloadPage();

                /*validate report with one filter*/
                Navigation.Click_Menu_Channel();
                Logger.WriteDebugMessage("Channel Dropdown displayed");
                Navigation.Click_Daily_Channel_by_Room_Type();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Channel report  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Daily_Channel_by_Room_Type_Report());

                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage(Parameter1_Value + "Selected as source market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(70000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                //Verify Data in export document and in front end 
                ReportParameter.Report_Excel_Format();

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                string Name_stay = hh.GetCellData(Worksheetname, 1, 3);
                if (Name_stay.Contains(Portfolio_NameDate))
                    Logger.WriteInfoMessage(Portfolio_NameDate + " matched with Report name ");
                else
                    Assert.Fail("Report name and stay not matched");

                TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                string Room = at.GetCellData(Worksheetname,5,29);
                if (Room.Contains(Total_Room))
                    Logger.WriteInfoMessage(Total_Room + " matched with total room under Marina Mountain View");
                else
                    scenario2 = false;

                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Menu_Channel();
                Logger.WriteDebugMessage("Channel Dropdown displayed");
                Navigation.Click_Daily_Channel_by_Room_Type();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on channel report  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Daily_Channel_by_Room_Type_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage(Parameter1_Value + "Selected as source market");
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(Parameter2_Value + "selected for Market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(70000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; Central Africa; ");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                //Verify Data in export document and in front end 
                ReportParameter.Report_Excel_Format();

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                string Revenue = ll.GetCellData(Worksheetname,19,19);
                if (Revenue.Contains(Total_Revenue))
                    Logger.WriteInfoMessage(Total_Revenue + " matched with total revenue for Palm Delux section for 10/24");
                else
                    scenario3 = false;

                //Delete downloaded file
                TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);

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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", Parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", Parameter1_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_NameDate", Portfolio_NameDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Room", Total_Room);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", Parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", Parameter1_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", Parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", Parameter2_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Revenue", Total_Revenue, true);
            }
        }


    }
}
