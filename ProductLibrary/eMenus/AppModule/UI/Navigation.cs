using BaseUtility.Utility;
using eMenus.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;

namespace eMenus.AppModule.UI
{
    public class Navigation : BaseUtility.AppModule.UI.Navigation
    {
       public static void VerifyValidationMessage(string actualValidationmessage, string expectedValidationMessage)
        {
            if (actualValidationmessage.Equals(expectedValidationMessage))
            { 
                Helper.VerifyTextOnPageAndHighLight(actualValidationmessage);
                Logger.WriteDebugMessage(actualValidationmessage + " is Equal to " + expectedValidationMessage);
            }
            else
                Assert.Fail(actualValidationmessage + " is not Equal to " + expectedValidationMessage);
        }
        public static void VerifyDetails(string actual, string expected)
        {
            if (actual.Contains(expected))
            {
                Logger.WriteDebugMessage(actual + " is Equal to " + expected);
            }
            else
                Assert.Fail(actual + " is not Equal to " + expected);
        }

        public static void Click_SignIn()
        {
            Helper.ElementClick(PageObject_Navigation.Link_SignIn());
        }

        public static void Click_Button_MyAccount()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Button_MyAccount());
        }
        public static void Click_MyAccount_SignOut()
        {
            Helper.ElementClick(PageObject_Navigation.Click_MyAccount_SignOut());
        }
    }
}