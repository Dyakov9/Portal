using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;

namespace TestCases
{
    [TestClass]
    public class UploadDeleteTemplatesTest
    {
        [TestMethod]
        public void UploadDeleteTemplates()
        {
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["ClinicAccount"]);
            Page.NavigationPage.GoToTemplatesPage();
            Page.TemplatesPage.UploadTemplate();
            Page.TemplatesPage.DeleteTemplate();
            BrowserFactory.QuitBrowser();
        }
    }
}