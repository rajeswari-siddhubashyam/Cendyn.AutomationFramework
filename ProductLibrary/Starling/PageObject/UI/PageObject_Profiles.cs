using BaseUtility.PageObject;
using CHC.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CHC.PageObject.UI
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

        public static IWebElement ContactDetailstab()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ContactDetails);
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



