using OpenQA.Selenium;


namespace Selenium_Tests.PageObjectModel.Locators
{
    internal class StartPageLocators
    { 
        // переделать без By на WebElement
        // разбить на два проекта:автомейшен юай тест;автомейшен юай(описание всех страниц)
        internal readonly By button_SignIn = By.XPath("//*[@class='HeaderMenu-link flex-shrink-0 no-underline']"); //authorization
        internal readonly By button_SignUp = By.XPath("//*[@class='HeaderMenu-link flex-shrink-0 d-inline-block no-underline border color-border-default rounded px-2 py-1']");
        internal readonly By inputSearchField = By.XPath("//*[@class ='form-control input-sm header-search-input jump-to-field js-jump-to-field js-site-search-focus']");
        internal readonly By clickButtonTeam = By.XPath("//*[@class ='HeaderMenu-link no-underline py-3 d-block d-lg-inline-block']");
        internal readonly By clickButtonEnterprise = By.XPath("//*[@class ='HeaderMenu-link no-underline py-3 d-block d-lg-inline-block']");
        internal readonly By clickButtonMarketplace = By.XPath("//*[@class ='HeaderMenu-link no-underline py-3 d-block d-lg-inline-block']");
    }
}
