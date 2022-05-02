//using BaseUtility.Utility;
using eLoyaltyV3.AppModule.UI;
using eLoyaltyV3.Entity;
using eLoyaltyV3.PageObject.UI;
using eLoyaltyV3.Utility;
using InfoMessageLogger;
using TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using BaseUtility.Utility;
using Queries = eLoyaltyV3.Utility.Queries;
using TestData.ExcelData;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region TP_121746 - Sign In Page
        public static void TC_119819()
        {
            if (TestCaseId == Utility.Constants.TC_119819)
            {
                //1.URL and Database detail is available in Master Test plan run 
                //2.Navigate to login page 
                //3.Enter valid credential and click on sign in      
                //*Added this code as per changes for R#208647 for HotelIcon Client*//
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);
                email = data.MemberEmail;

                LoginCredentials(email, ProjectDetails.CommonFrontendPassword, ProjectName);
                if (Driver.Url != LoginLand)
                {
                    if (VerifyTextOnPage("Welcome"))
                    {
                        Logger.WriteDebugMessage("Landed on Login Page");
                    }
                    else
                    {
                        Assert.Fail("Login was not successfull.");
                    }
                }
                //03/04/2018 : Divya : Made Changes as per Fraser Flow
                if (ProjectName.Equals("Fraser") || ProjectName.Equals("Iberostar") || ProjectName.Equals("HotelOrigami"))
                {
                    ElementWait(PageObject_Navigation.Link_MyAccount(), 60);
                }
                else
                {
                    if (ProjectName.Equals("Sarova") || ProjectName.Equals("EHPC"))
                    {
                        ElementWait(PageObject_Navigation.LinkText_MySettings(ProjectName), 60);
                    }
                    else
                    {
                        ElementWait(PageObject_Navigation.Link_MySettings(), 60);
                    }
                }
            }
            else if (Drivers.Value.Url == LoginLand)
            {
                if (IsElementVisible(PageObject_Navigation.Link_MySettings()) ||
                    IsElementVisible(PageObject_Navigation.LinkText_MySettings(ProjectName)) ||
                    IsElementVisible(PageObject_Navigation.Link_MyAccount()))
                {
                    string PageTitle = Drivers.Value.Title;
                    RegexFunction(PageTitle, pattern);
                }
                else
                {
                    Assert.Fail("Login was not successfull.");
                }
            }
            Logger.WriteDebugMessage("Sign in should be successful");
            Logger.LogTestData(TestPlanId, TestCaseId, "Email", email, true);
        }

        public static void TC_119820()
        {
            if (TestCaseId == Constants.TC_119820)
            {
                Users data = new Users();
                //1.URL and Database detail is available in Master Test plan run 
                //2.Navigate to login page 
                //3.Enter unregistered  email  and password as Cendyn123$
                //*Added this code as per changes for R#208647 for HotelIcon Client*//
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                Queries.GetNonActiveUser(data);
                LoginCredentials(data.eMail, ProjectDetails.CommonFrontendPassword, ProjectName);
                AddDelay(5000);
                if (VerifyTextOnPage(Constants.SignIn_ValidationMessageNotActivateUser))
                {
                    Logger.WriteDebugMessage("User was not able login with Unregistered email " + data.eMail);
                }
                else
                {
                    Assert.Fail("User was successfull able to login with an unregistered email:" + data.eMail);
                }

                Logger.WriteDebugMessage("User should not be able to sign in");
                Logger.LogTestData(TestPlanId, TestCaseId, "Email", data.eMail, true);
            }
        }

        public static void TC_119821()
        {
            if (TestCaseId == Constants.TC_119821)
            {
                //1.URL and Database detail is available in Master Test plan run 
                //2.Navigate to login page 
                //3.Enter registered email  and incorrect password                
                Users data = new Users();
                string InValidPass = randomNumber.Next().ToString() + "Cendyn123.";
                //*Added this code as per changes for R#208647 for HotelIcon Client*//
                Queries.GetActiveMemberEmail(data);
                email = data.MemberEmail;
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                LoginCredentials(email, InValidPass, ProjectName);

                if (VerifyTextOnPage(Constants.SignIn_InValidPass) ||
                    VerifyTextOnPage("Please enter valid credentials"))
                {
                    Logger.WriteDebugMessage("User was not able to login with invalid password " + InValidPass);
                }
                else
                {
                    Assert.Fail("User was able to login with invalid password:" + InValidPass);
                }

                Logger.WriteDebugMessage("Message display confirming incorrect credential");
                Logger.LogTestData(TestPlanId, TestCaseId, "Email", data.MemberEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Invalid Password", InValidPass, true);
            }
        }

        public static void TC_119822()
        {
            if (TestCaseId == Constants.TC_119822)
            {
                //Pre-requisites
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);
                string userName = "  " + data.MemberEmail + "  ";

                //1.URL and Database detail is available in Master Test plan run 
                //2.Navigate to login page 
                //3.Enter registered email with white space in front and end of the email   and its password                
                //*Added this code as per changes for R#208647 for HotelIcon Client*//

                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                LoginCredentials(userName, ProjectDetails.CommonFrontendPassword, ProjectName);

                AddDelay(10000);
                if (!Driver.Url.Contains(LoginLand))
                {
                    MySettingWait(ProjectName);
                }

                if (ProjectName != "Fraser")
                {
                    if (Driver.Url == LoginLand || IsElementVisible(PageObject_Navigation.Link_MySettings()))
                    {
                        string PageTitle = Driver.Title;
                        RegexFunction(PageTitle, pattern);
                    }
                }
                else if (ProjectName == "Fraser")
                {
                    if (IsElementDisplayed(PageObject_Navigation.Link_MyAccount()))
                    {
                        string PageTitle = Driver.Title;
                        RegexFunction(PageTitle, pattern);
                    }
                }
                else
                {
                    Assert.Fail("Login was not successfull.");
                }

                Logger.WriteDebugMessage("user should be able to sign in. Side bar gets displayed in landing page ");
                Logger.LogTestData(TestPlanId, TestCaseId, "Email", userName, true);
            }
        }

        public static void TC_119823()
        {
            if (TestCaseId == Constants.TC_119823)
            {
                //1.URL and Database detail is available in Master Test plan run 
                //2.Navigate to login page 
                //3.Verify the element present in Sign in page 
                //*Added this code as per changes for R#208647 for HotelIcon Client*//
                Users data = new Users();
                if (ProjectName.Equals("HotelOrigami") || ProjectName.Equals("Sacher") || ProjectName.Equals("MyPlace"))
                {
                    Navigation.Click_Button_JoinNow();
                }
                else if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_JoinNowButton();
                }
                else if (ProjectName.Equals("Bartell"))
                {
                    Navigation.Click_Link_SignIn();
                }
                else
                {
                    Navigation.Navigation_SignUpbtn();
                }
                if (!ProjectName.Equals("Bartell"))
                {
                    ElementWait(PageObject_SignUp.Button_Join(), 60);
                }
                //03/04/2018 : Divya : Modified as per Fraser Flow
                bool SignUpGetURL;
                if (ProjectName.Equals("Fraser") || ProjectName.Equals("HotelVic") || ProjectName.Equals("Loews") || ProjectName.Equals("HotelOrigami") || ProjectName.Equals("Sacher"))
                {
                    SignUpGetURL = Driver.Url.Contains("SignUp");
                }
                else if (ProjectName.Equals("HotelIcon") || ProjectName.Equals("MyPlace"))
                {
                    SignUpGetURL = Driver.Url.Contains("Login");
                }
                else if (ProjectName.Equals("Bartell"))
                {
                    SignUpGetURL = Driver.Url.Contains("signin");
                }
                else
                {
                    SignUpGetURL = Driver.Url.Contains("signup");
                }

                if (SignUpGetURL == true)
                {
                    Logger.WriteDebugMessage("Landed on SignUp Page.");
                    if (ProjectName.Equals("IndependentCollection"))
                    {
                        SignUp.Click_Link_SignIn();
                    }
                    else if (ProjectName.Equals("HotelIcon"))
                    {
                        //*Added this code as per changes for R#208647 for HotelIcon Client*//
                        SignUp.Click_Icon_Close();
                        Navigation.Click_Button_SignIn();
                    }
                    else
                    {
                        Navigation.Click_Link_SignIn();
                    }

                    if ((Helper.IsElementPresent(By.XPath("//input[@value='Log In']")) ||
                         Helper.IsElementPresent(By.XPath("//input[@id='btnValidateLogin']")) ||
                         Helper.IsElementPresent(By.XPath("//input[@value='Sign In']")) ||
                         Helper.IsElementPresent(By.PartialLinkText("SIGN IN"))) ||
                         Helper.IsElementPresent(By.XPath("//button[contains(text(),'Sign In')]")))
                    {
                        Logger.WriteDebugMessage("1. No Menu before Authentication 2.Header 3.Footer ");
                        Queries.GetActiveMemberEmail(data);
                        email = data.MemberEmail;
                        LoginCredentials(email, ProjectDetails.CommonFrontendPassword, ProjectName);
                        if (!Helper.Driver.Url.Contains(LoginLand))
                        {
                            //03/04/2018 : Divya : Made Changes as per Fraser Flow
                            if (ProjectName.Equals("Fraser"))
                            {
                                Helper.ElementWait(PageObject_Navigation.Link_MyAccount(), 60);
                            }
                            else
                            {
                                if (ProjectName.Equals("Sarova") || ProjectName.Equals("EHPC"))
                                {
                                    Helper.ElementWait(PageObject_Navigation.LinkText_MySettings(ProjectName), 60);
                                }
                                else
                                {
                                    Helper.ElementWait(PageObject_Navigation.Link_MySettings(), 60);
                                }
                            }
                        }

                        if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                        {
                            Logger.WriteDebugMessage("Logged in successfully with UserName:" +
                                                     data.MemberEmail + " and Password: " +
                                                     ProjectDetails.CommonFrontendPassword);
                            string PageTitle = Driver.Title;
                            Helper.RegexFunction(PageTitle, pattern);
                        }
                    }
                }
                else
                {
                    Assert.Fail("Login was not successfull.");
                }

            }
        }

        public static void TC_153344()
        {
            if (TestCaseId == Constants.TC_153344)
            {

                //1.URL and Database detail is available in Master Test plan run 
                //2.Navigate to login page 
                //3.Enter invalid email and tab out  for example,email,email123.com,Email@Cendyn17.com.net,E mail@Cendyn17.com
                //*Added this code as per changes for R#208647 for HotelIcon Client*//                
                string InvalidUserName = "email123.com";
                //*Added this code as per changes for R#208647 for HotelIcon Client*//
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                if (ProjectName == "IndependentCollection")
                {
                    LoginCredentials(InvalidUserName, ProjectDetails.CommonFrontendPassword, ProjectName);
                }
                else
                {
                    LoginCredentials(InvalidUserName, ProjectDetails.CommonFrontendPassword, ProjectName);
                }
                if (VerifyTextOnPage(Constants.SignIn_ValidationMessageInvalidFormat))
                {
                    Logger.WriteDebugMessage("Invalid UserName format was sucessfully detected " + InvalidUserName);
                }
                else
                {
                    Assert.Fail("Invalid UserName format was not detected.");
                }

                Logger.WriteDebugMessage("Validation message is expected to get displayed on tab out ");
            }
        }
        public static void TC_254266()
        {
            if (TestCaseId == Constants.TC_254266)
            {
                string emailvalidation = TestDataReader.ReadData(1, "EmailValidation");
                string passwordvalidation = TestDataReader.ReadData(1, "PasswordValidation");
                string username = TestDataReader.ReadData(1, "UserName");
                string password = TestDataReader.ReadData(1, "Password");
                //Click on sign in with entering any field
                SignIn.Click_Button_LogIn(ProjectName);
                Helper.VerifyTextOnPageAndHighLight(emailvalidation);
                Helper.VerifyTextOnPageAndHighLight(passwordvalidation);
                Logger.WriteDebugMessage("Validation message is displayed.");
                //Enter user name and click on sign in
                SignIn.EnterText_Text_Email(username);
                SignIn.Click_Button_LogIn(ProjectName);
                Helper.VerifyTextOnPageAndHighLight(passwordvalidation);
                Logger.WriteDebugMessage("Validation message is displayed for password.");
                Helper.ElementClearText(PageObject_SignIn.Text_Email());
                //Enter password and click on sign in
                SignIn.EnterText_Text_Password(password);
                SignIn.Click_Button_LogIn(ProjectName);
                Helper.VerifyTextOnPageAndHighLight(emailvalidation);
                Logger.WriteDebugMessage("Validation message is displayed for Email.");

                Logger.WriteDebugMessage("Test case passed successfully");


            }
        }
        public static void TC_128801()
        {
            //Prerequisites
            Users frontend = new Users();
            //string page, title,landedpage;
            Queries.GetActiveMemberEmail(frontend);
            LoginCredentials(frontend.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
            if (ProjectName == "Roomzzz")
            {
                ElementWait(PageObject_Navigation.Navigation_Link_MyAccount_Dropdown(), 240);
                Logger.WriteDebugMessage("Sign in successful with Username = " + frontend.MemberEmail);
                ElementClick(PageObject_Navigation.Navigation_Link_MyAccount_Dropdown());
                ElementClick(PageObject_Navigation.Link_SignOut(ProjectName));
            }
            else
            {
                ElementWait(PageObject_Navigation.Link_SignOut(ProjectName), 240);
                Logger.WriteDebugMessage("Sign in successful with Username = " + frontend.MemberEmail);
                /*  page = TestData.ExcelData.TestDataReader.ReadData(i, "PageName");
                    Navigation.ClickOnPage(page);
                    ElementWait(PageObject_Navigation.Link_SignOut(ProjectName), 240);
                    title = TestData.ExcelData.TestDataReader.ReadData(i, "PageTitle");
                    landedpage = TestData.ExcelData.TestDataReader.ReadData(i, "LandedPageText");
                    if ((Driver.Title).Contains(title))
                    {
                        VerifyTextOnPageAndHighLight(landedpage);
                        DynamicScrollToText(Driver, landedpage);
                        Logger.WriteDebugMessage("Landed on = " + landedpage + " Page");
                    }
                    else
                        Assert.Fail("Clicking on = " + page + " does not navigated to " + landedpage );
                */
                Navigation.Click_Link_SignOut(ProjectName);
            }
            if (ProjectName == "HotelIcon")
            {
                if (PageObject_Navigation.Button_SignIn().Displayed)
                    Logger.WriteInfoMessage("Log out link is working and Landed on Sign in Page");
                else
                    Assert.Fail("Log out link is not working");

            }
            else if (ProjectName == "TFE")
            {
                Helper.EnterFrameByxPath(PageObject_SignIn.TFE_SignIn_iFrame());
                if (PageObject_SignIn.Text_Email().Displayed)
                    Logger.WriteInfoMessage("Log out link is working and Landed on Sign in Page");
                else
                    Assert.Fail("Log out link is not working");
            }
            else
            {
                if (PageObject_SignIn.Text_Email().Displayed)
                    Logger.WriteInfoMessage("Log out link is working and Landed on Sign in Page");
                //      Logger.WriteInfoMessage("Log out link is working for "+ page +" Page and Landed on Sign in Page");
                else
                    Assert.Fail("Log out link is not working");
                //       Assert.Fail("Log out link is not working for Page = "+page);

            }

        }
        #endregion
    }
}


