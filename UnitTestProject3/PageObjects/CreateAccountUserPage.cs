using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace PageObjects
{
    public class CreateAccountUserPage
    {

        [FindsBy(How = How.Name, Using = "Email")]
        [CacheLookup]
        private IWebElement Email { get; set; }

        [FindsBy(How = How.Name, Using = "Name")]
        [CacheLookup]
        private IWebElement Name { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        [CacheLookup]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Name, Using = "Password-repeated")]
        [CacheLookup]
        private IWebElement PasswordRepeated { get; set; }

        [FindsBy(How = How.TagName, Using = "button")]
        [CacheLookup]
        private IWebElement NextButton1Step { get; set; }

        [FindsBy(How = How.Name, Using = "ContactName")]
        [CacheLookup]
        private IWebElement ContactName { get; set; }

        [FindsBy(How = How.Name, Using = "country")]
        [CacheLookup]
        private IWebElement Country { get; set; }

        [FindsBy(How = How.Name, Using = "state")]
        [CacheLookup]
        private IWebElement State { get; set; }

        [FindsBy(How = How.Name, Using = "City")]
        [CacheLookup]
        private IWebElement City { get; set; }

        [FindsBy(How = How.Name, Using = "AddressLine")]
        [CacheLookup]
        private IWebElement StreetAddress { get; set; }

        [FindsBy(How = How.Name, Using = "PostalCode")]
        [CacheLookup]
        private IWebElement PostalCode { get; set; }

        [FindsBy(How = How.Name, Using = "PhoneNumber")]
        [CacheLookup]
        private IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/form/div[3]/div[1]/div[8]/div/div[2]/button")]
        [CacheLookup]
        private IWebElement NextButton2Step { get; set; }

        [FindsBy(How = How.Name, Using = "dongleNumber")]
        [CacheLookup]
        private IWebElement DongleNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/form/div[4]/div[1]/div[2]/div/div[2]/button")]
        [CacheLookup]
        private IWebElement NextButton3Step { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/form/div[5]/div[1]/div[1]/div/label")]
        [CacheLookup]
        private IWebElement PracticeToggleButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/form/div[5]/div[1]/div[2]/div/label/span")]
        [CacheLookup]
        private IWebElement LabToggleButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/form/div[5]/div[1]/div[3]/div/div[2]/button")]
        [CacheLookup]
        private IWebElement CreateAccountButton { get; set; }

        
        public void EnterLoginInfo()
        {
            Email.Clear();
            Email.SendKeys("Testclinic44444444@3shapecommunicate.com");
            Name.Clear();
            Name.SendKeys("Testclinic444");
            Password.Clear();
            Password.SendKeys("Testclinic444@3shapecommunicate.com");
            PasswordRepeated.Clear();
            PasswordRepeated.SendKeys("Testclinic444@3shapecommunicate.com");
            NextButton1Step.Click();
            
        }
       public void EnterAccountInfo()
        {
            ContactName.Clear();
            ContactName.SendKeys("Testclinic444");
            SelectElement selectCountry = new SelectElement(Country);
            selectCountry.SelectByText("United States");
            SelectElement selectState = new SelectElement(State);
            selectState.SelectByText("Alaska");
            City.Clear();
            City.SendKeys("NY");
            StreetAddress.Clear();
            StreetAddress.SendKeys("Manhattan");
            PostalCode.Clear();
            PostalCode.SendKeys("10002");
            PhoneNumber.Clear();
            PhoneNumber.SendKeys("518-457-5181");
            NextButton2Step.Click();
                   }
        public void EnterDongleNumber()
        {
            DongleNumber.Clear();
            DongleNumber.SendKeys("945390570");
            Thread.Sleep(1000);
            NextButton3Step.Click();
        }
        public void ChooseRole()
        {
            PracticeToggleButton.Click();
            LabToggleButton.Click();
        }
        public void CreateAccount()
        {
            CreateAccountButton.Click();
            Assert.IsTrue(Page.IntegrationsPage.IntegrateAccountsButton.Displayed);
        }

       }
}