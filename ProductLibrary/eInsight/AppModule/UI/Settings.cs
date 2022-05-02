using BaseUtility.Utility;
using InfoMessageLogger;
using Common;
using eInsight.PageObject.UI;

namespace eInsight.AppModule.UI
{
    class Settings : Helper
    {

        public static void CheckMergeGuest()
        {
            ElementSelected(PageObject_Settings.Settings_AccessControl_MergeGuestCheckbox());
        }

        public static void UncheckMergeGuest()
        {
            ElementNOTSelected(PageObject_Settings.Settings_AccessControl_MergeGuestCheckbox());
        }

        public static void ClickAccessControlSave()
        {
            PageObject_Settings.Settings_AccessControl_Save().Click();
            AddDelay(10000);
        }

        public static void TurnOffMergeGuestAndSave()
        {
            Navigation.Click_Link_Settings();
            UncheckMergeGuest();
            ClickAccessControlSave();
        }

        public static void TurnOnMergeGuestAndSave()
        {
            Navigation.Click_Link_Settings();
            CheckMergeGuest();
            ClickAccessControlSave();
        }

        public static void ClickMergeGuest()
        {
            ElementClick(PageObject_Settings.Settings_AccessControl_MergeGuestCheckbox()); ;
        }

        public static void EnableDisableMergeGuest(int enableDisable)
        {
            switch(enableDisable)
            {
                case 0:
                    CheckMergeGuest();
                    break;
                case 1:
                    UncheckMergeGuest();
                    break;
            }
        }
    }
}
