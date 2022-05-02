using AMR_Agent.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;

namespace AMR_Agent.AppModule.UI
{
    class AccountSummary : Utility.Setup
    {
        private static string BookingNo { get; set; }
        private static string GuestFirstName { get; set; }
        private static string GuestLastName { get; set; }
        private static string Resort { get; set; }
        private static string ArrivalDate { get; set; }
        private static string DepartureDate { get; set; }

        /// <summary>
        /// This method sets the values of the "Not Yet Traveled" guest.
        /// </summary>
        public static void GetCurrentNotYetTraveled()
        {
            BookingNo = PageObject_AccountSummary.AccountSummarySummaryBookingsNotYetTraveledBookingNo().Text;
            GuestFirstName = PageObject_AccountSummary.AccountSummarySummaryBookingsNotYetTraveledGuestFirstName().Text;
            GuestLastName = PageObject_AccountSummary.AccountSummarySummaryBookingsNotYetTraveledGuestLastName().Text;
            Resort = PageObject_AccountSummary.AccountSummarySummaryBookingsNotYetTraveledResort().Text;
            ArrivalDate = PageObject_AccountSummary.AccountSummarySummaryBookingsNotYetTraveledGuestArrivalDate().Text;
            DepartureDate = PageObject_AccountSummary.AccountSummarySummaryBookingsNotYetTraveledGuestDepartureDate().Text;

        }

        public static void ConfirmGuestChanges()
        {
            if (BookingNo == PageObject_AccountSummary.AccountSummarySummaryBookingsNotYetTraveledBookingNo().Text)
                Logger.WriteInfoMessage("The booking number has been changed!");
            else
            {
                Logger.WriteFatalMessage("The booking number was not changed successfully.");
                Assert.Fail();
            }

            if (GuestFirstName == PageObject_AccountSummary.AccountSummarySummaryBookingsNotYetTraveledGuestFirstName().Text)
                Logger.WriteInfoMessage("The Guest First Name has been changed!");
            else
            {
                Logger.WriteFatalMessage("The Guest First Name was not changed successfully.");
                Assert.Fail();
            }

            if (GuestLastName == PageObject_AccountSummary.AccountSummarySummaryBookingsNotYetTraveledGuestLastName().Text)
                Logger.WriteInfoMessage("The Guest Last Name has been changed!");
            else
            {
                Logger.WriteFatalMessage("The Guest Last Name was not changed successfully.");
                Assert.Fail();
            }

            if (Resort == PageObject_AccountSummary.AccountSummarySummaryBookingsNotYetTraveledResort().Text)
                Logger.WriteInfoMessage("The Resort has been changed!");
            else
            {
                Logger.WriteFatalMessage("The Resort was not changed successfully.");
                Assert.Fail();
            }

            if (ArrivalDate == PageObject_AccountSummary.AccountSummarySummaryBookingsNotYetTraveledGuestArrivalDate().Text)
                Logger.WriteInfoMessage("The Arrival Date has been changed!");
            else
            {
                Logger.WriteFatalMessage("The Arrival Date was not changed successfully.");
                Assert.Fail();
            }

            if (DepartureDate == PageObject_AccountSummary.AccountSummarySummaryBookingsNotYetTraveledGuestDepartureDate().Text)
                Logger.WriteInfoMessage("The Departure Date has been changed!");
            else
            {
                Logger.WriteFatalMessage("The Departure Date was not changed successfully.");
                Assert.Fail();
            }



        }
    }
}
