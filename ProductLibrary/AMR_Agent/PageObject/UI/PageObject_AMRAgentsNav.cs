using AMR_Agent.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace AMR_Agent.PageObject.UI
{
    class PageObject_AMRAgentsNav : Setup
    {
        /*
        / These methods will return the element on the page by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
        */

        public static IWebElement AMRAgentsHome()
        {
            ScanPage(Constants.ModuleAMRAgentsNav);
            return PageAction.Find_ElementPartialLinkText(ObjectRepository.AMRAgentsHome);
        }

        public static IWebElement AMRAgentsBookNow()
        {
            ScanPage(Constants.ModuleAMRAgentsNav);
            return PageAction.Find_ElementPartialLinkText(ObjectRepository.AMRAgentsBookNow);
        }
        public static IWebElement AMRAgentsGDSCodes()
        {
            ScanPage(Constants.ModuleAMRAgentsNav);
            return PageAction.Find_ElementPartialLinkText(ObjectRepository.AMRAgentsGDSCodes);
        }
        public static IWebElement AMRAgentsAMRewards()
        {
            ScanPage(Constants.ModuleAMRAgentsNav);
            return PageAction.Find_ElementPartialLinkText(ObjectRepository.AMRAgentsAMRewards);
        }
        public static IWebElement AMRAgentsUpdateProfile()
        {
            ScanPage(Constants.ModuleAMRAgentsNav);
            return PageAction.Find_ElementPartialLinkText(ObjectRepository.AMRAgentsUpdateProfile);
        }
        public static IWebElement AMRAgentsLogOff()
        {
            ScanPage(Constants.ModuleAMRAgentsNav);
            return PageAction.Find_ElementPartialLinkText(ObjectRepository.AMRAgentsLogOff);
        }
        public static IWebElement AMRAgentsAccountSummary()
        {
            ScanPage(Constants.ModuleAMRAgentsNav);
            return PageAction.Find_ElementPartialLinkText(ObjectRepository.AMRAgentsAccountSummary);
        }
        public static IWebElement AMRAgentsMyRedemptions()
        {
            ScanPage(Constants.ModuleAMRAgentsNav);
            return PageAction.Find_ElementPartialLinkText(ObjectRepository.AMRAgentsMyRedemptions);
        }
        public static IWebElement AMRAgentsSubmitBooking()
        {
            ScanPage(Constants.ModuleAMRAgentsNav);
            return PageAction.Find_ElementPartialLinkText(ObjectRepository.AMRAgentsSubmitBooking);
        }

    }
}
