using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestDataAccess;
using WrapperFactory;

namespace PageObjects
{
   public class LoginPage
    {
       
        [FindsBy(How = How.Name, Using = "Email")]
        [CacheLookup]
        private IWebElement Email { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        [CacheLookup]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "RegisterButton")]
        [CacheLookup]
        private IWebElement Login { get; set; }

        [FindsBy(How = How.LinkText, Using = "create new account")]
        [CacheLookup]
        private IWebElement NewAccount { get; set; }

        [FindsBy(How = How.LinkText, Using = "I am a 3Shape software user")]
        [CacheLookup]
        private IWebElement SoftwareUser { get; set; }

        public void LoginToAppliction (string keyName)
        {
            BrowserFactory.WaitUntilElementToBeClickable(Email);
            var userData = ExcelDataAccess.GetTestData(keyName);
            Email.Clear();
            Email.SendKeys(userData.Email);
            Password.Clear();
            Password.SendKeys(userData.Password);
            Login.Submit();
            BrowserFactory.WaitUntilElementToBeClickable(Page.IntegrationsPage.IntegrateAccountsButton);
                    }
        public void GoToCreateAccountUserPage()
        {
            NewAccount.Click();
            SoftwareUser.Click();
        }
        }
}
