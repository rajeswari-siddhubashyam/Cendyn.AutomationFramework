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
using System;
using System.Text.RegularExpressions;

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_86434]
        public static void TC_80235()
        {
            Users CustData = new Users();
            Navigation.MenuNavigation("Profile");
            Profile.SelectSubClient(companyNameByTestCase);
            Logger.WriteDebugMessage("Selected Company " + companyNameByTestCase);
            SqlWarehouseQuery.GetCustomerCampaignHistoryData(CustData, companyNameByTestCase, "GetRandomReservation");
            Profile.SelectSearchGuestsSearchBy("Customer ID");
            Profile.InsertTextSearchGuestsSearchFor(CustData.CustomerID);
            Logger.WriteDebugMessage("Searching for an Email Address: " + CustData.Email + " in profile search page.");
            Profile.ClickOpenProfile(CustData.CustomerID);
            AddDelay(8000);
            Profile.ClickProfileCampaignHistory(CustData.ChildProjectID, CustData.CustomerID);
            Profile.Select_CampaignHistory_NumofRows(CustData.CustomerID, "500");
            Profile.VerifyCampaignHistoryData(CustData);
        }
        public static void TC_80287()
        {
        }
        #endregion[TP_86434]

    }
}