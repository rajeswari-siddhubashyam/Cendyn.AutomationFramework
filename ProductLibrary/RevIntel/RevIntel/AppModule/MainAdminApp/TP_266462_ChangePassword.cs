using BaseUtility.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using RevIntel.AppModule.UI;
using Navigation = RevIntel.AppModule.UI.Navigation;

namespace RevIntel.AppModule.MainAdminApp
{
    public partial class MainAdminApp : RevIntel.Utility.Setup 
    {
        // Validate Upon selecting Cancel user landed on Monthly Pickup page
        public static void TC_266463()
        {
            if (TestCaseId == Utility.Constants.TC_266463)
            {
                //Pre-Requisite
                string password, username, environment, client,url;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                url = TestData.ExcelData.TestDataReader.ReadData(1, "url");

                Logger.WriteInfoMessage("Test Case : Validate Upon selecting Cancel user landed on Monthly Pickup page");

                //Enter Email address and password
                if (TestPlanId == "TP_278124")
                    Login.Frontend_SignIn("rshende@delapex.com", "Cendyn123$");
                else
                    Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Verify link directed to right URL
                url = TestData.ExcelData.TestDataReader.ReadData(1, "url");

                string client_CurrentUrl = Driver.Url;
                if (client_CurrentUrl.Contains(url))
                    Logger.WriteDebugMessage("Actual url = " + client_CurrentUrl + " match with Expected url = " + url);
                else
                    Assert.Fail("Actual and Expeted url are not same");

                //Click on Change Password 
                Navigation.Click_TA();
                Logger.WriteDebugMessage("change password displayed");
                Navigation.Click_change_password();
                Logger.WriteDebugMessage("User landed on change password screen");

                //Click on Cancel button in change password screen 
                Navigation.Change_password_Cancel_button();
                Logger.WriteDebugMessage("User landed back to Monthly pick up page ");


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }

        // Verify Change Password functionality will not be successful when Current password is incorrect
        public static void TC_266464()
        {
            if (TestCaseId == Utility.Constants.TC_266464)
            {
                //Pre-Requisite
                string password, username, environment, client, Current_Password, New_Password, Confirm_Password,url;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Current_Password = TestData.ExcelData.TestDataReader.ReadData(1, "Current_Password");
                New_Password = TestData.ExcelData.TestDataReader.ReadData(1, "New_Password");
                Confirm_Password = TestData.ExcelData.TestDataReader.ReadData(1, "Confirm_Password");
                url = TestData.ExcelData.TestDataReader.ReadData(1, "url");

                Logger.WriteInfoMessage("Test Case : Verify Change Password functionality will not be successful when Current password is incorrect");

                //Enter Email address and password
                if (TestPlanId == "TP_278124")
                    Login.Frontend_SignIn("rshende@delapex.com", "Cendyn123$");
                else
                    Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Verify link directed to right URL
                url = TestData.ExcelData.TestDataReader.ReadData(1, "url");

                string client_CurrentUrl = Driver.Url;
                if (client_CurrentUrl.Contains(url))
                    Logger.WriteDebugMessage("Actual url = " + client_CurrentUrl + " match with Expected url = " + url);
                else
                    Assert.Fail("Actual and Expeted url are not same");

                //Click on Change Password 
                Navigation.Click_TA();
                Logger.WriteDebugMessage("change password displayed");
                Navigation.Click_change_password();
                Logger.WriteDebugMessage("User landed on change password screen");

                //Enter  incorrect current password  and all other information correctly  and Submit the form
                Navigation.Enter_Current_Password(Current_Password);
                Logger.WriteDebugMessage(Current_Password + "Entered as Current Password");
                Navigation.Enter_New_Password(New_Password);
                Logger.WriteDebugMessage(New_Password + "Entered as New Password");
                Navigation.Enter_Confirm_Password(Confirm_Password);
                Logger.WriteDebugMessage(Confirm_Password + "Entered as Confirm Password");
                Navigation.Click_Change_Password_button();
                Helper.VerifyTextOnPage("You have supplied the wrong password. If you have forgotten your password, follow the Forgot Password steps to reset your account.");
                Logger.WriteDebugMessage("You have supplied the wrong password. If you have forgotten your password, follow the Forgot Password steps to reset your account.");



                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current_Password", Current_Password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_New_Password", New_Password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Confirm_Password", Confirm_Password, true);
            }
        }

        //Verify Change Password functionality will not be successful when New and Confirm password are not matching
        public static void TC_266466()
        {
            if (TestCaseId == Utility.Constants.TC_266466)
            {
                //Pre-Requisite
                string password, username, environment, client, Current_Password, New_Password, Confirm_Password,url;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                Current_Password = TestData.ExcelData.TestDataReader.ReadData(1, "Current_Password");
                New_Password = TestData.ExcelData.TestDataReader.ReadData(1, "New_Password");
                Confirm_Password = TestData.ExcelData.TestDataReader.ReadData(1, "Confirm_Password");
                url = TestData.ExcelData.TestDataReader.ReadData(1, "url");

                Logger.WriteInfoMessage("Test Case : Verify Change Password functionality will not be successful when New and Confirm password are not matching");

                //Enter Email address and password
                if (TestPlanId == "TP_278124")
                    Login.Frontend_SignIn("rshende@delapex.com", "Cendyn123$");
                else
                    Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Verify link directed to right URL
                url = TestData.ExcelData.TestDataReader.ReadData(1, "url");

                string client_CurrentUrl = Driver.Url;
                if (client_CurrentUrl.Contains(url))
                    Logger.WriteDebugMessage("Actual url = " + client_CurrentUrl + " match with Expected url = " + url);
                else
                    Assert.Fail("Actual and Expeted url are not same");

                //Click on Change Password 
                Navigation.Click_TA();
                Logger.WriteDebugMessage("change password displayed");
                Navigation.Click_change_password();
                Logger.WriteDebugMessage("User landed on change password screen");

                //Enter  incorrect current password  and all other information correctly  and Submit the form
                Navigation.Enter_Current_Password(Current_Password);
                Logger.WriteDebugMessage(Current_Password + "Entered as Current Password");
                Navigation.Enter_New_Password(New_Password);
                Logger.WriteDebugMessage(New_Password + "Entered as New Password");
                Navigation.Enter_Confirm_Password(Confirm_Password);
                Logger.WriteDebugMessage(Confirm_Password + "Entered as Confirm Password");
                Navigation.Enter_Current_Password("");
                Logger.VerifyTextOnPage("The passwords you have entered do not match. Please try again.");
                Logger.WriteDebugMessage("The passwords you have entered do not match. Please try again.");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current_Password", Current_Password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_New_Password", New_Password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Confirm_Password", Confirm_Password, true);
            }
        }

        //Verify Change Password functionality will not be successful when entered detail is not meeting the Password requirement criteria
        public static void TC_266467()
        {
            if (TestCaseId == Utility.Constants.TC_266467)
            {
                //Pre-Requisite
                string password, username, client, Current_Password, New_Password, Confirm_Password, Current_Password_1, New_Password_1, Confirm_Password_1, url;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                Current_Password_1 = TestData.ExcelData.TestDataReader.ReadData(1, "Current_Password_1");
                New_Password_1 = TestData.ExcelData.TestDataReader.ReadData(1, "New_Password_1");
                Confirm_Password_1 = TestData.ExcelData.TestDataReader.ReadData(1, "Confirm_Password_1");

                Logger.WriteInfoMessage("Test Case : Verify Change Password functionality will not be successful when entered detail is not meeting the Password requirement criteria");

                //Enter Email address and password
                Login.Prod_Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Verify link directed to right URL
                url = TestData.ExcelData.TestDataReader.ReadData(1, "url");

                string client_CurrentUrl = Driver.Url;
                if (client_CurrentUrl.Contains(url))
                    Logger.WriteDebugMessage("Actual url = " + client_CurrentUrl + " match with Expected url = " + url);
                else
                    Assert.Fail("Actual and Expeted url are not same");

                Navigation.Click_TA();
                Logger.WriteDebugMessage("change password displayed");
                Navigation.Click_change_password();
                Logger.WriteDebugMessage("User landed on change password screen");


                //Enter correct current password Enter New and confirm password as one of the last 6 passwords Submit the form
                Navigation.Enter_Current_Password(Current_Password_1);
                Logger.WriteDebugMessage(Current_Password_1 + " Entered as Current Password");
                Navigation.Enter_New_Password(New_Password_1);
                Logger.WriteDebugMessage(New_Password_1 + " Entered as New Password");
                Navigation.Enter_Confirm_Password(Confirm_Password_1);
                Logger.WriteDebugMessage(Confirm_Password_1 + " Entered as Confirm Password");
                Navigation.Click_Change_Password_button();
                Helper.VerifyTextOnPage("The password is one of the last 6 passwords.");
                Logger.WriteDebugMessage("The password is one of the last 6 passwords.");
                Helper.ReloadPage();

                for (int Password = 2; Password < 7; Password++)
                {

                    Current_Password = TestData.ExcelData.TestDataReader.ReadData(Password, "Current_Password");
                    New_Password = TestData.ExcelData.TestDataReader.ReadData(Password, "New_Password");
                    Confirm_Password = TestData.ExcelData.TestDataReader.ReadData(Password, "Confirm_Password");

                    Navigation.Enter_Current_Password(Current_Password);
                    Logger.WriteDebugMessage(Current_Password + " Entered as Current Password");
                    Navigation.Enter_New_Password(New_Password);
                    Logger.WriteDebugMessage(New_Password + " Entered as New Password");
                    Navigation.Enter_Confirm_Password(Confirm_Password);
                    Logger.WriteDebugMessage(Confirm_Password + " Entered as Confirm Password");
                    Navigation.Check_Change_Password_button_Disable();
                    Helper.ReloadPage();
                }
                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client, true);
            }
        }

