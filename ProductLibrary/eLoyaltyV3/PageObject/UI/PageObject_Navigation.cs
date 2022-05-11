using BaseUtility.PageObject;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;
using System.Reflection;


namespace eLoyaltyV3.PageObject.UI
//namespace AutomationBase.PageObject.UI
{
    public class PageObject_Navigation: Setup//Base.PageObject.UI.PageObject_Navigation
    {
        public static string PageName = Utility.Constants.Navigation;

        public static IWebElement Button_SignIn()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Button_SignIn);
        }
        public static IWebElement Click_Button_Back()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Button_Back);
        }

        public static IWebElement Button_JoinNow()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Button_JoinNow);
        }
        public static IWebElement Button_JoinNow1()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Button_JoinNow1);
        }

        public static IWebElement Link_SignIn()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_SignIn);
        }
        public static IWebElement Click_Link_SignIn()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_Sign_In);
        }
        public static IWebElement Link_Join()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_Join);
        }

        public static IWebElement Link_Join2()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Navigation_Link_Join2);
        }

        public static IWebElement Link_MyStays()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_MyStays);
        }

        public static IWebElement Link_MyProfile()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_MyProfile);
        }
        public static IWebElement Link_MyProfile1()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_MyProfile1);
        }
        public static IWebElement Link_Benefits()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_Benefits);
        }

        public static IWebElement Link_FAQ()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_FAQ);
        }

        public static IWebElement Link_ContactUs(string ProjectName)
        {
            if (ProjectName.Equals("Sarova") || ProjectName.Equals("EHPC"))
            {
                ScanPage(Constants.Navigation);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//a[@href='/en-GB/ContactUs']");
            }
            else if (ProjectName.Equals("AMR"))
            {
                ScanPage(Constants.Navigation);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//a[@href='/en-US/ContactUs#contactUs']");
            }
            else
            {
                ScanPage(Constants.Navigation);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_ContactUs);
            }
        }

        public static IWebElement Link_ContactUs2()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_ContactUs2);
        }

        public static IWebElement Link_Redeem()
        {
            if (ProjectName.Equals("HotelOrigami"))
            {
                ScanPage(Constants.Navigation);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//a[contains(text(),'Redeem')]");
            }
            else
            {
                ScanPage(Constants.Navigation);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_Redeem);
            }

        }

        public static IWebElement Link_MyActivity()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_MyActivity);
        }

        public static IWebElement Link_Summary()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_Summary);
        }

        //HotelIcon
        public static IWebElement Link_SignOut(string ProjectName)
        {
            if (ProjectName.Equals("Sarova"))
            {
                ScanPage(Constants.Navigation);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//a[contains(@href,'/en-GB/Common/Logout')]");
            }
            else if (ProjectName.Equals("Sacher"))
            {
                ScanPage(Constants.Navigation);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//a[contains(@href,'/en-US/Common/Logout')]");
            }
            else if (ProjectName.Equals("EHPC"))
            {
                ScanPage(Constants.Navigation);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//div[@class='navbar-collapseWrapper']//a[@class='far fa-sign-out']");
            }
            else
            {
                ScanPage(Constants.Navigation);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_SignOut);
            }
        }

        //public static IWebElement Link_SignOut2()
        //{
        //    ScanPage(Constants.Navigation);
        //    CurrentPageName = PageName;
        //    CurrentElementName = MethodBase.GetCurrentMethod().Name;
        //    return PageAction.Find_ElementLinkText(ObjectRepository.Navigation_Link_SignOut2);
        //}

        public static IWebElement Link_UpdateMyPreferences()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_UpdateMyPreferences);
        }

        public static IWebElement Link_UpdateMyProfile()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_UpdateMyProfile);
        }

        public static IWebElement Link_MySettings()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_MySettings);
        }

        public static IWebElement Button_ExpandCollapse()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Button_ExpandCollapse);
        }

        public static IWebElement Overview_MemberSinceDate()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Overview_MemberSinceDate);
        }

        public static IWebElement Overview_MemberShipLevel()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Overview_MemberShipLevel);
        }

        public static IWebElement Link_MyAccount()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_MyAccount);
        }

        public static IWebElement LinkText_MySettings(string ProjectName)
        {
            if (ProjectName.Equals("Bartell") || ProjectName.Equals("MyPlace") || ProjectName.Equals("HotelIcon"))
            {
                ScanPage(Constants.Navigation);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//a[@href='/en-US/Settings']");
            }
            if (ProjectName.Equals("Sarova"))
            {
                ScanPage(Constants.Navigation);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//a[@href='/en-GB/Settings']");
            }
            if (ProjectName.Equals("EHPC"))
            {
                ScanPage(Constants.Navigation);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//a[@href='/en-GB/Settings' and @class='far fa-cog']");
            }
            ////a[@href='/en-GB/Settings' and @class='far fa-cog']
            else
            {
                ScanPage(Constants.Navigation);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementLinkText(ObjectRepository.Navigation_LinkText_MySettings);
            }

        }

        public static IWebElement Link_Facebook()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_Facebook);
        }
        public static IWebElement Link_Twitter()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_Twitter);
        }


        public static IWebElement Link_Exclusives()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_Exclusives);
        }
        public static IWebElement SignUp_Button_Join()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignUp_Button_Join);
        }
        public static IWebElement Link_LoginExclusives()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_LoginExclusives);
        }

        public static IWebElement Link_ProgramOverview()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_ProgramOverview);
        }

        public static IWebElement Link_SpecialOffer()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_SpecialOffer);
        }

        public static IWebElement Link_FAQ1()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_FAQ1);
        }

        public static IWebElement Link_MyAward()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_MyAward);
        }
        public static IWebElement MyAwards_Text_Filter()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_MyAward_Filter);
        }
        public static IWebElement MyAwards_Redeem_Button()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Button_MyAward_Redeem);
        }
        public static IWebElement Link_Enroll()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_Enroll);
        }

        public static IWebElement Link_InviteFriends()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_InviteFriends);
        }
        public static IWebElement DOB_Error()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.DOB_Error);
        }
        public static IWebElement FirstName_Error()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.FirstName_Error);
        }
        public static IWebElement LastName_Error()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.LastName_Error);
        }
        public static IWebElement Email_Error()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Email_Error);
        }
        public static IWebElement Card_Error()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Card_Error);
        }
        public static IWebElement Password_Error()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Password_Error);
        }
        public static IWebElement ConfirmPassword_Error()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ConfirmPassword_Error);
        }
        public static IWebElement Captcha_Error()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Captcha_Error);
        }
        public static IWebElement Click_Contact_Link()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Contact_Link);
        }
        public static IWebElement Navigation_Link_MyAccount_Dropdown()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_MyAccount_Dropdown);
        }
    }
}
