using AMR_Agent.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace AMR_Agent.PageObject.UI
{
    class PageObject_SubmitBooking : Setup
    {
        /*
        / These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
        */

        public static IWebElement SubmitBookingIndividualRadioButton()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingIndividualRadioButton);
        }
        public static IWebElement SubmitBookingGroupTypeRadioButton()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingGroupTypeRadioButton);
        }
        public static IWebElement SubmitBookingGroupTypeDropDown()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingGroupTypeDropDown);
        }
        public static IWebElement SubmitBookingNumOfRooms()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingNumOfRooms);
        }
        public static IWebElement SubmitBookingSetGroupButton()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingSetGroupButton);
        }
        public static IWebElement SubmitBookingGroupName()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingGroupName);
        }
        public static IWebElement SubmitBookingRoomNumber()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingRoomNumber);
        }
        public static IWebElement SubmitBookingBookingMadeWith()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingBookingMadeWith);
        }
        public static IWebElement SubmitBookingBookingNumber()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingBookingNumber);
        }
        public static IWebElement SubmitBookingGuestFirstName()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingGuestFirstName);
        }
        public static IWebElement SubmitBookingGuestLastName()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingGuestLastName);
        }
        public static IWebElement SubmitBookingDateBooked()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingDateBooked);
        }
        public static IWebElement SubmitBookingTravelStartDate()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingTravelStartDate);
        }
        public static IWebElement SubmitBookingTravelEndDate()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingTravelEndDate);
        }
        public static IWebElement SubmitBookingBrand()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingBrand);
        }
        public static IWebElement SubmitBookingResort()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingResort);
        }
        public static IWebElement SubmitBookingDepartureGateway1()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementXPath(ObjectRepository.SubmitBookingDepartureGateway1);
        }
        public static IWebElement SubmitBookingDepartureGateway()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementXPath(ObjectRepository.SubmitBookingDepartureGateway);
        }
        public static IWebElement SubmitBookingAddToBookingSummary()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingAddToBookingSummary);
        }
        public static IWebElement SubmitBookingClear()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingClear);
        }

        public static IWebElement SubmitBookingSelectBooking()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingSubmit);
        }
        public static IWebElement SubmitBookingSubmit()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingSubmit);
        }
        public static IWebElement SubmitBookingPopupOKBtn()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingPopupOKBtn);
        }
        public static IWebElement SubmitBookingSubmitPopupOKBtn()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementId(ObjectRepository.SubmitBookingSubmitPopupOKBtn);
        }
        public static IWebElement SubmitBooking_DatePickerMonth()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementClassName(ObjectRepository.SubmitBookingDatePickerMonth);
        }
        public static IWebElement SubmitBooking_DatePickerYear()
        {
            ScanPage(Constants.ModuleSubmitBooking);
            return PageAction.Find_ElementClassName(ObjectRepository.SubmitBookingDatePickerYear);
        }
        
    }
}
