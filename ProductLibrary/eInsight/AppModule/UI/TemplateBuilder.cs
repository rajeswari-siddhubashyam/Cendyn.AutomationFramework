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
    class TemplateBuilder : Helper
    {
        public static void Enter_TemplateName(string templateName)
        {
            ElementEnterText(PageObject_TemplateBuilder.Template_EnterTemplateName(), templateName);
            
            Logger.WriteDebugMessage("Searching for Template Name - " + templateName);
            ElementWait(Driver.FindElement(By.XPath("//h4[contains(text(), '"+ templateName +"')]")), 120);
            if (IsElementPresent(By.XPath("//h4[contains(text(), '"+ templateName + "')]")))
            {
                Logger.WriteDebugMessage("Template Name - " + templateName + " displayed on screen.");
            }
            else
            {
                Assert.Fail("Template Name - " + templateName + " did not displayed on screen.");
            }
        }
    }
}
