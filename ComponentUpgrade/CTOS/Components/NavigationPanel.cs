using CTOS.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CTOS.Components
{
	public class NavigationPanel : CendynElement, INavigationPanel
	{
		private string _xPathLink = "//span[text()[contains(.,'{0}')]]";
		private string _xPathGetHeader = "/ancestor::div[1]/ancestor::li[1]/a";

		public NavigationPanel(IWebDriver driver, By Selector) : base(driver, Selector)
		{
			_selector = Selector;
		}

		public string GetBottomIcon()
		{
			throw new NotImplementedException();
		}

		public void GetNumberOfLinks()
		{
			throw new NotImplementedException();
		}

		public string GetTopIcon()
		{
			throw new NotImplementedException();
		}

		public void NavigateTo(string LinkText)
		{
			Task.Delay(2000).Wait();
			if (CheckLinkIsUnderHeader(LinkText))
			{
				TryAndWait(() => 
				{ 
					var header = _driver.FindElement(By.XPath(string.Format(_xPathLink, LinkText) + _xPathGetHeader));
					if (header.GetDomAttribute("aria-expanded") != "true")
					{
						header.Click();
					}
				});
			}

			Task.Delay(1500).Wait();
			TryAndWait(() => _driver.FindElement(By.XPath(string.Format(_xPathLink, LinkText))).Click());
		}

		public void ToggleCollapse()
		{
			throw new NotImplementedException();
		}

		public bool CheckLinkIsUnderHeader(string LinkText)
		{
			bool returnValue = false;
			TryAndWait(() =>
			{
				try
				{
					try
					{
						// We want the method to fail if it can't find the base element. This will let the TryAndWait method retry until it can find it.
						_driver.FindElement(By.XPath(string.Format(_xPathLink, LinkText)));
					}
					catch(Exception e)
					{
						throw e;
					}

					// This will throw an exception if the header isn't found, which is what we want. If it's found, the returnValue is set to true.
					_driver.FindElement(By.XPath(string.Format(_xPathLink, LinkText) + _xPathGetHeader));
					returnValue = true;
				}
				catch { }
			});
			return returnValue;
		}
	}
}
