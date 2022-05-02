using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTOS.Models;
using OpenQA.Selenium;

namespace CTOS
{
    public class DatePicker : CendynElement, IDatePicker
    {
        private string ParentLocator;
        private CendynElement CalendarInput { get; }
        private CendynElement CalendarGUI { get; }
        private IWebDriver _driver { get; }

        public DatePicker(IWebDriver driver, By selector) : base(driver, selector)
        {
            _driver = driver;
            _selector = selector;
            CalendarInput = new CendynElement(driver, selector);
            CalendarGUI = new CendynElement(driver, By.XPath("//div[@class='e-datepicker e-popup-wrapper e-lib e-popup e-control ']"));
        }

        public CendynElement GetWebElement()
            => CalendarGUI;

        public void OpenCalendar()
        {
            if (IsDisabled())
                throw new InvalidElementStateException("Could not open Calendar. Input is disabled.");

            Task.Delay(1000).Wait();
            if (!IsCalendarOpen())
			{
                CalendarInput.FindElement(By.XPath($"../*[@class='e-input-group-icon e-date-icon e-icons']")).Click();
            }
            //CalendarInput.Click();
        }

        public bool IsCalendarOpen()
        {
            Task.Delay(1000).Wait();
            try
			{
                _driver.FindElement(By.CssSelector(".e-datepicker.e-popup-wrapper.e-lib.e-popup.e-control"));
                return true;
            }
			catch(Exception e)
			{
                Console.WriteLine(e);
                return false;
			}
        }

        public void SetDateByInput(DateTime date)
        {
            Task.Delay(1000).Wait();
        }

        public void SetDateByGUI(DateTime date)
        {
            if (IsDisabled())
                throw new InvalidElementStateException("Could not set Date. Input is disabled.");

            Task.Delay(3000).Wait();
            _driver.FindElement(By.XPath($"//*[contains(text(),'{date.Day}') and ancestor-or-self::td[not(contains(@class, 'e-other-month'))]]")).Click();
        }

        public bool IsDisabled()
		{
            if (CalendarInput.GetDomAttribute("readOnly") == "true")
                return true;
            else
                return false;
		}
    }
}
