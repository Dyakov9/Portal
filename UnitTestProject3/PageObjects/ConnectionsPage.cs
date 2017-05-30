using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WrapperFactory;
using UnitTestProject3.Extensions;

namespace UnitTestProject3.PageObjects
{
   public class ConnectionsPage
   {
        
        [FindsBy(How = How.CssSelector, Using = "button[class=button][ng-click='ctrl.openModal()']")]
        [CacheLookup]
        private IWebElement AddConnectionButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[2]/div[1]/input")]
        [CacheLookup]
        private IWebElement FindColloboratorField { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[2]/div[2]/button")]
        [CacheLookup]
        private IWebElement FindColloboratorButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[3]/div/div/ul/li[1]/div/div[2]")]
        [CacheLookup]
        private IWebElement ColloboratorsName { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[4]/div[2]/button")]
        [CacheLookup]
        private IWebElement ConnectButton { get; set; }

       [FindsBy(How = How.CssSelector, Using = "img[alt='Approve connection']")]
        [CacheLookup]
        private IWebElement ApproveConnectionButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span[class='ng-binding active']")]
        [CacheLookup]
        private IWebElement ConnectionStateText { get; set; }

        [FindsBy(How = How.CssSelector, Using = "img[alt='Remove connection']")]
        [CacheLookup]
        private IWebElement RemoveConnectionButton { get; set; }
       
      

        public void SendConnectionRequest(string accountName)
        {
            AddConnectionButton.WaitUntilElementToBeClickable();
            AddConnectionButton.Click();
            FindColloboratorField.WaitUntilElementToBeClickable();
            FindColloboratorField.EnterText(accountName);
            FindColloboratorButton.Click();
            ColloboratorsName.WaitUntilElementToBeClickable();
            ColloboratorsName.Click();
            ConnectButton.Click();
            Extensions.Extensions.WaitUntilAlertIsPresent();
            Extensions.Extensions.AcceptAlertWithMessage("connection request was sent");
        }

        public void ApproveConnectionRequestAndRemoveConnection()
        {
            var connectionStateCssSelector = "span[class='ng-binding active']";
            ApproveConnectionButton.WaitUntilElementToBeClickable();
            ApproveConnectionButton.Click();
            ConnectionStateText.WaitUntilElementToBeClickable();
            RemoveConnectionButton.WaitUntilElementToBeClickable();
            RemoveConnectionButton.Click();
            Extensions.Extensions.AcceptAlertWithMessage("This action will remove the connection and cannot be undone. Would you like to proceed?");
            Extensions.Extensions.WaitUntilElementIsInvisible(By.CssSelector(connectionStateCssSelector));
        }


    }
}
