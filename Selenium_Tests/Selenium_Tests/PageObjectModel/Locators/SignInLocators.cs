using OpenQA.Selenium;
using Selenium_Tests.PageObjectModel.BaseDriverSetUps;

namespace Selenium_Tests.PageObjectModel.Locators
{
    public class SignInLocators 
    {      
        BaseDriverSetUp helper = new BaseDriverSetUp();
        
        internal IWebElement inputUsernameField_SignIn = helper._driver.FindElement(By.XPath("//*[@id='login_field']"));
        internal IWebElement inputpassword_SignIn = By.Id("password");
        internal IWebElement clickButton_SignIn = By.XPath("//*[@class='btn btn-primary btn-block js-sign-in-button']");
        internal IWebElement clickButton_CreateAccaunt = By.XPath("//*[text()='Create an account']");
        
    }
}
