using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTOS.Models;
using OpenQA.Selenium;

namespace CTOS
{
    public class Button : CendynElement, IButton
    {
		private Dictionary<string, ButtonStyle> _buttonStyles = new Dictionary<string, ButtonStyle>() 
		{
			{ "primary", ButtonStyle.Primary },
			{ "secondary", ButtonStyle.Secondary },
			{ "danger", ButtonStyle.Danger },
			{ "success", ButtonStyle.Success }
		};

        public Button(IWebDriver driver, By selector) : base(driver, selector)
        {
        }

        public new void Click()
		{
			Task.Delay(1000).Wait();
            base.Click();
		}

		public string GetButtonText()
            => Text;

		public ButtonStyle GetStyle()
		{
			foreach (var key in _buttonStyles.Keys)
			{
				if (_webElement.GetAttribute("class").ToLower().Contains(key))
				{
					return _buttonStyles[key];
				}
			}

			return ButtonStyle.None;
		}

		public bool IsEnabled()
		{
			if (_webElement.GetDomAttribute("disabled") != "true")
				return true;

			return false;
		}
	}
}
