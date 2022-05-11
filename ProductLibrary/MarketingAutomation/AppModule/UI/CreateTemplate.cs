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
    public class CreateTemplate : Helper
    {

        #region[TemplateSelection]
        /// <summary>
        /// This method will Create Campaign button on the MarketingAutomation manage Campaign page
        /// </summary> 
        public static void ClickOnCreateTemplate()
        {
            ElementClick(PageObject_CreateTemplate.CreateTemplate_Button());
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateTemplate.Create_Template_Name()), "User is not landed on setting page");
            Logger.WriteDebugMessage("User lands on Template Selection page");
        }
        /// <summary>
        /// This method will verify marketing tab selected on the MarketingAutomation manage Campaign page
        /// </summary>

        public static void Verify3x3CardsAvailableOrNot()
        {
            int count = 0;
            IList<IWebElement> cards = PageObject_CreateTemplate.GetNumberOfCardsAvailableInPage();
            foreach (var item in cards)
            {
                string getCards = item.GetAttribute("class");
                if (getCards.Contains("4"))
                {
                    count = count + 1;
                }
            }
            Assert.IsTrue(count <= 9, $"{count} card are not in 3x3 format on the page");
            Logger.WriteInfoMessage($"{count} cardare not in 3x3 format on the page");
        }

        
        public static bool SelctionOfListButtonVerification() {
            bool verified = false;
            IWebElement listVaribleVerification = PageObject_CreateTemplate.SelctionOfListButton();
            verified = IsElementDisplayed(listVaribleVerification);
            Assert.IsTrue(verified == true, $"List switch button not selected yet");
            return verified;

        }
        public static void EnterTemplateName(string template)
        {
            ScrollToElement(PageObject_CreateTemplate.Create_Template_Name());
            ElementEnterText(PageObject_CreateTemplate.Create_Template_Name(), template);
            string value = GetValue(PageObject_CreateTemplate.Create_Template_Name());
            Assert.AreEqual(template.Trim(), value.Trim(), "Template Name is not entered correctly");
        }
        public static void ClickOnSaveAndContinue()
        {
            ScrollToElement(PageObject_CreateTemplate.Create_Template_SaveAndContinue());
            ElementClick(PageObject_CreateTemplate.Create_Template_SaveAndContinue());
            WaitForAjaxControls(90);
        }
        public static void ToVerifySwitchButtonWorking() {
            VerifySwitchButtons();
        }
        public static void SelectAnyTemplateTagFromList()
        {
            GetOptionFromDropDown();
        }
        public static void EnterTemplateDesc(string templateDesc)
        {
            ScrollToElement(PageObject_CreateTemplate.Create_Template_Desc());
            ElementEnterText(PageObject_CreateTemplate.Create_Template_Desc(), templateDesc);
            string value = GetValue(PageObject_CreateTemplate.Create_Template_Desc());
            Assert.AreEqual(templateDesc.Trim(), value.Trim(), "Template description is not entered correctly");
        }
        public static void VerifyTabSelection()
        {
            string selectedTab = null;
            IList<IWebElement> tabsAvailable = PageObject_CreateCampaign.SelectionOTabVerify();
            foreach (var item in tabsAvailable)
            {
                string getSelectedItem = item.GetAttribute("class");
                if (getSelectedItem.Contains("active"))
                {
                    selectedTab = GetText(item);
                }
            }
            Assert.IsTrue(selectedTab.Contains("Marketing"), "All tab are not dipslaying on the page");

        }
        //To tags are getting selected or not from the list
        public static void GetOptionFromDropDown()
        {
            IList<IWebElement> every = null;
            IList<IWebElement> allSelectedList = null;
            IList<string> actList = new List<string>();
            string toVerifyEnterValue = null;
            string afterEnter = null;
            bool verifiedEnteredValue = false;
            WaitForAjaxControls(30);
            ElementClick(PageObject_CreateTemplate.Create_Confirm_Every_Tag_Arrow());
            WaitForAjaxControls(30);
            for (int i = 0; i < 7; i++)
            {
                every = PageObject_CreateTemplate.Create_Confirm_Tag_List();
            }
            foreach (var item in every)
            {
                toVerifyEnterValue = GetText(item).ToLower().Trim();
                item.Click();
                break;
            }
            for (int i = 0; i < 7; i++)
            {
                allSelectedList = PageObject_CreateTemplate.GetListOfSelected();
            }
            foreach (var itemSelected in allSelectedList)
            {
                afterEnter = GetText(itemSelected).ToLower().Trim();
                if (afterEnter.Contains(toVerifyEnterValue))
                    verifiedEnteredValue = true;
            }
            Assert.IsTrue(verifiedEnteredValue.Equals(true), "Selected tags aren't available.");

        }


        public static void VerifySwitchButtons()
        {
            string selectedButton = null;
            IList<IWebElement> switchAvailable = PageObject_CreateTemplate.SelectionOfSwitchTabs();
            foreach (var item in switchAvailable)
            {
                item.Click();
                bool listButton = SelctionOfListButtonVerification();
                if (listButton == true)
                    Assert.IsTrue(listButton, "list not selected");


            }
            //Assert.IsTrue(selectedTab.Contains("Marketing"), "All tab are not dipslaying on the page");

        }

        #endregion[TemplateSelection]

        public static void Verify_ScrollToBottom()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Helper.Driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            bool atBottomConfirmatiom = Helper.IsElementDisplayed(PageObject_CreateCampaign.Create_Audience_Next_Page_Button());
            Assert.IsTrue(atBottomConfirmatiom.Equals(true), "User unable scroll and see next button");

        }

        public static void VerifyTemplatesLoaded()
        {
            int count = 0;
            IList<IWebElement> pages = PageObject_CreateCampaign.Create_Audience_Paggination_Page_Numbers();
            IList<IWebElement> cards = PageObject_CreateTemplate.GetNumberOfCardsAvailableInPage();
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

        public static void VerifyUserNavigateToTemplateCardView()
        {
            IList<IWebElement> templateCards = PageObject_CreateTemplate.Template_Grid_Cards_Title_List();
            Assert.IsTrue(templateCards.Count >= 1, "Cards are not displaying on the Template page");
        }

        public static void VerifyTemplateHeader()
        {
            int count = 6;
            IList<IWebElement> Header = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
            foreach (var item in Header)
            {
                string getHeader = item.GetAttribute("class");
                if (getHeader.Contains("6"))
                {
                    count = count - 1;
                }
            }
            if (Header.Count > 1)
                Assert.IsTrue(count == 6, "columns is not present");
            Logger.WriteDebugMessage("Template grid header is displayed");
        }

        public static void Click_TemplatePage_Ellipses_ViewDetails_SummaryTab()
        {
           ElementClick(PageObject_CreateTemplate.Click_TemplatePage_Ellipses_ViewDetails_SummaryTab());
           Logger.WriteDebugMessage("Click on Summary Tab");
        }
        public static void Click_TemplatePage_Ellipses_ViewDetails()
        {
            ElementClick(PageObject_CreateTemplate.Click_TemplatePage_Ellipses_ViewDetails());
            Logger.WriteDebugMessage("Click on Ellipse >> View Details");
        }
        public static void Click_TemplatePage_Ellipses()
        {
            ElementWait(PageObject_CreateTemplate.Click_TemplatePage_Ellipses(),20);
            ElementClick(PageObject_CreateTemplate.Click_TemplatePage_Ellipses());
            Logger.WriteDebugMessage("Click on Ellipses");
        }

        public static void VerifyManageTemplateHeaderList(string listValues)
        {
            WaitForAjaxControls(50);
            int count = 6;
            IList<IWebElement> HeaderList = null;
            IList<string> actList = new List<string>();
            IList<string> expList = new List<string>();

            HeaderList = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();

            foreach (var item in HeaderList)
            {
                actList.Add(item.GetAttribute("innerHTML").Trim());
            }
            var options = listValues.Split(',');
            foreach (var item in options)
            {
                expList.Add(item.Trim());
            }
            for (int i = 0; i < expList.Count; i++)
            {
                if (actList.Contains(expList[i]))
                    count = count - 1;
                else
                    Logger.WriteInfoMessage($"Actual list contains options: {expList[i]}");
            }
            Assert.IsTrue(expList.Count == count, $"List is not displaying expected options in it {expList}");

        }

        public static void VerifyTemplateDetailsHeaderList(string listValues)
        {
            WaitForAjaxControls(50);
            int count = 5;
            IList<IWebElement> HeaderList = null;
            IList<string> actList = new List<string>();
            IList<string> expList = new List<string>();

            HeaderList = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();

            foreach (var item in HeaderList)
            {
                actList.Add(item.GetAttribute("innerHTML").Trim());
            }
            var options = listValues.Split(',');
            foreach (var item in options)
            {
                expList.Add(item.Trim());
            }
            for (int i = 0; i < expList.Count; i++)
            {
                if (actList.Contains(expList[i]))
                    count = count - 1;
                else
                    Logger.WriteInfoMessage($"Actual list contains options: {expList[i]}");
            }
            Assert.IsTrue(expList.Count == count, $"List is not displaying expected options in it {expList}");

        }

        public static void Click_TemplatePage_SummaryTab()
        {
            IsElementDisplayed(PageObject_CreateTemplate.Click_TemplatePage_SummaryTab());
            Logger.WriteDebugMessage("Summary Overview of Template get displayed.");
        }
        public static void Click_ListView_FirstTemplate()
        {
            ElementClick(PageObject_CreateTemplate.Click_ListView_FirstTemplate());
            Logger.WriteDebugMessage("Click Template Name under list view.");
        }
        /// <summary>
        /// If we provide 1 then it clicks List view, if its 0 then it click grid view buton
        /// </summary>
        /// <param name="index"></param>
        public static void ClickSwitchButtonToChangeView(int index)
        {
            IList<IWebElement> switchAvailable = PageObject_CreateTemplate.SelectionOfSwitchTabs();
            switchAvailable[index].Click();
        }
        /// <summary>
        /// This method disable it if flag is 0 and if its 1 then enabled it
        /// </summary>
        /// <param name="flag"></param>
        public static void EnableOrDisableViewInBrowserLinkUsingFlag(int flag)
        {
            string value = PageObject_CreateTemplate.Create_Template_View_In_Browser_Link().GetAttribute("aria-checked");
            if (flag == 1)
            {
                if (value.Equals("false"))
                    ElementClick(PageObject_CreateTemplate.Create_Template_View_In_Browser_Link());
                value = PageObject_CreateTemplate.Create_Template_View_In_Browser_Link().GetAttribute("aria-checked");
                Assert.IsTrue(value.Equals("true"), "Unable to enable View in Browser Link");
            }
            if (flag == 0)
            {
                if (value.Equals("true"))
                    ElementClick(PageObject_CreateTemplate.Create_Template_View_In_Browser_Link());
                value = PageObject_CreateTemplate.Create_Template_View_In_Browser_Link().GetAttribute("aria-checked");
                Assert.IsTrue(value.Equals("false"), "Unable to disable View in Browser Link");
            }
        }

        /// <summary>
        /// This method disable it if flag is 0 and if its 1 then enabled it
        /// </summary>
        /// <param name="flag"></param>
        public static void EnableOrDisableUnsubsribeLinkUsingFlag(int flag)
        {
            string value = PageObject_CreateTemplate.Create_Template_Unsubsribe_Link().GetAttribute("aria-checked");
            if (flag == 1)
            {
                if (value.Equals("false"))
                    ElementClick(PageObject_CreateTemplate.Create_Template_Unsubsribe_Link());
                value = PageObject_CreateTemplate.Create_Template_Unsubsribe_Link().GetAttribute("aria-checked");
                Assert.IsTrue(value.Equals("true"), "Unable to enable View in Browser Link");
            }
            if (flag == 0)
            {
                if (value.Equals("true"))
                    ElementClick(PageObject_CreateTemplate.Create_Template_Unsubsribe_Link());
                value = PageObject_CreateTemplate.Create_Template_Unsubsribe_Link().GetAttribute("aria-checked");
                Assert.IsTrue(value.Equals("false"), "Unable to disable View in Browser Link");
            }
        }

        public static void VerifyUnsubscribeAndBrowserLinkValue(Template data,string templateName,int unsubsribeValue, int browserLinkValue)
        {
            string unsubscribe, browser;
            if (unsubsribeValue == 0)
                unsubscribe = "false";
            else
                unsubscribe = "true";
            if (browserLinkValue == 0)
                browser = "false";
            else
                browser = "true";
            Queries.GetTemplateIdByName(data, templateName);
            Queries.GetUnsubscribeAndBrowserLinkValueBasedOnTemplateId(data, data.TemplateId);
            if (!unsubscribe.Equals(data.Unsubscribe.ToLower()) && !browser.Equals(data.BrowserLink.ToLower()))
                Assert.Fail($"Unsubscribe is not set as {unsubsribeValue} BrowserLink is not set to {browserLinkValue}");
        }

        public static void Template_Create_Template_Tag_Input_expansion()
        {
            IsElementDisplayed(PageObject_CreateTemplate.Template_Create_Template_Tag_Input_expansion());
        }

        public static void Template_Create_Template_desc_Input()
        {
            IsElementDisplayed(PageObject_CreateTemplate.Template_Create_Template_desc_Input());
        }

        public static void Create_Template_Name_red()
        {
            IsElementDisplayed(PageObject_CreateTemplate.Create_Template_Name_red());
        }
        public static void Template_Create_Template_Name_Input()
        {
            IsElementDisplayed(PageObject_CreateTemplate.Template_Create_Template_Name_Input());
        }
        public static void Create_Template_DesignPage_SelectElement()
        {
            ElementClick(PageObject_CreateTemplate.Create_Template_DesignPage_SelectElement());
            Logger.WriteDebugMessage("Element got selected");
        }
        public static void Create_Template_DesignPage_body()
        {
            ElementClick(PageObject_CreateTemplate.Create_Template_DesignPage_body());
        }
        public static void iframe_Create_Template_DesignPage_body()
        {
            ElementClick(PageObject_CreateTemplate.iframe_Create_Template_DesignPage_body());
        }
        /// <summary>
        /// Get the random template name from list
        /// </summary>
        public static string GetTemplateName()
        {
            Random r = new Random();
            IList<IWebElement> templateCards = PageObject_CreateTemplate.Template_Grid_Cards_Title_List();
            int index;
            index = r.Next(0, templateCards.Count);
            return (Helper.GetText(templateCards[index]));
        }

        public static void VerifyFilterTemplateInfoOnPage(string templateeName)
        {
            Helper.WaitForAjaxControls(50);
            int actCount = 0, expCount = 0;
            IList<IWebElement> templateCards = PageObject_CreateTemplate.Template_Grid_Cards_Title_List();

            for (int i = 0; i < templateCards.Count; i++)
            {
                if (!String.IsNullOrEmpty(templateeName))
                {
                    actCount = actCount + 1;
                    if (templateCards[i].Text.Equals(templateeName))
                        expCount = expCount + 1;
                }
            }
            Assert.IsTrue(actCount >= expCount, "Audience with details is not present in the filter result");
            Assert.IsTrue(expCount >= 1, "System is not displying result based on filter");
        }

        public static void VerifyTemplateListNameOrdersDesc()
        {
            IList<IWebElement> listOfSortData = null;
            Helper.WaitForAjaxControls(50);
            listOfSortData = PageObject_CreateTemplate.Template_Grid_Cards_Title_List();
            if (listOfSortData.Count > 1)
            {
                for (int i = 0; i < listOfSortData.Count - 1; i++)
                {
                    string name1 = listOfSortData[i].Text;
                    string name2 = listOfSortData[i + 1].Text;
                    StringComparer comparer = StringComparer.OrdinalIgnoreCase;
                    if (comparer.Compare(name1, name2) == 0)
                        Logger.WriteInfoMessage("Both strings have same value.");
                    else if (comparer.Compare(name1, name2) < 0)
                        Assert.Fail($"Cmpaign is not in the {listOfSortData} name descending order");
                    else if (comparer.Compare(name1, name2) > 0)
                        Logger.WriteInfoMessage($"{name1} follows {name2}.");
                }
            }
        }

    }
}
