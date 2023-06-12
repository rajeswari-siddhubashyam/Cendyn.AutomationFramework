using System;
using eInsight.Utility;
using eInsight.AppModule.UI;
using Common;
using Constants = eInsight.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using SqlWarehouse;
using OpenQA.Selenium;
using NUnit.Framework;
using eInsight.AppModule.UI;
using eInsight.PageObject.UI;
using System.Text.RegularExpressions;
using BaseUtility.Utility.Hotmail;

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_128226]
        public static void TC_128429()
        {
            string projectID = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ProjectID");
            string campaignSubject = "QAAutomation _Test (Do not touch) - " + projectID;
            ProfileCustData SData = new ProfileCustData();
            ElementWait(PageObject_Navigation.Profile(), 60);
            Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");
            SqlWarehouseQuery.GetDataForCASL(SData, companyNameByTestCase, Convert.ToInt32(projectID));
            Navigation.MenuNavigation("ManageCampaign");
            Logger.WriteDebugMessage("Landed on Manage Campaign Page for Property: " + companyNameByTestCase);
            ManageCampaign.PreSearchCampaign_New(companyNameByTestCase, "ProjectID", projectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Details");
            ManageCampaign.CampaignDetails_TabActions("Audience", projectID, "CustomerDetails");
            
            ManageCampaign.SearchCustomer("Email", SData.Email);
            ManageCampaign.CustomerDetailEllipse_PreviewQuickSend("QuickSend");
            //ManageCampaign.CASL_QuickSendVerification(SData.CustomerID, 2);
            DateTime Date = DateTime.Parse(SData.ArrivalDate);
            string arrivalDate = Date.ToString("M/d/yyyy");
            Date = DateTime.Parse(SData.DepartureDate);
            string depatureDate = Date.ToString("M/d/yyyy");
            string resxPath = SData.ReservationNumber + " | " + arrivalDate + " - " + depatureDate;
            ManageCampaign.Customer_Send_QuickSend(SData.CustomerIDs, SData.ReservationNumber, resxPath);
            AddDelay(30000);
            OpenNewTab();
            Login.AutoAcc_logins(campaignSubject, 2, 0, LegacyTestData.CommonCatchallURL, 1);
            if (VerifyTextOnPage(campaignSubject) == true)
            {
                Logger.WriteDebugMessage("Received Quick Send Email.");
            }
            else
            {
                Assert.Fail("Quick Send Email was not received.");
            }
            if (VerifyTextOnPage("CA") == true)
            {
                Logger.WriteDebugMessage("Country Code: CA is displayed on Email");
            }
            else
            {
                Assert.Fail("Quick Send Email was not received.");
            }
        }
        public static void TC_128430()
        {           
                string projectID = SqlWarehouseQuery.ReturnCompanyName("TC_128429", "ProjectID");
                ProfileCustData profDetails = new ProfileCustData();
                CampaignDetails campDetails = new CampaignDetails();
                Navigation.MenuNavigation("Profile");
                AddDelay(8000);

                //SqlWarehouseQuery.GetCASLReservationDetails(campaignDetails, CompanyName);
                SqlWarehouseQuery.GetCampaignDetails(campDetails, companyNameByTestCase, projectID);
                SqlWarehouseQuery.GetDataForCASL(profDetails, companyNameByTestCase, Convert.ToInt32(projectID));
                Profile.SelectSubClient(companyNameByTestCase);

                Logger.WriteInfoMessage("Fetched data" + campDetails.CampaignName + ",\n " + profDetails.CustomerIDs + ",\n " + profDetails.Email + ",\n " + profDetails.ReservationNumber);
                PageLoadWait(120, "Profile.mvc/Profile");
                ElementWait(PageObject_Profile.Profile_SearchGuestsSearchExpression(), 120);
                ElementWait(PageObject_Profile.Profile_SearchGuestsSearch(), 120);
                Profile.SelectSearchGuestsSearchBy("Reservation #");
                Profile.InsertTextSearchGuestsSearchFor(profDetails.ReservationNumber);
                AddDelay(60000);
                Logger.WriteDebugMessage("Searching for an customer for a reservation number : " + profDetails.ReservationNumber + " on profile search page.");
                ElementWait(Driver.FindElement(By.XPath("//a[contains(text(), '" + profDetails.ReservationNumber + "')]")), 120);

                Profile.OpenandSendResend(profDetails.ReservationNumber, campDetails.CampaignName, "", "Profile", projectID);
                AddDelay(15000);
                OpenNewTab();
                ControlToNewWindow();
                Login.AutoAcc_logins(campDetails.CampaignSubject, 2, 0, LegacyTestData.CommonCatchallURL, 1);
            
        }
        public static void TC_128432()
        {
                string projectID = SqlWarehouseQuery.ReturnCompanyName("TC_128429", "ProjectID");
                ProfileCustData profDetails = new ProfileCustData();
                CampaignDetails campDetails = new CampaignDetails();
                Navigation.MenuNavigation("Profile");
                AddDelay(8000);

                //SqlWarehouseQuery.GetCASLReservationDetails(campaignDetails, CompanyName);
                SqlWarehouseQuery.GetCampaignDetails(campDetails, companyNameByTestCase, projectID);
                SqlWarehouseQuery.GetDataForCASL(profDetails, companyNameByTestCase, Convert.ToInt32(projectID));
                Profile.SelectSubClient(companyNameByTestCase);

                Logger.WriteInfoMessage("Fetched data " + campDetails.CampaignName + ",\n " + profDetails.CustomerID + ",\n " + profDetails.Email + ",\n " + profDetails.ReservationNumber);
                PageLoadWait(120, "Profile.mvc/Profile");
                ElementWait(PageObject_Profile.Profile_SearchGuestsSearchExpression(), 120);
                ElementWait(PageObject_Profile.Profile_SearchGuestsSearch(), 120);
                Profile.SelectSearchGuestsSearchBy("Reservation #");
                Profile.InsertTextSearchGuestsSearchFor(profDetails.ReservationNumber);
                Logger.WriteDebugMessage("Searching for an customer for a reservation number : " + profDetails.ReservationNumber + " on profile search page.");
                AddDelay(10000);
                Profile.ClickOpenProfile(profDetails.CustomerIDs);
                AddDelay(10000);
                //ScrollToElement(Driver.FindElement(By.XPath("//div[contains(@class, 'user-picture')]")));
                ScrollToElement(PageObject_Profile.Profile_CustomerProfileImage());
                ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0,800)", "");
                if (VerifyTextOnPage("CA"))
                {
                    Logger.WriteDebugMessage("Found CountryCode: CA for CustomerID -  " + profDetails.CustomerIDs);
                    ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0,-1000)", "");
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '#stays-div" + profDetails.PrimaryCustomer + "')]")));
                    AddDelay(10000);
                    ScrollToElement(Driver.FindElement(By.XPath("//a[contains(@href, '#stays-div" + profDetails.PrimaryCustomer + "')]")));

                    Profile.OpenandSendResend(profDetails.ReservationNumber, campDetails.CampaignName, "", "Stay", projectID);
                    AddDelay(10000);
                    Login.AutoAcc_login(campDetails.CampaignSubject, 2, 1, LegacyTestData.CommonCatchallURL, 0);
                }
           
        }
        public static void TC_257224()
        {
            string projectID = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ProjectID");
            Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");
            Navigation.MenuNavigation("ManageCampaign");
            ManageCampaign.PreSearchCampaign_New(companyNameByTestCase, "ProjectID", projectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Details");
            AddDelay(8000);
            if (VerifyTextOnPage(projectID))
            {
                ManageCampaign.SendToTestEmail(projectID, 0);
                AddDelay(60000);
                OpenNewTab();
                ControlToNewWindow();
                Login.AutoAcc_login("", 2, 1, LegacyTestData.CommonCatchallURL, 0);

                AddDelay(8000);
                if (VerifyTextOnPage("CA") == true)
                {
                    Logger.WriteDebugMessage("Country Code: CA is displayed on Email");
                }
                else
                {
                    Assert.Fail("Send to Test Email was not received.");
                }
            }
        }
        #endregion[TP_128226]

    }
}
