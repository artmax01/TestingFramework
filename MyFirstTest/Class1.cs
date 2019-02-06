using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test
{
    public class Class1
    {
        [TestFixture]
        public class AutomationCore
        {
        
            
            // Our Core Test Automation class
            [SetUp]
            public void startUpTest()// This method fire at the start of the Test
            {
                Browsers.Init();
                
            }

            [TearDown]
            public void endTest()// This method will fire at the end of the Test
            {
                Browsers.Close();
            }
        }
    }
}
