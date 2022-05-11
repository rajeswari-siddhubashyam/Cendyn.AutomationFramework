using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CendynUIKit.Components
{
	public static class Extensions
	{
		public static CendynElement ToCendynElement(this IWebElement webElement, IWebDriver driver)
		{
			return new CendynElement(driver, webElement);
		}
	}
}
