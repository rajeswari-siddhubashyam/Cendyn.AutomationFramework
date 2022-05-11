using eLoyaltyV3.PageObject.UI;
using BaseUtility.Utility;

namespace eLoyaltyV3.AppModule.UI
{
    class Awards
    {
        public static void Click_Award_Name()
        {
            Helper.ElementWait(PageObject_Awards.Award_Name(), 240);
            Helper.ElementClick(PageObject_Awards.Award_Name());
        }

        public static void Click_Award_Tab()
        {
            Helper.ElementWait(PageObject_Awards.Click_Award_Tab(), 240);
            Helper.ElementClick(PageObject_Awards.Click_Award_Tab());
        }

        public static void Award_Filter(string value)
        {
            Helper.ElementWait(PageObject_Awards.Award_Filter(), 240);
            Helper.ElementEnterText(PageObject_Awards.Award_Filter(), value);
        }

        public static void Click_Redemptions_SubTab()
        {
            Helper.ElementWait(PageObject_Awards.Click_Redemptions_SubTab(), 240);
            Helper.ElementClick(PageObject_Awards.Click_Redemptions_SubTab());
        }
    }
}
