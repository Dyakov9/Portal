using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using UnitTestProject3.Extensions;
using WrapperFactory;


namespace TestCases
{
    [TestClass]
    public class AsAdminEditAccountInformationTest
    {
        [TestMethod]
        public void AsAdminEditAccountInformation()
        {
            BrowserFactory.InitBrowser(Extensions.GetRandomBrowserName());
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["AdminAccount"]);
            Page.NavigationPage.GoToAdminPage();
            Page.AdminPage.GoToUserSettingsPage(ConfigurationManager.AppSettings["ClinicAccount"]);
            Page.SettingsPage.EditAccountInformation();
            BrowserFactory.QuitBrowser();
            }
    }
}
