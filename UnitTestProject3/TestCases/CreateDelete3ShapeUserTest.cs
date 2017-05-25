using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using UnitTestProject3.Extensions;
using WrapperFactory;


namespace TestCases
{
    [TestClass]
    public class CreateDelete3ShapeUserTest
    {
        [TestMethod]
        public void CreateDelete3ShapeUser()
        {
            BrowserFactory.InitBrowser(Extensions.GetRandomBrowserName());
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.GoToCreateAccountUserPage();
            Page.CreateAccountUser.CreateNewAccount();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["NewAccount"]);
            Page.NavigationPage.GoToSettingsPage();
            Page.SettingsPage.DeleteAccount();
            BrowserFactory.QuitBrowser();
        }
    }
}
