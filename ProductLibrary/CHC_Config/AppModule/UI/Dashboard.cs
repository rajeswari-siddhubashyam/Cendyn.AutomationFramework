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

namespace CHC_Config.AppModule.UI
{
    class Dashboard : Helper
    {
        public static void verifyAccountLocalizationDetails(string prop, AccountLocalization localization)
        {
            IList<IWebElement> local_fields = null;
            //if (prop.ToLower() == "chain")
           // {
                local_fields = PageObject_Dashboard.ChainDashboard_Localization();
           // }
            /*else if(prop.ToLower()=="brand")
                local_fields =PageObject_Dashboard.Bran*/
            bool pass = true;
            string failColumn = null;
            foreach(IWebElement i in local_fields)
            {
                IWebElement col_name = PageObject_Dashboard.Dashboard_ColumnName(i);
                IWebElement col_value = PageObject_Dashboard.Dashboard_ColumnValue(i);

                string columnName = col_name.Text.Trim();
                columnName = columnName.Replace(" ", ""); //string.Empty
                string DBValue = DataBinder.Eval(localization, columnName).ToString();

                if (DBValue == col_value.Text.Trim())
                {
                    HighlightElement(col_value);
                    Logger.WriteDebugMessage("Value matches DB - " + columnName + " = " + DBValue);
                    RemoveHighlightElement(col_value);
                }
                else
                {
                    Logger.WriteDebugMessage("Values not matching for " + columnName + " - UI value = " + col_value.Text.Trim() + " DB Value = " + DBValue);
                    pass = false;
                    failColumn = columnName;
                    Assert.Fail("Values not matching for " + failColumn);

                }
               
            }
            if (pass == false)
            {
                 //Assert.Fail("Values not matching for " + failColumn);
            }
        }
        public static void LogText(string prop, string section)
        {
            Logger.WriteInfoMessage("Verifying " + prop + " Dashboard -" + section + ".");
        }

