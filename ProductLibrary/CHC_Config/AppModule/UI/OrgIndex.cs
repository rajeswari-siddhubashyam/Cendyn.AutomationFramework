using BaseUtility.Utility;
using InfoMessageLogger;
using CHC_Config.PageObject.UI;
using NUnit.Framework;
using System.Collections.Generic;
using System.Reflection;
using OpenQA.Selenium;
using System;
using CHC_Config.Utility;
using OpenQA.Selenium.Support.UI;

namespace CHC_Config.AppModule.UI
{
    class OrgIndex : Helper
    {
        public static void viewColumnNames()
        {
            IList<IWebElement> columns = PageObject_OrgIndex.OrgIndex_Columns();
            int count = 0, fail = 0;
            string logtext = "";
            foreach (IWebElement i in columns)
            {
                count++;
                if (i.Text != "")
                {
                    string columnName = TestData.ExcelData.TestDataReader.ReadData(count, "header");
                    if (columnName.ToLower() != i.Text.ToLower())
                    {
                        Logger.WriteWarnMessage("Column not found " + columnName);
                        Assert.Fail("ColumnName not found");
                        fail = 1;
                    }
                    else
                        logtext = logtext + i.Text+", ";
                }
            }
            if (fail == 0)
            {
                Logger.WriteDebugMessage("Columns found - " + logtext);
             
            }
        }
        
