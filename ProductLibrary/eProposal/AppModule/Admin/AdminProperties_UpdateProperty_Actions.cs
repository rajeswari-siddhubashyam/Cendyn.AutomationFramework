using BaseUtility.Utility;
using eProposal.PageObject.Admin;


namespace eProposal.AppModule.Admin
{
    internal class AdminProperties_UpdateProperty_Actions : Helper
    {
        public static void Click_RadioButton_MergeProperty_On()
        {
            Helper.ElementClick(PageObject_AdminProperties_UpdateProperty_Actions.RadioButton_MergeProperty_On());
        }

        public static void Click_RadioButton_MergeProperty_Off()
        {
            Helper.ElementClick(PageObject_AdminProperties_UpdateProperty_Actions.RadioButton_MergeProperty_Off());
        }

        public static void Click_RadioButton_DisableProperty_On()
        {
            Helper.ElementClick(PageObject_AdminProperties_UpdateProperty_Actions.RadioButton_DisableProperty_On());
        }

        public static void Click_RadioButton_DisableProperty_Off()
        {
            Helper.ElementClick(PageObject_AdminProperties_UpdateProperty_Actions.RadioButton_DisableProperty_Off());
        }

        public static void Click_RadioButton_MultiLanguageProperty_On()
        {
            Helper.ElementClick(
                PageObject_AdminProperties_UpdateProperty_Actions.RadioButton_MultiLanguageProperty_On());
        }

        public static void Click_RadioButton_MultiLanguageProperty_Off()
        {
            Helper.ElementClick(
                PageObject_AdminProperties_UpdateProperty_Actions.RadioButton_MultiLanguageProperty_Off());
        }

        public static void Click_Button_Update()
        {
            Helper.ElementClick(PageObject_AdminProperties_UpdateProperty_Actions.Button_Update());
        }
    }
}