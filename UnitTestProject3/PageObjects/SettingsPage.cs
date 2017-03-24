using System.Configuration;
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

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[3]/div[3]/table/tbody/tr[7]/td[2]")]
        [CacheLookup]
        private IWebElement AccountNameResult { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[3]/div[3]/table/tbody/tr[8]/td[2]")]
        [CacheLookup]
        private IWebElement AddressResult { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[3]/div[3]/table/tbody/tr[9]/td[2]")]
        [CacheLookup]
        private IWebElement PhoneNumberResult { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[3]/div[3]/table/tbody/tr[9]/td[2]")]
        [CacheLookup]
        private IWebElement DongleResult { get; set; }


        public void EditAccountInformation()
        {
            BrowserFactory.WaitUntilElementToBeClickable(EditAccoutInformationButton);
            //BrowserFactory.WaitUntilElementToBeClickable(PhoneNumber);
            EditAccoutInformationButton.Click();
            
        }
    }
}
