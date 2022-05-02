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
        //Validate the Market->Market Report when comparison year is 1 at hotel Level
        public static void TC_269887()

        {
            if (TestCaseId == Utility.Constants.TC_269887)
            {
                //Pre-Requisite
                string password, username, environment, currency, Business_Unit, client,Hotel, startDate, enddate,enddate_PreviousYear, startDate_PreviousYear,
                    FilePath, FullPath, Filename, Worksheetname = "Totals";

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
                startDate_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "startDate_PreviousYear");
                enddate_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "enddate_PreviousYear");

                Logger.WriteInfoMessage("Test Case : Validate the Market->Market Report when comparison year is 1 at hotel Level");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);


                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Market();
                Logger.WriteDebugMessage("Market menu drop down displayed");
                Navigation.Market_Report();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Market Report Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Report());

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
                string RoomSold_CompaYear1 = tt1.GetCellData(Worksheetname, 8,1099);
                string Mix_CompaYear1 = tt1.GetCellData(Worksheetname, 9, 1099);
                string ADR_CompaYear1 = tt1.GetCellData(Worksheetname,10, 1099);
                string Revenue_CompaYear1 = tt1.GetCellData(Worksheetname,11, 1099);

                //Report with Comparison Year as 2 at Hotel Level
                Helper.ReloadPage();
                Navigation.Market();
                Logger.WriteDebugMessage("Market menu drop down displayed");
                Navigation.Market_Report();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Market Report Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Report());

                //Generate the report  with Comparison Year(2019) at Hotel Level 
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_endDate", enddate);
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

        //Validate the Market->Market Report when comparison year is 2 at hotel Level
        public static void TC_269888()
        {
            if (TestCaseId == Utility.Constants.TC_269888)
            {
                string password, username, environment, currency, Business_Unit, Hotel, client,startDate, enddate,startDate_PreviousYear, enddate_PreviousYear, Mix_CurrentYear,
                    FilePath, FullPath, Filename, Worksheetname = "Totals";

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                startDate_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "startDate_PreviousYear");
                enddate_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "enddate_PreviousYear");
                Mix_CurrentYear = TestData.ExcelData.TestDataReader.ReadData(1, "Mix_CurrentYear");

                Logger.WriteInfoMessage("Test Case : Validate the Market->Market Report when comparison year is 2 at hotel Level");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Generate the report  with Comparison Year as 2 at hotel Level
                Navigation.Market();
                Logger.WriteDebugMessage("Market menu drop down displayed");
                Navigation.Click_Market_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Market Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Report());

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

                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                string RoomSold_CompaYear1 = tt.GetCellData(Worksheetname, 8,918);
                string Mix_CompaYear1 = tt.GetCellData(Worksheetname, 9, 918);
                string ADR_CompaYear1 = tt.GetCellData(Worksheetname, 10, 918);
                string Revenue_CompaYear1 = tt.GetCellData(Worksheetname, 11, 918);


                // Generate the same report with Start date and End date as - 2year  
                Helper.ReloadPage();
                Navigation.Market();
                Logger.WriteDebugMessage("Market menu drop down displayed");
                Navigation.Market_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Market Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Report());

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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Date", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_End Date", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start Date of previous year", startDate_PreviousYear);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_End Date of previous year", enddate_PreviousYear);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_endDate", enddate);
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

        //Validate the Market->Market Report when comparison year is 3 at hotel Level
        public static void TC_269889()
        {
            if (TestCaseId == Utility.Constants.TC_269889)
            {
                {
                    string password, username, environment, currency, Business_Unit, client, Mix_CurrentYear,
                        startDate, enddate, hotel, parameter1, parameter1_value, startDate_PreviousYear, enddate_PreviousYear,
                        FilePath, FullPath, Filename, Worksheetname = "Totals";

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
                    Mix_CurrentYear = TestData.ExcelData.TestDataReader.ReadData(1, "Mix_CurrentYear");

                    Logger.WriteInfoMessage("Test Case : Validate the Market->Market Report when comparison year is 3 at hotel Level");

                    //Enter Email address and password
                    Login.Frontend_SignIn(username, password);

                    //Select Client 
                    Navigation.Select_Client(client);

                    //Generate the report  with Comparison Year as 3 at hotel
                    Navigation.Market();
                    Logger.WriteDebugMessage("Market drop down displayed");
                    Navigation.Market_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Market Report Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Report());

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
                    ReportParameter.Click_View_Analysis();
                    Helper.AddDelay(50000);
                    Logger.WriteDebugMessage("Report generated");

                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Roomsold_ComparisonYear = tt.GetCellData(Worksheetname, 8,1265);
                    string Mix_ComparisonYear = tt.GetCellData(Worksheetname, 9, 1265);
                    string ADR_ComparisonYear = tt.GetCellData(Worksheetname, 10, 1265);
                    string Revenue_ComparisonYear = tt.GetCellData(Worksheetname, 11, 1265);


                    // Generate the same report with Start date and End date as - 3year 
                    Helper.ReloadPage();
                    Navigation.Market();
                    Logger.WriteDebugMessage("Market menu drop down displayed");
                    Navigation.Click_Market_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Market Report Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Report());

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
                    string Roomsold_CurrentYear = vv.GetCellData(Worksheetname, 4,1572);
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

        //Validate the Market->Market Report when comparison year is 1 at hotel Level and DOW filter
        public static void TC_269890()
        {
            if (TestCaseId == Utility.Constants.TC_269890)
            {
                {
                    string password, username, environment, currency, Business_Unit, client, Mix_CurrentYear, Mix_ComparisonYear,
                        startDate, enddate, hotel, startDate_PreviousYear, enddate_PreviousYear,
                        FilePath, FullPath, Filename, Worksheetname = "Totals";

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

                    Logger.WriteInfoMessage("Test Case : Validate the Market->Market Report when comparison year is 1 at hotel Level and DOW filter");

                    //Enter Email address and password
                    Login.Frontend_SignIn(username, password);

                    //Select Client 
                    Navigation.Select_Client(client);

                    //Generate the report  with Comparison Year as 1 at hotel   and  a filter other than the  DOW
                    Navigation.Market();
                    Logger.WriteDebugMessage("Room Type menu drop down displayed");
                    Navigation.Market_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Room Type Analysis Report Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Report());

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
                    string Roomsold_ComparisonYear = tt.GetCellData(Worksheetname, 8,1099);

                    TestData.ExcelData.ExcelDataReader hv = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ComparisonYear = hv.GetCellData(Worksheetname, 9, 1099);
                    if (ComparisonYear.Contains(Mix_ComparisonYear))
                        Logger.WriteDebugMessage(Mix_ComparisonYear + " matched with total MIx% under ComparisonYear section ");
                    else
                        Assert.Fail("total MIx% under ComparisonYear section not match");

                    string ADR_ComparisonYear = tt.GetCellData(Worksheetname, 10, 1099);
                    string Revenue_ComparisonYear = tt.GetCellData(Worksheetname, 11, 1099);


                    // Generate the same report with Start date and End date as - 1year  and apply same filter  as above 
                    Helper.ReloadPage();
                    Navigation.Market();
                    Logger.WriteDebugMessage("Market menu drop down displayed");
                    Navigation.Market_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Market Report Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Report());

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
                    string Roomsold_CurrentYear = vv.GetCellData(Worksheetname, 4, 1680);

                    TestData.ExcelData.ExcelDataReader kk = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Mix = kk.GetCellData(Worksheetname,5,1680);
                    if (Mix.Contains(Mix_CurrentYear))
                        Logger.WriteDebugMessage(Mix_CurrentYear + " matched with total MIx% under current year section ");
                    else
                        Assert.Fail("total MIx% under current year section not match");

                    string ADR_CurrentYear = vv.GetCellData(Worksheetname, 6, 1680);
                    string Revenue_CurrentYear = vv.GetCellData(Worksheetname, 7, 1680);

                    //Match Comparison year data  of report generated  in 1 report with current year data in 2 generated report

                    if (Roomsold_ComparisonYear.Equals(Roomsold_CurrentYear))
                        Logger.WriteDebugMessage("Total ADR value under current year section matched ");
                    else
                        Assert.Fail("Total ADR value under current year section not matched");

                    if (ComparisonYear.Contains(Mix_CurrentYear))
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
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year MIX% for current year", Mix_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year ADR for current year", ADR_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison Year Revenue for current year", Revenue_ComparisonYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Room sold for previous year", Roomsold_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year Mix% for previous year", Mix_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year ADR for previous year", ADR_CurrentYear);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current year revenue for previous year", Revenue_CurrentYear, true);
                }
            }
        }

        //Validate the Market->Market Report when comparison year is 1 at portfolio level and a filter
        public static void TC_269891()
        {
            if (TestCaseId == Utility.Constants.TC_269891)
            {
                {
                    string password, username, environment, currency, Business_Unit, client, Mix_ComparisonYear, Mix_CurrentYear,
                        startDate, enddate, portfolio_value, parameter1_value, startDate_PreviousYear, enddate_PreviousYear,
                        FilePath, FullPath, Filename, Worksheetname = "Totals";

                    //Retrieve data from Database or testdata file
                    username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                    password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                    client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                    environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                    currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                    Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                    startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                    enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                    parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                    startDate_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "startDate_PreviousYear");
                    enddate_PreviousYear = TestData.ExcelData.TestDataReader.ReadData(1, "enddate_PreviousYear");
                    portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "portfolio_value");
                    Mix_ComparisonYear = TestData.ExcelData.TestDataReader.ReadData(1, "Mix_ComparisonYear");
                    Mix_CurrentYear = TestData.ExcelData.TestDataReader.ReadData(1, "Mix_CurrentYear");

                    Logger.WriteInfoMessage("Test Case : Validate the Market->Market Report when comparison year is 1 at portfolio level and a filter");

                    //Enter Email address and password
                    Login.Frontend_SignIn(username, password);

                    //Select Client 
                    Navigation.Select_Client(client);

                    //Generate the report  with Comparison Year as 1 at hotel level
                    Navigation.Market();
                    Logger.WriteDebugMessage("Market menu drop down displayed");
                    Navigation.Market_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Market Report Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Report());

                    ReportParameter.Portfolio_RadioButton();
                    ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                    ReportParameter.Portfolio_report_startdate_enddate(portfolio_value, startDate, enddate);
                    Logger.WriteDebugMessage("Enter start date as = " + startDate);
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

                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Roomsold_ComparisonYear = tt.GetCellData(Worksheetname, 8,141);

                    TestData.ExcelData.ExcelDataReader hv = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ComparisonYear = hv.GetCellData(Worksheetname, 9, 141);
                    if (ComparisonYear.Contains(Mix_ComparisonYear))
                        Logger.WriteDebugMessage(Mix_ComparisonYear + " matched with total MIx% under ComparisonYear section ");
                    else
                        Assert.Fail("total MIx% under ComparisonYear section not match");

                    string ADR_ComparisonYear = tt.GetCellData(Worksheetname, 10, 141);
                    string Revenue_ComparisonYear = tt.GetCellData(Worksheetname, 11, 141);


                    // Generate the same report with Start date and End date as - 1year  and apply same filter  as above 
                    Helper.ReloadPage();
                    Navigation.Market();
                    Logger.WriteDebugMessage("Market menu drop down displayed");
                    Navigation.Market_Report();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Market Report Page");

                    Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Report());

                    ReportParameter.Portfolio_RadioButton();
                    ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                    ReportParameter.Portfolio_report_startdate_enddate(portfolio_value, startDate_PreviousYear, enddate_PreviousYear);
                    Logger.WriteDebugMessage("Enter start date as = " + startDate);
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

                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader vv = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Roomsold_CurrentYear = vv.GetCellData(Worksheetname, 4,212);

                    TestData.ExcelData.ExcelDataReader kk = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Mix = kk.GetCellData(Worksheetname, 5, 212);
                    if (Mix.Contains(Mix_CurrentYear))
                        Logger.WriteDebugMessage(Mix_CurrentYear + " matched with total MIx% under ComparisonYear section ");
                    else
                        Assert.Fail("total MIx% under ComparisonYear section not match");

                    string ADR_CurrentYear = vv.GetCellData(Worksheetname, 6, 212);
                    string Revenue_CurrentYear = vv.GetCellData(Worksheetname, 7, 212);

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
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_portfolio_value", portfolio_value);
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

        //Validate the Market->Market Report Current year data
        public static void TC_269892()
        {
            if (TestCaseId == Utility.Constants.TC_269892)
            {
                {
                    string password, username, environment, currency, Business_Unit, client,
                        startDate, enddate, hotel,
                        FilePath, FullPath, Filename, Worksheetname = "Totals";
                    bool scenario1 = true, scenario2 = true;

                    //Retrieve data from Database or testdata file
                    username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                    password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                    client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                    environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                    hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                    currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                    Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                    startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                    enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");

                    Logger.WriteInfoMessage("Test Case : Validate Room Type analysis Current year data");

                    //Enter Email address and password
                    Login.Frontend_SignIn(username, password);


                    //Select Client 
                    Navigation.Select_Client(client);

                    Navigation.Market();
                    Logger.WriteDebugMessage("Market menu drop down displayed");
                    Navigation.Market_Report();
                    AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Market Report Page");

                    EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Report());

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
                    string RoomSold_CompaYear1 = tt1.GetCellData(Worksheetname, 4,1514);
                    string Mix_CompaYear1 = tt1.GetCellData(Worksheetname, 5, 1514);
                    string ADR_CompaYear1 = tt1.GetCellData(Worksheetname, 6, 1514);
                    string Revenue_CompaYear1 = tt1.GetCellData(Worksheetname, 7, 1514);

                    //Report with Comparison Year as 2 at Hotel Level
                    Helper.ReloadPage();
                    Navigation.Market();
                    Logger.WriteDebugMessage("Market menu drop down displayed");
                    Navigation.Market_Report();
                    AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Market Report Page");

                    EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Report());

                    //Generate the report  with Comparison Year as 2 at Hotel Level 
                    ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                    ReportParameter.Enter_StartDate(startDate);
                    ReportParameter.Enter_EndDate(enddate);
                    Logger.WriteDebugMessage("Enter start date as = " + startDate);
                    Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                    ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM();
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
                    string RoomSold_CompaYear2 = rr.GetCellData(Worksheetname, 4, 1217);
                    string Mix_CompaYear2 = rr.GetCellData(Worksheetname, 5, 1217);
                    string ADR_CompaYear2 = rr.GetCellData(Worksheetname, 6, 1217);
                    string Revenue_CompaYear2 = rr.GetCellData(Worksheetname, 7, 1217);

                    //Report with Comparison Year as 3 at Hotel Level
                    Helper.ReloadPage();
                    Navigation.Market();
                    Logger.WriteDebugMessage("Market menu drop down displayed");
                    Navigation.Market_Report();
                    AddDelay(10000);
                    Logger.WriteDebugMessage("User Landed on Market Report Page");

                    EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Report());

                    //Generate the report  with Comparison Year as 3 at Hotel Level 
                    ReportParameter.Select_Currency_Business_value(Business_Unit, currency);
                    ReportParameter.Enter_StartDate(startDate);
                    ReportParameter.Enter_EndDate(enddate);
                    Logger.WriteDebugMessage("Enter start date as = " + startDate);
                    Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                    ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM();
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
                    string RoomSold_CompaYear3 = uu.GetCellData(Worksheetname, 4, 1265);
                    string Mix_CompaYear3 = uu.GetCellData(Worksheetname, 5, 1265);
                    string ADR_CompaYear3 = uu.GetCellData(Worksheetname, 6, 1265);
                    string Revenue_CompaYear3 = uu.GetCellData(Worksheetname, 7, 1265);

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
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Room sold value under current year section for Comparision year 1", RoomSold_CompaYear1);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Mix% value under current year section for Comparision year 1", Mix_CompaYear1);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_ADR value under current year section for Comparision year 1", ADR_CompaYear1);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Revenue value under current year section for Comparision year 1", Revenue_CompaYear1);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Room sold value under current year section for Comparision year 2", RoomSold_CompaYear2);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Mix% value under current year section for Comparision year 2", Mix_CompaYear2);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_ADR value under current year section for Comparision year 2", ADR_CompaYear2);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Revenue value under current year section for Comparision year 2", Revenue_CompaYear2);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Room sold value under current year section for Comparision year 3", RoomSold_CompaYear3);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Mix% value under current year section for Comparision year 3", Mix_CompaYear3);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_ADR value under current year section for Comparision year 3", ADR_CompaYear3);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Revenue sold value under current year section for Comparision year 3", RoomSold_CompaYear3, true);
                }
            }
        }
    }
}