        // Verify Address , Chain ID, Billing ref, Release mode
        public static void verifyAccountdetails(string prop, AccountInfo account)
        {

            IWebElement status = PageObject_Dashboard.Dashboard_status();
            IWebElement address = PageObject_Dashboard.ChainDashboard_address(); 
            IList<IWebElement> prop_fields=null;
            if (prop.ToLower() == "chain")
            {
                prop_fields = PageObject_Dashboard.ChainDashboard_property_details();
            }
            else if (prop.ToLower() == "brand")
            {
                prop_fields = PageObject_Dashboard.BrandDashboard_property_details();
            }
            else if (prop.ToLower() == "property")
            {
                prop_fields = PageObject_Dashboard.PropertyDashboard_property_details();
            }
            
            /*--------- verifying status----------*/
            if (status.Text.Trim() == account.Status)
            {
                Logger.WriteDebugMessage("Status matching - UI value = " +status.Text  + " & DB value = " + account.Status);
            }
            else
            {
                Logger.WriteDebugMessage("Status does not match - UI value = " + status.Text + " & DB value = " + account.Status);
                Assert.Fail("status not matching");
            }
            /* --------------Verifying address--------- */
            string addr = address.Text;
            addr = addr.Replace("\r\n", " ");

            if (addr.Trim() == account.Address)
            {
                Logger.WriteDebugMessage("Address matching - UI value = " + address.Text + " & DB value = " + account.Address);
            }
            else
            {
                Logger.WriteDebugMessage("Address not matching - UI value = " + address.Text + " & DB value = " + account.Address);
                Assert.Fail("Address not matching");
            }
            /* ------------Verify fields in the list ---------*/
            foreach (IWebElement i in prop_fields)
            {
                IWebElement col_name = PageObject_Dashboard.Dashboard_sideColumnName(i);
                IWebElement col_value = PageObject_Dashboard.Dashboard_sideColumnValue(i);

                string columnName = col_name.Text.Trim();
                if (columnName != "Management Company")
                {
                    if (columnName.Contains("ID"))
                        columnName = "AccountID";

                    columnName = columnName.Replace(" ", ""); //string.Empty
                    string DBValue = DataBinder.Eval(account, columnName).ToString();

                    if (DBValue == "")
                        DBValue = "--";
                    if (DBValue.Trim() == col_value.Text.Trim())
                    {
                        HighlightElement(col_value);
                        Logger.WriteDebugMessage("Value matches DB- " + columnName + " = " + DBValue);
                        RemoveHighlightElement(col_value);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Values not matching for " + columnName + " - UI value = " + col_value.Text.Trim() + " DB Value = " + DBValue);
                        Assert.Fail("Values not matching for " + columnName);
                    }
                }
                
            }
        }
        public static void VerifyPhone(string prop, List<AccountPhone> phone)
        {
            ScrollDown();
            IList<IWebElement> local_fields = null;
            //if (prop.ToLower() == "chain")
           // {
                local_fields = PageObject_Dashboard.ChainDashboard_Phone();
           // }
            /*else if(prop.ToLower()=="brand")
                local_fields =PageObject_Dashboard.Bran*/

            foreach (IWebElement i in local_fields)
            {
                IWebElement col_name = PageObject_Dashboard.Dashboard_ColumnName(i);
                IWebElement col_value = PageObject_Dashboard.Dashboard_ColumnValue(i);

                string DBValue = null;
                string columnName = col_name.Text.Trim();
                string colValue = col_value.Text.Trim();
                if (colValue[0] == '+')
                    colValue = colValue.Replace('+', ' ').TrimStart();

                foreach(AccountPhone ph in phone)
                {
                    if(ph.PhoneType == columnName)
                    {
                        DBValue = ph.PhoneNumber;
                        break;
                    }
                }
           

                if (DBValue.Trim() == colValue.Trim())//col_value.Text.Trim())
                {
                    HighlightElement(col_value);
                    Logger.WriteDebugMessage("Value matches DB - " + columnName + " = " + DBValue);
                    RemoveHighlightElement(col_value);
                }
                else
                {
                    Logger.WriteDebugMessage("Values not matching for " + columnName + " - UI value = " + colValue.Trim() + " DB Value = " + DBValue);
                    Assert.Fail("Values not matching for " + columnName);
                }

            }
        }
        public static void VerifyLinks(string prop, List<AccountLinks> links)
        {
            IList<IWebElement> local_fields = null;
            //if (prop.ToLower() == "chain")
            //{
                local_fields = PageObject_Dashboard.ChainDashboard_Link();
            //}
            /*else if(prop.ToLower()=="brand")
                local_fields =PageObject_Dashboard.Bran*/
            bool pass = true;
            foreach (IWebElement i in local_fields)
            {
                string Url = i.GetAttribute("href");
                string desc = PageObject_Dashboard.ChainDashboard_Link_image(i).GetAttribute("alt");

                foreach (AccountLinks l in links)
                {
                   if (l.Description == desc)
                   { 
                        if (Url.Contains(l.Url)||Url==l.Url)
                        {
                           Logger.WriteDebugMessage("Url matching for " + desc + " - " + Url);
                           ElementClick(i);
                           WaitTillBrowserLoad();
                           var tabs = Driver.WindowHandles;
                           Driver.SwitchTo().Window(tabs[1]);
                           if (Driver.Title.Contains(desc))
                           {
                               Logger.WriteDebugMessage("Clicked & Opened Url - " + Url);
                           }
                            Driver.Close();
                            Driver.SwitchTo().Window(tabs[0]);
                            break;
                        }
                        else
                        {
                           HighlightElement(i);
                           Logger.WriteWarnMessage("Url NOT matching for " + desc + " - " + Url);
                           pass = false;
                        }
                   }
                }
            }
            if (pass == false)
            {
                Assert.Fail("There is value mismatch for Links");
               
            }
        }
        public static void VerifyBrands(List<AccountInfo> brands)
        {
            //IList<IWebElement> tabs = PageObject_Dashboard.Dashboard_navTabs();
            IWebElement brandTab = PageObject_Dashboard.Dashboard_BrandTab();
            brandTab.Click();
            //IsElementDisplayed(PageObject_Dashboard.Dashboard_loading)
            FindLoaderAndWaitTillHide(ObjectRepository.Dashboard_loading);
            ElementWait(PageObject_Dashboard.Dashboard_Brandtable_Row()[0], 15);
            IWebElement div = PageObject_Dashboard.Dashboard_Brand_div();
            //IWebElement Brand = Driver.FindElement(By.XPath("//div[@id='chaintabsContent']/div[@id='nav-chaintabs-2']//table[contains(@id,'_content_table')]/tbody/tr[@class='e-row']//td[1]"));
            IList<IWebElement> BrandRow = PageObject_Dashboard.Dashboard_Brandtable_Row();
            int j = 0;
                for(int i=0;i<brands.Count;i++)
                {

                    //if (BrandRow[j].Displayed == false)
                    //    j++;
                    IWebElement NameColumn = PageObject_Dashboard.Dashboard_Brandtable_Names(BrandRow[j]);
                    if (brands[i].Name == NameColumn.Text)
                        {
                            HighlightElement(NameColumn);
                            Logger.WriteDebugMessage("Brand name matches DB - " + NameColumn);
                            RemoveHighlightElement(NameColumn);
                        }
                    else
                        {
                            Logger.WriteWarnMessage("Brand not found " + NameColumn);
                            Assert.Fail("Brand not found");
                        }
                j++;
                
                }
            
        }
        public static void VerifyProperties(List<AccountInfo> properties)
        {
            //List<IWebElement> tabs = PageObject_Dashboard.Dashboard_navTabs();
            IWebElement PropTab = PageObject_Dashboard.Dashboard_PropTab();
            PropTab.Click();
            //IsElementDisplayed(PageObject_Dashboard.Dashboard_loading)
            FindLoaderAndWaitTillHide(ObjectRepository.Dashboard_loading);
            AddDelay(2000);

            IWebElement div = PageObject_Dashboard.Dashboard_Prop_div();
            //IWebElement Brand = Driver.FindElement(By.XPath("//div[@id='chaintabsContent']/div[@id='nav-chaintabs-3']//table[contains(@id,'_content_table')]/tbody/tr[@class='e-row']//td[contains(@class,'e-templatecell')]"));
            IList<IWebElement> PropRow = PageObject_Dashboard.Dashboard_Proptable_Row();
            int j = 0;
            for (int i = 0; i < properties.Count; i++)
            {
                
               // if (PropRow[j].Displayed == false)
              //      j++;
                IWebElement Name = PageObject_Dashboard.Dashboard_Proptable_Names(PropRow[j]);
                             
                if (PropRow[j].Text.Contains(properties[i].Name))
                {
                    HighlightElement(PropRow[j]);
                    Logger.WriteDebugMessage("Property name matches DB " + properties[i].Name);
                    RemoveHighlightElement(PropRow[j]);
                }
                else
                {
                    Logger.WriteWarnMessage("Property not found " + properties[i].Name +" "+ PropRow[j].Text);
                    Assert.Fail("Property not found");
                }
                j++;
            }

        }
        public static string ClickBrandProp(string type)
        {
            IWebElement prop = null;
            if (type.ToLower() == "brand")
            {
                prop = PageObject_Dashboard.ChainDashboard_FirstBrand();
            }
            else if (type.ToLower() == "property")
            {
                prop = PageObject_Dashboard.ChainDashboard_FirstProperty();
            }
            string returntext = prop.Text;
            
            ElementClick(prop);
            WaitTillBrowserLoad();
            return returntext;
        }
        public static void ViewDashboard(string type,string prop )
        {
            WaitTillBrowserLoad();
            FindLoaderAndWaitTillHide(ObjectRepository.OrgIndex_loading);
            IWebElement headerElement = null, Back_to_Org = null ,brandName = null;
            
            string pageheader = null, searchtext = null;
            if (type.ToLower() == "brand")
            {
                headerElement = PageObject_Dashboard.BrandDashboard_header();
                Back_to_Org = PageObject_Dashboard.BrandDashboard_Org();
                pageheader = TestData.ExcelData.TestDataReader.ReadData(3, "brand_dashboard");
                brandName = PageObject_Dashboard.Dashboard_Brand_Name();
            }
            else
            {
                 headerElement = PageObject_Dashboard.PropertyDashboard_header();
                 Back_to_Org = PageObject_Dashboard.PropertyDashboard_Org();
                 pageheader = TestData.ExcelData.TestDataReader.ReadData(2, "property_dashboard");
                 brandName = PageObject_Dashboard.Dashboard_Property_Name();
            }
            
            string searchText = prop;
            if (headerElement.Text.ToLower() == pageheader.ToLower())
            {
                Logger.WriteDebugMessage("Able to navigate to "+type+" Dashboard ");
                if (searchText.ToLower() == brandName.Text.ToLower())
                {
                    Logger.WriteInfoMessage(type+" name - " + searchText);
                }
                else
                {
                    Logger.WriteWarnMessage("Different "+type+" listed - search " + searchText + " & actual "+type+" - " + brandName.Text);
                }
            }
            else
            {
                Logger.WriteWarnMessage("Navigated to a different page ");
            }
            Assert.AreEqual(headerElement.Text.ToLower(), pageheader.ToLower(), "Header is not displaying");
            //Back_to_Org.Click();
            Driver.Navigate().Back();
            WaitTillBrowserLoad();
        }

