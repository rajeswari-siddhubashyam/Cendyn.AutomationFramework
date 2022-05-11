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
    class History
    {
        public static void checkHistoryLoad(IWebDriver d, WebDriverWait w)
        {
            Helper.AddDelay(1000);
            IWebElement History_table = PageObject_History.History_Results_Table().FindElement(By.TagName("tbody"));
            IWebElement History_Row = History_table.FindElement(By.TagName("tr"));
            Assert.IsNotNull(History_Row);
            if (History_Row.Equals(null))
            {
                Logger.WriteFatalMessage("History empty");
            }
            else
            {
                Logger.WriteDebugMessage("History found");
            }
        }
        public static void ViewHistoryProfile(IWebDriver d, WebDriverWait w)
        {
            IWebElement History_table = PageObject_History.History_Results_Table().FindElement(By.TagName("tbody"));
            IList<IWebElement> History_Rows = History_table.FindElements(By.TagName("tr"));
            if (History_Rows.Count != 0)
            {
                Random r = new Random();
                int row = r.Next(0, History_Rows.Count - 1);
                string profileId = History_Rows[row].FindElement(By.TagName("td")).Text;
                while (profileId.Trim() == "")
                {
                    r = new Random();
                    row = r.Next(0, History_Rows.Count - 1);
                    profileId = History_Rows[row].FindElement(By.TagName("td")).Text;
                }
                History_Rows[row].FindElement(By.TagName("td")).Click();
                Prompts.checkPromptsLoad(d, w);
            }
            else
            {
                Assert.Fail("History Empty");
                Logger.WriteFatalMessage("History empty");
            }
        }
    }
}
