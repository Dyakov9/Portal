﻿using System;
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
        
        [FindsBy(How = How.CssSelector, Using = "img[alt='3shape.png']")]
        [CacheLookup]
        private IWebElement FirstImage { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/div[1]/div[2]/div[1]/div[1]/div/span")]
        [CacheLookup]
        private IWebElement ImageCarouselForwardButton { get; set; }
               
        [FindsBy(How = How.CssSelector, Using = "img[alt='Top.jpg']")]
        [CacheLookup]
        private IWebElement SecondImage { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/ul/li[3]/span")]
        [CacheLookup]
        private IWebElement CommentTab { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/div[1]/div[2]/div[3]/div[2]/textarea")]
        [CacheLookup]
        private IWebElement CommentField { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/div[1]/div[2]/div[3]/div[2]/div[2]/button")]
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

        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Start date']")]
        [CacheLookup]
        private IWebElement StartDateCalendar { get; set; }
       
        public void Search()
        {
            SearchField.WaitUntilElementToBeClickable();
            SearchField.EnterText(ConfigurationManager.AppSettings["CaseId"]);
           // StartDateCalendar.SendKeys("01-03-2016");
            SearchButton.WaitUntilElementToBeClickable();
            SearchButton.Click();
            DetailsButton.WaitUntilElementToBeClickable();
            DetailsButton.Click();
            CaseId.WaitUntilTextToBePresentInElement(ConfigurationManager.AppSettings["CaseId"]);
            
        }
        public void VerifyImagesAreDisplayed ()
        {
            Search();
            FirstImage.WaitUntilElementToBeClickable();
            ImageCarouselForwardButton.WaitUntilElementToBeClickable();
            ImageCarouselForwardButton.Click();
            SecondImage.WaitUntilElementToBeClickable();
        }

        public void AddCommentWithImage()
        {
           Search();
           FirstImage.WaitUntilElementToBeClickable();
           CommentTab.Click();
           CommentField.EnterText(ConfigurationManager.AppSettings["Country"]);
           AddImageButton.SendKeys(ConfigurationManager.AppSettings["LogoFilePath"]);
           SendCommentButton.WaitUntilElementToBeClickable();
           SendCommentButton.Click();
           Toaster.WaitUntilTextToBePresentInElement("comment with image added");

        }
        public void UploadPdfFile(string path)
        {
            Search();
            PdfTab.WaitUntilElementToBeClickable();
            PdfTab.Click();
            ChoosePdfFileButton.SendKeys(path);
            UploadPdfFileButton.Click();
            Toaster.WaitUntilTextToBePresentInElement( "You have successfully uploaded the file!");
        }
            }
}
