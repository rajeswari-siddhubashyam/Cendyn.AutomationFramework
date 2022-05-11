using System;
using eLoyaltyV3.Utility;
using eLoyaltyV3.PageObject.UI;
using eLoyaltyV3.AppModule.UI;
using System.Collections.Generic;
using NUnit.Framework;
using InfoMessageLogger;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Queries = eLoyaltyV3.Utility.Queries;
using Constants = eLoyaltyV3.Utility.Constants;
using TestData;
using eLoyaltyV3.Entity;
using eLoyaltyV3.PageObject.Admin;
using BaseUtility.Utility;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eLoyaltyV3.Utility.Setup
    {
        #region TP Production Defect Page
        private static void D_222631()
        {
            if (TestCaseId == Constants.D_222631)
            {
                string page;
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);
                //1.Sign In with Valid credentail             
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                page = Driver.Title;
                Logger.WriteDebugMessage("user landed on " + page + "page");

                //2.Click on Redeem Tab
                Navigation.Click_Link_Redeem();
                page = Driver.Title;
                Logger.WriteDebugMessage("user landed on " + page + "page");

                //3.Verify if page is displayed as blank
                PageObject_Redeem.Button_Redeem();
                IList<IWebElement> elements = Driver.FindElements(By.XPath(ObjectRepository.Reedem_Button_Redeem));
                foreach (IWebElement element in elements)
                {
                    string value = element.GetAttribute("innerHTML");
                    if (value.Equals("Redeem"))
                    {
                        HighlightElement(element);
                        Logger.WriteDebugMessage("Redeem Button displayed under Reddem Page");
                    }
                    else
                    {
                        Assert.Fail("Redeem button is not displayed on the page");
                    }
                }
            }
        }

        private static void D_222706()
        {
            if (TestCaseId == Constants.D_222706)
            {
                string page;
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);
                //1.Sign In with Valid credentail             
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                page = Driver.Title;
                Logger.WriteDebugMessage("user landed on " + page + "page");

                //2.Click on Redeem Tab
                Navigation.Click_Link_InviteFriends();
                page = Driver.Title;
                Logger.WriteDebugMessage("user landed on " + page + "page");

                //3.Verify if page is displayed as blank
                PageObject_InviteFriends.Text_InviteFriends();
                string value = PageObject_InviteFriends.Text_InviteFriends().GetAttribute("innerHTML");
                if (value.Equals("Invite Friends"))
                {
                    VerifyTextOnPageAndHighLight(value);
                    HighlightElement(PageObject_InviteFriends.Button_SendMyInvitation());
                    Logger.WriteDebugMessage("User landed on Invite Friends page.");
                }
                else
                {
                    Assert.Fail("User is landed on Invite Friend Page which is displayed as blank");
                }
            }
        }

        private static void D_222707()
        {
            if (TestCaseId == Constants.D_222707)
            {
                string page;
                Users data = new Users();
                Queries.GetActiveMemberEmail(data, ProjectName);

                //1.Sign In with Valid credentail             
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                page = Driver.Title;
                Logger.WriteDebugMessage("user landed on " + page + "page");
                Logger.LogTestData(TestPlanId, TestCaseId, "Active Email", data.MemberEmail, true);
                //2.Click on Redeem Tab
                Navigation.Click_Link_SpecialOffer();
                page = Driver.Title;
                Logger.WriteDebugMessage("user landed on " + page + "page");

                //3.Verify if page is displayed as blank
                if (ProjectName.Equals("Fraser"))
                {
                    PageObject_SpecialOffers.Text_Exclusive();
                    string value = PageObject_SpecialOffers.Text_Exclusive().GetAttribute("innerHTML");
                    if (value.Equals("Exclusives"))
                    {
                        VerifyTextOnPageAndHighLight(value);
                        Logger.WriteDebugMessage("User landed on Special Offers page.");
                    }
                    else
                    {
                        Assert.Fail("User is landed on Special Offers Page which is displayed as blank");
                    }
                }
            }
        }
        #endregion

        #region TP Production Defect Page - July Defect [2019]
        private static void D_220805()
        {
            if (TestCaseId == Constants.D_220805)
            {
                Users data = new Users();
                string randomText = randomNumber.Next().ToString();
                string page, awardName, code, AwardType, pointValue, memberLevelText, emailText, couponName, marketingPartner, catalog, cardAmount, awardexpMonth, connectTo, name, balance;
                string startDate = DateTime.Now.ToString("MM/dd/yyyy");
                string endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                Console.WriteLine(DateTime.Now.Millisecond);
                awardName = string.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "AwardName"), randomText);
                code = string.Concat(DateTime.Now.Millisecond, DateTime.Now.Second);
                AwardType = TestData.ExcelData.TestDataReader.ReadData(1, "AwardType");
                pointValue = TestData.ExcelData.TestDataReader.ReadData(1, "PointValue");
                memberLevelText = TestData.ExcelData.TestDataReader.ReadData(1, "MemberLevelText");
                emailText = TestData.ExcelData.TestDataReader.ReadData(1, "EmailText");
                couponName = string.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "CouponName"), randomText);
                marketingPartner = TestData.ExcelData.TestDataReader.ReadData(1, "MarketingPartner");
                cardAmount = TestData.ExcelData.TestDataReader.ReadData(1, "CardAmount");
                catalog = TestData.ExcelData.TestDataReader.ReadData(1, "Catalog");
                awardexpMonth = TestData.ExcelData.TestDataReader.ReadData(1, "AwardExpMonth");
                name = string.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "RedemptionName"), randomText);
                //name = TestData.ExcelData.TestDataReader.ReadData(1, "RedemptionName");
                balance = TestData.ExcelData.TestDataReader.ReadData(1, "Balance");
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 20);

                //1.Navigate to Admin site
                //2.Log in with valid credentials
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Helper.ElementWait(PageObject_Admin.Menu_LoyaltyAwards(), 20);
                page = Driver.Title;
                Logger.WriteDebugMessage("user landed on " + page + "page");

                // 2.Click on Loyalty Award >> Click on Add Award
                Admin.Click_Menu_LoyaltyAwards();
                Helper.ElementWait(PageObject_Admin.Admin_Button_Awards_Add(), 20);
                Admin.Click_Button_Awards_Add();
                Logger.WriteDebugMessage("Add Award Popup should be displayed");

                //enter award details
                //3.Create an active point based award, as manual and check eGift checkbox.
                Admin.AddAward(awardName, code, startDate, endDate, AwardType);
                Admin.Click_Admin_Use_As_EGift();
                // Admin.AddPointBasedAward(pointValue, memberLevelText, emailText, awardexpMonth);

                Admin.AddPointBasedAwardWithAllMemberLevel(pointValue, emailText, awardexpMonth);
                Logger.WriteDebugMessage("All data should be get updated successfully");

                //click on save button
                Admin.Click_LoyaltyAwards_Button_Save();
                VerifyTextOnPage("Save Successfull");
                Logger.LogTestData(TestPlanId, TestCaseId, "Award Name", awardName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Award Code", code);
                Logger.LogTestData(TestPlanId, TestCaseId, "Award Type", AwardType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Point Value", pointValue);
                Logger.LogTestData(TestPlanId, TestCaseId, "Email Text", emailText);
                Logger.LogTestData(TestPlanId, TestCaseId, "Coupon Name", couponName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Marketing Partner", marketingPartner);
                Logger.LogTestData(TestPlanId, TestCaseId, "Catalog", catalog);
                Logger.LogTestData(TestPlanId, TestCaseId, "Redemption Name", name);
                Logger.LogTestData(TestPlanId, TestCaseId, "Balance", balance);
                Helper.ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Text_Filter(), 20);
                Admin.LoyaltyAwards_Text_Filter(awardName);
                Logger.WriteDebugMessage("Points based award should be added");

                //4.Click on Loyalty eGift > Click on Add 
                Admin.Click_Menu_LoyaltyeGifts();
                Helper.ElementWait(PageObject_Admin.Admin_LoyaltyeGifts_Button_AddeGift(), 20);
                Admin.Click_Admin_LoyaltyeGifts_Button_AddeGift();
                Logger.WriteDebugMessage("Loyalty Add eGift popup should be displayed");

                //5.Add an eGift of amount $10 and link recently created award.
                Admin.Add_LoyaltyeGifts(couponName, marketingPartner, awardName, catalog, cardAmount);
                Logger.WriteDebugMessage("Loyalty eGift should be added successfully");
                //click on Add button
                Admin.Admin_LoyaltyeGifts_Button_Add();
                VerifyTextOnPage("Saved Successfully");
                Helper.ElementWait(PageObject_Admin.Menu_Redeem(), 30);

                //6.Click_Menu_Redeem
                Admin.Click_Menu_Redeem();
                Logger.WriteDebugMessage("User navigates to Redeem tab");

                //7.Select an existing Redemption and link recently created record
                Helper.ElementWait(PageObject_Admin.Button_Add_Redemption(), 20);
                //add redeemption
                Admin.AddRedemption(name, awardName, name);
                //Admin.Click_Admin_Menu_Redeem_Edit();
                //Admin.Select_Admin_Menu_Redeem_Dropdown_Connect_To(awardName);
                //Admin.Click_Admin_Menu_Redeem_Button_Save();
                VerifyTextOnPage("Saved Successfully");
                Logger.WriteDebugMessage("Linked to recently added record");

                //8.Navigate to frontend portral
                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);

                Queries.GetMemberEmailWithSufficientBalance(data, balance);
                email = data.MemberEmail;
                //String email1= "Origamifrontautomationuser@cendyn17.com";
                LoginCredentials(email, ProjectDetails.CommonFrontendPassword, ProjectName);
                page = Driver.Title;
                Logger.WriteDebugMessage("user landed on " + page + "page");
                Logger.LogTestData(TestPlanId, TestCaseId, "Email with Sufficient Balance", data.MemberEmail, true);
                Helper.ElementWait(PageObject_Redeem.Navigation_Link_Redeem(), 20);
                //9. Navigate to Redeem tab
                Redeem.Click_Button_Redeem();
                // Helper.DynamicScroll(Helper.Driver,PageObject_Redeem.Redeem_Button_Frontend(name));
                //Helper.ElementWait(PageObject_Redeem.Redeem_Button_Frontend(),20);
                //13.Click on Redeem tab > Select recently edited Redemption record and click on Redeem button
                Redeem.Click_Redeem_Button_Frontend();
                Redeem.Click_Ok_Button_On_EGift();
                //verify that the image is present on the egift card
                if (PageObject_Redeem.Select_AwardImage().Displayed)
                //Assert.IsTrue(PageObject_Redeem.Image_On_Redeem_Button_Frontend().Displayed);
                {
                    Logger.WriteDebugMessage("Redeem card is displayed");
                }
                else
                {
                    Assert.Fail("Redeem card is not dispalyed");
                }

                //Login to Admin and Flip the Award status as off
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                ElementWait(PageObject_Admin.Menu_LoyaltyAwards(), 20);
                Admin.Click_Menu_LoyaltyAwards();
                Admin.LoyaltyAwards_Text_Filter(awardName);
                Logger.WriteDebugMessage("Award should be found");
                Admin.Click_LoyaltyAwards_Icon_Edit();
                Logger.WriteDebugMessage("Loyalty award popup should get display");
                Admin.Click_Admin_AwardStatusSwitch();
                Logger.WriteDebugMessage("Award Status button got switch off");
                Admin.Click_LoyaltyAwards_Button_Save();
                Logger.WriteDebugMessage("Award Status get switch off");
                Admin.LoyaltyAwards_Text_Filter(awardName);
                Logger.WriteDebugMessage("Award should be found");
            }
        }

        private static void D_221237()
        {
            if (TestCaseId == Constants.D_221237)
            {
                Logger.WriteDebugMessage("Navigated to Frontend");

                //2.SignIn.LogIn(email, password, ProjectName);
                string firstName, lastName, email;
                email = TestData.ExcelData.TestDataReader.ReadData(1, "Email");
                firstName = TestData.ExcelData.TestDataReader.ReadData(1, "FirstName");
                lastName = TestData.ExcelData.TestDataReader.ReadData(1, "LastName");
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Navigation_SignUpbtn();
                }
                else
                {
                    Navigation.Click_Link_Enroll();
                }
                Logger.LogTestData(TestPlanId, TestCaseId, "Email", email);
                Logger.LogTestData(TestPlanId, TestCaseId, "First Name", firstName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Last Name", lastName, true);

                //3.Enter data in First name, last name, email id field
                //4.Click on Date of Birth field and notice the option list
                ElementWait(PageObject_SignUp.Text_FirstName(), 20);
                SignUp.Click_On_Date_Of_Birth_Field(firstName, lastName, email);
                //verification
                Helper.VerifyElementOnPage(PageObject_SignUp.SignUp_Date_Picker());
                Logger.WriteDebugMessage("Calander is appearing on the date picker field");
            }
        }

        private static void D_221661()
        {
            if (TestCaseId == Constants.D_221661)
            {
                string multipleEmail = TestData.ExcelData.TestDataReader.ReadData(1, "MultipleEmail");

                //1.Navigate to Admin portal
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                ElementWait(PageObject_Admin.Admin_Text_UserName(), 20);

                //2.Log in with valid credentials
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                ElementWait(PageObject_Admin.Admin_Menu_LoyaltyeGifts(), 20);

                //3.Click on Loyalty eGifts
                Admin.Click_Menu_LoyaltyeGifts();

                //4.Click on Marketing Partners tab > Click on edit
                Admin.Admin_LoyaltyeGifts_Marketing_Partner_Tab();
                Admin.Admin_LoyaltyeGifts_Marketing_Partner_Edit();
                Admin.Admin_LoyaltyeGifts_Marketing_Partner_Notify_ClearText();

                //.5 Enter multiple email ids in Notify field and click on save
                Admin.Admin_LoyaltyeGifts_Marketing_Partner_Notify_EnterText(multipleEmail);
                Admin.Admin_LoyaltyeGifts_Marketing_Partner_Notify_Save();
                //verification
                VerifyTextOnPage("Save Successfull");

            }
        }

        private static void D_221720()
        {
            if (TestCaseId == Constants.D_221720)
            {
                // Pre-requisites
                string description = TestData.ExcelData.TestDataReader.ReadData(1, "Description");
                string iFrame = "tcdesc_ifr";

                //1.Navigate to Admin portal
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                ElementWait(PageObject_Admin.Admin_Text_UserName(), 20);

                //2.Log in with valid credentials
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                ElementWait(PageObject_Admin.Menu_LoyaltySetup(), 120);

                //3.Click on Loyalty Setup > Terms & Conditions
                //4.Click on Add button
                Admin.Click_Menu_LoyaltySetup();
                Admin.Click_SubTab_TermsAndConditions();
                Admin.Click_Admin_LoyaltySetUp_TermsAndCondition_Add_TermsAndCondition();

                //5.Enter description and keep title field blank as it is not mandatory
                Admin.Enter_Admin_LoyaltySetUp_TermsAndCondition_Description(description, iFrame);

                //6.Click on Save button
                Admin.Click_TermsAndCondition_Button_Save();
                //verification 
                if (PageObject_Admin.TermsAndCondition_Button_Save().Displayed)
                {
                    VerifyTextOnPageAndHighLight("Please enter title.");
                    Logger.WriteDebugMessage("'Please enter title.' Validation message displayed");
                }
                else
                    Assert.Fail("Validation message 'This tittle is already in use' is displayed");
                

            }
        }

        private static void D_221120()
        {
            if (TestCaseId == Constants.D_221120)
            {
                //retrive data from test data file
                string facebookTitleFromExcel = TestData.ExcelData.TestDataReader.ReadData(1, "FacebookTitleFromExcel");
                string twitterTitleFromExcel = TestData.ExcelData.TestDataReader.ReadData(1, "TwitterTitleFromExcel");
                string facebookUserNameusername = TestData.ExcelData.TestDataReader.ReadData(1, "FacebookUserNameusername");
                string facebookPassword = TestData.ExcelData.TestDataReader.ReadData(1, "FacebookPassword");
                string facebookTitleafterLoginFromExcel = TestData.ExcelData.TestDataReader.ReadData(1, "FacebookTitleafterLoginFromExcel");
                string twitterUsername = TestData.ExcelData.TestDataReader.ReadData(1, "TwitterUsername");
                string twitterPassword = TestData.ExcelData.TestDataReader.ReadData(1, "TwitterPassword");
                string twitterTitleafterLoginFromExcel = TestData.ExcelData.TestDataReader.ReadData(1, "TwitterTitleafterLoginFromExcel");
                string faceBookTitle = TestData.ExcelData.TestDataReader.ReadData(1, "FaceBookTitle");
                string twitterTitle = TestData.ExcelData.TestDataReader.ReadData(1, "TwitterTitle");
                Logger.WriteDebugMessage("Navigated to Frontend");
                string mainWindowTitle = Helper.Driver.Title;

                //2.scroll to the  bottom of page and observe link in footer
                Helper.ScrollDown();

                /*1.Navigate to Portal site

                2.Click on Join Now option
                */

                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_JoinNow();
                }
                else
                {
                    Navigation.Click_Button_JoinNow();
                }
                //3.Click on Twitter/ Google +/ Facebook icon
                //facebook
                SignUp.Navigate_To_Facebook_From_SignUp(mainWindowTitle, facebookTitleFromExcel);
                Logger.WriteDebugMessage("Verified that facebook link is opened in the new tab");
                SignUp.Enter_Facebook_UserName(facebookUserNameusername);
                SignUp.Enter_Facebook_Password(facebookPassword);
                SignUp.Click_Facebook_Signup_Login();
                //verify facebook home page
                //String titleAfterLoginToFacebook = Helper.Driver.Title;
                //Assert.AreEqual(facebookTitleafterLoginFromExcel, titleAfterLoginToFacebook);
                //Logger.WriteDebugMessage("Landed to Facebook Homepage");
                Helper.Driver.Close();
                //Twitter
                //ControlToPreviousWindow();
                //SignUp.Navigate_To_Twitter_From_SignUp(mainWindowTitle, twitterTitleFromExcel);
                //SignUp.Click_Authorise_App_Button();
                //SignUp.Enter_Twitter_UserName(twitterUsername);
                //SignUp.Enter_Twitter_Password(twitterPassword);
                //SignUp.Click_Twitter_Signup_Login();
                //String titleAfterLoginToTwitter = Helper.Driver.Title;
                //Assert.AreEqual(titleAfterLoginToTwitter, twitterTitleafterLoginFromExcel);
                //Helper.Driver.Close();
                //Logger.WriteDebugMessage("Verified that Twitter link is opened in the new tab");
            }
        }

        private static void D_221663()
        {
            if (TestCaseId == Constants.D_221663)
            {
                // Pre-requisites
                Users data = new Users();
                Random randomNumber = new Random();

                //retrive data from test data file
                string page, awardName, code, AwardType, pointValue, memberLevelText, emailText, couponName, marketingPartner, catalog, cardAmount, awardexpMonth, balance;
                string startDate = DateTime.Now.ToString("MM/dd/yyyy");
                string endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                Console.WriteLine(DateTime.Now.Millisecond);
                awardName = string.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "AwardName"), randomNumber.Next().ToString());
                code = string.Concat(DateTime.Now.Millisecond, DateTime.Now.Hour);
                AwardType = TestData.ExcelData.TestDataReader.ReadData(1, "AwardType");
                pointValue = TestData.ExcelData.TestDataReader.ReadData(1, "PointValue");
                memberLevelText = TestData.ExcelData.TestDataReader.ReadData(1, "MemberLevelText");
                emailText = TestData.ExcelData.TestDataReader.ReadData(1, "EmailText");
                couponName = string.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "CouponName"), randomNumber.Next().ToString());
                marketingPartner = TestData.ExcelData.TestDataReader.ReadData(1, "MarketingPartner");
                cardAmount = TestData.ExcelData.TestDataReader.ReadData(1, "CardAmount");
                catalog = TestData.ExcelData.TestDataReader.ReadData(1, "Catalog");
                awardexpMonth = TestData.ExcelData.TestDataReader.ReadData(1, "AwardExpMonth");
                balance = TestData.ExcelData.TestDataReader.ReadData(1, "Balance");
                Queries.GetMemberEmailWithSufficientBalance(data, balance);
                string userWithBalance = data.MemberEmail;
               
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                ElementWait(PageObject_Admin.Admin_Text_UserName(), 20);

                //1.Navigate to Admin Portal and login using Valid credentials
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                ElementWait(PageObject_Admin.Menu_LoyaltyAwards(), 20);
                page = Driver.Title;
                Logger.WriteDebugMessage("user landed on " + page + "page");
                Logger.LogTestData(TestPlanId, TestCaseId, "Award Name", awardName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Award Code", code);
                Logger.LogTestData(TestPlanId, TestCaseId, "Award Type", AwardType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Point Value", pointValue);
                Logger.LogTestData(TestPlanId, TestCaseId, "Email Text", emailText);
                Logger.LogTestData(TestPlanId, TestCaseId, "Coupon Name", couponName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Marketing Partner", marketingPartner);
                Logger.LogTestData(TestPlanId, TestCaseId, "Catalog", catalog);
                Logger.LogTestData(TestPlanId, TestCaseId, "Balance", balance);

                //2.Click on Loyalty Award >> Click on Add Award
                Admin.Click_Menu_LoyaltyAwards();
                ElementWait(PageObject_Admin.Admin_Button_Awards_Add(), 20);
                Admin.Click_Button_Awards_Add();
                Logger.WriteDebugMessage("Add Award Popup should be displayed");

                //3.Create an active point based award, as manual and check eGift checkbox.
                Admin.AddAward(awardName, code, startDate, endDate, AwardType);
                Admin.Click_Admin_Use_As_EGift();
                ElementWait(PageObject_Admin.Admin_Text_PointsCost(), 20);
                Admin.AddPointBasedAward(pointValue, memberLevelText, emailText, awardexpMonth);
                Admin.Click_Admin_AutomatedSwitch();
                Logger.WriteDebugMessage("All data should be get updated successfully");
             
                //click on save button
                Admin.Click_LoyaltyAwards_Button_Save();
                VerifyTextOnPage("Save Successfull");
                ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Text_Filter(), 20);
                Admin.LoyaltyAwards_Text_Filter(awardName);
                Logger.WriteDebugMessage("Points based award should be added");

                //4. Click on Loyalty eGift > Click on Add eGift
                Admin.Click_Menu_LoyaltyeGifts();
                ElementWait(PageObject_Admin.Admin_LoyaltyeGifts_Button_AddeGift(), 30);
                Admin.Click_Admin_LoyaltyeGifts_Button_AddeGift();
                Logger.WriteDebugMessage("Loyalty Add eGift popup should be displayed");

                //5.Add an eGift of amount $10 and link recently created award.
                Admin.Add_LoyaltyeGifts(couponName, marketingPartner, awardName, catalog, cardAmount);
                Logger.WriteDebugMessage("Loyalty eGift should be added successfully");
                //click on Add button
                Admin.Admin_LoyaltyeGifts_Button_Add();
                VerifyTextOnPage("Saved Successfully");
                ElementWait(PageObject_Admin.Menu_Home(), 20);

                //6.Select an active user and click on View button
                Admin.Click_Menu_Home();
                Admin.EnterEmail(userWithBalance);
                // search for member
                Admin.Click_Button_MemberSearch();

                //3.Click on view icon to see member information page
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User should get landed on Member Information page");

                //7.Click on Member Awards > Click on Add award
                //Admin.Click_Tab_MemberAwards();
                Admin.Click_MemberAwards_Button_AddAward();
                
                //8.Assign eGift award to user and send via email
                Admin.Dropdown_SelectAward(awardName);
                Admin.MemberAwards_Text_Comment(awardName);
                Admin.Click_MemberAwards_Button_Save();

                //9.Login using valid credentials and observe user have sufficient balance to redeem recently created award
                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                ElementWait(PageObject_SignIn.Text_Email(), 20);
                LoginCredentials(userWithBalance, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Email with Balance", userWithBalance, true);

                //10.Click on My Awards tab > Select recently issues award and click on Redeem button
                Navigation.Click_Link_MyAward();
                Helper.ScrollToElement(PageObject_Navigation.MyAwards_Text_Filter());
                Logger.WriteDebugMessage("Member Awards are getting Displayed");
                Navigation.MyAwards_Text_Filter(awardName);
                PageObject_Navigation.MyAwards_Text_Filter().SendKeys(Keys.Tab);
                Logger.WriteDebugMessage("Award got displayed on the My Award Page");
                Navigation.Click_MyAward_Redeem_Button();
                Logger.WriteDebugMessage("Award is ready for Reddem");


                //Login to Admin and Flip the Award status as off
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                ElementWait(PageObject_Admin.Menu_LoyaltyAwards(), 20);
                Admin.Click_Menu_LoyaltyAwards();
                Admin.LoyaltyAwards_Text_Filter(awardName);
                Logger.WriteDebugMessage("Award should be found");
                Admin.Click_LoyaltyAwards_Icon_Edit();
                Logger.WriteDebugMessage("Loyalty award popup should get display");
                Admin.Click_Admin_AwardStatusSwitch();
                Logger.WriteDebugMessage("Award Status button got switch off");
                Admin.Click_LoyaltyAwards_Button_Save();
                Logger.WriteDebugMessage("Award Status get switch off");
                Admin.LoyaltyAwards_Text_Filter(awardName);
                Logger.WriteDebugMessage("Award should be found");
            }
        }

        private static void D_221461()
        {
            if (TestCaseId == Constants.D_221461)
            {
                //retrive data from test data file
                string emailValidationerrorMsg = TestData.ExcelData.TestDataReader.ReadData(1, "EmailValidationerrorMsg");

                if (ProjectName.Equals("IndependentCollection"))
                {
                    SignIn.Click_Button_Next();
                }
                else
                {
                    SignIn.Click_Button_LogIn(ProjectName);
                }
                Logger.WriteDebugMessage("Clicked on Login button without entering an email ");
                Assert.AreEqual(emailValidationerrorMsg, GetText(PageObject_SignIn.SignIn_Email_Error_Message()));
                Logger.WriteDebugMessage("Error message validated");
            }
        }

        private static void D_221118()
        {
            if (TestCaseId == Constants.D_221118)
            {
                Users data = new Users();
                //1. Navigate to front end site
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                string faceBookTitle = TestData.ExcelData.TestDataReader.ReadData(1, "FaceBookTitle");                
                string twitterTitle = TestData.ExcelData.TestDataReader.ReadData(1, "TwitterTitle");
                Logger.WriteDebugMessage("Navigated to Frontend");
                string mainWindowTitle = Helper.Driver.Title;

                //2.scroll to the  bottom of page and observe link in footer
                Helper.ScrollDown();

                //3.Click on any of the link in the footer
                //verify facebook link is opened in new tab
                Navigation.Navigate_To_Facebook(mainWindowTitle, faceBookTitle);
                Logger.WriteDebugMessage("Verified that facebook link is opened in the new tab");
                Helper.Driver.Close();
                Helper.ControlToPreviousWindow();
                //verify twitter link is opened in new tab
                Navigation.Navigate_To_Twitter(mainWindowTitle, twitterTitle);
                Logger.WriteDebugMessage("Verified that Twitter link is opened in the new tab");
                Helper.Driver.Close();
                Helper.ControlToPreviousWindow();
            }
        }

        private static void D_221403()
        {
            if (TestCaseId == Constants.D_221403)
            {
                Users data = new Users();
                AdminVariable adminvariable = new AdminVariable();
                //1.Navigate to Admin site
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                ElementWait(PageObject_Admin.Admin_Text_UserName(), 20);

                //2.Log in with valid credentials
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                ElementWait(PageObject_Admin.Menu_LoyaltyAwards(), 20);

                //3.Click on Loyalty Award
                Admin.Click_Menu_LoyaltyAwards();
                ElementWait(PageObject_Admin.Menu_Home(), 20);

                //4.Check for the AwardName whose end date is past dated
                Queries.GetAwardWithPastDate(adminvariable);
                string awardWithPastDate = adminvariable.AwardName;
                //get the Email of the active user
                Queries.GetActiveMemberEmail(data);
                String activeMemberEmail = data.MemberEmail;
                //Go to Home page
                Admin.Click_Menu_Home();
                //search for the active membet
                Admin.SearchMember(activeMemberEmail);
                Admin.Click_Button_MemberSearch();

                //5.Go to Member Information
                //6.Click on Member Award >> Add Award
                Admin.ViewMemberSearch(ProjectName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Active Email", activeMemberEmail, true);
                Helper.ScrollToElement(PageObject_Admin.MemberAwards_Button_AddAward());
                Admin.Click_MemberAwards_Button_AddAward();
                ElementWait(PageObject_Admin.MemberAwards_Dropdown_SelectAward(), 20);

                //7.Notice that Admin user is able to see Award in Add Award dropdown though end date for that award is passed
                // PageObject_Admin.MemberAwards_Dropdown_SelectAward().
                SelectElement selectAll = new SelectElement(PageObject_Admin.MemberAwards_Dropdown_SelectAward());
                IList<IWebElement> allOptions = selectAll.Options;
                foreach (var item in allOptions)
                {
                    if (item.Text != awardWithPastDate)
                    {
                        Logger.WriteDebugMessage("The Admin User is not able to see the Award with past end date");
                    }
                    else
                    {
                        Logger.WriteDebugMessage("The Admin User is  able to see the Award with past end date");

                    }
                }

            }

        }
        #endregion

    }
}
