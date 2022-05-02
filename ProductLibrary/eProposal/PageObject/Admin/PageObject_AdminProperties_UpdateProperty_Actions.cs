using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.Admin
{
    public class PageObject_AdminProperties_UpdateProperty_Actions : Setup
    {
        public static string PageName = Constants.AdminProperties_UpdateProperty_Actions;

        public static IWebElement RadioButton_MergeProperty_On()
        {
            ScanPage(Constants.AdminProperties_UpdateProperty_Actions);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_UpdateProperty_Actions_RadioButton_MergeProperty_On);
        }

        public static IWebElement RadioButton_MergeProperty_Off()
        {
            ScanPage(Constants.AdminProperties_UpdateProperty_Actions);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_UpdateProperty_Actions_RadioButton_MergeProperty_Off);
        }

        public static IWebElement RadioButton_DisableProperty_On()
        {
            ScanPage(Constants.AdminProperties_UpdateProperty_Actions);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_UpdateProperty_Actions_RadioButton_DisableProperty_On);
        }

        public static IWebElement RadioButton_DisableProperty_Off()
        {
            ScanPage(Constants.AdminProperties_UpdateProperty_Actions);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_UpdateProperty_Actions_RadioButton_DisableProperty_Off);
        }

        public static IWebElement RadioButton_MultiLanguageProperty_On()
        {
            ScanPage(Constants.AdminProperties_UpdateProperty_Actions);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_UpdateProperty_Actions_RadioButton_MultiLanguageProperty_On);
        }

        public static IWebElement RadioButton_MultiLanguageProperty_Off()
        {
            ScanPage(Constants.AdminProperties_UpdateProperty_Actions);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_UpdateProperty_Actions_RadioButton_MultiLanguageProperty_Off);
        }

        public static IWebElement Button_Update()
        {
            ScanPage(Constants.AdminProperties_UpdateProperty_Actions);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_UpdateProperty_Actions_Button_Update);
        }
    }
}