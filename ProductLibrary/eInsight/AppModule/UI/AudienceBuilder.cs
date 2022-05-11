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
using OpenQA.Selenium.Interactions;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SqlWarehouse;

namespace eInsight.AppModule.UI
{
    class AudienceBuilder : Helper
    {
        public static void Prerequisite_CreateAudience(AudienceBuilderData builderData, string audienceName, string companyName, string dynamicCriteriaJSON, string audiencePublish = null)
        {
            /*Pre-requisite*/
            string email = LegacyTestData.CommonFrontendEmail;

            SqlWarehouseQuery.createAudience(companyName, builderData, audienceName, dynamicCriteriaJSON, email);
            if (builderData.AudienceDetailID == "1")
            {
                Logger.WriteInfoMessage("Audience Name " + audienceName + " already exist.");
            }
            else
            {
                Logger.WriteInfoMessage("Created a new Audience Name " + audienceName + " " + builderData.AudienceDetailID);
            }
            if (audiencePublish == "1")
            {
                SqlWarehouseQuery.publishAudience(companyName, builderData, audienceName, email);
                if (string.IsNullOrEmpty(builderData.AudiencePublishDetailID))
                {
                    Logger.WriteInfoMessage("Couldn't Publish Audience - " + audienceName);
                    Assert.Fail("Unable to publish Audience " + audienceName);
                }
                else
                {
                    Logger.WriteInfoMessage("Published Audience " + audienceName + ". Pulished AudienceID is  " + builderData.AudiencePublishDetailID);
                }
            }
            /*End of Pre-requisite*/
        }
        public static void Click_AB_AddNewAudience()
        {
            //ElementClick(PageObject_AudienceBuilder.AB_Button_Add());
            ElementClick(Driver.FindElement(By.Id("btnNewAudience")));
            Logger.WriteDebugMessage("Clicked on Add Button and Landed on AudienceBuilder Edit.");
        }
        public static void Click_ResetBuilder()
        {
            ElementClick(PageObject_AudienceBuilder.AB_Button_Reset());
        }

        public static void Search_CustomerDetails_Search(string searchCriteria)
        {
            AddDelay(1500);
            PageObject_AudienceBuilder.AB_CustomerDetailsSearchContent().Click();
            AddDelay(1000);
            PageObject_AudienceBuilder.AB_CustomerDetailsSearchContent().SendKeys(searchCriteria);
            AddDelay(10000);
            PageObject_AudienceBuilder.AB_CustomerDetailsSearchContent().SendKeys(Keys.Enter);
            AddDelay(3000);
        }

        public static void Audience_SearchBy(string audienceList)
        {
            //var resultdropdown = Driver.FindElement(By.Id("selectField"));
            ////create select element object 
            //var selectElement3 = new SelectElement(resultdropdown);

            ////select by value
            //selectElement3.SelectByValue(audienceList);
            ScrollUpUsingJavaScript(Driver, 500);
            ElementClick(Driver.FindElement(By.Id("selectField")));
            AddDelay(1000);
            Driver.FindElement(By.Id("selectField")).SendKeys(audienceList);
            AddDelay(10000);
            Driver.FindElement(By.Id("selectField")).SendKeys(Keys.Enter);

            Logger.WriteDebugMessage("Added SearchBy as " + audienceList);
        }

        public static void Audience_SearchByExpression(string audienceExpression)
        {
            var resultdropdown = Driver.FindElement(By.Id("selectOperator"));
            //create select element object 
            var selectElement3 = new SelectElement(resultdropdown);

            //select by value
            selectElement3.SelectByValue(audienceExpression);

            Logger.WriteDebugMessage("Select Searchby expression as: " + audienceExpression);
        }

