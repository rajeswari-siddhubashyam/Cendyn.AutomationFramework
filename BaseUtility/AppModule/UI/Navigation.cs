using OpenQA.Selenium;
using System.Collections.Generic;
using Common;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using System;

namespace BaseUtility.AppModule.UI
{
    public class Navigation
    {
      public static void NavigateToUrl(string ProjectName)
        {
            if (ProjectName == "HotelVic" || ProjectName == "HotelIcon" || ProjectName == "Iberostar")
            {
                Helper.Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL + "/signup");
            }
            else if (ProjectName == "AdareManor")
            {
                Helper.Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            }
            else
            {
                Helper.Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL + "?ReturnUrl=%2F#signup");
            }
        }

        /// <summary>
        /// Method to Retrieve all active links on a Page
        /// </summary>
        public static void GetLinkOnWebpage()
        {
            IList<IWebElement> elements = CommonMethod.Driver.FindElements(By.TagName("a"));
            foreach (IWebElement element in elements)
            {
                string link = element.Text;
                if (link != "")
                {
                    Logger.WriteInfoMessage(link);
                }
                else
                {

                }
            }
        }

        public static void Select_Client(string client)
        {
            throw new NotImplementedException();
        }
    }
}
