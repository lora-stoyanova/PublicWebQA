
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressQATask_v1.SliderDot
{
    class SliderDotAsserts
    {
        internal static void VeryfyThatDotContainerIsDisplayed()
        {
            Assert.True(SliderDotMap.DotContainar.Displayed, "Slider dot is not displayed on page.");
            Assert.True(SliderDotMap.MainContainer.Displayed, "Slider is not displayed on page.");
        }

        internal static void AssertThatSliderDotGoesToCorrectPosition()
        {
            Assert.True(SliderDotMap.DotContainar.Displayed, "Slider is not displayed on page.");
            // to do validation of class Slider-dot js-Slider-dot--0 -dib -mt3 -ml1 -mr1 - where 'active' is parsed of dot elements, based on arrow action
        }
    }
}
