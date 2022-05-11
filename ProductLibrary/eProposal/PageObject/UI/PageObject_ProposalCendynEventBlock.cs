using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.UI
{
    public class PageObject_ProposalCendynEventBlock : Setup
    {
        private static readonly string PageName = Constants.ProposalCendynEventBlock;

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/


        public static IWebElement CheckBox_IncludeEventBlockInProposal()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository
                .ProposalCendynEventBlock_CheckBox_IncludeEventBlockInProposal);
        }

        public static IWebElement Link_EventDate()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Link_EventDate);
        }

        public static IWebElement Text_StartTime()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Text_StartTime);
        }

        public static IWebElement Text_EndTime()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Text_EndTime);
        }

        public static IWebElement Text_Name()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Text_Name);
        }

        public static IWebElement Text_Room()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Text_Room);
        }

        public static IWebElement Text_Type()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Text_Type);
        }

        public static IWebElement Text_RentalFee()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Text_RentalFee);
        }

        public static IWebElement Text_Guests()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Text_Guests);
        }

        public static IWebElement Text_Setup()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Text_Setup);
        }

        public static IWebElement Text_Notes()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Text_Notes);
        }

        public static IWebElement Button_Submit()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Button_Submit);
        }

        public static IWebElement Button_Cancel()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Button_Cancel);
        }

        public static IWebElement Text_EventBlockComments()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynEventBlock_Text_EventBlockComments);
        }

        public static IWebElement Link_EventBlockStoredContent1()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Link_EventBlockStoredContent1);
        }

        public static IWebElement Link_EventBlockStoredContent2()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Link_EventBlockStoredContent2);
        }

        public static IWebElement Link_AddEstimatedCosts()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Link_AddEstimatedCosts);
        }

        public static IWebElement RadioButton_EstimatedCosts_Include()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository
                .ProposalCendynEventBlock_RadioButton_EstimatedCosts_Include);
        }

        public static IWebElement Text_EstimatedCosts_Item()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Text_EstimatedCosts_Item);
        }

        public static IWebElement Text_EstimatedCosts_PricePerItems()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(
                ObjectRepository.ProposalCendynEventBlock_Text_EstimatedCosts_PricePerItems);
        }

        public static IWebElement Text_EstimatedCosts_NumberOfItems()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(
                ObjectRepository.ProposalCendynEventBlock_Text_EstimatedCosts_NumberOfItems);
        }

        public static IWebElement Text_EstimatedCosts_NumberOfDays()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository
                .ProposalCendynEventBlock_Text_EstimatedCosts_NumberOfDays);
        }

        public static IWebElement RadioButton_AdditionalFields_Include()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository
                .ProposalCendynEventBlock_RadioButton_AdditionalFields_Include);
        }

        public static IWebElement Text_AdditionalFields_Item()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Text_AdditionalFields_Item);
        }

        public static IWebElement Text_AdditionalFields_Amount()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Text_AdditionalFields_Amount);
        }

        public static IWebElement Button_Back()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynEventBlock_Button_Back);
        }

        public static IWebElement Button_Next()
        {
            ScanPage(Constants.ProposalCendynEventBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynEventBlock_Button_Next);
        }
    }
}