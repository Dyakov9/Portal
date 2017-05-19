using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using UnitTestProject3.Extensions;


namespace PageObjects
{
    public class CreateAccountUserPage
    {

        [FindsBy(How = How.CssSelector, Using = "input[ng-model='userModel.Email']")]
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

        [FindsBy(How = How.Name, Using = "FirstName")]
        [CacheLookup]
        private IWebElement FirstNameField { get; set; }

        [FindsBy(How = How.Name, Using = "LastName")]
        [CacheLookup]
        private IWebElement LastNameField { get; set; }

        [FindsBy(How = How.TagName, Using = "button")]
        [CacheLookup]
        private IWebElement NextButton1Step { get; set; }

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

       [FindsBy(How = How.Name, Using = "PhoneNumber")]
        [CacheLookup]
        private IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[2]/div/form/div[3]/div[1]/div[8]/div/div[2]/button")]
        [CacheLookup]
        private IWebElement NextButton2Step { get; set; }

        [FindsBy(How = How.Name, Using = "dongleNumber")]
        [CacheLookup]
        private IWebElement DongleNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[2]/div/form/div[4]/div[1]/div[2]/div/div[2]/button")]
        [CacheLookup]                      
        private IWebElement NextButton3Step { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label[for='practice']")]
        [CacheLookup]
        private IWebElement PracticeToggleButton { get; set; }

       [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[2]/div/form/div[5]/div[1]/div[3]/div/div[2]/button")]
        [CacheLookup]
        private IWebElement CreateAccountButton { get; set; }

        
        public void CreateNewAccount()
        {
            Email.WaitUntilElementToBeClickable();           
            Email.EnterText(ConfigurationManager.AppSettings["NewAccount"]); 
            Password.EnterText(ConfigurationManager.AppSettings["NewAccount"]);
            PasswordRepeated.EnterText(ConfigurationManager.AppSettings["NewAccount"]);
            FirstNameField.EnterText(ConfigurationManager.AppSettings["NewAccount"]);
            LastNameField.EnterText(ConfigurationManager.AppSettings["NewAccount"]); 
            NextButton1Step.Click();
            Name.EnterText(ConfigurationManager.AppSettings["NewAccount"]);
            Country.SelectItem("United States");
            State.SelectItem("Alaska");
            City.SendKeys(ConfigurationManager.AppSettings["NewAccount"]);
            StreetAddress.SendKeys(ConfigurationManager.AppSettings["NewAccount"]);
            PhoneNumber.EnterText("518-457-5181");
            NextButton2Step.WaitUntilElementToBeClickable();
            NextButton2Step.Click();
            DongleNumber.EnterText("945390570");
            NextButton3Step.WaitUntilElementToBeClickable();
            Thread.Sleep(1000);
            NextButton3Step.Click();
            PracticeToggleButton.Click();
            CreateAccountButton.Click();
            Thread.Sleep(1000);

        }
       
             }
}