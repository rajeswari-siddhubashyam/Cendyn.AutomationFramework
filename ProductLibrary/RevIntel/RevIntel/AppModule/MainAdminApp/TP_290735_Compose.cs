using AventStack.ExtentReports.Model;
using BaseUtility.Utility;
using InfoMessageLogger;
using RevIntel.AppModule.UI;
using RevIntel.PageObject.UI;

namespace RevIntel.AppModule.MainAdminApp
{
    public partial class MainAdminApp : RevIntel.Utility.Setup
    {
        //Verify the Cancel and close icon functionality in Create New Report popup
        public static void TC_290742()

        {
            if (TestCaseId == Utility.Constants.TC_290742)
            {
                //Pre-Requisite
                string password, username, environment,client;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");

                Logger.WriteInfoMessage("Test Case : Verify the Cancel and close icon functionality in Create New Report popup");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                ReportParameter.Click_Compose_Menu();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Compose Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Compose());

                ReportParameter.Click_Compose_new_report();
                Logger.WriteDebugMessage("Create New Report pop up displayed");
                ReportParameter.Click_Compose_Create_New_Report_Cancel_button();
                Logger.WriteDebugMessage("Create New Report popup gets closed");

                ReportParameter.Click_Compose_new_report();
                Logger.WriteDebugMessage("Create New Report pop up displayed");
                ReportParameter.Click_Compose_Create_New_Report_Close_Icon();
                Logger.WriteDebugMessage("Create New Report popup gets closed");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }

        //Verify full screen functionality
        public static void TC_290745()

        {
            if (TestCaseId == Utility.Constants.TC_290745)
            {
                //Pre-Requisite
                string password, username, environment, client;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");

                Logger.WriteInfoMessage("Test Case : Verify full screen functionality");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                ReportParameter.Click_Compose_Menu();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Compose Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Compose());

                ReportParameter.Click_Compose_FullscreenButton();
                AddDelay(30000);
                Logger.WriteDebugMessage("Report gets displayed in full screen");
               


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }

        //Verify the Create Report fails when Report name is empty
        public static void TC_290743()

        {
            if (TestCaseId == Utility.Constants.TC_290743)
            {
                //Pre-Requisite
                string password, username, environment, client;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");

                Logger.WriteInfoMessage("Test Case : Verify the Create Report fails when Report name is empty");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                ReportParameter.Click_Compose_Menu();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Compose Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Compose());

                ReportParameter.Click_Compose_new_report();
                Logger.WriteDebugMessage("Create New Report pop up displayed");
                ReportParameter.Click_Compose_NewReport_Create_button();
                Logger.WriteDebugMessage("Validation message is displayed :Report Name must be at least three character long");


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }

        //Verify the Create functionality
        public static void TC_290739()

