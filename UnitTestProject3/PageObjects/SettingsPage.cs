using System;
using System.Configuration;
using System.Runtime.InteropServices;
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

        [FindsBy(How = How.CssSelector, Using = "button[class='button edit-user-information__button']")]
        [CacheLookup]
        private IWebElement EditAccoutInformationButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[2]/div[1]/div/fieldset[2]/div/div[2]/div/div[2]")]
        [CacheLookup]
        private IWebElement AccountNameResult { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[2]/div[1]/div/fieldset[2]/div/div[3]/div/div[2]")]
        [CacheLookup]
        private IWebElement AddressResult { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[2]/div[1]/div/fieldset[2]/div/div[4]/div/div[2]")]
        [CacheLookup]
        private IWebElement PhoneNumberResult { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[2]/div[1]/div/fieldset[2]/div/div[5]/div/div[2]")]
        [CacheLookup]
        private IWebElement DongleResult { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[2]/div[1]/div/fieldset[3]/div/div[2]/div/div[2]")]
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
            var modifier = "Modified";
            AccountNameResult.WaitUntilTextToBePresentInElement(ConfigurationManager.AppSettings["AccountName"]);
            AddressResult.WaitUntilTextToBePresentInElement(ConfigurationManager.AppSettings["Address"]);
            PhoneNumberResult.WaitUntilTextToBePresentInElement(ConfigurationManager.AppSettings["PhoneNumber"]);
            DongleResult.WaitUntilTextToBePresentInElement(ConfigurationManager.AppSettings["Dongle"]);
            NameResult.WaitUntilTextToBePresentInElement(ConfigurationManager.AppSettings["Name"]);
            string[] addressSplittedParts = ConfigurationManager.AppSettings["Address"].Split(new[] {", "},StringSplitOptions.None);
            string[] nameSplittedParts = ConfigurationManager.AppSettings["Name"].Split();
            EditAccoutInformationButton.WaitUntilElementToBeClickable();
            EditAccoutInformationButton.Click();
            AccountName.EnterText(modifier + ConfigurationManager.AppSettings["AccountName"]);
            StreetAddress.EnterText(modifier + addressSplittedParts[0]);
            City.EnterText(modifier + addressSplittedParts[1]);
            PostalCode.EnterText(modifier + addressSplittedParts[2]);
            Country.WaitUntilTextToBePresentInElement("Denmark");
            Country.SelectItem("Croatia");
            PhoneNumber.EnterText(modifier + ConfigurationManager.AppSettings["PhoneNumber"]);
            FirstName.EnterText(modifier + nameSplittedParts[0]);
            LastName.EnterText(modifier + nameSplittedParts[1]);
        }
    }
}
