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

        private static void AudiencePrereq_TP_247212(AudienceBuilderData builderData, int deleteAudience)
        {
            /*Pre-Requisite */
            audienceName = SqlWarehouseQuery.ReturnCompanyName("NA", "AudienceName", "TP_240125") + TestPlanId;
            string dynamicCriteriaJSON = SqlWarehouseQuery.ReturnDescriptionValue("NA", "AudienceJSON", "TP_243513");

            if (deleteAudience == 1)
            {
                SqlWarehouseQuery.DeleteAudience(CompanyName, audienceName);
            }

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

        #region[TP_247212]
        public static void TC_244751()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            
            AudiencePrereq_TP_247212(builderData, 1);

            //Profile.SelectClient(companyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");
            ElementWait(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), 120);
            ElementEnterText(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), audienceName);
            AudienceBuilder.Click_SearchButton();
            AudienceBuilder.Click_ABGrid_LastSaved();
            WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                ScrollToText("Audience List");
                ElementClick(Driver.FindElement(By.XPath("//*[@id='tableAudienceSearchResult']/tbody/tr/td[7]/div/span")));
                AudienceBuilder.GenerateCounts(0);
                Logger.WriteDebugMessage("Generating Counts from Audience Builder Home Page.");

                AudienceBuilder.Click_Grid_EditAudience();
                Logger.WriteDebugMessage("Clicked on edit button for audience : " + audienceName);

                ElementWait(Driver.FindElement(By.XPath("//button[contains(text(), 'Save')]")), 60);

                AudienceBuilder.Click_ABEdit_TotalRecords();
                if (VerifyTextOnPage("Notification"))
                {
                    Logger.WriteDebugMessage("Email Notification is switch on.");
                }
                else
                {
                    Assert.Fail("Did not show notification for audience Name - " + audienceName);
                }
            }
        }
        public static void TC_244111()
        {
            /*Pre-Requisite */
            AudienceBuilderData builderData = new AudienceBuilderData();
            AudiencePrereq_TP_247212(builderData, 1);

            //Profile.SelectClient(companyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");
            ElementWait(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), 120);
            ElementEnterText(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), audienceName);
            AudienceBuilder.Click_SearchButton();
            AudienceBuilder.Click_ABGrid_LastSaved();
            WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                ScrollToText("Audience List");
                ElementClick(Driver.FindElement(By.XPath("//*[@id='tableAudienceSearchResult']/tbody/tr/td[7]/div/span")));
                Logger.WriteDebugMessage("Clicked on Generating Counts from Audience Builder Home Page.");

                if (VerifyTextOnPage("Counts Not Generated"))
                {
                    Logger.WriteDebugMessage("Received message Counts Not Generated");
                }
            }
            else
            {
                Assert.Fail("Audience Name - " + audienceName + " did not appeared on the Page.");
            }
        }
        public static void TC_243186()
        {
            /*Pre-Requisite */
            AudienceBuilderData builderData = new AudienceBuilderData();
            AudiencePrereq_TP_247212(builderData, 1);
            /*End of Pre-Requisite */

            //Profile.SelectClient(companyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");
            ElementWait(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), 120);
            ElementEnterText(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), audienceName);
            AudienceBuilder.Click_SearchButton();
            AudienceBuilder.Click_ABGrid_LastSaved();
            WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                ScrollToText("Audience List");
                ElementClick(Driver.FindElement(By.XPath("//*[@id='tableAudienceSearchResult']/tbody/tr/td[7]/div/span")));
                Logger.WriteDebugMessage("Clicked on Generating Counts from Audience Builder Home Page.");

                if (VerifyTextOnPage("Counts Not Generated"))
                {
                    Logger.WriteDebugMessage("Received message Counts Not Generated");
                    AudienceBuilder.GenerateCounts(0);
                    ElementClick(Driver.FindElement(By.XPath("(//following::button[contains(text(), 'Cancel')])[2]")));
                    if (VerifyTextOnPage("Counts Cancelled"))
                    {
                        Logger.WriteDebugMessage("Received Message - Counts Cancelled");
                        ElementClick(Driver.FindElement(By.XPath("//h2[contains(text(), 'Audience List')]")));
                        AudienceBuilder.GenerateCounts(1);
                        AudienceBuilder.GenerateCounts(0);
                        
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
                    }
                }
            }
            else
            {
                Assert.Fail("Audience did not appreared on search grid.");
            }
        }
        public static void TC_243192()
        {
            /*Pre-Requisite */
            AudienceBuilderData builderData = new AudienceBuilderData();
            AudiencePrereq_TP_247212(builderData, 1);
            /*End of Pre-Requisite */

            //Profile.SelectClient(companyName);
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

                AudienceBuilder.Click_ABEdit_AddProperty();
                
                ElementClick(Driver.FindElement(By.XPath("//a[contains(text(), 'Total Records')]")));
                if (VerifyTextOnPage("Counts Not Generated"))
                {
                    Logger.WriteDebugMessage("Counts could be generated because it is not saved.");
                }
                else
                {
                    Assert.Fail("Count was generated without saving audience.");
                }
            }
        }
        #endregion[TP_247212]

    }
}
