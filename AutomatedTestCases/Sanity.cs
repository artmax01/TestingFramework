using NUnit.Framework;
using OpenQA.Selenium;
using Test;
using static Test.Class1;

namespace AutomatedTestCases
{
    [TestFixture]
    public class Sanity : AutomationCore
    {
        [Test]
        public void ClickLogin()
        {      
            Pages.Login.InputEmail("asdasd@gmail.com");
            Pages.Login.InputPassword("test");
            Pages.Login.LoginButton();
            Pages.Login.ErrorMessage();
        }

        [Test]
        public void OrderClick()
        {
            Browsers.getDriver.Navigate().GoToUrl("https://phptravels.com/");
            Pages.StartPage.Pricing();
            Pages.StartPage.OrderNow();
            Assert.AreEqual("https://phptravels.org/cart.php?a=confproduct&i=0", "https://phptravels.org/cart.php?a=confproduct&i=0");
        }

        [Test]
        public void HotelSearch()
        {
            Browsers.getDriver.Navigate().GoToUrl("https://www.phptravels.net/");
            Pages.PhpTravelsNet.SearchField();
            Pages.PhpTravelsNet.CheckIn();
            Pages.PhpTravelsNet.CheckOut();
            Pages.PhpTravelsNet.SearchButton();
            Assert.AreEqual("https://www.phptravels.net/hotels/search/20-02-2019/21-02-2019/2/0", "https://www.phptravels.net/hotels/search/20-02-2019/21-02-2019/2/0");
        }
    }
}