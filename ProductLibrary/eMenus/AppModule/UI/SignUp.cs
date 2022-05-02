using BaseUtility.Utility;
using eMenus.PageObject.UI;

namespace eMenus.AppModule.UI
{
    public class SignUp
    {
       public static void Click_CreateAccount()
        {
            Helper.ElementClick(PageObject_SignUp.Link_CreateAccount());
        }
        public static void EnterText_Text_FirstName(string text)
        {
            Helper.ElementEnterText(PageObject_SignUp.TextBox_FirstName(), text);
        }
        public static void EnterText_Text_LastName(string text)
        {
            Helper.ElementEnterText(PageObject_SignUp.TextBox_LastName(), text);
        }
        public static void EnterText_Text_Email(string text)
        {
            Helper.ElementEnterText(PageObject_SignUp.TextBox_Email(), text);
        }
        public static void EnterText_Text_Phone(string text)
        {
            Helper.ElementEnterText(PageObject_SignUp.TextBox_Phone(), text);
        }
       
        public static void EnterText_Text_Password(string text)
        {
            Helper.ElementEnterText(PageObject_SignUp.TextBox_Password(), text);
        }
        public static void EnterText_Text_Confirm_Password(string text)
        {
            Helper.ElementEnterText(PageObject_SignUp.TextBox_Confirm_Password(), text);
        }
        public static void Click_SignUp_Button()
        {
            Helper.ElementClick(PageObject_SignUp.Button_SignUp());
        }
        public static string FirstName_Validation()
        {
           return Helper.GetText(PageObject_SignUp.FirstName_Validation());
        }
        public static string LastName_Validation()
        {
            return Helper.GetText(PageObject_SignUp.LastName_Validation());
        }
        public static string Phone_Validation()
        {
            return Helper.GetText(PageObject_SignUp.Phone_Validation());
        }
        public static string Email_Validation()
        {
            return Helper.GetText(PageObject_SignUp.Email_Validation());
        }
        public static string Password_Validation()
        {
           return Helper.GetText(PageObject_SignUp.Password_Validation());
        }
        public static string ConfirmPassword_Validation()
        {
            return Helper.GetText(PageObject_SignUp.ConfirmPassword_Validation());
        }
        public static string Existing_Email_Validation()
        {
            return PageObject_SignUp.Existing_Email_Validation().GetAttribute("innerHTML");
        }
        public static void Click_SignIn_Button()
        {
            Helper.ElementClick(PageObject_SignUp.Create_Success_SignIn_Link());
        }
        public static void SignUpUser(string firstname, string lastname, string phone, string email, string password, string confirmpassword)
        {
            EnterText_Text_FirstName(firstname);
            EnterText_Text_LastName(lastname);
            EnterText_Text_Phone(phone);
            EnterText_Text_Email(email);
            EnterText_Text_Password(password);
            EnterText_Text_Confirm_Password(confirmpassword);
        }
    }
}
