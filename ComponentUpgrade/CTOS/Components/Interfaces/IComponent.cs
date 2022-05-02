using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace CTOS.Models.Components
{
    public interface IComponent
    {
        IWebElement GetWebElement();
    }
}
