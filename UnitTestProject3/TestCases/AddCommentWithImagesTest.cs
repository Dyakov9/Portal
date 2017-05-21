using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;

namespace TestCases
{
    [TestClass]
    public class AddCommentWithImagesTest
    {
        [TestMethod]
        public void AddCommentWithImages()
        {
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["ClinicAccount"]);
            Page.NavigationPage.GoToCasesPage();
            Page.CasesPage.AddCommentWithImage();
            BrowserFactory.QuitBrowser();
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["LabAccount"]);
            Page.NavigationPage.GoToCasesPage();
            Page.CasesPage.VerifyThatCommentIsAdded();
        }
    }
}
