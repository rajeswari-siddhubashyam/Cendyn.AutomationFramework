using System;
using System.Collections.Generic;
using System.Linq;
using AutoIt;
using BaseUtility.Utility;
using InfoMessageLogger;
using Common;
using eInsight.PageObject.UI;
using NUnit.Framework;
using OpenQA.Selenium;
using SqlWarehouse;
using AutoIt;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Support.UI;
//using AutoItX3Lib;

namespace eInsight.AppModule.UI
{
    class Profile : Helper
    {

        /// <summary>
        /// This method will select a client from the Client drop down menu.
        /// Client is ParentCompany
        /// </summary>
        /// <param name="client"></param>
        public static void SelectClient(string client)
        {
            AddDelay(1500);
            PageObject_Profile.Profile_Client().Click();
            AddDelay(1000);
            PageObject_Profile.Profile_Client().SendKeys(client);
            AddDelay(10000);
            PageObject_Profile.Profile_Client().SendKeys(Keys.Enter);
            AddDelay(3000);

            Logger.WriteInfoMessage("Selected ParentCompany as - " + client);
        }
        /// <summary>
        /// This method will select a client from the Client drop down menu.
        /// Client is ParentCompany
        /// </summary>
        /// <param name="client"></param>
        public static void Legacy_SelectSubClient(string client)
        {
            AddDelay(1500);
            PageObject_Profile.Profile_Sub_Client().Click();
            AddDelay(1000);
            PageObject_Profile.Profile_Sub_Client().SendKeys(client);
            AddDelay(10000);
            PageObject_Profile.Profile_Sub_Client().SendKeys(Keys.Enter);
            AddDelay(3000);

            Logger.WriteInfoMessage("Selected Property as - " + client);
        }
        public static void SelectSubClient(string client)
        {
            if (testCategory != "POC")
            {
                string clinetName = Driver.FindElement(By.XPath("//select[@id='client_select']/following-sibling::span")).Text;
                if(!clinetName.Equals(client))
                {
                    Logger.WriteInfoMessage("Selecting the Property " + client);
                    //ElementWait(PageObject_Profile.Profile_Sub_Client(), 320);
                     PageObject_Profile.Profile_Sub_Client().Click();
                    AddDelay(5000);
                    PageObject_Profile.Profile_Sub_Client_SearchField().SendKeys(client);
                    var cList = Driver.FindElement(By.Id("client_select"));
                    //create select element object 
                    var selectElement = new SelectElement(cList);
                    selectElement.SelectByText(client);
                    PageObject_Profile.Profile_Sub_Client_SearchField().SendKeys(Keys.Enter);
                    AddDelay(3000);
                    Logger.WriteInfoMessage("Selected Property as - " + client);
                }
            }
        }

        /// <summary>
        /// This method will select a company from the Company drop down menu.
        /// </summary>
        /// <param name="company"></param>
        public static void SelectCompany(string company)
        {
            AddDelay(1500);
            PageObject_Profile.Profile_Company().Click();
            AddDelay(1000);
            PageObject_Profile.Profile_Company().SendKeys(company);
            AddDelay(10000);
            PageObject_Profile.Profile_Company().SendKeys(Keys.Enter);
            AddDelay(3000);
        }

        public static void ClickSearchGuestsTab()
        {
            ElementClick(PageObject_Profile.Profile_SearchGuestsTab());
        }

        public static void ClickAddGuestsTab()
        {
            ElementClick(PageObject_Profile.Profile_AddGuestsTab());
            Logger.WriteDebugMessage("Landed on Profile - Add Guest Tab");
        }

        public static void ClickUnsubscribesTab()
        {
            ElementClick(PageObject_Profile.Profile_UnsubscribesTab());
        }

        public static void ClickMergeGuestRecordsTab()
        {
            ElementClick(PageObject_Profile.Profile_MergeGuestRecordsTab());
        }

        public static void SelectSearchGuestsSearchExpression(string expression)
        {
            ElementSelectFromDropDown(PageObject_Profile.Profile_SearchGuestsSearchExpression(), expression);
        }

        public static void SelectSearchGuestsSearchBy(string searchby)
        {
            ElementWait(PageObject_Profile.Profile_SearchGuestsSearchBy(), 60);
            if (IsElementVisible(PageObject_Profile.Profile_SearchGuestsSearchBy()))
            {
                ElementSelectFromDropDown(PageObject_Profile.Profile_SearchGuestsSearchBy(), searchby);
            }
            else
            {
                Logger.WriteDebugMessage("Couldn't find " + searchby + " element on Profile Page.");
            }

        }

        public static void SelectSearchExpression(int searchExpression)
        {
            string expressionFilter;
            switch(searchExpression)
            {
                case 1:
                    expressionFilter  = "Equals";
                    ElementWait(PageObject_Profile.Profile_SearchGuestsSearchExpression(), 60);
                    if (IsElementVisible(PageObject_Profile.Profile_SearchGuestsSearchExpression()))
                    {
                        SelectSearchGuestsSearchExpression(expressionFilter);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Couldn't find expression filter" + expressionFilter + " element on Profile Page.");
                    }
                    break;
                case 2:
                    expressionFilter = "Begins With";
                    ElementWait(PageObject_Profile.Profile_SearchGuestsSearchExpression(), 60);
                    if (IsElementVisible(PageObject_Profile.Profile_SearchGuestsSearchExpression()))
                    {
                        SelectSearchGuestsSearchExpression(expressionFilter);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Couldn't find expression filter" + expressionFilter + " element on Profile Page.");
                    }
                    break;
                case 3:
                    expressionFilter = "Ends With";
                    ElementWait(PageObject_Profile.Profile_SearchGuestsSearchExpression(), 60);
                    if (IsElementVisible(PageObject_Profile.Profile_SearchGuestsSearchExpression()))
                    {
                        SelectSearchGuestsSearchExpression(expressionFilter);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Couldn't find expression filter" + expressionFilter + " element on Profile Page.");
                    }
                    break;
                case 4:
                    expressionFilter = "Contains";
                    ElementWait(PageObject_Profile.Profile_SearchGuestsSearchExpression(), 60);
                    if (IsElementVisible(PageObject_Profile.Profile_SearchGuestsSearchExpression()))
                    {
                        SelectSearchGuestsSearchExpression(expressionFilter);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Couldn't find expression filter" + expressionFilter + " element on Profile Page.");
                    }
                    break;
            }
        }

