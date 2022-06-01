using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace CTOS.Components
{
	public class Input : CendynElement, IInput
	{
		private CendynElement inputText { get; }
		public Input(IWebDriver driver, By selector) : base(driver, selector)
		{
			inputText = new CendynElement(driver, selector);
		}
		public bool IsEnabled()
			=> base.Enabled;
		public Label GetInputLabel()
		{
			Label inputLabel = new Label(_driver, inputText.FindElement(By.XPath("./preceding::div[contains(@class, 'c-label')]/label[@class = 'c-label-text']")));
			return inputLabel;
		}
		public string GetInputText() => GetAttribute("value");
			//=> Text;
		//{
				//return inputText.Text.ToString(); - text is giving null
				//return base.GetAttribute("value");
		//}

        public void EnterInput(string inputText) => SendKeys(inputText);
		//{
		//	base.SendKeys(inputText);
		//}

		public bool IsInputEnabled() => IsEnabled();
		//     {
		//return true;
		//     }
	}
}
