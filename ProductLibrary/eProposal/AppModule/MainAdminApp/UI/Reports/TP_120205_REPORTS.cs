using System;
using eProposal.Utility;
using eProposal.AppModule.UI;
using Common;
using Constants = eProposal.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using SqlWarehouse;
using OpenQA.Selenium;
using NUnit.Framework;
using eProposal.AppModule.UI;
using eProposal.PageObject.UI;
using System.Text.RegularExpressions;

namespace eProposal.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
		#region[TP_120205]
		#region[TC_120206]

		public static void TC_120206()
		{
			//1. Log into: ePFull Employee UI
			EmployeeLogin.CommonLogin_SSO();
			Logger.WriteDebugMessage("Land on the home page");

			//2.Select a property.
			EmployeeHome.SelectProperty(Property);
			Logger.WriteDebugMessage("Test property selected: " + Property);

			//3.Click "Reports"
			EmployeeHome.Click_ReportsButton();
			Logger.WriteDebugMessage("Land on reports page.");

			//4.Click "To Date" 
			EnterFrame("frame_content");
			Reports.Click_Link_ToDate();
			AddDelay(2500);
			Logger.WriteDebugMessage("Page populates with three drop down menus");

			//5.For each module in the "Select Module" drop down, select it then click "Submit".               
			//6.Verify data is displayed correctly.
			Reports.SelectModule(Module);
			Reports.Click_Button_Submit();
			AddDelay(6000);
			ExitFrame();
			Logger.WriteDebugMessage("Land on Count to Date page.");

			//7.Click "Reports" again.
			EmployeeHome.Click_ReportsButton();
			Logger.WriteDebugMessage("Land on reports page.");

			//8.Repeat steps 4-6 for:
			//By Year
			EnterFrame("frame_content");
			Reports.Click_Link_ByYear();
			AddDelay(2500);

			Driver.FindElement(By.XPath("//select[@name='Property_Module_ProposalCountDetail']")).SendKeys(Module);
			AddDelay(500);
			Driver.FindElement(By.XPath("//select[@name='ProposalCountDetail_Year']")).SendKeys(year);
			Reports.Click_Button_Submit();
			AddDelay(6000);
			ExitFrame();

			//By Date Range
			EmployeeHome.Click_ReportsButton();
			Logger.WriteDebugMessage("Land on reports page.");
			EnterFrame("frame_content");
			Reports.Click_Link_ByDateRange();
			AddDelay(2500);
			Driver.FindElement(By.XPath("//select[@name='Property_Module_SMStatus']")).SendKeys(Module);
			Reports.Click_DatePicker_StartDate();
			Reports.Select_Datepicker_Month(startMonth);
			Reports.Select_Datepicker_Year(startYear);
			Reports.Click_Date(startDate);
			Reports.Click_DatePicker_EndDate();
			Reports.Select_Datepicker_Month(endMonth);
			Reports.Select_Datepicker_Year(endYear);
			Reports.Click_Date(endDate);
			Reports.Click_Button_Submit();
			AddDelay(6000);
			ExitFrame();

			//By User
			EmployeeHome.Click_ReportsButton();
			Logger.WriteDebugMessage("Land on reports page.");
			EnterFrame("frame_content");
			Reports.Click_Link_ByUser();
			AddDelay(2500);
			Driver.FindElement(By.XPath("//select[@name='Property_Module_SMName']")).SendKeys(Module);
			Reports.SelectUsername("Qa, Cendynautomation");
			Driver.FindElement(By.XPath("//input[@id='ProposalCountByTimePeriod_SearchBySMName_StartDate']")).Click();
			AddDelay(1500);
			Reports.Select_Datepicker_Month(startMonth);
			Reports.Select_Datepicker_Year(startYear);
			Reports.Click_Date(startDate);
			Driver.FindElement(By.XPath("//input[@id='ProposalCountByTimePeriod_SearchBySMName_EndDate']")).Click();
			AddDelay(1500);
			Reports.Select_Datepicker_Month(endMonth);
			Reports.Select_Datepicker_Year(endYear);
			Reports.Click_Date(endDate);
			Reports.Click_Button_Submit();
			AddDelay(6000);
			ExitFrame();

			//Per Client
			EmployeeHome.Click_ReportsButton();
			Logger.WriteDebugMessage("Land on reports page.");
			EnterFrame("frame_content");
			Reports.Click_Link_PerClient();
			AddDelay(2500);
			Driver.FindElement(By.XPath("//select[@name='Property_Module_ClientProposal']")).SendKeys(Module);
			Reports.Click_RadioButton_Lastname();
			Reports.Click_Button_Submit();
			AddDelay(6000);
			ExitFrame();
		}

		#endregion[TC_120206]

		#endregion[TP_120205]
	}
}
