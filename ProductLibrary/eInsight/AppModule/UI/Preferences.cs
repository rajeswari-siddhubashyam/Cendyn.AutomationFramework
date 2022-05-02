using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseUtility.Utility;
using InfoMessageLogger;
using Common;
using OpenQA.Selenium;
using eInsight.PageObject.UI;
using eInsight.Utility;
using BaseUtility.Utility.Hotmail;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;
using SqlWarehouse;

namespace eInsight.AppModule.UI
{
    class Preferences : Helper
    {
        public static void VerifyDatePreferenceOnAudienceSearchGrid(string selectedRegion, string date)
        {
            if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
            {
                string dateconvert = Convert.ToDateTime(date).ToString("d.M.yyyy");
                if (VerifyTextOnPage(dateconvert))
                {
                    Logger.WriteDebugMessage("Found date" + dateconvert);
                }
                else
                {
                    Assert.Fail("Could not find date" + dateconvert);
                }

            }
            else if (selectedRegion == "India (English)")
            {
                string dateconvert = Convert.ToDateTime(date).ToString("d-MM-yyyy");
                if (VerifyTextOnPage(dateconvert))
                {
                    Logger.WriteDebugMessage("Found date" + dateconvert);
                }
                else
                {
                    Assert.Fail("Could not find date" + dateconvert);
                }
            }
            else
            {
                Assert.Fail("Select the appropriate region to check date.");
            }
        }
        public static void VerifyDatePreferenceOnManageCampaign(string selectedRegion, string date)
        {
            if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
            {
                string dateconvert = Convert.ToDateTime(date).ToString("d.M.yyyy");
                if (VerifyTextOnPage(dateconvert))
                {
                    Logger.WriteDebugMessage("Found date" + dateconvert);
                }
                else
                {
                    Assert.Fail("Could not find date" + dateconvert);
                }

            }
            else if (selectedRegion == "India (English)")
            {
                string dateconvert = Convert.ToDateTime(date).ToString("d-MM-yyyy");
                if (VerifyTextOnPage(dateconvert))
                {
                    Logger.WriteDebugMessage("Found date" + dateconvert);
                }
                else
                {
                    Assert.Fail("Could not find date" + dateconvert);
                }
            }
            else
            {
                Assert.Fail("Select the appropriate region to check date.");
            }
        }

        public static void VerifyDateForManageCampaignPerProjectStatus(string eachStatus, string region, CampaignDetails data)
        {
            switch(eachStatus)
            {
                case "Approved":
                    ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Approved')]")));
                    Logger.WriteDebugMessage("Clicked on " + eachStatus + " status.");
                    VerifyDatePreferenceOnManageCampaign(region, data.RequestDate);
                    break;
                case "Scheduled Active":
                    ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Scheduled Active')]")));
                    Logger.WriteDebugMessage("Clicked on " + eachStatus + " status.");
                    VerifyDatePreferenceOnManageCampaign(region, data.DateSubmitted);
                    break;
            }
        }

