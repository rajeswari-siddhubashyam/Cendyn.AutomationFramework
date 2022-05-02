using BaseUtility.Utility;
using InfoMessageLogger;
using CHC_Config.PageObject.UI;
using NUnit.Framework;
using System.Collections.Generic;
using System.Reflection;
using OpenQA.Selenium;
using System;

namespace CHC_Config.AppModule.UI
{
    class Create : Helper
    {
        public static void clickCreateButton()
        {
            WaitTillBrowserLoad();
            ElementWait(PageObject_Create.Create_Button(), 10);
            IWebElement createButton = PageObject_Create.Create_Button();
            createButton.Click();
        }
        public static void createAndCancel()
        {
            IList<IWebElement> create_list = PageObject_OrgIndex.Create_list();
            for (int i=0;i<create_list.Count;i++)
            {
                string text = create_list[i].Text.Trim();
                ElementClick(create_list[i]);
                
                IWebElement header = PageObject_Create.createPage_header();
                Logger.WriteDebugMessage(PageObject_Create.create_cancel().Text);
                createPropertyCancel(text, header, PageObject_Create.create_cancel());
                if (i < create_list.Count - 1)
                {
                    clickCreateButton();
                    ElementWait(PageObject_OrgIndex.Create_list()[0], 10);
                    create_list = PageObject_OrgIndex.Create_list();
                }
            }
/*
            PageObject_Create.Create_Property().Click();
            IWebElement header = PageObject_Create.Create_Property_header();
            createPropertyCancel(TestData.ExcelData.TestDataReader.ReadData(1, "create_property"),header, PageObject_Create.Create_Cancel());
            AddDelay(500);
            clickCreateButton();

            PageObject_Create.Create_Brand().Click();
            header = PageObject_Create.Create_Brand_header();
            createPropertyCancel(TestData.ExcelData.TestDataReader.ReadData(2, "create_brand"), header, PageObject_Create.Create_Cancel());
            AddDelay(500);
            clickCreateButton();

            PageObject_Create.Create_Chain().Click();
            header = PageObject_Create.Create_Chain_header();
            createPropertyCancel(TestData.ExcelData.TestDataReader.ReadData(3, "create_chain"), header, PageObject_Create.Create_Chain_Cancel());
            AddDelay(500);*/
            

        }
        public static void createPropertyCancel(string expectedHeaderText, IWebElement header, IWebElement cancel)
        {
            WaitTillBrowserLoad();
          
            if (header.Text.Trim().ToLower() == expectedHeaderText.ToLower())
            {
                Logger.WriteDebugMessage("In " + expectedHeaderText + " page");
            }
            else
            {
                Logger.WriteWarnMessage("Inside a wrong page");
            }
            Assert.AreEqual(header.Text.Trim().ToLower(), expectedHeaderText.ToLower());
            ElementClick(cancel);
            WaitTillBrowserLoad();
        }

    }
}
