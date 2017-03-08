using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using PageObjects;
using System.Runtime.Serialization;
using OpenQA.Selenium.Interactions;

namespace WrapperFactory
{
    class BrowserFactory
    {
        public static IWebDriver Driver { get; set; }
        public static WebDriverWait Wait { get; set; }
        public static Actions builder { get; set; }

        public static void InitBrowser()
        {
            Driver = new ChromeDriver();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            builder = new Actions (Driver);
            
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

        public static void WaitUntilElementIsInvisible(By locator)
        {
            Wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
        }

        public static void WaitUntilTextToBePresentInElement(IWebElement element, string text)
        {
            Wait.Until(ExpectedConditions.TextToBePresentInElement(element, text));
        }
        
        public static void WaitUntilAlertIsPresent()
        {
            Wait.Until(ExpectedConditions.AlertIsPresent());
        }
        public static void WaitUntilAlertIsAbsent()
        {
            Wait.Until(ExpectedConditions.AlertState(false));
        }

        public static string GetUrl()
        {
           return Driver.Url; 
        }
        public static void QuitBrowser()
        {
            Driver.Quit();
        }

        public static IAlert InitAlert() 
        {
            return Driver.SwitchTo().Alert();
        }

        public static void WaitUntilUrlToBe(string text)
        {
            Wait.Until(ExpectedConditions.UrlToBe(text));
        }
    }
}
