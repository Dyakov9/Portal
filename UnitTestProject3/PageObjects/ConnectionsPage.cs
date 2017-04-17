using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestDataAccess;
using WrapperFactory;
using UnitTestProject3.Extensions;

namespace UnitTestProject3.PageObjects
{
   public class ConnectionsPage
   {
        private IAlert Alert { get; set; }

        private string ActualAlertText { get; set; }

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

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/nav/ul/li[2]/a")]
        [CacheLookup]
        private IWebElement LogOutLink { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/div[1]/div/ul/li/div/div[1]")]
        [CacheLookup]
        private IWebElement Colloborator { get; set; }

        [FindsBy(How = How.CssSelector, Using = "img[alt='Approve connection']")]
        [CacheLookup]
        private IWebElement ApproveConnectionButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span[class='ng-binding active']")]
        [CacheLookup]
        private IWebElement ConnectionStateText { get; set; }

        [FindsBy(How = How.CssSelector, Using = "img[alt='Remove connection']")]
        [CacheLookup]
        private IWebElement RemoveConnectionButton { get; set; }
       
      

        public void SendConnectionRequest(string keyName)
        {
            var userData = ExcelDataAccess.GetTestData(keyName);
            AddConnectionButton.WaitUntilElementToBeClickable();
            AddConnectionButton.Click();
            FindColloboratorField.WaitUntilElementToBeClickable();
            FindColloboratorField.EnterText(userData.Email);
            FindColloboratorButton.Click();
            ColloboratorsName.WaitUntilElementToBeClickable();
            ColloboratorsName.Click();
            ConnectButton.Click();
            Extensions.Extensions.WaitUntilAlertIsPresent();
            Alert = BrowserFactory.InitAlert();
            ActualAlertText = Alert.Text;
            Assert.AreEqual(userData.ExpectedResponseToConnectionRequest, ActualAlertText);
            Alert.Accept();
            
        }
        public void ApproveConnectionRequestAndRemoveConnection()
        {
            var connectionStateCssSelector = "span[class='ng-binding active']";
            ApproveConnectionButton.WaitUntilElementToBeClickable();
            ApproveConnectionButton.Click();
            ConnectionStateText.WaitUntilElementToBeClickable();
            RemoveConnectionButton.WaitUntilElementToBeClickable();
            RemoveConnectionButton.Click();
            BrowserFactory.InitAlert();
            Alert = BrowserFactory.InitAlert();
            ActualAlertText = Alert.Text;
            Assert.AreEqual("This action will remove the connection and cannot be undone. Would you like to proceed?", ActualAlertText);
            Alert.Accept();
            Extensions.Extensions.WaitUntilElementIsInvisible(By.CssSelector(connectionStateCssSelector));
        }


    }
}
