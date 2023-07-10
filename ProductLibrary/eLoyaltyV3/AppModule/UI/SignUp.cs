using System;
using System.Xml;
using System.Xml.Linq;
using System.Configuration;
using System.IO;
using System.Reflection;
using eLoyaltyV3.PageObject.UI;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;
using NUnit.Framework;
using Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BaseUtility.Utility;
using InfoMessageLogger;
using Constants = eLoyaltyV3.Utility.Constants;
using eLoyaltyV3.Entity;
using TestData;
using Queries = eLoyaltyV3.Utility.Queries;

namespace eLoyaltyV3.AppModule.UI
{
    public class SignUp
    {
        public static void Click_Link_SignIn()
        {
            Helper.ElementClick(PageObject_SignUp.Click_SignIn());
            Logger.WriteDebugMessage("Landed on SignIn Page.");
        }

        public static void Click_Button_Join()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_SignUp.Button_Join());
            Helper.ElementClick(PageObject_SignUp.Button_Join());            
        }

        public static void Click_Icon_Close()
        {           
            Helper.ElementClick(PageObject_SignUp.Icon_Close());
        }

        public static void Click_Button_Accept()
        {
            Helper.ElementClick(PageObject_SignUp.Button_Accept());
        }

        public static void Click_Button_Close()
        {
            Helper.ElementClick(PageObject_SignUp.Button_Close());
        }

        private static void SelectText_DropDown_Salutation(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_SignUp.DropDown_Salution(), text);
        }

        private static void EnterText_Text_FirstName(string text)
        {
            Helper.ElementEnterText(PageObject_SignUp.Text_FirstName(), text);
        }

        private static void EnterText_Text_PreferredCardName(string text)
        {
            Helper.ElementEnterText(PageObject_SignUp.Text_PreferredCardName(), text);
        }

        private static void EnterText_Text_LastName(string text)
        {
            Helper.ElementEnterText(PageObject_SignUp.Text_LastName(), text);
        }

        private static void EnterText_Text_Email(string text)
        {
            Helper.ElementEnterText(PageObject_SignUp.Text_Email(), text);
        }

        private static void EnterText_Text_Password(string text)
        {
            Helper.ElementClearText(PageObject_SignUp.Text_Password());
            Helper.ElementEnterText(PageObject_SignUp.Text_Password(), text);
        }

        private static void EnterText_Text_ConfirmPassword(string text)
        {
            Helper.ElementClearText(PageObject_SignUp.Text_ConfirmPassword());
            Helper.ElementEnterText(PageObject_SignUp.Text_ConfirmPassword(), text);
        }

        private static void Select_CheckBox_TermsAndConditions()
        {
            Helper.ElementSelected(PageObject_SignUp.CheckBox_TermsAndConditions());
        }

        private static void UnSelect_CheckBox_TermsAndConditions()
        {
            Helper.ElementNOTSelected(PageObject_SignUp.CheckBox_TermsAndConditions());
        }

        /// <summary>
        /// This method will select a valid birthday
        /// </summary>
        private static void SelectValidBirthday()
        {
            //Click the field
            string birthdayYear = (DateTime.Now.Year - 19).ToString();
            string birthDay = DateTime.Now.Day.ToString();
            Helper.ElementClick(CommonMethod.Driver.FindElement(By.XPath("//input[@id='loginDatePicker']")));
            Time.AddDelay(1000);

            //Select the year
            Helper.ElementSelectFromDropDown(CommonMethod.Driver.FindElement(By.XPath("//select[@class='ui-datepicker-year']")), birthdayYear);

            //Select the date
            Helper.ElementClick(CommonMethod.Driver.FindElement(By.LinkText(birthDay)));

            Logger.WriteInfoMessage("Selected a valid birthday.");
        }

        /// <summary>
        /// This method to create an account with valid validation message.
        /// </summary>
        public static void SucessfulSignUp(string firstName, string lastName, string email, string password, string ProjectName)
        {
            string PageUrlSignUpSuccess = "activation";
            try
            {
                if (Helper.IsElementPresent(By.Id("prefix")))
                {
                    SelectText_DropDown_Salutation("Mr.");
                }
                EnterText_Text_FirstName(firstName);
                EnterText_Text_LastName(lastName);
                EnterText_Text_Email(email);
                if (Helper.IsElementPresent(By.XPath("//input[@id='loginDatePicker']")))
                {
                    SelectValidBirthday();
                }
                if (Helper.IsElementPresent(By.XPath("//input[@id='pcn']")))
                {
                    EnterText_Text_PreferredCardName("text");
                }
                EnterText_Text_Password(password);
                EnterText_Text_ConfirmPassword(password);             
                Logger.WriteDebugMessage("Entered all mandatory fields.");
                String execScript = "return document.documentElement.scrollHeight>document.documentElement.clientHeight;";
                IJavaScriptExecutor scrollBarPresent = (IJavaScriptExecutor)Helper.Driver;
                Boolean test = (Boolean)(scrollBarPresent.ExecuteScript(execScript));
                if (test == true)
                {
                    scrollBarPresent.ExecuteScript("$(window).scrollTop(80)");
                }
                Click_Button_Join();
                Helper.AddDelay(1500);
                if(ProjectName != "Loews")
                {
                    if (Helper.IsElementVisible(PageObject_SignUp.Button_Accept()))
                    {
                        Click_Button_Accept();
                        Logger.WriteDebugMessage("Accepted terms and condition");
                    }
                }
              
                Helper.AddDelay(15000);
                if (ProjectName == "IndependentCollection" || ProjectName == "Iberostar" || ProjectName == "NYLO" || ProjectName == "HotelIcon" || ProjectName == "HotelVic" || ProjectName == "Loews" || ProjectName == "MyStay")
                {
                    if (CommonMethod.Driver.Url.Contains("activation") || CommonMethod.Driver.Url.Contains("Activation"))
                    {
                        if (Helper.Driver.Url.Contains(PageUrlSignUpSuccess))
                        {
                            if (Helper.VerifyTextOnPage(Constants.SignUpSuccess))
                            {
                                Logger.WriteDebugMessage("Received validation message as " + Constants.SignUpSuccess + " for emailaddress as " + email + " User is able to sign up using valid email addresses");
                            }
                        }
                    }
                }
                else if (Helper.Driver.Url.Contains("adareguestloyalty"))
                {
                    if (Helper.VerifyTextOnPage(Constants.AdareSignUpSuccess))
                    {
                        Logger.WriteDebugMessage("Signed up successfully!");
                    }
                }
                else
                {
                    Logger.WriteDebugMessage("SignUp not successful");
                    Assert.Fail("User was unable to register using email address: " + email);
                }
            }
            catch(Exception e)
            {
                Logger.WriteDebugMessage("SignUp not successful");
                throw;
            }
            Time.AddDelay(30000);
        }

        /// <summary>
        /// Checks Mismatch Password while creating an account
        /// </summary>
        public static void SignUpMisMatchPassword(string firstName, string lastName, string email, string password, string confirmPassword)
        {
            if (Helper.IsElementPresent(By.Id("prefix")))
            {
                SelectText_DropDown_Salutation("Mr.");
            }
            EnterText_Text_FirstName(firstName);
            EnterText_Text_LastName(lastName);
            EnterText_Text_Email(email);
            if (Helper.IsElementPresent(By.XPath("//input[@id='pcn']")))
            {
                EnterText_Text_PreferredCardName("text");
            }
            if (Helper.IsElementPresent(By.XPath("//input[@id='loginDatePicker']")))
            {
                SelectValidBirthday();
            }
            EnterText_Text_Password(password);
            EnterText_Text_ConfirmPassword(confirmPassword);
            //if (Helper.IsElementPresent(By.XPath("//input[@id='signupTerms']")))
            //{
            //    Select_CheckBox_TermsAndConditions();
            //}
            ValidateNonMatchingPasswords();
            Logger.WriteDebugMessage("User is able to enter all details");            
        }

        /// <summary>
        /// This method will make sure the user is able to register using valid email addresses.
        /// </summary>
        public static void ValidateValidEmail(string Projectname)
        {
            try
            {
                Random ran = new Random();
                string domain = "@cendyn17.com";

                string email = ran.Next(100000000, 900000000) + domain;
                if (!ConfirmValidEmail(email))
                    throw new Exception("User was unable to register using a valid email address: " + email);
                email = Helper.MakeGmailUnique("CendynAutomationQA@cendyn-one.com");
                if (!ConfirmValidEmail(email))
                    throw new Exception("User was unable to register using a valid email address: " + email);
                email = Helper.MakeGmailUnique("Marcus_LaRockus@cendyn-one.com");
                if (!ConfirmValidEmail(email))
                    throw new Exception("User was unable to register using a valid email address: " + email);
                email = Helper.MakeGmailUnique("CendynAutomationQA@cendyn17.name");
                if (!ConfirmValidEmail(email))
                    throw new Exception("User was unable to register using a valid email address: " + email);
                email = Helper.MakeGmailUnique("marcus-larockus@cendyn17.com");
                if (!ConfirmValidEmail(email))
                    throw new Exception("User was unable to register using a valid email address: " + email);
                email = Helper.MakeGmailUnique("CendynAutomationQA@cendyn17.cendyn-one.com");
                if (!ConfirmValidEmail(email))
                    throw new Exception("User was unable to register using a valid email address: " + email);
                email = Helper.MakeGmailUnique("CendynAutomationQA@cendyn17.co.jp");
                if (!ConfirmValidEmail(email))
                    throw new Exception("User was unable to register using a valid email address: " + email);
               
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                throw;
            }
        }

        /// <summary>
        /// To Confirm Valid EmailAddress is inserted while creating an account.
        /// </summary>
        private static bool ConfirmValidEmail(string email)
        {

            try
            {
               // FillInRequiredFieldsWithFakeData();
                EnterText_Text_Email(email);
                String execScript = "return document.documentElement.scrollHeight>document.documentElement.clientHeight;";
                IJavaScriptExecutor scrollBarPresent = (IJavaScriptExecutor)Helper.Driver;
                Boolean test = (Boolean)(scrollBarPresent.ExecuteScript(execScript));
                if (test == true)
                {
                    scrollBarPresent.ExecuteScript("$(window).scrollTop(80)");
                }
                Click_Button_Join();
                //if (Helper.IsElementPresent(By.Id("acceptTermsBtn")))
                //{
                //    Click_Button_Accept();
                //}
                if (Helper.IsElementPresent(By.Id("acceptTermsBtn")))
                {
                    Click_Button_Accept();
                }
                Time.AddDelay(5000);

                if (CommonMethod.Driver.FindElement(By.XPath("//p[contains(.,'Congratulations! Your account has been successfully created.')]")).Displayed)
                {
                    Navigation.Click_Link_Join();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        /// <summary>
        /// This method will make sure the user is not able to register using an invalid email.
        /// </summary>
        public static void ValidateInvalidEmails(String email, String result, int caseNum,string ProjectName)
        {
            try
            {
                switch (caseNum)
                {
                    case 1:
                        {
                            EnterText_Text_Email(email);
                            
                            Logger.WriteDebugMessage("Entered all required data.");
                            String execScript = "return document.documentElement.scrollHeight>document.documentElement.clientHeight;";
                            IJavaScriptExecutor scrollBarPresent = (IJavaScriptExecutor)Helper.Driver;
                            Boolean test = (Boolean)(scrollBarPresent.ExecuteScript(execScript));
                            if (test == true)
                            {
                                scrollBarPresent.ExecuteScript("$(window).scrollTop(80)");
                            }
                            Click_Button_Join();

                            Helper.AddDelay(15000);
                            if (Helper.VerifyTextOnPage(result))
                            {
                                Logger.WriteInfoMessage("Received validation message as " + result + " for emailaddress as " + email + " User is unable to sign up using invalid email addresses");
                            }
                            else
                            {
                                Assert.Fail("Could not validate message: " + result);
                            }
                            break;
                        }
                    case 2:
                        {
                            EnterText_Text_Email(email);
                            Logger.WriteDebugMessage("Entered Another Email Address: " + email);
                            String execScript = "return document.documentElement.scrollHeight>document.documentElement.clientHeight;";
                            IJavaScriptExecutor scrollBarPresent = (IJavaScriptExecutor)Helper.Driver;
                            Boolean test = (Boolean)(scrollBarPresent.ExecuteScript(execScript));
                            if (test == true)
                            {
                                scrollBarPresent.ExecuteScript("$(window).scrollTop(80)");
                            }
                            Click_Button_Join();                          
                            Helper.AddDelay(15000);
                            if(Helper.VerifyTextOnPage(result))
                            {
                                Logger.WriteInfoMessage("Received validation message as " + result + " for emailaddress as " + email);
                            }
                            else
                            {
                                Assert.Fail("Could not validate message: " + result);
                            }
                            break;
                        }

                    case 3:
                        {
                            if (Helper.IsElementPresent(By.Id("prefix")))
                            {
                                SelectText_DropDown_Salutation("Mr.");
                            }
                            EnterText_Text_FirstName("Test");
                            EnterText_Text_LastName("User");
                            EnterText_Text_Email(email);
                            if (Helper.IsElementPresent(By.XPath("//input[@id='loginDatePicker']")))
                            {
                                SelectValidBirthday();
                            }
                            EnterText_Text_Password(ProjectDetails.CommonFrontendPassword);
                            EnterText_Text_ConfirmPassword(ProjectDetails.CommonFrontendPassword);
                            if (Helper.IsElementPresent(By.XPath("//input[@id='pcn']")))
                            {
                                EnterText_Text_PreferredCardName("text");
                            }
                            Logger.WriteDebugMessage("Entered all required data.");
                            String execScript = "return document.documentElement.scrollHeight>document.documentElement.clientHeight;";
                            IJavaScriptExecutor scrollBarPresent = (IJavaScriptExecutor)Helper.Driver;
                            Boolean test = (Boolean)(scrollBarPresent.ExecuteScript(execScript));
                            if (test == true)
                            {
                                scrollBarPresent.ExecuteScript("$(window).scrollTop(80)");
                            }
                            Click_Button_Join();
                            if (ProjectName != "Loews")
                            {
                                if (Helper.IsElementVisible(PageObject_SignUp.Button_Accept()))
                                {
                                    Click_Button_Accept();
                                }
                            }
                            Helper.AddDelay(15000);
                            if (Helper.VerifyTextOnPage(result))
                            {
                                Logger.WriteInfoMessage("Received validation message as " + result + " for emailaddress as " + email + " User is ale to sign up with following email addresses");
                            }
                            else
                            {
                                Assert.Fail("Could not validate message: " + result);
                            }
                            break;
                        }
                }
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                Assert.Fail(e.ToString());
            }
        }

        /// <summary>
        /// Identified validation messages for Invalid Password.
        /// </summary>
        public static void EnterAllMandatoryFields(string Firstname, string Lastname, string Email, string Card, string Password, string Confirm, string Projectname)
        {
            string birthdayYear = (DateTime.Now.Year - 18).ToString();
            string birthDay = DateTime.Now.Day.ToString();
            Helper.ElementWait(CommonMethod.Driver.FindElement(By.XPath("//input[@id='loginDatePicker']")), 120);
            if (Helper.IsElementPresent(By.Id("prefix")))
            {
                SelectText_DropDown_Salutation("Mr.");
            }

            //Open the Calender
            Helper.ElementClick(CommonMethod.Driver.FindElement(By.XPath("//input[@id='loginDatePicker']")));
            Time.AddDelay(1000);

            //Select the year
            Helper.ElementSelectFromDropDown(CommonMethod.Driver.FindElement(By.XPath("//select[@class='ui-datepicker-year']")), birthdayYear);

            //Select the date
            Helper.ElementClick(CommonMethod.Driver.FindElement(By.LinkText(birthDay)));

            // Enter rest information
            EnterText_Text_FirstName(Firstname);
            EnterText_Text_LastName(Lastname);
            EnterText_Text_Email(Email);
            if(Projectname != "AdareManor")
                EnterText_Text_PreferredCardName(Card);
            EnterText_Text_Password(Password);
            EnterText_Text_ConfirmPassword(Confirm);
            
        }
        public static void EnterPasswordOnSignUp(string password, string passwordpassword)
        {
            Helper.ElementWait(PageObject_SignUp.Text_Password(), 120);
            EnterText_Text_Password(password);
            EnterText_Text_ConfirmPassword(password);

        }

        /// <summary>
        /// Identifies message if emailaddress ia already registered.
        /// </summary>

        public static void ValidateSigningUpWithExistingEmail(string Projectname)
        {
            string validation, fname, lname, email;
            email = Queries.ReturnRegisteredUserEmail();
            validation = Constants.SignUpEmailAddressExist;
            fname = TestData.ExcelData.TestDataReader.ReadData(1, "FirstName");
            lname = TestData.ExcelData.TestDataReader.ReadData(1, "LastName");
            FillInRequiredFieldsWithFakeData(fname,lname);
            EnterText_Text_Email(email);
            String execScript = "return document.documentElement.scrollHeight>document.documentElement.clientHeight;";
            IJavaScriptExecutor scrollBarPresent = (IJavaScriptExecutor)Helper.Driver;
            Boolean test = (Boolean)(scrollBarPresent.ExecuteScript(execScript));
            if (test == true)
            {
                scrollBarPresent.ExecuteScript("$(window).scrollTop(80)");
            }
            Click_Button_Join();
            if (Helper.IsElementVisible(PageObject_SignUp.Button_Accept()))//By.Id("acceptTermsBtn")
            {
                Click_Button_Accept();
            }
            Time.AddDelay(35000);
            try
            {
                if (Projectname == "Loews")
                {
                    if (Helper.VerifyTextOnPage("Oops this email seems to be in use already, please sign in or try another email address"))
                    {
                        Logger.WriteDebugMessage("Unable to register using an existing registered email address. Message confirming that email address already exist should display");
                    }
                }
                else if (Helper.VerifyTextOnPage(validation))
                {
                    Logger.WriteDebugMessage("Unable to register using an existing registered email address. Message confirming that email address already exist should display");
                }

                else
                {
                    throw new Exception("Unable to recognize validation message.");
                }
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                throw;
            }

        }
        
        public static void ValidateNonMatchingPasswords()
        {
            string passwordMatchError = "Passwords don't match";
            EnterText_Text_ConfirmPassword("Cendyn");
            String execScript = "return document.documentElement.scrollHeight>document.documentElement.clientHeight;";
            IJavaScriptExecutor scrollBarPresent = (IJavaScriptExecutor)Helper.Driver;
            Boolean test = (Boolean)(scrollBarPresent.ExecuteScript(execScript));
            if (test == true)
            {
                scrollBarPresent.ExecuteScript("$(window).scrollTop(80)");
            }
            Click_Button_Join();

            try
            {
                if (Helper.VerifyTextOnPage(passwordMatchError))
                    Logger.WriteInfoMessage("The " + passwordMatchError + " error displayed correctly.");
                else
                    Logger.WriteInfoMessage("The " + passwordMatchError + " error did NOT displayed correctly.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                throw;
            }

        }

        private static bool ConfirmInvalidPassword(string password)
        {
            IWebElement invalidPassword = CommonMethod.Driver.FindElement(By.XPath("//span[@id='pwd-error']"));
            EnterText_Text_Password(password);
            EnterText_Text_ConfirmPassword(password);
            //Logger.WriteInfoMessage("Entered Password as " + password + " and Confirm Password as " + password);
            String execScript = "return document.documentElement.scrollHeight>document.documentElement.clientHeight;";
            IJavaScriptExecutor scrollBarPresent = (IJavaScriptExecutor)Helper.Driver;
            Boolean test = (Boolean)(scrollBarPresent.ExecuteScript(execScript));
            if (test == true)
            {
                scrollBarPresent.ExecuteScript("$(window).scrollTop(80)");
            }
            Click_Button_Join();                        
            if (Helper.IsElementDisplayed(invalidPassword))
                return true;

            return false;

        }

        private static bool ConfirmInvalidEmail(string email)
        {
            try
            {
                EnterText_Text_Email(email);
                String execScript = "return document.documentElement.scrollHeight>document.documentElement.clientHeight;";
                IJavaScriptExecutor scrollBarPresent = (IJavaScriptExecutor)Helper.Driver;
                Boolean test = (Boolean)(scrollBarPresent.ExecuteScript(execScript));
                if (test == true)
                {
                    scrollBarPresent.ExecuteScript("$(window).scrollTop(80)");
                }
                Click_Button_Join();
                Time.AddDelay(1000);

                if (CommonMethod.Driver.FindElement(By.XPath("//span[@id='signUpEmail-error']")).Displayed)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        /// <summary>
        /// This method will enter all required fields with fake data but won't submit
        /// </summary>
        /// 
        
        public static void FillInRequiredFieldsWithFakeData(string fname=null, string lname=null)
        {
            if(Helper.IsElementPresent(By.Id("prefix")))
            {
                SelectText_DropDown_Salutation("Mr.");
            }
            if (fname == null)
            {
                EnterText_Text_FirstName(fname);
                EnterText_Text_LastName(lname);
            }
            else
            {
                EnterText_Text_FirstName(fname);
                EnterText_Text_LastName(lname);
            }
            //EnterText_Text_FirstName(TestData.TC_119763_FirstName);
            //EnterText_Text_LastName(TestData.TC_119763_LastName);
            EnterText_Text_Email(Helper.CommonUniqueTestCatchAll());
            if(Helper.IsElementPresent(By.XPath("//input[@id='pcn']")))
            {
                EnterText_Text_PreferredCardName("text");
            }
            if (Helper.IsElementPresent(By.XPath("//input[@id='loginDatePicker']")))
            {
                SelectValidBirthday();
            }
            EnterText_Text_Password(ProjectDetails.CommonFrontendPassword);
            EnterText_Text_ConfirmPassword(ProjectDetails.CommonFrontendPassword);
            //if (Helper.IsElementPresent(By.XPath("//input[@id='signupTerms']")))
            //{
            //    Select_CheckBox_TermsAndConditions();
            //}
        }
   

        public static void SignUpOlderThan18Years(string email)
        {
            FillInRequiredFieldsWithFakeData();
            EnterText_Text_Email(email);
            Logger.WriteDebugMessage("All required data are inserted into specific fields.");

            String execScript = "return document.documentElement.scrollHeight>document.documentElement.clientHeight;";
            IJavaScriptExecutor scrollBarPresent = (IJavaScriptExecutor)Helper.Driver;
            Boolean test = (Boolean)(scrollBarPresent.ExecuteScript(execScript));
            if(test == true)
            {
                scrollBarPresent.ExecuteScript("$(window).scrollTop(80)");
            }
            Click_Button_Join();
            if (Helper.IsElementPresent(By.Id("acceptTermsBtn")))
            {
                Click_Button_Accept();
            }
            Helper.AddDelay(25000);
            try
            {
                if (CommonMethod.Driver.Url.Contains("independentcollection") || CommonMethod.Driver.Url.Contains("iberostar") || CommonMethod.Driver.Url.Contains("nyloloyals") || CommonMethod.Driver.Url.Contains("hotelicon") || CommonMethod.Driver.Url.Contains("hotelvic"))
                {
                    if (CommonMethod.Driver.Url.Contains("activation") || CommonMethod.Driver.Url.Contains("Activation"))
                    {
                        if (Helper.VerifyTextOnPage(Constants.SignUpSuccess))
                        {
                            Logger.WriteDebugMessage("Received validation message as " + Constants.SignUpSuccess);
                        }
                    }
                }
                else if (Helper.Driver.Url.Contains("adareguestloyalty"))
                {
                    if (Helper.VerifyTextOnPage(Constants.AdareSignUpSuccess))
                    {
                        Logger.WriteDebugMessage("Signed up successfully!");
                    }
                }

                else if (CommonMethod.Driver.Url.Contains("Activation"))
                {
                    if (Helper.VerifyTextOnPage(Constants.SignUpSuccess))
                    {
                        Logger.WriteDebugMessage("Signed up successfully!");
                    }
                }
                else
                {
                    throw new Exception("Did not successfully sign up with a user birthday greater than 18 years ago.");
                }
                    
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                throw;
            }
        }
         

        public static void SignUpLessThan18Years(string fname, string lname)
        {
            string birthdayYear = (DateTime.Now.Year - 17).ToString();
            string birthDay = DateTime.Now.Day.ToString();

            try
            {
                if(Helper.IsElementPresent(By.Id("prefix")))
                {
                    SelectText_DropDown_Salutation("Mr.");
                }
                EnterText_Text_FirstName(fname);
                EnterText_Text_LastName(lname);
                EnterText_Text_Email(Helper.CommonUniqueTestCatchAll());
                EnterText_Text_Password(ProjectDetails.CommonFrontendPassword);
                EnterText_Text_ConfirmPassword(ProjectDetails.CommonFrontendPassword);
                //if (Helper.IsElementVisible(PageObject_SignUp.CheckBox_TermsAndConditions()))
                //{
                //    Select_CheckBox_TermsAndConditions();
              
                //}
                Logger.WriteDebugMessage("Entered other text field except Date of Birth.");
                Helper.ElementClick(CommonMethod.Driver.FindElement(By.XPath("//input[@id='loginDatePicker']")));

                Logger.WriteDebugMessage("Greater than 18 years old is required.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                throw;
            }
        }

        public static void SignUpExactly18YearsOld(string email)
        {
            FillInRequiredFieldsWithFakeData();
            EnterText_Text_Email(email);
            string birthdayYear = (DateTime.Now.Year - 18).ToString();
            string birthDay = DateTime.Now.Day.ToString();

            try
            {
                //Click the field
                Helper.ElementClick(CommonMethod.Driver.FindElement(By.XPath("//input[@id='loginDatePicker']")));
                Time.AddDelay(1000);

                //Select the year
                Helper.ElementSelectFromDropDown(CommonMethod.Driver.FindElement(By.XPath("//select[@class='ui-datepicker-year']")), birthdayYear);

                //Select the date
                Helper.ElementClick(CommonMethod.Driver.FindElement(By.LinkText(birthDay)));
                Logger.WriteDebugMessage("Selected a birthday exactly 18 years ago: " + DateTime.Now.Month + "/" + birthDay + "/" + birthdayYear);

                String execScript = "return document.documentElement.scrollHeight>document.documentElement.clientHeight;";
                IJavaScriptExecutor scrollBarPresent = (IJavaScriptExecutor)Helper.Driver;
                Boolean test = (Boolean)(scrollBarPresent.ExecuteScript(execScript));
                if (test == true)
                {
                    scrollBarPresent.ExecuteScript("$(window).scrollTop(80)");
                }

                Click_Button_Join();
                if (Helper.IsElementPresent(By.Id("acceptTermsBtn")))
                {
                    Click_Button_Accept();
                }
                Logger.WriteInfoMessage("User should get registered successfully on Fraser and Signup confirmation page should be displayed");
                Helper.AddDelay(20000);

                if (CommonMethod.Driver.Url.Contains("independentcollection") || CommonMethod.Driver.Url.Contains("iberostar") || CommonMethod.Driver.Url.Contains("nyloloyals") || CommonMethod.Driver.Url.Contains("hotelicon") || CommonMethod.Driver.Url.Contains("hotelvic"))
                {
                    if (CommonMethod.Driver.Url.Contains("activation") || CommonMethod.Driver.Url.Contains("Activation"))
                    {
                        if (Helper.VerifyTextOnPage(Constants.SignUpSuccess))
                        {
                            Logger.WriteDebugMessage("Received validation message as " + Constants.SignUpSuccess);
                        }
                    }
                }
                else if (Helper.Driver.Url.Contains("adareguestloyalty"))
                {
                    if (Helper.VerifyTextOnPage(Constants.AdareSignUpSuccess))
                    {
                        Logger.WriteDebugMessage("Signed up successfully!");
                    }
                }

                else if (CommonMethod.Driver.Url.Contains("Activation"))
                {
                   if (Helper.VerifyTextOnPage(Constants.SignUpSuccess))
                   {
                      Logger.WriteDebugMessage("Signed up successfully!");
                   }
                }
                else
                {
                    Assert.Fail("Did not successfully sign up with a user birthday exactly 18 years ago.");
                }

            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                throw;
            }
        }
            
        public static void CustomerSignUpAPIData(string ProjectName, string DCStayStatus, string TestCaseId, UserSignUpCRMAPI CustData)
        {
            //CRMAPIInfo cred = new CRMAPIInfo();

            string JsonResult;
            string TestPlanId = "121734";
            
            switch (DCStayStatus)
            {
                case "R":
                    // TestCaseID:119748 and StayStatus As 'R'

                    
                    string checkStayStatus = Queries.ReturnStayStatus(DCStayStatus);
                    if (checkStayStatus != "Record does not exist in table.")
                    {
                        Queries.GetCustomerSignUpAPIData(DCStayStatus, CustData);
                        JsonResult = CRMAPI.FormatJsonData(CustData);
                        CRMAPI.PostAPIRequest("Register", JsonResult, DCStayStatus);
                        Queries.UpdateRegistrationConfirmDate(ProjectName, CustData.email);
                    }
                    break;

                case "I":
                    DCStayStatus = "I";
                    
                    checkStayStatus = Queries.ReturnStayStatus(DCStayStatus);
                    if (checkStayStatus != "Record does not exist in table.")
                    {
                        Queries.GetCustomerSignUpAPIData(DCStayStatus, CustData);
                        JsonResult = CRMAPI.FormatJsonData(CustData);
                        CRMAPI.PostAPIRequest("Register", JsonResult, DCStayStatus);
                        Queries.UpdateRegistrationConfirmDate(ProjectName, CustData.email);
                    }
                    break;

                case "C":
                    DCStayStatus = "C";
                    
                    checkStayStatus = Queries.ReturnStayStatus(DCStayStatus);
                    if (checkStayStatus != "Record does not exist in table.")
                    {
                        Queries.GetCustomerSignUpAPIData(DCStayStatus, CustData);
                        JsonResult = CRMAPI.FormatJsonData(CustData);
                        CRMAPI.PostAPIRequest("Register", JsonResult, DCStayStatus);
                        Queries.UpdateRegistrationConfirmDate(ProjectName, CustData.email);
                    }
                    break;

                case "N":
                    
                    checkStayStatus = Queries.ReturnStayStatus(DCStayStatus);
                    if (checkStayStatus != "Record does not exist in table.")
                    {
                        Queries.GetCustomerSignUpAPIData(DCStayStatus, CustData);
                        JsonResult = CRMAPI.FormatJsonData(CustData);
                        CRMAPI.PostAPIRequest("Register", JsonResult, DCStayStatus);
                        Queries.UpdateRegistrationConfirmDate(ProjectName, CustData.email);
                    }
                    break;

                case "SameNameAndEmail":
                    
                    Queries.GetCustomerSignUpAPIData(DCStayStatus, CustData);
                    if (CustData.email != "")
                    {
                        Queries.GetCustomerSignUpAPIData(DCStayStatus, CustData);
                        JsonResult = CRMAPI.FormatJsonData(CustData);
                        CRMAPI.PostAPIRequest("Register", JsonResult, DCStayStatus);
                        Queries.UpdateRegistrationConfirmDate(ProjectName, CustData.email);
                    }
                    break;

                case "SameEmailDifferentName":
                    
                    Queries.GetCustomerSignUpAPIData(DCStayStatus, CustData);
                    if (CustData.email != "")
                    {
                        Queries.GetCustomerSignUpAPIData(DCStayStatus, CustData);
                        JsonResult = CRMAPI.FormatJsonData(CustData);
                        CRMAPI.PostAPIRequest("Register", JsonResult, DCStayStatus);
                        Queries.UpdateRegistrationConfirmDate(ProjectName, CustData.email);
                    }
                    break;
            }
        }

        public static void SignUpDummyUser(UserSignUpCRMAPI CustData)
        {
            string ProjectName = "Origami";
            Queries.GetDummySignUpAPIData(CustData);
            string JsonResult = CRMAPI.FormatJsonData(CustData);
            CRMAPI.PostAPIRequest("Register", JsonResult, "User");
            Queries.UpdateRegistrationConfirmDate(ProjectName, CustData.email);
            Queries.UpdateUsedDummyData(CustData.email);
        }
        
        public static void Click_SignUp_DateOfBirth()
        {
            Helper.ElementClick(PageObject_SignUp.SignUp_DateOfBirth());
        }
        /// <summary>
        /// This method will enter firstname,lastname ,email and click on the Date of month field
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        public static void Click_On_Date_Of_Birth_Field(string firstName, string lastName, string email)
        {
            try
            {
                EnterText_Text_FirstName(firstName);
                EnterText_Text_LastName(lastName);
                EnterText_Text_Email(email);
                Click_SignUp_DateOfBirth();
            }

            catch (Exception e)
            {
                Logger.WriteErrorMessage(System.Reflection.MethodBase.GetCurrentMethod().Name + "method is failed", e);
            }



        }

        public static void SignUp_Footer()
        {
            Helper.ElementClick(PageObject_SignUp.SignUp_Footer());
        }
        public static void Click_SignUp_Facebook_Link()
        {
            Helper.ElementClick(PageObject_SignUp.SignUp_Facebook_Link());
        }
        public static void Navigate_To_Facebook_From_SignUp(string mainWindowTitle, string faceBookTitle)
        {
            Helper.ElementWait(PageObject_SignUp.SignUp_Facebook_Link(), 120);
            Helper.AddDelay(5000);
            SignUp.Click_SignUp_Facebook_Link();
            Helper.AddDelay(5000);
            Helper.Driver.SwitchTo().Window(Helper.Driver.WindowHandles[1]);
            String ChildWindowTitleFacebook = Helper.Driver.Title;
            Assert.AreNotEqual(mainWindowTitle, ChildWindowTitleFacebook);
            Assert.IsTrue(ChildWindowTitleFacebook.Contains(faceBookTitle));
            //Assert.AreEqual(faceBookTitle, ChildWindowTitleFacebook);
            

        }
        public static void Click_SignUp_Twitter_Link()
        {
            Helper.ElementClick(PageObject_SignUp.SignUp_Twitter_Link());
        }
        public static void Navigate_To_Twitter_From_SignUp(string mainWindowTitle, string twitterTitle)
        {
            SignUp.Click_SignUp_Twitter_Link();
            Helper.Driver.SwitchTo().Window(Helper.Driver.WindowHandles[1]);
            String chlidWindowTitleTwitter = Helper.Driver.Title;
            Assert.AreNotEqual(mainWindowTitle, chlidWindowTitleTwitter);
            Assert.AreEqual(twitterTitle, chlidWindowTitleTwitter);
           
        }

        public static void Enter_Facebook_UserName(String userName)
        {
            PageObject_SignUp.Facebook_UserName().Clear();
            Helper.ElementEnterText(PageObject_SignUp.Facebook_UserName(),userName);
        }
        public static void Enter_Facebook_Password(String facebookPassword)
        {
            Helper.ElementEnterText(PageObject_SignUp.Facebook_Password(), facebookPassword);
        }
        public static void Enter_Twitter_UserName(String userName)
        {
            Helper.ElementEnterText(PageObject_SignUp.Twitter_UserName(), userName);
        }
        public static void Enter_Twitter_Password(String TwitterPassword)
        {
            Helper.ElementEnterText(PageObject_SignUp.Twitter_Password(), TwitterPassword);
        }

        public static void Click_Facebook_Signup_Login()
        {
            // Helper.ElementClick(PageObject_SignUp.Facebook_Login());
            PageObject_SignUp.Facebook_Login().Click();
        }
        public static void Click_Twitter_Signup_Login()
        {
            Helper.ElementClick(PageObject_SignUp.Twitter_Login());
        }
        public static void Click_Authorise_App_Button()
        {
            Helper.ElementClick(PageObject_SignUp.Allow_On_Twitter());
        }
        

        private static void InserttoXML(string TestPlanId, string TestCaseID, UserSignUpCRMAPI CustData)
        {
            string executableLocationCodeBase = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            UriBuilder uri = new UriBuilder(executableLocationCodeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            string locationPath = Path.GetDirectoryName(path);
            XmlDocument xml = new XmlDocument();

            string xslLocation = Path.Combine(executableLocationCodeBase, "TestData");

            xslLocation = xslLocation + "\\TP_" + TestPlanId + ".xml";
            var ParamkeyFN = "//Parameter[@key='" + TestCaseID + "_first_name" + "']";
            var ParamkeyLN = "//Parameter[@key='" + TestCaseID + "_last_name" + "']";
            var ParamkeyEmail = "//Parameter[@key='" + TestCaseID + "_email" + "']";
            var ParamkeyID = "//Parameter[@key='" + TestCaseID + "_login_id" + "']";
            var ParamkeyPwd = "//Parameter[@key='" + TestCaseID + "_Password" + "']";
            var ParamkeySln = "//Parameter[@key='" + TestCaseID + "_Salutation" + "']";
            var ParamkeyLang = "//Parameter[@key='" + TestCaseID + "_language" + "']";
            var ParamkeyDOB = "//Parameter[@key='" + TestCaseID + "_date_of_birth" + "']";
            var ParamkeyMem = "//Parameter[@key='" + TestCaseID + "_HasMembership" + "']";
            var ParamkeyAct = "//Parameter[@key='" + TestCaseID + "_NeedActivate" + "']";
            var ParamkeyNewsSub = "//Parameter[@key='" + TestCaseID + "_NewsletterSubscription" + "']";

            //Logger.WriteDebugMessage(xslLocation);
            xml.Load(xslLocation);
            xml.SelectSingleNode(ParamkeyFN).InnerText = CustData.first_name;
            xml.Save(xslLocation);
            xml.SelectSingleNode(ParamkeyLN).InnerText = CustData.last_name;
            xml.Save(xslLocation);
            xml.SelectSingleNode(ParamkeyEmail).InnerText = CustData.email;
            xml.Save(xslLocation);
            xml.SelectSingleNode(ParamkeyID).InnerText = CustData.login_id;
            xml.Save(xslLocation);
            xml.SelectSingleNode(ParamkeyPwd).InnerText = CustData.Password;
            xml.Save(xslLocation);
            xml.SelectSingleNode(ParamkeySln).InnerText = CustData.Salutation;
            xml.Save(xslLocation);
            xml.SelectSingleNode(ParamkeyLang).InnerText = CustData.language;
            xml.Save(xslLocation);
            xml.SelectSingleNode(ParamkeyDOB).InnerText = CustData.date_of_birth;
            xml.Save(xslLocation);
            xml.SelectSingleNode(ParamkeyMem).InnerText = CustData.HasMembership;
            xml.Save(xslLocation);
            xml.SelectSingleNode(ParamkeyAct).InnerText = CustData.NeedActivate;
            xml.Save(xslLocation);
            xml.SelectSingleNode(ParamkeyNewsSub).InnerText = CustData.NewsletterSubscription;
            xml.Save(xslLocation);
        }
        public static void SignUpEnterdetails(string FirstName, string Lastname, string Email, string Cardname, string Password, string ConfirmPassword, int casenumber)
        {
            string birthdayYear = (DateTime.Now.Year - 18).ToString();
            string birthDay = DateTime.Now.Day.ToString();

            switch (casenumber)
            {
                case 1:
                    //Click the field
                    Helper.ElementClick(CommonMethod.Driver.FindElement(By.XPath("//input[@id='loginDatePicker']")));
                    Time.AddDelay(1000);

                    //Select the year
                    Helper.ElementSelectFromDropDown(CommonMethod.Driver.FindElement(By.XPath("//select[@class='ui-datepicker-year']")), birthdayYear);

                    //Select the date
                    Helper.ElementClick(CommonMethod.Driver.FindElement(By.LinkText(birthDay)));
                    break;
                case 2:
                    EnterText_Text_FirstName(FirstName);
                    break;
                case 3:
                    EnterText_Text_LastName(Lastname);
                    break;
                case 4:
                    EnterText_Text_Email(Email);
                    break;
                case 5:
                    EnterText_Text_PreferredCardName(Cardname);
                    break;
                case 6:
                    EnterText_Text_Password(Password);
                    break;
                case 7:
                    EnterText_Text_ConfirmPassword(ConfirmPassword);
                    break;
           }
            
        }

        public static void SignUpVerifyErrorMessage(int caseId, string fieldValidation, string captchaValidation
                                            ,string dOB_Error, string firstName_Error, string lastName_Error, string email_Error
                                            ,string card_Error, string password_Error, string confirmPassword_Error,string captcha_Error)
        {

            bool isValidMessageDisplay = true;

            if (caseId == 0 && !dOB_Error.Equals(fieldValidation))
                    isValidMessageDisplay = false;

            if (caseId <= 1 && !firstName_Error.Equals(fieldValidation)                )
                isValidMessageDisplay = false;

            if (caseId <= 2 && !lastName_Error.Equals(fieldValidation))
                isValidMessageDisplay = false;

            if (caseId <= 3 && !email_Error.Equals(fieldValidation))
                isValidMessageDisplay = false;

            if (caseId <= 4 && !card_Error.Equals(fieldValidation))
                isValidMessageDisplay = false;

            if (caseId <= 5 && !password_Error.Equals(fieldValidation))
                isValidMessageDisplay = false;

            if (caseId <= 6 && !confirmPassword_Error.Equals(fieldValidation))
                isValidMessageDisplay = false;

            if (caseId <= 7 && !captcha_Error.Equals(captchaValidation))
                isValidMessageDisplay = false;

            if (isValidMessageDisplay)
                Logger.WriteDebugMessage("Validation messages are displaying properly");
            else
                Assert.Fail("Validation message is not displayed properly.");
        }
        public static void VerifyInvalidPasswordMessage(string fieldValidation, string password_Error)
        {
            if (password_Error.Equals(fieldValidation))
                Logger.WriteDebugMessage("Validation message for Invalid Password is Displayed");
            else
                Assert.Fail("Validation messages are not displayed");
        }
        public static void ClickOnSignUpEyeBall()
        {
            Helper.ElementClick(PageObject_SignUp.Password_Eye_Ball());
            Helper.ElementClick(PageObject_SignUp.ConfirmPassword_Eye_Ball());
        }

        public static void VerifyValidationMessage(string Actual_validation_Message, string Expected_Validation_Message)
        {
            
            if (Actual_validation_Message.Equals(Expected_Validation_Message))
                Logger.WriteDebugMessage("Validation messages are displaying properly");
           else
            {
                Assert.Fail("Validation message is not displayed properly.");
            }

        }

        public static void  SignUpVerificationwithhLessThan18Years()
        {
            string birthdayYear = (DateTime.Now.Year - 18).ToString();
            string birthMonth = (DateTime.Now.Month).ToString();
            string birthday = DateTime.Now.Day.ToString();

            //Open the Calender
            Helper.ElementWait(CommonMethod.Driver.FindElement(By.XPath("//input[@id='loginDatePicker']")), 120);
            Helper.ElementClick(CommonMethod.Driver.FindElement(By.XPath("//input[@id='loginDatePicker']")));
            Time.AddDelay(1000);
            Logger.WriteDebugMessage("Clicked on Calender on Sign Up Page");

            //Select the year
            Helper.ElementSelectFromDropDown(CommonMethod.Driver.FindElement(By.XPath("//select[@class='ui-datepicker-year']")), birthdayYear);
            Helper.ElementClick(CommonMethod.Driver.FindElement(By.XPath("//select[@class='ui-datepicker-year']")));
            Logger.WriteDebugMessage("Birth Year greater than 18 years get selected");
            
            //Select the Month
            Helper.ElementClick(CommonMethod.Driver.FindElement(By.XPath("//select[@class='ui-datepicker-month']")));
            Helper.AddDelay(3000);
            Logger.WriteDebugMessage("Current Month got selected as Birth Month");
            //Helper.ElementClick(CommonMethod.Driver.FindElement(By.LinkText(birthMonth)));

            //select the Current Day
            Helper.ElementClick(CommonMethod.Driver.FindElement(By.XPath("//input[@id='loginDatePicker']")));
            Helper.ElementClick(CommonMethod.Driver.FindElement(By.LinkText(birthday)));
            Logger.WriteDebugMessage("Current Day got selected as Birth Day");
        }

        /// <summary>
        /// Identified validation messages for Invalid Password.
        /// </summary>

    }
}
