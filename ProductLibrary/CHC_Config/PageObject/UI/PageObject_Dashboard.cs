using BaseUtility.PageObject;
using CHC_Config.Utility;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Reflection;


namespace CHC_Config.PageObject.UI
{
    class PageObject_Dashboard : Setup
    {
        public static string PageName = CHC_Config.Utility.Constants.PropertyDashboard;

        public static IWebElement PropertyDashboard_Org()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.PropertyDashboard_Org);
        }
        public static IWebElement PropertyDashboard_header()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.PropertyDashboard_header);
        }
        public static IWebElement Dashboard_Property_Name()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementClassName(ObjectRepository.Dashboard_Property_Name);
        }
        public static IWebElement Dashboard_Brand_Name()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementClassName(ObjectRepository.Dashboard_Brand_Name);
        }
        public static IWebElement Dashboard_Chain_Name()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementClassName(ObjectRepository.Dashboard_Chain_Name);
        }
        public static IWebElement BrandDashboard_Org()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.BrandDashboard_Org);
        }
        public static IWebElement BrandDashboard_header()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.BrandDashboard_header);
        }
        public static IWebElement ChainDashboard_Org()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ChainDashboard_Org);
        }
        public static IWebElement ChainDashboard_header()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ChainDashboard_header);
        }
        public static IList<IWebElement> Dashboard_navTabs()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Dashboard_navTabs);
        }
        public static IWebElement Dashboard_GeneralTab()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Dashboard_GeneralTab);
        }
        public static IWebElement Dashboard_BrandTab()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Dashboard_BrandTab);
        }
        public static IWebElement Dashboard_PropTab()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Dashboard_PropTab);
        }
        public static IWebElement Dashboard_General_Localization_div()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Dashboard_General_Localization_div);
        }
        public static IList<IWebElement> ChainDashboard_Localization()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.ChainDashboard_Localization);
        }
        public static IList<IWebElement> ChainDashboard_Phone()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.ChainDashboard_Phone);
        }
        public static IList<IWebElement> ChainDashboard_Link()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.ChainDashboard_Link);
        }
        public static IWebElement Dashboard_ColumnName(IWebElement element)
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return element.FindElement(By.ClassName(ObjectRepository.Dashboard_ColumnName));
        }
        public static IWebElement Dashboard_ColumnValue(IWebElement element)
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return element.FindElement(By.ClassName(ObjectRepository.Dashboard_ColumnValue));
        }
        public static IWebElement ChainDashboard_Link_image(IWebElement element)
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return element.FindElement(By.TagName(ObjectRepository.ChainDashboard_Link_image));
        }
        public static IWebElement ChainDashboard_Basic_details_div()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ChainDashboard_Basic_details_div);
        }
        public static IWebElement ChainDashboard_address()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ChainDashboard_address);
        }
        public static IWebElement Dashboard_status()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementClassName(ObjectRepository.Dashboard_status);
        }
        public static IList<IWebElement> ChainDashboard_property_details()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.ChainDashboard_property_details);
        }
        public static IList<IWebElement> BrandDashboard_property_details()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.BrandDashboard_property_details);
        }
        public static IList<IWebElement> PropertyDashboard_property_details()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.PropertyDashboard_property_details);
        }
        public static IWebElement Dashboard_sideColumnName(IWebElement element)
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return element.FindElement(By.ClassName(ObjectRepository.Dashboard_sideColumnName));
        }
        public static IWebElement Dashboard_sideColumnValue(IWebElement element)
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return element.FindElement(By.ClassName(ObjectRepository.Dashboard_sideColumnValue));
        }
        public static IWebElement Dashboard_Brand_header()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Dashboard_Brand_header);
        }
        
        public static IWebElement Dashboard_Brand_div()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Dashboard_Brand_div);
        }
        public static IList<IWebElement> Dashboard_Brandtable_Row()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Dashboard_Brandtable_Row);
        }
        public static IWebElement Dashboard_Brandtable_Names(IWebElement element)
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return element.FindElement(By.XPath(ObjectRepository.Dashboard_Brandtable_Names));
        }
        public static IList<IWebElement> Dashboard_Brandtable_DateAdded(IWebElement element)
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return element.FindElements(By.XPath(ObjectRepository.Dashboard_Brandtable_DateAdded));
        }
        
        public static IWebElement Dashboard_loading(IWebElement element)
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return element.FindElement(By.XPath(ObjectRepository.Dashboard_loading));
        }
        public static IWebElement Dashboard_Prop_div()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Dashboard_Prop_div);
        }
        public static IList<IWebElement> Dashboard_Proptable_Row()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Dashboard_Proptable_Row);
        }
        public static IWebElement Dashboard_Proptable_Names(IWebElement element)
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return element.FindElement(By.XPath(ObjectRepository.Dashboard_Prop_Names));
        }
        public static IWebElement ChainDashboard_FirstBrand()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ChainDashboard_FirstBrand);
        }
        public static IWebElement ChainDashboard_FirstProperty()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ChainDashboard_FirstProperty);
        }
        public static IList<IWebElement> PropertyDashboard_Metadata()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.PropertyDashboard_Metadata);
        }
        public static IList<IWebElement> PropertyDashboard_AdvancedConfig()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.PropertyDashboard_AdvancedConfig);
        }
        public static IList<IWebElement> PropertyDashboard_Facilities()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.PropertyDashboard_Facilities);
        }
        public static IWebElement PropertyDashboard_Rooms()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.PropertyDashboard_Rooms);
        }
        public static IWebElement PropertyDashboard_Beds()
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.PropertyDashboard_Beds);
        }
        public static IWebElement PropertyDashboard_ColumnName(IWebElement element)
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return element.FindElement(By.ClassName(ObjectRepository.PropertyDashboard_ColumnName));
        }
        public static IWebElement PropertyDashboard_ColumnValue(IWebElement element)
        {
            ScanPage(Constants.PropertyDashboard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return element.FindElement(By.ClassName(ObjectRepository.PropertyDashboard_ColumnValue));
        }
     
        


    }
}
