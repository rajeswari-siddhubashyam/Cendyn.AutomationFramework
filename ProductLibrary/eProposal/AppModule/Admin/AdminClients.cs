using BaseUtility.Utility;
using eProposal.PageObject.Admin;

namespace eProposal.AppModule.Admin
{
    internal class AdminClients
    {
        public static void Click_Link_ShowAll()
        {
            Helper.ElementClick(PageObject_AdminClients.Link_ShowAll());
        }

        public static void Click_Link_AddNew()
        {
            Helper.ElementClick(PageObject_AdminClients.Link_AddNew());
        }

        public static void Click_Link_Search()
        {
            Helper.ElementClick(PageObject_AdminClients.Link_Search());
        }

        public static void Click_Button_Top_FirstPage()
        {
            Helper.ElementClick(PageObject_AdminClients_Search.Button_Top_FirstPage());
        }

        public static void Click_Button_Top_PreviousPage()
        {
            Helper.ElementClick(PageObject_AdminClients_Search.Button_Top_PreviousPage());
        }

        public static void Click_Button_Top_NextPage()
        {
            Helper.ElementClick(PageObject_AdminClients_Search.Button_Top_NextPage());
        }

        public static void Click_Button_Top_LastPage()
        {
            Helper.ElementClick(PageObject_AdminClients_Search.Button_Top_LastPage());
        }

        public static void Click_Button_Bottom_FirstPage()
        {
            Helper.ElementClick(PageObject_AdminClients_Search.Button_Bottom_FirstPage());
        }

        public static void Click_Button_Bottom_PreviousPage()
        {
            Helper.ElementClick(PageObject_AdminClients_Search.Button_Bottom_PreviousPage());
        }

        public static void Click_Button_Bottom_NextPage()
        {
            Helper.ElementClick(PageObject_AdminClients_Search.Button_Bottom_NextPage());
        }

        public static void Click_Button_Bottom_LastPage()
        {
            Helper.ElementClick(PageObject_AdminClients_Search.Button_Bottom_LastPage());
        }

        public static void SelectFromDropDown_DropDown_Top_GoToPage(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_AdminClients_Search.DropDown_Top_GoToPage(), text);
        }

        public static void SelectFromDropDown_DropDown_Bottom_GoToPage(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_AdminClients_Search.DropDown_Bottom_GoToPage(), text);
        }
    }
}