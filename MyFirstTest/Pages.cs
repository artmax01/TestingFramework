using OpenQA.Selenium.Support.PageObjects;


namespace Test
{
    public static class Pages
    {
        private static T getPages<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browsers.getDriver, page);
            return page;
        }
        public static Login Login
        {
            get { return getPages<Login>(); }
        }

        public static StartPage StartPage
        {
            get { return getPages<StartPage>(); }
        }

        public static PhpTravelsNet PhpTravelsNet
        {
            get { return getPages<PhpTravelsNet>(); }
        }
    }
}