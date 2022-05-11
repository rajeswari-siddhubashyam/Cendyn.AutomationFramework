using CTOS.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading.Tasks;

namespace CTOS.Components
{
	public class Radio : CendynElement, IRadio
	{
		private Label _radioLabel;
		public Radio(IWebDriver driver, By Selector) : base(driver, Selector)
		{
			_selector = Selector;
			_radioLabel = new Label(driver, By.XPath("../label"));
		}

		public bool IsEnabled() 
			=> WebElement.Enabled;

		public bool IsSelected()
			=> WebElement.GetDomAttribute("checked") == "true" ? true : false;

		public ILabel GetLabel()
			=> _radioLabel;

		public void Select()
		{
			Task.Delay(1500).Wait();
			Actions actions = new Actions(_driver);
			if (IsEnabled())
				actions
					.MoveToElement(WebElement, 4, 4)
					.Click()
					.Perform();
			else
				throw new ElementNotInteractableException("Radio element is not selectable: " + _selector);
		}
		           
		public RadioStyle GetRadioStyle()
		{
			throw new NotImplementedException();
		}
	}
}
