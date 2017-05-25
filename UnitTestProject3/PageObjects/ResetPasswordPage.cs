using System;
using System.Configuration;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WrapperFactory;
using UnitTestProject3.Extensions;

namespace PageObjects
{
    public class ResetPasswordPage
    {


        [FindsBy(How = How.CssSelector, Using = "input[ng-class='{filled: userEmail}']")]
        [CacheLookup]
        private IWebElement Email { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[value='Reset password']")]
        [CacheLookup]
        private IWebElement ResetPasswordButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='toast-container']/div/div[3]/div")]
        [CacheLookup]
        private IWebElement Message { get; set; }

       
      
        
        public void ResetPassword()
        {
            
            Email.WaitUntilElementToBeClickable();
            Email.EnterText(ConfigurationManager.AppSettings["ClinicAccount"]);
            ResetPasswordButton.WaitUntilElementToBeClickable();
            ResetPasswordButton.Click();
            Message.WaitUntilTextToBePresentInElement("An email containing a link for password change has been sent (if the email does not appear in your inbox, please check your spam folder");
            
        }
    }
}
