using System;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.UI;
using OpenQA.Selenium;
using InfoMessageLogger;

namespace eProposal.AppModule.UI
{
    internal class Settings_StoredContent : Helper
    {
        public static void Click_Link_eProposal()
        {
            ElementClick(PageObject_Settings_StoredContent.Link_eProposal());
        }

        public static void Click_Link_eCard()
        {
            ElementClick(PageObject_Settings_StoredContent.Link_eCard());
        }

        public static void Click_Button_AddNew()
        {
            ElementClick(PageObject_Settings_StoredContent.Button_AddNew());
        }

        public static void Click_Link_FirstStoredContent_Edit()
        {
            ElementClick(PageObject_Settings_StoredContent.Link_FirstStoredContent_Edit());
        }

        public static void Click_Link_FirstStoredContent_Delete()
        {
            ElementClick(PageObject_Settings_StoredContent.Link_FirstStoredContent_Delete());
        }

        public static void SelectFromDropDown_DropDown_SelectModule(string text)
        {
            ElementSelectFromDropDown(PageObject_Settings_StoredContent.DropDown_SelectModule(), text);
        }

        public static void SelectFromDropDown_DropDown_SelectLanguage(string text)
        {
            ElementSelectFromDropDown(PageObject_Settings_StoredContent.DropDown_SelectLanguage(), text);
        }

        /// <summary>
        ///     This method will count the amount of stored content
        /// </summary>
        /// <returns>The total number of stored content.</returns>
        public static int CountContent()
        {
            var count = 0;

            try
            {
                for (var i = 1; i < 10; i++)
                    if (CommonMethod.Driver
                        .FindElement(By.XPath(
                            "//a[@id='ctl00_ctl00_MainContent_MainContent_rptParaType_ctl00_rptParagraphs_ctl0" + i +
                            "_lbtnParaName']"))
                        .Displayed)
                        count++;
            }
            catch (Exception)
            {
            }
            return count;
        }

        /// <summary>
        ///     This method will return the content of the stored content from the Stored Content page.
        /// </summary>
        /// <param name="contentNumber">Which stored content order number (first content = 1, second content = 2, etc)</param>
        public static string GetContent(int contentNumber)
        {
            var content = "";
            //The ids on the page are in multiples of 2.
            var contentPosition = contentNumber * 2;
            var contentHeader = contentPosition - 1;

            try
            {
                //Make sure the content is "Expanded"
                if (!CommonMethod.Driver.FindElement(By.XPath("//li[@id='ui-id-" + contentPosition + "']")).Displayed)
                    CommonMethod.Driver.FindElement(
                            By.XPath("//li[@id='ui-id-" + contentHeader + "']"))
                        .Click();
                AddDelay(1500);
                content = CommonMethod.Driver
                    .FindElement(By.XPath(
                        "//li[@id='ui-id-" + contentPosition + "']")).Text;
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Unable to return the content in position " + contentNumber);
                throw;
            }


            return content;
        }

        /// <summary>
        ///     This method will return the content title of the stored content from the Stored Content page.
        /// </summary>
        /// <param name="contentNumber">Which stored content order number (first content = 1, second content = 2, etc)</param>
        public static string GetContentTitle(int contentNumber)
        {
            var title = "";

            try
            {
                title = CommonMethod.Driver
                    .FindElement(By.XPath(
                        "//a[@id='ctl00_ctl00_MainContent_MainContent_rptParaType_ctl00_rptParagraphs_ctl0" +
                        contentNumber + "_lbtnParaName']")).Text;
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Unable to return the content in position " + contentNumber);
                throw;
            }

            return title;
        }

        /// <summary>
        ///     This method will check if there is stored content saved.
        /// </summary>
        /// <returns>True = Stored content is displayed. False = if no stored content is displayed.</returns>
        public static bool IsThereStoredContent()
        {
            if (CommonMethod.Driver
                .FindElement(By.XPath(
                    "//a[@id='ctl00_ctl00_MainContent_MainContent_rptParaType_ctl00_rptParagraphs_ctl01_lbtnParaName']"))
                .Displayed)
                return true;

            return false;
        }
    }
}