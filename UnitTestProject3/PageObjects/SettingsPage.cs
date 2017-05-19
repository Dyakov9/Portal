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
    public class SettingsPage
    {
        String modifier = "Modified";
        String modifiedCountry = "Croatia";

        [FindsBy(How = How.CssSelector, Using = "button[class='button edit-user-information__button']")]
        [CacheLookup]
        private IWebElement EditAccoutInformationButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[2]/div[1]/div/fieldset[2]/div/div[2]/div/div[2]")]
        [CacheLookup]
        private IWebElement AccountNameResult { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[2]/div[1]/div/fieldset[2]/div/div[3]/div/div[2]")]
        [CacheLookup]
        private IWebElement AddressResult { get; set; }

       [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[2]/div[1]/div/fieldset[4]/div/div[2]/div/div[2]")]
        [CacheLookup]
        private IWebElement NameResult { get; set; }

        [FindsBy(How = How.Name, Using = "name")]
        [CacheLookup]
        private IWebElement AccountName { get; set; }

        [FindsBy(How = How.Name, Using = "firstName")]
        [CacheLookup]
        private IWebElement FirstName { get; set; }

       [FindsBy(How = How.Name, Using = "country")]
        [CacheLookup]
        private IWebElement Country { get; set; }

       [FindsBy(How = How.CssSelector, Using = "button[class='large-6 columns save-user-information__button']")]
        [CacheLookup]
        private IWebElement SaveChangesButton { get; set; }

       [FindsBy(How = How.CssSelector, Using = "button[class='edit-user-information__logo__edit-logo']")]
       [CacheLookup]
       private IWebElement ChangeLogoButton { get; set; }

       [FindsBy(How = How.Id, Using = "userLogoToUpload")]
       [CacheLookup]
       private IWebElement UploadLogoButton { get; set; }

       [FindsBy(How = How.ClassName, Using = "uploadFileButton")]
       [CacheLookup]
       private IWebElement UploadLogoOkButton { get; set; }

      [FindsBy(How = How.CssSelector, Using = "button[title='Delete account']")]
       [CacheLookup]
       private IWebElement DeleteAccountButton { get; set; }

       [FindsBy(How = How.CssSelector, Using = "button[ng-click='deleteAccount()']")]
       [CacheLookup]
       private IWebElement DeleteAccountConfirmationButton { get; set; }

       [FindsBy(How = How.CssSelector, Using = "li[ng-click='showAccountInfoOnly = false; showCompanyInfoOnly = true; showNotificationsOnly = false']")]
       [CacheLookup]
       private IWebElement AccountInfoTab { get; set; }


        
        public void EditCompanyInformation()
        {
           
            AccountInfoTab.WaitUntilElementToBeClickable();
            AccountInfoTab.Click();
            AccountNameResult.WaitUntilTextToBePresentInElement(ConfigurationManager.AppSettings["ClinicAccount"]);
            AddressResult.WaitUntilTextToBePresentInElement(ConfigurationManager.AppSettings["Country"]);
            EditAccoutInformationButton.WaitUntilElementToBeClickable();
            EditAccoutInformationButton.Click();
            ChangeLogoButton.Click();
            UploadLogoButton.SendKeys(ConfigurationManager.AppSettings["LogoFilePath"]);
            UploadLogoOkButton.Click();
            AccountName.EnterText(modifier + ConfigurationManager.AppSettings["ClinicAccount"]);
            Country.WaitUntilTextToBePresentInElement(ConfigurationManager.AppSettings["Country"]);
            Country.SelectItem(modifiedCountry);
            SaveChangesButton.Click();
            AccountNameResult.WaitUntilTextToBePresentInElement(modifier + ConfigurationManager.AppSettings["ClinicAccount"]);
            AddressResult.WaitUntilTextToBePresentInElement(modifiedCountry);
            EditAccoutInformationButton.Click();
            AccountName.EnterText(ConfigurationManager.AppSettings["ClinicAccount"]);
            Country.WaitUntilTextToBePresentInElement(modifiedCountry);
            Country.SelectItem(ConfigurationManager.AppSettings["Country"]);
            SaveChangesButton.Click();
            AccountNameResult.WaitUntilTextToBePresentInElement(ConfigurationManager.AppSettings["ClinicAccount"]);
        }

        public void EditAccountInformation()
        {
            NameResult.WaitUntilTextToBePresentInElement(ConfigurationManager.AppSettings["Name"]);
            EditAccoutInformationButton.WaitUntilElementToBeClickable();
            EditAccoutInformationButton.Click();
            FirstName.EnterText(modifier + ConfigurationManager.AppSettings["Name"]);
            SaveChangesButton.Click();
            NameResult.WaitUntilTextToBePresentInElement(modifier + ConfigurationManager.AppSettings["Name"]);
            EditAccoutInformationButton.Click();
            FirstName.EnterText(ConfigurationManager.AppSettings["Name"]);
            SaveChangesButton.Click();
            NameResult.WaitUntilTextToBePresentInElement(ConfigurationManager.AppSettings["Name"]);
        }
        
        public void DeleteAccount()
        {
            EditAccoutInformationButton.WaitUntilElementToBeClickable();
            EditAccoutInformationButton.Click();
            DeleteAccountButton.Click();
            DeleteAccountConfirmationButton.WaitUntilElementToBeClickable();
            DeleteAccountConfirmationButton.Click();
            Extensions.WaitUntilUrlToBe(ConfigurationManager.AppSettings["LoginPageURL"]);
        }
    }
}
