using BaseUtility.Utility;
using eMenus.AppModule.Admin;
using eMenus.AppModule.UI;
using eMenus.Entity;
using eMenus.PageObject.Admin;
using eMenus.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;
using System;
using TestData;
using Queries = eMenus.Utility.Queries;

namespace eMenus.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eMenus.Utility.Setup
    {
        public static void TC_231915()
        {
            if (TestCaseId == Utility.Constants.TC_231915)
            {
                //Pre-Requisites
                string firstName, lastName, email, phone, password, confirmPassword, InvalidEmail_Validation, invalidEmail, email_Validation, existingEmailValidation;
                string[] actualvalidationmessage = new string[6];
                string[] expectedvalidationmessage = new string[6];
                Users data = new Users();
                Random ranno = new Random();

                //Retrieve data from test Data
                firstName = TestData.ExcelData.TestDataReader.ReadData(1, "FirstName");
                lastName = TestData.ExcelData.TestDataReader.ReadData(1, "LastName");
                email = String.Concat("QATest", ranno.Next().ToString(), "@cendyn17.com");
                phone = TestData.ExcelData.TestDataReader.ReadData(1, "Phone");
                password = ProjectDetails.CommonFrontendPassword;
                confirmPassword = ProjectDetails.CommonFrontendPassword;
                InvalidEmail_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "InvalidEmail_Validation");
                existingEmailValidation = TestData.ExcelData.TestDataReader.ReadData(1, "ExistingEmail_Validation");

                //Log test data into Log file as well as Extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_First Name", firstName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Last Name", lastName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email", email);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Confirm Password", confirmPassword);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_InValid Email Validation", InvalidEmail_Validation);


                for (int i = 0; i < 6; i++)
                {
                    expectedvalidationmessage[i] = TestData.ExcelData.TestDataReader.ReadData(i, "SignUpValidationMessage");
                }

                Logger.WriteDebugMessage("Landed on eMenus Front end Page");

                //Navigate to SignUp Page
                SignUp.Click_CreateAccount();
                Logger.WriteDebugMessage("Landed on eMenus Create and Account Page");

                //Click on SignUp button without entering any values inn text fields
                SignUp.Click_SignUp_Button();
                Logger.WriteDebugMessage("Required Fields validation Message should be Displayed");

                //Retrieve the Validation message
                actualvalidationmessage[0] = SignUp.FirstName_Validation();
                actualvalidationmessage[1] = SignUp.LastName_Validation();
                actualvalidationmessage[2] = SignUp.Phone_Validation();
                actualvalidationmessage[3] = SignUp.Email_Validation();
                actualvalidationmessage[4] = SignUp.Password_Validation();
                actualvalidationmessage[5] = SignUp.ConfirmPassword_Validation();


                //Verify the Actual Validation message with expected Validation message
                for (int i = 0; i < 6; i++)
                {
                    Navigation.VerifyValidationMessage(actualvalidationmessage[i], expectedvalidationmessage[i]);
                }

                //Enter the Details on the Create an Account Page with Invalid Email address and Validate the Invalid email error

                for (int i = 0; i < 5; i++)
                {
                    Helper.ReloadPage();
                    invalidEmail = TestData.ExcelData.TestDataReader.ReadData(i, "InvalidEmail");
                    Logger.WriteDebugMessage("Landed on Sign Up Page");

                    // Enter All mandatory Fields
                    SignUp.SignUpUser(firstName, lastName, phone, invalidEmail, password, confirmPassword);
                    Logger.WriteDebugMessage("Entered All Mandatory Fields");
                    Logger.WriteDebugMessage(invalidEmail + " Email entered for testing");

                    // Click on Join Now
                    SignUp.Click_SignUp_Button();

                    // Validate the Validation message for Email field
                    email_Validation = SignUp.Email_Validation();
                    Navigation.VerifyValidationMessage(email_Validation, InvalidEmail_Validation);

                }

                // try to SignUp with Already Existing email
                Helper.ReloadPage();
                Queries.GetActiveMemberEmail(data);
                SignUp.SignUpUser(firstName, lastName, phone, data.email, password, confirmPassword);
                SignUp.Click_SignUp_Button();
                AddDelay(10000);
                email_Validation = SignUp.Existing_Email_Validation();
                existingEmailValidation = String.Concat("User ", data.email, existingEmailValidation);
                Navigation.VerifyValidationMessage(email_Validation, existingEmailValidation);


                //SignUp with all Valid Details and Verify the email in Catchall
                Helper.ReloadPage();
                SignUp.SignUpUser(firstName, lastName, phone, email, password, confirmPassword);
                Logger.WriteDebugMessage("Entered All Valid Details");
                SignUp.Click_SignUp_Button();
                ElementWait(PageObject_SignUp.Create_Success_SignIn_Link(), 60);
                Logger.WriteDebugMessage("Sign In Succesfully");
                Helper.OpenNewTab();
                Email.LogIntoCatchAll();
                Logger.WriteDebugMessage("User should be Logged in Catchall Account");
                Email.CatchAll_SearchEmailAndOpenLatestMessage(email); // Searched for the email   
                VerifyTextOnPageAndHighLight(email);

                Logger.WriteDebugMessage("Catchall mailbox should be opened");
                Helper.CloseCurrentTab();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Email available in catchall");

                //Log in with the Newly created user
                Helper.CloseCurrentTab();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Landed on SignUp Confirmation Page");
                SignUp.Click_SignIn_Button();
                Logger.WriteDebugMessage("Landed on SignIn Page");
                SignIn.Frotnend_SignIn(email, ProjectDetails.CommonFrontendPassword);
                ElementWait(PageObject_Navigation.Create_NewOrder(), 60);
                Logger.WriteDebugMessage("Logged in Successfully");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Existing Email Validation", existingEmailValidation, true);

            }
        }
        public static void TC_231918()
        {
            if (TestCaseId == Utility.Constants.TC_231918)
            {
                //Pre-Requisite
                string username, password, username_validation, password_validation, invalid_password_validation, invalid_Username, invalid_Password;
                Users data = new Users();

                //Retrieve data from Test data
                Queries.GetActiveMemberEmail(data);
                username = data.email;
                password = ProjectDetails.CommonFrontendPassword;
                username_validation = TestData.ExcelData.TestDataReader.ReadData(1, "Email_Validation");
                password_validation = TestData.ExcelData.TestDataReader.ReadData(1, "Password_Validation");
                invalid_password_validation = TestData.ExcelData.TestDataReader.ReadData(1, "Invalid_Credential_Validation");
                invalid_Username = TestData.ExcelData.TestDataReader.ReadData(1, "Invalid_Username");
                invalid_Password = TestData.ExcelData.TestDataReader.ReadData(1, "Invalid_Password");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_User-name Validation", username_validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password Validation", password_validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_InValid Username", invalid_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_InValid Password", invalid_Password);


                //Navigate to Sign In button
                Logger.WriteDebugMessage("Landed on Front End Page");
                Navigation.Click_SignIn();
                ElementWait(PageObject_SignIn.TextBox_Username(), 60);
                Logger.WriteDebugMessage("Landed on Front End Sign In Page");

                //Click on Sign In button and verify the Validation for Email
                SignIn.Click_SignIn_Button();
                VerifyTextOnPageAndHighLight(username_validation);
                Logger.WriteDebugMessage("Validation message for Email id is Displayed");

                //Enter Invalid Username and click on SignIn button and verify the Email validation message.
                Helper.ReloadPage();
                SignIn.Enter_Username(invalid_Username);
                SignIn.Click_SignIn_Button();
                Navigation.VerifyValidationMessage(SignIn.Validation_Message(), username_validation);
                VerifyTextOnPageAndHighLight(username_validation);
                Logger.WriteDebugMessage("Validation message for In Valid Username is Displayed");

                //Enter User-name and click on SignIn button and verify the Password validation message.
                Helper.ReloadPage();
                SignIn.Enter_Username(username);
                SignIn.Click_SignIn_Button();
                Navigation.VerifyValidationMessage(SignIn.Validation_Message(), password_validation);
                VerifyTextOnPageAndHighLight(password_validation);
                Logger.WriteDebugMessage("Validation message for Password is Displayed");


                //Enter User-name and Invalid Password and Verify the Validation message
                Helper.ReloadPage();
                SignIn.Frotnend_SignIn(username, invalid_Password);
                Navigation.VerifyValidationMessage(SignIn.Validation_Message(), invalid_password_validation);
                VerifyTextOnPageAndHighLight(invalid_password_validation);
                Logger.WriteDebugMessage("Validation message for Invalid Password is Displayed");

                //Enter Valid User-name and password and Verify the user is able to sign in successfully
                Helper.ReloadPage();
                SignIn.Frotnend_SignIn(username, password);
                ElementWait(PageObject_Navigation.Create_NewOrder(), 60);
                Logger.WriteDebugMessage("Log-in successfully with User-name = " + username + " and Password =" + password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Invalid Credential Error", invalid_password_validation, true);
            }
        }

        public static void TC_231942()
        {
            if (TestCaseId == Utility.Constants.TC_231942)
            {
                //Pre-Requisite
                string username, password, myorders, managaeMyaccount, signIn;
                Users data = new Users();

                //Retrieve data from Test data
                Queries.GetActiveMemberEmail(data);
                username = data.email;
                password = ProjectDetails.CommonFrontendPassword;
                myorders = TestData.ExcelData.TestDataReader.ReadData(1, "My_Order");
                managaeMyaccount = TestData.ExcelData.TestDataReader.ReadData(1, "Manage_My_Account");
                signIn = TestData.ExcelData.TestDataReader.ReadData(1, "Sign_In");

                //Navigate to Sign In button
                Logger.WriteDebugMessage("Landed on Front End Page");
                Navigation.Click_SignIn();
                ElementWait(PageObject_SignIn.TextBox_Username(), 60);
                Logger.WriteDebugMessage("Landed on Front End Sign In Page");

                //Enter Valid User-name and password and Verify the user is able to sign in successfully
                SignIn.Frotnend_SignIn(username, password);
                ElementWait(PageObject_Navigation.Create_NewOrder(), 60);
                Logger.WriteDebugMessage("Log-in successfully with User-name = " + username + " and Password =" + password);

                //Click My Account icon and Click on Sign Out
                Navigation.Click_Button_MyAccount();
                Logger.WriteDebugMessage("My Account button should get clicked");
                Navigation.Click_MyAccount_SignOut();
                VerifyTextOnPageAndHighLight(signIn);
                Logger.WriteDebugMessage("User should Sign out successfully and redirecting to Sign in page");
                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password, true);
            }
        }

        public static void TC_231919()
        {
            if (TestCaseId == Utility.Constants.TC_231919)
            {
                //Pre-Requisite
                string username, password, invalid_Email, invalid_Email_Validation, not_register_Email, notRegister_Email_Validation, forget_passwordValidation, emailSendConfirmation;
                Users data = new Users();
                Random rannum = new Random();

                //Retrieve data from Test data
                Queries.GetActiveMemberEmail(data);
                username = data.email;
                password = ProjectDetails.CommonFrontendPassword;
                not_register_Email = String.Concat("QATest", rannum.Next().ToString(), "@cendyn17.com");
                invalid_Email = TestData.ExcelData.TestDataReader.ReadData(1, "ForgetPassword_InValid_Email");
                invalid_Email_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "InValid_Email_Validation");
                notRegister_Email_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "NotRegister_Email_Validation");
                emailSendConfirmation = TestData.ExcelData.TestDataReader.ReadData(1, "Email_Send_Validation");
                forget_passwordValidation = TestData.ExcelData.TestDataReader.ReadData(1, "Required_Field_Validation");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Invalid Email", invalid_Email);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Invalid Email Validation", invalid_Email_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Not Register Email", not_register_Email);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Not Register Email Validation", notRegister_Email_Validation);
                
                //Navigate to Sign In button
                Logger.WriteDebugMessage("Landed on Front End Page");
                Navigation.Click_SignIn();
                ElementWait(PageObject_SignIn.TextBox_Username(), 60);
                Logger.WriteDebugMessage("Landed on Front End Sign In Page");

                //Click Forgot Password
                ForgetPassword.Click_ForgetPassword();
                Logger.WriteDebugMessage("User should landed on Forget password page");
                ForgetPassword.Click_ForgetPassword_BackButton();
                Logger.WriteDebugMessage("User should navigate to previous page");
                ForgetPassword.Click_ForgetPassword();
                Logger.WriteDebugMessage("User Navigate back to Forgot Password Page");

                ////Verify the Required Filed Validation
                ForgetPassword.Click_ForgetPassword_SendButton();
                Navigation.VerifyValidationMessage(ForgetPassword.Forget_Password_Validation(), forget_passwordValidation);

                //Enter an Invalid Email 
                ForgetPassword.Click_ForgetPassword_BackButton();
                ForgetPassword.Click_ForgetPassword();
                ForgetPassword.ForgetPassword_Email(invalid_Email);
                Logger.WriteDebugMessage("Invalid Email = " + invalid_Email + " entered for testing");
                ForgetPassword.Click_ForgetPassword_SendButton();
                Navigation.VerifyValidationMessage(ForgetPassword.Forget_Password_Validation(), invalid_Email_Validation);


                //Enter valid not registered email
                ForgetPassword.Click_ForgetPassword_BackButton();
                ForgetPassword.Click_ForgetPassword();
                ForgetPassword.ForgetPassword_Email(not_register_Email);
                Logger.WriteDebugMessage("Not Registered Email = " + not_register_Email + " entered for testing");
                ForgetPassword.Click_ForgetPassword_SendButton();
                Navigation.VerifyValidationMessage(ForgetPassword.Forget_Password_Validation(), notRegister_Email_Validation);


                //Enter an Email of a registered account and click Send
                ForgetPassword.Click_ForgetPassword_BackButton();
                ForgetPassword.Click_ForgetPassword();
                ForgetPassword.ForgetPassword_Email(username);
                Logger.WriteDebugMessage("Entered Valid Email Address = " + username);
                ForgetPassword.Click_ForgetPassword_SendButton();
                ElementWait(PageObject_ForgetPassword.Forget_Password_Confirmation_Back(), 60);
                Logger.WriteDebugMessage("Validation message for email sent is  " + emailSendConfirmation);


                //Click Reset password in email link
                Helper.OpenNewTab();
                Email.LogIntoCatchAll();
                Logger.WriteDebugMessage("User should be Logged in Catchall Account");
                Email.CatchAll_SearchEmailAndOpenLatestMessage(username);
                Email.ForgotPasswordEmail_Check();
                Logger.WriteDebugMessage("Email available in catchall");
                Email.ActivationForgotPassword_CLick();
                AddDelay(5000);
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("User should be landed on password reset page");
                ForgetPassword.ResetPassword(username, ProjectDetails.CommonFrontendPassword, ProjectDetails.CommonFrontendPassword);

                ElementWait(PageObject_Navigation.Create_NewOrder(), 60);
                Logger.WriteDebugMessage("Password Reset Successfully");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email Sent Confirmation", emailSendConfirmation, true);
            }
        }

        public static void TC_231943()
        {
            if (TestCaseId == Utility.Constants.TC_231943)
            {
                //Pre-Requisite
                string username, password, fname, lname, address, address2, country, state, city, postalCode, phone, company, update_validation, expected_firstName_Validation, expected_lastName_Validation, expected_phone_Validation;
                string eventName, eventStartdate, eventEndDate, functionName, noOfGuest, functionRoom, functionType, setupStyle, menuName, contact, save_Confirmation, send_Confirmation, randnum;
                Users data = new Users();
                Random radno = new Random();
                randnum = radno.Next().ToString();

                //Retrieve data from Test data
                Queries.GetActiveMemberEmail(data);
                username = data.email;
                password = ProjectDetails.CommonFrontendPassword;
                fname = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "FirstName"), randnum);
                lname = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "LastName"), randnum);
                address = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Address"), randnum);
                address2 = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Address2"), randnum);
                country = TestData.ExcelData.TestDataReader.ReadData(1, "Country");
                state = TestData.ExcelData.TestDataReader.ReadData(1, "State");
                city = TestData.ExcelData.TestDataReader.ReadData(1, "City");
                postalCode = TestData.ExcelData.TestDataReader.ReadData(1, "PostalCode");
                phone = TestData.ExcelData.TestDataReader.ReadData(1, "Phone");
                company = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Company"), randnum);
                update_validation = TestData.ExcelData.TestDataReader.ReadData(1, "UpdationSuccess_Validation");
                expected_firstName_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "FirstName_Validation");
                expected_lastName_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "LastName_Validation");
                expected_phone_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "Phone_Validation");
                eventName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "EventName"), randnum);
                eventStartdate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                eventEndDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                functionName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "FunctionName"), randnum);
                noOfGuest = TestData.ExcelData.TestDataReader.ReadData(1, "NoOfGuest");
                functionRoom = TestData.ExcelData.TestDataReader.ReadData(1, "FunctionRoom");
                functionType = TestData.ExcelData.TestDataReader.ReadData(1, "FunctionType");
                setupStyle = TestData.ExcelData.TestDataReader.ReadData(1, "SetupStyle");
                menuName = TestData.ExcelData.TestDataReader.ReadData(1, "MenuName");
                contact = TestData.ExcelData.TestDataReader.ReadData(1, "Contact");
                save_Confirmation = TestData.ExcelData.TestDataReader.ReadData(1, "Save_Confirmation");
                send_Confirmation = TestData.ExcelData.TestDataReader.ReadData(1, "Send_Confirmation");


                //Navigate to Sign In button
                Logger.WriteDebugMessage("Landed on Front End Page");
                Navigation.Click_SignIn();
                ElementWait(PageObject_SignIn.TextBox_Username(), 60);
                Logger.WriteDebugMessage("Landed on Front End Sign In Page");

                // Enter Valid User - name and password and Verify the user is able to sign in successfully
                SignIn.Frotnend_SignIn(username, password);
                ElementWait(PageObject_Navigation.Create_NewOrder(), 60);
                Logger.WriteDebugMessage("Log-in successfully with User-name = " + username + " and Password =" + password);

                // Click Manage My account
                Navigation.Click_Button_MyAccount();
                Logger.WriteDebugMessage("My Account button should get clicked");
                ManageMyAccount.Click_MyOrder_ManageMyAccount();
                Logger.WriteDebugMessage("Manage My Account page should get displayed");

                //Clear All details on Manage my Account Page and Check for the Mandatory Fields
                ManageMyAccount.ClearManageAccountDetails();
                Logger.WriteDebugMessage("All Details are Cleared");
                ManageMyAccount.ManageMyAccount_UpdateButton();
                Navigation.VerifyValidationMessage(ManageMyAccount.ManageMyAccount_FirstnameValidation(), expected_firstName_Validation);
                Navigation.VerifyValidationMessage(ManageMyAccount.ManageMyAccount_LastnameValidation(), expected_lastName_Validation);
                Navigation.VerifyValidationMessage(ManageMyAccount.ManageMyAccount_PhoneValidation(), expected_phone_Validation);

                //Enter the Details on Mandatory Fields and Update the Details
                ManageMyAccount.ManageMyAccount_EnterMandatoryFields(fname, lname, phone);
                Logger.WriteDebugMessage("Entered all Mandatory Fields");
                ManageMyAccount.ManageMyAccount_UpdateButton();
                VerifyTextOnPageAndHighLight(update_validation);
                Logger.WriteDebugMessage("Update button should clicked and validation message should get display" + update_validation);

                // Enter all he details and check the Back Button Functionality
                Helper.ReloadPage();
                ManageMyAccount.ClearManageAccountDetails();
                Logger.WriteDebugMessage("All Details are Cleared");
                ManageMyAccount.ManageMyAccount_AccountInformation(fname, lname, address, address2, country, state, city, postalCode, phone, company);
                Logger.WriteDebugMessage("All the Details are Entered on Account Page");
                ManageMyAccount.ManageMyAccount_BackButton();
                Logger.WriteDebugMessage("User should able to navigate welcome page");

                //Enter all he details and click on Update button
                Navigation.Click_Button_MyAccount();
                Logger.WriteDebugMessage("My Account button should get clicked");
                ManageMyAccount.Click_MyOrder_ManageMyAccount();
                Logger.WriteDebugMessage("Manage My Account page should get displayed");
                ManageMyAccount.ClearManageAccountDetails();
                Logger.WriteDebugMessage("All Details are Cleared");
                ManageMyAccount.ManageMyAccount_AccountInformation(fname, lname, address, address2, country, state, city, postalCode, phone, company);
                Logger.WriteDebugMessage("All the Details are Entered on Account Page");
                ManageMyAccount.ManageMyAccount_UpdateButton();
                VerifyTextOnPageAndHighLight(update_validation);
                Logger.WriteDebugMessage("Update button should clicked and validation message should get display" + update_validation);

                //Navigate Back and Create an Order
                ManageMyAccount.ManageMyAccount_BackButton();
                Logger.WriteDebugMessage("Navigated Back to Home Page");
                Navigation.Click_Button_MyAccount();
                Logger.WriteDebugMessage("My Account button should get clicked");
                ManageMyAccount.Click_MyOrder_MyOrder();
                Logger.WriteDebugMessage("My Order Page gets Displayed");
                MyOrder.CreateOrder(eventName, eventStartdate, eventEndDate);

                //Add New Function for the Created Order and add menu to the Function
                MyOrder.Add_Function(functionName, noOfGuest, functionRoom, functionType, setupStyle);
                MyOrder.Add_Menu(menuName);

                //Select Menu Items
                MyOrder.SelectMenu();
                MyOrder.Click_ReviewOrder();
                Logger.WriteDebugMessage("Landed on Order Confirmation Page");

                //Verify Customer Information on Order Information Page
                MyOrder.VerifyCustomerDetails(fname, lname, address, address2, city, state, postalCode, phone, company);

                //Submit the Created Order and Save the order for Future Use
                MyOrder.SubmitOrder(contact);
                MyOrder.Click_Save_Order();

                //Check the order Saved Successfully and Navigate to CatchAll for email Verification
                ElementWait(PageObject_MyOrder.Click_MyOrder(), 60);
                VerifyTextOnPageAndHighLight(save_Confirmation);
                Logger.WriteDebugMessage("Order Saved Successfully");
                Helper.OpenNewTab();
                Email.LogIntoCatchAll();
                Logger.WriteDebugMessage("User should be Logged in Catchall Account");
                Email.CatchAll_SearchEmailAndOpenLatestMessage(username);
                MyOrder.ReviewInCatchall(username);
                MyOrder.ReviewNameDetail(fname, lname);
                Helper.CloseCurrentTab();
                Helper.ControlToNewWindow();

                //Navigate back to Order page and Send the Email
                Helper.ControlToPreviousWindow();
                MyOrder.SendOrder(eventName, contact, send_Confirmation);
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("User should be Logged in Catchall Account");
                Email.CatchAll_SearchEmailAndOpenLatestMessage(ProjectDetails.CommonAdminEmail);
                MyOrder.ReviewInCatchall(username);
                MyOrder.ReviewNameDetail(fname, lname);
                Logger.WriteDebugMessage("Customer Details are Displayed on Email");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_First Name", fname);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Last Name", lname);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Address", address);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Address 2", address2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Country", country);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_State", state);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_City", city);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Postal Code", postalCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Phone", phone);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Company", company);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Profile Update Message", update_validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_First Name Validation Message", expected_firstName_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Last Name Validation Message", expected_lastName_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Phone Validation Message", expected_phone_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Event Name", eventName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Event Start Date", eventStartdate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Event End Date", eventEndDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Name", functionName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_No Of Guest", noOfGuest);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Room", functionRoom);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Type", functionType);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Setup Style", setupStyle);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Contact Details", contact);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Order Save Confirmation", save_Confirmation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Order Send Confirmation", send_Confirmation, true);
            }
        }
        public static void TC_231944()
        {
            if (TestCaseId == Utility.Constants.TC_231944)
            {
                //Pre-Requisite
                string username, password, update_Password, update_ConfirmPassword, update_validation, incorrect_Password_Validation;
                Users data = new Users();

                //Retrieve data from Test data
                Queries.GetActiveMemberEmail(data);
                username = data.email;
                password = ProjectDetails.CommonFrontendPassword;
                update_Password = TestData.ExcelData.TestDataReader.ReadData(1, "Update_Password");
                update_ConfirmPassword = TestData.ExcelData.TestDataReader.ReadData(1, "Update_Confirm_Password");
                update_validation = TestData.ExcelData.TestDataReader.ReadData(1, "Update_Validation");
                incorrect_Password_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "Incorrect_Password_Validation");

                //Navigate to Sign In button
                Logger.WriteDebugMessage("Landed on Front End Page");
                Navigation.Click_SignIn();
                ElementWait(PageObject_SignIn.TextBox_Username(), 60);
                Logger.WriteDebugMessage("Landed on Front End Sign In Page");

                //Enter Valid User-name and password and Verify the user is able to sign in successfully
                SignIn.Frotnend_SignIn(username, password);
                ElementWait(PageObject_Navigation.Create_NewOrder(), 60);
                Logger.WriteDebugMessage("Log-in successfully with User-name = " + username + " and Password =" + password);

                //Click Manage My account 
                Navigation.Click_Button_MyAccount();
                Logger.WriteDebugMessage("My Account button should get clicked");
                ManageMyAccount.Click_MyOrder_ManageMyAccount();
                Logger.WriteDebugMessage("Manage My Account page should get displayed");

                //Update Password with New Password
                ManageMyAccount.UpdatePassword(update_Password, update_ConfirmPassword, update_validation);

                //Logout and Try to Login to Front-end by Old Password
                Navigation.Click_Button_MyAccount();
                Logger.WriteDebugMessage("My Account button should get clicked");
                Navigation.Click_MyAccount_SignOut();
                Logger.WriteDebugMessage("Navigated to Sign in Page");
                SignIn.Frotnend_SignIn(username, password);
                VerifyTextOnPageAndHighLight(incorrect_Password_Validation);
                Logger.WriteDebugMessage("Unable to Login from Username and Old Password");

                //Login to Front end from Updated Password
                SignIn.Frotnend_SignIn(username, update_Password);
                ElementWait(PageObject_Navigation.Create_NewOrder(), 60);
                Logger.WriteDebugMessage("Log-in successfully with User-name = " + username + " and Updated Password =" + update_Password);

                //Update the new Password with Old Password
                Navigation.Click_Button_MyAccount();
                Logger.WriteDebugMessage("My Account button should get clicked");
                ManageMyAccount.Click_MyOrder_ManageMyAccount();
                Logger.WriteDebugMessage("Manage My Account page should get displayed");
                ManageMyAccount.UpdatePassword(password, password, update_validation);
                Logger.WriteInfoMessage("Password is reseted to old Password");
            }
        }
        public static void TC_231928()
        {
            if (TestCaseId == Utility.Constants.TC_231928)
            {
                //Pre-Requisite
                string username, password, eventName_Validation, functionName_Validation, noOfGuests_Validation, function_Name, noOf_Guests, function_Room, function_Type, payment_Method,
                    setUp_Style, menu_Name, contact, status, propertyName, propertyAdmin_Username;
                Users data = new Users();

                //Retrieve data from Test data
                Queries.GetActiveMemberEmail(data);
                Random ranNum = new Random();
                username = data.email;
                password = ProjectDetails.CommonFrontendPassword;
                eventName_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "EventName_Validation");
                functionName_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "FunctionName_Validation");
                noOfGuests_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "NoOfGuests_Validation");
                function_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Function_Name");
                noOf_Guests = TestData.ExcelData.TestDataReader.ReadData(1, "NoOf_Guests");
                function_Room = TestData.ExcelData.TestDataReader.ReadData(1, "Function_Room");
                function_Type = TestData.ExcelData.TestDataReader.ReadData(1, "Function_Type");
                setUp_Style = TestData.ExcelData.TestDataReader.ReadData(1, "SetUp_Style");
                menu_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Menu_Name");
                contact = TestData.ExcelData.TestDataReader.ReadData(1, "Contact");
                payment_Method = TestData.ExcelData.TestDataReader.ReadData(1, "Payment_Method");
                status = TestData.ExcelData.TestDataReader.ReadData(1, "Status");
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;

                //Navigate to catchAll and Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to Cendyn Admin and Verify the Contact
                PropertyAdmin.Navigate_CendynAdmin();
                PropertyAdmin.VerifyContacts();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to Frontend Site
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();


                //Navigate to Sign In button
                Logger.WriteDebugMessage("Landed on Front End Page");
                Navigation.Click_SignIn();
                ElementWait(PageObject_SignIn.TextBox_Username(), 60);
                Logger.WriteDebugMessage("Landed on Front End Sign In Page");

                //Enter Valid User-name and password and Verify the user is able to sign in successfully
                SignIn.Frotnend_SignIn(username, password);
                ElementWait(PageObject_Navigation.Create_NewOrder(), 60);
                Logger.WriteDebugMessage("Log-in successfully with User-name = " + username + " and Password =" + password);

                // Create New Order functionality
                string eventName = "Test_" + ranNum.Next().ToString();
                MyOrders.MyOrdersCreateNewOrder(eventName, eventName_Validation);

                // Add function
                EventDetails.AddFunction(functionName_Validation, noOfGuests_Validation, function_Name, noOf_Guests, function_Room, function_Type, setUp_Style);

                //Select menu and add menu items
                EventDetails.AddMenu(menu_Name);

                //Review order funtionality
                EventDetails.ReviewOrder_SaveOrder(contact, payment_Method);

                //Search for the Created Order
                ElementWait(PageObject_MyOrder.Search_Filter(), 60);
                MyOrder.Enter_Search_Filter(eventName);
                VerifyTextOnPageAndHighLight(eventName);
                VerifyTextOnPageAndHighLight(status);
                Logger.WriteDebugMessage(eventName + " Event Found on Search Event Page");
                Helper.CloseCurrentTab();

                //Search for the Sent Order Confirmation Email in catchall
                //Helper.OpenNewTab();
                //Helper.ControlToNewWindow();
                //Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(username);
                MyOrder.ReviewInCatchall(username);
                Logger.WriteDebugMessage("Customer Details are Displayed on Email");


                //Log test data
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Frontend Username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Frontend Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Event Name", eventName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Event Validation", eventName_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Name ", function_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Validation ", functionName_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_No of Guest", noOf_Guests);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_No of Guest  Validation", noOfGuests_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Room", function_Room);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Type", function_Type);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Setup Style", setUp_Style);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menu_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Contact Name", contact);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Payment Method Name", payment_Method);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Admin User Name", propertyAdmin_Username, true);

            }
        }
        public static void TC_231929()
        {
            if (TestCaseId == Utility.Constants.TC_231929)
            {
                //Pre-Requisite
                string username, password, eventName_Validation, functionName_Validation, noOfGuests_Validation, function_Name, noOf_Guests, function_Room, function_Type, payment_Method,
                    setUp_Style, menu_Name, contact, status, propertyName, propertyAdmin_Username;
                Users data = new Users();

                //Retrieve data from Test data
                Queries.GetActiveMemberEmail(data);
                Random ranNum = new Random();
                username = data.email;
                password = ProjectDetails.CommonFrontendPassword;
                eventName_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "EventName_Validation");
                functionName_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "FunctionName_Validation");
                noOfGuests_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "NoOfGuests_Validation");
                function_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Function_Name");
                noOf_Guests = TestData.ExcelData.TestDataReader.ReadData(1, "NoOf_Guests");
                function_Room = TestData.ExcelData.TestDataReader.ReadData(1, "Function_Room");
                function_Type = TestData.ExcelData.TestDataReader.ReadData(1, "Function_Type");
                setUp_Style = TestData.ExcelData.TestDataReader.ReadData(1, "SetUp_Style");
                menu_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Menu_Name");
                contact = TestData.ExcelData.TestDataReader.ReadData(1, "Contact");
                payment_Method = TestData.ExcelData.TestDataReader.ReadData(1, "Payment_Method");
                status = TestData.ExcelData.TestDataReader.ReadData(1, "Status");
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                propertyAdmin_Username = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyAdmin_Username");

                //Navigate to catchAll and Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to Cendyn Admin and Verify the Contact
                PropertyAdmin.Navigate_CendynAdmin();
                PropertyAdmin.VerifyContacts();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to Frontend Site
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();

                //Navigate to Sign In button
                Logger.WriteDebugMessage("Landed on Front End Page");
                Navigation.Click_SignIn();
                ElementWait(PageObject_SignIn.TextBox_Username(), 60);
                Logger.WriteDebugMessage("Landed on Front End Sign In Page");

                //Enter Valid User-name and password and Verify the user is able to sign in successfully
                SignIn.Frotnend_SignIn(username, password);
                ElementWait(PageObject_Navigation.Create_NewOrder(), 60);
                Logger.WriteDebugMessage("Log-in successfully with User-name = " + username + " and Password =" + password);

                // Create New Order functionality
                string eventName = "Test_" + ranNum.Next().ToString();
                MyOrders.MyOrdersCreateNewOrder(eventName, eventName_Validation);

                // Add function
                EventDetails.AddFunction(functionName_Validation, noOfGuests_Validation, function_Name, noOf_Guests, function_Room, function_Type, setUp_Style);

                //Select menu and add menu items
                EventDetails.AddMenu(menu_Name);

                //Review order funtionality
                EventDetails.ReviewOrder_SendOrder(contact, payment_Method);

                //Search for the Created Order
                ElementWait(PageObject_MyOrder.Search_Filter(), 60);
                MyOrder.Enter_Search_Filter(eventName);
                Logger.WriteDebugMessage(eventName + " Event Found on Search Event Page");
                Helper.CloseCurrentTab();
                Helper.ControlToPreviousWindow();

                //Search for the Sent Order Confirmation Email in catchall
                //Helper.OpenNewTab();
                //Helper.ControlToNewWindow();
                //Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(username);
                MyOrder.ReviewInCatchall(username);
                Logger.WriteDebugMessage("Customer Details are Displayed on Email");
                Helper.CloseCurrentTab();

                //Navigate to Admin and Search for the Order
                //Helper.ControlToPWindow();
                Logger.WriteDebugMessage("Landed on Admin Page");
                PropertyAdmin.Click_uOrder();
                Logger.WriteDebugMessage("Landed on uOrder Page");
                PropertyAdmin.uOrder_OrderSearchBox(eventName);
                VerifyTextOnPageAndHighLight(eventName);
                VerifyTextOnPageAndHighLight(status);
                Logger.WriteDebugMessage("Event is Displayed on the Admin Page");

                //Log test data
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Frontend Username", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Frontend Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Event Name", eventName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Event Validation", eventName_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Name ", function_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Validation ", functionName_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_No of Guest", noOf_Guests);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_No of Guest  Validation", noOfGuests_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Room", function_Room);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Type", function_Type);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Setup Style", setUp_Style);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menu_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Contact Name", contact);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Payment Method Name", payment_Method);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Status", status);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Admin User Name", propertyAdmin_Username, true);
            }
        }

        public static void TC_233084()
        {
            if (TestCaseId == Utility.Constants.TC_233084)
            {
                //Pre-Requisite
                string username, password, glutenFreeMenu_Name, mostPopularMenu_Name;
                Users data = new Users();

                //Retrieve data from Test data
                Queries.GetActiveMemberEmail(data);
                username = data.email;
                password = ProjectDetails.CommonFrontendPassword;
                glutenFreeMenu_Name = TestData.ExcelData.TestDataReader.ReadData(1, "GlutenFreeMenu_Name");
                mostPopularMenu_Name = TestData.ExcelData.TestDataReader.ReadData(1, "MostPopularMenu_Name");

                //Navigate to Sign In button
                Logger.WriteDebugMessage("Landed on Front End Page");
                Navigation.Click_SignIn();
                ElementWait(PageObject_SignIn.TextBox_Username(), 60);
                Logger.WriteDebugMessage("Landed on Front End Sign In Page");

                //Enter Valid User-name and password and Verify the user is able to sign in successfully
                SignIn.Frotnend_SignIn(username, password);
                ElementWait(PageObject_Navigation.Create_NewOrder(), 60);
                Logger.WriteDebugMessage("Log-in successfully with User-name = " + username + " and Password =" + password);

                // Click on logo and validate fliter functionality
                HomePage.HomePage_Filter(glutenFreeMenu_Name);
            }
        }
        public static void TC_232085()
        {
            if (TestCaseId == Utility.Constants.TC_232085)
            {
                //pre-requisite
                string username, password, eventName, eventName_Validation, functionName_Validation, noOfGuests_Validation, function_Name, noOf_Guests, function_Room, function_Type, setUp_Style, menu_Name, function_Comment, clone_functionName, clone_functionDate, randomnum, function_Name_Update, noOf_Guests_Update, function_Room_Update, function_Type_Update, setUp_Style_Update;

                Users data = new Users();
                Random rando = new Random();

                //Assign and Retrieve data
                Queries.GetActiveMemberEmail(data);
                username = data.email;
                password = ProjectDetails.CommonFrontendPassword;
                randomnum = rando.Next().ToString();
                eventName = String.Concat("TestEvent_", randomnum);
                eventName_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "EventName_Validation");
                functionName_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "FunctionName_Validation");
                noOfGuests_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "NoOfGuests_Validation");
                function_Name = String.Concat("TestFunction_", randomnum);
                noOf_Guests = TestData.ExcelData.TestDataReader.ReadData(1, "NoOf_Guests");
                function_Room = TestData.ExcelData.TestDataReader.ReadData(1, "Function_Room");
                function_Type = TestData.ExcelData.TestDataReader.ReadData(1, "Function_Type");
                setUp_Style = TestData.ExcelData.TestDataReader.ReadData(1, "SetUp_Style");
                menu_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Menu_Name");
                function_Comment = TestData.ExcelData.TestDataReader.ReadData(1, "Function_Comments");
                clone_functionName = String.Concat(function_Name, "Cloned");
                clone_functionDate = DateTime.Now.ToString("M/dd/yyyy");
                function_Name_Update = String.Concat(function_Name, "_Update");
                noOf_Guests_Update = TestData.ExcelData.TestDataReader.ReadData(1, "NoOf_Guests_Update");
                function_Room_Update = TestData.ExcelData.TestDataReader.ReadData(1, "Function_Room_Update");
                function_Type_Update = TestData.ExcelData.TestDataReader.ReadData(1, "Function_Type_Update");
                setUp_Style_Update = TestData.ExcelData.TestDataReader.ReadData(1, "SetUp_Style_Update");



                //Navigate to Sign In button
                Logger.WriteDebugMessage("Landed on Front End Page");
                Navigation.Click_SignIn();
                ElementWait(PageObject_SignIn.TextBox_Username(), 60);
                Logger.WriteDebugMessage("Landed on Front End Sign In Page");

                //Enter Valid User-name and password and Verify the user is able to sign in successfully
                SignIn.Frotnend_SignIn(username, password);
                ElementWait(PageObject_Navigation.Create_NewOrder(), 60);
                Logger.WriteDebugMessage("Log-in successfully with User-name = " + username + " and Password =" + password);

                //Create Order 
                MyOrders.MyOrdersCreateNewOrder(eventName, eventName_Validation);

                //Add Function to the Event
                EventDetails.AddFunction(functionName_Validation, noOfGuests_Validation, function_Name, noOf_Guests, function_Room, function_Type, setUp_Style);

                //Add Specif Menu to the Event
                EventDetails.AddMenu(menu_Name);

                //Add comments to the Function
                EventDetails.Function_Add_Comments(function_Comment);

                //Edit the Existing Function 
                EventDetails.Function_Edit_Function(function_Name_Update, noOf_Guests_Update, function_Room_Update, function_Type_Update, setUp_Style_Update);

                //Clone the Function
                EventDetails.Function_Copy_Function(clone_functionName, clone_functionDate);

                //Delete Function
                EventDetails.Function_Delete_Function(clone_functionName);

                //Log test data in Test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Event Name", eventName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Event Validation", eventName_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Name", function_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Validation", functionName_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_No of Guest", noOf_Guests);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_No of Guest  Validation", noOfGuests_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Room", function_Room);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Type", function_Type);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Setup Style", setUp_Style);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Comment", function_Comment);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Updated Function Name", function_Name_Update);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Updated No of Guest", noOf_Guests_Update);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Updated Function Room", function_Room_Update);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Updated Function Type", function_Type_Update);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Updated Setup Style", setUp_Style_Update);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Cloned Function Name", clone_functionName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Cloned Function Date", clone_functionDate, true);

            }
        }
        public static void TC_232083()
        {
            if (TestCaseId == Utility.Constants.TC_232083)
            {
                //pre-requisite
                string username, password, eventName, eventName_Validation, functionName_Validation, noOfGuests_Validation, function_Name, noOf_Guests, function_Room, function_Type, setUp_Style, menu_Name, randomnum, quantity, specialrequest;

                Users data = new Users();
                Random rando = new Random();

                //Assign and Retrieve data
                Queries.GetActiveMemberEmail(data);
                username = data.email;
                password = ProjectDetails.CommonFrontendPassword;
                randomnum = rando.Next().ToString();
                eventName = String.Concat("TestEvent_", randomnum);
                eventName_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "EventName_Validation");
                functionName_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "FunctionName_Validation");
                noOfGuests_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "NoOfGuests_Validation");
                function_Name = String.Concat("TestFunction_", randomnum);
                noOf_Guests = TestData.ExcelData.TestDataReader.ReadData(1, "NoOf_Guests");
                function_Room = TestData.ExcelData.TestDataReader.ReadData(1, "Function_Room");
                function_Type = TestData.ExcelData.TestDataReader.ReadData(1, "Function_Type");
                setUp_Style = TestData.ExcelData.TestDataReader.ReadData(1, "SetUp_Style");
                menu_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Menu_Name");
                quantity = TestData.ExcelData.TestDataReader.ReadData(1, "Menu_Quantity");
                specialrequest = TestData.ExcelData.TestDataReader.ReadData(1, "Menu_Special_Request");


                //Navigate to Sign In button
                Logger.WriteDebugMessage("Landed on Front End Page");
                Navigation.Click_SignIn();
                ElementWait(PageObject_SignIn.TextBox_Username(), 60);
                Logger.WriteDebugMessage("Landed on Front End Sign In Page");

                //Enter Valid User-name and password and Verify the user is able to sign in successfully
                SignIn.Frotnend_SignIn(username, password);
                ElementWait(PageObject_Navigation.Create_NewOrder(), 60);
                Logger.WriteDebugMessage("Log-in successfully with User-name = " + username + " and Password =" + password);

                //Create Order 
                MyOrders.MyOrdersCreateNewOrder(eventName, eventName_Validation);

                //Add Function to the Event
                EventDetails.AddFunction(functionName_Validation, noOfGuests_Validation, function_Name, noOf_Guests, function_Room, function_Type, setUp_Style);

                //Add Specif Menu to the Event
                EventDetails.AddMenu(menu_Name);

                //Edit Menu Item
                EventDetails.Menu_Edit_Menu(quantity, specialrequest);

                //Copy Menu Item
                EventDetails.Menu_Copy_menu(function_Name);

                //Delete Menu Item
                EventDetails.Menu_Delete_Menu();

                //Log test data in Test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Event Name", eventName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Event Validation", eventName_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Name", function_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Validation", functionName_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_No of Guest", noOf_Guests);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_No of Guest  Validation", noOfGuests_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Room", function_Room);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Function Type", function_Type);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Setup Style", setUp_Style);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Updated Menu Quantity", quantity);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Added Special Request", specialrequest, true);

            }
        }        
    
        public static void TC_231935()
        {
            if (TestCaseId == Utility.Constants.TC_231935)
            {
                //Pre-Requisite
                string password, propertyName, propertyAdmin_Username, menuName, price, priceDescription, dynamicPrice, dynamicPriceDescription, randomNumber, dynamicPriceName, startdate, enddate;
               
                Random radno = new Random();
               

                //Retrive data from Database or testdata file
                randomNumber = radno.Next().ToString();
                password = ProjectDetails.CommonFrontendPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                menuName = String.Concat("Menu_", randomNumber);
                price = TestData.ExcelData.TestDataReader.ReadData(1, "Price");
                priceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "PriceDescription");
                dynamicPrice = TestData.ExcelData.TestDataReader.ReadData(1, "DynamicPrice");
                dynamicPriceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "DynamicPriceDescription");
                dynamicPriceName = String.Concat("DynamicPriceName_", randomNumber);
                startdate = DateTime.Now.ToString("MM/dd/yyyy");
                enddate = DateTime.Now.AddDays(3).ToString("MM/dd/yyyy");

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

               //Navigate to Settings and Dynamic Price Page
                PropertyAdmin.Click_MyMenu_Settings();
                ElementWait(PageObject_PropertyAdmin.Click_Settings_DynamicPricing(), 30);
                Logger.WriteDebugMessage("Navigate to Advance settings page");
                PropertyAdmin.Click_Settings_DynamicPricing();
                ElementWait(PageObject_PropertyAdmin.Click_DynamicPricing_AddNewButton(), 30);
                Logger.WriteDebugMessage("Navigate to Advance settings page");


                //Add New Dynamic Price
                PropertyAdmin.AddNewDynamicPricing(dynamicPriceName, startdate, enddate);

                //Navigate to My Menu Page and Add New Menu with Dynamic Price
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menu ");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                PropertyAdmin.AddNewMenu(menuName, price, priceDescription, dynamicPrice, dynamicPriceDescription);

                //View Menu on PDF Mode
                PropertyAdmin.Preview_PDF_View("Continental Breakfast", menuName);

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Frontend 
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigated to Front-end Site");

                
                //Navigate to Specific Menu
                HomePage.HomePage_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast menu");
                HomePage.HomePage_Select_ContinentalBreakfast();
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Navigated to Continental Breakfast Sub-menu and Added Menu is displaying");

                HomePage.Select_Event_date(enddate);

                //Verify the Display of Dynamic Price 

                AddDelay(10000);
                string menuPrice = HomePage.Get_Continental_Menu_Price(menuName);
                if(menuPrice.Contains(dynamicPrice) && menuPrice.Contains(dynamicPriceDescription))
                {
                    Logger.WriteDebugMessage("Dynamic Price is displaying for the Menu");
                }
                else
                {
                    Assert.Fail("Default Price is displaying for the Menu");
                }

                //Navigate Back to Admin and Delete the Added Dynamic Price
                Helper.ControlToPreviousWindow();
                PropertyAdmin.Delete_DyanamicPrice(dynamicPriceName);

                //Navigate to Category and Delete Menu
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menu ");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(menuName);

                //Log test data in Test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Admin Username", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price Name", dynamicPriceName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price Start Date", startdate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price End Date", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price", price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price Description", priceDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price", dynamicPrice);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price Description", dynamicPriceDescription, true);
            }
        }
        public static void TC_231936()
        {
            if (TestCaseId == Utility.Constants.TC_231936)
            {
                //Pre-Requisite
                string  password, propertyName, propertyAdmin_Username, menuName, price, priceDescription, dynamicPrice, dynamicPriceDescription, randomNumber, dynamicPriceName, startdate, enddate,lastaddedDynamicPrice;
               
                Random radno = new Random();
               
                //Retrive data from Database or testdata file
                randomNumber = radno.Next().ToString();
                password = ProjectDetails.CommonFrontendPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                menuName = String.Concat("Menu_", randomNumber,"_Updated");
                price = TestData.ExcelData.TestDataReader.ReadData(1, "Price");
                priceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "PriceDescription");
                dynamicPrice = TestData.ExcelData.TestDataReader.ReadData(1, "DynamicPrice");
                dynamicPriceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "DynamicPriceDescription");
                dynamicPriceName = String.Concat("DynamicPriceName_", randomNumber);
                startdate = DateTime.Now.AddDays(20).ToString("MM/dd/yyyy");
                enddate = DateTime.Now.AddDays(21).ToString("MM/dd/yyyy");

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to Settings and Dynamic Price Page
                PropertyAdmin.Click_MyMenu_Settings();
                ElementWait(PageObject_PropertyAdmin.Click_Settings_DynamicPricing(), 30);
                Logger.WriteDebugMessage("Navigate to Advance settings page");
                PropertyAdmin.Click_Settings_DynamicPricing();
                ElementWait(PageObject_PropertyAdmin.Click_DynamicPricing_AddNewButton(), 30);
                Logger.WriteDebugMessage("Navigate to Advance settings page");

                //Add new Dynamic Price for Edit purpose
                PropertyAdmin.AddNewDynamicPricing(dynamicPriceName, startdate, enddate);

                //Edit the Existing Dynamic Price
                lastaddedDynamicPrice = PropertyAdmin.Recentlyadded_DynamicPrice();
                PropertyAdmin.EditDynamicPricing(lastaddedDynamicPrice, startdate, enddate);

                //Navigate to My Menu Page and Edit New Menu with Dynamic Price
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menu ");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                try
                {
                    PropertyAdmin.Click_MyMenu_EditMenu();
                    PropertyAdmin.EditMenu(menuName, price, priceDescription, dynamicPrice, dynamicPriceDescription);
                }
                catch
                {
                    PropertyAdmin.AddNewMenu(menuName, price, priceDescription, dynamicPrice, dynamicPriceDescription);
                }

                //View Menu on PDF Mode
                PropertyAdmin.Preview_PDF_View("Continental Breakfast", menuName);

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Frontend 
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigated to Front-end Site");

                //Navigate to Specific Menu
                HomePage.HomePage_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast menu");
                HomePage.HomePage_Select_ContinentalBreakfast();
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Navigated to Continental Breakfast Sub-menu and Added Menu is displaying");

                HomePage.Select_Event_date(enddate);

                //Verify the Display of Dynamic Price 
                AddDelay(10000);
                string menuPrice = HomePage.Get_Continental_Menu_Price(menuName);
                if (menuPrice.Contains(dynamicPrice) && menuPrice.Contains(dynamicPriceDescription))
                {
                    Logger.WriteDebugMessage("Dynamic Price is displaying for the Menu");
                }
                else
                {
                    Assert.Fail("Default Price is displaying for the Menu");
                }

                //Navigate Back to Admin and Delete the Added Dynamic Price
                Helper.ControlToPreviousWindow();
                PropertyAdmin.Delete_DyanamicPrice(lastaddedDynamicPrice);

                //Navigate to Category and Delete Menu
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menu ");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(menuName);

                //Log test data in Test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Admin Username", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price Name", dynamicPriceName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price Start Date", startdate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price End Date", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price", price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price Description", priceDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price", dynamicPrice);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price Description", dynamicPriceDescription, true);
            }
        }
        public static void TC_231937()
        {
            if (TestCaseId == Utility.Constants.TC_231937)
            {
                //Pre-Requisite
                string password, propertyName, propertyAdmin_Username, menuName, price, priceDescription, dynamicPrice, dynamicPriceDescription, randomNumber, dynamicPriceName, startdate, enddate;
                
                Random radno = new Random();
                

                //Retrieve data from Database or testdata file
                randomNumber = radno.Next().ToString();
                password = ProjectDetails.CommonFrontendPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                menuName = String.Concat("Menu_", randomNumber);
                price = TestData.ExcelData.TestDataReader.ReadData(1, "Price");
                priceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "PriceDescription");
                dynamicPrice = TestData.ExcelData.TestDataReader.ReadData(1, "DynamicPrice");
                dynamicPriceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "DynamicPriceDescription");
                dynamicPriceName = String.Concat("DynamicPriceName_", randomNumber);
                startdate = DateTime.Now.AddDays(3).ToString("MM/dd/yyyy");
                enddate = DateTime.Now.AddDays(6).ToString("MM/dd/yyyy");

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to Settings and Dynamic Price Page
                PropertyAdmin.Click_MyMenu_Settings();
                ElementWait(PageObject_PropertyAdmin.Click_Settings_DynamicPricing(), 30);
                Logger.WriteDebugMessage("Navigate to Advance settings page");
                PropertyAdmin.Click_Settings_DynamicPricing();
                ElementWait(PageObject_PropertyAdmin.Click_DynamicPricing_AddNewButton(), 30);
                Logger.WriteDebugMessage("Navigate to Advance settings page");


                //Add New Dynamic Price
                PropertyAdmin.AddNewDynamicPricing(dynamicPriceName, startdate, enddate);

                //Navigate to My Menu Page and Add New Menu with Dynamic Price
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menu ");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                PropertyAdmin.AddNewMenu(menuName, price, priceDescription, dynamicPrice, dynamicPriceDescription);

                //View Menu on PDF Mode
                PropertyAdmin.Preview_PDF_View("Continental Breakfast", menuName);

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end 
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigated to Front-end Site");

               //Navigate to Specific Menu
                HomePage.HomePage_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast menu");
                HomePage.HomePage_Select_ContinentalBreakfast();
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Navigated to Continental Breakfast Sub-menu and Added Menu is displaying");

                HomePage.Select_Event_date(enddate);

                //Verify the Display of Dynamic Price 
                AddDelay(10000);
                string menuPrice = HomePage.Get_Continental_Menu_Price(menuName);
                if (menuPrice.Contains(dynamicPrice) && menuPrice.Contains(dynamicPriceDescription))
                {
                    Logger.WriteDebugMessage("Dynamic Price is displaying for the Menu");
                }
                else
                {
                    Assert.Fail("Default Price is displaying for the Menu");
                }

                //Navigate Back to Admin and Delete the Added Dynamic Price
                Helper.ControlToPreviousWindow();
                PropertyAdmin.Delete_DyanamicPrice(dynamicPriceName);

                //Verify the Dynamic Menu is removed from Add Menu Overlay
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menu ");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                PropertyAdmin.Verify_DeleteMenu(menuName, price, priceDescription, dynamicPrice, dynamicPriceDescription);

                //Navigate back to Front-end and Reload the page
                Helper.ControlToNextWindow();
                Logger.WriteDebugMessage("Landed on Front-end Page");
                Helper.ReloadPage();
                Logger.WriteDebugMessage("Page reloaded successfully");

                //Navigate to Menu and Check for the Default price
                HomePage.HomePage_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast menu");
                HomePage.HomePage_Select_ContinentalBreakfast();
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Navigated to Continental Breakfast Sub-menu and Added Menu is displaying");

                HomePage.Select_Event_date(enddate);

                
                AddDelay(10000);
                menuPrice = HomePage.Get_Continental_Menu_Price(menuName);
                if (menuPrice.Contains(price) && menuPrice.Contains(priceDescription))
                {
                    Logger.WriteDebugMessage("Default Price is displaying for the Menu");
                }
                else
                {
                    Assert.Fail("Dynamic price is Displaying for the menu");
                }

                //Log test data in Test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Admin Username", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price Name", dynamicPriceName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price Start Date", startdate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price End Date", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price", price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price Description", priceDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price", dynamicPrice);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price Description", dynamicPriceDescription, true);
            }
        }
        public static void TC_231938()
        {
            if (TestCaseId == Utility.Constants.TC_231938)
            {
                //Pre-Requisite
                string username, password, propertyName, propertyAdmin_Username, menuName, price, priceDescription, dynamicPrice, dynamicPriceDescription, randomNumber, dynamicPriceName, startdate, enddate, admin_menuPrice, admin_menuPrice_afterdynamic_price;
                Users data = new Users();
                Random radno = new Random();
                Queries.GetActiveMemberEmail(data);

                //Retrieve data from Database or testdata file
                randomNumber = radno.Next().ToString();
                username = data.email;
                password = ProjectDetails.CommonFrontendPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                menuName = String.Concat("Menu_", randomNumber);
                price = TestData.ExcelData.TestDataReader.ReadData(1, "Price");
                priceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "PriceDescription");
                dynamicPrice = TestData.ExcelData.TestDataReader.ReadData(1, "DynamicPrice");
                dynamicPriceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "DynamicPriceDescription");
                dynamicPriceName = String.Concat("DynamicPriceName_", randomNumber);
                startdate = DateTime.Now.ToString("MM/dd/yyyy");
                enddate = DateTime.Now.AddDays(6).ToString("MM/dd/yyyy");

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Capture the Menu Price for the Menu
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menu ");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                admin_menuPrice = PropertyAdmin.Existing_MenuPrice();
                Logger.WriteDebugMessage("Default Menu Price = " + admin_menuPrice);
                Helper.ExitFrame();
                
                //Navigate to Settings and Dynamic Price Page
                PropertyAdmin.Click_MyMenu_Settings();
                ElementWait(PageObject_PropertyAdmin.Click_Settings_DynamicPricing(), 30);
                Logger.WriteDebugMessage("Navigate to Advance settings page");
                PropertyAdmin.Click_Settings_DynamicPricing();
                ElementWait(PageObject_PropertyAdmin.Click_DynamicPricing_AddNewButton(), 30);
                Logger.WriteDebugMessage("Navigate to Advance settings page");


                //Add New Dynamic Price
                PropertyAdmin.AddNewDynamicPricing(dynamicPriceName, startdate, enddate);

                //Navigate back to My Menu Page and Edit  Menu with Dynamic Price
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menu ");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                PropertyAdmin.Click_MyMenu_EditMenu();
                PropertyAdmin.EditMenu(menuName, price, priceDescription, dynamicPrice, dynamicPriceDescription);

                //View Menu on PDF Mode
                PropertyAdmin.Preview_PDF_View("Continental Breakfast", menuName);

                //Verify the Menu Price after Updating the Menu
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menu ");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                admin_menuPrice_afterdynamic_price = PropertyAdmin.Existing_MenuPrice();
                Helper.ExitFrame();

                if (admin_menuPrice.Equals(admin_menuPrice_afterdynamic_price))
                    Assert.Fail("Dynamic Price does not Overrides the Default Price in Admin");
                Logger.WriteDebugMessage("Dynamic Price Overrides the Default Price in Admin");

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end 
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigated to Front-end Site");

                //Login to Front-end
                Navigation.Click_SignIn();
                ElementWait(PageObject_SignIn.TextBox_Username(), 60);
                Logger.WriteDebugMessage("Landed on Front End Sign In Page");

                //Enter Valid User-name and password and Verify the user is able to sign in successfully
                SignIn.Frotnend_SignIn(username, password);
                ElementWait(PageObject_Navigation.Create_NewOrder(), 60);
                Logger.WriteDebugMessage("Log-in successfully with User-name = " + username + " and Password =" + password);
                HomePage.Click_HotelOrigami_Logo();
                Logger.WriteDebugMessage("User should able to navigate to Home page");

                //Navigate to Specific Menu
                HomePage.HomePage_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast menu");
                HomePage.HomePage_Select_ContinentalBreakfast();
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Navigated to Continental Breakfast Sub-menu and Added Menu is displaying");

                HomePage.Select_Event_date(startdate);

                //Verify the Display of Dynamic Price 
                AddDelay(10000);
                string menuPrice = HomePage.Get_Continental_Menu_Price(menuName);
                if (menuPrice.Contains(dynamicPrice) && menuPrice.Contains(dynamicPriceDescription))
                {
                    Logger.WriteDebugMessage("Dynamic Price is displaying for the Menu");
                }
                else
                {
                    Assert.Fail("Default Price is displaying for the Menu");
                }

                //Navigate Back to Admin and Delete the Added Dynamic Price
                Helper.ControlToPreviousWindow();
                PropertyAdmin.Delete_DyanamicPrice(dynamicPriceName);

             
                //Log test data in Test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", data.email);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Admin Username", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price Name", dynamicPriceName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price Start Date", startdate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price End Date", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price", price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price Description", priceDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price", dynamicPrice);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price Description", dynamicPriceDescription, true);
            }
        }
    }

}
