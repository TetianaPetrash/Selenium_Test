using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_Tests.PageObjectModel.Locators;

namespace Selenium_Tests.PageObjectModel.BaseDriverSetUps
{
    public class BaseDriverSetUp
    {
        // SingleTon почитать
        // добавить emplicitwait
        public IWebDriver _driver;
       
        SignUpLocators signUpLocators = new SignUpLocators();

        public void CreateDriver()
        {
            _driver = new ChromeDriver(); // проблема в браузере
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);            
        }

        public IWebDriver GetDriver()
        {
            if (_driver == null)
                CreateDriver();

            return _driver;
        }

        //internal static void CleanDriver()
        //{
        //    // Open new empty tab.
        //    IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
        //    js.ExecuteScript("window.open('');");

        //    // Close all tabs but one tab and delete all cookies.
        //    for (var tabs = _driver.WindowHandles; tabs.Count > 1; tabs = _driver.WindowHandles)
        //    {
        //        _driver.SwitchTo().Window(tabs[0]);
        //        _driver.Manage().Cookies.DeleteAllCookies();
        //        _driver.Close();
        //    }

        //    // Switch to empty tab.
        //    _driver.SwitchTo().Window(_driver.WindowHandles[0]);
        //}

        internal void CloseDriver()
        {
            _driver.Quit();
        }

        internal void AnswerToReceiveUpdates()
        {
            string answer = "";
            if (answer.Equals("y"))
            {
                GetDriver().FindElement(signUpLocators.receiveUpdatesField).SendKeys("y");
            }
            else 
            {
                GetDriver().FindElement(signUpLocators.receiveUpdatesField).SendKeys("n");
            }
        }

    }
}

