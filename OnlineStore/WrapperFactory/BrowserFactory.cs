using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.WrapperFactory
{
    class BrowserFactory
    {
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string,IWebDriver>();
        private static IWebDriver driver;
        public  static string downloadPath= "C:\\Users\\sravanth\\Documents\\sravanth\\phonegap";
        public static IWebDriver Driver
        {
            get
            {
                return driver;
            }
            private set
            {
                driver = value;
            }
        }
        public static void InitBrowser(string browserName) {
            switch (browserName) {
                case "Firefox":
                    if (Driver==null)
                    {
                        driver = new FirefoxDriver();
                        Drivers.Add("Firefox",Driver);
                    }
                    break;
                case "Chrome":
                    if (Driver==null)
                    {
                        System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", "C:/Users/sravanth/Downloads/chromedriver_win32_1/chromedriver.exe");
                        Dictionary<string, object> chromePrefs = new Dictionary<string, object>();
                        chromePrefs.Add("profile.default_content_settings.popups",0);
                        chromePrefs.Add("download.default_directory", downloadPath);
                        ChromeOptions options = new ChromeOptions();
                        options.AddUserProfilePreference("profile.default_content_settings.popups", 0);
                        options.AddUserProfilePreference("download.default_directory", downloadPath);
                        options.AddArguments("--disable-notifications");
                        driver = new ChromeDriver("C:/Users/sravanth/Downloads/chromedriver_win32_1/", options);
                        Drivers.Add("Chrome",Driver);
                    }
                    break;
                case "IE":
                    if (Driver == null)
                    {
                        driver = new InternetExplorerDriver();
                        Drivers.Add("IE", Driver);
                    }
                    break;
            }
        }
        public static void LoadApplication(string url)
        {
            driver.Url = url;
        }
        public static void CloseAllDrivers()
        {
            foreach (var key in Drivers.Keys) {
                //Drivers[key].Close();
                Drivers[key].Quit();
            }
        }
    }       
}
