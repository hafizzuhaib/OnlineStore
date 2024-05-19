using NUnit.Framework;
using OnlineStore.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    [TestFixture]
    public class TestBase
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/";
            

            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.bookStoreLink.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            var bookspage = new BooksPage();
            PageFactory.InitElements(driver, bookspage);
            bookspage.bookstoreloginBtn.Click();

            var loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.UserName.SendKeys("TestUser_1");
            loginPage.Password.SendKeys("Test@123");
            loginPage.loginBtn.Submit();

            driver.Close();
        }
       

    }
}
