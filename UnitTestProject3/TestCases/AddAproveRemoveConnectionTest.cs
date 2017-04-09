using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;


namespace TestCases
{
    [TestClass]
    public class AddAproveRemoveConnectionTest
    {
        [TestMethod]
        public void AddAproveRemoveConnection()
        {
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction("Clinic");
            Page.IntegrationsPage.GoToConnectionsPage();
            Page.ConnectionsPage.SendConnectionRequest("Lab");
            BrowserFactory.QuitBrowser();
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction("Lab");
            Page.IntegrationsPage.GoToConnectionsPage();
            Page.ConnectionsPage.ApproveConnectionRequestAndRemoveConnection();
            //BrowserFactory.QuitBrowser();
        }
    }
}
