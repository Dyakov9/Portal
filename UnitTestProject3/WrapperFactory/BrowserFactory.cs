using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using PageObjects;
using System.Runtime.Serialization;


namespace WrapperFactory
{
    class BrowserFactory
    {
        public static IWebDriver Driver { get; set; }
        public static WebDriverWait Wait { get; set; }

        public static void InitBrowser()
        {
            Driver = new ChromeDriver();
            Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(1));
        }

        public static void LoadApplication(string url)
        {
            Driver.Url = url;
            Driver.Manage().Window.Maximize();
        }

        public static void WaitUntilElementToBeClickable(IWebElement element )
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static void WaitUntilTextToBePresentInElement(IWebElement element, string text)
        {
            Wait.Until(ExpectedConditions.TextToBePresentInElement(element, text));
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
