using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class PhpTravelsNet
    {
        [FindsBy(How = How.XPath, Using = "//span[@class='select2-chosen']")]
        private IWebElement searchField;
        [FindsBy(How = How.CssSelector, Using = "#dpd1 > div > input")]
        private IWebElement checkIn;
        [FindsBy(How = How.CssSelector, Using = "#dpd2 > div > input")]
        private IWebElement checkOut;
        [FindsBy(How = How.CssSelector, Using = "#hotels > form > div.col-md-2.form-group.go-right.col-xs-12.search-button > button")]
        private IWebElement searchButton;
        private IWebElement elem = Browsers.getDriver.FindElement(By.XPath("//td[text()='20']"));
        private IWebElement elem2 = Browsers.getDriver.FindElement(By.XPath("//td[text()='21']"));


        public void SearchField()
        {
            searchField.Click();
            Actions action = new Actions(Browsers.getDriver);
            action.MoveToElement(searchField).SendKeys("Chicago, United States").Build().Perform();
        }

        public void CheckIn()
        {
            Actions action2 = new Actions(Browsers.getDriver);
            action2.MoveToElement(checkIn).Click().Build().Perform();
            action2.MoveToElement(elem).Click().Build().Perform();
        }

        public void CheckOut()
        {
            Actions action1 = new Actions(Browsers.getDriver);
            action1.MoveToElement(checkOut).Click().Build().Perform();
            action1.MoveToElement(elem2).Click().Build().Perform();
        }

        public void SearchButton()
        {
            searchButton.Click();
        }
    }
}
