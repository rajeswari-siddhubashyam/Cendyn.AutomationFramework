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
using MarketingAutomation.Utility;
using System.Globalization;
using MarketingAutomation.Entity;
using Queries = MarketingAutomation.Utility.Queries;

namespace MarketingAutomation.AppModule.UI
{
    public class CreateAudience : Helper
    {
        public static void VerifyAudience3x3CardsAvailableOrNot()
        {
            int count = 0;
            IList<IWebElement> cards = PageObject_CreateAudience.Audience_Cards();
            foreach (var item in cards)
            {
                string getCards = item.GetAttribute("class");
                if (getCards.Contains("4"))
                {
                    count = count + 1;
                }
            }
            Assert.IsTrue(count <= 9, $"{count} card are not in 3x3 format on the page");
            Logger.WriteInfoMessage($"{count} card are not in 3x3 format on the page");
        }

        public static void VerifyAudienceLoaded()
        {
            int count = 0;
            IList<IWebElement> pages = PageObject_CreateCampaign.Create_Audience_Paggination_Page_Numbers();
            IList<IWebElement> cards = PageObject_CreateAudience.Audience_Cards();
            foreach (var item in cards)
            {
                string getCards = item.GetAttribute("class");
                if (getCards.Contains("4"))
                {
                    count = count + 1;
                }
            }
            if (pages.Count > 1)
                Assert.IsTrue(count == 9, $"{count} card are not in 3x3 format on the page and not loaded");
            else
                Assert.IsTrue(count <= 9, $"{count} card are not in 3x3 format on the page and not loaded");
        }

        public static void VerifyUserNavigateToAudienceCardView()
        {
            IList<IWebElement> audienceCards = PageObject_CreateCampaign.Create_Audience_Cards_Title_List();
            Assert.IsTrue(audienceCards.Count >= 1, "Cards are not displaying on the Audience page");
        }


        public static void Click_Audience_Name()
        {
            Helper.ElementClick(PageObject_CreateAudience.Click_Audience_Name());
            Logger.WriteDebugMessage("User lands on Audience Summary page.");
        }
        public static void Verify_CriteriaTab_AudiencePage()
        {
            Helper.ElementClick(PageObject_CreateAudience.Verify_CriteriaTab_AudiencePage());
            Logger.WriteDebugMessage("User lands on Audience Summary page.");
        }

        public static void Get_Audience_Name()
        {
            Helper.GetElementValue(PageObject_CreateAudience.Get_Audience_Name());
            Logger.WriteDebugMessage("Audience name Capture");
        }
        public static void Get_Audience_Status()
        {
            Helper.GetElementValue(PageObject_CreateAudience.Get_Audience_Status());
            Logger.WriteDebugMessage("Audience status Capture.");
        }
        public static void Get_Audience_Tag()
        {
            Helper.GetElementValue(PageObject_CreateAudience.Get_Audience_Tag());
            Logger.WriteDebugMessage("Audience Tag Capture.");
        }
        public static void Get_Audience_UpdatedDate()
        {
            Helper.GetElementValue(PageObject_CreateAudience.Get_Audience_UpdatedDate());
            Logger.WriteDebugMessage("Audience Updated date Capture.");
        }

        public static void Click_ManageAudience_CampaignTab()
        {
            ElementClick(PageObject_CreateAudience.Click_ManageAudience_CampaignTab());
            Logger.WriteDebugMessage("Campaign Tab should get displayed.");
        }

        public static void ClickOnAudienceAndVerifyTitle()
        {
            IList<IWebElement> buttons = PageObject_CreateAudience.AudienceOrSegmentButton();
            ElementClick(buttons[0]);
            string title = Helper.GetText(PageObject_CreateAudience.AudienceHeaderTitle());
            Assert.IsTrue(title.Contains("Audience"), "User is not switch to Audience");
        }
        public static void ClickOnSegmentAndVerifyTitle()
        {
            IList<IWebElement> buttons = PageObject_CreateAudience.AudienceOrSegmentButton();
            ElementClick(buttons[1]);
            string title = Helper.GetText(PageObject_CreateAudience.AudienceHeaderTitle());
            Assert.IsTrue(title.Contains("Segment"), "User is not switch to Segment");
        }

        public static void ClickOnCreateAudience()
        {
            Helper.ElementClick(PageObject_CreateAudience.AudienceCreateButton());
            Helper.ElementClick(PageObject_CreateAudience.Create_Audience_Button());
        }

