using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressQATask_v1.SliderDot
{
    class SliderDotMap
    {
        public static IWebElement MainContainer
        {
            get
            {
                return BasePage.Driver.FindElement(By.Id("GeneralContent_C829_Col00"));
            }
        }

        public static IWebElement DotContainar
        {
            get
            {
                return BasePage.Driver.FindElement(By.XPath("//div[@id = 'GeneralContent_C829_Col00']//div[contains(@class, 'Slider-dotContainer')]"));
            }
        }

        public static IWebElement LeftArrow
        {
            get
            {
                return BasePage.Driver.FindElement(By.XPath("//div[@id = 'GeneralContent_C830_Col00']//a[contains(@class, 'arrow-l') ]"));
            }
        }
        public static IWebElement RightArrow
        {
            get
            {
                return BasePage.Driver.FindElement(By.XPath("//div[@id = 'GeneralContent_C830_Col00']//a[contains(@class, 'arrow-r') ]"));
            }
        }
    }
}
