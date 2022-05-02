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
        //Validate the Pace and Forecast Report and the Forecast Budget Upload Report
        public static void TC_252838()
        {
            if (TestCaseId == Utility.Constants.TC_252838)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, reportName_stay, Total_Occupied_Rooms, Total_Sold_ADR, Currency, Business_Unit, client,As_Of_Date, Start_Month, FilePath, FullPath, Filename, Worksheetname = "Totals", reportName;
                bool scenario1 = true, scenario2 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                As_Of_Date = TestData.ExcelData.TestDataReader.ReadData(1, "As_Of_Date");
                Start_Month = TestData.ExcelData.TestDataReader.ReadData(1, "Start_Month");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportName_stay = TestData.ExcelData.TestDataReader.ReadData(1, "reportName_stay");
                Total_Sold_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Sold_ADR");
                Total_Occupied_Rooms = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Occupied_Rooms");

                Logger.WriteInfoMessage("Test Case : Validate the Pace and Forecast Report and the Forecast Budget Upload");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigation to Forecast Budget Upload Report
                Navigation.Click_Menu_Forecast_and_Budget();
                Logger.WriteDebugMessage("Foecast and Budget menu Drop down displayed");
                Navigation.Click_Forecast_Budget_Upload_Report();
                Logger.WriteDebugMessage("User landed on Forecast Budget Upload page");

                //Navigate to Pace and Forecast Report 
                Navigation.Click_Menu_Forecast_and_Budget();
                Logger.WriteDebugMessage("Foecast and Budget menu Drop down displayed");
                Navigation.Click_Pace_and_Forecast_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Pace and Forecast report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_and_Forecast_Report());

                //Generate report for hotel Level
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage(As_Of_Date + "entered as As of date");
                ReportParameter.Enter_Pace_Trend_Start_Month(Start_Month);
                Logger.WriteDebugMessage(Start_Month + "entered as start Month");
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
                        Logger.WriteInfoMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 3);
                    if (Name_stay.Contains(reportName_stay))
                        Logger.WriteInfoMessage(reportName_stay + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Sold_ADR = at.GetCellData(Worksheetname, 22, 102);
                    if (Sold_ADR.Contains(Total_Sold_ADR))
                        Logger.WriteInfoMessage(Total_Sold_ADR + " matched with total ADR under Last Year Actual Pickup section");
                    else
                        scenario1 = false;
                }
                //Generate report for Portfolio Level
                Helper.ReloadPage();
                Navigation.Click_Menu_Forecast_and_Budget();
                Logger.WriteDebugMessage("Foecast and Budget menu Drop down displayed");
                Navigation.Click_Pace_and_Forecast_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Pace and Forecast report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_and_Forecast_Report());

                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_DDL();
                Logger.WriteDebugMessage("Portfolio drop down displyed");
                ReportParameter.Portfolio_DDL_value(GlobalParameter.Portfolio);
                Logger.WriteDebugMessage(Portfolio_value + "Selected");
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage(As_Of_Date + "entered as As of date");
                ReportParameter.Enter_Pace_Trend_Start_Month(Start_Month);
                Logger.WriteDebugMessage(Start_Month + "entered as start Month");
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

                    TestData.ExcelData.ExcelDataReader kk = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Occupied_Rooms = kk.GetCellData(Worksheetname, 4, 113);
                    if (Occupied_Rooms.Contains(Total_Occupied_Rooms))
                        Logger.WriteInfoMessage(Total_Occupied_Rooms + " matched with Total Occupied_Rooms for 5/6/2020 ");
                    else
                        scenario2 = false;

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                if (scenario1 == false) Assert.Fail("Report with Hotel level is fail");
                else Logger.WriteInfoMessage("Scenario 1 : Report with Hotel level is Pass");

                if (scenario2 == false) Assert.Fail("Report with Portfolio level is fail");
                else Logger.WriteInfoMessage("Scenario 1 : Report with Portfolio level is Pass");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_As_Of_Date", As_Of_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Start_Month", Start_Month);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);;
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName_stay", reportName_stay);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Sold_ADR", Total_Sold_ADR);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Occupied_Rooms", Total_Occupied_Rooms, true);
            }
        }

    }
}
