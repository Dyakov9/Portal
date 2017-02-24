using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjects
{
    public class IntegrationsPage
    {

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div[3]/div/ul/li[2]/div/div[4]/button")]
        [CacheLookup]
        public IWebElement IntegrateAccountsButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/nav/section/ul/li[1]/a")]
        [CacheLookup]
        public IWebElement CasesPageLink { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/nav/section/ul/li[2]/a")]
        [CacheLookup]
        public IWebElement ConnectionsPageLink { get; set; }

        public void GoToCasePage()
        {
            CasesPageLink.Click();
        }
       
        public void GoToConnectionsPage()
        {
            ConnectionsPageLink.Click();
        }
    }
}