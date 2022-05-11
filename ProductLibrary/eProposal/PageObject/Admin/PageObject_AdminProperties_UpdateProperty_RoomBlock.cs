using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.Admin
{
    public class PageObject_AdminProperties_UpdateProperty_RoomBlock : Setup
    {
        public static string PageName = Constants.AdminProperties_UpdateProperty_RoomBlock;

        public static IWebElement RadioButton_RoomOnWelcome_On()
        {
            ScanPage(Constants.AdminProperties_UpdateProperty_RoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_On);
        }

        public static IWebElement RadioButton_RoomOnWelcome_DefaultChecked_On()
        {
            ScanPage(Constants.AdminProperties_UpdateProperty_RoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_DefaultChecked_On);
        }

        public static IWebElement RadioButton_RoomOnWelcome_ReadOnly_On()
        {
            ScanPage(Constants.AdminProperties_UpdateProperty_RoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_ReadOnly_On);
        }

        public static IWebElement RadioButton_RoomOnWelcome_Off()
        {
            ScanPage(Constants.AdminProperties_UpdateProperty_RoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_Off);
        }

        public static IWebElement RadioButton_RoomOnWelcome_DefaultChecked_Off()
        {
            ScanPage(Constants.AdminProperties_UpdateProperty_RoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_DefaultChecked_Off);
        }

        public static IWebElement RadioButton_RoomOnWelcome_ReadOnly_Off()
        {
            ScanPage(Constants.AdminProperties_UpdateProperty_RoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_ReadOnly_Off);
        }

        public static IWebElement Button_Submit()
        {
            ScanPage(Constants.AdminProperties_UpdateProperty_RoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_UpdateProperty_RoomBlock_Button_Submit);
        }
    }
}