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
using eLoyaltyV3.Entity;
using TestData;
using InfoMessageLogger;
using BaseUtility.Utility;
using Queries = eLoyaltyV3.Utility.Queries;
using AventStack.ExtentReports.Model;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eLoyaltyV3.Utility.Setup
    {
        #region TP_121741 - Contact US
        public static void TC_120118()
        {
            if (TestCaseId == Constants.TC_120118)
            {
                string ContactUsUrl = "/en-US/ContactUs";

                Users data = new Users();
                Queries.GetActiveMemberEmail(data);

                //1 Log in
                //*Added this code as per changes for R#208647 for HotelIcon Client*//
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully.");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email", data.MemberEmail, true);
                if (ProjectName.Equals("AMR"))
                {
                    Navigation.Click_Link_MyProfile(ProjectName);
                    AddDelay(2500);
                    Logger.WriteDebugMessage("User to land on the Profile page.");
                    Helper.PageDown();
                }
                else
                {
                    //2 Navigate to the Contact Us page.
                    Navigation.Click_Link_ContactUs(ProjectName);
                    ScrollDown();
                    Logger.WriteDebugMessage("Landed on the Contact Us page.");
                }



                //3 Verify fields are uneditable
                ContactUs.VerifyUneditableFields(ProjectName);
                Logger.WriteDebugMessage("Fields are uneditable on the Contact Us page!");

            }
        }

        public static void TC_120119()
        {
            if (TestCaseId == Constants.TC_120119)
            {
                string ContactUsUrl = "/en-US/ContactUs";
                if (ProjectName != "AdareManor")
                {
                    Users data = new Users();
                    Queries.GetActiveMemberEmail(data);

                    if (ProjectName.Equals("HotelIcon"))
                    {
                        Navigation.Click_Button_SignIn();
                    }
                    //*Added this code as per changes for R#208647 for HotelIcon Client*//      
                    LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                    Logger.WriteDebugMessage("Logged in successfully.");
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email", data.MemberEmail, true);

                    //2 Navigate to the Contact Us page.
                    if (ProjectName.Equals("AMR"))
                    {
                        Navigation.Click_Link_MyProfile(ProjectName);
                        Logger.WriteDebugMessage("User to land on the Profile page.");
                        Helper.PageDown();
                    }
                    else
                    {
                        Navigation.Click_Link_ContactUs(ProjectName);
                        Logger.WriteDebugMessage("Landed on the Contact Us page.");
                    }
                    //3 Verify fields are uneditable
                    string text = "Test";
                    ContactUs.InsertSpecialCharacterInPhone(text, ProjectName);
                }
            }
        }
        public static void TC_216107()
        {
            if (TestCaseId == Constants.TC_216107)
            {
                //pre-requisite
                string name, membership_No, email, phone, subject, message;
                Users frontenduser = new Users();
                Queries.GetActiveMemberEmail(frontenduser);

                //retrive data from test data file
                name = TestData.ExcelData.TestDataReader.ReadData(1, "Name");
                membership_No = TestData.ExcelData.TestDataReader.ReadData(1, "Membership_No");
                email = TestData.ExcelData.TestDataReader.ReadData(1, "Email");
                phone = TestData.ExcelData.TestDataReader.ReadData(1, "Phone");
                subject = TestData.ExcelData.TestDataReader.ReadData(1, "Subject");
                message = TestData.ExcelData.TestDataReader.ReadData(1, "Message");

                //Navigate to Un-Authenticated contact us page and verify the details
                ElementWait(PageObject_SignIn.Text_Email(), 240);
                Logger.WriteDebugMessage("Landed on Sign In Page");
                DynamicScroll(Driver, PageObject_ContactUs.Navigation_Link_Un_Authenticated_ContactUs()); ContactUs.Navigation_Link_Un_Authenticated_ContactUs();
                ElementWait(PageObject_ContactUs.ContactUs_Filedrag(), 240);
                Helper.DynamicScroll(Driver, PageObject_ContactUs.ContactUs_Filedrag());
                Logger.WriteDebugMessage("File drag and drop got displayed");
                VerifyTextOnPageAndHighLight(name);
                VerifyTextOnPageAndHighLight(membership_No);
                VerifyTextOnPageAndHighLight(email);
                VerifyTextOnPageAndHighLight(phone);
                VerifyTextOnPageAndHighLight(subject);
                VerifyTextOnPageAndHighLight(message);
                Logger.WriteDebugMessage("All the fields are displayed on the  Un-Authenticated contact US Page");

                //Login with Valid Credential and verify the contact us details
                Navigation.Click_Link_SignIn();
                ElementWait(PageObject_SignIn.Text_Email(), 240);
                Logger.WriteDebugMessage("Landed on Sign In Page");
                LoginCredentials(frontenduser.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully.");
                Navigation.Click_Link_ContactUs(ProjectName);
                ElementWait(PageObject_ContactUs.ContactUs_Filedrag(), 240);
                Helper.DynamicScroll(Driver, PageObject_ContactUs.ContactUs_Filedrag());
                Logger.WriteDebugMessage("File drag and drop got displayed");
                VerifyTextOnPageAndHighLight(name);
                VerifyTextOnPageAndHighLight(membership_No);
                VerifyTextOnPageAndHighLight(email);
                VerifyTextOnPageAndHighLight(phone);
                VerifyTextOnPageAndHighLight(subject);
                VerifyTextOnPageAndHighLight(message);
                Logger.WriteDebugMessage("All the fields are displayed on the  Un-Authenticated contact US Page");

                //Log test data into test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Name", name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Membership No", membership_No);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email", email);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Subject", subject);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Message", message);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Phone", phone, true);
            }

        }
        public static void TC_224924()
        {
            if (TestCaseId == Constants.TC_224924)
            {
                //pre-requisite
                string filePath, phoneno, subject, message, imageText;
                Users frontenduser = new Users();
                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                Queries.GetActiveMemberEmail(frontenduser);

                //retrive data from test data file
                filePath = TestData.ExcelData.TestDataReader.ReadData(1, "FilePath");
                phoneno = TestData.ExcelData.TestDataReader.ReadData(1, "PhoneNo");
                subject = TestData.ExcelData.TestDataReader.ReadData(1, "Subject");
                message = TestData.ExcelData.TestDataReader.ReadData(1, "Message");
                imageText = TestData.ExcelData.TestDataReader.ReadData(1, "Image_Text");

                //Navigate to Un-Authenticated contact us page and verify the file name
                ElementWait(PageObject_SignIn.Text_Email(), 240);
                Logger.WriteDebugMessage("Landed on Sign In Page");
                DynamicScroll(Driver, PageObject_ContactUs.Navigation_Link_Un_Authenticated_ContactUs()); ContactUs.Navigation_Link_Un_Authenticated_ContactUs();
                ElementWait(PageObject_ContactUs.ContactUs_Filedrag(), 240);
                Helper.DynamicScroll(Driver, PageObject_ContactUs.ContactUs_Filedrag());
                Logger.WriteDebugMessage("File drag and drop got displayed");
                ContactUs.Select_Contact_US_File(String.Concat(ProjectPath, filePath));
                if (ContactUs.Get_Contact_us_Filename().Contains(imageText))
                {
                    VerifyTextOnPageAndHighLight(imageText);
                    Logger.WriteDebugMessage("File got added succesfully");
                }
                else
                    Assert.Fail("File not got updated on Contact us page");

                //Login with Valid Credential and verify the file name
                Navigation.Click_Link_SignIn();
                ElementWait(PageObject_SignIn.Text_Email(), 240);
                LoginCredentials(frontenduser.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully.");
                Navigation.Click_Link_ContactUs(ProjectName);
                ElementWait(PageObject_ContactUs.ContactUs_Filedrag(), 240);
                ContactUs.EnterNumber_Text_PhoneNumber(phoneno);
                ContactUs.DropDownSelect_Authentication_Subject(subject);
                ContactUs.EnterText_Text_Message(message);
                Helper.DynamicScroll(Driver, PageObject_ContactUs.ContactUs_Filedrag());
                Logger.WriteDebugMessage("File drag and drop got displayed");
                ContactUs.Select_Contact_US_File(String.Concat(ProjectPath, filePath));
                if (ContactUs.Get_Contact_us_Filename().Contains(imageText))
                {
                    VerifyTextOnPageAndHighLight(imageText);
                    Logger.WriteDebugMessage("File got added succesfully");
                }
                else
                    Assert.Fail("File not got updated on Contact us page");

                //Log test data into test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Username", frontenduser.MemberEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Phone No", phoneno);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Subject", subject);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Message", message);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Image Text", imageText);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_FilePath", String.Concat(ProjectPath, filePath), true);
            }
        }
        public static void TC_238611()
        {
            if (TestCaseId == Constants.TC_238611)
            {
                //pre-requisite
                string filePath, validationMessage;
                Users frontenduser = new Users();
                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                Queries.GetActiveMemberEmail(frontenduser);

                //retrive data from test data file
                filePath = TestData.ExcelData.TestDataReader.ReadData(1, "FilePath");
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage");

                //Navigate to Un-Authenticated contact us page and verify the file name
                ElementWait(PageObject_SignIn.Text_Email(), 240);
                Logger.WriteDebugMessage("Landed on Sign In Page");
                DynamicScroll(Driver, PageObject_ContactUs.Navigation_Link_Un_Authenticated_ContactUs()); ContactUs.Navigation_Link_Un_Authenticated_ContactUs();
                ElementWait(PageObject_ContactUs.ContactUs_Filedrag(), 240);
                Helper.DynamicScroll(Driver, PageObject_ContactUs.ContactUs_Filedrag());
                Logger.WriteDebugMessage("File drag and drop got displayed");
                ContactUs.Select_Contact_US_File(String.Concat(ProjectPath, filePath));
                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage("Validation message for displayed for File having size more than 2 MB");
                //Login with Valid Credential and verify the file name
                Navigation.Click_Link_SignIn();
                ElementWait(PageObject_SignIn.Text_Email(), 240);
                LoginCredentials(frontenduser.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully.");
                Navigation.Click_Link_ContactUs(ProjectName);
                ElementWait(PageObject_ContactUs.ContactUs_Filedrag(), 240);

                Helper.DynamicScroll(Driver, PageObject_ContactUs.ContactUs_Filedrag());
                Logger.WriteDebugMessage("File drag and drop got displayed");
                ContactUs.Select_Contact_US_File(String.Concat(ProjectPath, filePath));
                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage("Validation message for displayed for File having size more than 2 MB");

                //Log test data into test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Username", frontenduser.MemberEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_FilePath", String.Concat(ProjectPath, filePath), true);
            }
        }
        public static void TC_237552()
        {
            if (TestCaseId == Constants.TC_237552)
            {
                //pre-requisite
                string filePath, validationMessage;
                Users frontenduser = new Users();

                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                Queries.GetActiveMemberEmail(frontenduser);

                //retrive data from test data file
                filePath = TestData.ExcelData.TestDataReader.ReadData(1, "FilePath");
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage");
                //Navigate to Un-Authenticated contact us page and verify the file name
                ElementWait(PageObject_SignIn.Text_Email(), 240);
                Logger.WriteDebugMessage("Landed on Sign In Page");
                DynamicScroll(Driver, PageObject_ContactUs.Navigation_Link_Un_Authenticated_ContactUs()); ContactUs.Navigation_Link_Un_Authenticated_ContactUs();
                ElementWait(PageObject_ContactUs.ContactUs_Filedrag(), 240);
                Helper.DynamicScroll(Driver, PageObject_ContactUs.ContactUs_Filedrag());
                Logger.WriteDebugMessage("File drag and drop got displayed");

                //Enter more than 5 files
                for (int i = 1; i <= 6; i++)
                {
                    ContactUs.Select_Contact_US_File(String.Concat(ProjectPath, filePath, i.ToString(), ".jpeg"));
                }
                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage("Validation message is getting displayed for more than 5 files on un-authenticated page");

                //Login with Valid Credential and verify the file name
                Navigation.Click_Link_SignIn();
                ElementWait(PageObject_SignIn.Text_Email(), 240);
                LoginCredentials(frontenduser.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully.");
                Navigation.Click_Link_ContactUs(ProjectName);
                ElementWait(PageObject_ContactUs.ContactUs_Filedrag(), 240);

                Helper.DynamicScroll(Driver, PageObject_ContactUs.ContactUs_Filedrag());
                Logger.WriteDebugMessage("File drag and drop got displayed");

                //Enter more than 5 files
                for (int i = 1; i <= 6; i++)
                {
                    ContactUs.Select_Contact_US_File(String.Concat(ProjectPath, filePath, i.ToString(), ".jpeg"));
                }

                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage("Validation message is getting displayed for more than 5 files on un-authenticated page");

                //Log test data into test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Username", frontenduser.MemberEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_FilePath", String.Concat(ProjectPath, filePath), true);
            }
        }
        public static void TC_254265()
        {
            if (TestCaseId == Constants.TC_254265)
            {
                string validationMessage, captchaErrorMessage, subject;
                Users data = new Users();
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage").Trim();
                captchaErrorMessage = TestData.ExcelData.TestDataReader.ReadData(1, "CaptchaValidationMessage").Trim();

                Helper.PageDown();
                Navigation.Click_Contact_Link();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Landed on the Contact Us page.");

                /*Without entering field click on send button*/
                Helper.DynamicScroll(Helper.Driver, PageObject_ContactUs.Button_Send());
                ContactUs.Click_Button_Send();
                Logger.WriteDebugMessage("Landed on the Contact Us page.");
                Helper.VerifyTextOnPageAndHighLight(validationMessage);
                Helper.VerifyTextOnPageAndHighLight(captchaErrorMessage);
                Logger.WriteDebugMessage("Validation message should get displayed");
                Helper.ReloadPage();
                //Verify the validation message for all Subject available
                for (int subjectNumber = 1; subjectNumber < 7; subjectNumber++)
                {
                    Helper.ReloadPage();
                    subject = TestData.ExcelData.TestDataReader.ReadData(subjectNumber, "Subject").Trim();
                    ScrollToElement(PageObject_ContactUs.DDM_Subject());
                    ContactUs.DropDownSelect_Text_Subject(subject);
                    ContactUs.Click_Button_Send();
                    VerifyTextOnPageAndHighLight(validationMessage);
                    Logger.WriteDebugMessage("Validation message should get displayed");

                    VerifyTextOnPageAndHighLight(captchaErrorMessage);
                    Logger.WriteDebugMessage("Validation message should get displayed");

                }
                Logger.WriteDebugMessage("Test case passed successfully");

            }

        }
        #endregion TP_121741
    }
}