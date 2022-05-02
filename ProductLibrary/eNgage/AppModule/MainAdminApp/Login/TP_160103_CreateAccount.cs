using System;
using eNgage.Utility;
using eNgage.AppModule.UI;
using Common;
using Constants = eNgage.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using OpenQA.Selenium;
using NUnit.Framework;
using eNgage.AppModule.UI;
using eNgage.PageObject.UI;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;

namespace eNgage.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_160103]

        private static string dateTime = DateTime.Now.ToString("Mddyyyyhhmm");
        private static string userName = "cendynautomation" + dateTime;

        private static string fname = "Cendyn";
        private static string lname = "Automation";
        private static string accEmail = userName  + "@cendyn17.com";
        private static string accPassword = "Cendyn123$";
        private static string accResetQuestion = "ProductType";
        private static string accResetAnswer = "Hotel Origami Automation";
        private static string accSuccessRegister = "You have successfully registered your account!";
        public static void TC_160960()
        {
            ElementClick(PageObject_Login.CreateAccount());
            if (VerifyTextOnPage("Register a New SSO Account"))
            {
                string errorForm = "Please correct the form before submitting";

                Logger.WriteDebugMessage("Landed on SignUp Page.");

                ElementEnterText(PageObject_SignUp.SignUp_FirstName(), fname);
                ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered FirstName and Clicked on Register without filling other text forms. And received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not received error message - " +  errorForm);
                }

                ElementEnterText(PageObject_SignUp.SignUp_FirstName(), "");
                ElementEnterText(PageObject_SignUp.SignUp_LastName(), lname);
                ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered LastName and Clicked on Register without filling other text forms. And received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not received error message - " + errorForm);
                }

                ElementEnterText(PageObject_SignUp.SignUp_FirstName(), "");
                ElementEnterText(PageObject_SignUp.SignUp_LastName(), "");
                ElementEnterText(PageObject_SignUp.SignUp_Email(), accEmail);
                ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered Email and Clicked on Register without filling other text forms. And received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not received error message - " + errorForm);
                }

                ElementEnterText(PageObject_SignUp.SignUp_FirstName(), "");
                ElementEnterText(PageObject_SignUp.SignUp_LastName(), "");
                ElementEnterText(PageObject_SignUp.SignUp_Email(), "");
                ElementEnterText(PageObject_SignUp.SignUp_Password(), accPassword);
                ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered Password and Clicked on Register without filling other text forms. And received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not received error message - " + errorForm);
                }

                ElementEnterText(PageObject_SignUp.SignUp_FirstName(), "");
                ElementEnterText(PageObject_SignUp.SignUp_LastName(), "");
                ElementEnterText(PageObject_SignUp.SignUp_Email(), "");
                ElementEnterText(PageObject_SignUp.SignUp_ConfirmPassword(), accPassword);
                ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered ConfirmPassword and Clicked on Register without filling other text forms. And received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not received error message - " + errorForm);
                }

                ElementEnterText(PageObject_SignUp.SignUp_FirstName(), "");
                ElementEnterText(PageObject_SignUp.SignUp_LastName(), "");
                ElementEnterText(PageObject_SignUp.SignUp_Email(), "");
                ElementEnterText(PageObject_SignUp.SignUp_Password(), "");
                ElementEnterText(PageObject_SignUp.SignUp_ConfirmPassword(), accPassword);
                ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered ConfirmPassword and Clicked on Register without filling other text forms. And received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not received error message - " + errorForm);
                }

                ElementEnterText(PageObject_SignUp.SignUp_FirstName(), "");
                ElementEnterText(PageObject_SignUp.SignUp_LastName(), "");
                ElementEnterText(PageObject_SignUp.SignUp_Email(), "");
                ElementEnterText(PageObject_SignUp.SignUp_Password(), "");
                ElementEnterText(PageObject_SignUp.SignUp_ConfirmPassword(), "");
                ElementEnterText(PageObject_SignUp.SignUp_PasswordResetQuestion(), accResetQuestion);
                ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered ResetQuestion and Clicked on Register without filling other text forms. And received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not received error message - " + errorForm);
                }

                ElementEnterText(PageObject_SignUp.SignUp_FirstName(), "");
                ElementEnterText(PageObject_SignUp.SignUp_LastName(), "");
                ElementEnterText(PageObject_SignUp.SignUp_Email(), "");
                ElementEnterText(PageObject_SignUp.SignUp_Password(), "");
                ElementEnterText(PageObject_SignUp.SignUp_ConfirmPassword(), "");
                ElementEnterText(PageObject_SignUp.SignUp_PasswordResetQuestion(), "");
                ElementEnterText(PageObject_SignUp.SignUp_PasswordResetAnswer(), accResetAnswer);
                ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered ResetAnswer and Clicked on Register without filling other text forms. And received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not received error message - " + errorForm);
                }

            }
        }
        public static void TC_160961()
        {
            string email1 = "testAtgmail.com";
            string email2 = "test@gmailcom";
            string email3 = "test@gmail";
            string email4 = "@gmai";

            string errorForm = "Please correct the form before submitting";

            ElementClick(PageObject_Login.CreateAccount());
            if (VerifyTextOnPage("Register a New SSO Account"))
            {
                ElementEnterText(PageObject_SignUp.SignUp_FirstName(), fname);
                ElementEnterText(PageObject_SignUp.SignUp_LastName(), lname);
                ElementEnterText(PageObject_SignUp.SignUp_Email(), email1);
                ElementEnterText(PageObject_SignUp.SignUp_Password(), accPassword);
                ElementEnterText(PageObject_SignUp.SignUp_ConfirmPassword(), accPassword);
                ElementEnterText(PageObject_SignUp.SignUp_PasswordResetQuestion(), accResetQuestion);
                ElementEnterText(PageObject_SignUp.SignUp_PasswordResetAnswer(), accResetAnswer);
                ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered incorrect email " + email1 + " and received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not receive error message as expected. " + errorForm);
                }

                ElementEnterText(PageObject_SignUp.SignUp_Email(), email2);
                ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered incorrect email " + email2 + " and received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not receive error message as expected. " + errorForm);
                }
                ElementEnterText(PageObject_SignUp.SignUp_Email(), email3);
                ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered incorrect email " + email3 + " and received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not receive error message as expected. " + errorForm);
                }
                ElementEnterText(PageObject_SignUp.SignUp_Email(), email4);
                ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered incorrect email " + email4 + " and received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not receive error message as expected. " + errorForm);
                }
                ElementEnterText(PageObject_SignUp.SignUp_Email(), accEmail);
                ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(accSuccessRegister))
                {
                    Logger.WriteDebugMessage("Entered valid email " + accEmail + " and received success Message - " + accSuccessRegister);
                }
                else
                {
                    Assert.Fail("Did not receive success message as expected. " + accSuccessRegister);
                }
            }
            else
            {
                Assert.Fail("Did not land on SignUp Page.");
            }
            
        }
        public static void TC_160962()
        {
            string password1 = "test";
            string password2 = "testtest";
            string password3 = "abcd";
            string password4 = "ABCD";
            string password5 = "ABCD12";
            string password6 = "1234";

            string errorForm = "Your password is not secure";

            ElementClick(PageObject_Login.CreateAccount());
            if (VerifyTextOnPage("Register a New SSO Account"))
            {
                ElementEnterText(PageObject_SignUp.SignUp_FirstName(), fname);
                ElementEnterText(PageObject_SignUp.SignUp_LastName(), lname);
                ElementEnterText(PageObject_SignUp.SignUp_Email(), accEmail);
                ElementEnterText(PageObject_SignUp.SignUp_Password(), password1);
                ElementEnterText(PageObject_SignUp.SignUp_ConfirmPassword(), password1);
                ElementEnterText(PageObject_SignUp.SignUp_PasswordResetQuestion(), accResetQuestion);
                ElementEnterText(PageObject_SignUp.SignUp_PasswordResetAnswer(), accResetAnswer);
               // ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered incorrect password " + password1 + " and received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not receive error message as expected. " + errorForm);
                }

                ElementEnterText(PageObject_SignUp.SignUp_Password(), password2);
                ElementEnterText(PageObject_SignUp.SignUp_ConfirmPassword(), password2);
               // ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered incorrect password " + password2 + " and received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not receive error message as expected. " + errorForm);
                }

                ElementEnterText(PageObject_SignUp.SignUp_Password(), password3);
                ElementEnterText(PageObject_SignUp.SignUp_ConfirmPassword(), password3);
                //ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered incorrect password " + password3 + " and received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not receive error message as expected. " + errorForm);
                }

                ElementEnterText(PageObject_SignUp.SignUp_Password(), password4);
                ElementEnterText(PageObject_SignUp.SignUp_ConfirmPassword(), password4);
               // ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered incorrect password " + password4 + " and received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not receive error message as expected. " + errorForm);
                }

                ElementEnterText(PageObject_SignUp.SignUp_Password(), password5);
                ElementEnterText(PageObject_SignUp.SignUp_ConfirmPassword(), password5);
                //ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered incorrect password " + password5 + " and received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not receive error message as expected. " + errorForm);
                }

                ElementEnterText(PageObject_SignUp.SignUp_Password(), password6);
                ElementEnterText(PageObject_SignUp.SignUp_ConfirmPassword(), password6);
                //ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(errorForm))
                {
                    Logger.WriteDebugMessage("Entered incorrect password " + password6 + " and received Validation Message - " + errorForm);
                }
                else
                {
                    Assert.Fail("Did not receive error message as expected. " + errorForm);
                }

                ElementEnterText(PageObject_SignUp.SignUp_FirstName(), fname);
                ElementEnterText(PageObject_SignUp.SignUp_LastName(), lname);
                ElementEnterText(PageObject_SignUp.SignUp_Email(), accEmail);
                ElementEnterText(PageObject_SignUp.SignUp_Password(), accPassword);
                ElementEnterText(PageObject_SignUp.SignUp_ConfirmPassword(), accPassword);
                ElementEnterText(PageObject_SignUp.SignUp_PasswordResetQuestion(), accResetQuestion);
                ElementEnterText(PageObject_SignUp.SignUp_PasswordResetAnswer(), accResetAnswer);
                ElementClick(PageObject_SignUp.SignUp_Register());
                if (VerifyTextOnPage(accSuccessRegister))
                {
                    Logger.WriteDebugMessage("Entered correct password " + accPassword + " and received success signUp Message - " + accSuccessRegister);
                }
                else
                {
                    Assert.Fail("Did not receive message as expected. " + accSuccessRegister);
                }
            }
            else
            {
                Assert.Fail("Did not land on SignUp Page.");
            }

        }
        #endregion[TP_160103]

    }
}
