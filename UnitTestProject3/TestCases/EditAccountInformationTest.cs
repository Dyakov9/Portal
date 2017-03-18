using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;

namespace TestCases
{
    [TestClass]
    public class EditAccountInformationTest
    {
        [TestMethod]
        public void EditAccountInformation()
        {
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction("Clinic");
            Page.IntegrationsPage.GoToSettingsPage();
            //Page.SettingsPage.EditAccountInformation();
           // BrowserFactory.QuitBrowser();
        }
    }
}