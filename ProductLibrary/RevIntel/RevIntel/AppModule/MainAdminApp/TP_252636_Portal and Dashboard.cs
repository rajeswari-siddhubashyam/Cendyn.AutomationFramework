using AventStack.ExtentReports.Gherkin.Model;
using BaseUtility.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using RevIntel.AppModule.UI;
using RevIntel.PageObject.UI;
using System;
using System.Runtime.CompilerServices;

namespace RevIntel.AppModule.MainAdminApp
{
    public partial class MainAdminApp : RevIntel.Utility.Setup
    {
        //Validate Portal - Validate Monthly Pickup Report
        public static void TC_252648()
        {
            if (TestCaseId == Utility.Constants.TC_252648)
            {
                //Pre-Requisite
                string password, Hotel, username, environment, Total_Bdgt_Var, Hotel_Stay_dates, Portfolio_Stay_dates, Total_Fcst_Var, Pickupend, Pickupstart,Currency, Business_Unit, client, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Monthly Pickup and Budget Varia", reportName;
                bool scenario1 = true, scenario2 = true;


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
                Pickupstart = TestData.ExcelData.TestDataReader.ReadData(1, "Pickupstart");
                Pickupend = TestData.ExcelData.TestDataReader.ReadData(1, "Pickupend");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");
                Portfolio_Stay_dates = TestData.ExcelData.TestDataReader.ReadData(1, "Portfolio_Stay_dates");
                Total_Fcst_Var = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Fcst_Var");
                Hotel_Stay_dates = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel_Stay_dates");
                Total_Bdgt_Var = TestData.ExcelData.TestDataReader.ReadData(1, "Total_Bdgt_Var");

                Logger.WriteInfoMessage("Test Case : Validate Monthly Pickup Report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Logger.WriteDebugMessage("User Landed on Monthly Pickup Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Monthly_Pickup());

                //At Portfolio Level
                ReportParameter.Dashboard_Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button got selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("21C");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("LCL");
                ReportParameter.Click_Dashboard_Business_DDL();
                VerifyTextOnPageAndHighLight("RESORTS");
                ReportParameter.Monthly_PickupStart(Pickupstart);
                ReportParameter.Monthly_PickupEnd(Pickupend);
                Logger.WriteDebugMessage("Enter Pick start as = " + Pickupstart);
                Logger.WriteDebugMessage("Enter Pick end as = " + Pickupend);
                Helper.ElementClearText(PageObject_ReportParameter.Monthly_Start());
                Helper.ElementClearText(PageObject_ReportParameter.Monthly_End());
                ReportParameter.Pace_Dashboard_StartDate(startDate);
                ReportParameter.Pace_Dashboard_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Pace_Dashboard_Update_Button();
                AddDelay(20000);
                ReportParameter.Click_Dashboard_Excel_Icon();
                AddDelay(20000);
                if (client == "Kerzner")
                {
                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.Dashboard_VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.Dashboard_GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Name = tt.GetCellData(Worksheetname, 1, 1);
                    if (Name.Equals(reportName))
                        Logger.WriteInfoMessage(reportName + " matched with Report name ");
                    else
                        scenario1 = false;

                    TestData.ExcelData.ExcelDataReader FF = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Stay_dates = FF.GetCellData(Worksheetname, 2, 3);
                    if (Stay_dates.Equals(Portfolio_Stay_dates))
                        Logger.WriteInfoMessage(Portfolio_Stay_dates + " matched with Report Portfolio and stay dates");
                    else
                        Assert.Fail("Portfolio stay dates not matched");

                    TestData.ExcelData.ExcelDataReader aa = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Fcst_Var = aa.GetCellData(Worksheetname, 9, 21);
                    if (Fcst_Var.Equals(Total_Fcst_Var))
                        Logger.WriteInfoMessage(Total_Fcst_Var + " matched with Report Total fscr var under Rooms sections ");
                    else
                        Assert.Fail("Total fscr var under Rooms sections not matched");
                }
                //At Hotel Level
                ReportParameter.Dashboard_Hotel_RadioButton();
                Logger.WriteDebugMessage("Hotel radio button got selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("O&O Cape Town");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("LCL");
                ReportParameter.Click_Dashboard_Business_DDL();
                VerifyTextOnPageAndHighLight("RESORTS");
                ReportParameter.Monthly_PickupStart(Pickupstart);
                ReportParameter.Monthly_PickupEnd(Pickupend);
                Logger.WriteDebugMessage("Enter Pick start as = " + Pickupstart);
                Logger.WriteDebugMessage("Enter Pick end as = " + Pickupend);
                ReportParameter.Pace_Dashboard_StartDate(startDate);
                ReportParameter.Pace_Dashboard_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Pace_Dashboard_Update_Button();
                AddDelay(20000);
                ReportParameter.Click_Dashboard_Excel_Icon();
                AddDelay(20000);
                if (client == "Kerzner")
                {
                    FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                    Filename = ReportParameter.Dashboard_VerifyFileFormate(FilePath);
                    FullPath = TestData.ExcelData.ExcelDataReader.Dashboard_GetNewestFile((FilePath));

                    TestData.ExcelData.ExcelDataReader jj = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Hotel_dates = jj.GetCellData(Worksheetname, 2, 3);
                    if (Hotel_dates.Equals(Hotel_Stay_dates))
                        Logger.WriteInfoMessage(Hotel_Stay_dates + " matched with Report Hotel and stay dates");
                    else
                        scenario2 = false;

                    TestData.ExcelData.ExcelDataReader hh = new TestData.ExcelData.ExcelDataReader(FullPath);
                    string Bdgt_Var = hh.GetCellData(Worksheetname, 15, 21);
                    if (Bdgt_Var.Equals(Total_Bdgt_Var))
                        Logger.WriteInfoMessage(Total_Bdgt_Var + " matched with Report Total fscr var under Rooms sections ");
                    else
                        Assert.Fail("Total fscr var under Rooms sections not matched");

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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_endDate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Portfolio_Stay_dates", Portfolio_Stay_dates, true);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Fcst_Var", Total_Fcst_Var);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel_Stay_dates", Hotel_Stay_dates);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Total_Bdgt_Var", Total_Bdgt_Var);
                
            }
        }

