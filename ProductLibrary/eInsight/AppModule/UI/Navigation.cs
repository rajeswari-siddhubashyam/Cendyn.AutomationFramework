using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseUtility.Utility;
using InfoMessageLogger;
using Common;
using eInsight.PageObject.UI;
using OpenQA.Selenium;
using NUnit.Framework;

namespace eInsight.AppModule.UI
{
    class Navigation : Helper
    {
        public static void UserProfileIcon()
        {
            ElementClick(PageObject_Navigation.UserProfileIcon());
        }

        public static void Link_Admin()
        {
            ElementClick(PageObject_Navigation.AdminLink());
        }
        public static void Link_MyPreference()
        {
            ElementClick(PageObject_Navigation.MyPreferenceLink());
        }
        public static void Link_Settings()
        {
            ElementClick(PageObject_Navigation.SettingsLink());
        }

        /// <summary>
        /// This method will click the Home navigation link on the main nav.
        /// </summary>
        public static void ClickHome()
        {
            ElementClick(PageObject_Navigation.Home());
        }

        /// <summary>
        /// This method will click the Profile navigation link on the main nav.
        /// </summary>
        public static void ClickProfile()
        {
            ElementClick(PageObject_Navigation.Profile());
            Helper.ElementWait(PageObject_Profile.Profile_SearchGuestsSearch(), 60);
            if (!Helper.IsElementPresent(By.Id("search")))
            {
                Logger.WriteDebugMessage("Didnot land on Profile Page");
            }
        }

        /// <summary>
        /// This method will click the Create Campaign navigation link on the main nav.
        /// </summary>
        public static void ClickCreateCampaign()
        {
            ElementClick(PageObject_Navigation.CreateCampaign());
        }

        /// <summary>
        /// This method will click the Manage Campaign navigation link on the main nav.
        /// </summary>
        public static void ClickManageCampaign()
        {
            ElementClick(PageObject_Navigation.ManageCampaign());
        }

        /// <summary>
        /// This method will click the Calendar navigation link on the main nav.
        /// </summary>
        public static void ClickCalendar()
        {
            ElementClick(PageObject_Navigation.Calendar());
        }

        /// <summary>
        /// This method will click the eGallery navigation link on the main nav.
        /// </summary>
        public static void ClickEGallery()
        {
            ElementClick(PageObject_Navigation.eGallery());
        }

        /// <summary>
        /// This method will click the Reports navigation link on the main nav.
        /// </summary>
        public static void ClickReports()
        {
            ElementClick(PageObject_Navigation.Reports());
        }

        /// <summary>
        /// This method will click the Survey navigation link on the main nav.
        /// </summary>
        public static void ClickSurvey()
        {
            ElementClick(PageObject_Navigation.Survey());
        }

        public static void Click_Link_Monitoring()
        {
            ElementClick(PageObject_Navigation.Link_Monitoring());
        }

        public static void Click_Link_Settings()
        {
            ElementClick(PageObject_Navigation.Link_Settings());
        }

        public static void Click_Link_Admin()
        {

            ElementClick(PageObject_Navigation.Link_Admin());
        }

        public static void Click_Link_MainMenu()
        {
            ElementClick(PageObject_Navigation.Link_MainMenu());
        }

        public static void Click_Link_Help()
        {
            ElementClick(PageObject_Navigation.Link_Help());
        }

        public static void Click_Link_LogOut()
        {
            ElementClick(PageObject_Navigation.Link_LogOut());
        }

        public static void Click_Link_ProductList_Show()
        {
            ElementClick(PageObject_Navigation.Link_ProductList_Show());
        }

        public static void Click_Link_ProductList_eInsight()
        {
            ElementClick(PageObject_Navigation.Link_ProductList_eInsight());
        }

        public static void Click_Link_ProductList_eConcierge()
        {
            ElementClick(PageObject_Navigation.Link_ProductList_eConcierge());
        }

