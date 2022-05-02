using System;
using System.Collections.Generic;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.UI;
using InfoMessageLogger;

namespace eProposal.AppModule.UI
{
    internal class Reports : Helper
    {
        public static void Click_Link_ToDate()
        {
            ElementClick(PageObject_Reports.Reports_Link_ToDate());
        }

        public static void Click_Link_ByYear()
        {
            ElementClick(PageObject_Reports.Reports_Link_ByYear());
        }

        public static void Click_Link_ByDateRange()
        {
            ElementClick(PageObject_Reports.Reports_Link_ByDateRange());
        }

        public static void Click_Link_ByUser()
        {
            ElementClick(PageObject_Reports.Reports_Link_ByUser());
        }

        public static void Click_Link_PerClient()
        {
            ElementClick(PageObject_Reports.Reports_Link_PerClient());
        }

        public static void SelectModule(string text)
        {
            ElementSelectFromDropDown(PageObject_Reports.Reports_Dropdown_SelectModule(), text);
        }

        public static void ProposalStatus(string text)
        {
            ElementSelectFromDropDown(PageObject_Reports.Reports_Dropdown_ProposalStatus(), text);
        }

        public static void UserStatus(string text)
        {
            ElementSelectFromDropDown(PageObject_Reports.Reports_Dropdown_UserStatus(), text);
        }

        public static void Click_Button_Submit()
        {
            ElementClick(PageObject_Reports.Reports_Button_Submit());
        }

        public static void SelectYear(string text)
        {
            ElementSelectFromDropDown(PageObject_Reports.Reports_Dropdown_Year(), text);
        }

        public static void Click_DatePicker_StartDate()
        {
            ElementClick(PageObject_Reports.Reports_DatePicker_StartDate());
        }

        public static void Click_Date(string text)
        {
            ElementClick(PageObject_Reports.Reports_Link_Date(text));
        }

        public static void Click_DatePicker_EndDate()
        {
            ElementClick(PageObject_Reports.Reports_DatePicker_EndDate());
        }

        public static void Select_Datepicker_Month(string text)
        {
            ElementSelectFromDropDown(PageObject_Reports.Reports_Dropdown_DatepickerMonth(), text);
        }

        public static void Select_Datepicker_Year(string text)
        {
            ElementSelectFromDropDown(PageObject_Reports.Reports_Dropdown_DatepickerYear(), text);
        }

        public static void SelectUsername(string text)
        {
            ElementSelectFromDropDown(PageObject_Reports.Reports_Dropdown_Username(), text);
        }

        public static void Click_RadioButton_Company()
        {
            ElementClick(PageObject_Reports.Reports_RadioButton_Company());
        }

        public static void Click_RadioButton_Lastname()
        {
            ElementClick(PageObject_Reports.Reports_RadioButton_Lastname());
        }
    }
}