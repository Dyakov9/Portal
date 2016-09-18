using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;


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
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }
        public static WebDriverWait ExplicitlyWait()
        {
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            return Wait;
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
