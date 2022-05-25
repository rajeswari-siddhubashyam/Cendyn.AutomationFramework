using CTOS.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading.Tasks;

namespace CTOS.Components
{
	public class Radio : CendynElement, IRadio
	{
		//private Label _radioLabel;
		private CendynElement radioButton { get; }

		/// <summary>
		/// constructor method to add the radio button
		/// </summary>
		/// <param name="driver"></param>
		/// <param name="Selector"></param>
		public Radio(IWebDriver driver, By Selector) : base(driver, Selector)
		{	
			radioButton = new CendynElement(driver, Selector);
		}

		public bool IsEnabled()
			=> base.Enabled;

		public bool IsSelected()
			=> base.GetDomAttribute("checked") == "true" ? true : false;

		public Label GetLabel()
		{
			Label radioLabel = new Label(_driver, radioButton.FindElement(By.XPath("./ancestor::div[contains(@class, 'e-radio-wrapper e-wrapper')]/label")));
			return radioLabel;
		}
		//	=> _radioLabel;

		public void Select()
		{
			bool lablefl = radioButton.IsElementPresent(By.XPath("./ancestor::div[contains(@class, 'e-radio-wrapper e-wrapper')]/label[@class = 'e-right']"));
			Task.Delay(1000).Wait();
			bool fl = IsEnabled();
			try
			{
				if (fl == true)
				{
					if (lablefl == true)
					{
						radioButton.FindElement(By.XPath("./ancestor::div[contains(@class, 'e-radio-wrapper e-wrapper')]/label[@class = 'e-right']")).Click();
					}
					else
					{
						base.Click();
					}
				}
				else
				{
					Console.WriteLine("Radio Button is disabled");
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}
	}
}