        public static void Click_SearchAddFilter()
        {
            ElementClick(PageObject_AudienceBuilder.AB_Button_AddSearchField());
        }
        public static void Click_SearchButton()
        {
            ElementClick(PageObject_AudienceBuilder.AB_Button_Search());
        }
        public static void Click_ABGrid_LastPublished()
        {
            ElementClick(PageObject_AudienceBuilder.AB_Grid_LastPublished());
        }
        public static void Click_ABGrid_LastSaved()
        {
            ElementClick(PageObject_AudienceBuilder.AB_Grid_LastSaved());
        }
        public static void Click_ABGrid_ButtonAction()
        {
            ElementClick(PageObject_AudienceBuilder.AB_Grid_ButtonAction());
        }
        public static void EnterText_ABSearch_AudienceFieldTextValue(int fieldindex, string AudienceFieldValue)
        {
            ElementEnterText(PageObject_AudienceBuilder.AB_TextBox_FieldValue(fieldindex), AudienceFieldValue);
        }
        public static void Click_ABGrid_ButtonDetail()
        {
            ElementClick(PageObject_AudienceBuilder.Click_ABGrid_ButtonDetail());
        }
        public static void Click_ABGrid_AudienceClone()
        {
            ElementClick(PageObject_AudienceBuilder.Click_ABGrid_AudienceClone());
            Logger.WriteDebugMessage("Clicked on Clone Button.");
        }
        public static void Click_ABGrid_AudienceActionButton()
        {
            ElementClick(Driver.FindElement(By.Id("btnActions")));
            Logger.WriteDebugMessage("Clicked on Actions Button");
        }
        public static void CloneAudienceAction()
        {
            Click_ABGrid_AudienceActionButton();
            Click_ABGrid_AudienceClone();
        }
        public static void Click_ABGrid_AudienceInactive()
        {
            ElementClick(Driver.FindElement(By.XPath("//div[@id='toggleStatus']//following::label")));
            Logger.WriteDebugMessage("Clicked on Active/Deactive toggle");
        }

        public static void Click_ABGrid_AudienceDeactivateCancel()
        {
            ElementClick(Driver.FindElement(By.XPath("(//button[contains(text(), 'Cancel')])[2]")));
            Logger.WriteDebugMessage("Cancelled deactivate audience.");
        }

        public static void Click_ABGrid_DeactivateAudience()
        {
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Deactivate')]")));
            Logger.WriteDebugMessage("Clicked on Active/Deactive button");
        }
        public static void Click_Checkbox_ShowInactive()
        {
            ElementClick(Driver.FindElement(By.Id("checkboxShowInactiveAudiences")));
            Logger.WriteDebugMessage("Clicked on Show inactive audience.");
        }

        public static void CloneAudience()
        {
            ElementClick(PageObject_AudienceBuilder.Click_ABGrid_AudienceClone());
        }
        public static void Click_ABEdit_StayOnPage()
        {
            ElementClick(PageObject_AudienceBuilder.Click_ABEdit_StayOnPage());
            Logger.WriteDebugMessage("Landed back on Add/Edit Audience page.");
        }
        public static void Click_ABEdit_LeavePage()
        {
            ElementClick(PageObject_AudienceBuilder.Click_ABEdit_LeavePage());
            Logger.WriteDebugMessage("Landed on Audience Builder Search Grid.");
        }

        public static void Click_ABEdit_CancelButton()
        {
            ElementClick(PageObject_AudienceBuilder.Click_ABEdit_CancelButton());
            //ElementClick(Driver.FindElement(By.XPath("//*[@id='ab_main']/div/div[1]/div[2]/div[2]/div[4]/button[1]")));
            //ElementClick(Driver.FindElement(By.XPath("//div[@class='text - right']//button[contains(text(), 'Cancel')][1]")));
            Logger.WriteDebugMessage("Clicked on Cancel button. Landed on Audience Builder Main Page.");
        }
        public static void Click_ABEdit_TotalRecords()
        {
            ElementClick(PageObject_AudienceBuilder.Click_ABEdit_TotalRecords());
            Logger.WriteDebugMessage("Clicked on Total Label Records.");
        }

