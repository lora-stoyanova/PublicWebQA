using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressQATask_v1.Filtration
{
    class FiltrationMap
    {
        public static IWebElement FilterContainer
            {
            get
            {
                return BasePage.Driver.FindElement(By.Id("GeneralContent_C041_Col00"));
            }
        }

        public static IWebElement FilterIndustryHeader
        {
            get
            {
                return BasePage.Driver.FindElement(By.XPath("//span[@id = 'GeneralContent_C092']//label"));
            }
        }

        public static IWebElement FilterProductHeader
        {
            get
            {
                return BasePage.Driver.FindElement(By.XPath("//span[@id = 'GeneralContent_C093']//label"));
            }
        }

        public static IWebElement FilterSolutionHeader
        {
            get
            {
                return BasePage.Driver.FindElement(By.XPath("//span[@id = 'GeneralContent_C094']//label"));
            }
        }

        public static IWebElement SelectIndustryButton
        {
            get
            {
                return BasePage.Driver.FindElement(By.XPath("//span[@id = 'GeneralContent_C092']//div[contains(@class, 'Dropdown Dropdown')]"));
            }
        }

        public static IWebElement OptionTag
        {
            get
            {
                return BasePage.Driver.FindElement(By.CssSelector(".Filter--gray span"));
            }
        }

        //public static IWebElement GetListElements
        //{
        //    get
        //    {
        //        return BasePage.Driver.FindElement(By.XPath("//span[@id = 'GeneralContent_C092']//div[contains(@class, 'Dropdown-view Dropdown')]//ul[@class = "dropdownItems"]")
        //    }
        //}
    }
}
