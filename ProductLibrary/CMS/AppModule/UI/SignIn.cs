using BaseUtility.Utility;
using InfoMessageLogger;
using CMS.PageObject.UI;

namespace CMS.AppModule.UI
{
    public class SignIn: Helper

    {
        /// <summary>
        /// This method will enter the email address on the MarketingAutomation SignIn page.
        /// </summary>
        /// <param name="email">email to enter</param>
        public static void EnterEmailAddress(string email)
        {
            ElementEnterText(PageObject_SignIn.Input_Email(), email);
        }

        /// <summary>
        /// This method will enter the password on the MarketingAutomation SignIn page.
        /// </summary>
        /// <param name="password">Password to enter.</param>
        public static void EnterPassword(string password)
        {
            ElementEnterText(PageObject_SignIn.Input_Password(), password);
            Logger.WriteDebugMessage("Entered email and password");
        }
        /// <summary>
        /// This method will click on SignIn button on the  MarketingAutomation SignIn page.
        /// </summary>
        public static void ClickOnSignInButton()
        {
            ElementClick(PageObject_SignIn.Button_SignIn());
        }

        public static void LoginWithValidCredentials(string username, string password)
        {
            Helper.WaitForAjaxControls(30);
            SignIn.EnterEmailAddress(username);
            SignIn.EnterPassword(password);
            SignIn.ClickOnSignInButton();
            Helper.WaitForAjaxControls(50);
        }
    }
}
