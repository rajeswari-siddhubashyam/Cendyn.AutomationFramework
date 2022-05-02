using System;
using OpenQA.Selenium;
using eLoyaltyV3.PageObject.UI;
using eLoyaltyV3.Utility;
using NUnit.Framework;
using Common;
using BaseUtility.Utility;
using InfoMessageLogger;
using AutoItX3Lib;

namespace eLoyaltyV3.AppModule.UI
{
    class ContactUs
    {

        public static void EnterNumber_Text_PhoneNumber(string text)
        {
            Helper.ElementWait(PageObject_ContactUs.Text_PhoneNumber(), 240);
            Helper.ElementEnterText(PageObject_ContactUs.Text_PhoneNumber(), text);
        }

        public static void DropDownSelect_Text_Subject(string text)
        {
            Helper.ElementWait(PageObject_ContactUs.DDM_Subject(), 240);
            Helper.ElementSelectFromDropDown(PageObject_ContactUs.DDM_Subject(), text);
        }
        public static void DropDownSelect_Authentication_Subject(string text)
        {
            Helper.ElementWait(PageObject_ContactUs.DropDownSelect_Authentication_Subject(), 240);
            Helper.ElementSelectFromDropDown(PageObject_ContactUs.DropDownSelect_Authentication_Subject(), text);
        }

        public static void EnterNumber_Text_Email(string text)
        {
            Helper.ElementWait(PageObject_ContactUs.Text_EmailAddress(), 240);
            Helper.ElementEnterText(PageObject_ContactUs.Text_EmailAddress(), text);
        }

        public static void EnterText_Text_Message(string text)
        {
            Helper.ElementWait(PageObject_ContactUs.Text_Message(), 240);
            Helper.ElementEnterText(PageObject_ContactUs.Text_Message(), text);
        }

        private static void Click_CheckBox_Captcha()
        {
            Helper.ElementWait(PageObject_ContactUs.Button_Captcha(), 240);
            Helper.ElementClick(PageObject_ContactUs.Button_Captcha());
        }

        public static void Click_Button_Send()
        {
            Helper.ElementWait(PageObject_ContactUs.Button_Send(), 240);
            Helper.ElementClick(PageObject_ContactUs.Button_Send());
        }

        public static void VerifyUneditableFields(string ProjectName)
        {
            IWebElement nameField = null;
            IWebElement emailField = null;
            IWebElement membershipNoField = null;
            if (ProjectName.Equals("AMR"))
            {
                emailField = CommonMethod.Driver.FindElement(By.XPath("//input[@id='Email']"));
            }
            else
            {
                nameField = CommonMethod.Driver.FindElement(By.XPath("//input[@id='FullName']"));
                emailField = CommonMethod.Driver.FindElement(By.XPath("//input[@id='Email']"));
                membershipNoField = CommonMethod.Driver.FindElement(By.XPath("//input[@id='MembershipID']"));
            }
            

            try
            {
                if (!Helper.IsElementEditable(nameField))
                    Logger.WriteInfoMessage("The Name field on the Contact Us page was not editable - Correct");
                else
                    Assert.Fail("The name field on the Contact Us page was editable - WRONG");
                if (!Helper.IsElementEditable(emailField))
                    Logger.WriteInfoMessage("The Email field on the Contact Us page was not editable - Correct");
                else
                    Assert.Fail("The Email field on the Contact Us page was editable - WRONG");
                if (!Helper.IsElementEditable(membershipNoField))
                    Logger.WriteInfoMessage("The Membership Number field on the Contact Us page was not editable - Correct");
                else
                    Assert.Fail("The Membership Number field on the Contact Us page was editable - WRONG");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                throw;
            }
            
        }

        public static void InsertValidDetails(string PhoneNumber, string Subject, string Message)
        {
            Helper.ScrollPageDown(PageObject_ContactUs.Button_Captcha());
            EnterNumber_Text_PhoneNumber(PhoneNumber);
            DropDownSelect_Text_Subject(Subject);
            EnterText_Text_Message(Message);
            Click_CheckBox_Captcha();
            Logger.WriteDebugMessage("Enter Valid data and clicked on Captcha.");
            Click_Button_Send();
            Helper.AddDelay(7000); 
        }

