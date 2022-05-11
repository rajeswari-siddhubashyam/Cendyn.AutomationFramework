using System;
using eLoyaltyV3.Utility;
using eLoyaltyV3.PageObject.UI;
using eLoyaltyV3.AppModule.UI;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;
using Common;
using OpenQA.Selenium;
using TestData.ExcelData;
using System.Net;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Constants = eLoyaltyV3.Utility.Constants;
using TestData;
using InfoMessageLogger;
using BaseUtility.Utility;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eLoyaltyV3.Utility.Setup
    {
        #region TP_121735 - Sign Up Non PMS User
        public static void TC_119758()
        {
            if (TestCaseId == Constants.TC_119758)
            {
                //1 Identify a Profile in PMS source who has Reserved stay status record
                email = MakeGmailUnique(ProjectDetails.CommonGmail);
                firstName = "John";
                lastName = "Doe";

                //2 Navigate to the Sign Up page
                AddDelay(30000);
                //*Added this code as per changes for R#208647 for HotelIcon Client*//
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_JoinNow();
                }
                else
                {
                    Navigation.Navigation_SignUpbtn();
                }

                Logger.WriteDebugMessage("Landed on the Sign Up page.");

                //3 Fill in all required fields.
                SignUp.SucessfulSignUp(firstName, lastName, email, ProjectDetails.CommonFrontendPassword, ProjectName);

                //5 Verify the acivation email is delivered to Hotmail
                Email.LogIntoGmail();
                Email.Gmail_OpenLatestEmail();
                Email.ActivationEmail_Check(ProjectName);
                Logger.WriteDebugMessage("The activation email was received.");

                //6 Click the activation email link.
                Email.ActivationEmail_ClickLink(ProjectName);
                AddDelay(7000);
                Logger.WriteDebugMessage("Confirmation message regarding account being confirmed is displayed.");

                //7 Verify the welcome email is delivered.
                ControlToNewWindow();
                CloseCurrentTab();
                ControlToPreviousWindow();
                Email.Gmail_OpenLatestEmail();
                Email.WelcomeEmail_Check(ProjectName);
                Logger.WriteDebugMessage("The welcome email was delivered.");

                //8 Click the welcome email.
                Email.WelcomeEmail_ClickLink(ProjectName, ProjectDetails.CommonFrontendURL);
                Logger.WriteDebugMessage("User landed on the Sign In page after clicking the Welcome Email link.");
            }
        }

        public static void TC_119759()
        {
            if (TestCaseId == Constants.TC_119759)
            {
                //2 Navigate to the Sign Up page
                AddDelay(30000);
                //*Added this code as per changes for R#208647 for HotelIcon Client*//
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_JoinNow();
                }
                else
                {
                    Navigation.Navigation_SignUpbtn();
                }

                Logger.WriteDebugMessage("Landed on the Sign Up page.");
                string ValidationResult2 = Constants.SignUpSuccess;
                string email1 = "QAJS" + GetDate + "1@Cendyn17.com";
                SignUp.SucessfulSignUp("Jay", "S", email1, "Cendyn123$", ProjectName);

                Navigation.NavigateToUrl(ProjectName);
                AddDelay(2500);
                string email2 = "QAJS" + GetDate + "2@Cendyn17.com";
                Navigation.CheckIfSignUpButtonIsVisible(ProjectName);
                //*Added this code as per changes for R#208647 for HotelIcon Client*//
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_JoinNow();
                }
                else
                {
                    Navigation.Navigation_SignUpbtn();
                }

                SignUp.SucessfulSignUp("Jay", "S", email2, "CCendyn1", ProjectName);
            }
        }

        public static void TC_119760()
        {
            if (TestCaseId == Constants.TC_119760)
            {
                //Pre-requisite
                string FirstName, LastName, Email, Card, Password, ConfirmPassword, Email_Error, EmailValidation;

                //Retrieved data
                FirstName = TestDataReader.ReadData(1, "FirstName");
                LastName = TestDataReader.ReadData(1, "LastName");
                Card = TestDataReader.ReadData(1, "Card");
                Password = TestDataReader.ReadData(1, "Password");
                ConfirmPassword = TestDataReader.ReadData(1, "ConfirmPassword");
                if(ProjectName.Equals("AdareManor"))
                    EmailValidation = TestDataReader.ReadData(1, "AdareValidationmessage");
                else
                    EmailValidation = TestDataReader.ReadData(1, "Validationmessage");
                
                Logger.WriteDebugMessage("Landed on Front end Sign In Page");
                Logger.LogTestData(TestPlanId, TestCaseId, "FirstName", FirstName);
                Logger.LogTestData(TestPlanId, TestCaseId, "LastName", LastName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Card", Card);
                Logger.LogTestData(TestPlanId, TestCaseId, "Password", Password);
                Logger.LogTestData(TestPlanId, TestCaseId, "ConfirmPassword", ConfirmPassword);
                Logger.LogTestData(TestPlanId, TestCaseId, "EmailValidation", EmailValidation);
                //Navigate to Sign Up Page
                Navigation.Navigation_SignUpbtn(ProjectName);
                
                // Verify the validation message should not display with different combination of Email
                for (int i = 1; i <= 10; i++)
                {
                    Email = TestDataReader.ReadData(i, "Email");
                    Logger.WriteDebugMessage("Landed on Sign Up Page");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Email " +i, Email);
                    // Enter All mandatory Fields
                    SignUp.EnterAllMandatoryFields(FirstName, LastName, Email, Card, Password, ConfirmPassword, ProjectName);
                    
                    // Click on Join Now
                    Navigation.SignUp_Button_Join();

                    // Validate the Validation message for password field
                    Email_Error = Navigation.Email_Error();
                    if (i == 10)
                        Logger.LogTestData(TestPlanId, TestCaseId, "Email Validation " +i, Email_Error, true);
                    else
                        Logger.LogTestData(TestPlanId, TestCaseId, "Email Validation "+i, Email_Error);
                    if ((Email_Error != EmailValidation) && (Email_Error == ""))
                    {
                       Logger.WriteDebugMessage(Email+" is a valid email address"); 
                    }
                    else
                    {
                        Assert.Fail("Validation message for "+Email + " getting displayed");
                    }
                    
                    Helper.ReloadPage();
                }
               
            }
        }

        public static void TC_119761()
        {
            if (TestCaseId == Constants.TC_119761)
            {
                //2 Navigate to the Sign Up page
                AddDelay(30000);
                //*Added this code as per changes for R#208647 for HotelIcon Client*//
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_JoinNow();
                }
                else
                {
                    Navigation.Navigation_SignUpbtn();
                }
                Logger.WriteDebugMessage("Landed on the Sign Up page.");

                string EmailADD = "js" + GetDate + "@cendyn17.com";
                //3 Verify the user cannot sign up using invalid email addresses
                SignUp.SucessfulSignUp("Jay", "S", EmailADD, ProjectDetails.CommonFrontendPassword, ProjectName);

                //4. Update RegistrationConfirmDate to Activate User's Accounnt
                //Queries.UpdateRegistrationConfirmDate(ProjectName, EmailADD);

                Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(EmailADD);
                Email.ActivationEmail_Check(ProjectName);
                Logger.WriteDebugMessage("The activation email was received.");

                //6 Click the activation email link.
                Email.ActivationEmail_ClickLink(ProjectName);
                AddDelay(7000);
                Logger.WriteDebugMessage("Confirmation message regarding account being confirmed is displayed.");

                //7 Verify the welcome email is delivered.
                ControlToNewWindow();
                CloseCurrentTab();
                ControlToPreviousWindow();
                Driver.Navigate().GoToUrl("https://outlook.office365.com/owa/?realm=cendyn17.com&exsvurl=1&ll-cc=1033&modurl=0");

                Email.CatchAll_SearchEmailAndOpenLatestMessage(EmailADD);
                Email.WelcomeEmail_Check(ProjectName);
                Logger.WriteDebugMessage("The welcome email was delivered.");

                //8 Click the welcome email.
                Email.WelcomeEmail_ClickLink(ProjectName, ProjectDetails.CommonFrontendURL);
                Logger.WriteDebugMessage("User landed on the Sign In page after clicking the Welcome Email link.");
                ControlToNewWindow();

                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);

                if (ProjectName != "AdareManor")
                {
                    //9 Log in using credentials
                    //*Added this code as per changes for R#208647 for HotelIcon Client*//
                    if (ProjectName.Equals("HotelIcon"))
                    {
                        Navigation.Click_Button_SignIn();
                    }

                    SignIn.LogIn(EmailADD, ProjectDetails.CommonFrontendPassword, ProjectName);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //10 Verify Member Since date is todays date.
                    if (!ProjectName.Equals("NYLO"))
                        if (!ProjectName.Equals("Loews"))
                        {
                            Navigation.VerifyMemberSinceToday(ProjectName);
                            Logger.WriteDebugMessage("Member since date is todays date.");
                        }

                    if (ProjectName != "HotelVic")
                    {
                        Navigation.Click_Link_MyStays();
                    }
                }
            }
        }
        #endregion TP_121735
    }
}
