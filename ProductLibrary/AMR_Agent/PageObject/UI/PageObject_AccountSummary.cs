using AMR_Agent.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace AMR_Agent.PageObject.UI
{
    class PageObject_AccountSummary : Setup
    {
        /*
        / These methods will return the element on the page by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
        */

        public static IWebElement AccountSummarySummaryBookingsTab()
        {
            ScanPage(Constants.ModuleAccountSummary);
            return PageAction.Find_ElementId(ObjectRepository.AccountSummarySummaryBookingsTab);
        }
        public static IWebElement AccountSummaryPointsEarnedTab()
        {
            ScanPage(Constants.ModuleAccountSummary);
            return PageAction.Find_ElementId(ObjectRepository.AccountSummaryPointsEarnedTab);
        }
        public static IWebElement AccountSummaryNotYetTraveledTable()
        {
            ScanPage(Constants.ModuleAccountSummary);
            return PageAction.Find_ElementXPath(ObjectRepository.AccountSummaryNotYetTraveledTable);
        }
        public static IWebElement AccountSummaryNotYetTraveledTab()
        {
            ScanPage(Constants.ModuleAccountSummary);
            return PageAction.Find_ElementId(ObjectRepository.AccountSummaryNotYetTraveledTab);
        }
        public static IWebElement AccountSummaryUnderReviewTab()
        {
            ScanPage(Constants.ModuleAccountSummary);
            return PageAction.Find_ElementId(ObjectRepository.AccountSummaryUnderReviewTab);
        }
        public static IWebElement AccountSummaryIneligibleTab()
        {
            ScanPage(Constants.ModuleAccountSummary);
            return PageAction.Find_ElementId(ObjectRepository.AccountSummaryIneligibleTab);
        }
        public static IWebElement AccountSummarySummaryBookingsNotYetTraveledBookingNo()
        {
            ScanPage(Constants.ModuleAccountSummary);
            return PageAction.Find_ElementXPath(ObjectRepository.AccountSummarySummaryBookingsNotYetTraveledBookingNo);
        }

        public static IWebElement AccountSummarySummaryBookingsNotYetTraveledGuestFirstName()
        {
            ScanPage(Constants.ModuleAccountSummary);
            return PageAction.Find_ElementXPath(ObjectRepository.AccountSummarySummaryBookingsNotYetTraveledGuestFirstName);
        }

        public static IWebElement AccountSummarySummaryBookingsNotYetTraveledGuestLastName()
        {
            ScanPage(Constants.ModuleAccountSummary);
            return PageAction.Find_ElementXPath(ObjectRepository.AccountSummarySummaryBookingsNotYetTraveledGuestLastName);
        }

        public static IWebElement AccountSummarySummaryBookingsNotYetTraveledResort()
        {
            ScanPage(Constants.ModuleAccountSummary);
            return PageAction.Find_ElementXPath(ObjectRepository.AccountSummarySummaryBookingsNotYetTraveledResort);
        }

        public static IWebElement AccountSummarySummaryBookingsNotYetTraveledGuestArrivalDate()
        {
            ScanPage(Constants.ModuleAccountSummary);
            return PageAction.Find_ElementXPath(ObjectRepository.AccountSummarySummaryBookingsNotYetTraveledGuestArrivalDate);
        }

        public static IWebElement AccountSummarySummaryBookingsNotYetTraveledGuestDepartureDate()
        {
            ScanPage(Constants.ModuleAccountSummary);
            return PageAction.Find_ElementXPath(ObjectRepository.AccountSummarySummaryBookingsNotYetTraveledGuestDepartureDate);
        }

        public static IWebElement AccountSummaryNotYetTraveledSubmitBtn()
        {
            ScanPage(Constants.ModuleAccountSummary);
            return PageAction.Find_ElementXPath(ObjectRepository.AccountSummaryNotYetTraveledSubmitBtn);
        }



    }
}
