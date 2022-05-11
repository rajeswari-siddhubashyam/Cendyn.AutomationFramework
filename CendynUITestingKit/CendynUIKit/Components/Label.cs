using System;
using System.Collections.Generic;
using System.Text;
using CendynUIKit.Models;
using OpenQA.Selenium;

namespace CendynUIKit.Components
{
    public class Label : CendynElement, ILabel
    {
        public Label(IWebDriver driver, By selector) : base(driver, selector)
        {
        }

        public new void Click()
            => Click();

        public string GetLabelText()
            => _webElement.Text;

		public new string GetCssValue(string propertyName)
            => GetCssValue(propertyName);
    }
}
