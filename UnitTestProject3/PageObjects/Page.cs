using WrapperFactory;
using OpenQA.Selenium.Support.PageObjects;
using UnitTestProject3.PageObjects;

namespace PageObjects
{
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(BrowserFactory.Driver, page);
            return page;
        }

         public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }
        public static CreateAccountUserPage CreateAccountUser
        {
            get { return GetPage<CreateAccountUserPage>(); }
        }
        public static IntegrationsPage IntegrationsPage
        {
            get { return GetPage<IntegrationsPage>(); }
        }
        public static CasesPage CasesPage
        {
            get { return GetPage<CasesPage>(); }
        }
        public static ConnectionsPage ConnectionsPage
        {
            get { return GetPage<ConnectionsPage>(); }
        }
    }
}