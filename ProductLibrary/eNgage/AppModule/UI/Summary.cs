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
    class Summary
    {
        public static void checkSummaryLoad(IWebDriver d, WebDriverWait w)
        {
            PageObject_Summary.Nav_Summary().Click();
            //d.FindElement(By.LinkText("Summary")).Click();
            Helper.AddDelay(500);
            IList<IWebElement> summary = d.FindElements(By.ClassName("portlet-title"));
            Assert.NotZero(summary.Count);
            if (summary.Count != 0)
                Logger.WriteDebugMessage("Summary page displayed");
            else
                Logger.WriteFatalMessage("Summary Page not loading");
            
        }
    }
}
