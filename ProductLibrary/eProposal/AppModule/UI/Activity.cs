using System;
using System.Globalization;
using System.Linq;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.UI;
using OpenQA.Selenium;
using eProposal.Utility;
using InfoMessageLogger;
using eProposalConstants = eProposal.Utility.Constants;

namespace eProposal.AppModule.UI
{
    internal class Activity : Helper
    {
        public static void Verify_Custom_SignatureImage()
        {
            Helper.VerifyElementOnPage(PageObject_Activity.Activity_Preview_CustomSignatureImage());
        }

        public static void Click_Link_SignNow()
        {
            AddDelay(500);
            Helper.ElementClick(PageObject_Activity.Activity_Link_SignNow());
            AddDelay(20000);
        }

        public static void Click_Button_SubmitElectronically()
        {
            AddDelay(500);
            Helper.ElementClick(PageObject_Activity.Activity_Button_SubmitElectronically());
            AddDelay(20000);
        }

        public static void Enter_Text_SignHere2(string text)
        {
            Helper.ElementEnterText(PageObject_Activity.Activity_Text_SignHere2(), text);
        }

        public static void Click_Link_ClickHere()
        {
            Helper.ElementClick(PageObject_Activity.Activity_Link_ClickHere());
            AddDelay(20000);
        }

        public static void ClickActivityTab()
        {
            AddDelay(3500);
            Helper.ElementClick(PageObject_Activity.Activity_Navigation_ActivityTab());
            AddDelay(3500);
        }

        public static void ClickLinkFrom()
        {
            AddDelay(2500);
            Helper.ElementClick(PageObject_Activity.Activity_Link_From());
        }

        public static void ClickLinkTO()
        {
            AddDelay(2500);
            Helper.ElementClick(PageObject_Activity.Activity_Link_To());
        }

        public static void ClickLinkeProposal()
        {
            AddDelay(2500);
            Helper.ElementClick(PageObject_Activity.Activity_Link_eProposal());
        }

        public static void ClickLinkViews()
        {
            AddDelay(2500);
            Helper.ElementClick(PageObject_Activity.Activity_Link_Views());
        }

        public static void ClickLinkSendingStatus()
        {
            AddDelay(2500);
            Helper.ElementClick(PageObject_Activity.Activity_Link_SendingStatus());
        }

        public static void ClickLinkSendOn()
        {
            AddDelay(2500);
            Helper.ElementClick(PageObject_Activity.Activity_Link_SendOn());
        }

        public static void ClickLinkEventDate()
        {
            AddDelay(2500);
            Helper.ElementClick(PageObject_Activity.Activity_Link_EventDate());
        }

        public static void ClickLinkExpirationDate()
        {
            AddDelay(2500);
            Helper.ElementClick(PageObject_Activity.Activity_Link_ExpirationDate());
        }

        public static void ClickLinkCreatedOn()
        {
            AddDelay(2500);
            Helper.ElementClick(PageObject_Activity.Activity_Link_CreatedOn());
        }

        public static void ClickButtoneCard()
        {
            AddDelay(2500);
            Helper.ElementClick(PageObject_Activity.Activity_Button_eCard());
        }

        public static void ClickLinkeCard()
        {
            AddDelay(2500);
            Helper.ElementClick(PageObject_Activity.Activity_Link_eCard());
        }

        public static void ClickLinkPreview()
        {
            AddDelay(1500);
            Helper.OpenPopUpWindow(PageObject_Activity.Activity_Link_Preview());
            AddDelay(8000);
        }

        public static void ClickButtonForward()
        {
            AddDelay(6500);
            Helper.ElementClick(PageObject_Activity.ActivityPreview_Button_Forward());
        }

        public static void ClickButtonGetLink()
        {
            AddDelay(1500);
            Helper.ElementClick(PageObject_Activity.Activity_Link_GetLink());
        }

        public static void ClickTextURL()
        {
            AddDelay(1500);
            Helper.ElementClick(PageObject_Activity.Activity_GetLink_URL());
        }

        public static void ClickLinkResend()
        {
            AddDelay(1500);
            Helper.ElementClick(PageObject_Activity.Activity_Link_Resend());
        }

        public static void ClickbuttonResendOK()
        {
            AddDelay(1500);
            Helper.ElementClick(PageObject_Activity.Activity_ResendLink_OK());
        }

