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
        public static string setPrerequisite(string companyName, int customerID, int sourceGuestID, int emailID, int hasEmail)
        {
            string result = SqlWarehouseQuery.HasBookingReservation(companyName, customerID, sourceGuestID, emailID, hasEmail);
            return result;
        }
        #region[TP_271585]
        public static void TC_263323()
        {
            int customerID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "CustomerID", TestPlanId));
            int sourceGuestID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "SourceGuestID", TestPlanId));
            int emailID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "EmailID", TestPlanId));
            Logger.WriteInfoMessage("/*----------PreRequisite--------*/");
            string result = setPrerequisite(CompanyName, customerID, sourceGuestID, emailID, 1);

            Logger.WriteInfoMessage(result);
            Logger.WriteInfoMessage("/*--------End of PreRequisite--------*/");

            ProfileCustData custData = new ProfileCustData();

            string arrivalDate = "";
            string departureDate = "";
            string ResCreationDate = "";
            string updateDate = "";

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0,"","", clientName, "1");

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

                if (IsElementVisible(Driver.FindElement(By.XPath("//table[@id='reservation_results']//following::*[contains(text(), '" + custData.Email + "')]"))))
                {
                    string message = "User appeared on the page.";
                    message = message + "\n Name: " + custData.FirstName + " " + custData.LastName;
                    message = message + "\n Email: " + custData.Email;
                    message = message + "\n Property: " + custData.PropertyName;
                    message = message + "\n Reservation Number: " + custData.ReservationNumber;
                    message = message + "\n Sub-Reservation Number: " + custData.SubReservationNumber;
                    message = message + "\n Reservation Status: " + custData.ReservationStatus;
                    message = message + "\n ArrivalDate: " + arrivalDate;
                    message = message + "\n DepartureDate: " + departureDate;
                    message = message + "\n ReservationCreationDate: " + ResCreationDate;

                    Logger.WriteDebugMessage(message);
                }


            }
        }
        public static void TC_264145()
        {
            int customerID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "CustomerID", TestPlanId));
            int sourceGuestID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "SourceGuestID", TestPlanId));
            int emailID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "EmailID", TestPlanId));
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
                string message = "Expected result appreared on the page.";

                string fullNameXPath = "//table[@id='reservation_results']//following::*[contains(text(), '" + custData.FullName + "')]";
                string emailXPath = "//table[@id='reservation_results']//following::*[contains(text(), '" + custData.Email + "')]";
                string propertynameXPath = "//table[@id='reservation_results']//following::*[contains(text(), '" + custData.PropertyName + "')]";
                string resNumXPath = "//table[@id='reservation_results']//following::*[contains(text(), '" + custData.ReservationNumber + "')]";
                string subresNumXPath = "//table[@id='reservation_results']//following::*[contains(text(), '" + custData.SubReservationNumber + "')]";
                string resstatusXPath = "//table[@id='reservation_results']//following::*[contains(text(), '" + custData.ReservationStatus + "')]";
                string arrivalDateXPath = "//table[@id='reservation_results']//following::*[contains(text(), '" + arrivalDate + "')]";
                string deptDateXPath = "//table[@id='reservation_results']//following::*[contains(text(), '" + departureDate + "')]";
                string resCreateDateXPath = "//table[@id='reservation_results']//following::*[contains(text(), '" + ResCreationDate + "')]";

                ElementClick(Driver.FindElement(By.XPath(fullNameXPath)));

                if (IsElementPresent(By.XPath(fullNameXPath)) &&
                    IsElementPresent(By.XPath(emailXPath)) &&
                    IsElementPresent(By.XPath(propertynameXPath)) &&
                    IsElementPresent(By.XPath(resNumXPath)) &&
                    IsElementPresent(By.XPath(subresNumXPath)) &&
                    IsElementPresent(By.XPath(resstatusXPath)) &&
                    IsElementPresent(By.XPath(arrivalDateXPath)) &&
                    IsElementPresent(By.XPath(deptDateXPath)) &&
                    IsElementPresent(By.XPath(resCreateDateXPath))
                    )
                {
                    message = message + "\n Name: " + custData.FullName;
                    message = message + "\n Email: " + custData.Email;
                    message = message + "\n Property: " + custData.PropertyName;
                    message = message + "\n Reservation Number: " + custData.ReservationNumber;
                    message = message + "\n Sub Reservation Number: " + custData.SubReservationNumber;
                    message = message + "\n Reservation Status: " + custData.ReservationStatus;
                    message = message + "\n ArrivalDate: " + arrivalDate;
                    message = message + "\n DepartureDate: " + departureDate;
                    message = message + "\n ReservationCreationDate: " + ResCreationDate;

                    Logger.WriteDebugMessage(message);
                }
                else
                {
                    Assert.Fail("One of the data are not matching.");
                }
            }
            else
            {
                Assert.Fail("One of the Customer's reservation data was not found on the page.");
            }
        }
        public static void TC_264147()
        {
            int customerID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "CustomerID", TestPlanId));
            int sourceGuestID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "SourceGuestID", TestPlanId));
            int emailID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "EmailID", TestPlanId));
            Logger.WriteInfoMessage("/*----------PreRequisite--------*/");
            string result = setPrerequisite(CompanyName, customerID, sourceGuestID, emailID, 1);

            Logger.WriteInfoMessage(result);
            Logger.WriteInfoMessage("/*--------End of PreRequisite--------*/");

            ProfileCustData custData = new ProfileCustData();

            string getCounts = SqlWarehouseQuery.GetReservationCount(CompanyName);

            if (Convert.ToInt32(getCounts) < 10)
            {
                Assert.Fail("There are only 1 reservation on the table.");
            }
            else
            {
                Profile.SelectSubClient(CompanyName);

                Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "Profile.mvc/Reservation/Reservation");
                AddDelay(8000);
                Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@name='Reservation']")));

                ElementWait(PageObject_PriorityQ.PriorityQ_Reset(), 60);

                if (IsElementVisible(PageObject_PriorityQ.PriorityQ_Reset()))
                {
                    DateTime date = DateTime.Now;
                    string startdate = date.AddDays(-2).ToString("M/d/yyyy");
                    string enddate = date.ToString("M/d/yyyy");

                    //Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@name='Reservation']")));

                    PriorityQ.SelectStartDate(startdate);
                    PriorityQ.SelectEndDate(enddate);
                    PriorityQ.Click_SearchButton();

                    Logger.WriteInfoMessage("Starting Pagination Testing");
                    ScrollToElement(Driver.FindElement(By.XPath("//th[contains(text(), 'Name')]")));
                    ElementClick(Driver.FindElement(By.XPath("(//a[@class = 'page-link'])[4]")));
                    ElementWait(Driver.FindElement(By.XPath("//table[@id='reservation_results']//button[contains(@class, 'editReservation')]")), 60);
                    Logger.WriteDebugMessage("Clicked on Page 2 and landed on second page.");

                    ElementClick(Driver.FindElement(By.XPath("(//a[@class = 'page-link'])[6]")));
                    ElementWait(Driver.FindElement(By.XPath("//table[@id='reservation_results']//button[contains(@class, 'editReservation')]")), 60);
                    Logger.WriteDebugMessage("Clicked on Next button and landed on next page.");

                    ElementClick(Driver.FindElement(By.XPath("(//a[@class = 'page-link'])[2]")));
                    ElementWait(Driver.FindElement(By.XPath("//table[@id='reservation_results']//button[contains(@class, 'editReservation')]")), 60);
                    Logger.WriteDebugMessage("Clicked on Previous button and landed on previous page.");

                    ElementClick(Driver.FindElement(By.XPath("(//a[@class = 'page-link'])[1]")));
                    ElementWait(Driver.FindElement(By.XPath("//table[@id='reservation_results']//button[contains(@class, 'editReservation')]")), 60);
                    Logger.WriteDebugMessage("Clicked on First button and landed on first page.");

                    ElementClick(Driver.FindElement(By.XPath("(//a[@class = 'page-link'])[7]")));
                    ElementWait(Driver.FindElement(By.XPath("//table[@id='reservation_results']//button[contains(@class, 'editReservation')]")), 60);
                    Logger.WriteDebugMessage("Clicked on Last button and landed on last page.");

                    Logger.WriteInfoMessage("Starting Sorting Testing");
                    ScrollToElement(Driver.FindElement(By.XPath("//h1[contains(text(), 'Reservations')]")));
                    ElementClick(Driver.FindElement(By.XPath("//th[contains(text(), 'Name')]")));
                    Logger.WriteDebugMessage("Sorted in Ascending order.");
                    ElementClick(Driver.FindElement(By.XPath("//th[contains(text(), 'Name')]")));
                    Logger.WriteDebugMessage("Sorted in Descending order.");

                    ElementClick(Driver.FindElement(By.XPath("//th[contains(text(), 'Email')]")));
                    Logger.WriteDebugMessage("Sorted in Ascending order.");
                    ElementClick(Driver.FindElement(By.XPath("//th[contains(text(), 'Email')]")));
                    Logger.WriteDebugMessage("Sorted in Descending order.");

                    ElementClick(Driver.FindElement(By.XPath("//th[contains(text(), 'Property')]")));
                    Logger.WriteDebugMessage("Sorted in Ascending order.");
                    ElementClick(Driver.FindElement(By.XPath("//th[contains(text(), 'Property')]")));
                    Logger.WriteDebugMessage("Sorted in Descending order.");

                    ElementClick(Driver.FindElement(By.XPath("//th[contains(text(), 'Res #')]")));
                    Logger.WriteDebugMessage("Sorted in Ascending order.");
                    ElementClick(Driver.FindElement(By.XPath("//th[contains(text(), 'Res #')]")));
                    Logger.WriteDebugMessage("Sorted in Descending order.");

                    ElementClick(Driver.FindElement(By.XPath("//th[contains(text(), 'Sub Res #')]")));
                    Logger.WriteDebugMessage("Sorted in Ascending order.");
                    ElementClick(Driver.FindElement(By.XPath("//th[contains(text(), 'Sub Res #')]")));
                    Logger.WriteDebugMessage("Sorted in Descending order.");
                }
                else
                {
                    Assert.Fail("Reservation Page did not load.");
                }
            }
        }
        public static void TC_264150()
        {
            int customerID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "CustomerID", TestPlanId));
            int sourceGuestID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "SourceGuestID", TestPlanId));
            int emailID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "EmailID", TestPlanId));
            Logger.WriteInfoMessage("/*----------PreRequisite--------*/");
            string result = setPrerequisite(CompanyName, customerID, sourceGuestID, emailID, 1);

            Logger.WriteInfoMessage(result);
            Logger.WriteInfoMessage("/*--------End of PreRequisite--------*/");

            ProfileCustData custData = new ProfileCustData();

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 0, "", "", clientName, "1");
            Profile.SelectSubClient(custData.CompanyName);

            string ResCreationDate = "";
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
                PriorityQ.SelectStartDate(ResCreationDate);
                PriorityQ.SelectEndDate(ResCreationDate);
                PriorityQ.Click_SearchButton();
                PriorityQ.EnterSearchFilterValue(custData.ReservationNumber);
                if (IsElementVisible(Driver.FindElement(By.XPath("//table[@id='reservation_results']//following::*[contains(text(), '" + custData.Email + "')]"))))
                {
                    Logger.WriteDebugMessage("Found Email in Search Grid.");
                }
                PriorityQ.EnterSearchFilterValue_Clear();
                PriorityQ.Click_ResetButton();
                PriorityQ.EnterSearchFilterValue(custData.Email);
                ElementClick(Driver.FindElement(By.XPath("//table[@id='reservation_results']//button[contains(@class, 'editReservation')]")));
                AddDelay(20000);
                Driver.SwitchTo().ParentFrame();
                Driver.SwitchTo().Frame(0);
                ElementWait(Driver.FindElement(By.Id("email_compliance_check")), 60);
                if (IsElementPresent(By.Id("email_compliance_check")))
                {
                    Logger.WriteDebugMessage("Landed on Edit Reservation Page.");
                }
                else
                {
                    Assert.Fail("Did not land on edit Reservation Page");
                }
            }
            else
            {
                Assert.Fail("Did not land on PriorityQ - Reservation Page.");
            }
        }
        public static void TC_267308()
        {
            int customerID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "CustomerID", TestPlanId));
            int sourceGuestID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "SourceGuestID", TestPlanId));
            int emailID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName("NA", "EmailID", TestPlanId));
            Logger.WriteInfoMessage("/*----------PreRequisite--------*/");
            string result = setPrerequisite(CompanyName, customerID, sourceGuestID, emailID, 1);

            Logger.WriteInfoMessage(result);
            Logger.WriteInfoMessage("/*--------End of PreRequisite--------*/");

            ProfileCustData custData = new ProfileCustData();

            string arrivalDate = "";
            string departureDate = "";
            string ResCreationDate = "";
            string updateDate = "";

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 1, "", "", clientName, "1");

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

                if ((IsElementPresent(By.XPath("(//table[@id='reservation_results']//following::*[contains(text(), '"+ custData.Email +"')])[1]"))))
                {
                    string message = "User did appeared on the page.";
                    message = message + "\n Name: " + custData.FullName; ;
                    message = message + "\n Email: " + custData.Email;
                    message = message + "\n Property: " + custData.PropertyName;
                    message = message + "\n Reservation Number: " + custData.ReservationNumber;
                    message = message + "\n Sub-Reservation Number: " + custData.SubReservationNumber;
                    message = message + "\n Reservation Status: " + custData.ReservationStatus;
                    message = message + "\n ArrivalDate: " + arrivalDate;
                    message = message + "\n DepartureDate: " + departureDate;
                    message = message + "\n ReservationCreationDate: " + ResCreationDate;

                    Logger.WriteDebugMessage(message);
                }
                else
                {
                    Assert.Fail("User appeared for the property which does not have access to the property.");
                }
            }
        }
        public static void TC_283238()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);
            int customerID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "CustomerID"));
            int sourceGuestID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "SourceGuestID"));
            int emailID = Convert.ToInt32(SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "EmailID"));
            Logger.WriteInfoMessage("/*----------PreRequisite--------*/");
            string result = setPrerequisite(CompanyName, customerID, sourceGuestID, emailID, 0);

            Logger.WriteInfoMessage(result);
            Logger.WriteInfoMessage("/*--------End of PreRequisite--------*/");

            ProfileCustData custData = new ProfileCustData();

            string arrivalDate = "";
            string departureDate = "";
            string ResCreationDate = "";
            string updateDate = "";

            SqlWarehouseQuery.GetStayDetails(CompanyName, custData, LegacyTestData.CommonFrontendEmail, 1, "", "", clientName, "0");
            
            CampaignDetails campaignData = new CampaignDetails();
            SqlWarehouseQuery.GetCampaignDetails(campaignData, CompanyName, projectID);

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

                string getEmailValue = Driver.FindElement(By.XPath("//table[@id = 'reservation_results']//following::tr//td[2]")).Text;

                if (String.IsNullOrEmpty(getEmailValue))
                {
                    Logger.WriteDebugMessage("Found Blank Email Address for Reservation - " + custData.ReservationNumber);
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
                    }
                }
                else
                {
                    Assert.Fail("Email address is not blank on search grid.");
                }
            }
        }
    }
    #endregion[TP_271585]
}
