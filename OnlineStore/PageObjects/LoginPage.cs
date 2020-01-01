using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.TestDataAccess;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OnlineStore.Extensions;
namespace OnlineStore.PageObjects
{
    public class LoginPage
    {
        IWebDriver driver;
        [FindsBy(How = How.Id, Using = "username")][CacheLookup]
        private IWebElement userName { get; set; }
        [FindsBy(How = How.Id, Using = "password")][CacheLookup]
        private IWebElement password { get; set; }
        [FindsBy(How = How.Name, Using = "login")][CacheLookup]
        private IWebElement loginButton { get; set; }
        
        public void loginToApplication(string testName) {
            var userData = ExcelDataAccess.GetTestData(testName);
            userName.EnterText(userData.UserName,"userName");
            password.EnterText(userData.password,"password");
            loginButton.Submit();
        }
    }
}
