using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;


namespace TestCases
{
    [TestClass]
    public class NewAccount3shapeUserTest
    {
        [TestMethod]
        public void CreateNewAccount3shapeUser()
        {
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.CreateNewAccount3shapeUser();
            Page.CreateAccountUser.EnterLoginInfo();
            Page.CreateAccountUser.EnterAccountInfo();
            Page.CreateAccountUser.EnterDongleNumber();
            Page.CreateAccountUser.ChooseRole();
            Page.CreateAccountUser.CreateAccount();
            BrowserFactory.QuitBrowser();
        }
    }
}