        public static void ClickbuttonResendCancel()
        {
            AddDelay(1500);
            Helper.ElementClick(PageObject_Activity.Activity_ResendLink_Cancel());
        }

        public static void ClickbuttonClose()
        {
            AddDelay(1500);
            Helper.ElementClick(PageObject_Activity.Activity_Button_Close());
        }

        public static void ClickLinkClone()
        {
            AddDelay(2500);
            Helper.ElementClick(PageObject_Activity.Activity_Link_Clone());
            AddDelay(7500);
        }

        public static void ClickLinkStatus()
        {
            AddDelay(1500);
            Helper.ElementClick(PageObject_Activity.Activity_Link_Status());
        }

        public static void ClickStatusCancel()
        {
            AddDelay(1500);
            Helper.ElementClick(PageObject_Activity.Activity_StatusLink_Cancel());
        }

        public static void ClickLinkDownloadPDF()
        {
            AddDelay(1500);
            Helper.ElementClick(PageObject_Activity.Activity_Link_DownloadPDF());
        }

        public static void ClickExpirationDateIcon()
        {
            AddDelay(7500);
            Helper.ElementClick(PageObject_Activity.Activity_DatePicker_ExpirationDate());
        }

        public static void SelectExpirationMonth(string month)
        {
            AddDelay(2500);
            Helper.ElementSelectFromDropDown(PageObject_Activity.Activity_dropdown_ExpirationMonth(), month);
        }

        public static void SelectExpirationYear(string Year)
        {
            AddDelay(2500);
            Helper.ElementSelectFromDropDown(PageObject_Activity.Activity_dropdown_ExpirationYear(), Year);
        }

        public static void ClickCurrentlyViewing()
        {
            AddDelay(1500);
            Helper.ElementClick(PageObject_Activity.Activity_dropdown_CurrentlyViewing());
        }

        public static void SelectCurrentlyViewing(string CurrentlyViewing)
        {
            AddDelay(2500);
            Helper.ElementSelectFromDropDown(PageObject_Activity.Activity_dropdown_CurrentlyViewing(),
                CurrentlyViewing);
        }

        public static void ClickViewContracts()
        {
            AddDelay(1500);
            Helper.ElementClick(PageObject_Activity.Activity_Dropdown_ViewContracts());
        }

        public static void SelectViewContracts(string CurrentlyViewing)
        {
            AddDelay(3500);
            Helper.ElementSelectFromDropDown(PageObject_Activity.Activity_Dropdown_ViewContracts(), CurrentlyViewing);
        }

        public static void Enter_Text_ActivityKeyword(string text)
        {
            Helper.ElementEnterText(PageObject_Activity.Activity_Search_Textbox(), text);
            Logger.WriteDebugMessage("Keyword Entered");
        }
        public static void Click_ActivitySearchButton()
        {
            Helper.ElementClick(PageObject_Activity.Activity_Search_Button());
            AddDelay(8000);
            Logger.WriteDebugMessage("Keyword searched!!");
        }
        public static void VerifyCurrentlyViewing()
        {
            AddDelay(1500);
            var dropdownList = PageObject_Activity.Activity_dropdown_CurrentlyViewing().GetAttribute("innerHTML");


            if (dropdownList.Contains("Prospect") && dropdownList.Contains("Tentative") &&
                dropdownList.Contains("General Inquiry") && dropdownList.Contains("Definite") &&
                dropdownList.Contains("Contracted") && dropdownList.Contains("Pending") &&
                dropdownList.Contains("Completed") && dropdownList.Contains("Canceled") &&
                dropdownList.Contains("Turn Down") && dropdownList.Contains("Lost") &&
                dropdownList.Contains("Actualize") && dropdownList.Contains("Archived") &&
                dropdownList.Contains("Viewed") && dropdownList.Contains("Metron - RFP") &&
                dropdownList.Contains("All"))
                Logger.WriteInfoMessage(
                    "The following options are displayed: Prospect Tentative General Inquiry Definite Contracted Pending Completed Canceled Turn Down Lost Actualized Archived Viewed Metron - RFP All");
        }

        public static void SelectStatus(string status)
        {
            AddDelay(2500);
            Helper.ElementSelectFromDropDown(PageObject_Activity.Activity_dropdown_Status(), status);
        }

        public static void ClickSave()
        {
            AddDelay(1500);
            Helper.ElementClick(PageObject_Activity.Activity_Button_Save());
        }

