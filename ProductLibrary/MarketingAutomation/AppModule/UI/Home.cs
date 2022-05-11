using BaseUtility.Utility;
using InfoMessageLogger;
using MarketingAutomation.PageObject.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
//using CTOS;

namespace MarketingAutomation.AppModule.UI
{
    public class Home : Helper
    {
        /// <summary>
        /// This method select the  'applicationName' from the home page
        /// If user want to select organization from side bar then he can provide the org name or default it is Kirigami Hotels
        /// </summary>
        /// <param name="applicationName"></param>
        /// <param name="orgName"></param>
        public static void ClickOnApplication(string applicationName, string orgName)
        {
            WaitTillElementDisplay(PageObject_Home.Home_Sidebar_Home());
            IList<IWebElement> cards = PageObject_Home.Application_Cards(); 
            foreach (var item in cards)
            {
                if (item.Text.Equals(applicationName))
                {
                    Helper.ElementClick(item);
                    break;
                }
                    
            }
            if (Helper.IsElementDisplayed(PageObject_Home.Home_Org_Popup()))
            {
                Helper.ElementClick(PageObject_Home.Home_Org_Popup_Choose());
                IList<IWebElement> orgs = PageObject_Home.Home_Sidebar_Org_Popup_List();
                int orgIndex = 0;
                foreach (var item in orgs)
                {
                    orgIndex = orgIndex + 1;

                    if (item.Text.Contains(orgName))
                    {
                        IList<IWebElement> chkButtons = item.FindElements(By.XPath("/descendant::div[@role='checkbox']"));
                        chkButtons[orgIndex - 1].Click();
                        break;
                    }
                }
            }
        }

        public static void WaitTillElementDisplay(string xpath)
        {
                int count = 0;
                try
                {
                    while (count < 10)
                    {
                        try
                        {
                            IWebElement ele = Driver.FindElement(By.XPath(xpath));
                            if (ele.Displayed)
                            break;
                        }
                        catch (Exception) { }
                        AddDelay(1000);
                        count = count + 1;
                        if (count > 10)
                            break;
                    }
                }
                catch (Exception) { }
         

        }

        //public static void VerifyButtonUse()
        //{
        //    Button b1 = new Button(Helper.Driver,By.Id(PageObject_SignIn.Button_SignInId()));
        //    string text = b1.GetButtonText();
        //    string ntext = b1.GetDomAttribute("value");
        //    var css = b1.GetStyle();
        //    var status = b1.IsEnabled();
        //    b1.Click();
        //}
    }
}
