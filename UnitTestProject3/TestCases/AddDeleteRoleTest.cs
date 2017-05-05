using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;


namespace TestCases
{
    [TestClass]
    public class AddDeleteRoleTest
    {
        [TestMethod]
        public void AddDeleteRole()
        {
            BrowserFactory.InitBrowser();
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["AdminAccount"]);
            Page.IntegrationsPage.GoToUserRolePage();
            Page.UserRolePagePage.GetUsersByRole("ReadyCoordinator");
            //BrowserFactory.QuitBrowser();
            }
    }
}
