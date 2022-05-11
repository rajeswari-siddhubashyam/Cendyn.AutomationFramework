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
        //Validate the Best Available Rate Contribution
        public static void TC_252860()
        {
            if (TestCaseId == Utility.Constants.TC_252860)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio_value, Portfolio_Name_Date,Hotel,Total_ADR_2019, parameter2_value, Total_Revenue_2020,parameter2, Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Best Available Rate Contributio", reportName;
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
                Total_ADR_2019 = TestData.ExcelData.TestDataReader.ReadData(1, "Total_ADR_2019");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Total_Revenue_2020 = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Revenue_2020");

                Logger.WriteInfoMessage("Test Case : Validate the Best Available Rate Contribution");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Room_Rate_Menu();
                Logger.WriteDebugMessage("Room Rate drop down displayed");
                Navigation.Best_Available_Rate_Contribution_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Best Available Rate Contribution Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Best_Available_Rate_Contribution_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
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
                        Logger.WriteInfoMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;
                }
                Helper.ReloadPage();

                /*validate report with one filter*/
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Room_Rate_Menu();
                Logger.WriteDebugMessage("Room Rate Dropdown displayed");
                Navigation.Best_Available_Rate_Contribution_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User landed on Best Available Rate Contribution Report  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Best_Available_Rate_Contribution_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected as source market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(70000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                Helper.AddDelay(1000);
                //Helper.ScrollToText("Best Available Rate Contribution");
                //Helper.PageUp();
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile(FilePath);

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 3);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteInfoMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR = at.GetCellData(Worksheetname, 4, 25);
                    if (ADR.Contains(Total_ADR_2019))
                        Logger.WriteInfoMessage(Total_ADR_2019 + " matched with total ADR  under 2019 section");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Room_Rate_Menu();
                Logger.WriteDebugMessage("Room Rate Dropdown displayed");
                Navigation.Best_Available_Rate_Contribution_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Best Available Rate Contribution Report  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Best_Available_Rate_Contribution_Report());
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
                Helper.AddDelay(1000);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(70000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; Central Africa;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                //Helper.ScrollToText("Best Available Rate Contribution");
                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Report_Excel_Format();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Total_Revenue = ll.GetCellData(Worksheetname, 10, 14);
                    if (Total_Revenue.Contains(Total_Revenue_2020))
                        Logger.WriteInfoMessage(Total_Revenue_2020 + " matched with total Revenue under 2020 section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_ADR_2019", Total_ADR_2019);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Revenue_2020", Total_Revenue_2020, true);
            }
        }

        //Validate the Total Revenue Analysis
        public static void TC_252861()
        {
            if (TestCaseId == Utility.Constants.TC_252861)
            {
                //Pre-Requisite
                string password, username, parameter2, parameter2_value,environment, Portfolio_value, Portfolio_Name_Date, Hotel, Total_Revenue, Total_Rooms,Currency, Business_Unit, client, parameter1, parameter1_value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Total Revenue Analysis", reportName;
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
                Total_Rooms = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Rooms");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                Total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Total Revenue Analysis");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Helper.AddDelay(10000);
                Navigation.Click_Room_Rate_Menu();
                Logger.WriteDebugMessage("Room Rate drop down displayed");
                Navigation.Click_Total_Revenue_Analysis_Report();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Total Revenue Analysis Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Total_Revenue_Analysis_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                //Required field Validation
                ReportParameter.Click_View_Analysis();
                Helper.VerifyTextOnPageAndHighLight("Required");
                Logger.WriteDebugMessage("Required field validation message is displaying");

                //Report with Required Field
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Helper.AddDelay(1000);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(80000);
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
                        scenario1 = false;
                }
                Helper.ReloadPage();

                /*validate report with one filter*/
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Room_Rate_Menu();
                Logger.WriteDebugMessage("Room Rate Dropdown displayed");
                Navigation.Click_Total_Revenue_Analysis_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Total Revenue Analysis Report  page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Total_Revenue_Analysis_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                //Report with one parameter
                ReportParameter.Portfolio_RadioButton();
                ReportParameter.Portfolio_report_startdate_enddate(Portfolio_value, startDate, enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage(parameter1_value + "Selected as Room product");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(70000);
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
                    string Name_stay = hh.GetCellData(Worksheetname, 1, 3);
                    if (Name_stay.Contains(Portfolio_Name_Date))
                        Logger.WriteInfoMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name and stay not matched");

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Rooms = at.GetCellData(Worksheetname, 7, 13);
                    if (Rooms.Contains(Total_Rooms))
                        Logger.WriteInfoMessage(Total_Rooms + " matched with Total Room under Revenue");
                    else
                        scenario2 = false;
                }
                //Report with Multiple filter and excel column validation 
                Helper.ReloadPage();
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Room_Rate_Menu();
                Logger.WriteDebugMessage("Room Rate Dropdown displayed");
                Navigation.Click_Total_Revenue_Analysis_Report();
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage("User landed on Total Revenue Analysis Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Total_Revenue_Analysis_Report());
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                Helper.ScrollToText("Booking Date:");
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage(parameter1_value + "Selected as Room Product");
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage(parameter2_value + "selected for Channel");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(70000);
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
                    string Revenue = ll.GetCellData(Worksheetname, 12, 13);
                    if (Revenue.Contains(Total_Revenue))
                        Logger.WriteInfoMessage(Total_Revenue + " matched with total Under Revenue ");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Rooms", Total_Rooms);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter1_value", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Revenue", Total_Revenue, true);
            }
        }
    }
}
