using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;

namespace TestCases
{
    [TestClass]
   public class VerifyThatImagesAreDisplayedTest
    {
        [TestMethod]
    public void VerifyThatImagesAreDisplayed()
        {
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["ClinicAccount"]);
            Page.IntegrationsPage.GoToCasePage();
            Page.CasesPage.VerifyImagesAreDisplayed();
            BrowserFactory.QuitBrowser();
        }
    }
}
