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
        //Validate Room Type analysis Current year data
        public static void TC_279701()

        {
            if (TestCaseId == Utility.Constants.TC_279701)
            {
                //Pre-Requisite
                string password, username, environment, currency, Business_Unit, client,
                    Hotel, startDate, enddate,
                    FilePath, FullPath, Filename, Worksheetname = "Room Type Analysis", reportName;
                bool scenario1 = true, scenario2 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel");
                currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");

                Logger.WriteInfoMessage("Test Case : Validate Room Type analysis Current year data");

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

                //Generate the report  with Comparison Year as 1 at Hotel Level 
                ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM();
                Logger.WriteDebugMessage("Comparison Year DDM clicked");
                ReportParameter.Select_RoomTypeAnalysis_ComparisonYear1();
                Logger.WriteDebugMessage("Comparison year selected as 1");
                Helper.ScrollToText("View Analysis");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");

                //Verify Data in export document and in front end 
                ReportParameter.Report_Excel_Format();

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                TestData.ExcelData.ExcelDataReader tt1 = new TestData.ExcelData.ExcelDataReader(FullPath);
                string RoomSold_CompaYear1 = tt1.GetCellData(Worksheetname, 4, 42);
                string Mix_CompaYear1 = tt1.GetCellData(Worksheetname, 5, 42);
                string ADR_CompaYear1 = tt1.GetCellData(Worksheetname, 6, 42);
                string Revenue_CompaYear1 = tt1.GetCellData(Worksheetname, 7, 42);

                //Report with Comparison Year as 2 at Hotel Level
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Room Type menu drop down displayed");
                Navigation.Click_Room_Type_Analysis_Report();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Room Type Analysis Report Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Analysis_Report());

                //Generate the report  with Comparison Year as 2 at Hotel Level 
                ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM();
                Logger.WriteDebugMessage("Comparison Year DDM clicked");
                ReportParameter.Select_RoomTypeAnalysis_ComparisonYear2();
                Logger.WriteDebugMessage("Comparison year selected as 2");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");

                //Verify Data in export document and in front end 
                ReportParameter.Report_Excel_Format();

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                TestData.ExcelData.ExcelDataReader rr = new TestData.ExcelData.ExcelDataReader(FullPath);
                string RoomSold_CompaYear2 = rr.GetCellData(Worksheetname, 4, 55);
                string Mix_CompaYear2 = rr.GetCellData(Worksheetname, 5, 55);
                string ADR_CompaYear2 = rr.GetCellData(Worksheetname, 6, 55);
                string Revenue_CompaYear2 = rr.GetCellData(Worksheetname, 7, 55);

                //Report with Comparison Year as 3 at Hotel Level
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Room Type menu drop down displayed");
                Navigation.Click_Room_Type_Analysis_Report();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Room Type Analysis Report Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Analysis_Report());

                //Generate the report  with Comparison Year as 3 at Hotel Level 
                ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM();
                Logger.WriteDebugMessage("Comparison Year DDM clicked");
                ReportParameter.Select_RoomTypeAnalysis_ComparisonYear3();
                Logger.WriteDebugMessage("Comparison year selected as 3");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");

                //Verify Data in export document and in front end 
                ReportParameter.Report_Excel_Format();

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                TestData.ExcelData.ExcelDataReader uu = new TestData.ExcelData.ExcelDataReader(FullPath);
                string RoomSold_CompaYear3 = uu.GetCellData(Worksheetname, 4, 52);
                string Mix_CompaYear3 = uu.GetCellData(Worksheetname, 5, 52);
                string ADR_CompaYear3 = uu.GetCellData(Worksheetname, 6, 52);
                string Revenue_CompaYear3 = uu.GetCellData(Worksheetname, 7, 52);

                //Validation by comparing reports
                //Compare report Current year value for Comparision year 1 and comparision year 2.
                if (RoomSold_CompaYear1.Equals(RoomSold_CompaYear2))
                    Logger.WriteDebugMessage("Total Room Sold value under current year section matched with Comparision year 1 and comparision year 2");
                else
                    Assert.Fail("Total Room Sold value under current year section not matched with Comparision year 1 and comparision year 2");

                if (Mix_CompaYear1.Equals(Mix_CompaYear2))
                    Logger.WriteDebugMessage("Total Mix% value under current year section matched with Comparision year 1 and comparision year 2");
                else
                    Assert.Fail("Total Mix% value under current year section not matched with Comparision year 1 and comparision year 2");

                if (ADR_CompaYear1.Equals(ADR_CompaYear2))
                    Logger.WriteDebugMessage("Total ADR value under current year section matched with Comparision year 1 and comparision year 2");
                else
                    Assert.Fail("Total ADR value under current year section not matched with Comparision year 1 and comparision year 2");

                if (Revenue_CompaYear1.Equals(Revenue_CompaYear2))
                    Logger.WriteDebugMessage("Total Revenue value under current year section matched with Comparision year 1 and comparision year 2");
                else
                    scenario1 = false;


                //Compare report Current year value for Comparision year 1 and comparision year 3.
                if (RoomSold_CompaYear1.Equals(RoomSold_CompaYear3))
                    Logger.WriteDebugMessage("Total Room Sold value under current year section matched with Comparision year 1 and comparision year 3");
                else
                    Assert.Fail("Total Room Sold value under current year section not matched with Comparision year 1 and comparision year 3");

                if (Mix_CompaYear1.Equals(Mix_CompaYear3))
                    Logger.WriteDebugMessage("Total Mix% value under current year section matched with Comparision year 1 and comparision year 3");
                else
                    Assert.Fail("Total Mix% value under current year section not matched with Comparision year 1 and comparision year 3");

                if (ADR_CompaYear1.Equals(ADR_CompaYear3))
                    Logger.WriteDebugMessage("Total ADR value under current year section matched with Comparision year 1 and comparision year 3");
                else
                    Assert.Fail("Total ADR value under current year section not matched with Comparision year 1 and comparision year 3");

                if (Revenue_CompaYear1.Equals(Revenue_CompaYear3))
                    Logger.WriteDebugMessage("Total Revenue value under current year section matched with Comparision year 1 and comparision year 3");
                else
                    scenario2 = false;

                //Delete downloaded file
                TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);

                if (scenario1 == false) Assert.Fail("Report for Comparison year 1 is fail");
                else Logger.WriteInfoMessage("Scenario 1 : Report for Comparison year 1 is Pass");

                if (scenario2 == false) Assert.Fail("Report for Comparison year 2 is fail");
                else Logger.WriteInfoMessage("Scenario 2 : Report for Comparison year 2 is Pass");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_endDate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year room sold for comparison year 1", RoomSold_CompaYear1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Mix% for comparison year 1", Mix_CompaYear1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year ADR for comparison year 1", ADR_CompaYear1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Revenue for comparison year 1", Revenue_CompaYear1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year room sold for comparison year 2", RoomSold_CompaYear2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Mix% for comparison year 2", Mix_CompaYear2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year ADR for comparison year 2", ADR_CompaYear2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Revenue for comparison year 2", Revenue_CompaYear2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year room sold for comparison year 3", RoomSold_CompaYear3);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Mix% for comparison year 3", Mix_CompaYear3);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year ADR for comparison year 3", ADR_CompaYear3);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Revenue for comparison year 3", Revenue_CompaYear3, true);
            }
        }

        //Validate Room Type analysis when comparison year is 1 at portfolio level and a filter
        public static void TC_279700()
        {
            if (TestCaseId == Utility.Constants.TC_279700)
            {
                string password, username, environment, currency, Business_Unit, client,
                    startDate, enddate, portfolio_value, parameter1, parameter1_value, startDate_PreviousYear, enddate_PreviousYear,
                    FilePath, FullPath, Filename, Worksheetname = "Room Type Analysis";

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                startDate_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "startDate_PreviousYear");
                enddate_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "enddate_PreviousYear");
                portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");

                Logger.WriteInfoMessage("Test Case : Validate Room Type analysis when comparison year is 1 at portfolio level and a filter");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Generate the report  with Comparison Year as 1 at Portfolio   and  a filter other than the  DOW
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Room Type menu drop down displayed");
                Navigation.Click_Room_Type_Analysis_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Room Type Analysis Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Analysis_Report());

                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                ReportParameter.Portfolio_report_startdate_enddate(portfolio_value, startDate, enddate);
                ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM();
                Logger.WriteDebugMessage("Comparison Year DDM clicked");
                ReportParameter.Select_RoomTypeAnalysis_ComparisonYear1();
                Logger.WriteDebugMessage("Comparison year selected as 1");
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

                //Verify Data in export document and in front end 
                ReportParameter.Report_Excel_Format();

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                string Roomsold_ComparisonYear = tt.GetCellData(Worksheetname, 8, 82);
                string Mix_ComparisonYear = tt.GetCellData(Worksheetname, 9, 82);
                string ADR_ComparisonYear = tt.GetCellData(Worksheetname, 10, 82);
                string Revenue_ComparisonYear = tt.GetCellData(Worksheetname, 11, 82);


                // Generate the same report with Start date and End date as - 1year  and apply same filter  as above 
                // For Example : if report at step 4 is generated for 04 / 01 / 2020 to 04 / 30 / 2020
                // ​Generate the report for date 04 / 01 / 2019 to 04 / 30 / 2019
                Helper.ReloadPage();

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Room Type menu drop down displayed");
                Navigation.Click_Room_Type_Analysis_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Room Type Analysis Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Analysis_Report());

                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                ReportParameter.Portfolio_report_startdate_enddate(portfolio_value, startDate_PreviousYear, enddate_PreviousYear);
                ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM();
                Logger.WriteDebugMessage("Comparison Year DDM clicked");
                ReportParameter.Select_RoomTypeAnalysis_ComparisonYear1();
                Logger.WriteDebugMessage("Comparison year selected as 1");
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; Central Africa; Sao Tome and Principe; Cameroon; ");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                //Verify Data in export document and in front end 
                ReportParameter.Report_Excel_Format();

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                TestData.ExcelData.ExcelDataReader vv = new TestData.ExcelData.ExcelDataReader(FullPath);
                string Roomsold_CurrentYear = vv.GetCellData(Worksheetname, 4, 115);
                string Mix_CurrentYear = vv.GetCellData(Worksheetname, 5, 115);
                string ADR_CurrentYear = vv.GetCellData(Worksheetname, 6, 115);
                string Revenue_CurrentYear = vv.GetCellData(Worksheetname, 7, 115);

                //Match Comparison year data  of report generated  in 1 report with current year data in 2 generated report

                if (Roomsold_ComparisonYear.Equals(Roomsold_CurrentYear))
                    Logger.WriteDebugMessage("Total Roomsold under current year section matched with Comparision year 1(2020) and comparision year 2(2019)");
                else
                    Assert.Fail("Total Roomsold value under current year section not matched with Comparision year 1(2020) and comparision year 2(2019)");

                if (Mix_ComparisonYear.Equals(Mix_CurrentYear))
                    Logger.WriteDebugMessage("Total Mix% value under current year section matched with Comparision year 1(2020) and comparision year 2(2019)");
                else
                    Assert.Fail("Total Mix% value under current year section not matched with Comparision year 1(2020) and comparision year 2(2019)");

                if (ADR_ComparisonYear.Equals(ADR_CurrentYear))
                    Logger.WriteDebugMessage("Total ADR value under current year section matched with Comparision year 1(2020) and comparision year 2(2019)");
                else
                    Assert.Fail("Total ADR value under current year section not matched with Comparision year 1(2020) and comparision year 2(2019)");

                if (Revenue_ComparisonYear.Equals(Revenue_CurrentYear))
                    Logger.WriteDebugMessage("Total Revenue value under current year section matched with Comparision year 1(2020) and comparision year 2(2019)");
                else
                    Assert.Fail("Total Revenue value under current year section not matched with Comparision year 1(2020) and comparision year 2(2019)");

                //Delete downloaded file
                TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Date", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_End Date", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Date of previous year", startDate_PreviousYear);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_End Date of previous year", enddate_PreviousYear);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Porfoilo value", portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year room sold for current year", Roomsold_ComparisonYear);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year MIX% for current year", Mix_ComparisonYear);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year ADR for current year", ADR_ComparisonYear);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year Revenue for current year", Revenue_ComparisonYear);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Room sold for previous year", Roomsold_CurrentYear);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Mix% for previous year", Mix_CurrentYear);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year ADR for previous year", ADR_CurrentYear);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year revenue for previous year", Revenue_CurrentYear, true);
            }
        }

        //Validate Room Type analysis when comparison year is 1 at hotel Level and DOW filter
        public static void TC_279699()
        {
            if (TestCaseId == Utility.Constants.TC_279699)
            {
                {
                    string password, username, environment, currency, Business_Unit, client,
                        startDate, enddate, hotel, parameter1, parameter1_value, startDate_PreviousYear, enddate_PreviousYear,
                        FilePath, FullPath, Filename, Worksheetname = "Room Type Analysis";

                    //Retrieve data from Database or testdata file
                    username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                    password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                    client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                    environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                    currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                    Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                    startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                    enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                    startDate_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "startDate_PreviousYear");
                    enddate_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "enddate_PreviousYear");
                    hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                    parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                    parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");

                    Logger.WriteInfoMessage("Test Case : Validate Room Type analysis when comparison year is 1 at hotel Level and DOW filter");

                    //Enter Email address and password
                    Login.Frontend_SignIn(username, password);

                    //Select Client 
                    Navigation.Select_Client(client);

                    //Generate the report  with Comparison Year as 1 at hotel   and  a filter other than the  DOW
                    Navigation.Click_Hamburger_Icon();
                    Navigation.Click_Menu_Room_Type();
                    Logger.WriteDebugMessage("Room Type menu drop down displayed");
                    Navigation.Click_Room_Type_Analysis_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Room Type Analysis Report Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Analysis_Report());

                    ReportParameter.Select_Hotel_DDL();
                    Logger.WriteDebugMessage("List for hotel displayed");
                    ReportParameter.Select_Hotel_value();
                    Logger.WriteDebugMessage(hotel + "selected as hotel");
                    ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                    ReportParameter.Enter_StartDate(startDate);
                    Logger.WriteDebugMessage("Enter start date as = " + startDate);
                    ReportParameter.Enter_EndDate(enddate);
                    Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                    ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM();
                    Logger.WriteDebugMessage("Comparison Year DDM clicked");
                    ReportParameter.Select_RoomTypeAnalysis_ComparisonYear1();
                    Logger.WriteDebugMessage("Comparison year selected as 1");
                    Helper.ScrollToText("Booking Date:");
                    ReportParameter.Select_SourceMarket_DDL();
                    Logger.WriteDebugMessage("Source Market drop down displayed");
                    ReportParameter.Select_SourceMarket_value();
                    Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
                    ReportParameter.Click_View_Analysis();
                    Helper.AddDelay(50000);
                    Logger.WriteDebugMessage("Report generated");
                    Helper.ScrollToText("Filter(s)");
                    Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa;");
                    Logger.WriteDebugMessage("Applied filter displayed at footer");

                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Roomsold_ComparisonYear = tt.GetCellData(Worksheetname, 8, 36);
                    string Mix_ComparisonYear = tt.GetCellData(Worksheetname, 9, 36);
                    string ADR_ComparisonYear = tt.GetCellData(Worksheetname, 10, 36);
                    string Revenue_ComparisonYear = tt.GetCellData(Worksheetname, 11, 36);


                    // Generate the same report with Start date and End date as - 1year  and apply same filter  as above 
                    // For Example : if report at step 4 is generated for 04 / 01 / 2020 to 04 / 30 / 2020
                    // ​Generate the report for date 04 / 01 / 2019 to 04 / 30 / 2019
                    Helper.ReloadPage();

                    Navigation.Click_Hamburger_Icon();
                    Navigation.Click_Menu_Room_Type();
                    Logger.WriteDebugMessage("Room Type menu drop down displayed");
                    Navigation.Click_Room_Type_Analysis_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Room Type Analysis Report Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Analysis_Report());

                    ReportParameter.Select_Hotel_DDL();
                    Logger.WriteDebugMessage("List for hotel displayed");
                    ReportParameter.Select_Hotel_value();
                    Logger.WriteDebugMessage(hotel + "selected as hotel");
                    ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                    ReportParameter.Enter_StartDate(startDate_PreviousYear);
                    ReportParameter.Enter_EndDate(enddate_PreviousYear);
                    Logger.WriteDebugMessage("Enter start date as = " + startDate_PreviousYear);
                    Logger.WriteDebugMessage("Enter enddate as = " + enddate_PreviousYear);
                    ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM();
                    Logger.WriteDebugMessage("Comparison Year DDM clicked");
                    ReportParameter.Select_RoomTypeAnalysis_ComparisonYear1();
                    Logger.WriteDebugMessage("Comparison year selected as 1");
                    Helper.ScrollToText("Booking Date:");
                    ReportParameter.Select_SourceMarket_DDL();
                    Logger.WriteDebugMessage("Source Market drop down displayed");
                    ReportParameter.Select_SourceMarket_value();
                    Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
                    ReportParameter.Click_View_Analysis();
                    Helper.AddDelay(50000);
                    Logger.WriteDebugMessage("Report generated");
                    Helper.ScrollToText("Filter(s)");
                    Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa;");
                    Logger.WriteDebugMessage("Applied filter displayed at footer");

                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader vv = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Roomsold_CurrentYear = vv.GetCellData(Worksheetname, 4, 47);
                    string Mix_CurrentYear = vv.GetCellData(Worksheetname, 5, 47);
                    string ADR_CurrentYear = vv.GetCellData(Worksheetname, 6, 47);
                    string Revenue_CurrentYear = vv.GetCellData(Worksheetname, 7, 47);

                    //Match Comparison year data  of report generated  in 1 report with current year data in 2 generated report

                    if (Roomsold_ComparisonYear.Equals(Roomsold_CurrentYear))
                        Logger.WriteDebugMessage("Total Roomsold value under current year section matched with Comparision year 1 and comparision year 2");
                    else
                        Assert.Fail("Total Roomsold value under current year section not matched with Comparision year 1 and comparision year 2");

                    if (Mix_ComparisonYear.Equals(Mix_CurrentYear))
                        Logger.WriteDebugMessage("Total Mix% value under current year section matched with Comparision year 1 and comparision year 2");
                    else
                        Assert.Fail("Total Mix% value under current year section not matched with Comparision year 1 and comparision year 2");

                    if (ADR_ComparisonYear.Equals(ADR_CurrentYear))
                        Logger.WriteDebugMessage("Total ADR value under current year section matched with Comparision year 1 and comparision year 2");
                    else
                        Assert.Fail("Total ADR value under current year section not matched with Comparision year 1 and comparision year 2");

                    if (Revenue_ComparisonYear.Equals(Revenue_CurrentYear))
                        Logger.WriteDebugMessage("Total Revenue value under current year section matched with Comparision year 1 and comparision year 2");
                    else
                        Assert.Fail("Total Revenue value under current year section not matched with Comparision year 1 and comparision year 2");

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);

                    //Log test data into log file as well as extent report
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", currency);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Date", startDate);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_End Date", enddate);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Date of previous year", startDate_PreviousYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_End Date of previous year", enddate_PreviousYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter", parameter1);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter value", parameter1_value);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year room sold for current year", Roomsold_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year MIX% for current year", Mix_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year ADR for current year", ADR_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year Revenue for current year", Revenue_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Room sold for previous year", Roomsold_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Mix% for previous year", Mix_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year ADR for previous year", ADR_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year revenue for previous year", Revenue_CurrentYear, true);
                }
            }
        }

        //Validate Room Type analysis when comparison year is 3 at hotel Level
        public static void TC_279698()
        {
            if (TestCaseId == Utility.Constants.TC_279698)
            {
                {
                    string password, username, environment, currency, Business_Unit, client, Mix_CurrentYear, Mix_ComparisonYear,
                        startDate, enddate, hotel, parameter1, parameter1_value, startDate_PreviousYear, enddate_PreviousYear,
                        FilePath, FullPath, Filename, Worksheetname = "Room Type Analysis";

                    //Retrieve data from Database or testdata file
                    username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                    password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                    client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                    environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                    currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                    Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                    startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                    enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                    startDate_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "startDate_PreviousYear");
                    enddate_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "enddate_PreviousYear");
                    hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                    parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                    parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                    Mix_ComparisonYear = TestData.ExcelData.TestDataReader.ReadData(1, "Mix_ComparisonYear");
                    Mix_CurrentYear = TestData.ExcelData.TestDataReader.ReadData(1, "Mix_CurrentYear");

                    Logger.WriteInfoMessage("Test Case : Validate Room Type analysis when comparison year is 3 at hotel Level");

                    //Enter Email address and password
                    Login.Frontend_SignIn(username, password);

                    //Select Client 
                    Navigation.Select_Client(client);

                    //Generate the report  with Comparison Year as 1 at Portfolio   and  a filter other than the  DOW
                    Navigation.Click_Hamburger_Icon();
                    Navigation.Click_Menu_Room_Type();
                    Logger.WriteDebugMessage("Room Type menu drop down displayed");
                    Navigation.Click_Room_Type_Analysis_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Room Type Analysis Report Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Analysis_Report());

                    ReportParameter.Select_Hotel_DDL();
                    Logger.WriteDebugMessage("List for hotel displayed");
                    ReportParameter.Select_Hotel_value();
                    Logger.WriteDebugMessage(hotel + "selected as hotel");
                    ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                    ReportParameter.Enter_StartDate(startDate);
                    Logger.WriteDebugMessage("Enter start date as = " + startDate);
                    ReportParameter.Enter_EndDate(enddate);
                    Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                    ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM();
                    Logger.WriteDebugMessage("Comparison Year DDM clicked");
                    ReportParameter.Select_RoomTypeAnalysis_ComparisonYear3();
                    Logger.WriteDebugMessage("Comparison year selected as 3");
                    Helper.ScrollToText("Booking Date:");
                    ReportParameter.Select_SourceMarket_DDL();
                    Logger.WriteDebugMessage("Source Market drop down displayed");
                    ReportParameter.Select_SourceMarket_value();
                    Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
                    ReportParameter.Click_View_Analysis();
                    Helper.AddDelay(50000);
                    Logger.WriteDebugMessage("Report generated");
                    Helper.ScrollToText("Filter(s)");
                    Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa;");
                    Logger.WriteDebugMessage("Applied filter displayed at footer");

                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Roomsold_ComparisonYear = tt.GetCellData(Worksheetname, 8, 51);

                    TestData.ExcelData.ExcelDataReader hv = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ComparisonYear = hv.GetCellData(Worksheetname, 9, 51);
                    if (ComparisonYear.Contains(Mix_ComparisonYear))
                        Logger.WriteDebugMessage(Mix_ComparisonYear + " matched with total MIx% under ComparisonYear section ");
                    else
                        Assert.Fail("total MIx% under ComparisonYear section not match");

                    string ADR_ComparisonYear = tt.GetCellData(Worksheetname, 10,51);
                    string Revenue_ComparisonYear = tt.GetCellData(Worksheetname, 11,51);


                    // Generate the same report with Start date and End date as - 1year  and apply same filter  as above 
                    // For Example : if report at step 4 is generated for 04 / 01 / 2020 to 04 / 30 / 2020
                    // ​Generate the report for date 04 / 01 / 2017 to 04 / 30 / 2017
                    Helper.ReloadPage();

                    Navigation.Click_Hamburger_Icon();
                    Navigation.Click_Menu_Room_Type();
                    Logger.WriteDebugMessage("Room Type menu drop down displayed");
                    Navigation.Click_Room_Type_Analysis_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Room Type Analysis Report Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Analysis_Report());

                    ReportParameter.Select_Hotel_DDL();
                    Logger.WriteDebugMessage("List for hotel displayed");
                    ReportParameter.Select_Hotel_value();
                    Logger.WriteDebugMessage(hotel + "selected as hotel");
                    ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                    ReportParameter.Enter_StartDate(startDate_PreviousYear);
                    ReportParameter.Enter_EndDate(enddate_PreviousYear);
                    Logger.WriteDebugMessage("Enter start date as = " + startDate_PreviousYear);
                    Logger.WriteDebugMessage("Enter enddate as = " + enddate_PreviousYear);
                    ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM();
                    Logger.WriteDebugMessage("Comparison Year DDM clicked");
                    ReportParameter.Select_RoomTypeAnalysis_ComparisonYear1();
                    Logger.WriteDebugMessage("Comparison year selected as 1");
                    Helper.ScrollToText("Booking Date:");
                    ReportParameter.Select_SourceMarket_DDL();
                    Logger.WriteDebugMessage("Source Market drop down displayed");
                    ReportParameter.Select_SourceMarket_value();
                    Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
                    ReportParameter.Click_View_Analysis();
                    Helper.AddDelay(50000);
                    Logger.WriteDebugMessage("Report generated");
                    Helper.ScrollToText("Filter(s)");
                    Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa;");
                    Logger.WriteDebugMessage("Applied filter displayed at footer");

                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader vv = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Roomsold_CurrentYear = vv.GetCellData(Worksheetname, 4, 51);

                    TestData.ExcelData.ExcelDataReader kk = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Mix = kk.GetCellData(Worksheetname, 5, 51);
                    if (Mix.Contains(Mix_CurrentYear))
                        Logger.WriteDebugMessage(Mix_CurrentYear + " matched with total MIx% under current year section ");
                    else
                        Assert.Fail("total MIx% under current year section not match");

                    string ADR_CurrentYear = vv.GetCellData(Worksheetname, 6, 51);
                    string Revenue_CurrentYear = vv.GetCellData(Worksheetname, 7,51);

                    //Match Comparison year data  of report generated  in 1 report with current year data in 2 generated report

                    if (Roomsold_ComparisonYear.Equals(Roomsold_CurrentYear))
                        Logger.WriteDebugMessage("Total ADR value under current year section matched ");
                    else
                        Assert.Fail("Total ADR value under current year section not matched");

                    if (Mix_ComparisonYear.Contains(Mix_CurrentYear))
                        Logger.WriteDebugMessage("Total ADR value under current year section matched ");
                    else
                        Assert.Fail("Total ADR value under current year section not matched with ");

                    if (ADR_ComparisonYear.Equals(ADR_CurrentYear))
                        Logger.WriteDebugMessage("Total ADR value under current year section matched");
                    else
                        Assert.Fail("Total ADR value under current year section not matched with");

                    if (Revenue_ComparisonYear.Equals(Revenue_CurrentYear))
                        Logger.WriteDebugMessage("Total ADR value under current year section matched");
                    else
                        Assert.Fail("Total ADR value under current year section not matched");

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);

                    //Log test data into log file as well as extent report
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", currency);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Date", startDate);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_End Date", enddate);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Date of previous year", startDate_PreviousYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_End Date of previous year", enddate_PreviousYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter", parameter1);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter value", parameter1_value);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year room sold for current year", Roomsold_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year MIX% for current year", Mix_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year ADR for current year", ADR_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year Revenue for current year", Revenue_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Room sold for previous year", Roomsold_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Mix% for previous year", Mix_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year ADR for previous year", ADR_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year revenue for previous year", Revenue_CurrentYear, true);
                }
            }
        }

        //Validate Room Type analysis when comparison year is 2 at hotel Level
        public static void TC_279697()
        {
            if (TestCaseId == Utility.Constants.TC_279697)
            {
                {
                    string password, username, environment, currency, Business_Unit, client, Mix_ComparisonYear, Mix_CurrentYear,
                        startDate, enddate, hotel,startDate_PreviousYear, enddate_PreviousYear,
                        FilePath, FullPath, Filename, Worksheetname = "Room Type Analysis";

                    //Retrieve data from Database or testdata file
                    username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                    password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                    client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                    environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                    currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                    Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                    startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                    enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                    startDate_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "startDate_PreviousYear");
                    enddate_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "enddate_PreviousYear");
                    hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                    Mix_ComparisonYear = TestData.ExcelData.TestDataReader.ReadData(1, "Mix_ComparisonYear");
                    Mix_CurrentYear = TestData.ExcelData.TestDataReader.ReadData(1, "Mix_CurrentYear");

                    Logger.WriteInfoMessage("Test Case : Validate Room Type analysis when comparison year is 2 at hotel Level");

                    //Enter Email address and password
                    Login.Frontend_SignIn(username, password);

                    //Select Client 
                    Navigation.Select_Client(client);

                    //Generate the report  with Comparison Year as 1 at hotel level
                    Navigation.Click_Hamburger_Icon();
                    Navigation.Click_Menu_Room_Type();
                    Logger.WriteDebugMessage("Room Type menu drop down displayed");
                    Navigation.Click_Room_Type_Analysis_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Room Type Analysis Report Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Analysis_Report());

                    ReportParameter.Select_Hotel_DDL();
                    Logger.WriteDebugMessage("List for hotel displayed");
                    ReportParameter.Select_Hotel_value();
                    Logger.WriteDebugMessage(hotel + "selected as hotel");
                    ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                    ReportParameter.Enter_StartDate(startDate);
                    Logger.WriteDebugMessage("Enter start date as = " + startDate);
                    ReportParameter.Enter_EndDate(enddate);
                    Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                    ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM();
                    Logger.WriteDebugMessage("Comparison Year DDM clicked");
                    ReportParameter.Select_RoomTypeAnalysis_ComparisonYear2();
                    Logger.WriteDebugMessage("Comparison year selected as 2");
                    ReportParameter.Click_View_Analysis();
                    Helper.AddDelay(50000);
                    Logger.WriteDebugMessage("Report generated");
                    
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Roomsold_ComparisonYear = tt.GetCellData(Worksheetname, 8, 55);

                    TestData.ExcelData.ExcelDataReader hv = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ComparisonYear = hv.GetCellData(Worksheetname, 9, 55);
                    if (ComparisonYear.Contains(Mix_ComparisonYear))
                        Logger.WriteDebugMessage(Mix_ComparisonYear + " matched with total MIx% under ComparisonYear section ");
                    else
                        Assert.Fail("total MIx% under ComparisonYear section not match");

                    string ADR_ComparisonYear = tt.GetCellData(Worksheetname, 10, 55);
                    string Revenue_ComparisonYear = tt.GetCellData(Worksheetname, 11, 55);


                    // Generate the same report with Start date and End date as - 1year  and apply same filter  as above 
                    // For Example : if report at step 4 is generated for 04 / 01 / 2020 to 04 / 30 / 2020
                    // ​Generate the report for date 04 / 01 / 2018 to 04 / 30 / 2018
                    Helper.ReloadPage();

                    Navigation.Click_Hamburger_Icon();
                    Navigation.Click_Menu_Room_Type();
                    Logger.WriteDebugMessage("Room Type menu drop down displayed");
                    Navigation.Click_Room_Type_Analysis_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Room Type Analysis Report Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Analysis_Report());

                    ReportParameter.Select_Hotel_DDL();
                    Logger.WriteDebugMessage("List for hotel displayed");
                    ReportParameter.Select_Hotel_value();
                    Logger.WriteDebugMessage(hotel + "selected as hotel");
                    ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                    ReportParameter.Enter_StartDate(startDate_PreviousYear);
                    ReportParameter.Enter_EndDate(enddate_PreviousYear);
                    Logger.WriteDebugMessage("Enter start date as = " + startDate_PreviousYear);
                    Logger.WriteDebugMessage("Enter enddate as = " + enddate_PreviousYear);
                    ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM();
                    Logger.WriteDebugMessage("Comparison Year DDM clicked");
                    ReportParameter.Select_RoomTypeAnalysis_ComparisonYear1();
                    Logger.WriteDebugMessage("Comparison year selected as 1");
                    ReportParameter.Click_View_Analysis();
                    Helper.AddDelay(50000);
                    Logger.WriteDebugMessage("Report generated");
                   
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader vv = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Roomsold_CurrentYear = vv.GetCellData(Worksheetname, 4, 55);

                    TestData.ExcelData.ExcelDataReader kk = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Mix = kk.GetCellData(Worksheetname, 5, 55);
                    if (Mix.Contains(Mix_CurrentYear))
                        Logger.WriteDebugMessage(Mix_CurrentYear + " matched with total MIx% under ComparisonYear section ");
                    else
                        Assert.Fail("total MIx% under ComparisonYear section not match");

                    string ADR_CurrentYear = vv.GetCellData(Worksheetname, 6, 55);
                    string Revenue_CurrentYear = vv.GetCellData(Worksheetname, 7, 55);

                    //Match Comparison year data  of report generated  in 1 report with current year data in 2 generated report

                    if (Roomsold_ComparisonYear.Equals(Roomsold_CurrentYear))
                        Logger.WriteDebugMessage("Total ADR value under current year section matched ");
                    else
                        Assert.Fail("Total ADR value under current year section not matched");

                    if (Mix_ComparisonYear.Equals(Mix_CurrentYear))
                        Logger.WriteDebugMessage("Total ADR value under current year section matched ");
                    else
                        Assert.Fail("Total ADR value under current year section not matched with ");

                    if (ADR_ComparisonYear.Equals(ADR_CurrentYear))
                        Logger.WriteDebugMessage("Total ADR value under current year section matched");
                    else
                        Assert.Fail("Total ADR value under current year section not matched with");

                    if (Revenue_ComparisonYear.Equals(Revenue_CurrentYear))
                        Logger.WriteDebugMessage("Total ADR value under current year section matched");
                    else
                        Assert.Fail("Total ADR value under current year section not matched");

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);

                    //Log test data into log file as well as extent report
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", currency);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Date", startDate);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_End Date", enddate);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Date of previous year", startDate_PreviousYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_End Date of previous year", enddate_PreviousYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year room sold for current year", Roomsold_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year MIX% for current year", Mix_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year ADR for current year", ADR_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year Revenue for current year", Revenue_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Room sold for previous year", Roomsold_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Mix% for previous year", Mix_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year ADR for previous year", ADR_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year revenue for previous year", Revenue_CurrentYear, true);
                }
            }
        }

        // Validate Room Type analysis when comparison year is 1 at hotel Level
        public static void TC_279696()
        {
            if (TestCaseId == Utility.Constants.TC_279696)
            {
                {
                    string password, username, environment, currency, Business_Unit, client,
                        startDate, enddate, hotel, startDate_PreviousYear, enddate_PreviousYear,
                        FilePath, FullPath, Filename, Worksheetname = "Room Type Analysis";

                    //Retrieve data from Database or testdata file
                    username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                    password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                    client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                    environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                    currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                    Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                    startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                    enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                    startDate_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "startDate_PreviousYear");
                    enddate_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "enddate_PreviousYear");
                    hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");

                    Logger.WriteInfoMessage("Test Case :  Validate Room Type analysis when comparison year is 1 at hotel Level");

                    //Enter Email address and password
                    Login.Frontend_SignIn(username, password);

                    //Select Client 
                    Navigation.Select_Client(client);

                    //Generate the report  with Comparison Year as 1 at hotel level
                    Navigation.Click_Hamburger_Icon();
                    Navigation.Click_Menu_Room_Type();
                    Logger.WriteDebugMessage("Room Type menu drop down displayed");
                    Navigation.Click_Room_Type_Analysis_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Room Type Analysis Report Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Analysis_Report());

                    ReportParameter.Select_Hotel_DDL();
                    Logger.WriteDebugMessage("List for hotel displayed");
                    ReportParameter.Select_Hotel_value();
                    Logger.WriteDebugMessage(hotel + "selected as hotel");
                    ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                    ReportParameter.Enter_StartDate(startDate);
                    Logger.WriteDebugMessage("Enter start date as = " + startDate);
                    ReportParameter.Enter_EndDate(enddate);
                    Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                    ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM();
                    Logger.WriteDebugMessage("Comparison Year DDM clicked");
                    ReportParameter.Select_RoomTypeAnalysis_ComparisonYear1();
                    Logger.WriteDebugMessage("Comparison year selected as 1");
                    ReportParameter.Click_View_Analysis();
                    Helper.AddDelay(50000);
                    Logger.WriteDebugMessage("Report generated");
                    

                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Roomsold_ComparisonYear = tt.GetCellData(Worksheetname, 8, 39);
                    string Mix_ComparisonYear = tt.GetCellData(Worksheetname, 9, 39);
                    string ADR_ComparisonYear = tt.GetCellData(Worksheetname, 10, 39);
                    string Revenue_ComparisonYear = tt.GetCellData(Worksheetname, 11, 39);


                    // Generate the same report with Start date and End date as - 1year  and apply same   as above 
                    // For Example : if report at step 4 is generated for 04 / 01 / 2020 to 04 / 30 / 2020
                    // ​Generate the report for date 04 / 01 / 2019 to 04 / 30 / 2019
                    Helper.ReloadPage();

                    Navigation.Click_Hamburger_Icon();
                    Navigation.Click_Menu_Room_Type();
                    Logger.WriteDebugMessage("Room Type menu drop down displayed");
                    Navigation.Click_Room_Type_Analysis_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Room Type Analysis Report Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Analysis_Report());

                    ReportParameter.Select_Hotel_DDL();
                    Logger.WriteDebugMessage("List for hotel displayed");
                    ReportParameter.Select_Hotel_value();
                    Logger.WriteDebugMessage(hotel + "selected as hotel");
                    ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                    ReportParameter.Enter_StartDate(startDate_PreviousYear);
                    ReportParameter.Enter_EndDate(enddate_PreviousYear);
                    Logger.WriteDebugMessage("Enter start date as = " + startDate_PreviousYear);
                    Logger.WriteDebugMessage("Enter enddate as = " + enddate_PreviousYear);
                    ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM();
                    Logger.WriteDebugMessage("Comparison Year DDM clicked");
                    ReportParameter.Select_RoomTypeAnalysis_ComparisonYear1();
                    Logger.WriteDebugMessage("Comparison year selected as 1");
                    ReportParameter.Click_View_Analysis();
                    Helper.AddDelay(50000);
                    Logger.WriteDebugMessage("Report generated");
                    
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader vv = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Roomsold_CurrentYear = vv.GetCellData(Worksheetname, 4,55);
                    string Mix_CurrentYear = vv.GetCellData(Worksheetname, 5, 55);
                    string ADR_CurrentYear = vv.GetCellData(Worksheetname, 6,55);
                    string Revenue_CurrentYear = vv.GetCellData(Worksheetname, 7,55);

                    //Match Comparison year data  of report generated  in 1 report with current year data in 2 generated report

                    if (Roomsold_ComparisonYear.Equals(Roomsold_CurrentYear))
                        Logger.WriteDebugMessage("Total ADR value under current year section matched ");
                    else
                        Assert.Fail("Total ADR value under current year section not matched");

                    if (Mix_ComparisonYear.Equals(Mix_CurrentYear))
                        Logger.WriteDebugMessage("Total ADR value under current year section matched ");
                    else
                        Assert.Fail("Total ADR value under current year section not matched with ");

                    if (ADR_ComparisonYear.Equals(ADR_CurrentYear))
                        Logger.WriteDebugMessage("Total ADR value under current year section matched");
                    else
                        Assert.Fail("Total ADR value under current year section not matched with");

                    if (Revenue_ComparisonYear.Equals(Revenue_CurrentYear))
                        Logger.WriteDebugMessage("Total ADR value under current year section matched");
                    else
                        Assert.Fail("Total ADR value under current year section not matched");

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);

                    //Log test data into log file as well as extent report
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", currency);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Date", startDate);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_End Date", enddate);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Date of previous year", startDate_PreviousYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_End Date of previous year", enddate_PreviousYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year room sold for current year", Roomsold_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year MIX% for current year", Mix_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year ADR for current year", ADR_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year Revenue for current year", Revenue_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Room sold for previous year", Roomsold_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Mix% for previous year", Mix_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year ADR for previous year", ADR_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year revenue for previous year", Revenue_CurrentYear, true);
                }
            }
        }
    }
}