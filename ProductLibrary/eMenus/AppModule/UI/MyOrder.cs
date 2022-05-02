using OpenQA.Selenium.Interactions;
using BaseUtility.Utility;
using eMenus.PageObject.UI;
using InfoMessageLogger;

using ObjectRepository = eMenus.Utility.ObjectRepository;

namespace eMenus.AppModule.UI
{
    public class MyOrder : eMenus.Utility.Setup
    {
        public static void Enter_EventName(string str)
        {
            Helper.ElementEnterText(PageObject_MyOrder.Enter_EventName(), str);
        }

        public static void Click_CreateOrderSave()
        {
            Helper.ElementClick(PageObject_MyOrder.Click_CreateOrder());
        }
        public static void Click_AddFunction()
        {
            Helper.ElementClick(PageObject_MyOrder.Click_AddFunction());
        }
        public static void Enter_FunctionName(string str)
        {
            Helper.ElementEnterText(PageObject_MyOrder.Enter_FunctionName(), str);
        }
        public static void Select_NoOfGuest(string str)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementClick(PageObject_MyOrder.Select_NoOfGuest());
            for (int i = 1; i <= int.Parse(str); i++)
            {
                action.SendKeys(OpenQA.Selenium.Keys.ArrowUp);
            }
            action.Build().Perform();
         }
        public static void Enter_FunctionRoom(string str)
        {
            Helper.ElementEnterText(PageObject_MyOrder.Enter_FunctionRoom(), str);
        }

        public static void Select_FunctionType(string str)
        {
            Helper.ElementSelectFromDropDown(PageObject_MyOrder.Select_FunctionType(), str);
        }
        public static void Select_SetupStype(string str)
        {
            Helper.ElementSelectFromDropDown(PageObject_MyOrder.Select_SetupType(), str);
        }
        public static void Click_CreateFunction()
        {
            Helper.ElementClick(PageObject_MyOrder.Click_CreateFunction());
        }

        public static void Click_AddMenu()
        {
            Helper.ElementClick(PageObject_MyOrder.Click_AddMenu());
        }
        public static void Select_Menu(string str)
        {
            Helper.ElementSelectFromDropDown(PageObject_MyOrder.Select_Menu(), str);

        }
        public static void Click_GoToMenu()
        {
            Helper.ElementClick(PageObject_MyOrder.GotoMenu());
        }
        public static void Click_AddMenuItem()
        {
            Helper.ElementClick(PageObject_MyOrder.AddMenuItem());
        }
        public static void Click_AddMenuItemNext()
        {
            Helper.ElementClick(PageObject_MyOrder.AddMenuItemNext());
        }
        public static void Click_AddMenuItemChoice()
        {
           Helper.ElementClick( PageObject_MyOrder.AddMenuChoice());
        }
        public static void Check_Choices()
        {
            PageObject_MyOrder.CheckChoice();
        }
        public static void Click_GoToEventDetails()
        {
            Helper.ElementClick(PageObject_MyOrder.Click_GoToEventDetails());
        }
        public static void Click_ReviewOrder()
        {
            Helper.ElementClick(PageObject_MyOrder.Click_ReviewOrder());
        }
        public static void Select_Event_Contact(string str)
        {
            Helper.ElementSelectFromDropDown(PageObject_MyOrder.Select_Event_Contact(), str);
        }

        public static void Enter_Event_Payment_Method(string str)
        {
            Helper.ElementEnterText(PageObject_MyOrder.Enter_Event_Payment_Method(), str);
        }
        public static string Get_CustomerFirstName()
        {
            return Helper.GetElementValue(PageObject_MyOrder.Customer_FirstName());
        }
        public static string Get_Customer_LastName()
        {
            return Helper.GetElementValue(PageObject_MyOrder.Customer_LastName());
        }
        public static string Get_Customer_Address()
        {
            return Helper.GetElementValue(PageObject_MyOrder.Customer_Address());
        }
        public static string Get_Customer_Address2()
        {
            return Helper.GetElementValue(PageObject_MyOrder.Customer_Address2());
        }
        public static string Get_Customer_City()
        {
            return Helper.GetElementValue(PageObject_MyOrder.Customer_City());
        }
        public static string Get_Customer_State()
        {
            return Helper.GetElementValue(PageObject_MyOrder.Customer_State());
        }
        public static string Get_Customer_PostalCode()
        {
            return Helper.GetElementValue(PageObject_MyOrder.Customer_PostalCode());
        }
        public static string Get_Customer_Country()
        {
            return Helper.GetText(PageObject_MyOrder.Customer_Country());
        }
        public static string Get_Customer_Phone()
        {
            return Helper.GetElementValue(PageObject_MyOrder.Customer_Phone());
        }
        public static string Get_Customer_Email()
        {
            return Helper.GetElementValue(PageObject_MyOrder.Customer_Email());
        }
        public static string Get_Customer_Company()
        {
            return Helper.GetElementValue(PageObject_MyOrder.Customer_Company());
        }
        public static void Click_Continue_Button()
        {
            Helper.ElementClick(PageObject_MyOrder.Click_Continue());
        }
        public static void Click_Save_Order()
        {
            Helper.ElementClick(PageObject_MyOrder.Click_Save_Order());
        }
        public static void Click_MyOrder()
        {
            Helper.ElementClick(PageObject_MyOrder.Click_MyOrder());
        }
        public static void Enter_Search_Filter(string str)
        {
            Helper.ElementEnterText(PageObject_MyOrder.Search_Filter(), str);
        }
        public static void Click_EditOrder()
        {
            Helper.ElementClick(PageObject_MyOrder.Click_EditOrder());
        }
        public static void Click_SendOrder()
        {
            Helper.ElementClick(PageObject_MyOrder.Click_SendOrder());
        }
        public static void Click_SendOrder_Confirmation()
        {
            Helper.ElementClick(PageObject_MyOrder.Click_SendOrder_Confirmation());
        }
        public static void Click_CreateNewOrder()
        {
            Helper.ElementClick(PageObject_Navigation.Create_NewOrder());
        }
        public static void Enter_Event_Start_Date(string date)
        {
            Helper.ElementEnterTextUsingJQuery(PageObject_MyOrder.Select_EventStartDate(), date);
        }
        public static void Enter_Event_End_Date(string date)
        {
            Helper.ElementEnterTextUsingJQuery(PageObject_MyOrder.Select_EventEndDate(), date);
        }
        public static void CreateOrder(string eventName, string startdate, string enddate)
        {
            Click_CreateNewOrder();
            Logger.WriteDebugMessage("Create New Order Pop Up Displayed");
            Enter_EventName(eventName);
            Enter_Event_Start_Date(startdate);
            Enter_Event_End_Date(enddate);
            Logger.WriteDebugMessage("Entered All details in Create Event Overlay ");
            Click_CreateOrderSave();
            Logger.WriteDebugMessage("Order Created Successfully"); ;
        }
        public static void Add_Function(string function_name, string noOfGuest, string functionRoom, string functionType, string setup_Style)
        {
            Click_AddFunction();
            Logger.WriteDebugMessage("Add Function Overlay is Displayed");
            Enter_FunctionName(function_name);
            Select_NoOfGuest(noOfGuest);
            Enter_FunctionRoom(functionRoom);
            Select_FunctionType(functionType);
            Select_SetupStype(setup_Style);
            Logger.WriteDebugMessage("All add function details are entered successfully");
            Click_CreateFunction();
            VerifyTextOnPageAndHighLight(function_name);
            Logger.WriteDebugMessage("Function Added Successfully"); ;

        }
        public static void Add_Menu(string menuname)
        {
            Click_AddMenu();
            Logger.WriteDebugMessage("Add Menu Popup is Displayed");
            Select_Menu(menuname);
            Logger.WriteDebugMessage(menuname+" is Selected");
            Click_GoToMenu();
            Logger.WriteDebugMessage("Navigated to Select Menu");
        }

