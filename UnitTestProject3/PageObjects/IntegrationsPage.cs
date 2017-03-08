﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjects
{
    public class IntegrationsPage
    {

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

        public void GoToCasePage()
        {
            CasesPageLink.Click();
        }
       
        public void GoToConnectionsPage()
        {
            ConnectionsPageLink.Click();
        }
        public void IntegrateAccounts()
        {
            IntegrateAccountsButton.Click();
            ValidationCodeField.Clear();
            ValidationCodeField.SendKeys("688540");
            ValidationCodeCheckBox.Click();
            ValidationCodeProceedButton.Click();
        }
    }
}