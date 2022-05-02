using AMR_Agent.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace AMR_Agent.PageObject.UI
{
    class PageObject_ForgotPassword : Setup
    {
        /*
        / These methods will return the element on the page by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
        */

        public static IWebElement ForgotPasswordEmail()
        {
            ScanPage(Constants.ModuleForgotPassword);
            return PageAction.Find_ElementId(ObjectRepository.ForgotPasswordEmail);
        }

        public static IWebElement ForgotPasswordValidationMobile()
        {
            ScanPage(Constants.ModuleForgotPassword);
            return PageAction.Find_ElementId(ObjectRepository.ForgotPasswordValidationMobile);
        }

        public static IWebElement ForgotPasswordValidationEmail()
        {
            ScanPage(Constants.ModuleForgotPassword);
            return PageAction.Find_ElementId(ObjectRepository.ForgotPasswordValidationEmail);
        }

        public static IWebElement ForgotPasswordRecoveryQuestionRadioButton()
        {
            ScanPage(Constants.ModuleForgotPassword);
            return PageAction.Find_ElementId(ObjectRepository.ForgotPasswordRecoveryQuestion);
        }

        public static IWebElement ForgotPasswordSubmit()
        {
            ScanPage(Constants.ModuleForgotPassword);
            return PageAction.Find_ElementId(ObjectRepository.ForgotPasswordSubmit);
        }

        public static IWebElement ForgotPasswordCancel()
        {
            ScanPage(Constants.ModuleForgotPassword);
            return PageAction.Find_ElementId(ObjectRepository.ForgotPasswordCancel);
        }

        public static IWebElement ForgotPasswordRecoveryAnswer()
        {
            ScanPage(Constants.ModuleForgotPassword);
            return PageAction.Find_ElementId(ObjectRepository.ForgotPasswordRecoveryAnswer);
        }

        public static IWebElement ForgotPasswordNewPassword()
        {
            ScanPage(Constants.ModuleForgotPassword);
            return PageAction.Find_ElementId(ObjectRepository.ForgotPasswordNewPassword);
        }

        public static IWebElement ForgotPasswordNewPasswordConfirmation()
        {
            ScanPage(Constants.ModuleForgotPassword);
            return PageAction.Find_ElementId(ObjectRepository.ForgotPasswordNewPasswordConfirmation);
        }

        public static IWebElement ForgotPasswordRecoverySubmit()
        {
            ScanPage(Constants.ModuleForgotPassword);
            return PageAction.Find_ElementId(ObjectRepository.ForgotPasswordRecoverySubmit);
        }

        public static IWebElement ForgotPasswordRecoveryCancel()
        {
            ScanPage(Constants.ModuleForgotPassword);
            return PageAction.Find_ElementId(ObjectRepository.ForgotPasswordRecoveryCancel);
        }

        public static IWebElement ForgotPasswordLogin()
        {
            ScanPage(Constants.ModuleForgotPassword);
            return PageAction.Find_ElementId(ObjectRepository.ForgotPasswordLogin);
        }

        public static IWebElement ForgotPasswordEmailVerificationCode()
        {
            ScanPage(Constants.ModuleForgotPassword);
            return PageAction.Find_ElementId(ObjectRepository.ForgotPassword_EmailVerificationCode);
        }

        public static IWebElement ForgotPasswordRecoveryQuestion()
        {
            ScanPage(Constants.ModuleForgotPassword);
            return PageAction.Find_ElementId(ObjectRepository.ForgotPassword_RecoveryQuestion);
        }

        public static IWebElement ForgotPasswordVerificationCode()
        {
            ScanPage(Constants.ModuleForgotPassword);
            return PageAction.Find_ElementId(ObjectRepository.ForgotPassword_VerificationCode);
        }

        public static IWebElement ForgotPasswordMailVerificationCode()
        {
            ScanPage(Constants.ModuleForgotPassword);
            return PageAction.Find_ElementXPath(ObjectRepository.ForgotPassword_CatchAllMail_VerificationCode);
        }


    }
}
