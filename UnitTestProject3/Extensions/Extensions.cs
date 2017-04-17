using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjects;
using WrapperFactory;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;



namespace UnitTestProject3.Extensions
{
        public static class Extensions

    {
        public static Actions builder { get; set; }

        public static void EnterText(this IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        public static void WaitUntilElementToBeClickable(this IWebElement element)
        {
            BrowserFactory.Wait.Until(ExpectedConditions. ElementToBeClickable(element));
        }

        public static void WaitUntilElementExists(By locator)
        {
            BrowserFactory.Wait.Until(ExpectedConditions.ElementExists(locator));
        }
        public static void WaitUntilElementIsVisible(By locator)
        {
            BrowserFactory.Wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public static void WaitUntilElementIsInvisible(By locator)
        {
            BrowserFactory.Wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
        }

        public static void WaitUntilTextToBePresentInElement(this IWebElement element, string text)
        {
            BrowserFactory.Wait.Until(ExpectedConditions.TextToBePresentInElement(element, text));
        }

        public static void WaitUntilAlertIsPresent()
        {
            BrowserFactory.Wait.Until(ExpectedConditions.AlertIsPresent());
        }

        public static void WaitUntilAlertIsAbsent()
        {
            BrowserFactory.Wait.Until(ExpectedConditions.AlertState(false));
        }

        public static IWebElement FindElementByLokator(By locator)
        {
            return BrowserFactory.Driver.FindElement(locator);
        }

        public static string GetUrl()
        {
            return BrowserFactory.Driver.Url;
        }
       
        public static void WaitUntilUrlToBe(string text)
        {
            BrowserFactory.Wait.Until(ExpectedConditions.UrlToBe(text));
        }

        public static void MoveToElement(this IWebElement element)
        {
            builder = new Actions(BrowserFactory.Driver);
            builder.MoveToElement(element).Click().Build().Perform();
            //builder.MoveToElement(secondElement).Click().Build().Perform();
        }

        public static void SelectItem(this IWebElement element, string text)
        {
            SelectElement select = new SelectElement(element);
            //element.WaitUntilTextToBePresentInElement(text);
            select.SelectByText(text);
            
        }
    }
}
