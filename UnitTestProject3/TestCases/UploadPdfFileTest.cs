using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using NUnit.Framework;
using UnitTestProject3.Extensions;
using WrapperFactory;

namespace TestCases
{
   [TestClass]
    public class UploadPdfFileTest
    {
        [TestMethod]
        public void UploadPdfFile()
        {
            BrowserFactory.InitBrowser(Extensions.GetRandomBrowserName());
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["ClinicAccount"]);
            Page.NavigationPage.GoToCasesPage();
            Page.CasesPage.UploadPdfFile(ConfigurationManager.AppSettings["PdfFilePath"]);
            BrowserFactory.QuitBrowser();
        }
    }
}