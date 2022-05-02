using System;
using System.Collections.Generic;
using System.Text;
using CTOS.Models;
using OpenQA.Selenium;

namespace CTOS.Components
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
