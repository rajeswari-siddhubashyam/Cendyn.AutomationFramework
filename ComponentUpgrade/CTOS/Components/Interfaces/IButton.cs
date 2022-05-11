using System;
using System.Collections.Generic;
using System.Text;

namespace CTOS.Models
{
    public interface IButton
    {
        ButtonStyle GetStyle();
        string GetButtonText();
        void Click();
        bool IsEnabled();

    }

    public enum ButtonStyle
	{
        Primary,
        Success,
        Danger,
        Secondary,
        None
	}
}
