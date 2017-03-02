using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;

namespace TestCases
{
    [TestClass]
    public class UploadPdfFileTest
    {
        [TestMethod]
        public void UploadPdfFile()
        {
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction("Clinic");
            Page.IntegrationsPage.GoToCasePage();
            Page.CasesPage.UploadPdfFile(ConfigurationManager.AppSettings["PdfFilePath"]);
            BrowserFactory.QuitBrowser();
        }
    }
}