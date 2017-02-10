using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Runtime.Serialization;


namespace WrapperFactory
{
    class BrowserFactory
    {
        public static IWebDriver Driver { get; set; }
        public static WebDriverWait Wait { get; set; }
        public static IWebDriver InitBrowser()
        {
            Driver = new ChromeDriver();
            return Driver;
        }
        public static void LoadApplication(string url)
        {
            Driver.Url = url;
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
        }
        public static void ExplicitlyWait(IWebElement element )
        {
            Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(1));
            Wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }


        public static string GetUrl()
        {
           return Driver.Url; 
        }
        public static void QuitBrowser()
        {
            Driver.Quit();
        }
    }
}
