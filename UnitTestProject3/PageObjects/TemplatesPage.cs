using System;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WrapperFactory;
using UnitTestProject3.Extensions;

namespace PageObjects
{
    public class TemplatesPage
    {
     
        [FindsBy(How = How.Id, Using = "templateFileInput")]
        [CacheLookup]                            
        private IWebElement TemplateFileInputButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "uploadFileButton")]
        [CacheLookup]
        private IWebElement UploadFileButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span[class='ng-binding']")]
        [CacheLookup]
        private IWebElement TemplateResult { get; set; }

        [FindsBy(How = How.CssSelector, Using = "img[alt='Delete']")]
        [CacheLookup]
        private IWebElement DeleteButton { get; set; }

        public void UploadTemplate()
        {
            Extensions.WaitUntilElementExists(By.Id("templateFileInput"));
            TemplateFileInputButton.SendKeys(ConfigurationManager.AppSettings["TemplateFilePath"]);
            UploadFileButton.Click();
            TemplateResult.WaitUntilTextToBePresentInElement("Nastia Order Template");
        }

        public void DeleteTemplate()
        {
            DeleteButton.WaitUntilElementToBeClickable();
            DeleteButton.Click();
            Extensions.AcceptAlertWithMessage("This will permanently delete the template file. This action cannot be undone. Proceed?");
            Extensions.WaitUntilElementWithTextIsInvisible(By.CssSelector("span[class='ng-binding'"), "Nastia Order Template");
        }
    }
}
