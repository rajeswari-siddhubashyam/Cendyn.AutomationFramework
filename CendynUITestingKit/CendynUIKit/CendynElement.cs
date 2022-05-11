using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Drawing;
using OpenQA.Selenium;
using System.Threading;

namespace CendynUIKit
{
    public class CendynElement
    {
        /// <summary>
        /// The time it will take for the test to fail a single action in milliseconds.
        /// </summary>
        public int TimeoutInMs = 15000;

        /// <summary>
        /// The time an action will wait before trying again in milliseconds.
        /// </summary>
        public int RetryTimeoutInMs = 1000;

        private IWebElement _lazyLoadElement;
        protected readonly IWebDriver _driver;
        protected By _selector;

        protected IWebElement _webElement
        {
            get
            {
                if (_lazyLoadElement == null)
                    TryAndWait(() => _lazyLoadElement = _driver.FindElement(_selector), 2000, 1000);
                return _lazyLoadElement;
            }
        }
        protected string TagName { get => _webElement.TagName; }
        protected string Text { get => _webElement.Text; }
        protected bool Enabled { get => _webElement.Enabled; }
        protected bool Selected { get => _webElement.Selected; }
        protected Point Location { get => _webElement.Location; }
        protected Size Size { get => _webElement.Size; }
        protected bool Displayed { get => _webElement.Displayed; }

        public CendynElement(IWebDriver driver, By selector)
        {
            _driver = driver;
            this._selector = selector;
        }
        
        public CendynElement(IWebDriver driver, IWebElement webElement)
        {
            _driver = driver;
            _lazyLoadElement = webElement;
        }

        public CendynElement(IWebDriver driver, CendynElement cendynElement)
        {
            _driver = driver;
            _lazyLoadElement = cendynElement._webElement;
        }

        public string GetDomAttribute(string attributeName)
            => _webElement.GetDomAttribute(attributeName);

        public string GetDomProperty(string propertyName)
            => _webElement.GetDomProperty(propertyName);

        public string GetCssValue(string propertyName)
            => _webElement.GetCssValue(propertyName);

        protected ISearchContext GetShadowRoot()
            => _webElement.GetShadowRoot();

        protected void Click()
            => TryAndWait(() => _webElement.Click());
        protected void SendKeys(string text)
            => TryAndWait(() => _webElement.SendKeys(text));
        protected void Clear()
            => TryAndWait(() => _webElement.Clear());
        protected void Submit()
            => TryAndWait(() => _webElement.Submit());

        /// <summary>
        /// Finds an element in relation to the current element. Selectors will begin their position starting from this element.
        /// </summary>
        /// <param name="by">Target selector.</param>
        /// <returns></returns>
        public IWebElement FindElement(By by)
        {
            IWebElement element = null;
            TryAndWait(() => element = _webElement.FindElement(by));
            return element;
        }

        /// <summary>
        /// Finds an element in relation to the current element. Selectors will begin their position starting from this element.
        /// </summary>
        /// <param name="by">Target selector.</param>
        /// <param name="timeoutMs">Timeout in milliseconds.</param>
        /// <param name="retryTimeout">Time to wait before trying again in milliseconds.</param>
        /// <returns></returns>
        public IWebElement FindElement(By by, int timeoutMs, int retryTimeout)
        {
            IWebElement element = null;
            TryAndWait(() => element = _webElement.FindElement(by), timeoutMs, retryTimeout);
            return element;
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            ReadOnlyCollection<IWebElement> elements = null;
            TryAndWait(() => elements = _webElement.FindElements(by));
            return elements;
        }

        /// <summary>
        /// Waits the specified timeoutMs and retries every retryTimeout interval.
        /// </summary>
        /// <param name="action">Action to run, such as clicking an element.</param>
        /// <param name="timeoutMs">Timeout in milliseconds.</param>
        /// <param name="retryTimeout">Time to wait before trying again in milliseconds.</param>
        protected void TryAndWait(Action action, int timeoutMs = 16000, int retryTimeout = 1000)
            => TryAndWait(action, CancellationToken.None, timeoutMs, retryTimeout);

        /// <summary>
        /// Waits the specified timeoutMs and retries every retryTimeout interval.
        /// </summary>
        /// <param name="action">Action to run, such as clicking an element.</param>
        /// <param name="cancellationToken">Cancellation token to be used for waiting.</param>
        /// <param name="timeoutMs">Timeout in milliseconds.</param>
        protected void TryAndWait(Action action, CancellationToken cancellationToken, int timeoutMs = 16000, int retryTimeout = 1000)
        {
            if (retryTimeout < 100)
                throw new ArgumentException("retryTimeout can not be less than 100 milliseconds.");

            var i = 0;
            while (i < (timeoutMs / retryTimeout))
            {
                try
                {
                    // First run could succeed instantly. Try it first.
                    if (i == 0)
                    {
                        action.Invoke();
                        return;
                    }

                    // If first run fails, wait timeoutMs since it failed instantly, then retry.
                    if (i != 0)
                    {
                        Task.Delay(retryTimeout, cancellationToken).Wait();
                        action.Invoke();
                        return;
                    }
                }
                catch
                {
                    i++;

                    if (i == (timeoutMs / retryTimeout))
                        throw;
                };
            }
        }
    }
}