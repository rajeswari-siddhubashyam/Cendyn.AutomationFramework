using CendynUIKit.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading.Tasks;

namespace CendynUIKit.Components
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
			=> _webElement.Enabled;

		public bool IsSelected()
			=> _webElement.GetDomAttribute("checked") == "true" ? true : false;

		public ILabel GetLabel()
			=> _radioLabel;

		public void Select()
		{
			Task.Delay(1500).Wait();
			Actions actions = new Actions(_driver);
			if (IsEnabled())
				actions
					.MoveToElement(_webElement, 4, 4)
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
