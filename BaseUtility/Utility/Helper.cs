using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using Common;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using wh = SeleniumExtras.WaitHelpers;
using AutoItX3Lib;
using SeleniumExtras.WaitHelpers;
using CTOS;



namespace BaseUtility.Utility
{
    public class Helper : CommonMethod
    {
        public const string BROWSER_CHROME = "Chrome";
        public const string BROWSER_FIREFOX = "Firefox";
        public const string BROWSER_INTERNETEXPLORER = "Internet Explorer";
        public const string BROWSER_MICROSOFTEDGE = "MicrosoftEdge";

        public static bool AcceptNextAlert = true;

        /// <summary>
        /// This method will click the element on the page.
        /// </summary>
        /// <param name="element">Element to insert the text</param>
        public static void ElementSelectFromDropDown(IWebElement element, string value)
        {
            try
            {
                SelectElement sel = new SelectElement(element);
                AddDelay(1000);
                sel.SelectByText(value);
                AddDelay(3000);
                Logger.WriteInfoMessage("Selected the " + value + " value from the " + CurrentElementName + " drop down.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                Logger.WriteFatalMessage("Unable to select the " + value + " value from the " + CurrentElementName + " drop down.");
                throw;
            }
        }

        public static void HoverOver(IWebElement element)
        {
            try
            {
                AddDelay(2000);
                element.Click();
                AddDelay(3000);
                Logger.WriteInfoMessage("Clicked the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage("Unable to click the " + CurrentElementName + " element on the " + CurrentPageName + " page." + e);
                throw;
            }
        }

        public static void ElementClick(IWebElement element)
        {
            try
            {
                AddDelay(2000);
                element.Click();
                AddDelay(3000);
                Logger.WriteInfoMessage("Clicked the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage("Unable to click the " + CurrentElementName + " element on the " + CurrentPageName + " page." + e);
                throw;
            }
        }

        /// <summary>
        /// Check if an element is available. Need to convert the element to ToString before passing through
        /// </summary>
        /// <param name="by">Type of element</param>
        /// <returns></returns>
        public static bool IsElementPresent(By by)
        {
            try
            {
                Driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }

        public static void DoubleClickElement(string xpath)
        {
            Element = Driver.FindElement(By.XPath(xpath));
            Actions act = new Actions(Driver);
            act.MoveToElement(Element);
            act.Click(Element);
            act.Build().Perform();
            AddDelay(500);
        }

        /// <summary>
        /// This method will double click an element via IWebElement
        /// </summary>
        /// <param name="xpath">xpath of element</param>
        public static void DoubleClickElement(IWebElement element)
        {
            Actions act = new Actions(Driver);
            act.DoubleClick(element).Build().Perform();
            AddDelay(500);
        }

        public static string GetProjectPath(string cases)
        {
            try
            {
                if (cases.Equals("1"))
                {
                    string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
                    string actualPath = path.Substring(0, path.LastIndexOf("/bin"));
                    ProjectPath = new Uri(actualPath).LocalPath;
                }
                else
                {
                    string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
                    string actualPath = path.Substring(0, path.LastIndexOf("/GuestLoyaltyV3"));
                    ProjectPath = new Uri(actualPath).LocalPath;
                }

            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage("Unable to fetch Project location", ex);
            }
            return ProjectPath;
        }

        /// <summary>
        /// Method to chech whether element is Clickable or not.
        /// </summary>
        /// <param name="element">element to be checked</param>
        /// <param name="time">Time until which it have to check</param>
        /// <returns></returns>
        public static IWebElement ElementWait(IWebElement element, int time)
        {
            try
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(time));
                return wait.Until(ExpectedConditions.ElementToBeClickable(element));
            }
            catch(Exception e)
            {
                Logger.WriteErrorMessage("Element not found",e);
            }
            return element;
        }

        public static void WaitTillPageLoadbyXpath(string path, double time)
        {
            By homePage = By.XPath(path);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(time));
            wait.PollingInterval = TimeSpan.FromMilliseconds(50);
            wait.Until(wh.ExpectedConditions.VisibilityOfAllElementsLocatedBy(homePage));
        }

        public static void WaitTillPageLoadbyId(string id, double time)
        {
            By homePage = By.XPath(id);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(time));
            wait.PollingInterval = TimeSpan.FromMilliseconds(50);
            wait.Until(wh.ExpectedConditions.VisibilityOfAllElementsLocatedBy(homePage));
        }

