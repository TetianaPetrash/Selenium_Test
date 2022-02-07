using OpenQA.Selenium;


namespace Selenium_Tests.PageObjectModel.Locators
{
    internal class SignUpLocators
    {
        internal readonly By clickButton_SignUp = By.XPath("//*[@class='HeaderMenu-link flex-shrink-0 d-inline-block no-underline border color-border-default rounded px-2 py-1']");
        internal readonly By inputEmailField_SignUp = By.Id("email"); //*[@id='email']
        internal readonly By clickButton_Continue = By.XPath("//*[@class='js-continue-button signup-continue-button form-control px-3 width-full width-sm-auto mt-4 mt-sm-0']");
        internal readonly By inputPasswordField_SignUp = By.Id("password"); //*[@id ="password"]
        internal readonly By clickButton_ContinueSignUp = By.XPath("//*[@class='js-continue-button signup-continue-button form-control px-3 width-full width-sm-auto mt-4 mt-sm-0']");
        internal readonly By inputUserNameField_SignUp = By.XPath("//*[@id ='login']");
        internal readonly By receiveUpdatesField = By.Id("opt_in"); //  if with "y" or "n"
        internal readonly By clickButtonContinue = By.XPath("//*[@class ='js -continue-button signup -continue-button form - control px - 3 width - full width - sm - auto mt - 4 mt - sm - 0']");
        internal readonly By checkButton_Person = By.XPath("//*[@id ='home_children_button']");
        internal readonly By clickPicture = By.XPath("//*[@class ='ChallengeSelectableOverlay__StyledElement-sc-6lu34v-0 doRXGA']");
        internal readonly By clickButtonAtTheEnd_CreateAccount = By.XPath("//*[@class ='form-control signup-submit-button width-full py-2 js-octocaptcha-form-submit']");
    }
}
