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
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["ClinicAccount"]);
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URLSettingsPage"]);
            Page.SettingsPage.EditAccountInformation();
            BrowserFactory.QuitBrowser();
        }
    }
}