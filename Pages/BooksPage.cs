// Ignore Spelling: Online

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace OnlineStore.Pages
{
    public class BooksPage
    {
        private IWebDriver driver;


        [FindsBy(How = How.Id, Using = ".searchBox")]
        public IWebElement searchBox { get; set; }


        [FindsBy(How = How.Id, Using = ".login")]
        public IWebElement bookstoreloginBtn { get; set; }


        //public void Goto()
        //{
        //    Pages.TopNavigation.LogIn();
        //}

    }
}