        public static void InsertSpecialCharacterInPhone(string text,string ProjectName= null)
        {
            if (ProjectName.Equals("AMR"))
            {
                EnterNumber_Text_Email(text);
            }
            else
            {
                EnterNumber_Text_PhoneNumber(text);
            }
            if(Helper.Getdata(PageObject_ContactUs.Text_PhoneNumber())=="")
            {
                Logger.WriteDebugMessage("Text field does not accept " + text + " data for the phone number field.. ");
            }
            else if(Helper.Getdata(PageObject_ContactUs.Text_EmailAddress()) == "")
            {
                Logger.WriteDebugMessage("Text field does not accept " + text + " data for the Email field.. ");
            }
            else
            {
                Assert.Fail("Element accepts " + text + "for the phone number field." );
            }
        }

        public static void VerifyPageDetals()
        {
            Helper.ScrollToElement(Helper.Driver.FindElement(By.Id("SubjectCode")));

            if (!Helper.Driver.Url.Contains("nyloloyals"))
            {
                DropDownSelect_Text_Subject("MSP");
                Logger.WriteDebugMessage("First Option Value from Drop down is selected. No change on frontend after selecting dropdown " + "Missing Stays/Points.");
            }

            DropDownSelect_Text_Subject("PRI");
            Logger.WriteDebugMessage("First Option Value from Drop down is selected. No change on frontend after selecting dropdown " + "Points Redemption Inquiry.");

            DropDownSelect_Text_Subject("RI");
            Logger.WriteDebugMessage("First Option Value from Drop down is selected. No change on frontend after selecting dropdown " + "Reservations Inquiry.");

            DropDownSelect_Text_Subject("FP");
            Logger.WriteDebugMessage("First Option Value from Drop down is selected. No change on frontend after selecting dropdown " + "FeedBack on Property.");

            if (!Helper.Driver.Url.Contains("nyloloyals") || !Helper.Driver.Url.Contains("hotelicon") || !Helper.Driver.Url.Contains("hotelvic"))
            {
                DropDownSelect_Text_Subject("FFW");
                Logger.WriteDebugMessage("First Option Value from Drop down is selected. No change on frontend after selecting dropdown " + "Feedback on Independent Collection.");
            }
        }
        public static void EnterText_Text_Confirmation_Number(string text)
        {
            Helper.ElementWait(PageObject_ContactUs.EnterText_Text_Confirmation_Number(), 240);
            Helper.ElementEnterText(PageObject_ContactUs.EnterText_Text_Confirmation_Number(), text);
        }

        public static void InsertSpecialCharacterInConfirmationField(string text)
        {
            EnterText_Text_Confirmation_Number(text);
            
            if (Helper.Getdata(PageObject_ContactUs.EnterText_Text_Confirmation_Number()) == "")
            {
                Logger.WriteDebugMessage("Text field does not accept " + text + " data for the phone number field.. ");
            }
            else
            {
                Assert.Fail("Element accepts " + text + "for the phone number field.");
            }
        }
        public static void Navigation_Link_Un_Authenticated_ContactUs()
        {
            Helper.ElementClick(PageObject_ContactUs.Navigation_Link_Un_Authenticated_ContactUs());
        }
        public static void Select_Contact_US_File()
        {
            Helper.ElementClick(PageObject_ContactUs.Select_Contact_US_File());
        }
     
        public static void Select_Contact_US_File(string filepath)
        {
            Select_Contact_US_File();
            Helper.AddDelay(2500);
            AutoItX3 AutoIt = new AutoItX3();
            AutoIt.WinActivate("Open");
            Helper.AddDelay(5000);
            AutoIt.Send(filepath);
            Helper.AddDelay(3000);
            AutoIt.Send("{ENTER}");
            Helper.AddDelay(5000);
        }
        public static string Get_Contact_us_Filename()
        {
            return Helper.GetText( PageObject_ContactUs.Get_Contact_us_Filename());
        }
    }
}
