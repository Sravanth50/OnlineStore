using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
namespace OnlineStore.PageObjects
{
    public class HomePage
    {
        private IWebDriver driver;
        [FindsBy(How =How.PartialLinkText,Using ="Account")][CacheLookup]
        private IWebElement MyAccount { get; set; }
        [FindsBy(How = How.PartialLinkText, Using = "Dismiss")][CacheLookup]
        private IWebElement DisMiss { get; set; }      
        public void ClickOnMyAccount() {
            DisMiss.Click();
            MyAccount.Click();
        }
    }
}
