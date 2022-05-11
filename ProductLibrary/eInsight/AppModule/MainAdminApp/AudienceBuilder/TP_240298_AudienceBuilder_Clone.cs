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

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        static string newaudienceName = "";
        #region[TP_240298]
        private static void AudiencePreReq_TP240298(AudienceBuilderData builderData)
        {
 
            /*Pre-requisite*/
            audienceName = SqlWarehouseQuery.ReturnCompanyName("NA", "AudienceName", "TP_240125") + TestPlanId;
            string dynamicCriteriaJSON = SqlWarehouseQuery.ReturnDescriptionValue("NA", "AudienceName", "TP_240125");
            string email = LegacyTestData.CommonFrontendEmail;

            SqlWarehouseQuery.createAudience(CompanyName, builderData, audienceName, dynamicCriteriaJSON, email);
            if (builderData.AudienceDetailID == "1")
            {
                Logger.WriteInfoMessage("Audience Name " + audienceName + " already exist.");
            }
            else
            {
                Logger.WriteInfoMessage("Created a new Audience Name " + audienceName + " " + builderData.AudienceDetailID);
            }
            SqlWarehouseQuery.publishAudience(CompanyName, builderData, audienceName, email);
            if (string.IsNullOrEmpty(builderData.AudiencePublishDetailID))
            {
                Logger.WriteInfoMessage("Couldn't Publish Audience - " + audienceName);
                Assert.Fail("Unable to publish Audience " + audienceName);
            }
            else
            {
                Logger.WriteInfoMessage("Published Audience " + audienceName + ". Pulished AudienceID is  " + builderData.AudiencePublishDetailID);
            }
            /*End of Pre-requisite*/

        }
        public static void TC_238728()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            AudiencePreReq_TP240298(builderData);
            

            //Profile.SelectClient(companyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), audienceName);
            AudienceBuilder.Click_SearchButton();
            WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            ElementWait(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]")), 60);
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                Logger.WriteDebugMessage("Audience Name - " + audienceName + " displayed in data table.");
                AudienceBuilder.CloneAudienceAction();
                AddDelay(25000);
                if (VerifyTextOnPage(audienceName + " - Clone"))
                {
                    Logger.WriteDebugMessage("Found Cloned Audience with name " + audienceName + " - Clone");
                    Logger.WriteDebugMessage("Landed on Audience Edit Page. Aidence have been cloned successfully.");
                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().Frame(0);
                    Logger.WriteDebugMessage("Found Property List as blank");
                    ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
                    ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
                    Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
                    Logger.WriteDebugMessage("Added Property List.");

                    ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save')]")));
                    Logger.WriteDebugMessage("Cloned Audience is being saved");
                    AddDelay(20000);

                    Logger.WriteInfoMessage("Comparing Original and cloned criteria");
                    AudienceBuilder.CompareAudienceCriteria(audienceName, audienceName + " - Clone", CompanyName, "checkdifferece");

                }
                else
                {
                    Assert.Fail(audienceName + " - Clone was not found.");
                }
            }
        }
        public static void TC_238731()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            ClientdbConnection userAccess = new ClientdbConnection();
            AudiencePreReq_TP240298(builderData);
            

            //Profile.SelectClient(companyName);
            Profile.SelectSubClient(clientName);
            SqlWarehouseQuery.GetAssignedCompanyFromUser(userAccess, LegacyTestData.CommonFrontendEmail, CompanyName);
            Logger.WriteInfoMessage(LegacyTestData.CommonFrontendEmail + " have propertyaccess " + userAccess.CompanyName + " for " + CompanyName);
            
            Navigation.MenuNavigation("AudienceBuilder");
            
            ElementEnterText(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), audienceName);
            AudienceBuilder.Click_SearchButton();
            WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            ElementWait(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]")), 60);
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                Logger.WriteDebugMessage("Audience Name is already created.");
            }
            Logger.WriteInfoMessage("Logging out from the account.");
            Navigatetoiframe(0);
            Login.AccLogout();
            LegacyTestData.CommonFrontendEmail = "EdgewaterAdmin@cendyn17.com";
            Login.ReLogin();
            Logger.WriteDebugMessage("Logged in as - " + LegacyTestData.CommonFrontendEmail);
            SqlWarehouseQuery.GetAssignedCompanyFromUser(userAccess, LegacyTestData.CommonFrontendEmail, CompanyName);
            Logger.WriteInfoMessage(LegacyTestData.CommonFrontendEmail + " have propertyaccess " + userAccess.CompanyName + " for " + CompanyName);

            //Profile.SelectClient(companyName);
            //Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");
            ElementEnterText(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), audienceName);
            AudienceBuilder.Click_SearchButton();
            WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AudienceBuilder.CloneAudienceAction();
            AddDelay(25000);
            if (VerifyTextOnPage(audienceName + " - Clone"))
            {
                Driver.SwitchTo().DefaultContent();
                Driver.SwitchTo().Frame(0);

                string newaudienceName = audienceName + "_" + TestCaseId;
                AudienceBuilder.EditAudienceName(newaudienceName);

                Driver.FindElement(By.XPath("(//input[@type='text'])[2]")).SendKeys(TestCaseId);
                Driver.FindElement(By.XPath("(//input[@type='text'])[2]")).SendKeys(Keys.Enter);
                Logger.WriteDebugMessage("Added Tags from List.");

                ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Details')]")));

                ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
                ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
                Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
                Logger.WriteDebugMessage("Added Property List.");

                ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Details')]")));

                ElementClick(Driver.FindElement(By.Id("helptext")));
                ElementEnterText(Driver.FindElement(By.Id("helptext")), TestCaseId);
                Logger.WriteDebugMessage("Added Description - " + TestCaseId);

                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save')]")));
                Logger.WriteDebugMessage("Cloned Audience is being saved");
                AddDelay(20000);

                SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastSaved", 1, 1, audienceName);
                string originalAudienceName = builderData.AudienceName;
                string originalTags = builderData.Tags;
                string originalDescription = builderData.AudienceDescription;


                SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastSaved", 1, 1, newaudienceName);
                string clonedAudienceName = builderData.AudienceName;
                string clonedTags = builderData.Tags;
                string clonedDescription = builderData.AudienceDescription;
                Logger.WriteInfoMessage("\n" + "Original Audience Details are \n" + "Name - " + originalAudienceName + "\nTags - " + originalTags + "\nDescription - " + originalDescription + "Cloned Audience Details are \n" + "Name - " + clonedAudienceName + "\nTags - " + clonedTags + "\nDescription - " + clonedDescription);
                AudienceBuilder.CompareAudienceCriteria(audienceName, newaudienceName, CompanyName, "checkdifferece");
            }
            else
            {
                Assert.Fail(audienceName + " - Clone was not found.");
            }
        }
        public static void TC_238732()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            newaudienceName = "QAAutomation_" + SqlWarehouseQuery.ReturnCompanyName("TC_240128", "AudienceName");
            AudiencePreReq_TP240298(builderData);

            //Profile.SelectClient(companyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), audienceName);
            AudienceBuilder.Click_SearchButton();
            WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            ElementWait(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]")), 60);
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                Logger.WriteDebugMessage("Audience Name - " + audienceName + " displayed in data table.");
                AudienceBuilder.CloneAudienceAction();
                AddDelay(25000);
                if (VerifyTextOnPage(audienceName + " - Clone"))
                {
                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().Frame(0);

                    AudienceBuilder.EditAudienceName(newaudienceName);

                    ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
                    ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
                    Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
                    Logger.WriteDebugMessage("Added Property List.");

                    ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Details')]")));

                    ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save')]")));
                    if (VerifyTextOnPage("Audience name exceeds limit. Rename Audience to enable saving."))
                    {
                        Logger.WriteDebugMessage("Received Error message ");
                    }
                    else if (VerifyTextOnPage("Audience saved successfully"))
                    {
                        Logger.WriteDebugMessage("Audience name allowed till 250 characters");
                    }
                }
                else
                {
                    Assert.Fail(audienceName + " - Clone was not found.");
                }
            }
        }
        public static void TC_239044()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            AudiencePreReq_TP240298(builderData);

            //Profile.SelectClient(companyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), audienceName);
            AudienceBuilder.Click_SearchButton();
            WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                Logger.WriteDebugMessage("Found " + audienceName + " on Published Tab. Navigating to Saved Tab.");
                AudienceBuilder.Click_ABGrid_LastSaved();
                Logger.WriteDebugMessage("Found " + audienceName + " on Saved Tab. ");
                WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
                Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
                ElementWait(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]")), 60);
                if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
                {
                    Logger.WriteDebugMessage("Audience Name - " + audienceName + " displayed in data table.");
                    AudienceBuilder.CloneAudienceAction();
                    {
                        AddDelay(25000);
                        if (VerifyTextOnPage(audienceName + " - Clone"))
                        {
                            ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Details')]")));
                            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
                            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
                            Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
                            Logger.WriteDebugMessage("Added Property List.");

                            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")));
                            Logger.WriteDebugMessage("Clicked on Save button. And Landed on Confirm Save and Publish Prompt.");
                            ElementClick(Driver.FindElement(By.XPath("(//button[contains(text(), 'Publish')])[2]")));
                            Logger.WriteDebugMessage("Clicked on Publish Button");
                            AddDelay(20000);
                            //string originalSavedAudience = SqlWarehouseQuery.GetAudienceCriteria(audienceName, CompanyName, "LastSaved", "getSpecificCriteria");
                            //string ClonedAudience = SqlWarehouseQuery.GetAudienceCriteria(audienceName, CompanyName, "LastSaved", "getSpecificCriteria");

                            Logger.WriteInfoMessage("Comparing LastSaved Version for " + audienceName + " & LastSaved Version for " + audienceName + " - Clone");
                            AudienceBuilder.CompareAudienceCriteria(audienceName, audienceName + " - Clone", CompanyName, "checkspecificdifferece", "LastSaved", "LastSaved");

                            Logger.WriteInfoMessage("Comparing LastSaved Version for " + audienceName + " & LastPublished Version for " + audienceName + " - Clone");
                            AudienceBuilder.CompareAudienceCriteria(audienceName, audienceName + " - Clone", CompanyName, "checkspecificdifferece", "LastSaved", "LastPublished");

                        }
                    }
                }
            }
            else
            {
                Assert.Fail(audienceName + " was not found on Published Search Data Table.");
            }
        }

        public static void TC_239045()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            AudiencePreReq_TP240298(builderData);

            //Profile.SelectClient(companyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(PageObject_AudienceBuilder.AB_TextBox_FieldValue(1), audienceName);
            AudienceBuilder.Click_SearchButton();
            WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                Logger.WriteDebugMessage("Found " + audienceName + " on Published Tab. Navigating to Saved Tab.");
                AudienceBuilder.Click_ABGrid_LastSaved();
                Logger.WriteDebugMessage("Found " + audienceName + " on Saved Tab. Navigating to Published Tab to clone.");
                AudienceBuilder.Click_ABGrid_LastPublished();
                WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
                AudienceBuilder.CloneAudienceAction();
                AddDelay(25000);
                if (VerifyTextOnPage(audienceName + " - Clone"))
                {
                    ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
                    ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
                    Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
                    Logger.WriteDebugMessage("Added Property List.");

                    ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")));
                    Logger.WriteDebugMessage("Clicked on Save button. And Landed on Confirm Save and Publish Prompt.");
                    ElementClick(Driver.FindElement(By.XPath("(//button[contains(text(), 'Publish')])[2]")));
                    Logger.WriteDebugMessage("Clicked on Publish Button");
                    AddDelay(20000);

                    Logger.WriteInfoMessage("Comparing LastPublished Version for " + audienceName + " & LastSaved Version for " + audienceName + " - Clone");
                    AudienceBuilder.CompareAudienceCriteria(audienceName, audienceName + " - Clone", CompanyName, "checkspecificdifferece", "LastPublished", "LastSaved");

                    Logger.WriteInfoMessage("Comparing LastPublished Version for " + audienceName + " & LastPublished Version for " + audienceName + " - Clone");
                    AudienceBuilder.CompareAudienceCriteria(audienceName, audienceName + " - Clone", CompanyName, "checkspecificdifferece", "LastPublished", "LastPublished");
                }
                else
                {
                    Assert.Fail(audienceName + " was not found on Published Search Data Table.");
                }
            }
        }
        #endregion[TP_240298]

    }
}
