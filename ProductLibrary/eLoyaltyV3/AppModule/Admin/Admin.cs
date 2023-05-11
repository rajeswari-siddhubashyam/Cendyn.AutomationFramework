using AutoItX3Lib;
using AventStack.ExtentReports.Model;
using BaseUtility.Utility;
using eLoyaltyV3.Entity;
using eLoyaltyV3.PageObject.Admin;
using eLoyaltyV3.Utility;
using InfoMessageLogger;
using Microsoft.Graph;
using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Principal;
using System.ServiceProcess;
using Constants = eLoyaltyV3.Utility.Constants;
using Queries = eLoyaltyV3.Utility.Queries;
using Setup = BaseUtility.Utility.Setup;

namespace eLoyaltyV3.AppModule.UI
{
    class Admin
    {
        #region[Admin]
        public static void EnterUsername(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_Text_UserName(), text);
        }

        public static void EnterPassword(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Text_Password(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_Text_Password(), text);
        }

        public static void Click_Button_LogIn()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Button_Login(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Button_Login());
        }

        public static void Click_Icon_View(string Projectname)
        {

            Helper.ElementWait(PageObject_Admin.Admin_Button_ViewMember(Projectname), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Button_ViewMember(Projectname));
        }


        public static void Admin_Yes_Click()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Button_DeleteYes(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_DeleteYes());
        }
        /*
        public static void Click_Icon_View(string Projectname)
        {
            if (Helper.VerifyElementIsClickable(Helper.Driver.FindElement(By.XPath("//table[@id='memberSearchResults']/tbody/tr/td"))))
            {
                Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//table[@id='memberSearchResults']/tbody/tr/td")));
                Helper.ScrollToElement(Helper.Driver.FindElement(By.XPath("//*[@id='memberSearchResults']/tbody/tr[2]/td/ul/li[8]/span[2]/a")));
                Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//*[@id='memberSearchResults']/tbody/tr[2]/td/ul/li[8]/span[2]/a")));
            }
            else
            {
                Helper.ElementClick(PageObject_Admin.Admin_Button_ViewMember(Projectname));
            }
            
        }
         */
        public static void Click_On_Close()
        {
            Helper.ElementWait(PageObject_Admin.Click_On_Close(), 240);
            Helper.ElementClick(PageObject_Admin.Click_On_Close());
        }

        public static void Click_Button_MemberSearch()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Button_MemberSearch(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Button_MemberSearch());
        }

        public static void Click_Button_ClearSearch()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Button_ClearSearch(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Button_ClearSearch());
        }

        public static void SearchMember(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Text_SearchEmail(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_Text_SearchEmail(), text);
        }

        public static string Admin_Value_EmailId()
        {
            return Helper.GetText(PageObject_Admin.Admin_Value_EmailId());
        }
        private static void GetMemberSearch()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Button_MemberSearch(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Button_MemberSearch());
        }

        public static string GetValueEmailAddress(string Projectname)
        {
            string value = PageObject_Admin.Admin_Value_Email(Projectname).Text;
            string[] data = value.Split(':');
            return data[1];
        }
        public static void Click_Member_Level_Email_Yes_Button()
        {
            Helper.ElementWait(PageObject_Admin.Click_Member_Level_Email_Yes_Button(), 240);
            Helper.ElementClick(PageObject_Admin.Click_Member_Level_Email_Yes_Button());
        }
        public static void ViewMemberSearch(string Projectname)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Button_ViewMember(Projectname), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Button_ViewMember(Projectname));
        }

        public static void Admin_ActivationEmail(string Email)
        {
            Helper.ElementWait(PageObject_Admin.Admin_ActivationEmail(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_ActivationEmail());
            //IJavaScriptExecutor js = (IJavaScriptExecutor)Helper.Driver;
            //js.ExecuteScript("arguments[0].click();", PageObject_Admin.Admin_ActivationEmail());
            Logger.WriteDebugMessage("Activation Email is sent to " + Email);
        }

        public static void Admin_WelcomeEmail(string Email)
        {
            Helper.ElementWait(PageObject_Admin.Admin_WelcomeEmail(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_WelcomeEmail());
            //IJavaScriptExecutor js = (IJavaScriptExecutor)Helper.Driver;
            //js.ExecuteScript("arguments[0].click();", PageObject_Admin.Admin_WelcomeEmail());
            Logger.WriteDebugMessage("Welcome Email is sent to " + Email);
        }

        public static void Admin_Button_Activation_Save()
        {
            Time.AddDelay(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Helper.Driver;
            js.ExecuteScript("arguments[0].click();", PageObject_Admin.Admin_Button_Activation_Save());
            Helper.ValitionMessage(Constants.ResendEmailSuccessful);
            Time.AddDelay(3000);
        }

        public static void Admin_Button_Welcome_Save()
        {
            Time.AddDelay(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Helper.Driver;
            js.ExecuteScript("arguments[0].click();", PageObject_Admin.Admin_Button_Welcome_Save());
            Helper.ValitionMessage(Constants.ResendEmailSuccessful);
            Time.AddDelay(3000);
        }

        public static void AdminLogin(string UserName, string Password)
        {

            EnterUsername(UserName);
            EnterPassword(Password);
            Logger.WriteDebugMessage("Entered Username and Password");
            Click_Button_LogIn();
        }

        public static void EnterFilter(string text)
        {
            Helper.ElementWait(PageObject_Admin.Textbox_Filter(), 240);
            Helper.ElementEnterText(PageObject_Admin.Textbox_Filter(), text);
        }

        public static void SearchEmail(string EmailAddress, string Projectname)
        {
            SearchMember(EmailAddress);
            GetMemberSearch();
            ViewMemberSearch(Projectname);
            Time.AddDelay(7000);
        }
        public static void SearchOldEmail(string EmailAddress, string Projectname)
        {
            SearchMember(EmailAddress);
            GetMemberSearch();
            Time.AddDelay(7000);

        }
        public static void EnterMemberNumber(string text)
        {
            Helper.ElementWait(PageObject_Admin.Textbox_MemberNumber(), 240);
            Helper.ElementEnterText(PageObject_Admin.Textbox_MemberNumber(), text);
        }

        public static void EnterFirst_name(string text)
        {
            Helper.ElementWait(PageObject_Admin.Textbox_First_Name(), 240);
            Helper.ElementEnterFirsName(PageObject_Admin.Textbox_First_Name(), text);

        }
        public static void EnterLast_name(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Textbox_Last_Name(), 240);
            Helper.ElementEnterLastname(PageObject_Admin.Admin_Textbox_Last_Name(), text);

        }
        public static void EnterFirstname(string text)
        {
            Helper.ElementWait(PageObject_Admin.Textbox_Firstname(), 240);
            Helper.ElementEnterText(PageObject_Admin.Textbox_Firstname(), text);
        }

        public static void EnterLastname(string text)
        {
            Helper.ElementWait(PageObject_Admin.Textbox_Lastname(), 240);
            PageObject_Admin.Textbox_Lastname().Clear();
            Helper.ElementEnterText(PageObject_Admin.Textbox_Lastname(), text);
        }

        public static void EnterEmail(string text)
        {
            Helper.ElementWait(PageObject_Admin.Textbox_Email(), 240);
            Helper.ElementEnterText(PageObject_Admin.Textbox_Email(), text);
        }
        public static void RecoveryEmail(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Textbox_Email(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_Textbox_Email(), text);
        }
        public static void EnterStreet(string text)
        {
            Helper.ElementWait(PageObject_Admin.Textbox_Street(), 240);
            Helper.ElementEnterText(PageObject_Admin.Textbox_Street(), text);
        }

        public static void EnterCity(string text)
        {
            Helper.ElementWait(PageObject_Admin.Textbox_City(), 240);
            Helper.ElementEnterText(PageObject_Admin.Textbox_City(), text);
        }

        public static void EnterZip(string text)
        {
            Helper.ElementWait(PageObject_Admin.Textbox_Zip(), 240);
            Helper.ElementEnterText(PageObject_Admin.Textbox_Zip(), text);
        }

        public static void EnterAwardNumber(string text)
        {
            Helper.ElementWait(PageObject_Admin.Textbox_AwardNumber(), 240);
            Helper.ElementEnterText(PageObject_Admin.Textbox_AwardNumber(), text);
        }

        public static void EnterCardName(string text)
        {
            Helper.ElementWait(PageObject_Admin.Textbox_CardName(), 240);
            Helper.ElementEnterText(PageObject_Admin.Textbox_CardName(), text);
        }

        public static void EnterPhone(string text)
        {
            Helper.ElementWait(PageObject_Admin.Textbox_Phone(), 240);
            Helper.ElementEnterText(PageObject_Admin.Textbox_Phone(), text);
        }

        public static void EnterCompany(string text)
        {
            Helper.ElementWait(PageObject_Admin.Textbox_Company(), 240);
            Helper.ElementEnterText(PageObject_Admin.Textbox_Company(), text);
        }

        public static void SelectAwardName(string text)
        {
            Helper.ElementWait(PageObject_Admin.Dropdown_AwardName(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Dropdown_AwardName(), text);
        }

        public static void SelectEmailStatus(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberInformation_Dropdown_EmailStatus(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Admin_MemberInformation_Dropdown_EmailStatus(), text);
        }

        public static void SelectMemberType(string text)
        {
            Helper.ElementWait(PageObject_Admin.Dropdown_MemberType(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Dropdown_MemberType(), text);
        }

        public static void SelectMemberStatus(string text)
        {
            Helper.ElementWait(PageObject_Admin.Dropdown_MemberStatus(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Dropdown_MemberStatus(), text);
        }

        public static void SelectCountry(string text, string Projectname)
        {
            if (Setup.BrowserType.Equals("Mozilla"))
            {
                Actions action = new Actions(Helper.Driver);
                Helper.ElementClick(PageObject_Admin.Textbox_Country(Projectname));
                Helper.ElementEnterText(PageObject_Admin.Input_Country(), text);
                //Helper.ElementSelectFromDropDown(PageObject_Admin.Dropdown_Country(), text);
                action.MoveToElement(PageObject_Admin.Dropdown_Value_Country()).Click().Build().Perform();



            }
            else
            {
                Helper.ElementClick(PageObject_Admin.Textbox_Country(Projectname));
                Helper.AddDelay(5000);
                if (Projectname.Equals("AMR"))
                {
                    Helper.ElementSelectFromDropDown(PageObject_Admin.Dropdown_Country(), "UNITED STATES");
                }
                else
                {
                    Helper.ElementSelectFromDropDown(PageObject_Admin.Dropdown_Country(), text);
                }
            }

        }

        public static string VerifyFileFormate(String path)
        {
            var files = new DirectoryInfo(path).GetFiles("*.*");
            String latestFile = "";
            DateTime lastupdate = DateTime.MinValue;
            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > lastupdate)
                {
                    lastupdate = file.LastWriteTime;
                    latestFile = file.Name;
                }
            }

            if (latestFile.Contains(".xlsx"))
            {
                Logger.WriteDebugMessage("The template should be downloaded in the csv file format.");
            }
            else
            {
                Assert.Fail("The template is not  in the csv file format.");
            }
            return latestFile;
        }

        public static void SelectState(string state)
        {
            Helper.ElementWait(PageObject_Admin.Dropdown_State(), 240);

            Helper.ElementClick(PageObject_Admin.Dropdown_State());

            Helper.AddDelay(5000);

            Helper.ElementEnterText(PageObject_Admin.Textbox_State(), state);
            Actions action = new Actions(Helper.Driver);
            action.MoveToElement(PageObject_Admin.DropDown_value_State()).Click().Build().Perform();
        }

        public static void SelectPagination(string text)
        {
            Helper.ElementWait(PageObject_Admin.Dropdown_Pagination(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Dropdown_Pagination(), text);
        }

        public static void Click_Icon_Next()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.Admin_Arrow_Next());
            Helper.ElementClick(PageObject_Admin.Admin_Arrow_Next());
        }

        public static void Click_Icon_Previous()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.Admin_Arrow_Previous());
            Helper.ElementClick(PageObject_Admin.Admin_Arrow_Previous());
        }

        public static void VerifyPaginationDropdown()
        {
            List<string> drop = new List<string> { "5", "10", "15", "20" };
            SelectElement soc = new SelectElement(Helper.Driver.FindElement(By.XPath(ObjectRepository.Admin_Dropdown_Pagination)));
            IList<IWebElement> options = soc.Options;
            foreach (IWebElement option in options)
            {
                Assert.IsTrue(drop.Contains(option.Text));
            }
        }

        public static void UpdateEmail(string email)
        {
            RecoveryEmail(email);
            Logger.WriteDebugMessage("Entered Email Address:" + email + " and clicking on Recover button.");
            ClickRecover();
        }
        public static void UpdateEmail1(string email)
        {
            RecoveryEmail(email);
            Logger.WriteDebugMessage("Entered Email Address:" + email + " and clicking on Recover button.");
            Admin_ForgotPassword_Recover();
        }
        public static void ClickRecover()
        {
            Helper.ElementWait(PageObject_Admin.ForgotPassword_Recover(), 240);
            Helper.ElementClick(PageObject_Admin.ForgotPassword_Recover());
        }
        public static void EnterNewPassword(string Password)
        {
            Helper.ElementWait(PageObject_Admin.NewPassword(), 240);
            Helper.ElementEnterText(PageObject_Admin.NewPassword(), Password);
        }

        public static void EnterNewConfirmedPassword(string Password)
        {
            Helper.ElementWait(PageObject_Admin.NewPasswordConfirm(), 240);
            Helper.ElementEnterText(PageObject_Admin.NewPasswordConfirm(), Password);
        }
        public static void SubmitNewPassword()
        {
            Helper.ElementWait(PageObject_Admin.SubmitNewPassword(), 240);
            Helper.ElementClick(PageObject_Admin.SubmitNewPassword());
        }

        public static void ResetPassword(string NewPassword)
        {
            EnterNewPassword(NewPassword);
            Helper.AddDelay(90);
            EnterNewConfirmedPassword(NewPassword);
            Logger.WriteDebugMessage("Entered new Password:" + NewPassword + " and clicking on Recover button.");
            SubmitNewPassword();
        }

        /*Member Stays*/

        public static void Click_MemberStays()
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberInfo_MemberStays(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_MemberInfo_MemberStays());
        }

        public static void Click_MemberStaysSearch(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberInfo_SearchMemberStays(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_MemberInfo_SearchMemberStays(), text);
        }

        public static void UpcomingStays_VerifyConfirmationNumberDisplays(string confirmationNumber)
        {
            String execScript = "return document.documentElement.scrollHeight>document.documentElement.clientHeight;";
            IJavaScriptExecutor scrollBarPresent = (IJavaScriptExecutor)Helper.Driver;
            Boolean test = (Boolean)(scrollBarPresent.ExecuteScript(execScript));
            if (test == true)
            {
                scrollBarPresent.ExecuteScript("$(window).scrollTop(80)");
            }

            Click_MemberStaysSearch(confirmationNumber);
            Helper.AddDelay(7000);
            try
            {
                if (Helper.VerifyTextOnPage(confirmationNumber))
                    Logger.WriteDebugMessage("The confirmation number was displayed on the page!");
                else
                    throw new Exception("The confirmation number: " + confirmationNumber +
                                        " did not display on the My Stays page.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                throw;
            }

        }

        /*Loyalty Awards*/
        public static void Click_LoyaltyAwards()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Menu_LoyaltyAwards(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Menu_LoyaltyAwards());
        }
        public static void Click_LoyaltyeGift()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Menu_LoyaltyEgift(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Menu_LoyaltyEgift());
        }
        public static void Click_LoyaltyeGift_AccountBalance()
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyeGift_AccountBalance(), 240);
            Helper.ElementClick(PageObject_Admin.Click_LoyaltyeGift_AccountBalance());
        }
        public static void Search_LoyaltyAwards(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Search_LoyaltyAwards(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_Search_LoyaltyAwards(), text);
        }

        public static void Click_Button_Awards_Add()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.Admin_Button_Awards_Add());
            Helper.ElementWait(PageObject_Admin.Admin_Button_Awards_Add(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Button_Awards_Add());
        }

        //public static void Click_DropDown_AwardType()
        //{
        //    Helper.ElementClick(PageObject_Admin.Admin_DropDown_AwardType());
        //}
        public static void Click_Button_Close()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Button_Close(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Button_Close());
        }

        public static void Enter_Text_Award_Name(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Text_Award_Name(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_Text_Award_Name(), text);
        }

        public static void Enter_Text_Award_Code(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Text_Award_Code(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_Text_Award_Code(), text);
        }

        public static void Enter_Text_Date_StartDate(string text)
        {
            PageObject_Admin.Admin_Text_Date_StartDate().SendKeys(text);
        }

        public static void Enter_Text_Date_EndDate(string text)
        {
            PageObject_Admin.Admin_Text_Date_EndDate().SendKeys(text);
        }

        private static void SelectText_DropDown_AwardType(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_DropDown_AwardType(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Admin_DropDown_AwardType(), text);
        }

        public static void Enter_Text_DaysActive(string text)
        {
            PageObject_Admin.Admin_Text_DaysActive().SendKeys(text);
        }

        private static void Enter_Text_AdvanceDeliveryDays(string text)
        {
            PageObject_Admin.Admin_Text_AdvanceDeliveryDays().SendKeys(text);
        }

        private static void Admin_DropDown_MinQualifiedStay(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_DropDown_MinQualifiedStay(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_DropDown_MinQualifiedStay());
            Helper.ElementClick(Helper.Driver.FindElement(By.LinkText(text)));
        }

        public static void Admin_DropDown_MemberLevel(string value)
        {
            //Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Member_Level(), 240);
            SelectElement selMemberLevel = new SelectElement(PageObject_Admin.Admin_LoyaltyAwards_Member_Level());
            selMemberLevel.SelectByText(value);
        }

        private static void Admin_DropDown_EmailName(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_DropDown_EmailName(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Admin_DropDown_EmailName(), text);
        }

        public static void Admin_Award_Savebtn()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.Admin_Award_Savebtn());
            Helper.ElementWait(PageObject_Admin.Admin_Award_Savebtn(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Award_Savebtn());
        }
        //Night Based
        private static void Admin_DropDown_NightCycle(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_DropDown_NightCycle(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Admin_DropDown_NightCycle(), text);
        }

        private static void Admin_DropDown_NightAwarded(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_DropDown_NightAwarded(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Admin_DropDown_NightAwarded(), text);
        }

        private static void Admin_DropDown_NightExpMonth(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_DropDown_NightExpMonth(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Admin_DropDown_NightExpMonth(), text);
        }

        private static void Admin_DropDown_NightHotels(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_DropDown_NightHotels(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Admin_DropDown_NightHotels(), text);
        }

        public static void Enter_Text_MaxAwardperMember(string text)
        {

            PageObject_Admin.Enter_Text_MaxAwardperMember().SendKeys(text);
        }

        public static void FillGeneralRequiredData(string AwardType, string MinQualifiedStay, string MemberLevel)
        {
            var myDate = DateTime.Now;
            var newDate = myDate.AddDays(30);
            string StartDate = newDate.ToString("MM/dd/yyyy");
            string EndDate = newDate.ToString("MM/dd/yyyy");
            string GetDate = DateTime.Now.ToString("MMddyyHHmmss");

            if (AwardType == "Birthday Based")
            {
                Enter_Text_Award_Name("Test" + GetDate);
                Enter_Text_Award_Code("111");
                Enter_Text_Date_StartDate(StartDate);
                Enter_Text_Date_EndDate(EndDate);
                SelectText_DropDown_AwardType("Birthday Based");
                Enter_Text_DaysActive("30");
                Enter_Text_AdvanceDeliveryDays("5");
                Admin_DropDown_MinQualifiedStay(MinQualifiedStay);
                Admin_DropDown_MemberLevel(MemberLevel);
                Admin_DropDown_EmailName("Birthday Email");
                Logger.WriteDebugMessage("Entered all data for Birthday Based form.");
            }
            else if (AwardType == "Nights Based")
            {
                Enter_Text_Award_Name("Test" + GetDate);
                Enter_Text_Date_StartDate(StartDate);
                Enter_Text_Date_EndDate(EndDate);
                Admin_DropDown_NightCycle("02");
                Admin_DropDown_NightAwarded("1");
                Admin_DropDown_NightExpMonth("02");
                Admin_DropDown_MemberLevel(MemberLevel);
                Enter_Text_MaxAwardperMember("5");
                Admin_DropDown_EmailName("Test Award");

                Logger.WriteDebugMessage("Entered all data for Night Based form.");
            }
            Admin.Admin_Award_Savebtn();
        }
        /*
        public static void VerifyAwardsNameChar()
        {
            string GetEnteredValue = Helper.Getdata(PageObject_Admin.Admin_Text_Award_Name());
            int GetEnterValueLength = GetEnteredValue.Length;

            Enter_Text_Award_Name(TestData.TC_112157_AwardName_1);
            if (GetEnterValueLength <= 100)
            {
                Logger.WriteDebugMessage("Entered Value in Award Name text box is equal to 100 or less that than 100");
            }
            else
            {
                TestHandling.TestFailed(new Exception("Award Name Text box is accepting more than 100 characters"));
            }
            Enter_Text_Award_Name(TestData.TC_112157_AwardName_2);
            if (GetEnterValueLength <= 100)
            {
                Logger.WriteDebugMessage("Entered Value in Award Name text box is equal to 100 or less that than 100");
            }
            else
            {
                TestHandling.TestFailed(new Exception("Award Name Text box is accepting more than 100 characters"));
            }
        }
        */
        public static void LoyaltyAward_SearchData(string data)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Search_LoyaltyAwards(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_Search_LoyaltyAwards(), data);
        }

        public static void Open_AwardPopup()
        {
            //IJavaScriptExecutor js = (IJavaScriptExecutor)Helper.Driver;
            //js.ExecuteScript("document.querySelectorAll('tr[data-id=\"list_'" + AwardID + "'\"]+div')[0].click();");
            Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//table[@id='loyaltyAwards01']/tbody/tr/td[10]/button")));
        }

        public static void VerifyFormisFilled(string AwardType, string AwardID, string AwardName)
        {
            LoyaltyAward_SearchData(AwardName);

            Open_AwardPopup();

            if (AwardType == "Birthday Based")
            {
                var GetAwardName = Helper.Getdata(PageObject_Admin.Admin_Text_Award_Name());
                var GetAwardCode = Helper.Getdata(PageObject_Admin.Admin_Text_Award_Code());
                var GetAwardStartDate = Helper.Getdata(PageObject_Admin.Admin_Text_Date_StartDate());
                var GetAwardEndDate = Helper.Getdata(PageObject_Admin.Admin_Text_Date_EndDate());
                var GetAwardtype = Helper.Getdata(PageObject_Admin.Admin_DropDown_AwardType());
                var GetAwardDaysActive = Helper.Getdata(PageObject_Admin.Admin_Text_DaysActive());
                var GetAwardAdvanceDelliveryDays = Helper.Getdata(PageObject_Admin.Admin_Text_AdvanceDeliveryDays());
                var GetAwardMinQualified = Helper.Getdata(PageObject_Admin.Admin_DropDown_MinQualifiedStay());
                var GetAwardMemberLevel = Helper.Getdata(PageObject_Admin.Admin_DropDown_MemberLevel());
                var GetAwardMemberName = Helper.Getdata(PageObject_Admin.Admin_DropDown_EmailName());

                if (string.IsNullOrEmpty(GetAwardName) || string.IsNullOrEmpty(GetAwardCode) || string.IsNullOrEmpty(GetAwardStartDate) || string.IsNullOrEmpty(GetAwardEndDate)
                    || string.IsNullOrEmpty(GetAwardtype) || string.IsNullOrEmpty(GetAwardDaysActive) || string.IsNullOrEmpty(GetAwardAdvanceDelliveryDays) ||
                    string.IsNullOrEmpty(GetAwardMinQualified) || string.IsNullOrEmpty(GetAwardMemberLevel) || string.IsNullOrEmpty(GetAwardMemberName))
                {
                    TestHandling.TestFailed(new Exception("One of the fields is empty."));
                }
            }
            else if (AwardType == "Nights Based")
            {

            }
        }

        public static void verifydate()
        {
            var GetAwardStartDate = Helper.Getdata(PageObject_Admin.Admin_Text_Date_StartDate());
            var GetAwardEndDate = Helper.Getdata(PageObject_Admin.Admin_Text_Date_EndDate());

            if (DateTime.Parse(GetAwardStartDate) > DateTime.Parse(GetAwardEndDate))
            {
                TestHandling.TestFailed(new Exception("Start Date is greater than End Date"));
            }
        }

        public static void VerfiyAwardNameCharacLen()
        {
            Enter_Text_Award_Name("HJNJPICVvcCmivbUZqHeyeVOMVkmpvFmJRkbenRHaDbUGBmiPvIRqNBltlmpfnNqfjHPffMGamgEvvriIvoampEIHQqZJibBDgAtQqZJibBDgAtQqZJibBDgAt");
            var GetAwardName = Helper.Getdata(PageObject_Admin.Admin_Text_Award_Name());

            if (GetAwardName.Length > 100)
            {
                TestHandling.TestFailed(new Exception("Character Length of Award Name is greater than 100."));
            }

        }
        /*
        public static void VerifyGridHeader()
        {
            if (Helper.VerifyTextOnPage(TestData.TC_112449_Column_1) || Helper.VerifyTextOnPage(TestData.TC_112449_Column_2)
                || Helper.VerifyTextOnPage(TestData.TC_112449_Column_3) || Helper.VerifyTextOnPage(TestData.TC_112449_Column_4)
                || Helper.VerifyTextOnPage(TestData.TC_112449_Column_5) || Helper.VerifyTextOnPage(TestData.TC_112449_Column_6)
                || Helper.VerifyTextOnPage(TestData.TC_112449_Column_7) || Helper.VerifyTextOnPage(TestData.TC_112449_Column_8)
                || Helper.VerifyTextOnPage(TestData.TC_112449_Column_9) || Helper.VerifyTextOnPage(TestData.TC_112449_Column_10))
                Logger.WriteDebugMessage("Confirmed Grid Header");
            else
            {
                TestHandling.TestFailed(new Exception("One of the grid header is changed."));
            }
        }
        */
        public static string ConvertMemberShipLevel_LowerCases(string value)
        {
            string level = value.ToLower().Substring(1);
            string level_Lower = value.ToCharArray().GetValue(0).ToString();
            string memberlevel = String.Concat(level_Lower, level);
            return memberlevel;
        }

        public static string AssignState(string ProjectName)
        {
            string state;
            if (ProjectName.Equals("Fraser"))
            {
                state = "California";
            }
            else
            {
                state = "CALIFORNIA";
            }
            return state;
        }
        public static void ForgotPassword_LinkText()
        {
            Helper.ElementWait(PageObject_Admin.ForgotPassword_LinkText(), 240);
            Helper.ElementClick(PageObject_Admin.ForgotPassword_LinkText());
        }

        public static void MemberBatchUpload_Tab()
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberBatchUpload_Tab(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_MemberBatchUpload_Tab());
        }
        public static void Admin_MemberBatchUpload_BtachRegistration_SubTab()
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberBatchUpload_BtachRegistration_SubTab(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_MemberBatchUpload_BtachRegistration_SubTab());
        }
        public static void Click_MemberBatchUpdate()
        {
            Helper.ElementWait(PageObject_Admin.Click_MemberBatchUpdate(), 240);
            Helper.ElementClick(PageObject_Admin.Click_MemberBatchUpdate());
        }
        public static void BatchUpdate_DownloadTemplete()
        {
            Helper.ElementWait(PageObject_Admin.BatchUpdate_DownloadTemplete(), 240);
            Helper.ElementClick(PageObject_Admin.BatchUpdate_DownloadTemplete());
        }
        public static void BatchUpload_DownloadTemplete()
        {
            Helper.ElementWait(PageObject_Admin.BatchUpload_DownloadTemplete(), 240);
            Helper.ElementClick(PageObject_Admin.BatchUpload_DownloadTemplete());
        }
        public static void BatchUpdate_UploadTemplete()
        {
            Helper.ElementWait(PageObject_Admin.BatchUpdate_UploadTemplete(), 240);
            Helper.ElementClick(PageObject_Admin.BatchUpdate_UploadTemplete());
        }
        public static void BatchUpload_UploadFile(string fullpath)
        {
            Helper.ElementWait(PageObject_Admin.BatchUpload_UploadFile(), 240);
            Helper.ElementClick(PageObject_Admin.BatchUpload_UploadFile());
            TestData.ExcelData.ExcelDataReader.uploadfile(fullpath);
            Helper.AddDelay(5000);
            //Logger.WriteDebugMessage("File Selected");
            Helper.ElementClick(PageObject_Admin.BatchUpload_ClickonUpload());

        }

        public static void BatchUpdate_UploadFile(string fullpath)
        {
            Helper.ElementWait(PageObject_Admin.BatchUpdate_UploadFile(), 240);
            Helper.ElementClick(PageObject_Admin.BatchUpdate_UploadFile());
            TestData.ExcelData.ExcelDataReader.uploadfile(fullpath);
            Helper.AddDelay(5000);
            Logger.WriteDebugMessage("File Selected");
            Helper.ElementClick(PageObject_Admin.BatchUpdate_UploadFiles());

        }
        public static void VerifyUploadedDetails(string filename)
        {
            Helper.ElementClick(PageObject_Admin.MemberUpload_Refreshbutton());
            Helper.AddDelay(5000);
            Helper.ElementEnterText(PageObject_Admin.Admin_Memberupload_Text_Filter(), filename);
            Helper.AddDelay(5000);
            Click_MemberBatchUpdate_UploadDateAndTime();
            Logger.WriteDebugMessage("Filtered the result by Latest Excel file");
            Helper.VerifyTextOnPageAndHighLight(filename);
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.MemberUploadedDetails());
            Helper.ElementClick(PageObject_Admin.MemberUploadedDetails());
            Logger.WriteDebugMessage("Uploaded Details are displayed on the screen");
        }

        public static void Click_MemberBatchUpdate_UploadDateAndTime()
        {
            Helper.ElementWait(PageObject_Admin.Click_MemberBatchUpdate_UploadDateAndTime(), 240);
            Helper.ElementClick(PageObject_Admin.Click_MemberBatchUpdate_UploadDateAndTime());
        }

        public static void VerifyUpdatedDetails(string filename)
        {
            Helper.ElementClick(PageObject_Admin.MemberUpdate_Refreshbutton());
            Helper.AddDelay(5000);
            Helper.ElementEnterText(PageObject_Admin.Admin_Memberupdate_Text_Filter(), filename);
            Helper.AddDelay(5000);
            Logger.WriteDebugMessage("Filtered the result by Latest Excel file");
            Helper.VerifyTextOnPageAndHighLight(filename);
            Helper.ElementClick(PageObject_Admin.MemberUpdateDetails());
            Logger.WriteDebugMessage("Uploaded Details are displayed on the screen");
        }
        public static void BatchUpdate_UpdateTemplete()
        {
            Helper.ElementWait(PageObject_Admin.BatchUpdate_UpdateTemplete(), 240);
            Helper.ElementClick(PageObject_Admin.BatchUpdate_UpdateTemplete());
        }

        public static void Click_CloseButton_OnMemberBatchUpdateDetailsPopup()
        {
            Helper.ElementWait(PageObject_Admin.Click_CloseButton_OnMemberBatchUpdateDetailsPopup(), 240);
            Helper.ElementClick(PageObject_Admin.Click_CloseButton_OnMemberBatchUpdateDetailsPopup());
        }

        public static void Click_MemberSearchTab()
        {
            Helper.ElementWait(PageObject_Admin.Click_MemberSearchTab(), 240);
            Helper.ElementClick(PageObject_Admin.Click_MemberSearchTab());
        }

        public static void BatchUploadRegistraion()
        {
            Helper.ElementWait(PageObject_Admin.BatchUploadRegistraion(), 240);
            Helper.ElementClick(PageObject_Admin.BatchUploadRegistraion());
        }
        public static void Admin_MemberInformation_Tab()
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberInformation_Tab(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_MemberInformation_Tab());
        }

        public static void Admin_Subtab_CommonMethod(string subtabname)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Subtab_CommonMethod(subtabname), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Subtab_CommonMethod(subtabname));
        }
        public static void Click_Member_Level_Email_No_Button()
        {
            Helper.ElementWait(PageObject_Admin.Click_Member_Level_Email_No_Button(), 240);
            Helper.ElementClick(PageObject_Admin.Click_Member_Level_Email_No_Button());
        }
        public static void MemberLevel_CrossButton()
        {
            Helper.ElementWait(PageObject_Admin.MemberLevel_CrossButton(), 240);
            Helper.ElementClick(PageObject_Admin.MemberLevel_CrossButton());
        }
        public static void Click_LoyaltyRules_MemberLevelRules_Tab()
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_Tab(), 240);
            Helper.ElementClick(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_Tab());
        }
        public static void Click_LoyaltyRules_MemberLevelRules_AddRule()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule());
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule(), 240);
            Helper.ElementClick(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule());
        }
        public static void Click_LoyaltyRules_MemberLevelRules_Filters(string text)
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_Filters(), 240);
            Helper.ElementEnterText(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_Filters(), text);
        }
        public static void Click_LoyaltyRules_MemberLevelRules_AddRule_RefferalCode(string text)
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_RefferalCode(), 240);
            Helper.ElementEnterText(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_RefferalCode(), text);
        }
        public static void Click_LoyaltyRules_MemberLevelRules_AddRule_QualifyingNights(string text)
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_QualifyingNights(), 240);
            Helper.ElementEnterText(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_QualifyingNights(), text);
        }
        public static void Click_LoyaltyRules_MemberLevelRules_AddRule_StayType(string text)
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_StayType(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_StayType(), text);
        }
        public static void Click_LoyaltyRules_MemberLevelRules_AddRule_NewLevel(string text)
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_NewLevel(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_NewLevel(), text);
        }
        public static void Click_LoyaltyRules_MemberLevelRules_AddRule_CancelButton()
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_CancelButton(), 240);
            Helper.ElementClick(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_CancelButton());
        }
        public static void Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton()
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton(), 240);
            Helper.ElementClick(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton());
        }
        public static void Click_LoyaltyRules_MemberLevelRules_EditButton()
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_EditButton(), 240);
            Helper.ElementClick(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_EditButton());
        }
        public static void Click_LoyaltyRules_MemberLevelRules_DeleteButton()
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_DeleteButton(), 240);
            Helper.ElementClick(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_DeleteButton());
        }
        public static void Click_LoyaltyRules_MemberLevelRules_PrevButton()
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_PrevButton(), 240);
            Helper.ElementClick(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_PrevButton());
        }
        public static void Click_LoyaltyRules_MemberLevelRules_NextButton()
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_NextButton(), 240);
            Helper.ElementClick(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_NextButton());
        }
        public static void Click_LoyaltyRules_MemberLevelRules_DeleteConfirmButton()
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_DeleteConfirmButton(), 240);
            Helper.ElementClick(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_DeleteConfirmButton());
        }
        public static void MemberLevelRules_AddRule(string refferalCode, string qualifyingNights, string stayType, string newLevel)
        {
            Click_LoyaltyRules_MemberLevelRules_AddRule();
            Logger.WriteDebugMessage("Clicked on Add Rule button");
            Click_LoyaltyRules_MemberLevelRules_AddRule_RefferalCode(refferalCode);
            Click_LoyaltyRules_MemberLevelRules_AddRule_QualifyingNights(qualifyingNights);
            Click_LoyaltyRules_MemberLevelRules_AddRule_StayType(stayType);
            Click_LoyaltyRules_MemberLevelRules_AddRule_NewLevel(newLevel);
            Logger.WriteDebugMessage("All details entered");
        }
        public static void MemberLevelRules_EditRule(string refferalCode, string qualifyingNights, string stayType, string newLevel)
        {
            Click_LoyaltyRules_MemberLevelRules_EditButton();
            Logger.WriteDebugMessage("Clicked on Edit Rule button");
            Click_LoyaltyRules_MemberLevelRules_AddRule_RefferalCode(refferalCode);
            Click_LoyaltyRules_MemberLevelRules_AddRule_QualifyingNights(qualifyingNights);
            Click_LoyaltyRules_MemberLevelRules_AddRule_StayType(stayType);
            Click_LoyaltyRules_MemberLevelRules_AddRule_NewLevel(newLevel);
            Logger.WriteDebugMessage("Edited details entered");
            Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton();
            Click_LoyaltyRules_MemberLevelRules_Filters(refferalCode);
            Helper.VerifyTextOnPageAndHighLight(refferalCode);
            Logger.WriteDebugMessage("Edited rule saved successfully");
        }

        public static void MemberLevelRules_DeleteRule(string refferalCode)
        {
            Click_LoyaltyRules_MemberLevelRules_Filters(refferalCode);
            Click_LoyaltyRules_MemberLevelRules_DeleteButton();
            Logger.WriteDebugMessage("Delete confirmation pop up get displayed");
            Click_LoyaltyRules_MemberLevelRules_DeleteConfirmButton();
            Helper.AddDelay(3000);
            Logger.WriteDebugMessage("Member rule deleted successfully");
        }
        public static void Click_LoyaltyRules_MemberLevelRules_PaginationDropdown()
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_PaginationDropdown(), 240);
            Helper.ElementClick(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_PaginationDropdown());
        }
        public static string Get_LoyaltyRules_MemberLevelRules_PaginationDropdown(int value)
        {
            return PageObject_Admin.Get_LoyaltyRules_MemberLevelRules_PaginationDropdown(value).GetAttribute("innerHTML");
        }
        public static void Click_LoyaltyRules_MemberLevelRules_DeleteCancle()
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_DeleteCancle(), 240);
            Helper.ElementClick(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_DeleteCancle());
        }
        public static void Click_LoyaltyRules_PointsEarningRule_RuleRestriction()
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_PointsEarningRule_RuleRestriction(), 240);
            Helper.ElementClick(PageObject_Admin.Click_LoyaltyRules_PointsEarningRule_RuleRestriction());
        }
        public static string Click_LoyaltyRules_PointsEarningRule_RuleRestriction_ChannelCodeValue()
        {
            return PageObject_Admin.Click_LoyaltyRules_PointsEarningRule_RuleRestriction_ChannelCodeValue().GetAttribute("innerHTML");
        }

        public static void Select_MembershipLevel_Entries(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_Admin.Select_MembershipLevel_Entries(), value);
        }
        public static void Enter_MembershipLevel_Filter(string value)
        {
            Helper.ElementClearText(PageObject_Admin.Enter_MembershipLevel_Filter());
            Helper.ElementEnterText(PageObject_Admin.Enter_MembershipLevel_Filter(), value);
        }

        #endregion[Admin]

        #region[Admin_Navigation]
        public static void Click_Tab_MemberTransactions()
        {
            Helper.ElementWait(PageObject_Admin.Tab_MemberTransactions(), 240);
            Helper.ElementClick(PageObject_Admin.Tab_MemberTransactions());
        }

        public static void Click_Tab_PointsHistory()
        {
            Helper.ElementWait(PageObject_Admin.Tab_PointsHistory(), 150);
            Helper.ElementClick(PageObject_Admin.Tab_PointsHistory());
        }

        public static void Click_Tab_MemberAwards()
        {
            Helper.ElementWait(PageObject_Admin.Tab_MemberAwards(), 240);
            Helper.ElementClick(PageObject_Admin.Tab_MemberAwards());
        }

        public static void Click_Tab_Invites()
        {
            Helper.ElementWait(PageObject_Admin.Tab_Invites(), 240);
            Helper.ElementClick(PageObject_Admin.Tab_Invites());
        }

        public static void Click_Tab_MemberStay()
        {
            Helper.ElementWait(PageObject_Admin.Tab_MemberStay(), 240);
            Helper.ElementClick(PageObject_Admin.Tab_MemberStay());
        }

        public static void Click_Tab_Redemptions()
        {
            Helper.ElementWait(PageObject_Admin.Tab_Redemptions(), 240);
            Helper.ElementClick(PageObject_Admin.Tab_Redemptions());
        }

        public static void Click_Tab_AdminUpdates()
        {
            Helper.ElementWait(PageObject_Admin.Tab_AdminUpdates(), 240);
            Helper.ElementClick(PageObject_Admin.Tab_AdminUpdates());
        }
        public static void Click_AdminUpdates_Button_Close()
        {
            Helper.ElementWait(PageObject_Admin.Click_AdminUpdates_Button_Close(), 240);
            Helper.ElementClick(PageObject_Admin.Click_AdminUpdates_Button_Close());
        }
        public static void Click_SubTab_TransactionReason()
        {
            Helper.ElementWait(PageObject_Admin.SubTab_TransactionReason(), 240);
            Helper.ElementClick(PageObject_Admin.SubTab_TransactionReason());
        }

        public static void Click_SubTab_TermsAndConditions()
        {
            Helper.ElementWait(PageObject_Admin.SubTab_TermsAndConditions(), 240);
            Helper.ElementClick(PageObject_Admin.SubTab_TermsAndConditions());
        }

        public static void Click_SubTab_Offers()
        {
            Helper.ElementWait(PageObject_Admin.SubTab_Offers(), 180);
            Helper.ElementClick(PageObject_Admin.SubTab_Offers());
        }

        public static void Click_SubTab_SignUpSources()
        {
            Helper.ElementWait(PageObject_Admin.SubTab_SignUpSources(), 240);
            Helper.ElementClick(PageObject_Admin.SubTab_SignUpSources());
        }

        public static void Click_Menu_LoyaltySetup()
        {
            Helper.ElementWait(PageObject_Admin.Menu_LoyaltySetup(), 240);
            Helper.ElementClick(PageObject_Admin.Menu_LoyaltySetup());
        }

        public static void Click_Menu_Home()
        {
            Helper.ElementWait(PageObject_Admin.Menu_Home(), 240);
            Helper.ElementClick(PageObject_Admin.Menu_Home());
        }

        public static void Click_Menu_ManualMerge()
        {
            Helper.ElementWait(PageObject_Admin.Menu_ManualMerge(), 240);
            Helper.ElementClick(PageObject_Admin.Menu_ManualMerge());
        }

        public static void Click_Menu_Users()
        {
            Helper.ElementWait(PageObject_Admin.Menu_Users(), 240);
            Helper.ElementClick(PageObject_Admin.Menu_Users());
        }
        public static void Click_Menu_UsersSetting()
        {
            Helper.ElementWait(PageObject_Admin.Submenu_Users_setting(), 240);
            Helper.ElementClick(PageObject_Admin.Submenu_Users_setting());
        }

        public static void Click_Menu_EmailSetuUp()
        {
            Helper.ElementClick(Helper.ElementWait(PageObject_Admin.Menu_EmailSetUp(), 240));
        }

        public static void Click_Menu_LoyaltyRules()
        {
            Helper.ElementWait(PageObject_Admin.Menu_LoyaltyRules(), 240);
            Helper.ElementClick(PageObject_Admin.Menu_LoyaltyRules());
        }

        public static void Click_Menu_LoyaltyAwards()
        {
            Helper.ElementWait(PageObject_Admin.Menu_LoyaltyAwards(), 240);
            Helper.ElementClick(PageObject_Admin.Menu_LoyaltyAwards());
        }
        public static void Click_Menu_LoyaltyeGifts()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Menu_LoyaltyeGifts(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Menu_LoyaltyeGifts());


        }
        public static void Click_Menu_Redeem()
        {
            Helper.ElementWait(PageObject_Admin.Menu_Redeem(), 240);
            Helper.ElementClick(PageObject_Admin.Menu_Redeem());
        }

        public static void Click_SubTab_QualifyingRules()
        {
            Helper.ElementWait(PageObject_Admin.SubTab_QualifyingRules(), 240);
            Helper.ElementClick(PageObject_Admin.SubTab_QualifyingRules());
        }

        public static void Click_SubTab_PointsEarningRules()
        {
            Helper.ElementWait(PageObject_Admin.SubTab_PointsEarningRules(), 240);
            Helper.ElementClick(PageObject_Admin.SubTab_PointsEarningRules());
        }

        public static void Admin_Menu_ContentManagment_Tab()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Menu_ContentManagment_Tab(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Menu_ContentManagment_Tab());
        }
        public static void Admin_Menu_LoyaltyMapping_Tab()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Menu_LoyaltyMapping_Tab(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Menu_LoyaltyMapping_Tab());
        }

        public static void Click_AddAward()
        {
            Helper.ElementWait(PageObject_Admin.Click_AddAward(), 240);
            Helper.ElementClick(PageObject_Admin.Click_AddAward());
        }
        #endregion[Admin_Navigation]

        #region[Admin_Information]
        public static void SelectStatus(string value)
        {
            Helper.ElementWait(PageObject_Admin.Value_MemberStatus(), 240);
            Helper.ElementClick(PageObject_Admin.Value_MemberStatus());
            Helper.ElementSelectFromDropDown(PageObject_Admin.MemberInformation_Dropdown_MemberStatus(), value);
            Helper.ElementClick(PageObject_Admin.Icon_Right());
            Helper.AddDelay(5000);
        }

        public static void SelectLevel(string value)
        {
            Helper.ElementWait(PageObject_Admin.Value_Information_MemberLevel(), 240);
            Helper.ElementClick(PageObject_Admin.Value_Information_MemberLevel());
            Helper.ElementSelectFromDropDown(PageObject_Admin.MemberInformation_Dropdown_MemberStatus(), value);
            Logger.WriteDebugMessage("Selected " + value + " member Level");
            Helper.ElementClick(PageObject_Admin.Icon_Right());
        }


        public static void Admin_MemberInformation_Send_Email_Popup_Close()
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberInformation_Send_Email_Popup_Close(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_MemberInformation_Send_Email_Popup_Close());
        }

        public static void SendResetLogin(string value)
        {
            Helper.ElementWait(PageObject_Admin.MemberInformation_Value_MemberLogin(), 240);
            Helper.ElementClick(PageObject_Admin.MemberInformation_Value_MemberLogin());
            PageObject_Admin.MemberInformation_Text_UserLogin().Clear();
            Helper.ElementEnterText(PageObject_Admin.MemberInformation_Text_UserLogin(), value);
            Logger.WriteDebugMessage("Member Login Reset Pop-up is Displayed");
            Helper.ElementClick(PageObject_Admin.MemberInformation_Button_Update());
        }

        public static void VerifyMemberLevelEmailOverlay()
        {
            if (PageObject_Admin.MemberLevel_Email_Overlay())
                Assert.Fail("Member Level email Overlay is getting Displayed");
            else
                Logger.WriteDebugMessage("Member Level email Overlay is not getting displayed");
        }
        public static void Admin_Update_View_Overlay_Close()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Update_View_Overlay_Close(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Update_View_Overlay_Close());
        }
        public static void SendResetLogin_clear(string value)
        {
            Helper.ElementWait(PageObject_Admin.MemberInformation_Value_MemberLogin(), 240);
            Helper.ElementClick(PageObject_Admin.MemberInformation_Value_MemberLogin());
            Helper.ElementEnterText(PageObject_Admin.MemberInformation_Text_UserLogin(), value);
            Helper.ElementClick(PageObject_Admin.MemberInformation_Button_Update());
        }

        public static void Click_MemberInformation_Icon_Close()
        {
            Helper.ElementWait(PageObject_Admin.MemberInformation_ResetLogin_Icon_Close(), 240);
            Helper.ElementClick(PageObject_Admin.MemberInformation_ResetLogin_Icon_Close());
        }

        public static void Click_MemberInformation_Value_MemberLogin()
        {
            Helper.ElementWait(PageObject_Admin.MemberInformation_Value_MemberLogin(), 240);
            Helper.ElementClick(PageObject_Admin.MemberInformation_Value_MemberLogin());
        }

        public static void Click_MemberInformation_Value_ActivationEmail()
        {
            Helper.ElementWait(PageObject_Admin.MemberInformation_Value_ActivationEmail(), 240);
            Helper.ElementClick(PageObject_Admin.MemberInformation_Value_ActivationEmail());
        }

        public static void Click_ActivationEmail_Icon_Close()
        {
            Helper.ElementWait(PageObject_Admin.Admin_ActivationEmail_Icon_Close(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_ActivationEmail_Icon_Close());
        }

        public static void Click_ExpirationDate()
        {
            Helper.ElementWait(PageObject_Admin.Click_ExpirationDate(), 840);
            Helper.ElementClick(PageObject_Admin.Click_ExpirationDate());
        }

        public static void Click_ExpirationDateSubmit()
        {
            Helper.ElementWait(PageObject_Admin.Click_ExpirationDateSubmit(), 240);
            Helper.ElementClick(PageObject_Admin.Click_ExpirationDateSubmit());
        }

        public static void Click_MemberAwardStatus()
        {
            Helper.ElementWait(PageObject_Admin.Click_MemberAwardStatus(), 240);
            Helper.ElementClick(PageObject_Admin.Click_MemberAwardStatus());
        }

        public static void Click_AdminSendResend()
        {
            Helper.ElementWait(PageObject_Admin.Click_AdminSendResend(), 240);
            Helper.ElementClick(PageObject_Admin.Click_AdminSendResend());
        }

        public static void click_ResendAwardEmail_Close()
        {
            Helper.ElementWait(PageObject_Admin.click_ResendAwardEmail_Close(), 240);
            Helper.ElementClick(PageObject_Admin.click_ResendAwardEmail_Close());
        }
        public static void Click_WelcomeEmail_Icon_Close()
        {
            Helper.ElementWait(PageObject_Admin.Admin_WelcomeEmail_Icon_Close(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_WelcomeEmail_Icon_Close());
        }

        public static void Click_MemberInformation_Value_WelcomeEmail()
        {
            Helper.ElementWait(PageObject_Admin.MemberInformation_Value_WelcomeEmail(), 240);
            Helper.ElementClick(PageObject_Admin.MemberInformation_Value_WelcomeEmail());
        }

        public static void Click_MemberInformation_Value_MemberPortal()
        {
            Helper.ElementWait(PageObject_Admin.MemberInformation_Value_MemberPortal(), 240);
            Helper.ElementClick(PageObject_Admin.MemberInformation_Value_MemberPortal());
        }

        public static void ValidateEmailStatus(string status)
        {
            string value = PageObject_Admin.MemberInformation_Value_EmailStatus().GetAttribute("innerHTML");
            Helper.AddDelay(2400);
            if (value.Contains(status))
            {
                Logger.WriteDebugMessage("Status is flipped as " + status);
            }
            else
            {
                Assert.Fail("Status is NOT updated as" + status);
            }

        }

        public static void ValidateActivatedField(string ProjectName)
        {
            if (!ProjectName.Equals("HotelIcon"))
            {
                Helper.HighlightElement(PageObject_Admin.MemberInformation_Value_ActivatedDate());
            }
            else
            {
                Logger.WriteDebugMessage("Activate Date field is NOT present for " + ProjectName);
            }

        }

        public static void ValidateActivatedDate(string ProjectName, string value)
        {
            if (!ProjectName.Equals("HotelIcon"))
            {
                Helper.HighlightElement(PageObject_Admin.MemberInformation_Value_ActivatedDate());
                string date = PageObject_Admin.MemberInformation_Value_ActivatedDate().GetAttribute("innerHTML");
                if (date.Contains(value))
                {
                    Logger.WriteDebugMessage("Date matches with Admin Registration Date");
                }
                else
                {
                    Assert.Fail("Date does NOT matches with Admin Registration Date");
                }
            }
            else
            {
                Logger.WriteDebugMessage("Activate Date field is NOT present for " + ProjectName);
            }

        }

        public static void SendActivationEmail()
        {
            Helper.ElementWait(PageObject_Admin.MemberInformation_Value_ActivationEmail(), 240);
            Helper.ElementClick(PageObject_Admin.MemberInformation_Value_ActivationEmail());
            Logger.WriteDebugMessage("Activation Email Pop-up is Displayed");
            Helper.ElementClick(PageObject_Admin.MemberInformation_Activation_Button_SendEmail());
        }

        public static void SendWelcomeEmail()
        {
            Helper.ElementWait(PageObject_Admin.MemberInformation_Value_WelcomeEmail(), 240);
            Helper.ElementClick(PageObject_Admin.MemberInformation_Value_WelcomeEmail());
            Logger.WriteDebugMessage("Welcome Email Pop-up is Displayed");
            Helper.ElementClick(PageObject_Admin.MemberInformation_Welcome_Button_SendEmail());
        }

        public static string GetMemberInformation_Email()
        {
            string email = PageObject_Admin.Admin_MemberInformation_Value_Email().Text;
            string[] value = email.Split(':');
            return value[1];
        }

        #endregion[Admin_Information]

        #region[Admin_MemberTransaction]
        public static void Click_Button_AddTransaction()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.Button_AddTransactions());
            Helper.ElementWait(PageObject_Admin.Button_AddTransactions(), 240);
            Helper.ElementClick(PageObject_Admin.Button_AddTransactions());
        }

        public static void Click_RadioButton_SendEmailToMember()
        {
            Helper.ElementWait(PageObject_Admin.RadioButton_SendEmailToMember(), 240);
            Helper.ElementClick(PageObject_Admin.RadioButton_SendEmailToMember());
        }

        public static void Click_RadioButton_AddCommentsToEmail()
        {
            Helper.ElementWait(PageObject_Admin.RadioButton_AddCommentsToEmail(), 240);
            Helper.ElementClick(PageObject_Admin.RadioButton_AddCommentsToEmail());
        }

        public static void Enter_Text_Points(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.Text_Points());
            for (int i = 1; i <= int.Parse(value); i++)
            {
                action.SendKeys(OpenQA.Selenium.Keys.ArrowUp);
            }
            action.Build().Perform();

        }

        public static void Enter_Text_NegativePoints(string value)
        {
            int value1 = Convert.ToInt32(value.Trim('-'));
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.Text_Points());
            for (int i = 1; i <= value1; i++)
            {
                action.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            }
            action.Build().Perform();

        }

        public static void SelectTransactionReason(string value)
        {
            Helper.ElementWait(PageObject_Admin.Dropdown_TransactionReason(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Dropdown_TransactionReason(), value);
        }

        public static void EnterExpiration(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementEnterText(PageObject_Admin.Text_ExpirationDate(), value);
            Helper.ElementClick(PageObject_Admin.DatePicker_ExpirationDate());
            action.SendKeys(OpenQA.Selenium.Keys.Enter);
            action.Build().Perform();
        }

        public static void EnterBCC(string value)
        {
            Helper.ElementWait(PageObject_Admin.Text_BCC(), 240);
            Helper.ElementEnterText(PageObject_Admin.Text_BCC(), value);
        }

        public static void EnterInternalComments(string value)
        {
            Helper.ElementWait(PageObject_Admin.Text_InternalComments(), 240);
            Helper.ElementEnterText(PageObject_Admin.Text_InternalComments(), value);
        }

        public static void EnterCommentsToGuest(string value)
        {
            Helper.ElementWait(PageObject_Admin.Text_CommentsToGuest(), 240);
            Helper.ElementEnterText(PageObject_Admin.Text_CommentsToGuest(), value);
        }

        public static void Click_Button_Save()
        {
            Helper.ElementWait(PageObject_Admin.Button_Save(), 240);
            Helper.ElementClick(PageObject_Admin.Button_Save());
        }

        public static void Click_Icon_Close()
        {
            Helper.ElementWait(PageObject_Admin.MemberTransaction_Icon_Close(), 240);
            Helper.ElementClick(PageObject_Admin.MemberTransaction_Icon_Close());
        }

        public static void Click_Text_Hotel()
        {
            Helper.ElementWait(PageObject_Admin.Text_Hotel(), 240);
            Helper.ElementClick(PageObject_Admin.Text_Hotel());
        }

        public static void Click_RadioButton_Hotel()
        {
            Helper.ElementWait(PageObject_Admin.RadioButton_Hotel(), 240);
            Helper.ElementClick(PageObject_Admin.RadioButton_Hotel());
        }

        public static void SelectHotel(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.RadioButton_Hotel());
            Helper.ElementClick(PageObject_Admin.Text_Hotel());
            Helper.ElementEnterText(PageObject_Admin.Dropdown_Hotel(), value);
            action.SendKeys(OpenQA.Selenium.Keys.Enter);
            action.Build().Perform();
        }

        public static string BalancePoints()
        {
            string value = PageObject_Admin.MemberInformation_Value_PointsBalance().GetAttribute("innerHTML");
            string[] data = value.Split('>');
            string final = data[2];
            string data1 = final.Trim('"');
            //string finalvalue = data1[2];
            return data1;
        }

        public static void MemberTransaction_SelectPagination(string text)
        {
            Helper.ElementWait(PageObject_Admin.MemberTransaction_Dropdown_Pagination(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.MemberTransaction_Dropdown_Pagination(), text);
        }

        public static void MemberTransaction_VerifyPaginationDropdown()
        {
            List<string> drop = new List<string> { "5", "10", "15", "20" };
            SelectElement soc = new SelectElement(Helper.Driver.FindElement(By.XPath(ObjectRepository.Admin_MemberTransaction_Dropdown_Pagination)));
            IList<IWebElement> options = soc.Options;
            foreach (IWebElement option in options)
            {
                Assert.IsTrue(drop.Contains(option.Text));
            }
        }

        public static void Click_MemberTransaction_Arrow_Next()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.MemberTransaction_Arrow_Next());
            Helper.ElementWait(PageObject_Admin.MemberTransaction_Arrow_Next(), 240);
            Helper.ElementClick(PageObject_Admin.MemberTransaction_Arrow_Next());
        }

        public static void Click_MemberTransaction_Arrow_Previous()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.MemberTransaction_Arrow_Previous());
            Helper.ElementWait(PageObject_Admin.MemberTransaction_Arrow_Previous(), 240);
            Helper.ElementClick(PageObject_Admin.MemberTransaction_Arrow_Previous());
        }

        public static string TransactionReason(string Projectname)
        {
            string reason;
            if (Projectname.Equals("HotelVic"))
            {
                reason = "Manual Points Adjustment";
            }
            else if (Projectname.Equals("SandyLane") || Projectname.Equals("PublicHotel"))
            {
                reason = "Forfeiture";
            }
            else if (Projectname.Equals("MyPlace") || Projectname.Equals("HotelOrigami"))
            {
                reason = "Adjustment";
            }

            else
            {
                reason = "Adjustments";
            }
            return reason;
        }

        public static string TransactionHotel(string Projectname)
        {
            string hotel;
            if (Projectname.Equals("Fraser"))
            {
                hotel = Projectname;
            }
            else if (Projectname.Equals("HotelIcon"))
            {
                hotel = "Hotel Icon";
            }
            else if (Projectname.Equals("HotelVIC"))
            {
                hotel = "Hotel VIC";
            }
            else if (Projectname.Equals("PublicHotel"))
            {
                hotel = "Public Hotel NYC";
            }
            else
            {
                hotel = "Caravelle";
            }
            return hotel;
        }

        /// <summary>
        /// Method to get all the HotelName listed under Transaction tab
        /// </summary>        
        public static List<string> GetHotel()
        {
            List<string> values = new List<string>();
            SelectElement element = new SelectElement(Helper.Driver.FindElement(By.Id("transHotel")));
            IList<IWebElement> options = element.Options;
            foreach (IWebElement option in options)
            {
                values.Add(option.Text);
            }
            return values;
        }


        /// <summary>
        /// Method to get all the transaction reason listed under Transaction reason dropdown.
        /// </summary>        
        public static List<string> GetTransactionReason()
        {
            List<string> values = new List<string>();
            SelectElement element = new SelectElement(PageObject_Admin.Dropdown_TransactionReason());
            IList<IWebElement> options = element.Options;
            foreach (IWebElement option in options)
            {
                values.Add(option.Text);
            }
            return values;
        }


        /// <summary>
        /// Method to add transaction under Member Transactions
        /// </summary>        
        public static void AddTransaction(string reason, string points, string expirationdate, string comments, string guestcomments, string Projectname)
        {
            string reason1 = TransactionReason(Projectname);
            if (reason1.Equals(" "))
                SelectTransactionReason(reason);
            else
                SelectTransactionReason(reason1);
            Enter_Text_Points(points);
            EnterExpiration(expirationdate);
            EnterInternalComments(comments);
            EnterCommentsToGuest(guestcomments);
            Click_RadioButton_SendEmailToMember();
            Click_RadioButton_AddCommentsToEmail();
        }

        /// <summary>
        /// Method to add transaction under Member Transactions with Negative Points
        /// </summary>        
        public static void AddTransaction_NegativePoints(string reason, string points, string expirationdate, string comments, string guestcomments, string Projectname)
        {
            string reason1 = TransactionReason(Projectname);
            if (reason1.Equals(" "))
                SelectTransactionReason(reason);
            else
                SelectTransactionReason(reason1);
            Enter_Text_NegativePoints(points);
            EnterInternalComments(comments);
            EnterCommentsToGuest(guestcomments);
            Click_RadioButton_SendEmailToMember();
            Click_RadioButton_AddCommentsToEmail();
        }

        public static void VerifyMemberEmailField()
        {
            bool value = PageObject_Admin.Text_MemberEmail().Enabled;
            if (value.Equals(false))
            {
                Logger.WriteInfoMessage("Member Email Field is NOT editable");
            }
            else
            {
                Assert.Fail("Member Email Field is editable");
            }
        }

        #endregion[Admin_MemberTransaction]

        #region[Admin_MemberStay]

        public static void Enter_Text_Filter(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberStay_Text_Filter(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_MemberStay_Text_Filter(), value);
        }

        public static void SelectEntries(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Dropdown_Entries(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Admin_Dropdown_Entries(), value);
        }

        public static void Click_Arrow_Previous(string Projectname)
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.Admin_Icon_Previous(Projectname));
            Helper.ElementClick(PageObject_Admin.Admin_Icon_Previous(Projectname));
        }

        public static void Click_Arrow_Next()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.Admin_Icon_Next());
            Helper.ElementClick(PageObject_Admin.Admin_Icon_Next());
        }

        public static void Click_Text_PageNumber(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Text_PageNumber(text), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Text_PageNumber(text));
        }

        public static void Click_MemberstayButton_SearchStay()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.Admin_MemberStay_Button_SearchStay());
            Helper.ElementClick(PageObject_Admin.Admin_MemberStay_Button_SearchStay());
        }

        public static void Click_Drodpown_Property()
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberStay_Dropdown_Property(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_MemberStay_Dropdown_Property());
        }

        public static void Click_MemberstayButton_Search()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.Admin_MemberStay_Button_Search());
            Helper.ElementClick(PageObject_Admin.Admin_MemberStay_Button_Search());
        }

        public static void Enter_Text_DepartureFrom(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberStay_Value_DepartureFrom(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_MemberStay_Value_DepartureFrom(), value);
        }

        public static void Enter_Text_DepartureTo(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberStay_Value_DepartureTo(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_MemberStay_Value_DepartureTo(), value);
        }

        public static void Enter_Text_Firstname(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberStay_Text_FirstName(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_MemberStay_Text_FirstName(), value);
        }

        public static void Enter_Text_Lastname(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberStay_Text_LastName(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_MemberStay_Text_LastName(), value);
        }

        public static void Enter_Text_ReservationNumber(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberStay_Text_ReservationNumber(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_MemberStay_Text_ReservationNumber(), value);
        }

        public static void Enter_Text_Property(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberStay_Value_Property(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_MemberStay_Value_Property(), value);
        }

        public static void SelectProperty(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Click_Drodpown_Property();
            Enter_Text_Property(value);
            action.SendKeys(OpenQA.Selenium.Keys.Enter);
            action.Build().Perform();
        }

        public static void Click_Tab_MemberID()
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberStay_Tab_MemberID(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_MemberStay_Tab_MemberID());
        }

        public static void Click_CheckBox_Select()
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberStay_Checkbox_Select(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_MemberStay_Checkbox_Select());
        }

        public static void Click_MemberStay_Button_Save()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.Admin_MemberStay_Button_Save());
            Helper.ElementClick(PageObject_Admin.Admin_MemberStay_Button_Save());
        }

        public static void Click_Button_Back()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.Admin_MemberStay_Button_Back());
            Helper.ElementClick(PageObject_Admin.Admin_MemberStay_Button_Back());
        }
        public static void Enter_ReservationNumber(string text)
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.Enter_ReservationNumber());
            Helper.ElementEnterText(PageObject_Admin.Enter_ReservationNumber(), text);
        }

        /// <summary>
        /// Method to get all the HotelName listed under Property Dropdown
        /// </summary>        
        public static List<string> GetProperty()
        {
            List<string> values = new List<string>();
            SelectElement element = new SelectElement(Helper.Driver.FindElement(By.Id("getProp")));
            IList<IWebElement> options = element.Options;
            foreach (IWebElement option in options)
            {
                values.Add(option.Text);
            }
            return values;
        }

        /// <summary>
        /// Method to verify entries dropdown value on Member stay page
        /// </summary>
        public static void VerifyEntriesDropdown()
        {
            string[] data = { "5", "10", "15", "20" };
            SelectElement element = new SelectElement(PageObject_Admin.Admin_Dropdown_Entries());
            IList<IWebElement> options = element.Options;
            int i = 0;
            foreach (IWebElement option in options)
            {
                Assert.IsTrue(data[i].Contains(option.Text));
                Logger.WriteDebugMessage(data[i] + " is a value for Entries Dropdown on Member Stay page");
                i++;
            }
        }
        #endregion[Admin_MemberStay]

        #region[Admin_MemberLevel]

        /// <summary>
        /// Method to verify the expiration on Member level up
        /// </summary>
        public static void VerifyExpirationDate(string date, String ProjectName)
        {
            int finalyear;
            string[] data = date.Split('/');
            string todaydate = DateTime.Today.ToString("MM/dd/yyyy");
            string[] splitdate = todaydate.Split('/');
            if (ProjectName.Equals("Virgin"))
            {
                finalyear = Int32.Parse(splitdate[2]);
            }
            if (ProjectName.Equals("Bartell") || ProjectName.Equals("IndependentCollection")) 
            {
                finalyear = Int32.Parse(splitdate[2]) + 2;
            }
            if (ProjectName.Equals("HotelOrigami"))
            {
                finalyear = Int32.Parse(splitdate[2]) + 1;
            }
            else
            {
                finalyear = Int32.Parse(splitdate[2]) + 1;
            }

            if (data[2].Contains(finalyear.ToString()))
            {
                Logger.WriteDebugMessage("Expiration date should be updated to " + finalyear);
            }
            else
            {
                Assert.Fail("Expiration date is NOT matching the criteria");
            }
        }
        /// <summary>
        /// Method to assign member Level as per Project
        /// </summary>
        public static string AssignChangeType(string ProjectName)
        {
            string value = "";
            if (ProjectName.Equals("Bartell") || ProjectName.Equals("HotelOrigami") || ProjectName.Equals("HotelIcon") || ProjectName.Equals("SH") || ProjectName.Equals("IndependentCollection"))
                value = "Update Level";
            else
                value = "Update Member Level";
            return value;
        }

        #endregion[Admin_MemberLevel]

        #region[Admin_MemberStatus]

        public static string GetExpirationDate()
        {
            string date;
            string todaydate = DateTime.Today.ToString("MM/dd/yyyy");
            string[] splitdate = todaydate.Split('/');
            int finalyear = Int32.Parse(splitdate[2]) + 2;
            date = String.Concat(splitdate[0], '/', splitdate[1], '/', finalyear.ToString());
            return date;
        }

        /// <summary>
        /// Method to verify the Member Log on status change
        /// </summary>
        public static void VerifyMemberStatusLog(string email, string status, string user, string date, string Projectname)
        {
            string email1 = email.Trim();
            string userupdated;
            Users data = new Users();
            Queries.GetMemberLogStatus(email1, data);
            string status1 = data.Status.TrimEnd('\t');
            string user1 = data.UpdatedBy.ToLower();
            DateTime dtInsertDate;
            string strInsertDate = "";
            bool isValidDate = DateTime.TryParse(data.InsertDate, out dtInsertDate);
            if (isValidDate)
                strInsertDate = dtInsertDate.ToString("MM/dd/yyyy");

            userupdated = user.ToLower();

            if (status1.Equals(status) && userupdated.Contains(user1) && strInsertDate.Contains(date))
            {
                Logger.WriteDebugMessage("Status , updated by and insert date should display correctly as," + status1 + user1 + strInsertDate);
            }
            else
            {
                Assert.Fail("Status , updated by and insert date is NOT displayed correctly");
            }

        }
        #endregion[Admin_MemberStatus]

        #region[Admin_Adminpdates]

        public static void AdminUpdates_SelectEntries(string value)
        {
            Helper.ElementWait(PageObject_Admin.AdminUpdates_Dropdown_Entries(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.AdminUpdates_Dropdown_Entries(), value);
        }

        public static void AdminUpdates_Text_Filter(string value)
        {
            Helper.ElementWait(PageObject_Admin.AdminUpdates_Text_Filter(), 240);
            Helper.ElementEnterText(PageObject_Admin.AdminUpdates_Text_Filter(), value);
        }
        public static void AdminUpdates_Text_clear()
        {
            Helper.ElementWait(PageObject_Admin.Admin_AdminUpdates_Search_Clear(), 240);
            Helper.ElementClearText(PageObject_Admin.Admin_AdminUpdates_Search_Clear());
        }
        public static void Click_AdminUpdates_Icon_View1()
        {
            Helper.ElementWait(PageObject_Admin.AdminUpdates_Icon_View1(), 240);
            Helper.ElementClick(PageObject_Admin.AdminUpdates_Icon_View1());
        }

        public static void Click_AdminUpdates_Button_Next()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.AdminUpdates_Button_Next());
            Helper.ElementClick(PageObject_Admin.AdminUpdates_Button_Next());
        }

        public static void Click_AdminUpdates_Button_Last()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.AdminUpdates_Button_Last());
            Helper.ElementClick(PageObject_Admin.AdminUpdates_Button_Last());
        }

        public static void Click_AdminUpdates_Button_Prev(string projectname)
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.AdminUpdates_Button_Prev(projectname));
            Helper.ElementClick(PageObject_Admin.AdminUpdates_Button_Prev(projectname));
        }

        public static void Click_AdminUpdates_Button_First()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.AdminUpdates_Button_First());
            Helper.ElementClick(PageObject_Admin.AdminUpdates_Button_First());
        }


        /// <summary>
        /// Method to verify entries dropdown value on Member stay page
        /// </summary>
        public static void VerifyEntriesAdminUpdates_Dropdown(string Projectname)
        {
            if (Projectname.Equals("Bartell") || Projectname.Equals("AquaAston") || Projectname.Equals("ALH") || Projectname.Equals("Fraser") || Projectname.Equals("Iberostar") || Projectname.Equals("Sarova") || Projectname.Equals("HotelOrigami") || Projectname.Equals("MyPlace") || Projectname.Equals("OmniHotels") || Projectname.Equals("HotelIcon") || Projectname.Equals("IndependentCollection"))
            {
                string[] data = { "5", "10", "15", "20", "All" };
                SelectElement element = new SelectElement(PageObject_Admin.AdminUpdates_Dropdown_Entries());
                IList<IWebElement> options = element.Options;
                int i = 0;
                foreach (IWebElement option in options)
                {
                    Assert.IsTrue(data[i].Contains(option.Text));
                    Logger.WriteInfoMessage(data[i] + " is a value for Entries Dropdown on Member Stay page");
                    i++;
                }
            }
            else
            {
                string[] data = { "5", "10", "15", "20", "All" };
                SelectElement element = new SelectElement(PageObject_Admin.AdminUpdates_Dropdown_Entries());
                IList<IWebElement> options = element.Options;
                int i = 0;
                foreach (IWebElement option in options)
                {
                    Assert.IsTrue(data[i].Contains(option.Text));
                    Logger.WriteInfoMessage(data[i] + " is a value for Entries Dropdown on Member Stay page");
                    i++;
                }
            }

        }
        #endregion[Admin_MemberStay]

        #region[Admin_MemberAwards]

        public static void Dropdown_SelectAward(string value)
        {
            SelectElement selectAward = new SelectElement(PageObject_Admin.MemberAwards_Dropdown_SelectAward());
            selectAward.SelectByText(value);
            Helper.AddDelay(2000);
            //Helper.ElementSelectFromDropDown(PageObject_Admin.MemberAwards_Dropdown_SelectAward(), value);
        }

        public static void MemberAwards_Text_Comment(string value)
        {
            Helper.ElementWait(PageObject_Admin.MemberAwards_Text_Comment(), 240);
            Helper.ElementEnterText(PageObject_Admin.MemberAwards_Text_Comment(), value);
        }

        public static void Click_MemberAwards_Button_AddAward()
        {
            Helper.ElementWait(PageObject_Admin.MemberAwards_Button_AddAward(), 240);
            Helper.ElementClick(PageObject_Admin.MemberAwards_Button_AddAward());
        }

        public static void Click_MemberAwards_Button_Save()
        {
            Helper.ElementWait(PageObject_Admin.MemberAwards_Button_Save(), 240);
            Helper.ElementClick(PageObject_Admin.MemberAwards_Button_Save());
        }

        public static void Click_MemberAwards_Icon_Close()
        {
            Helper.ElementWait(PageObject_Admin.MemberAwards_Icon_Close(), 240);
            Helper.ElementClick(PageObject_Admin.MemberAwards_Icon_Close());
        }

        public static void MemberAwards_Text_Filter(string value)
        {
            Helper.ElementWait(PageObject_Admin.MemberAwards_Text_Filter(), 500);
            Helper.ElementEnterText(PageObject_Admin.MemberAwards_Text_Filter(), value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="award"></param>

        /// <summary>
        /// Method to add Member Award
        /// </summary>
        /// <param name="Award"></param>
        /// <param name="comments"></param>
        public static void AddMemberAward(string Award, string comments)
        {
            Dropdown_SelectAward(Award);
            MemberAwards_Text_Comment(comments);
            Logger.WriteDebugMessage(Award + " Award got Selected from the dropdown");
            Click_MemberAwards_Button_Save();
        }

        public static void Dropdown_SelectStatus(string value)
        {
            SelectElement selectAward = new SelectElement(PageObject_Admin.Dropdown_SelectStatus());
            selectAward.SelectByText(value);
        }
        public static void SelectStatusCheck()
        {
            Helper.ElementWait(PageObject_Admin.SelectStatusCheck(), 240);
            Helper.ElementClick(PageObject_Admin.SelectStatusCheck());
        }
        public static void DeleteSelectedStatus()
        {
            Helper.ElementWait(PageObject_Admin.DeleteSelectedStatus(), 240);
            Helper.ElementClick(PageObject_Admin.DeleteSelectedStatus());
        }
        public static string LoyaltyeGift_RemainingBalance()
        {
            return PageObject_Admin.LoyaltyeGift_RemainingBalance().GetAttribute("innerHTML");
        }
        #endregion[Admin_MemberAwards]

        #region[LoyaltySetUp_TransactionReason]

        public static void Click_TransactionReason_Button_AddReason()
        {
            Helper.ElementWait(PageObject_Admin.TransactionReason_Button_AddReason(), 240);
            Helper.ElementClick(PageObject_Admin.TransactionReason_Button_AddReason());
        }

        public static void Click_TransactionReason_Button_Save()
        {
            Helper.ElementWait(PageObject_Admin.TransactionReason_Button_Save(), 240);
            Helper.ElementClick(PageObject_Admin.TransactionReason_Button_Save());
        }

        public static void Click_TransactionReason_Button_Cancel()
        {
            Helper.ElementWait(PageObject_Admin.TransactionReason_Button_Cancel(), 240);
            Helper.ElementClick(PageObject_Admin.TransactionReason_Button_Cancel());
        }

        public static void Click_TransactionReason_Icon_Close()
        {
            Helper.ElementWait(PageObject_Admin.TransactionReason_Icon_Close(), 240);
            Helper.ElementClick(PageObject_Admin.TransactionReason_Icon_Close());
        }

        public static void Click_TransactionReason_Icon_Edit()
        {
            Helper.ElementWait(PageObject_Admin.TransactionReason_Icon_Edit(), 240);
            Helper.ElementClick(PageObject_Admin.TransactionReason_Icon_Edit());
        }

        public static void TransactionReason_Text_Code(string value)
        {
            Helper.ElementWait(PageObject_Admin.TransactionReason_Text_Code(), 240);
            Helper.ElementEnterText(PageObject_Admin.TransactionReason_Text_Code(), value);
        }

        public static void TransactionReason_Text_Filter(string value)
        {
            // Helper.ElementClick(PageObject_Admin.TransactionReason_Text_Filter());
            Helper.ElementWait(PageObject_Admin.TransactionReason_Text_Filter(), 240);
            Helper.ElementEnterText(PageObject_Admin.TransactionReason_Text_Filter(), value);
        }

        public static void TransactionReason_Text_Reason(string value)
        {
            Helper.ElementWait(PageObject_Admin.TransactionReason_Text_Reason(), 240);
            Helper.ElementEnterText(PageObject_Admin.TransactionReason_Text_Reason(), value);
        }

        public static void AddLoyaltyTransactionReason(string code, string reason)
        {
            TransactionReason_Text_Code(code);
            TransactionReason_Text_Reason(reason);
        }

        #endregion[LoyaltySetUp_TransactionReason]

        #region[LoyaltySetUp_SignUpSource]

        public static void Click_SignUpSourceCode_Button_AddSource()
        {
            Helper.ElementWait(PageObject_Admin.SignUpSource_Button_AddSource(), 240);
            Helper.ElementClick(PageObject_Admin.SignUpSource_Button_AddSource());
        }

        public static void Click_SignUpSource_Button_Save()
        {
            Helper.ElementWait(PageObject_Admin.SignUpSource_Button_Save(), 240);
            Helper.ElementClick(PageObject_Admin.SignUpSource_Button_Save());
        }

        public static void Click_SignUpSource_Button_Cancel()
        {
            Helper.ElementWait(PageObject_Admin.SignUpSource_Button_Cancel(), 240);
            Helper.ElementClick(PageObject_Admin.SignUpSource_Button_Cancel());
        }

        public static void Click_SignUpSource_Button_Close()
        {
            Helper.ElementWait(PageObject_Admin.SignUpSource_Button_Close(), 240);
            Helper.ElementClick(PageObject_Admin.SignUpSource_Button_Close());
        }

        public static void Click_SignUpSource_Icon_Edit()
        {
            Helper.ElementWait(PageObject_Admin.SignUpSource_Icon_Edit(), 240);
            Helper.ElementClick(PageObject_Admin.SignUpSource_Icon_Edit());
        }

        public static void SignUpSource_Text_SignUpSourceCode(string value)
        {
            Helper.ElementWait(PageObject_Admin.SignUpSource_Text_SignUpSourceCode(), 240);
            Helper.ElementEnterText(PageObject_Admin.SignUpSource_Text_SignUpSourceCode(), value);
        }

        public static void SignUpSource_Text_Filter(string value)
        {
            Helper.ElementWait(PageObject_Admin.SignUpSource_Text_Filter(), 240);
            Helper.ElementEnterText(PageObject_Admin.SignUpSource_Text_Filter(), value);
        }

        public static void SignUpSource_Text_SignUpSourceName(string value)
        {
            Helper.ElementWait(PageObject_Admin.SignUpSource_Text_SignUpSourceName(), 240);
            Helper.ElementEnterText(PageObject_Admin.SignUpSource_Text_SignUpSourceName(), value);
        }

        public static void AddLoyaltySignUpSource(string sourcecode, string sourcename)
        {
            SignUpSource_Text_SignUpSourceCode(sourcecode);
            SignUpSource_Text_SignUpSourceName(sourcename);
        }

        #endregion[LoyaltySetUp_SignUpSource]

        #region[LoyaltySetUp_TermsAndCondition]

        public static void Click_TermsAndCondition_Button_AddTermsAndCondition()
        {
            Helper.ElementWait(PageObject_Admin.TermsAndCondition_Button_AddTermsAndCondition(), 240);
            Helper.ElementClick(PageObject_Admin.TermsAndCondition_Button_AddTermsAndCondition());
        }
        public static void Click_Admin_LoyaltySetUp_TermsAndCondition_Add_TermsAndCondition()
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltySetUp_TermsAndCondition_Add_TermsAndCondition(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltySetUp_TermsAndCondition_Add_TermsAndCondition());
            //PageObject_Admin.Admin_LoyaltySetUp_TermsAndCondition_Add_TermsAndCondition().Click();
        }


        public static void Click_TermsAndCondition_Icon_Edit()
        {
            Helper.ElementWait(PageObject_Admin.TermsAndCondition_Icon_Edit(), 240);
            Helper.ElementClick(PageObject_Admin.TermsAndCondition_Icon_Edit());
        }

        public static void Click_TermsAndCondition_Icon_Close()
        {
            Helper.ElementWait(PageObject_Admin.TermsAndCondition_Icon_Close(), 240);
            Helper.ElementClick(PageObject_Admin.TermsAndCondition_Icon_Close());
        }

        public static void Click_TermsAndCondition_Button_Cancel()
        {
            Helper.ElementWait(PageObject_Admin.TermsAndCondition_Button_Cancel(), 240);
            Helper.ElementClick(PageObject_Admin.TermsAndCondition_Button_Cancel());
        }

        public static void Click_TermsAndCondition_Button_Save()
        {
            Helper.ElementWait(PageObject_Admin.TermsAndCondition_Button_Save(), 240);
            Helper.ElementClick(PageObject_Admin.TermsAndCondition_Button_Save());
        }
        public static void Enter_Admin_LoyaltySetUp_TermsAndCondition_Description(string TnCDescription, string iFrameId)
        {
            Helper.EnterFrame(iFrameId);
            Helper.ElementEnterText(PageObject_Admin.Admin_LoyaltySetUp_TermsAndCondition_Description(), TnCDescription);
            Helper.ExitFrame();
        }

        public static void Click_TermsAndCondition_Button_Yes()
        {
            Helper.ElementWait(PageObject_Admin.TermsAndCondition_Button_Yes(), 240);
            Helper.ElementClick(PageObject_Admin.TermsAndCondition_Button_Yes());
        }

        public static void Click_TermsAndCondition_Button_No()
        {
            Helper.ElementWait(PageObject_Admin.TermsAndCondition_Button_No(), 240);
            Helper.ElementClick(PageObject_Admin.TermsAndCondition_Button_No());
        }

        public static void Click_TermsAndCondition_Icon_Delete()
        {
            Helper.ElementWait(PageObject_Admin.TermsAndCondition_Icon_Delete(), 240);
            Helper.ElementClick(PageObject_Admin.TermsAndCondition_Icon_Delete());
        }

        public static void TermsAndCondition_Text_Title(string value)
        {
            Helper.ElementWait(PageObject_Admin.TermsAndCondition_Text_Title(), 240);
            Helper.ElementEnterText(PageObject_Admin.TermsAndCondition_Text_Title(), value);
        }

        public static void TermsAndCondition_Text_Filter(string value)
        {
            Helper.ElementWait(PageObject_Admin.TermsAndCondition_Text_Filter(), 240);
            Helper.ElementEnterText(PageObject_Admin.TermsAndCondition_Text_Filter(), value);
        }

        /// <summary
        /// Method to Add terms and Condition
        /// /// </summary>        
        public static void AddTermsAndCondition(string title, string description)
        {
            TermsAndCondition_Text_Title(title);
            Helper.EnterFrame("tcdesc_ifr");
            Helper.ElementEnterText(PageObject_Admin.TermsAndCondition_Text_Description(), description);
            Helper.ExitFrame();
        }

        #endregion[LoyaltySetUp_TermsAndCondition]

        #region[LoyaltyRules_PointsEarningRules]

        public static void Click_PointsEarningRules_Button_AddRule()
        {
            Helper.ElementWait(PageObject_Admin.PointsEarningRules_Button_AddRule(), 240);
            Helper.ElementClick(PageObject_Admin.PointsEarningRules_Button_AddRule());
        }

        public static void Click_PointsEarningRules_Button_Cancel()
        {
            Helper.ElementWait(PageObject_Admin.PointsEarningRules_Button_Cancel(), 240);
            Helper.ElementClick(PageObject_Admin.PointsEarningRules_Button_Cancel());
        }

        public static void Click_PointsEarningRules_Button_Save()
        {
            Helper.ElementWait(PageObject_Admin.PointsEarningRules_Button_Save(), 240);
            Helper.ElementClick(PageObject_Admin.PointsEarningRules_Button_Save());
        }

        public static void Click_PointsEarningRules_Icon_Edit()
        {
            Helper.ElementWait(PageObject_Admin.PointsEarningRules_Icon_Edit(), 240);
            Helper.ElementClick(PageObject_Admin.PointsEarningRules_Icon_Edit());
        }

        public static void Enter_PointsEarningRules_Text_Filter(string value)
        {
            Helper.ElementWait(PageObject_Admin.PointsEarningRules_Text_Filter(), 240);
            Helper.ElementEnterText(PageObject_Admin.PointsEarningRules_Text_Filter(), value);
        }

        public static void Enter_PointsEarningRules_Text_Name(string value)
        {
            Helper.ElementWait(PageObject_Admin.PointsEarningRules_Text_Name(), 240);
            Helper.ElementEnterText(PageObject_Admin.PointsEarningRules_Text_Name(), value);
        }

        public static void Enter_PointsEarningRules_Text_DisplayName(string value)
        {
            Helper.ElementWait(PageObject_Admin.PointsEarningRules_Text_DisplayName(), 240);
            Helper.ElementEnterText(PageObject_Admin.PointsEarningRules_Text_DisplayName(), value);
        }

        public static void Enter_PointsEarningRules_Text_Description(string value)
        {
            Helper.ElementWait(PageObject_Admin.PointsEarningRules_Text_Description(), 240);
            Helper.ElementEnterText(PageObject_Admin.PointsEarningRules_Text_Description(), value);
        }

        public static void Select_PointsEarningRules_Dropdown_BasedOn(string value)
        {
            Helper.ElementWait(PageObject_Admin.PointsEarningRules_Dropdown_BasedOn(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.PointsEarningRules_Dropdown_BasedOn(), value);
        }

        public static void Select_PointsEarningRules_Dropdown_RevenueType(string value)
        {
            Helper.ElementWait(PageObject_Admin.PointsEarningRules_Dropdown_RevenueType(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.PointsEarningRules_Dropdown_RevenueType(), value);
        }

        public static void Enter_PointsEarningRules_Text_Priority(string value)
        {
            Helper.ElementWait(PageObject_Admin.PointsEarningRules_Text_Priority(), 240);
            Helper.ElementEnterText(PageObject_Admin.PointsEarningRules_Text_Priority(), value);
        }

        public static void Enter_PointsEarningRules_Text_PointsEarned(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.PointsEarningRules_Text_PointsEarned());
            for (int i = 1; i <= int.Parse(value); i++)
            {
                action.SendKeys(OpenQA.Selenium.Keys.ArrowUp);
            }
            action.Build().Perform();
        }

        public static void Enter_PointsEarningRules_Text_Per(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.PointsEarningRules_Text_Per());
            for (int i = 1; i <= int.Parse(value); i++)
            {
                action.SendKeys(OpenQA.Selenium.Keys.ArrowUp);
            }
            action.Build().Perform();
        }

        public static void Select_PointsEarningRules_Dropdown_RuleType(string value)
        {
            Helper.ElementWait(PageObject_Admin.PointsEarningRules_Dropdown_RuleType(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.PointsEarningRules_Dropdown_RuleType(), value);
        }

        public static void Select_PointsEarningRules_Dropdown_For(string value)
        {
            Helper.ElementWait(PageObject_Admin.PointsEarningRules_Dropdown_For(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.PointsEarningRules_Dropdown_For(), value);
        }

        public static void Select_PointsEarningRules_Dropdown_CalculatedOn(string value)
        {
            Helper.ElementWait(PageObject_Admin.PointsEarningRules_Dropdown_CaculatedOn(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.PointsEarningRules_Dropdown_CaculatedOn(), value);
        }

        public static void Enter_PointsEarningRules_Text_StartDate(string value)
        {
            Helper.ElementEnterTextUsingJQuery(PageObject_Admin.PointsEarningRules_Text_StartDate(), value);
        }

        public static void Enter_PointsEarningRules_Text_EndDate(string value)
        {
            Helper.ElementEnterTextUsingJQuery(PageObject_Admin.PointsEarningRules_Text_EndDate(), value);
        }

        public static void Enter_PointsEarningRules_Text_PointsExpiryMonth(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.PointsEarningRules_Text_PointsExpiryMonth());
            for (int i = 1; i <= int.Parse(value); i++)
            {
                action.SendKeys(OpenQA.Selenium.Keys.ArrowUp);
            }
            action.Build().Perform();
        }

        public static void Select_PointsEarningRules_MemberLevel(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.PointsEarningRules_Dropdown_IncludeMemberLevel());
            Helper.ElementEnterText(PageObject_Admin.PointsEarningRules_Text_IncludeMemberLevel(), value);
            action.SendKeys(OpenQA.Selenium.Keys.Enter).Build().Perform();
            Helper.ElementClick(PageObject_Admin.PointsEarningRules_Dropdown_IncludeMemberLevel());
        }

        /// <summary>
        /// Method to Add rule under Loyalty Rules
        /// </summary>        
        public static void PointsEarningRule_AddRule(string name, string displayname, string description, string basedOn, string startDate, string endDate, string ruletype, string priority, string forvalue,
            string pointsearned, string per, string calculatedOn, string revenueType, string pointsExpiringMonth, string memberLevel, string ProjectName = null)
        {
            Enter_PointsEarningRules_Text_Name(name);
            Enter_PointsEarningRules_Text_DisplayName(displayname);
            Enter_PointsEarningRules_Text_Description(description);
            Select_PointsEarningRules_Dropdown_BasedOn(basedOn);
            Enter_PointsEarningRules_Text_StartDate(startDate);
            Enter_PointsEarningRules_Text_EndDate(endDate);
            Enter_PointsEarningRules_Text_Priority(priority);
            Select_PointsEarningRules_Dropdown_RuleType(ruletype);
            Select_PointsEarningRules_Dropdown_For(forvalue);
            Enter_PointsEarningRules_Text_PointsEarned(pointsearned);
            Enter_PointsEarningRules_Text_Per(per);
            Select_PointsEarningRules_Dropdown_CalculatedOn(calculatedOn);
            Select_PointsEarningRules_Dropdown_RevenueType(revenueType);
            if (!ProjectName.Equals("Bartell"))
                Enter_PointsEarningRules_Text_PointsExpiryMonth(pointsExpiringMonth);
            Select_PointsEarningRules_MemberLevel(memberLevel);
        }

        /// <summary>
        /// Method to Update rule under Loyalty Rules
        /// </summary>        
        public static void PointsEarningRule_UpdateRule(string name, string displayname, string description, string priority, string pointsearned, string per)
        {
            Enter_PointsEarningRules_Text_Name(name);
            Enter_PointsEarningRules_Text_DisplayName(Helper.MakeUnique(displayname));
            Enter_PointsEarningRules_Text_Description(Helper.MakeUnique(description));
            Enter_PointsEarningRules_Text_Priority(priority);
            Enter_PointsEarningRules_Text_PointsEarned(pointsearned);
            Enter_PointsEarningRules_Text_Per(per);
        }

        #endregion[LoyaltyRules_PointsEarningRules]

        #region[LoyaltySetUp_Offers]

        public static void Click_LoyaltySetUp_Offers_Button_AddOffers()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Button_AddOffers(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_AddOffers());
        }

        public static void Click_LoyaltySetUp_Offers_Button_Cancel()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Button_Cancel(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_Cancel());
        }

        public static void Click_LoyaltySetUp_Offers_Button_No()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Button_No(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_No());
        }

        public static void Click_LoyaltySetUp_Offers_Button_Yes()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Button_Yes(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_Yes());
        }

        public static void Click_LoyaltySetUp_Offers_Button_Save()
        {
            Helper.DoubleClickElement(PageObject_Admin.LoyaltySetUp_Offers_Button_Save());
        }

        public static void Click_LoyaltySetUp_Offers_Icon_Edit()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit());
        }

        public static void Click_LoyaltySetUp_Offers_Icon_Close()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Icon_Close(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Icon_Close());
        }

        public static void Click_LoyaltySetUp_Offers_Icon_Image()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Icon_Image(), 240);
            Helper.DoubleClickElement(PageObject_Admin.LoyaltySetUp_Offers_Icon_Image());
        }
        public static void Click_LoyaltySetUp_Offers_Image_Icon()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Button_BrowseImage(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_BrowseImage());
        }

        public static void Click_LoyaltySetUp_Offers_Button_SaveImage()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Button_SaveImage(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_SaveImage());
        }

        public static void Click_LoyaltySetUp_Offers_Button_CancelImage()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Button_CancelImage(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_CancelImage());
        }

        public static void Click_LoyaltySetUp_Offers_Button_AddAnotherPromotion()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Button_AddAnotherPromotion(), 240);
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.LoyaltySetUp_Offers_Button_AddAnotherPromotion());
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_AddAnotherPromotion());
        }

        public static void Click_LoyaltySetUp_Offers_Button_CancelPromotion()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Button_CancelPromotion(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_CancelPromotion());
        }

        public static void Click_LoyaltySetUp_Offers_Button_SavePromotion()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.LoyaltySetUp_Offers_Button_SavePromotion());
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_SavePromotion());
        }

        public static void Click_LoyaltySetUp_Offers_Button_ConfirmPromotion()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Button_SavePromotionConfirm(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_SavePromotionConfirm());
        }

        public static void Click_LoyaltySetUp_Offers_Button_SavePromotionCancel()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Button_SavePromotionCancel(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_SavePromotionCancel());
        }

        public static void Click_LoyaltySetUp_Offers_Button_DeletePromotion()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Button_DeletePromotion(), 240);
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.LoyaltySetUp_Offers_Button_DeletePromotion());
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_DeletePromotion());
        }

        public static void Click_LoyaltySetUp_Offers_Button_EditPromotion()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Button_EditPromotion(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_EditPromotion());
        }
        public static void Enter_LoyaltySetUp_Promotion_Filter(string value)
        {
            Helper.ElementEnterText(PageObject_Admin.Click_LoyaltySetUp_Promotion_Filter(), value);
        }
        public static void Click_LoyaltySetUp_Offers_Button_DeleteYes()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Button_DeleteYes(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_DeleteYes());
        }

        public static void Click_LoyaltySetUp_Offers_Button_DeleteNo()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Button_DeleteNo(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_DeleteNo());
        }

        public static void Click_LoyaltySetUp_Offers_Icon_PromotionDeleteClose()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Icon_PromotionDeleteClose(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Icon_PromotionDeleteClose());
        }

        public static void LoyaltySetUp_Offers_Text_Filter(string value)
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Text_Filter(), 240);
            Helper.ElementClearText(PageObject_Admin.LoyaltySetUp_Offers_Text_Filter());
            Helper.ElementEnterText(PageObject_Admin.LoyaltySetUp_Offers_Text_Filter(), value);
        }

        public static void LoyaltySetUp_Offers_Text_Description(string value)
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Text_Description(), 240);
            Helper.ElementEnterText(PageObject_Admin.LoyaltySetUp_Offers_Text_Description(), value);
        }

        public static void LoyaltySetUp_Offers_Text_Title(string value)
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Text_Title(), 240);
            Helper.ElementEnterText(PageObject_Admin.LoyaltySetUp_Offers_Text_Title(), value);
        }

        public static void LoyaltySetUp_Offers_Text_PromotionStart(string value)
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Text_PromotionStart(), 240);
            Helper.ElementEnterText(PageObject_Admin.LoyaltySetUp_Offers_Text_PromotionStart(), value);
        }

        public static void LoyaltySetUp_Offers_Text_PromotionEnd(string value)
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Text_PromotionEnd(), 240);
            Helper.ElementEnterText(PageObject_Admin.LoyaltySetUp_Offers_Text_PromotionEnd(), value);
        }

        public static void LoyaltySetUp_Offers_Text_VisibilityStart(string value)
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Text_VisibilityStart(), 240);
            Helper.ElementEnterText(PageObject_Admin.LoyaltySetUp_Offers_Text_VisibilityStart(), value);
        }

        public static void LoyaltySetUp_Offers_Text_VisibilityEnd(string value)
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Text_VisibilityEnd(), 240);
            Helper.ElementEnterText(PageObject_Admin.LoyaltySetUp_Offers_Text_VisibilityEnd(), value);
        }

        public static void LoyaltySetUp_Offers_SelectMemberLevel(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Dropdown_MemberLevel());
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_DeselectAll());
            Helper.ElementEnterText(PageObject_Admin.LoyaltySetUp_Offers_Text_MemberLevel(), value);
            // action.SendKeys(Keys.ArrowDown);
            action.SendKeys(Keys.Enter);
            action.Build().Perform();
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Dropdown_MemberLevel());
        }
        public static void LoyaltySetUp_Offers_SelectMemberLevel2(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Dropdown_MemberLevel());
            Helper.ElementEnterText(PageObject_Admin.LoyaltySetUp_Offers_Text_MemberLevel(), value);
            // action.SendKeys(Keys.ArrowDown);
            action.SendKeys(Keys.Enter);
            action.Build().Perform();
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Dropdown_MemberLevel());
        }

        public static void LoyaltySetUp_Offers_Text_ShortDescription(string value)
        {
            Helper.EnterFrame(ObjectRepository.Admin_LoyaltySetUp_IFrame_ShortDescription);
            Helper.ElementEnterText(PageObject_Admin.LoyaltySetUp_Offers_Text_Description(), value);
            Helper.ExitFrame();
        }

        public static void LoyaltySetUp_Offers_Text_PromotionCode(string value)
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Text_PromotionCode(), 240);
            Helper.ElementEnterText(PageObject_Admin.LoyaltySetUp_Offers_Text_PromotionCode(), value);
        }

        public static void LoyaltySetUp_Offers_Text_ButtonText(string value)
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Text_ButtonText(), 240);
            Helper.ElementEnterText(PageObject_Admin.LoyaltySetUp_Offers_Text_ButtonText(), value);
        }

        public static void LoyaltySetUp_Offers_Dropdown_HotelSelection(string value, string Projectname)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Dropdown_HotelSelection(Projectname));
            Helper.ElementEnterText(PageObject_Admin.LoyaltySetUp_Offers_Value_HotelSelection(), value);
            action.SendKeys(Keys.ArrowDown);
            action.SendKeys(Keys.Enter);
            action.Build().Perform();
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Dropdown_HotelSelection(Projectname));
        }

        public static void LoyaltySetUp_Offers_Text_PromotionDescription(string value)
        {
            Helper.EnterFrame(ObjectRepository.Admin_LoyaltySetUp_Offers_Iframe_Description);
            Helper.ElementEnterText(PageObject_Admin.LoyaltySetUp_Offers_Text_Description(), value);
            Helper.ExitFrame();
        }

        public static void LoyaltySetUp_Offers_SelectMemberLevelALL()
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Dropdown_MemberLevel());
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_SelectAll());
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Dropdown_MemberLevel());
        }

        /// <summary>
        /// Method to Add/Update Offers
        /// </summary>
        public static void AddORUpdateOffers(string title, string visiblityStartDate, string visiblityEndDate, string memberlevel,
            string promotionStartdate, string promotionEnddate, string shortDescription)
        {
            Helper.ElementClearText(PageObject_Admin.LoyaltySetUp_Offers_Text_Title());
            LoyaltySetUp_Offers_Text_Title(title);
            LoyaltySetUp_Offers_Text_VisibilityStart(visiblityStartDate);
            LoyaltySetUp_Offers_Text_VisibilityEnd(visiblityEndDate);
            LoyaltySetUp_Offers_SelectMemberLevel(memberlevel);
            LoyaltySetUp_Offers_Text_PromotionStart(promotionStartdate);
            LoyaltySetUp_Offers_Text_PromotionEnd(promotionEnddate);
            LoyaltySetUp_Offers_Text_ShortDescription(shortDescription);
        }

        /// <summary>
        /// Method to upload image for Offers
        /// </summary>
        /// <param name="location"></param>
        public static void UploadImage(string location)
        {
            Click_LoyaltySetUp_Offers_Icon_Image();
            Click_LoyaltySetUp_Offers_Image_Icon();
            Helper.AddDelay(2500);
            AutoItX3 AutoIt = new AutoItX3();
            AutoIt.WinActivate("Open");
            Helper.AddDelay(2000);
            AutoIt.Send(location);
            Helper.AddDelay(3000);
            AutoIt.Send("{ENTER}");
            Helper.AddDelay(5000);
            Click_LoyaltySetUp_Offers_Button_SaveImage();
        }

        /// <summary>
        /// Method to Upload promotional image and add promotions
        /// </summary>
        public static void AddPromotion(string promotioncode, string buttonText, string hotel, string description, string Projectname)
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.LoyaltySetUp_Offers_Button_AddAnotherPromotion());
            Click_LoyaltySetUp_Offers_Button_AddAnotherPromotion();
            LoyaltySetUp_Offers_Text_PromotionCode(promotioncode);
            LoyaltySetUp_Offers_Text_ButtonText(buttonText);
            LoyaltySetUp_Offers_Dropdown_HotelSelection(hotel, Projectname);
            LoyaltySetUp_Offers_Text_PromotionDescription(description);
            Logger.WriteDebugMessage("Entered All Details for Promotion");
            Click_LoyaltySetUp_Offers_Button_SavePromotion();
        }

        /// <summary>
        /// Method to Upload promotional image and add promotions
        /// </summary>
        public static void UpdatePromotion(string promotioncode, string buttonText, string hotel, string description, string Projectname)
        {
            LoyaltySetUp_Offers_Text_PromotionCode(promotioncode);
            LoyaltySetUp_Offers_Text_ButtonText(buttonText);
            LoyaltySetUp_Offers_Dropdown_HotelSelection(hotel, Projectname);
            LoyaltySetUp_Offers_Text_PromotionDescription(description);
            Click_LoyaltySetUp_Offers_Button_SavePromotion();
        }
        public static void LoyaltySetUp_Offers_DeSelectMemberLevelALL()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Dropdown_MemberLevel(), 240);
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Dropdown_MemberLevel());
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Button_DeselectAll());
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Dropdown_MemberLevel());
        }
        public static void Click_Admin_LoyaltySetUp_Offers_Pagination_Dropdown()
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltySetUp_Offers_Pagination_Dropdown(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltySetUp_Offers_Pagination_Dropdown());
        }
        public static void Click_Admin_LoyaltySetUp_Offers_Pagination_Prev_Button()
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltySetUp_Offers_Pagination_Prev_Button(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltySetUp_Offers_Pagination_Prev_Button());
        }
        public static void Click_Admin_LoyaltySetUp_Offers_Pagination_Next_Button()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Admin.Admin_LoyaltySetUp_Offers_Pagination_Next_Button());
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltySetUp_Offers_Pagination_Next_Button(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltySetUp_Offers_Pagination_Next_Button());
        }
        public static string Get_Admin_LoyaltySetUp_Offers_Pagination_Dropdown(int value)
        {
            return PageObject_Admin.Get_Admin_LoyaltySetUp_Offers_Pagination_Dropdown(value).GetAttribute("innerHTML");
        }
        public static void Click_Admin_LoyaltySetUp_Offers_Pagination_Dropdown(int value)
        {
            Helper.ElementClick(PageObject_Admin.Get_Admin_LoyaltySetUp_Offers_Pagination_Dropdown(value));
        }
        #endregion[LoyaltySetUp_Offers]

        #region[Admin_LoyaltyAwards]

        public static void Dropdown_AwardType(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Dropdown_AwardType(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Admin_LoyaltyAwards_Dropdown_AwardType(), value);
        }

        public static void Dropdown_ExpMonth(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Dropdown_ExpMonth(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Admin_LoyaltyAwards_Dropdown_ExpMonth(), value);
        }

        public static void Dropdown_ExpDay(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Dropdown_ExpDay(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Admin_LoyaltyAwards_Dropdown_ExpDay(), value);
        }

        public static void Dropdown_ExpYear(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Dropdown_ExpYear(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Admin_LoyaltyAwards_Dropdown_ExpYear(), value);
        }

        public static void Dropdown_AdminMemberStatus(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Dropdown_AdminMemberStatus(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Admin_LoyaltyAwards_Dropdown_AdminMemberStatus(), value);
        }
        public static void Click_LoyaltyAwards_Button_Add()
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Button_Add(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltyAwards_Button_Add());
        }

        public static void Click_LoyaltyAwards_Icon_Edit()
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Icon_Edit(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltyAwards_Icon_Edit());
        }

        public static void Click_LoyaltyAwards_Button_Save()
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Button_Save(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltyAwards_Button_Save());
        }

        public static void Click_LoyaltyAwards_Button_Cancel()
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Button_Cancel(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltyAwards_Button_Cancel());
        }

        public static void Click_LoyaltyAwards_Icon_Close()
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Icon_Close(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltyAwards_Icon_Close());
        }

        public static void LoyaltyAwards_Text_Filter(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Text_Filter(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_LoyaltyAwards_Text_Filter(), value);
        }

        public static void LoyaltyAwards_Text_AwardName(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Text_AwardName(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_LoyaltyAwards_Text_AwardName(), value);
        }



        public static void LoyaltyAwards_Text_AwardCode(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Text_AwardCode(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_LoyaltyAwards_Text_AwardCode(), value);
        }

        public static void LoyaltyAwards_Text_StartDate(string value)
        {
            Helper.ElementEnterTextUsingJQuery(PageObject_Admin.Admin_LoyaltyAwards_Text_StartDate(), value);
        }

        public static void LoyaltyAwards_Text_EndDate(string value)
        {
            Helper.ElementEnterTextUsingJQuery(PageObject_Admin.Admin_LoyaltyAwards_Text_EndDate(), value);
        }

        public static void Admin_Enter_Points_Costs(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Text_PointsCost(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_Text_PointsCost(), value);
        }

        public static void Admin_Select_Award_Exp_month(string value)
        {
            SelectElement awardMonth = new SelectElement(PageObject_Admin.Admin_DropDown_AwardExpMonth());
            awardMonth.SelectByText(value);
        }
        public static void Click_Admin_Use_As_EGift()
        {
            Helper.ElementWait(PageObject_Admin.Admin_CheckBox_Use_As_EGift(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_CheckBox_Use_As_EGift());
        }

        public static void Click_Admin_LoyaltyAwards_Member_Level_DeselectAll()
        {
            //Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Member_Level_DeselectAll(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltyAwards_Member_Level_ClickDDM());
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltyAwards_Member_Level_DeselectAll());
        }


        public static void Click_Admin_LoyaltyAwards_Member_Level_SelectAll()
        {
            //Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Member_Level_SelectAll(), 240);
            //Helper.ElementClick(PageObject_Admin.Admin_LoyaltyAwards_Member_Level_ClickDDM());
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltyAwards_Member_Level_SelectAll());
        }
        public static void Enter_BirthdayAward_Text_DaysActive(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltyAwards_BirthdayAward_Text_DaysActive());
            for (int i = 1; i <= int.Parse(value); i++)
            {
                action.SendKeys(OpenQA.Selenium.Keys.ArrowUp);
            }
            action.Build().Perform();
        }

        public static void Enter_BirthdayAward_Text_AdvanceDeliveryDays(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltyAwards_BirthdayAward_Text_AdvanceDeliveryDays());
            for (int i = 1; i <= int.Parse(value); i++)
            {
                action.SendKeys(OpenQA.Selenium.Keys.ArrowUp);
            }
            action.Build().Perform();
        }

        public static void Enter_BirthdayAward_Text_MinQualifiedStays()
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltyAwards_BirthdayAward_Text_MinQualifiedStay());
            action.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            action.Build().Perform();
        }

        public static void Select_BirthdayAward_MemberLevel(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltyAwards_BirthdayAward_Dropdown_MemberLevel());
            Helper.ElementEnterText(PageObject_Admin.Admin_LoyaltyAwards_BirthdayAward_Text_MemberLevel(), value);
            action.SendKeys(OpenQA.Selenium.Keys.Enter);
            action.Build().Perform();
        }

        public static void Select_BirthdayAward_Dropdown_EmailName(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_BirthdayAward_Dropdown_EmailName(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Admin_LoyaltyAwards_BirthdayAward_Dropdown_EmailName(), value);
        }

        /// <summary>
        /// Method to assign member Level as per Project
        /// </summary>
        public static string AssignAwardType(string ProjectName, string awardname)
        {
            string Value = "";
            switch (awardname)
            {
                case "Joined":
                    {
                        Value = "Joined";
                        break;
                    }
                case "Stays":
                    {
                        Value = "Stays";
                        break;
                    }
                case "Nights Based":
                    {
                        Value = "Nights Based";
                        break;
                    }
                case "Birthday":
                    {
                        Value = "Birthday Based";
                        break;
                    }
            }
            return Value;
        }

        /// <summary>
        /// Method to add Award under Loyalty Award tab
        /// </summary>
        public static void AddAward(string awardname, string code, string startdate, string enddate, string awardType)
        {
            LoyaltyAwards_Text_AwardName(awardname);
            LoyaltyAwards_Text_AwardCode(code);
            LoyaltyAwards_Text_StartDate(startdate);
            LoyaltyAwards_Text_EndDate(enddate);
            Dropdown_AwardType(awardType);
        }

        /// <summary>
        /// Method to edit Award under  Loyalty Award tab
        /// </summary>
        /// <param name="awardname"></param>
        /// <param name="startdate"></param>
        /// <param name="enddate"></param>
        /// <param name="awardType"></param>
        public static void EditAward(string awardname, string startdate, string enddate, string awardType)
        {
            LoyaltyAwards_Text_AwardName(awardname);
            LoyaltyAwards_Text_StartDate(startdate);
            LoyaltyAwards_Text_EndDate(enddate);
            Dropdown_AwardType(awardType);
        }

        public static void EditMemberLevel(string awardname, string memberlevel)
        {
            Click_Admin_LoyaltyAwards_Member_Level_DeselectAll();
            LoyaltyAwards_Text_AwardName(awardname);
            Admin_DropDown_MemberLevel(memberlevel);
        }
        public static void EditMultipleMemberLevel(string awardname, string memberlevel1, string memberlevel2)
        {
            Click_Admin_LoyaltyAwards_Member_Level_DeselectAll();
            LoyaltyAwards_Text_AwardName(awardname);
            Admin_DropDown_MemberLevel(memberlevel1);
            Admin_DropDown_MemberLevel(memberlevel2);
        }
        public static void EditAllMemberLevel(string awardname)
        {
            LoyaltyAwards_Text_AwardName(awardname);
            Click_Admin_LoyaltyAwards_Member_Level_DeselectAll();
            Click_Admin_LoyaltyAwards_Member_Level_SelectAll();

        }

        /// <summary>
        /// Method to add Birthday Award details Loyalty Award tab
        /// </summary>
        public static void AddbirthdayAward(string daysActive, string advanceDeliverydays, string level, string EmailName)
        {
            Enter_BirthdayAward_Text_DaysActive(daysActive);
            Enter_BirthdayAward_Text_AdvanceDeliveryDays(advanceDeliverydays);
            Enter_BirthdayAward_Text_MinQualifiedStays();
            Select_BirthdayAward_MemberLevel(level);
            Select_BirthdayAward_Dropdown_EmailName(EmailName);
        }

        public static void AddPointBasedAward(string pointValue, string memberLevelText, string emailText, string awardexpMonth)
        {
            Admin_Enter_Points_Costs(pointValue);
            //Admin_Select_Award_Exp_month(awardexpMonth);
            Admin_DropDown_MemberLevel(memberLevelText);
            Helper.AddDelay(2000);
            Admin_DropDown_EmailName(emailText);
        }

        public static void AddPointBasedAwardWithAllMemberLevel(string pointValue, string emailText, string awardexpMonth)
        {
            Admin_Enter_Points_Costs(pointValue);
            //Admin_Select_Award_Exp_month();
            //PageObject_Admin.Admin_LoyaltyAwards_Member_Level().Click();
            Helper.Driver.FindElement(By.XPath("//button[@data-id='reqCL']/span[contains(text(),'None Selected')]")).Click();
            Actions action = new Actions(Helper.Driver);
            //action.MoveToElement(Helper.Driver.FindElement(By.XPath("//div[@class='col-sm-3 type staybased hide']//button[@class='actions-btn bs-select-all btn btn-default'][contains(text(),'Select All')]"))).Click().Build().Perform();
            //Helper.Driver.FindElement(By.XPath("//div[@class='col-sm-3 type staybased hide']//button[@class='actions-btn bs-select-all btn btn-default'][contains(text(),'Select All')]")).Click();
            Helper.Driver.FindElement(By.XPath("//div[@class='col-sm-3 type points staybased pointsbased marketing memberlevelbased birthday nightbased earningbased']//li[1]//a[1]//span[1]")).Click();
            Helper.Driver.FindElement(By.XPath("//div[@class='col-sm-3 type points staybased pointsbased marketing memberlevelbased birthday nightbased earningbased']//li[2]//a[1]//span[1]")).Click();
            Helper.Driver.FindElement(By.XPath("//div[@class='col-sm-3 type points staybased pointsbased marketing memberlevelbased birthday nightbased earningbased']//li[3]//a[1]//span[1]")).Click();
            Helper.AddDelay(2000);
            Admin_DropDown_EmailName(emailText);
        }
        public static void Click_Admin_AutomatedSwitch()
        {
            Helper.ElementWait(PageObject_Admin.Click_Admin_AutomatedSwitch(), 240);
            Helper.ElementClick(PageObject_Admin.Click_Admin_AutomatedSwitch());
        }
        public static void Click_Admin_AwardStatusSwitch()
        {
            Helper.ElementWait(PageObject_Admin.Click_Admin_AwardStatusSwitch(), 240);
            Helper.ElementClick(PageObject_Admin.Click_Admin_AwardStatusSwitch());
        }
        #endregion[Admin_LoyaltyAwards]

        #region[Admin_EmailSetUp]   

        public static void Click_EmailSetUp_Icon_Edit()
        {
            Helper.ElementWait(PageObject_Admin.Admin_EmailSetUp_Icon_Edit(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_EmailSetUp_Icon_Edit());
        }

        public static void Click_EmailSetUp_Button_Save()
        {
            Helper.ElementWait(PageObject_Admin.Admin_EmailSetUp_Button_Save(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_EmailSetUp_Button_Save());
        }

        public static void Click_EmailSetUp_Button_Cancel()
        {
            Helper.ElementWait(PageObject_Admin.Admin_EmailSetUp_Button_Cancel(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_EmailSetUp_Button_Cancel());
        }

        public static void EmailSetUp_Text_Filter(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_EmailSetUp_Text_Filter(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_EmailSetUp_Text_Filter(), value);
        }

        public static void EmailSetUp_Text_EmailName(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_EmailSetUp_Text_EmailName(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_EmailSetUp_Text_EmailName(), value);
        }

        public static void EmailSetUp_Text_EmailSubject(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_EmailSetUp_Text_EmailSubject(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_EmailSetUp_Text_EmailSubject(), value);
        }

        public static void EmailSetUp_Text_EmailContent(string value)
        {
            Helper.EnterFrame(ObjectRepository.Admin_EmailSetUp_IFrame_EmailContent);
            Helper.ElementEnterText(PageObject_Admin.Admin_EmailSetUp_Text_EmailContent(), value);
        }

        public static void EmailSetUp_Text_EmailTermsAndCondition(string value)
        {
            Helper.EnterFrame(ObjectRepository.Admin_EmailSetUp_IFrame_TermsAndCondition);
            Helper.ElementEnterText(PageObject_Admin.Admin_EmailSetUp_Text_TermsAndCondition(), value);
        }

        public static string GetData_Iframe(string ID, IWebElement element)
        {
            Helper.EnterFrame(ID);
            string value = Helper.Getdata(element);
            Helper.ExitFrame();
            return value;
        }

        public static void AddEmailSetUp(string emailname, string emailsubject)
        {
            EmailSetUp_Text_EmailName(emailname);
            EmailSetUp_Text_EmailSubject(emailsubject);
            //EmailSetUp_Text_EmailContent(emailcontent);
            //EmailSetUp_Text_EmailTermsAndCondition(TermsAndCondition);
        }

        #endregion[Admin_EmailSetUp]

        #region[Admin_Users]   

        public static void Click_Users_Button_AddUsers()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Users_Button_AddUsers(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Users_Button_AddUsers());
        }

        public static void Click_Users_Button_Delete()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Users_Button_Delete(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Users_Button_Delete());
        }

        public static void Click_Users_Button_Save()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Users_Button_Save(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Users_Button_Save());
        }

        public static void Click_Icon_Button_Close()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Users_Button_Close(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Users_Button_Close());
        }

        public static void Users_Text_Search(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Users_Text_Search(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_Users_Text_Search(), value);
        }

        public static void Users_Text_Firstname(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Users_Text_Firstname(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_Users_Text_Firstname(), value);
        }

        public static void Users_Text_Lastname(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Users_Text_Lastname(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_Users_Text_Lastname(), value);
        }

        public static void Users_Text_UsersLogin(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Users_Text_UserLogin(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_Users_Text_UserLogin(), value);
        }

        public static void Dropdown_UserPermission(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Users_Dropdown_UserPermission(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Admin_Users_Dropdown_UserPermission(), value);
        }

        public static void Click_Users_Button_SetPassword()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Users_Button_SetPassword(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Users_Button_SetPassword());
        }
        public static void AdminForgotPasswordNew()
        {
            Helper.ElementWait(PageObject_Admin.AdminForgotPassword_Recovery(), 240);
            Helper.ElementClick(PageObject_Admin.AdminForgotPassword_Recovery());
        }
        public static void Admin_ForgotPassword_Recover()
        {
            Helper.ElementWait(PageObject_Admin.Admin_ForgotPassword_Recover(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_ForgotPassword_Recover());
        }

        public static void Dropdown_UserTitle(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Users_Dropdown_UserTitle(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Admin_Users_Dropdown_UserTitle(), value);
        }
        public static void Dropdown_PropertyName(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_Users_Dropdown_PropertyName(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Admin_Users_Dropdown_PropertyName(), value);
        }
        public static void AddUsers(string firstname, string lastname, string title, string permission, string userlogin, string PropertyName)
        {
            Users_Text_Firstname(firstname);
            Users_Text_Lastname(lastname);
            Dropdown_UserPermission(permission);
            Dropdown_UserTitle(title);
            Users_Text_UsersLogin(userlogin);
            Dropdown_PropertyName(PropertyName);
        }
        #endregion[Admin_Users]

        #region[Admin_ManualMerge]   
        public static void ManualMerge_Text_MemberID(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_Text_MemberID(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_ManualMerge_Text_MemberID(), value);
        }

        public static void ManualMerge_Text_Firstname(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_Text_Firstname(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_ManualMerge_Text_Firstname(), value);
        }

        public static void ManualMerge_Text_Lastname(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_Text_Lastname(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_ManualMerge_Text_Lastname(), value);
        }

        public static void ManualMerge_Text_Email(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_Text_Email(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_ManualMerge_Text_Email(), value);
        }

        public static void ManualMerge_Text_City(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_Text_City(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_ManualMerge_Text_City(), value);
        }

        public static void ManualMerge_Text_Street(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_Text_Street(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_ManualMerge_Text_Street(), value);
        }

        public static void ManualMerge_Text_Zip(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_Text_Zip(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_ManualMerge_Text_Zip(), value);
        }

        public static void Click_ManualMerge_Button_SearchMember()
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_Button_SearchMember(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_ManualMerge_Button_SearchMember());
        }
        public static void Admin_ManualMerge_MemberMerge_SubTab()
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_MemberMerge_SubTab(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_ManualMerge_MemberMerge_SubTab());
        }
        public static void Click_ManualMerge_Button_ClearSearch()
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_Button_ClearSearch(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_ManualMerge_Button_ClearSearch());
        }

        public static void Click_ManualMerge_Button_Review()
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_Button_Review(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_ManualMerge_Button_Review());
        }

        public static void Click_ManualMerge_Button_Cancel()
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_Button_Cancel(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_ManualMerge_Button_Cancel());
        }

        public static void Click_ManualMerge_Button_Merge()
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_Button_Merge(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_ManualMerge_Button_Merge());
        }

        public static void Click_ManualMerge_Icon_Select1()
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_Icon_Select1(), 240);
            PageObject_Admin.Admin_ManualMerge_Icon_Select1().Click();
        }
        public static void Click_ManualMerge_Icon_Select1(string id)
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_Icon_Select1(id), 240);
            PageObject_Admin.Admin_ManualMerge_Icon_Select1(id).Click();
        }

        public static void Click_ManualMerge_RadioButton_AccountWinner1()
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_RadioButton_AccountWinner1(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_ManualMerge_RadioButton_AccountWinner1());
        }

        public static void Click_ManualMerge_RadioButton_AccountWinner2()
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_RadioButton_AccountWinner2(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_ManualMerge_RadioButton_AccountWinner2());
        }

        public static void Click_ManualMerge_Button_Back()
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_Button_Back(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_ManualMerge_Button_Back());
        }

        public static void Click_ManualMergeReview_Button_Merge()
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMergeReview_Button_Merge(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_ManualMergeReview_Button_Merge());
        }

        public static void Click_ManualMerge_Button_Confirm()
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMergeReview_Button_Confirm(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_ManualMergeReview_Button_Confirm());
        }

        public static void Click_ManualMergeReview_Button_Cancel()
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMergeReview_Button_Cancel(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_ManualMergeReview_Button_Cancel());
        }

        public static void Click_ManualMerge_SubTab_ManualMerge()
        {
            Helper.ElementWait(PageObject_Admin.Admin_ManualMerge_SubTab_ManualMerge(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_ManualMerge_SubTab_ManualMerge());
        }

        /// <summary>
        /// Method to select Member Profile on member merge page
        /// </summary>
        /// <param name="noOfProfile"></param>
        public static void SelectMembersToMerge(int noOfProfile)
        {
            IList<IWebElement> element = Helper.Driver.FindElements(By.XPath("//input[@type='checkbox']"));
            for (int i = 0; i < noOfProfile; i++)
            {
                element[i].Click();
            }
        }
        internal static void EnterEmail(object memberEmail)
        {
            throw new NotImplementedException();
        }
        public static void Admin_MemberBatchUpload_Tab()
        {
            Helper.ElementWait(PageObject_Admin.Admin_MemberBatchUpload_Tab(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_MemberBatchUpload_Tab());
        }

        #endregion[Admin_ManualMerge]

        #region [Admin_LoyaltyeGifts]

        public static void Click_Admin_LoyaltyeGifts_Button_AddeGift()
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyeGifts_Button_AddeGift(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltyeGifts_Button_AddeGift());


        }
        public static void Admin_LoyaltyeGifts_Name(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyeGifts_Name(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_LoyaltyeGifts_Name(), value);


        }
        public static void Admin_LoyaltyeGifts_Marketing_Partner(string value)
        {
            SelectElement chooseCatalog = new SelectElement(PageObject_Admin.Admin_LoyaltyeGifts_Marketing_Partner());
            chooseCatalog.SelectByText(value);

            Helper.AddDelay(3000);

        }
        public static void Admin_LoyaltyeGifts_Marketing_Partner_Input(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyeGifts_Marketing_Partner_Input(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_LoyaltyeGifts_Marketing_Partner_Input(), value);


        }
        public static void Admin_LoyaltyeGifts_Award(string value)
        {
            SelectElement chooseCatalog = new SelectElement(PageObject_Admin.Admin_LoyaltyeGifts_Award());
            chooseCatalog.SelectByText(value);


        }
        public static void Admin_LoyaltyeGifts_Card_Amount(string value)
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyeGifts_Card_Amount(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_LoyaltyeGifts_Card_Amount(), value);


        }

        public static void Admin_LoyaltyeGifts_Choose_Catalog(string value)
        {
            SelectElement chooseCatalog = new SelectElement(PageObject_Admin.Admin_LoyaltyeGifts_Choose_Catalog());
            chooseCatalog.SelectByText(value);



        }
        public static void Admin_LoyaltyeGifts_Button_Add()
        {
            Helper.ElementClickUsingJavascript(PageObject_Admin.Admin_LoyaltyeGifts_Button_Add());


        }

        public static void Add_LoyaltyeGifts(string couponName, string marketingPartner, string awardName, string catalog, string cardAmount)
        {
            Admin.Admin_LoyaltyeGifts_Name(couponName);
            Admin.Admin_LoyaltyeGifts_Marketing_Partner(marketingPartner);
            Admin.Admin_LoyaltyeGifts_Award(awardName);
            Admin.Admin_LoyaltyeGifts_Choose_Catalog(catalog);
            Admin.Admin_LoyaltyeGifts_Card_Amount(cardAmount);
        }

        public static void Admin_LoyaltyeGifts_Marketing_Partner_Tab()
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyeGifts_Marketing_Partner_Tab(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltyeGifts_Marketing_Partner_Tab());
        }
        public static void Admin_LoyaltyeGifts_Marketing_Partner_Edit()
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyeGifts_Marketing_Partner_Edit(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltyeGifts_Marketing_Partner_Edit());
        }
        public static void Admin_LoyaltyeGifts_Marketing_Partner_Notify_EnterText(string text)
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyeGifts_Marketing_Partner_Notify(), 240);
            Helper.ElementEnterText(PageObject_Admin.Admin_LoyaltyeGifts_Marketing_Partner_Notify(), text);
        }

        public static void Admin_LoyaltyeGifts_Marketing_Partner_Notify_ClearText()
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyeGifts_Marketing_Partner_Notify(), 240);
            Helper.ElementClearText(PageObject_Admin.Admin_LoyaltyeGifts_Marketing_Partner_Notify());
        }
        public static void Admin_LoyaltyeGifts_Marketing_Partner_Notify_Save()
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyeGifts_Marketing_Partner_Notify_Save(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltyeGifts_Marketing_Partner_Notify_Save());
        }

        #endregion

        #region[Admin_Redeem]
        public static void Click_Admin_Menu_Redeem_Edit()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Menu_Redeem_Edit(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Menu_Redeem_Edit());


        }
        public static void Select_Admin_Menu_Redeem_Dropdown_Connect_To(string value)
        {
            SelectElement selectContactTo = new SelectElement(PageObject_Admin.Admin_Menu_Redeem_Dropdown_Connect_To());
            selectContactTo.SelectByText(value);

        }
        public static void Click_Admin_Menu_Redeem_Button_Save()
        {
            Helper.ElementWait(PageObject_Admin.Admin_Menu_Redeem_Button_Save(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_Menu_Redeem_Button_Save());

        }
        public static void Click_Button_Add_Redemption()
        {
            Helper.ElementWait(PageObject_Admin.Button_Add_Redemption(), 240);
            PageObject_Admin.Button_Add_Redemption().Click();
        }

        public static void Name_InputBox_Add_Redemption(string text)
        {
            Helper.ElementWait(PageObject_Admin.Name_InputBox_Add_Redemption(), 240);
            Helper.ElementEnterText(PageObject_Admin.Name_InputBox_Add_Redemption(), text);
        }
        public static void Select_ConnectTo_InputBox_Add_Redemption(string text)
        {
            //Helper.ElementClickUsingJavascript(PageObject_Redeem.Navigation_Link_Redeem());

            SelectElement element = new SelectElement(PageObject_Admin.ConnectTo_InputBox_Add_Redemption());
            element.SelectByText(text);


        }
        public static void Button_InputBox_Add_Redemption(string text)
        {
            Helper.ElementWait(PageObject_Admin.Button_InputBox_Add_Redemption(), 240);
            Helper.ElementEnterText(PageObject_Admin.Button_InputBox_Add_Redemption(), text);
        }

        public static void AddRedemption(string name, string connectTo, string btnName)
        {
            Click_Button_Add_Redemption();
            Name_InputBox_Add_Redemption(name);
            Select_ConnectTo_InputBox_Add_Redemption(connectTo);
            Button_InputBox_Add_Redemption(btnName);
            Click_Admin_Menu_Redeem_Button_Save();
        }

        public static void Redeem_FilterSearch(string text)
        {
            Helper.ElementWait(PageObject_Admin.Redeem_FilterSearch(), 120);
            Helper.ElementEnterText(PageObject_Admin.Redeem_FilterSearch(), text);
        }

        #endregion[Admin_Redeem]

        #region[Admin_Member_Setup]
        public static void Click_MembershipSetup_Tab()
        {
            Helper.ElementWait(PageObject_Admin.Click_MembershipSetup_Tab(), 240);
            Helper.ElementClick(PageObject_Admin.Click_MembershipSetup_Tab());
        }
        public static void Click_MemberLevel_SubTab()
        {
            Helper.ElementWait(PageObject_Admin.Click_MemberLevel_SubTab(), 240);
            Helper.ElementClick(PageObject_Admin.Click_MemberLevel_SubTab());
        }
        public static void MembershipSetup_AddMemershipLevel_Button()
        {
            Helper.ElementWait(PageObject_Admin.MembershipSetup_AddMemershipLevel_Button(), 240);
            Helper.ElementClick(PageObject_Admin.MembershipSetup_AddMemershipLevel_Button());
        }
        public static void AddMemershipLevel_MembershipLevel(string text)
        {
            Helper.ElementWait(PageObject_Admin.AddMemershipLevel_MembershipLevel(), 240);
            Helper.ElementEnterText(PageObject_Admin.AddMemershipLevel_MembershipLevel(), text);
        }
        public static void AddMemershipLevel_MembershipCode(string text)
        {
            Helper.ElementWait(PageObject_Admin.AddMemershipLevel_MembershipCode(), 240);
            Helper.ElementEnterText(PageObject_Admin.AddMemershipLevel_MembershipCode(), text);
        }
        public static void AddMemershipLevel_LevelOrder(string text)
        {
            Helper.ElementWait(PageObject_Admin.AddMemershipLevel_LevelOrder(), 240);
            Helper.ElementEnterText(PageObject_Admin.AddMemershipLevel_LevelOrder(), text);
        }
        public static void AddMemershipLevel_CanBeProcessedByService_DDM(string value)
        {
            Helper.ElementWait(PageObject_Admin.AddMemershipLevel_CanBeProcessedByService_DDM(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.AddMemershipLevel_CanBeProcessedByService_DDM(), value);
        }
        public static void Click_AddMemershipLevel_CancelButton()
        {
            Helper.ElementWait(PageObject_Admin.Click_AddMemershipLevel_CancelButton(), 240);
            Helper.ElementClick(PageObject_Admin.Click_AddMemershipLevel_CancelButton());
        }
        public static void Click_AddMemershipLevel_SaveButton()
        {
            Helper.ElementWait(PageObject_Admin.Click_AddMemershipLevel_SaveButton(), 240);
            Helper.ElementClick(PageObject_Admin.Click_AddMemershipLevel_SaveButton());
        }

        public static void Click_AddMemershipLevel_EditeButton(string membershipLevelName)
        {
            Helper.ElementWait(PageObject_Admin.Click_AddMemershipLevel_EditButton(membershipLevelName), 240);
            Helper.ElementClick(PageObject_Admin.Click_AddMemershipLevel_EditButton(membershipLevelName));
        }
        public static void Click_AddMemershipLevel_DeleteButton(string membershipLevelName)
        {
            Helper.ElementWait(PageObject_Admin.Click_AddMemershipLevel_DeleteButton(membershipLevelName), 240);
            Helper.ElementClick(PageObject_Admin.Click_AddMemershipLevel_DeleteButton(membershipLevelName));
        }
        public static void Click_DeleteMemershipLevel_SubmitButton()
        {
            Helper.ElementWait(PageObject_Admin.Click_DeleteMemershipLevel_SubmitButton(), 240);
            Helper.ElementClick(PageObject_Admin.Click_DeleteMemershipLevel_SubmitButton());
        }
        public static void Click_DeleteMemershipLevel_CancelButton()
        {
            Helper.ElementWait(PageObject_Admin.Click_DeleteMemershipLevel_CancelButton(), 240);
            Helper.ElementClick(PageObject_Admin.Click_DeleteMemershipLevel_CancelButton());
        }

        public static void Click_AddMemershipLevel_Close()
        {
            Helper.ElementWait(PageObject_Admin.Click_AddMemershipLevel_Close(), 240);
            Helper.ElementClick(PageObject_Admin.Click_AddMemershipLevel_Close());
        }
        public static void Enter_AddMemershipLevel_Filter(string value)
        {
            Helper.ElementWait(PageObject_Admin.Enter_AddMemershipLevel_Filter(), 240);
            Helper.ElementEnterText(PageObject_Admin.Enter_AddMemershipLevel_Filter(), value);
        }

        public static void RequiredField_AddMembershipLevel(string mebershipLevel, string membershipcode, string levelOrder, string level_Validation, string code_Validation, string order_Validation)
        {
            MembershipSetup_AddMemershipLevel_Button();
            Helper.ElementWait(PageObject_Admin.Click_AddMemershipLevel_SaveButton(), 120);
            Logger.WriteDebugMessage("Add Membership Level button clicked and Add Overlay got displayed");
            Click_AddMemershipLevel_SaveButton();
            Helper.VerifyTextOnPageAndHighLight(level_Validation);
            Logger.WriteDebugMessage("Validation Message to enter Membership Name got Display");
            AddMemershipLevel_MembershipLevel(mebershipLevel);
            Click_AddMemershipLevel_SaveButton();
            Helper.VerifyTextOnPageAndHighLight(code_Validation);
            Logger.WriteDebugMessage("Validation Message to enter Membership Code got Display");
            AddMemershipLevel_MembershipCode(membershipcode);
            Click_AddMemershipLevel_SaveButton();
            Helper.VerifyTextOnPageAndHighLight(order_Validation);
            Logger.WriteDebugMessage("Validation Message to enter Membership Code got Display");
            AddMemershipLevel_LevelOrder(levelOrder);
            Click_AddMemershipLevel_SaveButton();
            Helper.VerifyTextOnPage("Save successful.");
            Enter_AddMemershipLevel_Filter(mebershipLevel);
            Helper.VerifyTextOnPageAndHighLight(mebershipLevel);
            Logger.WriteDebugMessage("MemberShip Level got added Succesfully");
        }

        public static void AddMembershipLevel(string name, string code, string order, string processByService)
        {
            MembershipSetup_AddMemershipLevel_Button();
            Logger.WriteDebugMessage("Clicked on Add Membership level button and Overlay got open");
            AddMemershipLevel_MembershipLevel(name);
            AddMemershipLevel_MembershipCode(code);
            AddMemershipLevel_LevelOrder(order);
            AddMemershipLevel_CanBeProcessedByService_DDM(processByService);
            Logger.WriteDebugMessage("All the Details are entered correctly");
            Click_AddMemershipLevel_SaveButton();
            Helper.VerifyTextOnPage("Save successful.");
            Enter_MembershipLevel_Filter(name);
            Helper.AddDelay(4000);
            Helper.VerifyTextOnPageAndHighLight(name);
            Logger.WriteDebugMessage("MemberShip Level got added Succesfully");
            Enter_MembershipLevel_Filter("");
        }

        public static void AddMembershipLevelForEdit(string nameEdit, string code, string order, string processByService)
        {
            MembershipSetup_AddMemershipLevel_Button();
            Logger.WriteDebugMessage("Clicked on Add Membership level button and Overlay got open");
            AddMemershipLevel_MembershipLevel(nameEdit);
            AddMemershipLevel_MembershipCode(code);
            AddMemershipLevel_LevelOrder(order);
            AddMemershipLevel_CanBeProcessedByService_DDM(processByService);
            Logger.WriteDebugMessage("All the Details are entered correctly");
            Click_AddMemershipLevel_SaveButton();
            Helper.VerifyTextOnPage("Save successful.");
            Enter_MembershipLevel_Filter(nameEdit);
            Helper.VerifyTextOnPageAndHighLight(nameEdit);
            Logger.WriteDebugMessage("MemberShip Level got added Succesfully");
        }

        public static void RequiredFieldsOnEditMembershipOverlay(string name, string membervalidation, string ordervalidation)
        {
            Click_AddMemershipLevel_EditeButton(name);
            try
            {
                Helper.ElementEnterText(PageObject_Admin.AddMemershipLevel_MembershipCode(), name);
                Assert.Fail("Membership Level Code field is not disable");
            }
            catch (Exception e)
            {
                Logger.WriteDebugMessage("Landed on Edit Membership Level Overlay and Membership Level Code field is disable");
            }
            AddMemershipLevel_MembershipLevel("");
            Logger.WriteDebugMessage("Entered the blank Space for member level textbox");
            Click_AddMemershipLevel_SaveButton();
            Helper.VerifyTextOnPageAndHighLight(membervalidation);
            Logger.WriteDebugMessage("Validation message for Member level is displayed for Edit member level");
            AddMemershipLevel_MembershipLevel(name);
            AddMemershipLevel_LevelOrder("");
            Logger.WriteDebugMessage("Entered the blank Space for member Order textbox");
            Click_AddMemershipLevel_SaveButton();
            Helper.VerifyTextOnPageAndHighLight(ordervalidation);
            Logger.WriteDebugMessage("Validation message for Member level is displayed for Edit member level");
            Click_AddMemershipLevel_CancelButton();
            Logger.WriteDebugMessage("Landed on Membership Level tab Page");

        }

        public static void EditMembershipLevel(string name, string order, string service)
        {
            Click_AddMemershipLevel_EditeButton(name);
            Logger.WriteDebugMessage("Landed on Edit Membership Level Overlay");
            AddMemershipLevel_MembershipLevel(name + "_Edit");
            AddMemershipLevel_LevelOrder(order);
            AddMemershipLevel_CanBeProcessedByService_DDM(service);
            Logger.WriteDebugMessage("All the Details are entered correctly");
            Click_AddMemershipLevel_SaveButton();
            Helper.VerifyTextOnPage("Save successful.");
            Enter_MembershipLevel_Filter(name);
            Helper.VerifyTextOnPageAndHighLight(name + "_Edit");
            Logger.WriteDebugMessage("MemberShip Level got Updated Succesfully");
        }
        public static void Delete_MembershipLevel(string mebershipLevel)
        {
            Admin.Enter_MembershipLevel_Filter(mebershipLevel);
            Click_AddMemershipLevel_DeleteButton(mebershipLevel);
            Helper.ElementWait(PageObject_Admin.Click_DeleteMemershipLevel_SubmitButton(), 120);
            Logger.WriteDebugMessage("Clicked on Delete button for " + mebershipLevel + " and Delete Overlay got displayed");
            Click_DeleteMemershipLevel_SubmitButton();
            Helper.AddDelay(5000);
            Helper.ReloadPage();
            if (Helper.IsElementRemoved(mebershipLevel))
                Assert.Fail("Membership Level not got Deleted");
            else
                Logger.WriteDebugMessage("Membership Level Deleted Successfully");

        }
        public static void Click_Memberlevelrule_Tab()
        {
            Helper.ElementWait(PageObject_Admin.Click_Memberlevelrule_Tab(), 240);
            Helper.ElementClick(PageObject_Admin.Click_Memberlevelrule_Tab());
        }
        public static void Click_AddRule_Button()
        {
            Helper.ElementWait(PageObject_Admin.Click_AddRule_Button(), 240);
            Helper.ElementClick(PageObject_Admin.Click_AddRule_Button());
        }
        public static void Select_MemberLevel_Dropdown(string value)
        {
            Helper.ElementWait(PageObject_Admin.Select_MemberLevel_Dropdown(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Select_MemberLevel_Dropdown(), value);
        }
        public static void Select_RuleType_Dropdown(string value)
        {
            Helper.ElementWait(PageObject_Admin.Select_RuleType_Dropdown(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Select_RuleType_Dropdown(), value);
        }
        public static void Select_StayType_Dropdown(string value)
        {
            Helper.ElementWait(PageObject_Admin.Select_StayType_Dropdown(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Select_StayType_Dropdown(), value);
        }
        public static void Select_DefaultRule_Dropdown(string value)
        {
            Helper.ElementWait(PageObject_Admin.Select_DefaultRule_Dropdown(), 240);
            Helper.ElementSelectFromDropDown(PageObject_Admin.Select_DefaultRule_Dropdown(), value);
        }
        public static void Enter_MonthPeriod_TextBox(string value)
        {
            Helper.ElementWait(PageObject_Admin.Enter_MonthPeriod_TextBox(), 240);
            Helper.ElementEnterText(PageObject_Admin.Enter_MonthPeriod_TextBox(), value);
        }
        public static void Enter_QualifyingNight_TextBox(string value)
        {
            Helper.ElementWait(PageObject_Admin.Enter_QualifyingNight_TextBox(), 240);
            Helper.ElementEnterText(PageObject_Admin.Enter_QualifyingNight_TextBox(), value);
        }
        public static void Enter_StayProperties_TextBox(string value)
        {
            Helper.ElementWait(PageObject_Admin.Enter_StayProperties_TextBox(), 240);
            Helper.ElementEnterText(PageObject_Admin.Enter_StayProperties_TextBox(), value);
        }
        public static void Enter_QualifiedStay_TextBox(string value)
        {
            Helper.ElementWait(PageObject_Admin.Enter_QualifiedStay_TextBox(), 240);
            Helper.ElementEnterText(PageObject_Admin.Enter_QualifiedStay_TextBox(), value);
        }
        public static void Enter_CheckedOutStay_TextBox(string value)
        {
            Helper.ElementWait(PageObject_Admin.Enter_CheckedOutStay_TextBox(), 240);
            Helper.ElementEnterText(PageObject_Admin.Enter_CheckedOutStay_TextBox(), value);
        }
        public static void Enter_Points_TextBox(string value)
        {
            Helper.ElementWait(PageObject_Admin.Enter_Points_TextBox(), 240);
            Helper.ElementEnterText(PageObject_Admin.Enter_Points_TextBox(), value);
        }
        public static void Enter_Revenue_TextBox(string value)
        {
            Helper.ElementWait(PageObject_Admin.Enter_Revenue_TextBox(), 240);
            Helper.ElementEnterText(PageObject_Admin.Enter_Revenue_TextBox(), value);
        }
        public static void Click_MembershipLevelSave_Button()
        {
            Helper.ElementWait(PageObject_Admin.Click_MembershipLevelSave_Button(), 240);
            Helper.ElementClick(PageObject_Admin.Click_MembershipLevelSave_Button());
        }
        public static void Click_MembershipLevelCancel_Button()
        {
            Helper.ElementWait(PageObject_Admin.Click_MembershipLevelCancel_Button(), 240);
            Helper.ElementClick(PageObject_Admin.Click_MembershipLevelCancel_Button());
        }
        public static void Click_MembershipLevelClose_Icon()
        {
            Helper.ElementWait(PageObject_Admin.Click_MembershipLevelClose_Icon(), 240);
            Helper.ElementClick(PageObject_Admin.Click_MembershipLevelClose_Icon());
        }
        public static void Enter_MemberLevelRule_Filter(string value)
        {
            Helper.ElementWait(PageObject_Admin.Enter_MemberLevelRule_Filter(), 240);
            Helper.ElementClearText(PageObject_Admin.Enter_MemberLevelRule_Filter());
            Helper.ElementEnterText(PageObject_Admin.Enter_MemberLevelRule_Filter(), value);
        }
        public static void Click_Edit_MembershipLevelRule()
        {
            Helper.ElementWait(PageObject_Admin.Click_Edit_MembershipLevelRule(), 240);
            Helper.ElementClick(PageObject_Admin.Click_Edit_MembershipLevelRule());
        }

        public static void AddMembershipRule(string memberLevel, string ruleType, string defaultPrice, string monthPeriod, string qualifiedNight, string stayProperties, string qualifiedStay, string checkedOutStay, string points, string revenue)
        {
            Click_AddRule_Button();
            Helper.ElementWait(PageObject_Admin.Select_MemberLevel_Dropdown(), 120);
            Logger.WriteDebugMessage("Clicked on Add Rule button and Overlay got Displayed");
            Select_MemberLevel_Dropdown(memberLevel);
            Select_RuleType_Dropdown(ruleType);
            Select_DefaultRule_Dropdown(defaultPrice);
            Enter_MonthPeriod_TextBox(monthPeriod);
            Enter_QualifyingNight_TextBox(qualifiedNight);
            Enter_StayProperties_TextBox(stayProperties);
            Enter_QualifiedStay_TextBox(qualifiedStay);
            Enter_CheckedOutStay_TextBox(checkedOutStay);
            Enter_Points_TextBox(points);
            Enter_Revenue_TextBox(revenue);
            Logger.WriteDebugMessage("All Details are entered Succesfully");
            Click_MembershipLevelSave_Button();
            Enter_MemberLevelRule_Filter(memberLevel);
            Helper.VerifyTextOnPageAndHighLight(memberLevel);
            Logger.WriteDebugMessage("Added Member Level Rule got displayed Succesffully");
        }

        public static void EditMembershipRule(string nameEdit, string ruleTypeEdit, string defaultPriceEdit, string monthPeriodEdit, string qualifiedNightEdit, string stayPropertiesEdit, string qualifiedStayEdit, string checkedOutStayEdit, string pointsEdit, string revenueEdit)
        {
            //Click_AddRule_Button();
            //Helper.ElementWait(PageObject_Admin.Select_MemberLevel_Dropdown(), 120);
            //Logger.WriteDebugMessage("Clicked on Add Rule button and Overlay got Displayed");
            Select_MemberLevel_Dropdown(nameEdit);
            Select_RuleType_Dropdown(ruleTypeEdit);
            Select_DefaultRule_Dropdown(defaultPriceEdit);
            Enter_MonthPeriod_TextBox(monthPeriodEdit);
            Enter_QualifyingNight_TextBox(qualifiedNightEdit);
            Enter_StayProperties_TextBox(stayPropertiesEdit);
            Enter_QualifiedStay_TextBox(qualifiedStayEdit);
            Enter_CheckedOutStay_TextBox(checkedOutStayEdit);
            Enter_Points_TextBox(pointsEdit);
            Enter_Revenue_TextBox(revenueEdit);
            Logger.WriteDebugMessage("All Details are entered Succesfully");
            Click_MembershipLevelSave_Button();
            Enter_MemberLevelRule_Filter(nameEdit);
            Helper.VerifyTextOnPageAndHighLight(nameEdit);
            Logger.WriteDebugMessage("Added Member Level Rule got displayed Succesffully");
        }
        public static void Click_Dropdown_MemberStatus()
        {
            Helper.ElementWait(PageObject_Admin.MemberInformation_Dropdown_MemberStatus(), 240);
            Helper.ElementClick(PageObject_Admin.MemberInformation_Dropdown_MemberStatus());
        }
        public static void Click_PointsEarningRules_Dropdown_IncludeMemberLevel()
        {
            Helper.ElementWait(PageObject_Admin.PointsEarningRules_Dropdown_IncludeMemberLevel(), 240);
            Helper.ElementClick(PageObject_Admin.PointsEarningRules_Dropdown_IncludeMemberLevel());
        }
        public static void Click_LoyaltyRules_AwardEarningRules()
        {
            Helper.ElementWait(PageObject_Admin.Click_LoyaltyRules_AwardEarningRules(), 240);
            Helper.ElementClick(PageObject_Admin.Click_LoyaltyRules_AwardEarningRules());
        }
        public static void Click_AwardEarningRules_AddRuleButton()
        {
            Helper.ElementWait(PageObject_Admin.Click_AwardEarningRules_AddRuleButton(), 240);
            Helper.ElementClick(PageObject_Admin.Click_AwardEarningRules_AddRuleButton());
        }
        public static void Click_AwardEarningRules_AddRule_IncludeMemberLevel()
        {
            Helper.ElementWait(PageObject_Admin.Click_AwardEarningRules_AddRule_IncludeMemberLevel(), 240);
            Helper.ElementClick(PageObject_Admin.Click_AwardEarningRules_AddRule_IncludeMemberLevel());
        }
        public static void Click_AwardEarningRules_AddRule_CancelButton()
        {
            Helper.ElementWait(PageObject_Admin.Click_AwardEarningRules_AddRule_CancelButton(), 240);
            Helper.ElementClick(PageObject_Admin.Click_AwardEarningRules_AddRule_CancelButton());
        }
        public static void Click_LoyaltyAwards_Dropdown_MemberLevel()
        {
            Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_NightBasedAward_Dropdown_MemberLevel(), 240);
            Helper.ElementClick(PageObject_Admin.Admin_LoyaltyAwards_NightBasedAward_Dropdown_MemberLevel());
        }
        public static void Click_LoyaltySetUp_Offers_Dropdown_MemberLevel()
        {
            Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Dropdown_MemberLevel(), 240);
            Helper.ElementClick(PageObject_Admin.LoyaltySetUp_Offers_Dropdown_MemberLevel());
        }
        public static void Click_MemberLevelRule_AddRuleButton()
        {
            Helper.ElementWait(PageObject_Admin.Click_MemberLevelRule_AddRuleButton(), 240);
            Helper.ElementClick(PageObject_Admin.Click_MemberLevelRule_AddRuleButton());
        }
        public static void Click_MemberLevelRule_AddRuleButton_NewLevel()
        {
            Helper.ElementWait(PageObject_Admin.Click_MemberLevelRule_AddRuleButton_NewLevel(), 240);
            Helper.ElementClick(PageObject_Admin.Click_MemberLevelRule_AddRuleButton_NewLevel());
        }
        public static void Click_MemberLevelRule_AddRuleButton_CancelButton()
        {
            Helper.ElementWait(PageObject_Admin.Click_MemberLevelRule_AddRuleButton_CancelButton(), 240);
            Helper.ElementClick(PageObject_Admin.Click_MemberLevelRule_AddRuleButton_CancelButton());
        }

        public static void AddMembershipRuleCancel(string memberLevel, string ruleType, string defaultPrice, string monthPeriod, string qualifiedNight, string stayProperties, string qualifiedStay, string checkedOutStay, string points, string revenue)
        {
            Click_AddRule_Button();
            Helper.ElementWait(PageObject_Admin.Select_MemberLevel_Dropdown(), 120);
            Logger.WriteDebugMessage("Clicked on Add Rule button and Overlay got Displayed");
            Select_MemberLevel_Dropdown(memberLevel);
            Select_RuleType_Dropdown(ruleType);
            Select_DefaultRule_Dropdown(defaultPrice);
            Enter_MonthPeriod_TextBox(monthPeriod);
            Enter_QualifyingNight_TextBox(qualifiedNight);
            Enter_StayProperties_TextBox(stayProperties);
            Enter_QualifiedStay_TextBox(qualifiedStay);
            Enter_CheckedOutStay_TextBox(checkedOutStay);
            Enter_Points_TextBox(points);
            Enter_Revenue_TextBox(revenue);
            Logger.WriteDebugMessage("All Details are entered Succesfully");
            Click_MembershipLevelCancel_Button();
            Enter_MemberLevelRule_Filter(memberLevel);
            //Helper.VerifyTextOnPageAndHighLight(memberLevel);
            Logger.WriteDebugMessage("Membership level rule is not added");
        }

        public static void AddMembershipRuleRequiredFields(string memberLevel, string ruleType, string defaultPrice, string monthPeriod)
        {
            Click_AddRule_Button();
            Helper.ElementWait(PageObject_Admin.Select_MemberLevel_Dropdown(), 120);
            Logger.WriteDebugMessage("Clicked on Add Rule button and Overlay got Displayed");
            Select_MemberLevel_Dropdown(memberLevel);
            Select_RuleType_Dropdown(ruleType);
            Select_DefaultRule_Dropdown(defaultPrice);
            Enter_MonthPeriod_TextBox(monthPeriod);
            Logger.WriteDebugMessage("Required fields entered Succesfully");
            Click_MembershipLevelSave_Button();
            Enter_MemberLevelRule_Filter(memberLevel);
            Helper.VerifyTextOnPageAndHighLight(memberLevel);
            Logger.WriteDebugMessage("Added Member Level Rule got displayed Succesffully");
        }

        public static void AddMembershipLevelRuleWithoutRequiredFields(string memberLevel, string ruleType, string monthPeriod, string memberLevel_Validation, string ruleType_Validation, string monthPeriod_Validation)
        {
            Click_AddRule_Button();
            //Helper.ElementWait(PageObject_Admin.Click_AddMemershipLevel_SaveButton(), 120);
            Logger.WriteDebugMessage("Add Membership Level button clicked and Add Overlay got displayed");
            Click_MembershipLevelSave_Button();
            Helper.VerifyTextOnPageAndHighLight(memberLevel_Validation);
            Logger.WriteDebugMessage("Validation Message to enter Member level Name got Display");
            Select_MemberLevel_Dropdown(memberLevel);
            Click_MembershipLevelSave_Button();
            Helper.VerifyTextOnPageAndHighLight(ruleType_Validation);
            Logger.WriteDebugMessage("Validation Message to enter Rule Type got Display");
            Select_RuleType_Dropdown(ruleType);
            Click_MembershipLevelSave_Button();
            Helper.VerifyTextOnPageAndHighLight(monthPeriod_Validation);
            Logger.WriteDebugMessage("Validation Message to enter Month Period got Display");
            Enter_MonthPeriod_TextBox(monthPeriod);
            Click_MembershipLevelSave_Button();
            Helper.VerifyTextOnPage("Save successful.");
            Enter_MemberLevelRule_Filter(memberLevel);
            Helper.VerifyTextOnPageAndHighLight(memberLevel);
            Logger.WriteDebugMessage("Added Member Level Rule got displayed Succesffully");
        }


        public static void Click_DeleteMemershipLevelRule_SubmitButton()
        {
            Helper.ElementWait(PageObject_Admin.Click_DeleteMemershipLevelRule_SubmitButton(), 240);
            Helper.ElementClick(PageObject_Admin.Click_DeleteMemershipLevelRule_SubmitButton());
        }

        public static void Click_DeleteMemershipLevelRule_CancelButton()
        {
            Helper.ElementWait(PageObject_Admin.Click_DeleteMemershipLevelRule_CancelButton(), 240);
            Helper.ElementClick(PageObject_Admin.Click_DeleteMemershipLevelRule_CancelButton());
        }

        public static void Click_DeleteMemberLevelRule_Button()
        {
            Helper.ElementWait(PageObject_Admin.Click_DeleteMemberLevelRule_Button(), 240);
            Helper.ElementClick(PageObject_Admin.Click_DeleteMemberLevelRule_Button());
        }

        public static void Click_EditMemberLevelRule_Button()
        {
            Helper.ElementClick(PageObject_Admin.Click_EditMemberLevelRule_Button());
        }

        #endregion[Admin_Member_Setup]
        #region[Admin_LoyaltyRule_LoyaltyRule_QualifyingRule]

        public static void Enter_Loyalty_Rule_QualifyingRule_General_Description(string value)
        {
            Helper.ElementWait(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_Description(), 240);
            Helper.ElementEnterText(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_Description(), value);

        }
        public static void Enter_Loyalty_Rule_QualifyingRule_General_MinRevenue(string value)
        {
            Helper.ElementWait(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_MinRevenue(), 240);
            Helper.ElementEnterText(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_MinRevenue(), value);

        }
        public static void Enter_Loyalty_Rule_QualifyingRule_General_ParallelStay(string value)
        {
            Helper.ElementWait(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_ParallelStay(), 240);
            Helper.ElementEnterText(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_ParallelStay(), value);

        }
        public static void Select_Loyalty_Rule_QualifyingRule_General_MarketCode(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_MarketCode());
            Helper.ElementEnterText(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_MarketCode_Text(), value);
            Logger.WriteDebugMessage(value + " Got Selected");
            action.SendKeys(OpenQA.Selenium.Keys.Enter).Build().Perform();
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_MarketCode());

        }
        public static void Select_Loyalty_Rule_QualifyingRule_General_ChannelCode(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_ChannelCode());
            Helper.ElementEnterText(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_ChannelCode_Text(), value);
            Logger.WriteDebugMessage(value + " Got Selected");
            action.SendKeys(OpenQA.Selenium.Keys.Enter).Build().Perform();
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_ChannelCode());

        }
        public static void Select_Loyalty_Rule_QualifyingRule_General_SourceOfBusiness(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_SourceOfBusiness());
            Helper.ElementEnterText(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_SourceOfBusiness_Text(), value);
            Logger.WriteDebugMessage(value + " Got Selected");
            action.SendKeys(OpenQA.Selenium.Keys.Enter).Build().Perform();
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_SourceOfBusiness());

        }
        public static void Click_Loyalty_Rule_QualifyingRule_General_ConsecutiveStays()
        {
            if (!PageObject_Admin.Loyalty_Rule_QualifyingRule_General_ConsecutiveStays().Selected)
                Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_ConsecutiveStays());
        }
        public static void Click_Loyalty_Rule_QualifyingRule_General_SaveButton()
        {
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_SaveButton());
        }
        public static void Click_Loyalty_Rule_QualifyingRule_General_SaveButton_Confirm()
        {
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_SaveButton_Confirm());
        }
        public static void Add_LoyaltyRule_QualifyingStay_Rule(string description, string minrev, string parallestay, string channelcode, string marketcode, string sob)
        {
            Enter_Loyalty_Rule_QualifyingRule_General_Description(description);
            Enter_Loyalty_Rule_QualifyingRule_General_MinRevenue(minrev);
            Enter_Loyalty_Rule_QualifyingRule_General_ParallelStay(parallestay);
            Select_Loyalty_Rule_QualifyingRule_General_ChannelCode(channelcode);
            Select_Loyalty_Rule_QualifyingRule_General_MarketCode(marketcode);
            Select_Loyalty_Rule_QualifyingRule_General_SourceOfBusiness(sob);
            Logger.WriteDebugMessage("All details are entered correctly");
            Click_Loyalty_Rule_QualifyingRule_General_SaveButton();
            Logger.WriteDebugMessage("Qualified Stay Rule Save Confirmation Message got Displayed");
            Click_Loyalty_Rule_QualifyingRule_General_SaveButton_Confirm();

        }
        public static void Enter_Loyalty_Rule_QualifyingRule_Night_Description(string value)
        {
            Helper.ElementWait(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_Description(), 240);
            Helper.ElementEnterText(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_Description(), value);

        }
        public static void Enter_Loyalty_Rule_QualifyingRule_Night_MinRevenue(string value)
        {
            Helper.ElementWait(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_MinRevenue(), 240);
            Helper.ElementEnterText(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_MinRevenue(), value);

        }
        public static void Select_Loyalty_Rule_QualifyingRule_Night_MarketCode(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_MarketCode());
            Helper.ElementEnterText(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_MarketCode_Text(), value);
            Logger.WriteDebugMessage(value + " Got Selected");
            action.SendKeys(OpenQA.Selenium.Keys.Enter).Build().Perform();
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_MarketCode());

        }
        public static void Select_Loyalty_Rule_QualifyingRule_Night_Hotel_SelectAll()
        {
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_Hotel());
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_Hotel_SelectAll());
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_Hotel());

        }
        public static void Select_Loyalty_Rule_QualifyingRule_Night_Hotel_DeselectAll()
        {
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_Hotel());
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_Hotel_DeselectAll());
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_Hotel());

        }
        public static void Select_Loyalty_Rule_QualifyingRule_Night_RatesCodes(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_RatesCodes());
            Helper.ElementEnterText(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_RatesCodes_Text(), value);
            Logger.WriteDebugMessage(value + " Got Selected");
            action.SendKeys(OpenQA.Selenium.Keys.Enter).Build().Perform();
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_RatesCodes());

        }
        public static void Select_Loyalty_Rule_QualifyingRule_Night_Hotel(string value)
        {

            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_Hotel());
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_Hotel_DeselectAll());
            Helper.ElementEnterText(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_Hotel_Text(), value);
            Logger.WriteDebugMessage(value + " Got Selected");
            action.SendKeys(OpenQA.Selenium.Keys.Enter).Build().Perform();
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_Hotel());

        }
        public static void Select_Loyalty_Rule_QualifyingRule_Night_MarketCombo(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_MarketCombo(), value);
        }
        public static void Select_Loyalty_Rule_QualifyingRule_Night_RateCombo(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_RateCombo(), value);
        }
        public static void Click_Loyalty_Rule_QualifyingRule_Night_Include_Market_RateCombo()
        {
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_Include_Market_RateCombo());
        }
        public static void Select_Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness());
            Helper.ElementEnterText(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness_Text(), value);
            Logger.WriteDebugMessage(value + " Got Selected");
            action.SendKeys(OpenQA.Selenium.Keys.Enter).Build().Perform();
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness());

        }
        public static void Select_Loyalty_Rule_QualifyingRule_Night_ChannelCode(string value)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_ChannelCode());
            Helper.ElementEnterText(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_ChannelCode_Text(), value);
            Logger.WriteDebugMessage(value + " Got Selected");
            action.SendKeys(OpenQA.Selenium.Keys.Enter).Build().Perform();
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_ChannelCode());

        }
        public static void Click_Loyalty_Rule_QualifyingRule_Night_SaveButton()
        {
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_SaveButton());
        }
        public static void Click_Loyalty_Rule_QualifyingRule_Night_Hotel_Include()
        {
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_Hotel_Include());
        }

        public static void Click_Loyalty_Rule_QualifyingRule_Night_SaveButton_Confirm()
        {
            Helper.ElementClick(PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_SaveButton_Confirm());
        }
        public static void Add_LoyaltyRule_QualifiedNight_Rule(string description, string minRev, string marketcode, string hotel, string ratescode, string marketcombo, string rateCombo, string sob, string channelcode)
        {
            Enter_Loyalty_Rule_QualifyingRule_Night_Description(description);
            Enter_Loyalty_Rule_QualifyingRule_Night_MinRevenue(minRev);
            Select_Loyalty_Rule_QualifyingRule_Night_Hotel(hotel);
            Select_Loyalty_Rule_QualifyingRule_Night_MarketCode(marketcode);
            Select_Loyalty_Rule_QualifyingRule_Night_RatesCodes(ratescode);
            Select_Loyalty_Rule_QualifyingRule_Night_MarketCombo(marketcombo);
            Select_Loyalty_Rule_QualifyingRule_Night_RateCombo(rateCombo);
            Click_Loyalty_Rule_QualifyingRule_Night_Include_Market_RateCombo();
            Select_Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness(sob);
            Select_Loyalty_Rule_QualifyingRule_Night_ChannelCode(channelcode);
            Click_Loyalty_Rule_QualifyingRule_Night_Hotel_Include();
            Logger.WriteDebugMessage("All Detils are entered correctly on Qualified Night Rule fields");
            Click_Loyalty_Rule_QualifyingRule_Night_SaveButton();
            Logger.WriteDebugMessage("Night Rule Save Confirmation message got displayed");
            Click_Loyalty_Rule_QualifyingRule_Night_SaveButton_Confirm();
            Helper.PageDown();
            Logger.WriteDebugMessage("Rule got Updated Succesfully");

        }
        #endregion[Admin_LoyaltyRule_LoyaltyRule_QualifyingRule]
        #region[Admin_EmailSetup]
        public static void Click_Button_EmailSetup_Add_Email()
        {
            Helper.ElementClick(PageObject_Admin.Button_EmailSetup_Add_Email());
        }
        public static void Enter_Filter_EmailSetup_SearchEmail(String value)
        {
            Helper.ElementEnterText(PageObject_Admin.Filter_EmailSetup_SearchEmail(), value);
        }
        public static void Click_Button_EmailSetup_EditEmail()
        {
            Helper.ElementClick(PageObject_Admin.Button_EmailSetup_EditEmail());
        }
        public static void Enter_Input_EmailSetup_FromEmail(String value)
        {
            Helper.ElementEnterText(PageObject_Admin.Input_EmailSetup_FromEmail(), value);
        }
        public static void Click_Button_EmailSetup_Save()
        {
            Helper.ElementClick(PageObject_Admin.Button_EmailSetup_Save());
        }
        public static void Click_Button_EmailSetup_Cancel()
        {
            Helper.ElementClick(PageObject_Admin.Button_EmailSetup_Cancel());
        }
        public static string CatchAllEmailname()
        {
            return PageObject_Admin.CatchAllEmailValue().GetAttribute("innerHTML");

        }

        
        #endregion[Admin_EmailSetup]

        #region[Admin_LoyaltyRule_RuleRestrictions]
        public static void Enter_Rule_Restrict_MinRevenue(string value)
        {
            Helper.ElementEnterText(PageObject_Admin.Enter_Rule_Restrict_MinRevenue(), value);
        }
        public static void Enter_Rule_Restrict_MinRoomRevenue(string value)
        {
            Helper.ElementEnterText(PageObject_Admin.Enter_Rule_Restrict_MinRoomRevenue(), value);
        }
        public static void Enter_Rule_Restrict_MinFandBRevenue(string value)
        {
            Helper.ElementEnterText(PageObject_Admin.Enter_Rule_Restrict_MinFandBRevenue(), value);
        }
        public static void Enter_Rule_Restrict_MinotherRevenue(string value)
        {
            Helper.ElementEnterText(PageObject_Admin.Enter_Rule_Restrict_MinotherRevenue(), value);
        }
        public static void Enter_Rule_Restrict_MinNight(string value)
        {
            Helper.ElementEnterText(PageObject_Admin.Enter_Rule_Restrict_MinNight(), value);
        }
        public static void Enter_Rule_Restrict_MinStay(string value)
        {
            Helper.ElementEnterText(PageObject_Admin.Enter_Rule_Restrict_MinStay(), value);
        }
        public static void Enter_Rule_Restrict_MaxStay(string value)
        {
            Helper.ElementEnterText(PageObject_Admin.Enter_Rule_Restrict_MaxStay(), value);
        }
        public static void Click_Rule_Restrict_MarketCode()
        {
            Helper.ElementClick(PageObject_Admin.Click_Rule_Restrict_MarketCode());
        }
        public static void Select_Rule_Restrict_MarketCode(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_Admin.Select_Rule_Restrict_MarketCode(), value);
        }
        public static void Click_Rule_Restrict_RateCode()
        {
            Helper.ElementClick(PageObject_Admin.Click_Rule_Restrict_RateCode());
        }
        public static void Select_Rule_Restrict_RateCode(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_Admin.Select_Rule_Restrict_RateCode(), value);
        }
        public static void Click_Rule_Restrict_Hotel()
        {
            Helper.ElementClick(PageObject_Admin.Click_Rule_Restrict_Hotel());
        }
        public static void Select_Rule_Restrict_Hotel(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_Admin.Select_Rule_Restrict_Hotel(), value);
        }
        public static void Click_Rule_Restrict_RoomType()
        {
            Helper.ElementClick(PageObject_Admin.Click_Rule_Restrict_RoomType());
        }
        public static void Select_Rule_Restrict_RoomType(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_Admin.Select_Rule_Restrict_RoomType(), value);
        }
        public static void Click_Rule_Restrict_SourceOfBusiness()
        {
            Helper.ElementClick(PageObject_Admin.Click_Rule_Restrict_SourceOfBusiness());
        }
        public static void Select_Rule_Restrict_SourceOfBusiness(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_Admin.Select_Rule_Restrict_SourceOfBusiness(), value);
        }
        public static void Click_Rule_Restrict_ChannelCode()
        {
            Helper.ElementClick(PageObject_Admin.Click_Rule_Restrict_ChannelCode());
        }
        public static void Select_Rule_Restrict_ChannelCode(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_Admin.Select_Rule_Restrict_ChannelCode(), value);
        }
        public static void Select_Rule_Restrict_BookingDate(string value)
        {
            Helper.ElementEnterTextUsingJQuery(PageObject_Admin.Select_Rule_Restrict_BookingDate(), value);
            //Helper.ElementEnterText(PageObject_Admin.Select_Rule_Restrict_BookingDate(), value);
        }
        public static void Select_Rule_Restrict_BookingEndDate(string value)
        {
            Helper.ElementEnterTextUsingJQuery(PageObject_Admin.Select_Rule_Restrict_BookingEndDate(), value);
            //     Helper.ElementEnterText(PageObject_Admin.Select_Rule_Restrict_BookingEndDate(), value);
        }
        public static void Select_Rule_Restrict_JoinDate(string value)
        {
            Helper.ElementEnterTextUsingJQuery(PageObject_Admin.Select_Rule_Restrict_JoinDate(), value);
            //  Helper.ElementEnterText(PageObject_Admin.Select_Rule_Restrict_JoinDate(), value);
        }
        public static void Select_Rule_Restrict_JoinEndDate(string value)
        {
            Helper.ElementEnterTextUsingJQuery(PageObject_Admin.Select_Rule_Restrict_JoinEndDate(), value);
            //  Helper.ElementEnterText(PageObject_Admin.Select_Rule_Restrict_JoinEndDate(), value);
        }
        public static void Click_Rule_Restrict_MarketCombo()
        {
            Helper.ElementClick(PageObject_Admin.Click_Rule_Restrict_MarketCombo());
        }
        public static void Select_Rule_Restrict_MarketCombo(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_Admin.Select_Rule_Restrict_MarketCombo(), value);
        }
        public static void Click_Rule_Restrict_RateCombo()
        {
            Helper.ElementClick(PageObject_Admin.Click_Rule_Restrict_RateCombo());
        }
        public static void Select_Rule_Restrict_RateCombo(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_Admin.Select_Rule_Restrict_RateCombo(), value);
        }
        public static void Click_Rule_Restrict_SaveButton()
        {
            Helper.ElementClick(PageObject_Admin.Click_Rule_Restrict_SaveButton());
        }
        public static void Click_Rule_Restrict_CancelButton()
        {
            Helper.ElementClick(PageObject_Admin.Click_Rule_Restrict_CancelButton());
        }
        public static void AddRuleRestriction(string minRevVal, string minRoomRevVal, string minFnBRevVal, string minOtherRevVal, string minNightVal, string minStayVal, string maxStaysVal, string marCodesVal, string rateCodeVal, string hotelsVal, string roomtypesVal, string sobVal, string channelCodesVal, string bookdateVal, string bookEndDate, string joinDateVal, string joinEnddate, string marcomboVal, string ratecomboVal)
        {
            Enter_Rule_Restrict_MinRevenue(minRevVal);
            Enter_Rule_Restrict_MinRoomRevenue(minRoomRevVal);
            Enter_Rule_Restrict_MinFandBRevenue(minFnBRevVal);
            Enter_Rule_Restrict_MinotherRevenue(minOtherRevVal);
            Enter_Rule_Restrict_MinNight(minNightVal);
            Enter_Rule_Restrict_MinStay(minStayVal);
            Enter_Rule_Restrict_MaxStay(maxStaysVal);
            Click_Rule_Restrict_MarketCode();
            Select_Rule_Restrict_MarketCode(marCodesVal);
            Click_Rule_Restrict_RateCode();
            Select_Rule_Restrict_RateCode(rateCodeVal);
            Click_Rule_Restrict_Hotel();
            Select_Rule_Restrict_Hotel(hotelsVal);
            Click_Rule_Restrict_RoomType();
            Select_Rule_Restrict_RoomType(roomtypesVal);
            Click_Rule_Restrict_SourceOfBusiness();
            Select_Rule_Restrict_SourceOfBusiness(sobVal);
            Click_Rule_Restrict_ChannelCode();
            Select_Rule_Restrict_ChannelCode(channelCodesVal);
            Select_Rule_Restrict_BookingDate(bookdateVal);
            Select_Rule_Restrict_BookingEndDate(bookEndDate);
            Select_Rule_Restrict_JoinDate(joinDateVal);
            Select_Rule_Restrict_JoinEndDate(joinEnddate);
            Select_Rule_Restrict_MarketCombo(marcomboVal);
            Select_Rule_Restrict_RateCombo(ratecomboVal);
        }
        #endregion[Admin_LoyaltyRule_RuleRestrictions]

        public static DateTime FromExcelSerialDate(int SerialDate)
        {
            if (SerialDate > 59) SerialDate -= 1; //Excel/Lotus 2/29/1900 bug   
            return new DateTime(1899, 12, 31).AddDays(SerialDate);
        }
        #region[Service_InsertStayNight]

        public static string InsertStay(int customerId, string propertyCode, string reservatioNo, string arrivalDate, string departureDate, string sourceNodeID, string sourceGuestId, string cendynPropertyId, string stayStatus, int stayNight, int roomNight, int numAdult, int numChil, int totalPerson, string marketSeg, string margetsubseg, string otherrevenue, string roomTypeCode, string roomRevenue, string resCreationDate, string selectedLoyMemberId, string sourceOfBusisness, string resAgent, string rateCode, string channel)
        {
            return Queries.InsertStay(customerId, propertyCode, reservatioNo, arrivalDate, departureDate, sourceNodeID, sourceGuestId, cendynPropertyId, stayStatus, stayNight, roomNight, numAdult, numChil, totalPerson, marketSeg, margetsubseg, otherrevenue, roomTypeCode, roomRevenue, resCreationDate, selectedLoyMemberId, sourceOfBusisness, resAgent, rateCode, channel);

        }

        public static void InsertNight(int resultid, int customerId, string propertyCode, string reservationNo, string stayDate, decimal stayRateAmount, int stayNumRooms, decimal stayRateAmountUSD, string stayRateType)
        {
            Queries.InsertNight(resultid, customerId, propertyCode, reservationNo, stayDate, stayRateAmount, stayNumRooms, stayRateAmountUSD, stayRateType);
        }

        #endregion[Service_InsertStayNight]

        #region[InsertLoyaltyRule]
        public static void InsertLoyaltyRule(string rulename, string displayName, string description, string dateType, string startDate, string endDate, int priority, int calculatedUnitTypeId, int fixedPoints, int calculateUnit, int CalculationType, string revenueType, decimal roomRevenue, decimal fnBRevenue, decimal otherRevenue, decimal pointsPerNight, int minRevenue, int minStay, int maxStay, string ruleType)
        {
            Queries.InsertLoyaltyRule(rulename, displayName, description, dateType, startDate, endDate, priority, calculatedUnitTypeId, fixedPoints, calculateUnit, CalculationType, revenueType, roomRevenue, fnBRevenue, otherRevenue, pointsPerNight, minRevenue, minStay, maxStay, ruleType);
        }
        #endregion[InsertLoyaltyRule]

        #region[InactiveLoyaltyRule]
        public static void TC_InactiveRules1_4(Users data, string RuleName, int activestatus)
        {
            Queries.UpdateRuleStatus(data, RuleName, activestatus);
        }
        #endregion[InactiveLoyaltyRule]

        #region[UpdteStayStatus]
        public static void UpdateStayStatusForServiceTestingPhaseTwo(string filePath, string worksheetname, int rowNumber)
        {
            //Pre-requisites [Variable Declaration]
            Users data = new Users();
            string email, resnNo, stayStatus;
            worksheetname = "Nightly_Points_Rule_Scenario";
            TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(filePath);
            email = tt.GetCellData(worksheetname, 3, rowNumber);
            resnNo = tt.GetCellData(worksheetname, 4, rowNumber);
            stayStatus = tt.GetCellData(worksheetname, 9, rowNumber);
            #region[Pre-requisites]
            Queries.GetSourceStayIDByMemberEmailAndResNo(data, email, resnNo);
            #endregion[Pre-requisites]
            #region[UpdteStayStatus]
            Queries.UpdateStayStatus(Convert.ToInt32(data.SourceStayID), stayStatus);
            #endregion[UpdateStayStatus]
        }
        #endregion[UpdteStayStatus]

        #region[UpdteNightRate]
        public static void UpdateNightRateForServiceTestingPhaseTwo(string filePath, string worksheetname, int rowNumber)
        {

            #region[Pre-requisites]
            //Pre-requisites [Variable Declaration]
            Users data = new Users();
            string email, resnNo, stayDate, rate_Code;
            decimal nightRate;

            // Retrive Data from Excel for email and Reservation No
            TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(filePath);
            email = tt.GetCellData(worksheetname, 3, rowNumber);
            resnNo = tt.GetCellData(worksheetname, 4, rowNumber);
            stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, rowNumber))).ToString("yyyy-MM-dd");
            rate_Code = tt.GetCellData(worksheetname, 7, rowNumber);
            nightRate = Convert.ToDecimal(tt.GetCellData(worksheetname, 6, rowNumber));
            #endregion[Pre-requisites]

            #region[UpdteNightRate]
            //get RateId value from DB
            Queries.GetStayRateIDByMemberEmailAndStayDate(data, email, stayDate, resnNo);
            Queries.UpdateNightRate(Convert.ToInt32(data.RateID), rate_Code, nightRate, null, null);
            #endregion[UpdateNightRate]
        }
        #endregion[UpdteNightRate]

        #region[RedeemPoints]
        public static void RedeemPointsForServiceTestingPhaseTwo(string filePath, string worksheetname, int rowNumber)
        {
            #region[Pre-requisites]
            //Pre-requisites [Variable Declaration]
            Users data = new Users();
            string email;
            int redeemPoint;
            decimal deductPoint, expectedPoint;
            // Retrive Data from Excel for email and Reservation No
            TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(filePath);
            email = tt.GetCellData(worksheetname, 3, rowNumber);
            redeemPoint = Convert.ToInt32(tt.GetCellData(worksheetname, 6, rowNumber));
            #endregion[Pre-requisites]

            #region[Redeem Point]
            Queries.GetProfileIDByMemberEmail(data, email);
            Queries.GetPointsRemainingRedeemUsingProfileID(data, Convert.ToInt32(data.ProfileID));
            deductPoint = Convert.ToDecimal(data.PointsRemainingForRedeem);
            expectedPoint = deductPoint - Convert.ToDecimal(redeemPoint);
            Queries.DeductPoints(redeemPoint, Convert.ToInt32(data.ProfileID), "ADJ", "For Automated Service Testing", "automationtestorigami@cendyn17.com");
            Queries.GetPointsRemainingRedeemUsingProfileID(data, Convert.ToInt32(data.ProfileID));
            deductPoint = Convert.ToDecimal(data.PointsRemainingForRedeem);
            if (expectedPoint != deductPoint)
                Assert.Fail("Points are not Redeem correctly");
            #endregion[UpdateNightRate]
        }
        #endregion[RedeemPoints]

        #region[UpdateMarketSubSegmentForSpecificData]
        public static void UpdateMarketSubSegmentForSpecificData(string filePath, string worksheetname, int rowNumber)
        {
            #region[Pre-requisites]
            //Pre-requisites [Variable Declaration]
            Users data = new Users();
            string email, resnNo, marketCode;
            // Retrive Data from Excel for email and Reservation No
            TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(filePath);
            email = tt.GetCellData(worksheetname, 3, rowNumber);
            resnNo = tt.GetCellData(worksheetname, 4, rowNumber);
            marketCode = tt.GetCellData(worksheetname, 14, rowNumber);
            #endregion[Pre-requisites]

            #region[UpdateMarketSubSegment]
            Queries.GetSourceStayIDByMemberEmailAndResNo(data, email, resnNo);
            Queries.UpdateMarketSubSegment(Convert.ToInt32(data.SourceStayID), marketCode);
            #endregion[UpdateMarketSubSegment]
        }
        #endregion[UpdateMarketSubSegmentForSpecificData]

        #region[SimulateDateByRuleIdAndProfileId]
        public static void SimulateDateForSpecificData(string filePath, string worksheetname, int rowNumber, string worksheetname1, int rowNumberOfSheet1)
        {
            //(int ruleId, int profileId, string dateForSimulate)
            #region[Pre-requisites]
            //Pre-requisites [Variable Declaration]
            Users data = new Users();
            string email, ruleName, departureDate;
            // Retrive Data from Excel for email and Reservation No
            TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(filePath);
            email = tt.GetCellData(worksheetname, 3, rowNumber);
            departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 13, rowNumber))).ToString("yyyy-MM-dd");
            ruleName = tt.GetCellData(worksheetname1, 1, rowNumberOfSheet1);
            #endregion[Pre-requisites]
            #region[UpdateDate]
            Queries.GetRuleByName(data, ruleName);
            Queries.GetProfileIdByMemberEmail(data, email);
            Queries.SimulateDateUsingProfileId(Convert.ToInt32(data.ProfileId), departureDate);
            #endregion[UpdateDate]
        }
        #endregion[SimulateDateByRuleIdAndProfileId]

        #region[GetValueFromMemberStayTablesByProvidingColumnNameofTheFirstRow]
        /// <summary>
        /// This method will return the first row value of the provided column name from the table
        /// It can use only for Member Stays table
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static string GetValueFromMemberStayTablesByProvidingColumnNameofTheFirstRow(string columnName)
        {
            return Helper.GetValueFromMemberStayTablesByProvidingColumnNameofTheFirstRow(columnName);
        }
        #endregion[GetValueFromMemberStayTablesByProvidingColumnNameofTheFirstRow]
        #region[SimulateDateForSpecificData24Hours]
        public static void SimulateDateForSpecificData24Hours(string filePath, string worksheetname, int rowNumber, string worksheetname1, int rowNumberOfSheet1)
        {
            //(int ruleId, int profileId, string dateForSimulate)
            #region[Pre-requisites]
            //Pre-requisites [Variable Declaration]
            Users data = new Users();
            string email, ruleName, departureDate;
            // Retrive Data from Excel for email and Reservation No
            TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(filePath);
            email = tt.GetCellData(worksheetname, 3, rowNumber);
            departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 6, rowNumber))).ToString("yyyy-MM-dd");
            ruleName = tt.GetCellData(worksheetname1, 1, rowNumberOfSheet1);
            #endregion[Pre-requisites]
            #region[UpdateDate]
            Queries.GetRuleByName(data, ruleName);
            Queries.GetProfileIdByMemberEmail(data, email);
            Queries.SimulateDateUsingProfileId(Convert.ToInt32(data.ProfileId), departureDate);
            #endregion[UpdateDate]
        }
        #endregion[SimulateDateForSpecificData24Hours]
    }
}
            