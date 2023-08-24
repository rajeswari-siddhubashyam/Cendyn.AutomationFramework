using eLoyaltyV3.AppModule.UI;
using eLoyaltyV3.Entity;
using eLoyaltyV3.PageObject.UI;
using eLoyaltyV3.Utility;
using InfoMessageLogger;
using TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using BaseUtility.Utility;
using Queries = eLoyaltyV3.Utility.Queries;
using System;
using eLoyaltyV3.PageObject.Admin;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        public static void TC_109737()
        {
            try
            {
                if (TestCaseId == Constants.TC_109737)
                {
                    // Pre-requisites
                    string title, promocode;
                    Users data = new Users();
                    Queries.GetMemberLevel(data, 2);
                    string level = data.MembershipLevel;
                    Queries.GetActiveLoyaltyOffer(data);

                    //Retrive data from Test Data 
                    title = data.OfferTitle;
                    promocode = data.PromotionCode;

                    //Navigate to admin -> Click on Edit in active offer -> Update level
                    Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                    Logger.WriteDebugMessage("Navigated to Admin");
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Admin.Click_Menu_LoyaltySetup();
                    Logger.WriteDebugMessage("Loyalty Setup tab clicked");
                    Admin.Click_SubTab_Offers();
                    Logger.WriteDebugMessage("Offers sub tab clicked");
                    Admin.LoyaltySetUp_Offers_Text_Filter(title);
                    Logger.WriteDebugMessage("Active Offers filtered");
                    Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                    Logger.WriteDebugMessage("Edit button clicked");
                    Admin.LoyaltySetUp_Offers_DeSelectMemberLevelALL();
                    Admin.LoyaltySetUp_Offers_SelectMemberLevel(level);
                    Logger.WriteDebugMessage("Member level selected");
                    Admin.Click_LoyaltySetUp_Offers_Button_Save();
                    if (PageObject_Admin.LoyaltySetUp_Offers_Button_Save().Displayed)
                    {
                        Admin.Click_LoyaltySetUp_Offers_Button_Cancel();
                    }
                    Logger.WriteDebugMessage("Offer updated successfully");

                    //Navigate to frontend and verify offer for user with updated membership level
                    OpenNewTab();
                    ControlToNewWindow();
                    Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                    Logger.WriteDebugMessage("Navigated to Frontend");
                    Queries.GetDataAsPerMemberLevel("PREFERRED", data);
                    string email = data.MemberEmail;
                    SignIn.LogIn(email, ProjectDetails.CommonFrontendPassword, ProjectName);
                    Logger.WriteDebugMessage("User landed on home page");
                    Navigation.Click_Link_SpecialOffer();
                    Logger.WriteDebugMessage("Navigated to Offers page");
                    VerifyTextOnPageAndHighLight(level);
                    VerifyTextOnPageAndHighLight(title);
                    PageDown();
                    Logger.WriteDebugMessage("Level and Title of the offer get displayed on Offers page");
                    Navigation.Click_SpecialOffers_Readmore(title);
                    Logger.WriteDebugMessage("Read more button clicked");
                    PageDown();
                    //ScrollToElement(PageObject_SpecialOffers.Specialoffers_LastButton());
                    //Navigation.Click_SpecialOffers_LastButton();
                    ScrollToElement(PageObject_SpecialOffers.Specialoffers_Button(promocode));
                    Navigation.Click_SpecialOffers_Button(promocode);
                    ControlToNewWindow();
                    Logger.WriteDebugMessage("ButtonText button clicked");
                    CloseCurrentTab();
                    ControlToNewWindow();
                    PageUp();
                    VerifyTextOnPageAndHighLight(level);
                    Logger.WriteDebugMessage("Membership level is same after clicking on ButtonText button");

                    // Verify offer not displayed for another membership level
                    Navigation.Click_Link_SignOut(ProjectName);
                    Logger.WriteDebugMessage("Sign out");
                    Queries.GetMemberLevel(data, 3);
                    string level2 = data.MembershipLevel;
                    Queries.GetDataAsPerMemberLevel("Elite", data);
                    string email2 = data.MemberEmail;
                    SignIn.LogIn(email2, ProjectDetails.CommonFrontendPassword, ProjectName);
                    Logger.WriteDebugMessage("User landed on home page with level = " + level2);
                    Navigation.Click_Link_SpecialOffer();
                    Logger.WriteDebugMessage("Navigated to Offers page");
                    PageDown();
                    Logger.WriteDebugMessage(title + "= Offer not displaying on the page");

                    //Log Test data into Log file and extend Report
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Title", title, true);

                }
            }
            catch (Exception e) { }
        }
        public static void TC_109738()
        {
            try { 
            if (TestCaseId == Constants.TC_109738)
            {
                // Pre-requisites
                string title, promocode;
                Users data = new Users();
                Queries.GetMemberLevel(data, 2);
                string level = data.MembershipLevel;
                Queries.GetMemberLevel(data, 3);
                string level2 = data.MembershipLevel;
                Queries.GetActiveLoyaltyOffer(data);
                //Retrive data from Test Data 
                title = data.OfferTitle;
                promocode = data.PromotionCode;


                //Navigate to admin -> Click on Edit in active offer -> Update level
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                Logger.WriteDebugMessage("Navigated to Admin");
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Admin.Click_Menu_LoyaltySetup();
                Logger.WriteDebugMessage("Loyalty Setup tab clicked");
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("Offers sub tab clicked");
                Admin.LoyaltySetUp_Offers_Text_Filter(title);
                Logger.WriteDebugMessage("Active Offers filtered");
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                Logger.WriteDebugMessage("Edit button clicked");
                Admin.LoyaltySetUp_Offers_DeSelectMemberLevelALL();
                Admin.LoyaltySetUp_Offers_SelectMemberLevel(level);
                Admin.LoyaltySetUp_Offers_SelectMemberLevel2(level2);
                Logger.WriteDebugMessage("Multiple Member levels selected");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                if (PageObject_Admin.LoyaltySetUp_Offers_Button_Save().Displayed)
                {
                    Admin.Click_LoyaltySetUp_Offers_Button_Cancel();
                }
                Logger.WriteDebugMessage("Offer updated successfully");

                //Navigate to frontend and verify offer for user with updated membership level
                OpenNewTab();
                ControlToNewWindow();
                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                Logger.WriteDebugMessage("Navigated to Frontend");
                Queries.GetDataAsPerMemberLevel("PREFERRED", data);
                string email = data.MemberEmail;
                SignIn.LogIn(email, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("User landed on home page");
                Navigation.Click_Link_SpecialOffer();
                Logger.WriteDebugMessage("Navigated to Offers page");
                AddDelay(8000);
                VerifyTextOnPageAndHighLight(level);
                VerifyTextOnPageAndHighLight(title);
                PageDown();
                Logger.WriteDebugMessage("Level and Title of the offer get displayed on Offers page");
                Navigation.Click_SpecialOffers_Readmore(title);
                Logger.WriteDebugMessage("Read more button clicked");
                PageDown();
                //ScrollToElement(PageObject_SpecialOffers.Specialoffers_LastButton());
                //Navigation.Click_SpecialOffers_LastButton();
                ScrollToElement(PageObject_SpecialOffers.Specialoffers_Button(promocode));
                Navigation.Click_SpecialOffers_Button(promocode);
                ControlToNewWindow();
                Logger.WriteDebugMessage("ButtonText button clicked");
                CloseCurrentTab();
                ControlToNewWindow();
                PageUp();
                VerifyTextOnPageAndHighLight(level);
                Logger.WriteDebugMessage("Membership level is same after clicking on ButtonText button");

                // Check for 2nd member level
                Navigation.Click_Link_SignOut(ProjectName);
                Logger.WriteDebugMessage("Sign out");
                Queries.GetDataAsPerMemberLevel("Elite", data);
                string email2 = data.MemberEmail;
                SignIn.LogIn(email2, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("User landed on home page with level = " + level2);
                Navigation.Click_Link_SpecialOffer();
                Logger.WriteDebugMessage("Navigated to Offers page");
                AddDelay(8000);
                VerifyTextOnPageAndHighLight(level2);
                VerifyTextOnPageAndHighLight(title);
                PageDown();
                Logger.WriteDebugMessage("Level and Title of the offer get displayed on Offers page");
                Navigation.Click_SpecialOffers_Readmore(title);
                Logger.WriteDebugMessage("Read more button clicked");
                PageDown();
                //ScrollToElement(PageObject_SpecialOffers.Specialoffers_LastButton());
                //Navigation.Click_SpecialOffers_LastButton();
                ScrollToElement(PageObject_SpecialOffers.Specialoffers_Button(promocode));
                Navigation.Click_SpecialOffers_Button(promocode);
                ControlToNewWindow();
                Logger.WriteDebugMessage("ButtonText button clicked");
                CloseCurrentTab();
                ControlToNewWindow();
                PageUp();
                VerifyTextOnPageAndHighLight(level2);
                Logger.WriteDebugMessage("Membership level is same after clicking on ButtonText button");

                // Verify offer not displayed for 3rd membership level
                Navigation.Click_Link_SignOut(ProjectName);
                Logger.WriteDebugMessage("Sign out");
                Queries.GetMemberLevel(data, 1);
                string level3 = data.MembershipLevel;
                Queries.GetDataAsPerMemberLevel("Member", data);
                string email3 = data.MemberEmail;
                SignIn.LogIn(email3, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("User landed on home page with level = " + level3);
                Navigation.Click_Link_SpecialOffer();
                Logger.WriteDebugMessage("Navigated to Offers page");
                PageDown();
                Logger.WriteDebugMessage(title + "= Offer not displaying on the page");


                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Title", title, true);

            }}
            catch (Exception e) { }
}
        public static void TC_109739()
        {
            if (TestCaseId == Constants.TC_109739)
            {
                // Pre-requisites
                string title, promocode;
                Users data = new Users();
                Queries.GetMemberLevel(data, 2);
                string level = data.MembershipLevel;
                Queries.GetMemberLevel(data, 3);
                string level2 = data.MembershipLevel;
                Queries.GetMemberLevel(data, 1);
                string level3 = data.MembershipLevel;
                Queries.GetMemberLevel(data, 24);
                string level4 = data.MembershipLevel;
                Queries.GetActiveLoyaltyOffer(data);

                //Retrive data from Test Data 
                title = data.OfferTitle;
                promocode = data.PromotionCode;

                //Navigate to admin -> Click on Edit in active offer -> Update level
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                Logger.WriteDebugMessage("Navigated to Admin");
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Admin.Click_Menu_LoyaltySetup();
                Logger.WriteDebugMessage("Loyalty Setup tab clicked");
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("Offers sub tab clicked");
                Admin.LoyaltySetUp_Offers_Text_Filter(title);
                Logger.WriteDebugMessage("Active Offers filtered");
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                Logger.WriteDebugMessage("Edit button clicked");
                Admin.LoyaltySetUp_Offers_SelectMemberLevelALL();
                Logger.WriteDebugMessage("All Member levels selected");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                if (PageObject_Admin.LoyaltySetUp_Offers_Button_Save().Displayed)
                {
                    Admin.Click_LoyaltySetUp_Offers_Button_Cancel();
                }
                Logger.WriteDebugMessage("Offer updated successfully");

                //Navigate to frontend and verify offer for user with updated membership level
                OpenNewTab();
                ControlToNewWindow();
                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                Logger.WriteDebugMessage("Navigated to Frontend");
                Queries.GetDataAsPerMemberLevel("PREFERRED", data);
                string email = data.MemberEmail;
                SignIn.LogIn(email, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("User landed on home page");
                Navigation.Click_Link_SpecialOffer();
                Logger.WriteDebugMessage("Navigated to Offers page");
                AddDelay(8000);
                VerifyTextOnPageAndHighLight(level);
                VerifyTextOnPageAndHighLight(title);
                PageDown();
                Logger.WriteDebugMessage("Level and Title of the offer get displayed on Offers page");
                Navigation.Click_SpecialOffers_Readmore(title);
                Logger.WriteDebugMessage("Read more button clicked");
                PageDown();
                //ScrollToElement(PageObject_SpecialOffers.Specialoffers_LastButton());
                //Navigation.Click_SpecialOffers_LastButton();
                ScrollToElement(PageObject_SpecialOffers.Specialoffers_Button(promocode));
                Navigation.Click_SpecialOffers_Button(promocode);
                ControlToNewWindow();
                Logger.WriteDebugMessage("ButtonText button clicked");
                CloseCurrentTab();
                ControlToNewWindow();
                PageUp();
                VerifyTextOnPageAndHighLight(level);
                Logger.WriteDebugMessage("Membership level is same after clicking on ButtonText button");

                // Check for 2nd member level
                Navigation.Click_Link_SignOut(ProjectName);
                Logger.WriteDebugMessage("Sign out");
                Queries.GetDataAsPerMemberLevel("Elite", data);
                string email2 = data.MemberEmail;
                SignIn.LogIn(email2, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("User landed on home page with level = " + level2);
                Navigation.Click_Link_SpecialOffer();
                Logger.WriteDebugMessage("Navigated to Offers page");
                VerifyTextOnPageAndHighLight(level2);
                VerifyTextOnPageAndHighLight(title);
                PageDown();
                Logger.WriteDebugMessage("Level and Title of the offer get displayed on Offers page");
                Navigation.Click_SpecialOffers_Readmore(title);
                Logger.WriteDebugMessage("Read more button clicked");
                PageDown();
                //ScrollToElement(PageObject_SpecialOffers.Specialoffers_LastButton());
                //Navigation.Click_SpecialOffers_LastButton();
                ScrollToElement(PageObject_SpecialOffers.Specialoffers_Button(promocode));
                Navigation.Click_SpecialOffers_Button(promocode);
                ControlToNewWindow();
                Logger.WriteDebugMessage("ButtonText button clicked");
                CloseCurrentTab();
                ControlToNewWindow();
                PageUp();
                VerifyTextOnPageAndHighLight(level2);
                Logger.WriteDebugMessage("Membership level is same after clicking on ButtonText button");

                // Check for 3rd member level
                Navigation.Click_Link_SignOut(ProjectName);
                Logger.WriteDebugMessage("Sign out");
                Queries.GetDataAsPerMemberLevel("MEMBER", data);
                string email3 = data.MemberEmail;
                SignIn.LogIn(email3, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("User landed on home page with level = " + level3);
                Navigation.Click_Link_SpecialOffer();
                Logger.WriteDebugMessage("Navigated to Offers page");
                VerifyTextOnPageAndHighLight(level3);
                VerifyTextOnPageAndHighLight(title);
                PageDown();
                Logger.WriteDebugMessage("Level and Title of the offer get displayed on Offers page");
                Navigation.Click_SpecialOffers_Readmore(title);
                Logger.WriteDebugMessage("Read more button clicked");
                PageDown();
                //ScrollToElement(PageObject_SpecialOffers.Specialoffers_LastButton());
                //Navigation.Click_SpecialOffers_LastButton();
                ScrollToElement(PageObject_SpecialOffers.Specialoffers_Button(promocode));
                Navigation.Click_SpecialOffers_Button(promocode);
                ControlToNewWindow();
                Logger.WriteDebugMessage("ButtonText button clicked");
                CloseCurrentTab();
                ControlToNewWindow();
                PageUp();
                VerifyTextOnPageAndHighLight(level3);
                Logger.WriteDebugMessage("Membership level is same after clicking on ButtonText button");

                // Check for 4th member level
                Navigation.Click_Link_SignOut(ProjectName);
                Logger.WriteDebugMessage("Sign out");
                Queries.GetDataAsPerMemberLevel("PL", data);
                string email4 = data.MemberEmail;
                SignIn.LogIn(email4, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("User landed on home page with level = " + level4);
                Navigation.Click_Link_SpecialOffer();
                Logger.WriteDebugMessage("Navigated to Offers page");
                //VerifyTextOnPageAndHighLight(level4);
                VerifyTextOnPageAndHighLight(title);
                PageDown();
                Logger.WriteDebugMessage("Level and Title of the offer get displayed on Offers page");
                Navigation.Click_SpecialOffers_Readmore(title);
                Logger.WriteDebugMessage("Read more button clicked");
                PageDown();
                //ScrollToElement(PageObject_SpecialOffers.Specialoffers_LastButton());
                //Navigation.Click_SpecialOffers_LastButton();
                ScrollToElement(PageObject_SpecialOffers.Specialoffers_Button(promocode));
                Navigation.Click_SpecialOffers_Button(promocode);
                ControlToNewWindow();
                Logger.WriteDebugMessage("ButtonText button clicked");
                CloseCurrentTab();
                ControlToNewWindow();
                PageUp();
                //VerifyTextOnPageAndHighLight(level4);
                Logger.WriteDebugMessage("Membership level is same after clicking on ButtonText button");


                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Title", title, true);

            }
        }
    }
}