        public static void ClickGetLinkClose()
        {
            AddDelay(1500);
            Helper.ElementClick(PageObject_Activity.Activity_Button_GetLinkClose());
        }

        public static void EnterComment(string comment)
        {
            AddDelay(1500);
            Helper.ElementEnterText(PageObject_Activity.Activity_Text_Comment(), comment);
        }

        public static void VerifyComment(string comment)
        {
            AddDelay(1500);
            Helper.VerifyTextOnPage(comment);
        }

        public static void ClickReviewSend()
        {
            Helper.ElementClick(PageObject_Activity.Activity_Link_ReviewSend());
            AddDelay(7500);
        }

        public static void ClickSend()
        {
            AddDelay(3500);
            Helper.ElementClick(PageObject_Activity.Activity_Button_Send());
            AddDelay(7500);
        }

        public static void ClickSearch()
        {
            Helper.ElementClick(PageObject_Activity.Activity_button_Search());
            AddDelay(7500);
        }

        public static void ClickAdvanceSearchLink()
        {
            Helper.ElementClick(PageObject_Activity.Activity_Link_AdvanceSearch());
            AddDelay(7500);
        }

        public static void EnterFrom(string from)
        {
            AddDelay(1500);
            Helper.ElementEnterText(PageObject_Activity.Activity_Textbox_From(), from);
            AddDelay(2500);
            ClickAdvanceSearchButton();
            AddDelay(3500);
        }

        public static void SelectSearchOption(string searchoption)
        {
            AddDelay(2500);
            Helper.ElementSelectFromDropDownByValue(PageObject_Activity.Activity_Dropdown_AdvanceSearch(),
                searchoption);
            AddDelay(2500);
            ClickAdvanceSearchButton();
            AddDelay(3500);
        }

        public static void EnterTo(string to)
        {
            AddDelay(1500);
            Helper.ElementEnterText(PageObject_Activity.Activity_Textbox_To(), to);
            AddDelay(2500);
            ClickAdvanceSearchButton();
            AddDelay(3500);
        }

        public static void EnterWiththeWords(string text)
        {
            AddDelay(1500);
            Helper.ElementEnterText(PageObject_Activity.Activity_Textbox_WiththeWords(), text);
            AddDelay(2500);
            ClickAdvanceSearchButton();
            AddDelay(3500);
        }

        public static void SelectIn(string value)
        {
            AddDelay(2500);
            Helper.ElementSelectFromDropDown(PageObject_Activity.Activity_Dropdown_In(), value);
        }

        public static void SelectWith(string value)
        {
            AddDelay(2500);
            Helper.ElementSelectFromDropDown(PageObject_Activity.Activity_Dropdown_With(), value);
        }

        public static void ClickAdvanceSearchButton()
        {
            Helper.ElementClick(PageObject_Activity.ActivityAdvanceSearch_Button_Search());
            AddDelay(7500);
        }

        public static void EnterText_search(string text)
        {
            Helper.ElementEnterText(PageObject_Activity.Activity_Text_Search(), text);
        }

        public static void EnterText_StartDate(string text)
        {
            Helper.ElementEnterText(PageObject_Activity.Activity_Icon_ExpirationStartDate(), text);
        }

        public static void EnterText_EndDate(string text)
        {
            Helper.ElementEnterText(PageObject_Activity.Activity_Icon_ExpirationEndDate(), text);
        }

        public static void VerifyViewContracts()
        {
            AddDelay(1500);
            var dropdownList = PageObject_Activity.Activity_Dropdown_ViewContracts().GetAttribute("innerHTML");


            if (dropdownList.Contains("Fully Signed"))
                Logger.WriteInfoMessage("The following options is displayed: Fully Signed");
        }

        /// <summary>
        ///     Click the "Forward" button on the eProposal,
        /// </summary>
        public static void clickForwardButtononeProposal()
        {
            Helper.ControlToNewWindow();
            ClickButtonForward();
            Helper.VerifyTextOnPage(eProposalConstants.Preview_Text);
            CommonMethod.Driver.Close();
        }

        /// <summary>
        ///     Copy and paste the URL into a browser.
        /// </summary>
        public static void GetURLandCopyPasteNewBrowser()
        {
            ClickTextURL();
            var url = CommonMethod.Driver.FindElement(By.XPath("//textarea[@readonly='readonly']"))
                .GetAttribute("value");
            AddDelay(2000);
            ClickGetLinkClose();
            AddDelay(1500);
            Helper.NewBrowser();
            CommonMethod.Driver.Navigate().GoToUrl(url);
            clickForwardButtononeProposal();
            Helper.ControlToPreviousWindow();
        }