        public static void ManageCampaignDateCheck(string selectedRegion, string company)
        {
            CampaignDetails CampaignDetails = new CampaignDetails();
            SqlWarehouseQuery.GetManageCampaignDateDetails(company, CampaignDetails);

            UserActions.SelectPreferredRegion(selectedRegion);
            string iFrameManageCampaign = "//iframe[@name='ManageCampaign']";
            ManageCampaign.PreSearchCampaign_New(company, "ProjectID", CampaignDetails.ParentProjectID, iFrameManageCampaign);
            AddDelay(25000);
            Logger.WriteDebugMessage("Landed on Manage Campaign Page for Property: " + CampaignDetails.ParentCompanyName);

            if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
            {
                string campDateSubDateconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("d.M.yyyy");
                string profUpdateDateconvert = Convert.ToDateTime(CampaignDetails.LastUpdated).ToString("d.M.yyyy");

                if (VerifyTextOnPage(profUpdateDateconvert))
                {
                    Logger.WriteDebugMessage("Checked for Campaign's Update Date - " + profUpdateDateconvert + " for ProjectID - " + CampaignDetails.ParentProjectID);
                }
                else if (String.IsNullOrEmpty(profUpdateDateconvert))
                {
                    if (VerifyTextOnPage("N/A"))
                    {
                        Logger.WriteDebugMessage("Checked for Campaign's Update Date - " + profUpdateDateconvert + " for ProjectID - " + CampaignDetails.ParentProjectID);
                    }
                }
                else
                {
                    Assert.Fail("Update Date for ProjectID - " + CampaignDetails.ParentProjectID + " was not found. Expected Date - " + profUpdateDateconvert);
                }
            }
            else if (selectedRegion == "India (English)")
            {

                string campDateSubDateconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("dd-MM-yyyy");
                string profUpdateDateconvert = Convert.ToDateTime(CampaignDetails.LastUpdated).ToString("dd-MM-yyyy");

                if (VerifyTextOnPage(profUpdateDateconvert))
                {
                    Logger.WriteDebugMessage("Checked for Campaign's Update Date - " + profUpdateDateconvert + " for ProjectID - " + CampaignDetails.ParentProjectID);
                }
                else
                {
                    Assert.Fail("Update Date for ProjectID - " + CampaignDetails.ParentProjectID + " was not found. Expected Date - " + profUpdateDateconvert);
                }
            }
            Driver.SwitchTo().ParentFrame();
            ReloadPage();
        }

        public static void ProfileDateCheck(string selectedRegion, string company)
        {
            ProfileCustData ProfData = new ProfileCustData();
            SqlWarehouseQuery.GetProfileDetails(company, ProfData);
            while (String.IsNullOrEmpty(ProfData.Email))
            {
                SqlWarehouseQuery.GetProfileDetails(company, ProfData);
            }

            UserActions.SelectPreferredRegion(selectedRegion);


            Navigation.MenuNavigation("Profile");
            Profile.SelectSubClient(company);

            Profile.SelectSearchGuestsSearchBy("Customer ID");
            Profile.InsertTextSearchGuestsSearchFor(ProfData.CustomerID);
            Logger.WriteDebugMessage("Searching for an customer for a CustomerID: " + ProfData.CustomerID + " in profile search page.");
            Profile.ClickOpenProfile(ProfData.CustomerID);
            AddDelay(120000);
            ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, '#profile-div" + ProfData.CustomerID + "')]")), 120);

