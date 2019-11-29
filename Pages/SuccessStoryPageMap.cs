using OpenQA.Selenium;
using ProgressQATask_v1.BaseUtils;
using System.Collections.Generic;

namespace ProgressQATask_v1.Pages
{
    class SuccessStoryPageMap
    {
        public static IWebElement GetGeneralContent
        {
            get
            {
                return BasePage.Driver.FindElement(By.Id("GeneralContent_ctl00_ctl00_ctl00_detailContainer"));
            }
        }

        public static IWebElement StoryHeader
        {
            get
            {
                return BasePage.Driver.FindElement(By.XPath("//h2[@class = '-fw5 -mb0']"));
            }
        }
    }
}