        public static void SelectSearchGuestsSearchBy_New(int caseType)
        {
            string searchby;

            switch (caseType)
            {

            case 1:
                    searchby = "Full Name";
                    ElementWait(PageObject_Profile.Profile_SearchGuestsSearchBy(), 60);
                    if (IsElementVisible(PageObject_Profile.Profile_SearchGuestsSearchBy()))
                    {
                        ElementSelectFromDropDown(PageObject_Profile.Profile_SearchGuestsSearchBy(), searchby);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Couldn't find " + searchby + " element on Profile Page.");
                    }
                    break;

                case 2:
                    searchby = "Last Name";
                    ElementWait(PageObject_Profile.Profile_SearchGuestsSearchBy(), 60);
                    if (IsElementVisible(PageObject_Profile.Profile_SearchGuestsSearchBy()))
                    {
                        ElementSelectFromDropDown(PageObject_Profile.Profile_SearchGuestsSearchBy(), searchby);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Couldn't find " + searchby + " element on Profile Page.");
                    }
                    break;

                case 3:
                    searchby = "First Name";
                    ElementWait(PageObject_Profile.Profile_SearchGuestsSearchBy(), 60);
                    if (IsElementVisible(PageObject_Profile.Profile_SearchGuestsSearchBy()))
                    {
                        ElementSelectFromDropDown(PageObject_Profile.Profile_SearchGuestsSearchBy(), searchby);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Couldn't find " + searchby + " element on Profile Page.");
                    }
                    break;

                case 4:
                    searchby = "Email";
                    ElementWait(PageObject_Profile.Profile_SearchGuestsSearchBy(), 60);
                    if (IsElementVisible(PageObject_Profile.Profile_SearchGuestsSearchBy()))
                    {
                        ElementSelectFromDropDown(PageObject_Profile.Profile_SearchGuestsSearchBy(), searchby);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Couldn't find " + searchby + " element on Profile Page.");
                    }
                    break;

                case 5:
                    searchby = "Reservation #";
                    ElementWait(PageObject_Profile.Profile_SearchGuestsSearchBy(), 60);
                    if (IsElementVisible(PageObject_Profile.Profile_SearchGuestsSearchBy()))
                    {
                        ElementSelectFromDropDown(PageObject_Profile.Profile_SearchGuestsSearchBy(), searchby);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Couldn't find " + searchby + " element on Profile Page.");
                    }
                    break;

                case 6:
                    searchby = "Sub Reservation #";
                    ElementWait(PageObject_Profile.Profile_SearchGuestsSearchBy(), 60);
                    if (IsElementVisible(PageObject_Profile.Profile_SearchGuestsSearchBy()))
                    {
                        ElementSelectFromDropDown(PageObject_Profile.Profile_SearchGuestsSearchBy(), searchby);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Couldn't find " + searchby + " element on Profile Page.");
                    }
                    break;

                case 7:
                    searchby = "Booking Eng Conf #";
                    ElementWait(PageObject_Profile.Profile_SearchGuestsSearchBy(), 60);
                    if (IsElementVisible(PageObject_Profile.Profile_SearchGuestsSearchBy()))
                    {
                        ElementSelectFromDropDown(PageObject_Profile.Profile_SearchGuestsSearchBy(), searchby);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Couldn't find " + searchby + " element on Profile Page.");
                    }
                    break;

                case 8:
                    searchby = "Inventory Block Code";
                    ElementWait(PageObject_Profile.Profile_SearchGuestsSearchBy(), 60);
                    if (IsElementVisible(PageObject_Profile.Profile_SearchGuestsSearchBy()))
                    {
                        ElementSelectFromDropDown(PageObject_Profile.Profile_SearchGuestsSearchBy(), searchby);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Couldn't find " + searchby + " element on Profile Page.");
                    }
                    break;

                case 9:
                    searchby = "Customer ID";
                    ElementWait(PageObject_Profile.Profile_SearchGuestsSearchBy(), 60);
                    if (IsElementVisible(PageObject_Profile.Profile_SearchGuestsSearchBy()))
                    {
                        ElementSelectFromDropDown(PageObject_Profile.Profile_SearchGuestsSearchBy(), searchby);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Couldn't find " + searchby + " element on Profile Page.");
                    }
                    break;

                case 10:
                    searchby = "Source Guest ID";
                    ElementWait(PageObject_Profile.Profile_SearchGuestsSearchBy(), 60);
                    if (IsElementVisible(PageObject_Profile.Profile_SearchGuestsSearchBy()))
                    {
                        ElementSelectFromDropDown(PageObject_Profile.Profile_SearchGuestsSearchBy(), searchby);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Couldn't find " + searchby + " element on Profile Page.");
                    }
                    break;

                case 11:
                    searchby = "Phone Number";
                    ElementWait(PageObject_Profile.Profile_SearchGuestsSearchBy(), 60);
                    if (IsElementVisible(PageObject_Profile.Profile_SearchGuestsSearchBy()))
                    {
                        ElementSelectFromDropDown(PageObject_Profile.Profile_SearchGuestsSearchBy(), searchby);
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Couldn't find " + searchby + " element on Profile Page.");
                    }
                    break;
            }
        }

        public static void InsertTextSearchGuestsSearchFor(string text)
        {
            ElementEnterText(PageObject_Profile.Profile_SearchGuestsSearchFor(), text);
            Profile.ClickSearchGuestsSearch();
            AddDelay(60000);
        }

        public static void ClickSearchGuestsSearch()
        {
            ElementClick(PageObject_Profile.Profile_SearchGuestsSearch());
        }

        public static void ClickOpenProfile(string CustomerID, string primaryCustomer = null)//a[@onclick='selectCustomerByCustomerID(2194676);']
        {
            try
            {
                IWebElement ele = Helper.Driver.FindElement(By.XPath("//div[contains(text(),'Loading Profile')]/ancestor::div[@role='dialog']"));
                while (ele.GetAttribute("style").Contains("block"))
                {
                    AddDelay(1000);
                    ele = Helper.Driver.FindElement(By.XPath("//div[contains(text(),'Loading Profile')]/ancestor::div[@role='dialog']"));
                }

            }
            catch (Exception) { }
            ElementClick(Driver.FindElement(By.XPath("//a[@onclick='selectCustomerByCustomerID(" + CustomerID + ");']")));
            
            AddDelay(300000);
            if (IsElementPresent(By.XPath("//a[contains(@href, '#profile-div" + primaryCustomer + "')]")))
            {
                Logger.WriteDebugMessage("Landed on Profile Page for CustomerID: " + primaryCustomer);
            }
            else
            {
                Assert.Fail("Did not land on Profile Page for CustomerID: " + primaryCustomer);
            }

        }

