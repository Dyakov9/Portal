using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using UnitTestProject3.Extensions;
using WrapperFactory;

namespace TestCases
{
    [TestClass]
    public class MigrateOldCasesTest
    {
        [TestMethod]
        public void MigrateOldCases()
        {
            BrowserFactory.InitBrowser(Extensions.GetRandomBrowserName());
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["ClinicAccount"]);
            Page.NavigationPage.GoToAccessOldCasesPage();
            Page.AxAccessOldCasesPage.MigrateOldCases();
            BrowserFactory.QuitBrowser();
        }
    }
}