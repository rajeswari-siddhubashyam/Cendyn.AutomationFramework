using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eInsight.PageObject.UI;
using BaseUtility.Utility;
using InfoMessageLogger;
using OpenQA.Selenium;
using eInsight.Utility;
using SqlWarehouse;
using NUnit.Framework;


namespace eInsight.AppModule.UI
{
    class Admin : Helper
    {
        public static void Click_Link_AllTabs()
        {
            ElementClick(PageObject_Admin.Click_AllTabs());
            Logger.WriteDebugMessage("Clicked on All Tabs Link");
        }
        public static void Click_Link_CompanySettings()
        {
            ElementClick(PageObject_Admin.Click_Tab_CompanySettings());
            Logger.WriteDebugMessage("Clicked on Company Settings Link");
        }
        public static void Click_Button_HasPropertyFromName()
        {
            ElementClick(PageObject_Admin.Click_Open_SpecificPropertySetting("HasPropertyFromName"));
            Logger.WriteDebugMessage("Clicked on HasPropertyFromName Button");
        }
        public static void Click_CompanySetting_Button_Submit()
        {
            ElementClick(PageObject_Admin.Admin_CompanySetting_Button_Submit());
            Logger.WriteDebugMessage("Clicked on Submit Button");
        }
        public static void EnterText_SettingValue(string value)
        {
            Navigatetoiframe(1);
            ElementEnterText(PageObject_Admin.Element_SettingValue(), value);
            Logger.WriteDebugMessage("Enter Setting Value - " + value);
            Click_CompanySetting_Button_Submit();
            Navigatetoiframe(0);
        }
    }
}
