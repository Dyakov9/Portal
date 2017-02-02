using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

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

    public void LoginToAppliction ()
        {
            Email.Clear();
            Email.SendKeys("Testclinic4@3shapecommunicate.com");
            Password.Clear();
            Password.SendKeys("123456");
            Login.Submit();
            Assert.IsTrue(Page.IntegrationsPage.IntegrateAccountsButton.Displayed);
                    }
        public void GoToCreateAccountUserPage()
        {
            NewAccount.Click();
            SoftwareUser.Click();
        }
        }
}
