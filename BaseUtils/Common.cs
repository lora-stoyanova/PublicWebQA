using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    class Common
    {
        public static string URLText()
        {
            string currentURL = BasePage.Driver.Url;
            return currentURL;
        }

        public static string GetDocumentState()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)BasePage.Driver;
            WebDriverWait wait = new WebDriverWait(BasePage.Driver, TimeSpan.FromSeconds(25));
            string DocState = js.ExecuteScript("return document.readyState").ToString();
            return DocState;
        }

        public static string GetElementText(IWebElement Element, string Locator)
        {
            Element = BasePage.Driver.FindElement(By.XPath(Locator));
            return Element.GetAttribute("innerHTML");
        }

        public static void AssertDocumentStateComplete()
        {
            string txt = Common.GetDocumentState();
            Assert.IsTrue(txt.Contains("complete"));
        }
    }
}
