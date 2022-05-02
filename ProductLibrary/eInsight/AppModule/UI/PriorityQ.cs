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
    class PriorityQ : Helper
    {
        public static void SelectStartDate(string startDate)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("document.getElementById('date-startdate').value='" + startDate + "'");
            Logger.WriteDebugMessage("Entered Start Date in DatePicker - " + startDate);
        }
        public static void SelectEndDate(string endtDate)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("document.getElementById('date-enddate').value='" + endtDate + "'");
            Logger.WriteDebugMessage("Entered Start Date in DatePicker - " + endtDate);
        }

        public static void Click_SearchButton()
        {
            ElementClick(PageObject_PriorityQ.PriorityQ_Submit());
            Logger.WriteDebugMessage("Cliced on Search button");
        }

        public static void Click_ResetButton()
        {
            ElementClick(PageObject_PriorityQ.PriorityQ_Reset());
            //js = (IJavaScriptExecutor)Driver;
            //js.ExecuteScript("arguments[0].click();",PageObject_PriorityQ.PriorityQ_Reset());
            
            Logger.WriteDebugMessage("Cliced on Reset button");
        }

        public static void EnterSearchFilterValue(string value)
        {
            ElementEnterText(PageObject_PriorityQ.PriorityQ_Filter(), value);
            Logger.WriteDebugMessage("Entered value in Search filter - " + value);
        }

        public static void EnterSearchFilterValue_Clear()
        {
            ElementClearText(PageObject_PriorityQ.PriorityQ_Filter());
            PageObject_PriorityQ.PriorityQ_Filter().SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Cleared Search Filter");
        }

        public static void EnterEmailAddress(string value)
        {
            //PageObject_PriorityQ.PriorityQ_EnterEmailAddress().SendKeys(value);
            ElementEnterText(PageObject_PriorityQ.PriorityQ_EnterEmailAddress(), value);
            Logger.WriteDebugMessage("Entered value in Campaign Container - " + value);
        }
        public static void CLickCampaignContainer()
        {
            ElementClick(PageObject_PriorityQ.PriorityQ_CampaignContainer());
        }
        public static void EnterCampaignContainer_Filter(string value)
        {
            PageObject_PriorityQ.PriorityQ_CampaignContainer_Filter().SendKeys(value);
            PageObject_PriorityQ.PriorityQ_CampaignContainer_Filter().SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Entered value in Campaign Container - " + value);
        }
        public static void UncheckedCASL_CheckInputDisabled(int typeCheck)
        {
            bool reservationTo = Driver.FindElement(By.Id("reservation_to")).Enabled;
            bool campaignList = Driver.FindElement(By.Id("reservation_campaign")).Enabled;

            switch (typeCheck)
            {
                case 0:
                    
                    if ((reservationTo == false) && (campaignList == false))
                    {
                        Logger.WriteDebugMessage("CASL Checkbox is unchecked and To EmailAddress and Reservation Campaign DropDown are Disabled");
                    }
                    else
                    {
                        Assert.Fail("To EmailAddress and Reservation Campaign DropDown was not Disabled");
                    }
                    break;
                case 1:
                    if ((reservationTo == true) && (campaignList == true))
                    {
                        Logger.WriteDebugMessage("CASL Checkbox is unchecked and To EmailAddress and Reservation Campaign DropDown are Enabled");
                    }
                    else
                    {
                        Assert.Fail("To EmailAddress and Reservation Campaign DropDown was not Disabled");
                    }
                    break;
            }
        }
        public static void Click_ComplianceCheck()
        {
            ElementClick(Driver.FindElement(By.Id("email_compliance_check")));
            Logger.WriteDebugMessage("Click on Email Compliance Check");
        }

        public static void ChangeTemplateDiv(string value)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("document.getElementById('divEditor').innerText='" + value + "'");
            Logger.WriteDebugMessage("Changed the text in Template - " + value);
        }

        private static void Click_SendtoTest()
        {
            ElementClick(PageObject_PriorityQ.PriorityQ_SendtoTest());
            Logger.WriteDebugMessage("Click on Send to Test Email Button");
        }

        private static void Click_SendtoTest_Send()
        {
            ElementClick(PageObject_PriorityQ.PriorityQ_SendtoTestButton());
            Logger.WriteDebugMessage("Click on Send to Test Button");
        }
        
        public static void Send_SentoTest(string value = null)
        {
            Click_SendtoTest();
            if (!String.IsNullOrEmpty(value))
            {
                ElementEnterText(Driver.FindElement(By.Id("sendTestEmail")), value);
                Logger.WriteDebugMessage("Entered Email - " + value);
            }
            Click_SendtoTest_Send();
            AddDelay(15000);
        }

        public static string GetSelectedSubject()
        {
            string result;

            return result = Driver.FindElement(By.Id("select2-reservation_campaign-container")).Text;
        }

        public static void SendTemplate()
        {
            ElementClick(Driver.FindElement(By.Id("sendemail")));
            if (VerifyTextOnPage("Confirm"))
            {
                Logger.WriteDebugMessage("Landed on Confirm Page to send email.");
                ElementClick(Driver.FindElement(By.Id("success_prompt")));
                Logger.WriteDebugMessage("Email Sent.");
            }
            else
            {
                Assert.Fail("Did not sent on Confirm Page.");
            }
            AddDelay(25000);
        }

        public static void Click_SendEmail_Cancel()
        {
            ElementClick(PageObject_PriorityQ.PriorityQ_SendEmail_Cancel());
            Logger.WriteDebugMessage("Clicked on Cancel Button.");
            AddDelay(8000);
        }
        public static void Click_SendEmail_Modal_Cancel()
        {
            ElementClick(PageObject_PriorityQ.PriorityQ_SendEmail_Cancel());
            Logger.WriteDebugMessage("Clicked on Cancel Button.");
            AddDelay(8000);
        }

        public static void Click_SendEmailPrompt_Cancel()
        {
            ElementClick(PageObject_PriorityQ.PriorityQ_SendEmail_Prompt_Cancel());
            Logger.WriteDebugMessage("Clicked Cancel button on SendEmail Prompt Page.");
        }

        public static void Delete_Section(string divID)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            //js.ExecuteScript("$('#"+divID+"').remove();");
            IWebElement element = Driver.FindElement(By.Id(divID));
            js.ExecuteScript("arguments[0].click();", element);
            js.ExecuteScript("arguments[0].remove();", element);
            Logger.WriteDebugMessage("Removed Element - " + divID);
        }

        public static void SelectCampaign(string campaignName)
        {
            ElementClick(Driver.FindElement(By.Id("select2-reservation_campaign-container")));
            ElementEnterText(Driver.FindElement(By.ClassName("select2-search__field")), campaignName);
            Driver.FindElement(By.ClassName("select2-search__field")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage(campaignName + " was selected.");
            AddDelay(15000);
            
            //ElementClick(Driver.FindElement(By.Id("select2-reservation_campaign-container")));
            //string getCampaignName = Driver.FindElement(By.ClassName("select2-results__option--highlighted")).Text;

            //if (campaignName == getCampaignName)
            //{
            //    Logger.WriteDebugMessage(campaignName + " was selected.");
            //}
            //else
            //{
            //    Assert.Fail(campaignName + " was not selected.");
            //}
            //ElementClick(Driver.FindElement(By.Id("select2-reservation_campaign-container")));
        }
    }
}
