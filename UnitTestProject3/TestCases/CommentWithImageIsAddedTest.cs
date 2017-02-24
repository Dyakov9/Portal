using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;

namespace TestCases
{
    [TestClass]
    public class CommentWithImageIsAddedTest
    {
        [TestMethod]
        public void CommentWithImageIsAdded()
        {
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction("Clinic");
            Page.IntegrationsPage.GoToCasePage();
            Page.CasesPage.AddCommentWithImage("Clinic");
            BrowserFactory.QuitBrowser();
        }
    }
}
