using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.UI
{
    class PageObject_eFaceTime : Setup
    {
            /*
            / These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
            */

        public static string PageName = Constants.eFaceTime;

        public static IWebElement eFaceTime_Link_Folder1()
        {
           ScanPage(Constants.eFaceTime);
           CurrentPageName = PageName;
           CurrentElementName = MethodBase.GetCurrentMethod().Name;
           return PageAction.Find_ElementXPath(ObjectRepository.eFaceTime_Link_Folder1);
        }

           
        public static IWebElement eFaceTime_Link_Preview()
        {
           ScanPage(Constants.eFaceTime);
           CurrentPageName = PageName;
           CurrentElementName = MethodBase.GetCurrentMethod().Name;
           return PageAction.Find_ElementXPath(ObjectRepository.eFaceTime_Link_Preview);
        }

        public static IWebElement eFaceTime_Link_Delete()
        {
           ScanPage(Constants.eFaceTime);
           CurrentPageName = PageName;
           CurrentElementName = MethodBase.GetCurrentMethod().Name;
           return PageAction.Find_ElementXPath(ObjectRepository.eFaceTime_Link_Delete);
        }

        public static IWebElement eFaceTime_Button_AddVideo()
        {
            ScanPage(Constants.eFaceTime);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eFaceTime_Button_AddVideo);
        }

        public static IWebElement eFaceTime_Text_NameYourVideo()
        {
            ScanPage(Constants.eFaceTime);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eFaceTime_Text_NameYourVideo);
        }

        public static IWebElement eFaceTime_Dropdown_SelectFolder()
        {
            ScanPage(Constants.eFaceTime);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eFaceTime_Dropdown_SelectFolder);
        }

        public static IWebElement eFaceTime_Button_YouTubeLink()
        {
            ScanPage(Constants.eFaceTime);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eFaceTime_Button_YouTubeLink);
        }

        public static IWebElement eFaceTime_Text_PasteLink()
        {
            ScanPage(Constants.eFaceTime);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eFaceTime_Text_PasteLink);
        }

        public static IWebElement eFaceTime_Button_SubmitLink()
        {
            ScanPage(Constants.eFaceTime);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eFaceTime_Button_SubmitLink);
        }
        
        public static IWebElement eFaceTime_Button_OkButton()
        {
            ScanPage(Constants.eFaceTime);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eFaceTime_Button_OkButton);
        }

        public static IWebElement eFaceTime_Link_Select()
        {
            ScanPage(Constants.eFaceTime);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eFaceTime_Link_Select);
        }

        public static IWebElement eFaceTime_Button_AttachYourVideo()
        {
            ScanPage(Constants.eFaceTime);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eFaceTime_Button_AttachYourVideo);
        }

        public static IWebElement eFaceTime_Button_UploadVideo()
        {
            ScanPage(Constants.eFaceTime);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eFaceTime_Button_UploadVideo);
        }

        public static IWebElement eFaceTime_Button_SelectVideos()
        {
            ScanPage(Constants.eFaceTime);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eFaceTime_Button_SelectVideos);
        }

        public static IWebElement eFaceTime_Button_ChooseFile()
        {
            ScanPage(Constants.eFaceTime);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.eFaceTime_Button_ChooseFile);
        }
    }
}
