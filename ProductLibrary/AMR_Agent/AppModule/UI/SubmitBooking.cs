using System;
using System.Globalization;
using System.Text.RegularExpressions;
using AMR_Agent.PageObject.UI;
using AMR_Agent.Utility;
using BaseUtility.Utility;
using Common;
using InfoMessageLogger;
using OpenQA.Selenium;

namespace AMR_Agent.AppModule.UI
{
    public class SubmitBooking : Utility.Setup
    {
        public static void AMRCalendar(string month, string day, string year)
        {
            //Select the year
            PageObject_SubmitBooking.SubmitBooking_DatePickerYear().Click();
            PageObject_SubmitBooking.SubmitBooking_DatePickerYear().SendKeys(year);
            PageObject_SubmitBooking.SubmitBooking_DatePickerYear().SendKeys(Keys.Enter);
            Time.AddDelay(2000);
            //Select the month          
            PageObject_SubmitBooking.SubmitBooking_DatePickerMonth().Click();
            PageObject_SubmitBooking.SubmitBooking_DatePickerMonth().SendKeys(month);
            PageObject_SubmitBooking.SubmitBooking_DatePickerMonth().SendKeys(Keys.Enter);
            Time.AddDelay(1000);

            //Select the day by link name
            Driver.FindElement(By.LinkText(day)).Click();

            //Find the day via xpath
            //for (int i = 1; i <= 6; i++)
            //    for (int j = 1; j <= 7; j++)
            //    {
            //        IWebElement element =
            //            Driver.FindElement(By.XPath("/html/body/div[13]/table/tbody/tr[" + i + "]/td[" + j + "]"));

            //        if (element.Text == day)
            //        {
            //            Time.AddDelay(1000);
            //            element.Click();
            //            Logger.WriteInfoMessage("Entered the date on calender.");
            //            return;
            //        }
            //    }
        }

        public static void SelectRadioIndividualButton()
        {
            Helper.ElementClick(PageObject_SubmitBooking.SubmitBookingIndividualRadioButton());
        }

        public static void SelectFromDropDown_DropDown_BookingBookingMadeWith(string text)
        {
            PageObject_SubmitBooking.SubmitBookingBookingMadeWith().SendKeys(text);
        }

        public static void EnterText_Text_BookingNumber(string text)
        {
            PageObject_SubmitBooking.SubmitBookingBookingNumber().SendKeys(text);
        }

        public static void EnterText_Text_FirstName(string text)
        {
            PageObject_SubmitBooking.SubmitBookingGuestFirstName().SendKeys(text);
        }

        public static void EnterText_Text_LastName(string text)
        {
            PageObject_SubmitBooking.SubmitBookingGuestLastName().SendKeys(text);
        }

        public static void DatePicker_DateBooked(string Date)
        {
            DateTime iDate = Convert.ToDateTime(Date);
            string GetDate = Convert.ToString(iDate.Day);
            int GetMonth = Convert.ToInt32(iDate.Month);
            string MonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(GetMonth);
            string GetYear = Convert.ToString(iDate.Year);

            Helper.ElementClick(Driver.FindElement(By.XPath("//*[@id='mainSkTable']/tbody/tr/td[1]/table/tbody/tr[6]/td[2]/img")));

            Helper.ElementSelectFromDropDown(CommonMethod.Driver.FindElement(By.XPath("//div[@id='ui-datepicker-div']/div/div/select[2]")), GetYear);
            Helper.ElementSelectFromDropDown(CommonMethod.Driver.FindElement(By.XPath("//div/select")), MonthName);
            Helper.ElementClick(CommonMethod.Driver.FindElement(By.LinkText(GetDate)));
        }

        public static void DatePicker_ArrivalDate(string Date)
        {
            DateTime iDate = Convert.ToDateTime(Date);
            string GetDate = Convert.ToString(iDate.Day);
            int GetMonth = Convert.ToInt32(iDate.Month);
            string MonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(GetMonth);
            string GetYear = Convert.ToString(iDate.Year);

            Helper.ElementClick(Driver.FindElement(By.XPath("//*[@id='mainSkTable']/tbody/tr/td[2]/table/tbody/tr[1]/td[2]/img")));
            Helper.ElementSelectFromDropDown(CommonMethod.Driver.FindElement(By.XPath("//div[@id='ui-datepicker-div']/div/div/select[2]")), GetYear);
            Helper.ElementSelectFromDropDown(CommonMethod.Driver.FindElement(By.XPath("//div/select")), MonthName);
            Helper.ElementClick(CommonMethod.Driver.FindElement(By.LinkText(GetDate)));
        }

