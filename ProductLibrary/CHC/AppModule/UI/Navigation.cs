using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseUtility.Utility;
using CHC.PageObject.UI;
using InfoMessageLogger;
using OpenQA.Selenium.Support.UI;

namespace CHC.AppModule.UI
{
    public class Navigation : BaseUtility.AppModule.UI.Navigation
    {
        public static void Click_Configurations_App()
        {
            Helper.ElementClick(PageObject_Navigation.Configuration_App());
            Logger.WriteDebugMessage("User landed on Campaigns Tab");
        }

       
        public static void Click_Marketing_Automation_App()
        {
            Helper.ElementClick(PageObject_Navigation.Marketing_Automation_App());
            Logger.WriteDebugMessage("User landed on Campaigns Tab");
        }

        public static void Click_Starling_App()
        {
            Helper.ElementClick(PageObject_Navigation.Starling_App());
            Logger.WriteDebugMessage("User landed on Campaigns Tab");
        }

        public static void Click_Unified_Profile_App()
        {
            Helper.ElementClick(PageObject_Navigation.Unified_Profile_App());
            Logger.WriteDebugMessage("User landed on Campaigns Tab");
        }

}
}
