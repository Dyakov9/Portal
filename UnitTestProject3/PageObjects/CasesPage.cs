using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PageObjects;
using TestDataAccess;
using WrapperFactory;

namespace UnitTestProject3.PageObjects
{
    public class CasesPage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[1]/div[1]/div/div[1]/input")]
        [CacheLookup]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[1]/div[1]/div/div[1]/button")]
        [CacheLookup]
        public IWebElement SearchButton { get; set; }

        public void Search(string testName)
        {
            var userData = ExcelDataAccess.GetTestData(testName);
            SearchField.Clear();
            SearchField.SendKeys(userData.CaseId);
            BrowserFactory.ExplicitlyWait(SearchButton);
            SearchButton.Click();
            
        }
    }
}