        public static void Click_ABEdit_AddProperty()
        {
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Added Property List");
            ElementClick(Driver.FindElement(By.XPath("//h2[contains(text(), 'Audience')]")));
        }
        public static void Click_ABGrid_Details()
        {
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            Logger.WriteDebugMessage("Landed on Details.");
        }
        public static void Click_ABGrid_BacktoManageAudience()
        {
            HighlightElement(Driver.FindElement(By.XPath("//*[contains(text(), 'Manage Audiences')]")));
            ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Manage Audiences')]")));
            Logger.WriteDebugMessage("Click to Back to Manage Audience.");
        }
        public static void Click_Grid_EditAudience()
        {
            ElementClick(Driver.FindElement(By.Id("btnActions")));
            Logger.WriteDebugMessage("Clicked on Actions Button");
            ElementClick(Driver.FindElement(By.Id("btnEdit")));
            Logger.WriteDebugMessage("Clicked on Edit Button");
            Logger.WriteDebugMessage("Click on Edit button.");
            if (IsElementVisible(PageObject_AudienceBuilder.Click_ABEdit_CancelButton()))
            {
                Logger.WriteDebugMessage("Clicked on edit button.");
            }
            else
            {
                Assert.Fail("Did not land on Edit button.");
            }
        }
        public static void GenerateCounts(int generatetype)
        {
            switch (generatetype)
            {
                //Finds Element when count was not generated
                case 0:
                    ElementClick(Driver.FindElement(By.XPath("//div[contains(text(), 'Counts Not Generated')]//following::button[contains(text(), 'Generate')]")));
                    Logger.WriteDebugMessage("Clicked on generate counts.");
                    break;
                case 1:
                    ElementClick(Driver.FindElement(By.XPath("//*[@id='tableAudienceSearchResult']/tbody/tr/td[7]/div/span")));
                    Logger.WriteDebugMessage("Clicked on Generating Counts from Audience Builder Home Page.");
                    break;
            }
        }

        public static void DeactivateAudience(string audienceName, string casetype)
        {
            var quote = '"';
            switch (casetype)
            {
                case "Cancel":
                    Click_ABGrid_AudienceActionButton();
                    Click_ABGrid_AudienceInactive();
                    Click_ABGrid_AudienceDeactivateCancel();
                    break;
                case "Deactivate":
                    Click_ABGrid_AudienceActionButton();
                    Click_ABGrid_AudienceInactive();
                    if (VerifyTextOnPage("To deactivate this audience, please remove it from all associated campaigns"))
                    {
                        Logger.WriteDebugMessage("Audience is associated to an active campaign. Received " + quote + "To deactivate this audience, please remove it from all associated campaigns" + quote);
                    }
                    if (VerifyTextOnPage("Deactivate " + audienceName))
                    {
                        Logger.WriteDebugMessage("Landed Confirm Page to Deactivate Audience. Received Comfirm message - Deactivate " + audienceName);
                        Click_ABGrid_DeactivateAudience();
                    }
                    break;
                case "Activate":
                    Click_ABGrid_AudienceActionButton();
                    Click_ABGrid_AudienceInactive();
                    break;
            }

        }
        public static void Click_AB_CustomerDetal_SearchButton()
        {
            ElementClick(Driver.FindElement(By.XPath("//div[@id='customerDetailsContent']/div/div[2]/div/div[3]/div/button[2]")));
            Logger.WriteDebugMessage("Clicked on Search Button");
            AddDelay(20000);
            ScrollToElement(Driver.FindElement(By.XPath("//div[@id='customerDetailsContent']/div/div[2]/div/div[3]/div/button[2]")));
        }
        public static void Click_AB_CustomerDetail_ResetButton()
        {
            ElementClick(Driver.FindElement(By.XPath("//button[contains (text(), 'Reset')]")));
            Logger.WriteDebugMessage("Clicked on Reset Button");
            AddDelay(20000);
        }
        public static void AB_Search_EnterTextTags(string tagValue)
        {
            Driver.FindElement(By.XPath("//*[@id='selectTags']/div/div/ul/li/input")).SendKeys(tagValue);
            Driver.FindElement(By.XPath("//*[@id='selectTags']/div/div/ul/li/input")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Selected Tags" + tagValue);
        }
        public static void AB_Search_EnterProperties(string propertyValue)
        {
            Driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(propertyValue);
            Driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Selected Properties" + propertyValue);
        }

        public static void ActivateInActivateAudience()
        {
            ElementClick(PageObject_AudienceBuilder.AB_Grid_ButtonAction());
            Logger.WriteDebugMessage("Clicked Action Button.");
            ElementClick(Driver.FindElement(By.XPath("//div[@id='toggleStatus']/label")));
            Logger.WriteDebugMessage("Clicked Active-Inactive Toggle button.");
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Deactivate')]")));
            AddDelay(8000);
            Logger.WriteDebugMessage("Clicked Deactivated audience.");

        }

        public static void HoverOverMouse(string audienceName)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            //var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[contains(text(), '"+ audienceName + "')]")));
            //Actions action = new Actions(Driver);
            //action.MoveToElement(element).Perform();
            ////Waiting for the menu to be displayed    
            //AddDelay(2000);

            Logger.WriteInfoMessage("Tooltip does not show due to selenium unable to hoverover mouse over Audience Name");
            if (VerifyTextOnPage("..."))
            {
                Logger.WriteDebugMessage("More than 250 character is wrapped with ...");
            }
        }
        public static void SelectEmailStatus(string statusName)
        {
            string[] getstatusName = Regex.Split(statusName, ",");
            foreach (string eachstatusName in getstatusName)
            {
                ElementClick(Driver.FindElement(By.XPath("//*[@id='customerDetailsContent']/div/div[2]/div/div[1]/div[4]/div/div[1]/ul/li")));
                Driver.FindElement(By.XPath("//*[@id='customerDetailsContent']/div/div[2]/div/div[1]/div[4]/div/div[1]/ul/li/input")).Click();
                Driver.FindElement(By.XPath("//*[@id='customerDetailsContent']/div/div[2]/div/div[1]/div[4]/div/div[1]/ul/li/input")).SendKeys(eachstatusName + Keys.Enter);
                Logger.WriteDebugMessage(eachstatusName + " selected.");
            }
        }

