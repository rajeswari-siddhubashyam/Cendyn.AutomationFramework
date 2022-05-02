using System;
using BaseUtility.Utility;
using eMenus.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;

namespace eMenus.AppModule.UI
{
    class EventDetails
    {
        public static void Click_AddFunction()
        {
            Helper.ElementClick(PageObject_EventDetails.Click_AddFunction());
        }
        public static void FunctionDate(string text)
        {
            Helper.ElementEnterText(PageObject_EventDetails.FunctionDate(), text);
        }
        public static void FunctionName(string text)
        {
            Helper.ElementEnterText(PageObject_EventDetails.FunctionName(), text);
        }
        public static void NumberOfGuests(string text)
        {
            Helper.ElementEnterText(PageObject_EventDetails.NumberOfGuests(), text);
        }
        public static void FunctionRoom(string text)
        {
            Helper.ElementEnterText(PageObject_EventDetails.FunctionRoom(), text);
        }
        public static void FunctionType(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_EventDetails.FunctionType(), text);
        }
        public static void SetupStyle(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_EventDetails.SetupStyle(), text);
        }
        public static void StartTime(string text)
        {
            Helper.ElementEnterText(PageObject_EventDetails.StartTime(), text);
        }
        public static void EndTime(string text)
        {
            Helper.ElementEnterText(PageObject_EventDetails.EndTime(), text);
        }
        public static void CancelButton()
        {
            Helper.ElementClick(PageObject_EventDetails.CancelButton());
        }
        public static void SaveButton()
        {
            Helper.ElementClick(PageObject_EventDetails.SaveButton());
        }
        public static void AddFunction(string FunctionName_Validation,string NoOfGuests_Validation,string Function_Name,string NoOf_Guests,string Function_Room,string Function_Type,string SetUp_Style)
        {
            Click_AddFunction();
            Logger.WriteDebugMessage("Add function modal should get displayed");
            CancelButton();
            Logger.WriteDebugMessage("Navigate back to Event Page");
            Click_AddFunction();
            SaveButton();
            Helper.VerifyTextOnPageAndHighLight(FunctionName_Validation);
            Helper.VerifyTextOnPageAndHighLight(NoOfGuests_Validation);
            Logger.WriteDebugMessage("Validation message should display for madetory fields");
            FunctionName(Function_Name);
            NumberOfGuests(NoOf_Guests);
            FunctionRoom(Function_Room);
            FunctionType(Function_Type);
            SetupStyle(SetUp_Style);
            Logger.WriteDebugMessage("All the details are added into add Function Overlay");
            SaveButton();
            Helper.VerifyTextOnPageAndHighLight(Function_Name);
            Logger.WriteDebugMessage("Function should get save and displayed on the page"+ Function_Name);
        }
        public static void Click_AddMenu()
        {
            Helper.ElementClick(PageObject_EventDetails.Click_AddMenu());
        }
        public static void MenuName(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_EventDetails.MenuName(), value);
        }
        public static void AddMenu_CancelButton()
        {
            Helper.ElementClick(PageObject_EventDetails.AddMenu_CancelButton());
        }
        public static void GoToMenu_Button()
        {
            Helper.ElementClick(PageObject_EventDetails.GoToMenu_Button());
        }
        public static void AddMenu_AddClick()
        {
            Helper.ElementClick(PageObject_EventDetails.AddMenu_AddClick());
        }
        public static void AddMenuModal_CancelButton()
        {
            Helper.ElementClick(PageObject_EventDetails.AddMenuModal_CancelButton());
        }
        public static void AddMenuModal_AddButton()
        {
            Helper.ElementClick(PageObject_EventDetails.AddMenuModal_AddButton());
        }
        public static void GoToEventDetails()
        {
            Helper.ElementClick(PageObject_EventDetails.GoToEventDetails());
        }
        public static void Click_ReviewOrder()
        {
            Helper.ElementClick(PageObject_EventDetails.Click_ReviewOrder());
        }
        public static void OrderInformation_Contact(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_EventDetails.OrderInformation_Contact(),value);
        }
        public static void OrderInformation_PaymentMothod(string text)
        {
            Helper.ElementEnterText(PageObject_EventDetails.OrderInformation_PaymentMothod(),text);
        }
        public static void OrderInformation_ContinueButton()
        {
            Helper.ElementClick(PageObject_EventDetails.OrderInformation_ContinueButton());
        }
        public static void ReviewOrder_SaveButton()
        {
            Helper.ElementClick(PageObject_EventDetails.ReviewOrder_SaveButton());
        }
        public static void MyOrders_Button()
        {
            Helper.ElementClick(PageObject_EventDetails.MyOrders_Button());
        }
        public static void Click_AddMenuModal_CancelButton()
        {
            Helper.ElementClick(PageObject_EventDetails.Click_AddMenuModal_CancelButton());
        }
        public static void ReviewOrder_SendOrder_SendButton()
        {
            Helper.ElementClick(PageObject_EventDetails.ReviewOrder_SendOrder_SendButton());
        }
        public static void SendOrdersMyOrders_Button()
        {
            Helper.ElementClick(PageObject_EventDetails.SendOrdersMyOrders_Button());
        }
        public static void AddMenu(string Menu_Name)
        {
            Click_AddMenu();
            Logger.WriteDebugMessage("Add Menu modal should get open");
            AddMenuModal_CancelButton();
            Logger.WriteDebugMessage("Navigate to Event Page");
            Click_AddMenu();
            MenuName(Menu_Name);
            Logger.WriteDebugMessage(Menu_Name +" got Selected");
            GoToMenu_Button();
            Logger.WriteDebugMessage("User should navigate to menu page");
            Helper.ScrollToElement(PageObject_EventDetails.AddMenu_AddClick());
            Helper.AddDelay(5000);
            Logger.WriteDebugMessage("Adding Menu Page is Displaying");
            AddMenu_AddClick();
            Logger.WriteDebugMessage("Add menu modal should get displayed on the page");
            Click_AddMenuModal_CancelButton();
            AddMenu_AddClick();
            Logger.WriteDebugMessage("Adding overlay should get displayed on the page");
            AddMenuModal_AddButton();
            Logger.WriteDebugMessage("Goto Event Overlay should be Displayed");
            GoToEventDetails();
            Logger.WriteDebugMessage("Event details page should get displayed");

        }
   
        public static void ReviewOrder(string Contact,string Payment_Method)
        {
            Click_ReviewOrder();
            Logger.WriteDebugMessage("order information page should get displayed");
            OrderInformation_Contact(Contact);
            try
            {
                OrderInformation_PaymentMothod(Payment_Method);
            }
            catch(Exception e)
            {
                Logger.WriteDebugMessage("Payment Method Textbox is not selected" +e);
            }
            OrderInformation_ContinueButton();
            ReviewOrder_SaveButton();
            MyOrders_Button();
            Logger.WriteDebugMessage("My Orders page should get displayed");
        }
        public static void ReviewOrder_SendOrder(string Contact, string Payment_Method)
        {
            Click_ReviewOrder();
            Logger.WriteDebugMessage("order information page should get displayed");
            OrderInformation_Contact(Contact);
            try
            { 
                OrderInformation_PaymentMothod(Payment_Method);
            }
            catch
            {
                Logger.WriteDebugMessage("Payment Method is not available");
            }
            Logger.WriteDebugMessage("Details Entered in to Order Information Page");
            OrderInformation_ContinueButton();
            Helper.ScrollToElement(PageObject_EventDetails.ReviewOrder_SendButton());
            Logger.WriteDebugMessage("Order Save or Send Button Displayed");
            ReviewOrder_SendButton();
            ReviewOrder_SendOrder_SendButton();
            Logger.WriteDebugMessage("Order Send Successfully");
            SendOrdersMyOrders_Button();
            Logger.WriteDebugMessage("My Orders page should get displayed");
        }
        public static void ReviewOrder_SaveOrder(string Contact, string Payment_Method)
        {
            Click_ReviewOrder();
            Logger.WriteDebugMessage("order information page should get displayed");
            OrderInformation_Contact(Contact);
            try
            {
                OrderInformation_PaymentMothod(Payment_Method);
            }
            catch
            {
                Logger.WriteDebugMessage("Payment Method is not available");
            }
            Logger.WriteDebugMessage("Details Entered in to Order Information Page");
            OrderInformation_ContinueButton();
            Helper.ScrollToElement(PageObject_EventDetails.ReviewOrder_SaveButton());
            Logger.WriteDebugMessage("Order Save or Send Button Displayed");
            ReviewOrder_SaveButton();
            Logger.WriteDebugMessage("Order Save Successfully");
            MyOrders_Button();
            Logger.WriteDebugMessage("My Orders page should get displayed");
        }
        public static void ReviewOrder_SendButton()
        {
            Helper.ElementClick(PageObject_EventDetails.ReviewOrder_SendButton());
        }

        public static void Click_Comment_Function()
        {
            Helper.ElementClick(PageObject_EventDetails.Click_Comment_Function());
        }
        public static void Enter_Function_Comments(string comment)
        {
            Helper.ElementEnterText(PageObject_EventDetails.Enter_Function_Comments(), comment);
        }
        public static void Click_AddComment()
        {
            Helper.ElementClick(PageObject_EventDetails.Click_AddComment());
        }
        public static void Click_Edit_Function()
        {
            Helper.ElementClick(PageObject_EventDetails.Click_Edit_Function());
        }
        public static void Click_Copy_Function()
        {
            Helper.ElementClick(PageObject_EventDetails.Click_Copy_Function());
        }
        public static void Enter_CloneFunctionName(string functionname)
        {
            Helper.ElementEnterText(PageObject_EventDetails.Enter_CloneFunctionName(), functionname);
        }
        public static void Select_CloneFunctionDate(string function_date)
        {
            Helper.ElementSelectFromDropDown(PageObject_EventDetails.Select_CloneFunctionDate(), function_date);
        }
        public static void Click_CloneSaveFunction()
        {
            Helper.ElementClick(PageObject_EventDetails.Click_CloneSaveFunction());
        }
        public static void Click_Delete_Function()
        {
            Helper.ElementClick(PageObject_EventDetails.Click_Delete_Function());
        }
        public static void Click_DeleteFunctionbutton()
        {
            Helper.ElementClick(PageObject_EventDetails.Click_DeleteFunctionbutton());
        }
        public static void Click_Edit_Menu()
        {
            Helper.ElementClick(PageObject_EventDetails.Click_Edit_Menu());
        }
        public static void Enter_EditMenu_Menu_Quantity(string str)
        {
            Helper.ElementEnterText(PageObject_EventDetails.Enter_EditMenu_Menu_Quantity(), str);
        }
        public static void Enter_EditMenu_Menu_Special_Request(string str)
        {
            Helper.ElementEnterText(PageObject_EventDetails.Enter_EditMenu_Menu_Special_Request(), str);
        }
        public static void Click_EditMenu_Menu_Save_Button()
        {
            Helper.ElementClick(PageObject_EventDetails.Click_EditMenu_Menu_Save_Button());
        }
        public static void Click_Copy_Menu()
        {
            Helper.ElementClick(PageObject_EventDetails.Click_Copy_Menu());
        }
        public static void Select_CopyMenu_FunctionList(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_EventDetails.Select_CopyMenu_FunctionList(), value);
        }
        public static void Click_CopyMenu_FunctionList_Save()
        {
            Helper.ElementClick(PageObject_EventDetails.Click_CopyMenu_FunctionList_Save());
        }
        public static void Click_Delete_Menu()
        {
            Helper.ElementClick(PageObject_EventDetails.Click_Delete_Menu());
        }
        public static void Click_Delete_Menu_Button()
        {
            Helper.ElementClick(PageObject_EventDetails.Click_Delete_Menu_Button());
        }
        public static void Function_Add_Comments(string comments)
        {
            Click_Comment_Function();
            Logger.WriteDebugMessage("Function Add Comment Overlay got Opened");
            Enter_Function_Comments(comments);
            Logger.WriteDebugMessage("Function Comments Added Successfully");
            Click_AddComment();
            Helper.ScrollToText(comments);
            Helper.VerifyTextOnPageAndHighLight(comments);
            Helper.DynamicScrollToText(Helper.Driver, comments);
            Logger.WriteDebugMessage("Function Comments got Added Successfully");
        }

        public static void Function_Edit_Function(string functionName, string noOfGuest, string functionRoom, string functionType, string setupstyle)
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_EventDetails.Click_Edit_Function());
            Click_Edit_Function();
            Logger.WriteDebugMessage("Edit Function Overlay got Opened");
            FunctionName(functionName);
            NumberOfGuests(noOfGuest);
            FunctionRoom(functionRoom);
            FunctionType(functionType);
            SetupStyle(setupstyle);
            Logger.WriteDebugMessage("All the Details for Functions are entered correctly");
            SaveButton();
            Helper.VerifyTextOnPageAndHighLight(functionName);
            Helper.VerifyTextOnPageAndHighLight(noOfGuest);
            Helper.VerifyTextOnPageAndHighLight(functionRoom);
            Helper.VerifyTextOnPageAndHighLight(functionType);
            Helper.VerifyTextOnPageAndHighLight(setupstyle);
            Logger.WriteDebugMessage("Function should get save and displayed on the page" + functionName);
        }

        public static void Menu_Edit_Menu(string quantity,string specialrequest)
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_EventDetails.Click_Edit_Menu());
            Click_Edit_Menu();
            Logger.WriteDebugMessage("Edit Menu Overlay should get open");
            Enter_EditMenu_Menu_Quantity(quantity);
            Enter_EditMenu_Menu_Special_Request(specialrequest);
            Logger.WriteDebugMessage("All the Details are Entered correctly");
            Click_EditMenu_Menu_Save_Button();
            Helper.VerifyTextOnPageAndHighLight(quantity);
            Helper.VerifyTextOnPageAndHighLight(specialrequest);
            Helper.DynamicScroll(Helper.Driver, PageObject_EventDetails.Click_Edit_Menu());
            Logger.WriteDebugMessage("Menu Edited Successfully");
        }

        public static void Menu_Copy_menu(string functionname)
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_EventDetails.Click_Copy_Menu());
            Click_Copy_Menu();
            Logger.WriteDebugMessage("Copy Menu Overlay should get Opened");
            Select_CopyMenu_FunctionList(functionname);
            Logger.WriteDebugMessage("All the Details are Entered correctly");
            Click_CopyMenu_FunctionList_Save();
            Helper.VerifyTextOnPageAndHighLight(functionname);
            Helper.DynamicScrollToText(Helper.Driver, functionname);
            Logger.WriteDebugMessage("Menu Copied Successfully");
        }
        public static void Menu_Delete_Menu()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_EventDetails.Click_Delete_Menu());
            Click_Delete_Menu();
            Logger.WriteDebugMessage("Delete Menu Pop-up got Displayed");
            Click_Delete_Menu_Button();
            if (Helper.IsWebElementRemoved(PageObject_EventDetails.Click_Delete_Menu_Button()))
               Assert.Fail("Menu Item is not deleted");
            else
                Logger.WriteDebugMessage("Menu Item got Deleted");


        }
        public static void Function_Copy_Function(string functionName, string functionDate)
        {
            Click_Copy_Function();
            Logger.WriteDebugMessage("Copy Function Overlay Got Displayed");
            Enter_CloneFunctionName(functionName);
            Select_CloneFunctionDate(functionDate);
            Logger.WriteDebugMessage("Entered all Details on Clone Function Overlay");
            Click_CloneSaveFunction();
            Helper.VerifyTextOnPageAndHighLight(functionName);
            Helper.DynamicScrollToText(Helper.Driver, functionName);
            Logger.WriteDebugMessage(functionName +" Function got cloned successfully");
            
        }

        public static void Function_Delete_Function(string functionName)
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_EventDetails.Click_Delete_Function());
            Click_Delete_Function();
            Logger.WriteDebugMessage("Delete Function Overlay got Displayed");
            Click_DeleteFunctionbutton();
            Helper.AddDelay(5000);
            if (Helper.IsElementRemoved(functionName))
            {
                Assert.Fail(functionName + " Is not Deleted");
            }
            else
                Logger.WriteDebugMessage(functionName + " is deleted from page");


        }

        
    }
}
