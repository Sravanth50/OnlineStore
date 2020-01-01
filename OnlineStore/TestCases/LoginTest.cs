using NUnit.Framework;
using OnlineStore.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using OnlineStore.WrapperFactory;
using OpenQA.Selenium.Support.UI;

using System.Net;
using System.Net.Http;
using SeleniumExtras;
using OpenQA.Selenium.Interactions;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.ObjectModel;

namespace OnlineStore.TestCases
{
    class LoginTest
    {
        [Test]
         public void Test()
         {
            BrowserFactory.InitBrowser("Chrome");
            //BrowserFactory.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromMilliseconds(10000);
            //BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["TestURL"]);
            BrowserFactory.LoadApplication("http://the-internet.herokuapp.com/tables");
            Console.WriteLine(BrowserFactory.Driver.CurrentWindowHandle);
            
            //BrowserFactory.Driver.SwitchTo().Frame("mce_0_ifr");
            //BrowserFactory.Driver.FindElement(By.Id("//h5[text()='name: user2']/following::a[contains(@href,'2')]")).SendKeys("Rocking");
            //BrowserFactory.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
            //IWebElement Element = BrowserFactory.Driver.FindElement(By.LinkText("Linux"));

            //IJavaScriptExecutor js = (IJavaScriptExecutor)BrowserFactory.Driver;
            
            /*Actions actions = new Actions(BrowserFactory.Driver);
            actions.MoveToElement(BrowserFactory.Driver.FindElement(By.XPath("//*[contains(text(),'Enabled')]"))).Build();
            actions.Perform();
            actions.MoveToElement(BrowserFactory.Driver.FindElement(By.XPath("//*[contains(text(),'Downloads')]"))).Build();
            actions.Perform();
            actions.MoveToElement(BrowserFactory.Driver.FindElement(By.XPath("//*[contains(text(),'Downloads')]"))).Build();
            actions.Perform();*/
            
            IList<IWebElement> rowWebElements = new List<IWebElement>();
            rowWebElements = BrowserFactory.Driver.FindElements(By.XPath("//table[@id='table1']//tr"));
            List<string> firstNameValidation = new List<string>();
            for (int i=0;i< rowWebElements.Count;i++) {
                IList<IWebElement> columnWebElements = rowWebElements[i].FindElements(By.TagName("td"));
                for (int j=0;j<columnWebElements.Count;j++) {
                    if (j == 1) {
                        firstNameValidation.Add(columnWebElements[j].Text);
                    }
                }
            }
            firstNameValidation.Sort();
            BrowserFactory.Driver.FindElement(By.XPath("//table[@id='table1']//th[2]")).Click();
            IList<IWebElement> sortedRowWebElements = new List<IWebElement>();
            sortedRowWebElements = BrowserFactory.Driver.FindElements(By.XPath("//table[@id='table1']//tr"));
            List<string> sortedFirstNameValidation = new List<string>();
            for (int i = 0; i < sortedRowWebElements.Count; i++)
            {
                IList<IWebElement> columnWebElements = sortedRowWebElements[i].FindElements(By.TagName("td"));
                for (int j = 0; j < columnWebElements.Count; j++)
                {
                    if (j == 1)
                    {
                        sortedFirstNameValidation.Add(columnWebElements[j].Text);
                    }
                }
            }
            int l = 0;
            foreach (string a in firstNameValidation) {
                if (sortedFirstNameValidation[l].Equals(a))
                {
                    Console.WriteLine("looks good");
                }
                else {
                    Console.WriteLine(a+"-"+sortedFirstNameValidation[l]);
                }
                l++;
            }
            /*
            String parentWindow = BrowserFactory.Driver.CurrentWindowHandle;
            ReadOnlyCollection<string> windowHandles = BrowserFactory.Driver.WindowHandles;
            Console.WriteLine(windowHandles.Count);
            BrowserFactory.Driver.SwitchTo().Window(windowHandles[1]);
            BrowserFactory.Driver.FindElement(By.XPath("//h3[contains(text(),'New')]"));
            BrowserFactory.Driver.SwitchTo().DefaultContent();
            Console.WriteLine(BrowserFactory.Driver.CurrentWindowHandle);
            BrowserFactory.Driver.FindElement(By.XPath("//a[contains(text(),'Click')]")).Click();
            */
            //js.ExecuteScript("arguments[0].scrollIntoView();",Element);
            //.SendKeys("chitedsravanth");
            //BrowserFactory.Driver.FindElement(By.Id("file-upload")).SendKeys(BrowserFactory.downloadPath+"//logo.png");
            // ;
            //Actions actions = new Actions(BrowserFactory.Driver);
            //actions.MoveToElement(BrowserFactory.Driver.FindElement(By.XPath("//h5[text()='name: user2']//parent::div//preceding-sibling::img"))).Build();
            //actions.Perform();
            //BrowserFactory.Driver.FindElement(By.XPath("//h5[text()='name: user2']//parent::div//following-sibling::a")).Click();
            //.SendKeys("Bobbyz@53");
            //BrowserFactory.Driver.FindElement(By.Id("file-submit")).Click();

            /* WebDriverWait webDriverWait = new WebDriverWait(BrowserFactory.Driver, TimeSpan.FromMilliseconds(5000));
             webDriverWait.PollingInterval = TimeSpan.FromMilliseconds(50);
             Func<IWebDriver, IWebElement> webElement = new Func<IWebDriver, IWebElement>(
                 (IWebDriver Web)=>
                 {
                     Console.WriteLine("Waiting for the color to change");
                     IWebElement weElement = Web.FindElement(By.Id("colorVar"));
                     if (weElement.GetAttribute("style").Contains("red")) {
                         return weElement;
                     }
                     return null; ;
                 }
                 );            
             webDriverWait.Until(ExpectedConditions.ElementToBeClickable(webDriverWait.Until(webElement)));
             */
            //Page.Home.ClickOnMyAccount();
            //homePage.ClickOnMyAccount();
            //var loginPage = new LoginPage(BrowserFactory.Driver);
            //loginPage.loginToApplication("LoginTest");
            //Page.Login.loginToApplication("LoginTest");
            /// Actions action = new Actions(BrowserFactory.Driver);
            Cursor.Position = new Point(0, 0);
            //SelectElement selectElement = new SelectElement(BrowserFactory.Driver.FindElement(By.Id("dropdown")));
            //selectElement.SelectByText("Option 1");
            //IList < IWebElement > brokenList= new List<IWebElement>();    
            /*  brokenList = BrowserFactory.Driver.FindElements(By.XPath("div[@id='hot-spot']"));
              foreach (IWebElement webElement in brokenList) {
                  //   ValidateImageAsync(webElement);
                  if (webElement.Selected) {

                  }
                  else{
                      webElement.Click();
                  }
                  System.Console.WriteLine(webElement.Selected);
              }*/
           // action.DragAndDrop(BrowserFactory.Driver.FindElement(By.Id("draggable")), BrowserFactory.Driver.FindElement(By.Id("droppable"))).Build().Perform();
            //IAlert alert = BrowserFactory.Driver.SwitchTo().Alert();
            //alert.Accept();
            //BrowserFactory.Driver.FindElement(By.CssSelector("button.added-manually[onclick='deleteElement()']")).Click();
            //System.Console.WriteLine(DateTime.Now.ToString()+"Next Line is implict wait");
            //BrowserFactory.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(10000);
            //BrowserFactory.Driver.FindElement(By.XPath("//button[text()='Start']")).Click();
            //System.Console.WriteLine(DateTime.Now.ToString() + "Next Line is implict wait");
            //BrowserFactory.Driver.FindElements(By.XPath("//h4[text()='Hello World!']"));
            //Console.WriteLine(DateTime.Now.ToString()+"Currenttime");
            //BrowserFactory.CloseAllDrivers();
        }
        //public async Task ValidateImageAsync(IWebElement webElement) {
        //    HttpClient httpClient = new HttpClient();
        //    var result = await httpClient.GetAsync(webElement.GetAttribute("src"));
        //    System.Console.WriteLine(result.ToString());
        //}

     }     
 }
