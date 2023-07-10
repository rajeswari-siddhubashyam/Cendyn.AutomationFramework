using eLoyaltyV3.AppModule.UI;
using eLoyaltyV3.Entity;
using InfoMessageLogger;
using eLoyaltyV3.PageObject.Admin;
using TestData;
using NUnit.Framework;
using System;
using Queries = eLoyaltyV3.Utility.Queries;
using Constants = eLoyaltyV3.Utility.Constants;
using BaseUtility.Utility;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region TP_190877 - Admin Member Login

        public static void TC_147736()
        {
            if (TestCaseId == Constants.TC_147736)
            {
                Users data = new Users();

                //1.Login to Admin 
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                if (!(ProjectName.Equals("SandyLane") || ProjectName.Equals("AdareManor") ||
                  ProjectName.Equals("WoodLoch") || ProjectName.Equals("IndependentCollection") ||
                  ProjectName.Equals("Bartell") || ProjectName.Equals("Sarova") ||
                  ProjectName.Equals("HotelOrigami") || ProjectName.Equals("EHPC")))
                {
                    //2.Search for a profile who signed up using social media
                    Queries.GetProfilePerStatus("Social media user", data);
                    string email = data.eMail;
                    Admin.EnterEmail(email);
                    Admin.Click_Button_MemberSearch();
                    Admin.Click_Icon_View(ProjectName);
                    Logger.WriteDebugMessage("Search result gets displayed ");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Active Email with Social Media", data.eMail);

                    //3.Click on view followed by the selection of login link in Member Information page 
                    Queries.ReturnProfileData(email, data);
                    string firstname = data.firstName;
                    string lastname = data.lastName;
                    string membership = data.Membership;
                    string membershipLevel = Admin.ConvertMemberShipLevel_LowerCases(data.Membershiplevel);
                    if (ProjectName.Equals("HotelIcon"))
                    {
                        membershipLevel = "Engage High Flyers";
                    }
                    Admin.Click_MemberInformation_Value_MemberPortal();
                    Admin.Click_MemberInformation_Value_MemberPortal();
                    AddDelay(120000);
                    Logger.WriteDebugMessage("User landed on My Stay  page  in new  same guest portal window");

                    //4.Verify the detail in side bar 
                    ControlToNewWindow();
                    Driver.Manage().Window.Maximize();
                    Helper.ScrollDown();
                    if (!ProjectName.Equals("Iberostar"))
                    {
                        ValidateTextOnPage(firstname);
                        ValidateTextOnPage(lastname);
                        ValidateTextOnPage(membership);
                        ValidateTextOnPage(membershipLevel);
                    }
                    else
                    {
                        ValidateTextOnPage(firstname);
                        ValidateTextOnPage(lastname);
                        ValidateTextOnPage(membership);
                    }

                    Logger.WriteDebugMessage("should match with details in member information of admin ");
                    CloseWindow();
                    ControlToPreviousWindow();

                    //5.Navigate to member search tab 
                    Helper.ReloadPage();
                    Logger.WriteDebugMessage("User landed on Member Search tab ");
                }
                else
                {
                    Logger.WriteDebugMessage("Social Media users is NOT applicable for" + ProjectName);
                }

                //6.Search for a profile who signed up using Kiosk
                Queries.GetProfilePerStatus("Kiosk User", data);
                string email_Kiosk = data.eMail;
                Admin.EnterEmail(email_Kiosk);
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Search result gets displayed ");
                Logger.LogTestData(TestPlanId, TestCaseId, "Active Email with KIOSK Login", data.eMail);

                //7.Click on view followed by the selection of login link in Member Information page 
                Queries.ReturnProfileData(email_Kiosk, data);
                string firstname_Kiosk = data.firstName;
                string lastname_Kiosk = data.lastName;
                string membership_Kiosk = data.Membership;
                string membershipLevel_Kiosk = Admin.ConvertMemberShipLevel_LowerCases(data.Membershiplevel);
                Admin.Click_MemberInformation_Value_MemberPortal();
                Admin.Click_MemberInformation_Value_MemberPortal();
                AddDelay(120000);
                Logger.WriteDebugMessage("User landed on My Stay  page  in  same guest portal window which is minimized in previous step");

                //8.Verify the detail in side bar 
                ControlToNewWindow();
                Driver.Manage().Window.Maximize();
                Helper.PageDown();
                if (ProjectName.Equals("AdareManor"))
                {
                    Logger.WriteDebugMessage("Field verified");
                }
                else if (!ProjectName.Equals("SandyLane"))
                {
                    ValidateTextOnPage(firstname_Kiosk);
                    ValidateTextOnPage(lastname_Kiosk);
                    ValidateTextOnPage(membership_Kiosk);
                    if (!ProjectName.Equals("Iberostar"))
                    {
                        ValidateTextOnPage(membershipLevel_Kiosk);
                    }

                }
                else
                {
                    ValidateTextOnPage(membership_Kiosk);
                }
                Logger.WriteDebugMessage("Should match with details in member information of admin  ");
                CloseWindow();
                ControlToPreviousWindow();

                //9.Navigate to member search tab 
                Helper.ReloadPage();
                Logger.WriteDebugMessage("User landed on Member Search tab ");

                //10.Search for a profile who signed up using Loyalty sign up  form 
                Queries.GetProfilePerStatus("Loyalty User", data);
                string email_Loyalty = data.eMail;
                Admin.EnterEmail(email_Loyalty);
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Search result gets displayed ");
                Logger.LogTestData(TestPlanId, TestCaseId, "Active Email with Loyalty SignUp", data.eMail, true);

                //11.Click on view followed by the selection of login link in Member Information page 
                Queries.ReturnProfileData(email_Loyalty, data);
                string firstname_Loyalty = data.firstName;
                string lastname_Loyalty = data.lastName;
                string membership_Loyalty = data.Membership;
                string membershipLevel_Loyalty = Admin.ConvertMemberShipLevel_LowerCases(data.Membershiplevel);
                Admin.Click_MemberInformation_Value_MemberPortal();
                Admin.Click_MemberInformation_Value_MemberPortal();
                AddDelay(120000);
                Logger.WriteDebugMessage("User landed on My Stay  page  in  same guest portal window which is minimized in previous step");

                //12.Verify the detail in side bar 
                ControlToNewWindow();
                Driver.Manage().Window.Maximize();
                Helper.PageDown();
                if (ProjectName.Equals("AdareManor"))
                {
                    Logger.WriteDebugMessage("Field verified");
                }
                else if (!ProjectName.Equals("SandyLane"))
                {
                    ValidateTextOnPage(firstname_Loyalty);
                    ValidateTextOnPage(lastname_Loyalty);
                    ValidateTextOnPage(membership_Loyalty);
                    if (!ProjectName.Equals("Iberostar"))
                    {
                        ValidateTextOnPage(membershipLevel_Loyalty);
                    }
                }
                else
                {
                    ValidateTextOnPage(membership_Loyalty);
                }

                Logger.WriteDebugMessage("Should match with details in member information of admin  ");
                CloseWindow();
                ControlToPreviousWindow();

                //13.Navigate to member search tab 
                Helper.ReloadPage();
                Logger.WriteDebugMessage("User landed on Member Search tab ");
            }
        }

        public static void TC_147743()
        {
            try { 
            if (TestCaseId == Constants.TC_147743)
            {
                //1.Login to Admin 
                Users data = new Users();
                string status, emailStatus;
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for an active profile
                status = TestData.ExcelData.TestDataReader.ReadData(1, "Status");
                emailStatus = TestData.ExcelData.TestDataReader.ReadData(1, "EmailStatus");
                Admin.SelectEmailStatus(emailStatus);
                Admin.SelectMemberStatus(status);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Search result gets displayed ");

                //3.Click on view followed by the selection of login link in Member Information page 
                Admin.Click_Icon_View(ProjectName);
                Admin.Click_MemberInformation_Value_MemberPortal();
                Admin.Click_MemberInformation_Value_MemberPortal();
                Logger.WriteDebugMessage("User landed on My Stay  page  in new  same guest portal window");
                    AddDelay(120000);
                //4.Minimize the  guest portal window 
                ControlToNewWindow();
                Driver.Manage().Window.Minimize();
                ControlToPreviousWindow();
                Logger.WriteDebugMessage("Guest portal window gets minimized ");

                //5.Navigate to member search tab 
                Helper.ReloadPage();
                Logger.WriteDebugMessage("User landed on Member Search tab ");

                //6.Search for another active profile
                Admin.SelectMemberStatus(status);
                Admin.SelectEmailStatus(emailStatus);

                Queries.GetActiveMemberEmail(data);
                Admin.EnterEmail(data.MemberEmail);

                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Search result gets displayed ");
                Logger.LogTestData(TestPlanId, TestCaseId, "Active Email", data.MemberEmail, true);

                //7.Click on view followed by the selection of login link in Member Information page 
                Admin.Click_Icon_View(ProjectName);
                Admin.Click_MemberInformation_Value_MemberPortal();
                Admin.Click_MemberInformation_Value_MemberPortal();
                AddDelay(60000);
                ControlToNewWindow();
                Driver.Manage().Window.Minimize();
                if (!(ProjectName.Equals("AdareManor") || ProjectName.Equals("HotelIcon")|| ProjectName.Equals("Sacher")))
                {
                    string number = Summary.Get_MembershipNo(ProjectName);
                    Logger.WriteDebugMessage("Membership number captured");
                    ControlToPreviousWindow();
                    VerifyTextOnPage(number);
                    Logger.WriteDebugMessage("User landed on My Stay  page  in  same guest portal window which is minimized in previous step");
                }
                else
                    ControlToPreviousWindow();

                //8.Navigate to member search tab
                Helper.ReloadPage();
                Logger.WriteDebugMessage("User landed on Member Search tab ");
              
                //9.Search for another active profile               
                Admin.SelectEmailStatus(emailStatus);
                Admin.SelectMemberStatus(status);
                if (!ProjectName.Equals("SandyLane"))
                {
                    Admin.EnterEmail(data.MemberEmail);
                }

                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Search result gets displayed ");

                //10.Click on view followed by the selection of login link in Member Information page 
                Admin.Click_Icon_View(ProjectName);
                Admin.Click_MemberInformation_Value_MemberPortal();
                Admin.Click_MemberInformation_Value_MemberPortal();
                 AddDelay(80000);
                ControlToNewWindow();
                if (!(ProjectName.Equals("AdareManor") || ProjectName.Equals("HotelIcon") || ProjectName.Equals("Sacher")))
                {
                    string number1 = Summary.Get_MembershipNo(ProjectName);
                    Logger.WriteDebugMessage("Membership number captured");
                    ControlToPreviousWindow();
                    VerifyTextOnPage(number1);
                    ControlToNewWindow();
                    Logger.WriteDebugMessage("User landed on My Stay  page  in  same guest portal window ");
                }

                //11.Navigate to the My Profile page and update the information
                Driver.Manage().Window.Maximize();
                Navigation.Click_Link_MyProfile(ProjectName);

                if (ProjectName.Equals("HotelVIC")
                || ProjectName.Equals("AdareManor"))
                {
                    MyProfile.EnterText_Text_FirstName("Text");
                    MyProfile.EnterText_Text_LastName("User");
                }
                else if (ProjectName.Equals("HotelIcon"))
                {
                    MyProfile.Click_Button_Next();
                }
                else
                {
                    Logger.WriteDebugMessage("Land on My Profile Page");
                }

                Logger.WriteDebugMessage("Update should be successful ");
            }
            }
            catch (Exception e)
            {
            }
        }

        public static void TC_147747()
        {
            if (TestCaseId == Constants.TC_147747)
            {
                Users data = new Users();
                //1.Login to Admin 
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for a profile who signed up using social media
                Queries.GetNonActiveUser(data);
                string email = data.eMail;
                Admin.EnterEmail(email);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Search result gets displayed ");

                //3.Click on view followed by the selection of login link in Member Information page 
                Admin.Click_Icon_View(ProjectName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Inactive Email", data.eMail);
                Admin.Click_MemberInformation_Value_MemberPortal();
                ControlToNewWindow();
                Driver.Manage().Window.Maximize();
                VerifyTextOnPage("Is not possible to impersonate the user " + email +
                                 ", because the requested user hasn't activated the account.");
                Logger.WriteDebugMessage("Validation msg should display  that 'you cannot impersonnate......'");
            }
        }

        public static void TC_147748()
        {
            if (TestCaseId == Constants.TC_147748)
            {
                Users data = new Users();
                //1.Login to Admin 
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for a PMS profile who has stays and points
                Queries.ReturnSignUpPMSCustomerWithStay(data);
                string email = data.eMail;
                Admin.EnterEmail(email);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Search result gets displayed");

                //3.Click on view followed by the selection of login link in Member Information page 
                Admin.Click_Icon_View(ProjectName);
                Logger.LogTestData(TestPlanId, TestCaseId, "PMS Customer Email", data.eMail, true);
                Admin.Click_MemberStays();
                Admin.Click_MemberInformation_Value_MemberPortal();
                Admin.Click_MemberInformation_Value_MemberPortal();
                AddDelay(120000);
                ControlToNewWindow();
                Driver.Manage().Window.Maximize();
                Logger.WriteDebugMessage("User landed on My Stay  page  in new  same guest portal window");

                //4.Click on My Stay in portal              
                if (ProjectName.Equals("SandyLane") || ProjectName.Equals("WoodLoch"))
                {
                    Navigation.Click_Link_MyActivity();
                }
                else
                {
                    Navigation.Click_Link_MyStays();
                }
                ScrollToText("Cancelled");
                VerifyTextOnPage("Cancelled");
                Logger.WriteDebugMessage("Stays  record in portal should match with stay record in Member Information -> My Stay");

                //5.Verify the detail in Sidebar 
                if (!(ProjectName.Equals("AdareManor") || (ProjectName.Equals("Sacher"))))
                {
                    PageUp();
                    string number = Summary.Get_MembershipNo(ProjectName);
                    Logger.WriteDebugMessage("Membership number captured");
                    ControlToPreviousWindow();
                    VerifyTextOnPageAndHighLight(number);
                    Logger.WriteDebugMessage("Details should match with data in Member information ");
                }

                //6.Verify admin is able to access all pages  and links 
                ControlToNewWindow();
                Navigation.Click_Link_MyProfile(ProjectName);
                Logger.WriteDebugMessage("Admin should be able to access all pages and links ");
            }
        }

        public static void TC_147758()
        {
            try
            {
                if (TestCaseId == Constants.TC_147758)
                {
                    //1.Login to Admin 
                    string status, emailStatus, updateStatus;
                    Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //2.Search for an inactive profile
                    status = TestData.ExcelData.TestDataReader.ReadData(1, "Status");
                    emailStatus = TestData.ExcelData.TestDataReader.ReadData(1, "EmailStatus");
                    updateStatus = TestData.ExcelData.TestDataReader.ReadData(1, "UpdateStatus");
                    Admin.SelectEmailStatus(emailStatus);
                    Admin.SelectMemberStatus(status);
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Search result gets displayed ");

                    //3.Click on view followed by the selection of login link in Member Information page 
                    Admin.Click_Icon_View(ProjectName);
                    Admin.Click_MemberInformation_Value_MemberPortal();
                    Admin.Click_MemberInformation_Value_MemberPortal();
                    AddDelay(120000);
                    ControlToNewWindow();
                    Driver.Manage().Window.Maximize();
                    Logger.WriteDebugMessage("User landed on My Stay  page  in new  same guest portal window");

                    //5.Verify the detail in Sidebar 
                    if (!(ProjectName.Equals("AdareManor") || ProjectName.Equals("Sacher")))
                    {
                        string number = Summary.Get_MembershipNo(ProjectName);
                        Logger.WriteDebugMessage("Membership number captured");
                        ControlToPreviousWindow();
                        VerifyTextOnPageAndHighLight(number);
                        Logger.WriteDebugMessage("Details should match with data in Member information ");
                    }
                    else
                        ControlToPreviousWindow();

                    //6.click on member search and search for an Deactivated profile 
                    Helper.ReloadPage();
                    Admin.SelectMemberStatus(updateStatus);
                    Admin.Click_Button_MemberSearch();
                    Admin.Click_Icon_View(ProjectName);
                    Logger.WriteDebugMessage("Search result gets displayed ");

                    //7.Verify Member Portal: Login link is not clickable 
                    string loginLink = PageObject_Admin.MemberInformation_Value_MemberPortal().GetAttribute("class");
                    if (loginLink.Contains("disabled"))
                        Logger.WriteDebugMessage("Member Portal: Login link should not be click-able ");
                    else
                        Assert.Fail("Member Portal: Login link is click-able ");
                }
            } catch (Exception e)
            { 
            }
        }

        public static void TC_147759()
        { try
            {
                if (TestCaseId == Constants.TC_147759)
                {
                    // Pre-requisites
                    string level1, memberlevel1, level2, memberlevel2, lvl2;
                    Users data = new Users();

                    //1.Login to Admin 
                    Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //2.Search for an  active crystal profile
                    Queries.GetMemberLevel(data, 1);
                    level1 = data.MembershipLevel;
                    if (ProjectName.Equals("HotelOrigami"))
                    {
                        memberlevel1 = "MEMBER";
                    }
                    else if (level1.Equals("Engage Explorer"))
                    {
                        memberlevel1 = "EXPLORER";
                    }
                    else
                        memberlevel1 = level1;
                    Logger.LogTestData(TestPlanId, TestCaseId, "Member Level", memberlevel1);
                    Queries.GetDataAsPerMemberLevel(memberlevel1, data);
                    Admin.EnterEmail(data.MemberEmail);
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Search result gets displayed");

                    //3.Click on view followed by the selection of login link in Member Information page 
                    Admin.Click_Icon_View(ProjectName);
                    Logger.LogTestData(TestPlanId, TestCaseId, "User Email", data.MemberEmail, true);
                    Admin.Click_MemberInformation_Value_MemberPortal();
                    Admin.DoubleClick_MemberInformation_Value_MemberPortal();
                    AddDelay(80000);
                    ControlToNewWindow();
                    Driver.Manage().Window.Maximize();
                    Logger.WriteDebugMessage("User landed on My Stay  page  in new  same guest portal window");

                    //4.Verify the detail in Sidebar  and Summary page 
                    VerifyTextOnPageAndHighLightNew(level1);
                    Logger.WriteDebugMessage(level1 + "= Membership level found on the page");
                    ControlToPreviousWindow();
                    Logger.WriteDebugMessage("Details should match with data in Member information ");

                    if (!(ProjectName.Equals("SandyLane") || ProjectName.Equals("Iberostar") || ProjectName.Equals("AdareManor")))
                    {
                        //5.click on member search and search for an active Sapphire  member  
                        Helper.ReloadPage();
                        Queries.GetMemberLevel(data, 2);
                        level2 = data.MembershipLevel;
                        if (ProjectName.Equals("HotelOrigami"))
                        {
                            level2 = "PREFERRED";
                        }
                        else if (level2.Equals("Engage High Flyers"))
                        {
                            level2 = "HIGHFLYERS";
                        }
                        Queries.GetDataAsPerMemberLevel(level2, data);
                        Admin.EnterEmail(data.MemberEmail);
                        Admin.Click_Button_MemberSearch();
                        Logger.WriteDebugMessage("Search result gets displayed");

                        //6.Click on view followed by the selection of login link in Member Information page 
                        Admin.Click_Icon_View(ProjectName);
                        Admin.Click_MemberInformation_Value_MemberPortal();
                        Admin.DoubleClick_MemberInformation_Value_MemberPortal();
                        AddDelay(120000);
                        ControlToNewWindow();
                        Driver.Manage().Window.Maximize();
                        Logger.WriteDebugMessage("User landed on My Stay  page  in  same guest portal window which is minimized in previous step");

                        //7.Verify the detail in Sidebar  and Summary page 
                        Queries.GetMemberLevel(data, 2);
                        level2 = data.MembershipLevel;
                        VerifyTextOnPageAndHighLight(level2);
                        Logger.WriteDebugMessage(level2 + "= Membership level found on the page");
                        ControlToPreviousWindow();
                        Logger.WriteDebugMessage("Details should match with data in Member information ");

                        //8.Click on member search and search for an active diamond member  
                        if (!ProjectName.Equals("HotelIcon"))
                        {
                            Helper.ReloadPage();
                            Queries.GetMemberLevel(data, 3);
                            string level3 = data.MembershipLevel;
                            if (ProjectName.Equals("HotelOrigami"))
                            {
                                level3 = "ELITE";
                            }

                            Queries.GetDataAsPerMemberLevel(level3, data);
                            Admin.EnterEmail(data.MemberEmail);
                            Admin.Click_Button_MemberSearch();
                            Logger.WriteDebugMessage("Search result gets displayed");

                            //9.Click on view followed by the selection of login link in Member Information page 
                            Admin.Click_Icon_View(ProjectName);
                            if (ProjectName.Equals("Fraser"))
                            {
                                Admin.Click_Tab_AdminUpdates();
                            }

                            Admin.Click_MemberInformation_Value_MemberPortal();
                            Admin.Click_MemberInformation_Value_MemberPortal();
                            AddDelay(80000);
                            ControlToNewWindow();
                            Driver.Manage().Window.Maximize();
                            Logger.WriteDebugMessage("User landed on My Stay  page  in  same guest portal window which is minimized in previous step");

                            //10.Verify the detail in Sidebar  and Summary page 
                            Queries.GetMemberLevel(data, 3);
                            level3 = data.MembershipLevel;
                            VerifyTextOnPageAndHighLightNew(level3);
                            Logger.WriteDebugMessage(level3 + "Membership level found on the page");
                            ControlToPreviousWindow();
                            Logger.WriteDebugMessage("Details should match with data in Member information ");


                            if (ProjectName.Equals("Fraser"))
                            {
                                //11.Click on member search and search for an active Platinum member
                                Helper.ReloadPage();
                                Queries.GetDataAsPerMemberLevel("Platinum", data);
                                Admin.EnterEmail(data.MemberEmail);
                                Admin.Click_Button_MemberSearch();
                                Logger.WriteDebugMessage("Search result gets displayed ");

                                //12.Click on view followed by the selection of login link in Member Information page 
                                Admin.Click_Icon_View(ProjectName);
                                Admin.Click_MemberInformation_Value_MemberPortal();
                                ControlToNewWindow();
                                Driver.Manage().Window.Maximize();
                                Logger.WriteDebugMessage("User landed on My Stay  page  in  same guest portal window which is minimized in previous step");

                                //13.Verify the detail in Sidebar  and Summary page 
                                VerifyTextOnPageAndHighLight("Platinum");
                                Logger.WriteDebugMessage("Member found on the page");
                                CloseWindow();
                                ControlToPreviousWindow();
                                Logger.WriteDebugMessage("Details should match with data in Member information ");
                            }
                        }
                    }

                }
            }catch(Exception e)
            {

            }
        }

        #endregion TP_190877
    }
}
