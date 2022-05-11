using OpenQA.Selenium;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.Admin;

namespace eProposal.AppModule.Admin
{
    internal class AdminEProposal
    {
        public static void Click_Link_SetupModuleSettings()
        {
            Helper.ElementClick(PageObject_AdminEProposal.Link_SetupModuleSettings());
        }

        public static void Click_Link_SetupTemplates()
        {
            Helper.ElementClick(PageObject_AdminEProposal.Link_SetupTemplates());
        }

        public static void Click_Link_NavigationAndContent()
        {
            Helper.ElementClick(PageObject_AdminEProposal.Link_NavigationAndContent());
        }

        public static void Click_Link_Paragraphs()
        {
            Helper.ElementClick(PageObject_AdminEProposal.Link_Paragraphs());
        }

        public static void Click_Link_RoomEventBlockParagraph()
        {
            Helper.ElementClick(PageObject_AdminEProposal.Link_RoomEventBlockParagraph());
        }

        public static void Click_Link_PropertyGMLetter()
        {
            Helper.ElementClick(PageObject_AdminEProposal.Link_PropertyGMLetter());
        }

        public static void Click_Link_ImageCaptionStyles()
        {
            Helper.ElementClick(PageObject_AdminEProposal.Link_ImageCaptionStyles());
        }

        public static void Click_Link_MediaSetup()
        {
            Helper.ElementClick(PageObject_AdminEProposal.Link_MediaSetup());
        }

        public static void Click_Link_HeaderGallery()
        {
            Helper.ElementClick(PageObject_AdminEProposal.Link_HeaderGallery());
        }

        /// <summary>
        ///     This method will check which modules are "Active" and make note of their "DisplayName", 
        ///     if there is no display name, it will assign the "Module" name.
        ///     08/10 Marc : Re-wrote this entire method.
        /// </summary>
        /// <returns>string of value</returns>
        public static string[] Assign_DisplayNames()
        {
            var data = new string[3];
            for (var i = 2; i < 5; i++)
            {
                var id = "//span[@id='ctl00_ctl00_MainContent_PageContent_ModuleSettingsGridView_ctl0" + i +
                         "_lblDisplayName']";
                var element = CommonMethod.Driver.FindElement(By.XPath(id));
                var j = i - 2;
                data[j] = element.GetAttribute("innerHTML");
            }
            return data;
        }
    }
}