        public static void WaitTillBrowserLoad()
        {
            IWait<IWebDriver> wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(180));
            wait.Until(driver1 => ((IJavaScriptExecutor)Driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        /// <summary>
        /// This method will click the element on the page.
        /// </summary>
        /// <param name="element">Element to insert the text</param>
        public static void ElementClickUsingJavascript(IWebElement element)
        {
            try
            {
                AddDelay(2000);
                IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", element);
                AddDelay(2000);
                Logger.WriteInfoMessage("Clicked the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Unable to click the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
                throw;
            }
        }

        /// <summary>
        /// Method to check if the element is Displayed
        /// </summary>
        /// <param name="element"></param>
        public static bool IsElementVisible(IWebElement element)
        {
            return element.Displayed;
        }

        /// <summary>
        ///  Recursive method for wait till element is visible
        /// </summary>
        /// <param name="data">element for which the visibility have to be checked</param>
        public static void WaittillElementDisplay(IWebElement data)
        {
            while (true)
            {
                bool visible = IsElementVisible(data);
                if (visible)
                {
                    {
                        data.Click();
                    }
                }
                else
                {
                    ElementWait(data, 2000);
                    continue;
                }
                break;
            }
        }

        public static void ElementSelected(IWebElement element)
        {
            try
            {
                while (!element.Selected)
                {
                    AddDelay(1000);
                    element.Click();
                }
                Logger.WriteInfoMessage("Checked the " + CurrentElementName + " checkbox.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Unable to check the " + CurrentElementName + " checkbox.");
            }
        }

        public static void ScrollDown(int width = 0, int height = 600)
        {
            try
            {
                ((IJavaScriptExecutor)Driver).ExecuteScript("window.scroll(" + height + " ," + width + " );");
            }
            catch { }
        }

        public static void DynamicScroll(IWebDriver driver, IWebElement element)
        {
            int location = element.Location.Y;
            try
            {
                bool value = element.Displayed;
                bool value1 = element.Enabled;
                if (value.Equals(true) || value1.Equals(true))
                {
                    if (location < 200)
                    {
                        ScrollDown(location, 0);
                    }
                    else
                    {
                        ScrollDown(location - 200, 0);
                    }
                }
            }
            catch (NoSuchElementException)
            {
                Thread.Sleep(2000);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
                Thread.Sleep(1000);
            }
        }

        public static void DynamicScrollToText(IWebDriver driver, string elementText)
        {
            IWebElement element = Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + elementText + "')]"));
            int location = element.Location.Y;
            try
            {
                bool value = element.Displayed;
                bool value1 = element.Enabled;
                if (value.Equals(true) || value1.Equals(true))
                {
                    if (location < 200)
                    {
                        ScrollDown(location, 0);
                    }
                    else
                    {
                        ScrollDown(location - 200, 0);
                    }
                }
            }
            catch (NoSuchElementException)
            {
                Thread.Sleep(2000);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
                Thread.Sleep(1000);
            }
        }
        /// <summary>
        /// This method will scroll and display an element into view
        /// </summary>
        /// <param name="element"></param>

        public static void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            AddDelay(2000);
        }