        public static void VerifyPropertyTable()
        {
            IWebElement td = PageObject_OrgIndex.SearchResults_PropertyName();
            if (td.Text!="" && td.Text!= "No records to display")
            {
                Logger.WriteDebugMessage("Properties displayed");
            }
            else
            {
                Logger.WriteWarnMessage("Property table is blank");
                Assert.Fail("Property table is blank");
            }


        }
        public static void SearchPropertyName()
        {
            FindLoaderAndWaitTillHide(ObjectRepository.OrgIndex_loading);
            IWebElement filter = PageObject_OrgIndex.Filter_PropertyName();
            string searchText = TestData.ExcelData.TestDataReader.ReadData(1, "search");
            WaitTillBrowserLoad();
            FindLoaderAndWaitTillHide(ObjectRepository.OrgIndex_loading);
            //ElementWait(PageObject_OrgIndex.SearchResults_Row(), 10);
            filter.SendKeys(searchText);
            Logger.WriteDebugMessage("Searching Property Name -" + searchText);
            WaitTillBrowserLoad();
            PageObject_OrgIndex.Filter_PropertyName_Search().Click();
            WaitTillBrowserLoad();
            FindLoaderAndWaitTillHide(ObjectRepository.OrgIndex_loading);
            
            //AddDelay(1000);
            IWebElement searchResult_PropertyName = PageObject_OrgIndex.SearchResults_PropertyName();
            //Verify searched text is equal to the Property displayed in the table           
            if (searchResult_PropertyName.Text.Trim().ToLower() == searchText.ToLower().Trim())
            {
                Logger.WriteDebugMessage("Search result displays matching Property Details for " + searchText);
            }
            else
            {   // Check No records to display
                if (PageObject_OrgIndex.SearchResults_Row().Text.Trim()==TestData.ExcelData.TestDataReader.ReadData(2,"noRecords"))
                {
                    Logger.WriteWarnMessage("Search Results returned blank" );
                }
                else 
                {
                    Logger.WriteWarnMessage("Search result does not match");
                    
                }
           
            }
            Assert.AreEqual(searchResult_PropertyName.Text.Trim().ToLower(), searchText.ToLower().Trim(), "Search results not matching");
        }
        public static void Filter_Options_ByPropertyName()
        {
            FindLoaderAndWaitTillHide(ObjectRepository.OrgIndex_loading);
            string searchText = TestData.ExcelData.TestDataReader.ReadData(1, "search");
            WaitTillBrowserLoad();
            FindLoaderAndWaitTillHide(ObjectRepository.OrgIndex_loading);
            ElementWait(PageObject_OrgIndex.FilterButton(), 20);
            IWebElement filter = PageObject_OrgIndex.FilterButton();
            AddDelay(2000);
            filter.Click();
            IList<IWebElement> Filter_Options = PageObject_OrgIndex.Filter_Options();
            foreach(IWebElement i in Filter_Options)
            {
                Logger.WriteDebugMessage("i.Text " + i.Text);
                string text = i.Text;
                
                if (i.Text.Contains("Property"))
                {
                    if(i.Text.Contains("Property ID")!=true)
                    {
                        IWebElement dropdown = PageObject_OrgIndex.Filter_Options_Select(i);
                        SelectElement s = new SelectElement(dropdown);
                        s.SelectByValue("startswith");
                        PageObject_OrgIndex.Filter_Options_Text(i).SendKeys(searchText);
                        PageObject_OrgIndex.Filter_Applybutton(i).Click();
                        break;
                    }
                }
            }
            //filter.SendKeys(searchText);
            Logger.WriteDebugMessage("Searching Property Name -" + searchText);
            //WaitTillBrowserLoad();
            //PageObject_OrgIndex.Filter_PropertyName_Search().Click();
            //WaitTillBrowserLoad();
            //FindLoaderAndWaitTillHide(ObjectRepository.OrgIndex_loading);

            //AddDelay(1000);
            IWebElement searchResult_PropertyName = PageObject_OrgIndex.SearchResults_PropertyName();
            //Verify searched text is equal to the Property displayed in the table           
            if (searchResult_PropertyName.Text.Trim().ToLower() == searchText.ToLower().Trim())
            {
                Logger.WriteDebugMessage("Search result displays matching Property Details for " + searchText);
            }
            else
            {   // Check No records to display
                if (PageObject_OrgIndex.SearchResults_Row().Text.Trim() == TestData.ExcelData.TestDataReader.ReadData(2, "noRecords"))
                {
                    Logger.WriteWarnMessage("Search Results returned blank");
                }
                else
                {
                    Logger.WriteWarnMessage("Search result does not match");

                }

            }
            Assert.AreEqual(searchResult_PropertyName.Text.Trim().ToLower(), searchText.ToLower().Trim(), "Search results not matching");
        }
        public static void ViewPropertyDashboard()
        {
            IWebElement Property = PageObject_OrgIndex.SearchResults_PropertyName();
            Property.Click();
            WaitTillBrowserLoad();
            FindLoaderAndWaitTillHide(ObjectRepository.OrgIndex_loading);
            //AddDelay(1000); // WaitTillInvisibilityOfLoader

            IWebElement headerElement = PageObject_Dashboard.PropertyDashboard_header();
                      
            IWebElement Back_to_Org = PageObject_Dashboard.PropertyDashboard_Org();
            string pageheader = TestData.ExcelData.TestDataReader.ReadData(2, "property_dashboard");
            IWebElement propertyName = PageObject_Dashboard.Dashboard_Property_Name();
            
            string searchText = TestData.ExcelData.TestDataReader.ReadData(1, "search");
            if (headerElement.Text.ToLower() == pageheader.ToLower())
            {
                Logger.WriteDebugMessage("Able to navigate to Property Dashboard ");
                if(searchText.ToLower()== propertyName.Text.ToLower())
                {
                    Logger.WriteInfoMessage("Property name - " + searchText);
                }
                else
                {
                    Logger.WriteWarnMessage("Different Property listed - search " + searchText+ " & actual property - "+ propertyName.Text);
                }
            }
            else
            {
                Logger.WriteWarnMessage("Navigated to a different page ");
            }
            // message  + assertion
            Assert.AreEqual(headerElement.Text.ToLower(), pageheader.ToLower(),"Header is not displaying");
            //Back_to_Org.Click();
            WaitTillBrowserLoad();
        }
        public static void ViewBrandDashboard()
        {
            IWebElement Brand = PageObject_OrgIndex.SearchResults_Brand();
            Brand.Click();
            WaitTillBrowserLoad();
            FindLoaderAndWaitTillHide(ObjectRepository.OrgIndex_loading);
            //AddDelay(1000);

            IWebElement headerElement = PageObject_Dashboard.BrandDashboard_header();

            IWebElement Back_to_Org = PageObject_Dashboard.BrandDashboard_Org();
            string pageheader = TestData.ExcelData.TestDataReader.ReadData(3, "brand_dashboard");
            IWebElement brandName = PageObject_Dashboard.Dashboard_Brand_Name();

            string searchText = TestData.ExcelData.TestDataReader.ReadData(5, "brand_name");
            if (headerElement.Text.ToLower() == pageheader.ToLower())
            {
                Logger.WriteDebugMessage("Able to navigate to Brand Dashboard ");
                if (searchText.ToLower() == brandName.Text.ToLower())
                {
                    Logger.WriteInfoMessage("Brand name - " + searchText);
                }
                else
                {
                    Logger.WriteWarnMessage("Different Brand listed - search " + searchText + " & actual brand - " + brandName.Text);
                }
            }
            else
            {
                Logger.WriteWarnMessage("Navigated to a different page ");
            }
            Assert.AreEqual(headerElement.Text.ToLower(), pageheader.ToLower(), "Header is not displaying");
            //Back_to_Org.Click();
            WaitTillBrowserLoad();
        }
        public static void ViewChainDashboard()
        {
            IWebElement Chain = PageObject_OrgIndex.SearchResults_Chain();
            Chain.Click();
            WaitTillBrowserLoad();
            FindLoaderAndWaitTillHide(ObjectRepository.OrgIndex_loading);
            //AddDelay(1000);

            IWebElement headerElement = PageObject_Dashboard.ChainDashboard_header();

            IWebElement Back_to_Org = PageObject_Dashboard.ChainDashboard_Org();
            string pageheader = TestData.ExcelData.TestDataReader.ReadData(4, "chain_dashboard");
            IWebElement chainName = PageObject_Dashboard.Dashboard_Chain_Name();

            string searchText = TestData.ExcelData.TestDataReader.ReadData(6, "chain_name");
            if (headerElement.Text.ToLower() == pageheader.ToLower())
            {
                Logger.WriteDebugMessage("Able to navigate to Chain Dashboard ");
                if (searchText.ToLower() == chainName.Text.ToLower())
                {
                    Logger.WriteInfoMessage("Chain name - " + searchText);
                }
                else
                {
                    Logger.WriteWarnMessage("Different Chain listed - search " + searchText + " & actual chain - " + chainName.Text);
                }
            }
            else
            {
                Logger.WriteWarnMessage("Navigated to a different page ");
            }
            Assert.AreEqual(headerElement.Text.ToLower(), pageheader.ToLower(), "Header is not displaying");
            
           // Back_to_Org.Click();
            WaitTillBrowserLoad();
        }
        public static void BackToOrganization(string prop)
        {

            IWebElement Back_to_Org = null;
            if (prop.ToLower() == "chain")
                Back_to_Org = PageObject_Dashboard.ChainDashboard_Org();
            else if (prop.ToLower() == "brand")
                Back_to_Org = PageObject_Dashboard.BrandDashboard_Org();
            else
                Back_to_Org = PageObject_Dashboard.PropertyDashboard_Org();

            Back_to_Org.Click();
            WaitTillBrowserLoad();
        }

    }
}
