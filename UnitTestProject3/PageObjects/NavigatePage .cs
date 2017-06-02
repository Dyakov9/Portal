using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using UnitTestProject3.Extensions;


namespace PageObjects
{
    public class NavigatePage
    {


        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/nav/section/ul/div/li[1]/a")]
        [CacheLookup]
        private IWebElement CasesPageLink { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/nav/section/ul/div/li[2]/a")]
        [CacheLookup]
        private IWebElement ConnectionsPageLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[class='profile ng-binding']")]
        [CacheLookup]
        private IWebElement ProfileMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[ng-click='ctrl.logOff()']")]
        [CacheLookup]
        private IWebElement LogOutLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href='#/settings/']")]
        [CacheLookup]
        private IWebElement SettingsPageLink { get; set; }

        [FindsBy(How = How.ClassName, Using = "more")]
        [CacheLookup]
        private IWebElement MoreItem { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href='#/userrole']")]
        [CacheLookup]
        private IWebElement UserRolePageLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href='#/admin']")]
        [CacheLookup]
        private IWebElement AdminPageLink { get; set; }

        [FindsBy(How = How.ClassName, Using = "orderForm")]
        [CacheLookup]
        private IWebElement OrderFormTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href='#/templates']")]
        [CacheLookup]
        private IWebElement TemplatesLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href='#/accessOldCases']")]
        [CacheLookup]
        private IWebElement AccessOldCasesLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[ng-click='ctrl.approveCase(currentCase)']")]
        [CacheLookup]
        private IWebElement ApproveCaseButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[ng-click='ctrl.rejectCase(currentCase)']")]
        [CacheLookup]
        private IWebElement RejectCaseButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[ng-click='ctrl.deleteCase(currentCase)']")]
        [CacheLookup]
        private IWebElement DeleteCaseButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href='#/integrations/']")]
        [CacheLookup]
        private IWebElement IntegrationsPageLink { get; set; }

       
        public void GoToCasesPage()
        {
            CasesPageLink.Click();
        }

        public void GoToSettingsPage()
        {
            ProfileMenu.MoveToElement();
            SettingsPageLink.Click();

        }

        public void GoToConnectionsPage()
        {
            ConnectionsPageLink.Click();
        }

        public void LogOut()
        {
            ProfileMenu.MoveToElement();
            LogOutLink.Click();
            Extensions.WaitUntilUrlToBe(ConfigurationManager.AppSettings["LoginPageURL"]);
        }

        public void GoToUserRolePage()
        {
            MoreItem.MoveToElement();
            UserRolePageLink.Click();
        }

        public void GoToAdminPage()
        {
            MoreItem.MoveToElement();
            AdminPageLink.Click();
        }
        
        public void GoToTemplatesPage()
        {
            OrderFormTab.MoveToElement();
            TemplatesLink.Click();
        }

        public void GoToAccessOldCasesPage()
        {
            MoreItem.MoveToElement();
            AccessOldCasesLink.Click();
        }

        public void VerifyThatApproveRejectDeleteAreClickable()
        {
           ApproveCaseButton.WaitUntilElementToBeClickable();
           RejectCaseButton.WaitUntilElementToBeClickable();
           DeleteCaseButton.WaitUntilElementToBeClickable();
        }

        public void GoToIntegrationsPage()
        {
           IntegrationsPageLink.Click();
        }

     
             }
}