using BaseUtility.Utility;
using eProposal.AppModule.UI;
using eProposal.PageObject.Admin;
using eProposal.Utility;

namespace eProposal.AppModule.Admin
{
    /// <summary>
    ///     This class will log into admin and turn on/off the selected setting.
    /// </summary>
    internal class PreReqs : Helper
    {
        private static void NavigateAndLogIntoAdmin()
        {
            Driver.Navigate().GoToUrl(LegacyTestData.CommonAdminURL);
            AdminLogin.LogInCommon();
        }

        /// <param name="property">Property to turn the setting on.</param>
        private static void NavigateToPropertiesUpdateProperty(string property)
        {
            AdminNavigation.Click_Button_Properties();
            AdminNavigation.SearchForRegularProperty(property);
            AddDelay(2500);
        }

        #region[TP_84293]

        /// <summary>
        ///     This method will log into the Admin site and make sure the Use My Favorite Settings feature is turned on for the
        ///     property.
        /// </summary>
        public static void TC_120443(string property)
        {
            NavigateAndLogIntoAdmin();
            NavigateToPropertiesUpdateProperty(property);
            AdminProperties.Click_Tab_Features();
            AdminProperties_UpdateProperty_Features.TurnProposalFavoriteOn();
        }

        /// <summary>
        ///     This method will turn on the Room on Welcome setting with default sub setting also turned on.
        /// </summary>
        /// <param name="property"></param>
        public static void TC_120447(string property)
        {
            NavigateAndLogIntoAdmin();
            NavigateToPropertiesUpdateProperty(property);
            AdminProperties.Click_Tab_RoomBlock();
            AdminProperties.iFrame_Enter();

            //Switch the setting on
            AdminProperties_UpdateProperty_RoomBlock.Click_RadioButton_RoomOnWelcome_On();

            //Switch the sub settings to off.
            AdminProperties_UpdateProperty_RoomBlock.Click_RadioButton_RoomOnWelcome_DefaultChecked_Off();
            AdminProperties_UpdateProperty_RoomBlock.Click_RadioButton_RoomOnWelcome_ReadOnly_Off();

            //Submit
            AdminProperties_UpdateProperty_RoomBlock.Click_Button_Submit();

            AdminProperties.iFrame_Exit();
        }

        #endregion[TP_84293]
    }
}