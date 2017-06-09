using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WrapperFactory;
using UnitTestProject3.Extensions;

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

        [FindsBy(How = How.CssSelector, Using = "a[href='#/resetpassword/']")]
        [CacheLookup]
        private IWebElement ResetPasswordLink { get; set; }




        public void LoginToAppliction (string accountName)
        {
            Email.WaitUntilElementToBeClickable();
            Email.EnterText(accountName);
            Password.EnterText(accountName);
            Login.Submit();
            Page.CasesPage.WaitUntilSearchButtonIsClickable();
                    }

        public void GoToCreateAccountUserPage()
        {
            NewAccount.Click();
            SoftwareUser.Click();
        }

        public void GoToResetPasswordPage()
        {
            ResetPasswordLink.WaitUntilElementToBeClickable();
            ResetPasswordLink.Click();
            
        }
        }
}
