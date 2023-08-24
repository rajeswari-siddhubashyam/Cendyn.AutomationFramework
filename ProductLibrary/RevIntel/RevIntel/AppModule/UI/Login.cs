using BaseUtility.Utility;
using InfoMessageLogger;
using RevIntel.PageObject.UI;
using GlobalParam = RevIntel.Utility.GlobalParameter;
using RevIntel.AppModule.UI;

namespace RevIntel.AppModule.UI
{
    public class Login
    {
        public static void Enter_EmailAddress(string str)
        {
            Helper.ElementWait(PageObject_Login.Enter_EmailAddress(), 240);
            Helper.ElementEnterText(PageObject_Login.Enter_EmailAddress(), str);
        }

        public static void Enter_Password(string str)
        {
            Helper.ElementWait(PageObject_Login.Enter_Password(), 240);
            Helper.ElementEnterText(PageObject_Login.Enter_Password(), str);
        }

        public static void Click_SignIn_Button()
        {
            Helper.ElementClick(PageObject_Login.Click_SignIn_Button());
        }
        public static void LogOut_Button()
        {
            Helper.ElementClick(PageObject_Login.LogOut_Button());
        }
        public static void Select_DropDown()
        {
            Helper.ElementClick(PageObject_Login.Select_DropDown());
        }
        public static void Click_Next_Button()
        {
            Helper.ElementWait(PageObject_Login.Click_Next_Button(), 240);
            Helper.ElementClick(PageObject_Login.Click_Next_Button());
        }
        

        public static void Frontend_SignIn(string username, string password)
        {
            Enter_EmailAddress(username);
            Logger.WriteDebugMessage("Email Address displayed"); 
            Click_Next_Button();
            Enter_Password(password);
            Logger.WriteDebugMessage("Login in with Username =" + username + " and Password =" + password);
            Click_SignIn_Button();
        }

        public static void Prod_Frontend_SignIn(string username, string password)
        {
            Enter_EmailAddress(username);
            Logger.WriteDebugMessage("Email Address displayed");
            Click_Next_Button();
            Enter_Password(password);
            Logger.WriteDebugMessage("Login in with Username =" + username + " and Password =" + password);
            Click_SignIn_Button();
        }

        public static void Login_SelectCLient()
        {
            //Retrieve data from Database or test data file
            string userName = GlobalParam.Username;
            string password = GlobalParam.Password;
            string client = GlobalParam.Client;

            Frontend_SignIn(userName, password);

            //Select Client 
            Navigation.Select_Client(client);
        }
    }
}
