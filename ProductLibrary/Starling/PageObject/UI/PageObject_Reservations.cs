using BaseUtility.PageObject;
using CHC.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CHC.PageObject.UI
{
    public class PageObject_Reservations : Setup
    {
        public static string PageName = Utility.Constants.Home;
        public static IWebElement Search_ReservationID()
        {
            ScanPage(Constants.Reservations);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ReservationID_Search);
        }
    }
}
