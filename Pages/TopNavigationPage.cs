using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Pages
{
    internal class TopNavigationPage
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static TopNavigationPage TopNavigation
        {
            get { return GetPage<TopNavigationPage>(); }
        }

        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }

        
    }
}
