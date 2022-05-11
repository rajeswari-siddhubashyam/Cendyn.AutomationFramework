using BaseUtility.Utility;
using eMenus.PageObject.UI;
using InfoMessageLogger;

namespace eMenus.AppModule.UI
{
    class ForgetPassword
    {
        public static void Click_ForgetPassword()
        {
            Helper.ElementClick(PageObject_ForgetPassword.Click_ForgetPassword());
        }
        public static void Click_ForgetPassword_BackButton()
        {
            Helper.ElementClick(PageObject_ForgetPassword.Click_ForgetPassword_BackButton());
        }

        public static void ForgetPassword_Email(string text)
        {
            Helper.ElementEnterText(PageObject_ForgetPassword.ForgetPassword_Email(), text);
        }
        public static void Click_ForgetPassword_SendButton()
        {
            Helper.ElementClick(PageObject_ForgetPassword.Click_ForgetPassword_SendButton());
        }

        public static string Forget_Password_Validation()
        {
            return Helper.GetText(PageObject_ForgetPassword.Forget_Password_Validation());
        }
        public static void ResetPassword_EnterEmail(string email)
        {
            Helper.ElementEnterText(PageObject_ForgetPassword.ResetPassword_Email(), email);
        }
        public static void ResetPassword_EnterPassword(string password)
        {
            Helper.ElementEnterText(PageObject_ForgetPassword.ResetPassword_Password(), password);
        }
        public static void ResetPassword_EnterConfirmPassword(string password)
        {
            Helper.ElementEnterText(PageObject_ForgetPassword.ResetPassword_ConfirmPassword(), password);
        }
        public static void Click_ResetPassword_Button()
        {
            Helper.ElementClick(PageObject_ForgetPassword.ResetPassword_Button());
        }

        public static void ResetPassword(string email, string password, string confirmpassword)
        {
            ResetPassword_EnterEmail(email);
            ResetPassword_EnterPassword(password);
            ResetPassword_EnterConfirmPassword(confirmpassword);
            Logger.WriteDebugMessage("All Details are Entered Successfully");
            Click_ResetPassword_Button();
        }
    }
}
