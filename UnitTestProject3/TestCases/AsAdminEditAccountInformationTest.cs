using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;


namespace TestCases
{
    [TestClass]
    public class AsAdminEditAccountInformationTest
    {
        [TestMethod]
        public void AsAdminEditAccountInformation()
        {
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["AdminAccount"]);
            Page.NavigationPage.GoToAdminPage();
            Page.AdminPage.GoToUserSettingsPage(ConfigurationManager.AppSettings["ClinicAccount"]);
            Page.SettingsPage.EditAccountInformation();
            Page.SettingsPage.EditCompanyInformation();
            BrowserFactory.QuitBrowser();
            }
    }
}
