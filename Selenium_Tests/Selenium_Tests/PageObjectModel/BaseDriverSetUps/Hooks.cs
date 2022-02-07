using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Selenium_Tests.PageObjectModel.BaseDriverSetUps;

namespace Selenium_Tests.PageObjectModel.Helpers
{
    public class Hooks
    {
        BaseDriverSetUp helper = new BaseDriverSetUp();

        [SetUp]
        public void SetUp()
        {

            helper.GetDriver().Navigate().GoToUrl("https://github.com/");
            
        }

        //[TearDown]
        //public void TearDown()
        //{
        //    Helper.CleanDriver();
        //}

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            helper.CloseDriver();
        }
    }
}
