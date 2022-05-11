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
        #region[TP_271586]
        public static void TC_263820()
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

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName);

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
                    string emailAddress = "";
                    Logger.WriteDebugMessage("Landed on Edit Reservation Page.");
                    PriorityQ.Click_ComplianceCheck();

                    PriorityQ.SelectCampaign(campaignData.CampaignName);
                    PriorityQ.EnterEmailAddress(LegacyTestData.CommonFrontendEmail);
                    //string getSelectedSubject = "Automation Resend Confirmation";//PriorityQ.GetSelectedSubject();

                    emailAddress = LegacyTestData.CommonFrontendEmail;
                    PriorityQ.Send_SentoTest(emailAddress);
                    Driver.SwitchTo().DefaultContent();

                    OpenNewTab();
                    ControlToNewWindow();
                    if (campaignData.CampaignSubject.Contains("#EMAIL#"))
                    {
                        campaignData.CampaignSubject = campaignData.CampaignSubject.Replace("#EMAIL#, ", "");
                    }
                    Login.AutoAcc_logins(campaignData.CampaignSubject, 2, 0, LegacyTestData.CommonCatchallURL, 1);

                    if (VerifyTextOnPage(campaignData.CampaignSubject) == true)
                    {
                        if (VerifyTextOnPage("Cendyn Automation"))
                        {
                            Logger.WriteDebugMessage("Email Was Received by - " + emailAddress);
                        }
                        else
                        {
                            Assert.Fail("Email was not received by - " + custData.Email);
                        }
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

                    Hotmail.OutlookSignOut();
                    ControlToPreviousWindow();
                    Driver.SwitchTo().ParentFrame();
                    Driver.SwitchTo().Frame(0);

                    emailAddress = "cendynautomation11@cendyn17.com";
                    PriorityQ.Send_SentoTest(emailAddress);
                    Driver.SwitchTo().DefaultContent();

                    OpenNewTab();
                    ControlToNewWindow();
                    if (campaignData.CampaignSubject.Contains("#EMAIL#"))
                    {
                        campaignData.CampaignSubject = campaignData.CampaignSubject.Replace("#EMAIL#, ", "");
                    }
                    Login.AutoAcc_logins(campaignData.CampaignSubject, 1, 0, LegacyTestData.CommonCatchallURL, 1);

                    if (VerifyTextOnPage(campaignData.CampaignSubject) == true)
                    {
                        if (VerifyTextOnPage(emailAddress))
                        {
                            Logger.WriteDebugMessage("Email Was Received by - " + emailAddress);
                        }
                        else
                        {
                            Assert.Fail("Email was not received by - " + emailAddress);
                        }
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
                }
            }
            else
            {
                Assert.Fail("Did not land on PriorityQ - Reservation Page.");
            }
        }
        public static void TC_263822()
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

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName);

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
                    //string getSelectedSubject = "Automation Resend Confirmation";//PriorityQ.GetSelectedSubject();

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
                }
                Hotmail.OutlookSignOut();
                ControlToPreviousWindow();

                Driver.SwitchTo().ParentFrame();
                Driver.SwitchTo().Frame(0);

                Driver.SwitchTo().Frame("templateEditor_ifr");

                Logger.WriteDebugMessage("Template had previeous text - Allow Edit Div");
                PriorityQ.ChangeTemplateDiv(newDivText);

                Driver.SwitchTo().DefaultContent();
                Driver.SwitchTo().ParentFrame();
                Driver.SwitchTo().Frame(0);

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
                    if (VerifyTextOnPage(newDivText))
                    {
                        Logger.WriteDebugMessage("Found default text - " + newDivText);
                    }
                    else
                    {
                        Assert.Fail("Couldn't find default text - " + newDivText);
                    }
                    Logger.WriteDebugMessage("Received Quick Send Email.");
                }
                else
                {
                    Assert.Fail("Send to Email was not received.");
                }

            }
        }
        public static void TC_264151()
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

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName);

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

                    PriorityQ.UncheckedCASL_CheckInputDisabled(0);

                    PriorityQ.Click_ComplianceCheck();

                    PriorityQ.UncheckedCASL_CheckInputDisabled(1);

                    ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'cendyncommunity')]")));
                    ControlToNewWindow();

                    if (Driver.Url.Equals("https://einsight.cendyncommunity.com/einsight-features-and-casl"))
                    {
                        Logger.WriteDebugMessage("Redirected to Cendyn Community Help Page.");
                    }
                    else
                    {
                        Assert.Fail("Did not land on redirected page to Cendyn Community Help Page.");
                    }
                }
            }
        }

        public static void TC_264152()
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

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName);

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
                    PriorityQ.Click_SendEmail_Cancel();
                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().Frame(0);
                    if (IsElementVisible(PageObject_PriorityQ.PriorityQ_Reset()))
                    {
                        Logger.WriteDebugMessage("Landed on PriorityQ - Search Page");
                        ElementClick(Driver.FindElement(By.XPath("//table[@id='reservation_results']//button[contains(@class, 'editReservation')]")));
                        AddDelay(20000);
                        Driver.SwitchTo().ParentFrame();
                        Driver.SwitchTo().Frame(0);
                        ElementWait(Driver.FindElement(By.Id("email_compliance_check")), 60);
                        if (IsElementPresent(By.Id("email_compliance_check")))
                        {
                            ElementClick(Driver.FindElement(By.XPath("//a[@aria-label='Close']//span")));
                            Driver.SwitchTo().DefaultContent();
                            Driver.SwitchTo().Frame(0);
                            if (IsElementVisible(PageObject_PriorityQ.PriorityQ_Reset()))
                            {
                                Logger.WriteDebugMessage("Landed on PriorityQ - Search Page");
                            }
                            else
                            {
                                Assert.Fail("Did not land on on PriorityQ - Search Page");
                            }
                        }
                    }
                    else
                    {
                        Assert.Fail("Did not land on on PriorityQ - Search Page");
                    }
                }
                else
                {
                    Assert.Fail("Did not land on Edit Reservation Page.");
                }
            }
        }
        public static void TC_264333()
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

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName);

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
                    PriorityQ.SendTemplate();
                    ReloadPage();
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
                        newDivText = "https://www.cendyn.com";
                        PriorityQ.ChangeTemplateDiv(newDivText);

                        Driver.SwitchTo().DefaultContent();
                        Driver.SwitchTo().ParentFrame();
                        Driver.SwitchTo().Frame(0);

                        SetBrowserZoom(85);
                        PriorityQ.Send_SentoTest();

                        OpenNewTab();
                        ControlToNewWindow();
                        if (campaignData.CampaignSubject.Contains("#EMAIL#"))
                        {
                            campaignData.CampaignSubject = campaignData.CampaignSubject.Replace("#EMAIL#, ", "");
                        }

                        Login.AutoAcc_login(campaignData.CampaignSubject, 2, 0, LegacyTestData.CommonCatchallURL, 1);

                        if (VerifyTextOnPage(campaignData.CampaignSubject) == true)
                        {
                            if (VerifyTextOnPage("www.cendyn.com"))
                            {
                                Logger.WriteDebugMessage("Found link on the page");
                            }
                            else
                            {
                                Assert.Fail("Couldn't find link on the page");
                            }
                        }
                        else
                        {
                            Assert.Fail("Send to Email was not received.");
                        }
                    }
                }
                else
                {
                    Assert.Fail("Did not land on Edit Reservation Page.");
                }
            }
        }
        public static void TC_264334()
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

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName);

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
                    string getSelectedSubject = "Automation Resend Confirmation";//PriorityQ.GetSelectedSubject();

                    Logger.WriteDebugMessage("Template had previeous text - Allow Edit Div");
                    Driver.SwitchTo().Frame("templateEditor_ifr");
                    PriorityQ.ChangeTemplateDiv(newDivText);
                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().ParentFrame();
                    Driver.SwitchTo().Frame(0);

                    PriorityQ.Send_SentoTest();
                    PriorityQ.SendTemplate();

                    OpenNewTab();
                    ControlToNewWindow();
                    ReloadPage();
                    if (campaignData.CampaignSubject.Contains("#EMAIL#"))
                    {
                        campaignData.CampaignSubject = campaignData.CampaignSubject.Replace("#EMAIL#, ", "");
                    }

                    Login.AutoAcc_logins(campaignData.CampaignSubject, 2, 0, LegacyTestData.CommonCatchallURL, 1);

                    if (VerifyTextOnPage(campaignData.CampaignSubject) == true)
                    {
                        if (VerifyTextOnPage(newDivText))
                        {
                            Logger.WriteDebugMessage("Found default text - " + newDivText);
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
                    ControlToPreviousWindow();
                    Navigation.MenuNavigation("ManageCampaign");

                    ManageCampaign.PreSearchCampaign_New(campaignData.ChildCompanyName, "ProjectID", projectID, iFrameManageCampaign, "Transactional");

                    ManageCampaign.ManageCampaign_EllipseButton("Details");
                    ManageCampaign.SendToTestEmail(projectID, 0);

                    ControlToNewWindow();
                    ReloadPage();
                    Hotmail.SearchEmailAndOpenLatestEmail(campaignData.CampaignSubject, 0);
                    if (VerifyTextOnPage(campaignData.CampaignSubject))
                    {
                        if (VerifyTextOnPage(defaultText))
                        {
                            Logger.WriteDebugMessage("Found Template test as - " + defaultText);
                        }
                        else if (VerifyTextOnPage(newDivText))
                        {
                            Assert.Fail("Found Edited text - " + newDivText);
                        }
                    }
                    else
                    {
                        Assert.Fail("Send to test email was not received.");
                    }

                }
            }
        }
        public static void TC_264335()
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

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName);

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
                    PriorityQ.Delete_Section("divEditor");

                    Logger.WriteInfoMessage("Testing Send To Test");

                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().ParentFrame();
                    Driver.SwitchTo().Frame(0);
                    PriorityQ.Send_SentoTest();
                    Driver.SwitchTo().DefaultContent();

                    OpenNewTab();
                    ControlToNewWindow();
                    if (campaignData.CampaignSubject.Contains("#EMAIL#"))
                    {
                        campaignData.CampaignSubject = campaignData.CampaignSubject.Replace("#EMAIL#, ", "");
                    }

                    Login.AutoAcc_logins(campaignData.CampaignSubject, 2, 0, LegacyTestData.CommonCatchallURL, 1);

                    if (VerifyTextOnPage(campaignData.CampaignSubject) == true)
                    {
                        if (!(IsElementPresent(By.XPath("//div[contains(@id, 'divEditor')]"))))
                        {
                            Logger.WriteDebugMessage("Element contains text - " + defaultText + " was removed on");
                        }
                        else
                        {
                            Assert.Fail("Section contains text - " + defaultText + " was found");
                        }
                    }
                    else
                    {
                        Assert.Fail("Send to Email was not received.");
                    }

                    ControlToPreviousWindow();
                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().ParentFrame();
                    Driver.SwitchTo().Frame(0);

                    Logger.WriteInfoMessage("Testing Send Email");
                    PriorityQ.SendTemplate();
                    Driver.SwitchTo().DefaultContent();
                    ControlToNewWindow();
                    ReloadPage();
                    Hotmail.SearchEmailAndOpenLatestEmail(campaignData.CampaignSubject, 0);

                    if (VerifyTextOnPage(campaignData.CampaignSubject) == true)
                    {
                        if (!(IsElementPresent(By.XPath("//div[contains(@id, 'divEditor')]"))))
                        {
                            Logger.WriteDebugMessage("Element contains text - " + defaultText + " was removed on");
                        }
                        else
                        {
                            Assert.Fail("Section contains text - " + defaultText + " was found");
                        }
                    }
                    else
                    {
                        Assert.Fail("Send to Email was not received.");
                    }
                }
            }
        }
        public static void TC_265698()
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

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName);

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
                    PriorityQ.Delete_Section("imageEditor");
                    PriorityQ.ChangeTemplateDiv(newDivText);

                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().ParentFrame();
                    Driver.SwitchTo().Frame(0);
                    Logger.WriteInfoMessage("Testing Send To Test");
                    PriorityQ.Send_SentoTest();
                    Driver.SwitchTo().DefaultContent();

                    OpenNewTab();
                    ControlToNewWindow();
                    if (campaignData.CampaignSubject.Contains("#EMAIL#"))
                    {
                        campaignData.CampaignSubject = campaignData.CampaignSubject.Replace("#EMAIL#, ", "");
                    }

                    Login.AutoAcc_logins(campaignData.CampaignSubject, 2, 0, LegacyTestData.CommonCatchallURL, 1);

                    if (VerifyTextOnPage(campaignData.CampaignSubject) == true)
                    {
                        if ((!IsElementPresent(By.XPath("//img[contains(@src, 'yourlogo_dark(2).png')]"))))
                        {
                            Logger.WriteDebugMessage("Image was successfully removed from the template.");
                        }
                        else
                        {
                            Assert.Fail("Image was not successfully removed from the template.");
                        }
                        if (VerifyTextOnPage(newDivText))
                        {
                            Logger.WriteDebugMessage("Section contains text - " + defaultText + " was replaced by " + newDivText + ".");
                        }
                        else
                        {
                            Assert.Fail("Section contains text - " + defaultText + " was not replaced by " + newDivText + ".");
                        }
                    }
                    else
                    {
                        Assert.Fail("Send to Email was not received.");
                    }

                    ControlToPreviousWindow();
                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().ParentFrame();
                    Driver.SwitchTo().Frame(0);

                    Logger.WriteInfoMessage("Testing Send Email");
                    PriorityQ.SendTemplate();

                    ControlToNewWindow();
                    ReloadPage();
                    Hotmail.SearchEmailAndOpenLatestEmail(campaignData.CampaignSubject, 0);

                    if (VerifyTextOnPage(campaignData.CampaignSubject) == true)
                    {
                        if ((!IsElementPresent(By.XPath("//img[contains(@src, 'yourlogo_dark(2).png')]"))))
                        {
                            Logger.WriteDebugMessage("Image was successfully removed from the template.");
                        }
                        else
                        {
                            Assert.Fail("Image was not successfully removed from the template.");
                        }
                        if (VerifyTextOnPage(newDivText))
                        {
                            Logger.WriteDebugMessage("Section contains text - " + defaultText + " was replaced by " + newDivText + ".");
                        }
                        else
                        {
                            Assert.Fail("Section contains text - " + defaultText + " was not replaced by " + newDivText + ".");
                        }
                    }
                    else
                    {
                        Assert.Fail("Send to Email was not received.");
                    }
                }
            }
        }
        public static void TC_265920()
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

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName);

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
                        if (VerifyTextOnPage(custData.SubReservationNumber))
                        {
                            Logger.WriteDebugMessage("Found personalization tag SubReservationNumber was replaced with text " + custData.SubReservationNumber + ".");
                        }
                        else
                        {
                            Assert.Fail("Found personalization tag Email was replaced with text " + custData.Email + ".");
                        }
                    }
                    else
                    {
                        Assert.Fail("Send Email was not received.");
                    }
                }
            }
        }
        public static void TC_267147()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);
            int customerID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "CustomerID", TestPlanId));
            int sourceGuestID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "SourceGuestID", TestPlanId));
            int emailID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "EmailID", TestPlanId));

            CampaignDetails campaignData = new CampaignDetails();
            SqlWarehouseQuery.GetCampaignDetails(campaignData, CompanyName, projectID);

            Profile.SelectSubClient(CompanyName);

            Logger.WriteInfoMessage("/*----------PreRequisite--------*/");
            string result = SqlWarehouseQuery.HasBookingReservation_NoCampaignAttached(CompanyName, customerID, sourceGuestID, emailID, 1);
            
            Logger.WriteInfoMessage(result);
            Logger.WriteInfoMessage("/*--------End of PreRequisite--------*/");

            ProfileCustData custData = new ProfileCustData();

            string arrivalDate = "";
            string departureDate = "";
            string ResCreationDate = "";
            string updateDate = "";
            string defaultText = "Allow Edit Div";

            if (testCategory == "QA")
            {
                clientName = "Freepoint Hotel";
            }
            if (testCategory == "POC")
            {
                clientName = "Hotel Origami Miami Beach";
            }

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

                if (string.IsNullOrEmpty(custData.ReservationNumber))
                {
                    custData.ReservationNumber = " ";
                }
                PriorityQ.EnterSearchFilterValue(custData.ReservationNumber);

                ElementClick(Driver.FindElement(By.XPath("//table[@id='reservation_results']//button[contains(@class, 'editReservation')]")));
                AddDelay(15000);
                if (VerifyTextOnPage("There is no campaign found for this reservation."))
                {
                    Logger.WriteDebugMessage("Received Warning Message - There is no campaign found for this reservation.");
                }
                else
                {
                    Assert.Fail("Did not land on the warning message.");
                }
            }
        }
        public static void TC_267002()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ProjectID");
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

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName);

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

                if (IsElementPresent(By.Id("email_compliance_check")))
                {
                    Logger.WriteDebugMessage("Landed on Edit Reservation Page.");
                    PriorityQ.Click_ComplianceCheck();

                    PriorityQ.SelectCampaign(campaignData.CampaignName);

                    if (VerifyTextOnPage("The actual saved campaign doesn't have any sections that are marked as editable."))
                    {
                        var quotes = '"';
                        Logger.WriteDebugMessage("Received Prompt - " + quotes + "The actual saved campaign doesn't have any sections that are marked as editable." + quotes);
                    }

                }
            }
        }
        public static void TC_275783()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ProjectID");
            string pattern = @",.*";
            string projID = Regex.Replace(projectID, pattern, "");
            CampaignDetails campaignData = new CampaignDetails();
            SqlWarehouseQuery.GetCampaignDetails(campaignData, CompanyName, projID);
            int customerID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "CustomerID", TestPlanId));
            int sourceGuestID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "SourceGuestID", TestPlanId));
            int emailID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "EmailID", TestPlanId));

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

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName);

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

                    ElementClick(Driver.FindElement(By.Id("select2-reservation_campaign-container")));

                    string[] forallProjectID = Regex.Split(projectID, ",");
                    foreach (string eachProjectID in forallProjectID)
                    {
                        Logger.WriteDebugMessage("Found CampaignName - " + campaignData.CampaignName);
                    }
                }
            }
        }
        #endregion[TP_271586]

    }
}
