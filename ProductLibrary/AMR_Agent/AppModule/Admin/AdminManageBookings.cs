using AMR_Agent.PageObject.Admin;
using BaseUtility.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMR_Agent.AppModule.Admin 
{
    class AdminManageBookings : Utility.Setup
    {
        public static void ClickNotYetTraveledTab()
        {
            Helper.ElementClick(PageObject_ManageBookings.AdminManageBookingsNotYetTraveledTab());
        }

        public static void ClickPendingValidationTab()
        {
            Helper.ElementClick(PageObject_ManageBookings.AdminManageBookingsPendingValidationTab());
        }

        public static void ClickPointsEarnedTab()
        {
            Helper.ElementClick(PageObject_ManageBookings.AdminManageBookingsPointsEarnedTab());
        }

        public static void ClickIneligibleTab()
        {
            Helper.ElementClick(PageObject_ManageBookings.AdminManageBookingsIneligibleTab());
        }

        public static void EnterSearch(string text)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementEnterText(PageObject_ManageBookings.AdminManageBookingsPendingValidationTabSearchbox(), text);
            Helper.AddDelay(5000);
            action.SendKeys(Keys.Enter).Build().Perform();
            Helper.AddDelay(15000);
        }

        public static string GetBookingNumber()
        {
            string bookingnumber = PageObject_ManageBookings.AdminManageBookings_PendingValidationTab_Field_BookingNumber().GetAttribute("title");
            return bookingnumber;
        }

        public static void ClickPendingValidationDeleteIcon()
        {
            Helper.ElementClick(PageObject_ManageBookings.AdminManageBookings_PendingValidationTab_DeleteIcon());
        }

        public static void ClickPendingValidationButtonDelete()
        {
            Helper.ElementClick(PageObject_ManageBookings.AdminManageBookings_PendingValidationTab_Button_Delete());
        }

        public static void ClickPendingValidationButtonClose()
        {
            Helper.ElementClick(PageObject_ManageBookings.AdminManageBookings_PendingValidationTab_Button_Close());
        }

        public static void ClickPendingValidationButtonCancel()
        {
            Helper.ElementClick(PageObject_ManageBookings.AdminManageBookings_PendingValidationTab_Button_Cancel());
        }

    }
}