        //Validate Dashboard - Validate the Hotel -> Hotel Dashboard
        public static void TC_252649()
        {
            if (TestCaseId == Utility.Constants.TC_252649)
            {
                //Pre-Requisite
                string password, username, environment, Hotel, Currency, Business_Unit, client, startDate, enddate;

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

                Logger.WriteInfoMessage("Test Case : Validate the Hotel -> Hotel Dashboard");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Menu_Hotel();
                Logger.WriteDebugMessage("Hotel drop down displayed");
                Navigation.Click_Hotel_Dashboard();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Hotel DashBoard Report Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Hotel_Dashboard());

                //Select Portfolio radio button
                ReportParameter.Dashboard_Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("21C");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("LCL");

                //Select ADR radio button
                ReportParameter.Hotel_Dashboard_ADR_Radio_button();
                Logger.WriteDebugMessage("ADR radio button selected");

                //Select Room Revenue radio button
                ReportParameter.Hotel_Dashboard_Room_Revenue_Radio_button();
                Logger.WriteDebugMessage("Room Revenue radio button selected");

                //Select RoomSold/OTB radio button
                ReportParameter.Hotel_Dashboard_Room_Sold_button();
                Logger.WriteDebugMessage("Room Sold radio button selected");

                //Select Hotel radio button
                ReportParameter.Dashboard_Hotel_RadioButton();
                Logger.WriteDebugMessage("Hotel radio button selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("O&O Cape Town");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("LCL");

                ReportParameter.Hotel_Dashboard_Detail();
                Logger.WriteDebugMessage("Landed on Details page");

                ReportParameter.Dashboard_Enter_StartDate(startDate);
                ReportParameter.Dashboard_Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_Dashboard_Update_Button();
                AddDelay(20000);
                VerifyTextOnPageAndHighLight("01 Oct 2020");
                VerifyTextOnPageAndHighLight("31 Oct 2020");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_endDate", enddate, true);
            }
        }

