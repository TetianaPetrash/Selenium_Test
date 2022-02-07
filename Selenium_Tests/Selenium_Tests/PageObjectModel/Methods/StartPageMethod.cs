using OpenQA.Selenium;
using Selenium_Tests.PageObjectModel.BaseDriverSetUps;
using Selenium_Tests.PageObjectModel.Locators;


namespace Selenium_Tests.PageObjectModel.Methods
{
    internal  class StartPageMethod
    {
        BaseDriverSetUp helper = new BaseDriverSetUp();
        StartPageLocators startPageLocators = new StartPageLocators();
        internal  void GetButtonSignIn() => helper.GetDriver().FindElement(startPageLocators.button_SignIn).Click();
        internal  void GetButtonSignUp() => helper.GetDriver().FindElement(startPageLocators.button_SignUp).Click();// нужно ли тут возвр знач IWebElement
        internal  void GetFieldSearchInfo() => helper.GetDriver().FindElement(startPageLocators.inputSearchField).SendKeys("new" + Keys.Enter);
        internal  void GetButtonTeam() => helper.GetDriver().FindElement(startPageLocators.clickButtonTeam).Click();
        internal  void GetButtonEnterprise() => helper.GetDriver().FindElement(startPageLocators.clickButtonEnterprise).Click();
        internal  void GetButtonMarketplace() => helper.GetDriver().FindElement(startPageLocators.clickButtonMarketplace).Click();
 
    }
}