        public static void SelectHistoryPageEntry(string value)
        {
            ScrollToElement(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));
            AddDelay(1500);
            ElementClick(Driver.FindElement(By.Name("tableAudienceHistory_length")));
            AddDelay(1000);
            Driver.FindElement(By.Name("tableAudienceHistory_length")).SendKeys(value);
            AddDelay(10000);
            Driver.FindElement(By.Name("tableAudienceHistory_length")).SendKeys(Keys.Enter);
            AddDelay(3000);

            Logger.WriteDebugMessage("Selected Page Entry Value as - " + value);

            ScrollToElement(Driver.FindElement(By.Id("tableAudienceHistory_info")));
            Logger.WriteDebugMessage("Selected Page Entry Value as - " + value);
        }
        public static void PublishAudience()
        {
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")));
            Logger.WriteDebugMessage("Clicked on Save and Publish button.");
            ElementClick(Driver.FindElement(By.XPath("(//button[contains(text(), 'Publish')])[2]")));
            Logger.WriteDebugMessage("Clicked on Publish Button");
        }
        public static void EditAudienceName(string value)
        {

            ElementClick(Driver.FindElement(By.Id("editAudienceName")));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver;
            Driver.FindElement(By.XPath("//input[@id='audienceName']")).SendKeys(Keys.Shift + Keys.Home + Keys.Delete);
            Driver.FindElement(By.XPath("//input[@id='audienceName']")).SendKeys(value);
            Logger.WriteDebugMessage("Updated Audience " + value);
        }

        //public static void GenerateAudience(AudienceBuilder builderData, string companyName)
        //{
        //    /*Pre-Requisite */
        //    string audienceName = SqlWarehouseQuery.ReturnCompanyName("NA", "AudienceName", TestPlanId) + TestPlanId;
        //    string dynamicCriteriaJSON = SqlWarehouseQuery.ReturnDescriptionValue("NA", "AudienceName", TestPlanId);

        //    SqlWarehouseQuery.createAudience(companyName, builderData, audienceName, dynamicCriteriaJSON, TestData.CommonFrontendEmail);

