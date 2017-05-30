using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using WrapperFactory;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;


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
            BrowserFactory.Wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static void WaitUntilElementExists(By locator)
        {
            BrowserFactory.Wait.Until(ExpectedConditions.ElementExists(locator));
        }

        public static void WaitUntilElementIsVisible(By locator)
        {
            BrowserFactory.Wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public static void WaitUntilElementWithTextIsInvisible(By locator, String text)
        {
            BrowserFactory.Wait.Until(ExpectedConditions.InvisibilityOfElementWithText(locator, text));
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
            builder.MoveToElement(element).Build().Perform();

        }

        public static void SelectItem(this IWebElement element, string text)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByText(text);

        }

        public static string GetRandomBrowserName()
        {
            List<string> names = new List<string>() { "Firefox", "IE", "Chrome" };
            Random r = new Random();
            string name = names[r.Next(names.Count)];
            return name;
        }

        public static void AcceptAlertWithMessage(String message)
        {
            var alert = BrowserFactory.InitAlert();
            var actualAlertText = alert.Text;
            Assert.AreEqual(message, actualAlertText);
            alert.Accept();
        }
    }
}

