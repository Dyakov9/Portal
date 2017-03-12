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
            Page.Login.LoginToAppliction("Clinic");
            Page.IntegrationsPage.IntegrateAccounts();
            BrowserFactory.QuitBrowser();
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction("Clinic");
            Page.IntegrationsPage.DisconnectAccounts();
            BrowserFactory.QuitBrowser();
        }
    }
}