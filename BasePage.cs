using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressQATask_v1
{
    class BasePage
    {
        private static WebDriverWait _driverWait;
        private static IWebDriver _driver;
        private static string _url = "https://www.progress.com/"; 


        public static IWebDriver Driver 
        {
            get
            {
                if (_driver == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
                }
                return _driver;
            }
            set
            {
                _driver = value;
            }
        }

        public static WebDriverWait DriverWait
        {
            get
            {
                if (_driverWait == null || _driver == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }
                return _driverWait;
            }
            private set
            {
                _driverWait = value;
            }
        }

        public static void StartBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            Driver = new ChromeDriver(@"C:\Users\loras\Downloads\driver\chromedriver_win32 (2)", options);
            DriverWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(25));
        }

        public static string URL
        {
            get
            {
                if (_url == null)
                {
                    throw new NullReferenceException("The base URL was not initialized.");
                }
                return _url;
            }
            set
            {
                _url = value;
            }
        }

        public static void GoToPage (string pageName)
        {
          
          if (string.IsNullOrEmpty(pageName))
            {
                throw new ArgumentException("The main URL cannot be null or empty.");
            }
            Driver.Navigate().GoToUrl(pageName);
        }

        public static void StopBrowser()
        {
            Driver.Quit();
            Driver = null;
            DriverWait = null;
        }
    }
}
