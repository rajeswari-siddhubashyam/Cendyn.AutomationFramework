using Common;
using InfoMessageLogger;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace BaseUtility.PageObject
{
    public class PageAction : CommonMethod
    {
        public static IWebElement Error;

        public static IWebElement Find_ElementId(string repoName)
        {
            try
            {
                //Grab the element
                Element = Driver.FindElement(By.Id(repoName));
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage("The " + repoName + " element was not found on the page.", ex);
            }
            return Element;
        }

        public static IWebElement Find_ElementXPath(string repoName)
        {
            try
            {
                Element = null;
                //Grab the element
                Element = Driver.FindElement(By.XPath(repoName));
                
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage("The " + repoName + " element was not found on the page.", ex);

            }
           return Element;
        }

        public static IWebElement Find_ElementLinkText(string repoName)
        {
            try
            {
                //Grab the element
                Element = Driver.FindElement(By.LinkText(repoName));
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage("The " + repoName + " element was not found on the page.", ex);
            }
            return Element;
        }

        public static IWebElement Find_ElementPartialLinkText(string repoName)
        {
            try
            {
                //Grab the element
                Element = Driver.FindElement(By.PartialLinkText(repoName));
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage("The " + repoName + " element was not found on the page.", ex);
            }
            return Element;
        }

        public static IWebElement Find_ElementClassName(string repoName)
        {
            try
            {
                //Grab the element
                Element = Driver.FindElement(By.ClassName(repoName));
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage("The " + repoName + " element was not found on the page.", ex);
            }
            return Element;
        }

        public static IWebElement Find_ElementCssSelector(string repoName)
        {
            try
            {
                //Grab the element
                Element = Driver.FindElement(By.CssSelector(repoName));
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage("The " + repoName + " element was not found on the page.", ex);
            }
            return Element;
        }

        public static IWebElement Find_ElementName(string repoName)
        {
            try
            {
                //Grab the element
                Element = Driver.FindElement(By.Name(repoName));
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage("The " + repoName + " element was not found on the page.", ex);
            }
            return Element;
        }

        public static IList<IWebElement> Find_ElementsXPath(string repoName)
        {
            try
            {
                Elements = null;
                //Grab the element
                Elements = Driver.FindElements(By.XPath(repoName));

            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage("The " + repoName + " element was not found on the page.", ex);

            }
            return Elements;
        }

        public static IList<IWebElement> Find_ElementsID(string repoName)
        {
            try
            {
                Elements = null;
                //Grab the element
                Elements = Driver.FindElements(By.Id(repoName));

            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage("The " + repoName + " element was not found on the page.", ex);

            }
            return Elements;
        }
    }
}
