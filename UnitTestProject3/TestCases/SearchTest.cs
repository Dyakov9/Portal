using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;

namespace TestCases
{
    [TestClass]
    public class SearchTest
    {
     [TestMethod]
         public static void Main()
         {
             BrowserFactory.InitBrowser();
             BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
             Page.Login.LoginToAppliction("Test");
             Page.IntegrationsPage.GoToCasePage();
             Page.CasesPage.Search("Test");
             BrowserFactory.QuitBrowser();
         }
    }
}
