using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProgressQATask_v1.BaseUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressQATask_v1.BaseUtils
{
    class CommonFunctions
    {
        public static string URLText()
        {
            string currentURL = Driver.Browser.Url;
            return currentURL;
        }

        public static string GetDocumentState()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Browser;
            WebDriverWait wait = new WebDriverWait(Driver.Browser, TimeSpan.FromSeconds(25));
            string DocState = js.ExecuteScript("return document.readyState").ToString();
            return DocState;
        }

        public static string GetElementText(IWebElement Element, string Locator)
        {
            Element = Driver.Browser.FindElement(By.XPath(Locator));
            return Element.GetAttribute("innerHTML");
        }
    }
}
