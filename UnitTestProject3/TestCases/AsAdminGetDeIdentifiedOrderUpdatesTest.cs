using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using UnitTestProject3.Extensions;
using WrapperFactory;


namespace TestCases
{
    [TestClass]
    public class AsAdminGetDeIdentifiedOrderUpdatesTest
    {
        [TestMethod]
        public void AsAdminGetDeIdentifiedOrderUpdates()
        {
            BrowserFactory.InitBrowser(Extensions.GetRandomBrowserName());
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["AdminAccount"]);
            Page.NavigationPage.GoToCasesPage();
            Page.CasesPage.Search();
            Page.CasesPage.GetDeIdentifiedOrderUpdates();
            BrowserFactory.QuitBrowser();
            }
    }
}
