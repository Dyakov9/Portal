using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;

namespace UnitTestProject3.TestCases
{
    [TestClass]
   public class ImagesAreDisplayedTest
    {
        [TestMethod]
    public void ImagesAreDisplayed ()
        {
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction();
            Page.IntegrationsPage.GoToCasePage();
            Page.CasesPage.VerifyImagesAreDisplayed();
            //BrowserFactory.QuitBrowser();
        }
    }
}
