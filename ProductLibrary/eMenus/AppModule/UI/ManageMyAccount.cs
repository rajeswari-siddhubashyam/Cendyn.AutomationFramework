using BaseUtility.Utility;
using eMenus.PageObject.UI;
using InfoMessageLogger;

namespace eMenus.AppModule.UI
{
    class ManageMyAccount : eMenus.Utility.Setup
    {
        public static void Click_MyOrder_ManageMyAccount()
        {
            Helper.ElementClick(PageObject_ManageMyAccount.Click_MyOrder_ManageMyAccount());
        }
        public static void Click_MyOrder_MyOrder()
        {
            Helper.ElementClick(PageObject_ManageMyAccount.Click_MyOrder_MyOrder());
        }
        public static void ManageMyAccount_FirstName(string text)
        {
            Helper.ElementClearText(PageObject_ManageMyAccount.ManageMyAccount_FirstName());
            Helper.AddDelay(5000);
            Helper.ElementEnterText(PageObject_ManageMyAccount.ManageMyAccount_FirstName(),text);
        }
        public static void ManageMyAccount_LastName(string text)
        {
            Helper.ElementEnterText(PageObject_ManageMyAccount.ManageMyAccount_LastName(), text);
        }
        public static void ManageMyAccount_Address(string text)
        {
            Helper.ElementEnterText(PageObject_ManageMyAccount.ManageMyAccount_Address(), text);
        }
        public static void ManageMyAccount_Address2(string text)
        {
            Helper.ElementEnterText(PageObject_ManageMyAccount.ManageMyAccount_Address2(), text);
        }
        public static void ManageMyAccount_Country(string text)
        {
            //Helper.ElementClick(PageObject_ManageMyAccount.ManageMyAccount_Country());
            Helper.ElementSelectFromDropDown(PageObject_ManageMyAccount.ManageMyAccount_Country(), text);
        }
        public static void ManageMyAccount_State(string text)
        {
            Helper.ElementEnterText(PageObject_ManageMyAccount.ManageMyAccount_State(), text);
        }
        public static void ManageMyAccount_City(string text)
        {
            Helper.ElementEnterText(PageObject_ManageMyAccount.ManageMyAccount_City(), text);
        }
        public static void ManageMyAccount_PostalCode(string text)
        {
            Helper.ElementEnterText(PageObject_ManageMyAccount.ManageMyAccount_PostalCode(), text);
        }
        public static void ManageMyAccount_Phone(string text)
        {
            Helper.ElementEnterText(PageObject_ManageMyAccount.ManageMyAccount_Phone(), text);
        }
        public static void ManageMyAccount_Company(string text)
        {
            Helper.ElementEnterText(PageObject_ManageMyAccount.ManageMyAccount_Company(), text);
        }
        public static void ManageMyAccount_BackButton()
        {
            Helper.ElementClick(PageObject_ManageMyAccount.ManageMyAccount_BackButton());
        }
        public static void ManageMyAccount_UpdateButton()
        {
            Helper.ElementClick(PageObject_ManageMyAccount.ManageMyAccount_UpdateButton());
        }
        public static string ManageMyAccount_FirstnameValidation()
        {
            return Helper.GetText(PageObject_ManageMyAccount.ManageMyAccount_FirstnameValidation());
        }
        public static string ManageMyAccount_LastnameValidation()
        {
            return Helper.GetText(PageObject_ManageMyAccount.ManageMyAccount_LastNameValidation());
        }
        public static string ManageMyAccount_PhoneValidation()
        {
            return Helper.GetText(PageObject_ManageMyAccount.ManageMyAccount_PhoneValidation());
        }
        public static void Click_Update_Password_Checkbox()
        {
            Helper.ElementClick(PageObject_ManageMyAccount.ManageMyAccount_Update_Password_Checkbox());
        }
        public static void ManageMyAccount_Update_Password(string text)
        {
            Helper.ElementEnterText(PageObject_ManageMyAccount.ManageMyAccount_Update_Password(), text);
        }
        public static void ManageMyAccount_Update_Confirm_Password(string text)
        {
            Helper.ElementEnterText(PageObject_ManageMyAccount.ManageMyAccount_Update_Confirm_Password(), text);
        }
        public static void ManageMyAccount_AccountInformation(string fname,string lname,string address,string address2,string country,string state,string city,string postalCode,string phone,string company)
        {
            ManageMyAccount_FirstName(fname);
            ManageMyAccount_LastName(lname);
            ManageMyAccount_Address(address);
            ManageMyAccount_Address2(address2);
            ManageMyAccount_Country(country);
            ManageMyAccount_State(state);
            ManageMyAccount_City(city);
            ManageMyAccount_PostalCode(postalCode);
            ManageMyAccount_Phone(phone);
            ManageMyAccount_Company(company);
        }
        public static void ManageMyAccount_EnterMandatoryFields(string firstname, string lastname, string phone)
        {
            ManageMyAccount_FirstName(firstname);
            ManageMyAccount_LastName(lastname);
            ManageMyAccount_Phone(phone);
        }
        public static void ClearManageAccountDetails()
        {
            PageObject_ManageMyAccount.ManageMyAccount_FirstName().Clear();
            PageObject_ManageMyAccount.ManageMyAccount_LastName().Clear();
            PageObject_ManageMyAccount.ManageMyAccount_Address().Clear();
            PageObject_ManageMyAccount.ManageMyAccount_Address2().Clear();
            PageObject_ManageMyAccount.ManageMyAccount_State().Clear();
            PageObject_ManageMyAccount.ManageMyAccount_City().Clear();
            PageObject_ManageMyAccount.ManageMyAccount_PostalCode().Clear();
            PageObject_ManageMyAccount.ManageMyAccount_Phone().Clear();
            PageObject_ManageMyAccount.ManageMyAccount_Company().Clear();
        }
        public static void UpdatePassword(string password, string confirm_password, string confirmationmessage)
        {
            Click_Update_Password_Checkbox();
            Logger.WriteDebugMessage("Update Password Check-box is checked");
            ManageMyAccount_Update_Password(password);
            ManageMyAccount_Update_Confirm_Password(confirm_password);
            Logger.WriteDebugMessage("Password and Confirm Password is entered correctly");
            ManageMyAccount_UpdateButton();
            VerifyTextOnPageAndHighLight(confirmationmessage);
            Logger.WriteDebugMessage("Password Updated Successfully");
            ManageMyAccount_BackButton();
            Logger.WriteDebugMessage("Navigated to Welcome Page");

        }
    }
}
