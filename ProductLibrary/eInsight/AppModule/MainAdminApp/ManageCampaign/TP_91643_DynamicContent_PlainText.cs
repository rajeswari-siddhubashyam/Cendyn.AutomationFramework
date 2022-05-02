using System;
using eInsight.Utility;
using eInsight.AppModule.UI;
using Common;
using Constants = eInsight.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using BaseUtility.Utility.Hotmail;
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
        public static void TC_89923()
        {
            string projectID = SqlWarehouseQuery.ReturnCompanyName("", "ProjectID", TestPlanId);
            Users pData = new Users();

            SqlWarehouseQuery.UpdateProjectStatus(Convert.ToInt32(projectID));
            Logger.WriteInfoMessage("Change campaign status to Draft.");

            Navigation.MenuNavigation("ManageCampaign");
            Logger.WriteDebugMessage("Navigated to Manage Campaign for ProjectID - " + projectID);

            SqlWarehouseQuery.GetPersonalizedTagValue(pData, CompanyName, 0,"", projectID,"");
            Logger.WriteInfoMessage("Found CustomerID - " + pData.CustomerIDs + " and Reservation Number - " + pData.ReservationNumber);
            SqlWarehouseQuery.GetPersonalizedTagValue(pData, CompanyName, 1, "", projectID, pData.CustomerIDs);
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Details");
            ManageCampaign.CampaignDetails_TabActions("Audience", projectID, "CustomerDetails");
            ManageCampaign.SearchCustomer("Reservation", pData.ReservationNumber);
            /* Preview */
            Logger.WriteInfoMessage("Started Preview");
            ManageCampaign.CustomerDetailEllipse_PreviewQuickSend("Preview");
            ManageCampaign.VerifyPersonalizeData(pData, 3, CompanyName, pData.CustomerIDs, "Preview", Int32.Parse(projectID), "Close");
            Logger.WriteInfoMessage("View in Browser is only available in QuickSend and Scheduling. Switching to Quick Send");

            /* Nagivate Back to inital frame*/
            Driver.SwitchTo().ParentFrame();
            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(iFrameManageCampaign)));

            /* Quick Send */

            Logger.WriteInfoMessage("Started Quick Send");

            //42164904-1 | 1/1/2020 - 1/3/2020
            DateTime Date = DateTime.Parse(pData.ArrivalDate);
            string arrivalDate = Date.ToString("M/d/yyyy");
            Date = DateTime.Parse(pData.DepartureDate);
            string depatureDate = Date.ToString("M/d/yyyy");
            string resxPath = pData.ReservationNumber + " | " + arrivalDate + " - " + depatureDate;
            ManageCampaign.CustomerDetailEllipse_PreviewQuickSend("QuickSend");
            ManageCampaign.Customer_Send_QuickSend(pData.CustomerIDs, pData.ReservationNumber, resxPath);
            //ManageCampaign.CASL_QuickSendVerification(pData.CustomerIDs, 1, pData.Email,pData.ReservationNumber, resxPath);
            OpenNewTab();
            ControlToNewWindow();
            Login.AutoAcc_login(projectID, 2, 0, LegacyTestData.CommonCatchallURL, 0);
            ManageCampaign.VerifyPersonalizeData(pData, 3, CompanyName, pData.CustomerIDs, "Schedule", Int32.Parse(projectID));
            ManageCampaign.ViewinBrowser(Int32.Parse(projectID));
            ControlToNewWindow();
            ManageCampaign.VerifyPersonalizeData(pData, 3, CompanyName, pData.CustomerIDs, "Schedule", Int32.Parse(projectID));
            CloseCurrentTab();
            ControlToNewWindow();
            Hotmail.OutlookSignOut();
            CloseCurrentTab();
            ControlToPreviousWindow();
            /* Scheduling */
            Logger.WriteInfoMessage("\nContinuing by Scheduling Campaign\n");
            Navigation.MenuNavigation("ManageCampaign");
            AddDelay(5000);
            Driver.SwitchTo().ParentFrame();
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
            //ManageCampaign.PreSearchCampaign(1, Int32.Parse(projectID), CompanyName, clientName);
            ManageCampaign.ManageCampaign_EllipseButton("Edit");
            AddDelay(15000);
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 60);
            Logger.WriteDebugMessage("Landed on Testing Tab.");
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            ElementWait(Driver.FindElement(By.XPath("//*[@id='SendToTestEmails" + projectID + "']")), 60);
            Logger.WriteDebugMessage("Landed on Approval Tab.");
            CreateCampaign.Click_Button_SendforApproval();
            CreateCampaign.CampaignApprove(Int32.Parse(projectID));
            CreateCampaign.CreateCampaign_Button_Continue();
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab(), 60);
            Logger.WriteDebugMessage("Landed on Schedule Page");
            CreateCampaign.SelectTime();
            CreateCampaign.CampaignScheduleandComplete("Schedule");
            AddDelay(450000);
            OpenNewTab();
            ControlToNewWindow();
            Login.AutoAcc_login(pData.Email, 1, 0, LegacyTestData.CommonCatchallURL, 0);
            ManageCampaign.VerifyPersonalizeData(pData, 3, CompanyName, pData.CustomerIDs, "Schedule", Int32.Parse(projectID));
            ManageCampaign.ViewinBrowser(Int32.Parse(projectID));
            ControlToNewWindow();
            ManageCampaign.VerifyPersonalizeData(pData, 3, CompanyName, pData.CustomerIDs, "Schedule", Int32.Parse(projectID));            
        }
    }
}
