using System;
using eLoyaltyV3.AppModule.UI;
using System.Collections.Generic;
using NUnit.Framework;
using TestData;
using eLoyaltyV3.Entity;
using BaseUtility.Utility;
using eLoyaltyV3.PageObject.Admin;
using InfoMessageLogger;
using Queries = eLoyaltyV3.Utility.Queries;
using Constants = eLoyaltyV3.Utility.Constants;
using System.Runtime.InteropServices;
using AventStack.ExtentReports.Model;
using OpenQA.Selenium;
using System.Security;
using System.Net.Mail;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eLoyaltyV3.Utility.Setup
    {
        public static void TC_264512()
        {
            
            if (TestCaseId == Constants.TC_264512)
            {
                //pre-requiste
                string emailTemplete, emailValidation, invalidEmailValidation, invalidEmail, validEmail;
                Users data = new Users();
                Queries.GetActiveTestEmailTemplate(data);


                //Retrive data from test data
                emailTemplete = TestData.ExcelData.TestDataReader.ReadData(1, "FromEmail");
                emailValidation = TestData.ExcelData.TestDataReader.ReadData(1, "EmailValidation");
                invalidEmailValidation = TestData.ExcelData.TestDataReader.ReadData(1, "InvalidEmailValidation");

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to Email Setup Tab
                Admin.Click_Menu_EmailSetuUp();
                Logger.WriteDebugMessage("Navigated to Admin Email Setup Page");

                //Verify fields available in Member level grid
                Admin.Enter_Filter_EmailSetup_SearchEmail(data.EmailName);
                if (PageObject_Admin.Button_EmailSetup_EditEmail().Displayed)
                    Logger.WriteDebugMessage("Email is Getting Displayed on the Dashboard");
                else
                    Assert.Fail("Email Not Found");

                Admin.Click_Button_EmailSetup_EditEmail();
                if (PageObject_Admin.Input_EmailSetup_FromEmail().Displayed)
                {
                    VerifyTextOnPageAndHighLight(emailTemplete);
                    Logger.WriteDebugMessage("Email field with place holder is displayed on Edit Overlay ");
                }

                //Verify the validation message for From Email text box.
                Admin.Enter_Input_EmailSetup_FromEmail("");
                Logger.WriteDebugMessage("Clear the From Email Field");
                Admin.Click_Button_EmailSetup_Save();
                VerifyTextOnPageAndHighLight(emailValidation);
                Logger.WriteDebugMessage("Validation Message for From Email address got displayed and From email field is requried field");

                //TC_264513
                //Verify saving the Email by entering the inValid Email Format 
                for (int i = 1; i < 13; i++)
                {
                    invalidEmail = TestData.ExcelData.TestDataReader.ReadData(i, "Email");
                    Admin.Enter_Input_EmailSetup_FromEmail(invalidEmail);
                    Logger.WriteDebugMessage("Entered = " + invalidEmail + " email address in From Email Field");
                    Admin.Click_Button_EmailSetup_Save();
                    VerifyTextOnPageAndHighLight(invalidEmailValidation);
                    Logger.WriteDebugMessage("Validation for invalid Email address got displayed");
                }
                Admin.Click_Button_EmailSetup_Cancel();
                Logger.WriteDebugMessage("Clicked on Cancel Button and Email Dashboard Got Displayed");

                //TC_264514
                //Verify saving the Email by Entering the valid Email Format
                for (int i = 13; i < 22; i++)
                {
                    Admin.Click_Button_EmailSetup_EditEmail();
                    validEmail = TestData.ExcelData.TestDataReader.ReadData(i, "Email");
                    Admin.Enter_Input_EmailSetup_FromEmail(validEmail);
                    Logger.WriteDebugMessage("Entered = " + validEmail + " email address in From Email Field");
                    Admin.Click_Button_EmailSetup_Save();
                    ElementWait(PageObject_Admin.Button_EmailSetup_Add_Email(), 240);
                    Logger.WriteDebugMessage(validEmail + " = is a Valid Email Address");
                }

                //Log Test data into Log file and extend Report
                for(int i =1;i<=12;i++)
                {
                    invalidEmail = TestData.ExcelData.TestDataReader.ReadData(i, "Email");
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Invalid Email "+i, invalidEmail);
                }
                for (int i = 13; i <= 21; i++)
                {
                    validEmail = TestData.ExcelData.TestDataReader.ReadData(i, "Email");
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Valid Email " + i, validEmail);
                }
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Required Email Validation", emailValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Invalid Email Validation", invalidEmailValidation, true);

            }

        }
        public static void TC_264521()
        {
            try
            {

                if (TestCaseId == Constants.TC_264521)
                {
                    Users data = new Users();
                    Queries.GetActiveTestEmailTemplate(data);
                    Queries.GetActiveMemberEmail(data);
                    string fromEmail1, fromEmail2;

                    //Retrive data from test data
                    fromEmail1 = TestData.ExcelData.TestDataReader.ReadData(1, "FromEmail");
                    fromEmail2 = TestData.ExcelData.TestDataReader.ReadData(2, "FromEmail");

                    // Navigate to Admin
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //Navigate to Email Setup Tab
                    Admin.Click_Menu_EmailSetuUp();
                    Logger.WriteDebugMessage("Navigated to Admin Email Setup Page");

                    //Verify fields available in Member level grid
                    Admin.Enter_Filter_EmailSetup_SearchEmail(data.EmailName);
                    if (PageObject_Admin.Button_EmailSetup_EditEmail().Displayed)
                        Logger.WriteDebugMessage("Email is Getting Displayed on the Dashboard");
                    else
                        Assert.Fail("Email Not Found");

                    //Cliick on Edit button for email
                    Admin.Click_Button_EmailSetup_EditEmail();
                    if (PageObject_Admin.Input_EmailSetup_FromEmail().Displayed)
                    {
                        Logger.WriteDebugMessage("Edit Overlay got Displayed");
                    }

                    //Update From Email Address and Save the changes
                    Admin.Enter_Input_EmailSetup_FromEmail(fromEmail1);
                    Logger.WriteDebugMessage("Entered From Email address in field");
                    Admin.Click_Button_EmailSetup_Save();
                    ElementWait(PageObject_Admin.Button_EmailSetup_Add_Email(), 240);
                    Logger.WriteDebugMessage("Changes got saved and Updated From email as " + fromEmail1);

                    //Trigger email from Admin
                    Admin.Click_Menu_Home();
                    Logger.WriteDebugMessage("Landed on Admin Home Page");
                    Admin.EnterEmail(data.MemberEmail);
                    Logger.WriteDebugMessage("Entered Active Email address");
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member Got Displayed");
                    Admin.Click_Icon_View(ProjectName);
                    Helper.ElementWait(PageObject_Admin.MemberInformation_Value_MemberLogin(), 240);
                    Logger.WriteDebugMessage("Landed on Member Information Page");
                    Admin.SendActivationEmail();

                    //Login to CatchAll and Verify the Email
                    OpenNewTab();
                    ControlToNextWindow();
                    Email.LogIntoCatchAll();
                    Time.AddDelay(10000);
                    Helper.ReloadPage();
                    Hotmail.CheckOutLook();
                    Hotmail.SearchEmail(data.MemberEmail);
                    Hotmail.OpenLatestEmailSingleClick();
                    /*try
                    {   
                        try
                        {
                            ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][4]")));
                        }
                        catch
                        {
                            try
                            {
                                ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][3]")));
                            }
                            catch
                            {
                                ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][2]")));
                            }
                        }


                    }
                    catch
                    {
                        ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][1]")));
                    }*/
                    Helper.PageDown();
                    if (Admin.CatchAllEmailname().Contains(data.MemberEmail))
                        Logger.WriteDebugMessage("From email address = " + data.MemberEmail + "found on the page for Activation Email");
                    else
                        Assert.Fail("From email address does not found on the page for Activation Email");

                    //Trigger one more email from Admin
                    ControlToPreviousWindow();
                    Admin.SendWelcomeEmail();
                    ControlToNextWindow();
                    Helper.ReloadPage();
                    Hotmail.CheckOutLook();
                    Hotmail.SearchEmail(data.MemberEmail);
                    Hotmail.OpenLatestEmailSingleClick();
                    /*
                    try
                    {
                        ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][4]")));
                    }
                    catch (Exception ex)
                    {
                        ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][1]")));
                    }*/
                    Helper.PageDown();
                    if (Admin.CatchAllEmailname().Contains(data.MemberEmail))
                        Logger.WriteDebugMessage("From email address = " + data.MemberEmail + "found on the page for Welcome Email");
                    else
                        Assert.Fail("From email address does not found on the page for Welcome Email");

                    //Verify the Email in Database on propertysetting and PropertyEmailSettings tables
                    Queries.GetSettingValueFromPropertySettings(data);
                    Queries.GetFromEmailFromPropertyEmailSettings(data);
                    if (data.SettingValue == fromEmail1 && data.EmailFromAddress == fromEmail1)
                        Logger.WriteInfoMessage("From Email address = " + fromEmail1 + " is reflecting correctly on Property Settings and PropertyEmailSettings Table");
                    else
                        Assert.Fail("From Email address = " + fromEmail1 + " is not reflecting correctly on Property Settings and PropertyEmailSettings Table");


                    //Update the From Email address to old email address
                    ControlToPreviousWindow();
                    Logger.WriteDebugMessage("Landed on Admin Email Setup Page");
                    Admin.Click_Menu_EmailSetuUp();
                    Logger.WriteDebugMessage("Navigated to Admin Email Setup Page");
                    Admin.Enter_Filter_EmailSetup_SearchEmail(data.EmailName);
                    if (PageObject_Admin.Button_EmailSetup_EditEmail().Displayed)
                        Logger.WriteDebugMessage("Email is Getting Displayed on the Dashboard");
                    else
                        Assert.Fail("Email Not Found");
                    Admin.Click_Button_EmailSetup_EditEmail();
                    if (PageObject_Admin.Input_EmailSetup_FromEmail().Displayed)
                    {
                        Logger.WriteDebugMessage("Edit Overlay got Displayed");
                    }
                    Admin.Enter_Input_EmailSetup_FromEmail(fromEmail2);
                    Logger.WriteDebugMessage("Entered From Email address in field");
                    Admin.Click_Button_EmailSetup_Save();
                    ElementWait(PageObject_Admin.Button_EmailSetup_Add_Email(), 240);
                    Logger.WriteDebugMessage("Changes got saved and Updated From email as " + fromEmail2);

                    //Trigger Another email from new FromEmail and verify the email
                    Admin.Click_Menu_Home();
                    Logger.WriteDebugMessage("Landed on Admin Home Page");
                    Admin.EnterEmail(data.MemberEmail);
                    Logger.WriteDebugMessage("Entered Active Email address");
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member Got Displayed");
                    Admin.Click_Icon_View(ProjectName);
                    Helper.ElementWait(PageObject_Admin.MemberInformation_Value_MemberLogin(), 240);
                    Logger.WriteDebugMessage("Landed on Member Information Page");
                    Admin.SendActivationEmail();

                    //Verify the Email in catchall
                    ControlToNextWindow();
                    Helper.ReloadPage();
                    Hotmail.CheckOutLook();
                    Hotmail.SearchEmail(data.MemberEmail);
                    Hotmail.OpenLatestEmailSingleClick();
                    /*try
                    {
                        ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][4]")));
                    }
                    catch (Exception ex)
                    {
                        ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][1]")));
                    }*/
                    Helper.PageDown();
                    if (Admin.CatchAllEmailname().Contains("hotelorigami@cendyn.com"))
                        Logger.WriteDebugMessage("From email address = hotelorigami@cendyn.com found on the page for Activation Email");
                    else
                        Assert.Fail("From email address does not found on the page for Activation Email");

                    //Trigger one more email from Admin
                    ControlToPreviousWindow();
                    Admin.SendWelcomeEmail();
                    ControlToNextWindow();
                    Helper.ReloadPage();
                    Hotmail.CheckOutLook();
                    Hotmail.SearchEmail(data.MemberEmail);
                    Hotmail.OpenLatestEmailSingleClick();
                    /* try
                     {
                         ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][4]")));
                     }
                     catch (Exception ex)
                     {
                         ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][1]")));
                     }*/
                    Helper.PageDown();
                    if (Admin.CatchAllEmailname().Contains("hotelorigami@cendyn.com"))
                        Logger.WriteDebugMessage("From email address = hotelorigami@cendyn.com  found on the page for Welcome Email");
                    else
                        Assert.Fail("From email address does not found on the page for Welcome Email");

                    //Verify the Email in Database on propertysetting and PropertyEmailSettings tables
                    Queries.GetSettingValueFromPropertySettings(data);
                    Queries.GetFromEmailFromPropertyEmailSettings(data);
                    if (data.SettingValue == fromEmail2 && data.EmailFromAddress == fromEmail2)
                        Logger.WriteInfoMessage("From Email address = " + fromEmail2 + " is reflecting correctly on Property Settings and PropertyEmailSettings Table");
                    else
                        Assert.Fail("From Email address = " + fromEmail2 + " is not reflecting correctly on Property Settings and PropertyEmailSettings Table");

                    //Log Test data into Log file and extend Report
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_1st From Email Address", fromEmail1);
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_2nd From Email Address", fromEmail2, true);

                }
            }
            catch (Exception e) { }
        }
    }
}