        //Verify Change Password functionality will be successful when entered detail met Password requirements
        public static void TC_266468()
        {
            if (TestCaseId == Utility.Constants.TC_266468)
            {
                //Pre-Requisite
                string password, username, url,environment, client, New_Password_1, Current_Password_1, Confirm_Password_1, Current_Password, New_Password, Confirm_Password, New_Set_Password;

                //Retrieve data from Database or testdata file
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");
                client = TestData.ExcelData.TestDataReader.ReadData(1, "client");
                environment = TestData.ExcelData.TestDataReader.ReadData(1, "environment");
                New_Set_Password = TestData.ExcelData.TestDataReader.ReadData(1, "New_Set_Password");
                Current_Password_1 = TestData.ExcelData.TestDataReader.ReadData(1, "Current_Password_1");
                New_Password_1 = TestData.ExcelData.TestDataReader.ReadData(1, "New_Password_1");
                Confirm_Password_1 = TestData.ExcelData.TestDataReader.ReadData(1, "Confirm_Password_1");
                url = TestData.ExcelData.TestDataReader.ReadData(1, "url");

                Logger.WriteInfoMessage("Test Case : Verify Change Password functionality will be successful when entered detail met Password requirements");

                //Enter Email address and password
                if (TestPlanId == "TP_278124")
                    Login.Frontend_SignIn("rshende@delapex.com", "Cendyn123$");
                else
                    Login.Frontend_SignIn(username, password);

                //Select Client 
                Navigation.Select_Client(client);

                //Verify link directed to right URL
                url = TestData.ExcelData.TestDataReader.ReadData(1, "url");

                string client_CurrentUrl = Driver.Url;
                if (client_CurrentUrl.Contains(url))
                    Logger.WriteDebugMessage("Actual url = " + client_CurrentUrl + " match with Expected url = " + url);
                else
                    Assert.Fail("Actual and Expeted url are not same");

                Navigation.Click_RS();
                Logger.WriteDebugMessage("change password displayed");
                Navigation.Click_change_password();
                Logger.WriteDebugMessage("User landed on change password screen");

                Navigation.Enter_Current_Password(Current_Password_1);
                Logger.WriteDebugMessage(Current_Password_1 + "Entered as Current Password");
                Navigation.Enter_New_Password(New_Password_1);
                Logger.WriteDebugMessage(New_Password_1 + "Entered as New Password");
                Navigation.Enter_Confirm_Password(Confirm_Password_1);
                Logger.WriteDebugMessage(Confirm_Password_1 + "Entered as Confirm Password");
                Navigation.Click_Change_Password_button();
                Logger.WriteDebugMessage("Password updated successfully ");

                Navigation.Click_RS();
                Logger.WriteDebugMessage("Logout button displayed");
                Login.LogOut_Button();
                Logger.WriteDebugMessage("User get log out successfully");
                Login.Enter_EmailAddress(username);
                Logger.WriteDebugMessage("Email Address displayed");
                Login.Click_Next_Button();
                Login.Enter_Password(New_Set_Password);
                Logger.WriteDebugMessage("Login in with Username =" + username + " and Password =" + New_Set_Password);
                Login.Click_SignIn_Button();
                Logger.WriteDebugMessage("Login in successfully with new password");

                //Select Client 
                Navigation.Click_Automation();
                Helper.PageDown();
                Navigation.Click_ClientName(client);
                Helper.AddDelay(10000);

                for (int Password = 2; Password < 8; Password++)
                {
                    Current_Password = TestData.ExcelData.TestDataReader.ReadData(Password, "Current_Password");
                    New_Password = TestData.ExcelData.TestDataReader.ReadData(Password, "New_Password");
                    Confirm_Password = TestData.ExcelData.TestDataReader.ReadData(Password, "Confirm_Password");

                    Navigation.Click_RS();
                    Navigation.Click_change_password();
                    Navigation.Enter_Current_Password(Current_Password);
                    Navigation.Enter_New_Password(New_Password);
                    Navigation.Enter_Confirm_Password(Confirm_Password);
                    Navigation.Click_Change_Password_button();
                }

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_environment", environment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Current_Password_1", Current_Password_1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_New_Password_1", New_Password_1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Confirm_Password_1", Confirm_Password_1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_New_Set_Password", New_Set_Password, true);
            }
        }
    }
    
}
