using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using PageObjects;
using System.Runtime.Serialization;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;

namespace WrapperFactory
{
    class BrowserFactory
    {
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        public static WebDriverWait Wait { get; set; }
        public static IWebDriver Driver { get; set; }
       
        public static void InitBrowser()
        {

            var options = new ChromeOptions();
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("password_manager_enabled", false);
            Driver = new ChromeDriver(options);
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(45));
            
            
        }

        public static void InitBrowser(string browserName)
        {
         
            switch (browserName)
            {
                case "Firefox":
                   
                        Driver = new FirefoxDriver();
                       break;

                case "IE":
                   
                        Driver = new InternetExplorerDriver();
//                        Drivers.Add("IE", Driver);
                    
                    break;

                case "Chrome":
                   
                        Driver = new ChromeDriver();
                       // Drivers.Add("Chrome", Driver);
                   
                    break;
            }
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
        }

        public static void LoadApplication(string url)
        {
            Driver.Url = url;
            Driver.Manage().Window.Maximize();
        }

        public static IAlert InitAlert()
        {
            return Driver.SwitchTo().Alert();
        }

        public static void QuitBrowser()
        {
            Driver.Quit();
        }

       
    }
}
