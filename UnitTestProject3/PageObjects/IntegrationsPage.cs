using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;
using OpenQA.Selenium.Internal;
using WrapperFactory;
using System.Threading;
using UnitTestProject3.Extensions;

namespace PageObjects
{
    public class IntegrationsPage
    {
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[3]/div/ul/li[2]/div[2]/div[4]/button")]
        [CacheLookup]
        private IWebElement IntegrateAccountsButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[3]/div/input")]
        [CacheLookup]
        private IWebElement ValidationCodeField { get; set; }

        [FindsBy(How = How.Id, Using = "swornDeclarationCheckBox")]
        [CacheLookup]
        private IWebElement ValidationCodeCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[5]/div[2]/button")]
        [CacheLookup]
        private IWebElement ValidationCodeProceedButton { get; set; }

        [FindsBy(How = How.Id, Using = "doctorname")]
        [CacheLookup]
        private IWebElement DoctorNameField { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        private IWebElement DoctorPasswordField { get; set; }

        [FindsBy(How = How.Id, Using = "form_0")]
        [CacheLookup]
        private IWebElement AlignPageLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[3]/div/ul/li[1]/div/div[4]/button")]
        [CacheLookup]
        private IWebElement DisconnectAccountsButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='toast-container']/div/div[3]/div")]
        [CacheLookup]
        private IWebElement IntegrationPageToaster { get; set; }

        public void IntegrateAccounts()
        {
            IntegrateAccountsButton.WaitUntilElementToBeClickable();
            IntegrateAccountsButton.Click();
            ValidationCodeField.WaitUntilElementToBeClickable();
            ValidationCodeField.EnterText("688540");
            ValidationCodeCheckBox.Click();
            ValidationCodeProceedButton.Click();
            DoctorNameField.WaitUntilElementToBeClickable();
            DoctorNameField.EnterText("ntest");
            DoctorPasswordField.EnterText("align");
            AlignPageLogin.Click();
            DisconnectAccountsButton.WaitUntilTextToBePresentInElement("Disconnect accounts");
                    }
        public void DisconnectAccounts()
        {
            DisconnectAccountsButton.WaitUntilElementToBeClickable();
            DisconnectAccountsButton.Click();
            IntegrationPageToaster.WaitUntilTextToBePresentInElement( "You have successfully disconnected your Invisalign integration");
                    }
        }
}