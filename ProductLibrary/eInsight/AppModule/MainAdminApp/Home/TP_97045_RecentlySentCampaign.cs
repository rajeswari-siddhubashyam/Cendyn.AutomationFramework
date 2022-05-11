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
        private static string dateRange = "";
        #region[TP_97045]
        #region[MarketingTab]
        public static void TC_85789()
        {
            CampaignReportDetails reportDetails = new CampaignReportDetails();
            
            Profile.SelectSubClient(clientNameByTestCase);
            
            ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));
            SqlWarehouseQuery.CampaignReport("NetClick", "Marketing", companyNameByTestCase, clientNameByTestCase, reportDetails);

            if (String.IsNullOrEmpty(reportDetails.CampaignName))
            {
                Assert.Fail("No Campaign Net Click report available.");
            }
            else
            {
                Home.Click_DropDown_DateRange(reportDetails.DateRange.Replace(" Months", ""), "Marketing");
                Logger.WriteDebugMessage("Clicked " + reportDetails.DateRange);

                Home.Click_DropDown_DataTableRange("Marketing", "500");

                VerifyTextOnPage(reportDetails.CampaignName);

                Logger.WriteDebugMessage("Found CampaignName - " + reportDetails.CampaignName);
            }
        }
        public static void TC_129807()
        {
                       
            Profile.SelectSubClient(clientNameByTestCase);
            AddDelay(5000);
            ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));

            dateRange = "1 Month,2 Months,3 Months,6 Months,12 Months";
            string[] dateRangeSplit = Regex.Split(dateRange, ",");
            foreach (string eachDateRange in dateRangeSplit)
            {
                Home.Click_DropDown_DateRange(eachDateRange.Replace(" Months", "").Replace(" Month", ""), "Marketing");
                Logger.WriteDebugMessage("Clicked " + eachDateRange);
            }
        }
        public static void TC_251644()
        {
            CampaignReportDetails reportDetails = new CampaignReportDetails();
            
            //Profile.SelectSubClient(clientNameByTestCase);
            
            ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));
            SqlWarehouseQuery.CampaignReport("Others", "Marketing", companyNameByTestCase, clientNameByTestCase, reportDetails);

            if (String.IsNullOrEmpty(reportDetails.DateRange))
            {
                Assert.Fail("No Data are available.");
            }
            else
            {
                Profile.SelectSubClient(reportDetails.CompanyName);
                Home.Click_DropDown_DateRange(reportDetails.DateRange.Replace(" Months",""), "Marketing");
                Logger.WriteDebugMessage("Clicked " + reportDetails.DateRange);

                Home.Click_DropDown_DataTableRange("Marketing", "500");

                VerifyTextOnPage(reportDetails.CampaignName);
                VerifyTextOnPage(reportDetails.Subject);
                VerifyTextOnPage(reportDetails.SendDate);
                ScrollToElement(Driver.FindElement(By.XPath("//td[contains(text(), '" + reportDetails.CampaignName + "')]")));
                Logger.WriteDebugMessage("Found report with CampaignName:" + reportDetails.CampaignName + "\n Subject:" + reportDetails.CampaignName + "\n SendDate: " + reportDetails.SendDate);
            }
        }
        public static void TC_251645()
        {
            CampaignReportDetails reportDetails = new CampaignReportDetails();
            
            //Profile.SelectSubClient(clientNameByTestCase);
            ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));
            SqlWarehouseQuery.CampaignReport("GetCountDetails", "Marketing", companyNameByTestCase, clientNameByTestCase, reportDetails);

            if (String.IsNullOrEmpty(reportDetails.DateRange))
            {
                Assert.Fail("No Data are available.");
            }
            else
            {
                Profile.SelectSubClient(reportDetails.CompanyName);
                Home.Click_DropDown_DateRange(reportDetails.DateRange.Replace(" Months", ""), "Marketing");
                Logger.WriteDebugMessage("Clicked " + reportDetails.DateRange);

                Home.Click_DropDown_DataTableRange("Marketing", "500");

                //Home.GetCountDetails(reportDetails, "Other", "Marketing");

                VerifyTextOnPage(reportDetails.CampaignName);
                VerifyTextOnPage(reportDetails.Subject);
                VerifyTextOnPage(reportDetails.SendDate);
                ScrollToElement(Driver.FindElement(By.XPath("//td[contains(text(), '" + reportDetails.CampaignName + "')]")));
                Logger.WriteDebugMessage("Found report with CampaignName:" + reportDetails.CampaignName + "\n Subject:" + reportDetails.CampaignName + "\n SendDate: " + reportDetails.SendDate + " with SendCount" + reportDetails.SendCount + " , DeliveredCount" + reportDetails.DeliverCount + " , OpenCount" + reportDetails.OpenCount);
            }
        }
        public static void TC_251646()
        {
           CampaignReportDetails reportDetails = new CampaignReportDetails();
           
            //Profile.SelectSubClient(clientNameByTestCase);

            ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));
            SqlWarehouseQuery.CampaignReport("NetOpen", "Marketing", companyNameByTestCase, clientNameByTestCase, reportDetails);

            if (String.IsNullOrEmpty(reportDetails.DateRange))
            {
                Assert.Fail("No Data are available.");
            }
            else
            {
                Profile.SelectSubClient(reportDetails.CompanyName);
                Home.Click_DropDown_DateRange(reportDetails.DateRange.Replace(" Months", ""), "Marketing");
                Logger.WriteDebugMessage("Clicked " + reportDetails.DateRange);

                Home.Click_DropDown_DataTableRange("Marketing", "500");

                //Home.GetCountDetails(reportDetails, "NetOpen", "Marketing");

                VerifyTextOnPage(reportDetails.CampaignName);
                VerifyTextOnPage(reportDetails.Subject);
                VerifyTextOnPage(reportDetails.SendDate);
                ScrollToElement(Driver.FindElement(By.XPath("//td[contains(text(), '" + reportDetails.CampaignName + "')]")));
                Logger.WriteDebugMessage("Found report with CampaignName:" + reportDetails.CampaignName + "\n Subject:" + reportDetails.CampaignName+ "\n with NetOpen " + reportDetails.UniqueOpenCount);
            }
        }
        public static void TC_251699()
        {
            CampaignReportDetails reportDetails = new CampaignReportDetails();
            
            ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));
            SqlWarehouseQuery.CampaignReport("GetCountDetails", "Marketing", companyNameByTestCase, clientNameByTestCase, reportDetails);

            if (String.IsNullOrEmpty(reportDetails.DateRange))
            {
                Assert.Fail("No Data are available.");
            }
            else
            {
                Profile.SelectSubClient(reportDetails.CompanyName);

                Home.Click_DropDown_DateRange(reportDetails.DateRange.Replace(" Months", ""), "Marketing");
                Logger.WriteDebugMessage("Clicked " + reportDetails.DateRange);

                Home.Click_DropDown_DataTableRange("Marketing", "500");

                Home.NavigatetoManageCampaign(reportDetails, "Marketing");
            }
        }
        #endregion[MarketingTab]
        #region[TransactionalTab]
        public static void TC_98348()
        {
            CampaignReportDetails reportDetails = new CampaignReportDetails();
            SqlWarehouseQuery.GetTransactional_Report(reportDetails, CompanyName);
            string getCompanyName = SqlWarehouseQuery.GetCompanyName(reportDetails.CompanyID);

            if (string.IsNullOrEmpty(reportDetails.CampaignName))
            {
                Assert.Fail("No TransactionalCampaign found");
            }
            //SqlWarehouseQuery.CampaignReport_Transactional("GetCountDetails", "Transactional", companyNameByTestCase, reportDetails);
            
            else
            {
                Profile.SelectSubClient(getCompanyName);
                ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));
                ElementClick(Driver.FindElement(By.XPath("//a[@id ='RecentCampaignsTransactional']")));
                Logger.WriteDebugMessage("Landed on Transactional Page");

                //Home.Click_DropDown_DataTableRange("Transactional", "Custom");
                Home.Select_DateRange("-1");
                Home.Enter_StartDate(reportDetails.SendDate);
                Home.Enter_EndDate(reportDetails.SendDate);
                Home.Enter_EmailAddress(reportDetails.Email);
                Home.Enter_ResNum(reportDetails.ReservationNumber);

                Home.Click_Search();
                ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), '" + reportDetails.CampaignName + "')]")));
                if (IsElementPresent(By.XPath("//table[@id='RealTimeCampaignsDt_Table']//following::*[contains(text(), '"+ reportDetails.ReservationNumber + "')]")))
                {
                    Logger.WriteDebugMessage("Found Reservation Number:" + reportDetails.ReservationNumber);
                }
                else
                {
                    Assert.Fail("Could not find Reservation Number:" + reportDetails.ReservationNumber);
                }
            }
        }
        public static void TC_98234()
        {
            CampaignReportDetails reportDetails = new CampaignReportDetails();
            SqlWarehouseQuery.GetTransactional_Report(reportDetails, CompanyName);
            string getCompanyName = SqlWarehouseQuery.GetCompanyName(reportDetails.CompanyID);

            if (string.IsNullOrEmpty(reportDetails.CampaignName))
            {
                Assert.Fail("No TransactionalCampaign found");
            }
            else
            {
                Profile.SelectSubClient(getCompanyName);
                ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));
                ElementClick(Driver.FindElement(By.XPath("//a[@id ='RecentCampaignsTransactional']")));
                Logger.WriteDebugMessage("Landed on Transactional Page");

                //Home.Click_DropDown_DataTableRange("Transactional", "Custom");
                Home.Select_DateRange("-1");
                Home.Enter_StartDate(reportDetails.SendDate);
                Home.Enter_EndDate(reportDetails.SendDate);
                Home.Enter_EmailAddress(reportDetails.Email);
                Home.Enter_ResNum(reportDetails.ReservationNumber);

                Home.Click_Search();
                ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), '" + reportDetails.CampaignName + "')]")));
                if (IsElementPresent(By.XPath("//table[@id='RealTimeCampaignsDt_Table']//following::*[contains(text(), '" + reportDetails.Email + "')]")))
                {
                    Logger.WriteDebugMessage("Found Email Address:" + reportDetails.Email);
                }
                else
                {
                    Assert.Fail("Could not find Email Address:" + reportDetails.Email);
                }
            }
        }
        public static void TC_98111()
        {
            CampaignReportDetails reportDetails = new CampaignReportDetails();
            SqlWarehouseQuery.GetTransactional_Report(reportDetails, CompanyName);
            string getCompanyName = SqlWarehouseQuery.GetCompanyName(reportDetails.CompanyID);

            if (string.IsNullOrEmpty(reportDetails.CampaignName))
            {
                Assert.Fail("No TransactionalCampaign found");
            }
            //SqlWarehouseQuery.CampaignReport_Transactional("GetCountDetails", "Transactional", companyNameByTestCase, reportDetails);

            else
            {
                Profile.SelectSubClient(getCompanyName);
                ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));
                ElementClick(Driver.FindElement(By.XPath("//a[@id ='RecentCampaignsTransactional']")));
                Logger.WriteDebugMessage("Landed on Transactional Page");

                //Home.Click_DropDown_DataTableRange("Transactional", "Custom");
                Home.Select_DateRange("-1");
                Home.Enter_StartDate(reportDetails.SendDate);
                Home.Enter_EndDate(reportDetails.SendDate);
                Home.Enter_EmailAddress(reportDetails.Email);
                Home.Enter_ResNum(reportDetails.ReservationNumber);

                Home.Click_Search();
                ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), '" + reportDetails.CampaignName + "')]")));
                if (IsElementPresent(By.XPath("//table[@id='RealTimeCampaignsDt_Table']//following::*[contains(text(), '" + reportDetails.ReservationNumber + "')]")))
                {
                    Logger.WriteDebugMessage("Found Reservation Number:" + reportDetails.ReservationNumber);
                }
                else
                {
                    Assert.Fail("Could not find Reservation Number:" + reportDetails.ReservationNumber);
                }
            }
        }
        public static void TC_130057()
        {
            ElementWait(Driver.FindElement(By.XPath("//a[@id ='RecentCampaignsTransactional']")), 60);
            Profile.SelectSubClient(clientNameByTestCase);
            AddDelay(5000);
            ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));
            ElementClick(Driver.FindElement(By.XPath("//a[@id ='RecentCampaignsTransactional']")));
            string dateRange = "1 Day,2 Days,3 Days,7 Days,14 Days,30 Days,60 Days,90 Days,365 Days";
            string[] RangeSplit2 = Regex.Split(dateRange, ",");
            foreach (string eachDateRange in RangeSplit2)
            {
                Home.Click_DropDown_DateRange(eachDateRange.Replace(" Days", "").Replace(" Day", ""), "Transactional");

                Logger.WriteDebugMessage("Clicked " + eachDateRange);
            }
        }
        public static void TC_251656()
        {
            CampaignReportDetails reportDetails = new CampaignReportDetails();
            SqlWarehouseQuery.GetTransactional_Report(reportDetails, CompanyName);
            string getCompanyName = SqlWarehouseQuery.GetCompanyName(reportDetails.CompanyID);

            if (string.IsNullOrEmpty(reportDetails.CampaignName))
            {
                Assert.Fail("No TransactionalCampaign found");
            }
            else
            {
                Profile.SelectSubClient(getCompanyName);
                ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));
                ElementClick(Driver.FindElement(By.XPath("//a[@id ='RecentCampaignsTransactional']")));
                Logger.WriteDebugMessage("Landed on Transactional Page");

                //Home.Click_DropDown_DataTableRange("Transactional", "Custom");
                Home.Select_DateRange("-1");
                Home.Enter_StartDate(reportDetails.SendDate);
                Home.Enter_EndDate(reportDetails.SendDate);
                Home.Enter_EmailAddress(reportDetails.Email);
                Home.Enter_ResNum(reportDetails.ReservationNumber);

                Home.Click_Search();
                ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), '" + reportDetails.CampaignName + "')]")));
                if (IsElementPresent(By.XPath("//table[@id='RealTimeCampaignsDt_Table']//following::*[contains(text(), '" + reportDetails.CampaignName + "')]")))
                {
                    Logger.WriteDebugMessage("Found Email Address:" + reportDetails.CampaignName);
                }
                else
                {
                    Assert.Fail("Could not find Email Address:" + reportDetails.CampaignName);
                }
            }
        }
        public static void TC_251924()
        {
            CampaignReportDetails reportDetails = new CampaignReportDetails();
            SqlWarehouseQuery.GetTransactional_Report(reportDetails, CompanyName);
            string getCompanyName = SqlWarehouseQuery.GetCompanyName(reportDetails.CompanyID);

            if (string.IsNullOrEmpty(reportDetails.CampaignName))
            {
                Assert.Fail("No TransactionalCampaign found");
            }
            else
            {
                Profile.SelectSubClient(getCompanyName);
                ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));
                ElementClick(Driver.FindElement(By.XPath("//a[@id ='RecentCampaignsTransactional']")));
                Logger.WriteDebugMessage("Landed on Transactional Page");

                //Home.Click_DropDown_DataTableRange("Transactional", "Custom");
                Home.Select_DateRange("-1");
                Home.Enter_StartDate(reportDetails.SendDate);
                Home.Enter_EndDate(reportDetails.SendDate);
                Home.Enter_EmailAddress(reportDetails.Email);
                Home.Enter_ResNum(reportDetails.ReservationNumber);

                Home.Click_Search();
                ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), '" + reportDetails.CampaignName + "')]")));
                if (IsElementPresent(By.XPath("//table[@id='RealTimeCampaignsDt_Table']//following::*[contains(text(), '" + reportDetails.CampaignName + "')]")) && IsElementPresent(By.XPath("//table[@id='RealTimeCampaignsDt_Table']//following::*[contains(text(), '" + reportDetails.CampaignSubject + "')]")))
                {
                    Logger.WriteDebugMessage("Found Campaign Name:" + reportDetails.Email + " And Campaign Subject: " + reportDetails.CampaignSubject );
                }
                else
                {
                    Assert.Fail("Could not find Campaign Name:" + reportDetails.Email + " And Campaign Subject: " + reportDetails.CampaignSubject);
                }
            }
        }
        #endregion[TransactionalTab]
        #region[TriggerTab]
        public static void TC_251662()
        {
            CampaignReportDetails reportDetails = new CampaignReportDetails();

            SqlWarehouseQuery.CampaignReport("NetClick", "Transactional", companyNameByTestCase, clientNameByTestCase, reportDetails);

            Profile.SelectSubClient(reportDetails.CompanyName);

            ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));
            ElementClick(Driver.FindElement(By.Id("RecentCampaignsTrigger")));

            if (String.IsNullOrEmpty(reportDetails.DateRange))
            {
                Assert.Fail("No Data found.");
            }
            else
            {
                Home.Click_DropDown_DateRange(reportDetails.DateRange.Replace(" Months", ""), "Trigger");
                Logger.WriteDebugMessage("Clicked " + reportDetails.DateRange);

                Home.Click_DropDown_DataTableRange("Trigger", "500");

                if (VerifyTextOnPage(reportDetails.CampaignName))
                {
                    ScrollToElement(Driver.FindElement(By.XPath("//td[contains(text(), '" + reportDetails.CampaignName + "')]")));
                    Logger.WriteDebugMessage("Found CampaignName:" + reportDetails.CampaignName);
                }
                else
                {
                    Assert.Fail("Campaign Name did not appear on the Page" + reportDetails.CampaignName);
                }
            }
        }
        public static void TC_251664()
        {
            if (testCategory == "EU01_PostDeployment")
            {
                Profile.SelectSubClient(clientNameByTestCase);
            }
            AddDelay(5000);
            ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));
            
            ElementClick(Driver.FindElement(By.Id("RecentCampaignsTrigger")));
            dateRange = "1 Month,2 Months,3 Months,6 Months,12 Months";
            string[] RangeSplit = Regex.Split(dateRange, ",");
            foreach (string eachDateRange in RangeSplit)
            {
                Home.Click_DropDown_DateRange(eachDateRange.Replace(" Months", "").Replace(" Month", ""), "Trigger");
                Logger.WriteDebugMessage("Clicked " + eachDateRange);
            }
        }
        public static void TC_251666()
        {
            
            CampaignReportDetails reportDetails = new CampaignReportDetails();
            
            SqlWarehouseQuery.CampaignReport("Others", "Transactional", companyNameByTestCase, clientNameByTestCase, reportDetails);

            if (String.IsNullOrEmpty(reportDetails.DateRange))
            {
                Assert.Fail("No Data are available.");
            }
            else
            {
                Profile.SelectSubClient(reportDetails.CompanyName);

                ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));
                ElementClick(Driver.FindElement(By.Id("RecentCampaignsTrigger")));

                Home.Click_DropDown_DateRange(reportDetails.DateRange.Replace(" Months", ""), "Trigger");
                WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Processing...')]"), 120);
                Logger.WriteDebugMessage("Clicked " + reportDetails.DateRange);

                Home.Click_DropDown_DataTableRange("Trigger", "500");
                WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Processing...')]"), 120);

                if (VerifyTextOnPage(reportDetails.CampaignName)) //&& VerifyTextOnPage(reportDetails.Subject) && VerifyTextOnPage(reportDetails.SendDate))
                {
                    ScrollToElement(Driver.FindElement(By.XPath("//table[@id='TriggerCampaignsDt_table']//td[contains(text(), '" + reportDetails.CampaignName + "')]")));
                    Logger.WriteDebugMessage("Found report with CampaignName:" + reportDetails.CampaignName + "\n Subject:" + reportDetails.CampaignName + "\n SendDate: " + reportDetails.SendDate);
                }
                else
                {
                    Assert.Fail("Campaign details did not display on the page for" + reportDetails.CampaignName);
                }
                
            }
        }
        public static void TC_251667()
        {
            CampaignReportDetails reportDetails = new CampaignReportDetails();

            SqlWarehouseQuery.CampaignReport("GetCountDetails", "Transactional", companyNameByTestCase, clientNameByTestCase, reportDetails);

            if (String.IsNullOrEmpty(reportDetails.DateRange))
            {
                ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));
                ElementClick(Driver.FindElement(By.Id("RecentCampaignsTrigger")));
                if (!Home.NoResultText().Equals("No Results Available"))
                Assert.Fail("No Data are available.");
                Logger.WriteInfoMessage("Data is not available in the database and also on UI");
            }
            else
            {

                Profile.SelectSubClient(reportDetails.CompanyName);

                ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));
                ElementClick(Driver.FindElement(By.Id("RecentCampaignsTrigger")));
                
                Home.Click_DropDown_DateRange(reportDetails.DateRange.Replace(" Months", ""), "Trigger");
                WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Processing...')]"), 120);
                Logger.WriteDebugMessage("Clicked " + reportDetails.DateRange);

                Home.Click_DropDown_DataTableRange("Trigger", "500");
                WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Processing...')]"), 120);

                //Home.GetCountDetails(reportDetails, "Other", "Trigger");

                VerifyTextOnPage(reportDetails.CampaignName);
                VerifyTextOnPage(reportDetails.Subject);
                VerifyTextOnPage(reportDetails.SendDate);
                ScrollToElement(Driver.FindElement(By.XPath("//*[contains(text(), '" + reportDetails.CampaignName + "')]")));
                Logger.WriteDebugMessage("Found report with CampaignName:" + reportDetails.CampaignName + "\n Subject:" + reportDetails.CampaignName + "\n SendDate: " + reportDetails.SendDate + " with SendCount" + reportDetails.SendCount + " , DeliveredCount" + reportDetails.DeliverCount + " , OpenCount" + reportDetails.OpenCount);
            }
        }
        public static void TC_251668()
        {
            CampaignReportDetails reportDetails = new CampaignReportDetails();
            
            SqlWarehouseQuery.CampaignReport("NetOpen", "Transactional", companyNameByTestCase, clientNameByTestCase, reportDetails);

            Profile.SelectSubClient(reportDetails.CompanyName);

            ElementClick(Driver.FindElement(By.Id("RecentCampaignsTrigger")));

            ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));

            if (String.IsNullOrEmpty(reportDetails.DateRange))
            {
                if (!Home.NoResultText().Equals("No Results Available"))
                    Assert.Fail("No Data are available.");
                Logger.WriteInfoMessage("Data is not available in the database and also on UI");
            }
            else
            {
                Home.Click_DropDown_DateRange(reportDetails.DateRange.Replace(" Months", ""), "Trigger");
                AddDelay(15000);
                Logger.WriteDebugMessage("Clicked " + reportDetails.DateRange);

                Home.Click_DropDown_DataTableRange("Trigger", "500");
                AddDelay(120000);

                //Home.GetCountDetails(reportDetails, "NetOpen", "Trigger");
                VerifyTextOnPage(reportDetails.CampaignName);
                VerifyTextOnPage(reportDetails.Subject);
                VerifyTextOnPage(reportDetails.SendDate);
                ScrollToElement(Driver.FindElement(By.XPath("//td[contains(text(), '" + reportDetails.CampaignName + "')]")));
                Logger.WriteDebugMessage("Found report with CampaignName:" + reportDetails.CampaignName + "\n Subject:" + reportDetails.CampaignName + "\n with NetOpen " + reportDetails.UniqueOpenCount);
            }
        }
        public static void TC_251700()
        {
            CampaignReportDetails reportDetails = new CampaignReportDetails();
            
            ScrollToElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Recently Sent Campaigns')]")));
            
            SqlWarehouseQuery.CampaignReport("GetCountDetails", "Transactional", companyNameByTestCase, clientNameByTestCase, reportDetails);

            if (String.IsNullOrEmpty(reportDetails.DateRange))
            {
                ElementClick(Driver.FindElement(By.Id("RecentCampaignsTrigger")));
                if (!Home.NoResultText().Equals("No Results Available"))
                    Assert.Fail("No Data are available.");
                Logger.WriteInfoMessage("Data is not available in the database and also on UI");
            }
            else
            {
                Profile.SelectSubClient(reportDetails.CompanyName);

                ElementClick(Driver.FindElement(By.Id("RecentCampaignsTrigger")));
                Home.Click_DropDown_DateRange(reportDetails.DateRange.Replace(" Months", ""), "Trigger");
                AddDelay(15000);
                Logger.WriteDebugMessage("Clicked " + reportDetails.DateRange);

                Home.Click_DropDown_DataTableRange("Trigger", "500");
                AddDelay(120000);

                Home.NavigatetoManageCampaign(reportDetails, "Trigger");
            }
        }
        #endregion[TriggerTab]
        #endregion[TP_97045]
    }
}