        public static void ScrollToText(string text)
        {
            IWebElement element = Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + text + "')]"));
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            AddDelay(2000);
        }

        public static string GetText(IWebElement element)
        {
            string capturedText = element.Text;
            return capturedText;
        }

        public static string GetElementValue(IWebElement element)
        {
            string capturedValue = element.GetAttribute("value").ToString();
            return capturedValue;
        }

        //public static void ElementEnterTextold(IWebElement element, string text)
        //{
        //    try
        //    {
        //        element.Clear();
        //        AddDelay(2500);
        //        element.SendKeys(text);
        //        AddDelay(1500);
        //        Logger.WriteInfoMessage("Inserted text in the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
        //    }
        //    catch (Exception e)
        //    {
        //        Logger.WriteFatalMessage(e);
        //        Logger.WriteFatalMessage("Unable to select text in the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
        //        throw;
        //    }
        //}

        //We have implemented this new CTOS addition
        public static void ElementEnterText(IWebElement element, string text)
        {
            try
            {
                CTOS.Models.IInput input = new CTOS.Input(Driver, element);
                input.EnterInput(text);
                AddDelay(1500);

                Logger.WriteInfoMessage("Inserted text in the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                Logger.WriteFatalMessage("Unable to select text in the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
                throw;
            }
        }

        /// <summary>
        /// Get Enum Description
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetEnumDescription(Enum value)
        {
            string description = value.ToString();
            FieldInfo fi = value.GetType().GetField(value.ToString());
            var attribute = (System.ComponentModel.DescriptionAttribute)fi.GetCustomAttribute(typeof(System.ComponentModel.DescriptionAttribute));
            return attribute.Description;
        }

        /// <summary>
        /// This method will get Page Title.
        /// </summary>
        /// <param name="element">Element to insert the text</param>
        public static void RegexFunction(string PageTitle, string patternstyle)
        {
            try
            {
                string pattern = patternstyle;
                AddDelay(500);
                string PageName = Regex.Replace(PageTitle, pattern, "");
                Logger.WriteDebugMessage("Landed on " + PageName + " page.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Unable to click the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
                throw;
            }
        }

        public static bool IsElementDisplayed(IWebElement element)
        {
            try
            {
                if (element.Displayed)
                {
                    Logger.WriteInfoMessage("The element " + element + " was found on the page.");
                    return true;
                }

            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage("The element " + element + " was not found on the page.");
                Logger.WriteFatalMessage(e);
                return false;

            }
            return false;
        }

        public static void ElementNOTSelected(IWebElement element)
        {
            try
            {
                while (element.Selected)
                {
                    AddDelay(1000);
                    element.Click();
                }
                Logger.WriteInfoMessage("Unchecked the " + CurrentElementName + " checkbox.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Unable to uncheck the " + CurrentElementName + " checkbox.");
            }
        }

        public static string MakeGmailUnique(string usedEmail)
        {

            thisDay = DateTime.Now;

            string[] splitEmail = usedEmail.Split('@');
            string email = splitEmail[0] + "+" + thisDay.ToString(@"yyyyMMdd") + thisDay.Hour + thisDay.Minute + "@" + splitEmail[1];

            return email;
        }

        public static bool IsElementEditable(IWebElement element)
        {
            try
            {
                element.Clear();
            }
            catch (Exception)
            {
                return false;
            }

            return true;


        }

        public static void ScrollPageDown(IWebElement ElementLocator)
        {
            string ElementHolder = "" + ElementLocator + "";
            IWebElement element = Driver.FindElement(By.Id(ElementHolder));
            Actions actions = new Actions(Driver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        public static string Getdata(IWebElement element)
        {
            Contract.Requires(element != null);
            Contract.Assert(String.IsNullOrWhiteSpace(element.GetAttribute("id")) == false, "Empty element 'id' attribute");

            //Build selector to get the element by the browser
            var cssSelector = String.Format("{0}#{1}",
            element.TagName, element.GetAttribute("id"));

            //Get WebDriver to look for elements and execute javaScript
            var webDriver = ((WebElement)element).WrappedDriver;

            //Build and execute the javaScript
            var script = String.Format(@"return $(""{0}"").val()", cssSelector);
            return ((IJavaScriptExecutor)webDriver).ExecuteScript(script) as string;
        }

        public static void PageDown()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("scroll(0,500)");
            AddDelay(1000);
        }

        public static void ValitionMessage(string message)
        {
            try
            {
                if (Helper.VerifyTextOnPage(message))
                {
                    Logger.WriteInfoMessage("Received Proper Validation Message on the page - " + message);
                }
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Could not find valid validation message on the screen - " + message);
                throw;
            }
        }

        public static void ElementClearText(IWebElement element)
        {
            try
            {
                element.Clear();
                AddDelay(1500);
                Logger.WriteInfoMessage("Cleared text in the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Unable to clear text in the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
                throw;
            }
        }

        public static void ControlToNewWindow()
        {
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            AddDelay(5000);
        }

        /// <summary>
        /// Provide the page title and switch to that window
        /// </summary>
        /// <param name="winTitle"></param>
        public static void SwitchToSpecificWindow(string winTitle)
        {
            var listOfWindows = Driver.WindowHandles;
            foreach (var item in listOfWindows)
            {
                if (Driver.SwitchTo().Window(item).Title.Equals(winTitle.Trim()))
                    break;
            }
        }

        /// <summary>
        /// Checks an element to make sure it is checked.
        /// </summary>
        /// <param name="element">element to be validate if it is checked</param>
        public static void MakeSureIsChecked(IWebElement element)
        {
            while (!element.Selected)
            {
                element.Click();
            }
            Logger.WriteInfoMessage("The element " + element + " is selected.");
        }

        /// <summary>
        /// Method to close new tab
        /// </summary>
        public static void CloseCurrentTab()
        {
            //((IJavaScriptExecutor)Driver).ExecuteScript("close();");
            Driver.Close();
            ControlToPreviousWindow();
            AddDelay(5000);
        }

        /// <summary>
        /// Method to navigate back to previous NEW WINDOW.
        /// </summary>
        public static void ControlToPreviousWindow()
        {
            Driver.SwitchTo().Window(Driver.WindowHandles.First());
            AddDelay(5000);
        }

        public static void ControlToNextWindow()
        {
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            AddDelay(5000);
        }

        /// <summary>
        /// This function will close the popup and return to the original window.
        /// </summary>
        public static void ClosePopUpWindow()
        {
            Driver.Close();
            Driver.SwitchTo().Window(UIWindow);
        }

        /// <summary>
        /// This method will make the new popup window active.
        /// </summary>
        /// <param name="element">element that causes the popup to appear.</param>
        public static void OpenPopUpWindow(IWebElement element)
        {
            //Set current window
            UIWindow = Driver.CurrentWindowHandle;
            PopupWindowFinder finder = new PopupWindowFinder(Driver);
            string popupWindow = finder.Click(element);
            Driver.SwitchTo().Window(popupWindow);
            if (BrowserType != "Chrome")
                Driver.Manage().Window.Maximize();
            //AddDelay(2000);

        }

        public static void ReloadPage()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("location.reload(true)");
        }

        /// <summary>
        /// This function will search a text on the page and highlight it.
        /// </summary>
        /// <param name="text">Text to find</param>
        /// <returns></returns>
        public static void VerifyTextOnPageAndHighLight(string text)
        {
            IList<IWebElement> list = Helper.Driver.FindElements(By.XPath("//*[contains(text(),'" + text + "')]"));
            int count = 0;
            foreach (IWebElement value in list)
            {
                if (count == 2)
                    break;
                if (value.Text.Contains(text.Trim()))
                {
                    HighlightElement(value);
                    count++;
                    Logger.WriteInfoMessage(text + " Found on the page");
                }
            }
            if (count == 0)
            {
                Assert.Fail(text + "Text not found");
            }
        }

        public static void ClickTextOnPage(string text)
        {
            Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + text + "')]")).Click();

        }

        public static Boolean IsElementRemoved(string text)
        {
            try
            {
                Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + text + "')]"));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }

        public static Boolean IsWebElementRemoved(IWebElement element)
        {
            try
            {
                if (element.Displayed)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        public static void RemoveHighLight(string text)
        {
            IList<IWebElement> list = Helper.Driver.FindElements(By.XPath("//*[contains(text(),'" + text + "')]"));
            int count = 0;
            foreach (IWebElement value in list)
            {
                if (value.Text.Contains(text))
                {
                    RemoveHighlightElement(value);
                    count++;
                    Logger.WriteInfoMessage(text + "Highlighter remove from page");
                }
            }
            if (count == 0)
            {
                Assert.Fail(text + "Text not found");
            }
        }

        /// <summary>
        /// Method to highlight a Tab on a Click
        /// </summary>
        /// <param name="element">element that have to high lighted</param>
        /// 
        public static void HighlightElement(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].scrollIntoView(false);", element);
            js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", element,
                "color: black; background-color: yellow");
            //Thread.Sleep(2000);
            //js.ExecuteScript("arguments[0].setAttribute('style', arguments[1], arguments[2]);", element, "");
            AddDelay(2000);
        }

        public static void RemoveHighlightElement(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].scrollIntoView(false);", element);
            js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", element,
                "color: black; background-color: white");
            //Thread.Sleep(2000);
            //js.ExecuteScript("arguments[0].setAttribute('style', arguments[1], arguments[2]);", element, "");
            AddDelay(2000);
        }

        public static void CloseWindow()
        {
            AddDelay(5000);
            Driver.Close();
        }

        public static void OpenNewTab()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.open();");
            ControlToNewWindow();
            AddDelay(5000);
        }

        public static void ExitFrame()
        {
            Logger.WriteInfoMessage("Switching out of the iFrame.");
            Driver.SwitchTo().ParentFrame();
            AddDelay(1000);
        }

        public static void EnterFrame(string frameID)
        {
            AddDelay(5000);
            IWebElement frameElement = Driver.FindElement(By.Id(frameID));
            Logger.WriteInfoMessage("Switching into the iFrame.");
            Driver.SwitchTo().Frame(frameElement);
            AddDelay(1000);
            //frameElement.SendKeys("text");

        }

        public static void EnterFrameByxPath(IWebElement frameElement)
        {
            AddDelay(5000);
            Logger.WriteInfoMessage("Switching into the iFrame.");
            Driver.SwitchTo().Frame(frameElement);
            AddDelay(1000);
            //frameElement.SendKeys("text");

        }

        public static void EnterFrame_ByName(string frameName)
        {
            AddDelay(5000);
            IWebElement frameElement = Driver.FindElement(By.Name(frameName));
            Logger.WriteInfoMessage("Switching into the iFrame.");
            Driver.SwitchTo().Frame(frameElement);
            AddDelay(1000);
        }
        /// <summary>
        /// This function will make the string unique by adding the date and time to the end of it. 
        /// </summary>
        /// <param name="name">String to make unique</param>
        /// <returns>Unique string</returns>
        public static string MakeUnique(string name)
        {
            thisDay = DateTime.Now;
            name = name + " " + thisDay.ToString("hhmmss") + " " + thisDay.ToString("MMddyy");
            return name;
        }

        /// <summary>
        /// This method will enter text into an element.
        /// </summary>
        /// <param name="element">Element to insert the text</param>
        /// <param name="text">Text to be inserted</param>
        //public static void ElementEnterTextUsingJQueryById(string Id, string text)
        //{
        //    try
        //    {
        //        IJavaScriptExecutor jsw = (IJavaScriptExecutor)Helper.Driver;
        //        jsw.ExecuteScript("$('#" + Id + "').val('')");
        //        jsw.ExecuteScript("$('#" + Id + "').val(\"" + text + "\")");
        //        Logger.WriteInfoMessage("Inserted text in the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
        //    }
        //    catch (Exception e)
        //    {
        //        Logger.WriteFatalMessage(e);
        //        Logger.WriteFatalMessage("Unable to insert text in the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
        //        throw;
        //    }
        //}
        public static void ElementEnterTextUsingJQuery(IWebElement element, string text)
        {
            try
            {
                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].value ='" + text + "';", element);
                Logger.WriteInfoMessage("Inserted text in the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                Logger.WriteFatalMessage("Unable to insert text in the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
                throw;
            }
        }
        /// <summary>
        /// This method will enter text into an element.
        /// </summary>
        /// <param name="element">Element to insert the text</param>
        /// <param name="text">Text to be inserted</param>

        public static void ElementEnterFirsName(IWebElement element, string text)
        {
            try
            {
                element.Click();
                Driver.FindElement(By.Id("firstextbox")).Clear();
                Driver.FindElement(By.Id("firstextbox")).SendKeys(text);
                Driver.FindElement(By.Id("firstextbox")).SendKeys(Keys.Enter);

            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                Logger.WriteFatalMessage("Unable to select text in the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
                throw;

            }
        }

        public static void ElementEnterLastname(IWebElement element, string text)
        {
            try
            {
                element.Click();
                Driver.FindElement(By.Id("lasttextbox")).Clear();
                Driver.FindElement(By.Id("lasttextbox")).SendKeys(text);
                Driver.FindElement(By.Id("lasttextbox")).SendKeys(Keys.Enter);

            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                Logger.WriteFatalMessage("Unable to select text in the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
                throw;

            }
        }

        /// <summary>
        /// This method will throw an exception if the text is not found on the page.
        /// </summary>
        /// <param name="text">Text to find on the page.</param>
        public static void ValidateTextOnPage(string text)
        {
            try
            {
                if (VerifyTextOnPage(text))
                {
                    //HighlightText(text);
                    Logger.WriteInfoMessage("Found the text: '" + text + "' on the " + CurrentPageName + " page.");
                }
                else throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Did not find the text: '" + text + "' on the " + CurrentPageName + " page.");
                throw;
            }
        }

        /// <summary>
        /// This function will make the email a unique value.
        /// </summary>
        /// <returns></returns>
        public static string MakeCatchAllUnique(string usedEmail)
        {

            thisDay = DateTime.Now;

            string[] splitEmail = usedEmail.Split('@');
            string email = splitEmail[0] + thisDay.ToString(@"yyyyMMdd") + thisDay.Hour + thisDay.Minute + "@" + splitEmail[1];

            return email;
        }

        public static void PageUp()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("scroll(0,-270)");
        }

        /// <summary>
        /// This method will hover over a link.
        /// </summary>
        /// <param name="element"></param>
        public static void ElementHover(IWebElement element)
        {
            Actions actions = new Actions(Helper.Driver);
            AddDelay(500);
            actions.MoveToElement(element).Build().Perform();
            AddDelay(500);
        }
        /// <summary>
        /// This method will hover over a Text.
        /// </summary>
        /// <param name="element"></param>
        public static void HoverOverText(string value)
        {
            IWebElement element = Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + value + "')]"));
            Actions actions = new Actions(Helper.Driver);
            AddDelay(500);
            actions.MoveToElement(element).Build().Perform();
            AddDelay(500);
        }

        public static string GetProjectLocation()
        {
            try
            {
                string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
                string actualPath = path.Substring(0, path.LastIndexOf("/bin"));
                Project_Path = new Uri(actualPath).LocalPath;
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage("Unable to fetch Project location", ex);
            }
            return Project_Path;
        }

        /// <summary>
        /// This method will search the page to see if an element exists.
        /// </summary>
        /// <param name="element">Element to check if it exists on the page.</param>
        /// <returns></returns>
        public static bool VerifyElementOnPage(IWebElement element)
        {
            try
            {
                AddDelay(1500);
                if (element.Displayed)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        public static string CommonUniqueTestCatchAll()
        {
            return MakeCatchAllUnique("Cendynautomationqa@cendyn17.com");
        }

        public static void Keyboard_Enter()
        {
            Actions action = new Actions(Driver);

            action.SendKeys(Keys.Enter).Build().Perform();
        }

        public static void Keyboard_Esc()
        {
            Actions action = new Actions(Driver);

            action.SendKeys(OpenQA.Selenium.Keys.Escape);
            //Element = Driver.FindElement(By.XPath("//*[@id='searchBoxTheme']"));
            //Element.SendKeys(Keys.Escape);
            Driver.FindElement(By.TagName("body")).SendKeys(Keys.Escape);
        }

        public static int CountWindowTabs()
        {
            String originalWindowHandle = Driver.CurrentWindowHandle;

            Thread.Sleep(3000);
            System.Collections.ObjectModel.ReadOnlyCollection<string> windowHandles = Driver.WindowHandles;

            return windowHandles.Count;
        }

        public static void RenewDriver()
        {

            int getcounts = CountWindowTabs();
            getcounts = getcounts - 1;
            if (getcounts > 1)
            {
                for (int i = getcounts; i > 0; i--)
                {
                    Driver.SwitchTo().Window(Driver.WindowHandles[i]);
                    CloseCurrentTab();
                }
            }
            //Driver.Close();
            //Driver.Quit();
            ////Ignore unsecured web warning
            ////var profile = new FirefoxProfile();
            ////profile.SetPreference("webdriver_assume_untrusted_issuer", false);

            //if (BrowserType == "Chrome")
            //{
            //    Driver = new ChromeDriver();
            //    Driver.Manage().Window.Maximize();
            //}
            //if (BrowserType == "Mozilla")
            //{
            //    var profile = new FirefoxOptions();
            //    profile.AcceptInsecureCertificates = true;
            //    Driver = new FirefoxDriver(profile);
            //    Driver.Manage().Window.Maximize();
            //    //Driver = new FirefoxDriver(profile);
            //}
            //if (BrowserType == "InternetExplorer")
            //{
            //    Driver = new InternetExplorerDriver();
            //    Driver.Manage().Window.Maximize();
            //}

        }

        public static void WaitUntilElementNotVisible(By searchElementBy, int timeoutInSeconds)
        {
            try
            {
                new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds))
                            .Until(drv => !Helper.IsElementPresent(searchElementBy));
            }
            catch (Exception ex)
            {
                ex = new Exception("Data Tables failed to load within " + timeoutInSeconds + "secs. ");
                TestHandling.TestFailed(ex);
            }
        }

        public static bool PageLoadWait(int time, string Url)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(time));
            //bool GetURL = Driver.Url.Contains(urlcontains);
            return wait.Until(ExpectedConditions.UrlContains(Url));
        }

        public static void Navigatetoiframe(int caseNum, string frameid = null)
        {
            switch (caseNum)
            {
                case 0:
                    {
                        Driver.SwitchTo().ParentFrame();
                        break;
                    }
                case 1:
                    {
                        Driver.SwitchTo().ParentFrame();
                        IJavaScriptExecutor js = (IJavaScriptExecutor)Helper.Driver;
                        var getIndex = js.ExecuteScript("return jQuery('iframe').length;");
                        //var getIndex = js.ExecuteScript("");
                        var frameName = "iframe_modal_" + (Convert.ToInt32(getIndex) - 1);
                        Driver.SwitchTo().Frame(frameName);
                        break;
                    }
                case 2:
                    {
                        Driver.SwitchTo().ParentFrame();
                        IJavaScriptExecutor js = (IJavaScriptExecutor)Helper.Driver;
                        var getIndex = js.ExecuteScript("return jQuery('iframe').length;");
                        //var getIndex = js.ExecuteScript("");
                        var frameName = "iframe_modal_" + (Convert.ToInt32(getIndex) - 2);
                        Driver.SwitchTo().Frame(frameName);
                        break;
                    }
                case 3:
                    {
                        var frameName = "iframe_modal_0";
                        Driver.SwitchTo().Frame(frameName);
                        break;
                    }
                case 4:
                    Driver.SwitchTo().ParentFrame();
                    Driver.SwitchTo().Frame(3);
                    break;
                case 5:
                    /*index navigation*/
                    Driver.SwitchTo().ParentFrame();
                    Driver.SwitchTo().Frame(frameid);
                    break;

            }
        }

        /// <summary>
        /// This method is for drop downs that don't allow text to be sent to them.
        /// Fraser uses some of these
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SecondaryDropDown(IWebElement element, string value)
        {
            int count = 1;
            do
            {
                element.SendKeys(Keys.Down);
                AddDelay(1000);
                count++;
                if (count > 100)
                {
                    throw new Exception("The salutation was not found on the Fraser kiosk.");
                }
            } while (element.GetAttribute("value") != value);
        }

        /// <summary>
        /// This method will select a value from the drop down.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void OLDDROPDOWNDONOTUSE(IWebElement element, string value)
        {
            while (element.Text != value)
            {
                string newVal = element.Text;
                //element.Click();
                AddDelay(1500);
                element.SendKeys(value);
                AddDelay(1500);
                Driver.Navigate().Refresh();
                //element.SendKeys(Keys.Enter);
                newVal = element.Text;
            }
        }

        /// <summary>
        /// This method will return "true" if the element is clickable
        /// This method will return "false" if the element is not clickable"
        /// Passing a webelement
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static bool VerifyElementIsClickable(IWebElement element)
        {
            try
            {

                if (element.Enabled)
                    return true;
            }
            catch (Exception)
            {

            }
            return false;
        }

        /// <summary>
        /// This method will return "true" if the element is clickable
        /// This method will return "false" if the element is not clickable"
        /// Passing a string to be converted to an element.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static bool VerifyElementIsClickable(string xpath)
        {

            try
            {
                IWebElement element = Driver.FindElement(By.XPath(xpath));
                if (element.Enabled)
                    return true;
            }
            catch (Exception)
            {

            }
            return false;
        }

        /// <summary>
        ///  Method for ScrollToElement in upward direction using Javascript.
        /// </summary>
        ///  ///
        /// <param name="driver"></param>
        /// <param name="lenght">Length till which we need to scroll</param>
        public static void ScrollUpUsingJavaScript(IWebDriver driver, int lenght)
        {
            if (driver == null) throw new ArgumentNullException("driver");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(" + lenght + ",0)");
        }

        /// <summary>
        ///  Method for ScrollToElement using Javascript.
        /// </summary>
        ///  ///
        /// <param name="driver"></param>
        /// <param name="lenght">Length till which we need to scroll</param>
        public static void ScrollDownUsingJavaScript(IWebDriver driver, int lenght)
        {
            if (driver == null) throw new ArgumentNullException("driver");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0," + lenght + ")");
        }

        /// <summary>
        /// Method to get the path for the working directory
        /// </summary>
        /// <returns></returns>
        public static string GetProjectPath()
        {
            try
            {
                string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
                string actualPath = path.Substring(0, path.LastIndexOf("/bin"));
                ProjectPath = new Uri(actualPath).LocalPath;
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage("Unable to fetch Project location", ex);
            }
            return ProjectPath;
        }

        public static void NewBrowser()
        {
            IJavaScriptExecutor jscript = Driver as IJavaScriptExecutor;
            jscript.ExecuteScript("window.open()");

            List<string> handles = Driver.WindowHandles.ToList<string>();
            Driver.SwitchTo().Window(handles.Last());
        }

        public static int GetElementHeight(IWebElement element)
        {
            int height = element.Size.Height;
            return height;

        }

        /// <summary>
        ///This method handle alert and return the value
        /// return Alert accept / Alert dismiss
        /// </summary>
        public static void CloseAlert()
        {
            try
            {
                IAlert alert = Driver.SwitchTo().Alert();

                if (AcceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }

            }
            finally
            {
                AcceptNextAlert = true;
            }
        }

        /// <summary>
        ///  Method to click an element that will open a window to find a file to select.
        /// </summary>
        /// <param name="element">The element that is clicked to display the upload file display</param>
        /// <param name="fileLocation">Location of the file the user wants to upload</param>
        public static void UploadFile(IWebElement element, string fileLocation)
        {
            //*** Upload image- Begin***//
            var Au3 = new AutoItX3();
            if (BrowserType == "Mozilla")
            {
                /**Upload Method for Mozilla browser using Au3 freeWare scripting commands-Start**/
                element.Click();
                AddDelay(1500);
                //Au3.("File Upload");
                //Au3.Send(fileLocation);
                AddDelay(1500);
                //Au3.Send("{ENTER}");
                Logger.WriteInfoMessage("File uploaded Successfully");
                /**Upload Method for Mozilla browser using Au3 freeWare scripting commands-Start**/

            }
            else
            {
                /** Upload method for IE and Chrome -Begin **/
                element.Click();
                AddDelay(3500);
                Au3.Send(fileLocation);
                AddDelay(2000);
                Au3.Send("{ENTER}");
                AddDelay(2000);
                Logger.WriteInfoMessage("File uploaded successfully");
                /** Upload method for IE and Chrome -End **/
            }
            /*** Upload image- End***/

        }

        /// <summary>
        /// This method will select the value from the drop down menu.
        /// </summary>
        /// <param name="element">Drop down element</param>
        /// <param name="value">Value to select</param>
        public static void ElementSelectFromDropDownByValue(IWebElement element, string value)
        {
            try
            {
                SelectElement sel = new SelectElement(element);
                sel.SelectByValue(value);
                AddDelay(3000);
                Logger.WriteInfoMessage("Selected the " + value + " value from the " + CurrentElementName + " drop down.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                Logger.WriteFatalMessage("Unable to select the " + value + " value from the " + CurrentElementName + " drop down.");
                throw;
            }
        }

        public static void HighlightText(string content)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            //js.ExecuteScript("arguments[0].setAttribute('style', arguments[1], arguments[2]);", content,
            //    "color: black; border: 3px solid yellow; background-color: yellow");
            //Thread.Sleep(2000);
            js.ExecuteScript("arguments[0].setAttribute('style', arguments[1], arguments[2]);", content);
            AddDelay(2000);
        }

        /// <summary>
        /// This function will return the current date and time in MMdd HOURMINUTE format.
        /// </summary>
        /// <returns></returns>
        public static string AddDateTime()
        {
            thisDay = DateTime.Now;
            return thisDay.ToString(@"MMdd") + " " + thisDay.Hour + thisDay.Minute;
        }

        /// <summary>
        /// This method will return the length of the string
        /// </summary>
        /// <param name="stringLen">String to count the length.</param>
        /// <returns></returns>
        public static int StringLength(string stringLen)
        {
            int x = stringLen.Length;
            return x;
        }

        /// <summary>
        /// This method will execute backspaces.
        /// </summary>
        /// <param name="element">Element to perform the backspaces on.</param>
        /// /// <param name="text">Text to enter inside the field after it has been cleared.</param>
        public static void ClearField(IWebElement element, string text)
        {
            for (int i = 0; i < 50; i++)
            {
                element.SendKeys(Keys.Delete);
            }

            for (int i = 0; i < 50; i++)
            {
                element.SendKeys(Keys.Backspace);
            }
            element.SendKeys(text);
        }

        /// <summary>
        /// This method will select the value from the drop down menu by typing in the value then selecting it from the displayed drop down.
        /// </summary>
        /// <param name="element">Drop down element</param>
        /// <param name="value">Value to select</param>
        public static void ElementSelectFromDropDownDownAndClick(IWebElement element, string value)
        {
            try
            {
                AddDelay(1500);
                element.Click();
                AddDelay(1000);
                ClearField(element, value);
                AddDelay(1500);
                element.SendKeys(Keys.Down);
                AddDelay(1000);
                element.SendKeys(Keys.Enter);
                AddDelay(3000);
                Logger.WriteInfoMessage("Selected the " + value + " value from the " + CurrentElementName + " drop down.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                Logger.WriteFatalMessage("Unable to select the " + value + " value from the " + CurrentElementName + " drop down.");
                throw;
            }
        }

        public static void VerifyFileExists(string Path)
        {
            string curFile = Path;
            Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");
        }

        public static void SetBrowserZoom(int level)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript(string.Format("document.body.style.zoom='{0}%'", level));
        }

        public static void WaitTillInvisibilityOfLoader(By xpath, int time)
        {
            try
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(time));
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(xpath));
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage($"Loader is still present {e}");
                throw e;
            }
        }

        public static void FindLoaderAndWaitTillHide(string xpath)
        {
            int count = 0;
            try
            {
                IWebElement loader = Driver.FindElement(By.XPath(xpath));
                while (loader.Displayed)
                {
                    AddDelay(1000);
                    loader = Driver.FindElement(By.XPath(xpath));
                    count = count + 1;
                    if (count > 10)
                        break;
                }
            }
            catch (Exception) { }
        }
        /// <summary>
        /// This method will return the first row value of the provided column name from the table
        /// It can use only for Member Stays table
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>

        public static string GetValueFromMemberStayTablesByProvidingColumnNameofTheFirstRow(string columnName)
        {
            IList<IWebElement> thColumn = Helper.Driver.FindElements(By.XPath("//div[@id='staysTable']/descendant::table/descendant::th"));
            int coulmnIndex = 0;
            string value;
            foreach (var item in thColumn)
            {
                coulmnIndex = coulmnIndex + 1;
                if (columnName.Equals(item.GetAttribute("innerHTML")))
                    break;
            }
            value = Helper.Driver.FindElement(By.XPath("//div[@id='staysTable']/descendant::table/descendant::th[contains(text(),'" + columnName + "')]/ancestor::table/parent::div/parent::div/following-sibling::div/descendant::tbody/child::tr[1]/child::td[" + coulmnIndex + "]")).GetAttribute("innerHTML");
            return value;
        }

        public static string GetRandomAlphaNumericString(int charlimit)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[charlimit];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            return finalString;
        }

        public static bool VerifyTextOnPageAndHighLightAndReturn(string text)
        {
            IList<IWebElement> list = Helper.Driver.FindElements(By.XPath("//*[contains(text(),'" + text + "')]"));
            int count = 0;
            foreach (IWebElement value in list)
            {

                if (count == 2)
                    break;

                if (value.Text.Contains(text.Trim()))
                {
                    HighlightElement(value);
                    count++;
                    Logger.WriteInfoMessage(text + " Found on the page");
                }

            }
            return true;
            if (count == 0)
            {
                return false;
            }
        }

        /// <summary>
        /// This method Wait for an Ajax call to complete with Selenium WebDriver using conditional sleep
        /// </summary>
        /// <param name="timeoutInSeconds"></param>
        public static void WaitForAjaxControls(int timeoutInSeconds)
        {
            Console.WriteLine("Querying active AJAX controls by calling jquery.active");

            try
            {
                if (Driver is IJavaScriptExecutor)
                {
                    IJavaScriptExecutor jsDriver = (IJavaScriptExecutor)Driver;
                    for (int i = 0; i < timeoutInSeconds; i++)
                    {
                        Object numberOfAjaxConnections = jsDriver.ExecuteScript("return jQuery.active");
                        // return should be a number
                        if (numberOfAjaxConnections is long)
                        {

                            long n = (long)numberOfAjaxConnections;
                            Console.WriteLine("Number of active jquery AJAX controls: "
                                            + n);
                            if (n.Equals(0L))
                                break;
                        }
                        Thread.Sleep(1000);
                    }
                }
                else
                {
                    Console.WriteLine("Web driver: " + Driver
                            + " can't run javascript.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static string GetValue(IWebElement element)
        {
            string capturedText = element.GetAttribute("value");
            return capturedText;
        }

        public static void ElementClickNoLog(IWebElement element)
        {
            try
            {
                AddDelay(2000);
                element.Click();
                AddDelay(3000);
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage("Unable to click the " + element + " page." + e);
                throw;
            }
        }

        public static int GetRandomNumber(int charlimit)
        {
            var chars = "0123456789";
            var stringChars = new char[charlimit];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);

            return Convert.ToInt32(finalString);
        }

        public static IWebElement ElementWaitByLocator(string xpath, int time)
        {
            By ele = By.XPath(xpath);
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(time));
            return wait.Until(ExpectedConditions.ElementIsVisible(ele));
        }

        public static void DragAndDrop(IWebElement element1, IWebElement element2)
        {
            var action = new Actions(Driver);
            var dragAndDrop = action.ClickAndHold(element1).MoveToElement(element2).Release(element1).Build();
            dragAndDrop.Perform();
        }
        /// <summary>
        /// Return the date by adding the given days into the current date
        /// </summary>
        /// <param name="days"></param>
        public static string GetFutureDateByProvidingDays(int days)
        {
            DateTime today = DateTime.Now;
            DateTime futureDate = today.AddDays(days);
            return futureDate.ToString("MM-dd-yyyy");
        }

        public static string GetDate(int addDays = 0)
        {
            return DateTime.Now.AddDays(addDays).ToString("MMM dd, yyyy");
        }

        public static IList<IWebElement> GetWebElements(By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
                wait.Until(ExpectedConditions.ElementToBeClickable(locator));
                return Driver.FindElements(locator);
            }
            catch
            {
                return null;
            }
        }

        public static DriverOptions GetBrowserDriverOptions(string browser)
        {
            switch (browser)
            {
                case BROWSER_CHROME:
                    return new ChromeOptions();
                case BROWSER_FIREFOX:
                    return new FirefoxOptions();
                case BROWSER_MICROSOFTEDGE:
                    return new EdgeOptions();
                case BROWSER_INTERNETEXPLORER:
                    return new InternetExplorerOptions();
                default:
                    return null;
            }
        }
    }
}
