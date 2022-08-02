using BaseUtility.PageObject;
using BaseUtility.Utility;
using CHC.Entity;
using CHC.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;

namespace CHC.AppModule.UI
{
    public class Profiles : Helper
    {
        /// <summary>
        /// This method will click on Filter by Email search on the  Starling Profiles page.
        /// </summary>
        public static void Enter_txt_on_Filter_by_Email(string email)
        {
            Helper.WaitForAjaxControls(30);
            WaittillElementDisplay(PageObject_Profiles.Btn_SearchIcon());
            ElementEnterText(PageObject_Profiles.Txt_FilterByEmail(), email);
            Logger.WriteDebugMessage("User enter the " + email + " in Search text box");
            ElementClick(PageObject_Profiles.Btn_SearchIcon());
            Logger.WriteDebugMessage("User entered the " + email + " and Click on Search icon");
            Helper.WaitForAjaxControls(30);
        }

        public static void VerifyFilterforemailfield(string email)
        {
            Assert.IsTrue(GetText(PageObject_Profiles.Verify_Emailontable()).Contains(email), "Search filter not working for email field");
        }

        public static void VerifyHelpPage()
        {
            Assert.IsTrue(IsElementVisible(PageObject_Profiles.Help_Scdhuleameeting_Newtab()), "Help page not loading");
        }

