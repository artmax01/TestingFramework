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
    public class Login
    {
        
        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement inputEmail;
        [FindsBy(How = How.Id, Using = "inputPassword")]
        private IWebElement inputPassword;
        [FindsBy(How = How.Id, Using = "login")]
        private IWebElement loginButton;
        [FindsBy(How = How.ClassName, Using = "alert alert-danger text-center")]
        private IWebElement errorMessage;

        public void InputEmail(string email)
        {
            inputEmail.SendKeys(email);
        }

        public void InputPassword(string password)
        {
            inputPassword.SendKeys(password);
        }

        public void LoginButton()
        {
            loginButton.Click();
        }

        public void ErrorMessage()
        {
            try
            {
                var text = errorMessage.Text;
            }
            catch (Exception e)
            {
                Assert.IsTrue(true);
            }
        }

        public void filldatafromCsv()
        {
            string filePath = @"C:\Users\TestProject\Desktop\runFile.csv";
            List<string> data = new List<string>();
            data = Servers.general.loadCsvFile(filePath);
            for (int i = 0; i < data.Count; i++)
            {
                var values = data[i].Split(';');
                InputEmail(values[0]);
                InputPassword(values[1]);
                LoginButton();
                ErrorMessage();
            }
        }
    }
}