        /// <summary>
        ///     Copy and paste the URL into a new window.
        /// </summary>
        public static void GetURLandCopyPasteNewWindow()
        {
            ClickTextURL();
            var url = CommonMethod.Driver.FindElement(By.XPath("//textarea[@readonly='readonly']"))
                .GetAttribute("value");
            AddDelay(2000);
            ClickGetLinkClose();
            AddDelay(1500);
            Helper.NewBrowser();
            CommonMethod.Driver.Navigate().GoToUrl(url);
        }

        /// <summary>
        ///     Method to select date before today
        /// </summary>
        public static void Setdatebeforetoday()
        {
            int dd, mm, yyyy;
            var date = DateTime.Now.ToShortDateString();
            var longdate = DateTime.Now.ToString("MMM,dd,yyyy");
            var dates = longdate.Split(',');
            var mm1 = dates[0];
            var yyyy1 = dates[2];
            SelectExpirationMonth(mm1);
            SelectExpirationYear(yyyy1);
            var datesplit = date.Split('/');
            var intArray = Array.ConvertAll(datesplit, int.Parse);
            mm = intArray[0];
            dd = intArray[1];
            yyyy = intArray[2];
            var datedd = dd - 1;
            var newdate = datedd.ToString();
            var element = CommonMethod.Driver.FindElement(By.LinkText(newdate));
            element.Click();
            Helper.VerifyTextOnPage(eProposalConstants.ExpirationBeforeToday);
            
        }

        /// <summary>
        ///     Method to select date before today
        /// </summary>
        public static void SetdateafterEventDate()
        {
            ClickExpirationDateIcon();
            int dd, mm, yyyy;
            var date = DateTime.Now.ToShortDateString();
            var longdate = DateTime.Now.ToString("MMM,dd,yyyy");
            var dates = longdate.Split(',');
            var mm1 = dates[0];
            //var yyyy1 = dates[2];
            SelectExpirationMonth(mm1);
            var datesplit = date.Split('/');
            var stryear = datesplit[2];
            var intArray = Array.ConvertAll(datesplit, int.Parse);
            mm = intArray[0];
            dd = intArray[1];
            yyyy = intArray[2];
            var datedd = dd + 1;
            var yearyy = stryear + 1;
            SelectExpirationYear(yearyy);
            var newdate = datedd.ToString();
            var element = CommonMethod.Driver.FindElement(By.LinkText(newdate));
            element.Click();


            //int dd, mm, yyyy;
            //var date = PageObject_Activity.Activity_Text_EventDate().GetAttribute("innerHTML");
            //var datesplit = date.Split('/');
            //var intArray = Array.ConvertAll(datesplit, int.Parse);
            //dd = intArray[1];
            //mm = intArray[0];
            //yyyy = intArray[2];
            //var datedd = dd + 1;
            //var newdate = datedd.ToString();
            //var stryear = datesplit[2];
            //var mfi = new
            //    DateTimeFormatInfo();
            //var strMonthName = mfi.GetMonthName(mm);
            //var month = strMonthName.Substring(0, 3);
            //SelectExpirationMonth("6");
            //SelectExpirationYear(stryear);
            //var element = CommonMethod.Driver.FindElement(By.LinkText(newdate));
            //element.Click();
            Helper.VerifyTextOnPage(eProposalConstants.ExpirationAfterEventDate);
            AddDelay(2500);
        }

        /// <summary>
        ///     Change the date to a date after today and before the "Event Date".
        /// </summary>
        public static void SetdateafterTodaybeforeEventDate()
        {
            ClickExpirationDateIcon();
            int dd, mm, yyyy;
            var date = PageObject_Activity.Activity_Text_EventDate().GetAttribute("innerHTML");
            var datesplit = date.Split('/');
            var intArray = Array.ConvertAll(datesplit, int.Parse);
            dd = intArray[1];
            mm = intArray[0];
            yyyy = intArray[2];
            var datedd = dd - 2;
            var newdate = datedd.ToString();
            var stryear = datesplit[2];
            var mfi = new
                DateTimeFormatInfo();
            var strMonthName = mfi.GetMonthName(mm);
            var month = strMonthName.Substring(0, 3);
            SelectExpirationMonth(month);
            SelectExpirationYear(stryear);
            var element = CommonMethod.Driver.FindElement(By.LinkText(newdate));
            element.Click();
            AddDelay(2500);
        }

