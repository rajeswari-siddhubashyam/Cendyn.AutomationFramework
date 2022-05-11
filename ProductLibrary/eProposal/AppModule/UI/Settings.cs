using System;
using System.Collections.Generic;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.UI;
using InfoMessageLogger;

namespace eProposal.AppModule.UI
{
    internal class Settings
    {
        public static void Click_Tab_PropertyInfo()
        {
            Helper.ElementClick(PageObject_Settings.Tab_PropertyInfo());
        }

        public static void Click_Tab_General()
        {
            Helper.ElementClick(PageObject_Settings.Tab_General());
        }

        public static void Click_Tab_SeniorStaffInfo()
        {
            Helper.ElementClick(PageObject_Settings.Tab_SeniorStaffInfo());
        }

        public static void Click_Tab_StoredContent()
        {
            Helper.ElementClick(PageObject_Settings.Tab_StoredContent());
        }

        public static void Click_Tab_RoomEventBlockComments()
        {
            Helper.ElementClick(PageObject_Settings.Tab_RoomEventBlockComments());
        }

        public static void Click_Tab_SpecialOffers()
        {
            Helper.ElementClick(PageObject_Settings.Tab_SpecialOffers());
        }

        public static void Click_Tab_CustomizePDF()
        {
            Helper.ElementClick(PageObject_Settings.Tab_CustomizePDF());
        }

        public static void Click_Tab_SocialMedia()
        {
            Helper.ElementClick(PageObject_Settings.Tab_SocialMedia());
        }


        /// <summary>
        ///     Methdo to verify value populated in Module dropdown under Senior staff info tab
        /// </summary>
        public static void VerifyModuleDropdown(string[] value)
        {
            var options = PageObject_Settings.Dropdown_Module().Options;
            foreach (var option in options)
            {
                var i = 0;
                var data = option.Text;
                if (value[i].Equals(data))
                {
                    Logger.WriteInfoMessage("All the modules that include a Senior Staff Information id displayed.");
                    i++;
                }
                else
                {
                    i++;
                }
            }
        }

        /// <summary>
        ///     Methdo to verify value populated in Module dropdown under customizr report tab.
        /// </summary>
        public static void VerifyModuleDropdownCustomizePDFByList(List<String> value)
        {
            var options = PageObject_Settings.Customize_Dropdown_Module().Options;
            var i = 0;
            foreach (var option in options)
            {
                var data = option.Text;
                if (value[i].Equals(data))
                {
                    Logger.WriteInfoMessage("The module " + value[i] + " that include a Senior Staff Information is displayed.");
                    i++;
                }
                else
                {
                    i++;
                }
            }
        }


        /// <summary>
        ///     Methdo to verify value populated in Special Offers Module dropdown
        /// </summary>
        public static void VerifySpecialOffersModuleDropdown(string[] value)
        {
            var options = PageObject_Settings.SpecialOffer_Dropdown_Module().Options;
            foreach (var option in options)
            {
                var i = 0;
                var data = option.Text;
                if (value[i].Equals(data))
                {
                    Logger.WriteInfoMessage("All the modules that include a Senior Staff Information id displayed.");
                    i++;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}