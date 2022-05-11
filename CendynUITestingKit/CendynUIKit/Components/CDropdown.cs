﻿using CendynUIKit.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CendynUIKit.Components
{
	public class CDropdown : CendynElement, ICDropdown
	{
		public CDropdown(IWebDriver driver, By selector) : base(driver, selector) { }

		public bool ContainsValue(string TextValue)
		{ /* Do Marketing Automation code... */
			return true;
		}
	}
}
