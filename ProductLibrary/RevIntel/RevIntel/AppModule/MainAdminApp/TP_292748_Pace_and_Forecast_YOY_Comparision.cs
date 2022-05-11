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
        //Validate Pace and Forecast Report Current year data
        public static void TC_279694()

        {
            if (TestCaseId == Utility.Constants.TC_279694)
            {
                //Pre-Requisite
                string password, username, environment, currency, Business_Unit, client, Hotel, StartMonth, As_Of_Date, As_Of_Date_PreviousYear, StartMonth_PreviousYear,
                    FilePath, FullPath, Filename, Worksheetname = "Totals";

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel");
                currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                StartMonth = TestData.ExcelData.TestDataReader.ReadData(1, "StartMonth");
                As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                StartMonth_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "StartMonth_PreviousYear");
                As_Of_Date_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date_PreviousYear");

                Logger.WriteInfoMessage("Test Case : Validate Pace and Forecast Report Current year data");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);


                //Select Client 
                //Navigation.Select_Client(client);

                Logger.WriteDebugMessage("user landed on the Automation RevIntel client selection page");
                Helper.PageDown();
                Logger.WriteDebugMessage("Client displayed");
                Navigation.Click_ClientName(client);
                Logger.WriteDebugMessage(client + " selected");
                Helper.AddDelay(10000);

                Navigation.Click_Menu_Forecast_and_Budget();
                Logger.WriteDebugMessage("Forecast and Budget menu drop down displayed");
                Navigation.Pace_Forecast_Report();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Pace and Forecast report Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_and_Forecast_Report());

                //Generate the report  with Comparison Year as 1 at Hotel Level 
                ReportParameter.Select_Hotel_DDL();
                ReportParameter.Select_Hotel_value();
                ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                ReportParameter.Enter_Start_Month(StartMonth);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter StartMonth date as = " + StartMonth);
                Logger.WriteDebugMessage("Enter As_Of_Date as = " + As_Of_Date);
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
                string RoomSold_CompaYear1 = tt1.GetCellData(Worksheetname, 8, 1099);
                string Mix_CompaYear1 = tt1.GetCellData(Worksheetname, 9, 1099);
                string ADR_CompaYear1 = tt1.GetCellData(Worksheetname, 10, 1099);
                string Revenue_CompaYear1 = tt1.GetCellData(Worksheetname, 11, 1099);

                //Report with Comparison Year as 2 at Hotel Level
                Helper.ReloadPage();
                Navigation.Click_Menu_Forecast_and_Budget();
                Logger.WriteDebugMessage("Foecast and Budget menu drop down displayed");
                Navigation.Pace_Forecast_Report();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Pace and forecast Report Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_and_Forecast_Report());

                //Generate the report  with Comparison Year(2019) at Hotel Level 
                ReportParameter.Select_Hotel_DDL();
                ReportParameter.Select_Hotel_value();
                ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                ReportParameter.Enter_Start_Month(StartMonth_PreviousYear);
                ReportParameter.Enter_As_Of_Date(As_Of_Date_PreviousYear);
                Logger.WriteDebugMessage("Enter StartMonth date as = " + StartMonth_PreviousYear);
                Logger.WriteDebugMessage("Enter_As_Of_Date as = " + As_Of_Date_PreviousYear);
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

                TestData.ExcelData.ExcelDataReader rr = new TestData.ExcelData.ExcelDataReader(FullPath);
                string RoomSold_CurrentYear = rr.GetCellData(Worksheetname, 4, 1680);
                string Mix_CurrentYear = rr.GetCellData(Worksheetname, 5, 1680);
                string ADR_CurrentYear = rr.GetCellData(Worksheetname, 6, 1680);
                string Revenue_CurrentYear = rr.GetCellData(Worksheetname, 7, 1680);

                //Validation by comparing reports
                //Compare report Current year value for Comparision year 1 and comparision year 2.
                if (RoomSold_CompaYear1.Equals(RoomSold_CurrentYear))
                    Logger.WriteDebugMessage("Total Room Sold value under current year section matched with Comparision year section(2020) and current year section(2019)");
                else
                    Assert.Fail("Total Room Sold value under current year section not matched with Comparision year section(2020) and current year section(2019)");

                if (Mix_CompaYear1.Equals(Mix_CurrentYear))
                    Logger.WriteDebugMessage("Total Mix% value under current year section matched with Comparision year section(2020) and current year section(2019)");
                else
                    Assert.Fail("Total Mix% value under current year section not matched with Comparision year section(2020) and current year section(2019)");

                if (ADR_CompaYear1.Equals(ADR_CurrentYear))
                    Logger.WriteDebugMessage("Total ADR value under current year section matched with Comparision year section(2020) and current year section(2019)");
                else
                    Assert.Fail("Total ADR value under current year section not matched with Comparision year section(2020) and current year section(2019)");

                if (Revenue_CompaYear1.Equals(Revenue_CurrentYear))
                    Logger.WriteDebugMessage("Total Revenue value under current year section matched with Comparision year section(2020) and current year section(2019)");
                else
                    Assert.Fail("Total Revenue value under current year section not matched with Comparision year section(2020) and current year section(2019)");


                //Delete downloaded file
                TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_StartMonth", StartMonth);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year section room sold value for year(2020)", RoomSold_CompaYear1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year section Mix% value for year(2020)", Mix_CompaYear1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year section ADR value for year(2020)", ADR_CompaYear1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year section Revenue value for year(2020)", Revenue_CompaYear1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current Year section room sold value for year(2019)", RoomSold_CurrentYear);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current Year section Mix% value for year(2019)", Mix_CurrentYear);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current Year section ADR value for year(2019)", ADR_CurrentYear);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current Year section Revenue value for year(2019)", Revenue_CurrentYear, true);
            }
        }

        //Validate Pace and Forecast Report when comparison year is 3 at hotel Level
        public static void TC_279691()
        {
            if (TestCaseId == Utility.Constants.TC_279691)
            {
                string password, username, environment, currency, Business_Unit, client, Mix_CurrentYear,
                StartMonth, As_Of_Date, hotel, parameter1, parameter1_value, StartMonth_PreviousYear, As_Of_Date_PreviousYear,
                FilePath, FullPath, Filename, Worksheetname = "Totals";

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                StartMonth = TestData.ExcelData.TestDataReader.ReadData(1, "StartMonth");
                As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                StartMonth_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "StartMonth_PreviousYear");
                As_Of_Date_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date_PreviousYear");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                Mix_CurrentYear = TestData.ExcelData.TestDataReader.ReadData(1, "Mix_CurrentYear");

                Logger.WriteInfoMessage("Test Case : Validate Pace and Forecast Report when comparison year is 3 at hotel Level");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                //Navigation.Select_Client(client);

                Helper.PageDown();
                Logger.WriteDebugMessage("Client displayed");
                Navigation.Click_ClientName(client);
                Logger.WriteDebugMessage(client + " selected");
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Montly pickup Dashboard page");

                //Generate the report  with Comparison Year as 3 at hotel
                Navigation.Click_Menu_Forecast_and_Budget();
                Logger.WriteDebugMessage("Forecat and Budget drop down displayed");
                Navigation.Pace_Forecast_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Pace and Forecast Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_and_Forecast_Report());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                ReportParameter.Enter_Start_Month(StartMonth);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter StartMonth date as = " + StartMonth);
                Logger.WriteDebugMessage("Enter As_Of_Date as = " + As_Of_Date);
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

                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                string Roomsold_ComparisonYear = tt.GetCellData(Worksheetname, 8, 1265);
                string Mix_ComparisonYear = tt.GetCellData(Worksheetname, 9, 1265);
                string ADR_ComparisonYear = tt.GetCellData(Worksheetname, 10, 1265);
                string Revenue_ComparisonYear = tt.GetCellData(Worksheetname, 11, 1265);


                // Generate the same report with Start date and End date as - 3year 
                Helper.ReloadPage();
                Navigation.Click_Menu_Forecast_and_Budget();
                Logger.WriteDebugMessage("Forecast and Budget menu drop down displayed");
                Navigation.Pace_Forecast_Report ();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Pace and Forecast Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_and_Forecast_Report());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                ReportParameter.Enter_Start_Month(StartMonth_PreviousYear);
                ReportParameter.Enter_As_Of_Date(As_Of_Date_PreviousYear);
                Logger.WriteDebugMessage("Enter StartMonth date as = " + StartMonth_PreviousYear);
                Logger.WriteDebugMessage("Enter_As_Of_Date as = " + As_Of_Date_PreviousYear);
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
                string Roomsold_CurrentYear = vv.GetCellData(Worksheetname, 4, 1572);
                string Mix_CurrentYear1 = vv.GetCellData(Worksheetname, 5, 1572);
                string ADR_CurrentYear = vv.GetCellData(Worksheetname, 6, 1572);
                string Revenue_CurrentYear = vv.GetCellData(Worksheetname, 7, 1572);

                //Match Comparison year data  of report generated  in 1 report with current year data in 2 generated report

                if (Roomsold_ComparisonYear.Equals(Roomsold_CurrentYear))
                    Logger.WriteDebugMessage("Total Roomsold value under current year section matched with Comparision year(2020) and comparision year(2017)");
                else
                    Assert.Fail("Total Roomsold value under current year section not matched with Comparision year(2020) and comparision year(2017)");

                if (Mix_ComparisonYear.Contains(Mix_CurrentYear))
                    Logger.WriteDebugMessage("Total Mix% value under current year section matched with Comparision year(2020) and comparision year(2017)");
                else
                    Assert.Fail("Total Mix% value under current year section not matched with Comparision year(2020) and comparision year(2017)");

                if (ADR_ComparisonYear.Equals(ADR_CurrentYear))
                    Logger.WriteDebugMessage("Total ADR value under current year section matched with Comparision year(2020) and comparision year(2017)");
                else
                    Assert.Fail("Total ADR value under current year section not matched with Comparision year(2020) and comparision year(2017)");

                if (Revenue_ComparisonYear.Equals(Revenue_CurrentYear))
                    Logger.WriteDebugMessage("Total Revenue value under current year section matched with Comparision year(2020) and comparision year(2017)");
                else
                    Assert.Fail("Total Revenue value under current year section not matched with Comparision year(2020) and comparision year(2017)");

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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_StartMonth", StartMonth);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_StartMonth_PreviousYear", StartMonth_PreviousYear);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date_PreviousYear", As_Of_Date_PreviousYear);
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

        //Validate Pace and Forecast Report when comparison year is 2 at hotel Level
        public static void TC_279690()
        {
            if (TestCaseId == Utility.Constants.TC_279690)
            {
                {
                    string password, username, environment, currency, Business_Unit, client, Mix_CurrentYear,
                    Start_Month, As_Of_Date, Hotel, parameter1, parameter1_value, StartMonth_PreviousYear, As_Of_Date_PreviousYear,
                    FilePath, FullPath, Filename, Worksheetname = "Totals";

                    //Retrieve data from Database or testdata file
                    username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                    password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                    client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                    environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                    currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                    Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                    Start_Month = TestData.ExcelData.TestDataReader.ReadData(1, "Start_Month");
                    As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                    StartMonth_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "StartMonth_PreviousYear");
                    As_Of_Date_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date_PreviousYear");
                    Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel");
                    parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                    parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                    Mix_CurrentYear = TestData.ExcelData.TestDataReader.ReadData(1, "Mix_CurrentYear");

                    Logger.WriteInfoMessage("Test Case : Validate the Market->Market Report when comparison year is 2 at hotel Level");

                    //Enter Email address and password
                    Login.Frontend_SignIn(username, password);

                    //Select Client 
                    //Navigation.Select_Client(client);

                    Helper.PageDown();
                    Logger.WriteDebugMessage("Client displayed");
                    Navigation.Click_ClientName(client);
                    Logger.WriteDebugMessage(client + " selected");
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User landed on Montly pickup Dashboard page");

                    //Generate the report  with Comparison Year as 2 at hotel Level
                    Navigation.Click_Menu_Forecast_and_Budget();
                    Logger.WriteDebugMessage("Forecast and Budget menu drop down displayed");
                    Navigation.Pace_Forecast_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Pace and forecast Report Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_and_Forecast_Report());

                    ReportParameter.Select_Hotel_DDL();
                    Logger.WriteDebugMessage("List for hotel displayed");
                    ReportParameter.Select_Hotel_value();
                    Logger.WriteDebugMessage(Hotel + "selected as hotel");
                    ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                    ReportParameter.Enter_As_Of_Date(As_Of_Date);
                    Logger.WriteDebugMessage("Enter As of date as = " + As_Of_Date);
                    ReportParameter.Enter_Start_Month(Start_Month);
                    Logger.WriteDebugMessage("Enter start Month as = " + Start_Month);
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
                    string RoomSold_CompaYear1 = tt.GetCellData(Worksheetname, 8, 918);
                    string Mix_CompaYear1 = tt.GetCellData(Worksheetname, 9, 918);
                    string ADR_CompaYear1 = tt.GetCellData(Worksheetname, 10, 918);
                    string Revenue_CompaYear1 = tt.GetCellData(Worksheetname, 11, 918);


                    // Generate the same report with Start date and End date as - 2year  
                    Helper.ReloadPage();
                    Navigation.Click_Menu_Forecast_and_Budget();
                    Logger.WriteDebugMessage("Forecast and Budget menu drop down displayed");
                    Navigation.Pace_Forecast_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Pace and Forecast Report Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_and_Forecast_Report());

                    ReportParameter.Select_Hotel_DDL();
                    Logger.WriteDebugMessage("List for hotel displayed");
                    ReportParameter.Select_Hotel_value();
                    Logger.WriteDebugMessage(Hotel + "selected as hotel");
                    ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                    ReportParameter.Enter_As_Of_Date(As_Of_Date_PreviousYear);
                    ReportParameter.Enter_Start_Month(StartMonth_PreviousYear);
                    Logger.WriteDebugMessage("Enter As of date as = " + As_Of_Date_PreviousYear);
                    Logger.WriteDebugMessage("Enter Start Month as = " + StartMonth_PreviousYear);
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
                    string RoomSold_CurrentYear = vv.GetCellData(Worksheetname, 4, 1603);
                    string Mix_CurrentYear1 = vv.GetCellData(Worksheetname, 5, 1603);
                    string ADR_CurrentYear = vv.GetCellData(Worksheetname, 6, 1603);
                    string Revenue_CurrentYear = vv.GetCellData(Worksheetname, 7, 1603);

                    //Match Comparison year data  of report generated  in 1 report with current year data in 2 generated report

                    if (RoomSold_CompaYear1.Equals(RoomSold_CurrentYear))
                        Logger.WriteDebugMessage("Total Roomsold under current year section matched with Comparision year 1(2020) and comparision year 2(2018)");
                    else
                        Assert.Fail("Total Roomsold value under current year section not matched with Comparision year 1(2020) and comparision year 2(2018)");

                    if (Mix_CompaYear1.Contains(Mix_CurrentYear))
                        Logger.WriteDebugMessage("Total Mix% value under current year section matched with Comparision year 1(2020) and comparision year 2(2018)");
                    else
                        Assert.Fail("Total Mix% value under current year section not matched with Comparision year 1(2020) and comparision year 2(2018)");

                    if (ADR_CompaYear1.Equals(ADR_CurrentYear))
                        Logger.WriteDebugMessage("Total ADR value under current year section matched with Comparision year 1(2020) and comparision year 2(2018)");
                    else
                        Assert.Fail("Total ADR value under current year section not matched with Comparision year 1(2020) and comparision year 2(2018)");

                    if (Revenue_CompaYear1.Equals(Revenue_CurrentYear))
                        Logger.WriteDebugMessage("Total Revenue value under current year section matched with Comparision year 1(2020) and comparision year 2(2018)");
                    else
                        Assert.Fail("Total Revenue value under current year section not matched with Comparision year 1(2020) and comparision year 2(2018)");

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);

                    //Log test data into log file as well as extent report
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", currency);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel", Hotel);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date", As_Of_Date);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start_Month", Start_Month);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start_Month_PreviousYear", StartMonth_PreviousYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date_PreviousYear", As_Of_Date_PreviousYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year section room sold value for year(2020)", RoomSold_CompaYear1);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year section Mix% value for year(2020)", Mix_CompaYear1);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year section ADR value for year(2020)", ADR_CompaYear1);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year section Revenue value for year(2020)", Revenue_CompaYear1);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current Year section room sold value for year(2018)", RoomSold_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current Year section Mix% value for year(2018)", Mix_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current Year section ADR value for year(2018)", ADR_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current Year section Revenue value for year(2018)", Revenue_CurrentYear, true);
                }
            }
        }

        //Validate Pace and Forecast Report when comparison year is 1 at hotel Level
        public static void TC_279689()
        {
            if (TestCaseId == Utility.Constants.TC_279689)
            {
                {
                    string password, username, environment, currency, Business_Unit, client, 
                        As_Of_Date, Start_Month, hotel, As_Of_Date_PreviousYear, Start_Month_PreviousYear,
                        FilePath, FullPath, Filename, Worksheetname = "Totals";

                    //Retrieve data from Database or testdata file
                    username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                    password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                    client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                    environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                    currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                    Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                    As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                    Start_Month = TestData.ExcelData.TestDataReader.ReadData(1, "Start_Month");
                    As_Of_Date_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date_PreviousYear");
                    Start_Month_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "Start_Month_PreviousYear");
                    hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");

                    Logger.WriteInfoMessage("Test Case : Validate Pace and Forecast Report when comparison year is 1 at hotel Level");

                    //Enter Email address and password
                    Login.Frontend_SignIn(username, password);

                    //Select Client 
                    //Navigation.Select_Client(client);

                    Helper.PageDown();
                    Logger.WriteDebugMessage("Client displayed");
                    Navigation.Click_ClientName(client);
                    Logger.WriteDebugMessage(client + " selected");
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User landed on Montly pickup Dashboard page");

                    //Generate the report  with Comparison Year as 1 at hotel   and  a filter other than the  DOW
                    Navigation.Click_Menu_Forecast_and_Budget();
                    Logger.WriteDebugMessage("Forecast and Budget menu drop down displayed");
                    Navigation.Pace_Forecast_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Pace and Forecast Report Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_and_Forecast_Report());

                    ReportParameter.Select_Hotel_DDL();
                    Logger.WriteDebugMessage("List for hotel displayed");
                    ReportParameter.Select_Hotel_value();
                    Logger.WriteDebugMessage(hotel + "selected as hotel");
                    ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                    ReportParameter.Enter_As_Of_Date(As_Of_Date);
                    Logger.WriteDebugMessage("Enter As of date as = " + As_Of_Date);
                    ReportParameter.Enter_Start_Month(Start_Month);
                    Logger.WriteDebugMessage("Enter start Month as = " + Start_Month);
                    ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM();
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
                    string Direct_Room_ComparisonYear = tt.GetCellData(Worksheetname, 20, 10);

                    //TestData.ExcelData.ExcelDataReader hv = new TestData.ExcelData.ExcelDataReader(FullPath);
                    //string ComparisonYear = hv.GetCellData(Worksheetname, 18, 101);
                    //if (ComparisonYear.Contains(Total_Occupied_Rooms_ComparisonYear))
                    //    Logger.WriteDebugMessage(Total_Occupied_Rooms_ComparisonYear + " matched with Total_Occupied_Rooms under ComparisonYear section ");
                    //else
                    //    Assert.Fail("total MIx% under ComparisonYear section not match");

                    //string Total_sold_ADR_ComparisonYear = tt.GetCellData(Worksheetname, 18, 102);
                    //string Total_Occupied_ADR_ComparisonYear = tt.GetCellData(Worksheetname, 18, 103);


                    // Generate the same report with Start date and End date as - 1year  and apply same filter  as above 
                    Helper.ReloadPage();
                    Navigation.Click_Menu_Forecast_and_Budget();
                    Logger.WriteDebugMessage("Forecast and Budget menu drop down displayed");
                    Navigation.Pace_Forecast_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Pace and Forecast Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_and_Forecast_Report());

                    ReportParameter.Select_Hotel_DDL();
                    Logger.WriteDebugMessage("List for hotel displayed");
                    ReportParameter.Select_Hotel_value();
                    Logger.WriteDebugMessage(hotel + "selected as hotel");
                    ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                    ReportParameter.Enter_As_Of_Date(As_Of_Date_PreviousYear);
                    ReportParameter.Enter_Start_Month(Start_Month_PreviousYear);
                    Logger.WriteDebugMessage("Enter As of date as = " + As_Of_Date_PreviousYear);
                    Logger.WriteDebugMessage("Enter Start Month as = " + Start_Month_PreviousYear);
                    ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM();
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
                    string Direct_Room_Forecst_CurrentYear = vv.GetCellData(Worksheetname,10, 10);                   

                    //Match Comparison year data  of report generated  in 1 report with current year data in 2 generated report

                    if (Direct_Room_ComparisonYear.Equals(Direct_Room_Forecst_CurrentYear))
                        Logger.WriteDebugMessage("Total ADR value under current year section matched ");
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
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date", As_Of_Date);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start_Month", Start_Month);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start_Month_PreviousYear", Start_Month_PreviousYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date_PreviousYear", As_Of_Date_PreviousYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Direct_Room_Forecst_CurrentYear", Direct_Room_Forecst_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Direct_Room_ComparisonYear", Direct_Room_ComparisonYear, true);
                }
            }
        }

      
    }
}