        public static void SelectMenu()
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_MyOrder.AddMenuItem());
            Logger.WriteDebugMessage("Add Menu Button is Displayed");
            Click_AddMenuItem();
            Logger.WriteDebugMessage("Select Menu Item Popup Displayed");
            ScrollToElement(PageObject_MyOrder.AddMenuChoice());
            Click_AddMenuItemChoice();
            ElementWait(PageObject_MyOrder.Click_GoToEventDetails(), 60);
            Logger.WriteDebugMessage("Menu Selected and Added Successfully");
            Click_GoToEventDetails();
            Logger.WriteDebugMessage("Landed on Event Detail Page");
        }

        public static void VerifyCustomerDetails(string firstName, string lastName, string address, string address2, string city, string state, string postalcode, string phone, string company)
        {
            Navigation.VerifyDetails(Get_CustomerFirstName(), firstName);
            Navigation.VerifyDetails(Get_Customer_LastName(), lastName);
            Navigation.VerifyDetails(Get_Customer_Address(), address);
            Navigation.VerifyDetails(Get_Customer_Address2(), address2);
            Navigation.VerifyDetails(Get_Customer_City(), city);
            Navigation.VerifyDetails(Get_Customer_State(), state);
            Navigation.VerifyDetails(Get_Customer_PostalCode(), postalcode);
            Navigation.VerifyDetails(Get_Customer_Phone(), phone);
            Navigation.VerifyDetails(Get_Customer_Company(), company);

        }

        public static void SubmitOrder(string contact)
        {
            Select_Event_Contact(contact);
            Logger.WriteDebugMessage(contact + " Contact is Selected");
            Enter_Event_Payment_Method("Cash");
            Click_Continue_Button();
            ElementWait(PageObject_MyOrder.Click_SendOrder(), 60);
            Logger.WriteDebugMessage("Landed on Order Review Page");
        }

        public static void ReviewInCatchall(string email)
        {

            VerifyTextOnPageAndHighLight(email);
            Logger.WriteDebugMessage("Email sent to "+email+" address");
            ScrollToElement(PageObject_Email.CatchAll_SupportEmail());
            Logger.WriteDebugMessage("All the Details are Present in Save Order Confirmation Email in catchall for ="+email);
        }
        public static void ReviewNameDetail(string firstnamme, string lastname)
        {
            VerifyTextOnPageAndHighLight(firstnamme);
            VerifyTextOnPageAndHighLight(lastname);
            Logger.WriteDebugMessage("First Name = " + firstnamme+ " and Last Name = "+lastname+" is Present");
        }
        public static void SendOrder(string eventname, string contact, string orderconfirmation)
        {
            ElementWait(PageObject_MyOrder.Click_MyOrder(), 60);
            Click_MyOrder();
            Logger.WriteDebugMessage("Navigated to My Order Page");
            ElementWait(PageObject_MyOrder.Search_Filter(), 60);
            Enter_Search_Filter(eventname);
            Logger.WriteDebugMessage(eventname+" Event Found on Search Event Page");
            Click_EditOrder();
            Logger.WriteDebugMessage("Navigated to Event Details Page");
            Click_ReviewOrder();
            Logger.WriteDebugMessage("Landed on Order Information Page");
            SubmitOrder(contact);
            Click_SendOrder();
            Logger.WriteDebugMessage("Order Send Confirmation Page is Displayed");
            Click_SendOrder_Confirmation();
            VerifyTextOnPageAndHighLight(orderconfirmation);
            Logger.WriteDebugMessage("Order Send Successfully");
        }
    }
}
