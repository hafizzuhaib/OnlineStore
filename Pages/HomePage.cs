using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = ".//*[@id=\"app\"]/div/div/div[2]/div/div[6]")]
        [CacheLookup]

        public IWebElement bookStoreLink { get; set; }

    }
}
