using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras;
using OpenQA.Selenium.Support.UI;
namespace OnlineStore.Extensions
{
    public static class ElementExtensions
    {
        public static void EnterText(this IWebElement element,string text,string elementName)
        {
            element.Clear();
            element.SendKeys(text);
        }
        public static bool isDisplayed(this IWebElement element,string elementName)
        {
            bool result;
            try
            {
                result = element.Displayed;
            }
            catch (Exception){
                result = false;

            }
            return result;
        }
        public static void SelectByText(this IWebElement element,string text,string elementName) {
           SelectElement oSelect = new SelectElement(element);
            oSelect.SelectByText(text);
        }
        public static void SelectByIndex(this IWebElement element,int index,string elementName) {
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByIndex(index);
;        }
        public static void SelectByValue(this IWebElement element,string value,string elementName) {
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByValue(value);
        }

    }
}
