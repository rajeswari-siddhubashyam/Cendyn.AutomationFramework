using BaseUtility.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using RevIntel.PageObject.UI;
using OpenQA.Selenium.Support.UI;

namespace RevIntel.AppModule.UI
{
    class ExchangeRate : Helper
    {
        public static void NavigatetoPaceForecastReport()
        {
            string iframeLocation = "//iframe[@name='Pace and Forecast Report']";
            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(iframeLocation)));
            Logger.WriteDebugMessage("Landed on Pace and Forecast Report");
        }
        public static void ChangeStartMonth_DateInput()
        {
            string startDateRange = "January 2021";
            ElementEnterText(Driver.FindElement(By.Id("txtStartMonth_dateInput")), startDateRange);
            Logger.WriteDebugMessage("Selected Start Month as " + startDateRange);
        }

        public static void ChangeDateAsOfInput()
        {
            string startDateRange = "5/7/2021";
            ElementEnterText(Driver.FindElement(By.Id("txtAsOfDate_dateInput")), startDateRange);
            Logger.WriteDebugMessage("Selected As of Date as " + startDateRange);
        }
        public static void Click_ViewAnalysis()
        {
            ElementClick(PageObject_ExchangeRate.Click_ViewAnalysis());
            Logger.WriteDebugMessage("Click on View Analysis button.");
        }

        public static void Identify_Forecast_TotalSoldRevenue()
        {
            string totalsoldRev_location = "/html/body/form/div[6]/div/table/tbody/tr/td[3]/div/table/tbody/tr/td[2]/div/div/table/tbody/tr[4]/td[3]/div/div[1]/div/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[77]/td[10]/div/div";
            string getValue = Driver.FindElement(By.XPath(totalsoldRev_location)).Text;

            if (getValue == "0")
            {
                Logger.WriteDebugMessage("Forecast - Total Sold Revenue - " + getValue + " is as per expected.");
            }
            else
            {
                Assert.Fail("Did not match the Forecast - Total Sold Revenue - " + getValue);
            }
        }
        public static void Identify_Budget_TotalSoldRevenue()
        {
            string totalsoldRev_location = "/html/body/form/div[6]/div/table/tbody/tr/td[3]/div/table/tbody/tr/td[2]/div/div/table/tbody/tr[4]/td[3]/div/div[1]/div/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[77]/td[16]/div/div";
            string getValue = Driver.FindElement(By.XPath(totalsoldRev_location)).Text;

            if (getValue == "0")
            {
                Logger.WriteDebugMessage("Budget - Total Sold Revenue - " + getValue + " is as per expected.");
            }
            else
            {
                Assert.Fail("Did not match the Budget - Total Sold Revenue - " + getValue);
            }
        }

        public static void Identify_Forecast_ToVarience()
        {
            string totalsoldRev_location = "/html/body/form/div[6]/div/table/tbody/tr/td[3]/div/table/tbody/tr/td[2]/div/div/table/tbody/tr[4]/td[3]/div/div[1]/div/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[77]/td[15]/div/div";
            string getValue = Driver.FindElement(By.XPath(totalsoldRev_location)).Text;

            if (getValue == "0")
            {
                Logger.WriteDebugMessage("Variance to Current Forecast - Total Sold Revenue - " + getValue + " is as per expected.");
            }
            else
            {
                Assert.Fail("Did not match the Variance to Current Forecast - Total Sold Revenue - " + getValue);
            }
        }
        public static void Identify_Budget_ToVarience()
        {
            string totalsoldRev_location = "/html/body/form/div[6]/div/table/tbody/tr/td[3]/div/table/tbody/tr/td[2]/div/div/table/tbody/tr[4]/td[3]/div/div[1]/div/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[77]/td[17]/div/div";
            string getValue = Driver.FindElement(By.XPath(totalsoldRev_location)).Text;

            if (getValue == "868,499")
            {
                Logger.WriteDebugMessage("Variance to Current Forecast - Total Sold Revenue - " + getValue + " is as per expected.");
            }
            else
            {
                Assert.Fail("Did not match the Variance to Current Forecast - Total Sold Revenue - " + getValue);
            }
        }

        public static void Identify_ADR_SubTotal()
        {
            string totalsoldRev_location = "/html/body/form/div[6]/div/table/tbody/tr/td[3]/div/table/tbody/tr/td[2]/div/div/table/tbody/tr[4]/td[3]/div/div[1]/div/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[5]/td[4]/div/div";
            string getValue = Driver.FindElement(By.XPath(totalsoldRev_location)).Text;

            if (getValue == "1,031.52")
            {
                Logger.WriteDebugMessage("ADR - SubTotal Revenue - " + getValue + " is as per expected.");
            }
            else
            {
                Assert.Fail("Did not match the ADR - SubTotal Revenue- " + getValue);
            }
        }
        public static void Identify_ADR_TotalADROccupied()
        {
            string totalsoldRev_location = "/html/body/form/div[6]/div/table/tbody/tr/td[3]/div/table/tbody/tr/td[2]/div/div/table/tbody/tr[4]/td[3]/div/div[1]/div/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[75]/td[4]/div/div";
            string getValue = Driver.FindElement(By.XPath(totalsoldRev_location)).Text;

            if (getValue == "646.42")
            {
                Logger.WriteDebugMessage("ADR - Total Revenue - " + getValue + " is as per expected.");
            }
            else
            {
                Assert.Fail("Did not match the ADR - Total Revenue- " + getValue);
            }
        }

        public static void Identify_Budget_TotalRevenue_Portal()
        {
            string totalBudgetRev = "/html/body/form/center/table[2]/tbody/tr[2]/td/div/table/tfoot/tr/td[6]";
            string getValue = Driver.FindElement(By.XPath(totalBudgetRev)).Text;

            if (getValue == "8,737")
            {
                Logger.WriteDebugMessage("Budget Var - Total Revenue - " + getValue + " is as per expected.");
            }
            else
            {
                Assert.Fail("Did not match the Budget Var - Total Revenue- " + getValue);
            }
        }

        public static void Identify_Forcast_TotalRevenue_Portal()
        {
            string totalBudgetRev = "/html/body/form/center/table[2]/tbody/tr[2]/td/div/table/tfoot/tr/td[7]";
            string getValue = Driver.FindElement(By.XPath(totalBudgetRev)).Text;

            if (getValue == "8,737")
            {
                Logger.WriteDebugMessage("Budget Var - Total Revenue - " + getValue + " is as per expected.");
            }
            else
            {
                Assert.Fail("Did not match the Budget Var - Total Revenue- " + getValue);
            }
        }
    }
}
