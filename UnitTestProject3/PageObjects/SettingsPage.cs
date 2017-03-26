using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestDataAccess;
using WrapperFactory;
using UnitTestProject3.Extensions;

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

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[3]/div[3]/table/tbody/tr[10]/td[2]")]
        [CacheLookup]
        private IWebElement DongleResult { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[3]/div[3]/table/tbody/tr[12]/td[2]")]
        [CacheLookup]
        private IWebElement NameResult { get; set; }

        [FindsBy(How = How.Name, Using = "name")]
        [CacheLookup]
        private IWebElement AccountName { get; set; }

        [FindsBy(How = How.Name, Using = "firstName")]
        [CacheLookup]
        private IWebElement FirstName { get; set; }

        [FindsBy(How = How.Name, Using = "lastName")]
        [CacheLookup]
        private IWebElement LastName { get; set; }

        [FindsBy(How = How.Name, Using = "dongleNumber")]
        [CacheLookup]
        private IWebElement DongleNumber { get; set; }

        [FindsBy(How = How.Name, Using = "addressLine")]
        [CacheLookup]
        private IWebElement StreetAddress { get; set; }

        [FindsBy(How = How.Name, Using = "city")]
        [CacheLookup]
        private IWebElement City { get; set; }

        [FindsBy(How = How.Name, Using = "country")]
        [CacheLookup]
        private IWebElement Country { get; set; }

        [FindsBy(How = How.Name, Using = "postalCode")]
        [CacheLookup]
        private IWebElement PostalCode { get; set; }

        [FindsBy(How = How.Name, Using = "phoneNumber")]
        [CacheLookup]
        private IWebElement PhoneNumber { get; set; }


        public void EditAccountInformation()
        {
            BrowserFactory.WaitUntilTextToBePresentInElement(AccountNameResult, "UiTestClinic@spam4.me");
            BrowserFactory.WaitUntilTextToBePresentInElement(AddressResult,"Long, LA, 111, Denmark");
            BrowserFactory.WaitUntilTextToBePresentInElement(PhoneNumberResult, "123");
            BrowserFactory.WaitUntilTextToBePresentInElement(DongleResult,"92295796");
            BrowserFactory.WaitUntilTextToBePresentInElement(NameResult, "John Big");
            EditAccoutInformationButton.WaitUntilElementToBeClickable();
            EditAccoutInformationButton.Click();
            AccountName.EnterText("UiTestClinic2@spam4.me");
           // FirstName.
        }
    }
}