        public static void DatePicker_DepartureDate(string Date)
        {
            DateTime iDate = Convert.ToDateTime(Date);
            string GetDate = Convert.ToString(iDate.Day);
            int GetMonth = Convert.ToInt32(iDate.Month);
            string MonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(GetMonth);
            string GetYear = Convert.ToString(iDate.Year);

            Helper.ElementClick(Driver.FindElement(By.XPath("//*[@id='mainSkTable']/tbody/tr/td[2]/table/tbody/tr[2]/td[2]/img")));
            if (!IsElementVisible(Driver.FindElement(By.XPath("//*[@id='ui-datepicker-div']"))))
            {
                Helper.ElementClick(Driver.FindElement(By.XPath("//*[@id='mainSkTable']/tbody/tr/td[2]/table/tbody/tr[2]/td[2]/img")));
            }
            Helper.ElementSelectFromDropDown(CommonMethod.Driver.FindElement(By.XPath("//div[@id='ui-datepicker-div']/div/div/select[2]")), GetYear);
            Helper.ElementSelectFromDropDown(CommonMethod.Driver.FindElement(By.XPath("//div/select")), MonthName);
            Helper.ElementClick(CommonMethod.Driver.FindElement(By.LinkText(GetDate)));
        }

        public static void SelectFromDropDown_DropDown_BrandName(string text)
        {
            PageObject_SubmitBooking.SubmitBookingBrand().SendKeys(text);
        }

        public static void SelectFromDropDown_DropDown_ResortName(string text)
        {
            PageObject_SubmitBooking.SubmitBookingResort().SendKeys(text);
        }

        public static void SelectFromDropDown_DropDown_DepartureGateway(string text)
        {
            ElementClick(PageObject_SubmitBooking.SubmitBookingDepartureGateway());
            string pattern = @"(?<=\().+?(?=\))";
            IJavaScriptExecutor js = (IJavaScriptExecutor)Helper.Driver;
            MatchCollection mc = Regex.Matches(text, pattern);
            foreach (Match m in mc)
            {
                PageObject_SubmitBooking.SubmitBookingDepartureGateway1().SendKeys(m.ToString());
                ElementClick(PageObject_SubmitBooking.SubmitBookingDepartureGateway());
                ElementClick(PageObject_SubmitBooking.SubmitBookingDepartureGateway());
                ElementClick(Driver.FindElement(By.XPath("//em[contains(text(),'" + m.ToString() + "')]")));
                //js.ExecuteScript("arguments[0].click();", Driver.FindElement(By.XPath("//em[contains(text(),'" + m.ToString() + "')]")));
            }
            //ElementClick(Driver.FindElement(By.XPath("//*[@id='airportSel']/div[3]/div[1]")));
        }

        public static void Button_SubmitBooking()
        {
            Helper.ElementClick(PageObject_SubmitBooking.SubmitBookingAddToBookingSummary());
        }

        private static string bookingNum;

        /// <summary>
        /// This method will generate a random booking number
        /// </summary>
        /// <returns></returns>
        public static string BookingNumber()
        {
            
            thisDay = DateTime.Now;
            bookingNum = thisDay.ToString("yy") + thisDay.ToString("MM") + thisDay.ToString("dd") + thisDay.Hour + thisDay.Minute;
            return bookingNum;
        }

        public static void CreateIndividualSubmitBooking(string BookingMade, string BookingNumber, string Firstname, string Lastname, string DateBooked, string Arrival, string Departure, string BrandName, string ResortName, string BookedEnteredByAgent, string DepartureGatewayId)
        {
            ScrollToElement(PageObject_SubmitBooking.SubmitBookingIndividualRadioButton());
            SelectRadioIndividualButton();
            SelectFromDropDown_DropDown_BookingBookingMadeWith(BookingMade);

            AddDelay(3000);
            if (Helper.IsElementVisible(Driver.FindElement(By.XPath("/html/body/div[10]/div[1]/button"))))
            {
                ScrollToElement(Driver.FindElement(By.XPath("/html/body/div[10]/div[1]/button")));
                AddDelay(3000);
                ScrollToElement(Driver.FindElement(By.XPath("/html/body/div[10]/div[1]/button")));
                AddDelay(3000);
                Helper.ElementClick(Driver.FindElement(By.XPath("/html/body/div[10]/div[1]/button")));
            }
            
            EnterText_Text_BookingNumber(BookingNumber);
            EnterText_Text_FirstName(Firstname);
            EnterText_Text_LastName(Lastname);
            DatePicker_DateBooked(DateBooked);
            AddDelay(1500);
            DatePicker_ArrivalDate(Arrival);
            AddDelay(1500);
            DatePicker_DepartureDate(Departure);
            SelectFromDropDown_DropDown_BrandName(BrandName);
            SelectFromDropDown_DropDown_ResortName(ResortName);
            SelectFromDropDown_DropDown_DepartureGateway(DepartureGatewayId);
            Logger.WriteDebugMessage("Inserted all mandatory fields.");
            Button_SubmitBooking();
            AddDelay(7000);

        }

    }
}
