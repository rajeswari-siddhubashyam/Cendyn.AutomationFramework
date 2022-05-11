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


namespace MarketingAutomation.AppModule.UI
{
    public class ManageCampaign : BaseUtility.AppModule.UI.ManageCampaign
    {
        public static void Card_View()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Card_View());
        }

        public static void List_View()
        {
            Helper.ElementClick(PageObject_ManageCampaign.List_View());
            Logger.WriteDebugMessage("campaign displayed in list view");
        }

        public static void Toggle_switch()
        {
            if (PageObject_ManageCampaign.Card_View().Displayed)
            {
                Logger.WriteDebugMessage("Toggle switch for Card is available");
            }
            else
                Assert.Fail("Toggle switch for Card is NOT available");

            if (PageObject_ManageCampaign.List_View().Displayed)
            {
                Logger.WriteDebugMessage("Toggle switch for List is available");
            }
            else
                Assert.Fail("Toggle switch for List is NOT available");
        }

        public static void VerifyDefaultView()
        {
            if (PageObject_ManageCampaign.Card_View().Enabled)
            {
                Logger.WriteDebugMessage("By default card view is selected");
            }
            else
                Assert.Fail("By default card view is NOT selected");
        }

        public static void Automated_Toggle_Button()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Automated_Toggle_Button());
            Helper.VerifyTextNOTOnPage("Audience");
            Logger.WriteDebugMessage("Automated campaigns Displayed");
        }

        public static void Marketing_Toggle_Button()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Marketing_Toggle_Button());
            Helper.VerifyTextOnPage("Audience");
            Logger.WriteDebugMessage("Marketing campaigns Displayed");
        }

        public static void Toggle_switch_Marketing_Automated()
        {
            if (PageObject_ManageCampaign.Marketing_Toggle_Button().Displayed)
            {
                Logger.WriteDebugMessage("Toggle switch for Marketing is available");
            }
            else
                Assert.Fail("Toggle switch for Marketing is NOT available");

            if (PageObject_ManageCampaign.Automated_Toggle_Button().Displayed)
            {
                Logger.WriteDebugMessage("Toggle switch for Automated is available");
            }
            else
                Assert.Fail("Toggle switch for Automated is NOT available");
        }

        public static void Hover_ListView_CampaignAudience()
        {
            Helper.ElementHover(PageObject_ManageCampaign.Hover_ListView_CampaignAudience());
            Logger.WriteDebugMessage("Audience should have hover over and Full campaign name displayed");
        }

        public static void Click_CampaignName()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Hover_ListView_CampaignName());
            Logger.WriteDebugMessage("Summary tab of Manage Campaign displayed");
        }

        public static void Verify_ManageCampaign_gridColumns()
        {
            Helper.VerifyTextOnPage("ID");
            Logger.WriteDebugMessage("ID columns available in the grid");

            Helper.VerifyTextOnPage("NAME");
            Logger.WriteDebugMessage("Name columns available in the grid");

            Helper.VerifyTextOnPage("STATUS");
            Logger.WriteDebugMessage("Status columns available in the grid");

            Helper.VerifyTextOnPage("AUDIENCE");
            Logger.WriteDebugMessage("Audience columns available in the grid");

            Helper.VerifyTextOnPage("UPDATED BY");
            Logger.WriteDebugMessage("Updated By columns available in the grid");

            Helper.VerifyTextOnPage("UPDATED ON");
            Logger.WriteDebugMessage("Updated On columns available in the grid");
        }

        public static void Campaign_ID()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Campaign_ID());
            Logger.WriteDebugMessage("Summary tab of Manage Campaign displayed");
        }

        public static string GetText(IWebElement element)
        {
            string capturedText = element.Text.Trim();
            return capturedText;
        }

        public static void ManageCapaign_Audience_Name()
        {
            Helper.ElementClick(PageObject_ManageCampaign.ManageCapaign_Audience_Name());
            Logger.WriteDebugMessage("Audience Name displayed");
        }
        public static void ManageCapaign_Update_By()
        {
            Helper.ElementClick(PageObject_ManageCampaign.ManageCapaign_Update_By());
            Logger.WriteDebugMessage("Updated by column  displayed");
        }

        public static void ManageCapaign_Updated_ON()
        {
            Helper.ElementClick(PageObject_ManageCampaign.ManageCapaign_Updated_ON());
            Logger.WriteDebugMessage("Updated ON column  displayed");
        }
        public static void ManageCapaign_Status()
        {
            Helper.ElementClick(PageObject_ManageCampaign.ManageCapaign_Status());
        }
        public static void Click_Approved_from_listGrid()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Click_Approved_from_listGrid());
        }

        public static void VerifyCampaign3x3CardsAvailableOrNot()
        {
            int count = 0;
            IList<IWebElement> cards = PageObject_ManageCampaign.Campaign_Cards();
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

        public static void VerifyCampaignLoaded()
        {
            int count = 0;
            IList<IWebElement> pages = PageObject_CreateCampaign.Create_Audience_Paggination_Page_Numbers();
            IList<IWebElement> cards = PageObject_ManageCampaign.Campaign_Cards();
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

        public static void ClickOnAutomatedToggle()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Automated_Toggle_Button());
        }

        public static void VerifyUserNavigateToCampaignCardView()
        {
            IList<IWebElement> audienceCards = PageObject_ManageCampaign.Campaign_Cards();
            Assert.IsTrue(audienceCards.Count >= 1, "Cards are not displaying on the Audience page");
        }
        /// <summary>
        /// This method will verify scroll down at Bottom
        /// </summary>
        public static void Verify_ScrollToBottom()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Helper.Driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            bool atBottomConfirmatiom = Helper.IsElementDisplayed(PageObject_CreateCampaign.Create_Audience_Next_Page_Button());
            Assert.IsTrue(atBottomConfirmatiom.Equals(true), "User unable to found bottom");
        }

        /// <summary>
        /// This method will verify scroll down at Bottom
        /// </summary>
        public static void Verify_ScrollToTop()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Helper.Driver;
            js.ExecuteScript("window.scrollTo(0, 0)");
            bool atBottomConfirmatiom = Helper.IsElementDisplayed(PageObject_CreateCampaign.Confirm_AtTopIcon());
            Assert.IsTrue(atBottomConfirmatiom.Equals(true), "User unable to found top");
        }

        /// <summary>
        /// This method will verify Logo present at Right Top
        /// </summary>
        public static bool ClickOnInitiaLogoOnTopRightCorner()
        {
            Helper.ElementClick(PageObject_CreateCampaign.Confirm_AtTopIcon());
            bool visible = Helper.IsElementVisible(PageObject_ManageCampaign.Click_ToVerifyLogout());
            Assert.IsTrue(visible.Equals(true), "Logout is not at top right corner");
            return visible;
        }

        /// <summary>
        /// This method will verify Login on the Dashboard
        /// </summary>
        public static bool VerifyLoggedinDashboard()
        {
            bool visible = Helper.IsElementVisible(PageObject_ManageCampaign.VerifyLoggedinDashboard());
            Assert.IsTrue(visible.Equals(true), "Logged in failure");
            return visible;
        }

        /// <summary>
        /// This method will verify Paggination is available
        /// </summary>
        public static void VerifyPagginationCountMore()
        {
            IList<IWebElement> paggination = PageObject_CreateCampaign.Create_Audience_Paggination_Page_Numbers();
            Assert.IsTrue(paggination.Count > 1, "Paggination not found");
        }
        /// <summary>
        /// This method will verify absolute 3x3 grid view in Audience & Template
        /// </summary>
        public static void VerifyAbsoluteGrid()
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
            Assert.IsTrue(count == 9, $"{count} card are not in 3x3 format on the page");
            Logger.WriteInfoMessage($"{count} cardare not in 3x3 format on the page");
        }

        /// <summary>
        /// This method will verify absolute 3x3 grid view in Campaign
        /// </summary>
        public static void VerifyAbsoluteGrids()
        {
            int count = 0;
            IList<IWebElement> cards = PageObject_CreateCampaign.GetNumberOfCardsAvailableInPage();
            foreach (var item in cards)
            {
                string getCards = item.GetAttribute("class");
                if (getCards.Contains("4"))
                {
                    count = count + 1;
                }
            }
            Assert.IsTrue(count == 9, $"{count} card are not in 3x3 format on the page");
            Logger.WriteInfoMessage($"{count} cardare not in 3x3 format on the page");
        }


        public static void Click_ManageCampaign_Ellipse()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Click_ManageCampaign_Ellipse());
        }

        public static void Click_ManageCampaign_Ellipse_Edit()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Click_ManageCampaign_Ellipse_Edit());
        }

        public static void Click_ManageCampaign_Ellipse_ViewDetails()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Click_ManageCampaign_Ellipse_ViewDetails());
        }
        public static void Click_ManageCampaign_Ellipse_ViewDetails_Subject()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Click_ManageCampaign_Ellipse_ViewDetails_Subject());
        }
        public static void CardView_Campaign_ID()
        {
            Helper.ElementClick(PageObject_ManageCampaign.CardView_Campaign_ID());
        }
        public static void CardView_Campaign_Status()
        {
            Helper.ElementClick(PageObject_ManageCampaign.CardView_Campaign_Status());
        }

        public static void VerifyMarketingCampaignPage()
        {
            IList<IWebElement> audience = PageObject_ManageCampaign.Campaign_Cards_Audience_Name();
            Assert.IsTrue(Helper.IsElementDisplayed(audience[0]), "User is not landed on the Marketing Campaign page");
        }
        /// <summary>
        /// This method return the campaign information as per given parameter 
        /// if you want only name then pass other parameter as null
        /// </summary>
        /// <param name="campaignName"></param>
        /// <param name="audienceName"></param>
        /// <param name="campaignId"></param>
        /// <param name="campaignStatus"></param>
        /// <param name="campaignDate"></param>
        /// <returns></returns>
        public static List<string> GetCampaignInfoFromPageByProvidingName(string campaignName, string audienceName, string campaignId, string campaignStatus, string campaignDate)
        {
            List<string> campaignInfo = new List<string>();
            Random r = new Random();
            int index;
            IList<IWebElement> campaignNameList = PageObject_ManageCampaign.Campaign_Cards_Title();
            index = r.Next(0, campaignNameList.Count);
            IList<IWebElement> audienceNameList = PageObject_ManageCampaign.Campaign_Cards_Audience_Name();
            IList<IWebElement> campaignIdList = PageObject_ManageCampaign.Campaign_Cards_Subtitle_Name();
            IList<IWebElement> campaignStatusList = PageObject_ManageCampaign.Campaign_Cards_Status();
            IList<IWebElement> campaignDateList = PageObject_ManageCampaign.Campaign_Cards_Update_Date();
            if (!String.IsNullOrEmpty(campaignName))
                campaignInfo.Add(GetText(campaignNameList[index]));
            if (!String.IsNullOrEmpty(audienceName))
                campaignInfo.Add(GetText(audienceNameList[index]));
            if (!String.IsNullOrEmpty(campaignId))
                campaignInfo.Add(GetText(campaignIdList[index]));
            if (!String.IsNullOrEmpty(campaignStatus))
                campaignInfo.Add(GetText(campaignStatusList[index]));
            if (!String.IsNullOrEmpty(campaignDate))
                campaignInfo.Add(GetText(campaignDateList[index]));
            return campaignInfo;
        }

        public static void EnterFilterValues(string filterOption, string filterType, string value)
        {
            IList<IWebElement> options = null;
            string filterTypeInputXpath = "//small[contains(text(),'" + filterOption + "')]/parent::*/following-sibling::div/descendant::span";
            string filterValueInputXpath = "//small[contains(text(),'" + filterOption + "')]/parent::*/following::input[@placeholder='Enter a value']";
            if (filterOption.Equals("ID") || filterOption.Equals("Name") || filterOption.Equals("Audience") || filterOption.Equals("Updated By"))
            {
                Helper.ElementClick(Helper.Driver.FindElement(By.XPath(filterTypeInputXpath)));
                for (int i = 0; i < 5; i++) { options = PageObject_ManageCampaign.Campaign_Filter_DropDown_FilterOptions(); }
                foreach (var item in options)
                {
                    if (item.Text.Equals(filterType))
                    {
                        item.Click();
                        break;
                    }
                }
                string extraClick= "//small[contains(text(),'" + filterOption + "')]";
                Helper.ElementClick(Helper.Driver.FindElement(By.XPath(extraClick)));
                Helper.ElementWait(Helper.Driver.FindElement(By.XPath(filterValueInputXpath)), 10);
                if (value.Length > 200)
                    value = value.Substring(0, 20);
                Helper.ElementEnterText(Helper.Driver.FindElement(By.XPath(filterValueInputXpath)), value.Trim());
            }
            else if (filterOption.Equals("Status"))
            {
                Helper.ElementClick(Helper.Driver.FindElement(By.XPath(filterTypeInputXpath)));
                for (int i = 0; i < 5; i++) { options = PageObject_ManageCampaign.Campaign_Filter_DropDown_FilterOptions(); }
                foreach (var item in options)
                {
                    if (item.Text.Equals(filterType))
                    {
                        item.Click();
                        break;
                    }
                }
                Helper.ElementClick(PageObject_ManageCampaign.Campaign_Filter_ID_Text());
                Helper.ElementWait(PageObject_ManageCampaign.Campaign_Filter_Status_DropDown_Arrow(), 10);
                Helper.ElementClick(PageObject_ManageCampaign.Campaign_Filter_Status_DropDown_Arrow());
                Helper.ElementEnterText(PageObject_ManageCampaign.Campaign_Filter_Status_DropDown_Input(), value);
                IList<IWebElement> statusOption = null;
                Helper.WaitForAjaxControls(50);
                for (int i = 0; i < 5; i++) { statusOption=PageObject_ManageCampaign.Campaign_Filter_Status_DropDown_Options(); }
                foreach (var item in statusOption)
                {
                    if (item.Text.Equals(value))
                    {
                        Helper.ElementWait(item, 5);
                        Helper.ElementClick(item);
                        break;
                    }
                }
                Helper.ElementClick(PageObject_ManageCampaign.Campaign_Filter_ID_Text());
            }
            if (filterOption.Equals("Updated On"))
            {
                Helper.ElementClick(Helper.Driver.FindElement(By.XPath(filterTypeInputXpath)));
                for (int i = 0; i < 5; i++) { options = PageObject_ManageCampaign.Campaign_Filter_DropDown_FilterOptions(); }
                foreach (var item in options)
                {
                    if (item.Text.Equals(filterType))
                    {
                        item.Click();
                        break;
                    }
                }
                Helper.ElementClick(PageObject_ManageCampaign.Campaign_Filter_ID_Text());
                var date = Convert.ToDateTime(value).ToString("MMM dd, yyyy");
                Helper.ElementEnterText(PageObject_ManageCampaign.Campaign_Filter_UpdatedOn_Input(), date);
                Helper.ElementClick(PageObject_ManageCampaign.Campaign_Filter_ID_Text());
            }
        }

        public static void VerifyFilterCampaignInfoOnPage(string campaignName, string audienceName, string campaignId, string campaignStatus, string campaignDate)
        {
            Helper.WaitForAjaxControls(50);
            int actCount = 0, expCount = 0;
            IList<IWebElement> campaignNameList = PageObject_ManageCampaign.Campaign_Cards_Title();
            IList<IWebElement> audienceNameList = PageObject_ManageCampaign.Campaign_Cards_Audience_Name();
            IList<IWebElement> campaignIdList = PageObject_ManageCampaign.Campaign_Cards_Subtitle_Name();
            IList<IWebElement> campaignStatusList = PageObject_ManageCampaign.Campaign_Cards_Status();
            IList<IWebElement> campaignDateList = PageObject_ManageCampaign.Campaign_Cards_Update_Date();
            for (int i = 0; i < campaignNameList.Count; i++)
            {
                if (!String.IsNullOrEmpty(campaignName))
                {
                    actCount = actCount + 1;
                    if (campaignNameList[i].Text.Equals(campaignName))
                        expCount = expCount + 1;
                }

                if (!String.IsNullOrEmpty(audienceName))
                {
                    actCount = actCount + 1;
                    if (audienceNameList[i].Text.Equals(audienceName))
                        expCount = expCount + 1;
                }

                if (!String.IsNullOrEmpty(campaignId))
                {
                    actCount = actCount + 1;
                    if (campaignIdList[i].Text.Equals(campaignId))
                        expCount = expCount + 1;
                }

                if (!String.IsNullOrEmpty(campaignStatus))
                {
                    actCount = actCount + 1;
                    if (campaignStatusList[i].Text.Equals(campaignStatus))
                        expCount = expCount + 1;
                }
                if (!String.IsNullOrEmpty(campaignDate))
                {
                    actCount = actCount + 1;
                    if (campaignDateList[i].Text.Equals(campaignDate))
                        expCount = expCount + 1;
                }
            }
            Assert.IsTrue(actCount >= expCount, "Campaign with details is not present in the filter result");
            Assert.IsTrue(expCount>=1, "System is not displying result based on filter");
        }

        //Click on Sort and Select ID with Drop-Down Option then click Apply.
        public static void ClickOnSortButton()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Manage_Campaign_Sort_Button());
        }

        public static void SelectSortType(string sortType)
        {
            IList<IWebElement> sortOptions = null;
            Helper.WaitForAjaxControls(50);
            IList<IWebElement> arrows = PageObject_ManageCampaign.Manage_Campaign_Sort_DropDown_Arrows();
            Helper.ElementClick(arrows[0]);
            for (int i = 0; i < 3; i++) { sortOptions = PageObject_ManageCampaign.Campaign_Filter_DropDown_FilterOptions(); }
            foreach (var item in sortOptions)
            {
                if (item.Text.Equals(sortType))
                {
                    item.Click();
                    break;
                }
            }
            Logger.WriteDebugMessage("Sort option selected");
        }

        public static void ClickOnSortApplyButton()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Manage_Campaign_Sort_Apply());
            Helper.WaitForAjaxControls(50);
        }

        public static void ClickOnSortClearButton()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Manage_Campaign_Sort_Clear());
            Helper.WaitForAjaxControls(50);
        }

        public static void VerifyCampaignOrderIDsDesc()
        {
            Helper.WaitForAjaxControls(50);
            IList<IWebElement> campaignIdList = PageObject_ManageCampaign.Campaign_Cards_Subtitle_Name();
            if (campaignIdList.Count > 1)
            {
                for (int i = 0; i < campaignIdList.Count - 1; i++)
                {
                    if (Convert.ToInt32(campaignIdList[i].Text) < Convert.ToInt32(campaignIdList[i + 1].Text))
                        Assert.Fail("Campaign is not in the Ids descending order");
                }
            }
        }
        /// <summary>
        /// This method verify the descending order for Campaign, Audience and status
        /// </summary>
        /// <param name="nameOfSort"></param>
        public static void VerifyCampaignListOrdersDesc(string nameOfSort)
        {
            IList<IWebElement> listOfSortData = null;
            Helper.WaitForAjaxControls(50);
            if (nameOfSort.Equals("Name"))
                listOfSortData = PageObject_ManageCampaign.Campaign_Cards_Title();
            else if (nameOfSort.Equals("Audience"))
                listOfSortData = PageObject_ManageCampaign.Campaign_Cards_Audience_Name();
            else if (nameOfSort.Equals("Status"))
                listOfSortData = PageObject_ManageCampaign.Campaign_Cards_Status();
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

        public static void VerifyCampaignListDateOrdersDesc()
        {
            IList<IWebElement> campaignDateList = PageObject_ManageCampaign.Campaign_Cards_Update_Date();
            for (int i = 0; i < campaignDateList.Count - 1; i++)
            {
                DateTime date1 = Convert.ToDateTime(campaignDateList[i].Text);
                DateTime date2 = Convert.ToDateTime(campaignDateList[i + 1].Text);
                if (DateTime.Compare(date1,date2)<0)
                    Assert.Fail("Campaign list is not in the updated on dates descending order");
            }

        }

        public static List<string> GetCampaignInfoFromPageByProvidingNameListView(string campaignName, string audienceName, string campaignId, string campaignStatus, string campaignDate)
        {
            int columnIndex = 0;
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> cellData = null;
            List<string> campaignInfo = new List<string>();
            Helper.WaitForAjaxControls(60);
            for (int l = 0; l < 20; l++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
            IList<IWebElement> columns = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
            if (!String.IsNullOrEmpty(campaignName))
            {
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("NAME"))
                        break;
                }
                campaignInfo.Add(GetText(cellData[columnIndex-1]));
                columnIndex = 0;
            }
            if (!String.IsNullOrEmpty(audienceName))
            {
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("AUDIENCE"))
                        break;
                }
                campaignInfo.Add(GetText(cellData[columnIndex - 1]));
                columnIndex = 0;
            }
            if (!String.IsNullOrEmpty(campaignId))
            {
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("ID"))
                        break;
                }
                campaignInfo.Add(GetText(cellData[columnIndex - 1]));
                columnIndex = 0;
            }
            if (!String.IsNullOrEmpty(campaignStatus))
            {
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("STATUS"))
                        break;
                }
                campaignInfo.Add(GetText(cellData[columnIndex - 1]));
                columnIndex = 0;
            }
            if (!String.IsNullOrEmpty(campaignDate))
            {
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("UPDATED ON"))
                        break;
                }
                campaignInfo.Add(GetText(cellData[columnIndex - 1]));
                columnIndex = 0;
            }
           return campaignInfo;
        }

        public static void VerifyCampaignInfoOnPageByProvidingNameListView(string campaignName, string audienceName, string campaignId, string campaignStatus, string campaignDate)
        {
            int columnIndex = 0;
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> cellData = null;
            List<string> campaignInfo = new List<string>();
            Helper.WaitForAjaxControls(60);
            for (int l = 0; l < 20; l++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
            IList<IWebElement> columns = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
            if (!String.IsNullOrEmpty(campaignName))
            {
                int expCount = 0;
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("NAME"))
                        break;
                }
                if (campaignName.Equals(GetText(cellData[columnIndex - 1])))
                {
                    expCount = expCount + 1;
                }
                columnIndex = 0;
                Assert.IsTrue(expCount >= 1, "System is not displayig data based on filter selection");
            }
            if (!String.IsNullOrEmpty(audienceName))
            {
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("AUDIENCE"))
                        break;
                }
                campaignInfo.Add(GetText(cellData[columnIndex - 1]));
                columnIndex = 0;
            }
            if (!String.IsNullOrEmpty(campaignId))
            {
                int expCount = 0;
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("ID"))
                        break;
                }
                if (campaignId.Equals(GetText(cellData[columnIndex - 1])))
                {
                    expCount = expCount + 1;
                }
                columnIndex = 0;
                Assert.IsTrue(expCount >= 1, "System is not displayig data based on filter selection");
            }
            if (!String.IsNullOrEmpty(campaignStatus))
            {
                int expCount = 0;
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("STATUS"))
                        break;
                }
                if (campaignStatus.Equals(GetText(cellData[columnIndex - 1])))
                {
                    expCount = expCount + 1;
                }
                columnIndex = 0;
                Assert.IsTrue(expCount >= 1, "System is not displayig data based on filter selection");
            }
            if (!String.IsNullOrEmpty(campaignDate))
            {
                int expCount = 0;
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("UPDATED ON"))
                        break;
                }
                if (campaignDate.Equals(GetText(cellData[columnIndex - 1])))
                {
                    expCount = expCount + 1;
                }
                columnIndex = 0;
                Assert.IsTrue(expCount >= 1, "System is not displayig data based on filter selection");
            }
        }
        public static void Campaign_Click_FilterAndVerifyPopup()
        {
            Helper.ElementClick(PageObject_CreateCampaign.Campaign_Click_Filter());
            Assert.IsTrue(Helper.IsElementDisplayed(PageObject_ManageCampaign.Campaign_Filter_ID_Text()), "Filter popup is not open");
        }

        public static void WaitToHideLoaderOnListView()
        {
            By loader = By.XPath(PageObject_ManageCampaign.Manage_Campaign_List_View_Loader());
            Helper.WaitTillInvisibilityOfLoader(loader, 5);
        }

        public static void VerifyCampaignSortBasedOnId()
        {       int columnIndex = 0, count = 0;
                Helper.WaitForAjaxControls(120);
                IList<IWebElement> cellData = null;
                IList<string> Ids= new List<string>();
                Helper.WaitForAjaxControls(60);
                for (int l = 0; l < 20; l++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                IList<IWebElement> columns = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
                foreach (var item in columns)
                {
                   columnIndex = columnIndex + 1;
                   if (item.Text.Trim().Equals("ID"))
                       break;
                }
                for (int i = columnIndex - 1; i < cellData.Count; i++)
                {
                 Helper.ScrollToElement(cellData[i]);
                 Ids.Add(cellData[i].Text);
                 for (int k = 0; k < 10; k++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                 i = i + 6;
                }
                for (int f = 0; f < Ids.Count - 1; f++)
                {
                    if (Convert.ToInt32(Ids[f]) > Convert.ToInt32(Ids[f+1]))
                        Logger.WriteInfoMessage("Campaign is displaying in Ids descending");
                    else
                        Assert.Fail($"{Ids[f]} and {Ids[f+1]} not is updated on descending order");
                }
        }

        public static void VerifyCampaignSortBasedOnNameDesc()
        {
            int columnIndex = 0, count = 0;
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> cellData = null;
            IList<string> name = new List<string>();
            Helper.WaitForAjaxControls(60);
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
                name.Add(cellData[i].Text);
                for (int k = 0; k < 10; k++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                i = i + 6;
            }
            for (int f = 0; f < name.Count - 1; f++)
            {
                string name1 = name[f];
                string name2 = name[f + 1];
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;
                if (comparer.Compare(name1, name2) == 0)
                    Logger.WriteInfoMessage("Both strings have same value.");
                else if (comparer.Compare(name1, name2) < 0)
                    Assert.Fail($"Cmpaign is not in the name descending order");
                else if (comparer.Compare(name1, name2) > 0)
                    Logger.WriteInfoMessage($"{name1} follows {name2}.");
            }
        }

        public static void VerifyCampaignSortBasedOnAudienceDesc()
        {
            int columnIndex = 0, count = 0;
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> cellData = null;
            IList<string> audName = new List<string>();
            Helper.WaitForAjaxControls(60);
            for (int l = 0; l < 20; l++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
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
                audName.Add(cellData[i].Text);
                for (int k = 0; k < 10; k++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                i = i + 6;
            }
            for (int f = 0; f < audName.Count - 1; f++)
            {
                string name1 = audName[f];
                string name2 = audName[f + 1];
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;
                if (comparer.Compare(name1, name2) == 0)
                    Logger.WriteInfoMessage("Both strings have same value.");
                else if (comparer.Compare(name1, name2) < 0)
                    Assert.Fail($"Cmpaign is not in the name descending order");
                else if (comparer.Compare(name1, name2) > 0)
                    Logger.WriteInfoMessage($"{name1} follows {name2}.");
            }
        }
        public static void VerifyCampaignSortBasedOnStatuseDesc()
        {
            int columnIndex = 0;
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> cellData = null;
            IList<string> status = new List<string>();
            Helper.WaitForAjaxControls(60);
            for (int l = 0; l < 20; l++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
            IList<IWebElement> columns = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
            foreach (var item in columns)
            {
                columnIndex = columnIndex + 1;
                if (item.Text.Trim().Equals("STATUS"))
                    break;
            }
            for (int i = columnIndex - 1; i < cellData.Count; i++)
            {
                Helper.ScrollToElement(cellData[i]);
                status.Add(cellData[i].Text);
                for (int k = 0; k < 10; k++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                i = i + 6;
            }
            for (int f = 0; f < status.Count - 1; f++)
            {
                string name1 = status[f];
                string name2 = status[f + 1];
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;
                if (comparer.Compare(name1, name2) == 0)
                    Logger.WriteInfoMessage("Both strings have same value.");
                else if (comparer.Compare(name1, name2) < 0)
                    Assert.Fail($"Cmpaign is not in the name descending order");
                else if (comparer.Compare(name1, name2) > 0)
                    Logger.WriteInfoMessage($"{name1} follows {name2}.");
            }
        }
        public static void VerifyAutomatedPage()
        {
            IList<IWebElement> audienceNameList = PageObject_ManageCampaign.Campaign_Cards_Audience_Name();
            Assert.IsTrue(audienceNameList.Count == 0, "User does not land on Automated Campaign Page. ");
        }

        public static void WaitToHideLoaderListView()
        {
            string loader = PageObject_ManageCampaign.Manage_Campaign_List_View_Loader();
            Helper.FindLoaderAndWaitTillHide(loader);
        }

        public static void Click_ManageCampaign_cardView_StatusArrow()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Click_ManageCampaign_cardView_StatusArrow());
        }

        public static void Check_ManageCampaign_cardView_Status_RequestApprove_button()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Check_ManageCampaign_cardView_Status_RequestApprove_button());
        }

        public static void Check_ManageCampaign_cardView_Status_SelfApprove_button()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Check_ManageCampaign_cardView_Status_SelfApprove_button());
        }
        public static void Check_ManageCampaign_cardView_Status_Schedule_button()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Check_ManageCampaign_cardView_Status_Schedule_button());
        }
        public static void Scheduled_Active_Edit_Button()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Scheduled_Active_Edit_Button());
        }
        public static void Scheduled_Active_Deactivate_Button()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Scheduled_Active_Deactivate_Button());
        }
        public static void Scheduled_InActive_Activate_Button()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Scheduled_InActive_Activate_Button());
        }
        public static void Click_ManageCampaign_ListView_StatusArrow()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Click_ManageCampaign_ListView_StatusArrow());
        }
        public static void Approved_Campaign_details_Approvedby_Field()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Approved_Campaign_details_Approvedby_Field());
        }
        public static void Approved_Campaign_details_ApprovedOn_Field()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Approved_Campaign_details_ApprovedOn_Field());
        }

        public static void ListView_Campaign_Status()
        {
            Helper.ElementClick(PageObject_ManageCampaign.ListView_Campaign_Status());
        }
        public static void Approved_Campaign_details_ApprovedOn_Field_Value()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Approved_Campaign_details_ApprovedOn_Field_Value());
        }
        public static void Approved_Campaign_details_Approvedby_Field_Value()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Approved_Campaign_details_Approvedby_Field_Value());
        }

        public static void VerifyApprovedByandApprovedOnFiled()
        {
            Helper.IsElementDisplayed(PageObject_ManageCampaign.Approved_Campaign_details_Approvedby_Field());
            String ApproveBy_value = Helper.GetText(PageObject_ManageCampaign.Approved_Campaign_details_Approvedby_Field_Value());
            Assert.IsTrue(ApproveBy_value.Length > 1, "Approved by field displayed");
            Helper.IsElementDisplayed(PageObject_ManageCampaign.Approved_Campaign_details_ApprovedOn_Field());
            String ApproveOn_value = Helper.GetText(PageObject_ManageCampaign.Approved_Campaign_details_ApprovedOn_Field_Value());
            Assert.IsTrue(ApproveOn_value.Length > 1, "Approved On field displayed");
            Logger.WriteDebugMessage("Approved on filed displayed");
        }
        public static void Click_On_Code_Editor()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Click_On_Code_Editor());
        }
        public static void Enter_HTML_Code(string value)
        {
            Helper.ElementEnterText(PageObject_ManageCampaign.Enter_HTML_Code(),value);
        }
        public static void Click_CSS()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Click_CSS());
        }
        public static void Enter_CSS_Code()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Enter_CSS_Code());
        }
        public static void Click_On_Code_Editor_Save_Button()
        {
            Helper.ElementClick(PageObject_ManageCampaign.Click_On_Code_Editor_Save_Button());
        }
        public static void VerifySummaryTab()
        {
            Helper.FindLoaderAndWaitTillHide(PageObject_CreateCampaign.Create_Audience_Preview_Loader());
            Assert.IsTrue(Helper.IsElementDisplayed(PageObject_ManageCampaign.View_Campaign_Summary_Tab()),"System is not displaying summary tab");
            Assert.IsTrue(Helper.IsElementDisplayed(PageObject_ManageCampaign.View_Campaign_Summary_General_Text()),"User is not on summary tab");
        }
        //Click on Audience Tab and verify
        public static void ClickOnViewCampaignAudienceTabAndVerify()
        {
            Helper.ElementClick(PageObject_ManageCampaign.View_Campaign_Audience_Tab());
            Assert.IsTrue(Helper.IsElementDisplayed(PageObject_ManageCampaign.View_Campaign_Audience_Criteria_Text()), "User is not on Audience tab");
        }

        public static void ClickOnViewCampaignAudienceTab()
        {
            Helper.ElementClick(PageObject_ManageCampaign.View_Campaign_Audience_Tab());
        }

        public static void ClickOnViewCampaignDesignTab()
        {
            Helper.ElementClick(PageObject_ManageCampaign.View_Campaign_Design_Tab());
        }

        //Click on Design Tab and verify
        public static void ClickOnViewCampaignDesignTabAndVerify()
        {
            Helper.ElementClick(PageObject_ManageCampaign.View_Campaign_Design_Tab());
            Assert.IsTrue(Helper.IsElementDisplayed(PageObject_ManageCampaign.View_Campaign_Design_General_Text()), "User is not on Design tab");
        }

        public static void VerifySortOptions(string options)
        {
            int count = 0;
            IList<IWebElement> sortOptions = null;
            IList<string> actualOptions = new List<string>();
            IList<string> expectedOptions = new List<string>();
            Helper.WaitForAjaxControls(50);
            IList<IWebElement> arrows = PageObject_ManageCampaign.Manage_Campaign_Sort_DropDown_Arrows();
            Helper.ElementClick(arrows[1]);
            for (int i = 0; i < 3; i++) { sortOptions = PageObject_ManageCampaign.Campaign_Filter_DropDown_FilterOptions(); }
            var act = options.Split(',');
            foreach (var item in act)
            {
                actualOptions.Add(item.ToLower().Trim());
            }
            foreach (var item in sortOptions)
            {
                expectedOptions.Add(item.Text.ToLower().Trim());
            }
            if (actualOptions.Count != expectedOptions.Count)
                Logger.WriteInfoMessage("Expected and actual list options count is not matching");
            for (int i = 0; i < actualOptions.Count; i++)
            {
                if (expectedOptions.Contains(actualOptions[i]))
                    count = count + 1;
            }
            Assert.IsTrue(actualOptions.Count == count, "List contains the all provided option for filter");
            Logger.WriteDebugMessage("List options");
            arrows = PageObject_ManageCampaign.Manage_Campaign_Sort_DropDown_Arrows();
            Helper.ElementClick(arrows[1]);
        }

        public static void SelectSortOptions(string optionsToSelect)
        {
            IList<IWebElement> sortOptions = null;
            Helper.WaitForAjaxControls(50);
            IList<IWebElement> arrows = PageObject_ManageCampaign.Manage_Campaign_Sort_DropDown_Arrows();
            Helper.ElementClick(arrows[1]);
            for (int i = 0; i < 3; i++) { sortOptions = PageObject_ManageCampaign.Campaign_Filter_DropDown_FilterOptions(); }
            foreach (var item in sortOptions)
            {
                if (item.Text.ToLower().Trim().Equals(optionsToSelect))
                {
                    Helper.ElementClick(item);
                    break;
                }
                    
            }
            
        }

    }
}