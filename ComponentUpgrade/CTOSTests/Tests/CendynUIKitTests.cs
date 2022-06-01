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
            Task.Delay(1000).Wait();
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
            NavBar.NavigateTo("C-RadioButton");

            var Radio1 = new Radio(driver, By.XPath("(//div[contains(@class, 'e-radio-wrapper e-wrapper')]/input)[1]"));   // //div[1]/div[contains(@class, 'e-radio-wrapper e-wrapper')]/input"));
            var Radio2 = new Radio(driver, By.XPath("(//div[contains(@class, 'e-radio-wrapper e-wrapper')]/input)[2]"));
            var Radio3 = new Radio(driver, By.XPath("(//div[contains(@class, 'e-radio-wrapper e-wrapper')]/input)[3]"));
            var Radio4 = new Radio(driver, By.XPath("(//div[contains(@class, 'e-radio-wrapper e-wrapper')]/input)[4]"));
            var Radio5 = new Radio(driver, By.XPath("(//div[contains(@class, 'e-radio-wrapper e-wrapper')]/input)[5]"));
            var Radio6 = new Radio(driver, By.XPath("(//div[contains(@class, 'e-radio-wrapper e-wrapper')]/input)[6]"));

            Radio1.Select();
            Radio2.Select();
            bool isEnabled = Radio1.IsEnabled();
            bool isSelected = Radio1.IsSelected();

            Radio3.Select();
            Radio4.Select();
            Radio5.Select();
            Radio6.Select();

            Label label5 = Radio5.GetLabel();
            string label5Name = label5.GetLabelText();
            Console.WriteLine(label5Name);
            Label label1 = Radio1.GetLabel();
        }

        [Test]
        public void InputText()
        {
            NavBar.NavigateTo("C-Input");

            var Input1 = new Input(driver, By.XPath("(//div[contains(@class, 'form-group')]/input[@type= 'text'])[1]"));
            var Input2 = new Input(driver, By.XPath("(//div[contains(@class, 'form-group')]/input[@type= 'text'])[2]"));
            var Input3 = new Input(driver, By.XPath("(//div[contains(@class, 'form-group')]/input[@type= 'text'])[3]"));
            var Input4 = new Input(driver, By.XPath("(//div[contains(@class, 'form-group')]/input[@type= 'text'])[4]"));

            Input1.EnterInput("testing123");
            Input2.EnterInput("###");
            Input3.EnterInput("^%^&%^%^&%");
            Input4.EnterInput("AaBbCc7890()");

            string inputText1 = Input1.GetInputText();
            Console.WriteLine(inputText1);
            string inputText2 = Input2.GetInputText();
            Console.WriteLine(inputText2);
            string inputText3 = Input3.GetInputText();
            Console.WriteLine(inputText3);
            string inputText4 = Input4.GetInputText();
            Console.WriteLine(inputText4);

            bool input1Enabled = Input1.IsInputEnabled();
            Console.WriteLine(input1Enabled);

            Label label1 = Input1.GetInputLabel();
            string label1Name = label1.GetLabelText();
            Console.WriteLine(label1Name);
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            driver.Close(); //current window instance
            driver.Quit(); //all window instances
        }
    }
}
    