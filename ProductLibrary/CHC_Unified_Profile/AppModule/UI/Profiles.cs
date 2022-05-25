using BaseUtility.PageObject;
using BaseUtility.Utility;
using CHC_Unified_Profile.Entity;
using CHC_Unified_Profile.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;

namespace CHC_Unified_Profile.AppModule.UI
{
    public class Profile : Helper
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

        public static void Click_Unified_ProfileApp()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_Profiles.Ele_UnifiedProfileApp());
            Logger.WriteDebugMessage("User clicked on Unified Profile page");
        }

        public static void ClickonSortbutton()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_Profiles.Btn_Sort());
            //Logger.WriteDebugMessage("Sort popup displayed with Clear and Choose buttons");
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

        /// <summary>
        /// This method will Check the Profile - Headers in a unified profile table
        /// </summary>
        public static void Verify_TableHeaders()
        {
            string[] tableHeaders = { "Res. No", "Property Name", "Revenue", "Guests", "Status", "Arrival Date","Departure Date" };
            IList<IWebElement> lst_TableHeaders = PageObject_Profiles.AllColumns_OnTable();

            for(int i = 0; i < lst_TableHeaders.Count-1; i++)
            {
               if(Helper.GetText(lst_TableHeaders[i]).ToLower().Equals(tableHeaders[i].ToLower())){
                    Logger.WriteInfoMessage("Table Header columns matched successfully " + tableHeaders[i] );
                    Logger.WriteDebugMessage("Table Header columns " + tableHeaders[i] );
                }
                else
                {
                    Logger.WriteInfoMessage("Table Header columns not matched successfully " + tableHeaders[i]);
                    Logger.WriteDebugMessage("Table Header columns not matches");
                }
            }            
        }
        
        //public static void Verify_AllColumns_onTable()
        //{
        //    ElementClick(PageObject_Profiles.Ele_ViewProfile());
        //    Logger.WriteDebugMessage("View Profile page should display");
        //    Helper.WaitForAjaxControls(30);
        //}

        public static void Click_OnEllipse_OnRes_table()
        {
            ElementClick(PageObject_Profiles.Click_Ellipse());
            Logger.WriteDebugMessage("User Clicked on Ellipse and should view the More details of reservation");
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

            if (tableRows != null && tableRows.Count > 0)
            {
                foreach (IWebElement tableRow in tableRows)
                {
                    Assert.IsTrue(GetText(tableRow).Contains(filterValue));
                }
            }
            else
            {
                Logger.WriteDebugMessage("No records display for filter value " + filterValue + " Field " + field);
            }
        }

        public static void View_ContactDetails()
        {
            ElementClick(PageObject_Profiles.ContactDetailstab());
            Logger.WriteDebugMessage("User lands on Profile related Contact Details page");
            Helper.WaitForAjaxControls(30);
        }

        public static void ClickOn_ViewProfile_ContactDetailsTab()
        {
            Helper.ElementWait(PageObject_Profiles.View_Profile_ContactDetailstab(), 10);
            ElementClick(PageObject_Profiles.View_Profile_ContactDetailstab());
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
            //Logger.WriteDebugMessage("User Click on Apply button on Sort tab & Should display the data based on Search");
            Helper.WaitForAjaxControls(30);
        }

        public static void Clickon_ViewProfile_HistoryTab()
        {
            Helper.ElementWait(PageObject_Profiles.View_Profile_Historytab(), 10);
            ElementClick(PageObject_Profiles.View_Profile_Historytab());
            Logger.WriteDebugMessage("User Click on History tab");
            Helper.WaitForAjaxControls(30);
        }
        
        public static void Clickon_Apply_Button_on_Filter()
        {            
            ElementClick(PageObject_Profiles.Btn_Click_on_Applybutton_Filter());
            Logger.WriteDebugMessage("User Clicked on Apply button on filter");
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
            Logger.WriteDebugMessage("User enter the profileid " + profileid );
            //ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

            Helper.WaitForAjaxControls(30);
        }

        public static string GetPropertyLocatorName(string propertyName)
        {
            if (propertyName.Equals("Profile Id"))
            {
                propertyName = "ProfileId";
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
                propertyName = "sourceName";
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
            if (propertyName.Equals("Property Id") || propertyName.Equals("Profile Id"))
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
                //Logger.WriteDebugMessage("User select the "+propertyValue+" from Order By drop down");
            }
            else if (propertyName.Equals("Direction"))
            {
                Thread.Sleep(3000);
                //WaittillElementDisplay(PageAction.Find_ElementXPath("//*[contains(@aria-owns,'-sort-order_options')]"));
                ElementClick(PageAction.Find_ElementXPath("//*[contains(@aria-owns,'-sort-order_options')]"));
                Thread.Sleep(3000);
                ElementClick(PageAction.Find_ElementXPath("//*[contains(@class,'e-popup-open')]//*[text()='" + propertyValue + "']"));
                //Logger.WriteDebugMessage("User select the " + propertyValue + " from Direction drop down");
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
            Logger.WriteDebugMessage("User click on Profile id URl and navigates to View Profile page");
            Helper.WaitForAjaxControls(30);
        }

        public static void ClickonNeedhelp()
        {
            ElementClick(PageObject_Profiles.Lnk_NeedHelp());
            Logger.WriteDebugMessage("User clicked on Need Help Signin Link");
            Helper.WaitForAjaxControls(30);
        }

        public static void ClickonForgot()
        {
            ElementClick(PageObject_Profiles.Lnk_Forgot());
            Logger.WriteDebugMessage("User clicked on Forgot Password Link and Navigates to Reset Password page");
            Helper.WaitForAjaxControls(30);
        }

        public static void EnterRecovery_Email(string email)
        {
            ElementEnterText(PageObject_Profiles.Lnk_Recovery(), email);
            Logger.WriteDebugMessage("User entered Recovery email");
            Helper.WaitForAjaxControls(30);
        }        

        public static void Clickon_ResetviaEmail()
        {
            ElementClick(PageObject_Profiles.Lnk_Reset());
            Logger.WriteDebugMessage("User clicked on Reset via Email button");
            Helper.WaitForAjaxControls(30);
        }

        public static void Clickon_BacktoSignin()
        {
            ElementClick(PageObject_Profiles.Lnk_Backtosignin());
            Logger.WriteDebugMessage("User clicked on Back to Signin button and navigates to Signin/Login page");
            Helper.WaitForAjaxControls(30);
        }
        
        public static void Enter_ResetPassword()
        {
            ElementClick(PageObject_Profiles.Btn_Resetpassword());
            Logger.WriteDebugMessage("User entered New Password");
            Helper.WaitForAjaxControls(30); 
        }

        public static void Enter_NewPassword(string password)
        {
            ElementEnterText(PageObject_Profiles.Txt_Newpassword(), password);            
            Logger.WriteDebugMessage("User entered New Password");
            Helper.WaitForAjaxControls(30); 
        }

        public static void Enter_ConfirmationPassword(string password)
        {
            ElementEnterText(PageObject_Profiles.Txt_ConfirmPassword(), password);
            Logger.WriteDebugMessage("User entered Confirmation Password");
            Helper.WaitForAjaxControls(30); 
        }

        public static void Clickon_ResetPasswordbutton()
        {
            ElementClick(PageObject_Profiles.Lnk_Resetpassword());
            Logger.WriteDebugMessage("User clicked on Reset Password");
            Helper.WaitForAjaxControls(30); 
        }

        public static void Enter_Unlock_Username(string email)
        {
            ElementEnterText(PageObject_Profiles.Txt_UnlockUsername(), email);
            Logger.WriteDebugMessage("User entered Confirmation Password");
            Helper.WaitForAjaxControls(30);
        }

        public static void Clickon_Unlock_SendEmail()
        {
            ElementClick(PageObject_Profiles.Lnk_Unlock_SendEmail());
            Logger.WriteDebugMessage("User clicked on Reset Password");
            Helper.WaitForAjaxControls(30); 
        }

        public static void Clickon_Outlook_Unlock_Account()
        {
            ElementClick(PageObject_Profiles.Lnk_Clcikon_Outlook_UnlockAccount());
            Logger.WriteDebugMessage("User clicked on Reset Password");
            Helper.WaitForAjaxControls(30); 
        }
        

        public static void Clickon_SignIn_Unlock_Account() 
        {
            ElementClick(PageObject_Profiles.Lnk_Clcikon_SignIn_UnlockAccount());
            Logger.WriteDebugMessage("User clicked on Reset Password");
            Helper.WaitForAjaxControls(30); 
        }

        public static void Verify_LinkExpired(string value)
        {
            Assert.IsTrue(GetText(PageObject_Profiles.Lnk_LinkExpired()).Contains(value), "");
            Logger.WriteDebugMessage("User clicked on Reset Password");
            Helper.WaitForAjaxControls(30); 
        }

        public static void Verify_EmailBlank_Validation(string value)
        {
            Assert.IsTrue(GetText(PageObject_Profiles.Txt_Email_LeaveBlank()).Contains(value), "");
            Logger.WriteDebugMessage("User clicked on Reset Password");
            Helper.WaitForAjaxControls(30);
        }

        public static void Verify_TextPresent(string value)
        {
            Assert.IsTrue(GetText(PageObject_Profiles.Txt_OutLook()).Contains(value), "");
            Logger.WriteDebugMessage("User clicked on Reset Password");
            Helper.WaitForAjaxControls(30);
        }

        public static void ClickonProfilerecordSecondonprofiletable()
        {
            ElementClick(PageObject_Profiles.Lnk_clickonProfilerecordSecond());
            Helper.WaitForAjaxControls(30);
        }

        public static void VerifyViewprofileName(string value)
        {
            Assert.IsTrue(GetText(PageObject_Profiles.Viewprofilerecordonviewpage()).Contains(value), "Profile Name not matches with selected profile Id");
            Helper.WaitForAjaxControls(30);
        }

        public static void Verify_SigiIN_Text(string value)
        {
            Assert.IsTrue(GetText(PageObject_SignIn.Login_Signin_Text()).Contains(value), "SigIn text is not present");
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
            Helper.ElementWait(PageObject_Profiles.Reservationstab(), 10);
            ElementClickUsingJavascript(PageObject_Profiles.Reservationstab());
            Helper.WaitForAjaxControls(30);
            Logger.WriteDebugMessage("User click on Reservations tab in View Profile page");
        }        

        public static void Verifytestpresentonreservations()
        {
            Assert.IsTrue(IsElementDisplayed(PageObject_Profiles.Verifyreservtionrecord()), "Reservation is not displayed selected value");
        }

        public static void VerifytestpresentonViewProfile()
        {
            Assert.IsTrue(IsElementDisplayed(PageObject_Profiles.Txt_Summary_ChecktextonViewProfile()), "Summary tab is not displayed in view profile");
            Logger.WriteDebugMessage("Summary tabs is presented in view profile page");
            Assert.IsTrue(IsElementDisplayed(PageObject_Profiles.Txt_ContactDetails_ChecktextonViewProfile()), "ContactDetails tab is not displayed in view profile");
            Logger.WriteDebugMessage("Contact Details tabs is presented in view profile page");
            Assert.IsTrue(IsElementDisplayed(PageObject_Profiles.Txt_Profile_ChecktextonViewProfile()), "Profile tab is not displayed in view profile");
            Logger.WriteDebugMessage("Profile tabs is presented in view profile page");
            Assert.IsTrue(IsElementDisplayed(PageObject_Profiles.Txt_Reservation_ChecktextonViewProfile()), "Reservation tab is not displayed in view profile");
            Logger.WriteDebugMessage("Reservations tabs is presented in view profile page");
            Assert.IsTrue(IsElementDisplayed(PageObject_Profiles.Txt_History_ChecktextonViewProfile()), "History tab is not displayed in view profile");
            Logger.WriteDebugMessage("History tabs is presented in view profile page");
            Logger.WriteDebugMessage("Summary - Contact details - Profile - Reservations - History tabs are presented in view profile page");
        }
        
        public static void VerifyStatustestpresentonReservationindex()
        {
            Assert.IsTrue(IsElementDisplayed(PageObject_Profiles.Txt_Status_Checktextonreservationindex()), "Status text not displayed in Reservation index page");
            Logger.WriteDebugMessage("Status text displayed in Reservation index page");
        } //h1[@class='header-title']     

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
            Helper.ElementWait(PageObject_Profiles.Lnk_clickonProfilerecord(), 10);
            string text = GetText(PageObject_Profiles.Lnk_clickonProfilerecord());
            ElementClick(PageObject_Profiles.Lnk_clickonProfilerecord());
            Logger.WriteDebugMessage("User click on the "+ text + " profile id URL");
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

        /// <summary>
        /// This method will Check the Details in column wise data with DB values.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static string GetFieldXpath(string fieldName)
        {
            string fieldXpath = "//div[contains(text(),'" + fieldName + "')]//parent::li//span";

            return fieldXpath;
        }

        /// <summary>
        /// This method will Check the Details in ellipse column wise data with DB values.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static string GetFieldXpath_Ellipse(string fieldName)
        {
            string fieldXpath = "//div[contains(text(), '" + fieldName + "')]//parent::div//following-sibling::div/div";
            //string fieldXpath = "//div[contains(text(),'" + fieldName + "')]//parent::li//span";

            return fieldXpath;
        }
        
        /// <summary>
        /// This method will Check the Details in table view data with DB values.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static string GetFieldXpath_Table(string fieldName)
        {
            string fieldXpath = "//h4[contains(text(),'"+ fieldName+"')]//parent::div//following-sibling::div[@class='card-body']";

            return fieldXpath;
        }

        /// <summary>
        /// This method will Check the Profile - Details of Main Section on view profile page - data with DB values.
        /// </summary>
        /// <param name="profile"></param>
        public static void VerifyDBValuesInUnifiedProfile_MainSection(Profile_DB profile)
        {
            VerifyTextOnPageAndHighLight(profile.ProfileId, GetFieldXpath(" Guest ID "));
            VerifyTextOnPageAndHighLight(profile.CMData, GetFieldXpath(" Email "));

            Logger.WriteDebugMessage("Main section Details fields should match with DB as below  - " +
                "Profile id " + profile.ProfileId + "" +
                "- CMDate(Email) " + profile.CMData + "");
        }

        /// <summary>
        /// This method will Check the Profile - Details of Main Section on view profile page - data with DB values.
        /// </summary>
        /// <param name="profile"></param>
        public static void VerifyDBValuesInUnifiedProfile_Ellipse(Profile_DB profile)
        {
            VerifyTextOnPageAndHighLight(profile.ConfirmationNum, GetFieldXpath_Ellipse(" Sub Res Number "));                     
            VerifyTextOnPageAndHighLight(DateTime.Parse(profile.DateInserted).ToString("MMM dd, yyyy"), GetFieldXpath_Ellipse(" Booked Date "));         
            VerifyTextOnPageAndHighLight(DateTime.Parse(profile.CancellationDate).ToString("MMM dd, yyyy"), GetFieldXpath_Ellipse(" Cancellation Date "));
            VerifyTextOnPageAndHighLight(profile.RateCode, GetFieldXpath_Ellipse(" Rate Code "));
            VerifyTextOnPageAndHighLight(profile.MarketCodeCategory, GetFieldXpath_Ellipse(" Market Segment "));
            VerifyTextOnPageAndHighLight(profile.ResSourceCode, GetFieldXpath_Ellipse(" Source Of Business "));
            VerifyTextOnPageAndHighLight(profile.ChannelCode, GetFieldXpath_Ellipse(" Channel "));
            VerifyTextOnPageAndHighLight(profile.RoomTypeCode, GetFieldXpath_Ellipse(" Room Type "));
            VerifyTextOnPageAndHighLight(Convert.ToInt32(Convert.ToDouble(profile.TotalRoomRevenue)).ToString(), GetFieldXpath_Ellipse(" Room Revenue "));            
            VerifyTextOnPageAndHighLight(Convert.ToInt32(Convert.ToDouble(profile.TotalFBRevenue)).ToString(), GetFieldXpath_Ellipse(" F&B Revenue "));
            VerifyTextOnPageAndHighLight(Convert.ToInt32(Convert.ToDouble(profile.TotalOtherRevenue)).ToString(), GetFieldXpath_Ellipse(" Other Revenue "));
            VerifyTextOnPageAndHighLight(profile.ExternalResID1, GetFieldXpath_Ellipse(" BE Res Number "));

            Logger.WriteDebugMessage("Ellipse Details fields should match with DB as below  - " +
                " Sub Res Number " + " - " +  profile.ConfirmationNum  + " , " +
                " Booked Date " + " - " + profile.DateInserted + " , " +
                " Rate Code " + " - " + profile.RateCode + " , " +
                " Market Segment " + " - " + profile.MarketCodeCategory + " , " +
                " Source Of Business " + " - " + profile.ResSourceCode + ",  " +
                " Channel " + " - " + profile.ChannelCode + ",  " +
                " Room Revenue " + " - " + profile.TotalRoomRevenue + " , " +
                " Room Type " + " - " + profile.RoomTypeCode + " , " +
                " F&B Revenue " + " - " + profile.TotalFBRevenue + " , " +
                " Other Revenue " + " - " + profile.TotalOtherRevenue + " , " +
                " BE Res Number " + " - " + profile.ExternalResID1
                );
        }
        
        /// <summary>
        /// This method will Check the Profile - Details of Email Section on view profile page - data with DB values.
        /// </summary>
        /// <param name="profile"></param>
        public static void VerifyDBValuesInUnifiedProfile_ContactDetails_EmailSection(Profile_DB profile)
        {            
            VerifyTextOnPageAndHighLight(profile.CMData, GetFieldXpath_Table(" Email "));          
            Logger.WriteDebugMessage("Email - CMDate(Email) " + profile.CMData + "");
        }

        /// <summary>
        /// This method will Check the Profile - Details of Phone Section on view profile page - data with DB values.
        /// </summary>
        /// <param name="profile"></param>
        public static void VerifyDBValuesInUnifiedProfile_ContactDetails_PhoneSection(Profile_DB profile)
        {
            VerifyTextOnPageAndHighLight(profile.CMData, GetFieldXpath_Table("Phone "));
            Logger.WriteDebugMessage("Phone Details should match with DB as below - CMDate(Phone) " + profile.CMData + "");
        }

        /// <summary>
        /// This method will Check the Profile - Details of Fax Section on view profile page - data with DB values.
        /// </summary>
        /// <param name="profile"></param>
        public static void VerifyDBValuesInUnifiedProfile_ContactDetails_FaxSection(Profile_DB profile)
        {
            VerifyTextOnPageAndHighLight(profile.CMData, GetFieldXpath_Table(" Fax "));
            Logger.WriteDebugMessage("Fax Details should match with DB as below - CMDate(Fax) " + profile.CMData + "");
        }

        /// <summary>
        /// This method will Check the Profile - Details of Address Section on view profile page - data with DB values.
        /// </summary>
        /// <param name="profile"></param>
        public static void VerifyDBValuesInUnifiedProfile_ContactDetails_AddressSection(Profile_DB profile)
        {
            VerifyTextOnPageAndHighLight(profile.Address1 , GetFieldXpath_Table(" Known Addresses "));
            if (!string.IsNullOrEmpty(profile.City) && string.IsNullOrEmpty(profile.StateProvince) && string.IsNullOrEmpty(profile.PostalCode))
            {
                VerifyTextOnPageAndHighLight(profile.City, GetFieldXpath_Table(" Known Addresses "));
                VerifyTextOnPageAndHighLight(profile.StateProvince, GetFieldXpath_Table(" Known Addresses "));
                VerifyTextOnPageAndHighLight(profile.PostalCode, GetFieldXpath_Table(" Known Addresses "));
            }

            VerifyTextOnPageAndHighLight(profile.CountryCode, GetFieldXpath_Table(" Known Addresses "));

            Logger.WriteDebugMessage("Knowun Address -Address1 Details should match with DB as below - Address1 " + profile.Address1 + " and "+profile.CountryCode+"");
        }

        /// <summary>
        /// This method will Check the UP Profile - Details of Main Section on view profile page - data with DB values.
        /// </summary>
        /// <param name="profile"></param>
        public static void VerifyDBValuesInUnifiedProfile_MainSection_Phone(Profile_DB profile)
        {            
            VerifyTextOnPageAndHighLight(profile.CMData, GetFieldXpath(" Phone "));

            Logger.WriteDebugMessage("Main section Details fields should match with DB as below  - CMData(Phone) " + profile.CMData + " ");
        }

        /// <summary>
        /// This method will Check the UP Profile - Details of Contact Section on view profile page - data with DB values.
        /// </summary>
        /// <param name="profile"></param>

        public static void VerifyDBValuesInUnifiedProfile_ContactDetailsSection(Profile_DB profile)
        {
            VerifyTextOnPageAndHighLight(profile.PrimaryLanguage, GetFieldXpath(" Gender "));
            VerifyTextOnPageAndHighLight(profile.GenderCode, GetFieldXpath(" Language "));

            Logger.WriteDebugMessage("Main section Details fields should match with DB as below  - " +
                "PrimaryLanguage " + profile.PrimaryLanguage + "" +
                "- GenderCode " + profile.GenderCode + "");
        }

        /// <summary>
        /// This method will Check the UP Profile - Details of Personal Section on view profile page - data with DB values.
        /// </summary>
        /// <param name="profile"></param>
        public static void VerifyDBValuesInUnifiedProfile_PersonalDetailsSection(Profile_DB profile)
        {
            VerifyTextOnPageAndHighLight(profile.Suffix, GetFieldXpath(" Prefix "));
            //VerifyTextOnPageAndHighLight(profile.GenderCode, GetFieldXpath(" Language "));

            Logger.WriteDebugMessage("Main section Details fields should match with DB as below  - " +
                " Prefix " + profile.Suffix+ "" +
                //"- GenderCode " + profile.GenderCode + "" +
                "");
        }

        /// <summary>
        /// This method will Check the Verify text on page and Highlight - data with DB values.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="xpath"></param>
        public static void VerifyTextOnPageAndHighLight(string text, string xpath)
        {
            if (string.IsNullOrEmpty(text))
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

        /// <summary>
        /// This method will Check the list of profiles in the first page of the table.
        /// </summary>
        /// <param name="lst_ProfileDb"></param>
        public static void VerifyTableData(List<Profile_DB> lst_ProfileDb)
        {            
            for (int i = 0; i < lst_ProfileDb.Count; i++)
            {
               Profile_DB profileDb = lst_ProfileDb[i];
               string profileId =  profileDb.ProfileId;

                VerifyTextOnPageAndHighLight(profileId, "//table[@class='e-table']//tr["+(i+1)+"]/td[1]");
                Logger.WriteDebugMessage("User verify the profile id is "+ profileId + " ");                             
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
                string externalResID1 = profileDb.ExternalResID1;

                VerifyTextOnPageAndHighLight(externalResID1, "//table[@class='e-table']//tr["+(i+1)+"]/td[1]");
                Logger.WriteDebugMessage("User verify the ExternalReservation id is " + externalResID1 + " ");
            }
        }

        /// <summary>
        /// This method will Check the list of accounts to select the Org.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        //public static string GetFieldXpath(string fieldName)
        //{
        //    string fieldXpath = "//div[contains(text(),'" + fieldName + "')]//parent::li//span";

        //    return fieldXpath;
        //}

        //public static string GetFieldXpath_Table(string fieldName)
        //{
        //    string fieldXpath = "//*[contains(text(),'" + fieldName + "')]//following::tr[@role='row']/td[contains(@aria-label,'" + fieldName + "')]";

        //    return fieldXpath;
        //}

        ///// <summary>
        ///// This method will Check the list of accounts to select the Org.
        ///// </summary>
        ///// <param name="fieldName"></param>
        ///// <returns></returns>
        //public static string GetFieldXpath_CrossIcon(string fieldName)
        //{
        //    fieldName = GetFieldUIName(fieldName);
        //    string fieldXpath = "//div[contains(text(),'" + fieldName + "')]/parent::li//*[name()='svg' and @class='base-icon x']";

        //    return fieldXpath;
        //}

        //public static string GetFieldXpath_CheckIcon(string fieldName)
        //{
        //    fieldName = GetFieldUIName(fieldName);
        //    string fieldXpath = "//div[contains(text(),'" + fieldName + "')]/parent::li//*[name()='svg' and @class='base-icon check']";

        //    return fieldXpath;
        //}

        //public static string GetFieldXpath_CheckEmpty(string fieldName)
        //{
        //    fieldName = GetFieldUIName(fieldName);
        //    string fieldXpath = "//div[contains(text(),'" + fieldName + "')]/parent::li//*[contains(text(),'--')]";

        //    return fieldXpath;
        //}

        //public static string GetFieldUIName(string fieldNameDB)
        //{
        //    string fieldName = null;
        //    if (fieldNameDB.Equals("GuestPriv"))
        //    {
        //        fieldName = "Guest Priv";
        //    }
        //    else if (fieldNameDB.Equals("AllowMail"))
        //    {
        //        fieldName = "Allow Mail";
        //    }
        //    else if (fieldNameDB.Equals("AllowEMail"))
        //    {
        //        fieldName = "Allow Email";
        //    }
        //    else if (fieldNameDB.Equals("AllowPhone"))
        //    {
        //        fieldName = "Allow Phone";
        //    }
        //    else if (fieldNameDB.Equals("AllowSMS"))
        //    {
        //        fieldName = "Allow SMS";
        //    }
        //    else if (fieldNameDB.Equals("AllowHistory"))
        //    {
        //        fieldName = "Allow History";
        //    }
        //    else if (fieldNameDB.Equals("AllowMarketResearch"))
        //    {
        //        fieldName = "Allow Market Research";
        //    }
        //    else if (fieldNameDB.Equals("AllowThirdParty"))
        //    {
        //        fieldName = "Allow Third Party";
        //    }
        //    else if (fieldNameDB.Equals("AllowLoyaltyProgram"))
        //    {
        //        fieldName = "Allow Loyalty Program";
        //    }
        //    else
        //    {
        //        fieldName = fieldNameDB;
        //    }

        //    return fieldName;
        //}

        ////public static void EnterFilterValues(string filterOption, string filterType, string value)
        ////{
        ////    IList<IWebElement> options = null;
        ////    string filterTypeInputXpath = "//small[contains(text(),'" + filterOption + "')]/parent::*/following-sibling::div/descendant::span";
        ////    string filterValueInputXpath = "//small[contains(text(),'" + filterOption + "')]/parent::*/following::input[@placeholder='Enter a value']";
        ////    if (filterOption.Equals("ID") || filterOption.Equals("Name") || filterOption.Equals("Property Id")
        ////        || filterOption.Equals("Audience") || filterOption.Equals("Updated By"))
        ////    {
        ////        Helper.ElementClick(Helper.Driver.FindElement(By.XPath(filterTypeInputXpath)));
        ////        for (int i = 0; i < 5; i++) { options = PageObject_ManageCampaign.Campaign_Filter_DropDown_FilterOptions(); }
        ////        foreach (var item in options)
        ////        {
        ////            if (item.Text.Equals(filterType))
        ////            {
        ////                item.Click();
        ////                break;
        ////            }
        ////        }
        ////        //Helper.ElementClick(PageObject_ManageCampaign.Campaign_Filter_ID_Text());
        ////        Helper.ElementWait(Helper.Driver.FindElement(By.XPath(filterValueInputXpath)), 10);
        ////        if (value.Length > 200)
        ////            value = value.Substring(0, 20);
        ////        Helper.ElementEnterText(Helper.Driver.FindElement(By.XPath(filterValueInputXpath)), value.Trim());
        ////    }
        ////    else if (filterOption.Equals("Status"))
        ////    {
        ////        Helper.ElementClick(Helper.Driver.FindElement(By.XPath(filterTypeInputXpath)));
        ////        for (int i = 0; i < 5; i++) { options = PageObject_ManageCampaign.Campaign_Filter_DropDown_FilterOptions(); }
        ////        foreach (var item in options)
        ////        {
        ////            if (item.Text.Equals(filterType))
        ////            {
        ////                item.Click();
        ////                break;
        ////            }
        ////        }
        ////        //Helper.ElementClick(PageObject_ManageCampaign.Campaign_Filter_ID_Text());
        ////        //Helper.ElementWait(PageObject_ManageCampaign.Campaign_Filter_Status_DropDown_Arrow(), 10);
        ////        Helper.ElementClick(PageObject_ManageCampaign.Campaign_Filter_Status_DropDown_Arrow());
        ////        //Helper.ElementEnterText(PageObject_ManageCampaign.Campaign_Filter_Status_DropDown_Input(), value);
        ////        IList<IWebElement> statusOption = null;
        ////        Helper.WaitForAjaxControls(50);
        ////        for (int i = 0; i < 5; i++) { statusOption = PageObject_ManageCampaign.Campaign_Filter_Status_DropDown_Options(); }
        ////        foreach (var item in statusOption)
        ////        {
        ////            if (item.Text.Equals(value))
        ////            {
        ////                Helper.ElementWait(item, 5);
        ////                Helper.ElementClick(item);
        ////                break;
        ////            }
        ////        }
        ////        Helper.ElementClick(PageObject_ManageCampaign.Campaign_Filter_ID_Text());
        ////    }
        ////    if (filterOption.Equals("Updated On") || filterOption.Equals("Check In"))
        ////    {
        ////        Helper.ElementClick(Helper.Driver.FindElement(By.XPath(filterTypeInputXpath)));
        ////        for (int i = 0; i < 5; i++) { options = PageObject_ManageCampaign.Campaign_Filter_DropDown_FilterOptions(); }
        ////        foreach (var item in options)
        ////        {
        ////            if (item.Text.Equals(filterType))
        ////            {
        ////                item.Click();
        ////                break;
        ////            }
        ////        }
        ////        Helper.ElementClick(PageObject_ManageCampaign.Campaign_Filter_ID_Text());
        ////        var date = Convert.ToDateTime(value).ToString("MMM dd, yyyy");
        ////        Helper.ElementEnterText(PageObject_ManageCampaign.Campaign_Filter_UpdatedOn_Input(), date);
        ////        Helper.ElementClick(PageObject_ManageCampaign.Campaign_Filter_ID_Text());
        ////    }
        ////}
    }
}

