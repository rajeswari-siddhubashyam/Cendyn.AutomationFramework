using AMR_Agent.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace AMR_Agent.PageObject.Admin
{
    public class PageObject_ManageBookings : Setup
    {

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/

        public static IWebElement AdminManageBookingsNotYetTraveledTab()
        {
            ScanPage(Constants.ModuleAdminManageBookings);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageBookingsNotYetTraveledTab);
        }

        public static IWebElement AdminManageBookingsPointsEarnedTab()
        {
            ScanPage(Constants.ModuleAdminManageBookings);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageBookingsPointsEarnedTab);
        }

        public static IWebElement AdminManageBookingsPendingValidationTab()
        {
            ScanPage(Constants.ModuleAdminManageBookings);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageBookingsPendingValidationTab);
        }

        public static IWebElement AdminManageBookingsIneligibleTab()
        {
            ScanPage(Constants.ModuleAdminManageBookings);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageBookingsIneligibleTab);
        }

        public static IWebElement AdminManageBookingsPendingValidationTabSearchbox()
        {
            ScanPage(Constants.ModuleAdminManageBookings);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageBookingsPendingValidationTabSearchbox);
        }

        public static IWebElement AdminManageBookings_PendingValidationTab_DeleteIcon()
        {
            ScanPage(Constants.ModuleAdminManageBookings);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageBookings_PendingValidationTab_DeleteIcon);
        }

        public static IWebElement AdminManageBookings_PendingValidationTab_Button_Delete()
        {
            ScanPage(Constants.ModuleAdminManageBookings);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageBookings_PendingValidationTab_Button_Delete);
        }

        public static IWebElement AdminManageBookings_PendingValidationTab_Button_Cancel()
        {
            ScanPage(Constants.ModuleAdminManageBookings);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageBookings_PendingValidationTab_Button_Cancel);
        }

        public static IWebElement AdminManageBookings_PendingValidationTab_Button_Close()
        {
            ScanPage(Constants.ModuleAdminManageBookings);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageBookings_PendingValidationTab_Button_Close);
        }

        public static IWebElement AdminManageBookings_PendingValidationTab_Field_BookingNumber()
        {
            ScanPage(Constants.ModuleAdminManageBookings);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageBookings_PendingValidationTab_Field_BookingNumber);
        }

    }
}