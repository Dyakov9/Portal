using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using UnitTestProject3.Extensions;
using WrapperFactory;


namespace TestCases
{
    [TestClass]
    public class ResetPasswordTest
    {
        [TestMethod]
        public void ResetPassword()
        {
            BrowserFactory.InitBrowser(Extensions.GetRandomBrowserName());
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.GoToResetPasswordPage();
            Page.ResetPasswordPagePage.ResetPassword();
            BrowserFactory.QuitBrowser();
        }
    }
}
