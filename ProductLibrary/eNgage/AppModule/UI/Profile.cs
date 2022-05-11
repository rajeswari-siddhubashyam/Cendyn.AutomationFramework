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

namespace eNgage.AppModule.UI
{
    class Profile
    {
        public static void checkProfileLoad(IWebDriver d)
        {
            Helper.AddDelay(500);
            IWebElement ProfileFrame = PageObject_Profile.Profile_Frame();
            d.SwitchTo().Frame(ObjectRepository.Profile_Frame);
            Helper.AddDelay(1000);
            bool elementFound = d.FindElement(By.Id("Profile")).Displayed;
            Assert.IsTrue(elementFound);
            if(elementFound == true)
            {
                Logger.WriteDebugMessage("Profile page displayed");
            }
            else
            {
                Logger.WriteFatalMessage("Profile Page not loading");
            }
        }
    }
}
