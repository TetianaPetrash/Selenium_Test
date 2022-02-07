using Selenium_Tests.PageObjectModel.BaseDriverSetUps;
using Selenium_Tests.PageObjectModel.Locators;



namespace Selenium_Tests.PageObjectModel.Methods
{
    internal  class SignInMethods
    {
        BaseDriverSetUp helper = new BaseDriverSetUp();
        SignInLocators signInLocators = new SignInLocators();
        internal void InputNameToSignIn() => helper.GetDriver().FindElement(signInLocators.inputUsernameField_SignIn).SendKeys("tanuhatim@gmail.com");
        internal void InputPasswordToSignIn() => helper.GetDriver().FindElement(signInLocators.inputpassword_SignIn).SendKeys("1992Vfhbyf92");
        internal void ClickButtton_SignIn() => helper.GetDriver().FindElement(signInLocators.clickButton_SignIn).Click();
        internal void ClickButtonCreateAccount() => helper.GetDriver().FindElement(signInLocators.clickButton_CreateAccaunt).Click();
    }
}
