using CTOS;
using CTOS.Components;
using CTOS.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace CTOSTests.Tests
{
    [TestFixture]
    public class CTOSTests
    {
        IWebDriver driver;
        NavigationPanel NavBar;

        [OneTimeSetUp]
        public void SetUp()
        {
            // This can be put into a test case, like original framework
            // Quick add here for demonstration

            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            chromeOptions.AddArgument("enable-automation");
            chromeOptions.AddArgument("--disable-infobars");
            chromeOptions.AddArgument("no-sandbox");

            driver = new ChromeDriver(chromeOptions);
            _ = driver.Manage().Timeouts().ImplicitWait;
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["BaseURL"]);
            Task.Delay(3000).Wait();
            NavBar = new NavigationPanel(driver, By.XPath("//*[@id='sidebar']"));
            try
            {
                driver.SwitchTo().Alert().Accept();
            }
            catch
            {

            }
        }

        [Test]
        public void TestingCalendar()
		{
            NavBar.NavigateTo("C-DatePicker");
            var Calendar1 = new DatePicker(driver, By.XPath("(//span[contains(@class, 'e-input-group e-control-wrapper e-date-wrapper')])[1]"));
            var Calendar2 = new DatePicker(driver, By.XPath("(//span[contains(@class, 'e-input-group e-control-wrapper e-date-wrapper')])[2]"));
            var Calendar3 = new DatePicker(driver, By.XPath("(//span[contains(@class, 'e-input-group e-control-wrapper e-date-wrapper')])[3]"));
            var Calendar4 = new DatePicker(driver, By.XPath("(//span[contains(@class, 'e-input-group e-control-wrapper e-date-wrapper')])[4]"));

            Calendar1.SetDateByInput(DateTime.Today.AddYears(-1).AddMonths(2));
            Calendar1.SetDateByInput(DateTime.Now);

            Calendar1.OpenCalendar();
            Calendar1.SetDateByGUI(DateTime.Now.AddDays(-30));
            Calendar1.OpenCalendar();
            Calendar1.SetDateByGUI(DateTime.Now.AddDays(12));

            Calendar2.OpenCalendar();
            Calendar2.SetDateByGUI(DateTime.Today.AddYears(-1).AddMonths(1));

            Calendar4.OpenCalendar();
            Calendar4.SetDateByGUI(DateTime.Now.AddDays(12));
            Calendar4.SetDateByInput(DateTime.Now);

            try
            {
                Calendar3.OpenCalendar();
                Calendar3.IsDisabled();
                //Assert.Fail("Calendar3 is disabled but OpenCalendar did not throw an exception.");
            }
            catch
            {
            }
        }

        [Test]
        public void TestingNavbar()
        {
            Task.Delay(5000).Wait();

            NavBar.NavigateTo("DataFilter");
            NavBar.NavigateTo("Badge");
            NavBar.NavigateTo("Breadcrumb");
        }

        [Test]
        public void TestingAlerts()
        {
            NavBar.NavigateTo("Alert");

            Task.Delay(4000).Wait();

            var Alert1 = new Alert(driver, By.ClassName("alert-primary"));
            var Alert2 = new Alert(driver, By.ClassName("alert-secondary"));
            var Alert3 = new Alert(driver, By.ClassName("alert-success"));
            var Alert4 = new Alert(driver, By.ClassName("alert-info"));
            var Alert5 = new Alert(driver, By.ClassName("alert-warning"));
            var Alert6 = new Alert(driver, By.ClassName("alert-danger"));
            var Alert7 = new Alert(driver, By.ClassName("alert-light"));
            var Alert8 = new Alert(driver, By.ClassName("alert-dark"));

            try
            {
                Alert1.CloseAlert();
                Assert.Fail("Alert1 is disabled but CloseAlert did not throw an exception.");
            }
            catch
            {
            }

            Alert2.CloseAlert();
            Alert3.CloseAlert();
            Alert4.CloseAlert();
            Alert5.CloseAlert();
            Alert6.CloseAlert();
            Alert7.CloseAlert();
            Alert8.CloseAlert();
        }

        [Test]
        public void TestingButtons()
        {
            NavBar.NavigateTo("Button");

            string BaseXPath = "//div[contains(@class, 'Components')]";

            var Button1 = new Button(driver, By.XPath(BaseXPath + "//button[contains(@class, 'btn-primary')]"));
            var Button2 = new Button(driver, By.XPath(BaseXPath + "//button[contains(@class, 'btn-secondary')]"));
            var Button3 = new Button(driver, By.XPath(BaseXPath + "//button[contains(@class, 'btn-danger')]"));
            var Button4 = new Button(driver, By.XPath(BaseXPath + "//button[contains(@class, 'btn-success')]"));

            Assert.AreEqual(ButtonStyle.Primary, Button1.GetStyle());
            Assert.AreEqual(ButtonStyle.Secondary, Button2.GetStyle());
            Assert.AreEqual(ButtonStyle.Danger, Button3.GetStyle());
            Assert.AreEqual(ButtonStyle.Success, Button4.GetStyle());

            Button1.Click();
            Button2.Click();
            Button3.Click();
            Button4.Click();
        }

        [Test]
        public void TestingRadios()
        {
            Task.Delay(10000).Wait();

            NavBar.NavigateTo("C-RadioButton");

            var Radio1 = new Radio(driver, By.XPath("//div[1]/div[contains(@class, 'e-radio-wrapper e-wrapper')]/input")); ;
            var Radio2 = new Radio(driver, By.XPath("//div[2]/div[contains(@class, 'e-radio-wrapper e-wrapper')]/input"));
            var Radio3 = new Radio(driver, By.XPath("//div[3]/div[contains(@class, 'e-radio-wrapper e-wrapper')]/input"));
            var Radio4 = new Radio(driver, By.XPath("//div[4]/div[contains(@class, 'e-radio-wrapper e-wrapper')]/input"));
            var Radio5 = new Radio(driver, By.XPath("//div[5]/div[contains(@class, 'e-radio-wrapper e-wrapper')]/input"));
            var Radio6 = new Radio(driver, By.XPath("//div[6]/div[contains(@class, 'e-radio-wrapper e-wrapper')]/input"));

            Radio1.GetLabel();

			Radio1.Select();
            Radio2.Select();

            try
            {
                Radio3.Select();
                Assert.Fail("Radio 3 is disabled but Select did not throw an exception.");
            }
            catch
            {
            }

            try
            {
                Radio4.Select();
                Assert.Fail("Radio 4 is disabled but Select did not throw an exception.");
            }
            catch
            {
            }

            Radio5.Select();
            Radio6.Select();
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            driver.Close(); //current window instance
            driver.Quit(); //all window instances
        }
    }
}
    