        public static void ClickonFilterbutton()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_Profiles.Btn_Filter());
            Logger.WriteDebugMessage("Filter popup displayed with Clear and Choose buttons");
        }
        
        public static void Clickon_Data_Inspection()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_Profiles.Lnk_Data_Inspection());
            Logger.WriteDebugMessage("User clicked on Data inspection drop down link");
        }

        public static void Clickon_Data_Inspection_Raw_Profiles()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_Profiles.Lnk_Data_Inspection_Raw_Profiles());
            Logger.WriteDebugMessage("User clicked on Raw Profile from Data inspection drop down link");
        }

        public static void ClickonSortbutton()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_Profiles.Btn_Sort());
            Logger.WriteDebugMessage("Sort popup displayed with Clear and Choose buttons");
        }

        public static void Clickon_Homebutton()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_Profiles.Btn_Home());
            Logger.WriteDebugMessage("User click on Home button & navigates to Home page, selected App will be closed");
        }

        public static void Clickon_Selectbutton_Org()
        {            
            ElementClick(PageObject_Profiles.Btn_OrgSwitcher_Select());
            Logger.WriteDebugMessage("User click on Select button & navigates to Profiles index page, Existing Org will replaced by newly selected Org");
        }

        public static void Clickon_HelpLink()
        {
            //WaitTillBrowserLoad();
            //ElementClick(PageObject_Profiles.Link_Help());
            //Logger.WriteDebugMessage("User click on Help link & navigates to New tab with Cendyn help page");
            ElementHover(PageObject_Profiles.Lnk_HelpMouseOver());
            Logger.WriteDebugMessage("User click on Help link & navigates to New tab with Cendyn help page");
            Helper.ElementWait(PageObject_Profiles.Link_Help(), 10);
            ElementClick(PageObject_Profiles.Link_Help());
        }      

        public static void Clickon_ProfileRecord()
        {
            ElementClick(PageObject_Profiles.Ele_ViewProfile());
            Logger.WriteDebugMessage("View Profile page should display");
            Helper.WaitForAjaxControls(30);
        }

        public static void Filter_Validation(string field, string filterValue)
        {
            int index = 0;
            if (field.ToUpper().Equals("PROFILE ID")) index = 1;
            else if 
                (field.ToUpper().Equals("NAME")) index = 2;
            else if
                (field.ToUpper().Equals("EMAIL")) index = 3;
            else if
                (field.ToUpper().Equals("COUNTRY")) index = 4;
            else if
                (field.ToUpper().Equals("DATE")) index = 5;
            else if
                (field.ToUpper().Equals("SOURCE")) index = 6;

            By locator = By.XPath("//*[@class='e-table']//tr/td[" + index + "]");

            IList<IWebElement> tableRows = GetWebElements(locator);

            if(tableRows != null && tableRows.Count > 0)
            {
                foreach (IWebElement tableRow in tableRows)
                {
                    Assert.IsTrue(GetText(tableRow).Contains(filterValue));
                }
            }
            else
            {
                Logger.WriteDebugMessage("No records display for filter value " + filterValue + " Field "+ field);
            }
        }

        public static void View_ContactDetails()
        {
            ElementClick(PageObject_Profiles.ContactDetailstab());
            Logger.WriteDebugMessage("User lands on Profile related Contact Details page");
            Helper.WaitForAjaxControls(30);
        }

        public static void Clickon_OrgSwitcher()
        {
            ElementClick(PageObject_Profiles.Lnk_OrgSwitcher());
            Logger.WriteDebugMessage("User lands on Profile related Contact Details page");
            Helper.WaitForAjaxControls(30);
        }
        
        public static void Clickon_ApplyonSort()
        {
            ElementClick(PageObject_Profiles.VerifyApplybuttononSort());
            Logger.WriteDebugMessage("User Click on Apply button on Sort tab & Should display the data based on Search");
            Helper.WaitForAjaxControls(30);
        }


        public static void VerifyApply_ClearPopuponfilter()
        {
            Assert.IsTrue(IsElementVisible(PageObject_Profiles.VerifyApplybuttononfilter()), "Apply button not present in filter popup");
            Assert.IsTrue(IsElementVisible(PageObject_Profiles.VerifyClearbuttononfilter()), "Clear button not present in filter popup");
        }

        public static void VerifyApply_ClearPopuponSort()
        {
            Assert.IsTrue(IsElementVisible(PageObject_Profiles.VerifyApplybuttononSort()), "Apply button not present in Sort popup");
            Assert.IsTrue(IsElementVisible(PageObject_Profiles.VerifyClearbuttononSort()), "Clear button not present in Sort popup");
        }

        public static void Enter_txt_on_ProfileidfieldFilter_Contains(string profileid)
        {
            ElementEnterText(PageObject_Profiles.Txt_Profileidfieldcontainsfilter(), profileid);
            Logger.WriteDebugMessage("User enter the Externalprofileid " + profileid + " and click on Apply button");
            ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

            Helper.WaitForAjaxControls(30);
        }

        public static string GetPropertyLocatorName(string propertyName)
        {
            if (propertyName.Equals("Profile Id"))
            {
                propertyName = "ExternalProfileId";
            }
            else if (propertyName.Equals("Name"))
            {
                propertyName = "fullName";
            }
            else if (propertyName.Equals("Email"))
            {
                propertyName = "email";
            }
            else if (propertyName.Equals("Country"))
            {
                propertyName = "countryCode";
            }
            else if (propertyName.Equals("Date"))
            {
                propertyName = "dateInserted";
            }
            else if (propertyName.Equals("Source"))
            {
                propertyName = "integrationType";
            }

            else if (propertyName.Equals("Property Id"))
            {
                propertyName = "cendynPropertyID";
            }
            else if (propertyName.Equals("Property Name"))
            {
                propertyName = "propertyName";
            }
            else if (propertyName.Equals("Reservation Id"))
            {
                propertyName = "ExternalResID1";
            }
            else if (propertyName.Equals("Status"))
            {
                propertyName = "resStatusCode";
            }
            else if (propertyName.Equals("Check In"))
            {   
                propertyName = "resArriveDate";
            }
            else if (propertyName.Equals("Check Out"))
            {
                propertyName = "resDepartDate";
            }   
            return propertyName; 
        }

        public static void Enter_FilterValues(string propertyName, string condition, string propertyValue)
        {
            //Get UI locator name
            string propertyLocatorName = GetPropertyLocatorName(propertyName);

            //Select the condition
            ElementClick(PageAction.Find_ElementXPath("//*[starts-with(@aria-describedby,'operator-" + propertyLocatorName + "')]"));
            Logger.WriteDebugMessage("User selected the Column " + propertyName + " ");
            Thread.Sleep(3000);
            //ElementClickUsingJavascript(PageAction.Find_ElementXPath("//*[starts-with(@id,'operator-" + propertyLocatorName + "')]//*[text()='" + condition + "']"));
            ElementClickUsingJavascript(PageAction.Find_ElementXPath("//*[contains(@class,'e-popup-open')]//*[text()='" + condition + "']"));

            Logger.WriteDebugMessage("User selected the Column " + propertyName + " and selected the " + condition + " from drop down ");
            Helper.WaitForAjaxControls(30);

            //Enter value
            if (propertyName.Equals("Property Id"))
            {
                ElementEnterText(PageAction.Find_ElementXPath("//input[starts-with(@id,'number-" + propertyLocatorName + "')]"), propertyValue);
            }
            else if (propertyName.Equals("Check In") || propertyName.Equals("Check Out") || propertyName.Equals("Date"))
            {
                ElementEnterText(PageAction.Find_ElementXPath("//input[starts-with(@id,'date-" + propertyLocatorName + "')]"), propertyValue);
            }            
            else if (propertyName.Equals("Status") || propertyName.Equals("Source"))
            {
                ElementClick(PageAction.Find_ElementXPath("//*[starts-with(@aria-labelledby,'dropdown-" + propertyLocatorName + "')]"));
                ElementClick(PageAction.Find_ElementXPath("//*[contains(@class,'e-popup-open')]//*[text()='" + propertyValue + "']"));
            }
            else
            {
                //Enter value
                ElementEnterText(PageAction.Find_ElementXPath("//input[starts-with(@id,'string-" + propertyLocatorName + "')]"), propertyValue);
            }

            Logger.WriteDebugMessage("User selected the Column " + propertyName + " and selected the " + condition + " from drop down and enter the value " + propertyValue + " in text box ");

            //ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());
            Helper.WaitForAjaxControls(30);
        }

        public static void Enter_SortValues(string propertyName, string propertyValue)
        {
            if (propertyName.Equals("Order By"))
            {
                Thread.Sleep(3000);
                //WaittillElementDisplay(PageAction.Find_ElementXPath("//*[contains(@aria-owns,'-sort-field_options')]"));
                ElementClick(PageAction.Find_ElementXPath("//*[contains(@aria-owns,'-sort-field_options')]"));
                Thread.Sleep(3000);
               
                ElementClick(PageAction.Find_ElementXPath("//*[contains(@class,'e-popup-open')]//*[contains(text(),'" + propertyValue + "')]"));
            }
            else if (propertyName.Equals("Direction"))
            {
                Thread.Sleep(3000);
                //WaittillElementDisplay(PageAction.Find_ElementXPath("//*[contains(@aria-owns,'-sort-order_options')]"));
                ElementClick(PageAction.Find_ElementXPath("//*[contains(@aria-owns,'-sort-order_options')]"));
                Thread.Sleep(3000);
                ElementClick(PageAction.Find_ElementXPath("//*[contains(@class,'e-popup-open')]//*[text()='" + propertyValue + "']"));

            }
        }  
        public static void Verifyprofileid(string value)
        {
            Assert.IsTrue(GetText(PageObject_Profiles.Verify_Emailontable()).Contains(value), "Profile id not matches with selected profile name");
            Helper.WaitForAjaxControls(30);
        }

        public static void ClickonProfilerecord()
        {

            ElementClick(PageObject_Profiles.Lnk_clickonProfilerecord());
            Logger.WriteDebugMessage("User click on profile id URl and navigates to View Profile page");
            Helper.WaitForAjaxControls(30);
        }

        public static void ClickonProfilerecordSecondonprofiletable()
        {

            ElementClick(PageObject_Profiles.Lnk_clickonProfilerecordSecond());
            Helper.WaitForAjaxControls(30);
        }

        public static void VerifyViewprofileName(string value)
        {
            Assert.IsTrue(GetText(PageObject_Profiles.Viewprofilerecordonviewpage()).Contains(value), "Profile id not matches with selected profile name");
            Helper.WaitForAjaxControls(30);
        }

        public static void VerifyHome_Present_On_HomepageName(string value)
        {
            Assert.IsTrue(GetText(PageObject_Profiles.Check_Hometext()).Contains(value), "Navigates to Home page after close the Cendyn Help tab");
            Helper.WaitForAjaxControls(30);
        }

        

        public static void VerifyViewreservationid(string value)
        {
            Assert.IsTrue(GetText(PageObject_Profiles.Verifyreservationidinviewreservation()).Contains(value), "Reservation id not matches with selected profile name");
        }

        public static void Clickonreservationstab()
        {
            ElementClickUsingJavascript(PageObject_Profiles.Reservationstab());
            Helper.WaitForAjaxControls(30);
            Logger.WriteDebugMessage("User click on Reservations tab in Profile dashboard page");
        }

        public static void Verifytestpresentonreservations()
        {
            Assert.IsTrue(IsElementDisplayed(PageObject_Profiles.Verifyreservtionrecord()), "Reservation is not displayed selected value");
        }

        public static string Clickonreservationrecordontable()
        {

            string text = GetText(PageObject_Profiles.Reservationrecord());
            ElementClick(PageObject_Profiles.Reservationrecord());

            Helper.WaitForAjaxControls(30);
            return text;
        }

        public static void ClickonApplauncher()
        {
            ElementClick(PageObject_Profiles.Applauncherbutton());
        }

        public static string ClickonProfilerecordonprofilestable()
        {
            Helper.ElementWait(PageObject_Profiles.FirstRecordonprofiletable(), 10);
            string text = GetText(PageObject_Profiles.FirstRecordonprofiletable());
            ElementClick(PageObject_Profiles.FirstRecordonprofiletable());
            Logger.WriteDebugMessage("User click on the 448361759 profile id");
            return text;
        }

        public static void VerifyApplicationsonapplauncher()
        {
            IList<IWebElement> App_Applications = PageObject_Profiles.Applauncherapplicationsonapplauncher();

            foreach (IWebElement ele_Application in App_Applications)
            {
                Assert.IsNotNull(GetText(ele_Application), "Applications are not loaded on app launcher in Starling app");
            }
        }

        public static void VerifyDBValuesInProfilePage(Profile_DB profile)
        {
            VerifyTextOnPageAndHighLight(profile.ExternalProfileId1);
            VerifyTextOnPageAndHighLight(profile.ProfileId);

            string db_DateInserted = profile.DateInserted;
            string db_DateInsertedFormat = DateTime.Parse(db_DateInserted).ToString("MMM dd, yyyy hh:mm:ss tt");
            VerifyTextOnPageAndHighLight(db_DateInsertedFormat);

            string db_DateUpdated = profile.DateUpdated;
            string db_DateUpdatedFormat = DateTime.Parse(db_DateUpdated).ToString("MMM dd, yyyy hh:mm:ss tt");
            VerifyTextOnPageAndHighLight(db_DateUpdatedFormat);
            Logger.WriteDebugMessage("Main section Details fields should match with DB as below  - External profile id - Profile id - Date Inserted - Last updated");
        }       

        public static void VerifyTextOnPageAndHighLight(string text, string xpath)
        {
            if (string.IsNullOrEmpty(text) ||  text.Equals("0"))
            {
                text = "--";
            }
            ElementWaitByLocator(xpath, 30);
            IList<IWebElement> list = Helper.Driver.FindElements(By.XPath(xpath));
            int count = 0;
            foreach (IWebElement value in list)
            {
                if (count == 2)
                    break;
                if (value.Text.Contains(text.Trim()))
                {
                    HighlightElement(value);
                    count++;
                    Logger.WriteInfoMessage(text + " Found on the page");
                }
            }
            if (count == 0)
            {
                Assert.Fail(text + "Text not found");
            }
        }

        public static void VerifyElementOnPageAndHighLight(string xpath)
        {
            ElementWaitByLocator(xpath, 30);
            IList<IWebElement> list = Helper.Driver.FindElements(By.XPath(xpath));
            int count = 0;
            foreach (IWebElement value in list)
            {
                if (count == 2)
                    break;
                if (value.Displayed)
                {
                    HighlightElement(value);
                    count++;
                    Logger.WriteInfoMessage("Element Found on the page");
                }
            }
            if (count == 0)
            {
                Assert.Fail("Element not found");
            }
        }

        public static void VerifyDBValuesInProfilePage_PersonalDetails(Profile_DB profile)
        {
            VerifyTextOnPageAndHighLight(profile.Salutation, GetFieldXpath("Salutation"));
            VerifyTextOnPageAndHighLight(profile.FirstName, GetFieldXpath("First Name"));
            VerifyTextOnPageAndHighLight(profile.FamiliarName, GetFieldXpath("Familiar Name"));
            VerifyTextOnPageAndHighLight(profile.MiddleName, GetFieldXpath("Middle Name"));
            VerifyTextOnPageAndHighLight(profile.LastName, GetFieldXpath("Last Name"));
            VerifyTextOnPageAndHighLight(profile.Nationality, GetFieldXpath("Nationality"));
            VerifyTextOnPageAndHighLight(profile.Suffix, GetFieldXpath("Suffix"));
            VerifyTextOnPageAndHighLight(profile.JobTitle, GetFieldXpath("Job Title"));
            VerifyTextOnPageAndHighLight(profile.PrimaryLanguage, GetFieldXpath("Primary Language"));
            VerifyTextOnPageAndHighLight(profile.GenderCode, GetFieldXpath("Gender Code"));
            Logger.WriteDebugMessage("Personal Details fields should match with DB data as below - FirstName - Last name - Suffix - Job Title - Primary Language - Gender Code - Nationality - Date of Birth ");
        }

        public static void VerifyDBValuesInProfilePage_AddressDetails(Profile_DB profile)
        {

            VerifyTextOnPageAndHighLight(profile.Address1, GetFieldXpath("Address 1"));
            VerifyTextOnPageAndHighLight(profile.Address2, GetFieldXpath("Address 2"));
            VerifyTextOnPageAndHighLight(profile.StateProvince, GetFieldXpath("State/Province"));
            VerifyTextOnPageAndHighLight(profile.City, GetFieldXpath("City"));
            VerifyTextOnPageAndHighLight(profile.PostalCode, GetFieldXpath("Postal Code"));
            VerifyTextOnPageAndHighLight(profile.CountryCode, GetFieldXpath("Country"));
            //VerifyTextOnPageAndHighLight(profile.IsPrimary, GetFieldXpath("Primary Address"));
            VerifyTextOnPageAndHighLight(profile.AddressLanguage, GetFieldXpath("Address Language"));

            //string db_DateInserted = profile.DateInserted;
            //string db_DateInsertedFormat = DateTime.Parse(db_DateInserted).ToString("MMM dd, yyyy hh:mm:ss tt");
            //VerifyTextOnPageAndHighLight(db_DateInsertedFormat);

            //string db_DateUpdated = profile.DateUpdated;
            //string db_DateUpdatedFormat = DateTime.Parse(db_DateUpdated).ToString("MMM dd, yyyy hh:mm:ss tt");
            //VerifyTextOnPageAndHighLight(db_DateUpdatedFormat);
            Logger.WriteDebugMessage("Personal Details fields should match with DB as below - Address1 - State / Province - City - Postal Code - Country - Address Language - Primary Address - Record Status - Inserted - Last updated");
        }

        public static void VerifyDBValuesIncontacrdetails1(string attributeName, string attributeValue)
        {
            string elementXpath;
            if (attributeValue.Equals("True") || attributeValue.Equals("1"))
            {
                elementXpath = GetFieldXpath_CheckIcon(attributeName);
            }
            else if (attributeValue.Equals("False") || attributeValue.Equals("0"))
            {
                elementXpath = GetFieldXpath_CrossIcon(attributeName);
            }
            else
            {
                elementXpath = GetFieldXpath_CheckEmpty(attributeName);
            }
            VerifyElementOnPageAndHighLight(elementXpath);
        }

        public static void VerifyDBValuesInProfilePage_CommnicationPreference(Profile_DB profile)
        {
            foreach (KeyValuePair<string, int> entry in profile.AttributeNames_Values)
            {
                string attributeName = entry.Key;
                int intergerValue = entry.Value;
                string elementXpath = null;
                if (intergerValue == 1)
                {
                    elementXpath = GetFieldXpath_CheckIcon(attributeName);
                }
                else if (intergerValue == 0)
                {
                    elementXpath = GetFieldXpath_CrossIcon(attributeName);
                }
                else
                {
                    elementXpath = GetFieldXpath_CheckEmpty(attributeName);
                }
                VerifyElementOnPageAndHighLight(elementXpath);

            }
        }

        /// <summary>
        /// This method will Check the list of profiles in the first page of the table.
        /// </summary>
        /// <param name="lst_ProfileDb"></param>
        public static void Verify_Res_TableData(List<Profile_DB> lst_ProfileDb)
        {
            for (int i = 0; i < lst_ProfileDb.Count; i++)
            {
                Profile_DB profileDb = lst_ProfileDb[i];
                string propertyAccountId = profileDb.PropertyAccountId;

                VerifyTextOnPageAndHighLight(propertyAccountId, "//table[@class='e-table']//tr[" + (i + 1) + "]/td[1]");
                Logger.WriteDebugMessage("User verify the ExternalReservation id is " + propertyAccountId + " ");
            }
        }

        public static void VerifyDBValuesInProfilePage_ExternalMembershipid(Profile_DB profile)
        {
            VerifyTextOnPageAndHighLight(profile.CustomerMembershipID, GetFieldXpath("Membership"));
        }

        public static void VerifyDBValuesInProfilePage_MembershipwithVIPCodeandVIPId(Profile_DB profile)
        {
            VerifyTextOnPageAndHighLight(profile.VIPID, GetFieldXpath("VIP ID"));
            VerifyTextOnPageAndHighLight(profile.VIPCode, GetFieldXpath("VIP Code"));
            Logger.WriteDebugMessage("Memberships Details should match with DB as below fields - Membership - VIP Code - VIP ID");
        }

        public static void VerifyDBValuesInContactDetailsPage(Profile_DB cmdata)
        {
            VerifyTextOnPageAndHighLight(cmdata.CMData, GetFieldXpath("Value"));
            //VerifyTextOnPageAndHighLight(cmdata.CMOptOut, GetFieldXpath("Opt Out"));
            VerifyDBValuesIncontacrdetails1("Opt Out", cmdata.CMOptOut);
            //VerifyDBValuesIncontacrdetails1("Primary IP", cmdata.IsPrimary);

            //VerifyTextOnPageAndHighLight(cmdata.IsPrimary, GetFieldXpath("Primary Email"));

            string db_DateInserted = cmdata.DateInserted;
            string db_DateInsertedFormat = DateTime.Parse(db_DateInserted).ToString("MMM dd, yyyy hh:mm:ss tt");
            VerifyTextOnPageAndHighLight(db_DateInsertedFormat);

            string db_DateUpdated = cmdata.DateUpdated;
            string db_DateUpdatedFormat = DateTime.Parse(db_DateUpdated).ToString("MMM dd, yyyy hh:mm:ss tt");
            VerifyTextOnPageAndHighLight(db_DateUpdatedFormat);
            Logger.WriteDebugMessage("Contact Details fields should match with DB as below  - Value " + cmdata.CMData + " - CMOptOut " + cmdata.CMOptOut + " - IsPrimary " + cmdata.IsPrimary + " - Date Inserted " + cmdata.DateInserted + " - Last updated " + cmdata.DateUpdated + " ");
        }

        public static void VerifyDBValuesInReservationsPage_MainResDetails(Reservation_DB reservation)
        {
            VerifyTextOnPageAndHighLight(reservation.ExternalResID1.ToString(), GetFieldXpath("Reservation ID"));          
            VerifyTextOnPageAndHighLight(reservation.ConfirmationNum, GetFieldXpath(" Confirmation Number "));
            Logger.WriteDebugMessage("Main Reservation Details fields should match with DB data as below - Reservation ID - Confirmation Number - Arrival - Departure - Nights - Adults - Children - Rooms - DateInserted - DateUpdated ");
        }

        public static void VerifyDBValuesInReservationsPage_MainResDetails_Room(Reservation_DB reservation)
        {           
            string db_ResArriveDate = reservation.ResArriveDate;
            string db_ResArriveDateFormat = DateTime.Parse(db_ResArriveDate).ToString("MMM dd, yyyy");
            VerifyTextOnPageAndHighLight(db_ResArriveDateFormat, GetFieldXpath_Table("Arrival"));

            string db_ResDepartDate = reservation.ResDepartDate;
            string db_ResDepartDateFormat = DateTime.Parse(db_ResDepartDate).ToString("MMM dd, yyyy");
            VerifyTextOnPageAndHighLight(db_ResDepartDateFormat, GetFieldXpath_Table("Departure"));

            VerifyTextOnPageAndHighLight(reservation.TotalRoomNights, GetFieldXpath_Table("Nights"));
            VerifyTextOnPageAndHighLight(reservation.NumAdults, GetFieldXpath_Table("Adults"));
            VerifyTextOnPageAndHighLight(reservation.NumChildren, GetFieldXpath_Table("Children"));
            VerifyTextOnPageAndHighLight(reservation.NumRooms, GetFieldXpath_Table("Rooms"));


            Logger.WriteDebugMessage("Main Reservation Details fields should match with DB data as below - FirstName - Last name - Suffix - Job Title - Primary Language - Gender Code - Nationality - Date of Birth ");
        }

        public static void VerifyDBValuesInReservationsPage_GuestDetails(Reservation_DB reservation)
        {
            //VerifyTextOnPageAndHighLight(reservation.ExternalProfileId1, GetFieldXpath("Total Room"));
            VerifyTextOnPageAndHighLight(reservation.ExternalResID1.ToString(), GetFieldXpath_Table("Profile Id"));
            

            //if (!string.IsNullOrEmpty(reservation.FirstName) && string.IsNullOrEmpty(reservation.LastName))
            //{
            //    VerifyTextOnPageAndHighLight(reservation.FirstName, GetFieldXpath_Table("Full Name"));
            //    VerifyTextOnPageAndHighLight(reservation.LastName, GetFieldXpath_Table("Full Name"));                
            //}

            //VerifyTextOnPageAndHighLight(reservation.IsPrimary, GetFieldXpath("Primary"));

            Logger.WriteDebugMessage("Guest Details fields should match with DB data as below - FirstName - Last name - Suffix - Job Title - Primary Language - Gender Code - Nationality - Date of Birth ");
        }

        public static void VerifyDBValuesInReservationsPage_StayDetails(Reservation_DB reservation)
        {           
            string db_StayDate = reservation.StayDate;
            string db_StayDateFormat = DateTime.Parse(db_StayDate).ToString("MMM dd, yyyy");
            VerifyTextOnPageAndHighLight(db_StayDateFormat, GetFieldXpath_Table("Stay Date"));

            VerifyTextOnPageAndHighLight(reservation.SourceRoomType, GetFieldXpath_Table("Room Type"));
            VerifyTextOnPageAndHighLight(reservation.SourceRateType, GetFieldXpath_Table("Rate Type"));
            VerifyTextOnPageAndHighLight(reservation.CurrencyCode, GetFieldXpath_Table("Currency"));
            
            string db_DailyRate = reservation.DailyRate;
            string db_DailyRateFormat = Convert.ToInt32(Convert.ToDouble(db_DailyRate)).ToString();
            VerifyTextOnPageAndHighLight(db_DailyRateFormat, GetFieldXpath_Table("Daily Rate"));

            VerifyTextOnPageAndHighLight(reservation.MarketSegmentCode, GetFieldXpath_Table("Market Segment"));
            VerifyTextOnPageAndHighLight(reservation.ResSourceCode, GetFieldXpath_Table("Source Of Business"));
            VerifyTextOnPageAndHighLight(reservation.ChannelCode, GetFieldXpath_Table("Channel Code"));            
           
            string db_DateInserted = reservation.DateInserted;
            string db_DateInsertedFormat = DateTime.Parse(db_DateInserted).ToString("MMM dd, yyyy");
            VerifyTextOnPageAndHighLight(db_DateInsertedFormat, GetFieldXpath_Table("Inserted"));

            string db_DateUpdated = reservation.DateUpdated;
            string db_DateUpdatedFormat = DateTime.Parse(db_DateUpdated).ToString("MMM dd, yyyy");
            VerifyTextOnPageAndHighLight(db_DateUpdatedFormat, GetFieldXpath_Table("Last Updated"));
            Logger.WriteDebugMessage("Stay Details fields should match with DB data as below - Stay Date - SourceRoomType - SourceRateType - CurrenyCode - DailyRate - MarketCode - ResSourceCode ");
        }

        public static void VerifyDBValuesInReservationsPage_TransactionDetails(Profile_DB profile)
        {
            VerifyTextOnPageAndHighLight(profile.Salutation, GetFieldXpath("Salutation"));
            
            Logger.WriteDebugMessage("Transaction Details fields should match with DB data as below - FirstName - Last name - Suffix - Job Title - Primary Language - Gender Code - Nationality - Date of Birth ");
        }

        public static void VerifyDBValuesInReservationsPage_PackageDetails(Profile_DB profile)
        {
            VerifyTextOnPageAndHighLight(profile.Salutation, GetFieldXpath("Salutation"));
            
            Logger.WriteDebugMessage("Package Details fields should match with DB data as below - FirstName - Last name - Suffix - Job Title - Primary Language - Gender Code - Nationality - Date of Birth ");
        }

        public static void VerifyDBValuesInReservationsPage_RevenueDetails(Reservation_DB reservation)
        {
            VerifyTextOnPageAndHighLight(reservation.TotalRoomRevenue, GetFieldXpath("Total Room"));
            VerifyTextOnPageAndHighLight(reservation.TotalOtherRevenue, GetFieldXpath("Total Other"));
            VerifyTextOnPageAndHighLight(reservation.TotalTax, GetFieldXpath("Total Tax"));
            VerifyTextOnPageAndHighLight(reservation.TotalFees, GetFieldXpath("Total Fees"));
            VerifyTextOnPageAndHighLight(reservation.TotalRevenue, GetFieldXpath("Total Revenue"));
            
            Logger.WriteDebugMessage("Revenue Details fields should match with DB data as below - TotalRoom - Total Other - Total Tax - Total Fees - Total Revenue ");
        }

        public static void VerifyDBValuesInReservationsPage_PoliciesDetails(Reservation_DB reservation)
        {
            VerifyTextOnPageAndHighLight(reservation.GuaranteedByCode, GetFieldXpath(" Guaranteed by Code "));
            VerifyTextOnPageAndHighLight(reservation.MethodOfPayment, GetFieldXpath(" Method of Payment "));
            VerifyTextOnPageAndHighLight(reservation.RateConfidential, GetFieldXpath(" Rate Confidential "));
            VerifyTextOnPageAndHighLight(reservation.DiscountCode, GetFieldXpath(" Discount Code "));
            VerifyTextOnPageAndHighLight(reservation.DiscountAmount, GetFieldXpath(" Discount Amount "));
            VerifyTextOnPageAndHighLight(reservation.DiscountPercent, GetFieldXpath(" Discount Percent "));
            VerifyTextOnPageAndHighLight(reservation.DiscountReasonCode, GetFieldXpath(" Discount Reason Code "));
            //VerifyTextOnPageAndHighLight(reservation.IsNotRefundable, GetFieldXpath("Salutation"));
            //VerifyTextOnPageAndHighLight(reservation.ApplyTax, GetFieldXpath(" Apply Tax "));
            Logger.WriteDebugMessage("Policies Details fields should match with DB data as below - GuaranteedByCode - MethodOfPayment - RateConfidential - DiscountCode - DiscountAmount - DiscountPercent - DiscountReasonCode - ApplyTax ");
        }        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservation"></param>
        public static void VerifyDBValuesInReservationsPage_AssociatedProfileDetails(Reservation_DB reservation)
        {
            VerifyTextOnPageAndHighLight(reservation.CompanyCode, GetFieldXpath(" Company Code "));
            VerifyTextOnPageAndHighLight(reservation.CompanyName, GetFieldXpath(" Company Name "));
            VerifyTextOnPageAndHighLight(reservation.TravelAgentCode, GetFieldXpath(" Travel Agent Code "));
            VerifyTextOnPageAndHighLight(reservation.TravelAgentName, GetFieldXpath(" Travel Agent Name "));
            Logger.WriteDebugMessage("AssociatedProfile Details fields should match with DB data as below - CompanyCode - CompanyName - TravelAgentCode - TravelAgentName ");
        }

        /// <summary>
        /// This method will Check the list of accounts to select the Org.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static string GetFieldXpath(string fieldName)
        {
            string fieldXpath = "//div[contains(text(),'" + fieldName + "')]//parent::li//span";

            return fieldXpath;
        }

        public static string GetFieldXpath_Table(string fieldName)
        {
            string fieldXpath = "//*[contains(text(),'"+ fieldName + "')]//following::tr[@role='row']/td[contains(@aria-label,'"+ fieldName + "')]";

            return fieldXpath;
        }

        /// <summary>
        /// This method will Check the list of accounts to select the Org.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static string GetFieldXpath_CrossIcon(string fieldName)
        {
            fieldName = GetFieldUIName(fieldName);
            string fieldXpath = "//div[contains(text(),'" + fieldName + "')]/parent::li//*[name()='svg' and @class='base-icon x']";

            return fieldXpath;
        }

        public static string GetFieldXpath_CheckIcon(string fieldName)
        {
            fieldName = GetFieldUIName(fieldName);
            string fieldXpath = "//div[contains(text(),'" + fieldName + "')]/parent::li//*[name()='svg' and @class='base-icon check']";

            return fieldXpath;
        }

        public static string GetFieldXpath_CheckEmpty(string fieldName)
        {
            fieldName = GetFieldUIName(fieldName);
            string fieldXpath = "//div[contains(text(),'" + fieldName + "')]/parent::li//*[contains(text(),'--')]";

            return fieldXpath;
        }

        public static string GetFieldUIName(string fieldNameDB)
        {
            string fieldName = null;
            if (fieldNameDB.Equals("GuestPriv"))
            {
                fieldName = "Guest Priv";
            }
            else if (fieldNameDB.Equals("AllowMail"))
            {
                fieldName = "Allow Mail";
            }
            else if (fieldNameDB.Equals("AllowEMail"))
            {
                fieldName = "Allow Email";
            }
            else if (fieldNameDB.Equals("AllowPhone"))
            {
                fieldName = "Allow Phone";
            }
            else if (fieldNameDB.Equals("AllowSMS"))
            {
                fieldName = "Allow SMS";
            }
            else if (fieldNameDB.Equals("AllowHistory"))
            {
                fieldName = "Allow History";
            }
            else if (fieldNameDB.Equals("AllowMarketResearch"))
            {
                fieldName = "Allow Market Research";
            }
            else if (fieldNameDB.Equals("AllowThirdParty"))
            {
                fieldName = "Allow Third Party";
            }
            else if (fieldNameDB.Equals("AllowLoyaltyProgram"))
            {
                fieldName = "Allow Loyalty Program";
            }
            else
            {
                fieldName = fieldNameDB;
            }

            return fieldName;
        }

        public static void EnterFilterValues(string filterOption, string filterType, string value)
        {
            IList<IWebElement> options = null;
            string filterTypeInputXpath = "//small[contains(text(),'" + filterOption + "')]/parent::*/following-sibling::div/descendant::span";
            string filterValueInputXpath = "//small[contains(text(),'" + filterOption + "')]/parent::*/following::input[@placeholder='Enter a value']";
            if (filterOption.Equals("ID") || filterOption.Equals("Name") || filterOption.Equals("Property Id")
                || filterOption.Equals("Audience") || filterOption.Equals("Updated By"))
            {
                Helper.ElementClick(Helper.Driver.FindElement(By.XPath(filterTypeInputXpath)));
                for (int i = 0; i < 5; i++) { options = PageObject_ManageCampaign.Campaign_Filter_DropDown_FilterOptions(); }
                foreach (var item in options)
                {
                    if (item.Text.Equals(filterType))
                    {
                        item.Click();
                        break;
                    }
                }
                //Helper.ElementClick(PageObject_ManageCampaign.Campaign_Filter_ID_Text());
                Helper.ElementWait(Helper.Driver.FindElement(By.XPath(filterValueInputXpath)), 10);
                if (value.Length > 200)
                    value = value.Substring(0, 20);
                Helper.ElementEnterText(Helper.Driver.FindElement(By.XPath(filterValueInputXpath)), value.Trim());
            }
            else if (filterOption.Equals("Status"))
            {
                Helper.ElementClick(Helper.Driver.FindElement(By.XPath(filterTypeInputXpath)));
                for (int i = 0; i < 5; i++) { options = PageObject_ManageCampaign.Campaign_Filter_DropDown_FilterOptions(); }
                foreach (var item in options)
                {
                    if (item.Text.Equals(filterType))
                    {
                        item.Click();
                        break;
                    }
                }
                //Helper.ElementClick(PageObject_ManageCampaign.Campaign_Filter_ID_Text());
                //Helper.ElementWait(PageObject_ManageCampaign.Campaign_Filter_Status_DropDown_Arrow(), 10);
                Helper.ElementClick(PageObject_ManageCampaign.Campaign_Filter_Status_DropDown_Arrow());
                //Helper.ElementEnterText(PageObject_ManageCampaign.Campaign_Filter_Status_DropDown_Input(), value);
                IList<IWebElement> statusOption = null;
                Helper.WaitForAjaxControls(50);
                for (int i = 0; i < 5; i++) { statusOption = PageObject_ManageCampaign.Campaign_Filter_Status_DropDown_Options(); }
                foreach (var item in statusOption)
                {
                    if (item.Text.Equals(value))
                    {
                        Helper.ElementWait(item, 5);
                        Helper.ElementClick(item);
                        break;
                    }
                }
                Helper.ElementClick(PageObject_ManageCampaign.Campaign_Filter_ID_Text());
            }
            if (filterOption.Equals("Updated On") || filterOption.Equals("Check In"))
            {
                Helper.ElementClick(Helper.Driver.FindElement(By.XPath(filterTypeInputXpath)));
                for (int i = 0; i < 5; i++) { options = PageObject_ManageCampaign.Campaign_Filter_DropDown_FilterOptions(); }
                foreach (var item in options)
                {
                    if (item.Text.Equals(filterType))
                    {
                        item.Click();
                        break;
                    }
                }
                Helper.ElementClick(PageObject_ManageCampaign.Campaign_Filter_ID_Text());
                var date = Convert.ToDateTime(value).ToString("MMM dd, yyyy");
                Helper.ElementEnterText(PageObject_ManageCampaign.Campaign_Filter_UpdatedOn_Input(), date);
                Helper.ElementClick(PageObject_ManageCampaign.Campaign_Filter_ID_Text());
            }
        }

    }
}


