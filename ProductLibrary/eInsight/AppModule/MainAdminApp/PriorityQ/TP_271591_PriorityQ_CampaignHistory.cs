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
        #region[TP_271591]
        public static void TC_264700()
        {
            int customerID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "CustomerID", TestPlanId));
            int sourceGuestID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "SourceGuestID", TestPlanId));
            int emailID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "EmailID", TestPlanId));

            //CompanyName = SqlWarehouseQuery.ReturnCompanyName("NA", "CompanyName", "TP_271591");
            Logger.WriteInfoMessage("/*----------PreRequisite--------*/");
            string result = setPrerequisite(CompanyName, customerID, sourceGuestID, emailID, 1);

            Logger.WriteInfoMessage(result);
            Logger.WriteInfoMessage("/*--------End of PreRequisite--------*/");

            ProfileCustData custData = new ProfileCustData();

            string arrivalDate = "";
            string departureDate = "";
            string ResCreationDate = "";
            string updateDate = "";

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", "", "1");

            Profile.SelectSubClient(custData.CompanyName);

            if (!string.IsNullOrEmpty(custData.ArrivalDate) && (custData.ArrivalDate != "No Data"))
            {
                DateTime Date = DateTime.Parse(custData.ArrivalDate);
                arrivalDate = Date.ToString("M/d/yyyy");
            }
            if (!string.IsNullOrEmpty(custData.DepartureDate) && (custData.DepartureDate != "No Data"))
            {
                DateTime Date = DateTime.Parse(custData.DepartureDate);
                departureDate = Date.ToString("M/d/yyyy");
            }
            if (!string.IsNullOrEmpty(custData.ResCreationDate) && (custData.ResCreationDate != "No Data"))
            {
                DateTime Date = DateTime.Parse(custData.ResCreationDate);
                ResCreationDate = Date.ToString("M/d/yyyy");
            }

            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "Profile.mvc/Reservation/Reservation");
            AddDelay(8000);
            Driver.SwitchTo().Frame(0);
            ElementWait(PageObject_PriorityQ.PriorityQ_Reset(), 60);
            if (IsElementVisible(PageObject_PriorityQ.PriorityQ_Reset()))
            {
                Logger.WriteDebugMessage("Landed on PriorityQ - Reservation Page.");

                PriorityQ.SelectStartDate(ResCreationDate);
                PriorityQ.SelectEndDate(ResCreationDate);

                PriorityQ.EnterSearchFilterValue(custData.ReservationNumber);

                ElementClick(Driver.FindElement(By.XPath("//table[@id='reservation_results']//button[contains(@class, 'editReservation')]")));
                AddDelay(20000);
                Driver.SwitchTo().ParentFrame();
                Driver.SwitchTo().Frame(0);
                ElementWait(Driver.FindElement(By.Id("email_compliance_check")), 60);
                if (IsElementPresent(By.Id("email_compliance_check")))
                {
                    Logger.WriteDebugMessage("Landed on Edit Reservation Page.");
                    ElementClick(Driver.FindElement(By.Id("email_compliance_check")));

                    ElementClick(Driver.FindElement(By.Id("sendemail")));
                    if (VerifyTextOnPage("Confirm"))
                    {
                        Logger.WriteDebugMessage("Landed on Confirm Page to send email.");
                        ElementClick(Driver.FindElement(By.Id("success_prompt")));

                        Logger.WriteDebugMessage("Email Sent and landed on Reservation Page");

                        AddDelay(15000);

                        ElementClick(Driver.FindElement(By.XPath("//a[contains(text(), '" + custData.ReservationNumber + "')]")));

                        Driver.SwitchTo().ParentFrame();
                        ControlToNewWindow();

                        Profile.ClickProfileCampaignHistory("", custData.CustomerID);
                        string getdateNow = DateTime.Now.ToString("M/d/yyyy");
                        string checkElement = "//a[contains(text(), 'RESENT')]//following::td[contains(text(), '" + getdateNow + "')]";
                        if (IsElementVisible(Driver.FindElement(By.XPath(checkElement))))
                        {
                            ScrollDownUsingJavaScript(Driver, 500);
                            Logger.WriteDebugMessage("RESENT lable is available on Campaign History Tab. \n " + "Found Resent Label for Date Sent " + getdateNow);
                        }
                        else
                        {
                            Logger.WriteDebugMessage("Did not find Resent Fuction on Profile - Campaign History Page.");
                        }
                        /*
                       Driver.SwitchTo().ParentFrame();

                       Navigation.MenuNavigation("Profile");

                       Profile.SelectSearchGuestsSearchBy("Reservation #");
                       Profile.InsertTextSearchGuestsSearchFor(custData.ReservationNumber);

                       Logger.WriteDebugMessage("Searching for an Email Address: " + custData.Email + " in profile search page.");




                       Profile.ClickOpenProfile(custData.CustomerID);

                       AddDelay(10000);

                       Profile.ClickProfileCampaignHistory("", custData.CustomerID);

                       Profile.Select_CampaignHistory_NumofRows(custData.CustomerID, "500");

                       Users data = new Users();

                       SqlWarehouseQuery.GetCustomerCampaignHistoryData(data, CompanyName, "GetReservatonfromCustomer", custData.CustomerID);

                       if (VerifyTextOnPage(data.Subject))
                       {
                           Logger.WriteDebugMessage("Found Campaign on Profile - Campaign History Tab.");
                       }
                        */

                    }


                }
            }

        }
        public static void TC_264703()
        {
        }
        #endregion[TP_271591]

    }
}