        public static void ClickOnCreateSegment()
        {
            Helper.ElementClick(PageObject_CreateAudience.AudienceCreateButton());
            Helper.ElementClick(PageObject_CreateAudience.Create_Segment_Button());
        }

        public static void VerifyWizardStepsSettings()
        {
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateCampaign.Create_Wizard_Settings()), "Settings step is not displaying");
        }

        public static void EnterAudienceName(string audienceName)
        {
            Helper.ElementEnterText(PageObject_CreateAudience.Create_Audience_Name(), audienceName);
        }

        public static void ClickOnSave()
        {
            Helper.ElementClick(PageObject_CreateAudience.Create_Segment_Save());
        }
        public static void VerifyAudienceInList(string audienceName, string expStatus)
        {
            int count = 0;
            IList<IWebElement> cards = PageObject_CreateAudience.Audience_Cards_Title();
            IList<IWebElement> status = PageObject_CreateAudience.Audience_Cards_Status();
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].Text.Trim().Equals(audienceName))
                {
                    if (status[i].Text.Trim().Equals(expStatus))
                    {
                        count = count + 1;
                        break;
                    }
                }
            }
            Assert.IsTrue(count == 1, "Audience is not present in list");
        }

        public static void Verify3x3SegmentCardsAvailableOrNot()
        {
            int count = 0;
            IList<IWebElement> cards = PageObject_CreateAudience.Segment_Cards();
            foreach (var item in cards)
            {
                string getCards = item.GetAttribute("class");
                if (getCards.Contains("4"))
                {
                    count = count + 1;
                }
            }
            Assert.IsTrue(count <= 9, $"{count} card are not in 3x3 format on the page");
            Logger.WriteInfoMessage($"{count} card are in 3x3 format on the page");
        }

        public static void EnterSegmentName(string segmentName)
        {
            Helper.ElementEnterText(PageObject_CreateAudience.Create_Segment_Name(), segmentName);
        }

        public static void SelectDomain(string profile)
        {
            Helper.ElementClick(PageObject_CreateAudience.Create_Segment_Domain_Arrow());
            IList<IWebElement> domainList = PageObject_CreateAudience.Create_Segment_DomainOrField_List();
            foreach (var item in domainList)
            {
                if (item.Text.Equals(profile))
                {
                    item.Click();
                    break;
                }
            }
        }

        public static void SelectField(string field)
        {
            Helper.ElementClick(PageObject_CreateAudience.Create_Segment_Field_Arrow());
            IList<IWebElement> listItems = PageObject_CreateAudience.Create_Segment_DomainOrField_List();
            foreach (var item in listItems)
            {
                if (item.Text.Equals(field))
                {
                    item.Click();
                    break;
                }
            }
        }
        public static void SelectOperation(string opration)
        {
            Helper.ElementClick(PageObject_CreateAudience.Create_Segment_Operation_Arrow());
            IList<IWebElement> listItems = PageObject_CreateAudience.Create_Segment_DomainOrField_List();
            foreach (var item in listItems)
            {
                if (item.Text.Equals(opration))
                {
                    item.Click();
                    break;
                }
            }
        }
        public static void EnterCriteriaValue(string criteriaValue)
        {
            Helper.ElementEnterText(PageObject_CreateAudience.Create_Segment_CriteriaValue(), criteriaValue);
        }
        public static void ClickOnFinish()
        {
            Helper.ElementClick(PageObject_CreateAudience.Create_Segment_Finish());
        }
        public static void VerifySegmentCreationPage()
        {
            string msg=Helper.GetText(PageObject_CreateAudience.Segment_Creation_MSG());
            Assert.IsTrue(msg.Contains("created"), "Segment is not created successully");
        }

        public static void VerifySegmenteInList(string segmentName, string expStatus)
        {
            int count = 0;
            IList<IWebElement> cards = PageObject_CreateAudience.Segment_Cards_Title();
            IList<IWebElement> status = PageObject_CreateAudience.Segment_Cards_Status();
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].Text.Trim().Equals(segmentName))
                {
                    if (status[i].Text.Trim().Equals(expStatus))
                    {
                        count = count + 1;
                        break;
                    }
                }
            }
            Assert.IsTrue(count == 1, "Audience is not present in list");
        }

        public static void VerifyAudienceSummaryPage()
        {
            string url = Helper.Driver.Url;
            Assert.IsTrue(url.ToLower().Contains("summary"), "User is not landed on Audience Summary tab");
            IList<IWebElement> tabs = PageObject_CreateAudience.Audience_Summary_Tabs();
            Assert.IsTrue(tabs.Count == 3, "User is not landed on Audience Summary tab");
        }

    }
}