        {
            if (TestCaseId == Utility.Constants.TC_290739)
            {
                //Pre-Requisite
                string password, username, environment, client, validation,Report_Name;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                validation = TestData.ExcelData.TestDataReader.ReadData(1, "validation");
                Report_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Report_Name");

                Logger.WriteInfoMessage("Test Case : Verify the Create functionality");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                ReportParameter.Click_Compose_Menu();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Compose Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Compose());

                ReportParameter.Click_Compose_new_report();
                Logger.WriteDebugMessage("Create New Report pop up displayed");
                ReportParameter.Compose_Enter_NewReport_Name(Report_Name);
                Logger.WriteDebugMessage(Report_Name + "Entered as Report name");
                ReportParameter.Click_Compose_NewReport_Create_button();
                Logger.WriteDebugMessage("Validation message displayed as :" + validation);
                AddDelay(10000);
                Helper.VerifyTextOnPageAndHighLight("new Report");
                Helper.VerifyTextOnPageAndHighLight("Private");
                ReportParameter.Compose_UserReport_Delete();
                ReportParameter.Compose_UserReport_DeleteReport_Delete_Button();

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Report_Name", Report_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_validation", validation, true);
            }
        }

        //Compose/Rename - Verify the Cancel and close icon functionality in Rename Report popup
        public static void TC_290751()

        {
            if (TestCaseId == Utility.Constants.TC_290751)
            {
                //Pre-Requisite
                string password, username, environment, client;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");

                Logger.WriteInfoMessage("Test Case : Compose/Rename - Verify the Cancel and close icon functionality in Rename Report popup");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                ReportParameter.Click_Compose_Menu();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Compose Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Compose());

                ReportParameter.Compose_Users_Report();
                Logger.WriteDebugMessage("Report gets displayed ");
                ReportParameter.Compose_Users_Report_HeaderName();
                ReportParameter.Compose_Users_Report_HeaderName_Edit();
                Logger.WriteDebugMessage("Rename  Report Popup gets displayed");
                ReportParameter.Compose_Users_Report_HeaderName_Edit_CancelButton();
                Logger.WriteDebugMessage("Rename  Report Popup gets close");


                ReportParameter.Compose_Users_Report();
                Logger.WriteDebugMessage("Report gets displayed ");
                ReportParameter.Compose_Users_Report_HeaderName();
                ReportParameter.Compose_Users_Report_HeaderName_Edit();
                ReportParameter.Compose_Users_Report_HeaderName_CloseButton();
                Logger.WriteDebugMessage("Rename  Report Popup gets Close");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }            
        
        //Compose/Rename - Verify the Rename functionality with out entering Report name
        public static void TC_290752()

        {
            if (TestCaseId == Utility.Constants.TC_290752)
            {
                //Pre-Requisite
                string password, username, environment, client, validation;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                validation = TestData.ExcelData.TestDataReader.ReadData(1, "validation");

                Logger.WriteInfoMessage("Test Case : Compose/Rename - Verify the Rename functionality with out entering Report name");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                ReportParameter.Click_Compose_Menu();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Compose Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Compose());

                ReportParameter.Compose_Users_Report();
                Logger.WriteDebugMessage("Report gets displayed ");
                ReportParameter.Compose_Users_Report_HeaderName();
                ReportParameter.Compose_Users_Report_HeaderName_Edit();
                ReportParameter.Compose_Rename_Button();
                AddDelay(10000);
                Logger.WriteDebugMessage("Click on Rename button");
                Logger.WriteDebugMessage(validation +"Displayed");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_validation", validation, true);
                
            }
        }

        //Verify the Rename functionality
        public static void TC_290754()

        {
            if (TestCaseId == Utility.Constants.TC_290754)
            {
                //Pre-Requisite
                string password, username, environment, client, New_Report_Name, validation1, New_Report_Name_Updated;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                New_Report_Name = TestData.ExcelData.TestDataReader.ReadData(1, "New_Report_Name");
                validation1 = TestData.ExcelData.TestDataReader.ReadData(1, "validation1");
                New_Report_Name_Updated = TestData.ExcelData.TestDataReader.ReadData(1, "New_Report_Name_Updated");

                Logger.WriteInfoMessage("Test Case :  Verify the Rename functionality");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                ReportParameter.Click_Compose_Menu();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Compose Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Compose());

                //Add new report
                ReportParameter.Click_Compose_new_report();
                Logger.WriteDebugMessage("Create New Report pop up displayed");
                ReportParameter.Compose_Enter_NewReport_Name(New_Report_Name);
                ReportParameter.Click_Compose_NewReport_Create_button();
                Logger.WriteDebugMessage("Validation message displayed as : "+ validation1);

                //Rename report name
                ReportParameter.Compose_Users_Report();
                ReportParameter.Compose_Users_Report_HeaderName();
                ReportParameter.Compose_Users_Report_HeaderName_Edit();
                Logger.WriteDebugMessage("Rename  Report Popup gets displayed");
                ReportParameter.Update_compose_report_Name(New_Report_Name_Updated);
                ReportParameter.Compose_Rename_Button();

                Helper.ReloadPage();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Compose Page");
                Helper.VerifyTextOnPageAndHighLight("Rename report pop up - Updated");
                ReportParameter.Compose_Users_Report_HeaderName();

                //Verify delete functinality
                ReportParameter.Compose_UserReport_Delete();
                Logger.WriteDebugMessage("Delete Pop up displayed");
                ReportParameter.Compose_UserReport_DeleteReport_Delete_Button();
                Logger.WriteDebugMessage("Report get deleted successfully");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_New_Report_Name", New_Report_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_validation1", validation1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_New_Report_Name_Updated", New_Report_Name_Updated, true);
            }
        }

        //Verify the Copy Report functionality
        public static void TC_290757()

        {
            if (TestCaseId == Utility.Constants.TC_290757)
            {
                //Pre-Requisite
                string password, username, environment, client;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");

                Logger.WriteInfoMessage("Test Case :  Verify the Rename functionality");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                ReportParameter.Click_Compose_Menu();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Compose Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Compose());

                //Add new report
                ReportParameter.Click_Compose_new_report();
                Logger.WriteDebugMessage("Create New Report pop up displayed");
                ReportParameter.Compose_Enter_NewReport_Name("Rename report pop up");
                ReportParameter.Click_Compose_NewReport_Create_button();
                Logger.WriteDebugMessage("Validation message displayed as : New user report saved!");

                //Rename report name
                ReportParameter.Compose_Users_Report();
                ReportParameter.Compose_Users_Report_HeaderName();
                ReportParameter.Compose_Users_Report_HeaderName_Edit();
                Logger.WriteDebugMessage("Rename  Report Popup gets displayed");
                ReportParameter.Update_compose_report_Name("Rename report pop up - Updated");
                ReportParameter.Compose_Rename_Button();
                Logger.WriteDebugMessage("User Landed on Compose Page");
                Helper.VerifyTextOnPageAndHighLight("Rename report pop up - Updated");
                ReportParameter.Compose_Users_Report_HeaderName();

                //Verify delete functinality
                ReportParameter.Compose_UserReport_Delete();
                Logger.WriteDebugMessage("Delete Pop up displayed");
                ReportParameter.Compose_UserReport_DeleteReport_Delete_Button();
                Logger.WriteDebugMessage("Report get deleted successfully");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }

        //Compose/Rename - Verify the Rename functionality by entering report name less than 3 characters
        public static void TC_290753()

        {
            if (TestCaseId == Utility.Constants.TC_290753)
            {
                //Pre-Requisite
                string password, username, environment, client, validation;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                validation = TestData.ExcelData.TestDataReader.ReadData(1, "validation");

                Logger.WriteInfoMessage("Test Case : Verify the Rename functionality by entering report name less than 3 characters");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                ReportParameter.Click_Compose_Menu();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Compose Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Compose());

                ReportParameter.Compose_Users_Report();
                Logger.WriteDebugMessage("Report gets displayed ");
                ReportParameter.Compose_Users_Report_HeaderName();
                ReportParameter.Compose_Users_Report_HeaderName_Edit();
                ReportParameter.Update_compose_report_Name("Re");
                ReportParameter.Check_Rename_Button_Disable();

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_validation", validation, true);

            }
        }

        //Compose/Create - Verify the Create Report fails when Report name is less than 3 characters
        public static void TC_290744()

        {
            if (TestCaseId == Utility.Constants.TC_290744)
            {
                //Pre-Requisite
                string password, username, environment, client, validation;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                validation = TestData.ExcelData.TestDataReader.ReadData(1, "validation");

                Logger.WriteInfoMessage("Test Case : Verify the Create Report fails when Report name is less than 3 characters");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                ReportParameter.Click_Compose_Menu();
                AddDelay(10000);
                Logger.WriteDebugMessage("User Landed on Compose Page");

                EnterFrameByxPath(PageObject_ReportParameter.iframe_Compose());

                ReportParameter.Click_Compose_new_report();
                Logger.WriteDebugMessage("Create New Report pop up displayed");
                ReportParameter.Compose_Enter_NewReport_Name("ne");
                ReportParameter.Compose_Create_Report_button_Disable();

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_validation", validation, true);

            }
        }


    }
}