        /// <summary>
        ///     Verify the "Event Date" matches the date is selected.
        /// </summary>
        public static void VerifyEventDate(string eventmonth, string eventyear, string eventdate)
        {
            string selecteventdate;
            var month = DateTime.Parse(eventdate + eventmonth + eventyear).Month;
            if (month < 10)
            {
                var presentmonth = string.Concat("0", month);
                selecteventdate = string.Concat(eventdate, "/", presentmonth, "/", eventyear);
            }
            else
            {
                selecteventdate = string.Concat(eventdate, "/", month, "/", eventyear);
            }

            var actualdate = PageObject_Activity.Activity_Text_EventDate().GetAttribute("innerHTML");
            if (actualdate.Contains(selecteventdate))
                Logger.WriteInfoMessage("Selected eventdate matches with the Event Date");
            else
                Logger.WriteInfoMessage("Selected eventdate does not matches with the Event Date");
        }

        /// <summary>
        ///     Verify the "Expiration Date" matches the date is selected.
        /// </summary>
        public static void VerifyExpirationDate(string expirationmonth, string expirationyear, string expirationdate)
        {
            string selecteventdate;
            var month = DateTime.Parse(expirationdate + expirationmonth + expirationyear).Month;
            if (month < 10)
            {
                var presentmonth = string.Concat("0", month);
                selecteventdate = string.Concat(expirationdate, "/", presentmonth, "/", expirationyear);
            }
            else
            {
                selecteventdate = string.Concat(expirationdate, "/", month, "/", expirationyear);
            }

            var actualdate = PageObject_Activity.Activity_Text_ExpirationDate().GetAttribute("innerHTML");
            if (actualdate.Contains(selecteventdate))
                Logger.WriteInfoMessage("Selected eventdate matches with the Expiration Date");
            else
                Logger.WriteInfoMessage("Selected eventdate does not matches with the Expiration Date");
        }

        /// <summary>
        ///     Verify the "Created on Date" matches the date is selected.
        /// </summary>
        public static void VerifyCreatedonDate()
        {
            string selecteventdate;
            int dd, mm, yyyy;
            var actualdate = PageObject_Activity.Activity_Text_CreatedOnDate().GetAttribute("innerHTML");
            var longdate = DateTime.Now.ToShortDateString();
            var datesplit = longdate.Split('/');
            var intArray = Array.ConvertAll(datesplit, int.Parse);
            mm = intArray[0];
            dd = intArray[1];
            yyyy = intArray[2];
            if (mm < 10)
            {
                var presentmonth = string.Concat("0", mm);
                selecteventdate = string.Concat(dd, "/", presentmonth, "/", yyyy);
            }
            else
            {
                selecteventdate = string.Concat(dd, "/", mm, "/", yyyy);
            }

            if (actualdate.Contains(selecteventdate))
                Logger.WriteInfoMessage("Created on date matches with the Today's date");
            else
                Logger.WriteInfoMessage("Created on date does not matches with the Today's date");
        }

        /// <summary>
        ///     Verify the "Sending Status" for this eProposal states "Not Sent".
        /// </summary>
        public static void VerifySendingStatus()
        {
            var gettext = PageObject_Activity.Activity_Text_SendingStatus().GetAttribute("innerHTML");
            if (gettext.Equals("Not Sent"))
                Logger.WriteInfoMessage("Sending Status for this eProposal states Not Sent.");
            else
                Logger.WriteInfoMessage("Sending Status for this eProposal states is Sent.");
        }

        /// <summary>
        ///     Verify the "Sending Status" for this eProposal states "Sent".
        /// </summary>
        public static void VerifySendingStatusSent()
        {
            var gettext = PageObject_Activity.Activity_Text_SendingStatus().GetAttribute("innerHTML");
            if (gettext.Equals("Sent"))
                Logger.WriteInfoMessage("Sending Status for this eProposal states  Sent.");
            else
                Logger.WriteInfoMessage("Sending Status for this eProposal states is Not Sent.");
        }

