using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using System.Threading;
using WrapperFactory;
using UnitTestProject3.Extensions;
using System.Configuration;

namespace UnitTestProject3.PageObjects
{
    public class CasesPage
    {
        string date = DateTime.Now.ToString();

        [FindsBy(How = How.CssSelector, Using = "input[type=search]")]
        [CacheLookup]
        private IWebElement SearchField { get; set; }

        [FindsBy(How = How.Id, Using = "searchForCasesButton")]
        [CacheLookup]
        private IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/div[1]/div[1]/div[2]/dl/dd[2]")]
        [CacheLookup]
        private IWebElement CaseId { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[class='show-details']")]
        [CacheLookup]
        private IWebElement DetailsButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span[title='Comments']")]
        [CacheLookup]
        private IWebElement CommentTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "textarea[ng-model='messageText']")]
        [CacheLookup]
        private IWebElement CommentField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[ng-click='ctrl.sendComment()']")]
        [CacheLookup]
        private IWebElement SendCommentButton { get; set; }

        [FindsBy(How = How.Id, Using = "commentsFileInput")]
        [CacheLookup]
        private IWebElement AddImageButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='toast-container']/div/div[3]/div")]
        [CacheLookup]
        private IWebElement Toaster { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/ul/li[4]/span")]
        [CacheLookup]
        private IWebElement PdfTab { get; set; }

        [FindsBy(How = How.Id, Using = "pdfFileToUpload")]
        [CacheLookup]
        private IWebElement ChoosePdfFileButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[class='uploadFileButton']")]
        [CacheLookup]
        private IWebElement UploadPdfFileButton { get; set; }

        [FindsBy(How = How.Name, Using = "searchByCasesStates")]
        [CacheLookup]
        private IWebElement SearchByCasesStatesDropDown { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[ng-click='ctrl.approveCase(currentCase)']")]
        [CacheLookup]
        private IWebElement ApproveCaseButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span[title='Order Updates']")]
        [CacheLookup]
        private IWebElement OrderUpdatesTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span[class='ng-binding']")]
        [CacheLookup]
        private IWebElement OrderUpdateResult { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label[for='practice']")]
        [CacheLookup]
        private IWebElement GetDeIdentifiedUpdatesToggle { get; set; }



        public void Search()
        {
            SearchField.WaitUntilElementToBeClickable();
            SearchField.EnterText(ConfigurationManager.AppSettings["CaseId"]);
            SearchByCasesStatesDropDown.SelectItem("Designed");
            SearchButton.WaitUntilElementToBeClickable();
            SearchButton.Click();
            Thread.Sleep(500);
            DetailsButton.WaitUntilElementToBeClickable();
            DetailsButton.Click();
            CaseId.WaitUntilTextToBePresentInElement(ConfigurationManager.AppSettings["CaseId"]);
            
        }
       
        public void AddCommentWithImage()
        {
           DetailsButton.WaitUntilElementToBeClickable();
           CommentTab.WaitUntilElementToBeClickable();
           CommentTab.Click();
           CommentField.WaitUntilElementToBeClickable();
           CommentField.EnterText(date);
           AddImageButton.SendKeys(ConfigurationManager.AppSettings["LogoFilePath"]);
           SendCommentButton.WaitUntilElementToBeClickable();
           SendCommentButton.Click();
           Toaster.WaitUntilTextToBePresentInElement("comment with image added");

        }

    
        public void UploadPdfFile(string path)
        {
            DetailsButton.WaitUntilElementToBeClickable();
            PdfTab.WaitUntilElementToBeClickable();
            PdfTab.Click();
            ChoosePdfFileButton.SendKeys(path);
            UploadPdfFileButton.Click();
            Toaster.WaitUntilTextToBePresentInElement( "You have successfully uploaded the file!");
        }

        public void GetDeIdentifiedOrderUpdates()
        {
            Thread.Sleep(500);
            OrderUpdatesTab.WaitUntilElementToBeClickable();
            OrderUpdatesTab.Click();
            GetDeIdentifiedUpdatesToggle.WaitUntilElementToBeClickable();
            GetDeIdentifiedUpdatesToggle.Click();
            Thread.Sleep(500);
            GetDeIdentifiedUpdatesToggle.Click();
            OrderUpdateResult.WaitUntilTextToBePresentInElement("5885d5b0-9fce-404c-afc3-a77e009f232a");
            
        }
            }
}
