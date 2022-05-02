using BaseUtility.Utility;
using eProposal.PageObject.Admin;

namespace eProposal.AppModule.Admin
{
    internal class AdminProperties : Helper
    {
        public static void Click_PropertyDropDown_Button()
        {
            ElementClick(PageObject_AdminProperties.AdminProperties_PropertyDropDown_Button());
        }

        public static void Click_Tab_Actions()
        {
            ElementClick(PageObject_AdminProperties.Tab_Actions());
        }

        public static void Click_Tab_RoomBlock()
        {
            ElementClick(PageObject_AdminProperties.Tab_RoomBlock());
        }

        public static void EnterText_Text_Name(string text)
        {
            ElementEnterText(PageObject_AdminProperties.AdminProperties_PropertyDropDown_Text(), text);
        }


        public static void Click_Tab_Features()
        {
            ElementClick(PageObject_AdminProperties.AdminProperties_Button_Features());
        }


        /// <summary>
        ///     This methood will select the test property from the drop down.
        /// </summary>
        public static void SelectProperty(string property)
        {
            AddDelay(1500);
            Click_PropertyDropDown_Button();
            ElementSelectFromDropDownDownAndClick(
                PageObject_AdminProperties.AdminProperties_PropertyDropDown_Text(), property);
            AddDelay(10000);
        }

        /// <summary>
        ///     This method will enter the Features tab iFrame
        /// </summary>
        public static void iFrame_Enter()
        {
            EnterFrame("iframe_property");
        }

        /// <summary>
        ///     This method will exit the Features tab iFrame
        /// </summary>
        public static void iFrame_Exit()
        {
            ExitFrame();
        }
    }
}