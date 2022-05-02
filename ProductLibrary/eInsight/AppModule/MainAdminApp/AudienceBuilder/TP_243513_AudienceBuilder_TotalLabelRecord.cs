using eInsight.Utility;
using eInsight.AppModule.UI;
using eInsight.PageObject.UI;
using Common;
using Constants = eInsight.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using SqlWarehouse;
using OpenQA.Selenium;
using NUnit.Framework;
using eInsight.AppModule.UI;

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        private static void AudiencePrereq_TP243513(AudienceBuilderData builderData)
        {
            /*Pre-Requisite */
            //string CompanyName = SqlWarehouseQuery.ReturnCompanyName("", "CompanyName", TestPlanId);
            audienceName = SqlWarehouseQuery.ReturnCompanyName("NA", "AudienceName", "TP_240125") + TestPlanId;
            string dynamicCriteriaJSON = SqlWarehouseQuery.ReturnCompanyName("NA", "AudienceJSON", TestPlanId);

            SqlWarehouseQuery.createAudience(CompanyName, builderData, audienceName, dynamicCriteriaJSON, LegacyTestData.CommonFrontendEmail);

            if (builderData.AudienceDetailID == "1")
            {
                Logger.WriteInfoMessage("Audience Name " + audienceName + " already exist.");
            }
            else
            {
                Logger.WriteInfoMessage("Created a new Audience Name " + audienceName);
            }
        }

        #region[TP_243513]
        public static void TC_243266()
        {

            //Previous used AudienceName - April 12 Audience1
            AudienceBuilderData builderData = new AudienceBuilderData();
            AudiencePrereq_TP243513(builderData);

            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            AudienceBuilder.Click_AB_AddNewAudience();
            ElementWait(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")), 60);

            if (VerifyTextOnPage("— Total Records"))
            {
                Logger.WriteDebugMessage("Total Record Label exist on the Page.");
            }
            else
            {
                Assert.Fail("Total Record Label does not exist on the Page.");
            }
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Click_ABEdit_CancelButton();

            ElementWait(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), 60);
            ElementEnterText(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), audienceName);
            AudienceBuilder.Click_SearchButton();
            WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
            AudienceBuilder.Click_ABGrid_LastSaved();
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                Logger.WriteDebugMessage("Audience Name - " + audienceName + " displayed in data table.");
                AudienceBuilder.Click_Grid_EditAudience();
                Logger.WriteDebugMessage("Clicked on edit button for audience : " + audienceName);

                if (VerifyTextOnPage("Total Records"))
                {
                    Logger.WriteDebugMessage("Total Record Label exist on the Page.");
                }
                else
                {
                    Assert.Fail("Total Record Label does not exist on the Page.");
                }
            }
            else
            {
                Assert.Fail("AudienceName - " + audienceName + " did not found on the page.");
            }

        }
        public static void TC_243267()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            AudiencePrereq_TP243513(builderData);

            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");
            ElementEnterText(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), audienceName);
            AudienceBuilder.Click_SearchButton();
            WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
            AudienceBuilder.Click_ABGrid_LastSaved();
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                Logger.WriteDebugMessage("Audience Name - " + audienceName + " displayed in data table.");
                AudienceBuilder.Click_Grid_EditAudience();
                Logger.WriteDebugMessage("Clicked on edit button for audience : " + audienceName);

                //if (VerifyTextOnPage("Total Records"))
                //{
                //    AudienceBuilder.Click_ABEdit_TotalRecords();
                //    WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Generating Counts')]"), 30);
                //    SqlWarehouseQuery.getForeCastAudience(companyName, audienceName, builderData);
                //    string totalcount = "//span[contains(text(), 'Total Count')]//following::span[contains(text(), '" + builderData.CountTotal +"')]";
                //    string totalnullcount = "//span[contains(text(), 'Null')]//following::span[contains(text(), '" + builderData.CountNull + "')]";
                //    string totalInvalidcount = "//span[contains(text(), 'Invalid')]//following::span[contains(text(), '" + builderData.CountInvalid + "')]";
                //    string totalunsubcount = "//span[contains(text(), 'Unsubscribed')]//following::span[contains(text(), '" + builderData.CountUnsubscribed + "')]";
                //    string totalBouncecount = "//span[contains(text(), 'Bounced')]//following::span[contains(text(), '" + builderData.CountBounced + "')]";
                //    string totalNonConsentcount = "//span[contains(text(), 'Non-Consent')]//following::span[contains(text(), '" + builderData.CountNonConsent + "')]";
                //    string totalflagcount = "//span[contains(text(), 'Flagged')]//following::span[contains(text(), '" + builderData.CountFlagged + "')]";
                //    string totalValidcount = "//span[contains(text(), 'Valid')]//following::span[contains(text(), '" + builderData.CountValid + "')]";
                //    string totalUniquecount = "//span[contains(text(), 'Unique')]//following::span[contains(text(), '" + builderData.CountUnique + "')]";

                //    if ((IsElementPresent((By.XPath(totalcount)))) && (IsElementPresent((By.XPath(totalInvalidcount)))) && (IsElementPresent((By.XPath(totalunsubcount)))) && (IsElementPresent((By.XPath(totalBouncecount)))) && (IsElementPresent((By.XPath(totalcount)))) && (IsElementPresent((By.XPath(totalNonConsentcount)))) && (IsElementPresent((By.XPath(totalflagcount)))) && (IsElementPresent((By.XPath(totalValidcount)))) && (IsElementPresent((By.XPath(totalUniquecount)))))
                //    {
                //        string message = "Expected Result are as below - ";
                //        message = message + "\n TotalCount - " + builderData.CountTotal +
                //                            "\n Null Count - " + builderData.CountNull +
                //                            "\n Invalid Count - " + builderData.CountInvalid +
                //                            "\n Unsubscribed Count - " + builderData.CountUnsubscribed +
                //                            "\n Bounced Count - " + builderData.CountBounced +
                //                            "\n Non-Consent Count - " + builderData.CountNonConsent +
                //                            "\n Flagged Count - " + builderData.CountFlagged +
                //                            "\n Valid Count - " + builderData.CountValid +
                //                            "\n Unique Count - " + builderData.CountUnique;
                //        Logger.WriteDebugMessage(message);

                //    }
                //    else
                //    {
                //        Assert.Fail("One of the Counts did not match.");
                //    }
                //}
                //Logger.WriteInfoMessage("Updating the criteria and getting total records");
                AudienceBuilder.Click_ABEdit_AddProperty();

                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save')]")));
                Logger.WriteDebugMessage("Clicked on Save button.");
                if (VerifyTextOnPage("Generating"))
                {
                    Logger.WriteDebugMessage("Counts are automatically generating it after clicking Save ");
                    AudienceBuilder.Click_ABEdit_TotalRecords();
                    WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Generating Counts')]"), 30);
                    SqlWarehouseQuery.getForeCastAudience(CompanyName, audienceName, builderData);
                    string totalcount = "//span[contains(text(), 'Total Count')]//following::span[contains(text(), '" + builderData.CountTotal + "')]";
                    string totalnullcount = "//span[contains(text(), 'Null')]//following::span[contains(text(), '" + builderData.CountNull + "')]";
                    string totalInvalidcount = "//span[contains(text(), 'Invalid')]//following::span[contains(text(), '" + builderData.CountInvalid + "')]";
                    string totalunsubcount = "//span[contains(text(), 'Unsubscribed')]//following::span[contains(text(), '" + builderData.CountUnsubscribed + "')]";
                    string totalBouncecount = "//span[contains(text(), 'Bounced')]//following::span[contains(text(), '" + builderData.CountBounced + "')]";
                    string totalNonConsentcount = "//span[contains(text(), 'Non-Consent')]//following::span[contains(text(), '" + builderData.CountNonConsent + "')]";
                    string totalflagcount = "//span[contains(text(), 'Flagged')]//following::span[contains(text(), '" + builderData.CountFlagged + "')]";
                    string totalValidcount = "//span[contains(text(), 'Valid')]//following::span[contains(text(), '" + builderData.CountValid + "')]";
                    string totalUniquecount = "//span[contains(text(), 'Unique')]//following::span[contains(text(), '" + builderData.CountUnique + "')]";

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
                    AudienceBuilder.Click_ABEdit_AddProperty();
                    AudienceBuilder.PublishAudience();
                    AddDelay(5000);
                    if (VerifyTextOnPage("Generating"))
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
                    /*Search Grid*/
                    AudienceBuilder.Click_ABEdit_CancelButton();
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
                }

            }
        }
        public static void TC_243269()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            AudiencePrereq_TP243513(builderData);

            string companyName = SqlWarehouseQuery.ReturnCompanyName("", "CompanyName", TestPlanId);
            string clientName = SqlWarehouseQuery.ReturnCompanyName("", "clientName", TestPlanId);

            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");
            ElementWait(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), 120);
            ElementEnterText(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), audienceName);
            AudienceBuilder.Click_SearchButton();
            WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
            AudienceBuilder.Click_ABGrid_LastSaved();
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                Logger.WriteDebugMessage("Audience Name - " + audienceName + " displayed in data table.");
                AudienceBuilder.Click_Grid_EditAudience();
                Logger.WriteDebugMessage("Clicked on edit button for audience : " + audienceName);

                if (VerifyTextOnPage("Total Records"))
                {
                    AudienceBuilder.Click_ABEdit_TotalRecords();
                    WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Generating Counts')]"), 30);
                    SqlWarehouseQuery.getForeCastAudience(companyName, audienceName, builderData);
                    string totalcount = "//span[contains(text(), 'Total Count')]//following::span[contains(text(), '" + builderData.CountTotal + "')]";
                    string totalnullcount = "//span[contains(text(), 'Null')]//following::span[contains(text(), '" + builderData.CountNull + "')]";
                    string totalInvalidcount = "//span[contains(text(), 'Invalid')]//following::span[contains(text(), '" + builderData.CountInvalid + "')]";
                    string totalunsubcount = "//span[contains(text(), 'Unsubscribed')]//following::span[contains(text(), '" + builderData.CountUnsubscribed + "')]";
                    string totalBouncecount = "//span[contains(text(), 'Bounced')]//following::span[contains(text(), '" + builderData.CountBounced + "')]";
                    string totalNonConsentcount = "//span[contains(text(), 'Non-Consent')]//following::span[contains(text(), '" + builderData.CountNonConsent + "')]";
                    string totalflagcount = "//span[contains(text(), 'Flagged')]//following::span[contains(text(), '" + builderData.CountFlagged + "')]";
                    string totalValidcount = "//span[contains(text(), 'Valid')]//following::span[contains(text(), '" + builderData.CountValid + "')]";
                    string totalUniquecount = "//span[contains(text(), 'Unique')]//following::span[contains(text(), '" + builderData.CountUnique + "')]";

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
                Logger.WriteInfoMessage("Updating the criteria and getting total records");
                ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
                ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
                Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);

                AudienceBuilder.PublishAudience();
                AddDelay(5000);
                if (VerifyTextOnPage("Total Records"))
                {
                    AudienceBuilder.Click_ABEdit_TotalRecords();
                    WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Generating Counts')]"), 30);
                    SqlWarehouseQuery.getForeCastAudience(companyName, audienceName, builderData);
                    string totalcount = "//span[contains(text(), 'Total Count')]//following::span[contains(text(), '" + builderData.CountTotal + "')]";
                    string totalnullcount = "//span[contains(text(), 'Null')]//following::span[contains(text(), '" + builderData.CountNull + "')]";
                    string totalInvalidcount = "//span[contains(text(), 'Invalid')]//following::span[contains(text(), '" + builderData.CountInvalid + "')]";
                    string totalunsubcount = "//span[contains(text(), 'Unsubscribed')]//following::span[contains(text(), '" + builderData.CountUnsubscribed + "')]";
                    string totalBouncecount = "//span[contains(text(), 'Bounced')]//following::span[contains(text(), '" + builderData.CountBounced + "')]";
                    string totalNonConsentcount = "//span[contains(text(), 'Non-Consent')]//following::span[contains(text(), '" + builderData.CountNonConsent + "')]";
                    string totalflagcount = "//span[contains(text(), 'Flagged')]//following::span[contains(text(), '" + builderData.CountFlagged + "')]";
                    string totalValidcount = "//span[contains(text(), 'Valid')]//following::span[contains(text(), '" + builderData.CountValid + "')]";
                    string totalUniquecount = "//span[contains(text(), 'Unique')]//following::span[contains(text(), '" + builderData.CountUnique + "')]";

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
            }
        }
        public static void TC_243270()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            AudiencePrereq_TP243513(builderData);

            string companyName = SqlWarehouseQuery.ReturnCompanyName("", "CompanyName", TestPlanId);
            string clientName = SqlWarehouseQuery.ReturnCompanyName("", "clientName", TestPlanId);

            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");
            ElementWait(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), 120);
            ElementEnterText(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), audienceName);
            AudienceBuilder.Click_SearchButton();
            WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
            
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                AddDelay(25000);
                ScrollToText("Audience List");
                ElementClick(Driver.FindElement(By.XPath("//*[@id='tableAudienceSearchResult']/tbody/tr/td[7]/div/span")));
                SqlWarehouseQuery.getForeCastAudience(companyName, audienceName, builderData);
                WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Generating Counts')]"), 30);
                string totalcount = "//span[contains(text(), 'Total Count')]//following::span[contains(text(), '" + builderData.CountTotal + "')]";
                string totalnullcount = "//span[contains(text(), 'Null')]//following::span[contains(text(), '" + builderData.CountNull + "')]";
                string totalInvalidcount = "//span[contains(text(), 'Invalid')]//following::span[contains(text(), '" + builderData.CountInvalid + "')]";
                string totalunsubcount = "//span[contains(text(), 'Unsubscribed')]//following::span[contains(text(), '" + builderData.CountUnsubscribed + "')]";
                string totalBouncecount = "//span[contains(text(), 'Bounced')]//following::span[contains(text(), '" + builderData.CountBounced + "')]";
                string totalNonConsentcount = "//span[contains(text(), 'Non-Consent')]//following::span[contains(text(), '" + builderData.CountNonConsent + "')]";
                string totalflagcount = "//span[contains(text(), 'Flagged')]//following::span[contains(text(), '" + builderData.CountFlagged + "')]";
                string totalValidcount = "//span[contains(text(), 'Valid')]//following::span[contains(text(), '" + builderData.CountValid + "')]";
                string totalUniquecount = "//span[contains(text(), 'Unique')]//following::span[contains(text(), '" + builderData.CountUnique + "')]";

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
        }
    }
}
#endregion[TP_243513]