        public static void Click_Link_ProductList_eSurvey()
        {
            ElementClick(PageObject_Navigation.Link_ProductList_eSurvey());
        }

        public static void Click_Link_ProductList_Loyalty()
        {
            ElementClick(PageObject_Navigation.Link_ProductList_Loyalty());
        }

        public static void Click_Link_ProductList_eInsightReports()
        {
            ElementClick(PageObject_Navigation.Link_ProductList_eInsightReports());
        }
        
        /*
        public static void ReLogin()
        {
            Click_Link_LogOut();
            ElementWait(PageObject_Login.Email(), 60);
            Logger.WriteDebugMessage("Logged Out Successfully");
            Login.CommonLogin();
            ElementWait(PageObject_Navigation.Link_LogOut(), 60);
            Logger.WriteDebugMessage("Landed on eInsight Home Page");
        }
        */
        public static void MenuNavigation(string menuSwitch)
        {
            switch(menuSwitch)
            {
                case "AudienceBuilder":
                    ElementClick(PageObject_Navigation.Audiences());
                    AddDelay(20000);
                    Driver.SwitchTo().Frame(0);
                    ElementWait(Driver.FindElement(By.Id("selectField")), 120);
                    if (IsElementPresent(By.Id("selectField")))
                    {
                        Logger.WriteDebugMessage("Landed on Audience Builder Page.");
                    }
                    else
                    {
                        Assert.Fail("Did not land on Audience Builder Page.");
                    }
                    break;
                case "Profile":
                    ElementClick(PageObject_Navigation.Profile());
                    ElementWait(PageObject_Profile.Profile_SearchGuestsSearch(), 120);
                    if (IsElementPresent(By.Id("search")))
                    {
                        Logger.WriteDebugMessage("Landed on Profile Page.");
                    }
                    else
                    {
                        Assert.Fail("Did not land on Profile Page.");
                    }
                    break;
                case "ManageCampaign":
                    ElementClick(Driver.FindElement(By.XPath("//a[@id='campaignsNav']")));
                    ElementWait(Driver.FindElement(By.XPath("//a[@id='campaignsNav']//following::a[contains(@href, '/Project.mvc/Project/ManageCampaigns')]")), 60);
                    ElementClick(Driver.FindElement(By.XPath("//a[@id='campaignsNav']//following::a[contains(@href, '/Project.mvc/Project/ManageCampaigns')]")));
                    AddDelay(2000);
                    if (Driver.Url.Contains("Project.mvc/Project/ManageCampaigns"))
                    {
                        Logger.WriteDebugMessage("Landed on Manage Campaign Page successfully.");
                    }
                    else
                    {
                        Assert.Fail("Did not land on Manage Campaign Page.");
                    }
                    break;
                case "Create":
                    ElementClick(Driver.FindElement(By.XPath("//a[@id='campaignsNav']")));
                    ElementWait(Driver.FindElement(By.XPath("//a[@id='campaignsNav']//following::a[contains(@href, '/Project.mvc/Project/Create')]")), 60);
                    ElementClick(Driver.FindElement(By.XPath("//a[@id='campaignsNav']//following::a[contains(@href, '/Project.mvc/Project/Create')]")));
                    AddDelay(20000);
                    if (Driver.Url.Contains("Project.mvc/Project/Create"))
                    {
                        Logger.WriteDebugMessage("Landed on Create Campaign Page successfully.");
                    }
                    else
                    {
                        Assert.Fail("Did not land on Create Campaign Page.");
                    }                    
                    break;
                case "TemplateBuilder":
                    ElementClick(Driver.FindElement(By.XPath("//a[@id='campaignsNav']")));
                    ElementClick(Driver.FindElement(By.XPath("//a[@id='campaignsNav']//following::a[contains(@href, '/Project.mvc/Project/TemplateBuilder')]")));
                    break;
            }
        }

    }

}
