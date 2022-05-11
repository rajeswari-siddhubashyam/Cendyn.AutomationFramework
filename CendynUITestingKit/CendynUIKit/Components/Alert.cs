using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace CendynUIKit.Components
{
	public class Alert : CendynElement, IAlert
	{
		private Dictionary<string, AlertType> _alertTypes = new Dictionary<string, AlertType>()
		{
			["alert-primary"] = AlertType.Primary,
			["alert-secondary"] = AlertType.Secondary,
			["alert-success"] = AlertType.Success,
			["alert-info"] = AlertType.Info,
			["alert-warning"] = AlertType.Warning,
			["alert-danger"] = AlertType.Danger,
			["alert-light"] = AlertType.Light,
			["alert-dark"] = AlertType.Dark
		};

		public Alert(IWebDriver driver, By selector) : base(driver, selector)
		{
			
		}

		public void CloseAlert()
		{
			Task.Delay(1000).Wait();
			if (IsDismissible())
				FindElement(By.XPath($"./button[@data-dismiss='alert']")).Click();
			else
				throw new ElementNotInteractableException("This alert is not dismissible. Selector: " + _selector);
		}

		public bool IsDismissible()
		{
			try
			{
				FindElement(By.XPath($"./self::*[contains(@class, 'alert-dismissible')]"), 2000, 1000);
				return true;
			}
			catch
			{
				return false;
			}
		}

		public AlertType GetAlertType()
		{
			var classes = GetDomAttribute("class");

			foreach(var key in _alertTypes.Keys)
			{
				if (classes.Contains(key))
					return _alertTypes[key];
			}
			return AlertType.None;
		}

		public Color GetBackgroundColor()
		{
			var bgColor = GetCssValue("background-color");

			if (bgColor.Contains("#") && bgColor.Length == 7)
			{
				// Remove # from string
				bgColor = bgColor.Substring(1);

				Stack<string> hexColors = new Stack<string>();
				hexColors.Push(bgColor.Substring(0, 1));
				hexColors.Push(bgColor.Substring(2, 3));
				hexColors.Push(bgColor.Substring(4, 5));

				// Converting from Hexadecimal to Decimal numbers
				Stack<int> decimalColors = new Stack<int>();
				decimalColors.Push(Convert.ToInt32(hexColors.Pop()));
				decimalColors.Push(Convert.ToInt32(hexColors.Pop()));
				decimalColors.Push(Convert.ToInt32(hexColors.Pop()));

				return Color.FromArgb(decimalColors.Pop(), decimalColors.Pop(), decimalColors.Pop());
			}
			else if (bgColor.Contains("rgba"))
			{
				return Color.Transparent;
			}
			else if (bgColor.Contains("rgb"))
			{
				return Color.Transparent;
			}

			return Color.Transparent;
		}

		public string GetIcon()
		{
			throw new NotImplementedException();
		}

		public string GetText()
			=> GetDomAttribute("innerText");
	}
}
