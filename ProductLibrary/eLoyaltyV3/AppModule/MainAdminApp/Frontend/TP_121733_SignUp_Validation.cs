using eLoyaltyV3.Utility;
using eLoyaltyV3.AppModule.UI;
using Common;
using Constants = eLoyaltyV3.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eLoyaltyV3.Utility.Setup
    {
        #region TP_121733 - SignUpValidation
        public static void TC_119763()
        {
            if (TestCaseId == Constants.TC_119763)
                {
                    // Pre-Requisites
                    string Password_Error, Fieldvalidation, FirstName, LastName, Email, Card, Password, Confirm;

                    Fieldvalidation = TestData.ExcelData.TestDataReader.ReadData(1, "Validationmessage");
                    FirstName = TestData.ExcelData.TestDataReader.ReadData(1, "FirstName");
                    LastName = TestData.ExcelData.TestDataReader.ReadData(1, "LastName");
                    Email = TestData.ExcelData.TestDataReader.ReadData(1, "Email");
                    Card = TestData.ExcelData.TestDataReader.ReadData(1, "Card");

                    Logger.WriteDebugMessage("Landed on the Sign In Page.");

                    //2 Navigate to the Sign Up page
                    Navigation.Navigation_SignUpbtn();


                    // Verify the Validation message with different type of Invalid Password (ccendyn1, CCENDYN1, cCCENDYN, Cendyn1, Cendyn@@, ccendyn1@@)
                    for (int i = 1; i < 7; i++)
                    {
                        Logger.WriteDebugMessage("Landed on Sign Up Page");

                        Password = TestData.ExcelData.TestDataReader.ReadData(i, "Scenario");
                        Confirm = TestData.ExcelData.TestDataReader.ReadData(i, "Confirm");
                        // Enter All mandatory Fields
                        if (i == 1)
                            SignUp.EnterAllMandatoryFields(FirstName, LastName, Email, Card, Password, Confirm, ProjectName);
                        else
                            SignUp.EnterPasswordOnSignUp(Password, Confirm);
                        SignUp.ClickOnSignUpEyeBall();
                        Logger.WriteDebugMessage("Entered All Mandatory Fields");
                        // Click on Join Now
                        Navigation.SignUp_Button_Join();
                        // Validate the Validation message for password field
                        Password_Error = Navigation.Password_Error();
                        SignUp.VerifyInvalidPasswordMessage(Fieldvalidation, Password_Error);
                        ///Helper.ReloadPage();
                }
            }            
        }

        public static void TC_119764()
        {
            if (TestCaseId == Constants.TC_119764)
            {
                //1.URL is available in Test plan run descrition
                //2.Data Requirement: email that was already register Note: Register an email to get data if you don't have one
                Logger.WriteDebugMessage("Landed on the Sign In Page.");

                //3.Navigate to Sign in page
                //4.Click on Sign up
                Navigation.Navigation_SignUpbtn();
                Logger.WriteDebugMessage("Landed on the Sign Up page.");

                //5.Enter all mandatory fields by entering email address as identified in step 2 and select I agree to the Terms and Conditions
                //6.Click on Sign up
                SignUp.ValidateSigningUpWithExistingEmail(ProjectName);
                Logger.WriteInfoMessage("Message confirming that email address already exist should display");
                Logger.WriteInfoMessage("User is unable to sign up using existing registered email addresses");
            }

        }

        public static void TC_119765()

        {
            if (TestCaseId == Constants.TC_119765)
            {
                //1.URL is available in Test plan descrition
                Logger.WriteDebugMessage("Landed on the Sign In Page.");
                string firstName, lastname, email, incorrectPassword;
                firstName = TestData.ExcelData.TestDataReader.ReadData(1, "FirstName");
                lastName = TestData.ExcelData.TestDataReader.ReadData(1, "LastName");
                email = TestData.ExcelData.TestDataReader.ReadData(1, "Email");
                incorrectPassword = TestData.ExcelData.TestDataReader.ReadData(1, "IncorrectConfirmPass");
                //2 Navigate to the Sign Up page
                //3.Click on Sign up
                Navigation.Navigation_SignUpbtn();
                Logger.WriteDebugMessage("Landed on the Sign Up page.");

                //4.Enter all mandatory fields: 1.select I agree to the Terms and Conditions 2.Enter mismatch detail in password and Confirm PasswordMismatch Password should get displayed
                //5.Click on Sign up
                SignUp.SignUpMisMatchPassword(firstName, lastName, email, ProjectDetails.CommonFrontendPassword, incorrectPassword);
                Logger.WriteInfoMessage("User is unable to sign up using non-matching passwords.");
                Logger.WriteInfoMessage("Message confirming that password fields are not matching should display");
            }
        }

        public static void TC_119766()
        {
            if (TestCaseId == Constants.TC_119766)
            {
                //1.URL is available in master Test plan  run descrition
                Logger.WriteDebugMessage("Landed on the Sign In Page.");

                //2. Navigate to the Sign Up page
                Navigation.Navigation_SignUpbtn();
                Logger.WriteDebugMessage("Landed on the Sign Up page.");

                //3.Enter required details of member, Enter Birth date with birth year  = 1999  and click on <Sign Up>
                string email = Helper.CommonUniqueTestCatchAll();
                SignUp.SignUpExactly18YearsOld(email);
                Logger.WriteDebugMessage("Able to sign up with a birthday of today.");

                //4.Login to User's mail account/Catchall and look for Activation Email 
                //5.Click on Verify my email

                Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(email);
                Email.ActivationEmail_Check(ProjectName);
                Logger.WriteDebugMessage("The activation email was received.");
                Email.ActivationEmail_ClickLink(ProjectName);
                AddDelay(7000);
                Logger.WriteDebugMessage("Confirmation message regarding account being confirmed is displayed.");

                //6.Verify Welcome email gets generated
                ControlToNewWindow();
                CloseCurrentTab();
                ControlToPreviousWindow();
                Driver.Navigate().GoToUrl("https://outlook.office365.com/owa/?realm=cendyn17.com&exsvurl=1&ll-cc=1033&modurl=0");
                Logger.WriteDebugMessage("Users is redirected to Catch all mail");

                //7.Click on the link in Welcome email
                AddDelay(5000);
                Email.CatchAll_SearchEmailAndOpenLatestMessage(email);
                Email.WelcomeEmail_Check(ProjectName);
                Logger.WriteDebugMessage("The welcome email was delivered.");
                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                Logger.WriteDebugMessage("User landed on the Sign In page after clicking the Welcome Email link.");

                //8.Enter the login credential created in previous steps
                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                SignIn.LogIn(email, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Sign in should be successful User landed on Overview page");

                //9.Observe Membership from Left Sidebar
                SignIn.ValidateMembershipLevel(ProjectName);

                //10.Observe Member Since date from Left Sidebar
                if (ProjectName != "NYLO" && ProjectName != "AdareManor")
                {
                    SignIn.ValidateMembershipSince();
                    Logger.WriteDebugMessage("Member Since date should be todays date");
                }
                else
                {
                    Logger.WriteDebugMessage("Member since date is NOT displayed for" + ProjectName);
                }
            }
        }

        public static void TC_119767()
        {
            if (TestCaseId == Constants.TC_119767)
            {
                Logger.WriteDebugMessage("Landed on the Sign In Page.");
                //2 Navigate to the Sign Up page
                Navigation.Navigation_SignUpbtn();
                Logger.WriteDebugMessage("Landed on the Sign Up page.");

                //3 Validate signing up exactly at 18 years
                string email = Helper.CommonUniqueTestCatchAll();
                SignUp.SignUpOlderThan18Years(email);
                Logger.WriteDebugMessage("Able to sign up with a birthday greater than 18 years.");

                //4.Login to User's mail account/Catchall and look for Activation Email 
                //5.Click on Verify my email
                Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(email);
                Email.ActivationEmail_Check(ProjectName);
                Logger.WriteDebugMessage("The activation email was received.");
                Email.ActivationEmail_ClickLink(ProjectName);
                AddDelay(7000);
                Logger.WriteDebugMessage("Confirmation message regarding account being confirmed is displayed.");

                //6.Verify Welcome email gets generated
                ControlToNewWindow();
                CloseCurrentTab();
                ControlToPreviousWindow();
                Driver.Navigate().GoToUrl("https://outlook.office365.com/owa/?realm=cendyn17.com&exsvurl=1&ll-cc=1033&modurl=0");

                //7.Click on the link in Welcome email
                AddDelay(5000);
                Email.CatchAll_SearchEmailAndOpenLatestMessage(email);
                Email.WelcomeEmail_Check(ProjectName);
                Logger.WriteDebugMessage("The welcome email was delivered.");
                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                Logger.WriteDebugMessage("User landed on the Sign In page after clicking the Welcome Email link.");

                //8.Enter the login credential created in previous steps
                //Driver.Navigate().GoToUrl(TestData.CommonFrontendURL);
                SignIn.LogIn(email, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Sign in should be successful User landed on Overview page");

                //9.Observe Membership from Left Sidebar
                SignIn.ValidateMembershipLevel(ProjectName);

                //10.Observe Member Since date from Left Sidebar
                if (ProjectName != "NYLO" && ProjectName != "AdareManor")
                {
                    SignIn.ValidateMembershipSince();
                    Logger.WriteDebugMessage("Member Since date should be todays date");
                }
                else
                {
                    Logger.WriteDebugMessage("Member since date is NOT displayed for" + ProjectName);
                }
            }
        }

        public static void TC_119768()
        {
            if (TestCaseId == Constants.TC_119768)
            {
                string firstName, lastName;
                firstName = TestData.ExcelData.TestDataReader.ReadData(1, "FirstName");
                lastName = TestData.ExcelData.TestDataReader.ReadData(1, "LastName");
                Logger.WriteDebugMessage("Landed on the Sign In Page.");
                //2 Navigate to the Sign Up page
                Navigation.Navigation_SignUpbtn();
                Logger.WriteDebugMessage("Landed on the Sign Up page.");

                //3 Validate signing up exactly at 18 years
                SignUp.SignUpLessThan18Years(firstName, lastName);
                Logger.WriteDebugMessage("Not to sign up with a birthday less than 18 years.");
            }
        }
        #endregion  
    }
}
