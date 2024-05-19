using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "userName")]
        [CacheLookup]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = ".login")]
        [CacheLookup]
        public IWebElement loginBtn { get; set; }

        [FindsBy(How = How.Id, Using = "newUser")]
        [CacheLookup]
        public IWebElement newUser { get; set; }

    }
}
