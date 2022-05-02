

using System;
using AMR_Agent.PageObject.UI;
using AMR_Agent.Utility;
using BaseUtility.Utility;

namespace AMR_Agent.AppModule.UI
{
    class ForgotPassword : Utility.Setup
    {
        public static string GeneratePassword()
        {
            thisDay = DateTime.Now;
            //return TestData.TC_37518_NewPassword + thisDay.Hour + thisDay.Minute;
            return "Cendyn1234%" + thisDay.Hour + thisDay.Minute;
        }

        public static void ClickButtonLogin()
        {
            Helper.ElementClick(PageObject_ForgotPassword.ForgotPasswordLogin());
        }
        
        public static void EnterEmailAddress(string text)
        {
            Helper.ElementEnterText(PageObject_ForgotPassword.ForgotPasswordEmail(),text);
        }

        public static void ClickRecoveryQuestion()
        {
            Helper.ElementClick(PageObject_ForgotPassword.ForgotPasswordRecoveryQuestion());
        }

        public static void ClickEmailVerificationCode()
        {
            Helper.ElementClick(PageObject_ForgotPassword.ForgotPasswordEmailVerificationCode());
        }

        public static void ClickSubmit()
        {
            Helper.ElementClick(PageObject_ForgotPassword.ForgotPasswordSubmit());
        }

        public static void EnterVerificationCode(string text)
        {
            Helper.ElementEnterText(PageObject_ForgotPassword.ForgotPasswordVerificationCode(), text);
        }

        public static void EnterNewPassword(string text)
        {
            Helper.ElementEnterText(PageObject_ForgotPassword.ForgotPasswordNewPassword(), text);
        }

        public static void EnterConfirmNewPassword(string text)
        {
            Helper.ElementEnterText(PageObject_ForgotPassword.ForgotPasswordNewPasswordConfirmation(), text);
        }

        public static void ClickRecoverySubmit()
        {
            Helper.ElementClick(PageObject_ForgotPassword.ForgotPasswordRecoverySubmit());
        }

        public static string GetVerificationCode()
        {
            string code = PageObject_ForgotPassword.ForgotPasswordMailVerificationCode().GetAttribute("innerHTML");
            String[] actualCode = code.Split(':');
            string verificationCode = actualCode[1];
            return verificationCode;
        }

    }
}
