using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;


namespace TestCases
{
    [TestClass]
    public class LogOutTest
    {
        [TestMethod]
        public void LogOut()
        {
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction("Clinic");
            Page.IntegrationsPage.LogOut();
            //BrowserFactory.QuitBrowser();
        }
    }
}
