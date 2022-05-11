using eLoyaltyV3.PageObject.UI;
using OpenQA.Selenium;
using NUnit.Framework;
using eLoyaltyV3.Utility;
using Common;
using BaseUtility.Utility;
using InfoMessageLogger;

namespace eLoyaltyV3.AppModule.UI
{
    class ForgotPassword
    {
        public static void ForgotPassword_LinkText()
        {
            Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_LinkText(), 240);
            Helper.ElementClick(PageObject_ForgotPassword.ForgotPassword_LinkText());
        }

        public static void EnterEmail(string email)
        {
            Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Email(), 240);
            Helper.ElementEnterText(PageObject_ForgotPassword.ForgotPassword_Email(), email);
            Helper.AddDelay(7000);
        }

        public static void ClickRecover()
        {
            Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recover(), 240);
            Helper.ElementClick(PageObject_ForgotPassword.ForgotPassword_Recover());
        }

        public static void SetNewPassword()
        {
            Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recovery(), 240);
            Helper.ElementClick(PageObject_ForgotPassword.ForgotPassword_Recovery());
        }
        
        public static void ClickCancel()
        {
            if(Helper.IsElementPresent(By.XPath("//input[@value='Cancel']")))
            {
                Helper.ElementClick(PageObject_ForgotPassword.ForgotPassword_Cancel());
            }
            else
            {
                Helper.ElementClick(PageObject_ForgotPassword.ForgotPassword_Back());
            }
            
        }

        public static void Click_Button_Accept()
        {
            Helper.ElementWait(PageObject_ForgotPassword.Button_Accept(), 240);
            Helper.ElementClick(PageObject_ForgotPassword.Button_Accept());
        }

        public static void EnterNewPassword(string Password)
        {
            Helper.ElementWait(PageObject_ForgotPassword.NewPassword(), 240);
            Helper.ElementEnterText(PageObject_ForgotPassword.NewPassword(), Password);
        }

        public static void EnterNewConfirmedPassword(string Password)
        {
            Helper.ElementEnterText(PageObject_ForgotPassword.NewPasswordConfirm(), Password);
        }
        
		/// <summary>
        /// This method is used to reset password for an account - Used for ForgotPassword and KioskSignUp TestCases
        /// 1. Case 1: Updating Email without checking validation message.
        /// 2. Case 2: Updating Email with checking validation message.
        /// </summary>
        public static void UpdateEmail(string email, string result, int caseNum)
        {
            switch (caseNum)
            {
                case 1:
                    {
                        EnterEmail(email);
                        Helper.AddDelay(2500);
                        Logger.WriteDebugMessage("Entered Email Address:" + email + " and clicking on Recover button.");
                        ClickRecover();
                        Helper.AddDelay(8000);
                        //Helper.ValitionMessage(result);
                        break;
                    }
                case 2:
                    {
                        EnterEmail(email);
                        Logger.WriteDebugMessage("Entered Email Address:" + email + " and clicking on Recover button.");
                        ClickRecover();
                        Helper.AddDelay(100);
                        Helper.ValitionMessage(result);
                        if (Helper.VerifyTextOnPage(result))
                        {
                            Logger.WriteDebugMessage("Received message :" + result + "for emailaddress: " + email);
                        }
                        else
                        {
                            Logger.WriteDebugMessage("Validation message on the page is different.");
                            Assert.Fail("Validation message on the page is different.");
                        }
                        break;
                        
                    }
                case 3:
                    {
                        EnterEmail(email);
                        Logger.WriteDebugMessage("Entered Email Address:" + email + " and clicking on Recover button.");
                        ClickRecover();
                        Helper.AddDelay(8000);
                        break;

                    }
            }
        }

        /// <summary>
        /// This method is used to reset password for an account - Used for ForgotPassword TestCases
        /// 1. Case 0: Ignores Validation Message to be checked on frontend.
        /// 2. Case 1: Identified required message to be checked on frontend when password is sucessfully changed.
        /// 3. Case 2: Used to identify validation with any missing fields on frontend.
        /// </summary>
        public static void ForgotPasswordNew(string NewPassword, string ValidationMessage, int caseNum)
        {
            switch (caseNum)
            {
                case 0:
                    {
                        EnterNewPassword(NewPassword);
                        Helper.AddDelay(90);
                        EnterNewConfirmedPassword(NewPassword);
                        Logger.WriteDebugMessage("Entered new Password:" + NewPassword + " and clicked on Recover button.");
                        SetNewPassword();                        
                        Helper.AddDelay(10000);
                        break;
                    }
                case 1:
                    {
                        EnterNewPassword(NewPassword);
                        Helper.AddDelay(90);
                        EnterNewConfirmedPassword(NewPassword);
                        Logger.WriteDebugMessage("Entered new Password:" + NewPassword + " and clicked on Recover button.");
                        Helper.AddDelay(5000);
                        SetNewPassword();                      
                        Helper.AddDelay(2500);
                        if (Helper.VerifyTextOnPage(ValidationMessage))
                        {
                            Logger.WriteDebugMessage("Received message :" + ValidationMessage);
                        }
                        else
                        {
                            Logger.WriteDebugMessage("Validation message on the page is different.");
                            Assert.Fail("Validation message on the page is different.");
                        }
                        break;
                    }
                case 2:
                    {
                        EnterNewPassword(NewPassword);
                        Helper.AddDelay(90);
                        EnterNewConfirmedPassword(NewPassword + ".");
                        Logger.WriteDebugMessage("Entered new Password:" + NewPassword + " and clicking on Recover button.");
                        SetNewPassword();                       
                        Helper.AddDelay(10000);
                        if (Helper.VerifyTextOnPage(ValidationMessage))
                        {
                            Logger.WriteDebugMessage("Received message :" + ValidationMessage);
                        }
                        else
                        {
                            Logger.WriteDebugMessage("Validation message on the page is different.");
                            Assert.Fail("Validation message on the page is different.");
                        }
                        break;
                    }
            }
        }
        public static void AdminForgotPassword(string NewPassword, string ValidationMessage)
        {
            EnterNewPassword(NewPassword);
            Helper.AddDelay(90);
            EnterNewConfirmedPassword(NewPassword);
            Logger.WriteDebugMessage("Entered new Password:" + NewPassword + " and clicked on Recover button.");
            Admin.SubmitNewPassword();
            Helper.AddDelay(10000);

        }
        public static void AdminForgotPasswordNew(string NewPassword, string ValidationMessage)
        {
            EnterNewPassword(NewPassword);
            Helper.AddDelay(90);
            EnterNewConfirmedPassword(NewPassword);
            Logger.WriteDebugMessage("Entered new Password:" + NewPassword + " and clicked on Recover button.");
            Admin.ClickRecover();
            Helper.AddDelay(10000);

        }

        /// <summary>
        /// This method is used to reset password for an account - Used for KioskSignUp TestCases
        /// 1. Case 0: Ignores Validation Message to be checked on frontend.
        /// 2. Case 1: Identified required message to be checked on frontend when password is sucessfully changed.
        /// 3. Case 2: Used to identify validation with any missing fields on frontend.
        /// </summary>
        public static void ForgotPasswordKiosk(string NewPassword, string ValidationMessage, int caseNum)
        {
            switch (caseNum)
            {
                case 0:
                    {
                        EnterNewPassword(NewPassword);
                        Helper.AddDelay(90);
                        EnterNewConfirmedPassword(NewPassword);
                        Logger.WriteDebugMessage("Entered new Password:" + NewPassword + " and clicked on Recover button.");
                        SetNewPassword();
                        Helper.AddDelay(2000);
                        if (Helper.IsElementPresent(By.Id("password-recovery-tc")))
                        {
                            Click_Button_Accept();
                        }
                        Helper.AddDelay(2000);
                        break;
                    }
                case 1:
                    {
                        EnterNewPassword(NewPassword);
                        Helper.AddDelay(90);
                        EnterNewConfirmedPassword(NewPassword);
                        Logger.WriteDebugMessage("Entered new Password:" + NewPassword + " and clicked on Recover button.");
                        SetNewPassword();
                        Helper.AddDelay(2000);
                        if (Helper.IsElementPresent(By.Id("password-recovery-tc")))
                        {
                            Click_Button_Accept();
                        }
                        Helper.AddDelay(2000);
                        if (Helper.VerifyTextOnPage(ValidationMessage))
                        {
                            Logger.WriteDebugMessage("Received message :" + ValidationMessage);
                        }
                        else
                        {
                            Logger.WriteDebugMessage("Validation message on the page is different.");
                            Assert.Fail("Validation message on the page is different.");
                        }
                        break;
                    }
                case 2:
                    {
                        EnterNewPassword(NewPassword);
                        Helper.AddDelay(90);
                        EnterNewConfirmedPassword(NewPassword + ".");
                        Logger.WriteDebugMessage("Entered new Password:" + NewPassword + " and clicking on Recover button.");
                        SetNewPassword();
                        Helper.AddDelay(2000);
                        if (Helper.IsElementPresent(By.Id("password-recovery-tc")))
                        {
                            Click_Button_Accept();
                        }
                        Helper.AddDelay(2000);
                        if (Helper.VerifyTextOnPage(ValidationMessage))
                        {
                            Logger.WriteDebugMessage("Received message :" + ValidationMessage);
                        }
                        else
                        {
                            Logger.WriteDebugMessage("Validation message on the page is different.");
                            Assert.Fail("Validation message on the page is different.");
                        }
                        break;
                    }
            }
        }
    }
}
