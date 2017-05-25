using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using UnitTestProject3.Extensions;
using WrapperFactory;

namespace TestCases
{
    [TestClass]
    public class AddCommentWithImagesTest
    {
        [TestMethod]
        public void AddCommentWithImages()
        {
            BrowserFactory.InitBrowser(Extensions.GetRandomBrowserName());
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["ClinicAccount"]);
            Page.NavigationPage.GoToCasesPage();
            Page.CasesPage.AddCommentWithImage();
            BrowserFactory.QuitBrowser();
            
        }
    }
}
