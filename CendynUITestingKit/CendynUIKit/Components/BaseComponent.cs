using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace CendynUIKit.Components
{
    public class BaseComponent
    {
        private CendynElement _webElement { get; set; }

        public BaseComponent(IWebDriver driver, By selector)
        {
            _webElement = new CendynElement(driver, selector);
        }

        public CendynElement GetWebElement()
            => _webElement;
    }
}
