using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using NUnit.Framework;
using System.IO;

namespace Test
{
    public class StartPage
    {
        [FindsBy(How = How.ClassName, Using = "hero-slogan")]
        private IWebElement pricing;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[4]/div/div/div[2]/div/div[1]/form/button")]
        private IWebElement orderNow;

        public void Pricing()
        {
            pricing.Click();
        }

        public void OrderNow()
        {
            orderNow.Click();
        }
    }
}
