using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using UnitTestProject3.Extensions;
using WrapperFactory;


namespace TestCases
{
   [TestClass]
    public class LogOutTest
    {
        [TestMethod]
        public void LogOut()
        {
            BrowserFactory.InitBrowser(Extensions.GetRandomBrowserName());
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["ClinicAccount"]);
            Page.NavigationPage.LogOut();
            BrowserFactory.QuitBrowser();
        }
    }
}
