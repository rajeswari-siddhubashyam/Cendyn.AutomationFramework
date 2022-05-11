using AMR_Agent.PageObject.UI;
using AMR_Agent.Utility;
using BaseUtility.Utility;
using InfoMessageLogger;

namespace AMR_Agent.AppModule.UI
{
    class AMRRewards : Utility.Setup
    {


        public static void AcceptPopup()
        {
            Logger.WriteDebugMessage("AMRewards Popup is displayed.");
            Time.AddDelay(2500);
            Helper.WaittillElementDisplay(PageObject_AMRewards.AMRRewardsEnrollMeCheckbox());
            Time.AddDelay(1500);
            PageObject_AMRewards.AMRRewardsPopupAccept().Click();
            Time.AddDelay(5000);
        }

    }
}
