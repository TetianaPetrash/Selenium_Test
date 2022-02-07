using Selenium_Tests.PageObjectModel.BaseDriverSetUps;
using Selenium_Tests.PageObjectModel.Locators;


namespace Selenium_Tests.PageObjectModel.Methods
{
    internal class SignUpMethods //регистрация
    {
        BaseDriverSetUp helper = new BaseDriverSetUp();
        SignUpLocators signUpLocators = new SignUpLocators();
        internal  void ClickButtonSignUp() => helper.GetDriver().FindElement(signUpLocators.clickButton_SignUp).Click();
        internal  void InputEmailToSignUp() => helper.GetDriver().FindElement(signUpLocators.inputEmailField_SignUp).SendKeys("alina_co@gmail.com");
        internal  void ClickButttonToContinue() => helper.GetDriver().FindElement(signUpLocators.clickButton_Continue).Click();
        internal  void InputPasswordToSignUp() => helper.GetDriver().FindElement(signUpLocators.inputPasswordField_SignUp).SendKeys("123qwe");
        internal  void InputUserNameToSignUp() => helper.GetDriver().FindElement(signUpLocators.inputUserNameField_SignUp).SendKeys("AlinaLuna");
        internal  void ClickReceiveUpdatesField() => helper.AnswerToReceiveUpdates();
        internal  void CheckPerson() => helper.GetDriver().FindElement(signUpLocators.checkButton_Person).Click();//??
        internal  void ClickPicture() => helper.GetDriver().FindElement(signUpLocators.clickPicture).Click();
        internal  void ClickButtonAtTheEnd_CreateAccount() => helper.GetDriver().FindElement(signUpLocators.clickButtonAtTheEnd_CreateAccount).Click();
        




    }
}
