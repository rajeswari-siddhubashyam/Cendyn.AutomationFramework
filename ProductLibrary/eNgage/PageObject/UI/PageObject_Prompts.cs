using System.Reflection;
using eNgage.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace eNgage.PageObject.UI
{
    class PageObject_Prompts : Setup
    {
        private static string PageName = Constants.Prompts;

        public static IWebElement Prompts_Container()
        {
            ScanPage(Constants.Prompts);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Prompts_Container);
        }
        public static IList<IWebElement> Prompts_Data()
        {
            ScanPage(Constants.Prompts);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Prompts_Container().FindElements(By.ClassName(ObjectRepository.Prompts_Data));
        }
        public static IList<IWebElement> Prompts_Div()
        {
            ScanPage(Constants.Prompts);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Prompts_Container().FindElements(By.CssSelector(ObjectRepository.Prompts_Div));
        }
        public static IList<IWebElement> Prompts_Responses(IWebElement PromptDiv)
        {
            ScanPage(Constants.Prompts);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PromptDiv.FindElement(By.ClassName(ObjectRepository.Prompts_Responses)).FindElements(By.TagName("li"));
        }
        public static IWebElement Prompts_inputText(IWebElement PromptDiv)
        {
            ScanPage(Constants.Prompts);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PromptDiv.FindElement(By.XPath(ObjectRepository.Prompts_inputText));
        }
        public static IWebElement Prompts_submit(IWebElement PromptDiv)
        {
            ScanPage(Constants.Prompts);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PromptDiv.FindElement(By.XPath(ObjectRepository.Prompts_submit));
        }
        public static IWebElement Prompts_Div2(IWebElement PromptDiv)
        {
            ScanPage(Constants.Prompts);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PromptDiv.FindElement(By.CssSelector(ObjectRepository.Prompts_Div2));
        }
        public static string Prompts_Text(IWebElement PromptDiv)
        {
            ScanPage(Constants.Prompts);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PromptDiv.FindElement(By.CssSelector(ObjectRepository.Prompts_Text)).Text;
        }

        public static string Prompts_Loader()
        {
            ScanPage(Constants.Prompts);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return ObjectRepository.Prompts_loader;
        }
    }
}
