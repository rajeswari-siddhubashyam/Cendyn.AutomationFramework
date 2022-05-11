using BaseUtility.Utility;
using Common;
using MarketingAutomation.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace MarketingAutomation.AppModule.UI
{
    public class Navigation : BaseUtility.AppModule.UI.Navigation
    {
        public static void Click_Campaigns()
        {
            Helper.ElementClick(PageObject_Navigation.Button_Campaigns());
            Logger.WriteDebugMessage("User landed on Campaigns Tab");
        }

        public static void Verify_LandsOnMAPage()
        {
            Helper.WaitForAjaxControls(60);
            Helper.ElementWaitByLocator(PageObject_Navigation.Text_SideNavMAutomationXpath(),50);
            Assert.IsTrue(PageObject_Navigation.Text_SideNavMAutomation().Displayed, "User is not landed on Marketing Automation page");
            Logger.WriteDebugMessage("User landed on Marketing Automation page");
        }
        
        public static void ClickOnSidebarCampaigns()
        {
            Helper.WaitForAjaxControls(60);
            Helper.ElementClick(PageObject_Navigation.Button_Campaigns_Sidebar());
            Helper.WaitForAjaxControls(90);
        }

        public static void ClickOnSidebarTemplates()
        {
                Helper.WaitForAjaxControls(60);
                Helper.ElementClick(PageObject_Navigation.Button_Templates_Sidebar());
                Helper.WaitForAjaxControls(90);
                string breadcrumb = Helper.GetText(PageObject_CreateTemplate.Template_Grid_Cards_Breadcrumb());
                Assert.IsTrue(breadcrumb.ToLower().Contains("templates"), "Template is not selected ");
        }

        public static void ClickOnSidebarAudience()
        {
            Helper.WaitForAjaxControls(60);
            Helper.ElementClick(PageObject_Navigation.Button_Audience_Sidebar());
            Helper.WaitForAjaxControls(90);
            string breadcrumb = Helper.GetText(PageObject_CreateTemplate.Template_Grid_Cards_Breadcrumb());
            Assert.IsTrue(breadcrumb.ToLower().Contains("audience"), "Audience is not selected ");
        }

        public static void ClickOnMAInCHCDashboard()
        {
            Helper.WaitForAjaxControls(60);
            Helper.HoverOver(PageObject_Navigation.To_MAutomation_FromCH());
            Helper.WaitForAjaxControls(60);
        }
        public static int VerifyNumberOfNavigatorLinks()
        {
            int countLink = 0;
            IList<IWebElement> totalLink = PageObject_Navigation.GetNumberOfNavigatorLinks();
            foreach (var item in totalLink)
            {
                string getCards = item.GetAttribute("class");
                if (getCards.Contains("navbar-nav"))
                {
                    countLink = countLink + 1;
                }
            }
            return countLink;
            Assert.IsTrue(countLink >1, $"{countLink} More than 1 Navigations links are available");
            Logger.WriteInfoMessage($"{countLink} More than 1 Navigations links are available");
        }

    }

}
