using BaseUtility.Utility;
using Common;
using eLoyaltyV3.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace eLoyaltyV3.AppModule.UI
{
    public class Navigation : BaseUtility.AppModule.UI.Navigation
    {
        public static void Click_Button_SignIn()
        {
            //Helper.ElementClick(PageObject_Navigation.Button_SignIn());
        }
        public static void Click_Button_JoinNow()
        {
            Helper.ElementClick(PageObject_Navigation.Button_JoinNow());
        }
        public static void Click_Button_JoinNowButton()
        {
            Helper.ElementClick(PageObject_Navigation.Button_JoinNow1());
        }
        public static void Navigate_To_Facebook(string mainWindowTitle, string faceBookTitle)
        {
            Navigation.Click_Link_Facebook();
            Helper.Driver.SwitchTo().Window(Helper.Driver.WindowHandles[1]);
            String ChildWindowTitleFacebook = CommonMethod.Driver.Title;
            Assert.AreNotEqual(mainWindowTitle, ChildWindowTitleFacebook);
            Assert.IsTrue(ChildWindowTitleFacebook.Contains(faceBookTitle));
            Logger.WriteDebugMessage("Verified that facebook link is opened in the new tab");
        }

        public static void Navigate_To_Twitter(string mainWindowTitle, string twitterTitle)
        {
            Navigation.Click_Link_Twitter();
            Helper.Driver.SwitchTo().Window(Helper.Driver.WindowHandles[1]);
            String chlidWindowTitleTwitter = CommonMethod.Driver.Title;
            Assert.AreNotEqual(mainWindowTitle, chlidWindowTitleTwitter);
            Assert.AreEqual(twitterTitle, chlidWindowTitleTwitter);
        }

        public static void Click_Link_Facebook()
        {
            try
            {
                Helper.ElementClick(PageObject_Navigation.Link_Facebook());
                CommonMethod.AddDelay(7000);
            }
            catch (Exception) { }
        }
        public static void Click_Link_Twitter()
        {
            Helper.ElementClick(PageObject_Navigation.Link_Twitter());
            CommonMethod.AddDelay(7000);
        }
        public static void Click_Link_Join()
        {
            Helper.ElementClick(PageObject_Navigation.Link_Join());
        }
        public static void Navigation_SignUpbtn(string ProjectName = null)
        {
            if (ProjectName != "HotelOrigami")
            {
                if (Helper.IsElementPresent(By.Id("btnEnrollNow")))
                {
                    Click_Button_JoinNow();
                }
            }
            else if ((Helper.IsElementPresent(By.XPath("//input[@id='JoinNowButton']"))) || (Helper.IsElementPresent(By.XPath("//a[contains(text(),'Join Now')]"))))
            {
                Click_Button_JoinNow();
            }
            else if (Helper.IsElementPresent(By.XPath("//a[@href='#signup']")))
            {
                Click_Link_Join();
            }


        }
        public static void Click_Link_SignIn()
        {
            if (Helper.IsElementPresent(By.PartialLinkText("SIGN IN")))
            {
                Helper.Driver.FindElement(By.PartialLinkText("SIGN IN")).Click();
            }
            else if (Helper.IsElementPresent(By.XPath("//a[contains(text(), 'Sign In')]")))
            {
                Helper.Driver.FindElement(By.XPath("//a[contains(text(), 'Sign In')]")).Click();
            }
            else if (Helper.IsElementPresent(By.XPath("//a[contains(@href, '/en-US/Login')]")))
            {
                Helper.Driver.FindElement(By.XPath("//a[contains(@href, '/en-US/Login')]")).Click();
            }
            else
            {
                //Helper.ElementClick(PageObject_Navigation.Link_SignIn());
                Helper.Driver.FindElement(By.PartialLinkText("Sign In")).Click();
            }
        }
        public static void Click_Link_UpdateMyPreferences()
        {
            Helper.ElementClick(PageObject_Navigation.Link_UpdateMyPreferences());
        }
        public static void Click_Link_UpdateMyProfile()
        {
            Helper.ElementClick(PageObject_Navigation.Link_UpdateMyProfile());
        }
        public static void Click_Link_MyProfile(string ProjectName)
        {
            if (ProjectName.Equals("HotelIcon"))
            {
                Navigation.Click_Link_UpdateMyPreferences();
            }
            else if (ProjectName.Equals("Iberostar") || ProjectName.Equals("HotelOrigami"))
            {
                Navigation.Click_Link_UpdateMyProfile();
            }
            else if (ProjectName.Equals("Fraser"))
            {
                Helper.ElementClick(PageObject_Navigation.Link_MyAccount());
                Helper.AddDelay(500);
                Helper.ElementClick(PageObject_Navigation.Link_MyProfile());
                Helper.AddDelay(500);
            }
            else if (ProjectName.Equals("MyPlace"))
            {
                Helper.ElementClickUsingJavascript(Helper.Driver.FindElement(By.XPath("//a[@class='guestProfileLink']")));
                Helper.AddDelay(500);
            }
            else if (ProjectName.Equals("Sacher"))
            {
                Helper.ElementClickUsingJavascript(Helper.Driver.FindElement(By.XPath("//*[@class='guestProfileLink']")));
                Helper.AddDelay(500);
            }
            else if (ProjectName.Equals("AdareManor"))
            {
                Helper.ElementClick(PageObject_Navigation.Link_MyProfile1());
            }
            else if (ProjectName.Equals("AMR"))
            {
                Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//a[@id='update-profile-link']")));
                Helper.AddDelay(5000);
            }
            else
            {
                Helper.ElementClick(PageObject_Navigation.Link_MyProfile());
                Time.AddDelay(5000);
            }
        }
        public static void Click_Link_ContactUs(string Projectname)
        {
            try
            {

                if (Projectname.Equals("MyPlace"))
                {
                    Helper.ElementClickUsingJavascript(PageObject_Navigation.Link_ContactUs(Projectname));
                    Helper.AddDelay(7000);
                }
                else if (Projectname.Equals("EHPC") || Projectname.Equals("HotelOrigami") || Projectname.Equals("Sacher"))
                {
                    Helper.ElementWait(PageObject_Navigation.Link_ContactUs(Projectname), 240);
                    Helper.ElementClick(PageObject_Navigation.Link_ContactUs(Projectname));
                    Helper.AddDelay(7000);
                }
                else if (Helper.IsElementVisible(Helper.Driver.FindElement(By.XPath("//*[@id='showLeft']"))))
                {
                    Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//*[@id='showLeft']")));
                    Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//ul[contains(@class, 'slide-out')]//a[contains(@href, 'ContactUs')]")));
                    Helper.AddDelay(7000);
                }
                else
                {
                    Helper.ElementClick(PageObject_Navigation.Link_ContactUs(Projectname));
                    Helper.AddDelay(7000);
                }

            }
            catch (Exception ex)
            {
                Logger.WriteFatalMessage("Unable to click the element on the page." + ex);
                throw;
            }
        }
        public static void ClickMySettings(string projectname)
        {
            if (projectname.Equals("Fraser") || projectname.Equals("Iberostar"))
            {
                Click_Link_MyAccount();
                Helper.AddDelay(2500);
                Click_Link_MySettings();
            }
            else if (projectname.Equals("AdareManor") || projectname.Equals("Loews"))
            {
                Helper.ScrollToElement(PageObject_Navigation.Link_MySettings());
                Helper.AddDelay(2500);
                Click_Link_MySettings();
            }
            else if (projectname.Equals("Bartell") || projectname.Equals("Sarova") || projectname.Equals("MyPlace") || projectname.Equals("EHPC") || projectname.Equals("HotelIcon"))
            {
                Helper.ScrollToElement(PageObject_Navigation.LinkText_MySettings(projectname));
                Helper.AddDelay(2500);
                Helper.ElementClick(PageObject_Navigation.LinkText_MySettings(projectname));
            }
            else if (projectname.Equals("HotelOrigami"))
            {
                Helper.ElementClick(PageObject_Navigation.Link_MySettings());
                Logger.WriteDebugMessage("Clicked on My Settings Button.");
                Helper.ElementWait(PageObject_MySettings.MySettings_UpdateUser(projectname), 60);
            }
            else if (projectname.Equals("HotelOrigami_Production"))
            {
                Helper.ElementClick(PageObject_Navigation.Link_MySettings());
                Logger.WriteDebugMessage("Clicked on My Settings Button.");
                Helper.ElementWait(PageObject_MySettings.MySettings_UpdateUser(projectname), 60);
            }
            else if (projectname.Equals("AMR"))
            {
                Helper.ElementClick(PageObject_Navigation.Link_MySettings());
                Logger.WriteDebugMessage("Clicked on My Settings Button.");

            }
            else
            {
                if (!projectname.Equals("HotelOrigami") && !projectname.Equals("Sacher"))
                {
                    Helper.ScrollToElement(Helper.Driver.FindElement(By.Id("headingOne")));
                }
                Helper.ElementClick(PageObject_Navigation.Link_MySettings());
                Logger.WriteDebugMessage("Clicked on My Settings Button.");
                Helper.ElementWait(PageObject_MySettings.MySettings_UpdateUser(projectname), 60);
            }

        }
        public static void Click_Link_MyAccount()
        {
            try
            {
                Helper.ElementClick(PageObject_Navigation.Link_MyAccount());
                Helper.AddDelay(7000);
            }
            catch (Exception) { }

        }
        public static void Click_Link_MySettings()
        {
            Helper.ElementClick(PageObject_Navigation.Link_MySettings());

        }
        public static void ClickSignOut(string Projectname)
        {
            try
            {
                if (Projectname.Equals("EHPC") || Projectname.Equals("HotelOrigami") || Projectname.Equals("Sacher"))
                {
                    Helper.ElementClick(PageObject_Navigation.Link_SignOut(Projectname));
                    Helper.AddDelay(5000);
                }
                else if (Helper.IsElementVisible(Helper.Driver.FindElement(By.XPath("//*[@id='showLeft']"))))
                {
                    Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//*[@id='showLeft']")));
                    Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//ul[contains(@class, 'slide-out')]//a[contains(@href, 'Logout')]")));
                    Helper.AddDelay(7000);
                }
                else
                {
                    Helper.ElementClick(PageObject_Navigation.Link_SignOut(Projectname));
                    Helper.AddDelay(15000);
                }
            }
            catch (Exception) { }
        }
        public static void Click_Button_Back()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Button_Back());
        }

        public static void Click_Link_MyActivity()
        {
            Helper.ElementClick(PageObject_Navigation.Link_MyActivity());
        }

        public static void Click_Link_MyStays()
        {
            Helper.PageUp();
            try
            {
                if (Helper.IsElementPresent(By.XPath("//a[contains(text(),'My Stays')]")))
                {
                    Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//a[contains(text(),'My Stays')]")));
                }
                else if (Helper.IsElementPresent(By.XPath("//a[contains(text(),'Status')]")))
                {
                    Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//a[contains(text(),'Status')]")));
                }
                else if (Helper.IsElementPresent(By.XPath("//a[contains(.,'Stays')]")))
                {
                    Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//a[contains(.,'Stays')]")));
                }
                else if (Helper.IsElementPresent(By.XPath("//a[contains(@href,'MyStays')]")))
                {
                    Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//a[contains(@href,'MyStays')]")));
                }
                else
                {
                    Helper.ElementClick(Helper.Driver.FindElement(By.LinkText("MY STAYS")));
                }

                Helper.ElementWait(Helper.Driver.FindElement(By.XPath("//input[@aria-controls='DataTables_Table_0']")), 60);
                if (Helper.IsElementPresent(By.XPath("//input[@aria-controls='DataTables_Table_0']")))
                {
                    Logger.WriteDebugMessage("Landed on Stays Page.");
                }


            }

            catch (Exception e)
            {
                Logger.WriteDebugMessage("Exited with excption :" + e);
            }

        }
        public static void Click_Link_MyStays2()
        {
            Helper.ElementClick(PageObject_Navigation.Link_MyStays());

        }

        public static void Click_Link_SpecialOffer()
        {
            Helper.ElementClick(PageObject_Navigation.Link_SpecialOffer());
        }

        public static void Click_SpecialOffers_Readmore(string offername)
        {
            Helper.ElementClick(PageObject_SpecialOffers.Specialoffers_Readmore(offername));
        }

        public static void Click_SpecialOffers_Button(string buttonName)
        {
            Helper.ElementClick(PageObject_SpecialOffers.Specialoffers_Button(buttonName));
        }

        public static void Click_Link_MyAward()
        {
            Helper.ElementClick(PageObject_Navigation.Link_MyAward());

        }
        public static void MyAwards_Text_Filter(string value)
        {
            Helper.ElementEnterText(PageObject_Navigation.MyAwards_Text_Filter(), value);

        }

        public static void Click_Link_Exclusive()
        {
            Helper.ElementClick(PageObject_Navigation.Link_Exclusives());
        }
        public static void Click_Link_LoginExclusives()
        {
            Helper.ElementClick(PageObject_Navigation.Link_LoginExclusives());
        }

        public static void Click_Link_Redeem()
        {
            Helper.ElementClick(PageObject_Navigation.Link_Redeem());
        }
        public static void Click_Link_InviteFriends()
        {
            Helper.ElementClick(PageObject_Navigation.Link_InviteFriends());
        }

        public static void Click_Link_Enroll()
        {
            Helper.ElementClick(PageObject_Navigation.Link_Enroll());
        }

        public static void Click_MyAward_Redeem_Button()
        {
            Helper.ElementClick(PageObject_Navigation.MyAwards_Redeem_Button());
        }

        public static void Click_Link_ProgramOverview()
        {
            Helper.ElementClick(PageObject_Navigation.Link_ProgramOverview());
        }

        public static void Click_Link_Benefits()
        {
            Helper.ElementClick(PageObject_Navigation.Link_Benefits());
        }
        public static void Click_Link_FAQ()
        {
            Helper.ElementClick(PageObject_Navigation.Link_FAQ());
        }
        public static void Click_Link_SignOut(string Projectname)
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_Navigation.Link_SignOut(Projectname));
            Helper.AddDelay(2500);
            Helper.ElementClick(PageObject_Navigation.Link_SignOut(Projectname));
        }

        public static void Click_Link_FAQ1()
        {
            Helper.ElementClick(PageObject_Navigation.Link_FAQ1());
        }

        public static void VerifyMenuLinks(string Event, string ProjectName)
        {
            try
            {
                switch (Event)
                {
                    case "After":
                        Click_Link_MyActivity();
                        string landingMyActivity = Helper.Driver.Title;
                        SignIn.VerifyLandingPage(ProjectName, landingMyActivity);
                        Helper.AddDelay(3000);

                        Click_Link_MyProfile(ProjectName);
                        string landingMyProfile = Helper.Driver.Title;
                        SignIn.VerifyLandingPage(ProjectName, landingMyProfile);
                        Helper.AddDelay(3000);

                        Click_Link_ProgramOverview();
                        string landingOverview = Helper.Driver.Title;
                        SignIn.VerifyLandingPage(ProjectName, landingOverview);
                        Helper.AddDelay(3000);

                        Click_Link_Benefits();
                        string landingBenefits = Helper.Driver.Title;
                        SignIn.VerifyLandingPage(ProjectName, landingBenefits);
                        Helper.AddDelay(3000);

                        Click_Link_Redeem();
                        string landingRedeem = Helper.Driver.Title;
                        SignIn.VerifyLandingPage(ProjectName, landingRedeem);
                        Helper.AddDelay(3000);

                        Click_Link_MyAward();
                        string landingMyAward = Helper.Driver.Title;
                        SignIn.VerifyLandingPage(ProjectName, landingMyAward);
                        Helper.AddDelay(3000);

                        Click_Link_SpecialOffer();
                        string landingSpecialOffer = Helper.Driver.Title;
                        SignIn.VerifyLandingPage(ProjectName, landingSpecialOffer);
                        Helper.AddDelay(3000);

                        Click_Link_FAQ();
                        string landingFAQ = Helper.Driver.Title;
                        SignIn.VerifyLandingPage(ProjectName, landingFAQ);
                        Helper.AddDelay(3000);

                        Click_Link_ContactUs(ProjectName);
                        string landingContactUs = Helper.Driver.Title;
                        SignIn.VerifyLandingPage(ProjectName, landingContactUs);
                        Helper.AddDelay(3000);

                        Click_Link_SignOut(ProjectName);
                        Helper.AddDelay(3000);
                        break;

                    case "Before":

                        Click_Link_SignIn();
                        string landingSignIn = Helper.Driver.Title;
                        SignIn.VerifyLandingPage(ProjectName, landingSignIn);
                        Helper.AddDelay(3000);

                        Click_Link_Enroll();
                        string landingEnroll = Helper.Driver.Title;
                        SignIn.VerifyLandingPage(ProjectName, landingEnroll);
                        Helper.AddDelay(3000);

                        Click_Link_FAQ1();
                        string landingFAQ1 = Helper.Driver.Title;
                        SignIn.VerifyLandingPage(ProjectName, landingFAQ1);
                        Helper.AddDelay(3000);

                        Logger.WriteInfoMessage("All Tabs are present on Before Login");
                        break;
                }
            }
            catch (Exception e)
            {
                Logger.WriteDebugMessage("Verification of Tabs failed ");
            }


        }
        public static void SignUp_Button_Join()
        {
            Helper.ElementClick(PageObject_Navigation.SignUp_Button_Join());
        }
        public static string DOB_Error()
        {
            return Helper.GetText(PageObject_Navigation.DOB_Error());
        }
        public static string FirstName_Error()
        {
            return Helper.GetText(PageObject_Navigation.FirstName_Error());
        }
        public static string LastName_Error()
        {
            return Helper.GetText(PageObject_Navigation.LastName_Error());
        }
        public static string Email_Error()
        {
            return Helper.GetText(PageObject_Navigation.Email_Error());
        }
        public static string Card_Error()
        {
            return Helper.GetText(PageObject_Navigation.Card_Error());
        }
        public static string Password_Error()
        {
            return Helper.GetText(PageObject_Navigation.Password_Error());
        }
        public static string ConfirmPassword_Error()
        {
            return Helper.GetText(PageObject_Navigation.ConfirmPassword_Error());
        }
        public static string Captcha_Error()
        {
            return Helper.GetText(PageObject_Navigation.Captcha_Error());
        }

        public static void CheckIfSignUpButtonIsVisible(string ProjectName)
        {
            if (!ProjectName.Equals("AdareManor"))
            {
                if (Helper.IsElementPresent(By.Id("btnEnrollNow")))
                {
                    Navigation.Click_Link_Join2();
                }
                else if (Helper.IsElementPresent(By.XPath("//a[@href='#signup']")))
                {
                    Navigation.Click_Link_Join();
                }
            }
            else
            {
                Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//a[@href='#signin']")));
            }
        }

        public static void Click_Link_Join2()
        {
            Helper.ElementClick(PageObject_Navigation.Link_Join2());
        }
        /// <summary>
        /// This method will verify the Member Since data is displaying for today's date.
        /// </summary>
        public static void VerifyMemberSinceToday(string Projectname)
        {
            string memberSince;
            if (Projectname.Equals("Sarova"))
            {
                memberSince = DateTime.Now.ToString("dd/MM/yyyy");
            }
            else
            {
                memberSince = DateTime.Now.ToString("M/d/yyyy");
            }


            try
            {
                if (Projectname.Equals("HotelIcon"))
                    Helper.ScrollToElement(Helper.Driver.FindElement(By.XPath("//strong[contains(text(), '" + memberSince + "')]")));

                else
                    Helper.ScrollToElement(Helper.Driver.FindElement(By.XPath("//span[contains(text(), '" + memberSince + "')]")));
                if (Helper.VerifyTextOnPage(memberSince))
                {
                    Logger.WriteDebugMessage("Found the text: '" + memberSince + "' on the page.");
                }

                else
                {
                    Assert.Fail("Did not find todays date: '" + memberSince + "' on the page.");
                }
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                throw;
            }

        }
        public static void Click_MembershipCard()
        {
            Helper.ElementWait(PageObject_Summary.Summary_Click_MembershipCard(), 120);
            Helper.ElementClick(PageObject_Summary.Summary_Click_MembershipCard());
        }
        public static void Click_MembershipCard_Close()
        {
            Helper.ElementWait(PageObject_Summary.Summary_MembershipCard_Close(),120);
            Helper.ElementClick(PageObject_Summary.Summary_MembershipCard_Close());
        }
        public static void Click_SpecialOffers_LastButton()
        {
            Helper.ElementClick(PageObject_SpecialOffers.Specialoffers_LastButton());
        }
        public static void Click_Contact_Link()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Contact_Link());
        }



    }
}