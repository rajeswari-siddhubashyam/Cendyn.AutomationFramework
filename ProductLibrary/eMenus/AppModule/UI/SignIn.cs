using BaseUtility.Utility;
using eMenus.PageObject.UI;
using InfoMessageLogger;

namespace eMenus.AppModule.UI
{
    public class SignIn
    {


        public static void Enter_Username(string str)
        {
            Helper.ElementEnterText(PageObject_SignIn.TextBox_Username(), str);
        }

        public static void Enter_Password(string str)
        {
            Helper.ElementEnterText(PageObject_SignIn.TextBox_Password(), str);
        }

        public static void Click_SignIn_Button()
        {
            Helper.ElementClick(PageObject_SignIn.Button_SignIn());
        }
        public static string Validation_Message()
        {
            return Helper.GetText(PageObject_SignIn.Validation_Message());
        }

        public static void Frotnend_SignIn(string username, string password)
        {
            Enter_Username(username);
            Enter_Password(password);
            Logger.WriteDebugMessage("Login in with Username =" + username + " and Password =" + password);
            Click_SignIn_Button();


        }

        public static void Next_Button()
        {
            Helper.ElementClick(PageObject_SignIn.Next_Button());

        }
        public static void Enter_Email_Address(string text)
        {
            Helper.ElementEnterText(PageObject_SignIn.Enter_Email_Address(), text);

        }
        public static void Enter_Email_Password(string text)
        {
            Helper.ElementEnterText(PageObject_SignIn.Enter_Email_Password(), text);

        }
        public static void Login_Button()
        {
            Helper.ElementClick(PageObject_SignIn.Login_Button());

        }


    }
}
