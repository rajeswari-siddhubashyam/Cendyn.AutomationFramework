using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.UI
{
    public class PageObject_ProposalSelect : Setup
    {
        private static readonly string PageName = Constants.ProposalSelect;

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/


        public static IWebElement Link_CheckAll()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalSelect_Link_CheckAll);
        }

        public static IWebElement Link_Clear()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_Link_Clear);
        }

        public static IWebElement Link_AddContract()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalSelect_Link_AddContract);
        }

        public static IWebElement Link_SelectVideo()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_Link_SelectVideo);
        }

        public static IWebElement TextBox_Attachment1()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_TextBox_Attachment1);
        }

        public static IWebElement Button_Browse_Attachment1()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_Button_Browse_Attachment1);
        }

        public static IWebElement TextBox_Attachment2()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_TextBox_Attachment2);
        }

        public static IWebElement Button_Browse_Attachment2()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_Button_Browse_Attachment2);
        }

        public static IWebElement TextBox_Attachment3()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_TextBox_Attachment3);
        }

        public static IWebElement Button_Browse_Attachment3()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_Button_Browse_Attachment3);
        }

        public static IWebElement TextBox_Attachment4()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_TextBox_Attachment4);
        }

        public static IWebElement Button_Browse_Attachment4()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_Button_Browse_Attachment4);
        }

        public static IWebElement TextBox_Attachment5()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_TextBox_Attachment5);
        }

        public static IWebElement Button_Browse_Attachment5()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_Button_Browse_Attachment5);
        }

        public static IWebElement TextBox_Attachment6()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_TextBox_Attachment6);
        }

        public static IWebElement Button_Browse_Attachment6()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_Button_Browse_Attachment6);
        }

        public static IWebElement Button_Upload()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_Button_Upload);
        }

        public static IWebElement Button_Back()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_Button_Back);
        }

        public static IWebElement Button_Next()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_Button_Next);
        }

        public static IWebElement CheckBox_Navigation_Honors()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalSelect_CheckBox_Navigation_Honors);
        }

        public static IWebElement Link_ViewYourVideo()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalSelect_Link_ViewYourVideo);
        }

        public static IWebElement Button_Cancel()
        {
            ScanPage(Constants.ProposalSelect);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalSelect_Button_Cancel);
        }
        
    }
}