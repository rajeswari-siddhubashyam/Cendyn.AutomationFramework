using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTOS.Models;
using OpenQA.Selenium;

namespace CTOS
{
    public class DatePicker : CendynElement, IDatePicker
    {
        private string[] stringSeparators = new string[] { " " };
        private string pattern = "dd-MMM-yyyy";

        private CendynElement CalendarInput { get; }
        private CendynElement CalendarGUI { get; }
        ////private IWebDriver _driver { get; }
        private CendynElement CalendarCloseBtn { get; }

        public DatePicker(IWebDriver driver, By selector) : base(driver, selector)
        {
            CalendarInput = new CendynElement(driver, selector);
            CalendarGUI = new CendynElement(driver, By.XPath("//div[contains(@class,'e-datepicker e-popup-wrapper e-lib e-popup e-control')]"));
            CalendarCloseBtn = new CendynElement(driver, By.XPath("./child::span[@class = 'e-clear-icon e-clear-icon-hide']"));
        }

        //public DatePicker(IWebDriver driver, CendynElement cendynElement) : base(driver, cendynElement)
        //{

        //}

        //public CendynElement GetWebElement()
        //    => CalendarGUI;

        public void OpenCalendar()
        {
            if (IsDisabled())
                throw new InvalidElementStateException("Could not open Calendar. Input is disabled.");

            //Task.Delay(1000).Wait();
            if (!IsCalendarOpen())
            {
                CalendarInput.FindElement(By.XPath("./child::span[contains(@class, 'e-input-group-icon e-date-icon e-icons')]")).Click();
                //By.XPath($"../*[@class='e-input-group-icon e-date-icon e-icons']")).Click();
                //By.XPath("./self::span[contains(@class, 'e-active')]")
            }
        }

        public bool IsCalendarOpen()
        {
            Task.Delay(1000).Wait();
            try
            {
                FindElement(By.XPath("//div[contains(@class,'e-datepicker e-popup-wrapper e-lib e-popup e-control')]"));
                //CalendarInput.FindElement(By.XPath("./child::div[@class ='e-datepicker e-popup-wrapper e-lib e-popup e-control e-popup-open']"));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public void SetDateByInput(DateTime date)
        {
            string inputDate = date.ToString(pattern);
            CalendarInput.FindElement(By.XPath("./child::input[@class ='e-control e-datepicker e-lib e-input e-keyboard']"));
            if (IsDisabled())
                throw new InvalidElementStateException("Could not set Date. Input is disabled.");

            Task.Delay(1000).Wait();

            if (CalendarInput.Enabled)
            {
                CalendarInput.FindElement(By.XPath("./child::input[@class = 'e-control e-datepicker e-lib e-input e-keyboard']")).Clear();
                //CalendarCloseBtn.Click();
            }

            CalendarInput.FindElement(By.XPath("./child::input[@class = 'e-control e-datepicker e-lib e-input e-keyboard']")).SendKeys(inputDate + Keys.Enter);

            //Gets the selected date from the input box
            DateTime selectedDate = DateTime.Parse(CalendarInput.FindElement(By.XPath("./child::input[@class = 'e-control e-datepicker e-lib e-input e-keyboard']")).GetAttribute("value")).ToUniversalTime(); //.ToString("r");

            //compares the target date should be the same as selected date


            int res = date.Date.CompareTo(selectedDate.Date);
            if (res != 0)
            {
                //log -dates are not equal
                Console.WriteLine("Dates are not equal");
            }
        }

        public void SetDateByGUI(DateTime date)
        {
            if (CalendarInput.Enabled)
            {
                CalendarInput.FindElement(By.XPath("./child::input[@class = 'e-control e-datepicker e-lib e-input e-keyboard']")).Clear();
                //CalendarCloseBtn.Click();
            }

            string finaltargetDate = date.ToString(DateTimeFormatInfo.CurrentInfo.LongDatePattern);
            //string finaltargetDate = date.ToUniversalTime().ToString("r");

            //Get the target month and year
            string targetmonYear = date.ToString(DateTimeFormatInfo.CurrentInfo.YearMonthPattern);
            string[] targetDate = targetmonYear.Split(stringSeparators, StringSplitOptions.None);
            int targetYear = Convert.ToInt32(targetDate[1]);
            //string targetMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(date.Month); // or targetDate[0]

            //Get the selected month and year
            string selectedmonYear = FindElement(By.XPath("//div[@class = 'e-day e-title']")).Text;
            string[] selectedDate = selectedmonYear.Split(stringSeparators, StringSplitOptions.None);
            int selectedYear = Convert.ToInt32(selectedDate[1]);
            //string selectedMonth = selectedDate[0];
            int selectedMonth = DateTime.Parse("1." + selectedDate[0] + " 2008").Month;

            bool prevBtn = IsElementPresent(By.XPath("//button[@aria-disabled = 'false' and contains(@class,'e-prev')]"));
            bool nextBtn = IsElementPresent(By.XPath("//button[@aria-disabled = 'false' and contains(@class,'e-next')]"));

            while (selectedmonYear != targetmonYear && nextBtn == true)
            {
                if (targetYear < selectedYear)
                {
                    //Click the Previous chevron
                    FindElement(By.XPath("//span[@class = 'e-date-icon-prev e-icons']")).Click();
                }

                else if (targetYear > selectedYear)
                {
                    //Click the Next chevron
                    FindElement(By.XPath("//span[@class = 'e-date-icon-next  e-icons']")).Click();
                }

                else //targetYear = selectedYear)
                {
                    if (date.Month < selectedMonth)
                    {
                        //Click the Previous chevron
                        FindElement(By.XPath("//span[@class = 'e-date-icon-prev e-icons']")).Click();
                    }
                    else
                    {
                        //Click the Next chevron
                        FindElement(By.XPath("//span[@class = 'e-date-icon-next  e-icons']")).Click();
                    }
                }

                selectedmonYear = FindElement(By.XPath("//div[@class = 'e-day e-title']")).Text;
                selectedDate = selectedmonYear.Split(stringSeparators, StringSplitOptions.None);
                selectedYear = Convert.ToInt32(selectedDate[1]);
                selectedMonth = DateTime.Parse("1." + selectedDate[0] + " 2008").Month;
            }

            //Click on the current Day
            FindElement(By.XPath($"//ancestor-or-self::td[not(contains(@class, 'e-other-month'))]/span[@title = '{finaltargetDate}']")).Click();

            //Gets the selected date from the input box
            DateTime finalselectedDate = DateTime.Parse(CalendarInput.FindElement(By.XPath("./child::input[@class = 'e-control e-datepicker e-lib e-input e-keyboard']")).GetAttribute("value")).ToUniversalTime(); //.ToString("D");
            //string finalselectedDate = DateTime.Parse(CalendarInput.GetAttribute("value")).ToUniversalTime().ToString("D");

            //compares the target date should be the same as selected date
            int res = date.Date.CompareTo(finalselectedDate.Date);
            if (res != 0)
            {
                //log -dates are not equal
                Console.WriteLine("Dates are not equal");
            }
        }

        public bool IsDisabled()
        {
            var attrVal = CalendarInput.FindElement(By.XPath("./child::input[@class ='e-control e-datepicker e-lib e-input e-keyboard']")).GetDomAttribute("readonly");
            if (attrVal == "true")
                return true;
            else
                return false;
        }
    }
}