using BaseUtility.Utility;
using Common;
using eLoyaltyV3.PageObject.UI;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace eLoyaltyV3.AppModule.UI
{
    class Exclusives
    {
        public static void Click_Text_ReadMore()
        {
            PageObject_Exclusives.Text_ReadMore();
            string path = ObjectRepository.Exclusives_Text_ReadMore;
            IList<IWebElement> list = Helper.Driver.FindElements(By.XPath(path));
            int i = list.Count;           
            foreach(IWebElement element in list)
            {
                if(list.IndexOf(element).Equals(i-1) )
                {
                    element.Click();
                }
            }
        }

        public static void Click_Button_BookNow()
        {
            PageObject_Exclusives.Button_BookNow();
            string path = ObjectRepository.Exclusives_Button_BookNow;
            IList<IWebElement> list = Helper.Driver.FindElements(By.XPath(path));
            int i = list.Count;
            foreach (IWebElement element in list)
            {
                if (list.IndexOf(element).Equals(i - 1))
                {
                    element.Click();
                }
            }           
        }

        public static void Click_Link_ShareNow()
        {
            Helper.ElementClick(PageObject_Exclusives.Link_ShareNow());
        }
    }
}
