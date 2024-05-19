// Ignore Spelling: Online

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Pages;
using SeleniumExtras.PageObjects;

namespace OnlineStore
{
    [TestFixture]
    public  class Browser
    {

        public static string baseUrl = "https://demoqa.com/";
        public static IWebDriver webDriver = new ChromeDriver();

        public static void Initialize()
        {
            Goto("");
        }


        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = baseUrl + url;
        }


        public static void Close()
        {
            webDriver.Close();
        }

    }
}
