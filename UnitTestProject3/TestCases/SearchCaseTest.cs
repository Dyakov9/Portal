﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using NUnit.Framework;
using UnitTestProject3.Extensions;
using WrapperFactory;


namespace TestCases
{
 [TestClass]
    public class SearchCaseTest
    {
        [TestMethod]
        public void SearchCase()
        {
            BrowserFactory.InitBrowser(Extensions.GetRandomBrowserName());
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            Page.Login.LoginToAppliction(ConfigurationManager.AppSettings["ClinicAccount"]);
            Page.NavigationPage.GoToCasesPage();
            Page.CasesPage.Search();
            BrowserFactory.QuitBrowser();
            }
    }
}