        public static void ClickGlobalOpenProfile(string CustomerID, ProfileCustData profID)//a[@onclick='selectCustomerByCustomerID(2194676);']
        {
            ElementWait(PageObject_Profile.Profile_SearchByCustomerPresent(CustomerID),240);
            string customerIDValue = "//a[@onclick='selectCustomerByCustomerID(" + CustomerID + ");']";
            ElementClick(Driver.FindElement(By.XPath(customerIDValue)));
            ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, 'profile-div')]")), 180);
            if (CustomerID == profID.PrimaryCustomer)
            {
                if (IsElementPresent(By.XPath("//a[contains(@href, '#profile-div" + CustomerID + "')]")))
                {
                    Logger.WriteDebugMessage("Landed on Profile Page for CustomerID: " + CustomerID);
                }
                else
                {
                    Assert.Fail("Did not land on Profile Page for CustomerID: " + CustomerID);
                }
            }
            else if (CustomerID != profID.PrimaryCustomer)
            {
                if (IsElementPresent(By.XPath("//a[contains(@href, '#profile-div" + profID.PrimaryCustomer + "')]")))
                {
                    Logger.WriteDebugMessage("Landed on Profile Page for CustomerID: " + profID.PrimaryCustomer);
                }
                else
                {
                    Assert.Fail("Did not land on Profile Page for CustomerID: " + profID.PrimaryCustomer);
                }
            }


        }

        public static void ClickSearchGuestsCancel()
        {
            ElementClick(PageObject_Profile.Profile_SearchGuestsCancel());
        }

        public static void ClickAddGuestsUploadNewFileNewSourceRb()
        {
            ElementClick(PageObject_Profile.Profile_AddGuestsUploadNewFileCreateNewSourceRb());
        }

        public static void InsertTextAddGuestsUploadNewFileNewSourceName(string name)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsUploadNewFileCreateNewSourceName(), name);
        }

        public static void ClickAddGuestsUploadNewFileNewSourceChooseFile()
        {
            ElementClick(PageObject_Profile.Profile_AddGuestsUploadNewFileCreateNewSourceChooseFile());
        }

        public static void ClickAddGuestsUploadNewFileCreateNewSourceSubmit()
        {
            ElementClick(PageObject_Profile.Profile_AddGuestsUploadNewFileCreateNewSourceSubmit());
        }

        public static void ClickAddGuestsUploadNewFileNewSourceReset()
        {
            ElementClick(PageObject_Profile.Profile_AddGuestsUploadNewFileCreateNewSourceReset());
        }

        public static void ClickAddGuestsUploadNewFileExistingSourceRb()
        {

            ElementClick(PageObject_Profile.Profile_AddGuestsUploadNewFileUpdateExistingSourceRb());
        }

        public static void InsertTextAddGuestsUploadNewFileExistingSourceName(string name)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsUploadNewFileUpdateExistingSourceName(), name);
        }

        public static void ClickAddGuestsUploadNewFileExistingSourceChooseFile()
        {
            ElementClick(PageObject_Profile.Profile_AddGuestsUploadNewFileUpdateExistingSourceChooseFile());
        }

        public static void ClickAddGuestsUploadNewFileCreateExistingSourceSubmit()
        {
            ElementClick(PageObject_Profile.Profile_AddGuestsUploadNewFileUpdateExistingSourceSubmit());
        }

        public static void ClickAddGuestsUploadNewFileExistingSourceReset()
        {
            ElementClick(PageObject_Profile.Profile_AddGuestsUploadNewFileUpdateExistingSourceReset());
        }

        public static void ClickAddGuestSubTab(int tabNum)
        {
            switch (tabNum)
            {
                case 0:
                    //ElementClick(PageObject_Profile.Profile_AddGuestsUploadNewFileTab());
                    Logger.WriteDebugMessage("Landed on Profile - Add Guest - File Upload Tab");
                    Driver.SwitchTo().Frame(0);
                    break;
                case 1:
                    ElementClick(PageObject_Profile.Profile_AddGuestsManuallyAddGuestTab());
                    Logger.WriteDebugMessage("Landed on Profile - Add Guest - Manually Add Guest Tab");
                    Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[contains(@id, 'addguestFrame')]")));
                    break;
            }
        }

        public static void InsertAddGuestsManuallyAddGuestsPrefix(string prefix)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsManuallyAddGuestPrefix(), prefix);
        }

        public static void InsertAddGuestsManuallyAddGuestsFirstName(string firstName)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsManuallyAddGuestFirstName(), firstName);
        }

        public static void InsertAddGuestsManuallyAddGuestsLastName(string lastName)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsManuallyAddGuestLastName(), lastName);
        }

        public static void InsertAddGuestsManuallyAddGuestsAddress1(string address1)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsManuallyAddGuestAddress1(), address1);
        }

        public static void InsertAddGuestsManuallyAddGuestsAddress2(string address2)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsManuallyAddGuestAddress2(), address2);
        }

        public static void InsertAddGuestsManuallyAddGuestsCity(string city)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsManuallyAddGuestCity(), city);
        }

        public static void InsertAddGuestsManuallyAddGuestsState(string state)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsManuallyAddGuestState(), state);
        }

        public static void InsertAddGuestsManuallyAddGuestsZip(string zip)

        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsManuallyAddGuestZip(), zip);
        }

        public static void InsertAddGuestsManuallyAddGuestsCountryCode(string countryCode)
        {
            AddDelay(1500);
            PageObject_Profile.Profile_AddGuestsManuallyAddGuestCountryCode().Click();
            AddDelay(1000);
            PageObject_Profile.Profile_AddGuestsManuallyAddGuestCountryCode().SendKeys(countryCode);
            AddDelay(10000);
            PageObject_Profile.Profile_AddGuestsManuallyAddGuestCountryCode().SendKeys(Keys.Enter);
            AddDelay(3000);
            
        }

        public static void InsertAddGuestsManuallyAddGuestsNewSourceName(string source)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsUploadNewFileUpdateExistingSourceName(), source);
        }

        public static void SelectAddGuestsManuallyAddGuestsExistingSourceName(string source)
        {
            OLDDROPDOWNDONOTUSE(PageObject_Profile.Profile_AddGuestsUploadNewFileUpdateExistingSourceName(), source);
        }

        public static void SelectExistingSource(string sourceName)
        {
            AddDelay(1500);
            PageObject_Profile.Profile_AddGuestsUploadNewFileUpdateExistingSourceName().Click();
            AddDelay(1000);
            PageObject_Profile.Profile_AddGuestsUploadNewFileUpdateExistingSourceName().SendKeys(sourceName);
            AddDelay(10000);
            PageObject_Profile.Profile_AddGuestsUploadNewFileUpdateExistingSourceName().SendKeys(Keys.Enter);
            AddDelay(3000);
        }

        public static void InsertAddGuestsManuallyAddGuestsEmail(string email)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsManuallyAddGuestEmail(), email);
        }

        public static void InsertAddGuestsManuallyAddGuestsCompany(string company)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsManuallyAddGuestCompany(), company);
        }

        public static void InsertAddGuestsManuallyAddGuestsTitle(string title)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsManuallyAddGuestTitle(), title);
        }

        public static void InsertAddGuestsManuallyAddGuestsWorkPhone(string workPhone)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsManuallyAddGuestWorkPhone(), workPhone);
        }

        public static void InsertAddGuestsManuallyAddGuestsWorkExt(string workExt)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsManuallyAddGuestWorkExt(), workExt);
        }

        public static void InsertAddGuestsManuallyAddGuestsFax(string fax)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsManuallyAddGuestFax(), fax);
        }

        public static void InsertAddGuestsManuallyAddGuestsMobile(string mobile)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsManuallyAddGuestMobile(), mobile);
        }

        public static void InsertAddGuestsManuallyAddGuestsHome(string home)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsManuallyAddGuestHome(), home);
        }

        public static void InsertAddGuestsManuallyAddGuestsSourceOfBusiness(string source)
        {
            ElementEnterText(PageObject_Profile.Profile_AddGuestsManuallyAddGuestSourceOfBusiness(), source);
        }

        public static void ClickAddGuestsManuallyAddGuestsNewSourceNameRb()
        {
            ElementClick(PageObject_Profile.Profile_AddGuestsManuallyAddGuestNewSourceNameRb());
        }

        public static void ClickAddGuestsManuallyAddGuestsExistingSourceRb()
        {
            ElementClick(PageObject_Profile.Profile_AddGuestsManuallyAddGuestExistingSourceRb());
        }

        public static void ClickAddGuestsNext()
        {
            ElementClick(PageObject_Profile.Profile_AddGuestsManuallyAddGuestNext());
        }

        public static void ClickAddGuestsReset()
        {
            ElementClick(PageObject_Profile.Profile_AddGuestsManuallyAddGuestReset());
        }

        public static void ClickUnsubscribesFileUploadBrowse()
        {
            ElementClick(PageObject_Profile.Profile_UnsubscribesFileUploadBrowse());
        }

        public static void ClickUnsubscribesFileUploadSubmit()
        {
            ElementClick(PageObject_Profile.Profile_UnsubscribesFileUploadSubmit());
        }

        public static void ClickUnsubscribeFileUploadCancel()
        {
            ElementClick(PageObject_Profile.Profile_UnsubscribesFileUploadCancel());
        }

        public static void ClickUnsubscribeFileUploadTab()
        {
            ElementClick(PageObject_Profile.Profile_UnsubscribesFileUploadTab());
        }

        public static void ClickUnsubscribeOneAtATimeTab()
        {
            ElementClick(PageObject_Profile.Profile_UnsubscribesOneAtATimeTab());
        }

        public static void ClickUnsubscribeSearchUnsubscribedTab()
        {
            ElementClick(PageObject_Profile.Profile_UnsubscribesFileUploadSearchUnsubscribedTab());
        }

        public static void InsertUnsubscribesOneAtATimeEmail(string email)
        {
            ElementEnterText(PageObject_Profile.Profile_UnsubscribesOneAtATimeEmail(), email);
        }

        public static void InsertUnsubscribesOneAtATimeMethod(string method)
        {
            ElementEnterText(PageObject_Profile.Profile_UnsubscribesOneAtATimeMethod(), method);
        }

        public static void InsertUnsubscribesOneAtATimeProjectID(string id)
        {
            ElementEnterText(PageObject_Profile.Profile_UnsubscribesOneAtATimeProjectId(), id);
        }

        public static void InsertUnsubscribesOneAtATimeComments(string comments)
        {
            ElementEnterText(PageObject_Profile.Profile_UnsubscribesOneAtATimeEmail(), comments);
        }

        public static void ClickUnsubscribesOneAtATimeSubmit()
        {
            ElementClick(PageObject_Profile.Profile_UnsubscribesOneAtATimeSubmit());
        }

        public static void ClickUnsubscribesOneAtATimeCancel()
        {
            ElementClick(PageObject_Profile.Profile_UnsubscribesOneAtATimeCancel());
        }

        public static void SelectSearchUnsubscribedExpression(string expression)
        {
            ElementSelectFromDropDown(PageObject_Profile.Profile_UnsubscribesSearchUnsubscribedSearchExpression(), expression);
        }

        public static void SelectSearchUnsubscribedSearchBy(string searchBy)
        {
            ElementSelectFromDropDown(PageObject_Profile.Profile_UnsubscribesSearchUnsubscribedSearchBy(), searchBy);
        }

        public static void InsertSearchUnsubscribedSearchFor(string searchFor)
        {
            ElementEnterText(PageObject_Profile.Profile_UnsubscribesSearchUnsubscribedSearchFor(), searchFor);
        }

        public static void ClickSearchUnsubscribedSearch()
        {
            ElementClick(PageObject_Profile.Profile_UnsubscribesSearchUnsubscribedSearch());
        }

        public static void ClickSearchUnsubscribedCancel()
        {
            ElementClick(PageObject_Profile.Profile_UnsubscribesSearchUnsubscribedCancel());
        }

        public static void ClickMergeGuestManualMergeTab()
        {
            ElementClick(PageObject_Profile.Profile_MergeGuestRecordsManualMergeTab());
        }

        public static void ClickMergeGuestPotentialMergeTab()
        {
            ElementClick(PageObject_Profile.Profile_MergeGuestRecordsPotentialMergeTab());
        }

        public static void ClickMergeGuestMergeHistoryTab()
        {
            ElementClick(PageObject_Profile.Profile_MergeGuestRecordsMergeHistoryTab());
        }

        public static void ClickMergeGuestMergeManualMergeSearchGuest()
        {
            ElementClick(PageObject_Profile.Profile_MergeGuestRecordsManualMergeSearchGuest());
        }

        public static void ClickMergeGuestMergeManualMergeCancel()
        {
            ElementClick(PageObject_Profile.Profile_MergeGuestRecordsManualMergeCancel());
        }

        public static void ClickMergeGuestMergeManualMergeAddToMergeProcess()
        {
            ElementClick(PageObject_Profile.Profile_MergeGuestRecordsManualMergeAddToMergeProcess());
        }

        public static void ClickMergeGuestMergeManualMergeRecordsToMerge()
        {
            ElementClick(PageObject_Profile.Profile_MergeGuestRecordsManualMergeRecordsToMerge());
        }

        public static void ClickMergeGuestMergeManualMergeCompare()
        {
            ElementClick(PageObject_Profile.Profile_MergeGuestRecordsManualMergeCompare());
        }

        public static void InsertMergeGuestMergeManualMergeFirstName(string firstName)
        {
            ElementEnterText(PageObject_Profile.Profile_MergeGuestRecordsManualMergeFirstName(), firstName);
        }

        public static void InsertMergeGuestMergeManualMergeLastName(string lastName)
        {
            ElementEnterText(PageObject_Profile.Profile_MergeGuestRecordsManualMergeLastName(), lastName);
        }

        public static void InsertMergeGuestMergeManualMergeEmail(string email)
        {
            ElementEnterText(PageObject_Profile.Profile_MergeGuestRecordsManualMergeEmail(), email);
        }

        public static void InsertMergeGuestMergeManualMergeZip(string zip)
        {
            ElementEnterText(PageObject_Profile.Profile_MergeGuestRecordsManualMergeZipCode(), zip);
        }

        public static void InsertMergeGuestMergeManualMergeCity(string city)
        {
            ElementEnterText(PageObject_Profile.Profile_MergeGuestRecordsManualMergeCity(), city);
        }

        public static void InsertMergeGuestMergeManualMergeState(string state)
        {
            ElementEnterText(PageObject_Profile.Profile_MergeGuestRecordsManualMergeState(), state);
        }

        public static void InsertMergeGuestMergeManualMergeCompany(string company)
        {
            ElementEnterText(PageObject_Profile.Profile_MergeGuestRecordsManualMergeCompany(), company);
        }

        public static void InsertMergeGuestMergeManualMergeSalutation(string salutation)
        {
            ElementEnterText(PageObject_Profile.Profile_MergeGuestRecordsManualMergeSalutation(), salutation);
        }

        public static void ClickSearchGuestsFirstResult()
        {
            ElementClick(PageObject_Profile.Profile_SearchGuestsFirstResult());
        }


        public static void VerifySearchMemberProfileIsDisplayed(string text)
        {
            VerifyTextOnPage(text);
        }
        public static void Click_CASLCheckBox()
        {
            ElementClick(PageObject_ManageCampaign.CheckBox_CASL());
        }

        public static void ClickProfileCampaignHistory(string ChildProjectID, string CustomerID)
        {
            Helper.FindLoaderAndWaitTillHide("//div[@role='dialog' and @style= 'display: block; z-index: 1006; outline: 0px; position: absolute; height: auto; width: 300px; top: 230.5px; left: 524.5px;']");
            ElementClick(PageObject_Profile.Profile_CampaignHistory());
            ScrollToElement(Driver.FindElement(By.XPath("//a[contains(@href, 'CampaignHistoryTab1" + CustomerID + "')]")));
            AddDelay(10000);
            ManageCampaign.WaitForReady();
            if (VerifyTextOnPage("Campaigns Overview"))
            {
                Logger.WriteDebugMessage("Landed on Campaign History Page for CustomerID: " + CustomerID);
            }
            else
            {
                Assert.Fail("Did not land on Campaign History Page for CustomerID: " + CustomerID);
            }
        }

        /// <summary>
        /// This method will verify that the Guest Records tab IS displayed on the Profile page.
        /// </summary>
        public static void VerifyMergeGuestRecordsTabIsDisplayed()
        {

            if (VerifyElementOnPage(PageObject_Profile.Profile_MergeGuestRecordsTab()))
            {
                Logger.WriteInfoMessage("The Merge Guest Records Auto Dedupe tab is displayed correctly. (CORRECT)");
            }
            else
                Assert.Fail("The Merge Guest Records Auto Dedupe tab was not displayed on the Profile page. (FAIL)");


        }

        /// <summary>
        /// This method will verify that the Guest Records tab IS NOT displayed on the Profile page.
        /// </summary>
        public static void VerifyMergeGuestRecordsTabIsNotDisplayed()
        {
            try
            {
                if (!VerifyElementOnPage(PageObject_Profile.Profile_MergeGuestRecordsTab()))
                {
                    Assert.Fail("The Merge Guest Records Auto Dedupe tab was displayed (FAIL).");
                }
            }
            catch (Exception)
            {
                Logger.WriteInfoMessage("The Merge Guest Records Auto Dedupe tab is not displayed (CORRECT).");
            }

        }

        public static void UploadExistingSourceFile(string sourceID)
        {
            try
            {
                string rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", "");

                string filelocation = @"\TestData\csv\GuestProfile.csv";
                string withxlsxlocation = @"\TestData\csv\GuestProfile.xlsx";
                string location = rootPath + filelocation;
                string excelLocation = rootPath + withxlsxlocation;

                AnnonymizedData data = new AnnonymizedData();
                SqlWarehouseQuery.GetDummyData(data);

                FileManager.UploadDummyData(excelLocation, data);

                Logger.WriteInfoMessage("Selecting and uploading the Existing Source file...");
                AddDelay(10000);
                ScrollDownUsingJavaScript(Driver, 1000);
                ClickAddGuestsManuallyAddGuestsExistingSourceRb();
                Logger.WriteDebugMessage("Click on Existing Source Option box.");

                ElementClick(PageObject_Profile.Profile_AddGuestsUploadNewFileUpdateExistingSourceName());
                ElementClick(PageObject_Profile.Profile_AddGuestsUploadNewFileUpdateExistingSourceName_SelectSource(sourceID));
                //IWebElement select = Driver.FindElement(By.Id("selectExisting"));
                //((IJavaScriptExecutor)Driver).ExecuteScript("var select = arguments[0]; for(var i = 0; i < select.options.length; i++){ if(select.options[i].text == arguments[1]){ select.options[i].selected = true; } }", select, "");

                Logger.WriteDebugMessage("Selected Existing Source " + sourceID);

                //UploadFile(PageObject_Profile.Profile_AddGuestsUploadNewFileUpdateExistingSourceChooseFile(), location);
                uploadGuestProfile(location);

                ClickAddGuestsUploadNewFileCreateExistingSourceSubmit();
                AddDelay(60000);
                Logger.WriteDebugMessage("Selected and attached the Existing Source file successfully.");

                SqlWarehouseQuery.UpdateUsedguestData(data.ID);

                File.Delete(location);

            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                throw;
            }
        }

        public static void uploadGuestProfile(string location)
        {
            IWebElement uploadfile = Driver.FindElement(By.Id("uploadFile2"));
            uploadfile.SendKeys(location);
        }

        public static void ExitIFrame()
        {
            ExitFrame();
        }

        public static void EnterCendynAddGuestsIFrame()
        {
            Driver.SwitchTo().Frame("guestfileuploadFrame621");
        }

        public static void EnterCendynUnsubscribesIFrame()
        {
            EnterFrame("unsubscribefileuploadFrame621");
        }

        public static void EnterMergeGuestRecordsIFrame()
        {

        }
        public static void Select_CampaignHistory_NumofRows(string customerID, string rows)
        {
            ElementClick(PageObject_Profile.Profile_Grid_CampaignHistory_NumberofRows(customerID, rows));
            Logger.WriteDebugMessage("Selected number of row - " + rows + " to be displayed on page.");
        }
        public static void VerifyCampaignHistoryData(Users HistoryData)
        {
            AddDelay(60000);
            DateTime SentDate = DateTime.Parse(HistoryData.SendDate);
            string SendDate = SentDate.ToString("M/d/yyyy");
            if (VerifyTextOnPage(HistoryData.Email) && VerifyTextOnPage(HistoryData.CampaignName) && VerifyTextOnPage(HistoryData.Subject) && VerifyTextOnPage(SendDate) && VerifyTextOnPage(HistoryData.OpenYN) && VerifyTextOnPage(HistoryData.ClickYN) && VerifyTextOnPage(HistoryData.ClickLinksCount) && VerifyTextOnPage(HistoryData.BouncedYN))
            {
                Logger.WriteDebugMessage("Campaign History Grid shows correct data.");
            }
            else
            {
                Assert.Fail("Campaign History Grid does not shows correct data.");
            }

            //IWebElement table = Driver.FindElement(By.Id("campaignHistoryRegularTable" + Data.CustomerID));
            //List<IWebElement> allRows = table.FindElements(By.Id(Data.ChildProjectID + "_" + Data.CustomerID));
        }

        public static void VerifyProfileData(ProfileCustData Data)
        {
            Data.InsertDate = Convert.ToDateTime(Data.InsertDate).ToString("M/d/yyyy");
            Data.UpdateDate = Convert.ToDateTime(Data.UpdateDate).ToString("M/d/yyyy");
            if (VerifyTextOnPage(Data.CustomerID) || VerifyTextOnPage(Data.GenderCode) || VerifyTextOnPage(Data.Languages) || VerifyTextOnPage(Data.PropertyCode) || VerifyTextOnPage(Data.InsertDate) || VerifyTextOnPage(Data.UpdateDate) || VerifyTextOnPage(Data.SourceName) || VerifyTextOnPage(Data.Email) || VerifyTextOnPage(Data.PhoneNumber) || VerifyTextOnPage(Data.Address1) || VerifyTextOnPage(Data.Address2) || VerifyTextOnPage(Data.City) || VerifyTextOnPage(Data.StateProvinceCode) || VerifyTextOnPage(Data.ZipCode) || VerifyTextOnPage(Data.CountryCode) || VerifyTextOnPage(Data.AddressStatus))
            {
                Logger.WriteDebugMessage("Campaign History Grid shows correct data.");
            }
            else
            {
                Assert.Fail("One of the value did not apprear on Profile Page.");
            }
        }

        public static void VerifyGlobalProfileData(string CustomerID, ProfileCustData Data)
        {
            string fullName = Data.FirstName + " " + Data.LastName;
            if (CustomerID == Data.PrimaryCustomer)
            {
                Logger.WriteInfoMessage("\n Actual Result - CustomerID: " + CustomerID + ",\n ShortTitle: " + Data.ShortTitle + ",\n Title: " + Data.Title + ",\n FullName: " + fullName + ",\n Email: " + Data.Email + ",\n GenderCode: " + Data.GenderCode + ",\n Languages: " + Data.Languages + ",\n PropertyCode: " + Data.PropertyCode + ",\n InsertDate: " + Data.InsertDate + ",\n UpdateDate: " + Data.UpdateDate + ",\n SourceName: " + Data.SourceName + ",\n PhoneNumber: " + Data.PhoneNumber + ",\n PhoneExt: " + Data.PhoneExt + ",\n MobilePhone: " + Data.MobilePhone + ",\n WorkPhone: " + Data.WorkPhone + ",\n HomePhone: " + Data.HomePhone + ",\n Address1: " + Data.Address1 + ",\n City: " + Data.City + ",\n StateName: " + Data.StateProvinceCode + ",\n ZipCode: " + Data.ZipCode + ",\n CountryCode: " + Data.CountryCode + ",\n AddressStatus: " + Data.AddressStatus + ",\n EmailStatus: " + Data.EmailStatus);
                if (VerifyTextOnPage(CustomerID) && VerifyTextOnPage(Data.ShortTitle) && VerifyTextOnPage(Data.Title) && VerifyTextOnPage(fullName) && VerifyTextOnPage(Data.Email) && VerifyTextOnPage(Data.GenderCode) && VerifyTextOnPage(Data.Languages) && VerifyTextOnPage(Data.InsertDate) && VerifyTextOnPage(Data.UpdateDate) && VerifyTextOnPage(Data.SourceName) && VerifyTextOnPage(Data.PhoneNumber) && VerifyTextOnPage(Data.PhoneExt) && VerifyTextOnPage(Data.MobilePhone) && VerifyTextOnPage(Data.WorkPhone) && VerifyTextOnPage(Data.HomePhone) && VerifyTextOnPage(Data.Address1) && VerifyTextOnPage(Data.City) && VerifyTextOnPage(Data.StateProvinceCode) && VerifyTextOnPage(Data.ZipCode) && VerifyTextOnPage(Data.CountryCode) && VerifyTextOnPage(Data.AddressStatus) && VerifyTextOnPage(Data.EmailStatus))
                {
                    Logger.WriteInfoMessage("\n Expected Result - CustomerID: " + CustomerID + ",\n ShortTitle: " + Data.ShortTitle + ",\n Title: " + Data.Title + ",\n FullName: " + fullName + ",\n Email: " + Data.Email + ",\n GenderCode: " + Data.GenderCode + ",\n Languages: " + Data.Languages + ",\n PropertyCode: " + Data.PropertyCode + ",\n InsertDate: " + Data.InsertDate + ",\n UpdateDate: " + Data.UpdateDate + ",\n SourceName: " + Data.SourceName + ",\n PhoneNumber: " + Data.PhoneNumber + ",\n PhoneExt: " + Data.PhoneExt + ",\n MobilePhone: " + Data.MobilePhone + ",\n WorkPhone: " + Data.WorkPhone + ",\n HomePhone: " + Data.HomePhone + ",\n Address1: " + Data.Address1 + ",\n City: " + Data.City + ",\n StateName: " + Data.StateProvinceCode + ",\n ZipCode: " + Data.ZipCode + ",\n CountryCode: " + Data.CountryCode + ",\n AddressStatus: " + Data.AddressStatus + ",\n EmailStatus: " + Data.EmailStatus);
                    Logger.WriteDebugMessage("Profile Tab Grid shows correct data.");
                }
                else
                {
                    Assert.Fail("One of the value did not apprear on Profile Page.");
                }
            }
            else
            {
                Logger.WriteInfoMessage("\nActual Result - CustomerID: " + Data.PrimaryCustomer + ",\n ShortTitle: " + Data.ShortTitle + ",\n Title: " + Data.Title + ",\n FullName: " + fullName + ",\n Email: " + Data.Email + ",\n GenderCode: " + Data.GenderCode + ",\n Languages: " + Data.Languages + ",\n PropertyCode: " + Data.PropertyCode + ",\n InsertDate: " + Data.InsertDate + ",\n UpdateDate: " + Data.UpdateDate + ",\n SourceName: " + Data.SourceName + ",\n PhoneNumber: " + Data.PhoneNumber + ",\n PhoneExt: " + Data.PhoneExt + ",\n MobilePhone: " + Data.MobilePhone + ",\n WorkPhone: " + Data.WorkPhone + ",\n HomePhone: " + Data.HomePhone + ",\n Address1: " + Data.Address1 + ",\n City: " + Data.City + ",\n StateName: " + Data.StateProvinceCode + ",\n ZipCode: " + Data.ZipCode + ",\n CountryCode: " + Data.CountryCode + ",\n AddressStatus: " + Data.AddressStatus + ",\n EmailStatus: " + Data.EmailStatus);
                if (VerifyTextOnPage(Data.PrimaryCustomer) && VerifyTextOnPage(Data.ShortTitle) && VerifyTextOnPage(Data.Title) && VerifyTextOnPage(fullName) && VerifyTextOnPage(Data.Email) && VerifyTextOnPage(Data.GenderCode) && VerifyTextOnPage(Data.Languages) && VerifyTextOnPage(Data.InsertDate) && VerifyTextOnPage(Data.UpdateDate) && VerifyTextOnPage(Data.SourceName) && VerifyTextOnPage(Data.PhoneNumber) && VerifyTextOnPage(Data.PhoneExt) && VerifyTextOnPage(Data.MobilePhone) && VerifyTextOnPage(Data.WorkPhone) && VerifyTextOnPage(Data.HomePhone) && VerifyTextOnPage(Data.Address1) && VerifyTextOnPage(Data.City) && VerifyTextOnPage(Data.StateProvinceCode) && VerifyTextOnPage(Data.ZipCode) && VerifyTextOnPage(Data.CountryCode) && VerifyTextOnPage(Data.AddressStatus) && VerifyTextOnPage(Data.EmailStatus))
                {
                    Logger.WriteInfoMessage("\nExpected Result - CustomerID: " + Data.PrimaryCustomer + ",\n ShortTitle: " + Data.ShortTitle + ",\n Title: " + Data.Title + ",\n FullName: " + fullName + ",\n Email: " + Data.Email + ",\n GenderCode: " + Data.GenderCode + ",\n Languages: " + Data.Languages + ",\n PropertyCode: " + Data.PropertyCode + ",\n InsertDate: " + Data.InsertDate + ",\n UpdateDate: " + Data.UpdateDate + ",\n SourceName: " + Data.SourceName + ",\n PhoneNumber: " + Data.PhoneNumber + ",\n PhoneExt: " + Data.PhoneExt + ",\n MobilePhone: " + Data.MobilePhone + ",\n WorkPhone: " + Data.WorkPhone + ",\n HomePhone: " + Data.HomePhone + ",\n Address1: " + Data.Address1 + ",\n City: " + Data.City + ",\n StateName: " + Data.StateProvinceCode + ",\n ZipCode: " + Data.ZipCode + ",\n CountryCode: " + Data.CountryCode + ",\n AddressStatus: " + Data.AddressStatus + ",\n EmailStatus: " + Data.EmailStatus);
                    Logger.WriteDebugMessage("Profile Tab Grid shows correct data.");
                }
                else
                {
                    Assert.Fail("One of the value did not apprear on Profile Page.");
                }
            }
        }
        public static void ClickProfileStayTab(string CustomerID)
        {
            ElementClick(Driver.FindElement(By.XPath("//*[@id='tab2Regular" + CustomerID + "']/ul/li[2]/a")));
            AddDelay(8000);
            if (VerifyTextOnPage("Stay Overview"))
            {
                Logger.WriteDebugMessage("Landed on Stay Tab Page for CustomerID: " + CustomerID);
            }
            else
            {
                Assert.Fail("Did not land on Stay Tab Page Page for CustomerID: " + CustomerID);
            }
        }
        //public static void VerifyProfileStayTabData(ProfileCustData data)
        //{
        //    AddDelay(8000);
        //    if (VerifyTextOnPage(data.CustomerName))
        //    {
        //        Logger.WriteDebugMessage("Landed on Stay Tab Page for CustomerID: " + CustomerID);
        //    }
        //    else
        //    {
        //        Assert.Fail("Did not land on Stay Tab Page Page for CustomerID: " + CustomerID);
        //    }
        //}

        public static void Button_SendResend(string projectID)
        {
            ScrollToElement(Driver.FindElement(By.XPath("//a[contains(@onclick, '" + projectID + "')]")));
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@onclick, '" + projectID + "')]")));
        }
        public static void EnterResendEmailAddress()
        {
            ElementEnterText(Driver.FindElement(By.Id("alt_email")), ",cendynautomation@cendyn.com");
        }

        public static void SelectCampaignName(string campaignName)
        {
            AddDelay(1500);
            PageObject_Profile.Resend_Client().Click();
            AddDelay(1000);
            PageObject_Profile.Resend_Client().SendKeys(campaignName);
            AddDelay(10000);
            PageObject_Profile.Resend_Client().SendKeys(Keys.Enter);
            AddDelay(3000);
        }
        public static void Select_StayPage_NumofRows(string customerID, string value)
        {
            string totalPage = Driver.FindElement(By.XPath("(//span[@id='sp_1'])[2]")).Text;
            if (Convert.ToInt32(totalPage) > 1)
            {
                ElementSelectFromDropDownByValue(Driver.FindElement(By.XPath("//*[@id='staysRegularPager" + customerID + "_center']/table/tbody/tr/td[8]/select")), value);
            }
        }
        public static void OpenandSendResend(string reservationNumber, string campaignName, string customerID, string tabtype, string projectID)
        {
            switch (tabtype)
            {
                case "Profile":
                    ElementClick(Driver.FindElement(By.XPath("(//a[contains(text(),'" + reservationNumber + "')])[1]")));
                    break;
                case "Stay":
                    ElementClick(Driver.FindElement(By.XPath("(//a[contains(text(),'" + reservationNumber + "')])[2]")));
                    break;
                case "CampaignHistory":
                    ElementClick(PageObject_Profile.Profile_Grid_CampaignHistory_NumberofRows(customerID, "500"));
                    ManageCampaign.WaitForReady();
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '" + projectID + "') and  contains(@href, '" + campaignName + "')]")));
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, '" + projectID + "')]")));
                    break;
            }
            //int countTabs = Helper.CountWindowTabs();
            //if (countTabs > 1)
            //{
            //    Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            //    if (Driver.Url.Contains("Project.mvc"))
            //    {
            //        Logger.WriteDebugMessage("Landed on Manage Campaign.");
            //    }
            //}
            //else
            //{
                AddDelay(60000);
                Navigatetoiframe(1);

                if (VerifyTextOnPage("This email address is in compliance with global spam laws"))
                {
                    Click_CASLCheckBox();
                    Logger.WriteDebugMessage("CASL is selected and sending send to test email.");

                }
                EnterResendEmailAddress();
                SelectCampaignName(campaignName);
                Logger.WriteDebugMessage("Entered email address to send Resend Campaign.");
                Button_SendResend(projectID);
                AddDelay(25000);
                ScrollToElement(Driver.FindElement(By.XPath("//span[contains(text(), 'Confirmation Sent')]")));
                Logger.WriteDebugMessage("Email Sent.");
                Navigatetoiframe(1);
                //if (IsElementPresent(By.XPath("//a[contains(@href, '#profile-div" + CustomerID + "')]")))
                //{
                //    Logger.WriteDebugMessage("Landed on Profile Page for CustomerID: " + CustomerID);
                //}
                //else
                //{
                //    Assert.Fail("Did not land on Profile Page for CustomerID: " + CustomerID);
                //}
            //}
        }

        public static void InsertGuestData(AnnonymizedData data)
        {
            InsertAddGuestsManuallyAddGuestsFirstName(data.FirstName);
            InsertAddGuestsManuallyAddGuestsLastName(data.LastName);
            InsertAddGuestsManuallyAddGuestsEmail(data.Email);
            InsertAddGuestsManuallyAddGuestsHome(data.HomePhone);
            InsertAddGuestsManuallyAddGuestsWorkPhone(data.WorkPhone);
            InsertAddGuestsManuallyAddGuestsMobile(data.CellPhone);
            InsertAddGuestsManuallyAddGuestsAddress1(data.Address1);
            InsertAddGuestsManuallyAddGuestsAddress2(data.Address2);
            InsertAddGuestsManuallyAddGuestsCity(data.City);
            InsertAddGuestsManuallyAddGuestsState(data.StateProvinceCode);
            InsertAddGuestsManuallyAddGuestsZip(data.ZipCode);
            InsertAddGuestsManuallyAddGuestsCountryCode(data.Country);

            Logger.WriteDebugMessage("Insert Guest Dummy Data.");
            ElementClick(PageObject_Profile.Profile_AddGuestsManuallyAddGuestExistingSourceRb());
            SelectExistingSource("CLIENT > Jtest_QA_1008");

            Logger.WriteDebugMessage("Selected the source.");

            ClickAddGuestsNext();

            AddDelay(20000);


        }
        public static void UploadGuestData()
        {
            Driver.SwitchTo().Frame("guestfileuploadFrame7181");
            string datetimeNow = DateTime.Now.ToString("MMddyyyy");
            string sourceName = "QA" + datetimeNow;

            ElementEnterText(Driver.FindElement(By.Id("txtNewSource")), sourceName);


        }

        public static void SelectCurrency(string currencyXPath, string currency)
        {
            string selectCurrency = currencyXPath + "/option[contains(text(), '" + currency + "')]";
            AddDelay(1500);
            ScrollDownUsingJavaScript(Driver, -1000);
            Driver.FindElement(By.XPath(currencyXPath)).Click();
            AddDelay(1000);
            Driver.FindElement(By.XPath(selectCurrency)).Click();
            AddDelay(5000);
            Logger.WriteDebugMessage("Selected currency - " + currency);
            //Driver.FindElement(By.XPath(currencyXPath)).SendKeys(Keys.Enter);
            ScrollDownUsingJavaScript(Driver, 500);
        }
    }
}
