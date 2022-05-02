using AMR_Agent.PageObject.UI;
using BaseUtility.Utility;
using InfoMessageLogger;

namespace AMR_Agent.AppModule.UI
{
    public class Login : Setup
    {

        public static void EnterEmail(string email)
        {
            PageObject_Login.LoginEmail().Clear();
            PageObject_Login.LoginEmail().SendKeys(email);
            Logger.WriteInfoMessage("RegEmail address is entered.");
        }

        public static void EnterPassword(string password)
        {
            PageObject_Login.LoginPassword().Clear();
            PageObject_Login.LoginPassword().SendKeys(password);
            Logger.WriteInfoMessage("Password is entered.");
        }

        public static void ClickAgreeandProceed()
        {
            Helper.ElementClick(PageObject_Login.LoginAcceptConsentToCookies());
        }

        public static void ClickClose()
        {
            Helper.ElementClick(PageObject_Login.LoginClose());
        }

        public static void ClickLoginForgotPassword()
        {
            Helper.ElementClick(PageObject_Login.LoginForgotPassword());
        }

    }
}
