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
    class Banner
    {
        public static void checkBannerLoad(IWebDriver d, WebDriverWait w)
        {
            Helper.AddDelay(500);
            IWebElement banner = d.FindElement(By.ClassName("iconBanner"));
            IList<IWebElement> bannerElements = banner.FindElements(By.ClassName("iconContainer"));
            Assert.NotZero(bannerElements.Count);
            if (bannerElements.Count != 0)
            {
                Logger.WriteDebugMessage("Banner found");
            }
            else
            {
                Logger.WriteFatalMessage("No Banner found");
            }
        }
    }
}
