using BaseUtility.Utility;
using eMenus.PageObject.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMenus.AppModule.UI
{
    class ePlannerHomePage
    {
        public static void Home_SearchBox(string str)
        {
            Helper.ElementEnterText(PageObject_ePlannerHomePage.Home_SearchBox(), str);
        }

        public static void Home_SearcBoxClear()
        {
            Helper.ElementClearText(PageObject_ePlannerHomePage.Home_SearchBox());
        }
    }
}
