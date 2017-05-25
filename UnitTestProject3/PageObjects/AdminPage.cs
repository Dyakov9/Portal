﻿using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using UnitTestProject3.Extensions;


namespace PageObjects
{
    public class AdminPage
    {

     
        [FindsBy(How = How.CssSelector, Using = "input[ng-model='searchString']")]
        [CacheLookup]
        private IWebElement SearchUsersField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[ng-click='search()']")]
        [CacheLookup]
        private IWebElement SearchUsersButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[ng-click='setPointOFView(foundUser)']")]
        [CacheLookup]
        private IWebElement FoundUserResult { get; set; }

        public void GoToUserSettingsPage(string userEmail)
        {
            SearchUsersField.WaitUntilElementToBeClickable();
            SearchUsersField.EnterText(userEmail);
            SearchUsersButton.Click();
            FoundUserResult.WaitUntilTextToBePresentInElement(userEmail);
            FoundUserResult.Click();

        }
       
             }
}