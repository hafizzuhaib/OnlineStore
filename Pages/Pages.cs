using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Pages
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);

            return page;
        }

        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }
    }
}
