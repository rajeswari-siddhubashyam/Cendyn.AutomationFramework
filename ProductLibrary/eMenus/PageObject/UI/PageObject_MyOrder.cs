using System.Collections.Generic;
using System.Reflection;
using BaseUtility.PageObject;
using eMenus.Utility;
using OpenQA.Selenium;

namespace eMenus.PageObject.UI
{
    class PageObject_MyOrder : Setup
    {
        public static string PageName = Utility.Constants.MyOrder;

        public static IWebElement Enter_EventName()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EventName);
        }
        public static IWebElement Select_EventStartDate()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Event_StartDate);
        }
        public static IWebElement Select_EventEndDate()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Event_EndDate);
        }
        public static IWebElement Click_CreateOrder()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_CreateOrder);
        }
        public static IWebElement Click_AddFunction()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddFunction);
        }
        public static IWebElement Enter_FunctionName()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.FunctionName);
        }
        public static IWebElement Select_NoOfGuest()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.NoOfGuest);
        }
        public static IWebElement Enter_FunctionRoom()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.FunctionRoom);
        }
        public static IWebElement Select_FunctionType()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.FunctionType);
        }
        public static IWebElement Select_SetupType()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SetupType);
        }
        public static IWebElement Click_CreateFunction()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_CreateFunction);
        }
        public static IWebElement Click_AddMenu()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AddMenu);
        }
        public static IWebElement Select_Menu()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SelectMenu);
        }
        public static IWebElement GotoMenu()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.GotoMenu);
        }
        public static IWebElement AddMenuItem()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AddMenuItem);
        }
        public static IWebElement AddMenuItemNext()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AddMenuItemNext);

        }
        public static void CheckChoice()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            IList<IWebElement> list = BaseUtility.Utility.Helper.Driver.FindElements(By.XPath(ObjectRepository.CheckChoice));
            foreach (IWebElement value in list)
            {
                if (value != null)
                {
                    BaseUtility.Utility.Helper.ElementClick(value);
                }
            }
        }
        public static IWebElement AddMenuChoice()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AddMenuChoice);

           
        }
        public static IWebElement Click_GoToEventDetails()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_GoToEventDetails);
        }
        public static IWebElement Click_ReviewOrder()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ReviewOrder);
        }
        public static IWebElement Select_Event_Contact()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Select_Contact);
        }
        public static IWebElement Enter_Event_Payment_Method()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Event_Payment_Method);
        }
        public static IWebElement Customer_FirstName()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Customer_FirstName);
        }
        public static IWebElement Customer_LastName()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Customer_LastName);
        }
        public static IWebElement Customer_Address()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Customer_Address);
        }
        public static IWebElement Customer_Address2()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Customer_Address2);
        }
        public static IWebElement Customer_City()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Customer_City);
        }
        public static IWebElement Customer_State()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Customer_State);
        }
        public static IWebElement Customer_PostalCode()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Customer_PostalCode);
        }
        public static IWebElement Customer_Country()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Customer_Country);
        }
        public static IWebElement Customer_Phone()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Customer_Phone);
        }
        public static IWebElement Customer_Email()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Customer_Email);
        }
        public static IWebElement Customer_Company()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Customer_Company);
        }
        public static IWebElement Click_Continue()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Continue);
        }
        public static IWebElement Select_Contact()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Select_Contact);
        }
        public static IWebElement Click_Save_Order()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Save_Order);
        }
        public static IWebElement Click_MyOrder()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyOrder);
        }
        public static IWebElement Search_Filter()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Search_Filter);
        }
        public static IWebElement Click_EditOrder()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_EditOrder);
        }
        public static IWebElement Click_SendOrder()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_SendOrder);
        }
        public static IWebElement Click_SendOrder_Confirmation()
        {
            ScanPage(Utility.Constants.MyOrder);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_SendOrder_Confirmation);
        }
    }
}

