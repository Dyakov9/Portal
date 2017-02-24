using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestDataAccess;
using WrapperFactory;


namespace UnitTestProject3.PageObjects
{
   public class ConnectionsPage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[1]/button")]
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

        public void SendConnectionRequest(string keyName)
        {
            var userData = ExcelDataAccess.GetTestData(keyName);
            AddConnectionButton.Click();
            FindColloboratorField.Clear();
            FindColloboratorField.SendKeys(userData.Email);
            FindColloboratorButton.Click();
            ColloboratorsName.Click();
            ConnectButton.Click();

        }
        
    }
}