        //Validate Dashboard - Validate the Business Source -> Agent Dashboard
        public static void TC_252650()
        {
            if (TestCaseId == Utility.Constants.TC_252650)
            {
                //Pre-Requisite
                string password, username, environment,Hotel,Currency, Business_Unit, client,startDate, enddate;

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

                Logger.WriteInfoMessage("Test Case : Validate the Business Source -> Agent Dashboard");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.BusinessSource();
                Logger.WriteDebugMessage("Business Source drop down displayed");
                Navigation.Click_Agent_Dashboard();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Agent_Dashboard Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Agent_Dashboard());
                //Select Portfolio radio button
                ReportParameter.Dashboard_Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("21C");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("AUD");
                ReportParameter.Dashboard_Enter_StartDate(startDate);
                ReportParameter.Dashboard_Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_Dashboard_Update_Button();

                //Select Hotel radio button
                ReportParameter.Dashboard_Hotel_RadioButton();
                Logger.WriteDebugMessage("Hotel radio button selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("Atlantis, The Palm");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("AUD");


                ReportParameter.Dashboard_Enter_StartDate(startDate);
                ReportParameter.Dashboard_Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_Dashboard_Update_Button();
                AddDelay(20000);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate, true);
            }
            
        }

        //Validate the Dashboard - Validate the Business Source -> Company Dashboard
        public static void TC_252651()
        {
            if (TestCaseId == Utility.Constants.TC_252651)
            {
                //Pre-Requisite
                string password, username, environment, Hotel, Currency, Business_Unit, client, startDate, enddate;

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

                Logger.WriteInfoMessage("Test Case : Validate the Business Source -> Company Dashboard");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.BusinessSource();
                Logger.WriteDebugMessage("Business Source drop down displayed");
                Navigation.Click_Company_Dashboard();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on  Company Dashboard Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Company_Dashboard());

                //Select Portfolio radio button
                ReportParameter.Dashboard_Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("21C");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("AUD");
                ReportParameter.CompanyDashboard_Enter_StartDate(startDate);
                ReportParameter.CompanyDashboard_Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_CompanyDashboard_Update_Button();

                //Select Hotel radio button
                ReportParameter.Dashboard_Hotel_RadioButton();
                Logger.WriteDebugMessage("Hotel radio button selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("Atlantis, The Palm");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("AUD");

                ReportParameter.CompanyDashboard_Enter_StartDate(startDate);
                ReportParameter.CompanyDashboard_Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_CompanyDashboard_Update_Button();
                AddDelay(20000);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate, true);
            }
        }

        //Validate the Dashboard - Validate the Business Source -> Negotiated Dashboard
        public static void TC_252652()
        {
            if (TestCaseId == Utility.Constants.TC_252652)
            {
                //Pre-Requisite
                string password, username, environment, Hotel, Currency, Business_Unit, client, startDate, enddate;

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

                Logger.WriteInfoMessage("Test Case : Validate the Business Source -> Negotiated Dashboard");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.BusinessSource();
                Logger.WriteDebugMessage("Business Source drop down displayed");
                Navigation.Click_Negotiated_Dashboard();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on  Negotiated Dashboard Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Negotiated_Dashboard());

                //Select Portfolio radio button
                ReportParameter.Dashboard_Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("21C");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("AUD");
                ReportParameter.Dashboard_Enter_StartDate(startDate);
                ReportParameter.Dashboard_Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_Dashboard_Update_Button();

                //Select Hotel radio button
                ReportParameter.Dashboard_Hotel_RadioButton();
                Logger.WriteDebugMessage("Hotel radio button selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("Atlantis, The Palm");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("AUD");

                ReportParameter.Dashboard_Enter_StartDate(startDate);
                ReportParameter.Dashboard_Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_Dashboard_Update_Button();
                AddDelay(20000);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate, true);
            }
        }

        //Validate the Dashboard - Validate the Market -> Market Dashboard
        public static void TC_252653()
        {
            if (TestCaseId == Utility.Constants.TC_252653)
            {
                //Pre-Requisite
                string password, username, environment, Hotel, Currency, Business_Unit, client, startDate, enddate;

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

                Logger.WriteInfoMessage("Test Case : Validate the Market -> Market Dashboard");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Market();
                Logger.WriteDebugMessage("Business Source drop down displayed");
                Navigation.Click_Market_Dashboard();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on  Market Dashboard Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Market_Dashboard());

                //Select Portfolio radio button
                ReportParameter.Dashboard_Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("21C");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("AUD");
                ReportParameter.Dashboard_Enter_StartDate(startDate);
                ReportParameter.Dashboard_Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_Dashboard_Update_Button();

                //Select Hotel radio button
                ReportParameter.Dashboard_Hotel_RadioButton();
                Logger.WriteDebugMessage("Hotel radio button selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("Atlantis, The Palm");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("AUD");

                ReportParameter.Dashboard_Enter_StartDate(startDate);
                ReportParameter.Dashboard_Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_Dashboard_Update_Button();
                AddDelay(20000);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate, true);
            }
        }

        //Validate Dashboard - Validate the Booking Trends -> Pace Dashboard
        public static void TC_252654()
        {
            if (TestCaseId == Utility.Constants.TC_252654)
            {
                //Pre-Requisite
                string password, username, environment, Hotel, Currency, Business_Unit, client, startDate, enddate;

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

                Logger.WriteInfoMessage("Test Case : Validate the Booking Trends -> Pace Dashboard");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Menu_Booking_Trends();
                Logger.WriteDebugMessage("Business Source drop down displayed");
                Navigation.Click_Pace_Dashboard();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Pace Dashboard Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Pace_Dashboard());

                //Select Portfolio radio button
                ReportParameter.Dashboard_Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("21C");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("AUD");
                ReportParameter.Pace_Dashboard_StartDate(startDate);
                ReportParameter.Pace_Dashboard_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Pace_Dashboard_Update_Button();

                //Select Hotel radio button
                ReportParameter.Dashboard_Hotel_RadioButton();
                Logger.WriteDebugMessage("Hotel radio button selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("Atlantis, The Palm");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("AUD");

                ReportParameter.Pace_Dashboard_StartDate(startDate);
                ReportParameter.Pace_Dashboard_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Pace_Dashboard_Update_Button();
                AddDelay(20000);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate, true);
            }
        }

        //Validate Dashboard - Validate the Channel -> Channel Dashboard
        public static void TC_252655()
        {
            if (TestCaseId == Utility.Constants.TC_252655)
            {
                //Pre-Requisite
                string password, username, environment, Hotel, Currency, Business_Unit, client, startDate, enddate;

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

                Logger.WriteInfoMessage("Test Case : Validate the Channel -> Channel Dashboard");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Menu_Channel();
                Logger.WriteDebugMessage("Channel drop down displayed");
                Navigation.Click_Channel_Dashboard();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on  channel Dashboard Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Channel_Dashboard());

                //Select Portfolio radio button
                ReportParameter.Dashboard_Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("21C");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("AUD");
                ReportParameter.CompanyDashboard_Enter_StartDate(startDate);
                ReportParameter.CompanyDashboard_Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_CompanyDashboard_Update_Button();

                //Select Hotel radio button
                ReportParameter.Dashboard_Hotel_RadioButton();
                Logger.WriteDebugMessage("Hotel radio button selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("Atlantis, The Palm");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("AUD");

                ReportParameter.CompanyDashboard_Enter_StartDate(startDate);
                ReportParameter.CompanyDashboard_Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_CompanyDashboard_Update_Button();
                AddDelay(20000);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate, true);
            }
        }

        //Validate the Dashboard -  Validate the Room Type -> Room Type Dashboard
        public static void TC_252656()
        {
            if (TestCaseId == Utility.Constants.TC_252656)
            {
                //Pre-Requisite
                string password, username, environment, Hotel, Currency, Business_Unit, client, startDate, enddate;

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

                Logger.WriteInfoMessage("Test Case : Validate the Room Type -> Room Type Dashboard");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Room Type drop down displayed");
                Navigation.Click_Room_Type_Dashboard();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on  Room Type Dashboard Page");

                Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Room_Type_Dashboard());

                //Select Portfolio radio button
                ReportParameter.Dashboard_Portfolio_RadioButton();
                Logger.WriteDebugMessage("Portfolio radio button selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("21C");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("AUD");
                ReportParameter.CompanyDashboard_Enter_StartDate(startDate);
                ReportParameter.CompanyDashboard_Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_CompanyDashboard_Update_Button();

                //Select Hotel radio button
                ReportParameter.Dashboard_Hotel_RadioButton();
                Logger.WriteDebugMessage("Hotel radio button selected");
                ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL();
                VerifyTextOnPageAndHighLight("Atlantis, The Palm");
                ReportParameter.Click_Dashboard_Currency_DDL();
                VerifyTextOnPageAndHighLight("AUD");

                ReportParameter.CompanyDashboard_Enter_StartDate(startDate);
                ReportParameter.CompanyDashboard_Enter_EndDate(enddate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_CompanyDashboard_Update_Button();
                AddDelay(20000);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Business_Unit", Business_Unit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Currency", Currency);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Hotel", Hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate, true);
            }
        }

    }
}
