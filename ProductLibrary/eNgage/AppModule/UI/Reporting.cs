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
    class Reporting
    {
        public static void checkReportingLoad(IWebDriver d, WebDriverWait w)
        {
            
            Logger.WriteDebugMessage("Clicked on Reporting Link");
            Helper.AddDelay(1000);
            IWebElement Reporting_Container = PageObject_Reporting.Reporting_Container();

            IWebElement Reporting_Results_Table = PageObject_Reporting.Reporting_Results_Table();
            Assert.IsNotNull(Reporting_Results_Table);
            if (Reporting_Results_Table.Equals(null))
            {
                Logger.WriteFatalMessage("Reporting Page did not load");
            }
            else
            {
                Logger.WriteDebugMessage("Reporting page found");
               
            }
        }

    }
}
