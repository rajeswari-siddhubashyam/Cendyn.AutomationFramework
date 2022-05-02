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

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        

        #region[TP_106791]
        public static void TC_68068()
        {
           
            Navigation.MenuNavigation("Profile");
            PageLoadWait(120, "Profile.mvc/Profile");
            Profile.SelectSubClient(companyNameByTestCase);

            Profile.ClickAddGuestsTab();
            WaitUntilElementNotVisible(By.XPath("//div[@id='AddGuestTab']//img[@alt='Please wait...']"), 30);
            Profile.ClickAddGuestSubTab(0);
            string sourceID = SqlWarehouseQuery.ReturnDataSourceID(companyNameByTestCase, "Jtest_QA_1008");
            Profile.UploadExistingSourceFile(sourceID);

            AddDelay(8000);
        }
        public static void TC_74653()
        {
           
            AnnonymizedData guestdata = new AnnonymizedData();

            Navigation.MenuNavigation("Profile");
            PageLoadWait(120, "Profile.mvc/Profile");
            Profile.SelectSubClient(companyNameByTestCase);

            Profile.ClickAddGuestsTab();
            Profile.ClickAddGuestSubTab(1);

            SqlWarehouseQuery.GetDummyData(guestdata);
            Profile.InsertGuestData(guestdata);
            SqlWarehouseQuery.UpdateUsedguestData(guestdata.ID);
        }
        public static void TC_80078()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ProjectID");
            ResendCampaignData stayData = new ResendCampaignData();
            Navigation.MenuNavigation("Profile");
            
            SqlWarehouseQuery.GetReservationNumber(companyNameByTestCase, stayData, "Profile", projectID);
            Profile.SelectSubClient(stayData.PropertyName);
            Logger.WriteInfoMessage("Fetched data" + stayData.CampaignName + ",\n " + stayData.CustomerID + ",\n " + stayData.EmailAddress + ",\n " + stayData.ReservationNumber);
            PageLoadWait(120, "Profile.mvc/Profile");
            ElementWait(PageObject_Profile.Profile_SearchGuestsSearch(), 120);
            Profile.SelectSearchGuestsSearchBy("Reservation #");
            Profile.InsertTextSearchGuestsSearchFor(stayData.ReservationNumber);
            Logger.WriteDebugMessage("Searching for an customer for a reservation number : " + stayData.ReservationNumber + " on profile search page.");
            Profile.ClickOpenProfile(stayData.CustomerID, stayData.PrimaryCustomer);
            
            ScrollToElement(PageObject_Profile.Profile_CustomerProfileImage());

            ElementClick(PageObject_Profile.Profile_StayTab(stayData.PrimaryCustomer));
            AddDelay(60000);
            ScrollToElement(PageObject_Profile.Profile_StayTab(stayData.PrimaryCustomer));
            PageDown();
            Profile.Select_StayPage_NumofRows(stayData.PrimaryCustomer, "500");
            AddDelay(25000);
            Profile.OpenandSendResend(stayData.ReservationNumber, stayData.CampaignName, "", "Stay", stayData.ParentProjectID);
            AddDelay(15000);

            if (stayData.CampaignSubject == "#EMAIL#, ")
            {
                stayData.CampaignSubject = stayData.CampaignSubject.Replace("#EMAIL#, ", "");
            }

            Login.AutoAcc_login(stayData.CampaignSubject, 2, 1, LegacyTestData.CommonCatchallURL, 0);
        }
        public static void TC_80080()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ProjectID");
            ResendCampaignData stayData = new ResendCampaignData();
            Navigation.MenuNavigation("Profile");
            
            SqlWarehouseQuery.GetReservationNumber(companyNameByTestCase, stayData, "Profile", projectID);
            
            Profile.SelectSubClient(stayData.PropertyName);
            
            PageLoadWait(120, "Profile.mvc/Profile");
            ElementWait(PageObject_Profile.Profile_SearchGuestsSearch(), 120);
            
            Profile.SelectSearchGuestsSearchBy("Reservation #");
            Profile.InsertTextSearchGuestsSearchFor(stayData.ReservationNumber);
            Logger.WriteDebugMessage("Searching for an customer for a reservation number : " + stayData.ReservationNumber + " on profile search page.");
            Profile.ClickOpenProfile(stayData.CustomerID, stayData.PrimaryCustomer);
            
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '#emailCampaignsHistory-div" + stayData.PrimaryCustomer + "')]")));
            AddDelay(60000);
            ScrollToElement(PageObject_Profile.Profile_CustomerProfileImage());
            ElementClick(PageObject_Profile.Profile_Grid_CampaignHistory_NumberofRows(stayData.PrimaryCustomer, "500"));
            ManageCampaign.WaitForReady();
            ScrollDownUsingJavaScript(Driver, -500);
            ElementClick(Driver.FindElement(By.XPath("//td[@title='"+ stayData.CampaignName +"']//preceding::a[contains(text(), 'RESENT')]")));
            
            if(VerifyTextOnPage("Preview"))
            {
                Logger.WriteDebugMessage("Landed on Preview Template");
            }
            else
            {
                Assert.Fail("Did not land on Preview page for campaignName - " +  stayData.CampaignName);
            }
            
        }
        public static void TC_63959()
        {
           
            string projectID = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ProjectID");
            /*Starting of Prerequisite*/

            CampaignDetails details = new CampaignDetails();
            SqlWarehouseQuery.GetResendCampaignStatus(details, projectID, companyNameByTestCase);
            if((details.ResendSaveCheck == "1") && (details.OldStatus == "Scheduled"))
            {
                Logger.WriteDebugMessage(details.ParentProjectID + " is scheduled and Saved as Resend");
            }
            else
            {
                if (details.ResendSaveCheck != "1")
                {
                    Assert.Fail("Campaign - " + projectID + " was not Saved as Resend.");
                }

                else if (details.OldStatus != "Scheduled")
                {
                    Assert.Fail("Campaign - " + projectID + " was not scheduled.");
                }
            }
            /*Starting of Prerequisite*/

            
            ResendCampaignData stayData = new ResendCampaignData();
            Profile.SelectSubClient(companyNameByTestCase);
            Navigation.MenuNavigation("Profile");
            
            SqlWarehouseQuery.GetReservationNumber(companyNameByTestCase, stayData, "Profile", projectID);
            
            Logger.WriteInfoMessage("Fetched data" + stayData.CampaignName + ",\n " + stayData.CustomerID + ",\n " + stayData.EmailAddress + ",\n " + stayData.ReservationNumber);
            PageLoadWait(120, "Profile.mvc/Profile");
            
            ElementWait(PageObject_Profile.Profile_SearchGuestsSearch(), 120);
            Profile.SelectSearchGuestsSearchBy("Reservation #");
            Profile.InsertTextSearchGuestsSearchFor(stayData.ReservationNumber);
            Logger.WriteDebugMessage("Searching for an customer for a reservation number : " + stayData.ReservationNumber + " on profile search page.");
            ElementWait(PageObject_Profile.Profile_Grid_ReservationNumber(stayData.ReservationNumber), 120);

            Profile.OpenandSendResend(stayData.ReservationNumber, stayData.CampaignName, "", "Profile", stayData.ParentProjectID);
            AddDelay(15000);
            if (stayData.CampaignSubject.Contains("#EMAIL#"))
            {
                stayData.CampaignSubject = stayData.CampaignSubject.Replace("#EMAIL#, ", "");
            }
            Login.AutoAcc_logins(stayData.CampaignSubject, 2, 0, LegacyTestData.CommonCatchallURL, 1);
        }
        public static void TC_95717()
        {
            ResendCampaignData stayData = new ResendCampaignData();
            SqlWarehouseQuery.GetReservationNumber(companyNameByTestCase, stayData, "Profile");
            Profile.SelectSubClient(companyNameByTestCase);
            Navigation.MenuNavigation("Profile");
            //Profile.SelectSubClient(stayData.PropertyName);

            Navigation.Click_Link_Settings();
            Settings.EnableDisableMergeGuest(1);
            Navigation.MenuNavigation("Profile");
            Logger.WriteDebugMessage("Merge Guest Tab does not exist.");
            Navigation.Click_Link_Settings();
            Settings.EnableDisableMergeGuest(0);
            Navigation.MenuNavigation("Profile");
            Logger.WriteDebugMessage("Merge Guest Tab does exist.");
        }
        #endregion[TP_106791]

    }
}
