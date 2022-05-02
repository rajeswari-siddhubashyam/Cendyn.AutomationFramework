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

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_234025]
        public static void TC_234161()
        {
            if (testCategory == "PostDeployment")
            {
                CompanyName = "Hotel Origami";
            }
            else
            {
                CompanyName = companyNameByTestCase;
            }
            
            ProfileCustData CustData = new ProfileCustData();
            //SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "CompanyName");
            Navigation.MenuNavigation("Profile");
            Profile.SelectSubClient(CompanyName);
            SqlWarehouseQuery.GetProfileData(CustData, CompanyName, 1, "");
            string[] eachGroupNum = Regex.Split(CustData.GroupID, ",");
            foreach (string groupID in eachGroupNum)
            {
                Logger.WriteInfoMessage("Executing for Group Number: " + groupID + ".");
                SqlWarehouseQuery.GetProfileData(CustData, CompanyName, 2, groupID);
                string[] eachCustomerNum = Regex.Split(CustData.CustomerIDs, ",");
                foreach (string custID in eachCustomerNum)
                {
                    Logger.WriteInfoMessage("This group contains " + eachCustomerNum.Length + " customers: " + CustData.CustomerIDs);
                    Logger.WriteInfoMessage("Executing for Customer ID :" + custID);
                    PageLoadWait(120, "Profile.mvc/Profile");
                    ElementWait(Driver.FindElement(By.XPath("//input[@id='search']")), 120);
                    ElementWait(PageObject_Profile.Profile_SearchGuestsSearch(), 120);
                    Profile.SelectSearchGuestsSearchBy("Customer ID");
                    Profile.InsertTextSearchGuestsSearchFor(custID);
                    Logger.WriteDebugMessage("Searching for an customer for a CustomerID: " + custID + " in profile search page.");
                    Profile.ClickGlobalOpenProfile(custID, CustData);
                    Logger.WriteDebugMessage("Landed on Profile Page.");
                    AddDelay(8000);

                    /* Verify Customer Profile Information*/
                    if (custID == CustData.PrimaryCustomer)
                    {
                        ScrollToElement(Driver.FindElement(By.XPath("//a[contains(@href, '#profile-div" + custID + "')]")));
                    }
                    else if (custID != CustData.PrimaryCustomer)
                    {
                        ScrollToElement(Driver.FindElement(By.XPath("//a[contains(@href, '#profile-div" + CustData.PrimaryCustomer + "')]")));
                    }


                    Profile.VerifyGlobalProfileData(custID, CustData);

                    /* Reservation Details Check */

                    ScrollDownUsingJavaScript(Driver, -1000);
                    if (custID == CustData.PrimaryCustomer)
                    {
                        ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '#stays-div" + custID + "')]")));
                        ScrollToElement(Driver.FindElement(By.XPath("//a[contains(@href, '#stays-div" + custID + "')]")));
                    }
                    else if (custID != CustData.PrimaryCustomer)
                    {
                        ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '#stays-div" + CustData.PrimaryCustomer + "')]")));
                        ScrollToElement(Driver.FindElement(By.XPath("//a[contains(@href, '#stays-div" + CustData.PrimaryCustomer + "')]")));
                    }

                    //ManageCampaign.WaitForReady();
                    //div[@id='staysRegular1120670']//following::td[contains(text(), '23586038')]
                    ElementWait(Driver.FindElement(By.XPath("//img[contains(@title, 'Stay Report')]")), 60);
                    Logger.WriteDebugMessage("Landed on Stays Tab");
                    string[] eachResNum = Regex.Split(CustData.ReservationNumber, ",");
                    Logger.WriteInfoMessage("Expected Result: Found " + eachResNum.Length + " reservations for the customer " + custID + "\n Reservation Numbers:" + CustData.ReservationNumber);
                    if (eachResNum.Length > 20)
                    {
                        if (custID == CustData.PrimaryCustomer)
                        {
                            ScrollToElement(Driver.FindElement(By.XPath("//*[@id='staysRegularPager" + custID + "_center']/table/tbody/tr/td[8]/select")));
                            ElementClick(Driver.FindElement(By.XPath("//*[@id='staysRegularPager" + custID + "_center']/table/tbody/tr/td[8]/select/option[4]")));
                        }
                        else if (custID != CustData.PrimaryCustomer)
                        {
                            ScrollToElement(Driver.FindElement(By.XPath("//*[@id='staysRegularPager" + CustData.PrimaryCustomer + "_center']/table/tbody/tr/td[8]/select")));
                            ElementClick(Driver.FindElement(By.XPath("//*[@id='staysRegularPager" + CustData.PrimaryCustomer + "_center']/table/tbody/tr/td[8]/select/option[4]")));
                        }
                        Regex regMatch = new Regex(@"^.*?(?=,)");
                        Match match = regMatch.Match(CustData.ReservationNumber);
                        ElementWait(PageObject_Profile.Profile_StayTabReservationPresent(CustData.PrimaryCustomer, match.ToString()), 120);
                        foreach (string resNum in eachResNum)
                        {
                            if (VerifyTextOnPage(resNum))
                            {
                                Logger.WriteInfoMessage("Actual Result: ReservationNumber - " + resNum + " found on StayTab");
                            }
                            else
                            {
                                Assert.Fail("Did not found Reservation Number: " + resNum + " on screen.");
                            }
                        }
                        Logger.WriteDebugMessage("Found all reservations for the customer + " + custID + " as per expected.");
                    }
                    else
                    {
                        foreach (string resNum in eachResNum)
                        {
                            if (VerifyTextOnPage(resNum))
                            {
                                Logger.WriteInfoMessage("Actual Result: ReservationNumber - " + resNum + " found on StayTab");
                            }
                            else
                            {
                                Assert.Fail("Did not found Reservation Number: " + resNum + " on screen.");
                            }
                        }
                        Logger.WriteDebugMessage("Found all reservations for the customer " + custID + " as per expected.");
                    }
                    /* Unsubscribe Details Check */
                    ScrollDownUsingJavaScript(Driver, -1000);
                    if (custID == CustData.PrimaryCustomer)
                    {
                        ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '#subsriptions-div" + custID + "')]")));
                        ScrollToElement(Driver.FindElement(By.XPath("//a[contains(@href, '#subsriptions-div" + custID + "')]")));
                    }
                    else if (custID != CustData.PrimaryCustomer)
                    {
                        ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '#subsriptions-div" + CustData.PrimaryCustomer + "')]")));
                        ScrollToElement(Driver.FindElement(By.XPath("//a[contains(@href, '#subsriptions-div" + CustData.PrimaryCustomer + "')]")));
                    }
                    Logger.WriteDebugMessage("Landed on Subscription Tab");
                    string isSubscribeStatus = "";
                    if (CustData.EmailStatus.Contains("Unsubscribed"))
                    {
                        isSubscribeStatus = "Is Unsubscribed";
                    }
                    if (CustData.EmailStatus.Contains("Valid"))
                    {
                        isSubscribeStatus = "Is Subscribed";
                    }
                    if (VerifyTextOnPage(isSubscribeStatus))
                    {
                        Logger.WriteInfoMessage("Expected Result for Subscription is " + CustData.EmailStatus);
                        Logger.WriteDebugMessage("Actual result found subscription as " + CustData.EmailStatus);
                    }
                    AddDelay(10000);
                    ReloadPage();
                }
            }
        }
        #endregion[TP_234025]
    }
}