        /// <summary>
        ///     Method to redirect back to Compose page.
        /// </summary>
        public static void RedirecttoNavigationButton()
        {
            eProposalCompose.Click_Button_Next();
            AddDelay(10000);
            Helper.ScrollToElement(PageObject_ProposalCompose.Button_Next());
            eProposalCompose.Click_Button_Next();
            AddDelay(6000);
        }

        /// <summary>
        ///     Method to redirect back to Compose page.
        /// </summary>
        public static void RedirectSendPage()
        {
            eProposalCompose.Click_Button_Next();
            AddDelay(5000);
            eProposalCompose.Click_Button_Next();
            AddDelay(5000);
            eProposalCendynEventBlock.Click_Button_Next();
            AddDelay(5000);
            Helper.ControlToNewWindow();
            Helper.CloseWindow();
            Helper.ControlToPreviousWindow();
        }

        /// <summary>
        ///     Enter a "keyword" (client name, employee name, proposal name, etc…) and click "Search"
        /// </summary>
        public static void SearchKeywords(string proposalname)
        {
            EnterText_search(proposalname);
            ClickSearch();
            AddDelay(5000);
        }

        /// <summary>
        ///     Verify "eCards" display a green "eC" icon.
        /// </summary>
        public static void VerifyeCardIconColour()
        {
            var colour = PageObject_Activity.Activity_Icon_eCard().GetCssValue("color");
            if (colour.Equals("rgba(73, 73, 73, 1)"))
                Logger.WriteInfoMessage("eCards display a green eC icon.");
        }

        /// <summary>
        ///     Verify "eProposal" display a green "eP" icon.
        /// </summary>
        public static void VerifyeProposalIconColour()
        {
            var colour = PageObject_Activity.Activity_Icon_eProposal().GetCssValue("color");
            if (colour.Equals("rgba(73, 73, 73, 1)"))
                Logger.WriteInfoMessage("eCards display a green eC icon.");
        }

        /// <summary>
        ///     Verify "eBrochure" is NOT listed next to the module name.
        /// </summary>
        public static void VerifyeBrochureisNotPresent(string eproposalname)
        {
            HighlightText(eproposalname);
            AddDelay(1500);
            var element = CommonMethod.Driver.FindElement(By.LinkText("eBrochure"));
            var visible = element.Displayed;
            if (visible.Equals(false))
                Logger.WriteInfoMessage("eBrochure is not displayed!");
        }

        /// <summary>
        ///     Method to get the Custom Signature name on Preview Page
        /// </summary>
        public static string Get_Custom_Signature()
        {
            var CustomSignatureSRC = PageObject_Activity.Activity_Preview_CustomSignature().GetAttribute("src");
            var CustomSignatureSplit = CustomSignatureSRC.Split('=');
            var CustomSignatureInitial = CustomSignatureSplit[0];
            return CustomSignatureInitial;
        }

        /// <summary>
        ///     Method to get the Custom Signature name on Preview Page
        /// </summary>
        public static string Get_Custom_SignatureImage()
        {
            var CustomSignatureSRC = PageObject_Activity.Activity_Preview_CustomSignatureImage().GetAttribute("src");
            var CustomSignatureSplit = CustomSignatureSRC.Split('=');
            var CustomSignatureInitial = CustomSignatureSplit[0];
            return CustomSignatureInitial;
        }

        /// <summary>
        /// This method will open the contract and sign it as the hotel employee.
        /// </summary>
        /// <param name="signature"></param>
        public static void OpenAndSignContractAsEmployee(string signature)
        {
            try
            {
                Helper.OpenPopUpWindow(PageObject_Activity.Activity_Link_SignNow());
                AddDelay(3500);
                Helper.EnterFrame("frSigning");
                AddDelay(3500);
                CommonMethod.Driver
                    .FindElement(By.XPath("//button[contains(@class,'jsbtnGetStarted btn btn-success btn-sm')]"))
                    .Click();
                AddDelay(2500);
                CommonMethod.Driver.FindElement(By.XPath("//input[@data-container-id='location3']")).SendKeys(signature);
                AddDelay(1000);
                CommonMethod.Driver
                    .FindElement(By.XPath("//button[@class='btn btn-success vertical-align-top submit-documents']"))
                    .Click();
                AddDelay(1000);
                Helper.ClosePopUpWindow();
                Logger.WriteInfoMessage("Signed the contract successfully as the hotel employee.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage("Unable to sign the contract as the hotel employee. \n" + e);
                throw;
            }

        }
    }
}