using AMR_Agent.PageObject.Admin;
using BaseUtility.Utility;

namespace AMR_Agent.AppModule.Admin
{
    class AdminManageHome : Utility.Setup
    {
        public static void ClickManageProfile()
            {
                Helper.ElementClick(PageObject_AdminHome.AdminHomeManageProfile());
            }

        public static void ClickManageBookings()
        {
            Helper.ElementClick(PageObject_AdminHome.AdminHomeManageBookings());
        }

        public static void ClickManageRedemptions()
        {
            Helper.ElementClick(PageObject_AdminHome.AdminHomeManageRedemptions());
        }
    }
}
