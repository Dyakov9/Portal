using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;


namespace TestCases
{
    [TestClass]
    public class NewAccount3ShapeUserTest
    {
        [TestMethod]
        public void CreateNewAccount3ShapeUser()
        {
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.GoToCreateAccountUserPage();
            Page.CreateAccountUser.CreateNewAccount();
            BrowserFactory.QuitBrowser();
        }
    }
}
