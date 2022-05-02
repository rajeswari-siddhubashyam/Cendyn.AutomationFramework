using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseUtility.Utility;
using CHC_Unified_Profile.PageObject.UI;
using InfoMessageLogger;
using OpenQA.Selenium.Support.UI;

namespace CHC_Unified_Profile.AppModule.UI
{
    public class Navigation : BaseUtility.AppModule.UI.Navigation
    {
        public static void Click_Configurations_App()
    {
        Helper.ElementClick(PageObject_Navigation.Configuration_App());
        Logger.WriteDebugMessage("User landed on Configuration App");
    }


    public static void Click_Marketing_Automation_App()
    {
        Helper.ElementClick(PageObject_Navigation.Marketing_Automation_App());
        Logger.WriteDebugMessage("User landed on Marketing Automation App");
    }

    public static void Click_Starling_App()
    {
        Helper.ElementClick(PageObject_Navigation.Starling_App());
        Logger.WriteDebugMessage("User landed on Starling App");
    }

    public static void Click_Unified_Profile_App()
    {
        Helper.ElementClick(PageObject_Navigation.Unified_Profile_App());
        Logger.WriteDebugMessage("User landed on Unified Profile App");
    }

}
}