        //    if (builderData.AudienceDetailID == "1")
        //    {
        //        Logger.WriteInfoMessage("Audience Name " + audienceName + " already exist.");
        //    }
        //    else
        //    {
        //        Logger.WriteInfoMessage("Created a new Audience Name " + audienceName);
        //    }
        //}
        //public static void WaitforDataTableLoad_Custo()
        //{
        //    //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(2));
        //    //IWebElement el = wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[contains(text(), 'Loading...')]")));

        //    WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
        //}

        public static void CompareAudienceCriteria(string audienceName, string newAudience, string companyName, string casetype, string AudiecneSaveType = null, string newAudiecneSaveType = null)
        {
            JObject sourceJObject;
            JObject targetJObject;
            //Diffenciate 
            switch (casetype)
            {
                case "checkdifferece":

                    string originalAudience = SqlWarehouseQuery.GetAudienceCriteria(audienceName, companyName);
                    string clonedAudience = SqlWarehouseQuery.GetAudienceCriteria(newAudience, companyName);

                    sourceJObject = JsonConvert.DeserializeObject<JObject>(originalAudience);
                    targetJObject = JsonConvert.DeserializeObject<JObject>(clonedAudience);


                    if (!JToken.DeepEquals(sourceJObject, targetJObject))
                    {
                        //Console.WriteLine("Not equals");
                        foreach (KeyValuePair<string, JToken> sourceProperty in sourceJObject)
                        {
                            JProperty targetProp = targetJObject.Property(sourceProperty.Key);
                            if (JToken.DeepEquals(sourceProperty.Value, targetProp.Value))
                            {
                                Logger.WriteInfoMessage(string.Format("{0} value is not changed", sourceProperty.Key));
                            }
                            if (!JToken.DeepEquals(sourceProperty.Value, targetProp.Value))
                            {
                                Logger.WriteInfoMessage(string.Format("{0} value is changed", sourceProperty.Key));
                            }
                            else
                            {

                            }
                        }
                    }
                    break;
                case "checkspecificdifferece":

                    originalAudience = SqlWarehouseQuery.GetAudienceCriteria(audienceName, companyName, AudiecneSaveType, "getSpecificCriteria");
                    clonedAudience = SqlWarehouseQuery.GetAudienceCriteria(newAudience, companyName, newAudiecneSaveType, "getSpecificCriteria");

                    sourceJObject = JsonConvert.DeserializeObject<JObject>(originalAudience);
                    targetJObject = JsonConvert.DeserializeObject<JObject>(clonedAudience);


                    if (!JToken.DeepEquals(sourceJObject, targetJObject))
                    {
                        //Console.WriteLine("Not equals");
                        foreach (KeyValuePair<string, JToken> sourceProperty in sourceJObject)
                        {
                            JProperty targetProp = targetJObject.Property(sourceProperty.Key);
                            if (JToken.DeepEquals(sourceProperty.Value, targetProp.Value))
                            {
                                Logger.WriteInfoMessage(string.Format("{0} value is not changed", sourceProperty.Key));
                            }
                            if (!JToken.DeepEquals(sourceProperty.Value, targetProp.Value))
                            {
                                Logger.WriteInfoMessage(string.Format("{0} value is changed", sourceProperty.Key));
                            }
                            else
                            {

                            }
                        }
                    }
                    break;
            }
        }

        public static List<String> GetAssociatedCampaignDetails(string PID)
        {

            string campaignname = GetText(Driver.FindElement(By.XPath("//span[contains(text(), '" + PID + "')]/parent::td/parent::tr/td[2]")));
            string status = GetText(Driver.FindElement(By.XPath("//span[contains(text(), '" + PID + "')]/parent::td/parent::tr/td[4]")));

            //changing status to the values that will be found in the database
            if (status == "Scheduled Inactive" || status == "Scheduled Active")
                status = "Scheduled";
            else if (status == "Rejected")
                status = "Disapproved";
            else if (status == "Testing")
                status = "AwaitingDeliverabilityReport";
            else if (status == "Pending")
                status = "AwaitingApproval";
            else if (status == "Rejected")
                status = "Disapproved";


            List<String> AssociatedCampaignDetails = new List<String>
                {
                    campaignname,
                    status
                };

            return AssociatedCampaignDetails;

        }
    }
}
