using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;

namespace TestCases
{
    [TestClass]
    public class SearchCaseAndUploadPdfFileTest
    {
        [TestMethod]
        public void SearchCaseAndUploadPdfFile()
        {
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["ClinicAccount"]);
            Page.IntegrationsPage.GoToCasePage();
            Page.CasesPage.UploadPdfFile(ConfigurationManager.AppSettings["PdfFilePath"]);
            BrowserFactory.QuitBrowser();
        }
    }
}