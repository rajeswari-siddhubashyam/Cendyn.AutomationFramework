using eLoyaltyV3.PageObject.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Collections.Generic;
using eLoyaltyV3.Utility;
using OpenQA.Selenium.Interactions;
using Common;
using BaseUtility.Utility;
using InfoMessageLogger;
using Setup = eLoyaltyV3.Utility.Setup;

namespace eLoyaltyV3.AppModule.UI
{
    public class MyProfile
    {
        public static void Click_Button_Next()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_MyProfile.Button_Next());
            Helper.AddDelay(2500);
            Helper.ElementClick(PageObject_MyProfile.Button_Next());
        }

        public static void EnterText_Text_FirstName(string text)
        {
            Helper.ElementEnterText(PageObject_MyProfile.Text_FirstName(), text);
        }

        public static void EnterText_Text_LastName(string text)
        {
            Helper.ElementEnterText(PageObject_MyProfile.Text_LastName(), text);
        }

        public static void EnterText_Text_CardName(string text)
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_MyProfile.Text_CardName());
            Helper.ElementEnterText(PageObject_MyProfile.Text_CardName(), text);
        }

        public static void EnterText_Text_MobilePhoneNumber(string text)
        {
            Helper.ElementEnterText(PageObject_MyProfile.Text_MobilePhoneNumber(), text);
        }

        public static void EnterText_Text_HomePhoneNumber(string text)
        {
            Helper.ElementEnterText(PageObject_MyProfile.Text_HomePhoneNumber(), text);
        }

        public static void EnterText_Text_Address1(string text)
        {
            if(Setup.ProjectName.Equals("Fraser"))
            {
                Helper.DynamicScroll(Helper.Driver, PageObject_MyProfile.Text_Address1());
            }            
            Helper.ElementEnterText(PageObject_MyProfile.Text_Address1(), text);
        }

        public static void EnterText_Text_Company(string text)
        {
            Helper.ElementEnterText(PageObject_MyProfile.Text_CompanyName(), text);
        }

        public static void Clear_Text_Address1()
        {
            Helper.ElementClearText(PageObject_MyProfile.Text_Address1());
        }

        public static void EnterText_Text_Address2(string text)
        {
            Helper.ElementEnterText(PageObject_MyProfile.Text_Address2(), text);
        }

        public static void EnterText_Text_City(string text)
        {
            Helper.ElementEnterText(PageObject_MyProfile.Text_City(), text);
        }

        public static void Clear_Text_City()
        {
            Helper.ElementClearText(PageObject_MyProfile.Text_City());
        }

        public static void EnterText_Text_Zip(string text)
        {
            Helper.ElementEnterText(PageObject_MyProfile.Text_Zip(), text);
        }

        public static void SelectFromDropDown_DropDown_Title(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_MyProfile.DropDown_Title(), text);
        }

        public static void SelectFromDropDown_DropDown_Language(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_MyProfile.DropDown_PreferredLanguage(), text);
        }

        public static void SelectFromDropDown_DropDown_Gender(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_MyProfile.DropDown_Gender(), text);
        }

        public static void SelectFromDropDown_DropDown_Country(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_MyProfile.DropDown_Country(), text);
        }

        public static void SelectFromDropDown_DropDown_State(string text)
        {
            if(Setup.ProjectName.Equals("Bartell"))
            {
                Helper.ElementSelectFromDropDown(PageObject_MyProfile.DropDown_StateProvince(), text.ToUpper());
            }
            else
            {
                Helper.ElementSelectFromDropDown(PageObject_MyProfile.DropDown_StateProvince(), text);
            }
            
        }

        public static void SelectFromDropDown_DropDown_CanadaState(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_MyProfile.DropDown_CanadaProvince(), text);
        }

        public static void ClickDateOfBirth()
        {
            Helper.ElementClick(PageObject_MyProfile.DropDown_DateOfBirth());
        }

        public static void EnterTextDateOfBirth(string date)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementEnterText(PageObject_MyProfile.DropDown_DateOfBirth(),date);
            action.SendKeys(Keys.Enter).Build().Perform();
        }

        public static void SelectFromDropDown_DateOFBirth_Month(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_MyProfile.DropDown_Month(), text);
        }

        public static void SelectFromDropDown_DateOfBirth_Year(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_MyProfile.DropDown_Year(), text);
        }

        public static void ClickLinkFraserSuites()
        {
            Helper.ElementClick(PageObject_MyProfile.Link_FraserSuites());
        }

        public static void ClickLinkFraserPlace()
        {
            Helper.ElementClick(PageObject_MyProfile.Link_FraserPlace());
        }

        public static void ClickLinkFraserResidence()
        {
            Helper.ElementClick(PageObject_MyProfile.Link_FraserResidence());
        }

        public static void ClickLinkMalmaison()
        {
            Helper.ElementClick(PageObject_MyProfile.Link_Malmaison());
        }

        public static void ClickLinkModena()
        {
            Helper.ElementClick(PageObject_MyProfile.Link_Modena());
        }

        public static void ClickLinkCapri()
        {
            Helper.ElementClick(PageObject_MyProfile.Link_Capri());
        }

        public static void ClickLinkHotelDuVin()
        {
            Helper.ElementClick(PageObject_MyProfile.Link_HotelDuVin());
        }
        
        public static void ClickLinkTermsAndCondition()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_MyProfile.Link_TermsAndCondition());
            Helper.AddDelay(2500);
            Helper.ElementClick(PageObject_MyProfile.Link_TermsAndCondition());
        }

        public static void ClickLinkContactUs()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_MyProfile.Link_ContactUs());
            Helper.AddDelay(2500);
            Helper.ElementClick(PageObject_MyProfile.Link_ContactUs());
        }
        
        public static void ClickLinkFrequentlyAskedQuestions()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_MyProfile.Link_FrequentlyAskedQuestions());
            Helper.AddDelay(2500);
            Helper.ElementClick(PageObject_MyProfile.Link_FrequentlyAskedQuestions());
        }

        public static void ClickLinkTermsOfUse()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_MyProfile.Link_TermsOfUse());
            Helper.AddDelay(2500);
            Helper.ElementClick(PageObject_MyProfile.Link_TermsOfUse());
        }

        public static void ClickLinkPrivacyPolicy()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_MyProfile.Link_PrivacyPolicy());
            Helper.AddDelay(2500);
            Helper.ElementClick(PageObject_MyProfile.Link_PrivacyPolicy());
        }

        public static void ClickLinkBestRateGuarantee()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_MyProfile.Link_BestRateGuarantee());
            Helper.AddDelay(2500);
            Helper.ElementClick(PageObject_MyProfile.Link_BestRateGuarantee());
        }

        public static void ClickIconClose()
        {
            Helper.ElementClick(PageObject_MyProfile.Icon_Close());
        }

        public static void ClickIconFAQClose()
        {
            Helper.ElementClick(PageObject_MyProfile.FAQ_Icon_Close());
        }
        
        public static void VerifyAsterickForMandatoryField()
        {
            int i,j;
            IList<IWebElement> element = Helper.Driver.FindElements(By.XPath("//font[@color='red']"));
            i = element.Count;         
            string asterick = Helper.Driver.FindElement(By.XPath("//font[@color='red']")).GetAttribute("innerHTML");
            if (i.Equals(10)|| i.Equals(9))
            {
                for(j= 1;j <= i;j++)
                {                    
                    Helper.ValidateTextOnPage(asterick);                    
                }
            }
            else
            {
                Assert.Fail("All Field on Page are not marked as Mandatory with Red Astericks(*)");
            }
           
        }
        
        public static string Get_MembershipNo()
        {
            string membershipNo = PageObject_MyProfile.Text_MembershipNumber().GetAttribute("value");
            return membershipNo;
        }

        public static string Get_MembershipType()
        {
            string membershipType = PageObject_MyProfile.Text_MembershipType().GetAttribute("value");
            return membershipType;
        }

        public static void VerifyStateDropdown_Enable(IWebElement element)
        {
            string property = element.GetAttribute("style");
            if(property.Equals("display: none;"))
            {
                Logger.WriteDebugMessage("State field should not be available for user, if country is other than United stated and Canada");
            }
            else
            {
                Logger.WriteDebugMessage("State field is available for user, if country is other than United stated and Canada");
            }
        }

        /// <summary>
        /// Method to verfiy value in a Dropdown
        /// </summary>
        public static void VerifyDropdown(string value)
        {
            string[] data, datatitle;
            switch (value)
            {
                case "Gender":
                    if(Setup.ProjectName.Equals("Bartell"))
                        data = new string[]{ "Please Select", "Male", "Female" };
                    else
                        data = new string[]{ "No Preference", "Female", "Male" };
                    SelectElement element = new SelectElement(PageObject_MyProfile.DropDown_Gender());
                    IList<IWebElement> options = element.Options;
                    int i = 0;
                    foreach (IWebElement option in options)
                    {
                        Assert.IsTrue(data[i].Contains(option.Text));
                        Logger.WriteDebugMessage(data[i] + " is a value for Gender Dropdown");
                        i++;
                    }
                    break;

                case "Title":
                    if (Setup.ProjectName.Equals("Bartell"))
                        datatitle = new string[] { "Please Select", "Mr.", "Miss.", "Mrs.", "Ms.", "Dr."};
                    else
                        datatitle = new string[] { "Please Select", "Mr.", "Ms.", "Mrs.", "Miss", "Dr.", "Prof." };
                    SelectElement elementtitle = new SelectElement(PageObject_MyProfile.DropDown_Title());
                    IList<IWebElement> optionstitle = elementtitle.Options;
                    int title = 0;
                    foreach (IWebElement option in optionstitle)
                    {
                        Assert.IsTrue(datatitle[title].Contains(option.Text));
                        Logger.WriteDebugMessage(datatitle[title] + " is a value for Title Dropdown");
                        title++;
                    }
                    break;

                case "Language":
                    string[] dataLanguage = { "English", "中文(简体）" };
                    SelectElement elementLanguage = new SelectElement(PageObject_MyProfile.DropDown_PreferredLanguage());
                    IList<IWebElement> optionsLanguage = elementLanguage.Options;
                    int Language = 0;
                    foreach (IWebElement option in optionsLanguage)
                    {
                        Assert.IsTrue(dataLanguage[Language].Contains(option.Text));
                        Logger.WriteDebugMessage(dataLanguage[Language] + " is a value for Title Dropdown");
                        Language++;
                    }
                    break;

            }
            
        }

        public static void ProfileDetails_MandatoryFields(string firstname,string lastname,string cardname,string dateOfbirth,string Address1,string country,string state,string city
            ,string zipcode,string language,string homephonenumber)
        {
            EnterText_Text_FirstName(firstname);
            EnterText_Text_LastName(lastname);
            if(Setup.ProjectName.Equals("Fraser"))
            {
                EnterText_Text_CardName(cardname);
            }            
            EnterTextDateOfBirth(dateOfbirth);
            EnterText_Text_Address1(Address1);
            SelectFromDropDown_DropDown_Country(country);
            SelectFromDropDown_DropDown_State(state);
            EnterText_Text_City(city);
            EnterText_Text_Zip(zipcode);
            if (Setup.ProjectName.Equals("Fraser"))
            {
                SelectFromDropDown_DropDown_Language(language);
            }
            if (Setup.ProjectName.Equals("Bartell"))
            {
                EnterText_Text_HomePhoneNumber(homephonenumber);
            }
        }
      
    }
}
