using AMR_Agent.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;


namespace AMR_Agent.PageObject.Admin
{
    class PageObject_AdminHome : Utility.Setup
    {
        /*
        / These methods will return the element on the page by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
        */

        public static IWebElement AdminHomeManageProfile()
        {
            ScanPage(Constants.ModuleAdminHome);
            return PageAction.Find_ElementPartialLinkText(ObjectRepository.AdminHomeManageProfile);
        }

        public static IWebElement AdminHomeManageBookings()
        {
            ScanPage(Constants.ModuleAdminHome);
            return PageAction.Find_ElementPartialLinkText(ObjectRepository.AdminHomeManageBookings);
        }

        public static IWebElement AdminHomeManageRedemptions()
        {
            ScanPage(Constants.ModuleAdminHome);
            return PageAction.Find_ElementPartialLinkText(ObjectRepository.AdminHomeManageRedemptions);
        }


    }
}
