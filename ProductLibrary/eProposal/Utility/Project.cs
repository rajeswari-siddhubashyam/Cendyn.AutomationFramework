using System;
using Common;
using eProposal.Utility;
using OpenQA.Selenium;
using BaseUtility.Utility;
using InfoMessageLogger;

namespace eProposal.Utility
{
    /// <summary>
    ///     This class is for project specific methods that are used throughout the application but not on other applications
    ///     such as a calendar.
    /// </summary>
    internal class Project : Helper
    {
        /// <summary>
        ///     This method will enter the month, day and year on the eProposal calendar.
        /// </summary>
        /// <param name="month">Month/Apr</param>
        /// <param name="day">Day/1</param>
        /// <param name="year">Year/2017</param>
        public static void Calendar(string month, string day, string year)
        {
            try
            {
                //Select calendar year
                ElementSelectFromDropDown(Driver.FindElement(By.XPath("//select[@class='ui-datepicker-year']")), year);
                Logger.WriteInfoMessage("Selected the calendar year.");

                //Select calendar month
                ElementSelectFromDropDown(Driver.FindElement(By.XPath("//select[@class='ui-datepicker-month']")),
                    month);
                Logger.WriteInfoMessage("Selected the calendar month.");

                //If the day starts with a 0, remove it.
                if (day[0].Equals('0'))
                    day = day.Remove(0, 1);

                //Select calendar day
                var xPathFront = "//a[contains(.,'";
                var xPathBack = "')]";
                var fullXPath = xPathFront + day + xPathBack;
                ElementClick(Driver.FindElement(By.XPath(fullXPath)));
                Logger.WriteInfoMessage("Selected the calendar day.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                Logger.WriteFatalMessage("Unable to select a date from the calendar.");
                throw;
            }
        }

        /// <summary>
        ///     This method will check to see if the current step is Step 4 on the proposal.
        /// </summary>
        /// <param name="step"></param>
        /// <returns></returns>
        public static bool IsThisStep4(string step)
        {
            if (Driver.FindElement(By.XPath("//div[contains(@class,'4')]")).Text.Contains(step))
                return true;

            return false;
        }

        /// <summary>
        ///     This method will check Step #2 and return TRUE if it is the SELECT step.
        /// </summary>
        /// <returns></returns>
        public static bool IsStep2Select()
        {
            try
            {
                if (Driver.FindElement(By.XPath("//div[contains(@class,'divName divName_2')]")).Text ==
                    Constants.SELECT)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        /// <summary>
        ///     This method will check Step #4 and return TRUE if it is the SELECT step.
        /// </summary>
        /// <returns></returns>
        public static bool IsStep4Select()
        {
            try
            {
                if (Driver.FindElement(By.XPath("//div[contains(@class,'divName divName_4')]")).Text ==
                    Constants.SELECT)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }
    }
}