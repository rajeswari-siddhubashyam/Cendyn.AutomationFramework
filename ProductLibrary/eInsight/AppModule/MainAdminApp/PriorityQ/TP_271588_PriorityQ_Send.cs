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
        #region[TP_271588]
        public static void TC_264338()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);
            int customerID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "CustomerID", TestPlanId));
            int sourceGuestID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "SourceGuestID", TestPlanId));
            int emailID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "EmailID", TestPlanId));

            CampaignDetails campaignData = new CampaignDetails();
            SqlWarehouseQuery.GetCampaignDetails(campaignData, CompanyName, projectID);

            Profile.SelectSubClient(CompanyName);

            Logger.WriteInfoMessage("/*----------PreRequisite--------*/");
            string result = setPrerequisite(CompanyName, customerID, sourceGuestID, emailID, 1);

            Logger.WriteInfoMessage(result);
            Logger.WriteInfoMessage("/*--------End of PreRequisite--------*/");

            ProfileCustData custData = new ProfileCustData();

            string arrivalDate = "";
            string departureDate = "";
            string ResCreationDate = "";
            string updateDate = "";

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName, "1");

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
                    PriorityQ.Click_ComplianceCheck();

                    PriorityQ.SelectCampaign(campaignData.CampaignName);
                    PriorityQ.EnterEmailAddress(LegacyTestData.CommonFrontendEmail);


                    Driver.SwitchTo().Frame("templateEditor_ifr");
                    string newDivText = "Template changed to text - Test JS";
                    Logger.WriteDebugMessage("Template had previeous text - Allow Edit Div");
                    PriorityQ.ChangeTemplateDiv(newDivText);
                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().ParentFrame();
                    Driver.SwitchTo().Frame(0);
                    PriorityQ.SendTemplate();
                    Logger.WriteDebugMessage("Template sent to Email - " + LegacyTestData.CommonFrontendEmail + " with changed div value to " + newDivText);
                    OpenNewTab();
                    ControlToNewWindow();
                    if (campaignData.CampaignSubject.Contains("#EMAIL#"))
                    {
                        campaignData.CampaignSubject = campaignData.CampaignSubject.Replace("#EMAIL#, ", "");
                    }
                    Login.AutoAcc_logins(campaignData.CampaignSubject, 2, 0, LegacyTestData.CommonCatchallURL, 1);
                    if (VerifyTextOnPage(newDivText))
                    {
                        Logger.WriteDebugMessage("Template sent to Email - " + LegacyTestData.CommonFrontendEmail + " with changed div value to " + newDivText);
                    }
                    else
                    {
                        Assert.Fail("Template sent to Email - " + LegacyTestData.CommonFrontendEmail + " did not had changed div value to " + newDivText);
                    }



                }
            }
        }
        public static void TC_264339()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);
            int customerID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "CustomerID", TestPlanId));
            int sourceGuestID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "SourceGuestID", TestPlanId));
            int emailID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "EmailID", TestPlanId));

            CampaignDetails campaignData = new CampaignDetails();
            SqlWarehouseQuery.GetCampaignDetails(campaignData, CompanyName, projectID);

            Profile.SelectSubClient(CompanyName);

            Logger.WriteInfoMessage("/*----------PreRequisite--------*/");
            string result = setPrerequisite(CompanyName, customerID, sourceGuestID, emailID, 1);

            Logger.WriteInfoMessage(result);
            Logger.WriteInfoMessage("/*--------End of PreRequisite--------*/");

            ProfileCustData custData = new ProfileCustData();

            string arrivalDate = "";
            string departureDate = "";
            string ResCreationDate = "";
            string updateDate = "";
            string defaultText = "Allow Edit Div";

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName, "1");

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
                    PriorityQ.Click_ComplianceCheck();

                    PriorityQ.SelectCampaign(campaignData.CampaignName);
                    PriorityQ.EnterEmailAddress(LegacyTestData.CommonFrontendEmail);

                    PriorityQ.Send_SentoTest();
                    Driver.SwitchTo().DefaultContent();
                    AddDelay(25000);

                    OpenNewTab();
                    ControlToNewWindow();
                    if (campaignData.CampaignSubject.Contains("#EMAIL#"))
                    {
                        campaignData.CampaignSubject = campaignData.CampaignSubject.Replace("#EMAIL#, ", "");
                    }
                    Login.AutoAcc_logins(campaignData.CampaignSubject, 2, 0, LegacyTestData.CommonCatchallURL, 1);

                    if (VerifyTextOnPage(campaignData.CampaignSubject) == true)
                    {
                        if (VerifyTextOnPage(defaultText))
                        {
                            Logger.WriteDebugMessage("Found default text - " + defaultText);
                        }
                        else
                        {
                            Assert.Fail("Couldn't find default text - " + defaultText);
                        }
                        Logger.WriteDebugMessage("Received Quick Send Email.");
                    }
                    else
                    {
                        Assert.Fail("Send to Email was not received.");
                    }

                    ControlToPreviousWindow();
                    Driver.SwitchTo().ParentFrame();
                    Driver.SwitchTo().Frame(0);

                    PriorityQ.SendTemplate();

                    ControlToNewWindow();
                    ReloadPage();
                    Hotmail.SearchEmailAndOpenLatestEmail(campaignData.CampaignSubject, 0);

                    if (VerifyTextOnPage(campaignData.CampaignSubject) == true)
                    {
                        if (VerifyTextOnPage(defaultText))
                        {
                            Logger.WriteDebugMessage("Found default text - " + defaultText);
                        }
                        else
                        {
                            Assert.Fail("Couldn't find default text - " + defaultText);
                        }
                        Logger.WriteDebugMessage("Received Sent Email.");
                    }
                    else
                    {
                        Assert.Fail("Send Email was not received.");
                    }
                }
            }
        }
        public static void TC_264939()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);
            int customerID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "CustomerID", TestPlanId));
            int sourceGuestID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "SourceGuestID", TestPlanId));
            int emailID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "EmailID", TestPlanId));

            CampaignDetails campaignData = new CampaignDetails();
            SqlWarehouseQuery.GetCampaignDetails(campaignData, CompanyName, projectID);

            Profile.SelectSubClient(CompanyName);

            Logger.WriteInfoMessage("/*----------PreRequisite--------*/");
            string result = setPrerequisite(CompanyName, customerID, sourceGuestID, emailID, 1);

            Logger.WriteInfoMessage(result);
            Logger.WriteInfoMessage("/*--------End of PreRequisite--------*/");

            ProfileCustData custData = new ProfileCustData();

            string arrivalDate = "";
            string departureDate = "";
            string ResCreationDate = "";
            string updateDate = "";
            string defaultText = "Allow Edit Div";

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName, "1");

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
                    PriorityQ.Click_ComplianceCheck();

                    PriorityQ.SelectCampaign(campaignData.CampaignName);
                    PriorityQ.EnterEmailAddress(LegacyTestData.CommonFrontendEmail);

                    PriorityQ.SendTemplate();

                    OpenNewTab();
                    ControlToNewWindow();
                    if (campaignData.CampaignSubject.Contains("#EMAIL#"))
                    {
                        campaignData.CampaignSubject = campaignData.CampaignSubject.Replace("#EMAIL#, ", "");
                    }
                    Login.AutoAcc_logins(campaignData.CampaignSubject, 2, 0, LegacyTestData.CommonCatchallURL, 1);

                    if (VerifyTextOnPage(campaignData.CampaignSubject) == true)
                    {
                        if (VerifyTextOnPage(defaultText))
                        {
                            Logger.WriteDebugMessage("Found default text - " + defaultText);
                        }
                        else
                        {
                            Assert.Fail("Couldn't find default text - " + defaultText);
                        }
                        Logger.WriteDebugMessage("Received Sent Email.");
                    }
                    else
                    {
                        Assert.Fail("Send Email was not received.");
                    }
                    CloseCurrentTab();
                    ControlToPreviousWindow();
                    Driver.SwitchTo().ParentFrame();
                    Driver.SwitchTo().Frame(0);
                    if (VerifyTextOnPage(custData.ReservationNumber))
                    {
                        Logger.WriteDebugMessage("Landed on PriorityQ - Reservation Search Page and search criteria with Reservation number is on the page - " + custData.ReservationNumber);
                    }
                    else
                    {
                        Assert.Fail("Did not land on Reservation Search Page and search criteria with Reservation number is on the page - " + custData.ReservationNumber);
                    }
                }
            }
        }
        public static void TC_265090()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);
            int customerID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "CustomerID", TestPlanId));
            int sourceGuestID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "SourceGuestID", TestPlanId));
            int emailID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "EmailID", TestPlanId));

            CampaignDetails campaignData = new CampaignDetails();
            SqlWarehouseQuery.GetCampaignDetails(campaignData, CompanyName, projectID);

            Profile.SelectSubClient(CompanyName);

            Logger.WriteInfoMessage("/*----------PreRequisite--------*/");
            string result = setPrerequisite(CompanyName, customerID, sourceGuestID, emailID, 1);

            Logger.WriteInfoMessage(result);
            Logger.WriteInfoMessage("/*--------End of PreRequisite--------*/");

            ProfileCustData custData = new ProfileCustData();

            string arrivalDate = "";
            string departureDate = "";
            string ResCreationDate = "";
            string updateDate = "";
            string defaultText = "Allow Edit Div";

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName, "1");

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
                    PriorityQ.Click_ComplianceCheck();

                    PriorityQ.SelectCampaign(campaignData.CampaignName);
                    PriorityQ.EnterEmailAddress(LegacyTestData.CommonFrontendEmail);

                    PriorityQ.SendTemplate();

                    OpenNewTab();
                    ControlToNewWindow();

                    if (campaignData.CampaignSubject.Contains("#EMAIL#"))
                    {
                        campaignData.CampaignSubject = campaignData.CampaignSubject.Replace("#EMAIL#, ", "");
                    }

                    Login.AutoAcc_logins(campaignData.CampaignSubject, 2, 0, LegacyTestData.CommonCatchallURL, 1);

                    if (VerifyTextOnPage(campaignData.CampaignSubject) == true)
                    {
                        if (VerifyTextOnPage(defaultText))
                        {
                            Logger.WriteDebugMessage("Found default text - " + defaultText);
                        }
                        else
                        {
                            Assert.Fail("Couldn't find default text - " + defaultText);
                        }
                        Logger.WriteDebugMessage("Received Sent Email.");
                    }
                    else
                    {
                        Assert.Fail("Send Email was not received.");
                    }
                }
            }
        }

        public static void TC_265091()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);
            int customerID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "CustomerID", TestPlanId));
            int sourceGuestID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "SourceGuestID", TestPlanId));
            int emailID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "EmailID", TestPlanId));

            CampaignDetails campaignData = new CampaignDetails();
            SqlWarehouseQuery.GetCampaignDetails(campaignData, CompanyName, projectID);

            Profile.SelectSubClient(CompanyName);

            Logger.WriteInfoMessage("/*----------PreRequisite--------*/");
            string result = setPrerequisite(CompanyName, customerID, sourceGuestID, emailID, 1);

            Logger.WriteInfoMessage(result);
            Logger.WriteInfoMessage("/*--------End of PreRequisite--------*/");

            ProfileCustData custData = new ProfileCustData();

            string arrivalDate = "";
            string departureDate = "";
            string ResCreationDate = "";
            string updateDate = "";

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName, "1");

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
                    PriorityQ.Click_ComplianceCheck();

                    SqlWarehouseQuery.GetCampaignDetails(campaignData, CompanyName, projectID);
                    PriorityQ.EnterEmailAddress(LegacyTestData.CommonFrontendEmail);

                    string newDivText = "Template changed to text - Test JS";
                    Logger.WriteDebugMessage("Template had previeous text - Allow Edit Div");
                    Driver.SwitchTo().Frame("templateEditor_ifr");
                    PriorityQ.ChangeTemplateDiv(newDivText);
                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().ParentFrame();
                    Driver.SwitchTo().Frame(0);
                    ElementClick(Driver.FindElement(By.Id("sendemail")));
                    if (VerifyTextOnPage("Confirm"))
                    {
                        PriorityQ.Click_SendEmailPrompt_Cancel();
                    }
                    //PriorityQ.Click_SendEmail_Cancel();
                    //Logger.WriteDebugMessage("Landed PriorityQ Main Page.");
                }
            }
        }
        public static void TC_265988()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);
            int customerID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "CustomerID", TestPlanId));
            int sourceGuestID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "SourceGuestID", TestPlanId));
            int emailID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "EmailID", TestPlanId));

            CampaignDetails campaignData = new CampaignDetails();
            SqlWarehouseQuery.GetCampaignDetails(campaignData, CompanyName, projectID);

            Profile.SelectSubClient(CompanyName);

            Logger.WriteInfoMessage("/*----------PreRequisite--------*/");
            string result = setPrerequisite(CompanyName, customerID, sourceGuestID, emailID, 1);

            Logger.WriteInfoMessage(result);
            Logger.WriteInfoMessage("/*--------End of PreRequisite--------*/");

            ProfileCustData custData = new ProfileCustData();

            string arrivalDate = "";
            string departureDate = "";
            string ResCreationDate = "";
            string updateDate = "";

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName, "1");

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
                    PriorityQ.Click_ComplianceCheck();

                    PriorityQ.SelectCampaign(campaignData.CampaignName);
                    PriorityQ.EnterEmailAddress(LegacyTestData.CommonFrontendEmail);

                    ElementClick(Driver.FindElement(By.Id("sendemail")));
                    if (VerifyTextOnPage("Confirm"))
                    {
                        if (VerifyTextOnPage("Send " + campaignData.CampaignName + " to " + LegacyTestData.CommonFrontendEmail))
                        {
                            Logger.WriteDebugMessage("Found the prompt message - Send " + campaignData.CampaignName + " to " + LegacyTestData.CommonFrontendEmail);
                            ElementClick(Driver.FindElement(By.Id("success_prompt")));
                            Logger.WriteDebugMessage("Email Sent.");
                        }
                    }
                }
            }
        }
        public static void TC_265989()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);
            int customerID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "CustomerID", TestPlanId));
            int sourceGuestID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "SourceGuestID", TestPlanId));
            int emailID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "EmailID", TestPlanId));

            CampaignDetails campaignData = new CampaignDetails();
            SqlWarehouseQuery.GetCampaignDetails(campaignData, CompanyName, projectID);

            Profile.SelectSubClient(CompanyName);

            Logger.WriteInfoMessage("/*----------PreRequisite--------*/");
            string result = setPrerequisite(CompanyName, customerID, sourceGuestID, emailID, 1);

            Logger.WriteInfoMessage(result);
            Logger.WriteInfoMessage("/*--------End of PreRequisite--------*/");

            ProfileCustData custData = new ProfileCustData();

            string arrivalDate = "";
            string departureDate = "";
            string ResCreationDate = "";
            string updateDate = "";

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName, "1");

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
                    PriorityQ.Click_ComplianceCheck();

                    PriorityQ.SelectCampaign(campaignData.CampaignName);
                    PriorityQ.EnterEmailAddress(LegacyTestData.CommonFrontendEmail);

                    Driver.SwitchTo().Frame("templateEditor_ifr");

                    Logger.WriteDebugMessage("Template had previeous text - Allow Edit Div");
                    PriorityQ.ChangeTemplateDiv(newDivText);
                    if (!VerifyTextOnPage("Allow Edit Div") && VerifyTextOnPage(newDivText)) 
                    {
                        Logger.WriteDebugMessage("Template had previeous text - Allow Edit Div and was replaced by " + newDivText + ". ");
                    }
                    else
                    {
                        Assert.Fail("Template had previeous text - Allow Edit Div and was replaced by " + newDivText + ". ");
                    }

                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().ParentFrame();
                    Driver.SwitchTo().Frame(0);

                    ElementClick(Driver.FindElement(By.Id("sendemail")));
                    if (VerifyTextOnPage("Confirm"))
                    {
                        Logger.WriteDebugMessage("Landed on Confirm Page to send email.");
                        PriorityQ.Click_SendEmailPrompt_Cancel();

                        Driver.SwitchTo().ParentFrame();
                        Driver.SwitchTo().Frame(0);

                        Driver.SwitchTo().Frame("templateEditor_ifr");
                        if (VerifyTextOnPage(newDivText))
                        {
                            Logger.WriteDebugMessage("Landed on PriorityQ - Edit Template after clicking on Cancel Button and the template still has edited content.");
                        }
                        else
                        {
                            Logger.WriteDebugMessage("Did not landed on PriorityQ - Edit Template after clicking on Cancel Button.");
                        }

                        Driver.SwitchTo().DefaultContent();
                        Driver.SwitchTo().ParentFrame();
                        Driver.SwitchTo().Frame(0);

                        PriorityQ.Click_SendEmail_Cancel();
                        if (IsElementVisible(PageObject_PriorityQ.PriorityQ_Reset()))
                        {
                            if (VerifyTextOnPage(custData.ReservationNumber))
                            {
                                Logger.WriteDebugMessage("Landed on PriorityQ - Reservation Search Page and search criteria with Reservation number is on the page - " + custData.ReservationNumber);
                            }
                            else
                            {
                                Assert.Fail("Did not land on Reservation Search Page and search criteria with Reservation number is on the page - " + custData.ReservationNumber);
                            }
                        }
                        else
                        {
                            Assert.Fail("Did not land on on PriorityQ - Reservation Page.");
                        }
                    }
                    else
                    {
                        Assert.Fail("Did not sent on Confirm Page.");
                    }
                }
            }

        }
        #endregion[TP_271588]

    }
}
