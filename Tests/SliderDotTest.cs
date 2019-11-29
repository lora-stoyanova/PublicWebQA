using NUnit.Framework;
using OpenQA.Selenium;
using ProgressQATask_v1.BaseUtils;
using ProgressQATask_v1.SliderDot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgressQATask_v1.Tests
{
    class SliderDotTest
    {
        [SetUp]
        public void setUp()
        {
            BasePage.StartBrowser();
        }

        [Test]
        [Property("Slider dot Tests ", 1)]
        public void SliderTestsScenario()
        {
            BasePage.Driver.Navigate().GoToUrl(BasePage.URL);
            Common.AssertDocumentStateComplete();

            SliderDotBase.MoveToSlider();
            SliderDotAsserts.VeryfyThatDotContainerIsDisplayed();
            
            SliderDotBase.PressLeftArrow_PreviousSlide();
            SliderDotAsserts.AssertThatSliderDotGoesToCorrectPosition();

            SliderDotBase.PressRightArrow_NextSlide();
            SliderDotAsserts.AssertThatSliderDotGoesToCorrectPosition();

        }

        

        [TearDown]
        public void TestCleanUp()
        {
            BasePage.StopBrowser();
        }



    }
}
