using System;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.Admin;
using OpenQA.Selenium;
using InfoMessageLogger;



namespace eProposal.AppModule.Admin
{
    internal class AdminNavigation : Helper
    {
        public static void Click_Button_Home()
        {
            ElementClick(PageObject_AdminNavigation.Button_Home());
        }

        public static void Click_Button_Properties()
        {
            ElementClick(PageObject_AdminNavigation.Button_Properties());
        }

        public static void Click_Button_eProposal()
        {
            ElementClick(PageObject_AdminNavigation.Button_eProposal());
        }

        public static void Click_Button_eCard()
        {
            ElementClick(PageObject_AdminNavigation.Button_eCard());
        }

        public static void Click_Button_Users()
        {
            ElementClick(PageObject_AdminNavigation.Button_Users());
        }

        public static void Click_Button_Clients()
        {
            ElementClick(PageObject_AdminNavigation.Button_Clients());
        }

        public static void Click_Button_Brand()
        {
            ElementClick(PageObject_AdminNavigation.Button_Brand());
        }

        public static void Click_Button_Global()
        {
            ElementClick(PageObject_AdminNavigation.Button_Global());
        }

        public static void Click_Link_Search()
        {
            ElementClick(PageObject_AdminNavigation.Link_Search());
        }

        public static void Click_Link_ClearSearch()
        {
            ElementClick(PageObject_AdminNavigation.Link_ClearSearch());
        }

        public static void Click_Tab_Search_Regular()
        {
            ElementClick(PageObject_AdminNavigation.Tab_Search_Regular());
        }

        public static void Click_Tab_Search_SSO()
        {
            ElementClick(PageObject_AdminNavigation.Tab_Search_SSO());
        }

        public static void Click_Tab_Search_CVB()
        {
            ElementClick(PageObject_AdminNavigation.Tab_Search_CVB());
        }

        public static void Click_Tab_Search_Master()
        {
            ElementClick(PageObject_AdminNavigation.Tab_Search_Master());
        }

        public static void Click_Tab_Search_Cluster()
        {
            ElementClick(PageObject_AdminNavigation.Tab_Search_Cluster());
        }

        public static void Click_Tab_Search_GSO()
        {
            ElementClick(PageObject_AdminNavigation.Tab_Search_GSO());
        }

        public static void Click_Tab_Search_Convert()
        {
            ElementClick(PageObject_AdminNavigation.Tab_Search_Convert());
        }

        public static void Click_Tab_Search_Upgrade()
        {
            ElementClick(PageObject_AdminNavigation.Tab_Search_Upgrade());
        }

        public static void Click_RadioButton_Search_ExternalLinkID()
        {
            ElementClick(PageObject_AdminNavigation.RadioButton_Search_ExternalLinkID());
        }

        public static void Click_Button_Search_Search()
        {
            ElementClick(PageObject_AdminNavigation.Button_Search_Search());
        }

        public static void Click_Button_Search_ClearSearch()
        {
            ElementClick(PageObject_AdminNavigation.Button_Search_ClearSearch());
        }

        public static void Click_Button_Search_Close()
        {
            ElementClick(PageObject_AdminNavigation.Button_Search_Close());
        }

        public static void EnterText_Text_PropertyDD(string text)
        {
            ElementEnterText(PageObject_AdminNavigation.Text_PropertyDD(), text);
        }

        public static void EnterText_Text_Search_ID(string text)
        {
            ElementEnterText(PageObject_AdminNavigation.Text_Search_ID(), text);
        }

        public static void EnterText_Text_Search_BrandDD(string text)
        {
            ElementEnterText(PageObject_AdminNavigation.Text_Search_BrandDD(), text);
        }

        public static void EnterText_Text_Name(string text)
        {
            ElementEnterText(PageObject_AdminNavigation.Text_Name(), text);
        }

        public static void SelectFromDropDown_DropDown_Search_Brand(string text)
        {
            ElementSelectFromDropDown(PageObject_AdminNavigation.DropDown_Search_Brand(), text);
        }

        /// <summary>
        ///     This method will search for a regular type property then verify it is displayed in the drop down.
        /// </summary>
        /// <param name="property">Regular property to search for</param>
        public static void SearchForRegularProperty(string property)
        {
            try
            {
                if (!PageObject_AdminNavigation.Text_Search_ID().Displayed)
                    Click_Link_Search();

                EnterText_Text_Name(property);
                PageObject_AdminNavigation.Text_Name().SendKeys(Keys.Down);
                PageObject_AdminNavigation.Text_Name().SendKeys(Keys.Enter);
                Click_Button_Search_Search();
                AddDelay(5000);
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Unable to search for the property: " + property);
                throw;
            }
        }
    }
}