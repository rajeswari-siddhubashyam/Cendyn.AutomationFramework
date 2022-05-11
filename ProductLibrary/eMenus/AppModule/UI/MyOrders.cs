using BaseUtility.Utility;
using eMenus.PageObject.UI;
using InfoMessageLogger;

namespace eMenus.AppModule.UI
{
    class MyOrders
    {
        public static void MyOrdersCreateNewOrder(string eventName,string EventName_Validation)
        {
            Click_CreateNewOrder();
            Logger.WriteDebugMessage("Create new order pop up should get displayed on the page");
            Click_CancelButton();
            Logger.WriteDebugMessage("Navigate back to My Order Page");
            Click_CreateNewOrder();
            Click_SaveButton();
            Helper.VerifyTextOnPageAndHighLight(EventName_Validation);
            Logger.WriteDebugMessage("Validation message should get displayed on page");

            Enter_EventName(eventName);
            Logger.WriteDebugMessage("Event Name is Entered");
            Click_SaveButton();
            Helper.VerifyTextOnPageAndHighLight(eventName);
            Logger.WriteDebugMessage("User should able to navigate on Event detail page of "+eventName);
        }
        public static void Click_CreateNewOrder()
        {
            Helper.ElementClick(PageObject_MyOrders.Click_CreateNewOrder());
        }
        public static void Enter_EventName(string text)
        {
            Helper.ElementEnterText(PageObject_MyOrders.Enter_EventName(), text);
        }
        public static void FromDate(string value)
        {
            Helper.ElementEnterText(PageObject_MyOrders.FromDate(), value);
        }
        public static void ToDate(string value)
        {
            Helper.ElementEnterText(PageObject_MyOrders.ToDate(), value);
        }
        public static void Click_CancelButton()
        {
            Helper.ElementClick(PageObject_MyOrders.Click_CancelButton());
        }
        public static void Click_SaveButton()
        {
            Helper.ElementClick(PageObject_MyOrders.Click_SaveButton());
        }
        public static void Search_Filter(string value)
        {
            Helper.ElementEnterText(PageObject_MyOrders.Search_Filter(),value);
        }
    }
}
