using CendynUIKit.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CendynUIKit.Components
{
	public class Card : CendynElement
	{
		public Card(IWebDriver driver, By selector) : base(driver, selector)
		{
		}

		public CendynElement GetImage()
		{
			return FindElement(By.XPath($"/img[1]")).ToCendynElement(_driver);
		}

		public CendynElement Row(int IndexStartingFromOne)
		{
			return FindElement(By.XPath($"/div[{IndexStartingFromOne}]")).ToCendynElement(_driver);
		}
	}
}