using BaseUtility.PageObject;
using eLoyaltyV3.Utility;

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace eLoyaltyV3.PageObject.Admin
{
    class PageObject_Admin : Utility.Setup
    {
        public static string PageName = Constants.Admin;
        #region[Admin]

        public static IWebElement Admin_Text_UserName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Text_UserName);
        }

        public static IWebElement Admin_Text_Password()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Text_Password);
        }
        public static IWebElement Dropdown_Value_Country()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Dropdown_Value_Country);
        }

        public static IWebElement Admin_Button_Login()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Button_Login);
        }



        public static IWebElement Admin_Text_SearchEmail()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Text_SearchEmail);
        }

        public static IWebElement Admin_Button_MemberSearch()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Button_MemberSearch);
        }

        public static IWebElement Admin_Value_Email(string ProjectName)
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@class='memberpage']//span[contains(@class , 'email' )]");

        }
        public static IWebElement Admin_Value_EmailId()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//*[@id='memberSearchResults']//td[2])[1]");

        }
        public static IWebElement Admin_Button_ClearSearch()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Button_ClearSearch);
        }
        public static IWebElement Admin_LoyaltyeGifts_Marketing_Partner_Tab()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyeGifts_Marketing_Partner_Tab);
        }
        public static IWebElement Admin_LoyaltyeGifts_Marketing_Partner_Edit()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyeGifts_Marketing_Partner_Edit);
        }
        public static IWebElement Admin_LoyaltyeGifts_Marketing_Partner_Notify()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyeGifts_Marketing_Partner_Notify);
        }
        public static IWebElement Admin_LoyaltyeGifts_Marketing_Partner_Notify_Save()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyeGifts_Marketing_Partner_Notify_Save);
        }

        public static IWebElement Admin_Button_ViewMember(string Projectname)
        {
            if (ProjectName.Equals("AquaAston") || ProjectName.Equals("Origami") || ProjectName.Equals("MyPlace") || ProjectName.Equals("HotelIcon") || ProjectName.Equals("OmniHotels") || ProjectName.Equals("PublicHotel"))
            {
                ScanPage(Constants.Admin);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//*[@id='memberSearchResults']/tbody/tr/td[10]/a");
            }
            else if (ProjectName.Equals("WoodLoch"))
            {
                ScanPage(Constants.Admin);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//*[@id='memberSearchResults']/tbody/tr[1]/td[8]/a");
            }
            else if (ProjectName.Equals("Fraser"))
            {
                ScanPage(Constants.Admin);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//*[@id='memberSearchResults']/tbody/tr[1]/td[13]/a/span");
            }
            else
            {
                ScanPage(Constants.Admin);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.Admin_Button_ViewMember);
            }
        }

        public static IWebElement Admin_Text_ViewMember()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Text_ViewMember);
        }

        public static IWebElement Admin_ActivationEmail()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Link_ActivationEmail);
        }

        public static IWebElement Admin_WelcomeEmail()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Link_WelcomeEmail);
        }

        public static IWebElement Admin_Button_Activation_Save()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Button_Activation_Save);
        }

        public static IWebElement Admin_Button_Welcome_Save()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Button_Welcome_Save);
        }

        public static IWebElement Dropdown_MemberType()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Dropdown_MemberType);
        }

        public static IWebElement Textbox_MemberNumber()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Textbox_MemberNumber);
        }
        public static IWebElement Admin_Textbox_Last_Name()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Textbox_Last_Name);
        }
        public static IWebElement Textbox_Lastname()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Textbox_Lastname);
        }

        public static IWebElement Textbox_Firstname()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Textbox_Firstname);
        }
        public static IWebElement Textbox_First_Name()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Textbox_First_Name);
        }

        public static IWebElement Textbox_Email()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Textbox_Email);
        }

        public static IWebElement Textbox_Street()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Textbox_Street);
        }

        public static IWebElement Textbox_City()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Textbox_City);
        }

        public static IWebElement Textbox_Zip()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Textbox_Zip);
        }

        public static IWebElement Dropdown_Country()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Dropdown_Country);
        }
        public static IWebElement Admin_Users_Text_Password()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Users_Text_Password);
        }

        public static IWebElement Textbox_Country(string Projectname)
        {
            if (ProjectName.Equals("Bartell"))
            {
                ScanPage(Constants.Admin);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//*[@id='search-fields']/div[1]/div/div/button");
            }
            else
            {
                ScanPage(Constants.Admin);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//*[@id='search-fields']/div[9]/div/div/button");
            }
        }

        public static IWebElement Input_Country()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='search-fields']/div[9]/div/div/div/div/input");

        }
        public static IWebElement DropDown_value_State()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.DropDown_value_State);
        }

        public static IWebElement Textbox_State()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//button[@data-id='state']/following-sibling::div[@class='dropdown-menu open']//input[@type='text']");
        }

        public static IWebElement Dropdown_State()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Dropdown_State);
        }

        public static IWebElement Dropdown_State_2()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Dropdown_State_2);
        }
        public static IWebElement Admin_Attribute_state()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Attribute_state);
        }
        public static IWebElement Admin_MemberInformation_Send_Email_Popup_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberInformation_Send_Email_Popup_Close);
        }


        public static IWebElement Dropdown_AwardName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Dropdown_AwardName);
        }

        public static IWebElement Textbox_AwardNumber()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Textbox_AwardNumber);
        }

        public static IWebElement Textbox_CardName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Textbox_CardName);
        }

        public static IWebElement Textbox_Company()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Textbox_Company);
        }

        public static IWebElement Textbox_Phone()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Textbox_Phone);
        }

        public static IWebElement Dropdown_MemberStatus()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Dropdown_MemberStatus);
        }

        public static IWebElement Value_MemberType()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Value_MemberType);
        }

        public static IWebElement Value_MemberNumber()
        {
            if (ProjectName.Equals("Almanac"))
            {
                ScanPage(Constants.Admin);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.Admin_Value_MemberNumber_Almanac);
            }
            else
            {
                ScanPage(Constants.Admin);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.Admin_Value_MemberNumber);
            }
        }

        public static IWebElement Value_Email()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Value_Email);
        }

        public static IWebElement Value_FullName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;

            if (ProjectName.Equals("SH") || ProjectName.Equals("AquaAston"))
            {
                return PageAction.Find_ElementXPath("//table[@id='memberSearchResults']//th[contains(@aria-label,'Full Name')]//following::td[3]");
            }
            else if (ProjectName.Equals("HotelIcon") || (ProjectName.Equals("AdareManor") || ProjectName.Equals("Bartell") || ProjectName.Equals("MyPlace") || ProjectName.Equals("PublicHotel") || ProjectName.Equals("Fraser")|| ProjectName.Equals("AMR")))
            {
                return PageAction.Find_ElementXPath("//table[@id='memberSearchResults']//th[contains(@aria-label,'Full Name')]//following::td[4]");
            }
            else
            {
                return PageAction.Find_ElementXPath(ObjectRepository.Admin_Value_FullName);
            }
        }

        public static IWebElement Value_Address()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            if (ProjectName.Equals("HotelOrigami"))
                return PageAction.Find_ElementXPath("//table[@id='memberSearchResults']//th[contains(@aria-label,'Address')]//following::td[4]");
            else
                return PageAction.Find_ElementXPath(ObjectRepository.Admin_Value_Address);
        }

        public static IWebElement Value_Phone()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Value_Phone);
        }

        public static IWebElement Value_CardName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Value_CardName);
        }

        public static IWebElement Value_MemberLevel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Value_MemberLevel);
        }

        public static IWebElement Value_Company()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Value_Company);
        }

        public static IWebElement Value_Status()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Value_Status);
        }

        public static IWebElement Textbox_Filter()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Textbox_Filter);
        }


        public static IWebElement Admin_Menu_LoyaltyAwards()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Menu_LoyaltyAwards);
        }
        public static IWebElement Admin_Menu_LoyaltyEgift()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Loyalty_Egift_tab);
        }
        public static IWebElement Click_LoyaltyeGift_AccountBalance()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Loyalty_Egift_Account_Balance);
        }
        public static IWebElement Admin_Search_LoyaltyAwards()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Text_Award_Search);
        }

        public static IWebElement Admin_Button_Awards_Add()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Button_Awards_Add);
        }

        public static IWebElement Admin_Text_Award_Name()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Text_Award_Name);
        }

        public static IWebElement Admin_Text_Award_Code()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Text_Award_Code);
        }

        public static IWebElement Admin_Text_Date_StartDate()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Text_Award_StartDate);
        }

        public static IWebElement Admin_Text_Date_EndDate()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Text_Award_EndDate);
        }

        public static IWebElement Admin_DropDown_AwardType()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_DropDown_Awardtype);
        }

        public static IWebElement Admin_Text_DaysActive()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Text_DaysActive);
        }

        public static IWebElement Admin_Text_AdvanceDeliveryDays()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Text_AdvanceDeliveryDays);
        }

        public static IWebElement Admin_DropDown_MinQualifiedStay()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_DropDown_MinQualifiedStay);
        }

        public static IWebElement Admin_DropDown_MemberLevel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_DropDown_MemberLevel);
        }

        public static IWebElement Admin_DropDown_EmailName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_DropDown_EmailName);
        }

        public static IWebElement Admin_Award_Savebtn()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Award_Savebtn);
        }

        public static IWebElement Admin_Button_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Button_Close);
        }

        public static IWebElement Admin_MemberInfo_MemberStays()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberInfo_MemberStays);
        }

        public static IWebElement Admin_MemberInfo_SearchMemberStays()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberInfo_SearchMemberStays);
        }

        public static IWebElement Admin_DropDown_NightCycle()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_DropDown_NightCycle);
        }

        public static IWebElement Admin_DropDown_NightAwarded()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_DropDown_NightAwarded);
        }

        public static IWebElement Admin_DropDown_NightExpMonth()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_DropDown_NightExpMonth);
        }

        public static IWebElement Admin_DropDown_NightHotels()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_DropDown_NightHotels);
        }

        public static IWebElement Enter_Text_MaxAwardperMember()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Text_MaxAwardperMember);
        }

        public static IWebElement Admin_Arrow_Next()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Arrow_Next);
        }

        public static IWebElement Admin_Arrow_Previous()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Arrow_Previous);
        }
        public static IWebElement ForgotPassword_LinkText()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ForgotPassword_LinkText);
        }
        public static IWebElement Admin_Textbox_Email()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Recovery_Email);
        }
        public static IWebElement ForgotPassword_Recover()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminorgotPassword_Recovery);
        }
        public static IWebElement NewPassword()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_NewPassword);
        }
        public static IWebElement NewPasswordConfirm()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_NewPasswordConfirm);
        }
        public static IWebElement SubmitNewPassword()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SubmitNewPassword);
        }

        public static IWebElement Admin_MemberBatchUpload_Tab()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberBatchUpload_Tab);
        }
        public static IWebElement Admin_MemberBatchUpload_BtachRegistration_SubTab()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberBatchUpload_BtachRegistration_SubTab);
        }
        public static IWebElement Click_MemberBatchUpdate()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MemberBatchUpdate);
        }
        public static IWebElement BatchUpdate_DownloadTemplete()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.BatchUpdate_DownloadTemplete);
        }
        public static IWebElement BatchUpload_DownloadTemplete()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.BatchUpload_DownloadTemplete);
        }
        public static IWebElement BatchUpdate_UploadTemplete()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.BatchUpdate_UploadTemplete);

        }
        public static IWebElement BatchUpload_UploadFile()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.BatchUpload_UploadFile);

        }

        public static IWebElement BatchUpdate_UploadFile()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.BatchUpdate_UploadFile);

        }


        public static IWebElement BatchUpdate_UploadFiles()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.BatchUpdate_UploadFiles);

        }
        public static IWebElement Click_MemberBatchUpdate_UploadDateAndTime()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MemberBatchUpdate_UploadDateAndTime);

        }

        public static IWebElement MemberUpload_Refreshbutton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Refreshbutton);

        }
        public static IWebElement MemberUpdate_Refreshbutton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UpdateRefreshbutton);

        }
        
        public static IWebElement MemberUploadedDetails()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MemberUploadedDetails);
        }
        public static IWebElement MemberUpdateDetails()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MemberUpdateDetails);
        }
        
        public static IWebElement BatchUpload_ClickonUpload()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.BatchUpload_ClickonUpload);

        }
        public static IWebElement BatchUpdate_UpdateTemplete()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.BatchUpdate_UpdateTemplete);

        }

        public static IWebElement Click_CloseButton_OnMemberBatchUpdateDetailsPopup()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_CloseButton_OnMemberBatchUpdateDetailsPopup);
        }

        public static IWebElement Click_MemberSearchTab()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MemberSearchTab);
        }

        public static IWebElement Text_MemberShipId()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Text_MemberShipId);
        }

        public static IWebElement BatchUploadRegistraion()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.BatchUploadRegistraion_Upload);
        }
        public static IWebElement Admin_MemberInformation_Tab()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberInformation_Tab);
        }
        public static IWebElement Admin_MemberAward_PreviousButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberAward_Previous_button);
        }
        public static IWebElement Click_LoyaltyRules_MemberLevelRules_Tab()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_MemberLevelRules_Tab);
        }
        public static IWebElement Click_LoyaltyRules_MemberLevelRules_AddRule()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_MemberLevelRules_AddRule);
        }
        public static IWebElement Click_LoyaltyRules_MemberLevelRules_Filters()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_MemberLevelRules_Filters);
        }
        public static IWebElement Click_LoyaltyRules_MemberLevelRules_AddRule_RefferalCode()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_MemberLevelRules_AddRule_RefferalCode);
        }
        public static IWebElement Click_LoyaltyRules_MemberLevelRules_AddRule_QualifyingNights()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_MemberLevelRules_AddRule_QualifyingNights);
        }
        public static IWebElement Click_LoyaltyRules_MemberLevelRules_AddRule_StayType()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_MemberLevelRules_AddRule_StayType);
        }
        public static IWebElement Click_LoyaltyRules_MemberLevelRules_AddRule_NewLevel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_MemberLevelRules_AddRule_NewLevel);
        }
        public static IWebElement Click_LoyaltyRules_MemberLevelRules_AddRule_CancelButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_MemberLevelRules_AddRule_CancelButton);
        }
        public static IWebElement Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton);
        }
        public static IWebElement Click_LoyaltyRules_MemberLevelRules_EditButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_MemberLevelRules_EditButton);
        }
        public static IWebElement Click_LoyaltyRules_MemberLevelRules_DeleteButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_MemberLevelRules_DeleteButton);
        }
        public static IWebElement Click_LoyaltyRules_MemberLevelRules_PrevButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_MemberLevelRules_PrevButton);
        }
        public static IWebElement Click_LoyaltyRules_MemberLevelRules_NextButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_MemberLevelRules_NextButton);
        }
        public static IWebElement Click_LoyaltyRules_MemberLevelRules_DeleteConfirmButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_MemberLevelRules_DeleteConfirmButton);
        }
        public static IWebElement Click_LoyaltyRules_MemberLevelRules_PaginationDropdown()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_MemberLevelRules_PaginationDropdown);
        }
        public static IWebElement Get_LoyaltyRules_MemberLevelRules_PaginationDropdown(int value)
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='table-fasttrack-rules_length']//option[@value = '"+value.ToString()+"']");
        }
        public static IWebElement Click_LoyaltyRules_MemberLevelRules_DeleteCancle()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_MemberLevelRules_DeleteCancle);
        }
        public static IWebElement Click_LoyaltyRules_PointsEarningRule_RuleRestriction()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_PointsEarningRule_RuleRestriction);
        }
        public static IWebElement Click_LoyaltyRules_PointsEarningRule_RuleRestriction_ChannelCodeValue()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_PointsEarningRule_RuleRestriction_ChannelCodeValue);
        }
        public static IWebElement Get_PointsEarningRule_GridName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_PointsEarningRule_GridName);
        }
        public static IWebElement Get_PointsEarningRule_GridPriority()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_PointsEarningRule_GridPriority);
        }
        #endregion

        #region[Admin_Navigation]
        public static IWebElement Tab_MemberTransactions()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Tab_MemberTransactions);
        }
        public static IWebElement Tab_PointsHistory()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Tab_PointsHistory);
        }

        public static IWebElement Tab_Invites()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Tab_Invites);
        }
        public static IWebElement Admin_Subtab_CommonMethod(string subtabname)
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//a[contains(text(),'"+subtabname+"')]");
        }
        

        public static IWebElement Tab_Redemptions()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Tab_Redemptions);
        }

        public static IWebElement Tab_AdminUpdates()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Tab_AdminUpdates);
        }
        public static IWebElement Click_AdminUpdates_Button_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AdminUpdates_Button_Close);
        }
        public static IWebElement Tab_MemberAwards()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Tab_MemberAwards);
        }

        public static IWebElement Menu_LoyaltySetup()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Menu_LoyaltySetup);
        }

        public static IWebElement Menu_Home()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Menu_Home);
        }

        public static IWebElement Menu_Users()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Menu_Users);
        }
        public static IWebElement Submenu_Users_setting()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_submenu_Users_setting);
        }
        public static IWebElement Menu_EmailSetUp()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Menu_EmailSetup);
        }

        public static IWebElement Menu_LoyaltyAwards()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Menu_LoyaltyAwards);
        }

        public static IWebElement Menu_LoyaltyRules()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Menu_LoyaltyRules);
        }

        public static IWebElement Menu_ManualMerge()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Menu_ManualMerge);
        }

        public static IWebElement Menu_Redeem()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Menu_Redeem);
        }


        public static IWebElement Tab_MemberStay()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Tab_MemberStays);
        }

        public static IWebElement SubTab_TransactionReason()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetup_SubTab_TransactionReason);
        }

        public static IWebElement SubTab_SignUpSources()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetup_SubTab_SignUpSources);
        }

        public static IWebElement SubTab_TermsAndConditions()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetup_SubTab_TermsAndConditions);
        }

        public static IWebElement SubTab_Offers()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetup_SubTab_Offers);
        }

        public static IWebElement SubTab_PointsEarningRules()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_SubTab_PointsEarningRules);
        }

        public static IWebElement SubTab_QualifyingRules()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_SubTab_QualifyingRules);
        }
       
        public static IWebElement Admin_Menu_ContentManagment_Tab()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Menu_ContentManagment_Tab);
        }
        public static IWebElement Admin_Menu_LoyaltyMapping_Tab()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Menu_LoyaltyMapping_Tab);
        }
        public static IWebElement Click_AddAward()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddAward);
        }

        public static IWebElement Click_Member_Level_Email_No_Button()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Member_Level_Email_No_Button);
        }

        public static IWebElement MemberLevel_CrossButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MemberLevel_CrossButton);
        }
        #endregion

        #region[Admin_MemberInformation]
        public static IWebElement Value_MemberStatus()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberInformation_Value_MemberStatus);
        }

        public static IWebElement Value_Information_MemberLevel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberInformation_Value_MemberLevel);
        }

        public static IWebElement MemberInformation_Dropdown_MemberStatus()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberInformation_Dropdown_MemberStatus);
        }

        public static IWebElement Icon_Right()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberInformation_Icon_Right);
        }

        public static IWebElement Icon_Cross()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberInformation_Icon_Cross);
        }

        public static IWebElement MemberInformation_Value_PointsBalance()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberInformation_Value_PointsBalance);
        }

        public static IWebElement MemberInformation_Value_MemberLogin()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberInformation_Value_MemberLogin);
        }

        public static IWebElement MemberInformation_Text_UserLogin()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberInformation_Text_UserLogin);
        }

        public static IWebElement MemberInformation_Button_Update()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberInformation_Button_Update);
        }

        public static IWebElement MemberInformation_ResetLogin_Icon_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberInformation_ResetLogin_Icon_Close);
        }

        public static bool MemberLevel_Email_Overlay()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            if (PageAction.Find_ElementXPath(ObjectRepository.MemberLevel_Email_Overlay).Displayed)
                return true;
            else
                return false;
        }
        public static IWebElement Admin_Update_View_Overlay_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Update_View_Overlay_Close);
        }
        public static IWebElement MemberInformation_Value_ActivationEmail()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberInformation_Value_ActivationEmail);
        }

        public static IWebElement Admin_ActivationEmail_Icon_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ActivationEmail_Icon_Close);
        }

        public static IWebElement Click_ExpirationDate()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Click_ExpirationDate);
        }

        public static IWebElement Click_MemberAwardStatus()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MemberAwardStatus);

        }

        public static IWebElement Click_ExpirationDateSubmit()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Click_ExpirationDateSubmit);
        }

        public static IWebElement Click_AdminSendResend()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AdminSendResend);

        }

        public static IWebElement click_ResendAwardEmail_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.click_ResendAwardEmail_Close);
        }

        public static IWebElement Admin_WelcomeEmail_Icon_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_WelcomeEmail_Icon_Close);
        }

        public static IWebElement MemberInformation_ActivationEmail_UserLogin()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberInformation_ActivationEmail_UserLogin);
        }

        public static IWebElement MemberInformation_Value_WelcomeEmail()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberInformation_Value_WelcomeEmail);
        }

        public static IWebElement MemberInformation_WelcomeEmail_UserLogin()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberInformation_WelcomeEmail_UserLogin);
        }

        public static IWebElement MemberInformation_Value_MemberPortal()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberInformation_Value_MemberPortal);
        }

        public static IWebElement MemberInformation_Value_EmailStatus()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberInformation_Value_EmailStatus);
        }

        public static IWebElement MemberInformation_Value_ActivatedDate()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberInformation_Value_ActivatedDate);
        }

        public static IWebElement MemberInformation_Activation_Button_SendEmail()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberInformation_Activation_Button_SendEmail);
        }

        public static IWebElement MemberInformation_Welcome_Button_SendEmail()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberInformation_Welcome_Button_SendEmail);
        }

        public static IWebElement Admin_MemberInformation_Dropdown_EmailStatus()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberInformation_Dropdown_EmailStatus);
        }

        public static IWebElement Admin_MemberInformation_Value_Email()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberInformation_Value_Email);
        }
        public static IWebElement Select_MembershipLevel_Entries()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_MembershipLevel_Entries);
        }
        
        #endregion

        #region[Admin_MemberTransaction]
        public static IWebElement Button_AddTransactions()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberTransaction_Button_AddTransactions);
        }

        public static IWebElement Text_FilterSearch()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberTransaction_Text_FilterSearch);
        }

        public static IWebElement Dropdown_Entries()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberTransaction_Dropdown_Entries);
        }

        public static IWebElement Dropdown_TransactionReason()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberTransaction_Dropdown_TransactionReason);
        }

        public static IWebElement Text_Points()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberTransaction_Text_Points);
        }

        public static IWebElement Text_InternalComments()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberTransaction_Text_InternalComments);
        }

        public static IWebElement Text_ExpirationDate()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberTransaction_Text_ExpirationDate);
        }

        public static IWebElement DatePicker_ExpirationDate()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberTransaction_DatePicker_ExpirationDate);
        }

        public static IWebElement Text_CommentsToGuest()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberTransaction_Text_CommentsToGuest);
        }

        public static IWebElement RadioButton_SendEmailToMember()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberTransaction_RadioButton_SendEmailToMember);
        }

        public static IWebElement RadioButton_AddCommentsToEmail()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberTransaction_RadioButton_AddCommentsToEmail);
        }

        public static IWebElement Text_MemberEmail()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberTransaction_Text_MemberEmail);
        }

        public static IWebElement Text_BCC()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberTransaction_Text_BCC);
        }

        public static IWebElement RadioButton_FraserHospitality()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberTransaction_RadioButton_FraserHospitality);
        }

        public static IWebElement RadioButton_Hotel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberTransaction_RadioButton_Hotel);
        }

        public static IWebElement Button_Save()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberTransaction_Button_Save);
        }

        public static IWebElement Dropdown_Hotel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberTransaction_Dropdown_Hotel);
        }

        public static IWebElement Text_Hotel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberTransaction_Text_Hotel);
        }

        public static IWebElement Dropdown_Options_Hotel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberTransaction_Dropdown_TransactionReason);
        }

        public static IWebElement MemberTransaction_Dropdown_Pagination()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberTransaction_Dropdown_Pagination);
        }

        public static IWebElement MemberTransaction_Icon_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberTransaction_Icon_Close);
        }

        public static IWebElement MemberTransaction_Arrow_Next()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberTransaction_Arrow_Next);
        }

        public static IWebElement MemberTransaction_Arrow_Previous()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberTransaction_Arrow_Previous);
        }
        #endregion

        #region[Admin_MemberStay]
        public static IWebElement Dropdown_Pagination()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Dropdown_Pagination);
        }

        public static IWebElement Admin_Dropdown_Entries()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Dropdown_Entries);
        }

        public static IWebElement Admin_Icon_Next()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Icon_Next);
        }

        public static IWebElement Admin_Icon_Previous(string Projectname)
        {
            if (Projectname.Equals("Sandylane") || ProjectName.Equals("Bartell") || ProjectName.Equals("Fraser") || ProjectName.Equals("MyPlace") || ProjectName.Equals("Origami") || ProjectName.Equals("Virgin") || ProjectName.Equals("IndependentCollection"))
            {
                ScanPage(Constants.Admin);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//div[@id='staysMember001_paginate']//a[text()='Pre']");
            }
            else
            {
                ScanPage(Constants.Admin);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.Admin_Icon_Previous);
            }

        }

        public static IWebElement Admin_Text_PageNumber(string text)
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//div[@id='staysMember001_paginate']//a[text()='" + text + "']");
        }

        public static IWebElement Admin_MemberStay_Button_SearchStay()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberStay_Button_SearchStay);
        }

        public static IWebElement Admin_MemberStay_Button_Search()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberStay_Button_Search);
        }

        public static IWebElement Admin_MemberStay_Dropdown_Property()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberStay_Dropdown_Property);
        }

        public static IWebElement Admin_MemberStay_Value_Property()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberStay_Value_Property);
        }

        public static IWebElement Admin_MemberStay_Value_DepartureFrom()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberStay_Value_DepartureFrom);
        }

        public static IWebElement Admin_MemberStay_Value_DepartureTo()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberStay_Value_DepartureTo);
        }

        public static IWebElement Admin_MemberStay_Text_FirstName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberStay_Text_FirstName);
        }

        public static IWebElement Admin_MemberStay_Text_LastName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberStay_Text_LastName);
        }

        public static IWebElement Admin_MemberStay_Text_ReservationNumber()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberStay_Text_ReservationNumber);
        }

        public static IWebElement Admin_MemberStay_Data_ReservationNumber()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberStay_Data_ReservationNumber);
        }

        public static IWebElement Admin_MemberStay_Data_Arrival(string ProjectName ="")
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            if(ProjectName.Equals("Bartell"))
                return PageAction.Find_ElementXPath(ObjectRepository.Admin_Bartell_MemberStay_Data_Arrival);
            else
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberStay_Data_Arrival);
        }

        public static IWebElement Admin_MemberStay_Data_Departure()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberStay_Data_Departure);
        }

        public static IWebElement Admin_MemberStay_Data_Hotel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberStay_Data_Hotel);
        }

        public static IWebElement Admin_MemberStay_Tab_MemberID()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberStay_Tab_MemberID);
        }

        public static IWebElement Admin_MemberStay_Checkbox_Select()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberStay_Checkbox_Select);
        }

        public static IWebElement Admin_MemberStay_Button_Save()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberStay_Button_Save);
        }

        public static IWebElement Admin_MemberStay_Button_Back()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberStay_Button_Back);
        }
        public static IWebElement Enter_ReservationNumber()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_ReservationNumber);
        }

        public static IWebElement Admin_MemberStay_Text_Filter()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberStay_Text_Filter);
        }
        public static IWebElement Admin_Memberupload_Text_Filter()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Memberupload_Text_Filter);
        }
        public static IWebElement Admin_Memberupdate_Text_Filter()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Memberupdate_Text_Filter);
        }
        
        #endregion

        #region[Admin_Updates]
        public static IWebElement AdminUpdates_Dropdown_Entries()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_AdminUpdates_Dropdown_Entries);
        }

        public static IWebElement AdminUpdates_Text_Filter()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_AdminUpdates_Text_Filter);
        }

        public static IWebElement AdminUpdates_Icon_View1()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_AdminUpdates_Icon_View1);
        }

        public static IWebElement AdminUpdates_Button_Next()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_AdminUpdates_Button_Next);
        }

        public static IWebElement AdminUpdates_Button_Last()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_AdminUpdates_Button_Last);
        }

        public static IWebElement AdminUpdates_Button_Prev(string Projectname)
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_AdminUpdates_Button_Prev);
            /*if(Projectname.Equals("AquaAston")|| Projectname.Equals("ALH")||Projectname.Equals("OmniHotels"))
            {
                ScanPage(Constants.Admin);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//div[@id='tbAdminUpdates001_paginate']//a[text()='Pre']");
            }
            else
            {
                ScanPage(Constants.Admin);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.Admin_AdminUpdates_Button_Prev);
            }*/

        }

        public static IWebElement AdminUpdates_Button_First()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_AdminUpdates_Button_First);
        }

        #endregion

        #region[Admin_MemberAwards]
        public static IWebElement MemberAwards_Button_AddAward()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberAwards_Button_AddAward);
        }

        public static IWebElement MemberAwards_Dropdown_SelectAward()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberAwards_Dropdown_SelectAward);
        }

        public static IWebElement MemberAwards_Text_Comment()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_MemberAwards_Text_Comment);
        }

        public static IWebElement MemberAwards_Button_Save()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberAwards_Button_Save);
        }

        public static IWebElement MemberAwards_Icon_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberAwards_Icon_Close);
        }

        public static IWebElement MemberAwards_Text_Filter()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_MemberAwards_Text_Filter);
        }
        public static IWebElement Dropdown_SelectStatus()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Dropdown_SelectStatus);
        }
        public static IWebElement SelectStatusCheck()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SelectStatusCheck);
        }
        public static IWebElement DeleteSelectedStatus()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.DeleteSelectedStatus);
        }
        public static IWebElement LoyaltyeGift_RemainingBalance()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.LoyaltyeGift_RemainingBalance);
        }
        #endregion

        #region[LoyaltySetUp_TransactionReason]
        public static IWebElement TransactionReason_Button_AddReason()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TransactionReason_Button_AddReason);
        }

        public static IWebElement TransactionReason_Text_Code()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltySetUp_TransactionReason_Text_Code);
        }

        public static IWebElement TransactionReason_Text_Filter()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TransactionReason_Text_Filter);
        }

        public static IWebElement TransactionReason_Text_Reason()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltySetUp_TransactionReason_Text_ReasonName);
        }

        public static IWebElement TransactionReason_Button_Save()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TransactionReason_Button_Save);
        }

        public static IWebElement TransactionReason_Button_Cancel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TransactionReason_Button_Cancel);
        }

        public static IWebElement TransactionReason_Icon_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TransactionReason_Icon_Close);
        }

        public static IWebElement TransactionReason_Icon_Edit()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TransactionReason_Icon_Edit);
        }
        #endregion 

        #region[LoyaltySetUp_SignUpSource]

        public static IWebElement SignUpSource_Button_AddSource()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_SignUpSource_Button_AddSource);
        }

        public static IWebElement SignUpSource_Text_Filter()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_SignUpSource_Text_Filter);
        }

        public static IWebElement SignUpSource_Icon_Edit()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_SignUpSource_Icon_Edit);
        }

        public static IWebElement SignUpSource_Text_SignUpSourceCode()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltySetUp_SignUpSource_Text_SignUpSourceCode);
        }

        public static IWebElement SignUpSource_Text_SignUpSourceName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltySetUp_SignUpSource_Text_SignUpSourceName);
        }

        public static IWebElement SignUpSource_Button_Save()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_SignUpSource_Button_Save);
        }

        public static IWebElement SignUpSource_Button_Cancel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_SignUpSource_Button_Cancel);
        }

        public static IWebElement SignUpSource_Button_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_SignUpSource_Button_Close);
        }

        #endregion[LoyaltySetUp_SignUpSource]

        #region[LoyaltySetUp_TermsAndCondition]

        public static IWebElement TermsAndCondition_Button_AddTermsAndCondition()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TermsAndCondition_Button_AddTermsAndCondition);
        }
        public static IWebElement Admin_LoyaltySetUp_TermsAndCondition_Add_TermsAndCondition()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TermsAndCondition_Add_TermsAndCondition);
         }

        public static IWebElement TermsAndCondition_Text_Filter()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TermsAndCondition_Text_Filter);
        }

        public static IWebElement TermsAndCondition_Icon_Edit()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TermsAndCondition_Icon_Edit);
        }

        public static IWebElement TermsAndCondition_Icon_Delete()
        {
            if(ProjectName.Equals("Fraser") || ProjectName.Equals("HotelOrigami"))
            {
                ScanPage(Constants.Admin);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//button[@class='btn btn-secondary btnRemove']");
             }
            else
            {
                 ScanPage(Constants.Admin);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TermsAndCondition_Icon_Delete);
            }
        }

        public static IWebElement TermsAndCondition_Text_Title()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TermsAndCondition_Text_Title);
        }

        public static IWebElement TermsAndCondition_Button_Save()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltySetUp_TermsAndCondition_Button_Save);
        }
        public static IWebElement Admin_LoyaltySetUp_TermsAndCondition_Description()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TermsAndCondition_Description);
        }


        public static IWebElement TermsAndCondition_Button_Cancel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TermsAndCondition_Button_Cancel);
        }

        public static IWebElement TermsAndCondition_Icon_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltySetUp_TermsAndCondition_Icon_Close);
        }

        public static IWebElement TermsAndCondition_Text_Description()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId("tinymce");
        }

        public static IWebElement TermsAndCondition_Button_Yes()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TermsAndCondition_Button_Yes);
        }

        public static IWebElement TermsAndCondition_Button_No()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TermsAndCondition_Button_No);
        }

        #endregion[LoyaltySetUp_TermsAndCondition]

        #region[LoyaltySetUp_PointsEarningRules]

        public static IWebElement PointsEarningRules_Button_AddRule()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Button_AddRule);
        }

        public static IWebElement PointsEarningRules_Text_Filter()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Text_Filter);
        }

        public static IWebElement PointsEarningRules_Icon_Edit()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Icon_Edit);
        }

        public static IWebElement PointsEarningRules_Text_Name()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Text_Name);
        }

        public static IWebElement PointsEarningRules_Text_DisplayName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Text_DisplayName);
        }

        public static IWebElement PointsEarningRules_Text_Description()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Text_Description);
        }

        public static IWebElement PointsEarningRules_Dropdown_BasedOn()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Dropdown_BasedOn);
        }

        public static IWebElement PointsEarningRules_Text_StartDate()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Text_StartDate);
        }

        public static IWebElement PointsEarningRules_Div_StartDate()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='datepicker - startdate']");
        }

        public static IWebElement PointsEarningRules_Text_EndDate()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Text_EndDate);
        }

        public static IWebElement PointsEarningRules_Text_Priority()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Text_Priority);
        }

        public static IWebElement PointsEarningRules_Dropdown_RuleType()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Dropdown_RuleType);
        }

        public static IWebElement PointsEarningRules_Dropdown_For()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Dropdown_For);
        }

        public static IWebElement PointsEarningRules_Text_PointsEarned()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Text_PointsEarned);
        }

        public static IWebElement PointsEarningRules_Text_Per()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Text_Per);
        }

        public static IWebElement PointsEarningRules_Dropdown_CaculatedOn()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Dropdown_CaculatedOn);
        }

        public static IWebElement PointsEarningRules_Dropdown_RevenueType()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Dropdown_RevenueType);
        }

        public static IWebElement PointsEarningRules_Text_IncludeMemberLevel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            if (ProjectName.Equals("Bartell"))
                return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Text_IncludeMemberLevel1);
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Text_IncludeMemberLevel);

        }

        public static IWebElement PointsEarningRules_Dropdown_IncludeMemberLevel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Dropdown_IncludeMemberLevel);
        }

        public static IWebElement PointsEarningRules_Button_Save()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Button_Save);
        }

        public static IWebElement PointsEarningRules_Button_Cancel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Button_Cancel);
        }

        public static IWebElement PointsEarningRules_Icon_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Icon_Close);
        }

        public static IWebElement PointsEarningRules_Text_PointsExpiryMonth()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Text_PointsExpiryMonth);
        }

        public static IWebElement PointsEarningRules_Dropdown_()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyRules_PointsEarningRules_Icon_Close);
        }

        #endregion[LoyaltySetUp_PointsEarningRules]

        #region[LoyaltySetUp_Offers]

        public static IWebElement LoyaltySetUp_Offers_Button_AddOffers()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_AddOffers);
        }

        public static IWebElement LoyaltySetUp_Offers_Text_Filter()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Text_Filter);
        }

        public static IWebElement LoyaltySetUp_Offers_Text_Title()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltySetUp_Offers_Text_Title);
        }
        public static IWebElement Admin_AdminUpdates_Search_Clear()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_AdminUpdates_Search_Clear);
        }
        public static IWebElement LoyaltySetUp_Offers_Text_Description()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltySetUp_Offers_Text_Description);
        }

        public static IWebElement LoyaltySetUp_Offers_Text_VisibilityStart()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Text_VisibilityStart);
        }

        public static IWebElement LoyaltySetUp_Offers_Text_VisibilityEnd()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Text_VisibilityEnd);
        }

        public static IWebElement LoyaltySetUp_Offers_Text_PromotionStart()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Text_PromotionStart);
        }

        public static IWebElement LoyaltySetUp_Offers_Text_PromotionEnd()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Text_PromotionEnd);
        }

        public static IWebElement LoyaltySetUp_Offers_Icon_Edit()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//*[@id='offersTable']//following::button[contains(text(),'Edit')])[1]");
        }

        public static IWebElement LoyaltySetUp_Offers_Icon_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Icon_Close);
        }

        public static IWebElement LoyaltySetUp_Offers_Icon_Image()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Icon_Image);
        }

        public static IWebElement LoyaltySetUp_Offers_Button_Save()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_Save);
        }

        public static IWebElement LoyaltySetUp_Offers_Button_Cancel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_Cancel);
        }

        public static IWebElement LoyaltySetUp_Offers_Button_Yes()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_Yes);
        }

        public static IWebElement LoyaltySetUp_Offers_Button_No()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_No);
        }

        public static IWebElement LoyaltySetUp_Offers_Dropdown_MemberLevel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Dropdown_MemberLevel);
        }

        public static IWebElement LoyaltySetUp_Offers_Text_MemberLevel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Text_MemberLevel);
        }

        public static IWebElement LoyaltySetUp_Offers_Button_SelectAll()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_SelectAll);
        }

        public static IWebElement LoyaltySetUp_Offers_Button_DeselectAll()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_DeselectAll);
        }

        public static IWebElement LoyaltySetUp_Offers_Button_BrowseImage()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_BrowseImage);
        }

        public static IWebElement LoyaltySetUp_Offers_Button_SaveImage()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_SaveImage);
        }

        public static IWebElement LoyaltySetUp_Offers_Button_CancelImage()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_CancelImage);
        }

        public static IWebElement LoyaltySetUp_Offers_Button_AddAnotherPromotion()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_AddAnotherPromotion);
        }

        public static IWebElement LoyaltySetUp_Offers_Text_PromotionCode()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltySetUp_Offers_Text_PromotionCode);
        }

        public static IWebElement LoyaltySetUp_Offers_Text_ButtonText()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltySetUp_Offers_Text_ButtonText);
        }

        public static IWebElement LoyaltySetUp_Offers_Iframe_Description()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltySetUp_Offers_Iframe_Description);
        }

        public static IWebElement LoyaltySetUp_Offers_Button_SavePromotion()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_SavePromotion);
        }

        public static IWebElement LoyaltySetUp_Offers_Button_CancelPromotion()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_CancelPromotion);
        }

        public static IWebElement LoyaltySetUp_Offers_Dropdown_HotelSelection(string Projectname)
        {
            if (Projectname.Equals("IndependentCollection"))
            {
                ScanPage(Constants.Admin);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//*[@id='promo-modal']/div/div/div[2]/div/div[4]/div/div/button");
            }
            else
            {
                ScanPage(Constants.Admin);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Dropdown_HotelSelection);
            }

        }

        public static IWebElement LoyaltySetUp_Offers_Value_HotelSelection()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Value_HotelSelection);
        }

        public static IWebElement LoyaltySetUp_Offers_Button_SavePromotionConfirm()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_SavePromotionConfirm);
        }

        public static IWebElement LoyaltySetUp_Offers_Button_SavePromotionCancel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_SavePromotionCancel);
        }

        public static IWebElement LoyaltySetUp_Offers_Button_EditPromotion()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_EditPromotion);
        }
        public static IWebElement Click_LoyaltySetUp_Promotion_Filter()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltySetUp_Promotion_Filter);
        }

        public static IWebElement LoyaltySetUp_Offers_Button_DeletePromotion()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_DeletePromotion);
        }

        public static IWebElement Click_Member_Level_Email_Yes_Button()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Member_Level_Email_Yes_Button);
        }
        //Adding new method as due to the xpath is different for other test cases 05/20/2021
        public static IWebElement LoyaltySetUp_Offers_Button_DeleteYes()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_DeleteYes);
        }

        public static IWebElement LoyaltySetUp_Offers_Button_DeleteNo()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Button_DeleteNo);
        }

        public static IWebElement LoyaltySetUp_Offers_Icon_PromotionDeleteClose()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Icon_PromotionDeleteClose);
        }
        public static IWebElement Admin_LoyaltySetUp_Offers_Pagination_Dropdown()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Pagination_Dropdown);
        }
        public static IWebElement Admin_LoyaltySetUp_Offers_Pagination_Prev_Button()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Pagination_Prev_Button);
        }
        public static IWebElement Admin_LoyaltySetUp_Offers_Pagination_Next_Button()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_Offers_Pagination_Next_Button);
        }
        public static IWebElement Get_Admin_LoyaltySetUp_Offers_Pagination_Dropdown(int value)
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='offersTable_length']//option[@value = '" + value.ToString() + "']");
            
        }
        public static IWebElement Click_Admin_LoyaltySetUp_Offers_Page(int value)
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='offersTable_paginate']//a[contains(text(),'"+value.ToString()+"')]");

        }

        #endregion[LoyaltySetUp_Offers]

        #region[Admin_LoyaltyAwards]

        public static IWebElement Admin_LoyaltyAwards_Button_Add()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltyAwards_Button_Add);
        }

        public static IWebElement Admin_LoyaltyAwards_Text_Filter()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_Text_Filter);
        }

        public static IWebElement Admin_LoyaltyAwards_Icon_Edit()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_Icon_Edit);
        }

        public static IWebElement Admin_LoyaltyAwards_Text_AwardName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltyAwards_Text_AwardName);
        }

        public static IWebElement Admin_LoyaltyAwards_Text_AwardCode()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltyAwards_Text_AwardCode);
        }

        public static IWebElement Admin_LoyaltyAwards_Text_StartDate()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltyAwards_Text_StartDate);
        }

        public static IWebElement Admin_LoyaltyAwards_Text_EndDate()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltyAwards_Text_EndDate);
        }

        public static IWebElement Admin_LoyaltyAwards_Dropdown_AwardType()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_Dropdown_AwardType);
        }
        
           public static IWebElement Admin_LoyaltyAwards_Dropdown_ExpMonth()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_Dropdown_ExpMonth);
        }
          public static IWebElement Admin_LoyaltyAwards_Dropdown_ExpDay()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_Dropdown_ExpDay);
        }

        public static IWebElement Admin_LoyaltyAwards_Dropdown_ExpYear()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_Dropdown_ExpYear);
        }

        public static IWebElement Admin_LoyaltyAwards_Dropdown_AdminMemberStatus()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_Dropdown_AdminMemberStatus);

        }
        public static IWebElement Admin_LoyaltyAwards_Button_Save()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltyAwards_Button_Save);
        }

        public static IWebElement Admin_LoyaltyAwards_Button_Cancel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltyAwards_Button_Cancel);
        }

        public static IWebElement Admin_LoyaltyAwards_Icon_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltyAwards_Icon_Close);
        }

        public static IWebElement Admin_LoyaltyAwards_BirthdayAward_Text_DaysActive()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltyAwards_BirthdayAward_Text_DaysActive);
        }

        public static IWebElement Admin_LoyaltyAwards_BirthdayAward_Text_AdvanceDeliveryDays()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltyAwards_BirthdayAward_Text_AdvanceDeliveryDays);
        }

        public static IWebElement Admin_LoyaltyAwards_BirthdayAward_Text_MinQualifiedStay()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_BirthdayAward_Text_MinQualifiedStay);
        }

        public static IWebElement Admin_LoyaltyAwards_BirthdayAward_Dropdown_MemberLevel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_BirthdayAward_Dropdown_MemberLevel);
        }

        public static IWebElement Admin_LoyaltyAwards_BirthdayAward_Text_MemberLevel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_BirthdayAward_Text_MemberLevel);
        }

        public static IWebElement Admin_LoyaltyAwards_BirthdayAward_Dropdown_EmailName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_BirthdayAward_Dropdown_EmailName);
        }

        public static IWebElement Admin_LoyaltyAwards_NightBasedAward_Text_NightCycle()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltyAwards_NightBasedAward_Text_NightCycle);
        }

        public static IWebElement Admin_LoyaltyAwards_NightBasedAward_Dropdown_NightAwarded()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_NightBasedAward_Dropdown_NightAwarded);
        }

        public static IWebElement Admin_LoyaltyAwards_NightBasedAward_Text_NightAwarded()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_NightBasedAward_Text_NightAwarded);
        }

        public static IWebElement Admin_LoyaltyAwards_NightBasedAward_Dropdown_AwardExpMonth()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_NightBasedAward_Dropdown_AwardExpMonth);
        }

        public static IWebElement Admin_LoyaltyAwards_NightBasedAward_Dropdown_MemberLevel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_NightBasedAward_Dropdown_MemberLevel);
        }

        public static IWebElement Admin_LoyaltyAwards_NightBasedAward_Text_MemberLevel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_NightBasedAward_Text_MemberLevel);
        }

        public static IWebElement Admin_LoyaltyAwards_NightBasedAward_Text_MaxAwardPerNight()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_LoyaltyAwards_NightBasedAward_Text_MaxAwardPerNight);
        }

        public static IWebElement Admin_LoyaltyAwards_NightBasedAward_Dropdown_Hotel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_NightBasedAward_Dropdown_Hotel);
        }

        public static IWebElement Admin_LoyaltyAwards_NightBasedAward_Text_Hotel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_NightBasedAward_Text_Hotel);
        }

        public static IWebElement Admin_Text_PointsCost()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Text_PointsCost);
        }

        public static IWebElement Admin_CheckBox_Use_As_EGift()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_CheckBox_Use_As_EGift);
        }

        public static IWebElement Admin_LoyaltyAwards_Member_Level_DeselectAll()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_Member_Level_DeselectAll);
        }
        public static IWebElement Admin_LoyaltyAwards_Member_Level_ClickDDM()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_Member_Level_ClickDDM);
        }
        public static IWebElement Admin_LoyaltyAwards_Member_Level_SelectAll()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_Member_Level_SelectAll);
        }

        public static IWebElement Admin_Menu_LoyaltyeGifts()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Menu_LoyaltyeGifts);
        }


        public static IWebElement Admin_DropDown_AwardExpMonth()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_DropDown_AwardExpMonth);
        }
        public static IWebElement Admin_LoyaltyAwards_Member_Level()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_Member_Level);
        }
        public static IWebElement Click_Admin_AutomatedSwitch()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Admin_AwardStatusSwitch);
        }
        public static IWebElement Click_Admin_AwardStatusSwitch()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Admin_AwardStatusSwitch);
        }
        public static IWebElement Admin_LoyaltyAwards_Text_Points()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyAwards_Text_Points);
        }


        #endregion[Admin_LoyaltyAwards]

        #region[Admin_LoyaltyeGifts]
        public static IWebElement Admin_LoyaltyeGifts_Button_AddeGift()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyeGifts_Button_AddeGift);
        }
        public static IWebElement Admin_LoyaltyeGifts_Name()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyeGifts_Name);
        }

        public static IWebElement Admin_LoyaltyeGifts_Marketing_Partner()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyeGifts_Marketing_Partner);
        }
        public static IWebElement Admin_LoyaltyeGifts_Marketing_Partner_Input()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyeGifts_Marketing_Partner_Input);
        }
        public static IWebElement Admin_LoyaltyeGifts_Award()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyeGifts_Award);
        }
        public static IWebElement Admin_LoyaltyeGifts_Choose_Catalog()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyeGifts_Choose_Catalog);
        }
        public static IWebElement Admin_LoyaltyeGifts_Card_Amount()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyeGifts_Card_Amount);
        }
        public static IWebElement Admin_LoyaltyeGifts_Button_Add()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltyeGifts_Button_Add);
        }

        #endregion[Admin_LoyaltyeGifts]

        #region[Admin_EmailSetUp]

        public static IWebElement Admin_EmailSetUp_Text_Filter()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_EmailSetUp_Text_Filter);
        }

        public static IWebElement Admin_EmailSetUp_Icon_Edit()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_EmailSetUp_Icon_Edit);
        }

        public static IWebElement Admin_EmailSetUp_Text_EmailName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_EmailSetUp_Text_EmailName);
        }

        public static IWebElement Admin_EmailSetUp_Text_EmailSubject()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_EmailSetUp_Text_EmailSubject);
        }

        public static IWebElement Admin_EmailSetUp_Text_EmailContent()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_EmailSetUp_Text_EmailContent);
        }

        public static IWebElement Admin_EmailSetUp_Text_TermsAndCondition()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_EmailSetUp_Text_TermsAndCondition);
        }

        public static IWebElement Admin_EmailSetUp_RadioButton_EmailStatus_Active()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_EmailSetUp_RadioButton_EmailStatus_Active);
        }

        public static IWebElement Admin_EmailSetUp_RadioButton_EmailStatus_InActive()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_EmailSetUp_RadioButton_EmailStatus_InActive);
        }

        public static IWebElement Admin_EmailSetUp_Button_Save()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_EmailSetUp_Button_Save);
        }

        public static IWebElement Admin_EmailSetUp_Button_Cancel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_EmailSetUp_Button_Cancel);
        }

        #endregion[Admin_EmailSetUp]

        #region[Admin_Users]

        public static IWebElement Admin_Users_Text_Search()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Users_Text_Search);
        }

        public static IWebElement Admin_Users_Text_Firstname()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Users_Text_Firstname);
        }

        public static IWebElement Admin_Users_Text_Lastname()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_Users_Text_Lastname);
        }

        public static IWebElement Admin_Users_Dropdown_UserTitle()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Users_Dropdown_UserTitle);
        }

        public static IWebElement AdminForgotPassword_Recovery()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminorgotPassword_Recovery);
        }
        public static IWebElement Admin_ForgotPassword_Recover()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ForgotPassword_Recover);
        }
        public static IWebElement Admin_Users_Dropdown_PropertyName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Users_Dropdown_PropertyName);
        }

        public static IWebElement Admin_Users_Dropdown_UserPermission()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Users_Dropdown_UserPermission);
        }

        public static IWebElement Admin_Users_Text_UserLogin()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Users_Text_UserLogin);
        }
     
        public static IWebElement Admin_Users_Button_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Users_Button_Close);
        }

        public static IWebElement Admin_Users_Button_Edit()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Users_Button_Edit);
        }

        public static IWebElement Admin_Users_Button_Delete()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Users_Button_Delete);
        }

        public static IWebElement Admin_Users_Button_Save()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Users_Button_Save);
        }

        public static IWebElement Admin_Users_Button_AddUsers()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Users_Button_AddUsers);
        }

        public static IWebElement Admin_Users_Button_SetPassword()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//a[contains(text(),'Set Password')]");
        }
      

        #endregion[Admin_Users]

        #region[Admin_ManualMerge]

        public static IWebElement Admin_ManualMerge_Text_MemberID()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_Text_MemberID);
        }

        public static IWebElement Admin_ManualMerge_Text_Firstname()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_Text_Firstname);
        }

        public static IWebElement Admin_ManualMerge_Text_Lastname()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_Text_Lastname);
        }

        public static IWebElement Admin_ManualMerge_Text_Email()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_Text_Email);
        }

        public static IWebElement Admin_ManualMerge_Text_Street()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_Text_Street);
        }

        public static IWebElement Admin_ManualMerge_Text_City()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_Text_City);
        }

        public static IWebElement Admin_ManualMerge_Text_Zip()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_Text_Zip);
        }

        public static IWebElement Admin_ManualMerge_Button_SearchMember()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_Button_SearchMember);
        }
        public static IWebElement Admin_ManualMerge_MemberMerge_SubTab()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_MemberMerge_SubTab);
        }
        public static IWebElement Admin_ManualMerge_Button_ClearSearch()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_Button_ClearSearch);
        }

        public static IWebElement Admin_ManualMerge_Button_Review()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_Button_Review);
        }

        public static IWebElement Admin_ManualMerge_Button_Cancel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_Button_Cancel);
        }

        public static IWebElement Admin_ManualMerge_Button_Merge()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_Button_Merge);
        }

        public static IWebElement Admin_ManualMerge_Icon_Select1()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_Icon_Select1);
        }
        public static IWebElement Admin_ManualMerge_Icon_Select1(string id)
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//td[contains(text(),'"+id+"')]//preceding::input[1])[1]");
        }

        public static IWebElement Admin_ManualMerge_Tab_AccountWinner1()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_Tab_AccountWinner1);
        }

        public static IWebElement Admin_ManualMerge_RadioButton_AccountWinner1()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_RadioButton_AccountWinner1);
        }

        public static IWebElement Admin_ManualMerge_RadioButton_AccountWinner2()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_RadioButton_AccountWinner2);
        }

        public static IWebElement Admin_ManualMerge_Button_Back()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Admin_ManualMerge_Button_Back);
        }

        public static IWebElement Admin_ManualMergeReview_Button_Merge()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMergeReview_Button_Merge);
        }

        public static IWebElement Admin_ManualMergeReview_Button_Confirm()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMergeReview_Button_Confirm);
        }

        public static IWebElement Admin_ManualMergeReview_Button_Cancel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMergeReview_Button_Cancel);
        }

        public static IWebElement Admin_ManualMerge_SubTab_ManualMerge()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_SubTab_ManualMerge);
        }

        public static IWebElement Admin_ManualMerge_Value_AccountWinner1_Email()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_Value_AccountWinner1_Email);
        }

        public static IWebElement Admin_ManualMerge_Value_AccountWinner2_Email()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_Value_AccountWinner2_Email);
        }

        public static IWebElement Admin_ManualMerge_Value_Status()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_ManualMerge_Value_Status);
        }
    
        #endregion[Admin_ManualMerge]

        #region[Admin_Redeem]
        public static IWebElement Admin_Menu_Redeem_Edit()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Menu_Redeem_Edit);
        }
        public static IWebElement Admin_Menu_Redeem_Dropdown_Connect_To()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Menu_Redeem_Dropdown_Connect_To);
        }
        public static IWebElement Admin_Menu_Redeem_Button_Save()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_Menu_Redeem_Button_Save);
        }

        public static IWebElement Button_Add_Redemption()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Button_Add_Redemption);
        }
        public static IWebElement Name_InputBox_Add_Redemption()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Name_InputBox_Add_Redemption);
        }

        public static IWebElement ConnectTo_InputBox_Add_Redemption()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ConnectTo_InputBox_Add_Redemption);
        }

        public static IWebElement Click_On_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_On_Close);
        }

        public static IWebElement Button_InputBox_Add_Redemption()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Button_InputBox_Add_Redemption);
        }

        public static IWebElement Activation_Email_Link_Button()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activation_Email_Link_Button);
        }

        public static IWebElement Activation_Email_Link()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activation_Email_Link);
        }

        public static IWebElement ForgotPassword_Email_Link()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ForgotPassword_Email_Link);
        }

        public static IWebElement Redeem_FilterSearch()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Redeem_FilterSearch);
        }
        public static IWebElement Get_RedeemptionName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_RedeemptionName);
        }
        public static IWebElement Get_AwardLinkName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_AwardLinkName);
        }
      
        #endregion[Admin_Redeem]
        #region[Admin_Member_Setup]
        public static IWebElement Click_MembershipSetup_Tab()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_MembershipSetup_Tab);
        }
        public static IWebElement Click_MemberLevel_SubTab()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MemberLevel_SubTab);
        }
        public static IWebElement MembershipSetup_AddMemershipLevel_Button()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.MembershipSetup_AddMemershipLevel_Button);
        }
        public static IWebElement AddMemershipLevel_MembershipLevel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AddMemershipLevel_MembershipLevel);
        }
        public static IWebElement AddMemershipLevel_MembershipCode()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AddMemershipLevel_MembershipCode);
        }
        public static IWebElement AddMemershipLevel_LevelOrder()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AddMemershipLevel_LevelOrder);
        }
        public static IWebElement AddMemershipLevel_CanBeProcessedByService_DDM()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AddMemershipLevel_CanBeProcessedByService_DDM);
        }
        public static IWebElement Click_AddMemershipLevel_CancelButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_AddMemershipLevel_CancelButton);
        }
        public static IWebElement Click_AddMemershipLevel_SaveButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_AddMemershipLevel_SaveButton);
        }
        public static IWebElement Click_AddMemershipLevel_EditButton(string membershipLevelName)
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//*[contains(text(),'" + membershipLevelName + "')]//following::button[contains(text(),'Edit')])[1]");
        }
        public static IWebElement Click_AddMemershipLevel_DeleteButton(string membershipLevelName)
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//*[contains(text(),'"+ membershipLevelName + "')]//following::button[contains(text(),'Delete')])[1]");
        }
        public static IWebElement Click_DeleteMemershipLevel_SubmitButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_DeleteMemershipLevel_SubmitButton);
        }
        public static IWebElement Click_DeleteMemershipLevel_CancelButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_DeleteMemershipLevel_CancelButton);
        }
        
        public static IWebElement Click_AddMemershipLevel_Close()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_AddMemershipLevel_Close);
        }

        public static IWebElement Click_Memberlevelrule_Tab()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Memberlevelrule_Tab);
        }
        public static IWebElement Click_AddRule_Button()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddRule_Button);
        }
        public static IWebElement Select_MemberLevel_Dropdown()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_MemberLevel_Dropdown);
        }
        public static IWebElement Select_RuleType_Dropdown()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_RuleType_Dropdown);
        }
        public static IWebElement Select_StayType_Dropdown()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_StayType_Dropdown);
        }
        public static IWebElement Select_DefaultRule_Dropdown()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_DefaultRule_Dropdown);
        }
        public static IWebElement Enter_MonthPeriod_TextBox()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_MonthPeriod_TextBox);
        }
        public static IWebElement Enter_QualifyingNight_TextBox()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_QualifyingNight_TextBox);
        }
        public static IWebElement Enter_StayProperties_TextBox()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_StayProperties_TextBox);
        }
        public static IWebElement Enter_QualifiedStay_TextBox()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_QualifiedStay_TextBox);
        }
        public static IWebElement Enter_CheckedOutStay_TextBox()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_CheckedOutStay_TextBox);
        }
        public static IWebElement Enter_Points_TextBox()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Points_TextBox);
        }
        public static IWebElement Enter_Revenue_TextBox()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Revenue_TextBox);
        }
        public static IWebElement Click_MembershipLevelSave_Button()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MembershipLevelSave_Button);
        }
        public static IWebElement Click_MembershipLevelCancel_Button()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MembershipLevelCancel_Button);
        }
        public static IWebElement Click_MembershipLevelClose_Icon()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MembershipLevelClose_Icon);
        }
        public static IWebElement Enter_MemberLevelRule_Filter()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_MemberLevelRule_Filter);
        }
        public static IWebElement Get_MembershipLevel_Name(string num)
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='table-membershiplevel']/tbody/tr[" + num + "]/td[1]");
        }
        public static IWebElement Get_MembershipLevel_Order(string num)
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='table-membershiplevel']/tbody/tr[" + num + "]/td[3]");
        }
        public static IWebElement Get_MemberLevel_Name(string num)
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='ddNewLevel_general']/option[" + num + "]");
        }
        public static IWebElement Get_Rule_Type(string num)
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='ddRuleType_general']/option["+num+"]");
        }
        public static IWebElement Get_Default_Rule(string num)
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='ddDefaultRule_general']/option["+num+"]");
        }
        public static IWebElement Click_Edit_MembershipLevelRule()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MemberLevelRuleEdit_Button);
        }
        
        public static IWebElement Click_LoyaltyRules_AwardEarningRules()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoyaltyRules_AwardEarningRules);
        }
        public static IWebElement Click_AwardEarningRules_AddRuleButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AwardEarningRules_AddRuleButton);
        }
        public static IWebElement Click_AwardEarningRules_AddRule_IncludeMemberLevel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AwardEarningRules_AddRule_IncludeMemberLevel);
        }
        public static IWebElement Click_AwardEarningRules_AddRule_CancelButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AwardEarningRules_AddRule_CancelButton);
        }
        public static IWebElement Get_Admin_MemberLevel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='memberSearchResults']/tbody/tr[1]/td[6]");
        }
        public static IWebElement Get_MemberInformation_MemberLevel(string num)
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//select[@class='form-control input-sm']//option[" + num + "]");
        }
        public static IWebElement Click_MemberLevelRule_AddRuleButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MemberLevelRule_AddRuleButton);
        }
        public static IWebElement Click_MemberLevelRule_AddRuleButton_NewLevel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MemberLevelRule_AddRuleButton_NewLevel);
        }
        public static IWebElement Click_MemberLevelRule_AddRuleButton_CancelButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MemberLevelRule_AddRuleButton_CancelButton);
        }


        public static IWebElement Click_DeleteMemershipLevelRule_SubmitButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_DeleteMemershipLevelRule_SubmitButton);
        }

        public static IWebElement Click_DeleteMemershipLevelRule_CancelButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_DeleteMemershipLevelRule_CancelButton);
        }

        public static IWebElement Click_DeleteMemberLevelRule_Button()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_DeleteMemberLevelRule_Button);
        }

        public static IWebElement Click_EditMemberLevelRule_Button()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_EditMemberLevelRule_Button);
        }
        public static IWebElement Enter_MembershipLevel_Filter()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_MembershipLevel_Filter);
        }
        



        public static IWebElement Enter_AddMemershipLevel_Filter()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_AddMemershipLevel_Filter);
        }

        #endregion[Admin_Member_Setup]
        #region[Admin_LoyaltyRule_QualifyingRule]
        public static IWebElement Loyalty_Rule_QualifyingRule_General_RuleName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_General_RuleName);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_General_Description()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_General_Description);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_General_MinRevenue()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_General_MinRevenue);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_General_ParallelStay()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_General_ParallelStay);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_General_MarketCode()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_General_MarketCode);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_General_SourceOfBusiness()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_General_SourceOfBusiness);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_General_ChannelCode()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_General_ChannelCode);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_General_ConsecutiveStays()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_General_ConsecutiveStays);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_General_SaveButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_General_SaveButton);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_RuleName()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_RuleName);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_Description()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_Description);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_MinRevenue()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_MinRevenue);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_MarketCode()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_MarketCode);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_Hotel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_Hotel);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_RatesCodes()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_RatesCodes);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_MarketCombo()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_MarketCombo);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_RateCombo()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_RateCombo);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_Include_Market_RateCombo()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_Include_Market_RateCombo);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_ChannelCode()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_ChannelCode);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_SaveButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_SaveButton);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_General_ChannelCode_Text()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_General_ChannelCode_Text);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_General_MarketCode_Text()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_General_MarketCode_Text);
        }
       
        public static IWebElement Loyalty_Rule_QualifyingRule_General_SourceOfBusiness_Text()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_General_SourceOfBusiness_Text);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_MarketCode_Text()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_MarketCode_Text);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_Hotel_Text()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_Hotel_Text);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_RatesCodes_Text()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_RatesCodes_Text);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness_Text()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness_Text);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_ChannelCode_Text()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_ChannelCode_Text);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_General_SaveButton_Confirm()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_General_SaveButton_Confirm);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_SaveButton_Confirm()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Loyalty_Rule_QualifyingRule_Night_SaveButton_Confirm);
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_Hotel_SelectAll()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//*[@id='qualifiedNightRuleForm']//button[contains(text(),'Select All')])[1]");
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_Hotel_DeselectAll()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//*[@id='qualifiedNightRuleForm']//button[contains(text(),'Deselect All')])[1]");
        }
        public static IWebElement Loyalty_Rule_QualifyingRule_Night_Hotel_Include()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='incNightHotels']");
        }
        #endregion[Admin_LoyaltyRule_QualifyingRule] 
        #region[Adin_EmailSetup]
        public static IWebElement Button_EmailSetup_Add_Email()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Button_EmailSetup_Add_Email);
        }
        public static IWebElement Filter_EmailSetup_SearchEmail()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Filter_EmailSetup_SearchEmail);
        }
        public static IWebElement Button_EmailSetup_EditEmail()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Button_EmailSetup_EditEmail);
        }
        public static IWebElement Input_EmailSetup_FromEmail()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Input_EmailSetup_FromEmail);
        }
        public static IWebElement Button_EmailSetup_Save()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Button_EmailSetup_Save);
        }
        public static IWebElement Button_EmailSetup_Cancel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Button_EmailSetup_Cancel);
        }
        public static IWebElement CatchAllEmailValue()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='ReadingPaneContainerId']/descendant::span[contains(.,'@')]");
        }
        #endregion[Admin_EmailSetup]

        #region[Admin_LoyaltyRule_RuleRestrictions]
        public static IWebElement Enter_Rule_Restrict_MinRevenue()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Rule_Restrict_MinRevenue);
        }
        public static IWebElement Enter_Rule_Restrict_MinRoomRevenue()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Rule_Restrict_MinRoomRevenue);
        }
        public static IWebElement Enter_Rule_Restrict_MinFandBRevenue()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Rule_Restrict_MinFandBRevenue);
        }
        public static IWebElement Enter_Rule_Restrict_MinotherRevenue()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Rule_Restrict_MinotherRevenue);
        }
        public static IWebElement Enter_Rule_Restrict_MinNight()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Rule_Restrict_MinNight);
        }
        public static IWebElement Enter_Rule_Restrict_MinStay()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Rule_Restrict_MinStay);
        }
        public static IWebElement Enter_Rule_Restrict_MaxStay()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Rule_Restrict_MaxStay);
        }
        public static IWebElement Click_Rule_Restrict_MarketCode()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Rule_Restrict_MarketCode);
        }
        public static IWebElement Select_Rule_Restrict_MarketCode()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Rule_Restrict_MarketCode);
        }
        public static IWebElement Click_Rule_Restrict_RateCode()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Rule_Restrict_RateCode);
        }
        public static IWebElement Select_Rule_Restrict_RateCode()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Rule_Restrict_RateCode);
        }
        public static IWebElement Click_Rule_Restrict_Hotel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Rule_Restrict_Hotel);
        }
        public static IWebElement Select_Rule_Restrict_Hotel()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Rule_Restrict_Hotel);
        }
        public static IWebElement Click_Rule_Restrict_RoomType()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Rule_Restrict_RoomType);
        }
        public static IWebElement Select_Rule_Restrict_RoomType()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Rule_Restrict_RoomType);
        }
        public static IWebElement Click_Rule_Restrict_SourceOfBusiness()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Rule_Restrict_SourceOfBusiness);
        }
        public static IWebElement Select_Rule_Restrict_SourceOfBusiness()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Rule_Restrict_SourceOfBusiness);
        }
        public static IWebElement Click_Rule_Restrict_ChannelCode()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Rule_Restrict_ChannelCode);
        }
        public static IWebElement Select_Rule_Restrict_ChannelCode()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Rule_Restrict_ChannelCode);
        }
        public static IWebElement Select_Rule_Restrict_BookingDate()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Rule_Restrict_BookingDate);
        }
        public static IWebElement Select_Rule_Restrict_BookingEndDate()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Rule_Restrict_BookingEndDate);
        }
        public static IWebElement Select_Rule_Restrict_JoinDate()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Rule_Restrict_JoinDate);
        }
        public static IWebElement Select_Rule_Restrict_JoinEndDate()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Rule_Restrict_JoinEndDate);
        }
        public static IWebElement Click_Rule_Restrict_MarketCombo()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Rule_Restrict_MarketCombo);
        }
        public static IWebElement Select_Rule_Restrict_MarketCombo()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Rule_Restrict_MarketCombo);
        }
        public static IWebElement Click_Rule_Restrict_RateCombo()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Rule_Restrict_RateCombo);
        }
        public static IWebElement Select_Rule_Restrict_RateCombo()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Rule_Restrict_RateCombo);
        }
        public static IWebElement Click_Rule_Restrict_SaveButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Rule_Restrict_SaveButton);
        }
        public static IWebElement Click_Rule_Restrict_CancelButton()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Rule_Restrict_CancelButton);
        }
        #endregion[Admin_LoyaltyRule_RuleRestrictions]
    }
}
