using CendynUIKit.Components.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CendynUIKit.Components
{
	public class C_InputTags : CendynElement, IC_InputTags
	{
		public C_InputTags(IWebDriver driver, By selector) : base(driver, selector)
		{
		}

		public void EnterText()
		{
			throw new NotImplementedException();
		}

		public List<string> GetInputs()
		{
			var stuff = FindElements(By.XPath("parent::*/child::div"));

			List<string> inputs = new List<string>();
			foreach(var inputString in stuff)
			{
				inputs.Add(inputString.Text);
			}

			return inputs;
		}

		public string GetPlaceholder()
		{
			throw new NotImplementedException();
		}

		public bool IsEnabled()
		{
			throw new NotImplementedException();
		}

		public bool IsRequired()
		{
			throw new NotImplementedException();
		}

		public bool Remove()
		{
			throw new NotImplementedException();
		}
	}
}
