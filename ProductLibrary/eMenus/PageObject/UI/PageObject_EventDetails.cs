using System.Reflection;
using BaseUtility.PageObject;
using eMenus.Utility;
using OpenQA.Selenium;

namespace eMenus.PageObject.UI
{
    class PageObject_EventDetails : Setup
    {
        public static string PageName = Utility.Constants.EventDetails;
        public static IWebElement Click_AddFunction()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ClickAddFunction);
        }
        public static IWebElement FunctionDate()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.FunctionDate);
        }
        public static IWebElement FunctionName()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Function_Name);
        }
        public static IWebElement NumberOfGuests()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.NumberOfGuests);
        }
        public static IWebElement FunctionRoom()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Function_Room);
        }
        public static IWebElement FunctionType()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Function_Type);
        }
        public static IWebElement SetupStyle()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SetupStyle);
        }
        public static IWebElement StartTime()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.StartTime);
        }
        public static IWebElement EndTime()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.EndTime);
        }
        public static IWebElement CancelButton()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CancelButton);
        }
        public static IWebElement SaveButton()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SaveButton);
        }
        public static IWebElement Click_AddMenu()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddMenu);
        }
        public static IWebElement MenuName()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.MenuName);
        }
        public static IWebElement AddMenu_CancelButton()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AddMenu_CancelButton);
        }
        public static IWebElement GoToMenu_Button()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.GoToMenu_Button);
        }
        public static IWebElement AddMenu_AddClick()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AddMenu_AddClick);
        }
        public static IWebElement AddMenuModal_CancelButton()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AddMenuModal_CancelButton);
        }
        public static IWebElement AddMenuModal_AddButton()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AddMenuModal_AddButton);
        }
        public static IWebElement GoToEventDetails()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.GoToEventDetails);
        }
        public static IWebElement Click_ReviewOrder()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ClickReviewOrder);
        }
        public static IWebElement OrderInformation_Contact()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.OrderInformation_Contact);
        }
        public static IWebElement OrderInformation_PaymentMothod()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.OrderInformation_PaymentMothod);
        }
        public static IWebElement OrderInformation_ContinueButton()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.OrderInformation_ContinueButton);
        }
        public static IWebElement ReviewOrder_SaveButton()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ReviewOrder_SaveButton);
        }
        public static IWebElement MyOrders_Button()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyOrders_Button);
        }
        public static IWebElement Click_AddMenuModal_CancelButton()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_AddMenuModal_CancelButton);
        }
        public static IWebElement ReviewOrder_SendButton()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ReviewOrder_SendButton);
        }
        public static IWebElement ReviewOrder_SendOrder_SendButton()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ReviewOrder_SendOrder_SendButton);
        }
        public static IWebElement SendOrdersMyOrders_Button()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SendOrdersMyOrders_Button);
        }
        public static IWebElement Click_Comment_Function()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Comment_Function);
        }
        public static IWebElement Enter_Function_Comments()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EnterComments);
        }
        public static IWebElement Click_AddComment()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddComment);
        }
        public static IWebElement Click_Edit_Function()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Edit_Function);
        }
        public static IWebElement Click_Copy_Function()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Copy_Function);
        }
        public static IWebElement Enter_CloneFunctionName()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_CloneFunctionName);
        }
        public static IWebElement Select_CloneFunctionDate()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_CloneFunctionDate);
        }
        public static IWebElement Click_CloneSaveFunction()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_CloneSaveFunction);
        }
        public static IWebElement Click_Delete_Function()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Delete_Function);
        }
        public static IWebElement Click_DeleteFunctionbutton()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_DeleteFunctionbutton);
        }
        public static IWebElement Click_Edit_Menu()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Edit_Menu);
        }
        public static IWebElement Enter_EditMenu_Menu_Quantity()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_EditMenu_Menu_Quantity);
        }
        public static IWebElement Enter_EditMenu_Menu_Special_Request()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_EditMenu_Menu_Special_Request);
        }
        public static IWebElement Click_EditMenu_Menu_Save_Button()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_EditMenu_Menu_Save_Button);
        }
        public static IWebElement Click_Copy_Menu()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Copy_Menu);
        }
        public static IWebElement Select_CopyMenu_FunctionList()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_CopyMenu_FunctionList);
        }
        public static IWebElement Click_CopyMenu_FunctionList_Save()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_CopyMenu_FunctionList_Save);
        }
        public static IWebElement Click_Delete_Menu()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Delete_Menu);
        }
        public static IWebElement Click_Delete_Menu_Button()
        {
            ScanPage(Utility.Constants.EventDetails);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Delete_Menu_Button);
        }
    }
}
