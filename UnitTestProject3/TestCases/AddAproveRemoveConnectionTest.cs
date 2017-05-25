using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using UnitTestProject3.Extensions;
using WrapperFactory;


namespace TestCases
{
    [TestClass]
    public class AddAproveRemoveConnectionTest
    {
        [TestMethod]
        public void AddAproveRemoveConnection()
        {
            BrowserFactory.InitBrowser(Extensions.GetRandomBrowserName());
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["ClinicAccount"]);
            Page.NavigationPage.GoToConnectionsPage();
            Page.ConnectionsPage.SendConnectionRequest(ConfigurationManager.AppSettings["LabAccount"]);
            BrowserFactory.QuitBrowser();
            BrowserFactory.InitBrowser(Extensions.GetRandomBrowserName());
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["LabAccount"]);
            Page.NavigationPage.GoToConnectionsPage();
            Page.ConnectionsPage.ApproveConnectionRequestAndRemoveConnection();
            BrowserFactory.QuitBrowser();
        }
    }
}
