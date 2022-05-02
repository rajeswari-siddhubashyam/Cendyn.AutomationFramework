using AMR_Agent.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace AMR_Agent.PageObject.UI
{
    class PageObject_AMRewards : Setup
    {
        /*
        / These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
        */

        public static IWebElement AMRRewardsEnrollMeCheckbox()
        {
            ScanPage(Constants.ModuleAMRewards);
            return PageAction.Find_ElementId(ObjectRepository.AMRRewardsEnrollMeCheckbox);
        }
        public static IWebElement AMRRewardsPopupAccept()
        {
            ScanPage(Constants.ModuleAMRewards);
            return PageAction.Find_ElementId(ObjectRepository.AMRRewardsPopupAccept);
        }
        public static IWebElement AMRewards_PointsHistory()
        {
            ScanPage(Constants.ModuleAMRewards);
            return PageAction.Find_ElementId(ObjectRepository.AMRewardsPointsHistory);
        }
        public static IWebElement AMRewardsRulesAndRegulations()
        {
            ScanPage(Constants.ModuleAMRewards);
            return PageAction.Find_ElementId(ObjectRepository.AMRewardsRulesAndRegulations);
        }
        public static IWebElement AMRewards_TotalPointsAvailable()
        {
            ScanPage(Constants.ModuleAMRewards);
            return PageAction.Find_ElementId(ObjectRepository.AMRewardsTotalPointsAvailable);
        }
        public static IWebElement AMRewards_TotalPointsRedeemed()
        {
            ScanPage(Constants.ModuleAMRewards);
            return PageAction.Find_ElementId(ObjectRepository.AMRewardsTotalPointsRedeemed);
        }
        public static IWebElement AMRewards_TotalPointsExpiring()
        {
            ScanPage(Constants.ModuleAMRewards);
            return PageAction.Find_ElementId(ObjectRepository.AMRewardsTotalPointsExpiring);
        }

    }
}
