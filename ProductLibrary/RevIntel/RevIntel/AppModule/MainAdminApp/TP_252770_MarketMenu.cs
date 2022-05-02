using BaseUtility.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using RevIntel.AppModule.UI;
using RevIntel.PageObject.UI;
using RevIntel.Utility;
using System;
using Navigation = RevIntel.AppModule.UI.Navigation;

namespace RevIntel.AppModule.MainAdminApp
{
    public partial class MainAdminApp : RevIntel.Utility.Setup
    {
        public static string FilePath { get; private set; }
        public static string Filename { get; private set; }
        public static string FullPath { get; private set; }

        //Validate the Market-> Market Report
        public static void TC_252810()
        {
            if (TestCaseId == Utility.Constants.TC_252810)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Portfolio_Name_Date, Hotel,Comparison_Year_ADR, Current_Year_Room_Sold, parameter2_value, parameter2, Currency, Business_Unit, client,parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Sep-20", reportName;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                client = GlobalParameter.Client;
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_Date = "Portfolio: "+GlobalParameter.Portfolio +" for dates: "+startDate +" - "+enddate;
                Current_Year_Room_Sold = TestData.ExcelData.TestDataReader.ReadData(1, "Current_Year_Room_Sold");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Comparison_Year_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "Comparison_Year_ADR");
              
                Logger.WriteInfoMessage("Test Case : Validate the Market-> Market Report");
                Navigation.Click_Menu_Market();
                Logger.WriteDebugMessage("Market menu drop down displayed");
                //Helper.AddDelay(2000);
                Navigation.Market_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Market Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);

                ReportParameter.VerifyUserPreferences(GlobalParameter.Hotel, GlobalParameter.BusinessUnit, GlobalParameter.Currency);

                //Required field Validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message displayed");

                //verify that the "Expand Level" drop down filter functions properly
                if (PageObject_ReportParameter.Market_Report_Expand_Level().Displayed)
                {
                    Logger.WriteDebugMessage("Expand Level Field Displayed");
                }
                else
                    Assert.Fail("Expand Level Field Is missing");

