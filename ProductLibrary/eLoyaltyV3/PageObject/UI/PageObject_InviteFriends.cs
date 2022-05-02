using System.Reflection;
using BaseUtility.PageObject;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;

namespace eLoyaltyV3.PageObject.UI
{
    class PageObject_InviteFriends : Setup
    {


        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        public static string PageName = Constants.InviteFriends;

        public static IWebElement Text_InviteFriends()
        {
            ScanPage(Constants.InviteFriends);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.InviteFriends_Text_InviteFriends);
        }

        public static IWebElement Button_SendMyInvitation()
        {
            ScanPage(Constants.InviteFriends);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.InviteFriends_Button_SendMyInvitation);
        }

        /// <summary>
        /// This will return the error message for mail to text box on Invite My Friend page   
        /// </summary>
        /// <returns></returns>
        public static IWebElement GetInviteMYFriend_Error()
        {
            ScanPage(Constants.InviteFriends);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.InviteFriends_Error_Message);
        }
        public static IWebElement EnterText_SendInvitation()
        {
            ScanPage(Constants.InviteFriends);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EnterText_SendInvitation);
        }
        public static IWebElement InviteFriendValidation_CaptchaError()
        {
            ScanPage(Constants.InviteFriends);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.InviteFriendValidation_CaptchaError);
        }

        public static IWebElement InviteFriendEmailValidation_Error()
        {
            ScanPage(Constants.InviteFriends);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.InviteFriendEmailValidation_Error);
        }

        public static IWebElement EnterText_SendInvitationMailContent()
        {
            ScanPage(Constants.InviteFriends);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EnterText_SendInvitationMailContent);
        }       
        public static IWebElement EnterText_SendInvitationMailContent_Error()
        {
            ScanPage(Constants.InviteFriends);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EnterText_SendInvitationMailContent_Error);
        }


    }
}
