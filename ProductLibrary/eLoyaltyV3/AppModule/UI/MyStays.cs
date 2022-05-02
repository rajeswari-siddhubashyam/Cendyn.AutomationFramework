using System;
using OpenQA.Selenium;
using NUnit.Framework;
using BaseUtility.Utility;
using InfoMessageLogger;
using eLoyaltyV3.PageObject.UI;

namespace eLoyaltyV3.AppModule.UI
{
    class MyStays
    {
        private static void EnterText_Text_UpcomingStays_Filter(string text)
        {
            Helper.ElementEnterText(PageObject_MyStays.Text_UpcomingStays_Filter(), text);
        }

        private static void EnterText_Text_PastStays_Filter(string text)
        {
            Helper.ElementEnterText(PageObject_MyStays.Text_PastStays_Filter(), text);
        }

        private static void SelectFromDropDown_DropDown_UpcomingStays(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_MyStays.DropDown_UpcomingStays(), text);
        }

        private static void SelectFromDropDown_DropDown_PastStays(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_MyStays.DropDown_PastStays(), text);
        }

       public static void UpcomingStays_VerifyConfirmationNumberDisplays(string confirmationNumber, string ProjectName, int totalRes)
       {
            if (totalRes > 3)
            {
                Helper.ElementClick(Helper.Driver.FindElement(By.Id("LoadMorePastReservations")));
            }
            //Time.AddDelay(1500000);
            //CommonMethod.Driver.Navigate().Refresh();
            //if (Helper.IsElementPresent(By.XPath("//input[@aria-controls='DataTables_Table_0']")))
            //{
            //    EnterText_Text_UpcomingStays_Filter(confirmationNumber);
            //    EnterText_Text_PastStays_Filter(confirmationNumber);
            //}

            try
            {
                if (Helper.VerifyTextOnPage(confirmationNumber))
                {
                    if (ProjectName.Equals("Fraser") || ProjectName.Equals("HotelIcon"))
                    {
                        Helper.ScrollToElement(Helper.Driver.FindElement(By.XPath("//td[contains(text(),'" + confirmationNumber + "')]")));
                    }
                    else if (string.IsNullOrEmpty(ProjectName))
                    {
                        Helper.ScrollToElement(Helper.Driver.FindElement(By.XPath("//span[contains(text(),'" + confirmationNumber + "')]")));
                        //Helper.PageDown();
                    }
                    Helper.VerifyTextOnPageAndHighLight(confirmationNumber);
                    Logger.WriteInfoMessage("The confirmation number was displayed on the page!");
                }
                else
                {
                    Assert.Fail("The confirmation number: " + confirmationNumber +
                                        " did not display on the My Stays page.");
                }
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                throw;
            }

        }
        public static void VerifyConfirmationNumberNotDisplays(string confirmationNumber, string ProjectName, int totalRes)
        {
            
            try
            {
                if (Helper.VerifyTextOnPage(confirmationNumber))
                {
                    Assert.Fail("The confirmation number: " + confirmationNumber +
                                         " did not display on the My Stays page.");
                }
            
                else
                {
                    Logger.WriteInfoMessage("The Stay did not display on the My Stays page.");

                }
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                throw;
            }

        }
    }
}
