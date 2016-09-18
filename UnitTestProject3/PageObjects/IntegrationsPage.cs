using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjects
{
    public class IntegrationsPage
    {

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[3]/div/ul/li[2]/div/div[4]/button")]
        [CacheLookup]
        public IWebElement IntegrateAccountsButton { get; set; }

    }
}