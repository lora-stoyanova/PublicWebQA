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

        public static void VerifyURLTextContainsSrt(string text)
        {
            string txt = Common.URLText();
            Assert.IsTrue(txt.Contains(text));
        }

        public static IWebElement Header
        {
            get
            {
                return BasePage.Driver.FindElement(By.ClassName("PRGS-Nav-title"));
            }
        }

        public static IWebElement Footer
        {
            get
            {
                return BasePage.Driver.FindElement(By.ClassName("PRGS-Footer-copyright"));
            }
        }

        internal static void AssertPageHeaderTextIsDisplayed(string expectedHeaderText)
        {
            string actualHaderText = Common.Header.Text;
            Assert.AreEqual(expectedHeaderText, actualHaderText, "Header of Customers page is not displayed properly. Expected: " + expectedHeaderText + "Actual: " + actualHaderText);
        }

        internal static void AssertPageFooterIsDisplayed(string expectedFooterText)
        {
            string actualFooterText = Common.Footer.Text.Trim();
            Assert.AreEqual(expectedFooterText, actualFooterText, "Footer of Customers page is not displayed properly. \n Expected: " + expectedFooterText + " \n Actual: " + actualFooterText);
        }
    }
}
