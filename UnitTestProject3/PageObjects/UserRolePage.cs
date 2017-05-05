using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using UnitTestProject3.Extensions;


namespace PageObjects
{
    public class UserRolePage
    {

        [FindsBy(How = How.Id, Using = "roleforusers")]
        [CacheLookup]
        private IWebElement RoleDropDown { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[ng-disabled='loading']")]
        [CacheLookup]
        private IWebElement GetUsersButton { get; set; }
        
        public void GetUsersByRole(string role)
        {
           RoleDropDown.WaitUntilTextToBePresentInElement("Administrator");
           RoleDropDown.SelectItem(role);
           GetUsersButton.Click();
        }
       
             }
}