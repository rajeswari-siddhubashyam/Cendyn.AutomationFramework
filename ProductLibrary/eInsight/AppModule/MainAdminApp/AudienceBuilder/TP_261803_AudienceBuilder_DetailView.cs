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
using OpenQA.Selenium.Support.UI;
using BaseUtility.Utility.Hotmail;

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_261803]
        public static void TC_261806()
        {
            Profile.SelectSubClient(clientNameByTestCase);

            AudienceBuilderData builderData = new AudienceBuilderData();
            audienceName = SqlWarehouseQuery.ReturnCompanyName("NA", "AudienceName", "TP_240125") + TestPlanId;
            string dynamicCriteriaJSON = SqlWarehouseQuery.ReturnCompanyName("NA", "AudienceJSON", "TP_243513");
            AudienceBuilder.Prerequisite_CreateAudience(builderData, audienceName, CompanyName, dynamicCriteriaJSON);

            Navigation.MenuNavigation("AudienceBuilder");
            ElementEnterText(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), audienceName);
            AudienceBuilder.Click_SearchButton();
            WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
            AudienceBuilder.Click_ABGrid_LastSaved();
            AudienceBuilder.Click_ABGrid_Details();
            AddDelay(8000);

            SqlWarehouseQuery.getForeCastAudience(CompanyName, audienceName, builderData);
            string totalcount = "//*[contains(text(), 'Total Records')]//following::span[contains(text(), '" + builderData.CountTotal + "')]";
            string totalnullcount = "//*[contains(text(), 'Null')]//following::span[contains(text(), '" + builderData.CountNull + "')]";
            string totalInvalidcount = "//*[contains(text(), 'Invalid')]//following::span[contains(text(), '" + builderData.CountInvalid + "')]";
            string totalunsubcount = "//*[contains(text(), 'Unsubscribed')]//following::span[contains(text(), '" + builderData.CountUnsubscribed + "')]";
            string totalBouncecount = "//*[contains(text(), 'Bounced')]//following::span[contains(text(), '" + builderData.CountBounced + "')]";
            string totalNonConsentcount = "//*[contains(text(), 'Non-Consent')]//following::span[contains(text(), '" + builderData.CountNonConsent + "')]";
            string totalflagcount = "//*[contains(text(), 'Flagged')]//following::span[contains(text(), '" + builderData.CountFlagged + "')]";
            string totalValidcount = "//*[contains(text(), 'Valid')]//following::span[contains(text(), '" + builderData.CountValid + "')]";
            string totalUniquecount = "//*[contains(text(), 'Unique')]//following::span[contains(text(), '" + builderData.CountUnique + "')]";
            Driver.SwitchTo().ParentFrame();
            Driver.SwitchTo().Frame(0);
            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//div[@id='criteriaPreviewContainer1']//iframe")));
            if (!(VerifyTextOnPage("Counts Not Generated")))
            {
                ElementClick(Driver.FindElement(By.Id("btnCountsTrigger")));
            }
            //if (IsElementPresent((By.XPath(totalcount))))
            //if (IsElementPresent((By.XPath(totalInvalidcount))))
            //if (IsElementPresent((By.XPath(totalunsubcount))))
            //if (IsElementPresent((By.XPath(totalBouncecount))))
            //if (IsElementPresent((By.XPath(totalcount))))
            //if (IsElementPresent((By.XPath(totalNonConsentcount))))
            //if (IsElementPresent((By.XPath(totalflagcount))))
            //if (IsElementPresent((By.XPath(totalValidcount))))
            //if (IsElementPresent((By.XPath(totalUniquecount))))

            if ((IsElementPresent((By.XPath(totalcount)))) && (IsElementPresent((By.XPath(totalInvalidcount)))) && (IsElementPresent((By.XPath(totalunsubcount)))) && (IsElementPresent((By.XPath(totalBouncecount)))) && (IsElementPresent((By.XPath(totalcount)))) && (IsElementPresent((By.XPath(totalNonConsentcount)))) && (IsElementPresent((By.XPath(totalflagcount)))) && (IsElementPresent((By.XPath(totalValidcount)))) && (IsElementPresent((By.XPath(totalUniquecount)))))
            {
                string message = "Expected Result are as below - ";
                message = message + "\n TotalCount - " + builderData.CountTotal +
                                        "\n Null Count - " + builderData.CountNull +
                                        "\n Invalid Count - " + builderData.CountInvalid +
                                        "\n Unsubscribed Count - " + builderData.CountUnsubscribed +
                                        "\n Bounced Count - " + builderData.CountBounced +
                                        "\n Non-Consent Count - " + builderData.CountNonConsent +
                                        "\n Flagged Count - " + builderData.CountFlagged +
                                        "\n Valid Count - " + builderData.CountValid +
                                        "\n Unique Count - " + builderData.CountUnique;
                Logger.WriteDebugMessage(message);

            }
            else
            {
                Assert.Fail("One of the Counts did not match.");
            }
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Click_ABGrid_BacktoManageAudience();
            ElementClick(Driver.FindElement(By.XPath("//*[@id='tableAudienceSearchResult']/tbody/tr/td[7]/div/span")));
            SqlWarehouseQuery.getForeCastAudience(CompanyName, audienceName, builderData);
            WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Generating Counts')]"), 30);
            totalcount = "//span[contains(text(), 'Total Count')]//following::span[contains(text(), '" + builderData.CountTotal + "')]";
            totalnullcount = "//span[contains(text(), 'Null')]//following::span[contains(text(), '" + builderData.CountNull + "')]";
            totalInvalidcount = "//span[contains(text(), 'Invalid')]//following::span[contains(text(), '" + builderData.CountInvalid + "')]";
            totalunsubcount = "//span[contains(text(), 'Unsubscribed')]//following::span[contains(text(), '" + builderData.CountUnsubscribed + "')]";
            totalBouncecount = "//span[contains(text(), 'Bounced')]//following::span[contains(text(), '" + builderData.CountBounced + "')]";
            totalNonConsentcount = "//span[contains(text(), 'Non-Consent')]//following::span[contains(text(), '" + builderData.CountNonConsent + "')]";
            totalflagcount = "//span[contains(text(), 'Flagged')]//following::span[contains(text(), '" + builderData.CountFlagged + "')]";
            totalValidcount = "//span[contains(text(), 'Valid')]//following::span[contains(text(), '" + builderData.CountValid + "')]";
            totalUniquecount = "//span[contains(text(), 'Unique')]//following::span[contains(text(), '" + builderData.CountUnique + "')]";

            if ((IsElementPresent((By.XPath(totalcount)))) && (IsElementPresent((By.XPath(totalInvalidcount)))) && (IsElementPresent((By.XPath(totalunsubcount)))) && (IsElementPresent((By.XPath(totalBouncecount)))) && (IsElementPresent((By.XPath(totalcount)))) && (IsElementPresent((By.XPath(totalNonConsentcount)))) && (IsElementPresent((By.XPath(totalflagcount)))) && (IsElementPresent((By.XPath(totalValidcount)))) && (IsElementPresent((By.XPath(totalUniquecount)))))
            {
                string message = "Expected Result are as below - ";
                message = message + "\n TotalCount - " + builderData.CountTotal +
                                    "\n Null Count - " + builderData.CountNull +
                                    "\n Invalid Count - " + builderData.CountInvalid +
                                    "\n Unsubscribed Count - " + builderData.CountUnsubscribed +
                                    "\n Bounced Count - " + builderData.CountBounced +
                                    "\n Non-Consent Count - " + builderData.CountNonConsent +
                                    "\n Flagged Count - " + builderData.CountFlagged +
                                    "\n Valid Count - " + builderData.CountValid +
                                    "\n Unique Count - " + builderData.CountUnique;
                Logger.WriteDebugMessage(message);

            }
            else
            {
                Assert.Fail("One of the Counts did not match.");
            }
            AudienceBuilder.Click_Grid_EditAudience();
            if (VerifyTextOnPage("Total Records"))
            {
                AudienceBuilder.Click_ABEdit_TotalRecords();
                WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Generating Counts')]"), 30);
                SqlWarehouseQuery.getForeCastAudience(CompanyName, audienceName, builderData);
                totalcount = "//span[contains(text(), 'Total Count')]//following::span[contains(text(), '" + builderData.CountTotal + "')]";
                totalnullcount = "//span[contains(text(), 'Null')]//following::span[contains(text(), '" + builderData.CountNull + "')]";
                totalInvalidcount = "//span[contains(text(), 'Invalid')]//following::span[contains(text(), '" + builderData.CountInvalid + "')]";
                totalunsubcount = "//span[contains(text(), 'Unsubscribed')]//following::span[contains(text(), '" + builderData.CountUnsubscribed + "')]";
                totalBouncecount = "//span[contains(text(), 'Bounced')]//following::span[contains(text(), '" + builderData.CountBounced + "')]";
                totalNonConsentcount = "//span[contains(text(), 'Non-Consent')]//following::span[contains(text(), '" + builderData.CountNonConsent + "')]";
                totalflagcount = "//span[contains(text(), 'Flagged')]//following::span[contains(text(), '" + builderData.CountFlagged + "')]";
                totalValidcount = "//span[contains(text(), 'Valid')]//following::span[contains(text(), '" + builderData.CountValid + "')]";
                totalUniquecount = "//span[contains(text(), 'Unique')]//following::span[contains(text(), '" + builderData.CountUnique + "')]";

                if ((IsElementPresent((By.XPath(totalcount)))) && (IsElementPresent((By.XPath(totalInvalidcount)))) && (IsElementPresent((By.XPath(totalunsubcount)))) && (IsElementPresent((By.XPath(totalBouncecount)))) && (IsElementPresent((By.XPath(totalcount)))) && (IsElementPresent((By.XPath(totalNonConsentcount)))) && (IsElementPresent((By.XPath(totalflagcount)))) && (IsElementPresent((By.XPath(totalValidcount)))) && (IsElementPresent((By.XPath(totalUniquecount)))))
                {
                    string message = "Expected Result are as below - ";
                    message = message + "\n TotalCount - " + builderData.CountTotal +
                                        "\n Null Count - " + builderData.CountNull +
                                        "\n Invalid Count - " + builderData.CountInvalid +
                                        "\n Unsubscribed Count - " + builderData.CountUnsubscribed +
                                        "\n Bounced Count - " + builderData.CountBounced +
                                        "\n Non-Consent Count - " + builderData.CountNonConsent +
                                        "\n Flagged Count - " + builderData.CountFlagged +
                                        "\n Valid Count - " + builderData.CountValid +
                                        "\n Unique Count - " + builderData.CountUnique;
                    Logger.WriteDebugMessage(message);

                }
                else
                {
                    Assert.Fail("One of the Counts did not match.");
                }
            }
            else
            {
                Assert.Fail("Did not find Total Records.");
            }

        }
        public static void TC_262015()
        {
            var newProjectID = "";
            string audienceID = SqlWarehouseQuery.ReturnCompanyName("NA", "AudienceID", TestPlanId);
            AudienceBuilderData builderData = new AudienceBuilderData();
            SqlWarehouseQuery.GetAudienceProjects(builderData, companyNameByTestCase, audienceID);
            SqlWarehouseQuery.getForeCastAudience(companyNameByTestCase, builderData.AudienceName, builderData);
            Navigation.MenuNavigation("ManageCampaign");
            ManageCampaign.PreSearchCampaign_New(clientNameByTestCase, "ProjectID", builderData.ParentProjectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Clone");
            Helper.WaitForAjaxControls(50);
            AddDelay(12000);
            ElementWait(PageObject_CreateCampaign.CreateCampaign_EditTemplate_Subject(), 120);
            if (IsElementVisible(PageObject_CreateCampaign.CreateCampaign_Button_SaveandContinue()))
            {
                string getURL = Driver.Url;
                newProjectID = Regex.Match(getURL, "#(.*)&ProjectTitle").Groups[1].Value;
                newProjectID = newProjectID.Replace("ProjectId=", "");
                string subjectName = "ProjectId=" + newProjectID;
                ManageCampaign.EnterCampaignSubject(subjectName);
                Logger.WriteDebugMessage("Landed on Cloned Campaign - Edit Campaign. New ProjectID - " + newProjectID);
                ScrollDownUsingJavaScript(Driver, -1000);
                CreateCampaign.CreateCampaign_Button_Save();
                CreateCampaign.Click_Tab_Criteria();
                ElementWait(Driver.FindElement(By.Id("searchAudienceSwitch")), 120);
                IWebElement frameElement = Driver.FindElement(By.Name("Audience"));
                Logger.WriteInfoMessage("Switching into the iFrame." + frameElement);
                Driver.SwitchTo().Frame(frameElement);
                CreateCampaign.ClickOnTotalColumnFirstRecordAndGenerateCount();
                SqlWarehouseQuery.getForeCastAudience(companyNameByTestCase, builderData.AudienceName, builderData);
                ExitFrame();
                CreateCampaign.Click_CreateCampaign_ForecastAudience();

                string totalUniquecount = "//span[contains(text(), 'Unique Emails Matches')]//following::span[contains(text(), '" + builderData.CountUnique + "')]";
                ElementWait(Driver.FindElement(By.XPath("//span[contains(text(), 'Unique Emails Matches')]")), 120);
                if (IsElementPresent(By.XPath(totalUniquecount)))
                {
                    Logger.WriteDebugMessage("Unique Counts for ProjectID: " + builderData.ParentProjectID + " was " + builderData.CountUnique + " and found unique counts to be same with cloned Project - " + newProjectID + " Unique Emails Matches - " + builderData.CountUnique);
                }
                else
                {
                    Assert.Fail("Could not find " + "eMail(" + builderData.CountUnique + ")");
                }

            }

            Navigation.MenuNavigation("ManageCampaign");

            ManageCampaign.PreSearchCampaign_New(clientNameByTestCase, "ProjectID", newProjectID, iFrameManageCampaign);
            Logger.WriteInfoMessage("Deleting Campaign " + newProjectID);
            ManageCampaign.ManageCampaign_EllipseButton("Details");
            ScrollDownUsingJavaScript(Driver, -1000);
            ManageCampaign.CampaignDetails_PerformActonsItems("Delete");
        }

        public static void TC_262347()
        {
            string audienceID = SqlWarehouseQuery.ReturnCompanyName("NA", "AudienceID", TestPlanId);
            AudienceBuilderData builderData = new AudienceBuilderData();
            SqlWarehouseQuery.GetAudienceProjects(builderData, companyNameByTestCase, audienceID);

            Profile.SelectSubClient(companyNameByTestCase);

            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "Project.mvc/Project/Create");
            ElementClick(Driver.FindElement(By.LinkText(companyNameByTestCase)));

            ElementWait(Driver.FindElement(By.XPath("//h2[contains(text(), 'Select Campaign Type')]")), 60);
            if (IsElementPresent(By.XPath("//h2[contains(text(), 'Select Campaign Type')]")))
            {
                ElementClick(Driver.FindElement(By.XPath("//div[contains(@onclick, 'isSubProject=0')]")));
                ElementWait(Driver.FindElement(By.XPath("//span[contains(text(), 'Audience Search')]")), 60);
                ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Audience Search')]")));
                Logger.WriteDebugMessage("Landed on Create Campaign - Audience Search Tab");
                ScrollToElement(Driver.FindElement(By.XPath("//button[contains(text(), 'Campaign Settings')]")));
                IWebElement frameElement = Driver.FindElement(By.Name("Audience"));
                Logger.WriteInfoMessage("Switching into the iFrame." + frameElement);
                Driver.SwitchTo().Frame(frameElement);
                AddDelay(1000);

                ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.AudienceName);
                ((IJavaScriptExecutor)Driver).ExecuteScript("scroll(0,100)");
                AudienceBuilder.Click_SearchButton();

                WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
                if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + builderData.AudienceName + "')]"))))
                {
                    AudienceBuilder.Click_ABGrid_Details();
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'customerDetails')]")));
                    if (Driver.FindElement(By.XPath("//a[contains(@href, 'customerDetails')]")).GetAttribute("class").Contains("active"))
                    {
                        if (VerifyTextOnPage("Customer Details"))
                        {
                            string custEmails = SqlWarehouseQuery.GetAudienceCustomer(companyNameByTestCase, audienceID);
                            AudienceBuilder.Search_CustomerDetails_Search("Email Address");
                            ScrollDownUsingJavaScript(Driver, 500);
                            string[] emails = Regex.Split(custEmails, ",");
                            foreach (string email in emails)
                            {
                                String[] parts = email.Split(new[] { '@' });
                                String username = parts[0]; // "hello"
                                String domain = parts[1]; // "example.com"
                                string emailID = username.ToUpper();
                                
                                ElementEnterText(Driver.FindElement(By.XPath("(//input[@type='text'])[2]")), email);
                                ElementClick(Driver.FindElement(By.XPath("//div[@id='customerDetailsContent']/div/div[2]/div/div[3]/div/button[2]")));
                                if (IsElementPresent(By.XPath("//th[@aria-controls='tableAudienceCustomerDetails']//following::*[contains(text(), '" + email + "')]")) || IsElementPresent(By.XPath("//th[@aria-controls='tableAudienceCustomerDetails']//following::*[contains(text(), '" + emailID + "')]")))
                                {
                                    Logger.WriteDebugMessage("Found email - " + email);
                                }
                                else
                                {
                                    Assert.Fail("Email " + email + " not found.");
                                }
                            }

                        }
                    }
                }
            }
        }

        public static void TC_274525()
        {
            string audienceID = SqlWarehouseQuery.ReturnCompanyName("NA", "AudienceID", TestPlanId);
            //Select Property
            Profile.SelectSubClient(CompanyName);
            Logger.WriteDebugMessage("Select Property " + CompanyName);

            AudienceBuilderData builderData = new AudienceBuilderData();
            SqlWarehouseQuery.GetAudienceProjects(builderData, CompanyName, audienceID);

            //Click Audiences
            ElementClick(Driver.FindElement(By.XPath("//*[@id='audienceBuilder']/a")));
            Logger.WriteDebugMessage("Click Audience");

            //Switching into the iFrame
            IWebElement frameElement = Driver.FindElement(By.Name("Audience"));
            Logger.WriteInfoMessage("Switching into the iFrame." + frameElement);
            Driver.SwitchTo().Frame(frameElement);
            AddDelay(8000);

            //Click Details 
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.AudienceName);
            ((IJavaScriptExecutor)Driver).ExecuteScript("scroll(0,100)");
            AudienceBuilder.Click_SearchButton();
            WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + builderData.AudienceName + "')]"))))
            {
                AudienceBuilder.Click_ABGrid_Details();
                Logger.WriteDebugMessage("Click Details");

                //Click Customer Details 
                ElementClick(Driver.FindElement(By.XPath("//*[@id='customerDetails-tab']")));
                Logger.WriteDebugMessage("Click Customer Details");

                //Click Export
                ElementClick(Driver.FindElement(By.XPath("//*[@id='audiencecustomerdetailexport']")));
                Logger.WriteDebugMessage("Click Export");

                ExitFrame();

                //Verify text and highlight 
                VerifyTextOnPageAndHighLight("Your report is being generated and will be sent to your email");
                Logger.WriteDebugMessage("Verify text");

                OpenNewTab();
                ControlToNewWindow();
                Login.AutoAcc_logins("Your Audience Customer Details File Export for Audience", 2, 0, LegacyTestData.CommonCatchallURL, 1);

                Logger.WriteDebugMessage("eInsight: Your Audience Customer Details File Export for Audience: " + builderData.AudienceName + " is ready");
                if (VerifyTextOnPage("Your eInsight Audience Customer Details export is ready to download."))
                {
                    Logger.WriteDebugMessage("Your eInsight Audience Customer Details export is ready to download. Please click here to download your file.");
                }
                else
                {
                    Assert.Fail("Your eInsight Audience Customer Details export is ready to download. Please click here to download your file.");
                }

            }
            else
            {
                Assert.Fail("Audience Name: " + builderData.AudienceName + " did not apprear on the page.");
            }


        }

        #endregion[TP_261803]

    }
}
