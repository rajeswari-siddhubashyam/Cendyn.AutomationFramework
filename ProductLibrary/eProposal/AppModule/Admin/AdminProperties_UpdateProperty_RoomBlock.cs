using BaseUtility.Utility;
using eProposal.PageObject.Admin;

namespace eProposal.AppModule.UI
{
    internal class AdminProperties_UpdateProperty_RoomBlock : Helper
    {
        public static void Click_RadioButton_RoomOnWelcome_On()
        {
            Helper.ElementClick(PageObject_AdminProperties_UpdateProperty_RoomBlock.RadioButton_RoomOnWelcome_On());
        }

        public static void Click_RadioButton_RoomOnWelcome_DefaultChecked_On()
        {
            Helper.ElementClick(PageObject_AdminProperties_UpdateProperty_RoomBlock
                .RadioButton_RoomOnWelcome_DefaultChecked_On());
        }

        public static void Click_RadioButton_RoomOnWelcome_ReadOnly_On()
        {
            Helper.ElementClick(PageObject_AdminProperties_UpdateProperty_RoomBlock
                .RadioButton_RoomOnWelcome_ReadOnly_On());
        }

        public static void Click_RadioButton_RoomOnWelcome_Off()
        {
            Helper.ElementClick(PageObject_AdminProperties_UpdateProperty_RoomBlock.RadioButton_RoomOnWelcome_Off());
        }

        public static void Click_RadioButton_RoomOnWelcome_DefaultChecked_Off()
        {
            Helper.ElementClick(PageObject_AdminProperties_UpdateProperty_RoomBlock
                .RadioButton_RoomOnWelcome_DefaultChecked_Off());
        }

        public static void Click_RadioButton_RoomOnWelcome_ReadOnly_Off()
        {
            Helper.ElementClick(PageObject_AdminProperties_UpdateProperty_RoomBlock
                .RadioButton_RoomOnWelcome_ReadOnly_Off());
        }

        public static void Click_Button_Submit()
        {
            Helper.ElementClick(PageObject_AdminProperties_UpdateProperty_RoomBlock.Button_Submit());
        }
    }
}