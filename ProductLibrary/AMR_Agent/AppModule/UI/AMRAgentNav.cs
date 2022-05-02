using AMR_Agent.PageObject.UI;
using BaseUtility.Utility;

namespace AMR_Agent.AppModule.UI
{
    class AMRAgentNav
    {

        public static void ClickAMRAgentsHome()
        {
            Helper.ElementClick(PageObject_AMRAgentsNav.AMRAgentsHome());
        }

        public static void ClickAMRAgentsBookNow()
        {
            Helper.ElementClick(PageObject_AMRAgentsNav.AMRAgentsBookNow());
        }

        public static void ClickAMRAgentsGDSCodes()
        {
            Helper.ElementClick(PageObject_AMRAgentsNav.AMRAgentsGDSCodes());
        }

        public static void ClickAMRAgentsAMRewards()
        {
            Helper.ElementClick(PageObject_AMRAgentsNav.AMRAgentsAMRewards());
        }

        public static void ClickAMRAgentsUpdateProfile()
        {
            Helper.ElementClick(PageObject_AMRAgentsNav.AMRAgentsUpdateProfile());
        }

        public static void ClickAMRAgentsLogOff()
        {
            Helper.ElementClick(PageObject_AMRAgentsNav.AMRAgentsLogOff());
        }

        public static void ClickAMRAgentsAccountSummary()
        {
            Helper.ElementClick(PageObject_AMRAgentsNav.AMRAgentsAccountSummary());
        }

        public static void ClickAMRAgentsMyRedemptions()
        {
            Helper.ElementClick(PageObject_AMRAgentsNav.AMRAgentsMyRedemptions());
        }

        public static void ClickAMRAgentsSubmitBooking()
        {
            Helper.ElementClick(PageObject_AMRAgentsNav.AMRAgentsSubmitBooking());
        }
    }
}
