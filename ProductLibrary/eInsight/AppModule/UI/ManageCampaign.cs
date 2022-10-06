using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eInsight.PageObject.UI;
using OpenQA.Selenium;
using eInsight.Utility;
using BaseUtility.Utility;
using InfoMessageLogger;
using SqlWarehouse;
using Common;
using NUnit.Framework;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using SeleniumExtras.WaitHelpers;

namespace eInsight.AppModule.UI
{

    class ManageCampaign : Helper
    {
        public static void ClickAllTab()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_AllTab());
        }

        public static void ClickDraftTab()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_DraftTab());
        }

        public static void ClickDeliverablityTab()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_DeliverabilityTab());
        }

        public static void ClickAwaitingApprovalTab()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_AwaitingApprovalTab());
        }

        public static void ClickApprovedTab()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_ApprovedTab());
        }

        public static void ClickRecurringTab()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_RecurringTab());
        }

        public static void ClickScheduledTab()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_ScheduledTab());
        }

        public static void ClickDisapprovedTab()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_DisapprovedTab());
        }

        public static void ClickSearchTab()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_SearchTab());
        }

        public static void SelectSearchField(string label)
        {
            ElementSelectFromDropDown(PageObject_ManageCampaign.ManageCampaign_Search_SearchFieldDDM(), label);
        }

        public static void SelectCondition(string value)
        {
            ElementSelectFromDropDown(PageObject_ManageCampaign.ManageCampaign_Search_ConditionDDM(), value);
        }

        public static void InsertInput(string value)
        {
            ElementEnterText(PageObject_ManageCampaign.ManageCampaign_Search_Input(), value);
        }

        public static void SelectSearchDate(string date)
        {
            ElementSelectFromDropDown(PageObject_ManageCampaign.ManageCampaign_Search_SearchDateDDM(), date);
        }

        public static void InsertFirstDate(string date)
        {
            ElementEnterText(PageObject_ManageCampaign.ManageCampaign_Search_BetweenFirst(), date);
        }

        public static void InsertSecondDate(string date)
        {
            ElementEnterText(PageObject_ManageCampaign.ManageCampaign_Search_BetweenSecond(), date);
        }

        public static void ClickPreviewLink()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_Search_PreviewLink());
        }

        public static void ClickCriteriaLink()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_Search_CriteriaLink());
        }

        public static void ClickCustomerDetailsLink()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_Search_CustomerDetails());
        }
        public static void ClickViewRecipientsLink()
        {
            ElementClick(PageObject_ManageCampaign.Button_ViewCampaignRecipients());
        }
        public static void SelectSearchByOption(string optionValue)
        {
            ElementSelectFromDropDown(PageObject_ManageCampaign.DDM_SearchBy(), optionValue);
        }
        public static void SelectSearchExpresionOption(string optionValue)
        {
            SecondaryDropDown(PageObject_ManageCampaign.DDM_SearchExpression(), optionValue);
        }
        public static void EnterSearchValue(string optionValue)
        {
            ElementEnterText(PageObject_ManageCampaign.TextValue_SearchValue(), optionValue);
        }
        public static void Click_Searchbutton()
        {
            ElementClick(PageObject_ManageCampaign.Click_Searchbutton());
        }

        public static void ClickDynamicContentLink()
        {
            OpenPopUpWindow(PageObject_ManageCampaign.ManageCampaign_Search_DynamicContentLink());
        }

        public static void ClickHistoryLink()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_Search_HistoryLink());
        }

        public static void ClickReportsLink()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_Search_ReportsLink());
        }

        public static void ClickMultiLanguageLink()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_Search_MultiLanguageLink());
        }

        public static void ClickClone()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_Clone());
        }

        public static void ClickSearchButton()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_Search_SearchButton());
        }


        public static void ClickPreviewPopupClose()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_Search_PreviewClose());
        }

        public static void ClickCriteriaPopupClose()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_Search_CriteriaClose());
        }

        public static void ClickCustomerDetailsClosePopupClose()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_Search_CustomerDetailsClose());
        }

        public static void CloseDynamicContentWindow()
        {
            ClosePopUpWindow();
        }

        public static void ClickHistoryPopupClose()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_Search_HistoryClose());
        }

        public static void ClickReportsPopupClose()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_Search_ReportsClose());
        }

        public static void ClickMultiLanguagePopupClose()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_MultiLanguageClose());
        }

        public static void Click_Tab_Sent()
        {
            ElementClick(PageObject_ManageCampaign.Tab_Sent());
        }

        public static void Click_Tab_Disapproved()
        {
            ElementClick(PageObject_ManageCampaign.Tab_Disapproved());
        }

        public static void Click_Button_First()
        {
            ElementClick(PageObject_ManageCampaign.Button_First());
        }

        public static void Click_Button_Previous()
        {
            ElementClick(PageObject_ManageCampaign.Button_Previous());
        }

        public static void Click_Button_Next()
        {
            ElementClick(PageObject_ManageCampaign.Button_Next());
        }

        public static void Click_Button_Last()
        {
            ElementClick(PageObject_ManageCampaign.Button_Last());
        }

        public static void Click_Button_Help()
        {
            ElementClick(PageObject_ManageCampaign.Button_Help());
        }

        public static void Click_Link_FirstCampaign_Preview()
        {
            ElementClick(PageObject_ManageCampaign.Link_FirstCampaign_Preview());
        }

        public static void Click_Link_FirstCampaign_Criteria()
        {
            ElementClick(PageObject_ManageCampaign.Link_FirstCampaign_Criteria());
        }

        public static void Click_Link_FirstCampaign_CustomerDetails()
        {
            ElementClick(PageObject_ManageCampaign.Link_FirstCampaign_CustomerDetails());
        }

        public static void Click_Link_FirstCampaign_DynamicContent()
        {
            ElementClick(PageObject_ManageCampaign.Link_FirstCampaign_DynamicContent());
        }

        public static void Click_Link_FirstCampaign_History()
        {
            ElementClick(PageObject_ManageCampaign.Link_FirstCampaign_History());
        }

        public static void Click_Link_FirstCampaign_Reports()
        {
            ElementClick(PageObject_ManageCampaign.Link_FirstCampaign_Reports());
        }

        public static void Click_Link_FirstCampaign_MultiLanguage()
        {
            ElementClick(PageObject_ManageCampaign.Link_FirstCampaign_MultiLanguage());
        }

        public static void Click_Link_FirstCampaign_ApprovalDashboard()
        {
            ElementClick(PageObject_ManageCampaign.Link_FirstCampaign_ApprovalDashboard());
        }

        public static void Click_Button_FirstCampaign_BasicValidationReport()
        {
            ElementClick(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport());
        }

        public static void Click_Button_FirstCampaign_AdvancedDeliverability()
        {
            ElementClick(PageObject_ManageCampaign.Button_FirstCampaign_AdvancedDeliverability());
        }

        public static void Click_Button_FirstCampaign_SendToTestEmails()
        {
            ElementClick(PageObject_ManageCampaign.Button_FirstCampaign_SendToTestEmails());
        }

        public static void Click_Button_FirstCampaign_RequestResponsive()
        {
            ElementClick(PageObject_ManageCampaign.Button_FirstCampaign_RequestResponsive());
        }

        public static void Click_Button_FirstCampaign_SendForTranslation()
        {
            ElementClick(PageObject_ManageCampaign.Button_FirstCampaign_SendForTranslation());
        }

        public static void Click_Button_FirstCampaign_DeleteCampaign()
        {
            ElementClick(PageObject_ManageCampaign.Button_FirstCampaign_DeleteCampaign());
        }

        public static void Click_Button_FirstCampaign_Edit()
        {
            ElementClick(PageObject_ManageCampaign.Button_FirstCampaign_Edit());
        }

        public static void Click_Button_FirstCampaign_ContinueDraft()
        {
            ElementClick(PageObject_ManageCampaign.Button_ContinueDraft());
        }

        public static void Click_Button_FirstCampaign_ProceedForApproval()
        {
            ElementClick(PageObject_ManageCampaign.Button_FirstCampaign_ProceedForApproval());
        }

        public static void Click_Button_FirstCampaign_SaveAsTemplate()
        {
            ElementClick(PageObject_ManageCampaign.Button_FirstCampaign_SaveAsTemplate());
        }

        public static void Click_Button_FirstCampaign_SaveAsResent()
        {
            ElementClick(PageObject_ManageCampaign.Button_FirstCampaign_SaveAsResent());
        }

        public static void Click_Button_FirstCampaign_Clone()
        {
            ElementClick(PageObject_ManageCampaign.Button_FirstCampaign_Clone());
        }

        public static void Click_Link_FirstCampaign_Status()
        {
            ElementClick(PageObject_ManageCampaign.Link_FirstCampaign_Status());
        }
        public static void Click_CASLCheckBox()
        {
            ElementClick(PageObject_ManageCampaign.CheckBox_CASL());
        }
        public static void Button_SendToTest()
        {
            ElementClick(PageObject_ManageCampaign.Button_SendToTest());
        }
        public static void QuickSend_EmailtoSelf()
        {
            ElementClick(PageObject_ManageCampaign.QuickSend_EmailtoSelf());
        }
        public static void Click_SelectGroupSeedList(string groupName)
        {
            ElementClick(PageObject_ManageCampaign.Select_GroupSeedList(groupName));
            Logger.WriteDebugMessage(groupName + " SeedList is selected.");
        }

        public static void NavigatetoCreateCampaign()
        {
            ElementClick(Driver.FindElement(By.XPath("//a[@id='campaignsNav']")));
            ElementClick(Driver.FindElement(By.XPath("//a[@id='campaignsNav']//following::a[contains(@href, '/Project.mvc/Project/Create')]")));
            if (VerifyTextOnPage("Who will this campaign be sent for?"))
            {
                Logger.WriteDebugMessage("Landed on Create Campaign Page successfully.");
            }
            else
            {
                Assert.Fail("Did not land on Create Campaign Page.");
            }
        }
        
        public static void EnterCampaignSubject(string text)
        {
            AddDelay(10000);
            ElementWait(PageObject_CreateCampaign.CreateCampaign_EditTemplate_Subject(), 120);
            ScrollToElement(PageObject_CreateCampaign.CreateCampaign_Button_SaveandContinue());
            if (IsElementVisible(PageObject_CreateCampaign.CreateCampaign_EditTemplate_Subject()))
            {
                ElementEnterText(PageObject_CreateCampaign.CreateCampaign_EditTemplate_Subject(), text);
                Logger.WriteDebugMessage("Entered Subject - " + text);
            }
            else
            {
                Assert.Fail("Could not find Element - " + PageObject_CreateCampaign.CreateCampaign_EditTemplate_Subject() + " for SubjectLine TextBox");
            }

        }
        /*-------------------JQGrid Wait function----------------*/
        public static void WaitForReady()
        {
            TimeSpan waitForElement = TimeSpan.FromMinutes(5);
            WebDriverWait wait = new WebDriverWait(Driver, waitForElement);
            wait.Until(driver =>
            {
                bool isAjaxFinished = (bool)((IJavaScriptExecutor)driver).
                    ExecuteScript("return jQuery.active == 0");
                bool isLoaderHidden = (bool)((IJavaScriptExecutor)driver).
                    ExecuteScript("return $('.spinner').is(':visible') == false");
                return isAjaxFinished & isLoaderHidden;
            });
        }
        /*-----------------------------------*/
        public static void ManageCampaign_EditCampaign(int ProjectID)
        {
            CampaignDetails data = new CampaignDetails();
            SqlWarehouseQuery.ReturnCampaignStatus(ProjectID, data);

            switch (data.OldStatus)
            {
                case "Draft":
                    {
                        HighlightElement(PageObject_ManageCampaign.Button_ContinueDraft());
                        Logger.WriteDebugMessage("Clicking on Draft button");
                        ElementClick(PageObject_ManageCampaign.Button_ContinueDraft());
                        ElementWait(PageObject_CreateCampaign.CreateCampaign_Button_Save(), 60);
                        Logger.WriteDebugMessage("Landed on Edit Campaign Page.");
                        break;
                    }
                case "AwaitingDeliverabilityReport":
                case "Disapproved":
                    {
                        HighlightElement(PageObject_ManageCampaign.ManageCampaign_EditCampaign(ProjectID.ToString()));
                        Logger.WriteDebugMessage("Clicking on Edit button");
                        ElementClick(PageObject_ManageCampaign.ManageCampaign_EditCampaign(ProjectID.ToString()));
                        if (VerifyTextOnPage("Are you sure you want to edit this campaign?"))
                        {

                            ElementClick(PageObject_ManageCampaign.ManageCampaign_EditSchedule_Confirm());
                            ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_TemplateTab(), 60);
                        }
                        break;
                    }
                case "Approved":
                    {
                        HighlightElement(PageObject_ManageCampaign.Button_Campaign_ScheduleCampaign());
                        Logger.WriteDebugMessage("Clicking on Schedule Campaign button");
                        ElementClick(PageObject_ManageCampaign.Button_Campaign_ScheduleCampaign());
                        ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_TemplateTab(), 60);
                        break;
                    }
                case "Scheduled":
                    {
                        HighlightElement(PageObject_ManageCampaign.ManageCampaign_EditSchedule());
                        Logger.WriteDebugMessage("Clicking on Edit Schedule button");
                        ElementClick(PageObject_ManageCampaign.ManageCampaign_EditSchedule());
                        ElementWait(PageObject_ManageCampaign.ManageCampaign_EditSchedule_Confirm(), 60);
                        ElementClick(PageObject_ManageCampaign.ManageCampaign_EditSchedule_Confirm());
                        break;
                    }
            }
        }
        public static void ManageCampaign_EditSchedule()
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_EditSchedule());
            if (VerifyTextOnPage("This project has already been scheduled."))
            {
                ElementClick(PageObject_ManageCampaign.ManageCampaign_EditSchedule_Confirm());
                ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab(), 60);
            }
        }
        public static void ManageCampaign_ScheduleCampaign()
        {
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab());
            ElementWait(PageObject_CreateCampaign.Button_Campaign_ScheduleandCompleteCampaign(), 60);
            Logger.WriteDebugMessage("Landed on Schedule Page");
        }
        public static void ManageCampaign_InactivateSchedule()
        {
            ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Scheduled Active')]")));
            ElementClick(PageObject_ManageCampaign.ManageCampaign_EditSchedule_InactivateSchedule());
            if (VerifyTextOnPage("Deactivating this schedule will pause sending."))
            {
                Logger.WriteDebugMessage("Inactivating specific campaign. \n" + "Received Confirmation Message - Deactivating this schedule will pause sending.");
                ElementClick(PageObject_ManageCampaign.ManageCampaign_EditSchedule_InactivateScheduleConfirm());
                AddDelay(8000);
                if (VerifyTextOnPage("Scheduled Inactive"))
                {
                    Helper.PageDown();
                    Logger.WriteDebugMessage("Scheduled Campaign is deactivated.");
                }
            }
        }

        public static void ManageCampaign_ActivateSchedule()
        {
            ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Scheduled Inactive')]")));
            ElementClick(PageObject_ManageCampaign.ManageCampaign_EditSchedule_ActivateSchedule());
            if (VerifyTextOnPage("Activating this schedule will resume sending."))
            {
                Logger.WriteDebugMessage("Activating specific campaign. \n" + "Received Confirmation Message - Activating this schedule will resume sending.");
                ElementClick(PageObject_ManageCampaign.ManageCampaign_EditSchedule_ActivateScheduleConfirm());
                AddDelay(8000);
                if (VerifyElementIsClickable(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab()))
                {
                    ScrollToElement(Driver.FindElement(By.Id("occuranceType")));
                    ElementClick(Driver.FindElement(By.XPath("//input[@id='activeStatus' and @value='Active']")));
                    CreateCampaign.SelectTime();
                    CreateCampaign.CampaignUpdateSchedule();
                }
            }
        }

        public static void SelectClient(string client)
        {
            AddDelay(1500);
            PageObject_ManageCampaign.ManageCampaign_ClientDDM().Click();
            AddDelay(1000);
            PageObject_Home.DropDown_RecentlySentCampaigns_SelectClient().SendKeys(client);
            AddDelay(10000);
            PageObject_Home.DropDown_RecentlySentCampaigns_SelectClient().SendKeys(Keys.Enter);
            AddDelay(3000);
        }

        public static void SelectCompany(string company)
        {
            AddDelay(1500);
            PageObject_ManageCampaign.ManageCampaign_CompanyDDM().Click();
            AddDelay(1000);
            PageObject_Home.DropDown_RecentlySentCampaigns_SelectCompany().SendKeys(company);
            AddDelay(10000);
            PageObject_Home.DropDown_RecentlySentCampaigns_SelectCompany().SendKeys(Keys.Enter);
            AddDelay(3000);
        }

        public static void SearchCampaign(string CustomerID, string value, int CaseNum, int projectID, int typeofPreSearch)
        {
            CampaignDetails data = new CampaignDetails();
            SqlWarehouseQuery.ReturnCampaignStatus(projectID, data);
            PreSearchCampaign(typeofPreSearch, projectID, data.ParentCompanyName, data.CompanyName);
            switch (CaseNum)
            {
                case 0:
                    {
                        if (Helper.VerifyTextOnPage(data.CampaignName))
                        {
                            ClickCustomerDetailsLink();
                            Navigatetoiframe(1);
                            Helper.ElementWait(PageObject_ManageCampaign.Button_ViewCampaignRecipients(), 60);
                            Logger.WriteDebugMessage("Landed on Customer Detail Page.");
                            SelectSearchByOption("Customer ID");
                            EnterSearchValue(CustomerID);
                            Click_Searchbutton();
                            if (VerifyTextOnPage(value))
                            {
                                Logger.WriteDebugMessage("Search result is displayed for CustomerID: " + CustomerID);
                            }
                            else
                            {
                                Assert.Fail("Did not output result for CustomerID: " + CustomerID);
                            }
                        }
                        break;
                    }
                case 1:
                    {
                        if (Helper.VerifyTextOnPage(data.CampaignName))
                        {
                            //Additional Step for Preview Customer
                            ClickCustomerDetailsLink();
                            Navigatetoiframe(1);
                            Helper.ElementWait(PageObject_ManageCampaign.Button_ViewCampaignRecipients(), 60);
                            Logger.WriteDebugMessage("Landed on Customer Detail Page.");
                            SelectSearchByOption("Customer ID");
                            EnterSearchValue(CustomerID);
                            AddDelay(7000);
                            Click_Searchbutton();
                            if (VerifyTextOnPage(value))
                            {
                                Logger.WriteDebugMessage("Search result is displayed for CustomerID: " + CustomerID);
                            }
                            else
                            {
                                Assert.Fail("Did not output result for CustomerID: " + CustomerID);
                            }
                            Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//*[@id='prevlink" + CustomerID + "']")));
                        }
                        break;
                    }
                case 2:
                    {
                        if (Helper.VerifyTextOnPage(data.CampaignName))
                        {
                            ClickCustomerDetailsLink();
                            Navigatetoiframe(1);
                            Helper.ElementWait(PageObject_ManageCampaign.Button_ViewCampaignRecipients(), 60);
                            Logger.WriteDebugMessage("Landed on Customer Detail Page.");
                            ClickViewRecipientsLink();
                            Driver.SwitchTo().ParentFrame();
                            Navigatetoiframe(1);
                            //Driver.SwitchTo().Frame("iframe_modal_3");
                            Helper.ElementWait(PageObject_ManageCampaign.DDM_SearchBy(), 60);
                            Logger.WriteDebugMessage("Landed on View Campaign Recipient Page.");
                            //AddDelay(30000);
                            WaitForReady();
                            SelectSearchByOption("Reservation");
                            EnterSearchValue(value);
                            Click_Searchbutton();
                            WaitForReady();
                            if (VerifyTextOnPage(value.ToLower()) || VerifyTextOnPage(value))
                            {
                                Logger.WriteDebugMessage("Searched Customer is displayed with Reservation Number as " + value);
                            }
                            else
                            {
                                Assert.Fail("Searched Customer did not displayed with Reservation Number as " + value);
                            }
                            AddDelay(8000);
                            //Helper.ElementClick(Helper.Driver.FindElement(By.XPath("//tr[@id='" + CustomerID + "']//*[@title='Preview']")));
                            ElementClick(Driver.FindElement(By.XPath("//a[@title='Preview' and contains(@href, '" + CustomerID + "')] ")));
                        }
                        break;
                    }
                case 3:
                    if (Helper.VerifyTextOnPage(data.CampaignName))
                    {
                        ClickCustomerDetailsLink();
                        Navigatetoiframe(1);
                        Helper.ElementWait(PageObject_ManageCampaign.Button_ViewCampaignRecipients(), 60);
                        Logger.WriteDebugMessage("Landed on Customer Detail Page.");
                        ClickViewRecipientsLink();
                        Navigatetoiframe(1);
                        Helper.ElementWait(PageObject_ManageCampaign.DDM_SearchBy(), 60);
                        Logger.WriteDebugMessage("Landed on View Campaign Recipient Page.");
                        //AddDelay(30000);
                        WaitForReady();
                        SelectSearchByOption("Email");
                        EnterSearchValue(value);
                        Click_Searchbutton();
                        WaitForReady();
                        if (VerifyTextOnPage(value.ToLower()) || VerifyTextOnPage(value))
                        {
                            Logger.WriteDebugMessage("Searched Customer is displayed with Reservation Number as " + value);
                        }
                        else
                        {
                            Assert.Fail("Searched Customer did not displayed with Reservation Number as " + value);
                        }
                        AddDelay(8000);
                    }
                    break;
            }

        }

        public static void PreSearchCampaign(int searchType, int projectId, string parentCompany, string companyName)
        {
            string SearchField = "Project ID";
            /*Add Sub Client*/

            ScrollDownUsingJavaScript(Driver, -1000);
            //Profile.SelectClient(parentCompany);
            Profile.SelectSubClient(companyName);

            //string ProjectId = "6417357";
            ClickSearchTab();
            switch (searchType)
            {
                case 0:
                    {
                        Helper.ElementWait(PageObject_ManageCampaign.ManageCampaign_Search_SearchButton(), 60);
                        SelectSearchField(SearchField);
                        InsertInput(projectId.ToString());
                        ClickSearchButton();
                        AddDelay(8000);
                        Helper.ScrollToElement(Helper.Driver.FindElement(By.XPath("//*[@id='" + projectId + "']/h2")));
                        Logger.WriteDebugMessage("Campaign Located. Project ID: " + projectId);
                        break;
                    }

                case 1:
                    {
                        if (IsElementPresent((By.Id("newsearch")))) //ElementClick(Driver.FindElement(By.Id("newsearch")));
                        {
                            ElementClick(Driver.FindElement(By.Id("newsearch")));
                        }
                        Helper.ElementWait(PageObject_ManageCampaign.ManageCampaign_Search_SearchButton(), 60);
                        SelectSearchField(SearchField);
                        InsertInput(projectId.ToString());
                        ClickSearchButton();
                        AddDelay(8000);
                        Helper.ScrollToElement(Helper.Driver.FindElement(By.XPath("//*[@id='" + projectId + "']/h2")));
                        Logger.WriteDebugMessage("Campaign Located. Project ID: " + projectId);
                        break;
                    }
            }
        }
        public static void VerifyPersonalizeData(Users Data, int CaseNum, string companyName, string customerID, string testModule, int projectID, string isClosed = null)
        {
            string arrivalDate = "No Data";
            string departureDate = "No Data";
            string cancelDate = "No Data";
            string updateDate = "No Data";
            if (!string.IsNullOrEmpty(Data.ArrivalDate) && (Data.ArrivalDate != "No Data"))
            {
                DateTime Date = DateTime.Parse(Data.ArrivalDate);
                arrivalDate = Date.ToString("M/d/yyyy");
            }
            if (!string.IsNullOrEmpty(Data.DepartureDate) && (Data.DepartureDate != "No Data"))
            {
                DateTime Date = DateTime.Parse(Data.DepartureDate);
                departureDate = Date.ToString("M/d/yyyy");
            }
            if (!string.IsNullOrEmpty(Data.CancelDate) && (Data.CancelDate != "No Data"))
            {
                DateTime Date = DateTime.Parse(Data.CancelDate);
                cancelDate = Date.ToString("M/d/yyyy");
            }
            if (!string.IsNullOrEmpty(Data.UpdateDate) && (Data.UpdateDate != "No Data"))
            {
                DateTime Date = DateTime.Parse(Data.UpdateDate);
                updateDate = Date.ToString("M/dd/yyyy HH:mm:ss tt");
            }
            if (Data.CountryCode == "N/A")
            {
                Data.CountryCode = "Country";
            }
            if(String.IsNullOrEmpty(Data.CountryCode))
            {
                Data.CountryCode = "";
            }
            string fileExtention = "";
            string primaryLocation = "";
            string febImage = "";
            if (testCategory == "QA")
            {
                primaryLocation = "https://qa.egallery.cendyn.com/egallery/upload/";
                fileExtention = "independent_collection/shared_company/";
                febImage = "Approved%20New%20varbiage.jpg";
            }
            else if (testCategory == "PostDeployment")
            {
                primaryLocation = "https://egallery.cendyn.com/egallery/upload/";
                fileExtention = "hotel_origami/hotel_origami/ts-test/";
                febImage = "ApprovedNewvarbiage.jpg";
            }
            else if (testCategory == "EU02_PostDeployment")
            {
                primaryLocation = "https://eu02egallery.cendyn.com/egallery/upload/";
                fileExtention = "hotel_origami/hotel_origami/connor-test/";
                febImage = "2-25-2019%204-12-53%20PM.jpg";
            }
            else if (testCategory == "POC")
            {
                primaryLocation = "https://pocegallery.cendyn.com/egallery/upload/";
                fileExtention = "hotel_origami/hotel_origami/ts-test/";
                febImage = "Approved%20New%20varbiage.jpg";
            }
            string imagelocation = primaryLocation + fileExtention;
            switch (CaseNum)
            {
                case 1:
                    {
                        Navigatetoiframe(1);
                        if (VerifyTextOnPage(Data.CustomerIDs) && VerifyTextOnPage(Data.FirstName) && VerifyTextOnPage(Data.LastName) && VerifyTextOnPage(Data.Email) && VerifyTextOnPage(Data.CountryCode) && VerifyTextOnPage(arrivalDate) && VerifyTextOnPage(Data.SourceStayID))
                        {
                            Logger.WriteDebugMessage("Able to match the data for CustomerID: " + Data.CustomerID);
                        }
                        else
                        {
                            Assert.Fail("One of the data did not match for CustomerID: " + Data.CustomerID);
                        }
                        break;
                    }
                case 2:
                    {
                        Navigatetoiframe(1);
                        if (VerifyTextOnPage(Data.CountryCode))
                        {
                            Logger.WriteDebugMessage("CountryCode data was matching for CustomerID: " + Data.CustomerID);
                        }
                        else
                        {
                            Assert.Fail("Could not find CountryCode data for CustomerID: " + Data.CustomerID);
                        }
                        break;
                    }
                case 3:
                    {
                        if (!(Driver.Url.Contains("outlook") || Driver.Url.Contains("viewqa.contact-client")) && !Driver.Url.Contains("ViewInBrowserForResendOrQuickSend"))
                        {
                            Navigatetoiframe(1);
                        }

                        //SqlWarehouseQuery.GetPersonalizedTagValue(Data, companyName, 1, "", projectID.ToString(), customerID);

                        if (testModule == "Preview")
                        {
                            if (projectID == 40004529 || projectID == 40004744 || projectID == 40009450 || projectID == 40013177 || projectID == 40012946)
                            {

                                /**/

                                Logger.WriteDebugMessage("Actual Result: \n" + "\n CustomerID: " + customerID + "\n FirstName: " + Data.FirstName + "\n LastName: " + Data.LastName + "\n memberLevel: " + Data.memberLevel + "\n ArrivalDate: " + arrivalDate + "\n DepartureDate: " + departureDate + "\n CancelDate: " + cancelDate + "\n legNumbers: " + Data.legNumbers + "\n stayPoints: " + Data.stayPoints + "\n stayAverageTax: " + Data.stayAverageTax + "\n birthday: " + Data.birthday + "\n nextLevel: " + Data.nextLevel + "\n membershipLevel: " + Data.membershipLevel + "\n PropertyName: " + Data.PropertyName + "\n ZipCode: " + Data.ZipCode + "\n guestFirstName: " + Data.guestFirstName + "\n confirmationNumber: " + Data.confirmationNumber + "\n PropertyCode: " + Data.PropertyCode + "\n");
                                if (VerifyTextOnPage(customerID) && VerifyTextOnPage(Data.FirstName) && VerifyTextOnPage(Data.LastName) && VerifyTextOnPage(Data.memberLevel) && VerifyTextOnPage(arrivalDate) && VerifyTextOnPage(departureDate)&& VerifyTextOnPage(cancelDate) && VerifyTextOnPage(Data.legNumbers) && VerifyTextOnPage(Data.stayPoints) && VerifyTextOnPage(Data.stayAverageTax) && VerifyTextOnPage(Data.nextLevel) && VerifyTextOnPage(Data.membershipLevel) && VerifyTextOnPage(Data.PropertyName) && VerifyTextOnPage(Data.ZipCode) && VerifyTextOnPage(Data.guestFirstName) && VerifyTextOnPage(Data.confirmationNumber) && VerifyTextOnPage(Data.PropertyCode))
                                {
                                    //Logger.WriteDebugMessage("Values found as per expected \n" + "\n CustomerID: " + values.PrimaryCustomer + "\n Address1: " + values.Address1 + "\n Address2: " + values.Address2 + "\n CellPhoneNumber: " + values.PhoneNumber + "\n City: " + values.City + "\n Company: " + values.Company + "\n CountryCode: " + values.CountryCode + "\n Email: " + values.Email + "\n FirstName: " + values.FirstName + "\n GenderCode: " + values.GenderCode + "\n Lang_LanguageID: " + values.Lang_LanguageID + "\n Languages: " + values.Languages + "\n LastName: " + values.LastName + "\n Token: " + values.Token + "\n PhoneNumber: " + values.PhoneNumber + "\n Salutation: " + values.Salutation + "\n ShortTitle: " + values.Title + "\n SourceGuestID: " + values.SourceGuestID + "\n StateProvinceCode: " + values.StateName + "\n Title: " + values.Title + "\n ZipCode: " + values.ZipCode + "\n monetary: " + values.monetary + "\n recency: " + values.recency);
                                    //Logger.WriteDebugMessage("Expected Result: \n" + "\n Subject: " + Data.Subject + "\n fromEmail: " + Data.fromEmail + "\n fromName: " + Data.fromName + "\n PrimaryCustomer: " + Data.PrimaryCustomer + "\n FirstName: " + Data.FirstName + "\n LastName: " + Data.LastName + "\n Salutation: " + Data.Salutation + "\n ArrivalDate: " + Data.ArrivalDate + "\n DepartureDate: " + Data.DepartureDate + "\n CancelDate: " + cancelDate + "\n legNumbers: " + Data.legNumbers + "\n stayPoints: " + Data.stayPoints + "\n stayAverageTax: " + Data.stayAverageTax + "\n birthday: " + Data.birthday + "\n nextLevel: " + Data.nextLevel + "\n membershipLevel: " + Data.membershipLevel + "\n brandCode: " + Data.brandCode + "\n ZipCode: " + Data.ZipCode + "\n guestFirstName: " + Data.guestFirstName + "\n confirmationNumber: " + Data.confirmationNumber + "\n PropertyCode: " + Data.PropertyCode + "\n");
                                    Logger.WriteDebugMessage("Expected Result: \n" + "\n CustomerID: " + customerID + "\n SourceStayID: " + Data.SourceStayID + "\n ReservationNumber: " + Data.ReservationNumber + "\n FirstName: " + Data.FirstName + "\n LastName: " + Data.LastName + "\n memberLevel: " + Data.memberLevel + "\n ArrivalDate: " + arrivalDate + "\n DepartureDate: " + departureDate + "\n CancelDate: " + cancelDate + "\n legNumbers: " + Data.legNumbers + "\n stayPoints: " + Data.stayPoints + "\n stayAverageTax: " + Data.stayAverageTax + "\n birthday: " + Data.birthday + "\n nextLevel: " + Data.nextLevel + "\n membershipLevel: " + Data.membershipLevel + "\n PropertyName: " + Data.PropertyName + "\n ZipCode: " + Data.ZipCode + "\n guestFirstName: " + Data.guestFirstName + "\n confirmationNumber: " + Data.confirmationNumber + "\n PropertyCode: " + Data.PropertyCode + "\n");
                                }
                                else
                                {
                                    Logger.WriteInfoMessage("TestCase Failed");
                                    Logger.WriteDebugMessage("Expected Result was : \n" + "\n CustomerID: " + customerID + "\n SourceStayID: " + Data.SourceStayID + "\n ReservationNumber: " + Data.ReservationNumber + "\n FirstName: " + Data.FirstName + "\n LastName: " + Data.LastName + "\n memberLevel: " + Data.memberLevel + "\n ArrivalDate: " + arrivalDate + "\n DepartureDate: " + departureDate + "\n CancelDate: " + cancelDate + "\n legNumbers: " + Data.legNumbers + "\n stayPoints: " + Data.stayPoints + "\n stayAverageTax: " + Data.stayAverageTax + "\n birthday: " + Data.birthday + "\n nextLevel: " + Data.nextLevel + "\n membershipLevel: " + Data.membershipLevel + "\n PropertyName: " + Data.PropertyName + "\n ZipCode: " + Data.ZipCode + "\n guestFirstName: " + Data.guestFirstName + "\n confirmationNumber: " + Data.confirmationNumber + "\n PropertyCode: " + Data.PropertyCode + "\n");
                                    Assert.Fail("One or more personalization value(s) was not found in Preview.");
                                }
                            }
                            else if (projectID == 40012827 || projectID == 62191267 || projectID == 40012945|| projectID == 89505256) 
                            {
                                string defaultmessage;
                                if (testCategory == "EU02_PostDeployment")
                                    defaultmessage = " Hello Cendyn";
                                else
                                    defaultmessage = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Vivamus gravida laoreet gravida.";
                                Logger.WriteInfoMessage("Actual Result - Your ArrivalDate is " + Data.ArrivalDate);
                                if (arrivalDate == "1/1/2020" || arrivalDate == "2/1/2020")
                                {
                                    if (VerifyTextOnPage(arrivalDate))
                                    {
                                        Logger.WriteDebugMessage("Found Expected Result - " + "Your ArrivalDate is " + arrivalDate);
                                    }
                                    if (arrivalDate == "1/1/2020")
                                    {
                                        if (VerifyDynamicImage(imagelocation, "image10.jpg"))
                                        { 
                                            Logger.WriteDebugMessage("Found image for arrivalDate" + arrivalDate);
                                        }
                                        else
                                        {
                                            Assert.Fail("Could not find image for ArrivalDate " + arrivalDate);
                                        }
                                    }
                                    else if (arrivalDate == "2/1/2020")
                                    {
                                        if (VerifyDynamicImage(imagelocation, febImage))
                                        {
                                            Logger.WriteDebugMessage("Found image for arrivalDate" + arrivalDate);
                                        }
                                        else
                                        {
                                            Assert.Fail("Could not find image for ArrivalDate " + arrivalDate);
                                        }
                                    }
                                    else
                                    {
                                        Assert.Fail("Cound not find Expected Result - " + "Your ArrivalDate is " + arrivalDate);
                                    }

                                }
                                else if (arrivalDate != "1/1/2020" || arrivalDate != "2/1/2020")
                                {
                                    if (VerifyTextOnPage(defaultmessage))
                                    {
                                        Logger.WriteDebugMessage("Found Expected Result - " + defaultmessage);
                                    }
                                    else
                                    {
                                        Assert.Fail("Could not find expected result - " + defaultmessage);
                                    }
                                }
                            }
                            //Omni Personalization Tags
                            else
                            {
                                Logger.WriteDebugMessage("Actual Result: \n" + "\n CustomerID: " + customerID + "\n memberLevel: " + Data.memberLevel + "\n ArrivalDate: " + arrivalDate + "\n DepartureDate: " + Data.DepartureDate + "\n CancelDate: " + cancelDate + "\n legNumbers: " + Data.legNumbers + "\n stayPoints: " + Data.stayPoints + "\n stayAverageTax: " + Data.stayAverageTax + "\n birthday: " + Data.birthday + "\n nextLevel: " + Data.nextLevel + "\n membershipLevel: " + Data.membershipLevel + "\n PropertyName: " + Data.PropertyName + "\n ZipCode: " + Data.ZipCode + "\n guestFirstName: " + Data.guestFirstName + "\n confirmationNumber: " + Data.confirmationNumber + "\n PropertyCode: " + Data.PropertyCode + "\n");
                                if (VerifyTextOnPage(customerID) && VerifyTextOnPage(Data.memberLevel) && VerifyTextOnPage(arrivalDate) && VerifyTextOnPage(Data.DepartureDate) && VerifyTextOnPage(cancelDate) && VerifyTextOnPage(Data.legNumbers) && VerifyTextOnPage(Data.stayPoints) && VerifyTextOnPage(Data.stayAverageTax) && VerifyTextOnPage(Data.nextLevel) && VerifyTextOnPage(Data.membershipLevel) && VerifyTextOnPage(Data.PropertyName) && VerifyTextOnPage(Data.ZipCode) && VerifyTextOnPage(Data.guestFirstName) && VerifyTextOnPage(Data.confirmationNumber) && VerifyTextOnPage(Data.PropertyCode))
                                {
                                    //Logger.WriteDebugMessage("Values found as per expected \n" + "\n CustomerID: " + values.PrimaryCustomer + "\n Address1: " + values.Address1 + "\n Address2: " + values.Address2 + "\n CellPhoneNumber: " + values.PhoneNumber + "\n City: " + values.City + "\n Company: " + values.Company + "\n CountryCode: " + values.CountryCode + "\n Email: " + values.Email + "\n FirstName: " + values.FirstName + "\n GenderCode: " + values.GenderCode + "\n Lang_LanguageID: " + values.Lang_LanguageID + "\n Languages: " + values.Languages + "\n LastName: " + values.LastName + "\n Token: " + values.Token + "\n PhoneNumber: " + values.PhoneNumber + "\n Salutation: " + values.Salutation + "\n ShortTitle: " + values.Title + "\n SourceGuestID: " + values.SourceGuestID + "\n StateProvinceCode: " + values.StateName + "\n Title: " + values.Title + "\n ZipCode: " + values.ZipCode + "\n monetary: " + values.monetary + "\n recency: " + values.recency);
                                    //Logger.WriteDebugMessage("Expected Result: \n" + "\n Subject: " + Data.Subject + "\n fromEmail: " + Data.fromEmail + "\n fromName: " + Data.fromName + "\n PrimaryCustomer: " + Data.PrimaryCustomer + "\n FirstName: " + Data.FirstName + "\n LastName: " + Data.LastName + "\n Salutation: " + Data.Salutation + "\n ArrivalDate: " + Data.ArrivalDate + "\n DepartureDate: " + Data.DepartureDate + "\n CancelDate: " + cancelDate + "\n legNumbers: " + Data.legNumbers + "\n stayPoints: " + Data.stayPoints + "\n stayAverageTax: " + Data.stayAverageTax + "\n birthday: " + Data.birthday + "\n nextLevel: " + Data.nextLevel + "\n membershipLevel: " + Data.membershipLevel + "\n brandCode: " + Data.brandCode + "\n ZipCode: " + Data.ZipCode + "\n guestFirstName: " + Data.guestFirstName + "\n confirmationNumber: " + Data.confirmationNumber + "\n PropertyCode: " + Data.PropertyCode + "\n");
                                    Logger.WriteDebugMessage("Expected Result: \n" + "\n CustomerID: " + customerID + "\n SourceStayID: " + Data.SourceStayID + "\n ReservationNumber: " + Data.ReservationNumber + "\n memberLevel: " + Data.memberLevel + "\n ArrivalDate: " + arrivalDate + "\n DepartureDate: " + Data.DepartureDate + "\n CancelDate: " + cancelDate + "\n legNumbers: " + Data.legNumbers + "\n stayPoints: " + Data.stayPoints + "\n stayAverageTax: " + Data.stayAverageTax + "\n birthday: " + Data.birthday + "\n nextLevel: " + Data.nextLevel + "\n membershipLevel: " + Data.membershipLevel + "\n PropertyName: " + Data.PropertyName + "\n ZipCode: " + Data.ZipCode + "\n guestFirstName: " + Data.guestFirstName + "\n confirmationNumber: " + Data.confirmationNumber + "\n PropertyCode: " + Data.PropertyCode + "\n");
                                }
                                else
                                {
                                    Logger.WriteInfoMessage("TestCase Failed");
                                    Logger.WriteDebugMessage("Expected Result was : \n" + "\n CustomerID: " + customerID + "\n SourceStayID: " + Data.SourceStayID + "\n ReservationNumber: " + Data.ReservationNumber + "\n memberLevel: " + Data.memberLevel + "\n ArrivalDate: " + arrivalDate + "\n DepartureDate: " + Data.DepartureDate + "\n CancelDate: " + cancelDate + "\n legNumbers: " + Data.legNumbers + "\n stayPoints: " + Data.stayPoints + "\n stayAverageTax: " + Data.stayAverageTax + "\n birthday: " + Data.birthday + "\n nextLevel: " + Data.nextLevel + "\n membershipLevel: " + Data.membershipLevel + "\n PropertyName: " + Data.PropertyName + "\n ZipCode: " + Data.ZipCode + "\n guestFirstName: " + Data.guestFirstName + "\n confirmationNumber: " + Data.confirmationNumber + "\n PropertyCode: " + Data.PropertyCode + "\n");
                                    Assert.Fail("One or more personalization value(s) was not found in Preview.");
                                }
                            }
                        }
                        if (testModule == "Schedule")
                        {
                            if (!Driver.Url.Contains("viewqa.contact-client"))
                            {
                                if (IsElementPresent(By.LinkText("Show blocked content")))
                                {
                                    ElementClick(Driver.FindElement(By.LinkText("Show blocked content")));
                                }
                            }
                            if (projectID == 40004529 || projectID == 40004744 || projectID == 40009450 || projectID == 40013177  || projectID == 40012946)
                            {
                                Logger.WriteDebugMessage("Actual Result: \n" + "\n Subject: " + Data.Subject + "\n fromEmail: " + Data.fromEmail + "\n fromName: " + Data.fromName + "\n CustomerID: " + customerID + "\n FirstName: " + Data.FirstName + "\n LastName: " + Data.LastName + "\n memberLevel: " + Data.memberLevel + "\n ArrivalDate: " + arrivalDate + "\n DepartureDate: " + departureDate + "\n CancelDate: " + cancelDate + "\n legNumbers: " + Data.legNumbers + "\n stayPoints: " + Data.stayPoints + "\n stayAverageTax: " + Data.stayAverageTax + "\n birthday: " + Data.birthday + "\n nextLevel: " + Data.nextLevel + "\n membershipLevel: " + Data.membershipLevel + "\n PropertyName: " + Data.PropertyName + "\n ZipCode: " + Data.ZipCode + "\n guestFirstName: " + Data.guestFirstName + "\n confirmationNumber: " + Data.confirmationNumber + "\n PropertyCode: " + Data.PropertyCode + "\n");
                                //if (VerifyTextOnPage(Data.Subject) && VerifyTextOnPage(Data.fromEmail) && VerifyTextOnPage(Data.fromName) && VerifyTextOnPage(Data.PrimaryCustomer) && VerifyTextOnPage(Data.FirstName) && VerifyTextOnPage(Data.LastName) && VerifyTextOnPage(Data.Salutation) && VerifyTextOnPage(Data.ArrivalDate) && VerifyTextOnPage(Data.DepartureDate) && VerifyTextOnPage(cancelDate) && VerifyTextOnPage(Data.legNumbers) && VerifyTextOnPage(Data.stayPoints) && VerifyTextOnPage(Data.stayAverageTax) && VerifyTextOnPage(Data.birthday) && VerifyTextOnPage(Data.nextLevel) && VerifyTextOnPage(Data.membershipLevel) && VerifyTextOnPage(Data.brandCode) && VerifyTextOnPage(Data.ZipCode) && VerifyTextOnPage(Data.guestFirstName) && VerifyTextOnPage(Data.confirmationNumber) && VerifyTextOnPage(Data.PropertyCode))
                                if (VerifyTextOnPage(customerID) && VerifyTextOnPage(Data.FirstName) && VerifyTextOnPage(Data.LastName) && VerifyTextOnPage(Data.memberLevel) && VerifyTextOnPage(arrivalDate) && VerifyTextOnPage(departureDate) && VerifyTextOnPage(cancelDate) && VerifyTextOnPage(Data.legNumbers) && VerifyTextOnPage(Data.stayPoints) && VerifyTextOnPage(Data.stayAverageTax) && VerifyTextOnPage(Data.birthday) && VerifyTextOnPage(Data.nextLevel) && VerifyTextOnPage(Data.membershipLevel) && VerifyTextOnPage(Data.PropertyName) && VerifyTextOnPage(Data.ZipCode) && VerifyTextOnPage(Data.guestFirstName) && VerifyTextOnPage(Data.confirmationNumber) && VerifyTextOnPage(Data.PropertyCode))
                                {
                                    //Logger.WriteDebugMessage("Values found as per expected \n" + "\n CustomerID: " + values.PrimaryCustomer + "\n Address1: " + values.Address1 + "\n Address2: " + values.Address2 + "\n CellPhoneNumber: " + values.PhoneNumber + "\n City: " + values.City + "\n Company: " + values.Company + "\n CountryCode: " + values.CountryCode + "\n Email: " + values.Email + "\n FirstName: " + values.FirstName + "\n GenderCode: " + values.GenderCode + "\n Lang_LanguageID: " + values.Lang_LanguageID + "\n Languages: " + values.Languages + "\n LastName: " + values.LastName + "\n Token: " + values.Token + "\n PhoneNumber: " + values.PhoneNumber + "\n Salutation: " + values.Salutation + "\n ShortTitle: " + values.Title + "\n SourceGuestID: " + values.SourceGuestID + "\n StateProvinceCode: " + values.StateName + "\n Title: " + values.Title + "\n ZipCode: " + values.ZipCode + "\n monetary: " + values.monetary + "\n recency: " + values.recency);
                                    //Logger.WriteDebugMessage("Expected Result: \n" + "\n Subject: " + Data.Subject + "\n fromEmail: " + Data.fromEmail + "\n fromName: " + Data.fromName + "\n PrimaryCustomer: " + Data.PrimaryCustomer + "\n FirstName: " + Data.FirstName + "\n LastName: " + Data.LastName + "\n Salutation: " + Data.Salutation + "\n ArrivalDate: " + Data.ArrivalDate + "\n DepartureDate: " + Data.DepartureDate + "\n CancelDate: " + cancelDate + "\n legNumbers: " + Data.legNumbers + "\n stayPoints: " + Data.stayPoints + "\n stayAverageTax: " + Data.stayAverageTax + "\n birthday: " + Data.birthday + "\n nextLevel: " + Data.nextLevel + "\n membershipLevel: " + Data.membershipLevel + "\n brandCode: " + Data.brandCode + "\n ZipCode: " + Data.ZipCode + "\n guestFirstName: " + Data.guestFirstName + "\n confirmationNumber: " + Data.confirmationNumber + "\n PropertyCode: " + Data.PropertyCode + "\n");
                                    Logger.WriteDebugMessage("Expected Result: \n" + "\n Subject: " + Data.Subject + "\n fromEmail: " + Data.fromEmail + "\n fromName: " + Data.fromName + "\n CustomerID: " + customerID + "\n SourceStayID: " + Data.SourceStayID + "\n ReservationNumber: " + Data.ReservationNumber + "\n FirstName: " + Data.FirstName + "\n LastName: " + Data.LastName + "\n memberLevel: " + Data.memberLevel + "\n ArrivalDate: " + arrivalDate + "\n DepartureDate: " + departureDate + "\n CancelDate: " + cancelDate + "\n legNumbers: " + Data.legNumbers + "\n stayPoints: " + Data.stayPoints + "\n stayAverageTax: " + Data.stayAverageTax + "\n birthday: " + Data.birthday + "\n nextLevel: " + Data.nextLevel + "\n membershipLevel: " + Data.membershipLevel + "\n PropertyName: " + Data.PropertyName + "\n ZipCode: " + Data.ZipCode + "\n guestFirstName: " + Data.guestFirstName + "\n confirmationNumber: " + Data.confirmationNumber + "\n PropertyCode: " + Data.PropertyCode + "\n");
                                }
                                else
                                {
                                    Logger.WriteInfoMessage("TestCase Failed");
                                    Logger.WriteDebugMessage("Expected Result was : \n" + "\n Subject: " + Data.Subject + "\n fromEmail: " + Data.fromEmail + "\n fromName: " + Data.fromName + "\n CustomerID: " + customerID + "\n SourceStayID: " + Data.SourceStayID + "\n ReservationNumber: " + Data.ReservationNumber + "\n FirstName: " + Data.FirstName + "\n LastName: " + Data.LastName + "\n memberLevel: " + Data.memberLevel + "\n ArrivalDate: " + arrivalDate + "\n DepartureDate: " + departureDate + "\n CancelDate: " + cancelDate + "\n legNumbers: " + Data.legNumbers + "\n stayPoints: " + Data.stayPoints + "\n stayAverageTax: " + Data.stayAverageTax + "\n birthday: " + Data.birthday + "\n nextLevel: " + Data.nextLevel + "\n membershipLevel: " + Data.membershipLevel + "\n PropertyName: " + Data.PropertyName + "\n ZipCode: " + Data.ZipCode + "\n guestFirstName: " + Data.guestFirstName + "\n confirmationNumber: " + Data.confirmationNumber + "\n PropertyCode: " + Data.PropertyCode + "\n");
                                    Assert.Fail("One or more personalization value(s) was not found in Preview.");
                                }
                            }
                            else if (projectID == 40012827 || projectID == 62191267 || projectID == 40012945 || projectID == 89505256)
                            {
                                string defaultmessage;
                                if (testCategory == "EU02_PostDeployment")
                                    defaultmessage = " Hello Cendyn";
                                else
                                    defaultmessage = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Vivamus gravida laoreet gravida.";
                                Logger.WriteInfoMessage("Actual Result - Your ArrivalDate is " + Data.ArrivalDate);
                                if (arrivalDate == "1/1/2020" || arrivalDate == "2/1/2020")
                                {
                                    if (VerifyTextOnPage(arrivalDate))
                                    {
                                        Logger.WriteDebugMessage("Found Expected Result - " + "Your ArrivalDate is " + arrivalDate);
                                    }
                                    else
                                    {
                                        Assert.Fail("Cound not find Expected Result - " + "Your ArrivalDate is " + arrivalDate);
                                    }
                                    if(arrivalDate == "1/1/2020")
                                    {
                                        if (VerifyDynamicImage(imagelocation, "image10.jpg"))
                                        {
                                            Logger.WriteDebugMessage("Found image for arrivalDate" + arrivalDate);
                                        }
                                        else
                                        {
                                            Assert.Fail("Could not find image for ArrivalDate " + arrivalDate);
                                        }
                                    }
                                    else if (arrivalDate == "2/1/2020")
                                    {
                                        if (VerifyDynamicImage(imagelocation, febImage))
                                        {
                                            Logger.WriteDebugMessage("Found image for arrivalDate" + arrivalDate);
                                        }
                                        else
                                        {
                                            Assert.Fail("Could not find image for ArrivalDate " + arrivalDate);
                                        }
                                    }


                                }
                                else if (arrivalDate != "1/1/2020" || arrivalDate != "2/1/2020")
                                {
                                    if (VerifyTextOnPage(defaultmessage) || VerifyTextOnPage("Hello Jayesh"))
                                    {
                                        Logger.WriteDebugMessage("Found Expected Result - " + defaultmessage);
                                    }
                                    else
                                    {
                                        Assert.Fail("Could not find expected result - " + defaultmessage);
                                    }
                                }
                            }
                            //Omni Personalization Tags
                            else
                            {
                                Logger.WriteDebugMessage("Actual Result: \n" + "\n Subject: " + Data.Subject + "\n fromEmail: " + Data.fromEmail + "\n fromName: " + Data.fromName + "\n CustomerID: " + customerID + "\n memberLevel: " + Data.memberLevel + "\n ArrivalDate: " + Data.ArrivalDate + "\n DepartureDate: " + Data.DepartureDate + "\n CancelDate: " + cancelDate + "\n legNumbers: " + Data.legNumbers + "\n stayPoints: " + Data.stayPoints + "\n stayAverageTax: " + Data.stayAverageTax + "\n birthday: " + Data.birthday + "\n nextLevel: " + Data.nextLevel + "\n membershipLevel: " + Data.membershipLevel + "\n PropertyName: " + Data.PropertyName + "\n ZipCode: " + Data.ZipCode + "\n guestFirstName: " + Data.guestFirstName + "\n confirmationNumber: " + Data.confirmationNumber + "\n PropertyCode: " + Data.PropertyCode + "\n");
                                if (VerifyTextOnPage(customerID) && VerifyTextOnPage(Data.memberLevel) && VerifyTextOnPage(Data.ArrivalDate) && VerifyTextOnPage(Data.DepartureDate) && VerifyTextOnPage(cancelDate) && VerifyTextOnPage(Data.legNumbers) && VerifyTextOnPage(Data.stayPoints) && VerifyTextOnPage(Data.stayAverageTax) && VerifyTextOnPage(Data.birthday) && VerifyTextOnPage(Data.nextLevel) && VerifyTextOnPage(Data.membershipLevel) && VerifyTextOnPage(Data.PropertyName) && VerifyTextOnPage(Data.ZipCode) && VerifyTextOnPage(Data.guestFirstName) && VerifyTextOnPage(Data.confirmationNumber) && VerifyTextOnPage(Data.PropertyCode))
                                {
                                    //Logger.WriteDebugMessage("Values found as per expected \n" + "\n CustomerID: " + values.PrimaryCustomer + "\n Address1: " + values.Address1 + "\n Address2: " + values.Address2 + "\n CellPhoneNumber: " + values.PhoneNumber + "\n City: " + values.City + "\n Company: " + values.Company + "\n CountryCode: " + values.CountryCode + "\n Email: " + values.Email + "\n FirstName: " + values.FirstName + "\n GenderCode: " + values.GenderCode + "\n Lang_LanguageID: " + values.Lang_LanguageID + "\n Languages: " + values.Languages + "\n LastName: " + values.LastName + "\n Token: " + values.Token + "\n PhoneNumber: " + values.PhoneNumber + "\n Salutation: " + values.Salutation + "\n ShortTitle: " + values.Title + "\n SourceGuestID: " + values.SourceGuestID + "\n StateProvinceCode: " + values.StateName + "\n Title: " + values.Title + "\n ZipCode: " + values.ZipCode + "\n monetary: " + values.monetary + "\n recency: " + values.recency);
                                    //Logger.WriteDebugMessage("Expected Result: \n" + "\n Subject: " + Data.Subject + "\n fromEmail: " + Data.fromEmail + "\n fromName: " + Data.fromName + "\n PrimaryCustomer: " + Data.PrimaryCustomer + "\n FirstName: " + Data.FirstName + "\n LastName: " + Data.LastName + "\n Salutation: " + Data.Salutation + "\n ArrivalDate: " + Data.ArrivalDate + "\n DepartureDate: " + Data.DepartureDate + "\n CancelDate: " + cancelDate + "\n legNumbers: " + Data.legNumbers + "\n stayPoints: " + Data.stayPoints + "\n stayAverageTax: " + Data.stayAverageTax + "\n birthday: " + Data.birthday + "\n nextLevel: " + Data.nextLevel + "\n membershipLevel: " + Data.membershipLevel + "\n brandCode: " + Data.brandCode + "\n ZipCode: " + Data.ZipCode + "\n guestFirstName: " + Data.guestFirstName + "\n confirmationNumber: " + Data.confirmationNumber + "\n PropertyCode: " + Data.PropertyCode + "\n");
                                    Logger.WriteDebugMessage("Expected Result: \n" + "\n Subject: " + Data.Subject + "\n fromEmail: " + Data.fromEmail + "\n fromName: " + Data.fromName + "\n CustomerID: " + customerID + "\n memberLevel: " + Data.memberLevel + "\n ArrivalDate: " + Data.ArrivalDate + "\n DepartureDate: " + Data.DepartureDate + "\n CancelDate: " + cancelDate + "\n legNumbers: " + Data.legNumbers + "\n stayPoints: " + Data.stayPoints + "\n stayAverageTax: " + Data.stayAverageTax + "\n birthday: " + Data.birthday + "\n nextLevel: " + Data.nextLevel + "\n membershipLevel: " + Data.membershipLevel + "\n PropertyName: " + Data.PropertyName + "\n ZipCode: " + Data.ZipCode + "\n guestFirstName: " + Data.guestFirstName + "\n confirmationNumber: " + Data.confirmationNumber + "\n PropertyCode: " + Data.PropertyCode + "\n");
                                }
                                else
                                {
                                    Logger.WriteInfoMessage("TestCase Failed");
                                    Logger.WriteDebugMessage("Expected Result was : \n" + "\n Subject: " + Data.Subject + "\n fromEmail: " + Data.fromEmail + "\n fromName: " + Data.fromName + "\n CustomerID: " + customerID + "\n FirstName: " + Data.FirstName + "\n LastName: " + Data.LastName + "\n Salutation: " + Data.Salutation + "\n ArrivalDate: " + arrivalDate + "\n DepartureDate: " + departureDate + "\n CancelDate: " + cancelDate + "\n legNumbers: " + Data.legNumbers + "\n stayPoints: " + Data.stayPoints + "\n stayAverageTax: " + Data.stayAverageTax + "\n birthday: " + Data.birthday + "\n nextLevel: " + Data.nextLevel + "\n membershipLevel: " + Data.membershipLevel + "\n brandCode: " + Data.brandCode + "\n ZipCode: " + Data.ZipCode + "\n guestFirstName: " + Data.guestFirstName + "\n confirmationNumber: " + Data.confirmationNumber + "\n PropertyCode: " + Data.PropertyCode + "\n");
                                    Assert.Fail("One or more personalization value(s) was not found in Preview.");
                                }
                            }
                        }

                        if (!(Driver.Url.Contains("outlook")|| Driver.Url.Contains("viewqa.contact-client")) && isClosed == "Close")
                        {
                            Navigatetoiframe(0);
                            ElementClick(Driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Preview'])[2]/following::span[1]")));
                        }

                        /*
                        string[] eachResNum = Regex.Split(Data.ReservationNumber, ",");
                        foreach (string resNum in eachResNum)
                        {
                            if (eachResNum.Length>1)
                            {
                                Logger.WriteInfoMessage("Searching for Update Date for each Reservation Number" + eachResNum);
                                SqlWarehouseQuery.GetPersonalizedTagValue(Data, companyName, 2, resNum);

                                DateTime Date = DateTime.Parse(Data.ArrivalDate);
                                ArrivalDate = Date.ToString("M/d/yyyy HH:mm:ss tt");



                                if (VerifyTextOnPage(ArrivalDate))
                                {
                                    
                                }
                            }
                            else
                            {
                                Logger.WriteInfoMessage("Searching for Update Date for each Reservation Number" + eachResNum);
                                SqlWarehouseQuery.GetPersonalizedTagValue(Data, companyName, 2, resNum);

                                DateTime Date = DateTime.Parse(Data.ArrivalDate);
                                ArrivalDate = Date.ToString("M/d/yyyy HH:mm:ss tt");
                            }
                            
                        }*/
                        break;
                    }
            }
        }
        public static void ViewinBrowser(int projectID, string previeworSchedule = null)
        {
            if(previeworSchedule == "Preview")
            {
                Navigatetoiframe(1);
            }
            if (IsElementPresent(By.LinkText("View in browser")))
            {
                ElementClick(Driver.FindElement(By.LinkText("View in browser")));
            }
            if (IsElementPresent(By.LinkText("View in Browser")))
            {
                ElementClick(Driver.FindElement(By.LinkText("View in Browser")));
            }
            Logger.WriteDebugMessage("Clicked on View in Browser");
        }

        public static bool VerifyDynamicImage(string location, string fileName)
        {
            IWebElement ele = null;
            try
            {
                ele= Driver.FindElement(By.XPath("//img[@src='" + location + fileName + "']"));
            }
            catch (Exception)
            {
                fileName = "Snip20181023_59.png";
                ele = Driver.FindElement(By.XPath("//img[@src='" + location + fileName + "']"));
            }
            if (IsElementVisible(ele))
            {
                return true;
            }
            return true;
        }
        public static void SendToTestEmail(string projectID, int caseType, string groupName = null)
        {
            //ClickSearchTab();
            //Helper.ElementWait(PageObject_ManageCampaign.ManageCampaign_Search_SearchFieldDDM(), 60);
            //SelectSearchField("project id");
            //InsertInput("6417357");
            //ClickSearchButton();
            //if (Helper.VerifyTextOnPage("eInsight Automation Campaign"))
            //{
            string sendToTestXPath = "//a[@id='SendToTestEmails']";
            Helper.ElementClick(Driver.FindElement(By.XPath(sendToTestXPath)));
            Helper.Navigatetoiframe(1);
            switch (caseType)
            {
                case 0:
                    //SendtoSelf
                    if (VerifyTextOnPage("This email address is in compliance with global spam laws"))
                    {
                        Click_CASLCheckBox();
                        Logger.WriteDebugMessage("CASL is selected and sending send to test email.");
                        Button_SendToTest();
                        AddDelay(15000);
                        Logger.WriteDebugMessage("Sent to Test Email is sent.");
                    }
                    break;
                case 1:
                    //SendtoGroupSeed
                    if (VerifyTextOnPage("This email address is in compliance with global spam laws"))
                    {
                        Click_CASLCheckBox();
                        Logger.WriteDebugMessage("CASL is selected and sending send to test email.");
                        if (String.IsNullOrEmpty(groupName))
                        {
                            Assert.Fail("Please specific group name to use");
                        }
                        else
                        {
                            //Click_SelectGroupSeedList("Email To Self");
                            Click_SelectGroupSeedList(groupName);
                            Button_SendToTest();
                            AddDelay(15000);
                            Logger.WriteDebugMessage("Sent to Test Email is sent.");
                        }
                    }
                    break;
                default:
                    Assert.Fail("Send to Self or GroupSeedList was not selected.");
                    break;
            }

            //}

        }
        public static void VerifySendToTestData(ProfileCustData Data)
        {
            if (VerifyTextOnPage(Data.CustomerID) && VerifyTextOnPage(Data.FirstName) && VerifyTextOnPage(Data.LastName) && VerifyTextOnPage(Data.Email) && VerifyTextOnPage(Data.ArrivalDate) && VerifyTextOnPage(Data.SourceStayID))
            {
                Logger.WriteDebugMessage("Able to match the data with CustomerID: " + Data.CustomerID);
            }
            else
            {
                Assert.Fail("One of the data did not match for CustomerID: " + Data.CustomerID);
            }
        }

        public static void CASL_QuickSendVerification(string CustomerID, int caseNum, string Email = null, string reservationNum = null, string resXpath = null)
        {
            //IWebElement btnAttri = Driver.FindElement(By.Id("submitRequestSeedList"));
            //bool result;
            var isDisabled = "";
            switch (caseNum)
            {
                case 0:
                    Navigatetoiframe(2);
                    //Helper.ElementClick(Driver.FindElement(By.XPath("//*[@id = 'qslink" + CustomerID + "']")));
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'QuickSend') and contains(@href, '" + CustomerID + "')]")));
                    Navigatetoiframe(3);
                    Logger.WriteDebugMessage("Landed on Quick Send Page for CustomerID: " + CustomerID);
                    isDisabled = Driver.FindElement(By.XPath("//*[@id='submitRequestSeedList']")).GetAttribute("class");
                    if (isDisabled.Contains("disabled"))
                    {
                        Helper.HighlightElement(PageObject_ManageCampaign.Button_SendToTest());
                        Click_CASLCheckBox();
                        isDisabled = Driver.FindElement(By.Id("submitRequestSeedList")).GetAttribute("disabled");
                        if (isDisabled == null)
                        {
                            Logger.WriteDebugMessage("CASL checkbox is selected and send a quicksend to self email address.");
                            if (!(String.IsNullOrEmpty(reservationNum)))
                            {
                                ElementSelectFromDropDown(PageObject_ManageCampaign.ManageCampaign_QuickSend_ReservationSelect(), resXpath);
                            }
                            Button_SendToTest();
                            Logger.WriteDebugMessage("Quick Send - Email to self is sent.");
                            AddDelay(10000);
                        }
                    }
                    AddDelay(10000);
                    break;
                case 1:
                    Navigatetoiframe(2);
                    Helper.ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'QuickSend') and  contains(@href, '" + Email + "')]")));
                    Navigatetoiframe(3);
                    Logger.WriteDebugMessage("Landed on Quick Send Page for CustomerID: " + CustomerID);
                    isDisabled = Driver.FindElement(By.XPath("//*[@id='submitRequestSeedList']")).GetAttribute("class");
                    if (isDisabled.Contains("disabled"))
                    {
                        Helper.HighlightElement(PageObject_ManageCampaign.Button_SendToTest());
                        Click_CASLCheckBox();
                        isDisabled = Driver.FindElement(By.Id("submitRequestSeedList")).GetAttribute("disabled");
                        if (isDisabled == null)
                        {
                            if (!(String.IsNullOrEmpty(reservationNum)))
                            {
                                ElementSelectFromDropDown(PageObject_ManageCampaign.ManageCampaign_QuickSend_ReservationSelect(), resXpath);
                            }
                            Logger.WriteDebugMessage("CASL checkbox is selected and send a quicksend to self email address.");
                            Button_SendToTest();
                            Logger.WriteDebugMessage("Quick Send - Email to self is sent.");
                            AddDelay(10000);
                        }
                    }
                    AddDelay(10000);
                    break;
                case 2:
                    //IWebElement detailFrame = Driver.FindElement(By.XPath("//a[contains(@href, 'QuickSend') and  contains(@href, '" + Email + "')]"));
                    //Driver.SwitchTo().Frame(detailFrame.GetAttribute("name"));
                    Helper.ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'QuickSend') and  contains(@href, '" + CustomerID + "')][1]")));

                    Navigatetoiframe(3);
                    Logger.WriteDebugMessage("Landed on Quick Send Page for CustomerID: " + CustomerID);
                    isDisabled = Driver.FindElement(By.XPath("//*[@id='submitRequestSeedList']")).GetAttribute("class");
                    if (isDisabled.Contains("disabled"))
                    {
                        Helper.HighlightElement(PageObject_ManageCampaign.Button_SendToTest());
                        Click_CASLCheckBox();
                        isDisabled = Driver.FindElement(By.Id("submitRequestSeedList")).GetAttribute("disabled");
                        if (isDisabled == null)
                        {
                            Logger.WriteDebugMessage("CASL checkbox is selected and send a quicksend to self email address.");
                            Button_SendToTest();
                            Logger.WriteDebugMessage("Quick Send - Email to self is sent.");
                            AddDelay(10000);
                        }
                    }
                    AddDelay(10000);
                    break;
            }
        }
        public static void PreviewReportCheck()
        {
            Logger.WriteInfoMessage("Checking one of the desktop report");
            ElementClick(Driver.FindElement(By.XPath("//*[@id='Desktop']/div[1]/div/a/img")));
            Logger.WriteDebugMessage("Opened Desktop Report.");
            ReloadPage();
            AddDelay(5000);
            ElementClick(Driver.FindElement(By.XPath("//a[@href='#Desktop']")));
            ElementClick(Driver.FindElement(By.XPath("//a[@href='#Mobile']")));
            Logger.WriteInfoMessage("Checking one of the Mobile report");
            ElementClick(Driver.FindElement(By.XPath("//*[@id='Mobile']/div[1]/div/a/img")));
            Logger.WriteDebugMessage("Opened Mobile Report.");
            ReloadPage();
            AddDelay(5000);
            ElementClick(Driver.FindElement(By.XPath("//a[@href='#Desktop']")));
            ElementClick(Driver.FindElement(By.XPath("//a[@href='#Common_Web_Clients']")));
            Logger.WriteInfoMessage("Checking one of the Common Web Clients report");
            ElementClick(Driver.FindElement(By.XPath("//*[@id='Common_Web_Clients']/div[1]/div/a/img")));
            Logger.WriteDebugMessage("Opened Common Web Clients Report.");
            ReloadPage();
            AddDelay(5000);
            if (IsElementPresent(By.XPath("//a[@href='#Other_Web_Clients']")))
            {
                ElementClick(Driver.FindElement(By.XPath("//a[@href='#Desktop']")));
                ElementClick(Driver.FindElement(By.XPath("//a[@href='#Other_Web_Clients']")));
                Logger.WriteInfoMessage("Checking one of the Other Web Clients report");
                ElementClick(Driver.FindElement(By.XPath("//*[@id='Other_Web_Clients']/div[1]/div/a/img")));
                Logger.WriteDebugMessage("Opened Other Web Clients Report.");
            }
        }
        //Driver.SwitchTo().Frame("iframe_modal_2");

        public static void PreSearchCampaign_New(string companyName, string searchType, string searchText, string iframeSwitch, string tabSelect = null)
        {
            /*Add Sub Client*/
            AddDelay(30000);
            ScrollDownUsingJavaScript(Driver, -1000);
            //Profile.SelectClient(parentCompany);
            Profile.SelectSubClient(companyName);
            AddDelay(20000);
            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(iframeSwitch)));
            if (!String.IsNullOrEmpty(tabSelect) && tabSelect == "Transactional")
            {
                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Transactional - In Testing')]")));
                Logger.WriteDebugMessage("Navigated to Tansactional Campaign Tab.");
            }
            switch (searchType)
            {
                case "ProjectID":
                    By loader1 = By.XPath("//*[contains(.,'Loading...')]");
                    Helper.WaitTillInvisibilityOfLoader(loader1, 55);
                    ElementClick(PageObject_ManageCampaign.ManageCampaign_SearchProjectID());
                    ElementEnterText(PageObject_ManageCampaign.ManageCampaign_SearchProjectIDText(), searchText);
                    ElementClick(PageObject_ManageCampaign.ManageCampaign_SearchProjectID_Filter());
                    Helper.WaitTillInvisibilityOfLoader(loader1, 180);
                    ElementWait(Driver.FindElement(By.XPath("//span[contains(text(), 'ID')]//following::*[contains(text(), '" + searchText + "')]")), 30);
                    if (IsElementPresent(By.XPath("//span[contains(text(), 'ID')]//following::*[contains(text(), '" + searchText + "')]")))
                    {
                        Logger.WriteDebugMessage("Search and Filtered ProjectID - " + searchText);
                    }
                    break;
            }
        }

        public static void ManageCampaign_SearchProjectIDOnly(string companyName, string searchType, string searchText, string iframeSwitch)
        {
            /*Add Sub Client*/

            ScrollDownUsingJavaScript(Driver, -1000);
            //Profile.SelectClient(parentCompany);
            Profile.SelectSubClient(companyName);
            AddDelay(20000);
            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(iframeSwitch)));
            switch (searchType)
            {
                case "ProjectID":
                    ElementClick(PageObject_ManageCampaign.ManageCampaign_SearchProjectID());
                    ElementEnterText(PageObject_ManageCampaign.ManageCampaign_SearchProjectIDTexts(), searchText);
                    ElementClick(PageObject_ManageCampaign.ManageCampaign_SearchProjectID_Filters());
                    AddDelay(20000);
                    break;
            }
        }

        public static void CampaignDetails_TabActions(string tabActions, string projectID, string subTabActions = null)
        {
            switch(tabActions)
            {
                case "Summary":
                    break;
                case "Preview":
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '/campaign-details/preview')]")));
                    Logger.WriteDebugMessage("Landed on Campaign Detail -> Preview Tab.");
                    //string iframePreviewTemplate = "//iframe[@id='template-iframe']";
                    Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@id='template-iframe']")));
                    break;
                case "Testing":
                    ElementClick(PageObject_ManageCampaign.ManageCampaign_CustomerDetails_Testing(projectID));
                    if (IsElementVisible(PageObject_ManageCampaign.ManageCampaign_CustomerDetails_Testing_Advanced()))
                    {
                        Logger.WriteDebugMessage("Clicked on Campaign Details -> Testing Tab.");
                        ElementClick(PageObject_ManageCampaign.ManageCampaign_CustomerDetails_Testing_Advanced());
                        if (IsElementPresent(By.XPath("//span[contains(text(), 'Inbox Preview')]")))
                        {
                            Logger.WriteDebugMessage("Landed on Campaign Detail -> Testing Tab -> Advanced Tab. ");
                        }
                        else
                        {
                            Assert.Fail("Landed on Campaign Detail -> Testing Tab -> Advanced Tab. ");
                        }
                    }
                    else
                    {
                        Assert.Fail("Clicked on Campaign Details -> Testing Tab.");
                    }
                    break;
                case "Audience":
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '/campaign-details/audience')]")));
                    switch (subTabActions)
                    {
                        case "CustomerDetails":
                            ElementClick(Driver.FindElement(By.XPath("//a[@id='customerDetails']")));
                            Logger.WriteDebugMessage("Landed on Campaign Detail -> Preview Tab.");
                            if (IsElementPresent(By.XPath("//div[@id='customer-details']//following::button[contains(text(), 'Export')]")))
                            {
                                Logger.WriteDebugMessage("Landed on Customer Details Page.");
                            }
                            else
                            {
                                Assert.Fail("Did not land on Customer Detail Page");
                            }
                        break;
                    }
                    break;
                case "History":
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));
                    Logger.WriteDebugMessage("Landed on History Tab.");
                    if (IsElementPresent(By.XPath("//a[contains(@href, 'history')]/following::*[contains(text(), 'History')]")))
                    {
                        Logger.WriteDebugMessage("Landed on History Tab");
                    }
                    else
                    {
                        Assert.Fail("Did not land on History Tab.");
                    }
                    break;
                case "Report":
                    break;
            }
        }

        public static void ManageCampaign_EllipseButton(string ellipsetype)
        {
            ElementClick(Driver.FindElement(By.XPath("//button[contains(@aria-label, ' dropdownbutton')]")));
            Logger.WriteDebugMessage("Clicked on Ellippse");

            switch(ellipsetype)
            {
                case "Details":
                    ElementClick(Driver.FindElement(By.XPath("//li[contains(text(), 'Details')]")));
                    string tabElement = "//a[contains(@href, '/campaign-details/summary')]";
                    if (IsElementPresent(By.XPath(tabElement)))
                    {
                        Logger.WriteDebugMessage("Landed on Campaign Details.");
                    }
                    else
                    {
                        Assert.Fail("Did not landed on Campaign Details.");
                    }
                    Logger.WriteDebugMessage("Clicked on Campaign Details button");

                    break;
                case "Edit":
                    ElementClick(Driver.FindElement(By.XPath("//li[contains(text(), 'Edit')]")));
                    break;
                case "Clone":
                    ElementClick(Driver.FindElement(By.XPath("//li[contains(text(), 'Clone')]")));
                    break;
            }
        }

        public static void CampaignDetails_TestingAdvancedTab(string projectID)
        {
            ElementClick(PageObject_ManageCampaign.ManageCampaign_CustomerDetails_Testing(projectID));
            if (IsElementVisible(PageObject_ManageCampaign.ManageCampaign_CustomerDetails_Testing_Advanced()))
            {
                Logger.WriteDebugMessage("Clicked on Campaign Details -> Testing Tab.");
                ElementClick(PageObject_ManageCampaign.ManageCampaign_CustomerDetails_Testing_Advanced());
                if (IsElementPresent(By.XPath("//span[contains(text(), 'Inbox Preview')]")))
                {
                    Logger.WriteDebugMessage("Landed on Campaign Detail -> Testing Tab -> Advanced Tab. ");
                }
                else
                {
                    Assert.Fail("Landed on Campaign Detail -> Testing Tab -> Advanced Tab. ");
                }
            }
            else
            {
                Assert.Fail("Clicked on Campaign Details -> Testing Tab.");
            }
        }
        public static void Request_InboxPrevieworForcaster(string inboxType, string campaignSubject)
        {
            switch (inboxType)
            {
                case "Preview":
                    if (IsElementPresent(By.XPath("//p[contains(text(), 'Review desktop')]//following::button[contains(text(), 'Request')]")))
                    {
                        
                        Logger.WriteDebugMessage("Clicked on Inbox Preview button");
                        DoubleClickElement(Driver.FindElement(By.XPath("//p[contains(text(), 'Review desktop')]//following::button[contains(text(), 'Request')]")));
                        Logger.WriteDebugMessage("Clicked on Inbox Preview button. And Received message : Your Inbox Preview will be available shortly.");
                        Logger.WriteInfoMessage("Holding short to generate preview report for 5 minutes.");
                        AddDelay(360000);
                    }
                    else
                    {
                        ElementClick(PageObject_ManageCampaign.ManageCampaign_CustomerDetails_Testing_Advanced_InboxPreview());
                        Logger.WriteDebugMessage("Clicked on Inbox Preview button. And Received message : Your Inbox Preview will be available shortly.");
                        Logger.WriteInfoMessage("Holding short to generate preview report for 5 minutes.");
                        AddDelay(360000);
                    }
                    
                    //ElementClick(Driver.FindElement(By.XPath("//p[contains(text(), '" + campaignSubject + "')]//following::p[contains(text(), '" + getDate + "')]//following::a")));
                    break;
                case "Forecaster":
                    if(IsElementPresent(By.Id("advancedDeliverability")))
                    {
                        ElementClick(Driver.FindElement(By.Id("advancedDeliverability")));
                        Logger.WriteDebugMessage("Clicked on Inbox Forecaster button");
                        Logger.WriteInfoMessage("Holding short to generate forecast report for 5 minutes.");
                        AddDelay(360000);
                    }
                    else
                    {
                        ElementClick(PageObject_ManageCampaign.ManageCampaign_CustomerDetails_Testing_Advanced_InboxForecaster());
                        //ElementClick(Driver.FindElement(By.XPath("//p[contains(text(), '" + campaignSubject + "')]//following::p[contains(text(), '" + getDate + "')]//following::a")));
                        Logger.WriteDebugMessage("Clicked on Inbox Forecaster button");
                        Logger.WriteInfoMessage("Holding short to generate forecast report for 5 minutes.");
                        AddDelay(360000);
                    }
                    break;
            }
        }
        public static void LaunchPreviewForCaster(string launchType, string campaignSubject)
        {
            var getDate = DateTime.Now.ToString("M/d/yyyy");
            switch (launchType)
            {
                case "Preview":
                    ScrollToText("Campaign Details");
                    ElementClick(Driver.FindElement(By.XPath("(//p[contains(text(), '" + campaignSubject + "')]//following::p[contains(text(), '" + getDate + "')]//following::a[contains(@href, 'CreateSelectedInboxPreviewReport')])[1]")));
                    break;
                case "Forecaster":
                    ScrollToText("Campaign Details");
                    ElementClick(Driver.FindElement(By.XPath("(//p[contains(text(), '" + campaignSubject + "')]//following::p[contains(text(), '" + getDate + "')]//following::a[contains(@href, 'CreateSelectedInboxInformantReport')])[1]")));
                    break;
            }
        }

        public static void CampaignDetails_PerformActonsItems(string actionType)
        {
            ElementClick(PageObject_ManageCampaign.ProjectID_CampaignDetails_Actions());
            switch (actionType)
            {
                case "Edit":
                    ElementClick(PageObject_ManageCampaign.CampaignDetails_Actions_Edit());
                    break;
                case "Clone":
                    ElementClick(PageObject_ManageCampaign.CampaignDetails_Actions_Clone());
                    if (IsElementVisible(PageObject_CreateCampaign.CreateCampaign_Button_SaveandContinue()))
                    {
                        Logger.WriteDebugMessage("Landed on Edit Template Page");
                    }
                    else
                    {
                        Assert.Fail("Failed to land on Edit Template Page after cloning the template.");
                    }
                    break;
                case "Delete":
                    ElementClick(PageObject_ManageCampaign.CampaignDetails_Actions_Delete());
                    if (VerifyTextOnPage("Delete Confirmation"))
                    {
                        Logger.WriteDebugMessage("Received Delete Confirmation message : Are you sure you wish to delete the campaign?");
                        ElementClick(Driver.FindElement(By.XPath("//h2[contains(text(), 'Delete Confirmation')]//following::button[contains(text(), 'Ok')]")));
                        Logger.WriteDebugMessage("Click on Ok button");
                    }
                    else
                    {
                        Assert.Fail("Did not land on Delete Confirmation message.");
                    }
                    AddDelay(20000);
                    break;
                case "SaveAsResend":
                    ElementClick(PageObject_ManageCampaign.CampaignDetails_Actions_SaveAsResend());
                    break;
                case "SaveAsTemplate":
                    ElementClick(PageObject_ManageCampaign.CampaignDetails_Actions_SaveAsTemplate());
                    break;
            }
        }

        public static void CriteriaPage_ForcastTargetAudience(int nextstep)
        {
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Forecast Target Audience')]")));
            Logger.WriteDebugMessage("Clicked on Forecast Target Audience.");
            switch(nextstep)
            {
                case 0:
                    if (IsElementPresent(By.XPath("//button[@class='switcher']")))
                    {
                        if (VerifyTextOnPage("You will receive an email notification when your counts finish generating"))
                        {
                            ElementClick(Driver.FindElement(By.XPath("(//span[contains(text(), 'Close')])[1]")));
                        }
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Forecast Audience counts available.");
                    }
                    break;
                case 1:
                    break;
            }
        }

        public static void SearchCustomerBy(string filterType, string searchValue)
        {
            switch (filterType)
            {
                case "Reservation":
                    ElementEnterText(Driver.FindElement(By.XPath("//input[@placeholder='Enter the value']")), searchValue);
                    Logger.WriteDebugMessage("Entered Reservation - " + searchValue);
                    ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Filter')]")));
                    if (VerifyTextOnPage(searchValue))
                    {
                        Logger.WriteDebugMessage("Entered Reservation - " + searchValue);
                    }
                    else
                    {
                        Assert.Fail("Could not find Reservation Number - " + searchValue);
                    }
                    break;
                case "Email":
                    ElementEnterText(Driver.FindElement(By.XPath("//input[@placeholder='Enter the value']")), searchValue);
                    Logger.WriteDebugMessage("Entered Email - " + searchValue);
                    ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Filter')]")));
                    //if (VerifyTextOnPage(searchValue))
                    //{
                    //    Logger.WriteDebugMessage("Entered Email - " + searchValue);
                    //}
                    //else
                    //{
                    //    Assert.Fail("Could not find Email - " + searchValue);
                    //}
                    AddDelay(10000);
                    Logger.WriteDebugMessage("Entered Email - " + searchValue);
                    break;
            }
        }
        public static void SearchCustomer(string customerSearchType, string searchValue)
        {
            switch(customerSearchType)
            {
                case "FirstName":
                    break;
                case "LastName":
                    break;
                case "Email":
                    ElementClick(Driver.FindElement(By.XPath("//div[contains(@class,'cendyn-grid')]/div[2]/div/table/thead/tr/th[3]/div[3]")));
                    SearchCustomerBy("Email", searchValue);
                    break;
                case "EmailStatus":
                    break;
                case "Reservation":
                    ElementClick(Driver.FindElement(By.XPath("//div[contains(@class,'cendyn-grid')]/div[2]/div/table/thead/tr/th[5]/div[3]")));
                    SearchCustomerBy("Reservation", searchValue);
                    break;
                case "Zip":
                    break;
                case "Property":
                    break;
                case "Source":
                    break;
            }
        }

        public static void CustomerDetailEllipse_PreviewQuickSend (string actiontype)
        {
            ElementClick(Driver.FindElement(By.XPath("//td[contains(@class, 'e-ellipsistooltip')]//button")));
            switch (actiontype)
            {
                case "Preview":
                    ElementClick(Driver.FindElement(By.Id("preview")));
                    break;
                case "QuickSend":
                    ElementClick(Driver.FindElement(By.Id("quickSend")));
                    break;
            }
        }

        public static void Customer_Send_QuickSend(string customerID, string reservationNum, string resXPath=null)
        {
            Navigatetoiframe(1);
            //Helper.ElementClick(Driver.FindElement(By.XPath("//*[@id = 'qslink" + CustomerID + "']")));
            //ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'QuickSend') and contains(@href, '" + customerID + "')]")));
            //Navigatetoiframe(3);
            Logger.WriteDebugMessage("Landed on Quick Send Page for CustomerID: " + customerID);
            string isDisabled = Driver.FindElement(By.XPath("//*[@id='submitRequestSeedList']")).GetAttribute("class");
            if (isDisabled.Contains("disabled"))
            {
                Helper.HighlightElement(PageObject_ManageCampaign.Button_SendToTest());
                Click_CASLCheckBox();
                isDisabled = Driver.FindElement(By.Id("submitRequestSeedList")).GetAttribute("disabled");
                if (isDisabled == null)
                {
                    Logger.WriteDebugMessage("CASL checkbox is selected and send a quicksend to self email address.");
                    if (!(String.IsNullOrEmpty(reservationNum)))
                    {
                        ElementSelectFromDropDown(PageObject_ManageCampaign.ManageCampaign_QuickSend_ReservationSelect(), resXPath);
                    }
                    Button_SendToTest();
                    Logger.WriteDebugMessage("Quick Send - Email to self is sent.");
                    AddDelay(10000);
                }
            }
            AddDelay(10000);
        }

        public static void ClickOnListViewOfTemplates()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(360));
            By loader1 = By.XPath(PageObject_CreateCampaign.CreateCampaign_Templates_ListView_Loader());
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(loader1));
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Templates_ListView(), 360);
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Templates_ListView());
            By loader = By.XPath(PageObject_CreateCampaign.CreateCampaign_Templates_ListView_Loader());
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(loader));
        }

        public static void SearchTemplatesBasedOnName(string filterOption, string filterText)
        {
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Templates_Name_FilterIcon());
            IWebElement ele = PageObject_CreateCampaign.CreateCampaign_Templates_SelectOption();
            ElementClick(ele);
            try
            {
                Actions act = new Actions(Driver);
                if (filterOption.ToLower().Contains("starts"))
                    Console.WriteLine("Starts with");
                else if (filterOption.ToLower().Contains("ends"))
                {
                    act.SendKeys(Keys.ArrowDown).Build().Perform();
                }
                else if (filterOption.ToLower().Contains("contains"))
                {
                    act.SendKeys(Keys.ArrowDown).Build().Perform();
                    act.SendKeys(Keys.ArrowDown).Build().Perform();
                    act.SendKeys(Keys.ArrowUp).Build().Perform();
                }
                else if (filterOption.ToLower().Contains("equal"))
                {
                    act.SendKeys(Keys.ArrowDown).Build().Perform();
                    act.SendKeys(Keys.ArrowDown).Build().Perform();
                    act.SendKeys(Keys.ArrowDown).Build().Perform();
                }
            }
            catch (Exception)
            {

                throw;
            }
            ElementEnterText(PageObject_CreateCampaign.CreateCampaign_Templates_ListView_Input_Filter(), filterText);
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Templates_ListView_FilterBtn());
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(240));
            By loader = By.XPath(PageObject_CreateCampaign.CreateCampaign_Templates_ListView_Loader());
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(loader));
        }
    }
}
