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
    public class ManageTemplate : BaseUtility.AppModule.UI.ManageCampaign
    {
        public static void ClickOnEllipsViewDetailsGridView()
        {
            IList<IWebElement> ellipses = PageObject_CreateTemplate.TemplatePage_Ellipses_List();
            IList<IWebElement> viewDetails = PageObject_CreateTemplate.TemplatePage_Ellipses_ViewDetails();
            Random rnd = new Random();
            int index = rnd.Next(0, ellipses.Count);
            Helper.ScrollToElement(ellipses[index]);
            ellipses[index].Click();
            Helper.WaitForAjaxControls(50);
            viewDetails[index].Click();

        }

        public static void VerifyTemplateSummaryPage()
        {
            Assert.IsTrue(Helper.IsElementDisplayed(PageObject_CreateTemplate.Click_TemplatePage_Ellipses_ViewDetails_SummaryTab()), "User is not landed on Template Summary page");
        }

        public static void ClickOnCampaignTabAndVerifyColumnHeader()
        {
            Helper.ElementClick(PageObject_CreateTemplate.Click_TemplatePage_Ellipses_ViewDetails_SummaryTab());
            ManageCampaign.WaitToHideLoaderListView();
            IList<IWebElement> columnHeader = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
            Assert.IsTrue(columnHeader.Count > 1, "Campaign tab is not displaying column");
        }

        /// <summary>
        /// Click on provided column name filter icon and verify provided list in the drop down
        /// column names are case sensitive ID, Name, Status and Update On
        /// option is a string with comma separated
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="options"></param>
        public static void ClickOnFilterIconAndVerifyFilterOptionsDropDownValue(string columnName, string options)
        {
            int count = 0;
            IList<IWebElement> dropDownOptions = null;
            IList<string> actualOptions = new List<string>();
            IList<string> expectedOptions = new List<string>();
            By columnFilterIcon = By.XPath("//small[contains(text(),'" + columnName + "')]/following::span[contains(@class,'e-search-icon')]");
            Helper.ScrollToElement(Helper.Driver.FindElement(columnFilterIcon));
            Helper.ElementClick(Helper.Driver.FindElement(columnFilterIcon));
            //Helper.ElementClick(PageObject_ManageTemplate.Column_Filter_Options_Arrow());
            for (int i = 0; i < 3; i++) { dropDownOptions = PageObject_ManageTemplate.Filter_Options_List(); }
            var act = options.Split(',');
            foreach (var item in act)
            {
                actualOptions.Add(item.ToLower().Trim());
            }
            foreach (var item in dropDownOptions)
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
        }

        /// <summary>
        /// Get first value of the column based on it name
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        /// e.g column name can be ID, NAME, STATUS, UPDATE BY, UPDATE ON
        public static string GetTheColumnValueBasedOnName(string columnName)
        {
            Helper.WaitForAjaxControls(120);
            int columnIndex = 0;
            string value = null;
            IList<IWebElement> cellData = null;
            cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List();
            IList<IWebElement> columns = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
            foreach (var item in columns)
            {
                columnIndex = columnIndex + 1;
                if (item.Text.Trim().Equals(columnName))
                    break;
            }
            for (int i = columnIndex - 1; i < cellData.Count; i++)
            {
                Helper.ScrollToElement(cellData[i]);
                value = cellData[i].Text.Trim();
                if (value.Length > 1)
                    break;
            }
            return value;
        }

        public static void EnterColumnFilterValueBasedOnName(string columnName, string options, string value)
        {
            IList<IWebElement> dropDownOptions = null;
            IList<string> actualOptions = new List<string>();
            IList<string> expectedOptions = new List<string>();
            By columnFilterIcon = By.XPath("//span[contains(text(),'" + columnName + "')]/following::div[contains(@class,'icon-filter')]");
            Helper.ScrollToElement(Helper.Driver.FindElement(columnFilterIcon));
            Helper.ElementClick(Helper.Driver.FindElement(columnFilterIcon));
            Helper.ElementClick(PageObject_ManageTemplate.Column_Filter_Options_Arrow());
            Helper.WaitForAjaxControls(50);
            for (int i = 0; i <10; i++) { dropDownOptions = PageObject_ManageTemplate.Filter_Options_List(); }
            foreach (var item in dropDownOptions)
            {
                try
                {
                    if (item.Text.ToLower().Trim().Equals(options.Trim().ToLower()))
                        item.Click();
                }
                catch (Exception) { }
            }
            if (!columnName.Equals("Status"))
            {
                try
                {
                    PageObject_ManageTemplate.Filter_Input().SendKeys(value);
                }
                catch (Exception)
                {
                    Helper.ElementEnterText(PageObject_ManageTemplate.Template_Filter_Input_Dates(), value);
                }
            }
            else
            {
                IWebElement ele=PageObject_ManageTemplate.Filter_Input();
                ele.FindElement(By.XPath("parent::*/following-sibling::span[contains(@class,'icon')]")).Click();
                Helper.ElementEnterText(PageObject_ManageCampaign.Campaign_Filter_Status_DropDown_Input(), value);
                IList<IWebElement> statusOption = null;
                Helper.WaitForAjaxControls(50);
                for (int i = 0; i < 5; i++) { statusOption = PageObject_ManageCampaign.Campaign_Filter_Status_DropDown_Options(); }
                foreach (var item in statusOption)
                {
                    if (item.Text.Equals(value))
                    {
                        Helper.ElementWait(item, 5);
                        Helper.ElementClick(item);
                        break;
                    }
                }
                PageObject_ManageTemplate.Filter_Text().Click();
                
            }
            Logger.WriteDebugMessage("Column filter selected");
            
        }

        public static void ClickOnColumnFilterIconeBasedOnName(string columnName)
        {
            By columnFilterIcon = By.XPath("//span[contains(text(),'" + columnName + "')]/following::div[contains(@class,'icon-filter')]");
            Helper.ScrollToElement(Helper.Driver.FindElement(columnFilterIcon));
            Helper.ElementClick(Helper.Driver.FindElement(columnFilterIcon));
        }

        public static void VerifyCampaignCountAndClickOnThreeDotOption()
        {
            int columnIndex = 0,  campaignIndex = 0, columnDiff;
            string campaignsCount;
            IList<IWebElement> cellData = null;
            IList<string> updatedOn = new List<string>();
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers();
                Helper.WaitForAjaxControls(60);
                for (int l = 0; l < 20; l++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                IList<IWebElement> columns = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("CAMPAIGNS"))
                        break;
                }
                foreach (var item in columns)
                {
                    campaignIndex = campaignIndex + 1;
                    if (item.Text.Trim().Equals(""))
                        break;
                }
                columnDiff = campaignIndex - columnIndex;
                for (int i = columnIndex - 1; i < cellData.Count; i++)
                {

                    Helper.ScrollToElement(cellData[i]);
                    campaignsCount = cellData[i].Text.Trim();
                    if (Convert.ToInt32(campaignsCount) > 0)
                    {
                        cellData[i + columnDiff].Click();
                        break;
                    }
                    for (int k = 0; k < 10; k++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                    i = i + 6;
                }
        }

        public static void ClickOnEllipsViewDetailsListView()
        {
            Helper.ElementClick(PageObject_ManageTemplate.Template_List_View_Details());
        }

        public static void VerifyCampaignCountAndClickOnNameToLandOnSummary()
        {
            int columnIndex = 0, campaignIndex = 0, columnDiff;
            string campaignsCount;
            IList<IWebElement> cellData = null;
            IList<string> updatedOn = new List<string>();
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> paggination = PageObject_CreateCampaign.Create_Audience_ListView_Page_Numbers();
            Helper.WaitForAjaxControls(60);
            for (int l = 0; l < 20; l++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
            IList<IWebElement> columns = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
            foreach (var item in columns)
            {
                columnIndex = columnIndex + 1;
                if (item.Text.Trim().Equals("CAMPAIGNS"))
                    break;
            }
            foreach (var item in columns)
            {
                campaignIndex = campaignIndex + 1;
                if (item.Text.Trim().Equals("NAME"))
                    break;
            }
            columnDiff = campaignIndex - columnIndex;
            for (int i = columnIndex - 1; i < cellData.Count; i++)
            {

                Helper.ScrollToElement(cellData[i]);
                campaignsCount = cellData[i].Text.Trim();
                if (Convert.ToInt32(campaignsCount) > 1)
                {
                    cellData[i + columnDiff].Click();
                    break;
                }
                for (int k = 0; k < 10; k++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
                i = i + 6;
            }
        }

        public static void VerifyDateFilterResultForEqualAndBetweenType(string type, string campaignDate)
        {
            int columnIndex = 0;
            Helper.WaitForAjaxControls(120);
            IList<IWebElement> cellData = null;
            List<string> campaignInfo = new List<string>();
            Helper.WaitForAjaxControls(60);
            for (int l = 0; l < 20; l++) { cellData = PageObject_CreateCampaign.Create_Audience_ListView_Cell_Data_List(); }
            IList<IWebElement> columns = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
            if (!String.IsNullOrEmpty(campaignDate))
            {
                int expCount = 0;
                foreach (var item in columns)
                {
                    columnIndex = columnIndex + 1;
                    if (item.Text.Trim().Equals("UPDATE ON"))
                        break;
                }
                if (type.ToLower().Trim().Equals("between"))
                {
                    var date1 = Convert.ToDateTime(campaignDate);
                    var date2 = Convert.ToDateTime(Helper.GetText(cellData[columnIndex - 1]));
                    if(DateTime.Compare(date1, date2)<=0)
                        expCount = expCount + 1;
                }
                else if (campaignDate.Equals(Helper.GetText(cellData[columnIndex - 1])))
                {
                    expCount = expCount + 1;
                }
                columnIndex = 0;
                Assert.IsTrue(expCount >= 1, "System is not displayig data based on filter selection");
            }
        }
    }
}
