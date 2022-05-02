using System.Reflection;
using eInsight.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eInsight.PageObject.UI
{
    public class PageObject_AudienceBuilder : Setup
    {

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        private static string PageName = Constants.AudienceBuilder;

        public static IWebElement AB_Button_Add()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AB_Button_Add);
        }
        public static IWebElement AB_Button_AddSearchField()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AB_Button_AddSearchField);
        }

        public static IWebElement AB_Checkbox_ShowInactive()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AB_Checkbox_ShowInactive);
        }
        public static IWebElement AB_Button_Reset()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AB_Button_Reset);
        }
        public static IWebElement AB_Button_Search()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AB_Button_Search);
        }
        public static IWebElement AB_CustomerDetailsSearchContent()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AB_CustomerDetailsSearchContent);
        }
        public static IWebElement AB_Grid_LastPublished()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AB_Grid_LastPublished);
        }
        public static IWebElement AB_Grid_LastSaved()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AB_Grid_LastSaved);
        }
        public static IWebElement AB_Grid_ButtonAction()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AB_Grid_ButtonAction);
        }

        public static IWebElement AB_Listbox_selectField()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AB_Listbox_selectField);
        }
        public static IWebElement AB_TextBox_FieldValue(int index)
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AB_TextBox_FieldValue.Replace("[i]", "[" + index + "]"));
        }

        public static IWebElement Click_ABGrid_ButtonDetail()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ABGrid_ButtonDetail);
        }
        public static IWebElement Click_ABGrid_AudienceClone()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_ABGrid_AudienceClone);
        }
        public static IWebElement Click_ABEdit_SavePublishButton()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ABEdit_SavePublishButton);
        }
        public static IWebElement Click_ABEdit_CancelButton()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ABEdit_CancelButton);
        }
        public static IWebElement AB_Grid_EditAudience()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AB_Grid_EditAudience);
        }
        public static IWebElement Click_ABEdit_FirstTime_TotalRecords()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ABEdit_FirstTime_TotalRecords);
        }
        public static IWebElement Click_ABEdit_TotalRecords()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_ABEdit_TotalRecords);
        }
        public static IWebElement Click_TotalCounts_Audience()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_TotalCounts_Audience);
        }
        public static IWebElement Click_ABEdit_StayOnPage()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ABEdit_StayOnPage);
        }
        public static IWebElement Click_ABEdit_LeavePage()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ABEdit_LeavePage);
        }
        public static IWebElement AB_IFrame()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AB_IFrame);
        }
    }
}