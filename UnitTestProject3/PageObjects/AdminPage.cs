using System.Configuration;
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

        [FindsBy(How = How.CssSelector, Using = "div[class='list-item__title ng-binding']")]
        [CacheLookup]
        private IWebElement FoundUserResult { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href='#/settings/UiTestClinic@spam4.me']")]
        [CacheLookup]
        private IWebElement UserSettingsLink { get; set; }

        public void GoToUserSettingsPage(string userEmail)
        {
            SearchUsersField.WaitUntilElementToBeClickable();
            SearchUsersField.EnterText(userEmail);
            SearchUsersButton.Click();
            FoundUserResult.WaitUntilTextToBePresentInElement(userEmail);
            UserSettingsLink.Click();

        }
       
             }
}