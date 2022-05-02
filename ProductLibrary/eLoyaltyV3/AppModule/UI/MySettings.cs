using eLoyaltyV3.PageObject.UI;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;
using NUnit.Framework;
using Common;
using BaseUtility.Utility;
using InfoMessageLogger;
using eLoyaltyV3.Entity;
using Queries = eLoyaltyV3.Utility.Queries;
using Setup = eLoyaltyV3.Utility.Setup;
using Constants = eLoyaltyV3.Utility.Constants;

namespace eLoyaltyV3.AppModule.UI
{
    class MySettings : eLoyaltyV3.Utility.Setup
    {
        public static bool value { get; set; }

        public static void EnterNewEmailAddress(string emailAddress)
        {
            Helper.ElementEnterText(PageObject_MySettings.MySettings_NewEmailAddress(), emailAddress);
        }

        public static void EnterPassword(string password)
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_MySettings.MySettings_Password());
            Helper.ElementEnterText(PageObject_MySettings.MySettings_Password(), password);
            Logger.WriteDebugMessage("Entered current password:" + password);
        }

        public static void ClickUpdateUser(string ProjectName)
        {
            if (ProjectName == "Loews")
            {
                Helper.DynamicScroll(Helper.Driver, PageObject_MySettings.MySettings_UpdateLogin());
                IJavaScriptExecutor js = (IJavaScriptExecutor)Helper.Driver;
                js.ExecuteScript("arguments[0].click();", PageObject_MySettings.MySettings_UpdateLogin());
            }
            else
            {
                Helper.DynamicScroll(Helper.Driver, PageObject_MySettings.MySettings_UpdateUser(ProjectName));

                IJavaScriptExecutor js = (IJavaScriptExecutor)Helper.Driver;
                js.ExecuteScript("arguments[0].click();", PageObject_MySettings.MySettings_UpdateUser(ProjectName));
            }
        }

        public static void EnterCurrentPassword(string currentPassword)
        {
            Helper.ElementEnterText(PageObject_MySettings.MySettings_CurrentPassword(), currentPassword);
        }

        public static void EnterNewPassword(string newPassword)
        {
            Helper.ElementEnterText(PageObject_MySettings.MySettings_NewPassword(), newPassword);
        }

        public static void EnterConfirmPassword(string confirmPassword)
        {
            Helper.ElementEnterText(PageObject_MySettings.MySettings_ConfirmPassword(), confirmPassword);
        }

        public static void ClickUpdatePassword(string Projectname)
        {
            //Helper.ElementClick(PageObject_MySettings.MySettings_UpdatePassword());
            IJavaScriptExecutor js = (IJavaScriptExecutor)Helper.Driver;
            js.ExecuteScript("arguments[0].click();", PageObject_MySettings.MySettings_UpdatePassword(Projectname));
            
        }

        public static void VerifyEmailUpdateDatabase(string newUsername,string table,string profileID)
        {
            string email;
            Users data = new Users();
            switch(table)
            {
                case "User":
                    Queries.ReturnEmailAddress(profileID, table, data);
                    email = data.eMail;
                    if (email.Equals(newUsername))
                    {
                        Logger.WriteDebugMessage("Username is Updated in table " + table + "as " + newUsername);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Username is not update in table" + table);
                    }
                    break;
                case "MemberShips":
                    Queries.ReturnEmailAddress(profileID, table, data);
                    email = data.MemberEmail;
                    if (email.Equals(newUsername))
                    {
                        Logger.WriteDebugMessage("Username is Updated in table " + table + "as " + newUsername);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Username is not update in table" + table);
                    }
                    break;
                case "D_Customer":
                    Queries.ReturnEmailAddress(profileID, table, data);
                    email = data.eMail;
                    if (email.Equals(newUsername))
                    {
                        Logger.WriteDebugMessage("Username is Updated in table " + table + "as " + newUsername);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Username is not update in table" + table);
                    }
                    break;
            }
        }

        public static void VerifyEmailUpdateContactUSPage(string newUsername,string title)
        {
            string emailContactUs = Helper.Getdata(PageObject_ContactUs.Text_EmailAddress());
            if (emailContactUs.Equals(newUsername))
                Logger.WriteDebugMessage("Email address is update as " + newUsername + "under Page" + title);
            else
                Assert.Fail("Email Address is NOT updated under Page" + title);

        }

        public static void UpdateUserPasswordwithCase(string CurrentPassword, string NewPassword, string ReturnResult ,int caseNum, string ProjectName)
        {
            switch (caseNum)
            {
                case 0:
                    {
                        //Fields to Update New Password for a user
                        ClickUpdatePassword(ProjectName);
                        CommonMethod.AddDelay(700);
                        if (ProjectName != "Loews")
                        {
                            Helper.ScrollToElement(Helper.Driver.FindElement(By.Id("alert-message")));
                        }

                        if (ProjectName == "IndependentCollection")
                        {
                            
                            Click_Button_updateConformationPassword();
                        }


                        Helper.VerifyTextOnPage(ReturnResult);
                        if(Helper.VerifyTextOnPage(ReturnResult) != true)
                        {
                            Assert.Fail(ReturnResult + " was not displayed on page.");
                        }
                        Logger.WriteDebugMessage("Received Message: " + ReturnResult);
                        break;
                    }
                case 1:
                    {
                        //Fields to Update New Password for a user
                        Setup.AddDelay(500);
                        EnterCurrentPassword(CurrentPassword);
                        EnterNewPassword(NewPassword);
                        EnterConfirmPassword(NewPassword);
                        Logger.WriteDebugMessage("Entered Current Password as " + CurrentPassword + ", New Password as " + NewPassword + "and Confirmed Password as "+ NewPassword + " in their respective fields.");
                        ClickUpdatePassword(ProjectName);
                        Setup.AddDelay(1500);
                        if (ProjectName != "Loews")
                        {
                            Helper.ScrollToElement(Helper.Driver.FindElement(By.Id("alert-message")));
                        }

                        if(ProjectName == "IndependentCollection")
                        {
                            Click_Button_updateConformationPassword();
                            return;
                        }
                        Helper.VerifyTextOnPage(ReturnResult);
                        if (Helper.VerifyTextOnPage(ReturnResult) != true)
                        {
                            Assert.Fail(ReturnResult + " was not displayed on page.");
                        }
                        Logger.WriteDebugMessage("Received Message: " + ReturnResult);
                        break;
                    }
                case 2:
                    {
                        string ConfirmPass = NewPassword + ".";

                        //Fields to Update New Password for a user
                        Setup.AddDelay(500);
                        EnterCurrentPassword(CurrentPassword);
                        EnterNewPassword(NewPassword);
                        EnterConfirmPassword(ConfirmPass);
                        Logger.WriteDebugMessage("Entered Current Password as " + CurrentPassword + ", New Password as " + NewPassword + "and Confirmed Password as " + ConfirmPass + " in their respective fields.");
                        ClickUpdatePassword(ProjectName);
                        Setup.AddDelay(5000);
                        if (ProjectName != "Loews")
                        {
                            Helper.ScrollToElement(Helper.Driver.FindElement(By.Id("alert-message")));
                        }
                        if (ProjectName == "IndependentCollection")
                        {
                            Click_Button_updateConformationPassword();
                            
                        }
                        Helper.VerifyTextOnPage(ReturnResult);
                        if (Helper.VerifyTextOnPage(ReturnResult) != true)
                        {
                            Assert.Fail(ReturnResult + " was not displayed on page.");
                        }
                        Logger.WriteDebugMessage("Received Message: " + ReturnResult);
                        break;
                    }
                case 3:
                    {
                        Setup.AddDelay(500);
                        EnterCurrentPassword(CurrentPassword);
                        EnterNewPassword(NewPassword);
                        Logger.WriteDebugMessage("Entered Current Password as " + CurrentPassword + " and New Password as " + NewPassword + " in their respective fields.");
                        ClickUpdatePassword(ProjectName);
                        Setup.AddDelay(200);
                        if (ProjectName != "Loews")
                        {
                            Helper.ScrollToElement(Helper.Driver.FindElement(By.Id("alert-message")));
                        }

                        if (ProjectName == "IndependentCollection")
                        {
                            Click_Button_updateConformationPassword();
                        }
                        Helper.VerifyTextOnPage(ReturnResult);
                        if (Helper.VerifyTextOnPage(ReturnResult) != true)
                        {
                            Assert.Fail(ReturnResult + " was not displayed on page.");
                        }
                        Logger.WriteDebugMessage("Received Message: " + ReturnResult);
                        break;
                    }
                case 4:
                    {
                        //Fields to Update New Password for a user
                        Setup.AddDelay(500);
                        EnterCurrentPassword(CurrentPassword);
                        EnterConfirmPassword(NewPassword);
                        Logger.WriteDebugMessage("Entered Current Password as " + CurrentPassword + " and New Password as " + NewPassword + " in their respective fields.");
                        ClickUpdatePassword(ProjectName);
                        if (ProjectName != "Loews")
                        {
                            Helper.ScrollToElement(Helper.Driver.FindElement(By.Id("alert-message")));
                        }
                        if (ProjectName == "IndependentCollection")
                        {
                            Click_Button_updateConformationPassword();
                        }
                        Setup.AddDelay(200);
                        Helper.VerifyTextOnPage(ReturnResult);
                        if (Helper.VerifyTextOnPage(ReturnResult) != true)
                        {
                            Assert.Fail(ReturnResult + " was not displayed on page.");
                        }
                        Logger.WriteDebugMessage("Received Message: " + ReturnResult);
                        break;
                    }

                case 5:
                    {
                        //Fields to Update New Password for a user
                        Setup.AddDelay(500);
                        EnterCurrentPassword(CurrentPassword);
                        EnterNewPassword(" ");
                        EnterConfirmPassword(NewPassword);
                        Logger.WriteDebugMessage("Entered Current Password as " + CurrentPassword + ", New Password as " + NewPassword + "and Confirmed Password as " + " " + " in their respective fields.");
                        ClickUpdatePassword(ProjectName);
                        Setup.AddDelay(200);
                        if (ProjectName != "Loews")
                        {
                            Helper.ScrollToElement(Helper.Driver.FindElement(By.Id("alert-message")));
                        }
                        if (ProjectName == "IndependentCollection")
                        {
                            Click_Button_updateConformationPassword();
                        }
                        Helper.VerifyTextOnPage(ReturnResult);
                        if (Helper.VerifyTextOnPage(ReturnResult) != true)
                        {
                            Assert.Fail(ReturnResult + " was not displayed on page.");
                        }
                        Logger.WriteDebugMessage("Received Message: " + ReturnResult);
                        break;
                    }
                case 6:
                    {
                        //Fields to Update New Password for a user
                        Setup.AddDelay(500);
                        EnterCurrentPassword(CurrentPassword);
                        Logger.WriteDebugMessage("Entered Current Password as " + CurrentPassword + " in current Password text field.");
                        ClickUpdatePassword(ProjectName);
                        Setup.AddDelay(200);
                        if (ProjectName != "Loews")
                        {
                            Helper.ScrollToElement(Helper.Driver.FindElement(By.Id("alert-message")));
                        }

                        if (ProjectName == "IndependentCollection")
                        {
                            Click_Button_updateConformationPassword();
                        }
                        Helper.VerifyTextOnPage(ReturnResult);
                        if (Helper.VerifyTextOnPage(ReturnResult) != true)
                        {
                            Assert.Fail(ReturnResult + " was not displayed on page.");
                        }
                        Logger.WriteDebugMessage("Received Message: " + ReturnResult);
                        break;
                    }
                case 7:
                    {
                        //Fields to Update New Password for a user
                        Setup.AddDelay(500);
                        EnterNewPassword(NewPassword);
                        Logger.WriteDebugMessage("Entered New Password as " + NewPassword + " in New Password text field.");
                        ClickUpdatePassword(ProjectName);
                        Setup.AddDelay(200);
                        if (ProjectName != "Loews")
                        {
                            Helper.ScrollToElement(Helper.Driver.FindElement(By.Id("alert-message")));
                        }
                        if (ProjectName == "IndependentCollection")
                        {
                            Click_Button_updateConformationPassword();
                        }
                        Helper.VerifyTextOnPage(ReturnResult);
                        if (Helper.VerifyTextOnPage(ReturnResult) != true)
                        {
                            Assert.Fail(ReturnResult + " was not displayed on page.");
                        }
                        Logger.WriteDebugMessage("Received Message: " + ReturnResult);
                        break;
                    }
                case 8:
                    {
                        //Fields to Update New Password for a user
                        Setup.AddDelay(500);
                        EnterConfirmPassword(NewPassword);
                        Logger.WriteDebugMessage("Entered Confirmed Password as " + NewPassword + " in Confirm Password text field.");
                        ClickUpdatePassword(ProjectName);
                        Setup.AddDelay(200);
                        if (ProjectName != "Loews")
                        {
                            Helper.ScrollToElement(Helper.Driver.FindElement(By.Id("alert-message")));
                        }
                        if (ProjectName == "IndependentCollection")
                        {
                            Click_Button_updateConformationPassword();
                        }
                        Helper.VerifyTextOnPage(ReturnResult);
                        if (Helper.VerifyTextOnPage(ReturnResult) != true)
                        {
                            Assert.Fail(ReturnResult + " was not displayed on page.");
                        }
                        Logger.WriteDebugMessage("Received Message: " + ReturnResult);
                        break;
                    }
            }
        }

        public static void UpdateUserEmail(string UpdatedEmail, string CurrentPassword, int caseNum, string ProjectName)
        {
            switch (caseNum)
            {
                case 1:
                    {
                        string ReturnResult = Constants.UpdateSettingsMessage;
                        //Fields to Update New Email Address for a user
                        EnterNewEmailAddress(UpdatedEmail);
                        if(ProjectName.Equals("AMR"))
                        {
                            Helper.Driver.FindElement(By.XPath("//input[@id='ConfirmEmail']")).SendKeys(UpdatedEmail);
                            Logger.WriteDebugMessage("Updated UserName and entered current Password.");
                            ClickUpdateUser(ProjectName);
                            Helper.AddDelay(5000);
                            Logger.WriteDebugMessage("User Should be able to change Email Sucessfully");
                            return;
                        }
                        else
                        {
                          EnterPassword(CurrentPassword);
                        }
                        Logger.WriteDebugMessage("Updated UserName and entered current Password.");
                        ClickUpdateUser(ProjectName);
                        Helper.AddDelay(7000);
                        if (ProjectName != "Loews")
                        {
                            Helper.ScrollToElement(Helper.Driver.FindElement(By.Id("alert-message")));
                        }
                        if(ProjectName== "IndependentCollection")
                        {
                            Click_Button_updateConformationEmail();
                            return;
                        }
                        Helper.VerifyTextOnPage(ReturnResult);
                        if (Helper.VerifyTextOnPage(ReturnResult) != true)
                        {
                            Assert.Fail(ReturnResult + " was not displayed on page.");
                        }                        
                        break;
                    }
                case 2:
                    {
                        string ReturnResult = Constants.ValidationSettingsMessage;
                        //Fields to Update New Email Address for a user
                        EnterNewEmailAddress(UpdatedEmail);
                        EnterPassword(CurrentPassword);
                        Logger.WriteDebugMessage("Updated UserName and entered current Password.");
                        ClickUpdateUser(ProjectName);
                        Helper.AddDelay(15000);
                        if (ProjectName != "Loews")
                        {
                            Helper.ScrollToElement(Helper.Driver.FindElement(By.Id("alert-message")));
                        }
                        Helper.VerifyTextOnPage(ReturnResult);
                        if (Helper.VerifyTextOnPage(ReturnResult) != true)
                        {
                            Assert.Fail(ReturnResult + " was not displayed on page.");
                        }                        
                        break;
                    }
                case 3:
                    {
                        string ReturnResult = Constants.InvalidEmailMessage;
                        //Fields to Update New Email Address for a user
                        EnterNewEmailAddress(UpdatedEmail);
                        EnterPassword(CurrentPassword);
                        Logger.WriteDebugMessage("Updated UserName and entered current Password.");
                        ClickUpdateUser(ProjectName);
                        Helper.AddDelay(15000);
                        if (ProjectName != "Loews")
                        {
                            Helper.ScrollToElement(Helper.Driver.FindElement(By.Id("alert-message")));
                        }
                        Helper.VerifyTextOnPage(ReturnResult);
                        if (Helper.VerifyTextOnPage(ReturnResult) != true)
                        {
                            Assert.Fail(ReturnResult + " was not displayed on page.");
                        }                        
                        break;
                    }
                case 4:
                    {
                        string ReturnResult = Constants.InvalidEmailMessage;
                        //Fields to Update New Email Address for a user
                        EnterNewEmailAddress(UpdatedEmail);
                        EnterPassword(CurrentPassword);
                        Logger.WriteDebugMessage("Updated UserName and entered current Password.");
                        ClickUpdateUser(ProjectName);
                        //Helper.ValidateTextOnPage(ReturnResult);
                        Helper.AddDelay(7000);
                        break;
                    }
            }
        }


        public static void Click_Button_updateConformationPassword()
        {
            Helper.ElementClick(PageObject_MySettings.MySettings_PasswordUpdationConformationPopup());
            
        }

        public static void Click_Button_updateConformationEmail()
        {
            Helper.ElementClick(PageObject_MySettings.MySettings_EmailUpdationConformationPopup());
        }
        
    }
}

