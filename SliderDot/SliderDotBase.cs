using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgressQATask_v1.SliderDot
{
    class SliderDotBase
    {
        internal static void PressLeftArrow_PreviousSlide()
        {
            SliderDotMap.LeftArrow.Click();
        }

        internal static void PressRightArrow_NextSlide()
        {
            SliderDotMap.RightArrow.Click();
        }

        public static void MoveToSlider()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)BasePage.Driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", SliderDotMap.MainContainer);
            Thread.Sleep(500);
        }
    }
}
