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

        //Validate the Agent Analysis report (no filter)
        public static void TC_252718()
        {
            if (TestCaseId == Utility.Constants.TC_252718)
            {
                //Pre-Requisite
                string password, environment, username, client, startDate, enddate, Portfolio, Currency, Business_Unit, FilePath, FullPath, Filename, Worksheetname = "Jan-20", reportName, PortfolioName_date, Difference_Revenue;
                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                Portfolio = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                PortfolioName_date = TestData.ExcelData.TestDataReader.ReadData(1, "PortfolioName_date");
                Difference_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Difference_Revenue");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");

                Logger.WriteInfoMessage("Test Case : Validate the Agent Analysis report (no filter)");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Select the menu Business Source->Agent Analysis
                Navigation.Select_AgentAnalysis();

                //Click View Analyisis button without mandatory fields
                Helper.EnterFrameByxPath(PageObject_ReportParameter.IFrame_Agent_Analysis());
                ReportParameter.Click_View_Analysis();
                Helper.VerifyTextOnPageAndHighLight("Required");
                Logger.WriteDebugMessage("Validation message displayed for required fields");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Select_Portfolio_RadioButton(startDate, enddate);

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Helper.AddDelay(30000);
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader eat = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string report_Name = eat.GetCellData(Worksheetname, 1, 1);
                    if (report_Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader et = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_date = et.GetCellData(Worksheetname, 1, 2);
                    if (Name_date.Equals(PortfolioName_date))
                        Logger.WriteDebugMessage(PortfolioName_date + " matched with Portfolio name  and date");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Revenue = tt.GetCellData(Worksheetname, 22, 7024);
                    if (Revenue.Equals(Difference_Revenue))
                        Logger.WriteDebugMessage(Difference_Revenue + " matched with Report name ");
                    else
                        Assert.Fail("Report Revenue Difference not matched");

                    //Delete downloded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio", Portfolio);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PortfolioName_date", PortfolioName_date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Difference_Revenue", Difference_Revenue, true);
            }
        }

        //Validate the Agent Summary report
        public static void TC_252719()
        {
            if (TestCaseId == Utility.Constants.TC_252719)
            {
                //Pre-Requisite
                string password, environment, username, client, Parameter1, Parameter2, Parameter1_Value, Parameter2_Value, Portfolio, Currency, Business_Unit, hotel, startDate, enddate, Column, Room_Sold, Food_Revenue, Other_Revenue, FilePath, FullPath, Filename, Worksheetname = "May-20", reportName, HotelName_Date, Portfolio_Name_Date, Portfolio_Name, Hotel_Name_Date, Hotel_Name;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Portfolio = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                Parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1");
                Parameter1_Value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1_Value");
                Parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2");
                Parameter2_Value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2_Value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Food_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Food_Revenue");
                Other_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Other_Revenue");
                Portfolio_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name");
                Portfolio_Name_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Name_Date");
                Hotel_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name");
                Hotel_Name_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Name_Date");
                Room_Sold = TestData.ExcelData.TestDataReader.ReadData(1, "Room_Sold");

                Logger.WriteInfoMessage("Test Case : Validate the Agent Summary report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Click_Automation();
                Logger.WriteDebugMessage("user landed on the Automation RevIntel client selection page");
                Navigation.Click_ClientName(client);
                Logger.WriteDebugMessage(client + " selected");

                //Select the menu Business Source->Agent Summary
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Navigation.Agent_Summary();
                Logger.WriteDebugMessage("Agent_Summary report selected");
                Navigation.BusinessSource();
                Helper.AddDelay(1000);
                Logger.WriteDebugMessage("Agent_Summary gets displayed");

                Helper.EnterFrameByxPath(PageObject_BusinessSource.iframe_AgentSummary());

                //Without entering required field click on view analysis
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message displayed for required fields");

                //with required field  at  hotel level   and verify the report header  and a data validation
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter end date as = " + enddate);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");

                if (client == "Kerzner")
                {
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader eat = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string report_Name = eat.GetCellData(Worksheetname, 1, 1);
                    if (report_Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;
                }
                //With required field +1 additional parameter  at Portfolio level and verify the header and footer
                ReloadPage();
                Helper.AddDelay(10000);
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Navigation.Agent_Summary();
                Logger.WriteDebugMessage("Agent_Summary report selected");
                Navigation.BusinessSource();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("Agent_Summary gets displayed");

                Helper.EnterFrameByxPath(PageObject_BusinessSource.iframe_AgentSummary());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage("Africa is selected as source market drop down");
                ReportParameter.Select_SourceMarket_DDL();
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; Central Africa; Sao Tome and Principe; Cameroon; Central African Republic;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string PortfolioName = at.GetCellData(Worksheetname, 1, 1);
                    if (PortfolioName.Equals(Portfolio_Name))
                        Logger.WriteDebugMessage(Portfolio_Name + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader aa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string PortfolioName_Date = aa.GetCellData(Worksheetname, 1, 3);
                    if (PortfolioName_Date.Equals(Portfolio_Name_Date))
                        Logger.WriteDebugMessage(Portfolio_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");


                    for (int ColumnNumber = 4; ColumnNumber < 10; ColumnNumber++)
                    {
                        Column = TestData.ExcelData.TestDataReader.ReadData(ColumnNumber, "Column");
                        string Actual_column = at.GetCellData(Worksheetname, ColumnNumber, 9);
                        if (Column.Contains(Actual_column))
                            Logger.WriteDebugMessage(Column + " display under current Year section");
                        else
                            Assert.Fail("Report not matched");
                    }

                    for (int ColumnNumber = 10; ColumnNumber < 14; ColumnNumber++)
                    {
                        Column = TestData.ExcelData.TestDataReader.ReadData(ColumnNumber, "Column");
                        string Excel_column = at.GetCellData(Worksheetname, ColumnNumber, 9);
                        if (Column.Contains(Excel_column))
                            Logger.WriteDebugMessage(Column + " display under Prior Year section");
                        else
                            Assert.Fail("Report not matched");
                    }

                    string Food_Revenue_column = at.GetCellData(Worksheetname, 14, 9);
                    if (Food_Revenue_column.Contains(Food_Revenue))
                        Logger.WriteDebugMessage(Food_Revenue + " display under Prior Year section ");
                    else
                        Assert.Fail("Food Revenue missing under Prior Year section");

                    string Prior_Year = at.GetCellData(Worksheetname, 16, 9);
                    if (Prior_Year.Contains(Other_Revenue))
                        Logger.WriteDebugMessage(Other_Revenue + " display under Prior Year section ");
                    else
                        scenario2 = false;
                }
                //With required field +2 additional parameter  at Hotel level and verify the header and footer
                Helper.ReloadPage();
                Helper.AddDelay(1000);
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Navigation.Agent_Summary();
                Logger.WriteDebugMessage("Agent_Summary report selected");
                Navigation.BusinessSource();
                Helper.AddDelay(1000);
                Logger.WriteDebugMessage("Agent_Summary gets displayed");

                Helper.EnterFrameByxPath(PageObject_BusinessSource.iframe_AgentSummary());

                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage("Africa is selected as source market drop down");
                ReportParameter.Select_SourceMarket_DDL();
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage("Room is selected for Room Product ");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; Central Africa; Sao Tome and Principe; Zaire; Cameroon; Central African Republic;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string HotelReport = hh.GetCellData(Worksheetname, 1, 1);
                    if (HotelReport.Equals(Hotel_Name))
                        Logger.WriteDebugMessage(Hotel_Name + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader ta = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_Date = ta.GetCellData(Worksheetname, 1, 3);
                    if (Name_Date.Equals(Hotel_Name_Date))
                        Logger.WriteDebugMessage(Hotel_Name_Date + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader cc = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string RoomSold = cc.GetCellData(Worksheetname, 10, 31);
                    if (RoomSold.Equals(Room_Sold))
                        Logger.WriteDebugMessage(Room_Sold + " matched with Room sold under prior year section");
                    else
                        scenario3 = false;

                    //Delete downloded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                if (scenario1 == false) Assert.Fail("Report with mandatory field is fail");
                else Logger.WriteDebugMessage("Scenario 1 : Report with mandatory field is Pass");

                if (scenario2 == false) Assert.Fail("Report with one filter is fail");
                else Logger.WriteDebugMessage("Scenario 2 : Report with one filter is Pass");

                if (scenario3 == false) Assert.Fail("Report with  multiple filter is fail");
                else Logger.WriteDebugMessage("Scenario 2 : Report with multiple filter is Pass");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_endDate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio", Portfolio);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_Parameter1", Parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_Parameter1_Value", Parameter1_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name", Portfolio_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Name_Date", Portfolio_Name_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_Parameter1", Parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_Parameter1_Value", Parameter1_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_Parameter2", Parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_Parameter2_Value", Parameter2_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Name_Date", Hotel_Name_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Room_Sold", Room_Sold, true);
            }
        }

        //Validate the Agent Room Type Analysis report  
        public static void TC_252720()
        {
            if (TestCaseId == Utility.Constants.TC_252720)
            {
                //Pre-Requisite
                string password, environment, username, client, hotel, Portfolio, parameter1_Value, parameter1, Currency, Business_Unit, startDate, Revenue_Difference, PortolioName_date, HotelName_Date, enddate, FilePath, FullPath, Filename, Worksheetname = "Agent Room Type Analysis", reportName, booking_enddate, booking_startDate, Revenue_CurrentYear;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Portfolio = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_Value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_Value");
                booking_startDate = TestData.ExcelData.TestDataReader.ReadData(1, "booking_startDate");
                booking_enddate = TestData.ExcelData.TestDataReader.ReadData(1, "booking_enddate");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                HotelName_Date = TestData.ExcelData.TestDataReader.ReadData(1, "HotelName_Date");
                Revenue_Difference = TestData.ExcelData.TestDataReader.ReadData(1, "Revenue_Difference");
                PortolioName_date = TestData.ExcelData.TestDataReader.ReadData(1, "PortolioName_date");
                Revenue_CurrentYear = TestData.ExcelData.TestDataReader.ReadData(1, "Revenue_CurrentYear");

                Logger.WriteInfoMessage("Test Case : Validate the Agent Room Type Analysis report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Click_Automation();
                Logger.WriteDebugMessage("user landed on the UAT RevIntel client selection page");
                Navigation.Click_ClientName(client);
                Logger.WriteDebugMessage(client + " selected");

                //Select the menu Business Source->Agent Room Type Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Business_Source.Click_AgentRoomTypeAnalysis();
                Logger.WriteDebugMessage("Agent Room Type Analysis report selected");
                Navigation.BusinessSource();
                Helper.AddDelay(1000);
                Logger.WriteDebugMessage("Agent Room Type Analysis report gets displayed");

                Helper.EnterFrameByxPath(PageObject_BusinessSource.iframe_Agent_Room_Type_Analysis());

                //Required field validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message displayed");

                //Report with only required field and validate report name
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report get generated");
                if (client == "Kerzner")
                {
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader eat = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string report_Name = eat.GetCellData(Worksheetname, 1, 1);
                    if (report_Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;
                }
                //Report with 1 filter at hotel level and validate report header,footer.
                ReloadPage();
                Helper.AddDelay(1000);
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Business_Source.Click_AgentRoomTypeAnalysis();
                Logger.WriteDebugMessage("Agent Room Type Analysis report selected");
                Helper.AddDelay(1000);
                Logger.WriteDebugMessage("Agent Room Type Analysis report gets displayed");

                Helper.EnterFrameByxPath(PageObject_BusinessSource.iframe_Agent_Room_Type_Analysis());

                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);                

                //Add filter Booking start date and Booking end date
                Helper.ScrollToText("Booking Date");
                Business_Source.BookingStartDate(booking_startDate);
                Logger.WriteDebugMessage(booking_startDate + " entered as booking start date");
                Business_Source.BookingEndDate(booking_enddate);
                Logger.WriteDebugMessage(booking_enddate + " entered as booking end date");
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter end date as = " + enddate);

                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s): Booking Date");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name = at.GetCellData(Worksheetname, 1, 1);
                    if (Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader aa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string HotelDate = aa.GetCellData(Worksheetname, 1, 2);
                    if (HotelDate.Equals(HotelName_Date))
                        Logger.WriteDebugMessage(HotelName_Date + " matched with Report stay date and hotel name ");
                    else
                        Assert.Fail("Report stay date and hotel name not matched");

                    TestData.ExcelData.ExcelDataReader sa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Revenue = sa.GetCellData(Worksheetname, 20, 11);
                    if (Revenue.Equals(Revenue_Difference))
                        Logger.WriteDebugMessage(Revenue_Difference + " matched with Revenue");
                    else
                        scenario2 = false;
                }
                //Report with 2 filter at hotel level and validate report header,footer.
                ReloadPage();
                Helper.AddDelay(1000);
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Business_Source.Click_AgentRoomTypeAnalysis();
                Logger.WriteDebugMessage("Agent Room Type Analysis report selected");
                Navigation.BusinessSource();
                Helper.AddDelay(1000);
                Logger.WriteDebugMessage("Agent Room Type Analysis report gets displayed");

                Helper.EnterFrameByxPath(PageObject_BusinessSource.iframe_Agent_Room_Type_Analysis());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);

                //Add filter Booking start date and Booking end date
                Helper.ScrollToText("Booking Date");
                Business_Source.BookingStartDate(booking_startDate);
                Business_Source.BookingEndDate(booking_enddate);
                Logger.WriteDebugMessage(booking_startDate + " entered as booking start date");
                Logger.WriteDebugMessage(booking_enddate + " entered as booking end date");
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Parameter market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage(parameter1_Value + "selected for Market Parameter");

                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Market Segment: Direct; Brand.com; Call Center / In House Reservation");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string PortfolioDate = jj.GetCellData(Worksheetname, 1, 2);
                    if (PortfolioDate.Equals(PortolioName_date))
                        Logger.WriteDebugMessage(PortolioName_date + " matched with Report stay date and hotel name ");
                    else
                        Assert.Fail("Report stay date and hotel name not matched");

                    TestData.ExcelData.ExcelDataReader nm = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Rev_CurrentYear = nm.GetCellData(Worksheetname, 11, 11);
                    if (Rev_CurrentYear.Equals(Revenue_CurrentYear))
                        Logger.WriteDebugMessage(Revenue_CurrentYear + " matched with Revenue");
                    else
                        scenario3 = false;

                    //Delete downloded file
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_booking_startDate", booking_startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_booking_enddate", booking_enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_HotelName_Date", HotelName_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Revenue_Difference", Revenue_Difference);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio", Portfolio);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PortolioName_date", PortolioName_date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1_Value", parameter1_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Revenue_CurrentYear", Revenue_CurrentYear, true);

            }
            Logger.WriteDebugMessage("Test case passed successfully");
        }


        //Validate the Annual Agent Analysis by Month report
        public static void TC_252721()
        {
            if (TestCaseId == Utility.Constants.TC_252721)
            {
                //Pre-Requisite
                string password, username, environment, client, Portfolio, parameter_Value, Parameter, Currency, Business_Unit, hotel, Year, FilePath, FullPath, Filename, Total_ADR, Report_PortfolioName_date, Worksheetname = "Annual Agent Analysis by Month", reportName, Total_Rooms, reportdate_Hotel;
                bool scenario1 = true, scenario2 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Portfolio = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                Year = TestData.ExcelData.TestDataReader.ReadData(1, "Year");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportdate_Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "reportdate_Hotel");
                Total_Rooms = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Rooms");
                Report_PortfolioName_date = TestData.ExcelData.TestDataReader.ReadData(1, "Report_PortfolioName_date");
                Total_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "Total_ADR");
                Parameter = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter");
                parameter_Value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter_Value");

                Logger.WriteInfoMessage("Test Case : Validate the Annual Agent Analysis by Month report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Click_Automation();
                Logger.WriteDebugMessage("user landed on the UAT RevIntel client selection page");
                Navigation.Click_ClientName(client);
                Logger.WriteDebugMessage(client + " selected");

                //Report with hotel leve1 and one filter

                //Select the menu Business Source->Annual Agent Analysis by Month report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Business_Source.Click_Annual_Agent_Analysis_by_Month();
                Logger.WriteDebugMessage("Annual Agent Analysis by Month report selected");
                Navigation.BusinessSource();
                Helper.AddDelay(1000);
                Logger.WriteDebugMessage("Annual Agent Analysis by Month report gets displayed");

                Helper.EnterFrameByxPath(PageObject_BusinessSource.iframe_Annual_Agent_Analysis_by_Month());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");

                //Select parameter and generate report
                Business_Source.Year_DDL();
                Logger.WriteDebugMessage("Year drop down displayed");
                Business_Source.Year_value();
                Logger.WriteDebugMessage("Year is selected as 2019");

                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Report generated");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string report_Name = at.GetCellData(Worksheetname, 2, 1);
                    if (report_Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    string Hotel = at.GetCellData(Worksheetname, 2, 3);
                    if (Hotel.Contains(reportdate_Hotel))
                        Logger.WriteDebugMessage(reportdate_Hotel + " matched with Hotel name and Stay date ");
                    else
                        Assert.Fail("Hotel name and Stay date not matched");

                    string Rooms = at.GetCellData(Worksheetname, 18, 1642);
                    if (Rooms.Contains(Total_Rooms))
                        Logger.WriteDebugMessage(Total_Rooms + " matched with Total Rooms ");
                    else
                        scenario1 = false;
                }
                //Report with Portfolio level and 2 filters
                Helper.ReloadPage();
                Helper.AddDelay(6000);
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Business_Source.Click_Annual_Agent_Analysis_by_Month();
                Logger.WriteDebugMessage("Annual Agent Analysis by Month report selected");
                Navigation.BusinessSource();
                Helper.AddDelay(1000);
                Logger.WriteDebugMessage("Annual Agent Analysis by Month report gets displayed");

                Helper.EnterFrameByxPath(PageObject_BusinessSource.iframe_Annual_Agent_Analysis_by_Month());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Business_Unit,Currency);
                Business_Source.Year_DDL();
                Logger.WriteDebugMessage("Year drop down displayed");
                Business_Source.Year_value();
                Logger.WriteDebugMessage("Year is selected as 2019");
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage("Direct is select for market");
                ReportParameter.Parameter_market();

                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s): ; Market Segment: Direct; Brand.com; Call Center / In House Reservation");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Portfolioname = hh.GetCellData(Worksheetname, 2, 3);
                    if (Portfolioname.Contains(Report_PortfolioName_date))
                        Logger.WriteDebugMessage(Report_PortfolioName_date + " matched with Hotel name and Stay date ");
                    else
                        Assert.Fail("Hotel name and Stay date not matched");

                    string ADR = hh.GetCellData(Worksheetname, 18, 1080);
                    if (ADR.Contains(Total_ADR))
                        Logger.WriteDebugMessage(Total_ADR + " matched with Hotel name and Stay date ");
                    else
                        scenario2 = false;

                    //Delete downloded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                if (scenario1 == false) Assert.Fail("Report with one filter is fail");
                else Logger.WriteDebugMessage("Scenario 1 : Report with one filter is Pass");

                if (scenario2 == false) Assert.Fail("Report with  multiple filter is fail");
                else Logger.WriteDebugMessage("Scenario 2 : Report with multiple filter is Pass");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Year", Year);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportdate_Hotel", reportdate_Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Rooms", Total_Rooms);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio", Portfolio);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter", Parameter);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter_Value", parameter_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Report_PortfolioName_date", Report_PortfolioName_date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_ADR", Total_ADR, true);
            }
            Logger.WriteDebugMessage("Test case passed successfully");
        }

        //Validate the Company Analysis report
        public static void TC_252722()
        {
            if (TestCaseId == Utility.Constants.TC_252722)
            {
                //Pre-Requisite
                string password, environment, username, client, Currency, Portfolio_value, Parameter2, Parameter1, Business_Unit, Parameter1_Value, Parameter2_Value, hotel, nbr_Resv, hotel_Name_Date, PriorYear_Revenue, FilePath, FullPath, Filename, Worksheetname = "Jun-20", reportName, Portfoliodate_Hotel, startDate, enddate;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1");
                Parameter1_Value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1_Value");
                Parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2");
                Parameter2_Value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2_Value");
                Portfolio_value = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfoliodate_Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "Portfoliodate_Hotel");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                nbr_Resv = TestData.ExcelData.TestDataReader.ReadData(1, "nbr_Resv");
                hotel_Name_Date = TestData.ExcelData.TestDataReader.ReadData(1, "hotel_Name_Date");
                PriorYear_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "PriorYear_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Company Analysis report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Click_Automation();
                Logger.WriteDebugMessage("user landed on the UAT RevIntel client selection page");
                Navigation.Click_ClientName(client);
                Logger.WriteDebugMessage(client + " selected");

                //Select the menu Business Source->Company Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Business_Source.Click_Company_Analysis();
                Logger.WriteDebugMessage("Company Analysis report selected");
                Navigation.BusinessSource();
                Helper.AddDelay(1000);
                Logger.WriteDebugMessage("Company Analysis report gets displayed");

                Helper.EnterFrameByxPath(PageObject_BusinessSource.iframe_Company_Analysis());

                //Required filed validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message is displayed");

                //Report with required field only
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string report_Name = at.GetCellData(Worksheetname, 1, 1);
                    if (report_Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;
                }
                //With 1 filter at portfolio level and validate report header with report data
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Business_Source.Click_Company_Analysis();
                Logger.WriteDebugMessage("Company Analysis report selected");
                Navigation.BusinessSource();
                Helper.AddDelay(1000);
                Logger.WriteDebugMessage("Company Analysis report gets displayed");

                Helper.EnterFrameByxPath(PageObject_BusinessSource.iframe_Company_Analysis());

                //Select parameter and generate report
                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.kerner_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG got selected from hotel/Portfolio dropdown ");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage("Room is selected as Room Product");

                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s):");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Room Product: Room; Arabian Court Deluxe Rooms;");
                Logger.WriteDebugMessage("Filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader aa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Portfoliodate = aa.GetCellData(Worksheetname, 1, 2);
                    if (Portfoliodate.Contains(Portfoliodate_Hotel))
                        Logger.WriteDebugMessage(Portfoliodate_Hotel + " matched with portfolio name and Stay date ");
                    else
                        Assert.Fail("portfolio name and Stay date not matched");

                    TestData.ExcelData.ExcelDataReader ee = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string nbrResv = ee.GetCellData(Worksheetname, 11, 334);
                    if (nbrResv.Contains(nbr_Resv))
                        Logger.WriteDebugMessage(nbr_Resv + " matched with Nbr Resv value under Prior year section");
                    else
                        scenario2 = false;
                }

                //With 2 filter at Hotel level and validate report header with report data
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Business_Source.Click_Company_Analysis();
                Logger.WriteDebugMessage("Company Analysis report selected");
                Navigation.BusinessSource();
                Logger.WriteDebugMessage("Company Analysis report gets displayed");

                Helper.EnterFrameByxPath(PageObject_BusinessSource.iframe_Company_Analysis());

                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage("Room is selected as Room Product");
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market Drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage("Africa is selected for Source Market");
                ReportParameter.Select_SourceMarket_DDL();
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s):");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; Central Africa; Sao Tome and Principe;");
                Logger.WriteDebugMessage("Filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader nn = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string hotel_Name = nn.GetCellData(Worksheetname, 1,2);
                    if (hotel_Name.Contains(hotel_Name_Date))
                        Logger.WriteDebugMessage(hotel_Name_Date + " matched with Hotel name and Stay date ");
                    else
                        Assert.Fail("Hotel name and Stay date not matched");

                    TestData.ExcelData.ExcelDataReader mm = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Revenue = mm.GetCellData(Worksheetname, 15, 18);
                    if (Revenue.Contains(PriorYear_Revenue))
                        Logger.WriteDebugMessage(PriorYear_Revenue + " matched with Report under Difference section");
                    else
                        scenario3 = false;

                    //Delete downloded file
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_value", Portfolio_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_Parameter1", Parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario1_Parameter1_Value", Parameter1_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfoliodate_Hotel", Portfoliodate_Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_nbr_Resv", nbr_Resv);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_Parameter1", Parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_Parameter1_Value", Parameter1_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_Parameter2", Parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Scenario2_Parameter2_Value", Parameter2_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel_Name_Date", hotel_Name_Date);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PriorYear_Revenue", PriorYear_Revenue, true);

            }
            Logger.WriteDebugMessage("Test case passed successfully");
        }

        //Validate the Annual Company Analysis by Month report
        public static void TC_252723()
        {
            if (TestCaseId == Utility.Constants.TC_252723)
            {
                //Pre-Requisite
                string password, username, environment, client, Portfolio, Parameter2, Currency, Parameter2_value, Parameter1, Parameter1_value, Business_Unit, RoomProduct_value, total_ADR, hotel, Portfolio_report_heading, Revenue, FilePath, FullPath, Filename, Worksheetname = "Annual Company Analysis by Mont", reportName, reportdate_Hotel, booking_startDate, booking_enddate;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Portfolio = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                Parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1");
                Parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1_value");
                Parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2");
                Parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2_value");
                RoomProduct_value = TestData.ExcelData.TestDataReader.ReadData(1, "RoomProduct_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportdate_Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "reportdate_Hotel");
                booking_startDate = TestData.ExcelData.TestDataReader.ReadData(1, "booking_startDate");
                booking_enddate = TestData.ExcelData.TestDataReader.ReadData(1, "booking_enddate");
                total_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "total_ADR");
                Portfolio_report_heading = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_report_heading");
                Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Annual Company Analysis by Month report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Click_Automation();
                Logger.WriteDebugMessage("user landed on the UAT RevIntel client selection page");
                Navigation.Click_ClientName(client);
                Logger.WriteDebugMessage(client + " selected");

                //Select the menu Business Source->Annual Company Analysis by Month report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Business_Source.Click_Annual_Company_Analysis_by_Month();
                Logger.WriteDebugMessage("Annual Company Analysis report selected");
                Navigation.BusinessSource();
                Logger.WriteDebugMessage("Annual Company Analysis report gets displayed");

                Helper.EnterFrameByxPath(PageObject_BusinessSource.iframe_Annual_Company_Analysis_by_Month());

                //Select hotel from drop down
                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");

                //Add filter Booking start date and Booking end date at hotel level
                Helper.ScrollToText("Booking Date");
                Business_Source.BookingStartDate(booking_startDate);
                Logger.WriteDebugMessage("Enter booking start date as = " + booking_startDate);
                Business_Source.BookingEndDate(booking_enddate);
                Logger.WriteDebugMessage("Enter booking end date as = " + booking_enddate);
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product Drop down displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage("Room product selected");
                ReportParameter.Select_RoomProduct_DDL();

                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s): Booking Date: 6/1/2020 - 6/30/2020 ; Room Product: Room; Deluxe;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string report_Name = at.GetCellData(Worksheetname, 1, 1);
                    if (report_Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    string Hotel = at.GetCellData(Worksheetname, 1, 3);
                    if (Hotel.Contains(reportdate_Hotel))
                        Logger.WriteDebugMessage(reportdate_Hotel + " matched with Hotel name and Stay date ");
                    else
                        Assert.Fail("Hotel name and Stay date not matched");

                    string ADR = at.GetCellData(Worksheetname, 17, 17);
                    if (ADR.Contains(total_ADR))
                        Logger.WriteDebugMessage(total_ADR + " matched with total_ADR ");
                    else
                        Assert.Fail("total_ADR not matched");
                }

                Helper.ReloadPage();
                //Add filter Booking start date-Booking end date and memberships at portfolio level
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Business_Source.Click_Annual_Company_Analysis_by_Month();
                Logger.WriteDebugMessage("Annual Company Analysis report selected");
                Navigation.BusinessSource();
                Logger.WriteDebugMessage("Annual Company Analysis report gets displayed");

                Helper.EnterFrameByxPath(PageObject_BusinessSource.iframe_Annual_Company_Analysis_by_Month());

                //Select Portfolio radio button
                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                
                Business_Source.kerner_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG got selected from hotel/Portfolio dropdown ");
                ReportParameter.Select_Currency_Business_value(Business_Unit, Currency);

                //Add filter Booking start date and Booking end date at hotel level
                Helper.ScrollToText("Booking Date");
                Business_Source.BookingStartDate(booking_startDate);
                Business_Source.BookingEndDate(booking_enddate);
                Logger.WriteDebugMessage("Enter booking start date as = " + booking_startDate);
                Logger.WriteDebugMessage("Enter booking end date as = " + booking_enddate);
                ReportParameter.Paremeter_Memberships();
                Logger.WriteDebugMessage("Memberships Drop down displayed");
                ReportParameter.Paremeter_Memberships_value();
                Logger.WriteDebugMessage("All is selected for Memberships");
                ReportParameter.Paremeter_Memberships();

                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s): Booking Date: 6/1/2020 - 6/30/2020");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader aa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name = aa.GetCellData(Worksheetname, 1, 1);
                    if (Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string report_heading = ll.GetCellData(Worksheetname, 1, 3);
                    if (report_heading.Contains(Portfolio_report_heading))
                        Logger.WriteDebugMessage(Portfolio_report_heading + " matched with Hotel name and Stay date ");
                    else
                        Assert.Fail("Hotel name and Stay date not matched");

                    TestData.ExcelData.ExcelDataReader nn = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Rev = nn.GetCellData(Worksheetname, 17, 19);
                    if (Rev.Contains(Revenue))
                        Logger.WriteDebugMessage(Revenue + " matched with total_ADR ");
                    else
                        Assert.Fail("total_ADR not matched");


                    //Delete downloded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", "Hotel");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", "AUD");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter1", "Room Product");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter1_value", "Room");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_booking_enddate", booking_enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_booking_startDate", booking_startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportdate_Hotel", reportdate_Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_total_ADR", total_ADR);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter2", "Memberships");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter2_value", "ALL");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_report_heading", Portfolio_report_heading);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Revenue", Revenue, true);


            }
            Logger.WriteDebugMessage("Test case passed successfully");
        }

        //Validate the Company Summary report
        public static void TC_252724()
        {
            if (TestCaseId == Utility.Constants.TC_252724)
            {
                //Pre-Requisite
                string password, environment, username, client, Room_Revenue, Hoteldate_name, other_Revenue, FilePath, FullPath, Filename, Worksheetname = "Jun-20", reportName, Portfoliodate_name, startDate, enddate;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfoliodate_name = TestData.ExcelData.TestDataReader.ReadData(1, "Portfoliodate_name");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                Room_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Room_Revenue");
                Hoteldate_name = TestData.ExcelData.TestDataReader.ReadData(1, "Hoteldate_name");
                other_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "other_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Company Summary report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Click_Automation();
                Logger.WriteDebugMessage("user landed on the UAT RevIntel client selection page");
                Navigation.Click_ClientName(client);
                Logger.WriteDebugMessage(client + " selected");

                //Select the menu Business Source->Company Summary report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Business_Source.Click_Company_Summary();
                Logger.WriteDebugMessage("Company Summary report selected");
                Navigation.BusinessSource();
                Helper.AddDelay(1000);
                Logger.WriteDebugMessage("Company Summary report gets displayed");

                Helper.EnterFrameByxPath(PageObject_BusinessSource.iframe_Company_Summary());

                //Required filed validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Validation message displayed");

                //Report with only required fields
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string report_Name = at.GetCellData(Worksheetname, 1, 1);
                    if (report_Name.Equals(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;
                }

                //Report with Portfolio level and with 1 filter
                Helper.ReloadPage();

                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Business_Source.Click_Company_Summary();
                Logger.WriteDebugMessage("Company Summary report selected");
                Navigation.BusinessSource();
                Helper.AddDelay(1000);
                Logger.WriteDebugMessage("Company Summary report gets displayed");

                Helper.EnterFrameByxPath(PageObject_BusinessSource.iframe_Company_Summary());
                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Drop down displayed for channel ");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage("Hotel Direct is selected as channel");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; Front Office Direct; Government;");
                Logger.WriteDebugMessage("Applied filter displayed at footer of the report");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Portfolio = tt.GetCellData(Worksheetname, 1, 2);
                    if (Portfolio.Contains(Portfoliodate_name))
                        Logger.WriteDebugMessage(Portfoliodate_name + " matched with Potfolio name and Stay date ");
                    else
                        Assert.Fail("Portfolio name and Stay date not matched");

                    string Revenue = tt.GetCellData(Worksheetname, 9, 40);
                    if (Revenue.Contains(Room_Revenue))
                        Logger.WriteDebugMessage(Room_Revenue + " matched with Report under Current year section ");
                    else
                        scenario2 = false;
                }

                //Report with Hotel level and with 2 filter 
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Business_Source.Click_Company_Summary();
                Logger.WriteDebugMessage("Company Summary report selected");
                Navigation.BusinessSource();
                Helper.AddDelay(1000);
                Logger.WriteDebugMessage("Company Summary report gets displayed");

                Helper.EnterFrameByxPath(PageObject_BusinessSource.iframe_Company_Summary());
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Drop down displayed for channel ");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage("Hotel Direct is selected as channel");
                ReportParameter.Parameter_Channel();
                ReportParameter.Paremeter_Memberships();
                Logger.WriteDebugMessage("Drop down displayed for Memberships");
                ReportParameter.Paremeter_Memberships_value();
                Logger.WriteDebugMessage("All is selected for memberships");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; Front Office Direct; ");
                Logger.WriteDebugMessage("Applied filter displayed at footer of the report");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader nn = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Hotel = nn.GetCellData(Worksheetname, 1, 2);
                    if (Hotel.Contains(Hoteldate_name))
                        Logger.WriteDebugMessage(Hoteldate_name + " matched with Potfolio name and Stay date ");
                    else
                        Assert.Fail("Portfolio name and Stay date not matched");

                    string other_Rev = nn.GetCellData(Worksheetname, 18, 24);
                    if (other_Rev.Contains(other_Revenue))
                        Logger.WriteDebugMessage(other_Revenue + " matched with Report under Current year section ");
                    else
                        scenario3 = false;

                    //Delete downloded file
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", "Hotel");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", "AUD");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel", "Atlantis,The Palm");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1", "Channel");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1_value", "Hotel Direct");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfoliodate_name", Portfoliodate_name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Room_Revenue", Room_Revenue);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2", "Memberships");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2_value", "All");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hoteldate_name", Hoteldate_name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_other_Revenue", other_Revenue, true);

            }
            Logger.WriteDebugMessage("Test case passed successfully");
        }

        //Validate the Parent Company Analysis report
        public static void TC_252725()
        {
            if (TestCaseId == Utility.Constants.TC_252725)
            {
                //Pre-Requisite
                string password, username, environment, client, hotel, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Parent Company Analysis", Rooms_Sold, reportName, reportdate_Hotel, reportName_Portfolio, Portfolio_NameDate, reportdate, Nbr_Resv;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportdate_Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "reportdate_Hotel");
                Rooms_Sold = TestData.ExcelData.TestDataReader.ReadData(1, "Rooms_Sold");
                reportName_Portfolio = TestData.ExcelData.TestDataReader.ReadData(1, "reportName_Portfolio");
                Portfolio_NameDate = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_NameDate");
                reportdate = TestData.ExcelData.TestDataReader.ReadData(1, "reportdate");
                Nbr_Resv = TestData.ExcelData.TestDataReader.ReadData(1, "Nbr_Resv");

                Logger.WriteInfoMessage("Test Case : Validate the Parent Company Analysis report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Parent_Company_Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Logger.WriteDebugMessage("Business source Dropdown displayed");
                Navigation.Parent_Company_Analysis();
                Navigation.BusinessSource();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("User landed on Parent Company Analysis report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Parent_Company_Analysis());

                //Required field validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("validation message displayed for required field");

                //With required field  at hotel level and verify the report header  and a data validation
                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Enter_startDate_EndDate(startDate, enddate);
                if (client == "Kerzner")
                {
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Dropdown displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader eat = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string report_Name = eat.GetCellData(Worksheetname, 1, 1);
                    if (report_Name.Contains(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader aa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Room = aa.GetCellData(Worksheetname, 17, 257);
                    if (Room.Contains(Rooms_Sold))
                        Logger.WriteDebugMessage(Rooms_Sold + " matched with Report ");
                    else
                        scenario1 = false;

                    //With required field +1 additional parameter  at Portfolio level and verify the header and footer
                    ReportParameter.Parent_Company_Analysis_Close();
                }
                //Navigate to Parent_Company_Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Logger.WriteDebugMessage("Business source Dropdown displayed");
                Navigation.Parent_Company_Analysis();
                Navigation.BusinessSource();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("User landed on Parent Company Analysis report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Parent_Company_Analysis());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Paremeter_Memberships();
                Logger.WriteDebugMessage("Memberships dropdown displayed");
                ReportParameter.Paremeter_Memberships();
                ReportParameter.Paremeter_Memberships_value();
                Logger.WriteDebugMessage("All is selected as Memberships value");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Verify Data in export document and in front end 
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_Portfolio = tt.GetCellData(Worksheetname, 1, 1);
                    if (Name_Portfolio.Equals(reportName_Portfolio))
                        Logger.WriteDebugMessage(reportName_Portfolio + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    string Hotel = tt.GetCellData(Worksheetname, 1, 2);
                    if (Hotel.Contains(Portfolio_NameDate))
                        Logger.WriteDebugMessage(Portfolio_NameDate + " matched with Portfolio name and Stay date ");
                    else
                        scenario2 = false;

                    ReportParameter.Parent_Company_Analysis_Close();
                }
                //With required field + 2 additional parameter  at hotel  level and verify export to excel and pdf is successful

                //Navigate to Parent_Company_Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Logger.WriteDebugMessage("Business source Dropdown displayed");
                Navigation.Parent_Company_Analysis();
                Navigation.BusinessSource();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("User landed on Parent Company Analysis report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Parent_Company_Analysis());

                //With required field  at hotel level and verify the report header  and a data validation
                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Channel dropdown displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Hotel Direct is selected as channel parameter");
                ReportParameter.Paremeter_Memberships();
                Logger.WriteDebugMessage("Membership dropdown displayed");
                ReportParameter.Paremeter_Memberships_value();
                Logger.WriteDebugMessage("ALL is selected as Membership parameter");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; Front Office Direct; Government;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Dropdown displayed");
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader ea = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name = ea.GetCellData(Worksheetname, 1, 1);
                    if (Name.Contains(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader ss = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string dateHotel = ss.GetCellData(Worksheetname, 1, 2);
                    if (dateHotel.Contains(reportdate_Hotel))
                        Logger.WriteDebugMessage(reportdate_Hotel + " matched with Report");
                    else
                        Assert.Fail("Report not matched");

                    TestData.ExcelData.ExcelDataReader rt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Resv = rt.GetCellData(Worksheetname, 11, 166);
                    if (Resv.Contains(Nbr_Resv))
                        Logger.WriteDebugMessage(Nbr_Resv + " matched with Nbr_Resv under Prior section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", "Hotel");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", "AUD");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Rooms_Sold", Rooms_Sold);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter1", "Memberships");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter1_value", "ALL");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName_Portfolio", reportName_Portfolio);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_NameDate", Portfolio_NameDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter2", "channel");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter2_value", "HotelDirect");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportdate_Hotel", reportdate_Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Nbr_Resv", Nbr_Resv, true);


                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        //Validate the Parent Travel Agent Analysis report
        public static void TC_252726()
        {
            if (TestCaseId == Utility.Constants.TC_252726)
            {
                //Pre-Requisite
                string password, username, environment, client, hotel, startDate, enddate, Portfolio, Currency, Business_Unit, Parameter1, Parameter1_Value, Parameter2_Value, Parameter2, FilePath, FullPath, Filename, Worksheetname = "Parent Travel Agent Analysis", Rooms_Sold, reportName, reportdate_Hotel, reportName_Portfolio, Portfolio_NameDate, reportdate, priorYear_ADR;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Portfolio = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                Parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1");
                Parameter1_Value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1_Value");
                Parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2");
                Parameter2_Value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2_Value");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportdate_Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "reportdate_Hotel");
                Rooms_Sold = TestData.ExcelData.TestDataReader.ReadData(1, "Rooms_Sold");
                reportName_Portfolio = TestData.ExcelData.TestDataReader.ReadData(1, "reportName_Portfolio");
                Portfolio_NameDate = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_NameDate");
                reportdate = TestData.ExcelData.TestDataReader.ReadData(1, "reportdate");
                priorYear_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "priorYear_ADR");

                Logger.WriteInfoMessage("Test Case : Validate the Parent Travel Agent Analysis report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Parent_Company_Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Logger.WriteDebugMessage("Business source Dropdown displayed");
                Navigation.Parent_Travel_Agent_Analysis();
                Navigation.BusinessSource();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("User landed on Parent Travel Agent Analysis report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Parent_Travel_Agent_Analysis());

                //Required field validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("validation message displayed for required field");

                //With required field  at hotel level and verify the report header  and a data validation
                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Enter_startDate_EndDate(startDate, enddate);
                ReportParameter.Export_Menu();
                Logger.WriteDebugMessage("Dropdown displayed");
                ReportParameter.Excel();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("Report exported in excel format");
                Helper.ExitFrame();
                if (client == "Kerzner")
                {
                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader eat = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string report_Name = eat.GetCellData(Worksheetname, 1, 1);
                    if (report_Name.Contains(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader de = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string DateName = de.GetCellData(Worksheetname, 1, 2);
                    if (DateName.Contains(reportdate))
                        Logger.WriteDebugMessage(reportdate + " matched with Report name ");
                    else
                        scenario1 = false;
                }
                //With required field +1 additional parameter  at Portfolio level and verify the header and footer
                ReportParameter.Parent_Travel_Agent_Analysis_Close();
                //Navigate to Parent_Company_Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Logger.WriteDebugMessage("Business source Dropdown displayed");
                Navigation.Parent_Travel_Agent_Analysis();
                Navigation.BusinessSource();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("User landed on Parent Travel Agent Analysis report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Parent_Travel_Agent_Analysis());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product dropdown displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage("Room is selected as Room product");
                ReportParameter.Select_RoomProduct_DDL();
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Room Product: Room; Arabian Court Deluxe Rooms; ");
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

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_Portfolio = tt.GetCellData(Worksheetname, 1, 1);
                    if (Name_Portfolio.Equals(reportName_Portfolio))
                        Logger.WriteDebugMessage(reportName_Portfolio + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    string Hotel = tt.GetCellData(Worksheetname, 1, 2);
                    if (Hotel.Contains(Portfolio_NameDate))
                        Logger.WriteDebugMessage(Portfolio_NameDate + " matched with Portfolio name and Stay date ");
                    else
                        scenario2 = false;

                    ReportParameter.Parent_Travel_Agent_Analysis_Close();
                }
                //With required field + 2 additional parameter  at hotel  level and verify export to excel and pdf is successful
                //Navigate to Parent_Company_Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Navigation.Parent_Travel_Agent_Analysis();
                Navigation.BusinessSource();
                Logger.WriteDebugMessage("User landed on Parent Travel Agent Analysis report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Parent_Travel_Agent_Analysis());

                //With required field  at hotel level and verify the report header  and a data validation
                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("channel dropdown displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage("Hotel Direct selected for channel parameter");
                ReportParameter.Parameter_Channel();
                ReportParameter.Select_RoomProduct_DDL();
                Logger.WriteDebugMessage("Room Product dropdown displayed");
                ReportParameter.Select_RoomProduct_value();
                Logger.WriteDebugMessage("Room is selected as Room product");
                ReportParameter.Select_RoomProduct_DDL();
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; ");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Dropdown displayed");
                    ReportParameter.Excel();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader ea = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name = ea.GetCellData(Worksheetname, 1, 1);
                    if (Name.Contains(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader ss = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string dateHotel = ss.GetCellData(Worksheetname, 1, 2);
                    if (dateHotel.Contains(reportdate_Hotel))
                        Logger.WriteDebugMessage(reportdate_Hotel + " matched with Report");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader sa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string priorYearADR = sa.GetCellData(Worksheetname, 14, 3323);
                    if (priorYearADR.Contains(priorYear_ADR))
                        Logger.WriteDebugMessage(priorYear_ADR + " matched with Report");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportdate", reportdate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio", Portfolio);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter1", Parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter1_Value", Parameter1_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName_Portfolio", reportName_Portfolio);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_NameDate", Portfolio_NameDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter2", Parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter2_Value", Parameter2_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportdate_Hotel", reportdate_Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_priorYear_ADR", priorYear_ADR, true);

                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        //Validate the Company Period Summary report
        public static void TC_252728()
        {
            if (TestCaseId == Utility.Constants.TC_252728)
            {
                //Pre-Requisite
                string password, environment, username, client, hotel, Currency, Business_Unit, Parameter1, Parameter1_Value, Parameter2, Parameter2_Value, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Company Period Summary", Rooms_Sold, reportName, reportdate_Hotel, reportName_Portfolio, Portfolio_NameDate, reportdate, currentYear_FoodRev;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                Parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1");
                Parameter1_Value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1_Value");
                Parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2");
                Parameter2_Value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2_Value");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportdate_Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "reportdate_Hotel");
                Rooms_Sold = TestData.ExcelData.TestDataReader.ReadData(1, "Rooms_Sold");
                reportName_Portfolio = TestData.ExcelData.TestDataReader.ReadData(1, "reportName_Portfolio");
                Portfolio_NameDate = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_NameDate");
                reportdate = TestData.ExcelData.TestDataReader.ReadData(1, "reportdate");
                currentYear_FoodRev = TestData.ExcelData.TestDataReader.ReadData(1, "currentYear_FoodRev");

                Logger.WriteInfoMessage("Test Case : Validate the Company Period Summary report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Parent_Company_Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Logger.WriteDebugMessage("Business source Dropdown displayed");
                Navigation.Company_Period_Summary();
                Navigation.BusinessSource();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("User landed on Company Period Summary report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Company_Period_Summary());

                //Required field validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("validation message displayed for required field");

                //With required field  at hotel level and verify the report header  and a data validation
                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Enter_startDate_EndDate(startDate, enddate);
                if (client == "Kerzner")
                {
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Dropdown displayed");
                    ReportParameter.Excel();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader eat = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string report_Name = eat.GetCellData(Worksheetname, 1, 1);
                    if (report_Name.Contains(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader de = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string DateName = de.GetCellData(Worksheetname, 1, 2);
                    if (DateName.Contains(reportdate))
                        Logger.WriteDebugMessage(reportdate + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader ee = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string RoomsSold = ee.GetCellData(Worksheetname, 6, 49);
                    if (RoomsSold.Contains(Rooms_Sold))
                        Logger.WriteDebugMessage(Rooms_Sold + " matched with Rooms Sold in current year section");
                    else
                        scenario1 = false;

                    //With required field +1 additional parameter  at Portfolio level and verify the header and footer
                    ReportParameter.Company_Period_Summary_Close();
                }
                //Navigate to Parent_Company_Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Logger.WriteDebugMessage("Business source Dropdown displayed");
                Navigation.Company_Period_Summary();
                Navigation.BusinessSource();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("User landed on Company Period Summary report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Company_Period_Summary());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source Market dropdown displayed");
                ReportParameter.Select_SourceMarket_value();
                Logger.WriteDebugMessage("Africa is Selected as Source Market");
                ReportParameter.Select_SourceMarket_DDL();
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(40000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; Central Africa; ");
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

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_Portfolio = tt.GetCellData(Worksheetname, 1, 1);
                    if (Name_Portfolio.Equals(reportName_Portfolio))
                        Logger.WriteDebugMessage(reportName_Portfolio + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    string Hotel = tt.GetCellData(Worksheetname, 1, 2);
                    if (Hotel.Contains(Portfolio_NameDate))
                        Logger.WriteDebugMessage(Portfolio_NameDate + " matched with Portfolio name and Stay date ");
                    else
                        scenario2 = false;

                    ReportParameter.Company_Period_Summary_Close();
                }
                //With required field + 2 additional parameter  at hotel  level and verify export to excel and pdf is successful
                //Navigate to Parent_Company_Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Logger.WriteDebugMessage("Business source Dropdown displayed");
                Navigation.Company_Period_Summary();
                Navigation.BusinessSource();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("User landed on Company Period Summary report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Company_Period_Summary());

                //With required field  at hotel level and verify the report header  and a data validation
                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Source market drop down displayed");
                ReportParameter.Select_SourceMarket_value();
                ReportParameter.Select_SourceMarket_DDL();
                Logger.WriteDebugMessage("Africa is selecetd as source market");
                ReportParameter.Paremeter_Memberships();
                Logger.WriteDebugMessage("Memberships drop down displayed");
                ReportParameter.Paremeter_Memberships();
                ReportParameter.Paremeter_Memberships_value();
                Logger.WriteDebugMessage("All is selected as memberships");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Source Market: Africa; Central Africa;");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                if (client == "Kerzner")
                {
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Dropdown displayed");
                    ReportParameter.Excel();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader ea = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name = ea.GetCellData(Worksheetname, 1, 1);
                    if (Name.Contains(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader ss = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string dateHotel = ss.GetCellData(Worksheetname, 1, 2);
                    if (dateHotel.Contains(reportdate_Hotel))
                        Logger.WriteDebugMessage(reportdate_Hotel + " matched with Report");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader sa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string FoodRev = sa.GetCellData(Worksheetname, 10, 18);
                    if (FoodRev.Contains(currentYear_FoodRev))
                        Logger.WriteDebugMessage(currentYear_FoodRev + " matched with Report");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportdate", reportdate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Rooms_Sold", Rooms_Sold);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter1", Parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter1_Value", Parameter1_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName_Portfolio", reportName_Portfolio);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_NameDate", Portfolio_NameDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter2", Parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter2_Value", Parameter2_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportdate_Hotel", reportdate_Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_currentYear_FoodRev", currentYear_FoodRev, true);

                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        //Validate the Agent Period Summary report
        public static void TC_252727()
        {
            if (TestCaseId == Utility.Constants.TC_252727)
            {
                //Pre-Requisite
                string password, environment, username, client, hotel, Portfolio, Currency, Business_Unit, Parameter2_Value, Parameter1_Value, Parameter2, Parameter1, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Agent Period Summary", Rooms_Sold, reportName, reportdate_Hotel, reportName_Portfolio, Portfolio_NameDate, reportdate, currentYear_FoodRev, CurrentRoomSold_Portfolio, reportName_Hotel;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                Portfolio = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                Parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1");
                Parameter1_Value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1_Value");
                Parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2");
                Parameter2_Value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2_Value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportdate_Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "reportdate_Hotel");
                Rooms_Sold = TestData.ExcelData.TestDataReader.ReadData(1, "Rooms_Sold");
                reportName_Portfolio = TestData.ExcelData.TestDataReader.ReadData(1, "reportName_Portfolio");
                Portfolio_NameDate = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_NameDate");
                CurrentRoomSold_Portfolio = TestData.ExcelData.TestDataReader.ReadData(1, "CurrentRoomSold_Portfolio");
                reportdate = TestData.ExcelData.TestDataReader.ReadData(1, "reportdate");
                currentYear_FoodRev = TestData.ExcelData.TestDataReader.ReadData(1, "currentYear_FoodRev");
                reportName_Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "reportName_Hotel");

                Logger.WriteInfoMessage("Test Case : Validate the Agent Period Summary report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Parent_Company_Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Logger.WriteDebugMessage("Business source Dropdown displayed");
                Navigation.Agent_Period_Summary();
                Navigation.BusinessSource();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("User landed on Agent Period Summary report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Agent_Period_Summary());

                //Required field validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("validation message displayed for required field");

                if (client == "Kerzner")
                {
                    //With required field  at hotel level and verify the report header  and a data validation
                    ReportParameter.Select_Hotel_DDL();
                    Logger.WriteDebugMessage("List for hotel displayed");
                    ReportParameter.Select_Hotel_value();
                    Logger.WriteDebugMessage(hotel + "selected as hotel");
                    ReportParameter.Enter_startDate_EndDate(startDate, enddate);
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Dropdown displayed");
                    ReportParameter.Excel();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader eat = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string report_Name = eat.GetCellData(Worksheetname, 1, 1);
                    if (report_Name.Contains(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader de = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string DateName = de.GetCellData(Worksheetname, 1, 2);
                    if (DateName.Contains(reportdate))
                        Logger.WriteDebugMessage(reportdate + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader ee = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string RoomsSold = ee.GetCellData(Worksheetname, 4, 297);
                    if (RoomsSold.Contains(Rooms_Sold))
                        Logger.WriteDebugMessage(Rooms_Sold + " matched with Rooms Sold in current year section");
                    else
                        scenario1 = false;

                    //With required field +1 additional parameter  at Portfolio level and verify the header and footer
                    ReportParameter.Agent_Period_Summary_Close();
                }
                //Navigate to Parent_Company_Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Logger.WriteDebugMessage("Business source Dropdown displayed");
                Navigation.Agent_Period_Summary();
                Navigation.BusinessSource();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("User landed on Agent_Period_Summary report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Agent_Period_Summary());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market dropdown displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage("Direct is Selected for Market");
                ReportParameter.Parameter_market();
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s): ; Market Segment: ");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                Logger.WriteDebugMessage("Report generated");
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

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_Portfolio = tt.GetCellData(Worksheetname, 1, 1);
                    if (Name_Portfolio.Equals(reportName_Portfolio))
                        Logger.WriteDebugMessage(reportName_Portfolio + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    string Hotel = tt.GetCellData(Worksheetname, 1, 2);
                    if (Hotel.Contains(Portfolio_NameDate))
                        Logger.WriteDebugMessage(Portfolio_NameDate + " matched with Portfolio name and Stay date ");
                    else
                        Assert.Fail("Hotel name and Stay date not matched");

                    string CurrentRoomSold = tt.GetCellData(Worksheetname, 4, 140);
                    if (CurrentRoomSold.Contains(CurrentRoomSold_Portfolio))
                        Logger.WriteDebugMessage(CurrentRoomSold_Portfolio + " matched with Room Sold under Current year section ");
                    else
                        scenario2 = false;

                    ReportParameter.Agent_Period_Summary_Close();
                }
                //With required field + 2 additional parameter  at hotel  level and verify export to excel and pdf is successful
                //Navigate to Parent_Company_Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Logger.WriteDebugMessage("Business source Dropdown displayed");
                Navigation.Agent_Period_Summary();
                Navigation.BusinessSource();
                Logger.WriteDebugMessage("User landed on Agent_Period_Summary report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Agent_Period_Summary());

                //With required field  at hotel level and verify the report header  and a data validation
                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Enter_StartDate(startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Channel drop down displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Hotel Direct is selecetd for channel");
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("market drop down displayed");
                ReportParameter.Parameter_market_Direct();
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Direct is selected for market");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; ");
                Logger.WriteDebugMessage("Applied filter displayed at footer");
                Logger.WriteDebugMessage("Report generated");
                if (client == "Kerzner")
                {
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Dropdown displayed");
                    ReportParameter.Excel();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader ea = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name = ea.GetCellData(Worksheetname, 1, 1);
                    if (Name.Contains(reportName_Hotel))
                        Logger.WriteDebugMessage(reportName_Hotel + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader ss = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string dateHotel = ss.GetCellData(Worksheetname, 1, 2);
                    if (dateHotel.Contains(reportdate_Hotel))
                        Logger.WriteDebugMessage(reportdate_Hotel + " matched with Report");
                    else
                        Assert.Fail("Report date not matched");

                    TestData.ExcelData.ExcelDataReader sa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string FoodRev = sa.GetCellData(Worksheetname, 8, 130);
                    if (FoodRev.Contains(currentYear_FoodRev))
                        Logger.WriteDebugMessage(currentYear_FoodRev + " matched with Food Rev under current year section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter1", Parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter1_value", Parameter1_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportdate", reportdate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Rooms_Sold", Rooms_Sold);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio", Portfolio);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter2", Parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter2_value", Parameter2_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName_Portfolio", reportName_Portfolio);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_NameDate", Portfolio_NameDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_CurrentRoomSold_Portfolio", CurrentRoomSold_Portfolio);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportdate_Hotel", reportdate_Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_currentYear_FoodRev", currentYear_FoodRev, true);

                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        //Validate the Agent Trend Report
        public static void TC_252729()
        {
            if (TestCaseId == Utility.Constants.TC_252729)
            {
                //Pre-Requisite
                string password, username, environment, Portfolio, Currency, Business_Unit, Parameter1, Parameter1_value, Parameter2, Parameter2_value, Compair_Revenue, client, hotel, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Agent Trend Report", Prior_ADR, reportName, reportdate_Hotel, reportName_Portfolio, Portfolio_NameDate, reportdate, Compare_enddate, Compare_startDate, Column, Column1, Agent_Production;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Portfolio = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                Parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1");
                Parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1_value");
                Parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2");
                Parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2_value");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportdate_Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "reportdate_Hotel");
                Prior_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "Prior_ADR");
                reportName_Portfolio = TestData.ExcelData.TestDataReader.ReadData(1, "reportName_Portfolio");
                Portfolio_NameDate = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_NameDate");
                Agent_Production = TestData.ExcelData.TestDataReader.ReadData(1, "Agent_Production");
                reportdate = TestData.ExcelData.TestDataReader.ReadData(1, "reportdate");
                Compare_startDate = TestData.ExcelData.TestDataReader.ReadData(1, "Compare_startDate");
                Compare_enddate = TestData.ExcelData.TestDataReader.ReadData(1, "Compare_enddate");
                Column1 = TestData.ExcelData.TestDataReader.ReadData(1, "Column1");
                Compair_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Compair_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Agent Trend Report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Parent_Company_Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Logger.WriteDebugMessage("Business source Dropdown displayed");
                Navigation.Agent_Trend_Report();
                Navigation.BusinessSource();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("User landed on Agent Trend Report report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Agent_Trend_Report());

                //Required field validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("validation message displayed for required field");

                //With required field  at hotel level and verify the report header  and a data validation
                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Compare_Start_Date(Compare_startDate);
                Logger.WriteDebugMessage("Enter Compare start date as = " + Compare_startDate);
                ReportParameter.Compare_End_Date(Compare_enddate);
                Logger.WriteDebugMessage("Enter Compare end date as = " + Compare_enddate);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(60000);
                Logger.WriteDebugMessage("Report generated");
                if (client == "Kerzner")
                {
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Dropdown displayed");
                    ReportParameter.Excel();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader eat = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string report_Name = eat.GetCellData(Worksheetname, 2, 2);
                    if (report_Name.Contains(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader de = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string DateName = de.GetCellData(Worksheetname, 2, 3);
                    if (DateName.Contains(reportdate))
                        Logger.WriteDebugMessage(reportdate + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader ee = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string ADR = ee.GetCellData(Worksheetname, 8, 223);
                    if (ADR.Contains(Prior_ADR))
                        Logger.WriteDebugMessage(Prior_ADR + " matched with ADR in  subject section");
                    else
                        scenario1 = false;

                    //With required field +1 additional parameter  at Portfolio level and verify the header and footer
                    ReportParameter.Agent_Trend_Report_Close();
                }

                //Navigate to Parent_Company_Analysis report
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Logger.WriteDebugMessage("Business source Dropdown displayed");
                Navigation.Agent_Trend_Report();
                Navigation.BusinessSource();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("User landed on Agent Trend Report report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Agent_Trend_Report());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Compare_Start_Date(Compare_startDate);
                Logger.WriteDebugMessage("Enter compare start date as = " + Compare_startDate);
                ReportParameter.Compare_End_Date(Compare_enddate);
                Logger.WriteDebugMessage("Enter compare end date as = " + Compare_enddate);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market dropdown displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage("Direct is Selected for Market parameter");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(60000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s): ; Market Segment: Direct; Brand.com; Call Center / In House Reservation");
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

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_Portfolio = tt.GetCellData(Worksheetname, 2, 2);
                    if (Name_Portfolio.Equals(reportName_Portfolio))
                        Logger.WriteDebugMessage(reportName_Portfolio + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    string Hotel = tt.GetCellData(Worksheetname, 2, 3);
                    if (Hotel.Contains(Portfolio_NameDate))
                        Logger.WriteDebugMessage(Portfolio_NameDate + " matched with Portfolio name and Stay date ");
                    else
                        Assert.Fail("Hotel name and Stay date not matched");

                    string Agent_Prod = tt.GetCellData(Worksheetname, 2, 12);
                    if (Agent_Prod.Contains(Agent_Production))
                        Logger.WriteDebugMessage(Agent_Production + " present in Agent Trend Report");
                    else
                        Assert.Fail("Agent Production is missing");

                    string A_Column = tt.GetCellData(Worksheetname, 5, 11);
                    if (A_Column.Contains(Column1))
                        Logger.WriteDebugMessage(Column1 + "Max% column display under subject section");
                    else
                        Assert.Fail("Report not matched");


                    for (int ColumnNumber = 7; ColumnNumber < 10; ColumnNumber++)
                    {
                        Column = TestData.ExcelData.TestDataReader.ReadData(ColumnNumber, "Column");
                        string column_Actual = tt.GetCellData(Worksheetname, ColumnNumber, 11);
                        if (Column.Contains(column_Actual))
                            Logger.WriteDebugMessage(Column + " column display under subject section");
                        else
                            Assert.Fail("Report not matched");
                    }

                    for (int ColumnNumber = 11; ColumnNumber < 15; ColumnNumber++)
                    {
                        Column = TestData.ExcelData.TestDataReader.ReadData(ColumnNumber, "Column");
                        string column_Actual = tt.GetCellData(Worksheetname, ColumnNumber, 11);
                        if (Column.Contains(column_Actual))
                            Logger.WriteDebugMessage(Column + " column display under Compare section");
                        else
                            Assert.Fail("Report not matched");
                    }

                    for (int ColumnNumber = 16; ColumnNumber < 20; ColumnNumber++)
                    {
                        Column = TestData.ExcelData.TestDataReader.ReadData(ColumnNumber, "Column");
                        string column_Actual = tt.GetCellData(Worksheetname, ColumnNumber, 11);
                        if (Column.Contains(column_Actual))
                            Logger.WriteDebugMessage(Column + " column display under change section");
                        else
                            scenario2 = false;
                    }
                }
                /*Report for hotel level with multiple filters*/
                //Navigate to Agent Trend report
                Helper.ReloadPage();
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Logger.WriteDebugMessage("Business source Dropdown displayed");
                Navigation.Agent_Trend_Report();
                Navigation.BusinessSource();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("User landed on Agent Trend Report report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Agent_Trend_Report());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Compare_Start_Date(Compare_startDate);
                Logger.WriteDebugMessage("Enter Compare start date as = " + Compare_startDate);
                ReportParameter.Compare_End_Date(Compare_enddate);
                Logger.WriteDebugMessage("Enter Compare end date as = " + Compare_enddate);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market drop down displyed");
                ReportParameter.Parameter_market_Direct();
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Direct is selected for market parameter");
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("channel drop down displyed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Hotel Direct is selected for channel parameter");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s): ");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; Front Office Direct; ");
                if (client == "Kerzner")
                {
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Dropdown displayed");
                    ReportParameter.Excel();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader at = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name = at.GetCellData(Worksheetname, 2, 2);
                    if (Name.Contains(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader kk = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string StayName = kk.GetCellData(Worksheetname, 2, 3);
                    if (StayName.Contains(reportdate_Hotel))
                        Logger.WriteDebugMessage(reportdate_Hotel + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader ww = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Rev = ww.GetCellData(Worksheetname, 14, 17);
                    if (Rev.Contains(Compair_Revenue))
                        Logger.WriteDebugMessage(Compair_Revenue + " matched with Revenue in  subject section");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportdate", reportdate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Prior_ADR", Prior_ADR);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio", Portfolio);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Compare_startDate", Compare_startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Compare_enddate", Compare_enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter1", Parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter1_value", Parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName_Portfolio", reportName_Portfolio);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_NameDate", Portfolio_NameDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Agent_Production", Agent_Production);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter2", Parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter2_value", Parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportdate_Hotel", reportdate_Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Compair_Revenue", Compair_Revenue, true);


                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        //Validate the Agent Analysis report (one filter)
        public static void TC_256851()
        {
            if (TestCaseId == Utility.Constants.TC_256851)
            {
                //Pre-Requisite
                string password, username, environment, client, hotel, Column, startDate, Business_Unit, Parameter, Parameter_value, Currency, enddate, FilePath, FullPath, Filename, Worksheetname = "Totals", Total_Revenue, reportName, reportdate_Hotel;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                Parameter = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter");
                Parameter_value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter_value");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportdate_Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "reportdate_Hotel");
                Total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Agent Analysis report (one filter)");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Select the menu Business Source->Agent Analysis
                Navigation.Select_AgentAnalysis();

                //Click View Analyisis button without mandatory fields
                Helper.EnterFrameByxPath(PageObject_ReportParameter.IFrame_Agent_Analysis());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();

                //Enter only required fields  and click on View analysis 
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Click on parameter market drop down");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage("Direct parameter for marget got selected");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s): ; Market Segment: Direct; Brand.com; Call Center / In House Reservation");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Click on Export to excel drop down
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");

                    //Export report in excel
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader eat = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string report_Name = eat.GetCellData(Worksheetname,1,1);
                    if (report_Name.Contains(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    for (int ColumnNumber = 7; ColumnNumber < 12; ColumnNumber++)
                    {
                        Column = TestData.ExcelData.TestDataReader.ReadData(ColumnNumber, "Column");
                        string column_Actual = eat.GetCellData(Worksheetname, ColumnNumber, 8);
                        if (Column.Contains(column_Actual))
                            Logger.WriteDebugMessage(Column + " display under current Year section");
                        else
                            Assert.Fail("Report not matched");
                    }

                    for (int ColumnNumber = 12; ColumnNumber < 17; ColumnNumber++)
                    {
                        Column = TestData.ExcelData.TestDataReader.ReadData(ColumnNumber, "Column");
                        string column_Actual = eat.GetCellData(Worksheetname, ColumnNumber, 8);
                        if (Column.Contains(column_Actual))
                            Logger.WriteDebugMessage(Column + " display under Prior Year section");
                        else
                            Assert.Fail("Report not matched");
                    }

                    string Revenue = eat.GetCellData(Worksheetname, 16, 407);
                    if (Revenue.Contains(Total_Revenue))
                        Logger.WriteDebugMessage(Total_Revenue + " matched with Total Revenue");
                    else

                        Assert.Fail("Total Revenue not matched");

                    //Delete downloaded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter", Parameter);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter_value", Parameter_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportdate_Hotel", reportdate_Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Revenue", Total_Revenue, true);

                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        //Validate the Agent Analysis report (multiple filter)
        public static void TC_256852()
        {
            if (TestCaseId == Utility.Constants.TC_256852)
            {
                //Pre-Requisite
                string password, username, environment, client, hotel, Column, Business_Unit, Currency, startDate, enddate, parameter1, parameter1_value, parameter2, parameter2_value, FilePath, FullPath, Filename, Worksheetname = "Jan-20", Total_Revenue, reportName, reportdate_Hotel;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1");
                parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter1_value");
                parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2");
                parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "parameter2_value");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportdate_Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "reportdate_Hotel");
                Total_Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Agent Analysis report (multiple filter)");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Select the menu Business Source->Agent Analysis
                Navigation.Select_AgentAnalysis();

                //Click View Analyisis button without mandatory fields
                Helper.EnterFrameByxPath(PageObject_ReportParameter.IFrame_Agent_Analysis());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);

                //Enter only required fields  and click on View analysis 
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Click on parameter market drop down");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage("Direct parameter for marget got selected");
                ReportParameter.Parameter_market();
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Click on parameter channel drop down");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage("Hotel Direct parameter for channel got selected");
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Selected Parameter displayed");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(50000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; Front Office Direct; ");
                Logger.WriteDebugMessage("Applied filter displayed at footer");

                if (client == "Kerzner")
                {
                    //Click on Export to excel drop down
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Export drop down menu displayed");

                    //Export report in excel
                    ReportParameter.Excel();
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader eat = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string report_Name = eat.GetCellData(Worksheetname, 1, 1);
                    if (report_Name.Contains(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    string Hotel = eat.GetCellData(Worksheetname, 1, 2);
                    if (Hotel.Contains(reportdate_Hotel))
                        Logger.WriteDebugMessage(reportdate_Hotel + " matched with Hotel name and Stay date ");
                    else
                        Assert.Fail("Hotel name and Stay date not matched");

                    for (int ColumnNumber = 7; ColumnNumber < 12; ColumnNumber++)
                    {
                        Column = TestData.ExcelData.TestDataReader.ReadData(ColumnNumber, "Column");
                        string column_Actual = eat.GetCellData(Worksheetname, ColumnNumber, 8);
                        if (Column.Contains(column_Actual))
                            Logger.WriteDebugMessage(Column + " column display under current Year section");
                        else
                            Assert.Fail("Report not matched");
                    }

                    for (int ColumnNumber = 12; ColumnNumber < 17; ColumnNumber++)
                    {
                        Column = TestData.ExcelData.TestDataReader.ReadData(ColumnNumber, "Column");
                        string column_Actual = eat.GetCellData(Worksheetname, ColumnNumber, 8);
                        if (Column.Contains(column_Actual))
                            Logger.WriteDebugMessage(Column + " column display under Prior Year section");
                        else
                            Assert.Fail("Report not matched");
                    }

                    string Revenue = eat.GetCellData(Worksheetname, 16, 654);
                    if (Revenue.Contains(Total_Revenue))
                        Logger.WriteDebugMessage(Total_Revenue + " matched with Total Revenue under Prior Year");
                    else
                        Assert.Fail("Total Revenue not matched");

                    //Delete downloded file
                    TestData.ExcelData.ExcelDataReader.deleteFile(FilePath);
                }
                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1", parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter1_value", parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2", parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_parameter2_value", parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Revenue", Total_Revenue, true);


                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        //Validate the Company Trend Report
        public static void TC_264418()
        {
            if (TestCaseId == Utility.Constants.TC_264418)
            {
                //Pre-Requisite
                string password, environment, username, Portfolio, Currency, Business_Unit, Parameter1, Revenue, Parameter1_value, Parameter2, Parameter2_value, client, hotel, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Company Trend Report", Prior_ADR, reportName, reportdate_Hotel, reportName_Portfolio, Portfolio_NameDate, reportdate, Compare_enddate, Compare_startDate, Column, Column1, Company_Production;
                bool scenario1 = true, scenario2 = true, scenario3 = true;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                hotel = TestData.ExcelData.TestDataReader.ReadData(1, "hotel");
                Portfolio = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio");
                Currency = TestData.ExcelData.TestDataReader.ReadData(1, "Currency");
                Business_Unit = TestData.ExcelData.TestDataReader.ReadData(1, "Business_Unit");
                Parameter1 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1");
                Parameter1_value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter1_value");
                Parameter2 = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2");
                Parameter2_value = TestData.ExcelData.TestDataReader.ReadData(1, "Parameter2_value");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                reportdate_Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "reportdate_Hotel");
                Prior_ADR = TestData.ExcelData.TestDataReader.ReadData(1, "Prior_ADR");
                reportName_Portfolio = TestData.ExcelData.TestDataReader.ReadData(1, "reportName_Portfolio");
                Portfolio_NameDate = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_NameDate");
                Company_Production = TestData.ExcelData.TestDataReader.ReadData(1, "Company_Production");
                reportdate = TestData.ExcelData.TestDataReader.ReadData(1, "reportdate");
                Compare_startDate = TestData.ExcelData.TestDataReader.ReadData(1, "Compare_startDate");
                Compare_enddate = TestData.ExcelData.TestDataReader.ReadData(1, "Compare_enddate");
                Column1 = TestData.ExcelData.TestDataReader.ReadData(1, "Column1");
                Revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Revenue");

                Logger.WriteInfoMessage("Test Case : Validate the Company Trend Report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Parent_Company_Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Logger.WriteDebugMessage("Business source Dropdown displayed");
                Navigation.Company_Trend_Report();
                Navigation.BusinessSource();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("User landed on Company Trend Report report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Company_Trend_Report());

                //Required field validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("validation message displayed for required field");

                //With required field  at hotel level and verify the report header  and a data validation
                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Compare_Start_Date(Compare_startDate);
                Logger.WriteDebugMessage("Enter Compare start date as = " + Compare_startDate);
                ReportParameter.Compare_End_Date(Compare_enddate);
                Logger.WriteDebugMessage("Enter Compare end date as = " + Compare_enddate);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(60000);
                Logger.WriteDebugMessage("Report generated");
                if (client == "Kerzner")
                {
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Dropdown displayed");
                    ReportParameter.Excel();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader eat = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string report_Name = eat.GetCellData(Worksheetname, 2, 2);
                    if (report_Name.Contains(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader de = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string DateName = de.GetCellData(Worksheetname, 2, 3);
                    if (DateName.Contains(reportdate))
                        Logger.WriteDebugMessage(reportdate + " matched with Report name ");
                    else
                        scenario1 = false;

                }
                //With required field +1 additional parameter  at Portfolio level and verify the header and footer
                Helper.ReloadPage();

                //Navigate to Parent_Company_Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Logger.WriteDebugMessage("Business source Dropdown displayed");
                Navigation.Company_Trend_Report();
                Navigation.BusinessSource();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("User landed on Company Trend Report report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Company_Trend_Report());

                ReportParameter.Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_HotelorPortfolio_DDL();
                Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
                Business_Source.Company_Summary_Portfolio();
                Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Compare_Start_Date(Compare_startDate);
                Logger.WriteDebugMessage("Enter compare start date as = " + Compare_startDate);
                ReportParameter.Compare_End_Date(Compare_enddate);
                Logger.WriteDebugMessage("Enter compare end date as = " + Compare_enddate);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market dropdown displayed");
                ReportParameter.Parameter_market_Direct();
                Logger.WriteDebugMessage("Direct is Selected for Market parameter");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(60000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s)");
                Helper.VerifyTextOnPageAndHighLight("Filter(s): ; Market Segment: Direct; Brand.com; Call Center / In House Reservation");
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

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name_Portfolio = tt.GetCellData(Worksheetname, 2, 2);
                    if (Name_Portfolio.Equals(reportName_Portfolio))
                        Logger.WriteDebugMessage(reportName_Portfolio + " matched with Report name ");
                    else
                        Assert.Fail("Report name for Portfolio level not matched");

                    string Hotel = tt.GetCellData(Worksheetname, 2, 3);
                    if (Hotel.Contains(Portfolio_NameDate))
                        Logger.WriteDebugMessage(Portfolio_NameDate + " matched with Portfolio name and Stay date ");
                    else
                        Assert.Fail("Hotel name and Stay date for Portfolio level not matched");

                    string Company_Prod = tt.GetCellData(Worksheetname, 2, 12);
                    if (Company_Prod.Contains(Company_Production))
                        Logger.WriteDebugMessage(Company_Production + " present in company Trend Report");
                    else
                        Assert.Fail("Company_Production is missing");

                    string A_Column = tt.GetCellData(Worksheetname, 5, 11);
                    if (A_Column.Contains(Column1))
                        Logger.WriteDebugMessage(Column1 + "Max% column display under subject section");
                    else
                        Assert.Fail("Report not matched");


                    for (int ColumnNumber = 7; ColumnNumber < 10; ColumnNumber++)
                    {
                        Column = TestData.ExcelData.TestDataReader.ReadData(ColumnNumber, "Column");
                        string column_Actual = tt.GetCellData(Worksheetname, ColumnNumber, 11);
                        if (Column.Contains(column_Actual))
                            Logger.WriteDebugMessage(Column + " column display under subject section");
                        else
                            Assert.Fail("Report not matched");
                    }

                    for (int ColumnNumber = 11; ColumnNumber < 15; ColumnNumber++)
                    {
                        Column = TestData.ExcelData.TestDataReader.ReadData(ColumnNumber, "Column");
                        string column_Actual = tt.GetCellData(Worksheetname, ColumnNumber, 11);
                        if (Column.Contains(column_Actual))
                            Logger.WriteDebugMessage(Column + " column display under Compare section");
                        else
                            Assert.Fail("Report not matched");
                    }

                    for (int ColumnNumber = 16; ColumnNumber < 20; ColumnNumber++)
                    {
                        Column = TestData.ExcelData.TestDataReader.ReadData(ColumnNumber, "Column");
                        string column_Actual = tt.GetCellData(Worksheetname, ColumnNumber, 11);
                        if (Column.Contains(column_Actual))
                            Logger.WriteDebugMessage(Column + " column display under change section");
                        else
                            scenario2 = false;
                    }
                }
                Helper.ReloadPage();
                /*validate report at  hotel levelwith multiple filter*/
                //Navigate to Parent_Company_Analysis report
                Helper.ElementHover(PageObject_Navigation.BusinessSource());
                Logger.WriteDebugMessage("Business source Dropdown displayed");
                Navigation.Company_Trend_Report();
                Navigation.BusinessSource();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("User landed on Company Trend Report report page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Company_Trend_Report());

                ReportParameter.Select_Hotel_DDL();
                Logger.WriteDebugMessage("List for hotel displayed");
                ReportParameter.Select_Hotel_value();
                Logger.WriteDebugMessage(hotel + "selected as hotel");
                ReportParameter.Select_Currency_Business_value(Currency, Business_Unit);
                ReportParameter.Compare_Start_Date(Compare_startDate);
                Logger.WriteDebugMessage("Enter Compare start date as = " + Compare_startDate);
                ReportParameter.Compare_End_Date(Compare_enddate);
                Logger.WriteDebugMessage("Enter Compare end date as = " + Compare_enddate);
                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                ReportParameter.Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Market dropdown displayed");
                ReportParameter.Parameter_market_Direct();
                ReportParameter.Parameter_market();
                Logger.WriteDebugMessage("Direct is Selected for Market parameter");
                ReportParameter.Parameter_Channel();
                Logger.WriteDebugMessage("Channel dropdown displayed");
                ReportParameter.Parameter_channel_Hotel_Direct();
                Logger.WriteDebugMessage("Hotel Direct is Selected for channel parameter");
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(30000);
                Logger.WriteDebugMessage("Report generated");
                Helper.ScrollToText("Filter(s):");
                Helper.VerifyTextOnPageAndHighLight("Filter(s):  ; Channel: Hotel Direct; Executive Office; Front Office Direct;");
                if (client == "Kerzner")
                {
                    ReportParameter.Export_Menu();
                    Logger.WriteDebugMessage("Dropdown displayed");
                    ReportParameter.Excel();
                    Helper.AddDelay(10000);
                    Logger.WriteDebugMessage("Report exported in excel format");
                    Helper.ExitFrame();

                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Hotel_Name = hh.GetCellData(Worksheetname, 2, 2);
                    if (Hotel_Name.Contains(reportName))
                        Logger.WriteDebugMessage(reportName + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader ll = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string StayName = ll.GetCellData(Worksheetname, 2, 3);
                    if (StayName.Contains(reportdate))
                        Logger.WriteDebugMessage(reportdate + " matched with Report name ");
                    else
                        Assert.Fail("Report name not matched");

                    TestData.ExcelData.ExcelDataReader gg = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Compare_Rev = gg.GetCellData(Worksheetname, 14, 14);
                    if (Compare_Rev.Contains(Revenue))
                        Logger.WriteDebugMessage(Revenue + " matched with Revenue under Compare section for Zabeel Palace");
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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportdate", reportdate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Prior_ADR", Prior_ADR);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio", Portfolio);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Compare_startDate", Compare_startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Compare_enddate", Compare_enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter1", Parameter1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter1_value", Parameter1_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter2", Parameter2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Parameter2_value", Parameter2_value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName_Portfolio", reportName_Portfolio);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_NameDate", Portfolio_NameDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Company_Production", Company_Production);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Revenue", Revenue, true);
            }
        }
    }
}
