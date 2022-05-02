using System;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.Admin;
using InfoMessageLogger;

namespace eProposal.AppModule.Admin
{
    internal class AdminClients_Search
    {
        public static void Click_Tab_Global()
        {
            Helper.ElementClick(PageObject_AdminClients_Search.Tab_Global());
        }

        public static void Click_Tab_Property()
        {
            Helper.ElementClick(PageObject_AdminClients_Search.Tab_Property());
        }

        public static void Click_Button_Search()
        {
            Helper.ElementClick(PageObject_AdminClients_Search.Button_Search());
        }

        public static void Click_Tab_Chain()
        {
            Helper.ElementClick(PageObject_AdminClients_Search.Tab_Chain());
        }

        public static void Click_Tab_ChainBrand()
        {
            Helper.ElementClick(PageObject_AdminClients_Search.Tab_ChainBrand());
        }

        public static void Click_Tab_Independent()
        {
            Helper.ElementClick(PageObject_AdminClients_Search.Tab_Independent());
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

        public static void Click_Button_FirstClient_Edit()
        {
            Helper.ElementClick(PageObject_AdminClients_Search.Button_FirstClient_Edit());
        }

        public static void EnterText_Text_Search(string text)
        {
            Helper.ElementEnterText(PageObject_AdminClients_Search.Text_Search(), text);
        }

        public static void SelectFromDropDown_DropDown_SearchByName(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_AdminClients_Search.DropDown_SearchByName(), text);
        }

        public static void SelectFromDropDown_DropDown_SearchByWith(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_AdminClients_Search.DropDown_SearchByWith(), text);
        }

        public static void SelectFromDropDown_DropDown_Top_GoToPage(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_AdminClients_Search.DropDown_Top_GoToPage(), text);
        }

        public static void SelectFromDropDown_DropDown_Bottom_GoToPage(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_AdminClients_Search.DropDown_Bottom_GoToPage(), text);
        }

        /// <summary>
        ///     This method will search for a client by their first name
        /// </summary>
        /// <param name="firstName">First Name of the client</param>
        public static void SearchClientFirstName(string firstName)
        {
            //Select the search critera in the drop downs
            SelectFromDropDown_DropDown_SearchByName("First Name");
            SelectFromDropDown_DropDown_SearchByWith("Equals");

            //Enter the client's first name
            EnterText_Text_Search(firstName);
            Click_Button_Search();

            //Clear the field
            PageObject_AdminClients_Search.Text_Search().Clear();

            try
            {
                if (Helper.VerifyTextOnPage(firstName))
                    Logger.WriteInfoMessage("The searched client displayed in the search results.");
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteDebugMessage("The client did not display in the search results.");
                throw;
            }
        }

        /// <summary>
        ///     This method will search for a client by their first name
        /// </summary>
        /// <param name="lastName">Last Name of the client</param>
        public static void SearchClientLastName(string lastName)
        {
            //Select the search critera in the drop downs
            SelectFromDropDown_DropDown_SearchByName("Last Name");
            SelectFromDropDown_DropDown_SearchByWith("Equals");

            //Enter the client's first name
            EnterText_Text_Search(lastName);
            Click_Button_Search();

            //Clear the field
            PageObject_AdminClients_Search.Text_Search().Clear();

            try
            {
                if (Helper.VerifyTextOnPage(lastName))
                    Logger.WriteInfoMessage("The searched client displayed in the search results.");
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteDebugMessage("The client did not display in the search results.");
                throw;
            }
        }

        /// <summary>
        ///     This method will search for a client by their first name
        /// </summary>
        /// <param name="email">Last Name of the client</param>
        public static void SearchClientEmail(string email)
        {
            //Select the search critera in the drop downs
            SelectFromDropDown_DropDown_SearchByName("Email");
            SelectFromDropDown_DropDown_SearchByWith("Equals");

            //Enter the client's first name
            EnterText_Text_Search(email);
            Click_Button_Search();

            //Clear the field
            PageObject_AdminClients_Search.Text_Search().Clear();

            try
            {
                if (Helper.VerifyTextOnPage(email))
                    Logger.WriteInfoMessage("The searched client displayed in the search results.");
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteDebugMessage("The client did not display in the search results.");
                throw;
            }
        }
    }
}