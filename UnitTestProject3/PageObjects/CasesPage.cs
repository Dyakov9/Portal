using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using System.Threading;
using TestDataAccess;
using WrapperFactory;
using UnitTestProject3.Extensions;

namespace UnitTestProject3.PageObjects
{
    public class CasesPage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[1]/div[1]/div/div[1]/input")]
        [CacheLookup]
        private IWebElement SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[1]/div[1]/div/div[1]/button")]
        [CacheLookup]
        private IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/div[1]/div[1]/div[2]/div/dl/dd[2]")]
        [CacheLookup]
        private IWebElement CaseId { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/div[1]/div[1]/div[1]/div[1]/button")]
        [CacheLookup]
        private IWebElement DetailsButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/div[1]/div[2]/div[1]/div[1]/ul/li[1]/img")]
        [CacheLookup]
        private IWebElement FirstImage { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/div[1]/div[2]/div[1]/div[1]/div/span")]
        [CacheLookup]
        private IWebElement ImageCarouselForwardButton { get; set; }
               
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/div[1]/div[2]/div[1]/div[1]/ul/li[2]/img")]
        [CacheLookup]
        private IWebElement SecondImage { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/div[2]/div[2]/textarea")]
        [CacheLookup]
        private IWebElement CommentField { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/div[2]/div[2]/div[2]/button")]
        [CacheLookup]
        private IWebElement SendCommentButton { get; set; }

        [FindsBy(How = How.Id, Using = "commentsFileInput")]
        [CacheLookup]
        private IWebElement AddImageButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='toast-container']/div/div[3]/div")]
        [CacheLookup]
        private IWebElement Toaster { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/div[1]/ul/li[5]/span")]
        [CacheLookup]
        private IWebElement PdfButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/div[1]/div[2]/div[2]/div[1]/a/input")]
        [CacheLookup]
        private IWebElement ChoosePdfFileButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/div[1]/div[2]/div[2]/div[1]/button")]
        [CacheLookup]
        private IWebElement UploadPdfFileButton { get; set; }

        [FindsBy(How = How.LinkText, Using = "AaZz059Kl.pdf")]
        [CacheLookup]
        private IWebElement PdfFileLink { get; set; }


        public void Search(string keyName)
        {
            SearchField.WaitUntilElementToBeClickable();
            var userData = ExcelDataAccess.GetTestData(keyName);
            SearchField.EnterText(userData.CaseId);
            SearchButton.WaitUntilElementToBeClickable();
            SearchButton.Click();
            DetailsButton.WaitUntilElementToBeClickable();
            DetailsButton.Click();
            BrowserFactory.WaitUntilTextToBePresentInElement(CaseId, userData.CaseId);
            
        }
        public void VerifyImagesAreDisplayed ()
        {
            Search("Clinic");
            FirstImage.WaitUntilElementToBeClickable();
            ImageCarouselForwardButton.WaitUntilElementToBeClickable();
            ImageCarouselForwardButton.Click();
            SecondImage.WaitUntilElementToBeClickable();
        }

        public void AddCommentWithImage(string keyName)
        {
           var userData = ExcelDataAccess.GetTestData(keyName);
           FirstImage.WaitUntilElementToBeClickable();
           CommentField.EnterText(userData.Text);
           AddImageButton.SendKeys(userData.FilePath);
           SendCommentButton.WaitUntilElementToBeClickable();
           SendCommentButton.Click();
           BrowserFactory.WaitUntilTextToBePresentInElement(Toaster, userData.AddCommentWithImageResponse);

        }
        public void UploadPdfFile(string path)
        {
            Search("Clinic");
            PdfButton.WaitUntilElementToBeClickable();
            PdfButton.Click();
            ChoosePdfFileButton.SendKeys(path);
            UploadPdfFileButton.Click();
            BrowserFactory.WaitUntilTextToBePresentInElement(Toaster, "You have successfully uploaded the file!");
        }
            }
}
