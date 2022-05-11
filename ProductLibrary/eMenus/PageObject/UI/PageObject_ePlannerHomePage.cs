using BaseUtility.PageObject;
using eMenus.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace eMenus.PageObject.UI
{
    class PageObject_ePlannerHomePage : Setup
    {
        public static string PageName = Utility.Constants.ePlannerFrontEndHome;

        public static IWebElement Home_SearchBox()
        {
            ScanPage(Utility.Constants.ePlannerFrontEndHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_SearchBox);
        }
    }
}
