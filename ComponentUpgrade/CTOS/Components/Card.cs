using CTOS.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTOS.Components
{
	public class Card : CendynElement
	{
		public Card(IWebDriver driver, By selector) : base(driver, selector)
		{
		}

		//public CendynElement Row(int IndexStartingFromOne)
		//{

		//}
	}
}