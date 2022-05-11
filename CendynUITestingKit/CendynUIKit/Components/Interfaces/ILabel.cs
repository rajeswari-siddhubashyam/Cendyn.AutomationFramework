﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CendynUIKit.Models
{
    public interface ILabel
    {
        void Click();
        string GetLabelText();
        string GetCssValue(string propertyName);
    }
}
