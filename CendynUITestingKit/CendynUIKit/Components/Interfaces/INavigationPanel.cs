using System;
using System.Collections.Generic;
using System.Text;

namespace CendynUIKit.Models
{
    public interface INavigationPanel
    {
        string GetTopIcon();
        string GetBottomIcon();
        void ToggleCollapse();
        void GetNumberOfLinks();

        void NavigateTo(string LinkText);

    }
}
