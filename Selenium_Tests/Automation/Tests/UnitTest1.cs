using NUnit.Framework;
using OpenQA.Selenium;
using Selenium_Tests.PageObjectModel.Helpers;
using Selenium_Tests.PageObjectModel.Methods;
using System.Threading;

namespace Selenium_Tests
{
    public class Tests : Hooks
    {
        StartPageMethod startPageMethod = new StartPageMethod();
        SignInMethods signInMethods = new SignInMethods();
       
        [Test]
        public void Authorization()
        {

            startPageMethod.GetButtonSignIn();
            signInMethods.InputNameToSignIn();
            signInMethods.InputPasswordToSignIn();
            signInMethods.ClickButtton_SignIn();
           
        }
    }
}