        public static void VerifyMetadata(PropertyAdvancedConfig ac)
        {
            ScrollDown();
            IList<IWebElement> prop_fields = null;

            prop_fields = PageObject_Dashboard.PropertyDashboard_Metadata();
            foreach (IWebElement i in prop_fields)
            {
                IWebElement col_name = PageObject_Dashboard.PropertyDashboard_ColumnName(i);
                IWebElement col_value = PageObject_Dashboard.PropertyDashboard_ColumnValue(i);

                string columnName = col_name.Text.Trim();
                
                    columnName = columnName.Replace(" ", ""); //string.Empty
                    string DBValue = DataBinder.Eval(ac, columnName).ToString();
                if (columnName.Contains("UN")==false)
                {
                    DBValue = DBValue.Replace(" ", "");
                }
               
                
                    if (DBValue == "")
                        DBValue = "--";
                    if (DBValue.ToLower() == col_value.Text.Trim().ToLower())
                    {
                        HighlightElement(col_value);
                        Logger.WriteDebugMessage("Value matches DB- " + columnName + " = " + DBValue);
                        RemoveHighlightElement(col_value);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Values not matching for " + columnName + " - UI value = " + col_value.Text.Trim() + " DB Value = " + DBValue);
                        Assert.Fail("Values not matching for " + columnName);
                    }
                

            }
        }
        public static void VerifyAdvancedConfig(PropertyAdvancedConfig ac)
        {
            ScrollDown();
            IList<IWebElement> prop_fields = null;

            prop_fields = PageObject_Dashboard.PropertyDashboard_AdvancedConfig();
            foreach (IWebElement i in prop_fields)
            {
                IWebElement col_name = PageObject_Dashboard.PropertyDashboard_ColumnName(i);
                IWebElement col_value = PageObject_Dashboard.PropertyDashboard_ColumnValue(i);

                string columnName = col_name.Text.Trim();

                columnName = columnName.Replace(" ", ""); //string.Empty
                string DBValue = DataBinder.Eval(ac, columnName).ToString();
               
                DBValue = DBValue.Replace(" ", "");
                if (DBValue == "")
                    DBValue = "--";
                if (DBValue.ToLower() == col_value.Text.Trim().ToLower())
                {
                    HighlightElement(col_value);
                    Logger.WriteDebugMessage("Value matches DB- " + columnName + " = " + DBValue);
                    RemoveHighlightElement(col_value);
                }
                else
                {
                    Logger.WriteDebugMessage("Values not matching for " + columnName + " - UI value = " + col_value.Text.Trim() + " DB Value = " + DBValue);
                    Assert.Fail("Values not matching for " + columnName);
                }
            }
        }
        public static void VerifyNumberOfRooms(PropertyAdvancedConfig ac)
        {
            ScrollDown();
            IWebElement Rooms = PageObject_Dashboard.PropertyDashboard_Rooms();
            IWebElement Beds = PageObject_Dashboard.PropertyDashboard_Beds();
            if (ac.NumberOfRooms == Rooms.Text.Trim())
                {
                    HighlightElement(Rooms);
                    Logger.WriteDebugMessage("Value matches DB- " + Rooms.Text + " = " + ac.NumberOfRooms);
                    RemoveHighlightElement(Rooms);
                }
             else
                {
                    Logger.WriteDebugMessage("Values not matching for Number Of Rooms + - UI value = " + Rooms.Text + " DB Value = " + ac.NumberOfRooms);
                    Assert.Fail("Values not matching for Number Of Rooms");
                }

             if (ac.NumberOfBeds == Beds.Text.Trim())
                {
                    HighlightElement(Beds);
                    Logger.WriteDebugMessage("Value matches DB- " + Beds.Text + " = " + ac.NumberOfBeds);
                    RemoveHighlightElement(Beds);
                }
             else
                {
                    Logger.WriteDebugMessage("Values not matching for Number Of Rooms + - UI value = " + Beds.Text + " DB Value = " + ac.NumberOfBeds);
                    Assert.Fail("Values not matching for Number Of Beds");
                }
        }
        public static void VerifyFacilities(List<string> facilitiesDB)
        {
            ScrollDown();
            IList<IWebElement> prop_fields = PageObject_Dashboard.PropertyDashboard_Facilities();
                      
            for (int i=0; i<facilitiesDB.Count;i++)
            {
                if (facilitiesDB[i]==prop_fields[i].Text.Trim())
                {
                    HighlightElement(prop_fields[i]);
                    Logger.WriteDebugMessage("Value matches DB- " + prop_fields[i].Text.Trim() + " = " + facilitiesDB[i]);
                    RemoveHighlightElement(prop_fields[i]);
                }
                else
                {
                    Logger.WriteDebugMessage("Values not matching for Facilities  - UI value = " + prop_fields[i].Text.Trim() + " DB Value = " + facilitiesDB[i]);
                    Assert.Fail("Values not matching for " + prop_fields[i].Text.Trim());
                }
            }
        }
    }
}
