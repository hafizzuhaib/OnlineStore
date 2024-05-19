using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Pages
{
    public class RegisterPage
    {
        [FindsBy(How =How.Id, Using = ".firstname")]
        public IWebElement firstName { get; set; }

        [FindsBy(How = How.Id, Using = ".lastname")]
        public IWebElement lastName { get; set; }

        [FindsBy(How = How.Id, Using = ".userName")]
        public IWebElement emailAddress { get; set;}

        [FindsBy(How = How.Id, Using = ".password")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id=\"recaptcha-anchor\"]/div[1]")]
        public IWebElement checkBox { get; set;}

        [FindsBy(How = How.Id, Using = ".register")]
        public IWebElement regButton { get; set; }     

    }
}
