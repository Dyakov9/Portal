using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using UnitTestProject3.Extensions;


namespace PageObjects
{
    public class AccessOldCasesPage
    {


        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Search by caseId']")]
        [CacheLookup]
        private IWebElement SearchByIdField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div[class='list-item__meta ng-binding']")]
        [CacheLookup]
        private IWebElement CasesResult { get; set; }

        [FindsBy(How = How.Id, Using = "searchForCasesButton")]
        [CacheLookup]
        private IWebElement SearchForCasesButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span[ng-click='ctrl.selectAllCaseForMigration()']")]
        [CacheLookup]
        private IWebElement SelectAllButton{ get; set; }

        [FindsBy(How = How.Id, Using = "migrateOldCases")]
        [CacheLookup]
        private IWebElement MakeSelectedCasesAvailableButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='toast-container']/div/div[3]/div")]
        [CacheLookup]
        public IWebElement Toaster { get; set; }

        //<div class="ng-binding ng-scope" ng-switch-default="">Your request to make cases available has been received</div>
        
      
        public void MigrateOldCases()
        {
            SearchByIdField.WaitUntilElementToBeClickable();
            SearchByIdField.EnterText(ConfigurationManager.AppSettings["CaseId"]);
            SearchForCasesButton.Click();
            CasesResult.WaitUntilTextToBePresentInElement(ConfigurationManager.AppSettings["CaseId"]);
            SelectAllButton.Click();
            MakeSelectedCasesAvailableButton.Click();
            Extensions.AcceptAlertWithMessage("Would you like to make 3 case(s) available on your Cases page?");
            Toaster.WaitUntilTextToBePresentInElement("Your request to make cases available has been received");
            
           

        }
       
             }
}