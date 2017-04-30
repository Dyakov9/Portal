using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;


namespace TestCases
{
    [TestClass]
    public class IntegrateAndDisconnectAccountsTest
    {
        [TestMethod]
        public void IntegrateAndDisconnectAccounts()
        {
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["ClinicAccount"]);
            Page.IntegrationsPage.IntegrateAccounts();
            BrowserFactory.QuitBrowser();
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["ClinicAccount"]);
            Page.IntegrationsPage.DisconnectAccounts();
            BrowserFactory.QuitBrowser();
        }
    }
}