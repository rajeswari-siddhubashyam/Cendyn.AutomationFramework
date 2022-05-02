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
    public class CreateCampaign : Helper
    {

        #region[CampaignSelection]
        /// <summary>
        /// This method will Create Campaign button on the MarketingAutomation manage Campaign page
        /// </summary> 
        public static void ClickOnCreateCampaign()
        {
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Button());
            ElementWait(PageObject_CreateCampaign.Marketing_Button(), 20);
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateCampaign.Marketing_Button()), "User is not landed on Campaign Selection page");
            Logger.WriteDebugMessage("User lands on Campaign Selection page");
        }
        /// <summary>
        /// This method will verify marketing tab selected on the MarketingAutomation manage Campaign page
        /// </summary>
        public static void VerifyMarketingTabSelection()
        {
            string activeText = PageObject_CreateCampaign.Marketing_Button().GetAttribute("class");
            Assert.IsTrue(activeText.Contains("active"), "Marketing tab is not selected by default");
            Logger.WriteInfoMessage("Marketing tab is selected by default");
        }

        /// <summary>
        /// This method will page title on the MarketingAutomation create campaign page
        /// </summary>
        /// <param name="pageTitle">expected page title</param>
        public static void VerifyPageTitle(string pageTitle)
        {
            string title = Driver.Title;
            Assert.IsTrue(pageTitle.Equals(title), $"Page Title is not matching with {pageTitle}");
            Logger.WriteInfoMessage($"Page Title is matching with {pageTitle}");
        }
        /// <summary>
        /// This method verify tabname is present in the application cards
        /// </summary>
        /// <param name="tabName"></param>
        public static void VerifyCardOnActiveTab(string tabName)
        {
            int count = 0;
            IList<IWebElement> cards = PageObject_CreateCampaign.ApplicationCards();
            foreach (var item in cards)
            {
                if (item.Text.Contains(tabName))
                {
                    count = count + 1;
                    break;
                }

            }
            Assert.IsTrue(count > 0, $"{tabName} card is not showing in the list");
            Logger.WriteInfoMessage($"{tabName} card is showing in the list");
        }

        /// <summary>
        /// This method will toggle to Automated tab on the MarketingAutomation create campaign page
        /// </summary>
        public static void ToggletoAutomatedTtab()
        {
            ElementClick(PageObject_CreateCampaign.Automated_Button());
            WaitForAjaxControls(10);
            Logger.WriteDebugMessage("Toggle to automated tab");
        }

        /// <summary>
        /// This method will toggle to Marketing tab on the MarketingAutomation create campaign page
        /// </summary>
        public static void ToggletoMarketingTtab()
        {
            ElementClick(PageObject_CreateCampaign.Marketing_Button());
            WaitForAjaxControls(10);
            Logger.WriteDebugMessage("Toggle to automated tab");
        }

        public static void VerifyClickingOnCardFirstStepOfCampaign()
        {
            try
            {
                //Verify when clicking on card, user is brought to first step of campaign creation process
                IList<IWebElement> cards = Driver.FindElements(By.XPath(ObjectRepository.Campaign_Button_ApplicationCards));
                for (int j = 0; j < 1; j++)
                {
                    ScrollToElement(cards[j]);
                    cards[j].Click();
                    WaitForAjaxControls(50);
                    IWebElement settings = PageObject_CreateCampaign.Create_Wizard_Settings();
                    string color = settings.GetCssValue("border-color");
                    Assert.AreEqual("rgb(39, 110, 205)", color, "Clicking on card, user is not brought to first step of campaign creation process");
                    Logger.WriteDebugMessage("Clicking on card, user is brought to first step of campaign creation process");
                    ElementClick(PageObject_CreateCampaign.Create_Wizard_Back_Button());
                    Logger.WriteDebugMessage("Clicking on back, user is brought to card selection");
                    WaitForAjaxControls(50);
                    for (int i = 0; i <= 10; i++)
                    {
                        cards = Driver.FindElements(By.XPath(ObjectRepository.Campaign_Button_ApplicationCards));
                    }
                }
            }
            catch (System.IndexOutOfRangeException e)
            {
                Logger.WriteErrorMessage("System is not displaying the cards", e);
                throw e;
            }

        }



        public static void ClickingOnCardFirstStepOfCampaign()
        {
            try
            {
                // Click on first card and verify user lands on the settings page
                IList<IWebElement> cards = Driver.FindElements(By.XPath(ObjectRepository.Campaign_Button_ApplicationCards));
                for (int j = 0; j < 1; j++)
                {
                    ScrollToElement(cards[j]);
                    cards[j].Click();
                    WaitForAjaxControls(50);
                    IWebElement settings = PageObject_CreateCampaign.Create_Wizard_Settings();
                    string color = settings.GetCssValue("border-color");
                    Assert.AreEqual("rgb(39, 110, 205)", color, "Clicking on card, user is not brought to first step of campaign creation process");
                    Logger.WriteDebugMessage("Clicking on card, user is brought to first step of campaign creation process");
                }
            }
            catch (System.IndexOutOfRangeException e)
            {
                Logger.WriteErrorMessage("System is not displaying the cards", e);
                throw e;
            }

        }
        /// <summary>
        /// Enter campaignName text and verify same is entered correclty or not
        /// </summary>
        /// <param name="campaignName"> Free text</param>
        public static void EnterCampaignNameVerifySame(string campaignName)
        {
            ElementEnterText(PageObject_CreateCampaign.Create_Campaign_Name(), campaignName);
            string value = GetValue(PageObject_CreateCampaign.Create_Campaign_Name());
            Assert.AreEqual(campaignName.Trim(), value.Trim(), "Campaign Name field is not freeform text box");
            Logger.WriteDebugMessage("Campaign Name field is freeform text box");
        }
        /// <summary>
        /// Enter subject text and verify same is entered correclty or not
        /// </summary>
        /// <param name="subject">subject to enter</param>
        public static void EnterSubjectVerifySame(string subject)
        {
            ElementEnterText(PageObject_CreateCampaign.Create_Campaign_Subject(), subject);
            string value = GetValue(PageObject_CreateCampaign.Create_Campaign_Subject());
            Assert.AreEqual(subject.Trim(), value.Trim(), "Subject field is not freeform text box");
            Logger.WriteDebugMessage("Subject field is freeform text box");
        }
        /// <summary>
        /// This method will verify provided text in subject inline on create campaign wizard
        /// </summary>
        /// <param name="subjectText">subjectText validate it</param>
        public static void VerifySubjectTextOnThePage(string subjectText)
        {
            string value = GetText(PageObject_CreateCampaign.Create_Campaign_Subject_InLine_Txt());
            Assert.AreEqual(subjectText.Trim(), value.Trim(), "Subject text is not macthing as expected");
            Logger.WriteDebugMessage("Subtext: Make your subject lines relevant, engaging, and tailored for the selected audience.");
        }

        public static void ClickOnFromDropDownAndVerifyList(IList<string> fromValue)
        {
            int count = 0;
            ScrollToElement(PageObject_CreateCampaign.Create_Campaign_From_Dropdown());
            ElementClick(PageObject_CreateCampaign.Create_Campaign_From_Dropdown());
            IList<IWebElement> fromList = null;
            for (int i = 0; i < 15; i++)
                fromList = PageObject_CreateCampaign.Create_Campaign_Form_DropDownList();
            foreach (var item in fromList)
            {
                for (int j = 0; j < fromValue.Count; j++)
                {
                    if (item.GetAttribute("data-value").Trim().ToLower().Equals(fromValue[j].Trim().ToLower()))
                    {
                        count = count + 1;
                        break;
                    }
                }

            }
            Assert.IsTrue(count == fromValue.Count, $"{fromValue} is not present in the list");
            //Logger.WriteDebugMessage("From field is populated from the DB From field displays based on Sort Order in the Cosmos DB (Will be from Admin when Admin page is developed)");
            Logger.WriteDebugMessage("From field is populated and verified based on above static list");
            ElementClick(PageObject_CreateCampaign.Create_Campaign_From_Dropdown());
        }

        public static void ClickOnReplyDropDownAndVerifyList(IList<string> replyValue)
        {
            int count = 0;
            ScrollToElement(PageObject_CreateCampaign.Create_Campaign_Reply_Dropdown());
            ElementClick(PageObject_CreateCampaign.Create_Campaign_Reply_Dropdown());
            IList<IWebElement> replyList = null;
            for (int i = 0; i < 15; i++)
                replyList = PageObject_CreateCampaign.Create_Campaign_Reply_DropDownList();
            foreach (var item in replyList)
            {
                for (int j = 0; j < replyValue.Count; j++)
                {
                    if (item.GetAttribute("data-value").Trim().ToLower().Equals(replyValue[j].Trim().ToLower()))
                    {
                        count = count + 1;
                        break;
                    }
                }
            }
            Assert.IsTrue(count == replyValue.Count, $"{replyValue} is not present in the list");
            //Logger.WriteDebugMessage("Reply To field is populated from the DB Reply To field displays based on Sort Order in the Cosmos DB (Will be from Admin when Admin page is developed)");
            Logger.WriteDebugMessage("Reply field is populated and verified based on above static list");
        }

        public static void VerifyTipBoxText(string tipText)
        {
            string value = GetText(PageObject_CreateCampaign.Create_Campaign_Tip_Text());
            Assert.AreEqual(tipText.Trim(), value.Trim(), "Subject text is not macthing as expected");
            Logger.WriteDebugMessage("Text reads: Use an easily recognizable “friendly - from” name and select the sender email address for this campaign.Select the email address that should receive replies to this email.");
        }

        public static void ClickAndVerifySaveAndContinueButtonDisabled()
        {
            try
            {
                PageObject_CreateCampaign.Create_Campaign_SaveAndContinue().Click();
                Logger.WriteErrorMessage("Save and Continue button enabled, clicked it", new Exception("Save&Continue Button enabled"));
            }
            catch (Exception) { }
            string property = PageObject_CreateCampaign.Create_Campaign_SaveAndContinue().GetAttribute("disabled");
            Assert.AreEqual("true", property, "Save and Continue button enabled");
            Logger.WriteDebugMessage("Continue button is disabled");
        }

        public static void EnterCampaignName(string campaignName)
        {
            ScrollToElement(PageObject_CreateCampaign.Create_Campaign_Name());
            ElementEnterText(PageObject_CreateCampaign.Create_Campaign_Name(), campaignName);
            string value = GetValue(PageObject_CreateCampaign.Create_Campaign_Name());
            Assert.AreEqual(campaignName.Trim(), value.Trim(), "Campaign Name is not entered correctly");
        }

        public static void RemoveCampaignNameAndVerifyErrorMsgButtonStatus(string errorMsg)
        {
            PageObject_CreateCampaign.Create_Campaign_Name().Clear();
            PageObject_CreateCampaign.Create_Campaign_Name().SendKeys("c");
            PageObject_CreateCampaign.Create_Campaign_Name().SendKeys(Keys.Backspace);
            string value = GetValue(PageObject_CreateCampaign.Create_Campaign_Name());
            Assert.IsTrue(value.Trim().Length < 1, "Campaign Name is not removed");
            string actError = GetText(PageObject_CreateCampaign.Create_Campaign_Name_Error());
            Assert.AreEqual(errorMsg, actError, "There is not a required field validation message");
            string property = PageObject_CreateCampaign.Create_Campaign_SaveAndContinue().GetAttribute("disabled");
            Assert.AreEqual("true", property, "Save and Continue button enabled");
            Logger.WriteDebugMessage("There is a required field validation message and user cannot click Continue, Campaign Name cannot be empty.");
        }

        public static void EnterSubject(string subject)
        {
            ElementEnterText(PageObject_CreateCampaign.Create_Campaign_Subject(), subject);
            string value = GetValue(PageObject_CreateCampaign.Create_Campaign_Subject());
            Assert.AreEqual(subject.Trim(), value.Trim(), "Subject field is not freeform text box");
        }

        public static void RemoveSubjectAndVerifyErrorMsgs(string errorMsg)
        {
            PageObject_CreateCampaign.Create_Campaign_Subject().Clear();
            PageObject_CreateCampaign.Create_Campaign_Subject().SendKeys("s");
            PageObject_CreateCampaign.Create_Campaign_Subject().SendKeys(Keys.Backspace);
            string value = GetValue(PageObject_CreateCampaign.Create_Campaign_Subject());
            Assert.IsTrue(value.Trim().Length < 1, "Subject is not removed");
            string actError = GetText(PageObject_CreateCampaign.Create_Campaign_Subject_Error());
            Assert.AreEqual(errorMsg, actError, "There is not a required field validation message");
            string property = PageObject_CreateCampaign.Create_Campaign_SaveAndContinue().GetAttribute("disabled");
            Assert.AreEqual("true", property, "Save and Continue button enabled");
            Logger.WriteDebugMessage("There is a required field validation message on Subject field and Campaign Name Subject cannot be empty.");
        }


        public static void VerifyCampaignErrorMsg(string errorMsg)
        {
            string actError = GetText(PageObject_CreateCampaign.Create_Campaign_Name_Error());
            Assert.AreEqual(errorMsg, actError, "There is not a required field validation message");
            string property = PageObject_CreateCampaign.Create_Campaign_SaveAndContinue().GetAttribute("disabled");
            Assert.AreEqual("true", property, "Save and Continue button enabled");
        }
        #endregion

        public static void VerifySubjectRequiredMsgHide()
        {
            try
            {
                Helper.Driver.FindElement(By.XPath(ObjectRepository.Campaign_Create_Campaign_Subject_Error_Text));
                string actError = GetText(PageObject_CreateCampaign.Create_Campaign_Subject_Error());
                Assert.IsTrue(actError.Length < 1, "There is a required field validation message");
            }
            catch (Exception) { }
            Logger.WriteDebugMessage("Subject is added and field validation is gone for Subject");
        }

        public static void ClickOnFromDropDownAndSelectFirstValue()
        {
            ScrollToElement(PageObject_CreateCampaign.Create_Campaign_From_Dropdown());
            ElementClick(PageObject_CreateCampaign.Create_Campaign_From_Dropdown());
            IList<IWebElement> fromList = null;
            for (int i = 0; i < 15; i++)
                fromList = PageObject_CreateCampaign.Create_Campaign_Form_DropDownList();
            foreach (var item in fromList)
            {
                if (item.GetAttribute("data-value").Trim().Length > 1)
                {
                    item.Click();
                    break;
                }
            }
            Logger.WriteDebugMessage("From Name/Email selected");
        }

        public static void RemoveFromSelectionAndVerifyErrorMsgs(string errorMsg)
        {
            ElementClick(PageObject_CreateCampaign.Create_Campaign_Form_RemoveSelection());
            string actError = GetText(PageObject_CreateCampaign.Create_Campaign_From_Error_Text());
            Assert.AreEqual(errorMsg, actError, "There is not a required field validation message");
            Logger.WriteDebugMessage("There is a required field validation message for the From dropdown From Name/Email cannot be empty.");
        }

        public static void Campaign_Create_Design_Click_SendMail()
        {
            ElementClick(PageObject_CreateCampaign.Campaign_Create_Design_Click_SendMail());
            Logger.WriteDebugMessage("Click on Send Mail");
        }

        public static void Campaign_Create_Design_SeedList_value(string values)
        {
            ElementEnterText(PageObject_CreateCampaign.Campaign_Create_Design_SeedList_value(), values);
            Logger.WriteDebugMessage("Seed list drop down displayed.");
        }
        public static void Campaign_Create_Design_SeedList_DDL()
        {
            ElementClick(PageObject_CreateCampaign.Campaign_Create_Design_SeedList_DDL());
            Logger.WriteDebugMessage("Seed Value displayed.");
        }
        public static void Campaign_Create_Design_SendTest_Send_Button()
        {
            ElementClick(PageObject_CreateCampaign.Campaign_Create_Design_SendTest_Send_Button());
            Logger.WriteDebugMessage("Click Send Button.");
        }
        public static void Recipients_Text_Box()
        {
            ElementClick(PageObject_CreateCampaign.Recipients_Text_Box());
        }

        public static void VerifyFromRequiredMsgHide()
        {
            try
            {
                Helper.Driver.FindElement(By.XPath(ObjectRepository.Campaign_Create_Campaign_Subject_Error_Text));
                string actError = GetText(PageObject_CreateCampaign.Create_Campaign_Subject_Error());
                Assert.IsTrue(actError.Length < 1, "There is a required field validation message");
            }
            catch (Exception) { }
            Logger.WriteDebugMessage("From Email added and field validation is gone");
        }

        public static void ClickOnReplyDropDownAndSelectFirstValue()
        {
            ScrollToElement(PageObject_CreateCampaign.Create_Campaign_Reply_Dropdown());
            ElementClick(PageObject_CreateCampaign.Create_Campaign_Reply_Dropdown());
            IList<IWebElement> fromList = null;
            for (int i = 0; i < 15; i++)
                fromList = PageObject_CreateCampaign.Create_Campaign_Reply_DropDownList();
            foreach (var item in fromList)
            {
                if (item.GetAttribute("data-value").Trim().Length > 1)
                {
                    item.Click();
                    break;
                }
            }
            Logger.WriteDebugMessage("Reply email selected");
        }

        public static void RemoveReplySelection()
        {
            ElementClick(PageObject_CreateCampaign.Create_Campaign_Reply_RemoveSelection());
            Logger.WriteDebugMessage("Reply email is removed and there is no field validation");
        }

        public static void VerifyCampaignErrorMsgHide()
        {
            try
            {
                Helper.Driver.FindElement(By.XPath(ObjectRepository.Campaign_Create_Campaign_Name_Error_Text));
                string actError = GetText(PageObject_CreateCampaign.Create_Campaign_Name_Error());
                Assert.IsTrue(actError.Length < 1, "There is  a required field validation message");
            }
            catch (Exception) { }
            Logger.WriteDebugMessage("Campaign Name field validation is gone");
        }

        public static void ClickOnSaveAndContinue()
        {
            ScrollToElement(PageObject_CreateCampaign.Create_Campaign_SaveAndContinue());
            WaitForAjaxControls(90);
            ElementClick(PageObject_CreateCampaign.Create_Campaign_SaveAndContinue());
            WaitForAjaxControls(90);
        }

        public static void VerifyUserNavigatedOnTheAudience()
        {
            Helper.AddDelay(5000);
            IWebElement audience = PageObject_CreateCampaign.Create_Wizard_Audience();
            string color = audience.GetCssValue("border-color");
            Assert.AreEqual("rgb(39, 110, 205)", color, "Clicking on Save&Continue, user is not brought to Audience");
        }

        public static void ClickOnBackAndVerifySettingsTab()
        {
            ElementClick(PageObject_CreateCampaign.Create_Wizard_Back_Button());
            IsElementDisplayed(PageObject_CreateCampaign.Create_Campaign_Name());
            WaitForAjaxControls(50);
        }

        public static void VerifyCampaignName(string campaignName)
        {
            ScrollUpUsingJavaScript(Driver, -1000);
            string value = GetValue(PageObject_CreateCampaign.Create_Campaign_Name());
            Assert.AreEqual(campaignName.Trim(), value.Trim(), "Campaign Name is not entered correctly");
        }

        public static void VerifySubjectName(string subject)
        {
            ScrollUpUsingJavaScript(Driver, -1000);
            string value = GetValue(PageObject_CreateCampaign.Create_Campaign_Subject());
            Assert.AreEqual(subject.Trim(), value.Trim(), "Campaign Name is not entered correctly");
        }

        public static void VerifySubjectErrorMsgs(string errorMsg)
        {
            string actError = GetText(PageObject_CreateCampaign.Create_Campaign_Subject_Error());
            Assert.AreEqual(errorMsg, actError, "There is not a required field validation message");
            string property = PageObject_CreateCampaign.Create_Campaign_SaveAndContinue().GetAttribute("disabled");
            Assert.AreEqual("true", property, "Save and Continue button enabled");

        }

        public static void VerifyFromValue(string fromValue)
        {
            string value = GetValue(PageObject_CreateCampaign.Create_Campaign_From_Dropdown_Input());
            Assert.AreEqual(fromValue, value, $"{fromValue} is not selected in the From Drop down");

        }

        public static void VerifyReplyValue(string replyValue)
        {
            string value = GetValue(PageObject_CreateCampaign.Create_Campaign_Reply_Dropdown_Input());
            Assert.AreEqual(replyValue, value, $"{replyValue} is not selected in the Reply Drop down");

        }

        public static string GetFromValue()
        {
            string value = GetValue(PageObject_CreateCampaign.Create_Campaign_From_Dropdown_Input());
            return value;

        }

        public static string GetReplyValue()
        {
            string value = GetValue(PageObject_CreateCampaign.Create_Campaign_Reply_Dropdown_Input());
            return value;
        }

        /* audience */

        public static void VerifyTruncatedTitleCardPresent()
        {
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> cards = null;
            cards = PageObject_CreateCampaign.Create_Audience_Cards_Title_List();
            foreach (var item in cards)
            {
                Helper.ScrollToElement(item);
                Helper.ElementHover(item);
                if (Helper.IsElementDisplayed(PageObject_CreateCampaign.Create_Audience_Cards_Truncated()))
                {
                    Logger.WriteDebugMessage("Audience Name is trucated with '…' is present in the list ");
                    break;
                }

                cards = PageObject_CreateCampaign.Create_Audience_Cards_Title_List();
            }
        }

        public static void VerifyFullTextTruncatedTitleCard()
        {
            string toolTip;
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> cards = null;
            cards = PageObject_CreateCampaign.Create_Audience_Cards_Title_List();

            foreach (var item in cards)
            {
                Helper.ScrollToElement(item);
                Helper.ElementHover(item);
                if (Helper.IsElementDisplayed(PageObject_CreateCampaign.Create_Audience_Cards_Truncated()))
                {
                    toolTip = GetText(PageObject_CreateCampaign.Create_Audience_Card_ToolTip_Text());
                    Logger.WriteInfoMessage($"This is ToolTip text: {toolTip}");
                    break;
                }
                cards = PageObject_CreateCampaign.Create_Audience_Cards_Title_List();
            }
        }

        public static void VerifyManyTagsWithCount()
        {
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> tagCount = null;
            tagCount = PageObject_CreateCampaign.Create_Audience_Cards_Tag_More_Count_List();
            Assert.IsTrue(tagCount.Count >= 1, "Cards with many tags in not present in the list of the first page");
        }

        public static void VerifyManyTagsWithCountAndHoverDisplayList(int tagCountIndex)
        {
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> tagCount = null;
            IList<IWebElement> moreTags = null;
            IList<IWebElement> tags = null;
            IList<string> hoverTagsList = new List<string>();
            string number;
            tagCount = PageObject_CreateCampaign.Create_Audience_Cards_Tag_More_Count_List();
            tags = PageObject_CreateCampaign.Create_Audience_Cards_Tags_List();
            for (int i = tagCountIndex; i < tags.Count; i++)
            {
                if (Helper.IsElementDisplayed(tagCount[i]))
                {
                    //Helper.ScrollToElement(tagCount[i]);
                    number = (tagCount[i].Text).Substring(1);
                    Helper.ElementHover(tagCount[i]);
                    moreTags = PageObject_CreateCampaign.Create_Audience_Cards_More_Tag_List();
                    foreach (var item in moreTags)
                    {
                        hoverTagsList.Add(item.Text);
                    }
                    Assert.IsTrue(Convert.ToInt32(number) == hoverTagsList.Count, "Count and list is not matching");
                    break;
                }
            }
        }

        public static void ClickOnEllipsesAndSelectContinue()
        {
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> ellipses = PageObject_CreateCampaign.Create_Audience_Card_Menu_Ellipses_List();
            // Generate random number
            Random rnd = new Random();
            int index = rnd.Next(0, ellipses.Count);
            ScrollToElement(ellipses[index]);
            ellipses[index].Click();
            WaitForAjaxControls(90);
            ElementWait(PageObject_CreateCampaign.Create_Audience_Card_SelectAndContinue_Button(), 30);
            ElementClick(PageObject_CreateCampaign.Create_Audience_Card_SelectAndContinue_Button());
            Helper.WaitForAjaxControls(120);
        }

        public static void ClickingOnRandomCardOfCampaignFromList()
        {
            try
            {
                IList<IWebElement> cards = Driver.FindElements(By.XPath(ObjectRepository.Campaign_Button_ApplicationCards));
                // Generate random number
                Random rnd = new Random();
                int index = rnd.Next(0, cards.Count);
                ScrollToElement(cards[index]);
                cards[index].Click();
                WaitForAjaxControls(50);
                IWebElement settings = PageObject_CreateCampaign.Create_Wizard_Settings();
                string color = settings.GetCssValue("border-color");
                Assert.AreEqual("rgb(39, 110, 205)", color, "Clicking on card, user is not brought to first step of campaign creation process");
            }
            catch (System.IndexOutOfRangeException e)
            {
                Logger.WriteErrorMessage("System is not displaying the cards", e);
                throw e;
            }

        }

        public static void VerifyUserNavigateToAudiencePreview()
        {
            Helper.WaitForAjaxControls(120);
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateCampaign.Create_Audience_Preview_Criteria_Text()), "User is not navigated to Audience Preview Page");
        }

        public static void VerifyAudienceName(string audienceName)
        {
            Helper.WaitForAjaxControls(120);
            audienceName = audienceName.Replace(" ", "");
            string aName = GetText(PageObject_CreateCampaign.Create_Audience_Preview_Audience_Name());
            aName = aName.Replace(" ", "");
            Assert.AreEqual(audienceName, aName, "Audience name is not showing correct on Audience preview page");
        }

        public static void VerifyAudienceDescription(string audienceDescription)
        {
            Helper.WaitForAjaxControls(120);
            audienceDescription = audienceDescription.Replace(" ", "");
            string aDescription = GetText(PageObject_CreateCampaign.Create_Audience_Preview_Audience_Description());
            aDescription = aDescription.Replace(" ", "");
            Assert.AreEqual(audienceDescription, aDescription, "Audience description is not showing correct on Audience preview page");
        }

        public static void VerifyTagsOnPreviewPage(string tagName)
        {
            int count = 0;
            IList<IWebElement> tags = PageObject_CreateCampaign.Create_Audience_Cards_Tags().FindElements(By.TagName("span"));
            foreach (var item in tags)
            {
                if (item.GetAttribute("innerHTML").Contains(tagName))
                {
                    count = count + 1;
                    break;
                }

            }
            Assert.IsTrue(count > 0, $"{tagName} tag is not showing in the list");
            Logger.WriteInfoMessage($"{tagName} tag is showing in the list");
        }

        public static void VerifyCorrectCardSelected(string audienceName)
        {
            if (IsElementDisplayed(PageObject_CreateCampaign.Create_Audience_Card_Border()))
            {
                string cardText = PageObject_CreateCampaign.Create_Audience_Card_Border().GetAttribute("innerHTML");
                Assert.IsTrue(cardText.Contains(audienceName), "Correct Audience card is not selected");
            }
        }

        public static void ClickOnBackButton()
        {
            ElementClick(PageObject_CreateCampaign.Create_Wizard_Back_Button());
            WaitForAjaxControls(120);
        }

        public static void SelectCardAndClickOnEllipsesAndSelectContinue()
        {
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> ellipses = PageObject_CreateCampaign.Create_Audience_Card_Menu_Ellipses_List();
            IList<IWebElement> cards = PageObject_CreateCampaign.Create_Audience_Cards_Title_List();
            // Generate random number
            Random rnd = new Random();
            int index = rnd.Next(0, ellipses.Count);
            ScrollToElement(cards[index]);
            cards[index].Click();
            Logger.WriteDebugMessage("Selected card on Audience page");
            ScrollToElement(ellipses[index]);
            ellipses[index].Click();
            WaitForAjaxControls(90);
            ElementWait(PageObject_CreateCampaign.Create_Audience_Card_SelectAndContinue_Button(), 30);
            ElementClick(PageObject_CreateCampaign.Create_Audience_Card_SelectAndContinue_Button());
            Helper.WaitForAjaxControls(120);
        }

        public static string SelectAndReturnAudienceCardName()
        {
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> cards = PageObject_CreateCampaign.Create_Audience_Cards_Title_List();
            // Generate random number
            Random rnd = new Random();
            int index = rnd.Next(0, cards.Count);
            ScrollToElement(cards[index]);
            string audienceName = Helper.GetText(cards[index]);
            cards[index].Click();
            return audienceName;
        }

        public static int ReturnCompainsCountFromAudiencePreviewPage()
        {
            int count = 0;
            Helper.WaitForAjaxControls(120);
            string value = Helper.GetText(PageObject_CreateCampaign.Create_Audience_Preview_Campaigns_Count());
            value = (value.Split('\n'))[1];
            count = Convert.ToInt32(value);
            return count;
        }

        public static void VrifySettingsChecked()
        {
            IWebElement settings = PageObject_CreateCampaign.Create_Wizard_Settings();
            string color = settings.GetCssValue("border-color");
            string bgColor = settings.GetCssValue("background");
            Assert.AreEqual("rgb(39, 110, 205)", color, "Setting is not checked");
            Assert.AreEqual("rgb(39, 110, 205) none repeat scroll 0% 0% / auto padding-box border-box", bgColor, "Setting is not checked");
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateCampaign.Create_Wizard_Settings_Checked()), "Settings is not checked");
        }


        public static void VerifyNoAudienceSelectedDefault()
        {
            int count = 0;
            IList<IWebElement> paggination = PageObject_CreateCampaign.Create_Audience_Paggination_Page_Numbers();
            for (int i = 1; i < paggination.Count; i++)
            {
                try
                {
                    Helper.Driver.FindElement(By.XPath(PageObject_CreateCampaign.Create_Audience_Card_Border_Xpath()));
                    count = count + 1;
                    break;
                }
                catch (Exception)
                {
                    Helper.ScrollToElement(paggination[i]);
                    paggination[i].Click();
                    WaitForAjaxControls(90);
                }
            }
            Assert.IsTrue(count <= 1, "Audience is selected when creating a new campaign");
        }

        public static void VerifySaveAndContinueButtonEnable()
        {
            string property = PageObject_CreateCampaign.Create_Campaign_SaveAndContinue().GetAttribute("disabled");
            Assert.IsTrue(String.IsNullOrEmpty(property), "Save and Continue button disabled");
        }


        public static void VerifyAudienceCount(string audienceName, string expCount)
        {
            int count = 0;
            IList<IWebElement> paggination = PageObject_CreateCampaign.Create_Audience_Paggination_Page_Numbers();
            for (int i = 0; i < paggination.Count; i++)
            {

                IList<IWebElement> audienceCards = PageObject_CreateCampaign.Create_Audience_Cards_Title_List();
                IList<IWebElement> userCounts = PageObject_CreateCampaign.Create_Audience_Cards_Users_Count_List();

                for (int j = 0; j < audienceCards.Count; j++)
                {

                    string aName = audienceCards[j].Text;
                    if (aName.Equals(audienceName))
                    {
                        Helper.ScrollToElement(audienceCards[j]);
                        string viewers = userCounts[j].Text;
                        Assert.AreEqual(expCount, viewers, "Audience count is not rounding");
                        Logger.WriteDebugMessage($"{audienceName} with expected rounded count {expCount}");
                        count = count + 1;
                        break;
                    }
                }
                if (count >= 1)
                    break;
                Helper.ScrollToElement(paggination[i]);
                paggination[i].Click();
                Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                WaitForAjaxControls(90);
            }
            Assert.IsTrue(count >= 1, $"{ audienceName} with expected rounded count { expCount} is not present)");
        }

        public static void SelectGivenAudienceCard(string audienceName)
        {
            int count = 0;
            IList<IWebElement> paggination = PageObject_CreateCampaign.Create_Audience_Paggination_Page_Numbers();
            for (int i = 0; i < paggination.Count; i++)
            {

                IList<IWebElement> audienceCards = PageObject_CreateCampaign.Create_Audience_Cards_Title_List();
                IList<IWebElement> userCounts = PageObject_CreateCampaign.Create_Audience_Cards_Users_Count_List();

                for (int j = 0; j < audienceCards.Count; j++)
                {

                    string aName = audienceCards[j].Text;
                    if (aName.Equals(audienceName))
                    {
                        Helper.ScrollToElement(audienceCards[j]);
                        Helper.ElementClick(audienceCards[j]);
                        count = count + 1;
                        break;
                    }
                }
                if (count >= 1)
                    break;
                Helper.ScrollToElement(paggination[i]);
                paggination[i].Click();
                Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                WaitForAjaxControls(90);
            }
        }

        public static string SearchAudienceAndGetCampaignCount(string audienceName)
        {
            int count = 0;
            string campCount = null;
            IList<IWebElement> paggination = PageObject_CreateCampaign.Create_Audience_Paggination_Page_Numbers();
            for (int i = 0; i < paggination.Count; i++)
            {

                IList<IWebElement> audienceCards = PageObject_CreateCampaign.Create_Audience_Cards_Title_List();
                IList<IWebElement> emailCounts = PageObject_CreateCampaign.Create_Audience_Cards_Email_Count_List();

                for (int j = 0; j < audienceCards.Count; j++)
                {

                    string aName = audienceCards[j].Text;
                    if (aName.Equals(audienceName))
                    {
                        Helper.ScrollToElement(emailCounts[j]);
                        campCount = GetText(emailCounts[j]);
                        count = count + 1;
                        break;
                    }
                }
                if (count >= 1)
                    break;
                Helper.ScrollToElement(paggination[i]);
                paggination[i].Click();
                Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                WaitForAjaxControls(90);
            }
            return campCount;
        }

        public static void VerifyAudienceDetailsOnGrid(string audienceName, string criteriaCount,
            string audienceTags, string audienceCount, string campaignsCount, string audienceUpdateDate)
        {
            int count = 0;
            IList<IWebElement> paggination = PageObject_CreateCampaign.Create_Audience_Paggination_Page_Numbers();
            for (int i = 0; i < paggination.Count; i++)
            {

                IList<IWebElement> audienceCards = PageObject_CreateCampaign.Create_Audience_Cards_Title_List();
                IList<IWebElement> userCounts = PageObject_CreateCampaign.Create_Audience_Cards_Users_Count_List();
                IList<IWebElement> emailCounts = PageObject_CreateCampaign.Create_Audience_Cards_Email_Count_List();
                IList<IWebElement> tags = PageObject_CreateCampaign.Create_Audience_Cards_Tags_List();
                IList<IWebElement> criteriaText = PageObject_CreateCampaign.Create_Audience_Cards_SubTitles_List();
                IList<IWebElement> cardDates = PageObject_CreateCampaign.Create_Audience_Cards_Dates_List();

                for (int j = 0; j < audienceCards.Count; j++)
                {

                    string aName = audienceCards[j].Text;
                    if (aName.Equals(audienceName))
                    {
                        Helper.ScrollToElement(audienceCards[j]);
                        string viewers = userCounts[j].Text;
                        string emailCount = emailCounts[j].Text;
                        audienceTags = audienceTags.Replace(",", "");
                        string tagsList = tags[j].Text;
                        string textCriteria = criteriaText[j].Text;
                        textCriteria = textCriteria.Split(' ')[0];
                        string date = cardDates[j].Text;
                        audienceUpdateDate = audienceUpdateDate.Split(' ')[0];
                        DateTime stringtodate = Convert.ToDateTime(date);
                        string expDate = stringtodate.ToString().Split(' ')[0];
                        if (audienceCount.Equals(viewers) && emailCount.Equals(campaignsCount) && audienceTags.Trim().Equals(tagsList) && textCriteria.Equals(criteriaCount) && audienceUpdateDate.Equals(expDate))
                            Logger.WriteInfoMessage("Cards values are not matching as per database");
                        else
                            Assert.Fail("Cards values are not matching as per database");
                        count = count + 1;
                        break;
                    }
                }
                if (count >= 1)
                    break;
                Helper.ScrollToElement(paggination[i]);
                paggination[i].Click();
                Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                WaitForAjaxControls(90);
            }
            Assert.IsTrue(count >= 1, $"{ audienceName} with expected cards value  is not present)");
        }

        public static void SelectRandomAudienceCardFromFirstPage()
        {
            IList<IWebElement> audienceCards = PageObject_CreateCampaign.Create_Audience_Cards_Title_List();
            // Generate random number
            Random rnd = new Random();
            int index = rnd.Next(0, audienceCards.Count);
            ScrollToElement(audienceCards[index]);
            audienceCards[index].Click();
        }



        public static void VerifyUserNavigateToDesignCardView()
        {
            IList<IWebElement> designCards = PageObject_CreateCampaign.Create_Design_Cards_Title_List();
            Assert.IsTrue(Helper.IsElementDisplayed(PageObject_CreateCampaign.Create_Design_New_Button()), "New button is not visible on the Design page");
            Assert.IsTrue(designCards.Count >= 1, "Cards are not displaying on the Design page");
        }

        public static void VrifyAudienceChecked()
        {
            IWebElement audience = PageObject_CreateCampaign.Create_Wizard_Audience();
            string color = audience.GetCssValue("border-color");
            string bgColor = audience.GetCssValue("background");
            Assert.AreEqual("rgb(39, 110, 205)", color, "Audience is not checked");
            Assert.AreEqual("rgb(39, 110, 205) none repeat scroll 0% 0% / auto padding-box border-box", bgColor, "Audience is not checked");
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateCampaign.Create_Wizard_Audience_Checked()), "Audience is not checked");
        }

        public static void VerifyDesignHighlighted()
        {
            IWebElement audience = PageObject_CreateCampaign.Create_Wizard_Design();
            string color = audience.GetCssValue("border-color");
            Assert.AreEqual("rgb(39, 110, 205)", color, "Clicking on Save&Continue, user is not brought to Audience");
        }

        public static void VerifyNoDesignSelectedDefault()
        {
            int count = 0;
            IList<IWebElement> paggination = PageObject_CreateCampaign.Create_Audience_Paggination_Page_Numbers();
            int loopCount = Convert.ToInt32(paggination[paggination.Count - 1].Text);
            for (int i = 1; i < loopCount; i++)
            {
                try
                {
                    Helper.Driver.FindElement(By.XPath(PageObject_CreateCampaign.Create_Design_Card_Border_Xpath()));
                    count = count + 1;
                    break;
                }
                catch (Exception)
                {
                    for (int z = 0; z < 3; z++) { paggination = PageObject_CreateCampaign.Create_Audience_Paggination_Page_Numbers(); }
                    if (paggination[paggination.Count - 1].Text.Length >= 2)
                    {
                        Helper.ScrollToElement(PageObject_CreateCampaign.Create_Audience_Next_Page_Button());
                        PageObject_CreateCampaign.Create_Audience_Next_Page_Button().Click();
                        WaitForAjaxControls(90);
                    }
                    else
                    {
                        Helper.ScrollToElement(paggination[i]);
                        paggination[i].Click();
                        WaitForAjaxControls(90);
                    }

                }
            }
            Assert.IsTrue(count <= 1, "Design is selected when creating a new campaign");
        }

        public static string SelectAndReturnDesignCardName()
        {
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> designCards = PageObject_CreateCampaign.Create_Design_Cards_Title_List();
            // Generate random number
            Random rnd = new Random();
            int index = rnd.Next(0, designCards.Count);
            ScrollToElement(designCards[index]);
            string designCardName = Helper.GetText(designCards[index]);
            ElementClick(designCards[index]);
            return designCardName;
        }

        public static void VerifyCorrectDesignCardSelected(string cardName)
        {
            if (IsElementDisplayed(PageObject_CreateCampaign.Create_Design_Card_Border()))
            {
                string cardText = PageObject_CreateCampaign.Create_Design_Card_Border().GetAttribute("innerHTML");
                Assert.IsTrue(cardText.Contains(cardName), "Correct card is not selected");
            }
        }

        public static void VerifyUserNavigateToDesignPreview()
        {
            Helper.WaitForAjaxControls(120);
            Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Design_Preview_Page_Loader());
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateCampaign.Create_Design_Preview_Edit_Design_Button()), "User is not navigated to Design Preview Page");
        }

        public static void ValidateDesignCardTitleOnPreviewPage(string designCardTitle)
        {
            string cardTitle = Helper.GetText(PageObject_CreateCampaign.Create_Design_Preview_Design_Title());
            Assert.AreEqual(designCardTitle.Trim(), cardTitle.Trim(), "Correct Design card title is not displaying on the preview page");
        }

        public static void SelectGivenDesignCard(string designName)
        {
            int count = 0;
            IList<IWebElement> paggination = PageObject_CreateCampaign.Create_Audience_Paggination_Page_Numbers();
            for (int i = 0; i < paggination.Count; i++)
            {

                IList<IWebElement> designCards = PageObject_CreateCampaign.Create_Design_Cards_Title_List();

                for (int j = 0; j < designCards.Count; j++)
                {

                    string dName = designCards[j].Text;
                    if (dName.Equals(designName))
                    {
                        Helper.ScrollToElement(designCards[j]);
                        Helper.ElementClick(designCards[j]);
                        count = count + 1;
                        break;
                    }
                }
                if (count >= 1)
                    break;
                Helper.ScrollToElement(paggination[i]);
                paggination[i].Click();
                Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Design_Preview_Page_Loader());
                WaitForAjaxControls(90);
            }
        }

        public static void ClickOnDesignListButton()
        {
            ElementClick(PageObject_CreateCampaign.Create_Design_ListView_Button());
            WaitForAjaxControls(40);
        }

        public static void VerifyDesignListViewPage()
        {
            WaitForAjaxControls(40);
            IList<IWebElement> columns = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
            IList<IWebElement> cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List();
            if (columns.Count <= 0 || cellData.Count <= 0)
                Assert.Fail("User is not navigated to the list view");
        }

        public static void VerifyFullTextTruncatedTitleDesignCard()
        {
            string toolTip;
            int columnIndex = 0, count = 0, pages = 0;
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> cellData = null;
            IList<IWebElement> paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers();
            int loopCount = Convert.ToInt32(paggination[paggination.Count - 1].Text);
            for (int z = 0; z < loopCount; z++)
            {
                WaitForAjaxControls(120);
                for (int s = 0; s < 30; s++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                IList<IWebElement> columns = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("NAME"))
                        break;
                }

                for (int i = columnIndex - 1; i < cellData.Count; i++)
                {
                    Helper.ScrollToElement(cellData[i]);
                    Helper.ElementHover(cellData[i]);
                    if (Helper.IsElementDisplayed(PageObject_CreateCampaign.Create_Audience_Card_ToolTip_Text()))
                        Logger.WriteDebugMessage("Tooltip Displayed");
                    {
                        count = count + 1;
                        toolTip = GetText(PageObject_CreateCampaign.Create_Audience_Card_ToolTip_Text());
                        Logger.WriteInfoMessage($"This is ToolTip text: {toolTip}");
                        break;
                    }
                    for (int b = 0; b < 20; b++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                    i = i + 6;
                }

                if (count >= 1)
                    break;
                pages = pages + 1;
                if (pages >= 1)
                    break;
                for (int k = 0; k < 10; k++) { paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers(); }
                if (paggination[paggination.Count - 1].Text.Length >= 2)
                {
                    Helper.ScrollToElement(PageObject_CreateCampaign.Create_Audience_ListView_Next_Page_Button());
                    PageObject_CreateCampaign.Create_Audience_ListView_Next_Page_Button().Click();
                    Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                    columnIndex = 0;
                    WaitForAjaxControls(90);
                }
                else
                {
                    Helper.ScrollToElement(paggination[z]);
                    paggination[z].Click();
                    Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                    columnIndex = 0;
                    WaitForAjaxControls(90);
                }
            }
            Assert.IsTrue(count >= 1, "System is not displaying complete text after mouse hover the truncated design name");
        }


        public static void VerifyDefaultListBasedOnUpdatedOn()
        {
            int columnIndex = 0, count = 0;
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> cellData = null;
            IList<string> updatedOn = new List<string>();
            IList<IWebElement> paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers();
            int loopCount = Convert.ToInt32(paggination[paggination.Count - 1].Text);
            for (int z = 0; z < loopCount; z++)
            {
                WaitForAjaxControls(60);
                for (int l = 0; l < 20; l++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                IList<IWebElement> columns = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("UPDATED ON"))
                        break;
                }

                for (int i = columnIndex - 1; i < cellData.Count; i++)
                {

                    Helper.ScrollToElement(cellData[i]);
                    updatedOn.Add(cellData[i].Text);
                    for (int k = 0; k < 10; k++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                    i = i + 6;
                }
                count = count + 1;
                if (count >= 1)
                    break;
                for (int k = 0; k < 3; k++) { paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers(); }
                if (paggination[paggination.Count - 1].Text.Length >= 2)
                {
                    Helper.ScrollToElement(PageObject_CreateCampaign.Create_Audience_ListView_Next_Page_Button());
                    PageObject_CreateCampaign.Create_Audience_ListView_Next_Page_Button().Click();
                    Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                    columnIndex = 0;
                    WaitForAjaxControls(90);
                }
                else
                {
                    Helper.ScrollToElement(paggination[z]);
                    paggination[z].Click();
                    Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                    columnIndex = 0;
                    WaitForAjaxControls(90);
                }
            }
            for (int f = 0; f < updatedOn.Count - 1; f++)
            {
                DateTime stringtodate = Convert.ToDateTime(updatedOn[f]);
                DateTime stringtodate2 = Convert.ToDateTime(updatedOn[f + 1]);
                if (stringtodate >= stringtodate2)
                    Logger.WriteInfoMessage("Default load will display by Updated On descending");
                else
                    Assert.Fail($"{stringtodate} and {stringtodate2} not is updated on descending order");
            }
        }


        public static void VerifCampaignCountForTheDesign(Campaign data)
        {
            int columnIndex = 0, count = 0, campaignIndex = 0, columnDiff;
            string designCardName, campCount;
            IList<IWebElement> cellData = null;
            IList<string> updatedOn = new List<string>();
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers();
            int loopCount = Convert.ToInt32(paggination[paggination.Count - 1].Text);
            for (int z = 0; z < loopCount; z++)
            {
                WaitForAjaxControls(60);
                for (int l = 0; l < 20; l++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                IList<IWebElement> columns = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("NAME"))
                        break;
                }
                foreach (var item in columns)
                {
                    campaignIndex = campaignIndex + 1;
                    if (item.Text.Trim().Equals("CAMPAIGNS"))
                        break;
                }
                columnDiff = campaignIndex - columnIndex;
                for (int i = columnIndex - 1; i < cellData.Count; i++)
                {

                    Helper.ScrollToElement(cellData[i]);
                    designCardName = cellData[i].Text.Trim();
                    campCount = cellData[i + columnDiff].Text.Trim();
                    Queries.GetCampaignsCountForTheDesignUsingName(data, designCardName);
                    Assert.AreEqual(designCardName, data.TemplateName.Trim(), "Campaign name is not matching");
                    Assert.AreEqual(campCount, data.CampaignsCount.Trim(), "Campaign count is not matching as per database");
                    for (int k = 0; k < 10; k++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                    i = i + 6;
                }
                count = count + 1;
                if (count >= 1)
                    break;
                for (int k = 0; k < 3; k++) { paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers(); }
                if (paggination[paggination.Count - 1].Text.Length >= 2)
                {
                    Helper.ScrollToElement(PageObject_CreateCampaign.Create_Audience_ListView_Next_Page_Button());
                    PageObject_CreateCampaign.Create_Audience_ListView_Next_Page_Button().Click();
                    Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                    columnIndex = 0;
                    campaignIndex = 0;
                    WaitForAjaxControls(90);
                }
                else
                {
                    Helper.ScrollToElement(paggination[z]);
                    paggination[z].Click();
                    Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                    columnIndex = 0;
                    campaignIndex = 0;
                    WaitForAjaxControls(90);
                }
            }
        }

        public static void VerifyPagginationFunctionalityForDesingListView()
        {
            bool nextCount = true, prevCount = true, page = true;
            IList<IWebElement> paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers();
            //Verify list should have more than one page
            if (paggination.Count > 1)
            {
                //verify next button functionality
                Helper.ScrollToElement(PageObject_CreateCampaign.Create_Audience_ListView_Next_Page_Button());
                PageObject_CreateCampaign.Create_Audience_ListView_Next_Page_Button().Click();
                Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                WaitForAjaxControls(90);
                for (int i = 0; i < 15; i++) { paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers(); }
                if (paggination[1].GetAttribute("class").Equals("active"))
                    Logger.WriteDebugMessage("Navigated to the next page using Next button");
                else
                    nextCount = false;

                //verify previous button functionality
                Helper.ScrollToElement(PageObject_CreateCampaign.Create_Audience_ListView_Previous_Page_Button());
                PageObject_CreateCampaign.Create_Audience_ListView_Previous_Page_Button().Click();
                Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                WaitForAjaxControls(90);
                for (int i = 0; i < 15; i++) { paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers(); }
                if (paggination[0].GetAttribute("class").Equals("active"))
                    Logger.WriteDebugMessage("User able to navigate with Previous button");
                else
                    prevCount = false;

                //verify page number button functionality
                for (int i = 0; i < 15; i++) { paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers(); }
                Helper.ScrollToElement(paggination[1]);
                Helper.ElementClick(paggination[1]);
                Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                WaitForAjaxControls(90);
                for (int i = 0; i < 15; i++) { paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers(); }
                if (paggination[1].GetAttribute("class").Equals("active"))
                    Logger.WriteDebugMessage("User able to navigate with pages numbe");
                else
                    page = false;

                if (nextCount && prevCount && page)
                {
                    Logger.WriteInfoMessage(" 1. User should able to see Prev and Next buttons " +
                                            " 2.User should able to navigate to pages with Prev and Next button" +
                                            " 3.User should able to navigate with pages numbers");
                }
                else
                {
                    Assert.Fail($"Next button={nextCount} or Previous button={prevCount} or Page number={page} is not working");
                }
            }
            else
            {
                Logger.WriteDebugMessage("Unable to validate paggination functionality due to pages are not available");
            }
        }

        public static void VerifyDesignTemplateNameAsPerDB(Campaign data)
        {
            int columnIndex = 0, count = 0;
            string designCardName, campCount;
            IList<IWebElement> cellData = null;
            IList<string> updatedOn = new List<string>();
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers();
            int loopCount = Convert.ToInt32(paggination[paggination.Count - 1].Text);
            for (int z = 0; z < loopCount; z++)
            {
                WaitForAjaxControls(60);
                for (int l = 0; l < 20; l++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                IList<IWebElement> columns = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("NAME"))
                        break;
                }

                for (int i = columnIndex - 1; i < cellData.Count; i++)
                {
                    Helper.ScrollToElement(cellData[i]);
                    designCardName = cellData[i].Text.Trim();
                    Queries.GetTemplateNameBasedOnName(data, designCardName);
                    Assert.AreEqual(designCardName, data.TemplateName.Trim(), "Campaign name is not matching");
                    for (int k = 0; k < 10; k++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                    i = i + 6;
                }
                count = count + 1;
                if (count >= 1)
                    break;
                for (int k = 0; k < 3; k++) { paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers(); }
                if (paggination[paggination.Count - 1].Text.Length >= 2)
                {
                    Helper.ScrollToElement(PageObject_CreateCampaign.Create_Audience_ListView_Next_Page_Button());
                    PageObject_CreateCampaign.Create_Audience_ListView_Next_Page_Button().Click();
                    Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                    columnIndex = 0;
                    WaitForAjaxControls(90);
                }
                else
                {
                    Helper.ScrollToElement(paggination[z]);
                    paggination[z].Click();
                    Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                    columnIndex = 0;
                    WaitForAjaxControls(90);
                }
            }
        }


        public static void VerifyManyTagsWithCountAndHoverDisplayListOnDesignTemplateList()
        {
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> tagCount = null;
            IList<IWebElement> moreTags = null;
            IList<IWebElement> tags = null;
            IList<string> hoverTagsList = new List<string>();
            string number;
            tagCount = PageObject_CreateCampaign.Create_Audience_Cards_Tag_More_Count_List();
            tags = PageObject_CreateCampaign.Create_Audience_List_Cards_Tag_List();
            for (int i = 0; i < tags.Count; i++)
            {
                if (Helper.IsElementDisplayed(tagCount[i]))
                {
                    //Helper.ScrollToElement(tagCount[i]);
                    number = (tagCount[i].Text).Substring(1);
                    Helper.ElementHover(tagCount[i]);
                    moreTags = PageObject_CreateCampaign.Create_Audience_Cards_More_Tag_List();
                    foreach (var item in moreTags)
                    {
                        if (!item.Text.Equals(","))
                            hoverTagsList.Add(item.Text);
                    }
                    Assert.IsTrue(Convert.ToInt32(number) == hoverTagsList.Count, "Count and list is not matching");
                    break;
                }
            }
        }

        public static void VerifyTagsForTheTemplatesPerDB(Campaign data)
        {
            Helper.WaitForAjaxControls(120);
            IList<string> tagsList = new List<string>();
            int columnIndex = 0, count = 0, tagCounts = 0;
            string designCardName, allTags = null;
            IList<IWebElement> cellData = null;
            IList<IWebElement> rowTags = new List<IWebElement>();
            IList<string> updatedOn = new List<string>();
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers();
            int loopCount = Convert.ToInt32(paggination[paggination.Count - 1].Text);
            for (int z = 0; z < loopCount; z++)
            {
                WaitForAjaxControls(60);
                for (int l = 0; l < 20; l++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                IList<IWebElement> columns = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("NAME"))
                        break;
                }
                int tagIndex = 0, columnDiff;
                foreach (var item in columns)
                {

                    tagIndex = tagIndex + 1;
                    if (item.Text.Trim().Equals("TAGS"))
                        break;
                }
                columnDiff = tagIndex - columnIndex;
                for (int i = columnIndex - 1; i < cellData.Count; i++)
                {
                    Helper.ScrollToElement(cellData[i]);
                    designCardName = cellData[i].Text.Trim();
                    allTags = null;
                    allTags = cellData[i + columnDiff].GetAttribute("innerHTML");
                    Queries.GetTemplateIDBasedOnName(data, designCardName);
                    Queries.GetTagsUsingDesignTemplateId(data, Convert.ToInt32(data.TemplateId));
                    if (data.DesignTagNames.Count > 1)
                    {
                        for (int k = 0; k < data.DesignTagNames.Count; k++)
                        {
                            if (allTags.Contains(data.DesignTagNames[k]))
                                tagCounts = tagCounts + 1;
                        }
                        if (tagCounts != data.DesignTagNames.Count)
                            Assert.Fail($"Tags are not displaying as per data base for the design template= {designCardName}");
                        else
                            Logger.WriteInfoMessage($"Tags are displaying as per data base for the design template= {designCardName}");
                    }

                    for (int k = 0; k < 10; k++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                    i = i + 6;
                }
                count = count + 1;
                if (count >= 1)
                    break;
                for (int k = 0; k < 3; k++) { paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers(); }
                if (paggination[paggination.Count - 1].Text.Length >= 2)
                {
                    Helper.ScrollToElement(PageObject_CreateCampaign.Create_Audience_ListView_Next_Page_Button());
                    PageObject_CreateCampaign.Create_Audience_ListView_Next_Page_Button().Click();
                    Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                    columnIndex = 0;
                    WaitForAjaxControls(90);
                }
                else
                {
                    Helper.ScrollToElement(paggination[z]);
                    paggination[z].Click();
                    Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                    columnIndex = 0;
                    WaitForAjaxControls(90);
                }
            }
        }

        public static void ClickOnDesignGridButton()
        {
            ElementClick(PageObject_CreateCampaign.Create_Design_GridView_Button());
            WaitForAjaxControls(40);
        }

        public static void VerifyUpdatedByForTheTemplatesPerDB(Campaign data)
        {
            Helper.WaitForAjaxControls(120);
            int columnIndex = 0, updatedByIndex = 0, columnDiff;
            string designCardName, updateBy;
            IList<IWebElement> cellData = null;
            cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List();
            IList<IWebElement> columns = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
            foreach (var item in columns)
            {
                columnIndex = columnIndex + 1;
                if (item.Text.Trim().Equals("NAME"))
                    break;
            }
            foreach (var item in columns)
            {
                updatedByIndex = updatedByIndex + 1;
                if (item.Text.Trim().Equals("UPDATED BY"))
                    break;
            }
            columnDiff = updatedByIndex - columnIndex;
            for (int i = columnIndex - 1; i < cellData.Count; i++)
            {
                Helper.ScrollToElement(cellData[i]);
                designCardName = cellData[i].Text.Trim();
                updateBy = cellData[i + columnDiff].Text.Trim();
                if (updateBy.Contains("\n"))
                    updateBy = updateBy.Split('\n')[1];
                Queries.GetUpdateByIdBasedOngDesignTemplateName(data, designCardName);
                if (data.UpdateById.Length >= 1)
                {
                    Queries.GetUserFirstAndLastNameBasedOnId(data, Convert.ToInt32(data.UpdateById));
                    string completeDBName = data.UserFirstName.Trim() + " " + data.UserLastName.Trim();
                    Assert.IsTrue(completeDBName.Equals(updateBy), $"For the template {designCardName} update by name is not correct");
                }
                else
                {
                    Logger.WriteInfoMessage($"{designCardName} not contains the updatete by ");
                }
                for (int k = 0; k < 10; k++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                i = i + 6;
            }
        }

        public static void VerifyDefaultRecipients(string DefaultLoginEmail)
        {
            string value = GetText(PageObject_CreateCampaign.Recipients_Text_Box());
            Assert.AreEqual(DefaultLoginEmail.Trim(), value.Trim(), "Recipients text is not macthing as expected");
            Logger.WriteDebugMessage("Recipients field show default logged in email of the user.");
        }

        public static void Recipients_Text_Box(string value)
        {
            ElementEnterText(PageObject_CreateCampaign.Recipients_Text_Box(), value);
            WaitForAjaxControls(40);
        }
        public static void Enter_Recipients(string value)
        {
            ElementEnterText(PageObject_CreateCampaign.Enter_Recipients(), value);
            WaitForAjaxControls(40);
        }


        public static void Campaign_Create_Design_Enter_SeedList(string value)
        {
            ElementEnterText(PageObject_CreateCampaign.Campaign_Create_Design_Enter_SeedList(), value);
            PageObject_CreateCampaign.Campaign_Create_Design_Enter_SeedList().SendKeys(Keys.Enter);
            WaitForAjaxControls(40);
        }



        public static void VerifyLastUpdatedDateForTheTemplatesPerDB(Campaign data)
        {
            Helper.WaitForAjaxControls(120);
            int columnIndex = 0, updatedByIndex = 0, columnDiff;
            string designCardName, updateOn;
            IList<IWebElement> cellData = null;
            cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List();
            IList<IWebElement> columns = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
            foreach (var item in columns)
            {
                columnIndex = columnIndex + 1;
                if (item.Text.Trim().Equals("NAME"))
                    break;
            }
            foreach (var item in columns)
            {
                updatedByIndex = updatedByIndex + 1;
                if (item.Text.Trim().Equals("UPDATED ON"))
                    break;
            }
            columnDiff = updatedByIndex - columnIndex;
            for (int i = columnIndex - 1; i < cellData.Count; i++)
            {
                Helper.ScrollToElement(cellData[i]);
                designCardName = cellData[i].Text.Trim();
                updateOn = cellData[i + columnDiff].Text.Trim();
                updateOn = Convert.ToDateTime(updateOn).ToString().Split(' ')[0];
                Queries.GetCreateUpdateDateBasedOngDesignTemplateName(data, designCardName);
                if (data.UpdateDate.Length >= 1)
                {
                    data.UpdateDate = Convert.ToDateTime(data.UpdateDate).ToString().Split(' ')[0];
                    Assert.IsTrue(data.UpdateDate.Equals(updateOn), $"For the template {designCardName} update on date is not correct");
                }
                else
                {
                    data.CreateDate = Convert.ToDateTime(data.CreateDate).ToString().Split(' ')[0];
                    Assert.IsTrue(data.CreateDate.Equals(updateOn), $"For the template {designCardName} update on date is not correct");
                }
                for (int k = 0; k < 10; k++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                i = i + 6;
            }
        }

        public static void VerifyConfirmHighlightedAndPage()
        {
            Helper.AddDelay(5000);
            IWebElement audience = PageObject_CreateCampaign.Create_Wizard_Confirm();
            string color = audience.GetCssValue("border-color");
            Assert.AreEqual("rgb(39, 110, 205)", color, "Clicking on Save&Continue, user is not brought to Confirm");
            if (!IsElementDisplayed(PageObject_CreateCampaign.Create_Confirm_Self_Approve()))
                Assert.Fail("Unable to see Self Approve button on confirm page");
        }

        public static void ClickOnSelfApproveButton()
        {
            ElementClick(PageObject_CreateCampaign.Create_Confirm_Self_Approve());
            if (!IsElementDisplayed(PageObject_CreateCampaign.Create_Confirm_Schedule_Text()))
                Assert.Fail("Unable to see Schedule text after clicking on Self Approve button");
        }

        public static void VerifySendDefaultValue(string sendValue)
        {
            WaitForAjaxControls(120);
            Helper.ElementWait(PageObject_CreateCampaign.Create_Confirm_Send_Input(), 10);
            string valueSend = Helper.GetValue(PageObject_CreateCampaign.Create_Confirm_Send_Input()).Trim();
            if (String.IsNullOrEmpty(valueSend))
            {
                AddDelay(5000);
                valueSend = Helper.GetValue(PageObject_CreateCampaign.Create_Confirm_Send_Input()).Trim();
            }
            Assert.AreEqual(sendValue.Trim(), valueSend, $"System is not displaying default value: {sendValue}");
        }

        public static void VerifyDayFromCurrentDate()
        {
            DateTime now = DateTime.Now;
            string date = now.ToString().Split(' ')[0];
            string valueFromDate = Helper.GetValue(PageObject_CreateCampaign.Create_Confirm_Days_From_Input()).Trim();
            string actDate = Convert.ToDateTime(valueFromDate).ToString().Split(' ')[0];
            Assert.AreEqual(date, actDate, $"System is not displaying Today's date: {date}");
        }

        public static void VerifyUntilCurrentDate()
        {
            DateTime now = DateTime.Now;
            string date = now.ToString().Split(' ')[0];
            string valueUntilDate = Helper.GetValue(PageObject_CreateCampaign.Create_Confirm_Until_Input()).Trim();
            string actDate = Convert.ToDateTime(valueUntilDate).ToString().Split(' ')[0];
            Assert.AreEqual(date, actDate, $"System is not displaying Today's date: {date}");
        }
        public static void VerifyTimeGreaterThanCurrentTime()
        {

            string time = DateTime.Now.ToString("hh:mm tt");
            DateTime newTime = Convert.ToDateTime(time);
            string valueTime = Helper.GetValue(PageObject_CreateCampaign.Create_Confirm_At_Time_Input()).Trim();
            DateTime convertedValue = Convert.ToDateTime(valueTime);
            if (convertedValue < newTime)
                Assert.Fail("System is not displaying future time slot");
        }

        public static void VerifyStartOnCurrentDate()
        {
            DateTime now = DateTime.Now;
            string date = now.ToString().Split(' ')[0];
            string valueStartOn = Helper.GetValue(PageObject_CreateCampaign.Create_Confirm_Start_On_Input()).Trim();
            string actDate = Convert.ToDateTime(valueStartOn).ToString().Split(' ')[0];
            Assert.AreEqual(date, actDate, $"System is not displaying Today's date: {date}");
        }

        public static void ClickOnSendDDMList()
        {
            WaitForAjaxControls(50);
            Helper.ElementWait(PageObject_CreateCampaign.Create_Confirm_Send_Input_DropDown(), 10);
            ElementClick(PageObject_CreateCampaign.Create_Confirm_Send_Input_DropDown());
        }

        public static void VerifySendDDMDropDownList(string listValues)
        {
            WaitForAjaxControls(50);
            int count = 0;
            IList<IWebElement> sendDDMList = null;
            IList<string> actList = new List<string>();
            IList<string> expList = new List<string>();
            for (int i = 0; i < 15; i++)
                sendDDMList = PageObject_CreateCampaign.Create_Confirm_Send_List();
            foreach (var item in sendDDMList)
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
                    count = count + 1;
                else
                    Logger.WriteInfoMessage($"Actual list is not contains options: {expList[i]}");
            }
            Assert.IsTrue(expList.Count == count, $"List is not displaying expected options in it {expList}");

        }

        public static void SelectOptionFromSendDDM(string option)
        {
            IList<IWebElement> sendDDMList = null;

            //Click on the drop down
            WaitForAjaxControls(120);
            Helper.ElementWait(PageObject_CreateCampaign.Create_Confirm_Send_Input_DropDown(), 10);
            ElementClick(PageObject_CreateCampaign.Create_Confirm_Send_Input_DropDown());
            //select option from the drop down
            WaitForAjaxControls(120);
            Helper.ElementEnterText(PageObject_CreateCampaign.Create_Confirm_Send_Input_ToEnter(), option);
            for (int i = 0; i < 15; i++)
                sendDDMList = PageObject_CreateCampaign.Create_Confirm_Send_List();
            foreach (var item in sendDDMList)
            {
                if (item.GetAttribute("innerHTML").Trim().Equals(option.Trim())) ;
                {
                    Helper.ElementClickUsingJavascript(item);
                    break;
                }
            }
            WaitForAjaxControls(120);
            Helper.ElementWait(PageObject_CreateCampaign.Create_Confirm_Send_Input(), 3);
            string selectedValue = Helper.GetValue(PageObject_CreateCampaign.Create_Confirm_Send_Input()).Trim();

            Assert.AreEqual(selectedValue.Trim(), option.Trim(), $"System is not displaying selectd value: {option}");
        }

        public static string SelectDatesInOnFieldOfNextDay()
        {
            IList<IWebElement> dates = null;
            string selectedDate = null;
            WaitForAjaxControls(30);
            Helper.ScrollToElement(PageObject_CreateCampaign.Create_Confirm_Schedule_Text());
            ElementClick(PageObject_CreateCampaign.Create_Confirm_On_Picker_Icon());
            for (int i = 0; i < 7; i++)
            {
                dates = PageObject_CreateCampaign.Create_Confirm_FutureDates();
            }
            dates[0].Click();
            selectedDate = GetElementValue(PageObject_CreateCampaign.Create_Confirm_On_Input()).Trim();
            return selectedDate;
        }

        public static string SelectTimeInAtFieldOfNextslot()
        {
            WaitForAjaxControls(50);
            string selectedTime = null;
            IList<IWebElement> time = null;
            WaitForAjaxControls(30);
            ElementClick(PageObject_CreateCampaign.Create_Confirm_At_Time_Icon());
            for (int i = 0; i < 7; i++)
            {
                time = PageObject_CreateCampaign.Create_Confirm_At_Time_List();
            }
            time[0].Click();
            WaitForAjaxControls(50);
            selectedTime = GetElementValue(PageObject_CreateCampaign.Create_Confirm_At_Time_Input()).Trim();
            ElementClick(PageObject_CreateCampaign.Create_Confirm_Schedule_Text());
            return selectedTime;
        }

        public static string SelectZoneInTimeZone(string zone)
        {
            try
            {
                string selectedZone = null;
                IList<IWebElement> zones = null;
                WaitForAjaxControls(30);
                ElementClick(PageObject_CreateCampaign.Create_Confirm_Time_Zone_Down_Arrow());
                ElementEnterText(PageObject_CreateCampaign.Create_Confirm_Time_Zone_Search_Input(), zone);
                for (int i = 0; i < 7; i++)
                {
                    zones = PageObject_CreateCampaign.Create_Confirm_Time_Zone_Options_List();
                }
                zones[0].Click();
                selectedZone = GetElementValue(PageObject_CreateCampaign.Create_Confirm_Time_Zone_Input()).Trim();
                ElementClick(PageObject_CreateCampaign.Create_Confirm_Schedule_Text());
                return selectedZone;
            }
            catch (Exception e)
            {
                Logger.WriteErrorMessage("Unable to select time zone", e);
                throw e;
            }
        }

        public static void ClickOnFinishButton()
        {
            ScrollToElement(PageObject_CreateCampaign.Create_Wizard_Confirm_Finish());
            ElementClick(PageObject_CreateCampaign.Create_Wizard_Confirm_Finish());
            WaitForAjaxControls(50);
        }

        public static void VerifySuccessTextOnConfirmPage()
        {
            WaitForAjaxControls(50);
            Assert.IsTrue("Success".Equals(GetText(PageObject_CreateCampaign.Create_Success_Text()).Trim()), "Success is not visible on the page");
        }

        public static void VerifyVisibilityOfManageCampaignsAndEditScheduleButtons()
        {
            WaitForAjaxControls(50);
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateCampaign.Create_Success_Manage_Campaigns_Button()), "Manage Campaigns button is not visible on the page");
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateCampaign.Create_Success_Edit_Schedule_Link()), "Manage Campaigns button is not visible on the page");
        }

        public static void VerifySubTitleOnPage(string campaignName, string sendDDM, string selectedDate, string selectedTime, string selectedZone)
        {
            selectedZone = selectedZone.Split('(')[0].Trim();
            selectedTime= selectedTime.Split(' ')[0].Trim();
            if (sendDDM.Equals("X-Minute"))
                sendDDM = "minute";
            if (sendDDM.Equals("Weekly"))
                sendDDM = "week";
            WaitForAjaxControls(50);
            string subTitle = GetText(PageObject_CreateCampaign.Create_Success_Message()).ToLower();
            string convertedDate = Convert.ToDateTime(selectedDate).ToString("MMM dd, yyyy");
            if (subTitle.Contains(campaignName.ToLower().Trim()) && subTitle.Contains(sendDDM.ToLower().Trim()) && subTitle.Contains(convertedDate.ToLower().Trim()) && subTitle.Contains(selectedTime.ToLower().Trim()) && subTitle.Contains(selectedZone.ToLower().Trim()))
                Logger.WriteInfoMessage("Subtitle contains all the selected information");
            else
                Assert.Fail("Subtitle is not contains all the selected information");
        }

        public static void VerifyFrequencyData(string dbFrequency, string sendDDM, string selectedDate, string selectedTime, string selectedZone)
        {

            string subTitle = dbFrequency.ToLower();
            string convertedDate = Convert.ToDateTime(selectedDate).ToString("yyyy-MM-dd");
            if (subTitle.Contains(sendDDM.ToLower().Trim()) && subTitle.Contains(convertedDate.ToLower().Trim()) && subTitle.Contains(selectedTime.ToLower().Trim()) && subTitle.Contains(selectedZone.ToLower().Trim()))
                Logger.WriteInfoMessage("Selected data is stored in the DB frequency column");
            else
                Assert.Fail("Selected data is not stored in the DB frequency column");
        }

        public static void VerifyFrequencyData(string dbFrequency, string sendDDM, string selectedDate, string selectedUntil, string selectedTime, string selectedZone, string everyValue)
        {
            if (String.IsNullOrEmpty(everyValue))
                everyValue = "";
            if (sendDDM.Equals("Daily"))
                sendDDM = "Day";
            else if (sendDDM.Equals("Monthly"))
                sendDDM = "Month";
            else if (sendDDM.Equals("X-Minute"))
                sendDDM = "Minute";
            else if (sendDDM.Equals("Hourly"))
                sendDDM = "Hour";
            else if (sendDDM.Equals("Weekly"))
                sendDDM = "week";
            string subTitle = dbFrequency.ToLower().Trim();
            string convertedDate = Convert.ToDateTime(selectedDate).ToString("yyyy-MM-dd");
            string convertedUntilDate = Convert.ToDateTime(selectedUntil).ToString("yyyy-MM-dd");
            if (subTitle.Contains(sendDDM.ToLower().Trim()) && subTitle.Contains(convertedDate.ToLower().Trim()) && subTitle.Contains(convertedUntilDate.ToLower().Trim()) && subTitle.Contains(selectedTime.ToLower().Trim()) && subTitle.Contains(selectedZone.ToLower().Trim()) && subTitle.Contains(everyValue.ToLower().Trim()))
                Logger.WriteInfoMessage("Selected data is stored in the DB frequency column");
            else
                Assert.Fail("Selected data is not stored in the DB frequency column");
        }

        public static void VerifyFrequencyData(string dbFrequency, string sendDDM, string selectedDate, string selectedUntil, string selectedTime, string selectedTime2, string selectedZone, string everyValue)
        {
            if (sendDDM.Equals("X-Minute"))
                sendDDM = "Minute";
            else if (sendDDM.Equals("Hourly"))
                sendDDM = "Hour";

            string subTitle = dbFrequency.ToLower().Trim();
            string convertedDate = Convert.ToDateTime(selectedDate).ToString("yyyy-MM-dd");
            string convertedUntilDate = Convert.ToDateTime(selectedUntil).ToString("yyyy-MM-dd");
            if (subTitle.Contains(sendDDM.ToLower().Trim()) && subTitle.Contains(convertedDate.ToLower().Trim()) && subTitle.Contains(convertedUntilDate.ToLower().Trim()) && subTitle.Contains(selectedTime.ToLower().Trim()) && subTitle.Contains(selectedTime2.ToLower().Trim()) && subTitle.Contains(selectedZone.ToLower().Trim()) && subTitle.Contains(everyValue.ToLower().Trim()))
                Logger.WriteInfoMessage("Selected data is stored in the DB frequency column");
            else
                Assert.Fail("Selected data is not stored in the DB frequency column");
        }

        public static void VerifyFrequencyData(string dbFrequency, string sendDDM, string selectedDate, string selectedUntil, string selectedTime, string selectedTime2, string selectedZone, string everyValue, string weekDays)
        {
            if (sendDDM.Equals("Weekly"))
                sendDDM = "week";
            if (String.IsNullOrEmpty(selectedTime2))
                selectedTime2 = "";
            if (String.IsNullOrEmpty(everyValue))
                everyValue = "";
            var options = weekDays.ToLower().Split(',');
            string[] days = new string[options.Length];
            for (int i = 0; i < options.Length; i++)
            {
                if (options[i].Trim().Equals("sun") || options[i].Trim().Equals("mon") || options[i].Trim().Equals("tue") || options[i].Trim().Equals("wed") || options[i].Trim().Equals("thur") || options[i].Trim().Equals("fri") || options[i].Trim().Equals("sat"))
                    days[i] = i.ToString();
            }
            string subTitle = dbFrequency.ToLower().Trim();
            string convertedDate = Convert.ToDateTime(selectedDate).ToString("yyyy-MM-dd");
            string convertedUntilDate = Convert.ToDateTime(selectedUntil).ToString("yyyy-MM-dd");
            if (subTitle.Contains(sendDDM.ToLower().Trim()) && subTitle.Contains(convertedDate.ToLower().Trim()) && subTitle.Contains(convertedUntilDate.ToLower().Trim()) && subTitle.Contains(selectedTime.ToLower().Trim()) && subTitle.Contains(selectedTime2.ToLower().Trim()) && subTitle.Contains(selectedZone.ToLower().Trim()) && subTitle.Contains(everyValue.ToLower().Trim()) && subTitle.Contains(string.Join(",", days)))
                Logger.WriteInfoMessage("Selected data is stored in the DB frequency column");
            else
                Assert.Fail("Selected data is not stored in the DB frequency column");
        }


        public static string SelectDateInDayFromFieldOfNextDay()
        {
            IList<IWebElement> dates = null;
            string selectedDate = null;
            WaitForAjaxControls(30);
            Helper.ScrollToElement(PageObject_CreateCampaign.Create_Confirm_Schedule_Text());
            ElementClick(PageObject_CreateCampaign.Create_Confirm_Days_From_Picker_Icon());
            for (int i = 0; i < 7; i++)
            {
                dates = PageObject_CreateCampaign.Create_Confirm_FutureDates();
            }
            dates[0].Click();
            selectedDate = GetElementValue(PageObject_CreateCampaign.Create_Confirm_Days_From_Input()).Trim();
            return selectedDate;
        }

        //For the current month the index will be 0 and for next month it will 1 next to next it will 2 like this
        public static string SelectDateIUntilFieldOfNextDay(int index)
        {
            try
            {
                IList<IWebElement> dates = null;
                string selectedDate = null;
                WaitForAjaxControls(30);
                Helper.ScrollToElement(PageObject_CreateCampaign.Create_Confirm_Schedule_Text());
                ElementClick(PageObject_CreateCampaign.Create_Confirm_Until_Picker_Icon());
                if (index > 0)
                {
                    for (int j = 0; j < index; j++)
                    {
                        ElementClick(PageObject_CreateCampaign.Create_Confirm_Calendar_Next());
                    }
                }
                for (int i = 0; i < 7; i++)
                {
                    dates = PageObject_CreateCampaign.Create_Confirm_FutureDates();
                }
                dates[dates.Count - 1].Click();
                selectedDate = GetElementValue(PageObject_CreateCampaign.Create_Confirm_Until_Input()).Trim();
                ElementClick(PageObject_CreateCampaign.Create_Confirm_Schedule_Text());
                return selectedDate;
            }
            catch (Exception e)
            {
                Logger.WriteErrorMessage("Unable to select untill date", e);
                throw e;
            }
        }

        public static string SelectCountOfEvery(string eveyValue)
        {
            //eveyValue should be 30 or less than it
            IList<IWebElement> every = null;
            string selectedEvery = null;
            WaitForAjaxControls(30);
            ElementClick(PageObject_CreateCampaign.Create_Confirm_Every_Arrow());
            ElementEnterText(PageObject_CreateCampaign.Create_Confirm_Every_Search_Input(), eveyValue);
            for (int i = 0; i < 7; i++)
            {
                every = PageObject_CreateCampaign.Create_Confirm_Every_List();
            }
            every[0].Click();
            selectedEvery = GetElementValue(PageObject_CreateCampaign.Create_Confirm_Every_Input()).Trim();
            return selectedEvery;
        }

        public static void VerifyUntillDateGreateThanOtherDate(string otherDate, string untilldate)
        {
            DateTime convertedOtherDate = Convert.ToDateTime(otherDate);
            DateTime convertedUntillDate = Convert.ToDateTime(untilldate);
            if (convertedUntillDate > convertedOtherDate)
                Logger.WriteInfoMessage($"{untilldate}  greater than ");
            else
                Assert.Fail($"{untilldate} is not greater than {otherDate}");

        }

        public static void ClickOnEditSchedule()
        {
            ElementClick(PageObject_CreateCampaign.Create_Success_Edit_Schedule_Link());
            ElementWait(PageObject_CreateCampaign.Create_Confirm_Schedule_Text(), 5);
            WaitForAjaxControls(50);
        }

        public static string SelectDateInMonthsFromFieldOfNextDay()
        {
            IList<IWebElement> dates = null;
            string selectedDate = null;
            WaitForAjaxControls(30);
            Helper.ScrollToElement(PageObject_CreateCampaign.Create_Confirm_Schedule_Text());
            ElementClick(PageObject_CreateCampaign.Create_Confirm_Months_From_Picker_Icon());
            for (int i = 0; i < 7; i++)
            {
                dates = PageObject_CreateCampaign.Create_Confirm_FutureDates();
            }
            dates[0].Click();
            selectedDate = GetElementValue(PageObject_CreateCampaign.Create_Confirm_Months_From_Input()).Trim();
            ElementClick(PageObject_CreateCampaign.Create_Confirm_Schedule_Text());
            return selectedDate;
        }

        public static string SelectCountOfEveryForMonth(string eveyValue)
        {
            //eveyValue should be 30 or less than it
            IList<IWebElement> every = null;
            string selectedEvery = null;
            WaitForAjaxControls(30);
            ElementClick(PageObject_CreateCampaign.Create_Confirm_Every_Monthly_Arrow());
            ElementEnterText(PageObject_CreateCampaign.Create_Confirm_Every_Search_Month_Input(), eveyValue);
            for (int i = 0; i < 7; i++)
            {
                every = PageObject_CreateCampaign.Create_Confirm_Every_Monthly_List();
            }
            every[0].Click();
            selectedEvery = GetElementValue(PageObject_CreateCampaign.Create_Confirm_Every_Month_Input()).Trim();
            ElementClick(PageObject_CreateCampaign.Create_Confirm_Schedule_Text());
            return selectedEvery;
        }

        public static string SelectDateInMinutesFromFieldOfNextDay()
        {
            IList<IWebElement> dates = null;
            string selectedDate = null;
            WaitForAjaxControls(30);
            Helper.ScrollToElement(PageObject_CreateCampaign.Create_Confirm_Schedule_Text());
            ElementClick(PageObject_CreateCampaign.Create_Confirm_Minutes_From_Picker_Icon());
            for (int i = 0; i < 7; i++)
            {
                dates = PageObject_CreateCampaign.Create_Confirm_FutureDates();
            }
            dates[0].Click();
            selectedDate = GetElementValue(PageObject_CreateCampaign.Create_Confirm_Minutes_From_Input()).Trim();
            return selectedDate;
        }

        public static string SelectTimeInAtFieldOfNextslotForMinutes()
        {
            try
            {
                WaitForAjaxControls(50);
                string selectedTime = null;
                IList<IWebElement> time = null;
                WaitForAjaxControls(30);
                ElementClick(PageObject_CreateCampaign.Create_Confirm_At_Time_Icon_List()[0]);
                for (int i = 0; i < 7; i++)
                {
                    time = PageObject_CreateCampaign.Create_Confirm_At_Time_List();
                }
                Helper.ElementClickUsingJavascript(time[time.Count - 1]);
                WaitForAjaxControls(50);
                selectedTime = GetElementValue(PageObject_CreateCampaign.Create_Confirm_At_Time_Input_Lists()[0]).Trim();
                return selectedTime;
            }
            catch (Exception e)
            {
                Logger.WriteErrorMessage("Unable to select time", e);
                throw e;
            }
        }
        public static string SelectTimeInAtFieldOfNextslotForUntil()
        {
            try
            {
                WaitForAjaxControls(50);
                string selectedTime = null;
                IList<IWebElement> time = null;
                WaitForAjaxControls(30);
                ElementClick(PageObject_CreateCampaign.Create_Confirm_At_Time_Icon_List()[1]);
                for (int i = 0; i < 7; i++)
                {
                    time = PageObject_CreateCampaign.Create_Confirm_At_Time_List();
                }
                Helper.ElementClickUsingJavascript(time[time.Count - 1]);
                WaitForAjaxControls(50);
                selectedTime = GetElementValue(PageObject_CreateCampaign.Create_Confirm_At_Time_Input_Lists()[1]).Trim();
                return selectedTime;
            }
            catch (Exception e)
            {
                Logger.WriteErrorMessage("Unable to select until time", e);
                throw e;
            }
        }

        public static string SelectCountOfEveryForMinutes(string eveyValue)
        {
            try
            {
                //eveyValue should be 30 or less than it
                IList<IWebElement> every = null;
                string selectedEvery = null;
                WaitForAjaxControls(30);
                ElementClick(PageObject_CreateCampaign.Create_Confirm_Every_Minute_Arrow());
                ElementEnterText(PageObject_CreateCampaign.Create_Confirm_Every_Minute_Search_Input(), eveyValue);
                for (int i = 0; i < 7; i++)
                {
                    every = PageObject_CreateCampaign.Create_Confirm_Every_Minute_List();
                }
                every[0].Click();
                selectedEvery = GetElementValue(PageObject_CreateCampaign.Create_Confirm_Every_Minute_Input()).Trim();
                return selectedEvery;
            }
            catch (Exception e)
            {
                Logger.WriteErrorMessage("Unable to select Every value", e);
                throw e;
            }
        }

        public static void SelectCardByProvidingIndex(int index)
        {
            try
            {
                // Click on first card and verify user lands on the settings page
                IList<IWebElement> cards = Driver.FindElements(By.XPath(ObjectRepository.Campaign_Button_ApplicationCards));
                ScrollToElement(cards[index]);
                cards[index].Click();
                WaitForAjaxControls(50);
                IWebElement settings = PageObject_CreateCampaign.Create_Wizard_Settings();
                string color = settings.GetCssValue("border-color");
                Assert.AreEqual("rgb(39, 110, 205)", color, "Clicking on card, user is not brought to first step of campaign creation process");
                Logger.WriteDebugMessage("Clicking on card, user is brought to first step of campaign creation process");
            }
            catch (System.IndexOutOfRangeException e)
            {
                Logger.WriteErrorMessage("System is not displaying the cards", e);
                throw e;
            }
        }
        /// <summary>
        ///currentOrNextDay=> 0= for the current day and 1 for next dat
        /// </summary>
        /// <param name="currentOrNextDay"></param>
        /// <returns></returns>
        public static string SelectStartOnDateCurrentOrNext(int currentOrNextDay)
        {
            IList<IWebElement> dates = null;
            string selectedDate = null;
            WaitForAjaxControls(30);
            Helper.ScrollToElement(PageObject_CreateCampaign.Create_Confirm_Schedule_Text());
            ElementClick(PageObject_CreateCampaign.Create_Confirm_Start_On_Picker_Icon());
            if (currentOrNextDay == 0)
            {
                ElementClick(PageObject_CreateCampaign.Create_Confirm_Todays_Dates());
            }
            else
            {
                for (int i = 0; i < 7; i++)
                {
                    dates = PageObject_CreateCampaign.Create_Confirm_FutureDates();
                }
                dates[0].Click();
            }
            selectedDate = GetElementValue(PageObject_CreateCampaign.Create_Confirm_Start_On_Input()).Trim();
            return selectedDate;
        }

        public static string SelectDateIUntilFieldAsCurrentDate()
        {
            string selectedDate = null;
            WaitForAjaxControls(30);
            Helper.ScrollToElement(PageObject_CreateCampaign.Create_Confirm_Schedule_Text());
            ElementClick(PageObject_CreateCampaign.Create_Confirm_Until_Picker_Icon());
            ElementClick(PageObject_CreateCampaign.Create_Confirm_Todays_Dates());
            selectedDate = GetElementValue(PageObject_CreateCampaign.Create_Confirm_Until_Input()).Trim();
            return selectedDate;
        }

        public static string SelectDateInHoursFromFieldOfNextDay()
        {
            try
            {
                IList<IWebElement> dates = null;
                string selectedDate = null;
                WaitForAjaxControls(30);
                Helper.ScrollToElement(PageObject_CreateCampaign.Create_Confirm_Schedule_Text());
                ElementClick(PageObject_CreateCampaign.Create_Confirm_Hours_From_Picker_Icon());
                for (int i = 0; i < 7; i++)
                {
                    dates = PageObject_CreateCampaign.Create_Confirm_FutureDates();
                }
                dates[0].Click();
                selectedDate = GetElementValue(PageObject_CreateCampaign.Create_Confirm_Hours_From_Input()).Trim();
                return selectedDate;
            }
            catch (Exception e)
            {
                Logger.WriteErrorMessage("Unable to select date", e);
                throw e;
            }
        }

        public static string SelectCountOfEveryForHours(string eveyValue)
        {
            try
            {
                //eveyValue should be 30 or less than it
                IList<IWebElement> every = null;
                string selectedEvery = null;
                WaitForAjaxControls(30);
                ElementClick(PageObject_CreateCampaign.Create_Confirm_Every_Hours_Arrow());
                ElementEnterText(PageObject_CreateCampaign.Create_Confirm_Every_Hours_Search_Input(), eveyValue);
                for (int i = 0; i < 7; i++)
                {
                    every = PageObject_CreateCampaign.Create_Confirm_Every_Hours_List();
                }
                every[0].Click();
                selectedEvery = GetElementValue(PageObject_CreateCampaign.Create_Confirm_Every_Hours_Input()).Trim();
                return selectedEvery;
            }
            catch (Exception e)
            {
                Logger.WriteErrorMessage("Unable to select Every value", e);
                throw e;
            }
        }

        public static void VerifyEveryDropDownOptionWhenHourSelected(string hours)
        {
            try
            {
                IList<IWebElement> every = null;
                IList<string> actList = new List<string>();
                IList<string> expList = new List<string>();
                int count = 0;
                WaitForAjaxControls(30);
                ElementClick(PageObject_CreateCampaign.Create_Confirm_Every_Hours_Arrow());
                for (int i = 0; i < 7; i++)
                {
                    every = PageObject_CreateCampaign.Create_Confirm_Every_Hours_List();
                }
                foreach (var item in every)
                {
                    actList.Add(GetText(item));
                }
                var options = hours.Split(',');
                foreach (var item in options)
                {
                    expList.Add(item.Trim());
                }
                for (int i = 0; i < expList.Count; i++)
                {
                    if (actList.Contains(expList[i]))
                        count = count + 1;
                    else
                        Logger.WriteInfoMessage($"Actual list is not contains options: {expList[i]}");
                }
                Assert.IsTrue(expList.Count == count, $"List is not displaying expected hours options in it {expList}");
            }
            catch (Exception e)
            {
                Logger.WriteErrorMessage("Unable to select get Every list value", e);
                throw e;
            }
        }

        public static void VerifyFullTextTruncatedAudienceDesignCard()
        {
            string toolTip;
            int columnIndex = 0, count = 0, pages = 0;
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> cellData = null;
            IList<IWebElement> paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers();
            int loopCount = Convert.ToInt32(paggination[paggination.Count - 1].Text);
            for (int z = 0; z < loopCount; z++)
            {
                WaitForAjaxControls(120);
                for (int s = 0; s < 30; s++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                IList<IWebElement> columns = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("AUDIENCE"))
                        break;
                }

                for (int i = columnIndex - 1; i < cellData.Count; i++)
                {
                    Helper.ScrollToElement(cellData[i]);
                    Helper.ElementHover(cellData[i]);
                    if (Helper.IsElementDisplayed(PageObject_CreateCampaign.Create_Audience_Card_ToolTip_Text()))
                        Logger.WriteDebugMessage("Tooltip Displayed");
                    {
                        count = count + 1;
                        toolTip = GetText(PageObject_CreateCampaign.Create_Audience_Card_ToolTip_Text());
                        Logger.WriteInfoMessage($"This is ToolTip text: {toolTip}");
                        break;
                    }
                    for (int b = 0; b < 20; b++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                    i = i + 6;
                }

                if (count >= 1)
                    break;
                pages = pages + 1;
                if (pages >= 1)
                    break;
                for (int k = 0; k < 10; k++) { paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers(); }
                if (paggination[paggination.Count - 1].Text.Length >= 2)
                {
                    Helper.ScrollToElement(PageObject_CreateCampaign.Create_Audience_ListView_Next_Page_Button());
                    PageObject_CreateCampaign.Create_Audience_ListView_Next_Page_Button().Click();
                    Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                    columnIndex = 0;
                    WaitForAjaxControls(90);
                }
                else
                {
                    Helper.ScrollToElement(paggination[z]);
                    paggination[z].Click();
                    Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
                    columnIndex = 0;
                    WaitForAjaxControls(90);
                }
            }
            Assert.IsTrue(count >= 1, "System is not displaying complete text after mouse hover the truncated design name");
        }
        public static string SelectDateInWeeklyFromFieldOfNextDay()
        {
            IList<IWebElement> dates = null;
            string selectedDate = null;
            WaitForAjaxControls(30);
            Helper.ScrollToElement(PageObject_CreateCampaign.Create_Confirm_Schedule_Text());
            ElementClick(PageObject_CreateCampaign.Create_Confirm_Weekly_From_Picker_Icon());
            for (int i = 0; i < 7; i++)
            {
                dates = PageObject_CreateCampaign.Create_Confirm_FutureDates();
            }
            dates[0].Click();
            selectedDate = GetElementValue(PageObject_CreateCampaign.Create_Confirm_Weekly_From_Input()).Trim();
            return selectedDate;
        }
        /// <summary>
        /// This method can apply multiple days as well where days can be send using ','
        /// </summary>
        /// <param name="dayValue"></param>
        /// <returns></returns>
        public static string SelectedADayFromWeek(string dayValue)
        {
            var options = dayValue.Split(',');
            foreach (var item in options)
            {
                SelectedDays(item);
            }
            return dayValue;
        }
        public static string SelectedDays(string dayValues)
        {
            IList<IWebElement> selectedDay = PageObject_CreateCampaign.Create_Confirm_Weekly_Day();
            string toVerifyDay = null;
            dayValues = dayValues.ToLower();
            foreach (var item in selectedDay)
            {
                toVerifyDay = GetText(item).Trim().ToLower();
                if (toVerifyDay.Contains(dayValues.Trim()))
                {
                    item.Click();
                    string selectedDayConfirm = item.GetAttribute("class");
                    if (selectedDayConfirm.Contains("active"))
                    {
                        Console.WriteLine("Options in the platform", toVerifyDay);
                        break;
                    }
                }
            }
            return dayValues;
        }
        public static string SelectTimeInAtFieldOfNextslotForWeekly()
        {
            WaitForAjaxControls(50);
            string selectedTime = null;
            IList<IWebElement> time = null;
            WaitForAjaxControls(30);
            ElementClick(PageObject_CreateCampaign.Create_Confirm_At_Time_Icon_List()[0]);
            for (int i = 0; i < 7; i++)
            {
                time = PageObject_CreateCampaign.Create_Confirm_At_Time_List();
            }
            time[10].Click();
            WaitForAjaxControls(50);
            selectedTime = GetElementValue(PageObject_CreateCampaign.Create_Confirm_At_Time_Input_Lists()[0]).Trim();
            return selectedTime;
        }
        //given set of tabs are available or not on the platform
        public static void VerifyTabsAreAvailabeOrNot(string tabsRequired)
        {

            string headingText = null;
            int tabsCount = 0;
            var option = tabsRequired.Split(',');
            // Click on first card and verify user lands on the settings page
            IList<IWebElement> tabsAvailable = Driver.FindElements(By.XPath(ObjectRepository.Campaign_Create_Confirm_TwoButtons));
            foreach (var item in tabsAvailable)
            {
                headingText = GetText(item).Trim();
                for (int i = 0; i < option.Length; i++)
                {
                    if (headingText.Contains(option[i].Trim()))
                    {
                        Console.WriteLine("Options in the platform", option[i]);
                        tabsCount++;
                        break;
                    }
                }
            }
            Assert.IsTrue(option.Length == tabsCount, "All tab are not dipslaying on the page");
        }

        public static void Campaign_Click_Filter()
        {
            ScrollToElement(PageObject_CreateCampaign.Campaign_Click_Filter());
            ElementClick(PageObject_CreateCampaign.Campaign_Click_Filter());
        }

        public static void Campaign_Click_Filter_Name_ddL()
        {
            ElementClick(PageObject_CreateCampaign.Campaign_Click_Filter_Name_ddL());
            WaitForAjaxControls(50);
        }

        public static void Campaign_Click_Filter_Name_ddL_Value()
        {
            ElementClick(PageObject_CreateCampaign.Campaign_Click_Filter_Name_ddL_Value());
        }

        public static void Campaign_Click_Filter_Name_Enter_CampaignName(string value)
        {
            ElementEnterText(PageObject_CreateCampaign.Campaign_Click_Filter_Name_Enter_CampaignName(), value);
        }

        public static void Campaign_Click_Filter_ID_ddL()
        {
            ElementClick(PageObject_CreateCampaign.Campaign_Click_Filter_ID_ddL());
        }

        public static void Campaign_Filter_Enter_ID(string value)
        {
            ElementEnterText(PageObject_CreateCampaign.Campaign_Filter_Enter_ID(), value);
        }

        public static void Campaign_Click_Filter_Audience_DDl()
        {
            ElementClick(PageObject_CreateCampaign.Campaign_Click_Filter_Audience_DDl());
        }

        public static void Campaign_Click_Filter_Enter_Audience(string value)
        {
            ElementEnterText(PageObject_CreateCampaign.Campaign_Click_Filter_Enter_Audience(), value);
        }

        public static void Campaign_Click_Filter_Apply_Button()
        {
            Logger.WriteDebugMessage("Selected filter are");
            ElementClick(PageObject_CreateCampaign.Campaign_Click_Filter_Apply_Button());
        }

        public static void Campaign_Click_Approval_SendRequest_Button()
        {
            ElementClick(PageObject_CreateCampaign.Campaign_Click_Approval_SendRequest_Button());
        }

        public static void Campaign_Click_Approval_SendRequest_Approve_Button()
        {
            ElementClick(PageObject_CreateCampaign.Campaign_Click_Approval_SendRequest_Approve_Button());
        }

        public static void Campaign_Click_Approval_SendRequest_Reject_Button()
        {
            ElementClick(PageObject_CreateCampaign.Campaign_Click_Approval_SendRequest_Reject_Button());
        }
        public static void Campaign_Click_Approval_Click_SelfApprove_Button()
        {
            ElementClick(PageObject_CreateCampaign.Campaign_Click_Approval_Click_SelfApprove_Button());
        }
        public static void Click_design_SelfApprove_Send_DDL()
        {
            ElementClick(PageObject_CreateCampaign.Click_design_SelfApprove_Send_DDL());
        }
        public static void Click_design_SelfApprove_TimeZone_DDL()
        {
            ElementClick(PageObject_CreateCampaign.Click_design_SelfApprove_TimeZone_DDL());
        }
        public static void Click_design_SelfApprove_On_Value()
        {
            ElementClick(PageObject_CreateCampaign.Click_design_SelfApprove_On_Value());
        }
        public static void Click_design_SelfApprove_Enter_Send_Value(string value)
        {
            ElementEnterText(PageObject_CreateCampaign.Click_design_SelfApprove_Enter_Send_Value(), value);
        }
        public static void RejectApproval__popUp_Reject_button()
        {
            ElementClick(PageObject_CreateCampaign.RejectApproval__popUp_Reject_button());
        }
        public static void RejectApproval__popUp_Enter_text(string value)
        {
            ElementEnterText(PageObject_CreateCampaign.RejectApproval__popUp_Enter_text(), value);
        }

        public static void Verify_Apply_Filter_for_Name()
        {
            string Name;

            //Verify Added Campaign details
            Name = ManageCampaign.GetText(PageObject_ManageCampaign.Hover_ListView_CampaignName());

            //Click on Filter.
            CreateCampaign.Campaign_Click_Filter();
            Logger.WriteDebugMessage("Filter Pop-up Modal should get opened.");

            //Click on Name Filter Drop-Down and Select Equal ddm.
            AddDelay(10000);
            CreateCampaign.Campaign_Click_Filter_Name_ddL();
            string selectionValue = "Equal";
            IList<IWebElement> list = Helper.Driver.FindElements(By.XPath("//div[@class='e-ddl e-popup e-lib e-control e-popup-open']/descendant::li"));
            foreach (var item in list)
            {
                if (item.Text.Trim().Equals(selectionValue))
                {
                    item.Click();
                    break;
                }
            }

            //Enter Campaign Noted Down at the step 5.
            CreateCampaign.Campaign_Click_Filter_Name_Enter_CampaignName(Name);
            Logger.WriteDebugMessage("Enter Campaign Name as " + Name);

            //Click on Apply.
            CreateCampaign.Campaign_Click_Filter_Apply_Button();
            Logger.WriteDebugMessage("Campaign displayed as per the applied filter for Name");

        }

        public static void Verify_Apply_Filter_for_Audience()
        {
            string Audience;

            //Verify Added Campaign details
            Audience = ManageCampaign.GetText(PageObject_ManageCampaign.Hover_ListView_CampaignAudience());

            //Click on Filter.
            CreateCampaign.Campaign_Click_Filter();
            Logger.WriteDebugMessage("Filter Pop-up Modal should get opened.");

            //Click on Audience Filter Drop-Down and Select Equal ddm.
            AddDelay(10000);
            CreateCampaign.Campaign_Click_Filter_Audience_DDl();
            string selectionAudience = "Equal";
            IList<IWebElement> list = Helper.Driver.FindElements(By.XPath("//div[@class='e-ddl e-popup e-lib e-control e-popup-open']/descendant::li"));
            foreach (var item in list)
            {
                if (item.Text.Trim().Equals(selectionAudience))
                {
                    item.Click();
                    break;
                }
            }

            //Enter Audience Noted Down at the step 5.
            CreateCampaign.Campaign_Click_Filter_Enter_Audience(Audience);
            Logger.WriteDebugMessage("Enter Audience as " + Audience);

            //Click on Apply.
            CreateCampaign.Campaign_Click_Filter_Apply_Button();
            Logger.WriteDebugMessage("Campaign displayed as per the applied filter for Audience");
        }

        /// <summary>
        /// This method will verify 3x3 cards in the MarketingAutomation manage Campaign page
        /// </summary>
        public static void Verify3x3CardsAvailableOrNot()
        {
            int count = 0;
            IList<IWebElement> cards = null;
            for (int i = 0; i < 7; i++){cards = PageObject_CreateCampaign.GetNumberOfCardsAvailableInPage(); }
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
        public static void VerifySubTitleOnPage(string campaignName, string sendDDM, string selectedZone)
        {
            selectedZone = selectedZone.Split('(')[0].Trim();
            if (sendDDM.Equals("Weekly"))
                sendDDM = "week";
            WaitForAjaxControls(50);
            string subTitle = GetText(PageObject_CreateCampaign.Create_Success_Message()).ToLower();
            if (subTitle.Contains(campaignName.ToLower().Trim()) && subTitle.Contains(sendDDM.ToLower().Trim()) && subTitle.Contains(selectedZone.ToLower().Trim()))
                Logger.WriteInfoMessage("Subtitle contains all the selected information");
            else
                Assert.Fail("Subtitle is not contains all the selected information");
        }
        public static void Verify_TopIcon()
        {

            IWebElement iconTop = PageObject_CreateCampaign.Confirm_AtTopIcon();
            bool elementVerify = IsElementDisplayed(iconTop);
            Assert.IsTrue(elementVerify.Equals(true), "Initial icon is not at top right corner");
        }
        //To Verify minutes availablility in the list
        public static void VerifyOptionFromXMinuteDropdown(string allMinutes)
        {
            IList<IWebElement> every = null;
            IList<string> expList = new List<string>();
            IList<string> actList = new List<string>();
            int count = 0;
            WaitForAjaxControls(30);
            ElementClick(PageObject_CreateCampaign.Create_Confirm_Every_Minute_Arrow());
            WaitForAjaxControls(30);
            for (int i = 0; i < 7; i++)
            {
                every = PageObject_CreateCampaign.Create_Confirm_Every_Minute_List();
            }
            foreach (var item in every)
            {
                actList.Add(GetText(item));
            }
            var option = allMinutes.Split(',');
            foreach (var item in option)
            {
                expList.Add(item.Trim());
            }
            for (int i = 0; i < expList.Count; i++)
            {
                if (actList.Contains(expList[i]))
                    count = count + 1;
            }
            Assert.IsTrue(expList.Count == count, "Every list is not dipslaying the all minutes options");

        }

        public static void VerifyWizardStepsSettingsAudienceDesignAndConfirm()
        {
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateCampaign.Create_Wizard_Settings()), "Settings step is not displaying");
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateCampaign.Create_Wizard_Audience()), "Audience step is not displaying");
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateCampaign.Create_Wizard_Design()), "Design step is not displaying");
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateCampaign.Create_Wizard_Confirm()), "Confirm step is not displaying");
        }

        public static void ClickOnUserIconAndVerifyLogoutOption()
        {

            ElementClick(PageObject_CreateCampaign.Confirm_AtTopIcon());
            bool elementVerify = IsElementDisplayed(PageObject_CreateCampaign.Logout_Button());
            Assert.IsTrue(elementVerify.Equals(true), "Logout is not displaying after click on user icon");
        }

        public static void ClickOnLogout()
        {

            ElementClick(PageObject_CreateCampaign.Confirm_AtTopIcon());
            ElementClick(PageObject_CreateCampaign.Logout_Button());
        }

        public static IList<IWebElement> SelectListOfCardEllipses()
        {
            try
            {
                IList<IWebElement> ellipses = PageObject_CreateCampaign.Create_Campaign_Card_Ellipses_List();
                Logger.WriteDebugMessage("List of card ellipses found");
                return ellipses;
            }
            catch (Exception e)
            {
                Logger.WriteErrorMessage("Unable to get the list of card ellipses", e);
                throw e;
            }
        }

        public static IList<IWebElement> SelectListOfCardTitles()
        {
            try
            {
                IList<IWebElement> titles = PageObject_CreateCampaign.Create_Campaign_Card_Titles_List();
                Logger.WriteDebugMessage("List of card titles found");
                return titles;
            }
            catch (Exception e)
            {
                Logger.WriteErrorMessage("Unable to get the list of card titles", e);
                throw e;
            }

        }

        public static IList<IWebElement> SelectListOfCardIDs()
        {
            try
            {
                IList<IWebElement> ids = PageObject_CreateCampaign.Create_Campaign_Card_IDs_List();
                Logger.WriteDebugMessage("List of card ids found");
                return ids;
            }
            catch (Exception e)
            {
                Logger.WriteErrorMessage("Unable to get the list of card ids", e);
                throw e;
            }

        }

        public static IList<IWebElement> SelectListOfCardEllipseClones()
        {
            try
            {
                IList<IWebElement> clones = PageObject_CreateCampaign.Create_Campaign_Card_Ellipse_Clone_List();
                Logger.WriteDebugMessage("List of card ids found");
                return clones;
            }
            catch (Exception e)
            {
                Logger.WriteErrorMessage("Unable to get the list of card ids", e);
                throw e;
            }

        }

        public static string[] getTitleAndIdOfCampaignCardRandom()
        {
            IList<IWebElement> titles = SelectListOfCardTitles();
            IList<IWebElement> ids = SelectListOfCardIDs();
            string titleCampaignName = "";
            string campaignId = "";
            String[] campaignDetails = new String[2];
            int count = titles.Count;

            try
            {
                if (count > 0)
                {
                    Logger.WriteDebugMessage("Cards are displaying on Manage Campaign page");
                    // Generate random number
                    Random rnd = new Random();
                    int index = rnd.Next(0, titles.Count);
                    ScrollToElement(titles[index]);

                    titleCampaignName = GetText(titles[index]);
                    Logger.WriteDebugMessage("Captured tilte of card");
                    campaignDetails[0] = titleCampaignName;

                    campaignId = GetText(ids[index]);
                    Logger.WriteDebugMessage("Captured tilte of card");
                    campaignDetails[1] = campaignId;

                }
            }
            catch (Exception e)
            {
                Logger.WriteDebugMessage("Cards are not displaying on Manage Campaign page");
                throw e;
            }
            return campaignDetails;
        }

        public static void ClickOnCamapignCardEllipseClone(string campaignID)
        {
            IList<IWebElement> titles = SelectListOfCardTitles();
            IList<IWebElement> ellipses = SelectListOfCardEllipses();
            IList<IWebElement> clones = SelectListOfCardEllipseClones();
            IList<IWebElement> ids = SelectListOfCardIDs();
            int count = titles.Count;
            try
            {
                if (count > 0)
                {
                    Logger.WriteDebugMessage("Cards are displaying on Manage Campaign page");
                    for (int i = 0; i < count; i++)
                    {
                        if (ids[i].Text == campaignID)
                        {
                            ScrollToElement(titles[i]);
                            Logger.WriteDebugMessage("Title of card is displaying");
                            ElementClick(ellipses[i]);
                            Logger.WriteDebugMessage("Clicked on ellipse of card");
                            ElementClick(clones[i]);
                            Logger.WriteDebugMessage("Clicked on clone of card");
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Logger.WriteDebugMessage("Cards are not displaying on Manage Campaign page");
                throw e;
            }
        }

        public static String VerifySuffixAndPrepopulatedDataOnCampaignName(String titleCampaignName, String suffixClone)
        {
            string cloneCampaignName = GetValue(PageObject_CreateCampaign.Create_Campaign_Name());
            int index = cloneCampaignName.LastIndexOf('-');
            try
            {
                if (index != -1)
                {
                    String prepopulatedCampaignName = cloneCampaignName.Substring(0, index).Trim();
                    String suffixCloneCampaign = cloneCampaignName.Substring(index + 1).Trim();
                    Assert.AreEqual(titleCampaignName, prepopulatedCampaignName, "Campaign Name in Pre-populated data of Campaign Name field of Setting page is matching after clone");
                    Logger.WriteDebugMessage("Campaign Name is matching in Campaign Name field after clone");
                    Assert.AreEqual(suffixClone, suffixCloneCampaign, "Suffix in Pre-populated data of Campaign Name field of Setting page is matching after clone");
                    Logger.WriteDebugMessage("Suffix is matching in Campaign Name field after clone");
                }
                return cloneCampaignName;
            }
            catch (Exception e)
            {
                Logger.WriteDebugMessage("Index Not found for Clone campaign name");
                throw e;
            }
        }

        public static String getURLOfCurrentWindow()
        {
            String url = Driver.Url;
            return url;
        }
        public static void VerifyCampaignIDInUrl(string campaignID)
        {
            String url = getURLOfCurrentWindow();
            String campaignIdFromUrl = (url.Split('=')[1]).Trim();
            Assert.AreEqual(campaignID, campaignIdFromUrl, "Campaign Id in url is matching with the selected clone campaign id");
            Logger.WriteDebugMessage("Campaign Id is matching in url of Setting page");
        }

        public static void applyFilter(String filterName, String filterNameValue, String cloneCampaignName)
        {
            IList<IWebElement> listOfNames = null;
            IWebElement elementFilterName = null;
            IWebElement elementFilterSearchText = null;
            string itemToClick = null;

            Helper.ElementClick(PageObject_CreateCampaign.Create_Campaign_Filter());
            if (filterName == "Name")
            {
                elementFilterName = PageObject_CreateCampaign.Create_Campaign_Filter_Name();
                Helper.ElementClick(elementFilterName);
                listOfNames = PageObject_CreateCampaign.Create_Campaign_Filter_Name_Value_List();
                elementFilterSearchText = PageObject_CreateCampaign.Create_Campaign_Filter_Name_Search_Text();
                foreach (var item in listOfNames)
                {
                    itemToClick = GetText(item);
                    if (itemToClick.Equals(filterNameValue.Trim()))
                    {
                        item.Click();
                        break;
                   }

                }
                Helper.ElementEnterText(elementFilterSearchText, cloneCampaignName);
            }
            Helper.ScrollToElement(PageObject_CreateCampaign.Create_Campaign_Filter_Button_Apply());
            Helper.ElementClick(PageObject_CreateCampaign.Create_Campaign_Filter_Button_Apply());
        }

        public static void VerifyFilterCampaignName(String expectedValue, String actualValue)
        {
            Assert.AreEqual(expectedValue, actualValue, $"Expected value {expectedValue} is matching with Actual value {actualValue}");
            Logger.WriteInfoMessage($"Expected value {expectedValue} is matching with Actual value {actualValue}");
        }

      
        public static void Verify_Apply_Filter_for_ID()
        {
            string ID; //Verify Added Campaign details
            ID = ManageCampaign.GetText(PageObject_ManageCampaign.Campaign_ID()); //Click on Filter.
            CreateCampaign.Campaign_Click_Filter();
            Logger.WriteDebugMessage("Filter Pop-up Modal should get opened."); //Click on ID Filter Drop-Down and Select Equal ddm.
            CreateCampaign.Campaign_Click_Filter_ID_ddL();
            string selectionValueID = "Equal";
            IList<IWebElement> IDlist = Helper.Driver.FindElements(By.XPath("//div[@class='e-ddl e-popup e-lib e-control e-popup-open']/descendant::li"));
            foreach (var item in IDlist)
            {
                if (item.Text.Trim().Equals(selectionValueID))
                {
                    item.Click();
                    break;
                }
            } //Enter ID
            CreateCampaign.Campaign_Filter_Enter_ID(ID); //Click on Apply.
            CreateCampaign.Campaign_Click_Filter_Apply_Button();
            Logger.WriteDebugMessage("Campaign displayed as per the applied filter for ID");
        }

        public static void Campaign_Click_Clear()
        {
            ElementClick(PageObject_CreateCampaign.Campaign_Click_Filter_Clear_Button());
        }
        public static void VerifyFrequencyOnPageByElement(string expectedvalue)
        {
            string getFreq = GetElementValue(PageObject_CreateCampaign.Create_Confirm_Every_Input()).Trim();
            if (getFreq.Contains(expectedvalue))
                Logger.WriteDebugMessage("Selected Frequency is same");
            else
                Assert.Fail("Selected Frequency is different");
        }
        public static void VerifyDateOnPageByElementOnce(string expectedvalue)
        {
            string getDate = GetElementValue(PageObject_CreateCampaign.Create_Confirm_On_Input()).Trim();
            if (getDate.Contains(expectedvalue))
                Logger.WriteDebugMessage("Selected Date is same");
            else
                Assert.Fail("Selected Date is different");
        }
        public static void VerifyDateOnPageByElementOther(string expectedvalue)
        {
            string getDate = GetElementValue(PageObject_CreateCampaign.Create_Confirm_Weekly_From_Input()).Trim();
            if (getDate.Contains(expectedvalue))
                Logger.WriteDebugMessage("Selected Date is same");
            else
                Assert.Fail("Selected Date is different");
        }
        public static void VerifyTimeOnPageByElement(string expectedvalue)
        {
            string getTime = GetElementValue(PageObject_CreateCampaign.Create_Confirm_At_Time_Input()).Trim();
            if (getTime.Contains(expectedvalue))
                Logger.WriteDebugMessage("Selected Time is same");
            else
                Assert.Fail("Selected Time is different");
        }
        public static void VerifyOnSchedulePage() { 
            if (!IsElementDisplayed(PageObject_CreateCampaign.Create_Confirm_Schedule_Text()))
                Assert.Fail("Unalbe to redirect on Schedule Page");
        }

        public static string SelectTimeInAtFieldOfNextslotEditalbe()
        {
            WaitForAjaxControls(50);
            string selectedTime = null;
            IList<IWebElement> time = null;
            WaitForAjaxControls(30);
            ElementClick(PageObject_CreateCampaign.Create_Confirm_At_Time_Icon());
            for (int i = 0; i < 7; i++)
            {
                time = PageObject_CreateCampaign.Create_Confirm_At_Time_List();
            }
            time[5].Click();
            WaitForAjaxControls(50);
            selectedTime = GetElementValue(PageObject_CreateCampaign.Create_Confirm_At_Time_Input()).Trim();
            return selectedTime;
        }

        public static void Create_Campaign_Automated_Button()
        {
            ElementClick(PageObject_CreateCampaign.Create_Campaign_Automated_Button());
        }

        public static void Verify_Approval_Card_Title()
        {
            IsElementDisplayed(PageObject_CreateCampaign.Verify_Approval_Card_Title());
        }

        public static void Verify_Approval_Card_Text()
        {
            IsElementDisplayed(PageObject_CreateCampaign.Verify_Approval_Card_Text());
        }
        public static void Verify_Approval_Left_Button()
        {
            IsElementDisplayed(PageObject_CreateCampaign.Verify_Approval_Left_Button());
        }
        public static void Verify_Approval_Right_Button()
        {
            IsElementDisplayed(PageObject_CreateCampaign.Verify_Approval_Right_Button());
        }

        public static void RejectApproval__popUp_Cancel_button()
        {
            ElementClick(PageObject_CreateCampaign.RejectApproval__popUp_Cancel_button());
        }
        
        public static void Verify_Approval_Card_contain()
        {
            IsElementDisplayed(PageObject_CreateCampaign.Verify_DesignPage_ApprovalCard_Title());
            Logger.WriteDebugMessage("Approval is displayed In Title");
            IsElementDisplayed(PageObject_CreateCampaign.Verify_DesignPage_ApprovalCard_Text());
            Logger.WriteDebugMessage("Text: Request Approval when you are ready to send this campaign for review. Approval is required to view and edit scheduling options. displayed");
            IsElementDisplayed(PageObject_CreateCampaign.Verify_DesignPage_ApprovalCard_SelfApprove_Button());
            Logger.WriteDebugMessage("Self-Approve button displayed.");
            IsElementDisplayed(PageObject_CreateCampaign.Verify_DesignPage_ApprovalCard_SendRequest_Button());
            Logger.WriteDebugMessage("Self-Approve button displayed.");
        }

        public static void VerifySendApprovalinApprovalcard()
        {
            IsElementDisplayed(PageObject_CreateCampaign.Verify_DesignPage_ApprovalCard_Title());
            Logger.WriteDebugMessage("Approval is displayed In Title");
            Helper.VerifyTextOnPage("Requested");
            Logger.WriteDebugMessage("Text: Requested. displayed");
            IsElementDisplayed(PageObject_CreateCampaign.Campaign_Click_Approval_SendRequest_Approve_Button());
            Logger.WriteDebugMessage("Approve button displayed.");
            IsElementDisplayed(PageObject_CreateCampaign.Campaign_Click_Approval_SendRequest_Reject_Button());
            Logger.WriteDebugMessage("Reject button displayed.");
        }

        public static void SelectOptionFromSeedList_DDL(string option)
        {
            IList<IWebElement> list = PageObject_CreateCampaign.Campaign_SendEmail_SeedLists();
            foreach (var item in list)
            {
                if (item.Text.Trim().Equals(option))
                {
                    item.Click();
                    break;
                }
            }
        }

        public static void ValidateRejectApprovalModalCotains()
        {
            Helper.VerifyTextOnPageAndHighLight("Reject Approval");
            Logger.WriteDebugMessage("Titel is displayed as : Reject Approval.");
            Helper.VerifyTextOnPageAndHighLight("Please provide an explanation for rejecting this campaign:");
            Logger.WriteDebugMessage("Verbiage displayed as : Please provide an explanation for rejecting this Campaign.");
            Helper.VerifyTextOnPage("Reject");
            Logger.WriteDebugMessage("Reject button displayed.");
            Helper.VerifyTextOnPageAndHighLight("Cancel");
            Logger.WriteDebugMessage("Cancel button displayed.");
            IsElementDisplayed(PageObject_CreateCampaign.RejectApproval__popUp_Enter_text());
            Logger.WriteDebugMessage("Reject Approval text box displayed.");
        }

        public static void Verify_SchedulePage_Schedule_Title()
        {
            ElementClick(PageObject_CreateCampaign.Verify_SchedulePage_Schedule_Title());
        }
        public static void CreateCampaign_Audience_Selection()
        {
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Audience_Selection());
        }
        public static void Deactivate_Schedule_Dialog_Contains_Title()
        {
            ElementClick(PageObject_CreateCampaign.Deactivate_Schedule_Dialog_Contains_Title());
        }
        public static void Deactivate_Schedule_Dialog_Contains_Text()
        {
            ElementClick(PageObject_CreateCampaign.Deactivate_Schedule_Dialog_Contains_Text());
        }
        public static void Deactivate_Schedule_Dialog_Contains_Cancel()
        {
            ElementClick(PageObject_CreateCampaign.Deactivate_Schedule_Dialog_Contains_Cancel());
        }
        public static void Deactivate_Schedule_Dialog_Contains_Deactivate()
        {
            ElementClick(PageObject_CreateCampaign.Deactivate_Schedule_Dialog_Contains_Deactivate());
        }
        public static void Schedule_Campaign_details_Status()
        {
            GetText(PageObject_CreateCampaign.Schedule_Campaign_details_Status());
        }
        public static void Schedule_Campaign_details_Send_Field()
        {
            ElementClick(PageObject_CreateCampaign.Schedule_Campaign_details_Send_Field());
        }
        public static void Schedule_Campaign_details_ScheduledBy_Field()
        {
            ElementClick(PageObject_CreateCampaign.Schedule_Campaign_details_ScheduledBy_Field());
        }
        public static void Schedule_Campaign_Activate_Button()
        {
            ElementClick(PageObject_CreateCampaign.Schedule_Campaign_Activate_Button());
        }
        public static void Activate_Schedule_Dialog_Contains_Activate_Button()
        {
            ElementClick(PageObject_CreateCampaign.Activate_Schedule_Dialog_Contains_Activate_Button());
        }

        public static void VerifyCardsOnMarketingTab(string cardsName)
        {
            try
            {
                var expCards = cardsName.Split(',');
                int count = 0;
                IList<IWebElement> cards = Driver.FindElements(By.XPath(ObjectRepository.Campaign_Button_ApplicationCards));
                foreach (var item in cards)
                {
                    for (int i = 0; i < expCards.Length; i++)
                    {
                        if (item.Text.Trim().Equals(expCards[i].Trim()))
                        {
                            count = count + 1;
                            break;
                        }
                    }
                }
                Assert.IsTrue(expCards.Length == count, $"System is not showing {cardsName} on the marketing page");
            }
            catch (System.IndexOutOfRangeException e)
            {
                Logger.WriteErrorMessage("System is not displaying the cards", e);
                throw e;
            }
        }
        /// <summary>
        /// Click on the cardName and validate the setting wizard
        /// </summary>
        /// <param name="cardName"></param>
        public static void ClickingOnCardBasedOnName(string cardName)
            {
                try
                {
                    // Click on first card and verify user lands on the settings page
                    IList<IWebElement> cards = Driver.FindElements(By.XPath(ObjectRepository.Campaign_Button_ApplicationCards));
                    for (int j = 0; j < 1; j++)
                    {
                    if (cards[j].Text.Trim().Equals(cardName.Trim()))
                    {
                        ScrollToElement(cards[j]);
                        cards[j].Click();
                        WaitForAjaxControls(50);
                        IWebElement settings = PageObject_CreateCampaign.Create_Wizard_Settings();
                        string color = settings.GetCssValue("border-color");
                        Assert.AreEqual("rgb(39, 110, 205)", color, "Clicking on card, user is not brought to first step of campaign creation process");
                        Logger.WriteDebugMessage("Clicking on card, user is brought to first step of campaign creation process");
                    }
                        
                    }
                }
                catch (System.IndexOutOfRangeException e)
                {
                    Logger.WriteErrorMessage($"Unable to select the given card {cardName}", e);
                    throw e;
                }
        }

        public static void VerifySendDMMDefaultValue(string defaultValue)
        {
            string defaultText = Helper.GetValue(PageObject_CreateCampaign.Create_Confirm_Send_Input_DropDown().FindElement(By.XPath("/descendant::option")));
            Assert.IsTrue(defaultText.Trim().Equals(defaultValue.Trim()), $"System is not displaying default value selected {defaultValue}");
        }

        public static void VerifyTimeZoneValue()
        {
            Helper.ScrollToElement(PageObject_CreateCampaign.Create_Confirm_Time_Zone_Input());
            Assert.IsTrue(GetElementValue(PageObject_CreateCampaign.Create_Confirm_Time_Zone_Input()).Trim().Length>1,"Time zone drop down doen't have value");
        }
        public static void VerifyWizardStepsSettingsDesignAndConfirm()
        {
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateCampaign.Create_Wizard_Settings()), "Settings step is not displaying");
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateCampaign.Create_Wizard_Design()), "Design step is not displaying");
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateCampaign.Create_Wizard_Confirm()), "Confirm step is not displaying");
        }

        public static void VerifyUserNavigateToDesignCardViewMA()
        {
            IList<IWebElement> designCards = PageObject_CreateCampaign.Create_Design_Cards_Title_List();
            Assert.IsTrue(designCards.Count >= 1, "Cards are not displaying on the Design page");
        }
        public static void VerifyUserNavigateToDesignPreviewMA()
        {
            Helper.WaitForAjaxControls(120);
            Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Design_Preview_Page_Loader());
        }

        public static void ClickOnCamapignCardEllipseEdit(string campaignID)
        {
            IList<IWebElement> titles = SelectListOfCardTitles();
            IList<IWebElement> ellipses = SelectListOfCardEllipses();
            IList<IWebElement> edit = PageObject_CreateCampaign.Campaign_Card_Campaign_Ellipse_Edit();
            IList<IWebElement> ids = SelectListOfCardIDs();
            int count = titles.Count;
            try
            {
                if (count > 0)
                {
                    Logger.WriteDebugMessage("Cards are displaying on Manage Campaign page");
                    for (int i = 0; i < count; i++)
                    {
                        if (ids[i].Text == campaignID)
                        {
                            ScrollToElement(titles[i]);
                            ElementClick(ellipses[i]);
                            ElementClick(edit[i]);
                            Logger.WriteDebugMessage("Clicked on Edit of card");
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Logger.WriteDebugMessage("Cards are not displaying on Manage Campaign page");
                throw e;
            }
        }
        public static void VrifyURLs(string url)
        {
            
            try
            {
                string currentUrl = Driver.Url;
                Assert.IsTrue(currentUrl.Contains(url), $"Campaign URLs is not matching as expected {url}");

            }
            catch (Exception e)
            {
                Logger.WriteDebugMessage("System is not displaying the correct URLs");
                throw e;
            }
        }

        public static void ClickOnCamapignCardEllipseViewDetails(string campaignID)
        {
            IList<IWebElement> titles = SelectListOfCardTitles();
            IList<IWebElement> ellipses = SelectListOfCardEllipses();
            IList<IWebElement> viewDetails = PageObject_CreateCampaign.Campaign_Card_Campaign_Ellipse_ViewDetails();
            IList<IWebElement> ids = SelectListOfCardIDs();
            int count = titles.Count;
            try
            {
                if (count > 0)
                {
                    Logger.WriteDebugMessage("Cards are displaying on Manage Campaign page");
                    for (int i = 0; i < count; i++)
                    {
                        if (ids[i].Text == campaignID)
                        {
                            ScrollToElement(titles[i]);
                            ElementClick(ellipses[i]);
                            ElementClick(viewDetails[i]);
                            Logger.WriteDebugMessage("Clicked on View Details of card");
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Logger.WriteDebugMessage("Cards are not displaying on Manage Campaign page");
                throw e;
            }
        }

        //For the current month the index will be 0 and for next month it will 1 next to next it will 2 like this
        public static string SelectDateInStartFromFieldOfNextMonth(int index)
        {
            IList<IWebElement> dates = null;
            string selectedDate = null;
            WaitForAjaxControls(30);
            Helper.ScrollToElement(PageObject_CreateCampaign.Create_Confirm_Schedule_Text());
            ElementClick(PageObject_CreateCampaign.Create_Confirm_Start_On_Picker_Icon());
            for (int j = 0; j < index; j++)
            {
                ElementClick(PageObject_CreateCampaign.Create_Confirm_Calendar_Next());
                Helper.AddDelay(3000);
            }
            for (int i = 0; i < 7; i++)
            {
                dates = PageObject_CreateCampaign.Create_Confirm_FutureDates();
            }
            dates[10].Click();
            selectedDate = GetElementValue(PageObject_CreateCampaign.Create_Confirm_Start_On_Input()).Trim();
            return selectedDate;
        }
        public static void ClickOnSendRequestAndVerifyButtons()
        {
            ElementClick(PageObject_CreateCampaign.Verify_DesignPage_ApprovalCard_SendRequest_Button());
            ElementWait(PageObject_CreateCampaign.Campaign_Click_Approval_SendRequest_Approve_Button(), 10);
            Assert.IsTrue(Helper.IsElementDisplayed(PageObject_CreateCampaign.Campaign_Click_Approval_SendRequest_Approve_Button()),"Approve button is not displaying");
            Assert.IsTrue(Helper.IsElementDisplayed(PageObject_CreateCampaign.Campaign_Click_Approval_SendRequest_Reject_Button()),"Reject button is not displaying");
        }
        public static void ClickOnRejectButtonAndVerifyCommentBox()
        {
            ElementClick(PageObject_CreateCampaign.Campaign_Click_Approval_SendRequest_Reject_Button());
            Assert.IsTrue(Helper.IsElementDisplayed(PageObject_CreateCampaign.Campaign_Card_Campaign_Reject_Textarea()),"Reject Approval popup is not displaying");
        }
        public static void EnterCommentAndRejectButton(string comments)
        {
            ElementEnterText(PageObject_CreateCampaign.Campaign_Card_Campaign_Reject_Textarea(),comments);
            ElementClick(PageObject_CreateCampaign.RejectApproval__popUp_Reject_button());
        }
        public static void VerifyCommentsAndUserName(string comment, string username, string defaultText)
        {
            string commentsText = null;
            commentsText = Helper.GetText(PageObject_CreateCampaign.Campaign_Card_Campaign_Reject_Comments());
            int count = 0;
            while (String.IsNullOrEmpty(commentsText))
            {
                Helper.AddDelay(5000);
                count = count + 1;
                commentsText = Helper.GetText(PageObject_CreateCampaign.Campaign_Card_Campaign_Reject_Comments());
                if (count > 5)
                    break;
            }
            string rejectAutoMsg = Helper.GetText(PageObject_CreateCampaign.Campaign_Card_Campaign_Reject_AutoMessage());
            Assert.IsTrue(commentsText.Contains(comment), "System is not displaying added rejected comment");
            Assert.IsTrue(rejectAutoMsg.Contains(username), "System is not displaying username with Reject Text");
            Assert.IsTrue(rejectAutoMsg.Contains(defaultText), $"System is not displaying ${defaultText} Text");
            string date = Helper.GetDate();
            Assert.IsTrue(rejectAutoMsg.Contains(date), $"System is not displaying date");
        }
    }
}
