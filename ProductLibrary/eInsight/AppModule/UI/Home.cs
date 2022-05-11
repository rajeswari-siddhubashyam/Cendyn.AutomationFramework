using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseUtility.Utility;
using InfoMessageLogger;
using Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using eInsight.PageObject.UI;
using eInsight.Utility;
using BaseUtility.Utility.Hotmail;
using NUnit.Framework;
using SqlWarehouse;
using eInsight.AppModule.MainAdminApp;

namespace eInsight.AppModule.UI
{
    class Home : Helper
    {
        public static void Click_Tab_AtAGlance_AllActivity()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_AllActivity());
        }

        public static void Click_Tab_AtAGlance_Created()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_Created());
        }

        public static void Click_Tab_AtAGlance_CriteriaChanged()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_CriteriaChanged());
        }

        public static void Click_Tab_AtAGlance_TemplateChanged()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_TemplateChanged());
        }

        public static void Click_Tab_AtAGlance_SentToTestEmailsHistory()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_SentToTestEmailsHistory());
        }

        public static void Click_Tab_AtAGlance_DeliveryReportRequested()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_DeliveryReportRequested());
        }

        public static void Click_Tab_AtAGlance_DeliveryReportReceived()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_DeliveryReportReceived());
        }

        public static void Click_Tab_AtAGlance_ProceedForApproval()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_ProceedForApproval());
        }

        public static void Click_Tab_AtAGlance_ApprovalRequested()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_ApprovalRequested());
        }

        public static void Click_Tab_AtAGlance_Approved()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_Approved());
        }

        public static void Click_Tab_AtAGlance_Disapproved()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_Disapproved());
        }

        public static void Click_Tab_AtAGlance_Scheduled()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_Scheduled());
        }

        public static void Click_Tab_AtAGlance_Rescheduled()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_Rescheduled());
        }

        public static void Click_Tab_AtAGlance_ScheduleDeactivated()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_ScheduleDeactivated());
        }

        public static void Click_Tab_AtAGlance_Sent()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_Sent());
        }

        public static void Click_Tab_AtAGlance_Cancelled()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_Cancelled());
        }

        public static void Click_Tab_AtAGlance_Previous()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_Previous());
        }

        public static void Click_Tab_AtAGlance_Next()
        {
            Helper.ElementClick(PageObject_Home.Tab_AtAGlance_Next());
        }

        public static void Click_Link_AtAGlance_GoToTab_Menu()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_Menu());
        }

        public static void Click_Link_AtAGlance_GoToTab_Created()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_Created());
        }

        public static void Click_Link_AtAGlance_GoToTab_CriteriaChanged()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_CriteriaChanged());
        }

        public static void Click_Link_AtAGlance_GoToTab_TemplateChanged()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_TemplateChanged());
        }

        public static void Click_Link_AtAGlance_GoToTab_SentToTestEmailsHistory()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_SentToTestEmailsHistory());
        }

        public static void Click_Link_AtAGlance_GoToTab_DeliveryReportRequested()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_DeliveryReportRequested());
        }

        public static void Click_Link_AtAGlance_GoToTab_DeliveryReportReceived()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_DeliveryReportReceived());
        }

        public static void Click_Link_AtAGlance_GoToTab_ProceedForApproval()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_ProceedForApproval());
        }

        public static void Click_Link_AtAGlance_GoToTab_ApprovalRequested()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_ApprovalRequested());
        }

        public static void Click_Link_AtAGlance_GoToTab_Approved()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_Approved());
        }

        public static void Click_Link_AtAGlance_GoToTab_Disapproved()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_Disapproved());
        }

        public static void Click_Link_AtAGlance_GoToTab_Scheduled()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_Scheduled());
        }

        public static void Click_Link_AtAGlance_GoToTab_Rescheduled()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_Rescheduled());
        }

        public static void Click_Link_AtAGlance_GoToTab_ScheduleDeactivated()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_ScheduleDeactivated());
        }

        public static void Click_Link_AtAGlance_GoToTab_Sent()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_Sent());
        }

        public static void Click_Link_AtAGlance_GoToTab_Cancelled()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_Cancelled());
        }

        public static void Click_Link_AtAGlance_Campaign_1()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_Campaign_1());
        }

        public static void Click_Link_AtAGlance_Campaign_2()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_Campaign_2());
        }

        public static void Click_Link_AtAGlance_Campaign_3()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_Campaign_3());
        }

        public static void Click_Link_AtAGlance_ViewAllActivity()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_ViewAllActivity());
        }

        public static void Click_Tab_RecentCampaigns()
        {
            Helper.ElementClick(PageObject_Home.Tab_RecentCampaigns());
        }

        public static void Click_Tab_Dashboard()
        {
            Helper.ElementClick(PageObject_Home.Tab_Dashboard());
        }
        public static void Click_Tab_RecentlySentCampaigns_Email()
        {
            Helper.ElementClick(PageObject_Home.Tab_RecentlySentCampaigns_Email());
        }

        public static void Click_Tab_RecentlySentCampaigns_RealTime()
        {
            Helper.ElementClick(PageObject_Home.Tab_RecentlySentCampaigns_RealTime());
        }

        public static void Click_Tab_RecentlySentCampaigns_TextMessage()
        {
            Helper.ElementClick(PageObject_Home.Tab_RecentlySentCampaigns_TextMessage());
        }

        public static void Click_Tab_RecentlySentCampaigns_KeywordTextMessage()
        {
            Helper.ElementClick(PageObject_Home.Tab_RecentlySentCampaigns_KeywordTextMessage());
        }

        public static void Click_Tab_RecentlySentCampaigns_TextMessageResponses()
        {
            Helper.ElementClick(PageObject_Home.Tab_RecentlySentCampaigns_TextMessageResponses());
        }

        public static void Click_Button_RecentlySentCampaigns_CalendarFrom()
        {
            Helper.ElementClick(PageObject_Home.Button_RecentlySentCampaigns_CalendarFrom());
        }

        public static void Click_Button_RecentlySentCampaigns_CalendarThrough()
        {
            Helper.ElementClick(PageObject_Home.Button_RecentlySentCampaigns_CalendarThrough());
        }

        public static void Click_Button_RecentlySentCampaigns_Merge()
        {
            Helper.ElementClick(PageObject_Home.Button_RecentlySentCampaigns_Merge());
        }

        public static void Click_Button_RecentlySentCampaigns_FirstPage()
        {
            Helper.ElementClick(PageObject_Home.Button_RecentlySentCampaigns_FirstPage());
        }

        public static void Click_Button_RecentlySentCampaigns_PreviousPage()
        {
            Helper.ElementClick(PageObject_Home.Button_RecentlySentCampaigns_PreviousPage());
        }

        public static void Click_Button_RecentlySentCampaigns_NextPage()
        {
            Helper.ElementClick(PageObject_Home.Button_RecentlySentCampaigns_NextPage());
        }

        public static void Click_Button_RecentlySentCampaigns_LastPage()
        {
            Helper.ElementClick(PageObject_Home.Button_RecentlySentCampaigns_LastPage());
        }

        public static void Click_Button_RecentlySentCampaigns_ExcelReport()
        {
            Helper.ElementClick(PageObject_Home.Button_RecentlySentCampaigns_ExcelReport());
        }

        public static void EnterText_Tab_RecentlySentCampaigns_TextMessage(string text)
        {
            Helper.ElementEnterText(PageObject_Home.Tab_RecentlySentCampaigns_TextMessage(), text);
        }

        public static void EnterText_Tab_RecentlySentCampaigns_KeywordTextMessage(string text)
        {
            Helper.ElementEnterText(PageObject_Home.Tab_RecentlySentCampaigns_KeywordTextMessage(), text);
        }

        public static void EnterText_Tab_RecentlySentCampaigns_TextMessageResponses(string text)
        {
            Helper.ElementEnterText(PageObject_Home.Tab_RecentlySentCampaigns_TextMessageResponses(), text);
        }

        public static void EnterText_Text_RecentlySentCampaigns_PageNumber(string text)
        {
            Helper.ElementEnterText(PageObject_Home.Text_RecentlySentCampaigns_PageNumber(), text);
        }

        public static void SelectFromDropDown_DropDown_RecentlySentCampaigns_SelectClient(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_Home.DropDown_RecentlySentCampaigns_SelectClient(), text);
        }

        public static void SelectFromDropDown_DropDown_RecentlySentCampaigns_SelectCompany(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_Home.DropDown_RecentlySentCampaigns_SelectCompany(), text);
        }

        public static void SelectFromDropDown_DropDown_RecentlySentCampaigns_ShowLast(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_Home.DropDown_RecentlySentCampaigns_ShowLast(), text);
        }

        public static void SelectFromDropDown_DropDown_RecentlySentCampaigns_DisplayResultsNumber(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_Home.DropDown_RecentlySentCampaigns_DisplayResultsNumber(), text);
        }

        public static void Click_Link_AtAGlance_GoToTab_AllActivity()
        {
            Helper.ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_AllActivity());
        }
        public static void Click_Home_Link_AtAGlance_GoToTab_Menu(string tabName)
        {
            string name = "//td[contains(text(), '"+tabName+"')]";
            ElementClick(PageObject_Home.Link_AtAGlance_GoToTab_Menu());
            ElementClick(Driver.FindElement(By.XPath(name)));
            Logger.WriteDebugMessage("Landed on Tab - " + tabName);
        }

        public static void Select_DateRange(string value)
        {
            ElementSelectFromDropDownByValue(Driver.FindElement(By.Id("NumbDays")), value);
            Logger.WriteDebugMessage("Selected Date Range as " + value);
        }

        public static void Enter_StartDate(string sDate)
        {

            DateTime enteredDate = Convert.ToDateTime(sDate);
            var lastMonthDate = enteredDate.AddMonths(-1);
            string endDate = lastMonthDate.ToString("M/d/yyyy");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("document.getElementById('RealTimeFrom').value='" + endDate + "'");
            Logger.WriteDebugMessage("Entered End Date in DatePicker - " + endDate);
        }
        public static void Enter_EndDate(string sDate)
        {
            DateTime enteredDate = DateTime.Parse(sDate);
            string startDate = enteredDate.ToString("M/d/yyyy");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("document.getElementById('RealTimeThru').value='" + startDate + "'");
            Logger.WriteDebugMessage("Entered Start Date in DatePicker - " + startDate);
        }

        public static void Enter_EmailAddress(string Email)
        {
            ElementEnterText(Driver.FindElement(By.Id("RealTimeEmail")), Email);
            Logger.WriteDebugMessage("Entered Email Address - " + Email);
        }
        public static void Enter_ResNum(string resNum)
        {
            ElementEnterText(Driver.FindElement(By.Id("RealTimeResno")), resNum);
            Logger.WriteDebugMessage("Entered ReservationNumber - " + resNum);
        }

        public static void Click_Search()
        {
            ElementClick(Driver.FindElement(By.Id("searchRealTime")));
            Logger.WriteInfoMessage("Waiting for 4 minutes to load the grid.");
            WaitUntilElementNotVisible(By.Id("RealTimeCampaignsDt_Table_processing"), 240);
        }

        public static void Click_DropDown_DataTableRange(string tabType, string tableRange)
        {
            switch (tabType)
            {
                case "Marketing":
                    ElementSelectFromDropDown(PageObject_Home.Home_Option_DatatableLength_Marketing(), tableRange);
                    AddDelay(3000);
                    break;
                case "Trigger":
                    ElementSelectFromDropDown(PageObject_Home.Home_Option_DatatableLength_Trigger(), tableRange);
                    AddDelay(3000);
                    break;
                case "Transactional":
                    ElementSelectFromDropDown(PageObject_Home.Home_Option_DatatableLength_Transactional(), tableRange);
                    break;
            }
        }

        public static void Click_DropDown_DateRange(string dateRange, string tabType)
        {
            switch (tabType)
            {
                case "Marketing":
                    ElementSelectFromDropDownByValue(PageObject_Home.Click_DropDown_DateRange_Marketing(), dateRange);
                    AddDelay(3000);
                    break;
                case "Trigger":
                    ElementSelectFromDropDownByValue(PageObject_Home.Click_DropDown_DateRange_Trigger(), dateRange);
                    AddDelay(3000);
                    break;
                case "Transactional":
                    ElementSelectFromDropDownByValue(PageObject_Home.Click_DropDown_DateRange_Transactional(), dateRange);

                    try
                    {
                        IWebElement ele = Driver.FindElement(By.Id("RealTimeCampaignsDt_Table_processing"));
                        while (!ele.GetAttribute("style").Contains("none"))
                        {
                            WaitUntilElementNotVisible(By.Id("RealTimeCampaignsDt_Table_processing"), 90);
                            ele = Driver.FindElement(By.Id("RealTimeCampaignsDt_Table_processing"));
                        }

                    }
                    catch (Exception) { }
                    break;
            }
            
        }
        public static void GetCountDetails(CampaignReportDetails reportdata, string caseType, string tabType)
        {
            switch(tabType)
            {
                case "Marketing":
                    switch (caseType)
                    {
                        case "Other":
                            string sendCountValue = Driver.FindElement(By.XPath("//a[contains(@href, '" + reportdata.ChildProjectID + "') and contains(@href, 'type=sent')]")).Text;
                            string deliveredCountValue = Driver.FindElement(By.XPath("//a[contains(@href, '" + reportdata.ChildProjectID + "') and contains(@href, 'type=delivered')]")).Text;
                            string openCountValue = Driver.FindElement(By.XPath("//a[contains(@href, '" + reportdata.ChildProjectID + "') and contains(@href, 'type=open')]")).Text;

                            if ((sendCountValue.Replace(",","") == reportdata.SendCount) && (deliveredCountValue.Replace(",", "") == reportdata.DeliverCount) && (openCountValue.Replace(",", "") == reportdata.OpenCount))
                            {
                                ScrollToElement(Driver.FindElement(By.XPath("//a[contains(@href, '" + reportdata.ChildProjectID + "') and contains(@href, 'type=sent')]")));
                                Logger.WriteDebugMessage("Data matched for Send, Delivered and Open for ProjectID: " + reportdata.ParentProjectID);
                            }
                            else
                            {
                                Assert.Fail();
                            }
                            break;
                        case "NetOpen":
                            //ElementClick(Driver.FindElement(By.XPath("//table[@id='MarketingCampaignsDt_table']/tbody/tr[25]/td")));
                            ScrollToElement(Driver.FindElement(By.XPath("//td[contains(text(),'" + reportdata.CampaignName + "')]")));
                            ElementClick(Driver.FindElement(By.XPath("//td[contains(text(),'"+ reportdata.CampaignName + "')]")));
                            string netOpenValue = Driver.FindElement(By.XPath("//a[contains(@href, '" + reportdata.ChildProjectID + "') and contains(@href, 'type=uniqueopened')]")).Text;

                            if ((netOpenValue.Replace(",", "") == reportdata.UniqueOpenCount))
                            {
                                Logger.WriteDebugMessage("Data matched for NetOpenValue: " + reportdata.ParentProjectID);
                            }
                            else
                            {
                                Assert.Fail();
                            }
                            break;
                    }
                    break;
                case "Trigger":
                    switch (caseType)
                    {
                        case "Other":
                            string sendCountValue = Driver.FindElement(By.XPath("//table[@id='TriggerCampaignsDt_table']//a[contains(@href, '" + reportdata.ChildProjectID + "') and contains(@href, 'type=sent')]")).Text;
                            string deliveredCountValue = Driver.FindElement(By.XPath("//table[@id='TriggerCampaignsDt_table']//a[contains(@href, '" + reportdata.ChildProjectID + "') and contains(@href, 'type=delivered')]")).Text;
                            string openCountValue;
                            if (String.IsNullOrEmpty(reportdata.OpenCount) || reportdata.OpenCount == "0")
                            {
                                openCountValue = "0";
                            }
                            else
                            {
                                openCountValue = Driver.FindElement(By.XPath("//table[@id='TriggerCampaignsDt_table']//a[contains(@href, '" + reportdata.ChildProjectID + "') and contains(@href, 'type=open')]")).Text;
                            }
                            

                            if ((sendCountValue.Replace(",", "") == reportdata.SendCount) && (deliveredCountValue.Replace(",", "") == reportdata.DeliverCount) && (openCountValue.Replace(",", "") == reportdata.OpenCount))
                            {
                                Logger.WriteDebugMessage("Data matched for Send, Delivered and Open for ProjectID: " + reportdata.ParentProjectID);
                            }
                            else
                            {
                                Assert.Fail();
                            }
                            break;
                        case "NetOpen":
                            ElementClick(Driver.FindElement(By.XPath("//table[@id='MarketingCampaignsDt_table']/tbody/tr[25]/td")));
                            string netOpenValue = Driver.FindElement(By.XPath("//table[@id='MarketingCampaignsDt_table']//a[contains(@href, '" + reportdata.ChildProjectID + "') and contains(@href, 'type=uniqueopened')]")).Text;

                            if ((netOpenValue.Replace(",", "") == reportdata.UniqueOpenCount))
                            {
                                Logger.WriteDebugMessage("Data matched for NetOpenValue: " + reportdata.ParentProjectID);
                            }
                            else
                            {
                                Assert.Fail();
                            }
                            break;
                    }
                    break;
            }
        }

        public static void NavigatetoManageCampaign(CampaignReportDetails reportdata, string tabActive)
        {
            if (tabActive == "Marketing")
            {
                ElementClick(Driver.FindElement(By.XPath("//table[@id='MarketingCampaignsDt_table']//a[contains(text(), '" + reportdata.Subject + "')]")));
            }
            if (tabActive == "Trigger")
            {
                ElementClick(Driver.FindElement(By.XPath("//table[@id='TriggerCampaignsDt_table']//a[contains(text(), '" + reportdata.Subject + "')]")));
            }

            PageLoadWait(60, "Project.mvc/Project/");
            if (VerifyTextOnPage("The requested action is not permitted."))
            {
                Logger.WriteDebugMessage("Landed on Manage Campaign. However this data is a dummy which does not have associated campaign to it.");
            }
            else 
            {
                string iFrameManageCampaign = "//iframe[@name='ManageCampaign']";
                Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(iFrameManageCampaign)));
                ElementWait(Driver.FindElement(By.XPath("//td[contains(text(), 'Project ID')]//following::a[contains(@href, 'GetProjectTemplateContent') and contains(text(), '"+ reportdata.ParentProjectID +"')]")), 60);
                if (IsElementPresent(By.XPath("//td[contains(text(), 'Project ID')]//following::a[contains(@href, 'GetProjectTemplateContent') and contains(text(), '" + reportdata.ParentProjectID + "')]")) && Driver.Url.Contains("Project.mvc"))
                {
                    Logger.WriteDebugMessage("Landed on Manage Campaign.");
                }
                else
                {
                    Assert.Fail();
                }
            }
        }

        public static string NoResultText()
        {
            string text = PageObject_Home.Home_RecentlySentCampaign_DateRange_Trigger_NoResult().Text;
            return text;
        }

    }
}