                //Report with Required Field
                ReportParameter.Enter_startDate_EndDate(startDate, enddate);
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));
                    
                    Helper.EnterFrameByxPath(Driver.FindElement(OpenQA.Selenium.By.XPath("//iframe[@name='Market Report']")));
                    
                    string Name = ReportParameter.Get_Report_Name("Market Report");
                    if (Name.Contains(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;
                ExitFrame();
                Helper.ReloadPage();

                /*validate report with one filter*/
                //Navigate to Market Report
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Market Dropdown displayed");
                Navigation.Market_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Market Report  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_report_startdate_enddate(GlobalParameter.Portfolio, startDate, enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
                Helper.PageUp();
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");
               // Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; Central Africa; Sao Tome and Principe;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                //Verify Data in export document and in front end 
                ReportParameter.Report_Excel_Format();
                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));
                if (client == "Kerzner")
                {
                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 4);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteDebugMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Room = at.GetCellData(Worksheetname, 4, 146);
                    if (Room.Contains(Current_Year_Room_Sold))
                        Logger.WriteDebugMessage(Current_Year_Room_Sold + " matched with RoomSold under Current Year section");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Market Dropdown displayed");
                Navigation.Market_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Market report  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Report());
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
                Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; Central Africa;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                //Verify Data in export document and in front end 
                ReportParameter.Report_Excel_Format();

                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = ReportParameter.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                if (client == "Kerzner")
                {
                    
                    TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR = ll.GetCellData(Worksheetname, 10, 77);
                    if (ADR.Contains(Comparison_Year_ADR))
                        Logger.WriteDebugMessage(Comparison_Year_ADR + " matched with total ADR under Compairson Year section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", GlobalParameter.Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", GlobalParameter.Password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", GlobalParameter.BusinessUnit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", GlobalParameter.Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel", GlobalParameter.Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_endDate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", Name);
                if (client=="Kerzner")
                {
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison_Year_ADR", Comparison_Year_ADR);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_Date", Portfolio_Name_Date);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current_Year_Room_Sold", Current_Year_Room_Sold);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);

                }
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", GlobalParameter.Portfolio,true);

            }
        }

        //Validate the Market-> Market Report Parameters
        public static void TC_252811()
        {
            if (TestCaseId == Utility.Constants.TC_252811)
            {
                //Pre-Requisite
                string password,username,environment,client, OTB_Revenue,startDate, Forecast_Total_Revenue, enddate,Hotel,Portfolio_value,Currency,Business_Unit,parameter1,parameter1_value,reportName,Portfolio_Name_Date,parameter2,parameter2_value, FilePath, FullPath, Filename, Worksheetname = "Market Performance";
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
                OTB_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "OTB_Revenue");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Forecast_Total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Forecast_Total_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Market-> Market Report Parameters");

                //Enter Email address and password
                //Login.Frontend_SignIn(username, password);

                //Select Client 
                //Navigation.Select_Client(client);

                Navigation.Market();
                Logger.WriteDebugMessage("Market menu drop down displayed");
                Navigation.Market_Performance();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Market Performance Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Performance());

                //Required field Validation
                Helper.ScrollToText("Hotel/Portfolio");
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message displayed");

                //Report with Required Field
                ReportParameter.Enter_startDate_EndDate(startDate, enddate);
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();
                    AddDelay(25000);

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
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Market Dropdown displayed");
                Navigation.Market_Performance();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Market Performance page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Performance());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected as Room Product");
                Helper.PageUp();
               // Helper.ScrollToText("Hotel/Portfolio");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");
               // Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Room Product: Room; Arabian Court Deluxe Rooms;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();
                    AddDelay(15000);

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
                    string OTB = at.GetCellData(Worksheetname, 4, 3042);
                    if (OTB.Contains(OTB_Revenue))
                        Logger.WriteDebugMessage(OTB_Revenue + " matched with Actual/OTB for Revenue");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Market_Performance();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Market Performance  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Performance());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Helper.ScrollToText("Rate Code");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage(parameter1_value + "Selected as Room Product");
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for channel");
                Helper.PageUp();
                //Helper.ScrollToText("Hotel/Portfolio");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
               // Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; Front Office Direct;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();
                    AddDelay(15000);

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Total_Forecast = ll.GetCellData(Worksheetname, 5, 3546);
                    if (Total_Forecast.Contains(Forecast_Total_Revenue))
                        Logger.WriteDebugMessage(Forecast_Total_Revenue + " matched with Forecast total Revenue");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Actuals/OTB_Revenue", OTB_Revenue);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Forecast_Total_Revenue", Forecast_Total_Revenue, true);
            }
        }

        //Validate the Market-> Market Trend Report
        public static void TC_252812()
        {
            if (TestCaseId == Utility.Constants.TC_252812)
            {
                //Pre-Requisite
                string password, username, environment, client, Subject_No_Rate, startDate, Compare_Start_Date, Compare_End_Date, Third_Party_Website_Room, enddate, Hotel, Portfolio_value, Currency, Business_Unit, parameter1, parameter1_value, reportName, Portfolio_Name_Date, parameter2, parameter2_value, FilePath, FullPath, Filename, Worksheetname = "Market Trend Report";
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
                Compare_Start_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Compare_Start_Date");
                Compare_End_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Compare_End_Date");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_Date");
                Subject_No_Rate = TestData.ExcelData.TestDataReader.ReadData(1, "Subject_No_Rate");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Third_Party_Website_Room = TestData.ExcelData.TestDataReader.ReadData(1, "Third_Party_Website_Room");

                Logger.WriteInfoMessage("Test Case : Validate the Market-> Market Trend Report");

                //Enter Email address and password
                //Login.Frontend_SignIn(username, password);

                //Select Client 
                //Navigation.Select_Client(client);

                Navigation.Market();
                Logger.WriteDebugMessage("Market menu drop down displayed");
                Navigation.Market_Trend_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Market Trend Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Trend_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                //Required field Validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message displayed");

                //Report with Required Field
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Helper.AddDelay(800);
                ReportParameter.Compare_Start_Date(Compare_Start_Date);
                ReportParameter.Compare_End_Date(Compare_End_Date);
                Logger.WriteDebugMessage("Enter Compare start date as = " + Compare_Start_Date);
                Logger.WriteDebugMessage("Enter COmpare end date as = " + Compare_End_Date);
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
                /*validate report with one filter*/
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Market Dropdown displayed");
                Navigation.Market_Trend_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Market Trend Reports page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Trend_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Helper.AddDelay(800);
                ReportParameter.Compare_Start_Date(Compare_Start_Date);
                ReportParameter.Compare_End_Date(Compare_End_Date);
                Logger.WriteDebugMessage("Enter Compare start date as = " + Compare_Start_Date);
                Logger.WriteDebugMessage("Enter Compare end date as = " + Compare_End_Date);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected as Room Product");
                Helper.PageUp();
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
               // Helper.ScrollToText("Filter(s)");
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
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 3);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteDebugMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string No_Rate = at.GetCellData(Worksheetname, 5, 45);
                    if (No_Rate.Contains(Subject_No_Rate))
                        Logger.WriteDebugMessage(Subject_No_Rate + " matched with No Rate for Rooms column under subject section");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter 
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Market_Trend_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Market Trend Report  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Trend_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Helper.AddDelay(800);
                ReportParameter.Compare_Start_Date(Compare_Start_Date);
                ReportParameter.Compare_End_Date(Compare_End_Date);
                Logger.WriteDebugMessage("Enter start date as = " + Compare_Start_Date);
                Logger.WriteDebugMessage("Enter end date as = " + Compare_End_Date);
                Helper.ScrollToText("Booking Date");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage(parameter2_value + "selected for Source Market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
               // Helper.ScrollToText("Filter(s)");
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
                    string Compare_Room = ll.GetCellData(Worksheetname, 10, 32);
                    if (Compare_Room.Contains(Third_Party_Website_Room))
                        Logger.WriteDebugMessage(Third_Party_Website_Room + " matched with Room for Third Party Website under Compare section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Subject_No_Rate", Subject_No_Rate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Third_Party_Website_Room", Third_Party_Website_Room, true);
            }
        }

        //Validate the Market-> Market Segment by Day
        public static void TC_252813()
        {
            if (TestCaseId == Utility.Constants.TC_252813)
            {
                //Pre-Requisite
                string password, username, environment, client, Total_Room, startDate, Total_Other_Revenue, enddate, Hotel, Portfolio_value, Currency, Business_Unit, parameter1, parameter1_value, reportName, Portfolio_Name_Date, parameter2, parameter2_value, FilePath, FullPath, Filename, Worksheetname = "Market Segment by Day";
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
                Total_Room = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Room");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Total_Other_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Other_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Market-> Market Segment by Day");

                //Enter Email address and password
                //Login.Frontend_SignIn(username, password);

                //Select Client 
                //Navigation.Select_Client(client);

                Navigation.Market();
                Logger.WriteDebugMessage("Market menu drop down displayed");
                Navigation.Market_Segment_by_Day();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Market Segment by Day Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Segment_by_Day());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                //Required field Validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message displayed");

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
                /*validate report with one filter*/
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Market Dropdown displayed");
                Navigation.Market_Segment_by_Day();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Market Segment By Day page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Segment_by_Day());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected as Room Product");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
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
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 3);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteDebugMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Room = at.GetCellData(Worksheetname, 8, 581);
                    if (Room.Contains(Total_Room))
                        Logger.WriteDebugMessage(Total_Room + " matched with Total Rooms for 5-1-20");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Market_Segment_by_Day();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Market Segment by Day  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Segment_by_Day());

                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Market");
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

                    TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Other_Revenue = ll.GetCellData(Worksheetname, 12, 327);
                    if (Other_Revenue.Contains(Total_Other_Revenue))
                        Logger.WriteDebugMessage(Total_Other_Revenue + " matched with Other Revenue for 5-7-20");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Room", Total_Room);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Other_Revenue", Total_Other_Revenue, true);
            }
        }

        //Validate the Market-> Market Segment by Day Summary
        public static void TC_252814()
        {
            if (TestCaseId == Utility.Constants.TC_252814)
            {
                //Pre-Requisite
                string password, username, environment, client, Total_Room, startDate, Total_Other_Revenue, enddate, Hotel, Portfolio_value, Currency, Business_Unit, parameter1, parameter1_value, reportName, Portfolio_Name_Date, parameter2, parameter2_value, FilePath, FullPath, Filename, Worksheetname = "Market Segment by Day Summary";
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
                Total_Room = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Room");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Total_Other_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Other_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Market-> Market Segment by Day Summary");

                Navigation.Market();
                Logger.WriteDebugMessage("Market menu drop down displayed");
                Navigation.Market_Segment_by_Day_Summary();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Market Segment by Day Summary Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Segment_by_Day_Summary());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                //Required field Validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message displayed");

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
                /*validate report with one filter*/
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Market Dropdown displayed");
                Navigation.Market_Segment_by_Day_Summary();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Market Segment By Day Summary page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Segment_by_Day_Summary());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected as Room Product");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
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
                    string Room = at.GetCellData(Worksheetname, 5, 24);
                    if (Room.Contains(Total_Room))
                        Logger.WriteDebugMessage(Total_Room + " matched with Total Rooms for 1-1-20");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Market_Segment_by_Day_Summary();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Market Segment by Day summary  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Segment_by_Day_Summary());

                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter1_value + "selected for Market");
                ReportParameter.Parameter_market();
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Channel");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; Front Office Direct;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Other_Revenue = ll.GetCellData(Worksheetname, 5, 29);
                    if (Other_Revenue.Contains(Total_Other_Revenue))
                        Logger.WriteDebugMessage(Total_Other_Revenue + " matched with Other Revenue for 1-1-20");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Room", Total_Room);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Other_Revenue", Total_Other_Revenue, true);
            }
        }

        //Validate the Market-> Annual Market Analysis by Month
        public static void TC_252815()
        {
            if (TestCaseId == Utility.Constants.TC_252815)
            {
                //Pre-Requisite
                string password, username, environment, client, Total_Jan, Total_Feb, Hotel, Portfolio_value, Currency, Business_Unit, parameter1, parameter1_value, reportName, Portfolio_Name_Date, parameter2, parameter2_value, FilePath, FullPath, Filename, Worksheetname = "Sheet1";
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Name_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_Date");
                Total_Jan = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Jan");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Total_Feb = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Feb");

                Logger.WriteInfoMessage("Test Case : Validate the Market-> Annual Market Analysis by Month");

                Navigation.Market();
                Logger.WriteDebugMessage("Market menu drop down displayed");
                Navigation.Annual_Market_Analysis_by_Month();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Annual Market Analysis by Month Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Annual_Market_Analysis_by_Month());

                //Required field Validation
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
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
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Market Dropdown displayed");
                Navigation.Annual_Market_Analysis_by_Month();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User Landed on Annual Market Analysis by Month Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Annual_Market_Analysis_by_Month());
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_DDL();
                ReportParameter.Portfolio_DDL_value(GlobalParameter.Portfolio);
                Business_Source.Year_DDL();
                Business_Source.Year_value();
                Logger.WriteDebugMessage("Year is selected as 2019");
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected as Room Product");
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
                    string Jan = at.GetCellData(Worksheetname, 3, 446);
                    if (Jan.Contains(Total_Jan))
                        Logger.WriteDebugMessage(Total_Jan + " matched with Total For Jan 2019");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Helper.AddDelay(1000);
                Navigation.Annual_Market_Analysis_by_Month();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User Landed on Annual Market Analysis by Month Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Annual_Market_Analysis_by_Month());

                Business_Source.Year_DDL();
                Business_Source.Year_value();
                Logger.WriteDebugMessage("Year is selected as 2019");
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter1_value + "selected for Market");
                ReportParameter.Parameter_market();
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Channel");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; Front Office Direct;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Feb = ll.GetCellData(Worksheetname, 4, 336);
                    if (Feb.Contains(Total_Feb))
                        Logger.WriteDebugMessage(Total_Feb + " matched with Other  for Feb");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_Date", Portfolio_Name_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Jan", Total_Jan);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Feb", Total_Feb, true);
            }
        }

        //Validate the Market-> Rate code Analyisis
        public static void TC_252816()
        {
            if (TestCaseId == Utility.Constants.TC_252816)
            {
                //Pre-Requisite
                string password, username, environment, client, Current_Year_Room_Sold, startDate, Comparison_Year_Total_ADR, enddate, Hotel, Portfolio_value, Currency, Business_Unit, parameter1, parameter1_value, reportName, Portfolio_Name_Date, parameter2, parameter2_value, FilePath, FullPath, Filename, Worksheetname = "Rate Code Analysis";
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
                Comparison_Year_Total_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "Comparison_Year_Total_ADR");

                Logger.WriteInfoMessage("Test Case : Validate the Market-> Rate code Analyisis");

                Navigation.Market();
                Logger.WriteDebugMessage("Market menu drop down displayed");
                Navigation.Rate_Code_Analysis();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Rate Code Analysis Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Rate_Code_Analysis());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                //Required field Validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message displayed");

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
                /*validate report with one filter*/
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Market Dropdown displayed");
                Navigation.Rate_Code_Analysis();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Rate Code Analysis page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Rate_Code_Analysis());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter1_value + "Selected as Room Product");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
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
                    string Room_Sold = at.GetCellData(Worksheetname, 4, 172);
                    if (Room_Sold.Contains(Current_Year_Room_Sold))
                        Logger.WriteDebugMessage(Current_Year_Room_Sold + " matched with Room_Sold for Current Year");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Rate_Code_Analysis();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Rate Code Analysis  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Rate_Code_Analysis());

                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter1_value + "selected for Market");
                ReportParameter.Parameter_market();
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Channel");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; Front Office Direct;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR = ll.GetCellData(Worksheetname, 10, 156);
                    if (ADR.Contains(Comparison_Year_Total_ADR))
                        Logger.WriteDebugMessage(Comparison_Year_Total_ADR + " matched with total ADR for Comparison Year");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Comparison_Year_Total_ADR", Comparison_Year_Total_ADR, true);
            }
        }

        //Validate the Market-> Market Analysis by Year
        public static void TC_252817()
        {
            if (TestCaseId == Utility.Constants.TC_252817)
            {
                //Pre-Requisite
                string password, username, environment, client, Total_Revenue, startDate, Total_Rooms, enddate, Hotel, Portfolio_value, Currency, Business_Unit, parameter1, parameter1_value, reportName, Portfolio_Name_Date, parameter2, parameter2_value, FilePath, FullPath, Filename, Worksheetname = "Market Analysis by Year";
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
                Total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Revenue");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Total_Rooms = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Rooms");

                Logger.WriteInfoMessage("Test Case : Validate the Market-> Market Analysis by Year");

                Navigation.Market();
                Logger.WriteDebugMessage("Market menu drop down displayed");
                Navigation.Market_Analysis_by_Year();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Market Analysis by Year Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Analysis_by_Year());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                //Required field Validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message displayed");

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
                /*validate report with one filter*/
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Market Dropdown displayed");
                Navigation.Market_Analysis_by_Year();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Market Analysis by Year page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Analysis_by_Year());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room ProductS drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected as Room Product");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
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
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 3);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteDebugMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Revenue = at.GetCellData(Worksheetname, 5, 62);
                    if (Revenue.Contains(Total_Revenue))
                        Logger.WriteDebugMessage(Total_Revenue + " matched with Revenue for 2020 KPI");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Market_Analysis_by_Year();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Market Analysis by Year  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Analysis_by_Year());

                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "selected for Market");
                ReportParameter.Select_RoomProduct_DDL();
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Channel");
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
                    string Room = ll.GetCellData(Worksheetname, 5, 40);
                    if (Room.Contains(Total_Rooms))
                        Logger.WriteDebugMessage(Total_Rooms + " matched with total Rooms for 2020 KPI");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Revenue", Total_Revenue);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Rooms", Total_Rooms, true);
            }
        }

        //Validate the Market-> Monthly Market segment Report
        public static void TC_252818()
        {
            if (TestCaseId == Utility.Constants.TC_252818)
            {
                //Pre-Requisite
                string password, username, environment, client, As_Of_Date, Total_Occupied_Rooms, startDate, Budget_Occupied_Rooms, enddate, Hotel, Portfolio_value, Currency, Business_Unit, parameter1, parameter1_value, reportName, Portfolio_Name_Date, parameter2, parameter2_value, FilePath, FullPath, Filename, Worksheetname = "Jun 2020";
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
                Total_Occupied_Rooms = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Occupied_Rooms");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Budget_Occupied_Rooms = TestData.ExcelData.TestDataReader.ReadData(1, "Budget_Occupied_Rooms");

                Logger.WriteInfoMessage("Test Case : Validate the Market-> Monthly Market segment Report");

                Navigation.Click_Menu_Market();
                Logger.WriteDebugMessage("Market menu drop down displayed");
                Navigation.Monthly_Market_Segment_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Monthly Market segment Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Monthly_Market_Segment_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                //verify that the "Source Market" field on Monthly Market Segment Report
                if (PageObject_ReportParameter.Select_SourceMarket_DDL().Displayed)
                {
                    Logger.WriteDebugMessage("Source Market is hidden");
                }
                else
                    Assert.Fail("Source Market Displayed");

                //Verify Comparison Year: field on report
                Helper.VerifyTextOnPage("Comparison Year: ");
                Logger.WriteDebugMessage("Comparison Year: Field is present");

                //Required field Validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message displayed");

                //Report with Required Field
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter enddate as = " + As_Of_Date);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name = tt.GetCellData(Worksheetname, 3, 1);
                    if (Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;
                }
                /*validate report with one filter*/
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Market Dropdown displayed");
                Navigation.Monthly_Market_Segment_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Monthly Market Segment report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Monthly_Market_Segment_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter enddate as = " + As_Of_Date);
                Helper.ScrollToText("Room Product:");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room ProductS drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected as Room Product");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
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
                    string Occupied_Rooms = at.GetCellData(Worksheetname, 10, 48);
                    if (Occupied_Rooms.Contains(Total_Occupied_Rooms))
                        Logger.WriteDebugMessage(Total_Occupied_Rooms + " matched with Total_Occupied_Rooms for 2020 Forecast section");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Market Dropdown displayed");
                Navigation.Monthly_Market_Segment_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Monthly Market segment report  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Monthly_Market_Segment_Report());

                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Enter_As_Of_Date(As_Of_Date);
                Logger.WriteDebugMessage("Enter enddate as = " + As_Of_Date);
                Helper.ScrollToText("Room Product");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "selected for Market");
                ReportParameter.Select_RoomProduct_DDL();
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
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Budget_Occupied = ll.GetCellData(Worksheetname, 5, 39);
                    if (Budget_Occupied.Contains(Budget_Occupied_Rooms))
                        Logger.WriteDebugMessage(Budget_Occupied_Rooms + " matched with Budget_Occupied_Rooms for 2020 Budget");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Occupied_Rooms", Total_Occupied_Rooms);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Budget_Occupied_Rooms", Budget_Occupied_Rooms, true);
            }
        }

        //Validate the Market-> Rate Code Trend Report (RHBI)
        public static void TC_252819()
        {
            if (TestCaseId == Utility.Constants.TC_252819)
            {
                //Pre-Requisite
                string password, username, environment, client, Subject_Room, Compare_Start_Date, Compare_End_Date,startDate, Compare_ADR, enddate, Hotel, Portfolio_value, Currency, Business_Unit, parameter1, parameter1_value, reportName, Portfolio_Name_Date, parameter2, parameter2_value, FilePath, FullPath, Filename, Worksheetname = "Rate Code Trend Report";
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

                Logger.WriteInfoMessage("Test Case : Validate the Market-> Rate Code Trend Report (RHBI)");

                Navigation.Market();
                Logger.WriteDebugMessage("Market menu drop down displayed");
                Navigation.Rate_Code_Trend_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Monthly Market segment Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Rate_Code_Trend_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);


                //Required field Validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message displayed");

                //Report with Required Field
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Helper.AddDelay(1000);
                ReportParameter.Compare_Start_Date(Compare_Start_Date);
                ReportParameter.Compare_End_Date(Compare_End_Date);
                Logger.WriteDebugMessage("Enter Compare_Start_Date as = " + Compare_Start_Date);
                Logger.WriteDebugMessage("Enter Compare_End_Date as = " + Compare_End_Date);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
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
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Market Dropdown displayed");
                Navigation.Rate_Code_Trend_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Rate code Trend Report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Rate_Code_Trend_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Helper.ScrollToText("Booking Date");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room ProductS drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected as Room Product");
                ReportParameter.Compare_Start_Date(Compare_Start_Date);
                ReportParameter.Compare_End_Date(Compare_End_Date);
                Helper.ScrollToText("View Analysis");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
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
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 2);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteDebugMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Rooms = at.GetCellData(Worksheetname, 6, 32);
                    if (Rooms.Contains(Subject_Room))
                        Logger.WriteDebugMessage(Subject_Room + " matched with Total Room under subject section");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.Market());
                Logger.WriteDebugMessage("Portfolio Dropdown displayed");
                Navigation.Rate_Code_Trend_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Rate code Trend report  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Rate_Code_Trend_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Helper.ScrollToText("Booking Date");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "selected for Market");
                ReportParameter.Select_RoomProduct_DDL();
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Channel");
                ReportParameter.Parameter_Channel();
                ReportParameter.Compare_Start_Date(Compare_Start_Date);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Compare_End_Date(Compare_End_Date);
                Logger.WriteDebugMessage("Enter end date as = " + Compare_End_Date);
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
                    string ADR = ll.GetCellData(Worksheetname, 12, 75);
                    if (ADR.Contains(Compare_ADR))
                        Logger.WriteDebugMessage(Compare_ADR + " matched with total ADR for Compare section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Subject_Room", Subject_Room);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Compare_ADR", Compare_ADR, true);
            }
        }
    }
}