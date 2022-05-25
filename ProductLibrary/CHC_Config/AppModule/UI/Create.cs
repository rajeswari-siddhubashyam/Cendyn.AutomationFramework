using BaseUtility.Utility;
using InfoMessageLogger;
using CHC_Config.PageObject.UI;
using NUnit.Framework;
using System.Collections.Generic;
using System.Reflection;
using OpenQA.Selenium;
using System;
using CHC_Config.Entity;
using System.Web.UI;
using CHC_Config.Utility;
using OpenQA.Selenium.Support.UI;

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
        public static void clickManageBrand()
        {
            WaitTillBrowserLoad();
            ElementWait(PageObject_Create.Manage_Brand(), 10);
            IWebElement Manage = PageObject_Create.Manage_Brand();
            Manage.Click();
            ElementWait(PageObject_Create.Edit_Details(), 20);
            IWebElement edit = PageObject_Create.Edit_Details();
            edit.Click();
        }
        public static void EditBrandPage(AccountInfo account,string expectedHeaderText)
        {
            WaitTillBrowserLoad();
            ElementWait(PageObject_Create.createPage_header(), 10);
            IWebElement header = PageObject_Create.createPage_header();
            if (header.Text.Trim().ToLower() == expectedHeaderText.ToLower())
            {
                Logger.WriteDebugMessage("In " + expectedHeaderText + " page");
            }
            else
            {
                Logger.WriteWarnMessage("Inside a wrong page");
            }
            Assert.AreEqual(header.Text.Trim().ToLower(), expectedHeaderText.ToLower());

            IWebElement sChain = PageObject_Create.input_chain();
            string selectedChain = sChain.GetAttribute("value");
            if (selectedChain.ToLower() == account.Chain.ToLower())
            {
                Logger.WriteDebugMessage("Chain selected in dropdown is "+ selectedChain.Trim()+" DB Value is "+ account.Chain);
            }
            else
            {
                Logger.WriteWarnMessage("Wrong Chain selected in dropdown  UI- " + selectedChain.Trim() + " DB Value is " + account.Chain);
            }
            Assert.AreEqual(selectedChain.Trim().ToLower(), account.Chain.ToLower());

            string BrandName = PageObject_Create.input_brand().GetAttribute("value");
            if (BrandName.Trim().ToLower() == account.Name.ToLower())
            {
                Logger.WriteDebugMessage("Brand selected in textbox is " + BrandName.Trim() + " DB Value is " + account.Name);
            }
            else
            {
                Logger.WriteWarnMessage("Wrong Brand selected in textbox  UI- " + BrandName.Trim() + " DB Value is " + account.Name);
            }
            Assert.AreEqual(BrandName.Trim().ToLower(), account.Name.ToLower());

            ElementClick(PageObject_Create.create_cancel());
            WaitTillBrowserLoad();
        }
        public static void clickManageProperty()
        {
            WaitTillBrowserLoad();
            ElementWait(PageObject_Create.Manage_Property(), 10);
            IWebElement Manage = PageObject_Create.Manage_Property();
            Manage.Click();
            ElementWait(PageObject_Create.Edit_Details(), 20);
            IWebElement edit = PageObject_Create.Edit_Details();
            edit.Click();
        }
        public static void EditPropertyPage(AccountInfo account, string expectedHeaderText)
        {
            WaitTillBrowserLoad();
            ElementWait(PageObject_Create.createPage_header(), 10);
            IWebElement header = PageObject_Create.createPage_header();
            if (header.Text.Trim().ToLower() == expectedHeaderText.ToLower())
            {
                Logger.WriteDebugMessage("In " + expectedHeaderText + " page");
            }
            else
            {
                Logger.WriteWarnMessage("Inside a wrong page");
            }
            Assert.AreEqual(header.Text.Trim().ToLower(), expectedHeaderText.ToLower());

            IWebElement sChain = PageObject_Create.input_chain();
            string selectedChain = sChain.GetAttribute("value");
            if (selectedChain.ToLower() == account.Chain.ToLower())
            {
                Logger.WriteDebugMessage("Chain selected in dropdown is " + selectedChain.Trim() + " DB Value is " + account.Chain);
            }
            else
            {
                Logger.WriteWarnMessage("Wrong Chain selected in dropdown  UI- " + selectedChain.Trim() + " DB Value is " + account.Chain);
            }
            Assert.AreEqual(selectedChain.Trim().ToLower(), account.Chain.ToLower());

            string BrandName = PageObject_Create.input_brand().GetAttribute("value");
            if (BrandName.Trim().ToLower() == account.Brand.Trim().ToLower())
            {
                Logger.WriteDebugMessage("Brand displayed in dropdown is " + BrandName.Trim() + " DB Value is " + account.Brand.Trim());
            }
            else
            {
                Logger.WriteWarnMessage("Wrong Brand displayed in dropdown  UI- " + BrandName.Trim() + " DB Value is " + account.Brand.Trim());
            }
            Assert.AreEqual(BrandName.Trim().ToLower(), account.Brand.Trim().ToLower());

            string PropertyName = PageObject_Create.input_property().GetAttribute("value");
            if (PropertyName.Trim().ToLower() == account.Name.Trim().ToLower().Trim())
            {
                Logger.WriteDebugMessage("Property selected in textbox is " + PropertyName.Trim() + " DB Value is " + account.Name.Trim());
            }
            else
            {
                Logger.WriteWarnMessage("Wrong Property selected in textbox  UI- " + PropertyName.Trim() + " DB Value is " + account.Name.Trim());
            }
            Assert.AreEqual(PropertyName.Trim().ToLower(), account.Name.Trim().ToLower());
            ElementClick(PageObject_Create.create_cancel());
            WaitTillBrowserLoad();
        }

    }
}
