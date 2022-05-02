using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseUtility.Utility;
using Common;
using eInsight.PageObject.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace eInsight.AppModule.UI
{
    class CreateCampaign_Criteria : Helper
    {
        public static void Click_Button_Brand_RemoveFirstBrand()
        {
            ElementClick(PageObject_CreateCampaign_Criteria.Button_Brand_RemoveFirstBrand());
        }

        public static void Click_Button_Save()
        {
            ElementClick(PageObject_CreateCampaign_Criteria.Button_Save());
        }

        //public static void Click_Button_SaveAndContinue()
        //{
        //    ElementClick(PageObject_CreateCampaign_Criteria.Button_SaveAndContinue());
        //}

        public static void Click_Button_Clear()
        {
            ElementClick(PageObject_CreateCampaign_Criteria.Button_Clear());
        }

        public static void Click_Button_PropertyList_RemoveFirstPropertyList()
        {
            ElementClick(PageObject_CreateCampaign_Criteria.Button_PropertyList_RemoveFirstPropertyList());
        }

        public static void Click_Button_SeedList_RemoveFirstSeedList()
        {
            ElementClick(PageObject_CreateCampaign_Criteria.Button_SeedList_RemoveFirstSeedList());
        }

        public static void Click_Button_ForecastTargetAudience()
        {
            ElementClick(PageObject_CreateCampaign_Criteria.Button_ForecastTargetAudience());
        }

        public static void Click_Button_NewSegment_Top()
        {
            ElementClick(PageObject_CreateCampaign_Criteria.Button_NewSegment_Top());
        }

        public static void Click_Button_NewSegment_Bottom()
        {
            ElementClick(PageObject_CreateCampaign_Criteria.Button_NewSegment_Bottom());
        }

        public static void Click_Button_TransactionalSettings_HideShow()
        {
            ElementClick(PageObject_CreateCampaign_Criteria.Button_TransactionalSettings_HideShow());
        }

        public static void Click_Button_CollapseAll()
        {
            ElementClick(PageObject_CreateCampaign_Criteria.Button_CollapseAll());
        }

        public static void Click_Button_ExpandAll()
        {
            ElementClick(PageObject_CreateCampaign_Criteria.Button_ExpandAll());
        }

        public static void Click_Button_Segment_CollapseExpand()
        {
            ElementClick(PageObject_CreateCampaign_Criteria.Button_Segment_CollapseExpand());
        }

        public static void Click_Button_Segment_Close()
        {
            ElementClick(PageObject_CreateCampaign_Criteria.Button_Segment_Close());
        }

        public static void Click_Button_Segment_First_SelectAll()
        {
            ElementClick(PageObject_CreateCampaign_Criteria.Button_Segment_First_SelectAll());
        }

        public static void Click_Button_Segment_First_Clone()
        {
            ElementClick(PageObject_CreateCampaign_Criteria.Button_Segment_First_Clone());
        }

        public static void Click_Button_Segment_First_Remove()
        {
            ElementClick(PageObject_CreateCampaign_Criteria.Button_Segment_First_Remove());
        }

        public static void EnterText_Text_CampaignName(string text)
        {
            ElementEnterText(PageObject_CreateCampaign_Criteria.Text_CampaignName(), text);
        }

        private static void EnterText_Text_Brand(string text)
        {
            ElementEnterText(PageObject_CreateCampaign_Criteria.Text_Brand(), text);
        }

        private static void EnterText_Text_PropertyList(string text)
        {
            ElementEnterText(PageObject_CreateCampaign_Criteria.Text_PropertyList(), text);
        }

        private static void EnterText_Text_SeedList(string text)
        {
            ElementEnterText(PageObject_CreateCampaign_Criteria.Text_SeedList(), text);
        }

        public static void EnterText_Text_Segment_SegmentDescription(string text)
        {
            ElementEnterText(PageObject_CreateCampaign_Criteria.Text_Segment_SegmentDescription(), text);
        }

        private static void EnterText_Text_Segment_DataSource(string text)
        {
            ElementEnterText(PageObject_CreateCampaign_Criteria.Text_Segment_DataSource(), text);
        }

        public static void SelectFromDropDown_DropDown_TransactionalSettings_ReservationEvent(string text)
        {
            ElementSelectFromDropDown(PageObject_CreateCampaign_Criteria.DropDown_TransactionalSettings_ReservationEvent(), text);
        }

        public static void SelectFromDropDown_DropDown_Segment_Include(string text)
        {
            ElementSelectFromDropDown(PageObject_CreateCampaign_Criteria.DropDown_Segment_Include(), text);
        }

        public static void SelectFromDropDown_DropDown_Segment_AndOrNandNor(string text)
        {
            ElementSelectFromDropDown(PageObject_CreateCampaign_Criteria.DropDown_Segment_AndOrNandNor(), text);
        }

        public static void Select_CheckBox_TransactionalSettings_EmailType_FirstResult()
        {
            ElementSelected(PageObject_CreateCampaign_Criteria.CheckBox_TransactionalSettings_EmailType_FirstResult());
        }

        public static void UnSelect_CheckBox_TransactionalSettings_EmailType_FirstResult()
        {
            ElementNOTSelected(PageObject_CreateCampaign_Criteria.CheckBox_TransactionalSettings_EmailType_FirstResult());
        }

        public static void Select_CheckBox_TransactionalSettings_EmailType_SecondResult()
        {
            ElementSelected(PageObject_CreateCampaign_Criteria.CheckBox_TransactionalSettings_EmailType_SecondResult());
        }

        public static void UnSelect_CheckBox_TransactionalSettings_EmailType_SecondResult()
        {
            ElementNOTSelected(PageObject_CreateCampaign_Criteria.CheckBox_TransactionalSettings_EmailType_SecondResult());
        }

        public static void Select_CheckBox_TransactionalSettings_UseFirstAvailableSelectedEmailType()
        {
            ElementSelected(PageObject_CreateCampaign_Criteria.CheckBox_TransactionalSettings_UseFirstAvailableSelectedEmailType());
        }

        public static void UnSelect_CheckBox_TransactionalSettings_UseFirstAvailableSelectedEmailType()
        {
            ElementNOTSelected(PageObject_CreateCampaign_Criteria.CheckBox_TransactionalSettings_UseFirstAvailableSelectedEmailType());
        }

        public static void Select_CheckBox_TransactionalSettings_IncludeUnsubscribe()
        {
            ElementSelected(PageObject_CreateCampaign_Criteria.CheckBox_TransactionalSettings_IncludeUnsubscribe());
        }

        public static void UnSelect_CheckBox_TransactionalSettings_IncludeUnsubscribe()
        {
            ElementNOTSelected(PageObject_CreateCampaign_Criteria.CheckBox_TransactionalSettings_IncludeUnsubscribe());
        }

        /// <summary>
        /// This method will select a brand from the Brand selection.
        /// </summary>
        /// <param name="brand">The brand to select</param>
        public static void SelectBrand(string brand)
        {
            EnterText_Text_Brand(brand + Keys.Enter);
        }

        /// <summary>
        /// This method will select a property list from the property list selection.
        /// </summary>
        /// <param name="propertyList">The property list to select</param>
        public static void SelectPropertyList(string propertyList)
        {
            EnterText_Text_PropertyList(propertyList + Keys.Enter);
        }

        /// <summary>
        /// This method will select a seed list from the seed list selection.
        /// </summary>
        /// <param name="seedList">The seed list to select</param>
        public static void SelectSeedList(string seedList)
        {
            EnterText_Text_SeedList(seedList + Keys.Enter);
        }

        /// <summary>
        /// This method will select a data Source from the data Source selection.
        /// </summary>
        /// <param name="dataSource">The data Source to select</param>
        public static void SelectdataSource(string dataSource)
        {
            EnterText_Text_Segment_DataSource(dataSource + Keys.Enter);
        }

        public static void InsertAgentProfileAffiliationIntoSegment()
        {
            IWebElement affiliation = CommonMethod.Driver.FindElement(By.XPath("//div[contains(.,'Affiliation')]"));
            IWebElement dropElement = CommonMethod.Driver.FindElement(By.XPath("//div[@class='segment-content']"));
            var builder = new Actions(CommonMethod.Driver);

            CommonMethod.Driver.FindElement(By.XPath("//div[contains(.,'Agent Profile')]")).Click();
            
            builder.ClickAndHold(affiliation);
            builder.MoveToElement(dropElement);
            builder.Perform();
            AddDelay(500);
            builder.Release(dropElement);
            builder.Perform();

        }

    }

}
