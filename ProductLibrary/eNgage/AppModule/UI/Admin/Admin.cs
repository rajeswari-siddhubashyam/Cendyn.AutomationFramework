using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseUtility.Utility;
using InfoMessageLogger;
using Common;
using OpenQA.Selenium;
using eNgage.PageObject.UI;
using eNgage.Utility;
using BaseUtility.Utility.Hotmail;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace eNgage.AppModule.UI
{
    class Admin
    {
        public static void checkAdminLoad(IWebDriver d, WebDriverWait w)
        {
            //d.SwitchTo().Window(d.WindowHandles.Last());
            Logger.WriteDebugMessage("Clicked on Admin Link");
            Helper.AddDelay(1000);
            IWebElement Admin_Container = PageObject_Admin.Admin_Container();
            IList<IWebElement> Admin_Data = PageObject_Admin.Admin_Tiles();
           
            Assert.NotZero(Admin_Data.Count);
            if (Admin_Data.Count==0)
            {
                Logger.WriteFatalMessage("Admin Page did not load");
            }
            else
            {
                Logger.WriteInfoMessage("Page Title " + d.Title);
                Logger.WriteDebugMessage("Admin page found");
            }
        }
        public static void closeAdminTab(IWebDriver d)
        {
            d.Close();
            d.SwitchTo().DefaultContent();
        }



    }
}
