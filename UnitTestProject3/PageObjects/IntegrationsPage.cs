﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;
using OpenQA.Selenium.Internal;
using WrapperFactory;
using System.Threading;

namespace PageObjects
{
    public class IntegrationsPage
    {
        private IAlert Alert { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[3]/div/ul/li[2]/div[2]/div[4]/button")]
        [CacheLookup]
        private IWebElement IntegrateAccountsButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/nav/section/ul/div/li[1]/a")]
        [CacheLookup]
        private IWebElement CasesPageLink { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/nav/section/ul/div/li[2]/a")]
        [CacheLookup]
        private IWebElement ConnectionsPageLink { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[3]/div/input")]
        [CacheLookup]
        private IWebElement ValidationCodeField { get; set; }

        [FindsBy(How = How.Id, Using = "swornDeclarationCheckBox")]
        [CacheLookup]
        private IWebElement ValidationCodeCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[5]/div[2]/button")]
        [CacheLookup]
        private IWebElement ValidationCodeProceedButton { get; set; }

        [FindsBy(How = How.Id, Using = "doctorname")]
        [CacheLookup]
        private IWebElement DoctorNameField { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        private IWebElement DoctorPasswordField { get; set; }

        [FindsBy(How = How.Id, Using = "form_0")]
        [CacheLookup]
        private IWebElement AlignPageLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[3]/div/ul/li[1]/div/div[4]/button")]
        [CacheLookup]
        private IWebElement DisconnectAccountsButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='toast-container']/div/div[3]/div")]
        [CacheLookup]
        private IWebElement IntegrationPageToaster { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/nav/section/ul/div/li[5]/a")]
        [CacheLookup]
        private IWebElement ProfileMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/nav/section/ul/div/li[5]/ul/li[2]/a")]
        [CacheLookup]                         
        private IWebElement LogOutLink { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/nav/section/ul/div/li[5]/ul/li[1]/a")]
        [CacheLookup]
        private IWebElement SettingsPageLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='toggleNav']/li[5]/a")]
        [CacheLookup]
        private IWebElement Profile { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='toggleNav']/li[5]/ul/li[2]/a")]
        [CacheLookup]
        private IWebElement SettingsPageLink2 { get; set; }


        public void GoToCasePage()
        {
            CasesPageLink.Click();
        }

        public void GoToSettingsPage()
        {
            //BrowserFactory.WaitUntilElementToBeClickable(IntegrateAccountsButton);
            Thread.Sleep(1000);
            BrowserFactory.MoveToElement(ProfileMenu);
            SettingsPageLink = BrowserFactory.FindElementByLokator(By.XPath("/html/body/div[2]/div/nav/section/ul/div/li[5]/ul/li[1]/a"));
            //Thread.Sleep(5000);
            //BrowserFactory.WaitUntilElementIsVisible(By.XPath("/html/body/div[2]/div/nav/section/ul/div/li[5]/ul/li[1]/a"));
           // BrowserFactory.WaitUntilElementToBeClickable(SettingsPageLink);
            SettingsPageLink.Click();

        }

        public void GoToConnectionsPage()
        {
            ConnectionsPageLink.Click();
        }
        public void IntegrateAccounts()
        {
            BrowserFactory.WaitUntilElementToBeClickable(IntegrateAccountsButton);
            IntegrateAccountsButton.Click();
            BrowserFactory.WaitUntilElementToBeClickable(ValidationCodeField);
            ValidationCodeField.Clear();
            ValidationCodeField.SendKeys("688540");
            ValidationCodeCheckBox.Click();
            ValidationCodeProceedButton.Click();
            BrowserFactory.WaitUntilElementToBeClickable(DoctorNameField);
            DoctorNameField.Clear();
            DoctorNameField.SendKeys("ntest");
            DoctorPasswordField.Clear();
            DoctorPasswordField.SendKeys("align");
            AlignPageLogin.Click();
            BrowserFactory.WaitUntilTextToBePresentInElement(DisconnectAccountsButton, "Disconnect accounts");
                    }
        public void DisconnectAccounts()
        {
            BrowserFactory.WaitUntilElementToBeClickable(DisconnectAccountsButton);
            DisconnectAccountsButton.Click();
            BrowserFactory.WaitUntilTextToBePresentInElement(IntegrationPageToaster, "You have successfully disconnected your Invisalign integration");
                    }

        public void LogOut()
        {
            //BrowserFactory.WaitUntilElementToBeClickable(ProfileMenu);
            //BrowserFactory.WaitUntilElementToBeClickable(IntegrateAccountsButton);
           //BrowserFactory.MoveToElement(ProfileMenu);
           Thread.Sleep(3000);
            BrowserFactory.WaitUntilElementIsVisible(By.XPath("/html/body/div[2]/div/nav/section/ul/div/li[5]/ul/li[1]/a"));
            
            LogOutLink.Click();
            //BrowserFactory.WaitUntilUrlToBe(ConfigurationManager.AppSettings["LoginPageURL"]);
        }
    }
}