            if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
            {
                string profInsertDateconvert = Convert.ToDateTime(ProfData.InsertDate).ToString("d.M.yyyy");
                string profUpdateDateconvert = Convert.ToDateTime(ProfData.UpdateDate).ToString("d.M.yyyy");
                string profArrivalDateconvert = Convert.ToDateTime(ProfData.ArrivalDate).ToString("d.M.yyyy");
                string profDepartureDateconvert = Convert.ToDateTime(ProfData.DepartureDate).ToString("d.M.yyyy");
                string profCreationDateconvert = Convert.ToDateTime(ProfData.ResCreationDate).ToString("d.M.yyyy");

                ScrollToElement(Driver.FindElement(By.XPath("//img[contains(@id, 'profileimage')]")));

                if (VerifyTextOnPage(profInsertDateconvert) && VerifyTextOnPage(profUpdateDateconvert))
                {
                    Logger.WriteDebugMessage("InsertDate and Update is matching. InsertDate - " + profInsertDateconvert + " UpdateDate - " + profUpdateDateconvert);
                }
                else
                {
                    Assert.Fail("One of the date was not found in Profile Information Tab.");
                }

                ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '#stays-div" + ProfData.CustomerID + "')]")));
                AddDelay(50000);
                if (VerifyTextOnPage(profArrivalDateconvert) && VerifyTextOnPage(profDepartureDateconvert) && VerifyTextOnPage(profCreationDateconvert))
                {
                    Logger.WriteDebugMessage("InsertDate and Update is matching. InsertDate - " + profArrivalDateconvert + " UpdateDate - " + profDepartureDateconvert + " Creation Date - " + profCreationDateconvert);
                }
                else
                {
                    Assert.Fail("One of the date was not found in Stays Information Tab.");
                }
                Navigation.ClickHome();
            }
            else if (selectedRegion == "India (English)")
            {
                string profInsertDateconvert = Convert.ToDateTime(ProfData.InsertDate).ToString("d-MM-yyyy");
                string profUpdateDateconvert = Convert.ToDateTime(ProfData.UpdateDate).ToString("d-MM-yyyy");
                string profArrivalDateconvert = Convert.ToDateTime(ProfData.ArrivalDate).ToString("d-MM-yyyy");
                string profDepartureDateconvert = Convert.ToDateTime(ProfData.DepartureDate).ToString("d-MM-yyyy");
                string profCreationDateconvert = Convert.ToDateTime(ProfData.ResCreationDate).ToString("d-MM-yyyy");

                ScrollToElement(Driver.FindElement(By.XPath("//img[contains(@id, 'profileimage')]")));

                if (VerifyTextOnPage(profInsertDateconvert) && VerifyTextOnPage(profUpdateDateconvert))
                {
                    Logger.WriteDebugMessage("InsertDate and Update is matching. InsertDate - " + profInsertDateconvert + " UpdateDate - " + profUpdateDateconvert);
                }
                else
                {
                    Assert.Fail("One of the date was not found on Profile Information Tab.");
                }

                ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '#stays-div" + ProfData.CustomerID + "')]")));
                AddDelay(50000);
                if (VerifyTextOnPage(profArrivalDateconvert) && VerifyTextOnPage(profDepartureDateconvert) && VerifyTextOnPage(profCreationDateconvert))
                {
                    Logger.WriteDebugMessage("InsertDate and Update is matching. InsertDate - " + profArrivalDateconvert + " UpdateDate - " + profDepartureDateconvert + " Creation Date - " + profCreationDateconvert);
                }
                else
                {
                    Assert.Fail("One of the date was not found on Stays Information Tab.");
                }
                Navigation.ClickHome();
            }
        }

        public static void ValidateDateFormat(string company, string childCompany)
        {

            string regionSelection = "Bulgaria (Bulgarian),Croatia (Croatian)";
            string[] eachRegion = Regex.Split(regionSelection, ",");
            foreach (string region in eachRegion)
            {
                UserActions.SelectPreferredRegion(region);

                string selectedRegion = region.ToString();

                ValidateDateFormatWithinPage(selectedRegion, company, childCompany);

            }
        }

        private static void ValidateDateFormatWithinPage(string selectedRegion, string company, string childCompany)
        {
            ProfileCustData ProfData = new ProfileCustData();

            if (selectedRegion == "Bulgaria (Bulgarian)" || selectedRegion == "Croatia (Croatian)")
            {
                var longdate = DateTime.Now.ToString("d.M.yyyy");
                VerifyTextOnPage(longdate);
                //Identifying Date Format in Profile Page
                Navigation.MenuNavigation("Profile");
                SqlWarehouseQuery.GetCustomerProfileData(ProfData, company, "US");
                Profile.SelectSearchGuestsSearchBy("Customer ID");
                Profile.InsertTextSearchGuestsSearchFor(ProfData.CustomerID);
                Logger.WriteDebugMessage("Searching for an customer for a CustomerID: " + ProfData.CustomerID + " in profile search page.");
                Profile.ClickOpenProfile(ProfData.CustomerID);
                ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, '#profile-div" + ProfData.CustomerID + "')]")), 120);
                ScrollToElement(Driver.FindElement(By.XPath("//a[contains(@href, '#profile-div" + ProfData.CustomerID + "')]")));

                var profDate = ProfData.InsertDate;
                string profDateconvert = Convert.ToDateTime(ProfData.InsertDate).ToString("d.M.yyyy");

                VerifyTextOnPage(profDateconvert);
                Logger.WriteDebugMessage("Profile Insert Date format matched with date " + profDateconvert);

                ManangeCampaignDateCheck(selectedRegion, company);

                Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "/Home.mvc");
                //Identifying Date Format in Profile Page
            }
            if (selectedRegion == "India (English)")
            {
                var longdate = DateTime.Now.ToString("dd-MM-yyyy");
                VerifyTextOnPage(longdate);
                //Identifying Date Format in Profile Page
                Navigation.MenuNavigation("Profile");
                SqlWarehouseQuery.GetCustomerProfileData(ProfData, company, "US");
                Profile.SelectSearchGuestsSearchBy("Customer ID");
                Profile.InsertTextSearchGuestsSearchFor(ProfData.CustomerID);
                Logger.WriteDebugMessage("Searching for an customer for a CustomerID: " + ProfData.CustomerID + " in profile search page.");
                Profile.ClickOpenProfile(ProfData.CustomerID);
                AddDelay(8000);
                ScrollToElement(Driver.FindElement(By.XPath("//a[contains(@href, '#profile-div" + ProfData.CustomerID + "')]")));

                var profDate = ProfData.InsertDate;
                string profDateconvert = Convert.ToDateTime(ProfData.InsertDate).ToString("dd-MM-yyyy");

                VerifyTextOnPage(profDateconvert);
                Logger.WriteDebugMessage("Profile Insert Date format matched with date " + profDateconvert);

                ManangeCampaignDateCheck(selectedRegion, company);
                Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "Home.mvc");
                //Identifying Date Format in Profile Page
            }
        }
        private static void ManangeCampaignDateCheck(string selectedRegion, string company)
        {
            CampaignDetails campaignData = new CampaignDetails();
            string projectID = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ProjectID");
            SqlWarehouseQuery.GetCampaignDetails(campaignData, company, projectID);
            Navigation.MenuNavigation("ManageCampaign");
            string iFrameManageCampaign = "//iframe[@name='ManageCampaign']";
            ManageCampaign.PreSearchCampaign_New(campaignData.CompanyName, "ProjectID", projectID, iFrameManageCampaign);

            Logger.WriteDebugMessage("Landed on Manage Campaign Page for Property: " + campaignData.ParentCompanyName + " - " + campaignData.ChildCampaignID);
            if (selectedRegion == "Bulgaria (Bulgarian)" || selectedRegion == "Croatia (Croatian)")
            {
                string profDateconvert = Convert.ToDateTime(campaignData.DateSubmitted).ToString("d.M.yyyy");
                VerifyTextOnPage(profDateconvert);
                Logger.WriteDebugMessage("Found Date Format");
            }
            if (selectedRegion == "India (English)")
            {
                string profDateconvert = Convert.ToDateTime(campaignData.DateSubmitted).ToString("dd-MM-yyyy");
                VerifyTextOnPage(profDateconvert);
                Logger.WriteDebugMessage("Found Date Format");
            }
        }
        public static void ViewAllActivityDateCheck(string selectedRegion, string company, string selectTab)
        {
            CampaignDetails CampaignDetails = new CampaignDetails();
            //SqlWarehouseQuery.GetManageCampaignDateDetails(company, CampaignDetails);
            string campDateSubmittedconvert;

            switch (selectTab)
            {
                case "All":
                    SqlWarehouseQuery.GetProjectEventDetails(CampaignDetails, "All");
                    ElementClick(Driver.FindElement(By.XPath("//span[contains(text(),'All Activity')]")));
                    if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("d.M.yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else if (selectedRegion == "India (English)")
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("dd-MM-yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else
                    {
                        Assert.Fail("Expected date for " + selectTab + " tab was not found. \nProjectID - " + CampaignDetails.ParentProjectID + ". \nExpected date - " + CampaignDetails.LastUpdated + ". \nFor Region - " + selectedRegion);
                    }
                    break;
                case "Created":
                    SqlWarehouseQuery.GetProjectEventDetails(CampaignDetails, "Created");
                    Home.Click_Home_Link_AtAGlance_GoToTab_Menu("Created");
                    if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("d.M.yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else if (selectedRegion == "India (English)")
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("dd-MM-yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else
                    {
                        Assert.Fail("Expected date for " + selectTab + " tab was not found. \nProjectID - " + CampaignDetails.ParentProjectID + ". \nExpected date - " + CampaignDetails.LastUpdated + ". \nFor Region - " + selectedRegion);
                    }
                    break;
                case "CriteriaChanged":
                    SqlWarehouseQuery.GetProjectEventDetails(CampaignDetails, "CriteriaChanged");
                    Home.Click_Home_Link_AtAGlance_GoToTab_Menu("Criteria Changed");

                    if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("d.M.yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else if (selectedRegion == "India (English)")
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("dd-MM-yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else
                    {
                        Assert.Fail("Expected date for " + selectTab + " tab was not found. \nProjectID - " + CampaignDetails.ParentProjectID + ". \nExpected date - " + CampaignDetails.LastUpdated + ". \nFor Region - " + selectedRegion);
                    }
                    break;
                case "TemplateChanged":
                    SqlWarehouseQuery.GetProjectEventDetails(CampaignDetails, "TemplateChanged");

                    Home.Click_Home_Link_AtAGlance_GoToTab_Menu("Template Changed");
                    if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("d.M.yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else if (selectedRegion == "India (English)")
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("dd-MM-yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else
                    {
                        Assert.Fail("Expected date for " + selectTab + " tab was not found. \nProjectID - " + CampaignDetails.ParentProjectID + ". \nExpected date - " + CampaignDetails.LastUpdated + ". \nFor Region - " + selectedRegion);
                    }
                    break;
                case "SendToTestEmailsRequested":
                    SqlWarehouseQuery.GetProjectEventDetails(CampaignDetails, "SendToTestEmailsRequested");

                    Home.Click_Home_Link_AtAGlance_GoToTab_Menu("Send To Test Emails");
                    if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("d.M.yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else if (selectedRegion == "India (English)")
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("dd-MM-yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else
                    {
                        Assert.Fail("Expected date for " + selectTab + " tab was not found. \nProjectID - " + CampaignDetails.ParentProjectID + ". \nExpected date - " + CampaignDetails.LastUpdated + ". \nFor Region - " + selectedRegion);
                    }
                    break;
                case "DeliverabilityReportRequested":
                    SqlWarehouseQuery.GetProjectEventDetails(CampaignDetails, "DeliverabilityReportRequested");
                    Home.Click_Home_Link_AtAGlance_GoToTab_Menu("Delivery Report Requested");

                    if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("d.M.yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else if (selectedRegion == "India (English)")
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("dd-MM-yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else
                    {
                        Assert.Fail("Expected date for " + selectTab + " tab was not found. \nProjectID - " + CampaignDetails.ParentProjectID + ". \nExpected date - " + CampaignDetails.LastUpdated + ". \nFor Region - " + selectedRegion);
                    }
                    break;
                case "DeliverabilityReportReceived":
                    SqlWarehouseQuery.GetProjectEventDetails(CampaignDetails, "DeliverabilityReportReceived");
                    Home.Click_Home_Link_AtAGlance_GoToTab_Menu("Delivery Report Received");

                    if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("d.M.yyyy");
                        if(campDateSubmittedconvert.Contains("0001"))
                        {
                            Assert.Fail("No records found for tab - " + selectTab);
                        }
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else if (selectedRegion == "India (English)")
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("dd-MM-yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else
                    {
                        Assert.Fail("Expected date for " + selectTab + " tab was not found. \nProjectID - " + CampaignDetails.ParentProjectID + ". \nExpected date - " + CampaignDetails.LastUpdated + ". \nFor Region - " + selectedRegion);
                    }
                    break;
                case "ProceedForApprovalRequested":
                    SqlWarehouseQuery.GetProjectEventDetails(CampaignDetails, "ProceedForApprovalRequested");
                    Home.Click_Home_Link_AtAGlance_GoToTab_Menu("Proceed For Approval");

                    if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("d.M.yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else if (selectedRegion == "India (English)")
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("dd-MM-yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else
                    {
                        Assert.Fail("Expected date for " + selectTab + " tab was not found. \nProjectID - " + CampaignDetails.ParentProjectID + ". \nExpected date - " + CampaignDetails.LastUpdated + ". \nFor Region - " + selectedRegion);
                    }
                    break;
                case "ApprovalRequested":
                    SqlWarehouseQuery.GetProjectEventDetails(CampaignDetails, "ApprovalRequested");
                    Home.Click_Home_Link_AtAGlance_GoToTab_Menu("Approval Requested");

                    if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("d.M.yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else if (selectedRegion == "India (English)")
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("dd-MM-yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else
                    {
                        Assert.Fail("Expected date for " + selectTab + " tab was not found. \nProjectID - " + CampaignDetails.ParentProjectID + ". \nExpected date - " + CampaignDetails.LastUpdated + ". \nFor Region - " + selectedRegion);
                    }
                    break;
                case "Approved":
                    SqlWarehouseQuery.GetProjectEventDetails(CampaignDetails, "Approved");
                    Home.Click_Home_Link_AtAGlance_GoToTab_Menu("Approved");

                    if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("d.M.yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else if (selectedRegion == "India (English)")
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("dd-MM-yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else
                    {
                        Assert.Fail("Expected date for " + selectTab + " tab was not found. \nProjectID - " + CampaignDetails.ParentProjectID + ". \nExpected date - " + CampaignDetails.LastUpdated + ". \nFor Region - " + selectedRegion);
                    }
                    break;
                case "Disapproved":
                    SqlWarehouseQuery.GetProjectEventDetails(CampaignDetails, "Disapproved");
                    Home.Click_Home_Link_AtAGlance_GoToTab_Menu("Disapproved");

                    if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("d.M.yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else if (selectedRegion == "India (English)")
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("dd-MM-yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else
                    {
                        Assert.Fail("Expected date for " + selectTab + " tab was not found. \nProjectID - " + CampaignDetails.ParentProjectID + ". \nExpected date - " + CampaignDetails.LastUpdated + ". \nFor Region - " + selectedRegion);
                    }
                    break;
                case "Scheduled":
                    SqlWarehouseQuery.GetProjectEventDetails(CampaignDetails, "Scheduled");
                    Home.Click_Home_Link_AtAGlance_GoToTab_Menu("Scheduled");

                    if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("d.M.yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else if (selectedRegion == "India (English)")
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("dd-MM-yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else
                    {
                        Assert.Fail("Expected date for " + selectTab + " tab was not found. \nProjectID - " + CampaignDetails.ParentProjectID + ". \nExpected date - " + CampaignDetails.LastUpdated + ". \nFor Region - " + selectedRegion);
                    }
                    break;
                case "Rescheduled":
                    SqlWarehouseQuery.GetProjectEventDetails(CampaignDetails, "Rescheduled");
                    Home.Click_Home_Link_AtAGlance_GoToTab_Menu("Rescheduled");

                    if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("d.M.yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else if (selectedRegion == "India (English)")
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("dd-MM-yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else
                    {
                        Assert.Fail("Expected date for " + selectTab + " tab was not found. \nProjectID - " + CampaignDetails.ParentProjectID + ". \nExpected date - " + CampaignDetails.LastUpdated + ". \nFor Region - " + selectedRegion);
                    }
                    break;
                case "CampaignScheduleDeactivated":
                    SqlWarehouseQuery.GetProjectEventDetails(CampaignDetails, "CampaignScheduleDeactivated");
                    Home.Click_Home_Link_AtAGlance_GoToTab_Menu("Schedule Deactivated");

                    if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("d.M.yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else if (selectedRegion == "India (English)")
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("dd-MM-yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else
                    {
                        Assert.Fail("Expected date for " + selectTab + " tab was not found. \nProjectID - " + CampaignDetails.ParentProjectID + ". \nExpected date - " + CampaignDetails.LastUpdated + ". \nFor Region - " + selectedRegion);
                    }
                    break;
                case "SendHistory":
                    SqlWarehouseQuery.GetProjectEventDetails(CampaignDetails, "SendHistory");
                    Home.Click_Home_Link_AtAGlance_GoToTab_Menu("Sent");

                    if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("d.M.yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else if (selectedRegion == "India (English)")
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("dd-MM-yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else
                    {
                        Assert.Fail("Expected date for " + selectTab + " tab was not found. \nProjectID - " + CampaignDetails.ParentProjectID + ". \nExpected date - " + CampaignDetails.LastUpdated + ". \nFor Region - " + selectedRegion);
                    }
                    break;
                case "Cancelled":
                    SqlWarehouseQuery.GetProjectEventDetails(CampaignDetails, "Cancelled");
                    Home.Click_Home_Link_AtAGlance_GoToTab_Menu("Cancelled");

                    if ((selectedRegion == "Bulgaria (Bulgarian)") || (selectedRegion == "Croatia (Croatian)"))
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("d.M.yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else if (selectedRegion == "India (English)")
                    {
                        campDateSubmittedconvert = Convert.ToDateTime(CampaignDetails.DateSubmitted).ToString("dd-MM-yyyy");
                        if (VerifyTextOnPage(campDateSubmittedconvert))
                        {
                            Logger.WriteDebugMessage("Checked Date for " + selectTab);
                        }
                        else
                        {
                            Assert.Fail("Could not find Date for " + selectTab);
                        }
                    }
                    else
                    {
                        Assert.Fail("Expected date for " + selectTab + " tab was not found. \nProjectID - " + CampaignDetails.ParentProjectID + ". \nExpected date - " + CampaignDetails.LastUpdated + ". \nFor Region - " + selectedRegion);
                    }
                    break;
            }

        }

        public static void VerifyDatePreference_ManageCampaign_History(string selectedRegion, string projectID, string companyName)
        {
            CampaignDetails data = new CampaignDetails();
            SqlWarehouseQuery.GetProjectEvents(data, companyName, projectID);
            string getDate = Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[2]/div/div/div[2]/table/tr[1]/td[2]/p[2]")).Text;
            if (selectedRegion == "Bulgaria (Bulgarian)" || selectedRegion == "Croatia (Croatian)")
            {
                string dateconvert = Convert.ToDateTime(data.ModifiedOn).ToString("d.M.yyyy");
                if (getDate.Contains(dateconvert))
                {
                    Logger.WriteDebugMessage("Found Date Format");
                }
                else
                {
                    Assert.Fail("Could not find preference date in History Log in Manage Campaign for ProjectID - " + projectID +" for region " + selectedRegion);
                }
            }
            if (selectedRegion == "India (English)")
            {
                string dateconvert = Convert.ToDateTime(data.ModifiedOn).ToString("dd-MM-yyyy");
                if (getDate.Contains(dateconvert))
                {
                    Logger.WriteDebugMessage("Found Date Format");
                }
                else
                {
                    Assert.Fail("Could not find preference date in History Log in Manage Campaign for ProjectID - " + projectID + " for region " + selectedRegion);
                }
            }
        }

        public static void VerifyDatePreference_TemplateBuilder(string selectedRegion, string modifiedDate)
        {
            if (selectedRegion == "Bulgaria (Bulgarian)" || selectedRegion == "Croatia (Croatian)")
            {
                string dateconvert = Convert.ToDateTime(modifiedDate).ToString("d.M.yyyy");
                if (VerifyTextOnPage(dateconvert))
                {
                    Logger.WriteDebugMessage("Found Date Format on Template Page.");
                }
                else
                {
                    Assert.Fail("Found Date Format on Template Page.");
                }
            }
            if (selectedRegion == "India (English)")
            {
                string dateconvert = Convert.ToDateTime(modifiedDate).ToString("d-MM-yyyy");
                if (VerifyTextOnPage(dateconvert))
                {
                    Logger.WriteDebugMessage("Found Date Format on Template Page.");
                }
                else
                {
                    Assert.Fail("Found Date Format on Template Page.");
                }
            }
        }
    }
}
