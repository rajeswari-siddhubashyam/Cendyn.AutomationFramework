using BaseUtility.PageObject;
using CHC_Unified_Profile.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CHC_Unified_Profile.PageObject.UI
{
    class PageObject_Profiles : Setup
    {
        public static string PageName = Utility.Constants.Home;

        public static IWebElement Txt_FilterByEmail()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Filter_By_Email);
        }

        public static IWebElement Lnk_OrgSwitcher()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Org_Swithcer_Top_Nav);
        }

        public static IWebElement Ele_UnifiedProfileApp()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Unified_Profile_App);
        }

        public static IWebElement Btn_OrgSwitcher_Select()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Org_Swithcer_Select);
        }

        public static IWebElement Btn_SearchIcon()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Search_Icon);
        }

        public static IWebElement Btn_Filter()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Filter_Button);
        }

        public static IWebElement Btn_Sort()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Sort_Button);
        }

        public static IWebElement Verify_Emailontable()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.table);
        }

        public static IWebElement Ele_ViewProfile()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.View_Profile);
        }

        public static IWebElement VerifyApplybuttononfilter()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Filter_Applybutton);
        }

        public static IWebElement VerifyClearbuttononfilter()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Filter_Clearbutton);
        }

        public static IWebElement Btn_Home()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Button);
        }

        public static IWebElement Link_Help()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Help_Link);
        }

        public static IWebElement Check_Hometext()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Text_Homepage);
        }

        public static IWebElement Click_Ellipse()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Ellipse);
        }

        public static IList<IWebElement> AllColumns_OnTable()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Table_Allcolumns);
        }

        public static IWebElement Help_Scdhuleameeting_Newtab()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Help_ScheduleMeeting);
        }

        public static IWebElement Lnk_HelpMouseOver()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HelpMouseOver);
        }

        public static IWebElement Lnk_NeedHelp()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Link_Needhelp_signin);
        }

        public static IWebElement Lnk_Forgot()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.Link_ForgotPassword);
        }

        public static IWebElement Lnk_Recovery()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_RecoveryEmail);
        }

        public static IWebElement Lnk_Reset()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.Click_Reset_ViaEmail);
        }

        public static IWebElement Lnk_Backtosignin()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.Click_BackTo_Signin);
        }

        public static IWebElement Btn_Resetpassword()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.Click_Reset_Password);
        }

        public static IWebElement Txt_Newpassword()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_NewPassword);
        }

        public static IWebElement Txt_ConfirmPassword()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_ConfirmPassword);
        }

        public static IWebElement Lnk_Resetpassword()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Reset_Resetpassword);
        }

        public static IWebElement Txt_UnlockUsername()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Unlock_EmailUsername);
        }

        public static IWebElement Lnk_Unlock_SendEmail()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.Unlock_SendEmail);
        }

        public static IWebElement Lnk_Clcikon_Outlook_UnlockAccount()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.Outlook_UnlockAccount);
        }

        public static IWebElement Lnk_Clcikon_SignIn_UnlockAccount()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.NeedHelp_UnlockAccount);
        }

        public static IWebElement Lnk_LinkExpired()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UnlockAccount_LinkExpired);
        }

        public static IWebElement Txt_Email_LeaveBlank()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UserName_LeftBlank);
        }

        public static IWebElement Txt_OutLook()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.OutLook_Text);
        }

        public static IWebElement ContactDetailstab()
        {
            ScanPage(Constants.Profiles); 
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ContactDetails);
        }

        public static IWebElement View_Profile_ContactDetailstab()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.View_ContactDetails);
        }

        public static IWebElement View_Profile_Historytab()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ViewProfile_Historytab);
        }

        public static IWebElement VerifyApplybuttononSort()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Sort_Applybutton);
        }

        public static IWebElement VerifyClearbuttononSort()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Sort_Clearbutton);
        }

        public static IWebElement Txt_Profileidfieldcontainsfilter()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Profileidfield_ContainsFilter);
        }

        public static IWebElement Lnk_clickonProfilerecord()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clickonfistrecord);
        }

        public static IWebElement Btn_Click_on_Applybutton_Filter()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_on_applybutton_Filter);
        }

        public static IWebElement Txt_History_ChecktextonViewProfile()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Text_History);
        }

        public static IWebElement Txt_Summary_ChecktextonViewProfile()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Text_Summary);
        }

        public static IWebElement Txt_ContactDetails_ChecktextonViewProfile()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Text_ContactDetails);
        }

        public static IWebElement Txt_Profile_ChecktextonViewProfile()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Text_Profile);
        }

        public static IWebElement Txt_Reservation_ChecktextonViewProfile()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Text_Reservations);
        }

        public static IWebElement Txt_Status_Checktextonreservationindex()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Text_Statusonreservationindexpage);
        }

        public static IWebElement Lnk_clickonProfilerecordSecond()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clickonfistrecordsecondontable);
        }

        public static IWebElement VerifyProfilenameinviewprofile()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ViewProfileName);
        }

        public static IWebElement Verifyreservationidinviewreservation()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verifyviewreservationrecord);
        }

        public static IWebElement Reservationstab()
        {
            ScanPage(Constants.Reservations);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reservations_Tab);
        }

        public static IWebElement Viewprofilerecordonviewpage()
        {
            ScanPage(Constants.Reservations);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.View_Profilerecordon_Viewpage);
        }

        public static IWebElement Verifyreservtionrecord()
        {
            ScanPage(Constants.Reservations);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verifyreservationdetail);
        }

        public static IWebElement Reservationrecord()
        {
            ScanPage(Constants.Reservations);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reservationrecordontable);
        }

        public static IWebElement Sidenav_Applauncher()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Applauncher);
        }

        public static IWebElement FirstRecordonprofiletable()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clickonfistrecord);
        }

        public static IWebElement Applauncherbutton()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Applauncher);
        }

        public static IList<IWebElement> Applauncherapplicationsonapplauncher()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Applauncher_Applications);
        }
    }
}

