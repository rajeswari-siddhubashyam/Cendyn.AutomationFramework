using BaseUtility.Utility;
using Common;
using MarketingAutomation.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingAutomation.AppModule.UI
{
    class ManageAudience : BaseUtility.AppModule.UI.ManageCampaign
    {

        public static void VerifyAudienceCampaignTab()
        {
            Assert.IsTrue(Helper.IsElementDisplayed(PageObject_CreateAudience.Audience_Details_Campaign_Tab()), "User is not landed on Template Summary page");
        }

        public static void ClickOnCampaignTabAndVerifyColumnHeader()
        {
            Helper.ElementClick(PageObject_CreateAudience.Audience_Details_Campaign_Tab());
            ManageCampaign.WaitToHideLoaderListView();
            IList<IWebElement> columnHeader = PageObject_CreateCampaign.Create_Audience_ListView_Column_Header_List();
            Assert.IsTrue(columnHeader.Count > 1, "Campaign tab is not displaying column");
        }

        /// <summary>
        /// Get audience name from the list in random manner
        /// </summary>
        /// <returns></returns>
        public static string GetAudienceName()
        {
            Random r = new Random();
            int index;
            IList<IWebElement> audienceNameList = PageObject_CreateAudience.Audience_Cards_Title();
            index = r.Next(0, audienceNameList.Count);
           return (Helper.GetText(audienceNameList[index]));
        }

        /// <summary>
        /// Verify audience name is showing in the list 
        /// </summary>
        /// <param name="audienceName"></param>
        public static void VerifyFilterAudienceInfoOnPage(string audienceName)
        {
            Helper.WaitForAjaxControls(50);
            int actCount = 0, expCount = 0;
            IList<IWebElement> audienceNameList = PageObject_CreateAudience.Audience_Cards_Title();
            
            for (int i = 0; i < audienceNameList.Count; i++)
            {
                if (!String.IsNullOrEmpty(audienceName))
                {
                    actCount = actCount + 1;
                    if (audienceNameList[i].Text.Equals(audienceName))
                        expCount = expCount + 1;
                }
            }
            Assert.IsTrue(actCount >= expCount, "Audience with details is not present in the filter result");
            Assert.IsTrue(expCount >= 1, "System is not displying result based on filter");
        }

        public static void VerifyAudienceListNameOrdersDesc()
        {
            IList<IWebElement> listOfSortData = null;
            Helper.WaitForAjaxControls(50);
            for (int i = 0; i < 7; i++){listOfSortData = PageObject_CreateAudience.Audience_Cards_Title(); }
            if (listOfSortData.Count > 1)
            {
                for (int i = 0; i < listOfSortData.Count - 1; i++)
                {
                    string name1 = listOfSortData[i].Text;
                    string name2 = listOfSortData[i + 1].Text;
                    int cmpVal = name1.CompareTo(name2);

                    if (cmpVal == 0) // The strings are the same.
                        Logger.WriteInfoMessage("Both strings have same value.");
                    else if (cmpVal < 0)
                        Assert.Fail($"Cmpaign is not in the {listOfSortData} name descending order");
                    else
                        Logger.WriteInfoMessage($"{name1} follows {name2}.");
                }
            }
        }
    }
}
