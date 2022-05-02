using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace CendynUIKit.Models.Components
{
    public interface IComponent
    {
        IWebElement GetWebElement();
    }
}
