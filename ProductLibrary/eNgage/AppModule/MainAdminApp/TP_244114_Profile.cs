using System;
using eNgage.Utility;
using eNgage.AppModule.UI;
using Common;
using Constants = eNgage.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using OpenQA.Selenium;
using NUnit.Framework;
using eNgage.AppModule.UI;
using eNgage.PageObject.UI;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;

namespace eNgage.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_244114]
        public static void TC_244127()
        {
            PageObject_Home.Nav_Home().Click();
            AddDelay(500);
            IWebElement dashboardTile = PageObject_Home.Dashboard_FirstTile();
            string count = PageObject_Home.Home_DashboardTile_Res_Count();
            if (count == "0")
            {
                Home.changeHotelDropDown(Driver, wait);
                dashboardTile = PageObject_Home.Dashboard_FirstTile();
            }
            dashboardTile.Click();
            Home.HomeSearchList(Driver, wait);
            Helper.ElementWait(PageObject_Prompts.Prompts_Container(), 180);
            PageObject_Profile.Nav_Profile().Click();
            Profile.checkProfileLoad(Driver);
        }
        #endregion[TP_244114]

    }
}
