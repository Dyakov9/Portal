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
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["ClinicAccount"]);
            Page.IntegrationsPage.GoToConnectionsPage();
            Page.ConnectionsPage.SendConnectionRequest(ConfigurationManager.AppSettings["LabAccount"]);
            BrowserFactory.QuitBrowser();
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["LabAccount"]);
            Page.IntegrationsPage.GoToConnectionsPage();
            Page.ConnectionsPage.ApproveConnectionRequestAndRemoveConnection();
            BrowserFactory.QuitBrowser();
        }
    }
}
