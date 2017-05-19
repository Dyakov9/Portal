using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;


namespace TestCases
{
    [TestClass]
    public class AsAdminSearchCaseTest
    {
        [TestMethod]
        public void AsAdminSearchCase()
        {
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["AdminAccount"]);
            Page.NavigationPage.GoToAdminPage();
            Page.AdminPage.GoToUserSettingsPage(ConfigurationManager.AppSettings["ClinicAccount"]);
            Page.NavigationPage.GoToCasesPage();
            Page.CasesPage.Search();
            BrowserFactory.QuitBrowser();
            }
    }
}
