using AMR_Agent.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace AMR_Agent.PageObject.UI
{
    class PageObject_AdminValidatedProfiles : Setup
    {
        /*
        / These methods will return the element on the page by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
        */

        public static IWebElement AdminValidatedProfilesEditProfile(string email)
        {
            ScanPage(Constants.ModuleAdminValidatedProfiles);
           return PageAction.Find_ElementXPath("(//td[@title = '"+email+"']//following::div[@title = 'Edit profile'])[1]");
        }
        public static IWebElement AdminValidatedProfilesSearch()
        {
            ScanPage(Constants.ModuleAdminValidatedProfiles);
            return PageAction.Find_ElementId(ObjectRepository.AdminValidatedProfilesSearch);
        }

    }
}
