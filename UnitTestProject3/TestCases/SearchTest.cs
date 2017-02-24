﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;
using System.Configuration;
using WrapperFactory;

namespace TestCases
{
    [TestClass]
    public class SearchTest
    {
     [TestMethod]
         public void Search()
         {
             BrowserFactory.InitBrowser();
             BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
             Page.Login.LoginToAppliction("Clinic");
             Page.IntegrationsPage.GoToCasePage();
             Page.CasesPage.Search("Clinic");
             BrowserFactory.QuitBrowser();
         }
    }
}
