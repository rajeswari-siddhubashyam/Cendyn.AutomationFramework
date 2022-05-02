using MarketingAutomation.AppModule.UI;
using MarketingAutomation.Entity;
using MarketingAutomation.Utility;
using BaseUtility.Utility;
using Queries = MarketingAutomation.Utility.Queries;
using System.Collections.Generic;
using InfoMessageLogger;
using TestData;
using OpenQA.Selenium;
using System;
using NUnit.Framework;
using MarketingAutomation.PageObject.UI;

namespace MarketingAutomation.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region[TP_320503]

        public static void TC_320504()
        {
            if (TestCaseId == Constants.TC_320504)
            {
                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Validate the toggle is available switch between  Card and Grid view
                ManageCampaign.Toggle_switch();

                //verify the default view
                ManageCampaign.VerifyDefaultView();
                Helper.VerifyTextNOTOnPage("ID");
                Logger.WriteDebugMessage("Campaign Displayed in Card View");

                //Click on list view
                ManageCampaign.List_View();
                Helper.VerifyTextOnPageAndHighLight("ID");
                Logger.WriteDebugMessage("Campaign Displayed in List View");
                
            }
        }

        public static void TC_320505()
        {
            if (TestCaseId == Constants.TC_320505)
            {

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Validate the toggle is available 
                ManageCampaign.Toggle_switch_Marketing_Automated();

                //Check the default selection 
                if (PageObject_ManageCampaign.Marketing_Toggle_Button().Enabled)
                {
                    Logger.WriteDebugMessage("By default Marketing toggle button is selected");
                }
                else
                    Assert.Fail("By default Marketing toggle button is NOT selected");

                //Click on Automated
                ManageCampaign.Automated_Toggle_Button();
            }
        }

        public static void TC_320506()
        {
            if (TestCaseId == Constants.TC_320506)
            {

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on List view
                ManageCampaign.List_View();

                //Verify Campaign Name is trucated with '…' and hover over displays the full text for the Campaign
                CreateCampaign.VerifyFullTextTruncatedTitleDesignCard();
            }
        }

        public static void TC_320507()
        {
            if (TestCaseId == Constants.TC_320507)
            {

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on List view
                ManageCampaign.List_View();

                //Validate If the text is long then the Name should have hover over and ...
                CreateCampaign.VerifyFullTextTruncatedAudienceDesignCard();
            }
        }

        public static void TC_320508()
        {
            if (TestCaseId == Constants.TC_320508)
            {

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on List view
                ManageCampaign.List_View();

                //Validate If the text is long then the Name should have hover over and ...
                ManageCampaign.Click_CampaignName();
                
            }
        }

        public static void TC_320509()
        {
            if (TestCaseId == Constants.TC_320509)
            {

                //Navigate to Marketing Automation and log in as valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on List view
                ManageCampaign.List_View();

                //Validate the columns in grid
                ManageCampaign.Verify_ManageCampaign_gridColumns();

            }
        }

        public static void TC_320510()
        {
            if (TestCaseId == Constants.TC_320510)
            {
                //Variables declaration and object creation
                Campaign data = new Campaign();

                //Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on List view
                ManageCampaign.List_View();

                //User lands on Campaign Selection page;
                string cName = GetText(PageObject_ManageCampaign.Hover_ListView_CampaignName());
                Logger.WriteDebugMessage("Campaign name is" + cName);

                //Get connection string
                Queries.GetCampaignsIDBasedOnManageCampaignName(data, cName);
                string campID = GetText(PageObject_ManageCampaign.Campaign_ID());
                Assert.IsTrue(campID.Equals(data.CampaignId), "CampaignID is present and matched with DB");
                Logger.WriteDebugMessage("ID displayed As" + campID);
            }
        }

        public static void TC_320511()
        {
            if (TestCaseId == Constants.TC_320511)
            {
                //Variables declaration and object creation
                Campaign data = new Campaign();

                //Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on List view
                ManageCampaign.List_View();

                //User lands on Campaign Selection page;
                string cName = GetText(PageObject_ManageCampaign.Hover_ListView_CampaignName());
                Logger.WriteDebugMessage("Campaign name is" + cName);

                //Get connection string
                Queries.GetCampaignsNameandCompaireManageCampaignName(data, cName);
                string Campaign_Name = GetText(PageObject_ManageCampaign.Hover_ListView_CampaignName());
                Assert.IsTrue(Campaign_Name.Equals(data.CampaignName), "campaign Name displayed");
            }
        }

        public static void TC_320512()
        {
            if (TestCaseId == Constants.TC_320512)
            {
                //Variables declaration and object creation
                Campaign data = new Campaign();

                //Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on List view
                ManageCampaign.List_View();
                ManageCampaign.Click_Approved_from_listGrid();

                //Validate the Status column
                string cID = GetText(PageObject_ManageCampaign.Campaign_ID());
                Logger.WriteDebugMessage("Campaign name is" + cID);

                //Get connection string

                Queries.GetStatusColumn(data, Convert.ToInt32(cID));
                string Campaign_Status = GetText(PageObject_ManageCampaign.ManageCapaign_Status());
                Assert.IsTrue(Campaign_Status.Contains(data.Status), "campaign status displyed and matched with Database");
            }
        }

        public static void TC_320513()
        {
            if (TestCaseId == Constants.TC_320513)
            {
                //Variables declaration and object creation
                Campaign data = new Campaign();

                //Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on List view
                ManageCampaign.List_View();
                ManageCampaign.Click_Approved_from_listGrid();

                //User lands on Campaign Selection page;
                string cAUDIENCE = GetText(PageObject_ManageCampaign.Hover_ListView_CampaignAudience());
                Logger.WriteDebugMessage("Audence is" + cAUDIENCE);

                //Get connection string
                Queries.GetAudienceName(data, cAUDIENCE);
                Assert.IsTrue(cAUDIENCE.Equals(data.AudienceName), "Audience Name displayed");
            }
        }

        public static void TC_320514()
        {
            if (TestCaseId == Constants.TC_320514)
            {
                //Variables declaration and object creation
                Campaign data = new Campaign();

                //Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on List view
                ManageCampaign.List_View();

                //User lands on Campaign Selection page;
                //Validate the Updated By column
                String UpdatedBY = GetText(PageObject_ManageCampaign.ManageCapaign_Update_By());
                Helper.VerifyElementOnPage(PageObject_ManageCampaign.ManageCapaign_Update_By());
                Logger.WriteDebugMessage("Name of user that updated the Campaign is " + UpdatedBY);
            }
        }

        public static void TC_320515()
        {
            if (TestCaseId == Constants.TC_320515)
            {
                //Variables declaration and object creation
                Campaign data = new Campaign();

                //Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Click on List view
                ManageCampaign.List_View();

                //User lands on Campaign Selection page;
                //Validate the Updated On column
                String UpdatedON = GetText(PageObject_ManageCampaign.ManageCapaign_Updated_ON());
                Logger.WriteDebugMessage("Campaign is Updated ON " + UpdatedON);
    
            }
        }
        #endregion[TP_320503]
    }
}
