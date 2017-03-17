﻿using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestDataAccess;
using WrapperFactory;

namespace PageObjects
{
    public class SettingsPage
    {

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[3]/button")]
        [CacheLookup]
        private IWebElement EditAccoutInformationButton { get; set; }

        public void EditAccountInformation()
        {
            BrowserFactory.WaitUntilElementToBeClickable(EditAccoutInformationButton);
            EditAccoutInformationButton.Click();
        }
    }
}
