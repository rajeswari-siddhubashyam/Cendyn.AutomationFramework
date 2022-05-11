using AventStack.ExtentReports.Model;
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
        //Verify the Access log
        public static void TC_252870()
        {
            if (TestCaseId == Utility.Constants.TC_252870)
            {
                //Pre-Requisite
                string password, username, client, environment;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");

                Logger.WriteInfoMessage("Test Case : Verify the Access log");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Administration();
                Logger.WriteDebugMessage("Administration drop down displayed");
                Navigation.Click_Access_Log();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Access Log Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Access_Log());

                Helper.VerifyTextOnPageAndHighLight("k_tautomation");
                Logger.WriteDebugMessage("system login gets displayed ");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }

        //Verify the Corporate Portfolio
        public static void TC_252871()
        {
            if (TestCaseId == Utility.Constants.TC_252871)
            {
                //Pre-Requisite
                string password, username, client, environment;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");

                Logger.WriteInfoMessage("Test Case : Verify the Corporate Portfolio");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Administration();
                Logger.WriteDebugMessage("Administration drop down displayed");
                Navigation.Corporate_Portfolio();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Corporate Portfolio Page");
                
                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }

        //Verify attempting to create a new user with an existing email or userid should fail
        public static void TC_252877()
        {
            if (TestCaseId == Utility.Constants.TC_252877)
            {
                //Pre-Requisite
                string password, username, client, environment, user_ID, user_email, First_Name, Last_Name;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                user_ID = TestData.ExcelData.TestDataReader.ReadData(1, "user_ID");
                user_email = TestData.ExcelData.TestDataReader.ReadData(1, "user_email");
                First_Name = TestData.ExcelData.TestDataReader.ReadData(1, "First_Name");
                Last_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Last_Name");

                Logger.WriteInfoMessage("Test Case : Verify the Corporate Portfolio");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Administration();
                Logger.WriteDebugMessage("Administration drop down displayed");
                Navigation.User_Maintenance();
                Logger.WriteDebugMessage("User Landed on User Maintenance Page");

                EnterFrameByxPath(PageObject_Navigation.Iframe_user_Maintenance());

                //Click on close
                Navigation.Add_New_User();
                Logger.WriteDebugMessage("Landed on revintel - Add Users Page");
                Navigation.user_Maintenance_Close();
                Logger.WriteDebugMessage("revintel - Add Users Page got closed");

                //Click on save button with entering mandatory field 
                Navigation.Add_New_User();
                Logger.WriteDebugMessage("Landed on revintel - Add Users Page");
                EnterFrameByxPath(PageObject_Navigation.Iframe_Add_User());
                Navigation.user_Maintenance_Save();
                Helper.VerifyTextOnPageAndHighLight("User Id is required!");
                Helper.VerifyTextOnPageAndHighLight("Email Id is required!");
                Logger.WriteDebugMessage("Required field validation message is displaying");

                //create a new user with an existing email
                Navigation.user_Id(user_ID);
                Logger.WriteDebugMessage("Enter User ID as " + user_ID);
                Navigation.Add_User_Email(user_email);
                Logger.WriteDebugMessage("Enter User Email as " + user_email);
                Navigation.Add_User_FirstName(First_Name);
                Logger.WriteDebugMessage("Enter User First name as " + First_Name);
                Navigation.Add_User_LastName(Last_Name);
                Logger.WriteDebugMessage("Enter User LastName as" + Last_Name);
                Navigation.Select_Available_Hotels();
                Navigation.user_Maintenance_Save();
                Logger.WriteDebugMessage("Validation message displayed");
                Helper.VerifyTextOnPageAndHighLight("User k_k_rshende already exists!");
               
                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_user_ID", user_ID);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_user_email", user_email);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_First_Name", First_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Last_Name", Last_Name, true);
            }
        }

        //Validate Parent Company - No duplicate Parent name is allowed and a warning displays
        public static void TC_252879()
        {
            if (TestCaseId == Utility.Constants.TC_252879)
            {
                //Pre-Requisite
                string password, username, client, environment, user_ID, user_email, First_Name, Last_Name;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                user_ID = TestData.ExcelData.TestDataReader.ReadData(1, "user_ID");
                user_email = TestData.ExcelData.TestDataReader.ReadData(1, "user_email");
                First_Name = TestData.ExcelData.TestDataReader.ReadData(1, "First_Name");
                Last_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Last_Name");

                Logger.WriteInfoMessage("Test Case : Verify the Corporate Portfolio");


                //Enter Email address and password
                Login.Frontend_SignIn(username, password);  

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Administration();
                Logger.WriteDebugMessage("Administration drop down displayed");
                Navigation.Click_Parent_Company();
                Logger.WriteDebugMessage("User Landed on Parent Company Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Parent_Company());

                ////Field Validation
                ReportParameter.Click_Add_New_Parent_Company();
                Logger.WriteDebugMessage("Landed on revintel - Add Parent Company Page");

                //EnterFrameByxPath(PageObject_ReportParameter.iframe_Add_Parent_Company_PopUp());
                //Helper.ZoomIn();
                //Helper.ScrollDown();
                //Helper.ScrollToElement(PageObject_ReportParameter.Enter_Parent_Company_Name());
                //ReportParameter.Click_Add_New_Parent_Company_Save_Button();
                //Logger.WriteDebugMessage("Required field validation message is displaying");
                //Helper.VerifyTextOnPageAndHighLight("Parent name is required!");


                //Enter duplicate Parent name and click on save
                ReportParameter.Enter_Parent_Company_Name("test");
                Logger.WriteDebugMessage("Entered Parent Company Name as test");
                ReportParameter.Click_Add_New_Parent_Company_Save_Button();
                Logger.WriteDebugMessage("Validation message is displaying");
                Helper.VerifyTextOnPageAndHighLight("Parent Profile 'test' already exists!");

                //Verify Add & Save functionality work
                ReportParameter.Enter_Parent_Company_Name("Auto test");
                Logger.WriteDebugMessage("Entered Parent Company Name as Auto test");
                ReportParameter.Click_Add_New_Parent_Company_Save_Button();
                Logger.WriteDebugMessage("New Parent Company got saved");
                VerifyTextOnPageAndHighLight("Auto test");
                Logger.WriteDebugMessage("Recently added parent company name displayed");

                //Verify Edit functionality work
                ReportParameter.Click_Parent_Company_Name_Edit_Link();
                Logger.WriteDebugMessage("Landed on revintel - Edit Parent Company");
                ReportParameter.Enter_Parent_Company_Name("New Name");
                Logger.WriteDebugMessage("Entered Parent Company Name as New Name");
                ReportParameter.Click_Add_New_Parent_Company_Save_Button();
                Logger.WriteDebugMessage("New Parent Company got saved");
                VerifyTextOnPageAndHighLight("New Name");
                Logger.WriteDebugMessage("Recently updated parent company name displayed");

                //Verify Cancel functionality work
                ReportParameter.Click_Add_New_Parent_Company();
                Logger.WriteDebugMessage("Landed on revintel - Add Parent Company Page");
                ReportParameter.Click_Add_New_Parent_Company_Close_Button();
                Logger.WriteDebugMessage("Add New Parent Company page got closed Successfully");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_user_ID", user_ID);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_user_email", user_email);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_First_Name", First_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Last_Name", Last_Name, true);
            }
        }

        //Verify the user access report
        public static void TC_252894()
        {
            if (TestCaseId == Utility.Constants.TC_252894)
            {
                //Pre-Requisite
                string password, username, client, environment, startDate, enddate, FilePath, FullPath, Filename, Worksheetname = "Sheet1", reportName;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                startDate = TestData.ExcelData.TestDataReader.ReadData(1, "startDate");
                enddate = TestData.ExcelData.TestDataReader.ReadData(1, "enddate");
                reportName = TestData.ExcelData.TestDataReader.ReadData(1, "reportName");

                Logger.WriteInfoMessage("Test Case : Verify the user access report");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                Navigation.Click_Hamburger_Icon();
                Navigation.Administration();
                Logger.WriteDebugMessage("Administration drop down displayed");
                Navigation.Click_User_Access_Report();
                Logger.WriteDebugMessage("User Landed on User Access report Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_User_Access_Report()); 

                //Required Field Validation
                ReportParameter.Click_View_Analysis();
                Logger.WriteDebugMessage("Required field validation message is displaying");
                Helper.VerifyTextOnPageAndHighLight("Required");

                ReportParameter.Enter_StartDate(startDate);
                Logger.WriteDebugMessage("Enter start date as = " + startDate);
                Logger.WriteDebugMessage("Enter enddate as = " + enddate);
                ReportParameter.Click_View_Analysis();
                Helper.AddDelay(10000);
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
                        Assert.Fail("Report name matched");
                }
                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_startDate", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_enddate", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_reportName", reportName, true);
            }
        }


        //Verify A user with Property Admin role should only see a list of hotels that he/she was given access to
        public static void TC_252878()
        {
            if (TestCaseId == Utility.Constants.TC_252878)
            {
                //Pre-Requisite
                string password, username, client, environment;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");

                Logger.WriteInfoMessage("Test Case : Verify A user with Property Admin role should only see a list of hotels that he/she was given access to");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Navigate to Administration >> User Maintenance
                Navigation.Click_Hamburger_Icon();
                Navigation.Administration();
                Logger.WriteDebugMessage("Administration drop down displayed");
                Navigation.User_Maintenance();
                Logger.WriteDebugMessage("User Landed on User Maintenance Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_User_Maintenance());

                ScrollDown();
                VerifyTextOnPageAndHighLight("password1@cendyn17.com");
                ReportParameter.Click_User_Maintenance_Edit_Link();
                Logger.WriteDebugMessage("Landed on revintel - Maintain Users Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Maintain_User());
                VerifyTextOnPageAndHighLight("Atlantis, The Palm");
                VerifyTextOnPageAndHighLight("Test Custom");
                Helper.ReloadPage();

                //Navigate to RainMaker >> Role_Maintenance
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_RainMaker();
                Logger.WriteDebugMessage("Rainmaker drop down displayed");
                ReportParameter.Click_Role_Maintenance();
                Logger.WriteDebugMessage("User Landed on Role Maintenance Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Role_Maintenance());
                ReportParameter.Click_Role_Maintenance_Edit_Link_for_Test_Custom();
                Logger.WriteDebugMessage("Landed on Role page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Role_Maintenance_PopUp());
                ReportParameter.Click_Role_Report_Tab();
                Logger.WriteDebugMessage("Landed on report page");
                ReportParameter.Click_Role_Tenants_Tab();

                Navigation.Click_TA();
                Login.LogOut_Button();
                Logger.WriteDebugMessage("User get logOut successfully");

                //Verify Data in export document and in front end 
                Login.Enter_EmailAddress("password1@cendyn17.com");
                Logger.WriteDebugMessage("Email is entered as password1@cendyn17.com");
                Login.Enter_Password("Cendyn123$");
                Logger.WriteDebugMessage("Password is entered as Cendyn123$");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client,true);
            }
        }
    }
}

