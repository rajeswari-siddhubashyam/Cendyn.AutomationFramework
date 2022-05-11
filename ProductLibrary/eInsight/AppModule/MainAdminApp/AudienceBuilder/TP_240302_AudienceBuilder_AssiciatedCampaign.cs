using System;
using eInsight.Utility;
using eInsight.AppModule.UI;
using Common;
using Constants = eInsight.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using SqlWarehouse;
using OpenQA.Selenium;
using NUnit.Framework;
using eInsight.AppModule.UI;
using eInsight.PageObject.UI;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {

        private static string AudienceIDs = "";
        #region[TP_240302]
        public static void TC_261225()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            AudienceIDs = SqlWarehouseQuery.GetAudienceIds(CompanyName, "Scheduled");

            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");
            string[] eachAudienceIds = Regex.Split(AudienceIDs, ",");
            foreach (string eachaudienceID in eachAudienceIds)
            {
                SqlWarehouseQuery.GetAudienceProjects(builderData, CompanyName, eachaudienceID);
                audienceName = builderData.AudienceName;
                //Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")).SendKeys(audienceName);
                ElementClick(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")));
                ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
                //ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
                AudienceBuilder.Click_SearchButton();
                AudienceBuilder.Click_ABGrid_LastSaved();
                WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
                Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
                IWebElement ele = null;
                try
                {
                    ElementWait(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(),'" + audienceName + "')]")), 60);
                    ele = Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(),'" + audienceName + "')]"));
                }
                catch (Exception) { ElementWait(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[@title='" + audienceName + "']")), 60);
                    ele = Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[@title='" + audienceName + "']")); }
                
                if (ele.Displayed)
                {
                    ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
                    ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, 'summary')]")), 120);

                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().Frame(0);
                    if (Driver.FindElement(By.XPath("//a[contains(@href, 'summary')]")).GetAttribute("class").Contains("active"))
                    {
                        Logger.WriteDebugMessage("Landed on Details Page for audience name - " + audienceName);
                        ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'associatedCampaigns')]")));
                        if (Driver.FindElement(By.XPath("//a[contains(@href, 'associatedCampaigns')]")).GetAttribute("class").Contains("active"))
                        {
                            Logger.WriteDebugMessage("Landed Associated Campaign Page for audience name - " + audienceName);
                            string[] pIds = Regex.Split(builderData.ParentProjectIDs, ",");
                            foreach (string eachprojectID in pIds)
                            {
                                SqlWarehouseQuery.GetAudienceProjects(builderData, CompanyName, eachaudienceID, eachprojectID);
                                //
                                List<string> associatedCampaignDetails = AudienceBuilder.GetAssociatedCampaignDetails(eachprojectID);
                                Helper.ScrollToText(builderData.ParentProjectID);
                                Helper.ScrollDown();
                                if (VerifyTextOnPage(builderData.ParentProjectID) && builderData.CampaignName == associatedCampaignDetails[0] && builderData.OldStatus == associatedCampaignDetails[1])
                                {
                                    Logger.WriteDebugMessage("Found Associated Campaign - " + "\n" + "ParentProjectID - " + builderData.ParentProjectID + "CampaignName - " + builderData.CampaignName + "Campaign Status - " + builderData.OldStatus); // "InsertDate - " + builderData.DateSubmitted) ;
                                }
                                else
                                {
                                    Assert.Fail("One of the data did not match.");
                                }
                            }
                        }
                    }
                    //Driver.SwitchTo().DefaultContent();
                    //ScrollToElement(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));
                    //ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));
                    //Driver.SwitchTo().DefaultContent();                            
                }
            }
        }
        public static void TC_261830()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            AudienceIDs = SqlWarehouseQuery.GetAudienceIds(CompanyName, "Scheduled");

            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");
            string[] eachAudienceIds = Regex.Split(AudienceIDs, ",");
            eachAudienceIds = Regex.Split(AudienceIDs, ",");
            foreach (string eachaudienceID in eachAudienceIds)
            {
                SqlWarehouseQuery.GetAudienceProjects(builderData, CompanyName, eachaudienceID);
                audienceName = builderData.AudienceName;
                ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
                AudienceBuilder.Click_SearchButton();
                AudienceBuilder.Click_ABGrid_LastSaved();
                WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
                Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
                ElementWait(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]")), 60);
                if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
                {
                    ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
                    ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, 'summary')]")), 120);

                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().Frame(0);
                    if (Driver.FindElement(By.XPath("//a[contains(@href, 'summary')]")).GetAttribute("class").Contains("active"))
                    {
                        Logger.WriteDebugMessage("Landed Detail Page for audience name - " + audienceName);
                        ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'associatedCampaigns')]")));
                        Logger.WriteDebugMessage("Landed Associated Campaign Page for audience name - " + audienceName);
                        if (Driver.FindElement(By.XPath("//a[contains(@href, 'associatedCampaigns')]")).GetAttribute("class").Contains("active"))
                        {
                            string[] pIds = Regex.Split(builderData.ParentProjectIDs, ",");
                            foreach (string eachprojectID in pIds)
                            {
                                Logger.WriteDebugMessage("ProjectID - " + eachprojectID + " visible on Associated Campaign Page. Clicking on ProjectID - " + eachprojectID);
                                ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), '" + eachprojectID + "')]")));
                                if (VerifyTextOnPage(eachprojectID))
                                {
                                    Logger.WriteDebugMessage("Landed on Manage Campaign of " + eachprojectID);
                                    Driver.SwitchTo().DefaultContent();
                                    Driver.Navigate().Back();
                                    Driver.SwitchTo().DefaultContent();
                                    Driver.SwitchTo().Frame(0);
                                    ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, 'associatedCampaigns')]")), 120);
                                    ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'associatedCampaigns')]")));
                                }
                                else
                                {
                                    Assert.Fail("Did not landed on Manage Campaign Page for " + eachprojectID);
                                }
                            }
                            //ScrollToElement(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));
                            //Driver.SwitchTo().DefaultContent();
                        }
                    }
                }
            }
        }
        public static void TC_261833()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            AudienceIDs = SqlWarehouseQuery.GetAudienceIds(CompanyName, "Scheduled");
            string message = "";
            string gridAudience = "";

            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");
            string[] eachAudienceIds = Regex.Split(AudienceIDs, ",");
            eachAudienceIds = Regex.Split(AudienceIDs, ",");
            foreach (string eachaudienceID in eachAudienceIds)
            {
                SqlWarehouseQuery.GetAudienceProjects(builderData, CompanyName, eachaudienceID);
                audienceName = builderData.AudienceName;
                ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
                AudienceBuilder.Click_SearchButton();
                AudienceBuilder.Click_ABGrid_LastSaved();
                WaitUntilElementNotVisible(By.XPath("//*[contains(text(), 'Loading...')]"), 120);
                Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
                if (audienceName.Length > 30)
                {
                    gridAudience = audienceName.Substring(0, 29);
                }
                else
                {
                    gridAudience = audienceName;
                }
                ElementWait(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + gridAudience + "')]")), 60);
                if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + gridAudience + "')]"))))
                {
                    ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
                    ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, 'summary')]")), 120);
                    Logger.WriteDebugMessage("Landed Details Page for audience name - " + audienceName);

                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().Frame(0);
                    if (Driver.FindElement(By.XPath("//a[contains(@href, 'summary')]")).GetAttribute("class").Contains("active"))
                    {
                        ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'associatedCampaigns')]")));
                        if (Driver.FindElement(By.XPath("//a[contains(@href, 'associatedCampaigns')]")).GetAttribute("class").Contains("active"))
                        {
                            Logger.WriteDebugMessage("Landed Associated Campaign Page for audience name - " + audienceName);
                            string[] pIds = Regex.Split(builderData.ParentProjectIDs, ",");
                            foreach (string eachprojectID in pIds)
                            {
                                SqlWarehouseQuery.GetAudienceProjects(builderData, CompanyName, eachaudienceID, eachprojectID);

                                //string createdDate = Convert.ToDateTime(builderData.DateSubmitted).ToString("M/d/yyyy hh:mm:ss tt");
                                string createdDate = Convert.ToDateTime(builderData.DateSubmitted).ToString("M/d/yyyy hh:mm");
                                string modifiedDate = Convert.ToDateTime(builderData.ModifiedOn).ToString("M/d/yyyy hh:mm:ss tt");
                                string emailType = builderData.eventtype.Replace("Email Type -", "").Trim();
                                string oldStatus = builderData.OldStatus;

                                //updating statuses to reflect how they display on old Campaign Details page
                                if (oldStatus == "AwaitingApproval")
                                    oldStatus = "Awaiting Approval";
                                else if (oldStatus == "AwaitingDeliverabilityReport")
                                    oldStatus = "In Testing";

                                Helper.ScrollDown();
                                ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), '" + eachprojectID + "')]")));
                                if (VerifyTextOnPage(eachprojectID))
                                {
                                    Logger.WriteDebugMessage("Landed on Manage Campaign of " + eachprojectID);
                                    Driver.SwitchTo().DefaultContent();
                                    string getCampaignStatus = Driver.FindElement(By.XPath("//span[@class='status-description']")).Text.Trim();
                                    if (getCampaignStatus.Contains("Scheduled"))
                                    {
                                        Regex regex = new Regex(@"[.(].*");
                                        getCampaignStatus = regex.Replace(getCampaignStatus, "").Trim();
                                    }

                                    string getProjectID = Driver.FindElement(By.XPath("(//dt[contains(text(), 'Project ID #')]/following::dd)[1]")).Text.Trim();
                                    string getCampaignCreatedDate = Driver.FindElement(By.XPath("(//dt[contains(text(), 'Created On')]/following::dd)[1]")).Text.Trim();
                                    string getCampaignName = Driver.FindElement(By.XPath("(//b[contains(text(), 'Campaign Name')]/following::b)[1]")).Text.Trim();
                                    //string getCampaignModifiedDate = Driver.FindElement(By.XPath("(//dt[contains(text(), 'Last Run On:')]/following::dd)[1]")).Text.Trim();
                                    string getCampaignEmailType = Driver.FindElement(By.XPath("(//dt[contains(text(), 'Email Type')]/following::dd)[1]")).Text.Trim();

                                    if ((getCampaignStatus == oldStatus) && (getProjectID == eachprojectID) && (getCampaignCreatedDate == builderData.DateSubmitted) && (getCampaignName == builderData.CampaignName) && (getCampaignEmailType == emailType))
                                    {
                                        Logger.WriteDebugMessage("\nCampaign Name - " + builderData.CampaignName +
                                        "\nProjectID - " + eachprojectID +
                                        "\nCampaign Status - " + builderData.OldStatus +
                                        "\nCampaign Type - " + emailType +
                                        "\nCreated Date - " + createdDate);
                                    }
                                    else
                                    {
                                        message = "Some of the Data did not match for ProjectID - " + eachprojectID;
                                        if ((getCampaignStatus != oldStatus))
                                        {
                                            message = message + "\n CampaignStatus :  " + "\n\t Actual Result - " + getCampaignStatus + "\n\t Expected Result - " + builderData.OldStatus + "\n";
                                        }
                                        if ((getProjectID != eachprojectID))
                                        {
                                            message = message + "\n ProjectID : " + "\n\t Actual Result - " + getProjectID + "\n\t Expected Result - " + eachprojectID + "\n";
                                        }
                                        if ((getCampaignCreatedDate != createdDate))
                                        {
                                            message = message + "\n Campaign Created Date - " + "\n\t Actual Result - " + getCampaignCreatedDate + "\n\t Expected Result - " + createdDate + "\n";
                                        }
                                        if ((getCampaignName != builderData.CampaignName))
                                        {
                                            message = message + "\n Campaign Name : " + "\n\t Actual Result - " + getCampaignName + "\n\t Expected Result - " + builderData.CampaignName + "\n";
                                        }
                                        if ((getCampaignEmailType != emailType))
                                        {
                                            message = message + "\n Campaign Email Type  : " + "\n\t Actual Result - " + getCampaignEmailType + "\n\t Expected Result - " + emailType + "\n";
                                        }

                                        Assert.Fail(message);
                                    }
                                    Driver.Navigate().Back();
                                    Driver.SwitchTo().DefaultContent();
                                    Driver.SwitchTo().Frame(0);
                                    ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, 'associatedCampaigns')]")), 120);
                                    ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'associatedCampaigns')]")));
                                }
                                else
                                {
                                    Assert.Fail("Did not landed on Manage Campaign Page for " + eachprojectID);
                                }
                            }
                            //ScrollToElement(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));
                            //Driver.SwitchTo().DefaultContent();
                        }
                    }
                }
            }
        }
        #endregion[TP_240302]

    }
}
